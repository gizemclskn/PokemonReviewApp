using PokemonReviewApp.Models;

namespace PokemonReviewApp.Interfaces
{
    public interface ICountryRepoository
    {
        ICollection<Category> GetCategories();
        Country GetCountry(int id);
        Country GetCountryByOwner(int ownerId);
    }
}
