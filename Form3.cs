using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI_Entrega
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }


        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'db_conexaoDataSet.produto'. Você pode
            // movê-la ou removê-la conforme necessário.
            this.produtoTableAdapter.Fill(this.db_conexaoDataSet.produto);

        }

            // Botão Salvar
        private void produtoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            // Para evitar erros no sistema, utilizamos o "tratamento de erros try, catch".

            try  // Tente realizar o que está dentro das chaves dos comandos a seguir.
            {     

                this.Validate(); // Valida, o controlador verifica e exibi a entrada de dados para o usuário.
                this.produtoBindingSource.EndEdit(); // Confirma e conclui a operação de edição na célula atual.
                produtoTableAdapter.Update(db_conexaoDataSet.produto); // Entende que efetuará uma atualização na tabela definida, e salva os dados.
                groupBox1.Enabled = false; // Bloqueia a box após salvar
                MessageBox.Show("Registro salvo", "CONTROLLER COMERCIAL"); // Exibe a mensagem registro salvo.


            }
            catch (Exception)  //Caso captura o erro, exibirá a mensagem.
            {
                MessageBox.Show("Ocorreu um erro, verifique os valores informados");
            }

        }

            // Botão adicionar
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            produtoBindingSource.AddNew();// O BindingSource tem o método de adicionar, cria o espaço em branco, aí o usuário poderá cancelar ou salvar.
            groupBox1.Enabled = true; // Libera a box para adicionar após clicar no botão adicionar
        }

            // Botão editar

        private void btnEditar_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true; // Libera a box para editar apoós clicar no botão editar
        }


        // Botão cancelar
         private void btnCancelar_Click(object sender, EventArgs e)
        {

            produtoBindingSource.CancelEdit();// Cancela a operação atual.
            groupBox1.Enabled = false; // Bloqueia a box após cancelar
        }

        // Botão Delete

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
           

            try

            {   // Tente realizar a seguir.
                // Para evitar erros e travar o sistema se não puder excluir, criamos dentro da estrutura de decisão if a pergunta de confirmação,

                if (MessageBox.Show("Confirme exclusão do registro", "CONTROLE DE LOJA", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    produtoBindingSource.RemoveCurrent(); // Se o usuário clicar em sim, executa o " remove current" e remove,
                    produtoTableAdapter.Update(db_conexaoDataSet.produto); // atualiza, salva.
                }
            }
            catch (Exception) // Se der erro, não travar e trazer de volta o que deu erro com o comando (.Fill)
            {
                
                produtoTableAdapter.Fill(db_conexaoDataSet.produto);
                MessageBox.Show("Registro não pode ser excluído");

            }

        }
    }
}


