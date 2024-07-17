using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formes.Programation_Asynchronne
{
    /// <summary>
    /// une class static elle que les attribut et les methodfe static et elle ni heriter ni implémentable
    /// 
    ///la differnce entre ces methode est que le retour void concrettement return un signale (vide) 
    /// 
    /// de ce fait on vas faire une methode  avec un type retour Task qui vas dire  a notre programme excuter la methode elle meme 
    /// et de continuer l'exution de programe tiers 
    /// 
    /// le mot clé async va nous permetre de " retirer Task.Factory.StartNew(async ()" de notre method et ajouter le mot cle await 
    /// </summary>
    static class Utility
    {
        public const int PAUSE = 5000;
        public static void Afficher()
        {
            ///
            /// Thred.sleep : c'est une pause pour simuler un traitement long 
            /// cad donner un temps de pause a fin de continuer l'execution du code 
            /// 
            /// 


            Thread.Sleep(PAUSE);
            Console.WriteLine("fin d'affichage");
        }
        /// <summary>
        /// task est une class 
        /// </summary>
        /// <returns></returns>
        public static Task AfficherAsync()
        {
             //Thread.Sleep(PAUSE);

            return Task.Factory.StartNew(async () => 
            {
               // Thread.Sleep(PAUSE);
               await Task.Delay(PAUSE);
            });

        }
        /// <summary>
        /// un exemple comment ecrire une methode async sans retour void 
        /// <returns></returns>
        /// 
        public static async Task AfficheAsync2()
        {
            await Task.Delay(PAUSE);
            
            
        }


        public static double Somme(double x, double y)
        {
            Thread.Sleep(PAUSE);
            return x + y;
        }
        /// <summary>
        /// les < > dans ce cas represente un generic qui nous dire le type retour comment il vas etre 
        /// 
        /// pour que la methode comprend que c'est une methode async et peut aussi comprendre le mot clé await : qui veux dire attend 
        /// une methode async cad une methode non blocante cad elle peut laisser la suite du code s'exuter avant quelle finis de s'executer 
        /// delay c'est le delais 
        /// </summary>
        public static async Task<double> SommeAsync(double x, double y)
        {
            await Task.Delay(PAUSE);
            return  x + y;
        }
       
    }
}
