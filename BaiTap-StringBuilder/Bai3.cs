using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Bài tập 3: Viết một chương trình C# để nối hàng loạt danh sách chuỗi vào một chuỗi duy nhất bằng StringBuilder.
namespace BaiTap_StringBuilder
{
	internal class Bai3
	{
		public static void Main(string[] args)
		{
            Console.WriteLine("Nhap So Luong Chuoi: ");
			int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap Cac Chuoi: ");
			List<String> list = new List<String>();
			while(n > 0)
			{
				list.Add(Console.ReadLine());
				n--;
			}
			StringBuilder stringBuilder = new StringBuilder();	
			foreach(String s in list)
			{
				stringBuilder.Append(s);
				stringBuilder.Append(" ");
			}

            Console.WriteLine("Ket Qua: ");
            Console.WriteLine(stringBuilder.ToString());
        }
	}
}
