using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface DGLJMMOCNPC<TObject, TPlayer, TRpcParam, TSyncField, TSyncFieldParam, TSyncFieldValue>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	TPlayer OLILMDOIKHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PNOOLIOJPCM(in TObject HKFNIHLBEHC, in TRpcParam FMOFDIPGIHC);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ECEAPHGKGHH(in TObject HKFNIHLBEHC, in TRpcParam FMOFDIPGIHC);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EOOIHAJHKIH(in TObject HKFNIHLBEHC, in TRpcParam FMOFDIPGIHC);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MOADBGANELG(in TObject HKFNIHLBEHC, in TRpcParam FMOFDIPGIHC);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	TPlayer LPHHBBBPPJH(in TObject HKFNIHLBEHC);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool MLJLOBGANDL(in TObject HKFNIHLBEHC, TPlayer DNBOIJPFOAB);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "7")]
	TSyncField IJFFFBOOPOB(global::JNODMCDPIFF<ADLHIFAEJNM> FBDAFGPAOAL, in TObject HKFNIHLBEHC, in TSyncFieldParam FMOFDIPGIHC);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void ANDPCLLPNNG(in TSyncField FMOFDIPGIHC);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void FAGOKJCPANL(in TSyncField NLIGLMCBGKJ, in TSyncFieldValue PKODKJLGOIN);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface BMAPKMGAHFN<TRpcParam>
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JDCHMJLJOGG(in TRpcParam PADKGNIPPLI);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public sealed class GOGPGCBJKPB
{
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class ADLHIFAEJNM
{
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class CKEPMJOPFJA<TObject, TPlayer, TRpcParam, TRpcReceiver, TSyncField, TSyncFieldParam, TSyncFieldValue, TDeps> : IDisposable where TRpcReceiver : global::BMAPKMGAHFN<TRpcParam> where TDeps : global::DGLJMMOCNPC<TObject, TPlayer, TRpcParam, TSyncField, TSyncFieldParam, TSyncFieldValue>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly TDeps LCFKANIOINC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private global::NNCPNHLELOH<GOGPGCBJKPB, global::JCIAKPCLCHK<TObject, TRpcParam, TRpcReceiver>> FOCCEHDNNME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private global::NNCPNHLELOH<ADLHIFAEJNM, global::DJBKFHPPPHH<TSyncField>> JHOFONIAPHI;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public TPlayer OLILMDOIKHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x27639C0", Offset = "0x2762DC0", VA = "0x1827639C0")]
		get
		{
			return (TPlayer)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x2763B60", Offset = "0x2762F60", VA = "0x182763B60")]
	public TSyncField IHICBDOFGLO(global::JNODMCDPIFF<ADLHIFAEJNM> AONODCFFDGE)
	{
		return (TSyncField)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2764F60", Offset = "0x2764360", VA = "0x182764F60")]
	protected CKEPMJOPFJA(in TDeps LFLGCLEIAAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x2762E40", Offset = "0x2762240", VA = "0x182762E40")]
	public static global::CKEPMJOPFJA<TObject, TPlayer, TRpcParam, TRpcReceiver, TSyncField, TSyncFieldParam, TSyncFieldValue, TDeps> AJMCJLMMDDK(in TDeps LFLGCLEIAAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2763750", Offset = "0x2762B50", VA = "0x182763750", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x2764E50", Offset = "0x2764250", VA = "0x182764E50")]
	public global::JNODMCDPIFF<GOGPGCBJKPB> OBBBLHHDDDK(in TObject HKFNIHLBEHC)
	{
		return default(global::JNODMCDPIFF<GOGPGCBJKPB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x2764B50", Offset = "0x2763F50", VA = "0x182764B50")]
	public void NPMHDFIHKNN(global::JNODMCDPIFF<GOGPGCBJKPB> HKFNIHLBEHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x2764580", Offset = "0x2763980", VA = "0x182764580")]
	public void LHENOMJMKNM(global::JNODMCDPIFF<GOGPGCBJKPB> HKFNIHLBEHC, in TRpcParam FMOFDIPGIHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2764EC0", Offset = "0x27642C0", VA = "0x182764EC0")]
	public void PNOOLIOJPCM(global::JNODMCDPIFF<GOGPGCBJKPB> HKFNIHLBEHC, in TRpcParam FMOFDIPGIHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x2763A20", Offset = "0x2762E20", VA = "0x182763A20")]
	public void ECEAPHGKGHH(global::JNODMCDPIFF<GOGPGCBJKPB> HKFNIHLBEHC, in TRpcParam FMOFDIPGIHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x2763AC0", Offset = "0x2762EC0", VA = "0x182763AC0")]
	public void EOOIHAJHKIH(global::JNODMCDPIFF<GOGPGCBJKPB> HKFNIHLBEHC, in TRpcParam FMOFDIPGIHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2764AB0", Offset = "0x2763EB0", VA = "0x182764AB0")]
	public void MOADBGANELG(global::JNODMCDPIFF<GOGPGCBJKPB> HKFNIHLBEHC, in TRpcParam FMOFDIPGIHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x2764700", Offset = "0x2763B00", VA = "0x182764700")]
	public void MEIMACBAPJG(global::JNODMCDPIFF<GOGPGCBJKPB> HKFNIHLBEHC, in TRpcReceiver FOEBBFDCJIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2764610", Offset = "0x2763A10", VA = "0x182764610")]
	public TPlayer LPHHBBBPPJH(global::JNODMCDPIFF<GOGPGCBJKPB> HKFNIHLBEHC)
	{
		return (TPlayer)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x27648C0", Offset = "0x2763CC0", VA = "0x1827648C0")]
	public bool MLJLOBGANDL(global::JNODMCDPIFF<GOGPGCBJKPB> HKFNIHLBEHC, in TPlayer DNBOIJPFOAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x2764210", Offset = "0x2763610", VA = "0x182764210")]
	public global::JNODMCDPIFF<ADLHIFAEJNM> IJFFFBOOPOB(global::JNODMCDPIFF<GOGPGCBJKPB> HKFNIHLBEHC, in TSyncFieldParam FMOFDIPGIHC)
	{
		return default(global::JNODMCDPIFF<ADLHIFAEJNM>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x2762F10", Offset = "0x2762310", VA = "0x182762F10")]
	public void ANDPCLLPNNG(global::JNODMCDPIFF<ADLHIFAEJNM> HOPKAGAFBOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x27647D0", Offset = "0x2763BD0", VA = "0x1827647D0")]
	public void MELIKPHLCGH(global::JNODMCDPIFF<ADLHIFAEJNM> NLIGLMCBGKJ, in TSyncFieldValue PKODKJLGOIN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
internal struct JCIAKPCLCHK<TObject, TRpcParam, TRpcReceiver> where TRpcReceiver : global::BMAPKMGAHFN<TRpcParam>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly HashSet<global::JNODMCDPIFF<ADLHIFAEJNM>> GAPOGMCHHMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly TObject MNLOGOLHODA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public TRpcReceiver HAHBGFDFHCG;

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x29AD870", Offset = "0x29ACC70", VA = "0x1829AD870")]
	private JCIAKPCLCHK(HashSet<global::JNODMCDPIFF<ADLHIFAEJNM>> BIAEMOGLJED, in TObject HKFNIHLBEHC, in TRpcReceiver FOEBBFDCJIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x29AD750", Offset = "0x29ACB50", VA = "0x1829AD750")]
	public static global::JCIAKPCLCHK<TObject, TRpcParam, TRpcReceiver> AJMCJLMMDDK(in TObject HKFNIHLBEHC)
	{
		return default(global::JCIAKPCLCHK<TObject, TRpcParam, TRpcReceiver>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
internal static class FCPHMABABIP<TRpcParam, TRpcReceiver> where TRpcReceiver : global::BMAPKMGAHFN<TRpcParam>
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x261ADB0", Offset = "0x261A1B0", VA = "0x18261ADB0")]
	public static global::JCIAKPCLCHK<TObject, TRpcParam, TRpcReceiver> AJMCJLMMDDK<TObject>(in TObject HKFNIHLBEHC)
	{
		return default(global::JCIAKPCLCHK<TObject, TRpcParam, TRpcReceiver>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal struct DJBKFHPPPHH<TSyncField>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public readonly TSyncField HLBKBJGDAAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public readonly global::JNODMCDPIFF<GOGPGCBJKPB> FODFGOPIGNJ;

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x36D7FB0", Offset = "0x36D73B0", VA = "0x1836D7FB0")]
	private DJBKFHPPPHH(in TSyncField AONODCFFDGE, global::JNODMCDPIFF<GOGPGCBJKPB> JDFGPJCFOFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x36D7F00", Offset = "0x36D7300", VA = "0x1836D7F00")]
	public static global::DJBKFHPPPHH<TSyncField> AJMCJLMMDDK(in TSyncField AONODCFFDGE, global::JNODMCDPIFF<GOGPGCBJKPB> JDFGPJCFOFD)
	{
		return default(global::DJBKFHPPPHH<TSyncField>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal static class OHNNAOFEHEA
{
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x27E0B40", Offset = "0x27DFF40", VA = "0x1827E0B40")]
	public static global::DJBKFHPPPHH<TSyncField> AJMCJLMMDDK<TSyncField>(in TSyncField AONODCFFDGE, global::JNODMCDPIFF<GOGPGCBJKPB> JDFGPJCFOFD)
	{
		return default(global::DJBKFHPPPHH<TSyncField>);
	}
}
namespace Cpp2IlInjected;

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
