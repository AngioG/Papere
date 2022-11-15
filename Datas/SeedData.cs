using Papere.Models;

namespace Papere.Datas
{
    public static class SeedData
    {
        public static void Initialize(AppDbContext context)
        {
            if (context.Papere.Any()) return;

            context.Papere.AddRange(new Papera
            {
                Nome = "Goose",
                Ali = 4
            }, new Papera
            {
                Nome = "Duck",
                Ali = 2
            }

                );

            context.SaveChanges();
            
        }
    }
}
