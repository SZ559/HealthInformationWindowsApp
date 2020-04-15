﻿using System.Windows.Forms;

namespace WindowsApp
{
    public class DataGridViewSetting
    { 
        public static void InitializeColumnHeader(DataGridView datagridview)
        {
            datagridview.Columns[0].HeaderCell.Value = "Gin Number";
            datagridview.Columns[1].HeaderCell.Value = "Name";
            datagridview.Columns[2].HeaderCell.Value = "Visit Hubei Recently";
            datagridview.Columns[3].HeaderCell.Value = "Has Abnormal Symptom";
            datagridview.Columns[4].HeaderCell.Value = "Body Temperature";
        }
    }
}