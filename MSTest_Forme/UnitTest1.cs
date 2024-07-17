using formes.Forms.Carre;

namespace MSTest_Forme
{
    /// <summary>
    /// on est obliger de ecrir avent la class [TestClass]
    /// et avant la methode 
    /// [TestMethod]
    /// </summary>
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var c = new Carre { Longeur = 10 };
            var r = new Rectangle { Longeur = 10 , Largeur = 5 };
            var u = new Cube { Longeur= 10 };
            ///tester la longeur de la classe carre 

            var c2 = new Carre { Longeur = -10 }; 

            /// assert c'est une class predefinis dans le "MStest"   qui as  des methode static
            ///
            /// par exemple on va ituliser la methode are equale que dans son premier
            /// parametre on vas introduire la valeur attendue de notre methode a teste superficie du care 
            /// a une longueur de 10 ca superficie est de 100 et le deuxieme paramettre ca va etre la methode a tester cest la methode superficier du carre
            ///
            Assert.AreEqual(100, c.Superficie());
            Assert.AreEqual(50, r.Superficie());
            Assert.AreEqual(600, u.Superficie());   
            Assert.AreEqual(100, c2.Superficie());
        }
    }
}
///
/// pour executer les teste 1er methode clicke droit executer test
/// 
///