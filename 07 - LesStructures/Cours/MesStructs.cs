using System;

public struct MaPremiereStructure
{
    // les propriétés
    int maProps;
    float maProps2;
    ConsoleKey key;
    public string message;

    private static int mapPropStatic = 1;
    public static int mapPropStatic2 = 1;

    // Constructeur par default 
    // il inialise les propriétés à leur valeur par defaut
    /*public MaPremiereStructure()
    {
    }*/

    // D'autre Constructeur
    public MaPremiereStructure(int prop1)
    {
        maProps = prop1;
        maProps2 = 1;
        key = ConsoleKey.Attention;
        message = "coucou " + prop1;
    }
    
    public MaPremiereStructure(int prop1, int prop2, ConsoleKey prop3)
    {
        maProps = prop1;
        maProps2 = prop2;
        key = prop3;
        message = "coucou";
    }

    // Fonction (ou methode) accessible au travers d'une instance de la structure
    public int GetSumValue()
    {
        return maProps + (int)maProps2 + mapPropStatic;
    }

    private void SetProp1(int value)
    {
        maProps = value;
    }

    public override string ToString()
    {
        string value = "{ maProps : " + maProps;
        value += ", maProps2 : " + maProps2;
        value += ", key : " + key;
        value += ", message : " + message + "}";
        return value;
    }

    // Fonction static accessible par le nom de la structure
    public static int GetGlobalValue()
    {
        return mapPropStatic;
    }

    public static void SetGlobalValue(int value)
    {
        mapPropStatic = value;
    }

    public static int SumTwoStruct(MaPremiereStructure var1, MaPremiereStructure var2)
    {
        return var1.GetSumValue() + var2.GetSumValue();
    }
}