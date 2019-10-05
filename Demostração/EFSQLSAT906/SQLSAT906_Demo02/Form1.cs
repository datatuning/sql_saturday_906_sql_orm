using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLSAT906_Demo02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //SELECT TOP 1
            var q = new AppDBContext();
            _ = q.Clientes.Find(1);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //SELECT * WHERE Nome LIKE 'NOME%'
            string nome = "Marcel";
            using (var db = new AppDBContext())
            {
                var cli = db.Clientes
                            .Where(c => c.Nome.StartsWith(nome))
                            .ToList();
            }
        }

        private void Button3_Click(object sender, EventArgs e)
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
