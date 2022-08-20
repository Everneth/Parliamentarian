using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parliamentarian.Models.Enums
{
    public enum AmendmentType
    {
        PROPOSAL = 1,
        AMENDMENT = 2
    }
    public enum AmendmentStatus
    {
        PASSED = 1,
        FAILED = 2,
        AMENDED = 3
    }

    public enum AmendmentSection
    {
        SECTION1 = 1,
        SECTION2 = 2,
        SECTION3 = 3,
        SECTION4 = 4,
        SECTION5 = 5,
        SECTION6 = 6
    }
}
