﻿using FluentValidation;
using FluentValidation.Results;

public abstract class Policy 
    {
        protected PolicyType _type;
        protected bool _isValid = true;
        protected decimal _rating = 0;
        public string FullName { get; set; }
        public virtual DateTime DateOfBirth { get; set; }
        public virtual PolicyType Type { get => _type; protected set => _type = value; }
        protected abstract ValidationResult Validate();
        public  bool ValidatePolicy()
        {
            var results = Validate();
            if (!results.IsValid)
            {
                foreach (var failure in results.Errors)
                {
                    Console.WriteLine(failure.ErrorMessage);
                }
            }
            return results.IsValid;
        }
        public abstract decimal RatingCalculate();
    }

