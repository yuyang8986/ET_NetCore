using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ET.Infrastructure.DataAccess;
using ET.Infrastructure.DataAccess.DTO.Occupation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace ET_NetCore.API.Controllers.IITR
{
    [Route("api/occupations")]
    [ApiController]
    public class IITROccupationsController : BaseController
    {
        private readonly ETContext _context;

        public IITROccupationsController(ETContext context)
        {
            _context = context;
        }
        /// <summary>
        /// Get All Occupations Names
        /// </summary> 
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            List<string> occupationNames= await
                _context.Occupations.Select(s => s.Name).ToListAsync();

            if(occupationNames != null)
            return Ok(occupationNames);

            return NotFound();
        }

        /// <summary>
        /// Get Occupation with all recommended income types and deduction types
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id:int}")]
        public async Task<IActionResult> Get(int id)
        {
            var occupation = await _context.Occupations
                .Include(s=>s.OccupationCategory).ThenInclude(s=>s.OccupationCategoryIncomeTypes).ThenInclude(s=>s.IncomeType)
                .Include(s => s.OccupationCategory).ThenInclude(s => s.OccupationCategoryDeductionTypes).ThenInclude(s => s.DeductionType)
                .FirstOrDefaultAsync(s => s.OccupationId == id);
            if(occupation!=null)
            return Ok(occupation);
            return NotFound();
        }
    }
}