using MemberRegistration.Business.Abstract;
using MemberRegistration.Business.Concrete.Managers;
using MemberRegistration.DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberRegistration.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            IMemberService _memberService = new MemberManager(new EfMemberDal());
            var members = _memberService.GetAll();
            foreach (var member in members)
            {
                Console.WriteLine(member.FirstName);
            }
            Console.Read();
        }
    }
}
