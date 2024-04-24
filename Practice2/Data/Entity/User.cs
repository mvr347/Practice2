using System;

namespace Practice2.Data.Entity
{
    using BCrypt.Net;
    public struct User
    {
        private string _username;
        private string _password;
        private DateTime? _createdAt;
        private bool _isAdmin;

        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public DateTime? CreatedAt
        {
            get { return _createdAt; }
            set { _createdAt = value; }
        }

        public bool IsAdmin
        {
            get { return _isAdmin; }
            set { _isAdmin = value; }
        }

        public User(string username, string password, bool isAdmin)
        {
            _username = username;
            _password = password;
            _createdAt = DateTime.Now;
            _isAdmin = isAdmin;
        }
        public void ChangePassword(string password)
        {
            if (password.Length < 4)
            {
                return;
            }
            this.Password = BCrypt.HashPassword(password);
            return;
        }
    }
}
