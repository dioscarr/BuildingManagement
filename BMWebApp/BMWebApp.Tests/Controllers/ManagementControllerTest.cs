using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BMWebApp;
using BMWebApp.Controllers;
using System.Web.Mvc;

namespace BMWebApp.Tests.Controllers
{
    [TestClass]
    public class ManagementControllerTest
    {
        [TestMethod]
        public void Index() 
        {
            //Arrange
            ManagementController Management = new ManagementController();

            //Act
            ActionResult result = Management.Index() as ActionResult;

            //Assert
            Assert.IsNotNull(result);
        }



        [TestMethod]
        public void ManagementCompany() 
        {
            //Arrange
            ManagementController Management = new ManagementController();

            //Act
            ActionResult result = Management.ManagementCompany() as ActionResult;

            Assert.IsNotNull(result);
        
        }
      

    }
}
