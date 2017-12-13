using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvalonEdit.Pieces
{
    public class MaxLineNumberLengthChangedEventArgs : EventArgs
    {
        public System.Windows.Size NewSize { get; set; }
    }
}
