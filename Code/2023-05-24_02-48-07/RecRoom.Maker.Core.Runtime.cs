using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7F0020", Offset = "0x7EEC20", VA = "0x1807F0020")]
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
		[Cpp2IlInjected.Address(RVA = "0x138D3A0", Offset = "0x138BFA0", VA = "0x18138D3A0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x852750", Offset = "0x851350", VA = "0x180852750")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xC81930", Offset = "0xC80530", VA = "0x180C81930")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7B2330", Offset = "0x7B1730")]
public class NGPCACBFCIK<TData> : global::NGJLBBBFBBD<global::KPMKNCMBLFB<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly FJBMIIEPEOP BEJMPMMMODH;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2899780", Offset = "0x2898380", VA = "0x182899780")]
	public NGPCACBFCIK(Vector3 OEICOCPNACP, bool KPKFGDAIIIJ, global::KPMKNCMBLFB<TData> ONMFHPEEBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2899710", Offset = "0x2898310", VA = "0x182899710", Slot = "4")]
	public override bool BNHDLCIOKEP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct OLMJHALJGMI<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public IEnumerable<TData> FJKBEPGJIJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public bool POAIHEGPCFG;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x4D82C70", Offset = "0x4D81870", VA = "0x184D82C70")]
	public OLMJHALJGMI(IEnumerable<TData> NGMFDEJHMNF, bool BIJFKJEIJPP = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface EMPGBLPIOEP<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HICKOCLAHCN([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7B23A0", Offset = "0x7B17A0")] in global::ILBPFIAMBDG<TData?> FOCFDAPBECJ);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KDPCJNFNOJO(in HJCPHFOMKGD MAKEPDAPPEE);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool KDPCJNFNOJO(in CCPJGMLDGJK MAKEPDAPPEE);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool KLHLKDPOIID();
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct EOKNJMCHCMP<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public TNode OOIPKNDBEAH;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x353DD10", Offset = "0x353C910", VA = "0x18353DD10")]
	public EOKNJMCHCMP(TNode OOIPKNDBEAH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct BBADHJNACOD<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public TNode HOJFPNNGODA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public FIBPDFDOBGG HOFHDBGLCKH;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3BCD2C0", Offset = "0x3BCBEC0", VA = "0x183BCD2C0")]
	public BBADHJNACOD(TNode HOJFPNNGODA, FIBPDFDOBGG HOFHDBGLCKH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7B0700", Offset = "0x7AFB00")]
public class JCDPEAGMOGH<TData> : global::NGJLBBBFBBD<global::EFKCPJBOKJH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7B0770", Offset = "0x7AFB70")]
	private readonly global::OLMJHALJGMI<TData> ACDKDGHLAPG;

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x468F4E0", Offset = "0x468E0E0", VA = "0x18468F4E0")]
	public JCDPEAGMOGH(List<TData> IHGFGANOELJ, global::EFKCPJBOKJH<TData> ONMFHPEEBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2899510", Offset = "0x2898110", VA = "0x182899510", Slot = "4")]
	public override bool BNHDLCIOKEP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface ODKABPDBKIC<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BNHDLCIOKEP([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7B07D0", Offset = "0x7AFBD0")] in global::OJEDNNNAIFM<TData?> PINLIGDEJBB);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct PFJGDGKEAEA<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public IEnumerable<TData> FJKBEPGJIJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public MFJEBBFONBC OHBNBDLMMIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public BIFNIOGHPEJ LPKOAIKFIFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public float GBNPCMDBPJC;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3E069F0", Offset = "0x3E055F0", VA = "0x183E069F0")]
	public PFJGDGKEAEA(IEnumerable<TData> JKLNEELBHOJ, MFJEBBFONBC OPOEPBAFNOG, BIFNIOGHPEJ IJIKACDMPFI, float GBNPCMDBPJC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
internal static class IODCLPJPOPG
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x138CCF0", Offset = "0x138B8F0", VA = "0x18138CCF0")]
	public static void KHMAIMACAIA(IEnumerable IHKODGEFCEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x2155720", Offset = "0x2154320", VA = "0x182155720")]
	public static void KHMAIMACAIA<T>(T[] EABDNHJFDCB) where T : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct FECKOPIDLIL<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public TData[] FJKBEPGJIJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public MFJEBBFONBC[] OHBNBDLMMIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public BIFNIOGHPEJ[] LPKOAIKFIFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public float[] GBNPCMDBPJC;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2BE06E0", Offset = "0x2BDF2E0", VA = "0x182BE06E0")]
	public FECKOPIDLIL(TData[] JKLNEELBHOJ, MFJEBBFONBC[] OPOEPBAFNOG, BIFNIOGHPEJ[] IJIKACDMPFI, float[] GBNPCMDBPJC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface NAONIBGKDCK
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool HOEGJHKMOIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool JNFPPCNAOLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool DCBMNAGFHFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool JHLNGGKLGOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct DKBOOAPBOFG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly Guid ENGCGOEGJAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly int NHHNPPKPBIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly Vector3 NABPHMOHNDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly Quaternion KDPJNNPKKHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly float EAHPLIAGBOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly bool KPKFGDAIIIJ;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x138CC70", Offset = "0x138B870", VA = "0x18138CC70")]
	public DKBOOAPBOFG(Guid ENGCGOEGJAE, int NHHNPPKPBIA, Vector3 NABPHMOHNDG, Quaternion KDPJNNPKKHC, float EAHPLIAGBOI, bool KPKFGDAIIIJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface KPHFKFGAEPF<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HICKOCLAHCN([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7B0840", Offset = "0x7AFC40")] in global::JONKFFADLHH<TData?> FOCFDAPBECJ);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KDPCJNFNOJO(in PLBBGJPDMOA MAKEPDAPPEE);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool KLHLKDPOIID();
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct HJCPHFOMKGD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public readonly float OMOAPNBJLBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public readonly Vector3 CNMOHJEEHNB;

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x138CCD0", Offset = "0x138B8D0", VA = "0x18138CCD0")]
	public HJCPHFOMKGD(float OMOAPNBJLBI, Vector3 CNMOHJEEHNB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct CCPJGMLDGJK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public readonly Vector3 AMMCBKOAOAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly float OMOAPNBJLBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public readonly Vector3 CNMOHJEEHNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly bool KPKFGDAIIIJ;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x138CC40", Offset = "0x138B840", VA = "0x18138CC40")]
	public CCPJGMLDGJK(Vector3 AMMCBKOAOAI, float OMOAPNBJLBI, Vector3 CNMOHJEEHNB, bool KPKFGDAIIIJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7B08B0", Offset = "0x7AFCB0")]
public class OCHCCKCPKMN<TData> : global::NGJLBBBFBBD<global::CHHPAIKEDAA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly MFHCFHBEBOG NJBEKEKLFGB;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x4900220", Offset = "0x48FEE20", VA = "0x184900220")]
	public OCHCCKCPKMN(Vector3 JAEADBEBFDD, global::CHHPAIKEDAA<TData> ONMFHPEEBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x2899710", Offset = "0x2898310", VA = "0x182899710", Slot = "4")]
	public override bool BNHDLCIOKEP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface FLMAKGKBMAB<TData> where TData : JMCLLHIJENJ
{
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BNHDLCIOKEP([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7B0920", Offset = "0x7AFD20")] in global::NBGMICDKHJH<TData> ICBGEJKPEAO);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BNHDLCIOKEP([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7B0990", Offset = "0x7AFD90")] in global::OEIHKBNNHAA<TData> ICBGEJKPEAO);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class OBFPDPCMHJG
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public enum MJELDEPAKFL
	{
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		ICreationContextObject,
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		Guid
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5301470", Offset = "0x5300070", VA = "0x185301470")]
	public static void JBADHJNEGOK<T>(T PKIKEDNMDGD, MJELDEPAKFL FIJCKHKKDCC) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x53015F0", Offset = "0x53001F0", VA = "0x1853015F0")]
	public static void JBADHJNEGOK<T>(T PKIKEDNMDGD) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5301680", Offset = "0x5300280", VA = "0x185301680")]
	public static T PNBJHLBKMLC<T>(MJELDEPAKFL FIJCKHKKDCC) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5301740", Offset = "0x5300340", VA = "0x185301740")]
	public static T PNBJHLBKMLC<T>() where T : class
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7B0A00", Offset = "0x7AFE00")]
public class MKCBIMCMEII<TData> : global::NGJLBBBFBBD<global::EFKCPJBOKJH<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x1B9E6F0", Offset = "0x1B9D2F0", VA = "0x181B9E6F0")]
	public MKCBIMCMEII(global::EFKCPJBOKJH<TData> ONMFHPEEBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x35EB7A0", Offset = "0x35EA3A0", VA = "0x1835EB7A0", Slot = "4")]
	public override bool BNHDLCIOKEP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface KOODPMGPAGA<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool Raycast(Vector3 OEBPJEAOOED, Vector3 AGOGLFBBBLL, float LHLJEFHGAPL, out T LBKHFOMHCAI, out Vector3 HMEDJJMHJOK, out Collider CPGMLAAKKBC);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int SpherecastPick(Vector3 OEBPJEAOOED, Vector3 AGOGLFBBBLL, float FCGNONDJBFN, float LHLJEFHGAPL, T[] FONAMLHAFND, out Vector3 EGEIHMGFGBG, out Collider ENNDBJNOHBG);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int SpherePick(Vector3 OEBPJEAOOED, float FCGNONDJBFN, Vector3 CLAIFDNFBPB, T[] FONAMLHAFND);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public abstract class CKEKECNMLLI<TReceiver, TFromExecute> where TReceiver : notnull where TFromExecute : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	protected TReceiver ONMFHPEEBAL;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x2E756B0", Offset = "0x2E742B0", VA = "0x182E756B0")]
	public CKEKECNMLLI(TReceiver ONMFHPEEBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TFromExecute BNHDLCIOKEP();
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7B0A70", Offset = "0x7AFE70")]
public class AEFNCLHNFEM<TData> : global::NGJLBBBFBBD<global::BHEHLKIIBIN<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7B0AE0", Offset = "0x7AFEE0")]
	private readonly global::IOIDNKIHFNN<TData> COIONAJGENL;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x37163C0", Offset = "0x3714FC0", VA = "0x1837163C0")]
	public AEFNCLHNFEM(IEnumerable<TData> JKLNEELBHOJ, MFJEBBFONBC OPOEPBAFNOG, BIFNIOGHPEJ IJIKACDMPFI, float GBNPCMDBPJC, bool POAIHEGPCFG, global::BHEHLKIIBIN<TData> ONMFHPEEBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2899510", Offset = "0x2898110", VA = "0x182899510", Slot = "4")]
	public override bool BNHDLCIOKEP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7B0B40", Offset = "0x7AFF40")]
public class MMCMFAKDPCC<TData> : global::NGJLBBBFBBD<global::KPMKNCMBLFB<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x1B9E6F0", Offset = "0x1B9D2F0", VA = "0x181B9E6F0")]
	public MMCMFAKDPCC(global::KPMKNCMBLFB<TData> ONMFHPEEBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x2CAA350", Offset = "0x2CA8F50", VA = "0x182CAA350", Slot = "4")]
	public override bool BNHDLCIOKEP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7B0BB0", Offset = "0x7AFFB0")]
public class BNAEDOFMMKA<TData> : global::NGJLBBBFBBD<global::CFECMBPEGKM<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7B0C20", Offset = "0x7B0020")]
	private readonly global::LGOOHNLAPNA<TData> NJBEKEKLFGB;

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x2CAE9F0", Offset = "0x2CAD5F0", VA = "0x182CAE9F0")]
	public BNAEDOFMMKA(IEnumerable<TData> JKLNEELBHOJ, Vector3 JAEADBEBFDD, bool POAIHEGPCFG, global::CFECMBPEGKM<TData> ONMFHPEEBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2899510", Offset = "0x2898110", VA = "0x182899510", Slot = "4")]
	public override bool BNHDLCIOKEP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public struct LGOOHNLAPNA<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public readonly IEnumerable<TData> JKLNEELBHOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly Vector3 JAEADBEBFDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public readonly bool POAIHEGPCFG;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x387E420", Offset = "0x387D020", VA = "0x18387E420")]
	public LGOOHNLAPNA(IEnumerable<TData> JKLNEELBHOJ, Vector3 JAEADBEBFDD, bool POAIHEGPCFG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface CFECMBPEGKM<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BNHDLCIOKEP([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7B0C80", Offset = "0x7B0080")] in global::LGOOHNLAPNA<TData?> NJBEKEKLFGB);
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7B0CF0", Offset = "0x7B00F0")]
public class KHJEPGNHCBA<TData> : global::NGJLBBBFBBD<global::EFKCPJBOKJH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly bool POAIHEGPCFG;

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2C16EA0", Offset = "0x2C15AA0", VA = "0x182C16EA0")]
	public KHJEPGNHCBA(bool POAIHEGPCFG, global::EFKCPJBOKJH<TData> ONMFHPEEBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2C16E30", Offset = "0x2C15A30", VA = "0x182C16E30", Slot = "4")]
	public override bool BNHDLCIOKEP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface GEIILMDDHOC<TNode>
{
	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HICKOCLAHCN([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7B0D60", Offset = "0x7B0160")] in global::EOKNJMCHCMP<TNode?> FOCFDAPBECJ);

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KLHLKDPOIID([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7B0DD0", Offset = "0x7B01D0")] in global::BBADHJNACOD<TNode?> AGFHKIGMLAI);

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool OIMCADDMNMH();
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7B0E40", Offset = "0x7B0240")]
public class AGCOLPGKILK<TNode> : global::NGJLBBBFBBD<global::GEIILMDDHOC<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x1B9E6F0", Offset = "0x1B9D2F0", VA = "0x181B9E6F0")]
	public AGCOLPGKILK(global::GEIILMDDHOC<TNode> ONMFHPEEBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x38635D0", Offset = "0x38621D0", VA = "0x1838635D0", Slot = "4")]
	public override bool BNHDLCIOKEP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface DGBCINDDGOC<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BNHDLCIOKEP([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7B0EB0", Offset = "0x7B02B0")] in global::FECKOPIDLIL<TData?> COIONAJGENL);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class MMIEGENJEBK
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	private struct IGPIALFMODC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public bool EFEABKGIBID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public MHOBEFMLEFD MLGFLIHDPHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public MHOBEFMLEFD OBANKPIKNAD;
	}

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static IGPIALFMODC NKNEADAEJHG;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static CancellationToken PIIFHPDGBIB
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x138D300", Offset = "0x138BF00", VA = "0x18138D300")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	internal static MHOBEFMLEFD MLGFLIHDPHB
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x138CF60", Offset = "0x138BB60", VA = "0x18138CF60")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x138D040", Offset = "0x138BC40", VA = "0x18138D040")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x138D110", Offset = "0x138BD10", VA = "0x18138D110")]
	[BBAPFPLPODF(BLGLNFDFDJO.Room, EDNJEIFHIMJ.None)]
	private static void MCFKFGEHJOK(MHOBEFMLEFD DABKGFKDEBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x138D1C0", Offset = "0x138BDC0", VA = "0x18138D1C0")]
	public static void NHGHFKAFNCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x138D0C0", Offset = "0x138BCC0", VA = "0x18138D0C0")]
	private static MHOBEFMLEFD LJNFCOJPLGL(MHOBEFMLEFD EOHDEJOCEFD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface ONMAIAAEPDN<TData> : ANIJJOLDOAL, global::NONDFKAKFJJ<TData>, global::EFKCPJBOKJH<TData>, global::OHHGJOPBPAO<TData>, NAONIBGKDCK, global::KOODPMGPAGA<TData>, AEHFJOHEHBB
{
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct OJEDNNNAIFM<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public readonly IEnumerable<TData> JKLNEELBHOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public readonly Quaternion JAEADBEBFDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public readonly Vector3? CNMOHJEEHNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public readonly bool HGMINIJGMNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public readonly bool POAIHEGPCFG;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3BE6110", Offset = "0x3BE4D10", VA = "0x183BE6110")]
	public OJEDNNNAIFM(IEnumerable<TData> JKLNEELBHOJ, Quaternion JAEADBEBFDD, Vector3? CNMOHJEEHNB, bool HGMINIJGMNM, bool POAIHEGPCFG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public struct IOIDNKIHFNN<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public IEnumerable<TData> FJKBEPGJIJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public MFJEBBFONBC OHBNBDLMMIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public BIFNIOGHPEJ LPKOAIKFIFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public float GBNPCMDBPJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public bool POAIHEGPCFG;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x2B455D0", Offset = "0x2B441D0", VA = "0x182B455D0")]
	public IOIDNKIHFNN(IEnumerable<TData> JKLNEELBHOJ, MFJEBBFONBC OPOEPBAFNOG, BIFNIOGHPEJ IJIKACDMPFI, float GBNPCMDBPJC, bool POAIHEGPCFG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7B0F40", Offset = "0x7B0340")]
public class LLBPEINAHNO<TData> : global::NGJLBBBFBBD<global::EMPGBLPIOEP<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly CCPJGMLDGJK EOEBGBGLIBA;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x424BAF0", Offset = "0x424A6F0", VA = "0x18424BAF0")]
	public LLBPEINAHNO(Vector3 AMMCBKOAOAI, float OMOAPNBJLBI, Vector3 CNMOHJEEHNB, bool DIIDBHNHLPI, global::EMPGBLPIOEP<TData> ONMFHPEEBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x35383B0", Offset = "0x3536FB0", VA = "0x1835383B0", Slot = "4")]
	public override bool BNHDLCIOKEP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7B0FB0", Offset = "0x7B03B0")]
public class IEFFPIPADOL<TData> : global::NGJLBBBFBBD<global::EFKCPJBOKJH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7B1020", Offset = "0x7B0420")]
	private readonly global::OLMJHALJGMI<TData> ACDKDGHLAPG;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x1A0C770", Offset = "0x1A0B370", VA = "0x181A0C770")]
	public IEFFPIPADOL(List<TData> IHGFGANOELJ, global::EFKCPJBOKJH<TData> ONMFHPEEBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x1A0C6A0", Offset = "0x1A0B2A0", VA = "0x181A0C6A0", Slot = "4")]
	public override bool BNHDLCIOKEP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public readonly struct EKEBFLABIPL<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly IEnumerable<TData> FJKBEPGJIJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly bool NKOHCMBENEP;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x35222C0", Offset = "0x3520EC0", VA = "0x1835222C0")]
	public EKEBFLABIPL(IEnumerable<TData> JKLNEELBHOJ, bool POAIHEGPCFG = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7B10C0", Offset = "0x7B04C0")]
public class BMGBOGLDCMN<TData> : global::NGJLBBBFBBD<global::EFKCPJBOKJH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7B1130", Offset = "0x7B0530")]
	private readonly global::OLMJHALJGMI<TData> ACDKDGHLAPG;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x2CAA7D0", Offset = "0x2CA93D0", VA = "0x182CAA7D0")]
	public BMGBOGLDCMN(List<TData> IHGFGANOELJ, bool POAIHEGPCFG, global::EFKCPJBOKJH<TData> ONMFHPEEBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x2CAA700", Offset = "0x2CA9300", VA = "0x182CAA700", Slot = "4")]
	public override bool BNHDLCIOKEP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface NONDFKAKFJJ<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void RenderHoverHighlight(T HHNPCHNMLMA, [Optional] IJMHEDAFOOI? ADFOOOIPFKF, bool MONEPLFPLCF = true);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RenderHoverHighlight(int FGHOJPFDCIA, IEnumerable<T> MJPJIGOGOAP, bool MONEPLFPLCF = true);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RenderHoverHighlight(int FGHOJPFDCIA, IEnumerable<T> MJPJIGOGOAP, IJMHEDAFOOI ADFOOOIPFKF, bool MONEPLFPLCF = true);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public struct ILBPFIAMBDG<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly IEnumerable<TData> JKLNEELBHOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly bool POAIHEGPCFG;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x34D4E40", Offset = "0x34D3A40", VA = "0x1834D4E40")]
	public ILBPFIAMBDG(IEnumerable<TData> JKLNEELBHOJ, bool POAIHEGPCFG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7B1190", Offset = "0x7B0590")]
public class DLDNGDMJCKD<TData> : global::KFKLJFLAKON<global::FPHCOFHHGAD<TData>, MHPBAPDBIDB> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7B1200", Offset = "0x7B0600")]
	private readonly global::EKEBFLABIPL<TData> CKLCJMHIDPL;

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x36D4C10", Offset = "0x36D3810", VA = "0x1836D4C10")]
	public DLDNGDMJCKD(IEnumerable<TData> JKLNEELBHOJ, bool POAIHEGPCFG, global::FPHCOFHHGAD<TData> ONMFHPEEBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x36D49D0", Offset = "0x36D35D0", VA = "0x1836D49D0", Slot = "4")]
	public override Task<MHPBAPDBIDB> BNHDLCIOKEP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7B1260", Offset = "0x7B0660")]
public class IPOBFNMDFAC<TData> : global::NGJLBBBFBBD<global::KPMKNCMBLFB<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7B12D0", Offset = "0x7B06D0")]
	private readonly global::FPKDKGAELHC<TData> BEJMPMMMODH;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x5DA8200", Offset = "0x5DA6E00", VA = "0x185DA8200")]
	public IPOBFNMDFAC(TData CBHLPGJGAKG, bool POAIHEGPCFG, global::KPMKNCMBLFB<TData> ONMFHPEEBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2899510", Offset = "0x2898110", VA = "0x182899510", Slot = "4")]
	public override bool BNHDLCIOKEP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct FPKDKGAELHC<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public readonly TData CBHLPGJGAKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly bool POAIHEGPCFG;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x3CEE0F0", Offset = "0x3CECCF0", VA = "0x183CEE0F0")]
	public FPKDKGAELHC(TData CBHLPGJGAKG, bool POAIHEGPCFG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public struct JLGBLCCKPII<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly IEnumerable<TData> JKLNEELBHOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public readonly bool POAIHEGPCFG;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x3508580", Offset = "0x3507180", VA = "0x183508580")]
	public JLGBLCCKPII(IEnumerable<TData> JKLNEELBHOJ, bool POAIHEGPCFG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7B1330", Offset = "0x7B0730")]
public class JENFIJINLJH<TData> : global::NGJLBBBFBBD<global::EMPGBLPIOEP<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly HJCPHFOMKGD EOEBGBGLIBA;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x30CEEE0", Offset = "0x30CDAE0", VA = "0x1830CEEE0")]
	public JENFIJINLJH(float OMOAPNBJLBI, Vector3 CNMOHJEEHNB, global::EMPGBLPIOEP<TData> ONMFHPEEBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2899710", Offset = "0x2898310", VA = "0x182899710", Slot = "4")]
	public override bool BNHDLCIOKEP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7B13A0", Offset = "0x7B07A0")]
public class OLPAELJCBIG<TData> : global::NGJLBBBFBBD<global::KPHFKFGAEPF<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x1B9E6F0", Offset = "0x1B9D2F0", VA = "0x181B9E6F0")]
	public OLPAELJCBIG(global::KPHFKFGAEPF<TData> ONMFHPEEBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x38635D0", Offset = "0x38621D0", VA = "0x1838635D0", Slot = "4")]
	public override bool BNHDLCIOKEP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7B1410", Offset = "0x7B0810")]
public class NGLLELFKOBO<TData> : global::NGJLBBBFBBD<global::KPHFKFGAEPF<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7B1480", Offset = "0x7B0880")]
	private readonly global::JONKFFADLHH<TData> PINLIGDEJBB;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2899670", Offset = "0x2898270", VA = "0x182899670")]
	public NGLLELFKOBO(IEnumerable<TData> JKLNEELBHOJ, bool POAIHEGPCFG, global::KPHFKFGAEPF<TData> ONMFHPEEBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2899510", Offset = "0x2898110", VA = "0x182899510", Slot = "4")]
	public override bool BNHDLCIOKEP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7B14E0", Offset = "0x7B08E0")]
public class HHHNMMMOLMB<TNode> : global::NGJLBBBFBBD<global::GEIILMDDHOC<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7B1550", Offset = "0x7B0950")]
	private readonly global::EOKNJMCHCMP<TNode> FOCFDAPBECJ;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x51D4C90", Offset = "0x51D3890", VA = "0x1851D4C90")]
	public HHHNMMMOLMB(TNode KEJPLMDBPBP, global::GEIILMDDHOC<TNode> ONMFHPEEBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2899510", Offset = "0x2898110", VA = "0x182899510", Slot = "4")]
	public override bool BNHDLCIOKEP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7B15B0", Offset = "0x7B09B0")]
public class GHFJFEPPHIH<TData> : global::NGJLBBBFBBD<global::CHHPAIKEDAA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7B1620", Offset = "0x7B0A20")]
	private readonly global::JLGBLCCKPII<TData> NJBEKEKLFGB;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x28B92E0", Offset = "0x28B7EE0", VA = "0x1828B92E0")]
	public GHFJFEPPHIH(IEnumerable<TData> JKLNEELBHOJ, bool POAIHEGPCFG, global::CHHPAIKEDAA<TData> ONMFHPEEBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2899510", Offset = "0x2898110", VA = "0x182899510", Slot = "4")]
	public override bool BNHDLCIOKEP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct JONKFFADLHH<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public readonly IEnumerable<TData> JKLNEELBHOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public readonly bool POAIHEGPCFG;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x3517DD0", Offset = "0x35169D0", VA = "0x183517DD0")]
	public JONKFFADLHH(IEnumerable<TData> JKLNEELBHOJ, bool POAIHEGPCFG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7B1680", Offset = "0x7B0A80")]
public class PCONOOKHHBB<TNode> : global::NGJLBBBFBBD<global::GEIILMDDHOC<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7B16F0", Offset = "0x7B0AF0")]
	private readonly global::BBADHJNACOD<TNode> AGFHKIGMLAI;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x3DF89B0", Offset = "0x3DF75B0", VA = "0x183DF89B0")]
	public PCONOOKHHBB(TNode HOJFPNNGODA, FIBPDFDOBGG HOFHDBGLCKH, global::GEIILMDDHOC<TNode> ONMFHPEEBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x3DF88E0", Offset = "0x3DF74E0", VA = "0x183DF88E0", Slot = "4")]
	public override bool BNHDLCIOKEP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public interface FPHCOFHHGAD<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<MHPBAPDBIDB> KNALOLAOOIF([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7B1750", Offset = "0x7B0B50")] in global::EKEBFLABIPL<TData> ACDKDGHLAPG, CancellationToken GFFFFCALMCA);
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface EFKCPJBOKJH<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JAMGJNEIAKD([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7B17C0", Offset = "0x7B0BC0")] in global::OLMJHALJGMI<TData> ACDKDGHLAPG);

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IOGAMAHKFNK([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7B1830", Offset = "0x7B0C30")] in global::OLMJHALJGMI<TData> ACDKDGHLAPG);

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IIBOIOFFHLD(in bool ECAPFECLFFO);

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool AMBMJMIEJPE([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7B18A0", Offset = "0x7B0CA0")] in global::OLMJHALJGMI<TData> ACDKDGHLAPG);

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LLDBNFEGHBI();

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool DMKEMICIOLM(in TData EPCJEHBDOPK);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public struct PLBBGJPDMOA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public readonly Quaternion JAEADBEBFDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly Vector3? CNMOHJEEHNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly bool HGMINIJGMNM;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x138D430", Offset = "0x138C030", VA = "0x18138D430")]
	public PLBBGJPDMOA(Quaternion JAEADBEBFDD, Vector3? CNMOHJEEHNB, bool HGMINIJGMNM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface KPMKNCMBLFB<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HICKOCLAHCN([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7B1910", Offset = "0x7B0D10")] in global::FPKDKGAELHC<TData?> FOCFDAPBECJ);

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KDPCJNFNOJO(in FJBMIIEPEOP MAKEPDAPPEE);

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool KDPCJNFNOJO(in DKBOOAPBOFG MAKEPDAPPEE);

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool KLHLKDPOIID();
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public struct MFHCFHBEBOG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly Vector3 JAEADBEBFDD;

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x12CB0E0", Offset = "0x12C9CE0", VA = "0x1812CB0E0")]
	public MFHCFHBEBOG(Vector3 JAEADBEBFDD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7B1980", Offset = "0x7B0D80")]
public class KJFEDIDPMLO<TData> : global::NGJLBBBFBBD<global::ODKABPDBKIC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7B19F0", Offset = "0x7B0DF0")]
	private readonly global::OJEDNNNAIFM<TData> PINLIGDEJBB;

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x2C1CC80", Offset = "0x2C1B880", VA = "0x182C1CC80")]
	public KJFEDIDPMLO(IEnumerable<TData> JKLNEELBHOJ, Quaternion JAEADBEBFDD, Vector3? CNMOHJEEHNB, bool HGMINIJGMNM, bool POAIHEGPCFG, global::ODKABPDBKIC<TData> ONMFHPEEBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x2899510", Offset = "0x2898110", VA = "0x182899510", Slot = "4")]
	public override bool BNHDLCIOKEP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7B1A50", Offset = "0x7B0E50")]
public class BMECFHLJFBF<TData> : global::NGJLBBBFBBD<global::EMPGBLPIOEP<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x1B9E6F0", Offset = "0x1B9D2F0", VA = "0x181B9E6F0")]
	public BMECFHLJFBF(global::EMPGBLPIOEP<TData> ONMFHPEEBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x2CAA350", Offset = "0x2CA8F50", VA = "0x182CAA350", Slot = "4")]
	public override bool BNHDLCIOKEP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7B1AC0", Offset = "0x7B0EC0")]
public class PKHEEKAEBNO<TData> : global::NGJLBBBFBBD<global::KPHFKFGAEPF<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly PLBBGJPDMOA PINLIGDEJBB;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x3A8EF20", Offset = "0x3A8DB20", VA = "0x183A8EF20")]
	public PKHEEKAEBNO(Quaternion JAEADBEBFDD, Vector3? CNMOHJEEHNB, bool HGMINIJGMNM, global::KPHFKFGAEPF<TData> ONMFHPEEBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x2899710", Offset = "0x2898310", VA = "0x182899710", Slot = "4")]
	public override bool BNHDLCIOKEP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7B1B30", Offset = "0x7B0F30")]
public class PFKCDPKKPIG<TData> : global::NGJLBBBFBBD<global::DGBCINDDGOC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7B1BA0", Offset = "0x7B0FA0")]
	private readonly global::FECKOPIDLIL<TData> COIONAJGENL;

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x3E06BC0", Offset = "0x3E057C0", VA = "0x183E06BC0")]
	public PFKCDPKKPIG(TData[] JKLNEELBHOJ, MFJEBBFONBC[] OPOEPBAFNOG, BIFNIOGHPEJ[] IJIKACDMPFI, float[] GBNPCMDBPJC, global::DGBCINDDGOC<TData> ONMFHPEEBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x3E060F0", Offset = "0x3E04CF0", VA = "0x183E060F0", Slot = "4")]
	public override bool BNHDLCIOKEP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7B1C00", Offset = "0x7B1000")]
public class MDCAHGFPHJF<TData> : global::NGJLBBBFBBD<global::FLMAKGKBMAB<TData>> where TData : notnull, JMCLLHIJENJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7B1C70", Offset = "0x7B1070")]
	private readonly global::OEIHKBNNHAA<TData> ICBGEJKPEAO;

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x3858270", Offset = "0x3856E70", VA = "0x183858270")]
	public MDCAHGFPHJF(List<TData> JKLNEELBHOJ, List<bool> NCJMKCFJPEH, global::FLMAKGKBMAB<TData> ONMFHPEEBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x2CAA700", Offset = "0x2CA9300", VA = "0x182CAA700", Slot = "4")]
	public override bool BNHDLCIOKEP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7B1CD0", Offset = "0x7B10D0")]
public class MGMDANEKMHO<TData> : global::NGJLBBBFBBD<global::CHHPAIKEDAA<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x1B9E6F0", Offset = "0x1B9D2F0", VA = "0x181B9E6F0")]
	public MGMDANEKMHO(global::CHHPAIKEDAA<TData> ONMFHPEEBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x38635D0", Offset = "0x38621D0", VA = "0x1838635D0", Slot = "4")]
	public override bool BNHDLCIOKEP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public struct FJBMIIEPEOP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public readonly Vector3 OEICOCPNACP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly bool KPKFGDAIIIJ;

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x138CCB0", Offset = "0x138B8B0", VA = "0x18138CCB0")]
	public FJBMIIEPEOP(Vector3 OEICOCPNACP, bool KPKFGDAIIIJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public interface OOCCBMPCEOK<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KDPCJNFNOJO([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7B1D40", Offset = "0x7B1140")] in global::PFJGDGKEAEA<TData?> COIONAJGENL);

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KLHLKDPOIID();
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7B1DB0", Offset = "0x7B11B0")]
public class PEOJFHEJGNJ<TData> : global::NGJLBBBFBBD<global::OOCCBMPCEOK<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7B1E20", Offset = "0x7B1220")]
	private readonly global::PFJGDGKEAEA<TData> COIONAJGENL;

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x3E061B0", Offset = "0x3E04DB0", VA = "0x183E061B0")]
	public PEOJFHEJGNJ(IEnumerable<TData> JKLNEELBHOJ, MFJEBBFONBC OPOEPBAFNOG, BIFNIOGHPEJ IJIKACDMPFI, float GBNPCMDBPJC, global::OOCCBMPCEOK<TData> ONMFHPEEBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x3E060F0", Offset = "0x3E04CF0", VA = "0x183E060F0", Slot = "4")]
	public override bool BNHDLCIOKEP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public interface JMCLLHIJENJ
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool HHBFHKFGDNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7B1E80", Offset = "0x7B1280")]
public class EOAEPGCAPAL<TData> : global::NGJLBBBFBBD<global::KPMKNCMBLFB<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly DKBOOAPBOFG BEJMPMMMODH;

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x3538420", Offset = "0x3537020", VA = "0x183538420")]
	public EOAEPGCAPAL(Guid ENGCGOEGJAE, int NHHNPPKPBIA, Vector3 NABPHMOHNDG, Quaternion KDPJNNPKKHC, float EAHPLIAGBOI, bool KPKFGDAIIIJ, global::KPMKNCMBLFB<TData> ONMFHPEEBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x35383B0", Offset = "0x3536FB0", VA = "0x1835383B0", Slot = "4")]
	public override bool BNHDLCIOKEP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7B1EF0", Offset = "0x7B12F0")]
public class FPOHMDDGHHA<TData> : global::NGJLBBBFBBD<global::FLMAKGKBMAB<TData>> where TData : notnull, JMCLLHIJENJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7B1F60", Offset = "0x7B1360")]
	private readonly global::NBGMICDKHJH<TData> ICBGEJKPEAO;

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x3CEE260", Offset = "0x3CECE60", VA = "0x183CEE260")]
	public FPOHMDDGHHA(List<TData> JKLNEELBHOJ, bool HIICENNMGHM, global::FLMAKGKBMAB<TData> ONMFHPEEBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x2899510", Offset = "0x2898110", VA = "0x182899510", Slot = "4")]
	public override bool BNHDLCIOKEP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7B1FC0", Offset = "0x7B13C0")]
public class IDHLLGEJCDE<TData> : global::NGJLBBBFBBD<global::EFKCPJBOKJH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly TData EPCJEHBDOPK;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x1A0B8D0", Offset = "0x1A0A4D0", VA = "0x181A0B8D0")]
	public IDHLLGEJCDE(TData EPCJEHBDOPK, global::EFKCPJBOKJH<TData> ONMFHPEEBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x1A0B800", Offset = "0x1A0A400", VA = "0x181A0B800", Slot = "4")]
	public override bool BNHDLCIOKEP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7B2030", Offset = "0x7B1430")]
public abstract class NGJLBBBFBBD<TReceiver> : global::CKEKECNMLLI<TReceiver, bool> where TReceiver : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x1B9E6F0", Offset = "0x1B9D2F0", VA = "0x181B9E6F0")]
	public NGJLBBBFBBD(TReceiver ONMFHPEEBAL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public interface ANIJJOLDOAL
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	Bounds ILCHJDCDEBF
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	Transform EEFMPHBAFHO
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	Bounds PLJFEJDLDOD
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	Transform FNFMNFEMBPL
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	Vector3 IPHHNJMGADK
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public struct NBGMICDKHJH<TData> where TData : notnull, JMCLLHIJENJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public IEnumerable<TData> FJKBEPGJIJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public bool HIICENNMGHM;

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x28890E0", Offset = "0x2887CE0", VA = "0x1828890E0")]
	public NBGMICDKHJH(IEnumerable<TData> NGMFDEJHMNF, bool MHJHPLPIPJG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public struct OEIHKBNNHAA<TData> where TData : notnull, JMCLLHIJENJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public List<TData> FJKBEPGJIJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public List<bool> NCJMKCFJPEH;

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x4066870", Offset = "0x4065470", VA = "0x184066870")]
	public OEIHKBNNHAA(List<TData> NGMFDEJHMNF, List<bool> MNNBCDNGKJP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public interface OHHGJOPBPAO<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool BFBECLKCGPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	int MABNAFKOGFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	IEnumerable<TData> AAKAHNBICCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IsSelected(TData FHJBBMIILLG);

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IsSelectable(TData FHJBBMIILLG);
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public interface AEHFJOHEHBB
{
	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnSelectionPickedUp();

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnSelectionReleased();
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public interface CHHPAIKEDAA<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HICKOCLAHCN([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7B20A0", Offset = "0x7B14A0")] in global::JLGBLCCKPII<TData?> ANCGLCMDIED);

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KDPCJNFNOJO(in MFHCFHBEBOG MAKEPDAPPEE);

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool KLHLKDPOIID();
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7B2110", Offset = "0x7B1510")]
public class DLKOCGHGGJI<TData> : global::NGJLBBBFBBD<global::OOCCBMPCEOK<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x1B9E6F0", Offset = "0x1B9D2F0", VA = "0x181B9E6F0")]
	public DLKOCGHGGJI(global::OOCCBMPCEOK<TData> ONMFHPEEBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x36D6090", Offset = "0x36D4C90", VA = "0x1836D6090", Slot = "4")]
	public override bool BNHDLCIOKEP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public interface HPOMNAADAHM : JMCLLHIJENJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7B2180", Offset = "0x7B1580")]
public abstract class KFKLJFLAKON<TReceiver, TFromTask> : global::CKEKECNMLLI<TReceiver, Task<TFromTask>>
{
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x1B9E6F0", Offset = "0x1B9D2F0", VA = "0x181B9E6F0")]
	public KFKLJFLAKON(TReceiver ONMFHPEEBAL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7B21F0", Offset = "0x7B15F0")]
public class DNNFPBPNMLI<TData> : global::NGJLBBBFBBD<global::EMPGBLPIOEP<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7B2260", Offset = "0x7B1660")]
	private readonly global::ILBPFIAMBDG<TData> EOEBGBGLIBA;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x36D80B0", Offset = "0x36D6CB0", VA = "0x1836D80B0")]
	public DNNFPBPNMLI(IEnumerable<TData> JKLNEELBHOJ, bool POAIHEGPCFG, global::EMPGBLPIOEP<TData> ONMFHPEEBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x2899510", Offset = "0x2898110", VA = "0x182899510", Slot = "4")]
	public override bool BNHDLCIOKEP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public interface BHEHLKIIBIN<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BNHDLCIOKEP([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7B22C0", Offset = "0x7B16C0")] in global::IOIDNKIHFNN<TData?> COIONAJGENL);
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
