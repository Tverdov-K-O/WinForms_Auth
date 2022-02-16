using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinForms_Auth.Data.Entities;

namespace WinForms_Auth.Store
{
    /// <summary>
    /// Класс для сохранения данных о текущем пользователе
    /// в дальнейшем тут будут хранится данные о клбчах сессии
    /// </summary>
    public class AuthStore
    {
        public bool hasRole(string roleName)
        {
            if (currentUser.Role.Name == roleName)
                return true;
            if (currentUser.Roles.Any(r => r.Name == roleName)) return true;
            return false;
        }
        public bool isRole(string roleName)
        {
            if (currentUser.Role.Name == roleName) return true;
            return false;
        }
        public bool isAdmin
        {
            get
            {
                if (currentUser.Role.Name == "Admin") 
                    return true;
                else
                    return false;
            }
            
        }

        public User currentUser { get; set; }
        public bool isLogin { get; set; } = false;
        private AuthStore() { }
        private static  AuthStore _instance;
        public static AuthStore getInstance()
        {
            if (_instance == null) _instance = new AuthStore();
            return _instance;
        }
    }
}
