using Models;

namespace DNPAssignment1.Data {
public interface IUserService {
    User ValidateUser(string userName, string password);
}
}