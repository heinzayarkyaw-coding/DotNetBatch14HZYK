using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetBatch14HZYK.ConsoleApp3.EFCoreExamples
{
    public class EFCoreExample
    {
        private readonly AppDbContext _db = new AppDbContext();

        public void Read()
        {
            var lst = _db.Blogs.ToList();
            foreach (var item in lst)
            {
                Console.WriteLine(item.Id);
                Console.WriteLine(item.Title);
                Console.WriteLine(item.Author);
                Console.WriteLine(item.Content);
            }
        }

        public void Edit(string id)
        {
            var item = _db.Blogs.FirstOrDefault(x => x.Id == id);
            if (item == null)
            {
                Console.WriteLine("No Data Found");
                return;
            }

            {
                Console.WriteLine(item.Id);
                Console.WriteLine(item.Title);
                Console.WriteLine(item.Author);
                Console.WriteLine(item.Content);
            }
        }


        public void Create(string Title, string Author, string Content)
        {
           
            var blog = new TblBlog { Id = Guid.NewGuid().ToString(), Title = Title, Author = Author, Content = Content };

            _db.Blogs.Add(blog);
            var result = _db.SaveChanges();

            string message = result > 0 ? "saving successful." : "saving failed.";
            Console.WriteLine(message);
        }



        public void Update(string id, string title, string author, string content)
        {
            var item = _db.Blogs.AsNoTracking().FirstOrDefault(x => x.Id == id);
            if (item is null)
            {
                Console.WriteLine("No data found.");
                return;
            }

            item.Title = title;
            item.Author = author;
            item.Content = content;

            _db.Entry(item).State = EntityState.Modified;
            var result = _db.SaveChanges();

            string message = result > 0 ? "Updating Successful." : "Updating Failed.";
            Console.WriteLine(message);
        }

        public void Delete(string id)
        {
            var item = _db.Blogs.AsNoTracking().FirstOrDefault(x => x.Id == id);
            if (item is null)
            {
                Console.WriteLine("No data found.");
                return;
            }

            _db.Entry(item).State = EntityState.Deleted;
            var result = _db.SaveChanges();

            string message = result > 0 ? "Deleting Successful." : "Deleting Failed.";
            Console.WriteLine(message);
        }
    }

}

