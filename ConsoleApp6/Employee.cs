using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp6
{
    public class Employee<T>
    {

        public T data;

        public Employee(T _data) {
            data= _data;
            Console.WriteLine("Name is: " + data);
        }

        public void getData(T value)
        {
            Console.WriteLine("Values is: " + value);

        }
    }
}
