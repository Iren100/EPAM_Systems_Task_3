using System;
using AutomaticStation;
using BillingSystem.Data;
using BillingSystem.Collections;

namespace Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 звонок


            #region BS1

            Station station = new Station("Station1");

            Port port = new Port(station);

            User user = new User(port, "Haidzel", "Iryna", "Ivanovna", "Grodno, st. Belye Rosy", "scorpion_nova@tut.by");

            TarrifePlan tarrifePlan = TarrifePlan.getInstance("budgetary");

         
            Agreement agreement = new Agreement("80295861456", user, tarrifePlan, station, "01", DateTime.Now, "First agreement!");

            #endregion


            #region AS1

            //заключение договора
            agreement.Sign(user, tarrifePlan, station);


            Phone phone = new Phone("1111");
            Terminal terminal = new Terminal(phone);

            //подключение терминала
            terminal.TerminalController.ConnectToPort(terminal,port);
            if (port.Status == PortStatus.Busy)
                Console.WriteLine("Успешное подключение терминала!");
            else
                Console.WriteLine("Порт выключен либо занят!");

            //запись в коллекцию callHistorytItems инфы о звонке
            CallHistory callHistory = new CallHistory(DateTime.Now, new Phone(agreement.PhoneNumber), phone, new TimeSpan(0,1,10), 5,user);
            UnityCollections.callHistorytItems.Add(callHistory);

            //отключение терминала
            terminal.TerminalController.DisconnectFromPort();

            print(port.Status);

            #endregion



            // 2 звонок


            #region BS2

            station = new Station("Station2");

            agreement = new Agreement("80295861457", user, tarrifePlan, station, "01", DateTime.Now, "Second agreement!");

            #endregion


            #region AS2

            //заключение договора
            agreement.Sign(user, tarrifePlan, station);

            phone = new Phone("2222");
            terminal = new Terminal(phone);

            //подключение терминала
            terminal.TerminalController.ConnectToPort(terminal, port);

            print(port.Status);

            //запись в коллекцию callHistorytItems инфы о звонке
            callHistory = new CallHistory(DateTime.Now, new Phone(agreement.PhoneNumber), phone, new TimeSpan(0, 2, 20), 10, user);
            UnityCollections.callHistorytItems.Add(callHistory);

            //отключение терминала
            terminal.TerminalController.DisconnectFromPort();

            print(port.Status);

            #endregion



            // 3 звонок


            #region BS3

            //port = new Port();

            user = new User(port, "Haidzel", "Lev", "Alekseevich", "Grodno, st. Belye Rosy", "scorpion_nova@mail.ru");

            agreement = new Agreement("80295861458", user, tarrifePlan, station, "03", DateTime.Now, "Third agreement!");

            #endregion


            #region AS3

            //заключение договора
            agreement.Sign(user, tarrifePlan, station);

            phone = new Phone("3333");
            terminal = new Terminal(phone);

            //подключение терминала
            terminal.TerminalController.ConnectToPort(terminal, port);
            print(port.Status);

            //запись в коллекцию callHistorytItems инфы о звонке
            callHistory = new CallHistory(DateTime.Now, new Phone(agreement.PhoneNumber), phone, new TimeSpan(0, 3, 300), 15, user);
            UnityCollections.callHistorytItems.Add(callHistory);

            //отключение терминала
            terminal.TerminalController.DisconnectFromPort();
           

            #endregion


            #region report

            Reports.ReportUtility.ReportForExcel(UnityCollections.callHistorytItems);

            #endregion

            //

            Console.WriteLine("Открыть отчет xlsx? Y");

            if (Console.ReadKey().Key == ConsoleKey.Y)
            {
                Reports.ReportUtility.ShowXlsx();
            }

            Console.ReadLine();
        }

        private static void print(PortStatus portStatus)
        {
            switch (portStatus)
                {
                case PortStatus.Busy:
                    Console.WriteLine("Успешное подключение терминала!");
                    break;
                case PortStatus.Free:
                    Console.WriteLine("Успешное отключение терминала!");
                    break;
                case (PortStatus.Free|PortStatus.TurnOff):
                    Console.WriteLine("Порт не занят или не подключен!");
                    break;
                default:
                    Console.WriteLine("Порт выключен либо занят!");
                    break;
            }
        }
    }
}
