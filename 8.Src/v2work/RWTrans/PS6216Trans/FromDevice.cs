
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Data ;
using System.Data.SqlClient;


namespace PS6216DataImporter
{
    public class FromDevice : DeviceBase
    {
        private int _totalHeight = 0;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="totalHeight"></param>
        public FromDevice(int totalHeight)
        {
            _totalHeight = totalHeight;           
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param deviceType="formDateTime"></param>
        /// <returns></returns>
        public DataTable ReadDataTable(DateTime fromDateTime)
        {
            DataTable tbl = ((FromDBI)DBI).ReadNewDataTable(fromDateTime);
            tbl.Columns.Add("wl", typeof(float));
            foreach (DataRow row in tbl.Rows)
            {
                float wl = Convert.ToSingle(row["水位"]);
                wl = _totalHeight - wl;
                row["wl"] = wl;
            }
            return tbl;
        }

        new private string Name
        {
            get { return base.Name; }
            set { base.Name = value; }
        }

        new private int ID
        {
            get { return base.ID; }
            set { base.ID = value; }
        }
    }

}
