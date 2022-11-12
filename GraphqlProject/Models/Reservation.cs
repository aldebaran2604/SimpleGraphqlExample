namespace GraphqlProject.Models;

public class Reservation
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string Phone { get; set; } = null!;
    public int TotalPeople { get; set; }
    public string Email { get; set; } = null!;
    public string Date { get; set; } = null!;
    public string Time { get; set; } = null!;
}