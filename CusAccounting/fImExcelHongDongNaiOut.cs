using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using CDTControl;
using CDTDatabase;
using CDTLib;
namespace CusAccounting
{
    public partial class fImExcelHongDongNaiOut : DevExpress.XtraEditors.XtraForm
    {
        public fImExcelHongDongNaiOut()
        {
            InitializeComponent();

            MapStruct = new DataTable();

            MapStruct.Columns.Add("FieldName", typeof(string));
            MapStruct.Columns.Add("Type", typeof(int));
            MapStruct.Columns.Add("ColName", typeof(string));
            MapStruct.Columns.Add("DefaultValue", typeof(string));
            MapStruct.Columns.Add("AllowNull", typeof(bool));

            DataRow dr0 = MapStruct.NewRow();
            dr0["FieldName"] = "NgayHD";
            dr0["ColName"] = "NgayHD";
            dr0["Type"] = 9;
            dr0["DefaultValue"] = DBNull.Value;
            dr0["AllowNull"] = 0;
            MapStruct.Rows.Add(dr0);

            DataRow dr = MapStruct.NewRow();
            dr["FieldName"] = "SoHoaDon";
            dr["ColName"] = "SoHoaDon";
            dr["Type"] = 2;
            dr["DefaultValue"] = DBNull.Value;
            dr["AllowNull"] = 0;
            MapStruct.Rows.Add(dr);

            DataRow dr1 = MapStruct.NewRow();
            dr1["FieldName"] = "Soseri";
            dr1["ColName"] = "Soseri";
            dr1["Type"] = 2;
            dr1["DefaultValue"] = DBNull.Value;
            dr1["AllowNull"] = 0;
            MapStruct.Rows.Add(dr1);
            DataRow dr2 = MapStruct.NewRow();
            dr2["FieldName"] = "TTienVon";
            dr2["ColName"] = "TTienVon";
            dr2["Type"] = 8;
            dr2["DefaultValue"] = 0;
            dr2["AllowNull"] = 0;
            MapStruct.Rows.Add(dr2);
            
            gridControl1.DataSource = MapStruct;
            gridControl1.DataMember = MapStruct.TableName;
        }
        public DataTable dbEx = null;
        ImportExcel IEx;
        public DataTable MapStruct;
        Database _db = Database.NewDataDatabase();
        Database _dbStruct = Database.NewStructDatabase();        

        DateTime ngayct=DateTime.Now;

        string classname = "";
        private void fImExcel_Load(object sender, EventArgs e)
        {
        
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "AllExel|*.xls;*.xlsx";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                tFileName.EditValue = dialog.FileName;
                IEx = new ImportExcel(dialog.FileName);
                List<string> sheets = IEx.GetSheets();
                lSheet.Properties.Items.Clear();
                lSheet.Properties.Items.AddRange(sheets.ToArray());
            }

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            string sql;
            if (IEx != null && IEx.Db != null)
            {
                dbEx = IEx.Db;
                ImportDetailFromExcel(dbEx, MapStruct);
                //this.Dispose();
            }
            else
            {
                MessageBox.Show("Không nhận được dữ liệu");
            }
            
            
            
        }

        private void ImportDetailFromExcel(DataTable dataTable, DataTable MapStruct)
        {
            //Insert  dữ liệu vào file tmp
            //Chạy proc 
            string str = "select * from datatype";
            DataTable tbtype = _dbStruct.GetDataTable(str);
            //_db.UpdateByNonQuery(str);
            _db.HasErrors = false;
            foreach (DataRow drdata in dataTable.Rows)
            {
               
                string sql = "Update MT32 set TTienVon=" + drdata["TTienVon"].ToString() + " where NgayHD='" + drdata["NgayHD"].ToString() +
                "' and SoHoaDon='" + drdata["SoHoaDon"].ToString() + "' and Soseri='" + drdata["Soseri"].ToString() + "'";
                _db.UpdateByNonQuery(sql);

                sql= "select MT32ID from MT32 where NgayHD='" + drdata["NgayHD"].ToString() +
                "' and SoHoaDon='" + drdata["SoHoaDon"].ToString() + "' and Soseri='" + drdata["Soseri"].ToString() + "'";
                object o = _db.GetValue(sql);
                if(o!=null  && o.ToString().Trim() != string.Empty)
                {
                    sql = "update bltk set PsNo = " + drdata["TTienVon"].ToString() + ",PsNoNT = " + drdata["TTienVon"].ToString() + " where MTID='" + o.ToString() + "' and NhomDK='HDB3'";
                    _db.UpdateByNonQuery(sql);
                    sql = "update bltk set PsCo = " + drdata["TTienVon"].ToString() + ",PsCoNT = " + drdata["TTienVon"].ToString() + " where MTID='" + o.ToString() + "' and NhomDK='HDB4'";
                    _db.UpdateByNonQuery(sql);
                }
                if (_db.HasErrors) break;
            }
            if(!_db.HasErrors) MessageBox.Show("Update dữ liệu thành công!");
        }
        

        private void lSheet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lSheet.EditValue == null) return;
            List<string> cols= IEx.GetCol(lSheet.EditValue.ToString());
            if (cols == null) return;
            RiCom.Items.Clear();
            RiCom.Items.AddRange(cols.ToArray());
             classname = lSheet.EditValue.ToString();
        }
        DataTable dmField;


        private void tFileName_EditValueChanged(object sender, EventArgs e)
        {

        }
        SaveFileDialog f;
       

        


    }
}