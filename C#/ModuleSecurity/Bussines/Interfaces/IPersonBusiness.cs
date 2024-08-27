using Entity.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines.Interfaces
{
    public interface IPersonBusiness
    {
        public Task Delete(int id);
        public Task<IEnumerable<PersonDto>> GetAll();
        public Task<IEnumerable<DataSelectDto>> GetAllSelect();
        public Task<PersonDto> GetById(int id);
        public Task<PersonDto> GetByFirst_name(string First_name);
        public Task<PersonDto> Save(PersonDto entity);
        public Task Update(PersonDto entity);
    }
}
