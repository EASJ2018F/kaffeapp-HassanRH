using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kaffe
{
    public class FlatWhite : Kaffe, Imælk
    {
        /// <summary>
        /// Her kan vi se hvor meget mælk der skal være i Flatwhite
        /// </summary>
        /// <returns></returns>
        public int MlMælk()
        {
            return 160;
        }

        /// <summary>
        /// Her kan vi se hvor meget prisen er på flatwhite
        /// </summary>
        /// <returns></returns>
        public override int Pris()
        {
            return 45;
        }

        /// <summary>
        /// Her kan vi se hvad styren på kaffen er i dette tilflde er den mild.
        /// </summary>
        /// <returns></returns>
        public override string Styrke()
        {
            return "Mild";
        }
    }
}
