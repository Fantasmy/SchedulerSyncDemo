using Quartz;

namespace SchedularPrac
{
    public class Job : IJob  // implementa Ijob
    {
        public void Execute(IJobExecutionContext context)  // método Execute
        {
            Form2 fm = new Form2();
            fm.ShowDialog();
        }
    }
}
