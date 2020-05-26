using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_2
{
    public class Repository
    {
        private Queue<Claim> _claimList = new Queue<Claim>();

        //Create
        public void AddItemsToLibrary(Claim claim)
        {
            _claimList.Enqueue(claim);
        }

        //Read
        public Queue<Claim> GetClaim()
        {
            return _claimList;
        }

        

    }

}

