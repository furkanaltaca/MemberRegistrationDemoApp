using MemberRegistration.Business.Abstract;
using MemberRegistration.Business.Concrete.Managers;
using MemberRegistration.Business.DependencyResolvers.Ninject;
using MemberRegistration.Business.ServiceAdapters.KpsService;
using MemberRegistration.DataAccess.Concrete.EntityFramework;
using MemberRegistration.Entities.Concrete;
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
            IMemberService _memberService = InstanceFactory.GetInstance<IMemberService>();

            try
            {
                _memberService.Add(new Member
                {
                    FirstName = "Furkan",
                    LastName = "Altaca",
                    DateOfBirth = new DateTime(2001, 6, 16),
                    TcNo = "46522310036",
                    Email = "deneme@gmail.com",
                });
                Console.WriteLine("Eklendi");

                var members = _memberService.GetAll();
                foreach (var member in members)
                {
                    Console.WriteLine(member.FirstName);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.Read();
        }
    }
}
