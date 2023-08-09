using AlphaHotel_API.Service.DTOs.Partner;

namespace AlphaHotel_API.Service.Services.Interfaces.Partner
{
    public interface IPartnerWriteService
    {
        Task CreateAsync(PartnerCreateDto room);
        Task DeleteAsync(string id);
        Task SoftDeleteAsync(string id);
        Task UpdateAsync(string id, PartnerUpdateDto room);
    }
}
