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
		[Cpp2IlInjected.Address(RVA = "0x3D42650", Offset = "0x3D41650", VA = "0x183D42650", Slot = "5")]
		get
		{
			return (TPlayer)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3D420A0", Offset = "0x3D410A0", VA = "0x183D420A0")]
	public TSyncField DNCBOKCJDDM(global::JIJCDEFKIBB<ADJCAKHFMDL> CGIIFGOPDLK)
	{
		return (TSyncField)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3D432C0", Offset = "0x3D422C0", VA = "0x183D432C0")]
	protected KCEOEKIAPNP(in TDeps BPGHHPMNGIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x389D2B0", Offset = "0x389C2B0", VA = "0x18389D2B0")]
	public static global::KCEOEKIAPNP<TObject, TPlayer, TRpcParam, TRpcReceiver, TSyncField, TSyncFieldParam, TSyncFieldValue, TDeps> CIAOGEOFBKG(in TDeps BPGHHPMNGIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3D420D0", Offset = "0x3D410D0", VA = "0x183D420D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3D430D0", Offset = "0x3D420D0", VA = "0x183D430D0")]
	public global::JIJCDEFKIBB<EIIDBGPEGBB> NKIIBPIDICK(in TObject FIEDOLNFNLH)
	{
		return default(global::JIJCDEFKIBB<EIIDBGPEGBB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x3D41CE0", Offset = "0x3D40CE0", VA = "0x183D41CE0")]
	public void CDANPMFEOKF(in global::JIJCDEFKIBB<EIIDBGPEGBB> FIEDOLNFNLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3D423E0", Offset = "0x3D413E0", VA = "0x183D423E0")]
	public void JHKGIIIALFC(in global::JIJCDEFKIBB<EIIDBGPEGBB> FIEDOLNFNLH, in TRpcParam JIGKFMMLBHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3D424A0", Offset = "0x3D414A0", VA = "0x183D424A0")]
	public void KLLPJKELLIA(in global::JIJCDEFKIBB<EIIDBGPEGBB> FIEDOLNFNLH, in TRpcParam JIGKFMMLBHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3D422A0", Offset = "0x3D412A0", VA = "0x183D422A0")]
	public void EGGAAPGMCEI(in global::JIJCDEFKIBB<EIIDBGPEGBB> FIEDOLNFNLH, in TRpcParam JIGKFMMLBHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3D42340", Offset = "0x3D41340", VA = "0x183D42340")]
	public void EKBGGIAHPGB(in global::JIJCDEFKIBB<EIIDBGPEGBB> FIEDOLNFNLH, in TRpcParam JIGKFMMLBHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3D42000", Offset = "0x3D41000", VA = "0x183D42000")]
	public void DMEHNAIEAJF(in global::JIJCDEFKIBB<EIIDBGPEGBB> FIEDOLNFNLH, in TRpcParam JIGKFMMLBHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3D43270", Offset = "0x3D42270", VA = "0x183D43270")]
	public void PEGLFJKHLDO(in global::JIJCDEFKIBB<EIIDBGPEGBB> FIEDOLNFNLH, in TRpcReceiver OPNHBKMFANE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3D41F00", Offset = "0x3D40F00", VA = "0x183D41F00")]
	public TPlayer CJPELNDHGMF(in global::JIJCDEFKIBB<EIIDBGPEGBB> FIEDOLNFNLH)
	{
		return (TPlayer)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3D43170", Offset = "0x3D42170", VA = "0x183D43170")]
	public bool OJEBBMDJDNN(in global::JIJCDEFKIBB<EIIDBGPEGBB> FIEDOLNFNLH, in TPlayer JLDONLICNFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3D42A30", Offset = "0x3D41A30", VA = "0x183D42A30")]
	public global::JIJCDEFKIBB<ADJCAKHFMDL> MKKIIHMLFCJ(in global::JIJCDEFKIBB<EIIDBGPEGBB> FIEDOLNFNLH, in TSyncFieldParam JIGKFMMLBHO)
	{
		return default(global::JIJCDEFKIBB<ADJCAKHFMDL>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3D418E0", Offset = "0x3D408E0", VA = "0x183D418E0")]
	public void AECFGMPHHIB(in global::JIJCDEFKIBB<ADJCAKHFMDL> JPBBMMPGOHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3D41AD0", Offset = "0x3D40AD0", VA = "0x183D41AD0")]
	public void BCAIIKHABBD(in global::JIJCDEFKIBB<ADJCAKHFMDL> OMOCMDDIDHA, in TSyncFieldValue MPHFKGJNMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3A05CF0", Offset = "0x3A04CF0", VA = "0x183A05CF0", Slot = "6")]
	private void GLHIHIKPLGH(in global::JIJCDEFKIBB<EIIDBGPEGBB> FIEDOLNFNLH, in TRpcParam JIGKFMMLBHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x3D41A00", Offset = "0x3D40A00", VA = "0x183D41A00", Slot = "7")]
	private void AOIFMPFDLHO(in global::JIJCDEFKIBB<EIIDBGPEGBB> FIEDOLNFNLH, in TRpcParam JIGKFMMLBHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3A068A0", Offset = "0x3A058A0", VA = "0x183A068A0", Slot = "8")]
	private void MEHGHIJBMBF(in global::JIJCDEFKIBB<EIIDBGPEGBB> FIEDOLNFNLH, in TRpcParam JIGKFMMLBHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3A06240", Offset = "0x3A05240", VA = "0x183A06240", Slot = "9")]
	private void MPNAOFIBHGI(in global::JIJCDEFKIBB<EIIDBGPEGBB> FIEDOLNFNLH, in TRpcParam JIGKFMMLBHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x3D43140", Offset = "0x3D42140", VA = "0x183D43140", Slot = "10")]
	private void OGKDGMGMOEC(in global::JIJCDEFKIBB<EIIDBGPEGBB> FIEDOLNFNLH, in TRpcReceiver OPNHBKMFANE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x3D42470", Offset = "0x3D41470", VA = "0x183D42470", Slot = "11")]
	private TPlayer KHNCAHBMFOB(in global::JIJCDEFKIBB<EIIDBGPEGBB> FIEDOLNFNLH)
	{
		return (TPlayer)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3A06170", Offset = "0x3A05170", VA = "0x183A06170", Slot = "12")]
	private bool PEBJFPKBAJB(in global::JIJCDEFKIBB<EIIDBGPEGBB> FIEDOLNFNLH, in TPlayer JLDONLICNFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3D42540", Offset = "0x3D41540", VA = "0x183D42540", Slot = "13")]
	private global::JIJCDEFKIBB<ADJCAKHFMDL> KPOBJHIGPGN(in global::JIJCDEFKIBB<EIIDBGPEGBB> FIEDOLNFNLH, in TSyncFieldParam JIGKFMMLBHO)
	{
		return default(global::JIJCDEFKIBB<ADJCAKHFMDL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x392DF20", Offset = "0x392CF20", VA = "0x18392DF20", Slot = "14")]
	private void BNPELALLNPO(in global::JIJCDEFKIBB<ADJCAKHFMDL> OMOCMDDIDHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3D42570", Offset = "0x3D41570", VA = "0x183D42570", Slot = "15")]
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
	[Cpp2IlInjected.Address(RVA = "0x3D76AA0", Offset = "0x3D75AA0", VA = "0x183D76AA0")]
	private ENMHGAHOECA(HashSet<global::JIJCDEFKIBB<ADJCAKHFMDL>> OIMFKDIPMHJ, in TObject FIEDOLNFNLH, in TRpcReceiver OPNHBKMFANE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3D769C0", Offset = "0x3D759C0", VA = "0x183D769C0")]
	public static global::ENMHGAHOECA<TObject, TRpcParam, TRpcReceiver> CIAOGEOFBKG(in TObject FIEDOLNFNLH)
	{
		return default(global::ENMHGAHOECA<TObject, TRpcParam, TRpcReceiver>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
internal static class PCPMFFDAOLN<TRpcParam, TRpcReceiver> where TRpcReceiver : global::FAAGOCCAKGC<TRpcParam>
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x32B5F60", Offset = "0x32B4F60", VA = "0x1832B5F60")]
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
	[Cpp2IlInjected.Address(RVA = "0x347E810", Offset = "0x347D810", VA = "0x18347E810")]
	private FDHEMAFBLGK(in TSyncField CGIIFGOPDLK, in global::JIJCDEFKIBB<EIIDBGPEGBB> KNDBJPIOPAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x347E780", Offset = "0x347D780", VA = "0x18347E780")]
	public static global::FDHEMAFBLGK<TSyncField> CIAOGEOFBKG(in TSyncField CGIIFGOPDLK, global::JIJCDEFKIBB<EIIDBGPEGBB> KNDBJPIOPAJ)
	{
		return default(global::FDHEMAFBLGK<TSyncField>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal static class EMFGNHLNHIB
{
	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x32A2E00", Offset = "0x32A1E00", VA = "0x1832A2E00")]
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
