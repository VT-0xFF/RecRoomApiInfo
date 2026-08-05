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
	public interface JHOQVNBWMWQ : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		bool HNVKFQMOIRL
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		bool MCQHHHDSNKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		XGOJTPBZDNO MZTSDSYRBJR
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		int IMMPYZUISYS
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		bool KFZXCHAXQKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		bool ECIYWEPIJVE
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		event Action EBPBWLXYDAT;

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void EVMOOSRRQSC();

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void PKBDTRBTSLK(object a, bool b);

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void KURZFRSCQUS();
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface POKVTIYVPRT : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000007")]
		string DCXGLLCDHCG
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		bool NTRGTGURVPW
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface YOCQPYKPABE<a> : POKVTIYVPRT, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		a KKJDFPSWCHI
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void UFYHXCIXBXR(a a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public sealed class QSZYQROTDXV<a> : YOCQPYKPABE<a>, POKVTIYVPRT, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private readonly QQCHIMCPOEY<a> SPGCBKPGRWK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private readonly QQCHIMCPOEY<a> YPKERAKLNWB;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public string DCXGLLCDHCG
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xFA91D0", Offset = "0xFA7FD0", VA = "0x180FA91D0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool VDMFOCHQMYY
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x5E2ED50", Offset = "0x5E2DB50", VA = "0x185E2ED50", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public a MYFCTOMGTFV
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x5E2D710", Offset = "0x5E2C510", VA = "0x185E2D710", Slot = "11")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x5E31B30", Offset = "0x5E30930", VA = "0x185E31B30", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public a KKJDFPSWCHI
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x5E2D8B0", Offset = "0x5E2C6B0", VA = "0x185E2D8B0", Slot = "4")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x5E2F340", Offset = "0x5E2E140", VA = "0x185E2F340", Slot = "13")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public a REKHREVTQMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x5E2D8B0", Offset = "0x5E2C6B0", VA = "0x185E2D8B0")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x5E302E0", Offset = "0x5E2F0E0", VA = "0x185E302E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool NTRGTGURVPW
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x5E2BEF0", Offset = "0x5E2ACF0", VA = "0x185E2BEF0", Slot = "7")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x5E2CDC0", Offset = "0x5E2BBC0", VA = "0x185E2CDC0", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool SCUFOCJJZIG
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x5E2D6C0", Offset = "0x5E2C4C0", VA = "0x185E2D6C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5E2DBC0", Offset = "0x5E2C9C0", VA = "0x185E2DBC0", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5E325C0", Offset = "0x5E313C0", VA = "0x185E325C0")]
		public QSZYQROTDXV([In] SyncData data, a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5E2E3F0", Offset = "0x5E2D1F0", VA = "0x185E2E3F0")]
		private void SEEVGUXJCMQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5E30EA0", Offset = "0x5E2FCA0", VA = "0x185E30EA0", Slot = "5")]
		public void UFYHXCIXBXR(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5E306A0", Offset = "0x5E2F4A0", VA = "0x185E306A0")]
		public void UFYHXCIXBXR(a a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5E2B710", Offset = "0x5E2A510", VA = "0x185E2B710", Slot = "8")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public sealed class QTFFNYIQNJE<a, b> : YOCQPYKPABE<(a, b)>, POKVTIYVPRT, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly QQSCAGKHQMZ<a, b> SPGCBKPGRWK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private readonly QQSCAGKHQMZ<a, b> YPKERAKLNWB;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public string DCXGLLCDHCG
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0xFA91D0", Offset = "0xFA7FD0", VA = "0x180FA91D0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool VDMFOCHQMYY
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x5E37460", Offset = "0x5E36260", VA = "0x185E37460", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool MYMMWLPPUCP
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x5E34700", Offset = "0x5E33500", VA = "0x185E34700")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool MYRTTSJNDNY
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x5E34880", Offset = "0x5E33680", VA = "0x185E34880")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public (a, b) MYFCTOMGTFV
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x5E35560", Offset = "0x5E34360", VA = "0x185E35560", Slot = "11")]
			get
			{
				return default((a, b));
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x5E38FB0", Offset = "0x5E37DB0", VA = "0x185E38FB0", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public (a, b) KKJDFPSWCHI
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x5E35B20", Offset = "0x5E34920", VA = "0x185E35B20", Slot = "4")]
			get
			{
				return default((a, b));
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x5E37CF0", Offset = "0x5E36AF0", VA = "0x185E37CF0", Slot = "13")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public (a, b) REKHREVTQMM
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x5E39550", Offset = "0x5E38350", VA = "0x185E39550")]
			get
			{
				return default((a, b));
			}
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x5E37E20", Offset = "0x5E36C20", VA = "0x185E37E20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public a LAPNBKXFCGK
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x5E35620", Offset = "0x5E34420", VA = "0x185E35620")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x5E36C40", Offset = "0x5E35A40", VA = "0x185E36C40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public a DSNZTIRMUXP
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x5E34F10", Offset = "0x5E33D10", VA = "0x185E34F10")]
			get
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public a UZAWKNMKXET
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x5E34F10", Offset = "0x5E33D10", VA = "0x185E34F10")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x5E3A130", Offset = "0x5E38F30", VA = "0x185E3A130")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public b LAKGEEDHSVB
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x5E35700", Offset = "0x5E34500", VA = "0x185E35700")]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x5E36EB0", Offset = "0x5E35CB0", VA = "0x185E36EB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public b DRYFBOJUSPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x5E34EC0", Offset = "0x5E33CC0", VA = "0x185E34EC0")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public b UZGDHUGIGQC
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x5E34EC0", Offset = "0x5E33CC0", VA = "0x185E34EC0")]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x5E39860", Offset = "0x5E38660", VA = "0x185E39860")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public bool NTRGTGURVPW
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x5E2BEF0", Offset = "0x5E2ACF0", VA = "0x185E2BEF0", Slot = "7")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x5E2CDC0", Offset = "0x5E2BBC0", VA = "0x185E2CDC0", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x5E362A0", Offset = "0x5E350A0", VA = "0x185E362A0", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x5E3A420", Offset = "0x5E39220", VA = "0x185E3A420")]
		public QTFFNYIQNJE([In] SyncData data, a a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x5E36350", Offset = "0x5E35150", VA = "0x185E36350")]
		private void SEEVGUXJCMQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x5E34300", Offset = "0x5E33100", VA = "0x185E34300")]
		public void ARFSFYUZJOI(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x5E38170", Offset = "0x5E36F70", VA = "0x185E38170")]
		public void UFYHXCIXBXR(a a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x5E383B0", Offset = "0x5E371B0", VA = "0x185E383B0", Slot = "5")]
		private void VKLFYXPOOIY((a, b) a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x5E2B710", Offset = "0x5E2A510", VA = "0x185E2B710", Slot = "8")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public sealed class QTKMLFCNWUN<a, b, c> : YOCQPYKPABE<(a, b, c)>, POKVTIYVPRT, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly QQMVCZQKHBQ<a, b, c> SPGCBKPGRWK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly QQMVCZQKHBQ<a, b, c> YPKERAKLNWB;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public string DCXGLLCDHCG
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0xFA91D0", Offset = "0xFA7FD0", VA = "0x180FA91D0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public bool VDMFOCHQMYY
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x5E3BD50", Offset = "0x5E3AB50", VA = "0x185E3BD50", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool MYMMWLPPUCP
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x5E3B2F0", Offset = "0x5E3A0F0", VA = "0x185E3B2F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public bool MYRTTSJNDNY
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x5E3B4B0", Offset = "0x5E3A2B0", VA = "0x185E3B4B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public bool MYXAQZDKMZH
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x5E3B3D0", Offset = "0x5E3A1D0", VA = "0x185E3B3D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public (a, b, c) MYFCTOMGTFV
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x5E3B620", Offset = "0x5E3A420", VA = "0x185E3B620", Slot = "11")]
			get
			{
				return default((a, b, c));
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x5E3BF60", Offset = "0x5E3AD60", VA = "0x185E3BF60", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public (a, b, c) KKJDFPSWCHI
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x5E3B920", Offset = "0x5E3A720", VA = "0x185E3B920", Slot = "4")]
			get
			{
				return default((a, b, c));
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x5E3BED0", Offset = "0x5E3ACD0", VA = "0x185E3BED0", Slot = "13")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public a LAPNBKXFCGK
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x5E3B7D0", Offset = "0x5E3A5D0", VA = "0x185E3B7D0")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x5E3BBB0", Offset = "0x5E3A9B0", VA = "0x185E3BBB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public a DSNZTIRMUXP
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x5E3B5F0", Offset = "0x5E3A3F0", VA = "0x185E3B5F0")]
			get
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public a UZAWKNMKXET
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x5E3B5F0", Offset = "0x5E3A3F0", VA = "0x185E3B5F0")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x5E3C330", Offset = "0x5E3B130", VA = "0x185E3C330")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public b LAKGEEDHSVB
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x5E3B800", Offset = "0x5E3A600", VA = "0x185E3B800")]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x5E3BC40", Offset = "0x5E3AA40", VA = "0x185E3BC40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public b DRYFBOJUSPO
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x5E3B5C0", Offset = "0x5E3A3C0", VA = "0x185E3B5C0")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public b UZGDHUGIGQC
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x5E3B5C0", Offset = "0x5E3A3C0", VA = "0x185E3B5C0")]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x5E3C290", Offset = "0x5E3B090", VA = "0x185E3C290")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public c LAEZGXJKJJS
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x5E3B830", Offset = "0x5E3A630", VA = "0x185E3B830")]
			get
			{
				return (c)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x5E3BCD0", Offset = "0x5E3AAD0", VA = "0x185E3BCD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public c DSDLYVDSCAX
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x5E3B590", Offset = "0x5E3A390", VA = "0x185E3B590")]
			get
			{
				return (c)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public c UZLKFBAFQBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x5E3B590", Offset = "0x5E3A390", VA = "0x185E3B590")]
			get
			{
				return (c)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x5E3C200", Offset = "0x5E3B000", VA = "0x185E3C200")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool NTRGTGURVPW
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x5E2BEF0", Offset = "0x5E2ACF0", VA = "0x185E2BEF0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x5E3BA10", Offset = "0x5E3A810", VA = "0x185E3BA10", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x5E3C3D0", Offset = "0x5E3B1D0", VA = "0x185E3C3D0")]
		public QTKMLFCNWUN([In] SyncData data, a a, b b, c c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x5E3BAC0", Offset = "0x5E3A8C0", VA = "0x185E3BAC0")]
		private void SEEVGUXJCMQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x5E3B230", Offset = "0x5E3A030", VA = "0x185E3B230")]
		public void ARFSFYUZJOI(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x5E3B860", Offset = "0x5E3A660", VA = "0x185E3B860")]
		public void OPHQLIXLHMH(b a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x5E3B710", Offset = "0x5E3A510", VA = "0x185E3B710")]
		public void LIJONQNDRQO(c a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x5E3BF20", Offset = "0x5E3AD20", VA = "0x185E3BF20")]
		public void UFYHXCIXBXR(a a, b b, c c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x5E3C1A0", Offset = "0x5E3AFA0", VA = "0x185E3C1A0", Slot = "5")]
		private void XIJSQKZIYNL((a, b, c) a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x5E2B710", Offset = "0x5E2A510", VA = "0x185E2B710", Slot = "8")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public sealed class QRZQEJTGITC<a, b, c, d> : YOCQPYKPABE<(a, b, c, d)>, POKVTIYVPRT, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly QRCPUTYCJJR<a, b, c, d> SPGCBKPGRWK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly QRCPUTYCJJR<a, b, c, d> YPKERAKLNWB;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public string DCXGLLCDHCG
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xFA91D0", Offset = "0xFA7FD0", VA = "0x180FA91D0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public (a, b, c, d) KKJDFPSWCHI
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x5E2BDD0", Offset = "0x5E2ABD0", VA = "0x185E2BDD0", Slot = "4")]
			get
			{
				return default((a, b, c, d));
			}
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x5E2CA50", Offset = "0x5E2B850", VA = "0x185E2CA50", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public b DRYFBOJUSPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x5E2B830", Offset = "0x5E2A630", VA = "0x185E2B830")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public c DSDLYVDSCAX
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x5E2B750", Offset = "0x5E2A550", VA = "0x185E2B750")]
			get
			{
				return (c)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public d DRNRHAVZZSW
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x5E2B9C0", Offset = "0x5E2A7C0", VA = "0x185E2B9C0")]
			get
			{
				return (d)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool NTRGTGURVPW
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x5E2BEF0", Offset = "0x5E2ACF0", VA = "0x185E2BEF0", Slot = "7")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x5E2CDC0", Offset = "0x5E2BBC0", VA = "0x185E2CDC0", Slot = "10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x5E2D4C0", Offset = "0x5E2C2C0", VA = "0x185E2D4C0")]
		public QRZQEJTGITC([In] SyncData data, a a, b b, c c, d d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x5E2BF10", Offset = "0x5E2AD10", VA = "0x185E2BF10")]
		private void SEEVGUXJCMQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x5E2B360", Offset = "0x5E2A160", VA = "0x185E2B360")]
		public void ARFSFYUZJOI(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x5E2CAA0", Offset = "0x5E2B8A0", VA = "0x185E2CAA0")]
		public void UFYHXCIXBXR(a a, b b, c c, d d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x5E2C2B0", Offset = "0x5E2B0B0", VA = "0x185E2C2B0", Slot = "5")]
		private void SXETKEBEABL((a, b, c, d) a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x5E2B710", Offset = "0x5E2A510", VA = "0x185E2B710", Slot = "8")]
		public void Dispose()
		{
		}
	}
}
namespace RecRoom.Networking.Policy
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class SVALMMOOBYC
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x86D7660", Offset = "0x86D6460", VA = "0x1886D7660")]
		public static string AFZQZICFONH(this SyncData a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xB16790", Offset = "0xB15590", VA = "0x180B16790")]
		public static NetworkSetterPermissionMode AYKAMUNELLY(this SyncData a)
		{
			return default(NetworkSetterPermissionMode);
		}
	}
}
namespace RecRoom.Networking.SynchronizedFields
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class QQCHIMCPOEY<a> : EROAWHMHQQB<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x5E22000", Offset = "0x5E20E00", VA = "0x185E22000")]
		public QQCHIMCPOEY([In] SyncData data, a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x5E200A0", Offset = "0x5E1EEA0", VA = "0x185E200A0")]
		public QQCHIMCPOEY(ZNLKIYOYHAH a, XGOJTPBZDNO b, string c, a d, NetworkSetterPermissionMode e, [Optional] Action f, [Optional] IJEAQFHLEGH g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x5E206C0", Offset = "0x5E1F4C0", VA = "0x185E206C0")]
		public QQCHIMCPOEY(ZNLKIYOYHAH a, string b, a c, NetworkSetterPermissionMode d, [Optional] Action e, [Optional] IJEAQFHLEGH f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x5E1F620", Offset = "0x5E1E420", VA = "0x185E1F620")]
		public QQCHIMCPOEY(ZNLKIYOYHAH a, string b, a c, NetworkSetterPermissionMode d, bool e, [Optional] Action f, [Optional] IJEAQFHLEGH g)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class QQSCAGKHQMZ<a, b> : EQYGENEPOIA<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x5E25CA0", Offset = "0x5E24AA0", VA = "0x185E25CA0")]
		public QQSCAGKHQMZ([In] SyncData data, a a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x5E26850", Offset = "0x5E25650", VA = "0x185E26850")]
		public QQSCAGKHQMZ(ZNLKIYOYHAH a, XGOJTPBZDNO b, string c, a d, b e, NetworkSetterPermissionMode f, [Optional] Action g, [Optional] IJEAQFHLEGH h)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x5E244F0", Offset = "0x5E232F0", VA = "0x185E244F0")]
		public QQSCAGKHQMZ(ZNLKIYOYHAH a, string b, a c, b d, NetworkSetterPermissionMode e, [Optional] Action f, [Optional] IJEAQFHLEGH g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x5E246C0", Offset = "0x5E234C0", VA = "0x185E246C0")]
		public QQSCAGKHQMZ(ZNLKIYOYHAH a, string b, a c, b d, NetworkSetterPermissionMode e, bool f, [Optional] Action g, [Optional] IJEAQFHLEGH h)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class QQMVCZQKHBQ<a, b, c> : ERDNBTYMXTJ<a, b, c>
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x5E23AB0", Offset = "0x5E228B0", VA = "0x185E23AB0")]
		public QQMVCZQKHBQ([In] SyncData data, a a, b b, c c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x5E22D30", Offset = "0x5E21B30", VA = "0x185E22D30")]
		public QQMVCZQKHBQ(ZNLKIYOYHAH a, string b, a c, b d, c e, NetworkSetterPermissionMode f, [Optional] Action g, [Optional] IJEAQFHLEGH h)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class QRCPUTYCJJR<a, b, c, d> : ESDVOBTZSYC<a, b, c, d>
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x5E2A150", Offset = "0x5E28F50", VA = "0x185E2A150")]
		public QRCPUTYCJJR([In] SyncData data, a a, b b, c c, d d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x5E2ACE0", Offset = "0x5E29AE0", VA = "0x185E2ACE0")]
		public QRCPUTYCJJR(ZNLKIYOYHAH a, XGOJTPBZDNO b, string c, a d, b e, c f, d g, NetworkSetterPermissionMode h, [Optional] Action i, [Optional] IJEAQFHLEGH j)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x5E2ABB0", Offset = "0x5E299B0", VA = "0x185E2ABB0")]
		public QRCPUTYCJJR(ZNLKIYOYHAH a, string b, a c, b d, c e, d f, NetworkSetterPermissionMode g, [Optional] Action h, [Optional] IJEAQFHLEGH i)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class QQXIXNEEZYI<a, b, c, d, e> : ESJCLINXCJL<a, b, c, d, e>
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x5E28500", Offset = "0x5E27300", VA = "0x185E28500")]
		public QQXIXNEEZYI(ZNLKIYOYHAH a, XGOJTPBZDNO b, string c, a d, b e, c f, d g, e h, NetworkSetterPermissionMode i, [Optional] Action j, [Optional] IJEAQFHLEGH k)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x5E291C0", Offset = "0x5E27FC0", VA = "0x185E291C0")]
		public QQXIXNEEZYI(ZNLKIYOYHAH a, string b, a c, b d, c e, d f, e g, NetworkSetterPermissionMode h, [Optional] Action i, [Optional] IJEAQFHLEGH j)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class KPHEYRMKKVJ<a> : EROAWHMHQQB<a>
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x54C5D40", Offset = "0x54C4B40", VA = "0x1854C5D40")]
		public KPHEYRMKKVJ(XGOJTPBZDNO a, string b, a c, [Optional] Action d, [Optional] IJEAQFHLEGH e)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class KPMLVYGHUGS<a, b> : EQYGENEPOIA<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x54C5ED0", Offset = "0x54C4CD0", VA = "0x1854C5ED0")]
		public KPMLVYGHUGS(XGOJTPBZDNO a, string b, a c, b d, [Optional] Action e, [Optional] IJEAQFHLEGH f)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public interface IYZLYLYNPMR
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "0")]
		QQCHIMCPOEY<a> BTSNIXOXQSB<a>(string a, a b, NetworkSetterPermissionMode c, [Optional] Action d);
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class KIALEKLOLOK : IYZLYLYNPMR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly IJEAQFHLEGH MADAVXOVKVO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly ZNLKIYOYHAH ADKEKNLASFE;

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0xABFA30", Offset = "0xABE830", VA = "0x180ABFA30")]
		public KIALEKLOLOK(IJEAQFHLEGH a, ZNLKIYOYHAH b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x39E59B0", Offset = "0x39E47B0", VA = "0x1839E59B0", Slot = "4")]
		public QQCHIMCPOEY<a> BTSNIXOXQSB<a>(string a, a b, NetworkSetterPermissionMode c, [Optional] Action d)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public interface HRGIJDBXRTW : ZNLKIYOYHAH
	{
		[Cpp2IlInjected.Token(Token = "0x17000036")]
		ViewId KUSKCIRACRA
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public interface ZNLKIYOYHAH
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		bool PROXLXCNZXU
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		bool AURCHPLFRYG
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		string SVKBYNEZAWG
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		bool MYVNAIANAOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void RegisterDestroyHandler(SLWJPQELUAZ handler);

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void UnregisterDestroyHandler(SLWJPQELUAZ handler);
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public static class BZCHZFRPBUB
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x86D7610", Offset = "0x86D6410", VA = "0x1886D7610")]
		public static bool NXZJIEEDLSS(this ZNLKIYOYHAH a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface IJEAQFHLEGH : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		XGOJTPBZDNO BATNORFFEXB
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		bool SCUFOCJJZIG
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		bool QPWLCIFHQJV
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
		object LXHEFIZOGBN(string a);

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "5")]
		object JXWGSNHCNIB(XGOJTPBZDNO a, string b);

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void UTCITMJXTVF(string a, object b);

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void BWENOHDAXUF(XGOJTPBZDNO a, string b, object c);

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void VLQOSESTSKG<a>(string a, a b);

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void WXSIRQVYHNS([CanBeNull] XGOJTPBZDNO photonPlayer, string a, ZQLNMWUAXWD b);

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void WFVLSKMVBCR([CanBeNull] XGOJTPBZDNO photonPlayer, string a, ZQLNMWUAXWD b);

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "11")]
		b KXIGHXRCCXJ<b>(object a);

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "12")]
		object XAEYNBFICAC<c>(c a);

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(Slot = "13")]
		void RYVIKUFREUL();

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void PNVZNWZGVPD();

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void JUWSFQGKYHK(string a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public struct SyncData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public XGOJTPBZDNO player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public ZNLKIYOYHAH context;

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
		public IJEAQFHLEGH networkBacking;

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x86D76F0", Offset = "0x86D64F0", VA = "0x1886D76F0")]
		public SyncData(SyncData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x86D7770", Offset = "0x86D6570", VA = "0x1886D7770")]
		public SyncData(ZNLKIYOYHAH context, string key, NetworkSetterPermissionMode permissionMode, [Optional] Action callback, [Optional] IJEAQFHLEGH networkBacking)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x86D76A0", Offset = "0x86D64A0", VA = "0x1886D76A0")]
		public static SyncData From(ZNLKIYOYHAH context, string key, NetworkSetterPermissionMode permissionMode, [Optional] Action callback, [Optional] IJEAQFHLEGH networkBacking)
		{
			return default(SyncData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public static class QLYFQBUYHVE
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x3C24D40", Offset = "0x3C23B40", VA = "0x183C24D40")]
		public static QQCHIMCPOEY<a> ZQLNMWUAXWD<a>(this SyncData a, a b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x3C24330", Offset = "0x3C23130", VA = "0x183C24330")]
		public static QQSCAGKHQMZ<b, c> ZQLNMWUAXWD<b, c>(this SyncData a, b b, c c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x3C243D0", Offset = "0x3C231D0", VA = "0x183C243D0")]
		public static QQMVCZQKHBQ<d, e, f> ZQLNMWUAXWD<d, e, f>(this SyncData a, d b, e c, f d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x3C247F0", Offset = "0x3C235F0", VA = "0x183C247F0")]
		public static QRCPUTYCJJR<g, h, i, j> ZQLNMWUAXWD<g, h, i, j>(this SyncData a, g b, h c, i d, j e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x3C23380", Offset = "0x3C22180", VA = "0x183C23380")]
		public static QSZYQROTDXV<k> YCSXUFJNGRC<k>(this SyncData a, k b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x3C23230", Offset = "0x3C22030", VA = "0x183C23230")]
		public static QTFFNYIQNJE<l, m> YCSXUFJNGRC<l, m>(this SyncData a, l b, m c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x3C232D0", Offset = "0x3C220D0", VA = "0x183C232D0")]
		public static QTKMLFCNWUN<n, o, p> YCSXUFJNGRC<n, o, p>(this SyncData a, n b, o c, p d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x3C23D40", Offset = "0x3C22B40", VA = "0x183C23D40")]
		public static QRZQEJTGITC<q, r, s, t> YCSXUFJNGRC<q, r, s, t>(this SyncData a, q b, r c, s d, t e)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public abstract class ZQLNMWUAXWD : SLWJPQELUAZ, IDisposable
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
		private static Stack<IJEAQFHLEGH> CPHTENNGXGR;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static bool NLROCASOXRO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		protected readonly XGOJTPBZDNO HRDEMWTKXBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		protected readonly ZNLKIYOYHAH ADKEKNLASFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		protected readonly string NFCNRPBPDKW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		protected readonly NetworkSetterPermissionMode UGDCWTANPHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		protected readonly Action ISCZYLVFJQU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		protected IJEAQFHLEGH QUIILMCDLUU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private Flags MHVIMQAZAKC;

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public static IJEAQFHLEGH DQTHSDCOFSH
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x86DB410", Offset = "0x86DA210", VA = "0x1886DB410")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		private bool RQQKCFSQCIP
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x86DB730", Offset = "0x86DA530", VA = "0x1886DB730")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x86DA840", Offset = "0x86D9640", VA = "0x1886DA840")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		private bool DFWUHSKVXBE
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x86DA670", Offset = "0x86D9470", VA = "0x1886DA670")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x86DA4E0", Offset = "0x86D92E0", VA = "0x1886DA4E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		private bool ABIFDRHJQJB
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x86DAE20", Offset = "0x86D9C20", VA = "0x1886DAE20")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x86DB1B0", Offset = "0x86D9FB0", VA = "0x1886DB1B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public bool NTRGTGURVPW
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x86DAC90", Offset = "0x86D9A90", VA = "0x1886DAC90")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x86DB5D0", Offset = "0x86DA3D0", VA = "0x1886DB5D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		protected virtual object NJNGLULNCQC
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D30", Offset = "0xABFB30", VA = "0x180AC0D30", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0xAC1370", Offset = "0xAC0170", VA = "0x180AC1370", Slot = "8")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public bool ZVQLYIBIYBL
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x86DAB70", Offset = "0x86D9970", VA = "0x1886DAB70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public int IGXHDWGYRWG
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0xECA790", Offset = "0xEC9590", VA = "0x180ECA790")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x1A8D0D0", Offset = "0x1A8BED0", VA = "0x181A8D0D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public string DCXGLLCDHCG
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D20", Offset = "0xAC0B20", VA = "0x180AC1D20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public bool SCUFOCJJZIG
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x86DA7F0", Offset = "0x86D95F0", VA = "0x1886DA7F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x86DB690", Offset = "0x86DA490", VA = "0x1886DB690")]
		public static void ZCWSGLDYEFU(IJEAQFHLEGH a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(Slot = "9")]
		protected abstract bool OGNBFCPMXHK();

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x86DB7D0", Offset = "0x86DA5D0", VA = "0x1886DB7D0")]
		protected ZQLNMWUAXWD(XGOJTPBZDNO a, ZNLKIYOYHAH b, string c, NetworkSetterPermissionMode d, Action e, IJEAQFHLEGH f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x86DA680", Offset = "0x86D9480", VA = "0x1886DA680", Slot = "1")]
		~ZQLNMWUAXWD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x86DA500", Offset = "0x86D9300", VA = "0x1886DA500", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x86DB210", Offset = "0x86DA010", VA = "0x1886DB210")]
		private void TTEJTOLIYFA(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x86DA370", Offset = "0x86D9170", VA = "0x1886DA370")]
		private object ARGHBBRLHQK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x86DA860", Offset = "0x86D9660", VA = "0x1886DA860")]
		protected void Initialize(bool enforceInitialValue, object initialValue, bool initialValueIsDefaultValue = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x86DB1D0", Offset = "0x86D9FD0", VA = "0x1886DB1D0")]
		protected void Set(object newValue, bool checkPermission = true, bool suppressCallback = false, bool requireModified = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x86DA120", Offset = "0x86D8F20", VA = "0x1886DA120")]
		protected void ABVKZSNIBUT(object a, bool b, bool c, bool d = false, bool e = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x86DAEC0", Offset = "0x86D9CC0", VA = "0x1886DAEC0")]
		internal void RELEANNNYLF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x86DABC0", Offset = "0x86D99C0", VA = "0x1886DABC0")]
		private void NTAAIEKTHQB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x86DAB10", Offset = "0x86D9910", VA = "0x1886DAB10")]
		private void MCSSSYEJDPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x86DAC20", Offset = "0x86D9A20", VA = "0x1886DAC20", Slot = "4")]
		private void PCFLHXLCVPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x86DAE10", Offset = "0x86D9C10", VA = "0x1886DAE10", Slot = "5")]
		private void QKENWBRJZDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x86DACC0", Offset = "0x86D9AC0", VA = "0x1886DACC0")]
		public bool PXBZUXHOUZP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x86DAF40", Offset = "0x86D9D40", VA = "0x1886DAF40")]
		public bool RXBZJBPYCLH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x86DB480", Offset = "0x86DA280", VA = "0x1886DB480")]
		private bool YWRPCSQCLEC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x86DB100", Offset = "0x86D9F00", VA = "0x1886DB100")]
		internal void SNBTBWWOQZZ(object a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x86DA6E0", Offset = "0x86D94E0", VA = "0x1886DA6E0")]
		private void GIQKQGFBWFP(object a, bool b, bool c = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x86DAE00", Offset = "0x86D9C00", VA = "0x1886DAE00")]
		private bool QAZKSBFZMUL(Flags a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x86DACA0", Offset = "0x86D9AA0", VA = "0x1886DACA0")]
		private void PHLMBCICBDN(Flags a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x86DAE30", Offset = "0x86D9C30", VA = "0x1886DAE30")]
		public static string QSQSCGFDSRH(XGOJTPBZDNO a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x86DAA30", Offset = "0x86D9830", VA = "0x1886DAA30")]
		public static string JHBFCLBLGLX(ZNLKIYOYHAH a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x86DB2B0", Offset = "0x86DA0B0", VA = "0x1886DB2B0")]
		public static bool WDUGPGXDFSH(object a, object b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public abstract class ZIVKKZTLIAR : IJEAQFHLEGH, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly Dictionary<object, object> HUXATMGWFGW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly List<string> ETUAMPBQDYC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly Dictionary<object, object> YSDECPGYCWI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly List<string> XHEVFPCIHMQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private bool UYCAAIVFHWU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		protected readonly Dictionary<string, object> WWVZLZCNBTU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		protected readonly Dictionary<XGOJTPBZDNO, Dictionary<string, object>> NMJPVWNPLXS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly HashSet<string> SDKCQDDRYMJ;

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public abstract Dictionary<object, object> INXJJTEMHNX
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(Slot = "21")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public abstract int FTYKUSGMDWC
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(Slot = "22")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public abstract XGOJTPBZDNO BATNORFFEXB
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(Slot = "23")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public abstract bool SCUFOCJJZIG
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(Slot = "24")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public abstract bool QPWLCIFHQJV
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(Slot = "25")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public virtual bool MVVTCIUUIWQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0xAD8CA0", Offset = "0xAD7AA0", VA = "0x180AD8CA0", Slot = "26")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public bool XYSPVSPMHUE
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0xC12EC0", Offset = "0xC11CC0", VA = "0x180C12EC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x3EAB7F0", Offset = "0x3EAA5F0", VA = "0x183EAB7F0", Slot = "12")]
		public void VLQOSESTSKG<a>(string a, a b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x86D7A00", Offset = "0x86D6800", VA = "0x1886D7A00", Slot = "11")]
		public void BWENOHDAXUF(XGOJTPBZDNO a, string b, object c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x86D8560", Offset = "0x86D7360", VA = "0x1886D8560", Slot = "9")]
		public object JXWGSNHCNIB(XGOJTPBZDNO a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x86D97C0", Offset = "0x86D85C0", VA = "0x1886D97C0", Slot = "10")]
		public void UTCITMJXTVF(string a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x86D8660", Offset = "0x86D7460", VA = "0x1886D8660", Slot = "8")]
		public object LXHEFIZOGBN(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x86D9D80", Offset = "0x86D8B80", VA = "0x1886D9D80", Slot = "13")]
		public void WXSIRQVYHNS(XGOJTPBZDNO a, string b, ZQLNMWUAXWD c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x86D9AE0", Offset = "0x86D88E0", VA = "0x1886D9AE0", Slot = "14")]
		public void WFVLSKMVBCR(XGOJTPBZDNO a, string b, ZQLNMWUAXWD c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x86D9E90", Offset = "0x86D8C90", VA = "0x1886D9E90")]
		private void XGDQVPUCCVX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x86D9EE0", Offset = "0x86D8CE0", VA = "0x1886D9EE0")]
		private void YBWTYFVQRHR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x86D7910", Offset = "0x86D6710", VA = "0x1886D7910")]
		private void AZAWIFKFOCG(XGOJTPBZDNO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x86D8700", Offset = "0x86D7500", VA = "0x1886D8700")]
		protected void MIYJRAGLRSI(XGOJTPBZDNO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x86D7CC0", Offset = "0x86D6AC0", VA = "0x1886D7CC0")]
		protected void ERAVYGDVBJW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x86D7CB0", Offset = "0x86D6AB0", VA = "0x1886D7CB0")]
		protected void EEQLACXBBPK(IDictionary<object, object> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x86D8C60", Offset = "0x86D7A60", VA = "0x1886D8C60")]
		protected void QJVUCHJVJII(XGOJTPBZDNO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x86D7970", Offset = "0x86D6770", VA = "0x1886D7970")]
		protected void BEDAQGQXBKS(XGOJTPBZDNO a, IDictionary<object, object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x86D8CD0", Offset = "0x86D7AD0", VA = "0x1886D8CD0")]
		private void QLHJTLWVAOV(IDictionary<object, object> a, Dictionary<string, object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x86D98E0", Offset = "0x86D86E0", VA = "0x1886D98E0")]
		private static void VFONTJCFAGR(object a, object b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x86D9280", Offset = "0x86D8080", VA = "0x1886D9280")]
		private static void RWDWMINLCIY(Dictionary<string, object> a, string b, ZQLNMWUAXWD c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x86D8110", Offset = "0x86D6F10", VA = "0x1886D8110")]
		private static void HJIMNLGLQCT(Dictionary<string, object> a, string b, ZQLNMWUAXWD c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x86D94A0", Offset = "0x86D82A0", VA = "0x1886D94A0", Slot = "17")]
		public void RYVIKUFREUL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(Slot = "27")]
		protected abstract void JYQCBFRSSJY(Dictionary<object, object> a);

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x86D8B80", Offset = "0x86D7980", VA = "0x1886D8B80", Slot = "18")]
		public void PNVZNWZGVPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "28")]
		protected abstract void PEGAZKMWDKY(Dictionary<object, object> a);

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x86D95A0", Offset = "0x86D83A0", VA = "0x1886D95A0")]
		private void UCLFPHWRDZZ(Dictionary<object, object> a, List<string> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x86D7DB0", Offset = "0x86D6BB0", VA = "0x1886D7DB0")]
		private void FXLBJDDDYVA(IDictionary<object, object> a, [Out] int b, [Out] string[] c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x86D91F0", Offset = "0x86D7FF0", VA = "0x1886D91F0")]
		public void ROPHIVCEVGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x86D8040", Offset = "0x86D6E40", VA = "0x1886D8040")]
		public void GOXIYMAHEHL(XGOJTPBZDNO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x86D8820", Offset = "0x86D7620", VA = "0x1886D8820")]
		public void OTXDZAPWKNU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "29")]
		protected abstract HashSet<int> KDBFRUMIHMS(bool a, bool b);

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x86D82E0", Offset = "0x86D70E0", VA = "0x1886D82E0", Slot = "19")]
		public void JUWSFQGKYHK(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x86D9160", Offset = "0x86D7F60", VA = "0x1886D9160")]
		protected string QSQSCGFDSRH(XGOJTPBZDNO a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "30")]
		public abstract object XAEYNBFICAC<b>(b a);

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "31")]
		public abstract c KXIGHXRCCXJ<c>(object a);

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "32")]
		public virtual void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x86D7B50", Offset = "0x86D6950", VA = "0x1886D7B50", Slot = "20")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "33")]
		protected virtual void PMKCSKWXWJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x86D9F30", Offset = "0x86D8D30", VA = "0x1886D9F30")]
		protected ZIVKKZTLIAR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public abstract class EROAWHMHQQB<a> : ZQLNMWUAXWD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private a DEVTHNXBBRK;

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		protected virtual a LBOVBAOOMYP
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x1017310", Offset = "0x1016110", VA = "0x181017310", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x1017300", Offset = "0x1016100", VA = "0x181017300", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		protected override object NJNGLULNCQC
		{
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x4A1EFD0", Offset = "0x4A1DDD0", VA = "0x184A1EFD0", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x4A2E640", Offset = "0x4A2D440", VA = "0x184A2E640", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x4A2FD90", Offset = "0x4A2EB90", VA = "0x184A2FD90", Slot = "9")]
		protected override bool OGNBFCPMXHK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x4A35D40", Offset = "0x4A34B40", VA = "0x184A35D40")]
		protected EROAWHMHQQB([In] SyncData data, a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x4A36F10", Offset = "0x4A35D10", VA = "0x184A36F10")]
		protected EROAWHMHQQB(XGOJTPBZDNO a, ZNLKIYOYHAH b, string c, a d, NetworkSetterPermissionMode e, bool f, Action g, IJEAQFHLEGH h)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x4A2EA40", Offset = "0x4A2D840", VA = "0x184A2EA40")]
		public a Get()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x4A33920", Offset = "0x4A32720", VA = "0x184A33920")]
		public void Set(a newValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x4A33E60", Offset = "0x4A32C60", VA = "0x184A33E60")]
		public void Set(a newValue, bool checkPermission, bool suppressCallback = false, bool requireModified = true)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public abstract class EQYGENEPOIA<a, b> : ZQLNMWUAXWD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private a DEVTHNXBBRK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private b DFLNZIETDZL;

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		protected virtual a LBOVBAOOMYP
		{
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x10E06E0", Offset = "0x10DF4E0", VA = "0x1810E06E0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x12B51B0", Offset = "0x12B3FB0", VA = "0x1812B51B0", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		protected virtual b LBUBYHILWJY
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x31D59E0", Offset = "0x31D47E0", VA = "0x1831D59E0", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x4A19060", Offset = "0x4A17E60", VA = "0x184A19060", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public b QBXYRSTDGPM
		{
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x170A170", Offset = "0x1708F70", VA = "0x18170A170")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		protected override object NJNGLULNCQC
		{
			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x4A1EFD0", Offset = "0x4A1DDD0", VA = "0x184A1EFD0", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x4A17560", Offset = "0x4A16360", VA = "0x184A17560", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x4A19D60", Offset = "0x4A18B60", VA = "0x184A19D60", Slot = "9")]
		protected override bool OGNBFCPMXHK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x4A216A0", Offset = "0x4A204A0", VA = "0x184A216A0")]
		protected EQYGENEPOIA([In] SyncData data, a a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x4A20390", Offset = "0x4A1F190", VA = "0x184A20390")]
		protected EQYGENEPOIA(XGOJTPBZDNO a, ZNLKIYOYHAH b, string c, a d, b e, NetworkSetterPermissionMode f, bool g, Action h, IJEAQFHLEGH i)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x4A1EFF0", Offset = "0x4A1DDF0", VA = "0x184A1EFF0")]
		public a VHEULAIOOQI()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x4A17F80", Offset = "0x4A16D80", VA = "0x184A17F80")]
		public void CZLNEYEERQQ(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x170A170", Offset = "0x1708F70", VA = "0x18170A170")]
		public b VHUPCUQGQYJ()
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x4A18DD0", Offset = "0x4A17BD0", VA = "0x184A18DD0")]
		public void DABHWSLWTYR(b a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x4A1C220", Offset = "0x4A1B020", VA = "0x184A1C220")]
		public void Set(a newValue1, b newValue2, bool checkPermission = true)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public abstract class ERDNBTYMXTJ<a, b, c> : ZQLNMWUAXWD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private a DEVTHNXBBRK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private b DFLNZIETDZL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private c DFGHCBKVUOC;

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		protected virtual a LBOVBAOOMYP
		{
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0xACFCF0", Offset = "0xACEAF0", VA = "0x180ACFCF0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0xACF6D0", Offset = "0xACE4D0", VA = "0x180ACF6D0", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		protected virtual b LBUBYHILWJY
		{
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0xED04E0", Offset = "0xECF2E0", VA = "0x180ED04E0", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x2A1B270", Offset = "0x2A1A070", VA = "0x182A1B270", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		protected virtual c LBZIVOCJFVH
		{
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0xAC50D0", Offset = "0xAC3ED0", VA = "0x180AC50D0", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return (c)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0xAC58D0", Offset = "0xAC46D0", VA = "0x180AC58D0", Slot = "15")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public a QBSRULZFXED
		{
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x4A1EFF0", Offset = "0x4A1DDF0", VA = "0x184A1EFF0")]
			get
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public b QBXYRSTDGPM
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x170A170", Offset = "0x1708F70", VA = "0x18170A170")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public c QCDFOZNAQAV
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x4A245E0", Offset = "0x4A233E0", VA = "0x184A245E0")]
			get
			{
				return (c)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		protected override object NJNGLULNCQC
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x4A1EFD0", Offset = "0x4A1DDD0", VA = "0x184A1EFD0", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x4A22DD0", Offset = "0x4A21BD0", VA = "0x184A22DD0", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x4A237D0", Offset = "0x4A225D0", VA = "0x184A237D0", Slot = "9")]
		protected override bool OGNBFCPMXHK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x4A24EC0", Offset = "0x4A23CC0", VA = "0x184A24EC0")]
		protected ERDNBTYMXTJ([In] SyncData data, a a, b b, c c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x4A246F0", Offset = "0x4A234F0", VA = "0x184A246F0")]
		protected ERDNBTYMXTJ(XGOJTPBZDNO a, ZNLKIYOYHAH b, string c, a d, b e, c f, NetworkSetterPermissionMode g, bool h, Action i, IJEAQFHLEGH j)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x4A1EFF0", Offset = "0x4A1DDF0", VA = "0x184A1EFF0")]
		public a VHEULAIOOQI()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x4A230B0", Offset = "0x4A21EB0", VA = "0x184A230B0")]
		public void CZLNEYEERQQ(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x170A170", Offset = "0x1708F70", VA = "0x18170A170")]
		public b VHUPCUQGQYJ()
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x4A23560", Offset = "0x4A22360", VA = "0x184A23560")]
		public void DABHWSLWTYR(b a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x4A245E0", Offset = "0x4A233E0", VA = "0x184A245E0")]
		public c VHPIFNWJHNA()
		{
			return (c)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x4A23270", Offset = "0x4A22070", VA = "0x184A23270")]
		public void CZWAZLRZKNI(c a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x4A24250", Offset = "0x4A23050", VA = "0x184A24250")]
		public void Set(a newValue1, b newValue2, c newValue3, bool checkPermission = true)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public abstract class ESDVOBTZSYC<a, b, c, d> : ZQLNMWUAXWD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private a DEVTHNXBBRK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private b DFLNZIETDZL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private c DFGHCBKVUOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private d DFWBTVSNWWD;

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		protected virtual a LBOVBAOOMYP
		{
			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0xF87480", Offset = "0xF86280", VA = "0x180F87480", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x4A3BBC0", Offset = "0x4A3A9C0", VA = "0x184A3BBC0", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		protected virtual b LBUBYHILWJY
		{
			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x20C0FF0", Offset = "0x20BFDF0", VA = "0x1820C0FF0", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x20C0BF0", Offset = "0x20BF9F0", VA = "0x1820C0BF0", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		protected virtual c LBZIVOCJFVH
		{
			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x4A3C130", Offset = "0x4A3AF30", VA = "0x184A3C130", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return (c)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x4A3BD70", Offset = "0x4A3AB70", VA = "0x184A3BD70", Slot = "15")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		protected virtual d LAOMOSTBRTW
		{
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x1CF5490", Offset = "0x1CF4290", VA = "0x181CF5490", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return (d)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x1665B80", Offset = "0x1664980", VA = "0x181665B80", Slot = "17")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public b QBXYRSTDGPM
		{
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x4A1EEF0", Offset = "0x4A1DCF0", VA = "0x184A1EEF0")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public c QCDFOZNAQAV
		{
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x4A245B0", Offset = "0x4A233B0", VA = "0x184A245B0")]
			get
			{
				return (c)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public d QASJIEDTBZK
		{
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x20D0EB0", Offset = "0x20CFCB0", VA = "0x1820D0EB0")]
			get
			{
				return (d)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		protected override object NJNGLULNCQC
		{
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x4A1EFD0", Offset = "0x4A1DDD0", VA = "0x184A1EFD0", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x4A38360", Offset = "0x4A37160", VA = "0x184A38360", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x4A3CD80", Offset = "0x4A3BB80", VA = "0x184A3CD80", Slot = "9")]
		protected override bool OGNBFCPMXHK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x4A41940", Offset = "0x4A40740", VA = "0x184A41940")]
		protected ESDVOBTZSYC([In] SyncData data, a a, b b, c c, d d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x4A419F0", Offset = "0x4A407F0", VA = "0x184A419F0")]
		protected ESDVOBTZSYC(XGOJTPBZDNO a, ZNLKIYOYHAH b, string c, a d, b e, c f, d g, NetworkSetterPermissionMode h, bool i, Action j, IJEAQFHLEGH k)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x4A1EFF0", Offset = "0x4A1DDF0", VA = "0x184A1EFF0")]
		public a VHEULAIOOQI()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x4A3A620", Offset = "0x4A39420", VA = "0x184A3A620")]
		public void CZLNEYEERQQ(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x4A1EEF0", Offset = "0x4A1DCF0", VA = "0x184A1EEF0")]
		public b VHUPCUQGQYJ()
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x4A3BAD0", Offset = "0x4A3A8D0", VA = "0x184A3BAD0")]
		public void DABHWSLWTYR(b a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x4A245B0", Offset = "0x4A233B0", VA = "0x184A245B0")]
		public c VHPIFNWJHNA()
		{
			return (c)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x4A3B130", Offset = "0x4A39F30", VA = "0x184A3B130")]
		public void CZWAZLRZKNI(c a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x20D0EB0", Offset = "0x20CFCB0", VA = "0x1820D0EB0")]
		public d VIFCXIEBJVB()
		{
			return (d)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x4A39780", Offset = "0x4A38580", VA = "0x184A39780")]
		public void CYVSNDWMPIP(d a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x4A3FCF0", Offset = "0x4A3EAF0", VA = "0x184A3FCF0")]
		public void Set(a newValue1, b newValue2, c newValue3, d newValue4, bool checkPermission = true)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public abstract class ESJCLINXCJL<a, b, c, d, e> : ZQLNMWUAXWD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private a DEVTHNXBBRK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private b DFLNZIETDZL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private c DFGHCBKVUOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private d DFWBTVSNWWD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private e DFQUWOYQNKU;

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		protected virtual a LBOVBAOOMYP
		{
			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0xACFCF0", Offset = "0xACEAF0", VA = "0x180ACFCF0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(RVA = "0xACF6D0", Offset = "0xACE4D0", VA = "0x180ACF6D0", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		protected virtual b LBUBYHILWJY
		{
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0xE16FE0", Offset = "0xE15DE0", VA = "0x180E16FE0", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0x147F9F0", Offset = "0x147E7F0", VA = "0x18147F9F0", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		protected virtual c LBZIVOCJFVH
		{
			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0xE32F20", Offset = "0xE31D20", VA = "0x180E32F20", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return (c)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0xE33840", Offset = "0xE32640", VA = "0x180E33840", Slot = "15")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		protected virtual d LAOMOSTBRTW
		{
			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0xAD9060", Offset = "0xAD7E60", VA = "0x180AD9060", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return (d)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0xAE9300", Offset = "0xAE8100", VA = "0x180AE9300", Slot = "17")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		protected virtual e LATTLZMZBFF
		{
			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0xAD8CB0", Offset = "0xAD7AB0", VA = "0x180AD8CB0", Slot = "18")]
			[CompilerGenerated]
			get
			{
				return (e)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0x4A3BEB0", Offset = "0x4A3ACB0", VA = "0x184A3BEB0", Slot = "19")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		protected override object NJNGLULNCQC
		{
			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0x4A1EFD0", Offset = "0x4A1DDD0", VA = "0x184A1EFD0", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(RVA = "0x4A445A0", Offset = "0x4A433A0", VA = "0x184A445A0", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x4A470C0", Offset = "0x4A45EC0", VA = "0x184A470C0", Slot = "9")]
		protected override bool OGNBFCPMXHK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x4A4A820", Offset = "0x4A49620", VA = "0x184A4A820")]
		protected ESJCLINXCJL(XGOJTPBZDNO a, ZNLKIYOYHAH b, string c, a d, b e, c f, d g, e h, NetworkSetterPermissionMode i, bool j, Action k, IJEAQFHLEGH l)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x4A1EFF0", Offset = "0x4A1DDF0", VA = "0x184A1EFF0")]
		public a VHEULAIOOQI()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x4A458D0", Offset = "0x4A446D0", VA = "0x184A458D0")]
		public void CZLNEYEERQQ(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x170A170", Offset = "0x1708F70", VA = "0x18170A170")]
		public b VHUPCUQGQYJ()
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x4A46820", Offset = "0x4A45620", VA = "0x184A46820")]
		public void DABHWSLWTYR(b a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x4A245E0", Offset = "0x4A233E0", VA = "0x184A245E0")]
		public c VHPIFNWJHNA()
		{
			return (c)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x4A45BB0", Offset = "0x4A449B0", VA = "0x184A45BB0")]
		public void CZWAZLRZKNI(c a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x20D0EB0", Offset = "0x20CFCB0", VA = "0x1820D0EB0")]
		public d VIFCXIEBJVB()
		{
			return (d)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x4A45050", Offset = "0x4A43E50", VA = "0x184A45050")]
		public void CYVSNDWMPIP(d a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x4A4A440", Offset = "0x4A49240", VA = "0x184A4A440")]
		public e VHZWABKEAJS()
		{
			return (e)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x4A44B80", Offset = "0x4A43980", VA = "0x184A44B80")]
		public void CYQLPXCPFXG(e a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x4A49D90", Offset = "0x4A48B90", VA = "0x184A49D90")]
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
