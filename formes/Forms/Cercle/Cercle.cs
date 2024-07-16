namespace formes.Forms.Cercle
{
    public class Cercle : FormeGeometrique
    {

        private int rayon;
        public int Rayon
        {
            get
            {
                return rayon;
            }
            set
            {
                rayon = Math.Abs(value);

            }
        }
        public override double Superficie()
        {
            return Math.PI * rayon * rayon;
        }

    }
}
