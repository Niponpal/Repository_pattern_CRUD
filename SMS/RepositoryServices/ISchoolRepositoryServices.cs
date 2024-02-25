using SMS.Models;
using SMS.ModelVm;
using SMS.Services;

namespace SMS.RepositoryServices
{
	public interface ISchoolRepositoryServices : IRepositoryServices<School, SchoolVm>
	{
		Task InsertAsync(SchoolVm schoolVm);
	}
}
