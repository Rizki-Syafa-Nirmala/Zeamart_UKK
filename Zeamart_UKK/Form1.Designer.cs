
namespace Zeamart_UKK
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtkode = new System.Windows.Forms.TextBox();
            this.txtnama = new System.Windows.Forms.TextBox();
            this.txtharga = new System.Windows.Forms.TextBox();
            this.txtstok = new System.Windows.Forms.TextBox();
            this.btnAdd = new Guna.UI.WinForms.GunaGradientButton();
            this.btnUpdate = new Guna.UI.WinForms.GunaGradientButton();
            this.btnDelete = new Guna.UI.WinForms.GunaGradientButton();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btnLoadData = new Guna.UI.WinForms.GunaGradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Swis721 Hv BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(286, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data Barang Zeamart";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(88, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama Barang";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(88, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Harga Barang";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(88, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Stok Barang";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(88, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Kode Barang";
            // 
            // txtkode
            // 
            this.txtkode.Location = new System.Drawing.Point(190, 73);
            this.txtkode.Name = "txtkode";
            this.txtkode.Size = new System.Drawing.Size(220, 20);
            this.txtkode.TabIndex = 5;
            // 
            // txtnama
            // 
            this.txtnama.Location = new System.Drawing.Point(190, 102);
            this.txtnama.Name = "txtnama";
            this.txtnama.Size = new System.Drawing.Size(220, 20);
            this.txtnama.TabIndex = 6;
            // 
            // txtharga
            // 
            this.txtharga.Location = new System.Drawing.Point(190, 133);
            this.txtharga.Name = "txtharga";
            this.txtharga.Size = new System.Drawing.Size(220, 20);
            this.txtharga.TabIndex = 7;
            // 
            // txtstok
            // 
            this.txtstok.Location = new System.Drawing.Point(190, 161);
            this.txtstok.Name = "txtstok";
            this.txtstok.Size = new System.Drawing.Size(220, 20);
            this.txtstok.TabIndex = 8;
            // 
            // btnAdd
            // 
            this.btnAdd.AnimationHoverSpeed = 0.07F;
            this.btnAdd.AnimationSpeed = 0.03F;
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BaseColor1 = System.Drawing.Color.SlateBlue;
            this.btnAdd.BaseColor2 = System.Drawing.Color.Fuchsia;
            this.btnAdd.BorderColor = System.Drawing.Color.Black;
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAdd.FocusedColor = System.Drawing.Color.Empty;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Image = null;
            this.btnAdd.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAdd.Location = new System.Drawing.Point(456, 88);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnAdd.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnAdd.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAdd.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAdd.OnHoverImage = null;
            this.btnAdd.OnPressedColor = System.Drawing.Color.Black;
            this.btnAdd.Radius = 10;
            this.btnAdd.Size = new System.Drawing.Size(98, 29);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.AnimationHoverSpeed = 0.07F;
            this.btnUpdate.AnimationSpeed = 0.03F;
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.BaseColor1 = System.Drawing.Color.SlateBlue;
            this.btnUpdate.BaseColor2 = System.Drawing.Color.Fuchsia;
            this.btnUpdate.BorderColor = System.Drawing.Color.Black;
            this.btnUpdate.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnUpdate.FocusedColor = System.Drawing.Color.Empty;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Image = null;
            this.btnUpdate.ImageSize = new System.Drawing.Size(20, 20);
            this.btnUpdate.Location = new System.Drawing.Point(559, 88);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnUpdate.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnUpdate.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnUpdate.OnHoverForeColor = System.Drawing.Color.White;
            this.btnUpdate.OnHoverImage = null;
            this.btnUpdate.OnPressedColor = System.Drawing.Color.Black;
            this.btnUpdate.Radius = 10;
            this.btnUpdate.Size = new System.Drawing.Size(98, 29);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.AnimationHoverSpeed = 0.07F;
            this.btnDelete.AnimationSpeed = 0.03F;
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BaseColor1 = System.Drawing.Color.SlateBlue;
            this.btnDelete.BaseColor2 = System.Drawing.Color.Fuchsia;
            this.btnDelete.BorderColor = System.Drawing.Color.Black;
            this.btnDelete.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDelete.FocusedColor = System.Drawing.Color.Empty;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = null;
            this.btnDelete.ImageSize = new System.Drawing.Size(20, 20);
            this.btnDelete.Location = new System.Drawing.Point(456, 133);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnDelete.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnDelete.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDelete.OnHoverForeColor = System.Drawing.Color.White;
            this.btnDelete.OnHoverImage = null;
            this.btnDelete.OnPressedColor = System.Drawing.Color.Black;
            this.btnDelete.Radius = 10;
            this.btnDelete.Size = new System.Drawing.Size(98, 29);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(28, 234);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(740, 267);
            this.dataGridView.TabIndex = 18;
            // 
            // btnLoadData
            // 
            this.btnLoadData.AnimationHoverSpeed = 0.07F;
            this.btnLoadData.AnimationSpeed = 0.03F;
            this.btnLoadData.BackColor = System.Drawing.Color.Transparent;
            this.btnLoadData.BaseColor1 = System.Drawing.Color.SlateBlue;
            this.btnLoadData.BaseColor2 = System.Drawing.Color.Fuchsia;
            this.btnLoadData.BorderColor = System.Drawing.Color.Black;
            this.btnLoadData.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLoadData.FocusedColor = System.Drawing.Color.Empty;
            this.btnLoadData.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLoadData.ForeColor = System.Drawing.Color.White;
            this.btnLoadData.Image = null;
            this.btnLoadData.ImageSize = new System.Drawing.Size(20, 20);
            this.btnLoadData.Location = new System.Drawing.Point(559, 133);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnLoadData.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnLoadData.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnLoadData.OnHoverForeColor = System.Drawing.Color.White;
            this.btnLoadData.OnHoverImage = null;
            this.btnLoadData.OnPressedColor = System.Drawing.Color.Black;
            this.btnLoadData.Radius = 10;
            this.btnLoadData.Size = new System.Drawing.Size(98, 29);
            this.btnLoadData.TabIndex = 20;
            this.btnLoadData.Text = "Load Data";
            this.btnLoadData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 551);
            this.Controls.Add(this.btnLoadData);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtstok);
            this.Controls.Add(this.txtharga);
            this.Controls.Add(this.txtnama);
            this.Controls.Add(this.txtkode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtkode;
        private System.Windows.Forms.TextBox txtnama;
        private System.Windows.Forms.TextBox txtharga;
        private System.Windows.Forms.TextBox txtstok;
        private Guna.UI.WinForms.GunaGradientButton btnAdd;
        private Guna.UI.WinForms.GunaGradientButton btnUpdate;
        private Guna.UI.WinForms.GunaGradientButton btnDelete;
        private System.Windows.Forms.DataGridView dataGridView;
        private Guna.UI.WinForms.GunaGradientButton btnLoadData;
    }
}

