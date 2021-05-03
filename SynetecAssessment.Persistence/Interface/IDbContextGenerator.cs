using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SynetecAssessmentApi.Persistence.Interface
{
    public interface IDbContextGenerator
    {
        void SeedData();
    }
}
