using AutoMapper;
using SMS.DataBase;
using SMS.Models;
using SMS.ModelVm;
using SMS.Services;

namespace SMS.RepositoryServices;

public class SchoolRepositoryServices : RepositoryServices<School, SchoolVm>, ISchoolRepositoryServices
{
	public SchoolRepositoryServices(IMapper mapper, ApplicationDbContext context) : base(mapper, context)
	{
	}

	public Task InsertAsync(SchoolVm schoolVm)
	{
		throw new NotImplementedException();
	}
}
