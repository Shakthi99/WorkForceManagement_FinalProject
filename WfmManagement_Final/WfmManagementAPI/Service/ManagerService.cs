using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WfmManagementAPI.Interface;
using WfmManagementAPI.Models;

namespace WfmManagementAPI.Service
{
    public class ManagerService :IManagerService
    {
        private readonly LoginRepository loginRepository;
        private readonly ManagerRepository managerRepository;
        private readonly WfmMemberRepository wfmMemberRepository;
        public ManagerService()
        {
            loginRepository = new LoginRepository();
            managerRepository = new ManagerRepository();
            wfmMemberRepository = new WfmMemberRepository();
        }
        public List<UserDetails> GetUserForLogin(LoginCriteria loginCriteria)
        {
            List<UserDetails> detail = new List<UserDetails>();
            detail = loginRepository.GetUserForLogin(loginCriteria);
            return detail;
        }

        public List<EmployeeDetails> GetDetailsForManagerPage()
        {
            List<EmployeeDetails> detail = new List<EmployeeDetails>();
            detail = managerRepository.GetDetailsForManagerPage();
            return detail;
        }

        public void LockStatusUpdateForManager(UpdateApprovalCriteria updateApprovalCriteria)
        {
            managerRepository.LockStatusUpdateForManager(updateApprovalCriteria);
        }

        public List<WfmMemberApprovalDetail> GetDetailsForWfmMemberPage(string UserName)
        {
            List<WfmMemberApprovalDetail> detail = new List<WfmMemberApprovalDetail>();
            detail = wfmMemberRepository.GetDetailsForWfmMemberPage(UserName);
            return detail;
        }

        public void LockStatusUpdateForWfmMember(UpdateApprovalCriteria updateApprovalCriteria)
        {
            wfmMemberRepository.LockStatusUpdateForWfmMember(updateApprovalCriteria);
        }
    }
}

