﻿using System;using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProductoServicesTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            ProductoWS.ProductoClient proxy = new ProductoWS.ProductoClient();
            
        }
    }
}