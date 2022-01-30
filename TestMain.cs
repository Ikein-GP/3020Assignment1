// Team: Greg Prouty, Bradley Primeau, Avery Chin
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
        node1.AddDestination(node2);
        node1.AddDestination(node3);
        node1.AddDestination(node5);
        node2.AddDestination(node1);
        node1.AddDestination(node2);
        node1.RemoveDestination(node2);
        node1.RemoveDestination(node2);
        node1.AddDestination(node2);
        foreach (AirportNode i in node1.Destinations) 
        {
            Console.WriteLine(i.ToString());
        }

        //this is a test comment to practice with git merging
    }
}

