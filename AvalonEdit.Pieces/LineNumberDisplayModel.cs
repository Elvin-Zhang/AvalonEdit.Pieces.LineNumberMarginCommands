using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvalonEdit.Pieces
{
    public class LineNumberDisplayModel : Dependencies.WPFViewModelBase.ViewModelBase
    {

        public int LineNumber
        {
            get { return this.GetValue(() => this.LineNumber); }
            set { this.SetValue(() => this.LineNumber, value); }
        }

        public string CommandText
        {
            get { return this.GetValue(() => this.CommandText); }
            set { this.SetValue(() => this.CommandText, value); }
        }

        // each line number is a specific height
        public double ControlHeight
        {
            get { return this.GetValue(() => this.ControlHeight); }
            set { this.SetValue(() => this.ControlHeight, value); }
        }


        public bool IsInView
        {
            get { return this.GetValue(() => this.IsInView); }
            set { this.SetValue(() => this.IsInView, value); }
        }



    }
}
