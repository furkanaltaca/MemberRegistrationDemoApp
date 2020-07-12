using MemberRegistration.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberRegistration.Business.Abstract
{
    public interface IMemberService
    {
        List<Member> GetAll();
        Member Add(Member member);
    }
}
