using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Курсовая_работа_Кривая_дракона_
{
    public partial class Inform : Form
    {
        public Inform()
        {
            InitializeComponent();
           // richTextBox1.LoadFile(@"C:\Users\User\Documents\Тест.docx", RichTextBoxStreamType.PlainText);
        }

        private void Inform_Load(object sender, EventArgs e)
        {
            rchTxtBox1.LoadFile(@"C:\Users\User\Documents\Visual Studio 2010\Projects\Курсовая работа(Кривая дракона)\Курсовая работа(Кривая дракона)\obj\Dragon.rtf", RichTextBoxStreamType.RichText);
            rchTxtBox2.LoadFile(@"C:\Users\User\Documents\Visual Studio 2010\Projects\Курсовая работа(Кривая дракона)\Курсовая работа(Кривая дракона)\obj\DragonManual.rtf", RichTextBoxStreamType.RichText);

        }

       
        

         
    }
}
