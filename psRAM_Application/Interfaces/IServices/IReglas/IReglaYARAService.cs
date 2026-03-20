using psRAM_Domain.Entities.Base.Operation;

namespace psRAM_Application.Interfaces.IServices.IReglas
{
    public interface IReglaYARAService
    {
        Task<OperationResult<int>> CrearReglaAsync(ReglaYARADtos dto);
        Task<OperationResult<IEnumerable<ReglaYARADtos>>> ObtenerTodasAsync();
    }

}
