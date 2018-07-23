using Quartz;
using Quartz.Impl;
using System;

namespace SchedularPrac
{
  public  class Scheduler
    {
        public  void Start(DateTime date)

        {

            IScheduler scheduler = StdSchedulerFactory.GetDefaultScheduler();  // método estático getdefaultScheduler
            scheduler.Start();
            IJobDetail job = JobBuilder.Create<Job>().Build(); // utiliza otro patrón de diseño, el buider. Muy utilizado en .net core. Instancia clase job
            ITrigger trigger = TriggerBuilder.Create()
             .WithIdentity("IDGJob", "IDG") // envia entidad usuadio y password
               .StartAt(date)  
               .WithPriority(1)  // máxima con un 1
               .Build(); // para crear el trigger. En Itrigger puedes ver todas las funcionalidades de trigger.
            scheduler.ScheduleJob(job, trigger);  // pasa 2 cosas, el job y el trigger

        }

    }
}
