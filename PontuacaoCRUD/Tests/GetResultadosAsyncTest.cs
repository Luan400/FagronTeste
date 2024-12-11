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
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PontuacaoCRUD.Tests
{
    public class GetResultadosAsync
    {
       private readonly ResultadosController _controller;
       private readonly Mock<PontuacaoDbContext> _mockContext;
    }
}