using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XanderUI;

namespace Task._Manangement
{
    public partial class Task : Form
    {
        public Task()
        {
            InitializeComponent();
            xuiGradientPanel1.Visible= check;
            Control();
           
            
            
        }
        List<Card> cards = new List<Card>();
      
        bool check = false;
       
        XUICard xUICard=null;

      

        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (richTextBox1.Text!="") { 
                    Card card=new Card();
                    card.Text = null;
                    card.Text1 = null;

                    if (chcbxStar.Checked)
                    {
                        card.starred = true;
                    }

                    card.Text2 = richTextBox1.Text;
                    card.Text3 = DateTime.Now.ToString();
                    cards.Add(card);
                    card.Click += Card_Click;
                    check= true;
                    xuiGradientPanel1.Visible = check;
                    
                    foreach (var item in cards)
                    {
                        Dock = DockStyle.Left;
                        AutoSize = true;
                        xuiGradientPanel1.Controls.Add(card);
                    }
                   
                   
                    richTextBox1.Text = "";
                   
                }
                else { 
                    
                    MessageBox.Show("Text Cannot be null"); 
                }

                   
                
                
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                Control();
            }
            
        }

        private void Task_Load(object sender, EventArgs e)
        {
            
        }

        private void Card_Click(object sender, EventArgs e)
        {
            xUICard = (XUICard)sender;
            btn_Add.Visible = false;
            btnUpdate.Visible = true;
            btn_Back.Visible = true;
            btn_Delete.Visible = true;
            
            richTextBox1.Text =xUICard.Text2 ;
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            xUICard.Text2 = richTextBox1.Text;
          
            
           



        }

       

        public void Control()
        {
            if (cards != null)
            {
                foreach (var item in cards)
                {
                    if (item.Text3 == DateTime.Now.ToString())
                    {

                        Card card = new Card();
                        card.Color1 = Color.Fuchsia;
                        card.Color2 = Color.Navy;
                        card.Text = null;
                        card.Text1 = null;

                        card.Text2 = item.Text2;
                        card.Text3 = item.Text3;

                        card.Click += Card_Click;

                        pnlToday.Controls.Add(card);
                    }
                    if (item.starred == true)
                    {
                        starredPage.Controls.Add(item);
                    }
                }

            }

        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            btn_Add.Visible = true;
            btnUpdate.Visible = false;
            btn_Back.Visible = false;
            btn_Delete.Visible = false;
            richTextBox1.Text = "";
        }

        private void btn_Delete_Click_1(object sender, EventArgs e)
        {
            xuiGradientPanel1.Controls.Remove(xUICard);
        }
    }
}
