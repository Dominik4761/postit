using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace postit
{
	internal class Post
	{
		private string szin;
		private string tartalom;

		public Post(string szin, string tartalom)
		{
			this.szin = szin;
			this.tartalom = tartalom;
		}

		public string Szin
		{
			get
			{ 
				return szin;
			}
		}
		public string Tartalom
		{
			get
			{
				return tartalom;
			}
			set
			{
				tartalom = value;
			}
		}

		public string Szin1 { get => szin; }
		public string Tartalom1 { get => tartalom; set => tartalom = value; }

		public override string ToString()
		{
			return $"{this.Szin} {this.tartalom}";
		}
	}
}
