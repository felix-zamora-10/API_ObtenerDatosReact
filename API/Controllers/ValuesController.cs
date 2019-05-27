using System.Collections.Generic;
using System.Web.Script.Serialization;
using API.API.BC.Modelos;
using API.API.BW;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase {

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get() {
            FlujoObtenerPreguntas flujo;
            List<Pregunta> preguntas;
            string preguntasEnJSon;
            JavaScriptSerializer convertidorJSon = new JavaScriptSerializer();

            flujo  = new FlujoObtenerPreguntas();
            preguntas = flujo.ObtienePregunta();
            preguntasEnJSon = convertidorJSon.Serialize(preguntas);

            return new string[] { "preguntasEnJSon" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id) {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value) {

        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value) {

        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id) {

        }
    }
}
