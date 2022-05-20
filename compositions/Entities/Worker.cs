using Compositions.Entities;

namespace Composition.Entities
{
    class WorkerLever
    {
        public string Name {  get; set; }
        public WorkerLever Level { get; set; }

        public double BaseSalary { get; set; }


    }
}