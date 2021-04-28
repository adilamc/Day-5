using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5
{

    public class PhotoBook
    {
        protected int numPages { get; set; }
        public int GetNumberPages()
        {
            return numPages;
        }
        public PhotoBook(int num)
        {
            numPages = num;
        }
        public PhotoBook()
        {
            numPages = 16;
        }
    }
    public class BigPhotoBook : PhotoBook
    {
        public BigPhotoBook()
        {
            numPages = 64;
        }
    }


    class PhotoBookTest
    {
        public static void Main()
        {
            PhotoBook photobook = new PhotoBook();
            Console.WriteLine("The no. of pages: ");
            Console.WriteLine(photobook.GetNumberPages());
            //int x = Convert.ToInt32(Console.ReadLine());
            PhotoBook photobook1 = new PhotoBook(24);
            //photobook1.PhotoBook(24);
            Console.WriteLine("The default no. of pages: ");
            Console.WriteLine(photobook.GetNumberPages());
            BigPhotoBook bigphotobook = new BigPhotoBook();
            Console.WriteLine("The no. of pages in bigbook: ");
            Console.WriteLine(bigphotobook.GetNumberPages());
            Console.ReadLine();
        }
    }
}
