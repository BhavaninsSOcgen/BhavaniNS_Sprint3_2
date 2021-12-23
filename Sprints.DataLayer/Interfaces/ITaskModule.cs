using Sprints.DataLayer.Models;
using System.Collections.Generic;

namespace Sprints.DataLayer.Interfaces
{
    public interface ITaskModule
    {
        List<TaskModule> GetAllTask();
        TaskModule GetTaskById(int id);
        TaskModule AddTask(TaskModule task);
        TaskModule UpdateTask(int id, TaskModule task);
        void DeleteTask(int id);
    }
}
