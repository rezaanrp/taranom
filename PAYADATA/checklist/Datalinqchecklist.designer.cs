﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PAYADATA.checklist
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="payazobnet")]
	public partial class DatalinqchecklistDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertmchecklistheader(mchecklistheader instance);
    partial void Updatemchecklistheader(mchecklistheader instance);
    partial void Deletemchecklistheader(mchecklistheader instance);
    partial void Insertmchecklistdetail(mchecklistdetail instance);
    partial void Updatemchecklistdetail(mchecklistdetail instance);
    partial void Deletemchecklistdetail(mchecklistdetail instance);
    partial void Insertmchecklistcontroler(mchecklistcontroler instance);
    partial void Updatemchecklistcontroler(mchecklistcontroler instance);
    partial void Deletemchecklistcontroler(mchecklistcontroler instance);
    partial void Insertmchecklistitem(mchecklistitem instance);
    partial void Updatemchecklistitem(mchecklistitem instance);
    partial void Deletemchecklistitem(mchecklistitem instance);
    partial void Insertmchecklistgroupcontroler(mchecklistgroupcontroler instance);
    partial void Updatemchecklistgroupcontroler(mchecklistgroupcontroler instance);
    partial void Deletemchecklistgroupcontroler(mchecklistgroupcontroler instance);
    partial void Insertmchecklistitemcatgroy(mchecklistitemcatgroy instance);
    partial void Updatemchecklistitemcatgroy(mchecklistitemcatgroy instance);
    partial void Deletemchecklistitemcatgroy(mchecklistitemcatgroy instance);
    #endregion
		
		public DatalinqchecklistDataContext() : 
				base(global::PAYADATA.Properties.Settings.Default.payazobnetConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DatalinqchecklistDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DatalinqchecklistDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DatalinqchecklistDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DatalinqchecklistDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<mchecklistheader> mchecklistheaders
		{
			get
			{
				return this.GetTable<mchecklistheader>();
			}
		}
		
		public System.Data.Linq.Table<mchecklistdetail> mchecklistdetails
		{
			get
			{
				return this.GetTable<mchecklistdetail>();
			}
		}
		
		public System.Data.Linq.Table<mchecklistcontroler> mchecklistcontrolers
		{
			get
			{
				return this.GetTable<mchecklistcontroler>();
			}
		}
		
		public System.Data.Linq.Table<mchecklistitem> mchecklistitems
		{
			get
			{
				return this.GetTable<mchecklistitem>();
			}
		}
		
		public System.Data.Linq.Table<mchecklistgroupcontroler> mchecklistgroupcontrolers
		{
			get
			{
				return this.GetTable<mchecklistgroupcontroler>();
			}
		}
		
		public System.Data.Linq.Table<mchecklistitemcatgroy> mchecklistitemcatgroys
		{
			get
			{
				return this.GetTable<mchecklistitemcatgroy>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.mchecklistheader")]
	public partial class mchecklistheader : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _xid;
		
		private string _xdate;
		
		private string _xtime;
		
		private string _xdevicecod;
		
		private string _xdevicenumber;
		
		private string _xnote;
		
		private System.Nullable<int> _xidusersupervisor;
		
		private System.Nullable<bool> _xconfirmsupervisor;
		
		private System.Nullable<int> _xidusernetsupervisor;
		
		private System.Nullable<bool> _xconfirmnetsupervisor;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnxidChanging(int value);
    partial void OnxidChanged();
    partial void OnxdateChanging(string value);
    partial void OnxdateChanged();
    partial void OnxtimeChanging(string value);
    partial void OnxtimeChanged();
    partial void OnxdevicecodChanging(string value);
    partial void OnxdevicecodChanged();
    partial void OnxdevicenumberChanging(string value);
    partial void OnxdevicenumberChanged();
    partial void OnxnoteChanging(string value);
    partial void OnxnoteChanged();
    partial void OnxidusersupervisorChanging(System.Nullable<int> value);
    partial void OnxidusersupervisorChanged();
    partial void OnxconfirmsupervisorChanging(System.Nullable<bool> value);
    partial void OnxconfirmsupervisorChanged();
    partial void OnxidusernetsupervisorChanging(System.Nullable<int> value);
    partial void OnxidusernetsupervisorChanged();
    partial void OnxconfirmnetsupervisorChanging(System.Nullable<bool> value);
    partial void OnxconfirmnetsupervisorChanged();
    #endregion
		
		public mchecklistheader()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_xid", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int xid
		{
			get
			{
				return this._xid;
			}
			set
			{
				if ((this._xid != value))
				{
					this.OnxidChanging(value);
					this.SendPropertyChanging();
					this._xid = value;
					this.SendPropertyChanged("xid");
					this.OnxidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_xdate", DbType="NChar(10)")]
		public string xdate
		{
			get
			{
				return this._xdate;
			}
			set
			{
				if ((this._xdate != value))
				{
					this.OnxdateChanging(value);
					this.SendPropertyChanging();
					this._xdate = value;
					this.SendPropertyChanged("xdate");
					this.OnxdateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_xtime", DbType="NChar(5)")]
		public string xtime
		{
			get
			{
				return this._xtime;
			}
			set
			{
				if ((this._xtime != value))
				{
					this.OnxtimeChanging(value);
					this.SendPropertyChanging();
					this._xtime = value;
					this.SendPropertyChanged("xtime");
					this.OnxtimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_xdevicecod", DbType="NChar(9)")]
		public string xdevicecod
		{
			get
			{
				return this._xdevicecod;
			}
			set
			{
				if ((this._xdevicecod != value))
				{
					this.OnxdevicecodChanging(value);
					this.SendPropertyChanging();
					this._xdevicecod = value;
					this.SendPropertyChanged("xdevicecod");
					this.OnxdevicecodChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_xdevicenumber", DbType="NChar(2)")]
		public string xdevicenumber
		{
			get
			{
				return this._xdevicenumber;
			}
			set
			{
				if ((this._xdevicenumber != value))
				{
					this.OnxdevicenumberChanging(value);
					this.SendPropertyChanging();
					this._xdevicenumber = value;
					this.SendPropertyChanged("xdevicenumber");
					this.OnxdevicenumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_xnote", DbType="NVarChar(MAX)")]
		public string xnote
		{
			get
			{
				return this._xnote;
			}
			set
			{
				if ((this._xnote != value))
				{
					this.OnxnoteChanging(value);
					this.SendPropertyChanging();
					this._xnote = value;
					this.SendPropertyChanged("xnote");
					this.OnxnoteChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_xidusersupervisor", DbType="Int")]
		public System.Nullable<int> xidusersupervisor
		{
			get
			{
				return this._xidusersupervisor;
			}
			set
			{
				if ((this._xidusersupervisor != value))
				{
					this.OnxidusersupervisorChanging(value);
					this.SendPropertyChanging();
					this._xidusersupervisor = value;
					this.SendPropertyChanged("xidusersupervisor");
					this.OnxidusersupervisorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_xconfirmsupervisor", DbType="Bit")]
		public System.Nullable<bool> xconfirmsupervisor
		{
			get
			{
				return this._xconfirmsupervisor;
			}
			set
			{
				if ((this._xconfirmsupervisor != value))
				{
					this.OnxconfirmsupervisorChanging(value);
					this.SendPropertyChanging();
					this._xconfirmsupervisor = value;
					this.SendPropertyChanged("xconfirmsupervisor");
					this.OnxconfirmsupervisorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_xidusernetsupervisor", DbType="Int")]
		public System.Nullable<int> xidusernetsupervisor
		{
			get
			{
				return this._xidusernetsupervisor;
			}
			set
			{
				if ((this._xidusernetsupervisor != value))
				{
					this.OnxidusernetsupervisorChanging(value);
					this.SendPropertyChanging();
					this._xidusernetsupervisor = value;
					this.SendPropertyChanged("xidusernetsupervisor");
					this.OnxidusernetsupervisorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_xconfirmnetsupervisor", DbType="Bit")]
		public System.Nullable<bool> xconfirmnetsupervisor
		{
			get
			{
				return this._xconfirmnetsupervisor;
			}
			set
			{
				if ((this._xconfirmnetsupervisor != value))
				{
					this.OnxconfirmnetsupervisorChanging(value);
					this.SendPropertyChanging();
					this._xconfirmnetsupervisor = value;
					this.SendPropertyChanged("xconfirmnetsupervisor");
					this.OnxconfirmnetsupervisorChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.mchecklistdetails")]
	public partial class mchecklistdetail : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _xid;
		
		private System.Nullable<int> _xidchecklistheader;
		
		private System.Nullable<int> _xidchecklistitem;
		
		private System.Nullable<int> _xidstate;
		
		private string _xdetails;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnxidChanging(int value);
    partial void OnxidChanged();
    partial void OnxidchecklistheaderChanging(System.Nullable<int> value);
    partial void OnxidchecklistheaderChanged();
    partial void OnxidchecklistitemChanging(System.Nullable<int> value);
    partial void OnxidchecklistitemChanged();
    partial void OnxidstateChanging(System.Nullable<int> value);
    partial void OnxidstateChanged();
    partial void OnxdetailsChanging(string value);
    partial void OnxdetailsChanged();
    #endregion
		
		public mchecklistdetail()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_xid", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int xid
		{
			get
			{
				return this._xid;
			}
			set
			{
				if ((this._xid != value))
				{
					this.OnxidChanging(value);
					this.SendPropertyChanging();
					this._xid = value;
					this.SendPropertyChanged("xid");
					this.OnxidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_xidchecklistheader", DbType="Int")]
		public System.Nullable<int> xidchecklistheader
		{
			get
			{
				return this._xidchecklistheader;
			}
			set
			{
				if ((this._xidchecklistheader != value))
				{
					this.OnxidchecklistheaderChanging(value);
					this.SendPropertyChanging();
					this._xidchecklistheader = value;
					this.SendPropertyChanged("xidchecklistheader");
					this.OnxidchecklistheaderChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_xidchecklistitem", DbType="Int")]
		public System.Nullable<int> xidchecklistitem
		{
			get
			{
				return this._xidchecklistitem;
			}
			set
			{
				if ((this._xidchecklistitem != value))
				{
					this.OnxidchecklistitemChanging(value);
					this.SendPropertyChanging();
					this._xidchecklistitem = value;
					this.SendPropertyChanged("xidchecklistitem");
					this.OnxidchecklistitemChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_xidstate", DbType="Int")]
		public System.Nullable<int> xidstate
		{
			get
			{
				return this._xidstate;
			}
			set
			{
				if ((this._xidstate != value))
				{
					this.OnxidstateChanging(value);
					this.SendPropertyChanging();
					this._xidstate = value;
					this.SendPropertyChanged("xidstate");
					this.OnxidstateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_xdetails", DbType="NVarChar(MAX)")]
		public string xdetails
		{
			get
			{
				return this._xdetails;
			}
			set
			{
				if ((this._xdetails != value))
				{
					this.OnxdetailsChanging(value);
					this.SendPropertyChanging();
					this._xdetails = value;
					this.SendPropertyChanged("xdetails");
					this.OnxdetailsChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.mchecklistcontroler")]
	public partial class mchecklistcontroler : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _xid;
		
		private System.Nullable<int> _xidcontroler;
		
		private System.Nullable<int> _xidchecklistheader;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnxidChanging(int value);
    partial void OnxidChanged();
    partial void OnxidcontrolerChanging(System.Nullable<int> value);
    partial void OnxidcontrolerChanged();
    partial void OnxidchecklistheaderChanging(System.Nullable<int> value);
    partial void OnxidchecklistheaderChanged();
    #endregion
		
		public mchecklistcontroler()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_xid", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int xid
		{
			get
			{
				return this._xid;
			}
			set
			{
				if ((this._xid != value))
				{
					this.OnxidChanging(value);
					this.SendPropertyChanging();
					this._xid = value;
					this.SendPropertyChanged("xid");
					this.OnxidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_xidcontroler", DbType="Int")]
		public System.Nullable<int> xidcontroler
		{
			get
			{
				return this._xidcontroler;
			}
			set
			{
				if ((this._xidcontroler != value))
				{
					this.OnxidcontrolerChanging(value);
					this.SendPropertyChanging();
					this._xidcontroler = value;
					this.SendPropertyChanged("xidcontroler");
					this.OnxidcontrolerChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_xidchecklistheader", DbType="Int")]
		public System.Nullable<int> xidchecklistheader
		{
			get
			{
				return this._xidchecklistheader;
			}
			set
			{
				if ((this._xidchecklistheader != value))
				{
					this.OnxidchecklistheaderChanging(value);
					this.SendPropertyChanging();
					this._xidchecklistheader = value;
					this.SendPropertyChanged("xidchecklistheader");
					this.OnxidchecklistheaderChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.mchecklistitem")]
	public partial class mchecklistitem : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _xid;
		
		private string _xdevicecod;
		
		private string _xitemreview;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnxidChanging(int value);
    partial void OnxidChanged();
    partial void OnxdevicecodChanging(string value);
    partial void OnxdevicecodChanged();
    partial void OnxitemreviewChanging(string value);
    partial void OnxitemreviewChanged();
    #endregion
		
		public mchecklistitem()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_xid", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int xid
		{
			get
			{
				return this._xid;
			}
			set
			{
				if ((this._xid != value))
				{
					this.OnxidChanging(value);
					this.SendPropertyChanging();
					this._xid = value;
					this.SendPropertyChanged("xid");
					this.OnxidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_xdevicecod", DbType="NChar(9)")]
		public string xdevicecod
		{
			get
			{
				return this._xdevicecod;
			}
			set
			{
				if ((this._xdevicecod != value))
				{
					this.OnxdevicecodChanging(value);
					this.SendPropertyChanging();
					this._xdevicecod = value;
					this.SendPropertyChanged("xdevicecod");
					this.OnxdevicecodChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_xitemreview", DbType="NVarChar(MAX)")]
		public string xitemreview
		{
			get
			{
				return this._xitemreview;
			}
			set
			{
				if ((this._xitemreview != value))
				{
					this.OnxitemreviewChanging(value);
					this.SendPropertyChanging();
					this._xitemreview = value;
					this.SendPropertyChanged("xitemreview");
					this.OnxitemreviewChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.mchecklistgroupcontroler")]
	public partial class mchecklistgroupcontroler : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _xid;
		
		private string _xnamegropcontroloer;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnxidChanging(int value);
    partial void OnxidChanged();
    partial void OnxnamegropcontroloerChanging(string value);
    partial void OnxnamegropcontroloerChanged();
    #endregion
		
		public mchecklistgroupcontroler()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_xid", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int xid
		{
			get
			{
				return this._xid;
			}
			set
			{
				if ((this._xid != value))
				{
					this.OnxidChanging(value);
					this.SendPropertyChanging();
					this._xid = value;
					this.SendPropertyChanged("xid");
					this.OnxidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_xnamegropcontroloer", DbType="NVarChar(50)")]
		public string xnamegropcontroloer
		{
			get
			{
				return this._xnamegropcontroloer;
			}
			set
			{
				if ((this._xnamegropcontroloer != value))
				{
					this.OnxnamegropcontroloerChanging(value);
					this.SendPropertyChanging();
					this._xnamegropcontroloer = value;
					this.SendPropertyChanged("xnamegropcontroloer");
					this.OnxnamegropcontroloerChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.mchecklistitem")]
	public partial class mchecklistitemcatgroy : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _xid;
		
		private string _xdevicecod;
		
		private string _xitemreview;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnxidChanging(int value);
    partial void OnxidChanged();
    partial void OnxdevicecodChanging(string value);
    partial void OnxdevicecodChanged();
    partial void OnxitemreviewChanging(string value);
    partial void OnxitemreviewChanged();
    #endregion
		
		public mchecklistitemcatgroy()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_xid", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int xid
		{
			get
			{
				return this._xid;
			}
			set
			{
				if ((this._xid != value))
				{
					this.OnxidChanging(value);
					this.SendPropertyChanging();
					this._xid = value;
					this.SendPropertyChanged("xid");
					this.OnxidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_xdevicecod", DbType="NChar(9)")]
		public string xdevicecod
		{
			get
			{
				return this._xdevicecod;
			}
			set
			{
				if ((this._xdevicecod != value))
				{
					this.OnxdevicecodChanging(value);
					this.SendPropertyChanging();
					this._xdevicecod = value;
					this.SendPropertyChanged("xdevicecod");
					this.OnxdevicecodChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_xitemreview", DbType="NVarChar(MAX)")]
		public string xitemreview
		{
			get
			{
				return this._xitemreview;
			}
			set
			{
				if ((this._xitemreview != value))
				{
					this.OnxitemreviewChanging(value);
					this.SendPropertyChanging();
					this._xitemreview = value;
					this.SendPropertyChanged("xitemreview");
					this.OnxitemreviewChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
