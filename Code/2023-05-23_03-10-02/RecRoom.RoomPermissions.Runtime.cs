using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using JetBrains.Annotations;
using Microsoft.CodeAnalysis;
using RecRoom.NoEngine.Common;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80DE80", VA = "0x18080EA80")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6840D80", Offset = "0x6840180", VA = "0x186840D80")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x881BC0", Offset = "0x880FC0", VA = "0x180881BC0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xD72FB0", Offset = "0xD723B0", VA = "0x180D72FB0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum JHKBLPJCLEP
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Vote,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	Instant,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	Off
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface MBPHKAJDKLB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	HBFOPCGPIMB MLGBCEBFIIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	IEnumerable<PNDNHJDGAML> KGFOFPCFIPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event MOAEMPDHDKP LCILLFDBBEM;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IReadOnlyList<PNDNHJDGAML> OFMHBAFGCCH(bool PELDGDEEOJC = false);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	PNDNHJDGAML NLGIDLBCALN(CFAHFELOIOE HLFEEOEAOAI);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool PCILIIFOIIH(CFAHFELOIOE HLFEEOEAOAI);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IReadOnlyList<PNDNHJDGAML> GHBMIIOBLIP(CFAHFELOIOE HLFEEOEAOAI, bool MMNFJDFPHDA = false);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool HPEPPKKBIAL(CFAHFELOIOE CAABNMALHPC, CJPJAKBBEBK HAEFIPKIGJM);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "9")]
	PNDNHJDGAML EAKIOAKDEBF(CJPJAKBBEBK HAEFIPKIGJM);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool FBJJLCBCKMO<T>(CJPJAKBBEBK HAEFIPKIGJM, GHDKNDLHOKN HJPMJJKGAIN, bool DIEBPEOGLIN, T GNIDPCMALKM) where T : notnull;
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface NOELOMDPBOG
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task FMKGJAOBNKC(FMGDIDICPAO IHPHNJFCMAH, CancellationToken EMJFDFLJKFG);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ACIAPFHDIAK(ref FMGDIDICPAO IHPHNJFCMAH);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface KEMAFLNBPNL
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool DBOKFKGLLBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool OLCNFHJOCFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool PEFCHMGODPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool LOGCKBLCINA
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool IAPEFFFBPLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool JPFGANACBCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class EIGKKGAILDE
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static readonly IReadOnlyList<CJPJAKBBEBK> JMAPJEGMDPM;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x683BC50", Offset = "0x683B050", VA = "0x18683BC50")]
	public static bool GPPGMNMENDJ(this CFAHFELOIOE LCFBOGPDINO, CJPJAKBBEBK HAEFIPKIGJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x683BBD0", Offset = "0x683AFD0", VA = "0x18683BBD0")]
	public static bool ADIMBMOONMI(this CFAHFELOIOE LCFBOGPDINO, CJPJAKBBEBK HAEFIPKIGJM, ODGNOLKLAJE GGNIPOAOGKN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal class PMGMNAMMBIM : HAAJHEIMKDE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly MBPHKAJDKLB KIPCKMNHALN;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x855900", Offset = "0x854D00", VA = "0x180855900")]
	[RecRoom.NoEngine.Common.Preserve]
	public PMGMNAMMBIM([KFMNGACPMHN(null)] MBPHKAJDKLB KIOCIPDGKOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6841450", Offset = "0x6840850", VA = "0x186841450")]
	private static JOMMLBDHDAM? PCOGMCLCIDJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6840E20", Offset = "0x6840220", VA = "0x186840E20", Slot = "4")]
	public bool JIAEJNIDKEC(CFAHFELOIOE JNMBJOBHOKI, CFAHFELOIOE PHMKALJPFLM, IEnumerable<CFAHFELOIOE> LEBGNOHGDOD, out JHKBLPJCLEP LCILDMKJNEN, out EGCPPOGDNCG MFJPHENNNMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6840F30", Offset = "0x6840330", VA = "0x186840F30")]
	internal bool LFIIGKBALMJ(CFAHFELOIOE JNMBJOBHOKI, CFAHFELOIOE PHMKALJPFLM, IEnumerable<CFAHFELOIOE> LEBGNOHGDOD, ODGNOLKLAJE GGNIPOAOGKN, JOMMLBDHDAM? GFKBJHKDMGA, out JHKBLPJCLEP LCILDMKJNEN, out EGCPPOGDNCG MFJPHENNNMO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface LPCFKPHEEOC<TPermission> where TPermission : notnull
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	string GDLPGHHGBPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event global::NNDKHMJBMFN<TPermission> HDELLIDBPMF;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public delegate void NNDKHMJBMFN<TPermission>(TPermission HJPMJJKGAIN);
[Cpp2IlInjected.Token(Token = "0x200000E")]
public delegate void MOAEMPDHDKP(CFAHFELOIOE HLFEEOEAOAI);
[Cpp2IlInjected.Token(Token = "0x200000F")]
internal class FFBDJMAMLFG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public readonly string GIMPGDCDJIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public readonly Type DFEMHFJKJHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public readonly ACEGAENHGGM ALNLEOMKGOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public readonly GHDKNDLHOKN EPGGNINKJED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public CMCDFPBAOHC KLMABFEELDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public EAELABDGEMP PNBNMHMBEMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public PBHCLMCAMNJ LDGEKLHDBGA;

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x683C000", Offset = "0x683B400", VA = "0x18683C000")]
	public FFBDJMAMLFG(Type PEIBFNIKGHN, string NFILGCJMNAA, GHDKNDLHOKN HJPMJJKGAIN, CMCDFPBAOHC IDFIAJKFGLE, EAELABDGEMP ACDIPKBMJJM, PBHCLMCAMNJ ENHLPFENAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x683BF10", Offset = "0x683B310", VA = "0x18683BF10")]
	public object DFAEFOPAADG(object? CCJMBGJFGLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2FB75F0", Offset = "0x2FB69F0", VA = "0x182FB75F0")]
	public void GJJMOJPKHIK<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x683BF50", Offset = "0x683B350", VA = "0x18683BF50")]
	public void GJJMOJPKHIK(Type GFKIJBMDABK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal class BFGNLGFPLAD<T> : FFBDJMAMLFG where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	internal delegate string NONFMGJINMA(T EOEKGHMNIDN);

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	internal delegate T AHNCEBGKPDD(string? GKEBIJBAFBN, T BICCJELLHLH);

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class OEIFJOFPJFH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public NONFMGJINMA serializeRecNetString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public AHNCEBGKPDD parseRecNetString;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x1939780", Offset = "0x1938B80", VA = "0x181939780")]
		public OEIFJOFPJFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x3F2C070", Offset = "0x3F2B470", VA = "0x183F2C070")]
		internal string BKBEBDHNKAF(object? v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x3F2C0E0", Offset = "0x3F2B4E0", VA = "0x183F2C0E0")]
		internal object KPJICHJNLGN(string? s, object d)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x36BDE70", Offset = "0x36BD270", VA = "0x1836BDE70")]
	public BFGNLGFPLAD(GHDKNDLHOKN HJPMJJKGAIN, string NFILGCJMNAA, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7B64F0", Offset = "0x7B58F0")] global::BFGNLGFPLAD<T>.NONFMGJINMA IDFIAJKFGLE, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7B6550", Offset = "0x7B5950")] global::BFGNLGFPLAD<T>.AHNCEBGKPDD ACDIPKBMJJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x36BD770", Offset = "0x36BCB70", VA = "0x1836BD770")]
	private static object? INEKOHCFCOE([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7B65B0", Offset = "0x7B59B0")] global::BFGNLGFPLAD<T?>.AHNCEBGKPDD? ACDIPKBMJJM, string? GKEBIJBAFBN, object? BICCJELLHLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x36BD130", Offset = "0x36BC530", VA = "0x1836BD130")]
	private static string AKAHDAOKFEM([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7B6610", Offset = "0x7B5A10")] global::BFGNLGFPLAD<T>.NONFMGJINMA CEHLCGGKDII, object? EOEKGHMNIDN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface ECGHPDBPEDH
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	CFAHFELOIOE CDIOAOOKCFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	LJFFMMDLLMI OILNMAIHHGF
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	ODGNOLKLAJE FCCEFGHDMBK
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action<INCFDFDJKDD> HPPKDIDAPGK;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action APOIKCDGGLO;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "4")]
	CJPJAKBBEBK EGCBDMNMGGF(CFAHFELOIOE HLFEEOEAOAI);

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<INCFDFDJKDD> GIIEAMGINPI(CancellationToken EMJFDFLJKFG);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task NJILMBLKJGD(long MEFEJANAPKD, long KKEHNOMAPGJ, IReadOnlyList<CBGAALBCCLJ> OIAMFCLEAAB);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IEnumerable<CFAHFELOIOE> NJKCODOEPKP();
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class GEONDPCNADB
{
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x683C3C0", Offset = "0x683B7C0", VA = "0x18683C3C0")]
	public static CJPJAKBBEBK MGAJKHENEFL(this ECGHPDBPEDH DEKKJJMPPGF)
	{
		return default(CJPJAKBBEBK);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
internal class NMENJMIAGGE : PNDNHJDGAML, IJIIBJIAFFF, KEMAFLNBPNL, global::LPCFKPHEEOC<GHDKNDLHOKN>
{
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	internal static readonly LNACMPLFAIJ OEJHIENEFHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	internal readonly BEJOIMPEAAI NJCKLMEFNCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private string? CDHDAEAKAFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private string? DJEBAOABJKG;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private bool KNNFCJIEAKA
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x683EBC0", Offset = "0x683DFC0", VA = "0x18683EBC0", Slot = "23")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	private bool MDPEJNNIBAE
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x683EC60", Offset = "0x683E060", VA = "0x18683EC60", Slot = "22")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	private bool MPJCOBJBPKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x683DF00", Offset = "0x683D300", VA = "0x18683DF00", Slot = "21")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	private bool DIPPOBAJGLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x683E2E0", Offset = "0x683D6E0", VA = "0x18683E2E0", Slot = "24")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	private bool GHNDMIOPFLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x683EA00", Offset = "0x683DE00", VA = "0x18683EA00", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	private bool FOLAOPHPDMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x683DF50", Offset = "0x683D350", VA = "0x18683DF50", Slot = "25")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public CJPJAKBBEBK HCKKOHFOFKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x90D9A0", Offset = "0x90CDA0", VA = "0x18090D9A0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(CJPJAKBBEBK);
		}
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x92ED50", Offset = "0x92E150", VA = "0x18092ED50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public string GDLPGHHGBPF
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x683E770", Offset = "0x683DB70", VA = "0x18683E770", Slot = "29")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x683DFF0", Offset = "0x683D3F0", VA = "0x18683DFF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public string ABHLCCIDDCN
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x683E770", Offset = "0x683DB70", VA = "0x18683E770", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool OFLDDIODMAF
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0xA39BA0", Offset = "0xA38FA0", VA = "0x180A39BA0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xC62CC0", Offset = "0xC620C0", VA = "0x180C62CC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool ENGKEIDBLMI
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x683EAF0", Offset = "0x683DEF0", VA = "0x18683EAF0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public JHKBLPJCLEP IDHNABKGGEC
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x683F9B0", Offset = "0x683EDB0", VA = "0x18683F9B0", Slot = "20")]
		get
		{
			return default(JHKBLPJCLEP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool KHHOJELGPKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x683E040", Offset = "0x683D440", VA = "0x18683E040", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public bool EDNJDCPPGNF
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x683FA50", Offset = "0x683EE50", VA = "0x18683FA50", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public bool IBMEHNAHDHH
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x683EAA0", Offset = "0x683DEA0", VA = "0x18683EAA0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public bool FBHPNGFBOHC
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x683E720", Offset = "0x683DB20", VA = "0x18683E720", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public bool KNIFIFLHDNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x683F960", Offset = "0x683ED60", VA = "0x18683F960", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool KDGIEPKKKBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x683EA50", Offset = "0x683DE50", VA = "0x18683EA50", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool BEFOCLLNFPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x683E270", Offset = "0x683D670", VA = "0x18683E270", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool NFKDPAIPEKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x683E6D0", Offset = "0x683DAD0", VA = "0x18683E6D0", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public IReadOnlyList<string> IKLIFLLKBGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x683FE10", Offset = "0x683F210", VA = "0x18683FE10", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public bool ILCJEHCHCIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x683EBC0", Offset = "0x683DFC0", VA = "0x18683EBC0", Slot = "30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public bool HOAONCAFFFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x683EA00", Offset = "0x683DE00", VA = "0x18683EA00", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public bool GFFMHDMINGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x683EC60", Offset = "0x683E060", VA = "0x18683EC60", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public bool IDFIPFCOMHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x683FA00", Offset = "0x683EE00", VA = "0x18683FA00", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public bool LANGLPMMFJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x683DFA0", Offset = "0x683D3A0", VA = "0x18683DFA0", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool KLPLKFAACMP
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x683DF00", Offset = "0x683D300", VA = "0x18683DF00", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool CEFEJDFAJEN
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x683EC10", Offset = "0x683E010", VA = "0x18683EC10", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool ABHCMDHCGGG
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x683E2E0", Offset = "0x683D6E0", VA = "0x18683E2E0", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool BPBLANKBGML
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x683DF50", Offset = "0x683D350", VA = "0x18683DF50", Slot = "35")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event global::NNDKHMJBMFN<GHDKNDLHOKN> HDELLIDBPMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x683E090", Offset = "0x683D490", VA = "0x18683E090", Slot = "27")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x683F8C0", Offset = "0x683ECC0", VA = "0x18683F8C0", Slot = "28")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x291D950", Offset = "0x291CD50", VA = "0x18291D950", Slot = "6")]
	public (bool, T?) FLKOJDHCPPJ<T>(GHDKNDLHOKN HJPMJJKGAIN) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x291D910", Offset = "0x291CD10", VA = "0x18291D910")]
	public NMENJMIAGGE AIPOAFJBGEL<T>(GHDKNDLHOKN HJPMJJKGAIN, bool DIEBPEOGLIN, T EOEKGHMNIDN) where T : notnull, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x683FF00", Offset = "0x683F300", VA = "0x18683FF00")]
	public NMENJMIAGGE(CJPJAKBBEBK HAEFIPKIGJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x683FEE0", Offset = "0x683F2E0", VA = "0x18683FEE0")]
	public NMENJMIAGGE(CJPJAKBBEBK HAEFIPKIGJM, [Optional] string? CDHDAEAKAFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6840080", Offset = "0x683F480", VA = "0x186840080")]
	public NMENJMIAGGE(NMENJMIAGGE MGKCCCOJHHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x683FF20", Offset = "0x683F320", VA = "0x18683FF20")]
	internal NMENJMIAGGE(CJPJAKBBEBK HOAMDAHGJOI, [Optional] string? CDHDAEAKAFM, [Optional] NMENJMIAGGE? MGKCCCOJHHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x683EB40", Offset = "0x683DF40", VA = "0x18683EB40")]
	public static ACEGAENHGGM JOMDPJFHAGO(GHDKNDLHOKN HJPMJJKGAIN)
	{
		return default(ACEGAENHGGM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x683E2C0", Offset = "0x683D6C0", VA = "0x18683E2C0")]
	public void CPDIDLELBLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x683FB80", Offset = "0x683EF80", VA = "0x18683FB80")]
	internal NMENJMIAGGE OPBCGGOGLLC(NMENJMIAGGE EMBKGALLPEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x683E330", Offset = "0x683D730", VA = "0x18683E330")]
	internal IReadOnlyCollection<GHDKNDLHOKN> EADENLHKLFK(NMENJMIAGGE MGKCCCOJHHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x683FAA0", Offset = "0x683EEA0", VA = "0x18683FAA0")]
	public bool ODELBJAPJOC(GHDKNDLHOKN HJPMJJKGAIN, bool DIEBPEOGLIN, string KNAIPKIEIEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x683DDF0", Offset = "0x683D1F0", VA = "0x18683DDF0")]
	public (bool, string) AEOFHKELABL(GHDKNDLHOKN HJPMJJKGAIN)
	{
		return default((bool, string));
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x683E1D0", Offset = "0x683D5D0", VA = "0x18683E1D0")]
	internal void BOIEEIPBJIG(GHDKNDLHOKN HJPMJJKGAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x683E7C0", Offset = "0x683DBC0", VA = "0x18683E7C0")]
	public LDGOPDGIJBL EPDEONOEJGG(Func<CJPJAKBBEBK, Guid> LCEBIENLJDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x683ECB0", Offset = "0x683E0B0", VA = "0x18683ECB0")]
	public void LKDBBKGKHHO(LDGOPDGIJBL CCGDJGCKNNA, Func<Guid, CJPJAKBBEBK> BODFJDOPMNF, [Optional] CJPJAKBBEBK? MHNBJAOEHPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x683E130", Offset = "0x683D530", VA = "0x18683E130")]
	[CompilerGenerated]
	private void BKOGINEPLLI(GHDKNDLHOKN ALPOJPCNOHD, KEABBPEHNCD AJFJGHJCPMD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface HAAJHEIMKDE
{
	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JIAEJNIDKEC(CFAHFELOIOE JNMBJOBHOKI, CFAHFELOIOE PHMKALJPFLM, IEnumerable<CFAHFELOIOE> LEBGNOHGDOD, out JHKBLPJCLEP LCILDMKJNEN, out EGCPPOGDNCG MFJPHENNNMO);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public enum EGCPPOGDNCG : byte
{
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	InsufficientPermission,
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	DisabledByRoom,
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	CantKickEventOrganizer
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface IJIIBJIAFFF
{
	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	bool ENGKEIDBLMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	bool KHHOJELGPKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	bool EDNJDCPPGNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	bool IBMEHNAHDHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	bool FBHPNGFBOHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	bool KNIFIFLHDNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	bool KDGIEPKKKBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	bool BEFOCLLNFPO
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	bool NFKDPAIPEKN
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	bool IDFIPFCOMHG
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	bool LANGLPMMFJI
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	bool CEFEJDFAJEN
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	IReadOnlyList<string> IKLIFLLKBGM
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	JHKBLPJCLEP IDHNABKGGEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface PNDNHJDGAML : IJIIBJIAFFF, KEMAFLNBPNL, global::LPCFKPHEEOC<GHDKNDLHOKN>
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	string ABHLCCIDDCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	CJPJAKBBEBK HCKKOHFOFKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(Slot = "2")]
	(bool, T?) FLKOJDHCPPJ<T>(GHDKNDLHOKN HJPMJJKGAIN) where T : new();
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal abstract class HJAHLEJGAAD
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public object? OOGPOFPCCBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x856480", Offset = "0x855880", VA = "0x180856480")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x87D040", Offset = "0x87C440", VA = "0x18087D040")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x855900", Offset = "0x854D00", VA = "0x180855900")]
	protected HJAHLEJGAAD(object? LBIIDJPACOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool BHKFGKHNKPG(object? EOEKGHMNIDN);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal class DHAMNGCGFJG<T> : HJAHLEJGAAD where T : notnull, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private T INOANLFLFCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly IEqualityComparer<T> BNHAJHCFHEM;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public T DEMEBAENMIP
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x90D9A0", Offset = "0x90CDA0", VA = "0x18090D9A0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x360A2A0", Offset = "0x36096A0", VA = "0x18360A2A0", Slot = "4")]
	public override bool BHKFGKHNKPG(object? EOEKGHMNIDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x360A850", Offset = "0x3609C50", VA = "0x18360A850")]
	public bool HCMBFOPEFDN(T PIDPOELMEHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x360AAD0", Offset = "0x3609ED0", VA = "0x18360AAD0")]
	public DHAMNGCGFJG(T BICCJELLHLH, IEqualityComparer<T> BNHAJHCFHEM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
internal static class KCMHNDHKEKK
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[Flags]
	public enum CCEDMGLHILL
	{
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		AG_EVERYONE = 0,
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		AG_CREATOR = 0x200000,
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		AG_COOWNER = 0x400000,
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		AG_HOST = 0x800000,
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		AG_MODERATOR = 0x1000000
	}

	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public static readonly Guid PCNGLPMKMBF;

	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public static readonly Guid BNKBGPNNDKH;

	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public static readonly Guid KOOJMFIKCKL;

	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public static readonly Guid IKGEKFDHHHP;

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public static readonly Guid NPPGIKHCKCA;

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private static readonly global::MACILFMEBMA<CJPJAKBBEBK, Guid> OLNBKLDLLMJ;

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	internal static IEnumerable<CJPJAKBBEBK> MGPDHHNHHBL
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x683C980", Offset = "0x683BD80", VA = "0x18683C980")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x683C8F0", Offset = "0x683BCF0", VA = "0x18683C8F0")]
	public static CJPJAKBBEBK HOHDPPFPPGM(Guid LKDOBHNFOAM)
	{
		return default(CJPJAKBBEBK);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x683C840", Offset = "0x683BC40", VA = "0x18683C840")]
	public static Guid FKBMJLHBKKC(CJPJAKBBEBK HAEFIPKIGJM)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x683C7A0", Offset = "0x683BBA0", VA = "0x18683C7A0")]
	public static bool ELMEHKDAKPH(CJPJAKBBEBK HAEFIPKIGJM, out Guid LKDOBHNFOAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x683CB20", Offset = "0x683BF20", VA = "0x18683CB20")]
	public static bool OFKCFCHHFLF(Guid LKDOBHNFOAM, out CJPJAKBBEBK HAEFIPKIGJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x683CAB0", Offset = "0x683BEB0", VA = "0x18683CAB0")]
	public static CJPJAKBBEBK MFJKPFOFIIC(CJPJAKBBEBK HAEFIPKIGJM)
	{
		return default(CJPJAKBBEBK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x683CA00", Offset = "0x683BE00", VA = "0x18683CA00")]
	public static CCEDMGLHILL MEMOJMLFCEH(CJPJAKBBEBK MABIGHNFEBF)
	{
		return default(CCEDMGLHILL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x683CAE0", Offset = "0x683BEE0", VA = "0x18683CAE0")]
	internal static CJPJAKBBEBK MHCJKGKLIPA(CCEDMGLHILL MNPOEDNEDCH)
	{
		return default(CJPJAKBBEBK);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal delegate string CMCDFPBAOHC(object? EOEKGHMNIDN);
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal delegate object EAELABDGEMP(string? GKEBIJBAFBN, [Optional] object BICCJELLHLH);
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal delegate HJAHLEJGAAD PBHCLMCAMNJ();
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal class LNACMPLFAIJ
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private class GADDAMNFLHG : IEqualityComparer<List<string>>
	{
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		internal static GADDAMNFLHG BGHJOACDLLH;

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x683C0C0", Offset = "0x683B4C0", VA = "0x18683C0C0", Slot = "4")]
		public bool Equals(List<string> MIKJHKLKLDH, List<string> EJBKGAHMBFP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x683C220", Offset = "0x683B620", VA = "0x18683C220", Slot = "5")]
		public int GetHashCode(List<string> GHHNOPFOGCC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public GADDAMNFLHG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	private class NPBBGJKHNPB : global::MKANDLFPGOA<JHKBLPJCLEP>
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x6840C40", Offset = "0x6840040", VA = "0x186840C40", Slot = "9")]
		public override string AKAHDAOKFEM(JHKBLPJCLEP FOODEAIIDGG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6840A50", Offset = "0x683FE50", VA = "0x186840A50", Slot = "10")]
		protected override bool AAFODHCAAOH(string FOODEAIIDGG, out JHKBLPJCLEP EOEKGHMNIDN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x6840D40", Offset = "0x6840140", VA = "0x186840D40")]
		public NPBBGJKHNPB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private static readonly GAILDAJOANH JFAGPCCLLGD;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static readonly NPBBGJKHNPB EEBEAAFAOKB;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static readonly List<FFBDJMAMLFG> HBJLLCLFNFP;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public IEnumerable<GHDKNDLHOKN> CGKHGNFMLHH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x856480", Offset = "0x855880", VA = "0x180856480")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public IReadOnlyDictionary<GHDKNDLHOKN, FFBDJMAMLFG> HPCBGJOJCPK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x8117E0", Offset = "0x810BE0", VA = "0x1808117E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x683DA80", Offset = "0x683CE80", VA = "0x18683DA80")]
	public LNACMPLFAIJ([Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7B66F0", Offset = "0x7B5AF0")] IList<FFBDJMAMLFG> LEFNIOCKBFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x683CE90", Offset = "0x683C290", VA = "0x18683CE90")]
	public FFBDJMAMLFG DMKCLMOBNNE(GHDKNDLHOKN HJPMJJKGAIN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class PPBMHJGNCLL : NOELOMDPBOG, MBPHKAJDKLB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class FNNHHOLEHAK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public NMENJMIAGGE newRole;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public FNNHHOLEHAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x683C090", Offset = "0x683B490", VA = "0x18683C090")]
		internal bool LJAIEDEOHJB(NMENJMIAGGE rc)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class OHDENMPGDFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public CJPJAKBBEBK roleTypeToUpdate;

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public OHDENMPGDFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x6840E10", Offset = "0x6840210", VA = "0x186840E10")]
		internal bool EDCGHPKGBEH(CJPJAKBBEBK r)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class AJMHGKLEHHH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public FMGDIDICPAO roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public PPBMHJGNCLL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private bool <isOffline>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private INCFDFDJKDD <tokenAndPermissionsDto>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private bool <hasRoomRoles>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private INCFDFDJKDD <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private bool <serverHasPermissions>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7B6C80", Offset = "0x7B6080")]
		private TaskAwaiter<INCFDFDJKDD> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public AJMHGKLEHHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x6839DC0", Offset = "0x68391C0", VA = "0x186839DC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class HONGOPIGLIB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public StringBuilder migrationMessageBuilder;

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public HONGOPIGLIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x683C6A0", Offset = "0x683BAA0", VA = "0x18683C6A0")]
		internal void PDCEBLKAACM(LDGOPDGIJBL r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x683C570", Offset = "0x683B970", VA = "0x18683C570")]
		internal void PBHCOIOACAD(LDGOPDGIJBL r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private struct DCLMGFMKDKK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public FMGDIDICPAO roomData;
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class HBDNAGAPDLP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7B6CE0", Offset = "0x7B60E0")]
		public Func<LDGOPDGIJBL, KEABBPEHNCD> dataFunc;

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public HBDNAGAPDLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x683C420", Offset = "0x683B820", VA = "0x18683C420")]
		internal void GIIOHIKBJDG(LDGOPDGIJBL r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x683C490", Offset = "0x683B890", VA = "0x18683C490")]
		internal void GKLCAJOMGKK(LDGOPDGIJBL r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x683C500", Offset = "0x683B900", VA = "0x18683C500")]
		internal void ODMKIAKGFKE(LDGOPDGIJBL r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class NLPBBONMIBM<T> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public PPBMHJGNCLL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public GHDKNDLHOKN rolePermission;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public CJPJAKBBEBK accountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public ACEGAENHGGM recNetPermissionType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public string serializedNewValue;

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x1939780", Offset = "0x1938B80", VA = "0x181939780")]
		public NLPBBONMIBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x3862DA0", Offset = "0x38621A0", VA = "0x183862DA0")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(<<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d))]
		internal void GPCCBOHKBHP()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private struct BJICLAHJPLF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public IReadOnlyList<CBGAALBCCLJ> newPermissionOverrides;
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class DCPFCHOHFFJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public ECGHPDBPEDH rolesDataProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public FMGDIDICPAO roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7B6E00", Offset = "0x7B6200")]
		public IReadOnlyDictionary<CJPJAKBBEBK, NMENJMIAGGE> defaultRoles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public IAFJNKBOOFK debugLogger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private StringBuilder <migrationLogBuilder>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7B6E60", Offset = "0x7B6260")]
		private List<CBGAALBCCLJ> <permissionsChangeBatch>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private IEnumerator<LDGOPDGIJBL> <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private LDGOPDGIJBL <roleData>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private CJPJAKBBEBK <roleAccountType>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private NMENJMIAGGE <role>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private IReadOnlyList<GHDKNDLHOKN> <modifiedPermissions>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private IEnumerator<GHDKNDLHOKN> <>s__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private GHDKNDLHOKN <permission>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private ACEGAENHGGM <recNetPermissionType>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7B6EC0", Offset = "0x7B62C0")]
		private (bool Overrides, string SerializedValue) <serializedData>5__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public DCPFCHOHFFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x683AC60", Offset = "0x683A060", VA = "0x18683AC60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly ECGHPDBPEDH DEKKJJMPPGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly NNDFMAJDBJP GMBDLBLBAPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly IAFJNKBOOFK OPKGOHKKPDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly Dictionary<int, NMENJMIAGGE> EEEGJMBKAFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	internal readonly Dictionary<CJPJAKBBEBK, NMENJMIAGGE> OIABEMBLHKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	internal readonly Dictionary<CJPJAKBBEBK, NMENJMIAGGE> POGDKOFDBOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	internal readonly List<NMENJMIAGGE> FMKMJECFHFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private bool NPOIDLJDCLK;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private static readonly GHDKNDLHOKN[] AHPPPDCDIFH;

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public HBFOPCGPIMB MLGBCEBFIIP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x8117E0", Offset = "0x810BE0", VA = "0x1808117E0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public IEnumerable<PNDNHJDGAML> KGFOFPCFIPC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x6843B40", Offset = "0x6842F40", VA = "0x186843B40", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event MOAEMPDHDKP LCILLFDBBEM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x6845FA0", Offset = "0x68453A0", VA = "0x186845FA0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x68457F0", Offset = "0x6844BF0", VA = "0x1868457F0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x6845890", Offset = "0x6844C90", VA = "0x186845890")]
	[HECCOHDEPAK(OEAABDENEKP.Room, JCKMLGOOEHJ.None)]
	private static void MEFILDPHPHB(HECDEIOAEPJ ODALLEOBHBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x6846B50", Offset = "0x6845F50", VA = "0x186846B50")]
	[UnityEngine.Scripting.Preserve]
	internal PPBMHJGNCLL([KFMNGACPMHN(null)] ECGHPDBPEDH AJOLOCOBKJJ, [KFMNGACPMHN(null)] NNDFMAJDBJP GDJFBAJJJOP, [KFMNGACPMHN(null)] IAFJNKBOOFK OPKGOHKKPDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x68435F0", Offset = "0x68429F0", VA = "0x1868435F0", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x68414A0", Offset = "0x68408A0", VA = "0x1868414A0")]
	private void AEGDCIEHMDK(IEnumerable<NMENJMIAGGE> GGAKLNODKJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x6846220", Offset = "0x6845620", VA = "0x186846220", Slot = "12")]
	public bool PCILIIFOIIH(CFAHFELOIOE HLFEEOEAOAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x6841FB0", Offset = "0x68413B0", VA = "0x186841FB0")]
	private void APOIKCDGGLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x6845660", Offset = "0x6844A60", VA = "0x186845660")]
	private void MBEKHMGLEGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x68461A0", Offset = "0x68455A0", VA = "0x1868461A0", Slot = "10")]
	public IReadOnlyList<PNDNHJDGAML> OFMHBAFGCCH(bool PELDGDEEOJC = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x6845E90", Offset = "0x6845290", VA = "0x186845E90", Slot = "11")]
	public PNDNHJDGAML NLGIDLBCALN(CFAHFELOIOE HLFEEOEAOAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x6845A50", Offset = "0x6844E50", VA = "0x186845A50")]
	private CJPJAKBBEBK MJNGGIHLDMC(CFAHFELOIOE HLFEEOEAOAI)
	{
		return default(CJPJAKBBEBK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x6843F90", Offset = "0x6843390", VA = "0x186843F90", Slot = "14")]
	public bool HPEPPKKBIAL(CFAHFELOIOE CAABNMALHPC, CJPJAKBBEBK HAEFIPKIGJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x6843700", Offset = "0x6842B00", VA = "0x186843700", Slot = "15")]
	public PNDNHJDGAML EAKIOAKDEBF(CJPJAKBBEBK HAEFIPKIGJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x6843BA0", Offset = "0x6842FA0", VA = "0x186843BA0")]
	private static bool HNLICABFBMH(PNGJGIKEFME HLNIKDOCGJJ, CJPJAKBBEBK HAEFIPKIGJM, out LDGOPDGIJBL? FKNPPMAAEHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x6844120", Offset = "0x6843520", VA = "0x186844120")]
	private static void ILEIDEINGBA(PNGJGIKEFME HLNIKDOCGJJ, Action<LDGOPDGIJBL> NCINJOHDNAM, CJPJAKBBEBK FIIFCHONJKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x6844220", Offset = "0x6843620", VA = "0x186844220")]
	private static void ILEIDEINGBA(PNGJGIKEFME HLNIKDOCGJJ, Action<LDGOPDGIJBL> NCINJOHDNAM, Predicate<CJPJAKBBEBK> IIDFDEEKMPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x6845E30", Offset = "0x6845230", VA = "0x186845E30")]
	private void NDMHFINLHLM(CFAHFELOIOE HLFEEOEAOAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x68437B0", Offset = "0x6842BB0", VA = "0x1868437B0", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(AJMHGKLEHHH))]
	public Task FMKGJAOBNKC([CanBeNull] FMGDIDICPAO IHPHNJFCMAH, CancellationToken EMJFDFLJKFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
	public void ACIAPFHDIAK(ref FMGDIDICPAO IHPHNJFCMAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x6843370", Offset = "0x6842770", VA = "0x186843370")]
	private void DGKPGDOCAAF(PNGJGIKEFME GGBEBFPMNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x6844C00", Offset = "0x6844000", VA = "0x186844C00")]
	internal static string KJGNBDIAMMO(ECGHPDBPEDH DEKKJJMPPGF, FMGDIDICPAO IHPHNJFCMAH, IReadOnlyDictionary<CJPJAKBBEBK, NMENJMIAGGE> OIABEMBLHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x6842460", Offset = "0x6841860", VA = "0x186842460")]
	private static void CPJGNIDLNCO(FMGDIDICPAO IHPHNJFCMAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x6841C90", Offset = "0x6841090", VA = "0x186841C90")]
	private static void AOBAEFJODKD(PNGJGIKEFME OPMOMLMHAMF, IReadOnlyDictionary<CJPJAKBBEBK, NMENJMIAGGE> OIABEMBLHKK, StringBuilder CDEINPFGNGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x6846040", Offset = "0x6845440", VA = "0x186846040")]
	private static bool OFHDJABEMIC(string BONOGFBDMOF, out Guid DENPKJCMDAG, out CJPJAKBBEBK HAEFIPKIGJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x6844420", Offset = "0x6843820", VA = "0x186844420")]
	private static void JGOHOGJCHED(FMGDIDICPAO IHPHNJFCMAH, StringBuilder CDEINPFGNGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x24E00D0", Offset = "0x24DF4D0", VA = "0x1824E00D0", Slot = "16")]
	public bool FBJJLCBCKMO<T>(CJPJAKBBEBK HAEFIPKIGJM, GHDKNDLHOKN HJPMJJKGAIN, bool DIEBPEOGLIN, T GNIDPCMALKM) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x6844A40", Offset = "0x6843E40", VA = "0x186844A40")]
	private void JPHOKGLAKKG(CJPJAKBBEBK HAEFIPKIGJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x68422A0", Offset = "0x68416A0", VA = "0x1868422A0")]
	private bool BPDNEHPNKKD(CFAHFELOIOE HLFEEOEAOAI, CJPJAKBBEBK HAEFIPKIGJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x6845B10", Offset = "0x6844F10", VA = "0x186845B10")]
	internal NMENJMIAGGE NBDNBEHONBO(CFAHFELOIOE HLFEEOEAOAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x6843B90", Offset = "0x6842F90", VA = "0x186843B90", Slot = "13")]
	public IReadOnlyList<PNDNHJDGAML> GHBMIIOBLIP(CFAHFELOIOE HLFEEOEAOAI, bool MMNFJDFPHDA = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x6843920", Offset = "0x6842D20", VA = "0x186843920")]
	internal IReadOnlyList<NMENJMIAGGE> FMLPFOPPLOD(CFAHFELOIOE HLFEEOEAOAI, bool MMNFJDFPHDA = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x6844F20", Offset = "0x6844320", VA = "0x186844F20")]
	private void KKJILNGGHON(INCFDFDJKDD GELFJBIKNFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x68462F0", Offset = "0x68456F0", VA = "0x1868462F0")]
	private static bool PIKMGOILBMF(NMENJMIAGGE JIHFHNMEOFK, IReadOnlyDictionary<CJPJAKBBEBK, NMENJMIAGGE> OIABEMBLHKK, out IReadOnlyList<GHDKNDLHOKN> KGMCJGMOFMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x68422C0", Offset = "0x68416C0", VA = "0x1868422C0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(DCPFCHOHFFJ))]
	private static Task CHNIGDHPGCJ(ECGHPDBPEDH DEKKJJMPPGF, FMGDIDICPAO IHPHNJFCMAH, IReadOnlyDictionary<CJPJAKBBEBK, NMENJMIAGGE> OIABEMBLHKK, IAFJNKBOOFK OPKGOHKKPDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x6841FC0", Offset = "0x68413C0", VA = "0x186841FC0")]
	[CompilerGenerated]
	internal static void BONDJJBMCAL(Func<LDGOPDGIJBL, KEABBPEHNCD> FBDLPJHEKJP, ref DCLMGFMKDKK P_1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x68465E0", Offset = "0x68459E0", VA = "0x1868465E0")]
	[CompilerGenerated]
	internal static bool PMCINGKMPHK(CJPJAKBBEBK HAEFIPKIGJM, GHDKNDLHOKN HJPMJJKGAIN, out CBGAALBCCLJ BOKLNCIINJG, ref BJICLAHJPLF P_3)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public enum GHDKNDLHOKN
{
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	INVALID = -1,
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	CAN_EDIT_ROOM_ROLES = 1,
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	VOTE_KICK_PERMISSION = 3,
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	CAN_INVITE = 4,
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	CAN_TALK = 6,
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	CAN_PRINT_PHOTOS = 7,
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	CAN_START_GAMES = 8,
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	CAN_SELF_REVIVE = 9,
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	AUTO_ASSIGNED_GAME_ROLES = 11,
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	CAN_CHANGE_GAME_MODE = 12,
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	CAN_USE_MAKER_PEN = 13,
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	CAN_USE_DELETE_ALL_BUTTON = 14,
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	CAN_SAVE_INVENTIONS = 15,
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	DISABLE_MIC_AUTO_MUTE = 16,
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	CAN_END_GAMES_EARLY = 17,
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	CAN_USE_SHARE_CAM = 18,
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	DEPRECATED_CAN_EDIT_CIRCUITS = 19,
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	CAN_SPAWN_INVENTIONS = 20,
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	CAN_SPAWN_CONSUMABLES = 21,
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	CAN_USE_ROOM_RESET_BUTTON = 22,
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	CAN_USE_PLAY_GIZMOS_TOGGLE = 23
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal class BEJOIMPEAAI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly Dictionary<GHDKNDLHOKN, bool> ONLGMCINKKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly Dictionary<GHDKNDLHOKN, HJAHLEJGAAD> BCFLIJLCBEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly LNACMPLFAIJ DKDAEOCKBCL;

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x683AA00", Offset = "0x6839E00", VA = "0x18683AA00")]
	public BEJOIMPEAAI(LNACMPLFAIJ DKDAEOCKBCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x683A7E0", Offset = "0x6839BE0", VA = "0x18683A7E0")]
	public bool KKBHMEAHEGK(GHDKNDLHOKN HJPMJJKGAIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x27C1340", Offset = "0x27C0740", VA = "0x1827C1340")]
	public bool EPLCMDJICEL<T>(GHDKNDLHOKN HJPMJJKGAIN, bool DIEBPEOGLIN, T EOEKGHMNIDN) where T : notnull, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x27C16B0", Offset = "0x27C0AB0", VA = "0x1827C16B0")]
	public (bool, T?) LPBFGKPBEFH<T>(GHDKNDLHOKN HJPMJJKGAIN) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x683A700", Offset = "0x6839B00", VA = "0x18683A700")]
	public bool EPLCMDJICEL(GHDKNDLHOKN HJPMJJKGAIN, bool DIEBPEOGLIN, object EOEKGHMNIDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x683A850", Offset = "0x6839C50", VA = "0x18683A850")]
	public (bool, object) LPBFGKPBEFH(GHDKNDLHOKN HJPMJJKGAIN)
	{
		return default((bool, object));
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x27C1470", Offset = "0x27C0870", VA = "0x1827C1470")]
	private void GJJMOJPKHIK<T>(GHDKNDLHOKN HJPMJJKGAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x683A940", Offset = "0x6839D40", VA = "0x18683A940")]
	private HJAHLEJGAAD NPBFACNHADG(GHDKNDLHOKN HJPMJJKGAIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x683A560", Offset = "0x6839960", VA = "0x18683A560")]
	public void CPDIDLELBLF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface HBFOPCGPIMB
{
	[Cpp2IlInjected.Token(Token = "0x17000042")]
	PNDNHJDGAML EOPHOIMMOJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal class NNDFMAJDBJP : HBFOPCGPIMB
{
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public static NNDFMAJDBJP MIACBHABNAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	internal readonly NMENJMIAGGE OCKLJDNGIAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	internal readonly IReadOnlyList<NMENJMIAGGE> CPCLCKABHDA;

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public PNDNHJDGAML EOPHOIMMOJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x856480", Offset = "0x855880", VA = "0x180856480", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x6840950", Offset = "0x683FD50", VA = "0x186840950")]
	public NNDFMAJDBJP(NMENJMIAGGE FINLAFCAAIN, IReadOnlyList<NMENJMIAGGE> ENICPIOPHCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x6840110", Offset = "0x683F510", VA = "0x186840110")]
	private static NNDFMAJDBJP KEILDPDLGIH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public enum INIONMAGLEC
{
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	Hosts,
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	Everyone
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
