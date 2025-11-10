using Project5_DapperNorthwind.dto.CategoryDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project5_DapperNorthwind.repos.categoryrepo
{
    public interface ICategoryRepo
    {
        Task<List<ResultCategoryDto>> GetAllCategoryAsync();
        Task CreateCategoryAsync(CreateDto createDto);
        Task UpdateCategoryAsync(UpdateDto updateDto);
        Task DeleteCategoryAsync(int id);
        Task<GetByIDdto>GetByIdCategoryAsync(int id);

    }
}
