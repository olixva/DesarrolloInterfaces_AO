using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploDisenador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void animalBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.animalBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.zooBDDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'zooBDDataSet.Zoo' Puede moverla o quitarla según sea necesario.
            this.zooTableAdapter.Fill(this.zooBDDataSet.Zoo);
            // TODO: esta línea de código carga datos en la tabla 'zooBDDataSet.Animal' Puede moverla o quitarla según sea necesario.
            this.animalTableAdapter.Fill(this.zooBDDataSet.Animal);
            
        }

        private void animalBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.animalBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.zooBDDataSet);

        }
        
    }
}
