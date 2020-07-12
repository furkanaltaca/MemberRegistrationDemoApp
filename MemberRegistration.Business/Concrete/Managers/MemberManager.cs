using MemberRegistration.Business.Abstract;
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
        public MemberManager(IMemberDal memberDal)
        {
            _memberDal = memberDal;
        }

        public Member Add(Member member)
        {
            return _memberDal.Add(member);
        }

        public List<Member> GetAll()
        {
            return _memberDal.GetAll();
        }
    }
}
