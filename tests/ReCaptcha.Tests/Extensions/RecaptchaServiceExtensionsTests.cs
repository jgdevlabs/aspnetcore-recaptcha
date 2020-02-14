﻿using System.Linq;
using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;

namespace ReCaptcha.Tests.Extensions
{
    [TestFixture]
    public class RecaptchaServiceExtensionsTests
    {
        [Test]
        public void AddRecaptchaService_ShouldAddAllRequired_WithDefaultOptions()
        {
            // Arrange
            var services = new ServiceCollection();

            // Act
            services.AddRecaptchaService();

            // Assert
            Assert.IsTrue(services.Any(service => service.ServiceType.FullName == "GSoftware.AspNetCore.ReCaptcha.Services.IRecaptchaService"));
            Assert.IsTrue(services.Any(service => service.ServiceType.FullName == "GSoftware.AspNetCore.ReCaptcha.Filters.ValidateRecaptchaFilter"));
            Assert.IsTrue(services.Any(service => service.ServiceType.FullName == "Microsoft.Extensions.Options.IConfigureOptions`1[[GSoftware.AspNetCore.ReCaptcha.Configuration.RecaptchaOptions, GSoftware.AspNetCore.ReCaptcha, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]]"));
            Assert.IsTrue(services.Any(service => service.ServiceType.FullName == "Microsoft.Extensions.Options.IConfigureOptions`1[[GSoftware.AspNetCore.ReCaptcha.Configuration.RecaptchaSettings, GSoftware.AspNetCore.ReCaptcha, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]]"));
        }
    }
}