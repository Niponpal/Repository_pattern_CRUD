namespace SMS.Services;

public interface IRepositoryServices<TEntiy,IModel>where TEntiy : class,new() where IModel : class
{
	Task<IEnumerable<IModel>> GetAllAsync(CancellationToken cancellationToken);
	Task<IModel>GetByIdAsync(int id,CancellationToken cancellationToken);
	Task<IModel>DeltedASync(int id,CancellationToken cancellationToken);
	Task<IModel>UpdatedAsync(int id,IModel model,CancellationToken cancellationToken);
	Task<IModel> InsertAsync(int id, IModel model, CancellationToken cancellationToken);

}
