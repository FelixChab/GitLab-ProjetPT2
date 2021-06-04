using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetPT2K
{
    public abstract class Account
    {
        protected string Username;

        protected MusiquePT2_KEntities Connection;

        public Account(string username, string password)
        {
            this.Username = username;
            this.Connection = App.getInstance().getConnection();
        }

    }
}