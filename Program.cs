using System;

namespace PleaseGodHelpMeitistoughtask
{
    class Program
    {
        private static object price;

        static void Main(string[] args)
        {
            /*2.Product class
- No
- Name
- Price
- Count

Book class - Productdan miras alır 
 - Genre 
 
No, Name ve Price dəyərləri təyin olunmadan Product obyekti yaradıla bilməz
Genre dəyəri təyin olunmadan Book yaradıla bilməz

Proqram run olduqda bizden say istemelidi, sayi daxil etdikden sonra hemin uzunluqda bir book arrayi yaradilmalidir
daha sonra verdiyimiz say defe bizden book ucun lazim olan butun inputlari daxil etmeyimizi istemelidi,
dovrun her stepinde yeni bir book obyekti yaranib array-e elave edilmelidir (Bura qeder dersde etdiklerimize uygundur)


Arrayi tam olaraq doldurduqdan sonra menu penceresi gorunmelidir console-da ve orada asagidaki kimi yazilmalidir:
1. Kitablari qiymete gore filterle
2. Butun kitablari goster
0. Proqrami bagla



bu gorsendeikden sonra proqram bizden bir input daxil etmeyimizi istemelidi

Eger daxil etdiyimiz deyer 1 olarsa proqram kitablari filter edib bize gostermek ucun bizden minPrice ve maxPrice deyerlerini daxil etmeyimizi istemelidi.
Biz her iki deyeri daxil etdikden sonra proqram yaranmis kitab arrayindeki kitablari gonderdiyimiz min ve max price deyerlerine gore filter edib bize gostermelidi.
Daha sonra yeniden menu penceresi gorunmelidir.

Eger daxil etdiyimiz deyer 2 olarsa butun kitablar gosterilmelidir ve sonra menu penceresi gorsenmelidir yene

Eger daxil etdiyimiz deyer 0 olarsa proqram baglanmalidir

Eger daxil etdiyimiz deyer bu 3-unden basqa bir sey olarsa proqram bizden yeniden secim etmeyimizi istemelidir ta ki duz secim edenedek
             */

            Console.WriteLine("Please write how many books do you want?");
            int type_count = int.Parse(Console.ReadLine());
            Book1s[] book1s = new Book1s[type_count];
            
            for (int i = 0; i < type_count; i++)
            {
                Console.Write("Please enter the Genre:  ");
                string Genre = Console.ReadLine();

                Console.Write("Please enter the No:  ");
                int No =int.Parse (Console.ReadLine());

                Console.Write("Please enter the size of Name:  ");
                string Name = (Console.ReadLine());

                Console.Write("Please enter the Price:  ");
                double Price = int.Parse(Console.ReadLine());

                book1s[i] = new Book1s(Genre, No, Name, Price);

             
            }
            Console.WriteLine("press 1 for filter books by prices");
            Console.WriteLine("press 2 show all the books");
            Console.WriteLine("press 0 close the application");

            int choosen = int.Parse(Console.ReadLine());

            

            do
            {
                Console.WriteLine(" re enter input");

            } while (choosen != 0 || choosen != 1 || choosen != 2 || choosen==2);
            




            int str = Convert.ToInt32(Console.ReadLine());
            switch (str)
            {


                case 1:
                    int maxValue = Convert.ToInt32(Console.ReadLine());
                    int minValue = Convert.ToInt32(Console.ReadLine());

                    for (int i = 0; i < book1s.Length; i++)
                    {
                        Book1s pr = new Book1s(double Price);
                       
                        
                        
                        
                        
                        

                        
                        
                        {
                            Console.WriteLine(0);
                        }



                    }

                  



                break;


            }
            




        }
    }

    internal class Book1s
    {
        private string genre;
        private int no;
        private string name;
        private double price;

        public Book1s(string genre, int no, string name, double price)
        {
            this.genre = genre;
            this.no = no;
            this.name = name;
            this.price = price;
        }
    }
}
