using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace oblig_4
{
    internal class Bil
    {
        //        Du skal lage et program som bruker en klasse Bil.
        //• Implementer klassen Bil skal inneholde tre private datamedlemmer: biltype
        //(tekst), eier, (tekst – som inneholder både fornavn og etternavn) og skilt(her må
        //du velge datatypen selv). Datamedlemmet skilt skal inneholde to bokstaver og fem
        //siffer.
        //Fakultet for ingeniør- og naturvitskap
        //Institutt for elektrofag
        //• Opprett en samling av biler(velg passende Collections-datatype) og fyll samlingen med
        //minst ti objekter av datatypen Bil.
        //• Vis (skriv til skjerm) informasjon om alle elementer i samlingen i «skilt»-rekkefølge
        //(skiltverdi AB99999 bør skrives ut før AC00000 og tilsvarende).
        //• Programmet skal til slutt finne og skrive ut eieren som har det lengste navnet(eller
        //eiere om det er flere som har like lange navn).

       // private string bil_type;
       // private string eier;
       // private string skilt_nr;

       // // datamedlem for biltype
       //public string bil_type
       // {
       //     get { return bil_type; }
       //     set { bil_type = value; }
       // }


       // // datamadlem for eier

       // public string Eier
       // {
       //     get { return eier; }
       //     set { eier = value; }
       // }


       // // datamedlem for skiltnr

       // public string Skilt_Nr
       // {
       //     get { return skilt_nr; }
       //     set { skilt_nr = value; }
       // }

       // // Konstruktør
       // public Bil(string biltype, string eier, string skilt_nr)
       // {
       //     this.bil_type = bil_type;
       //     this.eier = eier;
       //     this.skilt_nr = skilt_nr;
       // }


        // det under her erstatter alt over pga det over var vist veldig gammeldags og lite i bruk lenger

        // Auto-properties
        public string Bil_Type { get; set; }
        public string Eier { get; set; }
        public string Skilt_Nr { get; set; }

        // Konstruktør
        public Bil(string bilType, string eierNavn, string skiltnr)
        {
            this.Bil_Type = bilType;
            this.Eier = eierNavn;
            this.Skilt_Nr = skiltnr;
        }

        //collection av biler 





    }
}
