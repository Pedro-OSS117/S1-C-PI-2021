using System;

namespace TriBulle
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tabToSort = new int[]{10, 7, 4};
            DisplayTabAvecClasseGenerique(tabToSort);
            TriBulle(tabToSort);
            DisplayTabAvecClasseGenerique(tabToSort);

            int[] tabToSort2 = new int[]{10, 1, 4, 8, 5,256,9, 7, 4};
            DisplayTabAvecClasseGenerique(tabToSort2);
            TriBulle(tabToSort2);
            DisplayTabAvecClasseGenerique(tabToSort2);
        }

        static void TriBulle(int[] tabToSort)
        {
            for(int i = 0; i < tabToSort.Length; i++)
            {
                for(int j = 0; j < tabToSort.Length - 1; j++)
                {
                    if(tabToSort[j] > tabToSort[j+1])
                    {
                        int tmp = tabToSort[j+1];
                        tabToSort[j+1] = tabToSort[j];
                        tabToSort[j] = tmp;
                    }
                }
            }
        }       

        static void DisplayTabAvecClasseGenerique<T>(T[] myTab)
        {
            if(myTab == null)
            {
                return;
            }

            string display = "{";
            for(int i = 0; i < myTab.Length - 1; i++)
            {
                if(myTab[i] != null)
                {
                    display += "\"" + myTab[i].ToString() + "\",";
                }
            }
            if(myTab[myTab.Length - 1] != null)
            {
                display += "\"" + myTab[myTab.Length - 1].ToString() + "\"}";
            }
            Console.WriteLine(display);
        }
    }
}
