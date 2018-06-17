using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace smsApi
{
    public partial class Form1 : Form
    {
        public string api_key, gateway;
        public Form1()
        {
            InitializeComponent();
        }

        private void get_init_paramters()
        {
            if (apitxt.Text == "" || gatewaytxt.Text == "")
            {
                MessageBox.Show("api key and gateway cant be null");
            }
            api_key = apitxt.Text;
            gateway = gatewaytxt.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            get_init_paramters();
            WebClient webClient = new WebClient();
            string url = "https://api.sabanovin.com/v1/" + api_key + "/account/balance.json";
            string result = webClient.DownloadString(url);
            resulttxt.Text = result;
            JObject obj = JObject.Parse(result);
            resTxt.Text = obj["entry"]["balance"].ToString();
            statusCodeTxt.Text = obj["status"]["code"].ToString();
            // Fix UTF-8 Encoding
            string message = obj["status"]["message"].ToString();
            byte[] bytes = Encoding.Default.GetBytes(message);
            message = Encoding.UTF8.GetString(bytes);
            messageTxt.Text = message;
        }

        private void send_single_or_group_sms_btn_Click(object sender, EventArgs e)
        {
            get_init_paramters();
            string url = "https://api.sabanovin.com/v1/" + api_key + "/sms/send.json?gateway=" + 
                gateway + "&to=" + single_group_numbers_txt.Text + "&text=" + single_group_sms_txt.Text;
            WebClient webClient = new WebClient();
            string result = webClient.DownloadString(url);
            resulttxt.Text = result;
            JObject obj = JObject.Parse(result);
            resTxt.Text = "reference_id = " + obj["entries"][0]["reference_id"].ToString();
            statusCodeTxt.Text = obj["status"]["code"].ToString();
            // Fix UTF-8 Encoding
            string message = obj["status"]["message"].ToString();
            byte[] bytes = Encoding.Default.GetBytes(message);
            message = Encoding.UTF8.GetString(bytes);
            messageTxt.Text = message;
        }

        private void get_smses_btn_Click(object sender, EventArgs e)
        {
            get_init_paramters();
            string url = "";
            if (from_date_get_sms_txt.Text != "")
            {
                if (to_date_get_sms_txt.Text != "")
                {
                    url = "https://api.sabanovin.com/v1/" + api_key + "/sms/receive.json?gateway=" + gateway + "&is_read=0&from_date="+
                        from_date_get_sms_txt.Text+"&to_date=" + to_date_get_sms_txt.Text;
                }
                else
                {
                    url = "https://api.sabanovin.com/v1/" + api_key + "/sms/receive.json?gateway=" + gateway + "&is_read=0&from_date=" +
                                            from_date_get_sms_txt.Text;
                }
            }
            else
            {
                url = "https://api.sabanovin.com/v1/" + api_key + "/sms/receive.json?gateway=" + gateway + "&is_read=0";
            }
            System.Console.WriteLine(url);
            WebClient webClient = new WebClient();
            string result = webClient.DownloadString(url);
            resulttxt.Text = result;
            JObject obj = JObject.Parse(result);
            if (obj["entries"].Count() != 0) 
            {
                resTxt.Text = "reference_id = " + obj["entries"][0]["reference_id"].ToString();
            }
            statusCodeTxt.Text = obj["status"]["code"].ToString();
            // Fix UTF-8 Encoding
            string message = obj["status"]["message"].ToString();
            byte[] bytes = Encoding.Default.GetBytes(message);
            message = Encoding.UTF8.GetString(bytes);
            messageTxt.Text = message;
        }

        private void add_to_phonebook_btn_Click(object sender, EventArgs e)
        {
            get_init_paramters();
            string url = "https://api.sabanovin.com/v1/" + api_key + "/utils/add_contact.json?group_id=" + group_id.Text + "&number=" + number_add_to_phone_txt.Text;
            WebClient webClient = new WebClient();
            string result = webClient.DownloadString(url);
            resulttxt.Text = result;
            JObject obj = JObject.Parse(result);
            statusCodeTxt.Text = obj["status"]["code"].ToString();
            // Fix UTF-8 Encoding
            string message = obj["status"]["message"].ToString();
            byte[] bytes = Encoding.Default.GetBytes(message);
            message = Encoding.UTF8.GetString(bytes);
            messageTxt.Text = message;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void send_pair_pair_sms_Click(object sender, EventArgs e)
        {
            get_init_paramters();
            string[] numbers;
            numbers = numbers_pair_txt.Text.Split(',');
            string[] textes;
            textes = smes_pair_txt.Text.Split(',');
            if (textes.Count() != numbers.Count())
            {
                MessageBox.Show("number and textes are not equal");
            }
            var paramters = new { gateway = gateway, to = numbers, text = textes};
            using (var client = new WebClient())
            {
                var dataString = JsonConvert.SerializeObject(paramters);
                client.Headers.Add(HttpRequestHeader.ContentType, "application/json");
                string result = client.UploadString(new Uri("https://api.sabanovin.com/v1/"+api_key+"/sms/send_array.json"), "POST", dataString);
                resulttxt.Text = result;
                JObject obj = JObject.Parse(result);
                if (obj["entries"].Count() != 0)
                {
                    resTxt.Text = "reference_id = " + obj["entries"][0]["reference_id"].ToString();
                }
                statusCodeTxt.Text = obj["status"]["code"].ToString();
                // Fix UTF-8 Encoding
                string message = obj["status"]["message"].ToString();
                byte[] bytes = Encoding.Default.GetBytes(message);
                message = Encoding.UTF8.GetString(bytes);
                messageTxt.Text = message;
            }
        }
    }
}
