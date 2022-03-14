namespace models
{
	internal class Pelicula
	{
		private string _nombre;
		private string _genero;
		private int _a�o;
		private string _director;


		public Pelicula(string nombre, string genero, int a�o, string director)
		{
			this._nombre = nombre;
			this._genero = genero;
			this._a�o = a�o;
			this._director = director;

		}


		public string nombre { set; get; }
		public string genero { set; get; }
		public int a�o { set; get; }
		public string director { set; get; }

		public override string ToString()
		{
			return $"Nombre:{this._nombre} ,Genero:{this._genero} ,A�o:{this._a�o} ,Director:{this._director}\n";
		}
	}
}