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
			[Cpp2IlInjected.Address(RVA = "0xF84310", Offset = "0xF82F10", VA = "0x180F84310", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool RWZZXBCMNZJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x5129880", Offset = "0x5128480", VA = "0x185129880", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public a ZZOCBIPDATE
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x512A020", Offset = "0x5128C20", VA = "0x18512A020", Slot = "11")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x512BBB0", Offset = "0x512A7B0", VA = "0x18512BBB0", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public a IYPENRGWRFX
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x5129F10", Offset = "0x5128B10", VA = "0x185129F10", Slot = "4")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x512C9F0", Offset = "0x512B5F0", VA = "0x18512C9F0", Slot = "13")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public a YMGSSSXYISN
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x5129F10", Offset = "0x5128B10", VA = "0x185129F10")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x512A160", Offset = "0x5128D60", VA = "0x18512A160")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool IKQSTLUOMMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x5127F40", Offset = "0x5126B40", VA = "0x185127F40", Slot = "7")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x5127A50", Offset = "0x5126650", VA = "0x185127A50", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool ZALDBGGFNHL
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x5129DC0", Offset = "0x51289C0", VA = "0x185129DC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x512C210", Offset = "0x512AE10", VA = "0x18512C210", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x512EE80", Offset = "0x512DA80", VA = "0x18512EE80")]
		public YZPEHXXYCZC([In] SyncData data, a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x512D160", Offset = "0x512BD60", VA = "0x18512D160")]
		private void WEJETJMVVZV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x512D8E0", Offset = "0x512C4E0", VA = "0x18512D8E0", Slot = "5")]
		public void XUACCGNRNOU(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x512D9F0", Offset = "0x512C5F0", VA = "0x18512D9F0")]
		public void XUACCGNRNOU(a a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5127680", Offset = "0x5126280", VA = "0x185127680", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0xF84310", Offset = "0xF82F10", VA = "0x180F84310", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool RWZZXBCMNZJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x5139130", Offset = "0x5137D30", VA = "0x185139130", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool KTOGMYYRCUK
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x5138100", Offset = "0x5136D00", VA = "0x185138100")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool KTIZPSETTJB
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x5137EC0", Offset = "0x5136AC0", VA = "0x185137EC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public (a, b) ZZOCBIPDATE
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x513A450", Offset = "0x5139050", VA = "0x18513A450", Slot = "11")]
			get
			{
				return default((a, b));
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x513AFC0", Offset = "0x5139BC0", VA = "0x18513AFC0", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public (a, b) IYPENRGWRFX
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x5139B50", Offset = "0x5138750", VA = "0x185139B50", Slot = "4")]
			get
			{
				return default((a, b));
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x513CF80", Offset = "0x513BB80", VA = "0x18513CF80", Slot = "13")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public (a, b) YMGSSSXYISN
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x51398B0", Offset = "0x51384B0", VA = "0x1851398B0")]
			get
			{
				return default((a, b));
			}
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x513A980", Offset = "0x5139580", VA = "0x18513A980")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public a NWWDTUVGLKB
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x513A120", Offset = "0x5138D20", VA = "0x18513A120")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x513C440", Offset = "0x513B040", VA = "0x18513C440")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public a USMPQDVWBRW
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x51379C0", Offset = "0x51365C0", VA = "0x1851379C0")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x5139220", Offset = "0x5137E20", VA = "0x185139220")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public a BPPAZGVHXGA
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x51379C0", Offset = "0x51365C0", VA = "0x1851379C0")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x5138AB0", Offset = "0x51376B0", VA = "0x185138AB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public b NWGJCANOJCA
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x513A200", Offset = "0x5138E00", VA = "0x18513A200")]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x513C6F0", Offset = "0x513B2F0", VA = "0x18513C6F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public b UTCKHYDODZX
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x5137B80", Offset = "0x5136780", VA = "0x185137B80")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public b BQEVRBCZZOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x5137B80", Offset = "0x5136780", VA = "0x185137B80")]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x5138310", Offset = "0x5136F10", VA = "0x185138310")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public bool IKQSTLUOMMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x5127F40", Offset = "0x5126B40", VA = "0x185127F40", Slot = "7")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x5127A50", Offset = "0x5126650", VA = "0x185127A50", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x513C0E0", Offset = "0x513ACE0", VA = "0x18513C0E0", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x513E0C0", Offset = "0x513CCC0", VA = "0x18513E0C0")]
		public ZAEYZSFQFHD([In] SyncData data, a a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x513D070", Offset = "0x513BC70", VA = "0x18513D070")]
		private void WEJETJMVVZV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x5139820", Offset = "0x5138420", VA = "0x185139820")]
		public void GDZPVSSGUMV(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x513D6C0", Offset = "0x513C2C0", VA = "0x18513D6C0")]
		public void XUACCGNRNOU(a a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x513B960", Offset = "0x513A560", VA = "0x18513B960", Slot = "5")]
		private void RMAPZCVOTWX((a, b) a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x5127680", Offset = "0x5126280", VA = "0x185127680", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0xF84310", Offset = "0xF82F10", VA = "0x180F84310", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public bool RWZZXBCMNZJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x5133BA0", Offset = "0x51327A0", VA = "0x185133BA0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool KTOGMYYRCUK
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x5133190", Offset = "0x5131D90", VA = "0x185133190")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public bool KTIZPSETTJB
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x5132CE0", Offset = "0x51318E0", VA = "0x185132CE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public bool KTDSSLKWJXS
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x5132FF0", Offset = "0x5131BF0", VA = "0x185132FF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public (a, b, c) ZZOCBIPDATE
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x51348F0", Offset = "0x51334F0", VA = "0x1851348F0", Slot = "11")]
			get
			{
				return default((a, b, c));
			}
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x51353D0", Offset = "0x5133FD0", VA = "0x1851353D0", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public (a, b, c) IYPENRGWRFX
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x51343B0", Offset = "0x5132FB0", VA = "0x1851343B0", Slot = "4")]
			get
			{
				return default((a, b, c));
			}
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x5136040", Offset = "0x5134C40", VA = "0x185136040", Slot = "13")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public a NWWDTUVGLKB
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x5134620", Offset = "0x5133220", VA = "0x185134620")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x5135870", Offset = "0x5134470", VA = "0x185135870")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public a USMPQDVWBRW
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x5132AF0", Offset = "0x51316F0", VA = "0x185132AF0")]
			get
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public a BPPAZGVHXGA
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x5132AF0", Offset = "0x51316F0", VA = "0x185132AF0")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x5133910", Offset = "0x5132510", VA = "0x185133910")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public b NWGJCANOJCA
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x51347E0", Offset = "0x51333E0", VA = "0x1851347E0")]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x5135D50", Offset = "0x5134950", VA = "0x185135D50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public b UTCKHYDODZX
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x5132BD0", Offset = "0x51317D0", VA = "0x185132BD0")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public b BQEVRBCZZOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x5132BD0", Offset = "0x51317D0", VA = "0x185132BD0")]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x5133450", Offset = "0x5132050", VA = "0x185133450")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public c NWLPZHHLSNJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x5134650", Offset = "0x5133250", VA = "0x185134650")]
			get
			{
				return (c)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x5135B20", Offset = "0x5134720", VA = "0x185135B20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public c USXDKRJQUOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x5132C00", Offset = "0x5131800", VA = "0x185132C00")]
			get
			{
				return (c)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public c BPZOTUJCQCS
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x5132C00", Offset = "0x5131800", VA = "0x185132C00")]
			get
			{
				return (c)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x51336D0", Offset = "0x51322D0", VA = "0x1851336D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool IKQSTLUOMMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x5127F40", Offset = "0x5126B40", VA = "0x185127F40", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x5135750", Offset = "0x5134350", VA = "0x185135750", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x5137070", Offset = "0x5135C70", VA = "0x185137070")]
		public YZZSCLLSVVU([In] SyncData data, a a, b b, c c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x51368A0", Offset = "0x51354A0", VA = "0x1851368A0")]
		private void WEJETJMVVZV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x5133F30", Offset = "0x5132B30", VA = "0x185133F30")]
		public void GDZPVSSGUMV(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x5136F10", Offset = "0x5135B10", VA = "0x185136F10")]
		public void ZAGJLWBDGFE(b a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x5132990", Offset = "0x5131590", VA = "0x185132990")]
		public void CPSKMFCHNWH(c a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x5136C80", Offset = "0x5135880", VA = "0x185136C80")]
		public void XUACCGNRNOU(a a, b b, c c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x51363D0", Offset = "0x5134FD0", VA = "0x1851363D0", Slot = "5")]
		private void VPGGZFSNXGI((a, b, c) a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x5127680", Offset = "0x5126280", VA = "0x185127680", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0xF84310", Offset = "0xF82F10", VA = "0x180F84310", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public (a, b, c, d) IYPENRGWRFX
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x5127A70", Offset = "0x5126670", VA = "0x185127A70", Slot = "4")]
			get
			{
				return default((a, b, c, d));
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x51286A0", Offset = "0x51272A0", VA = "0x1851286A0", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public b UTCKHYDODZX
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x5127570", Offset = "0x5126170", VA = "0x185127570")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public c USXDKRJQUOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x51275A0", Offset = "0x51261A0", VA = "0x1851275A0")]
			get
			{
				return (c)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public d URWUYJODZJV
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x51273E0", Offset = "0x5125FE0", VA = "0x1851273E0")]
			get
			{
				return (d)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool IKQSTLUOMMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x5127F40", Offset = "0x5126B40", VA = "0x185127F40", Slot = "7")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x5127A50", Offset = "0x5126650", VA = "0x185127A50", Slot = "10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x51293F0", Offset = "0x5127FF0", VA = "0x1851293F0")]
		public YYZJQDQGARB([In] SyncData data, a a, b b, c c, d d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x51286F0", Offset = "0x51272F0", VA = "0x1851286F0")]
		private void WEJETJMVVZV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x5127960", Offset = "0x5126560", VA = "0x185127960")]
		public void GDZPVSSGUMV(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x5128A50", Offset = "0x5127650", VA = "0x185128A50")]
		public void XUACCGNRNOU(a a, b b, c c, d d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x5127F60", Offset = "0x5126B60", VA = "0x185127F60", Slot = "5")]
		private void QZRVRVLARXU((a, b, c, d) a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x5127680", Offset = "0x5126280", VA = "0x185127680", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x9995BA0", Offset = "0x99947A0", VA = "0x189995BA0")]
		public static string CARFOTRAMKU(this SyncData a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xD5A2A0", Offset = "0xD58EA0", VA = "0x180D5A2A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6F21600", Offset = "0x6F20200", VA = "0x186F21600")]
		public MRXGQCQLMGZ([In] SyncData data, a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6F1F990", Offset = "0x6F1E590", VA = "0x186F1F990")]
		public MRXGQCQLMGZ(DSDVCCWMEAG a, DDFOJMMWCEL b, string c, a d, NetworkSetterPermissionMode e, [Optional] Action f, [Optional] INJJPMNDUTS g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6F1E460", Offset = "0x6F1D060", VA = "0x186F1E460")]
		public MRXGQCQLMGZ(DSDVCCWMEAG a, string b, a c, NetworkSetterPermissionMode d, [Optional] Action e, [Optional] INJJPMNDUTS f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6F20CF0", Offset = "0x6F1F8F0", VA = "0x186F20CF0")]
		public MRXGQCQLMGZ(DSDVCCWMEAG a, string b, a c, NetworkSetterPermissionMode d, bool e, [Optional] Action f, [Optional] INJJPMNDUTS g)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class MRHLYIITJYY<a, b> : BRBVVNBOGWB<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6F1A2D0", Offset = "0x6F18ED0", VA = "0x186F1A2D0")]
		public MRHLYIITJYY([In] SyncData data, a a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6F19A80", Offset = "0x6F18680", VA = "0x186F19A80")]
		public MRHLYIITJYY(DSDVCCWMEAG a, DDFOJMMWCEL b, string c, a d, b e, NetworkSetterPermissionMode f, [Optional] Action g, [Optional] INJJPMNDUTS h)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x6F1B4E0", Offset = "0x6F1A0E0", VA = "0x186F1B4E0")]
		public MRHLYIITJYY(DSDVCCWMEAG a, string b, a c, b d, NetworkSetterPermissionMode e, [Optional] Action f, [Optional] INJJPMNDUTS g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x6F183D0", Offset = "0x6F16FD0", VA = "0x186F183D0")]
		public MRHLYIITJYY(DSDVCCWMEAG a, string b, a c, b d, NetworkSetterPermissionMode e, bool f, [Optional] Action g, [Optional] INJJPMNDUTS h)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class MRMSVPCQTKH<a, b, c> : BQWOYGHQXKS<a, b, c>
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x6F1C9C0", Offset = "0x6F1B5C0", VA = "0x186F1C9C0")]
		public MRMSVPCQTKH([In] SyncData data, a a, b b, c c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x6F1CE60", Offset = "0x6F1BA60", VA = "0x186F1CE60")]
		public MRMSVPCQTKH(DSDVCCWMEAG a, string b, a c, b d, c e, NetworkSetterPermissionMode f, [Optional] Action g, [Optional] INJJPMNDUTS h)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class MQWYDUUYRCG<a, b, c, d> : BPWGLYMECFZ<a, b, c, d>
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6F14A70", Offset = "0x6F13670", VA = "0x186F14A70")]
		public MQWYDUUYRCG([In] SyncData data, a a, b b, c c, d d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6F152D0", Offset = "0x6F13ED0", VA = "0x186F152D0")]
		public MQWYDUUYRCG(DSDVCCWMEAG a, DDFOJMMWCEL b, string c, a d, b e, c f, d g, NetworkSetterPermissionMode h, [Optional] Action i, [Optional] INJJPMNDUTS j)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6F14E60", Offset = "0x6F13A60", VA = "0x186F14E60")]
		public MQWYDUUYRCG(DSDVCCWMEAG a, string b, a c, b d, c e, d f, NetworkSetterPermissionMode g, [Optional] Action h, [Optional] INJJPMNDUTS i)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class MRCFBBOWANP<a, b, c, d, e> : BPQZORSGSUQ<a, b, c, d, e>
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6F16CC0", Offset = "0x6F158C0", VA = "0x186F16CC0")]
		public MRCFBBOWANP(DSDVCCWMEAG a, DDFOJMMWCEL b, string c, a d, b e, c f, d g, e h, NetworkSetterPermissionMode i, [Optional] Action j, [Optional] INJJPMNDUTS k)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x6F179C0", Offset = "0x6F165C0", VA = "0x186F179C0")]
		public MRCFBBOWANP(DSDVCCWMEAG a, string b, a c, b d, c e, d f, e g, NetworkSetterPermissionMode h, [Optional] Action i, [Optional] INJJPMNDUTS j)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class MNSITLULKWC<a> : BQMBDSTWEOA<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6F10D90", Offset = "0x6F0F990", VA = "0x186F10D90")]
		public MNSITLULKWC(DDFOJMMWCEL a, string b, a c, [Optional] Action d, [Optional] INJJPMNDUTS e)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class MNNBWFAOBKT<a, b> : BRBVVNBOGWB<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6F0F9C0", Offset = "0x6F0E5C0", VA = "0x186F0F9C0")]
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
		[Cpp2IlInjected.Address(RVA = "0xCF2960", Offset = "0xCF1560", VA = "0x180CF2960")]
		public VYIDZLVARYP(INJJPMNDUTS a, DSDVCCWMEAG b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x40CEB60", Offset = "0x40CD760", VA = "0x1840CEB60", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x9995B50", Offset = "0x9994750", VA = "0x189995B50")]
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
		[Cpp2IlInjected.Address(RVA = "0x9995C30", Offset = "0x9994830", VA = "0x189995C30")]
		public SyncData(SyncData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x9995CB0", Offset = "0x99948B0", VA = "0x189995CB0")]
		public SyncData(DSDVCCWMEAG context, string key, NetworkSetterPermissionMode permissionMode, [Optional] Action callback, [Optional] INJJPMNDUTS networkBacking)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x9995BE0", Offset = "0x99947E0", VA = "0x189995BE0")]
		public static SyncData From(DSDVCCWMEAG context, string key, NetworkSetterPermissionMode permissionMode, [Optional] Action callback, [Optional] INJJPMNDUTS networkBacking)
		{
			return default(SyncData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public static class UOKHGJMREOR
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x4091130", Offset = "0x408FD30", VA = "0x184091130")]
		public static MRXGQCQLMGZ<a> BKVGBBESOLE<a>(this SyncData a, a b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x4090030", Offset = "0x408EC30", VA = "0x184090030")]
		public static MRHLYIITJYY<b, c> BKVGBBESOLE<b, c>(this SyncData a, b b, c c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x40900D0", Offset = "0x408ECD0", VA = "0x1840900D0")]
		public static MRMSVPCQTKH<d, e, f> BKVGBBESOLE<d, e, f>(this SyncData a, d b, e c, f d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x4090BE0", Offset = "0x408F7E0", VA = "0x184090BE0")]
		public static MQWYDUUYRCG<g, h, i, j> BKVGBBESOLE<g, h, i, j>(this SyncData a, g b, h c, i d, j e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x40913B0", Offset = "0x408FFB0", VA = "0x1840913B0")]
		public static YZPEHXXYCZC<k> INTEZRNUAZV<k>(this SyncData a, k b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x4091260", Offset = "0x408FE60", VA = "0x184091260")]
		public static ZAEYZSFQFHD<l, m> INTEZRNUAZV<l, m>(this SyncData a, l b, m c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x4091300", Offset = "0x408FF00", VA = "0x184091300")]
		public static YZZSCLLSVVU<n, o, p> INTEZRNUAZV<n, o, p>(this SyncData a, n b, o c, p d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x4091680", Offset = "0x4090280", VA = "0x184091680")]
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
			[Cpp2IlInjected.Address(RVA = "0x99944C0", Offset = "0x99930C0", VA = "0x1899944C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		private bool JBLGJXYZHUY
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x9995840", Offset = "0x9994440", VA = "0x189995840")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x9994350", Offset = "0x9992F50", VA = "0x189994350")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		private bool LUMRGQPRRDB
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x9995110", Offset = "0x9993D10", VA = "0x189995110")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x9995870", Offset = "0x9994470", VA = "0x189995870")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		private bool MIZOJCNEBCG
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x99946A0", Offset = "0x99932A0", VA = "0x1899946A0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x9994CE0", Offset = "0x99938E0", VA = "0x189994CE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public bool IKQSTLUOMMB
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x99950A0", Offset = "0x9993CA0", VA = "0x1899950A0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x9994770", Offset = "0x9993370", VA = "0x189994770")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		protected virtual object FJFTLXBUGFZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0xCF42E0", Offset = "0xCF2EE0", VA = "0x180CF42E0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0xCF4510", Offset = "0xCF3110", VA = "0x180CF4510", Slot = "8")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public bool TJPGVZTBZOC
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x9994280", Offset = "0x9992E80", VA = "0x189994280")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public int UHTJVRPDYJD
		{
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0xEEF700", Offset = "0xEEE300", VA = "0x180EEF700")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x1AAA870", Offset = "0x1AA9470", VA = "0x181AAA870")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public string OTIUDMTTUGL
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0xCF1D90", Offset = "0xCF0990", VA = "0x180CF1D90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public bool ZALDBGGFNHL
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x9994720", Offset = "0x9993320", VA = "0x189994720")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x9994A00", Offset = "0x9993600", VA = "0x189994A00")]
		public static void JSAQTBBMHZT(INJJPMNDUTS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(Slot = "9")]
		protected abstract bool AUBWNTYAGOH();

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x9995930", Offset = "0x9994530", VA = "0x189995930")]
		protected BKVGBBESOLE(DDFOJMMWCEL a, DSDVCCWMEAG b, string c, NetworkSetterPermissionMode d, Action e, INJJPMNDUTS f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x99946C0", Offset = "0x99932C0", VA = "0x1899946C0", Slot = "1")]
		~BKVGBBESOLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x9994530", Offset = "0x9993130", VA = "0x189994530", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x9994D00", Offset = "0x9993900", VA = "0x189994D00")]
		private void MROJWKZBKXX(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x9995120", Offset = "0x9993D20", VA = "0x189995120")]
		private object SONCQFWGMCH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x9994830", Offset = "0x9993430", VA = "0x189994830")]
		protected void Initialize(bool enforceInitialValue, object initialValue, bool initialValueIsDefaultValue = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x9995290", Offset = "0x9993E90", VA = "0x189995290")]
		protected void Set(object newValue, bool checkPermission = true, bool suppressCallback = false, bool requireModified = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x99955F0", Offset = "0x99941F0", VA = "0x1899955F0")]
		protected void WJDJLMFFZEM(object a, bool b, bool c, bool d = false, bool e = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x99942D0", Offset = "0x9992ED0", VA = "0x1899942D0")]
		internal void BYECBTFIBDE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x9994DA0", Offset = "0x99939A0", VA = "0x189994DA0")]
		private void NXWHRYHKLEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x99950B0", Offset = "0x9993CB0", VA = "0x1899950B0")]
		private void RUREOGWMCXV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x9994AA0", Offset = "0x99936A0", VA = "0x189994AA0", Slot = "4")]
		private void JZJUYOLIBRN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x9994270", Offset = "0x9992E70", VA = "0x189994270", Slot = "5")]
		private void AJIYHVVCUCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x9994B10", Offset = "0x9993710", VA = "0x189994B10")]
		public bool KPHLSQIVQTC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x9994E00", Offset = "0x9993A00", VA = "0x189994E00")]
		public bool OHMRHPESIFY()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x9994370", Offset = "0x9992F70", VA = "0x189994370")]
		private bool CPPWXMLYUVT()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x9995540", Offset = "0x9994140", VA = "0x189995540")]
		internal void UWJBIPSPUIO(object a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x9995430", Offset = "0x9994030", VA = "0x189995430")]
		private void UOCZVHPWLSS(object a, bool b, bool c = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x99946B0", Offset = "0x99932B0", VA = "0x1899946B0")]
		private bool EDPJOESVZDM(Flags a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x9995850", Offset = "0x9994450", VA = "0x189995850")]
		private void ZLMHSDXCQHM(Flags a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x9994C50", Offset = "0x9993850", VA = "0x189994C50")]
		public static string LFZZJUBKLVK(DDFOJMMWCEL a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x9994FC0", Offset = "0x9993BC0", VA = "0x189994FC0")]
		public static string PEIEPUXURCQ(DSDVCCWMEAG a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x99952D0", Offset = "0x9993ED0", VA = "0x1899952D0")]
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
			[Cpp2IlInjected.Address(RVA = "0xD09BA0", Offset = "0xD087A0", VA = "0x180D09BA0", Slot = "28")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public bool OQIZMMIKYRN
		{
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0xD4DD70", Offset = "0xD4C970", VA = "0x180D4DD70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x408E4B0", Offset = "0x408D0B0", VA = "0x18408E4B0", Slot = "12")]
		public void UJQARUJTJYH<a>(string a, a b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x9997C90", Offset = "0x9996890", VA = "0x189997C90", Slot = "11")]
		public void SFUJJSZVOKW(DDFOJMMWCEL a, string b, object c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x9996CA0", Offset = "0x99958A0", VA = "0x189996CA0", Slot = "9")]
		public object INRZJAOHFFQ(DDFOJMMWCEL a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x9998300", Offset = "0x9996F00", VA = "0x189998300", Slot = "10")]
		public void ZVCCBKYJFYE(string a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x9996C00", Offset = "0x9995800", VA = "0x189996C00", Slot = "8")]
		public object IGIEWJJCYZS(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x9995F70", Offset = "0x9994B70", VA = "0x189995F70", Slot = "13")]
		public void DMCUZCCFLUN(DDFOJMMWCEL a, string b, BKVGBBESOLE c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x9997DE0", Offset = "0x99969E0", VA = "0x189997DE0", Slot = "14")]
		public void URNYJZOSFKE(DDFOJMMWCEL a, string b, BKVGBBESOLE c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x9996E80", Offset = "0x9995A80", VA = "0x189996E80")]
		private void IYHIPNWULPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x9996470", Offset = "0x9995070", VA = "0x189996470")]
		private void FDCRMVGNNAS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x9995F10", Offset = "0x9994B10", VA = "0x189995F10")]
		private void DGYHKOASZCN(DDFOJMMWCEL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x9996AE0", Offset = "0x99956E0", VA = "0x189996AE0")]
		protected void HFLKSOERPEF(DDFOJMMWCEL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x9996D90", Offset = "0x9995990", VA = "0x189996D90")]
		protected void ITPSPMKPEET()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x9996460", Offset = "0x9995060", VA = "0x189996460")]
		protected void EWQBWMAZIST(IDictionary<object, object> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x9997B20", Offset = "0x9996720", VA = "0x189997B20")]
		protected void SCHKDTACIPT(DDFOJMMWCEL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x99966C0", Offset = "0x99952C0", VA = "0x1899966C0")]
		protected void FOACIAAMOEJ(DDFOJMMWCEL a, IDictionary<object, object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x99974E0", Offset = "0x99960E0", VA = "0x1899974E0")]
		private void QHNOWFHXKEE(IDictionary<object, object> a, Dictionary<string, object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x99964C0", Offset = "0x99950C0", VA = "0x1899964C0")]
		private static void FNPPWJREDVS(object a, object b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x9996830", Offset = "0x9995430", VA = "0x189996830")]
		private static void FWUXZWKXQAP(Dictionary<string, object> a, string b, BKVGBBESOLE c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x9997950", Offset = "0x9996550", VA = "0x189997950")]
		private static void QVZWANBMXLI(Dictionary<string, object> a, string b, BKVGBBESOLE c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x9997B90", Offset = "0x9996790", VA = "0x189997B90", Slot = "19")]
		public void SEULCQDQNKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(Slot = "29")]
		protected abstract void HERODHXWYTH(Dictionary<object, object> a);

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x9996750", Offset = "0x9995350", VA = "0x189996750", Slot = "20")]
		public void FSKTEADFUCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "30")]
		protected abstract void GSDNAEUYEAH(Dictionary<object, object> a);

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x99972C0", Offset = "0x9995EC0", VA = "0x1899972C0")]
		private void NFHXTBZWPNA(Dictionary<object, object> a, List<string> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x9998080", Offset = "0x9996C80", VA = "0x189998080")]
		private void ZMCNNYLJNNJ(IDictionary<object, object> a, [Out] int b, [Out] string[] c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x9996A50", Offset = "0x9995650", VA = "0x189996A50")]
		public void GQZAPECVTQI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x9995E40", Offset = "0x9994A40", VA = "0x189995E40")]
		public void AJRSCCVENEE(DDFOJMMWCEL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x9996ED0", Offset = "0x9995AD0", VA = "0x189996ED0")]
		public void KUFTWQTYCTZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "31")]
		protected abstract HashSet<int> THCRZFFBIHX(bool a, bool b);

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x99961E0", Offset = "0x9994DE0", VA = "0x1899961E0", Slot = "21")]
		public void EHJTZEZHXOJ(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x9997230", Offset = "0x9995E30", VA = "0x189997230")]
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
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "36")]
		public virtual void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x9996080", Offset = "0x9994C80", VA = "0x189996080", Slot = "22")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "37")]
		protected virtual void WCFLDSFNRII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x9998420", Offset = "0x9997020", VA = "0x189998420")]
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
			[Cpp2IlInjected.Address(RVA = "0x4F7F7A0", Offset = "0x4F7E3A0", VA = "0x184F7F7A0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x4F7F5D0", Offset = "0x4F7E1D0", VA = "0x184F7F5D0", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		protected override object FJFTLXBUGFZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x4F69450", Offset = "0x4F68050", VA = "0x184F69450", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x4F80610", Offset = "0x4F7F210", VA = "0x184F80610", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x4F7E890", Offset = "0x4F7D490", VA = "0x184F7E890", Slot = "9")]
		protected override bool AUBWNTYAGOH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x4F87B00", Offset = "0x4F86700", VA = "0x184F87B00")]
		protected BQMBDSTWEOA([In] SyncData data, a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x4F85560", Offset = "0x4F84160", VA = "0x184F85560")]
		protected BQMBDSTWEOA(DDFOJMMWCEL a, DSDVCCWMEAG b, string c, a d, NetworkSetterPermissionMode e, bool f, Action g, INJJPMNDUTS h)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x4F6A740", Offset = "0x4F69340", VA = "0x184F6A740")]
		public a Get()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x4F834C0", Offset = "0x4F820C0", VA = "0x184F834C0")]
		public void Set(a newValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x4F83E60", Offset = "0x4F82A60", VA = "0x184F83E60")]
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
			[Cpp2IlInjected.Address(RVA = "0x10EAB40", Offset = "0x10E9740", VA = "0x1810EAB40", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x12B9B00", Offset = "0x12B8700", VA = "0x1812B9B00", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		protected virtual b WRHKOVRGCLB
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x327FFD0", Offset = "0x327EBD0", VA = "0x18327FFD0", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x4F95000", Offset = "0x4F93C00", VA = "0x184F95000", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public b FESMFKXTIDR
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x17257C0", Offset = "0x17243C0", VA = "0x1817257C0")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		protected override object FJFTLXBUGFZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x4F69450", Offset = "0x4F68050", VA = "0x184F69450", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x4F96AF0", Offset = "0x4F956F0", VA = "0x184F96AF0", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x4F93E40", Offset = "0x4F92A40", VA = "0x184F93E40", Slot = "9")]
		protected override bool AUBWNTYAGOH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x4F9BB50", Offset = "0x4F9A750", VA = "0x184F9BB50")]
		protected BRBVVNBOGWB([In] SyncData data, a a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x4F9D940", Offset = "0x4F9C540", VA = "0x184F9D940")]
		protected BRBVVNBOGWB(DDFOJMMWCEL a, DSDVCCWMEAG b, string c, a d, b e, NetworkSetterPermissionMode f, bool g, Action h, INJJPMNDUTS i)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x4F6A740", Offset = "0x4F69340", VA = "0x184F6A740")]
		public a RMEJWJXBKOL()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x4F957C0", Offset = "0x4F943C0", VA = "0x184F957C0")]
		public void JDOBNPXRLJF(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x17257C0", Offset = "0x17243C0", VA = "0x1817257C0")]
		public b RMJQTQQYTZU()
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x4F96290", Offset = "0x4F94E90", VA = "0x184F96290")]
		public void JDTIKWROUUO(b a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x4F986D0", Offset = "0x4F972D0", VA = "0x184F986D0")]
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
			[Cpp2IlInjected.Address(RVA = "0xD00E90", Offset = "0xCFFA90", VA = "0x180D00E90", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0xD006E0", Offset = "0xCFF2E0", VA = "0x180D006E0", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		protected virtual b WRHKOVRGCLB
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0xED3CB0", Offset = "0xED28B0", VA = "0x180ED3CB0", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x2AB1600", Offset = "0x2AB0200", VA = "0x182AB1600", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		protected virtual c WRCDROXISZS
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0xCEE720", Offset = "0xCED320", VA = "0x180CEE720", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return (c)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0xCEE730", Offset = "0xCED330", VA = "0x180CEE730", Slot = "15")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public a FEXTCRRQRPA
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x4F6A740", Offset = "0x4F69340", VA = "0x184F6A740")]
			get
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public b FESMFKXTIDR
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x17257C0", Offset = "0x17243C0", VA = "0x1817257C0")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public c FENFIEDVYSI
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x4F6A8E0", Offset = "0x4F694E0", VA = "0x184F6A8E0")]
			get
			{
				return (c)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		protected override object FJFTLXBUGFZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x4F69450", Offset = "0x4F68050", VA = "0x184F69450", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x4F8C600", Offset = "0x4F8B200", VA = "0x184F8C600", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x4F892D0", Offset = "0x4F87ED0", VA = "0x184F892D0", Slot = "9")]
		protected override bool AUBWNTYAGOH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x4F92980", Offset = "0x4F91580", VA = "0x184F92980")]
		protected BQWOYGHQXKS([In] SyncData data, a a, b b, c c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x4F917A0", Offset = "0x4F903A0", VA = "0x184F917A0")]
		protected BQWOYGHQXKS(DDFOJMMWCEL a, DSDVCCWMEAG b, string c, a d, b e, c f, NetworkSetterPermissionMode g, bool h, Action i, INJJPMNDUTS j)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x4F6A740", Offset = "0x4F69340", VA = "0x184F6A740")]
		public a RMEJWJXBKOL()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x4F8A840", Offset = "0x4F89440", VA = "0x184F8A840")]
		public void JDOBNPXRLJF(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x17257C0", Offset = "0x17243C0", VA = "0x1817257C0")]
		public b RMJQTQQYTZU()
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x4F8B4D0", Offset = "0x4F8A0D0", VA = "0x184F8B4D0")]
		public void JDTIKWROUUO(b a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x4F6A8E0", Offset = "0x4F694E0", VA = "0x184F6A8E0")]
		public c RMOXQXKWDLD()
		{
			return (c)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x4F8C000", Offset = "0x4F8AC00", VA = "0x184F8C000")]
		public void JDYPIDLMEFX(c a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x4F8FCF0", Offset = "0x4F8E8F0", VA = "0x184F8FCF0")]
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
			[Cpp2IlInjected.Address(RVA = "0xF4D0A0", Offset = "0xF4BCA0", VA = "0x180F4D0A0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x4F668F0", Offset = "0x4F654F0", VA = "0x184F668F0", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		protected virtual b WRHKOVRGCLB
		{
			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x1491440", Offset = "0x1490040", VA = "0x181491440", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x1490550", Offset = "0x148F150", VA = "0x181490550", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		protected virtual c WRCDROXISZS
		{
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x1513A20", Offset = "0x1512620", VA = "0x181513A20", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return (c)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x4F70620", Offset = "0x4F6F220", VA = "0x184F70620", Slot = "15")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		protected virtual d WQWWUIDLJOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x1D46400", Offset = "0x1D45000", VA = "0x181D46400", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return (d)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x166F470", Offset = "0x166E070", VA = "0x18166F470", Slot = "17")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public b FESMFKXTIDR
		{
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x4F6A800", Offset = "0x4F69400", VA = "0x184F6A800")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public c FENFIEDVYSI
		{
			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0x4F6EB80", Offset = "0x4F6D780", VA = "0x184F6EB80")]
			get
			{
				return (c)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public d FEHYKXJYPGZ
		{
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x15CA0F0", Offset = "0x15C8CF0", VA = "0x1815CA0F0")]
			get
			{
				return (d)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		protected override object FJFTLXBUGFZ
		{
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0x4F69450", Offset = "0x4F68050", VA = "0x184F69450", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0x4F737F0", Offset = "0x4F723F0", VA = "0x184F737F0", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x4F6F110", Offset = "0x4F6DD10", VA = "0x184F6F110", Slot = "9")]
		protected override bool AUBWNTYAGOH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x4F79A30", Offset = "0x4F78630", VA = "0x184F79A30")]
		protected BPWGLYMECFZ([In] SyncData data, a a, b b, c c, d d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x4F78110", Offset = "0x4F76D10", VA = "0x184F78110")]
		protected BPWGLYMECFZ(DDFOJMMWCEL a, DSDVCCWMEAG b, string c, a d, b e, c f, d g, NetworkSetterPermissionMode h, bool i, Action j, INJJPMNDUTS k)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x4F6A740", Offset = "0x4F69340", VA = "0x184F6A740")]
		public a RMEJWJXBKOL()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x4F70F60", Offset = "0x4F6FB60", VA = "0x184F70F60")]
		public void JDOBNPXRLJF(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x4F6A800", Offset = "0x4F69400", VA = "0x184F6A800")]
		public b RMJQTQQYTZU()
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x4F71B20", Offset = "0x4F70720", VA = "0x184F71B20")]
		public void JDTIKWROUUO(b a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x4F6EB80", Offset = "0x4F6D780", VA = "0x184F6EB80")]
		public c RMOXQXKWDLD()
		{
			return (c)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x4F72410", Offset = "0x4F71010", VA = "0x184F72410")]
		public void JDYPIDLMEFX(c a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x15CA0F0", Offset = "0x15C8CF0", VA = "0x1815CA0F0")]
		public d RLEBKCBOPJS()
		{
			return (d)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x4F727B0", Offset = "0x4F713B0", VA = "0x184F727B0")]
		public void JEDWFKFJNRG(d a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x4F75590", Offset = "0x4F74190", VA = "0x184F75590")]
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
			[Cpp2IlInjected.Address(RVA = "0xD00E90", Offset = "0xCFFA90", VA = "0x180D00E90", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0xD006E0", Offset = "0xCFF2E0", VA = "0x180D006E0", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		protected virtual b WRHKOVRGCLB
		{
			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0xDE6620", Offset = "0xDE5220", VA = "0x180DE6620", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0x14A5D80", Offset = "0x14A4980", VA = "0x1814A5D80", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		protected virtual c WRCDROXISZS
		{
			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0xE0C5C0", Offset = "0xE0B1C0", VA = "0x180E0C5C0", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return (c)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0xE0CDC0", Offset = "0xE0B9C0", VA = "0x180E0CDC0", Slot = "15")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		protected virtual d WQWWUIDLJOJ
		{
			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(RVA = "0xD09F60", Offset = "0xD08B60", VA = "0x180D09F60", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return (d)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0xD1A000", Offset = "0xD18C00", VA = "0x180D1A000", Slot = "17")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		protected virtual e WQRPXBJOADA
		{
			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0xD09BB0", Offset = "0xD087B0", VA = "0x180D09BB0", Slot = "18")]
			[CompilerGenerated]
			get
			{
				return (e)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x4F668E0", Offset = "0x4F654E0", VA = "0x184F668E0", Slot = "19")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		protected override object FJFTLXBUGFZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x4F69450", Offset = "0x4F68050", VA = "0x184F69450", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x4F696F0", Offset = "0x4F682F0", VA = "0x184F696F0", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x4F65740", Offset = "0x4F64340", VA = "0x184F65740", Slot = "9")]
		protected override bool AUBWNTYAGOH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x4F6DB20", Offset = "0x4F6C720", VA = "0x184F6DB20")]
		protected BPQZORSGSUQ(DDFOJMMWCEL a, DSDVCCWMEAG b, string c, a d, b e, c f, d g, e h, NetworkSetterPermissionMode i, bool j, Action k, INJJPMNDUTS l)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x4F6A740", Offset = "0x4F69340", VA = "0x184F6A740")]
		public a RMEJWJXBKOL()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x4F66F90", Offset = "0x4F65B90", VA = "0x184F66F90")]
		public void JDOBNPXRLJF(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x17257C0", Offset = "0x17243C0", VA = "0x1817257C0")]
		public b RMJQTQQYTZU()
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x4F676E0", Offset = "0x4F662E0", VA = "0x184F676E0")]
		public void JDTIKWROUUO(b a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x4F6A8E0", Offset = "0x4F694E0", VA = "0x184F6A8E0")]
		public c RMOXQXKWDLD()
		{
			return (c)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x4F67E40", Offset = "0x4F66A40", VA = "0x184F67E40")]
		public void JDYPIDLMEFX(c a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x15CA0F0", Offset = "0x15C8CF0", VA = "0x1815CA0F0")]
		public d RLEBKCBOPJS()
		{
			return (d)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x4F68C10", Offset = "0x4F67810", VA = "0x184F68C10")]
		public void JEDWFKFJNRG(d a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x4F6A680", Offset = "0x4F69280", VA = "0x184F6A680")]
		public e RLJIHIVLYVB()
		{
			return (e)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x4F68CF0", Offset = "0x4F678F0", VA = "0x184F68CF0")]
		public void JEJDCQZGXCP(e a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x4F6B550", Offset = "0x4F6A150", VA = "0x184F6B550")]
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
