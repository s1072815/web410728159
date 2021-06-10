using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace web410728159.ViewModels
{
    public class SignUpData
    {
        [Display(Name = "姓名")]
        [Required(ErrorMessage = "請輸入姓名")]
        [MinLength(5, ErrorMessage = "請輸入5~10個字")]
        [MaxLength(5, ErrorMessage = "請輸入5~10個字")]
        public String Name { get; set; }

        [Display(Name = "帳號")]
        [Required(ErrorMessage = "請輸入帳號")]
        [EmailAddress(ErrorMessage = "請輸入正確的e-mail格式")]
        public String Account { get; set; }

        [Display(Name = "密碼")]
        [Required(ErrorMessage = "請輸入密碼")]
        [StringLength(10, MinimumLength = 5, ErrorMessage = "請輸入5~10個字")]
        public String Password { get; set; }

        public String NameMessage { get; set; }

        public String AccountMessage { get; set; }

        public String PasswordMessage { get; set; }

        public String Message { get; set; }

    }
}