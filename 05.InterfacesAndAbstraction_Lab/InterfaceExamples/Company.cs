using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExamples
{
    class Company
    {
        public List<IWorker> Workers { get; set; }

        public Company()
        {
            Workers = new List<IWorker>();
        }

        public void WorkDay()
        {
            Workers.ForEach((worker) =>
            {
                worker.Work();
            });
        }

        public void Salaryday()
        {
            Workers.ForEach((worker) =>
            {
                worker.GetSalary();
            });
        }
    }
}
