using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Logging.Attributes;
using Unity.Collections;
using Unity.Mathematics;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_ObjectModel_ConfigUI_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : FNHPAIPGMGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7F4ED60", Offset = "0x7F4DB60", VA = "0x187F4ED60", Slot = "4")]
		public override void KEMEJJLNDFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA336C0", Offset = "0xA324C0", VA = "0x180A336C0")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_ObjectModel_ConfigUI_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private int[] localIndices0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private ServiceBitset bitset0;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xA0EAC0", Offset = "0xA0D8C0", VA = "0x180A0EAC0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x20D9300", Offset = "0x20D8100", VA = "0x1820D9300", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7F51150", Offset = "0x7F4FF50", VA = "0x187F51150")]
		private void OCIJCOAIOEO(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7F513A0", Offset = "0x7F501A0", VA = "0x187F513A0", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7F51400", Offset = "0x7F50200", VA = "0x187F51400", Slot = "7")]
		public override void RegisterTypes(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7F51AF0", Offset = "0x7F508F0", VA = "0x187F51AF0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
internal abstract class GDFCOJPKIHL : OLAHJKHFHOE<Enum>, CHCKAIIDCFI, ABHEHOBPGOK, BBFLLOBOHLE
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract bool JEGMHOKBDNL(Type AAFMBEEMJAC);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7F4B3A0", Offset = "0x7F4A1A0", VA = "0x187F4B3A0")]
	protected GDFCOJPKIHL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal abstract class OLAHJKHFHOE<T> : ABHEHOBPGOK, BBFLLOBOHLE where T : Enum
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class GDGBLLHCPEH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public FPBJBALAJNG property;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public GDGBLLHCPEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x4B84CA0", Offset = "0x4B83AA0", VA = "0x184B84CA0")]
		internal bool FPAMEHIPGEA()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x56770A0", Offset = "0x5675EA0", VA = "0x1856770A0")]
	protected OLAHJKHFHOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5676BC0", Offset = "0x56759C0", VA = "0x185676BC0")]
	protected void EMCDNCHGKLD(HFIFEJBPLFB FCFFBGOAPEH, FPBJBALAJNG FEMKAJANBPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4D56340", Offset = "0x4D55140", VA = "0x184D56340")]
	protected void GMIGKCDHJAG(OIHGHNJPKJP<T> FCFFBGOAPEH, FPBJBALAJNG FEMKAJANBPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract void JDMBLPNDBCP(FPBJBALAJNG FEMKAJANBPA, KEIKBBHBJFI GJLIPADLBPH);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal abstract class GCMDMAPAOIM : EJJCEGHPHIE, BBFLLOBOHLE
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public abstract JALOGBPPALL[] FMONPAEPPDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public abstract JALOGBPPALL[] GEHKIIFJPCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract void JDMBLPNDBCP(FPBJBALAJNG FEMKAJANBPA, MCBEIJGOANF GJBNBDFLEMP, LNGCNKDJIDO EEPKHBFMMAG, KEIKBBHBJFI GJLIPADLBPH);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x38FB9C0", Offset = "0x38FA7C0", VA = "0x1838FB9C0")]
	protected static T FAKNLPHGPGD<T>(LHGPEBNJFMN DIGOGLIAEGA, INBDAOJIOBO<T> FEMKAJANBPA) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x38FBA10", Offset = "0x38FA810", VA = "0x1838FBA10")]
	protected static void LIEFNNJELDE<T>(LHGPEBNJFMN DIGOGLIAEGA, INBDAOJIOBO<T> FEMKAJANBPA, T OAIIHELJHLG) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	protected GCMDMAPAOIM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
internal abstract class IOGNPDBFHJM<T> : ABHEHOBPGOK, BBFLLOBOHLE where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class MJAGAONLGGH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public FPBJBALAJNG property;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public MJAGAONLGGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x53C6170", Offset = "0x53C4F70", VA = "0x1853C6170")]
		internal bool FPAMEHIPGEA()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x4D568B0", Offset = "0x4D556B0", VA = "0x184D568B0")]
	protected IOGNPDBFHJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x4D556A0", Offset = "0x4D544A0", VA = "0x184D556A0")]
	protected void EMCDNCHGKLD(HFIFEJBPLFB FCFFBGOAPEH, FPBJBALAJNG FEMKAJANBPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x4D56140", Offset = "0x4D54F40", VA = "0x184D56140")]
	protected void GMIGKCDHJAG(OIHGHNJPKJP<T> FCFFBGOAPEH, FPBJBALAJNG FEMKAJANBPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract void JDMBLPNDBCP(FPBJBALAJNG FEMKAJANBPA, KEIKBBHBJFI GJLIPADLBPH);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[RegisterService(typeof(MCBEIJGOANF), new string[] { })]
internal class DGKNFLKKAOA : MCBEIJGOANF, IIPCECBIBKI, IMNKKHLGPLB, AHDIFPEGPEL, FAGFKOAOOFH
{
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly IEBEPMGFCGH NHLEILEPJMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	[DependsOn]
	private LNGCNKDJIDO EEPKHBFMMAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	[DependsOn]
	private KEIKBBHBJFI MGDAGFBJPJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private NGCDGAPACGJ KMLBIJDIMBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private LHGPEBNJFMN DIGOGLIAEGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private List<FPBJBALAJNG> NGEPEPOAJFC;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public LHGPEBNJFMN GBBLEMFGOCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x14614D0", Offset = "0x14602D0", VA = "0x1814614D0", Slot = "5")]
		get
		{
			return default(LHGPEBNJFMN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7F4C290", Offset = "0x7F4B090", VA = "0x187F4C290", Slot = "6")]
	public void PIEFLCLFLGG(LFBEMDOHFPC EPHKCBICOBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7F4B690", Offset = "0x7F4A490", VA = "0x187F4B690", Slot = "7")]
	public void DAHEEJMILJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7F4BD70", Offset = "0x7F4AB70", VA = "0x187F4BD70", Slot = "4")]
	public void NBCFPOEGIAF(LHGPEBNJFMN OJALGOECFOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7F4B990", Offset = "0x7F4A790", VA = "0x187F4B990")]
	private void JBDBCGEMHNK(LHGPEBNJFMN OJALGOECFOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7F4B790", Offset = "0x7F4A590", VA = "0x187F4B790")]
	private void DDBFFLKDPLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7F4BA00", Offset = "0x7F4A800", VA = "0x187F4BA00")]
	private void JDMBLPNDBCP(GCKAJDIKPPD DICIGALDDCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7F4BD00", Offset = "0x7F4AB00", VA = "0x187F4BD00", Slot = "8")]
	private void KHEDDOBEPFG(LFBEMDOHFPC EPHKCBICOBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x11E2B80", Offset = "0x11E1980", VA = "0x1811E2B80", Slot = "9")]
	private void JLHNKKDCLJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7F4C670", Offset = "0x7F4B470", VA = "0x187F4C670")]
	public DGKNFLKKAOA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[NFDPHHNNLMG(0)]
internal class CHEFFAEMCEN : GDFCOJPKIHL
{
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7F4B250", Offset = "0x7F4A050", VA = "0x187F4B250", Slot = "5")]
	public override void JDMBLPNDBCP(FPBJBALAJNG FEMKAJANBPA, KEIKBBHBJFI GJLIPADLBPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7F4B300", Offset = "0x7F4A100", VA = "0x187F4B300", Slot = "7")]
	public override bool JEGMHOKBDNL(Type AAFMBEEMJAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7F4B3A0", Offset = "0x7F4A1A0", VA = "0x187F4B3A0")]
	public CHEFFAEMCEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[NFDPHHNNLMG(0)]
internal class HECONPBHGHJ : GDFCOJPKIHL
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7F4CDC0", Offset = "0x7F4BBC0", VA = "0x187F4CDC0", Slot = "5")]
	public override void JDMBLPNDBCP(FPBJBALAJNG FEMKAJANBPA, KEIKBBHBJFI GJLIPADLBPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7F4CE70", Offset = "0x7F4BC70", VA = "0x187F4CE70", Slot = "7")]
	public override bool JEGMHOKBDNL(Type AAFMBEEMJAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7F4B3A0", Offset = "0x7F4A1A0", VA = "0x187F4B3A0")]
	public HECONPBHGHJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[CFGJFPPEJOA(typeof(JOOCMDBDCKI), 1)]
internal class NJFPICEDGJN : OLAHJKHFHOE<JOOCMDBDCKI>
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7F50710", Offset = "0x7F4F510", VA = "0x187F50710", Slot = "5")]
	public override void JDMBLPNDBCP(FPBJBALAJNG FEMKAJANBPA, KEIKBBHBJFI GJLIPADLBPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7F50860", Offset = "0x7F4F660", VA = "0x187F50860")]
	public NJFPICEDGJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[PNFHCLNHJCB(2)]
internal class AHMEPDMMOAN : GCMDMAPAOIM
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class ENDHOIDBOHA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public MCBEIJGOANF configUIService;

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public ENDHOIDBOHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7F4C8F0", Offset = "0x7F4B6F0", VA = "0x187F4C8F0")]
		internal (int, int) CEJFLDDNDFA()
		{
			return default((int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7F4C810", Offset = "0x7F4B610", VA = "0x187F4C810")]
		internal void CCCHGLCABND((int color, int material) value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public override JALOGBPPALL[] FMONPAEPPDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public override JALOGBPPALL[] GEHKIIFJPCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7F4A2E0", Offset = "0x7F490E0", VA = "0x187F4A2E0", Slot = "9")]
	public override void JDMBLPNDBCP(FPBJBALAJNG FEMKAJANBPA, MCBEIJGOANF GJBNBDFLEMP, LNGCNKDJIDO EEPKHBFMMAG, KEIKBBHBJFI GJLIPADLBPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7F4A6B0", Offset = "0x7F494B0", VA = "0x187F4A6B0")]
	public AHMEPDMMOAN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[CFGJFPPEJOA(typeof(bool))]
internal class LDHKJKFGIGG : IOGNPDBFHJM<bool>
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7F4EC90", Offset = "0x7F4DA90", VA = "0x187F4EC90", Slot = "5")]
	public override void JDMBLPNDBCP(FPBJBALAJNG FEMKAJANBPA, KEIKBBHBJFI GJLIPADLBPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7F4ED20", Offset = "0x7F4DB20", VA = "0x187F4ED20")]
	public LDHKJKFGIGG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[CFGJFPPEJOA(typeof(FixedString32Bytes))]
internal class CLGEHHLBNBB : IOGNPDBFHJM<FixedString32Bytes>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class KMJMDAAEAMM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public FPBJBALAJNG property;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public KMJMDAAEAMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7F4EC30", Offset = "0x7F4DA30", VA = "0x187F4EC30")]
		internal string CEJFLDDNDFA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7F4EBC0", Offset = "0x7F4D9C0", VA = "0x187F4EBC0")]
		internal void CCCHGLCABND(string value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7F4B3E0", Offset = "0x7F4A1E0", VA = "0x187F4B3E0", Slot = "5")]
	public override void JDMBLPNDBCP(FPBJBALAJNG FEMKAJANBPA, KEIKBBHBJFI GJLIPADLBPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7F4B580", Offset = "0x7F4A380", VA = "0x187F4B580")]
	public CLGEHHLBNBB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[CFGJFPPEJOA(typeof(FixedString64Bytes))]
internal class KEKNBFHADOJ : IOGNPDBFHJM<FixedString64Bytes>
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class DNNAFBPNANI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public FPBJBALAJNG property;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public DNNAFBPNANI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7F4C790", Offset = "0x7F4B590", VA = "0x187F4C790")]
		internal string CEJFLDDNDFA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7F4C700", Offset = "0x7F4B500", VA = "0x187F4C700")]
		internal void CCCHGLCABND(string value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7F4DCE0", Offset = "0x7F4CAE0", VA = "0x187F4DCE0", Slot = "5")]
	public override void JDMBLPNDBCP(FPBJBALAJNG FEMKAJANBPA, KEIKBBHBJFI GJLIPADLBPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7F4DE80", Offset = "0x7F4CC80", VA = "0x187F4DE80")]
	public KEKNBFHADOJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[CFGJFPPEJOA(typeof(float3))]
internal class HMJGBECIGJN : IOGNPDBFHJM<float3>
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class JOBNAEDOMOK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public FPBJBALAJNG property;

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public JOBNAEDOMOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7F4DA20", Offset = "0x7F4C820", VA = "0x187F4DA20")]
		internal float CEJFLDDNDFA()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x7F4DA10", Offset = "0x7F4C810", VA = "0x187F4DA10")]
		internal void CCCHGLCABND(float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x7F4DAA0", Offset = "0x7F4C8A0", VA = "0x187F4DAA0")]
		internal float GOKDJCKNGJD()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x7F4DA90", Offset = "0x7F4C890", VA = "0x187F4DA90")]
		internal void ECJCBIGABNK(float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7F4DC00", Offset = "0x7F4CA00", VA = "0x187F4DC00")]
		internal float NEDFJLAHBOP()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7F4DBF0", Offset = "0x7F4C9F0", VA = "0x187F4DBF0")]
		internal void LPCOOHIEPJL(float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x7F4DC70", Offset = "0x7F4CA70", VA = "0x187F4DC70")]
		internal float PPJALCPLBOL(int index)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x7F4DB10", Offset = "0x7F4C910", VA = "0x187F4DB10")]
		internal void HFMGHECOEGM(int index, float value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7F4CF20", Offset = "0x7F4BD20", VA = "0x187F4CF20", Slot = "5")]
	public override void JDMBLPNDBCP(FPBJBALAJNG FEMKAJANBPA, KEIKBBHBJFI GJLIPADLBPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7F4D350", Offset = "0x7F4C150", VA = "0x187F4D350")]
	public HMJGBECIGJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[CFGJFPPEJOA(typeof(float))]
internal class DAPIMEHAOKD : IOGNPDBFHJM<float>
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7F4B5C0", Offset = "0x7F4A3C0", VA = "0x187F4B5C0", Slot = "5")]
	public override void JDMBLPNDBCP(FPBJBALAJNG FEMKAJANBPA, KEIKBBHBJFI GJLIPADLBPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7F4B650", Offset = "0x7F4A450", VA = "0x187F4B650")]
	public DAPIMEHAOKD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[CFGJFPPEJOA(typeof(int))]
internal class KFGHOIPPIMO : IOGNPDBFHJM<int>
{
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7F4DEC0", Offset = "0x7F4CCC0", VA = "0x187F4DEC0", Slot = "5")]
	public override void JDMBLPNDBCP(FPBJBALAJNG FEMKAJANBPA, KEIKBBHBJFI GJLIPADLBPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7F4DF50", Offset = "0x7F4CD50", VA = "0x187F4DF50")]
	public KFGHOIPPIMO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[CFGJFPPEJOA(typeof(quaternion))]
internal class BKOALPCLDNM : IOGNPDBFHJM<quaternion>
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class IKPAGLCFHAA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public FPBJBALAJNG property;

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public IKPAGLCFHAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x7F4D3A0", Offset = "0x7F4C1A0", VA = "0x187F4D3A0")]
		internal float CEJFLDDNDFA()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x7F4D390", Offset = "0x7F4C190", VA = "0x187F4D390")]
		internal void CCCHGLCABND(float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x7F4D620", Offset = "0x7F4C420", VA = "0x187F4D620")]
		internal float GOKDJCKNGJD()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x7F4D3B0", Offset = "0x7F4C1B0", VA = "0x187F4D3B0")]
		internal void ECJCBIGABNK(float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x7F4D7B0", Offset = "0x7F4C5B0", VA = "0x187F4D7B0")]
		internal float NEDFJLAHBOP()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x7F4D7A0", Offset = "0x7F4C5A0", VA = "0x187F4D7A0")]
		internal void LPCOOHIEPJL(float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x7F4D630", Offset = "0x7F4C430", VA = "0x187F4D630")]
		internal float IPEFLBLHJGM(int index)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x7F4D3C0", Offset = "0x7F4C1C0", VA = "0x187F4D3C0")]
		internal void GLEFELEAFGM(int index, float value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7F4A9C0", Offset = "0x7F497C0", VA = "0x187F4A9C0", Slot = "5")]
	public override void JDMBLPNDBCP(FPBJBALAJNG FEMKAJANBPA, KEIKBBHBJFI GJLIPADLBPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7F4ADF0", Offset = "0x7F49BF0", VA = "0x187F4ADF0")]
	public BKOALPCLDNM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[CFGJFPPEJOA(typeof(uint))]
internal class BIBFOBKGAMH : IOGNPDBFHJM<uint>
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class AGDKKFGHFPO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public FPBJBALAJNG property;

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public AGDKKFGHFPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7F4A2A0", Offset = "0x7F490A0", VA = "0x187F4A2A0")]
		internal int CEJFLDDNDFA()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x7F4A250", Offset = "0x7F49050", VA = "0x187F4A250")]
		internal void CCCHGLCABND(int value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7F4A7E0", Offset = "0x7F495E0", VA = "0x187F4A7E0", Slot = "5")]
	public override void JDMBLPNDBCP(FPBJBALAJNG FEMKAJANBPA, KEIKBBHBJFI GJLIPADLBPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7F4A980", Offset = "0x7F49780", VA = "0x187F4A980")]
	public BIBFOBKGAMH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal struct GCKAJDIKPPD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public int BALPHCILBBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public JALOGBPPALL FEMKAJANBPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public int FBACJIPNPNF;
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
internal static class ACEKKOBDDBO
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7F495D0", Offset = "0x7F483D0", VA = "0x187F495D0")]
	public static void DOJPBGAJFMI(Type IKDPFGABOAB, Type OKKPLGGKKLO)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001F")]
internal struct HDBGIMKBLFK
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7F4CB60", Offset = "0x7F4B960", VA = "0x187F4CB60")]
	public static NativeList<JALOGBPPALL> LMFECBBFMBN(LHGPEBNJFMN DIGOGLIAEGA, LNGCNKDJIDO EEPKHBFMMAG)
	{
		return default(NativeList<JALOGBPPALL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x7F4CA70", Offset = "0x7F4B870", VA = "0x187F4CA70")]
	private static bool FFGFFAICCGN(JALOGBPPALL FEMKAJANBPA, LHGPEBNJFMN DIGOGLIAEGA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class KJNADBABOOJ : FPBJBALAJNG, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly JALOGBPPALL FEMKAJANBPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly LNGCNKDJIDO BMACFGNFKCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly LHGPEBNJFMN DIGOGLIAEGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private bool EKADHKFOHIM;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public string KHKODDKNOBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7F4E5F0", Offset = "0x7F4D3F0", VA = "0x187F4E5F0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool CJJDLPNFICK
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7F4E650", Offset = "0x7F4D450", VA = "0x187F4E650", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public GALEOJBODPG CNIGNBMAJNL
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7F4E970", Offset = "0x7F4D770", VA = "0x187F4E970", Slot = "8")]
		get
		{
			return default(GALEOJBODPG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Type KDNIOMEAELB
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7F4E5A0", Offset = "0x7F4D3A0", VA = "0x187F4E5A0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action KAFADCFHOOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x7F4E6D0", Offset = "0x7F4D4D0", VA = "0x187F4E6D0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x7F4E430", Offset = "0x7F4D230", VA = "0x187F4E430", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7F4EAD0", Offset = "0x7F4D8D0", VA = "0x187F4EAD0")]
	public KJNADBABOOJ(LHGPEBNJFMN DIGOGLIAEGA, JALOGBPPALL FEMKAJANBPA, LNGCNKDJIDO BMACFGNFKCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x7F4E9C0", Offset = "0x7F4D7C0", VA = "0x187F4E9C0")]
	private void PMDFMFIMBCG(FCNPFOCIONN FFEMKICJPKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7F4E890", Offset = "0x7F4D690", VA = "0x187F4E890", Slot = "10")]
	public void MBFFDPKOBBN(MPGMAKFMEHA OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x7F4E770", Offset = "0x7F4D570", VA = "0x187F4E770", Slot = "11")]
	public void KDAEEABIJCL(HGLLOOGIBCJ OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7F4E4D0", Offset = "0x7F4D2D0", VA = "0x187F4E4D0", Slot = "12")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[INGLFPHPBJB(1)]
internal sealed class OCFPHMJPKCK : FGDDJIGNBBM, ABHEHOBPGOK, BBFLLOBOHLE
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class ILHINAAPPMG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public FPBJBALAJNG property;

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public ILHINAAPPMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7F4D840", Offset = "0x7F4C640", VA = "0x187F4D840")]
		internal bool CEJFLDDNDFA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x7F4D7C0", Offset = "0x7F4C5C0", VA = "0x187F4D7C0")]
		internal string CCCHGLCABND()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7F4D970", Offset = "0x7F4C770", VA = "0x187F4D970")]
		internal void GOKDJCKNGJD(string value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x7F4D890", Offset = "0x7F4C690", VA = "0x187F4D890")]
		internal string ECJCBIGABNK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public JALOGBPPALL KPNBGJGPCHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7F50900", Offset = "0x7F4F700", VA = "0x187F50900", Slot = "4")]
		get
		{
			return default(JALOGBPPALL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x7F50970", Offset = "0x7F4F770", VA = "0x187F50970", Slot = "5")]
	public void JDMBLPNDBCP(FPBJBALAJNG FEMKAJANBPA, KEIKBBHBJFI GJLIPADLBPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public OCFPHMJPKCK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal class AEJIKHHPPEL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly LNGCNKDJIDO EEPKHBFMMAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly KEIKBBHBJFI GJLIPADLBPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly Action<GCKAJDIKPPD> OLJNDFBHPGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly HashSet<AMMJGKGFKHG> OPAELJIOJCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly Dictionary<AMMJGKGFKHG, List<GCKAJDIKPPD>> KJLKJMBJHGI;

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7F4A130", Offset = "0x7F48F30", VA = "0x187F4A130")]
	public AEJIKHHPPEL(LNGCNKDJIDO EEPKHBFMMAG, KEIKBBHBJFI GJLIPADLBPH, Action<GCKAJDIKPPD> OLJNDFBHPGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7F496A0", Offset = "0x7F484A0", VA = "0x187F496A0")]
	public void JINPMDHKEDF(NativeList<GCKAJDIKPPD> IANOHDOCOCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7F49F90", Offset = "0x7F48D90", VA = "0x187F49F90")]
	private void ONEHHOHJOFP(AMMJGKGFKHG NNLLPHNMAFL, GCKAJDIKPPD DICIGALDDCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7F49A10", Offset = "0x7F48810", VA = "0x187F49A10")]
	public void KFPFJKMBJJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7F49A70", Offset = "0x7F48870", VA = "0x187F49A70")]
	private void NGMCOJBHHNO(AMMJGKGFKHG NNLLPHNMAFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7F49EF0", Offset = "0x7F48CF0", VA = "0x187F49EF0")]
	private void NLMOEBEPDDN(AMMJGKGFKHG NNLLPHNMAFL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal class BLHFLFFJGOI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class KFHOIIENCBB : IEnumerable<JALOGBPPALL>, IEnumerable, IEnumerator<JALOGBPPALL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private JALOGBPPALL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public BLHFLFFJGOI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private Type type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public Type <>3__type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private NativeParallelMultiHashMap<long, int>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private JALOGBPPALL System.Collections.Generic.IEnumerator<RecRoom.DataLayer.NetworkProperty>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0xB97DF0", Offset = "0xB96BF0", VA = "0x180B97DF0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(JALOGBPPALL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x7F4E350", Offset = "0x7F4D150", VA = "0x187F4E350", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x12F1100", Offset = "0x12EFF00", VA = "0x1812F1100")]
		[DebuggerHidden]
		public KFHOIIENCBB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7F4E3A0", Offset = "0x7F4D1A0", VA = "0x187F4E3A0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7F4DF90", Offset = "0x7F4CD90", VA = "0x187F4DF90", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7F4E1F0", Offset = "0x7F4CFF0", VA = "0x187F4E1F0")]
		private void PPMJPANAFBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7F4E300", Offset = "0x7F4D100", VA = "0x187F4E300", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7F4E240", Offset = "0x7F4D040", VA = "0x187F4E240", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<JALOGBPPALL> System.Collections.Generic.IEnumerable<RecRoom.DataLayer.NetworkProperty>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7F4E240", Offset = "0x7F4D040", VA = "0x187F4E240", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private static readonly IEBEPMGFCGH NHLEILEPJMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private NativeParallelMultiHashMap<long, int> FBEHLGJFMDI;

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x7F4B060", Offset = "0x7F49E60", VA = "0x187F4B060")]
	public BLHFLFFJGOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7F4AE70", Offset = "0x7F49C70", VA = "0x187F4AE70")]
	[IteratorStateMachine(typeof(KFHOIIENCBB))]
	public IEnumerable<JALOGBPPALL> HHIBJGDJMON(Type AAFMBEEMJAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7F4AE30", Offset = "0x7F49C30", VA = "0x187F4AE30", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7F4AF10", Offset = "0x7F49D10", VA = "0x187F4AF10")]
	private long IKCPDFLCFPN(JALOGBPPALL FEMKAJANBPA)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7F4AF90", Offset = "0x7F49D90", VA = "0x187F4AF90")]
	private long IKCPDFLCFPN(Type AAFMBEEMJAC)
	{
		return default(long);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal struct OCGKLDMCFHG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private NativeBitArray BHEIJCEOHBC;

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x7F510F0", Offset = "0x7F4FEF0", VA = "0x187F510F0")]
	public OCGKLDMCFHG(int ALFGNAHPKIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x7F50DE0", Offset = "0x7F4FBE0", VA = "0x187F50DE0")]
	public static OCGKLDMCFHG AKKFAPKOOGD(int KIOMCEJDGPM, NativeArray<JALOGBPPALL> ADPBPEDNFCM)
	{
		return default(OCGKLDMCFHG);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x7F51030", Offset = "0x7F4FE30", VA = "0x187F51030")]
	public bool MCLBGHGHECG(int GLAOLHCPLLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x7F51020", Offset = "0x7F4FE20", VA = "0x187F51020")]
	public void KDAEEABIJCL(int GLAOLHCPLLG, bool OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x7F50F70", Offset = "0x7F4FD70", VA = "0x187F50F70")]
	public bool JCPINDJNAKP(JALOGBPPALL[] ADPBPEDNFCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x7F51040", Offset = "0x7F4FE40", VA = "0x187F51040")]
	public bool PGNLMIIDFAI(JALOGBPPALL[] ADPBPEDNFCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x7F50F60", Offset = "0x7F4FD60", VA = "0x187F50F60", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal class NGCDGAPACGJ
{
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static readonly IEBEPMGFCGH NHLEILEPJMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private readonly LNGCNKDJIDO EEPKHBFMMAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly List<BBFLLOBOHLE> NICLDNOBLCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly BLHFLFFJGOI FBEHLGJFMDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private NativeParallelMultiHashMap<int, int> IDPBGNCEPLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private NativeList<int> NKJJOELAMDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private bool EKADHKFOHIM;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public List<BBFLLOBOHLE> CPMPIDKCOFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x7F4FFB0", Offset = "0x7F4EDB0", VA = "0x187F4FFB0")]
	public NGCDGAPACGJ(LNGCNKDJIDO EEPKHBFMMAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x7F4FBB0", Offset = "0x7F4E9B0", VA = "0x187F4FBB0")]
	public void LNJEMOCDJGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x7F4F9F0", Offset = "0x7F4E7F0", VA = "0x187F4F9F0")]
	public void JKOPJCPMPLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x7F4EFB0", Offset = "0x7F4DDB0", VA = "0x187F4EFB0")]
	public NativeList<GCKAJDIKPPD> BGANOKGEOGL(NativeArray<JALOGBPPALL> ADPBPEDNFCM)
	{
		return default(NativeList<GCKAJDIKPPD>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x7F4F540", Offset = "0x7F4E340", VA = "0x187F4F540")]
	private bool DLHPLOONPKH(BBFLLOBOHLE LAOIHOGCLOF, OCGKLDMCFHG BMKFDPOMCFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x3AA87F0", Offset = "0x3AA75F0", VA = "0x183AA87F0")]
	private void KPICLKANNEN<TInterface, TAttribute>(Action<TInterface, TAttribute> BJEODFEPDCP) where TInterface : BBFLLOBOHLE where TAttribute : Attribute
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x7F4EE70", Offset = "0x7F4DC70", VA = "0x187F4EE70")]
	private void ACJKIGJEGKN(Type AAFMBEEMJAC, Type CCKPMKIPGBG, Type JGIGMJPCKDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x3AA8780", Offset = "0x3AA7580", VA = "0x183AA8780")]
	private TInterface FLBDPDKNAJO<TInterface>(Type AAFMBEEMJAC)
	{
		return (TInterface)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x7F4F4A0", Offset = "0x7F4E2A0", VA = "0x187F4F4A0")]
	private int DIAFLCPCMIL(BBFLLOBOHLE IPBPDGOKPLK, int FBACJIPNPNF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x7F4FC90", Offset = "0x7F4EA90", VA = "0x187F4FC90")]
	private void MFFOMMPGKCE(ABHEHOBPGOK LAOIHOGCLOF, CFGJFPPEJOA CMBDADJAGFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x7F4F610", Offset = "0x7F4E410", VA = "0x187F4F610")]
	private void EIGJPHJGIBA(CHCKAIIDCFI LAOIHOGCLOF, NFDPHHNNLMG CMBDADJAGFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x7F4EEA0", Offset = "0x7F4DCA0", VA = "0x187F4EEA0")]
	private void BCFCDEKAIHK(EJJCEGHPHIE LAOIHOGCLOF, PNFHCLNHJCB CMBDADJAGFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x7F4F920", Offset = "0x7F4E720", VA = "0x187F4F920")]
	private void FKKMKCIGEDI(FGDDJIGNBBM LAOIHOGCLOF, INGLFPHPBJB CMBDADJAGFI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal struct NJACDPPJBDB : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly List<BBFLLOBOHLE> NICLDNOBLCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private NativeList<GCKAJDIKPPD> BPDBICKBENG;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public NativeList<GCKAJDIKPPD> PAPFDMPECOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x29D9D60", Offset = "0x29D8B60", VA = "0x1829D9D60")]
		get
		{
			return default(NativeList<GCKAJDIKPPD>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x7F506B0", Offset = "0x7F4F4B0", VA = "0x187F506B0")]
	public NJACDPPJBDB(List<BBFLLOBOHLE> NICLDNOBLCJ, NativeArray<GCKAJDIKPPD> IANOHDOCOCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x7F50440", Offset = "0x7F4F240", VA = "0x187F50440", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x7F50110", Offset = "0x7F4EF10", VA = "0x187F50110")]
	private NativeList<GCKAJDIKPPD> ADNLOBFEBII(NativeArray<GCKAJDIKPPD> FGCMOJKLLOD)
	{
		return default(NativeList<GCKAJDIKPPD>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x7F50480", Offset = "0x7F4F280", VA = "0x187F50480")]
	private bool HJKEKBCHPJK(BBFLLOBOHLE LAOIHOGCLOF, OCGKLDMCFHG GLCGCAPGFJA, JALOGBPPALL FEMKAJANBPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x7F50570", Offset = "0x7F4F370", VA = "0x187F50570")]
	private void OIGLGDOGAOE(BBFLLOBOHLE LAOIHOGCLOF, OCGKLDMCFHG BHEIJCEOHBC, JALOGBPPALL DIMJPFKJNBM)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal struct OBGFCOIFCHH : IComparer<GCKAJDIKPPD>
{
	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x7F508F0", Offset = "0x7F4F6F0", VA = "0x187F508F0", Slot = "4")]
	public int Compare(GCKAJDIKPPD CHIPBNNCPBF, GCKAJDIKPPD MDEAIGKHMKE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x7F508A0", Offset = "0x7F4F6A0", VA = "0x187F508A0")]
	public static void ABILIENNHFM(NativeList<GCKAJDIKPPD> IANOHDOCOCO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[AttributeUsage(AttributeTargets.Class)]
public class INGLFPHPBJB : BKLCBDNMFFK
{
	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x7F4DA00", Offset = "0x7F4C800", VA = "0x187F4DA00")]
	public INGLFPHPBJB(int JIMKPCCKHFP = 1)
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
