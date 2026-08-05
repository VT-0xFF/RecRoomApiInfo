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
		[Cpp2IlInjected.Address(RVA = "0x36EEC30", Offset = "0x36ED630", VA = "0x1836EEC30", Slot = "5")]
		get
		{
			return (TPlayer)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x36EEA70", Offset = "0x36ED470", VA = "0x1836EEA70")]
	public TSyncField FEDOGJGINEP(global::ACAPOMDGPAA<AFPMIBPJNBH> HIMIACGHJCP)
	{
		return (TSyncField)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x36EF6F0", Offset = "0x36EE0F0", VA = "0x1836EF6F0")]
	protected IDLDHCFCKIH(in TDeps CMIHJGBLBEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x36EF020", Offset = "0x36EDA20", VA = "0x1836EF020")]
	public static global::IDLDHCFCKIH<TObject, TPlayer, TRpcParam, TRpcReceiver, TSyncField, TSyncFieldParam, TSyncFieldValue, TDeps> IHEMFNLEEFI(in TDeps CMIHJGBLBEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x36EDBC0", Offset = "0x36EC5C0", VA = "0x1836EDBC0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x36EDB50", Offset = "0x36EC550", VA = "0x1836EDB50")]
	public global::ACAPOMDGPAA<JPCAOFLMHIK> DDDNEFNBPPJ(in TObject FBOGCDJOCBP)
	{
		return default(global::ACAPOMDGPAA<JPCAOFLMHIK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x36EECF0", Offset = "0x36ED6F0", VA = "0x1836EECF0")]
	public void IEPJPMCFIEI(in global::ACAPOMDGPAA<JPCAOFLMHIK> FBOGCDJOCBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x36EEAA0", Offset = "0x36ED4A0", VA = "0x1836EEAA0")]
	public void GLHPEDADODN(in global::ACAPOMDGPAA<JPCAOFLMHIK> FBOGCDJOCBP, in TRpcParam BGOKFFKFKBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x36EF250", Offset = "0x36EDC50", VA = "0x1836EF250")]
	public void NBDEBEFHCCK(in global::ACAPOMDGPAA<JPCAOFLMHIK> FBOGCDJOCBP, in TRpcParam BGOKFFKFKBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x36EF650", Offset = "0x36EE050", VA = "0x1836EF650")]
	public void NONMCMEDCEE(in global::ACAPOMDGPAA<JPCAOFLMHIK> FBOGCDJOCBP, in TRpcParam BGOKFFKFKBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x36EDE10", Offset = "0x36EC810", VA = "0x1836EDE10")]
	public void EHPNBGELKAE(in global::ACAPOMDGPAA<JPCAOFLMHIK> FBOGCDJOCBP, in TRpcParam BGOKFFKFKBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x36EDAB0", Offset = "0x36EC4B0", VA = "0x1836EDAB0")]
	public void CJAPIIHALOB(in global::ACAPOMDGPAA<JPCAOFLMHIK> FBOGCDJOCBP, in TRpcParam BGOKFFKFKBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x36EDDC0", Offset = "0x36EC7C0", VA = "0x1836EDDC0")]
	public void EEDGNPHKPBA(in global::ACAPOMDGPAA<JPCAOFLMHIK> FBOGCDJOCBP, in TRpcReceiver CDPLICEKPHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x36EEB30", Offset = "0x36ED530", VA = "0x1836EEB30")]
	public TPlayer HHCKAAMFPDF(in global::ACAPOMDGPAA<JPCAOFLMHIK> FBOGCDJOCBP)
	{
		return (TPlayer)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x36EF150", Offset = "0x36EDB50", VA = "0x1836EF150")]
	public bool LPCBLJOGCIK(in global::ACAPOMDGPAA<JPCAOFLMHIK> FBOGCDJOCBP, in TPlayer LIIIKAIOJCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x36EDEB0", Offset = "0x36EC8B0", VA = "0x1836EDEB0")]
	public global::ACAPOMDGPAA<AFPMIBPJNBH> EILANHMALCC(in global::ACAPOMDGPAA<JPCAOFLMHIK> FBOGCDJOCBP, in TSyncFieldParam BGOKFFKFKBE)
	{
		return default(global::ACAPOMDGPAA<AFPMIBPJNBH>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x36EF2F0", Offset = "0x36EDCF0", VA = "0x1836EF2F0")]
	public void NCLBJEAIKDC(in global::ACAPOMDGPAA<AFPMIBPJNBH> HJOKDEFKMPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x36EE970", Offset = "0x36ED370", VA = "0x1836EE970")]
	public void ENIBBEDGLBF(in global::ACAPOMDGPAA<AFPMIBPJNBH> OCJCHAADOHL, in TSyncFieldValue HPIAFNBPEPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x34038B0", Offset = "0x34022B0", VA = "0x1834038B0", Slot = "6")]
	private void BBPIOIDKOHH(in global::ACAPOMDGPAA<JPCAOFLMHIK> FBOGCDJOCBP, in TRpcParam BGOKFFKFKBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x36EECC0", Offset = "0x36ED6C0", VA = "0x1836EECC0", Slot = "7")]
	private void IDLMNPGHMGC(in global::ACAPOMDGPAA<JPCAOFLMHIK> FBOGCDJOCBP, in TRpcParam BGOKFFKFKBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3403670", Offset = "0x3402070", VA = "0x183403670", Slot = "8")]
	private void LLLIDIPDNAM(in global::ACAPOMDGPAA<JPCAOFLMHIK> FBOGCDJOCBP, in TRpcParam BGOKFFKFKBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3403A90", Offset = "0x3402490", VA = "0x183403A90", Slot = "9")]
	private void EOPLJFBEGMD(in global::ACAPOMDGPAA<JPCAOFLMHIK> FBOGCDJOCBP, in TRpcParam BGOKFFKFKBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x36EF0F0", Offset = "0x36EDAF0", VA = "0x1836EF0F0", Slot = "10")]
	private void JPKGHEBEDBP(in global::ACAPOMDGPAA<JPCAOFLMHIK> FBOGCDJOCBP, in TRpcReceiver CDPLICEKPHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x36EDA80", Offset = "0x36EC480", VA = "0x1836EDA80", Slot = "11")]
	private TPlayer BLFFBDKDFMG(in global::ACAPOMDGPAA<JPCAOFLMHIK> FBOGCDJOCBP)
	{
		return (TPlayer)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3403DE0", Offset = "0x34027E0", VA = "0x183403DE0", Slot = "12")]
	private bool HHNONAMIIML(in global::ACAPOMDGPAA<JPCAOFLMHIK> FBOGCDJOCBP, in TPlayer LIIIKAIOJCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x36EF120", Offset = "0x36EDB20", VA = "0x1836EF120", Slot = "13")]
	private global::ACAPOMDGPAA<AFPMIBPJNBH> LLNBKKFHGLB(in global::ACAPOMDGPAA<JPCAOFLMHIK> FBOGCDJOCBP, in TSyncFieldParam BGOKFFKFKBE)
	{
		return default(global::ACAPOMDGPAA<AFPMIBPJNBH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x36EDD90", Offset = "0x36EC790", VA = "0x1836EDD90", Slot = "14")]
	private void EAJHCKPPKJA(in global::ACAPOMDGPAA<AFPMIBPJNBH> OCJCHAADOHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x36EEC90", Offset = "0x36ED690", VA = "0x1836EEC90", Slot = "15")]
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
	[Cpp2IlInjected.Address(RVA = "0x3DCFDF0", Offset = "0x3DCE7F0", VA = "0x183DCFDF0")]
	private KMKADNIDAFO(HashSet<global::ACAPOMDGPAA<AFPMIBPJNBH>> DOCMENDEICH, in TObject FBOGCDJOCBP, in TRpcReceiver CDPLICEKPHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3DCFCC0", Offset = "0x3DCE6C0", VA = "0x183DCFCC0")]
	public static global::KMKADNIDAFO<TObject, TRpcParam, TRpcReceiver> IHEMFNLEEFI(in TObject FBOGCDJOCBP)
	{
		return default(global::KMKADNIDAFO<TObject, TRpcParam, TRpcReceiver>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
internal static class KKBOFBLCCPF<TRpcParam, TRpcReceiver> where TRpcReceiver : global::CCCIDAFANDK<TRpcParam>
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x24051E0", Offset = "0x2403BE0", VA = "0x1824051E0")]
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
	[Cpp2IlInjected.Address(RVA = "0x34C30F0", Offset = "0x34C1AF0", VA = "0x1834C30F0")]
	private ELEHGMEIBPJ(in TSyncField HIMIACGHJCP, in global::ACAPOMDGPAA<JPCAOFLMHIK> OMIOPPIPHBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x34C3060", Offset = "0x34C1A60", VA = "0x1834C3060")]
	public static global::ELEHGMEIBPJ<TSyncField> IHEMFNLEEFI(in TSyncField HIMIACGHJCP, global::ACAPOMDGPAA<JPCAOFLMHIK> OMIOPPIPHBF)
	{
		return default(global::ELEHGMEIBPJ<TSyncField>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal static class JOJEDLGPIOO
{
	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x22B4360", Offset = "0x22B2D60", VA = "0x1822B4360")]
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
