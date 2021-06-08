using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetPT2K;

namespace UnitTestProjetPT2K
{
    public class UnitTest
    {
        /**
         * The Database object the tests will use.
         */
        protected Database Database = Database.GetInstance();

        /**
         * The connection to the dabase.
         */
        protected MusiquePT2_KEntities Connection = Database.GetInstance().GetConnection();

    }
}
