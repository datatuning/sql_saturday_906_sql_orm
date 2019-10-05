using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLSAT906_Demo01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //SELECT Id, Nome WHERE Nome = 
            using (var context = new AppDBContext())
            {
                string nome = "Marcel";
                var cli = context.Clientes
                            .Where(c => c.Nome.StartsWith(nome))
                            .Select(c => new { c.Id, c.Nome, c.CpfCnpj })
                            .ToList();
            }
        }
    }
}
