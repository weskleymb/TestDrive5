using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDrive5.Models;
using TestDrive5.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestDrive5.Views
{
    public partial class AgendamentoView : ContentPage
    {
        public AgendamentoView(Veiculo veiculo)
        {
            InitializeComponent();
            this.BindingContext = new AgendamentoViewModel(veiculo);
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            MessagingCenter.Subscribe<Agendamento>(this, "Agendamento",
                (agendamento) =>
                {
                    string titulo = "Agendamento";
                    string mensagem = $"Nome: {agendamento.Nome}\n"
                                    + $"Fone: {agendamento.Fone}\n"
                                    + $"Email: {agendamento.Email}\n"
                                    + $"Data: {agendamento.DataAgendamento.ToString("dd/MM/yyyy")}\n"
                                    + $"Hora: {agendamento.HoraAgendamento}";

                    DisplayAlert(titulo, mensagem, "Ok");
                });
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            MessagingCenter.Unsubscribe<Agendamento>(this, "Agendamento");
        }
    }
}
