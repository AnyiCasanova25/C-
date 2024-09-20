using Entity.DTO;
using Entity.Model.Security;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers.Interfaces
{
    public interface ICountriesController
    {
        Task<IActionResult> Delete(int id);
        Task<ActionResult<CountryDto>> GetById(int id);
        Task<ActionResult<Country>> Save([FromBody] CountryDto countriesDto);
        Task<IActionResult> Update([FromBody] CountryDto countriesDto);
        Task<ActionResult<IEnumerable<CountryDto>>> GetAll();
    }
}
