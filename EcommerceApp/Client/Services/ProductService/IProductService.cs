﻿using EcommerceApp.Shared;

namespace EcommerceApp.Client.Services.ProductService
{
    public interface IProductService
    {
        List<Product> Products { get; set; }
        Task GetProducts();
    }
}