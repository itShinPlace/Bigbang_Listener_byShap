using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
//using Bigbang.Core.Calulator;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Bigbang.Listener {
    [Route("api/[controller]")]
    [ApiController]
    public class CeleritasController : ControllerBase {
        // GET: api/<CeleritasController>
        [HttpGet]
        public IEnumerable<string> Get() {
            return new string[] { "value1", "value2" };
        }

        // GET api/<CeleritasController>/5
        [HttpGet("{id}")]
        public string Get(int id) {
            return "value";
        }

        // POST api/<CeleritasController>
        [HttpPost]
        public JsonElement Post([FromBody] JsonElement value) {
            
            string json = JsonSerializer.Serialize(value);
            
            string result = "{\"method\":\"None\",\"params\":{\"options\":\"None\",\"results\":\"None\"}}";

            switch (value.GetProperty("method").GetString()) {
                case "vanilaswap_calculate":
                    //BigVanilaSwap vanilaswap = new BigVanilaSwap();
                    //result = vanilaswap.calc(json);
                    break;

                case "swaption_calculate":
                    //BigSwaption swaption = new BigSwaption();
                    //swaption.calc(json);
                    break;

                default:
                    result = "{\"method\":\"None\",\"params\":{\"options\":\"None\",\"results\":\"None\"}}";
                    break;
            }

            return (JsonDocument.Parse(result)).RootElement;
        }

        // PUT api/<CeleritasController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value) {
        }

        // DELETE api/<CeleritasController>/5
        [HttpDelete("{id}")]
        public void Delete(int id) {
        }
    }
}
