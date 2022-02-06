// Team: Greg Prouty, Bradley Primeau, Avery Chin, Megan Risebrough
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class TestMain 
{
    static void Main()
    {
        
        AirportNode node1 = new AirportNode("test1", "3000");
        AirportNode node2 = new AirportNode("test2", "4000");
        AirportNode node3 = new AirportNode("test3", "5000");
        AirportNode node4 = new AirportNode("test4", "6000");
        AirportNode node5 = new AirportNode("test5", "7000");

        /////////////////////////////////////////////////////
        /////////////////////////////////////////////////////
        /// Test AddDestination
        node1.AddDestination(node2);
        node1.AddDestination(node3);
        node1.AddDestination(node5);
        node2.AddDestination(node1);
        node1.AddDestination(node2);
        node1.AddDestination(node2);

        /////////////////////////////////////////////////////
        /////////////////////////////////////////////////////
        // Test RemoveDestination
        node1.RemoveDestination(node2);
        node1.RemoveDestination(node2);

        /////////////////////////////////////////////////////
        /////////////////////////////////////////////////////
        // Test AddDestination - post removal
        node1.AddDestination(node2);

        /////////////////////////////////////////////////////
        /////////////////////////////////////////////////////
        // Test ToString
        foreach (AirportNode i in node1.Destinations) 
        {
            Console.WriteLine(i.ToString());
        }

        Console.WriteLine($"\n\nRouteMap Test: \n");
        RouteMapTest();
    }

    public static void RouteMapTest()
    {
        List<AirportNode> airports = new List<AirportNode>();

        AirportNode node1 = new AirportNode("test1", "3000");
        AirportNode node2 = new AirportNode("test2", "4000");
        AirportNode node3 = new AirportNode("test3", "5000");
        AirportNode node4 = new AirportNode("test4", "6000");
        AirportNode node5 = new AirportNode("test5", "7000");
        airports.Add(node1);
        airports.Add(node2);
        airports.Add(node3);
        airports.Add(node4);
        airports.Add(node5);

        RouteMap myRouteMap = new RouteMap(); // initialize Test RouteMap

        ///////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////
        // Test AddAirport
        Console.WriteLine("===================================================================");
        Console.WriteLine("\nAddAirport Test:");

        foreach (AirportNode a in airports) 
        {
            Console.WriteLine($"adding airport: {a.Name}");
            myRouteMap.AddAirport(a); //Test AddAirport
        }
        Console.WriteLine("\nPrinting Current RouteMap:");
        Console.WriteLine(myRouteMap.ToString()); // Print Added Airports to Console

        ///////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////
        // Test FindAirportByName and FindAirportByCode
        Console.WriteLine("===================================================================");
        Console.WriteLine("\nFindAirportByName Test:");
        Console.WriteLine($"Find \"test4\": {myRouteMap.FindAirportByName("test4")}");
        Console.WriteLine($"Find \"test6\": {myRouteMap.FindAirportByName("test6")}");

        Console.WriteLine("\nFindAirportByCode Test:");
        Console.WriteLine($"Find \"5000\": {myRouteMap.FindAirportByCode("5000")}");
        Console.WriteLine($"Find \"2000\": {myRouteMap.FindAirportByCode("2000")}");

        ///////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////
        // Test AddRoute
        Console.WriteLine("===================================================================");
        Console.WriteLine("\nAddRoute Test:");
        myRouteMap.AddRoute(node1, node2);
        myRouteMap.AddRoute(node2, node3);
        myRouteMap.AddRoute(node3, node4);
        myRouteMap.AddRoute(node5, node1);
        myRouteMap.AddRoute(node2, node4);
        myRouteMap.AddRoute(node3, node5);
        myRouteMap.AddRoute(node2, node1);
        myRouteMap.AddRoute(node4, node2);
        myRouteMap.AddRoute(node4, node5);
        myRouteMap.AddRoute(node1, node5);

        myRouteMap.AddRoute(node1, node1); //you can add itself as a destination?????


        myRouteMap.AddRoute(node1, node2); // adding the same route again 
        myRouteMap.AddRoute(new AirportNode("testX", "X000"), node2); // origin doesn't exist
        myRouteMap.AddRoute(node1, new AirportNode("testX", "X000")); // dest doesn't exist
        myRouteMap.AddRoute(new AirportNode("testX", "X000"), new AirportNode("testX2", "X200")); // both don't exist

        Console.WriteLine("\nPrinting Current RouteMap:");
        Console.WriteLine(myRouteMap.ToString()); // Print Added Airports to Console

        ///////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////
        // Test FastestRoute
        Console.WriteLine(myRouteMap.FastestRoute(node1, node3)); 

        ///////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////
        // Test RemoveRoute
        Console.WriteLine("===================================================================");
        Console.WriteLine("\nRemoveRoute Test:");

        myRouteMap.RemoveRoute(node1, node2);

        Console.WriteLine("\nPrinting Current RouteMap - remove test2 (4000) from test1:");
        Console.WriteLine(myRouteMap.ToString()); // Print Added Airports to Console

        myRouteMap.RemoveRoute(node4, node2);
        myRouteMap.RemoveRoute(node4, node5);

        Console.WriteLine("\nPrinting Current RouteMap - remove all routes from test4");
        Console.WriteLine(myRouteMap.ToString()); // Print Added Airports to Console

        myRouteMap.RemoveRoute(node4, node5); // dest already removed

        Console.WriteLine("\nPrinting Current RouteMap - dest doesn't exist in AirportNode");
        Console.WriteLine(myRouteMap.ToString()); // Print Added Airports to Console

        myRouteMap.RemoveRoute(new AirportNode("testX", "X000"), node2); // origin doesn't exist
        myRouteMap.RemoveRoute(node1, new AirportNode("testX", "X000")); // dest doesn't exist
        myRouteMap.RemoveRoute(new AirportNode("testX", "X000"), new AirportNode("testX2", "X200")); // both don't exist

        Console.WriteLine("\nPrinting Current RouteMap - doesn't exist in RouteMap");
        Console.WriteLine(myRouteMap.ToString()); // Print Added Airports to Console

        ///////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////
        // Test RemoveAirport
        Console.WriteLine("===================================================================");
        Console.WriteLine("\nRemoveAirport Test:");

        Console.WriteLine("\nPrinting Current RouteMap:");
        Console.WriteLine(myRouteMap.ToString()); // Print Added Airports to Console

        Console.WriteLine($"{myRouteMap.RemoveAirport(node4)}"); //Remove test4

        Console.WriteLine("\nPrinting Current RouteMap - test4 (6000) removed:");
        Console.WriteLine(myRouteMap.ToString()); // Print Added Airports to Console

        myRouteMap.RemoveAirport(node4); // doesn't exist in RouteMap (just removed)
        Console.WriteLine($"{myRouteMap.RemoveAirport(node4)}");

        Console.WriteLine("\nPrinting Current RouteMap - test4 attempted removal again:");
        Console.WriteLine(myRouteMap.ToString()); // Print Added Airports to Console














    }
}

