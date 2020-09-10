using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TODOAppDesktop.Model;

namespace TODOAppDesktop
{
    public partial class FrmListaZadan : Form
    {
        private readonly List<Zadanie> _listaZadan = new List<Zadanie>();

        public FrmListaZadan()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            _listaZadan.Clear();
            _listaZadan.AddRange(MagazynDanych.OdczytajZadania());

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
                _listaZadan.Add(zadanie);
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

            _listaZadan.Remove(z);
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

            if(z != null)
            {
                _btnZadanieWGore.Enabled = _lsvZadania.SelectedIndices[0] > 0;
                _btnZadanieWDol.Enabled = _lsvZadania.SelectedIndices[0] < _listaZadan.Count - 1;
            }
        }

        private void _lsvZadania_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            var zadanie = _listaZadan[e.Item.Index];
            zadanie.Wykonane = e.Item.Checked;
            ZapiszListeZadan();
        }


        private void OdswiezListboxZadan()
        {
            var zaznaczonyIndex = _lsvZadania.SelectedIndices.Count == 1 ? _lsvZadania.SelectedIndices[0] : -1;

            _lsvZadania.Items.Clear();

            foreach (var zadanie in _listaZadan)
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
            MagazynDanych.ZapiszZadania(_listaZadan);
        }

        private Zadanie GetZaznaczoneZadanieOrNull()
        {
            if (_lsvZadania.SelectedItems.Count != 1) return null;
            return _listaZadan[_lsvZadania.SelectedItems[0].Index];
        }

        private void PrzesunZadanie(Zadanie zadanie, int indexDo)
        {
            if (zadanie == null) return;

            var indexZ = _listaZadan.IndexOf(zadanie);

            if (indexDo < 0 || indexDo > _listaZadan.Count - 1) return;

            _listaZadan.Remove(zadanie);
            _listaZadan.Insert(indexDo, zadanie);
        }
    }
}
