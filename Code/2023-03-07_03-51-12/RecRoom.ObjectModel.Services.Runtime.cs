using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Mono.Math;
using RecRoom.ObjectModel.Service.Internal;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface CALFICILEMO<T>
{
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface HIJIFLANIAO
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MPBHMBLFPOG();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface NGENPNOGFON
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PBJBMEPEDIE(LODNGHNPONL KPGPMPPLGCI);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface CJFEEGPLPHA
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IHAPPEEILPC(LODNGHNPONL KPGPMPPLGCI);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface PJMBNFGPKOH
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PIKKIPBHELH(LODNGHNPONL KPGPMPPLGCI);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface HPLECDDPLCA : HIJIFLANIAO, NGENPNOGFON, CJFEEGPLPHA
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface DIACEKEHMCI
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	KGKNKCKDPOC OENHCKDAAJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FGMBIJAJIBC(LODNGHNPONL KPGPMPPLGCI);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface AAHLPGOALAE
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DNDHHJNBJKB(LODNGHNPONL KPGPMPPLGCI);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[DefaultMember("Item")]
[PHECHDJFGDG(FPOGPJMGMEG.Application)]
public interface NOEEIPFGABG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	LODNGHNPONL CLGONNHLFJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	FPOGPJMGMEG PIAACKBAPAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	LODNGHNPONL GAINDKPIJJC
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BKCAAEBNAMB(Type FPDPHGPGKGF, object OCGDPJBGCPH);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool PPNDICAMACE(Type FPDPHGPGKGF, global::OPNEPEIIDOI<object> GFCOCLEJPKI);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool PPNDICAMACE(Type FPDPHGPGKGF, global::OPNEPEIIDOI<object> GFCOCLEJPKI, FPOGPJMGMEG ODKOMDFLCPK);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void GJPFFEKIIEM();

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void IGBJLEMEJJK();
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class EJKILLJCHMB
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x2F20B90", Offset = "0x2F1FF90", VA = "0x182F20B90")]
	public static void PEBNPJONHNJ<T>(this NOEEIPFGABG KPGPMPPLGCI, out T OCGDPJBGCPH) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x2F20C10", Offset = "0x2F20010", VA = "0x182F20C10")]
	public static T PEBNPJONHNJ<T>(this NOEEIPFGABG KPGPMPPLGCI) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x64D7840", Offset = "0x64D6C40", VA = "0x1864D7840")]
	public static void GJPFFEKIIEM(this NOEEIPFGABG KPGPMPPLGCI, FPOGPJMGMEG ODKOMDFLCPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x64D7990", Offset = "0x64D6D90", VA = "0x1864D7990")]
	public static void IGBJLEMEJJK(this NOEEIPFGABG KPGPMPPLGCI, FPOGPJMGMEG ODKOMDFLCPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x64D7AE0", Offset = "0x64D6EE0", VA = "0x1864D7AE0")]
	public static void JEGNFLMBJLN(this NOEEIPFGABG KPGPMPPLGCI, FPOGPJMGMEG GCLECNJLDKB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface PMJCGFNIPBF
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KNEMJPBHGAN(Type BKGBGEHNCAE, out object OCGDPJBGCPH);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class JALHGOMAOKL
{
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface LODNGHNPONL : PMJCGFNIPBF
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	BHKHBEKDAPI CIFMMJJOMMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	KGKNKCKDPOC LBMLIBBHAFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	FPOGPJMGMEG PIAACKBAPAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "3")]
	object PEBNPJONHNJ(Type BKGBGEHNCAE);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class CBCMEIGMHIH
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x32A2970", Offset = "0x32A1D70", VA = "0x1832A2970")]
	public static bool KNEMJPBHGAN<T>(this LODNGHNPONL KPGPMPPLGCI, out T OCGDPJBGCPH) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x32A2B30", Offset = "0x32A1F30", VA = "0x1832A2B30")]
	public static T PEBNPJONHNJ<T>(this LODNGHNPONL KPGPMPPLGCI) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x32A2C80", Offset = "0x32A2080", VA = "0x1832A2C80")]
	public static void PEBNPJONHNJ<T>(this LODNGHNPONL KPGPMPPLGCI, out T OCGDPJBGCPH) where T : class
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[NAPHGBOEKGO(GPIMBHHJLKL.Services)]
	internal class LifetimeScopedServices
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static readonly BBHAOFNBCPD CDECIAPNKBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private readonly BHKHBEKDAPI CBOODPBIPLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly ServiceInitOrder BDAILPCIPEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private readonly OHOGNADNLBK OHMADKFPINL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly FPOGPJMGMEG ODKOMDFLCPK;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public KGKNKCKDPOC LBMLIBBHAFP
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x64D89F0", Offset = "0x64D7DF0", VA = "0x1864D89F0")]
			get
			{
				return default(KGKNKCKDPOC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public BHKHBEKDAPI CIFMMJJOMMN
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x705B90", Offset = "0x704F90", VA = "0x180705B90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x64D8D10", Offset = "0x64D8110", VA = "0x1864D8D10")]
		public LifetimeScopedServices(BHKHBEKDAPI CBOODPBIPLK, FPOGPJMGMEG ODKOMDFLCPK, LODNGHNPONL ONDFLKDCMGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x64D85D0", Offset = "0x64D79D0", VA = "0x1864D85D0")]
		public void BKCAAEBNAMB(Type BKGBGEHNCAE, object OCGDPJBGCPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x64D8970", Offset = "0x64D7D70", VA = "0x1864D8970")]
		public bool ICONIPJJEFC(Type BKGBGEHNCAE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x64D8A10", Offset = "0x64D7E10", VA = "0x1864D8A10")]
		public void NPFGFFCDMGH(PMJCGFNIPBF NBILJDMEMDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x64D87B0", Offset = "0x64D7BB0", VA = "0x1864D87B0")]
		public void DNDHHJNBJKB(LODNGHNPONL KDLEJHPKDEM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x64D88A0", Offset = "0x64D7CA0", VA = "0x1864D88A0")]
		public void HDEHBJFBHLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x64D8C50", Offset = "0x64D8050", VA = "0x1864D8C50", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x64D89A0", Offset = "0x64D7DA0", VA = "0x1864D89A0")]
		private static void IJMADPABGJJ(Type FPDPHGPGKGF, object OCGDPJBGCPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x64D8900", Offset = "0x64D7D00", VA = "0x1864D8900")]
		private void IBHMLDJIBIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x64D8B70", Offset = "0x64D7F70", VA = "0x1864D8B70")]
		private void OJLGGAMCJCB(Type BKGBGEHNCAE)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public delegate T OPNEPEIIDOI<out T>();
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[NAPHGBOEKGO(GPIMBHHJLKL.Services)]
	[DefaultMember("Item")]
	public class Services : NOEEIPFGABG, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		private class KDKKLPCJHNE : LODNGHNPONL, PMJCGFNIPBF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			private readonly Services KPGPMPPLGCI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			private readonly FPOGPJMGMEG ODKOMDFLCPK;

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			private LifetimeScopedServices ABEDOKHPDDA
			{
				[Cpp2IlInjected.Token(Token = "0x6000045")]
				[Cpp2IlInjected.Address(RVA = "0x64D83B0", Offset = "0x64D77B0", VA = "0x1864D83B0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public BHKHBEKDAPI CIFMMJJOMMN
			{
				[Cpp2IlInjected.Token(Token = "0x6000046")]
				[Cpp2IlInjected.Address(RVA = "0x64D82B0", Offset = "0x64D76B0", VA = "0x1864D82B0", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			public KGKNKCKDPOC LBMLIBBHAFP
			{
				[Cpp2IlInjected.Token(Token = "0x6000047")]
				[Cpp2IlInjected.Address(RVA = "0x64D8360", Offset = "0x64D7760", VA = "0x1864D8360", Slot = "5")]
				get
				{
					return default(KGKNKCKDPOC);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			public FPOGPJMGMEG PIAACKBAPAA
			{
				[Cpp2IlInjected.Token(Token = "0x6000048")]
				[Cpp2IlInjected.Address(RVA = "0x705BA0", Offset = "0x704FA0", VA = "0x180705BA0", Slot = "6")]
				get
				{
					return default(FPOGPJMGMEG);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x764570", Offset = "0x763970", VA = "0x180764570")]
			public KDKKLPCJHNE(Services KPGPMPPLGCI, FPOGPJMGMEG ODKOMDFLCPK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x64D8300", Offset = "0x64D7700", VA = "0x1864D8300", Slot = "8")]
			public bool KNEMJPBHGAN(Type BKGBGEHNCAE, out object OCGDPJBGCPH)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x64D83F0", Offset = "0x64D77F0", VA = "0x1864D83F0", Slot = "7")]
			public object PEBNPJONHNJ(Type BKGBGEHNCAE)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly BBHAOFNBCPD CDECIAPNKBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly LifetimeScopedServices[] EOLGPNLIODE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly KDKKLPCJHNE[] ONDFLKDCMGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private FPOGPJMGMEG ODKOMDFLCPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private bool GBMPCBCEGPH;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private LODNGHNPONL AKAAADMNADP
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x64DB800", Offset = "0x64DAC00", VA = "0x1864DB800", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public FPOGPJMGMEG PIAACKBAPAA
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x764360", Offset = "0x763760", VA = "0x180764360", Slot = "5")]
			get
			{
				return default(FPOGPJMGMEG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public LODNGHNPONL CLGONNHLFJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0xE8A940", Offset = "0xE89D40", VA = "0x180E8A940", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		private LifetimeScopedServices GAINDKPIJJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x12B95A0", Offset = "0x12B89A0", VA = "0x1812B95A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		private LifetimeScopedServices AGIICBLDODA
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x64DBD50", Offset = "0x64DB150", VA = "0x1864DBD50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x64DC2D0", Offset = "0x64DB6D0", VA = "0x1864DC2D0")]
		public static NOEEIPFGABG PELCFOCODBC([Optional] BHKHBEKDAPI CBOODPBIPLK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x64DBC60", Offset = "0x64DB060", VA = "0x1864DBC60")]
		public static NOEEIPFGABG KAAELOLDPLM(BHKHBEKDAPI CBOODPBIPLK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x64DC7B0", Offset = "0x64DBBB0", VA = "0x1864DC7B0")]
		private Services(BHKHBEKDAPI GJPMLLJBFIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x64DB890", Offset = "0x64DAC90", VA = "0x1864DB890", Slot = "7")]
		public void BKCAAEBNAMB(Type FPDPHGPGKGF, object OCGDPJBGCPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x64DB840", Offset = "0x64DAC40", VA = "0x1864DB840", Slot = "13")]
		public void BKCAAEBNAMB(Type FPDPHGPGKGF, object OCGDPJBGCPH, FPOGPJMGMEG ODKOMDFLCPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x64DC4F0", Offset = "0x64DB8F0", VA = "0x1864DC4F0", Slot = "8")]
		public bool PPNDICAMACE(Type FPDPHGPGKGF, global::OPNEPEIIDOI<object> GFCOCLEJPKI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x64DC640", Offset = "0x64DBA40", VA = "0x1864DC640", Slot = "9")]
		public bool PPNDICAMACE(Type FPDPHGPGKGF, global::OPNEPEIIDOI<object> GFCOCLEJPKI, FPOGPJMGMEG ODKOMDFLCPK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x64DBAF0", Offset = "0x64DAEF0", VA = "0x1864DBAF0", Slot = "10")]
		public void GJPFFEKIIEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x64DBBC0", Offset = "0x64DAFC0", VA = "0x1864DBBC0", Slot = "11")]
		public void IGBJLEMEJJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x64DB930", Offset = "0x64DAD30", VA = "0x1864DB930", Slot = "12")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x64DC060", Offset = "0x64DB460", VA = "0x1864DC060")]
		private void NDJMGJBGINH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x64DBA70", Offset = "0x64DAE70", VA = "0x1864DBA70")]
		private void FDIFNOGAKIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x64DBB20", Offset = "0x64DAF20", VA = "0x1864DBB20")]
		private bool ICONIPJJEFC(Type BKGBGEHNCAE, FPOGPJMGMEG ODKOMDFLCPK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x64DC230", Offset = "0x64DB630", VA = "0x1864DC230")]
		private bool PANDHLNBFIN(Type BKGBGEHNCAE, out FPOGPJMGMEG ODKOMDFLCPK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x64DC350", Offset = "0x64DB750", VA = "0x1864DC350")]
		private void PFMEMFDCDGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x64DBEA0", Offset = "0x64DB2A0", VA = "0x1864DBEA0")]
		private static LifetimeScopedServices[] MHHOFNBOFBF(BHKHBEKDAPI GJPMLLJBFIB, KDKKLPCJHNE[] FAHDFBCCHDD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x64DBD90", Offset = "0x64DB190", VA = "0x1864DBD90")]
		private KDKKLPCJHNE[] MCOGALGFNKN()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[Flags]
public enum KGKNKCKDPOC
{
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	InitInternal = 1,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	InitReferences = 2,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	InitExternal = 4,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	PostInit = 8,
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	Uninitialized = 0,
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	Initialized = 0x10,
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	ScopeChange = 0x20,
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	All = 0xF
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class HCBEPAPOGME
{
	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x64D7F10", Offset = "0x64D7310", VA = "0x1864D7F10")]
	public static Exception IDHCLELGHPE(Type FPDPHGPGKGF, FPOGPJMGMEG ODKOMDFLCPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x64D7FA0", Offset = "0x64D73A0", VA = "0x1864D7FA0")]
	public static Exception KKCKAGAICGK(Type FPDPHGPGKGF, FPOGPJMGMEG ODKOMDFLCPK, Type POOKOHMPBOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x64D8070", Offset = "0x64D7470", VA = "0x1864D8070")]
	public static Type OJBGCCNCMAP(int COOFAKHDCOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x64D8030", Offset = "0x64D7430", VA = "0x1864D8030")]
	private static string MGIPODALGHK(Type FPDPHGPGKGF, FPOGPJMGMEG ODKOMDFLCPK, Type POOKOHMPBOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x64D8030", Offset = "0x64D7430", VA = "0x1864D8030")]
	private static string LEDCHJDODFL(Type BKGBGEHNCAE)
	{
		return null;
	}
}
namespace RecRoom.ObjectModel.Service
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[NAPHGBOEKGO(GPIMBHHJLKL.Services)]
	public abstract class ServiceRegisterer : CDEIOGNPKKE
	{
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		public class HKELCFPLHIG : ServiceRegisterer
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x407ADA0", Offset = "0x407A1A0", VA = "0x18407ADA0", Slot = "8")]
			public override bool MHBAMOAJPNP<TBind, TInstance, TBind>(string[] MIHBJPNBFFD)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x64D81D0", Offset = "0x64D75D0", VA = "0x1864D81D0", Slot = "9")]
			public override bool MHBAMOAJPNP(Type FPDPHGPGKGF, Type POPCBFIHNJG, string[] MIHBJPNBFFD)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		public class GMNHKBHICHJ : ServiceRegisterer
		{
			[Cpp2IlInjected.Token(Token = "0x200001B")]
			[CompilerGenerated]
			private sealed class ANJEFCFFFFJ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400001B")]
				public Type instanceType;

				[Cpp2IlInjected.Token(Token = "0x6000061")]
				[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
				public ANJEFCFFFFJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000062")]
				[Cpp2IlInjected.Address(RVA = "0x64D7490", Offset = "0x64D6890", VA = "0x1864D7490")]
				internal object <Register>b__0()
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x64D7EA0", Offset = "0x64D72A0", VA = "0x1864D7EA0")]
			public GMNHKBHICHJ(NOEEIPFGABG KPGPMPPLGCI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x407A9F0", Offset = "0x4079DF0", VA = "0x18407A9F0", Slot = "8")]
			public override bool MHBAMOAJPNP<TBind, TInstance, TBind>(string[] MIHBJPNBFFD)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x64D7D40", Offset = "0x64D7140", VA = "0x1864D7D40", Slot = "9")]
			public override bool MHBAMOAJPNP(Type FPDPHGPGKGF, Type POPCBFIHNJG, string[] MIHBJPNBFFD)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		[CompilerGenerated]
		private sealed class ONIAAOJMOPG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public ServiceRegisterer <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public Type bindType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public FPOGPJMGMEG lifetime;

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
			public ONIAAOJMOPG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x64D9C60", Offset = "0x64D9060", VA = "0x1864D9C60")]
			internal object <AlsoBindAs>b__0()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private static readonly BBHAOFNBCPD CDECIAPNKBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private readonly NOEEIPFGABG KPGPMPPLGCI;

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x75F090", Offset = "0x75E490", VA = "0x18075F090")]
		public ServiceRegisterer(NOEEIPFGABG KPGPMPPLGCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract bool MHBAMOAJPNP<TBind, TInstance, TBind>(string[] MIHBJPNBFFD) where TBind : class where TInstance : TBind, new() where TBind : class;

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract bool MHBAMOAJPNP(Type FPDPHGPGKGF, Type POPCBFIHNJG, string[] MIHBJPNBFFD);

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x40A1050", Offset = "0x40A0450", VA = "0x1840A1050", Slot = "7")]
		public void OJFNNCLNDBM<TBind, TAlsoBindAs, TBind>() where TBind : class where TAlsoBindAs : class, TBind where TBind : class
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x64DB520", Offset = "0x64DA920", VA = "0x1864DB520", Slot = "5")]
		public void OJFNNCLNDBM(Type FPDPHGPGKGF, Type PAAMDKJAOLH)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal static class AMNHFLOIBJM
{
}
namespace RecRoom.ObjectModel.Service.Internal
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[NAPHGBOEKGO(GPIMBHHJLKL.Services)]
	internal class Disposables : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private static readonly BBHAOFNBCPD CDECIAPNKBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly List<IDisposable> FCMMMBDHCMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private bool GBMPCBCEGPH;

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x64D76A0", Offset = "0x64D6AA0", VA = "0x1864D76A0")]
		public void PPNDICAMACE(object GMEHFCMOOAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x64D7500", Offset = "0x64D6900", VA = "0x1864D7500")]
		public void BIEFCABEIDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x64D7520", Offset = "0x64D6920", VA = "0x1864D7520", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x64D77C0", Offset = "0x64D6BC0", VA = "0x1864D77C0")]
		public Disposables()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
internal class OHOGNADNLBK
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class DPEEKEHGLLD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public LODNGHNPONL newScope;

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public DPEEKEHGLLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x64D74A0", Offset = "0x64D68A0", VA = "0x1864D74A0")]
		internal void <ExecuteScopeChange>b__0(AAHLPGOALAE svc)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class LNPPAJFEGNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public LNPPAJFEGNH()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly Dictionary<KGKNKCKDPOC, List<object>> OHMADKFPINL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly KGKNKCKDPOC[] DAAHLDMDFPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly LODNGHNPONL KPGPMPPLGCI;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public KGKNKCKDPOC LBMLIBBHAFP
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x78F500", Offset = "0x78E900", VA = "0x18078F500")]
		[CompilerGenerated]
		get
		{
			return default(KGKNKCKDPOC);
		}
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x75DDF0", Offset = "0x75D1F0", VA = "0x18075DDF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x64D9B80", Offset = "0x64D8F80", VA = "0x1864D9B80")]
	public OHOGNADNLBK(LODNGHNPONL KPGPMPPLGCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x64D97B0", Offset = "0x64D8BB0", VA = "0x1864D97B0")]
	public void OODLPMEBHLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x64D9600", Offset = "0x64D8A00", VA = "0x1864D9600")]
	public void LPJPJHNNOHG(LODNGHNPONL KDLEJHPKDEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x64D9050", Offset = "0x64D8450", VA = "0x1864D9050")]
	internal void BIEFCABEIDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x64D93E0", Offset = "0x64D87E0", VA = "0x1864D93E0")]
	public bool KHEDPGMOGGJ(object GMEHFCMOOAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x32176B0", Offset = "0x3216AB0", VA = "0x1832176B0")]
	private void NEEMKBEPJCF<T>(Action<T> JBIMBCFPDBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x32174E0", Offset = "0x32168E0", VA = "0x1832174E0")]
	private void NEEMKBEPJCF<T>(Action<T> JBIMBCFPDBB, KGKNKCKDPOC EIONKOPIMNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x32172F0", Offset = "0x32166F0", VA = "0x1832172F0")]
	private static bool FCMAJDDHMBP<T>(object CLJOGGPIGLL, Action<T> JBIMBCFPDBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x3217410", Offset = "0x3216810", VA = "0x183217410")]
	private bool JMDMGCGGNHK<T>(KGKNKCKDPOC EIONKOPIMNI, object HIJHNJBFIPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x64D92B0", Offset = "0x64D86B0", VA = "0x1864D92B0")]
	private void KFFOONINDNE(KGKNKCKDPOC EIONKOPIMNI, object GMEHFCMOOAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x64D9250", Offset = "0x64D8650", VA = "0x1864D9250")]
	[CompilerGenerated]
	private void KFCLLNGCDBM(DIACEKEHMCI CLJOGGPIGLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x64D96F0", Offset = "0x64D8AF0", VA = "0x1864D96F0")]
	[CompilerGenerated]
	private void ODGOILNAKBA(DIACEKEHMCI CLJOGGPIGLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x64D8FF0", Offset = "0x64D83F0", VA = "0x1864D8FF0")]
	[CompilerGenerated]
	private void BGKIFAAHJIP(NGENPNOGFON CLJOGGPIGLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x64D91F0", Offset = "0x64D85F0", VA = "0x1864D91F0")]
	[CompilerGenerated]
	private void GNDNLNELDDM(DIACEKEHMCI CLJOGGPIGLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x64D95A0", Offset = "0x64D89A0", VA = "0x1864D95A0")]
	[CompilerGenerated]
	private void LMHGHMFJHDJ(CJFEEGPLPHA CLJOGGPIGLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x64D9190", Offset = "0x64D8590", VA = "0x1864D9190")]
	[CompilerGenerated]
	private void GLAJMHHODFF(DIACEKEHMCI CLJOGGPIGLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x64D9750", Offset = "0x64D8B50", VA = "0x1864D9750")]
	[CompilerGenerated]
	private void OFGCECFLGEE(PJMBNFGPKOH CLJOGGPIGLL)
	{
	}
}
namespace RecRoom.ObjectModel.Service.Internal
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[NAPHGBOEKGO(GPIMBHHJLKL.Services)]
	internal class ServiceInitOrder : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private static readonly BBHAOFNBCPD CDECIAPNKBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly NBMFCGEOKMG PCELECPCFEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private readonly Dictionary<Type, object> LEEBCLOKNJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private readonly HashSet<object> ENMINDMMNIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private readonly Disposables FCMMMBDHCMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private readonly FPOGPJMGMEG ODKOMDFLCPK;

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x64DB380", Offset = "0x64DA780", VA = "0x1864DB380")]
		public ServiceInitOrder(FPOGPJMGMEG ODKOMDFLCPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x64DA3D0", Offset = "0x64D97D0", VA = "0x1864DA3D0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x64D9DD0", Offset = "0x64D91D0", VA = "0x1864D9DD0")]
		public void BKCAAEBNAMB(Type FPDPHGPGKGF, object OCGDPJBGCPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x64DA540", Offset = "0x64D9940", VA = "0x1864DA540")]
		private void GCMLBDGGGHC(Type FPDPHGPGKGF, Type POPCBFIHNJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x64DA9E0", Offset = "0x64D9DE0", VA = "0x1864DA9E0")]
		private void IMLJOKJFLDC(Type FPDPHGPGKGF, Type POPCBFIHNJG, Type IFIDKENHJIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x64DB260", Offset = "0x64DA660", VA = "0x1864DB260")]
		public void OILEOACMMCC(OHOGNADNLBK OHMADKFPINL, PMJCGFNIPBF MDNECEIBGID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x64DA860", Offset = "0x64D9C60", VA = "0x1864DA860")]
		private void GJAOGMJCCPF(OHOGNADNLBK OHMADKFPINL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x64D9E60", Offset = "0x64D9260", VA = "0x1864D9E60")]
		private void CILNEMHIANL(OHOGNADNLBK OHMADKFPINL, PMJCGFNIPBF MDNECEIBGID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x64DA3F0", Offset = "0x64D97F0", VA = "0x1864DA3F0")]
		private IEnumerable<Type> EFHKDJFKNLA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x64DAB50", Offset = "0x64D9F50", VA = "0x1864DAB50")]
		private static bool ODCCFGHMKLI(Type CMFMDKPOIIC, Type IFIDKENHJIH, out FPOGPJMGMEG ODKOMDFLCPK, out string MCGMECECHJK)
		{
			return default(bool);
		}
	}
}
namespace RRAssemblyIndex.RecRoom.ObjectModel.Services.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[Preserve]
	internal class _RRAssemblyIndex : AOMBDDGFEEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x7CADD0", Offset = "0x7CA1D0", VA = "0x1807CADD0")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x64DCD00", Offset = "0x64DC100", VA = "0x1864DCD00", Slot = "4")]
		public sealed override void IPAAHMOMIKO()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class ABFMAPAPCGL
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static byte[] CFDBFPKMJCL;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static int NBKCFIGJMGE;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static int BKBNJMLFPCH;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static BigInteger IHOABMABNGK;

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public ABFMAPAPCGL()
	{
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2, Pack = 1, Size = 151)]
		[Cpp2IlInjected.Token(Token = "0x200002A")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public class __BB_OBFUSCATOR_VERSION_3_8_2
	{
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
