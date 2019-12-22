using System;
using System.Collections.Generic;
using AutomaticStation;
using BillingSystem.Data;

namespace Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            #region BS

            Port port = new Port();

            User user = new User(port, "Haidzel", "Iryna", "Ivanovna", "Grodno, st. Belye Rosy", "scorpion_nova@tut.by");

            TarrifePlan tarrifePlan = TarrifePlan.getInstance("budgetary");

            Station station = new Station("Station1", new List<Port>() { port } );

            Agreement agreement = new Agreement("80295861456", user, tarrifePlan, station, "01", Convert.ToDateTime("22.12.2019"), "First agreement!");

            #endregion


            #region AS

            //заключение договора
            agreement.Sign(user, tarrifePlan, station);


            Terminal terminal = new Terminal();

            //соединение абонента
            port.Connect(terminal);
            Console.WriteLine("Успешное подключение к порту!");
            if (port.Status != PortStatus.Busy)
                Console.WriteLine("Порт выключен либо занят!");

            //отсоединение абонента        
            port.Disconnect();
            Console.WriteLine("Успешное отключение от порта!");
            if (port.Status != PortStatus.IsFree)
                Console.WriteLine("Порт не занят или не подключен!");


            //подключение терминала
            terminal.ConnectToPort(port.Id);
            Console.WriteLine("Успешное подключение терминала!");
            if (port.Status != PortStatus.Busy)
                Console.WriteLine("Порт выключен либо занят!");
            
            //отключение терминала
            terminal.DisconnectFromPort();
            Console.WriteLine("Успешное отключение терминала!");
            if (port.Status != PortStatus.IsFree)
                Console.WriteLine("Порт не занят или не подключен!");

            #endregion

            Console.ReadLine();
        }
    }
}
