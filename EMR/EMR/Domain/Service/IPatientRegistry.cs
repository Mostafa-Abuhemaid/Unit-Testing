using EMR.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMR.Domain.Service
{
    public interface IPatientRegistry
    {
        Patient? Findpatient(string identityNumber);
    }
}
