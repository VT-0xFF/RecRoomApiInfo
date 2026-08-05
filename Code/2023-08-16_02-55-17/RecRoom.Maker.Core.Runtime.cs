using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
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
		[Cpp2IlInjected.Address(RVA = "0x7E5080", Offset = "0x7E4280", VA = "0x1807E5080")]
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
		[Cpp2IlInjected.Address(RVA = "0x6F50570", Offset = "0x6F4F770", VA = "0x186F50570")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7E3190", Offset = "0x7E2390", VA = "0x1807E3190")]
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
		[Cpp2IlInjected.Address(RVA = "0x17C7540", Offset = "0x17C6740", VA = "0x1817C7540")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DC8D0", Offset = "0x6DBCD0")]
public class NPLBHJLBEOK<TData> : OODFJMOECDB<CLDBGNHNBHL<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly LBFLLJFPMNM HNLMCLBFHIP;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2D79C70", Offset = "0x2D78E70", VA = "0x182D79C70")]
	public NPLBHJLBEOK(Vector3 LJHKOPLGJPN, bool KHNFIBMLCCP, CLDBGNHNBHL<TData> ALLNOIPNMOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x16409A0", Offset = "0x163FBA0", VA = "0x1816409A0", Slot = "4")]
	public override bool HJLCKJBAGNL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DC940", Offset = "0x6DBD40")]
public class MHBFHLJKGGN<TSpawnType, TSpawnInfo> : BFJGCDDDONF<EINKHLKPJGJ<TSpawnType, TSpawnInfo>, TSpawnType> where TSpawnType : notnull where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DC9B0", Offset = "0x6DBDB0")]
	private readonly EGJJCHCPIGA<TSpawnInfo> LCGFCGNMPHN;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3AA27D0", Offset = "0x3AA19D0", VA = "0x183AA27D0")]
	public MHBFHLJKGGN(TSpawnInfo KIBCGIIMOEE, Vector3 BOEKENJNLKP, Quaternion ELGEECMLAMI, float KIJNMGBKNIP, EINKHLKPJGJ<TSpawnType, TSpawnInfo> ALLNOIPNMOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3AA2380", Offset = "0x3AA1580", VA = "0x183AA2380", Slot = "4")]
	public override Task<TSpawnType> HJLCKJBAGNL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct LDFALKELGGM<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public IEnumerable<TData> GDDFGFCBPEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public bool LOKKNPJKACJ;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2C3AB90", Offset = "0x2C39D90", VA = "0x182C3AB90")]
	public LDFALKELGGM(IEnumerable<TData> MPLEDFPPNDE, bool GMDCNAODKEM = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface ANMEPDKFIJI<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EGOLABBFBJK([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DCA50", Offset = "0x6DBE50")] in JIDOAOBNLAF<TData?> MGCHLHDNCDB);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KHIPPDDEAGA(in NDMNJABEIFB BBEFNNJLIMD);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool KHIPPDDEAGA(in LGBGGHMBJFG BBEFNNJLIMD);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool OOKCMLLJANL();
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct IKCJEAFNLDJ<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public TNode BLCFODOGBFH;

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x253EE90", Offset = "0x253E090", VA = "0x18253EE90")]
	public IKCJEAFNLDJ(TNode BLCFODOGBFH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct LMDKJCEILHM<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public TNode DMIHLFOHNOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public LIBBDOCPNDD BECNFDNHEAJ;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3C02440", Offset = "0x3C01640", VA = "0x183C02440")]
	public LMDKJCEILHM(TNode DMIHLFOHNOH, LIBBDOCPNDD BECNFDNHEAJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DCAC0", Offset = "0x6DBEC0")]
public class OBHLOFEMCJD<TData> : OODFJMOECDB<GJKDDAFGPKM<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DCB30", Offset = "0x6DBF30")]
	private readonly LDFALKELGGM<TData> INFDIKKDNAJ;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x24DA310", Offset = "0x24D9510", VA = "0x1824DA310")]
	public OBHLOFEMCJD(List<TData> JLPNEGMFCHO, GJKDDAFGPKM<TData> ALLNOIPNMOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x201B190", Offset = "0x201A390", VA = "0x18201B190", Slot = "4")]
	public override bool HJLCKJBAGNL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface BMMCHODPAJO<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HJLCKJBAGNL([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DCB90", Offset = "0x6DBF90")] in DEDAGNCOOLB<TData?> MKKHBFAKBOK);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct HLMNLFDIDAN<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public IEnumerable<TData> GDDFGFCBPEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public HJGGJBIGLCH LAGNIFEAPPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public AFKEAPAJDHP CDHAIOKFIFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public float ICGLNMBGNFA;

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x20AD940", Offset = "0x20ACB40", VA = "0x1820AD940")]
	public HLMNLFDIDAN(IEnumerable<TData> EKKGCFPGANI, HJGGJBIGLCH GGJPGIMIKJF, AFKEAPAJDHP GMJJKHGKCAP, float ICGLNMBGNFA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
internal static class GNOHAHFLCHE
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6F502C0", Offset = "0x6F4F4C0", VA = "0x186F502C0")]
	public static void AAHPDIDPLKH(IEnumerable IALDCNICBMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x1E2C180", Offset = "0x1E2B380", VA = "0x181E2C180")]
	public static void AAHPDIDPLKH<T>(T[] LMFDNLBGHBA) where T : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface AMNPDHBLOBN<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HJLCKJBAGNL([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DCC40", Offset = "0x6DC040")] in BBDAGNEJCHC<T?> DBENCPELDMK);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct AOJEODNPGNB<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public TData[] GDDFGFCBPEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public HJGGJBIGLCH[] LAGNIFEAPPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public AFKEAPAJDHP[] CDHAIOKFIFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public float[] ICGLNMBGNFA;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x20089E0", Offset = "0x2007BE0", VA = "0x1820089E0")]
	public AOJEODNPGNB(TData[] EKKGCFPGANI, HJGGJBIGLCH[] GGJPGIMIKJF, AFKEAPAJDHP[] GMJJKHGKCAP, float[] ICGLNMBGNFA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface IMFPKEKKCEG
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool EIDFIFEAIDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool EJMLONDLGBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool IGKLPBABFLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool EOPNICHFEFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct AEBBCNFFPIP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly Guid NOEHMKAJCEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly int NNAODBDJDNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly Vector3 BOEKENJNLKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly Quaternion ELGEECMLAMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly float ADBNNNLLGEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public readonly bool KHNFIBMLCCP;

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6F50280", Offset = "0x6F4F480", VA = "0x186F50280")]
	public AEBBCNFFPIP(Guid NOEHMKAJCEN, int NNAODBDJDNJ, Vector3 BOEKENJNLKP, Quaternion ELGEECMLAMI, float ADBNNNLLGEN, bool KHNFIBMLCCP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface KECAJMBBIFH<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EGOLABBFBJK([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DCCB0", Offset = "0x6DC0B0")] in EMFMCLCIEMP<TData?> MGCHLHDNCDB);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KHIPPDDEAGA(in INDIMGCPKHG BBEFNNJLIMD);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool OOKCMLLJANL();
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct NDMNJABEIFB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public readonly float AJOPLFDEMOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public readonly Vector3 GDHPECELJGM;

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x4BDA1E0", Offset = "0x4BD93E0", VA = "0x184BDA1E0")]
	public NDMNJABEIFB(float AJOPLFDEMOP, Vector3 GDHPECELJGM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct LGBGGHMBJFG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly Vector3 DIMGPOIMBHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public readonly float AJOPLFDEMOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly Vector3 GDHPECELJGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly bool KHNFIBMLCCP;

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6F50540", Offset = "0x6F4F740", VA = "0x186F50540")]
	public LGBGGHMBJFG(Vector3 DIMGPOIMBHA, float AJOPLFDEMOP, Vector3 GDHPECELJGM, bool KHNFIBMLCCP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface BMKPDCPDKLF<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<OEFGJBAOAJP> HJLCKJBAGNL([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DCD20", Offset = "0x6DC120")] NMIJDEEBHCB<TData> HLLJGGBINFF);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DCD80", Offset = "0x6DC180")]
public class EOLCPMBBJIM<TData> : OODFJMOECDB<FNOIIIGIHGN<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly NHAPMPIBOKE PCAFALAFHKO;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x1640A10", Offset = "0x163FC10", VA = "0x181640A10")]
	public EOLCPMBBJIM(Vector3 JDAHEGLOPNP, FNOIIIGIHGN<TData> ALLNOIPNMOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x16409A0", Offset = "0x163FBA0", VA = "0x1816409A0", Slot = "4")]
	public override bool HJLCKJBAGNL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface FCBKJFAGGOE<TData> where TData : POILECOIEAP
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HJLCKJBAGNL([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DCDF0", Offset = "0x6DC1F0")] in FIJHKBNNFFA<TData> JFCMLHOKFHC);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HJLCKJBAGNL([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DCE60", Offset = "0x6DC260")] in EPLDMCHEPLB<TData> JFCMLHOKFHC);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class CICLPNPFCCM
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public enum KJPMCEEADFF
	{
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		ICreationContextObject,
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		Guid
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x22368D0", Offset = "0x2235AD0", VA = "0x1822368D0")]
	public static void OFKCCCDJPMJ<T>(T PEJFNLJIKME, KJPMCEEADFF FBNKHAJKFLM) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x2236A50", Offset = "0x2235C50", VA = "0x182236A50")]
	public static void OFKCCCDJPMJ<T>(T PEJFNLJIKME) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x2236680", Offset = "0x2235880", VA = "0x182236680")]
	public static void AFLNHLJBILG<T>(T PEJFNLJIKME) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x22367A0", Offset = "0x22359A0", VA = "0x1822367A0")]
	public static T MCKGCJAFOEM<T>(KJPMCEEADFF FBNKHAJKFLM) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x2236860", Offset = "0x2235A60", VA = "0x182236860")]
	public static T MCKGCJAFOEM<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x2236730", Offset = "0x2235930", VA = "0x182236730")]
	public static bool GDNNGGDGFGE<T>() where T : class
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DCED0", Offset = "0x6DC2D0")]
public class MFCGAAIGBKL<TData> : OODFJMOECDB<GJKDDAFGPKM<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x15C1A30", Offset = "0x15C0C30", VA = "0x1815C1A30")]
	public MFCGAAIGBKL(GJKDDAFGPKM<TData> ALLNOIPNMOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x2AFA1F0", Offset = "0x2AF93F0", VA = "0x182AFA1F0", Slot = "4")]
	public override bool HJLCKJBAGNL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface LKIMFIMMIKM<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool Raycast(Vector3 BIBNBENFBDB, Vector3 KCEMMLEMANI, float EKIBGBMDOJP, out T KINPPODENBI, out Vector3 AHFIDDGMDLJ, out Collider LHNDPANDEFP);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int SpherecastPick(Vector3 BIBNBENFBDB, Vector3 KCEMMLEMANI, float HHFDFBLFNPG, float EKIBGBMDOJP, T[] DEAMKFPFGHP, out Vector3 FKFBEGFJKEM, out Collider OMNLALHGJAB);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int SpherePick(Vector3 BIBNBENFBDB, float HHFDFBLFNPG, Vector3 BHJEKIHJLAC, T[] DEAMKFPFGHP);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public abstract class EAACNFODEPK<TReceiver, TFromExecute> where TReceiver : notnull where TFromExecute : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	protected TReceiver ALLNOIPNMOH;

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x2C24720", Offset = "0x2C23920", VA = "0x182C24720")]
	public EAACNFODEPK(TReceiver ALLNOIPNMOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TFromExecute HJLCKJBAGNL();
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DCF40", Offset = "0x6DC340")]
public class OFEGFHJNODG<TData> : OODFJMOECDB<DJECCMMOELE<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DCFB0", Offset = "0x6DC3B0")]
	private readonly NLMDCHGKLOC<TData> AAAAKEFKDAF;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x201B250", Offset = "0x201A450", VA = "0x18201B250")]
	public OFEGFHJNODG(IEnumerable<TData> EKKGCFPGANI, HJGGJBIGLCH GGJPGIMIKJF, AFKEAPAJDHP GMJJKHGKCAP, float ICGLNMBGNFA, bool LOKKNPJKACJ, DJECCMMOELE<TData> ALLNOIPNMOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x201B190", Offset = "0x201A390", VA = "0x18201B190", Slot = "4")]
	public override bool HJLCKJBAGNL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DD010", Offset = "0x6DC410")]
public class DGNCJDIOHIG<TData> : OODFJMOECDB<CLDBGNHNBHL<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x15C1A30", Offset = "0x15C0C30", VA = "0x1815C1A30")]
	public DGNCJDIOHIG(CLDBGNHNBHL<TData> ALLNOIPNMOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x15C19D0", Offset = "0x15C0BD0", VA = "0x1815C19D0", Slot = "4")]
	public override bool HJLCKJBAGNL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DD080", Offset = "0x6DC480")]
public class BDMEOODMEOO<TData> : OODFJMOECDB<GBEDINJOANG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DD0F0", Offset = "0x6DC4F0")]
	private readonly EOENMPFGDDG<TData> PCAFALAFHKO;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x230D910", Offset = "0x230CB10", VA = "0x18230D910")]
	public BDMEOODMEOO(IEnumerable<TData> EKKGCFPGANI, Vector3 JDAHEGLOPNP, bool LOKKNPJKACJ, GBEDINJOANG<TData> ALLNOIPNMOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x201B190", Offset = "0x201A390", VA = "0x18201B190", Slot = "4")]
	public override bool HJLCKJBAGNL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public struct EOENMPFGDDG<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly IEnumerable<TData> EKKGCFPGANI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public readonly Vector3 JDAHEGLOPNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly bool LOKKNPJKACJ;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x163E780", Offset = "0x163D980", VA = "0x18163E780")]
	public EOENMPFGDDG(IEnumerable<TData> EKKGCFPGANI, Vector3 JDAHEGLOPNP, bool LOKKNPJKACJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface GBEDINJOANG<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HJLCKJBAGNL([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DD150", Offset = "0x6DC550")] in EOENMPFGDDG<TData?> PCAFALAFHKO);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DD1C0", Offset = "0x6DC5C0")]
public class KPMKKPOMMEC<TData> : OODFJMOECDB<GJKDDAFGPKM<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly bool LOKKNPJKACJ;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x37DB3F0", Offset = "0x37DA5F0", VA = "0x1837DB3F0")]
	public KPMKKPOMMEC(bool LOKKNPJKACJ, GJKDDAFGPKM<TData> ALLNOIPNMOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x37DB380", Offset = "0x37DA580", VA = "0x1837DB380", Slot = "4")]
	public override bool HJLCKJBAGNL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public interface JCPIAEAEAKA<TNode>
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EGOLABBFBJK([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DD230", Offset = "0x6DC630")] in IKCJEAFNLDJ<TNode?> MGCHLHDNCDB);

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool OOKCMLLJANL([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DD2A0", Offset = "0x6DC6A0")] in LMDKJCEILHM<TNode?> KGODBMPEOLJ);

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool BBIMAMHMIFJ();
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DD310", Offset = "0x6DC710")]
public class OEFNLIDCCJE<TNode> : OODFJMOECDB<JCPIAEAEAKA<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x15C1A30", Offset = "0x15C0C30", VA = "0x1815C1A30")]
	public OEFNLIDCCJE(JCPIAEAEAKA<TNode> ALLNOIPNMOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2015550", Offset = "0x2014750", VA = "0x182015550", Slot = "4")]
	public override bool HJLCKJBAGNL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface LDCCPNAAMEK<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HJLCKJBAGNL([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DD380", Offset = "0x6DC780")] in AOJEODNPGNB<TData?> AAAAKEFKDAF);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public static class OGPHAOJOKPI
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	private struct MMJPEJPJGKG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public bool MLGLEPCPGFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public JFLMNMMPBBG HBEDEIFBKKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public JFLMNMMPBBG HIPMKBANBJE;
	}

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private static MMJPEJPJGKG LMMDCJGIFCG;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static CancellationToken JDDJPKHEHEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6F50600", Offset = "0x6F4F800", VA = "0x186F50600")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	internal static JFLMNMMPBBG HBEDEIFBKKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6F508D0", Offset = "0x6F4FAD0", VA = "0x186F508D0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6F50850", Offset = "0x6F4FA50", VA = "0x186F50850")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6F507A0", Offset = "0x6F4F9A0", VA = "0x186F507A0")]
	[GKCPJLBLCDF(FEKEMFJBKCA.Room, EHLDMJJGFKP.None)]
	private static void GLCMLHJOLCF(JFLMNMMPBBG KCJJOONLBDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6F50660", Offset = "0x6F4F860", VA = "0x186F50660")]
	public static void FNKHNDBLOJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6F509B0", Offset = "0x6F4FBB0", VA = "0x186F509B0")]
	private static JFLMNMMPBBG OKBLFOPMDOP(JFLMNMMPBBG JJEFLALKOOM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface HKOPCHCEFJF<TData> : OKMMLBFIDMB, AEAGFOKEELC<TData>, GJKDDAFGPKM<TData>, LEKAAJLOMPA<TData>, IMFPKEKKCEG, LKIMFIMMIKM<TData>, CBIKMLAKINJ, MECMIBOKADM
{
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public struct DEDAGNCOOLB<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public readonly IEnumerable<TData> EKKGCFPGANI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public readonly Quaternion JDAHEGLOPNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public readonly Vector3? GDHPECELJGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public readonly bool BBNINAAECAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public readonly bool LOKKNPJKACJ;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x21C4670", Offset = "0x21C3870", VA = "0x1821C4670")]
	public DEDAGNCOOLB(IEnumerable<TData> EKKGCFPGANI, Quaternion JDAHEGLOPNP, Vector3? GDHPECELJGM, bool BBNINAAECAC, bool LOKKNPJKACJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DD410", Offset = "0x6DC810")]
public class KMNJBFMANMO<T> : OODFJMOECDB<AMNPDHBLOBN<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DD480", Offset = "0x6DC880")]
	private readonly BBDAGNEJCHC<T> DBENCPELDMK;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x37D6730", Offset = "0x37D5930", VA = "0x1837D6730")]
	public KMNJBFMANMO(T BJPEGONLJEK, bool MHJLBEDJNAE, AMNPDHBLOBN<T> ALLNOIPNMOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x201B190", Offset = "0x201A390", VA = "0x18201B190", Slot = "4")]
	public override bool HJLCKJBAGNL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public struct NLMDCHGKLOC<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public IEnumerable<TData> GDDFGFCBPEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public HJGGJBIGLCH LAGNIFEAPPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public AFKEAPAJDHP CDHAIOKFIFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public float ICGLNMBGNFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public bool LOKKNPJKACJ;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x2D62A30", Offset = "0x2D61C30", VA = "0x182D62A30")]
	public NLMDCHGKLOC(IEnumerable<TData> EKKGCFPGANI, HJGGJBIGLCH GGJPGIMIKJF, AFKEAPAJDHP GMJJKHGKCAP, float ICGLNMBGNFA, bool LOKKNPJKACJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DD4E0", Offset = "0x6DC8E0")]
public class CCMOLOGKAJB<TData> : OODFJMOECDB<ANMEPDKFIJI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly LGBGGHMBJFG KGNKJGLJOOI;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x1E4FD20", Offset = "0x1E4EF20", VA = "0x181E4FD20")]
	public CCMOLOGKAJB(Vector3 DIMGPOIMBHA, float AJOPLFDEMOP, Vector3 GDHPECELJGM, bool BBHJPEFMOOE, ANMEPDKFIJI<TData> ALLNOIPNMOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x1E4FCB0", Offset = "0x1E4EEB0", VA = "0x181E4FCB0", Slot = "4")]
	public override bool HJLCKJBAGNL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public struct PCFFJFGOLGE<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly T BJPEGONLJEK;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2A1DFB0", Offset = "0x2A1D1B0", VA = "0x182A1DFB0")]
	public PCFFJFGOLGE(T CJDKLOEMALF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DD550", Offset = "0x6DC950")]
public class MPHJOAAKAFN<TData> : OODFJMOECDB<GJKDDAFGPKM<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DD5C0", Offset = "0x6DC9C0")]
	private readonly LDFALKELGGM<TData> INFDIKKDNAJ;

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2781EC0", Offset = "0x27810C0", VA = "0x182781EC0")]
	public MPHJOAAKAFN(List<TData> JLPNEGMFCHO, GJKDDAFGPKM<TData> ALLNOIPNMOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x2781D70", Offset = "0x2780F70", VA = "0x182781D70", Slot = "4")]
	public override bool HJLCKJBAGNL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public readonly struct PAFHDILCGMF<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly IEnumerable<TData> GDDFGFCBPEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly bool OIMJGKHNONF;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x2A19E30", Offset = "0x2A19030", VA = "0x182A19E30")]
	public PAFHDILCGMF(IEnumerable<TData> EKKGCFPGANI, bool LOKKNPJKACJ = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface MECMIBOKADM
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	HFMPGNIBJKD PENPBIOEGDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DD660", Offset = "0x6DCA60")]
public class EPEENFIDIFF<TData> : OODFJMOECDB<GJKDDAFGPKM<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DD6D0", Offset = "0x6DCAD0")]
	private readonly LDFALKELGGM<TData> INFDIKKDNAJ;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x1641920", Offset = "0x1640B20", VA = "0x181641920")]
	public EPEENFIDIFF(List<TData> JLPNEGMFCHO, bool LOKKNPJKACJ, GJKDDAFGPKM<TData> ALLNOIPNMOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x16417C0", Offset = "0x16409C0", VA = "0x1816417C0", Slot = "4")]
	public override bool HJLCKJBAGNL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface AEAGFOKEELC<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void RenderHoverHighlight(T PPNJOAJJOFF, [Optional] BLPFGIECEBB? DPBBKDNKPAE, bool NJFDBBFOJOA = true);

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RenderHoverHighlight(int BKHJHJOLNNF, IEnumerable<T> CJNNEOGFKIK, bool NJFDBBFOJOA = true);

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RenderHoverHighlight(int BKHJHJOLNNF, IEnumerable<T> CJNNEOGFKIK, BLPFGIECEBB DPBBKDNKPAE, bool NJFDBBFOJOA = true);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct JIDOAOBNLAF<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public readonly IEnumerable<TData> EKKGCFPGANI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public readonly bool LOKKNPJKACJ;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x3000C00", Offset = "0x2FFFE00", VA = "0x183000C00")]
	public JIDOAOBNLAF(IEnumerable<TData> EKKGCFPGANI, bool LOKKNPJKACJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DD730", Offset = "0x6DCB30")]
public class CAIFMDPPNIE<TData> : BFJGCDDDONF<LONLBLMEDOH<TData>, OEFGJBAOAJP> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DD7A0", Offset = "0x6DCBA0")]
	private readonly PAFHDILCGMF<TData> OGHLNBINJKC;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x1E407F0", Offset = "0x1E3F9F0", VA = "0x181E407F0")]
	public CAIFMDPPNIE(IEnumerable<TData> EKKGCFPGANI, bool LOKKNPJKACJ, LONLBLMEDOH<TData> ALLNOIPNMOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x1E405B0", Offset = "0x1E3F7B0", VA = "0x181E405B0", Slot = "4")]
	public override Task<OEFGJBAOAJP> HJLCKJBAGNL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DD800", Offset = "0x6DCC00")]
public class MBOLIPOINEL<TData> : OODFJMOECDB<CLDBGNHNBHL<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DD870", Offset = "0x6DCC70")]
	private readonly NNKLFKFEOII<TData> HNLMCLBFHIP;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2AF14E0", Offset = "0x2AF06E0", VA = "0x182AF14E0")]
	public MBOLIPOINEL(TData BJPEGONLJEK, bool LOKKNPJKACJ, CLDBGNHNBHL<TData> ALLNOIPNMOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x201B190", Offset = "0x201A390", VA = "0x18201B190", Slot = "4")]
	public override bool HJLCKJBAGNL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public struct NNKLFKFEOII<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public readonly TData BJPEGONLJEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly bool LOKKNPJKACJ;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2D785B0", Offset = "0x2D777B0", VA = "0x182D785B0")]
	public NNKLFKFEOII(TData BJPEGONLJEK, bool LOKKNPJKACJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct FBBHLAAKGCG<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly IEnumerable<TData> EKKGCFPGANI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public readonly bool LOKKNPJKACJ;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x1C64050", Offset = "0x1C63250", VA = "0x181C64050")]
	public FBBHLAAKGCG(IEnumerable<TData> EKKGCFPGANI, bool LOKKNPJKACJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DD8D0", Offset = "0x6DCCD0")]
public class IIEIPHKCHJN<T> : OODFJMOECDB<EKEFDDEPLML<T>> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x15C1A30", Offset = "0x15C0C30", VA = "0x1815C1A30")]
	public IIEIPHKCHJN(EKEFDDEPLML<T> ALLNOIPNMOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x1C45440", Offset = "0x1C44640", VA = "0x181C45440", Slot = "4")]
	public override bool HJLCKJBAGNL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DD940", Offset = "0x6DCD40")]
public class IIHMFOBCBNI<TData> : OODFJMOECDB<ANMEPDKFIJI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly NDMNJABEIFB KGNKJGLJOOI;

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x2569A40", Offset = "0x2568C40", VA = "0x182569A40")]
	public IIHMFOBCBNI(float AJOPLFDEMOP, Vector3 GDHPECELJGM, ANMEPDKFIJI<TData> ALLNOIPNMOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x16409A0", Offset = "0x163FBA0", VA = "0x1816409A0", Slot = "4")]
	public override bool HJLCKJBAGNL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DD9B0", Offset = "0x6DCDB0")]
public class HFDJLKAJIEH<TData> : OODFJMOECDB<KECAJMBBIFH<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x15C1A30", Offset = "0x15C0C30", VA = "0x1815C1A30")]
	public HFDJLKAJIEH(KECAJMBBIFH<TData> ALLNOIPNMOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x2015550", Offset = "0x2014750", VA = "0x182015550", Slot = "4")]
	public override bool HJLCKJBAGNL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DDA20", Offset = "0x6DCE20")]
public class AGPDPMLNBCJ<TData> : OODFJMOECDB<KECAJMBBIFH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DDA90", Offset = "0x6DCE90")]
	private readonly EMFMCLCIEMP<TData> MKKHBFAKBOK;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x28ED110", Offset = "0x28EC310", VA = "0x1828ED110")]
	public AGPDPMLNBCJ(IEnumerable<TData> EKKGCFPGANI, bool LOKKNPJKACJ, KECAJMBBIFH<TData> ALLNOIPNMOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x201B190", Offset = "0x201A390", VA = "0x18201B190", Slot = "4")]
	public override bool HJLCKJBAGNL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DDAF0", Offset = "0x6DCEF0")]
public class KGNGCDNMNNJ<TNode> : OODFJMOECDB<JCPIAEAEAKA<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DDB60", Offset = "0x6DCF60")]
	private readonly IKCJEAFNLDJ<TNode> MGCHLHDNCDB;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x22996C0", Offset = "0x22988C0", VA = "0x1822996C0")]
	public KGNGCDNMNNJ(TNode GCCAOIOJADA, JCPIAEAEAKA<TNode> ALLNOIPNMOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x201B190", Offset = "0x201A390", VA = "0x18201B190", Slot = "4")]
	public override bool HJLCKJBAGNL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DDBC0", Offset = "0x6DCFC0")]
public class HINBEHNFEJB<TData> : OODFJMOECDB<FNOIIIGIHGN<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DDC30", Offset = "0x6DD030")]
	private readonly FBBHLAAKGCG<TData> PCAFALAFHKO;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x20AA790", Offset = "0x20A9990", VA = "0x1820AA790")]
	public HINBEHNFEJB(IEnumerable<TData> EKKGCFPGANI, bool LOKKNPJKACJ, FNOIIIGIHGN<TData> ALLNOIPNMOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x201B190", Offset = "0x201A390", VA = "0x18201B190", Slot = "4")]
	public override bool HJLCKJBAGNL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public struct EMFMCLCIEMP<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public readonly IEnumerable<TData> EKKGCFPGANI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly bool LOKKNPJKACJ;

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x163A100", Offset = "0x1639300", VA = "0x18163A100")]
	public EMFMCLCIEMP(IEnumerable<TData> EKKGCFPGANI, bool LOKKNPJKACJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DDC90", Offset = "0x6DD090")]
public class NDGMLIBLLNO<TNode> : OODFJMOECDB<JCPIAEAEAKA<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DDD00", Offset = "0x6DD100")]
	private readonly LMDKJCEILHM<TNode> KGODBMPEOLJ;

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x1C55590", Offset = "0x1C54790", VA = "0x181C55590")]
	public NDGMLIBLLNO(TNode DMIHLFOHNOH, LIBBDOCPNDD BECNFDNHEAJ, JCPIAEAEAKA<TNode> ALLNOIPNMOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x1C554D0", Offset = "0x1C546D0", VA = "0x181C554D0", Slot = "4")]
	public override bool HJLCKJBAGNL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface LONLBLMEDOH<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<OEFGJBAOAJP> PENLDHEEEMJ([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DDD60", Offset = "0x6DD160")] in PAFHDILCGMF<TData> INFDIKKDNAJ, CancellationToken MELLLMEKJLC);
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public interface GJKDDAFGPKM<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LOJCKKKGDOB([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DDDD0", Offset = "0x6DD1D0")] in LDFALKELGGM<TData> INFDIKKDNAJ);

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MNCKLDJJMKO([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DDE40", Offset = "0x6DD240")] in LDFALKELGGM<TData> INFDIKKDNAJ);

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DMBKFIECGIL(in bool DDJILJIHECB);

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool CPENGJAMJCH([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DDEB0", Offset = "0x6DD2B0")] in LDFALKELGGM<TData> INFDIKKDNAJ);

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PCJOLAODJAE();

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool ILLDCLCPLNP(in TData PBNPDBABGCJ);
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public struct INDIMGCPKHG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly Quaternion JDAHEGLOPNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public readonly Vector3? GDHPECELJGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly bool BBNINAAECAC;

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x5446370", Offset = "0x5445570", VA = "0x185446370")]
	public INDIMGCPKHG(Quaternion JDAHEGLOPNP, Vector3? GDHPECELJGM, bool BBNINAAECAC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public interface CLDBGNHNBHL<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EGOLABBFBJK([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DDF20", Offset = "0x6DD320")] in NNKLFKFEOII<TData?> MGCHLHDNCDB);

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KHIPPDDEAGA(in LBFLLJFPMNM BBEFNNJLIMD);

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool KHIPPDDEAGA(in AEBBCNFFPIP BBEFNNJLIMD);

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool OOKCMLLJANL();
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public struct NHAPMPIBOKE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public readonly Vector3 JDAHEGLOPNP;

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x2C26B70", Offset = "0x2C25D70", VA = "0x182C26B70")]
	public NHAPMPIBOKE(Vector3 JDAHEGLOPNP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DDF90", Offset = "0x6DD390")]
public class FLCLNOKCNCN<T> : OODFJMOECDB<EKEFDDEPLML<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DE000", Offset = "0x6DD400")]
	private readonly PCFFJFGOLGE<T> EOOLNBJCCAN;

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x2C1C050", Offset = "0x2C1B250", VA = "0x182C1C050")]
	public FLCLNOKCNCN(T BJPEGONLJEK, EKEFDDEPLML<T> ALLNOIPNMOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x201B190", Offset = "0x201A390", VA = "0x18201B190", Slot = "4")]
	public override bool HJLCKJBAGNL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DE060", Offset = "0x6DD460")]
public class CKBCNNADGIO<TData> : OODFJMOECDB<BMMCHODPAJO<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DE0D0", Offset = "0x6DD4D0")]
	private readonly DEDAGNCOOLB<TData> MKKHBFAKBOK;

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x26AE320", Offset = "0x26AD520", VA = "0x1826AE320")]
	public CKBCNNADGIO(IEnumerable<TData> EKKGCFPGANI, Quaternion JDAHEGLOPNP, Vector3? GDHPECELJGM, bool BBNINAAECAC, bool LOKKNPJKACJ, BMMCHODPAJO<TData> ALLNOIPNMOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x201B190", Offset = "0x201A390", VA = "0x18201B190", Slot = "4")]
	public override bool HJLCKJBAGNL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DE130", Offset = "0x6DD530")]
public class LAOHFOFPPOM<TData> : OODFJMOECDB<ANMEPDKFIJI<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x15C1A30", Offset = "0x15C0C30", VA = "0x1815C1A30")]
	public LAOHFOFPPOM(ANMEPDKFIJI<TData> ALLNOIPNMOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x15C19D0", Offset = "0x15C0BD0", VA = "0x1815C19D0", Slot = "4")]
	public override bool HJLCKJBAGNL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DE1A0", Offset = "0x6DD5A0")]
public class LKAFJILMGOO<TData> : OODFJMOECDB<KECAJMBBIFH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private readonly INDIMGCPKHG MKKHBFAKBOK;

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x29FC290", Offset = "0x29FB490", VA = "0x1829FC290")]
	public LKAFJILMGOO(Quaternion JDAHEGLOPNP, Vector3? GDHPECELJGM, bool BBNINAAECAC, KECAJMBBIFH<TData> ALLNOIPNMOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x16409A0", Offset = "0x163FBA0", VA = "0x1816409A0", Slot = "4")]
	public override bool HJLCKJBAGNL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DE210", Offset = "0x6DD610")]
public class ACLCNGJIFKD<TData> : OODFJMOECDB<LDCCPNAAMEK<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DE280", Offset = "0x6DD680")]
	private readonly AOJEODNPGNB<TData> AAAAKEFKDAF;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x28E5D50", Offset = "0x28E4F50", VA = "0x1828E5D50")]
	public ACLCNGJIFKD(TData[] EKKGCFPGANI, HJGGJBIGLCH[] GGJPGIMIKJF, AFKEAPAJDHP[] GMJJKHGKCAP, float[] ICGLNMBGNFA, LDCCPNAAMEK<TData> ALLNOIPNMOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x28E5C90", Offset = "0x28E4E90", VA = "0x1828E5C90", Slot = "4")]
	public override bool HJLCKJBAGNL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DE2E0", Offset = "0x6DD6E0")]
public class FGBACCNNEFJ<TData> : OODFJMOECDB<FCBKJFAGGOE<TData>> where TData : notnull, POILECOIEAP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DE350", Offset = "0x6DD750")]
	private readonly EPLDMCHEPLB<TData> JFCMLHOKFHC;

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x2C0C730", Offset = "0x2C0B930", VA = "0x182C0C730")]
	public FGBACCNNEFJ(List<TData> EKKGCFPGANI, List<bool> NOECPAPGBLI, FCBKJFAGGOE<TData> ALLNOIPNMOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x16417C0", Offset = "0x16409C0", VA = "0x1816417C0", Slot = "4")]
	public override bool HJLCKJBAGNL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DE3B0", Offset = "0x6DD7B0")]
public class MMDPNEMOKOK<TData> : OODFJMOECDB<FNOIIIGIHGN<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x15C1A30", Offset = "0x15C0C30", VA = "0x1815C1A30")]
	public MMDPNEMOKOK(FNOIIIGIHGN<TData> ALLNOIPNMOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x2015550", Offset = "0x2014750", VA = "0x182015550", Slot = "4")]
	public override bool HJLCKJBAGNL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public struct LBFLLJFPMNM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly Vector3 LJHKOPLGJPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly bool KHNFIBMLCCP;

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x6F50520", Offset = "0x6F4F720", VA = "0x186F50520")]
	public LBFLLJFPMNM(Vector3 LJHKOPLGJPN, bool KHNFIBMLCCP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public struct BBDAGNEJCHC<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public readonly T BJPEGONLJEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public readonly bool CFGDOPGFMME;

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x507FE30", Offset = "0x507F030", VA = "0x18507FE30")]
	public BBDAGNEJCHC(T CJDKLOEMALF, bool MHJLBEDJNAE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public interface BPNOBOBKELM<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KHIPPDDEAGA([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DE420", Offset = "0x6DD820")] in HLMNLFDIDAN<TData?> AAAAKEFKDAF);

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OOKCMLLJANL();
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DE490", Offset = "0x6DD890")]
public class DALJMELMBHJ<TData> : OODFJMOECDB<BPNOBOBKELM<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DE500", Offset = "0x6DD900")]
	private readonly HLMNLFDIDAN<TData> AAAAKEFKDAF;

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x2991C70", Offset = "0x2990E70", VA = "0x182991C70")]
	public DALJMELMBHJ(IEnumerable<TData> EKKGCFPGANI, HJGGJBIGLCH GGJPGIMIKJF, AFKEAPAJDHP GMJJKHGKCAP, float ICGLNMBGNFA, BPNOBOBKELM<TData> ALLNOIPNMOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x28E5C90", Offset = "0x28E4E90", VA = "0x1828E5C90", Slot = "4")]
	public override bool HJLCKJBAGNL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public interface EINKHLKPJGJ<TSpawnType, TSpawnInfo>
{
	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> LJDBBCHIBFC([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DE560", Offset = "0x6DD960")] in EGJJCHCPIGA<TSpawnInfo> OCKDCKAJHPK, CancellationToken MELLLMEKJLC);
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public struct EGJJCHCPIGA<TSpawnInfo> where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public TSpawnInfo NCKLOPJILBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public Vector3 BOEKENJNLKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public Quaternion ELGEECMLAMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public float KIJNMGBKNIP;

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x184EC70", Offset = "0x184DE70", VA = "0x18184EC70")]
	public EGJJCHCPIGA(TSpawnInfo NCKLOPJILBO, Vector3 BOEKENJNLKP, Quaternion ELGEECMLAMI, float KIJNMGBKNIP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public interface POILECOIEAP
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool PIAGNFFONFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DE5D0", Offset = "0x6DD9D0")]
public class HOCNDGFDDIE<TData> : OODFJMOECDB<CLDBGNHNBHL<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly AEBBCNFFPIP HNLMCLBFHIP;

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x25974A0", Offset = "0x25966A0", VA = "0x1825974A0")]
	public HOCNDGFDDIE(Guid NOEHMKAJCEN, int NNAODBDJDNJ, Vector3 BOEKENJNLKP, Quaternion ELGEECMLAMI, float ADBNNNLLGEN, bool KHNFIBMLCCP, CLDBGNHNBHL<TData> ALLNOIPNMOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x1E4FCB0", Offset = "0x1E4EEB0", VA = "0x181E4FCB0", Slot = "4")]
	public override bool HJLCKJBAGNL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public struct NMIJDEEBHCB<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public TData HKGAENNMBAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public IReadOnlyList<TData> DGJHBGKINPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public bool OIMJGKHNONF;

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x2D70230", Offset = "0x2D6F430", VA = "0x182D70230")]
	public NMIJDEEBHCB(TData DJHBFDKHBMI, IReadOnlyList<TData> AEDPNHCLCBM, bool LOKKNPJKACJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public interface DEFJMAEONIG<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ClearHoverTarget(HLIMEKKIDCI BHFKBKGOFKL);

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool SetHoverTarget(TData BJPEGONLJEK, Collider LHNDPANDEFP, HLIMEKKIDCI BHFKBKGOFKL, [Optional] BLPFGIECEBB? JBAGFOHMNEG);

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool TryGetHoverTarget(out TData BJPEGONLJEK);
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DE640", Offset = "0x6DDA40")]
public class CGDGMKDJLDO<TData> : OODFJMOECDB<FCBKJFAGGOE<TData>> where TData : notnull, POILECOIEAP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DE6B0", Offset = "0x6DDAB0")]
	private readonly FIJHKBNNFFA<TData> JFCMLHOKFHC;

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x3E6B5E0", Offset = "0x3E6A7E0", VA = "0x183E6B5E0")]
	public CGDGMKDJLDO(List<TData> EKKGCFPGANI, bool CNDKFHDKLPD, FCBKJFAGGOE<TData> ALLNOIPNMOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x201B190", Offset = "0x201A390", VA = "0x18201B190", Slot = "4")]
	public override bool HJLCKJBAGNL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DE710", Offset = "0x6DDB10")]
public class DNFILJMHBFH<TData> : OODFJMOECDB<GJKDDAFGPKM<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly TData PBNPDBABGCJ;

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x2C783D0", Offset = "0x2C775D0", VA = "0x182C783D0")]
	public DNFILJMHBFH(TData PBNPDBABGCJ, GJKDDAFGPKM<TData> ALLNOIPNMOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x2C78270", Offset = "0x2C77470", VA = "0x182C78270", Slot = "4")]
	public override bool HJLCKJBAGNL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DE780", Offset = "0x6DDB80")]
public class GDPEDFPPDPB<TData> : BFJGCDDDONF<BMKPDCPDKLF<TData>, OEFGJBAOAJP> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private sealed class PEPCHJKAGOG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public AsyncTaskMethodBuilder<OEFGJBAOAJP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public GDPEDFPPDPB<TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private OEFGJBAOAJP <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private TaskAwaiter<OEFGJBAOAJP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x9CF3C0", Offset = "0x9CE5C0", VA = "0x1809CF3C0")]
		public PEPCHJKAGOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x366D240", Offset = "0x366C440", VA = "0x18366D240", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DE7F0", Offset = "0x6DDBF0")]
	private readonly NMIJDEEBHCB<TData> CFGIGJCGHLJ;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x2E77780", Offset = "0x2E76980", VA = "0x182E77780")]
	public GDPEDFPPDPB(TData DJHBFDKHBMI, IReadOnlyList<TData> AEDPNHCLCBM, bool LOKKNPJKACJ, BMKPDCPDKLF<TData> ALLNOIPNMOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x2E77610", Offset = "0x2E76810", VA = "0x182E77610", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(GDPEDFPPDPB<>.PEPCHJKAGOG))]
	public override Task<OEFGJBAOAJP> HJLCKJBAGNL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DE8C0", Offset = "0x6DDCC0")]
public abstract class OODFJMOECDB<TReceiver> : EAACNFODEPK<TReceiver, bool> where TReceiver : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x15C1A30", Offset = "0x15C0C30", VA = "0x1815C1A30")]
	public OODFJMOECDB(TReceiver ALLNOIPNMOH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public interface OKMMLBFIDMB
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	Bounds MLLCEANHMMM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	Transform GEKNCPDPENB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	Bounds LHLHJHCCGGK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	Transform PIPBNKEOKAG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	Vector3 OKILHKLOILN
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void SetSelectionBoundsDirty(bool CMKGCCHJFLM = true, int GLPCFCLKGHI = 0);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ShouldHideSelectionBoundsPreview(bool IGBDNNHGNOF, object FDCOCHLAHJD);
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public struct FIJHKBNNFFA<TData> where TData : notnull, POILECOIEAP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public IEnumerable<TData> GDDFGFCBPEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public bool CNDKFHDKLPD;

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x2C12F50", Offset = "0x2C12150", VA = "0x182C12F50")]
	public FIJHKBNNFFA(IEnumerable<TData> MPLEDFPPNDE, bool CPBPKHGHOOE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public struct EPLDMCHEPLB<TData> where TData : notnull, POILECOIEAP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public List<TData> GDDFGFCBPEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public List<bool> NOECPAPGBLI;

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x1641A50", Offset = "0x1640C50", VA = "0x181641A50")]
	public EPLDMCHEPLB(List<TData> MPLEDFPPNDE, List<bool> HLGMKLLEPPL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public interface LEKAAJLOMPA<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool FNOEJDJHPII
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	int CIMEFBJLNIC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	IEnumerable<TData> AJODHCGNGCE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IsSelected(TData JJJLNAPHHCM);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IsSelectable(TData JJJLNAPHHCM);
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public interface CBIKMLAKINJ
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnSelectionPickedUp();

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnSelectionReleased();
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public interface FNOIIIGIHGN<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EGOLABBFBJK([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DE930", Offset = "0x6DDD30")] in FBBHLAAKGCG<TData?> DBPPCLEFJJM);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KHIPPDDEAGA(in NHAPMPIBOKE BBEFNNJLIMD);

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool OOKCMLLJANL();
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DE9A0", Offset = "0x6DDDA0")]
public class AGOCFJAFKKH<TData> : OODFJMOECDB<BPNOBOBKELM<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x15C1A30", Offset = "0x15C0C30", VA = "0x1815C1A30")]
	public AGOCFJAFKKH(BPNOBOBKELM<TData> ALLNOIPNMOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x28ED0B0", Offset = "0x28EC2B0", VA = "0x1828ED0B0", Slot = "4")]
	public override bool HJLCKJBAGNL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public interface CDAAJMGNIPI : POILECOIEAP
{
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DEA10", Offset = "0x6DDE10")]
public abstract class BFJGCDDDONF<TReceiver, TFromTask> : EAACNFODEPK<TReceiver, Task<TFromTask>>
{
	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x15C1A30", Offset = "0x15C0C30", VA = "0x1815C1A30")]
	public BFJGCDDDONF(TReceiver ALLNOIPNMOH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public interface EKEFDDEPLML<T>
{
	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EGOLABBFBJK([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DEA80", Offset = "0x6DDE80")] in PCFFJFGOLGE<T?> EOOLNBJCCAN);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool OOKCMLLJANL();
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DEAF0", Offset = "0x6DDEF0")]
public class JPJENLPDAGE<TData> : OODFJMOECDB<ANMEPDKFIJI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DEB60", Offset = "0x6DDF60")]
	private readonly JIDOAOBNLAF<TData> KGNKJGLJOOI;

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x3C67210", Offset = "0x3C66410", VA = "0x183C67210")]
	public JPJENLPDAGE(IEnumerable<TData> EKKGCFPGANI, bool LOKKNPJKACJ, ANMEPDKFIJI<TData> ALLNOIPNMOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x201B190", Offset = "0x201A390", VA = "0x18201B190", Slot = "4")]
	public override bool HJLCKJBAGNL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public interface DJECCMMOELE<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HJLCKJBAGNL([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DEBC0", Offset = "0x6DDFC0")] in NLMDCHGKLOC<TData?> AAAAKEFKDAF);
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
