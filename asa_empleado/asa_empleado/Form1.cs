using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;

namespace asa_empleado
{
    public partial class asa : Form
    {
        //conexiondb con = new conexiondb();
        public asa()
        {
            InitializeComponent();
            //Estas lineas eliminan los parpadeos del formulario o controles en la interfaz grafica (Pero no en un 100%)
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;
        }
        conexiondb con = new conexiondb();
        string id;
        //METODO PARA REDIMENCIONAR/CAMBIAR TAMAÑO A FORMULARIO  TIEMPO DE EJECUCION ----------------------------------------------------------
        private int tolerance = 15;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        //----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));
            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);
            region.Exclude(sizeGripRectangle);
            this.panel1.Region = region;
            this.Invalidate();
        }
        //----------------COLOR Y GRIP DE RECTANGULO INFERIOR
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(55, 61, 69));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);
            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }
        private void btnMenu_Click(object sender, EventArgs e)
        {
            //-------CON EFECTO SLIDING
            if (panel3.Width == 230)
            {
                this.tmContraerMenu.Start();
            }
            else if (panel3.Width == 55)
            {
                this.tmExpandirMenu.Start();
            }
        }
        private void tmExpandirMenu_Tick(object sender, EventArgs e)
        {
            if (panel3.Width >= 230)
                this.tmExpandirMenu.Stop();
            else
                panel3.Width = panel3.Width + 5;

        }
        private void tmContraerMenu_Tick(object sender, EventArgs e)
        {
            if (panel3.Width <= 55)
                this.tmContraerMenu.Stop();
            else
                panel3.Width = panel3.Width - 5;
        }
        private void BUSCAR_Click(object sender, EventArgs e)
        {
           
        }

        private void BAJAS_Click(object sender, EventArgs e)
        {
            
            string bajas;


            bajas = "delete from asa.personal where idP = '"+ id.ToString() +"';";
            con.eliminar(bajas);

        }

        private void ALTAS_Click(object sender, EventArgs e)
        {
            EMPLEADOS emp = new EMPLEADOS();
            emp.Show();
        }

        private void MODIFICAR_Click(object sender, EventArgs e)
        {

        }

        private void asa_Load(object sender, EventArgs e)
        {
            string consulta = "select idP ,foto,tia,puesto,nombre, apellido,  sexo from personal;";
            EMPLEADOS.DataSource = con.Llenargrid(consulta);
             
        }

        private void EMPLEADOS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = EMPLEADOS.CurrentCell.Value.ToString();
        }

        private void ALTAS_Click_1(object sender, EventArgs e)
        {

        }

        private void BUSCAR_Click_1(object sender, EventArgs e)
        {

        }

        private void ASISTENCIA_Click(object sender, EventArgs e)
        {

        }

        private void EMPLEADOS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LAST_NAME_TextChanged(object sender, EventArgs e)
        {

        }

        private void TIA_TextChanged(object sender, EventArgs e)
        {

        }

        private void NAME_TextChanged(object sender, EventArgs e)
        {

        }

        private void BAJAS_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void MODIFICAR_Click_1(object sender, EventArgs e)
        {

        }

        private void EMPLEADOS_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
