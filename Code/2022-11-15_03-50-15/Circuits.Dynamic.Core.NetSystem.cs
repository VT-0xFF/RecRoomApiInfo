using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface MBJOFPMJNMO<TObject, TPlayer, TRpcParam, TSyncField, TSyncFieldParam, TSyncFieldValue>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	TPlayer CEOCLGGEKNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EAEAJBGPKDB(in TObject PDHKCBEBPNG, in TRpcParam HOCPDJAJOIH);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OEGMLIJDIGC(in TObject PDHKCBEBPNG, in TRpcParam HOCPDJAJOIH);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EOJCOOEOEEE(in TObject PDHKCBEBPNG, in TRpcParam HOCPDJAJOIH);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JCMOHOCAJMD(in TObject PDHKCBEBPNG, in TRpcParam HOCPDJAJOIH);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	TPlayer ACLKABFCJIG(in TObject PDHKCBEBPNG);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool LFCPNKNNIPH(in TObject PDHKCBEBPNG, TPlayer IBALNAIHOLI);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "7")]
	TSyncField MKLGEOOCGDM(global::MILDMIBLDIO<FAPEGLKNBBF> ENFGKNDHLNI, in TObject PDHKCBEBPNG, in TSyncFieldParam HOCPDJAJOIH);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void BFFFKFHGBKK(in TSyncField HOCPDJAJOIH);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void EBJNCLPJHBO(in TSyncField FELFGFPIGEP, in TSyncFieldValue NKJMIDIDBOE);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface BNCHMDKHKLM<TRpcParam>
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HIMPOJKPGMB(in TRpcParam LBPAPOGAAHD);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public sealed class JAIHIEKEHOM
{
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class FAPEGLKNBBF
{
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class KJLOFFLDEGK<TObject, TPlayer, TRpcParam, TRpcReceiver, TSyncField, TSyncFieldParam, TSyncFieldValue, TDeps> : IDisposable where TRpcReceiver : global::BNCHMDKHKLM<TRpcParam> where TDeps : global::MBJOFPMJNMO<TObject, TPlayer, TRpcParam, TSyncField, TSyncFieldParam, TSyncFieldValue>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly TDeps CALHALNNKLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private global::GEJFNEKJJOI<JAIHIEKEHOM, global::LCHLHMGLGMF<TObject, TRpcParam, TRpcReceiver>> EFIEFJBBPDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private global::GEJFNEKJJOI<FAPEGLKNBBF, global::HENMBGALADD<TSyncField>> NDDMHIHAKKF;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public TPlayer CEOCLGGEKNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x27BE2D0", Offset = "0x27BCCD0", VA = "0x1827BE2D0")]
		get
		{
			return (TPlayer)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x27BF220", Offset = "0x27BDC20", VA = "0x1827BF220")]
	public TSyncField GJEOIFHMEAI(global::MILDMIBLDIO<FAPEGLKNBBF> OPHCOPAJHLF)
	{
		return (TSyncField)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x27C0240", Offset = "0x27BEC40", VA = "0x1827C0240")]
	protected KJLOFFLDEGK(in TDeps MOAJGIGLIIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x27BFEC0", Offset = "0x27BE8C0", VA = "0x1827BFEC0")]
	public static global::KJLOFFLDEGK<TObject, TPlayer, TRpcParam, TRpcReceiver, TSyncField, TSyncFieldParam, TSyncFieldValue, TDeps> NDGDIJBCNJC(in TDeps MOAJGIGLIIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x27BE900", Offset = "0x27BD300", VA = "0x1827BE900", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x27BE260", Offset = "0x27BCC60", VA = "0x1827BE260")]
	public global::MILDMIBLDIO<JAIHIEKEHOM> ADHCIKIHOJE(in TObject PDHKCBEBPNG)
	{
		return default(global::MILDMIBLDIO<JAIHIEKEHOM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x27BF120", Offset = "0x27BDB20", VA = "0x1827BF120")]
	public void FEKMLJKHEGB(global::MILDMIBLDIO<JAIHIEKEHOM> PDHKCBEBPNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x27BFF90", Offset = "0x27BE990", VA = "0x1827BFF90")]
	public void NMNMCHGCIIA(global::MILDMIBLDIO<JAIHIEKEHOM> PDHKCBEBPNG, in TRpcParam HOCPDJAJOIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x27BEDE0", Offset = "0x27BD7E0", VA = "0x1827BEDE0")]
	public void EAEAJBGPKDB(global::MILDMIBLDIO<JAIHIEKEHOM> PDHKCBEBPNG, in TRpcParam HOCPDJAJOIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x27C0020", Offset = "0x27BEA20", VA = "0x1827C0020")]
	public void OEGMLIJDIGC(global::MILDMIBLDIO<JAIHIEKEHOM> PDHKCBEBPNG, in TRpcParam HOCPDJAJOIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x27BEE80", Offset = "0x27BD880", VA = "0x1827BEE80")]
	public void EOJCOOEOEEE(global::MILDMIBLDIO<JAIHIEKEHOM> PDHKCBEBPNG, in TRpcParam HOCPDJAJOIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x27BF280", Offset = "0x27BDC80", VA = "0x1827BF280")]
	public void JCMOHOCAJMD(global::MILDMIBLDIO<JAIHIEKEHOM> PDHKCBEBPNG, in TRpcParam HOCPDJAJOIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x27BF240", Offset = "0x27BDC40", VA = "0x1827BF240")]
	public void JAHFAOMDJCL(global::MILDMIBLDIO<JAIHIEKEHOM> PDHKCBEBPNG, in TRpcReceiver EOHIKAPDMOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x27BE170", Offset = "0x27BCB70", VA = "0x1827BE170")]
	public TPlayer ACLKABFCJIG(global::MILDMIBLDIO<JAIHIEKEHOM> PDHKCBEBPNG)
	{
		return (TPlayer)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x27BF3D0", Offset = "0x27BDDD0", VA = "0x1827BF3D0")]
	public bool LFCPNKNNIPH(global::MILDMIBLDIO<JAIHIEKEHOM> PDHKCBEBPNG, in TPlayer IBALNAIHOLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x27BF4C0", Offset = "0x27BDEC0", VA = "0x1827BF4C0")]
	public global::MILDMIBLDIO<FAPEGLKNBBF> MKLGEOOCGDM(global::MILDMIBLDIO<JAIHIEKEHOM> PDHKCBEBPNG, in TSyncFieldParam HOCPDJAJOIH)
	{
		return default(global::MILDMIBLDIO<FAPEGLKNBBF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x27BE330", Offset = "0x27BCD30", VA = "0x1827BE330")]
	public void BFFFKFHGBKK(global::MILDMIBLDIO<FAPEGLKNBBF> GDNKGMIJILA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x27C0150", Offset = "0x27BEB50", VA = "0x1827C0150")]
	public void PIGDDNAIOFI(global::MILDMIBLDIO<FAPEGLKNBBF> FELFGFPIGEP, in TSyncFieldValue NKJMIDIDBOE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
internal struct LCHLHMGLGMF<TObject, TRpcParam, TRpcReceiver> where TRpcReceiver : global::BNCHMDKHKLM<TRpcParam>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly HashSet<global::MILDMIBLDIO<FAPEGLKNBBF>> PIDHJEKCEBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly TObject NIMBJBDLMNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public TRpcReceiver EIBHJOHIDDG;

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x1B6BA00", Offset = "0x1B6A400", VA = "0x181B6BA00")]
	private LCHLHMGLGMF(HashSet<global::MILDMIBLDIO<FAPEGLKNBBF>> CEPIFFAPJPA, in TObject PDHKCBEBPNG, in TRpcReceiver EOHIKAPDMOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x1B6B800", Offset = "0x1B6A200", VA = "0x181B6B800")]
	public static global::LCHLHMGLGMF<TObject, TRpcParam, TRpcReceiver> NDGDIJBCNJC(in TObject PDHKCBEBPNG)
	{
		return default(global::LCHLHMGLGMF<TObject, TRpcParam, TRpcReceiver>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
internal static class BCGDGCLEOIK<TRpcParam, TRpcReceiver> where TRpcReceiver : global::BNCHMDKHKLM<TRpcParam>
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x179F8B0", Offset = "0x179E2B0", VA = "0x18179F8B0")]
	public static global::LCHLHMGLGMF<TObject, TRpcParam, TRpcReceiver> NDGDIJBCNJC<TObject>(in TObject PDHKCBEBPNG)
	{
		return default(global::LCHLHMGLGMF<TObject, TRpcParam, TRpcReceiver>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal struct HENMBGALADD<TSyncField>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public readonly TSyncField KLGBFJDPLDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public readonly global::MILDMIBLDIO<JAIHIEKEHOM> IGCLFOFEBAJ;

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x2675C10", Offset = "0x2674610", VA = "0x182675C10")]
	private HENMBGALADD(in TSyncField OPHCOPAJHLF, global::MILDMIBLDIO<JAIHIEKEHOM> DJOBHMHEKMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x2675B00", Offset = "0x2674500", VA = "0x182675B00")]
	public static global::HENMBGALADD<TSyncField> NDGDIJBCNJC(in TSyncField OPHCOPAJHLF, global::MILDMIBLDIO<JAIHIEKEHOM> DJOBHMHEKMD)
	{
		return default(global::HENMBGALADD<TSyncField>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal static class KDLGOEJILEE
{
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x1775030", Offset = "0x1773A30", VA = "0x181775030")]
	public static global::HENMBGALADD<TSyncField> NDGDIJBCNJC<TSyncField>(in TSyncField OPHCOPAJHLF, global::MILDMIBLDIO<JAIHIEKEHOM> DJOBHMHEKMD)
	{
		return default(global::HENMBGALADD<TSyncField>);
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
