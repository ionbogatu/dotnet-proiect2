using System;
using System.IO;
using System.Net.Mail;
using System.Windows.Forms;

namespace GUI
{
    partial class MyPhotos
    {
        private void emailButton_Click(object sender, EventArgs e)
        {
            Form prompt = new Form()
            {
                Width = 500,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = "Trimite rezultatul prin email",
                StartPosition = FormStartPosition.CenterScreen
            };
            Label textLabel = new Label() { Left = 50, Top = 20, Text = "Adresa de email al destinatarului" };
            TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 400 };
            Button confirmation = new Button() { Text = "Trimite", Left = 350, Width = 100, Top = 70, DialogResult = DialogResult.OK };
            confirmation.Click += (object sender1, EventArgs e1) =>
            {
                confirmation.Enabled = false;
                SendEmail(textBox.Text);
                prompt.Close();
            };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;

            prompt.ShowDialog();
        }

        private void SendEmail(string receiverEmail)
        {
            try
            {
                try
                {
                    new MailAddress(receiverEmail);
                }
                catch (ArgumentException)
                {
                    throw new Exception("Adresa de email nu este valida");
                }
                catch (FormatException)
                {
                    throw new Exception("Adresa de email nu este valida");
                }

                DateTime dateTime = DateTime.Now;
                string tmpFile = Path.GetTempPath() + Path.DirectorySeparatorChar + "Result " + dateTime.Year + "-" + (dateTime.Month < 10 ? "0" + dateTime.Month : dateTime.Month.ToString()) + "-" + (dateTime.Day < 10 ? "0" + dateTime.Day : dateTime.Day.ToString()) + "_" + (dateTime.Hour < 10 ? "0" + dateTime.Hour : dateTime.Hour.ToString()) + "-" + (dateTime.Minute < 10 ? "0" + dateTime.Minute : dateTime.Minute.ToString()) + "-" + (dateTime.Second < 10 ? "0" + dateTime.Second : dateTime.Second.ToString()) + ".txt";

                using (StreamWriter sw = new StreamWriter(tmpFile))
                {
                    sw.WriteLine(ResourcesToStringTable());
                }

                if (File.Exists(tmpFile))
                {
                    MailMessage mail = new MailMessage();
                    SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                    mail.From = new MailAddress("ionbogatu@gmail.com");
                    mail.To.Add(receiverEmail);
                    mail.Subject = "Fisierele mele";
                    mail.Body = "Salut,\nAm atasat fisierul cu rezultatele cautarii tale.";
                    mail.Attachments.Add(new Attachment(tmpFile));

                    SmtpServer.Port = 587;
                    SmtpServer.Credentials = new System.Net.NetworkCredential("ionbogatu", "secret");
                    SmtpServer.EnableSsl = true;

                    SmtpServer.Send(mail);
                    MessageBox.Show("Mesajul a fost trimis cu succes!");
                }
                else
                {
                    throw new Exception("Mesajul nu a putut fi trimis");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
