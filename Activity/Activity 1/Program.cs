using System;

namespace Activity_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Email = {"Deserie@gmail.com",
                              "Valdez@gmail.com" ,
                              "Placa@gmail.com" };
            string[] Username = {"Deserie",
                                 "Valdez" ,
                                 "Placa"};
            string[] Password = {"Deserie0",
                                 "Valdez1",
                                 "Placa2"};

            Console.Write("Index : ");

            int Index = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Email : " + Email [Index]);
            Console.WriteLine("Username : " + Username [Index]);
            Console.WriteLine("Password : " + Password [Index]);


        }
    }
}