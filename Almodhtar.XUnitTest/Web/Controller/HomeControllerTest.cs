using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Almodhtar.Controllers;
using Almodhtar.Data.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Almodhtar.XUnitTest.Web.Controller
{
    public class HomeControllerTest
    {
        private readonly Mock<IUnitOfWork> _moqIUnitOfWork;
        private readonly Mock<IHttpContextAccessor> _moqIHttpContextAccessor;
        private readonly HomeController _controller;

        public HomeControllerTest()
        {
            _moqIUnitOfWork = new Mock<IUnitOfWork>();
            _moqIHttpContextAccessor = new Mock<IHttpContextAccessor>();
            _controller = new HomeController(_moqIUnitOfWork.Object, _moqIHttpContextAccessor.Object);
        }


        [Fact]
        public void ReturnViewForTestAction()
        {
            IActionResult result = _controller.Test();
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public async Task ReturnNotFoundIfCategoryIdIsNullForNewsInCategoryAction()
        {
            var result = await _controller.NewsInCategory(null, null);
            Assert.IsType<NotFoundResult>(result);
        }
    }
}
