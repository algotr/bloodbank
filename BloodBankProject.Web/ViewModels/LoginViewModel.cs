using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BloodBankProject.Web.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage="يجب كتابة أسم المستخدم")]
        [Display(Name="أسم المستخدم")]
        public string Username { get; set; }

        [Required(ErrorMessage = "يجب كتابة كلمة المرور")]
        [Display(Name="كلمة المرور")]
        public string Password { get; set; }
    }
}