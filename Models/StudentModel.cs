using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class StudentModel
    {
        public int SID { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Name is Required")]
        //[RegularExpression(@"^(?=.{8,20}$)(?![_.])(?!.*[_.]{2})[a-zA-Z0-9._]+(?<![_.])$", ErrorMessage = "Invalid Name")]
        public string SName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Email is Required")]
        // [RegularExpression(@"^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?(?:\.[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?)*$", ErrorMessage = "Invalid Email")]
        public string SEmail { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Address is Required")]
        public string SAddress { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Address is Required")]
        public string SGDName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Address is Required")]
        public string SGDContact { get; set; }

        public DateTime SDob { get; set; }

        public string SGender { get; set; }
    }
}
