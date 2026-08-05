using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7DAB80", Offset = "0x7D9780", VA = "0x1807DAB80")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6163B50", Offset = "0x6162750", VA = "0x186163B50")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7DB530", Offset = "0x7DA130", VA = "0x1807DB530")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7DB570", Offset = "0x7DA170", VA = "0x1807DB570")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface DGFDLAHPGBM<TData, TReturn>
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TReturn CMDLJDJPAFB(TData OGGNGHKHHGI);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface IPNBNDLDJGK<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ClearHoverTarget(BKLNJCPBHNE MILMKHJOBAL);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool SetHoverTarget(TData PMKKKDOAOBE, Collider HFKFCPOBAOJ, BKLNJCPBHNE MILMKHJOBAL, [Optional] HMGGEEBIJCM? BKGPAHKJMKO);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool TryGetHoverTarget([Out] TData PMKKKDOAOBE);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool TryGetHoverCollider([Out] Collider HFKFCPOBAOJ);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface HAOAONENPGJ<TData> : HAGDAEFJHLN, ADDGFNEIEDK<TData>, HGDNFHNELDP<TData>, GGMNNCFIANI<TData>, PLCDDCBGLLC, JLIOCBBBDBN<TData>, KBMPBNJIJPI, LIBPPCLMDIJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface JLIOCBBBDBN<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool Raycast(Vector3 OABPANPBJFB, Vector3 MPBHICGGLEH, float BFEIMLNJNAB, [Out] T CGIPKBJNHIC, [Out] Vector3 NKMICNGPKNL, [Out] Collider HFKFCPOBAOJ);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int SpherecastPick(Vector3 OABPANPBJFB, Vector3 MPBHICGGLEH, float ADDOMPHLJMM, float BFEIMLNJNAB, T[] CBAGPDCOGFA, [Out] Vector3 PHEEBDJNCHL, [Out] Collider KNAJFMPENEP);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int SpherePick(Vector3 OABPANPBJFB, float ADDOMPHLJMM, Vector3 GIMMMKODOOF, T[] CBAGPDCOGFA);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool TryGetObjectFromColliderInCurrentScope(Collider HBMPMDPKNON, [Out] T EACIJNAJJOI);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface HAGDAEFJHLN
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Bounds BEMJBLKNFCB
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	Transform HNDPLOHJMJF
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	Bounds ANAPJGKPMHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Transform IDDMCFDAGPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	Vector3 JEAAOAJOKIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool JLMBAJOFGAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void SetSelectionBoundsDirty(bool AEEKAPGAODN = true, int BCPCDGJKGLI = 0);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ShouldHideSelectionBoundsPreview(bool FPBOCGEEJHG, object DGPOLLDAHJK);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface LIBPPCLMDIJ
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	GPEAFMNAGCL NAPJFMBIKKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface CEABMAPOIIC
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool KKNHNLGMOOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool NBDIDLOFEBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool MKOJJACBIBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Dictionary<Guid, Guid> TryGetPreviousCloneMapping();

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void TrySetPreviousCloneMapping(Dictionary<Guid, Guid> MBMIEEAHALE);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface GGMNNCFIANI<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool HFAPIKEACNN
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	int JNKHIPHKOKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<TData> LLCAPLJDBEL
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IsSelected(TData ILDOLMKGCCL);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IsSelectable(TData ILDOLMKGCCL);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface ADDGFNEIEDK<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void RenderHoverHighlight(T OGGNGHKHHGI, [Optional] HMGGEEBIJCM? PGMGJAILCNF, bool CDFNKOJEFGO = true);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RenderHoverHighlight(int MAJIECOCCAC, IEnumerable<T> AJGJFJPCBKM, bool CDFNKOJEFGO = true);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RenderHoverHighlight(int MAJIECOCCAC, IEnumerable<T> AJGJFJPCBKM, HMGGEEBIJCM PGMGJAILCNF, bool CDFNKOJEFGO = true);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface KBMPBNJIJPI
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnSelectionPickedUp();

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnSelectionReleased();
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface PLCDDCBGLLC
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool COPFDCMIOPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool LALGPGAJDNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	bool PFHLKKODMHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	bool NICENNIAHDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public abstract class FKDLNBBKBMI<TReceiver> : CFMIHLNFDHN<TReceiver, bool> where TReceiver : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3307360", Offset = "0x3305F60", VA = "0x183307360")]
	public FKDLNBBKBMI(TReceiver IPJAHGCJIBA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public abstract class EDGODNJKMEA<TReceiver, TFromTask> : CFMIHLNFDHN<TReceiver, Task<TFromTask>>
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3307360", Offset = "0x3305F60", VA = "0x183307360")]
	public EDGODNJKMEA(TReceiver IPJAHGCJIBA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public abstract class CFMIHLNFDHN<TReceiver, TFromExecute> where TReceiver : notnull where TFromExecute : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	protected TReceiver IPJAHGCJIBA;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x4AEE980", Offset = "0x4AED580", VA = "0x184AEE980")]
	public CFMIHLNFDHN(TReceiver IPJAHGCJIBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TFromExecute KHPMIBODMCP();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public abstract class MBINFGAMCHL<TReceiver, TResult> : CFMIHLNFDHN<TReceiver, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3307360", Offset = "0x3305F60", VA = "0x183307360")]
	public MBINFGAMCHL(TReceiver IPJAHGCJIBA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct KHGDKFCHGOM<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public TGroup NLDKCFOKIKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public TData MFHOAAJBOOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public IEnumerable<TData> HMGDFJBDPJF;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x1B2AFD0", Offset = "0x1B29BD0", VA = "0x181B2AFD0")]
	public KHGDKFCHGOM(TGroup IMOFHKDKEDI, TData LHCDEIHIBKG, IEnumerable<TData> KLADOHEIHEN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct GPECDFIJOLM<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public TGroup NLDKCFOKIKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public IEnumerable<TData> HMGDFJBDPJF;

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x902320", Offset = "0x900F20", VA = "0x180902320")]
	public GPECDFIJOLM(TGroup IMOFHKDKEDI, IEnumerable<TData> KLADOHEIHEN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct APADFPFGOJI<TGroup> where TGroup : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public TGroup NLDKCFOKIKB;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x93C290", Offset = "0x93AE90", VA = "0x18093C290")]
	public APADFPFGOJI(TGroup IMOFHKDKEDI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct DKLOKNHIFJP<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public IEnumerable<TData> HMGDFJBDPJF;

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x93C290", Offset = "0x93AE90", VA = "0x18093C290")]
	public DKLOKNHIFJP(IEnumerable<TData> KLADOHEIHEN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface BILNJNHPACD<TGroup, TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NIDJCDKEMDF MHHPCKFNGGH(KHGDKFCHGOM<TGroup, TData> KKIIJFIBGHH);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NIDJCDKEMDF JHBHBMLMGAH(KHGDKFCHGOM<TGroup, TData> KKIIJFIBGHH);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "2")]
	NIDJCDKEMDF AEJEDCGPCKM(GPECDFIJOLM<TGroup, TData> KKIIJFIBGHH);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "3")]
	NIDJCDKEMDF FEGEDLKDOBC(APADFPFGOJI<TGroup> KKIIJFIBGHH);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface INGDFDONGFF<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<NIDJCDKEMDF> MHHPCKFNGGH(DKLOKNHIFJP<TData> KKIIJFIBGHH);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class AEMFPNCCJID<TGroup, TData> : MBINFGAMCHL<BILNJNHPACD<TGroup, TData>, NIDJCDKEMDF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly GPECDFIJOLM<TGroup, TData> KKIIJFIBGHH;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x37C4E20", Offset = "0x37C3A20", VA = "0x1837C4E20")]
	public AEMFPNCCJID(TGroup IMOFHKDKEDI, IEnumerable<TData> KLADOHEIHEN, BILNJNHPACD<TGroup, TData> IPJAHGCJIBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x37C4D50", Offset = "0x37C3950", VA = "0x1837C4D50", Slot = "4")]
	public override NIDJCDKEMDF KHPMIBODMCP()
	{
		return default(NIDJCDKEMDF);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class CICGHDOOOCJ<TGroup, TData> : MBINFGAMCHL<BILNJNHPACD<TGroup, TData>, NIDJCDKEMDF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly KHGDKFCHGOM<TGroup, TData> KKIIJFIBGHH;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x334C880", Offset = "0x334B480", VA = "0x18334C880")]
	public CICGHDOOOCJ(TGroup IMOFHKDKEDI, TData CDNOKMAEOFC, IEnumerable<TData> KLADOHEIHEN, BILNJNHPACD<TGroup, TData> IPJAHGCJIBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x4BBFC00", Offset = "0x4BBE800", VA = "0x184BBFC00", Slot = "4")]
	public override NIDJCDKEMDF KHPMIBODMCP()
	{
		return default(NIDJCDKEMDF);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class PMJBEJJLDBJ<TGroup, TData> : MBINFGAMCHL<BILNJNHPACD<TGroup, TData>, NIDJCDKEMDF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly APADFPFGOJI<TGroup> KKIIJFIBGHH;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x332A970", Offset = "0x3329570", VA = "0x18332A970")]
	public PMJBEJJLDBJ(TGroup IMOFHKDKEDI, BILNJNHPACD<TGroup, TData> IPJAHGCJIBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x411E8B0", Offset = "0x411D4B0", VA = "0x18411E8B0", Slot = "4")]
	public override NIDJCDKEMDF KHPMIBODMCP()
	{
		return default(NIDJCDKEMDF);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class EMOAFBFGJND<TGroup, TData> : MBINFGAMCHL<BILNJNHPACD<TGroup, TData>, NIDJCDKEMDF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly KHGDKFCHGOM<TGroup, TData> KKIIJFIBGHH;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x334C880", Offset = "0x334B480", VA = "0x18334C880")]
	public EMOAFBFGJND(TGroup IMOFHKDKEDI, TData LHCDEIHIBKG, IEnumerable<TData> KLADOHEIHEN, BILNJNHPACD<TGroup, TData> IPJAHGCJIBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x334C7A0", Offset = "0x334B3A0", VA = "0x18334C7A0", Slot = "4")]
	public override NIDJCDKEMDF KHPMIBODMCP()
	{
		return default(NIDJCDKEMDF);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class ELBHPKGMBMP<TData> : EDGODNJKMEA<INGDFDONGFF<TData>, NIDJCDKEMDF> where TData : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private struct CLHKCFHPJEH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public AsyncTaskMethodBuilder<NIDJCDKEMDF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public ELBHPKGMBMP<TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private TaskAwaiter<NIDJCDKEMDF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x4C93850", Offset = "0x4C92450", VA = "0x184C93850", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x4C93AF0", Offset = "0x4C926F0", VA = "0x184C93AF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private DKLOKNHIFJP<TData> KKIIJFIBGHH;

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x332A970", Offset = "0x3329570", VA = "0x18332A970")]
	public ELBHPKGMBMP(IEnumerable<TData> LPBILDMDFGE, INGDFDONGFF<TData> IPJAHGCJIBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3345550", Offset = "0x3344150", VA = "0x183345550", Slot = "4")]
	[AsyncStateMachine(typeof(ELBHPKGMBMP<>.CLHKCFHPJEH))]
	public override Task<NIDJCDKEMDF> KHPMIBODMCP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public readonly struct DDHGFMDDDND
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly EJOCIDPLJFI NONCADNCDFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly bool KBPAFMDPGCL;

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6162A80", Offset = "0x6161680", VA = "0x186162A80")]
	public DDHGFMDDDND(EJOCIDPLJFI MMEAPCMFPCE, bool BBAIOGACFOI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface MNHEGIKIKLJ<TSpawnType> where TSpawnType : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> KHPMIBODMCP(DDHGFMDDDND PCCEIHCFCHM);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class BACAHABCMDK<TSpawnType> : EDGODNJKMEA<MNHEGIKIKLJ<TSpawnType>, TSpawnType> where TSpawnType : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private struct IAEILEGHBHN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public AsyncTaskMethodBuilder<TSpawnType> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public BACAHABCMDK<TSpawnType> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private TaskAwaiter<TSpawnType> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x3923FE0", Offset = "0x3922BE0", VA = "0x183923FE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x37F96E0", Offset = "0x37F82E0", VA = "0x1837F96E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly DDHGFMDDDND PCCEIHCFCHM;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x4733E00", Offset = "0x4732A00", VA = "0x184733E00")]
	public BACAHABCMDK(EJOCIDPLJFI MMEAPCMFPCE, bool BBAIOGACFOI, MNHEGIKIKLJ<TSpawnType> IPJAHGCJIBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x4733D00", Offset = "0x4732900", VA = "0x184733D00", Slot = "4")]
	[AsyncStateMachine(typeof(BACAHABCMDK<>.IAEILEGHBHN))]
	public override Task<TSpawnType> KHPMIBODMCP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public readonly struct EJOCIDPLJFI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly bool EFBECCMKLDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public readonly Vector3 PCKLNGGEIMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly Vector3 KMIPHHDCLED;

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6162F60", Offset = "0x6161B60", VA = "0x186162F60")]
	public EJOCIDPLJFI(Transform FCNOIPLMHNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6162F30", Offset = "0x6161B30", VA = "0x186162F30")]
	public EJOCIDPLJFI(Vector3 JJMOIFJMOBF, Vector3 GMKEEAOHFFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6162F00", Offset = "0x6161B00", VA = "0x186162F00")]
	public static EJOCIDPLJFI HAJEGJOEBAB()
	{
		return default(EJOCIDPLJFI);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6162FD0", Offset = "0x6161BD0", VA = "0x186162FD0")]
	private EJOCIDPLJFI(bool NGBGPMEMAHB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public struct BNPCLLDDEFC<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public TNode GINECKHKCAP;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x47FC990", Offset = "0x47FB590", VA = "0x1847FC990")]
	public BNPCLLDDEFC(TNode GINECKHKCAP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct CLOIEEGEKOF<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public TNode LOPKKOBFFEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public GKCNKDGHGBG IKGIAGBHMPM;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x4C94430", Offset = "0x4C93030", VA = "0x184C94430")]
	public CLOIEEGEKOF(TNode LOPKKOBFFEN, GKCNKDGHGBG IKGIAGBHMPM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface FEFEEDLANMF<TNode>
{
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CKNJDAIMNNK([In] BNPCLLDDEFC<TNode> JDLJCPHLDGB);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MHEFJNKJLGG([In] CLOIEEGEKOF<TNode> PHOKAEHFCBE);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool CJLOBGKJAHE();
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class KFONEDNAEIK<TNode> : FKDLNBBKBMI<FEFEEDLANMF<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x3307360", Offset = "0x3305F60", VA = "0x183307360")]
	public KFONEDNAEIK(FEFEEDLANMF<TNode> IPJAHGCJIBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x368F810", Offset = "0x368E410", VA = "0x18368F810", Slot = "4")]
	public override bool KHPMIBODMCP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class HKAMHIOHADM<TNode> : FKDLNBBKBMI<FEFEEDLANMF<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly CLOIEEGEKOF<TNode> PHOKAEHFCBE;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x3873050", Offset = "0x3871C50", VA = "0x183873050")]
	public HKAMHIOHADM(TNode LOPKKOBFFEN, GKCNKDGHGBG IKGIAGBHMPM, FEFEEDLANMF<TNode> IPJAHGCJIBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x367AAE0", Offset = "0x36796E0", VA = "0x18367AAE0", Slot = "4")]
	public override bool KHPMIBODMCP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class MKIHHJGCFDK<TNode> : FKDLNBBKBMI<FEFEEDLANMF<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly BNPCLLDDEFC<TNode> JDLJCPHLDGB;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x3E5C430", Offset = "0x3E5B030", VA = "0x183E5C430")]
	public MKIHHJGCFDK(TNode JMONNCNDANO, FEFEEDLANMF<TNode> IPJAHGCJIBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x332A8B0", Offset = "0x33294B0", VA = "0x18332A8B0", Slot = "4")]
	public override bool KHPMIBODMCP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct EPAOIDOPGMO<TSpawnInfo> where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public TSpawnInfo MOKCJDLCDGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public Vector3 GMKEEAOHFFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public Quaternion MJCNDCDLGEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public float LFFGFMIPECK;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x334EBB0", Offset = "0x334D7B0", VA = "0x18334EBB0")]
	public EPAOIDOPGMO(TSpawnInfo MOKCJDLCDGP, Vector3 GMKEEAOHFFK, Quaternion MJCNDCDLGEO, float LFFGFMIPECK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface CIJGCHHEELB<TSpawnType, TSpawnInfo>
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> KBDCKHOKNEG([In] EPAOIDOPGMO<TSpawnInfo> JALLHGCBGEE, CancellationToken EJGJLLMBDIN);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class KBDBPHHOJAF<TSpawnType, TSpawnInfo> : EDGODNJKMEA<CIJGCHHEELB<TSpawnType, TSpawnInfo>, TSpawnType> where TSpawnType : notnull where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly EPAOIDOPGMO<TSpawnInfo> PELDJLKMCIK;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x3B64D70", Offset = "0x3B63970", VA = "0x183B64D70")]
	public KBDBPHHOJAF(TSpawnInfo OEKIHDNGNML, Vector3 GMKEEAOHFFK, Quaternion MJCNDCDLGEO, float LFFGFMIPECK, CIJGCHHEELB<TSpawnType, TSpawnInfo> IPJAHGCJIBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3B2FB90", Offset = "0x3B2E790", VA = "0x183B2FB90", Slot = "4")]
	public override Task<TSpawnType> KHPMIBODMCP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public readonly struct CLLIGNFMNDC<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly IEnumerable<TData> HMGDFJBDPJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public readonly bool KBPAFMDPGCL;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x4C94130", Offset = "0x4C92D30", VA = "0x184C94130")]
	public CLLIGNFMNDC(IEnumerable<TData> KLADOHEIHEN, bool BBAIOGACFOI = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface KCDHBJKAFOL<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<NIDJCDKEMDF> NJJDFFMEKBK([In] CLLIGNFMNDC<TData> IIOAIOLEBGH, CancellationToken EJGJLLMBDIN);
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class JPJNPAEGPEK<TData> : EDGODNJKMEA<KCDHBJKAFOL<TData>, NIDJCDKEMDF> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly CLLIGNFMNDC<TData> BAEJJEODLLC;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x3B2FC70", Offset = "0x3B2E870", VA = "0x183B2FC70")]
	public JPJNPAEGPEK(IEnumerable<TData> KLADOHEIHEN, bool BBAIOGACFOI, KCDHBJKAFOL<TData> IPJAHGCJIBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x3B2FB90", Offset = "0x3B2E790", VA = "0x183B2FB90", Slot = "4")]
	public override Task<NIDJCDKEMDF> KHPMIBODMCP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct HFFBCBELDHG<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public readonly T PMKKKDOAOBE;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x37854B0", Offset = "0x37840B0", VA = "0x1837854B0")]
	public HFFBCBELDHG(T DCCIDBEDFOB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public interface EDPOGBBGDHJ<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CKNJDAIMNNK([In] HFFBCBELDHG<T> KEFAKLJHLCP);

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MHEFJNKJLGG();
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface DJDIEDJMGPP<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KHPMIBODMCP([In] IECGAKGDCGP<T> BGAOHNEFJHD);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct IECGAKGDCGP<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public readonly T PMKKKDOAOBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public readonly bool MEDGMHNFLKI;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x39337A0", Offset = "0x39323A0", VA = "0x1839337A0")]
	public IECGAKGDCGP(T DCCIDBEDFOB, bool LCFFENBFFPM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class JIDPDBFIOKL<T> : FKDLNBBKBMI<EDPOGBBGDHJ<T>> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x3307360", Offset = "0x3305F60", VA = "0x183307360")]
	public JIDPDBFIOKL(EDPOGBBGDHJ<T> IPJAHGCJIBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x3AFD800", Offset = "0x3AFC400", VA = "0x183AFD800", Slot = "4")]
	public override bool KHPMIBODMCP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public class EJBLOCIJMLB<T> : FKDLNBBKBMI<EDPOGBBGDHJ<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly HFFBCBELDHG<T> KEFAKLJHLCP;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x332A9E0", Offset = "0x33295E0", VA = "0x18332A9E0")]
	public EJBLOCIJMLB(T PMKKKDOAOBE, EDPOGBBGDHJ<T> IPJAHGCJIBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x332A8B0", Offset = "0x33294B0", VA = "0x18332A8B0", Slot = "4")]
	public override bool KHPMIBODMCP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public class CKHCIAMFAKP<T> : FKDLNBBKBMI<DJDIEDJMGPP<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly IECGAKGDCGP<T> BGAOHNEFJHD;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x4BCBE40", Offset = "0x4BCAA40", VA = "0x184BCBE40")]
	public CKHCIAMFAKP(T PMKKKDOAOBE, bool LCFFENBFFPM, DJDIEDJMGPP<T> IPJAHGCJIBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x332A8B0", Offset = "0x33294B0", VA = "0x18332A8B0", Slot = "4")]
	public override bool KHPMIBODMCP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct LOCICJMEBFJ<TData> where TData : notnull, GLLLDKHIMPH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public IEnumerable<TData> HMGDFJBDPJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public bool HMIKJOGLELP;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x3C43270", Offset = "0x3C41E70", VA = "0x183C43270")]
	public LOCICJMEBFJ(IEnumerable<TData> GADJJEOJHGH, bool EKBGOJIEDNG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public struct DBMCLNFJOAB<TData> where TData : notnull, GLLLDKHIMPH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public List<TData> HMGDFJBDPJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public List<bool> BEJMMNMNHAD;

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x50326D0", Offset = "0x50312D0", VA = "0x1850326D0")]
	public DBMCLNFJOAB(List<TData> GADJJEOJHGH, List<bool> ELOPBMANKOB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public interface GLLLDKHIMPH
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	bool CGHANHEDHGE
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface MLHDELIOONI<TData> where TData : GLLLDKHIMPH
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KHPMIBODMCP([In] LOCICJMEBFJ<TData> MCOLGEOKHNB);

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KHPMIBODMCP([In] DBMCLNFJOAB<TData> MCOLGEOKHNB);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface OPGNIKPOIIK<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HCHCHENEKMM(T PMKKKDOAOBE);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public class DAENKHNIPPK<TData> : FKDLNBBKBMI<MLHDELIOONI<TData>> where TData : notnull, GLLLDKHIMPH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly LOCICJMEBFJ<TData> MCOLGEOKHNB;

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x502E510", Offset = "0x502D110", VA = "0x18502E510")]
	public DAENKHNIPPK(List<TData> KLADOHEIHEN, bool HMIKJOGLELP, MLHDELIOONI<TData> IPJAHGCJIBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x332A8B0", Offset = "0x33294B0", VA = "0x18332A8B0", Slot = "4")]
	public override bool KHPMIBODMCP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public class NNNGCNBFFAN<TData> : FKDLNBBKBMI<MLHDELIOONI<TData>> where TData : notnull, GLLLDKHIMPH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly DBMCLNFJOAB<TData> MCOLGEOKHNB;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x3F4F210", Offset = "0x3F4DE10", VA = "0x183F4F210")]
	public NNNGCNBFFAN(List<TData> KLADOHEIHEN, List<bool> BEJMMNMNHAD, MLHDELIOONI<TData> IPJAHGCJIBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x3E1F930", Offset = "0x3E1E530", VA = "0x183E1F930", Slot = "4")]
	public override bool KHPMIBODMCP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface LKFENJAFBGK<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<NIDJCDKEMDF> KHPMIBODMCP(MNEHICEJBBI<TData> KHLPJJKGIEM);
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public class EPBHOCJMOEB<TData> : EDGODNJKMEA<LKFENJAFBGK<TData>, NIDJCDKEMDF> where TData : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private struct IINEFCCPLMG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public AsyncTaskMethodBuilder<NIDJCDKEMDF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public EPBHOCJMOEB<TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private TaskAwaiter<NIDJCDKEMDF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x3947480", Offset = "0x3946080", VA = "0x183947480", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x3947770", Offset = "0x3946370", VA = "0x183947770", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly MNEHICEJBBI<TData> IDGGPKCDKLN;

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x334ECE0", Offset = "0x334D8E0", VA = "0x18334ECE0")]
	public EPBHOCJMOEB(TData CBCFPHJFDML, IReadOnlyList<TData> BDIMOBPLJKG, bool BBAIOGACFOI, LKFENJAFBGK<TData> IPJAHGCJIBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x334EBE0", Offset = "0x334D7E0", VA = "0x18334EBE0", Slot = "4")]
	[AsyncStateMachine(typeof(EPBHOCJMOEB<>.IINEFCCPLMG))]
	public override Task<NIDJCDKEMDF> KHPMIBODMCP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public struct MNEHICEJBBI<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public TData OHKHBNABODE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public IReadOnlyList<TData> HCDCPIOPMLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public bool KBPAFMDPGCL;

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x3E8E870", Offset = "0x3E8D470", VA = "0x183E8E870")]
	public MNEHICEJBBI(TData CBCFPHJFDML, IReadOnlyList<TData> BDIMOBPLJKG, bool BBAIOGACFOI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public interface BOGGDBEMIHD<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KHPMIBODMCP([In] GNFNAJPABBI<TData> DDAGBBOPKCI);
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public interface ADHHNGLJEPP<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KHPMIBODMCP([In] CFKLBAAECLD<TData> DDAGBBOPKCI);
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface PIMOBKIAKPH<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NPHHKCKMGOK([In] NJFGLHHAKNP<TData> DDAGBBOPKCI);

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MHEFJNKJLGG();
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public class AHGCIANLMEM<TData> : FKDLNBBKBMI<BOGGDBEMIHD<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly GNFNAJPABBI<TData> DDAGBBOPKCI;

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x37CB910", Offset = "0x37CA510", VA = "0x1837CB910")]
	public AHGCIANLMEM(IEnumerable<TData> KLADOHEIHEN, NGIEHFKGLDJ IFKECNAKMLM, HJOGNBOCCHO PKJODJFPANA, float JGOBFAIMGFP, bool BBAIOGACFOI, BOGGDBEMIHD<TData> IPJAHGCJIBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x332A8B0", Offset = "0x33294B0", VA = "0x18332A8B0", Slot = "4")]
	public override bool KHPMIBODMCP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class IIPJKEGGDAK<TData> : FKDLNBBKBMI<ADHHNGLJEPP<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly CFKLBAAECLD<TData> DDAGBBOPKCI;

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x39481D0", Offset = "0x3946DD0", VA = "0x1839481D0")]
	public IIPJKEGGDAK(TData[] KLADOHEIHEN, NGIEHFKGLDJ[] IFKECNAKMLM, HJOGNBOCCHO[] PKJODJFPANA, float[] JGOBFAIMGFP, ADHHNGLJEPP<TData> IPJAHGCJIBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x37A98A0", Offset = "0x37A84A0", VA = "0x1837A98A0", Slot = "4")]
	public override bool KHPMIBODMCP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class PEKANDAOMNO<TData> : FKDLNBBKBMI<PIMOBKIAKPH<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x3307360", Offset = "0x3305F60", VA = "0x183307360")]
	public PEKANDAOMNO(PIMOBKIAKPH<TData> IPJAHGCJIBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x40FE4A0", Offset = "0x40FD0A0", VA = "0x1840FE4A0", Slot = "4")]
	public override bool KHPMIBODMCP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class GMBCGPGNGNI<TData> : FKDLNBBKBMI<PIMOBKIAKPH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly NJFGLHHAKNP<TData> DDAGBBOPKCI;

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x37A9960", Offset = "0x37A8560", VA = "0x1837A9960")]
	public GMBCGPGNGNI(IEnumerable<TData> KLADOHEIHEN, NGIEHFKGLDJ IFKECNAKMLM, HJOGNBOCCHO PKJODJFPANA, float JGOBFAIMGFP, PIMOBKIAKPH<TData> IPJAHGCJIBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x37A98A0", Offset = "0x37A84A0", VA = "0x1837A98A0", Slot = "4")]
	public override bool KHPMIBODMCP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public struct GNFNAJPABBI<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public IEnumerable<TData> HMGDFJBDPJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public NGIEHFKGLDJ DEHFKEFKIMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public HJOGNBOCCHO PGHAADBAFKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public float JGOBFAIMGFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public bool BBAIOGACFOI;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x37ACBC0", Offset = "0x37AB7C0", VA = "0x1837ACBC0")]
	public GNFNAJPABBI(IEnumerable<TData> KLADOHEIHEN, NGIEHFKGLDJ IFKECNAKMLM, HJOGNBOCCHO PKJODJFPANA, float JGOBFAIMGFP, bool BBAIOGACFOI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public struct CFKLBAAECLD<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public TData[] HMGDFJBDPJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public NGIEHFKGLDJ[] DEHFKEFKIMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public HJOGNBOCCHO[] PGHAADBAFKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public float[] JGOBFAIMGFP;

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x4AEDD20", Offset = "0x4AEC920", VA = "0x184AEDD20")]
	public CFKLBAAECLD(TData[] KLADOHEIHEN, NGIEHFKGLDJ[] IFKECNAKMLM, HJOGNBOCCHO[] PKJODJFPANA, float[] JGOBFAIMGFP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public struct NJFGLHHAKNP<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public IEnumerable<TData> HMGDFJBDPJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public NGIEHFKGLDJ DEHFKEFKIMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public HJOGNBOCCHO PGHAADBAFKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public float JGOBFAIMGFP;

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x3F332B0", Offset = "0x3F31EB0", VA = "0x183F332B0")]
	public NJFGLHHAKNP(IEnumerable<TData> KLADOHEIHEN, NGIEHFKGLDJ IFKECNAKMLM, HJOGNBOCCHO PKJODJFPANA, float JGOBFAIMGFP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public interface HGDNFHNELDP<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AEJEDCGPCKM([In] OJHMODDMGFM<TData> IIOAIOLEBGH);

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FEGEDLKDOBC([In] OJHMODDMGFM<TData> IIOAIOLEBGH);

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PMMCICKMLGM([In] bool JPGKKFFAIDM);

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool KHBILHKFCNA([In] OJHMODDMGFM<TData> IIOAIOLEBGH);

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CHEACGCJCBH();

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool CBPPAKHBCOG([In] TData AMGFKFIILFF);
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public class HBFOFGLADHK<TData> : FKDLNBBKBMI<HGDNFHNELDP<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private readonly OJHMODDMGFM<TData> IIOAIOLEBGH;

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x3802820", Offset = "0x3801420", VA = "0x183802820")]
	public HBFOFGLADHK(List<TData> MDLHOCLDHIN, HGDNFHNELDP<TData> IPJAHGCJIBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x332A8B0", Offset = "0x33294B0", VA = "0x18332A8B0", Slot = "4")]
	public override bool KHPMIBODMCP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public class NOGFJEKIPEC<TData> : FKDLNBBKBMI<HGDNFHNELDP<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x3307360", Offset = "0x3305F60", VA = "0x183307360")]
	public NOGFJEKIPEC(HGDNFHNELDP<TData> IPJAHGCJIBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x3F53840", Offset = "0x3F52440", VA = "0x183F53840", Slot = "4")]
	public override bool KHPMIBODMCP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class NAHDGEKNOFB<TData> : FKDLNBBKBMI<HGDNFHNELDP<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly bool BBAIOGACFOI;

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x3EDD3D0", Offset = "0x3EDBFD0", VA = "0x183EDD3D0")]
	public NAHDGEKNOFB(bool BBAIOGACFOI, HGDNFHNELDP<TData> IPJAHGCJIBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x3EDD370", Offset = "0x3EDBF70", VA = "0x183EDD370", Slot = "4")]
	public override bool KHPMIBODMCP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class MGNGJDPDDGL<TData> : FKDLNBBKBMI<HGDNFHNELDP<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly OJHMODDMGFM<TData> IIOAIOLEBGH;

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x3E1F9F0", Offset = "0x3E1E5F0", VA = "0x183E1F9F0")]
	public MGNGJDPDDGL(List<TData> MDLHOCLDHIN, bool BBAIOGACFOI, HGDNFHNELDP<TData> IPJAHGCJIBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x3E1F930", Offset = "0x3E1E530", VA = "0x183E1F930", Slot = "4")]
	public override bool KHPMIBODMCP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public class MJEHMLGIOJK<TData> : FKDLNBBKBMI<HGDNFHNELDP<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly TData AMGFKFIILFF;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x3E501D0", Offset = "0x3E4EDD0", VA = "0x183E501D0")]
	public MJEHMLGIOJK(TData AMGFKFIILFF, HGDNFHNELDP<TData> IPJAHGCJIBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x3E50100", Offset = "0x3E4ED00", VA = "0x183E50100", Slot = "4")]
	public override bool KHPMIBODMCP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class KLNKPAFOPGB<TData> : FKDLNBBKBMI<HGDNFHNELDP<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private readonly OJHMODDMGFM<TData> IIOAIOLEBGH;

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x3B76350", Offset = "0x3B74F50", VA = "0x183B76350")]
	public KLNKPAFOPGB(IEnumerable<TData> MDLHOCLDHIN, HGDNFHNELDP<TData> IPJAHGCJIBA, bool BBAIOGACFOI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x3B76280", Offset = "0x3B74E80", VA = "0x183B76280", Slot = "4")]
	public override bool KHPMIBODMCP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public struct OJHMODDMGFM<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public IEnumerable<TData> HMGDFJBDPJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public bool BBAIOGACFOI;

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x4029B00", Offset = "0x4028700", VA = "0x184029B00")]
	public OJHMODDMGFM(IEnumerable<TData> GADJJEOJHGH, bool IODHPKGPPKP = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public interface NLBMEIIDLJP
{
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<NIDJCDKEMDF> KHPMIBODMCP(BLDJEJKIMEP FJMFGPGACBB);
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public class PHKICHECANP : EDGODNJKMEA<NLBMEIIDLJP, NIDJCDKEMDF>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private struct IKOIJOLGCDA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public AsyncTaskMethodBuilder<NIDJCDKEMDF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public PHKICHECANP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private TaskAwaiter<NIDJCDKEMDF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x6163710", Offset = "0x6162310", VA = "0x186163710", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x6163990", Offset = "0x6162590", VA = "0x186163990", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private readonly BLDJEJKIMEP NAKBDMNKNOL;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6163CE0", Offset = "0x61628E0", VA = "0x186163CE0")]
	public PHKICHECANP(bool BBAIOGACFOI, NLBMEIIDLJP IPJAHGCJIBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6163BF0", Offset = "0x61627F0", VA = "0x186163BF0", Slot = "4")]
	[AsyncStateMachine(typeof(IKOIJOLGCDA))]
	public override Task<NIDJCDKEMDF> KHPMIBODMCP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public struct BLDJEJKIMEP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public bool KBPAFMDPGCL;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0xCB28E0", Offset = "0xCB14E0", VA = "0x180CB28E0")]
	public BLDJEJKIMEP(bool BBAIOGACFOI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public readonly struct GJOKMFMJKDB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly bool JHEPPCCGOBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly bool NAFCMIFICFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public readonly bool LFFGFMIPECK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public readonly bool BBAIOGACFOI;

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x45D0FE0", Offset = "0x45CFBE0", VA = "0x1845D0FE0")]
	public GJOKMFMJKDB(bool JHEPPCCGOBD, bool NAFCMIFICFC, bool LFFGFMIPECK, bool BBAIOGACFOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x6163700", Offset = "0x6162300", VA = "0x186163700")]
	public GJOKMFMJKDB(bool NAFCMIFICFC, bool BBAIOGACFOI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public interface MIALOJNCDMH
{
	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MJDBAKAKAFF(GJOKMFMJKDB HCPPOHBDPDP);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool OGPIANCPKMI(GJOKMFMJKDB HCPPOHBDPDP);
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public class BBGPNPHGDEG : FKDLNBBKBMI<MIALOJNCDMH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly GJOKMFMJKDB HCPPOHBDPDP;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x61627C0", Offset = "0x61613C0", VA = "0x1861627C0")]
	public BBGPNPHGDEG(bool NBNNMCCMOPL, bool NAFCMIFICFC, bool LFFGFMIPECK, bool BBAIOGACFOI, MIALOJNCDMH IPJAHGCJIBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6162770", Offset = "0x6161370", VA = "0x186162770", Slot = "4")]
	public override bool KHPMIBODMCP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class AAKKJDMDCFC : FKDLNBBKBMI<MIALOJNCDMH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly GJOKMFMJKDB HCPPOHBDPDP;

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x61626D0", Offset = "0x61612D0", VA = "0x1861626D0")]
	public AAKKJDMDCFC(bool NAFCMIFICFC, bool BBAIOGACFOI, MIALOJNCDMH IPJAHGCJIBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x6162680", Offset = "0x6161280", VA = "0x186162680", Slot = "4")]
	public override bool KHPMIBODMCP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public interface PDEPILKINOC
{
	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KHPMIBODMCP([In] DEMJHMLLEDF AAFAMNOOIFG);
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class FDGMGCDFJNH : FKDLNBBKBMI<PDEPILKINOC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly DEMJHMLLEDF AAFAMNOOIFG;

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x61634E0", Offset = "0x61620E0", VA = "0x1861634E0")]
	public FDGMGCDFJNH(Guid[] CLPAIFCBIDM, Vector3[] OOAFBFFNONL, Quaternion[] MCBEOEBNMOG, float[] OICFBCNMCAA, Dictionary<Guid, Vector3> JOECNPGIIGO, PDEPILKINOC IPJAHGCJIBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x6163430", Offset = "0x6162030", VA = "0x186163430", Slot = "4")]
	public override bool KHPMIBODMCP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public interface CCFALDCIIDK<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CKNJDAIMNNK([In] NEMONHNJAKE<TData> JDLJCPHLDGB);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NPHHKCKMGOK([In] OAFBDPODGEK LDEIMCIEEAO);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool NPHHKCKMGOK([In] MBPEIHKAIGO LDEIMCIEEAO);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool MHEFJNKJLGG();
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class MNPKJPAEKOA<TData> : FKDLNBBKBMI<CCFALDCIIDK<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x3307360", Offset = "0x3305F60", VA = "0x183307360")]
	public MNPKJPAEKOA(CCFALDCIIDK<TData> IPJAHGCJIBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x3E91A30", Offset = "0x3E90630", VA = "0x183E91A30", Slot = "4")]
	public override bool KHPMIBODMCP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public class JBPLHILNEMD<TData> : FKDLNBBKBMI<CCFALDCIIDK<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly OAFBDPODGEK FEBIHBAJEGM;

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x3AEA470", Offset = "0x3AE9070", VA = "0x183AEA470")]
	public JBPLHILNEMD(Vector3 NEFOGJEAFIE, bool LFNENNEGDAH, CCFALDCIIDK<TData> IPJAHGCJIBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x3344D30", Offset = "0x3343930", VA = "0x183344D30", Slot = "4")]
	public override bool KHPMIBODMCP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public class JMNMIINBNMO<TData> : FKDLNBBKBMI<CCFALDCIIDK<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly MBPEIHKAIGO FEBIHBAJEGM;

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x3B13710", Offset = "0x3B12310", VA = "0x183B13710")]
	public JMNMIINBNMO(Guid DMCGGEPDPNM, int PMIDLPOCCEE, Vector3 GMKEEAOHFFK, Quaternion MJCNDCDLGEO, float HAPMMMMDGHH, bool LFNENNEGDAH, CCFALDCIIDK<TData> IPJAHGCJIBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x3B136B0", Offset = "0x3B122B0", VA = "0x183B136B0", Slot = "4")]
	public override bool KHPMIBODMCP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class GFPLCMPOGCG<TData> : FKDLNBBKBMI<CCFALDCIIDK<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly NEMONHNJAKE<TData> FEBIHBAJEGM;

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x37855F0", Offset = "0x37841F0", VA = "0x1837855F0")]
	public GFPLCMPOGCG(TData PMKKKDOAOBE, bool BBAIOGACFOI, CCFALDCIIDK<TData> IPJAHGCJIBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x332A8B0", Offset = "0x33294B0", VA = "0x18332A8B0", Slot = "4")]
	public override bool KHPMIBODMCP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public struct OAFBDPODGEK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public readonly Vector3 NEFOGJEAFIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public readonly bool LFNENNEGDAH;

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x6163BD0", Offset = "0x61627D0", VA = "0x186163BD0")]
	public OAFBDPODGEK(Vector3 NEFOGJEAFIE, bool LFNENNEGDAH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public struct MBPEIHKAIGO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public readonly Guid DMCGGEPDPNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public readonly int PMIDLPOCCEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public readonly Vector3 GMKEEAOHFFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public readonly Quaternion MJCNDCDLGEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public readonly float HAPMMMMDGHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public readonly bool LFNENNEGDAH;

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x6163B10", Offset = "0x6162710", VA = "0x186163B10")]
	public MBPEIHKAIGO(Guid DMCGGEPDPNM, int PMIDLPOCCEE, Vector3 GMKEEAOHFFK, Quaternion MJCNDCDLGEO, float HAPMMMMDGHH, bool LFNENNEGDAH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public struct NEMONHNJAKE<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public readonly TData PMKKKDOAOBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public readonly bool BBAIOGACFOI;

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x3EF4B30", Offset = "0x3EF3730", VA = "0x183EF4B30")]
	public NEMONHNJAKE(TData PMKKKDOAOBE, bool BBAIOGACFOI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public interface DKLKMNHPNPG<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KHPMIBODMCP([In] GHIKJONAIMN<TData> FHNILODPJMD);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KHPMIBODMCP([In] OKOIIKEJOIH<TData> FHNILODPJMD);
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public interface KHPLJEHKCIM<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CKNJDAIMNNK([In] IPHHBEEAHEK<TData> FANGNDPIMCB);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NPHHKCKMGOK([In] ODHLOKPCNFH LDEIMCIEEAO);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool MHEFJNKJLGG();
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public class LEPBAJLHKEK<TData> : FKDLNBBKBMI<DKLKMNHPNPG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly GHIKJONAIMN<TData> FHNILODPJMD;

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x3C06CF0", Offset = "0x3C058F0", VA = "0x183C06CF0")]
	public LEPBAJLHKEK(IEnumerable<TData> KLADOHEIHEN, Vector3 GKAACEOHHAN, bool BBAIOGACFOI, DKLKMNHPNPG<TData> IPJAHGCJIBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x332A8B0", Offset = "0x33294B0", VA = "0x18332A8B0", Slot = "4")]
	public override bool KHPMIBODMCP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public class FMAKOAJCBCM<TData> : FKDLNBBKBMI<KHPLJEHKCIM<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x3307360", Offset = "0x3305F60", VA = "0x183307360")]
	public FMAKOAJCBCM(KHPLJEHKCIM<TData> IPJAHGCJIBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x368F810", Offset = "0x368E410", VA = "0x18368F810", Slot = "4")]
	public override bool KHPMIBODMCP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class FEJJIHLKLNJ<TData> : FKDLNBBKBMI<KHPLJEHKCIM<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly IPHHBEEAHEK<TData> FHNILODPJMD;

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x3684870", Offset = "0x3683470", VA = "0x183684870")]
	public FEJJIHLKLNJ(IEnumerable<TData> KLADOHEIHEN, bool BBAIOGACFOI, KHPLJEHKCIM<TData> IPJAHGCJIBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x332A8B0", Offset = "0x33294B0", VA = "0x18332A8B0", Slot = "4")]
	public override bool KHPMIBODMCP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class FBLADAHCENJ<TData> : FKDLNBBKBMI<DKLKMNHPNPG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly OKOIIKEJOIH<TData> FHNILODPJMD;

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x367ABB0", Offset = "0x36797B0", VA = "0x18367ABB0")]
	public FBLADAHCENJ(IEnumerable<TData> KLADOHEIHEN, Vector3 CICMOEHOBBL, MPFMMENGGBK CAHIKFFNPEG, bool BBAIOGACFOI, DKLKMNHPNPG<TData> IPJAHGCJIBA, Space GOABIBLCKPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x367AAE0", Offset = "0x36796E0", VA = "0x18367AAE0", Slot = "4")]
	public override bool KHPMIBODMCP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class OMIMLBOMPKI<TData> : FKDLNBBKBMI<KHPLJEHKCIM<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly ODHLOKPCNFH FHNILODPJMD;

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x4038AD0", Offset = "0x40376D0", VA = "0x184038AD0")]
	public OMIMLBOMPKI(Vector3 GKAACEOHHAN, KHPLJEHKCIM<TData> IPJAHGCJIBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x3344D30", Offset = "0x3343930", VA = "0x183344D30", Slot = "4")]
	public override bool KHPMIBODMCP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public struct GHIKJONAIMN<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public readonly IEnumerable<TData> KLADOHEIHEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public readonly Vector3 GKAACEOHHAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public readonly bool BBAIOGACFOI;

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x3789180", Offset = "0x3787D80", VA = "0x183789180")]
	public GHIKJONAIMN(IEnumerable<TData> KLADOHEIHEN, Vector3 GKAACEOHHAN, bool BBAIOGACFOI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public struct IPHHBEEAHEK<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public readonly IEnumerable<TData> KLADOHEIHEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public readonly bool BBAIOGACFOI;

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x3968680", Offset = "0x3967280", VA = "0x183968680")]
	public IPHHBEEAHEK(IEnumerable<TData> KLADOHEIHEN, bool BBAIOGACFOI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public struct OKOIIKEJOIH<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public readonly IEnumerable<TData> KLADOHEIHEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public readonly Vector3 CICMOEHOBBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public readonly MPFMMENGGBK CAHIKFFNPEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public readonly bool BBAIOGACFOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public readonly Space GOABIBLCKPH;

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x402A580", Offset = "0x4029180", VA = "0x18402A580")]
	public OKOIIKEJOIH(IEnumerable<TData> KLADOHEIHEN, Vector3 CICMOEHOBBL, MPFMMENGGBK CAHIKFFNPEG, bool BBAIOGACFOI, Space GOABIBLCKPH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public struct ODHLOKPCNFH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public readonly Vector3 GKAACEOHHAN;

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x1F7B170", Offset = "0x1F79D70", VA = "0x181F7B170")]
	public ODHLOKPCNFH(Vector3 GKAACEOHHAN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public enum MPFMMENGGBK
{
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	XYZ,
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	X_only,
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	Y_only,
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	Z_only
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public interface KOJBKJFAINH
{
	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KHPMIBODMCP([In] LMMKMCJKIEL EJCMHJCEPNF);
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public class IOPEJHFKBPB : FKDLNBBKBMI<KOJBKJFAINH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly LMMKMCJKIEL EJCMHJCEPNF;

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x6163AB0", Offset = "0x61626B0", VA = "0x186163AB0")]
	public IOPEJHFKBPB(bool BBAIOGACFOI, KOJBKJFAINH IPJAHGCJIBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x6163A00", Offset = "0x6162600", VA = "0x186163A00", Slot = "4")]
	public override bool KHPMIBODMCP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public readonly struct LMMKMCJKIEL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public readonly bool BBAIOGACFOI;

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0xCB28E0", Offset = "0xCB14E0", VA = "0x180CB28E0")]
	public LMMKMCJKIEL(bool BBAIOGACFOI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public interface LCCFMNDPNCK<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KHPMIBODMCP([In] DAMGKGNJOHI<TData> AFLBLNFIJNJ);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KHPMIBODMCP([In] ELJILJPDGJK<TData> AFLBLNFIJNJ);
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public interface HNNLPMOCHKN<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CKNJDAIMNNK([In] GAPKOHMNOFB<TData> JDLJCPHLDGB);

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NPHHKCKMGOK([In] LKEGNNEGDAJ LDEIMCIEEAO);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool MHEFJNKJLGG();
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public class GLEDOPEHMEF<TData> : FKDLNBBKBMI<LCCFMNDPNCK<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly DAMGKGNJOHI<TData> AFLBLNFIJNJ;

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x37A8730", Offset = "0x37A7330", VA = "0x1837A8730")]
	public GLEDOPEHMEF(IEnumerable<TData> KLADOHEIHEN, Quaternion GKAACEOHHAN, Vector3? EMPFOBBEECK, bool HNIJALGBBCL, bool BBAIOGACFOI, LCCFMNDPNCK<TData> IPJAHGCJIBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x332A8B0", Offset = "0x33294B0", VA = "0x18332A8B0", Slot = "4")]
	public override bool KHPMIBODMCP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public class FNLEKCMEMKM<TData> : FKDLNBBKBMI<HNNLPMOCHKN<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x3307360", Offset = "0x3305F60", VA = "0x183307360")]
	public FNLEKCMEMKM(HNNLPMOCHKN<TData> IPJAHGCJIBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x368F810", Offset = "0x368E410", VA = "0x18368F810", Slot = "4")]
	public override bool KHPMIBODMCP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public class LKODBKEKDJP<TData> : FKDLNBBKBMI<HNNLPMOCHKN<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly GAPKOHMNOFB<TData> AFLBLNFIJNJ;

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x3C30390", Offset = "0x3C2EF90", VA = "0x183C30390")]
	public LKODBKEKDJP(IEnumerable<TData> KLADOHEIHEN, bool BBAIOGACFOI, HNNLPMOCHKN<TData> IPJAHGCJIBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x332A8B0", Offset = "0x33294B0", VA = "0x18332A8B0", Slot = "4")]
	public override bool KHPMIBODMCP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public class LNDEGNBKFPJ<TData> : FKDLNBBKBMI<LCCFMNDPNCK<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly ELJILJPDGJK<TData> AFLBLNFIJNJ;

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x3C3CD20", Offset = "0x3C3B920", VA = "0x183C3CD20")]
	public LNDEGNBKFPJ(IEnumerable<TData> KLADOHEIHEN, Quaternion BFOMIBHJCAG, MPFMMENGGBK HMEHKLAFDMO, Vector3? EMPFOBBEECK, bool HNIJALGBBCL, bool BBAIOGACFOI, Space GOABIBLCKPH, LCCFMNDPNCK<TData> IPJAHGCJIBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x367AAE0", Offset = "0x36796E0", VA = "0x18367AAE0", Slot = "4")]
	public override bool KHPMIBODMCP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public class EKNKAMMGHPM<TData> : FKDLNBBKBMI<HNNLPMOCHKN<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly LKEGNNEGDAJ AFLBLNFIJNJ;

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x3344D90", Offset = "0x3343990", VA = "0x183344D90")]
	public EKNKAMMGHPM(Quaternion GKAACEOHHAN, Vector3? EMPFOBBEECK, bool HNIJALGBBCL, HNNLPMOCHKN<TData> IPJAHGCJIBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x3344D30", Offset = "0x3343930", VA = "0x183344D30", Slot = "4")]
	public override bool KHPMIBODMCP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public struct DAMGKGNJOHI<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public readonly IEnumerable<TData> KLADOHEIHEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public readonly Quaternion GKAACEOHHAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public readonly Vector3? EMPFOBBEECK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public readonly bool HNIJALGBBCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public readonly bool BBAIOGACFOI;

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x502F3E0", Offset = "0x502DFE0", VA = "0x18502F3E0")]
	public DAMGKGNJOHI(IEnumerable<TData> KLADOHEIHEN, Quaternion GKAACEOHHAN, Vector3? EMPFOBBEECK, bool HNIJALGBBCL, bool BBAIOGACFOI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public struct GAPKOHMNOFB<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public readonly IEnumerable<TData> KLADOHEIHEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public readonly bool BBAIOGACFOI;

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x374DC40", Offset = "0x374C840", VA = "0x18374DC40")]
	public GAPKOHMNOFB(IEnumerable<TData> KLADOHEIHEN, bool BBAIOGACFOI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public struct ELJILJPDGJK<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public readonly IEnumerable<TData> KLADOHEIHEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public readonly Quaternion BFOMIBHJCAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public readonly MPFMMENGGBK HMEHKLAFDMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public readonly Vector3? EMPFOBBEECK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public readonly bool HNIJALGBBCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public readonly bool BBAIOGACFOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public readonly Space GOABIBLCKPH;

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x3346450", Offset = "0x3345050", VA = "0x183346450")]
	public ELJILJPDGJK(IEnumerable<TData> KLADOHEIHEN, Quaternion BFOMIBHJCAG, MPFMMENGGBK HMEHKLAFDMO, Vector3? EMPFOBBEECK, bool HNIJALGBBCL, bool BBAIOGACFOI, Space GOABIBLCKPH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public struct LKEGNNEGDAJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public readonly Quaternion GKAACEOHHAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public readonly Vector3? EMPFOBBEECK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public readonly bool HNIJALGBBCL;

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x4598580", Offset = "0x4597180", VA = "0x184598580")]
	public LKEGNNEGDAJ(Quaternion GKAACEOHHAN, Vector3? EMPFOBBEECK, bool HNIJALGBBCL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public interface EDCLDJEJNGA<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CKNJDAIMNNK([In] BDNGAPICJPM<TData> JDLJCPHLDGB);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NPHHKCKMGOK([In] FGFFAFFBONB LDEIMCIEEAO);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool NPHHKCKMGOK([In] ACHPHGEMOJB LDEIMCIEEAO);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool NPHHKCKMGOK([In] GEFMKKGHOPA LDEIMCIEEAO);

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool MHEFJNKJLGG();
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public class EBJOCJHBDOC<TData> : FKDLNBBKBMI<EDCLDJEJNGA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly GEFMKKGHOPA FIOOOHCDPIF;

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x3304830", Offset = "0x3303430", VA = "0x183304830")]
	public EBJOCJHBDOC(Vector3 MFNBILPGODA, float MHDIGCPHMNA, Vector3 EMPFOBBEECK, bool MIEONDOAJEK, bool JOABOFMFKKJ, EDCLDJEJNGA<TData> IPJAHGCJIBA, Space GOABIBLCKPH = Space.Self)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x33047D0", Offset = "0x33033D0", VA = "0x1833047D0", Slot = "4")]
	public override bool KHPMIBODMCP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public class GMEKPGMBDDE<TData> : FKDLNBBKBMI<EDCLDJEJNGA<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x3307360", Offset = "0x3305F60", VA = "0x183307360")]
	public GMEKPGMBDDE(EDCLDJEJNGA<TData> IPJAHGCJIBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x37A9A30", Offset = "0x37A8630", VA = "0x1837A9A30", Slot = "4")]
	public override bool KHPMIBODMCP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public class AENHDKEOJGB<TData> : FKDLNBBKBMI<EDCLDJEJNGA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly BDNGAPICJPM<TData> FIOOOHCDPIF;

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x37C4EB0", Offset = "0x37C3AB0", VA = "0x1837C4EB0")]
	public AENHDKEOJGB(IEnumerable<TData> KLADOHEIHEN, bool BBAIOGACFOI, EDCLDJEJNGA<TData> IPJAHGCJIBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x332A8B0", Offset = "0x33294B0", VA = "0x18332A8B0", Slot = "4")]
	public override bool KHPMIBODMCP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public class NODELJCAGJC<TData> : FKDLNBBKBMI<EDCLDJEJNGA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly ACHPHGEMOJB FIOOOHCDPIF;

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x3F53790", Offset = "0x3F52390", VA = "0x183F53790")]
	public NODELJCAGJC(float JMOPOABCPEG, bool MFFIHIFNKIJ, Vector3 EMPFOBBEECK, EDCLDJEJNGA<TData> IPJAHGCJIBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x3F536C0", Offset = "0x3F522C0", VA = "0x183F536C0", Slot = "4")]
	public override bool KHPMIBODMCP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public class JKGJIINOHKD<TData> : FKDLNBBKBMI<EDCLDJEJNGA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly FGFFAFFBONB FIOOOHCDPIF;

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x3B04250", Offset = "0x3B02E50", VA = "0x183B04250")]
	public JKGJIINOHKD(float MHDIGCPHMNA, Vector3 EMPFOBBEECK, EDCLDJEJNGA<TData> IPJAHGCJIBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x3344D30", Offset = "0x3343930", VA = "0x183344D30", Slot = "4")]
	public override bool KHPMIBODMCP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public struct GEFMKKGHOPA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	public readonly Vector3 MFNBILPGODA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public readonly float MHDIGCPHMNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public readonly Vector3 EMPFOBBEECK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public readonly bool LFNENNEGDAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public readonly Space GOABIBLCKPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public readonly bool JOABOFMFKKJ;

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x61636C0", Offset = "0x61622C0", VA = "0x1861636C0")]
	public GEFMKKGHOPA(Vector3 MFNBILPGODA, float MHDIGCPHMNA, Vector3 EMPFOBBEECK, bool LFNENNEGDAH, bool BHGHBEBDGAN, Space GOABIBLCKPH = Space.Self)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public struct BDNGAPICJPM<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public readonly IEnumerable<TData> KLADOHEIHEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public readonly bool BBAIOGACFOI;

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x476E080", Offset = "0x476CC80", VA = "0x18476E080")]
	public BDNGAPICJPM(IEnumerable<TData> KLADOHEIHEN, bool BBAIOGACFOI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public struct ACHPHGEMOJB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public readonly float JMOPOABCPEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public readonly bool MFFIHIFNKIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public readonly Vector3 EMPFOBBEECK;

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x6162750", Offset = "0x6161350", VA = "0x186162750")]
	public ACHPHGEMOJB(float JMOPOABCPEG, bool MFFIHIFNKIJ, Vector3 EMPFOBBEECK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public struct FGFFAFFBONB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public readonly float MHDIGCPHMNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public readonly Vector3 EMPFOBBEECK;

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x456EC70", Offset = "0x456D870", VA = "0x18456EC70")]
	public FGFFAFFBONB(float MHDIGCPHMNA, Vector3 EMPFOBBEECK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public struct DEMJHMLLEDF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public readonly Guid[] KLADOHEIHEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public readonly bool HAOPJAMGDAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public readonly bool EFGMBFEPAGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public readonly bool IGBPOOLOKID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public readonly Vector3[] OOAFBFFNONL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public readonly Quaternion[] MCBEOEBNMOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public readonly float[] OICFBCNMCAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public readonly Dictionary<Guid, Vector3> JOECNPGIIGO;

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x6162C70", Offset = "0x6161870", VA = "0x186162C70")]
	public DEMJHMLLEDF(Guid[] CLPAIFCBIDM, Vector3[] OOAFBFFNONL, Quaternion[] MCBEOEBNMOG, float[] OICFBCNMCAA, Dictionary<Guid, Vector3> JOECNPGIIGO, bool HAOPJAMGDAB = true, bool EFGMBFEPAGG = true, bool IGBPOOLOKID = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x6162AA0", Offset = "0x61616A0", VA = "0x186162AA0")]
	private static void EKKAFFHMMME(Dictionary<Guid, Vector3> JOECNPGIIGO, int KAPIGGBGGIL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public static class ELAEKGKPMHE
{
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	private struct MAMIBNHEKHL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public bool HCFAMMFAKGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public OJEGDOKHPNO HAMOMEBNMGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public OJEGDOKHPNO FMIPNKGPDDK;
	}

	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private static MAMIBNHEKHL AGFIPDDKEGA;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static CancellationToken HMNPIMLNDBP
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x61630B0", Offset = "0x6161CB0", VA = "0x1861630B0")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	internal static OJEGDOKHPNO HAMOMEBNMGM
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x6163220", Offset = "0x6161E20", VA = "0x186163220")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x61632C0", Offset = "0x6161EC0", VA = "0x1861632C0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x6163330", Offset = "0x6161F30", VA = "0x186163330")]
	[JDFNDIEGGDI(EEILJHHLCPL.Room, COFBNFOEGIB.None)]
	private static void PACIOMMBOLO(OJEGDOKHPNO AILKBKAMOIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x61630D0", Offset = "0x6161CD0", VA = "0x1861630D0")]
	public static void KEPEANOIAHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x6163060", Offset = "0x6161C60", VA = "0x186163060")]
	private static OJEGDOKHPNO CLIHFICIEFJ(OJEGDOKHPNO GHINPDOJACO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public static class MBPLJAPIFOF
{
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	public enum GFNBLAIPHLL
	{
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		ICreationContextObject,
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		Guid
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x2894560", Offset = "0x2893160", VA = "0x182894560")]
	public static void NALGIBOAKBJ<T>(T MCFGKAKKIKD, GFNBLAIPHLL CJEAJMFMNNJ) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x2894500", Offset = "0x2893100", VA = "0x182894500")]
	public static void NALGIBOAKBJ<T>(T MCFGKAKKIKD) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x28943F0", Offset = "0x2892FF0", VA = "0x1828943F0")]
	public static void HLMLJEADILK<T>(T MCFGKAKKIKD) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x2894350", Offset = "0x2892F50", VA = "0x182894350")]
	public static T CPPPHMALPOD<T>(GFNBLAIPHLL CJEAJMFMNNJ) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x28941E0", Offset = "0x2892DE0", VA = "0x1828941E0")]
	public static bool AGMIEMMEKCH<T>(GFNBLAIPHLL CJEAJMFMNNJ, T DCCDHKCLHOD, [Out] T NMFAOIOAPEO) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x2894460", Offset = "0x2893060", VA = "0x182894460")]
	public static bool KCAKHDIPODD<T>(GFNBLAIPHLL CJEAJMFMNNJ) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x2894310", Offset = "0x2892F10", VA = "0x182894310")]
	public static T CPPPHMALPOD<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x2894140", Offset = "0x2892D40", VA = "0x182894140")]
	public static bool AGMIEMMEKCH<T>(T DCCDHKCLHOD, [Out] T NMFAOIOAPEO) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x2894310", Offset = "0x2892F10", VA = "0x182894310")]
	public static bool KCAKHDIPODD<T>() where T : class
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
internal static class BDGBBEMDCFP
{
	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x6162850", Offset = "0x6161450", VA = "0x186162850")]
	public static void BCIOGLPCEJD(IEnumerable CPBPMECBGID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x25997F0", Offset = "0x25983F0", VA = "0x1825997F0")]
	public static void BCIOGLPCEJD<T>(T[] GBCEGNLFFAN) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x25998E0", Offset = "0x25984E0", VA = "0x1825998E0")]
	public static void BCIOGLPCEJD<T>(T DIOIMJEHEHI) where T : notnull, Enum
	{
	}
}
namespace Cpp2IlInjected
{
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
}
