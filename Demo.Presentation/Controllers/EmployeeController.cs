using AutoMapper;
using Demo.BLL.Interfaces;
using Demo.DAL.Data.Contexts;
using Demo.DAL.Models;
using Demo.Presentation.Helper;
using Demo.Presentation.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Query;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;

namespace Demo.Presentation.Controllers
{
    [Authorize]
    public class EmployeeController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;


        //private readonly IDepartmentRepository _departmentRepository;

        public EmployeeController(IUnitOfWork unitOfWork,IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;

            //_departmentRepository = departmentRepository;
        }
        public async Task<IActionResult> Index(string searchInput)
        {
            var employees=Enumerable.Empty<Employee>();
            if (string.IsNullOrEmpty(searchInput))
            {
               employees =await _unitOfWork.EmployeeRepository.GetAll();
            }
            else
            {
                employees =await _unitOfWork.EmployeeRepository.SearchByName(searchInput);
            }
           var models=_mapper.Map<IEnumerable<EmpViewModel>>(employees);
            return View(models);
        } 
        public async Task<IActionResult> Search(string searchInput)
        {
            var employees=Enumerable.Empty<Employee>();
            if (string.IsNullOrEmpty(searchInput))
            {
               employees = await _unitOfWork.EmployeeRepository.GetAll();
            }
            else
            {
                employees =await _unitOfWork.EmployeeRepository.SearchByName(searchInput);
            }
           var models=_mapper.Map<IEnumerable<EmpViewModel>>(employees);
            return PartialView("EmpPartialView/EmployeePartialView", models);
        } 
        [HttpGet]
        public async Task<IActionResult> Details(int? id,string ViewName="Details")
        {
            //ViewData["department"] = _departmentRepository.GetAll();
            if (id is null)
                return BadRequest();
            var employee =await _unitOfWork.EmployeeRepository.Get(id.Value);
           var model=_mapper.Map<EmpViewModel>(employee);
            if (employee is null)
                return NotFound();
            return View(ViewName,model);
        }
        public IActionResult Create()
        {
            //ViewData["department"]= _departmentRepository.GetAll();
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(EmpViewModel model)
        {
            if (ModelState.IsValid)
            {
            model.ImageName = DocumnetSettings.UploadFile(model.Image, "images");
                var employee=_mapper.Map<Employee>(model);
                _unitOfWork.EmployeeRepository.Add(employee);
                var emp =await _unitOfWork.Complete();
                if (emp > 0)
                {
                    return RedirectToAction(nameof(Index));
                }
            }
            return View(model);
        }
        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {
            //ViewData["department"] = _departmentRepository.GetAll();
           
            return await Details(id,"Delete");
        }
        [HttpPost]
        public async Task<IActionResult> Delete([FromRoute] int? id, EmpViewModel model)
        {
            if (id != model.Id)
                return BadRequest();
            var employee = _mapper.Map<Employee>(model);

            if (ModelState.IsValid)
            {

                _unitOfWork.EmployeeRepository.Remove(employee);
                var count =await _unitOfWork.Complete();
                if (count > 0)
                {
                    DocumnetSettings.DeleteFile(model.ImageName, "images");
                    return RedirectToAction(nameof(Index));
                }
            }

            return View(employee);
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            //ViewData["department"] = _departmentRepository.GetAll();
           
            return await Details(id,"Edit");
        }
        [HttpPost]
        public async Task<IActionResult> Edit([FromRoute]int? id,EmpViewModel model)
        {
            if (id != model.Id)
                return BadRequest();
            if (model.ImageName is not null)
            {
                DocumnetSettings.DeleteFile(model.ImageName, "images");
            }
           model.ImageName= DocumnetSettings.UploadFile(model.Image, "images");
           var employee=_mapper.Map<Employee>(model);
            if (ModelState.IsValid)
            {
                 _unitOfWork.EmployeeRepository.Update(employee);
                var emp =await _unitOfWork.Complete();
                if (emp > 0)
                {
                    return RedirectToAction(nameof(Index));
                }
            }
            return View(employee);
        }

    }
}
    