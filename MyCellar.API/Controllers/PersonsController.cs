using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyCellar.API.Models;
using System.Data;

namespace MyCellar.API.Controllers
{
    [Route("api")]
    [ApiController]
    public class PersonsController : ControllerBase
    {
        List<Personne> personnes = new List<Personne>()
        {
            new Personne { Num = 1, Nom = "Morena", Prenom = "Andreas", Age =
            42 },
            new Personne { Num = 2, Nom = "Benamar", Prenom = "Karim", Age = 37
            },
            new Personne { Num = 3, Nom = "Paul", Prenom = "Jean", Age = 51 }
        };

        [Authorize(Roles = "User, Admin")]
        [HttpGet("personnes")]
        public IEnumerable<Personne> GetAllPersonnes()
        {
            return personnes;
        }

        [Authorize(Roles = "User, Admin")]
        [HttpGet("personnes/{id}")]
        public Personne GetPersonne(int id)
        {
            return personnes.FirstOrDefault((p) => p.Num == id);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost("personnes")]
        public IActionResult PostPersonne(Personne personne)
        {
            personnes.Add(personne);
            return Ok(personne);
        }

        [Authorize(Roles = "Admin")]
        [HttpDelete("personnes/{id}")]
        public IActionResult DeletePersonne(int id)
        {
            Personne personne = personnes.Find(elt => elt.Num == id);
            if (personne != null)
            {
                personne.Num = 0;
                personnes.Remove(personne);
                return Ok(personne);
            }
            return NotFound();
        }

        [Authorize(Roles = "Admin")]
        [HttpPut("personnes/{id}")]
        public IActionResult PutPersonne(int id, Personne personne)
        {
            if (id != personne.Num)
            {
                return BadRequest();
            }
            Personne personneUpd = personnes.Find(elt => elt.Num == id);
            if (personneUpd != null)
            {
                personneUpd = personne;
                return Ok(personneUpd);
            }
            return NotFound();
        }
    }
}
