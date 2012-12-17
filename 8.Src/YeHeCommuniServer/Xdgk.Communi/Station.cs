using System;
using System.Diagnostics;
using System.Runtime.Serialization;
using Xdgk.Common;
using System.Collections.Specialized;
using System.Collections;
using System.Threading ;

namespace Xdgk.Communi
{

    /// <summary>
    /// վ��
    /// </summary>
    public class Station : ObjectBase
    {

        #region Events
        /// <summary>
        /// ��CommuniPort���Ըı�ʱ�򴥷����¼�
        /// </summary>
        public event EventHandler CommuniPortChanged;
        #endregion //Events

        #region Members

        private DeviceCollection m_DeviceCollection;
        private CommuniType m_CommuniType;
        //private CommuniTypeOption m_CommuniTypeOption = CommuniTypeOption.GprsCommuni;
        private string _name = null;
        private string m_Description = null;

        #endregion

        #region Constructors


        #region Station
        /// <summary>
        /// 
        /// </summary>
        /// <param name="stationName"></param>
        /// <param name="description"></param>
        public Station(string stationName, CommuniType communiType )
        {
            _name = stationName;
            //m_Description = description;

            if (communiType == null)
                throw new ArgumentNullException("communiType");
            this.m_CommuniType = communiType;
        }
        #endregion //Station


        #region Station
        /// <summary>
        /// 
        /// </summary>
        /// <param name="stationName"></param>
        /// <param name="description"></param>
        public Station(string stationName, string description, DeviceCollection deviceCollection, CommuniType communiType)
            : this(stationName, communiType)
        {
            if (deviceCollection == null)
                throw new ArgumentNullException("deviceCollection");
            m_DeviceCollection = deviceCollection;
            m_DeviceCollection.Station = this;

            m_CommuniType = communiType;
        }
        #endregion //Station

        #endregion

        #region Properties


        #region Devices
        /// <summary>
        /// ��ȡ�������豸����
        /// </summary>
        public DeviceCollection Devices
        {
            get
            {
                if (m_DeviceCollection == null)
                    m_DeviceCollection = new DeviceCollection(this);
                return m_DeviceCollection;
            }
            set
            {
                if (m_DeviceCollection != value)
                {
                    if (m_DeviceCollection != null)
                        m_DeviceCollection.Station = null;

                    m_DeviceCollection = value;
                    if (m_DeviceCollection != null)
                        m_DeviceCollection.Station = this;
                }
            }
        }
        #endregion //Devices

        #region CommuniType
        /// <summary>
        /// ��ȡ������ͨѶ��ʽ����
        /// </summary>
        public CommuniType CommuniType
        {
            get
            {
                return this.m_CommuniType;
            }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("CommuniType");
                m_CommuniType = value;
            }
        }
        #endregion //CommuniType


        #region Name
        /// <summary>
        /// ��ȡ������վ�����Ƽ���
        /// վ�����Ʋ���Ϊ�գ���β�����ո����ִ�Сд
        /// ͬһ�������Ʋ�����ͬ
        /// </summary>
        public string Name
        {
            get { return _name; }
            set
            {
                //SetStationName(value);
                if (value == null || value.Trim().Length == 0)
                {
                    throw new System.ArgumentException("Station Name Exception!");
                }

                this._name = value.Trim();
            }
        }
        #endregion //Name

        #region Description
        /// <summary>
        /// ��ȡ������վ�㱸ע����
        /// վ�㱸ע����Ϊ��
        /// </summary>
        public string Description
        {
            get
            {
                if (m_Description == null)
                    m_Description = string.Empty;
                return m_Description;
            }
            set { m_Description = value; }
        }
        #endregion //Description


        #region DictionaryTag
        /// <summary>
        /// 
        /// </summary>
        public HybridDictionary DictionaryTag
        {
            get
            {
                if (_hybridDictionaryTag == null)
                    _hybridDictionaryTag = new HybridDictionary(true);
                return _hybridDictionaryTag;
            }
        } private HybridDictionary _hybridDictionaryTag;
        #endregion //DictionaryTag

        #region CommuniPort
        /// <summary>
        /// ��ȡ�����ø�Station��ص�CommuniPort
        /// </summary>
        public CommuniPort CommuniPort
        {
            get { return _communiPort; }
            set
            {
                if (_communiPort != value)
                {
                    _communiPort = value;
                    //OnCommuniPortChanged();
                    if (CommuniSoft.IsUseUISynchronizationContext)
                    {
                        CommuniSoft.UISynchronizationContext.Post(
                            this.CommuniPortChangedCallback, null);
                    }
                    else
                    {
                        this.OnCommuniPortChanged();
                    }
                }
            }
        }private CommuniPort _communiPort;
        #endregion //CommuniPort



        #region CommuniPortChangedCallback
        /// <summary>
        /// 
        /// </summary>
        private SendOrPostCallback CommuniPortChangedCallback
        {
            get
            {
                return new SendOrPostCallback(CommuniPortChangedCallbackTarget);
            }
        }
        #endregion //CommuniPortChangedCallback


        #region CommuniPortChangedCallbackTarget
        /// <summary>
        /// 
        /// </summary>
        /// <param name="state"></param>
        private void CommuniPortChangedCallbackTarget( object state )
        {
            OnCommuniPortChanged();
        }
        #endregion //CommuniPortChangedCallbackTarget


        #region OnCommuniPortChanged
        /// <summary>
        /// 
        /// </summary>
        private void OnCommuniPortChanged()
        {
            if (this.CommuniPortChanged != null)
            {
                EventHandler temp = this.CommuniPortChanged;
                temp(this, EventArgs.Empty);
            }
        } 
        #endregion //OnCommuniPortChanged
        
        #endregion


        #region ID
        /// <summary>
        /// ��ȡ�����ô����ö���������е�ID
        /// </summary>
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        } private int _id;
        #endregion //ID


        #region StationCollection
        /// <summary>
        /// ��ȡ�������ڸ�վ����ص�վ�㼯��
        /// </summary>
        public StationCollection StationCollection
        {
            get { return _stationCollection; }
            set { _stationCollection = value; }
        } private StationCollection _stationCollection;
        #endregion //StationCollection
    }
}
