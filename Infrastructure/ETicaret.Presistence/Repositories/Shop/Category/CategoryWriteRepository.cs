﻿using ETicaret.Application.Repositories.Shop;
using ETicaret.Domain.Entities;
using ETicaret.Presistence.Contexts;

namespace ETicaret.Presistence.Repositories.Shop;

public class CategoryWriteRepository : WriteRepository<Category>, ICategoryWriteRepository
{
    public CategoryWriteRepository(ETicaretDbContext context) : base(context)
    {
    }
}