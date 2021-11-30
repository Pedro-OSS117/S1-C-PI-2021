using System;

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

        public static int MinimumValueTableau(int[] myTab)
        {
            int minimum = myTab[0];

            for(int i = 1; i < myTab.Length; i++)
            {
                if(minimum > myTab[i])
                {
                    minimum = myTab[i];
                }
            }

            return minimum;
        }

        public static int MaximumValueTableau(int[] myTab)
        {
            int maximum = myTab[0];

            for(int i = 1; i < myTab.Length; i++)
            {
                if(maximum < myTab[i])
                {
                    maximum = myTab[i];
                }
            }

            return maximum;
        }

        public static int[] InsertVal(int[] originTab, int value)
        {
            int[] newTab = new int[originTab.Length + 1];
            for(int i = 0; i < originTab.Length; i++)
            {
                newTab[i] = originTab[i];
            }
            newTab[originTab.Length] = value;
            return newTab;
        }

        public static int[] InsertValAtIndex(int[] originTab, int value, int index)
        {
            // Verification si index demandé est non valide
            if(originTab.Length <= index)
            {
                return null;
            }

            int[] newTab = new int[originTab.Length + 1];
            // Insertion des valeurs de origin tab
            for(int i = 0; i < index; i++)
            {
                newTab[i] = originTab[i];
            }

            newTab[index] = value;   

            for(int i = index + 1; i < newTab.Length; i++)
            {
                newTab[i] = originTab[i - 1];
            }

            return newTab;
        }

        public static int[] InsertTabInTab(int[] tab1, int[] tab2, int index)
        {
            // Verification si index demandé est non valide
            if(tab1.Length < index)
            {
                index = tab1.Length - 1;
            }

            int[] newTab = new int[tab1.Length + tab2.Length];

            // Insertion des valeurs de origin tab
            for(int i = 0; i < index; i++)
            {
                newTab[i] = tab1[i];
            }

            for(int i = 0; i < tab2.Length; i++)
            {
                newTab[i + index] = tab2[i];
            }

            for(int i = index + tab2.Length; i < newTab.Length; i++)
            {
                newTab[i] = tab1[i - tab2.Length];
            }

            return newTab;
        }
        
        public static int[] CreateRandomIntTab(int length, int min = -100, int max = 100)
        {
            if (length < 2)
            {
                length = 2;
            }
            Random rand = new Random();
            int[] newRandomTab = new int[length];
            for (int i = 0; i < length; i++)
            {
                newRandomTab[i] = rand.Next(min, max);
            }
            return newRandomTab;
        }
    }
}