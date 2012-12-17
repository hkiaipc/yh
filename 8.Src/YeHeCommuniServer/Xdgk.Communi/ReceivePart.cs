using System;
namespace Xdgk.Communi
{

    /// <summary>
    /// ������豸���ص����ݵĶ����Լ���ش���
    /// </summary>
    public class ReceivePart
    {
        #region Constructor
        /// <summary>
        /// 
        /// </summary>
        public ReceivePart(int length)
        {
            if (length < 0)
                throw new ArgumentOutOfRangeException("length",length, "must >= 0 ");
            this.DataFieldManager.Length = length;
        }
        #endregion //

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="length"></param>
        public ReceivePart(string name, int length)
            : this( length )
        {
            this.Name = name;
        }

        /// <summary>
        /// 
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        } private string _name = string.Empty;


        #region DatafieldManager
        /// <summary>
        /// 
        /// </summary>
        public DatafieldManager DataFieldManager
        {
            get
            {
                if (this._DatafieldManager == null)
                    this._DatafieldManager = new DatafieldManager();
                return this._DatafieldManager ;
            }
        } private DatafieldManager _DatafieldManager;
        #endregion //

        #region ToValues
        /// <summary>
        /// ����DataFieldManager�Ķ��壬��bytesת��Ϊ��Ӧ��ֵ
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns></returns>
        public ParseResult ToValues(byte[] bytes)
        {
            if (bytes == null)
            {
                //    return new LengthErrorResult(this.Name, this.DataFieldManager.Length, 0);
                bytes = new byte[0];
            }

            if (bytes.Length < this.DataFieldManager.Length)
                return new LengthErrorResult(this.Name, this.DataFieldManager.Length, bytes.Length);

            return this.DataFieldManager.ToValues(this.Name, bytes);
        }
        #endregion //ToValues

        #region Add
        /// <summary>
        /// 
        /// </summary>
        /// <param name="df"></param>
        public void Add(DataField df)
        {
            if (!df.IsBytesVolatile)
            {
                throw new ArgumentException("dataField.IsBytesVolatile must be true");
            }
            this.DataFieldManager.DataFields.Add(df);
        }
        #endregion //Add

        #region Remove
        public void Remove(DataField df)
        {
            this.DataFieldManager.DataFields.Remove(df);
        }
        #endregion //Remove
    }
}
