using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;
using System.Data.SqlClient;

namespace metal_archives
{


    public partial class metalarchives : Form
    {
        string url;
        public List<string> bandInfo;
 
        public metalarchives()
        {
            InitializeComponent();
            bandInfo = new List<string>();
        }

        private List<string> getInfo()
        {
            try
            {
                url = urlBox.Text;

            HtmlWeb web = new HtmlWeb();
            var doc = web.Load(url);
            HtmlNode nameNode = doc.DocumentNode.SelectSingleNode("//*[@id=\"band_info\"]/h1/a");
            HtmlNode genreNode = doc.DocumentNode.SelectSingleNode("//*[@id=\"band_stats\"]/dl[2]/dd[1]");
            HtmlNode countryNode = doc.DocumentNode.SelectSingleNode("//*[@id=\"band_stats\"]/dl[1]/dd[1]/a");
            HtmlNode yearNode = doc.DocumentNode.SelectSingleNode("//*[@id=\"band_stats\"]/dl[1]/dd[4]");
            HtmlNode logoNode = doc.DocumentNode.SelectSingleNode("//*[@id=\"logo\"]");
            HtmlNode photoNode = doc.DocumentNode.SelectSingleNode("//*[@id=\"photo\"]");

            
                bandInfo.Clear();
                bandInfo.Add(nameNode.InnerHtml);
                bandInfo.Add(genreNode.InnerHtml);
                bandInfo.Add(countryNode.InnerHtml);
                bandInfo.Add(yearNode.InnerHtml);
                bandInfo.Add(logoNode.InnerHtml);
                bandInfo.Add(photoNode.InnerHtml);
            } catch (Exception)
            {
                MessageBox.Show("Zly format strony");
            }
            
            return bandInfo;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                bandInfo.Clear();
                bandInfo = getInfo();
                nameLabel.Text = bandInfo[0];
                genreLabel.Text = bandInfo[1];
                originLabel.Text = bandInfo[2];
                yearLabel.Text = bandInfo[3];

                int i = bandInfo[4].IndexOf('?');
                bandInfo[4] = bandInfo[4].Remove(i, bandInfo[4].Length - i);
                bandInfo[4] = bandInfo[4].Substring(10, bandInfo[4].Length - 10);


                i = bandInfo[5].IndexOf('?');
                bandInfo[5] = bandInfo[5].Remove(i, bandInfo[5].Length - i);
                bandInfo[5] = bandInfo[5].Substring(10, bandInfo[5].Length - 10);

                logoBox.LoadAsync(bandInfo[4]);
                photoBox.LoadAsync(bandInfo[5]);
            } catch (Exception)
            {
                MessageBox.Show("Zly format strony");
            }
            
            
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_metal_archivesDataSet1.FavBands' table. You can move, or remove it, as needed.
            this.favBandsTableAdapter.Fill(this._metal_archivesDataSet1.FavBands);

        }
        

        private void okBtn_click(object sender, EventArgs e)
        {
            DbManagment myDb = new DbManagment();
            myDb.insertToTable(nameLabel.Text, genreLabel.Text, originLabel.Text, yearLabel.Text, bandInfo[4], bandInfo[5]);
            dataGridView1.DataSource = myDb.displayData();

        }

        private void delete_Btn(object sender, EventArgs e)
        {
            DbManagment myDb = new DbManagment();
            myDb.delete(Convert.ToInt32(idToDelete.Value));
            dataGridView1.DataSource = myDb.displayData();
        }

        private void update_Btn(object sender, EventArgs e)
        {
            DbManagment myDb = new DbManagment();
            myDb.update(Convert.ToInt32(idToUpdate.Value), newGenreTb.Text);
            dataGridView1.DataSource = myDb.displayData();
        }

        private void show_Btn(object sender, EventArgs e)
        {
            DbManagment myDb = new DbManagment();
            bandInfo.Clear();
            bandInfo = myDb.showBand(Convert.ToInt32(idToLoad.Value));
            try {
                nameLabel.Text = bandInfo[0];
                genreLabel.Text = bandInfo[1];
                originLabel.Text = bandInfo[2];
                yearLabel.Text = bandInfo[3];
                logoBox.LoadAsync(bandInfo[4]);
                photoBox.LoadAsync(bandInfo[5]);
            } catch (Exception)
            {
                MessageBox.Show("Nie znaleziono zespolu o podanym ID");
            }

        }
    }
}
