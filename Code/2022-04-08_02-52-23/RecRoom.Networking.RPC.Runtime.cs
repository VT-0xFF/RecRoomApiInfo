using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface MDBDEPOBDNC
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void RpcAll<T1>(JDDFMEHFIJL.KNNHOABGKOJ<T1> PKGDELDOIFP, T1 BCLHJDPNHFD);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RpcOthers<T1>(JDDFMEHFIJL.KNNHOABGKOJ<T1> PKGDELDOIFP, T1 BCLHJDPNHFD);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RpcMaster<T1>(JDDFMEHFIJL.KNNHOABGKOJ<T1> PKGDELDOIFP, T1 BCLHJDPNHFD);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void RpcAuthority<T1>(JDDFMEHFIJL.KNNHOABGKOJ<T1> PKGDELDOIFP, T1 BCLHJDPNHFD);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void RpcAllBuffered<T1>(AIAHGFFFIPH JGABKCDFKIB, JDDFMEHFIJL.KNNHOABGKOJ<T1> PKGDELDOIFP, T1 BCLHJDPNHFD);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void ClearBufferedRPCs();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum AIAHGFFFIPH
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	AddToRoomCache = 4,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	AddToRoomCacheGlobal
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class JDDFMEHFIJL
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public delegate void IMBEPAFJBOC();

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public delegate void KNNHOABGKOJ<T1>(T1 BCLHJDPNHFD);

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public delegate void HNHKIDFICJG<T1, T2>(T1 BCLHJDPNHFD, T2 LFLINBIAEDG);

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public delegate void KPJJLPJBDNM<T1, T2, T3>(T1 BCLHJDPNHFD, T2 LFLINBIAEDG, T3 IDAEDGFEDDH);

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public delegate void GPKLPHDGAOF<T1, T2, T3, T4>(T1 BCLHJDPNHFD, T2 LFLINBIAEDG, T3 IDAEDGFEDDH, T4 CAFBOOLGFEI);

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public delegate void CAEFEGCGFLG<T1, T2, T3, T4, T5>(T1 BCLHJDPNHFD, T2 LFLINBIAEDG, T3 IDAEDGFEDDH, T4 CAFBOOLGFEI, T5 EPFIOEEGONC);

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public delegate void LPNBJOGDPBE<T1, T2, T3, T4, T5, T6>(T1 BCLHJDPNHFD, T2 LFLINBIAEDG, T3 IDAEDGFEDDH, T4 CAFBOOLGFEI, T5 EPFIOEEGONC, T6 JIEEDGLMBEO);

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public delegate void NCEFLFNGKEK<T1, T2, T3, T4, T5, T6, T7>(T1 BCLHJDPNHFD, T2 LFLINBIAEDG, T3 IDAEDGFEDDH, T4 CAFBOOLGFEI, T5 EPFIOEEGONC, T6 JIEEDGLMBEO, T7 HLMEEPMBMCG);

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public delegate void LIHMEFKCDAG<T1, T2, T3, T4, T5, T6, T7, T8>(T1 BCLHJDPNHFD, T2 LFLINBIAEDG, T3 IDAEDGFEDDH, T4 CAFBOOLGFEI, T5 EPFIOEEGONC, T6 JIEEDGLMBEO, T7 HLMEEPMBMCG, T8 DEEHCECKGDA);

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public delegate void CHDMAFLLOGH<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T1 BCLHJDPNHFD, T2 LFLINBIAEDG, T3 IDAEDGFEDDH, T4 CAFBOOLGFEI, T5 EPFIOEEGONC, T6 JIEEDGLMBEO, T7 HLMEEPMBMCG, T8 DEEHCECKGDA, T9 JPKNJMAKOBK);

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public delegate void OFHPOHAPIKM<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T1 BCLHJDPNHFD, T2 LFLINBIAEDG, T3 IDAEDGFEDDH, T4 CAFBOOLGFEI, T5 EPFIOEEGONC, T6 JIEEDGLMBEO, T7 HLMEEPMBMCG, T8 DEEHCECKGDA, T9 JPKNJMAKOBK, T10 OGHFJLNHPDL);

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public delegate void PGFAJAKGECH<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(T1 BCLHJDPNHFD, T2 LFLINBIAEDG, T3 IDAEDGFEDDH, T4 CAFBOOLGFEI, T5 EPFIOEEGONC, T6 JIEEDGLMBEO, T7 HLMEEPMBMCG, T8 DEEHCECKGDA, T9 JPKNJMAKOBK, T10 OGHFJLNHPDL, T11 EOOEFDCIHGG);

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public delegate void LNDEPBBMKLO<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T1 BCLHJDPNHFD, T2 LFLINBIAEDG, T3 IDAEDGFEDDH, T4 CAFBOOLGFEI, T5 EPFIOEEGONC, T6 JIEEDGLMBEO, T7 HLMEEPMBMCG, T8 DEEHCECKGDA, T9 JPKNJMAKOBK, T10 OGHFJLNHPDL, T11 EOOEFDCIHGG, T12 JBBGBACNEPH);

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public delegate void FPEOHBNPBHJ<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T1 BCLHJDPNHFD, T2 LFLINBIAEDG, T3 IDAEDGFEDDH, T4 CAFBOOLGFEI, T5 EPFIOEEGONC, T6 JIEEDGLMBEO, T7 HLMEEPMBMCG, T8 DEEHCECKGDA, T9 JPKNJMAKOBK, T10 OGHFJLNHPDL, T11 EOOEFDCIHGG, T12 JBBGBACNEPH, T13 CDKIMAEBGMB);

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public delegate void PFBPIAJOOGO<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T1 BCLHJDPNHFD, T2 LFLINBIAEDG, T3 IDAEDGFEDDH, T4 CAFBOOLGFEI, T5 EPFIOEEGONC, T6 JIEEDGLMBEO, T7 HLMEEPMBMCG, T8 DEEHCECKGDA, T9 JPKNJMAKOBK, T10 OGHFJLNHPDL, T11 EOOEFDCIHGG, T12 JBBGBACNEPH, T13 CDKIMAEBGMB, T14 FPKFKIIFOKJ);

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public delegate void EIPOGCABCFO<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T1 BCLHJDPNHFD, T2 LFLINBIAEDG, T3 IDAEDGFEDDH, T4 CAFBOOLGFEI, T5 EPFIOEEGONC, T6 JIEEDGLMBEO, T7 HLMEEPMBMCG, T8 DEEHCECKGDA, T9 JPKNJMAKOBK, T10 OGHFJLNHPDL, T11 EOOEFDCIHGG, T12 JBBGBACNEPH, T13 CDKIMAEBGMB, T14 FPKFKIIFOKJ, T15 FPJKNFEJELE);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct HKCAIMHEBDD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly int LKPBPPMDPLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly IGACHIDFNHM JIANNLLOEAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly int JKJBDGANHAG;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x16EDE10", Offset = "0x16ECC10", VA = "0x1816EDE10")]
	public HKCAIMHEBDD(int LKPBPPMDPLO, IGACHIDFNHM HNFHMMFGJGB, int IKMDNBJDNNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x16EDCD0", Offset = "0x16ECAD0", VA = "0x1816EDCD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface FOBKBNEEOBC
{
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[AttributeUsage(AttributeTargets.Method)]
public class BJOEBJHEMIK : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x522480", Offset = "0x521280", VA = "0x180522480")]
	public BJOEBJHEMIK()
	{
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
