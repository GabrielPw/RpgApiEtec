using AppRpgEtec.Models;
using AppRpgEtec.Services.Personagens;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

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
        }
    }
}
