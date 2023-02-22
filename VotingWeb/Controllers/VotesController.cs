using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Fabric;
using System.Fabric.Query;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace VotingWeb.Controllers
{
	[Produces("application/json")]
	[Route("api/Votes")]
	public class VotesController : Controller
	{
		private readonly HttpClient _httpClient;

		public VotesController(HttpClient httpClient)
		{
			_httpClient = httpClient;
		}

		// GET: api/Votes
		[HttpGet]
		public async Task<IActionResult> Get()
		{
			List<KeyValuePair<string, int>> votes = new List<KeyValuePair<string, int>>
			{
				new KeyValuePair<string, int>("Pizza", 3),
				new KeyValuePair<string, int>("Ice Cream", 4)
			};

			return Json(votes);
		}
	}
}
