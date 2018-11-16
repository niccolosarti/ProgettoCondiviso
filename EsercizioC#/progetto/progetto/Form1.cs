﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace progetto
{
    public partial class Form1 : Form
    {
        List<int> numeri = new List<int>();
        FileStream fileStream = new FileStream(
            "numeri.txt", FileMode.OpenOrCreate,
            FileAccess.ReadWrite, FileShare.None);

        public Form1()
        {
            InitializeComponent();
        }

        private void add()
        {
            numeri.Add(Convert.ToInt32(txtB.Text));
        }


        public void SalvaSuFile(List<int> numeri)
        {
            byte[] bdata = null;
            String str = String.Empty;

            foreach (int i in numeri)
            {
                str = str + i.ToString() + ',';
            }

            bdata = Encoding.ASCII.GetBytes(str);

            fileStream.Write(bdata, 0, bdata.Length);
        }

        public List<int> CaricaDaFile()
        {
            List<int> numeri = new List<int>();
            String fileContent;
            using (StreamReader reader = new StreamReader(fileStream))
            {
                fileContent = reader.ReadToEnd();
                string[] str = fileContent.Split(',');

                for(int i = 0; i < str.Length; i++)
                {
                    numeri.Add(Convert.ToInt32(i));
                }
            }
            return numeri;
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCarica_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void list_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}