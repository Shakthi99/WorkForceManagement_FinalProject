using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WfmManagementAPI.Models
{
    public class UpdateApprovalCriteria
    {
        public int LockId { get; set; }
        public string? RequestMessage { get; set; }
        public string? FirstName { get; set; }
        public int EmpId { get; set; }
        public string? ManagerStatus { get; set; }
        public string? ManagerComment { get; set; }
    }
}
