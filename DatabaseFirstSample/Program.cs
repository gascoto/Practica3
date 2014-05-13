using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseFirstSample
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new Entities()) //conexion a la base de datos
            {
                // Create and save a new Blog 
                Console.Write("Enter a name for a new Blog: ");
                var name = Console.ReadLine(); ///Ojo: Var se refiere a una variable sin condicion, asume lo que se le asigna, letra, numero, etc.

                var blog = new Blog { Name = name };  //aqui se abre el costructor, puedo asignarle propiedades
                db.Blogs.Add(blog);
                db.SaveChanges();

                // Display all Blogs from the database 
                var query = from b in db.Blogs
                            orderby b.Name
                            select b;

                

                Console.WriteLine("All blogs in the database:");
                foreach (var item in query)
                {
                    Console.WriteLine(item.Name);
                }

                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            } //en este punto se cierra la base de datos
        }
    }
}
