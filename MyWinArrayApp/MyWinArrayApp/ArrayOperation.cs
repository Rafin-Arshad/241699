using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWinArrayApp
{
    public partial class ArrayOperation : Form
    {
        public ArrayOperation()
        {
            InitializeComponent();
            const int size = 10;
            int []number=new int [size];
            number[0] = 9;
            number[5] = 10;
            number[8] = 15;
            string message = "";
            for(int index=0;index<size;index++)
       
            {
                if(number[index]!=0)
                {
                    message = message + "Value at the index :" + index + " is= " + number[index]+"\n";
                }
                
            }
            showRichTextBox.Text = message;

        }
    }
}
