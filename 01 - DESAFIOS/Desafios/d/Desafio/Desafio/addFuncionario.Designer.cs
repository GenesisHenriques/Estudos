
namespace Desafio
{
    partial class addFuncionario
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label telefoneLabel;
            System.Windows.Forms.Label celularLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label endereçoLabel;
            System.Windows.Forms.Label numeroLabel;
            System.Windows.Forms.Label cidadeLabel;
            System.Windows.Forms.Label sexoFLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomePesquisa = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnRelatorio = new System.Windows.Forms.Button();
            this.cadastrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cadastrosTableAdapter = new Desafio.AuE_SoluçõesDataSetTableAdapters.CadastrosTableAdapter();
            this.tableAdapterManager = new Desafio.AuE_SoluçõesDataSetTableAdapters.TableAdapterManager();
            this.cadastrosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cadastrosTableAdapter1 = new Desafio.AuE_SoluçõesDataSet1TableAdapters.CadastrosTableAdapter();
            this.tableAdapterManager1 = new Desafio.AuE_SoluçõesDataSet1TableAdapters.TableAdapterManager();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.telefoneTextBox = new System.Windows.Forms.TextBox();
            this.celularTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.endereçoTextBox = new System.Windows.Forms.TextBox();
            this.numeroTextBox = new System.Windows.Forms.TextBox();
            this.cidadeTextBox = new System.Windows.Forms.TextBox();
            this.sexoFCheckBox = new System.Windows.Forms.CheckBox();
            this.AuE_SoluçõesDataSet1 = new Desafio.AuE_SoluçõesDataSet();
            this.auE_SoluçõesDataSet1 = new Desafio.AuE_SoluçõesDataSet1();
            this.sexoMCheckBox = new System.Windows.Forms.CheckBox();
            nomeLabel = new System.Windows.Forms.Label();
            telefoneLabel = new System.Windows.Forms.Label();
            celularLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            endereçoLabel = new System.Windows.Forms.Label();
            numeroLabel = new System.Windows.Forms.Label();
            cidadeLabel = new System.Windows.Forms.Label();
            sexoFLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cadastrosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastrosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AuE_SoluçõesDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.auE_SoluçõesDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(47, 141);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(42, 13);
            nomeLabel.TabIndex = 35;
            nomeLabel.Text = "NOME:";
            // 
            // telefoneLabel
            // 
            telefoneLabel.AutoSize = true;
            telefoneLabel.Location = new System.Drawing.Point(47, 180);
            telefoneLabel.Name = "telefoneLabel";
            telefoneLabel.Size = new System.Drawing.Size(66, 13);
            telefoneLabel.TabIndex = 36;
            telefoneLabel.Text = "TELEFONE:";
            // 
            // celularLabel
            // 
            celularLabel.AutoSize = true;
            celularLabel.Location = new System.Drawing.Point(312, 180);
            celularLabel.Name = "celularLabel";
            celularLabel.Size = new System.Drawing.Size(59, 13);
            celularLabel.TabIndex = 37;
            celularLabel.Text = "CELULAR:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(50, 221);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(42, 13);
            emailLabel.TabIndex = 38;
            emailLabel.Text = "EMAIL:";
            // 
            // endereçoLabel
            // 
            endereçoLabel.AutoSize = true;
            endereçoLabel.Location = new System.Drawing.Point(50, 259);
            endereçoLabel.Name = "endereçoLabel";
            endereçoLabel.Size = new System.Drawing.Size(70, 13);
            endereçoLabel.TabIndex = 39;
            endereçoLabel.Text = "ENDEREÇO:";
            // 
            // numeroLabel
            // 
            numeroLabel.AutoSize = true;
            numeroLabel.Location = new System.Drawing.Point(50, 293);
            numeroLabel.Name = "numeroLabel";
            numeroLabel.Size = new System.Drawing.Size(19, 13);
            numeroLabel.TabIndex = 40;
            numeroLabel.Text = "Nº";
            // 
            // cidadeLabel
            // 
            cidadeLabel.AutoSize = true;
            cidadeLabel.Location = new System.Drawing.Point(312, 293);
            cidadeLabel.Name = "cidadeLabel";
            cidadeLabel.Size = new System.Drawing.Size(50, 13);
            cidadeLabel.TabIndex = 41;
            cidadeLabel.Text = "CIDADE:";
            // 
            // sexoFLabel
            // 
            sexoFLabel.AutoSize = true;
            sexoFLabel.Location = new System.Drawing.Point(50, 332);
            sexoFLabel.Name = "sexoFLabel";
            sexoFLabel.Size = new System.Drawing.Size(39, 13);
            sexoFLabel.TabIndex = 42;
            sexoFLabel.Text = "SEXO:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "PESQUISAR NOME:";
            // 
            // txtNomePesquisa
            // 
            this.txtNomePesquisa.Location = new System.Drawing.Point(159, 96);
            this.txtNomePesquisa.Name = "txtNomePesquisa";
            this.txtNomePesquisa.Size = new System.Drawing.Size(406, 20);
            this.txtNomePesquisa.TabIndex = 1;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAdicionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAdicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdicionar.FlatAppearance.BorderSize = 0;
            this.btnAdicionar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Olive;
            this.btnAdicionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAdicionar.Location = new System.Drawing.Point(47, 12);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(98, 48);
            this.btnAdicionar.TabIndex = 7;
            this.btnAdicionar.Text = "ADICIONAR";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.SeaGreen;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Olive;
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnBuscar.Location = new System.Drawing.Point(255, 12);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(98, 48);
            this.btnBuscar.TabIndex = 20;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // btnApagar
            // 
            this.btnApagar.BackColor = System.Drawing.Color.SeaGreen;
            this.btnApagar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnApagar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApagar.FlatAppearance.BorderSize = 0;
            this.btnApagar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Olive;
            this.btnApagar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnApagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnApagar.Location = new System.Drawing.Point(467, 12);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(98, 48);
            this.btnApagar.TabIndex = 22;
            this.btnApagar.Text = "APAGAR";
            this.btnApagar.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.SeaGreen;
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Olive;
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnEditar.Location = new System.Drawing.Point(361, 12);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(98, 48);
            this.btnEditar.TabIndex = 23;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Olive;
            this.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSalvar.Location = new System.Drawing.Point(150, 12);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(98, 48);
            this.btnSalvar.TabIndex = 24;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = false;
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.BackColor = System.Drawing.Color.SeaGreen;
            this.btnRelatorio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRelatorio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRelatorio.FlatAppearance.BorderSize = 0;
            this.btnRelatorio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Olive;
            this.btnRelatorio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnRelatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatorio.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnRelatorio.Location = new System.Drawing.Point(170, 377);
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Size = new System.Drawing.Size(269, 48);
            this.btnRelatorio.TabIndex = 25;
            this.btnRelatorio.Text = "RELATÓRIO";
            this.btnRelatorio.UseVisualStyleBackColor = false;
            // 
            // cadastrosBindingSource
            // 
            this.cadastrosBindingSource.DataMember = "Cadastros";
            // 
            // cadastrosTableAdapter
            // 
            this.cadastrosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CadastrosTableAdapter = this.cadastrosTableAdapter;
            this.tableAdapterManager.UpdateOrder = Desafio.AuE_SoluçõesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cadastrosBindingSource1
            // 
            this.cadastrosBindingSource1.DataMember = "Cadastros";
            // 
            // cadastrosTableAdapter1
            // 
            this.cadastrosTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.CadastrosTableAdapter = this.cadastrosTableAdapter1;
            this.tableAdapterManager1.UpdateOrder = Desafio.AuE_SoluçõesDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadastrosBindingSource1, "nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(123, 138);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(442, 20);
            this.nomeTextBox.TabIndex = 36;
            // 
            // telefoneTextBox
            // 
            this.telefoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadastrosBindingSource1, "telefone", true));
            this.telefoneTextBox.Location = new System.Drawing.Point(123, 177);
            this.telefoneTextBox.Name = "telefoneTextBox";
            this.telefoneTextBox.Size = new System.Drawing.Size(174, 20);
            this.telefoneTextBox.TabIndex = 37;
            // 
            // celularTextBox
            // 
            this.celularTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadastrosBindingSource1, "celular", true));
            this.celularTextBox.Location = new System.Drawing.Point(377, 177);
            this.celularTextBox.Name = "celularTextBox";
            this.celularTextBox.Size = new System.Drawing.Size(188, 20);
            this.celularTextBox.TabIndex = 38;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadastrosBindingSource1, "email", true));
            this.emailTextBox.Location = new System.Drawing.Point(123, 218);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(442, 20);
            this.emailTextBox.TabIndex = 39;
            // 
            // endereçoTextBox
            // 
            this.endereçoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadastrosBindingSource1, "endereço", true));
            this.endereçoTextBox.Location = new System.Drawing.Point(123, 256);
            this.endereçoTextBox.Name = "endereçoTextBox";
            this.endereçoTextBox.Size = new System.Drawing.Size(442, 20);
            this.endereçoTextBox.TabIndex = 40;
            // 
            // numeroTextBox
            // 
            this.numeroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadastrosBindingSource1, "numero", true));
            this.numeroTextBox.Location = new System.Drawing.Point(123, 290);
            this.numeroTextBox.Name = "numeroTextBox";
            this.numeroTextBox.Size = new System.Drawing.Size(174, 20);
            this.numeroTextBox.TabIndex = 41;
            // 
            // cidadeTextBox
            // 
            this.cidadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadastrosBindingSource1, "cidade", true));
            this.cidadeTextBox.Location = new System.Drawing.Point(377, 290);
            this.cidadeTextBox.Name = "cidadeTextBox";
            this.cidadeTextBox.Size = new System.Drawing.Size(188, 20);
            this.cidadeTextBox.TabIndex = 42;
            // 
            // sexoFCheckBox
            // 
            this.sexoFCheckBox.Location = new System.Drawing.Point(123, 327);
            this.sexoFCheckBox.Name = "sexoFCheckBox";
            this.sexoFCheckBox.Size = new System.Drawing.Size(104, 24);
            this.sexoFCheckBox.TabIndex = 43;
            this.sexoFCheckBox.Text = "FEMININO";
            this.sexoFCheckBox.UseVisualStyleBackColor = true;
            // 
            // auE_SoluçõesDataSet
            // 
            this.AuE_SoluçõesDataSet1.DataSetName = "AuE_SoluçõesDataSet";
            this.AuE_SoluçõesDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // auE_SoluçõesDataSet1
            // 
            this.auE_SoluçõesDataSet1.DataSetName = "AuE_SoluçõesDataSet1";
            this.auE_SoluçõesDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sexoMCheckBox
            // 
            this.sexoMCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.cadastrosBindingSource1, "sexoM", true));
            this.sexoMCheckBox.Location = new System.Drawing.Point(215, 327);
            this.sexoMCheckBox.Name = "sexoMCheckBox";
            this.sexoMCheckBox.Size = new System.Drawing.Size(104, 24);
            this.sexoMCheckBox.TabIndex = 44;
            this.sexoMCheckBox.Text = "MASCULINO";
            this.sexoMCheckBox.UseVisualStyleBackColor = true;
            // 
            // addFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 461);
            this.Controls.Add(this.sexoMCheckBox);
            this.Controls.Add(sexoFLabel);
            this.Controls.Add(this.sexoFCheckBox);
            this.Controls.Add(cidadeLabel);
            this.Controls.Add(this.cidadeTextBox);
            this.Controls.Add(numeroLabel);
            this.Controls.Add(this.numeroTextBox);
            this.Controls.Add(endereçoLabel);
            this.Controls.Add(this.endereçoTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(celularLabel);
            this.Controls.Add(this.celularTextBox);
            this.Controls.Add(telefoneLabel);
            this.Controls.Add(this.telefoneTextBox);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(this.btnRelatorio);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.txtNomePesquisa);
            this.Controls.Add(this.label1);
            this.Name = "addFuncionario";
            this.Text = "addFuncionario";
            this.Load += new System.EventHandler(this.addFuncionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cadastrosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastrosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AuE_SoluçõesDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.auE_SoluçõesDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomePesquisa;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnRelatorio;
        private System.Windows.Forms.BindingSource cadastrosBindingSource;
        private AuE_SoluçõesDataSetTableAdapters.CadastrosTableAdapter cadastrosTableAdapter;
        private AuE_SoluçõesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource cadastrosBindingSource1;
        private AuE_SoluçõesDataSet1TableAdapters.CadastrosTableAdapter cadastrosTableAdapter1;
        private AuE_SoluçõesDataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox telefoneTextBox;
        private System.Windows.Forms.TextBox celularTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox endereçoTextBox;
        private System.Windows.Forms.TextBox numeroTextBox;
        private System.Windows.Forms.TextBox cidadeTextBox;
        private System.Windows.Forms.CheckBox sexoFCheckBox;
        private AuE_SoluçõesDataSet AuE_SoluçõesDataSet1;
        private AuE_SoluçõesDataSet1 auE_SoluçõesDataSet1;
        private System.Windows.Forms.CheckBox sexoMCheckBox;
    }
}