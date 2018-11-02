using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PhotoManager
{
    public static class Utils
    {

        public static void ShowInfoBox(string text, string title = "Information")
        {
            MessageBox.Show(text, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static DialogResult ShowQuestionBox(string text, string title = "Question")
        {
            return MessageBox.Show(text, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
    }
}
