using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerComplainMS
{
    public partial class CustomerComplainForm : Form
    {
        public CustomerComplainForm()
        {
            serialNo = 0;
            InitializeComponent();
        }

        private Complain complainObject;
        private Queue<Complain> complainQueue = new Queue<Complain>();
        private int serialNo = 0;
        
        
        private void enqueueButton_Click(object sender, EventArgs e)
        {
            string name = enqueueNameTextBox.Text;
            string complain = enqueueComplainTextBox.Text;
            serialNo++;// = complainQueue.Count;

            complainObject = new Complain(serialNo , name , complain);
            complainQueue.Enqueue(complainObject);


            //adding item to listView


            ListViewItem listViewItem1 = new ListViewItem(new string[]
            {
                complainObject.GetSerialNo().ToString(),
                complainObject.GetName(),
                complainObject.GetComplain()
            });
            
            waitingQueueListView.Items.AddRange(new ListViewItem[]{listViewItem1});


            //enabling button
            dequeueButton.Enabled = true;
            //show name's serial no
            MessageBox.Show(complainObject.GetName()+"'s serial number is : "+complainObject.GetSerialNo());
        
            //make textbox empty
            enqueueNameTextBox.Text = "";
            enqueueComplainTextBox.Text = "";

            //make name textbox on focus
            enqueueNameTextBox.Focus();
            
        }

       
        private void Form1_Load(object sender, EventArgs e)
        {
            dequeueButton.Enabled = false;
            enqueueNameTextBox.Focus();
        }

        private void dequeueButton_Click(object sender, EventArgs e)
        {

            //focus name textbox
            enqueueNameTextBox.Focus();



            //check if the queue is empty
            if (complainQueue.Count == 0)
            {
                dequeueButton.Enabled = false;
                MessageBox.Show("No item found ");
                return;
            }
            {

                Complain com
                    = complainQueue.Dequeue();



                dequeueSerialNoTextBox.Text = com.GetSerialNo().ToString();
                  
                dequeueComplainTextBox.Text = com.GetComplain();
                dequeueNameTextBox.Text = com.GetName();


                int indexOfRemove = waitingQueueListView.Items.IndexOfKey(
                   com.GetSerialNo().ToString()
                    );

                //MessageBox.Show(indexOfRemove.ToString());
                
            
                waitingQueueListView.Items.RemoveAt(0);

            }


            
        }
    }
}
