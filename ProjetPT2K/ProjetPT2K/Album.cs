using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetPT2K
{
    public class Albums : ALBUMS
    {
        }
        public int CODE_ALBUM { get; set; }
        public Nullable<int> CODE_EDITEUR { get; set; }
        public Nullable<int> CODE_GENRE { get; set; }
        public string TITRE_ALBUM { get; set; }
        public Nullable<int> ANNÉE_ALBUM { get; set; }
        public decimal PRIX_ALBUM { get; set; }
        public string ALLÉE_ALBUM { get; set; }
        public int CASIER_ALBUM { get; set; }
        public byte[] POCHETTE { get; set; }

        public virtual EDITEURS EDITEURS { get; set; }
        public virtual GENRES GENRES { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EMPRUNTER> EMPRUNTER { get; set; }

    }
}
