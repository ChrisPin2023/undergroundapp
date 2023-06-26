using Models.Entities;
using Models.Interfaces;
using Services.DTOS.Hospital;

namespace Services.Clients
{
    public class HospitalClient
    {
        private readonly IHospital _hospital;
        public HospitalClient(IHospital hospital)
        {
            _hospital = hospital;
        }
        private string dataHoje = DateTime.Now.ToString("dd/MM/yyyy");
        public Task<IEnumerable<Hospital>> ExibirTodos()
        {
            try
            {
                var listaH = _hospital.Exibir();
                if (listaH.ToString == string.IsNullOrEmpty)
                {
                    throw new NullReferenceException("Nenhum dado foi encontrado");
                }
                return Task.FromResult(listaH);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }       
        public Task<Hospital> ExibirUm(Guid id)
        {
            try
            {
                var hospital = _hospital.Exibir(id);
                if (hospital == null)
                {
                    throw new NullReferenceException("Nenhum dado foi encontrado");
                }

                return hospital;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }        
        public async Task Inserir(AddHospitalDTO hospitalDTO)
        {
           try
           {
               var novoHospital = new Hospital{
                NomeHospital = hospitalDTO.NomeHospital,
                Servicos = hospitalDTO.Servicos,
                DataCadastro = dataHoje
                };

                if(hospitalDTO.NomeHospital == null)
                    throw new NullReferenceException
                        ($"Campo {hospitalDTO.NomeHospital} é obrigatorio");
                
                if(hospitalDTO.NomeHospital == null)
                    throw new NullReferenceException
                        ($"Campo {hospitalDTO.Servicos} é obrigatorio");


                await _hospital.Inserir(novoHospital);
                return;
           }
           catch (System.Exception ex)
           {
                throw new Exception(ex.Message);
           }
            
        }
        public async Task Atualizar(AtualizarHospitalDTO hospitalDTO)
        {
            var buscaHospital = await ExibirUm(hospitalDTO.Id);
            if(buscaHospital == null)
                throw new 
                    NullReferenceException("hospital selecionado não existe");
           try
           {
            
               await _hospital.Atualizar(buscaHospital);

                if(hospitalDTO.NomeHospital == null)
                    throw new NullReferenceException
                        ($"Campo {hospitalDTO.NomeHospital} é obrigatorio");
                
                if(hospitalDTO.NomeHospital == null)
                    throw new NullReferenceException
                        ($"Campo {hospitalDTO.Servicos} é obrigatorio");

           }
           catch (System.Exception ex)
           {
                throw new Exception(ex.Message);
           }
            
        }
    }
}