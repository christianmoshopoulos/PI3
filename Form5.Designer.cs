namespace PI_Entrega
{
    partial class Form5
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
            System.Windows.Forms.Label fk_cod_itemLabel;
            System.Windows.Forms.Label qtdeLabel;
            System.Windows.Forms.Label valor_compraLabel;
            System.Windows.Forms.Label nfLabel;
            System.Windows.Forms.Label dataLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.registro_vendaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.registro_vendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_conexaoDataSet = new PI_Entrega.db_conexaoDataSet();
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
            this.registro_vendaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataTextBox = new System.Windows.Forms.TextBox();
            this.nfMaskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.valor_compraTextBox = new System.Windows.Forms.TextBox();
            this.qtdeMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.fk_cod_itemMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.nfMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.registro_vendaTableAdapter = new PI_Entrega.db_conexaoDataSetTableAdapters.registro_vendaTableAdapter();
            this.tableAdapterManager = new PI_Entrega.db_conexaoDataSetTableAdapters.TableAdapterManager();
            fk_cod_itemLabel = new System.Windows.Forms.Label();
            qtdeLabel = new System.Windows.Forms.Label();
            valor_compraLabel = new System.Windows.Forms.Label();
            nfLabel = new System.Windows.Forms.Label();
            dataLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.registro_vendaBindingNavigator)).BeginInit();
            this.registro_vendaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.registro_vendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_conexaoDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fk_cod_itemLabel
            // 
            fk_cod_itemLabel.AutoSize = true;
            fk_cod_itemLabel.BackColor = System.Drawing.Color.Transparent;
            fk_cod_itemLabel.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fk_cod_itemLabel.ForeColor = System.Drawing.Color.White;
            fk_cod_itemLabel.Location = new System.Drawing.Point(116, 30);
            fk_cod_itemLabel.Name = "fk_cod_itemLabel";
            fk_cod_itemLabel.Size = new System.Drawing.Size(288, 40);
            fk_cod_itemLabel.TabIndex = 0;
            fk_cod_itemLabel.Text = "Código do Ítem:";
            // 
            // qtdeLabel
            // 
            qtdeLabel.AutoSize = true;
            qtdeLabel.BackColor = System.Drawing.Color.Transparent;
            qtdeLabel.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            qtdeLabel.ForeColor = System.Drawing.Color.White;
            qtdeLabel.Location = new System.Drawing.Point(116, 101);
            qtdeLabel.Name = "qtdeLabel";
            qtdeLabel.Size = new System.Drawing.Size(224, 40);
            qtdeLabel.TabIndex = 2;
            qtdeLabel.Text = "Quantidade:";
            // 
            // valor_compraLabel
            // 
            valor_compraLabel.AutoSize = true;
            valor_compraLabel.BackColor = System.Drawing.Color.Transparent;
            valor_compraLabel.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            valor_compraLabel.ForeColor = System.Drawing.Color.White;
            valor_compraLabel.Location = new System.Drawing.Point(116, 177);
            valor_compraLabel.Name = "valor_compraLabel";
            valor_compraLabel.Size = new System.Drawing.Size(383, 40);
            valor_compraLabel.TabIndex = 4;
            valor_compraLabel.Text = "Valor da Compra:  R$:";
            // 
            // nfLabel
            // 
            nfLabel.AutoSize = true;
            nfLabel.BackColor = System.Drawing.Color.Transparent;
            nfLabel.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nfLabel.ForeColor = System.Drawing.Color.White;
            nfLabel.Location = new System.Drawing.Point(116, 250);
            nfLabel.Name = "nfLabel";
            nfLabel.Size = new System.Drawing.Size(207, 40);
            nfLabel.TabIndex = 6;
            nfLabel.Text = "Nota Fiscal:";
            // 
            // dataLabel
            // 
            dataLabel.AutoSize = true;
            dataLabel.BackColor = System.Drawing.Color.Transparent;
            dataLabel.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataLabel.ForeColor = System.Drawing.Color.White;
            dataLabel.Location = new System.Drawing.Point(116, 318);
            dataLabel.Name = "dataLabel";
            dataLabel.Size = new System.Drawing.Size(105, 40);
            dataLabel.TabIndex = 8;
            dataLabel.Text = "Data:";
            // 
            // registro_vendaBindingNavigator
            // 
            this.registro_vendaBindingNavigator.AddNewItem = null;
            this.registro_vendaBindingNavigator.BindingSource = this.registro_vendaBindingSource;
            this.registro_vendaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.registro_vendaBindingNavigator.DeleteItem = null;
            this.registro_vendaBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.registro_vendaBindingNavigator.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.registro_vendaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.registro_vendaBindingNavigatorSaveItem,
            this.btnCancelar,
            this.btnEditar});
            this.registro_vendaBindingNavigator.Location = new System.Drawing.Point(198, 9);
            this.registro_vendaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.registro_vendaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.registro_vendaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.registro_vendaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.registro_vendaBindingNavigator.Name = "registro_vendaBindingNavigator";
            this.registro_vendaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.registro_vendaBindingNavigator.Size = new System.Drawing.Size(455, 39);
            this.registro_vendaBindingNavigator.TabIndex = 0;
            this.registro_vendaBindingNavigator.Text = "bindingNavigator1";
            // 
            // registro_vendaBindingSource
            // 
            this.registro_vendaBindingSource.DataMember = "registro_venda";
            this.registro_vendaBindingSource.DataSource = this.db_conexaoDataSet;
            // 
            // db_conexaoDataSet
            // 
            this.db_conexaoDataSet.DataSetName = "db_conexaoDataSet";
            this.db_conexaoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // registro_vendaBindingNavigatorSaveItem
            // 
            this.registro_vendaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.registro_vendaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("registro_vendaBindingNavigatorSaveItem.Image")));
            this.registro_vendaBindingNavigatorSaveItem.Name = "registro_vendaBindingNavigatorSaveItem";
            this.registro_vendaBindingNavigatorSaveItem.Size = new System.Drawing.Size(36, 36);
            this.registro_vendaBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.registro_vendaBindingNavigatorSaveItem.Click += new System.EventHandler(this.registro_vendaBindingNavigatorSaveItem_Click);
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
            this.groupBox1.Controls.Add(this.dataTextBox);
            this.groupBox1.Controls.Add(this.nfMaskedTextBox1);
            this.groupBox1.Controls.Add(this.valor_compraTextBox);
            this.groupBox1.Controls.Add(this.qtdeMaskedTextBox);
            this.groupBox1.Controls.Add(this.fk_cod_itemMaskedTextBox);
            this.groupBox1.Controls.Add(this.nfMaskedTextBox);
            this.groupBox1.Controls.Add(fk_cod_itemLabel);
            this.groupBox1.Controls.Add(qtdeLabel);
            this.groupBox1.Controls.Add(valor_compraLabel);
            this.groupBox1.Controls.Add(nfLabel);
            this.groupBox1.Controls.Add(dataLabel);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(47, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(852, 383);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // dataTextBox
            // 
            this.dataTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registro_vendaBindingSource, "data", true));
            this.dataTextBox.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataTextBox.Location = new System.Drawing.Point(490, 310);
            this.dataTextBox.Name = "dataTextBox";
            this.dataTextBox.Size = new System.Drawing.Size(290, 48);
            this.dataTextBox.TabIndex = 23;
            // 
            // nfMaskedTextBox1
            // 
            this.nfMaskedTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registro_vendaBindingSource, "nf", true));
            this.nfMaskedTextBox1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nfMaskedTextBox1.Location = new System.Drawing.Point(490, 242);
            this.nfMaskedTextBox1.Mask = "00000";
            this.nfMaskedTextBox1.Name = "nfMaskedTextBox1";
            this.nfMaskedTextBox1.Size = new System.Drawing.Size(290, 48);
            this.nfMaskedTextBox1.TabIndex = 22;
            // 
            // valor_compraTextBox
            // 
            this.valor_compraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registro_vendaBindingSource, "valor_compra", true));
            this.valor_compraTextBox.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valor_compraTextBox.Location = new System.Drawing.Point(490, 169);
            this.valor_compraTextBox.Name = "valor_compraTextBox";
            this.valor_compraTextBox.Size = new System.Drawing.Size(290, 48);
            this.valor_compraTextBox.TabIndex = 21;
            // 
            // qtdeMaskedTextBox
            // 
            this.qtdeMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registro_vendaBindingSource, "qtde", true));
            this.qtdeMaskedTextBox.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtdeMaskedTextBox.Location = new System.Drawing.Point(490, 97);
            this.qtdeMaskedTextBox.Name = "qtdeMaskedTextBox";
            this.qtdeMaskedTextBox.Size = new System.Drawing.Size(290, 48);
            this.qtdeMaskedTextBox.TabIndex = 20;
            // 
            // fk_cod_itemMaskedTextBox
            // 
            this.fk_cod_itemMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registro_vendaBindingSource, "fk_cod_item", true));
            this.fk_cod_itemMaskedTextBox.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fk_cod_itemMaskedTextBox.Location = new System.Drawing.Point(490, 26);
            this.fk_cod_itemMaskedTextBox.Name = "fk_cod_itemMaskedTextBox";
            this.fk_cod_itemMaskedTextBox.Size = new System.Drawing.Size(290, 48);
            this.fk_cod_itemMaskedTextBox.TabIndex = 19;
            // 
            // nfMaskedTextBox
            // 
            this.nfMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registro_vendaBindingSource, "nf", true));
            this.nfMaskedTextBox.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nfMaskedTextBox.Location = new System.Drawing.Point(476, 263);
            this.nfMaskedTextBox.Mask = "00000";
            this.nfMaskedTextBox.Name = "nfMaskedTextBox";
            this.nfMaskedTextBox.Size = new System.Drawing.Size(0, 49);
            this.nfMaskedTextBox.TabIndex = 18;
            this.nfMaskedTextBox.ValidatingType = typeof(int);
            // 
            // registro_vendaTableAdapter
            // 
            this.registro_vendaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.estoqueTableAdapter = null;
            this.tableAdapterManager.marcaTableAdapter = null;
            this.tableAdapterManager.produtoTableAdapter = null;
            this.tableAdapterManager.registro_vendaTableAdapter = this.registro_vendaTableAdapter;
            this.tableAdapterManager.UpdateOrder = PI_Entrega.db_conexaoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.vendasTableAdapter = null;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(899, 532);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.registro_vendaBindingNavigator);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.registro_vendaBindingNavigator)).EndInit();
            this.registro_vendaBindingNavigator.ResumeLayout(false);
            this.registro_vendaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.registro_vendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_conexaoDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private db_conexaoDataSet db_conexaoDataSet;
        private System.Windows.Forms.BindingSource registro_vendaBindingSource;
        private db_conexaoDataSetTableAdapters.registro_vendaTableAdapter registro_vendaTableAdapter;
        private db_conexaoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator registro_vendaBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton registro_vendaBindingNavigatorSaveItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.ToolStripButton btnEditar;
        private System.Windows.Forms.MaskedTextBox nfMaskedTextBox;
        private System.Windows.Forms.TextBox dataTextBox;
        private System.Windows.Forms.MaskedTextBox nfMaskedTextBox1;
        private System.Windows.Forms.TextBox valor_compraTextBox;
        private System.Windows.Forms.MaskedTextBox qtdeMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox fk_cod_itemMaskedTextBox;
    }
}