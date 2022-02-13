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
        //Test RemoveDestination
        //node1.RemoveDestination(node2);
        //node1.RemoveDestination(node2);

        /////////////////////////////////////////////////////
        /////////////////////////////////////////////////////
        // Test AddDestination - post removal
        //node1.AddDestination(node2);

        /////////////////////////////////////////////////////
        /////////////////////////////////////////////////////
        // Test ToString
        //foreach (AirportNode i in node3.Destinations) 
        //{
        //    Console.WriteLine(i.ToString());
        //}

        Console.WriteLine($"\n\nRouteMap Test: \n");
        RouteMapTest();

        // For Future Use
        //AirportNode a1 = new AirportNode("Calgary International Airport", "YYC");
        //AirportNode a2 = new AirportNode("Edmonton International Airport", "YEG");
        //AirportNode a3 = new AirportNode("Fredericton International Airport", "YFC");
        //AirportNode a4 = new AirportNode("Gander International Airport", "YQX");
        //AirportNode a5 = new AirportNode("Halifax Stanfield International Airport", "YHZ");
        //AirportNode a6 = new AirportNode("Greater Moncton Roméo LeBlanc International Airport", "YQM");
        //AirportNode a7 = new AirportNode("Montréal–Trudeau International Airport", "YUL");
        //AirportNode a8 = new AirportNode("Ottawa Macdonald–Cartier International Airport", "YOW");
        //AirportNode a9 = new AirportNode("Québec/Jean Lesage International Airport", "YQB");
        //AirportNode a10 = new AirportNode("St. John's International Airport", "YYT");
        //AirportNode a11 = new AirportNode("Toronto Pearson International Airport", "YYZ");
        //AirportNode a12 = new AirportNode("Vancouver International Airport", "YVR");
        //AirportNode a13 = new AirportNode("Winnipeg International Airport", "YWG");

    }//end Main

    public static void RouteMapTest()
    {
        List<AirportNode> airports = new List<AirportNode>();

        AirportNode node1 = new AirportNode("test1", "3000");
        AirportNode node2 = new AirportNode("test2", "4000");
        AirportNode node3 = new AirportNode("test3", "5000");
        AirportNode node4 = new AirportNode("test4", "6000");
        AirportNode node5 = new AirportNode("test5", "7000");
        AirportNode node6 = new AirportNode("test6", "8000");
        AirportNode node7 = new AirportNode("test7", "9000");
        airports.Add(node1);
        airports.Add(node2);
        airports.Add(node3);
        airports.Add(node4);
        airports.Add(node5);
        airports.Add(node5);
        airports.Add(node6);
        

        RouteMap myRouteMap = new RouteMap(); // initialize Test RouteMap

        ///////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////
        // Test AddAirport
        Console.WriteLine("===================================================================");
        Console.WriteLine("\nAddAirport Test:");
        
        
        foreach (AirportNode a in airports) 
        {



            if (myRouteMap.AddAirport(a) == true)//This need to be Fixed
                Console.WriteLine($"adding airport: {a}");
            myRouteMap.AddAirport(a); //Test AddAirport
            


        }
      
        
        Console.WriteLine("\nPrinting Current RouteMap:");
        Console.WriteLine(myRouteMap.ToString()); // Print Added Airports to Console

        ///////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////
        // Test FindAirportByName and FindAirportByCode
        //Console.WriteLine("===================================================================");
        //Console.WriteLine("\nFindAirportByName Test:");
        //Console.WriteLine($"Find \"test4\": {myRouteMap.FindAirportByName("test4")}");
        //Console.WriteLine($"Find \"test6\": {myRouteMap.FindAirportByName("test6")}");

        //Console.WriteLine("\nFindAirportByCode Test:");
        //Console.WriteLine($"Find \"5000\": {myRouteMap.FindAirportByCode("5000")}");
        //Console.WriteLine($"Find \"2000\": {myRouteMap.FindAirportByCode("2000")}");

        ///////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////
        // Test AddRoute
        //Console.WriteLine("===================================================================");
        //Console.WriteLine("\nAddRoute Test:");
        //myRouteMap.AddRoute(node1, node2);
        //myRouteMap.AddRoute(node2, node3);
        //myRouteMap.AddRoute(node3, node4);
        //myRouteMap.AddRoute(node5, node1);
        //myRouteMap.AddRoute(node2, node4);
        //myRouteMap.AddRoute(node3, node5);
        //myRouteMap.AddRoute(node2, node1);
        //myRouteMap.AddRoute(node4, node2);
        //myRouteMap.AddRoute(node4, node5);
        //myRouteMap.AddRoute(node1, node5);

        //myRouteMap.AddRoute(node1, node1); //you can add itself as a destination?????


        //myRouteMap.AddRoute(node1, node2); // adding the same route again 
        //myRouteMap.AddRoute(new AirportNode("testX", "X000"), node2); // origin doesn't exist
        //myRouteMap.AddRoute(node1, new AirportNode("testX", "X000")); // dest doesn't exist
        //myRouteMap.AddRoute(new AirportNode("testX", "X000"), new AirportNode("testX2", "X200")); // both don't exist

        //Console.WriteLine("\nPrinting Current RouteMap:");
        //Console.WriteLine(myRouteMap.ToString()); // Print Added Airports to Console

        ///////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////
        // Test FastestRoute

        //Console.WriteLine("===================================================================");
        //Console.WriteLine("\nFastestRoute Test: test1 to test3");
        //Console.WriteLine(myRouteMap.FastestRoute(node1, node3)); 

        ///////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////
        // Test RemoveRoute
       // Console.WriteLine("===================================================================");
        //Console.WriteLine("\nRemoveRoute Test:");
        //
        //myRouteMap.RemoveRoute(node1, node2);
        //
        //Console.WriteLine("\nPrinting Current RouteMap - remove test2 (4000) from test1:");
        //Console.WriteLine(myRouteMap.ToString()); // Print Added Airports to Console

        //myRouteMap.RemoveRoute(node4, node2);
        //myRouteMap.RemoveRoute(node4, node5);

        //Console.WriteLine("\nPrinting Current RouteMap - remove all routes from test4");
        //Console.WriteLine(myRouteMap.ToString()); // Print Added Airports to Console

        //myRouteMap.RemoveRoute(node4, node5); // dest already removed

        //Console.WriteLine("\nPrinting Current RouteMap - dest doesn't exist in AirportNode");
        //Console.WriteLine(myRouteMap.ToString()); // Print Added Airports to Console

        //myRouteMap.RemoveRoute(new AirportNode("testX", "X000"), node2); // origin doesn't exist
        //myRouteMap.RemoveRoute(node1, new AirportNode("testX", "X000")); // dest doesn't exist
        //myRouteMap.RemoveRoute(new AirportNode("testX", "X000"), new AirportNode("testX2", "X200")); // both don't exist

        //Console.WriteLine("\nPrinting Current RouteMap - doesn't exist in RouteMap");
        //Console.WriteLine(myRouteMap.ToString()); // Print Added Airports to Console

        ///////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////
        // Test RemoveAirport
        //Console.WriteLine("===================================================================");
        //Console.WriteLine("\nRemoveAirport Test:");
        //
        //Console.WriteLine("\nPrinting Current RouteMap:");
        //Console.WriteLine(myRouteMap.ToString()); // Print Added Airports to Console
        //
        //Console.WriteLine($"{myRouteMap.RemoveAirport(node4)}"); //Remove test4
        //
        //Console.WriteLine("\nPrinting Current RouteMap - test4 (6000) removed:");
        //Console.WriteLine(myRouteMap.ToString()); // Print Added Airports to Console
        //
        //myRouteMap.RemoveAirport(node4); // doesn't exist in RouteMap (just removed)
        //Console.WriteLine($"{myRouteMap.RemoveAirport(node4)}");
        //
        //Console.WriteLine("\nPrinting Current RouteMap - test4 attempted removal again:");
        //Console.WriteLine(myRouteMap.ToString()); // Print Added Airports to Console
        
    }// end RouteMapTest
}

