using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pustok.Business.Exceptions;

public class NotFoundException:Exception
{
    public NotFoundException():base("Object not found. Axtarmağa davam.")
    {
        
    }

    public NotFoundException(string message):base(message)
    {

    }
}
