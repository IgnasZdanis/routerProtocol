using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainForm
{
    public partial class Form1 : Form
    {
        List<Router> routers = new List<Router>();
        public Form1()
        {
            InitializeComponent();
        }

        private void addNodeButton_Click(object sender, EventArgs e)
        {
            Router newRouter = new Router();
            routers.Add(newRouter);
            List<int> routerNumbers = new List<int>();
            List<int> firstRouterNumbers = new List<int>();
            List<int> secondRouterNumbers = new List<int>();
            foreach (Router router in routers)
            {
                routerNumbers.Add(router.number);
                firstRouterNumbers.Add(router.number);
                secondRouterNumbers.Add(router.number);
            }
            currentRouters.DataSource = routerNumbers;
            firstNodeBox.DataSource = firstRouterNumbers;
            secondNodeBox.DataSource = secondRouterNumbers;
        }

        private void addPathButton_Click(object sender, EventArgs e)
        {
            Router first = routers[firstNodeBox.SelectedIndex];
            Router second = routers[secondNodeBox.SelectedIndex];
            int weight = int.Parse(weightBox.Text);
            AddNeighbour(first, second, weight);
        }

        private void AddNeighbour(Router first, Router second, int weight)
        {
            Neighbour newNeighbour = new Neighbour
            {
                number = second.number,
                weight = weight
            };
            first.neighbours.Add(newNeighbour);

            newNeighbour = new Neighbour
            {
                number = first.number,
                weight = weight
            };
            second.neighbours.Add(newNeighbour);
        }

        private void currentRouters_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row.
            dataGridView1.Rows.Add()
            foreach(var row in dataGridView1.Rows)
            {
                row.Router = 1;
            }
        }

        private void routerTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
