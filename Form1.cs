using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tugas_Akhir_PDKP
{
    public partial class FormUtama : Form
    {
        public FormUtama()
        {
            InitializeComponent();
            labelselected1.Visible = true;
            labelselected2.Visible = false;
            labelselected3.Visible = false;
            labelselected4.Visible = false;
            labelselected5.Visible = false;
            labelselected6.Visible = false;
            labelselected7.Visible = false;
            labelselected8.Visible = false;
            labelselected9.Visible = false;
            labelselected10.Visible = false;
            //tampilkan button
            buttoncomputercases.Visible = false;
            buttonmothreborard.Visible = false;
            buttoncpu.Visible = false;
            buttongpu.Visible = false;
            buttonpsu.Visible = false;
            buttonmemori.Visible = false;
            buttonpenyimpanan.Visible = false;
            buttoncooling.Visible = false;
            buttonuser.Visible = true;
            //tampilkan
            labelnama.Visible = true;
            labelalamat.Visible = true;
            labelemail.Visible = true;
            labeltelepon.Visible = true;
            textBoxalamat.Visible = true;
            textBoxnama.Visible = true;
            textBoxemail.Visible = true;
            textBoxtelepon.Visible = true;
            labelmidtower.Visible = false;
            comboBoxMidtower.Visible = false;
            buttonsubmitdatadiri.Visible = true;
            labelatxfulltower.Visible = false;
            comboBoxatxfulltower.Visible = false;
            labelintel.Visible = false;
            comboBoxintel.Visible = false;
            labelamd.Visible = false;
            comboBoxamd.Visible = false;
            labelintelcpu.Visible = false;
            comboBoxintelcpu.Visible = false;
            labelamdcpu.Visible = false;
            comboBoxamdcpu.Visible = false;
            labelnvidia.Visible = false;
            comboBoxnvidia.Visible = false;
            labelryzen.Visible = false;
            comboBoxryzen.Visible = false;
            labelpsuNM.Visible = false;
            comboBoxpsuNM.Visible = false;
            labelpsuM.Visible = false;
            comboBoxpsuM.Visible = false;
            labelddr4.Visible = false;
            comboBoxddr4.Visible = false;
            labelSATA.Visible = false;
            comboBoxSATA.Visible = false;
            labelNVMe.Visible = false;
            comboBoxNVMe.Visible = false;
            labelaircooler.Visible = false;
            comboBoxaircooler.Visible = false;
            labelsystemfans.Visible = false;
            comboBoxsystemfans.Visible = false;
            listBox1.Visible = false;
            textBoxtotal.Visible = false;
            comboBoxpembayaran.Visible = false;
            labelpembayaran.Visible = false;
            buttonselesai.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void buttondatadiri_Click(object sender, EventArgs e)
        {
            labelselected1.Visible = true;
            labelselected2.Visible = false;
            labelselected3.Visible = false;
            labelselected4.Visible = false;
            labelselected5.Visible = false;
            labelselected6.Visible = false;
            labelselected7.Visible = false;
            labelselected8.Visible = false;
            labelselected9.Visible = false;
            labelselected10.Visible = false;
            //tampilkan button
            buttoncomputercases.Visible = false;
            buttonmothreborard.Visible = false;
            buttoncpu.Visible = false;
            buttongpu.Visible = false;
            buttonpsu.Visible = false;
            buttonmemori.Visible = false;
            buttonpenyimpanan.Visible = false;
            buttoncooling.Visible = false;
            buttonuser.Visible = true;
            //tampilkan
            labelnama.Visible = true;
            labelalamat.Visible = true;
            labelemail.Visible = true;
            labeltelepon.Visible = true;
            textBoxalamat.Visible = true;
            textBoxnama.Visible = true;
            textBoxemail.Visible = true;
            textBoxtelepon.Visible = true;
            labelmidtower.Visible = false;
            comboBoxMidtower.Visible = false;
            buttonsubmitdatadiri.Visible = true;
            labelatxfulltower.Visible = false;
            comboBoxatxfulltower.Visible = false;
            labelintel.Visible = false;
            comboBoxintel.Visible = false;
            labelamd.Visible = false;
            comboBoxamd.Visible = false;
            labelintelcpu.Visible = false;
            comboBoxintelcpu.Visible = false;
            labelamdcpu.Visible = false;
            comboBoxamdcpu.Visible = false;
            labelnvidia.Visible = false;
            comboBoxnvidia.Visible = false;
            labelryzen.Visible = false;
            comboBoxryzen.Visible = false;
            labelpsuNM.Visible = false;
            comboBoxpsuNM.Visible = false;
            labelpsuM.Visible = false;
            comboBoxpsuM.Visible = false;
            labelddr4.Visible = false;
            comboBoxddr4.Visible = false;
            labelSATA.Visible = false;
            comboBoxSATA.Visible = false;
            labelNVMe.Visible = false;
            comboBoxNVMe.Visible = false;
            labelaircooler.Visible = false;
            comboBoxaircooler.Visible = false;
            labelsystemfans.Visible = false;
            comboBoxsystemfans.Visible = false; 
            listBox1.Visible = false;
            textBoxtotal.Visible = false;
            comboBoxpembayaran.Visible = false;
            labelpembayaran.Visible = false;
            buttonselesai.Visible = false;
        }

        private void buttoncomputercase_Click(object sender, EventArgs e)
        {
            labelselected1.Visible = false;
            labelselected2.Visible = true;
            labelselected3.Visible = false;
            labelselected4.Visible = false;
            labelselected5.Visible = false;
            labelselected6.Visible = false;
            labelselected7.Visible = false;
            labelselected8.Visible = false;
            labelselected9.Visible = false;
            labelselected10.Visible = false;
            //tampilkan button
            buttoncomputercases.Visible = true;
            buttonmothreborard.Visible = false;
            buttoncpu.Visible = false;
            buttongpu.Visible = false;
            buttonpsu.Visible = false;
            buttonmemori.Visible = false;
            buttonpenyimpanan.Visible = false;
            buttoncooling.Visible = false;
            buttonuser.Visible = false;
            //tampilkan
            labelnama.Visible = false;
            labelalamat.Visible = false;
            labelemail.Visible = false;
            labeltelepon.Visible = false;
            textBoxalamat.Visible = false;
            textBoxnama.Visible = false;
            textBoxemail.Visible = false;
            textBoxtelepon.Visible = false;
            labelmidtower.Visible = true;
            comboBoxMidtower.Visible = true;
            buttonsubmitdatadiri.Visible = false;
            labelatxfulltower.Visible = true;
            comboBoxatxfulltower.Visible = true;
            labelintel.Visible = false;
            comboBoxintel.Visible = false;
            labelamd.Visible = false;
            comboBoxamd.Visible = false;
            labelintelcpu.Visible = false;
            comboBoxintelcpu.Visible = false;
            labelamdcpu.Visible = false;
            comboBoxamdcpu.Visible = false;
            labelnvidia.Visible = false;
            comboBoxnvidia.Visible = false;
            labelryzen.Visible = false;
            comboBoxryzen.Visible = false;
            labelpsuNM.Visible = false;
            comboBoxpsuNM.Visible = false;
            labelpsuM.Visible = false;
            comboBoxpsuM.Visible = false;
            labelddr4.Visible = false;
            comboBoxddr4.Visible = false;
            labelSATA.Visible = false;
            comboBoxSATA.Visible = false;
            labelNVMe.Visible = false;
            comboBoxNVMe.Visible = false;
            labelaircooler.Visible = false;
            comboBoxaircooler.Visible = false;
            labelsystemfans.Visible = false;
            comboBoxsystemfans.Visible = false;
            listBox1.Visible = false;
            textBoxtotal.Visible = false;
            comboBoxpembayaran.Visible = false;
            labelpembayaran.Visible = false;
            buttonselesai.Visible = false;

            comboBoxMidtower.SelectedItem = "";
            listBox1.Items.Remove(midtower);
            listBox1.Items.Remove(fulltower);
        }

        private void buttonmotherboards_Click(object sender, EventArgs e)
        {
            labelselected1.Visible = false;
            labelselected2.Visible = false;
            labelselected3.Visible = true;
            labelselected4.Visible = false;
            labelselected5.Visible = false;
            labelselected6.Visible = false;
            labelselected7.Visible = false;
            labelselected8.Visible = false;
            labelselected9.Visible = false;
            labelselected10.Visible = false;
            //tampilkan button
            buttoncomputercases.Visible = false;
            buttonmothreborard.Visible = true;
            buttoncpu.Visible = false;
            buttongpu.Visible = false;
            buttonpsu.Visible = false;
            buttonmemori.Visible = false;
            buttonpenyimpanan.Visible = false;
            buttoncooling.Visible = false;
            buttonuser.Visible = false;
            //tampilkan
            labelnama.Visible = false;
            labelalamat.Visible = false;
            labelemail.Visible = false;
            labeltelepon.Visible = false;
            textBoxalamat.Visible = false;
            textBoxnama.Visible = false;
            textBoxemail.Visible = false;
            textBoxtelepon.Visible = false;
            labelmidtower.Visible = false;
            comboBoxMidtower.Visible = false;
            buttonsubmitdatadiri.Visible = false;
            labelatxfulltower.Visible = false;
            comboBoxatxfulltower.Visible = false;
            labelintel.Visible = true;
            comboBoxintel.Visible = true;
            labelamd.Visible = true;
            comboBoxamd.Visible = true;
            labelintelcpu.Visible = false;
            comboBoxintelcpu.Visible = false;
            labelamdcpu.Visible = false;
            comboBoxamdcpu.Visible = false;
            labelnvidia.Visible = false;
            comboBoxnvidia.Visible = false;
            labelryzen.Visible = false;
            comboBoxryzen.Visible = false;
            labelpsuNM.Visible = false;
            comboBoxpsuNM.Visible = false;
            labelpsuM.Visible = false;
            comboBoxpsuM.Visible = false;
            labelddr4.Visible = false;
            comboBoxddr4.Visible = false;
            labelSATA.Visible = false;
            comboBoxSATA.Visible = false;
            labelNVMe.Visible = false;
            comboBoxNVMe.Visible = false;
            labelaircooler.Visible = false;
            comboBoxaircooler.Visible = false;
            labelsystemfans.Visible = false;
            comboBoxsystemfans.Visible = false;
            listBox1.Visible = false;
            textBoxtotal.Visible = false;
            comboBoxpembayaran.Visible = false;
            labelpembayaran.Visible = false;
            buttonselesai.Visible = false;
            comboBoxamd.SelectedItem = "";
            listBox1.Items.Remove(amd);
            listBox1.Items.Remove(intel);
        }

        private void buttonprocessors_Click(object sender, EventArgs e)
        {
            labelselected1.Visible = false;
            labelselected2.Visible = false;
            labelselected3.Visible = false;
            labelselected4.Visible = true;
            labelselected5.Visible = false;
            labelselected6.Visible = false;
            labelselected7.Visible = false;
            labelselected8.Visible = false;
            labelselected9.Visible = false;
            labelselected10.Visible = false;
            //tampilkan button
            buttoncomputercases.Visible = false;
            buttonmothreborard.Visible = false;
            buttoncpu.Visible = true;
            buttongpu.Visible = false;
            buttonpsu.Visible = false;
            buttonmemori.Visible = false;
            buttonpenyimpanan.Visible = false;
            buttoncooling.Visible = false;
            buttonuser.Visible = false;
            //tampilkan
            labelnama.Visible = false;
            labelalamat.Visible = false;
            labelemail.Visible = false;
            labeltelepon.Visible = false;
            textBoxalamat.Visible = false;
            textBoxnama.Visible = false;
            textBoxemail.Visible = false;
            textBoxtelepon.Visible = false;
            labelmidtower.Visible = false;
            comboBoxMidtower.Visible = false;
            buttonsubmitdatadiri.Visible = false;
            labelatxfulltower.Visible = false;
            comboBoxatxfulltower.Visible = false;
            labelintel.Visible = false;
            comboBoxintel.Visible = false;
            labelamd.Visible = false;
            comboBoxamd.Visible = false;
            labelintelcpu.Visible = true;
            comboBoxintelcpu.Visible = true;
            labelamdcpu.Visible = true;
            comboBoxamdcpu.Visible = true;
            labelnvidia.Visible = false;
            comboBoxnvidia.Visible = false;
            labelryzen.Visible = false;
            comboBoxryzen.Visible = false;
            labelpsuNM.Visible = false;
            comboBoxpsuNM.Visible = false;
            labelpsuM.Visible = false;
            comboBoxpsuM.Visible = false;
            labelddr4.Visible = false;
            comboBoxddr4.Visible = false;
            labelSATA.Visible = false;
            comboBoxSATA.Visible = false;
            labelNVMe.Visible = false;
            comboBoxNVMe.Visible = false;
            labelaircooler.Visible = false;
            comboBoxaircooler.Visible = false;
            labelsystemfans.Visible = false;
            comboBoxsystemfans.Visible = false;
            listBox1.Visible = false;
            textBoxtotal.Visible = false;
            comboBoxpembayaran.Visible = false;
            labelpembayaran.Visible = false;
            buttonselesai.Visible = false;
            comboBoxintelcpu.SelectedItem = "";
            listBox1.Items.Remove(intelcpu);
            listBox1.Items.Remove(amdcpu);
        }

        private void buttongraphiccards_Click(object sender, EventArgs e)
        {
            labelselected1.Visible = false;
            labelselected2.Visible = false;
            labelselected3.Visible = false;
            labelselected4.Visible = false;
            labelselected5.Visible = true;
            labelselected6.Visible = false;
            labelselected7.Visible = false;
            labelselected8.Visible = false;
            labelselected9.Visible = false;
            labelselected10.Visible = false;
            //tampilkan button
            buttoncomputercases.Visible = false;
            buttonmothreborard.Visible = false;
            buttoncpu.Visible = false;
            buttongpu.Visible = true;
            buttonpsu.Visible = false;
            buttonmemori.Visible = false;
            buttonpenyimpanan.Visible = false;
            buttoncooling.Visible = false;
            buttonuser.Visible = false;
            //tampilkan
            labelnama.Visible = false;
            labelalamat.Visible = false;
            labelemail.Visible = false;
            labeltelepon.Visible = false;
            textBoxalamat.Visible = false;
            textBoxnama.Visible = false;
            textBoxemail.Visible = false;
            textBoxtelepon.Visible = false;
            labelmidtower.Visible = false;
            comboBoxMidtower.Visible = false;
            buttonsubmitdatadiri.Visible = false;
            labelatxfulltower.Visible = false;
            comboBoxatxfulltower.Visible = false;
            labelintel.Visible = false;
            comboBoxintel.Visible = false;
            labelamd.Visible = false;
            comboBoxamd.Visible = false;
            labelintelcpu.Visible = false;
            comboBoxintelcpu.Visible = false;
            labelamdcpu.Visible = false;
            comboBoxamdcpu.Visible = false;
            labelnvidia.Visible = true;
            comboBoxnvidia.Visible = true;
            labelryzen.Visible = true;
            comboBoxryzen.Visible = true;
            labelpsuNM.Visible = false;
            comboBoxpsuNM.Visible = false;
            labelpsuM.Visible = false;
            comboBoxpsuM.Visible = false;
            labelddr4.Visible = false;
            comboBoxddr4.Visible = false;
            labelSATA.Visible = false;
            comboBoxSATA.Visible = false;
            labelNVMe.Visible = false;
            comboBoxNVMe.Visible = false;
            labelaircooler.Visible = false;
            comboBoxaircooler.Visible = false;
            labelsystemfans.Visible = false;
            comboBoxsystemfans.Visible = false;
            listBox1.Visible = false;
            textBoxtotal.Visible = false;
            comboBoxpembayaran.Visible = false;
            labelpembayaran.Visible = false;
            buttonselesai.Visible = false;
            comboBoxnvidia.SelectedItem = "";
            listBox1.Items.Remove(nvidia);
            listBox1.Items.Remove(ryzen);
        }

        private void buttonpowersupplies_Click(object sender, EventArgs e)
        {
            labelselected1.Visible = false;
            labelselected2.Visible = false;
            labelselected3.Visible = false;
            labelselected4.Visible = false;
            labelselected5.Visible = false;
            labelselected6.Visible = true;
            labelselected7.Visible = false;
            labelselected8.Visible = false;
            labelselected9.Visible = false;
            labelselected10.Visible = false;
            //tampilkan button
            buttoncomputercases.Visible = false;
            buttonmothreborard.Visible = false;
            buttoncpu.Visible = false;
            buttongpu.Visible = false;
            buttonpsu.Visible = true;
            buttonmemori.Visible = false;
            buttonpenyimpanan.Visible = false;
            buttoncooling.Visible = false;
            buttonuser.Visible = false;
            //tampilkan
            labelnama.Visible = false;
            labelalamat.Visible = false;
            labelemail.Visible = false;
            labeltelepon.Visible = false;
            textBoxalamat.Visible = false;
            textBoxnama.Visible = false;
            textBoxemail.Visible = false;
            textBoxtelepon.Visible = false;
            labelmidtower.Visible = false;
            comboBoxMidtower.Visible = false;
            buttonsubmitdatadiri.Visible = false;
            labelatxfulltower.Visible = false;
            comboBoxatxfulltower.Visible = false;
            labelintel.Visible = false;
            comboBoxintel.Visible = false;
            labelamd.Visible = false;
            comboBoxamd.Visible = false;
            labelintelcpu.Visible = false;
            comboBoxintelcpu.Visible = false;
            labelamdcpu.Visible = false;
            comboBoxamdcpu.Visible = false;
            labelnvidia.Visible = false;
            comboBoxnvidia.Visible = false;
            labelryzen.Visible = false;
            comboBoxryzen.Visible = false;
            labelpsuNM.Visible = true;
            comboBoxpsuNM.Visible = true;
            labelpsuM.Visible = true;
            comboBoxpsuM.Visible = true;
            labelddr4.Visible = false;
            comboBoxddr4.Visible = false;
            labelSATA.Visible = false;
            comboBoxSATA.Visible = false;
            labelNVMe.Visible = false;
            comboBoxNVMe.Visible = false;
            labelaircooler.Visible = false;
            comboBoxaircooler.Visible = false;
            labelsystemfans.Visible = false;
            comboBoxsystemfans.Visible = false;
            listBox1.Visible = false;
            textBoxtotal.Visible = false;
            comboBoxpembayaran.Visible = false;
            labelpembayaran.Visible = false;
            buttonselesai.Visible = false;
            comboBoxpsuNM.SelectedItem = "";
            listBox1.Items.Remove(psuNM);
            listBox1.Items.Remove(psuM);
        }

        private void buttonmemory_Click(object sender, EventArgs e)
        {
            labelselected1.Visible = false;
            labelselected2.Visible = false;
            labelselected3.Visible = false;
            labelselected4.Visible = false;
            labelselected5.Visible = false;
            labelselected6.Visible = false;
            labelselected7.Visible = true;
            labelselected8.Visible = false;
            labelselected9.Visible = false;
            labelselected10.Visible = false;
            //tampilkan button
            buttoncomputercases.Visible = false;
            buttonmothreborard.Visible = false;
            buttoncpu.Visible = false;
            buttongpu.Visible = false;
            buttonpsu.Visible = false;
            buttonmemori.Visible = true;
            buttonpenyimpanan.Visible = false;
            buttoncooling.Visible = false;
            buttonuser.Visible = false;
            //tampilkan
            labelnama.Visible = false;
            labelalamat.Visible = false;
            labelemail.Visible = false;
            labeltelepon.Visible = false;
            textBoxalamat.Visible = false;
            textBoxnama.Visible = false;
            textBoxemail.Visible = false;
            textBoxtelepon.Visible = false;
            labelmidtower.Visible = false;
            comboBoxMidtower.Visible = false;
            buttonsubmitdatadiri.Visible = false;
            labelatxfulltower.Visible = false;
            comboBoxatxfulltower.Visible = false;
            labelintel.Visible = false;
            comboBoxintel.Visible = false;
            labelamd.Visible = false;
            comboBoxamd.Visible = false;
            labelintelcpu.Visible = false;
            comboBoxintelcpu.Visible = false;
            labelamdcpu.Visible = false;
            comboBoxamdcpu.Visible = false;
            labelnvidia.Visible = false;
            comboBoxnvidia.Visible = false;
            labelryzen.Visible = false;
            comboBoxryzen.Visible = false;
            labelpsuNM.Visible = false;
            comboBoxpsuNM.Visible = false;
            labelpsuM.Visible = false;
            comboBoxpsuM.Visible = false;
            labelddr4.Visible = true;
            comboBoxddr4.Visible = true;
            labelSATA.Visible = false;
            comboBoxSATA.Visible = false;
            labelNVMe.Visible = false;
            comboBoxNVMe.Visible = false;
            labelaircooler.Visible = false;
            comboBoxaircooler.Visible = false;
            labelsystemfans.Visible = false;
            comboBoxsystemfans.Visible = false;
            listBox1.Visible = false;
            textBoxtotal.Visible = false;
            comboBoxpembayaran.Visible = false;
            labelpembayaran.Visible = false;
            buttonselesai.Visible = false;
            comboBoxddr4.SelectedItem = "";
            listBox1.Items.Remove(ddr4);
        }

        private void buttonstorage_Click(object sender, EventArgs e)
        {
            labelselected1.Visible = false;
            labelselected2.Visible = false;
            labelselected3.Visible = false;
            labelselected4.Visible = false;
            labelselected5.Visible = false;
            labelselected6.Visible = false;
            labelselected7.Visible = false;
            labelselected8.Visible = true;
            labelselected9.Visible = false;
            labelselected10.Visible = false;
            //tampilkan button
            buttoncomputercases.Visible = false;
            buttonmothreborard.Visible = false;
            buttoncpu.Visible = false;
            buttongpu.Visible = false;
            buttonpsu.Visible = false;
            buttonmemori.Visible = false;
            buttonpenyimpanan.Visible = true;
            buttoncooling.Visible = false;
            buttonuser.Visible = false;
            //tampilkan
            labelnama.Visible = false;
            labelalamat.Visible = false;
            labelemail.Visible = false;
            labeltelepon.Visible = false;
            textBoxalamat.Visible = false;
            textBoxnama.Visible = false;
            textBoxemail.Visible = false;
            textBoxtelepon.Visible = false;
            labelmidtower.Visible = false;
            comboBoxMidtower.Visible = false;
            buttonsubmitdatadiri.Visible = false;
            labelatxfulltower.Visible = false;
            comboBoxatxfulltower.Visible = false;
            labelintel.Visible = false;
            comboBoxintel.Visible = false;
            labelamd.Visible = false;
            comboBoxamd.Visible = false;
            labelintelcpu.Visible = false;
            comboBoxintelcpu.Visible = false;
            labelamdcpu.Visible = false;
            comboBoxamdcpu.Visible = false;
            labelnvidia.Visible = false;
            comboBoxnvidia.Visible = false;
            labelryzen.Visible = false;
            comboBoxryzen.Visible = false;
            labelpsuNM.Visible = false;
            comboBoxpsuNM.Visible = false;
            labelpsuM.Visible = false;
            comboBoxpsuM.Visible = false;
            labelddr4.Visible = false;
            comboBoxddr4.Visible = false;
            labelSATA.Visible = true;
            comboBoxSATA.Visible = true;
            labelNVMe.Visible = true;
            comboBoxNVMe.Visible = true;
            labelaircooler.Visible = false;
            comboBoxaircooler.Visible = false;
            labelsystemfans.Visible = false;
            comboBoxsystemfans.Visible = false;
            listBox1.Visible = false;
            textBoxtotal.Visible = false;
            comboBoxpembayaran.Visible = false;
            labelpembayaran.Visible = false;
            buttonselesai.Visible = false;
            comboBoxSATA.SelectedItem = "";
            listBox1.Items.Remove(SATA);
            listBox1.Items.Remove(NVMe);
        }

        private void buttoncoolling_Click(object sender, EventArgs e)
        {
            labelselected1.Visible = false;
            labelselected2.Visible = false;
            labelselected3.Visible = false;
            labelselected4.Visible = false;
            labelselected5.Visible = false;
            labelselected6.Visible = false;
            labelselected7.Visible = false;
            labelselected8.Visible = false;
            labelselected9.Visible = true;
            labelselected10.Visible = false;
            //tampilkan button
            buttoncomputercases.Visible = false;
            buttonmothreborard.Visible = false;
            buttoncpu.Visible = false;
            buttongpu.Visible = false;
            buttonpsu.Visible = false;
            buttonmemori.Visible = false;
            buttonpenyimpanan.Visible = false;
            buttoncooling.Visible = true;
            buttonuser.Visible = false;
            //tampilkan
            labelnama.Visible = false;
            labelalamat.Visible = false;
            labelemail.Visible = false;
            labeltelepon.Visible = false;
            textBoxalamat.Visible = false;
            textBoxnama.Visible = false;
            textBoxemail.Visible = false;
            textBoxtelepon.Visible = false;
            labelmidtower.Visible = false;
            comboBoxMidtower.Visible = false;
            buttonsubmitdatadiri.Visible = false;
            labelatxfulltower.Visible = false;
            comboBoxatxfulltower.Visible = false;
            labelintel.Visible = false;
            comboBoxintel.Visible = false;
            labelamd.Visible = false;
            comboBoxamd.Visible = false;
            labelintelcpu.Visible = false;
            comboBoxintelcpu.Visible = false;
            labelamdcpu.Visible = false;
            comboBoxamdcpu.Visible = false;
            labelnvidia.Visible = false;
            comboBoxnvidia.Visible = false;
            labelryzen.Visible = false;
            comboBoxryzen.Visible = false;
            labelpsuNM.Visible = false;
            comboBoxpsuNM.Visible = false;
            labelpsuM.Visible = false;
            comboBoxpsuM.Visible = false;
            labelddr4.Visible = false;
            comboBoxddr4.Visible = false;
            labelSATA.Visible = false;
            comboBoxSATA.Visible = false;
            labelNVMe.Visible = false;
            comboBoxNVMe.Visible = false;
            labelaircooler.Visible = true;
            comboBoxaircooler.Visible = true;
            labelsystemfans.Visible = true;
            comboBoxsystemfans.Visible = true;
            listBox1.Visible = false;
            textBoxtotal.Visible = false;
            comboBoxpembayaran.Visible = false;
            labelpembayaran.Visible = false;
            buttonselesai.Visible = false;
            comboBoxaircooler.SelectedItem = "";
            listBox1.Items.Remove(aircooler);
            listBox1.Items.Remove(systemfans);
        }
        int totalharga = 0;
        private void buttoncheckout_Click(object sender, EventArgs e)
        {
            int totalharga = hargamidtower + hargafulltower + hargaamd + hargaintel + hargaintelcpu + hargaamdcpu + harganvidia + hargaryzen + hargapsuNM + hargapsuM + hargaddr4 + hargaSATA + hargaNVMe + hargaaircooler + hargasystemfans;
            labelselected1.Visible = false;
            labelselected2.Visible = false;
            labelselected3.Visible = false;
            labelselected4.Visible = false;
            labelselected5.Visible = false;
            labelselected6.Visible = false;
            labelselected7.Visible = false;
            labelselected8.Visible = false;
            labelselected9.Visible = false;
            labelselected10.Visible = true;
            //tampilkan button
            buttoncomputercases.Visible = false;
            buttonmothreborard.Visible = false;
            buttoncpu.Visible = false;
            buttongpu.Visible = false;
            buttonpsu.Visible = false;
            buttonmemori.Visible = false;
            buttonpenyimpanan.Visible = false;
            buttoncooling.Visible = false;
            buttonuser.Visible = false;
            //tampilkan
            labelnama.Visible = false;
            labelalamat.Visible = false;
            labelemail.Visible = false;
            labeltelepon.Visible = false;
            textBoxalamat.Visible = false;
            textBoxnama.Visible = false;
            textBoxemail.Visible = false;
            textBoxtelepon.Visible = false;
            labelmidtower.Visible = false;
            comboBoxMidtower.Visible = false;
            buttonsubmitdatadiri.Visible = false;
            labelatxfulltower.Visible = false;
            comboBoxatxfulltower.Visible = false;
            labelintel.Visible = false;
            comboBoxintel.Visible = false;
            labelamd.Visible = false;
            comboBoxamd.Visible = false;
            labelintelcpu.Visible = false;
            comboBoxintelcpu.Visible = false;
            labelamdcpu.Visible = false;
            comboBoxamdcpu.Visible = false;
            labelnvidia.Visible = false;
            comboBoxnvidia.Visible = false;
            labelryzen.Visible = false;
            comboBoxryzen.Visible = false;
            labelpsuNM.Visible = false;
            comboBoxpsuNM.Visible = false;
            labelpsuM.Visible = false;
            comboBoxpsuM.Visible = false;
            labelddr4.Visible = false;
            comboBoxddr4.Visible = false;
            labelSATA.Visible = false;
            comboBoxSATA.Visible = false;
            labelNVMe.Visible = false;
            comboBoxNVMe.Visible = false;
            labelaircooler.Visible = false;
            comboBoxaircooler.Visible = false;
            labelsystemfans.Visible = false;
            comboBoxsystemfans.Visible = false;
            listBox1.Visible = true;
            textBoxtotal.Visible = false;
            comboBoxpembayaran.Visible = true;
            labelpembayaran.Visible = true;
            buttonselesai.Visible = true;

            if (midtower != "")
            {
                listBox1.Items.Add(midtower);
            }
            if (fulltower != "")
            {
                listBox1.Items.Add(fulltower);
            }
            if (amd != "")
            {
                listBox1.Items.Add(amd);
            }
            if (intel != "")
            {
                listBox1.Items.Add(intel);
            }
            if (intelcpu != "")
            {
                listBox1.Items.Add(intelcpu);
            }
            if (amdcpu != "")
            {
                listBox1.Items.Add(amdcpu);
            }
            if (nvidia != "")
            {
                listBox1.Items.Add(nvidia);
            }
            if (ryzen != "")
            {
                listBox1.Items.Add(ryzen);
            }
            if (psuNM != "")
            {
                listBox1.Items.Add(psuNM);
            }
            if (psuM != "")
            {
                listBox1.Items.Add(psuM);
            }
            if (ddr4 != "")
            {
                listBox1.Items.Add(ddr4);
            }
            if (SATA != "")
            {
                listBox1.Items.Add(SATA);
            }
            if (NVMe != "")
            {
                listBox1.Items.Add(NVMe);
            }
            if (aircooler != "")
            {
                listBox1.Items.Add(aircooler);
            }
            if (systemfans != "")
            {
                listBox1.Items.Add(systemfans);
            }
           
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panelmiddle_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonpsu_Click(object sender, EventArgs e)
        {

        }

        private void buttoncpu_Click(object sender, EventArgs e)
        {

        }

        private void buttoncooling_Click(object sender, EventArgs e)
        {

        }

        private void buttonmothreborards_Click(object sender, EventArgs e)
        {

        }

        private void buttonmemori_Click(object sender, EventArgs e)
        {

        }

        private void buttongpu_Click(object sender, EventArgs e)
        {

        }

        private void buttonpenyimpanan_Click(object sender, EventArgs e)
        {

        }

        private void buttoncomputercases_Click(object sender, EventArgs e)
        {

        }
        private void buttonsubmit1_Click(object sender, EventArgs e)
        {
            if (textBoxnama.Text == "")
            {  
                MessageBox.Show("Anda harus mengisinya terlebih dahulu");
            }
            else if (textBoxalamat.Text == "")
            {
                MessageBox.Show("Anda harus mengisinya terlebih dahulu");
            }
            else if (textBoxemail.Text == "")
            {
                MessageBox.Show("Anda harus mengisinya terlebih dahulu");
            }
            else if (textBoxtelepon.Text == "")
            {
                MessageBox.Show("Anda harus mengisinya terlebih dahulu");
            }
            else
            {
                MessageBox.Show("Data diri diterima!");
            }
            
        }
        string midtower = "";
        int hargamidtower = 0;
        private void comboBoxMidtower_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                if (comboBoxMidtower.SelectedItem == "Asus - ROG Strix Helios 		(Rp.4.250.000,- )")
                {
                hargamidtower = 4250000;
                midtower = "Asus - ROG Strix Helios 		(Rp.4.250.000,- )";
                MessageBox.Show("Tempered Glass Side Panel, Mid Tower, (ATX/micro ATX/Mini ITX/EATX), Black, 1 x USB 3.1 Gen 2 (Type-C), 4 x USB 3.1 Gen 1, Audio in / out");
                }
                else if (comboBoxMidtower.SelectedItem == "Asus - TUF Gaming GT501 Case 	(Rp.2.250.000,- )")
                {
                hargamidtower = 2250000;
                midtower = "Asus - TUF Gaming GT501 Case 	(Rp.2.250.000,- )";
                MessageBox.Show("Tempered Glass Side Panel, Mid Tower, (ATX/micro ATX/Mini ITX/EATX), Black / Grey, 2 x USB 3.1 Gen1, Audio in / out");
                }
                else if (comboBoxMidtower.SelectedItem == "Abkoncore - Tengri 650 		(Rp.1.850.000,- )")
                {
                hargamidtower = 1850000;
                midtower = "Abkoncore - Tengri 650(Rp.1.850.000, - )";
                MessageBox.Show("Tempered Glass Side Panel, Mid Tower, (Mini - ITX, Micro ATX, ATX), Black, (FAN Not Included), 2 x USB 3.0, 2 x USB 2.0, HD Audio &Mic, Window Side Panel");
                }
            else
            {
                midtower = "";
            }

        }

        private void buttonsubmitcomputercase_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        string fulltower = "";
        int hargafulltower = 0;
        private void comboBoxatxfulltower_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxatxfulltower.SelectedItem == "Abkoncore - Ramesses 760		( Rp.3.820.000,-)")
            {
                hargafulltower = 3820000;
                fulltower = "Abkoncore - Ramesses 760		( Rp.3.820.000,-)";
                MessageBox.Show("Tempered Glass Side Panel, Full Tower (Mini - ITX, Micro ATX, ATX, E - ATX), Black, 2 x USB 3.0, 2 x USB 2.0, HD Audio & Mic, Window Side Panel");
            }
            else if (comboBoxatxfulltower.SelectedItem == "Corsair - Obsidian 1000D 		(Rp.7.890.000,- )")
            {
                hargafulltower = 7890000;
                fulltower = "Corsair - Obsidian 1000D 		(Rp.7.890.000,- )";
                MessageBox.Show("Tempered Glass Side Panel, Full Tower, (Mini - ITX, Micro ATX, ATX, E ATX), Black, 4x USB 3.0, 1 x HD Audio, Window Side Panel");
            }
            else if (comboBoxatxfulltower.SelectedItem == "Cooler Master - COSMOS C700M 	(Rp.6.420.000,- )")
            {
                hargafulltower = 6420000;
                fulltower = "Cooler Master - COSMOS C700M 	(Rp.6.420.000,- )";
                MessageBox.Show("Tempered Glass Side Panel, Full Tower, (Mini - ITX, Micro ATX, ATX, E - ATX), 1 x USB 3.0 Type - C, 4 x USB 3.0, HD Audio & Mic, Window Side Panel");
            }
            else
            {
                fulltower = "";
            }
            
        }

        string amd = "";
        int hargaamd = 0;
        private void comboBoxamd_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxamd.SelectedItem == "ASRock - X399 Phantom Gaming 6 	(Rp.4.550.000,- )")
            {
                hargaamd = 4550000;
                amd = "ASRock - X399 Phantom Gaming 6 	(Rp.4.550.000,- )";
                MessageBox.Show("AMD X399, 8 x DDR4 up to 3400MHz (OC), Socket TR4 ATX Form Factor, Support for 4 - Way CrossFire and 4 - Way SLI");
            }
            else if (comboBoxamd.SelectedItem == "Asus - ROG Strix X399-E Gaming 	(Rp.5.500.000,- )")
            {
                hargaamd = 5500000;
                amd = "Asus - ROG Strix X399-E Gaming 	(Rp.5.500.000,- )";
                MessageBox.Show("AMD X399, 8 x DDR4 up to 3600MHz (OC), Socket TR4 E - ATX Form Factor, Support for CrossFire and SLI");
            }
            else if (comboBoxamd.SelectedItem == "Asus - Zenith Extreme Alpha 		(Rp.10.760.000,-)")
            {
                hargaamd = 10760000;
                amd = "Asus - Zenith Extreme Alpha 		(Rp.10.760.000,-)";
                MessageBox.Show("AMD X399, 8 x DDR4 up to 3600MHz (OC), Socket TR4 E - ATX Form Factor, Support for 3 - Way CrossFire and 3 - Way SLI");
            }
            else
            {
                amd = "";
            }
        }
        string intel = "";
        int hargaintel = 0;
        private void comboBoxintel_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBoxintel.SelectedItem == "ASRock - Fatal1ty X299 Gaming K6 	   	( Rp.4.270.000,- )")
            {
                hargaintel = 4270000;
                intel = "ASRock - Fatal1ty X299 Gaming K6 	   	( Rp.4.270.000,- )";
                MessageBox.Show("Intel X299, 8 x DDR4 up to 4400MHz (OC), Socket 2066 E - ATX Form Factor, Support for 3 - Way CrossFire and 3 - Way SLI");
            }
            else if (comboBoxintel.SelectedItem == "Asus - ROG Strix X299-E Gaming II 	   	( Rp.7.840.000,- )")
            {
                hargaintel = 7840000;
                intel = "Asus - ROG Strix X299-E Gaming II 	   	( Rp.7.840.000,- )";
                MessageBox.Show("Intel X299, 8 x DDR4 up to 4266MHz (OC), Socket 2066 ATX Form Factor, Support for CrossFire and SLI");
            }
            else if (comboBoxintel.SelectedItem == "Asus - ROG Rampage VI Extreme Encore	( Rp.13.845.000,- )")
            {
                hargaintel = 13845000;
                intel = "Asus - ROG Rampage VI Extreme Encore	( Rp.13.845.000,- )";
                MessageBox.Show("Intel X299, 8 x DDR4 up to 4266MHz (OC), Socket 2066 E - ATX Form Factor, Support CrossFire and SLI");
            }
            else
            {
                intel = "";
            }
        }
        string intelcpu = "";
        int hargaintelcpu = 0;
        private void comboBoxintelcpu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxintelcpu.SelectedItem == "Intel - Core I9 10920X 	( Rp.12.370.000,-)")
            {
                hargaintelcpu = 12370000;
                intelcpu = "Intel - Core I9 10920X 	( Rp.12.370.000,-)";
                MessageBox.Show("Intel Core i9 X-Series, Clock / Turbo: 3.50 GHz / 4.80 GHz, 31.25MB Total Cache 12 Core / 24 Threads, Cascade Lake - X, 165W, LGA2066");
            }
            else if (comboBoxintelcpu.SelectedItem == "Intel - Core I9 10940X 	( Rp.14.120.000,-)")
            {
                hargaintelcpu = 14120000;
                intelcpu = "Intel - Core I9 10940X 	( Rp.14.120.000,-)";
                MessageBox.Show("Intel Core i9 X-Series, Clock / Turbo: 3.30 GHz / 4.80 GHz, 33.25MB Total Cache 14 Core / 28 Threads, Cascade Lake - X, 165W, LGA2066");
            }
            else if (comboBoxintelcpu.SelectedItem == "Intel - Core I9 10980XE 	( Rp.20.930.000,-)")
            {
                hargaintelcpu = 20930000;
                intelcpu = "Intel - Core I9 10980XE 	( Rp.20.930.000,-)";
                MessageBox.Show("Intel Core i9 X-Series, Clock / Turbo: 3.00 GHz / 4.80 GHz, 42.75MB Total Cache 18 Core / 36 Threads, Cascade Lake - X, 165W, LGA2066");
            }
            else
            {
                intelcpu = "";
            }
        }
        string amdcpu = "";
        int hargaamdcpu = 0;
        private void comboBoxamdcpu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxamdcpu.SelectedItem == "AMD - Ryzen 5 3600X 	( Rp.4.430.000,-)")
            {
                hargaamdcpu = 4430000;
                amdcpu = "AMD - Ryzen 5 3600X 	( Rp.4.430.000,-)";
                MessageBox.Show("AMD Ryzen 5, Clock / Turbo: 3.8GHz / 4.4GHz, 35MB Total Cache Hexa Core, Matisse, 95W, AM4");
            }
            else if (comboBoxamdcpu.SelectedItem == "AMD - Ryzen 7 3800X 	( Rp.7.115.000,-)")
            {
                hargaamdcpu = 7115000;
                amdcpu = "AMD - Ryzen 7 3800X 	( Rp.7.115.000,-)";
                MessageBox.Show("AMD Ryzen 7, Clock / Turbo: 3.9GHz / 4.5GHz, 36MB Total Cache Octa Core, Matisse, 105W, AM4");
            }
            else if (comboBoxamdcpu.SelectedItem == "AMD - Ryzen 9 3950X	(Rp.13.765.000,-)")
            {
                hargaamdcpu = 13765000;
                amdcpu = "AMD - Ryzen 9 3950X	(Rp.13.765.000,-)";
                MessageBox.Show("AMD Ryzen 9, Clock / Turbo: 3.5GHz / 4.7GHz, 72MB Total Cache Hexadeca(16) Core, Matisse, 105W, AM4");
            }
            else
            {
                amdcpu = "";
            }
        }

        private void labelintelcpu_Click(object sender, EventArgs e)
        {

        }
        string nvidia = "";
        int harganvidia = 0;
        private void comboBoxnvidia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxnvidia.SelectedItem == "GeForce GTX 1070TI	 (Rp.6.030.000,-)")
            {
                harganvidia = 6030000;
                nvidia = "GeForce GTX 1070TI	 (Rp.6.030.000,-)";
                MessageBox.Show("NVIDIA GeForce GTX 1070 Ti, Base / Boost Clock: 1607MHz / 1683MHz Memory Clock: 8Gbps, 8GB GDDR5 256 - bit, Power Connector: 8 - Pin");
            }
            else if (comboBoxnvidia.SelectedItem == "GeForce GTX 1660TI	 (Rp.7.010.000,-)")
            {
                harganvidia = 7010000;
                nvidia = "GeForce GTX 1660TI	 (Rp.7.010.000,-)";
                MessageBox.Show("NVIDIA GeForce GTX 1660 Ti, Boost Clock: 1860 MHz Memory Clock: 12 Gbps, 6GB GDDR6 192 - bit, Power Connector: 8 - Pin Minimum System Power Requirement 450W");
            }
            else if (comboBoxnvidia.SelectedItem == "GeForce RTX 2080TI 	(Rp.27.825.000,-)")
            {
                harganvidia = 27825000;
                nvidia = "GeForce RTX 2080TI 	(Rp.27.825.000,-)";
                MessageBox.Show("NVIDIA GeForce RTX 2080 Ti, Base / Boost Clock: 1350MHz / 1665MHz Memory Clock: 14Gbps, 11GB GDDR6X 352 - bit, Power Connector: 8 - Pin x2");
            }
            else
            {
                nvidia = "";
            }
        }
        string ryzen = "";
        int hargaryzen = 0;
        private void comboBoxryzen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxryzen.SelectedItem == "RX 5500XT	(Rp.4.540.000,-)")
            {
                hargaryzen = 4540000;
                ryzen = "RX 5500XT	(Rp.4.540.000,-)";
                MessageBox.Show("AMD Radeon RX 5500 XT, Boost Clock: 1845MHz Memory Clock: 14Gbps, 8GB GDDR6 128 - bit, Power Connector: 8 - Pin");
            }
            else if (comboBoxryzen.SelectedItem == "RX 5600XT	(Rp.5.750.000,-)")
            {
                hargaryzen = 5750000;
                ryzen = "RX 5600XT	(Rp.5.750.000,-)";
                MessageBox.Show("AMD Radeon RX 5600 XT, Boost Clock: 1750MHz Memory Clock: 12Gbps, 6GB GDDR6 192 - bit, Power Connector: 8 - Pin x2");
            }
            else if (comboBoxnvidia.SelectedItem == "RX 5700XT	(Rp.7.940.000,-)")
            {
                hargaryzen = 7940000;
                ryzen = "RX 5700XT	(Rp.7.940.000,-)";
                MessageBox.Show("AMD Radeon RX 5700 XT, Boost Clock: 2025MHz Memory Clock: 14Gbps, 8GB GDDR6 256 - bit, Power Connector: 8 - Pin x 2");
            }
            else
            {
                ryzen = "";
            }
        }
        string psuNM = "";
        int hargapsuNM = 0;
        private void comboBoxpsuNM_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxpsuNM.SelectedItem == "be quiet! - System Power U9 600W  		(Rp.920.000,-) 	")
            {
                hargapsuNM = 920000;
                psuNM = "be quiet! - System Power U9 600W  		(Rp.920.000,-) 	";
                MessageBox.Show("System Power U9, 100-240 VAC Input, 12CM Fan ATX, Non Modular, 600W, 80 Plus Bronze");
            }
            else if (comboBoxpsuNM.SelectedItem == "Corsair - CX650 				(Rp.995.000,-) ")
            {
                hargapsuNM = 995000;
                psuNM = "Corsair - CX650 				(Rp.995.000,-) ";
                MessageBox.Show("CX, 200-240 VAC Input, 12CM Fan ATX, Non Modular, 650W, 80 Plus Bronze");
            }
            else if (comboBoxpsuNM.SelectedItem == "Cooler Master - MWE 750 White 230V - V2   	(Rp.1.020.000,-) ")
            {
                hargapsuNM = 1020000;
                psuNM = "Cooler Master - MWE 750 White 230V - V2   	(Rp.1.020.000,-) ";
                MessageBox.Show("MWE White, 200-240 Vac AC Input, 12CM Fan ATX, Non Modular, 750W, 80 Plus");
            }
            else
            {
                psuNM = "";
            }
        }
        string psuM = "";
        int hargapsuM = 0;
        private void comboBoxpsuM_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxpsuM.SelectedItem == "be quiet! - Dark Power Pro 11 750W 	(Rp.2.480.000,-)")
            {
                hargapsuM = 2480000;
                psuM = "be quiet! - Dark Power Pro 11 750W 	(Rp.2.480.000,-)";
                MessageBox.Show("Dark Power Pro 11, 100-240 VAC Input, 13.5CM Fan ATX, Semi Modular, 750W, 80 Plus Platinum");
            }
            else if (comboBoxpsuM.SelectedItem == "Asus - ROG-THOR-850P 		(Rp.3.800.000,-)")
            {
                hargapsuM = 3800000;
                psuM = "Asus - ROG-THOR-850P 		(Rp.3.800.000,-)";
                MessageBox.Show("ROG Thor, 100-240 VAC Input ATX, Fully Modular, 850W, 80 Plus Platinum");
            }
            else if (comboBoxpsuM.SelectedItem == "CoolerMaster-MasterWatt Maker 1500 (Rp.7.499.000,-)")
            {
                hargapsuM = 7499000;
                psuM = "CoolerMaster-MasterWatt Maker 1500 (Rp.7.499.000,-)";
                MessageBox.Show("MasterWatt Maker, 100-240 VAC Input, 13.5CM Fan ATX, Fully Modular, 1500W, 80 Plus Titanium");
            }
            else
            {
                psuM = "";
            }
        }
        string ddr4 = "";
        int hargaddr4 = 0;
        private void comboBoxddr4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxddr4.SelectedItem == "Corsair - CMK4GX4M1A2400C16 	(Rp.505.000,-)")
            {
                hargaddr4 = 505000;
                ddr4 = "Corsair - CMK4GX4M1A2400C16 	(Rp.505.000,-)";
                MessageBox.Show("Vengeane LPX, 4GB DDR4 2400MHz (PC4-19200), 16-16-16-39, 1.2V");
            }
            else if (comboBoxddr4.SelectedItem == "Corsair - CMK8GX4M1A2400C16 	(Rp.790.000,-)")
            {
                hargaddr4 = 790000;
                ddr4 = "Corsair - CMK8GX4M1A2400C16 	(Rp.790.000,-)";
                MessageBox.Show("Vengeane LPX, 8GB DDR4 2400MHz (PC4-19200), 16-16-16-39, 1.2V");
            }
            else if (comboBoxddr4.SelectedItem == "Corsair - CMK16GX4M1A2666C16 	(Rp.1.480.000,- )")
            {
                hargaddr4 = 1480000;
                ddr4 = "Corsair - CMK16GX4M1A2666C16 	(Rp.1.480.000,- )";
                MessageBox.Show("Vengeane LPX, 16GB DDR4 2666MHz (PC4-21300 ), 16-18-18-35, 1.2V");
            }
            else if (comboBoxddr4.SelectedItem == "Corsair - CMK32GX4M1A2666C16	(Rp.3.025.000,-)")
            {
                hargaddr4 = 3025000;
                ddr4 = "Corsair - CMK32GX4M1A2666C16	(Rp.3.025.000,-)";
                MessageBox.Show("Vengeane LPX, 32GB DDR4 2666MHz (PC4-21300 ), 16-18-18-35, 1.2V");
            }
            else
            {
                ddr4 = "";
            }
        }
        string SATA = "";
        int hargaSATA = 0;
        private void comboBoxSATA_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSATA.SelectedItem == "Western Digital - Blue 3D NAND SATA SSD 250GB	(Rp.774.000,-)")
            {
                hargaSATA = 774000;
                SATA = "Western Digital - Blue 3D NAND SATA SSD 250GB	(Rp.774.000,-)";
                MessageBox.Show("Blue SSD Series, 2.5”, 250GB, SATA III Controller: -, Memory: 3D TLC NAND");
            }
            else if (comboBoxSATA.SelectedItem == "Samsung - SSD 860 Pro 512GB			(Rp.2.580.000,-)")
            {
                hargaSATA = 2580000;
                SATA = "Samsung - SSD 860 Pro 512GB			(Rp.2.580.000,-)";
                MessageBox.Show("860 Pro, 2.5 Inch, 512GB, SATA III Controller: Samsung MJX Controller");
            }
            else if (comboBoxSATA.SelectedItem == "Western Digital - Blue 3D NAND SATA SSD 1TB 		( Rp.2.105.000,-)")
            {
                hargaSATA = 2105000;
                SATA = "Western Digital - Blue 3D NAND SATA SSD 1TB 		( Rp.2.105.000,-)";
                MessageBox.Show("Blue SSD Series, 2.5”, 1TB, SATA III Controller: -, Memory: 3D TLC NAND");
            }
            else
            {
                SATA = "";
            }
            
        }
        string NVMe = "";
        int hargaNVMe = 0;
        private void comboBoxNVMe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxNVMe.SelectedItem == "Corsair - CSSD-F500GBMP600	(Rp.3.295.000,-)")
            {
                hargaNVMe = 3295000;
                NVMe = "Corsair - CSSD-F500GBMP600	(Rp.3.295.000,-)";
                MessageBox.Show("MP600, M.2 2280, 500GB, PCIe 4.0 x4 Controller: Phison PS5016 - E16, Memory: 3D TLC NAND");
            }
            else if (comboBoxNVMe.SelectedItem == "Corsair - CSSD-F1000GBMP600	(Rp.4.420.000,-)")
            {
                hargaNVMe = 4420000;
                NVMe = "Corsair - CSSD-F1000GBMP600	(Rp.4.420.000,-)";
                MessageBox.Show("MP600, M.2 2280, 1TB, PCIe 4.0 x4 Controller: Phison PS5016 - E16, Memory: 3D TLC NAND");
            }
            else if (comboBoxNVMe.SelectedItem == "Team - TM8FP7002T0C311		(Rp.6.750.000,-)")
            {
                hargaNVMe = 6750000;
                NVMe = "Team - TM8FP7002T0C311		(Rp.6.750.000,-)";
                MessageBox.Show("Cardea Zero Z440, M.2 2280, 2TB, PCIe Gen4 x4 with NVMe 1.3 Controller: Phison PS5016 - E16, Memory: 3D TLC NAND");
            }
            else
            {
                NVMe = "";
            }
        }
        string aircooler = "";
        int hargaaircooler = 0;
        private void comboBoxaircooler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxaircooler.SelectedItem == "AeroCool - Cylon 4			( Rp.350.000,-)")
            {
                hargaaircooler = 350000;
                aircooler = "AeroCool - Cylon 4			( Rp.350.000,-)";
                MessageBox.Show("CPU Cooler Height 155mm Intel: LGA 2066 / 2011 / 115X / 775 socket AMD: AM4 / AM3 + / AM3 / AM2 + / AM2 / FM2 + / FM2 / FM1 socket");
            }
            else if (comboBoxaircooler.SelectedItem == "be quiet! - Shadow Rock LP		( Rp.650.000,-) ")
            {
                hargaaircooler = 650000;
                aircooler = "be quiet! - Shadow Rock LP		( Rp.650.000,-) ";
                MessageBox.Show("CPU Cooler Height 50.4mm / 75.4mm with Fan Intel: 775 / 115X / 1366 / LGA2011 AMD: AM2(+) / AM3(+) / FM1 / FM2(+)");
            }
            else if (comboBoxaircooler.SelectedItem == "Cooler Master - MasterAir MA410M	(Rp.827.000,-) ")
            {
                hargaaircooler = 827000;
                aircooler = "Cooler Master - MasterAir MA410M	(Rp.827.000,-) ";
                MessageBox.Show("Intel LGA 2011-3, 2011, LGA,1156, LGA,1155, LGA,1151, LGA,1150, LGA,775 AMD® AM4 / AM3 + / AM3 / AM2 + / FM2 + / FM2 / FM1 2 x 120MM Fan Included");
            }
            else
            {
                aircooler = "";
            }
        }
        string systemfans = "";
        int hargasystemfans = 0;
        private void comboBoxsystemfans_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxsystemfans.SelectedItem == "Phanteks - PH-F200SP			(Rp.215.000,-)")
            {
                hargasystemfans = 215000;
                systemfans = "Phanteks - PH-F200SP			(Rp.215.000,-)";
                MessageBox.Show("200 x 200 x 30mm, 800 ± 250 rpm, 110.1 CFM, 3-Pin");
            }
            else if (comboBoxsystemfans.SelectedItem == "Cooler Master - MasterFan MF200R RGB	(Rp.378.000,-)")
            {
                hargasystemfans = 378000;
                systemfans = "Cooler Master - MasterFan MF200R RGB	(Rp.378.000,-)";
                MessageBox.Show("200 x 200 x 25 mm, up to 800 RPM, up to 90.10 CFM RGB LED, 3 Pin Connector");
            }
            else
            {
                systemfans = "";
            }
        }
        
        private void textBoxtotal_TextChanged(object sender, EventArgs e)
        {
            textBoxtotal.Text = Convert.ToString(totalharga);
        }

        private void comboBoxpembayaran_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxpembayaran.SelectedItem == "Bayar Ditempat")
            {
                MessageBox.Show("Pesanan anda akan segera dirakit dan dikirim ke alamat anda dalam 2-3 hari kerja");
            }
            else if (comboBoxpembayaran.SelectedItem == "ATM")
            {
                MessageBox.Show("Kami akan mengirimkan No rekening melalui email anda");
            }
            else if (comboBoxpembayaran.SelectedItem == "Virtual Account/M-Banking")
            {
                MessageBox.Show("Kami akan mengirimkan nomor virtual melalui email anda");
            }
        }

        private void buttonselesai_Click(object sender, EventArgs e)
        {
            {
                MessageBox.Show("Terima kasih telah mempercayai kami sebagai partner komputer anda");

            }
        }
    }
}
