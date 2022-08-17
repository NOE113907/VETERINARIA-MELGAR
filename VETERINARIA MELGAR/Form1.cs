using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VETERINARIA_MELGAR
{
    public partial class VeterinariaMelgar : Form
    {   
        private ConexionDatos acceso;
   
        public VeterinariaMelgar()
        {
            InitializeComponent();
            acceso = new ConexionDatos();
        }
       
    
        private void grbdueño_Load(object sender, EventArgs e)
        {
            //cargarCombo();
            cargarComboSP();
            cbotipo.SelectedIndex = -1;
            cargarLista();
            limpiarCampos(false);
        }
        public void limpiarCampos(bool x)
        {
            grcliente.Enabled = x;
            grbmascota.Enabled = x;
            btnnuevo.Enabled = !x;
            txtimporte.Enabled = x;
            lstAtención.Enabled = x;
            dtpfecha.Value = DateTime.Now;
        }

        /* Cargar combo como lo aprendi en PROGRAMACION I
        private void cargarCombo()
        {
            string query = "select* from tipo_mascotas";
            DataTable table=acceso.EjecutarQuery (query);
            cbotipo.DataSource = table;
            cbotipo.DisplayMember = "descripcion_tipo";
            cbotipo.ValueMember = "id_tipo";
        }
        */
        private void cargarComboSP() 
        {
            DataTable table = acceso.EjecutarQuery("declare @codTip int, " +
                "@nomtipo varchar execute SP_SELECT_TIPO @codTip output, @nomtipo output");
            cbotipo.DataSource = table;
            cbotipo.DisplayMember = "descripcion_tipo";
            cbotipo.ValueMember = "id_tipo";
            cbotipo.DropDownStyle = ComboBoxStyle.DropDownList; 

        }
        private void cargarLista()
        {
            string query = "select * from atencion";
            DataTable table= acceso.EjecutarQuery(query);
            lstAtención.Items.Clear();

            foreach (DataRow fila in table.Rows)
            {
                Atencion a= new Atencion();
                a.Fecha = Convert.ToDateTime(fila["fecha"].ToString());
                a.Descripcion = (fila["descripcion"].ToString());
                lstAtención.Items.Add(a);
            }
        }
        private void btnnuevo_Click(object sender, EventArgs e)
        {
            limpiarCampos(true);
            txtnombre.Focus();
        }
        public bool Validar()
        {
            bool validado =true;
            if (txtnombre.Text == "") { validado = false; }
            if (txtcodigo.Text == "") { validado = false; }
            if (txtnommascota.Text==""){ validado = false; }
            if(rdbfemenino.Checked || rdbmasc.Checked) { validado = false; }  
            if(rdbdias.Checked || rdbdias.Checked) { validado = false; }
            return validado;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void lblcodigo_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void grbmascota_Enter(object sender, EventArgs e)
        {

        }

        private void btngrabar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                Atencion oAtencion =new Atencion();
                oAtencion.Fecha = dtpfecha.Value;
                oAtencion.Descripcion = txtatencion.Text;




            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
