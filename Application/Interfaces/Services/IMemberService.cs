using AssociationWebAPI.Application.DTOs;

namespace AssociationWebAPI.Application.Interfaces.Services;

public interface IMemberService
{
    Task<CorporateResponseDto?> GetCorporateMemberAsync(int id, CancellationToken cancellationToken = default);
    Task<IndividualResponseDto?> GetIndividualMemberAsync(int id, CancellationToken cancellationToken = default);
    Task<IndividualResponseDto> CreateIndividualMemberAsync(IndividualRequestDto memberDto, CancellationToken cancellationToken = default);
}
