using Application.Notes.Commands.CreateNote;
using Application.Notes.Commands.UpdateNote;
using AutoMapper;
using WebAPI.Models;

namespace WebAPI.Mappings
{
    public class NoteDtoProfile : Profile
    {
        public NoteDtoProfile()
        {
            CreateMap<CreateNoteDto, CreateNoteCommand>()
                .ForMember(noteC => noteC.Title,
                opt => opt.MapFrom(noteDto => noteDto))
                .ForMember(noteC => noteC.Details,
                opt => opt.MapFrom(note => note.Details));
            CreateMap<UpdateNoteDto, UpdateNoteCommand>()
                .ForMember(noteU => noteU.Id,
                opt => opt.MapFrom(note => note.Id))
                .ForMember(noteU => noteU.Title,
                opt => opt.MapFrom(note => note.Title))
                .ForMember(noteU => noteU.Details,
                opt => opt.MapFrom(note => note.Details));
        }
    }
}
