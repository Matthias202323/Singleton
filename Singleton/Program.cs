using Singleton.Models;
using System;

namespace Singleton
{
    static class Program
    {
        static void Main()
        {
            //DatabaseSingleton singleton = new DatabaseSingleton();
           /* var context = new DBContext();*/

            /*     
                 Console.WriteLine("Hello");

            

            /* // I wipe out my database at each execution

             for (int i = 0; i < 10; i++)
                 {
                    */


            Class1 class1 = new Class1("Toto");
                    Class2 class2 = new Class2("Tutu");
            var context = DatabaseSingleton.Instance();
            context.Database.EnsureDeleted();
            // Then I recreate it
            context.Database.EnsureCreated();
        context.classes.Add(class1);
            context.classes2.Add(class2);
            context.SaveChanges();

        
            
           
            // After the shop is added, his relatonships will too
            // if they are defined          

            // Once changes are added, they must be saved to the database
            // unless you will have an unexisting one        





        }
    }
}

