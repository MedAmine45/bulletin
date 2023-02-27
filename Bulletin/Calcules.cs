using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulletin
{
    public class Calcules
    {
        public double CalculerMoyenne(double Math, double Physique, double Français  )
        {
            double moy;
            int c1 = 5; int c2 = 7;int c3 = 3;
            int total = c1 + c2 + c3;
            moy = ( Math*c1+Physique*c2 +Français*c3)/ total;


                
            return moy;
        }

        public double CalculerMoyenneMultiple(double[] matieres)
        {
            double moy;
            double sum = 0;
            for(int i = 0; i< matieres.Length; i++)
            {
                sum += matieres[i];
            }

            moy = sum/matieres.Length;



            return moy;
        }
    }
}
