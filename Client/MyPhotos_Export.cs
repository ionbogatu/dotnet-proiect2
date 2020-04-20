using Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    partial class MyPhotos
    {
        private void saveSearchResultButton_Click(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;

            Stream fs;
            SaveFileDialog dialog = new SaveFileDialog();

            dialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            dialog.FilterIndex = 2;
            dialog.RestoreDirectory = true;
            dialog.FileName = "Result " + dateTime.Year + "-" + (dateTime.Month < 10 ? "0" + dateTime.Month : dateTime.Month.ToString()) + "-" + (dateTime.Day < 10 ? "0" + dateTime.Day : dateTime.Day.ToString()) + "_" + (dateTime.Hour < 10 ? "0" + dateTime.Hour : dateTime.Hour.ToString()) + "-" + (dateTime.Minute < 10 ? "0" + dateTime.Minute : dateTime.Minute.ToString()) + "-" + (dateTime.Second < 10 ? "0" + dateTime.Second : dateTime.Second.ToString()) + ".txt";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if ((fs = dialog.OpenFile()) != null)
                {
                    byte[] data = new UTF8Encoding(true).GetBytes(ResourcesToStringTable());
                    fs.Write(data, 0, data.Length);

                    fs.Close();
                    fs.Dispose();
                }
            }
        }

        private string ResourcesToStringTable()
        {
            string[] headers = new string[] { "#", "Nume", "Cale", "Descriere", "Data Crearii", "Proprietati" };
            string[][] rows = new string[resources.Count][];

            for (var i = 0; i < resources.Count; i++)
            {
                List<string> row = new List<string>();

                row.Add((i + 1).ToString());
                row.Add(resources[i].name);
                row.Add(resources[i].fullpath);
                row.Add(resources[i].description);
                row.Add(resources[i].created_at.ToString().Split(" ".ToCharArray()[0])[0]);

                var resource_attributes = resources[i].resource_eav.ToList<resource_eav>();

                string properties = "[";

                for (var j = 0; j < resource_attributes.Count(); j++)
                {
                    resource_attributes attribute = resource_attributes.ElementAt(j).resource_attributes;
                    resource_attribute_values value = resource_attributes.ElementAt(j).resource_attribute_values;

                    properties += "{" + attribute.attribute + ":" + value.value + "}";

                    if (j < resource_attributes.Count() - 1)
                    {
                        properties += ", ";
                    }
                }

                properties += "]";
                row.Add(properties);

                rows[i] = row.ToArray();
            }

            return new TableToString(
                headers,
                rows
            ).GetResult();
        }
    }
}
