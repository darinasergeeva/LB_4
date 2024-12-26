using LB4_AnimeTitlesApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB4_AnimeTitlesApp
{
    public partial class FormTypes : Form
    {
        private AnimeTitlesContext db;
        public FormTypes()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.db = new AnimeTitlesContext();
            this.db.AnimeTypes.Load();
            this.dataGridViewTypes.DataSource = this.db.AnimeTypes.Local.OrderBy(o=>o.AnimeOfType).ToList();
            
            //сокрытие некоторых столбцов
            dataGridViewTypes.Columns["Id"].Visible = false;
            dataGridViewTypes.Columns["AnimeTitles"].Visible = false;

            //изменение названий заголовка столбцов
            dataGridViewTypes.Columns["AnimeOftype"].HeaderText="Тип";
        }

        private void FormTypes_Load(object sender, EventArgs e)
        {

        }
    }
}
