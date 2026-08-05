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
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80DE80", VA = "0x18080EA80")]
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
		[Cpp2IlInjected.Address(RVA = "0x16E9630", Offset = "0x16E8A30", VA = "0x1816E9630")]
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
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
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
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x87190", Offset = "0x86590")]
public class JDDOMLEFNNO<TData> : global::AEOALIHHJJH<global::DMNFJEBACKH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly ENOGIDPEOMN IJIBLPJPKFO;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3399390", Offset = "0x3398790", VA = "0x183399390")]
	public JDDOMLEFNNO(Vector3 GHKBKLCABIF, bool CONNLMNEIDN, global::DMNFJEBACKH<TData> GLFELGAFCBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2E9F930", Offset = "0x2E9ED30", VA = "0x182E9F930", Slot = "4")]
	public override bool NIJHMMDNNAP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct ECEMIKJBGAK<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public IEnumerable<TData> ELIGECFIICF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public bool FCHNNAGNMLC;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3487030", Offset = "0x3486430", VA = "0x183487030")]
	public ECEMIKJBGAK(IEnumerable<TData> FOIKCNCPLDO, bool CBLHGAKFGBC = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface GFDJJGLHFJG<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CFPKLHHDKAN([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x87200", Offset = "0x86600")] in global::FCOMABIMDDF<TData?> AEOOKNMMCDP);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool BPNFFGMMNAH(in MGLDMBAFEAG GLBDIKMMOPO);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool BPNFFGMMNAH(in FHLNJGPPCMP GLBDIKMMOPO);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool EGCMJKBDKCJ();
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct EILEBGGMKAB<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public TNode NGCOPABMHJP;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x37543F0", Offset = "0x37537F0", VA = "0x1837543F0")]
	public EILEBGGMKAB(TNode NGCOPABMHJP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct JJNLPMONCLK<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public TNode JKLPDHGOGFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public NGAEPHFLALO BHFGFKNJNIP;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3088820", Offset = "0x3087C20", VA = "0x183088820")]
	public JJNLPMONCLK(TNode JKLPDHGOGFP, NGAEPHFLALO BHFGFKNJNIP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x85540", Offset = "0x84940")]
public class NNEABFEICJF<TData> : global::AEOALIHHJJH<global::OAIFKAIEFIL<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x855B0", Offset = "0x849B0")]
	private readonly global::ECEMIKJBGAK<TData> HADPNLLPKOH;

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3C1D010", Offset = "0x3C1C410", VA = "0x183C1D010")]
	public NNEABFEICJF(List<TData> OGHMIAGGFBJ, global::OAIFKAIEFIL<TData> GLFELGAFCBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2CC1D70", Offset = "0x2CC1170", VA = "0x182CC1D70", Slot = "4")]
	public override bool NIJHMMDNNAP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface AFBACNMMNIN<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NIJHMMDNNAP([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x85610", Offset = "0x84A10")] in global::DCMJGNFCPEK<TData?> MPCDJJCAOKC);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct OHKLKDLBMAL<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public IEnumerable<TData> ELIGECFIICF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public LBLKEMKOINO KGMDFLMACAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public MONDBANNBDC OHBMOMDKLCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public float KOKEDNDOEHE;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x35524D0", Offset = "0x35518D0", VA = "0x1835524D0")]
	public OHKLKDLBMAL(IEnumerable<TData> HIDLNGIDPHM, LBLKEMKOINO OGGMNJPGMJE, MONDBANNBDC MCCMDDPOEBN, float KOKEDNDOEHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
internal static class MINGFLBBELJ
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x16E93C0", Offset = "0x16E87C0", VA = "0x1816E93C0")]
	public static void DDLEOGIPGKO(IEnumerable MBLOMLHOIEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x27C40C0", Offset = "0x27C34C0", VA = "0x1827C40C0")]
	public static void DDLEOGIPGKO<T>(T[] BIBDBFOMNHM) where T : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct AADMJLDBMPF<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public TData[] ELIGECFIICF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public LBLKEMKOINO[] KGMDFLMACAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public MONDBANNBDC[] OHBMOMDKLCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public float[] KOKEDNDOEHE;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x58B5B90", Offset = "0x58B4F90", VA = "0x1858B5B90")]
	public AADMJLDBMPF(TData[] HIDLNGIDPHM, LBLKEMKOINO[] OGGMNJPGMJE, MONDBANNBDC[] MCCMDDPOEBN, float[] KOKEDNDOEHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface LLPAHPPLNLL
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool JNBGPCADHFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool COFEFFODEGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool JNGKCPOPGGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool DNAKBCDBPNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct BPJBDJFGBPI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly Guid HLFKOIMNEJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly int CJOLACIBAJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly Vector3 FLBOBIODIJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly Quaternion FKJONOBDEOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly float AKNCHEAFHPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly bool CONNLMNEIDN;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x16E92F0", Offset = "0x16E86F0", VA = "0x1816E92F0")]
	public BPJBDJFGBPI(Guid HLFKOIMNEJN, int CJOLACIBAJH, Vector3 FLBOBIODIJO, Quaternion FKJONOBDEOA, float AKNCHEAFHPI, bool CONNLMNEIDN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface LHHNALEOOBN<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CFPKLHHDKAN([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x85680", Offset = "0x84A80")] in global::APDNONFBECI<TData?> AEOOKNMMCDP);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool BPNFFGMMNAH(in HNKNKLCPLPP GLBDIKMMOPO);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool EGCMJKBDKCJ();
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct MGLDMBAFEAG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public readonly float LDKNCAHIPED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public readonly Vector3 EOAADEKBLCF;

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x16E93A0", Offset = "0x16E87A0", VA = "0x1816E93A0")]
	public MGLDMBAFEAG(float LDKNCAHIPED, Vector3 EOAADEKBLCF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct FHLNJGPPCMP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public readonly Vector3 KOHDEFNFOII;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly float LDKNCAHIPED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public readonly Vector3 EOAADEKBLCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly bool CONNLMNEIDN;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x16E9350", Offset = "0x16E8750", VA = "0x1816E9350")]
	public FHLNJGPPCMP(Vector3 KOHDEFNFOII, float LDKNCAHIPED, Vector3 EOAADEKBLCF, bool CONNLMNEIDN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x856F0", Offset = "0x84AF0")]
public class EAOHFANBACL<TData> : global::AEOALIHHJJH<global::EMACHGFKHKG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly MGBCIJGALGE GCCLIALJGHH;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x2E9F9A0", Offset = "0x2E9EDA0", VA = "0x182E9F9A0")]
	public EAOHFANBACL(Vector3 IMLKMDAIOLE, global::EMACHGFKHKG<TData> GLFELGAFCBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x2E9F930", Offset = "0x2E9ED30", VA = "0x182E9F930", Slot = "4")]
	public override bool NIJHMMDNNAP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface EIDOHLJFKCI<TData> where TData : ALCANNKHBHK
{
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NIJHMMDNNAP([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x85760", Offset = "0x84B60")] in global::GBGPCAKPCID<TData> COFDJNFCKOJ);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NIJHMMDNNAP([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x857D0", Offset = "0x84BD0")] in global::FIOGBHIAKMJ<TData> COFDJNFCKOJ);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class LNOCIAOFFOB
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public enum HNNDKCMNOBK
	{
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		ICreationContextObject,
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		Guid
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x30007B0", Offset = "0x2FFFBB0", VA = "0x1830007B0")]
	public static void FLBEFMALKAJ<T>(T NNJMKDFAIHH, HNNDKCMNOBK ONBHBHIHHNE) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3000720", Offset = "0x2FFFB20", VA = "0x183000720")]
	public static void FLBEFMALKAJ<T>(T NNJMKDFAIHH) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3000930", Offset = "0x2FFFD30", VA = "0x183000930")]
	public static T LLPKLFBKNII<T>(HNNDKCMNOBK ONBHBHIHHNE) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x30009F0", Offset = "0x2FFFDF0", VA = "0x1830009F0")]
	public static T LLPKLFBKNII<T>() where T : class
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x85840", Offset = "0x84C40")]
public class GCGEBPMJMAB<TData> : global::AEOALIHHJJH<global::OAIFKAIEFIL<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x25DDD60", Offset = "0x25DD160", VA = "0x1825DDD60")]
	public GCGEBPMJMAB(global::OAIFKAIEFIL<TData> GLFELGAFCBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x40CF110", Offset = "0x40CE510", VA = "0x1840CF110", Slot = "4")]
	public override bool NIJHMMDNNAP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface LIIHEDNBPNJ<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool Raycast(Vector3 DNACOLDEFIO, Vector3 EPJPJGLJENE, float NCEKMHDDCCP, out T ICJEPJCBLFM, out Vector3 JCKEJHIENIA, out Collider CCENNBMLGKH);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int SpherecastPick(Vector3 DNACOLDEFIO, Vector3 EPJPJGLJENE, float MMBFALBOFDB, float NCEKMHDDCCP, T[] PIBGJILBCLC, out Vector3 FMHNAPGPJLK, out Collider CNMGKLALDJN);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int SpherePick(Vector3 DNACOLDEFIO, float MMBFALBOFDB, Vector3 NFKHPAMFGIC, T[] PIBGJILBCLC);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public abstract class DIJLJAIJCBB<TReceiver, TFromExecute> where TReceiver : notnull where TFromExecute : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	protected TReceiver GLFELGAFCBK;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x360F410", Offset = "0x360E810", VA = "0x18360F410")]
	public DIJLJAIJCBB(TReceiver GLFELGAFCBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TFromExecute NIJHMMDNNAP();
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x858B0", Offset = "0x84CB0")]
public class LOLFBKJPDHD<TData> : global::AEOALIHHJJH<global::DIKIAPCODHN<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x85920", Offset = "0x84D20")]
	private readonly global::ABBEHHEDLLK<TData> CFBNJIPKMBL;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x38BD980", Offset = "0x38BCD80", VA = "0x1838BD980")]
	public LOLFBKJPDHD(IEnumerable<TData> HIDLNGIDPHM, LBLKEMKOINO OGGMNJPGMJE, MONDBANNBDC MCCMDDPOEBN, float KOKEDNDOEHE, bool FCHNNAGNMLC, global::DIKIAPCODHN<TData> GLFELGAFCBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2CC1D70", Offset = "0x2CC1170", VA = "0x182CC1D70", Slot = "4")]
	public override bool NIJHMMDNNAP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x85980", Offset = "0x84D80")]
public class CMFIMGAKNFG<TData> : global::AEOALIHHJJH<global::DMNFJEBACKH<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x25DDD60", Offset = "0x25DD160", VA = "0x1825DDD60")]
	public CMFIMGAKNFG(global::DMNFJEBACKH<TData> GLFELGAFCBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x3C99740", Offset = "0x3C98B40", VA = "0x183C99740", Slot = "4")]
	public override bool NIJHMMDNNAP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x859F0", Offset = "0x84DF0")]
public class OPIBCJAPJIJ<TData> : global::AEOALIHHJJH<global::KBBFPOAKOOH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x85A60", Offset = "0x84E60")]
	private readonly global::JJHNKGLPNEM<TData> GCCLIALJGHH;

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x42939A0", Offset = "0x4292DA0", VA = "0x1842939A0")]
	public OPIBCJAPJIJ(IEnumerable<TData> HIDLNGIDPHM, Vector3 IMLKMDAIOLE, bool FCHNNAGNMLC, global::KBBFPOAKOOH<TData> GLFELGAFCBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2CC1D70", Offset = "0x2CC1170", VA = "0x182CC1D70", Slot = "4")]
	public override bool NIJHMMDNNAP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public struct JJHNKGLPNEM<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public readonly IEnumerable<TData> HIDLNGIDPHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly Vector3 IMLKMDAIOLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public readonly bool FCHNNAGNMLC;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x3086AE0", Offset = "0x3085EE0", VA = "0x183086AE0")]
	public JJHNKGLPNEM(IEnumerable<TData> HIDLNGIDPHM, Vector3 IMLKMDAIOLE, bool FCHNNAGNMLC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface KBBFPOAKOOH<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NIJHMMDNNAP([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x85AC0", Offset = "0x84EC0")] in global::JJHNKGLPNEM<TData?> GCCLIALJGHH);
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x85B30", Offset = "0x84F30")]
public class DGGHNIJILKA<TData> : global::AEOALIHHJJH<global::OAIFKAIEFIL<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly bool FCHNNAGNMLC;

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x36075F0", Offset = "0x36069F0", VA = "0x1836075F0")]
	public DGGHNIJILKA(bool FCHNNAGNMLC, global::OAIFKAIEFIL<TData> GLFELGAFCBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x3607580", Offset = "0x3606980", VA = "0x183607580", Slot = "4")]
	public override bool NIJHMMDNNAP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface PJFAKCJPEKC<TNode>
{
	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CFPKLHHDKAN([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x85BA0", Offset = "0x84FA0")] in global::EILEBGGMKAB<TNode?> AEOOKNMMCDP);

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool EGCMJKBDKCJ([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x85C10", Offset = "0x85010")] in global::JJNLPMONCLK<TNode?> APFOJDCGKEA);

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool GLCLJIFPIKG();
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x85C80", Offset = "0x85080")]
public class BEHAOCOKAJN<TNode> : global::AEOALIHHJJH<global::PJFAKCJPEKC<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x25DDD60", Offset = "0x25DD160", VA = "0x1825DDD60")]
	public BEHAOCOKAJN(global::PJFAKCJPEKC<TNode> GLFELGAFCBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x308D710", Offset = "0x308CB10", VA = "0x18308D710", Slot = "4")]
	public override bool NIJHMMDNNAP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface DFPPDCGLNOC<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NIJHMMDNNAP([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x85CF0", Offset = "0x850F0")] in global::AADMJLDBMPF<TData?> CFBNJIPKMBL);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class OJEOOKDNGNO
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	private struct ILGHKNJPCLI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public bool HOHIBELPHJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public HECDEIOAEPJ BNDGIPEHCBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public HECDEIOAEPJ PJJAACPOPNN;
	}

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static ILGHKNJPCLI NNDAOPAOIMB;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static CancellationToken KFGCPOHJKBB
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x16E9710", Offset = "0x16E8B10", VA = "0x1816E9710")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	internal static HECDEIOAEPJ BNDGIPEHCBP
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x16E9820", Offset = "0x16E8C20", VA = "0x1816E9820")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x16E9A40", Offset = "0x16E8E40", VA = "0x1816E9A40")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x16E9770", Offset = "0x16E8B70", VA = "0x1816E9770")]
	[HECCOHDEPAK(OEAABDENEKP.Room, JCKMLGOOEHJ.None)]
	private static void IDALJJNICHJ(HECDEIOAEPJ IBEIPCDNOGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x16E9900", Offset = "0x16E8D00", VA = "0x1816E9900")]
	public static void LLMEAOAJOJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x16E96C0", Offset = "0x16E8AC0", VA = "0x1816E96C0")]
	private static HECDEIOAEPJ APFHHINCIBL(HECDEIOAEPJ GGEGMNEAHKE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface MKAIFPFPPKJ<TData> : DPGKLHJDCCF, global::JIBAGBPEPHB<TData>, global::OAIFKAIEFIL<TData>, global::DIGIMGKHIBB<TData>, LLPAHPPLNLL, global::LIIHEDNBPNJ<TData>, GJFPLPKCEJM
{
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct DCMJGNFCPEK<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public readonly IEnumerable<TData> HIDLNGIDPHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public readonly Quaternion IMLKMDAIOLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public readonly Vector3? EOAADEKBLCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public readonly bool PGBKDJAEBDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public readonly bool FCHNNAGNMLC;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x35FF300", Offset = "0x35FE700", VA = "0x1835FF300")]
	public DCMJGNFCPEK(IEnumerable<TData> HIDLNGIDPHM, Quaternion IMLKMDAIOLE, Vector3? EOAADEKBLCF, bool PGBKDJAEBDO, bool FCHNNAGNMLC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public struct ABBEHHEDLLK<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public IEnumerable<TData> ELIGECFIICF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public LBLKEMKOINO KGMDFLMACAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public MONDBANNBDC OHBMOMDKLCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public float KOKEDNDOEHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public bool FCHNNAGNMLC;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x4A21230", Offset = "0x4A20630", VA = "0x184A21230")]
	public ABBEHHEDLLK(IEnumerable<TData> HIDLNGIDPHM, LBLKEMKOINO OGGMNJPGMJE, MONDBANNBDC MCCMDDPOEBN, float KOKEDNDOEHE, bool FCHNNAGNMLC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x85DA0", Offset = "0x851A0")]
public class JLIILJGEJBM<TData> : global::AEOALIHHJJH<global::GFDJJGLHFJG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly FHLNJGPPCMP AECIINGDPDL;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x308E770", Offset = "0x308DB70", VA = "0x18308E770")]
	public JLIILJGEJBM(Vector3 KOHDEFNFOII, float LDKNCAHIPED, Vector3 EOAADEKBLCF, bool GALABHALEJK, global::GFDJJGLHFJG<TData> GLFELGAFCBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x2C5B8E0", Offset = "0x2C5ACE0", VA = "0x182C5B8E0", Slot = "4")]
	public override bool NIJHMMDNNAP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x85E10", Offset = "0x85210")]
public class LEKBJJBCJGH<TData> : global::AEOALIHHJJH<global::OAIFKAIEFIL<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x85E80", Offset = "0x85280")]
	private readonly global::ECEMIKJBGAK<TData> HADPNLLPKOH;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x32AAC70", Offset = "0x32AA070", VA = "0x1832AAC70")]
	public LEKBJJBCJGH(List<TData> OGHMIAGGFBJ, global::OAIFKAIEFIL<TData> GLFELGAFCBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x32AABA0", Offset = "0x32A9FA0", VA = "0x1832AABA0", Slot = "4")]
	public override bool NIJHMMDNNAP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public readonly struct JLJIJNBJFNE<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly IEnumerable<TData> ELIGECFIICF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly bool CPEGIBGBGJH;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x308EAF0", Offset = "0x308DEF0", VA = "0x18308EAF0")]
	public JLJIJNBJFNE(IEnumerable<TData> HIDLNGIDPHM, bool FCHNNAGNMLC = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x85F20", Offset = "0x85320")]
public class JDJCHONEEMI<TData> : global::AEOALIHHJJH<global::OAIFKAIEFIL<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x85F90", Offset = "0x85390")]
	private readonly global::ECEMIKJBGAK<TData> HADPNLLPKOH;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x3399590", Offset = "0x3398990", VA = "0x183399590")]
	public JDJCHONEEMI(List<TData> OGHMIAGGFBJ, bool FCHNNAGNMLC, global::OAIFKAIEFIL<TData> GLFELGAFCBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x3399420", Offset = "0x3398820", VA = "0x183399420", Slot = "4")]
	public override bool NIJHMMDNNAP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface JIBAGBPEPHB<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void RenderHoverHighlight(T GHHNOPFOGCC, [Optional] IFPAFNCCJJC? BFKNABEILKA, bool EHFHHENFMHP = true);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RenderHoverHighlight(int HHFCIFFLNGA, IEnumerable<T> NFFIKMCFHBI, bool EHFHHENFMHP = true);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RenderHoverHighlight(int HHFCIFFLNGA, IEnumerable<T> NFFIKMCFHBI, IFPAFNCCJJC BFKNABEILKA, bool EHFHHENFMHP = true);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public struct FCOMABIMDDF<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly IEnumerable<TData> HIDLNGIDPHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly bool FCHNNAGNMLC;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x341B710", Offset = "0x341AB10", VA = "0x18341B710")]
	public FCOMABIMDDF(IEnumerable<TData> HIDLNGIDPHM, bool FCHNNAGNMLC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x85FF0", Offset = "0x853F0")]
public class MBMCPIKMMKN<TData> : global::FFNGAHHPJID<global::NAJNHLFOENJ<TData>, IHPJKLOOCFC> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x86060", Offset = "0x85460")]
	private readonly global::JLJIJNBJFNE<TData> OPIFPJDJMPD;

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2F92790", Offset = "0x2F91B90", VA = "0x182F92790")]
	public MBMCPIKMMKN(IEnumerable<TData> HIDLNGIDPHM, bool FCHNNAGNMLC, global::NAJNHLFOENJ<TData> GLFELGAFCBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x2F92550", Offset = "0x2F91950", VA = "0x182F92550", Slot = "4")]
	public override Task<IHPJKLOOCFC> NIJHMMDNNAP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x860C0", Offset = "0x854C0")]
public class CMFLMKCAFAB<TData> : global::AEOALIHHJJH<global::DMNFJEBACKH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x86130", Offset = "0x85530")]
	private readonly global::PHIOCJCPDAG<TData> IJIBLPJPKFO;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3C997A0", Offset = "0x3C98BA0", VA = "0x183C997A0")]
	public CMFLMKCAFAB(TData ICMDHGDOHEC, bool FCHNNAGNMLC, global::DMNFJEBACKH<TData> GLFELGAFCBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2CC1D70", Offset = "0x2CC1170", VA = "0x182CC1D70", Slot = "4")]
	public override bool NIJHMMDNNAP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct PHIOCJCPDAG<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public readonly TData ICMDHGDOHEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly bool FCHNNAGNMLC;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x3D51A10", Offset = "0x3D50E10", VA = "0x183D51A10")]
	public PHIOCJCPDAG(TData ICMDHGDOHEC, bool FCHNNAGNMLC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public struct FFMCLGEMHAM<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly IEnumerable<TData> HIDLNGIDPHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public readonly bool FCHNNAGNMLC;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x2C5BA80", Offset = "0x2C5AE80", VA = "0x182C5BA80")]
	public FFMCLGEMHAM(IEnumerable<TData> HIDLNGIDPHM, bool FCHNNAGNMLC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x86190", Offset = "0x85590")]
public class COGBFHOHCOI<TData> : global::AEOALIHHJJH<global::GFDJJGLHFJG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly MGLDMBAFEAG AECIINGDPDL;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3C9F1B0", Offset = "0x3C9E5B0", VA = "0x183C9F1B0")]
	public COGBFHOHCOI(float LDKNCAHIPED, Vector3 EOAADEKBLCF, global::GFDJJGLHFJG<TData> GLFELGAFCBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2E9F930", Offset = "0x2E9ED30", VA = "0x182E9F930", Slot = "4")]
	public override bool NIJHMMDNNAP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x86200", Offset = "0x85600")]
public class JKEMBNBLIKB<TData> : global::AEOALIHHJJH<global::LHHNALEOOBN<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x25DDD60", Offset = "0x25DD160", VA = "0x1825DDD60")]
	public JKEMBNBLIKB(global::LHHNALEOOBN<TData> GLFELGAFCBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x308D710", Offset = "0x308CB10", VA = "0x18308D710", Slot = "4")]
	public override bool NIJHMMDNNAP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x86270", Offset = "0x85670")]
public class EFNKMONEKGO<TData> : global::AEOALIHHJJH<global::LHHNALEOOBN<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x862E0", Offset = "0x856E0")]
	private readonly global::APDNONFBECI<TData> MPCDJJCAOKC;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x34B0F90", Offset = "0x34B0390", VA = "0x1834B0F90")]
	public EFNKMONEKGO(IEnumerable<TData> HIDLNGIDPHM, bool FCHNNAGNMLC, global::LHHNALEOOBN<TData> GLFELGAFCBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2CC1D70", Offset = "0x2CC1170", VA = "0x182CC1D70", Slot = "4")]
	public override bool NIJHMMDNNAP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x86340", Offset = "0x85740")]
public class HOPGDCNJHNB<TNode> : global::AEOALIHHJJH<global::PJFAKCJPEKC<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x863B0", Offset = "0x857B0")]
	private readonly global::EILEBGGMKAB<TNode> AEOOKNMMCDP;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x3239310", Offset = "0x3238710", VA = "0x183239310")]
	public HOPGDCNJHNB(TNode BOFLDGPAMPE, global::PJFAKCJPEKC<TNode> GLFELGAFCBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2CC1D70", Offset = "0x2CC1170", VA = "0x182CC1D70", Slot = "4")]
	public override bool NIJHMMDNNAP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x86410", Offset = "0x85810")]
public class JMKJJINKNKL<TData> : global::AEOALIHHJJH<global::EMACHGFKHKG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x86480", Offset = "0x85880")]
	private readonly global::FFMCLGEMHAM<TData> GCCLIALJGHH;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x3096810", Offset = "0x3095C10", VA = "0x183096810")]
	public JMKJJINKNKL(IEnumerable<TData> HIDLNGIDPHM, bool FCHNNAGNMLC, global::EMACHGFKHKG<TData> GLFELGAFCBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2CC1D70", Offset = "0x2CC1170", VA = "0x182CC1D70", Slot = "4")]
	public override bool NIJHMMDNNAP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct APDNONFBECI<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public readonly IEnumerable<TData> HIDLNGIDPHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public readonly bool FCHNNAGNMLC;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x39B7C90", Offset = "0x39B7090", VA = "0x1839B7C90")]
	public APDNONFBECI(IEnumerable<TData> HIDLNGIDPHM, bool FCHNNAGNMLC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x864E0", Offset = "0x858E0")]
public class CODPFDDOPKO<TNode> : global::AEOALIHHJJH<global::PJFAKCJPEKC<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x86550", Offset = "0x85950")]
	private readonly global::JJNLPMONCLK<TNode> APFOJDCGKEA;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x3C9F110", Offset = "0x3C9E510", VA = "0x183C9F110")]
	public CODPFDDOPKO(TNode JKLPDHGOGFP, NGAEPHFLALO BHFGFKNJNIP, global::PJFAKCJPEKC<TNode> GLFELGAFCBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x3C9F040", Offset = "0x3C9E440", VA = "0x183C9F040", Slot = "4")]
	public override bool NIJHMMDNNAP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public interface NAJNHLFOENJ<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IHPJKLOOCFC> FNMFHFOPPFB([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x865B0", Offset = "0x859B0")] in global::JLJIJNBJFNE<TData> HADPNLLPKOH, CancellationToken EMJFDFLJKFG);
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface OAIFKAIEFIL<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LOGKLCKGHHD([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x86620", Offset = "0x85A20")] in global::ECEMIKJBGAK<TData> HADPNLLPKOH);

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BAPJPBALGAJ([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x86690", Offset = "0x85A90")] in global::ECEMIKJBGAK<TData> HADPNLLPKOH);

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CEJPGLJGCLC(in bool CCENGALGHKD);

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool ONOKFDBBPMA([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x86700", Offset = "0x85B00")] in global::ECEMIKJBGAK<TData> HADPNLLPKOH);

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GEAPMAOHDFD();

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool OJMCGJIKEMB(in TData JPBHFFCHFLK);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public struct HNKNKLCPLPP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public readonly Quaternion IMLKMDAIOLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly Vector3? EOAADEKBLCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly bool PGBKDJAEBDO;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x16E9380", Offset = "0x16E8780", VA = "0x1816E9380")]
	public HNKNKLCPLPP(Quaternion IMLKMDAIOLE, Vector3? EOAADEKBLCF, bool PGBKDJAEBDO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface DMNFJEBACKH<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CFPKLHHDKAN([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x86770", Offset = "0x85B70")] in global::PHIOCJCPDAG<TData?> AEOOKNMMCDP);

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool BPNFFGMMNAH(in ENOGIDPEOMN GLBDIKMMOPO);

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool BPNFFGMMNAH(in BPJBDJFGBPI GLBDIKMMOPO);

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool EGCMJKBDKCJ();
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public struct MGBCIJGALGE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly Vector3 IMLKMDAIOLE;

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x15F90E0", Offset = "0x15F84E0", VA = "0x1815F90E0")]
	public MGBCIJGALGE(Vector3 IMLKMDAIOLE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x867E0", Offset = "0x85BE0")]
public class AKDJHEIJIIN<TData> : global::AEOALIHHJJH<global::AFBACNMMNIN<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x86850", Offset = "0x85C50")]
	private readonly global::DCMJGNFCPEK<TData> MPCDJJCAOKC;

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x3410CA0", Offset = "0x34100A0", VA = "0x183410CA0")]
	public AKDJHEIJIIN(IEnumerable<TData> HIDLNGIDPHM, Quaternion IMLKMDAIOLE, Vector3? EOAADEKBLCF, bool PGBKDJAEBDO, bool FCHNNAGNMLC, global::AFBACNMMNIN<TData> GLFELGAFCBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x2CC1D70", Offset = "0x2CC1170", VA = "0x182CC1D70", Slot = "4")]
	public override bool NIJHMMDNNAP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x868B0", Offset = "0x85CB0")]
public class CJOMAHNGKGL<TData> : global::AEOALIHHJJH<global::GFDJJGLHFJG<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x25DDD60", Offset = "0x25DD160", VA = "0x1825DDD60")]
	public CJOMAHNGKGL(global::GFDJJGLHFJG<TData> GLFELGAFCBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x3C99740", Offset = "0x3C98B40", VA = "0x183C99740", Slot = "4")]
	public override bool NIJHMMDNNAP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x86920", Offset = "0x85D20")]
public class IMJPPFBBOJH<TData> : global::AEOALIHHJJH<global::LHHNALEOOBN<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly HNKNKLCPLPP MPCDJJCAOKC;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x3314A30", Offset = "0x3313E30", VA = "0x183314A30")]
	public IMJPPFBBOJH(Quaternion IMLKMDAIOLE, Vector3? EOAADEKBLCF, bool PGBKDJAEBDO, global::LHHNALEOOBN<TData> GLFELGAFCBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x2E9F930", Offset = "0x2E9ED30", VA = "0x182E9F930", Slot = "4")]
	public override bool NIJHMMDNNAP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x86990", Offset = "0x85D90")]
public class MMKBDDEFBAH<TData> : global::AEOALIHHJJH<global::DFPPDCGLNOC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x86A00", Offset = "0x85E00")]
	private readonly global::AADMJLDBMPF<TData> CFBNJIPKMBL;

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x44EB260", Offset = "0x44EA660", VA = "0x1844EB260")]
	public MMKBDDEFBAH(TData[] HIDLNGIDPHM, LBLKEMKOINO[] OGGMNJPGMJE, MONDBANNBDC[] MCCMDDPOEBN, float[] KOKEDNDOEHE, global::DFPPDCGLNOC<TData> GLFELGAFCBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x3BB2FD0", Offset = "0x3BB23D0", VA = "0x183BB2FD0", Slot = "4")]
	public override bool NIJHMMDNNAP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x86A60", Offset = "0x85E60")]
public class NILNDANJFGF<TData> : global::AEOALIHHJJH<global::EIDOHLJFKCI<TData>> where TData : notnull, ALCANNKHBHK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x86AD0", Offset = "0x85ED0")]
	private readonly global::FIOGBHIAKMJ<TData> COFDJNFCKOJ;

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x3BB2F30", Offset = "0x3BB2330", VA = "0x183BB2F30")]
	public NILNDANJFGF(List<TData> HIDLNGIDPHM, List<bool> KNOBMMIHIEL, global::EIDOHLJFKCI<TData> GLFELGAFCBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x3399420", Offset = "0x3398820", VA = "0x183399420", Slot = "4")]
	public override bool NIJHMMDNNAP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x86B30", Offset = "0x85F30")]
public class LIKHLGAHFKC<TData> : global::AEOALIHHJJH<global::EMACHGFKHKG<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x25DDD60", Offset = "0x25DD160", VA = "0x1825DDD60")]
	public LIKHLGAHFKC(global::EMACHGFKHKG<TData> GLFELGAFCBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x308D710", Offset = "0x308CB10", VA = "0x18308D710", Slot = "4")]
	public override bool NIJHMMDNNAP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public struct ENOGIDPEOMN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public readonly Vector3 GHKBKLCABIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly bool CONNLMNEIDN;

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x16E9330", Offset = "0x16E8730", VA = "0x1816E9330")]
	public ENOGIDPEOMN(Vector3 GHKBKLCABIF, bool CONNLMNEIDN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public interface ALGANDLMADH<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BPNFFGMMNAH([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x86BA0", Offset = "0x85FA0")] in global::OHKLKDLBMAL<TData?> CFBNJIPKMBL);

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EGCMJKBDKCJ();
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x86C10", Offset = "0x86010")]
public class NIMEMJIOKCG<TData> : global::AEOALIHHJJH<global::ALGANDLMADH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x86C80", Offset = "0x86080")]
	private readonly global::OHKLKDLBMAL<TData> CFBNJIPKMBL;

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x3BB3090", Offset = "0x3BB2490", VA = "0x183BB3090")]
	public NIMEMJIOKCG(IEnumerable<TData> HIDLNGIDPHM, LBLKEMKOINO OGGMNJPGMJE, MONDBANNBDC MCCMDDPOEBN, float KOKEDNDOEHE, global::ALGANDLMADH<TData> GLFELGAFCBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x3BB2FD0", Offset = "0x3BB23D0", VA = "0x183BB2FD0", Slot = "4")]
	public override bool NIJHMMDNNAP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public interface ALCANNKHBHK
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool DFHHGLPOJPF
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
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x86CE0", Offset = "0x860E0")]
public class FFLDMLDPAOI<TData> : global::AEOALIHHJJH<global::DMNFJEBACKH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly BPJBDJFGBPI IJIBLPJPKFO;

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x2C5B950", Offset = "0x2C5AD50", VA = "0x182C5B950")]
	public FFLDMLDPAOI(Guid HLFKOIMNEJN, int CJOLACIBAJH, Vector3 FLBOBIODIJO, Quaternion FKJONOBDEOA, float AKNCHEAFHPI, bool CONNLMNEIDN, global::DMNFJEBACKH<TData> GLFELGAFCBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x2C5B8E0", Offset = "0x2C5ACE0", VA = "0x182C5B8E0", Slot = "4")]
	public override bool NIJHMMDNNAP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x86D50", Offset = "0x86150")]
public class PPHECDACGMK<TData> : global::AEOALIHHJJH<global::EIDOHLJFKCI<TData>> where TData : notnull, ALCANNKHBHK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x86DC0", Offset = "0x861C0")]
	private readonly global::GBGPCAKPCID<TData> COFDJNFCKOJ;

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x2CC1E30", Offset = "0x2CC1230", VA = "0x182CC1E30")]
	public PPHECDACGMK(List<TData> HIDLNGIDPHM, bool AGCAGFECJII, global::EIDOHLJFKCI<TData> GLFELGAFCBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x2CC1D70", Offset = "0x2CC1170", VA = "0x182CC1D70", Slot = "4")]
	public override bool NIJHMMDNNAP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x86E20", Offset = "0x86220")]
public class PHLFBDKDACL<TData> : global::AEOALIHHJJH<global::OAIFKAIEFIL<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly TData JPBHFFCHFLK;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x3D51C70", Offset = "0x3D51070", VA = "0x183D51C70")]
	public PHLFBDKDACL(TData JPBHFFCHFLK, global::OAIFKAIEFIL<TData> GLFELGAFCBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x3D51B00", Offset = "0x3D50F00", VA = "0x183D51B00", Slot = "4")]
	public override bool NIJHMMDNNAP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x86E90", Offset = "0x86290")]
public abstract class AEOALIHHJJH<TReceiver> : global::DIJLJAIJCBB<TReceiver, bool> where TReceiver : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x25DDD60", Offset = "0x25DD160", VA = "0x1825DDD60")]
	public AEOALIHHJJH(TReceiver GLFELGAFCBK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public interface DPGKLHJDCCF
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	Bounds BIJGLCHNFFL
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	Transform OKBKIELOCPM
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	Bounds CLOGBNLHKNI
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	Transform KLNEPNNLPDC
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	Vector3 CDADMMGAKLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public struct GBGPCAKPCID<TData> where TData : notnull, ALCANNKHBHK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public IEnumerable<TData> ELIGECFIICF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public bool AGCAGFECJII;

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x40BDEE0", Offset = "0x40BD2E0", VA = "0x1840BDEE0")]
	public GBGPCAKPCID(IEnumerable<TData> FOIKCNCPLDO, bool HFANHCAOFLG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public struct FIOGBHIAKMJ<TData> where TData : notnull, ALCANNKHBHK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public List<TData> ELIGECFIICF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public List<bool> KNOBMMIHIEL;

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x2C6A820", Offset = "0x2C69C20", VA = "0x182C6A820")]
	public FIOGBHIAKMJ(List<TData> FOIKCNCPLDO, List<bool> OLDGKAHMKLK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public interface DIGIMGKHIBB<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool MOLIDJLEMDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	int DJDGJIAJEKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	IEnumerable<TData> AGLOGDNFNHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IsSelected(TData NFFDNBMMLPN);

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IsSelectable(TData NFFDNBMMLPN);
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public interface GJFPLPKCEJM
{
	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnSelectionPickedUp();

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnSelectionReleased();
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public interface EMACHGFKHKG<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CFPKLHHDKAN([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x86F00", Offset = "0x86300")] in global::FFMCLGEMHAM<TData?> JBCFFCAGDBO);

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool BPNFFGMMNAH(in MGBCIJGALGE GLBDIKMMOPO);

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool EGCMJKBDKCJ();
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x86F70", Offset = "0x86370")]
public class OLLHECFJBKN<TData> : global::AEOALIHHJJH<global::ALGANDLMADH<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x25DDD60", Offset = "0x25DD160", VA = "0x1825DDD60")]
	public OLLHECFJBKN(global::ALGANDLMADH<TData> GLFELGAFCBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x355E4D0", Offset = "0x355D8D0", VA = "0x18355E4D0", Slot = "4")]
	public override bool NIJHMMDNNAP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public interface NOGKHMDCIAG : ALCANNKHBHK
{
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x86FE0", Offset = "0x863E0")]
public abstract class FFNGAHHPJID<TReceiver, TFromTask> : global::DIJLJAIJCBB<TReceiver, Task<TFromTask>>
{
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x25DDD60", Offset = "0x25DD160", VA = "0x1825DDD60")]
	public FFNGAHHPJID(TReceiver GLFELGAFCBK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x87050", Offset = "0x86450")]
public class DCMAGBLCANH<TData> : global::AEOALIHHJJH<global::GFDJJGLHFJG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x870C0", Offset = "0x864C0")]
	private readonly global::FCOMABIMDDF<TData> AECIINGDPDL;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x35FF260", Offset = "0x35FE660", VA = "0x1835FF260")]
	public DCMAGBLCANH(IEnumerable<TData> HIDLNGIDPHM, bool FCHNNAGNMLC, global::GFDJJGLHFJG<TData> GLFELGAFCBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x2CC1D70", Offset = "0x2CC1170", VA = "0x182CC1D70", Slot = "4")]
	public override bool NIJHMMDNNAP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public interface DIKIAPCODHN<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NIJHMMDNNAP([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x87120", Offset = "0x86520")] in global::ABBEHHEDLLK<TData?> CFBNJIPKMBL);
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
