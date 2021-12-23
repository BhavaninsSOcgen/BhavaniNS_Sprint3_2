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
    public class ProjectModuleTest
    {
        
        [Fact]
        public void GetProjectById_test()
        {


            var ProjectMock = new Mock<IProjectModule>();
            ProjectModule expected = new ProjectModule() { Id = 2, Name = "string", Detail = "string", CreatedOn = "string" };

            var project = ProjectMock.Object;
            var actual = project.GetProjectById(expected.Id);

            Assert.Equal(expected.Id, actual.Id);
            Assert.Equal(expected.Name, actual.Name);
            Assert.Equal(expected.Detail, actual.Detail);
            Assert.Equal(expected.Detail, actual.Detail);
            Assert.Equal(expected.CreatedOn, actual.CreatedOn);

        }

        [Fact]
        public void GetAllProjects_test()
        {
            var ProjectMock = new Mock<IProjectModule>();
            ProjectModule expected = new ProjectModule() { Id = 2, Name = "string", Detail = "string", CreatedOn = "string" };
            var project = ProjectMock.Object;
            var actual = project.GetAllProject();

            Assert.NotNull(actual);
        }

        [Fact]
        public void AddProject_Test()
        {
            var ProjectMock = new Mock<IProjectModule>();
            ProjectModule expected = new ProjectModule() { Id = 5, Name = "string2", Detail = "Detail2", CreatedOn = "2021-02-02" };
            var project = ProjectMock.Object;
            var actual = project.AddProject(expected);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void DeleteProject_test()
        {
            var ProjectMock = new Mock<IProjectModule>();
            ProjectModule expected = new ProjectModule() { Id = 3, Name = "TestProject2", Detail = "This is test project 2", CreatedOn = "2021-12-03 00:00:00" };
            var project = ProjectMock.Object;
            project.DeleteProject(expected.Id);

            Assert.IsType<OkResult>(project);

        }
        [Fact]
        public void UpdateProject_test()
        {
            var ProjectMock = new Mock<IProjectModule>();
            ProjectModule expected = new ProjectModule() { Id = 2, Name = "string3", Detail = "Detail3", CreatedOn = "2021-03-03" };
            var project = ProjectMock.Object;
            var actual = project.UpdateProject(expected.Id, expected);

            Assert.IsType<OkResult>(actual);


        }
    }
}
