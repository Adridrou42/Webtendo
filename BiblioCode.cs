//----------mon 1er programme----------
Console.WriteLine("Hello, World!");

//----------programme prenom age----------
// Déclaration des variables
string prenom ;
string phraseEntiere;
string ageChaine;
int age;

// Initialisation des variables
prenom = "JOAN";
phraseEntiere = "Salut, " + prenom;

// Demande du prénom à l'utilisateur
Console.Write("Quel est ton prenom ? ");
prenom = Console.ReadLine();

// Demande de l'age de l'utilisateur
Console.Write("Quel est ton age ? ");

// ageChaine = Console.ReadLine();
age = int.Parse(Console.ReadLine());
// age = int.Parse(ageChaine);

age = age + 1;

// Affichage
Console.WriteLine("Hello, " + prenom);
Console.WriteLine($"Hello, {prenom}, tu as {age - 1} ans, et tu aura {age} ans");
Console.WriteLine(phraseEntiere);

//------------programme langue--------------
    // Constantes 
    const string MSG_LANG = "Parler vous français ? (O/N)";

    // Déclaration et initialisation
    int entier = 0;
    char reponse = 'O';
    string msg_user = "";
    string msg_positif = "";

    // Choix de la langue
    Console.WriteLine(MSG_LANG);
    reponse = char.Parse(Console.ReadLine());

    if (reponse != 'O')
    {
        msg_user = "Give me an integer : ";
        msg_positif = "The integer is positive";
    }
    else
    {
        msg_user = "Saisir un nombre entier : ";
        msg_positif = "Le nombre est positif";
    }

    // Afficher le message à l'utilisateur
    Console.Write(msg_user);

    // Récupérer la valeur saisie par l'utilisateur
    entier = int.Parse(Console.ReadLine());

    // Tester la valeur et afficher le message
    if (entier > 0)
    {
        Console.WriteLine(msg_positif);
    }
    
//---------nombre positif/negatif/nul---------
int nombre = 0;

Console.WriteLine("Ecrivez un Nombre : ");
nombre = int.Parse(Console.ReadLine());

if (nombre == 0)
{
    Console.WriteLine("Nul");
}
else if (nombre > 0)
{
    Console.WriteLine("Positif");
}
else
{
    Console.WriteLine("Négatif");
}

//-------------age------------------------
int nombre = 0;

Console.Write("Quel est votre age ? ");
nombre = int.Parse(Console.ReadLine());

if (nombre >= 18)
{
    Console.WriteLine("Vous etes majeur");
}
else
{
    Console.WriteLine("Vous etes mineur");
}

//---------------mot de passe----------------
string mdp = "secret";

Console.Write("saisisez le mot de passe ? ");
mdp = Console.ReadLine();

if (mdp == "secret")
{
    Console.WriteLine("Acces autorisé");
}
else
{
    Console.WriteLine("Acces refusé");
}

//--------------paire impaire-----------------
int nombre = 0;

Console.Write("ecrivez un nombre entier : ");
nombre = int.Parse(Console.ReadLine());

if (nombre % 2 == 0)
{
    Console.WriteLine("Pair");
}
else
{
    Console.WriteLine("Impaire");
}

//-------------note /20---------------------
int nombre = 0;

Console.Write("entrez une note sur 20 : ");
nombre = int.Parse(Console.ReadLine());

if (nombre >= 10)
{
    if (nombre > 20)
    {
        Console.WriteLine("nombre Invalide");
    }
    else
    {
        Console.WriteLine("Validé");
    }
}
else
{
    Console.WriteLine("non validé");
}

//-------------reduction------------------
int nombre = 0;

Console.Write("entrez le montant d'achat : ");
nombre = int.Parse(Console.ReadLine());

if (nombre > 100)
{
        Console.WriteLine("Réduction de 10%");
}
else
{
    Console.WriteLine("Pas de réduction");
}

