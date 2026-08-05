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
		[Cpp2IlInjected.Address(RVA = "0x805E70", Offset = "0x804870", VA = "0x180805E70")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x655C3B0", Offset = "0x655ADB0", VA = "0x18655C3B0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x847190", Offset = "0x845B90", VA = "0x180847190")]
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
		[Cpp2IlInjected.Address(RVA = "0x143BBF0", Offset = "0x143A5F0", VA = "0x18143BBF0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum CGDJGHJPMKO
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Vote,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	Instant,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	Off
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum LNLMJAFGFHA
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	Hosts,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Everyone
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void LGMAEPHMNKK<TPermission>(TPermission OBINJPODAFH);
[Cpp2IlInjected.Token(Token = "0x2000008")]
public delegate void APKHFPOKBJA(DLMMMHADHKF KHHBJBINELJ);
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface HBEPDFPJONH
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool GHEOLGGJKGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool PGKDJJHFHJG
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool CHFCIAOJPBF
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool EBKFMMLPLKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool LCBOEOLOOOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool OGEALJEHIKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface AHAPMFLGDDO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	LPHCMAJMPGE DKOOGPDOEMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	IEnumerable<MIACBIKKOJM> PPILNJINNAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event APKHFPOKBJA PNPJEEANJCD;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IReadOnlyList<MIACBIKKOJM> MNAMIANIHBO(bool BPENENFGNMJ = false);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "5")]
	MIACBIKKOJM PLODKJJOOJM(DLMMMHADHKF KHHBJBINELJ);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool NFMJPEKOJIP(DLMMMHADHKF KHHBJBINELJ);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IReadOnlyList<MIACBIKKOJM> FMMJAEIFLDG(DLMMMHADHKF KHHBJBINELJ, bool OOGNBMOAGBL = false);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool LFDKNBFJEAA(DLMMMHADHKF FIHJMKELBMK, FJEEACACIFP DNIPFFINFGB);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	MIACBIKKOJM EKBOHMALPBD(FJEEACACIFP DNIPFFINFGB);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool PKGDJNADAFB<T>(FJEEACACIFP DNIPFFINFGB, KHDLFIFCBPJ OBINJPODAFH, bool CFDAOEONPIF, T NMPNMHNJPAA) where T : notnull;
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface LAFIKMLIILI
{
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task BKNBNOJEIHG(PPDGLIGMGBC EIFFMACPBMC, CancellationToken FAPLHFKLMOL);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JHEECMBKOLN(ref PPDGLIGMGBC EIFFMACPBMC);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface ENEJABNNOOD
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	DLMMMHADHKF JDEBACJMPNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	LFNBMKGDGCH PJPAGHPOAEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	ODEDLFDFFLB EKOCGEPLAMK
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<NMFCNLLMADP> JEBFMJCLFPC;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action NCGDEBJDJDF;

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "4")]
	FJEEACACIFP GMECMBHAMEG(DLMMMHADHKF KHHBJBINELJ);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<NMFCNLLMADP> KINKHDBCPHC(CancellationToken FAPLHFKLMOL);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task NGFPNPDGLMC(long GPCCPBNNCAG, long MFAFLMKPGKO, IReadOnlyList<OOBBHJNMIIF> HJLLIKKMOLN);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IEnumerable<DLMMMHADHKF> CJJDGHKGPIG();
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class KBNDEFJIKCD
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6558190", Offset = "0x6556B90", VA = "0x186558190")]
	public static FJEEACACIFP GMEHDDPFKCK(this ENEJABNNOOD HMJLKIOGPLI)
	{
		return default(FJEEACACIFP);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface FFJEKPNAAJO<TPermission> where TPermission : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	string IBPBFGIKAKN
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event global::LGMAEPHMNKK<TPermission> IMDBECGBLNB;
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
internal static class JECECHJBGPC
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[Flags]
	public enum GMNJOFDEMGH
	{
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		AG_EVERYONE = 0,
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		AG_CREATOR = 0x200000,
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		AG_COOWNER = 0x400000,
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		AG_HOST = 0x800000,
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		AG_MODERATOR = 0x1000000
	}

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static readonly Guid IAEFFAPBDCH;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly Guid NNLKCADBLLH;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly Guid DKLEOHMOCCB;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static readonly Guid OKKGLAPLBIO;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public static readonly Guid OMFOOJAJJNC;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static readonly global::AHFCLFBIBIJ<FJEEACACIFP, Guid> MHPADCFOGHF;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	internal static IEnumerable<FJEEACACIFP> KCEIKEJLEOA
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6557AA0", Offset = "0x65564A0", VA = "0x186557AA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6557C00", Offset = "0x6556600", VA = "0x186557C00")]
	public static FJEEACACIFP FHELJPLKEKA(Guid GDCMPFDFIDH)
	{
		return default(FJEEACACIFP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6557D70", Offset = "0x6556770", VA = "0x186557D70")]
	public static Guid LBAHAMFCJJH(FJEEACACIFP DNIPFFINFGB)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6557E20", Offset = "0x6556820", VA = "0x186557E20")]
	public static bool ODAPDHHEAJM(FJEEACACIFP DNIPFFINFGB, out Guid GDCMPFDFIDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6557CD0", Offset = "0x65566D0", VA = "0x186557CD0")]
	public static bool IGKPLHIEPOG(Guid GDCMPFDFIDH, out FJEEACACIFP DNIPFFINFGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6557BD0", Offset = "0x65565D0", VA = "0x186557BD0")]
	public static FJEEACACIFP FDJPJDNDMCA(FJEEACACIFP DNIPFFINFGB)
	{
		return default(FJEEACACIFP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6557B20", Offset = "0x6556520", VA = "0x186557B20")]
	public static GMNJOFDEMGH BMKJMGPINNI(FJEEACACIFP DIAEDCMJHPH)
	{
		return default(GMNJOFDEMGH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6557C90", Offset = "0x6556690", VA = "0x186557C90")]
	internal static FJEEACACIFP FOPHEBAEHAN(GMNJOFDEMGH LOLJLLJOBAG)
	{
		return default(FJEEACACIFP);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal abstract class DKPFGKIFCFJ
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public object? BHOFCOLGALN
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x75C3F0", Offset = "0x75ADF0", VA = "0x18075C3F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7D2880", Offset = "0x7D1280", VA = "0x1807D2880")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x82DEC0", Offset = "0x82C8C0", VA = "0x18082DEC0")]
	protected DKPFGKIFCFJ(object? MPCAEHJGOBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool AGPCCBACEAN(object? MFBGAMJDOKA);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal class CPOOPOCKNCK<T> : DKPFGKIFCFJ where T : notnull, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private T DAGJBILMADG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly IEqualityComparer<T> KOKADNNACHM;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public T ONBMIOJBCHK
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x80ADB0", Offset = "0x8097B0", VA = "0x18080ADB0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x42862E0", Offset = "0x4284CE0", VA = "0x1842862E0", Slot = "4")]
	public override bool AGPCCBACEAN(object? MFBGAMJDOKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x42866D0", Offset = "0x42850D0", VA = "0x1842866D0")]
	public bool KBFADGANAFJ(T EPAGPOPDFAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x4286A90", Offset = "0x4285490", VA = "0x184286A90")]
	public CPOOPOCKNCK(T NEHANGBEOBM, IEqualityComparer<T> KOKADNNACHM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class OPNMNMLAJKC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly Dictionary<KHDLFIFCBPJ, bool> ODMMLMNACCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly Dictionary<KHDLFIFCBPJ, DKPFGKIFCFJ> KNIOHKAKCHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly MAEGPPDCPNM IIMPDABCIJK;

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6562010", Offset = "0x6560A10", VA = "0x186562010")]
	public OPNMNMLAJKC(MAEGPPDCPNM IIMPDABCIJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6561D30", Offset = "0x6560730", VA = "0x186561D30")]
	public bool JMJBNKCBJDC(KHDLFIFCBPJ OBINJPODAFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3687710", Offset = "0x3686110", VA = "0x183687710")]
	public bool FEPMGPBLBHM<T>(KHDLFIFCBPJ OBINJPODAFH, bool CFDAOEONPIF, T MFBGAMJDOKA) where T : notnull, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3687A90", Offset = "0x3686490", VA = "0x183687A90")]
	public (bool, T?) NNOMPGDBHFC<T>(KHDLFIFCBPJ OBINJPODAFH) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6561B90", Offset = "0x6560590", VA = "0x186561B90")]
	public bool FEPMGPBLBHM(KHDLFIFCBPJ OBINJPODAFH, bool CFDAOEONPIF, object MFBGAMJDOKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6561DA0", Offset = "0x65607A0", VA = "0x186561DA0")]
	public (bool, object) NNOMPGDBHFC(KHDLFIFCBPJ OBINJPODAFH)
	{
		return default((bool, object));
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x36873D0", Offset = "0x3685DD0", VA = "0x1836873D0")]
	private void DHFCFAFPPPP<T>(KHDLFIFCBPJ OBINJPODAFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6561C70", Offset = "0x6560670", VA = "0x186561C70")]
	private DKPFGKIFCFJ GAKIJAPABIF(KHDLFIFCBPJ OBINJPODAFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6561E70", Offset = "0x6560870", VA = "0x186561E70")]
	public void PGLLHJDIFMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal class NBBPOODHKEP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly string ADHOEHCIAKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly Type CKCALNBFJIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly HFAMIKBBNJN GJGOHIADCAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly KHDLFIFCBPJ LCIIFEGOFMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public MELELCKNOHC HCMBNLMHIFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public FAOLMGFCNOM NGDBDBBKMKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public OJJKJPNIKOC PAMHDOOCDFE;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x655BFF0", Offset = "0x655A9F0", VA = "0x18655BFF0")]
	public NBBPOODHKEP(Type DIKPMEOLIMB, string AKMIILGDJDF, KHDLFIFCBPJ OBINJPODAFH, MELELCKNOHC NCFKAAAFBBK, FAOLMGFCNOM DGBKLJJCMOM, OJJKJPNIKOC KMBLGIEGIAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x655BFB0", Offset = "0x655A9B0", VA = "0x18655BFB0")]
	public object FPHLLMJPBDF(object? EHBPAFKHADK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3C7A400", Offset = "0x3C78E00", VA = "0x183C7A400")]
	public void DHFCFAFPPPP<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x655BF00", Offset = "0x655A900", VA = "0x18655BF00")]
	public void DHFCFAFPPPP(Type IEGIELABBKO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
internal class POEFBLNDEHG<T> : NBBPOODHKEP where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal delegate string BMNIPGMAMPG(T MFBGAMJDOKA);

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	internal delegate T KCOBMLIAAPA(string? ILEPHBAHFKG, T NEHANGBEOBM);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class OGEPIKOMEIA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public BMNIPGMAMPG serializeRecNetString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public KCOBMLIAAPA parseRecNetString;

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x25118A0", Offset = "0x25102A0", VA = "0x1825118A0")]
		public OGEPIKOMEIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x3ED8C10", Offset = "0x3ED7610", VA = "0x183ED8C10")]
		internal string <.ctor>b__0(object? v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x3ED8D00", Offset = "0x3ED7700", VA = "0x183ED8D00")]
		internal object <.ctor>b__1(string? s, object d)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x43ED830", Offset = "0x43EC230", VA = "0x1843ED830")]
	public POEFBLNDEHG(KHDLFIFCBPJ OBINJPODAFH, string AKMIILGDJDF, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0xD8ED0", Offset = "0xD82D0")] global::POEFBLNDEHG<T>.BMNIPGMAMPG NCFKAAAFBBK, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0xD8F30", Offset = "0xD8330")] global::POEFBLNDEHG<T>.KCOBMLIAAPA DGBKLJJCMOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x43EC150", Offset = "0x43EAB50", VA = "0x1843EC150")]
	private static object? AIBDMMJCKEC([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0xD8F90", Offset = "0xD8390")] global::POEFBLNDEHG<T?>.KCOBMLIAAPA? DGBKLJJCMOM, string? ILEPHBAHFKG, object? NEHANGBEOBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x43ECBA0", Offset = "0x43EB5A0", VA = "0x1843ECBA0")]
	private static string HGLHKADDNFF([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0xD8FF0", Offset = "0xD83F0")] global::POEFBLNDEHG<T>.BMNIPGMAMPG COELHNMKFFI, object? MFBGAMJDOKA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal delegate string MELELCKNOHC(object? MFBGAMJDOKA);
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal delegate object FAOLMGFCNOM(string? ILEPHBAHFKG, [Optional] object NEHANGBEOBM);
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal delegate DKPFGKIFCFJ OJJKJPNIKOC();
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal class MAEGPPDCPNM
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	private class PJMGLMHNHEJ : IEqualityComparer<List<string>>
	{
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		internal static PJMGLMHNHEJ FINLHCLDLDF;

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6562270", Offset = "0x6560C70", VA = "0x186562270", Slot = "4")]
		public bool Equals(List<string> KCAHJOFJKBP, List<string> NBBBAMBDAJJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x65623D0", Offset = "0x6560DD0", VA = "0x1865623D0", Slot = "5")]
		public int GetHashCode(List<string> OMHIFHKMIMJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
		public PJMGLMHNHEJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private class NMCEIFLFOKN : global::CAOGCMOHMEN<CGDJGHJPMKO>
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x655C080", Offset = "0x655AA80", VA = "0x18655C080", Slot = "9")]
		public override string HGLHKADDNFF(CGDJGHJPMKO LKCFMJOKMBE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x655C180", Offset = "0x655AB80", VA = "0x18655C180", Slot = "10")]
		protected override bool HIDAIFLFILK(string LKCFMJOKMBE, out CGDJGHJPMKO MFBGAMJDOKA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x655C370", Offset = "0x655AD70", VA = "0x18655C370")]
		public NMCEIFLFOKN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private static readonly FGBPAHBEJDH AIOBJFIBKID;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static readonly NMCEIFLFOKN JDCDLNFNHIK;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static readonly List<NBBPOODHKEP> EHHDMCAKFGA;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<KHDLFIFCBPJ> MGABGODJNHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x75C3F0", Offset = "0x75ADF0", VA = "0x18075C3F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public IReadOnlyDictionary<KHDLFIFCBPJ, NBBPOODHKEP> IFBLIGPABKH
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x76B750", Offset = "0x76A150", VA = "0x18076B750")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x655B990", Offset = "0x655A390", VA = "0x18655B990")]
	public MAEGPPDCPNM([Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0xD9050", Offset = "0xD8450")] IList<NBBPOODHKEP> EPJDBEDGHKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x655ADA0", Offset = "0x65597A0", VA = "0x18655ADA0")]
	public NBBPOODHKEP NKEAGDNEKEL(KHDLFIFCBPJ OBINJPODAFH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface LPHCMAJMPGE
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	MIACBIKKOJM IKINFFMDDPK
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal class EHCGIMBDDPP : LPHCMAJMPGE
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public static EHCGIMBDDPP HPGINPKFAOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	internal readonly KOBDFDOJFEG PJCFCCJOKEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	internal readonly IReadOnlyList<KOBDFDOJFEG> BLIJGOCLAMO;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public MIACBIKKOJM IKINFFMDDPK
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x75C3F0", Offset = "0x75ADF0", VA = "0x18075C3F0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6556DC0", Offset = "0x65557C0", VA = "0x186556DC0")]
	public EHCGIMBDDPP(KOBDFDOJFEG NOMKGKOGLFB, IReadOnlyList<KOBDFDOJFEG> IHGDHHIKBDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6556580", Offset = "0x6554F80", VA = "0x186556580")]
	private static EHCGIMBDDPP CHHKPFJGDHD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class PNPLNDMGHFL
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static readonly IReadOnlyList<FJEEACACIFP> NOHNFGJGOIM;

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6562570", Offset = "0x6560F70", VA = "0x186562570")]
	public static bool CPJCCIIBFNE(this DLMMMHADHKF GBANELEFAMB, FJEEACACIFP DNIPFFINFGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6562660", Offset = "0x6561060", VA = "0x186562660")]
	public static bool PGMOBAGJMAH(this DLMMMHADHKF GBANELEFAMB, FJEEACACIFP DNIPFFINFGB, ODEDLFDFFLB ECFCIHOBFKA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface HHAFENMPNGH
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool KOOMOALBOEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool PEEJDHPPKDH
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool DIOJCJJBFCH
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool FLIHEGABPDA
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool FBHKEKKNIMA
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool AALPDGIEHDE
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool BIMKDCMKKAN
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool CBGBHLNEEBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool IEBBNAGGADC
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool JJNEGNGNLDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool DDMLDHDHAIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool LCEGHGJKMIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	IReadOnlyList<string> FOMMCOPMGPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	CGDJGHJPMKO EGEPHLJELFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface MIACBIKKOJM : HHAFENMPNGH, HBEPDFPJONH, global::FFJEKPNAAJO<KHDLFIFCBPJ>
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	string EENCEFGKPPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	FJEEACACIFP DIOHOMNHHAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(Slot = "2")]
	(bool, T?) MBNOOELDBNL<T>(KHDLFIFCBPJ OBINJPODAFH) where T : new();
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public enum KHDLFIFCBPJ
{
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	INVALID = -1,
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	CAN_EDIT_ROOM_ROLES = 1,
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	VOTE_KICK_PERMISSION = 3,
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	CAN_INVITE = 4,
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	CAN_TALK = 6,
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	CAN_PRINT_PHOTOS = 7,
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	CAN_START_GAMES = 8,
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	CAN_SELF_REVIVE = 9,
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	AUTO_ASSIGNED_GAME_ROLES = 11,
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	CAN_CHANGE_GAME_MODE = 12,
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	CAN_USE_MAKER_PEN = 13,
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	CAN_USE_DELETE_ALL_BUTTON = 14,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	CAN_SAVE_INVENTIONS = 15,
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	DISABLE_MIC_AUTO_MUTE = 16,
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	CAN_END_GAMES_EARLY = 17,
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	CAN_USE_SHARE_CAM = 18,
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	DEPRECATED_CAN_EDIT_CIRCUITS = 19,
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	CAN_SPAWN_INVENTIONS = 20,
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	CAN_SPAWN_CONSUMABLES = 21,
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	CAN_USE_ROOM_RESET_BUTTON = 22,
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	CAN_USE_PLAY_GIZMOS_TOGGLE = 23
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal class KOBDFDOJFEG : MIACBIKKOJM, HHAFENMPNGH, HBEPDFPJONH, global::FFJEKPNAAJO<KHDLFIFCBPJ>
{
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	internal static readonly MAEGPPDCPNM MKPHPGACDPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	internal readonly OPNMNMLAJKC JNOOFEOFLJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private string? GHAILPPBLAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private string? JPGFCALEEEK;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public bool KOOMOALBOEI
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x6559F30", Offset = "0x6558930", VA = "0x186559F30", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public CGDJGHJPMKO EGEPHLJELFN
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x6559480", Offset = "0x6557E80", VA = "0x186559480", Slot = "20")]
		get
		{
			return default(CGDJGHJPMKO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public bool PEEJDHPPKDH
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x6559150", Offset = "0x6557B50", VA = "0x186559150", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool DIOJCJJBFCH
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x655A6D0", Offset = "0x65590D0", VA = "0x18655A6D0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool FLIHEGABPDA
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x655A5E0", Offset = "0x6558FE0", VA = "0x18655A5E0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool FBHKEKKNIMA
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x65593E0", Offset = "0x6557DE0", VA = "0x1865593E0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool AALPDGIEHDE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x655AAC0", Offset = "0x65594C0", VA = "0x18655AAC0", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public bool BIMKDCMKKAN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x6559FD0", Offset = "0x65589D0", VA = "0x186559FD0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public bool CBGBHLNEEBI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x655AA50", Offset = "0x6559450", VA = "0x18655AA50", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool IEBBNAGGADC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x655A680", Offset = "0x6559080", VA = "0x18655A680", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public IReadOnlyList<string> FOMMCOPMGPE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x65594D0", Offset = "0x6557ED0", VA = "0x1865594D0", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool GPCLNBHMAPG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x65591F0", Offset = "0x6557BF0", VA = "0x1865591F0", Slot = "30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool JBAECPNHLNB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x6559430", Offset = "0x6557E30", VA = "0x186559430", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool BMHFJOIAFKI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x655A630", Offset = "0x6559030", VA = "0x18655A630", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool JJNEGNGNLDC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x6559F80", Offset = "0x6558980", VA = "0x186559F80", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool DDMLDHDHAIA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6559530", Offset = "0x6557F30", VA = "0x186559530", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool JPJHHABJIIB
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x6558C00", Offset = "0x6557600", VA = "0x186558C00", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool LCEGHGJKMIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x6559240", Offset = "0x6557C40", VA = "0x186559240", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool KDNIHKBENDI
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x6558C50", Offset = "0x6557650", VA = "0x186558C50", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool KAHPGECJNEA
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x6559290", Offset = "0x6557C90", VA = "0x186559290", Slot = "35")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	private bool DMKANDDFNNE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x65591F0", Offset = "0x6557BF0", VA = "0x1865591F0", Slot = "23")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	private bool JGAMPFHDPMD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x655A630", Offset = "0x6559030", VA = "0x18655A630", Slot = "22")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	private bool HJMIBGKLCBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x6558C00", Offset = "0x6557600", VA = "0x186558C00", Slot = "21")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	private bool GOJHOFHIBME
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x6558C50", Offset = "0x6557650", VA = "0x186558C50", Slot = "24")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	private bool HJFOENMAPGE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x6559430", Offset = "0x6557E30", VA = "0x186559430", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	private bool EHLMPKNNENB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x6559290", Offset = "0x6557C90", VA = "0x186559290", Slot = "25")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public FJEEACACIFP DIOHOMNHHAF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x80ADB0", Offset = "0x8097B0", VA = "0x18080ADB0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(FJEEACACIFP);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x80A4B0", Offset = "0x808EB0", VA = "0x18080A4B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public string IBPBFGIKAKN
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x655A0C0", Offset = "0x6558AC0", VA = "0x18655A0C0", Slot = "29")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x65591A0", Offset = "0x6557BA0", VA = "0x1865591A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public string EENCEFGKPPO
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x655A0C0", Offset = "0x6558AC0", VA = "0x18655A0C0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool HFEFPIGLNNI
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x878090", Offset = "0x876A90", VA = "0x180878090")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x878110", Offset = "0x876B10", VA = "0x180878110")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event global::LGMAEPHMNKK<KHDLFIFCBPJ> IMDBECGBLNB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x655A7A0", Offset = "0x65591A0", VA = "0x18655A7A0", Slot = "27")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x655A020", Offset = "0x6558A20", VA = "0x18655A020", Slot = "28")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x655A840", Offset = "0x6559240", VA = "0x18655A840")]
	public LJPEGEGHADM OFJEEAPGMMC(Func<FJEEACACIFP, Guid> FDLPPNNLJFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x6559580", Offset = "0x6557F80", VA = "0x186559580")]
	public void IILHDOEKPBC(LJPEGEGHADM GOOACGIBELH, Func<Guid, FJEEACACIFP> OAEEHAGMIGN, [Optional] FJEEACACIFP? FBMDCBMGNEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x36F9370", Offset = "0x36F7D70", VA = "0x1836F9370", Slot = "6")]
	public (bool, T?) MBNOOELDBNL<T>(KHDLFIFCBPJ OBINJPODAFH) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x36F9500", Offset = "0x36F7F00", VA = "0x1836F9500")]
	public KOBDFDOJFEG NFIBMGIEOGF<T>(KHDLFIFCBPJ OBINJPODAFH, bool CFDAOEONPIF, T MFBGAMJDOKA) where T : notnull, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x655AD80", Offset = "0x6559780", VA = "0x18655AD80")]
	public KOBDFDOJFEG(FJEEACACIFP DNIPFFINFGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x655AB80", Offset = "0x6559580", VA = "0x18655AB80")]
	public KOBDFDOJFEG(FJEEACACIFP DNIPFFINFGB, [Optional] string? GHAILPPBLAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x655ABA0", Offset = "0x65595A0", VA = "0x18655ABA0")]
	public KOBDFDOJFEG(KOBDFDOJFEG MFHBOACDFHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x655AC30", Offset = "0x6559630", VA = "0x18655AC30")]
	internal KOBDFDOJFEG(FJEEACACIFP FPJINDMKIKE, [Optional] string? GHAILPPBLAD, [Optional] KOBDFDOJFEG? MFHBOACDFHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x655A720", Offset = "0x6559120", VA = "0x18655A720")]
	public static HFAMIKBBNJN NGFJAOKBJBK(KHDLFIFCBPJ OBINJPODAFH)
	{
		return default(HFAMIKBBNJN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x655AAA0", Offset = "0x65594A0", VA = "0x18655AAA0")]
	public void PGLLHJDIFMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x6558E10", Offset = "0x6557810", VA = "0x186558E10")]
	internal KOBDFDOJFEG APIAKKIDNIF(KOBDFDOJFEG FADFGHIBDJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x655A110", Offset = "0x6558B10", VA = "0x18655A110")]
	internal IReadOnlyCollection<KHDLFIFCBPJ> KCMGAHNKFOP(KOBDFDOJFEG MFHBOACDFHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x6558CA0", Offset = "0x65576A0", VA = "0x186558CA0")]
	public bool ALGMDPPLEKG(KHDLFIFCBPJ OBINJPODAFH, bool CFDAOEONPIF, string LDPHOFFBDDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x65592E0", Offset = "0x6557CE0", VA = "0x1865592E0")]
	public (bool, string) DBHJGGBMENL(KHDLFIFCBPJ OBINJPODAFH)
	{
		return default((bool, string));
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x655A540", Offset = "0x6558F40", VA = "0x18655A540")]
	internal void KGHFGHJGLCH(KHDLFIFCBPJ OBINJPODAFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x6558D80", Offset = "0x6557780", VA = "0x186558D80")]
	[CompilerGenerated]
	private void ALMGAFHAEGB(KHDLFIFCBPJ MJMKMFGOMDD, GAGJECBHKNI HJNMNMHHEHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class OMLPJABIBBB : LAFIKMLIILI, AHAPMFLGDDO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class EKJHJHBOIII
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public KOBDFDOJFEG newRole;

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
		public EKJHJHBOIII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x6556EC0", Offset = "0x65558C0", VA = "0x186556EC0")]
		internal bool <InitializeRolesLists>b__0(KOBDFDOJFEG rc)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class CCFGDCPINDG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public FJEEACACIFP roleTypeToUpdate;

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
		public CCFGDCPINDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x6555F50", Offset = "0x6554950", VA = "0x186555F50")]
		internal bool <UpdateRoleDatas>b__0(FJEEACACIFP r)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private struct DMGMIGHMAMF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public OMLPJABIBBB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public PPDGLIGMGBC roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private bool <isOffline>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0xD9640", Offset = "0xD8A40")]
		private TaskAwaiter<NMFCNLLMADP> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x6555F60", Offset = "0x6554960", VA = "0x186555F60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x9396C0", Offset = "0x9380C0", VA = "0x1809396C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class MPDFMDEPPMP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public StringBuilder migrationMessageBuilder;

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
		public MPDFMDEPPMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x655BD00", Offset = "0x655A700", VA = "0x18655BD00")]
		internal void <RunBackwardsCompatibilityMigration>b__0(LJPEGEGHADM r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x655BDE0", Offset = "0x655A7E0", VA = "0x18655BDE0")]
		internal void <RunBackwardsCompatibilityMigration>b__1(LJPEGEGHADM r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct LMLDEBKIPHK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public PPDGLIGMGBC roomData;
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class FEKJPLCPIAG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0xD96A0", Offset = "0xD8AA0")]
		public Func<LJPEGEGHADM, GAGJECBHKNI> dataFunc;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
		public FEKJPLCPIAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x6557980", Offset = "0x6556380", VA = "0x186557980")]
		internal void <MigrateLegacyHostSettings>b__1(LJPEGEGHADM r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x65579E0", Offset = "0x65563E0", VA = "0x1865579E0")]
		internal void <MigrateLegacyHostSettings>b__2(LJPEGEGHADM r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x6557A40", Offset = "0x6556440", VA = "0x186557A40")]
		internal void <MigrateLegacyHostSettings>b__3(LJPEGEGHADM r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class EDPOANCGNDC<T> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public OMLPJABIBBB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public KHDLFIFCBPJ rolePermission;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public FJEEACACIFP accountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public HFAMIKBBNJN recNetPermissionType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public string serializedNewValue;

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x25118A0", Offset = "0x25102A0", VA = "0x1825118A0")]
		public EDPOANCGNDC()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct ACPKJCIPJDI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public IReadOnlyList<OOBBHJNMIIF> newPermissionOverrides;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct KLKGABFDHLK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public ENEJABNNOOD rolesDataProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public PPDGLIGMGBC roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0xD97B0", Offset = "0xD8BB0")]
		public IReadOnlyDictionary<FJEEACACIFP, KOBDFDOJFEG> defaultRoles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public PLABCCAFOIB debugLogger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x65581F0", Offset = "0x6556BF0", VA = "0x1865581F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x9396C0", Offset = "0x9380C0", VA = "0x1809396C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private readonly ENEJABNNOOD HMJLKIOGPLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private readonly EHCGIMBDDPP CBGCHOLKDNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly PLABCCAFOIB KOJCJPGMKLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly Dictionary<int, KOBDFDOJFEG> BCPEDDMMCNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	internal readonly Dictionary<FJEEACACIFP, KOBDFDOJFEG> JDHAINOFOMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	internal readonly Dictionary<FJEEACACIFP, KOBDFDOJFEG> LFBAHOKHEOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	internal readonly List<KOBDFDOJFEG> FLGFHNKODPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private bool JCNJOFIEDDK;

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private static readonly KHDLFIFCBPJ[] HOGGMLFNIFM;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public LPHCMAJMPGE DKOOGPDOEMC
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x76B750", Offset = "0x76A150", VA = "0x18076B750", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public IEnumerable<MIACBIKKOJM> PPILNJINNAI
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x655DF50", Offset = "0x655C950", VA = "0x18655DF50", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event APKHFPOKBJA PNPJEEANJCD
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x655F580", Offset = "0x655DF80", VA = "0x18655F580", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x655DFB0", Offset = "0x655C9B0", VA = "0x18655DFB0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x655C440", Offset = "0x655AE40", VA = "0x18655C440")]
	[MBJLKJLIAAH(JLEIDHHFJDB.Room, JDACKNHLALI.None)]
	private static void AECLFLMFJEA(DPALDOJEBJE KKCEAAFKCFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x6561900", Offset = "0x6560300", VA = "0x186561900")]
	[UnityEngine.Scripting.Preserve]
	internal OMLPJABIBBB([PDHOKDIGCJO(null)] ENEJABNNOOD CACFOPOPLPL, [PDHOKDIGCJO(null)] EHCGIMBDDPP KJGKMAPALFI, [PDHOKDIGCJO(null)] PLABCCAFOIB KOJCJPGMKLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x655DD90", Offset = "0x655C790", VA = "0x18655DD90", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x655C760", Offset = "0x655B160", VA = "0x18655C760")]
	private void BGFPOAIGKDP(IEnumerable<KOBDFDOJFEG> NPFECBFJCED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x6560560", Offset = "0x655EF60", VA = "0x186560560", Slot = "12")]
	public bool NFMJPEKOJIP(DLMMMHADHKF KHHBJBINELJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x6560550", Offset = "0x655EF50", VA = "0x186560550")]
	private void NCGDEBJDJDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x655D300", Offset = "0x655BD00", VA = "0x18655D300")]
	private void COCENOAIJGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x65604D0", Offset = "0x655EED0", VA = "0x1865604D0", Slot = "10")]
	public IReadOnlyList<MIACBIKKOJM> MNAMIANIHBO(bool BPENENFGNMJ = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x6561620", Offset = "0x6560020", VA = "0x186561620", Slot = "11")]
	public MIACBIKKOJM PLODKJJOOJM(DLMMMHADHKF KHHBJBINELJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x655F1C0", Offset = "0x655DBC0", VA = "0x18655F1C0")]
	private FJEEACACIFP IPAMOGKKELP(DLMMMHADHKF KHHBJBINELJ)
	{
		return default(FJEEACACIFP);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x655FC00", Offset = "0x655E600", VA = "0x18655FC00", Slot = "14")]
	public bool LFDKNBFJEAA(DLMMMHADHKF FIHJMKELBMK, FJEEACACIFP DNIPFFINFGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x655DEA0", Offset = "0x655C8A0", VA = "0x18655DEA0", Slot = "15")]
	public MIACBIKKOJM EKBOHMALPBD(FJEEACACIFP DNIPFFINFGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x655D490", Offset = "0x655BE90", VA = "0x18655D490")]
	private static bool CPAJNAEFALF(GOBMFIJCCKJ AMJJACEGCNE, FJEEACACIFP DNIPFFINFGB, out LJPEGEGHADM? HGMFADOOPDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x65612C0", Offset = "0x655FCC0", VA = "0x1865612C0")]
	private static void PEKCMJPPCIK(GOBMFIJCCKJ AMJJACEGCNE, Action<LJPEGEGHADM> MJGIJHAAHEN, FJEEACACIFP PGAEPCDMKBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x65613C0", Offset = "0x655FDC0", VA = "0x1865613C0")]
	private static void PEKCMJPPCIK(GOBMFIJCCKJ AMJJACEGCNE, Action<LJPEGEGHADM> MJGIJHAAHEN, Predicate<FJEEACACIFP> DKLMOOHHGPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x65615C0", Offset = "0x655FFC0", VA = "0x1865615C0")]
	private void PIONLBDHLED(DLMMMHADHKF KHHBJBINELJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x655CF50", Offset = "0x655B950", VA = "0x18655CF50", Slot = "4")]
	[AsyncStateMachine(typeof(DMGMIGHMAMF))]
	public Task BKNBNOJEIHG([CanBeNull] PPDGLIGMGBC EIFFMACPBMC, CancellationToken FAPLHFKLMOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "5")]
	public void JHEECMBKOLN(ref PPDGLIGMGBC EIFFMACPBMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x655D090", Offset = "0x655BA90", VA = "0x18655D090")]
	private void BLLLCNBGEDJ(GOBMFIJCCKJ FOPKNBIAFIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x655F280", Offset = "0x655DC80", VA = "0x18655F280")]
	internal static string KEHEDLLOHDM(ENEJABNNOOD HMJLKIOGPLI, PPDGLIGMGBC EIFFMACPBMC, IReadOnlyDictionary<FJEEACACIFP, KOBDFDOJFEG> JDHAINOFOMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x655E050", Offset = "0x655CA50", VA = "0x18655E050")]
	private static void IHIPJGKLPPL(PPDGLIGMGBC EIFFMACPBMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x655F620", Offset = "0x655E020", VA = "0x18655F620")]
	private static void KJCPDEHLHHP(GOBMFIJCCKJ MKGEKACOGKE, IReadOnlyDictionary<FJEEACACIFP, KOBDFDOJFEG> JDHAINOFOMM, StringBuilder EHMGKLPLEBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x6560FA0", Offset = "0x655F9A0", VA = "0x186560FA0")]
	private static bool OOINPPEFMFD(string HAJHAILJNJH, out Guid CAFIFJFDMJE, out FJEEACACIFP DNIPFFINFGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x65609C0", Offset = "0x655F3C0", VA = "0x1865609C0")]
	private static void OIPFJBPMDHK(PPDGLIGMGBC EIFFMACPBMC, StringBuilder EHMGKLPLEBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x36864B0", Offset = "0x3684EB0", VA = "0x1836864B0", Slot = "16")]
	public bool PKGDJNADAFB<T>(FJEEACACIFP DNIPFFINFGB, KHDLFIFCBPJ OBINJPODAFH, bool CFDAOEONPIF, T NMPNMHNJPAA) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x6561100", Offset = "0x655FB00", VA = "0x186561100")]
	private void PBLJPANADIC(FJEEACACIFP DNIPFFINFGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x655EEB0", Offset = "0x655D8B0", VA = "0x18655EEB0")]
	private bool INOLJPDHCDM(DLMMMHADHKF KHHBJBINELJ, FJEEACACIFP DNIPFFINFGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x655D850", Offset = "0x655C250", VA = "0x18655D850")]
	internal KOBDFDOJFEG DCLEDPMJJNH(DLMMMHADHKF KHHBJBINELJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x655DFA0", Offset = "0x655C9A0", VA = "0x18655DFA0", Slot = "13")]
	public IReadOnlyList<MIACBIKKOJM> FMMJAEIFLDG(DLMMMHADHKF KHHBJBINELJ, bool OOGNBMOAGBL = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x655DB70", Offset = "0x655C570", VA = "0x18655DB70")]
	internal IReadOnlyList<KOBDFDOJFEG> DICGNBEGHIP(DLMMMHADHKF KHHBJBINELJ, bool OOGNBMOAGBL = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x655FD90", Offset = "0x655E790", VA = "0x18655FD90")]
	private void MLNICBHPCCH(NMFCNLLMADP AIKCOOJNBMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x655EED0", Offset = "0x655D8D0", VA = "0x18655EED0")]
	private static bool IOGAJCIDNOO(KOBDFDOJFEG PBKIGJDKMKN, IReadOnlyDictionary<FJEEACACIFP, KOBDFDOJFEG> JDHAINOFOMM, out IReadOnlyList<KHDLFIFCBPJ> NHMCIDMJNNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x655C600", Offset = "0x655B000", VA = "0x18655C600")]
	[AsyncStateMachine(typeof(KLKGABFDHLK))]
	private static Task BAFDFCEHIEM(ENEJABNNOOD HMJLKIOGPLI, PPDGLIGMGBC EIFFMACPBMC, IReadOnlyDictionary<FJEEACACIFP, KOBDFDOJFEG> JDHAINOFOMM, PLABCCAFOIB KOJCJPGMKLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x655F930", Offset = "0x655E330", VA = "0x18655F930")]
	[CompilerGenerated]
	internal static void LFBBJAPLPMM(Func<LJPEGEGHADM, GAGJECBHKNI> EICOPNLEKPA, ref LMLDEBKIPHK P_1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x6560630", Offset = "0x655F030", VA = "0x186560630")]
	[CompilerGenerated]
	internal static bool NKLIAKLOJIC(FJEEACACIFP DNIPFFINFGB, KHDLFIFCBPJ OBINJPODAFH, out OOBBHJNMIIF BKOCCPIHKNK, ref ACPKJCIPJDI P_3)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface JOOGOGBIELK
{
	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ACHDOFOKCMM(DLMMMHADHKF MKIBNGHJIBI, DLMMMHADHKF CIECDHCHJIP, IEnumerable<DLMMMHADHKF> KNDJPAJBOJP, out CGDJGHJPMKO CDGJKNOOOKN, out CBGMEIPHMAL GJFOJBBHFAM);
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public enum CBGMEIPHMAL : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	InsufficientPermission,
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	DisabledByRoom,
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	CantKickEventOrganizer
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal class EMBGHIOJDBN : JOOGOGBIELK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly AHAPMFLGDDO OLLGBCGFMDO;

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x82DEC0", Offset = "0x82C8C0", VA = "0x18082DEC0")]
	[RecRoom.NoEngine.Common.Preserve]
	public EMBGHIOJDBN([PDHOKDIGCJO(null)] AHAPMFLGDDO HEJIEKADGOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x6557510", Offset = "0x6555F10", VA = "0x186557510")]
	private static HCCLOEKIBAF? IJMMICFGMIK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x6556EF0", Offset = "0x65558F0", VA = "0x186556EF0", Slot = "4")]
	public bool ACHDOFOKCMM(DLMMMHADHKF MKIBNGHJIBI, DLMMMHADHKF CIECDHCHJIP, IEnumerable<DLMMMHADHKF> KNDJPAJBOJP, out CGDJGHJPMKO CDGJKNOOOKN, out CBGMEIPHMAL GJFOJBBHFAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x6557000", Offset = "0x6555A00", VA = "0x186557000")]
	internal bool IHCDAAMNNIO(DLMMMHADHKF MKIBNGHJIBI, DLMMMHADHKF CIECDHCHJIP, IEnumerable<DLMMMHADHKF> KNDJPAJBOJP, ODEDLFDFFLB ECFCIHOBFKA, HCCLOEKIBAF? IJJFLDGJKMN, out CGDJGHJPMKO CDGJKNOOOKN, out CBGMEIPHMAL GJFOJBBHFAM)
	{
		return default(bool);
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
