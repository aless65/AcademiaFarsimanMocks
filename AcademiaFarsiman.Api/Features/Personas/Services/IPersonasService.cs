using AcademiaFarsiman.Api.Features.Personas.Dtos;
using Farsiman.Application.Core.Standard.DTOs;

namespace AcademiaFarsiman.Api.Features.Personas.Services
{
    public interface IPersonasService
    {
        Task<Respuesta<PersonaDto?>> CambiarEstado(int id, int usuarioModificaId, bool estado);
        Task<Respuesta<PersonaDto>> CrearPersona(RegistroPersonaDto registroDto);
        Task<Respuesta<PersonaDto?>> EditarPersona(EdicionPersonaDto edicionDto);
        Task<Respuesta<List<PersonaDto>>> Obtener();
    }
}