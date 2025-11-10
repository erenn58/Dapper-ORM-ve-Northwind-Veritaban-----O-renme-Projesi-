using Project5_DapperNorthwind.dto.CategoryDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project5_DapperNorthwind.repos.categoryrepo
{
    public class CategoryRepos : ICategoryRepo
    {
        public Task CreateCategoryAsync(CreateDto createDto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteCategoryAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ResultCategoryDto>> GetAllCategoryAsync()
        {
            throw new NotImplementedException();
        }

        public Task<GetByIDdto> GetByIdCategoryAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateCategoryAsync(UpdateDto updateDto)
        {
            throw new NotImplementedException();
        }
    }
}
