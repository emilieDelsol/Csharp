using apiRestFullHtml.Models;
using apiRestFullHtml.Models.Blog;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;

namespace apiRestFullHtml.Models
{
	public class MonBlog
	{
		public static List<Article> GetArticle(string userId)
		{
			WebClient webClient = new WebClient();
			webClient.BaseAddress = ($"https://jsonplaceholder.typicode.com/");
			var responsePost = webClient.DownloadString($"users/{userId}/posts/ ");
			List<Article> articles = new List<Article>();
			List<Post> posts = JsonConvert.DeserializeObject<List<Post>>(responsePost);
			foreach (Post thisPost in posts)
			{
				var comments = webClient.DownloadString($"post/{thisPost.Id}/comments");
				List<Comments> commentsList = JsonConvert.DeserializeObject<List<Comments>>(comments);
				articles.Add(new Article { Post = thisPost, ListComments = commentsList });
			}
			return articles;
		}


		public static List<UserAlbum> GetPhotos(string userId)
		{
			WebClient webClient = new WebClient();
			webClient.BaseAddress = ($"https://jsonplaceholder.typicode.com/");

			var albumResponse = webClient.DownloadString($"users/{userId}/albums");
			List<UserAlbum> userAlbumsList = new List<UserAlbum>();

			List<Album> albums = JsonConvert.DeserializeObject<List<Album>>(albumResponse);
			foreach (Album album in albums)
			{
				var photoResponse = webClient.DownloadString($"album/{album.Id}/photos");
				List<Photos> photos = JsonConvert.DeserializeObject<List<Photos>>(photoResponse);
				userAlbumsList.Add(new UserAlbum {PhotosList = photos, AlbumId=album.Id }) ;
			}
			return userAlbumsList;
		}
	}
}