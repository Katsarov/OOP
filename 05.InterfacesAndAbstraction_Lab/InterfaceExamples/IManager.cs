using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExamples
{
    public interface IManager : IWorker
    {
        public List<IWorker> Team { get; set; }
    }
}
