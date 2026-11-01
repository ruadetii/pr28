using System.Collections.ObjectModel;
using TaskManager_Radosteva.Classes;
using TaskManager_Radosteva.Context;
using TaskManager_Radosteva.Models;

namespace TaskManager_Radosteva.ViewModels
{
    public class VM_Tasks : Notification
    {
        public TasksContext tasksContext = new TasksContext();
        public ObservableCollection<Tasks> Tasks { get; set; }
        public VM_Tasks() =>
            Tasks = new ObservableCollection<Tasks>(tasksContext.Tasks.OrderBy(x => x.Done));

        public RealyCommand OnAddTask
        {
            get { 
                return new RealyCommand(obj => { 
                    Tasks NewTask = new Tasks() 
                    {
                        DateExecute = DateTime.Now 
                    };
                    Tasks.Add(NewTask); 
                    tasksContext.Tasks.Add(NewTask); 
                    tasksContext.SaveChanges(); 
                });
            }
        }
    }
}
