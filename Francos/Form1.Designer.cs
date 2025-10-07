
namespace Francos
{
    partial class Francos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvPlanilla = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnenfermero = new System.Windows.Forms.Button();
            this.lblenf = new System.Windows.Forms.Label();
            this.txtagregarEnfermero = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanilla)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPlanilla
            // 
            this.dgvPlanilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlanilla.Location = new System.Drawing.Point(31, 29);
            this.dgvPlanilla.Name = "dgvPlanilla";
            this.dgvPlanilla.Size = new System.Drawing.Size(561, 150);
            this.dgvPlanilla.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tabla de francos:";
            // 
            // btnenfermero
            // 
            this.btnenfermero.Location = new System.Drawing.Point(613, 73);
            this.btnenfermero.Name = "btnenfermero";
            this.btnenfermero.Size = new System.Drawing.Size(93, 24);
            this.btnenfermero.TabIndex = 2;
            this.btnenfermero.Text = "Agregar";
            this.btnenfermero.UseVisualStyleBackColor = true;
            this.btnenfermero.Click += new System.EventHandler(this.btnenfermero_Click);
            // 
            // lblenf
            // 
            this.lblenf.AutoSize = true;
            this.lblenf.Location = new System.Drawing.Point(610, 30);
            this.lblenf.Name = "lblenf";
            this.lblenf.Size = new System.Drawing.Size(108, 13);
            this.lblenf.TabIndex = 3;
            this.lblenf.Text = "Agregar enfermero/a:";
            // 
            // txtagregarEnfermero
            // 
            this.txtagregarEnfermero.Location = new System.Drawing.Point(613, 47);
            this.txtagregarEnfermero.Name = "txtagregarEnfermero";
            this.txtagregarEnfermero.Size = new System.Drawing.Size(175, 20);
            this.txtagregarEnfermero.TabIndex = 4;
            // 
            // Francos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtagregarEnfermero);
            this.Controls.Add(this.lblenf);
            this.Controls.Add(this.btnenfermero);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPlanilla);
            this.Name = "Francos";
            this.Text = "Francos";
            this.Load += new System.EventHandler(this.Francos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanilla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPlanilla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnenfermero;
        private System.Windows.Forms.Label lblenf;
        private System.Windows.Forms.TextBox txtagregarEnfermero;
    }
}

