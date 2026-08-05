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
		[Cpp2IlInjected.Address(RVA = "0x8389E0", Offset = "0x8377E0", VA = "0x1808389E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x191DB90", Offset = "0x191C990", VA = "0x18191DB90")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x917630", Offset = "0x916430", VA = "0x180917630")]
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
		[Cpp2IlInjected.Address(RVA = "0xF6F160", Offset = "0xF6DF60", VA = "0x180F6F160")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x89000", Offset = "0x88400")]
public class NMAICAEEJNP<TData> : HJJMADMCJCH<ECPACIFPKDM<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly OCLOJNGGEPJ PIDALGLIKKF;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x47044B0", Offset = "0x47032B0", VA = "0x1847044B0")]
	public NMAICAEEJNP(Vector3 LKOAGODCEKF, bool ALJDMHKJFFL, ECPACIFPKDM<TData> FINCEHLLNFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3C38EB0", Offset = "0x3C37CB0", VA = "0x183C38EB0", Slot = "4")]
	public override bool FLEJJGKPECP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct HCOLLNBAFEK<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public IEnumerable<TData> IICDDEDLHCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public bool LJDPKMIBIJN;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3B40D30", Offset = "0x3B3FB30", VA = "0x183B40D30")]
	public HCOLLNBAFEK(IEnumerable<TData> IOFKICFKKFF, bool NPMCFDGHKOK = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface MHGGNCHPCPB<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OJCKDIDHMEI([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x89070", Offset = "0x88470")] in LFAPCBNEDNO<TData?> IEHKLCMFJJN);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NGFCHLDFGNK(in BACPFNBFOAJ CBJMFANOAIH);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool NGFCHLDFGNK(in CKIGLOFMPDB CBJMFANOAIH);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool HDEFLCPFKEN();
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct OHPPNLKMIFI<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public TNode KEBEMOEJEIC;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3182C70", Offset = "0x3181A70", VA = "0x183182C70")]
	public OHPPNLKMIFI(TNode KEBEMOEJEIC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct GADONFEHFBM<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public TNode CDNLINDHOGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public DMOCEGEPKPE BLJPCLIFEJC;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3939580", Offset = "0x3938380", VA = "0x183939580")]
	public GADONFEHFBM(TNode CDNLINDHOGF, DMOCEGEPKPE BLJPCLIFEJC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x873B0", Offset = "0x867B0")]
public class MGPKIDEACKA<TData> : HJJMADMCJCH<NEBHMCKIPOK<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x87420", Offset = "0x86820")]
	private readonly HCOLLNBAFEK<TData> IBEJACLCCJA;

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x38865C0", Offset = "0x38853C0", VA = "0x1838865C0")]
	public MGPKIDEACKA(List<TData> KLBCGPELFKC, NEBHMCKIPOK<TData> FINCEHLLNFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2A26A50", Offset = "0x2A25850", VA = "0x182A26A50", Slot = "4")]
	public override bool FLEJJGKPECP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface DKOCGEGOGLE<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FLEJJGKPECP([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x87480", Offset = "0x86880")] in KLJGAGIIHOE<TData?> NEKMCOKGJHN);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct IJGENEMMIKA<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public IEnumerable<TData> IICDDEDLHCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public DMKFAHLEAKG PMLMMLIFOEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public FPMADANDHIO JECIEOCHDJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public float EOJLEDMJOMD;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x2A2C340", Offset = "0x2A2B140", VA = "0x182A2C340")]
	public IJGENEMMIKA(IEnumerable<TData> DIAEHDKFEME, DMKFAHLEAKG OPEMNAAFCJM, FPMADANDHIO DMHFIODFBBK, float EOJLEDMJOMD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
internal static class BMHBPNHMIHM
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x191D490", Offset = "0x191C290", VA = "0x18191D490")]
	public static void FLOJCMCEJIM(IEnumerable CKBMKIFNOID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x45139E0", Offset = "0x45127E0", VA = "0x1845139E0")]
	public static void FLOJCMCEJIM<T>(T[] PKPHLPFOPGM) where T : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct MPOEHFKMNNA<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public TData[] IICDDEDLHCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public DMKFAHLEAKG[] PMLMMLIFOEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public FPMADANDHIO[] JECIEOCHDJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public float[] EOJLEDMJOMD;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x36232C0", Offset = "0x36220C0", VA = "0x1836232C0")]
	public MPOEHFKMNNA(TData[] DIAEHDKFEME, DMKFAHLEAKG[] OPEMNAAFCJM, FPMADANDHIO[] DMHFIODFBBK, float[] EOJLEDMJOMD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface GFLLNDCJPKE
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool KDGEBCIJJHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool EHGBGKBBKFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool LJJOAAHCDMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool OBJMCKOBJCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct AMNPBAMNNKG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly Guid DNNPDIIFDCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly int FHOMILACEHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly Vector3 IHHJAKDKGPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly Quaternion EMNOFGLPALH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly float JDDHCIGHCNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly bool ALJDMHKJFFL;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x191D430", Offset = "0x191C230", VA = "0x18191D430")]
	public AMNPBAMNNKG(Guid DNNPDIIFDCK, int FHOMILACEHB, Vector3 IHHJAKDKGPC, Quaternion EMNOFGLPALH, float JDDHCIGHCNC, bool ALJDMHKJFFL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface NHAHFLLGFJI<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OJCKDIDHMEI([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x874F0", Offset = "0x868F0")] in OFNDCDAOBND<TData?> IEHKLCMFJJN);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NGFCHLDFGNK(in MHBGFCEEGDO CBJMFANOAIH);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool HDEFLCPFKEN();
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct BACPFNBFOAJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public readonly float EDJIMOOOPCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public readonly Vector3 NLIAHLAMDDF;

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x191D470", Offset = "0x191C270", VA = "0x18191D470")]
	public BACPFNBFOAJ(float EDJIMOOOPCO, Vector3 NLIAHLAMDDF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct CKIGLOFMPDB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public readonly Vector3 HINCDANPNOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly float EDJIMOOOPCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public readonly Vector3 NLIAHLAMDDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly bool ALJDMHKJFFL;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x191D700", Offset = "0x191C500", VA = "0x18191D700")]
	public CKIGLOFMPDB(Vector3 HINCDANPNOE, float EDJIMOOOPCO, Vector3 NLIAHLAMDDF, bool ALJDMHKJFFL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x87560", Offset = "0x86960")]
public class BKEDGBLLHLL<TData> : HJJMADMCJCH<LFHAIBJBCKH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly POBHBPLDOBF HGCNGHHJEAL;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3CC9A60", Offset = "0x3CC8860", VA = "0x183CC9A60")]
	public BKEDGBLLHLL(Vector3 HMPKKKJELLB, LFHAIBJBCKH<TData> FINCEHLLNFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3C38EB0", Offset = "0x3C37CB0", VA = "0x183C38EB0", Slot = "4")]
	public override bool FLEJJGKPECP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface MBDBOLNGHIN<TData> where TData : MGMEOMAHPKI
{
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FLEJJGKPECP([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x875D0", Offset = "0x869D0")] in LOEKGGOHGLE<TData> JLEINNKMBAO);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FLEJJGKPECP([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x87640", Offset = "0x86A40")] in KGFNIKIHPEE<TData> JLEINNKMBAO);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class CHLANOALEEC
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public enum IMLEPGBGAPE
	{
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		ICreationContextObject,
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		Guid
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x2CCE720", Offset = "0x2CCD520", VA = "0x182CCE720")]
	public static void BEAIHOKGLLI<T>(T EJBAOAKFGMC, IMLEPGBGAPE LKLFHGBOOLP) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x2CCE8A0", Offset = "0x2CCD6A0", VA = "0x182CCE8A0")]
	public static void BEAIHOKGLLI<T>(T EJBAOAKFGMC) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x2CCE930", Offset = "0x2CCD730", VA = "0x182CCE930")]
	public static T KOLGIMOOKDG<T>(IMLEPGBGAPE LKLFHGBOOLP) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x2CCE9F0", Offset = "0x2CCD7F0", VA = "0x182CCE9F0")]
	public static T KOLGIMOOKDG<T>() where T : class
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x876B0", Offset = "0x86AB0")]
public class IFPBMKLLBMB<TData> : HJJMADMCJCH<NEBHMCKIPOK<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x27CBFC0", Offset = "0x27CADC0", VA = "0x1827CBFC0")]
	public IFPBMKLLBMB(NEBHMCKIPOK<TData> FINCEHLLNFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x2A26D20", Offset = "0x2A25B20", VA = "0x182A26D20", Slot = "4")]
	public override bool FLEJJGKPECP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface DOGDOBAOFJK<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool Raycast(Vector3 FEEJKCLONBL, Vector3 DMABJFINPCN, float HLNABDEKNDG, out T OGDEECKCBKH, out Vector3 MLGHEKFEHEC, out Collider MEGCMHCOMNK);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int SpherecastPick(Vector3 FEEJKCLONBL, Vector3 DMABJFINPCN, float EALOMMOBHKH, float HLNABDEKNDG, T[] IJGAENGFLFK, out Vector3 LLAKONBPIMM, out Collider NLEJCMACGDI);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int SpherePick(Vector3 FEEJKCLONBL, float EALOMMOBHKH, Vector3 NNNCKJOEACA, T[] IJGAENGFLFK);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public abstract class ONPKOELNGFE<TReceiver, TFromExecute> where TReceiver : notnull where TFromExecute : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	protected TReceiver FINCEHLLNFN;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5967270", Offset = "0x5966070", VA = "0x185967270")]
	public ONPKOELNGFE(TReceiver FINCEHLLNFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TFromExecute FLEJJGKPECP();
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x87720", Offset = "0x86B20")]
public class ADGELDGKJNB<TData> : HJJMADMCJCH<OPNDHJGAPMB<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x87790", Offset = "0x86B90")]
	private readonly APAFBENLMDP<TData> AHIPBNNJPHL;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3C2CF40", Offset = "0x3C2BD40", VA = "0x183C2CF40")]
	public ADGELDGKJNB(IEnumerable<TData> DIAEHDKFEME, DMKFAHLEAKG OPEMNAAFCJM, FPMADANDHIO DMHFIODFBBK, float EOJLEDMJOMD, bool LJDPKMIBIJN, OPNDHJGAPMB<TData> FINCEHLLNFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2A26A50", Offset = "0x2A25850", VA = "0x182A26A50", Slot = "4")]
	public override bool FLEJJGKPECP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x877F0", Offset = "0x86BF0")]
public class OJHHNPFCICH<TData> : HJJMADMCJCH<ECPACIFPKDM<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x27CBFC0", Offset = "0x27CADC0", VA = "0x1827CBFC0")]
	public OJHHNPFCICH(ECPACIFPKDM<TData> FINCEHLLNFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x3167FA0", Offset = "0x3166DA0", VA = "0x183167FA0", Slot = "4")]
	public override bool FLEJJGKPECP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x87860", Offset = "0x86C60")]
public class CIPJCIDJPEO<TData> : HJJMADMCJCH<KPHPHCBCHLN<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x878D0", Offset = "0x86CD0")]
	private readonly AJDLFBKPLKP<TData> HGCNGHHJEAL;

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x3B27460", Offset = "0x3B26260", VA = "0x183B27460")]
	public CIPJCIDJPEO(IEnumerable<TData> DIAEHDKFEME, Vector3 HMPKKKJELLB, bool LJDPKMIBIJN, KPHPHCBCHLN<TData> FINCEHLLNFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2A26A50", Offset = "0x2A25850", VA = "0x182A26A50", Slot = "4")]
	public override bool FLEJJGKPECP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public struct AJDLFBKPLKP<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public readonly IEnumerable<TData> DIAEHDKFEME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly Vector3 HMPKKKJELLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public readonly bool LJDPKMIBIJN;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x3C39A70", Offset = "0x3C38870", VA = "0x183C39A70")]
	public AJDLFBKPLKP(IEnumerable<TData> DIAEHDKFEME, Vector3 HMPKKKJELLB, bool LJDPKMIBIJN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface KPHPHCBCHLN<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FLEJJGKPECP([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x87930", Offset = "0x86D30")] in AJDLFBKPLKP<TData?> HGCNGHHJEAL);
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x879A0", Offset = "0x86DA0")]
public class ACNAKIFHMFI<TData> : HJJMADMCJCH<NEBHMCKIPOK<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly bool LJDPKMIBIJN;

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x457BCC0", Offset = "0x457AAC0", VA = "0x18457BCC0")]
	public ACNAKIFHMFI(bool LJDPKMIBIJN, NEBHMCKIPOK<TData> FINCEHLLNFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x457BC50", Offset = "0x457AA50", VA = "0x18457BC50", Slot = "4")]
	public override bool FLEJJGKPECP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface GEDPFIIFCHD<TNode>
{
	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OJCKDIDHMEI([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x87A10", Offset = "0x86E10")] in OHPPNLKMIFI<TNode?> IEHKLCMFJJN);

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HDEFLCPFKEN([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x87A80", Offset = "0x86E80")] in GADONFEHFBM<TNode?> GJNEAIBKGJO);

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool EGBAJJPJHBL();
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x87AF0", Offset = "0x86EF0")]
public class POGNIHJPBAM<TNode> : HJJMADMCJCH<GEDPFIIFCHD<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x27CBFC0", Offset = "0x27CADC0", VA = "0x1827CBFC0")]
	public POGNIHJPBAM(GEDPFIIFCHD<TNode> FINCEHLLNFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x44A5D30", Offset = "0x44A4B30", VA = "0x1844A5D30", Slot = "4")]
	public override bool FLEJJGKPECP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface EBALJGMJNBN<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FLEJJGKPECP([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x87B60", Offset = "0x86F60")] in MPOEHFKMNNA<TData?> AHIPBNNJPHL);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class GHIEPOAFNHI
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	private struct HAPJHEOBIPD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public bool HBIMJKJJFKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public OBEPLHILJNL IEDGOIEEOHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public OBEPLHILJNL GGOHNAAHIIH;
	}

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static HAPJHEOBIPD DCDMHCKLAMP;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static CancellationToken MOOJKCDDJOM
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x191D830", Offset = "0x191C630", VA = "0x18191D830")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	internal static OBEPLHILJNL IEDGOIEEOHN
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x191DA50", Offset = "0x191C850", VA = "0x18191DA50")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x191D890", Offset = "0x191C690", VA = "0x18191D890")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x191D730", Offset = "0x191C530", VA = "0x18191D730")]
	[GIEEOCCBBIJ(EMJNPDDLMAF.Room, PFHGMCKNAFN.None)]
	private static void AAMINKNBJMI(OBEPLHILJNL GHEEGEGINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x191D910", Offset = "0x191C710", VA = "0x18191D910")]
	public static void HKOMOLJGOCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x191D7E0", Offset = "0x191C5E0", VA = "0x18191D7E0")]
	private static OBEPLHILJNL BCPJCINMMOF(OBEPLHILJNL FMAOLKGCDLE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface FOPBKPCMAKD<TData> : PKHNIFGLHDP, KGEBNCAMOJN<TData>, NEBHMCKIPOK<TData>, PICFEFDDGAH<TData>, GFLLNDCJPKE, DOGDOBAOFJK<TData>, BANIHKJPLHA
{
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct KLJGAGIIHOE<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public readonly IEnumerable<TData> DIAEHDKFEME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public readonly Quaternion HMPKKKJELLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public readonly Vector3? NLIAHLAMDDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public readonly bool NJKHBCFFGNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public readonly bool LJDPKMIBIJN;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x44ADC00", Offset = "0x44ACA00", VA = "0x1844ADC00")]
	public KLJGAGIIHOE(IEnumerable<TData> DIAEHDKFEME, Quaternion HMPKKKJELLB, Vector3? NLIAHLAMDDF, bool NJKHBCFFGNK, bool LJDPKMIBIJN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public struct APAFBENLMDP<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public IEnumerable<TData> IICDDEDLHCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public DMKFAHLEAKG PMLMMLIFOEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public FPMADANDHIO JECIEOCHDJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public float EOJLEDMJOMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public bool LJDPKMIBIJN;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x474A310", Offset = "0x4749110", VA = "0x18474A310")]
	public APAFBENLMDP(IEnumerable<TData> DIAEHDKFEME, DMKFAHLEAKG OPEMNAAFCJM, FPMADANDHIO DMHFIODFBBK, float EOJLEDMJOMD, bool LJDPKMIBIJN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x87C10", Offset = "0x87010")]
public class ANGJABLNBAF<TData> : HJJMADMCJCH<MHGGNCHPCPB<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly CKIGLOFMPDB KCABFNJHOAI;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3CB8B70", Offset = "0x3CB7970", VA = "0x183CB8B70")]
	public ANGJABLNBAF(Vector3 HINCDANPNOE, float EDJIMOOOPCO, Vector3 NLIAHLAMDDF, bool EEOIAGNKOCE, MHGGNCHPCPB<TData> FINCEHLLNFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x387C4A0", Offset = "0x387B2A0", VA = "0x18387C4A0", Slot = "4")]
	public override bool FLEJJGKPECP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x87C80", Offset = "0x87080")]
public class LPNJLMBFJNL<TData> : HJJMADMCJCH<NEBHMCKIPOK<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x87CF0", Offset = "0x870F0")]
	private readonly HCOLLNBAFEK<TData> IBEJACLCCJA;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x53E6590", Offset = "0x53E5390", VA = "0x1853E6590")]
	public LPNJLMBFJNL(List<TData> KLBCGPELFKC, NEBHMCKIPOK<TData> FINCEHLLNFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x53E64C0", Offset = "0x53E52C0", VA = "0x1853E64C0", Slot = "4")]
	public override bool FLEJJGKPECP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public readonly struct DJFAAFOOLDA<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly IEnumerable<TData> IICDDEDLHCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly bool LGFLGNDHDGN;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3131100", Offset = "0x312FF00", VA = "0x183131100")]
	public DJFAAFOOLDA(IEnumerable<TData> DIAEHDKFEME, bool LJDPKMIBIJN = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x87D90", Offset = "0x87190")]
public class HNCEBEDEIGK<TData> : HJJMADMCJCH<NEBHMCKIPOK<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x87E00", Offset = "0x87200")]
	private readonly HCOLLNBAFEK<TData> IBEJACLCCJA;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x3B0E010", Offset = "0x3B0CE10", VA = "0x183B0E010")]
	public HNCEBEDEIGK(List<TData> KLBCGPELFKC, bool LJDPKMIBIJN, NEBHMCKIPOK<TData> FINCEHLLNFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x3B0DF40", Offset = "0x3B0CD40", VA = "0x183B0DF40", Slot = "4")]
	public override bool FLEJJGKPECP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface KGEBNCAMOJN<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void RenderHoverHighlight(T GNOEFMFMEOO, [Optional] HJNMAIFKPEK? ONIEAMHCLDE, bool CGMJKCBGJBL = true);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RenderHoverHighlight(int FNLBOMKPGBB, IEnumerable<T> IGAKKONPCPC, bool CGMJKCBGJBL = true);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RenderHoverHighlight(int FNLBOMKPGBB, IEnumerable<T> IGAKKONPCPC, HJNMAIFKPEK ONIEAMHCLDE, bool CGMJKCBGJBL = true);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public struct LFAPCBNEDNO<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly IEnumerable<TData> DIAEHDKFEME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly bool LJDPKMIBIJN;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x4A22210", Offset = "0x4A21010", VA = "0x184A22210")]
	public LFAPCBNEDNO(IEnumerable<TData> DIAEHDKFEME, bool LJDPKMIBIJN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x87E60", Offset = "0x87260")]
public class FENDMKOLFOP<TData> : PCLKCHLABGE<LPFJGJIKJKH<TData>, NJCONGMGGHJ> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x87ED0", Offset = "0x872D0")]
	private readonly DJFAAFOOLDA<TData> LIGCABLEMFB;

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x4278760", Offset = "0x4277560", VA = "0x184278760")]
	public FENDMKOLFOP(IEnumerable<TData> DIAEHDKFEME, bool LJDPKMIBIJN, LPFJGJIKJKH<TData> FINCEHLLNFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x4278480", Offset = "0x4277280", VA = "0x184278480", Slot = "4")]
	public override Task<NJCONGMGGHJ> FLEJJGKPECP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x87F30", Offset = "0x87330")]
public class IFAABMKMEDO<TData> : HJJMADMCJCH<ECPACIFPKDM<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x87FA0", Offset = "0x873A0")]
	private readonly IMFOPGMLMGE<TData> PIDALGLIKKF;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x2A26B10", Offset = "0x2A25910", VA = "0x182A26B10")]
	public IFAABMKMEDO(TData LMBGOHINBAF, bool LJDPKMIBIJN, ECPACIFPKDM<TData> FINCEHLLNFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2A26A50", Offset = "0x2A25850", VA = "0x182A26A50", Slot = "4")]
	public override bool FLEJJGKPECP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct IMFOPGMLMGE<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public readonly TData LMBGOHINBAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly bool LJDPKMIBIJN;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x2C3D900", Offset = "0x2C3C700", VA = "0x182C3D900")]
	public IMFOPGMLMGE(TData LMBGOHINBAF, bool LJDPKMIBIJN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public struct HOMKGPBICKG<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly IEnumerable<TData> DIAEHDKFEME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public readonly bool LJDPKMIBIJN;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x3B16030", Offset = "0x3B14E30", VA = "0x183B16030")]
	public HOMKGPBICKG(IEnumerable<TData> DIAEHDKFEME, bool LJDPKMIBIJN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x88000", Offset = "0x87400")]
public class AIEFHEPLEKE<TData> : HJJMADMCJCH<MHGGNCHPCPB<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly BACPFNBFOAJ KCABFNJHOAI;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3C38F20", Offset = "0x3C37D20", VA = "0x183C38F20")]
	public AIEFHEPLEKE(float EDJIMOOOPCO, Vector3 NLIAHLAMDDF, MHGGNCHPCPB<TData> FINCEHLLNFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3C38EB0", Offset = "0x3C37CB0", VA = "0x183C38EB0", Slot = "4")]
	public override bool FLEJJGKPECP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x88070", Offset = "0x87470")]
public class BAEEBKNLDAG<TData> : HJJMADMCJCH<NHAHFLLGFJI<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x27CBFC0", Offset = "0x27CADC0", VA = "0x1827CBFC0")]
	public BAEEBKNLDAG(NHAHFLLGFJI<TData> FINCEHLLNFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x44A5D30", Offset = "0x44A4B30", VA = "0x1844A5D30", Slot = "4")]
	public override bool FLEJJGKPECP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x880E0", Offset = "0x874E0")]
public class NGMAMBJEBJG<TData> : HJJMADMCJCH<NHAHFLLGFJI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x88150", Offset = "0x87550")]
	private readonly OFNDCDAOBND<TData> NEKMCOKGJHN;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3EBEE30", Offset = "0x3EBDC30", VA = "0x183EBEE30")]
	public NGMAMBJEBJG(IEnumerable<TData> DIAEHDKFEME, bool LJDPKMIBIJN, NHAHFLLGFJI<TData> FINCEHLLNFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2A26A50", Offset = "0x2A25850", VA = "0x182A26A50", Slot = "4")]
	public override bool FLEJJGKPECP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x881B0", Offset = "0x875B0")]
public class APOBNNFKHBM<TNode> : HJJMADMCJCH<GEDPFIIFCHD<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x88220", Offset = "0x87620")]
	private readonly OHPPNLKMIFI<TNode> IEHKLCMFJJN;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x474A9A0", Offset = "0x47497A0", VA = "0x18474A9A0")]
	public APOBNNFKHBM(TNode CJNKFHKFCOD, GEDPFIIFCHD<TNode> FINCEHLLNFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2A26A50", Offset = "0x2A25850", VA = "0x182A26A50", Slot = "4")]
	public override bool FLEJJGKPECP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x88280", Offset = "0x87680")]
public class EEAKNKDAFCG<TData> : HJJMADMCJCH<LFHAIBJBCKH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x882F0", Offset = "0x876F0")]
	private readonly HOMKGPBICKG<TData> HGCNGHHJEAL;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x344E890", Offset = "0x344D690", VA = "0x18344E890")]
	public EEAKNKDAFCG(IEnumerable<TData> DIAEHDKFEME, bool LJDPKMIBIJN, LFHAIBJBCKH<TData> FINCEHLLNFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2A26A50", Offset = "0x2A25850", VA = "0x182A26A50", Slot = "4")]
	public override bool FLEJJGKPECP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct OFNDCDAOBND<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public readonly IEnumerable<TData> DIAEHDKFEME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public readonly bool LJDPKMIBIJN;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x317EA00", Offset = "0x317D800", VA = "0x18317EA00")]
	public OFNDCDAOBND(IEnumerable<TData> DIAEHDKFEME, bool LJDPKMIBIJN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x88350", Offset = "0x87750")]
public class PGDEPEADINF<TNode> : HJJMADMCJCH<GEDPFIIFCHD<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x883C0", Offset = "0x877C0")]
	private readonly GADONFEHFBM<TNode> GJNEAIBKGJO;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x35FD340", Offset = "0x35FC140", VA = "0x1835FD340")]
	public PGDEPEADINF(TNode CDNLINDHOGF, DMOCEGEPKPE BLJPCLIFEJC, GEDPFIIFCHD<TNode> FINCEHLLNFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x35FD270", Offset = "0x35FC070", VA = "0x1835FD270", Slot = "4")]
	public override bool FLEJJGKPECP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public interface LPFJGJIKJKH<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<NJCONGMGGHJ> IGADNDMDDLB([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x88420", Offset = "0x87820")] in DJFAAFOOLDA<TData> IBEJACLCCJA, CancellationToken KIMBGNGMOGB);
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface NEBHMCKIPOK<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GAPLOLPBCGF([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x88490", Offset = "0x87890")] in HCOLLNBAFEK<TData> IBEJACLCCJA);

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MOKDADBPGMF([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x88500", Offset = "0x87900")] in HCOLLNBAFEK<TData> IBEJACLCCJA);

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IBPBNNIFJMO(in bool HEPCGHCHNIC);

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool MHKNKNJAPNB([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x88570", Offset = "0x87970")] in HCOLLNBAFEK<TData> IBEJACLCCJA);

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HFOFGPOOGOO();

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool BGOECECGKPH(in TData FALOBLAMFKA);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public struct MHBGFCEEGDO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public readonly Quaternion HMPKKKJELLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly Vector3? NLIAHLAMDDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly bool NJKHBCFFGNK;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x191DB70", Offset = "0x191C970", VA = "0x18191DB70")]
	public MHBGFCEEGDO(Quaternion HMPKKKJELLB, Vector3? NLIAHLAMDDF, bool NJKHBCFFGNK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface ECPACIFPKDM<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OJCKDIDHMEI([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x885E0", Offset = "0x879E0")] in IMFOPGMLMGE<TData?> IEHKLCMFJJN);

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NGFCHLDFGNK(in OCLOJNGGEPJ CBJMFANOAIH);

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool NGFCHLDFGNK(in AMNPBAMNNKG CBJMFANOAIH);

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool HDEFLCPFKEN();
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public struct POBHBPLDOBF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly Vector3 HMPKKKJELLB;

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x1838F60", Offset = "0x1837D60", VA = "0x181838F60")]
	public POBHBPLDOBF(Vector3 HMPKKKJELLB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x88650", Offset = "0x87A50")]
public class HBEEABJJMAI<TData> : HJJMADMCJCH<DKOCGEGOGLE<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x886C0", Offset = "0x87AC0")]
	private readonly KLJGAGIIHOE<TData> NEKMCOKGJHN;

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x3B3CBC0", Offset = "0x3B3B9C0", VA = "0x183B3CBC0")]
	public HBEEABJJMAI(IEnumerable<TData> DIAEHDKFEME, Quaternion HMPKKKJELLB, Vector3? NLIAHLAMDDF, bool NJKHBCFFGNK, bool LJDPKMIBIJN, DKOCGEGOGLE<TData> FINCEHLLNFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x2A26A50", Offset = "0x2A25850", VA = "0x182A26A50", Slot = "4")]
	public override bool FLEJJGKPECP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x88720", Offset = "0x87B20")]
public class OBCOEPKPFKD<TData> : HJJMADMCJCH<MHGGNCHPCPB<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x27CBFC0", Offset = "0x27CADC0", VA = "0x1827CBFC0")]
	public OBCOEPKPFKD(MHGGNCHPCPB<TData> FINCEHLLNFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x3167FA0", Offset = "0x3166DA0", VA = "0x183167FA0", Slot = "4")]
	public override bool FLEJJGKPECP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x88790", Offset = "0x87B90")]
public class GPLCPFICLDM<TData> : HJJMADMCJCH<NHAHFLLGFJI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly MHBGFCEEGDO NEKMCOKGJHN;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x467D660", Offset = "0x467C460", VA = "0x18467D660")]
	public GPLCPFICLDM(Quaternion HMPKKKJELLB, Vector3? NLIAHLAMDDF, bool NJKHBCFFGNK, NHAHFLLGFJI<TData> FINCEHLLNFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x3C38EB0", Offset = "0x3C37CB0", VA = "0x183C38EB0", Slot = "4")]
	public override bool FLEJJGKPECP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x88800", Offset = "0x87C00")]
public class NAFJLGNKABF<TData> : HJJMADMCJCH<EBALJGMJNBN<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x88870", Offset = "0x87C70")]
	private readonly MPOEHFKMNNA<TData> AHIPBNNJPHL;

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x38959E0", Offset = "0x38947E0", VA = "0x1838959E0")]
	public NAFJLGNKABF(TData[] DIAEHDKFEME, DMKFAHLEAKG[] OPEMNAAFCJM, FPMADANDHIO[] DMHFIODFBBK, float[] EOJLEDMJOMD, EBALJGMJNBN<TData> FINCEHLLNFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x35EC920", Offset = "0x35EB720", VA = "0x1835EC920", Slot = "4")]
	public override bool FLEJJGKPECP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x888D0", Offset = "0x87CD0")]
public class AINJFOCCHJE<TData> : HJJMADMCJCH<MBDBOLNGHIN<TData>> where TData : notnull, MGMEOMAHPKI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x88940", Offset = "0x87D40")]
	private readonly KGFNIKIHPEE<TData> JLEINNKMBAO;

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x3C38FB0", Offset = "0x3C37DB0", VA = "0x183C38FB0")]
	public AINJFOCCHJE(List<TData> DIAEHDKFEME, List<bool> NLJLAMDHIPF, MBDBOLNGHIN<TData> FINCEHLLNFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x3B0DF40", Offset = "0x3B0CD40", VA = "0x183B0DF40", Slot = "4")]
	public override bool FLEJJGKPECP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x889A0", Offset = "0x87DA0")]
public class KIEKOIFGMOB<TData> : HJJMADMCJCH<LFHAIBJBCKH<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x27CBFC0", Offset = "0x27CADC0", VA = "0x1827CBFC0")]
	public KIEKOIFGMOB(LFHAIBJBCKH<TData> FINCEHLLNFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x44A5D30", Offset = "0x44A4B30", VA = "0x1844A5D30", Slot = "4")]
	public override bool FLEJJGKPECP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public struct OCLOJNGGEPJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public readonly Vector3 LKOAGODCEKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly bool ALJDMHKJFFL;

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x191DC20", Offset = "0x191CA20", VA = "0x18191DC20")]
	public OCLOJNGGEPJ(Vector3 LKOAGODCEKF, bool ALJDMHKJFFL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public interface JLPOHLPPMBD<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NGFCHLDFGNK([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x88A10", Offset = "0x87E10")] in IJGENEMMIKA<TData?> AHIPBNNJPHL);

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HDEFLCPFKEN();
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x88A80", Offset = "0x87E80")]
public class PCBOINKEFGB<TData> : HJJMADMCJCH<JLPOHLPPMBD<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x88AF0", Offset = "0x87EF0")]
	private readonly IJGENEMMIKA<TData> AHIPBNNJPHL;

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x35EC9E0", Offset = "0x35EB7E0", VA = "0x1835EC9E0")]
	public PCBOINKEFGB(IEnumerable<TData> DIAEHDKFEME, DMKFAHLEAKG OPEMNAAFCJM, FPMADANDHIO DMHFIODFBBK, float EOJLEDMJOMD, JLPOHLPPMBD<TData> FINCEHLLNFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x35EC920", Offset = "0x35EB720", VA = "0x1835EC920", Slot = "4")]
	public override bool FLEJJGKPECP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public interface MGMEOMAHPKI
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool OONFHCCACPA
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
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x88B50", Offset = "0x87F50")]
public class MAPBJCCGPKH<TData> : HJJMADMCJCH<ECPACIFPKDM<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly AMNPBAMNNKG PIDALGLIKKF;

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x387C510", Offset = "0x387B310", VA = "0x18387C510")]
	public MAPBJCCGPKH(Guid DNNPDIIFDCK, int FHOMILACEHB, Vector3 IHHJAKDKGPC, Quaternion EMNOFGLPALH, float JDDHCIGHCNC, bool ALJDMHKJFFL, ECPACIFPKDM<TData> FINCEHLLNFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x387C4A0", Offset = "0x387B2A0", VA = "0x18387C4A0", Slot = "4")]
	public override bool FLEJJGKPECP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x88BC0", Offset = "0x87FC0")]
public class JCIHFPFMFHD<TData> : HJJMADMCJCH<MBDBOLNGHIN<TData>> where TData : notnull, MGMEOMAHPKI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x88C30", Offset = "0x88030")]
	private readonly LOEKGGOHGLE<TData> JLEINNKMBAO;

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x318B790", Offset = "0x318A590", VA = "0x18318B790")]
	public JCIHFPFMFHD(List<TData> DIAEHDKFEME, bool GLFMIOIODLJ, MBDBOLNGHIN<TData> FINCEHLLNFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x2A26A50", Offset = "0x2A25850", VA = "0x182A26A50", Slot = "4")]
	public override bool FLEJJGKPECP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x88C90", Offset = "0x88090")]
public class NHHABOPCHOI<TData> : HJJMADMCJCH<NEBHMCKIPOK<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly TData FALOBLAMFKA;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x3EC00A0", Offset = "0x3EBEEA0", VA = "0x183EC00A0")]
	public NHHABOPCHOI(TData FALOBLAMFKA, NEBHMCKIPOK<TData> FINCEHLLNFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x3EBFF30", Offset = "0x3EBED30", VA = "0x183EBFF30", Slot = "4")]
	public override bool FLEJJGKPECP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x88D00", Offset = "0x88100")]
public abstract class HJJMADMCJCH<TReceiver> : ONPKOELNGFE<TReceiver, bool> where TReceiver : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x27CBFC0", Offset = "0x27CADC0", VA = "0x1827CBFC0")]
	public HJJMADMCJCH(TReceiver FINCEHLLNFN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public interface PKHNIFGLHDP
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	Bounds PNBAMNCJEND
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	Transform KFJLOKLCEJL
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	Bounds BPFPDPJNGMH
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	Transform DGKGEFGGKDI
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	Vector3 IIOBCBGJJHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public struct LOEKGGOHGLE<TData> where TData : notnull, MGMEOMAHPKI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public IEnumerable<TData> IICDDEDLHCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public bool GLFMIOIODLJ;

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x37E7620", Offset = "0x37E6420", VA = "0x1837E7620")]
	public LOEKGGOHGLE(IEnumerable<TData> IOFKICFKKFF, bool DAJMFMDOGMB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public struct KGFNIKIHPEE<TData> where TData : notnull, MGMEOMAHPKI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public List<TData> IICDDEDLHCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public List<bool> NLJLAMDHIPF;

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x41993B0", Offset = "0x41981B0", VA = "0x1841993B0")]
	public KGFNIKIHPEE(List<TData> IOFKICFKKFF, List<bool> ACMDKNEOPNO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public interface PICFEFDDGAH<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool HDFMBGMOFHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	int GGLJGBBAFEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	IEnumerable<TData> JLFDIDFOBGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IsSelected(TData IGAFFKCMBEK);

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IsSelectable(TData IGAFFKCMBEK);
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public interface BANIHKJPLHA
{
	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnSelectionPickedUp();

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnSelectionReleased();
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public interface LFHAIBJBCKH<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OJCKDIDHMEI([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x88D70", Offset = "0x88170")] in HOMKGPBICKG<TData?> DMGEGADAKKP);

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NGFCHLDFGNK(in POBHBPLDOBF CBJMFANOAIH);

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool HDEFLCPFKEN();
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x88DE0", Offset = "0x881E0")]
public class BLINPGIOLGD<TData> : HJJMADMCJCH<JLPOHLPPMBD<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x27CBFC0", Offset = "0x27CADC0", VA = "0x1827CBFC0")]
	public BLINPGIOLGD(JLPOHLPPMBD<TData> FINCEHLLNFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x3CCDEE0", Offset = "0x3CCCCE0", VA = "0x183CCDEE0", Slot = "4")]
	public override bool FLEJJGKPECP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public interface BFLHKOIHJON : MGMEOMAHPKI
{
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x88E50", Offset = "0x88250")]
public abstract class PCLKCHLABGE<TReceiver, TFromTask> : ONPKOELNGFE<TReceiver, Task<TFromTask>>
{
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x27CBFC0", Offset = "0x27CADC0", VA = "0x1827CBFC0")]
	public PCLKCHLABGE(TReceiver FINCEHLLNFN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x88EC0", Offset = "0x882C0")]
public class PGBHCPKLOHA<TData> : HJJMADMCJCH<MHGGNCHPCPB<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x88F30", Offset = "0x88330")]
	private readonly LFAPCBNEDNO<TData> KCABFNJHOAI;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x35FD1D0", Offset = "0x35FBFD0", VA = "0x1835FD1D0")]
	public PGBHCPKLOHA(IEnumerable<TData> DIAEHDKFEME, bool LJDPKMIBIJN, MHGGNCHPCPB<TData> FINCEHLLNFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x2A26A50", Offset = "0x2A25850", VA = "0x182A26A50", Slot = "4")]
	public override bool FLEJJGKPECP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public interface OPNDHJGAPMB<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FLEJJGKPECP([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x88F90", Offset = "0x88390")] in APAFBENLMDP<TData?> AHIPBNNJPHL);
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
