using ASP_NetCore_6.Converter;
using ASP_NetCore_6.Dto;
using ASP_NetCore_6.Entity;
using ASP_NetCore_6.Repository;
using Quickwire.Attributes;

namespace ASP_NetCore_6.Service;

[RegisterService, InjectAllInitOnlyProperties]
public class UserService
{
    private UserRepository _userRepository { get; init; }

    public User? findbyId(long Id) => _userRepository.findbyId(Id);

    public User? findByEmailAndPassword(string email, string password) =>
        _userRepository.findByEmailAndPassword(email, password);
    
    public User createFromDto(UserDto userDto)
    {
        var user = UserDtoConverter.convert(userDto);
        if (!validatePassword(user.password, userDto.rePassword)||!isEmailValid(userDto.email))
        {
            return null;
        }
        validateUserName(user);
        return user;
    }

    private bool validatePassword(string password,string rePassword) =>
        (password.Length >= 12 && password.Length <= 35) && (password == rePassword);
    

    private void validateUserName(User user)
    {
        if (user.username == null)
        {
            user.username = "HelloSunShine!";
        }
    }

    private bool isEmailValid(string email) => _userRepository.findbyEmail(email) != null;

}

// add endpoint  and make a login page