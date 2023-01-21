using DependencyInjection;

//Hund hund = new Hund("Bello");          //Objekt Hund 

//Tierpfleger pfleger = new Tierpfleger(hund);            // Objekt Hund wird an pfleger weitergeleitet      

//Console.WriteLine((pfleger.getHund()).ToString());      //getHund returnt das Objekt Hund und mit toString,(welcher override ist)
//                                                        //wird der Name des Hundes ausgegeben.


List<string> Hundenamen = new List<String>();

Console.WriteLine("Geben Sie an wie viele Hunde sie heute Pflegen");
Console.Write("Eingabe: ");
int Zahl = Convert.ToInt32(Console.ReadLine());

for(int i = 1; i <= Zahl; i++)
{
    Console.WriteLine("Geben Sie der Name des Hundes ein.");
    Console.Write("Eingabe: ");
    string name = Console.ReadLine();
    Hundenamen.Add(name);
    }

foreach (string name in Hundenamen)
{
    var hund1 = new Hund(name);

    var pfleger1 = new Tierpfleger(hund1);

    Console.WriteLine((pfleger1.getHund()).ToString());
}







Console.ReadKey();