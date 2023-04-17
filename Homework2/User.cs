using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    public class User
    {
        private int _idUser;
        private string _fullNameUser;
        private int _balanceUser;

        public int IdUser
        {
            get { return _idUser; }
        }

        public string UserFullName
        {
            get { return _fullNameUser; }
        }

        public int BalanceUser
        {
            get { return _balanceUser; }
        }

        public User(int idUser, string nameUser, int balanceUser)
        {
            _idUser = idUser;
            _fullNameUser = nameUser;
            _balanceUser = balanceUser;
        }

        public void ShowUsers()
        {
            Console.WriteLine($"Id: {_idUser}\nName: {_fullNameUser}\nBalance: {_balanceUser} USD");
        }
    }
}
