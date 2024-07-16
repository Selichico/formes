namespace formes.Forms.Carre
{
    public class Cube : Carre
    {

        public override double Superficie()
        {
            //return Longeur * Longeur * 6;
            return base.Superficie() * 6;
        }

    }
}
