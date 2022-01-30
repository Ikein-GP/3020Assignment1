// Team: Greg Prouty, Bradley Primeau, Avery Chin
using System;
using System.Collections.Generic;

class AirportNode
{
    public string Name { get; set; } //variable to store an Airports name
    public string Code { get; set; } //variable to store the ID code of an Airport
    public List<AirportNode> Destinations { get; set; } //variable containing the list of destinations for the Airport
    public AirportNode(string name, string code) //Constructor taking a name and an id code as parameters
    {
        Name = name; //set Name to given name
        Code = code; //set Code to given code
        Destinations = new List<AirportNode>(); //initialize the list of destinations to an empty list
    }
    public void AddDestination(AirportNode destAirport) //method to add destinations to an Airports list of destinations
    {
        if (Destinations.Contains(destAirport)) //check if the destination already exists
        {
            Console.WriteLine("Target airport already has given airport as a destination."); //if destination already exists inform user that it cannot be added
        }
        else 
        {
            Destinations.Add(destAirport); //add destination to the target Airports list of destinations
            Console.WriteLine("Airport added to targets list of destinations"); //inform the user that the destination was added
        }
    }

    public void RemoveDestination(AirportNode destAirport) //Method to remove destinations from an Airports destinations list
    {
        if (!Destinations.Contains(destAirport)) //check if the target Airport has the parameter as a destination
        {
            Console.WriteLine("Removal target isn't a destination for that airport"); //if the destination isn't found inform the user it doesn't exist
        }
        else 
        {
            Destinations.Remove(destAirport); //remove the destination from the target destination list
            Console.WriteLine("Target has been removed from that airports list of destinations"); //inform the user that the destination has been removed
        }
    }

    public override string ToString()
    {
        return "Name: " + Name + " Code: " + Code;
    }
}