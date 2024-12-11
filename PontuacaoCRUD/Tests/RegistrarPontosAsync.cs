using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using Moq;
using PontuacaoCRUD.Controller;
using PontuacaoCRUD.Models;
using PontuacaoCRUD.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using PontuacaoCRUD.Entitites;


namespace PontuacaoCRUD.Tests
{
    public class RegistrarPontosAsync
    {
        private readonly JogosController _controller;
        private readonly Mock<PontuacaoDbContext> _mockContext;

        public RegistrarPontosAsync()
        {
            var options = new DbContextOptionsBuilder<PontuacaoDbContext>()
                            .UseInMemoryDatabase(databaseName: "PontuacaoDB")
                            .Options;
            var context = new PontuacaoDbContext(options);
            _controller = new JogosController(context);
        }

        [Fact]
        public async Task RegistrarPontosAsync_ReturnsOkResult_WhenGameIsRegistered()
        {
       
            var jogo = new Jogo { Id = 1, Date = new System.DateTime(2023, 4, 1), Points = 15 };

          
            var result = await _controller.RegistrarPontosAsync(jogo);

        
            var okResult = Assert.IsType<OkResult>(result);
        }
    }
}