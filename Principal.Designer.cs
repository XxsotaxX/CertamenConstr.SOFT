﻿namespace WinFormsApp1
{
    partial class Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            menuStrip1 = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            acercaDeToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            salirToolStripMenuItem = new ToolStripMenuItem();
            mantenedoresToolStripMenuItem = new ToolStripMenuItem();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            concesionariosToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            inventarioToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripSeparator();
            vehiculosToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripSeparator();
            ventasToolStripMenuItem = new ToolStripMenuItem();
            crearVentaToolStripMenuItem = new ToolStripMenuItem();
            listarVentaToolStripMenuItem = new ToolStripMenuItem();
            notifyIcon1 = new NotifyIcon(components);
            iconoMenu = new ContextMenuStrip(components);
            maximizarToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem5 = new ToolStripSeparator();
            salirToolStripMenuItem1 = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            iconoMenu.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, mantenedoresToolStripMenuItem, ventasToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(6, 3, 0, 3);
            menuStrip1.Size = new Size(800, 30);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { acercaDeToolStripMenuItem, toolStripMenuItem1, salirToolStripMenuItem });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(73, 24);
            archivoToolStripMenuItem.Text = "&Archivo";
            // 
            // acercaDeToolStripMenuItem
            // 
            acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            acercaDeToolStripMenuItem.Size = new Size(224, 26);
            acercaDeToolStripMenuItem.Text = "&Acerca de...";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(221, 6);
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(224, 26);
            salirToolStripMenuItem.Text = "&Salir";
            // 
            // mantenedoresToolStripMenuItem
            // 
            mantenedoresToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { clientesToolStripMenuItem, concesionariosToolStripMenuItem, toolStripMenuItem2, inventarioToolStripMenuItem, toolStripMenuItem3, vehiculosToolStripMenuItem, toolStripMenuItem4 });
            mantenedoresToolStripMenuItem.Name = "mantenedoresToolStripMenuItem";
            mantenedoresToolStripMenuItem.Size = new Size(118, 24);
            mantenedoresToolStripMenuItem.Text = "&Mantenedores";
            mantenedoresToolStripMenuItem.Click += mantenedoresToolStripMenuItem_Click;
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(224, 26);
            clientesToolStripMenuItem.Text = "&Clientes";
            clientesToolStripMenuItem.Click += clientesToolStripMenuItem_Click;
            // 
            // concesionariosToolStripMenuItem
            // 
            concesionariosToolStripMenuItem.Name = "concesionariosToolStripMenuItem";
            concesionariosToolStripMenuItem.Size = new Size(224, 26);
            concesionariosToolStripMenuItem.Text = "C&oncesionarios";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(221, 6);
            // 
            // inventarioToolStripMenuItem
            // 
            inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            inventarioToolStripMenuItem.Size = new Size(224, 26);
            inventarioToolStripMenuItem.Text = "Inventario";
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(221, 6);
            // 
            // vehiculosToolStripMenuItem
            // 
            vehiculosToolStripMenuItem.Name = "vehiculosToolStripMenuItem";
            vehiculosToolStripMenuItem.Size = new Size(224, 26);
            vehiculosToolStripMenuItem.Text = "Ve&hiculos";
            vehiculosToolStripMenuItem.Click += vehiculosToolStripMenuItem_Click;
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(221, 6);
            // 
            // ventasToolStripMenuItem
            // 
            ventasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { crearVentaToolStripMenuItem, listarVentaToolStripMenuItem });
            ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            ventasToolStripMenuItem.Size = new Size(66, 24);
            ventasToolStripMenuItem.Text = "&Ventas";
            // 
            // crearVentaToolStripMenuItem
            // 
            crearVentaToolStripMenuItem.Name = "crearVentaToolStripMenuItem";
            crearVentaToolStripMenuItem.Size = new Size(168, 26);
            crearVentaToolStripMenuItem.Text = "&Crear Venta";
            crearVentaToolStripMenuItem.Click += crearVentaToolStripMenuItem_Click;
            // 
            // listarVentaToolStripMenuItem
            // 
            listarVentaToolStripMenuItem.Name = "listarVentaToolStripMenuItem";
            listarVentaToolStripMenuItem.Size = new Size(168, 26);
            listarVentaToolStripMenuItem.Text = "&Listar Venta";
            // 
            // notifyIcon1
            // 
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.BalloonTipText = "Prueba prueba";
            notifyIcon1.BalloonTipTitle = "Mi Programa";
            notifyIcon1.ContextMenuStrip = iconoMenu;
            notifyIcon1.Icon = (Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // iconoMenu
            // 
            iconoMenu.ImageScalingSize = new Size(20, 20);
            iconoMenu.Items.AddRange(new ToolStripItem[] { maximizarToolStripMenuItem, toolStripMenuItem5, salirToolStripMenuItem1 });
            iconoMenu.Name = "iconoMenu";
            iconoMenu.Size = new Size(148, 58);
            // 
            // maximizarToolStripMenuItem
            // 
            maximizarToolStripMenuItem.Name = "maximizarToolStripMenuItem";
            maximizarToolStripMenuItem.Size = new Size(147, 24);
            maximizarToolStripMenuItem.Text = "Maximizar";
            // 
            // toolStripMenuItem5
            // 
            toolStripMenuItem5.Name = "toolStripMenuItem5";
            toolStripMenuItem5.Size = new Size(144, 6);
            // 
            // salirToolStripMenuItem1
            // 
            salirToolStripMenuItem1.Name = "salirToolStripMenuItem1";
            salirToolStripMenuItem1.Size = new Size(147, 24);
            salirToolStripMenuItem1.Text = "Salir";
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 394);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Principal";
            Text = "Principal";
            Load += Principal_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            iconoMenu.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem acercaDeToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem mantenedoresToolStripMenuItem;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem concesionariosToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem inventarioToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem3;
        private ToolStripMenuItem vehiculosToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem4;
        private ToolStripMenuItem ventasToolStripMenuItem;
        private ToolStripMenuItem crearVentaToolStripMenuItem;
        private ToolStripMenuItem listarVentaToolStripMenuItem;
        private NotifyIcon notifyIcon1;
        private ContextMenuStrip iconoMenu;
        private ToolStripMenuItem maximizarToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem5;
        private ToolStripMenuItem salirToolStripMenuItem1;
    }
}