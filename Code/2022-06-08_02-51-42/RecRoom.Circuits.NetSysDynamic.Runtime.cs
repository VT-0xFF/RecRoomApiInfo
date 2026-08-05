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
		[Cpp2IlInjected.Address(RVA = "0x32027E0", Offset = "0x32017E0", VA = "0x1832027E0", Slot = "5")]
		get
		{
			return (TPlayer)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3202180", Offset = "0x3201180", VA = "0x183202180")]
	public TSyncField DGGNCLJALEM(global::EMJMCNHDCKE<DELFKKIBLAM> CFNAJEGKJIO)
	{
		return (TSyncField)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x32030B0", Offset = "0x32020B0", VA = "0x1832030B0")]
	protected PCLDILJGFEK(in TDeps KBKIMKGOABO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3201460", Offset = "0x3200460", VA = "0x183201460")]
	public static global::PCLDILJGFEK<TObject, TPlayer, TRpcParam, TRpcReceiver, TSyncField, TSyncFieldParam, TSyncFieldValue, TDeps> BAPHMNFAJJN(in TDeps KBKIMKGOABO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x32025E0", Offset = "0x32015E0", VA = "0x1832025E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x32028F0", Offset = "0x32018F0", VA = "0x1832028F0")]
	public global::EMJMCNHDCKE<DPFCNHBBOCD> HDOFMLABHBD(in TObject OMILIKJDDEJ)
	{
		return default(global::EMJMCNHDCKE<DPFCNHBBOCD>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x3202D70", Offset = "0x3201D70", VA = "0x183202D70")]
	public void LKHDCLIABGI(in global::EMJMCNHDCKE<DPFCNHBBOCD> OMILIKJDDEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3201530", Offset = "0x3200530", VA = "0x183201530")]
	public void BPJEAMMMPAA(in global::EMJMCNHDCKE<DPFCNHBBOCD> OMILIKJDDEJ, in TRpcParam GLCBACNALCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x32020E0", Offset = "0x32010E0", VA = "0x1832020E0")]
	public void DADCAKCGKPB(in global::EMJMCNHDCKE<DPFCNHBBOCD> OMILIKJDDEJ, in TRpcParam GLCBACNALCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3202A50", Offset = "0x3201A50", VA = "0x183202A50")]
	public void IDJIOJMGDCK(in global::EMJMCNHDCKE<DPFCNHBBOCD> OMILIKJDDEJ, in TRpcParam GLCBACNALCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3202960", Offset = "0x3201960", VA = "0x183202960")]
	public void HIELBEHCMGI(in global::EMJMCNHDCKE<DPFCNHBBOCD> OMILIKJDDEJ, in TRpcParam GLCBACNALCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3202540", Offset = "0x3201540", VA = "0x183202540")]
	public void DNPKHOCLBPE(in global::EMJMCNHDCKE<DPFCNHBBOCD> OMILIKJDDEJ, in TRpcParam GLCBACNALCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3202A00", Offset = "0x3201A00", VA = "0x183202A00")]
	public void IDHBDFCGOBH(in global::EMJMCNHDCKE<DPFCNHBBOCD> OMILIKJDDEJ, in TRpcReceiver BDKGCACCINP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3201FE0", Offset = "0x3200FE0", VA = "0x183201FE0")]
	public TPlayer CPDHBBCLICO(in global::EMJMCNHDCKE<DPFCNHBBOCD> OMILIKJDDEJ)
	{
		return (TPlayer)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3201360", Offset = "0x3200360", VA = "0x183201360")]
	public bool ALIKBNAPGDC(in global::EMJMCNHDCKE<DPFCNHBBOCD> OMILIKJDDEJ, in TPlayer IEBNODEBKJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x32015C0", Offset = "0x32005C0", VA = "0x1832015C0")]
	public global::EMJMCNHDCKE<DELFKKIBLAM> CMDMBCIEPCM(in global::EMJMCNHDCKE<DPFCNHBBOCD> OMILIKJDDEJ, in TSyncFieldParam GLCBACNALCL)
	{
		return default(global::EMJMCNHDCKE<DELFKKIBLAM>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x32022D0", Offset = "0x32012D0", VA = "0x1832022D0")]
	public void DHNLGKCMPLN(in global::EMJMCNHDCKE<DELFKKIBLAM> HOAPCDNDECC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3202EB0", Offset = "0x3201EB0", VA = "0x183202EB0")]
	public void MHIFOHEJNJK(in global::EMJMCNHDCKE<DELFKKIBLAM> NMHIOKDOGND, in TSyncFieldValue MFBIHMKFNKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3202AF0", Offset = "0x3201AF0", VA = "0x183202AF0", Slot = "6")]
	private void INNFDDNCJAF(in global::EMJMCNHDCKE<DPFCNHBBOCD> OMILIKJDDEJ, in TRpcParam GLCBACNALCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x32027B0", Offset = "0x32017B0", VA = "0x1832027B0", Slot = "7")]
	private void FONLCMKAGCD(in global::EMJMCNHDCKE<DPFCNHBBOCD> OMILIKJDDEJ, in TRpcParam GLCBACNALCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3203050", Offset = "0x3202050", VA = "0x183203050", Slot = "8")]
	private void NCDLHALCIFG(in global::EMJMCNHDCKE<DPFCNHBBOCD> OMILIKJDDEJ, in TRpcParam GLCBACNALCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3203080", Offset = "0x3202080", VA = "0x183203080", Slot = "9")]
	private void NEPEOGEEGKD(in global::EMJMCNHDCKE<DPFCNHBBOCD> OMILIKJDDEJ, in TRpcParam GLCBACNALCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x3201300", Offset = "0x3200300", VA = "0x183201300", Slot = "10")]
	private void AKEMBMBNDLI(in global::EMJMCNHDCKE<DPFCNHBBOCD> OMILIKJDDEJ, in TRpcReceiver BDKGCACCINP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x3202510", Offset = "0x3201510", VA = "0x183202510", Slot = "11")]
	private TPlayer DJNMPMHOOFG(in global::EMJMCNHDCKE<DPFCNHBBOCD> OMILIKJDDEJ)
	{
		return (TPlayer)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3201330", Offset = "0x3200330", VA = "0x183201330", Slot = "12")]
	private bool ALALKCMCOCH(in global::EMJMCNHDCKE<DPFCNHBBOCD> OMILIKJDDEJ, in TPlayer IEBNODEBKJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3202E80", Offset = "0x3201E80", VA = "0x183202E80", Slot = "13")]
	private global::EMJMCNHDCKE<DELFKKIBLAM> MGEHNGBDBDK(in global::EMJMCNHDCKE<DPFCNHBBOCD> OMILIKJDDEJ, in TSyncFieldParam GLCBACNALCL)
	{
		return default(global::EMJMCNHDCKE<DELFKKIBLAM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x1FE2390", Offset = "0x1FE1390", VA = "0x181FE2390", Slot = "14")]
	private void HDCDFEDEECL(in global::EMJMCNHDCKE<DELFKKIBLAM> NMHIOKDOGND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3202B20", Offset = "0x3201B20", VA = "0x183202B20", Slot = "15")]
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
	[Cpp2IlInjected.Address(RVA = "0x308B440", Offset = "0x308A440", VA = "0x18308B440")]
	private CINBPGOEGKB(HashSet<global::EMJMCNHDCKE<DELFKKIBLAM>> DEJGIDPFFPI, in TObject OMILIKJDDEJ, in TRpcReceiver BDKGCACCINP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x308B270", Offset = "0x308A270", VA = "0x18308B270")]
	public static global::CINBPGOEGKB<TObject, TRpcParam, TRpcReceiver> BAPHMNFAJJN(in TObject OMILIKJDDEJ)
	{
		return default(global::CINBPGOEGKB<TObject, TRpcParam, TRpcReceiver>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
internal static class IAAFNGEABIE<TRpcParam, TRpcReceiver> where TRpcReceiver : global::OJKCAJDJHEE<TRpcParam>
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x18CC6D0", Offset = "0x18CB6D0", VA = "0x1818CC6D0")]
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
	[Cpp2IlInjected.Address(RVA = "0x30860C0", Offset = "0x30850C0", VA = "0x1830860C0")]
	private CBHPDJGIJCI(in TSyncField CFNAJEGKJIO, in global::EMJMCNHDCKE<DPFCNHBBOCD> HJDKPHJCNPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3086030", Offset = "0x3085030", VA = "0x183086030")]
	public static global::CBHPDJGIJCI<TSyncField> BAPHMNFAJJN(in TSyncField CFNAJEGKJIO, global::EMJMCNHDCKE<DPFCNHBBOCD> HJDKPHJCNPK)
	{
		return default(global::CBHPDJGIJCI<TSyncField>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal static class BNHKKBFGIPN
{
	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x18C72A0", Offset = "0x18C62A0", VA = "0x1818C72A0")]
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
