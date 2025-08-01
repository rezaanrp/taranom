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

namespace PAYADATA
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
	public partial class data_eventDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertTableevent(Tableevent instance);
    partial void UpdateTableevent(Tableevent instance);
    partial void DeleteTableevent(Tableevent instance);
    #endregion
		
		public data_eventDataContext() : 
				base(global::PAYADATA.Properties.Settings.Default.payazobnetConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public data_eventDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public data_eventDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public data_eventDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public data_eventDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Tableevent> Tableevents
		{
			get
			{
				return this.GetTable<Tableevent>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Tableevent")]
	public partial class Tableevent : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _xid;
		
		private string _xdate;
		
		private string _xtime;
		
		private string _xevent;
		
		private string _xmashinname;
		
		private string _xipmashin;
		
		private string _xusername;
		
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
    partial void OnxeventChanging(string value);
    partial void OnxeventChanged();
    partial void OnxmashinnameChanging(string value);
    partial void OnxmashinnameChanged();
    partial void OnxipmashinChanging(string value);
    partial void OnxipmashinChanged();
    partial void OnxusernameChanging(string value);
    partial void OnxusernameChanged();
    #endregion
		
		public Tableevent()
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_xdate", DbType="NVarChar(MAX)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_xtime", DbType="NVarChar(MAX)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_xevent", DbType="NVarChar(50)")]
		public string xevent
		{
			get
			{
				return this._xevent;
			}
			set
			{
				if ((this._xevent != value))
				{
					this.OnxeventChanging(value);
					this.SendPropertyChanging();
					this._xevent = value;
					this.SendPropertyChanged("xevent");
					this.OnxeventChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_xmashinname", DbType="NVarChar(50)")]
		public string xmashinname
		{
			get
			{
				return this._xmashinname;
			}
			set
			{
				if ((this._xmashinname != value))
				{
					this.OnxmashinnameChanging(value);
					this.SendPropertyChanging();
					this._xmashinname = value;
					this.SendPropertyChanged("xmashinname");
					this.OnxmashinnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_xipmashin", DbType="NVarChar(50)")]
		public string xipmashin
		{
			get
			{
				return this._xipmashin;
			}
			set
			{
				if ((this._xipmashin != value))
				{
					this.OnxipmashinChanging(value);
					this.SendPropertyChanging();
					this._xipmashin = value;
					this.SendPropertyChanged("xipmashin");
					this.OnxipmashinChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_xusername", DbType="NVarChar(50)")]
		public string xusername
		{
			get
			{
				return this._xusername;
			}
			set
			{
				if ((this._xusername != value))
				{
					this.OnxusernameChanging(value);
					this.SendPropertyChanging();
					this._xusername = value;
					this.SendPropertyChanged("xusername");
					this.OnxusernameChanged();
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
