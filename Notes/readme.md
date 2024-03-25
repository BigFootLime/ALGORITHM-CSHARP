# Titre 1
## Titre 2
### Titre 3
#### Titre 4
##### Titre 5

***Gras et Italique***

~~Barré~~

'Code'
```csharp
int test = 0;
```

~~

# ALGORITHME C# 
 -- Par Mounir Benha

 ## Découverte du C# 

### Une Class: 
Une class peut etre considéré comme l'entrée ou la class principale d'un program.

### Une Méthode: 
Une méthode Main c'est le point d'entrée d'un programme, elle est appelé au demarrage d'un programme.
Une Méthode est représenté par sa signature: <modificateur> <type de retour> <nom de la methode> (<parametres>)

Voici un exemple: 
'Code'
```csharp
 static void Main(string[] args)
```
### Types de Variables;

#### Types Valeur:
Incluent les types intégrés tels que int, double, char et bool.


```csharp
int monEntier = 5;
```

```csharp
const double PI = 3.14;
```

```csharp
char myChar = 'a';
```

```csharp
bool isAdul = true;
```

#### Types Référence:
Inclues les types comme string et les objets.

#### Conversion de Types:
En C#, la conversion peut etre implicite ou explicite

Implicite; Automatique, sans perte d'information
Explicite: Necessite une syntaxe spécifique pour eviter les erreurs



OPERATEURS ARYTHMETIQUE 

  // Les opérateurs arithmétiques
        // + - * / %
        int x = 10 % 3;
        int y = 10 / 3;
        float z = 10 / 3.0;
        Console.WriteLine(x); // 1
        Console.WriteLine(y); // 1
        Console.WriteLine(z); // 1


C:\Users\kesma\Documents\ALGORITHM CSHARP\Project\consoleProject\Program.cs(60,19): error CS0266: Impossible de convertir implicitement le type 'double' en 'floa
t'. Une conversion explicite existe (un cast est-il manquant ?) [C:\Users\kesma\Documents\ALGORITHM CSHARP\Project\consoleProject\consoleProject.csproj]

Pour reparer erreur :
  // Les opérateurs arithmétiques
        // + - * / %
        int x = 10 % 3;
        int y = 10 / 3;
        float z = 10 / (float)3.0; // Ceci est un cast explicite
        Console.WriteLine(x); // 1
        Console.WriteLine(y); // 1
        Console.WriteLine(z); // 1

ou alors 

 int x = 10 % 3;
        int y = 10 / 3;
        float z = 10 / (float)3.0; // Ceci est un cast explicite
        float a = 10 / 3.0f; // Ceci est un cast implicite
        Console.WriteLine(x); // 1
        Console.WriteLine(y); // 1
        Console.WriteLine(z); // 1

OPERATUERS BOOLEANS

  int age = 14;
        bool hasDrivingLicense = false;
        bool isEmancipated = false;
        if (age >= 18 && hasDrivingLicense || isEmancipated)
        {
            Console.WriteLine("Vous pouvez conduire");
        }
        else if (age >= 18 && !hasDrivingLicense)
        {
            Console.WriteLine("Vous ne pouvez pas conduire");
        }
        else
        {
            Console.WriteLine("Vous ne pouvez pas conduire");
        }
Structures de control 
         Boucles (for, while, do-while): Facilitent l'execution répétée de blos de code.

        Boucle for:
        int i = 0;
        for(i<5){
            Console.WriteLine("Valeur de i: " + i );
        }

         Boucle while:
        int i = 0;
        while(i<5){
            Console.WriteLine("Valeur de i: " + i );
            i ++;
        }

// Execute seulement apres que le programme s'execute dans la boucle, ducoup 10 s'affiche 
        Boucle do while
        do{
            Console.WriteLine(x);
            x++;
        } while (x < 10);
        

        Methodes et passages de parametres 

// Void est le type de retour de la methoode
        static void print (string message)
        {
            Console.WriteLine(message);
        }

          static int add (int a, int b)
        {
            return a + b
        }
         print ("Hello World!");
        print ("Bonjour le monde!")

        int result = add(5, 6);
        print (result.ToString());




         static void print (string message)
        {
            Console.WriteLine(message);
        }
        Type type = typeof(string);
        string message = "Hello World";
        Type messageType = message.GetType();

        if(type == messageType)
        {
            print(message);
        }
        else
        {
            print(Le type de la variable messsage n'est pas un string)
        }


static void Main (string[] args){
        // Un tableau est une structure de données 
        // qui permet de stocker plusieurs
        // type[] <nom de tableau> = new <type>[taille du tableau]

        int[] tab = new int[5]

        string[] jourDeLaSemaine = new string["Lundi, "Mardi", "Mercredi", "Jeudi", "Vendredi"]

        Console.WriteLine(jourDeLaSemaine[0])
}



