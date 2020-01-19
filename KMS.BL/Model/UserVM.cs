using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMS.BL.Model
{
   public class UserVM
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PrimaryPhone { get; set; }
        public string AadhaarUrl { get; set; }
        public bool IsActive { get; set; }
        public int TakenCredit { get; set; }
    }
}
