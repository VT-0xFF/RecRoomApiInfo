using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface HKPIAGMHDBH<TObject, TPlayer, TRpcParam, TSyncField, TSyncFieldParam, TSyncFieldValue>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	TPlayer OJNPAMCAAOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DADCAKCGKPB(in TObject OMILIKJDDEJ, in TRpcParam GLCBACNALCL);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IDJIOJMGDCK(in TObject OMILIKJDDEJ, in TRpcParam GLCBACNALCL);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HIELBEHCMGI(in TObject OMILIKJDDEJ, in TRpcParam GLCBACNALCL);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DNPKHOCLBPE(in TObject OMILIKJDDEJ, in TRpcParam GLCBACNALCL);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	TPlayer CPDHBBCLICO(in TObject OMILIKJDDEJ);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool ALIKBNAPGDC(in TObject OMILIKJDDEJ, in TPlayer IEBNODEBKJM);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "7")]
	TSyncField CMDMBCIEPCM(in global::EMJMCNHDCKE<DELFKKIBLAM> CPDLKGDIAIE, in TObject OMILIKJDDEJ, in TSyncFieldParam GLCBACNALCL);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void DHNLGKCMPLN(in TSyncField GLCBACNALCL);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void LOJJMNNDKHC(in TSyncField NMHIOKDOGND, in TSyncFieldValue MFBIHMKFNKA);
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000003")]
public readonly struct DPFCNHBBOCD
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000004")]
public readonly struct DELFKKIBLAM
{
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class PCLDILJGFEK<TObject, TPlayer, TRpcParam, TRpcReceiver, TSyncField, TSyncFieldParam, TSyncFieldValue, TDeps> : IDisposable, global::DNEHNNINBHD<global::EMJMCNHDCKE<DPFCNHBBOCD>, TPlayer, TRpcParam, TRpcReceiver, global::EMJMCNHDCKE<DELFKKIBLAM>, TSyncFieldParam, TSyncFieldValue> where TRpcReceiver : global::OJKCAJDJHEE<TRpcParam> where TDeps : global::HKPIAGMHDBH<TObject, TPlayer, TRpcParam, TSyncField, TSyncFieldParam, TSyncFieldValue>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly TDeps EGAGNOCKMLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly global::OIHNBCCIFCF<DPFCNHBBOCD, global::CINBPGOEGKB<TObject, TRpcParam, TRpcReceiver>> PIKDCCPHBPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly global::OIHNBCCIFCF<DELFKKIBLAM, global::CBHPDJGIJCI<TSyncField>> JECNGIHAPKB;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public TPlayer OJNPAMCAAOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x37648D0", Offset = "0x37630D0", VA = "0x1837648D0", Slot = "5")]
		get
		{
			return (TPlayer)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3764270", Offset = "0x3762A70", VA = "0x183764270")]
	public TSyncField DGGNCLJALEM(global::EMJMCNHDCKE<DELFKKIBLAM> CFNAJEGKJIO)
	{
		return (TSyncField)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x37650F0", Offset = "0x37638F0", VA = "0x1837650F0")]
	protected PCLDILJGFEK(in TDeps KBKIMKGOABO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2BD1410", Offset = "0x2BCFC10", VA = "0x182BD1410")]
	public static global::PCLDILJGFEK<TObject, TPlayer, TRpcParam, TRpcReceiver, TSyncField, TSyncFieldParam, TSyncFieldValue, TDeps> BAPHMNFAJJN(in TDeps KBKIMKGOABO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x37646D0", Offset = "0x3762ED0", VA = "0x1837646D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3764930", Offset = "0x3763130", VA = "0x183764930")]
	public global::EMJMCNHDCKE<DPFCNHBBOCD> HDOFMLABHBD(in TObject OMILIKJDDEJ)
	{
		return default(global::EMJMCNHDCKE<DPFCNHBBOCD>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x3764DB0", Offset = "0x37635B0", VA = "0x183764DB0")]
	public void LKHDCLIABGI(in global::EMJMCNHDCKE<DPFCNHBBOCD> OMILIKJDDEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3763620", Offset = "0x3761E20", VA = "0x183763620")]
	public void BPJEAMMMPAA(in global::EMJMCNHDCKE<DPFCNHBBOCD> OMILIKJDDEJ, in TRpcParam GLCBACNALCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x37641D0", Offset = "0x37629D0", VA = "0x1837641D0")]
	public void DADCAKCGKPB(in global::EMJMCNHDCKE<DPFCNHBBOCD> OMILIKJDDEJ, in TRpcParam GLCBACNALCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3764A90", Offset = "0x3763290", VA = "0x183764A90")]
	public void IDJIOJMGDCK(in global::EMJMCNHDCKE<DPFCNHBBOCD> OMILIKJDDEJ, in TRpcParam GLCBACNALCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x37649A0", Offset = "0x37631A0", VA = "0x1837649A0")]
	public void HIELBEHCMGI(in global::EMJMCNHDCKE<DPFCNHBBOCD> OMILIKJDDEJ, in TRpcParam GLCBACNALCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3764630", Offset = "0x3762E30", VA = "0x183764630")]
	public void DNPKHOCLBPE(in global::EMJMCNHDCKE<DPFCNHBBOCD> OMILIKJDDEJ, in TRpcParam GLCBACNALCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3764A40", Offset = "0x3763240", VA = "0x183764A40")]
	public void IDHBDFCGOBH(in global::EMJMCNHDCKE<DPFCNHBBOCD> OMILIKJDDEJ, in TRpcReceiver BDKGCACCINP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x37640D0", Offset = "0x37628D0", VA = "0x1837640D0")]
	public TPlayer CPDHBBCLICO(in global::EMJMCNHDCKE<DPFCNHBBOCD> OMILIKJDDEJ)
	{
		return (TPlayer)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3763520", Offset = "0x3761D20", VA = "0x183763520")]
	public bool ALIKBNAPGDC(in global::EMJMCNHDCKE<DPFCNHBBOCD> OMILIKJDDEJ, in TPlayer IEBNODEBKJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x37636B0", Offset = "0x3761EB0", VA = "0x1837636B0")]
	public global::EMJMCNHDCKE<DELFKKIBLAM> CMDMBCIEPCM(in global::EMJMCNHDCKE<DPFCNHBBOCD> OMILIKJDDEJ, in TSyncFieldParam GLCBACNALCL)
	{
		return default(global::EMJMCNHDCKE<DELFKKIBLAM>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x37643C0", Offset = "0x3762BC0", VA = "0x1837643C0")]
	public void DHNLGKCMPLN(in global::EMJMCNHDCKE<DELFKKIBLAM> HOAPCDNDECC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3764EF0", Offset = "0x37636F0", VA = "0x183764EF0")]
	public void MHIFOHEJNJK(in global::EMJMCNHDCKE<DELFKKIBLAM> NMHIOKDOGND, in TSyncFieldValue MFBIHMKFNKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3764B30", Offset = "0x3763330", VA = "0x183764B30", Slot = "6")]
	private void INNFDDNCJAF(in global::EMJMCNHDCKE<DPFCNHBBOCD> OMILIKJDDEJ, in TRpcParam GLCBACNALCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x37648A0", Offset = "0x37630A0", VA = "0x1837648A0", Slot = "7")]
	private void FONLCMKAGCD(in global::EMJMCNHDCKE<DPFCNHBBOCD> OMILIKJDDEJ, in TRpcParam GLCBACNALCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3765090", Offset = "0x3763890", VA = "0x183765090", Slot = "8")]
	private void NCDLHALCIFG(in global::EMJMCNHDCKE<DPFCNHBBOCD> OMILIKJDDEJ, in TRpcParam GLCBACNALCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x37650C0", Offset = "0x37638C0", VA = "0x1837650C0", Slot = "9")]
	private void NEPEOGEEGKD(in global::EMJMCNHDCKE<DPFCNHBBOCD> OMILIKJDDEJ, in TRpcParam GLCBACNALCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x37634C0", Offset = "0x3761CC0", VA = "0x1837634C0", Slot = "10")]
	private void AKEMBMBNDLI(in global::EMJMCNHDCKE<DPFCNHBBOCD> OMILIKJDDEJ, in TRpcReceiver BDKGCACCINP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x3764600", Offset = "0x3762E00", VA = "0x183764600", Slot = "11")]
	private TPlayer DJNMPMHOOFG(in global::EMJMCNHDCKE<DPFCNHBBOCD> OMILIKJDDEJ)
	{
		return (TPlayer)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x37634F0", Offset = "0x3761CF0", VA = "0x1837634F0", Slot = "12")]
	private bool ALALKCMCOCH(in global::EMJMCNHDCKE<DPFCNHBBOCD> OMILIKJDDEJ, in TPlayer IEBNODEBKJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3764EC0", Offset = "0x37636C0", VA = "0x183764EC0", Slot = "13")]
	private global::EMJMCNHDCKE<DELFKKIBLAM> MGEHNGBDBDK(in global::EMJMCNHDCKE<DPFCNHBBOCD> OMILIKJDDEJ, in TSyncFieldParam GLCBACNALCL)
	{
		return default(global::EMJMCNHDCKE<DELFKKIBLAM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x2BCD070", Offset = "0x2BCB870", VA = "0x182BCD070", Slot = "14")]
	private void HDCDFEDEECL(in global::EMJMCNHDCKE<DELFKKIBLAM> NMHIOKDOGND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3764B60", Offset = "0x3763360", VA = "0x183764B60", Slot = "15")]
	private void KNLHBAOLMNJ(in global::EMJMCNHDCKE<DELFKKIBLAM> NMHIOKDOGND, in TSyncFieldValue MFBIHMKFNKA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal struct CINBPGOEGKB<TObject, TRpcParam, TRpcReceiver> where TRpcReceiver : global::OJKCAJDJHEE<TRpcParam>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly HashSet<global::EMJMCNHDCKE<DELFKKIBLAM>> OJDBKGBHEHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly TObject GIANCODJNLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public TRpcReceiver IKMKJIHBCBK;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3454E90", Offset = "0x3453690", VA = "0x183454E90")]
	private CINBPGOEGKB(HashSet<global::EMJMCNHDCKE<DELFKKIBLAM>> DEJGIDPFFPI, in TObject OMILIKJDDEJ, in TRpcReceiver BDKGCACCINP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3454CC0", Offset = "0x34534C0", VA = "0x183454CC0")]
	public static global::CINBPGOEGKB<TObject, TRpcParam, TRpcReceiver> BAPHMNFAJJN(in TObject OMILIKJDDEJ)
	{
		return default(global::CINBPGOEGKB<TObject, TRpcParam, TRpcReceiver>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
internal static class IAAFNGEABIE<TRpcParam, TRpcReceiver> where TRpcReceiver : global::OJKCAJDJHEE<TRpcParam>
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x1FBF770", Offset = "0x1FBDF70", VA = "0x181FBF770")]
	public static global::CINBPGOEGKB<TObject, TRpcParam, TRpcReceiver> BAPHMNFAJJN<TObject>(in TObject OMILIKJDDEJ)
	{
		return default(global::CINBPGOEGKB<TObject, TRpcParam, TRpcReceiver>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
internal struct CBHPDJGIJCI<TSyncField>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public readonly TSyncField BNDKBBCMFPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public readonly global::EMJMCNHDCKE<DPFCNHBBOCD> OHGDOGPDIKP;

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x361DA60", Offset = "0x361C260", VA = "0x18361DA60")]
	private CBHPDJGIJCI(in TSyncField CFNAJEGKJIO, in global::EMJMCNHDCKE<DPFCNHBBOCD> HJDKPHJCNPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x361D9D0", Offset = "0x361C1D0", VA = "0x18361D9D0")]
	public static global::CBHPDJGIJCI<TSyncField> BAPHMNFAJJN(in TSyncField CFNAJEGKJIO, global::EMJMCNHDCKE<DPFCNHBBOCD> HJDKPHJCNPK)
	{
		return default(global::CBHPDJGIJCI<TSyncField>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal static class BNHKKBFGIPN
{
	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x1FBA3D0", Offset = "0x1FB8BD0", VA = "0x181FBA3D0")]
	public static global::CBHPDJGIJCI<TSyncField> BAPHMNFAJJN<TSyncField>(in TSyncField CFNAJEGKJIO, global::EMJMCNHDCKE<DPFCNHBBOCD> HJDKPHJCNPK)
	{
		return default(global::CBHPDJGIJCI<TSyncField>);
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
