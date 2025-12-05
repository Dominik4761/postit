using NUnit.Framework;
using System;

namespace DolgozatProject.Tests
{
	[TestFixture]
	public class DolgozatTest
	{
		private Dolgozat dolgozat;

		[SetUp]
		public void Setup()
		{
			dolgozat = new Dolgozat();
		}

		
		[Test]
		public void PontFelvesz_ValidPont_AddsToList()
		{
			dolgozat.PontFelvesz(80);
			Assert.AreEqual(1, dolgozat.pontok.Count);
		}

		[Test]
		public void PontFelvesz_InvalidPont_ThrowsException()
		{
			Assert.Throws<ArgumentException>(() => dolgozat.PontFelvesz(120));
		}

		
		[Test]
		public void MindenkiMegirta_NoStudents_ReturnsFalse()
		{
			Assert.IsFalse(dolgozat.MindenkiMegirta());
		}

		[Test]
		public void MindenkiMegirta_AllWrote_ReturnsTrue()
		{
			dolgozat.PontFelvesz(50);
			dolgozat.PontFelvesz(70);
			Assert.IsTrue(dolgozat.MindenkiMegirta());
		}

		[Test]
		public void MindenkiMegirta_OneDidNotWrite_ReturnsFalse()
		{
			dolgozat.PontFelvesz(-1);
			dolgozat.PontFelvesz(80);
			Assert.IsFalse(dolgozat.MindenkiMegirta());
		}

		
		[Test]
		public void Bukas_CountsCorrectly()
		{
			dolgozat.PontFelvesz(40);
			dolgozat.PontFelvesz(30);
			dolgozat.PontFelvesz(70);
			Assert.AreEqual(2, dolgozat.Bukas);
		}

		
		[Test]
		public void Elegseges_CountsCorrectly()
		{
			dolgozat.PontFelvesz(50);
			dolgozat.PontFelvesz(60);
			dolgozat.PontFelvesz(70);
			Assert.AreEqual(2, dolgozat.Elegseges);
		}

		
		[Test]
		public void Kozepes_CountsCorrectly()
		{
			dolgozat.PontFelvesz(61);
			dolgozat.PontFelvesz(70);
			dolgozat.PontFelvesz(80);
			Assert.AreEqual(2, dolgozat.Kozepes);
		}

		
		[Test]
		public void Jo_CountsCorrectly()
		{
			dolgozat.PontFelvesz(71);
			dolgozat.PontFelvesz(80);
			dolgozat.PontFelvesz(90);
			Assert.AreEqual(2, dolgozat.Jo);
		}

	
		[Test]
		public void Jeles_CountsCorrectly()
		{
			dolgozat.PontFelvesz(82);
			dolgozat.PontFelvesz(90);
			dolgozat.PontFelvesz(70);
			Assert.AreEqual(2, dolgozat.Jeles);
		}

		
		[Test]
		public void Gyanus_MoreJelesThanKivalok_ReturnsTrue()
		{
			dolgozat.PontFelvesz(90);
			dolgozat.PontFelvesz(95);
			Assert.IsTrue(dolgozat.Gyanus(1));
		}

		[Test]
		public void Gyanus_InvalidParameter_ThrowsException()
		{
			Assert.Throws<ArgumentException>(() => dolgozat.Gyanus(-1));
		}

		
		[Test]
		public void Ervenytelen_HalfDidNotWrite_ReturnsTrue()
		{
			dolgozat.PontFelvesz(-1);
			dolgozat.PontFelvesz(-1);
			dolgozat.PontFelvesz(70);
			dolgozat.PontFelvesz(80);
			Assert.IsTrue(dolgozat.Ervenytelen);
		}

		[Test]
		public void Ervenytelen_AllWrote_ReturnsFalse()
		{
			dolgozat.PontFelvesz(70);
			dolgozat.PontFelvesz(80);
			Assert.IsFalse(dolgozat.Ervenytelen);
		}
	}
}
