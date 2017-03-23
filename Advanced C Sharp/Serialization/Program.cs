using Newtonsoft.Json;
using System;

namespace Serialization
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee
            {
                Id = 1,
                Name = "Promact",
                Email = "Promact@promactinfo.com",
                MobileNo = "999999999"
            };

            var serializedObject = JsonConvert.SerializeObject(employee);

            Console.WriteLine(serializedObject);

            var deSerializedObject = JsonConvert.DeserializeObject<Employee>(serializedObject);


            Console.Read();

        }
    }
}
