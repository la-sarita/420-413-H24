using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_420_413.Evals.Quiz1
{
    class Employe
    {
        public string Nom {get; set; }
        public string Poste { get; set; }
        public double Salaire { get; set; }

        public virtual void AfficherInfos()
        {
            Console.WriteLine($"Nom : {Nom} - Poste {Poste} - Salaire : {Salaire} $");
        }
    }
}
