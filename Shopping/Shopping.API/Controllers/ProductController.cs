﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using Shopping.API.Data;
using Shopping.API.Models;

namespace Shopping.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ILogger<ProductController> _logger;
        private readonly ProductContext _context;

        public ProductController(ProductContext context, ILogger<ProductController> logger)
        {
            this._logger = logger;
            this._context = context;
        }

        [HttpGet]
        public async Task<IEnumerable<Product>> Get() 
        {
            return await _context.Products.Find(p => true).ToListAsync();
        }
    }
}
