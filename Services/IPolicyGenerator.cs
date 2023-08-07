using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestRatingNew.Entity;

namespace TestRatingNew.Services
{
    public interface IPolicyGenerator
    {
        dynamic PolicyCreate();
    }
}
