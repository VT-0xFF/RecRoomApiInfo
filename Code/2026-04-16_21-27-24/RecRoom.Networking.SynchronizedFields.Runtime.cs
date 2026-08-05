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
	public interface RRZUOTSKUYS : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		bool OKFLGCITNVJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		bool MEWCPGROCVW
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		GUPOFWBVNMS MIIHWOEUDCB
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		int VJRLEKBIQSQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		bool SERIIHRNHJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		bool MGMABVTGSEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		event Action RQOMSFKKQHD;

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void DKWTOGJQHRO();

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void GGGJHMYZUJA(object a, bool b);

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void BNGLFIZRLHW();
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface RIHVMHHTLCX : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000007")]
		string XVKQGRWDPTO
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		bool IPCJQPKHCXU
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface VCULCQRDTTS<a> : RIHVMHHTLCX, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		a GXDNQKLGWZS
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void XSKSCIBWCMZ(a a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public sealed class KYIZFIBDUYR<a> : VCULCQRDTTS<a>, RIHVMHHTLCX, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private readonly ELQQKJFLRGW<a> ATQDIZQEZJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private readonly ELQQKJFLRGW<a> VCRDMBDOHAD;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public string XVKQGRWDPTO
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xF7FC80", Offset = "0xF7EA80", VA = "0x180F7FC80", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool DYDPMZUXIXY
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x67A44C0", Offset = "0x67A32C0", VA = "0x1867A44C0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public a RGWETDIXIUV
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x67A3A00", Offset = "0x67A2800", VA = "0x1867A3A00", Slot = "11")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x67A5CC0", Offset = "0x67A4AC0", VA = "0x1867A5CC0", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public a GXDNQKLGWZS
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x67A3BE0", Offset = "0x67A29E0", VA = "0x1867A3BE0", Slot = "4")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x67A4D40", Offset = "0x67A3B40", VA = "0x1867A4D40", Slot = "13")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public a PGGBLURLEPI
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x67A3BE0", Offset = "0x67A29E0", VA = "0x1867A3BE0")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x67A6240", Offset = "0x67A5040", VA = "0x1867A6240")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool IPCJQPKHCXU
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x679D620", Offset = "0x679C420", VA = "0x18679D620", Slot = "7")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x679BD90", Offset = "0x679AB90", VA = "0x18679BD90", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool OKAKVETJBLG
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x67A4DF0", Offset = "0x67A3BF0", VA = "0x1867A4DF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x67A70B0", Offset = "0x67A5EB0", VA = "0x1867A70B0", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x67A8BF0", Offset = "0x67A79F0", VA = "0x1867A8BF0")]
		public KYIZFIBDUYR([In] SyncData data, a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x67A3DF0", Offset = "0x67A2BF0", VA = "0x1867A3DF0")]
		private void HFPUNXLANYG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x67A7630", Offset = "0x67A6430", VA = "0x1867A7630", Slot = "5")]
		public void XSKSCIBWCMZ(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x67A7A10", Offset = "0x67A6810", VA = "0x1867A7A10")]
		public void XSKSCIBWCMZ(a a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6798D70", Offset = "0x6797B70", VA = "0x186798D70", Slot = "8")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public sealed class KXTENNTLSQQ<a, b> : VCULCQRDTTS<(a, b)>, RIHVMHHTLCX, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly ELLJNCLOHVN<a, b> ATQDIZQEZJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private readonly ELLJNCLOHVN<a, b> VCRDMBDOHAD;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public string XVKQGRWDPTO
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0xF7FC80", Offset = "0xF7EA80", VA = "0x180F7FC80", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool DYDPMZUXIXY
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x67997E0", Offset = "0x67985E0", VA = "0x1867997E0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool CSGBEEJSMXP
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x679B9F0", Offset = "0x679A7F0", VA = "0x18679B9F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool CRQGMKCAKPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x679B530", Offset = "0x679A330", VA = "0x18679B530")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public (a, b) RGWETDIXIUV
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x67981A0", Offset = "0x6796FA0", VA = "0x1867981A0", Slot = "11")]
			get
			{
				return default((a, b));
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x679ADC0", Offset = "0x6799BC0", VA = "0x18679ADC0", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public (a, b) GXDNQKLGWZS
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x6798970", Offset = "0x6797770", VA = "0x186798970", Slot = "4")]
			get
			{
				return default((a, b));
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x6799FD0", Offset = "0x6798DD0", VA = "0x186799FD0", Slot = "13")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public (a, b) PGGBLURLEPI
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x679A1A0", Offset = "0x6798FA0", VA = "0x18679A1A0")]
			get
			{
				return default((a, b));
			}
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x679B0D0", Offset = "0x6799ED0", VA = "0x18679B0D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public a OHSLLYIJRJW
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x6798ED0", Offset = "0x6797CD0", VA = "0x186798ED0")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x679C8F0", Offset = "0x679B6F0", VA = "0x18679C8F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public a MHOAZBXTNRJ
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x67985A0", Offset = "0x67973A0", VA = "0x1867985A0")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x679BBF0", Offset = "0x679A9F0", VA = "0x18679BBF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public a BRBVLPJSAAV
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x67985A0", Offset = "0x67973A0", VA = "0x1867985A0")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x67977E0", Offset = "0x67965E0", VA = "0x1867977E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public b OIIGDSQBTRX
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x6798E90", Offset = "0x6797C90", VA = "0x186798E90")]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x679C600", Offset = "0x679B400", VA = "0x18679C600")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public b MHTHWIRQXCS
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x6798760", Offset = "0x6797560", VA = "0x186798760")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public b BQMATVBZXSU
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x6798760", Offset = "0x6797560", VA = "0x186798760")]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x6797C00", Offset = "0x6796A00", VA = "0x186797C00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public bool IPCJQPKHCXU
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x679D620", Offset = "0x679C420", VA = "0x18679D620", Slot = "7")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x679BD90", Offset = "0x679AB90", VA = "0x18679BD90", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x679BF70", Offset = "0x679AD70", VA = "0x18679BF70", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x679DFB0", Offset = "0x679CDB0", VA = "0x18679DFB0")]
		public KXTENNTLSQQ([In] SyncData data, a a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6799480", Offset = "0x6798280", VA = "0x186799480")]
		private void HFPUNXLANYG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x679CE50", Offset = "0x679BC50", VA = "0x18679CE50")]
		public void VAGJAGZKTUG(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x679D680", Offset = "0x679C480", VA = "0x18679D680")]
		public void XSKSCIBWCMZ(a a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x679D2D0", Offset = "0x679C0D0", VA = "0x18679D2D0", Slot = "5")]
		private void VQQLLBKWFOK((a, b) a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6798D70", Offset = "0x6797B70", VA = "0x186798D70", Slot = "8")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public sealed class KXYLKUNJCBZ<a, b, c> : VCULCQRDTTS<(a, b, c)>, RIHVMHHTLCX, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly ELGCPVRQYKE<a, b, c> ATQDIZQEZJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly ELGCPVRQYKE<a, b, c> VCRDMBDOHAD;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public string XVKQGRWDPTO
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0xF7FC80", Offset = "0xF7EA80", VA = "0x180F7FC80", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public bool DYDPMZUXIXY
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x67A04E0", Offset = "0x679F2E0", VA = "0x1867A04E0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool CSGBEEJSMXP
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x67A1C10", Offset = "0x67A0A10", VA = "0x1867A1C10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public bool CRQGMKCAKPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x67A1A70", Offset = "0x67A0870", VA = "0x1867A1A70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public bool CRVNJQVXUAX
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x67A19A0", Offset = "0x67A07A0", VA = "0x1867A19A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public (a, b, c) RGWETDIXIUV
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x679EF00", Offset = "0x679DD00", VA = "0x18679EF00", Slot = "11")]
			get
			{
				return default((a, b, c));
			}
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x67A1590", Offset = "0x67A0390", VA = "0x1867A1590", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public (a, b, c) GXDNQKLGWZS
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x679FCD0", Offset = "0x679EAD0", VA = "0x18679FCD0", Slot = "4")]
			get
			{
				return default((a, b, c));
			}
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x67A07C0", Offset = "0x679F5C0", VA = "0x1867A07C0", Slot = "13")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public a OHSLLYIJRJW
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x67A0050", Offset = "0x679EE50", VA = "0x1867A0050")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x67A2670", Offset = "0x67A1470", VA = "0x1867A2670")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public a MHOAZBXTNRJ
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x679F710", Offset = "0x679E510", VA = "0x18679F710")]
			get
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public a BRBVLPJSAAV
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x679F710", Offset = "0x679E510", VA = "0x18679F710")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x679EA90", Offset = "0x679D890", VA = "0x18679EA90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public b OIIGDSQBTRX
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x679FF40", Offset = "0x679ED40", VA = "0x18679FF40")]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x67A1F60", Offset = "0x67A0D60", VA = "0x1867A1F60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public b MHTHWIRQXCS
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x679F8D0", Offset = "0x679E6D0", VA = "0x18679F8D0")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public b BQMATVBZXSU
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x679F8D0", Offset = "0x679E6D0", VA = "0x18679F8D0")]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x679EE70", Offset = "0x679DC70", VA = "0x18679EE70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public c OICZGLWEKGO
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x67A0020", Offset = "0x679EE20", VA = "0x1867A0020")]
			get
			{
				return (c)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x67A2190", Offset = "0x67A0F90", VA = "0x1867A2190")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public c MHYOTPLOGOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x679F7F0", Offset = "0x679E5F0", VA = "0x18679F7F0")]
			get
			{
				return (c)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public c BQRHRBVXHED
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x679F7F0", Offset = "0x679E5F0", VA = "0x18679F7F0")]
			get
			{
				return (c)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x679EC80", Offset = "0x679DA80", VA = "0x18679EC80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool IPCJQPKHCXU
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x679D620", Offset = "0x679C420", VA = "0x18679D620", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x67A1E40", Offset = "0x67A0C40", VA = "0x1867A1E40", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x67A35F0", Offset = "0x67A23F0", VA = "0x1867A35F0")]
		public KXYLKUNJCBZ([In] SyncData data, a a, b b, c c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x67A0400", Offset = "0x679F200", VA = "0x1867A0400")]
		private void HFPUNXLANYG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x67A2A60", Offset = "0x67A1860", VA = "0x1867A2A60")]
		public void VAGJAGZKTUG(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x67A27A0", Offset = "0x67A15A0", VA = "0x1867A27A0")]
		public void TLHKGADZRKR(b a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x67A0B40", Offset = "0x679F940", VA = "0x1867A0B40")]
		public void KJCMSPHGLSA(c a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x67A3040", Offset = "0x67A1E40", VA = "0x1867A3040")]
		public void XSKSCIBWCMZ(a a, b b, c c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x679F3E0", Offset = "0x679E1E0", VA = "0x18679F3E0", Slot = "5")]
		private void CNHXBFFQVLN((a, b, c) a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x6798D70", Offset = "0x6797B70", VA = "0x186798D70", Slot = "8")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public sealed class KYYTXCIVXGS<a, b, c, d> : VCULCQRDTTS<(a, b, c, d)>, RIHVMHHTLCX, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly EMQYWRAYMLP<a, b, c, d> ATQDIZQEZJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly EMQYWRAYMLP<a, b, c, d> VCRDMBDOHAD;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public string XVKQGRWDPTO
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xF7FC80", Offset = "0xF7EA80", VA = "0x180F7FC80", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public (a, b, c, d) GXDNQKLGWZS
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x67A9E00", Offset = "0x67A8C00", VA = "0x1867A9E00", Slot = "4")]
			get
			{
				return default((a, b, c, d));
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x67AA9D0", Offset = "0x67A97D0", VA = "0x1867AA9D0", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public b MHTHWIRQXCS
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x67A9C40", Offset = "0x67A8A40", VA = "0x1867A9C40")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public c MHYOTPLOGOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x67A9C10", Offset = "0x67A8A10", VA = "0x1867A9C10")]
			get
			{
				return (c)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public d MGNSMUCGSMQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x67A9DD0", Offset = "0x67A8BD0", VA = "0x1867A9DD0")]
			get
			{
				return (d)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool IPCJQPKHCXU
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x679D620", Offset = "0x679C420", VA = "0x18679D620", Slot = "7")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x679BD90", Offset = "0x679AB90", VA = "0x18679BD90", Slot = "10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x67ABAF0", Offset = "0x67AA8F0", VA = "0x1867ABAF0")]
		public KYYTXCIVXGS([In] SyncData data, a a, b b, c c, d d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x67AA2D0", Offset = "0x67A90D0", VA = "0x1867AA2D0")]
		private void HFPUNXLANYG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x67AADC0", Offset = "0x67A9BC0", VA = "0x1867AADC0")]
		public void VAGJAGZKTUG(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x67AB150", Offset = "0x67A9F50", VA = "0x1867AB150")]
		public void XSKSCIBWCMZ(a a, b b, c c, d d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x67AAA20", Offset = "0x67A9820", VA = "0x1867AAA20", Slot = "5")]
		private void PVFKXRSYNBN((a, b, c, d) a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6798D70", Offset = "0x6797B70", VA = "0x186798D70", Slot = "8")]
		public void Dispose()
		{
		}
	}
}
namespace RecRoom.Networking.Policy
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class QTVCRBMMUUQ
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x997CA30", Offset = "0x997B830", VA = "0x18997CA30")]
		public static string FSIGNWOSSAD(this SyncData a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xD512A0", Offset = "0xD500A0", VA = "0x180D512A0")]
		public static NetworkSetterPermissionMode FKOFDFGBUWI(this SyncData a)
		{
			return default(NetworkSetterPermissionMode);
		}
	}
}
namespace RecRoom.Networking.SynchronizedFields
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class ELQQKJFLRGW<a> : HANJKIAZVNZ<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x5B01C70", Offset = "0x5B00A70", VA = "0x185B01C70")]
		public ELQQKJFLRGW([In] SyncData data, a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x5B026A0", Offset = "0x5B014A0", VA = "0x185B026A0")]
		public ELQQKJFLRGW(SABLHYKIBLD a, GUPOFWBVNMS b, string c, a d, NetworkSetterPermissionMode e, [Optional] Action f, [Optional] BPOYGHLAACR g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x5AFFA50", Offset = "0x5AFE850", VA = "0x185AFFA50")]
		public ELQQKJFLRGW(SABLHYKIBLD a, string b, a c, NetworkSetterPermissionMode d, [Optional] Action e, [Optional] BPOYGHLAACR f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x5B02E80", Offset = "0x5B01C80", VA = "0x185B02E80")]
		public ELQQKJFLRGW(SABLHYKIBLD a, string b, a c, NetworkSetterPermissionMode d, bool e, [Optional] Action f, [Optional] BPOYGHLAACR g)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class ELLJNCLOHVN<a, b> : HASQHOUXEZI<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x5AFCF00", Offset = "0x5AFBD00", VA = "0x185AFCF00")]
		public ELLJNCLOHVN([In] SyncData data, a a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x5AFA660", Offset = "0x5AF9460", VA = "0x185AFA660")]
		public ELLJNCLOHVN(SABLHYKIBLD a, GUPOFWBVNMS b, string c, a d, b e, NetworkSetterPermissionMode f, [Optional] Action g, [Optional] BPOYGHLAACR h)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x5AFC670", Offset = "0x5AFB470", VA = "0x185AFC670")]
		public ELLJNCLOHVN(SABLHYKIBLD a, string b, a c, b d, NetworkSetterPermissionMode e, [Optional] Action f, [Optional] BPOYGHLAACR g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x5AFC460", Offset = "0x5AFB260", VA = "0x185AFC460")]
		public ELLJNCLOHVN(SABLHYKIBLD a, string b, a c, b d, NetworkSetterPermissionMode e, bool f, [Optional] Action g, [Optional] BPOYGHLAACR h)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class ELGCPVRQYKE<a, b, c> : HAXXEVOUOKR<a, b, c>
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x5AF2770", Offset = "0x5AF1570", VA = "0x185AF2770")]
		public ELGCPVRQYKE([In] SyncData data, a a, b b, c c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x5AF2930", Offset = "0x5AF1730", VA = "0x185AF2930")]
		public ELGCPVRQYKE(SABLHYKIBLD a, string b, a c, b d, c e, NetworkSetterPermissionMode f, [Optional] Action g, [Optional] BPOYGHLAACR h)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class EMQYWRAYMLP<a, b, c, d> : GZNAYAFNAJG<a, b, c, d>
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x5B05750", Offset = "0x5B04550", VA = "0x185B05750")]
		public EMQYWRAYMLP([In] SyncData data, a a, b b, c c, d d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x5B05400", Offset = "0x5B04200", VA = "0x185B05400")]
		public EMQYWRAYMLP(SABLHYKIBLD a, GUPOFWBVNMS b, string c, a d, b e, c f, d g, NetworkSetterPermissionMode h, [Optional] Action i, [Optional] BPOYGHLAACR j)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x5B050D0", Offset = "0x5B03ED0", VA = "0x185B050D0")]
		public EMQYWRAYMLP(SABLHYKIBLD a, string b, a c, b d, c e, d f, NetworkSetterPermissionMode g, [Optional] Action h, [Optional] BPOYGHLAACR i)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class EMLRZKHBDAG<a, b, c, d, e> : GZSHVGZKJUP<a, b, c, d, e>
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x5B044B0", Offset = "0x5B032B0", VA = "0x185B044B0")]
		public EMLRZKHBDAG(SABLHYKIBLD a, GUPOFWBVNMS b, string c, a d, b e, c f, d g, e h, NetworkSetterPermissionMode i, [Optional] Action j, [Optional] BPOYGHLAACR k)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x5B03D40", Offset = "0x5B02B40", VA = "0x185B03D40")]
		public EMLRZKHBDAG(SABLHYKIBLD a, string b, a c, b d, c e, d f, e g, NetworkSetterPermissionMode h, [Optional] Action i, [Optional] BPOYGHLAACR j)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class FLDXNDYBBNX<a> : HANJKIAZVNZ<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x62A37F0", Offset = "0x62A25F0", VA = "0x1862A37F0")]
		public FLDXNDYBBNX(GUPOFWBVNMS a, string b, a c, [Optional] Action d, [Optional] BPOYGHLAACR e)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class FKOCVJQIZFW<a, b> : HASQHOUXEZI<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x62A3140", Offset = "0x62A1F40", VA = "0x1862A3140")]
		public FKOCVJQIZFW(GUPOFWBVNMS a, string b, a c, b d, [Optional] Action e, [Optional] BPOYGHLAACR f)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public interface LZHEMRHKFUH
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "0")]
		ELQQKJFLRGW<a> HZBEBTLUTFB<a>(string a, a b, NetworkSetterPermissionMode c, [Optional] Action d);
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class PLBZQKDNIKQ : LZHEMRHKFUH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly BPOYGHLAACR SCTPCCQTXAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly SABLHYKIBLD ACLJKNVEUJW;

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0xCE9C40", Offset = "0xCE8A40", VA = "0x180CE9C40")]
		public PLBZQKDNIKQ(BPOYGHLAACR a, SABLHYKIBLD b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x3D7E330", Offset = "0x3D7D130", VA = "0x183D7E330", Slot = "4")]
		public ELQQKJFLRGW<a> HZBEBTLUTFB<a>(string a, a b, NetworkSetterPermissionMode c, [Optional] Action d)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public interface POUEUUSEPBA : SABLHYKIBLD
	{
		[Cpp2IlInjected.Token(Token = "0x17000036")]
		ViewId NTZCCDPYCXW
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public interface SABLHYKIBLD
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		bool VIQCPVWISLW
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		bool ZRRMNTACRAU
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		string UWUZMUMWHOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		bool ZQNBLGXVZKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void RegisterDestroyHandler(XVBFOFGHFVF handler);

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void UnregisterDestroyHandler(XVBFOFGHFVF handler);
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public static class VJJUFNKCWQD
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x997F4A0", Offset = "0x997E2A0", VA = "0x18997F4A0")]
		public static bool FLBFIVJJSFK(this SABLHYKIBLD a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface BPOYGHLAACR : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		GUPOFWBVNMS JEGPTVEDGKN
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		bool OKAKVETJBLG
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		bool RLAZWSISEMB
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
		object QGSQJJFURNP(string a);

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "5")]
		object BTMOXRDNACH(GUPOFWBVNMS a, string b);

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void EMLXLKOEQPT(string a, object b);

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void FAREEZKNLRB(GUPOFWBVNMS a, string b, object c);

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void IGSETKBNSSY<a>(string a, a b);

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void SOWSMCAKDVQ([CanBeNull] GUPOFWBVNMS photonPlayer, string a, DSZGRWEPSDL b);

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void NCAXLBLKKJJ([CanBeNull] GUPOFWBVNMS photonPlayer, string a, DSZGRWEPSDL b);

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "11")]
		b RIJWCXNKQXH<b>(object a);

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(Slot = "12")]
		object IEFNSKTCZOA<c>(c a);

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "13")]
		object RIJWCXNKQXH(object a, Type b);

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "14")]
		object IEFNSKTCZOA(object a, Type b);

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void UDJLVKSOGSV();

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "16")]
		void FLLBNEEMPDJ();

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "17")]
		void DQHEOFUNLEC(string a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public struct SyncData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public GUPOFWBVNMS player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public SABLHYKIBLD context;

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
		public BPOYGHLAACR networkBacking;

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x997CAC0", Offset = "0x997B8C0", VA = "0x18997CAC0")]
		public SyncData(SyncData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x997CB40", Offset = "0x997B940", VA = "0x18997CB40")]
		public SyncData(SABLHYKIBLD context, string key, NetworkSetterPermissionMode permissionMode, [Optional] Action callback, [Optional] BPOYGHLAACR networkBacking)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x997CA70", Offset = "0x997B870", VA = "0x18997CA70")]
		public static SyncData From(SABLHYKIBLD context, string key, NetworkSetterPermissionMode permissionMode, [Optional] Action callback, [Optional] BPOYGHLAACR networkBacking)
		{
			return default(SyncData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public static class CYWODZONAWA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x38302F0", Offset = "0x382F0F0", VA = "0x1838302F0")]
		public static ELQQKJFLRGW<a> DSZGRWEPSDL<a>(this SyncData a, a b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x382F1F0", Offset = "0x382DFF0", VA = "0x18382F1F0")]
		public static ELLJNCLOHVN<b, c> DSZGRWEPSDL<b, c>(this SyncData a, b b, c c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x382F290", Offset = "0x382E090", VA = "0x18382F290")]
		public static ELGCPVRQYKE<d, e, f> DSZGRWEPSDL<d, e, f>(this SyncData a, d b, e c, f d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x382FDA0", Offset = "0x382EBA0", VA = "0x18382FDA0")]
		public static EMQYWRAYMLP<g, h, i, j> DSZGRWEPSDL<g, h, i, j>(this SyncData a, g b, h c, i d, j e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x3830570", Offset = "0x382F370", VA = "0x183830570")]
		public static KYIZFIBDUYR<k> VGOLVWUTBPE<k>(this SyncData a, k b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x3830420", Offset = "0x382F220", VA = "0x183830420")]
		public static KXTENNTLSQQ<l, m> VGOLVWUTBPE<l, m>(this SyncData a, l b, m c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x38304C0", Offset = "0x382F2C0", VA = "0x1838304C0")]
		public static KXYLKUNJCBZ<n, o, p> VGOLVWUTBPE<n, o, p>(this SyncData a, n b, o c, p d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x3830840", Offset = "0x382F640", VA = "0x183830840")]
		public static KYYTXCIVXGS<q, r, s, t> VGOLVWUTBPE<q, r, s, t>(this SyncData a, q b, r c, s d, t e)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public abstract class DSZGRWEPSDL : XVBFOFGHFVF, IDisposable
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
		private static Stack<BPOYGHLAACR> LVVGOYAJUUL;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static bool AHEZZJFPAKW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		protected readonly GUPOFWBVNMS TNHMXMRDUHW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		protected readonly SABLHYKIBLD ACLJKNVEUJW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		protected readonly string APYHZOACXVC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		protected readonly NetworkSetterPermissionMode BKNPHPUPYFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		protected readonly Action PKLQWBZQGHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		protected BPOYGHLAACR YJWXSHOLLPQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private Flags JTBPWUDBHYM;

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public static BPOYGHLAACR UPQARFASCJL
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x997B1C0", Offset = "0x9979FC0", VA = "0x18997B1C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		private bool RAXOSSGVOEZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x997B470", Offset = "0x997A270", VA = "0x18997B470")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x997C4E0", Offset = "0x997B2E0", VA = "0x18997C4E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		private bool KHNQLVWNRYM
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x997B1B0", Offset = "0x9979FB0", VA = "0x18997B1B0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x997B4D0", Offset = "0x997A2D0", VA = "0x18997B4D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		private bool JVCWZVKKNSR
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x997C500", Offset = "0x997B300", VA = "0x18997C500")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x997C1E0", Offset = "0x997AFE0", VA = "0x18997C1E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public bool IPCJQPKHCXU
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x997C4D0", Offset = "0x997B2D0", VA = "0x18997C4D0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x997C050", Offset = "0x997AE50", VA = "0x18997C050")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		protected virtual object ZSUBFNTLSZS
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0xCE82E0", Offset = "0xCE70E0", VA = "0x180CE82E0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0xCE8290", Offset = "0xCE7090", VA = "0x180CE8290", Slot = "8")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public bool PTHEWMYULDZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x997B480", Offset = "0x997A280", VA = "0x18997B480")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public int LJRZZRLLQVC
		{
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0xEE5F80", Offset = "0xEE4D80", VA = "0x180EE5F80")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x1AA2FA0", Offset = "0x1AA1DA0", VA = "0x181AA2FA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public string XVKQGRWDPTO
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0xCE8BC0", Offset = "0xCE79C0", VA = "0x180CE8BC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public bool OKAKVETJBLG
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x997B6C0", Offset = "0x997A4C0", VA = "0x18997B6C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x997BFB0", Offset = "0x997ADB0", VA = "0x18997BFB0")]
		public static void RVYOWFLRGNW(BPOYGHLAACR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(Slot = "9")]
		protected abstract bool BTXDAICSWIK();

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x997C810", Offset = "0x997B610", VA = "0x18997C810")]
		protected DSZGRWEPSDL(GUPOFWBVNMS a, SABLHYKIBLD b, string c, NetworkSetterPermissionMode d, Action e, BPOYGHLAACR f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x997B3B0", Offset = "0x997A1B0", VA = "0x18997B3B0", Slot = "1")]
		~DSZGRWEPSDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x997B230", Offset = "0x997A030", VA = "0x18997B230", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x997B8E0", Offset = "0x997A6E0", VA = "0x18997B8E0")]
		private void NDJNXVTLYDK(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x997C220", Offset = "0x997B020", VA = "0x18997C220")]
		private object WAOJVQXJEXC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x997B4F0", Offset = "0x997A2F0", VA = "0x18997B4F0")]
		protected void Initialize(bool enforceInitialValue, object initialValue, bool initialValueIsDefaultValue = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x997C110", Offset = "0x997AF10", VA = "0x18997C110")]
		protected void Set(object newValue, bool checkPermission = true, bool suppressCallback = false, bool requireModified = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x997C520", Offset = "0x997B320", VA = "0x18997C520")]
		protected void ZROXUQOGEDL(object a, bool b, bool c, bool d = false, bool e = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x997B710", Offset = "0x997A510", VA = "0x18997B710")]
		internal void LOMLKNASVXH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x997B410", Offset = "0x997A210", VA = "0x18997B410")]
		private void GRJZTQFJWGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x997B150", Offset = "0x9979F50", VA = "0x18997B150")]
		private void BCBPNBWJVBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x997BB90", Offset = "0x997A990", VA = "0x18997BB90", Slot = "4")]
		private void PUHIKKOKYLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x997C510", Offset = "0x997B310", VA = "0x18997C510", Slot = "5")]
		private void ZOTOSRAZQYZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x997C390", Offset = "0x997B190", VA = "0x18997C390")]
		public bool WLQFTMAVUSD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x997BC00", Offset = "0x997AA00", VA = "0x18997BC00")]
		public bool QJWKKTVCBKH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x997B790", Offset = "0x997A590", VA = "0x18997B790")]
		private bool LUHNZVVJERO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x997B980", Offset = "0x997A780", VA = "0x18997B980")]
		internal void ORSVODJMVGV(object a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x997BDC0", Offset = "0x997ABC0", VA = "0x18997BDC0")]
		private void QNDAIZVEWZR(object a, bool b, bool c = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x997B3A0", Offset = "0x997A1A0", VA = "0x18997B3A0")]
		private bool FWQQFIPPCXP(Flags a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x997C200", Offset = "0x997B000", VA = "0x18997C200")]
		private void VWUHQOMIPND(Flags a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x997C150", Offset = "0x997AF50", VA = "0x18997C150")]
		public static string TKBAEZZJGAX(GUPOFWBVNMS a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x997BED0", Offset = "0x997ACD0", VA = "0x18997BED0")]
		public static string RHANOHRBCFZ(SABLHYKIBLD a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x997BA30", Offset = "0x997A830", VA = "0x18997BA30")]
		public static bool PQMDDUXMIBD(object a, object b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public abstract class UXUTZVSTAYP : BPOYGHLAACR, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly Dictionary<object, object> JPBAQPMJGLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly List<string> KQESZWHAQBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly Dictionary<object, object> KFBYCBIJPEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly List<string> TQIMEHPZBVI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private bool ICYNOWPKTPY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		protected readonly Dictionary<string, object> LTYOOJQQFVW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		protected readonly Dictionary<GUPOFWBVNMS, Dictionary<string, object>> GYPKHBLGLGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly HashSet<string> ZKFTBHLOZTN;

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public abstract Dictionary<object, object> NXDALBFNBUP
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(Slot = "23")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public abstract int HBEGKNLVLLS
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(Slot = "24")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public abstract GUPOFWBVNMS JEGPTVEDGKN
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(Slot = "25")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public abstract bool OKAKVETJBLG
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(Slot = "26")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public abstract bool RLAZWSISEMB
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(Slot = "27")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public virtual bool FBUEEULATRU
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0xD00B10", Offset = "0xCFF910", VA = "0x180D00B10", Slot = "28")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public bool AJRBHITXSUS
		{
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0xD44660", Offset = "0xD43460", VA = "0x180D44660")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x40908F0", Offset = "0x408F6F0", VA = "0x1840908F0", Slot = "12")]
		public void IGSETKBNSSY<a>(string a, a b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x997D590", Offset = "0x997C390", VA = "0x18997D590", Slot = "11")]
		public void FAREEZKNLRB(GUPOFWBVNMS a, string b, object c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x997CDC0", Offset = "0x997BBC0", VA = "0x18997CDC0", Slot = "9")]
		public object BTMOXRDNACH(GUPOFWBVNMS a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x997D460", Offset = "0x997C260", VA = "0x18997D460", Slot = "10")]
		public void EMLXLKOEQPT(string a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x997E860", Offset = "0x997D660", VA = "0x18997E860", Slot = "8")]
		public object QGSQJJFURNP(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x997EB20", Offset = "0x997D920", VA = "0x18997EB20", Slot = "13")]
		public void SOWSMCAKDVQ(GUPOFWBVNMS a, string b, DSZGRWEPSDL c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x997E260", Offset = "0x997D060", VA = "0x18997E260", Slot = "14")]
		public void NCAXLBLKKJJ(GUPOFWBVNMS a, string b, DSZGRWEPSDL c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x997D890", Offset = "0x997C690", VA = "0x18997D890")]
		private void HRIKOHWHUHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x997E180", Offset = "0x997CF80", VA = "0x18997E180")]
		private void LOIEEEIYEFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x997EFE0", Offset = "0x997DDE0", VA = "0x18997EFE0")]
		private void YFLOMAXBNLS(GUPOFWBVNMS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x997E060", Offset = "0x997CE60", VA = "0x18997E060")]
		protected void LGGFBZJUNXA(GUPOFWBVNMS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x997CCD0", Offset = "0x997BAD0", VA = "0x18997CCD0")]
		protected void AJMCQFZIWBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x997D580", Offset = "0x997C380", VA = "0x18997D580")]
		protected void FAPAGXWVKSC(IDictionary<object, object> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x997F040", Offset = "0x997DE40", VA = "0x18997F040")]
		protected void YZCYDVKAEEC(GUPOFWBVNMS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x997E1D0", Offset = "0x997CFD0", VA = "0x18997E1D0")]
		protected void MBBDXBVXVIQ(GUPOFWBVNMS a, IDictionary<object, object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x997D8E0", Offset = "0x997C6E0", VA = "0x18997D8E0")]
		private void INIFEVMHDMP(IDictionary<object, object> a, Dictionary<string, object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x997F0B0", Offset = "0x997DEB0", VA = "0x18997F0B0")]
		private static void ZWIYCFKOIQD(object a, object b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x997E900", Offset = "0x997D700", VA = "0x18997E900")]
		private static void SCEKKFAOCKO(Dictionary<string, object> a, string b, DSZGRWEPSDL c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x997CEB0", Offset = "0x997BCB0", VA = "0x18997CEB0")]
		private static void BXAVWEKFACN(Dictionary<string, object> a, string b, DSZGRWEPSDL c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x997ECC0", Offset = "0x997DAC0", VA = "0x18997ECC0", Slot = "19")]
		public void UDJLVKSOGSV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(Slot = "29")]
		protected abstract void HMKMHWYISKI(Dictionary<object, object> a);

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x997D6E0", Offset = "0x997C4E0", VA = "0x18997D6E0", Slot = "20")]
		public void FLLBNEEMPDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "30")]
		protected abstract void ANEJCGAGOYK(Dictionary<object, object> a);

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x997EDC0", Offset = "0x997DBC0", VA = "0x18997EDC0")]
		private void UMYPMKFZSJD(Dictionary<object, object> a, List<string> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x997DD50", Offset = "0x997CB50", VA = "0x18997DD50")]
		private void IXSJBMCTNBS(IDictionary<object, object> a, [Out] int b, [Out] string[] c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x997DFD0", Offset = "0x997CDD0", VA = "0x18997DFD0")]
		public void JJNZUVNQKOT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x997D7C0", Offset = "0x997C5C0", VA = "0x18997D7C0")]
		public void FUNYKAKKQIT(GUPOFWBVNMS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x997E500", Offset = "0x997D300", VA = "0x18997E500")]
		public void PXPVUQITXQI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "31")]
		protected abstract HashSet<int> LBDMWLLMDAI(bool a, bool b);

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x997D080", Offset = "0x997BE80", VA = "0x18997D080", Slot = "21")]
		public void DQHEOFUNLEC(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x997EC30", Offset = "0x997DA30", VA = "0x18997EC30")]
		protected string TKBAEZZJGAX(GUPOFWBVNMS a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "32")]
		public abstract object IEFNSKTCZOA<b>(b a);

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "33")]
		public abstract c RIJWCXNKQXH<c>(object a);

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(Slot = "34")]
		public abstract object IEFNSKTCZOA(object a, Type b);

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(Slot = "35")]
		public abstract object RIJWCXNKQXH(object a, Type b);

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150", Slot = "36")]
		public virtual void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x997D300", Offset = "0x997C100", VA = "0x18997D300", Slot = "22")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150", Slot = "37")]
		protected virtual void XTLFXBYXWKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x997F2B0", Offset = "0x997E0B0", VA = "0x18997F2B0")]
		protected UXUTZVSTAYP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public abstract class HANJKIAZVNZ<a> : DSZGRWEPSDL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private a GOYCTKPBZHU;

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		protected virtual a QFZCBOARGNP
		{
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x64405C0", Offset = "0x643F3C0", VA = "0x1864405C0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x643F370", Offset = "0x643E170", VA = "0x18643F370", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		protected override object ZSUBFNTLSZS
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x639A440", Offset = "0x6399240", VA = "0x18639A440", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x6440360", Offset = "0x643F160", VA = "0x186440360", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x643E170", Offset = "0x643CF70", VA = "0x18643E170", Slot = "9")]
		protected override bool BTXDAICSWIK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x6446D30", Offset = "0x6445B30", VA = "0x186446D30")]
		protected HANJKIAZVNZ([In] SyncData data, a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x64473D0", Offset = "0x64461D0", VA = "0x1864473D0")]
		protected HANJKIAZVNZ(GUPOFWBVNMS a, SABLHYKIBLD b, string c, a d, NetworkSetterPermissionMode e, bool f, Action g, BPOYGHLAACR h)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x5313DC0", Offset = "0x5312BC0", VA = "0x185313DC0")]
		public a Get()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x64447A0", Offset = "0x64435A0", VA = "0x1864447A0")]
		public void Set(a newValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x6441B20", Offset = "0x6440920", VA = "0x186441B20")]
		public void Set(a newValue, bool checkPermission, bool suppressCallback = false, bool requireModified = true)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public abstract class HASQHOUXEZI<a, b> : DSZGRWEPSDL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private a GOYCTKPBZHU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private b GOSVWDVEPWL;

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		protected virtual a QFZCBOARGNP
		{
			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x10E4190", Offset = "0x10E2F90", VA = "0x1810E4190", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x12B2830", Offset = "0x12B1630", VA = "0x1812B2830", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		protected virtual b QFJHJTSZEFO
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x3277010", Offset = "0x3275E10", VA = "0x183277010", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x6448FD0", Offset = "0x6447DD0", VA = "0x186448FD0", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public b GGQLDJOFBTO
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x17189F0", Offset = "0x17177F0", VA = "0x1817189F0")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		protected override object ZSUBFNTLSZS
		{
			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x639A440", Offset = "0x6399240", VA = "0x18639A440", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x6449010", Offset = "0x6447E10", VA = "0x186449010", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x6448CE0", Offset = "0x6447AE0", VA = "0x186448CE0", Slot = "9")]
		protected override bool BTXDAICSWIK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x644C020", Offset = "0x644AE20", VA = "0x18644C020")]
		protected HASQHOUXEZI([In] SyncData data, a a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x644B290", Offset = "0x644A090", VA = "0x18644B290")]
		protected HASQHOUXEZI(GUPOFWBVNMS a, SABLHYKIBLD b, string c, a d, b e, NetworkSetterPermissionMode f, bool g, Action h, BPOYGHLAACR i)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x5313DC0", Offset = "0x5312BC0", VA = "0x185313DC0")]
		public a EVBINGRLEAG()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x6449D50", Offset = "0x6448B50", VA = "0x186449D50")]
		public void SDAPFWWDJHI(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x17189F0", Offset = "0x17177F0", VA = "0x1817189F0")]
		public b EUWBPZXNUOX()
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x6449A60", Offset = "0x6448860", VA = "0x186449A60")]
		public void SCVIIQCFZVZ(b a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x644AF00", Offset = "0x6449D00", VA = "0x18644AF00")]
		public void Set(a newValue1, b newValue2, bool checkPermission = true, bool suppressCallback = false, bool requireModified = true)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public abstract class HAXXEVOUOKR<a, b, c> : DSZGRWEPSDL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private a GOYCTKPBZHU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private b GOSVWDVEPWL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private c GONOYXBHGLC;

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		protected virtual a QFZCBOARGNP
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0xCF7E00", Offset = "0xCF6C00", VA = "0x180CF7E00", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0xCF7D50", Offset = "0xCF6B50", VA = "0x180CF7D50", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		protected virtual b QFJHJTSZEFO
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0xEDC840", Offset = "0xEDB640", VA = "0x180EDC840", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x2AA72D0", Offset = "0x2AA60D0", VA = "0x182AA72D0", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		protected virtual c QFOOHAMWNQX
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0xCE7B60", Offset = "0xCE6960", VA = "0x180CE7B60", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return (c)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0xCE7AE0", Offset = "0xCE68E0", VA = "0x180CE7AE0", Slot = "15")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public a GHGFVDVXEBP
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x5313DC0", Offset = "0x5312BC0", VA = "0x185313DC0")]
			get
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public b GGQLDJOFBTO
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x17189F0", Offset = "0x17177F0", VA = "0x1817189F0")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public c GGVSAQICLEX
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x639DB60", Offset = "0x639C960", VA = "0x18639DB60")]
			get
			{
				return (c)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		protected override object ZSUBFNTLSZS
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x639A440", Offset = "0x6399240", VA = "0x18639A440", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x6458340", Offset = "0x6457140", VA = "0x186458340", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x6456C50", Offset = "0x6455A50", VA = "0x186456C50", Slot = "9")]
		protected override bool BTXDAICSWIK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x645FAD0", Offset = "0x645E8D0", VA = "0x18645FAD0")]
		protected HAXXEVOUOKR([In] SyncData data, a a, b b, c c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x645DA80", Offset = "0x645C880", VA = "0x18645DA80")]
		protected HAXXEVOUOKR(GUPOFWBVNMS a, SABLHYKIBLD b, string c, a d, b e, c f, NetworkSetterPermissionMode g, bool h, Action i, BPOYGHLAACR j)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x5313DC0", Offset = "0x5312BC0", VA = "0x185313DC0")]
		public a EVBINGRLEAG()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x645A8D0", Offset = "0x64596D0", VA = "0x18645A8D0")]
		public void SDAPFWWDJHI(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x17189F0", Offset = "0x17177F0", VA = "0x1817189F0")]
		public b EUWBPZXNUOX()
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x6459760", Offset = "0x6458560", VA = "0x186459760")]
		public void SCVIIQCFZVZ(b a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x639DB60", Offset = "0x639C960", VA = "0x18639DB60")]
		public c EUQUSTDQLDO()
		{
			return (c)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x64590A0", Offset = "0x6457EA0", VA = "0x1864590A0")]
		public void SCQBLJIIQKQ(c a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x645A9F0", Offset = "0x64597F0", VA = "0x18645A9F0")]
		public void Set(a newValue1, b newValue2, c newValue3, bool checkPermission = true)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public abstract class GZNAYAFNAJG<a, b, c, d> : DSZGRWEPSDL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private a GOYCTKPBZHU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private b GOSVWDVEPWL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private c GONOYXBHGLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private d GPYLFSKOUMN;

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		protected virtual a QFZCBOARGNP
		{
			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0xF539F0", Offset = "0xF527F0", VA = "0x180F539F0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x639A430", Offset = "0x6399230", VA = "0x18639A430", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		protected virtual b QFJHJTSZEFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x1488670", Offset = "0x1487470", VA = "0x181488670", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x1484960", Offset = "0x1483760", VA = "0x181484960", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		protected virtual c QFOOHAMWNQX
		{
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x150B280", Offset = "0x150A080", VA = "0x18150B280", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return (c)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x639A3F0", Offset = "0x63991F0", VA = "0x18639A3F0", Slot = "15")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		protected virtual d QGOWTIIJIVQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x1D3E1C0", Offset = "0x1D3CFC0", VA = "0x181D3E1C0", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return (d)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x16792B0", Offset = "0x16780B0", VA = "0x1816792B0", Slot = "17")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public b GGQLDJOFBTO
		{
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x639A340", Offset = "0x6399140", VA = "0x18639A340")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public c GGVSAQICLEX
		{
			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0x639A2C0", Offset = "0x63990C0", VA = "0x18639A2C0")]
			get
			{
				return (c)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public d GHWAMYDPGJQ
		{
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x15BED30", Offset = "0x15BDB30", VA = "0x1815BED30")]
			get
			{
				return (d)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		protected override object ZSUBFNTLSZS
		{
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0x639A440", Offset = "0x6399240", VA = "0x18639A440", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0x639A8B0", Offset = "0x63996B0", VA = "0x18639A8B0", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x639A000", Offset = "0x6398E00", VA = "0x18639A000", Slot = "9")]
		protected override bool BTXDAICSWIK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x639C2C0", Offset = "0x639B0C0", VA = "0x18639C2C0")]
		protected GZNAYAFNAJG([In] SyncData data, a a, b b, c c, d d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x639BF80", Offset = "0x639AD80", VA = "0x18639BF80")]
		protected GZNAYAFNAJG(GUPOFWBVNMS a, SABLHYKIBLD b, string c, a d, b e, c f, d g, NetworkSetterPermissionMode h, bool i, Action j, BPOYGHLAACR k)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x5313DC0", Offset = "0x5312BC0", VA = "0x185313DC0")]
		public a EVBINGRLEAG()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x639B480", Offset = "0x639A280", VA = "0x18639B480")]
		public void SDAPFWWDJHI(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x639A340", Offset = "0x6399140", VA = "0x18639A340")]
		public b EUWBPZXNUOX()
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x639B240", Offset = "0x639A040", VA = "0x18639B240")]
		public void SCVIIQCFZVZ(b a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x639A2C0", Offset = "0x63990C0", VA = "0x18639A2C0")]
		public c EUQUSTDQLDO()
		{
			return (c)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x639AEF0", Offset = "0x6399CF0", VA = "0x18639AEF0")]
		public void SCQBLJIIQKQ(c a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x15BED30", Offset = "0x15BDB30", VA = "0x1815BED30")]
		public d EWBQZOMXZEZ()
		{
			return (d)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x639AE00", Offset = "0x6399C00", VA = "0x18639AE00")]
		public void SCKUOCOLGZH(d a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x639BAC0", Offset = "0x639A8C0", VA = "0x18639BAC0")]
		public void Set(a newValue1, b newValue2, c newValue3, d newValue4, bool checkPermission = true)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public abstract class GZSHVGZKJUP<a, b, c, d, e> : DSZGRWEPSDL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private a GOYCTKPBZHU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private b GOSVWDVEPWL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private c GONOYXBHGLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private d GPYLFSKOUMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private e GPTEILQRLBE;

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		protected virtual a QFZCBOARGNP
		{
			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0xCF7E00", Offset = "0xCF6C00", VA = "0x180CF7E00", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0xCF7D50", Offset = "0xCF6B50", VA = "0x180CF7D50", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		protected virtual b QFJHJTSZEFO
		{
			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0xDDF380", Offset = "0xDDE180", VA = "0x180DDF380", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0x149CD80", Offset = "0x149BB80", VA = "0x18149CD80", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		protected virtual c QFOOHAMWNQX
		{
			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0xE0DEE0", Offset = "0xE0CCE0", VA = "0x180E0DEE0", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return (c)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0xE0E920", Offset = "0xE0D720", VA = "0x180E0E920", Slot = "15")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		protected virtual d QGOWTIIJIVQ
		{
			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(RVA = "0xD00ED0", Offset = "0xCFFCD0", VA = "0x180D00ED0", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return (d)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0xD113B0", Offset = "0xD101B0", VA = "0x180D113B0", Slot = "17")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		protected virtual e QGUDQPCGSGZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0xD00B20", Offset = "0xCFF920", VA = "0x180D00B20", Slot = "18")]
			[CompilerGenerated]
			get
			{
				return (e)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x639DE60", Offset = "0x639CC60", VA = "0x18639DE60", Slot = "19")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		protected override object ZSUBFNTLSZS
		{
			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x639A440", Offset = "0x6399240", VA = "0x18639A440", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x63A7550", Offset = "0x63A6350", VA = "0x1863A7550", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x63A6420", Offset = "0x63A5220", VA = "0x1863A6420", Slot = "9")]
		protected override bool BTXDAICSWIK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x63ADCA0", Offset = "0x63ACAA0", VA = "0x1863ADCA0")]
		protected GZSHVGZKJUP(GUPOFWBVNMS a, SABLHYKIBLD b, string c, a d, b e, c f, d g, e h, NetworkSetterPermissionMode i, bool j, Action k, BPOYGHLAACR l)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x5313DC0", Offset = "0x5312BC0", VA = "0x185313DC0")]
		public a EVBINGRLEAG()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x63AA780", Offset = "0x63A9580", VA = "0x1863AA780")]
		public void SDAPFWWDJHI(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x17189F0", Offset = "0x17177F0", VA = "0x1817189F0")]
		public b EUWBPZXNUOX()
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x63AA220", Offset = "0x63A9020", VA = "0x1863AA220")]
		public void SCVIIQCFZVZ(b a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x639DB60", Offset = "0x639C960", VA = "0x18639DB60")]
		public c EUQUSTDQLDO()
		{
			return (c)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x63A99F0", Offset = "0x63A87F0", VA = "0x1863A99F0")]
		public void SCQBLJIIQKQ(c a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x15BED30", Offset = "0x15BDB30", VA = "0x1815BED30")]
		public d EWBQZOMXZEZ()
		{
			return (d)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x63A9360", Offset = "0x63A8160", VA = "0x1863A9360")]
		public void SCKUOCOLGZH(d a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x63A6F30", Offset = "0x63A5D30", VA = "0x1863A6F30")]
		public e EVWKCHTAPTQ()
		{
			return (e)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x63A8B30", Offset = "0x63A7930", VA = "0x1863A8B30")]
		public void SCFNQVUNXNY(e a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x63ABA00", Offset = "0x63AA800", VA = "0x1863ABA00")]
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
