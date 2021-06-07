using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetPT2K
{
    public abstract class Account
    {

        public bool isAdministrator;
        protected MusiquePT2_KEntities Connection;

        public Account()
        {
            Database database = Database.GetInstance();
            this.Connection = database.GetConnection();
        }

    }
}
