using SuperSimpleTcp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCPServer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SimpleTcpServer server;
        private void btnStarta_Click(object sender, EventArgs e)
        {
            server.Start();
            txtInfo.Text += $"Starting...{Environment.NewLine}";            
            btnStarta.Enabled = false;
            btnSkicka.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnSkicka.Enabled = false;
            server = new SimpleTcpServer(txtIP.Text);
            server.Events.ClientConnected += Events_ClientConnected;
            server.Events.ClientDisconnected += Events_ClientDisconnected;
            server.Events.DataReceived += Events_DataReceived;
        }

        private void Events_DataReceived(object sender, DataReceivedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                txtInfo.Text += $"{ e.IpPort}:{ Encoding.UTF8.GetString(e.Data)}{ Environment.NewLine}";
            });
        }

        private void Events_ClientDisconnected(object sender, ConnectionEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                txtInfo.Text += $"{e.IpPort} disconnected.{Environment.NewLine}";
                lbxKlientIP.Items.Remove(e.IpPort);
            });
        }

        private void Events_ClientConnected(object sender, ConnectionEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                txtInfo.Text += $"{e.IpPort} connected.{Environment.NewLine}";
                lbxKlientIP.Items.Add(e.IpPort);
            });
        }

        private void btnSkicka_Click(object sender, EventArgs e)
        {
            if(server.IsListening)
            {
                if(!string.IsNullOrEmpty(txtMeddelande.Text)&& lbxKlientIP.SelectedItem != null)
                {
                    server.Send(lbxKlientIP.SelectedItem.ToString(), txtMeddelande.Text);
                    txtInfo.Text += $"Server: {txtMeddelande.Text}{Environment.NewLine}";
                    txtMeddelande.Text = string.Empty;

                }
            }
        }
    }
}
