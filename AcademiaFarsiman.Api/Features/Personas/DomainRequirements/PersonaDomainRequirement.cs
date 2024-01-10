namespace AcademiaFarsiman.Api.Features.Personas.DomainRequirements
{
    public class PersonaDomainRequirement
    {
        public bool ExistePersona { get; set; }

        public PersonaDomainRequirement(bool existePersona)
        {
            ExistePersona = existePersona;
        }

    }
}

