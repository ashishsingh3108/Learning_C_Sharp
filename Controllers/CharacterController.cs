using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace dotnet_course.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CharacterController: ControllerBase
    {
        private static List<Character> characters = new List<Character>{
            new Character{
                Id=1,
                Name = "Ashish Singh"
            },
            new Character { Id = 2 , Name = "Sam"}
        };

        [HttpGet("GetAll")]
        public ActionResult<List<Character>> Get(){
            return characters;
        }

        [HttpGet("{id}")]
        public ActionResult<Character> GetSingle(int id){
            return characters.Find(character => character.Id == id);
        }
    }
}