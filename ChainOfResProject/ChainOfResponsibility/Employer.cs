using ChainOfResProject.Models;

namespace ChainOfResProject.ChainOfResponsibility
{
    public  abstract class Employer
    {
        protected Employer NextApprover;
        public  void SetNextAprrover(Employer superVisior)
        {
            this.NextApprover = superVisior;
        }

        public abstract void ProcessRequest(CustomerProcessViewModel model);
       
    }
}
