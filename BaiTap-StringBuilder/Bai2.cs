using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Bài tập 2: Viết một chương trình C# để tạo một chuỗi được định dạng theo một mẫu đã cho, với các giá trị được điền vào các vị trí cụ thể bằng StringBuilder. Ví dụ: "Hello, {0}! Today is {1}.".
namespace BaiTap_StringBuilder
{
	internal class Bai2
	{
		public static void Main(string[] args)
		{
            Console.WriteLine("Nhap Chuoi Dinh Dang: ");
			string input = Console.ReadLine();
            Console.WriteLine("Nhap Ten cua Ban: ");
			string name = Console.ReadLine();
            Console.WriteLine("Nhap Ngay Hom Hay");
			string date = Console.ReadLine();

			StringBuilder sb = new StringBuilder(input);

			sb.Replace("{0}", name);
			sb.Replace("{1}", date);


            Console.WriteLine("Ket Qua: ");
            Console.WriteLine(sb.ToString());
        }
	}
}
