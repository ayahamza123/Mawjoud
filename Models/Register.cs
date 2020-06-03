using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mawjoud2.Models
{
    public class Register
    {
        public int MemberId { get; set; }
        public string FristName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Memberphoto { get; set; }
        public string Membercity { get; set; }
        public string Password { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }

    }
}