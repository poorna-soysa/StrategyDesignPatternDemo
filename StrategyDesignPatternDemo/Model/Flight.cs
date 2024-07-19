namespace StrategyDesignPatternDemo.Model;

public class Flight
{
    public int FlightId { get; set; }
    public string AircraftRegistrationNo { get; set; } = string.Empty;
    public string Destination { get; set; } = string.Empty;
    public int NumberOfPassengers { get; set; } = 0;
}
