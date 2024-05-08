using ChainOfResProject.DAL;
using ChainOfResProject.Models;

namespace ChainOfResProject.ChainOfResponsibility
{
    public class Treasurer : Employer
    {
        private readonly Context _context;

        public Treasurer(Context context)
        {
            _context = context;
        }

        public override void ProcessRequest(CustomerProcessViewModel model)
        {
            if (model.Amount <= 80000)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = model.Amount;
                customerProcess.Name = model.Name;
                customerProcess.EmployerName = "Elif Çalış";
                customerProcess.Description = "İstenen Tutar Müşteriye Veznedar Tarafından Ödendi";
                _context.CustomerProcesses.Add(customerProcess);
                _context.SaveChanges();
            }
            else if(NextApprover != null)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = model.Amount;
                customerProcess.Name = model.Name;
                customerProcess.EmployerName = "Elif Çalış";
                customerProcess.Description = "Ödeme Veznedar Tarafından Yapılamadı ve İşlem Şube Müdür Yrdç Gönderildi";
                _context.CustomerProcesses.Add(customerProcess);
                _context.SaveChanges();
                NextApprover.ProcessRequest(model);

            }
        }
    }
}
