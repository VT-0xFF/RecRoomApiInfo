using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface FPGCIOACICG<TObject, TPlayer, TRpcParam, TSyncField, TSyncFieldParam, TSyncFieldValue>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	TPlayer ENAGEIMBPEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PNELDOJOKFG(in TObject ANFJLMLDELH, in TRpcParam DDBPFEGDPNC);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EABMOAIDLAI(in TObject ANFJLMLDELH, in TRpcParam DDBPFEGDPNC);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GBLOMGDHMMN(in TObject ANFJLMLDELH, in TRpcParam DDBPFEGDPNC);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KIDNMGLGNCP(in TObject ANFJLMLDELH, in TRpcParam DDBPFEGDPNC);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	TPlayer JEKFMICIIPK(in TObject ANFJLMLDELH);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool PCKDLIOAECE(in TObject ANFJLMLDELH, in TPlayer EBFMKAPODJN);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "7")]
	TSyncField PIFEIMNAGPD(in global::PJGCMECOCNN<FIDBCDPFCLA> KMDPOACIOBM, in TObject ANFJLMLDELH, in TSyncFieldParam DDBPFEGDPNC);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void GMDFHEKBFII(in TSyncField DDBPFEGDPNC);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void MIMMIGIBAKJ(in TSyncField ONCOGECNGKK, in TSyncFieldValue LDPMPDNIHLJ);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public sealed class FEGFALOKCMC
{
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public sealed class FIDBCDPFCLA
{
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class DOIBNMEDNJG<TObject, TPlayer, TRpcParam, TRpcReceiver, TSyncField, TSyncFieldParam, TSyncFieldValue, TDeps> : IDisposable, global::GLEFDEAKPCI<global::PJGCMECOCNN<FEGFALOKCMC>, TPlayer, TRpcParam, TRpcReceiver, global::PJGCMECOCNN<FIDBCDPFCLA>, TSyncFieldParam, TSyncFieldValue> where TRpcReceiver : global::HABICOHCBPA<TRpcParam> where TDeps : global::FPGCIOACICG<TObject, TPlayer, TRpcParam, TSyncField, TSyncFieldParam, TSyncFieldValue>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly TDeps DFGLAINKKLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly global::ACCDFHPGBAI<FEGFALOKCMC, global::BNNPNNPMKPO<TObject, TRpcParam, TRpcReceiver>> JFMFBJACIIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly global::ACCDFHPGBAI<FIDBCDPFCLA, global::GGIEDBLCJEA<TSyncField>> CFEJIDHKJPO;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public TPlayer ENAGEIMBPEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x3A851F0", Offset = "0x3A843F0", VA = "0x183A851F0", Slot = "5")]
		get
		{
			return (TPlayer)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3A85680", Offset = "0x3A84880", VA = "0x183A85680")]
	public TSyncField IAPDNNGOBDI(global::PJGCMECOCNN<FIDBCDPFCLA> JDFCCDMGKAH)
	{
		return (TSyncField)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3A86A90", Offset = "0x3A85C90", VA = "0x183A86A90")]
	protected DOIBNMEDNJG(in TDeps GGHABHHMKFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3A85DA0", Offset = "0x3A84FA0", VA = "0x183A85DA0")]
	public static global::DOIBNMEDNJG<TObject, TPlayer, TRpcParam, TRpcReceiver, TSyncField, TSyncFieldParam, TSyncFieldValue, TDeps> NPLCOEOMBMO(in TDeps GGHABHHMKFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3A84B70", Offset = "0x3A83D70", VA = "0x183A84B70", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3A85CF0", Offset = "0x3A84EF0", VA = "0x183A85CF0")]
	public global::PJGCMECOCNN<FEGFALOKCMC> NHIHPFCHHMO(in TObject ANFJLMLDELH)
	{
		return default(global::PJGCMECOCNN<FEGFALOKCMC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x3A856E0", Offset = "0x3A848E0", VA = "0x183A856E0")]
	public void IPKPBLMJMFN(in global::PJGCMECOCNN<FEGFALOKCMC> ANFJLMLDELH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3A85BB0", Offset = "0x3A84DB0", VA = "0x183A85BB0")]
	public void LMKCFMOODBK(in global::PJGCMECOCNN<FEGFALOKCMC> ANFJLMLDELH, in TRpcParam DDBPFEGDPNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3A869F0", Offset = "0x3A85BF0", VA = "0x183A869F0")]
	public void PNELDOJOKFG(in global::PJGCMECOCNN<FEGFALOKCMC> ANFJLMLDELH, in TRpcParam DDBPFEGDPNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3A85150", Offset = "0x3A84350", VA = "0x183A85150")]
	public void EABMOAIDLAI(in global::PJGCMECOCNN<FEGFALOKCMC> ANFJLMLDELH, in TRpcParam DDBPFEGDPNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3A85250", Offset = "0x3A84450", VA = "0x183A85250")]
	public void GBLOMGDHMMN(in global::PJGCMECOCNN<FEGFALOKCMC> ANFJLMLDELH, in TRpcParam DDBPFEGDPNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3A85B10", Offset = "0x3A84D10", VA = "0x183A85B10")]
	public void KIDNMGLGNCP(in global::PJGCMECOCNN<FEGFALOKCMC> ANFJLMLDELH, in TRpcParam DDBPFEGDPNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3A85C70", Offset = "0x3A84E70", VA = "0x183A85C70")]
	public void MKCCPPCANNA(in global::PJGCMECOCNN<FEGFALOKCMC> ANFJLMLDELH, in TRpcReceiver HCHBIEKGJOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3A85A10", Offset = "0x3A84C10", VA = "0x183A85A10")]
	public TPlayer JEKFMICIIPK(in global::PJGCMECOCNN<FEGFALOKCMC> ANFJLMLDELH)
	{
		return (TPlayer)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3A85ED0", Offset = "0x3A850D0", VA = "0x183A85ED0")]
	public bool PCKDLIOAECE(in global::PJGCMECOCNN<FEGFALOKCMC> ANFJLMLDELH, in TPlayer EBFMKAPODJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3A862F0", Offset = "0x3A854F0", VA = "0x183A862F0")]
	public global::PJGCMECOCNN<FIDBCDPFCLA> PIFEIMNAGPD(in global::PJGCMECOCNN<FEGFALOKCMC> ANFJLMLDELH, in TSyncFieldParam DDBPFEGDPNC)
	{
		return default(global::PJGCMECOCNN<FIDBCDPFCLA>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3A85530", Offset = "0x3A84730", VA = "0x183A85530")]
	public void GMDFHEKBFII(in global::PJGCMECOCNN<FIDBCDPFCLA> HOGOAGECHBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3A84780", Offset = "0x3A83980", VA = "0x183A84780")]
	public void CGLPHIPLBDF(in global::PJGCMECOCNN<FIDBCDPFCLA> ONCOGECNGKK, in TSyncFieldValue LDPMPDNIHLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3A85EA0", Offset = "0x3A850A0", VA = "0x183A85EA0", Slot = "6")]
	private void OOCJEPOJAMO(in global::PJGCMECOCNN<FEGFALOKCMC> ANFJLMLDELH, in TRpcParam DDBPFEGDPNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x3A84680", Offset = "0x3A83880", VA = "0x183A84680", Slot = "7")]
	private void AOPCKLHCAKJ(in global::PJGCMECOCNN<FEGFALOKCMC> ANFJLMLDELH, in TRpcParam DDBPFEGDPNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3A85650", Offset = "0x3A84850", VA = "0x183A85650", Slot = "8")]
	private void HPPKDHBBEAC(in global::PJGCMECOCNN<FEGFALOKCMC> ANFJLMLDELH, in TRpcParam DDBPFEGDPNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3A85C40", Offset = "0x3A84E40", VA = "0x183A85C40", Slot = "9")]
	private void LPDGIDKIHBD(in global::PJGCMECOCNN<FEGFALOKCMC> ANFJLMLDELH, in TRpcParam DDBPFEGDPNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x3A85CC0", Offset = "0x3A84EC0", VA = "0x183A85CC0", Slot = "10")]
	private void NEJPOOIKDDH(in global::PJGCMECOCNN<FEGFALOKCMC> ANFJLMLDELH, in TRpcReceiver HCHBIEKGJOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x3A856B0", Offset = "0x3A848B0", VA = "0x183A856B0", Slot = "11")]
	private TPlayer ILNIHNOHOAO(in global::PJGCMECOCNN<FEGFALOKCMC> ANFJLMLDELH)
	{
		return (TPlayer)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3A85E70", Offset = "0x3A85070", VA = "0x183A85E70", Slot = "12")]
	private bool OJKGBHPAONH(in global::PJGCMECOCNN<FEGFALOKCMC> ANFJLMLDELH, in TPlayer EBFMKAPODJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3A846B0", Offset = "0x3A838B0", VA = "0x183A846B0", Slot = "13")]
	private global::PJGCMECOCNN<FIDBCDPFCLA> BMMCDNIAGAK(in global::PJGCMECOCNN<FEGFALOKCMC> ANFJLMLDELH, in TSyncFieldParam DDBPFEGDPNC)
	{
		return default(global::PJGCMECOCNN<FIDBCDPFCLA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x29674A0", Offset = "0x29666A0", VA = "0x1829674A0", Slot = "14")]
	private void MELBKEFIPJL(in global::PJGCMECOCNN<FIDBCDPFCLA> ONCOGECNGKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3A85D70", Offset = "0x3A84F70", VA = "0x183A85D70", Slot = "15")]
	private void NKBNOEMDBIA(in global::PJGCMECOCNN<FIDBCDPFCLA> ONCOGECNGKK, in TSyncFieldValue LDPMPDNIHLJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal struct BNNPNNPMKPO<TObject, TRpcParam, TRpcReceiver> where TRpcReceiver : global::HABICOHCBPA<TRpcParam>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly HashSet<global::PJGCMECOCNN<FIDBCDPFCLA>> EEAHPFJKGLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly TObject IMAPOECGKCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public TRpcReceiver EGMKFHBONLA;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x40BE8A0", Offset = "0x40BDAA0", VA = "0x1840BE8A0")]
	private BNNPNNPMKPO(HashSet<global::PJGCMECOCNN<FIDBCDPFCLA>> LAEDCIGDDNN, in TObject ANFJLMLDELH, in TRpcReceiver HCHBIEKGJOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x40BE680", Offset = "0x40BD880", VA = "0x1840BE680")]
	public static global::BNNPNNPMKPO<TObject, TRpcParam, TRpcReceiver> NPLCOEOMBMO(in TObject ANFJLMLDELH)
	{
		return default(global::BNNPNNPMKPO<TObject, TRpcParam, TRpcReceiver>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
internal static class PPIMNEKHCIA<TRpcParam, TRpcReceiver> where TRpcReceiver : global::HABICOHCBPA<TRpcParam>
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x2D14D60", Offset = "0x2D13F60", VA = "0x182D14D60")]
	public static global::BNNPNNPMKPO<TObject, TRpcParam, TRpcReceiver> NPLCOEOMBMO<TObject>(in TObject ANFJLMLDELH)
	{
		return default(global::BNNPNNPMKPO<TObject, TRpcParam, TRpcReceiver>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
internal struct GGIEDBLCJEA<TSyncField>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public readonly TSyncField HLKGNAGJHKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public readonly global::PJGCMECOCNN<FEGFALOKCMC> LBHCHCKANFB;

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x1E515B0", Offset = "0x1E507B0", VA = "0x181E515B0")]
	private GGIEDBLCJEA(in TSyncField JDFCCDMGKAH, in global::PJGCMECOCNN<FEGFALOKCMC> DLECMGPKCJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x1E51480", Offset = "0x1E50680", VA = "0x181E51480")]
	public static global::GGIEDBLCJEA<TSyncField> NPLCOEOMBMO(in TSyncField JDFCCDMGKAH, in global::PJGCMECOCNN<FEGFALOKCMC> DLECMGPKCJI)
	{
		return default(global::GGIEDBLCJEA<TSyncField>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal static class BFKBLAJGIEA
{
	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2089680", Offset = "0x2088880", VA = "0x182089680")]
	public static global::GGIEDBLCJEA<TSyncField> NPLCOEOMBMO<TSyncField>(in TSyncField JDFCCDMGKAH, in global::PJGCMECOCNN<FEGFALOKCMC> DLECMGPKCJI)
	{
		return default(global::GGIEDBLCJEA<TSyncField>);
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
