//Tres Matrices basicas
//Crea una matriz para contener los valores enteros 0 a 9
int[] numArray = {0,1,2,3,4,5,6,7,8,9};
//Crea una matriz con los nombres "Tim","Martin","Nikki" y "Sara"
string[] names = {"Tim","Martin","Nikki","Sara"};
//Crea una matriz de longitud 10 que alterne entre valores verdadero y falso, empezando por verdadero.​
bool[] booleans = new bool[10];
bool value = true;
for (int i = 0; i < booleans.Length; i++)
{
    booleans[i] = value;
    value = !value;
}

//Lista de Sabores
//Crea una lista de sabores de helados que contenga al menos 5 sabores diferentes (¡no dudes en añadir más de 5!).​
List<string> iceCream = new List<string>();
iceCream.Add("Vainilla");
iceCream.Add("Chocolate");
iceCream.Add("Frutilla");
iceCream.Add("Menta");
iceCream.Add("Piña");
//Imprime la longitud de esta lista después de construirla. ​
Console.WriteLine($"Actualmente hay {iceCream.Count} sabores de helado en la lista");
//Imprime el tercer sabor de la lista y luego elimina ese valor. ​
Console.WriteLine($"El tercer sabor de la lista es {iceCream[2]}");
iceCream.RemoveAt(2);
//Obtén la nueva longitud de la lista (¡sólo debería ser una menos!)​
Console.WriteLine($"Actualmente hay {iceCream.Count} sabores de helado en la lista");

//Diccionario de Información del Usuario
//Crea un diccionario que almacene tanto claves de cadena como valores de cadena. 
Dictionary<string,string> user = new Dictionary<string,string>();
//Añade pares clave/valor a este diccionario donde:​
    //cada clave sea un nombre de la matriz de nombres​
    //cada valor sea un sabor seleccionado al azar de tu lista de sabores.​
foreach (string name in names)
{
    Random rand = new Random();
    int index = rand.Next(0,iceCream.Count);
    user.Add(name,iceCream[index]);
}
//Revisa el diccionario e imprime el nombre de cada usuario y su sabor de helado asociado.​
foreach (var entry in user)
{
    Console.WriteLine($"{entry.Key} y su sabor de helado asociado es: {entry.Value}");
}