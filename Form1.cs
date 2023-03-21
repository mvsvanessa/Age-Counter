using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaiorIDade
{
    public partial class Form1 : Form
    {
        int maiorIdade = 0;  // Variável global
        int pos = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("Deseja Realmente Sair", "SAIR",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question); 
            if (dl == DialogResult.Yes)
            {
                this.Close();
            }
            
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            txtIdade.ReadOnly = false;
            btnNext.Enabled = true;
            btnIniciar.Enabled = false;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(txtIdade.Text) > maiorIdade)
                {
                    maiorIdade = int.Parse(txtIdade.Text);
                }
                pos++;
                txtIdade.Clear();
                //txtIdade.Focus();
               
                if (pos <= 5)
                {
                    label1.Text = "Insira a Idade " + pos +":";
                }
               else
                {
                    txtIdade.ReadOnly = true;
                    btnNext.Enabled = false;
                    btnIniciar.Enabled = true;
                    label1.Text = "Insira a Idade";
                    MessageBox.Show("A Maior Idade é: " + maiorIdade, "MAIOR IDADE",
                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                    
                
                                 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Insira sua Idade na caixa", "ERRO",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtIdade.Clear();
               // txtIdade.Focus();
            }
            finally
            {
                txtIdade.Focus();
            }
        }
    }
}
