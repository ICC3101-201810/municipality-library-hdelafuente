using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;
using ClassLibrary1;
using System.Runtime.Serialization.Formatters.Binary;

namespace lab10
{
    class Program
    {
            public static void Serializar1(List<Person> lista_locales, string archivo)
            {
                try
                {
                    string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\" + archivo);
                    using (Stream stream = File.Open(path, FileMode.Create))
                    {
                        BinaryFormatter bin = new BinaryFormatter();
                        bin.Serialize(stream, lista_locales);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            public static List<Person> Deserializar1(string archivo)
            {
                List<Person> locales;
                try
                {
                    string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\" + archivo);
                    using (Stream stream = File.Open(path, FileMode.Open))
                    {
                        BinaryFormatter bin = new BinaryFormatter();

                        locales = (List<Person>)bin.Deserialize(stream);
                    }
                    return locales;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    return null;
                }
            }

        public static void Serializar2(List<Address> lista_locales, string archivo)
        {
            try
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\" + archivo);
                using (Stream stream = File.Open(path, FileMode.Create))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    bin.Serialize(stream, lista_locales);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static List<Address> Deserializar2(string archivo)
        {
            List<Address> locales;
            try
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\" + archivo);
                using (Stream stream = File.Open(path, FileMode.Open))
                {
                    BinaryFormatter bin = new BinaryFormatter();

                    locales = (List<Address>)bin.Deserialize(stream);
                }
                return locales;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
        public static void Serializar3(List<Car> lista_locales, string archivo)
        {
            try
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\" + archivo);
                using (Stream stream = File.Open(path, FileMode.Create))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    bin.Serialize(stream, lista_locales);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static List<Car> Deserializar3(string archivo)
        {
            List<Car> locales;
            try
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\" + archivo);
                using (Stream stream = File.Open(path, FileMode.Open))
                {
                    BinaryFormatter bin = new BinaryFormatter();

                    locales = (List<Car>)bin.Deserialize(stream);
                }
                return locales;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }





        static void Main(string[] args)
        {
            //Assembly info = Assembly.LoadFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\ClassLibrary1"));
            List<Person> lista1 = new List<Person>();
            List<Car> lista2 = new List<Car>();
            List<Address> lista3 = new List<Address>();
            Console.WriteLine("1. Inscribir Persona\n" +
                "2. Inscribir Propiedad\n" +
                "3. Inscribir Vehiculo\n");
            Console.Write("Opcion: ");
            string opc = Console.ReadLine();
            if (opc == "1" )
            {
                Console.Write("Nombre: ");
                string name = Console.ReadLine();
                Console.Write("Apellido: ");
                string last_name = Console.ReadLine();
                fecha:
                Console.Write("Fecha de nacimiento(aaaa/mm/dd): ");
                string algo = Console.ReadLine();
                try
                {
                    DateTime bdate = Convert.ToDateTime(algo);
                }
                catch(Exception e)
                {
                    Console.WriteLine("No cumple con el formato! (aaaa/mm/dd)");
                    goto fecha;
                }
                DateTime algo2 = Convert.ToDateTime(algo);
                Console.Write("Alma Mater: ");
                string alma_mater = Console.ReadLine();
                Console.Write("Grado profesional: ");
                string degree = Console.ReadLine();
                Console.Write("Rut: ");
                string rut = Console.ReadLine();
                Person add = new Person(name, last_name, algo2, null, rut, null, null);
                lista1.Add(add);
                Console.WriteLine(add.First_name + " " + add.Alma_mater);


            }
            else if (opc == "2")
            {
                Console.Write("Calle: ");
                string street = Console.ReadLine();
                Console.Write("Numero: ");
                int number = Convert.ToInt32(Console.ReadLine());
                Console.Write("Comuna: ");
                string comuna = Console.ReadLine();
                Console.Write("Ciudad: ");
                string city = Console.ReadLine();
                Console.Write("Año de construccion: ");
                int year = Convert.ToInt32(Console.ReadLine());
                Console.Write("Nro de habitaciones: ");
                int bedrooms = Convert.ToInt32(Console.ReadLine());
                Console.Write("Nro de baños: ");
                int baths = Convert.ToInt32(Console.ReadLine());
                Console.Write("Patio?(1.si, 2.no");
                bool backyard = false;
                string b = Console.ReadLine();
                if (b=="1")
                {
                    backyard = true;
                }

                Console.Write("Piscina?(1.si, 2.no");
                bool pool = false;
                string c = Console.ReadLine();
                if (c == "1")
                {
                    backyard = true;
                }

                Address ne = new Address(street, number, comuna, city, null, year, bedrooms, baths, backyard, pool);
                lista3.Add(ne);

            }

            else if (opc == "3")
            {
                Console.Write("Marca: ");
                string marca = Console.ReadLine();
                Console.Write("Modelo: ");
                string model = Console.ReadLine();
                Console.Write("Año del auto: ");
                int year = Convert.ToInt32(Console.ReadLine());
                Console.Write("Nro de habitaciones: ");
                string patente = Console.ReadLine();
                Console.Write("Nro de baños: ");
                int cinturones = Convert.ToInt32(Console.ReadLine());
                Console.Write("Diesel?(1.si, 2.no");
                bool diesel = false;
                string b = Console.ReadLine();
                if (b == "1")
                {
                    diesel = true;
                }
                Car ne = new Car(marca, model, year, null, patente, cinturones, diesel);
                lista2.Add(ne);

            }
            Serializar1(lista1, "personas.bin");
            Serializar2(lista3, "direcciones.bin");
            Serializar3(lista2, "autos.bin");

            Console.ReadKey();
        }
    }
}
