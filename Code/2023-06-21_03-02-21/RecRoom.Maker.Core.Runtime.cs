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
		[Cpp2IlInjected.Address(RVA = "0x841A80", Offset = "0x840C80", VA = "0x180841A80")]
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
		[Cpp2IlInjected.Address(RVA = "0x15864D0", Offset = "0x15856D0", VA = "0x1815864D0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8F3350", Offset = "0x8F2550", VA = "0x1808F3350")]
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
		[Cpp2IlInjected.Address(RVA = "0xE73C20", Offset = "0xE72E20", VA = "0x180E73C20")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x89900", Offset = "0x88D00")]
public class KJBEIDJEIBO<TData> : BHKLNDFKMLB<KLMLHGKPFDH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly HFJBPBBBNDO CIPLOMMEEEJ;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3130610", Offset = "0x312F810", VA = "0x183130610")]
	public KJBEIDJEIBO(Vector3 NLMHPMHPJDK, bool ODFJAAAPEBE, KLMLHGKPFDH<TData> OBPGNCIMCCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2D9B750", Offset = "0x2D9A950", VA = "0x182D9B750", Slot = "4")]
	public override bool AGDCFCDLKJK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct LFMIIKMPJNP<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public IEnumerable<TData> ONNEJIHAPKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public bool AIEMKMOFDMK;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x354D930", Offset = "0x354CB30", VA = "0x18354D930")]
	public LFMIIKMPJNP(IEnumerable<TData> CNJBOBAIHEB, bool AENONCHMFLA = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface FHHNCMCACLN<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool INNJBGAAJMD([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x899B0", Offset = "0x88DB0")] in AHMGJJLJFBE<TData?> JGDMLDGDFKB);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool JHOOFDDGOGO(in LNMJPKECLPP BPOBNLJBOCC);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool JHOOFDDGOGO(in HKDNBDFHDCE BPOBNLJBOCC);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool NPNBNPLHFHE();
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct CMACCBBMFOP<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public TNode AJJJNNKHIAM;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4A48D20", Offset = "0x4A47F20", VA = "0x184A48D20")]
	public CMACCBBMFOP(TNode AJJJNNKHIAM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct JDMJFOCOPNI<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public TNode FBGJHLIECFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public FPILJDAONBF LPFPKONAPPJ;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x34E74D0", Offset = "0x34E66D0", VA = "0x1834E74D0")]
	public JDMJFOCOPNI(TNode FBGJHLIECFI, FPILJDAONBF LPFPKONAPPJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x89A20", Offset = "0x88E20")]
public class MMHBCOFNCGA<TData> : BHKLNDFKMLB<KICFEINHFPG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x89A90", Offset = "0x88E90")]
	private readonly LFMIIKMPJNP<TData> NIBHEJOBNOM;

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x2C7BC20", Offset = "0x2C7AE20", VA = "0x182C7BC20")]
	public MMHBCOFNCGA(List<TData> CAGPAHEIADO, KICFEINHFPG<TData> OBPGNCIMCCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2C7BAD0", Offset = "0x2C7ACD0", VA = "0x182C7BAD0", Slot = "4")]
	public override bool AGDCFCDLKJK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface MLMCOOPELBA<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AGDCFCDLKJK([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x89AF0", Offset = "0x88EF0")] in JLBNFILCIKC<TData?> MLDLCLNOLKF);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct GHOGEPAKBCA<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public IEnumerable<TData> ONNEJIHAPKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public LNOPPDJFMPP CBHLHFBIIPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public FACFKJMCFHH POMHABFAHGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public float AJBGKCGEICG;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x41AD430", Offset = "0x41AC630", VA = "0x1841AD430")]
	public GHOGEPAKBCA(IEnumerable<TData> IMECJELCELL, LNOPPDJFMPP MBOFNGAOJFM, FACFKJMCFHH LGBCNNOGHMI, float AJBGKCGEICG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
internal static class NKFCMNHCFKE
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x1586270", Offset = "0x1585470", VA = "0x181586270")]
	public static void KNLOLMMGJHP(IEnumerable FACAGHKGOMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x2FEC1C0", Offset = "0x2FEB3C0", VA = "0x182FEC1C0")]
	public static void KNLOLMMGJHP<T>(T[] BGBPILICHHA) where T : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct LGMCKKAFAHE<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public TData[] ONNEJIHAPKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public LNOPPDJFMPP[] CBHLHFBIIPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public FACFKJMCFHH[] POMHABFAHGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public float[] AJBGKCGEICG;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x38DC3E0", Offset = "0x38DB5E0", VA = "0x1838DC3E0")]
	public LGMCKKAFAHE(TData[] IMECJELCELL, LNOPPDJFMPP[] MBOFNGAOJFM, FACFKJMCFHH[] LGBCNNOGHMI, float[] AJBGKCGEICG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface FIELMOCFHED
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool BHGIMOBIGEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool CPPPKIFKDGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool CLEJAEIGDEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool OEGCCCLFEJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct ONIGHHGHNLN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly Guid ICJIMEBGKGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly int MMFFFGBLCAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly Vector3 FNDKHLEFPKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly Quaternion AAECNILGNMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly float AANJADLMGPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly bool ODFJAAAPEBE;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x1586560", Offset = "0x1585760", VA = "0x181586560")]
	public ONIGHHGHNLN(Guid ICJIMEBGKGI, int MMFFFGBLCAP, Vector3 FNDKHLEFPKD, Quaternion AAECNILGNMA, float AANJADLMGPL, bool ODFJAAAPEBE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface IPIJEBLPGNI<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool INNJBGAAJMD([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x89B60", Offset = "0x88F60")] in AMNONECDFKG<TData?> JGDMLDGDFKB);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool JHOOFDDGOGO(in KKHGLDFIEDP BPOBNLJBOCC);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool NPNBNPLHFHE();
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct LNMJPKECLPP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public readonly float NEPMEFCPECN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public readonly Vector3 AANFLKANPLD;

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x1586250", Offset = "0x1585450", VA = "0x181586250")]
	public LNMJPKECLPP(float NEPMEFCPECN, Vector3 AANFLKANPLD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct HKDNBDFHDCE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public readonly Vector3 IJOJFBKHNEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly float NEPMEFCPECN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public readonly Vector3 AANFLKANPLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly bool ODFJAAAPEBE;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x1585DC0", Offset = "0x1584FC0", VA = "0x181585DC0")]
	public HKDNBDFHDCE(Vector3 IJOJFBKHNEH, float NEPMEFCPECN, Vector3 AANFLKANPLD, bool ODFJAAAPEBE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x89BD0", Offset = "0x88FD0")]
public class ICIEPOFALEL<TData> : BHKLNDFKMLB<HPHHGIFIGDM<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly ODCFCANHCHB BJAIEELNEGF;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x2D9B7C0", Offset = "0x2D9A9C0", VA = "0x182D9B7C0")]
	public ICIEPOFALEL(Vector3 NGKBKEDJEEF, HPHHGIFIGDM<TData> OBPGNCIMCCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x2D9B750", Offset = "0x2D9A950", VA = "0x182D9B750", Slot = "4")]
	public override bool AGDCFCDLKJK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface JALEBJFPJAH<TData> where TData : GBOAEGAEJLJ
{
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AGDCFCDLKJK([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x89C40", Offset = "0x89040")] in OMOICDBKBFD<TData> LPDGCLHMIOL);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AGDCFCDLKJK([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x89CB0", Offset = "0x890B0")] in AGLCGIDEAIP<TData> LPDGCLHMIOL);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class NCLGMEOEGCB
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public enum OGKDGHNIKBJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		ICreationContextObject,
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		Guid
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x2FE4F00", Offset = "0x2FE4100", VA = "0x182FE4F00")]
	public static void EJPLLHBKFNH<T>(T LGFCIPNNCDA, OGKDGHNIKBJ JAACLLLIGMF) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x2FE5080", Offset = "0x2FE4280", VA = "0x182FE5080")]
	public static void EJPLLHBKFNH<T>(T LGFCIPNNCDA) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x2FE5110", Offset = "0x2FE4310", VA = "0x182FE5110")]
	public static T MEINKDCJHDP<T>(OGKDGHNIKBJ JAACLLLIGMF) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x2FE51D0", Offset = "0x2FE43D0", VA = "0x182FE51D0")]
	public static T MEINKDCJHDP<T>() where T : class
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x89D20", Offset = "0x89120")]
public class LHNFIFAFLDA<TData> : BHKLNDFKMLB<KICFEINHFPG<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x1CBDE20", Offset = "0x1CBD020", VA = "0x181CBDE20")]
	public LHNFIFAFLDA(KICFEINHFPG<TData> OBPGNCIMCCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x38B72C0", Offset = "0x38B64C0", VA = "0x1838B72C0", Slot = "4")]
	public override bool AGDCFCDLKJK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface LDECKHIFMCL<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool Raycast(Vector3 IOOCLPLPHGP, Vector3 DKILHHENEBB, float GMDPDEIGPMK, out T BCDPECFINFB, out Vector3 HIEAGAEOKIF, out Collider MHLCKEBLLCN);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int SpherecastPick(Vector3 IOOCLPLPHGP, Vector3 DKILHHENEBB, float MJMGJKIDGPD, float GMDPDEIGPMK, T[] ILAPCLCNAPG, out Vector3 PDCLANDOGJC, out Collider DPOKENIJOCP);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int SpherePick(Vector3 IOOCLPLPHGP, float MJMGJKIDGPD, Vector3 BJEAAGCBIKG, T[] ILAPCLCNAPG);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public abstract class DGHAIPIHEOB<TReceiver, TFromExecute> where TReceiver : notnull where TFromExecute : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	protected TReceiver OBPGNCIMCCF;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x4372690", Offset = "0x4371890", VA = "0x184372690")]
	public DGHAIPIHEOB(TReceiver OBPGNCIMCCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TFromExecute AGDCFCDLKJK();
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x89D90", Offset = "0x89190")]
public class GBIGDFNPLJC<TData> : BHKLNDFKMLB<EBBCOKNPDFG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x89E00", Offset = "0x89200")]
	private readonly LIOLFKGOCCG<TData> DACLPBKDENL;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x4884830", Offset = "0x4883A30", VA = "0x184884830")]
	public GBIGDFNPLJC(IEnumerable<TData> IMECJELCELL, LNOPPDJFMPP MBOFNGAOJFM, FACFKJMCFHH LGBCNNOGHMI, float AJBGKCGEICG, bool AIEMKMOFDMK, EBBCOKNPDFG<TData> OBPGNCIMCCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2C7BAD0", Offset = "0x2C7ACD0", VA = "0x182C7BAD0", Slot = "4")]
	public override bool AGDCFCDLKJK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x89E60", Offset = "0x89260")]
public class BPPOLKOHDJP<TData> : BHKLNDFKMLB<KLMLHGKPFDH<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x1CBDE20", Offset = "0x1CBD020", VA = "0x181CBDE20")]
	public BPPOLKOHDJP(KLMLHGKPFDH<TData> OBPGNCIMCCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x2F94110", Offset = "0x2F93310", VA = "0x182F94110", Slot = "4")]
	public override bool AGDCFCDLKJK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x89ED0", Offset = "0x892D0")]
public class DJAMNLFEDLD<TData> : BHKLNDFKMLB<JHABPCNFNBJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x89F40", Offset = "0x89340")]
	private readonly DGJFKEFAPKI<TData> BJAIEELNEGF;

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x437DBE0", Offset = "0x437CDE0", VA = "0x18437DBE0")]
	public DJAMNLFEDLD(IEnumerable<TData> IMECJELCELL, Vector3 NGKBKEDJEEF, bool AIEMKMOFDMK, JHABPCNFNBJ<TData> OBPGNCIMCCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2C7BAD0", Offset = "0x2C7ACD0", VA = "0x182C7BAD0", Slot = "4")]
	public override bool AGDCFCDLKJK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public struct DGJFKEFAPKI<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public readonly IEnumerable<TData> IMECJELCELL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly Vector3 NGKBKEDJEEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public readonly bool AIEMKMOFDMK;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x43731F0", Offset = "0x43723F0", VA = "0x1843731F0")]
	public DGJFKEFAPKI(IEnumerable<TData> IMECJELCELL, Vector3 NGKBKEDJEEF, bool AIEMKMOFDMK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface JHABPCNFNBJ<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AGDCFCDLKJK([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x89FA0", Offset = "0x893A0")] in DGJFKEFAPKI<TData?> BJAIEELNEGF);
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x8A010", Offset = "0x89410")]
public class OGFPKNKDLLM<TData> : BHKLNDFKMLB<KICFEINHFPG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly bool AIEMKMOFDMK;

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3E30FC0", Offset = "0x3E301C0", VA = "0x183E30FC0")]
	public OGFPKNKDLLM(bool AIEMKMOFDMK, KICFEINHFPG<TData> OBPGNCIMCCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x3E30F50", Offset = "0x3E30150", VA = "0x183E30F50", Slot = "4")]
	public override bool AGDCFCDLKJK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface DFBLDGEFMEJ<TNode>
{
	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool INNJBGAAJMD([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x8A080", Offset = "0x89480")] in CMACCBBMFOP<TNode?> JGDMLDGDFKB);

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NPNBNPLHFHE([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x8A0F0", Offset = "0x894F0")] in JDMJFOCOPNI<TNode?> HIGCJBNGFNP);

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool NEEEHGMFKPL();
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x8A160", Offset = "0x89560")]
public class PHAMMAGKBLD<TNode> : BHKLNDFKMLB<DFBLDGEFMEJ<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x1CBDE20", Offset = "0x1CBD020", VA = "0x181CBDE20")]
	public PHAMMAGKBLD(DFBLDGEFMEJ<TNode> OBPGNCIMCCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x359DBD0", Offset = "0x359CDD0", VA = "0x18359DBD0", Slot = "4")]
	public override bool AGDCFCDLKJK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface CJDOLMNOCHP<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AGDCFCDLKJK([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x8A1D0", Offset = "0x895D0")] in LGMCKKAFAHE<TData?> DACLPBKDENL);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class JCOAGDNIBFN
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	private struct CCMLJOIKIBG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public bool DEMFCAKJAON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public JLCNCEFHLIA DCCLFJBDDGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public JLCNCEFHLIA FBIDHGHCGCM;
	}

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static CCMLJOIKIBG OOBINJFNOIE;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static CancellationToken GENOJEADKJD
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x1586190", Offset = "0x1585390", VA = "0x181586190")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	internal static JLCNCEFHLIA DCCLFJBDDGI
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x15860B0", Offset = "0x15852B0", VA = "0x1815860B0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x1585F30", Offset = "0x1585130", VA = "0x181585F30")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x1586000", Offset = "0x1585200", VA = "0x181586000")]
	[MPKPGFJAEKF(MCJFPPEDLHH.Room, OJBJGAAILBP.None)]
	private static void GLKCEAHJCJM(JLCNCEFHLIA OJPBFFGPJHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x1585DF0", Offset = "0x1584FF0", VA = "0x181585DF0")]
	public static void BLKLFBLJHAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x1585FB0", Offset = "0x15851B0", VA = "0x181585FB0")]
	private static JLCNCEFHLIA FHGHIABIHEO(JLCNCEFHLIA LCOCKHBLJDI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface AHKNKFDKPAJ<TData> : HCFNHLFLGDK, FEDIPDDILPB<TData>, KICFEINHFPG<TData>, ALLEOBFPLDK<TData>, FIELMOCFHED, LDECKHIFMCL<TData>, HIIGJPNECPC
{
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct JLBNFILCIKC<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public readonly IEnumerable<TData> IMECJELCELL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public readonly Quaternion NGKBKEDJEEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public readonly Vector3? AANFLKANPLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public readonly bool NGJGEPCKCCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public readonly bool AIEMKMOFDMK;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3612070", Offset = "0x3611270", VA = "0x183612070")]
	public JLBNFILCIKC(IEnumerable<TData> IMECJELCELL, Quaternion NGKBKEDJEEF, Vector3? AANFLKANPLD, bool NGJGEPCKCCM, bool AIEMKMOFDMK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public struct LIOLFKGOCCG<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public IEnumerable<TData> ONNEJIHAPKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public LNOPPDJFMPP CBHLHFBIIPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public FACFKJMCFHH POMHABFAHGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public float AJBGKCGEICG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public bool AIEMKMOFDMK;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x38BB970", Offset = "0x38BAB70", VA = "0x1838BB970")]
	public LIOLFKGOCCG(IEnumerable<TData> IMECJELCELL, LNOPPDJFMPP MBOFNGAOJFM, FACFKJMCFHH LGBCNNOGHMI, float AJBGKCGEICG, bool AIEMKMOFDMK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x8A280", Offset = "0x89680")]
public class KLAMLMNAHIP<TData> : BHKLNDFKMLB<FHHNCMCACLN<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly HKDNBDFHDCE EMNBKENHJMD;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x35E3A10", Offset = "0x35E2C10", VA = "0x1835E3A10")]
	public KLAMLMNAHIP(Vector3 IJOJFBKHNEH, float NEPMEFCPECN, Vector3 AANFLKANPLD, bool IFGDCOCADEM, FHHNCMCACLN<TData> OBPGNCIMCCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x35E39A0", Offset = "0x35E2BA0", VA = "0x1835E39A0", Slot = "4")]
	public override bool AGDCFCDLKJK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x8A2F0", Offset = "0x896F0")]
public class APKOJACBEHB<TData> : BHKLNDFKMLB<KICFEINHFPG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x8A360", Offset = "0x89760")]
	private readonly LFMIIKMPJNP<TData> NIBHEJOBNOM;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x393AA20", Offset = "0x3939C20", VA = "0x18393AA20")]
	public APKOJACBEHB(List<TData> CAGPAHEIADO, KICFEINHFPG<TData> OBPGNCIMCCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x393A8D0", Offset = "0x3939AD0", VA = "0x18393A8D0", Slot = "4")]
	public override bool AGDCFCDLKJK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public readonly struct KGEMMPGLJJE<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly IEnumerable<TData> ONNEJIHAPKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly bool GFCBBIKFMAI;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x312CD60", Offset = "0x312BF60", VA = "0x18312CD60")]
	public KGEMMPGLJJE(IEnumerable<TData> IMECJELCELL, bool AIEMKMOFDMK = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x8A400", Offset = "0x89800")]
public class EJAPPAFAAGP<TData> : BHKLNDFKMLB<KICFEINHFPG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x8A470", Offset = "0x89870")]
	private readonly LFMIIKMPJNP<TData> NIBHEJOBNOM;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x448CD50", Offset = "0x448BF50", VA = "0x18448CD50")]
	public EJAPPAFAAGP(List<TData> CAGPAHEIADO, bool AIEMKMOFDMK, KICFEINHFPG<TData> OBPGNCIMCCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x35D7E80", Offset = "0x35D7080", VA = "0x1835D7E80", Slot = "4")]
	public override bool AGDCFCDLKJK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface FEDIPDDILPB<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void RenderHoverHighlight(T BHEOHCEHIBM, [Optional] HJJHEHOPHGJ? INMFCIONCCO, bool JAHIGOJFPMA = true);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RenderHoverHighlight(int IGDJHHPIJBK, IEnumerable<T> FDFEHAHHBAD, bool JAHIGOJFPMA = true);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RenderHoverHighlight(int IGDJHHPIJBK, IEnumerable<T> FDFEHAHHBAD, HJJHEHOPHGJ INMFCIONCCO, bool JAHIGOJFPMA = true);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public struct AHMGJJLJFBE<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly IEnumerable<TData> IMECJELCELL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly bool AIEMKMOFDMK;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x4C77EE0", Offset = "0x4C770E0", VA = "0x184C77EE0")]
	public AHMGJJLJFBE(IEnumerable<TData> IMECJELCELL, bool AIEMKMOFDMK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x8A4D0", Offset = "0x898D0")]
public class AMHGMPKMMPK<TData> : FFLELJGGAHG<MFCPLEOOMBD<TData>, PHNIEPLGADL> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x8A540", Offset = "0x89940")]
	private readonly KGEMMPGLJJE<TData> DAFENKPHLDP;

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x392F940", Offset = "0x392EB40", VA = "0x18392F940")]
	public AMHGMPKMMPK(IEnumerable<TData> IMECJELCELL, bool AIEMKMOFDMK, MFCPLEOOMBD<TData> OBPGNCIMCCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x392F700", Offset = "0x392E900", VA = "0x18392F700", Slot = "4")]
	public override Task<PHNIEPLGADL> AGDCFCDLKJK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x8A5A0", Offset = "0x899A0")]
public class JPFDMPNJHEI<TData> : BHKLNDFKMLB<KLMLHGKPFDH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x8A610", Offset = "0x89A10")]
	private readonly LKMLDFIAFGM<TData> CIPLOMMEEEJ;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3617DD0", Offset = "0x3616FD0", VA = "0x183617DD0")]
	public JPFDMPNJHEI(TData PDDCMNAKECC, bool AIEMKMOFDMK, KLMLHGKPFDH<TData> OBPGNCIMCCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2C7BAD0", Offset = "0x2C7ACD0", VA = "0x182C7BAD0", Slot = "4")]
	public override bool AGDCFCDLKJK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct LKMLDFIAFGM<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public readonly TData PDDCMNAKECC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly bool AIEMKMOFDMK;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x3E91380", Offset = "0x3E90580", VA = "0x183E91380")]
	public LKMLDFIAFGM(TData PDDCMNAKECC, bool AIEMKMOFDMK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public struct CMCMPICIKMD<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly IEnumerable<TData> IMECJELCELL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public readonly bool AIEMKMOFDMK;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x4A48F90", Offset = "0x4A48190", VA = "0x184A48F90")]
	public CMCMPICIKMD(IEnumerable<TData> IMECJELCELL, bool AIEMKMOFDMK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x8A670", Offset = "0x89A70")]
public class JLEKADKFDNP<TData> : BHKLNDFKMLB<FHHNCMCACLN<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly LNMJPKECLPP EMNBKENHJMD;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3612400", Offset = "0x3611600", VA = "0x183612400")]
	public JLEKADKFDNP(float NEPMEFCPECN, Vector3 AANFLKANPLD, FHHNCMCACLN<TData> OBPGNCIMCCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2D9B750", Offset = "0x2D9A950", VA = "0x182D9B750", Slot = "4")]
	public override bool AGDCFCDLKJK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x8A6E0", Offset = "0x89AE0")]
public class FGHAKHIIJJK<TData> : BHKLNDFKMLB<IPIJEBLPGNI<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x1CBDE20", Offset = "0x1CBD020", VA = "0x181CBDE20")]
	public FGHAKHIIJJK(IPIJEBLPGNI<TData> OBPGNCIMCCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x359DBD0", Offset = "0x359CDD0", VA = "0x18359DBD0", Slot = "4")]
	public override bool AGDCFCDLKJK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x8A750", Offset = "0x89B50")]
public class DCGFIDKLIFE<TData> : BHKLNDFKMLB<IPIJEBLPGNI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x8A7C0", Offset = "0x89BC0")]
	private readonly AMNONECDFKG<TData> MLDLCLNOLKF;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x4C59A80", Offset = "0x4C58C80", VA = "0x184C59A80")]
	public DCGFIDKLIFE(IEnumerable<TData> IMECJELCELL, bool AIEMKMOFDMK, IPIJEBLPGNI<TData> OBPGNCIMCCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2C7BAD0", Offset = "0x2C7ACD0", VA = "0x182C7BAD0", Slot = "4")]
	public override bool AGDCFCDLKJK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x8A820", Offset = "0x89C20")]
public class CPEEINDFEMB<TNode> : BHKLNDFKMLB<DFBLDGEFMEJ<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x8A890", Offset = "0x89C90")]
	private readonly CMACCBBMFOP<TNode> JGDMLDGDFKB;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x383EC70", Offset = "0x383DE70", VA = "0x18383EC70")]
	public CPEEINDFEMB(TNode AOCPJFDEPPA, DFBLDGEFMEJ<TNode> OBPGNCIMCCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2C7BAD0", Offset = "0x2C7ACD0", VA = "0x182C7BAD0", Slot = "4")]
	public override bool AGDCFCDLKJK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x8A8F0", Offset = "0x89CF0")]
public class FJKBHIBILIH<TData> : BHKLNDFKMLB<HPHHGIFIGDM<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x8A960", Offset = "0x89D60")]
	private readonly CMCMPICIKMD<TData> BJAIEELNEGF;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x3A9C040", Offset = "0x3A9B240", VA = "0x183A9C040")]
	public FJKBHIBILIH(IEnumerable<TData> IMECJELCELL, bool AIEMKMOFDMK, HPHHGIFIGDM<TData> OBPGNCIMCCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2C7BAD0", Offset = "0x2C7ACD0", VA = "0x182C7BAD0", Slot = "4")]
	public override bool AGDCFCDLKJK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct AMNONECDFKG<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public readonly IEnumerable<TData> IMECJELCELL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public readonly bool AIEMKMOFDMK;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x3930640", Offset = "0x392F840", VA = "0x183930640")]
	public AMNONECDFKG(IEnumerable<TData> IMECJELCELL, bool AIEMKMOFDMK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x8A9C0", Offset = "0x89DC0")]
public class CDBBDLGPNME<TNode> : BHKLNDFKMLB<DFBLDGEFMEJ<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x8AA30", Offset = "0x89E30")]
	private readonly JDMJFOCOPNI<TNode> HIGCJBNGFNP;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x36989B0", Offset = "0x3697BB0", VA = "0x1836989B0")]
	public CDBBDLGPNME(TNode FBGJHLIECFI, FPILJDAONBF LPFPKONAPPJ, DFBLDGEFMEJ<TNode> OBPGNCIMCCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x36988F0", Offset = "0x3697AF0", VA = "0x1836988F0", Slot = "4")]
	public override bool AGDCFCDLKJK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public interface MFCPLEOOMBD<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<PHNIEPLGADL> BJHOELDHFCP([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x8AA90", Offset = "0x89E90")] in KGEMMPGLJJE<TData> NIBHEJOBNOM, CancellationToken PLEKJLHDOLP);
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface KICFEINHFPG<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KAFBKIMDLDC([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x8AB00", Offset = "0x89F00")] in LFMIIKMPJNP<TData> NIBHEJOBNOM);

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LGIKGCEAPFL([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x8AB70", Offset = "0x89F70")] in LFMIIKMPJNP<TData> NIBHEJOBNOM);

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AIPPCKFODIC(in bool FJBOKPIDELO);

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool HMKAOCOBIOJ([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x8ABE0", Offset = "0x89FE0")] in LFMIIKMPJNP<TData> NIBHEJOBNOM);

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JDEJPCKDPLE();

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool MCEDEPCEPGI(in TData AFHKFFMJOJD);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public struct KKHGLDFIEDP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public readonly Quaternion NGKBKEDJEEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly Vector3? AANFLKANPLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly bool NGJGEPCKCCM;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x1586230", Offset = "0x1585430", VA = "0x181586230")]
	public KKHGLDFIEDP(Quaternion NGKBKEDJEEF, Vector3? AANFLKANPLD, bool NGJGEPCKCCM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface KLMLHGKPFDH<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool INNJBGAAJMD([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x8AC50", Offset = "0x8A050")] in LKMLDFIAFGM<TData?> JGDMLDGDFKB);

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool JHOOFDDGOGO(in HFJBPBBBNDO BPOBNLJBOCC);

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool JHOOFDDGOGO(in ONIGHHGHNLN BPOBNLJBOCC);

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool NPNBNPLHFHE();
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public struct ODCFCANHCHB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly Vector3 NGKBKEDJEEF;

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x14B4A80", Offset = "0x14B3C80", VA = "0x1814B4A80")]
	public ODCFCANHCHB(Vector3 NGKBKEDJEEF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x8ACC0", Offset = "0x8A0C0")]
public class POCEKDIDEMH<TData> : BHKLNDFKMLB<MLMCOOPELBA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x8AD30", Offset = "0x8A130")]
	private readonly JLBNFILCIKC<TData> MLDLCLNOLKF;

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x31D7250", Offset = "0x31D6450", VA = "0x1831D7250")]
	public POCEKDIDEMH(IEnumerable<TData> IMECJELCELL, Quaternion NGKBKEDJEEF, Vector3? AANFLKANPLD, bool NGJGEPCKCCM, bool AIEMKMOFDMK, MLMCOOPELBA<TData> OBPGNCIMCCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x2C7BAD0", Offset = "0x2C7ACD0", VA = "0x182C7BAD0", Slot = "4")]
	public override bool AGDCFCDLKJK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x8AD90", Offset = "0x8A190")]
public class FOLHMMMIAJL<TData> : BHKLNDFKMLB<FHHNCMCACLN<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x1CBDE20", Offset = "0x1CBD020", VA = "0x181CBDE20")]
	public FOLHMMMIAJL(FHHNCMCACLN<TData> OBPGNCIMCCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x2F94110", Offset = "0x2F93310", VA = "0x182F94110", Slot = "4")]
	public override bool AGDCFCDLKJK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x8AE00", Offset = "0x8A200")]
public class BKMCKPPJFPP<TData> : BHKLNDFKMLB<IPIJEBLPGNI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly KKHGLDFIEDP MLDLCLNOLKF;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x476F910", Offset = "0x476EB10", VA = "0x18476F910")]
	public BKMCKPPJFPP(Quaternion NGKBKEDJEEF, Vector3? AANFLKANPLD, bool NGJGEPCKCCM, IPIJEBLPGNI<TData> OBPGNCIMCCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x2D9B750", Offset = "0x2D9A950", VA = "0x182D9B750", Slot = "4")]
	public override bool AGDCFCDLKJK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x8AE70", Offset = "0x8A270")]
public class BDALCAKLCOC<TData> : BHKLNDFKMLB<CJDOLMNOCHP<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x8AEE0", Offset = "0x8A2E0")]
	private readonly LGMCKKAFAHE<TData> DACLPBKDENL;

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x44431A0", Offset = "0x44423A0", VA = "0x1844431A0")]
	public BDALCAKLCOC(TData[] IMECJELCELL, LNOPPDJFMPP[] MBOFNGAOJFM, FACFKJMCFHH[] LGBCNNOGHMI, float[] AJBGKCGEICG, CJDOLMNOCHP<TData> OBPGNCIMCCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x275BBF0", Offset = "0x275ADF0", VA = "0x18275BBF0", Slot = "4")]
	public override bool AGDCFCDLKJK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x8AF40", Offset = "0x8A340")]
public class PDCHCNBFGNM<TData> : BHKLNDFKMLB<JALEBJFPJAH<TData>> where TData : notnull, GBOAEGAEJLJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x8AFB0", Offset = "0x8A3B0")]
	private readonly AGLCGIDEAIP<TData> LPDGCLHMIOL;

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x35D7F40", Offset = "0x35D7140", VA = "0x1835D7F40")]
	public PDCHCNBFGNM(List<TData> IMECJELCELL, List<bool> CGELDBLMONF, JALEBJFPJAH<TData> OBPGNCIMCCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x35D7E80", Offset = "0x35D7080", VA = "0x1835D7E80", Slot = "4")]
	public override bool AGDCFCDLKJK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x8B010", Offset = "0x8A410")]
public class DIGCAGAHBNP<TData> : BHKLNDFKMLB<HPHHGIFIGDM<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x1CBDE20", Offset = "0x1CBD020", VA = "0x181CBDE20")]
	public DIGCAGAHBNP(HPHHGIFIGDM<TData> OBPGNCIMCCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x359DBD0", Offset = "0x359CDD0", VA = "0x18359DBD0", Slot = "4")]
	public override bool AGDCFCDLKJK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public struct HFJBPBBBNDO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public readonly Vector3 NLMHPMHPJDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly bool ODFJAAAPEBE;

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x1585DA0", Offset = "0x1584FA0", VA = "0x181585DA0")]
	public HFJBPBBBNDO(Vector3 NLMHPMHPJDK, bool ODFJAAAPEBE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public interface KLCEBBOPPFP<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JHOOFDDGOGO([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x8B080", Offset = "0x8A480")] in GHOGEPAKBCA<TData?> DACLPBKDENL);

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NPNBNPLHFHE();
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x8B0F0", Offset = "0x8A4F0")]
public class ILMCKKAHBPJ<TData> : BHKLNDFKMLB<KLCEBBOPPFP<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x8B160", Offset = "0x8A560")]
	private readonly GHOGEPAKBCA<TData> DACLPBKDENL;

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x275BCB0", Offset = "0x275AEB0", VA = "0x18275BCB0")]
	public ILMCKKAHBPJ(IEnumerable<TData> IMECJELCELL, LNOPPDJFMPP MBOFNGAOJFM, FACFKJMCFHH LGBCNNOGHMI, float AJBGKCGEICG, KLCEBBOPPFP<TData> OBPGNCIMCCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x275BBF0", Offset = "0x275ADF0", VA = "0x18275BBF0", Slot = "4")]
	public override bool AGDCFCDLKJK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public interface GBOAEGAEJLJ
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool LMHDKHOPKPO
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
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x8B1C0", Offset = "0x8A5C0")]
public class HIOOPHGHHDH<TData> : BHKLNDFKMLB<KLMLHGKPFDH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly ONIGHHGHNLN CIPLOMMEEEJ;

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x46767F0", Offset = "0x46759F0", VA = "0x1846767F0")]
	public HIOOPHGHHDH(Guid ICJIMEBGKGI, int MMFFFGBLCAP, Vector3 FNDKHLEFPKD, Quaternion AAECNILGNMA, float AANJADLMGPL, bool ODFJAAAPEBE, KLMLHGKPFDH<TData> OBPGNCIMCCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x35E39A0", Offset = "0x35E2BA0", VA = "0x1835E39A0", Slot = "4")]
	public override bool AGDCFCDLKJK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x8B230", Offset = "0x8A630")]
public class MFDPJKLGLCO<TData> : BHKLNDFKMLB<JALEBJFPJAH<TData>> where TData : notnull, GBOAEGAEJLJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x8B2A0", Offset = "0x8A6A0")]
	private readonly OMOICDBKBFD<TData> LPDGCLHMIOL;

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x304A870", Offset = "0x3049A70", VA = "0x18304A870")]
	public MFDPJKLGLCO(List<TData> IMECJELCELL, bool BBINHMGKOMJ, JALEBJFPJAH<TData> OBPGNCIMCCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x2C7BAD0", Offset = "0x2C7ACD0", VA = "0x182C7BAD0", Slot = "4")]
	public override bool AGDCFCDLKJK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x8B300", Offset = "0x8A700")]
public class PPLMDKCBFAO<TData> : BHKLNDFKMLB<KICFEINHFPG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly TData AFHKFFMJOJD;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x31D8220", Offset = "0x31D7420", VA = "0x1831D8220")]
	public PPLMDKCBFAO(TData AFHKFFMJOJD, KICFEINHFPG<TData> OBPGNCIMCCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x31D8160", Offset = "0x31D7360", VA = "0x1831D8160", Slot = "4")]
	public override bool AGDCFCDLKJK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x8B370", Offset = "0x8A770")]
public abstract class BHKLNDFKMLB<TReceiver> : DGHAIPIHEOB<TReceiver, bool> where TReceiver : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x1CBDE20", Offset = "0x1CBD020", VA = "0x181CBDE20")]
	public BHKLNDFKMLB(TReceiver OBPGNCIMCCF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public interface HCFNHLFLGDK
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	Bounds EHKIGFJADFI
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	Transform AMIKLDPKODE
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	Bounds JOAFCIDCOHN
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	Transform MBGJPOJOHAF
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	Vector3 OFLHGENDGBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void SetSelectionBoundsDirty(bool BBCCDJBOMDH = true, int JGBPMPOMDPC = 0);
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public struct OMOICDBKBFD<TData> where TData : notnull, GBOAEGAEJLJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public IEnumerable<TData> ONNEJIHAPKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public bool BBINHMGKOMJ;

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x3244D20", Offset = "0x3243F20", VA = "0x183244D20")]
	public OMOICDBKBFD(IEnumerable<TData> CNJBOBAIHEB, bool LIHFCIJGKNL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public struct AGLCGIDEAIP<TData> where TData : notnull, GBOAEGAEJLJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public List<TData> ONNEJIHAPKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public List<bool> CGELDBLMONF;

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x4C73C80", Offset = "0x4C72E80", VA = "0x184C73C80")]
	public AGLCGIDEAIP(List<TData> CNJBOBAIHEB, List<bool> ICFBMGGAILF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public interface ALLEOBFPLDK<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool NHFOFLLGPJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	int BMPHLDKBNII
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	IEnumerable<TData> KNEAFOLPCCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IsSelected(TData FNPJDMFCFGH);

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IsSelectable(TData FNPJDMFCFGH);
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public interface HIIGJPNECPC
{
	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnSelectionPickedUp();

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnSelectionReleased();
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public interface HPHHGIFIGDM<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool INNJBGAAJMD([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x8B3E0", Offset = "0x8A7E0")] in CMCMPICIKMD<TData?> PJDLAMPAKLC);

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool JHOOFDDGOGO(in ODCFCANHCHB BPOBNLJBOCC);

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool NPNBNPLHFHE();
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x8B450", Offset = "0x8A850")]
public class FCEBMMCOEMF<TData> : BHKLNDFKMLB<KLCEBBOPPFP<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x1CBDE20", Offset = "0x1CBD020", VA = "0x181CBDE20")]
	public FCEBMMCOEMF(KLCEBBOPPFP<TData> OBPGNCIMCCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x557D5F0", Offset = "0x557C7F0", VA = "0x18557D5F0", Slot = "4")]
	public override bool AGDCFCDLKJK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public interface PGNGFFLECDG : GBOAEGAEJLJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x8B4C0", Offset = "0x8A8C0")]
public abstract class FFLELJGGAHG<TReceiver, TFromTask> : DGHAIPIHEOB<TReceiver, Task<TFromTask>>
{
	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x1CBDE20", Offset = "0x1CBD020", VA = "0x181CBDE20")]
	public FFLELJGGAHG(TReceiver OBPGNCIMCCF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x8B530", Offset = "0x8A930")]
public class JBGBOHMNOPJ<TData> : BHKLNDFKMLB<FHHNCMCACLN<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x8B5A0", Offset = "0x8A9A0")]
	private readonly AHMGJJLJFBE<TData> EMNBKENHJMD;

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x34DD630", Offset = "0x34DC830", VA = "0x1834DD630")]
	public JBGBOHMNOPJ(IEnumerable<TData> IMECJELCELL, bool AIEMKMOFDMK, FHHNCMCACLN<TData> OBPGNCIMCCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x2C7BAD0", Offset = "0x2C7ACD0", VA = "0x182C7BAD0", Slot = "4")]
	public override bool AGDCFCDLKJK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public interface EBBCOKNPDFG<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AGDCFCDLKJK([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x8B600", Offset = "0x8AA00")] in LIOLFKGOCCG<TData?> DACLPBKDENL);
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
