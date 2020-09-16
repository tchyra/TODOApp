using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TODOAppDesktop.Model;

namespace TODOAppDesktop
{
    public partial class FrmListaZadan : Form
    {
        private readonly ListaZadan _listaZadan;

        public FrmListaZadan()
        {
            InitializeComponent();
        }

        public FrmListaZadan(ListaZadan lista) : this()
        {
            _listaZadan = lista;
            Text = lista.Nazwa;
        }

        protected override void OnLoad(EventArgs e)
        {
            // inicjalizacja formatki
            OdswiezListboxZadan();
        }


        private void _btnDodajZadanie_Click(object sender, EventArgs e)
        {
            var dialog = new TextInputDialog("Podaj treść zadania");
            var result = dialog.ShowDialog();
            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(dialog.WprowadzonyTekst))
            {
                var zadanie = new Zadanie(false, dialog.WprowadzonyTekst);
                _listaZadan.Zadania.Add(zadanie);
                ZapiszListeZadan();
                OdswiezListboxZadan();
            }
        }

        private void _btnEdytujZadanie_Click(object sender, EventArgs e)
        {
            var z = GetZaznaczoneZadanieOrNull();
            if (z == null) return;

            var dialog = new TextInputDialog("Edytuj treść zadania", z.Tresc);
            var result = dialog.ShowDialog();
            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(dialog.WprowadzonyTekst))
            {
                z.Tresc = dialog.WprowadzonyTekst;
                ZapiszListeZadan();
                OdswiezListboxZadan();
            }
        }

        private void _btnUsunZadanie_Click(object sender, EventArgs e)
        {
            var z = GetZaznaczoneZadanieOrNull();
            if (z == null) return;

            _listaZadan.Zadania.Remove(z);
            ZapiszListeZadan();
            OdswiezListboxZadan();
        }

        private void _btnZadanieWGore_Click(object sender, EventArgs e)
        {
            var z = GetZaznaczoneZadanieOrNull();
            if (z == null) return;

            var indexDo = _lsvZadania.SelectedIndices[0] - 1;
            PrzesunZadanie(z, indexDo);

            ZapiszListeZadan();
            OdswiezListboxZadan();

            _lsvZadania.SelectedIndices.Clear();
            _lsvZadania.SelectedIndices.Add(indexDo);
        }

        private void _btnZadanieWDol_Click(object sender, EventArgs e)
        {
            var z = GetZaznaczoneZadanieOrNull();
            if (z == null) return;

            var indexDo = _lsvZadania.SelectedIndices[0] + 1;
            PrzesunZadanie(z, indexDo);

            ZapiszListeZadan();
            OdswiezListboxZadan();

            _lsvZadania.SelectedIndices.Clear();
            _lsvZadania.SelectedIndices.Add(indexDo);
        }


        private void _lsvZadania_SelectedIndexChanged(object sender, EventArgs e)
        {
            var z = GetZaznaczoneZadanieOrNull();

            _btnUsunZadanie.Enabled
                = _btnEdytujZadanie.Enabled
                = _btnZadanieWDol.Enabled
                = _btnZadanieWGore.Enabled
                = z != null;

            if (z != null)
            {
                _btnZadanieWGore.Enabled = _lsvZadania.SelectedIndices[0] > 0;
                _btnZadanieWDol.Enabled = _lsvZadania.SelectedIndices[0] < _listaZadan.Zadania.Count - 1;
            }
        }

        private void _lsvZadania_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            var zadanie = _listaZadan.Zadania[e.Item.Index];
            zadanie.Wykonane = e.Item.Checked;
            ZapiszListeZadan();
        }


        private void OdswiezListboxZadan()
        {
            var zaznaczonyIndex = _lsvZadania.SelectedIndices.Count == 1 ? _lsvZadania.SelectedIndices[0] : -1;

            _lsvZadania.Items.Clear();

            foreach (var zadanie in _listaZadan.Zadania)
            {
                var item = new ListViewItem(zadanie.Tresc)
                {
                    Checked = zadanie.Wykonane
                };

                _lsvZadania.Items.Add(item);
            }

            if (zaznaczonyIndex != -1)
                _lsvZadania.SelectedIndices.Add(zaznaczonyIndex);
        }

        private void ZapiszListeZadan()
        {
            //MagazynDanych.ZapiszZadania(_listaZadan.Zadania);
            ListaZmieniona?.Invoke(this, EventArgs.Empty);
        }

        private Zadanie GetZaznaczoneZadanieOrNull()
        {
            if (_lsvZadania.SelectedItems.Count != 1) return null;
            return _listaZadan.Zadania[_lsvZadania.SelectedItems[0].Index];
        }

        private void PrzesunZadanie(Zadanie zadanie, int indexDo)
        {
            if (zadanie == null) return;

            if (indexDo < 0 || indexDo > _listaZadan.Zadania.Count - 1) return;

            _listaZadan.Zadania.Remove(zadanie);
            _listaZadan.Zadania.Insert(indexDo, zadanie);
        }

        public event EventHandler ListaZmieniona;
    }
}
