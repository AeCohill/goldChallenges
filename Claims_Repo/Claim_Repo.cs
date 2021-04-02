using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Claims_Repo
{
    public class Claim_Repo
    {
        private Queue<Claim> _queue = new Queue<Claim>();
        //Helper Method
        public void GotoNext()
        {
            Console.WriteLine(_queue.Peek());

        }

        //Get Claim
        public Queue<Claim> GetQueue(Q)
        {
            return _queue;

        }
        //Process Claim
        public void DeQueueNext()
        {
            _queue.Dequeue();

        }
        //Create New Claim
        public void CreateNew(Claim claim)
        {
           _queue.Enqueue(claim);

        }
      



    }
}
