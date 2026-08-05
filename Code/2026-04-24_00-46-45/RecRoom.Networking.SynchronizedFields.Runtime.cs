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
	public interface UQKLHVFTFHP : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		bool BXSYBKZOHCE
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		bool OQATZMIHLKF
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		KDSOOWCXYNX QIWPLFMOOJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		int ELAZJFOBHHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		bool QPOCVVHRKLB
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		bool UIVPDWADJAH
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		event Action LFLVCKXNUBC;

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void TJTWNSLGTER();

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void DNDMCETGQBT(object a, bool b);

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void PYVZSLMQHTB();
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface KIHLSETRYCG : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000007")]
		string PMSYNPVRYWB
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		bool EFJSJSPJIDZ
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface VYOFOFLRCOZ<a> : KIHLSETRYCG, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		a XFKDBHWRIHZ
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void LDXOSOJVVPE(a a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public sealed class VCFCPHQCOMK<a> : VYOFOFLRCOZ<a>, KIHLSETRYCG, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private readonly CAAVBGFGJFR<a> TOFTKMHFDPR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private readonly CAAVBGFGJFR<a> ZNCWPKAMXVY;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public string PMSYNPVRYWB
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xFBAA00", Offset = "0xFB9400", VA = "0x180FBAA00", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool OBVFHSTUMPD
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x7E32850", Offset = "0x7E31250", VA = "0x187E32850", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public a BXGNOPSANQE
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x7E34630", Offset = "0x7E33030", VA = "0x187E34630", Slot = "11")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x7E30B40", Offset = "0x7E2F540", VA = "0x187E30B40", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public a XFKDBHWRIHZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x7E34560", Offset = "0x7E32F60", VA = "0x187E34560", Slot = "4")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x7E300A0", Offset = "0x7E2EAA0", VA = "0x187E300A0", Slot = "13")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public a BPERYPXGUEX
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x7E34560", Offset = "0x7E32F60", VA = "0x187E34560")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x7E33080", Offset = "0x7E31A80", VA = "0x187E33080")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool EFJSJSPJIDZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x7E21EC0", Offset = "0x7E208C0", VA = "0x187E21EC0", Slot = "7")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x7E213C0", Offset = "0x7E1FDC0", VA = "0x187E213C0", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool SUTKPCFTSTR
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x7E30970", Offset = "0x7E2F370", VA = "0x187E30970")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7E33EE0", Offset = "0x7E328E0", VA = "0x187E33EE0", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7E359C0", Offset = "0x7E343C0", VA = "0x187E359C0")]
		public VCFCPHQCOMK([In] SyncData data, a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7E30490", Offset = "0x7E2EE90", VA = "0x187E30490")]
		private void DJLSKEUECOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7E320E0", Offset = "0x7E30AE0", VA = "0x187E320E0", Slot = "5")]
		public void LDXOSOJVVPE(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7E321E0", Offset = "0x7E30BE0", VA = "0x187E321E0")]
		public void LDXOSOJVVPE(a a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7E21780", Offset = "0x7E20180", VA = "0x187E21780", Slot = "8")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public sealed class VBZVSAWFFBB<a, b> : VYOFOFLRCOZ<(a, b)>, KIHLSETRYCG, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly CAGBYMZDSRA<a, b> TOFTKMHFDPR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private readonly CAGBYMZDSRA<a, b> ZNCWPKAMXVY;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public string PMSYNPVRYWB
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0xFBAA00", Offset = "0xFB9400", VA = "0x180FBAA00", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool OBVFHSTUMPD
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x7E2BE40", Offset = "0x7E2A840", VA = "0x187E2BE40", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool IVOWQZHGRWI
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x7E2E910", Offset = "0x7E2D310", VA = "0x187E2E910")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool IWERITOYUEJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x7E2EC90", Offset = "0x7E2D690", VA = "0x187E2EC90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public (a, b) BXGNOPSANQE
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x7E2DB80", Offset = "0x7E2C580", VA = "0x187E2DB80", Slot = "11")]
			get
			{
				return default((a, b));
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x7E2AF70", Offset = "0x7E29970", VA = "0x187E2AF70", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public (a, b) XFKDBHWRIHZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x7E2D700", Offset = "0x7E2C100", VA = "0x187E2D700", Slot = "4")]
			get
			{
				return default((a, b));
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x7E28940", Offset = "0x7E27340", VA = "0x187E28940", Slot = "13")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public (a, b) BPERYPXGUEX
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x7E2E4C0", Offset = "0x7E2CEC0", VA = "0x187E2E4C0")]
			get
			{
				return default((a, b));
			}
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x7E2C030", Offset = "0x7E2AA30", VA = "0x187E2C030")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public a VAEJPYUWWTV
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x7E2D290", Offset = "0x7E2BC90", VA = "0x187E2D290")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x7E2C670", Offset = "0x7E2B070", VA = "0x187E2C670")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public a RUBAQJIKAXM
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x7E28EE0", Offset = "0x7E278E0", VA = "0x187E28EE0")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x7E28FC0", Offset = "0x7E279C0", VA = "0x187E28FC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public a LXKOKSXIPHY
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x7E28EE0", Offset = "0x7E278E0", VA = "0x187E28EE0")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x7E298C0", Offset = "0x7E282C0", VA = "0x187E298C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public b VAJQNFOUGFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x7E2D240", Offset = "0x7E2BC40", VA = "0x187E2D240")]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x7E2C0B0", Offset = "0x7E2AAB0", VA = "0x187E2C0B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public b RTVTTCOMRMD
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x7E28E90", Offset = "0x7E27890", VA = "0x187E28E90")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public b LXFHNMDLFWP
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x7E28E90", Offset = "0x7E27890", VA = "0x187E28E90")]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x7E29D10", Offset = "0x7E28710", VA = "0x187E29D10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public bool EFJSJSPJIDZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x7E21EC0", Offset = "0x7E208C0", VA = "0x187E21EC0", Slot = "7")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x7E213C0", Offset = "0x7E1FDC0", VA = "0x187E213C0", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x7E2CCA0", Offset = "0x7E2B6A0", VA = "0x187E2CCA0", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7E2F870", Offset = "0x7E2E270", VA = "0x187E2F870")]
		public VBZVSAWFFBB([In] SyncData data, a a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7E29650", Offset = "0x7E28050", VA = "0x187E29650")]
		private void DJLSKEUECOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7E2E420", Offset = "0x7E2CE20", VA = "0x187E2E420")]
		public void XLHBWXQLVGT(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7E2B620", Offset = "0x7E2A020", VA = "0x187E2B620")]
		public void LDXOSOJVVPE(a a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7E2B4A0", Offset = "0x7E29EA0", VA = "0x187E2B4A0", Slot = "5")]
		private void KRDSDXDDCRT((a, b) a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x7E21780", Offset = "0x7E20180", VA = "0x187E21780", Slot = "8")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public sealed class VBUOUUCHVPS<a, b, c> : VYOFOFLRCOZ<(a, b, c)>, KIHLSETRYCG, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly CALIVTTBCCJ<a, b, c> TOFTKMHFDPR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly CALIVTTBCCJ<a, b, c> ZNCWPKAMXVY;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public string PMSYNPVRYWB
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0xFBAA00", Offset = "0xFB9400", VA = "0x180FBAA00", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public bool OBVFHSTUMPD
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x7E253C0", Offset = "0x7E23DC0", VA = "0x187E253C0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool IVOWQZHGRWI
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x7E278A0", Offset = "0x7E262A0", VA = "0x187E278A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public bool IWERITOYUEJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x7E27AB0", Offset = "0x7E264B0", VA = "0x187E27AB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public bool IVZKLMVBKTA
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x7E27DA0", Offset = "0x7E267A0", VA = "0x187E27DA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public (a, b, c) BXGNOPSANQE
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x7E27310", Offset = "0x7E25D10", VA = "0x187E27310", Slot = "11")]
			get
			{
				return default((a, b, c));
			}
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x7E244B0", Offset = "0x7E22EB0", VA = "0x187E244B0", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public (a, b, c) XFKDBHWRIHZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x7E269C0", Offset = "0x7E253C0", VA = "0x187E269C0", Slot = "4")]
			get
			{
				return default((a, b, c));
			}
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x7E233E0", Offset = "0x7E21DE0", VA = "0x187E233E0", Slot = "13")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public a VAEJPYUWWTV
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x7E26990", Offset = "0x7E25390", VA = "0x187E26990")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x7E26110", Offset = "0x7E24B10", VA = "0x187E26110")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public a RUBAQJIKAXM
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x7E235F0", Offset = "0x7E21FF0", VA = "0x187E235F0")]
			get
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public a LXKOKSXIPHY
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x7E235F0", Offset = "0x7E21FF0", VA = "0x187E235F0")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x7E23E70", Offset = "0x7E22870", VA = "0x187E23E70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public b VAJQNFOUGFE
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x7E26800", Offset = "0x7E25200", VA = "0x187E26800")]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x7E25BD0", Offset = "0x7E245D0", VA = "0x187E25BD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public b RTVTTCOMRMD
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x7E23430", Offset = "0x7E21E30", VA = "0x187E23430")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public b LXFHNMDLFWP
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x7E23430", Offset = "0x7E21E30", VA = "0x187E23430")]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x7E24170", Offset = "0x7E22B70", VA = "0x187E24170")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public c VAOXKMIRPQN
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x7E26720", Offset = "0x7E25120", VA = "0x187E26720")]
			get
			{
				return (c)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x7E25AD0", Offset = "0x7E244D0", VA = "0x187E25AD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public c RTQMVVUPIAU
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x7E235C0", Offset = "0x7E21FC0", VA = "0x187E235C0")]
			get
			{
				return (c)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public c LXAAQFJNWLG
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x7E235C0", Offset = "0x7E21FC0", VA = "0x187E235C0")]
			get
			{
				return (c)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x7E24340", Offset = "0x7E22D40", VA = "0x187E24340")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool EFJSJSPJIDZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x7E21EC0", Offset = "0x7E208C0", VA = "0x187E21EC0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7E261A0", Offset = "0x7E24BA0", VA = "0x187E261A0", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x7E27FB0", Offset = "0x7E269B0", VA = "0x187E27FB0")]
		public VBUOUUCHVPS([In] SyncData data, a a, b b, c c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x7E23D80", Offset = "0x7E22780", VA = "0x187E23D80")]
		private void DJLSKEUECOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x7E274C0", Offset = "0x7E25EC0", VA = "0x187E274C0")]
		public void XLHBWXQLVGT(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x7E25540", Offset = "0x7E23F40", VA = "0x187E25540")]
		public void PICJCXTBHDW(b a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x7E236D0", Offset = "0x7E220D0", VA = "0x187E236D0")]
		public void BSRSTSMQFVT(c a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x7E24E90", Offset = "0x7E23890", VA = "0x187E24E90")]
		public void LDXOSOJVVPE(a a, b b, c c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x7E266C0", Offset = "0x7E250C0", VA = "0x187E266C0", Slot = "5")]
		private void SNAPXSXFGBE((a, b, c) a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7E21780", Offset = "0x7E20180", VA = "0x187E21780", Slot = "8")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public sealed class VBPHXNIKMEJ<a, b, c, d> : VYOFOFLRCOZ<(a, b, c, d)>, KIHLSETRYCG, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly BZAMOYJTOAY<a, b, c, d> TOFTKMHFDPR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly BZAMOYJTOAY<a, b, c, d> ZNCWPKAMXVY;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public string PMSYNPVRYWB
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xFBAA00", Offset = "0xFB9400", VA = "0x180FBAA00", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public (a, b, c, d) XFKDBHWRIHZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x7E222C0", Offset = "0x7E20CC0", VA = "0x187E222C0", Slot = "4")]
			get
			{
				return default((a, b, c, d));
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x7E20CF0", Offset = "0x7E1F6F0", VA = "0x187E20CF0", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public b RTVTTCOMRMD
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x7E21200", Offset = "0x7E1FC00", VA = "0x187E21200")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public c RTQMVVUPIAU
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x7E21390", Offset = "0x7E1FD90", VA = "0x187E21390")]
			get
			{
				return (c)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public d RTLFYPARYPL
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x7E21120", Offset = "0x7E1FB20", VA = "0x187E21120")]
			get
			{
				return (d)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool EFJSJSPJIDZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x7E21EC0", Offset = "0x7E208C0", VA = "0x187E21EC0", Slot = "7")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x7E213C0", Offset = "0x7E1FDC0", VA = "0x187E213C0", Slot = "10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7E22E70", Offset = "0x7E21870", VA = "0x187E22E70")]
		public VBPHXNIKMEJ([In] SyncData data, a a, b b, c c, d d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7E21670", Offset = "0x7E20070", VA = "0x187E21670")]
		private void DJLSKEUECOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7E223E0", Offset = "0x7E20DE0", VA = "0x187E223E0")]
		public void XLHBWXQLVGT(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7E21E70", Offset = "0x7E20870", VA = "0x187E21E70")]
		public void LDXOSOJVVPE(a a, b b, c c, d d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x7E21B40", Offset = "0x7E20540", VA = "0x187E21B40", Slot = "5")]
		private void JZISSIEVCGM((a, b, c, d) a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x7E21780", Offset = "0x7E20180", VA = "0x187E21780", Slot = "8")]
		public void Dispose()
		{
		}
	}
}
namespace RecRoom.Networking.Policy
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class HQFCDVMKRBR
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x9B056F0", Offset = "0x9B040F0", VA = "0x189B056F0")]
		public static string TSMNPQPLLXU(this SyncData a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xD7C730", Offset = "0xD7B130", VA = "0x180D7C730")]
		public static NetworkSetterPermissionMode YRAMXQFCGPN(this SyncData a)
		{
			return default(NetworkSetterPermissionMode);
		}
	}
}
namespace RecRoom.Networking.SynchronizedFields
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class CAAVBGFGJFR<a> : VFRPVTRVRRQ<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x5059C60", Offset = "0x5058660", VA = "0x185059C60")]
		public CAAVBGFGJFR([In] SyncData data, a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x5056370", Offset = "0x5054D70", VA = "0x185056370")]
		public CAAVBGFGJFR(PENMSEVEISY a, KDSOOWCXYNX b, string c, a d, NetworkSetterPermissionMode e, [Optional] Action f, [Optional] TVESOOWUPOW g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x5058800", Offset = "0x5057200", VA = "0x185058800")]
		public CAAVBGFGJFR(PENMSEVEISY a, string b, a c, NetworkSetterPermissionMode d, [Optional] Action e, [Optional] TVESOOWUPOW f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x5057580", Offset = "0x5055F80", VA = "0x185057580")]
		public CAAVBGFGJFR(PENMSEVEISY a, string b, a c, NetworkSetterPermissionMode d, bool e, [Optional] Action f, [Optional] TVESOOWUPOW g)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class CAGBYMZDSRA<a, b> : VFMIYMXYIGH<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x505D220", Offset = "0x505BC20", VA = "0x18505D220")]
		public CAGBYMZDSRA([In] SyncData data, a a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x505AEA0", Offset = "0x50598A0", VA = "0x18505AEA0")]
		public CAGBYMZDSRA(PENMSEVEISY a, KDSOOWCXYNX b, string c, a d, b e, NetworkSetterPermissionMode f, [Optional] Action g, [Optional] TVESOOWUPOW h)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x505BD60", Offset = "0x505A760", VA = "0x18505BD60")]
		public CAGBYMZDSRA(PENMSEVEISY a, string b, a c, b d, NetworkSetterPermissionMode e, [Optional] Action f, [Optional] TVESOOWUPOW g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x505CAC0", Offset = "0x505B4C0", VA = "0x18505CAC0")]
		public CAGBYMZDSRA(PENMSEVEISY a, string b, a c, b d, NetworkSetterPermissionMode e, bool f, [Optional] Action g, [Optional] TVESOOWUPOW h)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class CALIVTTBCCJ<a, b, c> : VFHCBGEAYUY<a, b, c>
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x5060CA0", Offset = "0x505F6A0", VA = "0x185060CA0")]
		public CALIVTTBCCJ([In] SyncData data, a a, b b, c c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x50609B0", Offset = "0x505F3B0", VA = "0x1850609B0")]
		public CALIVTTBCCJ(PENMSEVEISY a, string b, a c, b d, c e, NetworkSetterPermissionMode f, [Optional] Action g, [Optional] TVESOOWUPOW h)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class BZAMOYJTOAY<a, b, c, d> : VGRYIBNIMWJ<a, b, c, d>
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x4F52350", Offset = "0x4F50D50", VA = "0x184F52350")]
		public BZAMOYJTOAY([In] SyncData data, a a, b b, c c, d d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x4F52B40", Offset = "0x4F51540", VA = "0x184F52B40")]
		public BZAMOYJTOAY(PENMSEVEISY a, KDSOOWCXYNX b, string c, a d, b e, c f, d g, NetworkSetterPermissionMode h, [Optional] Action i, [Optional] TVESOOWUPOW j)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x4F52A10", Offset = "0x4F51410", VA = "0x184F52A10")]
		public BZAMOYJTOAY(PENMSEVEISY a, string b, a c, b d, c e, d f, NetworkSetterPermissionMode g, [Optional] Action h, [Optional] TVESOOWUPOW i)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class BZFTMFDQXMH<a, b, c, d, e> : VGMRKUTLDLA<a, b, c, d, e>
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x4F54920", Offset = "0x4F53320", VA = "0x184F54920")]
		public BZFTMFDQXMH(PENMSEVEISY a, KDSOOWCXYNX b, string c, a d, b e, c f, d g, e h, NetworkSetterPermissionMode i, [Optional] Action j, [Optional] TVESOOWUPOW k)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x4F54810", Offset = "0x4F53210", VA = "0x184F54810")]
		public BZFTMFDQXMH(PENMSEVEISY a, string b, a c, b d, c e, d f, e g, NetworkSetterPermissionMode h, [Optional] Action i, [Optional] TVESOOWUPOW j)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class IIFPGALWWIM<a> : VFRPVTRVRRQ<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x65FBE50", Offset = "0x65FA850", VA = "0x1865FBE50")]
		public IIFPGALWWIM(KDSOOWCXYNX a, string b, a c, [Optional] Action d, [Optional] TVESOOWUPOW e)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class IIVJXUTOYQN<a, b> : VFMIYMXYIGH<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x65FC100", Offset = "0x65FAB00", VA = "0x1865FC100")]
		public IIVJXUTOYQN(KDSOOWCXYNX a, string b, a c, b d, [Optional] Action e, [Optional] TVESOOWUPOW f)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public interface UDTJSYRXGGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "0")]
		CAAVBGFGJFR<a> KZFWXBAIMJC<a>(string a, a b, NetworkSetterPermissionMode c, [Optional] Action d);
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class DAGUXIVCVOB : UDTJSYRXGGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly TVESOOWUPOW WUVXDLFSSKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly PENMSEVEISY LTCUZYHUHUF;

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0xD13D90", Offset = "0xD12790", VA = "0x180D13D90")]
		public DAGUXIVCVOB(TVESOOWUPOW a, PENMSEVEISY b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x390D160", Offset = "0x390BB60", VA = "0x18390D160", Slot = "4")]
		public CAAVBGFGJFR<a> KZFWXBAIMJC<a>(string a, a b, NetworkSetterPermissionMode c, [Optional] Action d)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public interface KIFQTBBYBUB : PENMSEVEISY
	{
		[Cpp2IlInjected.Token(Token = "0x17000036")]
		ViewId BZAVQXYMJBR
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public interface PENMSEVEISY
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		bool KKEKQWARIXR
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		bool HEYYGZFGLIB
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		string NIMTUHLJNWT
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		bool NMKQSUITEME
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void RegisterDestroyHandler(PPFVVNKSZNQ handler);

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void UnregisterDestroyHandler(PPFVVNKSZNQ handler);
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public static class WNGEPKMOZJY
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x9B09A80", Offset = "0x9B08480", VA = "0x189B09A80")]
		public static bool ZEHRJFPCBER(this PENMSEVEISY a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface TVESOOWUPOW : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		KDSOOWCXYNX HBPTAMMHPSI
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		bool SUTKPCFTSTR
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		bool YBYLUNUVGBU
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
		object JOOBRCHMHTM(string a);

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "5")]
		object SEBDTBQQMGE(KDSOOWCXYNX a, string b);

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void TTWTUYCEKJQ(string a, object b);

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void YQSZOTYTJCE(KDSOOWCXYNX a, string b, object c);

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void UVZXQAJDMPL<a>(string a, a b);

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void MDUKYAGXMSP([CanBeNull] KDSOOWCXYNX photonPlayer, string a, MRFHEYATTPK b);

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void CSSUQLTPBRM([CanBeNull] KDSOOWCXYNX photonPlayer, string a, MRFHEYATTPK b);

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "11")]
		b ELNJYSPZCWW<b>(object a);

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(Slot = "12")]
		object PIWYHVEGCPB<c>(c a);

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "13")]
		object ELNJYSPZCWW(object a, Type b);

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "14")]
		object PIWYHVEGCPB(object a, Type b);

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void QBATSCRTLSW();

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "16")]
		void EQBKIEDIFXC();

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "17")]
		void ROHKTCPDRFF(string a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public struct SyncData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public KDSOOWCXYNX player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public PENMSEVEISY context;

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
		public TVESOOWUPOW networkBacking;

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x9B07200", Offset = "0x9B05C00", VA = "0x189B07200")]
		public SyncData(SyncData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x9B07060", Offset = "0x9B05A60", VA = "0x189B07060")]
		public SyncData(PENMSEVEISY context, string key, NetworkSetterPermissionMode permissionMode, [Optional] Action callback, [Optional] TVESOOWUPOW networkBacking)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x9B07010", Offset = "0x9B05A10", VA = "0x189B07010")]
		public static SyncData From(PENMSEVEISY context, string key, NetworkSetterPermissionMode permissionMode, [Optional] Action callback, [Optional] TVESOOWUPOW networkBacking)
		{
			return default(SyncData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public static class NAFRJINOCIL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x3D54120", Offset = "0x3D52B20", VA = "0x183D54120")]
		public static CAAVBGFGJFR<a> MRFHEYATTPK<a>(this SyncData a, a b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x3D53710", Offset = "0x3D52110", VA = "0x183D53710")]
		public static CAGBYMZDSRA<b, c> MRFHEYATTPK<b, c>(this SyncData a, b b, c c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x3D537B0", Offset = "0x3D521B0", VA = "0x183D537B0")]
		public static CALIVTTBCCJ<d, e, f> MRFHEYATTPK<d, e, f>(this SyncData a, d b, e c, f d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x3D53BD0", Offset = "0x3D525D0", VA = "0x183D53BD0")]
		public static BZAMOYJTOAY<g, h, i, j> MRFHEYATTPK<g, h, i, j>(this SyncData a, g b, h c, i d, j e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x3D52760", Offset = "0x3D51160", VA = "0x183D52760")]
		public static VCFCPHQCOMK<k> HLJJIZCZBQZ<k>(this SyncData a, k b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x3D52610", Offset = "0x3D51010", VA = "0x183D52610")]
		public static VBZVSAWFFBB<l, m> HLJJIZCZBQZ<l, m>(this SyncData a, l b, m c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x3D526B0", Offset = "0x3D510B0", VA = "0x183D526B0")]
		public static VBUOUUCHVPS<n, o, p> HLJJIZCZBQZ<n, o, p>(this SyncData a, n b, o c, p d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x3D53120", Offset = "0x3D51B20", VA = "0x183D53120")]
		public static VBPHXNIKMEJ<q, r, s, t> HLJJIZCZBQZ<q, r, s, t>(this SyncData a, q b, r c, s d, t e)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public abstract class MRFHEYATTPK : PPFVVNKSZNQ, IDisposable
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
		private static Stack<TVESOOWUPOW> BEDDXCPFQWS;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static bool UOCGKPCQOKR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		protected readonly KDSOOWCXYNX HEJFHZRELCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		protected readonly PENMSEVEISY LTCUZYHUHUF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		protected readonly string ZOYFTTVDVER;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		protected readonly NetworkSetterPermissionMode OLZLOPQUNSW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		protected readonly Action QPTYZMPRDZD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		protected TVESOOWUPOW HIWYNXGVWPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private Flags BSLJFOZKPBT;

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public static TVESOOWUPOW QXKSGXOADBU
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x9B05910", Offset = "0x9B04310", VA = "0x189B05910")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		private bool PDUJQNSZPPI
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x9B06CE0", Offset = "0x9B056E0", VA = "0x189B06CE0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x9B05C30", Offset = "0x9B04630", VA = "0x189B05C30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		private bool HLWDTNVRNCV
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x9B06750", Offset = "0x9B05150", VA = "0x189B06750")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x9B06950", Offset = "0x9B05350", VA = "0x189B06950")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		private bool QRFQCEHSSIA
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x9B067D0", Offset = "0x9B051D0", VA = "0x189B067D0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x9B05EF0", Offset = "0x9B048F0", VA = "0x189B05EF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public bool EFJSJSPJIDZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x9B06600", Offset = "0x9B05000", VA = "0x189B06600")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x9B05740", Offset = "0x9B04140", VA = "0x189B05740")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		protected virtual object HRFHZUDJLOZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0xD159A0", Offset = "0xD143A0", VA = "0x180D159A0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0xD159C0", Offset = "0xD143C0", VA = "0x180D159C0", Slot = "8")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public bool BHOCSRHZQOA
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x9B06760", Offset = "0x9B05160", VA = "0x189B06760")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public int SGVEKLPJYEH
		{
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0xEE94F0", Offset = "0xEE7EF0", VA = "0x180EE94F0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x1AD9140", Offset = "0x1AD7B40", VA = "0x181AD9140")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public string PMSYNPVRYWB
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0xD11BE0", Offset = "0xD105E0", VA = "0x180D11BE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public bool SUTKPCFTSTR
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x9B05C50", Offset = "0x9B04650", VA = "0x189B05C50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x9B05800", Offset = "0x9B04200", VA = "0x189B05800")]
		public static void BWNMTIIREPZ(TVESOOWUPOW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(Slot = "9")]
		protected abstract bool GHMQXGJIVUR();

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x9B06DF0", Offset = "0x9B057F0", VA = "0x189B06DF0")]
		protected MRFHEYATTPK(KDSOOWCXYNX a, PENMSEVEISY b, string c, NetworkSetterPermissionMode d, Action e, TVESOOWUPOW f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x9B05BD0", Offset = "0x9B045D0", VA = "0x189B05BD0", Slot = "1")]
		~MRFHEYATTPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x9B05980", Offset = "0x9B04380", VA = "0x189B05980", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x9B06BC0", Offset = "0x9B055C0", VA = "0x189B06BC0")]
		private void TWXWDAXUFMT(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x9B067E0", Offset = "0x9B051E0", VA = "0x189B067E0")]
		private object QICFKHQWEFH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x9B05F10", Offset = "0x9B04910", VA = "0x189B05F10")]
		protected void Initialize(bool enforceInitialValue, object initialValue, bool initialValueIsDefaultValue = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x9B06A20", Offset = "0x9B05420", VA = "0x189B06A20")]
		protected void Set(object newValue, bool checkPermission = true, bool suppressCallback = false, bool requireModified = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x9B05CA0", Offset = "0x9B046A0", VA = "0x189B05CA0")]
		protected void HPRIJUDDQJU(object a, bool b, bool c, bool d = false, bool e = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x9B06C60", Offset = "0x9B05660", VA = "0x189B06C60")]
		internal void UPOEXJDPLHW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x9B06CF0", Offset = "0x9B056F0", VA = "0x189B06CF0")]
		private void XPEUSRSNYIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x9B060E0", Offset = "0x9B04AE0", VA = "0x189B060E0")]
		private void JPTJDSBTIQF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x9B058A0", Offset = "0x9B042A0", VA = "0x189B058A0", Slot = "4")]
		private void CDLWZSPMSFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x9B065F0", Offset = "0x9B04FF0", VA = "0x189B065F0", Slot = "5")]
		private void LPXORQDNCOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x9B06610", Offset = "0x9B05010", VA = "0x189B06610")]
		public bool NMNDGWXXMQK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x9B063A0", Offset = "0x9B04DA0", VA = "0x189B063A0")]
		public bool KSFFCCJHISU()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x9B06250", Offset = "0x9B04C50", VA = "0x189B06250")]
		private bool KOHQLGFWXIX()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x9B06970", Offset = "0x9B05370", VA = "0x189B06970")]
		internal void SFXOJYBXBPS(object a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x9B06140", Offset = "0x9B04B40", VA = "0x189B06140")]
		private void JTSYKNFOGTS(object a, bool b, bool c = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x9B05730", Offset = "0x9B04130", VA = "0x189B05730")]
		private bool AKTGCBDYUVC(Flags a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x9B067B0", Offset = "0x9B051B0", VA = "0x189B067B0")]
		private void NTWPENYTITS(Flags a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x9B06560", Offset = "0x9B04F60", VA = "0x189B06560")]
		public static string LIWEXJTDCWG(KDSOOWCXYNX a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x9B05AF0", Offset = "0x9B044F0", VA = "0x189B05AF0")]
		public static string FMJDGKXBGSO(PENMSEVEISY a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x9B06A60", Offset = "0x9B05460", VA = "0x189B06A60")]
		public static bool TRTXMAHVSKY(object a, object b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public abstract class TXFWKRVPCKW : TVESOOWUPOW, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly Dictionary<object, object> GIIEAKIRIYT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly List<string> SEBPDYNRJFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly Dictionary<object, object> OYORTAZRCBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly List<string> DMEPAEFXIGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private bool WQKINWPMPUV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		protected readonly Dictionary<string, object> ZCTKJHBKRXZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		protected readonly Dictionary<KDSOOWCXYNX, Dictionary<string, object>> KOBDLUWECMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly HashSet<string> IQRVLGAGEKI;

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public abstract Dictionary<object, object> XSZGDAVALDS
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(Slot = "23")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public abstract int LRNJJHIVHGF
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(Slot = "24")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public abstract KDSOOWCXYNX HBPTAMMHPSI
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(Slot = "25")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public abstract bool SUTKPCFTSTR
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(Slot = "26")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public abstract bool YBYLUNUVGBU
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(Slot = "27")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public virtual bool PAYKJQSOVIV
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0xD2BB70", Offset = "0xD2A570", VA = "0x180D2BB70", Slot = "28")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public bool DFPZNIZKTBH
		{
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0xD6FAC0", Offset = "0xD6E4C0", VA = "0x180D6FAC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x3F72410", Offset = "0x3F70E10", VA = "0x183F72410", Slot = "12")]
		public void UVZXQAJDMPL<a>(string a, a b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x9B09620", Offset = "0x9B08020", VA = "0x189B09620", Slot = "11")]
		public void YQSZOTYTJCE(KDSOOWCXYNX a, string b, object c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x9B08DA0", Offset = "0x9B077A0", VA = "0x189B08DA0", Slot = "9")]
		public object SEBDTBQQMGE(KDSOOWCXYNX a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x9B08EA0", Offset = "0x9B078A0", VA = "0x189B08EA0", Slot = "10")]
		public void TTWTUYCEKJQ(string a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x9B07E90", Offset = "0x9B06890", VA = "0x189B07E90", Slot = "8")]
		public object JOOBRCHMHTM(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x9B080C0", Offset = "0x9B06AC0", VA = "0x189B080C0", Slot = "13")]
		public void MDUKYAGXMSP(KDSOOWCXYNX a, string b, MRFHEYATTPK c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x9B07280", Offset = "0x9B05C80", VA = "0x189B07280", Slot = "14")]
		public void CSSUQLTPBRM(KDSOOWCXYNX a, string b, MRFHEYATTPK c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x9B07F30", Offset = "0x9B06930", VA = "0x189B07F30")]
		private void KGASAXDLNPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x9B07FE0", Offset = "0x9B069E0", VA = "0x189B07FE0")]
		private void KXKXCFVIPZK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x9B07F80", Offset = "0x9B06980", VA = "0x189B07F80")]
		private void KKRXNFIRNYP(KDSOOWCXYNX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x9B09770", Offset = "0x9B08170", VA = "0x189B09770")]
		protected void ZRLNBOKDLPF(KDSOOWCXYNX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x9B09460", Offset = "0x9B07E60", VA = "0x189B09460")]
		protected void WKEGSBFHUXT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x9B08FC0", Offset = "0x9B079C0", VA = "0x189B08FC0")]
		protected void UQKCFXNGLMB(IDictionary<object, object> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x9B086C0", Offset = "0x9B070C0", VA = "0x189B086C0")]
		protected void QPEPOIATLSL(KDSOOWCXYNX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x9B07980", Offset = "0x9B06380", VA = "0x189B07980")]
		protected void EYCOZOSZLXV(KDSOOWCXYNX a, IDictionary<object, object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x9B07A10", Offset = "0x9B06410", VA = "0x189B07A10")]
		private void INNRBZEKCFY(IDictionary<object, object> a, Dictionary<string, object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x9B08FD0", Offset = "0x9B079D0", VA = "0x189B08FD0")]
		private static void USMRFNCMXPA(object a, object b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x9B08900", Offset = "0x9B07300", VA = "0x189B08900")]
		private static void QWUMJFIZHHT(Dictionary<string, object> a, string b, MRFHEYATTPK c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x9B08730", Offset = "0x9B07130", VA = "0x189B08730")]
		private static void QQPWHEDGYJW(Dictionary<string, object> a, string b, MRFHEYATTPK c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x9B085C0", Offset = "0x9B06FC0", VA = "0x189B085C0", Slot = "19")]
		public void QBATSCRTLSW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(Slot = "29")]
		protected abstract void FDXVNMUYTYX(Dictionary<object, object> a);

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x9B078A0", Offset = "0x9B062A0", VA = "0x189B078A0", Slot = "20")]
		public void EQBKIEDIFXC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "30")]
		protected abstract void WVQGSYGCEAF(Dictionary<object, object> a);

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x9B07520", Offset = "0x9B05F20", VA = "0x189B07520")]
		private void DMXICJXNXKQ(Dictionary<object, object> a, List<string> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x9B091D0", Offset = "0x9B07BD0", VA = "0x189B091D0")]
		private void VLJAYLRTEFH(IDictionary<object, object> a, [Out] int b, [Out] string[] c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x9B08530", Offset = "0x9B06F30", VA = "0x189B08530")]
		public void OKSYFTXRKXQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x9B09550", Offset = "0x9B07F50", VA = "0x189B09550")]
		public void WMUTYKFUNKW(KDSOOWCXYNX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x9B081D0", Offset = "0x9B06BD0", VA = "0x189B081D0")]
		public void MWWAJRCGXCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "31")]
		protected abstract HashSet<int> XBDHSDQKRWX(bool a, bool b);

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x9B08B20", Offset = "0x9B07520", VA = "0x189B08B20", Slot = "21")]
		public void ROHKTCPDRFF(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x9B08030", Offset = "0x9B06A30", VA = "0x189B08030")]
		protected string LIWEXJTDCWG(KDSOOWCXYNX a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "32")]
		public abstract object PIWYHVEGCPB<b>(b a);

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "33")]
		public abstract c ELNJYSPZCWW<c>(object a);

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(Slot = "34")]
		public abstract object PIWYHVEGCPB(object a, Type b);

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(Slot = "35")]
		public abstract object ELNJYSPZCWW(object a, Type b);

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "36")]
		public virtual void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x9B07740", Offset = "0x9B06140", VA = "0x189B07740", Slot = "22")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "37")]
		protected virtual void FZZVURSNXUC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x9B09890", Offset = "0x9B08290", VA = "0x189B09890")]
		protected TXFWKRVPCKW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public abstract class VFRPVTRVRRQ<a> : MRFHEYATTPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private a SAUINGFOHYH;

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		protected virtual a ZCHOLKCGAEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x7E61F20", Offset = "0x7E60920", VA = "0x187E61F20", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x7E67B10", Offset = "0x7E66510", VA = "0x187E67B10", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		protected override object HRFHZUDJLOZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x7E502D0", Offset = "0x7E4ECD0", VA = "0x187E502D0", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x7E66F30", Offset = "0x7E65930", VA = "0x187E66F30", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x7E61D20", Offset = "0x7E60720", VA = "0x187E61D20", Slot = "9")]
		protected override bool GHMQXGJIVUR()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x7E68F50", Offset = "0x7E67950", VA = "0x187E68F50")]
		protected VFRPVTRVRRQ([In] SyncData data, a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x7E69BC0", Offset = "0x7E685C0", VA = "0x187E69BC0")]
		protected VFRPVTRVRRQ(KDSOOWCXYNX a, PENMSEVEISY b, string c, a d, NetworkSetterPermissionMode e, bool f, Action g, TVESOOWUPOW h)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x538B280", Offset = "0x5389C80", VA = "0x18538B280")]
		public a Get()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x7E639A0", Offset = "0x7E623A0", VA = "0x187E639A0")]
		public void Set(a newValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x7E66780", Offset = "0x7E65180", VA = "0x187E66780")]
		public void Set(a newValue, bool checkPermission, bool suppressCallback = false, bool requireModified = true)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public abstract class VFMIYMXYIGH<a, b> : MRFHEYATTPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private a SAUINGFOHYH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private b SAZPKMZLRJQ;

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		protected virtual a ZCHOLKCGAEA
		{
			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x11037B0", Offset = "0x11021B0", VA = "0x1811037B0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x12EE480", Offset = "0x12ECE80", VA = "0x1812EE480", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		protected virtual b ZCXJDEJYCMB
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x32B9600", Offset = "0x32B8000", VA = "0x1832B9600", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x7E581B0", Offset = "0x7E56BB0", VA = "0x187E581B0", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public b ZMXFBPPSPJL
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x174C270", Offset = "0x174AC70", VA = "0x18174C270")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		protected override object HRFHZUDJLOZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x7E502D0", Offset = "0x7E4ECD0", VA = "0x187E502D0", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x7E57D30", Offset = "0x7E56730", VA = "0x187E57D30", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x7E542B0", Offset = "0x7E52CB0", VA = "0x187E542B0", Slot = "9")]
		protected override bool GHMQXGJIVUR()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x7E58790", Offset = "0x7E57190", VA = "0x187E58790")]
		protected VFMIYMXYIGH([In] SyncData data, a a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x7E588D0", Offset = "0x7E572D0", VA = "0x187E588D0")]
		protected VFMIYMXYIGH(KDSOOWCXYNX a, PENMSEVEISY b, string c, a d, b e, NetworkSetterPermissionMode f, bool g, Action h, TVESOOWUPOW i)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x538B280", Offset = "0x5389C80", VA = "0x18538B280")]
		public a OMXQBKWDLQN()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x7E53C50", Offset = "0x7E52650", VA = "0x187E53C50")]
		public void CZOMFFUYTON(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x174C270", Offset = "0x174AC70", VA = "0x18174C270")]
		public b OMHVJQOLJIM()
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x7E53210", Offset = "0x7E51C10", VA = "0x187E53210")]
		public void CYYRNLNGRGM(b a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x7E557C0", Offset = "0x7E541C0", VA = "0x187E557C0")]
		public void Set(a newValue1, b newValue2, bool checkPermission = true, bool suppressCallback = false, bool requireModified = true)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public abstract class VFHCBGEAYUY<a, b, c> : MRFHEYATTPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private a SAUINGFOHYH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private b SAZPKMZLRJQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private c SBEWHTTJAUZ;

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		protected virtual a ZCHOLKCGAEA
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0xD22D10", Offset = "0xD21710", VA = "0x180D22D10", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0xD22CE0", Offset = "0xD216E0", VA = "0x180D22CE0", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		protected virtual b ZCXJDEJYCMB
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0xEF3330", Offset = "0xEF1D30", VA = "0x180EF3330", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x2AE64B0", Offset = "0x2AE4EB0", VA = "0x182AE64B0", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		protected virtual c ZCSCFXQATAS
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0xD14190", Offset = "0xD12B90", VA = "0x180D14190", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return (c)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0xD141F0", Offset = "0xD12BF0", VA = "0x180D141F0", Slot = "15")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public a ZMHKJVIANBK
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x538B280", Offset = "0x5389C80", VA = "0x18538B280")]
			get
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public b ZMXFBPPSPJL
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x174C270", Offset = "0x174AC70", VA = "0x18174C270")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public c ZMRYEIVVFYC
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x75AF7E0", Offset = "0x75AE1E0", VA = "0x1875AF7E0")]
			get
			{
				return (c)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		protected override object HRFHZUDJLOZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x7E502D0", Offset = "0x7E4ECD0", VA = "0x187E502D0", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x7E4F400", Offset = "0x7E4DE00", VA = "0x187E4F400", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x7E4B150", Offset = "0x7E49B50", VA = "0x187E4B150", Slot = "9")]
		protected override bool GHMQXGJIVUR()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x7E52A30", Offset = "0x7E51430", VA = "0x187E52A30")]
		protected VFHCBGEAYUY([In] SyncData data, a a, b b, c c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x7E50BB0", Offset = "0x7E4F5B0", VA = "0x187E50BB0")]
		protected VFHCBGEAYUY(KDSOOWCXYNX a, PENMSEVEISY b, string c, a d, b e, c f, NetworkSetterPermissionMode g, bool h, Action i, TVESOOWUPOW j)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x538B280", Offset = "0x5389C80", VA = "0x18538B280")]
		public a OMXQBKWDLQN()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x7E49170", Offset = "0x7E47B70", VA = "0x187E49170")]
		public void CZOMFFUYTON(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x174C270", Offset = "0x174AC70", VA = "0x18174C270")]
		public b OMHVJQOLJIM()
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x7E48760", Offset = "0x7E47160", VA = "0x187E48760")]
		public void CYYRNLNGRGM(b a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x75AF7E0", Offset = "0x75AE1E0", VA = "0x1875AF7E0")]
		public c OMNCGXIISTV()
		{
			return (c)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x7E48D90", Offset = "0x7E47790", VA = "0x187E48D90")]
		public void CZDYKSHEARV(c a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x7E4E250", Offset = "0x7E4CC50", VA = "0x187E4E250")]
		public void Set(a newValue1, b newValue2, c newValue3, bool checkPermission = true)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public abstract class VGRYIBNIMWJ<a, b, c, d> : MRFHEYATTPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private a SAUINGFOHYH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private b SAZPKMZLRJQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private c SBEWHTTJAUZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private d SBKDFANGKGI;

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		protected virtual a ZCHOLKCGAEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0xF7B730", Offset = "0xF7A130", VA = "0x180F7B730", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x7E72F30", Offset = "0x7E71930", VA = "0x187E72F30", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		protected virtual b ZCXJDEJYCMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x14B21F0", Offset = "0x14B0BF0", VA = "0x1814B21F0", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x14AD170", Offset = "0x14ABB70", VA = "0x1814AD170", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		protected virtual c ZCSCFXQATAS
		{
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x154D230", Offset = "0x154BC30", VA = "0x18154D230", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return (c)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x7E7E7A0", Offset = "0x7E7D1A0", VA = "0x187E7E7A0", Slot = "15")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		protected virtual d ZDHWXRXSVIT
		{
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x1D76B30", Offset = "0x1D75530", VA = "0x181D76B30", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return (d)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x169E430", Offset = "0x169CE30", VA = "0x18169E430", Slot = "17")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public b ZMXFBPPSPJL
		{
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x7E49C70", Offset = "0x7E48670", VA = "0x187E49C70")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public c ZMRYEIVVFYC
		{
			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0x7E49D90", Offset = "0x7E48790", VA = "0x187E49D90")]
			get
			{
				return (c)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public d ZNHSWDDNIGD
		{
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x15F45B0", Offset = "0x15F2FB0", VA = "0x1815F45B0")]
			get
			{
				return (d)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		protected override object HRFHZUDJLOZ
		{
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0x7E502D0", Offset = "0x7E4ECD0", VA = "0x187E502D0", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0x7E7E2E0", Offset = "0x7E7CCE0", VA = "0x187E7E2E0", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x7E79400", Offset = "0x7E77E00", VA = "0x187E79400", Slot = "9")]
		protected override bool GHMQXGJIVUR()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x7E80D80", Offset = "0x7E7F780", VA = "0x187E80D80")]
		protected VGRYIBNIMWJ([In] SyncData data, a a, b b, c c, d d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x7E80090", Offset = "0x7E7EA90", VA = "0x187E80090")]
		protected VGRYIBNIMWJ(KDSOOWCXYNX a, PENMSEVEISY b, string c, a d, b e, c f, d g, NetworkSetterPermissionMode h, bool i, Action j, TVESOOWUPOW k)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x538B280", Offset = "0x5389C80", VA = "0x18538B280")]
		public a OMXQBKWDLQN()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x7E77970", Offset = "0x7E76370", VA = "0x187E77970")]
		public void CZOMFFUYTON(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x7E49C70", Offset = "0x7E48670", VA = "0x187E49C70")]
		public b OMHVJQOLJIM()
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x7E767F0", Offset = "0x7E751F0", VA = "0x187E767F0")]
		public void CYYRNLNGRGM(b a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x7E49D90", Offset = "0x7E48790", VA = "0x187E49D90")]
		public c OMNCGXIISTV()
		{
			return (c)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x7E77640", Offset = "0x7E76040", VA = "0x187E77640")]
		public void CZDYKSHEARV(c a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x15F45B0", Offset = "0x15F2FB0", VA = "0x1815F45B0")]
		public d ONNKTFDVNYO()
		{
			return (d)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x7E76070", Offset = "0x7E74A70", VA = "0x187E76070")]
		public void CYODSXZLYJU(d a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x7E7B1C0", Offset = "0x7E79BC0", VA = "0x187E7B1C0")]
		public void Set(a newValue1, b newValue2, c newValue3, d newValue4, bool checkPermission = true)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public abstract class VGMRKUTLDLA<a, b, c, d, e> : MRFHEYATTPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private a SAUINGFOHYH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private b SAZPKMZLRJQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private c SBEWHTTJAUZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private d SBKDFANGKGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private e SBPKCHHDTRR;

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		protected virtual a ZCHOLKCGAEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0xD22D10", Offset = "0xD21710", VA = "0x180D22D10", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0xD22CE0", Offset = "0xD216E0", VA = "0x180D22CE0", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		protected virtual b ZCXJDEJYCMB
		{
			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0xE21210", Offset = "0xE1FC10", VA = "0x180E21210", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0x14C8410", Offset = "0x14C6E10", VA = "0x1814C8410", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		protected virtual c ZCSCFXQATAS
		{
			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0xE27890", Offset = "0xE26290", VA = "0x180E27890", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return (c)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0xE28040", Offset = "0xE26A40", VA = "0x180E28040", Slot = "15")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		protected virtual d ZDHWXRXSVIT
		{
			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(RVA = "0xD2BF40", Offset = "0xD2A940", VA = "0x180D2BF40", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return (d)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0xD3CC50", Offset = "0xD3B650", VA = "0x180D3CC50", Slot = "17")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		protected virtual e ZDCQALDVLXK
		{
			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0xD2BB80", Offset = "0xD2A580", VA = "0x180D2BB80", Slot = "18")]
			[CompilerGenerated]
			get
			{
				return (e)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x7E72D60", Offset = "0x7E71760", VA = "0x187E72D60", Slot = "19")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		protected override object HRFHZUDJLOZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x7E502D0", Offset = "0x7E4ECD0", VA = "0x187E502D0", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x7E72350", Offset = "0x7E70D50", VA = "0x187E72350", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x7E6E810", Offset = "0x7E6D210", VA = "0x187E6E810", Slot = "9")]
		protected override bool GHMQXGJIVUR()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x7E740A0", Offset = "0x7E72AA0", VA = "0x187E740A0")]
		protected VGMRKUTLDLA(KDSOOWCXYNX a, PENMSEVEISY b, string c, a d, b e, c f, d g, e h, NetworkSetterPermissionMode i, bool j, Action k, TVESOOWUPOW l)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x538B280", Offset = "0x5389C80", VA = "0x18538B280")]
		public a OMXQBKWDLQN()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x7E6D680", Offset = "0x7E6C080", VA = "0x187E6D680")]
		public void CZOMFFUYTON(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x174C270", Offset = "0x174AC70", VA = "0x18174C270")]
		public b OMHVJQOLJIM()
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x7E6C650", Offset = "0x7E6B050", VA = "0x187E6C650")]
		public void CYYRNLNGRGM(b a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x75AF7E0", Offset = "0x75AE1E0", VA = "0x1875AF7E0")]
		public c OMNCGXIISTV()
		{
			return (c)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x7E6CA10", Offset = "0x7E6B410", VA = "0x187E6CA10")]
		public void CZDYKSHEARV(c a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x15F45B0", Offset = "0x15F2FB0", VA = "0x1815F45B0")]
		public d ONNKTFDVNYO()
		{
			return (d)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x7E6B820", Offset = "0x7E6A220", VA = "0x187E6B820")]
		public void CYODSXZLYJU(d a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x7E6EE50", Offset = "0x7E6D850", VA = "0x187E6EE50")]
		public e ONSRQLXSXJX()
		{
			return (e)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x7E6BBE0", Offset = "0x7E6A5E0", VA = "0x187E6BBE0")]
		public void CYTKQETJHVD(e a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x7E6FD30", Offset = "0x7E6E730", VA = "0x187E6FD30")]
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
