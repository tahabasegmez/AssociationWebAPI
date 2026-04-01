using AutoMapper;
using AssociationWebAPI.Application.DTOs;
using AssociationWebAPI.Domain.Entities;
using AssociationWebAPI.Domain.Enums;

namespace AssociationWebAPI.Application.Mappers;

public class DtoMappingProfile : Profile
{
    public DtoMappingProfile()
    {
        CreateMap<Address, AddressRequestDto>();
        CreateMap<Address, AddressResponseDto>();
        CreateMap<AddressRequestDto, Address>();
        CreateMap<AddressResponseDto, Address>();

        CreateMap<AdministratorRequestDto, Administrator>()
            .ForMember(dest => dest.Association, opt => opt.Ignore());
        CreateMap<Administrator, AdministratorResponseDto>();

        CreateMap<AssociationRequestDto, Association>()
            .ForMember(dest => dest.Administrators, opt => opt.Ignore())
            .ForMember(dest => dest.Safe, opt => opt.Ignore());
        CreateMap<Association, AssociationResponseDto>()
            .ForMember(dest => dest.SafeId, opt => opt.MapFrom(src => src.Safe != null ? src.Safe.Id : (int?)null))
            .ForMember(dest => dest.AdministratorIds, opt => opt.MapFrom(src => src.Administrators.Select(a => a.Id).ToList()));

        CreateMap<Member, MemberResponseDto>()
            .ForMember(dest => dest.DuesIds, opt => opt.MapFrom(src => src.Dues.Select(d => d.Id).ToList()));

        CreateMap<CorporateRequestDto, Corporate>()
            .ForMember(dest => dest.Type, opt => opt.MapFrom(_ => MemberType.Corporate))
            .ForMember(dest => dest.Dues, opt => opt.Ignore())
            .ForMember(dest => dest.Representatives, opt => opt.Ignore());
        CreateMap<Corporate, CorporateResponseDto>()
            .ForMember(dest => dest.RepresentativeIds, opt => opt.MapFrom(src => src.Representatives.Select(r => r.Id).ToList()));

        CreateMap<IndividualRequestDto, Individual>()
            .ForMember(dest => dest.Type, opt => opt.MapFrom(_ => MemberType.Individual))
            .ForMember(dest => dest.Dues, opt => opt.Ignore())
            .ForMember(dest => dest.Meetings, opt => opt.Ignore());
        CreateMap<Individual, IndividualResponseDto>()
            .ForMember(dest => dest.MeetingIds, opt => opt.MapFrom(src => src.Meetings.Select(m => m.Id).ToList()));

        CreateMap<DecisionRequestDto, Decision>()
            .ForMember(dest => dest.Meeting, opt => opt.Ignore());
        CreateMap<Decision, DecisionResponseDto>();

        CreateMap<DuesRequestDto, Dues>()
            .ForMember(dest => dest.Member, opt => opt.Ignore())
            .ForMember(dest => dest.Income, opt => opt.Ignore());
        CreateMap<Dues, DuesResponseDto>();

        CreateMap<ExpenseRequestDto, Expense>()
            .ForMember(dest => dest.Safe, opt => opt.Ignore());
        CreateMap<Expense, ExpenseResponseDto>();

        CreateMap<IncomeRequestDto, Income>()
            .ForMember(dest => dest.Safe, opt => opt.Ignore())
            .ForMember(dest => dest.Dues, opt => opt.Ignore());
        CreateMap<Income, IncomeResponseDto>()
            .ForMember(dest => dest.DuesId, opt => opt.MapFrom(src => src.Dues != null ? src.Dues.Id : (int?)null));

        CreateMap<MeetingRequestDto, Meeting>()
            .ForMember(dest => dest.IndividualParticipants, opt => opt.Ignore())
            .ForMember(dest => dest.RepresentativeParticipants, opt => opt.Ignore())
            .ForMember(dest => dest.Decisions, opt => opt.Ignore());
        CreateMap<Meeting, MeetingResponseDto>()
            .ForMember(dest => dest.IndividualParticipantIds, opt => opt.MapFrom(src => src.IndividualParticipants.Select(i => i.Id).ToList()))
            .ForMember(dest => dest.RepresentativeParticipantIds, opt => opt.MapFrom(src => src.RepresentativeParticipants.Select(r => r.Id).ToList()))
            .ForMember(dest => dest.DecisionIds, opt => opt.MapFrom(src => src.Decisions.Select(d => d.Id).ToList()));

        CreateMap<RepresentativeRequestDto, Representative>()
            .ForMember(dest => dest.Corporate, opt => opt.Ignore())
            .ForMember(dest => dest.Meetings, opt => opt.Ignore());
        CreateMap<Representative, RepresentativeResponseDto>()
            .ForMember(dest => dest.MeetingIds, opt => opt.MapFrom(src => src.Meetings.Select(m => m.Id).ToList()));

        CreateMap<SafeRequestDto, Safe>()
            .ForMember(dest => dest.Association, opt => opt.Ignore())
            .ForMember(dest => dest.Incomes, opt => opt.Ignore())
            .ForMember(dest => dest.Expenses, opt => opt.Ignore());
        CreateMap<Safe, SafeResponseDto>()
            .ForMember(dest => dest.IncomeIds, opt => opt.MapFrom(src => src.Incomes.Select(i => i.Id).ToList()))
            .ForMember(dest => dest.ExpenseIds, opt => opt.MapFrom(src => src.Expenses.Select(e => e.Id).ToList()));

        CreateMap<Document, DocumentResponseDto>();

        CreateMap<IncomingRequestDto, Incoming>();
        CreateMap<Incoming, IncomingResponseDto>()
            .IncludeBase<Document, DocumentResponseDto>();

        CreateMap<OutgoingRequestDto, Outgoing>();
        CreateMap<Outgoing, OutgoingResponseDto>()
            .IncludeBase<Document, DocumentResponseDto>();

        CreateMap<InternalRequestDto, global::AssociationWebAPI.Domain.Entities.Internal>();
        CreateMap<global::AssociationWebAPI.Domain.Entities.Internal, InternalResponseDto>()
            .IncludeBase<Document, DocumentResponseDto>();
    }
}

