using MemberRegistration.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberRegistration.Business.ServiceAdapters.KpsService
{
    public class TestKpsServiceAdapter : IKpsService
    {
        public bool ValidateUser(Member member)
        {
            return true;
        }
    }
}
