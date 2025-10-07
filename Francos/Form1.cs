using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace Francos
{
    public partial class Francos : Form
    {
        public Francos()
        {
            InitializeComponent();
        }

        private void Francos_Load(object sender, EventArgs e)
        {
            cargar();
        }
        public void cargar()
        {
            conexionRegistroMensual conexion = new conexionRegistroMensual();
            List<RegistroMensual> registros = conexion.ListarRegistroOctubre();

            CrearGrillaDesdeRegistros(dgvPlanilla, registros, 10, 2025);
        }

        private void CrearGrillaDesdeRegistros(DataGridView dgv, List<RegistroMensual> registros, int mes, int año)
        {
            dgv.Columns.Clear();
            dgv.Rows.Clear();
            dgv.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;

            // Columna fija para nombre del empleado
            dgv.Columns.Add("IdEmpleado", "Empleado");

            int diasMes = DateTime.DaysInMonth(año, mes);
            for (int d = 1; d <= diasMes; d++)
            {
                DataGridViewColumn col = new DataGridViewColumn(new DataGridViewComboBoxCell());
                col.Name = $"D{d}";
                col.HeaderText = $"{d}/{mes}";
                col.Width = 80;
                dgv.Columns.Add(col);
            }

            foreach (var reg in registros)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgv);
                row.Cells[0].Value = reg.NombreCompleto;

                for (int d = 1; d <= diasMes; d++)
                {
                    string prop = $"Dia_{d:D2}";
                    var valor = typeof(RegistroMensual).GetProperty(prop).GetValue(reg);
                    DataGridViewComboBoxCell comboCell = new DataGridViewComboBoxCell();
                    comboCell.Items.AddRange(Enum.GetNames(typeof(TipoFranco)));
                    comboCell.Value = valor.ToString();
                    row.Cells[d] = comboCell;
                }

                dgv.Rows.Add(row);
            }
        }

        private void btnenfermero_Click(object sender, EventArgs e)
        {
            conexionRegistroMensual conexion = new conexionRegistroMensual();
            conexion.insertarEnfermero(txtagregarEnfermero.Text);
            cargar();
        }
    }


    
      
    
}
