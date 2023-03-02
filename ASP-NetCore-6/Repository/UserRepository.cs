using ASP_NetCore_6.Config;
using ASP_NetCore_6.Dto;
using ASP_NetCore_6.Entity;
using Quickwire.Attributes;

namespace ASP_NetCore_6.Repository;
[RegisterService, InjectAllInitOnlyProperties]
public class UserRepository
{
    private ApplicationDbContext _applicationDbContext { get; init; }
    public User? findbyId(long Id) => _applicationDbContext.NET_USER.FirstOrDefault(u => u.Id == Id);
    public User? findbyEmail(string email) => _applicationDbContext.NET_USER.FirstOrDefault(u => u.email == email);

    public User? findByEmailAndPassword(string email, string password) =>
        _applicationDbContext.NET_USER.FirstOrDefault(u => u.email == email && u.password == password);
    public User persist(User user)
    {
        _applicationDbContext.NET_USER.Add(user);
        _applicationDbContext.SaveChanges();
        return user;
    } 
}

// init = dependency injection material
// ? meaning we are accepting it can be nullable 
//First Order Default = FirstOrDefault