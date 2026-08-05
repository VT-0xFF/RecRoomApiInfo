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
			[Cpp2IlInjected.Address(RVA = "0xFA46A0", Offset = "0xFA30A0", VA = "0x180FA46A0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool DYDPMZUXIXY
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x6880590", Offset = "0x687EF90", VA = "0x186880590", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public a RGWETDIXIUV
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x687FA40", Offset = "0x687E440", VA = "0x18687FA40", Slot = "11")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x6881F50", Offset = "0x6880950", VA = "0x186881F50", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public a GXDNQKLGWZS
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x687FC30", Offset = "0x687E630", VA = "0x18687FC30", Slot = "4")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x6880EA0", Offset = "0x687F8A0", VA = "0x186880EA0", Slot = "13")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public a PGGBLURLEPI
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x687FC30", Offset = "0x687E630", VA = "0x18687FC30")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x6882540", Offset = "0x6880F40", VA = "0x186882540")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool IPCJQPKHCXU
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x6879120", Offset = "0x6877B20", VA = "0x186879120", Slot = "7")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x6877710", Offset = "0x6876110", VA = "0x186877710", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool OKAKVETJBLG
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x6880F60", Offset = "0x687F960", VA = "0x186880F60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6883500", Offset = "0x6881F00", VA = "0x186883500", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6885180", Offset = "0x6883B80", VA = "0x186885180")]
		public KYIZFIBDUYR([In] SyncData data, a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x687FE60", Offset = "0x687E860", VA = "0x18687FE60")]
		private void HFPUNXLANYG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6883AE0", Offset = "0x68824E0", VA = "0x186883AE0", Slot = "5")]
		public void XSKSCIBWCMZ(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6883EF0", Offset = "0x68828F0", VA = "0x186883EF0")]
		public void XSKSCIBWCMZ(a a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x68743E0", Offset = "0x6872DE0", VA = "0x1868743E0", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0xFA46A0", Offset = "0xFA30A0", VA = "0x180FA46A0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool DYDPMZUXIXY
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x6874F10", Offset = "0x6873910", VA = "0x186874F10", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool CSGBEEJSMXP
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x6877340", Offset = "0x6875D40", VA = "0x186877340")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool CRQGMKCAKPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x6876E20", Offset = "0x6875820", VA = "0x186876E20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public (a, b) RGWETDIXIUV
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x6873750", Offset = "0x6872150", VA = "0x186873750", Slot = "11")]
			get
			{
				return default((a, b));
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x6876660", Offset = "0x6875060", VA = "0x186876660", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public (a, b) GXDNQKLGWZS
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x6873F90", Offset = "0x6872990", VA = "0x186873F90", Slot = "4")]
			get
			{
				return default((a, b));
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x6875770", Offset = "0x6874170", VA = "0x186875770", Slot = "13")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public (a, b) PGGBLURLEPI
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x6875970", Offset = "0x6874370", VA = "0x186875970")]
			get
			{
				return default((a, b));
			}
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x6876990", Offset = "0x6875390", VA = "0x186876990")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public a OHSLLYIJRJW
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x6874550", Offset = "0x6872F50", VA = "0x186874550")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x6878340", Offset = "0x6876D40", VA = "0x186878340")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public a MHOAZBXTNRJ
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x6873BA0", Offset = "0x68725A0", VA = "0x186873BA0")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x6877560", Offset = "0x6875F60", VA = "0x186877560")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public a BRBVLPJSAAV
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x6873BA0", Offset = "0x68725A0", VA = "0x186873BA0")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x6872CF0", Offset = "0x68716F0", VA = "0x186872CF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public b OIIGDSQBTRX
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x6874500", Offset = "0x6872F00", VA = "0x186874500")]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x6878030", Offset = "0x6876A30", VA = "0x186878030")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public b MHTHWIRQXCS
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x6873D60", Offset = "0x6872760", VA = "0x186873D60")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public b BQMATVBZXSU
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x6873D60", Offset = "0x6872760", VA = "0x186873D60")]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x6873150", Offset = "0x6871B50", VA = "0x186873150")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public bool IPCJQPKHCXU
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x6879120", Offset = "0x6877B20", VA = "0x186879120", Slot = "7")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x6877710", Offset = "0x6876110", VA = "0x186877710", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6877900", Offset = "0x6876300", VA = "0x186877900", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6879B40", Offset = "0x6878540", VA = "0x186879B40")]
		public KXTENNTLSQQ([In] SyncData data, a a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6874B70", Offset = "0x6873570", VA = "0x186874B70")]
		private void HFPUNXLANYG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x68788E0", Offset = "0x68772E0", VA = "0x1868788E0")]
		public void VAGJAGZKTUG(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x6879190", Offset = "0x6877B90", VA = "0x186879190")]
		public void XSKSCIBWCMZ(a a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x6878D90", Offset = "0x6877790", VA = "0x186878D90", Slot = "5")]
		private void VQQLLBKWFOK((a, b) a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x68743E0", Offset = "0x6872DE0", VA = "0x1868743E0", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0xFA46A0", Offset = "0xFA30A0", VA = "0x180FA46A0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public bool DYDPMZUXIXY
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x687C1F0", Offset = "0x687ABF0", VA = "0x18687C1F0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool CSGBEEJSMXP
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x687DAB0", Offset = "0x687C4B0", VA = "0x18687DAB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public bool CRQGMKCAKPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x687D8F0", Offset = "0x687C2F0", VA = "0x18687D8F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public bool CRVNJQVXUAX
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x687D810", Offset = "0x687C210", VA = "0x18687D810")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public (a, b, c) RGWETDIXIUV
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x687AB10", Offset = "0x6879510", VA = "0x18687AB10", Slot = "11")]
			get
			{
				return default((a, b, c));
			}
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x687D3C0", Offset = "0x687BDC0", VA = "0x18687D3C0", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public (a, b, c) GXDNQKLGWZS
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x687B980", Offset = "0x687A380", VA = "0x18687B980", Slot = "4")]
			get
			{
				return default((a, b, c));
			}
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x687C4F0", Offset = "0x687AEF0", VA = "0x18687C4F0", Slot = "13")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public a OHSLLYIJRJW
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x687BD20", Offset = "0x687A720", VA = "0x18687BD20")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x687E5B0", Offset = "0x687CFB0", VA = "0x18687E5B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public a MHOAZBXTNRJ
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x687B3A0", Offset = "0x6879DA0", VA = "0x18687B3A0")]
			get
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public a BRBVLPJSAAV
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x687B3A0", Offset = "0x6879DA0", VA = "0x18687B3A0")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x687A650", Offset = "0x6879050", VA = "0x18687A650")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public b OIIGDSQBTRX
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x687BC10", Offset = "0x687A610", VA = "0x18687BC10")]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x687DE30", Offset = "0x687C830", VA = "0x18687DE30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public b MHTHWIRQXCS
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x687B560", Offset = "0x6879F60", VA = "0x18687B560")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public b BQMATVBZXSU
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x687B560", Offset = "0x6879F60", VA = "0x18687B560")]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x687AA70", Offset = "0x6879470", VA = "0x18687AA70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public c OICZGLWEKGO
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x687BCF0", Offset = "0x687A6F0", VA = "0x18687BCF0")]
			get
			{
				return (c)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x687E090", Offset = "0x687CA90", VA = "0x18687E090")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public c MHYOTPLOGOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x687B480", Offset = "0x6879E80", VA = "0x18687B480")]
			get
			{
				return (c)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public c BQRHRBVXHED
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x687B480", Offset = "0x6879E80", VA = "0x18687B480")]
			get
			{
				return (c)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x687A860", Offset = "0x6879260", VA = "0x18687A860")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool IPCJQPKHCXU
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x6879120", Offset = "0x6877B20", VA = "0x186879120", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x687DCF0", Offset = "0x687C6F0", VA = "0x18687DCF0", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x687F620", Offset = "0x687E020", VA = "0x18687F620")]
		public KXYLKUNJCBZ([In] SyncData data, a a, b b, c c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x687C100", Offset = "0x687AB00", VA = "0x18687C100")]
		private void HFPUNXLANYG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x687EA00", Offset = "0x687D400", VA = "0x18687EA00")]
		public void VAGJAGZKTUG(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x687E700", Offset = "0x687D100", VA = "0x18687E700")]
		public void TLHKGADZRKR(b a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x687C8B0", Offset = "0x687B2B0", VA = "0x18687C8B0")]
		public void KJCMSPHGLSA(c a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x687F040", Offset = "0x687DA40", VA = "0x18687F040")]
		public void XSKSCIBWCMZ(a a, b b, c c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x687B030", Offset = "0x6879A30", VA = "0x18687B030", Slot = "5")]
		private void CNHXBFFQVLN((a, b, c) a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x68743E0", Offset = "0x6872DE0", VA = "0x1868743E0", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0xFA46A0", Offset = "0xFA30A0", VA = "0x180FA46A0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public (a, b, c, d) GXDNQKLGWZS
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x6886410", Offset = "0x6884E10", VA = "0x186886410", Slot = "4")]
			get
			{
				return default((a, b, c, d));
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x6887090", Offset = "0x6885A90", VA = "0x186887090", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public b MHTHWIRQXCS
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x6886250", Offset = "0x6884C50", VA = "0x186886250")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public c MHYOTPLOGOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x6886220", Offset = "0x6884C20", VA = "0x186886220")]
			get
			{
				return (c)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public d MGNSMUCGSMQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x68863E0", Offset = "0x6884DE0", VA = "0x1868863E0")]
			get
			{
				return (d)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool IPCJQPKHCXU
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x6879120", Offset = "0x6877B20", VA = "0x186879120", Slot = "7")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x6877710", Offset = "0x6876110", VA = "0x186877710", Slot = "10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6888270", Offset = "0x6886C70", VA = "0x186888270")]
		public KYYTXCIVXGS([In] SyncData data, a a, b b, c c, d d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6886910", Offset = "0x6885310", VA = "0x186886910")]
		private void HFPUNXLANYG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x68874C0", Offset = "0x6885EC0", VA = "0x1868874C0")]
		public void VAGJAGZKTUG(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6887870", Offset = "0x6886270", VA = "0x186887870")]
		public void XSKSCIBWCMZ(a a, b b, c c, d d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x68870E0", Offset = "0x6885AE0", VA = "0x1868870E0", Slot = "5")]
		private void PVFKXRSYNBN((a, b, c, d) a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x68743E0", Offset = "0x6872DE0", VA = "0x1868743E0", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x9AFFB50", Offset = "0x9AFE550", VA = "0x189AFFB50")]
		public static string FSIGNWOSSAD(this SyncData a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xD7B500", Offset = "0xD79F00", VA = "0x180D7B500")]
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
		[Cpp2IlInjected.Address(RVA = "0x5B99710", Offset = "0x5B98110", VA = "0x185B99710")]
		public ELQQKJFLRGW([In] SyncData data, a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x5B9A150", Offset = "0x5B98B50", VA = "0x185B9A150")]
		public ELQQKJFLRGW(SABLHYKIBLD a, GUPOFWBVNMS b, string c, a d, NetworkSetterPermissionMode e, [Optional] Action f, [Optional] BPOYGHLAACR g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x5B974C0", Offset = "0x5B95EC0", VA = "0x185B974C0")]
		public ELQQKJFLRGW(SABLHYKIBLD a, string b, a c, NetworkSetterPermissionMode d, [Optional] Action e, [Optional] BPOYGHLAACR f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x5B9A940", Offset = "0x5B99340", VA = "0x185B9A940")]
		public ELQQKJFLRGW(SABLHYKIBLD a, string b, a c, NetworkSetterPermissionMode d, bool e, [Optional] Action f, [Optional] BPOYGHLAACR g)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class ELLJNCLOHVN<a, b> : HASQHOUXEZI<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x5B94770", Offset = "0x5B93170", VA = "0x185B94770")]
		public ELLJNCLOHVN([In] SyncData data, a a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x5B91E40", Offset = "0x5B90840", VA = "0x185B91E40")]
		public ELLJNCLOHVN(SABLHYKIBLD a, GUPOFWBVNMS b, string c, a d, b e, NetworkSetterPermissionMode f, [Optional] Action g, [Optional] BPOYGHLAACR h)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x5B93EA0", Offset = "0x5B928A0", VA = "0x185B93EA0")]
		public ELLJNCLOHVN(SABLHYKIBLD a, string b, a c, b d, NetworkSetterPermissionMode e, [Optional] Action f, [Optional] BPOYGHLAACR g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x5B93C90", Offset = "0x5B92690", VA = "0x185B93C90")]
		public ELLJNCLOHVN(SABLHYKIBLD a, string b, a c, b d, NetworkSetterPermissionMode e, bool f, [Optional] Action g, [Optional] BPOYGHLAACR h)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class ELGCPVRQYKE<a, b, c> : HAXXEVOUOKR<a, b, c>
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x5B89BB0", Offset = "0x5B885B0", VA = "0x185B89BB0")]
		public ELGCPVRQYKE([In] SyncData data, a a, b b, c c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x5B89D70", Offset = "0x5B88770", VA = "0x185B89D70")]
		public ELGCPVRQYKE(SABLHYKIBLD a, string b, a c, b d, c e, NetworkSetterPermissionMode f, [Optional] Action g, [Optional] BPOYGHLAACR h)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class EMQYWRAYMLP<a, b, c, d> : GZNAYAFNAJG<a, b, c, d>
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x5B9D2C0", Offset = "0x5B9BCC0", VA = "0x185B9D2C0")]
		public EMQYWRAYMLP([In] SyncData data, a a, b b, c c, d d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x5B9CF60", Offset = "0x5B9B960", VA = "0x185B9CF60")]
		public EMQYWRAYMLP(SABLHYKIBLD a, GUPOFWBVNMS b, string c, a d, b e, c f, d g, NetworkSetterPermissionMode h, [Optional] Action i, [Optional] BPOYGHLAACR j)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x5B9CC30", Offset = "0x5B9B630", VA = "0x185B9CC30")]
		public EMQYWRAYMLP(SABLHYKIBLD a, string b, a c, b d, c e, d f, NetworkSetterPermissionMode g, [Optional] Action h, [Optional] BPOYGHLAACR i)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class EMLRZKHBDAG<a, b, c, d, e> : GZSHVGZKJUP<a, b, c, d, e>
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x5B9BFC0", Offset = "0x5B9A9C0", VA = "0x185B9BFC0")]
		public EMLRZKHBDAG(SABLHYKIBLD a, GUPOFWBVNMS b, string c, a d, b e, c f, d g, e h, NetworkSetterPermissionMode i, [Optional] Action j, [Optional] BPOYGHLAACR k)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x5B9B810", Offset = "0x5B9A210", VA = "0x185B9B810")]
		public EMLRZKHBDAG(SABLHYKIBLD a, string b, a c, b d, c e, d f, e g, NetworkSetterPermissionMode h, [Optional] Action i, [Optional] BPOYGHLAACR j)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class FLDXNDYBBNX<a> : HANJKIAZVNZ<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x635E2E0", Offset = "0x635CCE0", VA = "0x18635E2E0")]
		public FLDXNDYBBNX(GUPOFWBVNMS a, string b, a c, [Optional] Action d, [Optional] BPOYGHLAACR e)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class FKOCVJQIZFW<a, b> : HASQHOUXEZI<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x635DBF0", Offset = "0x635C5F0", VA = "0x18635DBF0")]
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
		[Cpp2IlInjected.Address(RVA = "0xD13C40", Offset = "0xD12640", VA = "0x180D13C40")]
		public PLBZQKDNIKQ(BPOYGHLAACR a, SABLHYKIBLD b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x3DC8270", Offset = "0x3DC6C70", VA = "0x183DC8270", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x9B02600", Offset = "0x9B01000", VA = "0x189B02600")]
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
		[Cpp2IlInjected.Address(RVA = "0x9AFFBE0", Offset = "0x9AFE5E0", VA = "0x189AFFBE0")]
		public SyncData(SyncData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x9AFFC60", Offset = "0x9AFE660", VA = "0x189AFFC60")]
		public SyncData(SABLHYKIBLD context, string key, NetworkSetterPermissionMode permissionMode, [Optional] Action callback, [Optional] BPOYGHLAACR networkBacking)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x9AFFB90", Offset = "0x9AFE590", VA = "0x189AFFB90")]
		public static SyncData From(SABLHYKIBLD context, string key, NetworkSetterPermissionMode permissionMode, [Optional] Action callback, [Optional] BPOYGHLAACR networkBacking)
		{
			return default(SyncData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public static class CYWODZONAWA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x3878B60", Offset = "0x3877560", VA = "0x183878B60")]
		public static ELQQKJFLRGW<a> DSZGRWEPSDL<a>(this SyncData a, a b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x3877A60", Offset = "0x3876460", VA = "0x183877A60")]
		public static ELLJNCLOHVN<b, c> DSZGRWEPSDL<b, c>(this SyncData a, b b, c c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x3877B00", Offset = "0x3876500", VA = "0x183877B00")]
		public static ELGCPVRQYKE<d, e, f> DSZGRWEPSDL<d, e, f>(this SyncData a, d b, e c, f d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x3878610", Offset = "0x3877010", VA = "0x183878610")]
		public static EMQYWRAYMLP<g, h, i, j> DSZGRWEPSDL<g, h, i, j>(this SyncData a, g b, h c, i d, j e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x3878DE0", Offset = "0x38777E0", VA = "0x183878DE0")]
		public static KYIZFIBDUYR<k> VGOLVWUTBPE<k>(this SyncData a, k b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x3878C90", Offset = "0x3877690", VA = "0x183878C90")]
		public static KXTENNTLSQQ<l, m> VGOLVWUTBPE<l, m>(this SyncData a, l b, m c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x3878D30", Offset = "0x3877730", VA = "0x183878D30")]
		public static KXYLKUNJCBZ<n, o, p> VGOLVWUTBPE<n, o, p>(this SyncData a, n b, o c, p d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x38790B0", Offset = "0x3877AB0", VA = "0x1838790B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x9AFE2E0", Offset = "0x9AFCCE0", VA = "0x189AFE2E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		private bool RAXOSSGVOEZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x9AFE590", Offset = "0x9AFCF90", VA = "0x189AFE590")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x9AFF600", Offset = "0x9AFE000", VA = "0x189AFF600")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		private bool KHNQLVWNRYM
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x9AFE2D0", Offset = "0x9AFCCD0", VA = "0x189AFE2D0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x9AFE5F0", Offset = "0x9AFCFF0", VA = "0x189AFE5F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		private bool JVCWZVKKNSR
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x9AFF620", Offset = "0x9AFE020", VA = "0x189AFF620")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x9AFF300", Offset = "0x9AFDD00", VA = "0x189AFF300")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public bool IPCJQPKHCXU
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x9AFF5F0", Offset = "0x9AFDFF0", VA = "0x189AFF5F0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x9AFF170", Offset = "0x9AFDB70", VA = "0x189AFF170")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		protected virtual object ZSUBFNTLSZS
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0xD122E0", Offset = "0xD10CE0", VA = "0x180D122E0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0xD12290", Offset = "0xD10C90", VA = "0x180D12290", Slot = "8")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public bool PTHEWMYULDZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x9AFE5A0", Offset = "0x9AFCFA0", VA = "0x189AFE5A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public int LJRZZRLLQVC
		{
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0xF01E60", Offset = "0xF00860", VA = "0x180F01E60")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x1ADB800", Offset = "0x1ADA200", VA = "0x181ADB800")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public string XVKQGRWDPTO
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0xD12BC0", Offset = "0xD115C0", VA = "0x180D12BC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public bool OKAKVETJBLG
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x9AFE7E0", Offset = "0x9AFD1E0", VA = "0x189AFE7E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x9AFF0D0", Offset = "0x9AFDAD0", VA = "0x189AFF0D0")]
		public static void RVYOWFLRGNW(BPOYGHLAACR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(Slot = "9")]
		protected abstract bool BTXDAICSWIK();

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x9AFF930", Offset = "0x9AFE330", VA = "0x189AFF930")]
		protected DSZGRWEPSDL(GUPOFWBVNMS a, SABLHYKIBLD b, string c, NetworkSetterPermissionMode d, Action e, BPOYGHLAACR f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x9AFE4D0", Offset = "0x9AFCED0", VA = "0x189AFE4D0", Slot = "1")]
		~DSZGRWEPSDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x9AFE350", Offset = "0x9AFCD50", VA = "0x189AFE350", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x9AFEA00", Offset = "0x9AFD400", VA = "0x189AFEA00")]
		private void NDJNXVTLYDK(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x9AFF340", Offset = "0x9AFDD40", VA = "0x189AFF340")]
		private object WAOJVQXJEXC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x9AFE610", Offset = "0x9AFD010", VA = "0x189AFE610")]
		protected void Initialize(bool enforceInitialValue, object initialValue, bool initialValueIsDefaultValue = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x9AFF230", Offset = "0x9AFDC30", VA = "0x189AFF230")]
		protected void Set(object newValue, bool checkPermission = true, bool suppressCallback = false, bool requireModified = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x9AFF640", Offset = "0x9AFE040", VA = "0x189AFF640")]
		protected void ZROXUQOGEDL(object a, bool b, bool c, bool d = false, bool e = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x9AFE830", Offset = "0x9AFD230", VA = "0x189AFE830")]
		internal void LOMLKNASVXH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x9AFE530", Offset = "0x9AFCF30", VA = "0x189AFE530")]
		private void GRJZTQFJWGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x9AFE270", Offset = "0x9AFCC70", VA = "0x189AFE270")]
		private void BCBPNBWJVBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x9AFECB0", Offset = "0x9AFD6B0", VA = "0x189AFECB0", Slot = "4")]
		private void PUHIKKOKYLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x9AFF630", Offset = "0x9AFE030", VA = "0x189AFF630", Slot = "5")]
		private void ZOTOSRAZQYZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x9AFF4B0", Offset = "0x9AFDEB0", VA = "0x189AFF4B0")]
		public bool WLQFTMAVUSD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x9AFED20", Offset = "0x9AFD720", VA = "0x189AFED20")]
		public bool QJWKKTVCBKH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x9AFE8B0", Offset = "0x9AFD2B0", VA = "0x189AFE8B0")]
		private bool LUHNZVVJERO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x9AFEAA0", Offset = "0x9AFD4A0", VA = "0x189AFEAA0")]
		internal void ORSVODJMVGV(object a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x9AFEEE0", Offset = "0x9AFD8E0", VA = "0x189AFEEE0")]
		private void QNDAIZVEWZR(object a, bool b, bool c = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x9AFE4C0", Offset = "0x9AFCEC0", VA = "0x189AFE4C0")]
		private bool FWQQFIPPCXP(Flags a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x9AFF320", Offset = "0x9AFDD20", VA = "0x189AFF320")]
		private void VWUHQOMIPND(Flags a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x9AFF270", Offset = "0x9AFDC70", VA = "0x189AFF270")]
		public static string TKBAEZZJGAX(GUPOFWBVNMS a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x9AFEFF0", Offset = "0x9AFD9F0", VA = "0x189AFEFF0")]
		public static string RHANOHRBCFZ(SABLHYKIBLD a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x9AFEB50", Offset = "0x9AFD550", VA = "0x189AFEB50")]
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
			[Cpp2IlInjected.Address(RVA = "0xD2AB70", Offset = "0xD29570", VA = "0x180D2AB70", Slot = "28")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public bool AJRBHITXSUS
		{
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0xD6E8A0", Offset = "0xD6D2A0", VA = "0x180D6E8A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x40E12E0", Offset = "0x40DFCE0", VA = "0x1840E12E0", Slot = "12")]
		public void IGSETKBNSSY<a>(string a, a b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x9B006D0", Offset = "0x9AFF0D0", VA = "0x189B006D0", Slot = "11")]
		public void FAREEZKNLRB(GUPOFWBVNMS a, string b, object c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x9AFFEF0", Offset = "0x9AFE8F0", VA = "0x189AFFEF0", Slot = "9")]
		public object BTMOXRDNACH(GUPOFWBVNMS a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x9B005A0", Offset = "0x9AFEFA0", VA = "0x189B005A0", Slot = "10")]
		public void EMLXLKOEQPT(string a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x9B019C0", Offset = "0x9B003C0", VA = "0x189B019C0", Slot = "8")]
		public object QGSQJJFURNP(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x9B01C80", Offset = "0x9B00680", VA = "0x189B01C80", Slot = "13")]
		public void SOWSMCAKDVQ(GUPOFWBVNMS a, string b, DSZGRWEPSDL c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x9B013C0", Offset = "0x9AFFDC0", VA = "0x189B013C0", Slot = "14")]
		public void NCAXLBLKKJJ(GUPOFWBVNMS a, string b, DSZGRWEPSDL c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x9B009D0", Offset = "0x9AFF3D0", VA = "0x189B009D0")]
		private void HRIKOHWHUHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x9B012E0", Offset = "0x9AFFCE0", VA = "0x189B012E0")]
		private void LOIEEEIYEFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x9B02140", Offset = "0x9B00B40", VA = "0x189B02140")]
		private void YFLOMAXBNLS(GUPOFWBVNMS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x9B011C0", Offset = "0x9AFFBC0", VA = "0x189B011C0")]
		protected void LGGFBZJUNXA(GUPOFWBVNMS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x9AFFE00", Offset = "0x9AFE800", VA = "0x189AFFE00")]
		protected void AJMCQFZIWBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x9B006C0", Offset = "0x9AFF0C0", VA = "0x189B006C0")]
		protected void FAPAGXWVKSC(IDictionary<object, object> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x9B021A0", Offset = "0x9B00BA0", VA = "0x189B021A0")]
		protected void YZCYDVKAEEC(GUPOFWBVNMS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x9B01330", Offset = "0x9AFFD30", VA = "0x189B01330")]
		protected void MBBDXBVXVIQ(GUPOFWBVNMS a, IDictionary<object, object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x9B00A20", Offset = "0x9AFF420", VA = "0x189B00A20")]
		private void INIFEVMHDMP(IDictionary<object, object> a, Dictionary<string, object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x9B02210", Offset = "0x9B00C10", VA = "0x189B02210")]
		private static void ZWIYCFKOIQD(object a, object b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x9B01A60", Offset = "0x9B00460", VA = "0x189B01A60")]
		private static void SCEKKFAOCKO(Dictionary<string, object> a, string b, DSZGRWEPSDL c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x9AFFFF0", Offset = "0x9AFE9F0", VA = "0x189AFFFF0")]
		private static void BXAVWEKFACN(Dictionary<string, object> a, string b, DSZGRWEPSDL c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x9B01E20", Offset = "0x9B00820", VA = "0x189B01E20", Slot = "19")]
		public void UDJLVKSOGSV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(Slot = "29")]
		protected abstract void HMKMHWYISKI(Dictionary<object, object> a);

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x9B00820", Offset = "0x9AFF220", VA = "0x189B00820", Slot = "20")]
		public void FLLBNEEMPDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "30")]
		protected abstract void ANEJCGAGOYK(Dictionary<object, object> a);

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x9B01F20", Offset = "0x9B00920", VA = "0x189B01F20")]
		private void UMYPMKFZSJD(Dictionary<object, object> a, List<string> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x9B00EA0", Offset = "0x9AFF8A0", VA = "0x189B00EA0")]
		private void IXSJBMCTNBS(IDictionary<object, object> a, [Out] int b, [Out] string[] c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x9B01130", Offset = "0x9AFFB30", VA = "0x189B01130")]
		public void JJNZUVNQKOT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x9B00900", Offset = "0x9AFF300", VA = "0x189B00900")]
		public void FUNYKAKKQIT(GUPOFWBVNMS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x9B01660", Offset = "0x9B00060", VA = "0x189B01660")]
		public void PXPVUQITXQI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "31")]
		protected abstract HashSet<int> LBDMWLLMDAI(bool a, bool b);

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x9B001C0", Offset = "0x9AFEBC0", VA = "0x189B001C0", Slot = "21")]
		public void DQHEOFUNLEC(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x9B01D90", Offset = "0x9B00790", VA = "0x189B01D90")]
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
		[Cpp2IlInjected.Address(RVA = "0xD10150", Offset = "0xD0EB50", VA = "0x180D10150", Slot = "36")]
		public virtual void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x9B00440", Offset = "0x9AFEE40", VA = "0x189B00440", Slot = "22")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0xD10150", Offset = "0xD0EB50", VA = "0x180D10150", Slot = "37")]
		protected virtual void XTLFXBYXWKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x9B02410", Offset = "0x9B00E10", VA = "0x189B02410")]
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
			[Cpp2IlInjected.Address(RVA = "0x6506BC0", Offset = "0x65055C0", VA = "0x186506BC0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x6505960", Offset = "0x6504360", VA = "0x186505960", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		protected override object ZSUBFNTLSZS
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x645AD60", Offset = "0x6459760", VA = "0x18645AD60", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x6506980", Offset = "0x6505380", VA = "0x186506980", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x65046D0", Offset = "0x65030D0", VA = "0x1865046D0", Slot = "9")]
		protected override bool BTXDAICSWIK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x650D690", Offset = "0x650C090", VA = "0x18650D690")]
		protected HANJKIAZVNZ([In] SyncData data, a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x650DD40", Offset = "0x650C740", VA = "0x18650DD40")]
		protected HANJKIAZVNZ(GUPOFWBVNMS a, SABLHYKIBLD b, string c, a d, NetworkSetterPermissionMode e, bool f, Action g, BPOYGHLAACR h)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x5376C90", Offset = "0x5375690", VA = "0x185376C90")]
		public a Get()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x650B050", Offset = "0x6509A50", VA = "0x18650B050")]
		public void Set(a newValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x6508200", Offset = "0x6506C00", VA = "0x186508200")]
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
			[Cpp2IlInjected.Address(RVA = "0x1107E30", Offset = "0x1106830", VA = "0x181107E30", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x12EF120", Offset = "0x12EDB20", VA = "0x1812EF120", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		protected virtual b QFJHJTSZEFO
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x32B8570", Offset = "0x32B6F70", VA = "0x1832B8570", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x650F9E0", Offset = "0x650E3E0", VA = "0x18650F9E0", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public b GGQLDJOFBTO
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x174EBC0", Offset = "0x174D5C0", VA = "0x18174EBC0")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		protected override object ZSUBFNTLSZS
		{
			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x645AD60", Offset = "0x6459760", VA = "0x18645AD60", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x650FA20", Offset = "0x650E420", VA = "0x18650FA20", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x650F6D0", Offset = "0x650E0D0", VA = "0x18650F6D0", Slot = "9")]
		protected override bool BTXDAICSWIK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x6512B10", Offset = "0x6511510", VA = "0x186512B10")]
		protected HASQHOUXEZI([In] SyncData data, a a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x6511D60", Offset = "0x6510760", VA = "0x186511D60")]
		protected HASQHOUXEZI(GUPOFWBVNMS a, SABLHYKIBLD b, string c, a d, b e, NetworkSetterPermissionMode f, bool g, Action h, BPOYGHLAACR i)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x5376C90", Offset = "0x5375690", VA = "0x185376C90")]
		public a EVBINGRLEAG()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x65107B0", Offset = "0x650F1B0", VA = "0x1865107B0")]
		public void SDAPFWWDJHI(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x174EBC0", Offset = "0x174D5C0", VA = "0x18174EBC0")]
		public b EUWBPZXNUOX()
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x65104C0", Offset = "0x650EEC0", VA = "0x1865104C0")]
		public void SCVIIQCFZVZ(b a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x65119C0", Offset = "0x65103C0", VA = "0x1865119C0")]
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
			[Cpp2IlInjected.Address(RVA = "0xD21E10", Offset = "0xD20810", VA = "0x180D21E10", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0xD21D60", Offset = "0xD20760", VA = "0x180D21D60", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		protected virtual b QFJHJTSZEFO
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0xEF2E30", Offset = "0xEF1830", VA = "0x180EF2E30", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x2AE5000", Offset = "0x2AE3A00", VA = "0x182AE5000", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		protected virtual c QFOOHAMWNQX
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0xD11B60", Offset = "0xD10560", VA = "0x180D11B60", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return (c)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0xD11AE0", Offset = "0xD104E0", VA = "0x180D11AE0", Slot = "15")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public a GHGFVDVXEBP
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x5376C90", Offset = "0x5375690", VA = "0x185376C90")]
			get
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public b GGQLDJOFBTO
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x174EBC0", Offset = "0x174D5C0", VA = "0x18174EBC0")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public c GGVSAQICLEX
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x645E5E0", Offset = "0x645CFE0", VA = "0x18645E5E0")]
			get
			{
				return (c)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		protected override object ZSUBFNTLSZS
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x645AD60", Offset = "0x6459760", VA = "0x18645AD60", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x651F3C0", Offset = "0x651DDC0", VA = "0x18651F3C0", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x651DC10", Offset = "0x651C610", VA = "0x18651DC10", Slot = "9")]
		protected override bool BTXDAICSWIK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x6526DD0", Offset = "0x65257D0", VA = "0x186526DD0")]
		protected HAXXEVOUOKR([In] SyncData data, a a, b b, c c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x6524D00", Offset = "0x6523700", VA = "0x186524D00")]
		protected HAXXEVOUOKR(GUPOFWBVNMS a, SABLHYKIBLD b, string c, a d, b e, c f, NetworkSetterPermissionMode g, bool h, Action i, BPOYGHLAACR j)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x5376C90", Offset = "0x5375690", VA = "0x185376C90")]
		public a EVBINGRLEAG()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x6521A30", Offset = "0x6520430", VA = "0x186521A30")]
		public void SDAPFWWDJHI(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x174EBC0", Offset = "0x174D5C0", VA = "0x18174EBC0")]
		public b EUWBPZXNUOX()
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x6520860", Offset = "0x651F260", VA = "0x186520860")]
		public void SCVIIQCFZVZ(b a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x645E5E0", Offset = "0x645CFE0", VA = "0x18645E5E0")]
		public c EUQUSTDQLDO()
		{
			return (c)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x6520180", Offset = "0x651EB80", VA = "0x186520180")]
		public void SCQBLJIIQKQ(c a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x6521B50", Offset = "0x6520550", VA = "0x186521B50")]
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
			[Cpp2IlInjected.Address(RVA = "0xF91C80", Offset = "0xF90680", VA = "0x180F91C80", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x645AD50", Offset = "0x6459750", VA = "0x18645AD50", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		protected virtual b QFJHJTSZEFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x14B11F0", Offset = "0x14AFBF0", VA = "0x1814B11F0", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x14AD4A0", Offset = "0x14ABEA0", VA = "0x1814AD4A0", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		protected virtual c QFOOHAMWNQX
		{
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x154CB00", Offset = "0x154B500", VA = "0x18154CB00", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return (c)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x645AD10", Offset = "0x6459710", VA = "0x18645AD10", Slot = "15")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		protected virtual d QGOWTIIJIVQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x1D76460", Offset = "0x1D74E60", VA = "0x181D76460", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return (d)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x16AF4C0", Offset = "0x16ADEC0", VA = "0x1816AF4C0", Slot = "17")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public b GGQLDJOFBTO
		{
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x645AC60", Offset = "0x6459660", VA = "0x18645AC60")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public c GGVSAQICLEX
		{
			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0x645ABE0", Offset = "0x64595E0", VA = "0x18645ABE0")]
			get
			{
				return (c)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public d GHWAMYDPGJQ
		{
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x15F3C40", Offset = "0x15F2640", VA = "0x1815F3C40")]
			get
			{
				return (d)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		protected override object ZSUBFNTLSZS
		{
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0x645AD60", Offset = "0x6459760", VA = "0x18645AD60", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0x645B1F0", Offset = "0x6459BF0", VA = "0x18645B1F0", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x645A910", Offset = "0x6459310", VA = "0x18645A910", Slot = "9")]
		protected override bool BTXDAICSWIK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x645CC80", Offset = "0x645B680", VA = "0x18645CC80")]
		protected GZNAYAFNAJG([In] SyncData data, a a, b b, c c, d d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x645C930", Offset = "0x645B330", VA = "0x18645C930")]
		protected GZNAYAFNAJG(GUPOFWBVNMS a, SABLHYKIBLD b, string c, a d, b e, c f, d g, NetworkSetterPermissionMode h, bool i, Action j, BPOYGHLAACR k)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x5376C90", Offset = "0x5375690", VA = "0x185376C90")]
		public a EVBINGRLEAG()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x645BDE0", Offset = "0x645A7E0", VA = "0x18645BDE0")]
		public void SDAPFWWDJHI(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x645AC60", Offset = "0x6459660", VA = "0x18645AC60")]
		public b EUWBPZXNUOX()
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x645BBA0", Offset = "0x645A5A0", VA = "0x18645BBA0")]
		public void SCVIIQCFZVZ(b a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x645ABE0", Offset = "0x64595E0", VA = "0x18645ABE0")]
		public c EUQUSTDQLDO()
		{
			return (c)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x645B840", Offset = "0x645A240", VA = "0x18645B840")]
		public void SCQBLJIIQKQ(c a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x15F3C40", Offset = "0x15F2640", VA = "0x1815F3C40")]
		public d EWBQZOMXZEZ()
		{
			return (d)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x645B750", Offset = "0x645A150", VA = "0x18645B750")]
		public void SCKUOCOLGZH(d a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x645C440", Offset = "0x645AE40", VA = "0x18645C440")]
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
			[Cpp2IlInjected.Address(RVA = "0xD21E10", Offset = "0xD20810", VA = "0x180D21E10", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0xD21D60", Offset = "0xD20760", VA = "0x180D21D60", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		protected virtual b QFJHJTSZEFO
		{
			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0xE23D50", Offset = "0xE22750", VA = "0x180E23D50", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0x14C7410", Offset = "0x14C5E10", VA = "0x1814C7410", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		protected virtual c QFOOHAMWNQX
		{
			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0xE37650", Offset = "0xE36050", VA = "0x180E37650", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return (c)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0xE38100", Offset = "0xE36B00", VA = "0x180E38100", Slot = "15")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		protected virtual d QGOWTIIJIVQ
		{
			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(RVA = "0xD2AF40", Offset = "0xD29940", VA = "0x180D2AF40", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return (d)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0xD3B440", Offset = "0xD39E40", VA = "0x180D3B440", Slot = "17")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		protected virtual e QGUDQPCGSGZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0xD2AB80", Offset = "0xD29580", VA = "0x180D2AB80", Slot = "18")]
			[CompilerGenerated]
			get
			{
				return (e)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x645E8E0", Offset = "0x645D2E0", VA = "0x18645E8E0", Slot = "19")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		protected override object ZSUBFNTLSZS
		{
			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x645AD60", Offset = "0x6459760", VA = "0x18645AD60", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x6468540", Offset = "0x6466F40", VA = "0x186468540", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x6467350", Offset = "0x6465D50", VA = "0x186467350", Slot = "9")]
		protected override bool BTXDAICSWIK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x646F000", Offset = "0x646DA00", VA = "0x18646F000")]
		protected GZSHVGZKJUP(GUPOFWBVNMS a, SABLHYKIBLD b, string c, a d, b e, c f, d g, e h, NetworkSetterPermissionMode i, bool j, Action k, BPOYGHLAACR l)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x5376C90", Offset = "0x5375690", VA = "0x185376C90")]
		public a EVBINGRLEAG()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x646B910", Offset = "0x646A310", VA = "0x18646B910")]
		public void SDAPFWWDJHI(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x174EBC0", Offset = "0x174D5C0", VA = "0x18174EBC0")]
		public b EUWBPZXNUOX()
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x646B390", Offset = "0x6469D90", VA = "0x18646B390")]
		public void SCVIIQCFZVZ(b a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x645E5E0", Offset = "0x645CFE0", VA = "0x18645E5E0")]
		public c EUQUSTDQLDO()
		{
			return (c)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x646AB30", Offset = "0x6469530", VA = "0x18646AB30")]
		public void SCQBLJIIQKQ(c a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x15F3C40", Offset = "0x15F2640", VA = "0x1815F3C40")]
		public d EWBQZOMXZEZ()
		{
			return (d)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x646A470", Offset = "0x6468E70", VA = "0x18646A470")]
		public void SCKUOCOLGZH(d a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x6467ED0", Offset = "0x64668D0", VA = "0x186467ED0")]
		public e EVWKCHTAPTQ()
		{
			return (e)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x6469C00", Offset = "0x6468600", VA = "0x186469C00")]
		public void SCFNQVUNXNY(e a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x646CC30", Offset = "0x646B630", VA = "0x18646CC30")]
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
