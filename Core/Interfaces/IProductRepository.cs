using Core.Entities;

namespace Core.Interfaces
{
    public interface IProductRepository
    {
        /*
        This interface defines the methods we have in our Repository. Our repository is
        the code that sites between our logic and the data.
        */
        Task<Product> GetProductByIdAsync(int id);
        Task<IReadOnlyList<Product>> GetProductsAsync();
        Task<IReadOnlyList<ProductBrand>> GetProductBrandsAsync();
        Task<IReadOnlyList<ProductType>> GetProductTypesAsync();
    }
}
