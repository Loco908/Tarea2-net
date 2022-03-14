using models;
namespace Ejercicio1
{
    internal class Registro
    {

        Libreria li = new Libreria();



        public void MostrarMenu()
        {
            int select = 0;
            while (select == 0)
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1.Agregar Pelicula");
                Console.WriteLine("2.Editar Pelicula");
                Console.WriteLine("3.Eliminar Pelicula");
                Console.WriteLine("4.Mostrar Pelicula");
                Console.WriteLine("5.Mostrar todas las Peliculas");
                Console.WriteLine("______________________________");
                select = int.Parse(Console.ReadLine());


            }
            switch (select)
            {
                case 1:
                    MostrarMenu1();
                    break;
                case 2:
                    MostrarMenu2();
                    break;
                case 3:
                    MostrarMenu3();
                    break;
                case 4:
                    MostrarMenu4();
                    break;
                case 5:
                    MostrarMenu5();

                    break;

            }
        }
        public void MostrarMenu1()
        {
            Console.WriteLine("|AgregarPelicula|");
            Console.WriteLine("Ingresa rl nombre de la pelicula");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingresa el genero de la pelicula");
            string genero = Console.ReadLine();
            Console.WriteLine("ingresa el año");
            int año = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el director");
            string director = Console.ReadLine();
            Console.WriteLine("______________________________");
            Pelicula peli = new Pelicula(nombre, genero, año, director);
            li.agregar(peli);
            MostrarMenu();
        }


        public void MostrarMenu2()
        {
            Console.WriteLine("|Editar pelicula|");
            Console.WriteLine("Ingresa el nombre de la pelicula");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingresa el nuevo nombre de la pelicula");
            string nnombre = Console.ReadLine();
            Console.WriteLine("Ingresa el genero de la pelicula");
            string genero = Console.ReadLine();
            Console.WriteLine("ingresa el año");
            int año = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el director");
            string director = Console.ReadLine();
            Console.WriteLine("______________________________");
            li.editar(nnombre, nombre, genero, año, director);
            MostrarMenu();
        }
        public void MostrarMenu3()
        {
            Console.WriteLine("|Eliminar pelicula|");
            Console.WriteLine("Ingresa el nombre de la pelicula");
            string nombre = Console.ReadLine();
            Console.WriteLine("______________________________");
            li.eliminar(nombre);
            MostrarMenu();

        }
        public void MostrarMenu4()
        {
            Console.WriteLine("|Mostar Pelicula|");
            Console.WriteLine("Ingresa el nombre de la pelicula");
            string nombre = Console.ReadLine();
            li.mostrar(nombre);
            Console.WriteLine("______________________________");
            MostrarMenu();
        }
        public void MostrarMenu5()
        {
            Console.WriteLine("|Mostar Peliculas|");
            li.mostrarTodos();
            Console.WriteLine("______________________________");
            MostrarMenu();
        }

        public void generar()
        {
            Pelicula peli = new Pelicula("la marca del zorrrilo", "comedia", 1950, "Gilberto Martínez Solares");
            li.agregar(peli);
            Pelicula peli2 = new Pelicula("Los olviados", "drama", 1950, "Luis Buñuel");
            li.agregar(peli2);
            Pelicula peli3 = new Pelicula("Angel exterminador", "drama", 1966, "Luis Buñuel");
            li.agregar(peli3);
            Pelicula peli4 = new Pelicula("Forrest Gump", "comedia", 1994, "Robert Zemeckis");
            li.agregar(peli4);
            Pelicula peli5 = new Pelicula("Chabelo y Pepito contra los monstruos", "comedia", 1973, "José Estrada");
            li.agregar(peli5);

        }

    }


}