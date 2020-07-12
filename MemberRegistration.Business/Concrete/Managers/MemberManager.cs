using MemberRegistration.Business.Abstract;
using MemberRegistration.Business.ServiceAdapters.KpsService;
using MemberRegistration.DataAccess.Abstract;
using MemberRegistration.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberRegistration.Business.Concrete.Managers
{
    public class MemberManager : IMemberService
    {
        private IMemberDal _memberDal;
        private IKpsService _kpsService;
        public MemberManager(IMemberDal memberDal, IKpsService kpsService)
        {
            _memberDal = memberDal;
            _kpsService = kpsService;
        }

        public Member Add(Member member)
        {
            if (_kpsService.ValidateUser(member) == false)
            {
                throw new Exception("Not a valid user");
            }

            return _memberDal.Add(member);
        }

        public List<Member> GetAll()
        {
            return _memberDal.GetAll();
        }
    }
}
