using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matris1GrupBulma
{
	class Block
	{
		public int data;
		public Block next;
		public Block(int veri)
		{
			this.data = veri;
		}
	}

	class Program
	{

		static int[] tree = new int[100];
		static int c = 0;
		static void Yaz(int[] tree, int i, int sayı)
		{
			if (i >= 15) return;
			if (tree[i] == sayı) { c++; Console.WriteLine("sayı tree de vardır"); }

			Yaz(tree, 2 * i + 1, sayı);
			Yaz(tree, 2 * i + 2, sayı);

		}
		static int a = 0;
		static void SağKol(int[] tree, int i, int sayı)//2,5,6,11,12,13,14
		{
			if (i >= 15) return;
			a = 2 * i + 1;
			if (tree[i] == sayı) { c++; Console.WriteLine("sayı tree de vardır"); }

			SağKol(tree, a, sayı);
			SağKol(tree, a + 1, sayı);

		}
		static void SolKol(int[] tree, int i, int sayı)
		{
			if (i >= 15) return;
			a = 2 * i + 1;
			if (tree[i] == sayı) { c++; Console.WriteLine("sayı tree de vardır"); }

			SolKol(tree, a, sayı);
			SolKol(tree, a + 1, sayı);

		}


		static void Main()
		{
			tree[0] = 50;

			tree[1] = 17;
			tree[2] = 72;

			tree[3] = 12;
			tree[4] = 23;
			tree[5] = 54;
			tree[6] = 76;

			tree[7] = 9;
			tree[8] = 14;
			tree[9] = 19;
			tree[10] = -1;
			tree[11] = -1;
			tree[12] = 67;
			tree[13] = -1;
			tree[14] = -1;



			//short edilmiş tree yapısında 67 yi ara short edilmemiş tree yapısında 67 yi ara

			Console.WriteLine("hangi sayıyı kontrol etmek istersiniz");
			int sayı = Convert.ToInt32(Console.ReadLine());

			Stack<int> stack = new Stack<int>();
			if (sayı > tree[0])
			{
				SağKol(tree, 0, sayı);
			}
			else if (sayı < tree[0])
			{
				SolKol(tree, 0, sayı);
			}
			else//eşit dir
			{
				Console.WriteLine("sayımız tree yapında vardır");
			}
			if (c == 0) Console.WriteLine("sayımız tree de bulunmamaktadır");




			//short edilmemiş tree yapısında önce short edip de yapılabilir
			Console.WriteLine("hangi sayıyı kontrol etmek istersiniz");
			int sayı2 = Convert.ToInt32(Console.ReadLine());
			Yaz(tree, 0, sayı2);
			if (c == 0) Console.WriteLine("sayımız tree de bulunmamaktadır");



		}
	}
}