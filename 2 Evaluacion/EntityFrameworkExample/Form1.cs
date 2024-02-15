using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace EntityFrameworkExample
{
    public partial class FormProductos : Form
    {
        private ProductsContext dbContext;
        public FormProductos()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.dbContext = new ProductsContext();
            // Uncomment the line below to start fresh with a new database.
            // this.dbContext.Database.EnsureDeleted();
            this.dbContext.Database.EnsureCreated();
            this.dbContext.Categories.Load();
            this.categoryBindingSource.DataSource =
            dbContext.Categories.Local.ToBindingList();
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            this.dbContext?.Dispose();
            this.dbContext = null;
        }

        private void dataGridViewCategoria_SelectionChanged(object sender, EventArgs e)
        {
            if (this.dbContext != null)
            {
                var category = (Category)this.dataGridViewCategoria.CurrentRow.DataBoundItem;
                if (category != null)
                {
                    this.dbContext.Entry(category).Collection(e => e.Products).Load();
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.dbContext!.SaveChanges();
            this.dataGridViewCategoria.Refresh();
            this.dataGridViewProductos.Refresh();
        }
    }
}