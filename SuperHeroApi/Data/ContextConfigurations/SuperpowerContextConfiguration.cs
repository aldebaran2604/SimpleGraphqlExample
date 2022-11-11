using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SuperHeroApi.Models;

namespace SuperHeroApi.Data.ContextConfigurations;

public class SuperpowerContextConfiguration : IEntityTypeConfiguration<Superpower>
{
    private Guid[] _guids;

    public SuperpowerContextConfiguration(Guid[] guids)
    {
        _guids = guids;
    }

    public void Configure(EntityTypeBuilder<Superpower> builder)
    {
        builder
                .HasData(
                new Superpower
                {
                    Id = Guid.NewGuid(),
                    SuperPower = "Intellect.",
                    Description = "He's always a step ahead.",
                    SuperheroId = _guids[0]
                },
                new Superpower
                {
                    Id = Guid.NewGuid(),
                    SuperPower = "Fighting",
                    Description = "Sublime fighting skills.",
                    SuperheroId = _guids[0]
                },
                new Superpower
                {
                    Id = Guid.NewGuid(),
                    SuperPower = "Wealth.",
                    Description = "He got a lot of money",
                    SuperheroId = _guids[0]
                },
                new Superpower
                {
                    Id = Guid.NewGuid(),
                    SuperPower = "Deflect blaster power.",
                    Description = "Skywalker is able to deflect fire from a blaster back at the opponent firing. This enables Luke to turn someone else's weapon against them.",
                    SuperheroId = _guids[1]
                },
                new Superpower
                {
                    Id = Guid.NewGuid(),
                    SuperPower = "Espionage",
                    Description = "She's good at spying at people.",
                    SuperheroId = _guids[2]
                },
                new Superpower
                {
                    Id = Guid.NewGuid(),
                    SuperPower = "Infiltration",
                    Description = "She knows how to infiltrate the enemy.",
                    SuperheroId = _guids[2]
                },
                new Superpower
                {
                    Id = Guid.NewGuid(),
                    SuperPower = "Subterfuge",
                    Description = "The knowledge of how to undermine others.",
                    SuperheroId = _guids[2]
                });
    }
}