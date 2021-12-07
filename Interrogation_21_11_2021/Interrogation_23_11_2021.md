## NOM : 
## PRENOM :  

# Cours C# - PI - Interrogation - 23/11/2021	

# I - Un peu d'histoire 

1 - Comment appelle-t-on le code que peut éxécuter un ordinateur ?
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
2 - De quoi est composé un fichier écrit en langage éxécutable par une machine ?
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
3 - Lister les étapes pour produire un programme ?
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
4 - Quel interval de nombre peut-on écrire sur 1 octet ?
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<div style="page-break-after: always;"></div>
# II - Les Programmes

1 - Que comportera toujours un programme ?
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
2 - De quoi est composé un programme ?
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
3 - Qu'est ce que Visual Code ?
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
4 - Qu'est ce que le C# ?
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
5 - Qu'est ce qu'un compilateur ?
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<div style="page-break-after: always;"></div>
# III - Les variables

1 - Comment appelle-t-on l'instruction suivante ?

```csharp
int maVariable;
```  
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
2 - Comment appelle-t-on l'instruction suivante ?

```csharp
maVariable = 1;
```  
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
3 - Quel est le terme pour définir le nom d'une variable ?
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
4 - Citer les 9 types de base du C#.
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
5 - Combien d'octet prend un int en mémoire ?
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<div style="page-break-after: always;"></div>
6 - Ces instructions compilent-elles ? Corriger les instructions invalides s'il y en a.

```csharp
byte number1 = 256;
```
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
7 - Ces instructions compilent-elles ? Corriger les instructions invalides s'il y en a.

```csharp
float number1 = 1.0f;
double number2 = number1;
```  
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
8 - Ces instructions compilent-elles ? Corriger les instructions invalides s'il y en a.

```csharp
float number1 = 1.0f;
int number2 = number1;
```  
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
9 - Comment appelle-t-on les opérateurs suivants : +, -, /, * ?
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
10 - Qu'affichera ce programmme ?

```csharp
string message = "Bonjour ";
message += "ça va ?";
message = "ça va bien";
Console.WriteLine(message);
```  
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
11 - Qu'est ce qu'une variable static ?
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
12 - Quelle est la différence entre un cast explicite et un cast implicite ?
Donner un exemple pour chacun des cas.
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
13 - Ces instructions compilent-elles ? Corriger les instructions invalides s'il y en a.

```csharp
int a = 1;
int b = 2;
if(a < b)
{
    string message = "a est inferieur à b";
}
Console.WriteLine(message);
``` 
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
14 - Que faut-il toujours déclarer pour définir une variable ?
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<div style="page-break-after: always;"></div>
# IV - Les instructions conditionnelles

1 - Que retourne une instruction conditionnelle ?
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
2 - Citer les opérateurs logiques.
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
3 - Citer les opérateurs de comparaison.
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
4 - Quels sont les deux blocs conditionnels du C# ?
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
5 - Qu'affichera ce programme ?

```csharp
int a = 1;
int b = 2;
Console.WriteLine(a > b || (a + 1) == b);
``` 
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<div style="page-break-after: always;"></div>
6 - Qu'affichera ce programme ?

```csharp
int a = 1;
int b = 2;
Console.WriteLine(a > b || (a == b && (a + 1) >= b));
``` 
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
7 - Qu'affichera ce programme ?

```csharp
int a = 1;
int b = 2;
Console.WriteLine(a > b || (a < b && (a + 1) >= b));
``` 
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
8 - Qu'affichera ce programme ?

```csharp
int a = 10;
int b = 4;
bool test = a > b && a >= (b - 3) && b != (a - 5);
Console.WriteLine(!test);
``` 
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<div style="page-break-after: always;"></div>
9 - Ces instructions compilent-elles ? Corriger les instructions invalides s'il y en a.
Qu'affichera ce programme ?

```csharp
string Message = "coucou"
switch(message) {
    cases : "cocu"
        Console.WriteLine("bravo 1 !");
    cases : "bj";
        Console.WriteLine("bravo 2 !");
    defaut : 
        Console.WriteLine("bravo 3 !");
}
```
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<div style="page-break-after: always;"></div>
# V - Les Fonctions

1 - Comment appelle-t-on la définition d'une fonction ?
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
2 - Quelles sont les noms des 5 parties qui définissent une fonction ?
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
3 - Combien de paramètres peut avoir une fonction ?
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
4 - Par quelle instruction doit se terminer une fonction ?
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
5 - Soit l'appel de la fonction "UnNomDeFonction" suivante, donner la définition de la fonction.

```csharp
bool theTruth = false;
string message = "coucou";
theTruth = UnNom.UnNomDeFonction(12, message);
```
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<div style="page-break-after: always;"></div>
6 - Soit l'appel de la fonction "UnNomDeFonction2" suivante, donner la définition de la fonction.

```csharp
string message = "coucou";
UnNom.UnNomDeFonction2(a > 12, message == "bob" ? 1 : 2, message);
```
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
7 - Qu'affichera ce programme ?

```csharp
static void Main(string[] args)
{
    int value = 3;
    UnNomDeFonction(value);
    value++;
    Console.WriteLine("La valeur est : " + value);
}

static void UnNomDeFonction(int value)
{
    value++;
    Console.WriteLine("La valeur est : " + value);
    value += 2;
}
```
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<div style="page-break-after: always;"></div>
8 - Qu'affichera ce programme ?

```csharp
static void Main(string[] args)
{
    string message = "Bonjour";
    string message2 = "Au revoir";
    message2 += UnNomDeFonction(message);
    Console.WriteLine(message2);
}

static string UnNomDeFonction(string message)
{
    Console.WriteLine(message);
    message += "\nComment va ?\n";
    return message;
}
```
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<div style="page-break-after: always;"></div>
# VI - Les Boucles

1 - Soit la boucle for suivante, décrire les trois instructions qui la constituent :
 
```csharp
for(int i = 0; i < 2; i++)
{

}
```
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/> 
2 - Quand utilise-t-on une boucle for ?
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
3 - Quand utilise-t-on une boucle while ?
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
4 - Ecrire une boucle infinie avec une boucle for et une boucle while
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<div style="page-break-after: always;"></div>
5 - Ecrire une fonction qui permet d'afficher la somme totale en additionnant tous les nombres jusqu'à un nombre passé en paramètre.
Ecrire cette fonction en trois versions : avec une boucle for, while et do while.

Exemple si vous saisissez 7. Vous devez afficher le résultat de 1 + 2 + 3 + 4 + 5 + 6 + 7<br/>
Affichage final sur l'écran : Le résultat est 28
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
<br/><br/>
6 - Écrivez une fonction qui affiche la table de multiplication d’un chiffre passé en paramètre.
Ecrire cette fonction en trois versions : avec une boucle for, while et do while.

Exemple si vous saisissez 3, le programme affichera :<br/>
1 x 3 = 3<br/>
2 x 3 = 6<br/>
3 x 3 = 9<br/>
4 x 3 = 12<br/>
5 x 3 = 15<br/>
6 x 3 = 18<br/>
7 x 3 = 21<br/>
8 x 3 = 24<br/>
9 x 3 = 27<br/>






