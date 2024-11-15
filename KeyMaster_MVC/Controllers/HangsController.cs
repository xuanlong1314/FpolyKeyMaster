using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using KeyMaster_API.Data;
using KeyMaster_Data.Models;
using KeyMaster_API.IRepositories;
using KeyMaster_MVC.IService;
using System.Drawing;
using KeyMaster_MVC.ViewModel;

namespace KeyMaster_MVC.Controllers
{
    public class HangsController : Controller
    {
        private readonly IHangService _hangService;

        public HangsController(IHangService hangService)
        {
            _hangService = hangService;
        }

        // GET: Hangs
        public async Task<IActionResult> Index(int currentPage = 1, int rowsPerPage = 10)
        {
            var hangs = await _hangService.GetAllHangs();

            // Phân trang
            var totalHangs = hangs.Count();
            var totalPages = (int)Math.Ceiling((double)totalHangs / rowsPerPage);
            var pagedHangs = hangs.Skip((currentPage - 1) * rowsPerPage).Take(rowsPerPage).ToList();

            var viewModel = new HangViewModel
            {
                Hangs = pagedHangs,
                NewHang = new Hang(),
            };

            ViewBag.CurrentPage = currentPage;
            ViewBag.RowsPerPage = rowsPerPage;
            ViewBag.TotalPages = totalPages;

            return View(viewModel);
        }

        // GET: Hangs/Details/5
        public async Task<IActionResult> Details(Guid id)
        {
            if (_hangService.GetAllHangs == null)
            {
                return NotFound();
            }

            var hang = await _hangService.GetHangById(id);
            if (hang == null)
            {
                return NotFound();
            }

            return View(hang);
        }

        // GET: Hangs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Hangs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(HangViewModel hangViewModel)
        {
            if (ModelState.IsValid)
            {
                hangViewModel.NewHang.IdHang = Guid.NewGuid();
                await _hangService.Create(hangViewModel.NewHang);
                return RedirectToAction(nameof(Index));
            }
            return RedirectToAction(nameof(Index));
        }

        // GET: Hangs/Edit/5
        public async Task<IActionResult> Edit(Guid id)
        {
            if (_hangService.GetAllHangs() == null)
            {
                return NotFound();
            }

            var hang = await _hangService.GetHangById(id);
            if (hang == null)
            {
                return NotFound();
            }
            return View(hang);
        }
        // POST: Hangs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, HangViewModel hangViewModel)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await _hangService.Update(hangViewModel.NewHang);
                }
                catch (DbUpdateConcurrencyException)
                {
                    var existingMaterial = await _hangService.GetHangById(hangViewModel.NewHang.IdHang);
                    if (existingMaterial == null)
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                hangViewModel.Hangs = await _hangService.GetAllHangs();
                return RedirectToAction(nameof(Index));
            }
            return BadRequest("Lỗi không sửa được");
        }

        // GET: Hangs/Delete/5
        public async Task<IActionResult> Delete(Guid id)
        {
            if (_hangService.GetAllHangs() == null)
            {
                return NotFound();
            }

            var hang = await _hangService.GetHangById(id);
            if (hang == null)
            {
                return NotFound();
            }

            return View(hang);
        }
        // POST: Hangs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            if (_hangService.GetAllHangs() == null)
            {
                return Problem("Entity set 'Hang' is null.");
            }

            await _hangService.Delete(id);

            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public async Task<IActionResult> ToggleStatus(Guid id)
        {
            // Tìm kiếm vật liệu theo ID
            var material = await _hangService.GetHangById(id);
            if (material == null)
            {
                return NotFound();
            }

            material.TrangThai = !material.TrangThai;
            await _hangService.Update(material);

            return RedirectToAction("Index");
        }
    }
}
