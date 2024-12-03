using IFSPStore.App.Base;
using IFSPStore.Domain.Base;
using IFSPStore.Domain.Entities;
using IFSPStore.Service.Validators;

namespace IFSPStore.App.Cadastros
{
    public partial class CadastroGrupo : CadastroBase
    {
        private readonly IBaseService<Grupo> _grupoService;

        private List<Grupo>? grupos;

        public CadastroGrupo(IBaseService<Grupo> grupoService)
        {
            _grupoService = grupoService;
            InitializeComponent();
        }

        private void PreencheObjeto(Grupo grupo)
        {
            grupo.Nome = txtNome.Text;
        }

        protected override void Salvar()
        {
            try
            {
                if (IsAlteracao)
                {
                    if (int.TryParse(txtId.Text, out var id))
                    {
                        var grupo = _grupoService.GetById<Grupo>(id);
                        PreencheObjeto(grupo);
                        grupo = _grupoService.Update<Grupo, Grupo, GrupoValidator>(grupo);
                    }
                }
                else
                {
                    var grupo = new Grupo();
                    PreencheObjeto(grupo);
                    _grupoService.Add<Grupo, Grupo, GrupoValidator>(grupo);
                }
                _grupoService.

                tabControlCadastro.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"IFSP Store", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void Deletar(int id)
        {
            try
            {
                _grupoService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"IFSP Store", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        protected override void CarregaGrid()
        {
            grupos = _grupoService.Get<Grupo>(false).ToList();
            dataGridViewConsulta.DataSource = grupos;
            dataGridViewConsulta.Columns["Nome"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            txtId.Text = linha?.Cells["Id"].Value.ToString();
            txtNome.Text = linha?.Cells["Nome"].Value.ToString();
        }

    }
}
