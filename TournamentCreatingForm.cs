using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace EPRT_C_sharp
{
    public partial class TournamentCreatingForm : Form
    {
        public TournamentCreatingForm()
        {
            InitializeComponent();
        }

        public TournamentCreatingForm(StartForm f)
        {
            InitializeComponent();
            f.BackColor = Color.Coral;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            memberTableAdapter.Fill(ePRTDataSet.Member);
        }

        

        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        { 
            
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
          
        }



        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
                if (!listBox1.Items.Contains(dataGridView1.CurrentCell.Value))
                    listBox1.Items.Add(dataGridView1.CurrentCell.Value);
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            int i = ((DataGridView)sender).CurrentRow.Index;    
            memberTableAdapter.DeleteString(((DataGridView)sender).)
        }

    }

}
