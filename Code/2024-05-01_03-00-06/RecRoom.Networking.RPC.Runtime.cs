using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface HBMCCDIIOFI
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void RpcAll<T1>(DIGKNKELKBD.KLAJCADHDFC<T1> JBMNJPFPMLM, T1 LJPBHANJJKC);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RpcPlayer<T1>(CMFDBPHCNJN HKNKALEJLDA, DIGKNKELKBD.KLAJCADHDFC<T1> JBMNJPFPMLM, T1 LJPBHANJJKC);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RpcPlayer<T1, T2>(CMFDBPHCNJN HKNKALEJLDA, DIGKNKELKBD.FCAGOLAKHIE<T1, T2> JBMNJPFPMLM, T1 LJPBHANJJKC, T2 HHFOKEOPICI);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void RpcPlayer<T1, T2, T3>(CMFDBPHCNJN HKNKALEJLDA, DIGKNKELKBD.DGDKFGCOGDG<T1, T2, T3> JBMNJPFPMLM, T1 LJPBHANJJKC, T2 HHFOKEOPICI, T3 PIDNJANGDDD);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void RpcPlayer<T1, T2>(CMFDBPHCNJN HKNKALEJLDA, DIGKNKELKBD.DGDKFGCOGDG<T1, T2, DFAHIKCJGKG> JBMNJPFPMLM, T1 LJPBHANJJKC, T2 HHFOKEOPICI);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void RpcPlayer<T1, T2, T3>(CMFDBPHCNJN HKNKALEJLDA, DIGKNKELKBD.AILLHMANADG<T1, T2, T3, DFAHIKCJGKG> JBMNJPFPMLM, T1 LJPBHANJJKC, T2 HHFOKEOPICI, T3 PIDNJANGDDD);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum KLCBNMJLOPE
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	AddToRoomCache = 4,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	AddToRoomCacheGlobal
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class DIGKNKELKBD
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public delegate void BFCEOJEOGDE();

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public delegate void KLAJCADHDFC<T1>(T1 LJPBHANJJKC);

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public delegate void FCAGOLAKHIE<T1, T2>(T1 LJPBHANJJKC, T2 HHFOKEOPICI);

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public delegate void DGDKFGCOGDG<T1, T2, T3>(T1 LJPBHANJJKC, T2 HHFOKEOPICI, T3 PIDNJANGDDD);

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public delegate void AILLHMANADG<T1, T2, T3, T4>(T1 LJPBHANJJKC, T2 HHFOKEOPICI, T3 PIDNJANGDDD, T4 OCCKLIBEGOA);

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public delegate void HBCNLOKNAPB<T1, T2, T3, T4, T5>(T1 LJPBHANJJKC, T2 HHFOKEOPICI, T3 PIDNJANGDDD, T4 OCCKLIBEGOA, T5 BHHLADIDOIK);

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public delegate void EPDECEFAKCC<T1, T2, T3, T4, T5, T6>(T1 LJPBHANJJKC, T2 HHFOKEOPICI, T3 PIDNJANGDDD, T4 OCCKLIBEGOA, T5 BHHLADIDOIK, T6 FKEEKLKJFAA);

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public delegate void CDINDBBCFCI<T1, T2, T3, T4, T5, T6, T7>(T1 LJPBHANJJKC, T2 HHFOKEOPICI, T3 PIDNJANGDDD, T4 OCCKLIBEGOA, T5 BHHLADIDOIK, T6 FKEEKLKJFAA, T7 MKOJEILBMFM);

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public delegate void HMCMLIDMIDG<T1, T2, T3, T4, T5, T6, T7, T8>(T1 LJPBHANJJKC, T2 HHFOKEOPICI, T3 PIDNJANGDDD, T4 OCCKLIBEGOA, T5 BHHLADIDOIK, T6 FKEEKLKJFAA, T7 MKOJEILBMFM, T8 OCGLONPFLML);

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public delegate void PDPOODPIOKA<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T1 LJPBHANJJKC, T2 HHFOKEOPICI, T3 PIDNJANGDDD, T4 OCCKLIBEGOA, T5 BHHLADIDOIK, T6 FKEEKLKJFAA, T7 MKOJEILBMFM, T8 OCGLONPFLML, T9 BIJHGKGOKFC);

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public delegate void FFCPIHKCAFB<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T1 LJPBHANJJKC, T2 HHFOKEOPICI, T3 PIDNJANGDDD, T4 OCCKLIBEGOA, T5 BHHLADIDOIK, T6 FKEEKLKJFAA, T7 MKOJEILBMFM, T8 OCGLONPFLML, T9 BIJHGKGOKFC, T10 NLINEJJHNLA);

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public delegate void IMBJAMFLKDB<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(T1 LJPBHANJJKC, T2 HHFOKEOPICI, T3 PIDNJANGDDD, T4 OCCKLIBEGOA, T5 BHHLADIDOIK, T6 FKEEKLKJFAA, T7 MKOJEILBMFM, T8 OCGLONPFLML, T9 BIJHGKGOKFC, T10 NLINEJJHNLA, T11 HFDALBGHGJG);

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public delegate void JOLDAPKBIAJ<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T1 LJPBHANJJKC, T2 HHFOKEOPICI, T3 PIDNJANGDDD, T4 OCCKLIBEGOA, T5 BHHLADIDOIK, T6 FKEEKLKJFAA, T7 MKOJEILBMFM, T8 OCGLONPFLML, T9 BIJHGKGOKFC, T10 NLINEJJHNLA, T11 HFDALBGHGJG, T12 NBNHKEDMPJJ);

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public delegate void AOFGJGOCGOI<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T1 LJPBHANJJKC, T2 HHFOKEOPICI, T3 PIDNJANGDDD, T4 OCCKLIBEGOA, T5 BHHLADIDOIK, T6 FKEEKLKJFAA, T7 MKOJEILBMFM, T8 OCGLONPFLML, T9 BIJHGKGOKFC, T10 NLINEJJHNLA, T11 HFDALBGHGJG, T12 NBNHKEDMPJJ, T13 JMHFIKPOAEC);

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public delegate void CGLKJJJHKIJ<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T1 LJPBHANJJKC, T2 HHFOKEOPICI, T3 PIDNJANGDDD, T4 OCCKLIBEGOA, T5 BHHLADIDOIK, T6 FKEEKLKJFAA, T7 MKOJEILBMFM, T8 OCGLONPFLML, T9 BIJHGKGOKFC, T10 NLINEJJHNLA, T11 HFDALBGHGJG, T12 NBNHKEDMPJJ, T13 JMHFIKPOAEC, T14 GMMMAHGPPDO);

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public delegate void LIMFADACPPG<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T1 LJPBHANJJKC, T2 HHFOKEOPICI, T3 PIDNJANGDDD, T4 OCCKLIBEGOA, T5 BHHLADIDOIK, T6 FKEEKLKJFAA, T7 MKOJEILBMFM, T8 OCGLONPFLML, T9 BIJHGKGOKFC, T10 NLINEJJHNLA, T11 HFDALBGHGJG, T12 NBNHKEDMPJJ, T13 JMHFIKPOAEC, T14 GMMMAHGPPDO, T15 BHCICMDPOEE);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct DFAHIKCJGKG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly int CPEPOKDGNPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly CMFDBPHCNJN PJCOLEGBPLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly int DGCPMFJDPMM;

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x62BB200", Offset = "0x62BA000", VA = "0x1862BB200")]
	public DFAHIKCJGKG(int CPEPOKDGNPA, CMFDBPHCNJN MJBACBKGPMA, int ECAJDMFACLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x62BB090", Offset = "0x62B9E90", VA = "0x1862BB090", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface GIEKEOBDNPO
{
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
public class LILBKIHIKPP : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7D9A20", Offset = "0x7D8820", VA = "0x1807D9A20")]
	public LILBKIHIKPP()
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
