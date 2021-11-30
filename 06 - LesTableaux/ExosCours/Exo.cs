namespace ExosCours
{
    public class Exo
    {
        public static int SearchIndexValue(int[] myTab, int myValue)
        {
            for (int i = 0; i < myTab.Length; i++)
            {
                if (myValue == myTab[i])
                {
                    return i;
                }
            }
            return -1;
        }

        public static int SearchOccurenceValue(int[] myTab, int myValue)
        {
            int result = 0;
            for (int i = 0; i < myTab.Length; i++)
            {
                if (myValue == myTab[i])
                {
                    result++;
                }
            }
            return result;
        }
    }
}