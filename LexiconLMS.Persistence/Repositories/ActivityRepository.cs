﻿using LexiconLMS.Persistence.Data;
using System.Linq.Expressions;

namespace LexiconLMS.Persistence.Repositories
{
    public class ActivityRepository : IRepository<Activity>
    {
        private readonly LexiconDbContext _context;

        public ActivityRepository(LexiconDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Activity>> GetListAsync()
        {
            var activities = await _context.Activities
                .Include(a => a.Module)
                .ToListAsync();

            return activities;
        }

        public async Task<IEnumerable<Activity>> GetFilteredAsync(Expression<Func<Activity, bool>> predicate)
        {
            var activities = await _context.Activities
                .Include(a => a.Module)
                .Where(predicate)
                .ToListAsync();

            return activities;
        }

        public async Task<Activity?> GetByIdAsync(int id)
        {
            var activity = await _context.Activities
                .Include(a => a.Module)
                .Include(a => a.Documents)
                .FirstOrDefaultAsync(a => a.Id == id);

            return activity;
        }

        public async Task<Activity> CreateAsync(Activity entity)
        {
            var entry = await _context.Activities.AddAsync(entity);
            return entry.Entity;
        }

        public void Update(Activity entity) => _context.Activities.Update(entity);
        public void Delete(Activity entity) => _context.Activities.Remove(entity);
    }
}