//-----------intervalle 10 ; 20-------------
int nombre = 0;

Console.Write("entrez un nombre : ");
nombre = int.Parse(Console.ReadLine());

if ((nombre >= 10) && (nombre <= 20))
{
    Console.WriteLine("Le nombre est dans l'intervalle [10 ; 20]");
}
else
{
    Console.WriteLine("Le nombre est en dehors de l'intervalle");
}

//------------année bissextile----------------
int nombre = 0;

Console.Write("entrez une année : ");
nombre = int.Parse(Console.ReadLine());

if (nombre % 4 == 0)
{
    Console.WriteLine("Année bissextile");
}
else
{
    Console.WriteLine("Année non bissextile");
}

//------------calculatrice-------------------
int nombreA = 0;
int nombreB = 0;
string signe;

Console.Write("entrez le 1er nombre : ");
nombreA = int.Parse(Console.ReadLine());
Console.Write("entrez le 2eme nombre : ");
nombreB = int.Parse(Console.ReadLine());
Console.Write("entrez le signe (+/-) : ");
signe = Console.ReadLine();

if (signe == "+")
{
    Console.WriteLine(nombreA + nombreB);
}
else if (signe == "-")
{
    Console.WriteLine(nombreA - nombreB);
}

//------------------switch-----------------
//----------------jour semaine-------------
int chiffre = 0;
string correspondance = "Le chiffre correspond à ";

Console.Write("Ecrit un chiffre entre 1 et 7 : ");
chiffre = int.Parse(Console.ReadLine());

switch (chiffre) 
{
    case 1:
        Console.WriteLine(correspondance + "Lundi");
        break;
    case 2:
        Console.WriteLine(correspondance + "Mardi");
        break;
    case 3:
        Console.WriteLine(correspondance + "Mercredi");
        break;
    case 4:
        Console.WriteLine(correspondance + "Jeudi");
        break;
    case 5:
        Console.WriteLine(correspondance + "Vendredi");
        break;
    case 6:
        Console.WriteLine(correspondance + "Samedi");
        break;
    case 7:
        Console.WriteLine(correspondance + "Dimanche");
        break;
    default:
        Console.WriteLine("chiffre invalid");
}

//----------------calculatrice-------------
float chiffre1 = 0;
float chiffre2 = 0;
string operation = "";
string correspondance = "Le chiffre correspond à ";

Console.Write("Ecrit le 1er chiffre : ");
chiffre1 = float.Parse(Console.ReadLine());
Console.Write("Ecrit le 2eme chiffre : ");
chiffre2 = float.Parse(Console.ReadLine());
Console.Write("Ecrit l'operateur : ");
operation = Console.ReadLine();

switch (operation) 
{
    case "+":
        Console.WriteLine(chiffre1 + chiffre2);
        break;
    case "-":
        Console.WriteLine(chiffre1 - chiffre2);
        break;
    case "*":
        Console.WriteLine(chiffre1 * chiffre2);
        break;
    case "/":
        Console.WriteLine(chiffre1 / chiffre2);
        break;
    default:
        Console.WriteLine("erreur");
        break;
}

//------------------menu----------------
int choix = 0;

Console.Write("que voulez vous faire ? 1 - Démarrer 2 - Arrêter 3 - Redémarrer 4 - Quitter");
choix = int.Parse(Console.ReadLine());

switch (choix) 
{
    case 1:
        Console.WriteLine("Bienvenue");
        break;
    case 2:
        Console.WriteLine("Au revoir");
        break;
    case 3:
        Console.WriteLine("Redémarrage en cour");
        break;
    case 4:
        Console.WriteLine("Byebye");
        break;
    default:
        Console.WriteLine("erreur");
        break;
}

//--------------boucle----------------
//------compte a 10 avec boucle-------
for (int i = 1; i <= 10; i++)
{
    Console.Write(i + " ");
}

//--------------nombre +1-------------
int nombre = 0;
int n = 0;

