using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Insurance_Claim_Repository
{
    public class ClaimRepository
    {

        private Queue<Claim> _contentQueue = new Queue<Claim>();

        public void AddToQueue(Claim content)
        {
            _contentQueue.Enqueue(content);
        }
        public Claim GetNextClaim()
        {
            Claim nextClaim = _contentQueue.Dequeue();
            return nextClaim;
        }
        public Claim PeekNextContent()
        {
            return _contentQueue.Peek();
        }
        public Queue<Claim> GetClaimQueue()
        {
            return _contentQueue;
        }







    }
}
