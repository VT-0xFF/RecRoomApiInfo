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
		[Cpp2IlInjected.Address(RVA = "0x80EA90", Offset = "0x80D290", VA = "0x18080EA90")]
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
		[Cpp2IlInjected.Address(RVA = "0x1667FF0", Offset = "0x16667F0", VA = "0x181667FF0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8C8540", Offset = "0x8C6D40", VA = "0x1808C8540")]
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
		[Cpp2IlInjected.Address(RVA = "0xD79980", Offset = "0xD78180", VA = "0x180D79980")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x87070", Offset = "0x86470")]
public class NGPCACBFCIK<TData> : global::NGJLBBBFBBD<global::KPMKNCMBLFB<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly FJBMIIEPEOP BEJMPMMMODH;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x29CBD50", Offset = "0x29CA550", VA = "0x1829CBD50")]
	public NGPCACBFCIK(Vector3 OEICOCPNACP, bool KPKFGDAIIIJ, global::KPMKNCMBLFB<TData> ONMFHPEEBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x29CBCE0", Offset = "0x29CA4E0", VA = "0x1829CBCE0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x42586E0", Offset = "0x4256EE0", VA = "0x1842586E0")]
	public OLMJHALJGMI(IEnumerable<TData> NGMFDEJHMNF, bool BIJFKJEIJPP = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface EMPGBLPIOEP<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HICKOCLAHCN([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x870E0", Offset = "0x864E0")] in global::ILBPFIAMBDG<TData?> FOCFDAPBECJ);

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
	[Cpp2IlInjected.Address(RVA = "0x185E500", Offset = "0x185CD00", VA = "0x18185E500")]
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
	[Cpp2IlInjected.Address(RVA = "0x4828F60", Offset = "0x4827760", VA = "0x184828F60")]
	public BBADHJNACOD(TNode HOJFPNNGODA, FIBPDFDOBGG HOFHDBGLCKH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x853D0", Offset = "0x847D0")]
public class JCDPEAGMOGH<TData> : global::NGJLBBBFBBD<global::EFKCPJBOKJH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x85440", Offset = "0x84840")]
	private readonly global::OLMJHALJGMI<TData> ACDKDGHLAPG;

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x32E75F0", Offset = "0x32E5DF0", VA = "0x1832E75F0")]
	public JCDPEAGMOGH(List<TData> IHGFGANOELJ, global::EFKCPJBOKJH<TData> ONMFHPEEBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x29CBAE0", Offset = "0x29CA2E0", VA = "0x1829CBAE0", Slot = "4")]
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
	bool BNHDLCIOKEP([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x854A0", Offset = "0x848A0")] in global::OJEDNNNAIFM<TData?> PINLIGDEJBB);
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
	[Cpp2IlInjected.Address(RVA = "0x40A9E20", Offset = "0x40A8620", VA = "0x1840A9E20")]
	public PFJGDGKEAEA(IEnumerable<TData> JKLNEELBHOJ, MFJEBBFONBC OPOEPBAFNOG, BIFNIOGHPEJ IJIKACDMPFI, float GBNPCMDBPJC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
internal static class IODCLPJPOPG
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x1667940", Offset = "0x1666140", VA = "0x181667940")]
	public static void KHMAIMACAIA(IEnumerable IHKODGEFCEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x243B010", Offset = "0x2439810", VA = "0x18243B010")]
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
	[Cpp2IlInjected.Address(RVA = "0x260FE00", Offset = "0x260E600", VA = "0x18260FE00")]
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
	[Cpp2IlInjected.Address(RVA = "0x16678C0", Offset = "0x16660C0", VA = "0x1816678C0")]
	public DKBOOAPBOFG(Guid ENGCGOEGJAE, int NHHNPPKPBIA, Vector3 NABPHMOHNDG, Quaternion KDPJNNPKKHC, float EAHPLIAGBOI, bool KPKFGDAIIIJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface KPHFKFGAEPF<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HICKOCLAHCN([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x85510", Offset = "0x84910")] in global::JONKFFADLHH<TData?> FOCFDAPBECJ);

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
	[Cpp2IlInjected.Address(RVA = "0x1667920", Offset = "0x1666120", VA = "0x181667920")]
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
	[Cpp2IlInjected.Address(RVA = "0x1667890", Offset = "0x1666090", VA = "0x181667890")]
	public CCPJGMLDGJK(Vector3 AMMCBKOAOAI, float OMOAPNBJLBI, Vector3 CNMOHJEEHNB, bool KPKFGDAIIIJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x85580", Offset = "0x84980")]
public class OCHCCKCPKMN<TData> : global::NGJLBBBFBBD<global::CHHPAIKEDAA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly MFHCFHBEBOG NJBEKEKLFGB;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x58CEBA0", Offset = "0x58CD3A0", VA = "0x1858CEBA0")]
	public OCHCCKCPKMN(Vector3 JAEADBEBFDD, global::CHHPAIKEDAA<TData> ONMFHPEEBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x29CBCE0", Offset = "0x29CA4E0", VA = "0x1829CBCE0", Slot = "4")]
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
	bool BNHDLCIOKEP([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x855F0", Offset = "0x849F0")] in global::NBGMICDKHJH<TData> ICBGEJKPEAO);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BNHDLCIOKEP([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x85660", Offset = "0x84A60")] in global::OEIHKBNNHAA<TData> ICBGEJKPEAO);
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
	[Cpp2IlInjected.Address(RVA = "0x54B0440", Offset = "0x54AEC40", VA = "0x1854B0440")]
	public static void JBADHJNEGOK<T>(T PKIKEDNMDGD, MJELDEPAKFL FIJCKHKKDCC) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x54B05C0", Offset = "0x54AEDC0", VA = "0x1854B05C0")]
	public static void JBADHJNEGOK<T>(T PKIKEDNMDGD) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x54B0650", Offset = "0x54AEE50", VA = "0x1854B0650")]
	public static T PNBJHLBKMLC<T>(MJELDEPAKFL FIJCKHKKDCC) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x54B0710", Offset = "0x54AEF10", VA = "0x1854B0710")]
	public static T PNBJHLBKMLC<T>() where T : class
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x856D0", Offset = "0x84AD0")]
public class MKCBIMCMEII<TData> : global::NGJLBBBFBBD<global::EFKCPJBOKJH<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x249D730", Offset = "0x249BF30", VA = "0x18249D730")]
	public MKCBIMCMEII(global::EFKCPJBOKJH<TData> ONMFHPEEBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x366DA70", Offset = "0x366C270", VA = "0x18366DA70", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x3AF4640", Offset = "0x3AF2E40", VA = "0x183AF4640")]
	public CKEKECNMLLI(TReceiver ONMFHPEEBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TFromExecute BNHDLCIOKEP();
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x85740", Offset = "0x84B40")]
public class AEFNCLHNFEM<TData> : global::NGJLBBBFBBD<global::BHEHLKIIBIN<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x857B0", Offset = "0x84BB0")]
	private readonly global::IOIDNKIHFNN<TData> COIONAJGENL;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3A18550", Offset = "0x3A16D50", VA = "0x183A18550")]
	public AEFNCLHNFEM(IEnumerable<TData> JKLNEELBHOJ, MFJEBBFONBC OPOEPBAFNOG, BIFNIOGHPEJ IJIKACDMPFI, float GBNPCMDBPJC, bool POAIHEGPCFG, global::BHEHLKIIBIN<TData> ONMFHPEEBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x29CBAE0", Offset = "0x29CA2E0", VA = "0x1829CBAE0", Slot = "4")]
	public override bool BNHDLCIOKEP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x85810", Offset = "0x84C10")]
public class MMCMFAKDPCC<TData> : global::NGJLBBBFBBD<global::KPMKNCMBLFB<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x249D730", Offset = "0x249BF30", VA = "0x18249D730")]
	public MMCMFAKDPCC(global::KPMKNCMBLFB<TData> ONMFHPEEBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x2EF9920", Offset = "0x2EF8120", VA = "0x182EF9920", Slot = "4")]
	public override bool BNHDLCIOKEP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x85880", Offset = "0x84C80")]
public class BNAEDOFMMKA<TData> : global::NGJLBBBFBBD<global::CFECMBPEGKM<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x858F0", Offset = "0x84CF0")]
	private readonly global::LGOOHNLAPNA<TData> NJBEKEKLFGB;

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x2EFDFF0", Offset = "0x2EFC7F0", VA = "0x182EFDFF0")]
	public BNAEDOFMMKA(IEnumerable<TData> JKLNEELBHOJ, Vector3 JAEADBEBFDD, bool POAIHEGPCFG, global::CFECMBPEGKM<TData> ONMFHPEEBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x29CBAE0", Offset = "0x29CA2E0", VA = "0x1829CBAE0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x49BEF50", Offset = "0x49BD750", VA = "0x1849BEF50")]
	public LGOOHNLAPNA(IEnumerable<TData> JKLNEELBHOJ, Vector3 JAEADBEBFDD, bool POAIHEGPCFG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface CFECMBPEGKM<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BNHDLCIOKEP([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x85950", Offset = "0x84D50")] in global::LGOOHNLAPNA<TData?> NJBEKEKLFGB);
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x859C0", Offset = "0x84DC0")]
public class KHJEPGNHCBA<TData> : global::NGJLBBBFBBD<global::EFKCPJBOKJH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly bool POAIHEGPCFG;

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x24A1FF0", Offset = "0x24A07F0", VA = "0x1824A1FF0")]
	public KHJEPGNHCBA(bool POAIHEGPCFG, global::EFKCPJBOKJH<TData> ONMFHPEEBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x24A1F80", Offset = "0x24A0780", VA = "0x1824A1F80", Slot = "4")]
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
	bool HICKOCLAHCN([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x85A30", Offset = "0x84E30")] in global::EOKNJMCHCMP<TNode?> FOCFDAPBECJ);

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KLHLKDPOIID([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x85AA0", Offset = "0x84EA0")] in global::BBADHJNACOD<TNode?> AGFHKIGMLAI);

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool OIMCADDMNMH();
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x85B10", Offset = "0x84F10")]
public class AGCOLPGKILK<TNode> : global::NGJLBBBFBBD<global::GEIILMDDHOC<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x249D730", Offset = "0x249BF30", VA = "0x18249D730")]
	public AGCOLPGKILK(global::GEIILMDDHOC<TNode> ONMFHPEEBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3665620", Offset = "0x3663E20", VA = "0x183665620", Slot = "4")]
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
	void BNHDLCIOKEP([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x85B80", Offset = "0x84F80")] in global::FECKOPIDLIL<TData?> COIONAJGENL);
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
		[Cpp2IlInjected.Address(RVA = "0x1667F50", Offset = "0x1666750", VA = "0x181667F50")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	internal static MHOBEFMLEFD MLGFLIHDPHB
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x1667BB0", Offset = "0x16663B0", VA = "0x181667BB0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x1667C90", Offset = "0x1666490", VA = "0x181667C90")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x1667D60", Offset = "0x1666560", VA = "0x181667D60")]
	[BBAPFPLPODF(BLGLNFDFDJO.Room, EDNJEIFHIMJ.None)]
	private static void MCFKFGEHJOK(MHOBEFMLEFD DABKGFKDEBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x1667E10", Offset = "0x1666610", VA = "0x181667E10")]
	public static void NHGHFKAFNCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x1667D10", Offset = "0x1666510", VA = "0x181667D10")]
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
	[Cpp2IlInjected.Address(RVA = "0x424C810", Offset = "0x424B010", VA = "0x18424C810")]
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
	[Cpp2IlInjected.Address(RVA = "0x39C86A0", Offset = "0x39C6EA0", VA = "0x1839C86A0")]
	public IOIDNKIHFNN(IEnumerable<TData> JKLNEELBHOJ, MFJEBBFONBC OPOEPBAFNOG, BIFNIOGHPEJ IJIKACDMPFI, float GBNPCMDBPJC, bool POAIHEGPCFG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x85C30", Offset = "0x85030")]
public class LLBPEINAHNO<TData> : global::NGJLBBBFBBD<global::EMPGBLPIOEP<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly CCPJGMLDGJK EOEBGBGLIBA;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x49C92E0", Offset = "0x49C7AE0", VA = "0x1849C92E0")]
	public LLBPEINAHNO(Vector3 AMMCBKOAOAI, float OMOAPNBJLBI, Vector3 CNMOHJEEHNB, bool DIIDBHNHLPI, global::EMPGBLPIOEP<TData> ONMFHPEEBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x387DED0", Offset = "0x387C6D0", VA = "0x18387DED0", Slot = "4")]
	public override bool BNHDLCIOKEP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x85CA0", Offset = "0x850A0")]
public class IEFFPIPADOL<TData> : global::NGJLBBBFBBD<global::EFKCPJBOKJH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x85D10", Offset = "0x85110")]
	private readonly global::OLMJHALJGMI<TData> ACDKDGHLAPG;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x1CA09E0", Offset = "0x1C9F1E0", VA = "0x181CA09E0")]
	public IEFFPIPADOL(List<TData> IHGFGANOELJ, global::EFKCPJBOKJH<TData> ONMFHPEEBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x1CA0910", Offset = "0x1C9F110", VA = "0x181CA0910", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x3867ED0", Offset = "0x38666D0", VA = "0x183867ED0")]
	public EKEBFLABIPL(IEnumerable<TData> JKLNEELBHOJ, bool POAIHEGPCFG = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x85DB0", Offset = "0x851B0")]
public class BMGBOGLDCMN<TData> : global::NGJLBBBFBBD<global::EFKCPJBOKJH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x85E20", Offset = "0x85220")]
	private readonly global::OLMJHALJGMI<TData> ACDKDGHLAPG;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x2EF9DD0", Offset = "0x2EF85D0", VA = "0x182EF9DD0")]
	public BMGBOGLDCMN(List<TData> IHGFGANOELJ, bool POAIHEGPCFG, global::EFKCPJBOKJH<TData> ONMFHPEEBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x2EF9D00", Offset = "0x2EF8500", VA = "0x182EF9D00", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x34BFB60", Offset = "0x34BE360", VA = "0x1834BFB60")]
	public ILBPFIAMBDG(IEnumerable<TData> JKLNEELBHOJ, bool POAIHEGPCFG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x85E80", Offset = "0x85280")]
public class DLDNGDMJCKD<TData> : global::KFKLJFLAKON<global::FPHCOFHHGAD<TData>, MHPBAPDBIDB> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x85EF0", Offset = "0x852F0")]
	private readonly global::EKEBFLABIPL<TData> CKLCJMHIDPL;

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2F83A40", Offset = "0x2F82240", VA = "0x182F83A40")]
	public DLDNGDMJCKD(IEnumerable<TData> JKLNEELBHOJ, bool POAIHEGPCFG, global::FPHCOFHHGAD<TData> ONMFHPEEBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x2F83800", Offset = "0x2F82000", VA = "0x182F83800", Slot = "4")]
	public override Task<MHPBAPDBIDB> BNHDLCIOKEP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x85F50", Offset = "0x85350")]
public class IPOBFNMDFAC<TData> : global::NGJLBBBFBBD<global::KPMKNCMBLFB<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x85FC0", Offset = "0x853C0")]
	private readonly global::FPKDKGAELHC<TData> BEJMPMMMODH;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x39CB500", Offset = "0x39C9D00", VA = "0x1839CB500")]
	public IPOBFNMDFAC(TData CBHLPGJGAKG, bool POAIHEGPCFG, global::KPMKNCMBLFB<TData> ONMFHPEEBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x29CBAE0", Offset = "0x29CA2E0", VA = "0x1829CBAE0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x3601DE0", Offset = "0x36005E0", VA = "0x183601DE0")]
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
	[Cpp2IlInjected.Address(RVA = "0x398C720", Offset = "0x398AF20", VA = "0x18398C720")]
	public JLGBLCCKPII(IEnumerable<TData> JKLNEELBHOJ, bool POAIHEGPCFG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x86020", Offset = "0x85420")]
public class JENFIJINLJH<TData> : global::NGJLBBBFBBD<global::EMPGBLPIOEP<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly HJCPHFOMKGD EOEBGBGLIBA;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x32EE9C0", Offset = "0x32ED1C0", VA = "0x1832EE9C0")]
	public JENFIJINLJH(float OMOAPNBJLBI, Vector3 CNMOHJEEHNB, global::EMPGBLPIOEP<TData> ONMFHPEEBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x29CBCE0", Offset = "0x29CA4E0", VA = "0x1829CBCE0", Slot = "4")]
	public override bool BNHDLCIOKEP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x86090", Offset = "0x85490")]
public class OLPAELJCBIG<TData> : global::NGJLBBBFBBD<global::KPHFKFGAEPF<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x249D730", Offset = "0x249BF30", VA = "0x18249D730")]
	public OLPAELJCBIG(global::KPHFKFGAEPF<TData> ONMFHPEEBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x3665620", Offset = "0x3663E20", VA = "0x183665620", Slot = "4")]
	public override bool BNHDLCIOKEP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x86100", Offset = "0x85500")]
public class NGLLELFKOBO<TData> : global::NGJLBBBFBBD<global::KPHFKFGAEPF<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x86170", Offset = "0x85570")]
	private readonly global::JONKFFADLHH<TData> PINLIGDEJBB;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x29CBC40", Offset = "0x29CA440", VA = "0x1829CBC40")]
	public NGLLELFKOBO(IEnumerable<TData> JKLNEELBHOJ, bool POAIHEGPCFG, global::KPHFKFGAEPF<TData> ONMFHPEEBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x29CBAE0", Offset = "0x29CA2E0", VA = "0x1829CBAE0", Slot = "4")]
	public override bool BNHDLCIOKEP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x861D0", Offset = "0x855D0")]
public class HHHNMMMOLMB<TNode> : global::NGJLBBBFBBD<global::GEIILMDDHOC<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x86240", Offset = "0x85640")]
	private readonly global::EOKNJMCHCMP<TNode> FOCFDAPBECJ;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x49364E0", Offset = "0x4934CE0", VA = "0x1849364E0")]
	public HHHNMMMOLMB(TNode KEJPLMDBPBP, global::GEIILMDDHOC<TNode> ONMFHPEEBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x29CBAE0", Offset = "0x29CA2E0", VA = "0x1829CBAE0", Slot = "4")]
	public override bool BNHDLCIOKEP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x862A0", Offset = "0x856A0")]
public class GHFJFEPPHIH<TData> : global::NGJLBBBFBBD<global::CHHPAIKEDAA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x86310", Offset = "0x85710")]
	private readonly global::JLGBLCCKPII<TData> NJBEKEKLFGB;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2BDD450", Offset = "0x2BDBC50", VA = "0x182BDD450")]
	public GHFJFEPPHIH(IEnumerable<TData> JKLNEELBHOJ, bool POAIHEGPCFG, global::CHHPAIKEDAA<TData> ONMFHPEEBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x29CBAE0", Offset = "0x29CA2E0", VA = "0x1829CBAE0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x3D22DF0", Offset = "0x3D215F0", VA = "0x183D22DF0")]
	public JONKFFADLHH(IEnumerable<TData> JKLNEELBHOJ, bool POAIHEGPCFG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x86370", Offset = "0x85770")]
public class PCONOOKHHBB<TNode> : global::NGJLBBBFBBD<global::GEIILMDDHOC<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x863E0", Offset = "0x857E0")]
	private readonly global::BBADHJNACOD<TNode> AGFHKIGMLAI;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x409BDE0", Offset = "0x409A5E0", VA = "0x18409BDE0")]
	public PCONOOKHHBB(TNode HOJFPNNGODA, FIBPDFDOBGG HOFHDBGLCKH, global::GEIILMDDHOC<TNode> ONMFHPEEBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x409BD10", Offset = "0x409A510", VA = "0x18409BD10", Slot = "4")]
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
	Task<MHPBAPDBIDB> KNALOLAOOIF([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x86440", Offset = "0x85840")] in global::EKEBFLABIPL<TData> ACDKDGHLAPG, CancellationToken GFFFFCALMCA);
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface EFKCPJBOKJH<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JAMGJNEIAKD([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x864B0", Offset = "0x858B0")] in global::OLMJHALJGMI<TData> ACDKDGHLAPG);

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IOGAMAHKFNK([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x86520", Offset = "0x85920")] in global::OLMJHALJGMI<TData> ACDKDGHLAPG);

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IIBOIOFFHLD(in bool ECAPFECLFFO);

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool AMBMJMIEJPE([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x86590", Offset = "0x85990")] in global::OLMJHALJGMI<TData> ACDKDGHLAPG);

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
	[Cpp2IlInjected.Address(RVA = "0x1668080", Offset = "0x1666880", VA = "0x181668080")]
	public PLBBGJPDMOA(Quaternion JAEADBEBFDD, Vector3? CNMOHJEEHNB, bool HGMINIJGMNM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface KPMKNCMBLFB<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HICKOCLAHCN([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x86600", Offset = "0x85A00")] in global::FPKDKGAELHC<TData?> FOCFDAPBECJ);

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
	[Cpp2IlInjected.Address(RVA = "0x1579660", Offset = "0x1577E60", VA = "0x181579660")]
	public MFHCFHBEBOG(Vector3 JAEADBEBFDD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x86670", Offset = "0x85A70")]
public class KJFEDIDPMLO<TData> : global::NGJLBBBFBBD<global::ODKABPDBKIC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x866E0", Offset = "0x85AE0")]
	private readonly global::OJEDNNNAIFM<TData> PINLIGDEJBB;

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x324CC30", Offset = "0x324B430", VA = "0x18324CC30")]
	public KJFEDIDPMLO(IEnumerable<TData> JKLNEELBHOJ, Quaternion JAEADBEBFDD, Vector3? CNMOHJEEHNB, bool HGMINIJGMNM, bool POAIHEGPCFG, global::ODKABPDBKIC<TData> ONMFHPEEBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x29CBAE0", Offset = "0x29CA2E0", VA = "0x1829CBAE0", Slot = "4")]
	public override bool BNHDLCIOKEP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x86740", Offset = "0x85B40")]
public class BMECFHLJFBF<TData> : global::NGJLBBBFBBD<global::EMPGBLPIOEP<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x249D730", Offset = "0x249BF30", VA = "0x18249D730")]
	public BMECFHLJFBF(global::EMPGBLPIOEP<TData> ONMFHPEEBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x2EF9920", Offset = "0x2EF8120", VA = "0x182EF9920", Slot = "4")]
	public override bool BNHDLCIOKEP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x867B0", Offset = "0x85BB0")]
public class PKHEEKAEBNO<TData> : global::NGJLBBBFBBD<global::KPHFKFGAEPF<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly PLBBGJPDMOA PINLIGDEJBB;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x3D598F0", Offset = "0x3D580F0", VA = "0x183D598F0")]
	public PKHEEKAEBNO(Quaternion JAEADBEBFDD, Vector3? CNMOHJEEHNB, bool HGMINIJGMNM, global::KPHFKFGAEPF<TData> ONMFHPEEBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x29CBCE0", Offset = "0x29CA4E0", VA = "0x1829CBCE0", Slot = "4")]
	public override bool BNHDLCIOKEP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x86820", Offset = "0x85C20")]
public class PFKCDPKKPIG<TData> : global::NGJLBBBFBBD<global::DGBCINDDGOC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x86890", Offset = "0x85C90")]
	private readonly global::FECKOPIDLIL<TData> COIONAJGENL;

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x40A9FF0", Offset = "0x40A87F0", VA = "0x1840A9FF0")]
	public PFKCDPKKPIG(TData[] JKLNEELBHOJ, MFJEBBFONBC[] OPOEPBAFNOG, BIFNIOGHPEJ[] IJIKACDMPFI, float[] GBNPCMDBPJC, global::DGBCINDDGOC<TData> ONMFHPEEBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x40A9520", Offset = "0x40A7D20", VA = "0x1840A9520", Slot = "4")]
	public override bool BNHDLCIOKEP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x868F0", Offset = "0x85CF0")]
public class MDCAHGFPHJF<TData> : global::NGJLBBBFBBD<global::FLMAKGKBMAB<TData>> where TData : notnull, JMCLLHIJENJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x86960", Offset = "0x85D60")]
	private readonly global::OEIHKBNNHAA<TData> ICBGEJKPEAO;

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x365A240", Offset = "0x3658A40", VA = "0x18365A240")]
	public MDCAHGFPHJF(List<TData> JKLNEELBHOJ, List<bool> NCJMKCFJPEH, global::FLMAKGKBMAB<TData> ONMFHPEEBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x2EF9D00", Offset = "0x2EF8500", VA = "0x182EF9D00", Slot = "4")]
	public override bool BNHDLCIOKEP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x869C0", Offset = "0x85DC0")]
public class MGMDANEKMHO<TData> : global::NGJLBBBFBBD<global::CHHPAIKEDAA<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x249D730", Offset = "0x249BF30", VA = "0x18249D730")]
	public MGMDANEKMHO(global::CHHPAIKEDAA<TData> ONMFHPEEBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x3665620", Offset = "0x3663E20", VA = "0x183665620", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x1667900", Offset = "0x1666100", VA = "0x181667900")]
	public FJBMIIEPEOP(Vector3 OEICOCPNACP, bool KPKFGDAIIIJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public interface OOCCBMPCEOK<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KDPCJNFNOJO([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x86A30", Offset = "0x85E30")] in global::PFJGDGKEAEA<TData?> COIONAJGENL);

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KLHLKDPOIID();
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x86AA0", Offset = "0x85EA0")]
public class PEOJFHEJGNJ<TData> : global::NGJLBBBFBBD<global::OOCCBMPCEOK<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x86B10", Offset = "0x85F10")]
	private readonly global::PFJGDGKEAEA<TData> COIONAJGENL;

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x40A95E0", Offset = "0x40A7DE0", VA = "0x1840A95E0")]
	public PEOJFHEJGNJ(IEnumerable<TData> JKLNEELBHOJ, MFJEBBFONBC OPOEPBAFNOG, BIFNIOGHPEJ IJIKACDMPFI, float GBNPCMDBPJC, global::OOCCBMPCEOK<TData> ONMFHPEEBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x40A9520", Offset = "0x40A7D20", VA = "0x1840A9520", Slot = "4")]
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
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x86B70", Offset = "0x85F70")]
public class EOAEPGCAPAL<TData> : global::NGJLBBBFBBD<global::KPMKNCMBLFB<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly DKBOOAPBOFG BEJMPMMMODH;

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x387DF40", Offset = "0x387C740", VA = "0x18387DF40")]
	public EOAEPGCAPAL(Guid ENGCGOEGJAE, int NHHNPPKPBIA, Vector3 NABPHMOHNDG, Quaternion KDPJNNPKKHC, float EAHPLIAGBOI, bool KPKFGDAIIIJ, global::KPMKNCMBLFB<TData> ONMFHPEEBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x387DED0", Offset = "0x387C6D0", VA = "0x18387DED0", Slot = "4")]
	public override bool BNHDLCIOKEP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x86BE0", Offset = "0x85FE0")]
public class FPOHMDDGHHA<TData> : global::NGJLBBBFBBD<global::FLMAKGKBMAB<TData>> where TData : notnull, JMCLLHIJENJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x86C50", Offset = "0x86050")]
	private readonly global::NBGMICDKHJH<TData> ICBGEJKPEAO;

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x3601F50", Offset = "0x3600750", VA = "0x183601F50")]
	public FPOHMDDGHHA(List<TData> JKLNEELBHOJ, bool HIICENNMGHM, global::FLMAKGKBMAB<TData> ONMFHPEEBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x29CBAE0", Offset = "0x29CA2E0", VA = "0x1829CBAE0", Slot = "4")]
	public override bool BNHDLCIOKEP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x86CB0", Offset = "0x860B0")]
public class IDHLLGEJCDE<TData> : global::NGJLBBBFBBD<global::EFKCPJBOKJH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly TData EPCJEHBDOPK;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x1C9FB60", Offset = "0x1C9E360", VA = "0x181C9FB60")]
	public IDHLLGEJCDE(TData EPCJEHBDOPK, global::EFKCPJBOKJH<TData> ONMFHPEEBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x1C9FA90", Offset = "0x1C9E290", VA = "0x181C9FA90", Slot = "4")]
	public override bool BNHDLCIOKEP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x86D20", Offset = "0x86120")]
public abstract class NGJLBBBFBBD<TReceiver> : global::CKEKECNMLLI<TReceiver, bool> where TReceiver : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x249D730", Offset = "0x249BF30", VA = "0x18249D730")]
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
	[Cpp2IlInjected.Address(RVA = "0x341CAD0", Offset = "0x341B2D0", VA = "0x18341CAD0")]
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
	[Cpp2IlInjected.Address(RVA = "0x3AA3230", Offset = "0x3AA1A30", VA = "0x183AA3230")]
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
	bool HICKOCLAHCN([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x86D90", Offset = "0x86190")] in global::JLGBLCCKPII<TData?> ANCGLCMDIED);

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KDPCJNFNOJO(in MFHCFHBEBOG MAKEPDAPPEE);

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool KLHLKDPOIID();
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x86E00", Offset = "0x86200")]
public class DLKOCGHGGJI<TData> : global::NGJLBBBFBBD<global::OOCCBMPCEOK<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x249D730", Offset = "0x249BF30", VA = "0x18249D730")]
	public DLKOCGHGGJI(global::OOCCBMPCEOK<TData> ONMFHPEEBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x2F84F90", Offset = "0x2F83790", VA = "0x182F84F90", Slot = "4")]
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
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x86E70", Offset = "0x86270")]
public abstract class KFKLJFLAKON<TReceiver, TFromTask> : global::CKEKECNMLLI<TReceiver, Task<TFromTask>>
{
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x249D730", Offset = "0x249BF30", VA = "0x18249D730")]
	public KFKLJFLAKON(TReceiver ONMFHPEEBAL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x86EE0", Offset = "0x862E0")]
public class DNNFPBPNMLI<TData> : global::NGJLBBBFBBD<global::EMPGBLPIOEP<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x86F50", Offset = "0x86350")]
	private readonly global::ILBPFIAMBDG<TData> EOEBGBGLIBA;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x2F86FF0", Offset = "0x2F857F0", VA = "0x182F86FF0")]
	public DNNFPBPNMLI(IEnumerable<TData> JKLNEELBHOJ, bool POAIHEGPCFG, global::EMPGBLPIOEP<TData> ONMFHPEEBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x29CBAE0", Offset = "0x29CA2E0", VA = "0x1829CBAE0", Slot = "4")]
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
	bool BNHDLCIOKEP([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x86FB0", Offset = "0x863B0")] in global::IOIDNKIHFNN<TData?> COIONAJGENL);
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
