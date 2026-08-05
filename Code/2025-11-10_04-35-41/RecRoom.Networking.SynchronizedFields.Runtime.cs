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
	public interface TCDQPEYPWIR : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		bool JDHXFAEKXXC
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		bool VSDQJHEHKIN
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		JCSDFORPEFX PJXUSAWNIPA
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		int GLCVSEHMCSH
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		bool DBLKPPKBJNR
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		bool KJKTQIQVRHR
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		event Action AXNSAALKGUU;

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void SPAMZDTVQZT();

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void GYROFBMTBBH(object a, bool b);

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void AWLUCVLNGED();
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface VHJXRDEFVWK : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000007")]
		string HHRNDMXWTMB
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		bool VYSWKBVFIEP
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface UTBSIAVGOUV<a> : VHJXRDEFVWK, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		a WMOJZBXLGDZ
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void MNGKYJYSCPI(a a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public sealed class QIKHQUJGLZE<a> : UTBSIAVGOUV<a>, VHJXRDEFVWK, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private readonly SZUDHGNLOST<a> XLFBFHMGHHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private readonly SZUDHGNLOST<a> IKLNROWKWPY;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public string HHRNDMXWTMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xC76E10", Offset = "0xC76210", VA = "0x180C76E10", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool SPUVLEPHYWV
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x5AE1620", Offset = "0x5AE0A20", VA = "0x185AE1620", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public a HNZJIVPCMKU
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x5AE15B0", Offset = "0x5AE09B0", VA = "0x185AE15B0", Slot = "11")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x5AE1910", Offset = "0x5AE0D10", VA = "0x185AE1910", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public a WMOJZBXLGDZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x5AE13A0", Offset = "0x5AE07A0", VA = "0x185AE13A0", Slot = "4")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x5AE1570", Offset = "0x5AE0970", VA = "0x185AE1570", Slot = "13")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public a QEMSNQIEONV
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x5AE13A0", Offset = "0x5AE07A0", VA = "0x185AE13A0")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x5AE1D50", Offset = "0x5AE1150", VA = "0x185AE1D50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool VYSWKBVFIEP
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x5ACD710", Offset = "0x5ACCB10", VA = "0x185ACD710", Slot = "7")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x5ACE1A0", Offset = "0x5ACD5A0", VA = "0x185ACE1A0", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool ZCQMDRLXERN
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x5AE1D30", Offset = "0x5AE1130", VA = "0x185AE1D30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5AE1BF0", Offset = "0x5AE0FF0", VA = "0x185AE1BF0", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5AE2050", Offset = "0x5AE1450", VA = "0x185AE2050")]
		public QIKHQUJGLZE([In] SyncData data, a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5AE14A0", Offset = "0x5AE08A0", VA = "0x185AE14A0")]
		private void GMOGMSUBGIZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5AE17D0", Offset = "0x5AE0BD0", VA = "0x185AE17D0", Slot = "5")]
		public void MNGKYJYSCPI(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5AE1880", Offset = "0x5AE0C80", VA = "0x185AE1880")]
		public void MNGKYJYSCPI(a a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5ACCA70", Offset = "0x5ACBE70", VA = "0x185ACCA70", Slot = "8")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public sealed class QIFATNPJCNV<a, b> : UTBSIAVGOUV<(a, b)>, VHJXRDEFVWK, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly SZZKENHIYEC<a, b> XLFBFHMGHHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private readonly SZZKENHIYEC<a, b> IKLNROWKWPY;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public string HHRNDMXWTMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0xC76E10", Offset = "0xC76210", VA = "0x180C76E10", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool SPUVLEPHYWV
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x5AD7750", Offset = "0x5AD6B50", VA = "0x185AD7750", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool UCDPRDSGZVC
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x5AD9320", Offset = "0x5AD8720", VA = "0x185AD9320")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool UCTKIXZZCDD
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x5AD9620", Offset = "0x5AD8A20", VA = "0x185AD9620")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public (a, b) HNZJIVPCMKU
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x5AD66A0", Offset = "0x5AD5AA0", VA = "0x185AD66A0", Slot = "11")]
			get
			{
				return default((a, b));
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x5AD81A0", Offset = "0x5AD75A0", VA = "0x185AD81A0", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public (a, b) WMOJZBXLGDZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x5AD5640", Offset = "0x5AD4A40", VA = "0x185AD5640", Slot = "4")]
			get
			{
				return default((a, b));
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x5AD6240", Offset = "0x5AD5640", VA = "0x185AD6240", Slot = "13")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public (a, b) QEMSNQIEONV
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x5AD9C60", Offset = "0x5AD9060", VA = "0x185AD9C60")]
			get
			{
				return default((a, b));
			}
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x5ADA280", Offset = "0x5AD9680", VA = "0x185ADA280")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public a RMDHNMKSOWX
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x5ADA1A0", Offset = "0x5AD95A0", VA = "0x185ADA1A0")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x5AD6F00", Offset = "0x5AD6300", VA = "0x185AD6F00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public a ZGJIRURXZPQ
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x5AD49E0", Offset = "0x5AD3DE0", VA = "0x185AD49E0")]
			get
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public a KLQGXQNZIVQ
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x5AD49E0", Offset = "0x5AD3DE0", VA = "0x185AD49E0")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x5AD4D20", Offset = "0x5AD4120", VA = "0x185AD4D20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public b RMIOKTEPYIG
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x5ADA0B0", Offset = "0x5AD94B0", VA = "0x185ADA0B0")]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x5AD6D90", Offset = "0x5AD6190", VA = "0x185AD6D90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public b ZGEBUNYAQEH
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x5AD48C0", Offset = "0x5AD3CC0", VA = "0x185AD48C0")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public b KLLAAJUBZKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x5AD48C0", Offset = "0x5AD3CC0", VA = "0x185AD48C0")]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x5AD50F0", Offset = "0x5AD44F0", VA = "0x185AD50F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public bool VYSWKBVFIEP
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x5ACD710", Offset = "0x5ACCB10", VA = "0x185ACD710", Slot = "7")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x5ACE1A0", Offset = "0x5ACD5A0", VA = "0x185ACE1A0", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x5AD9020", Offset = "0x5AD8420", VA = "0x185AD9020", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x5ADAC50", Offset = "0x5ADA050", VA = "0x185ADAC50")]
		public QIFATNPJCNV([In] SyncData data, a a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x5AD5AE0", Offset = "0x5AD4EE0", VA = "0x185AD5AE0")]
		private void GMOGMSUBGIZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x5AD8A00", Offset = "0x5AD7E00", VA = "0x185AD8A00")]
		public void OOTSMWJSQHV(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x5AD7C70", Offset = "0x5AD7070", VA = "0x185AD7C70")]
		public void MNGKYJYSCPI(a a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x5ADA020", Offset = "0x5AD9420", VA = "0x185ADA020", Slot = "5")]
		private void VDTLVKCZSBD((a, b) a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x5ACCA70", Offset = "0x5ACBE70", VA = "0x185ACCA70", Slot = "8")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public sealed class QHZTWGVLTCM<a, b, c> : UTBSIAVGOUV<(a, b, c)>, VHJXRDEFVWK, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly TAERBUBGHPL<a, b, c> XLFBFHMGHHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly TAERBUBGHPL<a, b, c> IKLNROWKWPY;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public string HHRNDMXWTMB
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0xC76E10", Offset = "0xC76210", VA = "0x180C76E10", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public bool SPUVLEPHYWV
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x5AD1C50", Offset = "0x5AD1050", VA = "0x185AD1C50", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool UCDPRDSGZVC
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x5AD3540", Offset = "0x5AD2940", VA = "0x185AD3540")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public bool UCTKIXZZCDD
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x5AD3920", Offset = "0x5AD2D20", VA = "0x185AD3920")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public bool UCODLRGBSRU
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x5AD3AC0", Offset = "0x5AD2EC0", VA = "0x185AD3AC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public (a, b, c) HNZJIVPCMKU
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x5AD0FF0", Offset = "0x5AD03F0", VA = "0x185AD0FF0", Slot = "11")]
			get
			{
				return default((a, b, c));
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x5AD2A10", Offset = "0x5AD1E10", VA = "0x185AD2A10", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public (a, b, c) WMOJZBXLGDZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x5AD03C0", Offset = "0x5ACF7C0", VA = "0x185AD03C0", Slot = "4")]
			get
			{
				return default((a, b, c));
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x5AD0BA0", Offset = "0x5ACFFA0", VA = "0x185AD0BA0", Slot = "13")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public a RMDHNMKSOWX
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x5AD3F20", Offset = "0x5AD3320", VA = "0x185AD3F20")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x5AD1650", Offset = "0x5AD0A50", VA = "0x185AD1650")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public a ZGJIRURXZPQ
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x5ACF580", Offset = "0x5ACE980", VA = "0x185ACF580")]
			get
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public a KLQGXQNZIVQ
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x5ACF580", Offset = "0x5ACE980", VA = "0x185ACF580")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x5ACF7D0", Offset = "0x5ACEBD0", VA = "0x185ACF7D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public b RMIOKTEPYIG
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x5AD3D90", Offset = "0x5AD3190", VA = "0x185AD3D90")]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x5AD15D0", Offset = "0x5AD09D0", VA = "0x185AD15D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public b ZGEBUNYAQEH
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x5ACF3C0", Offset = "0x5ACE7C0", VA = "0x185ACF3C0")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public b KLLAAJUBZKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x5ACF3C0", Offset = "0x5ACE7C0", VA = "0x185ACF3C0")]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x5ACF860", Offset = "0x5ACEC60", VA = "0x185ACF860")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public c RMNVHZYNHTP
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x5AD3D60", Offset = "0x5AD3160", VA = "0x185AD3D60")]
			get
			{
				return (c)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x5AD1150", Offset = "0x5AD0550", VA = "0x185AD1150")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public c ZFYUXHEDGSY
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x5ACF4A0", Offset = "0x5ACE8A0", VA = "0x185ACF4A0")]
			get
			{
				return (c)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public c KLFTDDAEPYY
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x5ACF4A0", Offset = "0x5ACE8A0", VA = "0x185ACF4A0")]
			get
			{
				return (c)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x5ACFBC0", Offset = "0x5ACEFC0", VA = "0x185ACFBC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool VYSWKBVFIEP
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x5ACD710", Offset = "0x5ACCB10", VA = "0x185ACD710", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x5AD34A0", Offset = "0x5AD28A0", VA = "0x185AD34A0", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x5AD46D0", Offset = "0x5AD3AD0", VA = "0x185AD46D0")]
		public QHZTWGVLTCM([In] SyncData data, a a, b b, c c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x5AD04A0", Offset = "0x5ACF8A0", VA = "0x185AD04A0")]
		private void GMOGMSUBGIZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x5AD2FB0", Offset = "0x5AD23B0", VA = "0x185AD2FB0")]
		public void OOTSMWJSQHV(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x5AD2C30", Offset = "0x5AD2030", VA = "0x185AD2C30")]
		public void OBCJYKJRKIY(b a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x5ACFCF0", Offset = "0x5ACF0F0", VA = "0x185ACFCF0")]
		public void DMUPOQXLJBT(c a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x5AD2280", Offset = "0x5AD1680", VA = "0x185AD2280")]
		public void MNGKYJYSCPI(a a, b b, c c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x5AD1900", Offset = "0x5AD0D00", VA = "0x185AD1900", Slot = "5")]
		private void JIAXGICTPSW((a, b, c) a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x5ACCA70", Offset = "0x5ACBE70", VA = "0x185ACCA70", Slot = "8")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public sealed class QHUMZABOJRD<a, b, c, d> : UTBSIAVGOUV<(a, b, c, d)>, VHJXRDEFVWK, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly SYTUUYRYTOA<a, b, c, d> XLFBFHMGHHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly SYTUUYRYTOA<a, b, c, d> IKLNROWKWPY;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public string HHRNDMXWTMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xC76E10", Offset = "0xC76210", VA = "0x180C76E10", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public (a, b, c, d) WMOJZBXLGDZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x5ACCE80", Offset = "0x5ACC280", VA = "0x185ACCE80", Slot = "4")]
			get
			{
				return default((a, b, c, d));
			}
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x5ACD300", Offset = "0x5ACC700", VA = "0x185ACD300", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public b ZGEBUNYAQEH
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x5ACC8B0", Offset = "0x5ACBCB0", VA = "0x185ACC8B0")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public c ZFYUXHEDGSY
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x5ACCA40", Offset = "0x5ACBE40", VA = "0x185ACCA40")]
			get
			{
				return (c)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public d ZFTOAAKFXHP
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x5ACC7D0", Offset = "0x5ACBBD0", VA = "0x185ACC7D0")]
			get
			{
				return (d)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool VYSWKBVFIEP
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x5ACD710", Offset = "0x5ACCB10", VA = "0x185ACD710", Slot = "7")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x5ACE1A0", Offset = "0x5ACD5A0", VA = "0x185ACE1A0", Slot = "10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x5ACE890", Offset = "0x5ACDC90", VA = "0x185ACE890")]
		public QHUMZABOJRD([In] SyncData data, a a, b b, c c, d d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x5ACD200", Offset = "0x5ACC600", VA = "0x185ACD200")]
		private void GMOGMSUBGIZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x5ACDA40", Offset = "0x5ACCE40", VA = "0x185ACDA40")]
		public void OOTSMWJSQHV(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x5ACD9F0", Offset = "0x5ACCDF0", VA = "0x185ACD9F0")]
		public void MNGKYJYSCPI(a a, b b, c c, d d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x5ACE140", Offset = "0x5ACD540", VA = "0x185ACE140", Slot = "5")]
		private void VVYDJGAUEAY((a, b, c, d) a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x5ACCA70", Offset = "0x5ACBE70", VA = "0x185ACCA70", Slot = "8")]
		public void Dispose()
		{
		}
	}
}
namespace RecRoom.Networking.Policy
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class IQCFQRDLLYL
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x83D0540", Offset = "0x83CF940", VA = "0x1883D0540")]
		public static string ACXXGBQMUWC(this SyncData a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xAFEDD0", Offset = "0xAFE1D0", VA = "0x180AFEDD0")]
		public static NetworkSetterPermissionMode CSKLWROMVST(this SyncData a)
		{
			return default(NetworkSetterPermissionMode);
		}
	}
}
namespace RecRoom.Networking.SynchronizedFields
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class SZUDHGNLOST<a> : TUPZOJTSFFA<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x5E07B90", Offset = "0x5E06F90", VA = "0x185E07B90")]
		public SZUDHGNLOST([In] SyncData data, a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x5E04310", Offset = "0x5E03710", VA = "0x185E04310")]
		public SZUDHGNLOST(BZXWFWBHLFW a, JCSDFORPEFX b, string c, a d, NetworkSetterPermissionMode e, [Optional] Action f, [Optional] KEIZMPCKSCC g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x5E081A0", Offset = "0x5E075A0", VA = "0x185E081A0")]
		public SZUDHGNLOST(BZXWFWBHLFW a, string b, a c, NetworkSetterPermissionMode d, [Optional] Action e, [Optional] KEIZMPCKSCC f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x5E049C0", Offset = "0x5E03DC0", VA = "0x185E049C0")]
		public SZUDHGNLOST(BZXWFWBHLFW a, string b, a c, NetworkSetterPermissionMode d, bool e, [Optional] Action f, [Optional] KEIZMPCKSCC g)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class SZZKENHIYEC<a, b> : TUKSRCZUVTR<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x5E08F50", Offset = "0x5E08350", VA = "0x185E08F50")]
		public SZZKENHIYEC([In] SyncData data, a a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x5E0B920", Offset = "0x5E0AD20", VA = "0x185E0B920")]
		public SZZKENHIYEC(BZXWFWBHLFW a, JCSDFORPEFX b, string c, a d, b e, NetworkSetterPermissionMode f, [Optional] Action g, [Optional] KEIZMPCKSCC h)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x5E0AFB0", Offset = "0x5E0A3B0", VA = "0x185E0AFB0")]
		public SZZKENHIYEC(BZXWFWBHLFW a, string b, a c, b d, NetworkSetterPermissionMode e, [Optional] Action f, [Optional] KEIZMPCKSCC g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x5E0A860", Offset = "0x5E09C60", VA = "0x185E0A860")]
		public SZZKENHIYEC(BZXWFWBHLFW a, string b, a c, b d, NetworkSetterPermissionMode e, bool f, [Optional] Action g, [Optional] KEIZMPCKSCC h)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class TAERBUBGHPL<a, b, c> : TUFLTWFXMII<a, b, c>
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x5EE3C50", Offset = "0x5EE3050", VA = "0x185EE3C50")]
		public TAERBUBGHPL([In] SyncData data, a a, b b, c c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x5EE3EB0", Offset = "0x5EE32B0", VA = "0x185EE3EB0")]
		public TAERBUBGHPL(BZXWFWBHLFW a, string b, a c, b d, c e, NetworkSetterPermissionMode f, [Optional] Action g, [Optional] KEIZMPCKSCC h)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class SYTUUYRYTOA<a, b, c, d> : TVQIARPFAJT<a, b, c, d>
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x5E00D50", Offset = "0x5E00150", VA = "0x185E00D50")]
		public SYTUUYRYTOA([In] SyncData data, a a, b b, c c, d d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x5E01D00", Offset = "0x5E01100", VA = "0x185E01D00")]
		public SYTUUYRYTOA(BZXWFWBHLFW a, JCSDFORPEFX b, string c, a d, b e, c f, d g, NetworkSetterPermissionMode h, [Optional] Action i, [Optional] KEIZMPCKSCC j)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x5E00870", Offset = "0x5DFFC70", VA = "0x185E00870")]
		public SYTUUYRYTOA(BZXWFWBHLFW a, string b, a c, b d, c e, d f, NetworkSetterPermissionMode g, [Optional] Action h, [Optional] KEIZMPCKSCC i)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class SYZBSFLWCZJ<a, b, c, d, e> : TVLBDKVHQYK<a, b, c, d, e>
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x5E02810", Offset = "0x5E01C10", VA = "0x185E02810")]
		public SYZBSFLWCZJ(BZXWFWBHLFW a, JCSDFORPEFX b, string c, a d, b e, c f, d g, e h, NetworkSetterPermissionMode i, [Optional] Action j, [Optional] KEIZMPCKSCC k)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x5E02A30", Offset = "0x5E01E30", VA = "0x185E02A30")]
		public SYZBSFLWCZJ(BZXWFWBHLFW a, string b, a c, b d, c e, d f, e g, NetworkSetterPermissionMode h, [Optional] Action i, [Optional] KEIZMPCKSCC j)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class GVSDYBPETSU<a> : TUPZOJTSFFA<a>
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x4EDB950", Offset = "0x4EDAD50", VA = "0x184EDB950")]
		public GVSDYBPETSU(JCSDFORPEFX a, string b, a c, [Optional] Action d, [Optional] KEIZMPCKSCC e)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class GWHYPVWWWAV<a, b> : TUKSRCZUVTR<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x4EDC3C0", Offset = "0x4EDB7C0", VA = "0x184EDC3C0")]
		public GWHYPVWWWAV(JCSDFORPEFX a, string b, a c, b d, [Optional] Action e, [Optional] KEIZMPCKSCC f)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public interface AOWKSJHVBTO
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "0")]
		SZUDHGNLOST<a> BVMINLFWMEU<a>(string a, a b, NetworkSetterPermissionMode c, [Optional] Action d);
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class VNVJINBXVYF : AOWKSJHVBTO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly KEIZMPCKSCC XCPQJNRXHRD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly BZXWFWBHLFW CNGCLABNYJH;

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0xAA8230", Offset = "0xAA7630", VA = "0x180AA8230")]
		public VNVJINBXVYF(KEIZMPCKSCC a, BZXWFWBHLFW b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x3BE91C0", Offset = "0x3BE85C0", VA = "0x183BE91C0", Slot = "4")]
		public SZUDHGNLOST<a> BVMINLFWMEU<a>(string a, a b, NetworkSetterPermissionMode c, [Optional] Action d)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public interface BSPGLUGQSFD : BZXWFWBHLFW
	{
		[Cpp2IlInjected.Token(Token = "0x17000036")]
		ViewId RHFFQUVNHSX
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public interface BZXWFWBHLFW
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		bool EBOYCAOBIFV
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		bool GVVKCONZJFP
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		string IAZGUJGDTXR
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		bool XHQBBUHUJCM
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void RegisterDestroyHandler(FZERGMMLSNU handler);

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void UnregisterDestroyHandler(FZERGMMLSNU handler);
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public static class EOQKIPQDUXI
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x83D04F0", Offset = "0x83CF8F0", VA = "0x1883D04F0")]
		public static bool IHRAJWKYIRT(this BZXWFWBHLFW a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface KEIZMPCKSCC : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		JCSDFORPEFX NYHENYQESVW
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		bool ZCQMDRLXERN
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		bool ONWUNJMGJPE
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void Initialize();

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "4")]
		object DFZLFEXMRZY(string a);

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "5")]
		object WWNZLSTAIEI(JCSDFORPEFX a, string b);

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void YGVMRIKLDZE(string a, object b);

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void WYEOSGUGLCU(JCSDFORPEFX a, string b, object c);

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void MFQFHRVSFDX<a>(string a, a b);

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void EVGGTTLFICP([CanBeNull] JCSDFORPEFX photonPlayer, string a, ZCNCOROGCBS b);

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void YIZVBSSELDI([CanBeNull] JCSDFORPEFX photonPlayer, string a, ZCNCOROGCBS b);

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "11")]
		b UVMYQUHOAHM<b>(object a);

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "12")]
		object XMBQOGFZBEL<c>(c a);

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(Slot = "13")]
		void DNTFDKKQTBI();

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void RISYAVQUUUU();

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void WERTRINNLNN(string a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public struct SyncData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public JCSDFORPEFX player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public BZXWFWBHLFW context;

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
		public KEIZMPCKSCC networkBacking;

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x83D05D0", Offset = "0x83CF9D0", VA = "0x1883D05D0")]
		public SyncData(SyncData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x83D0650", Offset = "0x83CFA50", VA = "0x1883D0650")]
		public SyncData(BZXWFWBHLFW context, string key, NetworkSetterPermissionMode permissionMode, [Optional] Action callback, [Optional] KEIZMPCKSCC networkBacking)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x83D0580", Offset = "0x83CF980", VA = "0x1883D0580")]
		public static SyncData From(BZXWFWBHLFW context, string key, NetworkSetterPermissionMode permissionMode, [Optional] Action callback, [Optional] KEIZMPCKSCC networkBacking)
		{
			return default(SyncData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public static class ESFZPQRKGDN
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x35600D0", Offset = "0x355F4D0", VA = "0x1835600D0")]
		public static SZUDHGNLOST<a> ZCNCOROGCBS<a>(this SyncData a, a b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x355F6C0", Offset = "0x355EAC0", VA = "0x18355F6C0")]
		public static SZZKENHIYEC<b, c> ZCNCOROGCBS<b, c>(this SyncData a, b b, c c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x355F760", Offset = "0x355EB60", VA = "0x18355F760")]
		public static TAERBUBGHPL<d, e, f> ZCNCOROGCBS<d, e, f>(this SyncData a, d b, e c, f d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x355FB80", Offset = "0x355EF80", VA = "0x18355FB80")]
		public static SYTUUYRYTOA<g, h, i, j> ZCNCOROGCBS<g, h, i, j>(this SyncData a, g b, h c, i d, j e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x355E6D0", Offset = "0x355DAD0", VA = "0x18355E6D0")]
		public static QIKHQUJGLZE<k> AYMYYCSAFTT<k>(this SyncData a, k b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x355E580", Offset = "0x355D980", VA = "0x18355E580")]
		public static QIFATNPJCNV<l, m> AYMYYCSAFTT<l, m>(this SyncData a, l b, m c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x355E620", Offset = "0x355DA20", VA = "0x18355E620")]
		public static QHZTWGVLTCM<n, o, p> AYMYYCSAFTT<n, o, p>(this SyncData a, n b, o c, p d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x355F0D0", Offset = "0x355E4D0", VA = "0x18355F0D0")]
		public static QHUMZABOJRD<q, r, s, t> AYMYYCSAFTT<q, r, s, t>(this SyncData a, q b, r c, s d, t e)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public abstract class ZCNCOROGCBS : FZERGMMLSNU, IDisposable
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
		private static Stack<KEIZMPCKSCC> LTCGTXVHYAO;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static bool MRJITCXGFBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		protected readonly JCSDFORPEFX CAABOZTJRQL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		protected readonly BZXWFWBHLFW CNGCLABNYJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		protected readonly string RJWUJQXIPUR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		protected readonly NetworkSetterPermissionMode WFFTPGUUIKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		protected readonly Action QCMVESDEXDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		protected KEIZMPCKSCC QPDPDCTYOTL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private Flags KIDSOCPGFSR;

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public static KEIZMPCKSCC OUHEGWAWWAC
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x83D1CF0", Offset = "0x83D10F0", VA = "0x1883D1CF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		private bool ACULTSUNLBU
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x83D14D0", Offset = "0x83D08D0", VA = "0x1883D14D0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x83D09F0", Offset = "0x83CFDF0", VA = "0x1883D09F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		private bool FOAWXRNSYVD
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x83D0A10", Offset = "0x83CFE10", VA = "0x1883D0A10")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x83D1220", Offset = "0x83D0620", VA = "0x1883D1220")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		private bool JQIXJLUPUJW
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x83D1410", Offset = "0x83D0810", VA = "0x1883D1410")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x83D0870", Offset = "0x83CFC70", VA = "0x1883D0870")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public bool VYSWKBVFIEP
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x83D14C0", Offset = "0x83D08C0", VA = "0x1883D14C0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x83D1B80", Offset = "0x83D0F80", VA = "0x1883D1B80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		protected virtual object PQRAXCKXLAV
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0xAAA160", Offset = "0xAA9560", VA = "0x180AAA160", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0xAAA870", Offset = "0xAA9C70", VA = "0x180AAA870", Slot = "8")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public bool KIPCAPWWCXG
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x83D1B30", Offset = "0x83D0F30", VA = "0x1883D1B30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public int HWBNPKHNYSL
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0xBB86C0", Offset = "0xBB7AC0", VA = "0x180BB86C0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x175B160", Offset = "0x175A560", VA = "0x18175B160")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public string HHRNDMXWTMB
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1C0", Offset = "0xAAA5C0", VA = "0x180AAB1C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public bool ZCQMDRLXERN
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x83D16B0", Offset = "0x83D0AB0", VA = "0x1883D16B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x83D1D60", Offset = "0x83D1160", VA = "0x1883D1D60")]
		public static void YWRUHAHFQDB(KEIZMPCKSCC a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(Slot = "9")]
		protected abstract bool WHQBQPGRROV();

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x83D1E90", Offset = "0x83D1290", VA = "0x1883D1E90")]
		protected ZCNCOROGCBS(JCSDFORPEFX a, BZXWFWBHLFW b, string c, NetworkSetterPermissionMode d, Action e, KEIZMPCKSCC f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x83D0EC0", Offset = "0x83D02C0", VA = "0x1883D0EC0", Slot = "1")]
		~ZCNCOROGCBS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x83D0A80", Offset = "0x83CFE80", VA = "0x1883D0A80", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x83D1420", Offset = "0x83D0820", VA = "0x1883D1420")]
		private void KPKQNMHXUYX(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x83D19C0", Offset = "0x83D0DC0", VA = "0x1883D19C0")]
		private object WSCFYHFYIMR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x83D1240", Offset = "0x83D0640", VA = "0x1883D1240")]
		protected void Initialize(bool enforceInitialValue, object initialValue, bool initialValueIsDefaultValue = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x83D1810", Offset = "0x83D0C10", VA = "0x1883D1810")]
		protected void Set(object newValue, bool checkPermission = true, bool suppressCallback = false, bool requireModified = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x83D0BF0", Offset = "0x83CFFF0", VA = "0x1883D0BF0")]
		protected void EZYHBXRYMHA(object a, bool b, bool c, bool d = false, bool e = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x83D0E40", Offset = "0x83D0240", VA = "0x1883D0E40")]
		internal void FFJZJMUYJOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x83D07E0", Offset = "0x83CFBE0", VA = "0x1883D07E0")]
		private void AOAOIPJEKYG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x83D0A20", Offset = "0x83CFE20", VA = "0x1883D0A20")]
		private void DMAWRCWSKTX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x83D1640", Offset = "0x83D0A40", VA = "0x1883D1640", Slot = "4")]
		private void SNFVFLYDLSZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x83D0860", Offset = "0x83CFC60", VA = "0x1883D0860", Slot = "5")]
		private void AWHEQBRJEIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x83D0F20", Offset = "0x83D0320", VA = "0x1883D0F20")]
		public bool HILJMVGZMCG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x83D1060", Offset = "0x83D0460", VA = "0x1883D1060")]
		public bool HLYQPWRJVKQ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x83D0890", Offset = "0x83CFC90", VA = "0x1883D0890")]
		private bool BKZJVXQERDB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x83D1C40", Offset = "0x83D1040", VA = "0x1883D1C40")]
		internal void XQTVKEPJOYU(object a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x83D1700", Offset = "0x83D0B00", VA = "0x1883D1700")]
		private void SVUYNRDAPXG(object a, bool b, bool c = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x83D09E0", Offset = "0x83CFDE0", VA = "0x1883D09E0")]
		private bool BOCWAPZHWCA(Flags a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x83D0840", Offset = "0x83CFC40", VA = "0x1883D0840")]
		private void APJDLBZPYJW(Flags a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x83D1930", Offset = "0x83D0D30", VA = "0x1883D1930")]
		public static string UWJRWVAJAES(JCSDFORPEFX a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x83D1850", Offset = "0x83D0C50", VA = "0x1883D1850")]
		public static string UCSTTWBEUFA(BZXWFWBHLFW a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x83D14E0", Offset = "0x83D08E0", VA = "0x1883D14E0")]
		public static bool RAYTQDOUDUY(object a, object b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public abstract class CMSELRKJJBU : KEIZMPCKSCC, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly Dictionary<object, object> QFVJWXJQKFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly List<string> HAZNUNKJCRT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly Dictionary<object, object> HVNKLAANQVD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly List<string> QGZERFYUXDV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private bool HLFKHWGNBJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		protected readonly Dictionary<string, object> QNHHRUBCQAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		protected readonly Dictionary<JCSDFORPEFX, Dictionary<string, object>> HCQFHIEWGPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly HashSet<string> CQHNSRKQGXO;

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public abstract Dictionary<object, object> SRVSJQYNWCY
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(Slot = "21")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public abstract int VGPKZUGYVLD
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(Slot = "22")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public abstract JCSDFORPEFX NYHENYQESVW
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(Slot = "23")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public abstract bool ZCQMDRLXERN
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(Slot = "24")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public abstract bool ONWUNJMGJPE
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(Slot = "25")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public virtual bool HUYYMFYQHBD
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0xABEDC0", Offset = "0xABE1C0", VA = "0x180ABEDC0", Slot = "26")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public bool EGNAKZZXDYZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0xAF9F90", Offset = "0xAF9390", VA = "0x180AF9F90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x34280C0", Offset = "0x34274C0", VA = "0x1834280C0", Slot = "12")]
		public void MFQFHRVSFDX<a>(string a, a b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x83CF960", Offset = "0x83CED60", VA = "0x1883CF960", Slot = "11")]
		public void WYEOSGUGLCU(JCSDFORPEFX a, string b, object c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x83CF870", Offset = "0x83CEC70", VA = "0x1883CF870", Slot = "9")]
		public object WWNZLSTAIEI(JCSDFORPEFX a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x83CFF30", Offset = "0x83CF330", VA = "0x1883CFF30", Slot = "10")]
		public void YGVMRIKLDZE(string a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x83CE010", Offset = "0x83CD410", VA = "0x1883CE010", Slot = "8")]
		public object DFZLFEXMRZY(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x83CE380", Offset = "0x83CD780", VA = "0x1883CE380", Slot = "13")]
		public void EVGGTTLFICP(JCSDFORPEFX a, string b, ZCNCOROGCBS c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x83D0050", Offset = "0x83CF450", VA = "0x1883D0050", Slot = "14")]
		public void YIZVBSSELDI(JCSDFORPEFX a, string b, ZCNCOROGCBS c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x83CF820", Offset = "0x83CEC20", VA = "0x1883CF820")]
		private void WWMQOHPXBOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x83CEB20", Offset = "0x83CDF20", VA = "0x1883CEB20")]
		private void QOITKOIQJXW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x83CE9D0", Offset = "0x83CDDD0", VA = "0x1883CE9D0")]
		private void KLWIQXNVITF(JCSDFORPEFX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x83CF480", Offset = "0x83CE880", VA = "0x1883CF480")]
		protected void VCWVUUVVHBR(JCSDFORPEFX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x83CEA30", Offset = "0x83CDE30", VA = "0x1883CEA30")]
		protected void OWMILQYYNXH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x83CE7F0", Offset = "0x83CDBF0", VA = "0x1883CE7F0")]
		protected void IUIJEWYZMHH(IDictionary<object, object> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x83CE0B0", Offset = "0x83CD4B0", VA = "0x1883CE0B0")]
		protected void DMCFSZOXDOD(JCSDFORPEFX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x83CDF80", Offset = "0x83CD380", VA = "0x1883CDF80")]
		protected void CSMPCIJYRYL(JCSDFORPEFX a, IDictionary<object, object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x83CFAB0", Offset = "0x83CEEB0", VA = "0x1883CFAB0")]
		private void XLKMZZVPNBM(IDictionary<object, object> a, Dictionary<string, object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x83CEB70", Offset = "0x83CDF70", VA = "0x1883CEB70")]
		private static void QTKTQQEQEGG(object a, object b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x83CF140", Offset = "0x83CE540", VA = "0x1883CF140")]
		private static void TAKGHFEPQXP(Dictionary<string, object> a, string b, ZCNCOROGCBS c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x83CE800", Offset = "0x83CDC00", VA = "0x1883CE800")]
		private static void JGOKEUTGNCI(Dictionary<string, object> a, string b, ZCNCOROGCBS c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x83CE120", Offset = "0x83CD520", VA = "0x1883CE120", Slot = "17")]
		public void DNTFDKKQTBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(Slot = "27")]
		protected abstract void EWCWIPCKAUL(Dictionary<object, object> a);

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x83CEF90", Offset = "0x83CE390", VA = "0x1883CEF90", Slot = "18")]
		public void RISYAVQUUUU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "28")]
		protected abstract void FOGLFXWLLEJ(Dictionary<object, object> a);

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x83CED70", Offset = "0x83CE170", VA = "0x1883CED70")]
		private void QXEVHQAMOWE(Dictionary<object, object> a, List<string> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x83CDD10", Offset = "0x83CD110", VA = "0x1883CDD10")]
		private void BFMCTEWYNKZ(IDictionary<object, object> a, [Out] int b, [Out] string[] c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x83CF360", Offset = "0x83CE760", VA = "0x1883CF360")]
		public void UVCPXLMSAMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x83CF070", Offset = "0x83CE470", VA = "0x1883CF070")]
		public void SRZSNFTMWWK(JCSDFORPEFX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x83CE490", Offset = "0x83CD890", VA = "0x1883CE490")]
		public void FEFADZZYLGZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "29")]
		protected abstract HashSet<int> PFQQAMMDHYT(bool a, bool b);

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x83CF5A0", Offset = "0x83CE9A0", VA = "0x1883CF5A0", Slot = "19")]
		public void WERTRINNLNN(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x83CF3F0", Offset = "0x83CE7F0", VA = "0x1883CF3F0")]
		protected string UWJRWVAJAES(JCSDFORPEFX a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "30")]
		public abstract object XMBQOGFZBEL<b>(b a);

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "31")]
		public abstract c UVMYQUHOAHM<c>(object a);

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "32")]
		public virtual void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x83CE220", Offset = "0x83CD620", VA = "0x1883CE220", Slot = "20")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "33")]
		protected virtual void AZLCNHUFTFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x83D0300", Offset = "0x83CF700", VA = "0x1883D0300")]
		protected CMSELRKJJBU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public abstract class TUPZOJTSFFA<a> : ZCNCOROGCBS
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private a YMIJYOPOLUP;

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		protected virtual a VPVSNDBFPKQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0xD1DEA0", Offset = "0xD1D2A0", VA = "0x180D1DEA0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0xD1DD40", Offset = "0xD1D140", VA = "0x180D1DD40", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		protected override object PQRAXCKXLAV
		{
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x5F0B090", Offset = "0x5F0A490", VA = "0x185F0B090", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x5F27C70", Offset = "0x5F27070", VA = "0x185F27C70", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x5F2CC50", Offset = "0x5F2C050", VA = "0x185F2CC50", Slot = "9")]
		protected override bool WHQBQPGRROV()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x5F2FE00", Offset = "0x5F2F200", VA = "0x185F2FE00")]
		protected TUPZOJTSFFA([In] SyncData data, a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x5F2F320", Offset = "0x5F2E720", VA = "0x185F2F320")]
		protected TUPZOJTSFFA(JCSDFORPEFX a, BZXWFWBHLFW b, string c, a d, NetworkSetterPermissionMode e, bool f, Action g, KEIZMPCKSCC h)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x5F274B0", Offset = "0x5F268B0", VA = "0x185F274B0")]
		public a Get()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x5F2B620", Offset = "0x5F2AA20", VA = "0x185F2B620")]
		public void Set(a newValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x5F2AE40", Offset = "0x5F2A240", VA = "0x185F2AE40")]
		public void Set(a newValue, bool checkPermission, bool suppressCallback = false, bool requireModified = true)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public abstract class TUKSRCZUVTR<a, b> : ZCNCOROGCBS
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private a YMIJYOPOLUP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private b YMNQVVJLVFY;

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		protected virtual a VPVSNDBFPKQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0xDF8800", Offset = "0xDF7C00", VA = "0x180DF8800", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0xFB5540", Offset = "0xFB4940", VA = "0x180FB5540", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		protected virtual b VQLNEXIXRSR
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x2F605E0", Offset = "0x2F5F9E0", VA = "0x182F605E0", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x5F23A90", Offset = "0x5F22E90", VA = "0x185F23A90", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public b QCJNTJUDTNL
		{
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x1417D20", Offset = "0x1417120", VA = "0x181417D20")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		protected override object PQRAXCKXLAV
		{
			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x5F0B090", Offset = "0x5F0A490", VA = "0x185F0B090", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x5F1C8E0", Offset = "0x5F1BCE0", VA = "0x185F1C8E0", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x5F22140", Offset = "0x5F21540", VA = "0x185F22140", Slot = "9")]
		protected override bool WHQBQPGRROV()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x5F26DC0", Offset = "0x5F261C0", VA = "0x185F26DC0")]
		protected TUKSRCZUVTR([In] SyncData data, a a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x5F256D0", Offset = "0x5F24AD0", VA = "0x185F256D0")]
		protected TUKSRCZUVTR(JCSDFORPEFX a, BZXWFWBHLFW b, string c, a d, b e, NetworkSetterPermissionMode f, bool g, Action h, KEIZMPCKSCC i)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x5F09FF0", Offset = "0x5F093F0", VA = "0x185F09FF0")]
		public a EDXPXIDLFFD()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x5F1C160", Offset = "0x5F1B560", VA = "0x185F1C160")]
		public void AQOLGNZOEAF(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x1417D20", Offset = "0x1417120", VA = "0x181417D20")]
		public b EDHVFNVTCXC()
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x5F1B940", Offset = "0x5F1AD40", VA = "0x185F1B940")]
		public void APYQOTRWBSE(b a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x5F1E510", Offset = "0x5F1D910", VA = "0x185F1E510")]
		public void Set(a newValue1, b newValue2, bool checkPermission = true)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public abstract class TUFLTWFXMII<a, b, c> : ZCNCOROGCBS
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private a YMIJYOPOLUP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private b YMNQVVJLVFY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private c YMSXTCDJERH;

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		protected virtual a VPVSNDBFPKQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0xAB5E80", Offset = "0xAB5280", VA = "0x180AB5E80", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0xAB5E50", Offset = "0xAB5250", VA = "0x180AB5E50", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		protected virtual b VQLNEXIXRSR
		{
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0xBB85D0", Offset = "0xBB79D0", VA = "0x180BB85D0", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x27A9090", Offset = "0x27A8490", VA = "0x1827A9090", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		protected virtual c VQGGHQPAIHI
		{
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0xAA5380", Offset = "0xAA4780", VA = "0x180AA5380", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return (c)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA4790", VA = "0x180AA5390", Slot = "15")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public a QBTTBPMLRFK
		{
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x5F09FF0", Offset = "0x5F093F0", VA = "0x185F09FF0")]
			get
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public b QCJNTJUDTNL
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x1417D20", Offset = "0x1417120", VA = "0x181417D20")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public c QCEGWDAGKCC
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x5A99330", Offset = "0x5A98730", VA = "0x185A99330")]
			get
			{
				return (c)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		protected override object PQRAXCKXLAV
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x5F0B090", Offset = "0x5F0A490", VA = "0x185F0B090", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x5F0AF30", Offset = "0x5F0A330", VA = "0x185F0AF30", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x5F0DFB0", Offset = "0x5F0D3B0", VA = "0x185F0DFB0", Slot = "9")]
		protected override bool WHQBQPGRROV()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x5F0EFD0", Offset = "0x5F0E3D0", VA = "0x185F0EFD0")]
		protected TUFLTWFXMII([In] SyncData data, a a, b b, c c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x5F0E350", Offset = "0x5F0D750", VA = "0x185F0E350")]
		protected TUFLTWFXMII(JCSDFORPEFX a, BZXWFWBHLFW b, string c, a d, b e, c f, NetworkSetterPermissionMode g, bool h, Action i, KEIZMPCKSCC j)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x5F09FF0", Offset = "0x5F093F0", VA = "0x185F09FF0")]
		public a EDXPXIDLFFD()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x5F09C90", Offset = "0x5F09090", VA = "0x185F09C90")]
		public void AQOLGNZOEAF(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x1417D20", Offset = "0x1417120", VA = "0x181417D20")]
		public b EDHVFNVTCXC()
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x5F09260", Offset = "0x5F08660", VA = "0x185F09260")]
		public void APYQOTRWBSE(b a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x5A99330", Offset = "0x5A98730", VA = "0x185A99330")]
		public c EDNCCUPQMIL()
		{
			return (c)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x5F09710", Offset = "0x5F08B10", VA = "0x185F09710")]
		public void AQDXMALTLDN(c a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x5F0B0F0", Offset = "0x5F0A4F0", VA = "0x185F0B0F0")]
		public void Set(a newValue1, b newValue2, c newValue3, bool checkPermission = true)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public abstract class TVQIARPFAJT<a, b, c, d> : ZCNCOROGCBS
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private a YMIJYOPOLUP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private b YMNQVVJLVFY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private c YMSXTCDJERH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private d YMYEQIXGOCQ;

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		protected virtual a VPVSNDBFPKQ
		{
			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0xC59760", Offset = "0xC58B60", VA = "0x180C59760", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x5F39940", Offset = "0x5F38D40", VA = "0x185F39940", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		protected virtual b VQLNEXIXRSR
		{
			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x123B9F0", Offset = "0x123ADF0", VA = "0x18123B9F0", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x123B220", Offset = "0x123A620", VA = "0x18123B220", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		protected virtual c VQGGHQPAIHI
		{
			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x5F423A0", Offset = "0x5F417A0", VA = "0x185F423A0", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return (c)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x5F46DA0", Offset = "0x5F461A0", VA = "0x185F46DA0", Slot = "15")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		protected virtual d VQWAZKWSKPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x1A04120", Offset = "0x1A03520", VA = "0x181A04120", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return (d)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x1359650", Offset = "0x1358A50", VA = "0x181359650", Slot = "17")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public b QCJNTJUDTNL
		{
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x5F09F80", Offset = "0x5F09380", VA = "0x185F09F80")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public c QCEGWDAGKCC
		{
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x5F09FC0", Offset = "0x5F093C0", VA = "0x185F09FC0")]
			get
			{
				return (c)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public d QCUBNXHYMKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x137A970", Offset = "0x1379D70", VA = "0x18137A970")]
			get
			{
				return (d)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		protected override object PQRAXCKXLAV
		{
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x5F0B090", Offset = "0x5F0A490", VA = "0x185F0B090", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x5F41A30", Offset = "0x5F40E30", VA = "0x185F41A30", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x5F45580", Offset = "0x5F44980", VA = "0x185F45580", Slot = "9")]
		protected override bool WHQBQPGRROV()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x5F48700", Offset = "0x5F47B00", VA = "0x185F48700")]
		protected TVQIARPFAJT([In] SyncData data, a a, b b, c c, d d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x5F47330", Offset = "0x5F46730", VA = "0x185F47330")]
		protected TVQIARPFAJT(JCSDFORPEFX a, BZXWFWBHLFW b, string c, a d, b e, c f, d g, NetworkSetterPermissionMode h, bool i, Action j, KEIZMPCKSCC k)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x5F09FF0", Offset = "0x5F093F0", VA = "0x185F09FF0")]
		public a EDXPXIDLFFD()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x5F40300", Offset = "0x5F3F700", VA = "0x185F40300")]
		public void AQOLGNZOEAF(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x5F09F80", Offset = "0x5F09380", VA = "0x185F09F80")]
		public b EDHVFNVTCXC()
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x5F3F090", Offset = "0x5F3E490", VA = "0x185F3F090")]
		public void APYQOTRWBSE(b a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x5F09FC0", Offset = "0x5F093C0", VA = "0x185F09FC0")]
		public c EDNCCUPQMIL()
		{
			return (c)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x5F3F620", Offset = "0x5F3EA20", VA = "0x185F3F620")]
		public void AQDXMALTLDN(c a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x137A970", Offset = "0x1379D70", VA = "0x18137A970")]
		public d EENKPCLDHNE()
		{
			return (d)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x5F3E320", Offset = "0x5F3D720", VA = "0x185F3E320")]
		public void APOCUGEBIVM(d a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x5F43600", Offset = "0x5F42A00", VA = "0x185F43600")]
		public void Set(a newValue1, b newValue2, c newValue3, d newValue4, bool checkPermission = true)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public abstract class TVLBDKVHQYK<a, b, c, d, e> : ZCNCOROGCBS
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private a YMIJYOPOLUP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private b YMNQVVJLVFY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private c YMSXTCDJERH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private d YMYEQIXGOCQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private e YNDLNPRDXNZ;

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		protected virtual a VPVSNDBFPKQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0xAB5E80", Offset = "0xAB5280", VA = "0x180AB5E80", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(RVA = "0xAB5E50", Offset = "0xAB5250", VA = "0x180AB5E50", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		protected virtual b VQLNEXIXRSR
		{
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0x11863E0", Offset = "0x11857E0", VA = "0x1811863E0", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0x1186830", Offset = "0x1185C30", VA = "0x181186830", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		protected virtual c VQGGHQPAIHI
		{
			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0xB22530", Offset = "0xB21930", VA = "0x180B22530", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return (c)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0xB22460", Offset = "0xB21860", VA = "0x180B22460", Slot = "15")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		protected virtual d VQWAZKWSKPJ
		{
			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0xABF180", Offset = "0xABE580", VA = "0x180ABF180", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return (d)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0xACEF60", Offset = "0xACE360", VA = "0x180ACEF60", Slot = "17")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		protected virtual e VQQUCECVBEA
		{
			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0xABEDD0", Offset = "0xABE1D0", VA = "0x180ABEDD0", Slot = "18")]
			[CompilerGenerated]
			get
			{
				return (e)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0x5F39910", Offset = "0x5F38D10", VA = "0x185F39910", Slot = "19")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		protected override object PQRAXCKXLAV
		{
			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0x5F0B090", Offset = "0x5F0A490", VA = "0x185F0B090", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(RVA = "0x5F368F0", Offset = "0x5F35CF0", VA = "0x185F368F0", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x5F39630", Offset = "0x5F38A30", VA = "0x185F39630", Slot = "9")]
		protected override bool WHQBQPGRROV()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x5F3A450", Offset = "0x5F39850", VA = "0x185F3A450")]
		protected TVLBDKVHQYK(JCSDFORPEFX a, BZXWFWBHLFW b, string c, a d, b e, c f, d g, e h, NetworkSetterPermissionMode i, bool j, Action k, KEIZMPCKSCC l)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x5F09FF0", Offset = "0x5F093F0", VA = "0x185F09FF0")]
		public a EDXPXIDLFFD()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x5F36170", Offset = "0x5F35570", VA = "0x185F36170")]
		public void AQOLGNZOEAF(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x1417D20", Offset = "0x1417120", VA = "0x181417D20")]
		public b EDHVFNVTCXC()
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x5F35680", Offset = "0x5F34A80", VA = "0x185F35680")]
		public void APYQOTRWBSE(b a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x5A99330", Offset = "0x5A98730", VA = "0x185A99330")]
		public c EDNCCUPQMIL()
		{
			return (c)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x5F35B20", Offset = "0x5F34F20", VA = "0x185F35B20")]
		public void AQDXMALTLDN(c a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x137A970", Offset = "0x1379D70", VA = "0x18137A970")]
		public d EENKPCLDHNE()
		{
			return (d)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x5F34E50", Offset = "0x5F34250", VA = "0x185F34E50")]
		public void APOCUGEBIVM(d a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x5F364A0", Offset = "0x5F358A0", VA = "0x185F364A0")]
		public e EESRMJFAQYN()
		{
			return (e)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x5F351F0", Offset = "0x5F345F0", VA = "0x185F351F0")]
		public void APTJRMXYSGV(e a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x5F379D0", Offset = "0x5F36DD0", VA = "0x185F379D0")]
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
