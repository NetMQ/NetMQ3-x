using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace NetMQ.Tests
{
    [SetUpFixture]
    public class Setup
    {
        [TearDown]
        public void TearDown()
        {
            NetMQConfig.Cleanup(false);
        }
    }
}
