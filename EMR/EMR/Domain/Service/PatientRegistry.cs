using EMR.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMR.Domain.Service
{
    public class PatientRegistry : IPatientRegistry
    {
        private readonly ApplicationDbContext _context;

        public PatientRegistry(ApplicationDbContext context)
        {
            _context = context;
        }
        public Patient? Findpatient(string identityNumber)
        {

        }
    }
}
