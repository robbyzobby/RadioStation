using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace Radio_Station_Library
{
    public class MusicPlayer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1060:MovePInvokesToNativeMethodsClass"), System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Portability", "CA1901:PInvokeDeclarationsShouldBePortable", MessageId = "3"), System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA2101:SpecifyMarshalingForPInvokeStringArguments", MessageId = "0"), System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA2101:SpecifyMarshalingForPInvokeStringArguments", MessageId = "1"), System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Portability", "CA1901:PInvokeDeclarationsShouldBePortable", MessageId = "return"), DllImport("winmm.dll")]
        private static extern long MciSendString(string lpstrCommand, StringBuilder lpstrReturnString, int UReturnLength, int hwndCallback);

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
        public void Open(string file)
        {
            string command = "open \"" + file + "\" type MPEGVideo alias MyMp3";
            MciSendString(command, null, 0, 0);
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
        public void Play()
        {
            string command = "play MyMp3";
            MciSendString(command, null, 0, 0);
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
        public void Stop()
        {
            string command = "stop MyMp3";
            MciSendString(command, null, 0, 0);

            command = "close MyMp3";
            MciSendString(command, null, 0, 0);
        }
    }
}
