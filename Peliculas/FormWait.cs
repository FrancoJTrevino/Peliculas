using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Peliculas
{
    public partial class FormWait : Form
    {
        Rectangle BoundRect;
        Rectangle OldRect = Rectangle.Empty;
        public FormWait()
        {
            InitializeComponent();
        }

        private void FormWait_Load(object sender, EventArgs e)
        {
            OldRect = Cursor.Clip;
            BoundRect = new Rectangle(this.Location.X + 100, this.Location.Y + 25, 1, 1);
            Cursor.Clip = BoundRect;
            Cursor.Current = Cursors.WaitCursor;
        }
    }
}
