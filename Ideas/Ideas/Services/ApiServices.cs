using Ideas.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Ideas.Services
{
	public class ApiServices
	{
		public async Task<bool> RegisterAsync(string email, string password, string confirmPassword)
		{
			var client = new HttpClient();

			var model = new RegisterBindingModel
			{
				Email = email,
				Password = password,
				ConfirmPassword = confirmPassword
			};

			var json = JsonConvert.SerializeObject(model);


			HttpContent content = new StringContent(json);

			content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

			var response = await client.PostAsync("https://localhost:44357/api/Account/Register", content);

			return response.IsSuccessStatusCode;
		}


		public async Task LoginAsync(string userName, string password)
		{
			var KeyValues = new List<KeyValuePair<string, string>>
			{
				new KeyValuePair<string, string>("username", userName),
				new KeyValuePair<string, string>("password", password),
			   new KeyValuePair<string, string>("grant_type", password)
			};

			var request = new HttpRequestMessage(HttpMethod.Post, "https://localhost:44357/Token");

			request.Content = new FormUrlEncodedContent(KeyValues);

			var client = new HttpClient();
			var response = await client.SendAsync(request);


			var content = await response.Content.ReadAsStringAsync();
			Debug.WriteLine(content);
		}


		public async Task<List<Idea>> GetIdeasAsync(string accessToken)
		{
			var client = new HttpClient();
			client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("bearer", accessToken);


			var json = await client.GetStringAsync("https://localhost:44357/api/values");

			var ideas = JsonConvert.DeserializeObject<List<Idea>>(json);

			return ideas;
		}

		
	}
}
