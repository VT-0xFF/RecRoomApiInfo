using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface MPPGNEBLOLP<TObject, TPlayer, TRpcParam, TSyncField, TSyncFieldParam, TSyncFieldValue>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	TPlayer CAFOLMBDNFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KLLPJKELLIA(in TObject FIEDOLNFNLH, in TRpcParam JIGKFMMLBHO);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EGGAAPGMCEI(in TObject FIEDOLNFNLH, in TRpcParam JIGKFMMLBHO);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EKBGGIAHPGB(in TObject FIEDOLNFNLH, in TRpcParam JIGKFMMLBHO);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DMEHNAIEAJF(in TObject FIEDOLNFNLH, in TRpcParam JIGKFMMLBHO);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	TPlayer CJPELNDHGMF(in TObject FIEDOLNFNLH);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool OJEBBMDJDNN(in TObject FIEDOLNFNLH, in TPlayer JLDONLICNFI);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "7")]
	TSyncField MKKIIHMLFCJ(in global::JIJCDEFKIBB<ADJCAKHFMDL> DNNJPGCJGFN, in TObject FIEDOLNFNLH, in TSyncFieldParam JIGKFMMLBHO);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void AECFGMPHHIB(in TSyncField JIGKFMMLBHO);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void LIPLEJHNLCB(in TSyncField OMOCMDDIDHA, in TSyncFieldValue MPHFKGJNMOK);
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000003")]
public readonly struct EIIDBGPEGBB
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000004")]
public readonly struct ADJCAKHFMDL
{
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class KCEOEKIAPNP<TObject, TPlayer, TRpcParam, TRpcReceiver, TSyncField, TSyncFieldParam, TSyncFieldValue, TDeps> : IDisposable, global::APDPNOFPOLB<global::JIJCDEFKIBB<EIIDBGPEGBB>, TPlayer, TRpcParam, TRpcReceiver, global::JIJCDEFKIBB<ADJCAKHFMDL>, TSyncFieldParam, TSyncFieldValue> where TRpcReceiver : global::FAAGOCCAKGC<TRpcParam> where TDeps : global::MPPGNEBLOLP<TObject, TPlayer, TRpcParam, TSyncField, TSyncFieldParam, TSyncFieldValue>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly TDeps OPDJBDGEAJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly global::LPGDOIMMPJG<EIIDBGPEGBB, global::ENMHGAHOECA<TObject, TRpcParam, TRpcReceiver>> PGJFPMNALKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly global::LPGDOIMMPJG<ADJCAKHFMDL, global::FDHEMAFBLGK<TSyncField>> KCFAKOKGMHI;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public TPlayer CAFOLMBDNFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x3F9F860", Offset = "0x3F9DE60", VA = "0x183F9F860", Slot = "5")]
		get
		{
			return (TPlayer)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3F9F2B0", Offset = "0x3F9D8B0", VA = "0x183F9F2B0")]
	public TSyncField DNCBOKCJDDM(global::JIJCDEFKIBB<ADJCAKHFMDL> CGIIFGOPDLK)
	{
		return (TSyncField)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3FA04D0", Offset = "0x3F9EAD0", VA = "0x183FA04D0")]
	protected KCEOEKIAPNP(in TDeps BPGHHPMNGIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2696240", Offset = "0x2694840", VA = "0x182696240")]
	public static global::KCEOEKIAPNP<TObject, TPlayer, TRpcParam, TRpcReceiver, TSyncField, TSyncFieldParam, TSyncFieldValue, TDeps> CIAOGEOFBKG(in TDeps BPGHHPMNGIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3F9F2E0", Offset = "0x3F9D8E0", VA = "0x183F9F2E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3FA02E0", Offset = "0x3F9E8E0", VA = "0x183FA02E0")]
	public global::JIJCDEFKIBB<EIIDBGPEGBB> NKIIBPIDICK(in TObject FIEDOLNFNLH)
	{
		return default(global::JIJCDEFKIBB<EIIDBGPEGBB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x3F9EEF0", Offset = "0x3F9D4F0", VA = "0x183F9EEF0")]
	public void CDANPMFEOKF(in global::JIJCDEFKIBB<EIIDBGPEGBB> FIEDOLNFNLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3F9F5F0", Offset = "0x3F9DBF0", VA = "0x183F9F5F0")]
	public void JHKGIIIALFC(in global::JIJCDEFKIBB<EIIDBGPEGBB> FIEDOLNFNLH, in TRpcParam JIGKFMMLBHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3F9F6B0", Offset = "0x3F9DCB0", VA = "0x183F9F6B0")]
	public void KLLPJKELLIA(in global::JIJCDEFKIBB<EIIDBGPEGBB> FIEDOLNFNLH, in TRpcParam JIGKFMMLBHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3F9F4B0", Offset = "0x3F9DAB0", VA = "0x183F9F4B0")]
	public void EGGAAPGMCEI(in global::JIJCDEFKIBB<EIIDBGPEGBB> FIEDOLNFNLH, in TRpcParam JIGKFMMLBHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3F9F550", Offset = "0x3F9DB50", VA = "0x183F9F550")]
	public void EKBGGIAHPGB(in global::JIJCDEFKIBB<EIIDBGPEGBB> FIEDOLNFNLH, in TRpcParam JIGKFMMLBHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3F9F210", Offset = "0x3F9D810", VA = "0x183F9F210")]
	public void DMEHNAIEAJF(in global::JIJCDEFKIBB<EIIDBGPEGBB> FIEDOLNFNLH, in TRpcParam JIGKFMMLBHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3FA0480", Offset = "0x3F9EA80", VA = "0x183FA0480")]
	public void PEGLFJKHLDO(in global::JIJCDEFKIBB<EIIDBGPEGBB> FIEDOLNFNLH, in TRpcReceiver OPNHBKMFANE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3F9F110", Offset = "0x3F9D710", VA = "0x183F9F110")]
	public TPlayer CJPELNDHGMF(in global::JIJCDEFKIBB<EIIDBGPEGBB> FIEDOLNFNLH)
	{
		return (TPlayer)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3FA0380", Offset = "0x3F9E980", VA = "0x183FA0380")]
	public bool OJEBBMDJDNN(in global::JIJCDEFKIBB<EIIDBGPEGBB> FIEDOLNFNLH, in TPlayer JLDONLICNFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3F9FC40", Offset = "0x3F9E240", VA = "0x183F9FC40")]
	public global::JIJCDEFKIBB<ADJCAKHFMDL> MKKIIHMLFCJ(in global::JIJCDEFKIBB<EIIDBGPEGBB> FIEDOLNFNLH, in TSyncFieldParam JIGKFMMLBHO)
	{
		return default(global::JIJCDEFKIBB<ADJCAKHFMDL>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3F9EAF0", Offset = "0x3F9D0F0", VA = "0x183F9EAF0")]
	public void AECFGMPHHIB(in global::JIJCDEFKIBB<ADJCAKHFMDL> JPBBMMPGOHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3F9ECE0", Offset = "0x3F9D2E0", VA = "0x183F9ECE0")]
	public void BCAIIKHABBD(in global::JIJCDEFKIBB<ADJCAKHFMDL> OMOCMDDIDHA, in TSyncFieldValue MPHFKGJNMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x34A7FD0", Offset = "0x34A65D0", VA = "0x1834A7FD0", Slot = "6")]
	private void GLHIHIKPLGH(in global::JIJCDEFKIBB<EIIDBGPEGBB> FIEDOLNFNLH, in TRpcParam JIGKFMMLBHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x3F9EC10", Offset = "0x3F9D210", VA = "0x183F9EC10", Slot = "7")]
	private void AOIFMPFDLHO(in global::JIJCDEFKIBB<EIIDBGPEGBB> FIEDOLNFNLH, in TRpcParam JIGKFMMLBHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x34A8B80", Offset = "0x34A7180", VA = "0x1834A8B80", Slot = "8")]
	private void MEHGHIJBMBF(in global::JIJCDEFKIBB<EIIDBGPEGBB> FIEDOLNFNLH, in TRpcParam JIGKFMMLBHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x34A8520", Offset = "0x34A6B20", VA = "0x1834A8520", Slot = "9")]
	private void MPNAOFIBHGI(in global::JIJCDEFKIBB<EIIDBGPEGBB> FIEDOLNFNLH, in TRpcParam JIGKFMMLBHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x3FA0350", Offset = "0x3F9E950", VA = "0x183FA0350", Slot = "10")]
	private void OGKDGMGMOEC(in global::JIJCDEFKIBB<EIIDBGPEGBB> FIEDOLNFNLH, in TRpcReceiver OPNHBKMFANE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x3F9F680", Offset = "0x3F9DC80", VA = "0x183F9F680", Slot = "11")]
	private TPlayer KHNCAHBMFOB(in global::JIJCDEFKIBB<EIIDBGPEGBB> FIEDOLNFNLH)
	{
		return (TPlayer)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x34A8450", Offset = "0x34A6A50", VA = "0x1834A8450", Slot = "12")]
	private bool PEBJFPKBAJB(in global::JIJCDEFKIBB<EIIDBGPEGBB> FIEDOLNFNLH, in TPlayer JLDONLICNFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3F9F750", Offset = "0x3F9DD50", VA = "0x183F9F750", Slot = "13")]
	private global::JIJCDEFKIBB<ADJCAKHFMDL> KPOBJHIGPGN(in global::JIJCDEFKIBB<EIIDBGPEGBB> FIEDOLNFNLH, in TSyncFieldParam JIGKFMMLBHO)
	{
		return default(global::JIJCDEFKIBB<ADJCAKHFMDL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x2F3C0B0", Offset = "0x2F3A6B0", VA = "0x182F3C0B0", Slot = "14")]
	private void BNPELALLNPO(in global::JIJCDEFKIBB<ADJCAKHFMDL> OMOCMDDIDHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3F9F780", Offset = "0x3F9DD80", VA = "0x183F9F780", Slot = "15")]
	private void LKHPDBGMLED(in global::JIJCDEFKIBB<ADJCAKHFMDL> OMOCMDDIDHA, in TSyncFieldValue MPHFKGJNMOK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal struct ENMHGAHOECA<TObject, TRpcParam, TRpcReceiver> where TRpcReceiver : global::FAAGOCCAKGC<TRpcParam>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly HashSet<global::JIJCDEFKIBB<ADJCAKHFMDL>> NACIIJNHKOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly TObject OOIKPMDBHHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public TRpcReceiver DKEMMNPDPOE;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x38CE5A0", Offset = "0x38CCBA0", VA = "0x1838CE5A0")]
	private ENMHGAHOECA(HashSet<global::JIJCDEFKIBB<ADJCAKHFMDL>> OIMFKDIPMHJ, in TObject FIEDOLNFNLH, in TRpcReceiver OPNHBKMFANE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x38CE4C0", Offset = "0x38CCAC0", VA = "0x1838CE4C0")]
	public static global::ENMHGAHOECA<TObject, TRpcParam, TRpcReceiver> CIAOGEOFBKG(in TObject FIEDOLNFNLH)
	{
		return default(global::ENMHGAHOECA<TObject, TRpcParam, TRpcReceiver>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
internal static class PCPMFFDAOLN<TRpcParam, TRpcReceiver> where TRpcReceiver : global::FAAGOCCAKGC<TRpcParam>
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x259E9E0", Offset = "0x259CFE0", VA = "0x18259E9E0")]
	public static global::ENMHGAHOECA<TObject, TRpcParam, TRpcReceiver> CIAOGEOFBKG<TObject>(in TObject FIEDOLNFNLH)
	{
		return default(global::ENMHGAHOECA<TObject, TRpcParam, TRpcReceiver>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
internal struct FDHEMAFBLGK<TSyncField>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public readonly TSyncField OJGCOANPPAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public readonly global::JIJCDEFKIBB<EIIDBGPEGBB> OENJDNKCNPN;

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x296D4F0", Offset = "0x296BAF0", VA = "0x18296D4F0")]
	private FDHEMAFBLGK(in TSyncField CGIIFGOPDLK, in global::JIJCDEFKIBB<EIIDBGPEGBB> KNDBJPIOPAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x296D460", Offset = "0x296BA60", VA = "0x18296D460")]
	public static global::FDHEMAFBLGK<TSyncField> CIAOGEOFBKG(in TSyncField CGIIFGOPDLK, global::JIJCDEFKIBB<EIIDBGPEGBB> KNDBJPIOPAJ)
	{
		return default(global::FDHEMAFBLGK<TSyncField>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal static class EMFGNHLNHIB
{
	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x258ABC0", Offset = "0x25891C0", VA = "0x18258ABC0")]
	public static global::FDHEMAFBLGK<TSyncField> CIAOGEOFBKG<TSyncField>(in TSyncField CGIIFGOPDLK, global::JIJCDEFKIBB<EIIDBGPEGBB> KNDBJPIOPAJ)
	{
		return default(global::FDHEMAFBLGK<TSyncField>);
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
