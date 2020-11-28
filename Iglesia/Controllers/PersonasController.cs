using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Iglesia.Models;
using Iglesia.Data;
using Microsoft.AspNetCore.Authorization;

namespace Iglesia.Controllers
{
    public class PersonasController : Controller
    {
        private readonly AuthDbContext _context;

        public PersonasController(AuthDbContext context)
        {
            _context = context;
        }

        // GET: Personas
        public async Task<IActionResult> Index()
        {
            return View(await _context.personas.ToListAsync());
        }

        // GET: Personas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var persona = await _context.personas
                .FirstOrDefaultAsync(m => m.PersonaId == id);
            if (persona == null)
            {
                return NotFound();
            }

            return View(persona);
        }

        // GET: Personas/Create
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PersonaId,genero,nombre,apellido,telefonoPer,celular,correo,TipoDocumento,DocuIdentidad,fechaNacimiento,PaisNacimiento,CiudadNacimiento,PaisResidencia,CiudadResidencia,Direccion,EstadoCivil,Hijos,Profesion,NombreEmpresa,Ocupacion,TelefonoEmp,FechaConversion,FechaBautismo,FechaAceptado,Denominacion,NombreIglesia,IglesiaAnterior,NombrePastor,Disciplinado,Causas,Funciones,Ministerios,MinisterioMayorFruto,MinisterioLlamado,Metas,Respaldo,NivelEstudio,ExpulsadoIns,Razon")] Persona persona)
        {
            if (ModelState.IsValid)
            {
                _context.Add(persona);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(persona);
        }

        // GET: Personas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var persona = await _context.personas.FindAsync(id);
            if (persona == null)
            {
                return NotFound();
            }
            return View(persona);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PersonaId,genero,nombre,apellido,telefonoPer,celular,correo,TipoDocumento,DocuIdentidad,fechaNacimiento,PaisNacimiento,CiudadNacimiento,PaisResidencia,CiudadResidencia,Direccion,EstadoCivil,Hijos,Profesion,NombreEmpresa,Ocupacion,TelefonoEmp,FechaConversion,FechaBautismo,FechaAceptado,Denominacion,NombreIglesia,IglesiaAnterior,NombrePastor,Disciplinado,Causas,Funciones,Ministerios,MinisterioMayorFruto,MinisterioLlamado,Metas,Respaldo,NivelEstudio,ExpulsadoIns,Razon")] Persona persona)
        {
            if (id != persona.PersonaId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(persona);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PersonaExists(persona.PersonaId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(persona);
        }

        // GET: Personas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var persona = await _context.personas
                .FirstOrDefaultAsync(m => m.PersonaId == id);
            if (persona == null)
            {
                return NotFound();
            }

            return View(persona);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var persona = await _context.personas.FindAsync(id);
            _context.personas.Remove(persona);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PersonaExists(int id)
        {
            return _context.personas.Any(e => e.PersonaId == id);
        }
    }
}
