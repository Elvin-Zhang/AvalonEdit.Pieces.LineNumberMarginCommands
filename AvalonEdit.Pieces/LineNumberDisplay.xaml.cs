﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AvalonEdit.Pieces
{
    /// <summary>
    /// Interaction logic for LineNumberDisplay.xaml
    /// </summary>
    public partial class LineNumberDisplay : UserControl
    {

        #region Model DP

        public static readonly DependencyProperty ModelProperty = DependencyProperty.Register("Model", typeof(LineNumberDisplayModel), typeof(LineNumberDisplay));

        public LineNumberDisplayModel Model
        {
            get { return (LineNumberDisplayModel)this.GetValue(ModelProperty); }
            set { this.SetValue(ModelProperty, value); }
        }

        #endregion

        public LineNumberDisplay()
        {
            InitializeComponent();

            this.Model = new LineNumberDisplayModel();
            this.Model.LineNumber = 99;
        }


        private void lineNumberTextBlock_MouseEnter(object sender, MouseEventArgs e)
        {
            var tb = sender as TextBlock;
            this.Model.IsCommandMode = true;
        }

        private void lineNumberTextBox_MouseLeave(object sender, MouseEventArgs e)
        {
            var tb = sender as TextBox;
            this.Model.IsCommandMode = false;

        }



    }
}