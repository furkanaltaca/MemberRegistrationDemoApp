using MemberRegistration.Business.Abstract;
using MemberRegistration.Business.ServiceAdapters.KpsService;
using MemberRegistration.Business.ValidationRules.FluentValidation;
using MemberRegistration.DataAccess.Abstract;
using MemberRegistration.Entities.Concrete;
using DevFramework.Core.Aspects.PostSharp.ValidationAspects;
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

        [FluentValidationAspect(typeof(MemberValidator))]
        public Member Add(Member member)
        {
            CheckIfMemberExists(member);
            CheckIfUserValidFromKps(member);

            return _memberDal.Add(member);
        }

        private void CheckIfUserValidFromKps(Member member)
        {
            if (_kpsService.ValidateUser(member) == false)
            {
                throw new Exception("Not a valid user.");
            }
        }

        private void CheckIfMemberExists(Member member)
        {
            if (_memberDal.Get(m => m.TcNo == member.TcNo) != null)
            {
                throw new Exception("User already exists.");
            }
        }

        public List<Member> GetAll()
        {
            return _memberDal.GetAll();
        }
    }
}
