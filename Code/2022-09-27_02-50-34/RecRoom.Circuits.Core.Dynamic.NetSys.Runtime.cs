using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface DGDHDIDALCH<TObject, TPlayer, TRpcParam, TSyncField, TSyncFieldParam, TSyncFieldValue>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	TPlayer BGBLIKAGEOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MAAKINHEMBE(in TObject PBKPNJLDBOM, in TRpcParam DPMFCNNBNAK);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MGFMKCDJNEL(in TObject PBKPNJLDBOM, in TRpcParam DPMFCNNBNAK);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JKFFPPFFDIE(in TObject PBKPNJLDBOM, in TRpcParam DPMFCNNBNAK);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CCMMBEHFLJD(in TObject PBKPNJLDBOM, in TRpcParam DPMFCNNBNAK);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	TPlayer GMGDOAFPENB(in TObject PBKPNJLDBOM);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool OMDFFEHOKAN(in TObject PBKPNJLDBOM, in TPlayer DGFKMAMLEOJ);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "7")]
	TSyncField EHJDIFOIIHN(in global::JMIGNGAIFLD<HPCJBKMJBIE> PBHKOJIKFGJ, in TObject PBKPNJLDBOM, in TSyncFieldParam DPMFCNNBNAK);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void JJIOEIOLFAP(in TSyncField DPMFCNNBNAK);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void AIJHAICCFNC(in TSyncField MLCDMIIKCEK, in TSyncFieldValue ADBNEBBHMOP);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public sealed class KBDFBHLBJBL
{
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public sealed class HPCJBKMJBIE
{
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class OEBNHAFKJMK<TObject, TPlayer, TRpcParam, TRpcReceiver, TSyncField, TSyncFieldParam, TSyncFieldValue, TDeps> : IDisposable, global::FPLCENIILML<global::JMIGNGAIFLD<KBDFBHLBJBL>, TPlayer, TRpcParam, TRpcReceiver, global::JMIGNGAIFLD<HPCJBKMJBIE>, TSyncFieldParam, TSyncFieldValue> where TRpcReceiver : global::KKCMPJKCAJH<TRpcParam> where TDeps : global::DGDHDIDALCH<TObject, TPlayer, TRpcParam, TSyncField, TSyncFieldParam, TSyncFieldValue>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly TDeps BAPDCJKANBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly global::ELKBIOFAKIP<KBDFBHLBJBL, global::FJEOEOJDCOJ<TObject, TRpcParam, TRpcReceiver>> DPAIFAMCJBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly global::ELKBIOFAKIP<HPCJBKMJBIE, global::KAOKENGPKPH<TSyncField>> JLCFNKBHGPK;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public TPlayer BGBLIKAGEOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x1E07AA0", Offset = "0x1E06CA0", VA = "0x181E07AA0", Slot = "5")]
		get
		{
			return (TPlayer)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x1E06630", Offset = "0x1E05830", VA = "0x181E06630")]
	public TSyncField BFHJNHADJDD(global::JMIGNGAIFLD<HPCJBKMJBIE> IMDJNBMDOOI)
	{
		return (TSyncField)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x1E089E0", Offset = "0x1E07BE0", VA = "0x181E089E0")]
	protected OEBNHAFKJMK(in TDeps BINNMIIOOPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x1E07C00", Offset = "0x1E06E00", VA = "0x181E07C00")]
	public static global::OEBNHAFKJMK<TObject, TPlayer, TRpcParam, TRpcReceiver, TSyncField, TSyncFieldParam, TSyncFieldValue, TDeps> HCEINCHCOLK(in TDeps BINNMIIOOPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x1E06700", Offset = "0x1E05900", VA = "0x181E06700", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x1E07F00", Offset = "0x1E07100", VA = "0x181E07F00")]
	public global::JMIGNGAIFLD<KBDFBHLBJBL> IJBMCMKMJGB(in TObject PBKPNJLDBOM)
	{
		return default(global::JMIGNGAIFLD<KBDFBHLBJBL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x1E08660", Offset = "0x1E07860", VA = "0x181E08660")]
	public void LIDJCODGNGF(in global::JMIGNGAIFLD<KBDFBHLBJBL> PBKPNJLDBOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1E07E70", Offset = "0x1E07070", VA = "0x181E07E70")]
	public void IDCNMOMEJNN(in global::JMIGNGAIFLD<KBDFBHLBJBL> PBKPNJLDBOM, in TRpcParam DPMFCNNBNAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x1E08770", Offset = "0x1E07970", VA = "0x181E08770")]
	public void MAAKINHEMBE(in global::JMIGNGAIFLD<KBDFBHLBJBL> PBKPNJLDBOM, in TRpcParam DPMFCNNBNAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x1E08810", Offset = "0x1E07A10", VA = "0x181E08810")]
	public void MGFMKCDJNEL(in global::JMIGNGAIFLD<KBDFBHLBJBL> PBKPNJLDBOM, in TRpcParam DPMFCNNBNAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x1E082E0", Offset = "0x1E074E0", VA = "0x181E082E0")]
	public void JKFFPPFFDIE(in global::JMIGNGAIFLD<KBDFBHLBJBL> PBKPNJLDBOM, in TRpcParam DPMFCNNBNAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x1E06660", Offset = "0x1E05860", VA = "0x181E06660")]
	public void CCMMBEHFLJD(in global::JMIGNGAIFLD<KBDFBHLBJBL> PBKPNJLDBOM, in TRpcParam DPMFCNNBNAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x1E07A50", Offset = "0x1E06C50", VA = "0x181E07A50")]
	public void FMEHKFCOGOI(in global::JMIGNGAIFLD<KBDFBHLBJBL> PBKPNJLDBOM, in TRpcReceiver MHJFFHABNNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x1E07B00", Offset = "0x1E06D00", VA = "0x181E07B00")]
	public TPlayer GMGDOAFPENB(in global::JMIGNGAIFLD<KBDFBHLBJBL> PBKPNJLDBOM)
	{
		return (TPlayer)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x1E088E0", Offset = "0x1E07AE0", VA = "0x181E088E0")]
	public bool OMDFFEHOKAN(in global::JMIGNGAIFLD<KBDFBHLBJBL> PBKPNJLDBOM, in TPlayer DGFKMAMLEOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x1E07350", Offset = "0x1E06550", VA = "0x181E07350")]
	public global::JMIGNGAIFLD<HPCJBKMJBIE> EHJDIFOIIHN(in global::JMIGNGAIFLD<KBDFBHLBJBL> PBKPNJLDBOM, in TSyncFieldParam DPMFCNNBNAK)
	{
		return default(global::JMIGNGAIFLD<HPCJBKMJBIE>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x1E080A0", Offset = "0x1E072A0", VA = "0x181E080A0")]
	public void JJIOEIOLFAP(in global::JMIGNGAIFLD<HPCJBKMJBIE> EJDGPDCKHGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x1E07D70", Offset = "0x1E06F70", VA = "0x181E07D70")]
	public void HOBOGEIKABK(in global::JMIGNGAIFLD<HPCJBKMJBIE> MLCDMIIKCEK, in TSyncFieldValue ADBNEBBHMOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0xF37FA0", Offset = "0xF371A0", VA = "0x180F37FA0", Slot = "6")]
	private void FNBPFEJNNAB(in global::JMIGNGAIFLD<KBDFBHLBJBL> PBKPNJLDBOM, in TRpcParam DPMFCNNBNAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x1E08410", Offset = "0x1E07610", VA = "0x181E08410", Slot = "7")]
	private void LDCHEFJOKFF(in global::JMIGNGAIFLD<KBDFBHLBJBL> PBKPNJLDBOM, in TRpcParam DPMFCNNBNAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0xF38000", Offset = "0xF37200", VA = "0x180F38000", Slot = "8")]
	private void LHMHNDLEGPC(in global::JMIGNGAIFLD<KBDFBHLBJBL> PBKPNJLDBOM, in TRpcParam DPMFCNNBNAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0xF37C70", Offset = "0xF36E70", VA = "0x180F37C70", Slot = "9")]
	private void MBKLABNKAEP(in global::JMIGNGAIFLD<KBDFBHLBJBL> PBKPNJLDBOM, in TRpcParam DPMFCNNBNAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x1E083E0", Offset = "0x1E075E0", VA = "0x181E083E0", Slot = "10")]
	private void LCNFMINEDEA(in global::JMIGNGAIFLD<KBDFBHLBJBL> PBKPNJLDBOM, in TRpcReceiver MHJFFHABNNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x1E08380", Offset = "0x1E07580", VA = "0x181E08380", Slot = "11")]
	private TPlayer KBDOHAHDJBO(in global::JMIGNGAIFLD<KBDFBHLBJBL> PBKPNJLDBOM)
	{
		return (TPlayer)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x1E07A20", Offset = "0x1E06C20", VA = "0x181E07A20", Slot = "12")]
	private bool FKEBGPBMGGG(in global::JMIGNGAIFLD<KBDFBHLBJBL> PBKPNJLDBOM, in TPlayer DGFKMAMLEOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x1E079F0", Offset = "0x1E06BF0", VA = "0x181E079F0", Slot = "13")]
	private global::JMIGNGAIFLD<HPCJBKMJBIE> FJEMKNIMOCP(in global::JMIGNGAIFLD<KBDFBHLBJBL> PBKPNJLDBOM, in TSyncFieldParam DPMFCNNBNAK)
	{
		return default(global::JMIGNGAIFLD<HPCJBKMJBIE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x1E083B0", Offset = "0x1E075B0", VA = "0x181E083B0", Slot = "14")]
	private void KEIIOLDKNJB(in global::JMIGNGAIFLD<HPCJBKMJBIE> MLCDMIIKCEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x1E088B0", Offset = "0x1E07AB0", VA = "0x181E088B0", Slot = "15")]
	private void NDPHEJADMJM(in global::JMIGNGAIFLD<HPCJBKMJBIE> MLCDMIIKCEK, in TSyncFieldValue ADBNEBBHMOP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal struct FJEOEOJDCOJ<TObject, TRpcParam, TRpcReceiver> where TRpcReceiver : global::KKCMPJKCAJH<TRpcParam>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly HashSet<global::JMIGNGAIFLD<HPCJBKMJBIE>> CAKHNLFLJFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly TObject INCLDCFEKDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public TRpcReceiver DALAIPHIIOK;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x48542A0", Offset = "0x48534A0", VA = "0x1848542A0")]
	private FJEOEOJDCOJ(HashSet<global::JMIGNGAIFLD<HPCJBKMJBIE>> NLDIHGFKJFE, in TObject PBKPNJLDBOM, in TRpcReceiver MHJFFHABNNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x48540D0", Offset = "0x48532D0", VA = "0x1848540D0")]
	public static global::FJEOEOJDCOJ<TObject, TRpcParam, TRpcReceiver> HCEINCHCOLK(in TObject PBKPNJLDBOM)
	{
		return default(global::FJEOEOJDCOJ<TObject, TRpcParam, TRpcReceiver>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
internal static class JCILMBKHHMM<TRpcParam, TRpcReceiver> where TRpcReceiver : global::KKCMPJKCAJH<TRpcParam>
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3839AA0", Offset = "0x3838CA0", VA = "0x183839AA0")]
	public static global::FJEOEOJDCOJ<TObject, TRpcParam, TRpcReceiver> HCEINCHCOLK<TObject>(in TObject PBKPNJLDBOM)
	{
		return default(global::FJEOEOJDCOJ<TObject, TRpcParam, TRpcReceiver>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
internal struct KAOKENGPKPH<TSyncField>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public readonly TSyncField NICEIHJBMJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public readonly global::JMIGNGAIFLD<KBDFBHLBJBL> IOBODGAEJAO;

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x133E370", Offset = "0x133D570", VA = "0x18133E370")]
	private KAOKENGPKPH(in TSyncField IMDJNBMDOOI, in global::JMIGNGAIFLD<KBDFBHLBJBL> PNJFJEGLKJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x133E2B0", Offset = "0x133D4B0", VA = "0x18133E2B0")]
	public static global::KAOKENGPKPH<TSyncField> HCEINCHCOLK(in TSyncField IMDJNBMDOOI, in global::JMIGNGAIFLD<KBDFBHLBJBL> PNJFJEGLKJP)
	{
		return default(global::KAOKENGPKPH<TSyncField>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal static class LEFNFJHMGLF
{
	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x3CB9850", Offset = "0x3CB8A50", VA = "0x183CB9850")]
	public static global::KAOKENGPKPH<TSyncField> HCEINCHCOLK<TSyncField>(in TSyncField IMDJNBMDOOI, in global::JMIGNGAIFLD<KBDFBHLBJBL> PNJFJEGLKJP)
	{
		return default(global::KAOKENGPKPH<TSyncField>);
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
