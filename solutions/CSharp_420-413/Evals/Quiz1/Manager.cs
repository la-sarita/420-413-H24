using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_420_413.Evals.Quiz1
{
    class Manager : Employe
    {
        private double _bonus;
        public double Bonus
        {
            get => this._bonus = Salaire * 0.1;
            set { }
        }

        public override void AfficherInfos()
        {
            Console.WriteLine($"Nom : {Nom} - Poste {Poste} - Salaire : {Salaire} $ - Bonus : {Bonus} $");
        }
    }
}
