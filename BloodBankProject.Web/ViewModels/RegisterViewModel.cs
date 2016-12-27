
using System.ComponentModel.DataAnnotations;
namespace BloodBankProject.Web.ViewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage="يجب كتابة اسم المستخدم")]
        [Display(Name="اسم المستخدم")]
        public string Username { get; set; }

        [Required(ErrorMessage="يجب كتابة كلمة المرور")]
        [Display(Name="كلمة المرور")]
        public string Password { get; set; }

        [Required(ErrorMessage="يجب تأكيد كلمة المرور")]
        [Display(Name="تأكيد كلمة المرور")]
        [Compare("Password", ErrorMessage="كلمة المرور غير متطابقة")]
        public string PasswordConfirm { get; set; }

        [Required(ErrorMessage="يجب كتابة البريد الالكتروني")]
        [Display(Name="البريد الالكتروني")]
        [EmailAddress(ErrorMessage = "يجب كتابة بريد الكتروني صحيح")]
        public string Email { get; set; }
    }
}