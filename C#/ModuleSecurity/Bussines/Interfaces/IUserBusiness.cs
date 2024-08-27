using Entity.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines.Interfaces
{
    public interface IUserBusiness
    {
        public Task Delete(int id);
        public Task<IEnumerable<UserDto>> GetAll();
        public Task<IEnumerable<DataSelectDto>> GetAllSelect();
        public Task<UserDto> GetById(int id);
        public Task<UserDto> Save(UserDto entity);
        public Task Update(UserDto entity);
    }
}
