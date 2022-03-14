namespace models
{
	internal class Pelicula
	{
		private string _nombre;
		private string _genero;
		private int _año;
		private string _director;


		public Pelicula(string nombre, string genero, int año, string director)
		{
			this._nombre = nombre;
			this._genero = genero;
			this._año = año;
			this._director = director;

		}


		public string nombre { set; get; }
		public string genero { set; get; }
		public int año { set; get; }
		public string director { set; get; }

		public override string ToString()
		{
			return $"Nombre:{this._nombre} ,Genero:{this._genero} ,Año:{this._año} ,Director:{this._director}\n";
		}
	}
}