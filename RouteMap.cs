// Team: Greg Prouty, Bradley Primeau, Avery Chin, Megan Risebrough
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class RouteMap
{
    private List<AirportNode> A; // List of airport nodes (adjaceny list)

    // RouteMap: no-arg constructor
    public RouteMap() 
    {
        A = new List<AirportNode>(); // initialize new list of airport nodes (vertexes)

    }// end RouteMap

    // FindAirportByName:
    /// <summary>
    /// Tells the user if an airport exists in the routemap by its name.
    /// </summary>
    /// <param name="name">The name of the airport to find</param>
    /// <returns>True if there exists an AirportNode within A that has the given name. Otherwise, false.</returns>
    public bool FindAirportByName(string name)
    {
        foreach (AirportNode airport in A) // Look through each AirportNode in A
        {
            if (airport.Name == name) // Return true if match is found
            {
                return true;

            }// end if

        }// end foreach

        return false;

    }// end FindAirportByName

    // FindAirportByCode:
    /// <summary>
    /// Tells the user if an airport exists in the routemap by its code.
    /// </summary>
    /// <param name="code">The code of the airport to find</param>
    /// <returns>True if there exists an AirportNode within A that has the given code. Otherwise, false.</returns>
    public bool FindAirportByCode(string code)
    {
        foreach (AirportNode airport in A) // Look through each AirportNode in A
        {
            if (airport.Code == code) // Return true if match is found
            {
                return true;

            }// end if

        }// end foreach

        return false;

    }// end FindAirportByCode

    // AddAirport:
    /// <summary>
    /// If AirportNode, a, does not already exist in List, A, then add it to A and return true. Otherwise, false.
    /// </summary>
    /// <param name="a">The airport to be added</param>
    /// <returns>True if addition occurs, false if airport is not added</returns>
    public bool AddAirport(AirportNode a)
    {
        if (!A.Contains(a)) 
        {
            A.Add(a);
            return true;
        }//end if
        return false;
    }// end AddAirport

    // RemoveAirport:
    /// <summary>
    /// If AirportNode, a, exists in List, A, then remove it from A and return true. Otherwise, false.
    /// If a is removed, then all routes to a will also be removed.
    /// </summary>
    /// <param name="a">The airport to be removed</param>
    /// <returns>True if removal occurs, false if airport is not removed</returns>
    public bool RemoveAirport(AirportNode a)
    {
        if (A.Contains(a))
        {
            A.Remove(a); // remove target from List A

            foreach (AirportNode airport in A) // ensure that all routes to a are also removed
            {
                airport.RemoveDestination(a); 
            }//end foreach

            return true;

        }// end if

        return false;

    }// end RemoveAirport

    // AddRoute:
    /// <summary>
    /// If origin and dest exist within List A, then add dest to origin's List of Destinations and return true. Otherwise, false.
    /// </summary>
    /// <param name="origin">The starting airport of type AirportNode</param>
    /// <param name="dest">The target airport of type AirportNode</param>
    /// <returns>True if addition occurs, false if route is not added</returns>
    public bool AddRoute(AirportNode origin, AirportNode dest)
    {
        if (A.Contains(origin) && A.Contains(dest))
        {
            int index = A.IndexOf(origin); // find index of origin within A
            A[index].AddDestination(dest); // add destination
            return true;
        }//end if

        Console.WriteLine("Error: Either origin or destination or both do not exist within the List");
        return false;
    }// end AddRoute

    // RemoveRoute:
    /// <summary>
    /// If origin and dest exist within List A, then remove dest from origin's List of Destinations and return true. Otherwise, false.
    /// </summary>
    /// <param name="origin">The starting airport of type AirportNode</param>
    /// <param name="dest">The target airport of type AirportNode</param>
    /// <returns>True if removal occurs, false if route is not removed</returns>
    public bool RemoveRoute(AirportNode origin, AirportNode dest)
    {
        if (A.Contains(origin) && A.Contains(dest))
        {
            int index = A.IndexOf(origin); // find index of origin within A
            A[index].RemoveDestination(dest); // remove destination
            return true;
        }// end if

        Console.WriteLine("Error: Either origin or destination or both do not exist within the List");
        return false;
    }// end RemoveRoute

    /// <summary>
    /// Uses a breadth first search to find the shortest path between two given airports
    /// </summary>
    /// <param name="origin">The starting airport of type AirportNode</param>
    /// <param name="dest">The target airport of type AirportNode</param>
    /// <returns>A string containing the shortest route</returns>
    public string FastestRoute (AirportNode origin, AirportNode dest)
    {
        Queue<AirportNode> frontierQueue = new Queue<AirportNode>(); // Queue used to move through the AirportNodes
        List<AirportNode> discoveredSet = new List<AirportNode>(); // List for AirportNodes once they've been discovered
        AirportNode currentAirport; // Used to keep track of the current AirportNode
        string route = ""; // String to be added to and returned containing the route

        frontierQueue.Enqueue(origin); // Enqueue the starting AirportNode
        discoveredSet.Add(origin); // Add the starting airport to the discovered ones

        while (frontierQueue.Count > 0) // While there is another airport to check
        {
            currentAirport = frontierQueue.Dequeue(); 

            if (currentAirport == null)
            {
                return "An error occurred";
            }

            if (currentAirport == dest) // If the current airport is the one we want, stop and return the route
            {
                route = route + currentAirport.Name + ":" + currentAirport.Code;
                return route;
            }
            else
            {
                route = route + currentAirport.Name + ":" + currentAirport.Code + " -> "; // Add the current airport to the route
                foreach (AirportNode adjA in currentAirport.Destinations) { // Check each destination airport from current airport
                    if (!(discoveredSet.Contains(adjA))) // If destination airport has not been discovered, discover it
                    {
                        frontierQueue.Enqueue(adjA);
                        discoveredSet.Add(adjA);
                    }
                }
            }
        }
        return "An error occurred";
    }// End FastestRoute

    /// <summary>
    /// Used to print out the route map in a nice format.
    /// </summary>
    /// <returns>A string listing the airports in the routemap an their destinations</returns>
    public override string ToString()
    {
        string airportList = "";
        int index = 0;

        foreach(AirportNode airport in A)
        {
            airportList += $"[{index}] {airport.ToString()}\n";
            index++;
        }

        return airportList;
    }
}
