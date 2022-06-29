﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyPhongKhamDongY
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="QLPKDY")]
	public partial class QLPKDYDataClassesDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertBenhNhan(BenhNhan instance);
    partial void UpdateBenhNhan(BenhNhan instance);
    partial void DeleteBenhNhan(BenhNhan instance);
    partial void InsertThuoc(Thuoc instance);
    partial void UpdateThuoc(Thuoc instance);
    partial void DeleteThuoc(Thuoc instance);
    partial void InsertChiTietDonThuoc(ChiTietDonThuoc instance);
    partial void UpdateChiTietDonThuoc(ChiTietDonThuoc instance);
    partial void DeleteChiTietDonThuoc(ChiTietDonThuoc instance);
    partial void InsertDonThuoc(DonThuoc instance);
    partial void UpdateDonThuoc(DonThuoc instance);
    partial void DeleteDonThuoc(DonThuoc instance);
    partial void InsertTaiKhoan(TaiKhoan instance);
    partial void UpdateTaiKhoan(TaiKhoan instance);
    partial void DeleteTaiKhoan(TaiKhoan instance);
    #endregion
		
		public QLPKDYDataClassesDataContext() : 
				base(global::QuanLyPhongKhamDongY.Properties.Settings.Default.QLPKDYConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public QLPKDYDataClassesDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QLPKDYDataClassesDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QLPKDYDataClassesDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QLPKDYDataClassesDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<BenhNhan> BenhNhans
		{
			get
			{
				return this.GetTable<BenhNhan>();
			}
		}
		
		public System.Data.Linq.Table<Thuoc> Thuocs
		{
			get
			{
				return this.GetTable<Thuoc>();
			}
		}
		
		public System.Data.Linq.Table<ChiTietDonThuoc> ChiTietDonThuocs
		{
			get
			{
				return this.GetTable<ChiTietDonThuoc>();
			}
		}
		
		public System.Data.Linq.Table<DonThuoc> DonThuocs
		{
			get
			{
				return this.GetTable<DonThuoc>();
			}
		}
		
		public System.Data.Linq.Table<TaiKhoan> TaiKhoans
		{
			get
			{
				return this.GetTable<TaiKhoan>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.BenhNhan")]
	public partial class BenhNhan : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaBN;
		
		private string _TenBN;
		
		private string _SDT;
		
		private string _DiaChi;
		
		private EntitySet<DonThuoc> _DonThuocs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaBNChanging(int value);
    partial void OnMaBNChanged();
    partial void OnTenBNChanging(string value);
    partial void OnTenBNChanged();
    partial void OnSDTChanging(string value);
    partial void OnSDTChanged();
    partial void OnDiaChiChanging(string value);
    partial void OnDiaChiChanged();
    #endregion
		
		public BenhNhan()
		{
			this._DonThuocs = new EntitySet<DonThuoc>(new Action<DonThuoc>(this.attach_DonThuocs), new Action<DonThuoc>(this.detach_DonThuocs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaBN", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MaBN
		{
			get
			{
				return this._MaBN;
			}
			set
			{
				if ((this._MaBN != value))
				{
					this.OnMaBNChanging(value);
					this.SendPropertyChanging();
					this._MaBN = value;
					this.SendPropertyChanged("MaBN");
					this.OnMaBNChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenBN", DbType="NVarChar(MAX)")]
		public string TenBN
		{
			get
			{
				return this._TenBN;
			}
			set
			{
				if ((this._TenBN != value))
				{
					this.OnTenBNChanging(value);
					this.SendPropertyChanging();
					this._TenBN = value;
					this.SendPropertyChanged("TenBN");
					this.OnTenBNChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SDT", DbType="Char(10)")]
		public string SDT
		{
			get
			{
				return this._SDT;
			}
			set
			{
				if ((this._SDT != value))
				{
					this.OnSDTChanging(value);
					this.SendPropertyChanging();
					this._SDT = value;
					this.SendPropertyChanged("SDT");
					this.OnSDTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DiaChi", DbType="NVarChar(MAX)")]
		public string DiaChi
		{
			get
			{
				return this._DiaChi;
			}
			set
			{
				if ((this._DiaChi != value))
				{
					this.OnDiaChiChanging(value);
					this.SendPropertyChanging();
					this._DiaChi = value;
					this.SendPropertyChanged("DiaChi");
					this.OnDiaChiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="BenhNhan_DonThuoc", Storage="_DonThuocs", ThisKey="MaBN", OtherKey="MaBN")]
		public EntitySet<DonThuoc> DonThuocs
		{
			get
			{
				return this._DonThuocs;
			}
			set
			{
				this._DonThuocs.Assign(value);
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
		
		private void attach_DonThuocs(DonThuoc entity)
		{
			this.SendPropertyChanging();
			entity.BenhNhan = this;
		}
		
		private void detach_DonThuocs(DonThuoc entity)
		{
			this.SendPropertyChanging();
			entity.BenhNhan = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Thuoc")]
	public partial class Thuoc : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaThuoc;
		
		private string _TenThuoc;
		
		private string _QuyCach;
		
		private string _CongDung;
		
		private string _CachDung;
		
		private System.Nullable<System.DateTime> _NSX;
		
		private System.Nullable<System.DateTime> _HSD;
		
		private System.Nullable<long> _Gia;
		
		private EntitySet<ChiTietDonThuoc> _ChiTietDonThuocs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaThuocChanging(int value);
    partial void OnMaThuocChanged();
    partial void OnTenThuocChanging(string value);
    partial void OnTenThuocChanged();
    partial void OnQuyCachChanging(string value);
    partial void OnQuyCachChanged();
    partial void OnCongDungChanging(string value);
    partial void OnCongDungChanged();
    partial void OnCachDungChanging(string value);
    partial void OnCachDungChanged();
    partial void OnNSXChanging(System.Nullable<System.DateTime> value);
    partial void OnNSXChanged();
    partial void OnHSDChanging(System.Nullable<System.DateTime> value);
    partial void OnHSDChanged();
    partial void OnGiaChanging(System.Nullable<long> value);
    partial void OnGiaChanged();
    #endregion
		
		public Thuoc()
		{
			this._ChiTietDonThuocs = new EntitySet<ChiTietDonThuoc>(new Action<ChiTietDonThuoc>(this.attach_ChiTietDonThuocs), new Action<ChiTietDonThuoc>(this.detach_ChiTietDonThuocs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaThuoc", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MaThuoc
		{
			get
			{
				return this._MaThuoc;
			}
			set
			{
				if ((this._MaThuoc != value))
				{
					this.OnMaThuocChanging(value);
					this.SendPropertyChanging();
					this._MaThuoc = value;
					this.SendPropertyChanged("MaThuoc");
					this.OnMaThuocChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenThuoc", DbType="NVarChar(MAX)")]
		public string TenThuoc
		{
			get
			{
				return this._TenThuoc;
			}
			set
			{
				if ((this._TenThuoc != value))
				{
					this.OnTenThuocChanging(value);
					this.SendPropertyChanging();
					this._TenThuoc = value;
					this.SendPropertyChanged("TenThuoc");
					this.OnTenThuocChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_QuyCach", DbType="NVarChar(10)")]
		public string QuyCach
		{
			get
			{
				return this._QuyCach;
			}
			set
			{
				if ((this._QuyCach != value))
				{
					this.OnQuyCachChanging(value);
					this.SendPropertyChanging();
					this._QuyCach = value;
					this.SendPropertyChanged("QuyCach");
					this.OnQuyCachChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CongDung", DbType="NVarChar(MAX)")]
		public string CongDung
		{
			get
			{
				return this._CongDung;
			}
			set
			{
				if ((this._CongDung != value))
				{
					this.OnCongDungChanging(value);
					this.SendPropertyChanging();
					this._CongDung = value;
					this.SendPropertyChanged("CongDung");
					this.OnCongDungChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CachDung", DbType="NVarChar(MAX)")]
		public string CachDung
		{
			get
			{
				return this._CachDung;
			}
			set
			{
				if ((this._CachDung != value))
				{
					this.OnCachDungChanging(value);
					this.SendPropertyChanging();
					this._CachDung = value;
					this.SendPropertyChanged("CachDung");
					this.OnCachDungChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NSX", DbType="DateTime")]
		public System.Nullable<System.DateTime> NSX
		{
			get
			{
				return this._NSX;
			}
			set
			{
				if ((this._NSX != value))
				{
					this.OnNSXChanging(value);
					this.SendPropertyChanging();
					this._NSX = value;
					this.SendPropertyChanged("NSX");
					this.OnNSXChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HSD", DbType="DateTime")]
		public System.Nullable<System.DateTime> HSD
		{
			get
			{
				return this._HSD;
			}
			set
			{
				if ((this._HSD != value))
				{
					this.OnHSDChanging(value);
					this.SendPropertyChanging();
					this._HSD = value;
					this.SendPropertyChanged("HSD");
					this.OnHSDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Gia", DbType="BigInt")]
		public System.Nullable<long> Gia
		{
			get
			{
				return this._Gia;
			}
			set
			{
				if ((this._Gia != value))
				{
					this.OnGiaChanging(value);
					this.SendPropertyChanging();
					this._Gia = value;
					this.SendPropertyChanged("Gia");
					this.OnGiaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Thuoc_ChiTietDonThuoc", Storage="_ChiTietDonThuocs", ThisKey="MaThuoc", OtherKey="MaThuoc")]
		public EntitySet<ChiTietDonThuoc> ChiTietDonThuocs
		{
			get
			{
				return this._ChiTietDonThuocs;
			}
			set
			{
				this._ChiTietDonThuocs.Assign(value);
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
		
		private void attach_ChiTietDonThuocs(ChiTietDonThuoc entity)
		{
			this.SendPropertyChanging();
			entity.Thuoc = this;
		}
		
		private void detach_ChiTietDonThuocs(ChiTietDonThuoc entity)
		{
			this.SendPropertyChanging();
			entity.Thuoc = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ChiTietDonThuoc")]
	public partial class ChiTietDonThuoc : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaCTDT;
		
		private System.Nullable<int> _MaDT;
		
		private System.Nullable<int> _MaThuoc;
		
		private System.Nullable<int> _SL;
		
		private System.Nullable<long> _ThanhTien;
		
		private EntityRef<Thuoc> _Thuoc;
		
		private EntityRef<DonThuoc> _DonThuoc;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaCTDTChanging(int value);
    partial void OnMaCTDTChanged();
    partial void OnMaDTChanging(System.Nullable<int> value);
    partial void OnMaDTChanged();
    partial void OnMaThuocChanging(System.Nullable<int> value);
    partial void OnMaThuocChanged();
    partial void OnSLChanging(System.Nullable<int> value);
    partial void OnSLChanged();
    partial void OnThanhTienChanging(System.Nullable<long> value);
    partial void OnThanhTienChanged();
    #endregion
		
		public ChiTietDonThuoc()
		{
			this._Thuoc = default(EntityRef<Thuoc>);
			this._DonThuoc = default(EntityRef<DonThuoc>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaCTDT", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MaCTDT
		{
			get
			{
				return this._MaCTDT;
			}
			set
			{
				if ((this._MaCTDT != value))
				{
					this.OnMaCTDTChanging(value);
					this.SendPropertyChanging();
					this._MaCTDT = value;
					this.SendPropertyChanged("MaCTDT");
					this.OnMaCTDTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaDT", DbType="Int")]
		public System.Nullable<int> MaDT
		{
			get
			{
				return this._MaDT;
			}
			set
			{
				if ((this._MaDT != value))
				{
					if (this._DonThuoc.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaDTChanging(value);
					this.SendPropertyChanging();
					this._MaDT = value;
					this.SendPropertyChanged("MaDT");
					this.OnMaDTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaThuoc", DbType="Int")]
		public System.Nullable<int> MaThuoc
		{
			get
			{
				return this._MaThuoc;
			}
			set
			{
				if ((this._MaThuoc != value))
				{
					if (this._Thuoc.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaThuocChanging(value);
					this.SendPropertyChanging();
					this._MaThuoc = value;
					this.SendPropertyChanged("MaThuoc");
					this.OnMaThuocChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SL", DbType="Int")]
		public System.Nullable<int> SL
		{
			get
			{
				return this._SL;
			}
			set
			{
				if ((this._SL != value))
				{
					this.OnSLChanging(value);
					this.SendPropertyChanging();
					this._SL = value;
					this.SendPropertyChanged("SL");
					this.OnSLChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ThanhTien", DbType="BigInt")]
		public System.Nullable<long> ThanhTien
		{
			get
			{
				return this._ThanhTien;
			}
			set
			{
				if ((this._ThanhTien != value))
				{
					this.OnThanhTienChanging(value);
					this.SendPropertyChanging();
					this._ThanhTien = value;
					this.SendPropertyChanged("ThanhTien");
					this.OnThanhTienChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Thuoc_ChiTietDonThuoc", Storage="_Thuoc", ThisKey="MaThuoc", OtherKey="MaThuoc", IsForeignKey=true, DeleteRule="CASCADE")]
		public Thuoc Thuoc
		{
			get
			{
				return this._Thuoc.Entity;
			}
			set
			{
				Thuoc previousValue = this._Thuoc.Entity;
				if (((previousValue != value) 
							|| (this._Thuoc.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Thuoc.Entity = null;
						previousValue.ChiTietDonThuocs.Remove(this);
					}
					this._Thuoc.Entity = value;
					if ((value != null))
					{
						value.ChiTietDonThuocs.Add(this);
						this._MaThuoc = value.MaThuoc;
					}
					else
					{
						this._MaThuoc = default(Nullable<int>);
					}
					this.SendPropertyChanged("Thuoc");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="DonThuoc_ChiTietDonThuoc", Storage="_DonThuoc", ThisKey="MaDT", OtherKey="MaDT", IsForeignKey=true, DeleteRule="CASCADE")]
		public DonThuoc DonThuoc
		{
			get
			{
				return this._DonThuoc.Entity;
			}
			set
			{
				DonThuoc previousValue = this._DonThuoc.Entity;
				if (((previousValue != value) 
							|| (this._DonThuoc.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._DonThuoc.Entity = null;
						previousValue.ChiTietDonThuocs.Remove(this);
					}
					this._DonThuoc.Entity = value;
					if ((value != null))
					{
						value.ChiTietDonThuocs.Add(this);
						this._MaDT = value.MaDT;
					}
					else
					{
						this._MaDT = default(Nullable<int>);
					}
					this.SendPropertyChanged("DonThuoc");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.DonThuoc")]
	public partial class DonThuoc : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaDT;
		
		private System.Nullable<int> _MaBN;
		
		private System.Nullable<System.DateTime> _NgayLap;
		
		private System.Nullable<long> _TongTien;
		
		private EntitySet<ChiTietDonThuoc> _ChiTietDonThuocs;
		
		private EntityRef<BenhNhan> _BenhNhan;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaDTChanging(int value);
    partial void OnMaDTChanged();
    partial void OnMaBNChanging(System.Nullable<int> value);
    partial void OnMaBNChanged();
    partial void OnNgayLapChanging(System.Nullable<System.DateTime> value);
    partial void OnNgayLapChanged();
    partial void OnTongTienChanging(System.Nullable<long> value);
    partial void OnTongTienChanged();
    #endregion
		
		public DonThuoc()
		{
			this._ChiTietDonThuocs = new EntitySet<ChiTietDonThuoc>(new Action<ChiTietDonThuoc>(this.attach_ChiTietDonThuocs), new Action<ChiTietDonThuoc>(this.detach_ChiTietDonThuocs));
			this._BenhNhan = default(EntityRef<BenhNhan>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaDT", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MaDT
		{
			get
			{
				return this._MaDT;
			}
			set
			{
				if ((this._MaDT != value))
				{
					this.OnMaDTChanging(value);
					this.SendPropertyChanging();
					this._MaDT = value;
					this.SendPropertyChanged("MaDT");
					this.OnMaDTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaBN", DbType="Int")]
		public System.Nullable<int> MaBN
		{
			get
			{
				return this._MaBN;
			}
			set
			{
				if ((this._MaBN != value))
				{
					if (this._BenhNhan.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaBNChanging(value);
					this.SendPropertyChanging();
					this._MaBN = value;
					this.SendPropertyChanged("MaBN");
					this.OnMaBNChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgayLap", DbType="DateTime")]
		public System.Nullable<System.DateTime> NgayLap
		{
			get
			{
				return this._NgayLap;
			}
			set
			{
				if ((this._NgayLap != value))
				{
					this.OnNgayLapChanging(value);
					this.SendPropertyChanging();
					this._NgayLap = value;
					this.SendPropertyChanged("NgayLap");
					this.OnNgayLapChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TongTien", DbType="BigInt")]
		public System.Nullable<long> TongTien
		{
			get
			{
				return this._TongTien;
			}
			set
			{
				if ((this._TongTien != value))
				{
					this.OnTongTienChanging(value);
					this.SendPropertyChanging();
					this._TongTien = value;
					this.SendPropertyChanged("TongTien");
					this.OnTongTienChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="DonThuoc_ChiTietDonThuoc", Storage="_ChiTietDonThuocs", ThisKey="MaDT", OtherKey="MaDT")]
		public EntitySet<ChiTietDonThuoc> ChiTietDonThuocs
		{
			get
			{
				return this._ChiTietDonThuocs;
			}
			set
			{
				this._ChiTietDonThuocs.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="BenhNhan_DonThuoc", Storage="_BenhNhan", ThisKey="MaBN", OtherKey="MaBN", IsForeignKey=true, DeleteRule="CASCADE")]
		public BenhNhan BenhNhan
		{
			get
			{
				return this._BenhNhan.Entity;
			}
			set
			{
				BenhNhan previousValue = this._BenhNhan.Entity;
				if (((previousValue != value) 
							|| (this._BenhNhan.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._BenhNhan.Entity = null;
						previousValue.DonThuocs.Remove(this);
					}
					this._BenhNhan.Entity = value;
					if ((value != null))
					{
						value.DonThuocs.Add(this);
						this._MaBN = value.MaBN;
					}
					else
					{
						this._MaBN = default(Nullable<int>);
					}
					this.SendPropertyChanged("BenhNhan");
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
		
		private void attach_ChiTietDonThuocs(ChiTietDonThuoc entity)
		{
			this.SendPropertyChanging();
			entity.DonThuoc = this;
		}
		
		private void detach_ChiTietDonThuocs(ChiTietDonThuoc entity)
		{
			this.SendPropertyChanging();
			entity.DonThuoc = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TaiKhoan")]
	public partial class TaiKhoan : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _TDN;
		
		private string _MK;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnTDNChanging(string value);
    partial void OnTDNChanged();
    partial void OnMKChanging(string value);
    partial void OnMKChanged();
    #endregion
		
		public TaiKhoan()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TDN", DbType="NVarChar(20) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string TDN
		{
			get
			{
				return this._TDN;
			}
			set
			{
				if ((this._TDN != value))
				{
					this.OnTDNChanging(value);
					this.SendPropertyChanging();
					this._TDN = value;
					this.SendPropertyChanged("TDN");
					this.OnTDNChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MK", DbType="NVarChar(MAX)")]
		public string MK
		{
			get
			{
				return this._MK;
			}
			set
			{
				if ((this._MK != value))
				{
					this.OnMKChanging(value);
					this.SendPropertyChanging();
					this._MK = value;
					this.SendPropertyChanged("MK");
					this.OnMKChanged();
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