Console.WriteLine("donne moi un nombre entier");
nombre = int.Parse(Console.ReadLine());

for (n = 0; n <= nombre; n++)
{
    Console.Write(n + " + ");
}
Console.Write(nombre);

//------------nombre multiplié--------
int nombre = 1;
int n = 0;

Console.WriteLine("donne moi un nombre entier");
n = int.Parse(Console.ReadLine());

//-----------nombre pair---------------
for (nombre = 1; nombre <= n; nombre++)
{
    if (nombre % 2 == 0)
    {
        Console.WriteLine("le nombre " + nombre + " est pair");
    }
}

//----------boite etoile---------------
int n = 0;

Console.WriteLine("Ecrit un entier N : ");
n = int.Parse(Console.ReadLine());

for (int ligne = 0; ligne < n; ligne++)
{
    for (int collumns = 0; collumns < n; collumns++)
    {
        Console.Write("*");
    }
    Console.WriteLine("");
}

//--------table multiplication---------
int n1 = 1;
int n2 = 1;

for (n1 = 1; n1 <= 10; n1++)
{
    for (n2 = 1; n2 <= 10; n2++)
    {
        Console.Write(n2 * n1 + "  ");
    }
    Console.WriteLine("");
}

//----------compte 1 a 10 while-------
int n = 0;

while (n < 10)
{
    n++;
    Console.WriteLine(n);
}

//--------------de 1 à N--------------
int n = 0;
int i = 0;


Console.WriteLine("donne moi un nombre supérieur à 0");
n = int.Parse(Console.ReadLine());

while (i < n - 1)
{
    i++;
    Console.Write(i + "+");
}
Console.Write(n);

//-------------note 0 a 20----------
int n = 0;

Console.WriteLine("donne moi ta note");
n = int.Parse(Console.ReadLine());

while (n < 0 || n > 20)
{
    Console.WriteLine("c'est pas possible");
    Console.WriteLine("réecrit un chiffre : ");
    n = int.Parse(Console.ReadLine());
}

//--------compte nombre chiffre-----
int n = 0;
int i = 0;

Console.Write("donne moi un entier : ");
n = int.Parse(Console.ReadLine());

while (n > 0)
{
    i++;
    Console.WriteLine(i);
    n = n / 10;
}
Console.WriteLine("il y a un total de " + i + " chiffres");

//--------nombre jusqua -1------
int n = 0;
int i = 0;

Console.Write("ecrit des nombre jusqua -1 ");
n = int.Parse(Console.ReadLine());

while (n > -1)
{
    Console.WriteLine("continue");
    n = int.Parse(Console.ReadLine());
}
Console.WriteLine("fin");

//---------moyenne valeur -1-------
{
    int n = 0;
    int i = 0;
    int a = 0;
    int somme = 0;

    Console.Write("ecrit des nombre jusqua -1 : ");
    n = int.Parse(Console.ReadLine());

    while (n != -1)
    {
        i = n;
        a = i + a;
        somme++;
        Console.WriteLine("continue");
        n = int.Parse(Console.ReadLine());
    }
    a /= somme;
    Console.WriteLine($"Moyenne : {a}");

}
//---------------rng---------------
int rand = new Random().Next(1, 100);
int n = 0;
int essais = 0;

Console.WriteLine(rand);
n = int.Parse(Console.ReadLine());

while(n != rand)
    {
    essais++;
    if (n < rand)
    {
        Console.WriteLine("Trop petit");
    }
    else
    {
        Console.WriteLine("Trop grand");
    }
    Console.Write("reesaie : ");
    n = int.Parse(Console.ReadLine());
}
essais++;
Console.WriteLine($"Bravo, tu as trouver en {essais} essais");

//------------menu while------------
int a = 1;
int b = 2;
int c = 3;
int choix = 0;

Console.WriteLine("1: Hello World");
Console.WriteLine("2: Hello Universe");

