﻿using AspNetCore.BookStore.Models;
using System.Collections.Generic;
using System.Linq;

namespace AspNetCore.BookStore.Repository
{
    public class BookRepository
    {
        public List<Book> GetAllBooks()
        {
            return DataSource();
        }

        public Book GetBookById(int bookId)
        {
            return DataSource().Where(x => x.Id == bookId).FirstOrDefault();
        }

        public List<Book> SearchBook(string title, string authorName)
        {
            return DataSource().Where(x => x.Title.Contains(title) || x.Author.Contains(authorName)).ToList();
        }

        private List<Book> DataSource()
        {
            return new List<Book>()
            {
                new Book(){Id =1, Title="MVC", Author = "Nitish", Description = "This descrition for MVC book", Category="Programming", Language="English", TotalPages=1000},
                new Book(){Id =2, Title="Dot Net Core", Author = "Nitish", Description = "This descrition for .NET CORE book" , Category="Programming", Language="English", TotalPages=1000},
                new Book(){Id =3, Title="C#", Author = "Monika", Description = "This descrition for C# book" , Category="Programming", Language="English", TotalPages=1000},
                new Book(){Id =4, Title="Java", Author = "Webgentle", Description = "This descrition for JAVA book" , Category="Programming", Language="English", TotalPages=1000},
                new Book(){Id =5, Title="Php", Author = "Webgentle", Description = "This descrition for PHP book" , Category="Programming", Language="English", TotalPages=1000},
            };
        }
    }
}
