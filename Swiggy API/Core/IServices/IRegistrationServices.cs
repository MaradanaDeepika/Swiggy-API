using Swiggy_API.DTO;
using Swiggy_API.Model;

namespace Swiggy_API.Core.IServices
{
    public interface IRegistrationServices
    {
        List<UserModel> GetUsers();                 //List of Users.
        string SignIn(LogInDTO loginDTO);           //User with already existed.
        string SignUp(UserModel userModels);        // New User.
        //string SignOut(UserModel userModels);     //User LogOut.
        string PutUser(int UserId, UserModel userModels);      // If User Wants to change Email or PassWord.
    }
}
