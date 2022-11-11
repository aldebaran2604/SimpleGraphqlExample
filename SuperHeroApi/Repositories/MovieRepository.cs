using SuperHeroApi.Data;
using SuperHeroApi.Interfaces;

namespace SuperHeroApi.Repositories;

public class MovieRepository : IMovieRepository
{
    private readonly ApplicationDbContext _applicationDbContext;

    public MovieRepository(ApplicationDbContext applicationDbContext)
    {
        _applicationDbContext = applicationDbContext;
    }
}