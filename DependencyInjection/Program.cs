using DependencyInjection;

Console.WriteLine("Wie heisst ihr Hund?");
Console.Write("Eingabe: ");
string name = Console.ReadLine();



Hund hund = new Hund(name);          //Objekt Hund 

Tierpfleger pfleger = new Tierpfleger(hund);            // Objekt Hund wird an pfleger weitergeleitet      

Console.WriteLine((pfleger.getHund()).ToString());      //getHund returnt das Objekt Hund und mit toString,(welcher override ist)
                                                        //wird der Name des Hundes ausgegeben.

