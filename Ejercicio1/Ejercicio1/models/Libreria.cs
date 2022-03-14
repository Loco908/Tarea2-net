namespace models

{


    internal class libreria
    {

        private List<Pelicula> _peliculas;

        public Libreria()
        {
            _peliculas = new List<Pelicula>();
        }

        public void agregar(Pelicula pelicula)
        {
            if (pelicula != null)
            {
                _peliculas.Add(pelicula);

            }
        }
        public void editar(string nnombre, string nombre, string genero, int a�o, string director)
        {
            if (nombre != null && genero != null && a�o != 0 && director != null)
            {
                foreach (Pelicula pelicula in _peliculas)
                {
                    if (pelicula.nombre == nombre)
                    {
                        pelicula.genero = genero;
                        pelicula.a�o = a�o;
                        pelicula.director = director;
                        pelicula.nombre = nnombre;

                    }

                }

            }
            else
            {
                Console.WriteLine("Pelicula no encontrada");
            }

        }

        public void eliminar(string nombre)
        {
            if (nombre != null)
            {
                foreach (Pelicula pelicula in _peliculas)
                {
                    if (pelicula.nombre == nombre)
                    {
                        _peliculas.Remove(pelicula);

                    }

                }

            }
            else
            {
                Console.WriteLine("Pelicula no encontrada");
            }
        }
        public void mostrar(string nombre)
        {
            if (nombre != null)
            {
                foreach (Pelicula pelicula in _peliculas)
                {
                    if (pelicula.nombre == nombre)
                    {
                        Console.WriteLine(pelicula.ToString());
                        break;
                    }
                }

            }
            else
            {
                Console.WriteLine("Pelicula no encontrada");
            }
        }
        public void mostrarTodos()
        {
            foreach (Pelicula pelicula in _peliculas)
            {

                Console.WriteLine(pelicula.ToString());

            }
        }

    }


}