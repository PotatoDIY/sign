using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sign
{
    public partial class Sign : Form
    {
        public Sign()
        {
            InitializeComponent();
        }

        private void buttonSign_Click(object sender, EventArgs e)
        {
            textBoxSignText.Text = sign(textBoxText.Text);
        }

        public string sign(string str)
        {
            //根据需要加签时的哈希算法转化成对应的hash字符节
            byte[] bt = Encoding.GetEncoding("utf-8").GetBytes(str);
            var sha256 = new SHA256CryptoServiceProvider();
            byte[] rgbHash = sha256.ComputeHash(bt);
            RSACryptoServiceProvider key = new RSACryptoServiceProvider();
            using (StreamReader streamReader = new StreamReader("PrivateKey.xml")) // 读取运行目录下的PrivateKey.xml
            {
                key.FromXmlString(streamReader.ReadToEnd());// 将私匙载入进RSA实例中
            }
            RSAPKCS1SignatureFormatter formatter = new RSAPKCS1SignatureFormatter(key);
            formatter.SetHashAlgorithm("SHA256");//此处是你需要加签的hash算法，需要和上边你计算的hash值的算法一致，不然会报错。
            byte[] inArray = formatter.CreateSignature(rgbHash);
            return Convert.ToBase64String(inArray);
        }
    }
}
