using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    public class Scheduler : IEntryManager<ScheduleTask>
    {
        private readonly List<ScheduleTask> _scheduleTasks;

        public Scheduler()
        {
            _scheduleTasks = new List<ScheduleTask>();
        }

        public void AddEntry(ScheduleTask entry) => _scheduleTasks.Add(entry);

        public void RemoveEntryAt(int index) => _scheduleTasks.RemoveAt(index);

        public override string ToString() => 
            string.Join(Environment.NewLine, _scheduleTasks.Select(x => $"Task with id: {x.TaskId} with content: {x.Content} is going to be executed on: {x.ExecuteOn}"));
    }
}
