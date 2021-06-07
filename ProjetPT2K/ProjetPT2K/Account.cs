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
        /**
         * True if the considered account has administrator priviledges.
         */
        public bool IsAdministrator { get; }

        /**
         * Return the open connection to the database.
         * 
         * @return a MusiquePT2_KEntities object
         */
        protected MusiquePT2_KEntities Connection 
        { 
            get 
            { 
                return Database.GetInstance().GetConnection(); 
            } 
        }

    }
}
