﻿using Microsoft.AspNetCore.Mvc;
using UnitOfWorkRepositoryPatternProject.Core.Entities;
using UnitOfWorkRepositoryPatternProject.Core.Models;
using UnitOfWorkRepositoryPatternProject.Service.Interface;

namespace UnitOfWorkRepositoryPatternProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        public readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpGet]
        public async Task<ActionResult<List<Product>>> Get()
        {
            try
            {
                var products = await _productService.GetAllProduct();
                return Ok(products);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpGet("GetProduct")]
        public async Task<ActionResult<List<Product>>> GetProduct([FromQuery]PaginationDto pagination)
        {
            try
            {
                var products = await _productService.GetAllProductWithPagination(pagination);
                return Ok(products);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        [HttpGet("GetProductWithCategory")]
        public async Task<ActionResult> GetProductWithCategory()
        {
            try
            {
                var products = await _productService.GetProductWithCategory();
                return Ok(products);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //[HttpPost("AddProduct")]
        //public async Task<ActionResult> AddProduct()
        //{
        //    try
        //    {
        //    }
        //    catch (Exception ex)
        //    {

        //        throw new Exception(ex.Message);
        //    }
        //}
    }
}
