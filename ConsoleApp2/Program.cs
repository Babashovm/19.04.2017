using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var userObj = new Username("Admin","Admin","p203");
        }
    }

    class Username
    {
        private string username = "Admin";
        private string password = "Admin";
        private string keyword;
        string emr;

        public Username(string _username, string _password,string _keyword)
        {
            Console.WriteLine("Istediyiniz Emrin Kodunu Daxil Edin");
           
            var emr = Console.ReadLine();

            if (emr == "1")
            {
                
                Console.WriteLine("Admin Parolu Yazin");
             _username=Console.ReadLine();
                Console.WriteLine("Parolu Yazin");
              _password=Console.ReadLine();

                if(_username == username && _password == password)
                {
                    Console.WriteLine("Daxil Oldunuz");
                }
                else
                {
                    Console.WriteLine("Melumatlariniz Duzgun Deyil Bir de Yoxla");
                    
                    Console.WriteLine("Admin Parolu Yazin");
                    _username = Console.ReadLine();
                    Console.WriteLine("Parolu Yazin");
                    _password = Console.ReadLine();

                    if (_username == username && _password == password)
                    {
                        Console.WriteLine("Daxil Oldunuz");
                    }
                    else
                    {
                        Console.WriteLine("Melumatlariniz Duzgun Deyil Bir de Yoxla");

                        Console.WriteLine("Admin Parolu Yazin");
                        _username = Console.ReadLine();
                        Console.WriteLine("Parolu Yazin");
                        _password = Console.ReadLine();

                        if (_username == username && _password == password)
                        {
                            Console.WriteLine("Daxil Oldunuz");
                        }
                        else
                        {
                            Console.WriteLine("Melumatlariniz Duzgun Deyil Bir de Yoxla");

                            Console.WriteLine("Admin Parolu Yazin");
                            _username = Console.ReadLine();
                            Console.WriteLine("Parolu Yazin");
                            _password = Console.ReadLine();
                            if (_username == username && _password == password)
                            {
                                Console.WriteLine("Daxil Oldunuz");
                            }
                            else
                            {
                                Console.WriteLine("Blok Oldun:))");
                            }
                        }

                    }
                    
                }

            }
            else if (emr == "2")
            {

                Console.WriteLine("Istifadeci Adi ve Sifremi Unutmusansa?");
                Console.WriteLine("Acar Sozu Daxil Edin");
                var keyword = Console.ReadLine();
                if (keyword == "p203")
                {
                    Console.WriteLine("Sizin Melumatlariniz Bunlardir " + username + " " + password);
                }
                else
                {
                    Console.WriteLine("Sehv Melumatlar Daxil Etdiniz");
                }
            }
            else
            {
                Console.WriteLine("Duzgun Emr Yazmadiniz");
            }
            
            

        }
    }
}
