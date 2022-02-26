// Team: Greg Prouty, Bradley Primeau, Avery Chin, Megan Risebrough
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

    /// <summary>
    /// Adds a destination to an Airport's list of destinations
    /// </summary>
    /// <param name="destAirport">The destination Airport to add to the list</param>
    public void AddDestination(AirportNode destAirport) 
    {
        if (Destinations.Contains(destAirport)) //check if the destination already exists
        {
            Console.WriteLine("Target airport already has given airport as a destination."); //if destination already exists inform user that it cannot be added
        }
        else if (destAirport.Name == this.Name)//check if the added airport is the current airport
        {
            Console.WriteLine("An airport cannot be its own destination");
        }
        else 
        {
            Destinations.Add(destAirport); //add destination to the target Airports list of destinations
            Console.WriteLine("Airport added to targets list of destinations"); //inform the user that the destination was added
        }
    }

    /// <summary>
    /// Removes a destination from an Airports destinations list
    /// </summary>
    /// <param name="destAirport">The destination Airport to be removed from the list</param>
    public void RemoveDestination(AirportNode destAirport) 
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

    /// <summary>
    /// ToString method to display Airport name, code, and all destination codes
    /// </summary>
    /// <returns>A nicely formatted string of the Airport name, code, and all destination codes</returns>
    public override string ToString() 
    {
        string airport = $"Name: {Name}, Code: {Code}, Destinations: {{ "; //append name and code to a string

        foreach(AirportNode a in Destinations) //go through every airport
        {
            airport += $"[{a.Code}] "; //append each airport code in the destinations list to a single string
        }

        return airport + "}"; //return completed string
    }
}