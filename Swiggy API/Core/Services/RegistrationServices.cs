using Microsoft.AspNetCore.DataProtection.Repositories;
using Swiggy_API.Core.IServices;
using Swiggy_API.Data;
using Swiggy_API.DTO;
using Swiggy_API.Model;

namespace Swiggy_API.Core.Services
{
    public class RegistrationServices : IRegistrationServices
    {
        private readonly SwiggyDbContext model;

        public RegistrationServices(SwiggyDbContext Model)
        {
            this.model = Model;
        }
        List<UserModel> IRegistrationServices.GetUsers()
        {
            return model.userModels.ToList();
        }

        public string SignIn(LogInDTO loginDTO)
        {
            try
            {
                var login = model.userModels.FirstOrDefault(x => x.UserName == loginDTO.UserName && x.Password == loginDTO.Password);
                if (login != null)
                {
                    return "Login Succeful";
                }
                else
                {
                    return "Login Failed";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
       public string SignUp(UserModel userModels)
        {
            try
            {
                if(userModels != null)
                {
                    model.userModels.Add(userModels);
                    model.SaveChanges();
                    return "Register Successfully.";
                }
                else
                {
                    return "Registration Failed.";
                }
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
        }

        public string PutUser(int UserId, UserModel userModels)
        {
            try
            {
                    if (userModels != null)
                    {
                        UserModel user = new UserModel();
                        var p = model.userModels.FirstOrDefault(p => p.UserId == UserId);
                        p.Email =userModels.Email;
                        p.Password =userModels.Password;
                        model.SaveChanges();
                        return "Updated Successfully";
                }
                    else
                    {
                        return "updation failed";
                    }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
