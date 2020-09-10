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
    public partial class FrmListy : Form
    {
        private readonly List<ListaZadan> _listy = new List<ListaZadan>();

        public FrmListy()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            _listy.Clear();
            _listy.AddRange(MagazynDanych.OdczytajListyZadan());

            // inicjalizacja formatki
            OdswiezListbox();
        }

        private void _btnUtworzListe_Click(object sender, EventArgs e)
        {
            var dialog = new TextInputDialog("Podaj nazwę listy");
            var result = dialog.ShowDialog();
            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(dialog.WprowadzonyTekst))
            {
                var lista = new ListaZadan(dialog.WprowadzonyTekst.Trim());
                _listy.Add(lista);
                ZapiszListy();
                OdswiezListbox();
            }
        }

        private void _btnZmienNazwe_Click(object sender, EventArgs e)
        {

        }

        private void _btnUsun_Click(object sender, EventArgs e)
        {

        }

        private void _lbxListy_DoubleClick(object sender, EventArgs e)
        {
            var lista = _lbxListy.SelectedItem as ListaZadan;
            if (lista == null) return;

            var frm = new FrmListaZadan(lista);
            frm.ListaZmieniona += frmListaZadan_ListaZmieniona;
            frm.ShowDialog();
        }

        private void frmListaZadan_ListaZmieniona(object sender, EventArgs e)
        {
            ZapiszListy();
        }

        private void OdswiezListbox()
        {
            _lbxListy.Items.Clear();
            foreach (var lista in _listy)
            {
                _lbxListy.Items.Add(lista);
            }
        }

        private void ZapiszListy()
        {
            MagazynDanych.ZapiszListyZadan(_listy);
        }
    }
}
