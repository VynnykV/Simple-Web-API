using Application.Notes.Queries.GetNoteDetails;
using Application.Notes.Queries.GetNoteList;
using AutoMapper;
using Domain;

namespace Application.Common.Mappings
{
    public class NoteProfile: Profile
    {
        public NoteProfile()
        {
            CreateMap<Note, NoteDetailsVm>()
                .ForMember(noteVm => noteVm.Id,
                opt => opt.MapFrom(note => note.Id))
                .ForMember(noteVm => noteVm.Title,
                opt => opt.MapFrom(note => note.Title))
                .ForMember(noteVm => noteVm.Details,
                opt => opt.MapFrom(note => note.Details))
                .ForMember(noteVm => noteVm.CreationDate,
                opt => opt.MapFrom(note => note.CreationDate))
                .ForMember(noteVm => noteVm.EditDate,
                opt => opt.MapFrom(note => note.EditDate));
            CreateMap<Note, NoteLookupDto>()
                .ForMember(noteDto => noteDto.Id,
                opt => opt.MapFrom(note => note.Id))
                .ForMember(noteDto => noteDto.Title,
                opt => opt.MapFrom(note => note.Title));
        }
    }
}
