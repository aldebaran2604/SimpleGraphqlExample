using SuperHeroApi.Data;
using SuperHeroApi.Interfaces;

namespace SuperHeroApi.Repositories;

public class SuperpowerRepository : ISuperpowerRepository
{
    private readonly ApplicationDbContext _applicationDbContext;

    public SuperpowerRepository(ApplicationDbContext applicationDbContext)
    {
        _applicationDbContext = applicationDbContext;
    }
}