using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Utils;
using System.Collections;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
                private DataTable CreateTable(int RowCount)
        {
            DataTable tbl = new DataTable();
            tbl.Columns.Add("Name", typeof(string));
            tbl.Columns.Add("ID", typeof(int));
            tbl.Columns.Add("Number", typeof(int));
            tbl.Columns.Add("Date", typeof(DateTime));
            for (int i = 0; i < RowCount; i++)
                tbl.Rows.Add(new object[] { String.Format("Name{0}", i), i, 3 - i, DateTime.Now.AddDays(i) });
            return tbl;
        }
        
        public Form1()
        {
            InitializeComponent();
            dataGridView1.DataSource = CreateTable(20);
            dataNavigator1.DataSource = dataGridView1.DataSource;
        }
    }

    public class DataNavigatorButtonCaptionHelper : Component
    {

        private DataNavigator _SelectedNavigator;
        public DataNavigator SelectedNavigator
        {
            get { return _SelectedNavigator; }
            set { BeforeSelectedNavigatorChanged(value); _SelectedNavigator = value; AfterSelectedNavigatorChanged(); }
        }
        
        public ImageList _imageList;

        void BeforeSelectedNavigatorChanged(DataNavigator newNavigator)
        {
            if (_SelectedNavigator != null)
            {
                _SelectedNavigator.Buttons.ImageList = null;
            }
            if (newNavigator != null)
            {
                newNavigator.Buttons.ImageList = _imageList;
            }
        }


        private void TraverseCollection(ICollection collection)
        {
            NavigatorButtonCollectionBase col1 = collection as NavigatorButtonCollectionBase;
            NavigatorCustomButtons col2 = collection as NavigatorCustomButtons;
            for (int i = 0; i < collection.Count; i++)
            {
                NavigatorButtonBase button = null;
                if (col1 != null) button = col1[i];
                else button = col2[i];
                if (button.Tag == null) continue;
                _imageList.Images.Add(GetBitmap(button.Tag));
                button.ImageIndex = _imageList.Images.Count - 1;
            }
        }
        private void AfterSelectedNavigatorChanged()
        {
            if (SelectedNavigator == null) return;
            TraverseCollection(SelectedNavigator.Buttons.ButtonCollection);
            TraverseCollection(SelectedNavigator.Buttons.CustomButtons);
        }



        Bitmap GetBitmap(object text)
        {
            Bitmap image = new Bitmap(_imageList.ImageSize.Width, _imageList.ImageSize.Height);
            Graphics g = Graphics.FromImage(image);
            Rectangle rect = new Rectangle(new Point(0, 0), image.Size);
            g.FillRectangle(Brushes.White, rect);
            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;
            g.DrawString(text.ToString(), AppearanceObject.DefaultFont, Brushes.Black, rect, sf);
            image.MakeTransparent();
            return image;
        }

             

        public DataNavigatorButtonCaptionHelper()
        {
            _imageList = new ImageList();
            _imageList.ImageSize = new Size(70, 20);
        }
    }
}