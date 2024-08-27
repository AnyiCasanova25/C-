using Entity.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines.Interfaces
{
    public interface IRoleViewBusiness
    {
        public Task Delete(int id);
        public Task<IEnumerable<RoleViewDto>> GetAll();
        public Task<IEnumerable<DataSelectDto>> GetAllSelect();
        public Task<RoleViewDto> GetById(int id);
        public Task<RoleViewDto> Save(RoleViewDto entity);
        public Task Update(ViewDto entity);
    }
}
