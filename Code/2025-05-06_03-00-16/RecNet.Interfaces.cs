using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecNet;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xA08FF0", Offset = "0xA077F0", VA = "0x180A08FF0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7073770", Offset = "0x7071F70", VA = "0x187073770")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA09330", Offset = "0xA07B30", VA = "0x180A09330")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA09370", Offset = "0xA07B70", VA = "0x180A09370")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface GNCNAHDBINF
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	string HHEGGAPMMCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string NNCJPANENGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface JLAEKHHCELE
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PLIMMKHFKBA();

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<DGMMIABMBEA> NMJGJNKGIMB([Optional] CancellationToken DNHBNMHIDAC);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<GNCNAHDBINF> AOPPHHHDNCL(string BBECHOEGLJE, string NHNFHJEMJEO, string NMEEDCLBOJK, string? MNAEKHECKGH, float GFLECDOPEML, [Optional] CancellationToken DNHBNMHIDAC);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task<DGMMIABMBEA> JBOJBOKGIDN(long PAHLPEDOKGC, decimal HBEFCENNIBJ, [Optional] CancellationToken DNHBNMHIDAC);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task OFDNELOODEP(string BFGLGAEMILF, string AGGLOCCOENC, [Optional] CancellationToken DNHBNMHIDAC);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task GJHJHJMDFBJ(long PJFJENDBCMC, string AGGLOCCOENC, [Optional] CancellationToken DNHBNMHIDAC);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task<string> GCBFFOCPGFE(long PJFJENDBCMC, [Optional] CancellationToken DNHBNMHIDAC);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task<string> IJGEEJFOKFI(string BBECHOEGLJE, string MKGNKAJJBKJ, [Optional] string? LBLAFDELPAC, [Optional] string? CBECCFLDGHI, [Optional] CancellationToken DNHBNMHIDAC);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Task<IEOCOGBHABP?>? ECANHJHEHIE(string MKGNKAJJBKJ, [Optional] JBIECEIKKIO? HMLPEKNJHFN, [Optional] string? KMNBFAHKKBN, [Optional] string? NHNFHJEMJEO, [Optional] string? DEOMFOMAGAI, [Optional] string? BBECHOEGLJE, [Optional] bool? FJNNPNKEGIM, [Optional] CancellationToken DNHBNMHIDAC);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Task<IEOCOGBHABP> JNGJBKABEKE(string HLGPGMAFMLJ, [Optional] JBIECEIKKIO? HMLPEKNJHFN, [Optional] string? DEOMFOMAGAI, [Optional] CancellationToken DNHBNMHIDAC);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class GDCLKIOMFNO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private string HNCFPNONKBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private string KPLMNKFMNHA;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public string ILNOMOOOBLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x9DF730", Offset = "0x9DDF30", VA = "0x1809DF730")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x9DF740", Offset = "0x9DDF40", VA = "0x1809DF740")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public string HFCCIPMFOLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x9DF790", Offset = "0x9DDF90", VA = "0x1809DF790")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x9DF780", Offset = "0x9DDF80", VA = "0x1809DF780")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public string MEMDCOJFMKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x9DF770", Offset = "0x9DDF70", VA = "0x1809DF770")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x9DF750", Offset = "0x9DDF50", VA = "0x1809DF750")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public string JPADOEEJFMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x9E0DB0", Offset = "0x9DF5B0", VA = "0x1809E0DB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int? BGHAALIHFMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x9E2460", Offset = "0x9E0C60", VA = "0x1809E2460")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int? BPDANBOKHKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x9E0DD0", Offset = "0x9DF5D0", VA = "0x1809E0DD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x706EC80", Offset = "0x706D480", VA = "0x18706EC80")]
	public GDCLKIOMFNO(string HDOBJENBFIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x706EC50", Offset = "0x706D450", VA = "0x18706EC50")]
	public void PEPCFBNPGNP(string BOGNGPIAHAK = "")
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x706EB50", Offset = "0x706D350", VA = "0x18706EB50")]
	private void HJFPMGJOALI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface HCHDGGNBPBF
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	GIBKPHCLPMP CFALBOABAJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<DHJFLMOKEAF> NHNGMDKAEEE;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<FODMAOOEOBP> BGJEAHENCJG;

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<FODMAOOEOBP> MLJCNGOJPDL(bool LECIAAEEEMC = false, [Optional] CancellationToken DNHBNMHIDAC);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool INFDDFBKEKO([Out] FODMAOOEOBP HKCAIDLGODJ);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class GHOICJNONDG
{
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x706F4B0", Offset = "0x706DCB0", VA = "0x18706F4B0")]
	public static bool IMNFHDPIHLN(this HCHDGGNBPBF NOKEFBHBLPJ, [Out] DHJFLMOKEAF NNNOHEOEOFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x706F590", Offset = "0x706DD90", VA = "0x18706F590")]
	public static bool OGOILABIMHE(this HCHDGGNBPBF NOKEFBHBLPJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct IADOPPAOCPL : IEquatable<IADOPPAOCPL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly bool PABKHGDMMPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public readonly DateTime JMANMNCCIHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public readonly bool JPLKFJFPHHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly IAHCCPKAHLI? HPGPIIDGCLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly string HCEJJPGCODO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly int? JJPLIGIDODD;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public static IADOPPAOCPL HAFACAFOGHA
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x26F9790", Offset = "0x26F7F90", VA = "0x1826F9790")]
		get
		{
			return default(IADOPPAOCPL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x70703F0", Offset = "0x706EBF0", VA = "0x1870703F0")]
	public IADOPPAOCPL(DateTime GGBABKBPOEP, bool IJBMOLNBHPM, IAHCCPKAHLI? IEDBPDLCDHK, string DGOFGIGGHPM, int? HEKFCDPNNNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x706FEE0", Offset = "0x706E6E0", VA = "0x18706FEE0")]
	public DHJFLMOKEAF BNJFHBIJOCB(GIBKPHCLPMP NCEGKIPAPPN)
	{
		return default(DHJFLMOKEAF);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7070230", Offset = "0x706EA30", VA = "0x187070230")]
	private static DHJFLMOKEAF KEJODLJPNIK(GIBKPHCLPMP NCEGKIPAPPN, DateTime GGBABKBPOEP)
	{
		return default(DHJFLMOKEAF);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x706FF70", Offset = "0x706E770", VA = "0x18706FF70", Slot = "4")]
	public bool Equals(IADOPPAOCPL PGPJMFPAKOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x70700D0", Offset = "0x706E8D0", VA = "0x1870700D0", Slot = "0")]
	public override bool Equals(object PNHCNFOFAFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7070180", Offset = "0x706E980", VA = "0x187070180", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x70702B0", Offset = "0x706EAB0", VA = "0x1870702B0")]
	public static bool NIDGPKKMDPO(IADOPPAOCPL HKAFAMHBCLL, IADOPPAOCPL JAKFFJGMBEJ)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x70702E0", Offset = "0x706EAE0", VA = "0x1870702E0")]
	public static bool ONONOJDPAAN(IADOPPAOCPL HKAFAMHBCLL, IADOPPAOCPL JAKFFJGMBEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7070320", Offset = "0x706EB20", VA = "0x187070320", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct FODMAOOEOBP : IEquatable<FODMAOOEOBP>
{
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public static readonly FODMAOOEOBP HAFACAFOGHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly bool FFFKLPKJBMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly DHJFLMOKEAF ACAEOOCHPCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly IADOPPAOCPL COKNIOJLFCB;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x706E740", Offset = "0x706CF40", VA = "0x18706E740")]
	public FODMAOOEOBP(DHJFLMOKEAF NNNOHEOEOFF, IADOPPAOCPL LCEAJGOPJOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x706E2B0", Offset = "0x706CAB0", VA = "0x18706E2B0", Slot = "4")]
	public bool Equals(FODMAOOEOBP PGPJMFPAKOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x706E180", Offset = "0x706C980", VA = "0x18706E180", Slot = "0")]
	public override bool Equals(object PNHCNFOFAFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x706E360", Offset = "0x706CB60", VA = "0x18706E360", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x706E420", Offset = "0x706CC20", VA = "0x18706E420")]
	public static bool NIDGPKKMDPO(FODMAOOEOBP HKAFAMHBCLL, FODMAOOEOBP JAKFFJGMBEJ)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x706E530", Offset = "0x706CD30", VA = "0x18706E530")]
	public static bool ONONOJDPAAN(FODMAOOEOBP HKAFAMHBCLL, FODMAOOEOBP JAKFFJGMBEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x706E650", Offset = "0x706CE50", VA = "0x18706E650", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public enum DHJFLMOKEAF : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	None,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	Expired,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	Active
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class ILDGDLCBAAB : GIBKPHCLPMP
{
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public const string FLKNLCFBDHA = "ServerTime";

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private static readonly Stopwatch ODKAIIEJHNJ;

	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private static DateTimeOffset? HDKKBIEGBEJ;

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private static readonly ILDGDLCBAAB CHKHGNKGCIE;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public static GIBKPHCLPMP DJLOIKDDKCN
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7070B00", Offset = "0x706F300", VA = "0x187070B00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	internal static ILDGDLCBAAB PNPBIHGHAAL
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7070AB0", Offset = "0x706F2B0", VA = "0x187070AB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static DateTimeOffset EBGEEFBFKAK
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x7070830", Offset = "0x706F030", VA = "0x187070830")]
		get
		{
			return default(DateTimeOffset);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static DateTime DKCHADPDFJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x70707A0", Offset = "0x706EFA0", VA = "0x1870707A0")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public DateTime MOPBMCFHOCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x70709F0", Offset = "0x706F1F0", VA = "0x1870709F0", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public DateTimeOffset JHBEFLHNLCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7070990", Offset = "0x706F190", VA = "0x187070990", Slot = "5")]
		get
		{
			return default(DateTimeOffset);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	private ILDGDLCBAAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7070580", Offset = "0x706ED80", VA = "0x187070580")]
	internal static void AAPGCJJHDKF(DateTime? MKGLPEDMMGD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public enum KEOBFAFDPHN
{
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	Front,
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	Back
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public enum MAOBFFAJEAH
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	AnimatedPuppet,
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	Imposter
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[BDENCKNLAKO]
public class ACFMHBIMNNI : CKJDFPHEKDD, CPKMEDMFFBO, HDINHDBEFHC, NFLOLGCKCAF, DBFGNPPEILE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct CAGEAPADFHC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public ACFMHBIMNNI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x706C530", Offset = "0x706AD30", VA = "0x18706C530", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x706C8D0", Offset = "0x706B0D0", VA = "0x18706C8D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400003A")]
	[IgnoreDataMember]
	public static FLFFJCDCPLP NBGANMDBLAN;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public Guid ACPBCEPFHAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xF63890", Offset = "0xF62090", VA = "0x180F63890", Slot = "38")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0xF63950", Offset = "0xF62150", VA = "0x180F63950")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int LMEEILKOFMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xBD6AB0", Offset = "0xBD52B0", VA = "0x180BD6AB0", Slot = "39")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xC46540", Offset = "0xC44D40", VA = "0x180C46540")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public string ACOJEEABMOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x9DF790", Offset = "0x9DDF90", VA = "0x1809DF790", Slot = "40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x9DF780", Offset = "0x9DDF80", VA = "0x1809DF780")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public string NJJPEPDLCHL
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x9DF770", Offset = "0x9DDF70", VA = "0x1809DF770", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x9DF750", Offset = "0x9DDF50", VA = "0x1809DF750")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public int CFBMCPJNOHN
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x9FCF80", Offset = "0x9FB780", VA = "0x1809FCF80", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xD38EB0", Offset = "0xD376B0", VA = "0x180D38EB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public IDBDBALOLAF ABONPAANCAG
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x9FCF90", Offset = "0x9FB790", VA = "0x1809FCF90", Slot = "44")]
		[CompilerGenerated]
		get
		{
			return default(IDBDBALOLAF);
		}
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x144A290", Offset = "0x1448A90", VA = "0x18144A290")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool LNDCBIPDFJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0xBFD9F0", Offset = "0xBFC1F0", VA = "0x180BFD9F0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0xCC7800", Offset = "0xCC6000", VA = "0x180CC7800")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool MENKMGHAAIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xD52010", Offset = "0xD50810", VA = "0x180D52010", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xD50A40", Offset = "0xD4F240", VA = "0x180D50A40")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool EPBOHBIMKPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x1E23E20", Offset = "0x1E22620", VA = "0x181E23E20", Slot = "41")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x1E23300", Offset = "0x1E21B00", VA = "0x181E23300")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public int? EKOIFPKKKNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x706AD90", Offset = "0x7069590", VA = "0x18706AD90", Slot = "43")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x706ACC0", Offset = "0x70694C0", VA = "0x18706ACC0", Slot = "14")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public string EDPFEAEHFPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x9DD200", Offset = "0x9DBA00", VA = "0x1809DD200", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x9DD240", Offset = "0x9DBA40", VA = "0x1809DD240")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public string PMIPGFCAFPC
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x9DD230", Offset = "0x9DBA30", VA = "0x1809DD230", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x9DD1D0", Offset = "0x9DB9D0", VA = "0x1809DD1D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public string FEGKEMEANPK
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x9DD210", Offset = "0x9DBA10", VA = "0x1809DD210", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x9DD220", Offset = "0x9DBA20", VA = "0x1809DD220")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public DateTime OKKIKOGNGDL
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x9DD1C0", Offset = "0x9DB9C0", VA = "0x1809DD1C0", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xE28F40", Offset = "0xE27740", VA = "0x180E28F40")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public DateTime NEDBPOMOOOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x9DD1F0", Offset = "0x9DB9F0", VA = "0x1809DD1F0", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xE297B0", Offset = "0xE27FB0", VA = "0x180E297B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public KEOBFAFDPHN CKKFABDIILF
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xD7F590", Offset = "0xD7DD90", VA = "0x180D7F590", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return default(KEOBFAFDPHN);
		}
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xE6BF40", Offset = "0xE6A740", VA = "0x180E6BF40")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public string IDNLAMLPNJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x9E9310", Offset = "0x9E7B10", VA = "0x1809E9310", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x9E9320", Offset = "0x9E7B20", VA = "0x1809E9320")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public int GGNBKBNHGHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xC076F0", Offset = "0xC05EF0", VA = "0x180C076F0", Slot = "42")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0xC079F0", Offset = "0xC061F0", VA = "0x180C079F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public IReadOnlyList<EKFEIBCLMAK> KIIGHLOFGMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0xBCAEE0", Offset = "0xBC96E0", VA = "0x180BCAEE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x12B1DD0", Offset = "0x12B05D0", VA = "0x1812B1DD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public IReadOnlyList<LOHCFDIIBJF> PLHPBICJNCA
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xBCAEE0", Offset = "0xBC96E0", VA = "0x180BCAEE0", Slot = "37")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public AMOFOKFIPOB CLHPKDKNEBI
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x9E9390", Offset = "0x9E7B90", VA = "0x1809E9390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x9E9340", Offset = "0x9E7B40", VA = "0x1809E9340")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public string MNGILMGJJMA
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x706AA20", Offset = "0x7069220", VA = "0x18706AA20", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public BPEBJLOIJPB IFCMPJACFHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0xBCB360", Offset = "0xBC9B60", VA = "0x180BCB360", Slot = "24")]
		get
		{
			return default(BPEBJLOIJPB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public string NGHJMEDCGPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x706AA20", Offset = "0x7069220", VA = "0x18706AA20", Slot = "25")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public string DGFFOJPABFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x9DF790", Offset = "0x9DDF90", VA = "0x1809DF790", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool FFOBJAGEOJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0xA28A40", Offset = "0xA27240", VA = "0x180A28A40", Slot = "29")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public KKHKGMOAKDA EFOAOHHGDKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0xF46C70", Offset = "0xF45470", VA = "0x180F46C70", Slot = "30")]
		get
		{
			return default(KKHKGMOAKDA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public string FGDKEKLFOCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x9DECC0", Offset = "0x9DD4C0", VA = "0x1809DECC0", Slot = "31")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public NIJJFMMKHEB? HBIBOMOHFGP
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x706ACD0", Offset = "0x70694D0", VA = "0x18706ACD0", Slot = "32")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public NLJFLIJKFBN GCOEHDOHPKH
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0xBCB360", Offset = "0xBC9B60", VA = "0x180BCB360", Slot = "33")]
		get
		{
			return default(NLJFLIJKFBN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool LNDFPKHHBDN
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xA28A40", Offset = "0xA27240", VA = "0x180A28A40", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public ACFMHBIMNNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0xF60000", Offset = "0xF5E800", VA = "0x180F60000")]
	public ACFMHBIMNNI([Optional] Guid KAAGPNJIINH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x706AA40", Offset = "0x7069240", VA = "0x18706AA40", Slot = "35")]
	public void AOEGOOLELIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x706ABF0", Offset = "0x70693F0", VA = "0x18706ABF0", Slot = "36")]
	[AsyncStateMachine(typeof(CAGEAPADFHC))]
	public Task BKIAAJDPKIB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x706AD20", Offset = "0x7069520", VA = "0x18706AD20")]
	public ACFMHBIMNNI MCKFNIJNPJM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[BDENCKNLAKO]
public class PJDCNCDCFOP : HDINHDBEFHC
{
	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public string ACOJEEABMOC
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x9DF710", Offset = "0x9DDF10", VA = "0x1809DF710")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x9DF720", Offset = "0x9DDF20", VA = "0x1809DF720")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public string NJJPEPDLCHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x9DF700", Offset = "0x9DDF00", VA = "0x1809DF700")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public int CFBMCPJNOHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0xBD6AB0", Offset = "0xBD52B0", VA = "0x180BD6AB0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0xC46540", Offset = "0xC44D40", VA = "0x180C46540")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public int? EKOIFPKKKNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0xEABFC0", Offset = "0xEAA7C0", VA = "0x180EABFC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0xEABFF0", Offset = "0xEAA7F0", VA = "0x180EABFF0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public string EDPFEAEHFPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x9DF770", Offset = "0x9DDF70", VA = "0x1809DF770")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x9DF750", Offset = "0x9DDF50", VA = "0x1809DF750")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public IDBDBALOLAF ABONPAANCAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x9FCF80", Offset = "0x9FB780", VA = "0x1809FCF80")]
		[CompilerGenerated]
		get
		{
			return default(IDBDBALOLAF);
		}
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0xD38EB0", Offset = "0xD376B0", VA = "0x180D38EB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public KEOBFAFDPHN? CKKFABDIILF
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0xC78FE0", Offset = "0xC777E0", VA = "0x180C78FE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xC79030", Offset = "0xC77830", VA = "0x180C79030")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "4")]
	public void AOEGOOLELIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public PJDCNCDCFOP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[BDENCKNLAKO]
public class MICNONBIAOI : HDINHDBEFHC
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public int LMEEILKOFMI
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x9DD1A0", Offset = "0x9DB9A0", VA = "0x1809DD1A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x9EBF60", Offset = "0x9EA760", VA = "0x1809EBF60")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public int? EKOIFPKKKNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0xEABF80", Offset = "0xEAA780", VA = "0x180EABF80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0xEB4E30", Offset = "0xEB3630", VA = "0x180EB4E30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public string PMIPGFCAFPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x9DF730", Offset = "0x9DDF30", VA = "0x1809DF730")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x9DF740", Offset = "0x9DDF40", VA = "0x1809DF740")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public string EDPFEAEHFPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x9DF790", Offset = "0x9DDF90", VA = "0x1809DF790")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x9DF780", Offset = "0x9DDF80", VA = "0x1809DF780")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "4")]
	public void AOEGOOLELIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public MICNONBIAOI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[BDENCKNLAKO]
public class EPLGCLLPDJE : HDINHDBEFHC
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public int? EKOIFPKKKNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x9DF710", Offset = "0x9DDF10", VA = "0x1809DF710")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0xCDCAB0", Offset = "0xCDB2B0", VA = "0x180CDCAB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public string EDPFEAEHFPC
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x9DF700", Offset = "0x9DDF00", VA = "0x1809DF700")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "4")]
	public void AOEGOOLELIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public EPLGCLLPDJE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct DIABDEPEFOE
{
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public static int DCHHKKBJFLJ;

	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public static int FGJACFINFIA;

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public int CMPIKFADAMI
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0xA2A760", Offset = "0xA28F60", VA = "0x180A2A760")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x127A100", Offset = "0x1278900", VA = "0x18127A100")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public int GIBGLINMLEN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x706D540", Offset = "0x706BD40", VA = "0x18706D540")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public static DIABDEPEFOE CONOIFPANGO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x706D4F0", Offset = "0x706BCF0", VA = "0x18706D4F0")]
		get
		{
			return default(DIABDEPEFOE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x706D5E0", Offset = "0x706BDE0", VA = "0x18706D5E0")]
	public DIABDEPEFOE(int LMFHKDKPGFI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[BDENCKNLAKO]
public class FHJGMMLJMFO : HDINHDBEFHC
{
	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public int JCGDKOOBCEK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x9DD1A0", Offset = "0x9DB9A0", VA = "0x1809DD1A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x9EBF60", Offset = "0x9EA760", VA = "0x1809EBF60")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public int? HKJOOEMLOEO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0xEABF80", Offset = "0xEAA780", VA = "0x180EABF80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0xEB4E30", Offset = "0xEB3630", VA = "0x180EB4E30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public string? LOFKFCJKLII
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x9DF730", Offset = "0x9DDF30", VA = "0x1809DF730")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x9DF740", Offset = "0x9DDF40", VA = "0x1809DF740")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x706E120", Offset = "0x706C920", VA = "0x18706E120")]
	public FHJGMMLJMFO(int NNJMLCCPAMG, int? EBGJINJOMEF, string? NJAAPDELBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public FHJGMMLJMFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "4")]
	public void AOEGOOLELIF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[BDENCKNLAKO]
public class PDAANDNBLFH : HDINHDBEFHC
{
	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public OAPJJHMCLAN.HKHDPGEAODK BAKEJJGHDGL
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x9DD1A0", Offset = "0x9DB9A0", VA = "0x1809DD1A0")]
		[CompilerGenerated]
		get
		{
			return default(OAPJJHMCLAN.HKHDPGEAODK);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x9EBF60", Offset = "0x9EA760", VA = "0x1809EBF60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public string JGLNLFIPCKG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x9DF700", Offset = "0x9DDF00", VA = "0x1809DF700")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public int? BFGMBCNFLON
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x9DF730", Offset = "0x9DDF30", VA = "0x1809DF730")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0xC79020", Offset = "0xC77820", VA = "0x180C79020")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "4")]
	public void AOEGOOLELIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public PDAANDNBLFH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface LOHCFDIIBJF
{
	[Cpp2IlInjected.Token(Token = "0x17000046")]
	long JPKINCGHIMK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	Guid ACPBCEPFHAA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	Guid CPEKFMPNMOI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	string JIOFECKBFNE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	string DCDFHCNMFOD
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	int DCHHGBFKGNL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	string PCIBPIMFNMM
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	string LMJNMJGNFBB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	string ACALBEEJAEB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	string PKBBNBLPAHN
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	int GGNBKBNHGHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[BDENCKNLAKO]
public class EKFEIBCLMAK : LOHCFDIIBJF, HDINHDBEFHC
{
	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public long JPKINCGHIMK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x9DF710", Offset = "0x9DDF10", VA = "0x1809DF710", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0xCDCAB0", Offset = "0xCDB2B0", VA = "0x180CDCAB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public Guid ACPBCEPFHAA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0xBEBD90", Offset = "0xBEA590", VA = "0x180BEBD90", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0xDA40F0", Offset = "0xDA28F0", VA = "0x180DA40F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public Guid CPEKFMPNMOI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x1256F40", Offset = "0x1255740", VA = "0x181256F40", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x12575D0", Offset = "0x1255DD0", VA = "0x1812575D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public DateTime OKKIKOGNGDL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x9E0DB0", Offset = "0x9DF5B0", VA = "0x1809E0DB0")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x9E4300", Offset = "0x9E2B00", VA = "0x1809E4300")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public string JIOFECKBFNE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x9E2460", Offset = "0x9E0C60", VA = "0x1809E2460", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x9E0DA0", Offset = "0x9DF5A0", VA = "0x1809E0DA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public string DCDFHCNMFOD
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x9E0DD0", Offset = "0x9DF5D0", VA = "0x1809E0DD0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x9E0BB0", Offset = "0x9DF3B0", VA = "0x1809E0BB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public int DCHHGBFKGNL
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0xCF7CF0", Offset = "0xCF64F0", VA = "0x180CF7CF0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0xE3E7C0", Offset = "0xE3CFC0", VA = "0x180E3E7C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public string PCIBPIMFNMM
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x9DD230", Offset = "0x9DBA30", VA = "0x1809DD230", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x9DD1D0", Offset = "0x9DB9D0", VA = "0x1809DD1D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public string LMJNMJGNFBB
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x9DD210", Offset = "0x9DBA10", VA = "0x1809DD210", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x9DD220", Offset = "0x9DBA20", VA = "0x1809DD220")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public string ACALBEEJAEB
	{
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x9DD1C0", Offset = "0x9DB9C0", VA = "0x1809DD1C0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x9DD1B0", Offset = "0x9DB9B0", VA = "0x1809DD1B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public string PKBBNBLPAHN
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x9DD1F0", Offset = "0x9DB9F0", VA = "0x1809DD1F0", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x9DD1E0", Offset = "0x9DB9E0", VA = "0x1809DD1E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public int GGNBKBNHGHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0xD7F590", Offset = "0xD7DD90", VA = "0x180D7F590", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0xE6BF40", Offset = "0xE6A740", VA = "0x180E6BF40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "15")]
	public void AOEGOOLELIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public EKFEIBCLMAK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[Flags]
public enum PBAMODLJKNO
{
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	Shirt = 1,
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	All = -1
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public enum EPMINODABBD
{
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	SearchScoreDescending,
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	HotScoreDescending,
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	Newest,
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	Oldest,
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	PriceAscending,
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	PriceDescending,
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	FeaturedFirst
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class OPGGFMANKGE
{
	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x7073B00", Offset = "0x7072300", VA = "0x187073B00")]
	public static int? PCNMPGCBMME(PBAMODLJKNO? EJDMAMNHOCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x7073A70", Offset = "0x7072270", VA = "0x187073A70")]
	public static int? HBFEHIHLPHI(EPMINODABBD? ANNBHGOMIIC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[BDENCKNLAKO]
public class KKMAPDJAMJN : HDINHDBEFHC
{
	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public string ACOJEEABMOC
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x9DF710", Offset = "0x9DDF10", VA = "0x1809DF710")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x9DF720", Offset = "0x9DDF20", VA = "0x1809DF720")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public string NJJPEPDLCHL
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x9DF700", Offset = "0x9DDF00", VA = "0x1809DF700")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public int? CFBMCPJNOHN
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x9DF730", Offset = "0x9DDF30", VA = "0x1809DF730")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0xC79020", Offset = "0xC77820", VA = "0x180C79020")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public IDBDBALOLAF? ABONPAANCAG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x9DF790", Offset = "0x9DDF90", VA = "0x1809DF790")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x9E0DE0", Offset = "0x9DF5E0", VA = "0x1809E0DE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "4")]
	public void AOEGOOLELIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public KKMAPDJAMJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[BDENCKNLAKO]
public class FCKBIMABIOA : KBMNKECBFGE, HDINHDBEFHC
{
	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public Guid ACPBCEPFHAA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0xF63890", Offset = "0xF62090", VA = "0x180F63890")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0xF63950", Offset = "0xF62150", VA = "0x180F63950")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public byte NLNKGOHMIHB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x9E0E00", Offset = "0x9DF600", VA = "0x1809E0E00")]
		[CompilerGenerated]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x9E0E10", Offset = "0x9DF610", VA = "0x1809E0E10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "4")]
	public void AOEGOOLELIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public FCKBIMABIOA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public static class FBDOINCDEJH
{
	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x706E000", Offset = "0x706C800", VA = "0x18706E000")]
	public static PENJJHBLLDC NGDPEOKNJEA(this FCKBIMABIOA NFOGFJOGLPE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface CKJDFPHEKDD
{
	[Cpp2IlInjected.Token(Token = "0x17000063")]
	Guid ACPBCEPFHAA
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	int LMEEILKOFMI
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	string ACOJEEABMOC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	string NJJPEPDLCHL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	int CFBMCPJNOHN
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	IDBDBALOLAF ABONPAANCAG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	bool LNDCBIPDFJF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	bool MENKMGHAAIM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	bool EPBOHBIMKPI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	int? EKOIFPKKKNO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "10")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	string EDPFEAEHFPC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	string PMIPGFCAFPC
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	string FEGKEMEANPK
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	DateTime OKKIKOGNGDL
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	DateTime NEDBPOMOOOA
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	KEOBFAFDPHN CKKFABDIILF
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	string IDNLAMLPNJE
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	int GGNBKBNHGHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	string MNGILMGJJMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x706CC50", Offset = "0x706B450", VA = "0x18706CC50", Slot = "19")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface DBFGNPPEILE
{
	[Cpp2IlInjected.Token(Token = "0x17000076")]
	IReadOnlyList<LOHCFDIIBJF> PLHPBICJNCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	Guid ACPBCEPFHAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	int LMEEILKOFMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	string ACOJEEABMOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	bool EPBOHBIMKPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	int GGNBKBNHGHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	int? EKOIFPKKKNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	IDBDBALOLAF ABONPAANCAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class IOCPFDBHMOF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private struct CEMPLHPDNGB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public IEnumerable<NFLOLGCKCAF> list;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x706C930", Offset = "0x706B130", VA = "0x18706C930", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x706CBD0", Offset = "0x706B3D0", VA = "0x18706CBD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x7070D00", Offset = "0x706F500", VA = "0x187070D00")]
	public static bool IGBGPCBALJP(this IEnumerable<HDINHDBEFHC> GIPAMJGJGNH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x7070C30", Offset = "0x706F430", VA = "0x187070C30")]
	[AsyncStateMachine(typeof(CEMPLHPDNGB))]
	public static Task DFPIJMDEHCJ(this IEnumerable<NFLOLGCKCAF> GIPAMJGJGNH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct COMDBKPAHPB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public readonly string LABGJIFHBPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public readonly string KLMGAAOGPNK;

	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public static readonly COMDBKPAHPB KHBPMGHIGAO;

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0xA81780", Offset = "0xA7FF80", VA = "0x180A81780")]
	public COMDBKPAHPB(string IAIFPKJLLJB, string EGAIPBFBDLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0xEC9A30", Offset = "0xEC8230", VA = "0x180EC9A30")]
	public bool GNBACMEALJB(COMDBKPAHPB PGPJMFPAKOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x706CDF0", Offset = "0x706B5F0", VA = "0x18706CDF0", Slot = "0")]
	public override bool Equals(object PNHCNFOFAFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x706CEC0", Offset = "0x706B6C0", VA = "0x18706CEC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x706CF30", Offset = "0x706B730", VA = "0x18706CF30")]
	public static bool NIDGPKKMDPO(COMDBKPAHPB HKAFAMHBCLL, COMDBKPAHPB JAKFFJGMBEJ)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x706CFB0", Offset = "0x706B7B0", VA = "0x18706CFB0")]
	public static bool ONONOJDPAAN(COMDBKPAHPB HKAFAMHBCLL, COMDBKPAHPB JAKFFJGMBEJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface BADHLLBMKOM
{
	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	GDCLKIOMFNO ILGJIFNMLEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	string DMGFFCPEBII
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	string PPEMHLFONHK
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	long AKLCKNFIMGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	string KDGFEFMBAPI
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	string DBKCGPOEECN
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	string FNMCOBJEMFN
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	string AHGNIGMJNCH
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[BDENCKNLAKO]
public class AJIPEMEOMNJ : GJPPOELLMFN
{
	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public string JADHOMPAIIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x9DF700", Offset = "0x9DDF00", VA = "0x1809DF700")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public HBLFPBHAAOA AGAHKFOOPKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0xBD6AB0", Offset = "0xBD52B0", VA = "0x180BD6AB0")]
		[CompilerGenerated]
		get
		{
			return default(HBLFPBHAAOA);
		}
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0xC46540", Offset = "0xC44D40", VA = "0x180C46540")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public JIALNPGKMCB CMHPLEEODMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0xCE6F70", Offset = "0xCE5770", VA = "0x180CE6F70")]
		[CompilerGenerated]
		get
		{
			return default(JIALNPGKMCB);
		}
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0xEF7300", Offset = "0xEF5B00", VA = "0x180EF7300")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public KFGFGMCADFD NOBNOMFJGFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x9EBF90", Offset = "0x9EA790", VA = "0x1809EBF90")]
		[CompilerGenerated]
		get
		{
			return default(KFGFGMCADFD);
		}
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x9EBF70", Offset = "0x9EA770", VA = "0x1809EBF70")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	[DataMember(Name = "Header")]
	public string? HGJMFIMIALB
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x9DF770", Offset = "0x9DDF70", VA = "0x1809DF770")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x9DF750", Offset = "0x9DDF50", VA = "0x1809DF750")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public string? CNEFPHCHBOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x9E0DB0", Offset = "0x9DF5B0", VA = "0x1809E0DB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x9E0DC0", Offset = "0x9DF5C0", VA = "0x1809E0DC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public string? KGIFLCJFBJC
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x9E2460", Offset = "0x9E0C60", VA = "0x1809E2460")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x9E0DA0", Offset = "0x9DF5A0", VA = "0x1809E0DA0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public List<string> FNLLMLNKFLP
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x9E0DD0", Offset = "0x9DF5D0", VA = "0x1809E0DD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x9E0BB0", Offset = "0x9DF3B0", VA = "0x1809E0BB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public List<BHDMAODBGLE> NDEMNBDDPLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x9DD200", Offset = "0x9DBA00", VA = "0x1809DD200")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x9DD240", Offset = "0x9DBA40", VA = "0x1809DD240")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x706B160", Offset = "0x7069960", VA = "0x18706B160", Slot = "5")]
	public override void AOEGOOLELIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x706B170", Offset = "0x7069970", VA = "0x18706B170")]
	public AJIPEMEOMNJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public enum OINJFMCJINL
{
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	Url,
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	AccountId,
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	EventId,
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	RoomName,
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	Storefront,
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	[Obsolete("6/4/21: This was only ever used for an announcement for Shawn's referral event, which is not happening again. Removing as part of a StackUI cleanup")]
	ActionCode,
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	Item,
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	CustomAvatarItem,
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	AuthorizedRecNetUrl,
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	Close
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public enum HBLFPBHAAOA
{
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	Vertical,
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	Horizontal
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public enum JIALNPGKMCB
{
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	Small,
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	Medium,
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	Large
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public enum KFGFGMCADFD
{
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	Before,
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	Overlay,
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	After
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[BDENCKNLAKO]
public class BHDMAODBGLE : HDINHDBEFHC
{
	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public OINJFMCJINL JGAJDGCAAKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x9DD1A0", Offset = "0x9DB9A0", VA = "0x1809DD1A0")]
		[CompilerGenerated]
		get
		{
			return default(OINJFMCJINL);
		}
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x9EBF60", Offset = "0x9EA760", VA = "0x1809EBF60")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public string? JLDNHDIEHAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x9DF700", Offset = "0x9DDF00", VA = "0x1809DF700")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	[DataMember(Name = "LinkParameter")]
	public string? NPKHMPCCLFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x9DF730", Offset = "0x9DDF30", VA = "0x1809DF730")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x9DF740", Offset = "0x9DDF40", VA = "0x1809DF740")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public string? NPHELCPEANH
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x9DF790", Offset = "0x9DDF90", VA = "0x1809DF790")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x9DF780", Offset = "0x9DDF80", VA = "0x1809DF780")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "4")]
	public void AOEGOOLELIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public BHDMAODBGLE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public abstract class GJPPOELLMFN : HDINHDBEFHC
{
	[Cpp2IlInjected.Token(Token = "0x17000093")]
	[IgnoreDataMember]
	public string? KFNAJKPJEJG
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x9DF710", Offset = "0x9DDF10", VA = "0x1809DF710")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x9DF720", Offset = "0x9DDF20", VA = "0x1809DF720")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract void AOEGOOLELIF();

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x706F680", Offset = "0x706DE80", VA = "0x18706F680")]
	protected GJPPOELLMFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[BDENCKNLAKO]
public class AGFEPEBMION : HDINHDBEFHC
{
	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public string? NJPOPMFBJIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x9DF710", Offset = "0x9DDF10", VA = "0x1809DF710")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x9DF720", Offset = "0x9DDF20", VA = "0x1809DF720")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "4")]
	public void AOEGOOLELIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public AGFEPEBMION()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[BDENCKNLAKO]
public class IPDPOAHFKDO : HDINHDBEFHC
{
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	internal static Func<string, AJIPEMEOMNJ>? DGFMALLHICD;

	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	internal static Func<string, MIHKNPAFAPL>? HNMFMOCAFOC;

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public string? NJPOPMFBJIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x9DF710", Offset = "0x9DDF10", VA = "0x1809DF710")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x9DF720", Offset = "0x9DDF20", VA = "0x1809DF720")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public string? KMGJCMGKCGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x9DF700", Offset = "0x9DDF00", VA = "0x1809DF700")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public bool DAAFBILMJEA
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x9E0E00", Offset = "0x9DF600", VA = "0x1809E0E00")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x9E0E10", Offset = "0x9DF610", VA = "0x1809E0E10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public IAHCCPKAHLI JHBPFKBLDNC
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0xCE6F70", Offset = "0xCE5770", VA = "0x180CE6F70")]
		[CompilerGenerated]
		get
		{
			return default(IAHCCPKAHLI);
		}
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0xEF7300", Offset = "0xEF5B00", VA = "0x180EF7300")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public OEKNDJBDCIH GPPNKBKOEFO
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x9EBF90", Offset = "0x9EA790", VA = "0x1809EBF90")]
		[CompilerGenerated]
		get
		{
			return default(OEKNDJBDCIH);
		}
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x9EBF70", Offset = "0x9EA770", VA = "0x1809EBF70")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public int MLANLEIGIEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0xC4B9C0", Offset = "0xC4A1C0", VA = "0x180C4B9C0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x1388660", Offset = "0x1386E60", VA = "0x181388660")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public DateTime FOJIEDDPHIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x9DF770", Offset = "0x9DDF70", VA = "0x1809DF770")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x9E0DF0", Offset = "0x9DF5F0", VA = "0x1809E0DF0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	[DataMember(Name = "IsRead")]
	internal bool CHLMIOAMNAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0xD58CC0", Offset = "0xD574C0", VA = "0x180D58CC0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0xD58CE0", Offset = "0xD574E0", VA = "0x180D58CE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	[IgnoreDataMember]
	public bool EBNPBDFDDPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0xD58CD0", Offset = "0xD574D0", VA = "0x180D58CD0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0xD58CF0", Offset = "0xD574F0", VA = "0x180D58CF0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public LCGBAOLGJAD IMHEBHFIGAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x9FCF90", Offset = "0x9FB790", VA = "0x1809FCF90")]
		[CompilerGenerated]
		get
		{
			return default(LCGBAOLGJAD);
		}
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x144A290", Offset = "0x1448A90", VA = "0x18144A290")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public GHGALKPFCKJ PGNLGPDDKED
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x9EDEE0", Offset = "0x9EC6E0", VA = "0x1809EDEE0")]
		[CompilerGenerated]
		get
		{
			return default(GHGALKPFCKJ);
		}
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0xDF1550", Offset = "0xDEFD50", VA = "0x180DF1550")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	internal string? APAFGBIEFEN
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x9E0DD0", Offset = "0x9DF5D0", VA = "0x1809E0DD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x9E0BB0", Offset = "0x9DF3B0", VA = "0x1809E0BB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	[IgnoreDataMember]
	public AJIPEMEOMNJ? KFOMBHMHAAD
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x7070F40", Offset = "0x706F740", VA = "0x187070F40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	[IgnoreDataMember]
	public MIHKNPAFAPL? PNHEMENNDDI
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x70712E0", Offset = "0x706FAE0", VA = "0x1870712E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	[IgnoreDataMember]
	public GJPPOELLMFN? AJCIEMJKPDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x9DD200", Offset = "0x9DBA00", VA = "0x1809DD200")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x9DD240", Offset = "0x9DBA40", VA = "0x1809DD240")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x7070FC0", Offset = "0x706F7C0", VA = "0x187070FC0", Slot = "4")]
	public void AOEGOOLELIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0xA09500", Offset = "0xA07D00", VA = "0x180A09500")]
	public IPDPOAHFKDO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[BDENCKNLAKO]
public class EBFNBFICLGM : HDINHDBEFHC
{
	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public AHPBNKGKHHF DHNIIBFKOCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x9DD1A0", Offset = "0x9DB9A0", VA = "0x1809DD1A0")]
		[CompilerGenerated]
		get
		{
			return default(AHPBNKGKHHF);
		}
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x9EBF60", Offset = "0x9EA760", VA = "0x1809EBF60")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public string PJHGODHDKHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x9DF700", Offset = "0x9DDF00", VA = "0x1809DF700")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public int LNDKBIIOLNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0xBD6AB0", Offset = "0xBD52B0", VA = "0x180BD6AB0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0xC46540", Offset = "0xC44D40", VA = "0x180C46540")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "4")]
	public void AOEGOOLELIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x706DE60", Offset = "0x706C660", VA = "0x18706DE60")]
	public EBFNBFICLGM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[BDENCKNLAKO]
public class MIHKNPAFAPL : GJPPOELLMFN
{
	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public string DCDLIDOFHJH
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x9DF700", Offset = "0x9DDF00", VA = "0x1809DF700")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public string? ACOJEEABMOC
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x9DF730", Offset = "0x9DDF30", VA = "0x1809DF730")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x9DF740", Offset = "0x9DDF40", VA = "0x1809DF740")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public GKLJGJGBIOF KAECCKELDPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x9EBF90", Offset = "0x9EA790", VA = "0x1809EBF90")]
		[CompilerGenerated]
		get
		{
			return default(GKLJGJGBIOF);
		}
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x9EBF70", Offset = "0x9EA770", VA = "0x1809EBF70")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	[DataMember(Name = "all_conditions_required")]
	public bool KHMBCFEDDIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x15423D0", Offset = "0x1540BD0", VA = "0x1815423D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0xEE7DA0", Offset = "0xEE65A0", VA = "0x180EE7DA0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public List<EBFNBFICLGM> KLDBDDBOGAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x9DF770", Offset = "0x9DDF70", VA = "0x1809DF770")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x9DF750", Offset = "0x9DDF50", VA = "0x1809DF750")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x70731F0", Offset = "0x70719F0", VA = "0x1870731F0", Slot = "5")]
	public override void AOEGOOLELIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x7073200", Offset = "0x7071A00", VA = "0x187073200")]
	public MIHKNPAFAPL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public enum GHGALKPFCKJ
{
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	Unknown,
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	ContentBlock,
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	JustInTimeTutorialTrigger
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public enum LCGBAOLGJAD
{
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	Announcements,
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	JustInTimeTutorials
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public enum GKLJGJGBIOF
{
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	Unknown,
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	MakerPenButtonHighlight,
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	MakerAIIntroTutorial
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public enum AHPBNKGKHHF
{
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	EnteredRoom,
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	TimeInRoom,
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	ObjectInteractionRoom,
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	StartedMakerAI
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface MJJDDHGCHAI
{
	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	bool OPOBCCMHEMA
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	HOPADDCECBJ<IPDPOAHFKDO> OPHHCCNBLHP
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	HOPADDCECBJ<string> OIMPDJKOCGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	HOPADDCECBJ<IPDPOAHFKDO> ECDAMKOFPJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	HOPADDCECBJ<IPDPOAHFKDO> IGMNNJOCNCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IReadOnlyList<IPDPOAHFKDO> PACHJEFLFPB(LCGBAOLGJAD DOOLFGIGJNJ);

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<IPDPOAHFKDO> JJIEHPADEII(LCGBAOLGJAD DOOLFGIGJNJ);

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IPDPOAHFKDO DANLIEJHDJP(LCGBAOLGJAD DOOLFGIGJNJ, string DJCKFOHNIOM);

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IPDPOAHFKDO IAMFPCJBNBK(LCGBAOLGJAD DOOLFGIGJNJ);

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool HENGOLNJNIG(LCGBAOLGJAD DOOLFGIGJNJ);

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int JPLJNONALPD(LCGBAOLGJAD DOOLFGIGJNJ);

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task OHNEMOLKICN();

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task DIPLCKKEFPO(IPDPOAHFKDO NJAAPDELBNN);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public interface PLBGOAOMEFP
{
	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	CEHFFIEONLE PKMEHMPEDFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	int HFECNLHAEGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	bool OILBKJOHKEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	bool JMCNPLHODJM
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	bool PLMIFFBKDDG
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	bool LJMKFOMNLKP
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	bool EKJEIJKPJBK
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	bool AADIKPPOIFO
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	bool KGNEBBEGPDE
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action GIAPCHINPGC;

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(Slot = "11")]
	KJPDFMLMKLI<EDCALICBMOK> MNPMCIAKHKF(int DCILOEIKONN);

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(Slot = "12")]
	ELBPMMKABPA PJGOGEADMNO(DateTime MCPJJHLJJGM);

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(Slot = "13")]
	ELBPMMKABPA MCMJEHHJHLN(string BEBBNKFFBDE);

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Task FMBHMJICMPK([Optional] CancellationToken DNHBNMHIDAC);
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public enum AKJBGKAIMKK
{
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	Memory,
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	Multiplayer
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class CLAKKALHCEL
{
	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x706CD10", Offset = "0x706B510", VA = "0x18706CD10")]
	public static string CJACHDEBJLP(this AKJBGKAIMKK IPLENNNENDP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface LFGDLKAKOJC
{
	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<List<IPDPOAHFKDO>> HMOMOLBNAMC(LCGBAOLGJAD DOOLFGIGJNJ);

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task DIPLCKKEFPO(string DJCKFOHNIOM);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface IICNNFMBHCL
{
	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<LABAENODJCG> JDJALFEFIAE();
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface EFOMCLALCFN
{
	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KJPDFMLMKLI<List<LBMPENJMNCI>> LEMJIJJKGGO();

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(Slot = "1")]
	KJPDFMLMKLI<List<LBMPENJMNCI>> KJJEDKJAJHJ();

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<List<LBMPENJMNCI>> CCJEBCECILK([Optional] CancellationToken DNHBNMHIDAC);

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	KJPDFMLMKLI<List<LBMPENJMNCI>> PMLNEPJMPDB(List<AJELBAFCNLN> CAPNIDFJLAE);

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	KJPDFMLMKLI<List<LBMPENJMNCI>> LOGCEFAAKJD(List<AJELBAFCNLN> CAPNIDFJLAE);
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface IOLAPEOHCCL
{
	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	List<DCIOEOOBAMK> HFDELONLGFM
	{
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action<KFLCGBIEDHD> GOIGPICNALM;

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	ELBPMMKABPA MGJHHCEOGMC(DCIOEOOBAMK DNFCMOGKFGA);

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	[Obsolete("Alternate gift contexts are being phased out. Use LocalRequestGiftPackage(GiftContext context, string message) instead")]
	KJPDFMLMKLI<DCIOEOOBAMK> CBJGJIAEANH(AKGOFIOCCAL KLNHOILIBHH, AKGOFIOCCAL? BBCIIDEEKLF, bool OAIKDFPJIIP, string NJAAPDELBNN);

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	KJPDFMLMKLI<DCIOEOOBAMK> CBJGJIAEANH(AKGOFIOCCAL KLNHOILIBHH, string NJAAPDELBNN);

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void PLEPAMDJKCE(DCIOEOOBAMK BNGMGHONBHC, bool BDEGFBFFNPA = false, bool GJJBGGCJIOA = false, bool KKBFMHJMAPJ = true);

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(Slot = "7")]
	KJPDFMLMKLI<List<DCIOEOOBAMK>> OJMBBONHJHA();
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface HAKJMCEGFCP
{
	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	string DMGNDAMHPLM
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	bool OPENCLEBAEL
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	ELBPMMKABPA GCFDPAIDDLB();

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ELBPMMKABPA DJHJBAHOGPH(string GCMKNNKLKDA, string NFIPNFAMBGG);

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ELBPMMKABPA BMFFHBGMFPP(string LPONCKEOFHG);

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DLMAAJENKII();

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task<CEJAKCPDCOP> HHLCMGDEJMN(string BEBBNKFFBDE, string LPONCKEOFHG, bool MPPLBNKMBHB, string LBCMHKPFKGC, string NCJGPCMPFJF, [Optional] CancellationToken DNHBNMHIDAC);

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task AFKJBHBPPCJ(int DCILOEIKONN, string CMINDMLONDN, [Optional] CancellationToken DNHBNMHIDAC);

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Task DALGHCDINMF(int DCILOEIKONN, [Optional] CancellationToken DNHBNMHIDAC);

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Task EOJLEHEEJFO([Optional] AKJBGKAIMKK? FMLNGOAGHBN, [Optional] CancellationToken DNHBNMHIDAC);

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Task<IReadOnlyList<KOGELNCIALD>> FHIGODNCIBG([Optional] CancellationToken DNHBNMHIDAC);

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task GMOFDMNNHHE([Optional] CancellationToken DNHBNMHIDAC);
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface MEDFPGBPJHB
{
	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<List<DFIBJNLLEPO>> NJECGLGCBNM([Optional] CancellationToken DNHBNMHIDAC);

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<List<ICADBOFBNJO>> DODPELKENDK([Optional] CancellationToken DNHBNMHIDAC);
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface FAOOOAGNCOI
{
	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task ICIAFONIPLO([Optional] CancellationToken DNHBNMHIDAC);

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GOCJGLJFFGK();
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public interface KHDICHPDAPP
{
	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event HLAAGFFGDJN? ACLHDPMEFPL;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event HLAAGFFGDJN? BBPOHPFJIMI;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event HLAAGFFGDJN? HKPJFANCPPE;

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task<BOIHPHGPMPK> NBNIGFCJDGA();

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task<BOIHPHGPMPK?>? EPKENCCMPBN(int DCILOEIKONN);

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Task<List<KOIKGCPOBMM>> GAFCFLCFEBN(List<int> PHOFJMNHHBH);

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Task<IReadOnlyDictionary<int, BOIHPHGPMPK>> NGEHNLOGAHB();

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Task<List<BOIHPHGPMPK?>?>? MBJJLAMLALH(int DCILOEIKONN);

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task HJAGLFOOKJE(int OPKLODOCMCI);

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task<KFNGEGFGHNK> FBHDGCMMOBM(BOIHPHGPMPK PFDIFCADNMH);
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public delegate void HLAAGFFGDJN(int DCILOEIKONN, int OPKLODOCMCI, BOIHPHGPMPK? PFDIFCADNMH);
[Cpp2IlInjected.Token(Token = "0x2000044")]
public interface FLFFJCDCPLP
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[Flags]
	public enum NNCGFINGNCE
	{
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		FilterProfanity = 1,
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		FilterURL = 2
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	string BBHBOHJONEB
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	GCEOHBAELHJ BOLKAPIMPLO
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	IAHCCPKAHLI JHBPFKBLDNC
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	string HCEJJPGCODO
	{
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	byte GOHHCLICJEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	int MFCPNPDCKOD
	{
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	int FJIFFKGJGPI
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	bool IKMEMLEBDDP
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	bool DONJPPMMHFE
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	bool AMEPEBEHBNI
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	bool OGKMJAKMMLD
	{
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	bool LBILEBHCMLL
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	bool ANDLDBOLDFB
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	bool GKBDFCAGPLG
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(Slot = "4")]
	KJPDFMLMKLI<string> ANGOFLPAAFE();

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<string> LDCFFJNDGBG();

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(Slot = "15")]
	KJPDFMLMKLI<bool> IsPlayerCommunicationRestricted(int DCILOEIKONN);

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(Slot = "16")]
	string MGGNGABBBGK(string GLGOHIJMLFB, bool FBBBBDCCOIK = true);

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Task<string> APHCIHGCCGJ(string GLGOHIJMLFB, bool FBBBBDCCOIK = true);

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(Slot = "18")]
	KJPDFMLMKLI<string> MakeRoomNameAdhereToPlatformRequirements(long MDLDCACFGIB, string GLGOHIJMLFB);

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(Slot = "19")]
	bool SanitizeDisplayText(string GDHAMHCOHMI, NNCGFINGNCE APBHGDDFGKJ = NNCGFINGNCE.FilterProfanity | NNCGFINGNCE.FilterURL);

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(Slot = "20")]
	Task<string> SanitizeDisplayTextAsync(string GDHAMHCOHMI, NNCGFINGNCE APBHGDDFGKJ = NNCGFINGNCE.FilterProfanity | NNCGFINGNCE.FilterURL, bool LLGKCNJKGCH = false);

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(Slot = "21")]
	bool CheckNameForProfanity(string GLGOHIJMLFB, NNCGFINGNCE APBHGDDFGKJ = NNCGFINGNCE.FilterProfanity | NNCGFINGNCE.FilterURL);

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(Slot = "23")]
	KJPDFMLMKLI<string> GetCommerceSubscriptionAccessToken();
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public interface GDCKMPECBAN
{
	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<List<IKPHFAHHOFF>> KMCOONPCKGM([Optional] CancellationToken DNHBNMHIDAC);
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface PGABMFDMFFM
{
	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MDHICBENJEM(byte[] EGAIPBFBDLP, byte[] JEFALOIBONH);
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public interface AOGPILKFBDF
{
	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task HMKEDOFPCCE(string OGGMBJHOGMD);
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public interface BLCGDLHHKLL
{
	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	HOPADDCECBJ<OMEKGGFLNKA> KIJBGLNHPPO
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<bool> IPFIPAHFBFH(string GGJHNOCCFNF);

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<JJOCNNDDEEE> GJPIIEPAMBF(string GGJHNOCCFNF, string HKLHGMEOADD);

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task IMPKBABJECG(string GGJHNOCCFNF, IEnumerable<string> IKEAFJEKLCE, int JFNCDOKKMIN = 0);

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task<List<MLGCIODNMCL<FilteredTextDTO>>> OGJAGEHAOMK(uint LEOMMPEBBPM, IEnumerable<string> IKEAFJEKLCE);
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public interface IGBKAJGFBKN
{
	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KCNPEHHMKKM([Out] bool OPMIAMEJKDH);

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KIINELPOONH([Out] bool OPMIAMEJKDH);

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool LEANBMKACGA([Out] int OPMIAMEJKDH);
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public enum NOIELDIGMHO
{
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	BasedOnBirthday,
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	ModerationOverride,
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	PendingOverride
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public enum BGHDGEPHCBH
{
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	Id,
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	Email,
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	Phone
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
[Flags]
public enum CMCGBLCFDLM
{
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	SheHer = 1,
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	HeHim = 2,
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	TheyThem = 4,
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	ZeHir = 8,
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	ZeZir = 0x10,
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	XeXem = 0x20
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
[Flags]
public enum GOFFNMMINHD
{
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	LGBTQIA = 1,
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	Transgender = 2,
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	Bisexual = 4,
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	Lesbian = 8,
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	Pansexual = 0x10,
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	Asexual = 0x20,
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	Intersex = 0x40,
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	Genderqueer = 0x80,
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	Nonbinary = 0x100,
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	Aromantic = 0x200
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public enum MCFKBDOMEJB
{
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	Daily = 10,
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	Weekly = 20,
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	Monthly = 30,
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	Never = 40,
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	Yes = 50
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public enum NIPBJOOPOPL
{
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	BELOW_TEN = 0,
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	BETWEEN_TEN_AND_TWELVE = 10,
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	TEEN = 13,
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	ADULT = 18,
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	UNKNOWN = 999
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public interface EDCALICBMOK
{
	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	int HIGADEKDBLE
	{
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	string AMEJBAKFGJE
	{
		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	string BPHMKEGIIPB
	{
		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	string IDKBHJKDOLA
	{
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	string FAIKDMLOLFN
	{
		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	string JHFNJLCJPEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	string GPNCGDKDDOE
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	bool HBFOHCEPHEC
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	bool MEIIHGABLIL
	{
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	CMCGBLCFDLM LFPPLGFBIHC
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	GOFFNMMINHD OCCFBEGAMPE
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	DateTime OKKIKOGNGDL
	{
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	bool? MFNGJKNGGKC
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void KKGDHBPEGLJ(bool CGPKHEACHHC);

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void ILCMDMGOKPN(bool OAKMMNLJGBO);
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public interface CEHFFIEONLE : EDCALICBMOK
{
	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	string POJJHEAOGAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	string FIIDJNLKHPM
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	DateTime? PBBKECAIBCI
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	NOIELDIGMHO LLPKFFENPGP
	{
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	int? PFLPCFFKIEC
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	int HIBMMAMMKJA
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	bool HKLCJDAPDHN
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	bool KCFKENMLALJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	bool? OJCPJMBLEMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class LLJFLGIMKEJ
{
	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	public EDCALICBMOK ILEOJGJONOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x9DF710", Offset = "0x9DDF10", VA = "0x1809DF710")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	public BGHDGEPHCBH FOCNIKBEHEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x9E9470", Offset = "0x9E7C70", VA = "0x1809E9470")]
		[CompilerGenerated]
		get
		{
			return default(BGHDGEPHCBH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	public string NCPOGNAEHOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x9DF730", Offset = "0x9DDF30", VA = "0x1809DF730")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x69FE590", Offset = "0x69FCD90", VA = "0x1869FE590")]
	public LLJFLGIMKEJ(EDCALICBMOK IBKCOAFDMDK, BGHDGEPHCBH LCIEOBCLCOO, string ILNHEDIICKK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public interface OMIDMGELEFI
{
	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	int HIGADEKDBLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	bool IOIMGKIHHON
	{
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public interface AKGNIJLBDOC
{
	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	int HIGADEKDBLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	bool LPPIDDPEAOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public interface FOEFEOAOGLE
{
	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	int HIGADEKDBLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	string HCDAJFKCHJC
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public enum NIJJFMMKHEB
{
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	Outfit,
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	HairDye,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	CustomOutfit
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public class LBMPENJMNCI
{
	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	public NIJJFMMKHEB HBIBOMOHFGP
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x9DD1A0", Offset = "0x9DB9A0", VA = "0x1809DD1A0")]
		[CompilerGenerated]
		get
		{
			return default(NIJJFMMKHEB);
		}
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x9EBF60", Offset = "0x9EA760", VA = "0x1809EBF60")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	public string DGFFOJPABFM
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x9DF700", Offset = "0x9DDF00", VA = "0x1809DF700")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	public string PDKMFGBEPMG
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x9DF730", Offset = "0x9DDF30", VA = "0x1809DF730")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x9DF740", Offset = "0x9DDF40", VA = "0x1809DF740")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	public KKHKGMOAKDA EFOAOHHGDKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x9EBF90", Offset = "0x9EA790", VA = "0x1809EBF90")]
		[CompilerGenerated]
		get
		{
			return default(KKHKGMOAKDA);
		}
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x9EBF70", Offset = "0x9EA770", VA = "0x1809EBF70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	public string FBOHCIPDAIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x9DF770", Offset = "0x9DDF70", VA = "0x1809DF770")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x9DF750", Offset = "0x9DDF50", VA = "0x1809DF750")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	public int FJJLDHGENBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x9FCF80", Offset = "0x9FB780", VA = "0x1809FCF80")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0xD38EB0", Offset = "0xD376B0", VA = "0x180D38EB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	public bool PEKKPHLCGNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0xDFC880", Offset = "0xDFB080", VA = "0x180DFC880")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0xDFC280", Offset = "0xDFAA80", VA = "0x180DFC280")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	public AJELBAFCNLN KGFHCIEFHKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x12678A0", Offset = "0x12660A0", VA = "0x1812678A0")]
		[CompilerGenerated]
		get
		{
			return default(AJELBAFCNLN);
		}
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x70723F0", Offset = "0x7070BF0", VA = "0x1870723F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	public HHIJJAHMBEN CHDENKJAIEI
	{
		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x190AE30", Offset = "0x1909630", VA = "0x18190AE30")]
		[CompilerGenerated]
		get
		{
			return default(HHIJJAHMBEN);
		}
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x48DA2E0", Offset = "0x48D8AE0", VA = "0x1848DA2E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	public string DBLBIJEBJAG
	{
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x9E9310", Offset = "0x9E7B10", VA = "0x1809E9310")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x9E9320", Offset = "0x9E7B20", VA = "0x1809E9320")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	public DateTime OKKIKOGNGDL
	{
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x9E9400", Offset = "0x9E7C00", VA = "0x1809E9400")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x65C4A30", Offset = "0x65C3230", VA = "0x1865C4A30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x7072550", Offset = "0x7070D50", VA = "0x187072550")]
	internal LBMPENJMNCI(AKHFHCDCMGG IJDHDLICCCO, GJKCLLPHCAN MBAEAPFMAEC, HABBFPCILCO CCNONNFOJHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x7072410", Offset = "0x7070C10", VA = "0x187072410")]
	public LBMPENJMNCI(NIJJFMMKHEB EBBCCBJKFBI = NIJJFMMKHEB.Outfit, [Optional] AJELBAFCNLN BMKOKGKGFID, [Optional] string PANEKIAKHIH, [Optional] string NCHBNCOKHCB, KKHKGMOAKDA KNGKAICMNCJ = KKHKGMOAKDA.Common, [Optional] string GHGAHCPEBCH, int IOFOJGFFCHA = 0, bool OIGNNJNNBLA = false, [Optional] string FGFIEFLLKDF, [Optional] DateTime? LIHJPHMPNOL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
[BDENCKNLAKO]
public class AKHFHCDCMGG : HDINHDBEFHC
{
	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	public NIJJFMMKHEB HBIBOMOHFGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x9DD1A0", Offset = "0x9DB9A0", VA = "0x1809DD1A0")]
		[CompilerGenerated]
		get
		{
			return default(NIJJFMMKHEB);
		}
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x9EBF60", Offset = "0x9EA760", VA = "0x1809EBF60")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	[DataMember(Name = "AvatarItemDesc")]
	public string KJBFKFOKEGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x9DF700", Offset = "0x9DDF00", VA = "0x1809DF700")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	public string DGFFOJPABFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x9DF730", Offset = "0x9DDF30", VA = "0x1809DF730")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x9DF740", Offset = "0x9DDF40", VA = "0x1809DF740")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	public string PDKMFGBEPMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x9DF790", Offset = "0x9DDF90", VA = "0x1809DF790")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x9DF780", Offset = "0x9DDF80", VA = "0x1809DF780")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	public KKHKGMOAKDA EFOAOHHGDKA
	{
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x9E4120", Offset = "0x9E2920", VA = "0x1809E4120")]
		[CompilerGenerated]
		get
		{
			return default(KKHKGMOAKDA);
		}
		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x9E4110", Offset = "0x9E2910", VA = "0x1809E4110")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	public string FBOHCIPDAIO
	{
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x9E0DB0", Offset = "0x9DF5B0", VA = "0x1809E0DB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x9E0DC0", Offset = "0x9DF5C0", VA = "0x1809E0DC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	public int FJJLDHGENBG
	{
		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x9EDEE0", Offset = "0x9EC6E0", VA = "0x1809EDEE0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0xDF1550", Offset = "0xDEFD50", VA = "0x180DF1550")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	public bool PEKKPHLCGNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x1647D70", Offset = "0x1646570", VA = "0x181647D70")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x1655DA0", Offset = "0x16545A0", VA = "0x181655DA0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	public string IMLIMGLNMDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x9E0DD0", Offset = "0x9DF5D0", VA = "0x1809E0DD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x9E0BB0", Offset = "0x9DF3B0", VA = "0x1809E0BB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	public DateTime OKKIKOGNGDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x9DD200", Offset = "0x9DBA00", VA = "0x1809DD200")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0xDFC260", Offset = "0xDFAA60", VA = "0x180DFC260")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "4")]
	public void AOEGOOLELIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public AKHFHCDCMGG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
[BDENCKNLAKO]
public sealed class KNAEBAHNHLL : HDINHDBEFHC
{
	[Cpp2IlInjected.Token(Token = "0x17000100")]
	public List<string> KNGLPMAINDP
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x9DF710", Offset = "0x9DDF10", VA = "0x1809DF710")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x9DF720", Offset = "0x9DDF20", VA = "0x1809DF720")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x7072120", Offset = "0x7070920", VA = "0x187072120")]
	public KNAEBAHNHLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x9EBB90", Offset = "0x9EA390", VA = "0x1809EBB90")]
	public KNAEBAHNHLL(List<string> CAPNIDFJLAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "4")]
	public void AOEGOOLELIF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
[BDENCKNLAKO]
public class LABAENODJCG : HDINHDBEFHC
{
	[Cpp2IlInjected.Token(Token = "0x17000101")]
	public KMAFGLACFIP DKONMIFKDHC
	{
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x9DF710", Offset = "0x9DDF10", VA = "0x1809DF710")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x9DF720", Offset = "0x9DDF20", VA = "0x1809DF720")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	public PPBLFPMEBNF BLIADIEEJLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x9DF700", Offset = "0x9DDF00", VA = "0x1809DF700")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public LABAENODJCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x9E57C0", Offset = "0x9E3FC0", VA = "0x1809E57C0")]
	public LABAENODJCG(KMAFGLACFIP HIPKDPGEDOJ, PPBLFPMEBNF NMCCMGOKJLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "4")]
	public void AOEGOOLELIF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public enum HODOKHJEAOB
{
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	Braze,
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	Rengage
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public enum KFLHINMBLML : byte
{
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	APNS,
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	Firebase,
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	Mock,
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	Braze,
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	Rengage
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
[BDENCKNLAKO]
public class KMAFGLACFIP : HDINHDBEFHC
{
	[Cpp2IlInjected.Token(Token = "0x17000103")]
	public HODOKHJEAOB AMANPHFPCHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x9DD1A0", Offset = "0x9DB9A0", VA = "0x1809DD1A0")]
		[CompilerGenerated]
		get
		{
			return default(HODOKHJEAOB);
		}
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x9EBF60", Offset = "0x9EA760", VA = "0x1809EBF60")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	public KFLHINMBLML? MKOBJEJMHDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x2DB3630", Offset = "0x2DB1E30", VA = "0x182DB3630")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x6EFD780", Offset = "0x6EFBF80", VA = "0x186EFD780")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	public bool PCNGCJKCPPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x1D21BB0", Offset = "0x1D203B0", VA = "0x181D21BB0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x1D21D30", Offset = "0x1D20530", VA = "0x181D21D30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x7072040", Offset = "0x7070840", VA = "0x187072040")]
	public KMAFGLACFIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x7072050", Offset = "0x7070850", VA = "0x187072050")]
	public KMAFGLACFIP(HODOKHJEAOB DHANAGKACIE, KFLHINMBLML OJEIOCKDBAJ, bool EGJJJBBKPIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "4")]
	public void AOEGOOLELIF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
[BDENCKNLAKO]
public class PPBLFPMEBNF : HDINHDBEFHC
{
	[Cpp2IlInjected.Token(Token = "0x17000106")]
	public string PLFLPGEOLGI
	{
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x9DF710", Offset = "0x9DDF10", VA = "0x1809DF710")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x9DF720", Offset = "0x9DDF20", VA = "0x1809DF720")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	public string JOKJGEBNHKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x9DF700", Offset = "0x9DDF00", VA = "0x1809DF700")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public PPBLFPMEBNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x9E57C0", Offset = "0x9E3FC0", VA = "0x1809E57C0")]
	public PPBLFPMEBNF(string JENPKINIGHB, string BOGGAPOBJAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "4")]
	public void AOEGOOLELIF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public enum GCEOHBAELHJ
{
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	Unknown,
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	VR,
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	Screen,
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	Mobile,
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	VRLow,
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	Quest2
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public struct KFLCGBIEDHD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public DCIOEOOBAMK KBHAGFCHMBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	public bool OGIOBBFKBFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public bool IGNKGKDOGBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public bool FECGDEIHAIE;
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
[BDENCKNLAKO]
public class DCIOEOOBAMK : NFLOLGCKCAF, HDINHDBEFHC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private struct JGNPOMKGPPK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public DCIOEOOBAMK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x70718C0", Offset = "0x70700C0", VA = "0x1870718C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x7071A50", Offset = "0x7070250", VA = "0x187071A50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000131")]
	internal static Action<DCIOEOOBAMK> GBKHOPKGLCG;

	[Cpp2IlInjected.Token(Token = "0x4000132")]
	internal static Func<DCIOEOOBAMK, Task> HCMEJJFMLAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC1")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	[IgnoreDataMember]
	public bool GPMNMECBKJA;

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	public long? NGHJMEDCGPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0xF63890", Offset = "0xF62090", VA = "0x180F63890")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0xF63950", Offset = "0xF62150", VA = "0x180F63950")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	public int JIDJLPNJOBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0xBD6AB0", Offset = "0xBD52B0", VA = "0x180BD6AB0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0xC46540", Offset = "0xC44D40", VA = "0x180C46540")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	public int? JIGKJGLOGHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0xEABFC0", Offset = "0xEAA7C0", VA = "0x180EABFC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0xEABFF0", Offset = "0xEAA7F0", VA = "0x180EABFF0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	public string FGDKEKLFOCP
	{
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x9DF770", Offset = "0x9DDF70", VA = "0x1809DF770")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x9DF750", Offset = "0x9DDF50", VA = "0x1809DF750")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	public NIJJFMMKHEB? HBIBOMOHFGP
	{
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x9E0DB0", Offset = "0x9DF5B0", VA = "0x1809E0DB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x9E4300", Offset = "0x9E2B00", VA = "0x1809E4300")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	[DataMember(Name = "AvatarItemDesc")]
	public string CJKEEDLNADL
	{
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x9E2460", Offset = "0x9E0C60", VA = "0x1809E2460")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x9E0DA0", Offset = "0x9DF5A0", VA = "0x1809E0DA0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	public Guid? ACPBCEPFHAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x706D110", Offset = "0x706B910", VA = "0x18706D110")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x706D200", Offset = "0x706BA00", VA = "0x18706D200")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	public string NAIAKEEFGGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x9DD210", Offset = "0x9DBA10", VA = "0x1809DD210")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x9DD220", Offset = "0x9DBA20", VA = "0x1809DD220")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	public string OGAAIOAEIAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x9DD1C0", Offset = "0x9DB9C0", VA = "0x1809DD1C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x9DD1B0", Offset = "0x9DB9B0", VA = "0x1809DD1B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	public FIEOJKLGOND LDLCENPHCNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0xA06680", Offset = "0xA04E80", VA = "0x180A06680")]
		[CompilerGenerated]
		get
		{
			return default(FIEOJKLGOND);
		}
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x12C7F40", Offset = "0x12C6740", VA = "0x1812C7F40")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	public int HFDOGLFKDIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0xA066E0", Offset = "0xA04EE0", VA = "0x180A066E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x12C8760", Offset = "0x12C6F60", VA = "0x1812C8760")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	public int MDAKFFDEHBH
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0xD7F590", Offset = "0xD7DD90", VA = "0x180D7F590")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0xE6BF40", Offset = "0xE6A740", VA = "0x180E6BF40")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	public AKGOFIOCCAL IJMAMPKPIDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0xE12EB0", Offset = "0xE116B0", VA = "0x180E12EB0")]
		[CompilerGenerated]
		get
		{
			return default(AKGOFIOCCAL);
		}
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x13274E0", Offset = "0x1325CE0", VA = "0x1813274E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	public KKHKGMOAKDA EKCHOOKNLPG
	{
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0xBD1E40", Offset = "0xBD0640", VA = "0x180BD1E40")]
		[CompilerGenerated]
		get
		{
			return default(KKHKGMOAKDA);
		}
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x12FCC50", Offset = "0x12FB450", VA = "0x1812FCC50")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	[DataMember(Name = "Message")]
	public string IOPFKNEHIFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x9E9400", Offset = "0x9E7C00", VA = "0x1809E9400")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x9E92D0", Offset = "0x9E7AD0", VA = "0x1809E92D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	public string PLKKHHKCBDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0xBCAEE0", Offset = "0xBC96E0", VA = "0x180BCAEE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x12B1DD0", Offset = "0x12B05D0", VA = "0x1812B1DD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	public bool GCDEBNABKND
	{
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0xDFCA00", Offset = "0xDFB200", VA = "0x180DFCA00")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0xDFCA10", Offset = "0xDFB210", VA = "0x180DFCA10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	public IAHCCPKAHLI JHBPFKBLDNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0xD89A70", Offset = "0xD88270", VA = "0x180D89A70")]
		[CompilerGenerated]
		get
		{
			return default(IAHCCPKAHLI);
		}
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0xD884B0", Offset = "0xD86CB0", VA = "0x180D884B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	public OEKNDJBDCIH PPHJGBNMEBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x9E9330", Offset = "0x9E7B30", VA = "0x1809E9330")]
		[CompilerGenerated]
		get
		{
			return default(OEKNDJBDCIH);
		}
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x9E9370", Offset = "0x9E7B70", VA = "0x1809E9370")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	public LJOOEGFMDKC? JACLJDAPHAF
	{
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x706D210", Offset = "0x706BA10", VA = "0x18706D210")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x706D290", Offset = "0x706BA90", VA = "0x18706D290")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	public bool BONHBCJMCBL
	{
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x706D220", Offset = "0x706BA20", VA = "0x18706D220")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	public bool OIIHJPDKAMK
	{
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x706D2A0", Offset = "0x706BAA0", VA = "0x18706D2A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	public bool LCFINKDHPCI
	{
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x706D2C0", Offset = "0x706BAC0", VA = "0x18706D2C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	[IgnoreDataMember]
	public bool FBBPKGCLLEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x9EB330", Offset = "0x9E9B30", VA = "0x1809EB330")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x9EB320", Offset = "0x9E9B20", VA = "0x1809EB320")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	[IgnoreDataMember]
	public bool FFFKLPKJBMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x2AA2600", Offset = "0x2AA0E00", VA = "0x182AA2600")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x2AA2A10", Offset = "0x2AA1210", VA = "0x182AA2A10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	[IgnoreDataMember]
	public string INEDDIBOANH
	{
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0xBF9060", Offset = "0xBF7860", VA = "0x180BF9060")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0xE28C10", Offset = "0xE27410", VA = "0x180E28C10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	[IgnoreDataMember]
	public string IKBBIHCBLEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0xD206F0", Offset = "0xD1EEF0", VA = "0x180D206F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0xD20700", Offset = "0xD1EF00", VA = "0x180D20700")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000123")]
	[IgnoreDataMember]
	public bool FACCIKLHLHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0xF1E460", Offset = "0xF1CC60", VA = "0x180F1E460")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0xBB6A70", Offset = "0xBB5270", VA = "0x180BB6A70")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x706D0B0", Offset = "0x706B8B0", VA = "0x18706D0B0", Slot = "5")]
	public void AOEGOOLELIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x706D130", Offset = "0x706B930", VA = "0x18706D130", Slot = "6")]
	[AsyncStateMachine(typeof(JGNPOMKGPPK))]
	public virtual Task BKIAAJDPKIB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x13274E0", Offset = "0x1325CE0", VA = "0x1813274E0")]
	public void NLLAMKKMLKN(AKGOFIOCCAL KLNHOILIBHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public DCIOEOOBAMK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public interface DGDDAFDMFMN
{
	[Cpp2IlInjected.Token(Token = "0x17000124")]
	long AGHOEKJHDHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000125")]
	string JNJLNNBPPIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000126")]
	int JHKNDHDDGOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000127")]
	string ACOJEEABMOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	string NJJPEPDLCHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000129")]
	string CEPHECKGENM
	{
		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	string GFJBHKHMHCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	byte PBLNOAABPFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	int KHIHPCCLCEP
	{
		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	int LOLILOAGPDF
	{
		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	IDBDBALOLAF ABONPAANCAG
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	bool LNDCBIPDFJF
	{
		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000130")]
	DateTime NEDBPOMOOOA
	{
		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000131")]
	DateTime OKKIKOGNGDL
	{
		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000132")]
	DateTime? LHONOKNBKHB
	{
		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000133")]
	long? ADNCCDFGFIA
	{
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000134")]
	int FDFPOEJADNI
	{
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000135")]
	int NHDHENLOOMI
	{
		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000136")]
	int OAIOJHLGGLD
	{
		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000137")]
	HJMECHLICGN BMBJGBKLHJL
	{
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000138")]
	HJMECHLICGN GFCBCCPOMFL
	{
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000139")]
	bool BBKOPNNHIHI
	{
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	bool CFDDLJDHOEK
	{
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	bool EPBOHBIMKPI
	{
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	bool FHLDKFCGOPO
	{
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	int? CFBMCPJNOHN
	{
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	bool EMDCIKKGMAB
	{
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	string KNDKIMCLDKB
	{
		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MEEDLCEHHLA();

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GFNFOJFKGKO();
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
[BDENCKNLAKO]
public class HDCOCMJMLKL : HDINHDBEFHC
{
	[Cpp2IlInjected.Token(Token = "0x17000140")]
	public List<PGFHCNLIEKC> FHGFDMDLJNI
	{
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x9DF710", Offset = "0x9DDF10", VA = "0x1809DF710")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x9DF720", Offset = "0x9DDF20", VA = "0x1809DF720")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x706FB40", Offset = "0x706E340", VA = "0x18706FB40")]
	public List<string> PIPCPDPCKAN(params LAHGMBJNKFJ[] AGEKMPCIDAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x706FAC0", Offset = "0x706E2C0", VA = "0x18706FAC0")]
	public List<string> JGJECAFBFNC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x706FA70", Offset = "0x706E270", VA = "0x18706FA70")]
	public List<string> IJGCCCAOOOD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x706F980", Offset = "0x706E180", VA = "0x18706F980", Slot = "4")]
	public void AOEGOOLELIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public HDCOCMJMLKL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
[BDENCKNLAKO]
public class LLBNDJMOLDF : HDINHDBEFHC
{
	[Cpp2IlInjected.Token(Token = "0x17000141")]
	public int JHKNDHDDGOB
	{
		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x9DD1A0", Offset = "0x9DB9A0", VA = "0x1809DD1A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x9EBF60", Offset = "0x9EA760", VA = "0x1809EBF60")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "4")]
	public void AOEGOOLELIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public LLBNDJMOLDF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
[BDENCKNLAKO]
public class GAKFIBJDOGP : HDINHDBEFHC
{
	[Cpp2IlInjected.Token(Token = "0x17000142")]
	public long AGHOEKJHDHB
	{
		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x9DF710", Offset = "0x9DDF10", VA = "0x1809DF710")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0xCDCAB0", Offset = "0xCDB2B0", VA = "0x180CDCAB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	public string JNJLNNBPPIC
	{
		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x9DF700", Offset = "0x9DDF00", VA = "0x1809DF700")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000144")]
	public int JFHJBFPKKDO
	{
		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0xBD6AB0", Offset = "0xBD52B0", VA = "0x180BD6AB0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0xC46540", Offset = "0xC44D40", VA = "0x180C46540")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000145")]
	public bool HNHPICGMKGI
	{
		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0xCE8C70", Offset = "0xCE7470", VA = "0x180CE8C70")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0xCE8D90", Offset = "0xCE7590", VA = "0x180CE8D90")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	public int BEHGANENJKN
	{
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x9EBF90", Offset = "0x9EA790", VA = "0x1809EBF90")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x9EBF70", Offset = "0x9EA770", VA = "0x1809EBF70")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000147")]
	public int OIAABDHBAMP
	{
		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0xC4B9C0", Offset = "0xC4A1C0", VA = "0x180C4B9C0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x1388660", Offset = "0x1386E60", VA = "0x181388660")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000148")]
	public int ICHKJNFLKDD
	{
		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x9E4120", Offset = "0x9E2920", VA = "0x1809E4120")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x9E4110", Offset = "0x9E2910", VA = "0x1809E4110")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000149")]
	public int CODNOGCNEBM
	{
		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0xA1F270", Offset = "0xA1DA70", VA = "0x180A1F270")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0xA1EA50", Offset = "0xA1D250", VA = "0x180A1EA50")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014A")]
	public string HICEIKEDAEB
	{
		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x9E0DB0", Offset = "0x9DF5B0", VA = "0x1809E0DB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x9E0DC0", Offset = "0x9DF5C0", VA = "0x1809E0DC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	public string GAELEGHNKAL
	{
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x9E2460", Offset = "0x9E0C60", VA = "0x1809E2460")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x9E0DA0", Offset = "0x9DF5A0", VA = "0x1809E0DA0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014C")]
	public DateTime OKKIKOGNGDL
	{
		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x9E0DD0", Offset = "0x9DF5D0", VA = "0x1809E0DD0")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x6DAEEC0", Offset = "0x6DAD6C0", VA = "0x186DAEEC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	public IDBDBALOLAF? LCGINEDPHFH
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x9DD200", Offset = "0x9DBA00", VA = "0x1809DD200")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0xDFC260", Offset = "0xDFAA60", VA = "0x180DFC260")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014E")]
	public IReadOnlyList<Guid> JFMPMMLCHAH
	{
		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x9DD230", Offset = "0x9DBA30", VA = "0x1809DD230")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x9DD1D0", Offset = "0x9DB9D0", VA = "0x1809DD1D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014F")]
	public COMDBKPAHPB LIFJHPCBJML
	{
		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x706E770", Offset = "0x706CF70", VA = "0x18706E770")]
		get
		{
			return default(COMDBKPAHPB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "4")]
	public void AOEGOOLELIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x706E9A0", Offset = "0x706D1A0", VA = "0x18706E9A0", Slot = "0")]
	public override bool Equals(object PNHCNFOFAFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x706EA20", Offset = "0x706D220", VA = "0x18706EA20")]
	public bool GNBACMEALJB(GAKFIBJDOGP KLHONOJLOLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x706E7C0", Offset = "0x706CFC0", VA = "0x18706E7C0")]
	private bool EOJLDONIAPF(GAKFIBJDOGP KLHONOJLOLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x706EA30", Offset = "0x706D230", VA = "0x18706EA30")]
	private static bool OCEGCDHLEDC(IReadOnlyList<Guid> DDJKPGMBNIG, IReadOnlyList<Guid> MINOGAFMAPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x275B450", Offset = "0x2759C50", VA = "0x18275B450", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public GAKFIBJDOGP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
[BDENCKNLAKO]
public class OJKHMJDMOIN : HDINHDBEFHC
{
	[Cpp2IlInjected.Token(Token = "0x17000150")]
	public int AIPIGGGAIBE
	{
		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x9DD1A0", Offset = "0x9DB9A0", VA = "0x1809DD1A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x9EBF60", Offset = "0x9EA760", VA = "0x1809EBF60")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "4")]
	public void AOEGOOLELIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public OJKHMJDMOIN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
[BDENCKNLAKO]
public class PCOJEMOMCHL : HDINHDBEFHC
{
	[Cpp2IlInjected.Token(Token = "0x17000151")]
	public bool BPFOALPLDFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0xC47930", Offset = "0xC46130", VA = "0x180C47930")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0xC466E0", Offset = "0xC44EE0", VA = "0x180C466E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "4")]
	public void AOEGOOLELIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public PCOJEMOMCHL()
	{
	}
}
namespace RecNet
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[BDENCKNLAKO]
	public class NewInventionRequestDTO : HDINHDBEFHC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public string description;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public string imageName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public bool hasBetaContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public int instantiationCost;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public int lightsCost;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public int chipsCost;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public int cloudVariablesCost;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public int aiCost;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public byte ugcVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public long creationRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public string inventionDataFilename;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public List<long> referencedInventions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public IReadOnlyList<Guid> referencedUnityAssetIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public COICKFBCMHF creatorAccountRole;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public long? convertedFromInventionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public string displayMetadataJson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public string longDescription;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		public ModifyTagsRequest tagsRequest;

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0xE84E50", Offset = "0xE83650", VA = "0x180E84E50", Slot = "4")]
		public void AOEGOOLELIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x7073760", Offset = "0x7071F60", VA = "0x187073760")]
		public NewInventionRequestDTO()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[BDENCKNLAKO]
	public class AddVersionInventionRequestDTO : HDINHDBEFHC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		public long inventionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public bool hasBetaContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public int instantiationCost;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		public int lightsCost;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		public int chipsCost;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		public int cloudVariablesCost;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		public int aiCost;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public byte ugcVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		public long creationRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		public string inventionDataFilename;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public List<long> referencedInventions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public IReadOnlyList<Guid> referencedUnityAssetIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public ModifyTagsRequest tagsRequest;

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0xE84E50", Offset = "0xE83650", VA = "0x180E84E50", Slot = "4")]
		public void AOEGOOLELIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x706B450", Offset = "0x7069C50", VA = "0x18706B450")]
		public AddVersionInventionRequestDTO()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[BDENCKNLAKO]
	public class ModifyTagsRequest : HDINHDBEFHC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		public List<string> AutoTags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public List<string> CustomTags;

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "4")]
		public void AOEGOOLELIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public ModifyTagsRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[BDENCKNLAKO]
	public class InventionModifyTagsRequest : ModifyTagsRequest
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		public long InventionId;

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public InventionModifyTagsRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[BDENCKNLAKO]
	public class ReportRequest : HDINHDBEFHC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		public long InventionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public string Details;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public INFJKNPHHJL ReportCategory;

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "4")]
		public void AOEGOOLELIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public ReportRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[BDENCKNLAKO]
	public class CheerRequest : HDINHDBEFHC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public long InventionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public bool Cheer;

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "4")]
		public void AOEGOOLELIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public CheerRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[BDENCKNLAKO]
	public class UpdatePriceRequest : HDINHDBEFHC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public long InventionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public int Price;

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "4")]
		public void AOEGOOLELIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public UpdatePriceRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[BDENCKNLAKO]
	public class UpdateInventionMetadataRequest : HDINHDBEFHC
	{
		[Cpp2IlInjected.Token(Token = "0x17000152")]
		public long InventionId
		{
			[Cpp2IlInjected.Token(Token = "0x60002F0")]
			[Cpp2IlInjected.Address(RVA = "0x9DF710", Offset = "0x9DDF10", VA = "0x1809DF710")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x60002F1")]
			[Cpp2IlInjected.Address(RVA = "0xCDCAB0", Offset = "0xCDB2B0", VA = "0x180CDCAB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000153")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x60002F2")]
			[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002F3")]
			[Cpp2IlInjected.Address(RVA = "0x9DF700", Offset = "0x9DDF00", VA = "0x1809DF700")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000154")]
		public string Description
		{
			[Cpp2IlInjected.Token(Token = "0x60002F4")]
			[Cpp2IlInjected.Address(RVA = "0x9DF730", Offset = "0x9DDF30", VA = "0x1809DF730")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002F5")]
			[Cpp2IlInjected.Address(RVA = "0x9DF740", Offset = "0x9DDF40", VA = "0x1809DF740")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000155")]
		public string LongDescription
		{
			[Cpp2IlInjected.Token(Token = "0x60002F6")]
			[Cpp2IlInjected.Address(RVA = "0x9DF790", Offset = "0x9DDF90", VA = "0x1809DF790")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002F7")]
			[Cpp2IlInjected.Address(RVA = "0x9DF780", Offset = "0x9DDF80", VA = "0x1809DF780")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000156")]
		public string ImageName
		{
			[Cpp2IlInjected.Token(Token = "0x60002F8")]
			[Cpp2IlInjected.Address(RVA = "0x9DF770", Offset = "0x9DDF70", VA = "0x1809DF770")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002F9")]
			[Cpp2IlInjected.Address(RVA = "0x9DF750", Offset = "0x9DDF50", VA = "0x1809DF750")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000157")]
		public ModifyTagsRequest TagsRequest
		{
			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(RVA = "0x9E0DB0", Offset = "0x9DF5B0", VA = "0x1809E0DB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002FB")]
			[Cpp2IlInjected.Address(RVA = "0x9E0DC0", Offset = "0x9DF5C0", VA = "0x1809E0DC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0xE84E50", Offset = "0xE83650", VA = "0x180E84E50", Slot = "4")]
		public void AOEGOOLELIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public UpdateInventionMetadataRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[BDENCKNLAKO]
	public class UpdateInventionGeneralPermissionRequest : HDINHDBEFHC
	{
		[Cpp2IlInjected.Token(Token = "0x17000158")]
		public long InventionId
		{
			[Cpp2IlInjected.Token(Token = "0x60002FE")]
			[Cpp2IlInjected.Address(RVA = "0x9DF710", Offset = "0x9DDF10", VA = "0x1809DF710")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x60002FF")]
			[Cpp2IlInjected.Address(RVA = "0xCDCAB0", Offset = "0xCDB2B0", VA = "0x180CDCAB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000159")]
		public HJMECHLICGN Permission
		{
			[Cpp2IlInjected.Token(Token = "0x6000300")]
			[Cpp2IlInjected.Address(RVA = "0x9E9470", Offset = "0x9E7C70", VA = "0x1809E9470")]
			[CompilerGenerated]
			get
			{
				return default(HJMECHLICGN);
			}
			[Cpp2IlInjected.Token(Token = "0x6000301")]
			[Cpp2IlInjected.Address(RVA = "0x9EC7A0", Offset = "0x9EAFA0", VA = "0x1809EC7A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "4")]
		public void AOEGOOLELIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public UpdateInventionGeneralPermissionRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	[BDENCKNLAKO]
	public class PublishInventionRequest : HDINHDBEFHC
	{
		[Cpp2IlInjected.Token(Token = "0x1700015A")]
		public long InventionId
		{
			[Cpp2IlInjected.Token(Token = "0x6000304")]
			[Cpp2IlInjected.Address(RVA = "0x9DF710", Offset = "0x9DDF10", VA = "0x1809DF710")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000305")]
			[Cpp2IlInjected.Address(RVA = "0xCDCAB0", Offset = "0xCDB2B0", VA = "0x180CDCAB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015B")]
		public HJMECHLICGN Permission
		{
			[Cpp2IlInjected.Token(Token = "0x6000306")]
			[Cpp2IlInjected.Address(RVA = "0x9E9470", Offset = "0x9E7C70", VA = "0x1809E9470")]
			[CompilerGenerated]
			get
			{
				return default(HJMECHLICGN);
			}
			[Cpp2IlInjected.Token(Token = "0x6000307")]
			[Cpp2IlInjected.Address(RVA = "0x9EC7A0", Offset = "0x9EAFA0", VA = "0x1809EC7A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015C")]
		public IDBDBALOLAF Accessibility
		{
			[Cpp2IlInjected.Token(Token = "0x6000308")]
			[Cpp2IlInjected.Address(RVA = "0xA07330", Offset = "0xA05B30", VA = "0x180A07330")]
			[CompilerGenerated]
			get
			{
				return default(IDBDBALOLAF);
			}
			[Cpp2IlInjected.Token(Token = "0x6000309")]
			[Cpp2IlInjected.Address(RVA = "0xD3DBC0", Offset = "0xD3C3C0", VA = "0x180D3DBC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015D")]
		public int? Price
		{
			[Cpp2IlInjected.Token(Token = "0x600030A")]
			[Cpp2IlInjected.Address(RVA = "0x9DF730", Offset = "0x9DDF30", VA = "0x1809DF730")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600030B")]
			[Cpp2IlInjected.Address(RVA = "0xC79020", Offset = "0xC77820", VA = "0x180C79020")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "4")]
		public void AOEGOOLELIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public PublishInventionRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[BDENCKNLAKO]
	public class UnpublishInventionRequest : HDINHDBEFHC
	{
		[Cpp2IlInjected.Token(Token = "0x1700015E")]
		public long InventionId
		{
			[Cpp2IlInjected.Token(Token = "0x600030E")]
			[Cpp2IlInjected.Address(RVA = "0x9DF710", Offset = "0x9DDF10", VA = "0x1809DF710")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600030F")]
			[Cpp2IlInjected.Address(RVA = "0xCDCAB0", Offset = "0xCDB2B0", VA = "0x180CDCAB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "4")]
		public void AOEGOOLELIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public UnpublishInventionRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	[BDENCKNLAKO]
	public class DeleteInventionRequest : HDINHDBEFHC
	{
		[Cpp2IlInjected.Token(Token = "0x1700015F")]
		public long InventionId
		{
			[Cpp2IlInjected.Token(Token = "0x6000312")]
			[Cpp2IlInjected.Address(RVA = "0x9DF710", Offset = "0x9DDF10", VA = "0x1809DF710")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000313")]
			[Cpp2IlInjected.Address(RVA = "0xCDCAB0", Offset = "0xCDB2B0", VA = "0x180CDCAB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "4")]
		public void AOEGOOLELIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public DeleteInventionRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	[BDENCKNLAKO]
	public class SetInventionVersionAccessibilityRequest : HDINHDBEFHC
	{
		[Cpp2IlInjected.Token(Token = "0x17000160")]
		public long InventionId
		{
			[Cpp2IlInjected.Token(Token = "0x6000316")]
			[Cpp2IlInjected.Address(RVA = "0x9DF710", Offset = "0x9DDF10", VA = "0x1809DF710")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000317")]
			[Cpp2IlInjected.Address(RVA = "0xCDCAB0", Offset = "0xCDB2B0", VA = "0x180CDCAB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000161")]
		public int VersionNumber
		{
			[Cpp2IlInjected.Token(Token = "0x6000318")]
			[Cpp2IlInjected.Address(RVA = "0x9E9470", Offset = "0x9E7C70", VA = "0x1809E9470")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000319")]
			[Cpp2IlInjected.Address(RVA = "0x9EC7A0", Offset = "0x9EAFA0", VA = "0x1809EC7A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000162")]
		public IDBDBALOLAF NewAccessibility
		{
			[Cpp2IlInjected.Token(Token = "0x600031A")]
			[Cpp2IlInjected.Address(RVA = "0xA07330", Offset = "0xA05B30", VA = "0x180A07330")]
			[CompilerGenerated]
			get
			{
				return default(IDBDBALOLAF);
			}
			[Cpp2IlInjected.Token(Token = "0x600031B")]
			[Cpp2IlInjected.Address(RVA = "0xD3DBC0", Offset = "0xD3C3C0", VA = "0x180D3DBC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "4")]
		public void AOEGOOLELIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public SetInventionVersionAccessibilityRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[BDENCKNLAKO]
	public class SpecialTags : HDINHDBEFHC
	{
		[Cpp2IlInjected.Token(Token = "0x17000163")]
		public List<string> AutoTags
		{
			[Cpp2IlInjected.Token(Token = "0x600031E")]
			[Cpp2IlInjected.Address(RVA = "0x9DF710", Offset = "0x9DDF10", VA = "0x1809DF710")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600031F")]
			[Cpp2IlInjected.Address(RVA = "0x9DF720", Offset = "0x9DDF20", VA = "0x1809DF720")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000164")]
		public List<string> AGOnlyTags
		{
			[Cpp2IlInjected.Token(Token = "0x6000320")]
			[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000321")]
			[Cpp2IlInjected.Address(RVA = "0x9DF700", Offset = "0x9DDF00", VA = "0x1809DF700")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "4")]
		public void AOEGOOLELIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public SpecialTags()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public enum GFPMHNFCFGE
{
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	Success,
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	InvalidParameters,
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	PlayerCannotUpload,
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	DuplicateName,
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	NameTooShort,
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	NameTooLong,
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	NotCreator,
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	DoesNotExist,
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	ImageDoesNotExist,
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	InventionLimitReached,
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	DescriptionTooLong,
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	InnapropriateName,
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	InappropriateDescription,
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	CannotBeModified,
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	PlayerCannotPublish,
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	AlreadyPublished,
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	AlreadyUnpublished,
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	InventionUnderModerationReview,
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	PlayerCannotDownload,
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	PlayerAlreadyOwns,
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	DescriptionTooShort,
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	DoesNotHavePermission,
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	PermissionLevelCannotBeChanged,
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	AlreadyCheered,
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	AlreadyRemovedCheer,
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	ModeratorRestrictedPublishing,
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	PlayerCannotSell,
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	InvalidPrice,
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	PriceCannotBeChanged,
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	InvalidPermissionForPaidInvention,
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	PurchaseFailed,
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	CannotDownloadPaidInvention,
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	CannotSellUnownedLineage,
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	DoesNotAllowTrial,
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	StillOnTrialCooldown,
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	PlayerCannotTrial,
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	PaidInventionPublishingDisabled,
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	PaidInventionPurchasingDisabled,
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	OperationIsDisabled,
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	PlayerRestrictedFromP2PSelling,
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	PlayerNotRecRoomPlusMember,
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	InvalidInstantiationCost,
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	FeaturedInventionNotPublished,
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	FeaturedInventionNotActive,
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	InventionContainsBlockedFiles,
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	PlayerRestrictedFromP2PBuying,
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	ReservedWordRuleViolationInName,
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	ReservedWordRuleViolationInDescription,
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	InventionContainsBetaContent,
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	PlatformDoesntSupportPublishing,
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	MismatchedUgcVersions,
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	ConvertedFromSameUgcVersion,
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	ConvertedFromInventionDoesNotExist,
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	ConvertedFromInventionHigherVersion,
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	PlatformDoesntSupportInvention
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public enum INFJKNPHHJL
{
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	Unknown = -1,
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	CoC_Discriminatory,
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	CoC_Sexual,
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	CoC_Trolling,
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	Misleading,
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	Other
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public enum EOHGCPJCCNK
{
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	False,
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	True,
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	Invited
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public interface KOGELNCIALD
{
	[Cpp2IlInjected.Token(Token = "0x17000165")]
	IAHCCPKAHLI JHBPFKBLDNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000166")]
	string HCEJJPGCODO
	{
		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000167")]
	int HIGADEKDBLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000168")]
	DateTime KDANHHEHJJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000169")]
	bool PMDDEGDMCAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700016A")]
	string ABGBOOELKEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700016B")]
	EDCALICBMOK ILEOJGJONOK
	{
		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void AOEGOOLELIF();

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void EEABGNPGJCB(EDCALICBMOK IBKCOAFDMDK);
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public interface JNGKPLLMPOM
{
	[Cpp2IlInjected.Token(Token = "0x1700016C")]
	string ADBDGDHMIAH
	{
		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700016D")]
	int GJDKFIAMFHK
	{
		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700016E")]
	bool ONCEGALPAAM
	{
		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void AOEGOOLELIF();
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public struct CEJAKCPDCOP
{
	[Cpp2IlInjected.Token(Token = "0x1700016F")]
	public APJMMLBBMEA OAAOOKAPDKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0xA2A760", Offset = "0xA28F60", VA = "0x180A2A760")]
		[CompilerGenerated]
		readonly get
		{
			return default(APJMMLBBMEA);
		}
		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x127A100", Offset = "0x1278900", VA = "0x18127A100")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000170")]
	public JNGKPLLMPOM ELAFGKKCDIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0xD68560", Offset = "0xD66D60", VA = "0x180D68560")]
		[CompilerGenerated]
		readonly get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0xD68550", Offset = "0xD66D50", VA = "0x180D68550")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000171")]
	public string CJBAEJEMFJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x9DF710", Offset = "0x9DDF10", VA = "0x1809DF710")]
		[CompilerGenerated]
		readonly get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x9DF720", Offset = "0x9DDF20", VA = "0x1809DF720")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x15E35D0", Offset = "0x15E1DD0", VA = "0x1815E35D0")]
	public CEJAKCPDCOP(APJMMLBBMEA LMFHHGHJKAN, [Optional] JNGKPLLMPOM NOLKDKMAIME, [Optional] string NCJGPCMPFJF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public enum APJMMLBBMEA
{
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	Unknown,
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	Success,
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	ContinueSecurityCode,
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	TryAgainSecurityCode,
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	RemoteAuthPending
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
[BDENCKNLAKO]
public class DFIBJNLLEPO : HDINHDBEFHC
{
	[Cpp2IlInjected.Token(Token = "0x17000172")]
	public string LKGFGNBINIK
	{
		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x9DF710", Offset = "0x9DDF10", VA = "0x1809DF710")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x9DF720", Offset = "0x9DDF20", VA = "0x1809DF720")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000173")]
	public string AFKABAKBBAB
	{
		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x9DF700", Offset = "0x9DDF00", VA = "0x1809DF700")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000174")]
	public string PKGPMOOMMEP
	{
		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x9DF730", Offset = "0x9DDF30", VA = "0x1809DF730")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x9DF740", Offset = "0x9DDF40", VA = "0x1809DF740")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000175")]
	public string AFHEHCCCOMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x9DF790", Offset = "0x9DDF90", VA = "0x1809DF790")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x9DF780", Offset = "0x9DDF80", VA = "0x1809DF780")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000176")]
	public List<BJAOCDGEKDG> IFCHFKLOPGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x9DF770", Offset = "0x9DDF70", VA = "0x1809DF770")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x9DF750", Offset = "0x9DDF50", VA = "0x1809DF750")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public DFIBJNLLEPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x4892A10", Offset = "0x4891210", VA = "0x184892A10")]
	public DFIBJNLLEPO([Optional] string EHEFDPNDNCO, [Optional] string MHKFINGBJLL, [Optional] string FMPMCIIGFNE, [Optional] string JMABDDFKKOP, [Optional] List<BJAOCDGEKDG> OCEFJMLHJPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "4")]
	public void AOEGOOLELIF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
[BDENCKNLAKO]
public class BJAOCDGEKDG : HDINHDBEFHC
{
	[Cpp2IlInjected.Token(Token = "0x17000177")]
	public string FNMCOBJEMFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x9DF710", Offset = "0x9DDF10", VA = "0x1809DF710")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x9DF720", Offset = "0x9DDF20", VA = "0x1809DF720")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000178")]
	public string AFHEHCCCOMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x9DF700", Offset = "0x9DDF00", VA = "0x1809DF700")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "4")]
	public void AOEGOOLELIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public BJAOCDGEKDG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
[BDENCKNLAKO]
public class ICADBOFBNJO : HDINHDBEFHC
{
	[Cpp2IlInjected.Token(Token = "0x17000179")]
	public string AFKABAKBBAB
	{
		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x9DF710", Offset = "0x9DDF10", VA = "0x1809DF710")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x9DF720", Offset = "0x9DDF20", VA = "0x1809DF720")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017A")]
	public string OAAOOKAPDKL
	{
		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x9DF700", Offset = "0x9DDF00", VA = "0x1809DF700")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017B")]
	public string LKGFGNBINIK
	{
		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x9DF730", Offset = "0x9DDF30", VA = "0x1809DF730")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x9DF740", Offset = "0x9DDF40", VA = "0x1809DF740")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017C")]
	public List<string> FBKELLIEGBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x9DF790", Offset = "0x9DDF90", VA = "0x1809DF790")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x9DF780", Offset = "0x9DDF80", VA = "0x1809DF780")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "4")]
	public void AOEGOOLELIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public ICADBOFBNJO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
[BDENCKNLAKO]
public interface HDINHDBEFHC
{
	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AOEGOOLELIF();
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
[BDENCKNLAKO]
public interface NFLOLGCKCAF : HDINHDBEFHC
{
	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task BKIAAJDPKIB();
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
[OKCNDJDIEGL]
public interface KBMNKECBFGE : HDINHDBEFHC
{
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
[BDENCKNLAKO]
public class PENJJHBLLDC : HDINHDBEFHC
{
	[Cpp2IlInjected.Token(Token = "0x1700017D")]
	public Guid ACPBCEPFHAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0xF63890", Offset = "0xF62090", VA = "0x180F63890")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0xF63950", Offset = "0xF62150", VA = "0x180F63950")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017E")]
	public int NLNKGOHMIHB
	{
		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0xBD6AB0", Offset = "0xBD52B0", VA = "0x180BD6AB0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0xC46540", Offset = "0xC44D40", VA = "0x180C46540")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017F")]
	public string CAOBJIEEMIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x9DF790", Offset = "0x9DDF90", VA = "0x1809DF790")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x9DF780", Offset = "0x9DDF80", VA = "0x1809DF780")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000180")]
	public string DCDFHCNMFOD
	{
		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x9DF770", Offset = "0x9DDF70", VA = "0x1809DF770")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x9DF750", Offset = "0x9DDF50", VA = "0x1809DF750")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public PENJJHBLLDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x70741A0", Offset = "0x70729A0", VA = "0x1870741A0")]
	public PENJJHBLLDC([Optional] Guid KAAGPNJIINH, int MDILONMHHMF = 0, [Optional] string HJCFLJOBEGP, [Optional] string FKJNOHJCNMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "4")]
	public void AOEGOOLELIF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
[BDENCKNLAKO]
public class BOIHPHGPMPK : HDINHDBEFHC
{
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	public const int AMNHOBHJADF = 0;

	[Cpp2IlInjected.Token(Token = "0x17000181")]
	public long MKJAOOHHCCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x9DF710", Offset = "0x9DDF10", VA = "0x1809DF710")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0xCDCAB0", Offset = "0xCDB2B0", VA = "0x180CDCAB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000182")]
	public DKLNLJPEMAI KFOKMCOCENN
	{
		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x9DF700", Offset = "0x9DDF00", VA = "0x1809DF700")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000183")]
	public string IHLIJLJDCLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x9DF730", Offset = "0x9DDF30", VA = "0x1809DF730")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x9DF740", Offset = "0x9DDF40", VA = "0x1809DF740")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000184")]
	public List<PENJJHBLLDC> HPMOCLPECGP
	{
		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x9DF790", Offset = "0x9DDF90", VA = "0x1809DF790")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x9DF780", Offset = "0x9DDF80", VA = "0x1809DF780")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000185")]
	public int LJCPOBFAJEN
	{
		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x9E4120", Offset = "0x9E2920", VA = "0x1809E4120")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x9E4110", Offset = "0x9E2910", VA = "0x1809E4110")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000186")]
	public string ACOJEEABMOC
	{
		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x9E0DB0", Offset = "0x9DF5B0", VA = "0x1809E0DB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x9E0DC0", Offset = "0x9DF5C0", VA = "0x1809E0DC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000187")]
	public IDBDBALOLAF ABONPAANCAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x9EDEE0", Offset = "0x9EC6E0", VA = "0x1809EDEE0")]
		[CompilerGenerated]
		get
		{
			return default(IDBDBALOLAF);
		}
		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0xDF1550", Offset = "0xDEFD50", VA = "0x180DF1550")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000188")]
	public string JIOFECKBFNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x9E0DD0", Offset = "0x9DF5D0", VA = "0x1809E0DD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x9E0BB0", Offset = "0x9DF3B0", VA = "0x1809E0BB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000189")]
	public bool CLGLFICJMLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x1DA9650", Offset = "0x1DA7E50", VA = "0x181DA9650")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x706C420", Offset = "0x706AC20", VA = "0x18706C420")]
	public BOIHPHGPMPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x706C300", Offset = "0x706AB00", VA = "0x18706C300")]
	public BOIHPHGPMPK(long AJJGIECJFIH = 0L, [Optional] DKLNLJPEMAI BFACLEAANPD, [Optional] string NKNAJHAPOEH, [Optional] List<PENJJHBLLDC> PIJHEJBLJIA, int OPKLODOCMCI = 0, [Optional] string GLGOHIJMLFB, IDBDBALOLAF BABAPBFHKIC = IDBDBALOLAF.Private, [Optional] string GEMKJDCEONE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "4")]
	public void AOEGOOLELIF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public class KOIKGCPOBMM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	public readonly int HIGADEKDBLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	public readonly BOIHPHGPMPK GNDHIAIGMIF;

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0xEA3BB0", Offset = "0xEA23B0", VA = "0x180EA3BB0")]
	public KOIKGCPOBMM(int DCILOEIKONN, BOIHPHGPMPK PFDIFCADNMH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
[BDENCKNLAKO]
public class DKLNLJPEMAI : HDINHDBEFHC
{
	[Cpp2IlInjected.Token(Token = "0x1700018A")]
	public string IDDBGPDPGGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x9DF710", Offset = "0x9DDF10", VA = "0x1809DF710")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x9DF720", Offset = "0x9DDF20", VA = "0x1809DF720")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700018B")]
	public string CPCKIENJHCD
	{
		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x9DF700", Offset = "0x9DDF00", VA = "0x1809DF700")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700018C")]
	public string CLEEHDBFFFG
	{
		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x9DF730", Offset = "0x9DDF30", VA = "0x1809DF730")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x9DF740", Offset = "0x9DDF40", VA = "0x1809DF740")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700018D")]
	public string BMFKBDBBCFH
	{
		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x9DF790", Offset = "0x9DDF90", VA = "0x1809DF790")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x9DF780", Offset = "0x9DDF80", VA = "0x1809DF780")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700018E")]
	public string AOIMIPLALPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x9DF770", Offset = "0x9DDF70", VA = "0x1809DF770")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x9DF750", Offset = "0x9DDF50", VA = "0x1809DF750")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700018F")]
	public string HPMOCLPECGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x706D630", Offset = "0x706BE30", VA = "0x18706D630")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public DKLNLJPEMAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0x4892A10", Offset = "0x4891210", VA = "0x184892A10")]
	public DKLNLJPEMAI([Optional] string KFBGBPNPHNI, [Optional] string FGDOPJKNEGA, [Optional] string KNNOEANFGOD, [Optional] string GKIKDNIBDLJ, [Optional] string JOMPIHICHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "4")]
	public void AOEGOOLELIF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
[BDENCKNLAKO]
public class BLLAJNPOBFO : HDINHDBEFHC
{
	[Cpp2IlInjected.Token(Token = "0x17000190")]
	public Dictionary<int, BOIHPHGPMPK> BFNGEKKJNMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x9DF710", Offset = "0x9DDF10", VA = "0x1809DF710")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x9DF720", Offset = "0x9DDF20", VA = "0x1809DF720")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "4")]
	public void AOEGOOLELIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public BLLAJNPOBFO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
[BDENCKNLAKO]
public class ONALICOBNFD : HDINHDBEFHC
{
	[Cpp2IlInjected.Token(Token = "0x17000191")]
	public List<int> NAEPONEMKHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x9DF710", Offset = "0x9DDF10", VA = "0x1809DF710")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x9DF720", Offset = "0x9DDF20", VA = "0x1809DF720")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000192")]
	public byte? GOHHCLICJEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x2DB6030", Offset = "0x2DB4830", VA = "0x182DB6030")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x2DB5FA0", Offset = "0x2DB47A0", VA = "0x182DB5FA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000193")]
	public int? MFCPNPDCKOD
	{
		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0xEABFB0", Offset = "0xEAA7B0", VA = "0x180EABFB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0xEABFE0", Offset = "0xEAA7E0", VA = "0x180EABFE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "4")]
	public void AOEGOOLELIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public ONALICOBNFD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public static class NCGLAGBKBHA
{
	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x7073300", Offset = "0x7071B00", VA = "0x187073300")]
	public static FCKBIMABIOA DLCIDMMLCEK(this PENJJHBLLDC NFOGFJOGLPE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
[Flags]
public enum OEKNDJBDCIH
{
	[Cpp2IlInjected.Token(Token = "0x400020F")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000210")]
	Steam = 1,
	[Cpp2IlInjected.Token(Token = "0x4000211")]
	Oculus = 2,
	[Cpp2IlInjected.Token(Token = "0x4000212")]
	PlayStation = 4,
	[Cpp2IlInjected.Token(Token = "0x4000213")]
	Xbox = 8,
	[Cpp2IlInjected.Token(Token = "0x4000214")]
	RecNet = 0x10,
	[Cpp2IlInjected.Token(Token = "0x4000215")]
	IOS = 0x20,
	[Cpp2IlInjected.Token(Token = "0x4000216")]
	GooglePlay = 0x40,
	[Cpp2IlInjected.Token(Token = "0x4000217")]
	Standalone = 0x80,
	[Cpp2IlInjected.Token(Token = "0x4000218")]
	Pico = 0x100,
	[Cpp2IlInjected.Token(Token = "0x4000219")]
	Switch = 0x200,
	[Cpp2IlInjected.Token(Token = "0x400021A")]
	All = -1
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public enum IAHCCPKAHLI
{
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	All = -1,
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	Steam,
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	Oculus,
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	PlayStation,
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	Xbox,
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	RecNet,
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	IOS,
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	GooglePlay,
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	Standalone,
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	Pico,
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	Switch
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
[BDENCKNLAKO]
public class OJFKCFOPPIC : HDINHDBEFHC
{
	[Cpp2IlInjected.Token(Token = "0x17000194")]
	[DataMember(Name = "PlayerId")]
	public int HIGADEKDBLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x9DD1A0", Offset = "0x9DB9A0", VA = "0x1809DD1A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x9EBF60", Offset = "0x9EA760", VA = "0x1809EBF60")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000195")]
	public int NJNAHMBDHML
	{
		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0xB5FCA0", Offset = "0xB5E4A0", VA = "0x180B5FCA0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0xC57CC0", Offset = "0xC564C0", VA = "0x180C57CC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000196")]
	public int ONLDELDLAHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x9E9470", Offset = "0x9E7C70", VA = "0x1809E9470")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x9EC7A0", Offset = "0x9EAFA0", VA = "0x1809EC7A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "4")]
	public void AOEGOOLELIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public OJFKCFOPPIC()
	{
	}
}
namespace RecNet
{
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	[BDENCKNLAKO]
	public class ProgressionEventRecordDTO : HDINHDBEFHC
	{
		[Cpp2IlInjected.Token(Token = "0x17000197")]
		public int HIGADEKDBLE
		{
			[Cpp2IlInjected.Token(Token = "0x600039C")]
			[Cpp2IlInjected.Address(RVA = "0x9DD1A0", Offset = "0x9DB9A0", VA = "0x1809DD1A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600039D")]
			[Cpp2IlInjected.Address(RVA = "0x9EBF60", Offset = "0x9EA760", VA = "0x1809EBF60")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000198")]
		public int MDAKFFDEHBH
		{
			[Cpp2IlInjected.Token(Token = "0x600039E")]
			[Cpp2IlInjected.Address(RVA = "0xB5FCA0", Offset = "0xB5E4A0", VA = "0x180B5FCA0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600039F")]
			[Cpp2IlInjected.Address(RVA = "0xC57CC0", Offset = "0xC564C0", VA = "0x180C57CC0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000199")]
		public int NDJOGEFNNFP
		{
			[Cpp2IlInjected.Token(Token = "0x60003A0")]
			[Cpp2IlInjected.Address(RVA = "0x9E9470", Offset = "0x9E7C70", VA = "0x1809E9470")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60003A1")]
			[Cpp2IlInjected.Address(RVA = "0x9EC7A0", Offset = "0x9EAFA0", VA = "0x1809EC7A0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019A")]
		public int FCIOILIAMPK
		{
			[Cpp2IlInjected.Token(Token = "0x60003A2")]
			[Cpp2IlInjected.Address(RVA = "0xA07330", Offset = "0xA05B30", VA = "0x180A07330")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60003A3")]
			[Cpp2IlInjected.Address(RVA = "0xD3DBC0", Offset = "0xD3C3C0", VA = "0x180D3DBC0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019B")]
		public int NGLMNCGGPAP
		{
			[Cpp2IlInjected.Token(Token = "0x60003A4")]
			[Cpp2IlInjected.Address(RVA = "0xBD6AB0", Offset = "0xBD52B0", VA = "0x180BD6AB0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60003A5")]
			[Cpp2IlInjected.Address(RVA = "0xC46540", Offset = "0xC44D40", VA = "0x180C46540")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019C")]
		public DateTime? IJGICCPNHOL
		{
			[Cpp2IlInjected.Token(Token = "0x60003A6")]
			[Cpp2IlInjected.Address(RVA = "0x1256F40", Offset = "0x1255740", VA = "0x181256F40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003A7")]
			[Cpp2IlInjected.Address(RVA = "0x12575D0", Offset = "0x1255DD0", VA = "0x1812575D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public ProgressionEventRecordDTO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x70746B0", Offset = "0x7072EB0", VA = "0x1870746B0")]
		public ProgressionEventRecordDTO(int DCILOEIKONN = 0, int GKOFEJOFEGI = 0, int LOFLACEEPFL = 0, int ADCGBDHJMHJ = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "4")]
		public void AOEGOOLELIF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	[BDENCKNLAKO]
	public class ProgressionEventDTO : HDINHDBEFHC
	{
		[Cpp2IlInjected.Token(Token = "0x1700019D")]
		public long JAMDECLJBHI
		{
			[Cpp2IlInjected.Token(Token = "0x60003AB")]
			[Cpp2IlInjected.Address(RVA = "0x9DF710", Offset = "0x9DDF10", VA = "0x1809DF710")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x60003AC")]
			[Cpp2IlInjected.Address(RVA = "0xCDCAB0", Offset = "0xCDB2B0", VA = "0x180CDCAB0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019E")]
		public string ACOJEEABMOC
		{
			[Cpp2IlInjected.Token(Token = "0x60003AD")]
			[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003AE")]
			[Cpp2IlInjected.Address(RVA = "0x9DF700", Offset = "0x9DDF00", VA = "0x1809DF700")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019F")]
		public List<ProgressionEventRewardDTO> FIEOALBMJJO
		{
			[Cpp2IlInjected.Token(Token = "0x60003AF")]
			[Cpp2IlInjected.Address(RVA = "0x9DF730", Offset = "0x9DDF30", VA = "0x1809DF730")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003B0")]
			[Cpp2IlInjected.Address(RVA = "0x9DF740", Offset = "0x9DDF40", VA = "0x1809DF740")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A0")]
		public List<KeepsakeRoomListDTO> CJKNEJDAPNB
		{
			[Cpp2IlInjected.Token(Token = "0x60003B1")]
			[Cpp2IlInjected.Address(RVA = "0x9DF790", Offset = "0x9DDF90", VA = "0x1809DF790")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003B2")]
			[Cpp2IlInjected.Address(RVA = "0x9DF780", Offset = "0x9DDF80", VA = "0x1809DF780")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A1")]
		public DateTime MMMAAJABPKC
		{
			[Cpp2IlInjected.Token(Token = "0x60003B3")]
			[Cpp2IlInjected.Address(RVA = "0x9DF770", Offset = "0x9DDF70", VA = "0x1809DF770")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x60003B4")]
			[Cpp2IlInjected.Address(RVA = "0x9E0DF0", Offset = "0x9DF5F0", VA = "0x1809E0DF0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A2")]
		public DateTime DCCOJGEPDPH
		{
			[Cpp2IlInjected.Token(Token = "0x60003B5")]
			[Cpp2IlInjected.Address(RVA = "0x9E0DB0", Offset = "0x9DF5B0", VA = "0x1809E0DB0")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x60003B6")]
			[Cpp2IlInjected.Address(RVA = "0x9E4300", Offset = "0x9E2B00", VA = "0x1809E4300")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A3")]
		public DateTime CIIMLMILMAG
		{
			[Cpp2IlInjected.Token(Token = "0x60003B7")]
			[Cpp2IlInjected.Address(RVA = "0x9E2460", Offset = "0x9E0C60", VA = "0x1809E2460")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x60003B8")]
			[Cpp2IlInjected.Address(RVA = "0xDFC010", Offset = "0xDFA810", VA = "0x180DFC010")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A4")]
		public bool JFFHNMIFMHE
		{
			[Cpp2IlInjected.Token(Token = "0x60003B9")]
			[Cpp2IlInjected.Address(RVA = "0xBFD9E0", Offset = "0xBFC1E0", VA = "0x180BFD9E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60003BA")]
			[Cpp2IlInjected.Address(RVA = "0xC03A50", Offset = "0xC02250", VA = "0x180C03A50")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A5")]
		public int JCIJNFPANHC
		{
			[Cpp2IlInjected.Token(Token = "0x60003BB")]
			[Cpp2IlInjected.Address(RVA = "0x1323500", Offset = "0x1321D00", VA = "0x181323500")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60003BC")]
			[Cpp2IlInjected.Address(RVA = "0x1FB5D50", Offset = "0x1FB4550", VA = "0x181FB5D50")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A6")]
		public float LPOJOLBINBN
		{
			[Cpp2IlInjected.Token(Token = "0x60003BD")]
			[Cpp2IlInjected.Address(RVA = "0x1093C80", Offset = "0x1092480", VA = "0x181093C80")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60003BE")]
			[Cpp2IlInjected.Address(RVA = "0x13380B0", Offset = "0x13368B0", VA = "0x1813380B0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A7")]
		public Guid? GBNFELDPJPK
		{
			[Cpp2IlInjected.Token(Token = "0x60003BF")]
			[Cpp2IlInjected.Address(RVA = "0x70745E0", Offset = "0x7072DE0", VA = "0x1870745E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003C0")]
			[Cpp2IlInjected.Address(RVA = "0x70745D0", Offset = "0x7072DD0", VA = "0x1870745D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A8")]
		public string JKGFLBEBAJM
		{
			[Cpp2IlInjected.Token(Token = "0x60003C1")]
			[Cpp2IlInjected.Address(RVA = "0x9DD1C0", Offset = "0x9DB9C0", VA = "0x1809DD1C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003C2")]
			[Cpp2IlInjected.Address(RVA = "0x9DD1B0", Offset = "0x9DB9B0", VA = "0x1809DD1B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A9")]
		public string GOAOCLKMPGI
		{
			[Cpp2IlInjected.Token(Token = "0x60003C3")]
			[Cpp2IlInjected.Address(RVA = "0x9DD1F0", Offset = "0x9DB9F0", VA = "0x1809DD1F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003C4")]
			[Cpp2IlInjected.Address(RVA = "0x9DD1E0", Offset = "0x9DB9E0", VA = "0x1809DD1E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AA")]
		public string MAGNCMJIKGN
		{
			[Cpp2IlInjected.Token(Token = "0x60003C5")]
			[Cpp2IlInjected.Address(RVA = "0x9E93E0", Offset = "0x9E7BE0", VA = "0x1809E93E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003C6")]
			[Cpp2IlInjected.Address(RVA = "0x9E9480", Offset = "0x9E7C80", VA = "0x1809E9480")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AB")]
		public string ICEHAMOIKHI
		{
			[Cpp2IlInjected.Token(Token = "0x60003C7")]
			[Cpp2IlInjected.Address(RVA = "0x9E9310", Offset = "0x9E7B10", VA = "0x1809E9310")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003C8")]
			[Cpp2IlInjected.Address(RVA = "0x9E9320", Offset = "0x9E7B20", VA = "0x1809E9320")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public ProgressionEventDTO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x7074600", Offset = "0x7072E00", VA = "0x187074600")]
		public ProgressionEventDTO(long BOOHEBBJOLC = 0L, [Optional] string GLGOHIJMLFB, [Optional] List<ProgressionEventRewardDTO> CGBMLEKJANC, [Optional] List<KeepsakeRoomListDTO> AJLACJAABLD, [Optional] DateTime GEEOJGFNPAK, [Optional] DateTime OPADMCNDOMB, [Optional] DateTime HJAMPGDNBOH, bool EDJKFKPOLHN = false, int JDPFFGNNKOH = 0, float BKMKEKMIGGC = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "4")]
		public void AOEGOOLELIF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	[BDENCKNLAKO]
	public class KeepsakeRoomListDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170001AC")]
		public long POBPGNKBLGK
		{
			[Cpp2IlInjected.Token(Token = "0x60003CC")]
			[Cpp2IlInjected.Address(RVA = "0x9DF710", Offset = "0x9DDF10", VA = "0x1809DF710")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x60003CD")]
			[Cpp2IlInjected.Address(RVA = "0xCDCAB0", Offset = "0xCDB2B0", VA = "0x180CDCAB0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AD")]
		public long JAMDECLJBHI
		{
			[Cpp2IlInjected.Token(Token = "0x60003CE")]
			[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x60003CF")]
			[Cpp2IlInjected.Address(RVA = "0xC57CB0", Offset = "0xC564B0", VA = "0x180C57CB0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AE")]
		public int? CKPACDLEKDP
		{
			[Cpp2IlInjected.Token(Token = "0x60003D0")]
			[Cpp2IlInjected.Address(RVA = "0x9DF730", Offset = "0x9DDF30", VA = "0x1809DF730")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003D1")]
			[Cpp2IlInjected.Address(RVA = "0xC79020", Offset = "0xC77820", VA = "0x180C79020")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AF")]
		public int? DMAKIBKKANN
		{
			[Cpp2IlInjected.Token(Token = "0x60003D2")]
			[Cpp2IlInjected.Address(RVA = "0x9DF790", Offset = "0x9DDF90", VA = "0x1809DF790")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003D3")]
			[Cpp2IlInjected.Address(RVA = "0x9E0DE0", Offset = "0x9DF5E0", VA = "0x1809E0DE0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B0")]
		public long? GLGNELNDJAM
		{
			[Cpp2IlInjected.Token(Token = "0x60003D4")]
			[Cpp2IlInjected.Address(RVA = "0xDA6670", Offset = "0xDA4E70", VA = "0x180DA6670")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003D5")]
			[Cpp2IlInjected.Address(RVA = "0xDA6BD0", Offset = "0xDA53D0", VA = "0x180DA6BD0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B1")]
		public long ACONELNHPME
		{
			[Cpp2IlInjected.Token(Token = "0x60003D6")]
			[Cpp2IlInjected.Address(RVA = "0x9E2460", Offset = "0x9E0C60", VA = "0x1809E2460")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x60003D7")]
			[Cpp2IlInjected.Address(RVA = "0xDFC010", Offset = "0xDFA810", VA = "0x180DFC010")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B2")]
		public TimeSpan KCDNPODDLLE
		{
			[Cpp2IlInjected.Token(Token = "0x60003D8")]
			[Cpp2IlInjected.Address(RVA = "0x7072260", Offset = "0x7070A60", VA = "0x187072260")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B3")]
		public long OLIPGCIENFM
		{
			[Cpp2IlInjected.Token(Token = "0x60003D9")]
			[Cpp2IlInjected.Address(RVA = "0x9E0DD0", Offset = "0x9DF5D0", VA = "0x1809E0DD0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x60003DA")]
			[Cpp2IlInjected.Address(RVA = "0x6DAEEC0", Offset = "0x6DAD6C0", VA = "0x186DAEEC0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B4")]
		public TimeSpan FNLLDEDGGLK
		{
			[Cpp2IlInjected.Token(Token = "0x60003DB")]
			[Cpp2IlInjected.Address(RVA = "0x7072210", Offset = "0x7070A10", VA = "0x187072210")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B5")]
		public int OJMOJJIDEKD
		{
			[Cpp2IlInjected.Token(Token = "0x60003DC")]
			[Cpp2IlInjected.Address(RVA = "0xCF7CF0", Offset = "0xCF64F0", VA = "0x180CF7CF0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60003DD")]
			[Cpp2IlInjected.Address(RVA = "0xE3E7C0", Offset = "0xE3CFC0", VA = "0x180E3E7C0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B6")]
		public OOCKLLBKMIG KMIOGOPPDNK
		{
			[Cpp2IlInjected.Token(Token = "0x60003DE")]
			[Cpp2IlInjected.Address(RVA = "0x110B6C0", Offset = "0x1109EC0", VA = "0x18110B6C0")]
			[CompilerGenerated]
			get
			{
				return default(OOCKLLBKMIG);
			}
			[Cpp2IlInjected.Token(Token = "0x60003DF")]
			[Cpp2IlInjected.Address(RVA = "0x2137CE0", Offset = "0x21364E0", VA = "0x182137CE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B7")]
		public List<KeepsakeRoomDTO> FDOBJBHHPFJ
		{
			[Cpp2IlInjected.Token(Token = "0x60003E0")]
			[Cpp2IlInjected.Address(RVA = "0x9DD230", Offset = "0x9DBA30", VA = "0x1809DD230")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003E1")]
			[Cpp2IlInjected.Address(RVA = "0x9DD1D0", Offset = "0x9DB9D0", VA = "0x1809DD1D0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public KeepsakeRoomListDTO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x70722B0", Offset = "0x7070AB0", VA = "0x1870722B0")]
		public KeepsakeRoomListDTO(long IGGBKAEOJGI = 0L, long BOOHEBBJOLC = 0L, [Optional] int? NNMKPKBADEF, [Optional] int? DDCEIJCHDPN, [Optional] long? GHNOJKJBAIP, long PKHJKIFLPLM = 0L, long GICNLGIFDAM = 0L, int BBAECOEKLOK = 0, OOCKLLBKMIG GFLMEDCKLGN = OOCKLLBKMIG.Standard, [Optional] List<KeepsakeRoomDTO> DMPDKJDIEMI)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	[BDENCKNLAKO]
	public class KeepsakeRoomDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170001B8")]
		public long DKBNDOAAHPG
		{
			[Cpp2IlInjected.Token(Token = "0x60003E4")]
			[Cpp2IlInjected.Address(RVA = "0x9DF710", Offset = "0x9DDF10", VA = "0x1809DF710")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x60003E5")]
			[Cpp2IlInjected.Address(RVA = "0xCDCAB0", Offset = "0xCDB2B0", VA = "0x180CDCAB0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B9")]
		public long MPBMECOMGLA
		{
			[Cpp2IlInjected.Token(Token = "0x60003E6")]
			[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x60003E7")]
			[Cpp2IlInjected.Address(RVA = "0xC57CB0", Offset = "0xC564B0", VA = "0x180C57CB0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BA")]
		public long POBPGNKBLGK
		{
			[Cpp2IlInjected.Token(Token = "0x60003E8")]
			[Cpp2IlInjected.Address(RVA = "0x9DF730", Offset = "0x9DDF30", VA = "0x1809DF730")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x60003E9")]
			[Cpp2IlInjected.Address(RVA = "0xC79020", Offset = "0xC77820", VA = "0x180C79020")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BB")]
		public OOCKLLBKMIG PALJBODIBGP
		{
			[Cpp2IlInjected.Token(Token = "0x60003EA")]
			[Cpp2IlInjected.Address(RVA = "0x9EBF90", Offset = "0x9EA790", VA = "0x1809EBF90")]
			[CompilerGenerated]
			get
			{
				return default(OOCKLLBKMIG);
			}
			[Cpp2IlInjected.Token(Token = "0x60003EB")]
			[Cpp2IlInjected.Address(RVA = "0x9EBF70", Offset = "0x9EA770", VA = "0x1809EBF70")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BC")]
		public int LNAKCPJJILC
		{
			[Cpp2IlInjected.Token(Token = "0x60003EC")]
			[Cpp2IlInjected.Address(RVA = "0xC4B9C0", Offset = "0xC4A1C0", VA = "0x180C4B9C0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60003ED")]
			[Cpp2IlInjected.Address(RVA = "0x1388660", Offset = "0x1386E60", VA = "0x181388660")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public KeepsakeRoomDTO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x70721B0", Offset = "0x70709B0", VA = "0x1870721B0")]
		public KeepsakeRoomDTO(long CNDIPPCPBLM = 0L, long MDLDCACFGIB = 0L, long IGGBKAEOJGI = 0L, OOCKLLBKMIG PIJHKCJDAHO = OOCKLLBKMIG.Standard, int CMIFIHKJOBP = 0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	[BDENCKNLAKO]
	public class ProgressionEventRewardDTO : HDINHDBEFHC
	{
		[Cpp2IlInjected.Token(Token = "0x170001BD")]
		public long DKFEAGEALMA
		{
			[Cpp2IlInjected.Token(Token = "0x60003EE")]
			[Cpp2IlInjected.Address(RVA = "0x9DF710", Offset = "0x9DDF10", VA = "0x1809DF710")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x60003EF")]
			[Cpp2IlInjected.Address(RVA = "0xCDCAB0", Offset = "0xCDB2B0", VA = "0x180CDCAB0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BE")]
		public int DNNEOMIELNA
		{
			[Cpp2IlInjected.Token(Token = "0x60003F0")]
			[Cpp2IlInjected.Address(RVA = "0x9E9470", Offset = "0x9E7C70", VA = "0x1809E9470")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60003F1")]
			[Cpp2IlInjected.Address(RVA = "0x9EC7A0", Offset = "0x9EAFA0", VA = "0x1809EC7A0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BF")]
		public string GFJBHKHMHCE
		{
			[Cpp2IlInjected.Token(Token = "0x60003F2")]
			[Cpp2IlInjected.Address(RVA = "0x9DF730", Offset = "0x9DDF30", VA = "0x1809DF730")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003F3")]
			[Cpp2IlInjected.Address(RVA = "0x9DF740", Offset = "0x9DDF40", VA = "0x1809DF740")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C0")]
		public int MDAKFFDEHBH
		{
			[Cpp2IlInjected.Token(Token = "0x60003F4")]
			[Cpp2IlInjected.Address(RVA = "0x9EBF90", Offset = "0x9EA790", VA = "0x1809EBF90")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60003F5")]
			[Cpp2IlInjected.Address(RVA = "0x9EBF70", Offset = "0x9EA770", VA = "0x1809EBF70")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C1")]
		public int BDAGFJLHEKI
		{
			[Cpp2IlInjected.Token(Token = "0x60003F6")]
			[Cpp2IlInjected.Address(RVA = "0xC4B9C0", Offset = "0xC4A1C0", VA = "0x180C4B9C0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60003F7")]
			[Cpp2IlInjected.Address(RVA = "0x1388660", Offset = "0x1386E60", VA = "0x181388660")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C2")]
		public bool NGDABBHFMLD
		{
			[Cpp2IlInjected.Token(Token = "0x60003F8")]
			[Cpp2IlInjected.Address(RVA = "0xA0BF30", Offset = "0xA0A730", VA = "0x180A0BF30")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60003F9")]
			[Cpp2IlInjected.Address(RVA = "0xA0BCB0", Offset = "0xA0A4B0", VA = "0x180A0BCB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "4")]
		public void AOEGOOLELIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public ProgressionEventRewardDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	[BDENCKNLAKO]
	public class ProgressionEventPurchasableXpBoostDTO : HDINHDBEFHC
	{
		[Cpp2IlInjected.Token(Token = "0x170001C3")]
		public Guid ODADAOFEOCA
		{
			[Cpp2IlInjected.Token(Token = "0x60003FC")]
			[Cpp2IlInjected.Address(RVA = "0xF63890", Offset = "0xF62090", VA = "0x180F63890")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x60003FD")]
			[Cpp2IlInjected.Address(RVA = "0xF63950", Offset = "0xF62150", VA = "0x180F63950")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C4")]
		public int AECCGLOPNCN
		{
			[Cpp2IlInjected.Token(Token = "0x60003FE")]
			[Cpp2IlInjected.Address(RVA = "0xBD6AB0", Offset = "0xBD52B0", VA = "0x180BD6AB0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60003FF")]
			[Cpp2IlInjected.Address(RVA = "0xC46540", Offset = "0xC44D40", VA = "0x180C46540")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C5")]
		public int EMHKGPCLPGO
		{
			[Cpp2IlInjected.Token(Token = "0x6000400")]
			[Cpp2IlInjected.Address(RVA = "0xCE6F70", Offset = "0xCE5770", VA = "0x180CE6F70")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000401")]
			[Cpp2IlInjected.Address(RVA = "0xEF7300", Offset = "0xEF5B00", VA = "0x180EF7300")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C6")]
		public int MKNBHHODDBP
		{
			[Cpp2IlInjected.Token(Token = "0x6000402")]
			[Cpp2IlInjected.Address(RVA = "0x9EBF90", Offset = "0x9EA790", VA = "0x1809EBF90")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000403")]
			[Cpp2IlInjected.Address(RVA = "0x9EBF70", Offset = "0x9EA770", VA = "0x1809EBF70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C7")]
		public long FIGCIIMDBFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000404")]
			[Cpp2IlInjected.Address(RVA = "0x9DF770", Offset = "0x9DDF70", VA = "0x1809DF770")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000405")]
			[Cpp2IlInjected.Address(RVA = "0x9E0DF0", Offset = "0x9DF5F0", VA = "0x1809E0DF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C8")]
		public long POMCKLGDPAJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000406")]
			[Cpp2IlInjected.Address(RVA = "0x9E0DB0", Offset = "0x9DF5B0", VA = "0x1809E0DB0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000407")]
			[Cpp2IlInjected.Address(RVA = "0x9E4300", Offset = "0x9E2B00", VA = "0x1809E4300")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "4")]
		public void AOEGOOLELIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public ProgressionEventPurchasableXpBoostDTO()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public enum OOCKLLBKMIG
{
	[Cpp2IlInjected.Token(Token = "0x400025B")]
	Standard,
	[Cpp2IlInjected.Token(Token = "0x400025C")]
	Premium
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
public enum CCAFHCPHPLB
{
	[Cpp2IlInjected.Token(Token = "0x400025E")]
	Explore = 0,
	[Cpp2IlInjected.Token(Token = "0x400025F")]
	GreenPowerCore = 1,
	[Cpp2IlInjected.Token(Token = "0x4000260")]
	Present = 2,
	[Cpp2IlInjected.Token(Token = "0x4000261")]
	PurplePowerCore = 3,
	[Cpp2IlInjected.Token(Token = "0x4000262")]
	UnnamedKeepsakeNumber1 = 4,
	[Cpp2IlInjected.Token(Token = "0x4000263")]
	UnnamedKeepsakeNumber2 = 5,
	[Cpp2IlInjected.Token(Token = "0x4000264")]
	UnnamedKeepsakeNumber3 = 6,
	[Cpp2IlInjected.Token(Token = "0x4000265")]
	UnnamedKeepsakeNumber4 = 7,
	[Cpp2IlInjected.Token(Token = "0x4000266")]
	UnnamedKeepsakeNumber5 = 8,
	[Cpp2IlInjected.Token(Token = "0x4000267")]
	_Test = 1000
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
[BDENCKNLAKO]
public class IKPHFAHHOFF : HDINHDBEFHC
{
	[Cpp2IlInjected.Token(Token = "0x170001C9")]
	public string LABGJIFHBPG
	{
		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x9DF710", Offset = "0x9DDF10", VA = "0x1809DF710")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x9DF720", Offset = "0x9DDF20", VA = "0x1809DF720")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001CA")]
	public string? KLMGAAOGPNK
	{
		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x9DF700", Offset = "0x9DDF00", VA = "0x1809DF700")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "4")]
	public void AOEGOOLELIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public IKPHFAHHOFF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public interface DGMMIABMBEA
{
	[Cpp2IlInjected.Token(Token = "0x170001CB")]
	bool BEPNLJCJPFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001CC")]
	string? EEMNMJJFOOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001CD")]
	string? LOKBGPAFMHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public interface LJEBMPEMBGD<T> : DGMMIABMBEA
{
	[Cpp2IlInjected.Token(Token = "0x170001CE")]
	T GDCDOMLHCOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
public static class MJPLMDOJJNB
{
	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x38C45D0", Offset = "0x38C2DD0", VA = "0x1838C45D0")]
	public static LJEBMPEMBGD<T> FCHHAJKLMDP<T, U>(this LJEBMPEMBGD<U> HLPIAOANGMD, Func<U, T> MLDHKINDHNN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
public struct DNNKPDFOFFD<T> : LJEBMPEMBGD<T>, DGMMIABMBEA
{
	[Cpp2IlInjected.Token(Token = "0x170001CF")]
	public bool BEPNLJCJPFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0xF136D0", Offset = "0xF11ED0", VA = "0x180F136D0", Slot = "5")]
		[CompilerGenerated]
		readonly get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x2976410", Offset = "0x2974C10", VA = "0x182976410")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001D0")]
	public string? EEMNMJJFOOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0xD68560", Offset = "0xD66D60", VA = "0x180D68560", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0xD68550", Offset = "0xD66D50", VA = "0x180D68550")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001D1")]
	public string? LOKBGPAFMHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x9DF710", Offset = "0x9DDF10", VA = "0x1809DF710", Slot = "7")]
		[CompilerGenerated]
		readonly get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x9DF720", Offset = "0x9DDF20", VA = "0x1809DF720")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001D2")]
	public T GDCDOMLHCOE
	{
		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x9DF700", Offset = "0x9DDF00", VA = "0x1809DF700")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x68E60E0", Offset = "0x68E48E0", VA = "0x1868E60E0")]
	public static DNNKPDFOFFD<T> MIFIOPOFFBK(T OPMIAMEJKDH)
	{
		return default(DNNKPDFOFFD<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x68E6020", Offset = "0x68E4820", VA = "0x1868E6020")]
	public static DNNKPDFOFFD<T> AGCJKPGDFIK(string LKNKJJBHDKO, string BOGNKCPELPH = "")
	{
		return default(DNNKPDFOFFD<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
[BDENCKNLAKO]
public class KFNGEGFGHNK : DGMMIABMBEA, HDINHDBEFHC
{
	[Cpp2IlInjected.Token(Token = "0x170001D3")]
	public bool BEPNLJCJPFD
	{
		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0xC47930", Offset = "0xC46130", VA = "0x180C47930", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0xC466E0", Offset = "0xC44EE0", VA = "0x180C466E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001D4")]
	public string? EEMNMJJFOOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x9DF700", Offset = "0x9DDF00", VA = "0x1809DF700")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001D5")]
	[DataMember(Name = "error_id")]
	public string? LOKBGPAFMHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x9DF730", Offset = "0x9DDF30", VA = "0x1809DF730", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x9DF740", Offset = "0x9DDF40", VA = "0x1809DF740")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "8")]
	public virtual void AOEGOOLELIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(RVA = "0x7071BB0", Offset = "0x70703B0", VA = "0x187071BB0")]
	public static KFNGEGFGHNK MIFIOPOFFBK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(RVA = "0x7071B20", Offset = "0x7070320", VA = "0x187071B20")]
	public static KFNGEGFGHNK AGCJKPGDFIK(string LKNKJJBHDKO, string BOGNKCPELPH = "")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public KFNGEGFGHNK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
[LMPNAKPEIDE]
public abstract class NJALFJAOODE<T> : KFNGEGFGHNK, LJEBMPEMBGD<T>, DGMMIABMBEA
{
	[Cpp2IlInjected.Token(Token = "0x170001D6")]
	public T GDCDOMLHCOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0xD83850", Offset = "0xD82050", VA = "0x180D83850", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0xA82330", Offset = "0xA80B30", VA = "0x180A82330")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0xA08FF0", Offset = "0xA077F0", VA = "0x180A08FF0")]
	protected NJALFJAOODE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
[LMPNAKPEIDE]
public class KNLMMNCFKNM<T> : NJALFJAOODE<T>
{
	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x4F40620", Offset = "0x4F3EE20", VA = "0x184F40620")]
	private static void OIHGIADMDMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x43AA000", Offset = "0x43A8800", VA = "0x1843AA000")]
	public KNLMMNCFKNM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
[LMPNAKPEIDE]
public class MLGCIODNMCL<T> : NJALFJAOODE<T>, NFLOLGCKCAF, HDINHDBEFHC where T : HDINHDBEFHC, new()
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	[CompilerGenerated]
	private struct BIJPBDHONMC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		public MLGCIODNMCL<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x5F1A500", Offset = "0x5F18D00", VA = "0x185F1A500", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0x5F1A780", Offset = "0x5F18F80", VA = "0x185F1A780", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x528CD30", Offset = "0x528B530", VA = "0x18528CD30", Slot = "8")]
	public override void AOEGOOLELIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x528CE30", Offset = "0x528B630", VA = "0x18528CE30", Slot = "10")]
	[AsyncStateMachine(typeof(MLGCIODNMCL<>.BIJPBDHONMC))]
	public Task BKIAAJDPKIB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x528CF00", Offset = "0x528B700", VA = "0x18528CF00")]
	public static MLGCIODNMCL<T> MIFIOPOFFBK(T OPMIAMEJKDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x528CBE0", Offset = "0x528B3E0", VA = "0x18528CBE0")]
	public new static MLGCIODNMCL<T> AGCJKPGDFIK(string LKNKJJBHDKO, string BOGNKCPELPH = "")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x4860200", Offset = "0x485EA00", VA = "0x184860200")]
	public MLGCIODNMCL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
[LMPNAKPEIDE]
public class IEHKPNICKBC<T> : NJALFJAOODE<List<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x43AA000", Offset = "0x43A8800", VA = "0x1843AA000")]
	public IEHKPNICKBC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
[LMPNAKPEIDE]
public class CCBKFFHDKAF<T> : NJALFJAOODE<List<T>>, NFLOLGCKCAF, HDINHDBEFHC where T : HDINHDBEFHC, new()
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	[CompilerGenerated]
	private struct NBLGBBFCOHL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		public CCBKFFHDKAF<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0x52DBCE0", Offset = "0x52DA4E0", VA = "0x1852DBCE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0x52DBEF0", Offset = "0x52DA6F0", VA = "0x1852DBEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x630B760", Offset = "0x6309F60", VA = "0x18630B760")]
	public static CCBKFFHDKAF<T> MIFIOPOFFBK(List<T> OPMIAMEJKDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x630B2D0", Offset = "0x6309AD0", VA = "0x18630B2D0")]
	public new static CCBKFFHDKAF<T> AGCJKPGDFIK(string LKNKJJBHDKO, string BOGNKCPELPH = "")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x630B420", Offset = "0x6309C20", VA = "0x18630B420", Slot = "8")]
	public override void AOEGOOLELIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x630B690", Offset = "0x6309E90", VA = "0x18630B690", Slot = "10")]
	[AsyncStateMachine(typeof(CCBKFFHDKAF<>.NBLGBBFCOHL))]
	public Task BKIAAJDPKIB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x4E74B80", Offset = "0x4E73380", VA = "0x184E74B80")]
	public CCBKFFHDKAF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
public enum IHEADBDKHBJ
{
	[Cpp2IlInjected.Token(Token = "0x400027B")]
	AI,
	[Cpp2IlInjected.Token(Token = "0x400027C")]
	Auth,
	[Cpp2IlInjected.Token(Token = "0x400027D")]
	API,
	[Cpp2IlInjected.Token(Token = "0x400027E")]
	Commerce,
	[Cpp2IlInjected.Token(Token = "0x400027F")]
	Matchmaking,
	[Cpp2IlInjected.Token(Token = "0x4000280")]
	Notifications,
	[Cpp2IlInjected.Token(Token = "0x4000281")]
	Images,
	[Cpp2IlInjected.Token(Token = "0x4000282")]
	CDN,
	[Cpp2IlInjected.Token(Token = "0x4000283")]
	Storage,
	[Cpp2IlInjected.Token(Token = "0x4000284")]
	Chat,
	[Cpp2IlInjected.Token(Token = "0x4000285")]
	Leaderboard,
	[Cpp2IlInjected.Token(Token = "0x4000286")]
	Accounts,
	[Cpp2IlInjected.Token(Token = "0x4000287")]
	Link,
	[Cpp2IlInjected.Token(Token = "0x4000288")]
	Lists,
	[Cpp2IlInjected.Token(Token = "0x4000289")]
	RoomComments,
	[Cpp2IlInjected.Token(Token = "0x400028A")]
	Clubs,
	[Cpp2IlInjected.Token(Token = "0x400028B")]
	Rooms,
	[Cpp2IlInjected.Token(Token = "0x400028C")]
	PlatformNotifications,
	[Cpp2IlInjected.Token(Token = "0x400028D")]
	Moderation,
	[Cpp2IlInjected.Token(Token = "0x400028E")]
	DataCollection,
	[Cpp2IlInjected.Token(Token = "0x400028F")]
	BugReporting,
	[Cpp2IlInjected.Token(Token = "0x4000290")]
	Discovery,
	[Cpp2IlInjected.Token(Token = "0x4000291")]
	PlayerSettings,
	[Cpp2IlInjected.Token(Token = "0x4000292")]
	Studio,
	[Cpp2IlInjected.Token(Token = "0x4000293")]
	GameLogs,
	[Cpp2IlInjected.Token(Token = "0x4000294")]
	Strings,
	[Cpp2IlInjected.Token(Token = "0x4000295")]
	StringsCDN,
	[Cpp2IlInjected.Token(Token = "0x4000296")]
	WWW,
	[Cpp2IlInjected.Token(Token = "0x4000297")]
	Econ,
	[Cpp2IlInjected.Token(Token = "0x4000298")]
	Data,
	[Cpp2IlInjected.Token(Token = "0x4000299")]
	Cards
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public static class CHABHFNNDLL
{
	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x706CC30", Offset = "0x706B430", VA = "0x18706CC30")]
	public static bool AEHPPCFIEGL(this IHEADBDKHBJ KICOAPCJPFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x706CC30", Offset = "0x706B430", VA = "0x18706CC30")]
	public static bool FCOJDCGPLML(this IHEADBDKHBJ KICOAPCJPFE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public enum FIEOJKLGOND
{
	[Cpp2IlInjected.Token(Token = "0x400029B")]
	Invalid = 0,
	[Cpp2IlInjected.Token(Token = "0x400029C")]
	LaserTagTickets = 1,
	[Cpp2IlInjected.Token(Token = "0x400029D")]
	RecCenterTokens = 2,
	[Cpp2IlInjected.Token(Token = "0x400029E")]
	LostSkullsGold = 100,
	[Cpp2IlInjected.Token(Token = "0x400029F")]
	DraculaSilver = 101,
	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	RecRoyale_Season1 = 200,
	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	RoomCurrency = 300,
	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	RoomInventoryItem = 301,
	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	ProgressionEvent = 400
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public enum LJOOEGFMDKC
{
	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	NonPurchasedNotUsableInP2P = -2,
	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	NonPurchasedDefault = -1,
	[Cpp2IlInjected.Token(Token = "0x40002A7")]
	SteamPurchased = 0,
	[Cpp2IlInjected.Token(Token = "0x40002A8")]
	OculusPurchased = 1,
	[Cpp2IlInjected.Token(Token = "0x40002A9")]
	PlayStationPurchased = 2,
	[Cpp2IlInjected.Token(Token = "0x40002AA")]
	MicrosoftPurchased = 3,
	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	IOSPurchased = 5,
	[Cpp2IlInjected.Token(Token = "0x40002AC")]
	GooglePlayPurchased = 6,
	[Cpp2IlInjected.Token(Token = "0x40002AD")]
	PicoPurchased = 8,
	[Cpp2IlInjected.Token(Token = "0x40002AE")]
	RecNetPurchased = 4,
	[Cpp2IlInjected.Token(Token = "0x40002AF")]
	SwitchPurchased = 9,
	[Cpp2IlInjected.Token(Token = "0x40002B0")]
	[Obsolete("Subscription benefits for PS4 players were awarded with this balance type. It is not transferrable to other platforms. Usable in P2P economy. We are using PlayStationPurchased instead now. -- bilal - 11/11/2020")]
	PlayStationNonPurchasedP2P = 100,
	[Cpp2IlInjected.Token(Token = "0x40002B1")]
	[Obsolete("Subscription benefits for NON PS4 players were awarded with this balance type. We are using <PlatformType>Purchased instead now. -- bilal - 11/11/2020")]
	NonPlayStationNonPurchasedP2P = 101,
	[Cpp2IlInjected.Token(Token = "0x40002B2")]
	NonPurchasedEarnedByP2P = 1000,
	[Cpp2IlInjected.Token(Token = "0x40002B3")]
	NonPurchasedEarnedByP2Pv2 = 1001
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
public enum AKGOFIOCCAL
{
	[Cpp2IlInjected.Token(Token = "0x40002B5")]
	None = -1,
	[Cpp2IlInjected.Token(Token = "0x40002B6")]
	Default = 0,
	[Cpp2IlInjected.Token(Token = "0x40002B7")]
	First_Activity = 1,
	[Cpp2IlInjected.Token(Token = "0x40002B8")]
	Game_Drop = 2,
	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	All_Daily_Challenges_Complete = 3,
	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	All_Weekly_Challenge_Complete = 4,
	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	Daily_Challenge_Complete = 5,
	[Cpp2IlInjected.Token(Token = "0x40002BC")]
	Weekly_Challenge_Complete = 6,
	[Cpp2IlInjected.Token(Token = "0x40002BD")]
	Unassigned_Equipment = 10,
	[Cpp2IlInjected.Token(Token = "0x40002BE")]
	Unassigned_Avatar = 11,
	[Cpp2IlInjected.Token(Token = "0x40002BF")]
	Unassigned_Consumable = 12,
	[Cpp2IlInjected.Token(Token = "0x40002C0")]
	Reacquisition = 20,
	[Cpp2IlInjected.Token(Token = "0x40002C1")]
	Membership = 21,
	[Cpp2IlInjected.Token(Token = "0x40002C2")]
	NUX_TokensAndDressUp = 30,
	[Cpp2IlInjected.Token(Token = "0x40002C3")]
	NUX_Experiment1 = 31,
	[Cpp2IlInjected.Token(Token = "0x40002C4")]
	NUX_Experiment2 = 32,
	[Cpp2IlInjected.Token(Token = "0x40002C5")]
	NUX_Experiment3 = 33,
	[Cpp2IlInjected.Token(Token = "0x40002C6")]
	NUX_Experiment4 = 34,
	[Cpp2IlInjected.Token(Token = "0x40002C7")]
	NUX_Experiment5 = 35,
	[Cpp2IlInjected.Token(Token = "0x40002C8")]
	GameRewards = 50,
	[Cpp2IlInjected.Token(Token = "0x40002C9")]
	GameRewards_Tokens = 51,
	[Cpp2IlInjected.Token(Token = "0x40002CA")]
	GameRewards_Tokens_Experiment_Override = 52,
	[Cpp2IlInjected.Token(Token = "0x40002CB")]
	GameRewards_A = 53,
	[Cpp2IlInjected.Token(Token = "0x40002CC")]
	GameRewards_B = 54,
	[Cpp2IlInjected.Token(Token = "0x40002CD")]
	LevelUp = 100,
	[Cpp2IlInjected.Token(Token = "0x40002CE")]
	Purchased_Gift_A = 500,
	[Cpp2IlInjected.Token(Token = "0x40002CF")]
	Purchased_Gift_B = 501,
	[Cpp2IlInjected.Token(Token = "0x40002D0")]
	Purchased_Gift_C = 502,
	[Cpp2IlInjected.Token(Token = "0x40002D1")]
	Purchased_Gift_D = 503,
	[Cpp2IlInjected.Token(Token = "0x40002D2")]
	Holiday = 1000,
	[Cpp2IlInjected.Token(Token = "0x40002D3")]
	Contest = 1001,
	[Cpp2IlInjected.Token(Token = "0x40002D4")]
	Promotion = 1002,
	[Cpp2IlInjected.Token(Token = "0x40002D5")]
	LimitedTime = 1003,
	[Cpp2IlInjected.Token(Token = "0x40002D6")]
	LimitedTimeEvent = 1004,
	[Cpp2IlInjected.Token(Token = "0x40002D7")]
	Deprecated = 1100,
	[Cpp2IlInjected.Token(Token = "0x40002D8")]
	RecRoyale = 1200,
	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	Friendotron_Gift = 1300,
	[Cpp2IlInjected.Token(Token = "0x40002DA")]
	DEPRECATED_Paintball_ClearCut = 2000,
	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	DEPRECATED_Paintball_Homestead = 2001,
	[Cpp2IlInjected.Token(Token = "0x40002DC")]
	DEPRECATED_Paintball_Quarry = 2002,
	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	DEPRECATED_Paintball_River = 2003,
	[Cpp2IlInjected.Token(Token = "0x40002DE")]
	DEPRECATED_Paintball_Dam = 2004,
	[Cpp2IlInjected.Token(Token = "0x40002DF")]
	DEPRECATED_Paintball_DriveIn = 2005,
	[Cpp2IlInjected.Token(Token = "0x40002E0")]
	Paintball_ClearCut = 2010,
	[Cpp2IlInjected.Token(Token = "0x40002E1")]
	Paintball_Homestead = 2011,
	[Cpp2IlInjected.Token(Token = "0x40002E2")]
	Paintball_Quarry = 2012,
	[Cpp2IlInjected.Token(Token = "0x40002E3")]
	Paintball_River = 2013,
	[Cpp2IlInjected.Token(Token = "0x40002E4")]
	Paintball_Dam = 2014,
	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	Paintball_DriveIn = 2015,
	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	DEPRECATED_Discgolf_Propulsion = 3000,
	[Cpp2IlInjected.Token(Token = "0x40002E7")]
	DEPRECATED_Discgolf_Lake = 3001,
	[Cpp2IlInjected.Token(Token = "0x40002E8")]
	Discgolf_Propulsion = 3010,
	[Cpp2IlInjected.Token(Token = "0x40002E9")]
	Discgolf_Lake = 3011,
	[Cpp2IlInjected.Token(Token = "0x40002EA")]
	Discgolf_Mode_CoopCatch = 3500,
	[Cpp2IlInjected.Token(Token = "0x40002EB")]
	Quest_Goblin_A = 4000,
	[Cpp2IlInjected.Token(Token = "0x40002EC")]
	Quest_Goblin_B = 4001,
	[Cpp2IlInjected.Token(Token = "0x40002ED")]
	Quest_Goblin_C = 4002,
	[Cpp2IlInjected.Token(Token = "0x40002EE")]
	Quest_Goblin_S = 4003,
	[Cpp2IlInjected.Token(Token = "0x40002EF")]
	Quest_Goblin_Consumable = 4004,
	[Cpp2IlInjected.Token(Token = "0x40002F0")]
	Quest_Cauldron_A = 4010,
	[Cpp2IlInjected.Token(Token = "0x40002F1")]
	Quest_Cauldron_B = 4011,
	[Cpp2IlInjected.Token(Token = "0x40002F2")]
	Quest_Cauldron_C = 4012,
	[Cpp2IlInjected.Token(Token = "0x40002F3")]
	Quest_Cauldron_S = 4013,
	[Cpp2IlInjected.Token(Token = "0x40002F4")]
	Quest_Cauldron_Consumable = 4014,
	[Cpp2IlInjected.Token(Token = "0x40002F5")]
	Quest_Pirate1_A = 4100,
	[Cpp2IlInjected.Token(Token = "0x40002F6")]
	Quest_Pirate1_B = 4101,
	[Cpp2IlInjected.Token(Token = "0x40002F7")]
	Quest_Pirate1_C = 4102,
	[Cpp2IlInjected.Token(Token = "0x40002F8")]
	Quest_Pirate1_S = 4103,
	[Cpp2IlInjected.Token(Token = "0x40002F9")]
	Quest_Pirate1_X = 4104,
	[Cpp2IlInjected.Token(Token = "0x40002FA")]
	Quest_Pirate1_Consumable = 4105,
	[Cpp2IlInjected.Token(Token = "0x40002FB")]
	Quest_Dracula1_A = 4200,
	[Cpp2IlInjected.Token(Token = "0x40002FC")]
	Quest_Dracula1_B = 4201,
	[Cpp2IlInjected.Token(Token = "0x40002FD")]
	Quest_Dracula1_C = 4202,
	[Cpp2IlInjected.Token(Token = "0x40002FE")]
	Quest_Dracula1_S = 4203,
	[Cpp2IlInjected.Token(Token = "0x40002FF")]
	Quest_Dracula1_X = 4204,
	[Cpp2IlInjected.Token(Token = "0x4000300")]
	Quest_Dracula1_Consumable = 4205,
	[Cpp2IlInjected.Token(Token = "0x4000301")]
	Quest_Dracula1_SS = 4206,
	[Cpp2IlInjected.Token(Token = "0x4000302")]
	Quest_SciFi_A = 4500,
	[Cpp2IlInjected.Token(Token = "0x4000303")]
	Quest_SciFi_B = 4501,
	[Cpp2IlInjected.Token(Token = "0x4000304")]
	Quest_SciFi_C = 4502,
	[Cpp2IlInjected.Token(Token = "0x4000305")]
	Quest_SciFi_S = 4503,
	[Cpp2IlInjected.Token(Token = "0x4000306")]
	Quest_Scifi_Consumable = 4504,
	[Cpp2IlInjected.Token(Token = "0x4000307")]
	DEPRECATED_Charades = 5000,
	[Cpp2IlInjected.Token(Token = "0x4000308")]
	Charades = 5001,
	[Cpp2IlInjected.Token(Token = "0x4000309")]
	DEPRECATED_Soccer = 6000,
	[Cpp2IlInjected.Token(Token = "0x400030A")]
	Soccer = 6001,
	[Cpp2IlInjected.Token(Token = "0x400030B")]
	DEPRECATED_Paddleball = 7000,
	[Cpp2IlInjected.Token(Token = "0x400030C")]
	Paddleball = 7001,
	[Cpp2IlInjected.Token(Token = "0x400030D")]
	DEPRECATED_Dodgeball = 8000,
	[Cpp2IlInjected.Token(Token = "0x400030E")]
	Dodgeball = 8001,
	[Cpp2IlInjected.Token(Token = "0x400030F")]
	DEPRECATED_Lasertag = 9000,
	[Cpp2IlInjected.Token(Token = "0x4000310")]
	Lasertag = 9001,
	[Cpp2IlInjected.Token(Token = "0x4000311")]
	DEPRECATED_Bowling = 10000,
	[Cpp2IlInjected.Token(Token = "0x4000312")]
	Bowling = 10001,
	[Cpp2IlInjected.Token(Token = "0x4000313")]
	StuntRunner_TheMainEvent_A = 11000,
	[Cpp2IlInjected.Token(Token = "0x4000314")]
	StuntRunner_TheMainEvent_B = 11001,
	[Cpp2IlInjected.Token(Token = "0x4000315")]
	StuntRunner_TheMainEvent_C = 11002,
	[Cpp2IlInjected.Token(Token = "0x4000316")]
	StuntRunner_TheMainEvent_D = 11003,
	[Cpp2IlInjected.Token(Token = "0x4000317")]
	StuntRunner_TheMainEvent_S = 11004,
	[Cpp2IlInjected.Token(Token = "0x4000318")]
	StuntRunner_TheMainEvent_X = 11005,
	[Cpp2IlInjected.Token(Token = "0x4000319")]
	StuntRunner_TheMainEvent_Consumable = 11006,
	[Cpp2IlInjected.Token(Token = "0x400031A")]
	StuntRunner_TheMainEvent_SS = 11007,
	[Cpp2IlInjected.Token(Token = "0x400031B")]
	RecRally = 12000,
	[Cpp2IlInjected.Token(Token = "0x400031C")]
	Showdown_A = 12100,
	[Cpp2IlInjected.Token(Token = "0x400031D")]
	Showdown_B = 12101,
	[Cpp2IlInjected.Token(Token = "0x400031E")]
	Showdown_C = 12102,
	[Cpp2IlInjected.Token(Token = "0x400031F")]
	MyLittleMonsters = 12200,
	[Cpp2IlInjected.Token(Token = "0x4000320")]
	RunTheBlock = 12300,
	[Cpp2IlInjected.Token(Token = "0x4000321")]
	RROStorefront_ToBeNamed_2 = 12400,
	[Cpp2IlInjected.Token(Token = "0x4000322")]
	ProgressionEvent = 13000,
	[Cpp2IlInjected.Token(Token = "0x4000323")]
	Store_LaserTag = 100000,
	[Cpp2IlInjected.Token(Token = "0x4000324")]
	Store_RecCenter = 100010,
	[Cpp2IlInjected.Token(Token = "0x4000325")]
	Consumable = 110000,
	[Cpp2IlInjected.Token(Token = "0x4000326")]
	Token = 110100,
	[Cpp2IlInjected.Token(Token = "0x4000327")]
	Punchcard_Challenge_Complete = 110200,
	[Cpp2IlInjected.Token(Token = "0x4000328")]
	All_Punchcard_Challenges_Complete = 110201,
	[Cpp2IlInjected.Token(Token = "0x4000329")]
	New_Player_Checklist_Item_Complete = 110300,
	[Cpp2IlInjected.Token(Token = "0x400032A")]
	Commerce_Purchase = 200000,
	[Cpp2IlInjected.Token(Token = "0x400032B")]
	Gift_Card_Redemption = 210000
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public enum KKHKGMOAKDA
{
	[Cpp2IlInjected.Token(Token = "0x400032D")]
	None = -1,
	[Cpp2IlInjected.Token(Token = "0x400032E")]
	Common = 0,
	[Cpp2IlInjected.Token(Token = "0x400032F")]
	Uncommon = 10,
	[Cpp2IlInjected.Token(Token = "0x4000330")]
	Rare = 20,
	[Cpp2IlInjected.Token(Token = "0x4000331")]
	Epic = 30,
	[Cpp2IlInjected.Token(Token = "0x4000332")]
	Legendary = 50
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
public enum EBHFKFFGGPP
{
	[Cpp2IlInjected.Token(Token = "0x4000334")]
	OK,
	[Cpp2IlInjected.Token(Token = "0x4000335")]
	TooManyRequests,
	[Cpp2IlInjected.Token(Token = "0x4000336")]
	NotEnoughCredit,
	[Cpp2IlInjected.Token(Token = "0x4000337")]
	AlreadyOwned,
	[Cpp2IlInjected.Token(Token = "0x4000338")]
	NoItemAvailable,
	[Cpp2IlInjected.Token(Token = "0x4000339")]
	CouponNotApplicable,
	[Cpp2IlInjected.Token(Token = "0x400033A")]
	RequestedPriceDoesNotMatch,
	[Cpp2IlInjected.Token(Token = "0x400033B")]
	RequestedAmountNotAllowed,
	[Cpp2IlInjected.Token(Token = "0x400033C")]
	PlayerNotEligible,
	[Cpp2IlInjected.Token(Token = "0x400033D")]
	RequestCannotBeRefunded,
	[Cpp2IlInjected.Token(Token = "0x400033E")]
	PlayerNotApproved
}
namespace RecNet
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	[BDENCKNLAKO]
	public class BalanceResponseDTO : HDINHDBEFHC
	{
		[Cpp2IlInjected.Token(Token = "0x170001D7")]
		public long Balance
		{
			[Cpp2IlInjected.Token(Token = "0x600043F")]
			[Cpp2IlInjected.Address(RVA = "0x9DF710", Offset = "0x9DDF10", VA = "0x1809DF710")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000440")]
			[Cpp2IlInjected.Address(RVA = "0xCDCAB0", Offset = "0xCDB2B0", VA = "0x180CDCAB0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D8")]
		public FIEOJKLGOND CurrencyType
		{
			[Cpp2IlInjected.Token(Token = "0x6000441")]
			[Cpp2IlInjected.Address(RVA = "0x9E9470", Offset = "0x9E7C70", VA = "0x1809E9470")]
			[CompilerGenerated]
			get
			{
				return default(FIEOJKLGOND);
			}
			[Cpp2IlInjected.Token(Token = "0x6000442")]
			[Cpp2IlInjected.Address(RVA = "0x9EC7A0", Offset = "0x9EAFA0", VA = "0x1809EC7A0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D9")]
		[DataMember(Name = "Platform")]
		public LJOOEGFMDKC BalanceType
		{
			[Cpp2IlInjected.Token(Token = "0x6000443")]
			[Cpp2IlInjected.Address(RVA = "0xA07330", Offset = "0xA05B30", VA = "0x180A07330")]
			[CompilerGenerated]
			get
			{
				return default(LJOOEGFMDKC);
			}
			[Cpp2IlInjected.Token(Token = "0x6000444")]
			[Cpp2IlInjected.Address(RVA = "0xD3DBC0", Offset = "0xD3C3C0", VA = "0x180D3DBC0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "5")]
		public virtual void AOEGOOLELIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public BalanceResponseDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	[BDENCKNLAKO]
	public class FilteredTextDTO : HDINHDBEFHC
	{
		[Cpp2IlInjected.Token(Token = "0x170001DA")]
		public string ADBDGDHMIAH
		{
			[Cpp2IlInjected.Token(Token = "0x6000447")]
			[Cpp2IlInjected.Address(RVA = "0x9DF710", Offset = "0x9DDF10", VA = "0x1809DF710")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000448")]
			[Cpp2IlInjected.Address(RVA = "0x9DF720", Offset = "0x9DDF20", VA = "0x1809DF720")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DB")]
		public int INMDAOGAFLL
		{
			[Cpp2IlInjected.Token(Token = "0x6000449")]
			[Cpp2IlInjected.Address(RVA = "0x9E9470", Offset = "0x9E7C70", VA = "0x1809E9470")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600044A")]
			[Cpp2IlInjected.Address(RVA = "0x9EC7A0", Offset = "0x9EAFA0", VA = "0x1809EC7A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "4")]
		public void AOEGOOLELIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044C")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public FilteredTextDTO()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
[BDENCKNLAKO]
public class FPIPOPFPJJP : HDINHDBEFHC
{
	[Cpp2IlInjected.Token(Token = "0x170001DC")]
	public string NICBEJJLIBF
	{
		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0x9DF710", Offset = "0x9DDF10", VA = "0x1809DF710")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0x9DF720", Offset = "0x9DDF20", VA = "0x1809DF720")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001DD")]
	public string CHIGODNNKCO
	{
		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x9DF700", Offset = "0x9DDF00", VA = "0x1809DF700")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "4")]
	public void AOEGOOLELIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public FPIPOPFPJJP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
[BDENCKNLAKO]
public class JJOCNNDDEEE : HDINHDBEFHC
{
	[Cpp2IlInjected.Token(Token = "0x170001DE")]
	public List<FPIPOPFPJJP> MGBBNGLHPAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0x9DF710", Offset = "0x9DDF10", VA = "0x1809DF710")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0x9DF720", Offset = "0x9DDF20", VA = "0x1809DF720")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "4")]
	public void AOEGOOLELIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public JJOCNNDDEEE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
[BDENCKNLAKO]
public class NKNIBJCHANO : HDINHDBEFHC
{
	[Cpp2IlInjected.Token(Token = "0x170001DF")]
	public string OBKLDGDALAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000457")]
		[Cpp2IlInjected.Address(RVA = "0x9DF710", Offset = "0x9DDF10", VA = "0x1809DF710")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000458")]
		[Cpp2IlInjected.Address(RVA = "0x9DF720", Offset = "0x9DDF20", VA = "0x1809DF720")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x9EBB90", Offset = "0x9EA390", VA = "0x1809EBB90")]
	public NKNIBJCHANO(string PKGEHDOKOHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "4")]
	public void AOEGOOLELIF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
[BDENCKNLAKO]
public class NAEBKBNMFCJ : HDINHDBEFHC
{
	[Cpp2IlInjected.Token(Token = "0x170001E0")]
	public List<FPIPOPFPJJP> MGBBNGLHPAD
	{
		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(RVA = "0x9DF710", Offset = "0x9DDF10", VA = "0x1809DF710")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0x9DF720", Offset = "0x9DDF20", VA = "0x1809DF720")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "4")]
	public void AOEGOOLELIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public NAEBKBNMFCJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
[BDENCKNLAKO]
public class KKDFCHFCKMK : HDINHDBEFHC
{
	[Cpp2IlInjected.Token(Token = "0x170001E1")]
	public List<NKNIBJCHANO> MMGJOBILIEP
	{
		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0x9DF710", Offset = "0x9DDF10", VA = "0x1809DF710")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(RVA = "0x9DF720", Offset = "0x9DDF20", VA = "0x1809DF720")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001E2")]
	public string LBMCOGFDEHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000461")]
		[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000462")]
		[Cpp2IlInjected.Address(RVA = "0x9DF700", Offset = "0x9DDF00", VA = "0x1809DF700")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001E3")]
	public bool IDKIINICEIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(RVA = "0x9E0E00", Offset = "0x9DF600", VA = "0x1809E0E00")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0x9E0E10", Offset = "0x9DF610", VA = "0x1809E0E10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001E4")]
	public int LCCEIDCICGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0xCE6F70", Offset = "0xCE5770", VA = "0x180CE6F70")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0xEF7300", Offset = "0xEF5B00", VA = "0x180EF7300")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public KKDFCHFCKMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x7071D90", Offset = "0x7070590", VA = "0x187071D90")]
	public KKDFCHFCKMK(string GGJHNOCCFNF, List<NKNIBJCHANO> IKEAFJEKLCE, bool OCNILMFCKCI, int JFNCDOKKMIN = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "4")]
	public void AOEGOOLELIF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
[BDENCKNLAKO]
public class HGAFGJBNJNO : HDINHDBEFHC
{
	[Cpp2IlInjected.Token(Token = "0x170001E5")]
	public List<NAEBKBNMFCJ> GCBKIMFBEBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x9DF710", Offset = "0x9DDF10", VA = "0x1809DF710")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0x9DF720", Offset = "0x9DDF20", VA = "0x1809DF720")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001E6")]
	public bool IDKIINICEIB
	{
		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0xA85410", Offset = "0xA83C10", VA = "0x180A85410")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x9E1B40", Offset = "0x9E0340", VA = "0x1809E1B40")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "4")]
	public void AOEGOOLELIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public HGAFGJBNJNO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
[BDENCKNLAKO]
public class OMEKGGFLNKA : HDINHDBEFHC
{
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	public enum APEMCGNMOCG
	{
		[Cpp2IlInjected.Token(Token = "0x4000353")]
		EnqueuedPending,
		[Cpp2IlInjected.Token(Token = "0x4000354")]
		DequeuedStarting,
		[Cpp2IlInjected.Token(Token = "0x4000355")]
		CompleteSuccess
	}

	[Cpp2IlInjected.Token(Token = "0x400034F")]
	public const string KGDPEHKDENN = "StringAutoLocalizationJob";

	[Cpp2IlInjected.Token(Token = "0x170001E7")]
	public string LBMCOGFDEHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x9DF710", Offset = "0x9DDF10", VA = "0x1809DF710")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x9DF720", Offset = "0x9DDF20", VA = "0x1809DF720")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001E8")]
	public APEMCGNMOCG OAAOOKAPDKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x9E9470", Offset = "0x9E7C70", VA = "0x1809E9470")]
		[CompilerGenerated]
		get
		{
			return default(APEMCGNMOCG);
		}
		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x9EC7A0", Offset = "0x9EAFA0", VA = "0x1809EC7A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x7073A60", Offset = "0x7072260", VA = "0x187073A60")]
	public OMEKGGFLNKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x7073A10", Offset = "0x7072210", VA = "0x187073A10")]
	public OMEKGGFLNKA(string GGJHNOCCFNF, APEMCGNMOCG LMFHHGHJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "4")]
	public void AOEGOOLELIF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
[BDENCKNLAKO]
public class JBLBOGDMNCL : HDINHDBEFHC
{
	[Cpp2IlInjected.Token(Token = "0x170001E9")]
	public bool BFPMPKADKEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0xC47930", Offset = "0xC46130", VA = "0x180C47930")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(RVA = "0xC466E0", Offset = "0xC44EE0", VA = "0x180C466E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "4")]
	public void AOEGOOLELIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public JBLBOGDMNCL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
public static class OAPJJHMCLAN
{
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	public enum HKHDPGEAODK
	{
		[Cpp2IlInjected.Token(Token = "0x4000358")]
		CoC_Discriminatory,
		[Cpp2IlInjected.Token(Token = "0x4000359")]
		CoC_Sexual,
		[Cpp2IlInjected.Token(Token = "0x400035A")]
		CoC_Trolling,
		[Cpp2IlInjected.Token(Token = "0x400035B")]
		Misleading,
		[Cpp2IlInjected.Token(Token = "0x400035C")]
		Other,
		[Cpp2IlInjected.Token(Token = "0x400035D")]
		InappropriateClothing
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
[BDENCKNLAKO]
public class GBANEJGHIOJ : HDINHDBEFHC
{
	[Cpp2IlInjected.Token(Token = "0x170001EA")]
	public long MPBMECOMGLA
	{
		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x9DF710", Offset = "0x9DDF10", VA = "0x1809DF710")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0xCDCAB0", Offset = "0xCDB2B0", VA = "0x180CDCAB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001EB")]
	public Guid NGHMJJBAAON
	{
		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0xBEBD90", Offset = "0xBEA590", VA = "0x180BEBD90")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0xDA40F0", Offset = "0xDA28F0", VA = "0x180DA40F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001EC")]
	public long HEGCGOODJKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0x9DF790", Offset = "0x9DDF90", VA = "0x1809DF790")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(RVA = "0x9E0DE0", Offset = "0x9DF5E0", VA = "0x1809E0DE0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001ED")]
	public PKKDMDAFDNG GDAFPJHNMNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(RVA = "0x9DF770", Offset = "0x9DDF70", VA = "0x1809DF770")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0x9DF750", Offset = "0x9DDF50", VA = "0x1809DF750")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public GBANEJGHIOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(RVA = "0x706EAF0", Offset = "0x706D2F0", VA = "0x18706EAF0")]
	public GBANEJGHIOJ(long MDLDCACFGIB, Guid PGFOOHKJEBD, long JBLCDPEEHBE, PKKDMDAFDNG CNMGAKDGFGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x706EAD0", Offset = "0x706D2D0", VA = "0x18706EAD0", Slot = "4")]
	public void AOEGOOLELIF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
[BDENCKNLAKO]
public class BHNCPHCJCEH : HDINHDBEFHC
{
	[Cpp2IlInjected.Token(Token = "0x170001EE")]
	public DNIFKKNCMME JBGJDBLIIKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x9DD1A0", Offset = "0x9DB9A0", VA = "0x1809DD1A0")]
		[CompilerGenerated]
		get
		{
			return default(DNIFKKNCMME);
		}
		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x9EBF60", Offset = "0x9EA760", VA = "0x1809EBF60")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001EF")]
	public DHKFIBAHAEL MLOAMBBHDPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x9DF700", Offset = "0x9DDF00", VA = "0x1809DF700")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public BHNCPHCJCEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0xEA3BB0", Offset = "0xEA23B0", VA = "0x180EA3BB0")]
	public BHNCPHCJCEH(DNIFKKNCMME HLPIAOANGMD, DHKFIBAHAEL AHEFNMJAIHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "4")]
	public void AOEGOOLELIF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
[BDENCKNLAKO]
public class PKKDMDAFDNG : HDINHDBEFHC
{
	[Cpp2IlInjected.Token(Token = "0x170001F0")]
	public Guid? CICJKAMOJGC
	{
		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(RVA = "0x2D818C0", Offset = "0x2D800C0", VA = "0x182D818C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(RVA = "0x7074570", Offset = "0x7072D70", VA = "0x187074570")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001F1")]
	public Guid ADAFPNBPDCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(RVA = "0xCF7CC0", Offset = "0xCF64C0", VA = "0x180CF7CC0")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(RVA = "0xF05A80", Offset = "0xF04280", VA = "0x180F05A80")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public PKKDMDAFDNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x7074580", Offset = "0x7072D80", VA = "0x187074580")]
	public PKKDMDAFDNG(Guid? EMOKCKJDIBE, Guid BGLLFKOABJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "4")]
	public void AOEGOOLELIF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
[BDENCKNLAKO]
public class DHKFIBAHAEL : HDINHDBEFHC
{
	[Cpp2IlInjected.Token(Token = "0x170001F2")]
	public long MPBMECOMGLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(RVA = "0x9DF710", Offset = "0x9DDF10", VA = "0x1809DF710")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(RVA = "0xCDCAB0", Offset = "0xCDB2B0", VA = "0x180CDCAB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001F3")]
	public Guid NGHMJJBAAON
	{
		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(RVA = "0xBEBD90", Offset = "0xBEA590", VA = "0x180BEBD90")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0xDA40F0", Offset = "0xDA28F0", VA = "0x180DA40F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001F4")]
	public long FCHJPHAGFMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0x9DF790", Offset = "0x9DDF90", VA = "0x1809DF790")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0x9E0DE0", Offset = "0x9DF5E0", VA = "0x1809E0DE0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001F5")]
	public Guid CBHBPMHINGH
	{
		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0xDA6670", Offset = "0xDA4E70", VA = "0x180DA6670")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0xDA6BD0", Offset = "0xDA53D0", VA = "0x180DA6BD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001F6")]
	public DateTime OKKIKOGNGDL
	{
		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x9E2460", Offset = "0x9E0C60", VA = "0x1809E2460")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0xDFC010", Offset = "0xDFA810", VA = "0x180DFC010")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001F7")]
	public DateTime NEDBPOMOOOA
	{
		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x9E0DD0", Offset = "0x9DF5D0", VA = "0x1809E0DD0")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x6DAEEC0", Offset = "0x6DAD6C0", VA = "0x186DAEEC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "4")]
	public void AOEGOOLELIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public DHKFIBAHAEL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
[BDENCKNLAKO]
public class HFNDDBPMKJI : HDINHDBEFHC
{
	[Cpp2IlInjected.Token(Token = "0x170001F8")]
	public string ACOJEEABMOC
	{
		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x9DF710", Offset = "0x9DDF10", VA = "0x1809DF710")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x9DF720", Offset = "0x9DDF20", VA = "0x1809DF720")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001F9")]
	public string NJJPEPDLCHL
	{
		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x9DF700", Offset = "0x9DDF00", VA = "0x1809DF700")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001FA")]
	public string GFJBHKHMHCE
	{
		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x9DF730", Offset = "0x9DDF30", VA = "0x1809DF730")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x9DF740", Offset = "0x9DDF40", VA = "0x1809DF740")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001FB")]
	public List<long> APOIMAPFIIE
	{
		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x9DF790", Offset = "0x9DDF90", VA = "0x1809DF790")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x9DF780", Offset = "0x9DDF80", VA = "0x1809DF780")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001FC")]
	public List<MPLGNNAICHL> OGGFKGGAJMM
	{
		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0x9DF770", Offset = "0x9DDF70", VA = "0x1809DF770")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0x9DF750", Offset = "0x9DDF50", VA = "0x1809DF750")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001FD")]
	public string FNAJCJLKEEP
	{
		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0x9E0DB0", Offset = "0x9DF5B0", VA = "0x1809E0DB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0x9E0DC0", Offset = "0x9DF5C0", VA = "0x1809E0DC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001FE")]
	public byte? FPEBKJPMEDE
	{
		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0x706FD40", Offset = "0x706E540", VA = "0x18706FD40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0x706FD10", Offset = "0x706E510", VA = "0x18706FD10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001FF")]
	public int? NNHCOFLKPFA
	{
		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x706AD90", Offset = "0x7069590", VA = "0x18706AD90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0x706ACC0", Offset = "0x70694C0", VA = "0x18706ACC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000200")]
	public Guid? LICLALLJCBM
	{
		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0x706FD20", Offset = "0x706E520", VA = "0x18706FD20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004B3")]
		[Cpp2IlInjected.Address(RVA = "0x706FD00", Offset = "0x706E500", VA = "0x18706FD00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000201")]
	public bool JAAMNHLPHEF
	{
		[Cpp2IlInjected.Token(Token = "0x60004B4")]
		[Cpp2IlInjected.Address(RVA = "0x9E24B0", Offset = "0x9E0CB0", VA = "0x1809E24B0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60004B5")]
		[Cpp2IlInjected.Address(RVA = "0x9E2380", Offset = "0x9E0B80", VA = "0x1809E2380")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "4")]
	public void AOEGOOLELIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public HFNDDBPMKJI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
[BDENCKNLAKO]
public class EEJBDKFLKNK : HDINHDBEFHC
{
	[Cpp2IlInjected.Token(Token = "0x17000202")]
	public Guid LICLALLJCBM
	{
		[Cpp2IlInjected.Token(Token = "0x60004B8")]
		[Cpp2IlInjected.Address(RVA = "0xF63890", Offset = "0xF62090", VA = "0x180F63890")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		[Cpp2IlInjected.Address(RVA = "0xF63950", Offset = "0xF62150", VA = "0x180F63950")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000203")]
	public long MPBMECOMGLA
	{
		[Cpp2IlInjected.Token(Token = "0x60004BA")]
		[Cpp2IlInjected.Address(RVA = "0x9DF730", Offset = "0x9DDF30", VA = "0x1809DF730")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(RVA = "0xC79020", Offset = "0xC77820", VA = "0x180C79020")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000204")]
	public string ACOJEEABMOC
	{
		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0x9DF790", Offset = "0x9DDF90", VA = "0x1809DF790")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004BD")]
		[Cpp2IlInjected.Address(RVA = "0x9DF780", Offset = "0x9DDF80", VA = "0x1809DF780")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000205")]
	public string NJJPEPDLCHL
	{
		[Cpp2IlInjected.Token(Token = "0x60004BE")]
		[Cpp2IlInjected.Address(RVA = "0x9DF770", Offset = "0x9DDF70", VA = "0x1809DF770")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004BF")]
		[Cpp2IlInjected.Address(RVA = "0x9DF750", Offset = "0x9DDF50", VA = "0x1809DF750")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000206")]
	public string GFJBHKHMHCE
	{
		[Cpp2IlInjected.Token(Token = "0x60004C0")]
		[Cpp2IlInjected.Address(RVA = "0x9E0DB0", Offset = "0x9DF5B0", VA = "0x1809E0DB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004C1")]
		[Cpp2IlInjected.Address(RVA = "0x9E0DC0", Offset = "0x9DF5C0", VA = "0x1809E0DC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000207")]
	public DateTime OKKIKOGNGDL
	{
		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0x9E2460", Offset = "0x9E0C60", VA = "0x1809E2460")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0xDFC010", Offset = "0xDFA810", VA = "0x180DFC010")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000208")]
	public DateTime NEDBPOMOOOA
	{
		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0x9E0DD0", Offset = "0x9DF5D0", VA = "0x1809E0DD0")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0x6DAEEC0", Offset = "0x6DAD6C0", VA = "0x186DAEEC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000209")]
	public string FNAJCJLKEEP
	{
		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0x9DD200", Offset = "0x9DBA00", VA = "0x1809DD200")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0x9DD240", Offset = "0x9DBA40", VA = "0x1809DD240")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700020A")]
	public List<long> APOIMAPFIIE
	{
		[Cpp2IlInjected.Token(Token = "0x60004C8")]
		[Cpp2IlInjected.Address(RVA = "0x9DD230", Offset = "0x9DBA30", VA = "0x1809DD230")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(RVA = "0x9DD1D0", Offset = "0x9DB9D0", VA = "0x1809DD1D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700020B")]
	public List<EJIMKFPHKMF> OGGFKGGAJMM
	{
		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0x9DD210", Offset = "0x9DBA10", VA = "0x1809DD210")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0x9DD220", Offset = "0x9DBA20", VA = "0x1809DD220")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700020C")]
	public byte FPEBKJPMEDE
	{
		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(RVA = "0xCF7360", Offset = "0xCF5B60", VA = "0x180CF7360")]
		[CompilerGenerated]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(RVA = "0x11F8F80", Offset = "0x11F7780", VA = "0x1811F8F80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700020D")]
	public int NNHCOFLKPFA
	{
		[Cpp2IlInjected.Token(Token = "0x60004CE")]
		[Cpp2IlInjected.Address(RVA = "0xA14DB0", Offset = "0xA135B0", VA = "0x180A14DB0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0x12C7F20", Offset = "0x12C6720", VA = "0x1812C7F20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "4")]
	public void AOEGOOLELIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public EEJBDKFLKNK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
public enum DNIFKKNCMME
{
	[Cpp2IlInjected.Token(Token = "0x4000383")]
	Unknown = -1,
	[Cpp2IlInjected.Token(Token = "0x4000384")]
	Success,
	[Cpp2IlInjected.Token(Token = "0x4000385")]
	RoomInventoryItemDoesNotExist,
	[Cpp2IlInjected.Token(Token = "0x4000386")]
	PlayerDoesNotExist,
	[Cpp2IlInjected.Token(Token = "0x4000387")]
	RoomDoesNotExist,
	[Cpp2IlInjected.Token(Token = "0x4000388")]
	RequestQuantityTooLarge,
	[Cpp2IlInjected.Token(Token = "0x4000389")]
	PlayerHasReachedTheMinimumOwnedAmount,
	[Cpp2IlInjected.Token(Token = "0x400038A")]
	ConcurrencyCodeMismatch,
	[Cpp2IlInjected.Token(Token = "0x400038B")]
	InvalidConcurrencyCode
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
public interface MJKEGBGKJOF
{
	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<NJALFJAOODE<EEJBDKFLKNK>> MLCPDBOEFOA(Guid? NJHJECCCGDO, long MDLDCACFGIB, string GLGOHIJMLFB, string NIAMDMBDIJG, string LJANIECHELJ, string DJFINDIAKCO, byte AAMAJMKCBNJ, int AGNHOOELDII, [Optional] List<long> JHEIHGLJEKA, [Optional] List<EJIMKFPHKMF> EHCHEIAFPOF, bool BNDADHGIJAI = false, [Optional] CancellationToken DNHBNMHIDAC);

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<NJALFJAOODE<EEJBDKFLKNK>> DHGLGFEEMGC(Guid PGFOOHKJEBD, long MDLDCACFGIB, [Optional] string GLGOHIJMLFB, [Optional] string NIAMDMBDIJG, [Optional] string LJANIECHELJ, [Optional] List<long> JHEIHGLJEKA, [Optional] Dictionary<string, string> EHCHEIAFPOF, [Optional] string DJFINDIAKCO, [Optional] byte? AAMAJMKCBNJ, [Optional] int? AGNHOOELDII, [Optional] CancellationToken DNHBNMHIDAC);

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<KFNGEGFGHNK> EMALHECPLMH(Guid PGFOOHKJEBD, long MDLDCACFGIB, [Optional] CancellationToken DNHBNMHIDAC);

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task<List<EEJBDKFLKNK>> MNIJNGCFNAA(long MDLDCACFGIB, [Optional] CancellationToken DNHBNMHIDAC);

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task<List<DHKFIBAHAEL>> FFJPCMMHONP(long MDLDCACFGIB, [Optional] CancellationToken DNHBNMHIDAC);

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<List<BHNCPHCJCEH>> CDIENCHFBHG(long MDLDCACFGIB, List<GBANEJGHIOJ> LOCHJMGBNOG, [Optional] CancellationToken DNHBNMHIDAC);
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
[BDENCKNLAKO]
public class MPLGNNAICHL : HDINHDBEFHC
{
	[Cpp2IlInjected.Token(Token = "0x1700020E")]
	public string ACOJEEABMOC
	{
		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(RVA = "0x9DF710", Offset = "0x9DDF10", VA = "0x1809DF710")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004D9")]
		[Cpp2IlInjected.Address(RVA = "0x9DF720", Offset = "0x9DDF20", VA = "0x1809DF720")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700020F")]
	public string FNAJCJLKEEP
	{
		[Cpp2IlInjected.Token(Token = "0x60004DA")]
		[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004DB")]
		[Cpp2IlInjected.Address(RVA = "0x9DF700", Offset = "0x9DDF00", VA = "0x1809DF700")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "4")]
	public void AOEGOOLELIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public MPLGNNAICHL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
[BDENCKNLAKO]
public class EJIMKFPHKMF : HDINHDBEFHC
{
	[Cpp2IlInjected.Token(Token = "0x17000210")]
	public long LDFIBNHAPPM
	{
		[Cpp2IlInjected.Token(Token = "0x60004DE")]
		[Cpp2IlInjected.Address(RVA = "0x9DF710", Offset = "0x9DDF10", VA = "0x1809DF710")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x60004DF")]
		[Cpp2IlInjected.Address(RVA = "0xCDCAB0", Offset = "0xCDB2B0", VA = "0x180CDCAB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000211")]
	public string ACOJEEABMOC
	{
		[Cpp2IlInjected.Token(Token = "0x60004E0")]
		[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004E1")]
		[Cpp2IlInjected.Address(RVA = "0x9DF700", Offset = "0x9DDF00", VA = "0x1809DF700")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000212")]
	public string FNAJCJLKEEP
	{
		[Cpp2IlInjected.Token(Token = "0x60004E2")]
		[Cpp2IlInjected.Address(RVA = "0x9DF730", Offset = "0x9DDF30", VA = "0x1809DF730")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004E3")]
		[Cpp2IlInjected.Address(RVA = "0x9DF740", Offset = "0x9DDF40", VA = "0x1809DF740")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "4")]
	public void AOEGOOLELIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public EJIMKFPHKMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
[BDENCKNLAKO]
public class JCOEHPDGDOP : HDINHDBEFHC
{
	[Cpp2IlInjected.Token(Token = "0x17000213")]
	public long LDFIBNHAPPM
	{
		[Cpp2IlInjected.Token(Token = "0x60004E7")]
		[Cpp2IlInjected.Address(RVA = "0x9DF710", Offset = "0x9DDF10", VA = "0x1809DF710")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x60004E8")]
		[Cpp2IlInjected.Address(RVA = "0xCDCAB0", Offset = "0xCDB2B0", VA = "0x180CDCAB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000214")]
	public string FNAJCJLKEEP
	{
		[Cpp2IlInjected.Token(Token = "0x60004E9")]
		[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004EA")]
		[Cpp2IlInjected.Address(RVA = "0x9DF700", Offset = "0x9DDF00", VA = "0x1809DF700")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x488BE40", Offset = "0x488A640", VA = "0x18488BE40")]
	public JCOEHPDGDOP(long KEHLMAAOAKJ, string OMHBAAPJDOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "4")]
	public void AOEGOOLELIF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
public interface JAPDBJIJNMH
{
	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<NJALFJAOODE<List<EJIMKFPHKMF>>> IIKILJFAHEI(long MDLDCACFGIB, List<JCOEHPDGDOP> LOCHJMGBNOG, [Optional] CancellationToken DNHBNMHIDAC);

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<KFNGEGFGHNK> PHJBPADGHGP(long KEHLMAAOAKJ, [Optional] CancellationToken DNHBNMHIDAC);

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<List<EJIMKFPHKMF>> KPJMDOHLMJI(long MDLDCACFGIB, [Optional] CancellationToken DNHBNMHIDAC);
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
[BDENCKNLAKO]
public class FGPHLMFKCNC : KLGJFHMNMIM, IEquatable<FGPHLMFKCNC>
{
	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(RVA = "0x706E070", Offset = "0x706C870", VA = "0x18706E070", Slot = "7")]
	public bool Equals(FGPHLMFKCNC PGPJMFPAKOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F0")]
	[Cpp2IlInjected.Address(RVA = "0x706E0B0", Offset = "0x706C8B0", VA = "0x18706E0B0", Slot = "6")]
	public override KLGJFHMNMIM LMNLEEHCNJH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F1")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public FGPHLMFKCNC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
public static class KHFPIMFDIPL
{
	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(RVA = "0x7071D20", Offset = "0x7070520", VA = "0x187071D20")]
	public static FGPHLMFKCNC DCDLIDOFHJH(this JFPJFPPIPDF BLFLGKHLJNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(RVA = "0x7071C20", Offset = "0x7070420", VA = "0x187071C20")]
	public static FGPHLMFKCNC BADGNPPKOJM(string OFAGJKJMDGP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
[BDENCKNLAKO]
public class JFPJFPPIPDF : HDINHDBEFHC
{
	[Cpp2IlInjected.Token(Token = "0x4000393")]
	public const int OFPIAKDOBJG = 3;

	[Cpp2IlInjected.Token(Token = "0x4000394")]
	public const int FPEJJNDGGKG = 40;

	[Cpp2IlInjected.Token(Token = "0x4000395")]
	public const int KPDFFDKKDIL = 180;

	[Cpp2IlInjected.Token(Token = "0x4000396")]
	public const int PIKAHJFIFED = 1000;

	[Cpp2IlInjected.Token(Token = "0x4000397")]
	public const int BJLOCLKBLGI = 99999;

	[Cpp2IlInjected.Token(Token = "0x4000398")]
	public const int IKAIPGHNNOJ = 8;

	[Cpp2IlInjected.Token(Token = "0x4000399")]
	public const int DENBDONJIDM = 1;

	[Cpp2IlInjected.Token(Token = "0x400039A")]
	public const int BHFKLFJIDDA = 1000000000;

	[Cpp2IlInjected.Token(Token = "0x400039B")]
	public const int LHKGDCDGLPA = 9999;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40003A9")]
	[IgnoreDataMember]
	private IReadOnlyDictionary<Guid, int>? OPLKJNEFJFP;

	[Cpp2IlInjected.Token(Token = "0x17000215")]
	public Guid LICLALLJCBM
	{
		[Cpp2IlInjected.Token(Token = "0x60004F4")]
		[Cpp2IlInjected.Address(RVA = "0xF63890", Offset = "0xF62090", VA = "0x180F63890")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x60004F5")]
		[Cpp2IlInjected.Address(RVA = "0xF63950", Offset = "0xF62150", VA = "0x180F63950")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000216")]
	public long MPBMECOMGLA
	{
		[Cpp2IlInjected.Token(Token = "0x60004F6")]
		[Cpp2IlInjected.Address(RVA = "0x9DF730", Offset = "0x9DDF30", VA = "0x1809DF730")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x60004F7")]
		[Cpp2IlInjected.Address(RVA = "0xC79020", Offset = "0xC77820", VA = "0x180C79020")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000217")]
	public string ACOJEEABMOC
	{
		[Cpp2IlInjected.Token(Token = "0x60004F8")]
		[Cpp2IlInjected.Address(RVA = "0x9DF790", Offset = "0x9DDF90", VA = "0x1809DF790")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004F9")]
		[Cpp2IlInjected.Address(RVA = "0x9DF780", Offset = "0x9DDF80", VA = "0x1809DF780")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000218")]
	public string? NJJPEPDLCHL
	{
		[Cpp2IlInjected.Token(Token = "0x60004FA")]
		[Cpp2IlInjected.Address(RVA = "0x9DF770", Offset = "0x9DDF70", VA = "0x1809DF770")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004FB")]
		[Cpp2IlInjected.Address(RVA = "0x9DF750", Offset = "0x9DDF50", VA = "0x1809DF750")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000219")]
	public string? GFJBHKHMHCE
	{
		[Cpp2IlInjected.Token(Token = "0x60004FC")]
		[Cpp2IlInjected.Address(RVA = "0x9E0DB0", Offset = "0x9DF5B0", VA = "0x1809E0DB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004FD")]
		[Cpp2IlInjected.Address(RVA = "0x9E0DC0", Offset = "0x9DF5C0", VA = "0x1809E0DC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700021A")]
	public int CFBMCPJNOHN
	{
		[Cpp2IlInjected.Token(Token = "0x60004FE")]
		[Cpp2IlInjected.Address(RVA = "0x9EDEE0", Offset = "0x9EC6E0", VA = "0x1809EDEE0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60004FF")]
		[Cpp2IlInjected.Address(RVA = "0xDF1550", Offset = "0xDEFD50", VA = "0x180DF1550")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700021B")]
	public Guid? HEMPHGNHNLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000500")]
		[Cpp2IlInjected.Address(RVA = "0x70717C0", Offset = "0x706FFC0", VA = "0x1870717C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000501")]
		[Cpp2IlInjected.Address(RVA = "0x7071390", Offset = "0x706FB90", VA = "0x187071390")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700021C")]
	public int ILGJIFNMLEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000502")]
		[Cpp2IlInjected.Address(RVA = "0xD43E80", Offset = "0xD42680", VA = "0x180D43E80")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000503")]
		[Cpp2IlInjected.Address(RVA = "0xD44100", Offset = "0xD42900", VA = "0x180D44100")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700021D")]
	public int? BIKPMKEPPND
	{
		[Cpp2IlInjected.Token(Token = "0x6000504")]
		[Cpp2IlInjected.Address(RVA = "0x6A8E4A0", Offset = "0x6A8CCA0", VA = "0x186A8E4A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000505")]
		[Cpp2IlInjected.Address(RVA = "0x6A8E4C0", Offset = "0x6A8CCC0", VA = "0x186A8E4C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700021E")]
	public int? CILCOMJKPIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000506")]
		[Cpp2IlInjected.Address(RVA = "0x70713A0", Offset = "0x706FBA0", VA = "0x1870713A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000507")]
		[Cpp2IlInjected.Address(RVA = "0x70713B0", Offset = "0x706FBB0", VA = "0x1870713B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700021F")]
	public IReadOnlyList<LBEPFOJFIEI> JKBJEKDJGON
	{
		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(RVA = "0x9DD1F0", Offset = "0x9DB9F0", VA = "0x1809DD1F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(RVA = "0x9DD1E0", Offset = "0x9DB9E0", VA = "0x1809DD1E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000220")]
	public DateTime OKKIKOGNGDL
	{
		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0x9E93E0", Offset = "0x9E7BE0", VA = "0x1809E93E0")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x600050B")]
		[Cpp2IlInjected.Address(RVA = "0xE29760", Offset = "0xE27F60", VA = "0x180E29760")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000221")]
	public DateTime NEDBPOMOOOA
	{
		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(RVA = "0x9E9310", Offset = "0x9E7B10", VA = "0x1809E9310")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(RVA = "0xE294D0", Offset = "0xE27CD0", VA = "0x180E294D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000222")]
	[IgnoreDataMember]
	public GCFCGMIOOKJ HFOFCFEKAPL
	{
		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0x70713C0", Offset = "0x706FBC0", VA = "0x1870713C0")]
		get
		{
			return default(GCFCGMIOOKJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000223")]
	[IgnoreDataMember]
	public IReadOnlyDictionary<Guid, int> LDGOGBHCCFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0x7071770", Offset = "0x706FF70", VA = "0x187071770")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0x9E92D0", Offset = "0x9E7AD0", VA = "0x1809E92D0")]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(RVA = "0x7071380", Offset = "0x706FB80", VA = "0x187071380", Slot = "4")]
	public void AOEGOOLELIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000512")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public JFPJFPPIPDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000513")]
	[Cpp2IlInjected.Address(RVA = "0x70717E0", Offset = "0x706FFE0", VA = "0x1870717E0")]
	public JFPJFPPIPDF(Guid NJHJECCCGDO, long MDLDCACFGIB, string GLGOHIJMLFB, string NIAMDMBDIJG, string LJANIECHELJ, int BBCMDPJPAOE, int? PLBKBDMCCHF, int? LNPJBLPPKCO, List<LBEPFOJFIEI> LOKPAMFOFMG, [Optional] DateTime LIHJPHMPNOL, [Optional] DateTime GLOONLBLPGD, [Optional] Guid? ECJMHHIOGBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000514")]
	[Cpp2IlInjected.Address(RVA = "0x7071430", Offset = "0x706FC30", VA = "0x187071430")]
	private GCFCGMIOOKJ IKGMHGNAFGE()
	{
		return default(GCFCGMIOOKJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000515")]
	[Cpp2IlInjected.Address(RVA = "0x70714A0", Offset = "0x706FCA0", VA = "0x1870714A0")]
	private Dictionary<Guid, int> KAIAFMMPBAA(IReadOnlyList<LBEPFOJFIEI> LOKPAMFOFMG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
[BDENCKNLAKO]
public class MIHCBPAFGNN : HDINHDBEFHC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003AA")]
	public Guid LICLALLJCBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003AB")]
	public long MPBMECOMGLA;

	[Cpp2IlInjected.Token(Token = "0x6000516")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "4")]
	public void AOEGOOLELIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000517")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public MIHCBPAFGNN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
[BDENCKNLAKO]
public class MLAFGABEIIB : HDINHDBEFHC
{
	[Cpp2IlInjected.Token(Token = "0x17000224")]
	public string ACOJEEABMOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0x9DF710", Offset = "0x9DDF10", VA = "0x1809DF710")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0x9DF720", Offset = "0x9DDF20", VA = "0x1809DF720")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000225")]
	public string? NJJPEPDLCHL
	{
		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0x9DF700", Offset = "0x9DDF00", VA = "0x1809DF700")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000226")]
	public string? GFJBHKHMHCE
	{
		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0x9DF730", Offset = "0x9DDF30", VA = "0x1809DF730")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(RVA = "0x9DF740", Offset = "0x9DDF40", VA = "0x1809DF740")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000227")]
	public int CFBMCPJNOHN
	{
		[Cpp2IlInjected.Token(Token = "0x600051E")]
		[Cpp2IlInjected.Address(RVA = "0x9EBF90", Offset = "0x9EA790", VA = "0x1809EBF90")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600051F")]
		[Cpp2IlInjected.Address(RVA = "0x9EBF70", Offset = "0x9EA770", VA = "0x1809EBF70")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000228")]
	public int? BIKPMKEPPND
	{
		[Cpp2IlInjected.Token(Token = "0x6000520")]
		[Cpp2IlInjected.Address(RVA = "0xEABFA0", Offset = "0xEAA7A0", VA = "0x180EABFA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000521")]
		[Cpp2IlInjected.Address(RVA = "0xEABFD0", Offset = "0xEAA7D0", VA = "0x180EABFD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000229")]
	public int? CILCOMJKPIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000522")]
		[Cpp2IlInjected.Address(RVA = "0xC78FF0", Offset = "0xC777F0", VA = "0x180C78FF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(RVA = "0xC79040", Offset = "0xC77840", VA = "0x180C79040")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700022A")]
	public List<LBEPFOJFIEI> JKBJEKDJGON
	{
		[Cpp2IlInjected.Token(Token = "0x6000524")]
		[Cpp2IlInjected.Address(RVA = "0x9E2460", Offset = "0x9E0C60", VA = "0x1809E2460")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(RVA = "0x9E0DA0", Offset = "0x9DF5A0", VA = "0x1809E0DA0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700022B")]
	public Guid? AIHGGGJNKEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0x706D110", Offset = "0x706B910", VA = "0x18706D110")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0x706D200", Offset = "0x706BA00", VA = "0x18706D200")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700022C")]
	public Guid? LICLALLJCBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0x70732E0", Offset = "0x7071AE0", VA = "0x1870732E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x70732D0", Offset = "0x7071AD0", VA = "0x1870732D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700022D")]
	public bool JAAMNHLPHEF
	{
		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0xCF73B0", Offset = "0xCF5BB0", VA = "0x180CF73B0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0x13E0150", Offset = "0x13DE950", VA = "0x1813E0150")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(RVA = "0x70732C0", Offset = "0x7071AC0", VA = "0x1870732C0", Slot = "4")]
	public void AOEGOOLELIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052D")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public MLAFGABEIIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
[BDENCKNLAKO]
public class LBEPFOJFIEI : HDINHDBEFHC
{
	[Cpp2IlInjected.Token(Token = "0x1700022E")]
	public PCACGIONCDG IFCMPJACFHI
	{
		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(RVA = "0xC47930", Offset = "0xC46130", VA = "0x180C47930")]
		[CompilerGenerated]
		get
		{
			return default(PCACGIONCDG);
		}
		[Cpp2IlInjected.Token(Token = "0x600052F")]
		[Cpp2IlInjected.Address(RVA = "0xC466E0", Offset = "0xC44EE0", VA = "0x180C466E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700022F")]
	public Guid AGPLEAHODDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(RVA = "0x188DD40", Offset = "0x188C540", VA = "0x18188DD40")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(RVA = "0x5795F10", Offset = "0x5794710", VA = "0x185795F10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000230")]
	public int FCHJPHAGFMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000532")]
		[Cpp2IlInjected.Address(RVA = "0xCE6F70", Offset = "0xCE5770", VA = "0x180CE6F70")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000533")]
		[Cpp2IlInjected.Address(RVA = "0xEF7300", Offset = "0xEF5B00", VA = "0x180EF7300")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public LBEPFOJFIEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(RVA = "0x70723A0", Offset = "0x7070BA0", VA = "0x1870723A0")]
	public LBEPFOJFIEI(Guid BDIABKHKHBN, PCACGIONCDG PIJHKCJDAHO, int PCFOAHIEPDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000536")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "4")]
	public void AOEGOOLELIF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
[BDENCKNLAKO]
public class NEPIBHNNPJN : HDINHDBEFHC
{
	[Cpp2IlInjected.Token(Token = "0x17000231")]
	public Guid LIHAHDCDCBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0xF63890", Offset = "0xF62090", VA = "0x180F63890")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0xF63950", Offset = "0xF62150", VA = "0x180F63950")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000232")]
	public string ACOJEEABMOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0x9DF730", Offset = "0x9DDF30", VA = "0x1809DF730")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0x9DF740", Offset = "0x9DDF40", VA = "0x1809DF740")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000233")]
	public int AEJJJAICGAF
	{
		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0x9EBF90", Offset = "0x9EA790", VA = "0x1809EBF90")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0x9EBF70", Offset = "0x9EA770", VA = "0x1809EBF70")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000234")]
	public DateTime CHIMHIBEOLO
	{
		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0x9DF770", Offset = "0x9DDF70", VA = "0x1809DF770")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0x9E0DF0", Offset = "0x9DF5F0", VA = "0x1809E0DF0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000235")]
	public int ILGJIFNMLEF
	{
		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x9FCF80", Offset = "0x9FB780", VA = "0x1809FCF80")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0xD38EB0", Offset = "0xD376B0", VA = "0x180D38EB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000541")]
	[Cpp2IlInjected.Address(RVA = "0x70733B0", Offset = "0x7071BB0", VA = "0x1870733B0")]
	public NEPIBHNNPJN(Guid GBKHLEIHNJJ, string GLGOHIJMLFB, int HJAPLJKLIPD, DateTime MCHONMNJDEJ, int JLNEBEJFOHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public NEPIBHNNPJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000543")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "4")]
	public void AOEGOOLELIF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
[BDENCKNLAKO]
public class HGOMMDFEGNA : HDINHDBEFHC
{
	[Cpp2IlInjected.Token(Token = "0x17000236")]
	public Guid LIHAHDCDCBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0xF63890", Offset = "0xF62090", VA = "0x180F63890")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0xF63950", Offset = "0xF62150", VA = "0x180F63950")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000237")]
	public int BCJEIOONLLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0xBD6AB0", Offset = "0xBD52B0", VA = "0x180BD6AB0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000547")]
		[Cpp2IlInjected.Address(RVA = "0xC46540", Offset = "0xC44D40", VA = "0x180C46540")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public HGOMMDFEGNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(RVA = "0x4E2A7C0", Offset = "0x4E28FC0", VA = "0x184E2A7C0")]
	public HGOMMDFEGNA(Guid GBKHLEIHNJJ, int ABOOAOLLJBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054A")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "4")]
	public void AOEGOOLELIF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
[BDENCKNLAKO]
public class GEBJAJNBMNJ : HDINHDBEFHC
{
	[Cpp2IlInjected.Token(Token = "0x17000238")]
	public int BCJEIOONLLH
	{
		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(RVA = "0x9DD1A0", Offset = "0x9DB9A0", VA = "0x1809DD1A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(RVA = "0x9EBF60", Offset = "0x9EA760", VA = "0x1809EBF60")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000239")]
	public Guid DNHGKMDAGJA
	{
		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0x188DD40", Offset = "0x188C540", VA = "0x18188DD40")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x6000550")]
		[Cpp2IlInjected.Address(RVA = "0x5795F10", Offset = "0x5794710", VA = "0x185795F10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700023A")]
	public int NCNLALJCOOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000551")]
		[Cpp2IlInjected.Address(RVA = "0xCE6F70", Offset = "0xCE5770", VA = "0x180CE6F70")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000552")]
		[Cpp2IlInjected.Address(RVA = "0xEF7300", Offset = "0xEF5B00", VA = "0x180EF7300")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700023B")]
	public Guid? IGNGGMDJJFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000553")]
		[Cpp2IlInjected.Address(RVA = "0xE281E0", Offset = "0xE269E0", VA = "0x180E281E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000554")]
		[Cpp2IlInjected.Address(RVA = "0x213E990", Offset = "0x213D190", VA = "0x18213E990")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700023C")]
	public int NIEBLHGEAAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000555")]
		[Cpp2IlInjected.Address(RVA = "0x9FCF90", Offset = "0x9FB790", VA = "0x1809FCF90")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000556")]
		[Cpp2IlInjected.Address(RVA = "0x144A290", Offset = "0x1448A90", VA = "0x18144A290")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700023D")]
	public Dictionary<Guid, Guid?> GNLGGOHOMLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000557")]
		[Cpp2IlInjected.Address(RVA = "0x9E2460", Offset = "0x9E0C60", VA = "0x1809E2460")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0x9E0DA0", Offset = "0x9DF5A0", VA = "0x1809E0DA0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public GEBJAJNBMNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(RVA = "0x706F160", Offset = "0x706D960", VA = "0x18706F160")]
	public GEBJAJNBMNJ(int ABOOAOLLJBL, Guid KGHLAMMNFHM, int CFJHJINAHDH, Guid? DANKNCHGLFO, int MNFLFEIIBMD, Dictionary<Guid, Guid?> BDCMALJLLNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "4")]
	public void AOEGOOLELIF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
[BDENCKNLAKO]
public class DGOCPJLDHFO : HDINHDBEFHC
{
	[Cpp2IlInjected.Token(Token = "0x1700023E")]
	public GLMHIPLNDOP NOEIKOJJBCO
	{
		[Cpp2IlInjected.Token(Token = "0x600055C")]
		[Cpp2IlInjected.Address(RVA = "0xC47930", Offset = "0xC46130", VA = "0x180C47930")]
		[CompilerGenerated]
		get
		{
			return default(GLMHIPLNDOP);
		}
		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(RVA = "0xC466E0", Offset = "0xC44EE0", VA = "0x180C466E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700023F")]
	public EBHFKFFGGPP? AJNCIBELBHL
	{
		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(RVA = "0xEABF80", Offset = "0xEAA780", VA = "0x180EABF80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600055F")]
		[Cpp2IlInjected.Address(RVA = "0xEB4E30", Offset = "0xEB3630", VA = "0x180EB4E30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000240")]
	public BalanceResponseDTO MGNIKBACEJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(RVA = "0x9DF730", Offset = "0x9DDF30", VA = "0x1809DF730")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(RVA = "0x9DF740", Offset = "0x9DDF40", VA = "0x1809DF740")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000241")]
	public List<DHKFIBAHAEL> KBAJODIEMMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0x9DF790", Offset = "0x9DDF90", VA = "0x1809DF790")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x9DF780", Offset = "0x9DDF80", VA = "0x1809DF780")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public DGOCPJLDHFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(RVA = "0x706D480", Offset = "0x706BC80", VA = "0x18706D480")]
	public DGOCPJLDHFO(GLMHIPLNDOP IPLEIHBFJNI, EBHFKFFGGPP? AJNGPKENFMN, BalanceResponseDTO HJOIPNHEOPI, List<DHKFIBAHAEL> ELOJGLDOJNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000564")]
	[Cpp2IlInjected.Address(RVA = "0x706D470", Offset = "0x706BC70", VA = "0x18706D470", Slot = "4")]
	public void AOEGOOLELIF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
public enum PCACGIONCDG : byte
{
	[Cpp2IlInjected.Token(Token = "0x40003CB")]
	Unset,
	[Cpp2IlInjected.Token(Token = "0x40003CC")]
	RoomInventoryItem
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
public enum GLMHIPLNDOP : byte
{
	[Cpp2IlInjected.Token(Token = "0x40003CE")]
	Success = 0,
	[Cpp2IlInjected.Token(Token = "0x40003CF")]
	ConcurrencyCodeMismatch = 1,
	[Cpp2IlInjected.Token(Token = "0x40003D0")]
	RoomOfferDoesNotExist = 2,
	[Cpp2IlInjected.Token(Token = "0x40003D1")]
	InvalidRequest = 3,
	[Cpp2IlInjected.Token(Token = "0x40003D2")]
	AccountIdIsInvalid = 4,
	[Cpp2IlInjected.Token(Token = "0x40003D3")]
	PlayerIsP2PBuyingRestricted = 5,
	[Cpp2IlInjected.Token(Token = "0x40003D4")]
	ExpectedOfferTotalPriceMismatch = 6,
	[Cpp2IlInjected.Token(Token = "0x40003D5")]
	ExpectedOfferVersionMismatch = 7,
	[Cpp2IlInjected.Token(Token = "0x40003D6")]
	InsufficientBalance = 8,
	[Cpp2IlInjected.Token(Token = "0x40003D7")]
	OfferUnderModeration = 9,
	[Cpp2IlInjected.Token(Token = "0x40003D8")]
	InvalidExpectedTotalPrice = 10,
	[Cpp2IlInjected.Token(Token = "0x40003D9")]
	InvalidExpectedOfferVersion = 11,
	[Cpp2IlInjected.Token(Token = "0x40003DA")]
	CannotPurchaseMoreThanPerPlayerLimit = 12,
	[Cpp2IlInjected.Token(Token = "0x40003DB")]
	InvalidExpectedPriceUnit = 13,
	[Cpp2IlInjected.Token(Token = "0x40003DC")]
	InsufficientInventoryItems = 14,
	[Cpp2IlInjected.Token(Token = "0x40003DD")]
	NoConcurrencyCodesForInventoryItem = 100,
	[Cpp2IlInjected.Token(Token = "0x40003DE")]
	UnexpectedOfferItemType = 101,
	[Cpp2IlInjected.Token(Token = "0x40003DF")]
	FeatureDisabled = 254,
	[Cpp2IlInjected.Token(Token = "0x40003E0")]
	UnknownError = byte.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
public enum GCFCGMIOOKJ : byte
{
	[Cpp2IlInjected.Token(Token = "0x40003E2")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x40003E3")]
	OneTimePurchase,
	[Cpp2IlInjected.Token(Token = "0x40003E4")]
	BulkPurchase
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
public interface IGOFIAMJLAI
{
	[Cpp2IlInjected.Token(Token = "0x40003E5")]
	static HOPADDCECBJ<JFPJFPPIPDF> DCGLNGEDEBK;

	[Cpp2IlInjected.Token(Token = "0x40003E6")]
	static HOPADDCECBJ<JFPJFPPIPDF> CNGLLMEPEJE;

	[Cpp2IlInjected.Token(Token = "0x40003E7")]
	static HOPADDCECBJ<Guid> LONAEHDEHDN;

	[Cpp2IlInjected.Token(Token = "0x6000565")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<NJALFJAOODE<JFPJFPPIPDF?>?>? BPJMPNLNDOM(Guid? NJHJECCCGDO, long MDLDCACFGIB, string GLGOHIJMLFB, string? NIAMDMBDIJG, string? LJANIECHELJ, int BBCMDPJPAOE, GCFCGMIOOKJ KFCFICFFEGM, [Optional] Dictionary<Guid, int>? KNDAJKFINHI, [Optional] Guid? OBDKEHDOHMD, bool BNDADHGIJAI = false, [Optional] CancellationToken DNHBNMHIDAC);

	[Cpp2IlInjected.Token(Token = "0x6000566")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<NJALFJAOODE<JFPJFPPIPDF?>?>? CFOCFLCAIHD(Guid GBKHLEIHNJJ, long MDLDCACFGIB, string GLGOHIJMLFB, string? NIAMDMBDIJG, string? LJANIECHELJ, int BBCMDPJPAOE, GCFCGMIOOKJ KFCFICFFEGM, [Optional] Dictionary<Guid, int>? KNDAJKFINHI, [Optional] Guid? OBDKEHDOHMD, [Optional] CancellationToken DNHBNMHIDAC);

	[Cpp2IlInjected.Token(Token = "0x6000567")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<KFNGEGFGHNK> MIEJIAFDECN(Guid GBKHLEIHNJJ, long MDLDCACFGIB, [Optional] CancellationToken DNHBNMHIDAC);

	[Cpp2IlInjected.Token(Token = "0x6000568")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task<List<JFPJFPPIPDF>> IDFOAPGJDOF(long MDLDCACFGIB, [Optional] CancellationToken DNHBNMHIDAC);

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task<NJALFJAOODE<List<HGOMMDFEGNA>>> NHKIJHECLGB(long MDLDCACFGIB, [Optional] CancellationToken DNHBNMHIDAC);

	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<NJALFJAOODE<List<NEPIBHNNPJN>>> KFADAOJGBJN(long MDLDCACFGIB, [Optional] CancellationToken DNHBNMHIDAC);

	[Cpp2IlInjected.Token(Token = "0x600056B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task<DGOCPJLDHFO> FCMIMEPEGBK(Guid GBKHLEIHNJJ, long MDLDCACFGIB, int ABOOAOLLJBL, int CFJHJINAHDH, Guid? NOLIDKNNFPE, int MNFLFEIIBMD, Dictionary<Guid, Guid?> HOECGEMGNEP, [Optional] CancellationToken DNHBNMHIDAC);

	[Cpp2IlInjected.Token(Token = "0x600056C")]
	[Cpp2IlInjected.Address(RVA = "0x7070430", Offset = "0x706EC30", VA = "0x187070430")]
	static IGOFIAMJLAI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
[BDENCKNLAKO]
public class EMNBPACHFHA : HDINHDBEFHC
{
	[Cpp2IlInjected.Token(Token = "0x17000242")]
	public long MPBMECOMGLA
	{
		[Cpp2IlInjected.Token(Token = "0x600056D")]
		[Cpp2IlInjected.Address(RVA = "0x9DF710", Offset = "0x9DDF10", VA = "0x1809DF710")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(RVA = "0xCDCAB0", Offset = "0xCDB2B0", VA = "0x180CDCAB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000243")]
	public bool ADKLLGEEFDO
	{
		[Cpp2IlInjected.Token(Token = "0x600056F")]
		[Cpp2IlInjected.Address(RVA = "0xA85410", Offset = "0xA83C10", VA = "0x180A85410")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(RVA = "0x9E1B40", Offset = "0x9E0340", VA = "0x1809E1B40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "4")]
	public void AOEGOOLELIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public EMNBPACHFHA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
public interface EBHECEKKDLE
{
	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<EMNBPACHFHA> AJFILKENHHC(long MDLDCACFGIB, [Optional] CancellationToken DNHBNMHIDAC);

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<KFNGEGFGHNK> JEGEKFEEGOG(long MDLDCACFGIB, bool JDLCMNAHMEL, [Optional] CancellationToken DNHBNMHIDAC);
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
[LMPNAKPEIDE]
public class DKBFCLOHDNF<DataType> where DataType : HDINHDBEFHC
{
	[Cpp2IlInjected.Token(Token = "0x17000244")]
	public long IGKGFEDGMJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000575")]
		[Cpp2IlInjected.Address(RVA = "0x9DF710", Offset = "0x9DDF10", VA = "0x1809DF710")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000576")]
		[Cpp2IlInjected.Address(RVA = "0xCDCAB0", Offset = "0xCDB2B0", VA = "0x180CDCAB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000245")]
	public FIEOJKLGOND LDLCENPHCNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000577")]
		[Cpp2IlInjected.Address(RVA = "0x9E9470", Offset = "0x9E7C70", VA = "0x1809E9470")]
		[CompilerGenerated]
		get
		{
			return default(FIEOJKLGOND);
		}
		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0x9EC7A0", Offset = "0x9EAFA0", VA = "0x1809EC7A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000246")]
	public LJOOEGFMDKC JACLJDAPHAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(RVA = "0xA07330", Offset = "0xA05B30", VA = "0x180A07330")]
		[CompilerGenerated]
		get
		{
			return default(LJOOEGFMDKC);
		}
		[Cpp2IlInjected.Token(Token = "0x600057A")]
		[Cpp2IlInjected.Address(RVA = "0xD3DBC0", Offset = "0xD3C3C0", VA = "0x180D3DBC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000247")]
	public DataType BADLMALNNLF
	{
		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(RVA = "0x9DF730", Offset = "0x9DDF30", VA = "0x1809DF730")]
		[CompilerGenerated]
		get
		{
			return (DataType)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600057C")]
		[Cpp2IlInjected.Address(RVA = "0x9DF740", Offset = "0x9DDF40", VA = "0x1809DF740")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600057D")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public DKBFCLOHDNF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
[LMPNAKPEIDE]
public class AAPECEEBHMC<DataType> where DataType : HDINHDBEFHC
{
	[Cpp2IlInjected.Token(Token = "0x17000248")]
	public long IGKGFEDGMJC
	{
		[Cpp2IlInjected.Token(Token = "0x600057E")]
		[Cpp2IlInjected.Address(RVA = "0x9DF710", Offset = "0x9DDF10", VA = "0x1809DF710")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600057F")]
		[Cpp2IlInjected.Address(RVA = "0xCDCAB0", Offset = "0xCDB2B0", VA = "0x180CDCAB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000249")]
	public FIEOJKLGOND LDLCENPHCNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000580")]
		[Cpp2IlInjected.Address(RVA = "0x9E9470", Offset = "0x9E7C70", VA = "0x1809E9470")]
		[CompilerGenerated]
		get
		{
			return default(FIEOJKLGOND);
		}
		[Cpp2IlInjected.Token(Token = "0x6000581")]
		[Cpp2IlInjected.Address(RVA = "0x9EC7A0", Offset = "0x9EAFA0", VA = "0x1809EC7A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700024A")]
	public LJOOEGFMDKC JACLJDAPHAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000582")]
		[Cpp2IlInjected.Address(RVA = "0xA07330", Offset = "0xA05B30", VA = "0x180A07330")]
		[CompilerGenerated]
		get
		{
			return default(LJOOEGFMDKC);
		}
		[Cpp2IlInjected.Token(Token = "0x6000583")]
		[Cpp2IlInjected.Address(RVA = "0xD3DBC0", Offset = "0xD3C3C0", VA = "0x180D3DBC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700024B")]
	public List<DataType> BADLMALNNLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000584")]
		[Cpp2IlInjected.Address(RVA = "0x9DF730", Offset = "0x9DDF30", VA = "0x1809DF730")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000585")]
		[Cpp2IlInjected.Address(RVA = "0x9DF740", Offset = "0x9DDF40", VA = "0x1809DF740")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000586")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public AAPECEEBHMC()
	{
	}
}
namespace RecNet
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000D6")]
	[LMPNAKPEIDE]
	public class BalanceUpdateResponseDTO<DataTypeDTO> : BalanceResponseDTO where DataTypeDTO : HDINHDBEFHC, new()
	{
		[Cpp2IlInjected.Token(Token = "0x20000D7")]
		[LMPNAKPEIDE]
		public class JNMAMDNABBJ : NFLOLGCKCAF, HDINHDBEFHC
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x20000D8")]
			[CompilerGenerated]
			private struct EPBLPAGIICK : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40003F5")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40003F6")]
				public AsyncTaskMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40003F7")]
				public JNMAMDNABBJ <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40003F8")]
				private TaskAwaiter <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000592")]
				[Cpp2IlInjected.Address(RVA = "0x443E000", Offset = "0x443C800", VA = "0x18443E000", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000593")]
				[Cpp2IlInjected.Address(RVA = "0x443E2E0", Offset = "0x443CAE0", VA = "0x18443E2E0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700024D")]
			public EBHFKFFGGPP KNELOOPMPKP
			{
				[Cpp2IlInjected.Token(Token = "0x600058B")]
				[Cpp2IlInjected.Address(RVA = "0x9DD1A0", Offset = "0x9DB9A0", VA = "0x1809DD1A0")]
				[CompilerGenerated]
				get
				{
					return default(EBHFKFFGGPP);
				}
				[Cpp2IlInjected.Token(Token = "0x600058C")]
				[Cpp2IlInjected.Address(RVA = "0x9EBF60", Offset = "0x9EA760", VA = "0x1809EBF60")]
				[CompilerGenerated]
				internal set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700024E")]
			public DataTypeDTO BADLMALNNLF
			{
				[Cpp2IlInjected.Token(Token = "0x600058D")]
				[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760")]
				[CompilerGenerated]
				get
				{
					return (DataTypeDTO)null;
				}
				[Cpp2IlInjected.Token(Token = "0x600058E")]
				[Cpp2IlInjected.Address(RVA = "0x9DF700", Offset = "0x9DDF00", VA = "0x1809DF700")]
				[CompilerGenerated]
				internal set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600058F")]
			[Cpp2IlInjected.Address(RVA = "0x4E2D1E0", Offset = "0x4E2B9E0", VA = "0x184E2D1E0", Slot = "5")]
			public void AOEGOOLELIF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000590")]
			[Cpp2IlInjected.Address(RVA = "0x4E2D2D0", Offset = "0x4E2BAD0", VA = "0x184E2D2D0", Slot = "4")]
			[AsyncStateMachine(typeof(BalanceUpdateResponseDTO<>.JNMAMDNABBJ.EPBLPAGIICK))]
			public Task BKIAAJDPKIB()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000591")]
			[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
			public JNMAMDNABBJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700024C")]
		public List<JNMAMDNABBJ> BalanceUpdates
		{
			[Cpp2IlInjected.Token(Token = "0x6000587")]
			[Cpp2IlInjected.Address(RVA = "0x9DF730", Offset = "0x9DDF30", VA = "0x1809DF730")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000588")]
			[Cpp2IlInjected.Address(RVA = "0x9DF740", Offset = "0x9DDF40", VA = "0x1809DF740")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000589")]
		[Cpp2IlInjected.Address(RVA = "0x55BB6D0", Offset = "0x55B9ED0", VA = "0x1855BB6D0", Slot = "5")]
		public override void AOEGOOLELIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058A")]
		[Cpp2IlInjected.Address(RVA = "0xA08FF0", Offset = "0xA077F0", VA = "0x180A08FF0")]
		public BalanceUpdateResponseDTO()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000D9")]
	[LMPNAKPEIDE]
	public class PurchaseBalanceUpdateResponseDTO<DataTypeDTO> : BalanceResponseDTO where DataTypeDTO : HDINHDBEFHC, new()
	{
		[Cpp2IlInjected.Token(Token = "0x20000DA")]
		[LMPNAKPEIDE]
		public class FLNJLCCBLNK : NFLOLGCKCAF, HDINHDBEFHC
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x20000DB")]
			[CompilerGenerated]
			private struct HOPADMBJKPM : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40003FC")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40003FD")]
				public AsyncTaskMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40003FE")]
				public FLNJLCCBLNK <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40003FF")]
				private TaskAwaiter <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600059F")]
				[Cpp2IlInjected.Address(RVA = "0x4A9B220", Offset = "0x4A99A20", VA = "0x184A9B220", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005A0")]
				[Cpp2IlInjected.Address(RVA = "0x4A9B490", Offset = "0x4A99C90", VA = "0x184A9B490", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000250")]
			public EBHFKFFGGPP KNELOOPMPKP
			{
				[Cpp2IlInjected.Token(Token = "0x6000598")]
				[Cpp2IlInjected.Address(RVA = "0x9DD1A0", Offset = "0x9DB9A0", VA = "0x1809DD1A0")]
				[CompilerGenerated]
				get
				{
					return default(EBHFKFFGGPP);
				}
				[Cpp2IlInjected.Token(Token = "0x6000599")]
				[Cpp2IlInjected.Address(RVA = "0x9EBF60", Offset = "0x9EA760", VA = "0x1809EBF60")]
				[CompilerGenerated]
				internal set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000251")]
			public List<DataTypeDTO> BADLMALNNLF
			{
				[Cpp2IlInjected.Token(Token = "0x600059A")]
				[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600059B")]
				[Cpp2IlInjected.Address(RVA = "0x9DF700", Offset = "0x9DDF00", VA = "0x1809DF700")]
				[CompilerGenerated]
				internal set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600059C")]
			[Cpp2IlInjected.Address(RVA = "0x48D3270", Offset = "0x48D1A70", VA = "0x1848D3270", Slot = "5")]
			public void AOEGOOLELIF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600059D")]
			[Cpp2IlInjected.Address(RVA = "0x48D3510", Offset = "0x48D1D10", VA = "0x1848D3510", Slot = "4")]
			[AsyncStateMachine(typeof(PurchaseBalanceUpdateResponseDTO<>.FLNJLCCBLNK.HOPADMBJKPM))]
			public Task BKIAAJDPKIB()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600059E")]
			[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
			public FLNJLCCBLNK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700024F")]
		public List<FLNJLCCBLNK> BalanceUpdates
		{
			[Cpp2IlInjected.Token(Token = "0x6000594")]
			[Cpp2IlInjected.Address(RVA = "0x9DF730", Offset = "0x9DDF30", VA = "0x1809DF730")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000595")]
			[Cpp2IlInjected.Address(RVA = "0x9DF740", Offset = "0x9DDF40", VA = "0x1809DF740")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000596")]
		[Cpp2IlInjected.Address(RVA = "0x55BB6D0", Offset = "0x55B9ED0", VA = "0x1855BB6D0", Slot = "5")]
		public override void AOEGOOLELIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000597")]
		[Cpp2IlInjected.Address(RVA = "0xA08FF0", Offset = "0xA077F0", VA = "0x180A08FF0")]
		public PurchaseBalanceUpdateResponseDTO()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
[HNFOEAFIOFJ]
public class KMPHHADGEGG : PurchaseBalanceUpdateResponseDTO<DCIOEOOBAMK>
{
	[Cpp2IlInjected.Token(Token = "0x60005A1")]
	[Cpp2IlInjected.Address(RVA = "0x70720E0", Offset = "0x70708E0", VA = "0x1870720E0")]
	public KMPHHADGEGG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
[HNFOEAFIOFJ]
public class KKDHILECJNA : PurchaseBalanceUpdateResponseDTO<DCIOEOOBAMK>.FLNJLCCBLNK
{
	[Cpp2IlInjected.Token(Token = "0x60005A2")]
	[Cpp2IlInjected.Address(RVA = "0x7071E00", Offset = "0x7070600", VA = "0x187071E00")]
	public KKDHILECJNA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
[BDENCKNLAKO]
public class BPPOFEBHEAD : HDINHDBEFHC
{
	[Cpp2IlInjected.Token(Token = "0x17000252")]
	public BHKGNBJOFOC NPHGJPKCJFO
	{
		[Cpp2IlInjected.Token(Token = "0x60005A3")]
		[Cpp2IlInjected.Address(RVA = "0x9DF710", Offset = "0x9DDF10", VA = "0x1809DF710")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005A4")]
		[Cpp2IlInjected.Address(RVA = "0x9DF720", Offset = "0x9DDF20", VA = "0x1809DF720")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000253")]
	public long JCGDKOOBCEK
	{
		[Cpp2IlInjected.Token(Token = "0x60005A5")]
		[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x60005A6")]
		[Cpp2IlInjected.Address(RVA = "0xC57CB0", Offset = "0xC564B0", VA = "0x180C57CB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000254")]
	public GiftItemDTO? AJLNBNBOHMF
	{
		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(RVA = "0x9DF730", Offset = "0x9DDF30", VA = "0x1809DF730")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005A8")]
		[Cpp2IlInjected.Address(RVA = "0x9DF740", Offset = "0x9DDF40", VA = "0x1809DF740")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000255")]
	public long? LPHIJIGIEFB
	{
		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(RVA = "0x1256F40", Offset = "0x1255740", VA = "0x181256F40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0x12575D0", Offset = "0x1255DD0", VA = "0x1812575D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000256")]
	public int NBHBKLOCLBL
	{
		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(RVA = "0x9FCF80", Offset = "0x9FB780", VA = "0x1809FCF80")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60005AC")]
		[Cpp2IlInjected.Address(RVA = "0xD38EB0", Offset = "0xD376B0", VA = "0x180D38EB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005AD")]
	[Cpp2IlInjected.Address(RVA = "0x706C4B0", Offset = "0x706ACB0", VA = "0x18706C4B0")]
	public BPPOFEBHEAD(BHKGNBJOFOC JOJMKBJPEIH, long NNJMLCCPAMG, GiftItemDTO? DNFCMOGKFGA, int GFCKEFAGOCA = 1, [Optional] long? EAONCAHKMKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AE")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "4")]
	public void AOEGOOLELIF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
[BDENCKNLAKO]
public class JOBNKAIODFF : HDINHDBEFHC
{
	[Cpp2IlInjected.Token(Token = "0x17000257")]
	public List<BPPOFEBHEAD> IHKELNELDDM
	{
		[Cpp2IlInjected.Token(Token = "0x60005AF")]
		[Cpp2IlInjected.Address(RVA = "0x9DF710", Offset = "0x9DDF10", VA = "0x1809DF710")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005B0")]
		[Cpp2IlInjected.Address(RVA = "0x9DF720", Offset = "0x9DDF20", VA = "0x1809DF720")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000258")]
	public JDGPNLOGLBE? DJGAKOJLALJ
	{
		[Cpp2IlInjected.Token(Token = "0x60005B1")]
		[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005B2")]
		[Cpp2IlInjected.Address(RVA = "0xC57CB0", Offset = "0xC564B0", VA = "0x180C57CB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000259")]
	public FIEOJKLGOND LDLCENPHCNF
	{
		[Cpp2IlInjected.Token(Token = "0x60005B3")]
		[Cpp2IlInjected.Address(RVA = "0xBD6AB0", Offset = "0xBD52B0", VA = "0x180BD6AB0")]
		[CompilerGenerated]
		get
		{
			return default(FIEOJKLGOND);
		}
		[Cpp2IlInjected.Token(Token = "0x60005B4")]
		[Cpp2IlInjected.Address(RVA = "0xC46540", Offset = "0xC44D40", VA = "0x180C46540")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700025A")]
	public bool ACJJBIIBIDD
	{
		[Cpp2IlInjected.Token(Token = "0x60005B5")]
		[Cpp2IlInjected.Address(RVA = "0xCE8C70", Offset = "0xCE7470", VA = "0x180CE8C70")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60005B6")]
		[Cpp2IlInjected.Address(RVA = "0xCE8D90", Offset = "0xCE7590", VA = "0x180CE8D90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700025B")]
	public bool JDHGIHAPLOE
	{
		[Cpp2IlInjected.Token(Token = "0x60005B7")]
		[Cpp2IlInjected.Address(RVA = "0x1322A10", Offset = "0x1321210", VA = "0x181322A10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60005B8")]
		[Cpp2IlInjected.Address(RVA = "0x25FE5C0", Offset = "0x25FCDC0", VA = "0x1825FE5C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005B9")]
	[Cpp2IlInjected.Address(RVA = "0x7071AB0", Offset = "0x70702B0", VA = "0x187071AB0")]
	public JOBNKAIODFF(List<BPPOFEBHEAD> BOOCPNNFOGP, JDGPNLOGLBE? KOMCFMMPJNL, FIEOJKLGOND NEJHFIOGEEJ, bool BKMIPIBIFCK, bool BCKEHNBHAKK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BA")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "4")]
	public void AOEGOOLELIF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
[BDENCKNLAKO]
public class DEHHLKOFBNB : NFLOLGCKCAF, HDINHDBEFHC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000E1")]
	[CompilerGenerated]
	private struct NKHDEGDJPCM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400040E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400040F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000410")]
		public DEHHLKOFBNB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000411")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005C2")]
		[Cpp2IlInjected.Address(RVA = "0x7073420", Offset = "0x7071C20", VA = "0x187073420", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C3")]
		[Cpp2IlInjected.Address(RVA = "0x7073700", Offset = "0x7071F00", VA = "0x187073700", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400040A")]
	internal static Action<DCIOEOOBAMK>? DNODNPJFDIA;

	[Cpp2IlInjected.Token(Token = "0x400040B")]
	internal static Func<DCIOEOOBAMK, Task>? EEPHNJAGEAC;

	[Cpp2IlInjected.Token(Token = "0x1700025C")]
	public DCIOEOOBAMK KBHAGFCHMBH
	{
		[Cpp2IlInjected.Token(Token = "0x60005BB")]
		[Cpp2IlInjected.Address(RVA = "0x9DF710", Offset = "0x9DDF10", VA = "0x1809DF710")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005BC")]
		[Cpp2IlInjected.Address(RVA = "0x9DF720", Offset = "0x9DDF20", VA = "0x1809DF720")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700025D")]
	public ACFMHBIMNNI? IKEJJDACNHE
	{
		[Cpp2IlInjected.Token(Token = "0x60005BD")]
		[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005BE")]
		[Cpp2IlInjected.Address(RVA = "0x9DF700", Offset = "0x9DDF00", VA = "0x1809DF700")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005BF")]
	[Cpp2IlInjected.Address(RVA = "0x706D2E0", Offset = "0x706BAE0", VA = "0x18706D2E0", Slot = "5")]
	public void AOEGOOLELIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C0")]
	[Cpp2IlInjected.Address(RVA = "0x706D3A0", Offset = "0x706BBA0", VA = "0x18706D3A0", Slot = "6")]
	[AsyncStateMachine(typeof(NKHDEGDJPCM))]
	public virtual Task BKIAAJDPKIB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C1")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public DEHHLKOFBNB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
[HNFOEAFIOFJ]
public class NEOOMBMPDLF : BalanceUpdateResponseDTO<DEHHLKOFBNB>
{
	[Cpp2IlInjected.Token(Token = "0x60005C4")]
	[Cpp2IlInjected.Address(RVA = "0x7073370", Offset = "0x7071B70", VA = "0x187073370")]
	public NEOOMBMPDLF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
[HNFOEAFIOFJ]
public class GGAPHBENPFO : BalanceUpdateResponseDTO<DEHHLKOFBNB>.JNMAMDNABBJ
{
	[Cpp2IlInjected.Token(Token = "0x60005C5")]
	[Cpp2IlInjected.Address(RVA = "0x706F1E0", Offset = "0x706D9E0", VA = "0x18706F1E0")]
	public GGAPHBENPFO()
	{
	}
}
namespace RecNet
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000E4")]
	[BDENCKNLAKO]
	public class GiftItemDTO
	{
		[Cpp2IlInjected.Token(Token = "0x1700025E")]
		public int ToPlayerId
		{
			[Cpp2IlInjected.Token(Token = "0x60005C6")]
			[Cpp2IlInjected.Address(RVA = "0x9DD1A0", Offset = "0x9DB9A0", VA = "0x1809DD1A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60005C7")]
			[Cpp2IlInjected.Address(RVA = "0x9EBF60", Offset = "0x9EA760", VA = "0x1809EBF60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700025F")]
		public string? Message
		{
			[Cpp2IlInjected.Token(Token = "0x60005C8")]
			[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005C9")]
			[Cpp2IlInjected.Address(RVA = "0x9DF700", Offset = "0x9DDF00", VA = "0x1809DF700")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000260")]
		public bool Anonymous
		{
			[Cpp2IlInjected.Token(Token = "0x60005CA")]
			[Cpp2IlInjected.Address(RVA = "0x9E0E00", Offset = "0x9DF600", VA = "0x1809E0E00")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60005CB")]
			[Cpp2IlInjected.Address(RVA = "0x9E0E10", Offset = "0x9DF610", VA = "0x1809E0E10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000261")]
		public AKGOFIOCCAL GiftContext
		{
			[Cpp2IlInjected.Token(Token = "0x60005CC")]
			[Cpp2IlInjected.Address(RVA = "0xCE6F70", Offset = "0xCE5770", VA = "0x180CE6F70")]
			[CompilerGenerated]
			get
			{
				return default(AKGOFIOCCAL);
			}
			[Cpp2IlInjected.Token(Token = "0x60005CD")]
			[Cpp2IlInjected.Address(RVA = "0xEF7300", Offset = "0xEF5B00", VA = "0x180EF7300")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005CE")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public GiftItemDTO()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
[BDENCKNLAKO]
public class AMOFOKFIPOB : HDINHDBEFHC, FMGFJMMDKNG
{
	[Cpp2IlInjected.Token(Token = "0x17000262")]
	public GGHEBLNIHGG? IBLKPDCCDKA
	{
		[Cpp2IlInjected.Token(Token = "0x60005CF")]
		[Cpp2IlInjected.Address(RVA = "0x9DF710", Offset = "0x9DDF10", VA = "0x1809DF710")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005D0")]
		[Cpp2IlInjected.Address(RVA = "0x9DF720", Offset = "0x9DDF20", VA = "0x1809DF720")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000263")]
	[IgnoreDataMember]
	public Guid ACPBCEPFHAA
	{
		[Cpp2IlInjected.Token(Token = "0x60005D1")]
		[Cpp2IlInjected.Address(RVA = "0x706B2B0", Offset = "0x7069AB0", VA = "0x18706B2B0", Slot = "5")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000264")]
	public BHKGNBJOFOC? OGHNJNDAJMF
	{
		[Cpp2IlInjected.Token(Token = "0x60005D3")]
		[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005D4")]
		[Cpp2IlInjected.Address(RVA = "0x9DF700", Offset = "0x9DDF00", VA = "0x1809DF700")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000265")]
	public List<OMCPAFCHDFL>? EOPCNOHMFNM
	{
		[Cpp2IlInjected.Token(Token = "0x60005D5")]
		[Cpp2IlInjected.Address(RVA = "0x9DF730", Offset = "0x9DDF30", VA = "0x1809DF730", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005D6")]
		[Cpp2IlInjected.Address(RVA = "0x9DF740", Offset = "0x9DDF40", VA = "0x1809DF740")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000266")]
	public DateTime? MEMLHBNNOLL
	{
		[Cpp2IlInjected.Token(Token = "0x60005D7")]
		[Cpp2IlInjected.Address(RVA = "0x1256F40", Offset = "0x1255740", VA = "0x181256F40", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(RVA = "0x12575D0", Offset = "0x1255DD0", VA = "0x1812575D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000267")]
	public DateTime? HADGKICJOIA
	{
		[Cpp2IlInjected.Token(Token = "0x60005D9")]
		[Cpp2IlInjected.Address(RVA = "0x1337EC0", Offset = "0x13366C0", VA = "0x181337EC0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(RVA = "0x1337FD0", Offset = "0x13367D0", VA = "0x181337FD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000268")]
	public DateTime? PHLBNCGKGOO
	{
		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0xCF7380", Offset = "0xCF5B80", VA = "0x180CF7380", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x5792870", Offset = "0x5791070", VA = "0x185792870")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000269")]
	public bool DBBMNPHCIHI
	{
		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0xBE2D10", Offset = "0xBE1510", VA = "0x180BE2D10", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0xBE24A0", Offset = "0xBE0CA0", VA = "0x180BE24A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700026A")]
	public bool DLBFNNHLEOI
	{
		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(RVA = "0x110B5E0", Offset = "0x1109DE0", VA = "0x18110B5E0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60005E0")]
		[Cpp2IlInjected.Address(RVA = "0x1271A00", Offset = "0x1270200", VA = "0x181271A00")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700026B")]
	public bool FFOBJAGEOJH
	{
		[Cpp2IlInjected.Token(Token = "0x60005E1")]
		[Cpp2IlInjected.Address(RVA = "0xE8B3A0", Offset = "0xE89BA0", VA = "0x180E8B3A0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60005E2")]
		[Cpp2IlInjected.Address(RVA = "0x1564B00", Offset = "0x1563300", VA = "0x181564B00")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700026C")]
	public bool MENKMGHAAIM
	{
		[Cpp2IlInjected.Token(Token = "0x60005E3")]
		[Cpp2IlInjected.Address(RVA = "0xE86D80", Offset = "0xE85580", VA = "0x180E86D80", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60005E4")]
		[Cpp2IlInjected.Address(RVA = "0xE8B430", Offset = "0xE89C30", VA = "0x180E8B430")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005D2")]
	[Cpp2IlInjected.Address(RVA = "0x706B330", Offset = "0x7069B30", VA = "0x18706B330")]
	public static AMOFOKFIPOB INKAKAANGGJ(Guid KAAGPNJIINH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E5")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "4")]
	public void AOEGOOLELIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005E6")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public AMOFOKFIPOB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
[BDENCKNLAKO]
public class JBFDAFCIMNK
{
	[Cpp2IlInjected.Token(Token = "0x1700026D")]
	public int ILGJIFNMLEF
	{
		[Cpp2IlInjected.Token(Token = "0x60005E7")]
		[Cpp2IlInjected.Address(RVA = "0x9DD1A0", Offset = "0x9DB9A0", VA = "0x1809DD1A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60005E8")]
		[Cpp2IlInjected.Address(RVA = "0x9EBF60", Offset = "0x9EA760", VA = "0x1809EBF60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700026E")]
	public string EHFLOPKGJJH
	{
		[Cpp2IlInjected.Token(Token = "0x60005E9")]
		[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005EA")]
		[Cpp2IlInjected.Address(RVA = "0x9DF700", Offset = "0x9DDF00", VA = "0x1809DF700")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700026F")]
	public string HJNFBKJJKCM
	{
		[Cpp2IlInjected.Token(Token = "0x60005EB")]
		[Cpp2IlInjected.Address(RVA = "0x9DF730", Offset = "0x9DDF30", VA = "0x1809DF730")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005EC")]
		[Cpp2IlInjected.Address(RVA = "0x9DF740", Offset = "0x9DDF40", VA = "0x1809DF740")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000270")]
	public Dictionary<int, MOBOGNFCHAI> NNDCDLEJIKA
	{
		[Cpp2IlInjected.Token(Token = "0x60005ED")]
		[Cpp2IlInjected.Address(RVA = "0x9DF790", Offset = "0x9DDF90", VA = "0x1809DF790")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005EE")]
		[Cpp2IlInjected.Address(RVA = "0x9DF780", Offset = "0x9DDF80", VA = "0x1809DF780")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000271")]
	public Dictionary<string, int> IJPGIKBKPMO
	{
		[Cpp2IlInjected.Token(Token = "0x60005EF")]
		[Cpp2IlInjected.Address(RVA = "0x9DF770", Offset = "0x9DDF70", VA = "0x1809DF770")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005F0")]
		[Cpp2IlInjected.Address(RVA = "0x9DF750", Offset = "0x9DDF50", VA = "0x1809DF750")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000272")]
	public Dictionary<CCIHBDKOHFM, List<int>> HEDDENLHELO
	{
		[Cpp2IlInjected.Token(Token = "0x60005F1")]
		[Cpp2IlInjected.Address(RVA = "0x9E0DB0", Offset = "0x9DF5B0", VA = "0x1809E0DB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005F2")]
		[Cpp2IlInjected.Address(RVA = "0x9E0DC0", Offset = "0x9DF5C0", VA = "0x1809E0DC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000273")]
	public Dictionary<string, string> KDCOJEGLBBM
	{
		[Cpp2IlInjected.Token(Token = "0x60005F3")]
		[Cpp2IlInjected.Address(RVA = "0x9E2460", Offset = "0x9E0C60", VA = "0x1809E2460")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005F4")]
		[Cpp2IlInjected.Address(RVA = "0x9E0DA0", Offset = "0x9DF5A0", VA = "0x1809E0DA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005F5")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public JBFDAFCIMNK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
public enum CCIHBDKOHFM
{
	[Cpp2IlInjected.Token(Token = "0x4000428")]
	DetailsScreen,
	[Cpp2IlInjected.Token(Token = "0x4000429")]
	SignUpScreen,
	[Cpp2IlInjected.Token(Token = "0x400042A")]
	ManageMembershipScreen,
	[Cpp2IlInjected.Token(Token = "0x400042B")]
	ItemDetailsScreen,
	[Cpp2IlInjected.Token(Token = "0x400042C")]
	ActivityRewardsScreen,
	[Cpp2IlInjected.Token(Token = "0x400042D")]
	RoomPublishUpsell
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
[BDENCKNLAKO]
public class MOBOGNFCHAI : BACKBNADPDJ
{
	[Cpp2IlInjected.Token(Token = "0x17000274")]
	public OEKNDJBDCIH DOGGNFIGMNP
	{
		[Cpp2IlInjected.Token(Token = "0x60005F6")]
		[Cpp2IlInjected.Address(RVA = "0x9DD1A0", Offset = "0x9DB9A0", VA = "0x1809DD1A0")]
		[CompilerGenerated]
		get
		{
			return default(OEKNDJBDCIH);
		}
		[Cpp2IlInjected.Token(Token = "0x60005F7")]
		[Cpp2IlInjected.Address(RVA = "0x9EBF60", Offset = "0x9EA760", VA = "0x1809EBF60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000275")]
	public bool NBEAKMPPCPK
	{
		[Cpp2IlInjected.Token(Token = "0x60005F8")]
		[Cpp2IlInjected.Address(RVA = "0x110C0D0", Offset = "0x110A8D0", VA = "0x18110C0D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60005F9")]
		[Cpp2IlInjected.Address(RVA = "0x1326130", Offset = "0x1324930", VA = "0x181326130")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000276")]
	public bool OGLKHHDJPCA
	{
		[Cpp2IlInjected.Token(Token = "0x60005FA")]
		[Cpp2IlInjected.Address(RVA = "0x1D21BD0", Offset = "0x1D203D0", VA = "0x181D21BD0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60005FB")]
		[Cpp2IlInjected.Address(RVA = "0x1D21BC0", Offset = "0x1D203C0", VA = "0x181D21BC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000277")]
	public string NAEAJLFLBDA
	{
		[Cpp2IlInjected.Token(Token = "0x60005FC")]
		[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005FD")]
		[Cpp2IlInjected.Address(RVA = "0x9DF700", Offset = "0x9DDF00", VA = "0x1809DF700")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000278")]
	public string MEIBOEFOPDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60005FE")]
		[Cpp2IlInjected.Address(RVA = "0x9DF730", Offset = "0x9DDF30", VA = "0x1809DF730", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005FF")]
		[Cpp2IlInjected.Address(RVA = "0x9DF740", Offset = "0x9DDF40", VA = "0x1809DF740")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000279")]
	public string ONOKOACJLHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000600")]
		[Cpp2IlInjected.Address(RVA = "0x9DF790", Offset = "0x9DDF90", VA = "0x1809DF790", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000601")]
		[Cpp2IlInjected.Address(RVA = "0x9DF780", Offset = "0x9DDF80", VA = "0x1809DF780")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700027A")]
	public string JMKHJEDGOJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000602")]
		[Cpp2IlInjected.Address(RVA = "0x9DF770", Offset = "0x9DDF70", VA = "0x1809DF770", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000603")]
		[Cpp2IlInjected.Address(RVA = "0x9DF750", Offset = "0x9DDF50", VA = "0x1809DF750")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700027B")]
	public Dictionary<IAHCCPKAHLI, string> OBDDBMBPGBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000604")]
		[Cpp2IlInjected.Address(RVA = "0x9E0DB0", Offset = "0x9DF5B0", VA = "0x1809E0DB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000605")]
		[Cpp2IlInjected.Address(RVA = "0x9E0DC0", Offset = "0x9DF5C0", VA = "0x1809E0DC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000606")]
	[Cpp2IlInjected.Address(RVA = "0x1326180", Offset = "0x1324980", VA = "0x181326180")]
	public MOBOGNFCHAI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
[BDENCKNLAKO]
public class IKBELMNGJCE : HDINHDBEFHC
{
	[Cpp2IlInjected.Token(Token = "0x1700027C")]
	public IReadOnlyList<GGHEBLNIHGG>? KMMLBAFNILJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000607")]
		[Cpp2IlInjected.Address(RVA = "0x9DF710", Offset = "0x9DDF10", VA = "0x1809DF710")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000608")]
		[Cpp2IlInjected.Address(RVA = "0x9DF720", Offset = "0x9DDF20", VA = "0x1809DF720")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000609")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public IKBELMNGJCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600060A")]
	[Cpp2IlInjected.Address(RVA = "0x9EBB90", Offset = "0x9EA390", VA = "0x1809EBB90")]
	public IKBELMNGJCE(IReadOnlyList<GGHEBLNIHGG>? GFLKAHBLNKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600060B")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "4")]
	public void AOEGOOLELIF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
public enum NLJFLIJKFBN
{
	[Cpp2IlInjected.Token(Token = "0x4000438")]
	Unspecified = -1,
	[Cpp2IlInjected.Token(Token = "0x4000439")]
	XP,
	[Cpp2IlInjected.Token(Token = "0x400043A")]
	OutfitItem,
	[Cpp2IlInjected.Token(Token = "0x400043B")]
	Equipment,
	[Cpp2IlInjected.Token(Token = "0x400043C")]
	Currency,
	[Cpp2IlInjected.Token(Token = "0x400043D")]
	Consumable,
	[Cpp2IlInjected.Token(Token = "0x400043E")]
	Query,
	[Cpp2IlInjected.Token(Token = "0x400043F")]
	HairDye
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
public interface FMGFJMMDKNG
{
	[Cpp2IlInjected.Token(Token = "0x1700027D")]
	Guid ACPBCEPFHAA
	{
		[Cpp2IlInjected.Token(Token = "0x600060C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700027E")]
	BHKGNBJOFOC? OGHNJNDAJMF
	{
		[Cpp2IlInjected.Token(Token = "0x600060D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700027F")]
	List<OMCPAFCHDFL>? EOPCNOHMFNM
	{
		[Cpp2IlInjected.Token(Token = "0x600060E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000280")]
	DateTime? MEMLHBNNOLL
	{
		[Cpp2IlInjected.Token(Token = "0x600060F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000281")]
	DateTime? HADGKICJOIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000610")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000282")]
	DateTime? PHLBNCGKGOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000611")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000283")]
	bool DBBMNPHCIHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000612")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000284")]
	bool FFOBJAGEOJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000613")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000285")]
	bool MENKMGHAAIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000614")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
public interface AMBNHKGDCJJ
{
	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event Action GKEFNBHJDLF;

	[Cpp2IlInjected.Token(Token = "0x6000617")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task BAKCHGEBNFN(CancellationToken DNHBNMHIDAC);

	[Cpp2IlInjected.Token(Token = "0x6000618")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task JOIPFBILBFC(CancellationToken DNHBNMHIDAC);

	[Cpp2IlInjected.Token(Token = "0x6000619")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool EJIONDNOOBG([Out] PINIMFEJINI PKENAIPAKDA);
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
public interface PINIMFEJINI
{
	[Cpp2IlInjected.Token(Token = "0x17000286")]
	string EHFLOPKGJJH
	{
		[Cpp2IlInjected.Token(Token = "0x600061A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000287")]
	string HJNFBKJJKCM
	{
		[Cpp2IlInjected.Token(Token = "0x600061B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000288")]
	IReadOnlyDictionary<CCIHBDKOHFM, IReadOnlyList<BACKBNADPDJ>> NHINNHKOBBL
	{
		[Cpp2IlInjected.Token(Token = "0x600061C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000289")]
	IReadOnlyDictionary<string, string> KDCOJEGLBBM
	{
		[Cpp2IlInjected.Token(Token = "0x600061D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public interface BACKBNADPDJ
{
	[Cpp2IlInjected.Token(Token = "0x1700028A")]
	string MEIBOEFOPDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600061E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700028B")]
	string NAEAJLFLBDA
	{
		[Cpp2IlInjected.Token(Token = "0x600061F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700028C")]
	string ONOKOACJLHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000620")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700028D")]
	string JMKHJEDGOJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000621")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
public interface CPKMEDMFFBO
{
	[Cpp2IlInjected.Token(Token = "0x1700028E")]
	BPEBJLOIJPB IFCMPJACFHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000622")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700028F")]
	string NGHJMEDCGPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000623")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000290")]
	string DGFFOJPABFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000624")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000291")]
	string FEGKEMEANPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000625")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000292")]
	bool MENKMGHAAIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000626")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000293")]
	bool FFOBJAGEOJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000627")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000294")]
	KKHKGMOAKDA EFOAOHHGDKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000628")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000295")]
	string FGDKEKLFOCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000629")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000296")]
	NIJJFMMKHEB? HBIBOMOHFGP
	{
		[Cpp2IlInjected.Token(Token = "0x600062A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000297")]
	NLJFLIJKFBN GCOEHDOHPKH
	{
		[Cpp2IlInjected.Token(Token = "0x600062B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000298")]
	bool LNDFPKHHBDN
	{
		[Cpp2IlInjected.Token(Token = "0x600062C")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
[BDENCKNLAKO]
public class BHKGNBJOFOC : HDINHDBEFHC
{
	[Cpp2IlInjected.Token(Token = "0x17000299")]
	public BPEBJLOIJPB PALJBODIBGP
	{
		[Cpp2IlInjected.Token(Token = "0x600062D")]
		[Cpp2IlInjected.Address(RVA = "0x9DD1A0", Offset = "0x9DB9A0", VA = "0x1809DD1A0")]
		[CompilerGenerated]
		get
		{
			return default(BPEBJLOIJPB);
		}
		[Cpp2IlInjected.Token(Token = "0x600062E")]
		[Cpp2IlInjected.Address(RVA = "0x9EBF60", Offset = "0x9EA760", VA = "0x1809EBF60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700029A")]
	public int? MLAIEDDEFJI
	{
		[Cpp2IlInjected.Token(Token = "0x600062F")]
		[Cpp2IlInjected.Address(RVA = "0xEABF80", Offset = "0xEAA780", VA = "0x180EABF80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000630")]
		[Cpp2IlInjected.Address(RVA = "0xEB4E30", Offset = "0xEB3630", VA = "0x180EB4E30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700029B")]
	public Guid? HNPGENHBKNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000631")]
		[Cpp2IlInjected.Address(RVA = "0x9E9420", Offset = "0x9E7C20", VA = "0x1809E9420")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000632")]
		[Cpp2IlInjected.Address(RVA = "0x9E93A0", Offset = "0x9E7BA0", VA = "0x1809E93A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000633")]
	[Cpp2IlInjected.Address(RVA = "0x706B520", Offset = "0x7069D20", VA = "0x18706B520")]
	public static BHKGNBJOFOC PFEHKLAIEDI(int IECNOABADIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000634")]
	[Cpp2IlInjected.Address(RVA = "0x706B460", Offset = "0x7069C60", VA = "0x18706B460")]
	public static BHKGNBJOFOC FFHJJAJKAIG(Guid KAAGPNJIINH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000635")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "4")]
	public void AOEGOOLELIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000636")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public BHKGNBJOFOC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
public enum BPEBJLOIJPB
{
	[Cpp2IlInjected.Token(Token = "0x4000444")]
	PurchasableItem,
	[Cpp2IlInjected.Token(Token = "0x4000445")]
	CustomAvatarItem
}
[Cpp2IlInjected.Token(Token = "0x20000F2")]
[BDENCKNLAKO]
public class OMCPAFCHDFL : HDINHDBEFHC
{
	[Cpp2IlInjected.Token(Token = "0x1700029C")]
	public FIEOJKLGOND LDLCENPHCNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000637")]
		[Cpp2IlInjected.Address(RVA = "0x9DD1A0", Offset = "0x9DB9A0", VA = "0x1809DD1A0")]
		[CompilerGenerated]
		get
		{
			return default(FIEOJKLGOND);
		}
		[Cpp2IlInjected.Token(Token = "0x6000638")]
		[Cpp2IlInjected.Address(RVA = "0x9EBF60", Offset = "0x9EA760", VA = "0x1809EBF60")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700029D")]
	public int CFBMCPJNOHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000639")]
		[Cpp2IlInjected.Address(RVA = "0xB5FCA0", Offset = "0xB5E4A0", VA = "0x180B5FCA0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600063A")]
		[Cpp2IlInjected.Address(RVA = "0xC57CC0", Offset = "0xC564C0", VA = "0x180C57CC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700029E")]
	public PHAFFFDOPEA LOCLBLCHBCL
	{
		[Cpp2IlInjected.Token(Token = "0x600063B")]
		[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600063C")]
		[Cpp2IlInjected.Address(RVA = "0x9DF700", Offset = "0x9DDF00", VA = "0x1809DF700")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600063D")]
	[Cpp2IlInjected.Address(RVA = "0xE84E50", Offset = "0xE83650", VA = "0x180E84E50", Slot = "4")]
	public void AOEGOOLELIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600063E")]
	[Cpp2IlInjected.Address(RVA = "0x70739C0", Offset = "0x70721C0", VA = "0x1870739C0")]
	public int BDGFLDOMHFN(DateTime EKJNPCGEOHI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600063F")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public OMCPAFCHDFL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
[BDENCKNLAKO]
public class PHAFFFDOPEA : HDINHDBEFHC
{
	[Cpp2IlInjected.Token(Token = "0x1700029F")]
	public int MPIEJGKCLGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000640")]
		[Cpp2IlInjected.Address(RVA = "0x9DD1A0", Offset = "0x9DB9A0", VA = "0x1809DD1A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000641")]
		[Cpp2IlInjected.Address(RVA = "0x9EBF60", Offset = "0x9EA760", VA = "0x1809EBF60")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002A0")]
	public DateTime? GBHCPGNPIDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000642")]
		[Cpp2IlInjected.Address(RVA = "0xBEBD90", Offset = "0xBEA590", VA = "0x180BEBD90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000643")]
		[Cpp2IlInjected.Address(RVA = "0xDA40F0", Offset = "0xDA28F0", VA = "0x180DA40F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002A1")]
	public DateTime? CAIPAOIEJAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000644")]
		[Cpp2IlInjected.Address(RVA = "0x1256F40", Offset = "0x1255740", VA = "0x181256F40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000645")]
		[Cpp2IlInjected.Address(RVA = "0x12575D0", Offset = "0x1255DD0", VA = "0x1812575D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000646")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "4")]
	public void AOEGOOLELIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000647")]
	[Cpp2IlInjected.Address(RVA = "0x7074360", Offset = "0x7072B60", VA = "0x187074360")]
	public bool AOHNIELOFNE(DateTime EKJNPCGEOHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000648")]
	[Cpp2IlInjected.Address(RVA = "0x7074540", Offset = "0x7072D40", VA = "0x187074540")]
	public int OOHABPEDAGE(DateTime EKJNPCGEOHI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000649")]
	[Cpp2IlInjected.Address(RVA = "0x7074450", Offset = "0x7072C50", VA = "0x187074450")]
	public TimeSpan? GMBMDEADJOD(DateTime EKJNPCGEOHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600064A")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public PHAFFFDOPEA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F4")]
public enum JDGPNLOGLBE
{
	[Cpp2IlInjected.Token(Token = "0x400044D")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400044E")]
	LaserTag = 1,
	[Cpp2IlInjected.Token(Token = "0x400044F")]
	RecCenter = 2,
	[Cpp2IlInjected.Token(Token = "0x4000450")]
	Watch = 3,
	[Cpp2IlInjected.Token(Token = "0x4000451")]
	Quest_LostSkulls = 100,
	[Cpp2IlInjected.Token(Token = "0x4000452")]
	Quest_Dracula = 101,
	[Cpp2IlInjected.Token(Token = "0x4000453")]
	Quest_GoldenTrophy = 102,
	[Cpp2IlInjected.Token(Token = "0x4000454")]
	Quest_CrimsonCauldron = 103,
	[Cpp2IlInjected.Token(Token = "0x4000455")]
	RecRoyale = 200,
	[Cpp2IlInjected.Token(Token = "0x4000456")]
	Cafe = 300,
	[Cpp2IlInjected.Token(Token = "0x4000457")]
	Paintball = 400,
	[Cpp2IlInjected.Token(Token = "0x4000458")]
	Paintball_River = 401,
	[Cpp2IlInjected.Token(Token = "0x4000459")]
	Paintball_Homestead = 402,
	[Cpp2IlInjected.Token(Token = "0x400045A")]
	Paintball_Quarry = 403,
	[Cpp2IlInjected.Token(Token = "0x400045B")]
	Paintball_ClearCut = 404,
	[Cpp2IlInjected.Token(Token = "0x400045C")]
	Paintball_Spillway = 405,
	[Cpp2IlInjected.Token(Token = "0x400045D")]
	Paintball_SunsetDriveIn = 406,
	[Cpp2IlInjected.Token(Token = "0x400045E")]
	Bowling = 500,
	[Cpp2IlInjected.Token(Token = "0x400045F")]
	StuntRunner = 600,
	[Cpp2IlInjected.Token(Token = "0x4000460")]
	DormMirror = 700,
	[Cpp2IlInjected.Token(Token = "0x4000461")]
	InventionStore = 800,
	[Cpp2IlInjected.Token(Token = "0x4000462")]
	RoomKeys = 900,
	[Cpp2IlInjected.Token(Token = "0x4000463")]
	Player_Profile = 1000,
	[Cpp2IlInjected.Token(Token = "0x4000464")]
	Room_Save = 1100,
	[Cpp2IlInjected.Token(Token = "0x4000465")]
	RoomCurrencies = 1200,
	[Cpp2IlInjected.Token(Token = "0x4000466")]
	Wishlist = 1300,
	[Cpp2IlInjected.Token(Token = "0x4000467")]
	Friendotron = 1400,
	[Cpp2IlInjected.Token(Token = "0x4000468")]
	RoomConsumables = 1500,
	[Cpp2IlInjected.Token(Token = "0x4000469")]
	RecRally = 1600,
	[Cpp2IlInjected.Token(Token = "0x400046A")]
	PopUpShop_1 = 1700,
	[Cpp2IlInjected.Token(Token = "0x400046B")]
	PopUpShop_2 = 1701,
	[Cpp2IlInjected.Token(Token = "0x400046C")]
	PopUpShop_3 = 1702,
	[Cpp2IlInjected.Token(Token = "0x400046D")]
	PopUpShop_4 = 1703,
	[Cpp2IlInjected.Token(Token = "0x400046E")]
	PopUpShop_5 = 1704,
	[Cpp2IlInjected.Token(Token = "0x400046F")]
	PopUpShop_6 = 1705,
	[Cpp2IlInjected.Token(Token = "0x4000470")]
	PopUpShop_7 = 1706,
	[Cpp2IlInjected.Token(Token = "0x4000471")]
	PopUpShop_8 = 1707,
	[Cpp2IlInjected.Token(Token = "0x4000472")]
	PopUpShop_9 = 1708,
	[Cpp2IlInjected.Token(Token = "0x4000473")]
	PopUpShop_10 = 1709,
	[Cpp2IlInjected.Token(Token = "0x4000474")]
	PopUpShop_11 = 1710,
	[Cpp2IlInjected.Token(Token = "0x4000475")]
	PopUpShop_12 = 1711,
	[Cpp2IlInjected.Token(Token = "0x4000476")]
	PopUpShop_13 = 1712,
	[Cpp2IlInjected.Token(Token = "0x4000477")]
	PopUpShop_14 = 1713,
	[Cpp2IlInjected.Token(Token = "0x4000478")]
	PopUpShop_15 = 1714,
	[Cpp2IlInjected.Token(Token = "0x4000479")]
	PopUpShop_16 = 1715,
	[Cpp2IlInjected.Token(Token = "0x400047A")]
	PopUpShop_17 = 1716,
	[Cpp2IlInjected.Token(Token = "0x400047B")]
	PopUpShop_18 = 1717,
	[Cpp2IlInjected.Token(Token = "0x400047C")]
	PopUpShop_19 = 1718,
	[Cpp2IlInjected.Token(Token = "0x400047D")]
	PopUpShop_20 = 1719,
	[Cpp2IlInjected.Token(Token = "0x400047E")]
	CustomAvatarItems = 1800,
	[Cpp2IlInjected.Token(Token = "0x400047F")]
	ProgressionEventPurchasableXpBoosts = 1900,
	[Cpp2IlInjected.Token(Token = "0x4000480")]
	PopUpShop_ProgressionEvent_1 = 2000,
	[Cpp2IlInjected.Token(Token = "0x4000481")]
	PopUpShop_ProgressionEvent_2 = 2001,
	[Cpp2IlInjected.Token(Token = "0x4000482")]
	PopUpShop_ProgressionEvent_3 = 2002,
	[Cpp2IlInjected.Token(Token = "0x4000483")]
	PopUpShop_ProgressionEvent_4 = 2003,
	[Cpp2IlInjected.Token(Token = "0x4000484")]
	PopUpShop_ProgressionEvent_5 = 2004,
	[Cpp2IlInjected.Token(Token = "0x4000485")]
	RoomOffers = 2100,
	[Cpp2IlInjected.Token(Token = "0x4000486")]
	MyLittleMonsters = 2200,
	[Cpp2IlInjected.Token(Token = "0x4000487")]
	Destiny = 2201,
	[Cpp2IlInjected.Token(Token = "0x4000488")]
	RunTheBlock = 2202,
	[Cpp2IlInjected.Token(Token = "0x4000489")]
	RROStorefront_ToBeNamed_2 = 2203,
	[Cpp2IlInjected.Token(Token = "0x400048A")]
	DevStorefront_DoNotAddToWatch_1 = 2300,
	[Cpp2IlInjected.Token(Token = "0x400048B")]
	DevStorefront_DoNotAddToWatch_2 = 2301,
	[Cpp2IlInjected.Token(Token = "0x400048C")]
	DevStorefront_DoNotAddToWatch_3 = 2302,
	[Cpp2IlInjected.Token(Token = "0x400048D")]
	DevStorefront_DoNotAddToWatch_4 = 2303,
	[Cpp2IlInjected.Token(Token = "0x400048E")]
	DevStorefront_DoNotAddToWatch_5 = 2304
}
[Cpp2IlInjected.Token(Token = "0x20000F5")]
public enum BMDGMLCBLNF
{
	[Cpp2IlInjected.Token(Token = "0x4000490")]
	GiftDrop,
	[Cpp2IlInjected.Token(Token = "0x4000491")]
	SeasonTier,
	[Cpp2IlInjected.Token(Token = "0x4000492")]
	SeasonEliteUpgrade
}
[Cpp2IlInjected.Token(Token = "0x20000F6")]
public enum EDNJEAAIJKL
{
	[Cpp2IlInjected.Token(Token = "0x4000494")]
	Invalid = 0,
	[Cpp2IlInjected.Token(Token = "0x4000495")]
	DirectBalanceWithMultiplier = 1,
	[Cpp2IlInjected.Token(Token = "0x4000496")]
	FromGiftBox = 2,
	[Cpp2IlInjected.Token(Token = "0x4000497")]
	NUXChallenge = 10,
	[Cpp2IlInjected.Token(Token = "0x4000498")]
	AllNUXChallenges = 11,
	[Cpp2IlInjected.Token(Token = "0x4000499")]
	DailyChallenge = 100,
	[Cpp2IlInjected.Token(Token = "0x400049A")]
	AllDailyChallenges = 101,
	[Cpp2IlInjected.Token(Token = "0x400049B")]
	FinishActivity = 200,
	[Cpp2IlInjected.Token(Token = "0x400049C")]
	RecRoyaleMatchFinished = 250,
	[Cpp2IlInjected.Token(Token = "0x400049D")]
	ChecklistCredit = 303,
	[Cpp2IlInjected.Token(Token = "0x400049E")]
	WonGame = 1000,
	[Cpp2IlInjected.Token(Token = "0x400049F")]
	LostGame = 1001,
	[Cpp2IlInjected.Token(Token = "0x40004A0")]
	WonGameRateLimited = 1002,
	[Cpp2IlInjected.Token(Token = "0x40004A1")]
	WonGamePartial = 1003,
	[Cpp2IlInjected.Token(Token = "0x40004A2")]
	LevelUp = 1100,
	[Cpp2IlInjected.Token(Token = "0x40004A3")]
	Registered = 1200,
	[Cpp2IlInjected.Token(Token = "0x40004A4")]
	CreatorReward = 1300,
	[Cpp2IlInjected.Token(Token = "0x40004A5")]
	CommercePurchase = 1400,
	[Cpp2IlInjected.Token(Token = "0x40004A6")]
	CommercePurchaseRevoked = 1401,
	[Cpp2IlInjected.Token(Token = "0x40004A7")]
	Manual_Refund = 2000,
	[Cpp2IlInjected.Token(Token = "0x40004A8")]
	Manual_Thanks = 2010,
	[Cpp2IlInjected.Token(Token = "0x40004A9")]
	Manual_Apology = 2020,
	[Cpp2IlInjected.Token(Token = "0x40004AA")]
	TestOnly = 8000
}
[Cpp2IlInjected.Token(Token = "0x20000F7")]
public enum IIHFKBEIKNB
{
	[Cpp2IlInjected.Token(Token = "0x40004AC")]
	Interval,
	[Cpp2IlInjected.Token(Token = "0x40004AD")]
	PerDay
}
[Cpp2IlInjected.Token(Token = "0x20000F8")]
public enum IPCFJDFIOCM
{
	[Cpp2IlInjected.Token(Token = "0x40004AF")]
	PERCENTAGE = 1,
	[Cpp2IlInjected.Token(Token = "0x40004B0")]
	EXACT_AMOUNT
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
[BDENCKNLAKO]
public class DMPFFKFFNKP : IEquatable<DMPFFKFFNKP>
{
	[Cpp2IlInjected.Token(Token = "0x170002A2")]
	public int? FNLPNMKIOGA
	{
		[Cpp2IlInjected.Token(Token = "0x600064B")]
		[Cpp2IlInjected.Address(RVA = "0x9DF710", Offset = "0x9DDF10", VA = "0x1809DF710")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600064C")]
		[Cpp2IlInjected.Address(RVA = "0xCDCAB0", Offset = "0xCDB2B0", VA = "0x180CDCAB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002A3")]
	public int? KNGDLJNLKGI
	{
		[Cpp2IlInjected.Token(Token = "0x600064D")]
		[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600064E")]
		[Cpp2IlInjected.Address(RVA = "0xC57CB0", Offset = "0xC564B0", VA = "0x180C57CB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002A4")]
	public int? BJOIGHODLMP
	{
		[Cpp2IlInjected.Token(Token = "0x600064F")]
		[Cpp2IlInjected.Address(RVA = "0x9DF730", Offset = "0x9DDF30", VA = "0x1809DF730")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000650")]
		[Cpp2IlInjected.Address(RVA = "0xC79020", Offset = "0xC77820", VA = "0x180C79020")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002A5")]
	public List<int>? IIJKOILKIHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000651")]
		[Cpp2IlInjected.Address(RVA = "0x9DF790", Offset = "0x9DDF90", VA = "0x1809DF790")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000652")]
		[Cpp2IlInjected.Address(RVA = "0x9DF780", Offset = "0x9DDF80", VA = "0x1809DF780")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000653")]
	[Cpp2IlInjected.Address(RVA = "0x706DCF0", Offset = "0x706C4F0", VA = "0x18706DCF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000654")]
	[Cpp2IlInjected.Address(RVA = "0x706DC90", Offset = "0x706C490", VA = "0x18706DC90")]
	public static DMPFFKFFNKP LMPJHEFPPOG(int? NPNFKHJCBCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000655")]
	[Cpp2IlInjected.Address(RVA = "0x706D660", Offset = "0x706BE60", VA = "0x18706D660", Slot = "4")]
	public bool Equals(DMPFFKFFNKP? PGPJMFPAKOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000656")]
	[Cpp2IlInjected.Address(RVA = "0x706DBF0", Offset = "0x706C3F0", VA = "0x18706DBF0")]
	private static bool IIEBFOOAEHG(List<int>? BINANFFLHIK, List<int>? NOAPPAEGHOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000657")]
	[Cpp2IlInjected.Address(RVA = "0x706D7E0", Offset = "0x706BFE0", VA = "0x18706D7E0", Slot = "0")]
	public override bool Equals(object? PNHCNFOFAFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000658")]
	[Cpp2IlInjected.Address(RVA = "0x706DA10", Offset = "0x706C210", VA = "0x18706DA10", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000659")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public DMPFFKFFNKP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FA")]
public struct BNHEKEPANBN : IEquatable<BNHEKEPANBN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004B5")]
	public readonly BPEBJLOIJPB IFCMPJACFHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40004B6")]
	private readonly int MLAIEDDEFJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004B7")]
	private readonly Guid HNPGENHBKNE;

	[Cpp2IlInjected.Token(Token = "0x170002A6")]
	public Guid ACPBCEPFHAA
	{
		[Cpp2IlInjected.Token(Token = "0x600065A")]
		[Cpp2IlInjected.Address(RVA = "0x706BA00", Offset = "0x706A200", VA = "0x18706BA00")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002A7")]
	public int FKCKKMGFOOO
	{
		[Cpp2IlInjected.Token(Token = "0x600065B")]
		[Cpp2IlInjected.Address(RVA = "0x706C040", Offset = "0x706A840", VA = "0x18706C040")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002A8")]
	public string OMBJHBJMMML
	{
		[Cpp2IlInjected.Token(Token = "0x600065C")]
		[Cpp2IlInjected.Address(RVA = "0x706BBD0", Offset = "0x706A3D0", VA = "0x18706BBD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600065D")]
	[Cpp2IlInjected.Address(RVA = "0x706B5C0", Offset = "0x7069DC0", VA = "0x18706B5C0")]
	public static bool AJHOHMFMDLC(string HCBFCADAOMC, [Out] BNHEKEPANBN CJAMLNMKAKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600065E")]
	[Cpp2IlInjected.Address(RVA = "0x706BE00", Offset = "0x706A600", VA = "0x18706BE00")]
	public static BNHEKEPANBN KPBEBEDKBNH(int MLBCMOLHELH)
	{
		return default(BNHEKEPANBN);
	}

	[Cpp2IlInjected.Token(Token = "0x600065F")]
	[Cpp2IlInjected.Address(RVA = "0x706BCB0", Offset = "0x706A4B0", VA = "0x18706BCB0")]
	public static BNHEKEPANBN KNLMIEJGMBL(Guid MLBCMOLHELH)
	{
		return default(BNHEKEPANBN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000660")]
	[Cpp2IlInjected.Address(RVA = "0x706BF30", Offset = "0x706A730", VA = "0x18706BF30")]
	private static bool NOFCEMFDJPH(string HCBFCADAOMC, [Out] BPEBJLOIJPB HGDECDJAKBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000661")]
	[Cpp2IlInjected.Address(RVA = "0x706C100", Offset = "0x706A900", VA = "0x18706C100")]
	private BNHEKEPANBN(BPEBJLOIJPB HGDECDJAKBB, int? GLPPBFIILPN, Guid? KAAGPNJIINH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000662")]
	[Cpp2IlInjected.Address(RVA = "0x706BB60", Offset = "0x706A360", VA = "0x18706BB60", Slot = "4")]
	public bool Equals(BNHEKEPANBN PGPJMFPAKOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000663")]
	[Cpp2IlInjected.Address(RVA = "0x706BA70", Offset = "0x706A270", VA = "0x18706BA70", Slot = "0")]
	public override bool Equals(object PNHCNFOFAFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000664")]
	[Cpp2IlInjected.Address(RVA = "0x706BC20", Offset = "0x706A420", VA = "0x18706BC20", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000665")]
	[Cpp2IlInjected.Address(RVA = "0x706C050", Offset = "0x706A850", VA = "0x18706C050", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FB")]
[BDENCKNLAKO]
public abstract class KLGJFHMNMIM : IEquatable<KLGJFHMNMIM>, HDINHDBEFHC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004B8")]
	public Guid PJFNCPIJCFE;

	[Cpp2IlInjected.Token(Token = "0x6000666")]
	[Cpp2IlInjected.Address(RVA = "0x7071FD0", Offset = "0x70707D0", VA = "0x187071FD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000667")]
	[Cpp2IlInjected.Address(RVA = "0x7071F50", Offset = "0x7070750", VA = "0x187071F50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000668")]
	[Cpp2IlInjected.Address(RVA = "0x706E070", Offset = "0x706C870", VA = "0x18706E070", Slot = "4")]
	public bool Equals(KLGJFHMNMIM PGPJMFPAKOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000669")]
	[Cpp2IlInjected.Address(RVA = "0x7071E40", Offset = "0x7070640", VA = "0x187071E40", Slot = "0")]
	public override bool Equals(object PNHCNFOFAFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600066A")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "5")]
	public void AOEGOOLELIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600066B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract KLGJFHMNMIM LMNLEEHCNJH();

	[Cpp2IlInjected.Token(Token = "0x600066C")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	protected KLGJFHMNMIM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FC")]
public enum LMCIBMIFEHG
{
	[Cpp2IlInjected.Token(Token = "0x40004BA")]
	RoomKey,
	[Cpp2IlInjected.Token(Token = "0x40004BB")]
	RoomConsumable,
	[Cpp2IlInjected.Token(Token = "0x40004BC")]
	RoomCurrencyPurchaseOffer,
	[Cpp2IlInjected.Token(Token = "0x40004BD")]
	CustomAvatarItem,
	[Cpp2IlInjected.Token(Token = "0x40004BE")]
	StoreUGCAvatarItem,
	[Cpp2IlInjected.Token(Token = "0x40004BF")]
	UNDEFINED
}
[Cpp2IlInjected.Token(Token = "0x20000FD")]
[BDENCKNLAKO]
public class GGHEBLNIHGG : KLGJFHMNMIM, IEquatable<GGHEBLNIHGG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004C0")]
	public LMCIBMIFEHG HGDECDJAKBB;

	[Cpp2IlInjected.Token(Token = "0x600066D")]
	[Cpp2IlInjected.Address(RVA = "0x706F3D0", Offset = "0x706DBD0", VA = "0x18706F3D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600066E")]
	[Cpp2IlInjected.Address(RVA = "0x706F270", Offset = "0x706DA70", VA = "0x18706F270", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600066F")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public GGHEBLNIHGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000670")]
	[Cpp2IlInjected.Address(RVA = "0x706F470", Offset = "0x706DC70", VA = "0x18706F470")]
	public GGHEBLNIHGG(LMCIBMIFEHG HGDECDJAKBB, Guid PJFNCPIJCFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000671")]
	[Cpp2IlInjected.Address(RVA = "0x706F2F0", Offset = "0x706DAF0", VA = "0x18706F2F0")]
	public static GGHEBLNIHGG KNLMIEJGMBL(Guid IOFOJGFFCHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000672")]
	[Cpp2IlInjected.Address(RVA = "0x706F220", Offset = "0x706DA20", VA = "0x18706F220", Slot = "7")]
	public bool Equals(GGHEBLNIHGG PGPJMFPAKOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000673")]
	[Cpp2IlInjected.Address(RVA = "0x706F360", Offset = "0x706DB60", VA = "0x18706F360", Slot = "6")]
	public override KLGJFHMNMIM LMNLEEHCNJH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FE")]
public static class OCHEGDJODMO
{
	[Cpp2IlInjected.Token(Token = "0x6000674")]
	[Cpp2IlInjected.Address(RVA = "0x7073950", Offset = "0x7072150", VA = "0x187073950")]
	public static GGHEBLNIHGG DCDLIDOFHJH(this AEGPIDJEJJD BLFLGKHLJNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000675")]
	[Cpp2IlInjected.Address(RVA = "0x70737F0", Offset = "0x7071FF0", VA = "0x1870737F0")]
	public static GGHEBLNIHGG BADGNPPKOJM(string JKIFKGJDAEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000676")]
	[Cpp2IlInjected.Address(RVA = "0x70738E0", Offset = "0x70720E0", VA = "0x1870738E0")]
	public static GGHEBLNIHGG BPCBHHDMFMC(Guid PNFHFGDFAIN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FF")]
[BDENCKNLAKO]
public class AEGPIDJEJJD : KBMNKECBFGE, HDINHDBEFHC
{
	[Cpp2IlInjected.Token(Token = "0x170002A9")]
	public LMCIBMIFEHG IFCMPJACFHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000677")]
		[Cpp2IlInjected.Address(RVA = "0x9DD1A0", Offset = "0x9DB9A0", VA = "0x1809DD1A0")]
		[CompilerGenerated]
		get
		{
			return default(LMCIBMIFEHG);
		}
		[Cpp2IlInjected.Token(Token = "0x6000678")]
		[Cpp2IlInjected.Address(RVA = "0x9EBF60", Offset = "0x9EA760", VA = "0x1809EBF60")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002AA")]
	public Guid IBLKPDCCDKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000679")]
		[Cpp2IlInjected.Address(RVA = "0x188DD40", Offset = "0x188C540", VA = "0x18188DD40")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x600067A")]
		[Cpp2IlInjected.Address(RVA = "0x5795F10", Offset = "0x5794710", VA = "0x185795F10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002AB")]
	public string ACOJEEABMOC
	{
		[Cpp2IlInjected.Token(Token = "0x600067B")]
		[Cpp2IlInjected.Address(RVA = "0x9DF790", Offset = "0x9DDF90", VA = "0x1809DF790")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600067C")]
		[Cpp2IlInjected.Address(RVA = "0x9DF780", Offset = "0x9DDF80", VA = "0x1809DF780")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002AC")]
	public string NJJPEPDLCHL
	{
		[Cpp2IlInjected.Token(Token = "0x600067D")]
		[Cpp2IlInjected.Address(RVA = "0x9DF770", Offset = "0x9DDF70", VA = "0x1809DF770")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600067E")]
		[Cpp2IlInjected.Address(RVA = "0x9DF750", Offset = "0x9DDF50", VA = "0x1809DF750")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002AD")]
	public string GFJBHKHMHCE
	{
		[Cpp2IlInjected.Token(Token = "0x600067F")]
		[Cpp2IlInjected.Address(RVA = "0x9E0DB0", Offset = "0x9DF5B0", VA = "0x1809E0DB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000680")]
		[Cpp2IlInjected.Address(RVA = "0x9E0DC0", Offset = "0x9DF5C0", VA = "0x1809E0DC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002AE")]
	public long? MPBMECOMGLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000681")]
		[Cpp2IlInjected.Address(RVA = "0xE99CC0", Offset = "0xE984C0", VA = "0x180E99CC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000682")]
		[Cpp2IlInjected.Address(RVA = "0xE99E10", Offset = "0xE98610", VA = "0x180E99E10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002AF")]
	public long CFBMCPJNOHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000683")]
		[Cpp2IlInjected.Address(RVA = "0x9DD200", Offset = "0x9DBA00", VA = "0x1809DD200")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000684")]
		[Cpp2IlInjected.Address(RVA = "0xDFC260", Offset = "0xDFAA60", VA = "0x180DFC260")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002B0")]
	public Guid? EPKKNOBADMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000685")]
		[Cpp2IlInjected.Address(RVA = "0x706ADA0", Offset = "0x70695A0", VA = "0x18706ADA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000686")]
		[Cpp2IlInjected.Address(RVA = "0x706ADC0", Offset = "0x70695C0", VA = "0x18706ADC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002B1")]
	public DateTime OKKIKOGNGDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000687")]
		[Cpp2IlInjected.Address(RVA = "0x9DD1F0", Offset = "0x9DB9F0", VA = "0x1809DD1F0")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x6000688")]
		[Cpp2IlInjected.Address(RVA = "0xE297B0", Offset = "0xE27FB0", VA = "0x180E297B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002B2")]
	public DateTime NEDBPOMOOOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000689")]
		[Cpp2IlInjected.Address(RVA = "0x9E93E0", Offset = "0x9E7BE0", VA = "0x1809E93E0")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x600068A")]
		[Cpp2IlInjected.Address(RVA = "0xE29760", Offset = "0xE27F60", VA = "0x180E29760")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600068B")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public AEGPIDJEJJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600068C")]
	[Cpp2IlInjected.Address(RVA = "0x706AE80", Offset = "0x7069680", VA = "0x18706AE80")]
	public AEGPIDJEJJD(LMCIBMIFEHG HGDECDJAKBB, Guid PJFNCPIJCFE, [Optional] string GLGOHIJMLFB, [Optional] string NIAMDMBDIJG, [Optional] string LJANIECHELJ, [Optional] long? MDLDCACFGIB, long BBCMDPJPAOE = 0L, [Optional] Guid? MIJKNNLCBGG, [Optional] DateTime LIHJPHMPNOL, [Optional] DateTime GLOONLBLPGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600068D")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "4")]
	public void AOEGOOLELIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600068E")]
	[Cpp2IlInjected.Address(RVA = "0x706ADD0", Offset = "0x70695D0", VA = "0x18706ADD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000100")]
public enum LAHGMBJNKFJ
{
	[Cpp2IlInjected.Token(Token = "0x40004CC")]
	General,
	[Cpp2IlInjected.Token(Token = "0x40004CD")]
	Auto,
	[Cpp2IlInjected.Token(Token = "0x40004CE")]
	AGOnly,
	[Cpp2IlInjected.Token(Token = "0x40004CF")]
	Banned
}
[Cpp2IlInjected.Token(Token = "0x2000101")]
public enum JBOOCBEEEDM
{
	[Cpp2IlInjected.Token(Token = "0x40004D1")]
	Success,
	[Cpp2IlInjected.Token(Token = "0x40004D2")]
	TooManyTags,
	[Cpp2IlInjected.Token(Token = "0x40004D3")]
	TagUseRestricted,
	[Cpp2IlInjected.Token(Token = "0x40004D4")]
	InvalidTag,
	[Cpp2IlInjected.Token(Token = "0x40004D5")]
	InappropriateTag,
	[Cpp2IlInjected.Token(Token = "0x40004D6")]
	TagTooLong,
	[Cpp2IlInjected.Token(Token = "0x40004D7")]
	TagNotFound,
	[Cpp2IlInjected.Token(Token = "0x40004D8")]
	TagAlreadyExists,
	[Cpp2IlInjected.Token(Token = "0x40004D9")]
	NoChange,
	[Cpp2IlInjected.Token(Token = "0x40004DA")]
	TagRepeated,
	[Cpp2IlInjected.Token(Token = "0x40004DB")]
	LacksPermission,
	[Cpp2IlInjected.Token(Token = "0x40004DC")]
	RoomDoesNotExist,
	[Cpp2IlInjected.Token(Token = "0x40004DD")]
	InventionDoesNotExist,
	[Cpp2IlInjected.Token(Token = "0x40004DE")]
	ReservedWordViolation
}
[Cpp2IlInjected.Token(Token = "0x2000102")]
[BDENCKNLAKO]
public class HBENEMBCNMN : HDINHDBEFHC
{
	[Cpp2IlInjected.Token(Token = "0x170002B3")]
	public JBOOCBEEEDM JBGJDBLIIKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600068F")]
		[Cpp2IlInjected.Address(RVA = "0x9DD1A0", Offset = "0x9DB9A0", VA = "0x1809DD1A0")]
		[CompilerGenerated]
		get
		{
			return default(JBOOCBEEEDM);
		}
		[Cpp2IlInjected.Token(Token = "0x6000690")]
		[Cpp2IlInjected.Address(RVA = "0x9EBF60", Offset = "0x9EA760", VA = "0x1809EBF60")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002B4")]
	public List<string> FHGFDMDLJNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000691")]
		[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000692")]
		[Cpp2IlInjected.Address(RVA = "0x9DF700", Offset = "0x9DDF00", VA = "0x1809DF700")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000693")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "4")]
	public void AOEGOOLELIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000694")]
	[Cpp2IlInjected.Address(RVA = "0x706F6D0", Offset = "0x706DED0", VA = "0x18706F6D0")]
	public string GMCEEGOICPB(int KPHPIIANKBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000695")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public HBENEMBCNMN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000103")]
[BDENCKNLAKO]
public class PGFHCNLIEKC : HDINHDBEFHC
{
	[Cpp2IlInjected.Token(Token = "0x170002B5")]
	public string FFMOLMBIDKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000696")]
		[Cpp2IlInjected.Address(RVA = "0x9DF710", Offset = "0x9DDF10", VA = "0x1809DF710")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000697")]
		[Cpp2IlInjected.Address(RVA = "0x9DF720", Offset = "0x9DDF20", VA = "0x1809DF720")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002B6")]
	public LAHGMBJNKFJ PALJBODIBGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000698")]
		[Cpp2IlInjected.Address(RVA = "0x9E9470", Offset = "0x9E7C70", VA = "0x1809E9470")]
		[CompilerGenerated]
		get
		{
			return default(LAHGMBJNKFJ);
		}
		[Cpp2IlInjected.Token(Token = "0x6000699")]
		[Cpp2IlInjected.Address(RVA = "0x9EC7A0", Offset = "0x9EAFA0", VA = "0x1809EC7A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600069A")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "4")]
	public void AOEGOOLELIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600069B")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public PGFHCNLIEKC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000104")]
public static class LOEDNPAAEFA
{
	[Cpp2IlInjected.Token(Token = "0x40004E3")]
	public const string IFFBDMIGFOI = "costume";

	[Cpp2IlInjected.Token(Token = "0x40004E4")]
	public const string MKLFCMLMIME = "gadget";

	[Cpp2IlInjected.Token(Token = "0x40004E5")]
	public const string CMIOBEAEOPC = "holotar";

	[Cpp2IlInjected.Token(Token = "0x40004E6")]
	public const string ENFMDKKAJCK = "large";

	[Cpp2IlInjected.Token(Token = "0x40004E7")]
	public const string EHMEPPDLANL = "medium";

	[Cpp2IlInjected.Token(Token = "0x40004E8")]
	public const string IINHOCJLKJI = "small";

	[Cpp2IlInjected.Token(Token = "0x40004E9")]
	public const string LOLFGAJKALE = "sound";

	[Cpp2IlInjected.Token(Token = "0x40004EA")]
	public const string JFNCJMGOJKE = "dormanchor";

	[Cpp2IlInjected.Token(Token = "0x40004EB")]
	public const string NFAOPDAKBPJ = "reccenteranchor";

	[Cpp2IlInjected.Token(Token = "0x40004EC")]
	public const string PHKHEEMKKKF = "r2";

	[Cpp2IlInjected.Token(Token = "0x170002B7")]
	public static List<string> LCODCDPKBOP
	{
		[Cpp2IlInjected.Token(Token = "0x600069C")]
		[Cpp2IlInjected.Address(RVA = "0x70727B0", Offset = "0x7070FB0", VA = "0x1870727B0")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000105")]
public static class KDPMMILGKHN
{
	[Cpp2IlInjected.Token(Token = "0x40004ED")]
	public const string NGHLDCGFLDK = "beta";

	[Cpp2IlInjected.Token(Token = "0x40004EE")]
	public const string KHLOIJINFFG = "limitsv2";
}
[Cpp2IlInjected.Token(Token = "0x2000106")]
[BDENCKNLAKO]
public class FCPOOHEOJKD : HDINHDBEFHC
{
	[Cpp2IlInjected.Token(Token = "0x170002B8")]
	public List<string> GMMDMGACGHN
	{
		[Cpp2IlInjected.Token(Token = "0x600069D")]
		[Cpp2IlInjected.Address(RVA = "0x9DF710", Offset = "0x9DDF10", VA = "0x1809DF710")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600069E")]
		[Cpp2IlInjected.Address(RVA = "0x9DF720", Offset = "0x9DDF20", VA = "0x1809DF720")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002B9")]
	public List<string> INABMLNFFOB
	{
		[Cpp2IlInjected.Token(Token = "0x600069F")]
		[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006A0")]
		[Cpp2IlInjected.Address(RVA = "0x9DF700", Offset = "0x9DDF00", VA = "0x1809DF700")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002BA")]
	public List<string> IOEKAGPBBFM
	{
		[Cpp2IlInjected.Token(Token = "0x60006A1")]
		[Cpp2IlInjected.Address(RVA = "0x9DF730", Offset = "0x9DDF30", VA = "0x1809DF730")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006A2")]
		[Cpp2IlInjected.Address(RVA = "0x9DF740", Offset = "0x9DDF40", VA = "0x1809DF740")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006A3")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "4")]
	public void AOEGOOLELIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A4")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public FCPOOHEOJKD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000107")]
public class MDDCHKLKJJI : IEquatable<MDDCHKLKJJI>
{
	[Cpp2IlInjected.Token(Token = "0x170002BB")]
	protected virtual Type LPLLMCDLLHO
	{
		[Cpp2IlInjected.Token(Token = "0x60006A6")]
		[Cpp2IlInjected.Address(RVA = "0x7072FD0", Offset = "0x70717D0", VA = "0x187072FD0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002BC")]
	public IHEADBDKHBJ? NPNDIKJDFPI
	{
		[Cpp2IlInjected.Token(Token = "0x60006A7")]
		[Cpp2IlInjected.Address(RVA = "0x9DF710", Offset = "0x9DDF10", VA = "0x1809DF710")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006A8")]
		[Cpp2IlInjected.Address(RVA = "0xCDCAB0", Offset = "0xCDB2B0", VA = "0x180CDCAB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002BD")]
	public HttpMethod? JODBJMBGOHN
	{
		[Cpp2IlInjected.Token(Token = "0x60006A9")]
		[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006AA")]
		[Cpp2IlInjected.Address(RVA = "0x9DF700", Offset = "0x9DDF00", VA = "0x1809DF700")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002BE")]
	public string? DEGHEDDEBDN
	{
		[Cpp2IlInjected.Token(Token = "0x60006AB")]
		[Cpp2IlInjected.Address(RVA = "0x9DF730", Offset = "0x9DDF30", VA = "0x1809DF730")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006AC")]
		[Cpp2IlInjected.Address(RVA = "0x9DF740", Offset = "0x9DDF40", VA = "0x1809DF740")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006A5")]
	[Cpp2IlInjected.Address(RVA = "0x70731A0", Offset = "0x70719A0", VA = "0x1870731A0")]
	public MDDCHKLKJJI(IHEADBDKHBJ? NPNDIKJDFPI, HttpMethod? JODBJMBGOHN, string? DEGHEDDEBDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006AD")]
	[Cpp2IlInjected.Address(RVA = "0x7073030", Offset = "0x7071830", VA = "0x187073030", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006AE")]
	[Cpp2IlInjected.Address(RVA = "0x7072A10", Offset = "0x7071210", VA = "0x187072A10", Slot = "6")]
	protected virtual bool DKEOECEPNNL(StringBuilder BNBMBDEFHIJ)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60006AF")]
	[Cpp2IlInjected.Address(RVA = "0xEC9630", Offset = "0xEC7E30", VA = "0x180EC9630")]
	public static bool ONONOJDPAAN(MDDCHKLKJJI? FGLDDBBPFDE, MDDCHKLKJJI? DPCHMAGAFJN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60006B0")]
	[Cpp2IlInjected.Address(RVA = "0xEC9600", Offset = "0xEC7E00", VA = "0x180EC9600")]
	public static bool NIDGPKKMDPO(MDDCHKLKJJI? FGLDDBBPFDE, MDDCHKLKJJI? DPCHMAGAFJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006B1")]
	[Cpp2IlInjected.Address(RVA = "0x7072E60", Offset = "0x7071660", VA = "0x187072E60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60006B2")]
	[Cpp2IlInjected.Address(RVA = "0x7072C00", Offset = "0x7071400", VA = "0x187072C00", Slot = "0")]
	public override bool Equals(object? PNHCNFOFAFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006B3")]
	[Cpp2IlInjected.Address(RVA = "0x7072C90", Offset = "0x7071490", VA = "0x187072C90", Slot = "7")]
	public virtual bool Equals(MDDCHKLKJJI? PGPJMFPAKOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006B4")]
	[Cpp2IlInjected.Address(RVA = "0x7072B70", Offset = "0x7071370", VA = "0x187072B70", Slot = "8")]
	public virtual MDDCHKLKJJI DPGKEAJBDMJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006B5")]
	[Cpp2IlInjected.Address(RVA = "0x7073140", Offset = "0x7071940", VA = "0x187073140")]
	protected MDDCHKLKJJI(MDDCHKLKJJI OGIIDFFGAOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006B6")]
	[Cpp2IlInjected.Address(RVA = "0x7072E20", Offset = "0x7071620", VA = "0x187072E20")]
	public void GBLJIMIKPOB([Out] IHEADBDKHBJ? NPNDIKJDFPI, [Out] HttpMethod? JODBJMBGOHN, [Out] string? DEGHEDDEBDN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000108")]
public class PCGCHFFBFFC : IEquatable<PCGCHFFBFFC>
{
	[Cpp2IlInjected.Token(Token = "0x170002BF")]
	protected virtual Type LPLLMCDLLHO
	{
		[Cpp2IlInjected.Token(Token = "0x60006B8")]
		[Cpp2IlInjected.Address(RVA = "0x7074020", Offset = "0x7072820", VA = "0x187074020", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002C0")]
	public int LDMHMJPCLIE
	{
		[Cpp2IlInjected.Token(Token = "0x60006B9")]
		[Cpp2IlInjected.Address(RVA = "0x9DD1A0", Offset = "0x9DB9A0", VA = "0x1809DD1A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60006BA")]
		[Cpp2IlInjected.Address(RVA = "0x9EBF60", Offset = "0x9EA760", VA = "0x1809EBF60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002C1")]
	public FMODPLEICDD KECDLGPOCCK
	{
		[Cpp2IlInjected.Token(Token = "0x60006BB")]
		[Cpp2IlInjected.Address(RVA = "0xB5FCA0", Offset = "0xB5E4A0", VA = "0x180B5FCA0")]
		[CompilerGenerated]
		get
		{
			return default(FMODPLEICDD);
		}
		[Cpp2IlInjected.Token(Token = "0x60006BC")]
		[Cpp2IlInjected.Address(RVA = "0xC57CC0", Offset = "0xC564C0", VA = "0x180C57CC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006B7")]
	[Cpp2IlInjected.Address(RVA = "0x7074190", Offset = "0x7072990", VA = "0x187074190")]
	public PCGCHFFBFFC(int LDMHMJPCLIE, FMODPLEICDD KECDLGPOCCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006BD")]
	[Cpp2IlInjected.Address(RVA = "0x7074080", Offset = "0x7072880", VA = "0x187074080", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006BE")]
	[Cpp2IlInjected.Address(RVA = "0x7073B90", Offset = "0x7072390", VA = "0x187073B90", Slot = "6")]
	protected virtual bool DKEOECEPNNL(StringBuilder BNBMBDEFHIJ)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60006BF")]
	[Cpp2IlInjected.Address(RVA = "0xEC9630", Offset = "0xEC7E30", VA = "0x180EC9630")]
	public static bool ONONOJDPAAN(PCGCHFFBFFC? FGLDDBBPFDE, PCGCHFFBFFC? DPCHMAGAFJN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60006C0")]
	[Cpp2IlInjected.Address(RVA = "0xEC9600", Offset = "0xEC7E00", VA = "0x180EC9600")]
	public static bool NIDGPKKMDPO(PCGCHFFBFFC? FGLDDBBPFDE, PCGCHFFBFFC? DPCHMAGAFJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006C1")]
	[Cpp2IlInjected.Address(RVA = "0x7073F10", Offset = "0x7072710", VA = "0x187073F10", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60006C2")]
	[Cpp2IlInjected.Address(RVA = "0x7073D30", Offset = "0x7072530", VA = "0x187073D30", Slot = "0")]
	public override bool Equals(object? PNHCNFOFAFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006C3")]
	[Cpp2IlInjected.Address(RVA = "0x7073DC0", Offset = "0x70725C0", VA = "0x187073DC0", Slot = "7")]
	public virtual bool Equals(PCGCHFFBFFC? PGPJMFPAKOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006C4")]
	[Cpp2IlInjected.Address(RVA = "0x7073CC0", Offset = "0x70724C0", VA = "0x187073CC0", Slot = "8")]
	public virtual PCGCHFFBFFC DPGKEAJBDMJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006C5")]
	[Cpp2IlInjected.Address(RVA = "0xB5FDA0", Offset = "0xB5E5A0", VA = "0x180B5FDA0")]
	protected PCGCHFFBFFC(PCGCHFFBFFC OGIIDFFGAOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C6")]
	[Cpp2IlInjected.Address(RVA = "0x7073F00", Offset = "0x7072700", VA = "0x187073F00")]
	public void GBLJIMIKPOB([Out] int LDMHMJPCLIE, [Out] FMODPLEICDD KECDLGPOCCK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000109")]
public enum FMODPLEICDD
{
	[Cpp2IlInjected.Token(Token = "0x40004F8")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40004F9")]
	ConnectionTimeout,
	[Cpp2IlInjected.Token(Token = "0x40004FA")]
	InternalServerError
}
[Cpp2IlInjected.Token(Token = "0x200010A")]
public interface DJLAPCPKMJJ
{
	[Cpp2IlInjected.Token(Token = "0x60006C7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IReadOnlyDictionary<MDDCHKLKJJI, PCGCHFFBFFC> AMFCCLNKMBB();

	[Cpp2IlInjected.Token(Token = "0x60006C8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FJALKJEMHLL(MDDCHKLKJJI BELIEAFHDAH, PCGCHFFBFFC GFMBHCHPLDH);

	[Cpp2IlInjected.Token(Token = "0x60006C9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ADPAEEJPOPK(MDDCHKLKJJI BELIEAFHDAH);

	[Cpp2IlInjected.Token(Token = "0x60006CA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void IJMFBMKONLD();

	[Cpp2IlInjected.Token(Token = "0x60006CB")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task KLCKGEAFDOL(IHEADBDKHBJ KICOAPCJPFE, HttpMethod DHJOJHBFIIF, string PFJPGPHDMPG, CancellationToken DNHBNMHIDAC);
}
[Cpp2IlInjected.Token(Token = "0x200010B")]
[LMPNAKPEIDE]
public class ANJHPPEHIAC<TResult> where TResult : HDINHDBEFHC, new()
{
	[Cpp2IlInjected.Token(Token = "0x170002C2")]
	public IReadOnlyList<TResult> PMKPCLCDCBI
	{
		[Cpp2IlInjected.Token(Token = "0x60006CC")]
		[Cpp2IlInjected.Address(RVA = "0x9DF710", Offset = "0x9DDF10", VA = "0x1809DF710")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006CD")]
		[Cpp2IlInjected.Address(RVA = "0x9DF720", Offset = "0x9DDF20", VA = "0x1809DF720")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002C3")]
	public long KKJOEKAIIBK
	{
		[Cpp2IlInjected.Token(Token = "0x60006CE")]
		[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x60006CF")]
		[Cpp2IlInjected.Address(RVA = "0xC57CB0", Offset = "0xC564B0", VA = "0x180C57CB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006D0")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public ANJHPPEHIAC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010C")]
public enum DJFBNCKFIMM
{
	[Cpp2IlInjected.Token(Token = "0x40004FE")]
	Development = 1,
	[Cpp2IlInjected.Token(Token = "0x40004FF")]
	QA = 8,
	[Cpp2IlInjected.Token(Token = "0x4000500")]
	Production = 0x100
}
[Cpp2IlInjected.Token(Token = "0x200010D")]
public interface KNCJLGOHIEG
{
	[Cpp2IlInjected.Token(Token = "0x60006D1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IReadOnlyList<AGCHINJCLHB>> NIICAHJAHIH(bool LECIAAEEEMC = false, [Optional] CancellationToken DNHBNMHIDAC);

	[Cpp2IlInjected.Token(Token = "0x60006D2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool AHPIEFFDDGM([Out] AGCHINJCLHB? OPMIAMEJKDH);

	[Cpp2IlInjected.Token(Token = "0x60006D3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<AGCHINJCLHB> ILNBIGKFKLF(bool LECIAAEEEMC = false, [Optional] CancellationToken DNHBNMHIDAC);

	[Cpp2IlInjected.Token(Token = "0x60006D4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BKBHPIPEDNJ(string NLGEMFKLFCF = "");
}
[Cpp2IlInjected.Token(Token = "0x200010E")]
public abstract class FFEPNFKMCIE
{
	[Cpp2IlInjected.Token(Token = "0x60006D5")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	protected FFEPNFKMCIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010F")]
[BDENCKNLAKO]
public class AGCHINJCLHB : HDINHDBEFHC
{
	[Cpp2IlInjected.Token(Token = "0x170002C4")]
	public int KBAEBNONMKL
	{
		[Cpp2IlInjected.Token(Token = "0x60006D6")]
		[Cpp2IlInjected.Address(RVA = "0x9DD1A0", Offset = "0x9DB9A0", VA = "0x1809DD1A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60006D7")]
		[Cpp2IlInjected.Address(RVA = "0x9EBF60", Offset = "0x9EA760", VA = "0x1809EBF60")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002C5")]
	public string ACOJEEABMOC
	{
		[Cpp2IlInjected.Token(Token = "0x60006D8")]
		[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006D9")]
		[Cpp2IlInjected.Address(RVA = "0x9DF700", Offset = "0x9DDF00", VA = "0x1809DF700")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002C6")]
	public string NJJPEPDLCHL
	{
		[Cpp2IlInjected.Token(Token = "0x60006DA")]
		[Cpp2IlInjected.Address(RVA = "0x9DF730", Offset = "0x9DDF30", VA = "0x1809DF730")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006DB")]
		[Cpp2IlInjected.Address(RVA = "0x9DF740", Offset = "0x9DDF40", VA = "0x1809DF740")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002C7")]
	public string GFJBHKHMHCE
	{
		[Cpp2IlInjected.Token(Token = "0x60006DC")]
		[Cpp2IlInjected.Address(RVA = "0x9DF790", Offset = "0x9DDF90", VA = "0x1809DF790")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006DD")]
		[Cpp2IlInjected.Address(RVA = "0x9DF780", Offset = "0x9DDF80", VA = "0x1809DF780")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002C8")]
	public int CFBMCPJNOHN
	{
		[Cpp2IlInjected.Token(Token = "0x60006DE")]
		[Cpp2IlInjected.Address(RVA = "0x9E4120", Offset = "0x9E2920", VA = "0x1809E4120")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60006DF")]
		[Cpp2IlInjected.Address(RVA = "0x9E4110", Offset = "0x9E2910", VA = "0x1809E4110")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002C9")]
	public string KEBENACDEMK
	{
		[Cpp2IlInjected.Token(Token = "0x60006E0")]
		[Cpp2IlInjected.Address(RVA = "0x9E0DB0", Offset = "0x9DF5B0", VA = "0x1809E0DB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006E1")]
		[Cpp2IlInjected.Address(RVA = "0x9E0DC0", Offset = "0x9DF5C0", VA = "0x1809E0DC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002CA")]
	public string NLJEBLGLJKC
	{
		[Cpp2IlInjected.Token(Token = "0x60006E2")]
		[Cpp2IlInjected.Address(RVA = "0x9E2460", Offset = "0x9E0C60", VA = "0x1809E2460")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006E3")]
		[Cpp2IlInjected.Address(RVA = "0x9E0DA0", Offset = "0x9DF5A0", VA = "0x1809E0DA0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002CB")]
	[DataMember(Name = "PsnProductLabel")]
	public string JCAKOGFFJEN
	{
		[Cpp2IlInjected.Token(Token = "0x60006E4")]
		[Cpp2IlInjected.Address(RVA = "0x9E0DD0", Offset = "0x9DF5D0", VA = "0x1809E0DD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006E5")]
		[Cpp2IlInjected.Address(RVA = "0x9E0BB0", Offset = "0x9DF3B0", VA = "0x1809E0BB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002CC")]
	public string GBPKNJIPNAE
	{
		[Cpp2IlInjected.Token(Token = "0x60006E6")]
		[Cpp2IlInjected.Address(RVA = "0x9DD200", Offset = "0x9DBA00", VA = "0x1809DD200")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006E7")]
		[Cpp2IlInjected.Address(RVA = "0x9DD240", Offset = "0x9DBA40", VA = "0x1809DD240")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002CD")]
	public string GFLFAIKNEKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60006E8")]
		[Cpp2IlInjected.Address(RVA = "0x9DD230", Offset = "0x9DBA30", VA = "0x1809DD230")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006E9")]
		[Cpp2IlInjected.Address(RVA = "0x9DD1D0", Offset = "0x9DB9D0", VA = "0x1809DD1D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002CE")]
	public string CMFFPAKNPJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60006EA")]
		[Cpp2IlInjected.Address(RVA = "0x9DD210", Offset = "0x9DBA10", VA = "0x1809DD210")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006EB")]
		[Cpp2IlInjected.Address(RVA = "0x9DD220", Offset = "0x9DBA20", VA = "0x1809DD220")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002CF")]
	public string MLAADCMOFKN
	{
		[Cpp2IlInjected.Token(Token = "0x60006EC")]
		[Cpp2IlInjected.Address(RVA = "0x9DD1C0", Offset = "0x9DB9C0", VA = "0x1809DD1C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006ED")]
		[Cpp2IlInjected.Address(RVA = "0x9DD1B0", Offset = "0x9DB9B0", VA = "0x1809DD1B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002D0")]
	public string AELBPHEMIHI
	{
		[Cpp2IlInjected.Token(Token = "0x60006EE")]
		[Cpp2IlInjected.Address(RVA = "0x9DD1F0", Offset = "0x9DB9F0", VA = "0x1809DD1F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006EF")]
		[Cpp2IlInjected.Address(RVA = "0x9DD1E0", Offset = "0x9DB9E0", VA = "0x1809DD1E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002D1")]
	public bool HINJACOHLCF
	{
		[Cpp2IlInjected.Token(Token = "0x60006F0")]
		[Cpp2IlInjected.Address(RVA = "0xC053B0", Offset = "0xC03BB0", VA = "0x180C053B0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60006F1")]
		[Cpp2IlInjected.Address(RVA = "0xC048E0", Offset = "0xC030E0", VA = "0x180C048E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002D2")]
	public bool CAAFCMMKJBK
	{
		[Cpp2IlInjected.Token(Token = "0x60006F2")]
		[Cpp2IlInjected.Address(RVA = "0x1569A40", Offset = "0x1568240", VA = "0x181569A40")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60006F3")]
		[Cpp2IlInjected.Address(RVA = "0x1569C20", Offset = "0x1568420", VA = "0x181569C20")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002D3")]
	public DDHBPMINLIM BADLMALNNLF
	{
		[Cpp2IlInjected.Token(Token = "0x60006F4")]
		[Cpp2IlInjected.Address(RVA = "0x9E9310", Offset = "0x9E7B10", VA = "0x1809E9310")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006F5")]
		[Cpp2IlInjected.Address(RVA = "0x9E9320", Offset = "0x9E7B20", VA = "0x1809E9320")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002D4")]
	[IgnoreDataMember]
	public string OPGLKEFOEEB
	{
		[Cpp2IlInjected.Token(Token = "0x60006F6")]
		[Cpp2IlInjected.Address(RVA = "0x9E9400", Offset = "0x9E7C00", VA = "0x1809E9400")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006F7")]
		[Cpp2IlInjected.Address(RVA = "0x9E92D0", Offset = "0x9E7AD0", VA = "0x1809E92D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002D5")]
	[IgnoreDataMember]
	public string CEPHECKGENM
	{
		[Cpp2IlInjected.Token(Token = "0x60006F8")]
		[Cpp2IlInjected.Address(RVA = "0xBCAEE0", Offset = "0xBC96E0", VA = "0x180BCAEE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006F9")]
		[Cpp2IlInjected.Address(RVA = "0x12B1DD0", Offset = "0x12B05D0", VA = "0x1812B1DD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002D6")]
	[IgnoreDataMember]
	public string FGFFBFFJPBL
	{
		[Cpp2IlInjected.Token(Token = "0x60006FA")]
		[Cpp2IlInjected.Address(RVA = "0x9E9390", Offset = "0x9E7B90", VA = "0x1809E9390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006FB")]
		[Cpp2IlInjected.Address(RVA = "0x9E9340", Offset = "0x9E7B40", VA = "0x1809E9340")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002D7")]
	[IgnoreDataMember]
	public FFEPNFKMCIE NECFENFNBHC
	{
		[Cpp2IlInjected.Token(Token = "0x60006FC")]
		[Cpp2IlInjected.Address(RVA = "0xCAB0D0", Offset = "0xCA98D0", VA = "0x180CAB0D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006FD")]
		[Cpp2IlInjected.Address(RVA = "0xE18B30", Offset = "0xE17330", VA = "0x180E18B30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002D8")]
	[IgnoreDataMember]
	public bool DNMMHCCHCGB
	{
		[Cpp2IlInjected.Token(Token = "0x60006FE")]
		[Cpp2IlInjected.Address(RVA = "0x706B0D0", Offset = "0x70698D0", VA = "0x18706B0D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006FF")]
	[Cpp2IlInjected.Address(RVA = "0x706AF40", Offset = "0x7069740", VA = "0x18706AF40", Slot = "4")]
	public void AOEGOOLELIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000700")]
	[Cpp2IlInjected.Address(RVA = "0x706B030", Offset = "0x7069830", VA = "0x18706B030")]
	public static AGCHINJCLHB GLHECLDALMF(int MLBCMOLHELH, string GLGOHIJMLFB, string LJANIECHELJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000701")]
	[Cpp2IlInjected.Address(RVA = "0x706B0F0", Offset = "0x70698F0", VA = "0x18706B0F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000702")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public AGCHINJCLHB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000110")]
[BDENCKNLAKO]
public class DDHBPMINLIM : HDINHDBEFHC
{
	[Cpp2IlInjected.Token(Token = "0x170002D9")]
	public List<int> BNHPIJJGCJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000703")]
		[Cpp2IlInjected.Address(RVA = "0x9DF710", Offset = "0x9DDF10", VA = "0x1809DF710")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000704")]
		[Cpp2IlInjected.Address(RVA = "0x9DF720", Offset = "0x9DDF20", VA = "0x1809DF720")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002DA")]
	public string LOFKFCJKLII
	{
		[Cpp2IlInjected.Token(Token = "0x6000705")]
		[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000706")]
		[Cpp2IlInjected.Address(RVA = "0x9DF700", Offset = "0x9DDF00", VA = "0x1809DF700")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002DB")]
	public BPKFHDMPKIN GNOAPCBCCNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000707")]
		[Cpp2IlInjected.Address(RVA = "0x9DF730", Offset = "0x9DDF30", VA = "0x1809DF730")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000708")]
		[Cpp2IlInjected.Address(RVA = "0x9DF740", Offset = "0x9DDF40", VA = "0x1809DF740")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000709")]
	[Cpp2IlInjected.Address(RVA = "0xE84E50", Offset = "0xE83650", VA = "0x180E84E50", Slot = "4")]
	public void AOEGOOLELIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600070A")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public DDHBPMINLIM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000111")]
public enum AGFFGAIPDAJ
{
	[Cpp2IlInjected.Token(Token = "0x4000519")]
	Gold,
	[Cpp2IlInjected.Token(Token = "0x400051A")]
	Platinum
}
[Cpp2IlInjected.Token(Token = "0x2000112")]
public enum IINBIBCMBLE
{
	[Cpp2IlInjected.Token(Token = "0x400051C")]
	Month,
	[Cpp2IlInjected.Token(Token = "0x400051D")]
	Year,
	[Cpp2IlInjected.Token(Token = "0x400051E")]
	ThreeMonth,
	[Cpp2IlInjected.Token(Token = "0x400051F")]
	SixMonth
}
[Cpp2IlInjected.Token(Token = "0x2000113")]
[BDENCKNLAKO]
public class BPKFHDMPKIN : HDINHDBEFHC
{
	[Cpp2IlInjected.Token(Token = "0x170002DC")]
	public AGFFGAIPDAJ NJNAHMBDHML
	{
		[Cpp2IlInjected.Token(Token = "0x600070B")]
		[Cpp2IlInjected.Address(RVA = "0x9DD1A0", Offset = "0x9DB9A0", VA = "0x1809DD1A0")]
		[CompilerGenerated]
		get
		{
			return default(AGFFGAIPDAJ);
		}
		[Cpp2IlInjected.Token(Token = "0x600070C")]
		[Cpp2IlInjected.Address(RVA = "0x9EBF60", Offset = "0x9EA760", VA = "0x1809EBF60")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002DD")]
	public IINBIBCMBLE KFFGNAPIBFB
	{
		[Cpp2IlInjected.Token(Token = "0x600070D")]
		[Cpp2IlInjected.Address(RVA = "0xB5FCA0", Offset = "0xB5E4A0", VA = "0x180B5FCA0")]
		[CompilerGenerated]
		get
		{
			return default(IINBIBCMBLE);
		}
		[Cpp2IlInjected.Token(Token = "0x600070E")]
		[Cpp2IlInjected.Address(RVA = "0xC57CC0", Offset = "0xC564C0", VA = "0x180C57CC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002DE")]
	public bool JPLKFJFPHHG
	{
		[Cpp2IlInjected.Token(Token = "0x600070F")]
		[Cpp2IlInjected.Address(RVA = "0xA85410", Offset = "0xA83C10", VA = "0x180A85410")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000710")]
		[Cpp2IlInjected.Address(RVA = "0x9E1B40", Offset = "0x9E0340", VA = "0x1809E1B40")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000711")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "4")]
	public void AOEGOOLELIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000712")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public BPKFHDMPKIN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000114")]
[BDENCKNLAKO]
public class MGPPPMEKKPP : HDINHDBEFHC
{
	[Cpp2IlInjected.Token(Token = "0x170002DF")]
	public string NOKDJFCNJII
	{
		[Cpp2IlInjected.Token(Token = "0x6000713")]
		[Cpp2IlInjected.Address(RVA = "0x9DF710", Offset = "0x9DDF10", VA = "0x1809DF710")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000714")]
		[Cpp2IlInjected.Address(RVA = "0x9DF720", Offset = "0x9DDF20", VA = "0x1809DF720")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002E0")]
	public JBIECEIKKIO? EJJGDDPBANP
	{
		[Cpp2IlInjected.Token(Token = "0x6000715")]
		[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000716")]
		[Cpp2IlInjected.Address(RVA = "0x9DF700", Offset = "0x9DDF00", VA = "0x1809DF700")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002E1")]
	public string? EKICPINCGBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000717")]
		[Cpp2IlInjected.Address(RVA = "0x9DF730", Offset = "0x9DDF30", VA = "0x1809DF730")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000718")]
		[Cpp2IlInjected.Address(RVA = "0x9DF740", Offset = "0x9DDF40", VA = "0x1809DF740")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002E2")]
	public string? GIINAILONFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000719")]
		[Cpp2IlInjected.Address(RVA = "0x9DF790", Offset = "0x9DDF90", VA = "0x1809DF790")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600071A")]
		[Cpp2IlInjected.Address(RVA = "0x9DF780", Offset = "0x9DDF80", VA = "0x1809DF780")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002E3")]
	public string? KDGBKFDFFAI
	{
		[Cpp2IlInjected.Token(Token = "0x600071B")]
		[Cpp2IlInjected.Address(RVA = "0x9DF770", Offset = "0x9DDF70", VA = "0x1809DF770")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600071C")]
		[Cpp2IlInjected.Address(RVA = "0x9DF750", Offset = "0x9DDF50", VA = "0x1809DF750")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002E4")]
	public string? ALOONECBGCN
	{
		[Cpp2IlInjected.Token(Token = "0x600071D")]
		[Cpp2IlInjected.Address(RVA = "0x9E0DB0", Offset = "0x9DF5B0", VA = "0x1809E0DB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600071E")]
		[Cpp2IlInjected.Address(RVA = "0x9E0DC0", Offset = "0x9DF5C0", VA = "0x1809E0DC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002E5")]
	public bool? JMMEMDFAKLG
	{
		[Cpp2IlInjected.Token(Token = "0x600071F")]
		[Cpp2IlInjected.Address(RVA = "0x706FD40", Offset = "0x706E540", VA = "0x18706FD40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000720")]
		[Cpp2IlInjected.Address(RVA = "0x706FD10", Offset = "0x706E510", VA = "0x18706FD10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000721")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "4")]
	public void AOEGOOLELIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000722")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public MGPPPMEKKPP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000115")]
[BDENCKNLAKO]
public class GBJMHJKIINJ : HDINHDBEFHC
{
	[Cpp2IlInjected.Token(Token = "0x170002E6")]
	public string GBDGOENPFFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000723")]
		[Cpp2IlInjected.Address(RVA = "0x9DF710", Offset = "0x9DDF10", VA = "0x1809DF710")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000724")]
		[Cpp2IlInjected.Address(RVA = "0x9DF720", Offset = "0x9DDF20", VA = "0x1809DF720")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002E7")]
	public JBIECEIKKIO? EJJGDDPBANP
	{
		[Cpp2IlInjected.Token(Token = "0x6000725")]
		[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000726")]
		[Cpp2IlInjected.Address(RVA = "0x9DF700", Offset = "0x9DDF00", VA = "0x1809DF700")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002E8")]
	public string? KDGBKFDFFAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000727")]
		[Cpp2IlInjected.Address(RVA = "0x9DF730", Offset = "0x9DDF30", VA = "0x1809DF730")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000728")]
		[Cpp2IlInjected.Address(RVA = "0x9DF740", Offset = "0x9DDF40", VA = "0x1809DF740")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000729")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "4")]
	public void AOEGOOLELIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600072A")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public GBJMHJKIINJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000116")]
[BDENCKNLAKO]
public class NILFPKGHGAD : HDINHDBEFHC
{
	[Cpp2IlInjected.Token(Token = "0x170002E9")]
	public string ALOONECBGCN
	{
		[Cpp2IlInjected.Token(Token = "0x600072B")]
		[Cpp2IlInjected.Address(RVA = "0x9DF710", Offset = "0x9DDF10", VA = "0x1809DF710")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600072C")]
		[Cpp2IlInjected.Address(RVA = "0x9DF720", Offset = "0x9DDF20", VA = "0x1809DF720")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002EA")]
	public string GIINAILONFN
	{
		[Cpp2IlInjected.Token(Token = "0x600072D")]
		[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600072E")]
		[Cpp2IlInjected.Address(RVA = "0x9DF700", Offset = "0x9DDF00", VA = "0x1809DF700")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002EB")]
	public string KCBOFCLNFPA
	{
		[Cpp2IlInjected.Token(Token = "0x600072F")]
		[Cpp2IlInjected.Address(RVA = "0x9DF730", Offset = "0x9DDF30", VA = "0x1809DF730")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000730")]
		[Cpp2IlInjected.Address(RVA = "0x9DF740", Offset = "0x9DDF40", VA = "0x1809DF740")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002EC")]
	public string? POLBINNHFEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000731")]
		[Cpp2IlInjected.Address(RVA = "0x9DF790", Offset = "0x9DDF90", VA = "0x1809DF790")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000732")]
		[Cpp2IlInjected.Address(RVA = "0x9DF780", Offset = "0x9DDF80", VA = "0x1809DF780")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002ED")]
	public float HAKKLICLOGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000733")]
		[Cpp2IlInjected.Address(RVA = "0xBCD620", Offset = "0xBCBE20", VA = "0x180BCD620")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000734")]
		[Cpp2IlInjected.Address(RVA = "0xEE6A80", Offset = "0xEE5280", VA = "0x180EE6A80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000735")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "4")]
	public void AOEGOOLELIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000736")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public NILFPKGHGAD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000117")]
[BDENCKNLAKO]
public class FONEBALKFNL : GNCNAHDBINF, HDINHDBEFHC
{
	[Cpp2IlInjected.Token(Token = "0x170002EE")]
	public string HHEGGAPMMCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000737")]
		[Cpp2IlInjected.Address(RVA = "0x9DF710", Offset = "0x9DDF10", VA = "0x1809DF710", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000738")]
		[Cpp2IlInjected.Address(RVA = "0x9DF720", Offset = "0x9DDF20", VA = "0x1809DF720")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002EF")]
	public string NNCJPANENGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000739")]
		[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600073A")]
		[Cpp2IlInjected.Address(RVA = "0x9DF700", Offset = "0x9DDF00", VA = "0x1809DF700")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600073B")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "6")]
	public void AOEGOOLELIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600073C")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public FONEBALKFNL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000118")]
[BDENCKNLAKO]
public class PLCNDDBPICB : HDINHDBEFHC
{
	[Cpp2IlInjected.Token(Token = "0x170002F0")]
	public long NFPIDGIHNLA
	{
		[Cpp2IlInjected.Token(Token = "0x600073D")]
		[Cpp2IlInjected.Address(RVA = "0x9DF710", Offset = "0x9DDF10", VA = "0x1809DF710")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600073E")]
		[Cpp2IlInjected.Address(RVA = "0xCDCAB0", Offset = "0xCDB2B0", VA = "0x180CDCAB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002F1")]
	public decimal EDPJLKNMLAK
	{
		[Cpp2IlInjected.Token(Token = "0x600073F")]
		[Cpp2IlInjected.Address(RVA = "0xBEBD90", Offset = "0xBEA590", VA = "0x180BEBD90")]
		[CompilerGenerated]
		get
		{
			return default(decimal);
		}
		[Cpp2IlInjected.Token(Token = "0x6000740")]
		[Cpp2IlInjected.Address(RVA = "0xDA40F0", Offset = "0xDA28F0", VA = "0x180DA40F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000741")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "4")]
	public void AOEGOOLELIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000742")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public PLCNDDBPICB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000119")]
[BDENCKNLAKO]
public class EJBIKHALGPJ : HDINHDBEFHC
{
	[Cpp2IlInjected.Token(Token = "0x170002F2")]
	public string HHEGGAPMMCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000743")]
		[Cpp2IlInjected.Address(RVA = "0x9DF710", Offset = "0x9DDF10", VA = "0x1809DF710")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000744")]
		[Cpp2IlInjected.Address(RVA = "0x9DF720", Offset = "0x9DDF20", VA = "0x1809DF720")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002F3")]
	public string EOCKCHNGEJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000745")]
		[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000746")]
		[Cpp2IlInjected.Address(RVA = "0x9DF700", Offset = "0x9DDF00", VA = "0x1809DF700")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000747")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public EJBIKHALGPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000748")]
	[Cpp2IlInjected.Address(RVA = "0x9E57C0", Offset = "0x9E3FC0", VA = "0x1809E57C0")]
	public EJBIKHALGPJ(string BFGLGAEMILF, string AGGLOCCOENC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000749")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "4")]
	public void AOEGOOLELIF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011A")]
[BDENCKNLAKO]
public class DGMHPANLAPE : HDINHDBEFHC
{
	[Cpp2IlInjected.Token(Token = "0x170002F4")]
	public string EOCKCHNGEJM
	{
		[Cpp2IlInjected.Token(Token = "0x600074A")]
		[Cpp2IlInjected.Address(RVA = "0x9DF710", Offset = "0x9DDF10", VA = "0x1809DF710")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600074B")]
		[Cpp2IlInjected.Address(RVA = "0x9DF720", Offset = "0x9DDF20", VA = "0x1809DF720")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600074C")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "4")]
	public void AOEGOOLELIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600074D")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public DGMHPANLAPE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011B")]
[BDENCKNLAKO]
public class PNOFJBMHGHI : HDINHDBEFHC
{
	[Cpp2IlInjected.Token(Token = "0x170002F5")]
	public string ALOONECBGCN
	{
		[Cpp2IlInjected.Token(Token = "0x600074E")]
		[Cpp2IlInjected.Address(RVA = "0x9DF710", Offset = "0x9DDF10", VA = "0x1809DF710")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600074F")]
		[Cpp2IlInjected.Address(RVA = "0x9DF720", Offset = "0x9DDF20", VA = "0x1809DF720")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002F6")]
	public string NOKDJFCNJII
	{
		[Cpp2IlInjected.Token(Token = "0x6000750")]
		[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000751")]
		[Cpp2IlInjected.Address(RVA = "0x9DF700", Offset = "0x9DDF00", VA = "0x1809DF700")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002F7")]
	public string? OABHEPHNFCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000752")]
		[Cpp2IlInjected.Address(RVA = "0x9DF730", Offset = "0x9DDF30", VA = "0x1809DF730")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000753")]
		[Cpp2IlInjected.Address(RVA = "0x9DF740", Offset = "0x9DDF40", VA = "0x1809DF740")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002F8")]
	public string? BAKAOLJFIDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000754")]
		[Cpp2IlInjected.Address(RVA = "0x9DF790", Offset = "0x9DDF90", VA = "0x1809DF790")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000755")]
		[Cpp2IlInjected.Address(RVA = "0x9DF780", Offset = "0x9DDF80", VA = "0x1809DF780")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000756")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "4")]
	public void AOEGOOLELIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000757")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public PNOFJBMHGHI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011C")]
[BDENCKNLAKO]
public class DKFFGKMKIOD : HDINHDBEFHC
{
	[Cpp2IlInjected.Token(Token = "0x170002F9")]
	public string LABGJIFHBPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000758")]
		[Cpp2IlInjected.Address(RVA = "0x9DF710", Offset = "0x9DDF10", VA = "0x1809DF710")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000759")]
		[Cpp2IlInjected.Address(RVA = "0x9DF720", Offset = "0x9DDF20", VA = "0x1809DF720")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600075A")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "4")]
	public void AOEGOOLELIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600075B")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public DKFFGKMKIOD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011D")]
[BDENCKNLAKO]
public class LPKMOGAJAME : HDINHDBEFHC
{
	[Cpp2IlInjected.Token(Token = "0x170002FA")]
	public int NGHJMEDCGPM
	{
		[Cpp2IlInjected.Token(Token = "0x600075C")]
		[Cpp2IlInjected.Address(RVA = "0x9DD1A0", Offset = "0x9DB9A0", VA = "0x1809DD1A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600075D")]
		[Cpp2IlInjected.Address(RVA = "0x9EBF60", Offset = "0x9EA760", VA = "0x1809EBF60")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002FB")]
	public string PALJBODIBGP
	{
		[Cpp2IlInjected.Token(Token = "0x600075E")]
		[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600075F")]
		[Cpp2IlInjected.Address(RVA = "0x9DF700", Offset = "0x9DDF00", VA = "0x1809DF700")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002FC")]
	public string? ACOJEEABMOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000760")]
		[Cpp2IlInjected.Address(RVA = "0x9DF730", Offset = "0x9DDF30", VA = "0x1809DF730")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000761")]
		[Cpp2IlInjected.Address(RVA = "0x9DF740", Offset = "0x9DDF40", VA = "0x1809DF740")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002FD")]
	public IReadOnlyList<int> HBKLAEHMMMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000762")]
		[Cpp2IlInjected.Address(RVA = "0x9DF790", Offset = "0x9DDF90", VA = "0x1809DF790")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000763")]
		[Cpp2IlInjected.Address(RVA = "0x9DF780", Offset = "0x9DDF80", VA = "0x1809DF780")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002FE")]
	public string? CFNKNIAKONE
	{
		[Cpp2IlInjected.Token(Token = "0x6000764")]
		[Cpp2IlInjected.Address(RVA = "0x9DF770", Offset = "0x9DDF70", VA = "0x1809DF770")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000765")]
		[Cpp2IlInjected.Address(RVA = "0x9DF750", Offset = "0x9DDF50", VA = "0x1809DF750")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000766")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "4")]
	public void AOEGOOLELIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000767")]
	[Cpp2IlInjected.Address(RVA = "0x7072980", Offset = "0x7071180", VA = "0x187072980")]
	public LPKMOGAJAME()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011E")]
[BDENCKNLAKO]
public class EGEFFNDLIIO : HDINHDBEFHC
{
	[Cpp2IlInjected.Token(Token = "0x170002FF")]
	public int NGHJMEDCGPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000768")]
		[Cpp2IlInjected.Address(RVA = "0x9DD1A0", Offset = "0x9DB9A0", VA = "0x1809DD1A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000769")]
		[Cpp2IlInjected.Address(RVA = "0x9EBF60", Offset = "0x9EA760", VA = "0x1809EBF60")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000300")]
	public Guid? HNPGENHBKNE
	{
		[Cpp2IlInjected.Token(Token = "0x600076A")]
		[Cpp2IlInjected.Address(RVA = "0x213ECA0", Offset = "0x213D4A0", VA = "0x18213ECA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600076B")]
		[Cpp2IlInjected.Address(RVA = "0x213E980", Offset = "0x213D180", VA = "0x18213E980")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000301")]
	public string PALJBODIBGP
	{
		[Cpp2IlInjected.Token(Token = "0x600076C")]
		[Cpp2IlInjected.Address(RVA = "0x9DF790", Offset = "0x9DDF90", VA = "0x1809DF790")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600076D")]
		[Cpp2IlInjected.Address(RVA = "0x9DF780", Offset = "0x9DDF80", VA = "0x1809DF780")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000302")]
	public List<LPKMOGAJAME> GKCGJLMIMJG
	{
		[Cpp2IlInjected.Token(Token = "0x600076E")]
		[Cpp2IlInjected.Address(RVA = "0x9DF770", Offset = "0x9DDF70", VA = "0x1809DF770")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600076F")]
		[Cpp2IlInjected.Address(RVA = "0x9DF750", Offset = "0x9DDF50", VA = "0x1809DF750")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000303")]
	public List<LPKMOGAJAME> HADIHDIPJIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000770")]
		[Cpp2IlInjected.Address(RVA = "0x9E0DB0", Offset = "0x9DF5B0", VA = "0x1809E0DB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000771")]
		[Cpp2IlInjected.Address(RVA = "0x9E0DC0", Offset = "0x9DF5C0", VA = "0x1809E0DC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000304")]
	public string? ACOJEEABMOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000772")]
		[Cpp2IlInjected.Address(RVA = "0x9E2460", Offset = "0x9E0C60", VA = "0x1809E2460")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000773")]
		[Cpp2IlInjected.Address(RVA = "0x9E0DA0", Offset = "0x9DF5A0", VA = "0x1809E0DA0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000305")]
	public string? CFNKNIAKONE
	{
		[Cpp2IlInjected.Token(Token = "0x6000774")]
		[Cpp2IlInjected.Address(RVA = "0x9E0DD0", Offset = "0x9DF5D0", VA = "0x1809E0DD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000775")]
		[Cpp2IlInjected.Address(RVA = "0x9E0BB0", Offset = "0x9DF3B0", VA = "0x1809E0BB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000306")]
	public string? DMJJHFPIDGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000776")]
		[Cpp2IlInjected.Address(RVA = "0x9DD200", Offset = "0x9DBA00", VA = "0x1809DD200")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000777")]
		[Cpp2IlInjected.Address(RVA = "0x9DD240", Offset = "0x9DBA40", VA = "0x1809DD240")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000778")]
	[Cpp2IlInjected.Address(RVA = "0x706DF10", Offset = "0x706C710", VA = "0x18706DF10", Slot = "4")]
	public void AOEGOOLELIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000779")]
	[Cpp2IlInjected.Address(RVA = "0x706DF40", Offset = "0x706C740", VA = "0x18706DF40")]
	public EGEFFNDLIIO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011F")]
[BDENCKNLAKO]
public class EEENDNLMMLO : HDINHDBEFHC
{
	[Cpp2IlInjected.Token(Token = "0x17000307")]
	public string ACOJEEABMOC
	{
		[Cpp2IlInjected.Token(Token = "0x600077A")]
		[Cpp2IlInjected.Address(RVA = "0x9DF710", Offset = "0x9DDF10", VA = "0x1809DF710")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600077B")]
		[Cpp2IlInjected.Address(RVA = "0x9DF720", Offset = "0x9DDF20", VA = "0x1809DF720")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000308")]
	public EGEFFNDLIIO GKCGJLMIMJG
	{
		[Cpp2IlInjected.Token(Token = "0x600077C")]
		[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600077D")]
		[Cpp2IlInjected.Address(RVA = "0x9DF700", Offset = "0x9DDF00", VA = "0x1809DF700")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000309")]
	public EGEFFNDLIIO HADIHDIPJIG
	{
		[Cpp2IlInjected.Token(Token = "0x600077E")]
		[Cpp2IlInjected.Address(RVA = "0x9DF730", Offset = "0x9DDF30", VA = "0x1809DF730")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600077F")]
		[Cpp2IlInjected.Address(RVA = "0x9DF740", Offset = "0x9DDF40", VA = "0x1809DF740")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700030A")]
	public string? DMJJHFPIDGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000780")]
		[Cpp2IlInjected.Address(RVA = "0x9DF790", Offset = "0x9DDF90", VA = "0x1809DF790")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000781")]
		[Cpp2IlInjected.Address(RVA = "0x9DF780", Offset = "0x9DDF80", VA = "0x1809DF780")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000782")]
	[Cpp2IlInjected.Address(RVA = "0x706DEB0", Offset = "0x706C6B0", VA = "0x18706DEB0", Slot = "5")]
	public virtual void AOEGOOLELIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000783")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public EEENDNLMMLO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000120")]
[BDENCKNLAKO]
public class PFDGIFEKAAB : HDINHDBEFHC
{
	[Cpp2IlInjected.Token(Token = "0x1700030B")]
	public string ACOJEEABMOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000784")]
		[Cpp2IlInjected.Address(RVA = "0x9DF710", Offset = "0x9DDF10", VA = "0x1809DF710")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000785")]
		[Cpp2IlInjected.Address(RVA = "0x9DF720", Offset = "0x9DDF20", VA = "0x1809DF720")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700030C")]
	public IReadOnlyList<EGEFFNDLIIO> GANLEEKFEDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000786")]
		[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000787")]
		[Cpp2IlInjected.Address(RVA = "0x9DF700", Offset = "0x9DDF00", VA = "0x1809DF700")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700030D")]
	public IReadOnlyList<EEENDNLMMLO> DKNNFMNKDKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000788")]
		[Cpp2IlInjected.Address(RVA = "0x9DF730", Offset = "0x9DDF30", VA = "0x1809DF730")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000789")]
		[Cpp2IlInjected.Address(RVA = "0x9DF740", Offset = "0x9DDF40", VA = "0x1809DF740")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700030E")]
	public IReadOnlyList<PFDGIFEKAAB> FBGNNAEMCAE
	{
		[Cpp2IlInjected.Token(Token = "0x600078A")]
		[Cpp2IlInjected.Address(RVA = "0x9DF790", Offset = "0x9DDF90", VA = "0x1809DF790")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600078B")]
		[Cpp2IlInjected.Address(RVA = "0x9DF780", Offset = "0x9DDF80", VA = "0x1809DF780")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700030F")]
	public string? DMJJHFPIDGG
	{
		[Cpp2IlInjected.Token(Token = "0x600078C")]
		[Cpp2IlInjected.Address(RVA = "0x9DF770", Offset = "0x9DDF70", VA = "0x1809DF770")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600078D")]
		[Cpp2IlInjected.Address(RVA = "0x9DF750", Offset = "0x9DDF50", VA = "0x1809DF750")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600078E")]
	[Cpp2IlInjected.Address(RVA = "0x7074210", Offset = "0x7072A10", VA = "0x187074210", Slot = "4")]
	public void AOEGOOLELIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600078F")]
	[Cpp2IlInjected.Address(RVA = "0x7074240", Offset = "0x7072A40", VA = "0x187074240")]
	public PFDGIFEKAAB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000121")]
[BDENCKNLAKO]
public class JBIECEIKKIO : HDINHDBEFHC
{
	[Cpp2IlInjected.Token(Token = "0x17000310")]
	public string ACOJEEABMOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000790")]
		[Cpp2IlInjected.Address(RVA = "0x9DF710", Offset = "0x9DDF10", VA = "0x1809DF710")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000791")]
		[Cpp2IlInjected.Address(RVA = "0x9DF720", Offset = "0x9DDF20", VA = "0x1809DF720")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000311")]
	public string PALJBODIBGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000792")]
		[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000793")]
		[Cpp2IlInjected.Address(RVA = "0x9DF700", Offset = "0x9DDF00", VA = "0x1809DF700")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000312")]
	public List<JBIECEIKKIO>? MHBEANDDIPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000794")]
		[Cpp2IlInjected.Address(RVA = "0x9DF730", Offset = "0x9DDF30", VA = "0x1809DF730")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000795")]
		[Cpp2IlInjected.Address(RVA = "0x9DF740", Offset = "0x9DDF40", VA = "0x1809DF740")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000796")]
	[Cpp2IlInjected.Address(RVA = "0x7071360", Offset = "0x706FB60", VA = "0x187071360", Slot = "4")]
	public void AOEGOOLELIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000797")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public JBIECEIKKIO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000122")]
[BDENCKNLAKO]
public class AOKCPCGCMDF : HDINHDBEFHC
{
	[Cpp2IlInjected.Token(Token = "0x17000313")]
	public string NGHJMEDCGPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000798")]
		[Cpp2IlInjected.Address(RVA = "0x9DF710", Offset = "0x9DDF10", VA = "0x1809DF710")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000799")]
		[Cpp2IlInjected.Address(RVA = "0x9DF720", Offset = "0x9DDF20", VA = "0x1809DF720")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000314")]
	public PFDGIFEKAAB CAGIBPCAKLC
	{
		[Cpp2IlInjected.Token(Token = "0x600079A")]
		[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600079B")]
		[Cpp2IlInjected.Address(RVA = "0x9DF700", Offset = "0x9DDF00", VA = "0x1809DF700")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000315")]
	public JBIECEIKKIO? EJJGDDPBANP
	{
		[Cpp2IlInjected.Token(Token = "0x600079C")]
		[Cpp2IlInjected.Address(RVA = "0x9DF730", Offset = "0x9DDF30", VA = "0x1809DF730")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600079D")]
		[Cpp2IlInjected.Address(RVA = "0x9DF740", Offset = "0x9DDF40", VA = "0x1809DF740")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000316")]
	public string? GBDGOENPFFH
	{
		[Cpp2IlInjected.Token(Token = "0x600079E")]
		[Cpp2IlInjected.Address(RVA = "0x9DF790", Offset = "0x9DDF90", VA = "0x1809DF790")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600079F")]
		[Cpp2IlInjected.Address(RVA = "0x9DF780", Offset = "0x9DDF80", VA = "0x1809DF780")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007A0")]
	[Cpp2IlInjected.Address(RVA = "0x706B3E0", Offset = "0x7069BE0", VA = "0x18706B3E0", Slot = "4")]
	public void AOEGOOLELIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007A1")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public AOKCPCGCMDF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000123")]
[BDENCKNLAKO]
public class IEOCOGBHABP : HDINHDBEFHC
{
	[Cpp2IlInjected.Token(Token = "0x17000317")]
	public MLGCIODNMCL<AOKCPCGCMDF> JBGJDBLIIKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60007A2")]
		[Cpp2IlInjected.Address(RVA = "0x9DF710", Offset = "0x9DDF10", VA = "0x1809DF710")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007A3")]
		[Cpp2IlInjected.Address(RVA = "0x9DF720", Offset = "0x9DDF20", VA = "0x1809DF720")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000318")]
	public decimal MHNOENJGNDP
	{
		[Cpp2IlInjected.Token(Token = "0x60007A4")]
		[Cpp2IlInjected.Address(RVA = "0xBEBD90", Offset = "0xBEA590", VA = "0x180BEBD90")]
		[CompilerGenerated]
		get
		{
			return default(decimal);
		}
		[Cpp2IlInjected.Token(Token = "0x60007A5")]
		[Cpp2IlInjected.Address(RVA = "0xDA40F0", Offset = "0xDA28F0", VA = "0x180DA40F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007A6")]
	[Cpp2IlInjected.Address(RVA = "0x6E2E030", Offset = "0x6E2C830", VA = "0x186E2E030", Slot = "4")]
	public void AOEGOOLELIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007A7")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public IEOCOGBHABP()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000124")]
public class AICHEIEOLIK
{
	[Cpp2IlInjected.Token(Token = "0x60007A8")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public AICHEIEOLIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007A9")]
	[Cpp2IlInjected.Address(RVA = "0x6D87FB0", Offset = "0x6D867B0", VA = "0x186D87FB0")]
	public static string GBBADNGHMLI(byte[] LAHNFBAFDMD, byte[] BDHNNIJDOJN)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000125")]
	public class __BB_OBFUSCATOR_VERSION_3_10_0
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
