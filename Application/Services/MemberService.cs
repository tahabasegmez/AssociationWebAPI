using AssociationWebAPI.Application.DTOs;
using AssociationWebAPI.Application.Interfaces.Repositories;
using AssociationWebAPI.Application.Interfaces.Services;
using AssociationWebAPI.Application.Mappers;

namespace AssociationWebAPI.Application.Services;

public class MemberService : IMemberService
{
    private readonly IMemberRepository _memberRepository;

    public MemberService(IMemberRepository memberRepository)
    {
        _memberRepository = memberRepository;
    }

    public async Task<CorporateResponseDto?> GetCorporateMemberAsync(int id, CancellationToken cancellationToken = default)
    {
        var corporate = await _memberRepository.GetCorporateByIdAsync(id, cancellationToken);
        return corporate?.ToResponseDto();
    }

    public async Task<IndividualResponseDto?> GetIndividualMemberAsync(int id, CancellationToken cancellationToken = default)
    {
        var individual = await _memberRepository.GetIndividualByIdAsync(id, cancellationToken);
        return individual?.ToResponseDto();
    }

    public async Task<IndividualResponseDto> CreateIndividualMemberAsync(IndividualRequestDto memberDto, CancellationToken cancellationToken = default)
    {
        var member = memberDto.ToEntity();

        await _memberRepository.AddAsync(member, cancellationToken);
        await _memberRepository.SaveChangesAsync(cancellationToken);

        return member.ToResponseDto();
    }
}
