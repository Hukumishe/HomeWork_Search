using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search_240221
{
    class Product : IEnumerable
    {
        public int PartNumber { get; set; }
        public string Brand { get; set; }
        public string Name { get; set; }

        public void ShowInfo()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("Номер товара: " + PartNumber);
            Console.WriteLine("Название бренда: " + Brand);
            Console.WriteLine("Название товара: " + Name);

        }







        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
