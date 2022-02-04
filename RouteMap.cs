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
    // Returns true if there exists an AirportNode within A that has the given name. Otherwise, false.
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
    // Returns true if there exists an AirportNode within A that has the given code. Otherwise, false.
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
    // If AirportNode, a, does not already exist in List, A, then add it to A and return true. Otherwise, false.
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
    // If AirportNode, a, exists in List, A, then remove it from A and return true. Otherwise, false.
    // If a is removed, then all routes to a will also be removed.
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
    // If origin and dest exist within List A, then add dest to origin's List of Destinations and return true. Otherwise, false.
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
    // If origin and dest exist within List A, then remove dest from origin's List of Destinations and return true. Otherwise, false.
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
