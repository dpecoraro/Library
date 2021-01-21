using Core.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.IServices
{
    public interface IUserService
    {
        User Get(string name, string password);
    }
}
