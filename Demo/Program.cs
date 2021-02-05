using System;
using StopParkAPI;
using System.IO.Ports;
namespace Demo
{
    class Program
    {
       
        static void Main(string[] args)
        {
            API aPI = new API();

            //setting the parking ip address
            aPI.Address = "192.168.31.249";
            //setting the parking port
            aPI.Port = 101;
            //executing a sql command and getting the result
            var responce = aPI.ManDataDB("Select TimeIn From Ticket");
            Console.WriteLine(responce);


            
            string uid1 = "0492387A662180";
            string uid2 = "0437117A662180";
            string uid3 = "044F75B2792280";
            string uid4 = "047F7C12374E80";
            string uid5 = "00000016D86912";



            //convert uid card mifare
            var res = aPI.ConvertMifare(uid5);
            Console.WriteLine(res);
            Console.ReadLine();
        }

       
    }
}
