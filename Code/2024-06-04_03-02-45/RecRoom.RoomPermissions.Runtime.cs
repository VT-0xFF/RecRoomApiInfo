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
		[Cpp2IlInjected.Address(RVA = "0x86CBD0", Offset = "0x86B3D0", VA = "0x18086CBD0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6F478E0", Offset = "0x6F460E0", VA = "0x186F478E0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x86D840", Offset = "0x86C040", VA = "0x18086D840")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x86D880", Offset = "0x86C080", VA = "0x18086D880")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum HJECDCJNAMJ
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Vote,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	Instant,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	Off
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public delegate void JGEBNDFGOMI<TPermission>(TPermission LLMDLBHHKGI);
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void MCHBKDGCNBP(KCMOAPDBFGB PENGDIMNCLF);
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum JPFPDLDLGEN
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	Hosts,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Everyone
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface MJMJPGJHGCM
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool EMPINNNLEMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool IIKKCAJCHDP
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool MMJOMPDIPII
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool IGJAJKKEEAO
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool NMMPCPNEAPA
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool JPHKEDDLNPF
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal static class LBGMMNODNGJ
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[Flags]
	public enum NMGGIHBKPHP
	{
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		AG_EVERYONE = 0,
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		AG_CREATOR = 0x200000,
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		AG_COOWNER = 0x400000,
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		AG_HOST = 0x800000,
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		AG_MODERATOR = 0x1000000
	}

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static readonly Guid AHBMPEDJDBF;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly Guid JNOEGLELFHJ;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly Guid GDKONEKKJJI;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static readonly Guid IBLKLMKJJMF;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public static readonly Guid DFHOHHEPFBD;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static readonly Guid JJDBPOCNECC;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly EHLMNKGOHPH<CDGDFMGKCOP, Guid> JAFDJGPJNEF;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	internal static IEnumerable<CDGDFMGKCOP> BBPIHGEPFMM
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6F441A0", Offset = "0x6F429A0", VA = "0x186F441A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6F44110", Offset = "0x6F42910", VA = "0x186F44110")]
	public static CDGDFMGKCOP CIEJJOBGCNM(Guid PGOHCHKMLGH)
	{
		return default(CDGDFMGKCOP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6F443A0", Offset = "0x6F42BA0", VA = "0x186F443A0")]
	public static Guid OKGDHIDMNEI(CDGDFMGKCOP ILHCIBLFOIC)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6F44040", Offset = "0x6F42840", VA = "0x186F44040")]
	public static bool BGHEMMBPPPB(CDGDFMGKCOP ILHCIBLFOIC, [Out] Guid PGOHCHKMLGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6F44300", Offset = "0x6F42B00", VA = "0x186F44300")]
	public static bool MEPKLGOKMPG(Guid PGOHCHKMLGH, [Out] CDGDFMGKCOP ILHCIBLFOIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6F44210", Offset = "0x6F42A10", VA = "0x186F44210")]
	public static CDGDFMGKCOP EHKDIDELPCK(CDGDFMGKCOP ILHCIBLFOIC)
	{
		return default(CDGDFMGKCOP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6F44250", Offset = "0x6F42A50", VA = "0x186F44250")]
	public static NMGGIHBKPHP JGHKJIHIMCD(CDGDFMGKCOP JHAFDBHNPIN)
	{
		return default(NMGGIHBKPHP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6F440D0", Offset = "0x6F428D0", VA = "0x186F440D0")]
	internal static CDGDFMGKCOP CELNOLEKICK(NMGGIHBKPHP EHLPNJLJFEA)
	{
		return default(CDGDFMGKCOP);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface KMEPDLIABIH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	ILCKHAKAHLM GJMJENEEOLE
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	IEnumerable<BENDLKLDEMG> CHBODLPAKJH
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event MCHBKDGCNBP DAEGIJPPFOC;

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IReadOnlyList<BENDLKLDEMG> IOJHLIBNFBD(bool OIDDPHHNJIP = false);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	BENDLKLDEMG NDMDLGLEDME(KCMOAPDBFGB PENGDIMNCLF);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool OMLDCOOPADB(KCMOAPDBFGB PENGDIMNCLF);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IReadOnlyList<BENDLKLDEMG> FIAPBOLEFPM(KCMOAPDBFGB PENGDIMNCLF, bool EJKBMPLBKEH = false);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool OJINNEBCLOJ(KCMOAPDBFGB LLHMBFFMBEL, CDGDFMGKCOP ILHCIBLFOIC);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "9")]
	BENDLKLDEMG IAGIDOJKEIF(CDGDFMGKCOP ILHCIBLFOIC);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool IKCOMJBDPOO<T>(CDGDFMGKCOP ILHCIBLFOIC, KDPKFDCNFIC LLMDLBHHKGI, bool PDBILGFAMKK, T NIFGNHBNLFL, [Optional] Action GDOAJHGNONH) where T : notnull;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "11")]
	string HALDIELIOIA(KDPKFDCNFIC LLMDLBHHKGI);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface PMBBCNFDDCF
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task MEOAHJMCDBO(JGEEHKGDOJK OLHDNFLDIIE, CancellationToken ODNHMAMKFFP);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MLKJPHJHBHB(JGEEHKGDOJK OLHDNFLDIIE);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface EHFIELOHEFL
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	KCMOAPDBFGB JHOIDJKOAFG
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	PCHMOHFEPBH NFOIJFLPELE
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	APGABJIFLDK BOCKMGLILID
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<CGAIHMMGDJF> CKLJPNCDKIH;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action DFKKEBIBOLC;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	CDGDFMGKCOP FMOAGLLIMHC(KCMOAPDBFGB PENGDIMNCLF);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<CGAIHMMGDJF> BPNHDKEHIAA(CancellationToken ODNHMAMKFFP);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task JDHHKMHJFPO(long LNOJCNCBDMF, IReadOnlyList<EJFFFDIPMEC> ABCEFJIJEML);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task EKJHFGPCGLI(long LNOJCNCBDMF, long EIPINGDKEKJ, IReadOnlyList<EJFFFDIPMEC> ABCEFJIJEML);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IEnumerable<KCMOAPDBFGB> NCFGNHPBPPI();
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class FIFDGFDOJOG
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6F3D5A0", Offset = "0x6F3BDA0", VA = "0x186F3D5A0")]
	public static CDGDFMGKCOP PJBJOPALNIL(this EHFIELOHEFL NPFIAKPODPH)
	{
		return default(CDGDFMGKCOP);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface PFLAPOEINPL<TPermission> where TPermission : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	string IFJLHHNMKNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event JGEBNDFGOMI<TPermission> OPPFAOGHDID;
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal abstract class AGEABNDPIAO
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public object? PBOJLIHLPDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x846800", Offset = "0x845000", VA = "0x180846800")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8467F0", Offset = "0x844FF0", VA = "0x1808467F0")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x8468E0", Offset = "0x8450E0", VA = "0x1808468E0")]
	protected AGEABNDPIAO(object? OLLEACDHEGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool KBAHBKICJCG(object? IPHHABIKCHD);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal class HGPJKHLOFOC<T> : AGEABNDPIAO where T : notnull, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private T FEHDNFDEPOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly IEqualityComparer<T> DLJFDIOPEMA;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public T JDDKPJKLOJP
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8E2F40", Offset = "0x8E1740", VA = "0x1808E2F40")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x3CABBF0", Offset = "0x3CAA3F0", VA = "0x183CABBF0", Slot = "4")]
	public override bool KBAHBKICJCG(object? IPHHABIKCHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3CAC030", Offset = "0x3CAA830", VA = "0x183CAC030")]
	public bool MOKGGAAHIJO(T JBJNDPLMKBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x3CAC460", Offset = "0x3CAAC60", VA = "0x183CAC460")]
	public HGPJKHLOFOC(T HLCNDDGKJJF, IEqualityComparer<T> DLJFDIOPEMA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class KJBHDGFOHHB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly Dictionary<KDPKFDCNFIC, bool> FOFLFEBFCEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly Dictionary<KDPKFDCNFIC, AGEABNDPIAO> COFAFCJLFDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly EDFAHLKMOBA GMCAHNFGHLL;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6F43D80", Offset = "0x6F42580", VA = "0x186F43D80")]
	public KJBHDGFOHHB(EDFAHLKMOBA GMCAHNFGHLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6F43A40", Offset = "0x6F42240", VA = "0x186F43A40")]
	public bool COIALPLCFIO(KDPKFDCNFIC LLMDLBHHKGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2B28F90", Offset = "0x2B27790", VA = "0x182B28F90")]
	public bool CNJPLJOFNLH<T>(KDPKFDCNFIC LLMDLBHHKGI, bool PDBILGFAMKK, T IPHHABIKCHD) where T : notnull, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2B29510", Offset = "0x2B27D10", VA = "0x182B29510")]
	public (bool, T?) JFCOBCFOGMJ<T>(KDPKFDCNFIC LLMDLBHHKGI) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6F43960", Offset = "0x6F42160", VA = "0x186F43960")]
	public bool CNJPLJOFNLH(KDPKFDCNFIC LLMDLBHHKGI, bool PDBILGFAMKK, object IPHHABIKCHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6F43AB0", Offset = "0x6F422B0", VA = "0x186F43AB0")]
	public (bool, object) JFCOBCFOGMJ(KDPKFDCNFIC LLMDLBHHKGI)
	{
		return default((bool, object));
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2B28F30", Offset = "0x2B27730", VA = "0x182B28F30")]
	private void CALGDHMICGK<T>(KDPKFDCNFIC LLMDLBHHKGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6F43890", Offset = "0x6F42090", VA = "0x186F43890")]
	private AGEABNDPIAO CKDCEKFEAIC(KDPKFDCNFIC LLMDLBHHKGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6F43B80", Offset = "0x6F42380", VA = "0x186F43B80")]
	public void MEHMLOPLAME()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal class BPJLDNLEKPM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly string DHCMDJCLOOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly Type KBJHNIHFNPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly DBMIIPKDNDG CDDMEJKOIJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly KDPKFDCNFIC DCFJHKACJIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public AEHOFEBDNJF DGIFFOICEBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public CJKIFOHJMCE EAHHDCGFGIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public JLLFJHBJPJD FNPCAPMOMJJ;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6F3AD90", Offset = "0x6F39590", VA = "0x186F3AD90")]
	public BPJLDNLEKPM(Type LBIJANKGFKM, string AKFEKJBHCJF, KDPKFDCNFIC LLMDLBHHKGI, AEHOFEBDNJF INHOCPHHHLO, CJKIFOHJMCE HPECLCNPCEO, JLLFJHBJPJD KEMFIDFAJKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6F3AD40", Offset = "0x6F39540", VA = "0x186F3AD40")]
	public object HBKFGOGOHHN(object? OGFCKBADKBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x2840DA0", Offset = "0x283F5A0", VA = "0x182840DA0")]
	public void CALGDHMICGK<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6F3AC90", Offset = "0x6F39490", VA = "0x186F3AC90")]
	public void CALGDHMICGK(Type FPLBKDMADFI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
internal class KGBOCPAFBCO<T> : BPJLDNLEKPM where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal delegate string MNKMNALKKFO(T IPHHABIKCHD);

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	internal delegate T MCMPCEDLOJI(string? CNCMJLJHCPD, T HLCNDDGKJJF);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class KFPIEEPGKNO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public MNKMNALKKFO serializeRecNetString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public MCMPCEDLOJI parseRecNetString;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public KFPIEEPGKNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x4094AA0", Offset = "0x40932A0", VA = "0x184094AA0")]
		internal string GNBKHIKCGNL(object? v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x40949E0", Offset = "0x40931E0", VA = "0x1840949E0")]
		internal object FNPIMCPCNPM(string? s, object d)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x40963F0", Offset = "0x4094BF0", VA = "0x1840963F0")]
	public KGBOCPAFBCO(KDPKFDCNFIC LLMDLBHHKGI, string AKFEKJBHCJF, [Optional] MNKMNALKKFO? INHOCPHHHLO, [Optional] MCMPCEDLOJI? HPECLCNPCEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x40956F0", Offset = "0x4093EF0", VA = "0x1840956F0")]
	private static object? PKPMANIAHDL(MCMPCEDLOJI? HPECLCNPCEO, string? CNCMJLJHCPD, object? HLCNDDGKJJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x40950E0", Offset = "0x40938E0", VA = "0x1840950E0")]
	private static string HNAIEAEAFJH(MNKMNALKKFO? MIAIKKLDINO, object? IPHHABIKCHD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal delegate string AEHOFEBDNJF(object? IPHHABIKCHD);
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal delegate object CJKIFOHJMCE(string? CNCMJLJHCPD, [Optional] object HLCNDDGKJJF);
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal delegate AGEABNDPIAO JLLFJHBJPJD();
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal class EDFAHLKMOBA
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	private class LKOFGDBKJDB : IEqualityComparer<List<string>>
	{
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		internal static LKOFGDBKJDB DCEJKJKKEPJ;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6F44A40", Offset = "0x6F43240", VA = "0x186F44A40", Slot = "4")]
		public bool Equals(List<string> PNGIKMLKECD, List<string> MADKMAGKKBH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6F44B90", Offset = "0x6F43390", VA = "0x186F44B90", Slot = "5")]
		public int GetHashCode(List<string> GHDJADLHPAA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public LKOFGDBKJDB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private class LKIJMMELMJE : FFHFKJBODJB<HJECDCJNAMJ>
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6F44730", Offset = "0x6F42F30", VA = "0x186F44730", Slot = "9")]
		public override string HNAIEAEAFJH(HJECDCJNAMJ FDJIPPJKNDH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6F44820", Offset = "0x6F43020", VA = "0x186F44820", Slot = "10")]
		protected override bool KAIIHOJPNEF(string FDJIPPJKNDH, [Out] HJECDCJNAMJ IPHHABIKCHD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6F44A00", Offset = "0x6F43200", VA = "0x186F44A00")]
		public LKIJMMELMJE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static readonly NMBKMKOAFPF LLGPDHOENKJ;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private static readonly LKIJMMELMJE GABCCGGEGNC;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private static readonly List<BPJLDNLEKPM> CFJDEFBMDLI;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<KDPKFDCNFIC> MLCFFBNKMKE
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x846800", Offset = "0x845000", VA = "0x180846800")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public IReadOnlyDictionary<KDPKFDCNFIC, BPJLDNLEKPM> OPNHFKAGNLD
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x847510", Offset = "0x845D10", VA = "0x180847510")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6F3D280", Offset = "0x6F3BA80", VA = "0x186F3D280")]
	public EDFAHLKMOBA([Optional] IList<BPJLDNLEKPM>? NPOENNJCOLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6F3BD80", Offset = "0x6F3A580", VA = "0x186F3BD80")]
	public BPJLDNLEKPM PMFFIKOCEFP(KDPKFDCNFIC LLMDLBHHKGI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface ILCKHAKAHLM
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	BENDLKLDEMG OLKEODIANKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal class DCENKGFNCMA : ILCKHAKAHLM
{
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static DCENKGFNCMA KBIIBPACOMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	internal readonly NAHFILNBHGL PMGGDLGJPCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	internal readonly IReadOnlyList<NAHFILNBHGL> LFJOHNLACMF;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public BENDLKLDEMG OLKEODIANKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x846800", Offset = "0x845000", VA = "0x180846800", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6F3BC70", Offset = "0x6F3A470", VA = "0x186F3BC70")]
	public DCENKGFNCMA(NAHFILNBHGL INBGMHCNNOJ, IReadOnlyList<NAHFILNBHGL> FOBJAPMFNIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6F3AE30", Offset = "0x6F39630", VA = "0x186F3AE30")]
	private static DCENKGFNCMA PJEGOIMEFAD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class MOLLOIPEOIM
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public static readonly IReadOnlyList<CDGDFMGKCOP> GBEODCANPLB;

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6F454C0", Offset = "0x6F43CC0", VA = "0x186F454C0")]
	public static bool KKBHAOGACBM(this KCMOAPDBFGB GBDHHGKEDDM, CDGDFMGKCOP ILHCIBLFOIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6F45440", Offset = "0x6F43C40", VA = "0x186F45440")]
	public static bool GCFPPCEGMDC(this KCMOAPDBFGB GBDHHGKEDDM, CDGDFMGKCOP ILHCIBLFOIC, APGABJIFLDK HHIDENNENFF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface IOEJPLFALPO
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool MGHOKOFDHPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool BGLBNOEECDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool OIEMDDDCKJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool DAKEMDDCBBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool KBAEHBHGEMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool BOKDJBJCPKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool EHOCKPEKIBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool MAGJGOHGFDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool OFHNGIBHFGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool EKKLAHFGCEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool EDGOAIIHJOC
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool BFMFGEOCIIM
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	IReadOnlyList<string> MBIMHEDCPNO
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	HJECDCJNAMJ EFLJMHDJJPP
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface BENDLKLDEMG : IOEJPLFALPO, MJMJPGJHGCM, PFLAPOEINPL<KDPKFDCNFIC>
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	string CKBABMJGKAC
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	CDGDFMGKCOP BIBKFNJPLHA
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "2")]
	(bool, T?) GLPENDCAAKF<T>(KDPKFDCNFIC LLMDLBHHKGI) where T : new();
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public enum KDPKFDCNFIC
{
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	INVALID = -1,
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	CAN_EDIT_ROOM_ROLES = 1,
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	VOTE_KICK_PERMISSION = 3,
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	CAN_INVITE = 4,
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	CAN_TALK = 6,
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	CAN_PRINT_PHOTOS = 7,
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	CAN_START_GAMES = 8,
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	CAN_SELF_REVIVE = 9,
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	AUTO_ASSIGNED_GAME_ROLES = 11,
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	CAN_CHANGE_GAME_MODE = 12,
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	CAN_USE_MAKER_PEN = 13,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	CAN_USE_DELETE_ALL_BUTTON = 14,
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	CAN_SAVE_INVENTIONS = 15,
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	DISABLE_MIC_AUTO_MUTE = 16,
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	CAN_END_GAMES_EARLY = 17,
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	CAN_USE_SHARE_CAM = 18,
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	DEPRECATED_CAN_EDIT_CIRCUITS = 19,
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	CAN_SPAWN_INVENTIONS = 20,
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	CAN_SPAWN_CONSUMABLES = 21,
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	CAN_USE_ROOM_RESET_BUTTON = 22,
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	CAN_USE_PLAY_GIZMOS_TOGGLE = 23,
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	AUTO_ASSIGNED_PLAYER_TAGS = 24,
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	CAN_USE_RRS = 25,
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	ROOM_LEVEL_THRESHOLD = 1000,
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	CAN_SAVE_ROOM = 1001,
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	CAN_PUBLISH_ROOM = 1002,
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	CAN_CLONE_ROOM = 1003,
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	CAN_RESTORE_ROOM = 1004,
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	CAN_EDIT_MAIN_ROOM_SETTINGS = 1006,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	CAN_EDIT_ROOM_ECON_SETTINGS = 1007,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	CAN_CREATE_SUBROOMS = 1008,
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	CAN_NAME_SUBROOMS = 1009,
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	CAN_CLONE_SUBROOMS = 1010,
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	CAN_MOVE_SUBROOMS = 1011,
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	CAN_DELETE_SUBROOMS = 1012,
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	CAN_EDIT_SUBROOM_SETTINGS = 1013,
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	CAN_RESET_CLOUD_VARIABLES = 1014,
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	CAN_DELETE_CLOUD_VARIABLES = 1015,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	CAN_EDIT_ROOM_PROGRESSION = 1016,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	CAN_REMOVE_ROOM_BANS = 1017,
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	CAN_ADD_ROOM_BANS = 1018
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal class NAHFILNBHGL : BENDLKLDEMG, IOEJPLFALPO, MJMJPGJHGCM, PFLAPOEINPL<KDPKFDCNFIC>
{
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	internal static readonly EDFAHLKMOBA GNIGDBNENKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	internal readonly KJBHDGFOHHB FAIKHJAGNIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private string? DOJJPDBIHPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private string? ADKBCGDLFLB;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private bool MGNAAFMNBBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x6F46150", Offset = "0x6F44950", VA = "0x186F46150", Slot = "23")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private bool DMKJMDFHNPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x6F47270", Offset = "0x6F45A70", VA = "0x186F47270", Slot = "22")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	private bool JEDPHGNMBIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x6F45AC0", Offset = "0x6F442C0", VA = "0x186F45AC0", Slot = "21")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private bool MLGGBGJIOBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6F45BB0", Offset = "0x6F443B0", VA = "0x186F45BB0", Slot = "24")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private bool LOIFGBMEOEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6F46490", Offset = "0x6F44C90", VA = "0x186F46490", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	private bool MDAECPLAHMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6F45B60", Offset = "0x6F44360", VA = "0x186F45B60", Slot = "25")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public CDGDFMGKCOP BIBKFNJPLHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x8E2F40", Offset = "0x8E1740", VA = "0x1808E2F40", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(CDGDFMGKCOP);
		}
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x84DAC0", Offset = "0x84C2C0", VA = "0x18084DAC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public string IFJLHHNMKNH
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x6F472C0", Offset = "0x6F45AC0", VA = "0x186F472C0", Slot = "29")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x6F461A0", Offset = "0x6F449A0", VA = "0x186F461A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public string CKBABMJGKAC
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x6F472C0", Offset = "0x6F45AC0", VA = "0x186F472C0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool NKOFNEKBFGD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x984EC0", Offset = "0x9836C0", VA = "0x180984EC0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x9846E0", Offset = "0x982EE0", VA = "0x1809846E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool MGHOKOFDHPO
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x6F47360", Offset = "0x6F45B60", VA = "0x186F47360", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public HJECDCJNAMJ EFLJMHDJJPP
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x6F465D0", Offset = "0x6F44DD0", VA = "0x186F465D0", Slot = "20")]
		get
		{
			return default(HJECDCJNAMJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool BGLBNOEECDM
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x6F464E0", Offset = "0x6F44CE0", VA = "0x186F464E0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool OIEMDDDCKJH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x6F47400", Offset = "0x6F45C00", VA = "0x186F47400", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool DAKEMDDCBBG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x6F46530", Offset = "0x6F44D30", VA = "0x186F46530", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool KBAEHBHGEMP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x6F46440", Offset = "0x6F44C40", VA = "0x186F46440", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool BOKDJBJCPKN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x6F47220", Offset = "0x6F45A20", VA = "0x186F47220", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool EHOCKPEKIBD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x6F473B0", Offset = "0x6F45BB0", VA = "0x186F473B0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool MAGJGOHGFDD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x6F471D0", Offset = "0x6F459D0", VA = "0x186F471D0", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool OFHNGIBHFGK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x6F47310", Offset = "0x6F45B10", VA = "0x186F47310", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public IReadOnlyList<string> MBIMHEDCPNO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x6F47050", Offset = "0x6F45850", VA = "0x186F47050", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public bool OIGAAADHNLP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x6F46150", Offset = "0x6F44950", VA = "0x186F46150", Slot = "30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public bool CNKMAONOPAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x6F46490", Offset = "0x6F44C90", VA = "0x186F46490", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool DEMAFIPHGCO
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x6F47270", Offset = "0x6F45A70", VA = "0x186F47270", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool EKKLAHFGCEK
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6F46380", Offset = "0x6F44B80", VA = "0x186F46380", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool EDGOAIIHJOC
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x6F45B10", Offset = "0x6F44310", VA = "0x186F45B10", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool EKDCDIGKMDA
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x6F45AC0", Offset = "0x6F442C0", VA = "0x186F45AC0", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool BFMFGEOCIIM
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x6F46580", Offset = "0x6F44D80", VA = "0x186F46580", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool JFBCPPPMPLI
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x6F45BB0", Offset = "0x6F443B0", VA = "0x186F45BB0", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool MCEEHMFMAEM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x6F45B60", Offset = "0x6F44360", VA = "0x186F45B60", Slot = "35")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event JGEBNDFGOMI<KDPKFDCNFIC> OPPFAOGHDID
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x6F461F0", Offset = "0x6F449F0", VA = "0x186F461F0", Slot = "27")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x6F46620", Offset = "0x6F44E20", VA = "0x186F46620", Slot = "28")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x2BD4620", Offset = "0x2BD2E20", VA = "0x182BD4620", Slot = "6")]
	public (bool, T?) GLPENDCAAKF<T>(KDPKFDCNFIC LLMDLBHHKGI) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x2BD45C0", Offset = "0x2BD2DC0", VA = "0x182BD45C0")]
	public NAHFILNBHGL CEEIAEPPKJH<T>(KDPKFDCNFIC LLMDLBHHKGI, bool PDBILGFAMKK, T IPHHABIKCHD) where T : notnull, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6F47840", Offset = "0x6F46040", VA = "0x186F47840")]
	public NAHFILNBHGL(CDGDFMGKCOP ILHCIBLFOIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6F47820", Offset = "0x6F46020", VA = "0x186F47820")]
	public NAHFILNBHGL(CDGDFMGKCOP ILHCIBLFOIC, [Optional] string? DOJJPDBIHPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6F47860", Offset = "0x6F46060", VA = "0x186F47860")]
	public NAHFILNBHGL(NAHFILNBHGL EMJFEJBMMAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x6F476D0", Offset = "0x6F45ED0", VA = "0x186F476D0")]
	internal NAHFILNBHGL(CDGDFMGKCOP MPLHJNELDCG, [Optional] string? DOJJPDBIHPJ, [Optional] NAHFILNBHGL? EMJFEJBMMAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x6F463D0", Offset = "0x6F44BD0", VA = "0x186F463D0")]
	public static DBMIIPKDNDG JBOALJEOMJP(KDPKFDCNFIC LLMDLBHHKGI)
	{
		return default(DBMIIPKDNDG);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x6F471B0", Offset = "0x6F459B0", VA = "0x186F471B0")]
	public void MEHMLOPLAME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x6F45740", Offset = "0x6F43F40", VA = "0x186F45740")]
	internal NAHFILNBHGL ADHPGMOJFOD(NAHFILNBHGL LFKFAEPFBHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6F45C00", Offset = "0x6F44400", VA = "0x186F45C00")]
	internal IReadOnlyCollection<KDPKFDCNFIC> DBMPDAIGBHO(NAHFILNBHGL EMJFEJBMMAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6F46070", Offset = "0x6F44870", VA = "0x186F46070")]
	public bool DJKOBIMPIMC(KDPKFDCNFIC LLMDLBHHKGI, bool PDBILGFAMKK, string ILKBHAAEKPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6F470B0", Offset = "0x6F458B0", VA = "0x186F470B0")]
	public (bool, string) LKPMFDIHOGM(KDPKFDCNFIC LLMDLBHHKGI)
	{
		return default((bool, string));
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x6F46330", Offset = "0x6F44B30", VA = "0x186F46330")]
	internal void IEDNKJMPEDD(KDPKFDCNFIC LLMDLBHHKGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x6F47450", Offset = "0x6F45C50", VA = "0x186F47450")]
	public EMAIKFLOIPH PGHPOCCCICG(Func<CDGDFMGKCOP, Guid> OOHKKHGJGFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x6F466D0", Offset = "0x6F44ED0", VA = "0x186F466D0")]
	public void LJDABCDEKCD(EMAIKFLOIPH DIGFFKKFKOE, Func<Guid, CDGDFMGKCOP> JPEGCJNMDJE, [Optional] CDGDFMGKCOP? IAPGCOJJINI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x6F462A0", Offset = "0x6F44AA0", VA = "0x186F462A0")]
	[CompilerGenerated]
	private void GIKCPKMFILG(KDPKFDCNFIC PNCEKLGGPHN, OKDOFLHDHJI PGDOIGJJJEC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class JOEGIIEKCNM : PMBBCNFDDCF, KMEPDLIABIH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class BFCGJNFONLK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public NAHFILNBHGL newRole;

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public BFCGJNFONLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x6F3AC60", Offset = "0x6F39460", VA = "0x186F3AC60")]
		internal bool EAOJGJJAMEC(NAHFILNBHGL rc)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class KLNBAGPMJEE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public CDGDFMGKCOP roleTypeToUpdate;

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public KLNBAGPMJEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x6F44030", Offset = "0x6F42830", VA = "0x186F44030")]
		internal bool MHNPOEFHLLC(CDGDFMGKCOP r)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private struct MJMOOKJLDOD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public JOEGIIEKCNM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public JGEEHKGDOJK roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private bool <isOffline>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private TaskAwaiter<CGAIHMMGDJF> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x6F44D70", Offset = "0x6F43570", VA = "0x186F44D70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x6F453E0", Offset = "0x6F43BE0", VA = "0x186F453E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class OIIANCNMBFO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public StringBuilder migrationMessageBuilder;

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public OIIANCNMBFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x6F47B10", Offset = "0x6F46310", VA = "0x186F47B10")]
		internal void NIKNNJCDIOA(EMAIKFLOIPH r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x6F479F0", Offset = "0x6F461F0", VA = "0x186F479F0")]
		internal void EADENPIFKDI(EMAIKFLOIPH r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct NMEEHNIJADF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public JGEEHKGDOJK roomData;
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class OFMDJOMIOMI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public Func<EMAIKFLOIPH, OKDOFLHDHJI> dataFunc;

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public OFMDJOMIOMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x6F47960", Offset = "0x6F46160", VA = "0x186F47960")]
		internal void BFBOCMEHPMC(EMAIKFLOIPH r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x6F479C0", Offset = "0x6F461C0", VA = "0x186F479C0")]
		internal void MFPHKHOBAPK(EMAIKFLOIPH r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x6F47990", Offset = "0x6F46190", VA = "0x186F47990")]
		internal void LLEGNDLHHPD(EMAIKFLOIPH r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class PIHNJHFICLB<T> where T : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		private struct <<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009B")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009C")]
			public PIHNJHFICLB<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			private TaskAwaiter<CGAIHMMGDJF> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x34AAF90", Offset = "0x34A9790", VA = "0x1834AAF90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x9A4BE0", Offset = "0x9A33E0", VA = "0x1809A4BE0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public KDPKFDCNFIC rolePermission;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public CDGDFMGKCOP accountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public DBMIIPKDNDG recNetPermissionType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public string serializedNewValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public JOEGIIEKCNM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public Action onComplete;

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public PIHNJHFICLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x4659DC0", Offset = "0x46585C0", VA = "0x184659DC0")]
		[AsyncStateMachine(typeof(PIHNJHFICLB<>.<<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d))]
		internal void FPAFPEEGEGN()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct CGINKKLODOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public IReadOnlyList<EJFFFDIPMEC> newPermissionOverrides;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct AEGDLDDHKPM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public EHFIELOHEFL rolesDataProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public JGEEHKGDOJK roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public IReadOnlyDictionary<CDGDFMGKCOP, NAHFILNBHGL> defaultRoles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public KOLINNPELBE debugLogger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x6F3A0F0", Offset = "0x6F388F0", VA = "0x186F3A0F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x6F3AC00", Offset = "0x6F39400", VA = "0x186F3AC00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly EHFIELOHEFL NPFIAKPODPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly DCENKGFNCMA EJAHBBPCBLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly KOLINNPELBE AHILIMBPIGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private readonly Dictionary<int, NAHFILNBHGL> CHIKIGJFHLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	internal readonly Dictionary<CDGDFMGKCOP, NAHFILNBHGL> NKNNHJBKMBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	internal readonly Dictionary<CDGDFMGKCOP, NAHFILNBHGL> OGKGOAENGLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	internal readonly List<NAHFILNBHGL> LMFNKPGMPBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private bool BLDOEEJHEFF;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static readonly KDPKFDCNFIC[] IDJHIPAKMMH;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public ILCKHAKAHLM GJMJENEEOLE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x847510", Offset = "0x845D10", VA = "0x180847510", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public IEnumerable<BENDLKLDEMG> CHBODLPAKJH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x6F42150", Offset = "0x6F40950", VA = "0x186F42150", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event MCHBKDGCNBP DAEGIJPPFOC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x6F3FD40", Offset = "0x6F3E540", VA = "0x186F3FD40", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x6F3E760", Offset = "0x6F3CF60", VA = "0x186F3E760", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x6F3EEB0", Offset = "0x6F3D6B0", VA = "0x186F3EEB0")]
	[ANLGLDAOJJE(KKPEBAHBECP.Room, ELBANFBEGNE.None)]
	private static void DCCJADFNLLG(AANDDJDEEFL JBFKAEMANEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x6F435D0", Offset = "0x6F41DD0", VA = "0x186F435D0")]
	[UnityEngine.Scripting.Preserve]
	internal JOEGIIEKCNM([GNKLNMHODGG(null)] EHFIELOHEFL PLJKAAHLAGD, [GNKLNMHODGG(null)] DCENKGFNCMA MPHIKLOEJPK, [GNKLNMHODGG(null)] KOLINNPELBE AHILIMBPIGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x6F3F3C0", Offset = "0x6F3DBC0", VA = "0x186F3F3C0", Slot = "18")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x6F3F4D0", Offset = "0x6F3DCD0", VA = "0x186F3F4D0")]
	private void EHEMIGNFGGP(IEnumerable<NAHFILNBHGL> JPDPHNBKEOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x6F43090", Offset = "0x6F41890", VA = "0x186F43090", Slot = "12")]
	public bool OMLDCOOPADB(KCMOAPDBFGB PENGDIMNCLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x6F3F070", Offset = "0x6F3D870", VA = "0x186F3F070")]
	private void DFKKEBIBOLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x6F3FEC0", Offset = "0x6F3E6C0", VA = "0x186F3FEC0")]
	private void GOGFCOLHOEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x6F40BF0", Offset = "0x6F3F3F0", VA = "0x186F40BF0", Slot = "10")]
	public IReadOnlyList<BENDLKLDEMG> IOJHLIBNFBD(bool OIDDPHHNJIP = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x6F41900", Offset = "0x6F40100", VA = "0x186F41900", Slot = "11")]
	public BENDLKLDEMG NDMDLGLEDME(KCMOAPDBFGB PENGDIMNCLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x6F3FDF0", Offset = "0x6F3E5F0", VA = "0x186F3FDF0")]
	private CDGDFMGKCOP GIKGDBHEAFG(KCMOAPDBFGB PENGDIMNCLF)
	{
		return default(CDGDFMGKCOP);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x6F42F00", Offset = "0x6F41700", VA = "0x186F42F00", Slot = "14")]
	public bool OJINNEBCLOJ(KCMOAPDBFGB LLHMBFFMBEL, CDGDFMGKCOP ILHCIBLFOIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x6F40800", Offset = "0x6F3F000", VA = "0x186F40800", Slot = "15")]
	public BENDLKLDEMG IAGIDOJKEIF(CDGDFMGKCOP ILHCIBLFOIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x6F3EB80", Offset = "0x6F3D380", VA = "0x186F3EB80")]
	private static bool CPDJIKGFNFJ(JPNCBNMABOB ABNLKIADPHB, CDGDFMGKCOP ILHCIBLFOIC, [Out] EMAIKFLOIPH? GLOKNFOBGCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x6F3EA90", Offset = "0x6F3D290", VA = "0x186F3EA90")]
	private static void COFKFPMMBFD(JPNCBNMABOB ABNLKIADPHB, Action<EMAIKFLOIPH> GMMPEKDAOBI, CDGDFMGKCOP HNNGFPAAMMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x6F3E800", Offset = "0x6F3D000", VA = "0x186F3E800")]
	private static void COFKFPMMBFD(JPNCBNMABOB ABNLKIADPHB, Action<EMAIKFLOIPH> GMMPEKDAOBI, Predicate<CDGDFMGKCOP> JGPJFEHBIKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x6F3DF70", Offset = "0x6F3C770", VA = "0x186F3DF70")]
	private void BFPFBPECCIM(KCMOAPDBFGB PENGDIMNCLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x6F412F0", Offset = "0x6F3FAF0", VA = "0x186F412F0", Slot = "4")]
	[AsyncStateMachine(typeof(MJMOOKJLDOD))]
	public Task MEOAHJMCDBO([CanBeNull] JGEEHKGDOJK OLHDNFLDIIE, CancellationToken ODNHMAMKFFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530", Slot = "5")]
	public void MLKJPHJHBHB(JGEEHKGDOJK OLHDNFLDIIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x6F3F080", Offset = "0x6F3D880", VA = "0x186F3F080")]
	private void DLOHPJEOFAD(JPNCBNMABOB PKNCMGJHCFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x6F40FE0", Offset = "0x6F3F7E0", VA = "0x186F40FE0")]
	internal static string KNDLIIGPMKH(EHFIELOHEFL NPFIAKPODPH, JGEEHKGDOJK OLHDNFLDIIE, IReadOnlyDictionary<CDGDFMGKCOP, NAHFILNBHGL> NKNNHJBKMBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x6F421A0", Offset = "0x6F409A0", VA = "0x186F421A0")]
	private static void NPDNDDNDGLA(JGEEHKGDOJK OLHDNFLDIIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x6F408A0", Offset = "0x6F3F0A0", VA = "0x186F408A0")]
	private static void IHHNIEAMPNI(JPNCBNMABOB FEMJLNDNELE, IReadOnlyDictionary<CDGDFMGKCOP, NAHFILNBHGL> NKNNHJBKMBI, StringBuilder ACNLDBNEPDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x6F3DE60", Offset = "0x6F3C660", VA = "0x186F3DE60")]
	private static bool BAHMKNFOKJO(string FDEBMEALCHN, [Out] Guid NINAMBPAGHH, [Out] CDGDFMGKCOP ILHCIBLFOIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x6F41A10", Offset = "0x6F40210", VA = "0x186F41A10")]
	private static void NJFDKHCJONN(JGEEHKGDOJK OLHDNFLDIIE, StringBuilder ACNLDBNEPDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x2AEB030", Offset = "0x2AE9830", VA = "0x182AEB030", Slot = "16")]
	public bool IKCOMJBDPOO<T>(CDGDFMGKCOP ILHCIBLFOIC, KDPKFDCNFIC LLMDLBHHKGI, bool PDBILGFAMKK, T NIFGNHBNLFL, [Optional] Action GDOAJHGNONH) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x6F400B0", Offset = "0x6F3E8B0", VA = "0x186F400B0", Slot = "17")]
	public string HALDIELIOIA(KDPKFDCNFIC LLMDLBHHKGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x6F41410", Offset = "0x6F3FC10", VA = "0x186F41410")]
	private void MGCBPJDILCK(CDGDFMGKCOP ILHCIBLFOIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x6F40120", Offset = "0x6F3E920", VA = "0x186F40120")]
	private bool HJHDJMGBAIJ(KCMOAPDBFGB PENGDIMNCLF, CDGDFMGKCOP ILHCIBLFOIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x6F404B0", Offset = "0x6F3ECB0", VA = "0x186F404B0")]
	internal NAHFILNBHGL HPHIHBEOJMM(KCMOAPDBFGB PENGDIMNCLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x6F3FDE0", Offset = "0x6F3E5E0", VA = "0x186F3FDE0", Slot = "13")]
	public IReadOnlyList<BENDLKLDEMG> FIAPBOLEFPM(KCMOAPDBFGB PENGDIMNCLF, bool EJKBMPLBKEH = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x6F40DB0", Offset = "0x6F3F5B0", VA = "0x186F40DB0")]
	internal IReadOnlyList<NAHFILNBHGL> KELMFIPLHMC(KCMOAPDBFGB PENGDIMNCLF, bool EJKBMPLBKEH = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x6F3DFE0", Offset = "0x6F3C7E0", VA = "0x186F3DFE0")]
	private void BGHFOBOEDPJ(CGAIHMMGDJF OJOIBCEKJKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x6F41620", Offset = "0x6F3FE20", VA = "0x186F41620")]
	private static bool NAGHCEADKCO(NAHFILNBHGL JIIBJIHNLDH, IReadOnlyDictionary<CDGDFMGKCOP, NAHFILNBHGL> NKNNHJBKMBI, [Out] IReadOnlyList<KDPKFDCNFIC> GFCLPJEHEGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x6F40C70", Offset = "0x6F3F470", VA = "0x186F40C70")]
	[AsyncStateMachine(typeof(AEGDLDDHKPM))]
	private static Task JHFDHHFFGLF(EHFIELOHEFL NPFIAKPODPH, JGEEHKGDOJK OLHDNFLDIIE, IReadOnlyDictionary<CDGDFMGKCOP, NAHFILNBHGL> NKNNHJBKMBI, KOLINNPELBE AHILIMBPIGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x6F43160", Offset = "0x6F41960", VA = "0x186F43160")]
	[CompilerGenerated]
	internal static void OOALPCCPAOM(Func<EMAIKFLOIPH, OKDOFLHDHJI> BBPAILPMGFK, NMEEHNIJADF P_1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x6F40140", Offset = "0x6F3E940", VA = "0x186F40140")]
	[CompilerGenerated]
	internal static bool HMHCIAMJNBI(CDGDFMGKCOP ILHCIBLFOIC, KDPKFDCNFIC LLMDLBHHKGI, [Out] EJFFFDIPMEC CFJNPNCAHHF, CGINKKLODOL P_3)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface KBJGPOCELHF
{
	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PDOKPLIMKEC(KCMOAPDBFGB BEEFOGMOOPC, KCMOAPDBFGB LPMAOGLHLLO, IEnumerable<KCMOAPDBFGB> FKCJMIJPJOJ, [Out] HJECDCJNAMJ OIHGGKBAKBD, [Out] MCFOCJDABAA OPHEANHOOKP);

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string GCFKEJOOAAA(MCFOCJDABAA JBDBGHFLDKA);
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public enum MCFOCJDABAA : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	InsufficientPermission,
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	DisabledByRoom,
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	CantKickEventOrganizer,
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	Broadcaster,
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	GameInProgress,
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	OpponentGameInProgress
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal class GHCJLHJDMPN : KBJGPOCELHF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly KMEPDLIABIH JBKCGOFCDIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private readonly IGMFCLHFJEB OOJEKGJENFN;

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x84B520", Offset = "0x849D20", VA = "0x18084B520")]
	[RecRoom.NoEngine.Common.Preserve]
	public GHCJLHJDMPN([GNKLNMHODGG(null)] KMEPDLIABIH JJEKOPMNMFM, [GNKLNMHODGG(null)] IGMFCLHFJEB BAMMBLANMHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x6F3DD20", Offset = "0x6F3C520", VA = "0x186F3DD20")]
	private static JHBBCONCKJI? OKLCHPLIPDJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x6F3DD60", Offset = "0x6F3C560", VA = "0x186F3DD60", Slot = "4")]
	public bool PDOKPLIMKEC(KCMOAPDBFGB BEEFOGMOOPC, KCMOAPDBFGB LPMAOGLHLLO, IEnumerable<KCMOAPDBFGB> FKCJMIJPJOJ, [Out] HJECDCJNAMJ OIHGGKBAKBD, [Out] MCFOCJDABAA OPHEANHOOKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x6F3D600", Offset = "0x6F3BE00", VA = "0x186F3D600", Slot = "5")]
	public string GCFKEJOOAAA(MCFOCJDABAA JBDBGHFLDKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x6F3D700", Offset = "0x6F3BF00", VA = "0x186F3D700")]
	internal bool GHOGLJJIODH(KCMOAPDBFGB BEEFOGMOOPC, KCMOAPDBFGB LPMAOGLHLLO, IEnumerable<KCMOAPDBFGB> FKCJMIJPJOJ, APGABJIFLDK HHIDENNENFF, JHBBCONCKJI? KCECNIOJLJJ, [Out] HJECDCJNAMJ OIHGGKBAKBD, [Out] MCFOCJDABAA OPHEANHOOKP)
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
