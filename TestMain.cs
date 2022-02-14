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
        List<AirportNode> airports = new List<AirportNode>();

        // Creating the Canadian AirportNodes
        AirportNode a1 = new AirportNode("Calgary International Airport", "YYC");
        AirportNode a2 = new AirportNode("Edmonton International Airport", "YEG");
        AirportNode a3 = new AirportNode("Fredericton International Airport", "YFC");
        AirportNode a4 = new AirportNode("Gander International Airport", "YQX");
        AirportNode a5 = new AirportNode("Halifax Stanfield International Airport", "YHZ");
        AirportNode a6 = new AirportNode("Greater Moncton Roméo LeBlanc International Airport", "YQM");
        AirportNode a7 = new AirportNode("Montréal–Trudeau International Airport", "YUL");
        AirportNode a8 = new AirportNode("Ottawa Macdonald–Cartier International Airport", "YOW");
        AirportNode a9 = new AirportNode("Québec/Jean Lesage International Airport", "YQB");
        AirportNode a10 = new AirportNode("St. John's International Airport", "YYT");
        AirportNode a11 = new AirportNode("Toronto Pearson International Airport", "YYZ");
        AirportNode a12 = new AirportNode("Vancouver International Airport", "YVR");
        AirportNode a13 = new AirportNode("Winnipeg International Airport", "YWG");

        airports.Add(a1);
        airports.Add(a2);
        airports.Add(a3);
        airports.Add(a4);
        airports.Add(a5);
        airports.Add(a6);
        airports.Add(a7);
        airports.Add(a8);
        airports.Add(a9);
        airports.Add(a10);
        airports.Add(a11);
        airports.Add(a12);
        airports.Add(a13);
        airports.Add(a13);


        /////////////////////////////////////////////////////
        /////////////////////////////////////////////////////
        /// Test AddDestination
        //Console.WriteLine("Testing AddDestination:");
        //a1.AddDestination(a1);
        //a1.AddDestination(a2);
        //a1.AddDestination(a3);
        //a1.AddDestination(a5);
        //a2.AddDestination(a1);
        //Console.WriteLine(a1.ToString());
        //Console.WriteLine(a2.ToString());
        //a1.AddDestination(a2);

        /////////////////////////////////////////////////////
        /////////////////////////////////////////////////////
        //Test RemoveDestination
        //Console.WriteLine("\nTesting removeDestination:");
        //a1.AddDestination(a2);
        //Console.WriteLine(a1.ToString());
        //a1.RemoveDestination(a2);
        //Console.WriteLine(a1.ToString());
        //a1.RemoveDestination(a2);

        /////////////////////////////////////////////////////
        /////////////////////////////////////////////////////
        // Test AddDestination - post removal
        //Console.WriteLine("\nTesting addDestination after removing that destination:");
        //a1.AddDestination(a2);

        /////////////////////////////////////////////////////
        /////////////////////////////////////////////////////
        // Test ToString
        /*Console.WriteLine("\nTesting ToString:");
        foreach (AirportNode i in a1.Destinations) 
        {
            Console.WriteLine(i.ToString());
        }*/

        Console.WriteLine($"\n\nRouteMap Test: \n");

        RouteMap myRouteMap = new RouteMap(); // initialize Test RouteMap

        ///////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////
        // Test AddAirport
        Console.WriteLine("===================================================================");
        Console.WriteLine("\nAddAirport Test:");


        foreach (AirportNode a in airports)
        {
            if (myRouteMap.AddAirport(a) == true) 
                Console.WriteLine($"Adding airport: {a}");
            else 
                Console.WriteLine($"Error: Airport is already in the route map.");
        }


        Console.WriteLine("\nPrinting Current RouteMap:");
        Console.WriteLine(myRouteMap.ToString()); // Print Added Airports to Console

        ///////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////
        // Test FindAirportByName and FindAirportByCode
        //Console.WriteLine("===================================================================");
        /*Console.WriteLine("\nFindAirportByName Test:");
        Console.WriteLine($"Find \"Gander International Airport\": {myRouteMap.FindAirportByName("Gander International Airport")}");
        Console.WriteLine($"Find \"Vancouver International Airport\": {myRouteMap.FindAirportByName("Vancouver International Airport")}");
        Console.WriteLine($"Find \"Airport\": {myRouteMap.FindAirportByName("Airport")}");
        Console.WriteLine($"Find \"YFC\": {myRouteMap.FindAirportByName("YFC")}");*/

        /*Console.WriteLine("\nFindAirportByCode Test:");
        Console.WriteLine($"Find \"YYC\": {myRouteMap.FindAirportByCode("YYC")}");
        Console.WriteLine($"Find \"YFC\": {myRouteMap.FindAirportByCode("YFC")}");
        Console.WriteLine($"Find \"ABC\": {myRouteMap.FindAirportByCode("ABC")}");
        Console.WriteLine($"Find \"Vancouver International Airport\": {myRouteMap.FindAirportByCode("Vancouver International Airport")}");*/

        ///////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////
        // Test AddRoute
        Console.WriteLine("===================================================================");
        Console.WriteLine("\nAddRoute Test:");
        myRouteMap.AddRoute(a1, a3);
        myRouteMap.AddRoute(a1, a9);
        myRouteMap.AddRoute(a1, a11);
        myRouteMap.AddRoute(a1, a12);
        myRouteMap.AddRoute(a2, a4);
        myRouteMap.AddRoute(a2, a8);
        myRouteMap.AddRoute(a3, a2);
        myRouteMap.AddRoute(a3, a10);
        myRouteMap.AddRoute(a3, a13);
        myRouteMap.AddRoute(a4, a12);
        myRouteMap.AddRoute(a4, a6);
        myRouteMap.AddRoute(a5, a11);
        myRouteMap.AddRoute(a6, a13);
        myRouteMap.AddRoute(a6, a8);
        myRouteMap.AddRoute(a7, a12);
        myRouteMap.AddRoute(a8, a1);
        myRouteMap.AddRoute(a8, a5);
        myRouteMap.AddRoute(a9, a11);
        myRouteMap.AddRoute(a9, a4);
        myRouteMap.AddRoute(a10, a2);
        myRouteMap.AddRoute(a10, a12);
        myRouteMap.AddRoute(a11, a4);
        myRouteMap.AddRoute(a11, a1);
        myRouteMap.AddRoute(a11, a3);
        myRouteMap.AddRoute(a11, a13);
        myRouteMap.AddRoute(a11, a12);
        myRouteMap.AddRoute(a12, a10);
        myRouteMap.AddRoute(a12, a1);
        myRouteMap.AddRoute(a12, a11);
        myRouteMap.AddRoute(a13, a11);
        myRouteMap.AddRoute(a13, a12);

        Console.WriteLine("\nPrinting Current RouteMap:");
        Console.WriteLine(myRouteMap.ToString()); // Print Added Airports to Console

        /*myRouteMap.AddRoute(a1, a1);
        myRouteMap.AddRoute(a1, a3); // adding the same route again 
        myRouteMap.AddRoute(new AirportNode("testX", "X000"), a2); // origin doesn't exist
        myRouteMap.AddRoute(a1, new AirportNode("testX", "X000")); // dest doesn't exist
        myRouteMap.AddRoute(new AirportNode("testX", "X000"), new AirportNode("testX2", "X200")); // both don't exist
        */

        ///////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////
        // Test RemoveRoute
        // Console.WriteLine("===================================================================");
        //Console.WriteLine("\nRemoveRoute Test:");
        //
        //myRouteMap.RemoveRoute(a1, a3);
        //
        //Console.WriteLine("\nPrinting Current RouteMap - remove Fredericton (YFC) from Calgary:");
        //Console.WriteLine(myRouteMap.ToString()); // Print Added Airports to Console

        //myRouteMap.RemoveRoute(a4, a12);
        //myRouteMap.RemoveRoute(a4, a6);

        //Console.WriteLine("\nPrinting Current RouteMap - remove all routes from Gander International Airport");
        //Console.WriteLine(myRouteMap.ToString()); // Print Added Airports to Console

        //myRouteMap.RemoveRoute(a4, a12);
        //myRouteMap.RemoveRoute(a4, a12); // dest already removed

        //Console.WriteLine("\nPrinting Current RouteMap - dest doesn't exist in AirportNode");
        //Console.WriteLine(myRouteMap.ToString()); // Print Added Airports to Console

        //myRouteMap.RemoveRoute(new AirportNode("testX", "X000"), a2); // origin doesn't exist
        //myRouteMap.RemoveRoute(a1, new AirportNode("testX", "X000")); // dest doesn't exist
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
        //Console.WriteLine($"{myRouteMap.RemoveAirport(a4)}"); //Remove a4
        //
        //Console.WriteLine("\nPrinting Current RouteMap - Gander International Airport (YQX) removed:");
        //Console.WriteLine(myRouteMap.ToString()); // Print
        //
        //myRouteMap.RemoveAirport(a4); // doesn't exist in RouteMap (just removed)
        //Console.WriteLine("\nPrinting Current RouteMap - Gander International Airport (YQX) attempted removal again:");
        //Console.WriteLine($"{myRouteMap.RemoveAirport(a4)}");
        //
        //Console.WriteLine(myRouteMap.ToString()); // Print 

        ///////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////
        // Test FastestRoute

        //Console.WriteLine("===================================================================");
        //Console.WriteLine("\nFastestRoute Test: Calgary to Edmonton");
        //myRouteMap.RemoveRoute(a1, a3);
        //Console.WriteLine(myRouteMap.FastestRoute(a1, a2));

        //Console.WriteLine("\nFastestRoute Test: Calgary to Winnipeg");
        //Console.WriteLine(myRouteMap.FastestRoute(a1, a13)); // More than one fastest route

        /*
        myRouteMap.RemoveRoute(a2,a8);
        myRouteMap.RemoveRoute(a4, a12);
        myRouteMap.RemoveRoute(a6, a8);
        myRouteMap.RemoveRoute(a6, a13);

        Console.WriteLine("\nFastestRoute Test: Calgary to Winnipeg");
        Console.WriteLine(myRouteMap.FastestRoute(a2, a13)); // No route
        */

        /*Console.WriteLine("\nFastestRoute Test: Non-existent Airports");
        Console.WriteLine(myRouteMap.FastestRoute(new AirportNode("testX", "X000"), a2)); // origin doesn't exist
        Console.WriteLine(myRouteMap.FastestRoute(a1, new AirportNode("testX", "X000"))); // dest doesn't exist
        Console.WriteLine(myRouteMap.FastestRoute(new AirportNode("testX", "X000"), new AirportNode("testX2", "X200"))); // both don't exist
        */
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
                Console.WriteLine($"Adding airport: {a}");
            else
            {
                Console.WriteLine($"Error: Airport is already in the route map.");
            }

        }
      
        
        Console.WriteLine("\nPrinting Current RouteMap:");
        Console.WriteLine(myRouteMap.ToString()); // Print Added Airports to Console

        ///////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////
        // Test FindAirportByName and FindAirportByCode
        //Console.WriteLine("===================================================================");
        //Console.WriteLine("\nFindAirportByName Test:");
        //Console.WriteLine($"Find \"Winnipeg International Airport\": {myRouteMap.FindAirportByName("Winnipeg International Airport")}");
        //Console.WriteLine($"Find \"Winnipeg Airport\": {myRouteMap.FindAirportByName("Winnipeg Airport")}");

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

