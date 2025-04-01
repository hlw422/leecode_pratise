using CAPWebAPI.Model;
using FluentValidation;
namespace CAPWebAPI.validate;


public class UserModelValidator : AbstractValidator<UserModel>
{
    public UserModelValidator()
    {
        RuleFor(x => x.UserName)
            .NotEmpty().WithMessage("用户名不能为空");

        RuleFor(x => x.Password)
            .NotEmpty().WithMessage("密码不能为空")
            .Length(6, 100).WithMessage("密码长度必须在6到100个字符之间");
    }
}
