﻿using Couchbase.Authentication;
using Couchbase.Configuration.Client;
using NUnit.Framework;

namespace Couchbase.UnitTests
{
    [TestFixture]
    public class ClusterHelperTests
    {
        [Test]
        public void Initialized_AfterInit_ReturnsTrue()
        {
            Assert.False(ClusterHelper.Initialized);
            ClusterHelper.Initialize(new ClientConfiguration());

            Assert.True(ClusterHelper.Initialized);
        }

        [Test]
        public void Initialized_AfterClose_ReturnsFalse()
        {
            ClusterHelper.Initialize(new ClientConfiguration());
            Assert.True(ClusterHelper.Initialized);

            ClusterHelper.Close();
            Assert.False(ClusterHelper.Initialized);
        }

        [Test]
        public void Cluster_Uses_Provided_Authenticator()
        {
            var config = new ClientConfiguration();
            config.SetAuthenticator(new PasswordAuthenticator("username", "password"));
            ClusterHelper.Initialize(config);

            Assert.AreEqual(config.Authenticator, ClusterHelper.Get().Configuration.Authenticator);
        }

        [TearDown]
        public void TearDown()
        {
            // clear after each test
            ClusterHelper.Close();
        }
    }
}
