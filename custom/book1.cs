using System;
namespace PleaseGodHelpMeitistoughtask.custom
{
    public class Book1:Product
    {
        
        
        public string Genre;
       
        


        public Book1(string genre)
        {
            Genre = genre;
        }
        public void GetInfo()
        {
            Console.WriteLine($"No:{No}\n" +

                $"Name:{Name}\n" +
                $"Price:{Price}\n" +
                $"Genre:{Genre}\n");
        }

    }
}
