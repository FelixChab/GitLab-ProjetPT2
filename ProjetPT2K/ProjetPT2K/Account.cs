using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetPT2K
{
    public abstract class Account
    {

        public bool isAdministrator; 

        protected MusiquePT2_KEntities Connection;

        public Account()
        {
            this.Connection = Database.GetInstance().GetConnection();
        }

    }
}