while (choix != c)
{
    choix = int.Parse(Console.ReadLine());
    if (choix == a)
    {
        Console.WriteLine("Hello World!");
    }
    else if (choix == b)
    {
        Console.WriteLine("Hello Universe!");
    }
}
Console.WriteLine("byebye");

//------------somme element tableau------------
int n = 0;
int i = 0;

// Demander à l'utilisateur de saisir une valeur N
Console.Write("Saisir une valeur N strictement positive : ");
n = int.Parse(Console.ReadLine());

// Créer un tableau de n entiers
int[] tabEntiers = new int[n];

// Boucle !
while (i < n)
{
    Console.Write($"donne moi la valeur {i + 1} : ");
    tabEntiers[i] = int.Parse(Console.ReadLine());
    i++;
}

for (int a = 0; a < tabEntiers.Length; a++)
{
    Console.Write(tabEntiers[a] + " / ");
}

//-----------valeur max et min------------
int n = 0;
int i = 0;

// Demander à l'utilisateur de saisir une valeur N
Console.Write("Saisir une valeur N strictement positive : ");
n = int.Parse(Console.ReadLine());

// Créer un tableau de n entiers
int[] tabEntiers = new int[n];

// Boucle !
while (i < n)
{
    Console.Write($"donne moi la valeur {i + 1} : ");
    tabEntiers[i] = int.Parse(Console.ReadLine());
    i++;
}

Console.WriteLine($"la valeure maximale est {tabEntiers.Max()}");
Console.WriteLine($"la valeure minimale est {tabEntiers.Min()}");

//--------nombre paire--------------
int n = 0;
int i = 0;

// Demander à l'utilisateur de saisir une valeur N
Console.Write("Saisir une valeur N strictement positive : ");
n = int.Parse(Console.ReadLine());

// Créer un tableau de n entiers
int[] tabEntiers = new int[n];

// Boucle !
while (i < n)
{
    Console.Write($"donne moi la valeur {i + 1} : ");
    tabEntiers[i] = int.Parse(Console.ReadLine());
    i++;
}

// Compter les nombres paires
int countPair = 0;
for (i = 0; i < n; i++)
{
    if (tabEntiers[i] % 2 == 0)
    {
        countPair++;
    }
}

Console.WriteLine($"il y a {countPair} nombres paire");

//----------x dans tableau-----------
int n = 0;
int i = 0;

// Demander à l'utilisateur de saisir une valeur N
Console.Write("Saisir une valeur N strictement positive : ");
n = int.Parse(Console.ReadLine());

// Créer un tableau de n entiers
int[] tabEntiers = new int[n];

// Boucle !
while (i < n)
{
    Console.Write($"donne moi la valeur {i + 1} : ");
    tabEntiers[i] = int.Parse(Console.ReadLine());
    i++;
}

// demander une valeur X
Console.Write("Saisir une valeur X à rechercher dans le tableau : ");
int x = int.Parse(Console.ReadLine());

// afficher si X est dans le tableau
Console.WriteLine(x);

if (tabEntiers.Contains(x))
{
    Console.WriteLine($"La valeur {x} est présente dans le tableau.");
}
else
{
    Console.WriteLine($"La valeur {x} n'est pas présente dans le tableau.");
}

//----------inverser tableau----------
int n = 0;
int i = 0;

// Demander à l'utilisateur de saisir une valeur N
Console.Write("Saisir une valeur N strictement positive : ");
n = int.Parse(Console.ReadLine());

// Créer un tableau de n entiers
int[] tabEntiers = new int[n];

// Boucle !
while (i < n)
{
    Console.Write($"donne moi la valeur {i + 1} : ");
    tabEntiers[i] = int.Parse(Console.ReadLine());
    i++;
}
// inverser le tableau
Array.Reverse(tabEntiers);
Console.WriteLine($"Le tableau inversé est : {string.Join(", ", tabEntiers)}");

//-----------tri tableau-------------