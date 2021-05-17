using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VnExpress.Data.EF;
using VnExpress.Data.Entities;
using VnExpress.ViewModel.Posts;

namespace VnExpress.Application.Posts
{
    public class PostService : IPostService
    {
        private readonly VnExpressDbContext _context;
        public PostService(VnExpressDbContext context)
        {
            _context = context;

        }
        public async Task<List<PostVm>> GetAll()
        {
            var posts = await _context.Posts.Select(post => new PostVm()
            {
                Id = post.Id,
                Title = post.Title,
                ShortContent = post.ShortContent,
                MainContent = post.MainContent,
                Author = post.Author,
                Images = post.Images,
                CategoryId = post.CategoryId
            }).ToListAsync();
            return posts;

        }
        public async Task<PostVm> GetById(int postId)
        {
            var post = await _context.Posts.FindAsync(postId);
            var postViewModel = new PostVm()
            {
                Id = post.Id,
                Title = post.Title,
                ShortContent = post.ShortContent,
                MainContent = post.MainContent,
                Author = post.Author,
                Images = post.Images,
                CategoryId = post.CategoryId

            };
            return postViewModel;
        }

        public async Task<int> Create(PostCreateRequest request)
        {
            {

                var post = new Post()
                {
                    Title = request.Title,
                    ShortContent = request.ShortContent,
                    MainContent = request.MainContent,
                    Author = request.Author,
                    Images = request.Images,
                    CategoryId = request.CategoryId

                };

                _context.Posts.Add(post);
                await _context.SaveChangesAsync();
                return post.Id;
            }
        }

        public async Task<int> Delete(int postId)
        {
            var post = await _context.Posts.FindAsync(postId);
            if (post == null) throw new Exception($"Cannot find a post: {postId}");
            _context.Posts.Remove(post);
            return await _context.SaveChangesAsync();
        }


        public async Task<int> Update(PostUpdateRequest request)
        {
            var post = await _context.Posts.FindAsync(request.Id);
            if (post == null) throw new Exception($"Cannot find a post with id: {request.Id}");
            post.Title = request.Title;
            post.ShortContent = request.ShortContent;
            post.MainContent = request.MainContent;
            post.Author = request.Author;
            post.Images = request.Images;
            post.CategoryId = request.CategoryId;
            return await _context.SaveChangesAsync();

        }

      
    }
}
