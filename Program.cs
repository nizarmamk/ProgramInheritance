using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Person1 = new Person();
            Person1.Name = "Kowalski";
            Person1.Age = 19;
            Person1.InfoPerson();
            Console.WriteLine();

            // Inheritance
            Karyawan Karyawan1 = new Karyawan();
            Karyawan1.Name = "Julien";
            Karyawan1.Age = 31;
            Karyawan1.InfoPerson();
            Karyawan1.InfoPerson("Dosen", "ABC12345");

            Console.ReadLine();
        }
    }
}
