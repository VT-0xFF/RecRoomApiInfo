using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface FICKIIKHLFD<TObject, TPlayer, TRpcParam, TSyncField, TSyncFieldParam, TSyncFieldValue>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	TPlayer CNPKAMFLMPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NBDEBEFHCCK(in TObject FBOGCDJOCBP, in TRpcParam BGOKFFKFKBE);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NONMCMEDCEE(in TObject FBOGCDJOCBP, in TRpcParam BGOKFFKFKBE);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EHPNBGELKAE(in TObject FBOGCDJOCBP, in TRpcParam BGOKFFKFKBE);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CJAPIIHALOB(in TObject FBOGCDJOCBP, in TRpcParam BGOKFFKFKBE);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	TPlayer HHCKAAMFPDF(in TObject FBOGCDJOCBP);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool LPCBLJOGCIK(in TObject FBOGCDJOCBP, in TPlayer LIIIKAIOJCL);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "7")]
	TSyncField EILANHMALCC(in global::ACAPOMDGPAA<AFPMIBPJNBH> EPEDGGPALGC, in TObject FBOGCDJOCBP, in TSyncFieldParam BGOKFFKFKBE);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void NCLBJEAIKDC(in TSyncField BGOKFFKFKBE);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void FKMAAFJFGJL(in TSyncField OCJCHAADOHL, in TSyncFieldValue HPIAFNBPEPC);
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000003")]
public readonly struct JPCAOFLMHIK
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000004")]
public readonly struct AFPMIBPJNBH
{
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class IDLDHCFCKIH<TObject, TPlayer, TRpcParam, TRpcReceiver, TSyncField, TSyncFieldParam, TSyncFieldValue, TDeps> : IDisposable, global::OPLBCEGOAND<global::ACAPOMDGPAA<JPCAOFLMHIK>, TPlayer, TRpcParam, TRpcReceiver, global::ACAPOMDGPAA<AFPMIBPJNBH>, TSyncFieldParam, TSyncFieldValue> where TRpcReceiver : global::CCCIDAFANDK<TRpcParam> where TDeps : global::FICKIIKHLFD<TObject, TPlayer, TRpcParam, TSyncField, TSyncFieldParam, TSyncFieldValue>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly TDeps NEODHPLBLHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly global::JIOGIJKAOLL<JPCAOFLMHIK, global::KMKADNIDAFO<TObject, TRpcParam, TRpcReceiver>> BGFIBLLHIHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly global::JIOGIJKAOLL<AFPMIBPJNBH, global::ELEHGMEIBPJ<TSyncField>> OEBLCHPHEOO;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public TPlayer CNPKAMFLMPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x38D45E0", Offset = "0x38D2FE0", VA = "0x1838D45E0", Slot = "5")]
		get
		{
			return (TPlayer)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x38D4420", Offset = "0x38D2E20", VA = "0x1838D4420")]
	public TSyncField FEDOGJGINEP(global::ACAPOMDGPAA<AFPMIBPJNBH> HIMIACGHJCP)
	{
		return (TSyncField)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x38D50A0", Offset = "0x38D3AA0", VA = "0x1838D50A0")]
	protected IDLDHCFCKIH(in TDeps CMIHJGBLBEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x38D49D0", Offset = "0x38D33D0", VA = "0x1838D49D0")]
	public static global::IDLDHCFCKIH<TObject, TPlayer, TRpcParam, TRpcReceiver, TSyncField, TSyncFieldParam, TSyncFieldValue, TDeps> IHEMFNLEEFI(in TDeps CMIHJGBLBEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x38D3570", Offset = "0x38D1F70", VA = "0x1838D3570", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x38D3500", Offset = "0x38D1F00", VA = "0x1838D3500")]
	public global::ACAPOMDGPAA<JPCAOFLMHIK> DDDNEFNBPPJ(in TObject FBOGCDJOCBP)
	{
		return default(global::ACAPOMDGPAA<JPCAOFLMHIK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x38D46A0", Offset = "0x38D30A0", VA = "0x1838D46A0")]
	public void IEPJPMCFIEI(in global::ACAPOMDGPAA<JPCAOFLMHIK> FBOGCDJOCBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x38D4450", Offset = "0x38D2E50", VA = "0x1838D4450")]
	public void GLHPEDADODN(in global::ACAPOMDGPAA<JPCAOFLMHIK> FBOGCDJOCBP, in TRpcParam BGOKFFKFKBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x38D4C00", Offset = "0x38D3600", VA = "0x1838D4C00")]
	public void NBDEBEFHCCK(in global::ACAPOMDGPAA<JPCAOFLMHIK> FBOGCDJOCBP, in TRpcParam BGOKFFKFKBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x38D5000", Offset = "0x38D3A00", VA = "0x1838D5000")]
	public void NONMCMEDCEE(in global::ACAPOMDGPAA<JPCAOFLMHIK> FBOGCDJOCBP, in TRpcParam BGOKFFKFKBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x38D37C0", Offset = "0x38D21C0", VA = "0x1838D37C0")]
	public void EHPNBGELKAE(in global::ACAPOMDGPAA<JPCAOFLMHIK> FBOGCDJOCBP, in TRpcParam BGOKFFKFKBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x38D3460", Offset = "0x38D1E60", VA = "0x1838D3460")]
	public void CJAPIIHALOB(in global::ACAPOMDGPAA<JPCAOFLMHIK> FBOGCDJOCBP, in TRpcParam BGOKFFKFKBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x38D3770", Offset = "0x38D2170", VA = "0x1838D3770")]
	public void EEDGNPHKPBA(in global::ACAPOMDGPAA<JPCAOFLMHIK> FBOGCDJOCBP, in TRpcReceiver CDPLICEKPHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x38D44E0", Offset = "0x38D2EE0", VA = "0x1838D44E0")]
	public TPlayer HHCKAAMFPDF(in global::ACAPOMDGPAA<JPCAOFLMHIK> FBOGCDJOCBP)
	{
		return (TPlayer)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x38D4B00", Offset = "0x38D3500", VA = "0x1838D4B00")]
	public bool LPCBLJOGCIK(in global::ACAPOMDGPAA<JPCAOFLMHIK> FBOGCDJOCBP, in TPlayer LIIIKAIOJCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x38D3860", Offset = "0x38D2260", VA = "0x1838D3860")]
	public global::ACAPOMDGPAA<AFPMIBPJNBH> EILANHMALCC(in global::ACAPOMDGPAA<JPCAOFLMHIK> FBOGCDJOCBP, in TSyncFieldParam BGOKFFKFKBE)
	{
		return default(global::ACAPOMDGPAA<AFPMIBPJNBH>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x38D4CA0", Offset = "0x38D36A0", VA = "0x1838D4CA0")]
	public void NCLBJEAIKDC(in global::ACAPOMDGPAA<AFPMIBPJNBH> HJOKDEFKMPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x38D4320", Offset = "0x38D2D20", VA = "0x1838D4320")]
	public void ENIBBEDGLBF(in global::ACAPOMDGPAA<AFPMIBPJNBH> OCJCHAADOHL, in TSyncFieldValue HPIAFNBPEPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x38B3D80", Offset = "0x38B2780", VA = "0x1838B3D80", Slot = "6")]
	private void BBPIOIDKOHH(in global::ACAPOMDGPAA<JPCAOFLMHIK> FBOGCDJOCBP, in TRpcParam BGOKFFKFKBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x38D4670", Offset = "0x38D3070", VA = "0x1838D4670", Slot = "7")]
	private void IDLMNPGHMGC(in global::ACAPOMDGPAA<JPCAOFLMHIK> FBOGCDJOCBP, in TRpcParam BGOKFFKFKBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x38B3B40", Offset = "0x38B2540", VA = "0x1838B3B40", Slot = "8")]
	private void LLLIDIPDNAM(in global::ACAPOMDGPAA<JPCAOFLMHIK> FBOGCDJOCBP, in TRpcParam BGOKFFKFKBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x38B3F60", Offset = "0x38B2960", VA = "0x1838B3F60", Slot = "9")]
	private void EOPLJFBEGMD(in global::ACAPOMDGPAA<JPCAOFLMHIK> FBOGCDJOCBP, in TRpcParam BGOKFFKFKBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x38D4AA0", Offset = "0x38D34A0", VA = "0x1838D4AA0", Slot = "10")]
	private void JPKGHEBEDBP(in global::ACAPOMDGPAA<JPCAOFLMHIK> FBOGCDJOCBP, in TRpcReceiver CDPLICEKPHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x38D3430", Offset = "0x38D1E30", VA = "0x1838D3430", Slot = "11")]
	private TPlayer BLFFBDKDFMG(in global::ACAPOMDGPAA<JPCAOFLMHIK> FBOGCDJOCBP)
	{
		return (TPlayer)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x38B42B0", Offset = "0x38B2CB0", VA = "0x1838B42B0", Slot = "12")]
	private bool HHNONAMIIML(in global::ACAPOMDGPAA<JPCAOFLMHIK> FBOGCDJOCBP, in TPlayer LIIIKAIOJCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x38D4AD0", Offset = "0x38D34D0", VA = "0x1838D4AD0", Slot = "13")]
	private global::ACAPOMDGPAA<AFPMIBPJNBH> LLNBKKFHGLB(in global::ACAPOMDGPAA<JPCAOFLMHIK> FBOGCDJOCBP, in TSyncFieldParam BGOKFFKFKBE)
	{
		return default(global::ACAPOMDGPAA<AFPMIBPJNBH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x38D3740", Offset = "0x38D2140", VA = "0x1838D3740", Slot = "14")]
	private void EAJHCKPPKJA(in global::ACAPOMDGPAA<AFPMIBPJNBH> OCJCHAADOHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x38D4640", Offset = "0x38D3040", VA = "0x1838D4640", Slot = "15")]
	private void HPLOJBCMAOE(in global::ACAPOMDGPAA<AFPMIBPJNBH> OCJCHAADOHL, in TSyncFieldValue HPIAFNBPEPC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal struct KMKADNIDAFO<TObject, TRpcParam, TRpcReceiver> where TRpcReceiver : global::CCCIDAFANDK<TRpcParam>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly HashSet<global::ACAPOMDGPAA<AFPMIBPJNBH>> CKMKMGFIJGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly TObject FDMHMBIOEKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public TRpcReceiver JNJGPHOCBLD;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x4055810", Offset = "0x4054210", VA = "0x184055810")]
	private KMKADNIDAFO(HashSet<global::ACAPOMDGPAA<AFPMIBPJNBH>> DOCMENDEICH, in TObject FBOGCDJOCBP, in TRpcReceiver CDPLICEKPHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x40556E0", Offset = "0x40540E0", VA = "0x1840556E0")]
	public static global::KMKADNIDAFO<TObject, TRpcParam, TRpcReceiver> IHEMFNLEEFI(in TObject FBOGCDJOCBP)
	{
		return default(global::KMKADNIDAFO<TObject, TRpcParam, TRpcReceiver>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
internal static class KKBOFBLCCPF<TRpcParam, TRpcReceiver> where TRpcReceiver : global::CCCIDAFANDK<TRpcParam>
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x29A6FA0", Offset = "0x29A59A0", VA = "0x1829A6FA0")]
	public static global::KMKADNIDAFO<TObject, TRpcParam, TRpcReceiver> IHEMFNLEEFI<TObject>(in TObject FBOGCDJOCBP)
	{
		return default(global::KMKADNIDAFO<TObject, TRpcParam, TRpcReceiver>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
internal struct ELEHGMEIBPJ<TSyncField>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public readonly TSyncField JINBNCLDCPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public readonly global::ACAPOMDGPAA<JPCAOFLMHIK> LBIGEGHFFPB;

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3929150", Offset = "0x3927B50", VA = "0x183929150")]
	private ELEHGMEIBPJ(in TSyncField HIMIACGHJCP, in global::ACAPOMDGPAA<JPCAOFLMHIK> OMIOPPIPHBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x39290C0", Offset = "0x3927AC0", VA = "0x1839290C0")]
	public static global::ELEHGMEIBPJ<TSyncField> IHEMFNLEEFI(in TSyncField HIMIACGHJCP, global::ACAPOMDGPAA<JPCAOFLMHIK> OMIOPPIPHBF)
	{
		return default(global::ELEHGMEIBPJ<TSyncField>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal static class JOJEDLGPIOO
{
	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x27C7340", Offset = "0x27C5D40", VA = "0x1827C7340")]
	public static global::ELEHGMEIBPJ<TSyncField> IHEMFNLEEFI<TSyncField>(in TSyncField HIMIACGHJCP, global::ACAPOMDGPAA<JPCAOFLMHIK> OMIOPPIPHBF)
	{
		return default(global::ELEHGMEIBPJ<TSyncField>);
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
