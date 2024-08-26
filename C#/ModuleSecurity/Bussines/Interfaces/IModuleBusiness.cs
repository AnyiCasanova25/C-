using Entity.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines.Interfaces
{
    public interface IModuleBusiness
    {
        public Task Delete(int id);
        public Task<IEnumerable<ModuleDto>> GetAll();
        public Task<IEnumerable<DataSelectDto>> GetAllSelect();
        public Task<ModuleDto> GetById(int id);
        public Task<ModuleDto> Save(ModuleDto entity);
        public Task Update(ModuleDto entity);
    }
}
