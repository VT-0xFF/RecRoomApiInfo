using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface MLPOEGBNDEA<TObject, TPlayer, TRpcParam, TSyncField, TSyncFieldParam, TSyncFieldValue>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	TPlayer LEJJINNGNID
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AHIKNEGPDDH(in TObject KMFLGGMLFJA, in TRpcParam BHOMHPIPDNM);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ICMNBPGKGLH(in TObject KMFLGGMLFJA, in TRpcParam BHOMHPIPDNM);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JEGIICGBCBE(in TObject KMFLGGMLFJA, in TRpcParam BHOMHPIPDNM);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PHLLACMJJCG(in TObject KMFLGGMLFJA, in TRpcParam BHOMHPIPDNM);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	TPlayer GFOCHMDMHGF(in TObject KMFLGGMLFJA);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool EMELPOEBKLC(in TObject KMFLGGMLFJA, TPlayer ELMPCHPADPD);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "7")]
	TSyncField EKMGLAJJJAG(global::IBGINLNKKBK<LNJBBNNHEOH> GLGEGPNMJGF, in TObject KMFLGGMLFJA, in TSyncFieldParam BHOMHPIPDNM);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void INBNMKLOHEK(in TSyncField BHOMHPIPDNM);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void EGDHJAFLBJF(in TSyncField KOKKABCBPKB, in TSyncFieldValue GKFICKKHACC);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface HKMJIMJOIFA<TRpcParam>
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FJMALHDKLCP(in TRpcParam KDJGJCHCIKK);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public sealed class IALNLOOMFAE
{
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class LNJBBNNHEOH
{
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class DMKBBMIKBGL<TObject, TPlayer, TRpcParam, TRpcReceiver, TSyncField, TSyncFieldParam, TSyncFieldValue, TDeps> : IDisposable where TRpcReceiver : global::HKMJIMJOIFA<TRpcParam> where TDeps : global::MLPOEGBNDEA<TObject, TPlayer, TRpcParam, TSyncField, TSyncFieldParam, TSyncFieldValue>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly TDeps DPDFKNGGDCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private global::HJBNDEPHGEO<IALNLOOMFAE, global::LHGFFDNCEHJ<TObject, TRpcParam, TRpcReceiver>> ODKBFNFBJID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private global::HJBNDEPHGEO<LNJBBNNHEOH, global::DPBDEKPEFKB<TSyncField>> ELCBPPEOJMG;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public TPlayer LEJJINNGNID
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x3658980", Offset = "0x3657780", VA = "0x183658980")]
		get
		{
			return (TPlayer)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x36574A0", Offset = "0x36562A0", VA = "0x1836574A0")]
	public TSyncField DCEJDFLDBDK(global::IBGINLNKKBK<LNJBBNNHEOH> GNHLNBEGIDP)
	{
		return (TSyncField)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x36594E0", Offset = "0x36582E0", VA = "0x1836594E0")]
	protected DMKBBMIKBGL(in TDeps HKPDNJBMEMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3659000", Offset = "0x3657E00", VA = "0x183659000")]
	public static global::DMKBBMIKBGL<TObject, TPlayer, TRpcParam, TRpcReceiver, TSyncField, TSyncFieldParam, TSyncFieldValue, TDeps> KCNAIILPDFM(in TDeps HKPDNJBMEMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x36574C0", Offset = "0x36562C0", VA = "0x1836574C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x36590D0", Offset = "0x3657ED0", VA = "0x1836590D0")]
	public global::IBGINLNKKBK<IALNLOOMFAE> LBBLFNFOCLK(in TObject KMFLGGMLFJA)
	{
		return default(global::IBGINLNKKBK<IALNLOOMFAE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3659140", Offset = "0x3657F40", VA = "0x183659140")]
	public void PAHKHPEICKF(global::IBGINLNKKBK<IALNLOOMFAE> KMFLGGMLFJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x36588F0", Offset = "0x36576F0", VA = "0x1836588F0")]
	public void HFHJJKGPCHB(global::IBGINLNKKBK<IALNLOOMFAE> KMFLGGMLFJA, in TRpcParam BHOMHPIPDNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x36573C0", Offset = "0x36561C0", VA = "0x1836573C0")]
	public void AHIKNEGPDDH(global::IBGINLNKKBK<IALNLOOMFAE> KMFLGGMLFJA, in TRpcParam BHOMHPIPDNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3658B60", Offset = "0x3657960", VA = "0x183658B60")]
	public void ICMNBPGKGLH(global::IBGINLNKKBK<IALNLOOMFAE> KMFLGGMLFJA, in TRpcParam BHOMHPIPDNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3658F60", Offset = "0x3657D60", VA = "0x183658F60")]
	public void JEGIICGBCBE(global::IBGINLNKKBK<IALNLOOMFAE> KMFLGGMLFJA, in TRpcParam BHOMHPIPDNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3659440", Offset = "0x3658240", VA = "0x183659440")]
	public void PHLLACMJJCG(global::IBGINLNKKBK<IALNLOOMFAE> KMFLGGMLFJA, in TRpcParam BHOMHPIPDNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3657460", Offset = "0x3656260", VA = "0x183657460")]
	public void CGJNEMMCPPL(global::IBGINLNKKBK<IALNLOOMFAE> KMFLGGMLFJA, in TRpcReceiver OIJGODEOMJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3658800", Offset = "0x3657600", VA = "0x183658800")]
	public TPlayer GFOCHMDMHGF(global::IBGINLNKKBK<IALNLOOMFAE> KMFLGGMLFJA)
	{
		return (TPlayer)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3658610", Offset = "0x3657410", VA = "0x183658610")]
	public bool EMELPOEBKLC(global::IBGINLNKKBK<IALNLOOMFAE> KMFLGGMLFJA, in TPlayer ELMPCHPADPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3657C10", Offset = "0x3656A10", VA = "0x183657C10")]
	public global::IBGINLNKKBK<LNJBBNNHEOH> EKMGLAJJJAG(global::IBGINLNKKBK<IALNLOOMFAE> KMFLGGMLFJA, in TSyncFieldParam BHOMHPIPDNM)
	{
		return default(global::IBGINLNKKBK<LNJBBNNHEOH>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3658E40", Offset = "0x3657C40", VA = "0x183658E40")]
	public void INBNMKLOHEK(global::IBGINLNKKBK<LNJBBNNHEOH> JPJGEDCHOBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3658A70", Offset = "0x3657870", VA = "0x183658A70")]
	public void IBNADGHDDNO(global::IBGINLNKKBK<LNJBBNNHEOH> KOKKABCBPKB, in TSyncFieldValue GKFICKKHACC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
internal struct LHGFFDNCEHJ<TObject, TRpcParam, TRpcReceiver> where TRpcReceiver : global::HKMJIMJOIFA<TRpcParam>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly HashSet<global::IBGINLNKKBK<LNJBBNNHEOH>> MFJCGLAHOKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly TObject NAMHJICBNNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public TRpcReceiver KGADHHAOHEJ;

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x2BBB3C0", Offset = "0x2BBA1C0", VA = "0x182BBB3C0")]
	private LHGFFDNCEHJ(HashSet<global::IBGINLNKKBK<LNJBBNNHEOH>> NFMKHIAGNDM, in TObject KMFLGGMLFJA, in TRpcReceiver OIJGODEOMJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x2BBB1C0", Offset = "0x2BB9FC0", VA = "0x182BBB1C0")]
	public static global::LHGFFDNCEHJ<TObject, TRpcParam, TRpcReceiver> KCNAIILPDFM(in TObject KMFLGGMLFJA)
	{
		return default(global::LHGFFDNCEHJ<TObject, TRpcParam, TRpcReceiver>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
internal static class MDMIFBCDEEB<TRpcParam, TRpcReceiver> where TRpcReceiver : global::HKMJIMJOIFA<TRpcParam>
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x270B910", Offset = "0x270A710", VA = "0x18270B910")]
	public static global::LHGFFDNCEHJ<TObject, TRpcParam, TRpcReceiver> KCNAIILPDFM<TObject>(in TObject KMFLGGMLFJA)
	{
		return default(global::LHGFFDNCEHJ<TObject, TRpcParam, TRpcReceiver>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal struct DPBDEKPEFKB<TSyncField>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public readonly TSyncField JOKNFPNHCHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public readonly global::IBGINLNKKBK<IALNLOOMFAE> JCEBCPONLEN;

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x365B600", Offset = "0x365A400", VA = "0x18365B600")]
	private DPBDEKPEFKB(in TSyncField GNHLNBEGIDP, global::IBGINLNKKBK<IALNLOOMFAE> LFLHKBBMFCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x365B580", Offset = "0x365A380", VA = "0x18365B580")]
	public static global::DPBDEKPEFKB<TSyncField> KCNAIILPDFM(in TSyncField GNHLNBEGIDP, global::IBGINLNKKBK<IALNLOOMFAE> LFLHKBBMFCA)
	{
		return default(global::DPBDEKPEFKB<TSyncField>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal static class LEGHEGHNIGA
{
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x2DD34B0", Offset = "0x2DD22B0", VA = "0x182DD34B0")]
	public static global::DPBDEKPEFKB<TSyncField> KCNAIILPDFM<TSyncField>(in TSyncField GNHLNBEGIDP, global::IBGINLNKKBK<IALNLOOMFAE> LFLHKBBMFCA)
	{
		return default(global::DPBDEKPEFKB<TSyncField>);
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
