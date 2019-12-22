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
            Port port = new Port();

            User user = new User(port, "Haidzel", "Iryna", "Ivanovna", "Grodno, st. Belye Rosy", "scorpion_nova@tut.by");

            TarrifePlan tarrifePlan = TarrifePlan.getInstance("budgetary");

            Station station = new Station("Station1", new List<Port>() { port } );

            Agreement agreement = new Agreement("80295861456", user, tarrifePlan, station, "01", "22.12.2019", "First agreement!");

        }
    }
}
