using Demo.DAL.Models;
using Microsoft.AspNetCore.Mvc;
using Demo.BLL.Repositories;
using Demo.BLL.Interfaces;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
namespace Demo.Presentation.Controllers
{
    [Authorize]
    public class DepartmentController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public DepartmentController(IUnitOfWork unitOfWork)//inject  // ask CLR to create object
        {
            _unitOfWork = unitOfWork;
        } // DI

        public async Task<IActionResult> Index()
        {
            var depatrment =await _unitOfWork.DepartmentRepository.GetAll();
            return View(depatrment);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Department model)
        {
            if (ModelState.IsValid)
            {
                 _unitOfWork.DepartmentRepository.Add(model);
                var count =await _unitOfWork.Complete();
                if (count > 0)
                {
                    return RedirectToAction(nameof(Index));
                }
            }

            return View();
        }

        public async Task<IActionResult> Details(int? id,string ViewName="Details")
        {
            if (id == null)
                return BadRequest();
            var department =await _unitOfWork.DepartmentRepository.Get(id);
            if (department == null)
                return NotFound();
            return View(department);
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
           
            return await Details(id,"Edit");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit([FromRoute] int? id, Department department)
        {
            if (id != department.Id)
                return BadRequest();
            if (ModelState.IsValid)
            {
                 _unitOfWork.DepartmentRepository.Update(department);
                var count = await _unitOfWork.Complete();
                if (count > 0)
                {
                    return RedirectToAction(nameof(Index));
                }
            }
            return View(department);
        }
        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {   
            return await Details(id,"Delete");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete([FromRoute] int? id, Department department)
        {
            if (id != department.Id)
                return BadRequest();
             _unitOfWork.DepartmentRepository.Remove(department);
            var count =await _unitOfWork.Complete();

            if (count > 0)
            {
                return RedirectToAction(nameof(Index));
            }
            return View(department);
        }
    }
}
