using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;

namespace ConsoleAppQueteResFull
{
	class Program
	{
		static void Main(string[] args)
		{
			WebClient webClient = new WebClient();
			Console.WriteLine("quelle utilisateur voulez-vous voir?");
			string number = Console.ReadLine();
			
			webClient.BaseAddress = ($"https://jsonplaceholder.typicode.com/");
			var responsePost = webClient.DownloadString($"users/{ number}/posts/ ");
			var  userResponse = webClient.DownloadString($"users/{number}");
			var albumResponse = webClient.DownloadString($"users/{number}/albums");

			List<Album> albums = JsonConvert.DeserializeObject<List<Album>>(albumResponse);
			
			
			Users user = JsonConvert.DeserializeObject<Users>(userResponse);
			Console.WriteLine($"You choose id : {user.Id}, name: {user.Name}");

			List<Post> posts = JsonConvert.DeserializeObject<List<Post>>(responsePost);
			foreach(Post post in posts)
			{
				var comments = webClient.DownloadString($"post/{post.Id}/comments");
				List<Comments> commentsList = JsonConvert.DeserializeObject<List<Comments>>(comments);
				Console.WriteLine($"Post n° {post.Id} \t Titre: {post.Title} \n\t\t Contenu: {post.Body}\n");
				Console.WriteLine($"Commmentaires du post n° {post.Id}");
				foreach(Comments comment in commentsList)
				{
					Console.WriteLine(comment);
				}
			}

			Console.WriteLine($"Toutes les photos de l'utilisateur {user.Id} {user.Name}: ");

			foreach (Album album in albums)
			{
				var photoResponse = webClient.DownloadString($"album/{album.Id}/photos");
				List<Photos> photos = JsonConvert.DeserializeObject<List<Photos>>(photoResponse);
				foreach( Photos photo in photos) { Console.WriteLine($"photo\t {photo}"); };
			}


		}
	}
}
