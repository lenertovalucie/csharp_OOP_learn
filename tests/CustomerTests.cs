using System;
using Xunit;
using AutoFixture;
using AutoFixture.AutoMoq;
using AutoFixture.Xunit2;
using ACM.BL;


namespace tests
{
    public class CustmerTests
    {
        [Theory, AutoData]
        public void FullNameValidTest(Customer sut)
        {
            Assert.Equal($"{sut.LastName}, {sut.FirstName}", sut.FullName);
        }

        [Theory, AutoData]
        public void FullNameLastNameEmptyTest(Customer sut)
        {
            sut.LastName = "";
            Assert.Equal($"{sut.FirstName}", sut.FullName);
        }

        [Theory, AutoData]
        public void FullNameFirstNameEmptyTest(Customer sut)
        {
            sut.FirstName = "";
            Assert.Equal($"{sut.LastName}", sut.FullName);
        }
    }
}
