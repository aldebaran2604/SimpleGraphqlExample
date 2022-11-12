using GraphqlProject.Data;
using GraphqlProject.Interfaces;
using GraphqlProject.Models;

namespace GraphqlProject.Services;

public class ReservationService : IReservation
{
    private GraphQLDbContext _dbContext;

    public ReservationService(GraphQLDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public Reservation AddReservation(Reservation reservation)
    {
        _dbContext.Reservations.Add(reservation);
        _dbContext.SaveChanges();
        return reservation;
    }

    public List<Reservation> GetReservations()
    {
        return _dbContext.Reservations.ToList();
    }
}