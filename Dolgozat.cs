using System;
using System.Collections.Generic;
using System.Linq;

namespace DolgozatProject
{
	public class Dolgozat
	{
		internal List<int> pontok;

		public Dolgozat()
		{
			pontok = new List<int>();
		}

	
		public void PontFelvesz(int x)
		{
			if (x < -1 || x > 100)
				throw new ArgumentException("Érvénytelen pontszám!");
			pontok.Add(x);
		}

		
		public bool MindenkiMegirta()
		{
			if (pontok.Count == 0) return false; 
			return !pontok.Contains(-1);
		}

	
		public int Bukas
		{
			get { return pontok.Count(p => p != -1 && p < 50); }
		}

		
		public int Elegseges
		{
			get { return pontok.Count(p => p >= 50 && p <= 60); }
		}

		
		public int Kozepes
		{
			get { return pontok.Count(p => p >= 61 && p <= 70); }
		}

		
		public int Jo
		{
			get { return pontok.Count(p => p >= 71 && p <= 80); }
		}

		
		public int Jeles
		{
			get { return pontok.Count(p => p > 81); }
		}

		
		public bool Gyanus(int kivalok)
		{
			if (kivalok < 0)
				throw new ArgumentException("Érvénytelen kivalók szám!");
			return Jeles > kivalok;
		}

		
		public bool Ervenytelen
		{
			get
			{
				if (pontok.Count == 0) return false;
				int nemMegirtak = pontok.Count(p => p == -1);
				return nemMegirtak >= pontok.Count / 2.0;
			}
		}
	}
}
