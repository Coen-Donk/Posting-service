using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Gateway.Controllers
{
	public class CSharpMember
	{
		public string Name { get; set; }
		public string Bio { get; set; }
		public DateTime JoinDate { get; set; }
		public bool Author { get; set; }
	}

	[Route("[controller]")]
	[ApiController]
	public class HomeController : ControllerBase
	{
		// GET: api/<HomeController>
		[HttpGet]
		public CSharpMember Get()
		{
		string jsonString = "{\"Name\":\"John Doe\",\"Bio\":\"Software developer\",\"JoinDate\":\"2023-05-31T20:29:33-04:00\",\"Author\":true}";
			CSharpMember member = JsonSerializer.Deserialize<CSharpMember>(jsonString);


			return member;
		}

		// GET api/<HomeController>/5
		[HttpGet("{id}")]
		public string Get(int id)
		{
			return "value";
		}

		// POST api/<HomeController>
		[HttpPost]
		public void Post([FromBody] string value)
		{
		}

		// PUT api/<HomeController>/5
		[HttpPut("{id}")]
		public void Put(int id, [FromBody] string value)
		{
		}

		// DELETE api/<HomeController>/5
		[HttpDelete("{id}")]
		public void Delete(int id)
		{
		}
	}
}
