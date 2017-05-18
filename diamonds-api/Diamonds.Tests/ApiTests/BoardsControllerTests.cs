﻿using Diamonds.Common.Entities;
using Diamonds.Common.Storage;
using Diamonds.Rest.Controllers;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Diamonds.Tests.ApiTests
{

    public  class BoardsControllerTests
    {
        [Fact]
        public void CanGetBoards()
        {
            // Arrange
            var controller = new BoardsController(new MemoryStorage());

            // Act
            var response = controller.Get();

            // Assert
            var versionResult = (OkObjectResult)response;
            var boards = (IEnumerable<Board>) versionResult.Value;

            Assert.Equal(1, boards.Count());
            Assert.Equal("77", boards.First().BoardId);
        }
    }
}
