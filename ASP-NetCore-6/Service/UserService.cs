using ASP_NetCore_6.Entity;
using ASP_NetCore_6.Repository;
using Quickwire.Attributes;

namespace ASP_NetCore_6.Service;

[RegisterService, InjectAllInitOnlyProperties]
public class UserService
{
    private UserRepository _userRepository { get; init; }

    public User? findbyId(long Id) => _userRepository.findbyId(Id);

    public User CreateUser(User user) => _userRepository.persist(user);

    public void characterCheck(User user)
    {
        if (user.password.Length >= 12 || user.password.Length <= 35)
        {
            _userRepository.persist(user);
        }
    }

}