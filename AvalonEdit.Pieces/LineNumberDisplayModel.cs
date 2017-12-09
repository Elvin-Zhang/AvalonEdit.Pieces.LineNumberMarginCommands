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


        public bool IsCommandMode
        {
            get { return this.GetValue(() => this.IsCommandMode); }
            set { this.SetValue(() => this.IsCommandMode, value); }
        }

        public string CommandText
        {
            get { return this.GetValue(() => this.CommandText); }
            set { this.SetValue(() => this.CommandText, value); }
        }



    }
}
