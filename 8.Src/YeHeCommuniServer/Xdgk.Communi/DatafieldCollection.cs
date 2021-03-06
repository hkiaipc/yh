///////////////////////////////////////////////////////////
//  DatafieldCollection.cs
//  Implementation of the Class DatafieldCollection
//  Generated by Enterprise Architect
//  Created on:      08-七月-2009 11:35:55
//  Original author: LiZhL
///////////////////////////////////////////////////////////



using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Xdgk.Communi
{
    //public class MyCollection<T> : Collection<T>
    //{
    //    /// <summary>
    //    /// 
    //    /// </summary>
    //    /// <param name="item"></param>
    //    public new void Add(T item)
    //    {
    //        this.CheckNullOrExist(item);
    //        base.Add(item);
    //    }

    //    /// <summary>
    //    /// 
    //    /// </summary>
    //    /// <param name="index"></param>
    //    /// <param name="item"></param>
    //    public new void Insert( int index, T item )
    //    {
    //        this.CheckNullOrExist(item);
    //        base.Insert(index, item);
    //    }

    //    /// <summary>
    //    /// 
    //    /// </summary>
    //    /// <param name="item"></param>
    //    private void CheckNullOrExist(T item)
    //    {
    //        if (item == null)
    //            throw new ArgumentNullException("item");

    //        if (this.Contains(item))
    //            throw new ArgumentException("exist item: " + item );
    //    }
    //}

    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    public class DataFieldCollection : Xdgk.Common.Collection<DataField>
    {
        /// <summary>
        /// 获取Bytes的长度
        /// </summary>
        public int BytesLength
        {
            get 
            {
                if (this.Count == 0)
                    return 0;

                DataField df = this[this.Count - 1];
                return df.BeginPosition + df.DataLength;
            }
        }

        //// Exist df.Name
        ////
        //public new void Add(DataField df)
        //{
        //    if (this.Contains(df.Name))
        //        throw new ArgumentException("exist dataField: " + df.Name);
        //    base.Add(df);
        //}

        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        /// <param name="item"></param>
        protected override void InsertItem(int index, DataField item)
        {
            if( this.Contains( item.Name ) )
                throw new ArgumentException("exist dataField: " + item.Name);
            base.InsertItem(index, item);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dfName"></param>
        /// <returns></returns>
        public bool Contains(string dfName)
        {
            dfName = dfName.Trim();
            foreach (DataField df in this)
            {
                if (string.Compare(df.Name, dfName, true) == 0)
                    return true;
            }
            return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns></returns>
        public bool Check(byte[] bytes)
        {
            // 1. check length
            // 2. crc if exist
            // 3.
            //
            // get dfs max length and check bytes.length >= max length
            //

            // crc
            //
            return false;
        }

        #region 
        /// <summary>
        /// 
        /// </summary>
        public DataField CRCDataField
        {
            get
            {
                foreach (DataField df in this)
                {
                    if (df.IsCRC)
                        return df;
                }
                return null;
            }
        }        
        #endregion //


        //#region
        ///// <summary>
        ///// 检查bytes是否满足DataFields的最大长度需要
        ///// </summary>
        ///// <param name="bytes"></param>
        ///// <returns></returns>
        //public bool CheckLength(byte[] bytes)
        //{
        //    int dfsMaxLength = GetDfsLength();
        //    if (bytes.Length < dfsMaxLength)
        //        return false;
        //    return true;
        //}
        //#endregion //


        /// <summary>
        /// 获取此DataFieldCollection的bytes的长度
        /// </summary>
        public int Length
        {
            get { return this.GetDfsLength(); }
        }


        #region GetDfsLength
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private int GetDfsLength()
        {
            int max = 0;
            int temp = 0;
            foreach (DataField df in this)
            {
                temp = df.BeginPosition + df.DataLength;
                if (temp > max)
                    max = temp;
            }
            return max;
        }
        #endregion //GetDfsLength

    }//end DatafieldCollection
}