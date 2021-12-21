using Microsoft.AspNetCore.Mvc;
using Moq;
using Sprints.Interfaces;
using Sprints.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace SprintsTest
{
    public class TaskModuleTest
    {
        [Fact]

        public void GetTaskById_test()
        {

            var TaskMock = new Mock<ITaskModule>();
            TaskModule expected = new TaskModule() { Id = 1, ProjectId = 1, StatusId = 1, AssignedToUserId = 1, CreatedOn = "2021-01-01", Detail = "string1" };

            var task = TaskMock.Object;
            var actual = task.GetTaskById(expected.Id);

            Assert.Equal(expected.Id, actual.Id);
            Assert.Equal(expected.ProjectId, actual.ProjectId);
            Assert.Equal(expected.StatusId, actual.StatusId);
            Assert.Equal(expected.AssignedToUserId, actual.AssignedToUserId);
            Assert.Equal(expected.Detail, actual.Detail);
            Assert.Equal(expected.CreatedOn, actual.CreatedOn);

        }

        [Fact]

        public void GetAllTasks_test()
        {

            var TaskMock = new Mock<ITaskModule>();
            TaskModule expected = new TaskModule() { Id = 1, ProjectId = 1, StatusId = 1, AssignedToUserId = 1, CreatedOn = "2021-01-01", Detail = "string1" };

            var task = TaskMock.Object;
            var actual = task.GetAllTask();

            Assert.NotNull(actual);

        }

        [Fact]

        public void AddTask_test()
        {
            var TaskMock = new Mock<ITaskModule>();
            TaskModule expected = new TaskModule() { Id = 2, ProjectId = 2, StatusId = 2, AssignedToUserId = 2, CreatedOn = "2021-02-02", Detail = "string2" };

            var task = TaskMock.Object;
            var actual = task.AddTask(expected);

            Assert.Equal(expected, actual);

        }

        [Fact]
        public void DeleteTask_test()
        {
            var TaskMock = new Mock<ITaskModule>();
            TaskModule expected = new TaskModule() { Id = 1, ProjectId = 1, StatusId = 1, AssignedToUserId = 1, CreatedOn = "2021-01-01", Detail = "string1" };
            var task = TaskMock.Object;
            task.DeleteTask(2);

            Assert.IsType<OkResult>(task);
        }

        [Fact]

        public void UpdateTask_test()
        {
            var TaskMock = new Mock<ITaskModule>();
            TaskModule expected = new TaskModule() { Id = 3, ProjectId = 2, StatusId = 2, AssignedToUserId = 2, CreatedOn = "2021-02-02", Detail = "string2" };
            var task = TaskMock.Object;
            var actual = task.UpdateTask(expected.Id, expected);

            Assert.IsType<OkResult>(actual);
        }
    }
}
