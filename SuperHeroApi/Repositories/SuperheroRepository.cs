using SuperHeroApi.Data;
using SuperHeroApi.Interfaces;

namespace SuperHeroApi.Repositories;

public class SuperheroRepository : ISuperheroRepository
{
    private readonly ApplicationDbContext _applicationDbContext;

    public SuperheroRepository(ApplicationDbContext applicationDbContext)
    {
        _applicationDbContext = applicationDbContext;
    }
}