using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {

            var person = new Person()
            {
                Name = "jack",
                Age = 20,
                Address = new Address()
                {
                    Province = "安徽",
                    City = "安庆"
                }
            };


            //MemoryStream memoryStream = new MemoryStream();
            //BinaryFormatter binaryFormatter = new BinaryFormatter();
            //binaryFormatter.Serialize(memoryStream, person);
            //memoryStream.Seek(0,SeekOrigin.Begin);
            //var person1= (Person)binaryFormatter.Deserialize(memoryStream);

            //memoryStream.Close();

            //Console.WriteLine(person1.Address.City);


            var person2 = (Person)person.Clone();

            person2.Address = (Address)person.Address.Clone();

            Console.WriteLine(person2.Address.City);
            Console.Read();
        }
    }
}
