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
		[Cpp2IlInjected.Address(RVA = "0x78D520", Offset = "0x78C920", VA = "0x18078D520")]
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
		[Cpp2IlInjected.Address(RVA = "0x62B7580", Offset = "0x62B6980", VA = "0x1862B7580")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x78E300", Offset = "0x78D700", VA = "0x18078E300")]
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
		[Cpp2IlInjected.Address(RVA = "0x78E340", Offset = "0x78D740", VA = "0x18078E340")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum IHLLPKDILJL
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Vote,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	Instant,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	Off
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public delegate void MLBNGHFMDFP<TPermission>(TPermission KDIDMEHLBBM);
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void IICAGNOFIEB(KEMOGAOMDFA DAGDNCKDFEF);
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum KJDAEFKJJON
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	Hosts,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Everyone
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface LCDADKABOKP
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool NEPALLGODAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool NHCPOKHIBAC
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool CDPANCLADCN
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool BMBIPFMPNBK
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool JIMGHNBEBAO
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool OADJENEMAMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal static class OBBOJHBKIAL
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[Flags]
	public enum OFJEJKBFKDC
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
	public static readonly Guid ONJLDKIKMAL;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly Guid FLHLCGMBCKO;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly Guid DCLCMNACAHG;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static readonly Guid ELFGLBIGLAN;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public static readonly Guid GAGFIPIAAPD;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static readonly EKPLPHLDHGP<OAIIBDMKGPP, Guid> LAAHLPDKOCE;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	internal static IEnumerable<OAIIBDMKGPP> KPOHEHBEPNN
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x62B7600", Offset = "0x62B6A00", VA = "0x1862B7600")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x62B77C0", Offset = "0x62B6BC0", VA = "0x1862B77C0")]
	public static OAIIBDMKGPP ICGFEMFOMIG(Guid HILDEDLDEPK)
	{
		return default(OAIIBDMKGPP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x62B7960", Offset = "0x62B6D60", VA = "0x1862B7960")]
	public static Guid OAKKMANGCMP(OAIIBDMKGPP CACMCNMBEDN)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x62B7730", Offset = "0x62B6B30", VA = "0x1862B7730")]
	public static bool GDLAMJBFPBP(OAIIBDMKGPP CACMCNMBEDN, [Out] Guid HILDEDLDEPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x62B78C0", Offset = "0x62B6CC0", VA = "0x1862B78C0")]
	public static bool LIMJLAJFPEI(Guid HILDEDLDEPK, [Out] OAIIBDMKGPP CACMCNMBEDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x62B7850", Offset = "0x62B6C50", VA = "0x1862B7850")]
	public static OAIIBDMKGPP LGCGHJLFOGM(OAIIBDMKGPP CACMCNMBEDN)
	{
		return default(OAIIBDMKGPP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x62B7680", Offset = "0x62B6A80", VA = "0x1862B7680")]
	public static OFJEJKBFKDC DCOPIBKODFI(OAIIBDMKGPP LMJDEDMLDJN)
	{
		return default(OFJEJKBFKDC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x62B7880", Offset = "0x62B6C80", VA = "0x1862B7880")]
	internal static OAIIBDMKGPP LGDJAGLOCCF(OFJEJKBFKDC DODCNJKOFOM)
	{
		return default(OAIIBDMKGPP);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface FPJFIEMKFMN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	IBDADEIMEED FLEJBMKHELG
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	IEnumerable<ANCDPOLKLPI> FIPNEDBGAID
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event IICAGNOFIEB AEKOJCLBKGC;

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IReadOnlyList<ANCDPOLKLPI> JLKOMICIHFO(bool DFPAGHDAGII = false);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	ANCDPOLKLPI HJENIODPCLL(KEMOGAOMDFA DAGDNCKDFEF);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool FFFOPLMENDI(KEMOGAOMDFA DAGDNCKDFEF);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IReadOnlyList<ANCDPOLKLPI> GFJBFNJALIN(KEMOGAOMDFA DAGDNCKDFEF, bool EDEJFMCNLBI = false);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool HHDCKAFMGFA(KEMOGAOMDFA MKMIFHDEJKM, OAIIBDMKGPP CACMCNMBEDN);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "9")]
	ANCDPOLKLPI EIMFBPMGIJE(OAIIBDMKGPP CACMCNMBEDN);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool OEJHHMJLCJK<T>(OAIIBDMKGPP CACMCNMBEDN, EBFCCHOBPLA KDIDMEHLBBM, bool BHKJINHPLEC, T LIFDGOACBCI) where T : notnull;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface NEGJFDIFFJH
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task IBJOKMHKNME(KAIKLPKIAEH NDJHINJFLAD, CancellationToken OMFABMCIOAC);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KCFPHCEFIHB(KAIKLPKIAEH NDJHINJFLAD);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface LLIOCPHNEDH
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	KEMOGAOMDFA DIDGKACBIBN
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	BDKFBCEFMIP OCCMLAJCKJH
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	FDKPOLPBLFH ALBJAADNBJC
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<IAJNIDNHHFC> JDKHOIKHDMD;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action GDABIHCPPDN;

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "4")]
	OAIIBDMKGPP BEIBLFODFEB(KEMOGAOMDFA DAGDNCKDFEF);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<IAJNIDNHHFC> OFLDBJOOCNE(CancellationToken OMFABMCIOAC);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task OHDAONNAODH(long BLPLCJENHDJ, long PINPACMDEDH, IReadOnlyList<AIOBEDIPPFK> AHFHPEKHIEC);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IEnumerable<KEMOGAOMDFA> JFBCEBODDOJ();
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class IFCLALNNGPK
{
	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x62AF230", Offset = "0x62AE630", VA = "0x1862AF230")]
	public static OAIIBDMKGPP ELLBHBMNIPL(this LLIOCPHNEDH APCEIFLHKAH)
	{
		return default(OAIIBDMKGPP);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface NMBPMHCNJED<TPermission> where TPermission : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	string EFBEFHMFLMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event MLBNGHFMDFP<TPermission> KIKIFINNGCI;
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal abstract class GLAIBFAEEAJ
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public object? CNNADGJGKHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x764450", Offset = "0x763850", VA = "0x180764450")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x764460", Offset = "0x763860", VA = "0x180764460")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x767650", Offset = "0x766A50", VA = "0x180767650")]
	protected GLAIBFAEEAJ(object? KNGEMOCCJMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool PKEJFAOGFIE(object? LPCGJALKADL);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal class PGCDJMANIGK<T> : GLAIBFAEEAJ where T : notnull, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private T DJIKIHJBMIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly IEqualityComparer<T> MMIDKDDGBBD;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public T OFPAGNFLHNE
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x804D90", Offset = "0x804190", VA = "0x180804D90")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3E43A30", Offset = "0x3E42E30", VA = "0x183E43A30", Slot = "4")]
	public override bool PKEJFAOGFIE(object? LPCGJALKADL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3E434B0", Offset = "0x3E428B0", VA = "0x183E434B0")]
	public bool BNICFOOKFNB(T NGPLCKOIMLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3E43C80", Offset = "0x3E43080", VA = "0x183E43C80")]
	public PGCDJMANIGK(T HBPJMDHPOKO, IEqualityComparer<T> MMIDKDDGBBD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class CKKCLMJJIEA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly Dictionary<EBFCCHOBPLA, bool> DCFMKFCDJAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly Dictionary<EBFCCHOBPLA, GLAIBFAEEAJ> EEINBJGCOIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly MAECBGDAHGJ CNELOAHCBHI;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x62AE1C0", Offset = "0x62AD5C0", VA = "0x1862AE1C0")]
	public CKKCLMJJIEA(MAECBGDAHGJ CNELOAHCBHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x62ADCD0", Offset = "0x62AD0D0", VA = "0x1862ADCD0")]
	public bool AMIGAKNNPNM(EBFCCHOBPLA KDIDMEHLBBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x22075F0", Offset = "0x22069F0", VA = "0x1822075F0")]
	public bool KKHALHNFDFM<T>(EBFCCHOBPLA KDIDMEHLBBM, bool BHKJINHPLEC, T LPCGJALKADL) where T : notnull, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2207220", Offset = "0x2206620", VA = "0x182207220")]
	public (bool, T?) ICPCIMHHCJL<T>(EBFCCHOBPLA KDIDMEHLBBM) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x62ADEE0", Offset = "0x62AD2E0", VA = "0x1862ADEE0")]
	public bool KKHALHNFDFM(EBFCCHOBPLA KDIDMEHLBBM, bool BHKJINHPLEC, object LPCGJALKADL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x62ADE10", Offset = "0x62AD210", VA = "0x1862ADE10")]
	public (bool, object) ICPCIMHHCJL(EBFCCHOBPLA KDIDMEHLBBM)
	{
		return default((bool, object));
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x22071E0", Offset = "0x22065E0", VA = "0x1822071E0")]
	private void CGBEGAKOEGK<T>(EBFCCHOBPLA KDIDMEHLBBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x62ADD40", Offset = "0x62AD140", VA = "0x1862ADD40")]
	private GLAIBFAEEAJ HENAFKIHCKL(EBFCCHOBPLA KDIDMEHLBBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x62ADFC0", Offset = "0x62AD3C0", VA = "0x1862ADFC0")]
	public void NDLFPOMMPAE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal class COEMLNPAEPK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly string NDGMEGMCDLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly Type HJOANHBGKIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly HDCENOEKPLJ LDICMAEEDLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly EBFCCHOBPLA KBELPJJPNOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public IBGAPNALPLE OBFMENPFPOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public BNNEGIAAOLJ CKELBDFNNNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public FMEABDLNMMI HHJPJMHIAGN;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x62AE570", Offset = "0x62AD970", VA = "0x1862AE570")]
	public COEMLNPAEPK(Type FGGIOLDIDKE, string CLCFMOIOBPJ, EBFCCHOBPLA KDIDMEHLBBM, IBGAPNALPLE CPEHFEMCKNK, BNNEGIAAOLJ GKFKFDPGNAC, FMEABDLNMMI JDNJEJOKCLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x62AE520", Offset = "0x62AD920", VA = "0x1862AE520")]
	public object JLOGFOAADHB(object? KEEHOGPOIFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x2208E80", Offset = "0x2208280", VA = "0x182208E80")]
	public void CGBEGAKOEGK<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x62AE470", Offset = "0x62AD870", VA = "0x1862AE470")]
	public void CGBEGAKOEGK(Type EKDJIBLHIED)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
internal class FJAAAODKAJF<T> : COEMLNPAEPK where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal delegate string KOCIHGMJNPI(T LPCGJALKADL);

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	internal delegate T BFFOEOCJOGD(string? EBNIAAOMIJP, T HBPJMDHPOKO);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class GJAHAIHHNBE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public KOCIHGMJNPI serializeRecNetString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public BFFOEOCJOGD parseRecNetString;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public GJAHAIHHNBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x349A6D0", Offset = "0x3499AD0", VA = "0x18349A6D0")]
		internal string KAFCKKHAIGB(object? v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x349A700", Offset = "0x3499B00", VA = "0x18349A700")]
		internal object PKPHNOABFCP(string? s, object d)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x33B56E0", Offset = "0x33B4AE0", VA = "0x1833B56E0")]
	public FJAAAODKAJF(EBFCCHOBPLA KDIDMEHLBBM, string CLCFMOIOBPJ, [Optional] KOCIHGMJNPI? CPEHFEMCKNK, [Optional] BFFOEOCJOGD? GKFKFDPGNAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x33B48C0", Offset = "0x33B3CC0", VA = "0x1833B48C0")]
	private static object? HNNKJEMPCFP(BFFOEOCJOGD? GKFKFDPGNAC, string? EBNIAAOMIJP, object? HBPJMDHPOKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x33B50F0", Offset = "0x33B44F0", VA = "0x1833B50F0")]
	private static string MFIMBGNEKOH(KOCIHGMJNPI? HAPFIOMLBDK, object? LPCGJALKADL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal delegate string IBGAPNALPLE(object? LPCGJALKADL);
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal delegate object BNNEGIAAOLJ(string? EBNIAAOMIJP, [Optional] object HBPJMDHPOKO);
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal delegate GLAIBFAEEAJ FMEABDLNMMI();
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal class MAECBGDAHGJ
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	private class MFCAEKLKKHI : IEqualityComparer<List<string>>
	{
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		internal static MFCAEKLKKHI OMCMBELJBID;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x62B0C50", Offset = "0x62B0050", VA = "0x1862B0C50", Slot = "4")]
		public bool Equals(List<string> DCLOFHDPPBE, List<string> JMNKJKLHIOM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x62B0DA0", Offset = "0x62B01A0", VA = "0x1862B0DA0", Slot = "5")]
		public int GetHashCode(List<string> IBBNLILJNEB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public MFCAEKLKKHI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private class OFBJANIGJGJ : AIHKNEJPOKO<IHLLPKDILJL>
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x62B7E90", Offset = "0x62B7290", VA = "0x1862B7E90", Slot = "9")]
		public override string MFIMBGNEKOH(IHLLPKDILJL INCBMJFBGNP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x62B7CB0", Offset = "0x62B70B0", VA = "0x1862B7CB0", Slot = "10")]
		protected override bool EBKBAEGICKB(string INCBMJFBGNP, [Out] IHLLPKDILJL LPCGJALKADL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x62B7F80", Offset = "0x62B7380", VA = "0x1862B7F80")]
		public OFBJANIGJGJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private static readonly LADMNNKHFPB DMHOOJGIJOG;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static readonly OFBJANIGJGJ EDKKLAFNGFJ;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static readonly List<COEMLNPAEPK> PHLJHOHNAJC;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<EBFCCHOBPLA> MFANONBGDHB
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x764450", Offset = "0x763850", VA = "0x180764450")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public IReadOnlyDictionary<EBFCCHOBPLA, COEMLNPAEPK> JIOMKBAELEN
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x767230", Offset = "0x766630", VA = "0x180767230")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x62B0900", Offset = "0x62AFD00", VA = "0x1862B0900")]
	public MAECBGDAHGJ([Optional] IList<COEMLNPAEPK>? JOKDBKJFIIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x62AF950", Offset = "0x62AED50", VA = "0x1862AF950")]
	public COEMLNPAEPK LMKHMDNKFHB(EBFCCHOBPLA KDIDMEHLBBM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface IBDADEIMEED
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	ANCDPOLKLPI HOPPJCKFCEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal class PAFLIIDGHDE : IBDADEIMEED
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public static PAFLIIDGHDE BJIFPKPBNNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	internal readonly PHOHIOGCLDH HBDBKGOIDBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	internal readonly IReadOnlyList<PHOHIOGCLDH> PJEHBAFBFJC;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public ANCDPOLKLPI HOPPJCKFCEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x764450", Offset = "0x763850", VA = "0x180764450", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x62B8810", Offset = "0x62B7C10", VA = "0x1862B8810")]
	public PAFLIIDGHDE(PHOHIOGCLDH OHCIAOGAFMI, IReadOnlyList<PHOHIOGCLDH> JHJLDFLMGMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x62B7FC0", Offset = "0x62B73C0", VA = "0x1862B7FC0")]
	private static PAFLIIDGHDE LPGAOJLNKNF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class GNFGJAIOHLJ
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static readonly IReadOnlyList<OAIIBDMKGPP> FDBDLAHHMHK;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x62AEF20", Offset = "0x62AE320", VA = "0x1862AEF20")]
	public static bool BICKNENJAHJ(this KEMOGAOMDFA ENPJGNCLGBK, OAIIBDMKGPP CACMCNMBEDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x62AF000", Offset = "0x62AE400", VA = "0x1862AF000")]
	public static bool HAHPFLFFFHN(this KEMOGAOMDFA ENPJGNCLGBK, OAIIBDMKGPP CACMCNMBEDN, FDKPOLPBLFH COJBLDLANGK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface KNPHBDADMAK
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool EBFIPADEEII
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool EJINJBDPCCK
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool CCGBJDOEEIK
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool GGDAKLLFKMI
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool LICOELPOCEE
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool IAMAMPKJJLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool EAKCKHCGCNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool FCJOHPKENBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool LEFPHKHPANB
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool FANHHKFFGCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool ENBOCICFNEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool PGEKEKGEJLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	IReadOnlyList<string> HJIAODJGEGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	IHLLPKDILJL EFAIIIOHFPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface ANCDPOLKLPI : KNPHBDADMAK, LCDADKABOKP, NMBPMHCNJED<EBFCCHOBPLA>
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	string HBPGKFDMNIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	OAIIBDMKGPP DOMFNKDFOBK
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	(bool, T?) NEDJKADMEKJ<T>(EBFCCHOBPLA KDIDMEHLBBM) where T : new();
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public enum EBFCCHOBPLA
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
internal class PHOHIOGCLDH : ANCDPOLKLPI, KNPHBDADMAK, LCDADKABOKP, NMBPMHCNJED<EBFCCHOBPLA>
{
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	internal static readonly MAECBGDAHGJ JIKHLPFLGFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	internal readonly CKKCLMJJIEA JAEHNKMEADG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private string? IIFALNGKKOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private string? HOOODGENCOI;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private bool EJMPJMECOBD
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x62B8920", Offset = "0x62B7D20", VA = "0x1862B8920", Slot = "23")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private bool INBNAEJCPIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x62B9680", Offset = "0x62B8A80", VA = "0x1862B9680", Slot = "22")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	private bool MCJMIKLCAPC
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x62B97C0", Offset = "0x62B8BC0", VA = "0x1862B97C0", Slot = "21")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private bool NPACGHMDINN
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x62B9980", Offset = "0x62B8D80", VA = "0x1862B9980", Slot = "24")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private bool MMIKFBFNBHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x62B8A70", Offset = "0x62B7E70", VA = "0x1862B8A70", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	private bool LMKPALCBCEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x62B9A70", Offset = "0x62B8E70", VA = "0x1862B9A70", Slot = "25")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public OAIIBDMKGPP DOMFNKDFOBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x804D90", Offset = "0x804190", VA = "0x180804D90", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(OAIIBDMKGPP);
		}
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x764440", Offset = "0x763840", VA = "0x180764440")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public string EFBEFHMFLMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x62B96D0", Offset = "0x62B8AD0", VA = "0x1862B96D0", Slot = "29")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x62B9810", Offset = "0x62B8C10", VA = "0x1862B9810")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public string HBPGKFDMNIP
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x62B96D0", Offset = "0x62B8AD0", VA = "0x1862B96D0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool LLNOBIDCPAD
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x7E2C20", Offset = "0x7E2020", VA = "0x1807E2C20")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0xA5A2A0", Offset = "0xA596A0", VA = "0x180A5A2A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool EBFIPADEEII
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x62B99D0", Offset = "0x62B8DD0", VA = "0x1862B99D0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public IHLLPKDILJL EFAIIIOHFPO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x62B9770", Offset = "0x62B8B70", VA = "0x1862B9770", Slot = "20")]
		get
		{
			return default(IHLLPKDILJL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool EJINJBDPCCK
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x62B94E0", Offset = "0x62B88E0", VA = "0x1862B94E0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool CCGBJDOEEIK
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x62BA730", Offset = "0x62B9B30", VA = "0x1862BA730", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool GGDAKLLFKMI
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x62B9860", Offset = "0x62B8C60", VA = "0x1862B9860", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool LICOELPOCEE
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x62B89C0", Offset = "0x62B7DC0", VA = "0x1862B89C0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool IAMAMPKJJLA
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x62B9A20", Offset = "0x62B8E20", VA = "0x1862B9A20", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool EAKCKHCGCNP
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x62BA6E0", Offset = "0x62B9AE0", VA = "0x1862BA6E0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool FCJOHPKENBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x62B9720", Offset = "0x62B8B20", VA = "0x1862B9720", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool LEFPHKHPANB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x62B8AC0", Offset = "0x62B7EC0", VA = "0x1862B8AC0", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public IReadOnlyList<string> HJIAODJGEGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x62B8A10", Offset = "0x62B7E10", VA = "0x1862B8A10", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public bool GCNOEGABGBH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x62B8920", Offset = "0x62B7D20", VA = "0x1862B8920", Slot = "30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public bool IDHAHMNLOFI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x62B8A70", Offset = "0x62B7E70", VA = "0x1862B8A70", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool AFKDPPMMKGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x62B9680", Offset = "0x62B8A80", VA = "0x1862B9680", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool FANHHKFFGCI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x62B9930", Offset = "0x62B8D30", VA = "0x1862B9930", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool ENBOCICFNEH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x62B8B10", Offset = "0x62B7F10", VA = "0x1862B8B10", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool GKEAJGDMHGK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x62B97C0", Offset = "0x62B8BC0", VA = "0x1862B97C0", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool PGEKEKGEJLM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x62B8970", Offset = "0x62B7D70", VA = "0x1862B8970", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool ELPCJKMMIMM
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x62B9980", Offset = "0x62B8D80", VA = "0x1862B9980", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool PMDLAIAINGD
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x62B9A70", Offset = "0x62B8E70", VA = "0x1862B9A70", Slot = "35")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event MLBNGHFMDFP<EBFCCHOBPLA> KIKIFINNGCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x62BA780", Offset = "0x62B9B80", VA = "0x1862BA780", Slot = "27")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x62B9E20", Offset = "0x62B9220", VA = "0x1862B9E20", Slot = "28")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x254D890", Offset = "0x254CC90", VA = "0x18254D890", Slot = "6")]
	public (bool, T?) NEDJKADMEKJ<T>(EBFCCHOBPLA KDIDMEHLBBM) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x254D850", Offset = "0x254CC50", VA = "0x18254D850")]
	public PHOHIOGCLDH GCCPLMNGPOI<T>(EBFCCHOBPLA KDIDMEHLBBM, bool BHKJINHPLEC, T LPCGJALKADL) where T : notnull, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x62BAAD0", Offset = "0x62B9ED0", VA = "0x1862BAAD0")]
	public PHOHIOGCLDH(OAIIBDMKGPP CACMCNMBEDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x62BA8C0", Offset = "0x62B9CC0", VA = "0x1862BA8C0")]
	public PHOHIOGCLDH(OAIIBDMKGPP CACMCNMBEDN, [Optional] string? IIFALNGKKOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x62BA8E0", Offset = "0x62B9CE0", VA = "0x1862BA8E0")]
	public PHOHIOGCLDH(PHOHIOGCLDH LGAHCHLEJFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x62BA970", Offset = "0x62B9D70", VA = "0x1862BA970")]
	internal PHOHIOGCLDH(OAIIBDMKGPP GNPFHGKKALI, [Optional] string? IIFALNGKKOL, [Optional] PHOHIOGCLDH? LGAHCHLEJFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x62B98B0", Offset = "0x62B8CB0", VA = "0x1862B98B0")]
	public static HDCENOEKPLJ IFNEDCEMPGP(EBFCCHOBPLA KDIDMEHLBBM)
	{
		return default(HDCENOEKPLJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x62B9ED0", Offset = "0x62B92D0", VA = "0x1862B9ED0")]
	public void NDLFPOMMPAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x62B9EF0", Offset = "0x62B92F0", VA = "0x1862B9EF0")]
	internal PHOHIOGCLDH OBDIBAPHJEB(PHOHIOGCLDH MMKCMPJEOOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x62BA270", Offset = "0x62B9670", VA = "0x1862BA270")]
	internal IReadOnlyCollection<EBFCCHOBPLA> PCONDBHNLLG(PHOHIOGCLDH LGAHCHLEJFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x62B9D40", Offset = "0x62B9140", VA = "0x1862B9D40")]
	public bool MLEHHLLBPLJ(EBFCCHOBPLA KDIDMEHLBBM, bool BHKJINHPLEC, string LBKHEHNJHCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x62B9580", Offset = "0x62B8980", VA = "0x1862B9580")]
	public (bool, string) FPPFOOOJKCK(EBFCCHOBPLA KDIDMEHLBBM)
	{
		return default((bool, string));
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x62B9530", Offset = "0x62B8930", VA = "0x1862B9530")]
	internal void FFFKDDNLHFB(EBFCCHOBPLA KDIDMEHLBBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x62B9AC0", Offset = "0x62B8EC0", VA = "0x1862B9AC0")]
	public MCEIKFOIDBF LNACCCHMHBP(Func<OAIIBDMKGPP, Guid> CDHGKEKGOMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x62B8B60", Offset = "0x62B7F60", VA = "0x1862B8B60")]
	public void EAHOKPLLNNL(MCEIKFOIDBF HKCBDBBHGJG, Func<Guid, OAIIBDMKGPP> CMKDOFKAILP, [Optional] OAIIBDMKGPP? IEHJEMPPOFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x62B9CB0", Offset = "0x62B90B0", VA = "0x1862B9CB0")]
	[CompilerGenerated]
	private void MEIHNFPEAEE(EBFCCHOBPLA FDNNMHPEIBB, MFGKCKPHBKB HGGOCOENGMG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class NAFKHLEFEEK : NEGJFDIFFJH, FPJFIEMKFMN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class DEJNCMAKKNC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public PHOHIOGCLDH newRole;

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public DEJNCMAKKNC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x62AE610", Offset = "0x62ADA10", VA = "0x1862AE610")]
		internal bool HPELCPKHBMI(PHOHIOGCLDH rc)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class BCPFLMOHGIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public OAIIBDMKGPP roleTypeToUpdate;

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public BCPFLMOHGIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x62ADCC0", Offset = "0x62AD0C0", VA = "0x1862ADCC0")]
		internal bool DMFEJKGOGMJ(OAIIBDMKGPP r)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private struct IPENCLNDDEC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public NAFKHLEFEEK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public KAIKLPKIAEH roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private bool <isOffline>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private TaskAwaiter<IAJNIDNHHFC> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x62AF290", Offset = "0x62AE690", VA = "0x1862AF290", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x62AF8F0", Offset = "0x62AECF0", VA = "0x1862AF8F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class FBDGJNPBJKF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public StringBuilder migrationMessageBuilder;

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public FBDGJNPBJKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x62AE760", Offset = "0x62ADB60", VA = "0x1862AE760")]
		internal void BHJOMFBEJHK(MCEIKFOIDBF r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x62AE640", Offset = "0x62ADA40", VA = "0x1862AE640")]
		internal void AGELNEOEPAG(MCEIKFOIDBF r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct HANDPLJHBOA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public KAIKLPKIAEH roomData;
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class FHIDDHCHFHJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public Func<MCEIKFOIDBF, MFGKCKPHBKB> dataFunc;

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public FHIDDHCHFHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x62AE840", Offset = "0x62ADC40", VA = "0x1862AE840")]
		internal void BOPBJAPNBEJ(MCEIKFOIDBF r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x62AE8A0", Offset = "0x62ADCA0", VA = "0x1862AE8A0")]
		internal void KOBPGOPEBBD(MCEIKFOIDBF r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x62AE870", Offset = "0x62ADC70", VA = "0x1862AE870")]
		internal void EBJLDLGJBDO(MCEIKFOIDBF r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class EAGCKDKLNMI<T> where T : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		private struct <<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000084")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000085")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			public EAGCKDKLNMI<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			private object <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			private int <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			private TaskAwaiter<IAJNIDNHHFC> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x2EB46E0", Offset = "0x2EB3AE0", VA = "0x182EB46E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x82FC80", Offset = "0x82F080", VA = "0x18082FC80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public NAFKHLEFEEK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public EBFCCHOBPLA rolePermission;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public OAIIBDMKGPP accountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public HDCENOEKPLJ recNetPermissionType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public string serializedNewValue;

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public EAGCKDKLNMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x3015210", Offset = "0x3014610", VA = "0x183015210")]
		[AsyncStateMachine(typeof(EAGCKDKLNMI<>.<<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d))]
		internal void KFEIPIHIAJG()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct KGOIKIAMDDJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public IReadOnlyList<AIOBEDIPPFK> newPermissionOverrides;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct NKIEPIEOHKM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public LLIOCPHNEDH rolesDataProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public KAIKLPKIAEH roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public IReadOnlyDictionary<OAIIBDMKGPP, PHOHIOGCLDH> defaultRoles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public MEFINKCPADA debugLogger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x62B6A10", Offset = "0x62B5E10", VA = "0x1862B6A10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x62B7520", Offset = "0x62B6920", VA = "0x1862B7520", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private readonly LLIOCPHNEDH APCEIFLHKAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private readonly PAFLIIDGHDE CDBGAJHAKAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly MEFINKCPADA FKKIEMBAOGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly Dictionary<int, PHOHIOGCLDH> AGMIOECOCDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	internal readonly Dictionary<OAIIBDMKGPP, PHOHIOGCLDH> ELBAJCEPMKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	internal readonly Dictionary<OAIIBDMKGPP, PHOHIOGCLDH> CKNJJEEGHIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	internal readonly List<PHOHIOGCLDH> ICEDMPFJMID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private bool HEOHDBMFOHO;

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private static readonly EBFCCHOBPLA[] KKCHNCGMMBI;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public IBDADEIMEED FLEJBMKHELG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x767230", Offset = "0x766630", VA = "0x180767230", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public IEnumerable<ANCDPOLKLPI> FIPNEDBGAID
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x62B2DE0", Offset = "0x62B21E0", VA = "0x1862B2DE0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event IICAGNOFIEB AEKOJCLBKGC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x62B3230", Offset = "0x62B2630", VA = "0x1862B3230", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x62B0F90", Offset = "0x62B0390", VA = "0x1862B0F90", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x62B3350", Offset = "0x62B2750", VA = "0x1862B3350")]
	[DCEDJGMCFCN(HKDEIDHACLB.Room, IIPPAMCLFBJ.None)]
	private static void KAGIJELEALE(BFGBHKPNKEI AFJFOILCBOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x62B6750", Offset = "0x62B5B50", VA = "0x1862B6750")]
	[UnityEngine.Scripting.Preserve]
	internal NAFKHLEFEEK([LMAFJMDCBJO(null)] LLIOCPHNEDH HEABDDJGBAP, [LMAFJMDCBJO(null)] PAFLIIDGHDE EEDLHPBLGMK, [LMAFJMDCBJO(null)] MEFINKCPADA FKKIEMBAOGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x62B1A00", Offset = "0x62B0E00", VA = "0x1862B1A00", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x62B5D00", Offset = "0x62B5100", VA = "0x1862B5D00")]
	private void PEMFDPEJPFB(IEnumerable<PHOHIOGCLDH> IFJGLKIEHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x62B1F70", Offset = "0x62B1370", VA = "0x1862B1F70", Slot = "12")]
	public bool FFFOPLMENDI(KEMOGAOMDFA DAGDNCKDFEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x62B23C0", Offset = "0x62B17C0", VA = "0x1862B23C0")]
	private void GDABIHCPPDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x62B2E30", Offset = "0x62B2230", VA = "0x1862B2E30")]
	private void INJEJGJMDGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x62B32D0", Offset = "0x62B26D0", VA = "0x1862B32D0", Slot = "10")]
	public IReadOnlyList<ANCDPOLKLPI> JLKOMICIHFO(bool DFPAGHDAGII = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x62B2BB0", Offset = "0x62B1FB0", VA = "0x1862B2BB0", Slot = "11")]
	public ANCDPOLKLPI HJENIODPCLL(KEMOGAOMDFA DAGDNCKDFEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x62B1BB0", Offset = "0x62B0FB0", VA = "0x1862B1BB0")]
	private OAIIBDMKGPP EINLLLBGBDE(KEMOGAOMDFA DAGDNCKDFEF)
	{
		return default(OAIIBDMKGPP);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x62B2A20", Offset = "0x62B1E20", VA = "0x1862B2A20", Slot = "14")]
	public bool HHDCKAFMGFA(KEMOGAOMDFA MKMIFHDEJKM, OAIIBDMKGPP CACMCNMBEDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x62B1B10", Offset = "0x62B0F10", VA = "0x1862B1B10", Slot = "15")]
	public ANCDPOLKLPI EIMFBPMGIJE(OAIIBDMKGPP CACMCNMBEDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x62B2680", Offset = "0x62B1A80", VA = "0x1862B2680")]
	private static bool GMJDMPLOGHH(FBLDNKDKIMH HODHNDDMGLC, OAIIBDMKGPP CACMCNMBEDN, [Out] MCEIKFOIDBF? LGEFMPEKKHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x62B22D0", Offset = "0x62B16D0", VA = "0x1862B22D0")]
	private static void FGMPAAFDHAE(FBLDNKDKIMH HODHNDDMGLC, Action<MCEIKFOIDBF> JJEBDJIMCKC, OAIIBDMKGPP MGNJELDMPJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x62B2040", Offset = "0x62B1440", VA = "0x1862B2040")]
	private static void FGMPAAFDHAE(FBLDNKDKIMH HODHNDDMGLC, Action<MCEIKFOIDBF> JJEBDJIMCKC, Predicate<OAIIBDMKGPP> IEOCDICJMCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x62B29B0", Offset = "0x62B1DB0", VA = "0x1862B29B0")]
	private void GNAOFIFFNFP(KEMOGAOMDFA DAGDNCKDFEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x62B2CC0", Offset = "0x62B20C0", VA = "0x1862B2CC0", Slot = "4")]
	[AsyncStateMachine(typeof(IPENCLNDDEC))]
	public Task IBJOKMHKNME([CanBeNull] KAIKLPKIAEH NDJHINJFLAD, CancellationToken OMFABMCIOAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "5")]
	public void KCFPHCEFIHB(KAIKLPKIAEH NDJHINJFLAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x62B5280", Offset = "0x62B4680", VA = "0x1862B5280")]
	private void OEFGKBNAIHN(FBLDNKDKIMH EMCKBMBKCMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x62B1C70", Offset = "0x62B1070", VA = "0x1862B1C70")]
	internal static string ELPNPCNLGLD(LLIOCPHNEDH APCEIFLHKAH, KAIKLPKIAEH NDJHINJFLAD, IReadOnlyDictionary<OAIIBDMKGPP, PHOHIOGCLDH> ELBAJCEPMKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x62B3510", Offset = "0x62B2910", VA = "0x1862B3510")]
	private static void KIBCLNNHODD(KAIKLPKIAEH NDJHINJFLAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x62B4320", Offset = "0x62B3720", VA = "0x1862B4320")]
	private static void LADNMIGKOJD(FBLDNKDKIMH MBNGHOCPFOE, IReadOnlyDictionary<OAIIBDMKGPP, PHOHIOGCLDH> ELBAJCEPMKK, StringBuilder FAJNGICILPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x62B5170", Offset = "0x62B4570", VA = "0x1862B5170")]
	private static bool NPJLIJPDIPL(string GOLHMKIPJID, [Out] Guid LANMMJAGNGO, [Out] OAIIBDMKGPP CACMCNMBEDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x62B55C0", Offset = "0x62B49C0", VA = "0x1862B55C0")]
	private static void OJPDONLGJKC(KAIKLPKIAEH NDJHINJFLAD, StringBuilder FAJNGICILPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x24D79D0", Offset = "0x24D6DD0", VA = "0x1824D79D0", Slot = "16")]
	public bool OEJHHMJLCJK<T>(OAIIBDMKGPP CACMCNMBEDN, EBFCCHOBPLA KDIDMEHLBBM, bool BHKJINHPLEC, T LIFDGOACBCI) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x62B3020", Offset = "0x62B2420", VA = "0x1862B3020")]
	private void IOBBOFIFLJK(OAIIBDMKGPP CACMCNMBEDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x62B1380", Offset = "0x62B0780", VA = "0x1862B1380")]
	private bool AMDJJEMBFLK(KEMOGAOMDFA DAGDNCKDFEF, OAIIBDMKGPP CACMCNMBEDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x62B1030", Offset = "0x62B0430", VA = "0x1862B1030")]
	internal PHOHIOGCLDH AHIAPPFFLGG(KEMOGAOMDFA DAGDNCKDFEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x62B23D0", Offset = "0x62B17D0", VA = "0x1862B23D0", Slot = "13")]
	public IReadOnlyList<ANCDPOLKLPI> GFJBFNJALIN(KEMOGAOMDFA DAGDNCKDFEF, bool EDEJFMCNLBI = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x62B14E0", Offset = "0x62B08E0", VA = "0x1862B14E0")]
	internal IReadOnlyList<PHOHIOGCLDH> COPELOJKCFE(KEMOGAOMDFA DAGDNCKDFEF, bool EDEJFMCNLBI = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x62B4670", Offset = "0x62B3A70", VA = "0x1862B4670")]
	private void MJFHHBAPLGE(IAJNIDNHHFC LDKDGLMAIDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x62B1710", Offset = "0x62B0B10", VA = "0x1862B1710")]
	private static bool DNOJCMIPJDH(PHOHIOGCLDH KLPNBNAMCNP, IReadOnlyDictionary<OAIIBDMKGPP, PHOHIOGCLDH> ELBAJCEPMKK, [Out] IReadOnlyList<EBFCCHOBPLA> LDMGHEGIDHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x62B13A0", Offset = "0x62B07A0", VA = "0x1862B13A0")]
	[AsyncStateMachine(typeof(NKIEPIEOHKM))]
	private static Task BAKFLBNAGIG(LLIOCPHNEDH APCEIFLHKAH, KAIKLPKIAEH NDJHINJFLAD, IReadOnlyDictionary<OAIIBDMKGPP, PHOHIOGCLDH> ELBAJCEPMKK, MEFINKCPADA FKKIEMBAOGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x62B23E0", Offset = "0x62B17E0", VA = "0x1862B23E0")]
	[CompilerGenerated]
	internal static void GGLFEEPFOHO(Func<MCEIKFOIDBF, MFGKCKPHBKB> BFOJHMLOKLH, HANDPLJHBOA P_1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x62B4E00", Offset = "0x62B4200", VA = "0x1862B4E00")]
	[CompilerGenerated]
	internal static bool NMNBGGLEOCK(OAIIBDMKGPP CACMCNMBEDN, EBFCCHOBPLA KDIDMEHLBBM, [Out] AIOBEDIPPFK PJIGEOCNCKE, KGOIKIAMDDJ P_3)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface KAPAIEPCBAJ
{
	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KIBFEPOGCGE(KEMOGAOMDFA JEPALJDEHNB, KEMOGAOMDFA HMMOEPGACDL, IEnumerable<KEMOGAOMDFA> KAMEHNKMPOA, [Out] IHLLPKDILJL BANNJLGMODB, [Out] DJDNLPLOCIC MGHGNMKDDHK);
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public enum DJDNLPLOCIC : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	InsufficientPermission,
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	DisabledByRoom,
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	CantKickEventOrganizer
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal class FOKCFAGPPEN : KAPAIEPCBAJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly FPJFIEMKFMN IJNBECCICIL;

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x767650", Offset = "0x766A50", VA = "0x180767650")]
	[RecRoom.NoEngine.Common.Preserve]
	public FOKCFAGPPEN([LMAFJMDCBJO(null)] FPJFIEMKFMN IEFBKHBOEPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x62AE8D0", Offset = "0x62ADCD0", VA = "0x1862AE8D0")]
	private static DAIFBCEANDC? CHLILMOEHOG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x62AE910", Offset = "0x62ADD10", VA = "0x1862AE910", Slot = "4")]
	public bool KIBFEPOGCGE(KEMOGAOMDFA JEPALJDEHNB, KEMOGAOMDFA HMMOEPGACDL, IEnumerable<KEMOGAOMDFA> KAMEHNKMPOA, [Out] IHLLPKDILJL BANNJLGMODB, [Out] DJDNLPLOCIC MGHGNMKDDHK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x62AEA10", Offset = "0x62ADE10", VA = "0x1862AEA10")]
	internal bool OICMCECJDCG(KEMOGAOMDFA JEPALJDEHNB, KEMOGAOMDFA HMMOEPGACDL, IEnumerable<KEMOGAOMDFA> KAMEHNKMPOA, FDKPOLPBLFH COJBLDLANGK, DAIFBCEANDC? ADFEHFCLEII, [Out] IHLLPKDILJL BANNJLGMODB, [Out] DJDNLPLOCIC MGHGNMKDDHK)
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
