using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MineSweeper_NEA_Project
{
    public partial class Form1 : Form
    {
        int mineCount = 10;
        static int numbersInArrayEasy = 11;
        int[,] array = new int[numbersInArrayEasy, numbersInArrayEasy];       
        private Button btnAdd = new Button();  
        
        const int MAX_COL = 10;
        const int MAX_ROW = 10;
        private const int BOX_SIZE = 40;
        TextBox[,] txtBox;

        int space = 20;

        public Form1()
        {
                       
            InitializeComponent();


            txtBox = new TextBox[MAX_COL, MAX_ROW];

            for (int col = 0; col < MAX_COL; col++)
            {
                for (int row = 0; row < MAX_ROW; row++)
                {

                    txtBox[col, row] = new TextBox();
                    //makes sure that the user can't type inside of the text boxes.
                    txtBox[col, row].ReadOnly = true;
                    txtBox[col, row].Name = col + ":" + row;
                    txtBox[col, row].Text = col + ":" + row;
                    txtBox[col, row].AutoSize = false;
                    txtBox[col, row].Width = BOX_SIZE;
                    txtBox[col, row].Height = BOX_SIZE;
                    txtBox[col, row].Click += new EventHandler(TxtBoxClick);
                }

            }

            int y = 5;
            for (int col = 0; col < MAX_COL; col++)
            {
                int x = 10;
                for (int row = 0; row < MAX_ROW; row++)
                {
                    txtBox[col, row].Visible = true;
                    txtBox[col, row].Location = new Point(x, y);
                    this.Controls.Add(txtBox[col, row]);
                    x += 50;
                }
                y += 50;
            }
            while ()
            {

            }

        }
        void TxtBoxClick(object sender, EventArgs e)
        {
            TextBox currentBox = (sender) as TextBox;
            if (currentBox != null)
            {
                if (!(currentBox.BackColor == Color.Red) && !(currentBox.BackColor == Color.Green) && !(currentBox.BackColor == Color.Orange))
                {
                    currentBox.BackColor = Color.Red;
                }
                else if (currentBox.BackColor == Color.Red)
                {
                    currentBox.BackColor = Color.Orange;
                }
                else if (currentBox.BackColor == Color.Orange)
                {
                    currentBox.BackColor = Color.Green;
                }
                else if (currentBox.BackColor == Color.Green)
                {
                    currentBox.BackColor = Color.Red;
                }
                else MessageBox.Show(Convert.ToString(currentBox.BackColor));

            }
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
            //Design of the program

            //Setting up the Form
            
           // this.Controls.Add(btnAdd);
           // this.Controls.Add(txtBox);
            
           // this.Controls.Add(chkBox);
           

        }
    }
}
    

