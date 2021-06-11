namespace Discotèque
{
    public abstract class Account
    {
        /// <summary>
        /// True if the considered account has administrator priviledges.
        /// </summary>
        public bool IsAdministrator { get; set; }

        /// <summary>
        /// The Database object the tests will use.
        /// </summary>
        protected Database Database = Database.GetInstance();

        /// <summary>
        /// The connection to the dabase.
        /// </summary>
        protected MusiquePT2_KEntities Connection = Database.GetInstance().GetConnection();

    }
}
