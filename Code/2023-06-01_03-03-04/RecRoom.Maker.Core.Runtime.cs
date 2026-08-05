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
		[Cpp2IlInjected.Address(RVA = "0x7F3020", Offset = "0x7F1C20", VA = "0x1807F3020")]
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
		[Cpp2IlInjected.Address(RVA = "0x6FD6770", Offset = "0x6FD5370", VA = "0x186FD6770")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x83E010", Offset = "0x83CC10", VA = "0x18083E010")]
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
		[Cpp2IlInjected.Address(RVA = "0xBF6D90", Offset = "0xBF5990", VA = "0x180BF6D90")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7AFC00", Offset = "0x7AF000")]
public class NGPCACBFCIK<TData> : NGJLBBBFBBD<KPMKNCMBLFB<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly FJBMIIEPEOP BEJMPMMMODH;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x1FBF1C0", Offset = "0x1FBDDC0", VA = "0x181FBF1C0")]
	public NGPCACBFCIK(Vector3 OEICOCPNACP, bool KPKFGDAIIIJ, KPMKNCMBLFB<TData> ONMFHPEEBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x1FBF150", Offset = "0x1FBDD50", VA = "0x181FBF150", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x48983B0", Offset = "0x4896FB0", VA = "0x1848983B0")]
	public OLMJHALJGMI(IEnumerable<TData> NGMFDEJHMNF, bool BIJFKJEIJPP = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface EMPGBLPIOEP<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HICKOCLAHCN([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7AFC70", Offset = "0x7AF070")] in ILBPFIAMBDG<TData?> FOCFDAPBECJ);

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
	[Cpp2IlInjected.Address(RVA = "0x1B100B0", Offset = "0x1B0ECB0", VA = "0x181B100B0")]
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
	[Cpp2IlInjected.Address(RVA = "0x4893C90", Offset = "0x4892890", VA = "0x184893C90")]
	public BBADHJNACOD(TNode HOJFPNNGODA, FIBPDFDOBGG HOFHDBGLCKH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7ADFD0", Offset = "0x7AD3D0")]
public class JCDPEAGMOGH<TData> : NGJLBBBFBBD<EFKCPJBOKJH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7AE040", Offset = "0x7AD440")]
	private readonly OLMJHALJGMI<TData> ACDKDGHLAPG;

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3EAF4A0", Offset = "0x3EAE0A0", VA = "0x183EAF4A0")]
	public JCDPEAGMOGH(List<TData> IHGFGANOELJ, EFKCPJBOKJH<TData> ONMFHPEEBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x1FBEF50", Offset = "0x1FBDB50", VA = "0x181FBEF50", Slot = "4")]
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
	bool BNHDLCIOKEP([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7AE0A0", Offset = "0x7AD4A0")] in OJEDNNNAIFM<TData?> PINLIGDEJBB);
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
	[Cpp2IlInjected.Address(RVA = "0x3A78320", Offset = "0x3A76F20", VA = "0x183A78320")]
	public PFJGDGKEAEA(IEnumerable<TData> JKLNEELBHOJ, MFJEBBFONBC OPOEPBAFNOG, BIFNIOGHPEJ IJIKACDMPFI, float GBNPCMDBPJC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
internal static class IODCLPJPOPG
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6FD60C0", Offset = "0x6FD4CC0", VA = "0x186FD60C0")]
	public static void KHMAIMACAIA(IEnumerable IHKODGEFCEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x1F1BD90", Offset = "0x1F1A990", VA = "0x181F1BD90")]
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
	[Cpp2IlInjected.Address(RVA = "0x1D68330", Offset = "0x1D66F30", VA = "0x181D68330")]
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
	[Cpp2IlInjected.Address(RVA = "0x6FD6060", Offset = "0x6FD4C60", VA = "0x186FD6060")]
	public DKBOOAPBOFG(Guid ENGCGOEGJAE, int NHHNPPKPBIA, Vector3 NABPHMOHNDG, Quaternion KDPJNNPKKHC, float EAHPLIAGBOI, bool KPKFGDAIIIJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface KPHFKFGAEPF<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HICKOCLAHCN([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7AE110", Offset = "0x7AD510")] in JONKFFADLHH<TData?> FOCFDAPBECJ);

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
	[Cpp2IlInjected.Address(RVA = "0x502C0B0", Offset = "0x502ACB0", VA = "0x18502C0B0")]
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
	[Cpp2IlInjected.Address(RVA = "0x6FD6030", Offset = "0x6FD4C30", VA = "0x186FD6030")]
	public CCPJGMLDGJK(Vector3 AMMCBKOAOAI, float OMOAPNBJLBI, Vector3 CNMOHJEEHNB, bool KPKFGDAIIIJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7AE180", Offset = "0x7AD580")]
public class OCHCCKCPKMN<TData> : NGJLBBBFBBD<CHHPAIKEDAA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly MFHCFHBEBOG NJBEKEKLFGB;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x4872420", Offset = "0x4871020", VA = "0x184872420")]
	public OCHCCKCPKMN(Vector3 JAEADBEBFDD, CHHPAIKEDAA<TData> ONMFHPEEBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x1FBF150", Offset = "0x1FBDD50", VA = "0x181FBF150", Slot = "4")]
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
	bool BNHDLCIOKEP([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7AE1F0", Offset = "0x7AD5F0")] in NBGMICDKHJH<TData> ICBGEJKPEAO);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BNHDLCIOKEP([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7AE260", Offset = "0x7AD660")] in OEIHKBNNHAA<TData> ICBGEJKPEAO);
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
	[Cpp2IlInjected.Address(RVA = "0x1F616D0", Offset = "0x1F602D0", VA = "0x181F616D0")]
	public static void JBADHJNEGOK<T>(T PKIKEDNMDGD, MJELDEPAKFL FIJCKHKKDCC) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x1F61850", Offset = "0x1F60450", VA = "0x181F61850")]
	public static void JBADHJNEGOK<T>(T PKIKEDNMDGD) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x1F618E0", Offset = "0x1F604E0", VA = "0x181F618E0")]
	public static T PNBJHLBKMLC<T>(MJELDEPAKFL FIJCKHKKDCC) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x1F619A0", Offset = "0x1F605A0", VA = "0x181F619A0")]
	public static T PNBJHLBKMLC<T>() where T : class
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7AE2D0", Offset = "0x7AD6D0")]
public class MKCBIMCMEII<TData> : NGJLBBBFBBD<EFKCPJBOKJH<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x1D58E10", Offset = "0x1D57A10", VA = "0x181D58E10")]
	public MKCBIMCMEII(EFKCPJBOKJH<TData> ONMFHPEEBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x2C76010", Offset = "0x2C74C10", VA = "0x182C76010", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x29A7F50", Offset = "0x29A6B50", VA = "0x1829A7F50")]
	public CKEKECNMLLI(TReceiver ONMFHPEEBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TFromExecute BNHDLCIOKEP();
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7AE340", Offset = "0x7AD740")]
public class AEFNCLHNFEM<TData> : NGJLBBBFBBD<BHEHLKIIBIN<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7AE3B0", Offset = "0x7AD7B0")]
	private readonly IOIDNKIHFNN<TData> COIONAJGENL;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3806570", Offset = "0x3805170", VA = "0x183806570")]
	public AEFNCLHNFEM(IEnumerable<TData> JKLNEELBHOJ, MFJEBBFONBC OPOEPBAFNOG, BIFNIOGHPEJ IJIKACDMPFI, float GBNPCMDBPJC, bool POAIHEGPCFG, BHEHLKIIBIN<TData> ONMFHPEEBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x1FBEF50", Offset = "0x1FBDB50", VA = "0x181FBEF50", Slot = "4")]
	public override bool BNHDLCIOKEP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7AE410", Offset = "0x7AD810")]
public class MMCMFAKDPCC<TData> : NGJLBBBFBBD<KPMKNCMBLFB<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x1D58E10", Offset = "0x1D57A10", VA = "0x181D58E10")]
	public MMCMFAKDPCC(KPMKNCMBLFB<TData> ONMFHPEEBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x2C81E10", Offset = "0x2C80A10", VA = "0x182C81E10", Slot = "4")]
	public override bool BNHDLCIOKEP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7AE480", Offset = "0x7AD880")]
public class BNAEDOFMMKA<TData> : NGJLBBBFBBD<CFECMBPEGKM<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7AE4F0", Offset = "0x7AD8F0")]
	private readonly LGOOHNLAPNA<TData> NJBEKEKLFGB;

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x34B1C90", Offset = "0x34B0890", VA = "0x1834B1C90")]
	public BNAEDOFMMKA(IEnumerable<TData> JKLNEELBHOJ, Vector3 JAEADBEBFDD, bool POAIHEGPCFG, CFECMBPEGKM<TData> ONMFHPEEBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x1FBEF50", Offset = "0x1FBDB50", VA = "0x181FBEF50", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x34B9AF0", Offset = "0x34B86F0", VA = "0x1834B9AF0")]
	public LGOOHNLAPNA(IEnumerable<TData> JKLNEELBHOJ, Vector3 JAEADBEBFDD, bool POAIHEGPCFG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface CFECMBPEGKM<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BNHDLCIOKEP([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7AE550", Offset = "0x7AD950")] in LGOOHNLAPNA<TData?> NJBEKEKLFGB);
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7AE5C0", Offset = "0x7AD9C0")]
public class KHJEPGNHCBA<TData> : NGJLBBBFBBD<EFKCPJBOKJH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly bool POAIHEGPCFG;

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2C3C830", Offset = "0x2C3B430", VA = "0x182C3C830")]
	public KHJEPGNHCBA(bool POAIHEGPCFG, EFKCPJBOKJH<TData> ONMFHPEEBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2C3C7C0", Offset = "0x2C3B3C0", VA = "0x182C3C7C0", Slot = "4")]
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
	bool HICKOCLAHCN([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7AE630", Offset = "0x7ADA30")] in EOKNJMCHCMP<TNode?> FOCFDAPBECJ);

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KLHLKDPOIID([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7AE6A0", Offset = "0x7ADAA0")] in BBADHJNACOD<TNode?> AGFHKIGMLAI);

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool OIMCADDMNMH();
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7AE710", Offset = "0x7ADB10")]
public class AGCOLPGKILK<TNode> : NGJLBBBFBBD<GEIILMDDHOC<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x1D58E10", Offset = "0x1D57A10", VA = "0x181D58E10")]
	public AGCOLPGKILK(GEIILMDDHOC<TNode> ONMFHPEEBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x350DC30", Offset = "0x350C830", VA = "0x18350DC30", Slot = "4")]
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
	void BNHDLCIOKEP([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7AE780", Offset = "0x7ADB80")] in FECKOPIDLIL<TData?> COIONAJGENL);
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
		[Cpp2IlInjected.Address(RVA = "0x6FD66D0", Offset = "0x6FD52D0", VA = "0x186FD66D0")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	internal static MHOBEFMLEFD MLGFLIHDPHB
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x6FD6330", Offset = "0x6FD4F30", VA = "0x186FD6330")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6FD6410", Offset = "0x6FD5010", VA = "0x186FD6410")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6FD64E0", Offset = "0x6FD50E0", VA = "0x186FD64E0")]
	[BBAPFPLPODF(BLGLNFDFDJO.Room, EDNJEIFHIMJ.None)]
	private static void MCFKFGEHJOK(MHOBEFMLEFD DABKGFKDEBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6FD6590", Offset = "0x6FD5190", VA = "0x186FD6590")]
	public static void NHGHFKAFNCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6FD6490", Offset = "0x6FD5090", VA = "0x186FD6490")]
	private static MHOBEFMLEFD LJNFCOJPLGL(MHOBEFMLEFD EOHDEJOCEFD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface ONMAIAAEPDN<TData> : ANIJJOLDOAL, NONDFKAKFJJ<TData>, EFKCPJBOKJH<TData>, OHHGJOPBPAO<TData>, NAONIBGKDCK, KOODPMGPAGA<TData>, AEHFJOHEHBB
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
	[Cpp2IlInjected.Address(RVA = "0x353C100", Offset = "0x353AD00", VA = "0x18353C100")]
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
	[Cpp2IlInjected.Address(RVA = "0x38723A0", Offset = "0x3870FA0", VA = "0x1838723A0")]
	public IOIDNKIHFNN(IEnumerable<TData> JKLNEELBHOJ, MFJEBBFONBC OPOEPBAFNOG, BIFNIOGHPEJ IJIKACDMPFI, float GBNPCMDBPJC, bool POAIHEGPCFG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7AE810", Offset = "0x7ADC10")]
public class LLBPEINAHNO<TData> : NGJLBBBFBBD<EMPGBLPIOEP<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly CCPJGMLDGJK EOEBGBGLIBA;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x34C35B0", Offset = "0x34C21B0", VA = "0x1834C35B0")]
	public LLBPEINAHNO(Vector3 AMMCBKOAOAI, float OMOAPNBJLBI, Vector3 CNMOHJEEHNB, bool DIIDBHNHLPI, EMPGBLPIOEP<TData> ONMFHPEEBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x1B0A750", Offset = "0x1B09350", VA = "0x181B0A750", Slot = "4")]
	public override bool BNHDLCIOKEP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7AE880", Offset = "0x7ADC80")]
public class IEFFPIPADOL<TData> : NGJLBBBFBBD<EFKCPJBOKJH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7AE8F0", Offset = "0x7ADCF0")]
	private readonly OLMJHALJGMI<TData> ACDKDGHLAPG;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x1C748D0", Offset = "0x1C734D0", VA = "0x181C748D0")]
	public IEFFPIPADOL(List<TData> IHGFGANOELJ, EFKCPJBOKJH<TData> ONMFHPEEBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x1C74800", Offset = "0x1C73400", VA = "0x181C74800", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x3292FC0", Offset = "0x3291BC0", VA = "0x183292FC0")]
	public EKEBFLABIPL(IEnumerable<TData> JKLNEELBHOJ, bool POAIHEGPCFG = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7AE990", Offset = "0x7ADD90")]
public class BMGBOGLDCMN<TData> : NGJLBBBFBBD<EFKCPJBOKJH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7AEA00", Offset = "0x7ADE00")]
	private readonly OLMJHALJGMI<TData> ACDKDGHLAPG;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x34AA490", Offset = "0x34A9090", VA = "0x1834AA490")]
	public BMGBOGLDCMN(List<TData> IHGFGANOELJ, bool POAIHEGPCFG, EFKCPJBOKJH<TData> ONMFHPEEBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x34AA3C0", Offset = "0x34A8FC0", VA = "0x1834AA3C0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x346A880", Offset = "0x3469480", VA = "0x18346A880")]
	public ILBPFIAMBDG(IEnumerable<TData> JKLNEELBHOJ, bool POAIHEGPCFG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7AEA60", Offset = "0x7ADE60")]
public class DLDNGDMJCKD<TData> : KFKLJFLAKON<FPHCOFHHGAD<TData>, MHPBAPDBIDB> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7AEAD0", Offset = "0x7ADED0")]
	private readonly EKEBFLABIPL<TData> CKLCJMHIDPL;

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2A47B30", Offset = "0x2A46730", VA = "0x182A47B30")]
	public DLDNGDMJCKD(IEnumerable<TData> JKLNEELBHOJ, bool POAIHEGPCFG, FPHCOFHHGAD<TData> ONMFHPEEBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x2A478F0", Offset = "0x2A464F0", VA = "0x182A478F0", Slot = "4")]
	public override Task<MHPBAPDBIDB> BNHDLCIOKEP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7AEB30", Offset = "0x7ADF30")]
public class IPOBFNMDFAC<TData> : NGJLBBBFBBD<KPMKNCMBLFB<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7AEBA0", Offset = "0x7ADFA0")]
	private readonly FPKDKGAELHC<TData> BEJMPMMMODH;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3874260", Offset = "0x3872E60", VA = "0x183874260")]
	public IPOBFNMDFAC(TData CBHLPGJGAKG, bool POAIHEGPCFG, KPMKNCMBLFB<TData> ONMFHPEEBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x1FBEF50", Offset = "0x1FBDB50", VA = "0x181FBEF50", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x32C7B10", Offset = "0x32C6710", VA = "0x1832C7B10")]
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
	[Cpp2IlInjected.Address(RVA = "0x298C080", Offset = "0x298AC80", VA = "0x18298C080")]
	public JLGBLCCKPII(IEnumerable<TData> JKLNEELBHOJ, bool POAIHEGPCFG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7AEC00", Offset = "0x7AE000")]
public class JENFIJINLJH<TData> : NGJLBBBFBBD<EMPGBLPIOEP<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly HJCPHFOMKGD EOEBGBGLIBA;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3EBF990", Offset = "0x3EBE590", VA = "0x183EBF990")]
	public JENFIJINLJH(float OMOAPNBJLBI, Vector3 CNMOHJEEHNB, EMPGBLPIOEP<TData> ONMFHPEEBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x1FBF150", Offset = "0x1FBDD50", VA = "0x181FBF150", Slot = "4")]
	public override bool BNHDLCIOKEP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7AEC70", Offset = "0x7AE070")]
public class OLPAELJCBIG<TData> : NGJLBBBFBBD<KPHFKFGAEPF<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x1D58E10", Offset = "0x1D57A10", VA = "0x181D58E10")]
	public OLPAELJCBIG(KPHFKFGAEPF<TData> ONMFHPEEBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x350DC30", Offset = "0x350C830", VA = "0x18350DC30", Slot = "4")]
	public override bool BNHDLCIOKEP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7AECE0", Offset = "0x7AE0E0")]
public class NGLLELFKOBO<TData> : NGJLBBBFBBD<KPHFKFGAEPF<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7AED50", Offset = "0x7AE150")]
	private readonly JONKFFADLHH<TData> PINLIGDEJBB;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x1FBF0B0", Offset = "0x1FBDCB0", VA = "0x181FBF0B0")]
	public NGLLELFKOBO(IEnumerable<TData> JKLNEELBHOJ, bool POAIHEGPCFG, KPHFKFGAEPF<TData> ONMFHPEEBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x1FBEF50", Offset = "0x1FBDB50", VA = "0x181FBEF50", Slot = "4")]
	public override bool BNHDLCIOKEP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7AEDB0", Offset = "0x7AE1B0")]
public class HHHNMMMOLMB<TNode> : NGJLBBBFBBD<GEIILMDDHOC<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7AEE20", Offset = "0x7AE220")]
	private readonly EOKNJMCHCMP<TNode> FOCFDAPBECJ;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x45044F0", Offset = "0x45030F0", VA = "0x1845044F0")]
	public HHHNMMMOLMB(TNode KEJPLMDBPBP, GEIILMDDHOC<TNode> ONMFHPEEBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x1FBEF50", Offset = "0x1FBDB50", VA = "0x181FBEF50", Slot = "4")]
	public override bool BNHDLCIOKEP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7AEE80", Offset = "0x7AE280")]
public class GHFJFEPPHIH<TData> : NGJLBBBFBBD<CHHPAIKEDAA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7AEEF0", Offset = "0x7AE2F0")]
	private readonly JLGBLCCKPII<TData> NJBEKEKLFGB;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2604260", Offset = "0x2602E60", VA = "0x182604260")]
	public GHFJFEPPHIH(IEnumerable<TData> JKLNEELBHOJ, bool POAIHEGPCFG, CHHPAIKEDAA<TData> ONMFHPEEBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x1FBEF50", Offset = "0x1FBDB50", VA = "0x181FBEF50", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x329E2E0", Offset = "0x329CEE0", VA = "0x18329E2E0")]
	public JONKFFADLHH(IEnumerable<TData> JKLNEELBHOJ, bool POAIHEGPCFG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7AEF50", Offset = "0x7AE350")]
public class PCONOOKHHBB<TNode> : NGJLBBBFBBD<GEIILMDDHOC<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7AEFC0", Offset = "0x7AE3C0")]
	private readonly BBADHJNACOD<TNode> AGFHKIGMLAI;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x3A6EF80", Offset = "0x3A6DB80", VA = "0x183A6EF80")]
	public PCONOOKHHBB(TNode HOJFPNNGODA, FIBPDFDOBGG HOFHDBGLCKH, GEIILMDDHOC<TNode> ONMFHPEEBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x3A6EEB0", Offset = "0x3A6DAB0", VA = "0x183A6EEB0", Slot = "4")]
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
	Task<MHPBAPDBIDB> KNALOLAOOIF([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7AF020", Offset = "0x7AE420")] in EKEBFLABIPL<TData> ACDKDGHLAPG, CancellationToken GFFFFCALMCA);
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface EFKCPJBOKJH<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JAMGJNEIAKD([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7AF090", Offset = "0x7AE490")] in OLMJHALJGMI<TData> ACDKDGHLAPG);

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IOGAMAHKFNK([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7AF100", Offset = "0x7AE500")] in OLMJHALJGMI<TData> ACDKDGHLAPG);

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IIBOIOFFHLD(in bool ECAPFECLFFO);

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool AMBMJMIEJPE([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7AF170", Offset = "0x7AE570")] in OLMJHALJGMI<TData> ACDKDGHLAPG);

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
	[Cpp2IlInjected.Address(RVA = "0x5CE61D0", Offset = "0x5CE4DD0", VA = "0x185CE61D0")]
	public PLBBGJPDMOA(Quaternion JAEADBEBFDD, Vector3? CNMOHJEEHNB, bool HGMINIJGMNM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface KPMKNCMBLFB<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HICKOCLAHCN([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7AF1E0", Offset = "0x7AE5E0")] in FPKDKGAELHC<TData?> FOCFDAPBECJ);

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
	[Cpp2IlInjected.Address(RVA = "0x3523AD0", Offset = "0x35226D0", VA = "0x183523AD0")]
	public MFHCFHBEBOG(Vector3 JAEADBEBFDD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7AF250", Offset = "0x7AE650")]
public class KJFEDIDPMLO<TData> : NGJLBBBFBBD<ODKABPDBKIC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7AF2C0", Offset = "0x7AE6C0")]
	private readonly OJEDNNNAIFM<TData> PINLIGDEJBB;

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x2C42440", Offset = "0x2C41040", VA = "0x182C42440")]
	public KJFEDIDPMLO(IEnumerable<TData> JKLNEELBHOJ, Quaternion JAEADBEBFDD, Vector3? CNMOHJEEHNB, bool HGMINIJGMNM, bool POAIHEGPCFG, ODKABPDBKIC<TData> ONMFHPEEBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x1FBEF50", Offset = "0x1FBDB50", VA = "0x181FBEF50", Slot = "4")]
	public override bool BNHDLCIOKEP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7AF320", Offset = "0x7AE720")]
public class BMECFHLJFBF<TData> : NGJLBBBFBBD<EMPGBLPIOEP<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x1D58E10", Offset = "0x1D57A10", VA = "0x181D58E10")]
	public BMECFHLJFBF(EMPGBLPIOEP<TData> ONMFHPEEBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x2C81E10", Offset = "0x2C80A10", VA = "0x182C81E10", Slot = "4")]
	public override bool BNHDLCIOKEP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7AF390", Offset = "0x7AE790")]
public class PKHEEKAEBNO<TData> : NGJLBBBFBBD<KPHFKFGAEPF<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly PLBBGJPDMOA PINLIGDEJBB;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x42EC2B0", Offset = "0x42EAEB0", VA = "0x1842EC2B0")]
	public PKHEEKAEBNO(Quaternion JAEADBEBFDD, Vector3? CNMOHJEEHNB, bool HGMINIJGMNM, KPHFKFGAEPF<TData> ONMFHPEEBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x1FBF150", Offset = "0x1FBDD50", VA = "0x181FBF150", Slot = "4")]
	public override bool BNHDLCIOKEP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7AF400", Offset = "0x7AE800")]
public class PFKCDPKKPIG<TData> : NGJLBBBFBBD<DGBCINDDGOC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7AF470", Offset = "0x7AE870")]
	private readonly FECKOPIDLIL<TData> COIONAJGENL;

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x3A78420", Offset = "0x3A77020", VA = "0x183A78420")]
	public PFKCDPKKPIG(TData[] JKLNEELBHOJ, MFJEBBFONBC[] OPOEPBAFNOG, BIFNIOGHPEJ[] IJIKACDMPFI, float[] GBNPCMDBPJC, DGBCINDDGOC<TData> ONMFHPEEBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x3A77AD0", Offset = "0x3A766D0", VA = "0x183A77AD0", Slot = "4")]
	public override bool BNHDLCIOKEP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7AF4D0", Offset = "0x7AE8D0")]
public class MDCAHGFPHJF<TData> : NGJLBBBFBBD<FLMAKGKBMAB<TData>> where TData : notnull, JMCLLHIJENJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7AF540", Offset = "0x7AE940")]
	private readonly OEIHKBNNHAA<TData> ICBGEJKPEAO;

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x3503390", Offset = "0x3501F90", VA = "0x183503390")]
	public MDCAHGFPHJF(List<TData> JKLNEELBHOJ, List<bool> NCJMKCFJPEH, FLMAKGKBMAB<TData> ONMFHPEEBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x34AA3C0", Offset = "0x34A8FC0", VA = "0x1834AA3C0", Slot = "4")]
	public override bool BNHDLCIOKEP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7AF5A0", Offset = "0x7AE9A0")]
public class MGMDANEKMHO<TData> : NGJLBBBFBBD<CHHPAIKEDAA<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x1D58E10", Offset = "0x1D57A10", VA = "0x181D58E10")]
	public MGMDANEKMHO(CHHPAIKEDAA<TData> ONMFHPEEBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x350DC30", Offset = "0x350C830", VA = "0x18350DC30", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x6FD60A0", Offset = "0x6FD4CA0", VA = "0x186FD60A0")]
	public FJBMIIEPEOP(Vector3 OEICOCPNACP, bool KPKFGDAIIIJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public interface OOCCBMPCEOK<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KDPCJNFNOJO([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7AF610", Offset = "0x7AEA10")] in PFJGDGKEAEA<TData?> COIONAJGENL);

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KLHLKDPOIID();
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7AF680", Offset = "0x7AEA80")]
public class PEOJFHEJGNJ<TData> : NGJLBBBFBBD<OOCCBMPCEOK<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7AF6F0", Offset = "0x7AEAF0")]
	private readonly PFJGDGKEAEA<TData> COIONAJGENL;

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x3A77B90", Offset = "0x3A76790", VA = "0x183A77B90")]
	public PEOJFHEJGNJ(IEnumerable<TData> JKLNEELBHOJ, MFJEBBFONBC OPOEPBAFNOG, BIFNIOGHPEJ IJIKACDMPFI, float GBNPCMDBPJC, OOCCBMPCEOK<TData> ONMFHPEEBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x3A77AD0", Offset = "0x3A766D0", VA = "0x183A77AD0", Slot = "4")]
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
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7AF750", Offset = "0x7AEB50")]
public class EOAEPGCAPAL<TData> : NGJLBBBFBBD<KPMKNCMBLFB<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly DKBOOAPBOFG BEJMPMMMODH;

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x1B0A7C0", Offset = "0x1B093C0", VA = "0x181B0A7C0")]
	public EOAEPGCAPAL(Guid ENGCGOEGJAE, int NHHNPPKPBIA, Vector3 NABPHMOHNDG, Quaternion KDPJNNPKKHC, float EAHPLIAGBOI, bool KPKFGDAIIIJ, KPMKNCMBLFB<TData> ONMFHPEEBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x1B0A750", Offset = "0x1B09350", VA = "0x181B0A750", Slot = "4")]
	public override bool BNHDLCIOKEP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7AF7C0", Offset = "0x7AEBC0")]
public class FPOHMDDGHHA<TData> : NGJLBBBFBBD<FLMAKGKBMAB<TData>> where TData : notnull, JMCLLHIJENJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7AF830", Offset = "0x7AEC30")]
	private readonly NBGMICDKHJH<TData> ICBGEJKPEAO;

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x32C7C80", Offset = "0x32C6880", VA = "0x1832C7C80")]
	public FPOHMDDGHHA(List<TData> JKLNEELBHOJ, bool HIICENNMGHM, FLMAKGKBMAB<TData> ONMFHPEEBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x1FBEF50", Offset = "0x1FBDB50", VA = "0x181FBEF50", Slot = "4")]
	public override bool BNHDLCIOKEP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7AF890", Offset = "0x7AEC90")]
public class IDHLLGEJCDE<TData> : NGJLBBBFBBD<EFKCPJBOKJH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly TData EPCJEHBDOPK;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x1C73B90", Offset = "0x1C72790", VA = "0x181C73B90")]
	public IDHLLGEJCDE(TData EPCJEHBDOPK, EFKCPJBOKJH<TData> ONMFHPEEBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x1C73A20", Offset = "0x1C72620", VA = "0x181C73A20", Slot = "4")]
	public override bool BNHDLCIOKEP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7AF900", Offset = "0x7AED00")]
public abstract class NGJLBBBFBBD<TReceiver> : CKEKECNMLLI<TReceiver, bool> where TReceiver : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x1D58E10", Offset = "0x1D57A10", VA = "0x181D58E10")]
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
	[Cpp2IlInjected.Address(RVA = "0x2F85580", Offset = "0x2F84180", VA = "0x182F85580")]
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
	[Cpp2IlInjected.Address(RVA = "0x4074D40", Offset = "0x4073940", VA = "0x184074D40")]
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
	bool HICKOCLAHCN([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7AF970", Offset = "0x7AED70")] in JLGBLCCKPII<TData?> ANCGLCMDIED);

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KDPCJNFNOJO(in MFHCFHBEBOG MAKEPDAPPEE);

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool KLHLKDPOIID();
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7AF9E0", Offset = "0x7AEDE0")]
public class DLKOCGHGGJI<TData> : NGJLBBBFBBD<OOCCBMPCEOK<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x1D58E10", Offset = "0x1D57A10", VA = "0x181D58E10")]
	public DLKOCGHGGJI(OOCCBMPCEOK<TData> ONMFHPEEBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x2A49080", Offset = "0x2A47C80", VA = "0x182A49080", Slot = "4")]
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
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7AFA50", Offset = "0x7AEE50")]
public abstract class KFKLJFLAKON<TReceiver, TFromTask> : CKEKECNMLLI<TReceiver, Task<TFromTask>>
{
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x1D58E10", Offset = "0x1D57A10", VA = "0x181D58E10")]
	public KFKLJFLAKON(TReceiver ONMFHPEEBAL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7AFAC0", Offset = "0x7AEEC0")]
public class DNNFPBPNMLI<TData> : NGJLBBBFBBD<EMPGBLPIOEP<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7AFB30", Offset = "0x7AEF30")]
	private readonly ILBPFIAMBDG<TData> EOEBGBGLIBA;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x2A4B390", Offset = "0x2A49F90", VA = "0x182A4B390")]
	public DNNFPBPNMLI(IEnumerable<TData> JKLNEELBHOJ, bool POAIHEGPCFG, EMPGBLPIOEP<TData> ONMFHPEEBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x1FBEF50", Offset = "0x1FBDB50", VA = "0x181FBEF50", Slot = "4")]
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
	bool BNHDLCIOKEP([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7AFB90", Offset = "0x7AEF90")] in IOIDNKIHFNN<TData?> COIONAJGENL);
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
