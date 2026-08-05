using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface NGAKHKOJINL<TObject, TPlayer, TRpcParam, TSyncField, TSyncFieldParam, TSyncFieldValue>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	TPlayer EIAGIBCAOAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FNFDIMFCJOH(in TObject CMGFKLKICHP, in TRpcParam DNMFIMLLNDL);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ABIIJOPHMFK(in TObject CMGFKLKICHP, in TRpcParam DNMFIMLLNDL);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BFIMODMHBNP(in TObject CMGFKLKICHP, in TRpcParam DNMFIMLLNDL);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OGKPKPOAAKD(in TObject CMGFKLKICHP, in TRpcParam DNMFIMLLNDL);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	TPlayer IEJFLJFANEH(in TObject CMGFKLKICHP);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool LMIIOPOGJHE(in TObject CMGFKLKICHP, in TPlayer IHGGHPEPPHN);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "7")]
	TSyncField DMFGEPFADFG(in global::CBOPPAHLFPF<AANKPNPBPDK> EGIMPHGOEAK, in TObject CMGFKLKICHP, in TSyncFieldParam DNMFIMLLNDL);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void BNEKGOHJJGD(in TSyncField DNMFIMLLNDL);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void DGLLJBGBEIG(in TSyncField GCEJJEHDDEL, in TSyncFieldValue MGNFAPLJAOB);
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000003")]
public readonly struct EDFHKFBHEHN
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000004")]
public readonly struct AANKPNPBPDK
{
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class ODLMPAFPELO<TObject, TPlayer, TRpcParam, TRpcReceiver, TSyncField, TSyncFieldParam, TSyncFieldValue, TDeps> : IDisposable, global::AGDLGCHBPFF<global::CBOPPAHLFPF<EDFHKFBHEHN>, TPlayer, TRpcParam, TRpcReceiver, global::CBOPPAHLFPF<AANKPNPBPDK>, TSyncFieldParam, TSyncFieldValue> where TRpcReceiver : global::OPEKCGNFMJN<TRpcParam> where TDeps : global::NGAKHKOJINL<TObject, TPlayer, TRpcParam, TSyncField, TSyncFieldParam, TSyncFieldValue>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly TDeps ICJDHGAABDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly global::CNKLMAGFFHC<EDFHKFBHEHN, global::IPNKALLJBPD<TObject, TRpcParam, TRpcReceiver>> IAKLCCAOBJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly global::CNKLMAGFFHC<AANKPNPBPDK, global::BKNACJGCLNG<TSyncField>> FDBBOIKNOGD;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public TPlayer EIAGIBCAOAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x3FCBAD0", Offset = "0x3FCAED0", VA = "0x183FCBAD0", Slot = "5")]
		get
		{
			return (TPlayer)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3FCCFE0", Offset = "0x3FCC3E0", VA = "0x183FCCFE0")]
	public TSyncField KEHFOIFNCIF(global::CBOPPAHLFPF<AANKPNPBPDK> HJILKKEIPIL)
	{
		return (TSyncField)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3FCD5A0", Offset = "0x3FCC9A0", VA = "0x183FCD5A0")]
	protected ODLMPAFPELO(in TDeps MKGMINLKDPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2FAA550", Offset = "0x2FA9950", VA = "0x182FAA550")]
	public static global::ODLMPAFPELO<TObject, TPlayer, TRpcParam, TRpcReceiver, TSyncField, TSyncFieldParam, TSyncFieldValue, TDeps> HFCEOLCNMNF(in TDeps MKGMINLKDPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3FCCB80", Offset = "0x3FCBF80", VA = "0x183FCCB80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3FCCE40", Offset = "0x3FCC240", VA = "0x183FCCE40")]
	public global::CBOPPAHLFPF<EDFHKFBHEHN> GEEEFNDEIHM(in TObject CMGFKLKICHP)
	{
		return default(global::CBOPPAHLFPF<EDFHKFBHEHN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x3FCD3C0", Offset = "0x3FCC7C0", VA = "0x183FCD3C0")]
	public void NGHNBIDPBFA(in global::CBOPPAHLFPF<EDFHKFBHEHN> CMGFKLKICHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3FCD110", Offset = "0x3FCC510", VA = "0x183FCD110")]
	public void NBPDBNLPNHG(in global::CBOPPAHLFPF<EDFHKFBHEHN> CMGFKLKICHP, in TRpcParam DNMFIMLLNDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3FCCD50", Offset = "0x3FCC150", VA = "0x183FCCD50")]
	public void FNFDIMFCJOH(in global::CBOPPAHLFPF<EDFHKFBHEHN> CMGFKLKICHP, in TRpcParam DNMFIMLLNDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3FCBA30", Offset = "0x3FCAE30", VA = "0x183FCBA30")]
	public void ABIIJOPHMFK(in global::CBOPPAHLFPF<EDFHKFBHEHN> CMGFKLKICHP, in TRpcParam DNMFIMLLNDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3FCBB60", Offset = "0x3FCAF60", VA = "0x183FCBB60")]
	public void BFIMODMHBNP(in global::CBOPPAHLFPF<EDFHKFBHEHN> CMGFKLKICHP, in TRpcParam DNMFIMLLNDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3FCD500", Offset = "0x3FCC900", VA = "0x183FCD500")]
	public void OGKPKPOAAKD(in global::CBOPPAHLFPF<EDFHKFBHEHN> CMGFKLKICHP, in TRpcParam DNMFIMLLNDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3FCCDF0", Offset = "0x3FCC1F0", VA = "0x183FCCDF0")]
	public void GANCLPCIBLI(in global::CBOPPAHLFPF<EDFHKFBHEHN> CMGFKLKICHP, in TRpcReceiver LOAKBMPLLGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3FCCEE0", Offset = "0x3FCC2E0", VA = "0x183FCCEE0")]
	public TPlayer IEJFLJFANEH(in global::CBOPPAHLFPF<EDFHKFBHEHN> CMGFKLKICHP)
	{
		return (TPlayer)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3FCD010", Offset = "0x3FCC410", VA = "0x183FCD010")]
	public bool LMIIOPOGJHE(in global::CBOPPAHLFPF<EDFHKFBHEHN> CMGFKLKICHP, in TPlayer IHGGHPEPPHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3FCC660", Offset = "0x3FCBA60", VA = "0x183FCC660")]
	public global::CBOPPAHLFPF<AANKPNPBPDK> DMFGEPFADFG(in global::CBOPPAHLFPF<EDFHKFBHEHN> CMGFKLKICHP, in TSyncFieldParam DNMFIMLLNDL)
	{
		return default(global::CBOPPAHLFPF<AANKPNPBPDK>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3FCBE40", Offset = "0x3FCB240", VA = "0x183FCBE40")]
	public void BNEKGOHJJGD(in global::CBOPPAHLFPF<AANKPNPBPDK> OOOAJNDEKOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3FCCA80", Offset = "0x3FCBE80", VA = "0x183FCCA80")]
	public void DPODNKKMIDN(in global::CBOPPAHLFPF<AANKPNPBPDK> GCEJJEHDDEL, in TSyncFieldValue MGNFAPLJAOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x36F2440", Offset = "0x36F1840", VA = "0x1836F2440", Slot = "6")]
	private void PNOCDINJGDM(in global::CBOPPAHLFPF<EDFHKFBHEHN> CMGFKLKICHP, in TRpcParam DNMFIMLLNDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x3FCBB30", Offset = "0x3FCAF30", VA = "0x183FCBB30", Slot = "7")]
	private void AMKHFPHPGKH(in global::CBOPPAHLFPF<EDFHKFBHEHN> CMGFKLKICHP, in TRpcParam DNMFIMLLNDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x36F1FE0", Offset = "0x36F13E0", VA = "0x1836F1FE0", Slot = "8")]
	private void PCGIDEDMEON(in global::CBOPPAHLFPF<EDFHKFBHEHN> CMGFKLKICHP, in TRpcParam DNMFIMLLNDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x36F2340", Offset = "0x36F1740", VA = "0x1836F2340", Slot = "9")]
	private void OFPEDNFHDEO(in global::CBOPPAHLFPF<EDFHKFBHEHN> CMGFKLKICHP, in TRpcParam DNMFIMLLNDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x3FCD4D0", Offset = "0x3FCC8D0", VA = "0x183FCD4D0", Slot = "10")]
	private void NOIDBCADNOF(in global::CBOPPAHLFPF<EDFHKFBHEHN> CMGFKLKICHP, in TRpcReceiver LOAKBMPLLGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x3FCBF90", Offset = "0x3FCB390", VA = "0x183FCBF90", Slot = "11")]
	private TPlayer DHACLKDEMNP(in global::CBOPPAHLFPF<EDFHKFBHEHN> CMGFKLKICHP)
	{
		return (TPlayer)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x36F1BB0", Offset = "0x36F0FB0", VA = "0x1836F1BB0", Slot = "12")]
	private bool ALKEJEOOJLD(in global::CBOPPAHLFPF<EDFHKFBHEHN> CMGFKLKICHP, in TPlayer IHGGHPEPPHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3FCBF60", Offset = "0x3FCB360", VA = "0x183FCBF60", Slot = "13")]
	private global::CBOPPAHLFPF<AANKPNPBPDK> CEMNGGMKCGM(in global::CBOPPAHLFPF<EDFHKFBHEHN> CMGFKLKICHP, in TSyncFieldParam DNMFIMLLNDL)
	{
		return default(global::CBOPPAHLFPF<AANKPNPBPDK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x2FADA90", Offset = "0x2FACE90", VA = "0x182FADA90", Slot = "14")]
	private void PCCCAKIIADM(in global::CBOPPAHLFPF<AANKPNPBPDK> GCEJJEHDDEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3FCCEB0", Offset = "0x3FCC2B0", VA = "0x183FCCEB0", Slot = "15")]
	private void GKFLANDCAML(in global::CBOPPAHLFPF<AANKPNPBPDK> GCEJJEHDDEL, in TSyncFieldValue MGNFAPLJAOB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal struct IPNKALLJBPD<TObject, TRpcParam, TRpcReceiver> where TRpcReceiver : global::OPEKCGNFMJN<TRpcParam>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly HashSet<global::CBOPPAHLFPF<AANKPNPBPDK>> ALPPFIOALCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly TObject MIOIPDAJFHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public TRpcReceiver ELLJLHPKGHG;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x24BF510", Offset = "0x24BE910", VA = "0x1824BF510")]
	private IPNKALLJBPD(HashSet<global::CBOPPAHLFPF<AANKPNPBPDK>> KJBGOIANAEH, in TObject CMGFKLKICHP, in TRpcReceiver LOAKBMPLLGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x24BF2F0", Offset = "0x24BE6F0", VA = "0x1824BF2F0")]
	public static global::IPNKALLJBPD<TObject, TRpcParam, TRpcReceiver> HFCEOLCNMNF(in TObject CMGFKLKICHP)
	{
		return default(global::IPNKALLJBPD<TObject, TRpcParam, TRpcReceiver>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
internal static class OJLAOIAJNBA<TRpcParam, TRpcReceiver> where TRpcReceiver : global::OPEKCGNFMJN<TRpcParam>
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x1FD1B70", Offset = "0x1FD0F70", VA = "0x181FD1B70")]
	public static global::IPNKALLJBPD<TObject, TRpcParam, TRpcReceiver> HFCEOLCNMNF<TObject>(in TObject CMGFKLKICHP)
	{
		return default(global::IPNKALLJBPD<TObject, TRpcParam, TRpcReceiver>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
internal struct BKNACJGCLNG<TSyncField>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public readonly TSyncField OFOEBFLMPOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public readonly global::CBOPPAHLFPF<EDFHKFBHEHN> HNHDEOAHBGL;

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3BC2C20", Offset = "0x3BC2020", VA = "0x183BC2C20")]
	private BKNACJGCLNG(in TSyncField HJILKKEIPIL, in global::CBOPPAHLFPF<EDFHKFBHEHN> AFIBCMPNNHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3BC2B90", Offset = "0x3BC1F90", VA = "0x183BC2B90")]
	public static global::BKNACJGCLNG<TSyncField> HFCEOLCNMNF(in TSyncField HJILKKEIPIL, global::CBOPPAHLFPF<EDFHKFBHEHN> AFIBCMPNNHD)
	{
		return default(global::BKNACJGCLNG<TSyncField>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal static class KFJHBPKJLMB
{
	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x21D5930", Offset = "0x21D4D30", VA = "0x1821D5930")]
	public static global::BKNACJGCLNG<TSyncField> HFCEOLCNMNF<TSyncField>(in TSyncField HJILKKEIPIL, global::CBOPPAHLFPF<EDFHKFBHEHN> AFIBCMPNNHD)
	{
		return default(global::BKNACJGCLNG<TSyncField>);
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
