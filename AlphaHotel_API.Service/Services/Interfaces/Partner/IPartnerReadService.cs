using AlphaHotel_API.Service.DTOs.Partner;

namespace AlphaHotel_API.Service.Services.Interfaces.Partner
{
    public interface IPartnerReadService
    {
        List<PartnerListDto> GetAll();
        List<PartnerListDto> Search(string? searchText);
        Task<PartnerListDto> GetByIdAsync(string id);
    }
}
