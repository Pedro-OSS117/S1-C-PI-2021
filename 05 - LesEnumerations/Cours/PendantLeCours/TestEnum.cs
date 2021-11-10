namespace MyEnum
{

    public enum DoigtMain
    {
        Pouce,
        Index,
        Majeur,
        Annulaire,
        Auriculaire
    }

    public enum Mois
    {
        Janvier = 1,
        Fevrier,
        Mars,
        Avril,
        Mai,
        Juin,
        Juillet,
        Aout,
        Septembre,
        Octobre,
        Novembre,
        Decembre
    }

    public enum Season
    {
        Hiver,
        Printemps,
        Ete,
        Automne
    }

    public class TestEnum
    {
        // Accessible uniquement dans la classe
        private enum MyEnum
        {

        }

        public int maPropriete = 1;

        public void MyFunction()
        {

        }

        public static int maVariableStatic = 1;

        public static void MyFunctionStatic()
        {

        }
    }
}