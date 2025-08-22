using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebTRY.Models
{
    public class RegisterModel
    {
        [Required (ErrorMessage = " First name is required.")]
        [RegularExpression(@"^[a-zA-Z0-9 ]*$", ErrorMessage = " Invalid first name.")]
        public string FirstName { get; set; }

        [Required (ErrorMessage = " Last name is required.")]
        [RegularExpression(@"^[a-zA-Z0-9 ]*$", ErrorMessage = " Invalid last name.")]
        public string LastName { get; set; }

        [Required, EmailAddress(ErrorMessage = " Invalid email address.")]
        public string Email { get; set; }

        [Required, Phone(ErrorMessage = " Invalid phone number.")]
        public string Phone { get; set; }

        [Required(ErrorMessage = " Gender is required.")]
        public string Gender { get; set; }

        [Range(1, 120,ErrorMessage = " Invalid age.")]
        public int Age { get; set; }

        [Required(ErrorMessage = " University name is required.")]
        public string UnivName { get; set; }

        [Required(ErrorMessage = " Course is required.")]
        public string Course { get; set; }

        [Required(ErrorMessage = " Year level is required.")]
        public string YearLevel { get; set; }

        [Required(ErrorMessage = " Job role is required.")]
        public string Role { get; set; }

        [Required(ErrorMessage = " Assigned Department is required.")]
        public string Department { get; set; }

        [Required(ErrorMessage = " Required time is required.")]
        public int Time { get; set; }

        [Required(ErrorMessage = " Username is required.")]
        public string Username { get; set; }

        [Required(ErrorMessage = " Password is required.")]
        public int Password { get; set; }

    }
}