using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CitasMedicas.App.Dominio;
using CitasMedicas.App.Persistencia;


namespace CitasMedicas.App.Frontend.Pages.Pacientes
{
    public class Index1Model : PageModel
    {
        private readonly IRepositorioPaciente _repoPaciente;
        public IEnumerable<Paciente> pacientes {get;set;}
        public Index1Model(IRepositorioPaciente repoPaciente)
        {
            _repoPaciente = repoPaciente;
        } 



        public void OnGet()
        {
            pacientes = _repoPaciente.GetAllPacientes();
        }
    }
}
