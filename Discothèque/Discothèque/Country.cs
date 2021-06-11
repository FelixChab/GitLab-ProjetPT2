using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discotèque
{
    /// <summary>
    /// Class representing a country in the database.
    /// </summary>
    public partial class PAYS
    {
        /// <summary>
        /// Return the string representation of the country.
        /// </summary>
        /// <returns> a string </returns>
        public override String ToString()
        {
            return this.NOM_PAYS.Trim();
        }
    }
}
