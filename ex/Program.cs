using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Le programme doit permettre de récupérer une couleur de feu tricolore (officiellement par un
              capteur, mais ce sera ici sous forme de saisie de R pour rouge, O pour orange et V pour vert) et
              d'afficher l'ordre qui doit être exécuté : "s'arrêter", "ralentir", "passer". La saisie de la couleur
              doit être contrôlée */

            char CouleurFeu;

            do
            {
                Console.WriteLine("choix de la couleur de feu tricolore = R pour rouge, O pour orange et V pour vert : ");
                CouleurFeu = Console.ReadKey().KeyChar;
            } while (CouleurFeu != 'V' && CouleurFeu != 'O' && CouleurFeu != 'R');


            switch (CouleurFeu)
            {
                case 'V':
                    Console.WriteLine("passer");
                    Console.ReadLine();
                    break;

                case 'O':
                    Console.WriteLine("ralentir");
                    Console.ReadLine();
                    break;

                default:
                    Console.WriteLine("s'arrêter");
                    Console.ReadLine();
                    break;
            }

        }   
    }
}
