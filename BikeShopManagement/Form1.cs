﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BikeShopManagement
{
    public partial class Form1 : Form
    {
        private SalesReport salesReport;
        private dashboard dashboardControl;
        public Point mouseLocation;
        public bool mouseDown;


        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        public Form1()
        {
            InitializeComponent();
            ShowDashboard();
            this.Size = new Size(800, 450);
            btnExit.BringToFront();
        }

        private void dashboardMenuItem_Click(object sender, EventArgs e)
        {
            ShowDashboard();
            btnExit.BringToFront();
        }

        private void inventoryMenuItem_Click(object sender, EventArgs e)
        {
            LoadInventoryManagement();
            btnExit.BringToFront();
        }

        private void salesMenuItem_Click(object sender, EventArgs e)
        {
            LoadSalesReport();
            btnExit.BringToFront();
        }

        private void reportsMenuItem_Click(object sender, EventArgs e)
        {
            ShowReports();
            btnExit.BringToFront();
        }
        private void ShowDashboard()
        {
            if (dashboardControl == null)
            {
                dashboardControl = new dashboard();  
                dashboardControl.Dock = DockStyle.Fill;
            }

            mainPanel.Controls.Clear(); 
            mainPanel.Controls.Add(dashboardControl);
            menuStrip1.BringToFront(); 
        }
        private void LoadInventoryManagement()
        {
            salesReport = new SalesReport();
            InventoryManagement inventoryControl = new InventoryManagement(salesReport);
            inventoryControl.Dock = DockStyle.Fill;
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(inventoryControl);
            menuStrip1.BringToFront();
        }
        private void LoadSalesReport()
        {
            salesReport = new SalesReport(); 
            salesReport.Dock = DockStyle.Fill; 
            mainPanel.Controls.Clear(); 
            mainPanel.Controls.Add(salesReport); 
            menuStrip1.BringToFront(); 
        }
        private void ShowSalesTracking()
        {
            mainPanel.Controls.Clear();
            Label salesLabel = new Label
            {
                Text = "Sales Tracking: Products Sold, Dates, Items, Amount, Quantity",
                Dock = DockStyle.Fill,
                TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            };
            mainPanel.Controls.Add(salesLabel);
        }

        private void ShowReports()
        {
            Reports reportsControl = new Reports();
            reportsControl.Dock = DockStyle.Fill;
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(reportsControl);
            menuStrip1.BringToFront();
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

    }
}