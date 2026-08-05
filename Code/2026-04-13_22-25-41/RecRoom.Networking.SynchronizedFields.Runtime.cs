using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using JetBrains.Annotations;
using RecRoom.DataLayer;
using RecRoom.Foundation;
using RecRoom.Networking.DataTypes;
using RecRoom.Networking.SynchronizedFields;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Networking
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public interface NUAUZMIGHGX : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		bool OSLGERNTSUG
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		bool VQHWDULORRR
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		DDFOJMMWCEL XUPGIOENIWM
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		int YRBYESARCNL
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		bool AHPZUIEDDCV
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		bool GOTJOUIHQWF
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		event Action IUQHWDNKBGG;

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void RIHCKHWQLMX();

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void KNIBMYBTXLF(object a, bool b);

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void GUGKNCYFZXH();
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface OZNPFEQMNJS : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000007")]
		string OTIUDMTTUGL
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		bool IKQSTLUOMMB
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface ZKLTCJLGJQP<a> : OZNPFEQMNJS, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		a IYPENRGWRFX
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void XUACCGNRNOU(a a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public sealed class YZPEHXXYCZC<a> : ZKLTCJLGJQP<a>, OZNPFEQMNJS, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private readonly MRXGQCQLMGZ<a> RPXWAUSORIR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private readonly MRXGQCQLMGZ<a> GBUZOZSTWNS;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public string OTIUDMTTUGL
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xF84310", Offset = "0xF82D10", VA = "0x180F84310", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool RWZZXBCMNZJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x5128100", Offset = "0x5126B00", VA = "0x185128100", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public a ZZOCBIPDATE
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x51288A0", Offset = "0x51272A0", VA = "0x1851288A0", Slot = "11")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x512A430", Offset = "0x5128E30", VA = "0x18512A430", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public a IYPENRGWRFX
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x5128790", Offset = "0x5127190", VA = "0x185128790", Slot = "4")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x512B270", Offset = "0x5129C70", VA = "0x18512B270", Slot = "13")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public a YMGSSSXYISN
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x5128790", Offset = "0x5127190", VA = "0x185128790")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x51289E0", Offset = "0x51273E0", VA = "0x1851289E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool IKQSTLUOMMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x51267C0", Offset = "0x51251C0", VA = "0x1851267C0", Slot = "7")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x51262D0", Offset = "0x5124CD0", VA = "0x1851262D0", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool ZALDBGGFNHL
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x5128640", Offset = "0x5127040", VA = "0x185128640")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x512AA90", Offset = "0x5129490", VA = "0x18512AA90", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x512D700", Offset = "0x512C100", VA = "0x18512D700")]
		public YZPEHXXYCZC([In] SyncData data, a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x512B9E0", Offset = "0x512A3E0", VA = "0x18512B9E0")]
		private void WEJETJMVVZV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x512C160", Offset = "0x512AB60", VA = "0x18512C160", Slot = "5")]
		public void XUACCGNRNOU(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x512C270", Offset = "0x512AC70", VA = "0x18512C270")]
		public void XUACCGNRNOU(a a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5125F00", Offset = "0x5124900", VA = "0x185125F00", Slot = "8")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public sealed class ZAEYZSFQFHD<a, b> : ZKLTCJLGJQP<(a, b)>, OZNPFEQMNJS, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly MRHLYIITJYY<a, b> RPXWAUSORIR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private readonly MRHLYIITJYY<a, b> GBUZOZSTWNS;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public string OTIUDMTTUGL
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0xF84310", Offset = "0xF82D10", VA = "0x180F84310", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool RWZZXBCMNZJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x51379B0", Offset = "0x51363B0", VA = "0x1851379B0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool KTOGMYYRCUK
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x5136980", Offset = "0x5135380", VA = "0x185136980")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool KTIZPSETTJB
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x5136740", Offset = "0x5135140", VA = "0x185136740")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public (a, b) ZZOCBIPDATE
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x5138CD0", Offset = "0x51376D0", VA = "0x185138CD0", Slot = "11")]
			get
			{
				return default((a, b));
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x5139840", Offset = "0x5138240", VA = "0x185139840", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public (a, b) IYPENRGWRFX
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x51383D0", Offset = "0x5136DD0", VA = "0x1851383D0", Slot = "4")]
			get
			{
				return default((a, b));
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x513B800", Offset = "0x513A200", VA = "0x18513B800", Slot = "13")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public (a, b) YMGSSSXYISN
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x5138130", Offset = "0x5136B30", VA = "0x185138130")]
			get
			{
				return default((a, b));
			}
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x5139200", Offset = "0x5137C00", VA = "0x185139200")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public a NWWDTUVGLKB
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x51389A0", Offset = "0x51373A0", VA = "0x1851389A0")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x513ACC0", Offset = "0x51396C0", VA = "0x18513ACC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public a USMPQDVWBRW
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x5136240", Offset = "0x5134C40", VA = "0x185136240")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x5137AA0", Offset = "0x51364A0", VA = "0x185137AA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public a BPPAZGVHXGA
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x5136240", Offset = "0x5134C40", VA = "0x185136240")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x5137330", Offset = "0x5135D30", VA = "0x185137330")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public b NWGJCANOJCA
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x5138A80", Offset = "0x5137480", VA = "0x185138A80")]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x513AF70", Offset = "0x5139970", VA = "0x18513AF70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public b UTCKHYDODZX
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x5136400", Offset = "0x5134E00", VA = "0x185136400")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public b BQEVRBCZZOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x5136400", Offset = "0x5134E00", VA = "0x185136400")]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x5136B90", Offset = "0x5135590", VA = "0x185136B90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public bool IKQSTLUOMMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x51267C0", Offset = "0x51251C0", VA = "0x1851267C0", Slot = "7")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x51262D0", Offset = "0x5124CD0", VA = "0x1851262D0", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x513A960", Offset = "0x5139360", VA = "0x18513A960", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x513C940", Offset = "0x513B340", VA = "0x18513C940")]
		public ZAEYZSFQFHD([In] SyncData data, a a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x513B8F0", Offset = "0x513A2F0", VA = "0x18513B8F0")]
		private void WEJETJMVVZV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x51380A0", Offset = "0x5136AA0", VA = "0x1851380A0")]
		public void GDZPVSSGUMV(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x513BF40", Offset = "0x513A940", VA = "0x18513BF40")]
		public void XUACCGNRNOU(a a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x513A1E0", Offset = "0x5138BE0", VA = "0x18513A1E0", Slot = "5")]
		private void RMAPZCVOTWX((a, b) a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x5125F00", Offset = "0x5124900", VA = "0x185125F00", Slot = "8")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public sealed class YZZSCLLSVVU<a, b, c> : ZKLTCJLGJQP<(a, b, c)>, OZNPFEQMNJS, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly MRMSVPCQTKH<a, b, c> RPXWAUSORIR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly MRMSVPCQTKH<a, b, c> GBUZOZSTWNS;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public string OTIUDMTTUGL
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0xF84310", Offset = "0xF82D10", VA = "0x180F84310", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public bool RWZZXBCMNZJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x5132420", Offset = "0x5130E20", VA = "0x185132420", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool KTOGMYYRCUK
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x5131A10", Offset = "0x5130410", VA = "0x185131A10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public bool KTIZPSETTJB
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x5131560", Offset = "0x512FF60", VA = "0x185131560")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public bool KTDSSLKWJXS
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x5131870", Offset = "0x5130270", VA = "0x185131870")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public (a, b, c) ZZOCBIPDATE
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x5133170", Offset = "0x5131B70", VA = "0x185133170", Slot = "11")]
			get
			{
				return default((a, b, c));
			}
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x5133C50", Offset = "0x5132650", VA = "0x185133C50", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public (a, b, c) IYPENRGWRFX
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x5132C30", Offset = "0x5131630", VA = "0x185132C30", Slot = "4")]
			get
			{
				return default((a, b, c));
			}
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x51348C0", Offset = "0x51332C0", VA = "0x1851348C0", Slot = "13")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public a NWWDTUVGLKB
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x5132EA0", Offset = "0x51318A0", VA = "0x185132EA0")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x51340F0", Offset = "0x5132AF0", VA = "0x1851340F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public a USMPQDVWBRW
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x5131370", Offset = "0x512FD70", VA = "0x185131370")]
			get
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public a BPPAZGVHXGA
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x5131370", Offset = "0x512FD70", VA = "0x185131370")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x5132190", Offset = "0x5130B90", VA = "0x185132190")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public b NWGJCANOJCA
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x5133060", Offset = "0x5131A60", VA = "0x185133060")]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x51345D0", Offset = "0x5132FD0", VA = "0x1851345D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public b UTCKHYDODZX
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x5131450", Offset = "0x512FE50", VA = "0x185131450")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public b BQEVRBCZZOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x5131450", Offset = "0x512FE50", VA = "0x185131450")]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x5131CD0", Offset = "0x51306D0", VA = "0x185131CD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public c NWLPZHHLSNJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x5132ED0", Offset = "0x51318D0", VA = "0x185132ED0")]
			get
			{
				return (c)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x51343A0", Offset = "0x5132DA0", VA = "0x1851343A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public c USXDKRJQUOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x5131480", Offset = "0x512FE80", VA = "0x185131480")]
			get
			{
				return (c)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public c BPZOTUJCQCS
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x5131480", Offset = "0x512FE80", VA = "0x185131480")]
			get
			{
				return (c)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x5131F50", Offset = "0x5130950", VA = "0x185131F50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool IKQSTLUOMMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x51267C0", Offset = "0x51251C0", VA = "0x1851267C0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x5133FD0", Offset = "0x51329D0", VA = "0x185133FD0", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x51358F0", Offset = "0x51342F0", VA = "0x1851358F0")]
		public YZZSCLLSVVU([In] SyncData data, a a, b b, c c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x5135120", Offset = "0x5133B20", VA = "0x185135120")]
		private void WEJETJMVVZV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x51327B0", Offset = "0x51311B0", VA = "0x1851327B0")]
		public void GDZPVSSGUMV(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x5135790", Offset = "0x5134190", VA = "0x185135790")]
		public void ZAGJLWBDGFE(b a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x5131210", Offset = "0x512FC10", VA = "0x185131210")]
		public void CPSKMFCHNWH(c a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x5135500", Offset = "0x5133F00", VA = "0x185135500")]
		public void XUACCGNRNOU(a a, b b, c c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x5134C50", Offset = "0x5133650", VA = "0x185134C50", Slot = "5")]
		private void VPGGZFSNXGI((a, b, c) a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x5125F00", Offset = "0x5124900", VA = "0x185125F00", Slot = "8")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public sealed class YYZJQDQGARB<a, b, c, d> : ZKLTCJLGJQP<(a, b, c, d)>, OZNPFEQMNJS, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly MQWYDUUYRCG<a, b, c, d> RPXWAUSORIR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly MQWYDUUYRCG<a, b, c, d> GBUZOZSTWNS;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public string OTIUDMTTUGL
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xF84310", Offset = "0xF82D10", VA = "0x180F84310", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public (a, b, c, d) IYPENRGWRFX
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x51262F0", Offset = "0x5124CF0", VA = "0x1851262F0", Slot = "4")]
			get
			{
				return default((a, b, c, d));
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x5126F20", Offset = "0x5125920", VA = "0x185126F20", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public b UTCKHYDODZX
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x5125DF0", Offset = "0x51247F0", VA = "0x185125DF0")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public c USXDKRJQUOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x5125E20", Offset = "0x5124820", VA = "0x185125E20")]
			get
			{
				return (c)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public d URWUYJODZJV
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x5125C60", Offset = "0x5124660", VA = "0x185125C60")]
			get
			{
				return (d)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool IKQSTLUOMMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x51267C0", Offset = "0x51251C0", VA = "0x1851267C0", Slot = "7")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x51262D0", Offset = "0x5124CD0", VA = "0x1851262D0", Slot = "10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x5127C70", Offset = "0x5126670", VA = "0x185127C70")]
		public YYZJQDQGARB([In] SyncData data, a a, b b, c c, d d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x5126F70", Offset = "0x5125970", VA = "0x185126F70")]
		private void WEJETJMVVZV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x51261E0", Offset = "0x5124BE0", VA = "0x1851261E0")]
		public void GDZPVSSGUMV(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x51272D0", Offset = "0x5125CD0", VA = "0x1851272D0")]
		public void XUACCGNRNOU(a a, b b, c c, d d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x51267E0", Offset = "0x51251E0", VA = "0x1851267E0", Slot = "5")]
		private void QZRVRVLARXU((a, b, c, d) a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x5125F00", Offset = "0x5124900", VA = "0x185125F00", Slot = "8")]
		public void Dispose()
		{
		}
	}
}
namespace RecRoom.Networking.Policy
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class LCENLYCFDZD
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x99940F0", Offset = "0x9992AF0", VA = "0x1899940F0")]
		public static string CARFOTRAMKU(this SyncData a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xD5A2A0", Offset = "0xD58CA0", VA = "0x180D5A2A0")]
		public static NetworkSetterPermissionMode LQNKMBCPQAN(this SyncData a)
		{
			return default(NetworkSetterPermissionMode);
		}
	}
}
namespace RecRoom.Networking.SynchronizedFields
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class MRXGQCQLMGZ<a> : BQMBDSTWEOA<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6F1FE80", Offset = "0x6F1E880", VA = "0x186F1FE80")]
		public MRXGQCQLMGZ([In] SyncData data, a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6F1E210", Offset = "0x6F1CC10", VA = "0x186F1E210")]
		public MRXGQCQLMGZ(DSDVCCWMEAG a, DDFOJMMWCEL b, string c, a d, NetworkSetterPermissionMode e, [Optional] Action f, [Optional] INJJPMNDUTS g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6F1CCE0", Offset = "0x6F1B6E0", VA = "0x186F1CCE0")]
		public MRXGQCQLMGZ(DSDVCCWMEAG a, string b, a c, NetworkSetterPermissionMode d, [Optional] Action e, [Optional] INJJPMNDUTS f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6F1F570", Offset = "0x6F1DF70", VA = "0x186F1F570")]
		public MRXGQCQLMGZ(DSDVCCWMEAG a, string b, a c, NetworkSetterPermissionMode d, bool e, [Optional] Action f, [Optional] INJJPMNDUTS g)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class MRHLYIITJYY<a, b> : BRBVVNBOGWB<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6F18B50", Offset = "0x6F17550", VA = "0x186F18B50")]
		public MRHLYIITJYY([In] SyncData data, a a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6F18300", Offset = "0x6F16D00", VA = "0x186F18300")]
		public MRHLYIITJYY(DSDVCCWMEAG a, DDFOJMMWCEL b, string c, a d, b e, NetworkSetterPermissionMode f, [Optional] Action g, [Optional] INJJPMNDUTS h)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x6F19D60", Offset = "0x6F18760", VA = "0x186F19D60")]
		public MRHLYIITJYY(DSDVCCWMEAG a, string b, a c, b d, NetworkSetterPermissionMode e, [Optional] Action f, [Optional] INJJPMNDUTS g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x6F16C50", Offset = "0x6F15650", VA = "0x186F16C50")]
		public MRHLYIITJYY(DSDVCCWMEAG a, string b, a c, b d, NetworkSetterPermissionMode e, bool f, [Optional] Action g, [Optional] INJJPMNDUTS h)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class MRMSVPCQTKH<a, b, c> : BQWOYGHQXKS<a, b, c>
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x6F1B240", Offset = "0x6F19C40", VA = "0x186F1B240")]
		public MRMSVPCQTKH([In] SyncData data, a a, b b, c c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x6F1B6E0", Offset = "0x6F1A0E0", VA = "0x186F1B6E0")]
		public MRMSVPCQTKH(DSDVCCWMEAG a, string b, a c, b d, c e, NetworkSetterPermissionMode f, [Optional] Action g, [Optional] INJJPMNDUTS h)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class MQWYDUUYRCG<a, b, c, d> : BPWGLYMECFZ<a, b, c, d>
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6F132F0", Offset = "0x6F11CF0", VA = "0x186F132F0")]
		public MQWYDUUYRCG([In] SyncData data, a a, b b, c c, d d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6F13B50", Offset = "0x6F12550", VA = "0x186F13B50")]
		public MQWYDUUYRCG(DSDVCCWMEAG a, DDFOJMMWCEL b, string c, a d, b e, c f, d g, NetworkSetterPermissionMode h, [Optional] Action i, [Optional] INJJPMNDUTS j)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6F136E0", Offset = "0x6F120E0", VA = "0x186F136E0")]
		public MQWYDUUYRCG(DSDVCCWMEAG a, string b, a c, b d, c e, d f, NetworkSetterPermissionMode g, [Optional] Action h, [Optional] INJJPMNDUTS i)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class MRCFBBOWANP<a, b, c, d, e> : BPQZORSGSUQ<a, b, c, d, e>
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6F15540", Offset = "0x6F13F40", VA = "0x186F15540")]
		public MRCFBBOWANP(DSDVCCWMEAG a, DDFOJMMWCEL b, string c, a d, b e, c f, d g, e h, NetworkSetterPermissionMode i, [Optional] Action j, [Optional] INJJPMNDUTS k)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x6F16240", Offset = "0x6F14C40", VA = "0x186F16240")]
		public MRCFBBOWANP(DSDVCCWMEAG a, string b, a c, b d, c e, d f, e g, NetworkSetterPermissionMode h, [Optional] Action i, [Optional] INJJPMNDUTS j)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class MNSITLULKWC<a> : BQMBDSTWEOA<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6F0F610", Offset = "0x6F0E010", VA = "0x186F0F610")]
		public MNSITLULKWC(DDFOJMMWCEL a, string b, a c, [Optional] Action d, [Optional] INJJPMNDUTS e)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class MNNBWFAOBKT<a, b> : BRBVVNBOGWB<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6F0E240", Offset = "0x6F0CC40", VA = "0x186F0E240")]
		public MNNBWFAOBKT(DDFOJMMWCEL a, string b, a c, b d, [Optional] Action e, [Optional] INJJPMNDUTS f)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public interface TIWHZUVAQFU
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "0")]
		MRXGQCQLMGZ<a> BNJJKARHPLU<a>(string a, a b, NetworkSetterPermissionMode c, [Optional] Action d);
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class VYIDZLVARYP : TIWHZUVAQFU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly INJJPMNDUTS DLLCEHTEYPV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly DSDVCCWMEAG SZKFOUDUREX;

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0xCF2960", Offset = "0xCF1360", VA = "0x180CF2960")]
		public VYIDZLVARYP(INJJPMNDUTS a, DSDVCCWMEAG b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x40CD470", Offset = "0x40CBE70", VA = "0x1840CD470", Slot = "4")]
		public MRXGQCQLMGZ<a> BNJJKARHPLU<a>(string a, a b, NetworkSetterPermissionMode c, [Optional] Action d)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public interface FLXSWDTULZN : DSDVCCWMEAG
	{
		[Cpp2IlInjected.Token(Token = "0x17000036")]
		ViewId BAUHYNCUZBT
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public interface DSDVCCWMEAG
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		bool YRLVANZTLCV
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		bool YOKUFGKYOGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		string AYIWIXMYNJH
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		bool GZVSNUBPDHQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void RegisterDestroyHandler(IATHQHSNSXK handler);

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void UnregisterDestroyHandler(IATHQHSNSXK handler);
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public static class BLLCBVZCXLK
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x99940A0", Offset = "0x9992AA0", VA = "0x1899940A0")]
		public static bool SNALXYYRDVB(this DSDVCCWMEAG a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface INJJPMNDUTS : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		DDFOJMMWCEL SJQDIJZJGRA
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		bool ZALDBGGFNHL
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		bool RXQOZDWSMOM
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void Initialize();

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "4")]
		object IGIEWJJCYZS(string a);

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "5")]
		object INRZJAOHFFQ(DDFOJMMWCEL a, string b);

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void ZVCCBKYJFYE(string a, object b);

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void SFUJJSZVOKW(DDFOJMMWCEL a, string b, object c);

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void UJQARUJTJYH<a>(string a, a b);

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void DMCUZCCFLUN([CanBeNull] DDFOJMMWCEL photonPlayer, string a, BKVGBBESOLE b);

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void URNYJZOSFKE([CanBeNull] DDFOJMMWCEL photonPlayer, string a, BKVGBBESOLE b);

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "11")]
		b GQBIWFKLTBK<b>(object a);

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(Slot = "12")]
		object BVYGVRSRQPX<c>(c a);

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "13")]
		object GQBIWFKLTBK(object a, Type b);

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "14")]
		object BVYGVRSRQPX(object a, Type b);

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void SEULCQDQNKE();

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "16")]
		void FSKTEADFUCO();

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "17")]
		void EHJTZEZHXOJ(string a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public struct SyncData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public DDFOJMMWCEL player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public DSDVCCWMEAG context;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public string key;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public NetworkSetterPermissionMode permissionMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public bool enforceInitialValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public Action callback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public INJJPMNDUTS networkBacking;

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x9994180", Offset = "0x9992B80", VA = "0x189994180")]
		public SyncData(SyncData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x9994200", Offset = "0x9992C00", VA = "0x189994200")]
		public SyncData(DSDVCCWMEAG context, string key, NetworkSetterPermissionMode permissionMode, [Optional] Action callback, [Optional] INJJPMNDUTS networkBacking)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x9994130", Offset = "0x9992B30", VA = "0x189994130")]
		public static SyncData From(DSDVCCWMEAG context, string key, NetworkSetterPermissionMode permissionMode, [Optional] Action callback, [Optional] INJJPMNDUTS networkBacking)
		{
			return default(SyncData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public static class UOKHGJMREOR
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x408FA40", Offset = "0x408E440", VA = "0x18408FA40")]
		public static MRXGQCQLMGZ<a> BKVGBBESOLE<a>(this SyncData a, a b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x408E940", Offset = "0x408D340", VA = "0x18408E940")]
		public static MRHLYIITJYY<b, c> BKVGBBESOLE<b, c>(this SyncData a, b b, c c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x408E9E0", Offset = "0x408D3E0", VA = "0x18408E9E0")]
		public static MRMSVPCQTKH<d, e, f> BKVGBBESOLE<d, e, f>(this SyncData a, d b, e c, f d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x408F4F0", Offset = "0x408DEF0", VA = "0x18408F4F0")]
		public static MQWYDUUYRCG<g, h, i, j> BKVGBBESOLE<g, h, i, j>(this SyncData a, g b, h c, i d, j e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x408FCC0", Offset = "0x408E6C0", VA = "0x18408FCC0")]
		public static YZPEHXXYCZC<k> INTEZRNUAZV<k>(this SyncData a, k b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x408FB70", Offset = "0x408E570", VA = "0x18408FB70")]
		public static ZAEYZSFQFHD<l, m> INTEZRNUAZV<l, m>(this SyncData a, l b, m c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x408FC10", Offset = "0x408E610", VA = "0x18408FC10")]
		public static YZZSCLLSVVU<n, o, p> INTEZRNUAZV<n, o, p>(this SyncData a, n b, o c, p d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x408FF90", Offset = "0x408E990", VA = "0x18408FF90")]
		public static YYZJQDQGARB<q, r, s, t> INTEZRNUAZV<q, r, s, t>(this SyncData a, q b, r c, s d, t e)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public abstract class BKVGBBESOLE : IATHQHSNSXK, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[Flags]
		private enum Flags
		{
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			Disposed = 1,
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			LastSetLocally = 2,
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			Synchronizing = 4,
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			ModifiedOffline = 8,
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			Default = 4
		}

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private static Stack<INJJPMNDUTS> KZOLTODRAVO;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static bool RGEQHDFOETV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		protected readonly DDFOJMMWCEL KVMXBTYSGGR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		protected readonly DSDVCCWMEAG SZKFOUDUREX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		protected readonly string YVOBJQTFQPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		protected readonly NetworkSetterPermissionMode JPHWBFGRXPW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		protected readonly Action NOJJNBVDIQT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		protected INJJPMNDUTS MINCCMLFXZN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private Flags JNWDLXQRNSD;

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public static INJJPMNDUTS TWTRNOROXOI
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x9992A10", Offset = "0x9991410", VA = "0x189992A10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		private bool JBLGJXYZHUY
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x9993D90", Offset = "0x9992790", VA = "0x189993D90")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x99928A0", Offset = "0x99912A0", VA = "0x1899928A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		private bool LUMRGQPRRDB
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x9993660", Offset = "0x9992060", VA = "0x189993660")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x9993DC0", Offset = "0x99927C0", VA = "0x189993DC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		private bool MIZOJCNEBCG
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x9992BF0", Offset = "0x99915F0", VA = "0x189992BF0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x9993230", Offset = "0x9991C30", VA = "0x189993230")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public bool IKQSTLUOMMB
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x99935F0", Offset = "0x9991FF0", VA = "0x1899935F0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x9992CC0", Offset = "0x99916C0", VA = "0x189992CC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		protected virtual object FJFTLXBUGFZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0xCF42E0", Offset = "0xCF2CE0", VA = "0x180CF42E0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0xCF4510", Offset = "0xCF2F10", VA = "0x180CF4510", Slot = "8")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public bool TJPGVZTBZOC
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x99927D0", Offset = "0x99911D0", VA = "0x1899927D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public int UHTJVRPDYJD
		{
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0xEEF700", Offset = "0xEEE100", VA = "0x180EEF700")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x1AA8FD0", Offset = "0x1AA79D0", VA = "0x181AA8FD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public string OTIUDMTTUGL
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0xCF1D90", Offset = "0xCF0790", VA = "0x180CF1D90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public bool ZALDBGGFNHL
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x9992C70", Offset = "0x9991670", VA = "0x189992C70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x9992F50", Offset = "0x9991950", VA = "0x189992F50")]
		public static void JSAQTBBMHZT(INJJPMNDUTS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(Slot = "9")]
		protected abstract bool AUBWNTYAGOH();

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x9993E80", Offset = "0x9992880", VA = "0x189993E80")]
		protected BKVGBBESOLE(DDFOJMMWCEL a, DSDVCCWMEAG b, string c, NetworkSetterPermissionMode d, Action e, INJJPMNDUTS f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x9992C10", Offset = "0x9991610", VA = "0x189992C10", Slot = "1")]
		~BKVGBBESOLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x9992A80", Offset = "0x9991480", VA = "0x189992A80", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x9993250", Offset = "0x9991C50", VA = "0x189993250")]
		private void MROJWKZBKXX(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x9993670", Offset = "0x9992070", VA = "0x189993670")]
		private object SONCQFWGMCH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x9992D80", Offset = "0x9991780", VA = "0x189992D80")]
		protected void Initialize(bool enforceInitialValue, object initialValue, bool initialValueIsDefaultValue = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x99937E0", Offset = "0x99921E0", VA = "0x1899937E0")]
		protected void Set(object newValue, bool checkPermission = true, bool suppressCallback = false, bool requireModified = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x9993B40", Offset = "0x9992540", VA = "0x189993B40")]
		protected void WJDJLMFFZEM(object a, bool b, bool c, bool d = false, bool e = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x9992820", Offset = "0x9991220", VA = "0x189992820")]
		internal void BYECBTFIBDE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x99932F0", Offset = "0x9991CF0", VA = "0x1899932F0")]
		private void NXWHRYHKLEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x9993600", Offset = "0x9992000", VA = "0x189993600")]
		private void RUREOGWMCXV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x9992FF0", Offset = "0x99919F0", VA = "0x189992FF0", Slot = "4")]
		private void JZJUYOLIBRN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x99927C0", Offset = "0x99911C0", VA = "0x1899927C0", Slot = "5")]
		private void AJIYHVVCUCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x9993060", Offset = "0x9991A60", VA = "0x189993060")]
		public bool KPHLSQIVQTC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x9993350", Offset = "0x9991D50", VA = "0x189993350")]
		public bool OHMRHPESIFY()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x99928C0", Offset = "0x99912C0", VA = "0x1899928C0")]
		private bool CPPWXMLYUVT()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x9993A90", Offset = "0x9992490", VA = "0x189993A90")]
		internal void UWJBIPSPUIO(object a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x9993980", Offset = "0x9992380", VA = "0x189993980")]
		private void UOCZVHPWLSS(object a, bool b, bool c = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x9992C00", Offset = "0x9991600", VA = "0x189992C00")]
		private bool EDPJOESVZDM(Flags a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x9993DA0", Offset = "0x99927A0", VA = "0x189993DA0")]
		private void ZLMHSDXCQHM(Flags a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x99931A0", Offset = "0x9991BA0", VA = "0x1899931A0")]
		public static string LFZZJUBKLVK(DDFOJMMWCEL a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x9993510", Offset = "0x9991F10", VA = "0x189993510")]
		public static string PEIEPUXURCQ(DSDVCCWMEAG a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x9993820", Offset = "0x9992220", VA = "0x189993820")]
		public static bool TTAIXBUERDA(object a, object b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public abstract class UMMYAHVZXAE : INJJPMNDUTS, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly Dictionary<object, object> ZBSCUKTILYB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly List<string> TIFSMOLQUIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly Dictionary<object, object> YDPJKRRRUPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly List<string> SFCTBHHRPLX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private bool INFOAPNSOCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		protected readonly Dictionary<string, object> HXYUJPZABVT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		protected readonly Dictionary<DDFOJMMWCEL, Dictionary<string, object>> SEUOFQHCQTV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly HashSet<string> SZBMOSMXGXE;

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public abstract Dictionary<object, object> ZSDDYGWCKTU
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(Slot = "23")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public abstract int HLLBNLNSYEP
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(Slot = "24")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public abstract DDFOJMMWCEL SJQDIJZJGRA
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(Slot = "25")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public abstract bool ZALDBGGFNHL
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(Slot = "26")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public abstract bool RXQOZDWSMOM
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(Slot = "27")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public virtual bool RIKGOXGSTUL
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0xD09BA0", Offset = "0xD085A0", VA = "0x180D09BA0", Slot = "28")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public bool OQIZMMIKYRN
		{
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0xD4DD70", Offset = "0xD4C770", VA = "0x180D4DD70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x408CDC0", Offset = "0x408B7C0", VA = "0x18408CDC0", Slot = "12")]
		public void UJQARUJTJYH<a>(string a, a b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x99961E0", Offset = "0x9994BE0", VA = "0x1899961E0", Slot = "11")]
		public void SFUJJSZVOKW(DDFOJMMWCEL a, string b, object c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x99951F0", Offset = "0x9993BF0", VA = "0x1899951F0", Slot = "9")]
		public object INRZJAOHFFQ(DDFOJMMWCEL a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x9996850", Offset = "0x9995250", VA = "0x189996850", Slot = "10")]
		public void ZVCCBKYJFYE(string a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x9995150", Offset = "0x9993B50", VA = "0x189995150", Slot = "8")]
		public object IGIEWJJCYZS(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x99944C0", Offset = "0x9992EC0", VA = "0x1899944C0", Slot = "13")]
		public void DMCUZCCFLUN(DDFOJMMWCEL a, string b, BKVGBBESOLE c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x9996330", Offset = "0x9994D30", VA = "0x189996330", Slot = "14")]
		public void URNYJZOSFKE(DDFOJMMWCEL a, string b, BKVGBBESOLE c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x99953D0", Offset = "0x9993DD0", VA = "0x1899953D0")]
		private void IYHIPNWULPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x99949C0", Offset = "0x99933C0", VA = "0x1899949C0")]
		private void FDCRMVGNNAS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x9994460", Offset = "0x9992E60", VA = "0x189994460")]
		private void DGYHKOASZCN(DDFOJMMWCEL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x9995030", Offset = "0x9993A30", VA = "0x189995030")]
		protected void HFLKSOERPEF(DDFOJMMWCEL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x99952E0", Offset = "0x9993CE0", VA = "0x1899952E0")]
		protected void ITPSPMKPEET()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x99949B0", Offset = "0x99933B0", VA = "0x1899949B0")]
		protected void EWQBWMAZIST(IDictionary<object, object> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x9996070", Offset = "0x9994A70", VA = "0x189996070")]
		protected void SCHKDTACIPT(DDFOJMMWCEL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x9994C10", Offset = "0x9993610", VA = "0x189994C10")]
		protected void FOACIAAMOEJ(DDFOJMMWCEL a, IDictionary<object, object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x9995A30", Offset = "0x9994430", VA = "0x189995A30")]
		private void QHNOWFHXKEE(IDictionary<object, object> a, Dictionary<string, object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x9994A10", Offset = "0x9993410", VA = "0x189994A10")]
		private static void FNPPWJREDVS(object a, object b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x9994D80", Offset = "0x9993780", VA = "0x189994D80")]
		private static void FWUXZWKXQAP(Dictionary<string, object> a, string b, BKVGBBESOLE c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x9995EA0", Offset = "0x99948A0", VA = "0x189995EA0")]
		private static void QVZWANBMXLI(Dictionary<string, object> a, string b, BKVGBBESOLE c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x99960E0", Offset = "0x9994AE0", VA = "0x1899960E0", Slot = "19")]
		public void SEULCQDQNKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(Slot = "29")]
		protected abstract void HERODHXWYTH(Dictionary<object, object> a);

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x9994CA0", Offset = "0x99936A0", VA = "0x189994CA0", Slot = "20")]
		public void FSKTEADFUCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "30")]
		protected abstract void GSDNAEUYEAH(Dictionary<object, object> a);

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x9995810", Offset = "0x9994210", VA = "0x189995810")]
		private void NFHXTBZWPNA(Dictionary<object, object> a, List<string> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x99965D0", Offset = "0x9994FD0", VA = "0x1899965D0")]
		private void ZMCNNYLJNNJ(IDictionary<object, object> a, [Out] int b, [Out] string[] c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x9994FA0", Offset = "0x99939A0", VA = "0x189994FA0")]
		public void GQZAPECVTQI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x9994390", Offset = "0x9992D90", VA = "0x189994390")]
		public void AJRSCCVENEE(DDFOJMMWCEL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x9995420", Offset = "0x9993E20", VA = "0x189995420")]
		public void KUFTWQTYCTZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "31")]
		protected abstract HashSet<int> THCRZFFBIHX(bool a, bool b);

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x9994730", Offset = "0x9993130", VA = "0x189994730", Slot = "21")]
		public void EHJTZEZHXOJ(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x9995780", Offset = "0x9994180", VA = "0x189995780")]
		protected string LFZZJUBKLVK(DDFOJMMWCEL a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "32")]
		public abstract object BVYGVRSRQPX<b>(b a);

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "33")]
		public abstract c GQBIWFKLTBK<c>(object a);

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(Slot = "34")]
		public abstract object BVYGVRSRQPX(object a, Type b);

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(Slot = "35")]
		public abstract object GQBIWFKLTBK(object a, Type b);

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEE930", VA = "0x180CEFF30", Slot = "36")]
		public virtual void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x99945D0", Offset = "0x9992FD0", VA = "0x1899945D0", Slot = "22")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEE930", VA = "0x180CEFF30", Slot = "37")]
		protected virtual void WCFLDSFNRII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x9996970", Offset = "0x9995370", VA = "0x189996970")]
		protected UMMYAHVZXAE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public abstract class BQMBDSTWEOA<a> : BKVGBBESOLE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private a QNYOXKQGFXP;

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		protected virtual a WRMRMCLDLWK
		{
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x4F7E0B0", Offset = "0x4F7CAB0", VA = "0x184F7E0B0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x4F7DEE0", Offset = "0x4F7C8E0", VA = "0x184F7DEE0", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		protected override object FJFTLXBUGFZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x4F67D60", Offset = "0x4F66760", VA = "0x184F67D60", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x4F7EF20", Offset = "0x4F7D920", VA = "0x184F7EF20", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x4F7D1A0", Offset = "0x4F7BBA0", VA = "0x184F7D1A0", Slot = "9")]
		protected override bool AUBWNTYAGOH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x4F86410", Offset = "0x4F84E10", VA = "0x184F86410")]
		protected BQMBDSTWEOA([In] SyncData data, a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x4F83E70", Offset = "0x4F82870", VA = "0x184F83E70")]
		protected BQMBDSTWEOA(DDFOJMMWCEL a, DSDVCCWMEAG b, string c, a d, NetworkSetterPermissionMode e, bool f, Action g, INJJPMNDUTS h)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x4F69050", Offset = "0x4F67A50", VA = "0x184F69050")]
		public a Get()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x4F81DD0", Offset = "0x4F807D0", VA = "0x184F81DD0")]
		public void Set(a newValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x4F82770", Offset = "0x4F81170", VA = "0x184F82770")]
		public void Set(a newValue, bool checkPermission, bool suppressCallback = false, bool requireModified = true)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public abstract class BRBVVNBOGWB<a, b> : BKVGBBESOLE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private a QNYOXKQGFXP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private b QNIUFQIODPO;

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		protected virtual a WRMRMCLDLWK
		{
			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x10EAB40", Offset = "0x10E9540", VA = "0x1810EAB40", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x12B9B00", Offset = "0x12B8500", VA = "0x1812B9B00", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		protected virtual b WRHKOVRGCLB
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x327ED40", Offset = "0x327D740", VA = "0x18327ED40", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x4F93910", Offset = "0x4F92310", VA = "0x184F93910", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public b FESMFKXTIDR
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x1723F20", Offset = "0x1722920", VA = "0x181723F20")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		protected override object FJFTLXBUGFZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x4F67D60", Offset = "0x4F66760", VA = "0x184F67D60", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x4F95400", Offset = "0x4F93E00", VA = "0x184F95400", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x4F92750", Offset = "0x4F91150", VA = "0x184F92750", Slot = "9")]
		protected override bool AUBWNTYAGOH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x4F9A460", Offset = "0x4F98E60", VA = "0x184F9A460")]
		protected BRBVVNBOGWB([In] SyncData data, a a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x4F9C250", Offset = "0x4F9AC50", VA = "0x184F9C250")]
		protected BRBVVNBOGWB(DDFOJMMWCEL a, DSDVCCWMEAG b, string c, a d, b e, NetworkSetterPermissionMode f, bool g, Action h, INJJPMNDUTS i)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x4F69050", Offset = "0x4F67A50", VA = "0x184F69050")]
		public a RMEJWJXBKOL()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x4F940D0", Offset = "0x4F92AD0", VA = "0x184F940D0")]
		public void JDOBNPXRLJF(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x1723F20", Offset = "0x1722920", VA = "0x181723F20")]
		public b RMJQTQQYTZU()
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x4F94BA0", Offset = "0x4F935A0", VA = "0x184F94BA0")]
		public void JDTIKWROUUO(b a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x4F96FE0", Offset = "0x4F959E0", VA = "0x184F96FE0")]
		public void Set(a newValue1, b newValue2, bool checkPermission = true, bool suppressCallback = false, bool requireModified = true)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public abstract class BQWOYGHQXKS<a, b, c> : BKVGBBESOLE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private a QNYOXKQGFXP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private b QNIUFQIODPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private c QNOBCXCLNAX;

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		protected virtual a WRMRMCLDLWK
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0xD00E90", Offset = "0xCFF890", VA = "0x180D00E90", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0xD006E0", Offset = "0xCFF0E0", VA = "0x180D006E0", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		protected virtual b WRHKOVRGCLB
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0xED3CB0", Offset = "0xED26B0", VA = "0x180ED3CB0", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x2AB0370", Offset = "0x2AAED70", VA = "0x182AB0370", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		protected virtual c WRCDROXISZS
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0xCEE720", Offset = "0xCED120", VA = "0x180CEE720", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return (c)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0xCEE730", Offset = "0xCED130", VA = "0x180CEE730", Slot = "15")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public a FEXTCRRQRPA
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x4F69050", Offset = "0x4F67A50", VA = "0x184F69050")]
			get
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public b FESMFKXTIDR
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x1723F20", Offset = "0x1722920", VA = "0x181723F20")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public c FENFIEDVYSI
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x4F691F0", Offset = "0x4F67BF0", VA = "0x184F691F0")]
			get
			{
				return (c)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		protected override object FJFTLXBUGFZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x4F67D60", Offset = "0x4F66760", VA = "0x184F67D60", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x4F8AF10", Offset = "0x4F89910", VA = "0x184F8AF10", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x4F87BE0", Offset = "0x4F865E0", VA = "0x184F87BE0", Slot = "9")]
		protected override bool AUBWNTYAGOH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x4F91290", Offset = "0x4F8FC90", VA = "0x184F91290")]
		protected BQWOYGHQXKS([In] SyncData data, a a, b b, c c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x4F900B0", Offset = "0x4F8EAB0", VA = "0x184F900B0")]
		protected BQWOYGHQXKS(DDFOJMMWCEL a, DSDVCCWMEAG b, string c, a d, b e, c f, NetworkSetterPermissionMode g, bool h, Action i, INJJPMNDUTS j)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x4F69050", Offset = "0x4F67A50", VA = "0x184F69050")]
		public a RMEJWJXBKOL()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x4F89150", Offset = "0x4F87B50", VA = "0x184F89150")]
		public void JDOBNPXRLJF(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x1723F20", Offset = "0x1722920", VA = "0x181723F20")]
		public b RMJQTQQYTZU()
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x4F89DE0", Offset = "0x4F887E0", VA = "0x184F89DE0")]
		public void JDTIKWROUUO(b a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x4F691F0", Offset = "0x4F67BF0", VA = "0x184F691F0")]
		public c RMOXQXKWDLD()
		{
			return (c)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x4F8A910", Offset = "0x4F89310", VA = "0x184F8A910")]
		public void JDYPIDLMEFX(c a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x4F8E600", Offset = "0x4F8D000", VA = "0x184F8E600")]
		public void Set(a newValue1, b newValue2, c newValue3, bool checkPermission = true)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public abstract class BPWGLYMECFZ<a, b, c, d> : BKVGBBESOLE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private a QNYOXKQGFXP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private b QNIUFQIODPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private c QNOBCXCLNAX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private d QOOJPEXYIFQ;

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		protected virtual a WRMRMCLDLWK
		{
			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0xF4D0A0", Offset = "0xF4BAA0", VA = "0x180F4D0A0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x4F65200", Offset = "0x4F63C00", VA = "0x184F65200", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		protected virtual b WRHKOVRGCLB
		{
			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x1491440", Offset = "0x148FE40", VA = "0x181491440", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x1490550", Offset = "0x148EF50", VA = "0x181490550", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		protected virtual c WRCDROXISZS
		{
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x1513A10", Offset = "0x1512410", VA = "0x181513A10", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return (c)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x4F6EF30", Offset = "0x4F6D930", VA = "0x184F6EF30", Slot = "15")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		protected virtual d WQWWUIDLJOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x1D44B60", Offset = "0x1D43560", VA = "0x181D44B60", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return (d)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x166DBD0", Offset = "0x166C5D0", VA = "0x18166DBD0", Slot = "17")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public b FESMFKXTIDR
		{
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x4F69110", Offset = "0x4F67B10", VA = "0x184F69110")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public c FENFIEDVYSI
		{
			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0x4F6D490", Offset = "0x4F6BE90", VA = "0x184F6D490")]
			get
			{
				return (c)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public d FEHYKXJYPGZ
		{
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x15C9470", Offset = "0x15C7E70", VA = "0x1815C9470")]
			get
			{
				return (d)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		protected override object FJFTLXBUGFZ
		{
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0x4F67D60", Offset = "0x4F66760", VA = "0x184F67D60", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0x4F72100", Offset = "0x4F70B00", VA = "0x184F72100", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x4F6DA20", Offset = "0x4F6C420", VA = "0x184F6DA20", Slot = "9")]
		protected override bool AUBWNTYAGOH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x4F78340", Offset = "0x4F76D40", VA = "0x184F78340")]
		protected BPWGLYMECFZ([In] SyncData data, a a, b b, c c, d d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x4F76A20", Offset = "0x4F75420", VA = "0x184F76A20")]
		protected BPWGLYMECFZ(DDFOJMMWCEL a, DSDVCCWMEAG b, string c, a d, b e, c f, d g, NetworkSetterPermissionMode h, bool i, Action j, INJJPMNDUTS k)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x4F69050", Offset = "0x4F67A50", VA = "0x184F69050")]
		public a RMEJWJXBKOL()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x4F6F870", Offset = "0x4F6E270", VA = "0x184F6F870")]
		public void JDOBNPXRLJF(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x4F69110", Offset = "0x4F67B10", VA = "0x184F69110")]
		public b RMJQTQQYTZU()
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x4F70430", Offset = "0x4F6EE30", VA = "0x184F70430")]
		public void JDTIKWROUUO(b a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x4F6D490", Offset = "0x4F6BE90", VA = "0x184F6D490")]
		public c RMOXQXKWDLD()
		{
			return (c)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x4F70D20", Offset = "0x4F6F720", VA = "0x184F70D20")]
		public void JDYPIDLMEFX(c a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x15C9470", Offset = "0x15C7E70", VA = "0x1815C9470")]
		public d RLEBKCBOPJS()
		{
			return (d)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x4F710C0", Offset = "0x4F6FAC0", VA = "0x184F710C0")]
		public void JEDWFKFJNRG(d a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x4F73EA0", Offset = "0x4F728A0", VA = "0x184F73EA0")]
		public void Set(a newValue1, b newValue2, c newValue3, d newValue4, bool checkPermission = true)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public abstract class BPQZORSGSUQ<a, b, c, d, e> : BKVGBBESOLE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private a QNYOXKQGFXP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private b QNIUFQIODPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private c QNOBCXCLNAX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private d QOOJPEXYIFQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private e QOTQMLRVRQZ;

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		protected virtual a WRMRMCLDLWK
		{
			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0xD00E90", Offset = "0xCFF890", VA = "0x180D00E90", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0xD006E0", Offset = "0xCFF0E0", VA = "0x180D006E0", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		protected virtual b WRHKOVRGCLB
		{
			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0xDE6620", Offset = "0xDE5020", VA = "0x180DE6620", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0x14A5D80", Offset = "0x14A4780", VA = "0x1814A5D80", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		protected virtual c WRCDROXISZS
		{
			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0xE0C5C0", Offset = "0xE0AFC0", VA = "0x180E0C5C0", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return (c)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0xE0CDC0", Offset = "0xE0B7C0", VA = "0x180E0CDC0", Slot = "15")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		protected virtual d WQWWUIDLJOJ
		{
			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(RVA = "0xD09F60", Offset = "0xD08960", VA = "0x180D09F60", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return (d)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0xD1A000", Offset = "0xD18A00", VA = "0x180D1A000", Slot = "17")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		protected virtual e WQRPXBJOADA
		{
			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0xD09BB0", Offset = "0xD085B0", VA = "0x180D09BB0", Slot = "18")]
			[CompilerGenerated]
			get
			{
				return (e)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x4F651F0", Offset = "0x4F63BF0", VA = "0x184F651F0", Slot = "19")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		protected override object FJFTLXBUGFZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x4F67D60", Offset = "0x4F66760", VA = "0x184F67D60", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x4F68000", Offset = "0x4F66A00", VA = "0x184F68000", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x4F64050", Offset = "0x4F62A50", VA = "0x184F64050", Slot = "9")]
		protected override bool AUBWNTYAGOH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x4F6C430", Offset = "0x4F6AE30", VA = "0x184F6C430")]
		protected BPQZORSGSUQ(DDFOJMMWCEL a, DSDVCCWMEAG b, string c, a d, b e, c f, d g, e h, NetworkSetterPermissionMode i, bool j, Action k, INJJPMNDUTS l)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x4F69050", Offset = "0x4F67A50", VA = "0x184F69050")]
		public a RMEJWJXBKOL()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x4F658A0", Offset = "0x4F642A0", VA = "0x184F658A0")]
		public void JDOBNPXRLJF(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x1723F20", Offset = "0x1722920", VA = "0x181723F20")]
		public b RMJQTQQYTZU()
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x4F65FF0", Offset = "0x4F649F0", VA = "0x184F65FF0")]
		public void JDTIKWROUUO(b a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x4F691F0", Offset = "0x4F67BF0", VA = "0x184F691F0")]
		public c RMOXQXKWDLD()
		{
			return (c)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x4F66750", Offset = "0x4F65150", VA = "0x184F66750")]
		public void JDYPIDLMEFX(c a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x15C9470", Offset = "0x15C7E70", VA = "0x1815C9470")]
		public d RLEBKCBOPJS()
		{
			return (d)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x4F67520", Offset = "0x4F65F20", VA = "0x184F67520")]
		public void JEDWFKFJNRG(d a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x4F68F90", Offset = "0x4F67990", VA = "0x184F68F90")]
		public e RLJIHIVLYVB()
		{
			return (e)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x4F67600", Offset = "0x4F66000", VA = "0x184F67600")]
		public void JEJDCQZGXCP(e a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x4F69E60", Offset = "0x4F68860", VA = "0x184F69E60")]
		public void Set(a newValue1, b newValue2, c newValue3, d newValue4, e newValue5)
		{
		}
	}
}
namespace Cpp2IlInjected
{
	internal class AddressAttribute : Attribute
	{
		public string RVA;

		public string Offset;

		public string VA;

		public string Slot;
	}
	internal class FieldOffsetAttribute : Attribute
	{
		public string Offset;
	}
	internal class AttributeAttribute : Attribute
	{
		public string Name;

		public string RVA;

		public string Offset;
	}
	internal class MetadataOffsetAttribute : Attribute
	{
		public string Offset;
	}
	internal class TokenAttribute : Attribute
	{
		public string Token;
	}
	internal class AnalysisFailedException : Exception
	{
		public AnalysisFailedException(string message)
			: base(message)
		{
		}
	}
}
