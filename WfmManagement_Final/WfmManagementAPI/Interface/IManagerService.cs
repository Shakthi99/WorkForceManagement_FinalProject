using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WfmManagementAPI.Models;

namespace WfmManagementAPI.Interface
{
   public interface IManagerService
    {
        List<UserDetails> GetUserForLogin(LoginCriteria loginCriteria);
        List<EmployeeDetails> GetDetailsForManagerPage();
        void LockStatusUpdateForManager(UpdateApprovalCriteria updateApprovalCriteria);
        List<WfmMemberApprovalDetail> GetDetailsForWfmMemberPage(string UserName);
        void LockStatusUpdateForWfmMember(UpdateApprovalCriteria updateApprovalCriteria);
    }
}
