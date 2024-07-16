using System.Text.Json;

namespace formes.Forms.Carre
{
    public class Rectangle : Carre
    {


        private int largeur;

        public int Largeur
        {
            get
            {
                return largeur;
            }
            set
            {
                if (value >= 0)
                    largeur = value;
            }
        }


        public override double Superficie()
        {
            return Longeur * Largeur;
        }
        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }

    }
}
