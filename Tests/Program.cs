using System;
using System.Collections.Generic;
using AutomaticStation;
using BillingSystem.Data;
using BillingSystem.Collections;
using Reports;

namespace Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 звонок


            #region BS

            Port port = new Port();

            User user = new User(port, "Haidzel", "Iryna", "Ivanovna", "Grodno, st. Belye Rosy", "scorpion_nova@tut.by");

            TarrifePlan tarrifePlan = TarrifePlan.getInstance("budgetary");

            Station station = new Station("Station1", new List<Port>() { port } );

            Agreement agreement = new Agreement("80295861456", user, tarrifePlan, station, "01", DateTime.Now, "First agreement!");

            #endregion


            #region AS

            //заключение договора
            agreement.Sign(user, tarrifePlan, station);


            Terminal terminal = new Terminal();

            ////соединение абонента
            //port.Connect(terminal);
            //if (port.Status == PortStatus.Busy)
            //    Console.WriteLine("Успешное подключение к порту!");
            //else
            //    Console.WriteLine("Порт выключен либо занят!");

            ////отсоединение абонента        
            //port.Disconnect();
            //if (port.Status == PortStatus.IsFree)
            //    Console.WriteLine("Успешное отключение от порта!");
            //else
            //    Console.WriteLine("Порт не занят или не подключен!");


            Phone phone = new Phone("1111");

            //подключение терминала
            terminal.terminalController.ConnectToPort(terminal,port);
            if (port.Status == PortStatus.Busy)
                Console.WriteLine("Успешное подключение терминала!");
            else
                Console.WriteLine("Порт выключен либо занят!");

            //запись в коллекцию callHistorytItems инфы о звонке
            CallHistory callHistory = new CallHistory(DateTime.Now, new Phone(agreement.PhoneNumber), phone, new TimeSpan(), 5,user);
            UnityCollections.callHistorytItems.Add(callHistory);

            //отключение терминала
            terminal.terminalController.DisconnectFromPort();
            if (port.Status == PortStatus.Free)
                Console.WriteLine("Успешное отключение терминала!");
            else
                Console.WriteLine("Порт не занят или не подключен!");

            #endregion



            // 2 звонок


            #region BS

            station = new Station("Station2", new List<Port>() { port });

            agreement = new Agreement("80295861457", user, tarrifePlan, station, "01", DateTime.Now, "Second agreement!");

            #endregion


            #region AS

            //заключение договора
            agreement.Sign(user, tarrifePlan, station);


            terminal = new Terminal();

            ////соединение абонента
            //port.Connect(terminal);
            //if (port.Status == PortStatus.Busy)
            //    Console.WriteLine("Успешное подключение к порту!");
            //else
            //    Console.WriteLine("Порт выключен либо занят!");

            ////отсоединение абонента        
            //port.Disconnect();
            //if (port.Status == PortStatus.IsFree)
            //    Console.WriteLine("Успешное отключение от порта!");
            //else
            //    Console.WriteLine("Порт не занят или не подключен!");


            phone = new Phone("2222");

            //подключение терминала
            terminal.terminalController.ConnectToPort(terminal, port);
            if (port.Status == PortStatus.Busy)
                Console.WriteLine("Успешное подключение терминала!");
            else
                Console.WriteLine("Порт выключен либо занят!");

            //запись в коллекцию callHistorytItems инфы о звонке
            callHistory = new CallHistory(DateTime.Now, new Phone(agreement.PhoneNumber), phone, new TimeSpan(), 10, user);
            UnityCollections.callHistorytItems.Add(callHistory);

            //отключение терминала
            terminal.terminalController.DisconnectFromPort();
            if (port.Status == PortStatus.Free)
                Console.WriteLine("Успешное отключение терминала!");
            else
                Console.WriteLine("Порт не занят или не подключен!");

            #endregion



            // 3 звонок


            #region BS

            port = new Port();

            user = new User(port, "Haidzel", "Lev", "Alekseevich", "Grodno, st. Belye Rosy", "scorpion_nova@mail.ru");

            agreement = new Agreement("80295861458", user, tarrifePlan, station, "03", DateTime.Now, "Third agreement!");

            #endregion


            #region AS

            //заключение договора
            agreement.Sign(user, tarrifePlan, station);


            terminal = new Terminal();

            ////соединение абонента
            //port.Connect(terminal);
            //if (port.Status == PortStatus.Busy)
            //    Console.WriteLine("Успешное подключение к порту!");
            //else
            //    Console.WriteLine("Порт выключен либо занят!");

            ////отсоединение абонента        
            //port.Disconnect();
            //if (port.Status == PortStatus.IsFree)
            //    Console.WriteLine("Успешное отключение от порта!");
            //else
            //    Console.WriteLine("Порт не занят или не подключен!");


            phone = new Phone("3333");

            //подключение терминала
            terminal.terminalController.ConnectToPort(terminal, port);
            if (port.Status == PortStatus.Busy)
                Console.WriteLine("Успешное подключение терминала!");
            else
                Console.WriteLine("Порт выключен либо занят!");

            //запись в коллекцию callHistorytItems инфы о звонке
            callHistory = new CallHistory(DateTime.Now, new Phone(agreement.PhoneNumber), phone, new TimeSpan(), 15, user);
            UnityCollections.callHistorytItems.Add(callHistory);

            //отключение терминала
            terminal.terminalController.DisconnectFromPort();
            if (port.Status == PortStatus.Free)
                Console.WriteLine("Успешное отключение терминала!");
            else
                Console.WriteLine("Порт не занят или не подключен!");

            #endregion


            #region report

            Reports.Report_Excel.ReportForExcel(UnityCollections.callHistorytItems);

            #endregion

            //

            Console.ReadLine();
        }
    }
}
