﻿namespace LexiconLMS.Persistence.Repositories
{
    public class DocumentRepository : IRepository<Document>
    {
        private readonly LexiconDbContext _context;

        public DocumentRepository(LexiconDbContext context)
        {
            _context = context;
        }

        public Task<Document> GetListAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Document?> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Document> CreateAsync(Document entity)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Document entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Document entity)
        {
            throw new NotImplementedException();
        }
    }
}
