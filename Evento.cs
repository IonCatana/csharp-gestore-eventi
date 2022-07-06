using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_gestore_eventi
{
    internal class Evento
    {
        private string titoloEvento; //lettura e scrittura
        private DateTime dataEvento; //lettura e scrittura
        private int MaxCapienza; //lettura
        private int nPostiPrenotati; //lettura

        // --- Getter & Setter ---
        private void SetTitoloEvento(string titolo)
        {
            if (titolo == null)
            {
                throw new ArgumentNullException(nameof(titolo));
            }
            this.titoloEvento = titolo;
        }
        public string GetTitoloEvento()
        {
            return this.titoloEvento;
        }
        public void SetDataEvento(DateTime data)
        {
            if (data < DateTime.Now)
            {
                throw new InvalidTimeZoneException(nameof(data));
            }
            this.dataEvento = data;
        }
        public DateTime GetDataEvento()
        {
            return this.dataEvento;
        }
        private void SetMaxCapienza(int maxCapienza)
        {
            if (maxCapienza < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(maxCapienza));
            }
            else
            {
                this.MaxCapienza = maxCapienza;
            }
        }
        public int GetMaxCapienza()
        {
            return this.MaxCapienza;
        }
        public int GetNPostiPrenotati()
        {
            return this.nPostiPrenotati;
        }

    }

}
