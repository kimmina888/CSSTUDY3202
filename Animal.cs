using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSSTUDY3202
{
    public class Animal
    {
        public int Age { get; set; }
        public Animal()
        {
            this.Age = 0;
        }
        public void Eat()
        {
            Console.WriteLine("냠냠 먹겠습니다.");
        }

        public void Sleep()
        {
            Console.WriteLine("쿨쿨 잠을 잡니다.");
        }

    }
}
