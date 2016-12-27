using System.ComponentModel.DataAnnotations;

namespace BloodBankProject.Web.ViewModels
{
    public class ChangePasswordViewModel
    {
        [Display(Name="كلمة المرور الحالية")]
        [Required(ErrorMessage="يجب كتابة كلمة المرور الحالية")]
        public string CurrentPassword { get; set; }

        [Display(Name="كلمة المرور الجديدة")]
        [Required(ErrorMessage="يجب كتابة كلمة المرور الجديدة")]
        public string Password { get; set; }

        [Display(Name="تأكيد كلمة المرور الجديدة")]
        [Compare("Password", ErrorMessage="كلمة المرور غير متطابقة")]
        public string PasswordConfirm { get; set; }
    }
}