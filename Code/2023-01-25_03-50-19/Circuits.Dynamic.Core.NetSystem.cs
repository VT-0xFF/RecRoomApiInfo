using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface GGJLHCMJCPI<TObject, TPlayer, TRpcParam, TSyncField, TSyncFieldParam, TSyncFieldValue>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	TPlayer HODLJMGJDPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GJPEKEALKBJ(in TObject GKCPJCKCENH, in TRpcParam ONHHPHCFHJN);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PDPFPLGLIDL(in TObject GKCPJCKCENH, in TRpcParam ONHHPHCFHJN);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PCMGIAJIDPO(in TObject GKCPJCKCENH, in TRpcParam ONHHPHCFHJN);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FNFGOBDAGGC(in TObject GKCPJCKCENH, in TRpcParam ONHHPHCFHJN);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	TPlayer PBLFLBMGLHI(in TObject GKCPJCKCENH);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool LBBNCCJCAGO(in TObject GKCPJCKCENH, TPlayer JMJDGCPGKLL);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "7")]
	TSyncField MCHPBBCBBNP(global::HAFOMODBANL<FMDBECBHJLC> KCHLIHHPAKF, in TObject GKCPJCKCENH, in TSyncFieldParam ONHHPHCFHJN);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void NPPHNFMOHJC(in TSyncField ONHHPHCFHJN);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void BDNPPCDJACD(in TSyncField HFNDODGNHIE, in TSyncFieldValue DFEOJBAFBHE);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface JKLDHEKFGED<TRpcParam>
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BPDFKGKLGOA(in TRpcParam KNOLDLABLMF);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public sealed class HFAJALODOLA
{
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class FMDBECBHJLC
{
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class FNNABALAEAH<TObject, TPlayer, TRpcParam, TRpcReceiver, TSyncField, TSyncFieldParam, TSyncFieldValue, TDeps> : IDisposable where TRpcReceiver : global::JKLDHEKFGED<TRpcParam> where TDeps : global::GGJLHCMJCPI<TObject, TPlayer, TRpcParam, TSyncField, TSyncFieldParam, TSyncFieldValue>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly TDeps HOKAKDDBBJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private global::FDBKMKENHNE<HFAJALODOLA, global::FOEFMDPKIII<TObject, TRpcParam, TRpcReceiver>> JLCFHLIJIDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private global::FDBKMKENHNE<FMDBECBHJLC, global::FNIEANNPFCL<TSyncField>> APLDHMMPFFL;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public TPlayer HODLJMGJDPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2E0B530", Offset = "0x2E0A530", VA = "0x182E0B530")]
		get
		{
			return (TPlayer)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x2E0A230", Offset = "0x2E09230", VA = "0x182E0A230")]
	public TSyncField EIHBJIBNIKL(global::HAFOMODBANL<FMDBECBHJLC> BNIDIHAAOAJ)
	{
		return (TSyncField)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2E0B7C0", Offset = "0x2E0A7C0", VA = "0x182E0B7C0")]
	protected FNNABALAEAH(in TDeps GODJKHDKJCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x2E09710", Offset = "0x2E08710", VA = "0x182E09710")]
	public static global::FNNABALAEAH<TObject, TPlayer, TRpcParam, TRpcReceiver, TSyncField, TSyncFieldParam, TSyncFieldValue, TDeps> DHGKFEMNGCO(in TDeps GODJKHDKJCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2E09CC0", Offset = "0x2E08CC0", VA = "0x182E09CC0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x2E0A5C0", Offset = "0x2E095C0", VA = "0x182E0A5C0")]
	public global::HAFOMODBANL<HFAJALODOLA> MAOGCBOADMG(in TObject GKCPJCKCENH)
	{
		return default(global::HAFOMODBANL<HFAJALODOLA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x2E0A030", Offset = "0x2E09030", VA = "0x182E0A030")]
	public void EBHJJJFMEDM(global::HAFOMODBANL<HFAJALODOLA> GKCPJCKCENH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x2E09680", Offset = "0x2E08680", VA = "0x182E09680")]
	public void BGPPOHJCADK(global::HAFOMODBANL<HFAJALODOLA> GKCPJCKCENH, in TRpcParam ONHHPHCFHJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2E0A330", Offset = "0x2E09330", VA = "0x182E0A330")]
	public void GJPEKEALKBJ(global::HAFOMODBANL<HFAJALODOLA> GKCPJCKCENH, in TRpcParam ONHHPHCFHJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x2E0B720", Offset = "0x2E0A720", VA = "0x182E0B720")]
	public void PDPFPLGLIDL(global::HAFOMODBANL<HFAJALODOLA> GKCPJCKCENH, in TRpcParam ONHHPHCFHJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x2E0B680", Offset = "0x2E0A680", VA = "0x182E0B680")]
	public void PCMGIAJIDPO(global::HAFOMODBANL<HFAJALODOLA> GKCPJCKCENH, in TRpcParam ONHHPHCFHJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2E0A290", Offset = "0x2E09290", VA = "0x182E0A290")]
	public void FNFGOBDAGGC(global::HAFOMODBANL<HFAJALODOLA> GKCPJCKCENH, in TRpcParam ONHHPHCFHJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x2E0A250", Offset = "0x2E09250", VA = "0x182E0A250")]
	public void FJHCCKMJCEC(global::HAFOMODBANL<HFAJALODOLA> GKCPJCKCENH, in TRpcReceiver HPADJEKKMOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2E0B590", Offset = "0x2E0A590", VA = "0x182E0B590")]
	public TPlayer PBLFLBMGLHI(global::HAFOMODBANL<HFAJALODOLA> GKCPJCKCENH)
	{
		return (TPlayer)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x2E0A3D0", Offset = "0x2E093D0", VA = "0x182E0A3D0")]
	public bool LBBNCCJCAGO(global::HAFOMODBANL<HFAJALODOLA> GKCPJCKCENH, in TPlayer JMJDGCPGKLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x2E0A630", Offset = "0x2E09630", VA = "0x182E0A630")]
	public global::HAFOMODBANL<FMDBECBHJLC> MCHPBBCBBNP(global::HAFOMODBANL<HFAJALODOLA> GKCPJCKCENH, in TSyncFieldParam ONHHPHCFHJN)
	{
		return default(global::HAFOMODBANL<FMDBECBHJLC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x2E0B2E0", Offset = "0x2E0A2E0", VA = "0x182E0B2E0")]
	public void NPPHNFMOHJC(global::HAFOMODBANL<FMDBECBHJLC> IGFDJMLEABD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x2E0B0C0", Offset = "0x2E0A0C0", VA = "0x182E0B0C0")]
	public void MLEIHHHMOKD(global::HAFOMODBANL<FMDBECBHJLC> HFNDODGNHIE, in TSyncFieldValue DFEOJBAFBHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
internal struct FOEFMDPKIII<TObject, TRpcParam, TRpcReceiver> where TRpcReceiver : global::JKLDHEKFGED<TRpcParam>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly HashSet<global::HAFOMODBANL<FMDBECBHJLC>> CBGIMALAAML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly TObject BOPBDDIKOBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public TRpcReceiver AMAMDEGJEOM;

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x2E10F70", Offset = "0x2E0FF70", VA = "0x182E10F70")]
	private FOEFMDPKIII(HashSet<global::HAFOMODBANL<FMDBECBHJLC>> KMLDOMFKBII, in TObject GKCPJCKCENH, in TRpcReceiver HPADJEKKMOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x2E10EA0", Offset = "0x2E0FEA0", VA = "0x182E10EA0")]
	public static global::FOEFMDPKIII<TObject, TRpcParam, TRpcReceiver> DHGKFEMNGCO(in TObject GKCPJCKCENH)
	{
		return default(global::FOEFMDPKIII<TObject, TRpcParam, TRpcReceiver>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
internal static class PJJNNAJBCEM<TRpcParam, TRpcReceiver> where TRpcReceiver : global::JKLDHEKFGED<TRpcParam>
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x27C0BD0", Offset = "0x27BFBD0", VA = "0x1827C0BD0")]
	public static global::FOEFMDPKIII<TObject, TRpcParam, TRpcReceiver> DHGKFEMNGCO<TObject>(in TObject GKCPJCKCENH)
	{
		return default(global::FOEFMDPKIII<TObject, TRpcParam, TRpcReceiver>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal struct FNIEANNPFCL<TSyncField>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public readonly TSyncField ECKAHDLJBKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public readonly global::HAFOMODBANL<HFAJALODOLA> PKDGLMGOCBL;

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x2E09630", Offset = "0x2E08630", VA = "0x182E09630")]
	private FNIEANNPFCL(in TSyncField BNIDIHAAOAJ, global::HAFOMODBANL<HFAJALODOLA> DLEJNHLNJBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x2E09580", Offset = "0x2E08580", VA = "0x182E09580")]
	public static global::FNIEANNPFCL<TSyncField> DHGKFEMNGCO(in TSyncField BNIDIHAAOAJ, global::HAFOMODBANL<HFAJALODOLA> DLEJNHLNJBM)
	{
		return default(global::FNIEANNPFCL<TSyncField>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal static class OEPNNFFAKAC
{
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x2784A60", Offset = "0x2783A60", VA = "0x182784A60")]
	public static global::FNIEANNPFCL<TSyncField> DHGKFEMNGCO<TSyncField>(in TSyncField BNIDIHAAOAJ, global::HAFOMODBANL<HFAJALODOLA> DLEJNHLNJBM)
	{
		return default(global::FNIEANNPFCL<TSyncField>);
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
