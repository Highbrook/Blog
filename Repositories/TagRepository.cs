using Blog.Data;
using Blog.Models.Domain;

namespace Blog.Repositories
{
    public class TagRepository : ITagInterface
    {
        private readonly BlogDbContext blogDbContext;

        public TagRepository(BlogDbContext blogDbContext)
        {
            this.blogDbContext = blogDbContext;
        }


        public async Task<Tag> AddAsync(Tag tag)
        {
            await blogDbContext.Tags.AddAsync(tag);
            await blogDbContext.SaveChangesAsync();
            return tag;
        }

        public Task<Tag?> DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Tag>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Tag?> GetAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Tag?> UpdateAsync(Tag tag)
        {
            throw new NotImplementedException();
        }
    }
}
