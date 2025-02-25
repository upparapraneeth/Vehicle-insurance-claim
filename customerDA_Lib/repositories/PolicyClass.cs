using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using customerDA_Lib.models;

namespace customerDA_Lib.repositories
{
    public class PolicyClass : IRepositoryPolicy<Policy>
    {
        public bool createPolicy(Policy entity)
        {
            throw new NotImplementedException();
        }

        public List<Policy> getPolicyDetails()
        {
            throw new NotImplementedException();
        }

        public bool renewPolicy(Policy entity)
        {
            throw new NotImplementedException();
        }
    }
}
