using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XNBNodeUIWrapper
{
    public class XNBHelper
    {
        public static void Unpack(string source, string target)
        {
            RunXNBNode("extract \"" + source + "\" \"" + target + "\"");
        }

        public static void Repack(string source, string target)
        {
            RunXNBNode("pack " + source + " " + target);
        }

        private static void RunXNBNode(string cmd)
        {
            var prc = new ProcessStartInfo();
            prc.FileName = "xnb_node.cmd";
            prc.Arguments = cmd;
            prc.UseShellExecute = false;
            Process.Start(prc);
        }
    }
}
