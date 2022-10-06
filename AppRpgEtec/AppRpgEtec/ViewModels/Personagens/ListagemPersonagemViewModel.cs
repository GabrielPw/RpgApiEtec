using AppRpgEtec.Models;
using AppRpgEtec.Services.Personagens;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppRpgEtec.ViewModels.Personagens
{
    public class ListagemPersonagemViewModel : BaseViewModel
    {

        private PersonagemService pService;
        public ObservableCollection<Personagem> Personagens { get; set; }

        public ListagemPersonagemViewModel()
        {
            string token = "";
            pService = new PersonagemService(token);

            Personagens = new ObservableCollection<Personagem>();
            _ = ObterPersonagens();
        }

        public async Task ObterPersonagens() {

            try
            {

            }
            catch (Exception ex)
            {

                await Application.Current.MainPage.DisplayAlert("Oops", ex.Message + "Detalhes: " + ex.InnerException, "Ok");
                throw;
            }
        }
    }
}
