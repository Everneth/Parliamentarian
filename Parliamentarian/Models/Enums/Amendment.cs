using Discord.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parliamentarian.Models.Enums
{
    public enum AmendmentType
    {
        [ChoiceDisplay("Proposal")]
        PROPOSAL = 1,
        [ChoiceDisplay("Amendment")]
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
        [ChoiceDisplay("Section I")]
        SECTION1 = 1,
        [ChoiceDisplay("Section II")]
        SECTION2 = 2,
        [ChoiceDisplay("Section III")]
        SECTION3 = 3,
        [ChoiceDisplay("Section IV")]
        SECTION4 = 4,
        [ChoiceDisplay("Section V")]
        SECTION5 = 5,
        [ChoiceDisplay("Section VI")]
        SECTION6 = 6
    }

    public enum VoteType
    {
        YAY = 1,
        NAY = 2,
        NAYAMEND = 3
    }
}
