using Entity.DTO;
using Entity.Model.Security;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Data.Interfaces
{
    public interface IStateData
    {
        public Task<State> GetById(int id);
        public Task<State> GetByName(string name);
        public Task<State> Save(State entity);
        public Task Update(State entity);
        public Task Delete(int id);
        public Task<IEnumerable<State>> GetAll();
        public Task<IEnumerable<DataSelectDto>> GetAllSelect();
    }
}
