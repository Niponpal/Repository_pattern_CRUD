using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata;
using SMS.ModelVm;
using SMS.RepositoryServices;

namespace SMS.Controllers;

public class SchoolController : Controller
{
	private readonly ISchoolRepositoryServices _services;

	public SchoolController(ISchoolRepositoryServices services)
	{
		_services = services;
	}

	public async Task<ActionResult<SchoolVm>> Index(CancellationToken cancellationToken)
	{
		return View(await _services.GetAllAsync(cancellationToken));
	}
	[HttpGet]
	public async Task<ActionResult<SchoolVm>> CreateOrEdit(int id, CancellationToken cancellationToken)
	{
		if (id == 0)
		{
			return View(new SchoolVm());
		}
        else
        {
			var entiy = await _services.GetByIdAsync(id, cancellationToken);
			return View(entiy);
        }
    }
	[HttpPost]
	public async Task<ActionResult<SchoolVm>> CreateOrEdit(int id, CancellationToken cancelToken, SchoolVm schoolVm)
	{
		if (id == 0)
		{
            if (ModelState.IsValid)
            {
				var enti = await _services.InsertAsync(id,schoolVm,cancelToken);
				return RedirectToAction("Index");
            }
        }
        else
        {
            await _services.UpdatedAsync(id,schoolVm,cancelToken);
			return  RedirectToAction("Index");
        }
		return View(schoolVm);
    }
	public async Task<ActionResult<SchoolVm>> Delted(int id,CancellationToken cancellationToken)
	{
		if (id != 0)
		{
			await _services.DeltedASync(id, cancellationToken);
			return RedirectToAction("Index");
		}
		return RedirectToAction("Index");
	}

	public async Task<ActionResult<SchoolVm>> Details(int id,CancellationToken cancellationToken)
	{
		var enti= await _services.GetByIdAsync(id,cancellationToken);
		return View (enti);

	}

}
