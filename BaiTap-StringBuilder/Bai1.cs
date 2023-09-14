using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Bài tập 1: Viết một chương trình C# để đảo ngược một chuỗi bằng cách sử dụng StringBuilder.

namespace BaiTap_StringBuilder
{
	public class Bai1
	{
		public static void Main(string[] args)
		{
            Console.WriteLine("Nhap Mot Chuoi: ");
			string input = Console.ReadLine();

			StringBuilder sb = new StringBuilder(input);

			int left = 0;
			int right = sb.Length - 1;

			while(left < right)
			{
				char temp = sb[left];
				sb[left] = sb[right];
				sb[right] = temp;


				left++;
				right--;
			}

            Console.WriteLine("Chuoi Dao Nguoc: ");
            Console.WriteLine(sb.ToString());
        }

	}
}
