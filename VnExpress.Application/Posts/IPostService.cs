using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using VnExpress.ViewModel.Posts;

namespace VnExpress.Application.Posts
{
    public interface IPostService
    {
        Task<PostVm> GetById(int postId);
        Task<int> Create(PostCreateRequest request);
        Task<int> Delete(int postId);
        Task<int> Update(PostUpdateRequest request);
        
    }
}
