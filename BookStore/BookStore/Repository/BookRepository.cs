using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Repository
{
	public class BookRepository
	{
		public List<BookModel> GetAllBooks()
		{
			return DataSource();
		}

		public BookModel GetBookById(int id)
		{
			return DataSource().Where(x => x.Id == id).FirstOrDefault();
		}

		public List<BookModel> SearchBook(string title, string authorName)
		{
			return DataSource().Where(x => x.Title.Contains(title) || x.Author.Contains(authorName)).ToList();
		}

		public List<BookModel> DataSource()
		{
			return new List<BookModel>()
			{
				new BookModel(){ Id = 1, Title = "MVC ASP.NET", Author = "Ali"},
				new BookModel(){ Id = 2, Title = "Dot Net", Author = "Dawood"},
				new BookModel(){ Id = 3, Title = "Java", Author = "David"},
				new BookModel(){ Id = 4, Title = "PHP fro bigginer", Author = "Nohe"},
				new BookModel(){ Id = 5, Title = "Ruby", Author = "Yousef"},
				new BookModel(){ Id = 6, Title = "HTML & CSS", Author = "Mohammed"},
				new BookModel(){ Id = 7, Title = "C# from scratch", Author = "Ahmed"}
			};
		}
	}
}
