using IFSPStore.App.Base;
using IFSPStore.Domain.Base;
using IFSPStore.Domain.Entities;
using IFSPStore.Service.Validators;

namespace IFSPStore.App.Cadastros
{
    public partial class CadastroCidade : CadastroBase
    {
        private IBaseService<Cidade> _cidadeService;
        private List<Cidade> cidades;
        public CadastroCidade(IBaseService<Cidade> cidadeService)
        {
            _cidadeService = cidadeService;
            InitializeComponent();
        }

        private void PreencheObjeto(Cidade cidade)
        {
            cidade.Nome = txtNome.Text;
            cidade.Estado = cboEstado.Text;
        }

        protected override void Salvar()
        {
            try{
                if (IsAlteracao){
                    if(int.TryParse(txtId.Text, out var id)){
                        var cidade = _cidadeService.GetById<Cidade>(id);
                        PreencheObjeto(cidade);
                        cidade = _cidadeService.Update<Cidade, Cidade, CidadeValidator>(cidade);
                    }
                }
                else{
                    var cidade = new Cidade();
                    PreencheObjeto (cidade);
                    _cidadeService.Add<Cidade,Cidade, CidadeValidator>(cidade); 

                }
                tabControlCadastro.SelectedIndex = 1;
            }
            catch (Exception ex){
                MessageBox.Show(ex.Message, @"IFSP Store",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void Deletar(int id)
        {
            try{
                _cidadeService.Delete(id);
            }catch (Exception ex){
                MessageBox.Show(ex.Message, @"IFSP Store",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            cidades = _cidadeService.Get<Cidade>().ToList(); 
            dataGridViewConsulta.DataSource = cidades;
            dataGridViewConsulta.Columns["Nome"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            txtId.Text = linha?.Cells["Id"].Value.ToString();
            txtNome.Text = linha?.Cells["Nome"].Value.ToString();
            cboEstado.Text = linha?.Cells["Estado"].Value.ToString();
        }       
    }
}
