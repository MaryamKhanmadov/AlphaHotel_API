using AlphaHotel_API.Service.DTOs.Partner;

namespace AlphaHotel_API.Service.Services.Interfaces.Partner
{
    public interface IPartnerReadService
    {
        List<PartnerListDto> GetAll();
        Task<List<PartnerListDto>> SearchAsync(string? searchText);
        Task<PartnerListDto> GetByIdAsync(string id);
    }
}
