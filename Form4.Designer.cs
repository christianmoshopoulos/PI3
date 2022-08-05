namespace PI_Entrega
{
    partial class Form4
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
            System.Windows.Forms.Label fk_est_cod_itemLabel;
            System.Windows.Forms.Label fk_est_marcaLabel;
            System.Windows.Forms.Label qtde_estoqueLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.db_conexaoDataSet = new PI_Entrega.db_conexaoDataSet();
            this.estoqueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estoqueTableAdapter = new PI_Entrega.db_conexaoDataSetTableAdapters.estoqueTableAdapter();
            this.tableAdapterManager = new PI_Entrega.db_conexaoDataSetTableAdapters.TableAdapterManager();
            this.estoqueBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.estoqueBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.qtde_estoqueTextBox = new System.Windows.Forms.TextBox();
            this.fk_est_marcaTextBox = new System.Windows.Forms.TextBox();
            this.fk_est_cod_itemTextBox = new System.Windows.Forms.TextBox();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produtoTableAdapter = new PI_Entrega.db_conexaoDataSetTableAdapters.produtoTableAdapter();
            fk_est_cod_itemLabel = new System.Windows.Forms.Label();
            fk_est_marcaLabel = new System.Windows.Forms.Label();
            qtde_estoqueLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.db_conexaoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueBindingNavigator)).BeginInit();
            this.estoqueBindingNavigator.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // fk_est_cod_itemLabel
            // 
            fk_est_cod_itemLabel.AutoSize = true;
            fk_est_cod_itemLabel.BackColor = System.Drawing.Color.Transparent;
            fk_est_cod_itemLabel.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fk_est_cod_itemLabel.ForeColor = System.Drawing.Color.White;
            fk_est_cod_itemLabel.Location = new System.Drawing.Point(81, 79);
            fk_est_cod_itemLabel.Name = "fk_est_cod_itemLabel";
            fk_est_cod_itemLabel.Size = new System.Drawing.Size(288, 40);
            fk_est_cod_itemLabel.TabIndex = 2;
            fk_est_cod_itemLabel.Text = "Código do Ítem:";
            // 
            // fk_est_marcaLabel
            // 
            fk_est_marcaLabel.AutoSize = true;
            fk_est_marcaLabel.BackColor = System.Drawing.Color.Transparent;
            fk_est_marcaLabel.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fk_est_marcaLabel.ForeColor = System.Drawing.Color.White;
            fk_est_marcaLabel.Location = new System.Drawing.Point(81, 177);
            fk_est_marcaLabel.Name = "fk_est_marcaLabel";
            fk_est_marcaLabel.Size = new System.Drawing.Size(135, 40);
            fk_est_marcaLabel.TabIndex = 4;
            fk_est_marcaLabel.Text = "Marca:";
            // 
            // qtde_estoqueLabel
            // 
            qtde_estoqueLabel.AutoSize = true;
            qtde_estoqueLabel.BackColor = System.Drawing.Color.Transparent;
            qtde_estoqueLabel.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            qtde_estoqueLabel.ForeColor = System.Drawing.Color.White;
            qtde_estoqueLabel.Location = new System.Drawing.Point(81, 281);
            qtde_estoqueLabel.Name = "qtde_estoqueLabel";
            qtde_estoqueLabel.Size = new System.Drawing.Size(363, 40);
            qtde_estoqueLabel.TabIndex = 6;
            qtde_estoqueLabel.Text = "Quantidade Estoque:";
            // 
            // db_conexaoDataSet
            // 
            this.db_conexaoDataSet.DataSetName = "db_conexaoDataSet";
            this.db_conexaoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // estoqueBindingSource
            // 
            this.estoqueBindingSource.DataMember = "estoque";
            this.estoqueBindingSource.DataSource = this.db_conexaoDataSet;
            // 
            // estoqueTableAdapter
            // 
            this.estoqueTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.estoqueTableAdapter = this.estoqueTableAdapter;
            this.tableAdapterManager.marcaTableAdapter = null;
            this.tableAdapterManager.produtoTableAdapter = null;
            this.tableAdapterManager.registro_vendaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PI_Entrega.db_conexaoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.vendasTableAdapter = null;
            // 
            // estoqueBindingNavigator
            // 
            this.estoqueBindingNavigator.AddNewItem = null;
            this.estoqueBindingNavigator.BindingSource = this.estoqueBindingSource;
            this.estoqueBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.estoqueBindingNavigator.DeleteItem = null;
            this.estoqueBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.estoqueBindingNavigator.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.estoqueBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.estoqueBindingNavigatorSaveItem,
            this.btnCancelar,
            this.btnEditar});
            this.estoqueBindingNavigator.Location = new System.Drawing.Point(198, 9);
            this.estoqueBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.estoqueBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.estoqueBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.estoqueBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.estoqueBindingNavigator.Name = "estoqueBindingNavigator";
            this.estoqueBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.estoqueBindingNavigator.Size = new System.Drawing.Size(455, 39);
            this.estoqueBindingNavigator.TabIndex = 0;
            this.estoqueBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 36);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(36, 36);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(36, 36);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 39);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(36, 36);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(36, 36);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(36, 36);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(36, 36);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // estoqueBindingNavigatorSaveItem
            // 
            this.estoqueBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.estoqueBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("estoqueBindingNavigatorSaveItem.Image")));
            this.estoqueBindingNavigatorSaveItem.Name = "estoqueBindingNavigatorSaveItem";
            this.estoqueBindingNavigatorSaveItem.Size = new System.Drawing.Size(36, 36);
            this.estoqueBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.estoqueBindingNavigatorSaveItem.Click += new System.EventHandler(this.estoqueBindingNavigatorSaveItem_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(36, 36);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(36, 36);
            this.btnEditar.Text = "Editar";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.qtde_estoqueTextBox);
            this.groupBox1.Controls.Add(this.fk_est_marcaTextBox);
            this.groupBox1.Controls.Add(this.fk_est_cod_itemTextBox);
            this.groupBox1.Controls.Add(fk_est_cod_itemLabel);
            this.groupBox1.Controls.Add(fk_est_marcaLabel);
            this.groupBox1.Controls.Add(qtde_estoqueLabel);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(47, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(817, 370);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // qtde_estoqueTextBox
            // 
            this.qtde_estoqueTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.estoqueBindingSource, "qtde_estoque", true));
            this.qtde_estoqueTextBox.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtde_estoqueTextBox.Location = new System.Drawing.Point(481, 268);
            this.qtde_estoqueTextBox.Name = "qtde_estoqueTextBox";
            this.qtde_estoqueTextBox.Size = new System.Drawing.Size(290, 53);
            this.qtde_estoqueTextBox.TabIndex = 9;
            // 
            // fk_est_marcaTextBox
            // 
            this.fk_est_marcaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.estoqueBindingSource, "fk_est_marca", true));
            this.fk_est_marcaTextBox.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fk_est_marcaTextBox.Location = new System.Drawing.Point(481, 164);
            this.fk_est_marcaTextBox.Name = "fk_est_marcaTextBox";
            this.fk_est_marcaTextBox.Size = new System.Drawing.Size(290, 53);
            this.fk_est_marcaTextBox.TabIndex = 8;
            // 
            // fk_est_cod_itemTextBox
            // 
            this.fk_est_cod_itemTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.estoqueBindingSource, "fk_est_cod_item", true));
            this.fk_est_cod_itemTextBox.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fk_est_cod_itemTextBox.Location = new System.Drawing.Point(481, 66);
            this.fk_est_cod_itemTextBox.Name = "fk_est_cod_itemTextBox";
            this.fk_est_cod_itemTextBox.Size = new System.Drawing.Size(290, 53);
            this.fk_est_cod_itemTextBox.TabIndex = 7;
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataMember = "produto";
            this.produtoBindingSource.DataSource = this.db_conexaoDataSet;
            // 
            // produtoTableAdapter
            // 
            this.produtoTableAdapter.ClearBeforeFill = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(898, 532);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.estoqueBindingNavigator);
            this.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.db_conexaoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueBindingNavigator)).EndInit();
            this.estoqueBindingNavigator.ResumeLayout(false);
            this.estoqueBindingNavigator.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private db_conexaoDataSet db_conexaoDataSet;
        private System.Windows.Forms.BindingSource estoqueBindingSource;
        private db_conexaoDataSetTableAdapters.estoqueTableAdapter estoqueTableAdapter;
        private db_conexaoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator estoqueBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton estoqueBindingNavigatorSaveItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.ToolStripButton btnEditar;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private db_conexaoDataSetTableAdapters.produtoTableAdapter produtoTableAdapter;
        private System.Windows.Forms.TextBox qtde_estoqueTextBox;
        private System.Windows.Forms.TextBox fk_est_marcaTextBox;
        private System.Windows.Forms.TextBox fk_est_cod_itemTextBox;
    }
}