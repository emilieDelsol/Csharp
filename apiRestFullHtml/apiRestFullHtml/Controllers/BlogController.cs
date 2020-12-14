using apiRestFullHtml.Models;
using apiRestFullHtml.Models.Blog;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace apiRestFullHtml.Controllers
{
	public class BlogController : Controller
	{
		
		public IActionResult Index(String userId)
		{
			List<Article> articles = MonBlog.GetArticle(userId);
			List<UserAlbum> albums = MonBlog.GetPhotos(userId);
			UserArticlesPhotos userArticlesPhotos = new UserArticlesPhotos { Articles = articles, userAlbums = albums };
			return View("Index", userArticlesPhotos);
		}
		public IActionResult Test(String userId)
		{
			List<Article> articles = MonBlog.GetArticle(userId);
			List<UserAlbum> albums = MonBlog.GetPhotos(userId);
			UserArticlesPhotos userArticlesPhotos = new UserArticlesPhotos { Articles = articles, userAlbums = albums };
			return View("Test", userArticlesPhotos);
		}
	}
}
