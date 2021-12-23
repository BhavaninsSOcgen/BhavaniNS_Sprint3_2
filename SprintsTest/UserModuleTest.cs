using Microsoft.AspNetCore.Mvc;
using Moq;
using Sprints.DataLayer.Interfaces;
using Sprints.DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
namespace SprintsTest
{
    public class UserModuleTest
    {
        [Fact]
        public void GetUserById_test()
        {

            var UserMock = new Mock<IUserModule>();
            UserModule expected = new UserModule() { Id = 1, FirstName = "string1", LastName = "string1", Email = "abc@gmail.com", Password = "abcd" };

            var User = UserMock.Object;
            var actual = User.GetUserById(expected.Id);

            Assert.Equal(expected.Id, actual.Id);
            Assert.Equal(expected.FirstName, actual.FirstName);
            Assert.Equal(expected.LastName, actual.LastName);
            Assert.Equal(expected.Email, actual.Email);
            Assert.Equal(expected.Password, actual.Password);
        }

        [Fact]
        public void GetAllUsers_test()
        {

            var UserMock = new Mock<IUserModule>();
            UserModule expected = new UserModule() { Id = 1, FirstName = "string1", LastName = "string1", Email = "abc@gmail.com", Password = "abcd" };

            var User = UserMock.Object;
            var actual = User.GetAllUsers();

            Assert.NotNull(actual);

        }

        [Fact]
        public void AddUser_test()
        {
            var UserMock = new Mock<IUserModule>();
            UserModule expected = new UserModule() { Id = 1, FirstName = "string1", LastName = "string1", Email = "abc@gmail.com", Password = "abcd" };

            var User = UserMock.Object;
            var actual = User.AddUser(expected);

            Assert.Equal(expected, actual);

        }

        [Fact]
        public void DeleteUser_test()
        {
            var UserMock = new Mock<IUserModule>();
            UserModule expected = new UserModule() { Id = 1, FirstName = "string1", LastName = "string1", Email = "abc@gmail.com", Password = "abcd" };
            var User = UserMock.Object;
            var actual = User.GetUserById(expected.Id);
            User.DeleteUser(actual.Id);

            Assert.IsType<OkResult>(User);
        }

        [Fact]
        public void UpdateUser_test()
        {
            var UserMock = new Mock<IUserModule>();
            UserModule expected = new UserModule() { Id = 3, FirstName = "string3", LastName = "string3", Email = "abcdef@gmail.com", Password = "abcdf" };
            var User = UserMock.Object;
            var actual = User.UpdateUser(expected.Id, expected);

            Assert.IsType<OkResult>(actual);
        }
    }
}
