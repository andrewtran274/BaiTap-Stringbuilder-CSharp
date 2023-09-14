using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Bài tập 4: Viết một chương trình C# để xóa tất cả các từ trùng lặp trong một chuỗi sử dụng StringBuilder.

namespace BaiTap_StringBuilder
{
	internal class Bai4
	{
		public static void Main(string[] args)
		{
            Console.WriteLine("Nhap Mot Chuoi: ");
			string input = Console.ReadLine();

			StringBuilder stringBuilder = new StringBuilder(input);

			HashSet<string> list = new HashSet<string>();

			int startIndex = 0;

			for(int i  = 0; i < stringBuilder.Length; i++)
			{
				if (char.IsWhiteSpace(stringBuilder[i]) || i == stringBuilder.Length - 1)
				{
					string word = stringBuilder.ToString(startIndex, i - startIndex + 1 ).Trim();

					if (!list.Contains(word))
					{
						list.Add(word);
					}
					else
					{
						stringBuilder.Remove(startIndex, i - startIndex + 1);
						i = startIndex - 1;
					}

					startIndex = i + 1;
				}
			}

            Console.WriteLine("Ket Qua: ");
            Console.WriteLine(stringBuilder.ToString());
        }
	}
}
