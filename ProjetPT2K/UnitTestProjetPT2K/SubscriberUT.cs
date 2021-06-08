using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ProjetPT2K;

namespace UnitTestProjetPT2K
{
    [TestClass]
    public class UnitTest1
    {





        [TestMethod]
        public void CreateAccount()
        {
            MusiquePT2_KEntities connection = Database.GetInstance().GetConnection();
            Database.GetInstance().CreateAccount("prénom", "nom", 01, "testeur", "blabla");
            connection.Database.ExecuteSqlCommand("SELECT NOM_ABONNÉ FROM ABONNÉS WHERE ABONNÉS.NOM_ABONNÉ = 'nom'");
           
        }


    }
}
