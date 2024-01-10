using AcademiaFarsiman.Api.Features.Personas.Dtos;
using AcademiaFarsiman.Api.Features.Personas.Services;
using AutoMapper;
using Farsiman.Application.Core.Standard.DTOs;
using Farsiman.Domain.Core.Standard.Repositories;
using FluentAssertions;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using NSubstitute;
using NSubstitute.ExceptionExtensions;

namespace AcademiaFarsimanMocks.Tests
{
    public class PersonaTests
    {
        [Fact]
        public async void CrearPersona_Catch()
        {
            //Arrange
            var unitOfWork = Substitute.For<IUnitOfWork>();
            var personaDomain = new PersonaDomain();
            var autoMapper = Substitute.For<IMapper>();

            var personasService = Substitute.For<PersonasService>(unitOfWork, personaDomain, autoMapper);


            //Act
            //personasService
            //.CrearPersona(Arg.Any<RegistroPersonaDto>())
            //.Returns(x => { throw new Exception(); });

            personasService
            .CrearPersona(Arg.Any<RegistroPersonaDto>())
            .Returns<Task<Respuesta<PersonaDto>>>(x => throw new Exception());


            Func<Task> resultado = async () => await personasService.CrearPersona(Arg.Any<RegistroPersonaDto>());

            //Assert
            await resultado.Should().ThrowAsync<Exception>();
        }
    }
}