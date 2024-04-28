using System;

namespace Practice2.Data.Entity
{
    public struct User
    {
        private string _username;
        private string _password;
        private DateTime? _createdAt;
        private bool _isAdmin;
        private string _apartment;

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

        public string apartment
        {
            get { return _apartment; }
            set { _apartment = value; }
        }

        public User(string username, string password, bool isAdmin, string apartment)
        {
            _username = username;
            _password = password;
            _createdAt = DateTime.Now;
            _isAdmin = isAdmin;
            _apartment = apartment;
        }

        //public void ChangePassword(string password) На курсач
        //{
        //    if (password.Length < 6)
        //    {
        //        return;
        //    }
        //    this.Password = BCrypt.HashPassword(password);
        //    return;
        //}
    }
}
