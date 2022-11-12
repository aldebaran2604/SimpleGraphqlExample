using GraphqlProject.Models;

namespace GraphqlProject.Interfaces;

public interface IReservation
{
    List<Reservation> GetReservations();

    Reservation AddReservation(Reservation reservation);
}