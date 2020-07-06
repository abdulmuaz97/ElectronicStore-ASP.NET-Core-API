﻿using ElectronicsStore.Domain.Models;
using ElectronicsStore.Domain.Services.Communication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElectronicsStore.Domain.Repositories {
    public interface ICategoriesRepository {

        public Task<IEnumerable<Category>> GetAllAsync();

        public Task<Category> FindAsync(Guid id);
        
        public Task<Category> AddAsync(Category category);

        public Task<Category> Update(Category category);

        public Task<bool> Delete(Category category);
    }
}