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
			[Cpp2IlInjected.Address(RVA = "0xF9FC40", Offset = "0xF9EC40", VA = "0x180F9FC40", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool RWZZXBCMNZJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x517BC70", Offset = "0x517AC70", VA = "0x18517BC70", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public a ZZOCBIPDATE
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x517C480", Offset = "0x517B480", VA = "0x18517C480", Slot = "11")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x517E240", Offset = "0x517D240", VA = "0x18517E240", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public a IYPENRGWRFX
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x517C360", Offset = "0x517B360", VA = "0x18517C360", Slot = "4")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x517F1C0", Offset = "0x517E1C0", VA = "0x18517F1C0", Slot = "13")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public a YMGSSSXYISN
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x517C360", Offset = "0x517B360", VA = "0x18517C360")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x517C5D0", Offset = "0x517B5D0", VA = "0x18517C5D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool IKQSTLUOMMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x517A200", Offset = "0x5179200", VA = "0x18517A200", Slot = "7")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x5179CE0", Offset = "0x5178CE0", VA = "0x185179CE0", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool ZALDBGGFNHL
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x517C210", Offset = "0x517B210", VA = "0x18517C210")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x517E930", Offset = "0x517D930", VA = "0x18517E930", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x51817B0", Offset = "0x51807B0", VA = "0x1851817B0")]
		public YZPEHXXYCZC([In] SyncData data, a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x517F990", Offset = "0x517E990", VA = "0x18517F990")]
		private void WEJETJMVVZV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5180150", Offset = "0x517F150", VA = "0x185180150", Slot = "5")]
		public void XUACCGNRNOU(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5180270", Offset = "0x517F270", VA = "0x185180270")]
		public void XUACCGNRNOU(a a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x51798F0", Offset = "0x51788F0", VA = "0x1851798F0", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0xF9FC40", Offset = "0xF9EC40", VA = "0x180F9FC40", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool RWZZXBCMNZJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x518C290", Offset = "0x518B290", VA = "0x18518C290", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool KTOGMYYRCUK
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x518B150", Offset = "0x518A150", VA = "0x18518B150")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool KTIZPSETTJB
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x518AEE0", Offset = "0x5189EE0", VA = "0x18518AEE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public (a, b) ZZOCBIPDATE
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x518D6B0", Offset = "0x518C6B0", VA = "0x18518D6B0", Slot = "11")]
			get
			{
				return default((a, b));
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x518E2C0", Offset = "0x518D2C0", VA = "0x18518E2C0", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public (a, b) IYPENRGWRFX
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x518CD30", Offset = "0x518BD30", VA = "0x18518CD30", Slot = "4")]
			get
			{
				return default((a, b));
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x5190490", Offset = "0x518F490", VA = "0x185190490", Slot = "13")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public (a, b) YMGSSSXYISN
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x518CA60", Offset = "0x518BA60", VA = "0x18518CA60")]
			get
			{
				return default((a, b));
			}
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x518DC30", Offset = "0x518CC30", VA = "0x18518DC30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public a NWWDTUVGLKB
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x518D360", Offset = "0x518C360", VA = "0x18518D360")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x518F890", Offset = "0x518E890", VA = "0x18518F890")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public a USMPQDVWBRW
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x518A990", Offset = "0x5189990", VA = "0x18518A990")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x518C390", Offset = "0x518B390", VA = "0x18518C390")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public a BPPAZGVHXGA
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x518A990", Offset = "0x5189990", VA = "0x18518A990")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x518BBC0", Offset = "0x518ABC0", VA = "0x18518BBC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public b NWGJCANOJCA
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x518D440", Offset = "0x518C440", VA = "0x18518D440")]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x518FB70", Offset = "0x518EB70", VA = "0x18518FB70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public b UTCKHYDODZX
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x518AB50", Offset = "0x5189B50", VA = "0x18518AB50")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public b BQEVRBCZZOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x518AB50", Offset = "0x5189B50", VA = "0x18518AB50")]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x518B390", Offset = "0x518A390", VA = "0x18518B390")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public bool IKQSTLUOMMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x517A200", Offset = "0x5179200", VA = "0x18517A200", Slot = "7")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x5179CE0", Offset = "0x5178CE0", VA = "0x185179CE0", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x518F500", Offset = "0x518E500", VA = "0x18518F500", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x51916D0", Offset = "0x51906D0", VA = "0x1851916D0")]
		public ZAEYZSFQFHD([In] SyncData data, a a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x5190590", Offset = "0x518F590", VA = "0x185190590")]
		private void WEJETJMVVZV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x518C9C0", Offset = "0x518B9C0", VA = "0x18518C9C0")]
		public void GDZPVSSGUMV(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x5190C90", Offset = "0x518FC90", VA = "0x185190C90")]
		public void XUACCGNRNOU(a a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x518ECF0", Offset = "0x518DCF0", VA = "0x18518ECF0", Slot = "5")]
		private void RMAPZCVOTWX((a, b) a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x51798F0", Offset = "0x51788F0", VA = "0x1851798F0", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0xF9FC40", Offset = "0xF9EC40", VA = "0x180F9FC40", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public bool RWZZXBCMNZJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x5186840", Offset = "0x5185840", VA = "0x185186840", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool KTOGMYYRCUK
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x5185D90", Offset = "0x5184D90", VA = "0x185185D90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public bool KTIZPSETTJB
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x5185890", Offset = "0x5184890", VA = "0x185185890")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public bool KTDSSLKWJXS
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x5185BD0", Offset = "0x5184BD0", VA = "0x185185BD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public (a, b, c) ZZOCBIPDATE
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x5187630", Offset = "0x5186630", VA = "0x185187630", Slot = "11")]
			get
			{
				return default((a, b, c));
			}
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x51881A0", Offset = "0x51871A0", VA = "0x1851881A0", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public (a, b, c) IYPENRGWRFX
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x51870C0", Offset = "0x51860C0", VA = "0x1851870C0", Slot = "4")]
			get
			{
				return default((a, b, c));
			}
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x5188EC0", Offset = "0x5187EC0", VA = "0x185188EC0", Slot = "13")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public a NWWDTUVGLKB
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x5187350", Offset = "0x5186350", VA = "0x185187350")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x5188680", Offset = "0x5187680", VA = "0x185188680")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public a USMPQDVWBRW
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x51856A0", Offset = "0x51846A0", VA = "0x1851856A0")]
			get
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public a BPPAZGVHXGA
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x51856A0", Offset = "0x51846A0", VA = "0x1851856A0")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x5186580", Offset = "0x5185580", VA = "0x185186580")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public b NWGJCANOJCA
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x5187510", Offset = "0x5186510", VA = "0x185187510")]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x5188B90", Offset = "0x5187B90", VA = "0x185188B90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public b UTCKHYDODZX
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x5185780", Offset = "0x5184780", VA = "0x185185780")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public b BQEVRBCZZOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x5185780", Offset = "0x5184780", VA = "0x185185780")]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x5186080", Offset = "0x5185080", VA = "0x185186080")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public c NWLPZHHLSNJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x5187380", Offset = "0x5186380", VA = "0x185187380")]
			get
			{
				return (c)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x5188950", Offset = "0x5187950", VA = "0x185188950")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public c USXDKRJQUOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x51857B0", Offset = "0x51847B0", VA = "0x1851857B0")]
			get
			{
				return (c)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public c BPZOTUJCQCS
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x51857B0", Offset = "0x51847B0", VA = "0x1851857B0")]
			get
			{
				return (c)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x5186330", Offset = "0x5185330", VA = "0x185186330")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool IKQSTLUOMMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x517A200", Offset = "0x5179200", VA = "0x18517A200", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x5188540", Offset = "0x5187540", VA = "0x185188540", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x518A000", Offset = "0x5189000", VA = "0x18518A000")]
		public YZZSCLLSVVU([In] SyncData data, a a, b b, c c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x51897A0", Offset = "0x51887A0", VA = "0x1851897A0")]
		private void WEJETJMVVZV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x5186C00", Offset = "0x5185C00", VA = "0x185186C00")]
		public void GDZPVSSGUMV(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x5189E80", Offset = "0x5188E80", VA = "0x185189E80")]
		public void ZAGJLWBDGFE(b a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x5185530", Offset = "0x5184530", VA = "0x185185530")]
		public void CPSKMFCHNWH(c a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x5189BC0", Offset = "0x5188BC0", VA = "0x185189BC0")]
		public void XUACCGNRNOU(a a, b b, c c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x5189280", Offset = "0x5188280", VA = "0x185189280", Slot = "5")]
		private void VPGGZFSNXGI((a, b, c) a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x51798F0", Offset = "0x51788F0", VA = "0x1851798F0", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0xF9FC40", Offset = "0xF9EC40", VA = "0x180F9FC40", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public (a, b, c, d) IYPENRGWRFX
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x5179D00", Offset = "0x5178D00", VA = "0x185179D00", Slot = "4")]
			get
			{
				return default((a, b, c, d));
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x517A9C0", Offset = "0x51799C0", VA = "0x18517A9C0", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public b UTCKHYDODZX
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x51797E0", Offset = "0x51787E0", VA = "0x1851797E0")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public c USXDKRJQUOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x5179810", Offset = "0x5178810", VA = "0x185179810")]
			get
			{
				return (c)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public d URWUYJODZJV
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x5179650", Offset = "0x5178650", VA = "0x185179650")]
			get
			{
				return (d)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool IKQSTLUOMMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x517A200", Offset = "0x5179200", VA = "0x18517A200", Slot = "7")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x5179CE0", Offset = "0x5178CE0", VA = "0x185179CE0", Slot = "10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x517B7B0", Offset = "0x517A7B0", VA = "0x18517B7B0")]
		public YYZJQDQGARB([In] SyncData data, a a, b b, c c, d d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x517AA10", Offset = "0x5179A10", VA = "0x18517AA10")]
		private void WEJETJMVVZV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x5179BF0", Offset = "0x5178BF0", VA = "0x185179BF0")]
		public void GDZPVSSGUMV(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x517ADB0", Offset = "0x5179DB0", VA = "0x18517ADB0")]
		public void XUACCGNRNOU(a a, b b, c c, d d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x517A220", Offset = "0x5179220", VA = "0x18517A220", Slot = "5")]
		private void QZRVRVLARXU((a, b, c, d) a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x51798F0", Offset = "0x51788F0", VA = "0x1851798F0", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x9B36E20", Offset = "0x9B35E20", VA = "0x189B36E20")]
		public static string CARFOTRAMKU(this SyncData a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xD756C0", Offset = "0xD746C0", VA = "0x180D756C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7034C50", Offset = "0x7033C50", VA = "0x187034C50")]
		public MRXGQCQLMGZ([In] SyncData data, a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x7032FD0", Offset = "0x7031FD0", VA = "0x187032FD0")]
		public MRXGQCQLMGZ(DSDVCCWMEAG a, DDFOJMMWCEL b, string c, a d, NetworkSetterPermissionMode e, [Optional] Action f, [Optional] INJJPMNDUTS g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x7031A70", Offset = "0x7030A70", VA = "0x187031A70")]
		public MRXGQCQLMGZ(DSDVCCWMEAG a, string b, a c, NetworkSetterPermissionMode d, [Optional] Action e, [Optional] INJJPMNDUTS f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7034340", Offset = "0x7033340", VA = "0x187034340")]
		public MRXGQCQLMGZ(DSDVCCWMEAG a, string b, a c, NetworkSetterPermissionMode d, bool e, [Optional] Action f, [Optional] INJJPMNDUTS g)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class MRHLYIITJYY<a, b> : BRBVVNBOGWB<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x702D7F0", Offset = "0x702C7F0", VA = "0x18702D7F0")]
		public MRHLYIITJYY([In] SyncData data, a a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x702CF60", Offset = "0x702BF60", VA = "0x18702CF60")]
		public MRHLYIITJYY(DSDVCCWMEAG a, DDFOJMMWCEL b, string c, a d, b e, NetworkSetterPermissionMode f, [Optional] Action g, [Optional] INJJPMNDUTS h)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x702EA40", Offset = "0x702DA40", VA = "0x18702EA40")]
		public MRHLYIITJYY(DSDVCCWMEAG a, string b, a c, b d, NetworkSetterPermissionMode e, [Optional] Action f, [Optional] INJJPMNDUTS g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x702B830", Offset = "0x702A830", VA = "0x18702B830")]
		public MRHLYIITJYY(DSDVCCWMEAG a, string b, a c, b d, NetworkSetterPermissionMode e, bool f, [Optional] Action g, [Optional] INJJPMNDUTS h)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class MRMSVPCQTKH<a, b, c> : BQWOYGHQXKS<a, b, c>
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x702FF90", Offset = "0x702EF90", VA = "0x18702FF90")]
		public MRMSVPCQTKH([In] SyncData data, a a, b b, c c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x7030430", Offset = "0x702F430", VA = "0x187030430")]
		public MRMSVPCQTKH(DSDVCCWMEAG a, string b, a c, b d, c e, NetworkSetterPermissionMode f, [Optional] Action g, [Optional] INJJPMNDUTS h)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class MQWYDUUYRCG<a, b, c, d> : BPWGLYMECFZ<a, b, c, d>
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x7027D70", Offset = "0x7026D70", VA = "0x187027D70")]
		public MQWYDUUYRCG([In] SyncData data, a a, b b, c c, d d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x7028610", Offset = "0x7027610", VA = "0x187028610")]
		public MQWYDUUYRCG(DSDVCCWMEAG a, DDFOJMMWCEL b, string c, a d, b e, c f, d g, NetworkSetterPermissionMode h, [Optional] Action i, [Optional] INJJPMNDUTS j)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x7028180", Offset = "0x7027180", VA = "0x187028180")]
		public MQWYDUUYRCG(DSDVCCWMEAG a, string b, a c, b d, c e, d f, NetworkSetterPermissionMode g, [Optional] Action h, [Optional] INJJPMNDUTS i)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class MRCFBBOWANP<a, b, c, d, e> : BPQZORSGSUQ<a, b, c, d, e>
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x702A080", Offset = "0x7029080", VA = "0x18702A080")]
		public MRCFBBOWANP(DSDVCCWMEAG a, DDFOJMMWCEL b, string c, a d, b e, c f, d g, e h, NetworkSetterPermissionMode i, [Optional] Action j, [Optional] INJJPMNDUTS k)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x702AE00", Offset = "0x7029E00", VA = "0x18702AE00")]
		public MRCFBBOWANP(DSDVCCWMEAG a, string b, a c, b d, c e, d f, e g, NetworkSetterPermissionMode h, [Optional] Action i, [Optional] INJJPMNDUTS j)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class MNSITLULKWC<a> : BQMBDSTWEOA<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x7023F10", Offset = "0x7022F10", VA = "0x187023F10")]
		public MNSITLULKWC(DDFOJMMWCEL a, string b, a c, [Optional] Action d, [Optional] INJJPMNDUTS e)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class MNNBWFAOBKT<a, b> : BRBVVNBOGWB<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x7022AA0", Offset = "0x7021AA0", VA = "0x187022AA0")]
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
		[Cpp2IlInjected.Address(RVA = "0xD0D9F0", Offset = "0xD0C9F0", VA = "0x180D0D9F0")]
		public VYIDZLVARYP(INJJPMNDUTS a, DSDVCCWMEAG b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x40E0B50", Offset = "0x40DFB50", VA = "0x1840E0B50", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x9B36DD0", Offset = "0x9B35DD0", VA = "0x189B36DD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9B36EB0", Offset = "0x9B35EB0", VA = "0x189B36EB0")]
		public SyncData(SyncData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x9B36F30", Offset = "0x9B35F30", VA = "0x189B36F30")]
		public SyncData(DSDVCCWMEAG context, string key, NetworkSetterPermissionMode permissionMode, [Optional] Action callback, [Optional] INJJPMNDUTS networkBacking)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x9B36E60", Offset = "0x9B35E60", VA = "0x189B36E60")]
		public static SyncData From(DSDVCCWMEAG context, string key, NetworkSetterPermissionMode permissionMode, [Optional] Action callback, [Optional] INJJPMNDUTS networkBacking)
		{
			return default(SyncData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public static class UOKHGJMREOR
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x40AC3F0", Offset = "0x40AB3F0", VA = "0x1840AC3F0")]
		public static MRXGQCQLMGZ<a> BKVGBBESOLE<a>(this SyncData a, a b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x40AB2F0", Offset = "0x40AA2F0", VA = "0x1840AB2F0")]
		public static MRHLYIITJYY<b, c> BKVGBBESOLE<b, c>(this SyncData a, b b, c c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x40AB390", Offset = "0x40AA390", VA = "0x1840AB390")]
		public static MRMSVPCQTKH<d, e, f> BKVGBBESOLE<d, e, f>(this SyncData a, d b, e c, f d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x40ABEA0", Offset = "0x40AAEA0", VA = "0x1840ABEA0")]
		public static MQWYDUUYRCG<g, h, i, j> BKVGBBESOLE<g, h, i, j>(this SyncData a, g b, h c, i d, j e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x40AC670", Offset = "0x40AB670", VA = "0x1840AC670")]
		public static YZPEHXXYCZC<k> INTEZRNUAZV<k>(this SyncData a, k b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x40AC520", Offset = "0x40AB520", VA = "0x1840AC520")]
		public static ZAEYZSFQFHD<l, m> INTEZRNUAZV<l, m>(this SyncData a, l b, m c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x40AC5C0", Offset = "0x40AB5C0", VA = "0x1840AC5C0")]
		public static YZZSCLLSVVU<n, o, p> INTEZRNUAZV<n, o, p>(this SyncData a, n b, o c, p d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x40AC940", Offset = "0x40AB940", VA = "0x1840AC940")]
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
			[Cpp2IlInjected.Address(RVA = "0x9B35740", Offset = "0x9B34740", VA = "0x189B35740")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		private bool JBLGJXYZHUY
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x9B36AC0", Offset = "0x9B35AC0", VA = "0x189B36AC0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x9B355D0", Offset = "0x9B345D0", VA = "0x189B355D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		private bool LUMRGQPRRDB
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x9B36390", Offset = "0x9B35390", VA = "0x189B36390")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x9B36AF0", Offset = "0x9B35AF0", VA = "0x189B36AF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		private bool MIZOJCNEBCG
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x9B35920", Offset = "0x9B34920", VA = "0x189B35920")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x9B35F60", Offset = "0x9B34F60", VA = "0x189B35F60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public bool IKQSTLUOMMB
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x9B36320", Offset = "0x9B35320", VA = "0x189B36320")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x9B359F0", Offset = "0x9B349F0", VA = "0x189B359F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		protected virtual object FJFTLXBUGFZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0xD0F390", Offset = "0xD0E390", VA = "0x180D0F390", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0xD0F5C0", Offset = "0xD0E5C0", VA = "0x180D0F5C0", Slot = "8")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public bool TJPGVZTBZOC
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x9B35500", Offset = "0x9B34500", VA = "0x189B35500")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public int UHTJVRPDYJD
		{
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0xF0AFC0", Offset = "0xF09FC0", VA = "0x180F0AFC0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x1AC5500", Offset = "0x1AC4500", VA = "0x181AC5500")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public string OTIUDMTTUGL
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0xD0CE10", Offset = "0xD0BE10", VA = "0x180D0CE10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public bool ZALDBGGFNHL
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x9B359A0", Offset = "0x9B349A0", VA = "0x189B359A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x9B35C80", Offset = "0x9B34C80", VA = "0x189B35C80")]
		public static void JSAQTBBMHZT(INJJPMNDUTS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(Slot = "9")]
		protected abstract bool AUBWNTYAGOH();

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x9B36BB0", Offset = "0x9B35BB0", VA = "0x189B36BB0")]
		protected BKVGBBESOLE(DDFOJMMWCEL a, DSDVCCWMEAG b, string c, NetworkSetterPermissionMode d, Action e, INJJPMNDUTS f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x9B35940", Offset = "0x9B34940", VA = "0x189B35940", Slot = "1")]
		~BKVGBBESOLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x9B357B0", Offset = "0x9B347B0", VA = "0x189B357B0", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x9B35F80", Offset = "0x9B34F80", VA = "0x189B35F80")]
		private void MROJWKZBKXX(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x9B363A0", Offset = "0x9B353A0", VA = "0x189B363A0")]
		private object SONCQFWGMCH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x9B35AB0", Offset = "0x9B34AB0", VA = "0x189B35AB0")]
		protected void Initialize(bool enforceInitialValue, object initialValue, bool initialValueIsDefaultValue = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x9B36510", Offset = "0x9B35510", VA = "0x189B36510")]
		protected void Set(object newValue, bool checkPermission = true, bool suppressCallback = false, bool requireModified = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x9B36870", Offset = "0x9B35870", VA = "0x189B36870")]
		protected void WJDJLMFFZEM(object a, bool b, bool c, bool d = false, bool e = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x9B35550", Offset = "0x9B34550", VA = "0x189B35550")]
		internal void BYECBTFIBDE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x9B36020", Offset = "0x9B35020", VA = "0x189B36020")]
		private void NXWHRYHKLEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x9B36330", Offset = "0x9B35330", VA = "0x189B36330")]
		private void RUREOGWMCXV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x9B35D20", Offset = "0x9B34D20", VA = "0x189B35D20", Slot = "4")]
		private void JZJUYOLIBRN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x9B354F0", Offset = "0x9B344F0", VA = "0x189B354F0", Slot = "5")]
		private void AJIYHVVCUCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x9B35D90", Offset = "0x9B34D90", VA = "0x189B35D90")]
		public bool KPHLSQIVQTC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x9B36080", Offset = "0x9B35080", VA = "0x189B36080")]
		public bool OHMRHPESIFY()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x9B355F0", Offset = "0x9B345F0", VA = "0x189B355F0")]
		private bool CPPWXMLYUVT()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x9B367C0", Offset = "0x9B357C0", VA = "0x189B367C0")]
		internal void UWJBIPSPUIO(object a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x9B366B0", Offset = "0x9B356B0", VA = "0x189B366B0")]
		private void UOCZVHPWLSS(object a, bool b, bool c = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x9B35930", Offset = "0x9B34930", VA = "0x189B35930")]
		private bool EDPJOESVZDM(Flags a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x9B36AD0", Offset = "0x9B35AD0", VA = "0x189B36AD0")]
		private void ZLMHSDXCQHM(Flags a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x9B35ED0", Offset = "0x9B34ED0", VA = "0x189B35ED0")]
		public static string LFZZJUBKLVK(DDFOJMMWCEL a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x9B36240", Offset = "0x9B35240", VA = "0x189B36240")]
		public static string PEIEPUXURCQ(DSDVCCWMEAG a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x9B36550", Offset = "0x9B35550", VA = "0x189B36550")]
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
			[Cpp2IlInjected.Address(RVA = "0xD24DB0", Offset = "0xD23DB0", VA = "0x180D24DB0", Slot = "28")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public bool OQIZMMIKYRN
		{
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0xD69190", Offset = "0xD68190", VA = "0x180D69190")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x40A9770", Offset = "0x40A8770", VA = "0x1840A9770", Slot = "12")]
		public void UJQARUJTJYH<a>(string a, a b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x9B38F10", Offset = "0x9B37F10", VA = "0x189B38F10", Slot = "11")]
		public void SFUJJSZVOKW(DDFOJMMWCEL a, string b, object c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x9B37F20", Offset = "0x9B36F20", VA = "0x189B37F20", Slot = "9")]
		public object INRZJAOHFFQ(DDFOJMMWCEL a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x9B39590", Offset = "0x9B38590", VA = "0x189B39590", Slot = "10")]
		public void ZVCCBKYJFYE(string a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x9B37E80", Offset = "0x9B36E80", VA = "0x189B37E80", Slot = "8")]
		public object IGIEWJJCYZS(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x9B371F0", Offset = "0x9B361F0", VA = "0x189B371F0", Slot = "13")]
		public void DMCUZCCFLUN(DDFOJMMWCEL a, string b, BKVGBBESOLE c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x9B39060", Offset = "0x9B38060", VA = "0x189B39060", Slot = "14")]
		public void URNYJZOSFKE(DDFOJMMWCEL a, string b, BKVGBBESOLE c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x9B38100", Offset = "0x9B37100", VA = "0x189B38100")]
		private void IYHIPNWULPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x9B376F0", Offset = "0x9B366F0", VA = "0x189B376F0")]
		private void FDCRMVGNNAS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x9B37190", Offset = "0x9B36190", VA = "0x189B37190")]
		private void DGYHKOASZCN(DDFOJMMWCEL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x9B37D60", Offset = "0x9B36D60", VA = "0x189B37D60")]
		protected void HFLKSOERPEF(DDFOJMMWCEL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x9B38010", Offset = "0x9B37010", VA = "0x189B38010")]
		protected void ITPSPMKPEET()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x9B376E0", Offset = "0x9B366E0", VA = "0x189B376E0")]
		protected void EWQBWMAZIST(IDictionary<object, object> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x9B38DA0", Offset = "0x9B37DA0", VA = "0x189B38DA0")]
		protected void SCHKDTACIPT(DDFOJMMWCEL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x9B37940", Offset = "0x9B36940", VA = "0x189B37940")]
		protected void FOACIAAMOEJ(DDFOJMMWCEL a, IDictionary<object, object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x9B38760", Offset = "0x9B37760", VA = "0x189B38760")]
		private void QHNOWFHXKEE(IDictionary<object, object> a, Dictionary<string, object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x9B37740", Offset = "0x9B36740", VA = "0x189B37740")]
		private static void FNPPWJREDVS(object a, object b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x9B37AB0", Offset = "0x9B36AB0", VA = "0x189B37AB0")]
		private static void FWUXZWKXQAP(Dictionary<string, object> a, string b, BKVGBBESOLE c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x9B38BD0", Offset = "0x9B37BD0", VA = "0x189B38BD0")]
		private static void QVZWANBMXLI(Dictionary<string, object> a, string b, BKVGBBESOLE c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x9B38E10", Offset = "0x9B37E10", VA = "0x189B38E10", Slot = "19")]
		public void SEULCQDQNKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(Slot = "29")]
		protected abstract void HERODHXWYTH(Dictionary<object, object> a);

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x9B379D0", Offset = "0x9B369D0", VA = "0x189B379D0", Slot = "20")]
		public void FSKTEADFUCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "30")]
		protected abstract void GSDNAEUYEAH(Dictionary<object, object> a);

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x9B38540", Offset = "0x9B37540", VA = "0x189B38540")]
		private void NFHXTBZWPNA(Dictionary<object, object> a, List<string> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x9B39310", Offset = "0x9B38310", VA = "0x189B39310")]
		private void ZMCNNYLJNNJ(IDictionary<object, object> a, [Out] int b, [Out] string[] c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x9B37CD0", Offset = "0x9B36CD0", VA = "0x189B37CD0")]
		public void GQZAPECVTQI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x9B370C0", Offset = "0x9B360C0", VA = "0x189B370C0")]
		public void AJRSCCVENEE(DDFOJMMWCEL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x9B38150", Offset = "0x9B37150", VA = "0x189B38150")]
		public void KUFTWQTYCTZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "31")]
		protected abstract HashSet<int> THCRZFFBIHX(bool a, bool b);

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x9B37460", Offset = "0x9B36460", VA = "0x189B37460", Slot = "21")]
		public void EHJTZEZHXOJ(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x9B384B0", Offset = "0x9B374B0", VA = "0x189B384B0")]
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
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "36")]
		public virtual void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x9B37300", Offset = "0x9B36300", VA = "0x189B37300", Slot = "22")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "37")]
		protected virtual void WCFLDSFNRII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x9B396B0", Offset = "0x9B386B0", VA = "0x189B396B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x4FC41C0", Offset = "0x4FC31C0", VA = "0x184FC41C0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x4FC41B0", Offset = "0x4FC31B0", VA = "0x184FC41B0", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		protected override object FJFTLXBUGFZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x4FB1D50", Offset = "0x4FB0D50", VA = "0x184FB1D50", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x4FC41D0", Offset = "0x4FC31D0", VA = "0x184FC41D0", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x4FC40E0", Offset = "0x4FC30E0", VA = "0x184FC40E0", Slot = "9")]
		protected override bool AUBWNTYAGOH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x4FC46C0", Offset = "0x4FC36C0", VA = "0x184FC46C0")]
		protected BQMBDSTWEOA([In] SyncData data, a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x4FC45C0", Offset = "0x4FC35C0", VA = "0x184FC45C0")]
		protected BQMBDSTWEOA(DDFOJMMWCEL a, DSDVCCWMEAG b, string c, a d, NetworkSetterPermissionMode e, bool f, Action g, INJJPMNDUTS h)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x4FB30D0", Offset = "0x4FB20D0", VA = "0x184FB30D0")]
		public a Get()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x4FC42F0", Offset = "0x4FC32F0", VA = "0x184FC42F0")]
		public void Set(a newValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x4FC4320", Offset = "0x4FC3320", VA = "0x184FC4320")]
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
			[Cpp2IlInjected.Address(RVA = "0x1106830", Offset = "0x1105830", VA = "0x181106830", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x12D5C70", Offset = "0x12D4C70", VA = "0x1812D5C70", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		protected virtual b WRHKOVRGCLB
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x3294CE0", Offset = "0x3293CE0", VA = "0x183294CE0", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x4FDEEE0", Offset = "0x4FDDEE0", VA = "0x184FDEEE0", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public b FESMFKXTIDR
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x173FB70", Offset = "0x173EB70", VA = "0x18173FB70")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		protected override object FJFTLXBUGFZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x4FB1D50", Offset = "0x4FB0D50", VA = "0x184FB1D50", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x4FE1130", Offset = "0x4FE0130", VA = "0x184FE1130", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x4FDDA00", Offset = "0x4FDCA00", VA = "0x184FDDA00", Slot = "9")]
		protected override bool AUBWNTYAGOH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x4FE72C0", Offset = "0x4FE62C0", VA = "0x184FE72C0")]
		protected BRBVVNBOGWB([In] SyncData data, a a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x4FE9120", Offset = "0x4FE8120", VA = "0x184FE9120")]
		protected BRBVVNBOGWB(DDFOJMMWCEL a, DSDVCCWMEAG b, string c, a d, b e, NetworkSetterPermissionMode f, bool g, Action h, INJJPMNDUTS i)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x4FB30D0", Offset = "0x4FB20D0", VA = "0x184FB30D0")]
		public a RMEJWJXBKOL()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x4FDFBB0", Offset = "0x4FDEBB0", VA = "0x184FDFBB0")]
		public void JDOBNPXRLJF(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x173FB70", Offset = "0x173EB70", VA = "0x18173FB70")]
		public b RMJQTQQYTZU()
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x4FE0890", Offset = "0x4FDF890", VA = "0x184FE0890")]
		public void JDTIKWROUUO(b a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x4FE31F0", Offset = "0x4FE21F0", VA = "0x184FE31F0")]
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
			[Cpp2IlInjected.Address(RVA = "0xD1C050", Offset = "0xD1B050", VA = "0x180D1C050", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0xD1B8A0", Offset = "0xD1A8A0", VA = "0x180D1B8A0", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		protected virtual b WRHKOVRGCLB
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0xEEF530", Offset = "0xEEE530", VA = "0x180EEF530", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x2AC7690", Offset = "0x2AC6690", VA = "0x182AC7690", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		protected virtual c WRCDROXISZS
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0xD09730", Offset = "0xD08730", VA = "0x180D09730", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return (c)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0xD09740", Offset = "0xD08740", VA = "0x180D09740", Slot = "15")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public a FEXTCRRQRPA
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x4FB30D0", Offset = "0x4FB20D0", VA = "0x184FB30D0")]
			get
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public b FESMFKXTIDR
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x173FB70", Offset = "0x173EB70", VA = "0x18173FB70")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public c FENFIEDVYSI
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x4FB3270", Offset = "0x4FB2270", VA = "0x184FB3270")]
			get
			{
				return (c)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		protected override object FJFTLXBUGFZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x4FB1D50", Offset = "0x4FB0D50", VA = "0x184FB1D50", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x4FD5D80", Offset = "0x4FD4D80", VA = "0x184FD5D80", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x4FD2900", Offset = "0x4FD1900", VA = "0x184FD2900", Slot = "9")]
		protected override bool AUBWNTYAGOH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x4FDC350", Offset = "0x4FDB350", VA = "0x184FDC350")]
		protected BQWOYGHQXKS([In] SyncData data, a a, b b, c c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x4FDB150", Offset = "0x4FDA150", VA = "0x184FDB150")]
		protected BQWOYGHQXKS(DDFOJMMWCEL a, DSDVCCWMEAG b, string c, a d, b e, c f, NetworkSetterPermissionMode g, bool h, Action i, INJJPMNDUTS j)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x4FB30D0", Offset = "0x4FB20D0", VA = "0x184FB30D0")]
		public a RMEJWJXBKOL()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x4FD3F30", Offset = "0x4FD2F30", VA = "0x184FD3F30")]
		public void JDOBNPXRLJF(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x173FB70", Offset = "0x173EB70", VA = "0x18173FB70")]
		public b RMJQTQQYTZU()
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x4FD4BF0", Offset = "0x4FD3BF0", VA = "0x184FD4BF0")]
		public void JDTIKWROUUO(b a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x4FB3270", Offset = "0x4FB2270", VA = "0x184FB3270")]
		public c RMOXQXKWDLD()
		{
			return (c)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x4FD5760", Offset = "0x4FD4760", VA = "0x184FD5760")]
		public void JDYPIDLMEFX(c a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x4FD9610", Offset = "0x4FD8610", VA = "0x184FD9610")]
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
			[Cpp2IlInjected.Address(RVA = "0xF68A10", Offset = "0xF67A10", VA = "0x180F68A10", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x4FAF0B0", Offset = "0x4FAE0B0", VA = "0x184FAF0B0", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		protected virtual b WRHKOVRGCLB
		{
			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x14AD8B0", Offset = "0x14AC8B0", VA = "0x1814AD8B0", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x14AC9C0", Offset = "0x14AB9C0", VA = "0x1814AC9C0", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		protected virtual c WRCDROXISZS
		{
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x1530030", Offset = "0x152F030", VA = "0x181530030", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return (c)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x4FB92A0", Offset = "0x4FB82A0", VA = "0x184FB92A0", Slot = "15")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		protected virtual d WQWWUIDLJOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x1D60C00", Offset = "0x1D5FC00", VA = "0x181D60C00", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return (d)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x1689730", Offset = "0x1688730", VA = "0x181689730", Slot = "17")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public b FESMFKXTIDR
		{
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x4FB3190", Offset = "0x4FB2190", VA = "0x184FB3190")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public c FENFIEDVYSI
		{
			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0x4FB7700", Offset = "0x4FB6700", VA = "0x184FB7700")]
			get
			{
				return (c)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public d FEHYKXJYPGZ
		{
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x15E54A0", Offset = "0x15E44A0", VA = "0x1815E54A0")]
			get
			{
				return (d)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		protected override object FJFTLXBUGFZ
		{
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0x4FB1D50", Offset = "0x4FB0D50", VA = "0x184FB1D50", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0x4FBC5C0", Offset = "0x4FBB5C0", VA = "0x184FBC5C0", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x4FB7CC0", Offset = "0x4FB6CC0", VA = "0x184FB7CC0", Slot = "9")]
		protected override bool AUBWNTYAGOH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x4FC2AD0", Offset = "0x4FC1AD0", VA = "0x184FC2AD0")]
		protected BPWGLYMECFZ([In] SyncData data, a a, b b, c c, d d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x4FC1100", Offset = "0x4FC0100", VA = "0x184FC1100")]
		protected BPWGLYMECFZ(DDFOJMMWCEL a, DSDVCCWMEAG b, string c, a d, b e, c f, d g, NetworkSetterPermissionMode h, bool i, Action j, INJJPMNDUTS k)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x4FB30D0", Offset = "0x4FB20D0", VA = "0x184FB30D0")]
		public a RMEJWJXBKOL()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x4FB9C20", Offset = "0x4FB8C20", VA = "0x184FB9C20")]
		public void JDOBNPXRLJF(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x4FB3190", Offset = "0x4FB2190", VA = "0x184FB3190")]
		public b RMJQTQQYTZU()
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x4FBA840", Offset = "0x4FB9840", VA = "0x184FBA840")]
		public void JDTIKWROUUO(b a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x4FB7700", Offset = "0x4FB6700", VA = "0x184FB7700")]
		public c RMOXQXKWDLD()
		{
			return (c)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x4FBB160", Offset = "0x4FBA160", VA = "0x184FBB160")]
		public void JDYPIDLMEFX(c a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x15E54A0", Offset = "0x15E44A0", VA = "0x1815E54A0")]
		public d RLEBKCBOPJS()
		{
			return (d)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x4FBB510", Offset = "0x4FBA510", VA = "0x184FBB510")]
		public void JEDWFKFJNRG(d a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x4FBE440", Offset = "0x4FBD440", VA = "0x184FBE440")]
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
			[Cpp2IlInjected.Address(RVA = "0xD1C050", Offset = "0xD1B050", VA = "0x180D1C050", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0xD1B8A0", Offset = "0xD1A8A0", VA = "0x180D1B8A0", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		protected virtual b WRHKOVRGCLB
		{
			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0xE01CE0", Offset = "0xE00CE0", VA = "0x180E01CE0", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0x14C2210", Offset = "0x14C1210", VA = "0x1814C2210", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		protected virtual c WRCDROXISZS
		{
			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0xE27CA0", Offset = "0xE26CA0", VA = "0x180E27CA0", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return (c)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0xE284A0", Offset = "0xE274A0", VA = "0x180E284A0", Slot = "15")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		protected virtual d WQWWUIDLJOJ
		{
			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(RVA = "0xD25180", Offset = "0xD24180", VA = "0x180D25180", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return (d)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0xD35250", Offset = "0xD34250", VA = "0x180D35250", Slot = "17")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		protected virtual e WQRPXBJOADA
		{
			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0xD24DC0", Offset = "0xD23DC0", VA = "0x180D24DC0", Slot = "18")]
			[CompilerGenerated]
			get
			{
				return (e)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x4FAF0A0", Offset = "0x4FAE0A0", VA = "0x184FAF0A0", Slot = "19")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		protected override object FJFTLXBUGFZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x4FB1D50", Offset = "0x4FB0D50", VA = "0x184FB1D50", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x4FB2010", Offset = "0x4FB1010", VA = "0x184FB2010", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x4FADE60", Offset = "0x4FACE60", VA = "0x184FADE60", Slot = "9")]
		protected override bool AUBWNTYAGOH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x4FB6620", Offset = "0x4FB5620", VA = "0x184FB6620")]
		protected BPQZORSGSUQ(DDFOJMMWCEL a, DSDVCCWMEAG b, string c, a d, b e, c f, d g, e h, NetworkSetterPermissionMode i, bool j, Action k, INJJPMNDUTS l)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x4FB30D0", Offset = "0x4FB20D0", VA = "0x184FB30D0")]
		public a RMEJWJXBKOL()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x4FAF790", Offset = "0x4FAE790", VA = "0x184FAF790")]
		public void JDOBNPXRLJF(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x173FB70", Offset = "0x173EB70", VA = "0x18173FB70")]
		public b RMJQTQQYTZU()
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x4FAFF10", Offset = "0x4FAEF10", VA = "0x184FAFF10")]
		public void JDTIKWROUUO(b a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x4FB3270", Offset = "0x4FB2270", VA = "0x184FB3270")]
		public c RMOXQXKWDLD()
		{
			return (c)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x4FB0690", Offset = "0x4FAF690", VA = "0x184FB0690")]
		public void JDYPIDLMEFX(c a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x15E54A0", Offset = "0x15E44A0", VA = "0x1815E54A0")]
		public d RLEBKCBOPJS()
		{
			return (d)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x4FB14D0", Offset = "0x4FB04D0", VA = "0x184FB14D0")]
		public void JEDWFKFJNRG(d a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x4FB3010", Offset = "0x4FB2010", VA = "0x184FB3010")]
		public e RLJIHIVLYVB()
		{
			return (e)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x4FB15C0", Offset = "0x4FB05C0", VA = "0x184FB15C0")]
		public void JEJDCQZGXCP(e a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x4FB3F40", Offset = "0x4FB2F40", VA = "0x184FB3F40")]
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
