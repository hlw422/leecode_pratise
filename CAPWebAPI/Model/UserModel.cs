using System.ComponentModel.DataAnnotations;
namespace CAPWebAPI.Model;

public class UserModel
{
    //[Required(ErrorMessage = "用户名不能为空")]
    public string UserName { get; set; }
    
  //  [Required(ErrorMessage = "密码不能为空")]
    //[StringLength(100, MinimumLength = 6, ErrorMessage = "密码长度必须在6到100个字符之间")]
    public string Password { get; set; }
}
