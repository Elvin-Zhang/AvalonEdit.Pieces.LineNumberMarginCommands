using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using ICSharpCode.AvalonEdit;
using ICSharpCode.AvalonEdit.Editing;
using ICSharpCode.AvalonEdit.Rendering;
using System.Windows;
using System.Windows.Controls;
using System.Globalization;

namespace AvalonEdit.Pieces
{
    // idea from: http://community.icsharpcode.net/forums/t/11706.aspx
    public class LineNumberMarginWithCommands : LineNumberMargin
    {

        public static void Install( TextEditor _editor)
        {
            var me = new LineNumberMarginWithCommands(_editor);
            
            _editor.ShowLineNumbers = false; // turn off the built in
            _editor.TextArea.LeftMargins.Add(me);
            _editor.TextArea.LeftMargins.Add(DottedLineMargin.Create());
        }

        public LineNumberMarginWithCommands(TextEditor _editor)
        {
            /*TextView textView = new TextView()
            {
                Document = _editor.Document
            };

            this.TextView = textView;*/
        }

        protected override System.Windows.Size MeasureOverride(System.Windows.Size availableSize)
        {
            FormattedText text = new FormattedText(
                new string('9', maxLineNumberLength),
                System.Globalization.CultureInfo.CurrentCulture,
                FlowDirection.LeftToRight,
                typeface,
                emSize,
                (Brush)GetValue(Control.ForegroundProperty)
            );
            return new Size(text.Width, 0);
        }


        protected override void OnRender(DrawingContext drawingContext)
        {
            TextView textView = this.TextView;
            Size renderSize = this.RenderSize;
            if (textView != null && textView.VisualLinesValid)
            {
                var foreground = (Brush)GetValue(Control.ForegroundProperty);
                foreach (VisualLine line in textView.VisualLines)
                {
                    int lineNumber = line.FirstDocumentLine.LineNumber;
                    FormattedText text = new FormattedText(
                        lineNumber.ToString(CultureInfo.CurrentCulture),
                        CultureInfo.CurrentCulture,
                        FlowDirection.LeftToRight,
                        typeface, emSize, foreground
                    );
                    drawingContext.DrawText(text, new Point(renderSize.Width - text.Width,
                                                            line.VisualTop - textView.VerticalOffset));
                }
            }
        }

    }
}
