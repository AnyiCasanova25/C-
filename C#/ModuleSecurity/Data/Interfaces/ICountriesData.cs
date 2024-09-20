using Entity.DTO;
using Entity.Model.Security;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Threading.Tasks;

namespace Data.Interfaces
{
    public interface ICountriesData
    {
        public Task Delete(int id);
        public Task<Country> GetByName(string name);
        public Task<Country> Save(Country entity);
        public Task Update(Country entity);
        public Task<Country> GetById(int id);
        public Task<IEnumerable<Country>> GetAll();
        public Task<IEnumerable<DataSelectDto>> GetAllSelect();
        
    }
}
