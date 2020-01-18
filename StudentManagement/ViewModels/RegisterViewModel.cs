﻿using System.ComponentModel.DataAnnotations;

namespace StudentManagement.ViewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "邮箱地址不能为空")]
        [EmailAddress]
        [Display(Name = "邮箱地址")]
        public string Email { get; set; }

        [Required(ErrorMessage = "密码不能为空")]
        [DataType(DataType.Password)]
        [Display(Name = "密码")]
        public string Password { get; set; }

        [Required(ErrorMessage = "请再次输入密码")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "确认密码与密码不一致，请重新输入！")]
        [Display(Name = "确认密码")]
        public string ConfirmPassword { get; set; }
    }
}