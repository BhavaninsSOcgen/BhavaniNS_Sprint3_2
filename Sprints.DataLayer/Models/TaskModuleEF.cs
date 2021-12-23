using Sprints.DataLayer.Context;
using Sprints.DataLayer.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Sprints.DataLayer.Models
{
   
        public class TaskModuleEf : ITaskModule
        {

            private readonly AppDbContext _context;

            public TaskModuleEf(AppDbContext context)
            {
                _context = context;
            }
            public TaskModule AddTask(TaskModule task)
            {

                _context.TaskModule.Add(task);
                _context.SaveChanges();
                return task;
            }

            public void DeleteTask(int id)
            {
                TaskModule task = GetTaskById(id);
                _context.TaskModule.Remove(task);
                _context.SaveChanges();
            }

            public List<TaskModule> GetAllTask()
            {
                return _context.TaskModule.ToList();
            }

            public TaskModule GetTaskById(int id)
            {
                return _context.TaskModule.FirstOrDefault(usr => usr.Id == id);
            }

            public TaskModule UpdateTask(int id, TaskModule task)
            {
                var DatatobeUpdated = _context.TaskModule.FirstOrDefault(usr => usr.Id == id);
                if (DatatobeUpdated != null)
                {
                    DatatobeUpdated.ProjectId = task.ProjectId;
                    DatatobeUpdated.StatusId = task.StatusId;
                    DatatobeUpdated.AssignedToUserId = task.AssignedToUserId;
                    DatatobeUpdated.Detail = task.Detail;
                    DatatobeUpdated.CreatedOn = task.CreatedOn;

                    _context.SaveChanges();

                }
                return task;

            }
        }
    }

