﻿using AppMVCBasica.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AppMVCBasica.Data;
public class ApplicationDbContext : IdentityDbContext
{
    public DbSet<Produto> Produtos { get; set; }
    public DbSet<Fornecedor> Fornecedores   { get; set; }
    public DbSet<Endereco> Enderecos { get; set; }


    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
}
