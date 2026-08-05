using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class LFAPOBMIELM
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public delegate void DADNJGHJMCJ<TType>(in TType LIJLAEFJGCI);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface BEPEKCKENBL<TInputKey, TOutputKey, TEdgeKey, TNodeKey, TInput, TOutput, TEdge, TNode, TEdgeKeys>
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TInput KKBCFGFANJP(in TInputKey OMJCAEHDFPF);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	TOutput ODOENPICLFA(in TOutputKey JOFOIKJBMMG);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "2")]
	TEdge HCIHDMOPFGN(in TEdgeKey GABIOLOOBKM);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "3")]
	TNode ICFGIPJBIOD(in TNodeKey ICKBAEIJPFG);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "4")]
	TNodeKey LBECHJFHAPF(in TInput GLJCPDEKKCL);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	TEdgeKeys KHOOANIPFFP(in TInput GLJCPDEKKCL);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	TNodeKey LBECHJFHAPF(in TOutput JMIGDAADKLB);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "7")]
	TEdgeKeys KHOOANIPFFP(in TOutput JMIGDAADKLB);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	TOutputKey PPMJLNGOFOH(in TEdge LDHFHHPCLNO);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "9")]
	TInputKey FNPFOGLFCHN(in TEdge LDHFHHPCLNO);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "10")]
	int OHEALIHCDNB(in TNode PKMOGGONLGF);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "11")]
	int LEAKGPMNJIN(in TNode PKMOGGONLGF);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "12")]
	TInputKey AFGOOPEAFFH(in TNode PKMOGGONLGF, int HIANDEDCLIF);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "13")]
	TOutputKey LPOCCFENKKA(in TNode PKMOGGONLGF, int HIANDEDCLIF);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface CDOPNHGGOBN<TAction, TResult, TActionReceiver>
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TResult OFGPNGKADPN(in TAction KINCGCMCJLI, bool LGDLENHLBCH);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface GADGCLGHLPK<TAction, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TResult OBDJFAIFOBI(in TAction KINCGCMCJLI);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "1")]
	TAction DALDHNOKHAM();
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface NHNMBABLBPJ<TErrType, TTypeParamRef, TTypeApp, TType, TDirectedType, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TDirectedType NDILMPIDACE(in TRoot IFKKFCHLHMM, in TDirectedType HNGAIMDNIHA, in TDirectedType ENOBOONFLBG);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "1")]
	TErrType HEINJBHECAF();

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "2")]
	string OCGLNLPHEPA(in TTypeParamRef LIJLAEFJGCI);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "3")]
	TType CADBGEHHBLN(in TTypeApp LIJLAEFJGCI);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool MNCMFICJNIJ(in TType LIJLAEFJGCI);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	TTypeApp OPMLMJCKBDI(in TType LIJLAEFJGCI, List<TType> GICOGMGJPLB);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void DOOIFDFPAME(in TType LIJLAEFJGCI, LFAPOBMIELM.DADNJGHJMCJ<TType> GPKMDBFFKAN, LFAPOBMIELM.DADNJGHJMCJ<TTypeParamRef> DANMPFFOEBC, LFAPOBMIELM.DADNJGHJMCJ<TTypeApp> KNDLKOLNFKL, LFAPOBMIELM.DADNJGHJMCJ<TTypeApp> BGLACGCBJGP);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface BDAPBEDKAGF<TTermKey, TResult, TInputTerm, TOutputTerm, TOutputSubstitution, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TTermKey CIJJICOPHDK();

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	TInputTerm IAJKHELBMDO(in TInputTerm GJJHHCKBLGD, in TInputTerm HHCNFMAKKIK);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	TInputTerm AOMGLDFCOOG(in TTermKey BHKOFHBEHLJ);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NDAGODNMAEN(in TInputTerm EHGLDEHJCJA, in TInputTerm POGMGOCOOHC);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "4")]
	TResult NMBFFHIHKOH(in TRoot IFKKFCHLHMM);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "5")]
	TOutputTerm LJAAAPJANCD(in TTermKey BHKOFHBEHLJ);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool MFIMMNHHFPL(in TOutputTerm PPODBDKHIEI);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool EKLEHAADBNC(in TOutputTerm PPODBDKHIEI);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "8")]
	TTermKey OJNJJOHBEIF(in TOutputTerm PPODBDKHIEI);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "9")]
	TOutputTerm PJAFGICMPAJ(in TOutputTerm PPODBDKHIEI);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "10")]
	TOutputTerm KLFHGBPDFCM(in TOutputTerm PPODBDKHIEI);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "11")]
	TTermKey GDAKEOLBAMN(in TOutputSubstitution EKHGDIGDKMJ);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "12")]
	TOutputTerm MCKIBAMOJBC(in TOutputSubstitution EKHGDIGDKMJ);
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
