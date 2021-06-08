using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ProjetPT2K;
using System.Collections.Generic;

namespace UnitTestProjetPT2K
{
    [TestClass]
    public class DatabaseUT
    {
        [TestMethod]
        public void RestoreCleanState()
        {
            MusiquePT2_KEntities connection = Database.GetInstance().GetConnection();
            connection.Database.ExecuteSqlCommand("DELETE FROM ABONNÉS");
            connection.Database.ExecuteSqlCommand("TRUNCATE TABLE EMPRUNTER");
            Assert.IsTrue(true);
        }
    }
}