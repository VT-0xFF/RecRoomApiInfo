using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.DataLayer.Attributes;
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
		[Cpp2IlInjected.Address(RVA = "0x8DF890", Offset = "0x8DE890", VA = "0x1808DF890")]
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
		[Cpp2IlInjected.Address(RVA = "0x6EF9300", Offset = "0x6EF8300", VA = "0x186EF9300")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8E0550", Offset = "0x8DF550", VA = "0x1808E0550")]
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
		[Cpp2IlInjected.Address(RVA = "0x8E0590", Offset = "0x8DF590", VA = "0x1808E0590")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_Maker_Core_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	[Preserve]
	public class _AssemblyIndex : PFMKOBANMPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6EF93C0", Offset = "0x6EF83C0", VA = "0x186EF93C0", Slot = "8")]
		public override void NCHGKCJDJHF(GLGFPKOIELC registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6565350", Offset = "0x6564350", VA = "0x186565350")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface PDPGPNOAANE<TData, TReturn>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TReturn CHJMBDIDHFF(TData IFPBFCLBBDP);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface FFIDFOPLLBE<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ClearHoverTarget(PHFMLCDMFAG BEBBJBNFAFN);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool SetHoverTarget(TData CECLKDDLGFE, Collider MPAKMPIIKMG, PHFMLCDMFAG BEBBJBNFAFN, [Optional] MBMBIKLIHBO? LAKOCKALOPA);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool TryGetHoverTarget([Out] TData CECLKDDLGFE);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool TryGetHoverCollider([Out] Collider MPAKMPIIKMG);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface FMEFCJODGEL<TData> : OIGBBHMIJCA, LCBOHCLLLIE<TData>, JHGNPKJAGOO<TData>, JKELANINMBF<TData>, ILIPAGJDPCP, HEAFFDGKMAL<TData>, INDFOBCPBLP, AHEJLABALJA
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface HEAFFDGKMAL<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool Raycast(Vector3 KGHGAEAECEO, Vector3 IKMGCHAHKMB, float OCANAPGPKID, [Out] T DEKFGMCGFFD, [Out] Vector3 JKAPJDGOFDM, [Out] Collider MPAKMPIIKMG);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int SpherecastPick(Vector3 KGHGAEAECEO, Vector3 IKMGCHAHKMB, float BGLNEHNOOFA, float OCANAPGPKID, T[] PDIAGJAKKJG, [Out] Vector3 HHFPKONAPIO, [Out] Collider ECEDIJDGEFN);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int SpherePick(Vector3 KGHGAEAECEO, float BGLNEHNOOFA, Vector3 DONFAAOKCPA, T[] PDIAGJAKKJG);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool TryGetObjectFromColliderInCurrentScope(Collider MMLIMBGJNAP, [Out] T HBABLMJEDBL);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface OIGBBHMIJCA
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Bounds DOJEIIFJILF
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	Transform CPAELIEFKPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	Bounds DGOCCLAIMMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Transform MMPONNJEKFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	Vector3 PNFGPBMIOAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool OLJNBHPHMPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void SetSelectionBoundsDirty(bool OJAOFBEFKLJ = true, int APHGAKFPIGD = 0);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ShouldHideSelectionBoundsPreview(bool BFHBFGAOGNG, object NANMDIJGGLP);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface AHEJLABALJA
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	GDBINPMHEFP JAEKDIMOBOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface EOBKNINILKL
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool BPOGLGMFCMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool NNAKCDPKEMP
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool GJOJDGCFFIC
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Dictionary<Guid, Guid> TryGetPreviousCloneMapping();

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void TrySetPreviousCloneMapping(Dictionary<Guid, Guid> HLOIIAEKPGD);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface JKELANINMBF<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool OFHAOOBKJBP
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	int DEEGINBGELB
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<TData> JNEFKIPLGOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IsSelected(TData KBDJJFPFPLD);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IsSelectable(TData KBDJJFPFPLD);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface LCBOHCLLLIE<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void RenderHoverHighlight(T IFPBFCLBBDP, [Optional] MBMBIKLIHBO? FAPOANHDBEJ, bool HLLAJBHPADB = true);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RenderHoverHighlight(int DCEOMHJEBBP, IEnumerable<T> OGONHNAOEFB, bool HLLAJBHPADB = true);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RenderHoverHighlight(int DCEOMHJEBBP, IEnumerable<T> OGONHNAOEFB, MBMBIKLIHBO FAPOANHDBEJ, bool HLLAJBHPADB = true);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface INDFOBCPBLP
{
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnSelectionPickedUp();

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnSelectionReleased();
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface ILIPAGJDPCP
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool CPEOICFBHAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool OBLDKEPKHFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	bool LFIFHLFEEHH
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	bool PJHOMFKOIEK
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public abstract class EFMKOODMAJI<TReceiver> : DMNNNGJFOCK<TReceiver, bool> where TReceiver : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3C4C550", Offset = "0x3C4B550", VA = "0x183C4C550")]
	public EFMKOODMAJI(TReceiver BGLJKFHLJGM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public abstract class KACMBIALKLP<TReceiver, TFromTask> : DMNNNGJFOCK<TReceiver, Task<TFromTask>>
{
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3C4C550", Offset = "0x3C4B550", VA = "0x183C4C550")]
	public KACMBIALKLP(TReceiver BGLJKFHLJGM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public abstract class DMNNNGJFOCK<TReceiver, TFromExecute> where TReceiver : notnull where TFromExecute : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	protected TReceiver BGLJKFHLJGM;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x5DC9E90", Offset = "0x5DC8E90", VA = "0x185DC9E90")]
	public DMNNNGJFOCK(TReceiver BGLJKFHLJGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TFromExecute IALMCJCIBIH();
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public abstract class NKHGLCECBJP<TReceiver, TResult> : DMNNNGJFOCK<TReceiver, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x3C4C550", Offset = "0x3C4B550", VA = "0x183C4C550")]
	public NKHGLCECBJP(TReceiver BGLJKFHLJGM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct AMFAKPOBFBG<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public TGroup JOBKBCDNJPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public TData KBJDKGHNLBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public IEnumerable<TData> JDIMMEFHIGM;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x21E39D0", Offset = "0x21E29D0", VA = "0x1821E39D0")]
	public AMFAKPOBFBG(TGroup LNJNMIOFKOA, TData AOAALNNCIFF, IEnumerable<TData> JCJBLFPIMAJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct NBJPFNMKMFK<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public TGroup JOBKBCDNJPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public IEnumerable<TData> JDIMMEFHIGM;

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0xE8C760", Offset = "0xE8B760", VA = "0x180E8C760")]
	public NBJPFNMKMFK(TGroup LNJNMIOFKOA, IEnumerable<TData> JCJBLFPIMAJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct MNKMDELIIJJ<TGroup> where TGroup : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public TGroup JOBKBCDNJPC;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x997970", Offset = "0x996970", VA = "0x180997970")]
	public MNKMDELIIJJ(TGroup LNJNMIOFKOA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct ILNMLFPIPJP<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public IEnumerable<TData> JDIMMEFHIGM;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x997970", Offset = "0x996970", VA = "0x180997970")]
	public ILNMLFPIPJP(IEnumerable<TData> JCJBLFPIMAJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface OIHNCPKPAGM<TGroup, TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CNCPFEDCKAP LMKJLGGHNKP(AMFAKPOBFBG<TGroup, TData> GHLCAJFLJPO);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "1")]
	CNCPFEDCKAP EMHAENHGLFI(AMFAKPOBFBG<TGroup, TData> GHLCAJFLJPO);

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "2")]
	CNCPFEDCKAP PAKMCKLIIPB(NBJPFNMKMFK<TGroup, TData> GHLCAJFLJPO);

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "3")]
	CNCPFEDCKAP EFJKBICNFLF(MNKMDELIIJJ<TGroup> GHLCAJFLJPO);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface NMOJODGIDKG<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<CNCPFEDCKAP> LMKJLGGHNKP(ILNMLFPIPJP<TData> GHLCAJFLJPO);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class JNLAMNHMIPH<TGroup, TData> : NKHGLCECBJP<OIHNCPKPAGM<TGroup, TData>, CNCPFEDCKAP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly NBJPFNMKMFK<TGroup, TData> GHLCAJFLJPO;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x45ACAF0", Offset = "0x45ABAF0", VA = "0x1845ACAF0")]
	public JNLAMNHMIPH(TGroup LNJNMIOFKOA, IEnumerable<TData> JCJBLFPIMAJ, OIHNCPKPAGM<TGroup, TData> BGLJKFHLJGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x45ACA20", Offset = "0x45ABA20", VA = "0x1845ACA20", Slot = "4")]
	public override CNCPFEDCKAP IALMCJCIBIH()
	{
		return default(CNCPFEDCKAP);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class HEONBBDGCKN<TGroup, TData> : NKHGLCECBJP<OIHNCPKPAGM<TGroup, TData>, CNCPFEDCKAP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly AMFAKPOBFBG<TGroup, TData> GHLCAJFLJPO;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x408B100", Offset = "0x408A100", VA = "0x18408B100")]
	public HEONBBDGCKN(TGroup LNJNMIOFKOA, TData IODJJFAPBMF, IEnumerable<TData> JCJBLFPIMAJ, OIHNCPKPAGM<TGroup, TData> BGLJKFHLJGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x41E88F0", Offset = "0x41E78F0", VA = "0x1841E88F0", Slot = "4")]
	public override CNCPFEDCKAP IALMCJCIBIH()
	{
		return default(CNCPFEDCKAP);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class OOFIBFPMDNI<TGroup, TData> : NKHGLCECBJP<OIHNCPKPAGM<TGroup, TData>, CNCPFEDCKAP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly MNKMDELIIJJ<TGroup> GHLCAJFLJPO;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x453AF90", Offset = "0x4539F90", VA = "0x18453AF90")]
	public OOFIBFPMDNI(TGroup LNJNMIOFKOA, OIHNCPKPAGM<TGroup, TData> BGLJKFHLJGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x4B32600", Offset = "0x4B31600", VA = "0x184B32600", Slot = "4")]
	public override CNCPFEDCKAP IALMCJCIBIH()
	{
		return default(CNCPFEDCKAP);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class ABONJHPCKKJ<TGroup, TData> : NKHGLCECBJP<OIHNCPKPAGM<TGroup, TData>, CNCPFEDCKAP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly AMFAKPOBFBG<TGroup, TData> GHLCAJFLJPO;

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x408B100", Offset = "0x408A100", VA = "0x18408B100")]
	public ABONJHPCKKJ(TGroup LNJNMIOFKOA, TData AOAALNNCIFF, IEnumerable<TData> JCJBLFPIMAJ, OIHNCPKPAGM<TGroup, TData> BGLJKFHLJGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x408B020", Offset = "0x408A020", VA = "0x18408B020", Slot = "4")]
	public override CNCPFEDCKAP IALMCJCIBIH()
	{
		return default(CNCPFEDCKAP);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class JABGEMIBGFM<TData> : KACMBIALKLP<NMOJODGIDKG<TData>, CNCPFEDCKAP> where TData : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private struct LCMJHDJIHAI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public AsyncTaskMethodBuilder<CNCPFEDCKAP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public JABGEMIBGFM<TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private TaskAwaiter<CNCPFEDCKAP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x471B070", Offset = "0x471A070", VA = "0x18471B070", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x471B310", Offset = "0x471A310", VA = "0x18471B310", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private ILNMLFPIPJP<TData> GHLCAJFLJPO;

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x453AF90", Offset = "0x4539F90", VA = "0x18453AF90")]
	public JABGEMIBGFM(IEnumerable<TData> MOFCDBNGKII, NMOJODGIDKG<TData> BGLJKFHLJGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x453AE90", Offset = "0x4539E90", VA = "0x18453AE90", Slot = "4")]
	[AsyncStateMachine(typeof(JABGEMIBGFM<>.LCMJHDJIHAI))]
	public override Task<CNCPFEDCKAP> IALMCJCIBIH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public readonly struct PJDHILMBJDB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly KLGJCFIMLCL OOCKMNBGFOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly bool DNJILKHGMOE;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6EF93A0", Offset = "0x6EF83A0", VA = "0x186EF93A0")]
	public PJDHILMBJDB(KLGJCFIMLCL HKKGGFLOEIJ, bool CNAHFDJPKEK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface AMLKLPDLPFP<TSpawnType> where TSpawnType : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> IALMCJCIBIH(PJDHILMBJDB NOMDIDMHIHL);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class KAJOFNDLIDC<TSpawnType> : KACMBIALKLP<AMLKLPDLPFP<TSpawnType>, TSpawnType> where TSpawnType : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private struct DJLGMPJOOAD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public AsyncTaskMethodBuilder<TSpawnType> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public KAJOFNDLIDC<TSpawnType> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private TaskAwaiter<TSpawnType> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x5DB7E50", Offset = "0x5DB6E50", VA = "0x185DB7E50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x40113E0", Offset = "0x40103E0", VA = "0x1840113E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly PJDHILMBJDB NOMDIDMHIHL;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x465F170", Offset = "0x465E170", VA = "0x18465F170")]
	public KAJOFNDLIDC(KLGJCFIMLCL HKKGGFLOEIJ, bool CNAHFDJPKEK, AMLKLPDLPFP<TSpawnType> BGLJKFHLJGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x465EE40", Offset = "0x465DE40", VA = "0x18465EE40", Slot = "4")]
	[AsyncStateMachine(typeof(KAJOFNDLIDC<>.DJLGMPJOOAD))]
	public override Task<TSpawnType> IALMCJCIBIH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public readonly struct KLGJCFIMLCL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly bool CGHEOKMHNCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public readonly Vector3 KNMPFOHLFEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly Vector3 BFENJPJIDPJ;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6EF8C70", Offset = "0x6EF7C70", VA = "0x186EF8C70")]
	public KLGJCFIMLCL(Transform CMIOPMEGLHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6EF8BC0", Offset = "0x6EF7BC0", VA = "0x186EF8BC0")]
	public KLGJCFIMLCL(Vector3 LCMGGHKGECO, Vector3 PAMMLHPIJIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6EF8B90", Offset = "0x6EF7B90", VA = "0x186EF8B90")]
	public static KLGJCFIMLCL PIAFMCAELCF()
	{
		return default(KLGJCFIMLCL);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6EF8BF0", Offset = "0x6EF7BF0", VA = "0x186EF8BF0")]
	private KLGJCFIMLCL(bool HGECNHDLLKA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct NHJIMCJOLLN<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public TNode LJPHLEHCHLG;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x49E7310", Offset = "0x49E6310", VA = "0x1849E7310")]
	public NHJIMCJOLLN(TNode LJPHLEHCHLG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct DBAHMIJCICN<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public TNode BJELPAELGOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public EJCOKMFJGML LGGLBECKDLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly bool DNJILKHGMOE;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x5D4B940", Offset = "0x5D4A940", VA = "0x185D4B940")]
	public DBAHMIJCICN(TNode BJELPAELGOB, EJCOKMFJGML LGGLBECKDLM, bool CNAHFDJPKEK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface BCIGCLINPIA<TNode>
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OMENOEDKBHE([In] NHJIMCJOLLN<TNode> PEDINFMMANF);

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CBHLHLGJKKO([In] DBAHMIJCICN<TNode> DCDLOMLNPBI);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool AEAJBIIOEFA();
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class CNKBCELPELO<TNode> : EFMKOODMAJI<BCIGCLINPIA<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x3C4C550", Offset = "0x3C4B550", VA = "0x183C4C550")]
	public CNKBCELPELO(BCIGCLINPIA<TNode> BGLJKFHLJGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x59E2210", Offset = "0x59E1210", VA = "0x1859E2210", Slot = "4")]
	public override bool IALMCJCIBIH()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class JLHJCFNCIJI<TNode> : EFMKOODMAJI<BCIGCLINPIA<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly DBAHMIJCICN<TNode> DCDLOMLNPBI;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x45A6330", Offset = "0x45A5330", VA = "0x1845A6330")]
	public JLHJCFNCIJI(TNode BJELPAELGOB, EJCOKMFJGML LGGLBECKDLM, BCIGCLINPIA<TNode> BGLJKFHLJGM, bool CNAHFDJPKEK = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x40E9C20", Offset = "0x40E8C20", VA = "0x1840E9C20", Slot = "4")]
	public override bool IALMCJCIBIH()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class IMCCFNLJBKF<TNode> : EFMKOODMAJI<BCIGCLINPIA<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly NHJIMCJOLLN<TNode> PEDINFMMANF;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x437C330", Offset = "0x437B330", VA = "0x18437C330")]
	public IMCCFNLJBKF(TNode GBHLFLMNBCJ, BCIGCLINPIA<TNode> BGLJKFHLJGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x437C270", Offset = "0x437B270", VA = "0x18437C270", Slot = "4")]
	public override bool IALMCJCIBIH()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public struct MCNIKHAGGOE<TSpawnInfo> where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public TSpawnInfo PBNMPHEDDAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public Vector3 PAMMLHPIJIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public Quaternion JKJHCABJJIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public float KBGFEDJHNAE;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x4933CF0", Offset = "0x4932CF0", VA = "0x184933CF0")]
	public MCNIKHAGGOE(TSpawnInfo PBNMPHEDDAD, Vector3 PAMMLHPIJIB, Quaternion JKJHCABJJIO, float KBGFEDJHNAE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface JNNNKGEOAOK<TSpawnType, TSpawnInfo>
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> IBFNFAHLBLA([In] MCNIKHAGGOE<TSpawnInfo> LJMFLIGBGHH, CancellationToken CLIKNEKJHEI);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class ADGENMFMFLM<TSpawnType, TSpawnInfo> : KACMBIALKLP<JNNNKGEOAOK<TSpawnType, TSpawnInfo>, TSpawnType> where TSpawnType : notnull where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly MCNIKHAGGOE<TSpawnInfo> NABJMDALPIF;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x408F590", Offset = "0x408E590", VA = "0x18408F590")]
	public ADGENMFMFLM(TSpawnInfo HDNKKBIJAAK, Vector3 PAMMLHPIJIB, Quaternion JKJHCABJJIO, float KBGFEDJHNAE, JNNNKGEOAOK<TSpawnType, TSpawnInfo> BGLJKFHLJGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x408F390", Offset = "0x408E390", VA = "0x18408F390", Slot = "4")]
	public override Task<TSpawnType> IALMCJCIBIH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public readonly struct IMCMNAFGEAM<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public readonly IEnumerable<TData> JDIMMEFHIGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public readonly bool DNJILKHGMOE;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x437C6E0", Offset = "0x437B6E0", VA = "0x18437C6E0")]
	public IMCMNAFGEAM(IEnumerable<TData> JCJBLFPIMAJ, bool CNAHFDJPKEK = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public interface NEENGBEIOCF<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<CNCPFEDCKAP> PJGNEIGJCCG([In] IMCMNAFGEAM<TData> ANEOFKEPCMN, CancellationToken CLIKNEKJHEI);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public class CBOJOAMKKBP<TData> : KACMBIALKLP<NEENGBEIOCF<TData>, CNCPFEDCKAP> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private readonly IMCMNAFGEAM<TData> PEIDKLKMIDN;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5708560", Offset = "0x5707560", VA = "0x185708560")]
	public CBOJOAMKKBP(IEnumerable<TData> JCJBLFPIMAJ, bool CNAHFDJPKEK, NEENGBEIOCF<TData> BGLJKFHLJGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x408F390", Offset = "0x408E390", VA = "0x18408F390", Slot = "4")]
	public override Task<CNCPFEDCKAP> IALMCJCIBIH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public struct BMFPMEOCLED<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public readonly T CECLKDDLGFE;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x4BD1AC0", Offset = "0x4BD0AC0", VA = "0x184BD1AC0")]
	public BMFPMEOCLED(T AGCGDDNDIKC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface CDPAJCDAPGE<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OMENOEDKBHE([In] BMFPMEOCLED<T> GKOFMFKJBBO);

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CBHLHLGJKKO();
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface EIBDHECBGBF<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IALMCJCIBIH([In] MHIPOGPNNAF<T> MABMPGCLICE);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public struct MHIPOGPNNAF<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public readonly T CECLKDDLGFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public readonly bool HFNKKIFDHOK;

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x4950A00", Offset = "0x494FA00", VA = "0x184950A00")]
	public MHIPOGPNNAF(T AGCGDDNDIKC, bool CNNOIPGEJJE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public class NHHNPFNDMKN<T> : EFMKOODMAJI<CDPAJCDAPGE<T>> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x3C4C550", Offset = "0x3C4B550", VA = "0x183C4C550")]
	public NHHNPFNDMKN(CDPAJCDAPGE<T> BGLJKFHLJGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x49E72C0", Offset = "0x49E62C0", VA = "0x1849E72C0", Slot = "4")]
	public override bool IALMCJCIBIH()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public class CPLLPLEHGFE<T> : EFMKOODMAJI<CDPAJCDAPGE<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly BMFPMEOCLED<T> GKOFMFKJBBO;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x5AE47A0", Offset = "0x5AE37A0", VA = "0x185AE47A0")]
	public CPLLPLEHGFE(T CECLKDDLGFE, CDPAJCDAPGE<T> BGLJKFHLJGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x437C270", Offset = "0x437B270", VA = "0x18437C270", Slot = "4")]
	public override bool IALMCJCIBIH()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public class BNNMGMOBJPA<T> : EFMKOODMAJI<EIBDHECBGBF<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly MHIPOGPNNAF<T> MABMPGCLICE;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x53DCAD0", Offset = "0x53DBAD0", VA = "0x1853DCAD0")]
	public BNNMGMOBJPA(T CECLKDDLGFE, bool CNNOIPGEJJE, EIBDHECBGBF<T> BGLJKFHLJGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x437C270", Offset = "0x437B270", VA = "0x18437C270", Slot = "4")]
	public override bool IALMCJCIBIH()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public struct DGIBFJPLMJK<TData> where TData : notnull, ODJGABEIKDK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public IEnumerable<TData> JDIMMEFHIGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public bool JPFDEPFECFK;

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x5D79DC0", Offset = "0x5D78DC0", VA = "0x185D79DC0")]
	public DGIBFJPLMJK(IEnumerable<TData> BJAPBNLJMJK, bool AJKCHGOJGCC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public struct OHGBJCPJDOP<TData> where TData : notnull, ODJGABEIKDK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public List<TData> JDIMMEFHIGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public List<bool> OGBOGIJEDMK;

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x4B11E80", Offset = "0x4B10E80", VA = "0x184B11E80")]
	public OHGBJCPJDOP(List<TData> BJAPBNLJMJK, List<bool> CGICJDOMBIN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface ODJGABEIKDK
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	bool IKDPCPMEHNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface HJPGDNONENB<TData> where TData : ODJGABEIKDK
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IALMCJCIBIH([In] DGIBFJPLMJK<TData> DPGILPGFPHG);

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IALMCJCIBIH([In] OHGBJCPJDOP<TData> DPGILPGFPHG);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface PBBAKHNFFJK<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MADNJGKINAG(T CECLKDDLGFE);
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public class MAFPOIPPAEE<TData> : EFMKOODMAJI<HJPGDNONENB<TData>> where TData : notnull, ODJGABEIKDK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly DGIBFJPLMJK<TData> DPGILPGFPHG;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x492AD00", Offset = "0x4929D00", VA = "0x18492AD00")]
	public MAFPOIPPAEE(List<TData> JCJBLFPIMAJ, bool JPFDEPFECFK, HJPGDNONENB<TData> BGLJKFHLJGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x437C270", Offset = "0x437B270", VA = "0x18437C270", Slot = "4")]
	public override bool IALMCJCIBIH()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public class GJCDPGJDBCG<TData> : EFMKOODMAJI<HJPGDNONENB<TData>> where TData : notnull, ODJGABEIKDK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly OHGBJCPJDOP<TData> DPGILPGFPHG;

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x4172B20", Offset = "0x4171B20", VA = "0x184172B20")]
	public GJCDPGJDBCG(List<TData> JCJBLFPIMAJ, List<bool> OGBOGIJEDMK, HJPGDNONENB<TData> BGLJKFHLJGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x4172A60", Offset = "0x4171A60", VA = "0x184172A60", Slot = "4")]
	public override bool IALMCJCIBIH()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface NNGADAKPAIG<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<CNCPFEDCKAP> IALMCJCIBIH(CCJPBJIDHME<TData> IHJFHPDENAI);
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class ABDEODJPIDL<TData> : KACMBIALKLP<NNGADAKPAIG<TData>, CNCPFEDCKAP> where TData : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private struct BIEKOLKHMAH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public AsyncTaskMethodBuilder<CNCPFEDCKAP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public ABDEODJPIDL<TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private TaskAwaiter<CNCPFEDCKAP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x53504D0", Offset = "0x534F4D0", VA = "0x1853504D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x53507B0", Offset = "0x534F7B0", VA = "0x1853507B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly CCJPBJIDHME<TData> MJCMGGAOLPL;

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x4080E80", Offset = "0x407FE80", VA = "0x184080E80")]
	public ABDEODJPIDL(TData FACMNADJEOF, IReadOnlyList<TData> DNOENBBCKIO, bool CNAHFDJPKEK, NNGADAKPAIG<TData> BGLJKFHLJGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x4080D80", Offset = "0x407FD80", VA = "0x184080D80", Slot = "4")]
	[AsyncStateMachine(typeof(ABDEODJPIDL<>.BIEKOLKHMAH))]
	public override Task<CNCPFEDCKAP> IALMCJCIBIH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public struct CCJPBJIDHME<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public TData LJCIPMEKFBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public IReadOnlyList<TData> LOKNDIAAHGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public bool DNJILKHGMOE;

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x514DE50", Offset = "0x514CE50", VA = "0x18514DE50")]
	public CCJPBJIDHME(TData FACMNADJEOF, IReadOnlyList<TData> DNOENBBCKIO, bool CNAHFDJPKEK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public interface JGOCAAFACDJ<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IALMCJCIBIH([In] FAJFDCOMLNI<TData> JHAADFFNDIG);
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface KBHJAKGHMFH<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IALMCJCIBIH([In] DBGHMDCCLDG<TData> JHAADFFNDIG);
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public interface FOGGFLPNHBO<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PBPLGGNGNBE([In] FCKCIOBOIEI<TData> JHAADFFNDIG);

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CBHLHLGJKKO();
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class PKIEKMMOHGL<TData> : EFMKOODMAJI<JGOCAAFACDJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly FAJFDCOMLNI<TData> JHAADFFNDIG;

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x4BE7870", Offset = "0x4BE6870", VA = "0x184BE7870")]
	public PKIEKMMOHGL(IEnumerable<TData> JCJBLFPIMAJ, NPNHMPJJEOO DANHKIEIFNH, OLBGPBMGBBB BIDMCIBAHOL, float DJEANKPEOMM, bool CNAHFDJPKEK, JGOCAAFACDJ<TData> BGLJKFHLJGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x437C270", Offset = "0x437B270", VA = "0x18437C270", Slot = "4")]
	public override bool IALMCJCIBIH()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class GBANMOMAFEF<TData> : EFMKOODMAJI<KBHJAKGHMFH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly DBGHMDCCLDG<TData> JHAADFFNDIG;

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x40E0780", Offset = "0x40DF780", VA = "0x1840E0780")]
	public GBANMOMAFEF(TData[] JCJBLFPIMAJ, NPNHMPJJEOO[] DANHKIEIFNH, OLBGPBMGBBB[] BIDMCIBAHOL, float[] DJEANKPEOMM, KBHJAKGHMFH<TData> BGLJKFHLJGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x40E05D0", Offset = "0x40DF5D0", VA = "0x1840E05D0", Slot = "4")]
	public override bool IALMCJCIBIH()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class JHEPGDHGCBN<TData> : EFMKOODMAJI<FOGGFLPNHBO<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x3C4C550", Offset = "0x3C4B550", VA = "0x183C4C550")]
	public JHEPGDHGCBN(FOGGFLPNHBO<TData> BGLJKFHLJGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x458FE60", Offset = "0x458EE60", VA = "0x18458FE60", Slot = "4")]
	public override bool IALMCJCIBIH()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public class HEODEJCIOJO<TData> : EFMKOODMAJI<FOGGFLPNHBO<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly FCKCIOBOIEI<TData> JHAADFFNDIG;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x41E8800", Offset = "0x41E7800", VA = "0x1841E8800")]
	public HEODEJCIOJO(IEnumerable<TData> JCJBLFPIMAJ, NPNHMPJJEOO DANHKIEIFNH, OLBGPBMGBBB BIDMCIBAHOL, float DJEANKPEOMM, FOGGFLPNHBO<TData> BGLJKFHLJGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x40E05D0", Offset = "0x40DF5D0", VA = "0x1840E05D0", Slot = "4")]
	public override bool IALMCJCIBIH()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public struct FAJFDCOMLNI<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public IEnumerable<TData> JDIMMEFHIGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public NPNHMPJJEOO EBJKJODGGDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public OLBGPBMGBBB DBFEFIMCDNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public float DJEANKPEOMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public bool CNAHFDJPKEK;

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x3FEBA00", Offset = "0x3FEAA00", VA = "0x183FEBA00")]
	public FAJFDCOMLNI(IEnumerable<TData> JCJBLFPIMAJ, NPNHMPJJEOO DANHKIEIFNH, OLBGPBMGBBB BIDMCIBAHOL, float DJEANKPEOMM, bool CNAHFDJPKEK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public struct DBGHMDCCLDG<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public TData[] JDIMMEFHIGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public NPNHMPJJEOO[] EBJKJODGGDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public OLBGPBMGBBB[] DBFEFIMCDNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public float[] DJEANKPEOMM;

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x5D4D640", Offset = "0x5D4C640", VA = "0x185D4D640")]
	public DBGHMDCCLDG(TData[] JCJBLFPIMAJ, NPNHMPJJEOO[] DANHKIEIFNH, OLBGPBMGBBB[] BIDMCIBAHOL, float[] DJEANKPEOMM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public struct FCKCIOBOIEI<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public IEnumerable<TData> JDIMMEFHIGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public NPNHMPJJEOO EBJKJODGGDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public OLBGPBMGBBB DBFEFIMCDNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public float DJEANKPEOMM;

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x3FF0DB0", Offset = "0x3FEFDB0", VA = "0x183FF0DB0")]
	public FCKCIOBOIEI(IEnumerable<TData> JCJBLFPIMAJ, NPNHMPJJEOO DANHKIEIFNH, OLBGPBMGBBB BIDMCIBAHOL, float DJEANKPEOMM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public interface JHGNPKJAGOO<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PAKMCKLIIPB([In] HAODPOHKDJC<TData> ANEOFKEPCMN);

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EFJKBICNFLF([In] HAODPOHKDJC<TData> ANEOFKEPCMN);

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GGPJIFGFNFN([In] bool MLPBDDGPBGE);

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool PPGBMMFLCPJ([In] HAODPOHKDJC<TData> ANEOFKEPCMN);

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KHHEHGJKEEA();

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool JCLMMHEAGNF([In] TData FFIODMMCMJD);
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public class LNFGKDMCLME<TData> : EFMKOODMAJI<JHGNPKJAGOO<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly HAODPOHKDJC<TData> ANEOFKEPCMN;

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x4760D90", Offset = "0x475FD90", VA = "0x184760D90")]
	public LNFGKDMCLME(List<TData> LCHNOCELOBI, JHGNPKJAGOO<TData> BGLJKFHLJGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x437C270", Offset = "0x437B270", VA = "0x18437C270", Slot = "4")]
	public override bool IALMCJCIBIH()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class PENINPBDMHK<TData> : EFMKOODMAJI<JHGNPKJAGOO<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x3C4C550", Offset = "0x3C4B550", VA = "0x183C4C550")]
	public PENINPBDMHK(JHGNPKJAGOO<TData> BGLJKFHLJGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x4BDBE90", Offset = "0x4BDAE90", VA = "0x184BDBE90", Slot = "4")]
	public override bool IALMCJCIBIH()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class KELDACCCFNP<TData> : EFMKOODMAJI<JHGNPKJAGOO<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly bool CNAHFDJPKEK;

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x466EAF0", Offset = "0x466DAF0", VA = "0x18466EAF0")]
	public KELDACCCFNP(bool CNAHFDJPKEK, JHGNPKJAGOO<TData> BGLJKFHLJGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x466EA90", Offset = "0x466DA90", VA = "0x18466EA90", Slot = "4")]
	public override bool IALMCJCIBIH()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public class AHHONPGOBHB<TData> : EFMKOODMAJI<JHGNPKJAGOO<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly HAODPOHKDJC<TData> ANEOFKEPCMN;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x41A12B0", Offset = "0x41A02B0", VA = "0x1841A12B0")]
	public AHHONPGOBHB(List<TData> LCHNOCELOBI, bool CNAHFDJPKEK, JHGNPKJAGOO<TData> BGLJKFHLJGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x4172A60", Offset = "0x4171A60", VA = "0x184172A60", Slot = "4")]
	public override bool IALMCJCIBIH()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class LKBNLNDGKEP<TData> : EFMKOODMAJI<JHGNPKJAGOO<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private readonly TData FFIODMMCMJD;

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x475C030", Offset = "0x475B030", VA = "0x18475C030")]
	public LKBNLNDGKEP(TData FFIODMMCMJD, JHGNPKJAGOO<TData> BGLJKFHLJGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x475BF70", Offset = "0x475AF70", VA = "0x18475BF70", Slot = "4")]
	public override bool IALMCJCIBIH()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class KJCIJGCJCBM<TData> : EFMKOODMAJI<JHGNPKJAGOO<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly HAODPOHKDJC<TData> ANEOFKEPCMN;

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x4689900", Offset = "0x4688900", VA = "0x184689900")]
	public KJCIJGCJCBM(IEnumerable<TData> LCHNOCELOBI, JHGNPKJAGOO<TData> BGLJKFHLJGM, bool CNAHFDJPKEK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x4689790", Offset = "0x4688790", VA = "0x184689790", Slot = "4")]
	public override bool IALMCJCIBIH()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public struct HAODPOHKDJC<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public IEnumerable<TData> JDIMMEFHIGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public bool CNAHFDJPKEK;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x41D63B0", Offset = "0x41D53B0", VA = "0x1841D63B0")]
	public HAODPOHKDJC(IEnumerable<TData> BJAPBNLJMJK, bool PPNBJMFMABN = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public interface DDFCPGFNKJD
{
	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<CNCPFEDCKAP> IALMCJCIBIH(POPFFALPOLB JJDPKEIDFLN);
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public class IFNAKLEPMFE : KACMBIALKLP<DDFCPGFNKJD, CNCPFEDCKAP>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private struct HHLFALIOPLB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public AsyncTaskMethodBuilder<CNCPFEDCKAP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public IFNAKLEPMFE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private TaskAwaiter<CNCPFEDCKAP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x6EF7E20", Offset = "0x6EF6E20", VA = "0x186EF7E20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6EF80A0", Offset = "0x6EF70A0", VA = "0x186EF80A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly POPFFALPOLB BMCJCAAMGEK;

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6EF8240", Offset = "0x6EF7240", VA = "0x186EF8240")]
	public IFNAKLEPMFE(bool CNAHFDJPKEK, DDFCPGFNKJD BGLJKFHLJGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6EF8150", Offset = "0x6EF7150", VA = "0x186EF8150", Slot = "4")]
	[AsyncStateMachine(typeof(HHLFALIOPLB))]
	public override Task<CNCPFEDCKAP> IALMCJCIBIH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public struct POPFFALPOLB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public bool DNJILKHGMOE;

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x24BC480", Offset = "0x24BB480", VA = "0x1824BC480")]
	public POPFFALPOLB(bool CNAHFDJPKEK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public readonly struct COHOGPAIAJE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly bool FDCDKJLBACC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public readonly bool EKGMHGIPNGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public readonly bool KBGFEDJHNAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public readonly bool CNAHFDJPKEK;

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x515A5C0", Offset = "0x51595C0", VA = "0x18515A5C0")]
	public COHOGPAIAJE(bool FDCDKJLBACC, bool EKGMHGIPNGE, bool KBGFEDJHNAE, bool CNAHFDJPKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x6EF7D30", Offset = "0x6EF6D30", VA = "0x186EF7D30")]
	public COHOGPAIAJE(bool EKGMHGIPNGE, bool CNAHFDJPKEK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public interface DHADONINLKD
{
	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GGOIKLANFLM(COHOGPAIAJE EECBIECNGJO);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NEEKBDMGNDF(COHOGPAIAJE EECBIECNGJO);
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class GDGIEIGDCCF : EFMKOODMAJI<DHADONINLKD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly COHOGPAIAJE EECBIECNGJO;

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6EF7D90", Offset = "0x6EF6D90", VA = "0x186EF7D90")]
	public GDGIEIGDCCF(bool IMCFIOFNLHP, bool EKGMHGIPNGE, bool KBGFEDJHNAE, bool CNAHFDJPKEK, DHADONINLKD BGLJKFHLJGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x6EF7D40", Offset = "0x6EF6D40", VA = "0x186EF7D40", Slot = "4")]
	public override bool IALMCJCIBIH()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public class JMPNKCOKAHF : EFMKOODMAJI<DHADONINLKD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly COHOGPAIAJE EECBIECNGJO;

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x6EF86B0", Offset = "0x6EF76B0", VA = "0x186EF86B0")]
	public JMPNKCOKAHF(bool EKGMHGIPNGE, bool CNAHFDJPKEK, DHADONINLKD BGLJKFHLJGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x6EF8660", Offset = "0x6EF7660", VA = "0x186EF8660", Slot = "4")]
	public override bool IALMCJCIBIH()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public interface DIJOOOKDIAF
{
	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IALMCJCIBIH([In] JPFMBEGEBNF MDIGMCKELIK);
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class IPIJOGAGLOO : EFMKOODMAJI<DIJOOOKDIAF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly JPFMBEGEBNF MDIGMCKELIK;

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x6EF8460", Offset = "0x6EF7460", VA = "0x186EF8460")]
	public IPIJOGAGLOO(Guid[] DOFJKNJHCCE, Vector3[] EJBCGLMBPJB, Quaternion[] ECFAGKIGDNN, float[] OMMPPPAGFNO, Dictionary<Guid, Vector3> JNEHFHFKPMI, DIJOOOKDIAF BGLJKFHLJGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x6EF83B0", Offset = "0x6EF73B0", VA = "0x186EF83B0", Slot = "4")]
	public override bool IALMCJCIBIH()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public interface GIMADIDPCBH<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OMENOEDKBHE([In] OJENMEFPLMI<TData> PEDINFMMANF);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool PBPLGGNGNBE([In] JMMNOMNLAGL EFAJKAILHEF);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool PBPLGGNGNBE([In] IAIOCNMEAHK EFAJKAILHEF);

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool CBHLHLGJKKO();
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public class NCLKPOIOPOO<TData> : EFMKOODMAJI<GIMADIDPCBH<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x3C4C550", Offset = "0x3C4B550", VA = "0x183C4C550")]
	public NCLKPOIOPOO(GIMADIDPCBH<TData> BGLJKFHLJGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x49C5730", Offset = "0x49C4730", VA = "0x1849C5730", Slot = "4")]
	public override bool IALMCJCIBIH()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public class AEIBAGGJBAD<TData> : EFMKOODMAJI<GIMADIDPCBH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly JMMNOMNLAGL PDDGDPOLBEE;

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x4092DD0", Offset = "0x4091DD0", VA = "0x184092DD0")]
	public AEIBAGGJBAD(Vector3 JMDBINLCBFD, bool HPHHEFPEMLA, GIMADIDPCBH<TData> BGLJKFHLJGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x3C4B6E0", Offset = "0x3C4A6E0", VA = "0x183C4B6E0", Slot = "4")]
	public override bool IALMCJCIBIH()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class KOAHALKKEMA<TData> : EFMKOODMAJI<GIMADIDPCBH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly IAIOCNMEAHK PDDGDPOLBEE;

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x46A9700", Offset = "0x46A8700", VA = "0x1846A9700")]
	public KOAHALKKEMA(Guid OOALKEOMNJG, int KHAIDMGPIED, Vector3 PAMMLHPIJIB, Quaternion JKJHCABJJIO, float PEGACPFCNHH, bool HPHHEFPEMLA, GIMADIDPCBH<TData> BGLJKFHLJGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x46A96A0", Offset = "0x46A86A0", VA = "0x1846A96A0", Slot = "4")]
	public override bool IALMCJCIBIH()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public class BCKHBONCNIF<TData> : EFMKOODMAJI<GIMADIDPCBH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly OJENMEFPLMI<TData> PDDGDPOLBEE;

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x52F9D30", Offset = "0x52F8D30", VA = "0x1852F9D30")]
	public BCKHBONCNIF(TData CECLKDDLGFE, bool CNAHFDJPKEK, GIMADIDPCBH<TData> BGLJKFHLJGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x437C270", Offset = "0x437B270", VA = "0x18437C270", Slot = "4")]
	public override bool IALMCJCIBIH()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public struct JMMNOMNLAGL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public readonly Vector3 JMDBINLCBFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public readonly bool HPHHEFPEMLA;

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6EF8640", Offset = "0x6EF7640", VA = "0x186EF8640")]
	public JMMNOMNLAGL(Vector3 JMDBINLCBFD, bool HPHHEFPEMLA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public struct IAIOCNMEAHK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public readonly Guid OOALKEOMNJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public readonly int KHAIDMGPIED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public readonly Vector3 PAMMLHPIJIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public readonly Quaternion JKJHCABJJIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public readonly float PEGACPFCNHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public readonly bool HPHHEFPEMLA;

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x6EF8110", Offset = "0x6EF7110", VA = "0x186EF8110")]
	public IAIOCNMEAHK(Guid OOALKEOMNJG, int KHAIDMGPIED, Vector3 PAMMLHPIJIB, Quaternion JKJHCABJJIO, float PEGACPFCNHH, bool HPHHEFPEMLA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public struct OJENMEFPLMI<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public readonly TData CECLKDDLGFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public readonly bool CNAHFDJPKEK;

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x4B16600", Offset = "0x4B15600", VA = "0x184B16600")]
	public OJENMEFPLMI(TData CECLKDDLGFE, bool CNAHFDJPKEK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public interface DNPJLGKIGAN<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IALMCJCIBIH([In] KPAIKBCOPAI<TData> NDIJHLOPPGK);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool IALMCJCIBIH([In] CNNPEIJECDA<TData> NDIJHLOPPGK);
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public interface FOOGPMAEFIN<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OMENOEDKBHE([In] EKLHMPBOODM<TData> HAOHDCDLIFN);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool PBPLGGNGNBE([In] BFGMDIJNKJD EFAJKAILHEF);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool CBHLHLGJKKO();
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public class POKIMNIDJCE<TData> : EFMKOODMAJI<DNPJLGKIGAN<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly KPAIKBCOPAI<TData> NDIJHLOPPGK;

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x4BEA770", Offset = "0x4BE9770", VA = "0x184BEA770")]
	public POKIMNIDJCE(IEnumerable<TData> JCJBLFPIMAJ, Vector3 KDBEGDDLMCM, bool CNAHFDJPKEK, DNPJLGKIGAN<TData> BGLJKFHLJGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x437C270", Offset = "0x437B270", VA = "0x18437C270", Slot = "4")]
	public override bool IALMCJCIBIH()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class MFOOLAKKJED<TData> : EFMKOODMAJI<FOOGPMAEFIN<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x3C4C550", Offset = "0x3C4B550", VA = "0x183C4C550")]
	public MFOOLAKKJED(FOOGPMAEFIN<TData> BGLJKFHLJGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x3FF4B50", Offset = "0x3FF3B50", VA = "0x183FF4B50", Slot = "4")]
	public override bool IALMCJCIBIH()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class NBGFDPNFECL<TData> : EFMKOODMAJI<FOOGPMAEFIN<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly EKLHMPBOODM<TData> NDIJHLOPPGK;

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x49C09C0", Offset = "0x49BF9C0", VA = "0x1849C09C0")]
	public NBGFDPNFECL(IEnumerable<TData> JCJBLFPIMAJ, bool CNAHFDJPKEK, FOOGPMAEFIN<TData> BGLJKFHLJGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x437C270", Offset = "0x437B270", VA = "0x18437C270", Slot = "4")]
	public override bool IALMCJCIBIH()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class GDAGLIECMJC<TData> : EFMKOODMAJI<DNPJLGKIGAN<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly CNNPEIJECDA<TData> NDIJHLOPPGK;

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x40E9CE0", Offset = "0x40E8CE0", VA = "0x1840E9CE0")]
	public GDAGLIECMJC(IEnumerable<TData> JCJBLFPIMAJ, Vector3 JEMOAFKDGKF, NIDEIFPEPFL DJICPGLKHAB, bool CNAHFDJPKEK, DNPJLGKIGAN<TData> BGLJKFHLJGM, Space BPEAJPGDPCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x40E9C20", Offset = "0x40E8C20", VA = "0x1840E9C20", Slot = "4")]
	public override bool IALMCJCIBIH()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public class EENHEHKHAKO<TData> : EFMKOODMAJI<FOOGPMAEFIN<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly BFGMDIJNKJD NDIJHLOPPGK;

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x3C4B740", Offset = "0x3C4A740", VA = "0x183C4B740")]
	public EENHEHKHAKO(Vector3 KDBEGDDLMCM, FOOGPMAEFIN<TData> BGLJKFHLJGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x3C4B6E0", Offset = "0x3C4A6E0", VA = "0x183C4B6E0", Slot = "4")]
	public override bool IALMCJCIBIH()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public struct KPAIKBCOPAI<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public readonly IEnumerable<TData> JCJBLFPIMAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public readonly Vector3 KDBEGDDLMCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public readonly bool CNAHFDJPKEK;

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x46ABE30", Offset = "0x46AAE30", VA = "0x1846ABE30")]
	public KPAIKBCOPAI(IEnumerable<TData> JCJBLFPIMAJ, Vector3 KDBEGDDLMCM, bool CNAHFDJPKEK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public struct EKLHMPBOODM<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public readonly IEnumerable<TData> JCJBLFPIMAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public readonly bool CNAHFDJPKEK;

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x3C67970", Offset = "0x3C66970", VA = "0x183C67970")]
	public EKLHMPBOODM(IEnumerable<TData> JCJBLFPIMAJ, bool CNAHFDJPKEK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public struct CNNPEIJECDA<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public readonly IEnumerable<TData> JCJBLFPIMAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public readonly Vector3 JEMOAFKDGKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public readonly NIDEIFPEPFL DJICPGLKHAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public readonly bool CNAHFDJPKEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public readonly Space BPEAJPGDPCN;

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x59E3470", Offset = "0x59E2470", VA = "0x1859E3470")]
	public CNNPEIJECDA(IEnumerable<TData> JCJBLFPIMAJ, Vector3 JEMOAFKDGKF, NIDEIFPEPFL DJICPGLKHAB, bool CNAHFDJPKEK, Space BPEAJPGDPCN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public struct BFGMDIJNKJD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public readonly Vector3 KDBEGDDLMCM;

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x24BC570", Offset = "0x24BB570", VA = "0x1824BC570")]
	public BFGMDIJNKJD(Vector3 KDBEGDDLMCM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public enum NIDEIFPEPFL
{
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	XYZ,
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	X_only,
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	Y_only,
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	Z_only
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public interface GJKGEFKBMCI
{
	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IALMCJCIBIH([In] NODCKHIFLNN DFKPKKGGMOF);
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public class IGEGPNDFEBK : EFMKOODMAJI<GJKGEFKBMCI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly NODCKHIFLNN DFKPKKGGMOF;

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x6EF8350", Offset = "0x6EF7350", VA = "0x186EF8350")]
	public IGEGPNDFEBK(bool CNAHFDJPKEK, GJKGEFKBMCI BGLJKFHLJGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x6EF82A0", Offset = "0x6EF72A0", VA = "0x186EF82A0", Slot = "4")]
	public override bool IALMCJCIBIH()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public readonly struct NODCKHIFLNN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public readonly bool CNAHFDJPKEK;

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x24BC480", Offset = "0x24BB480", VA = "0x1824BC480")]
	public NODCKHIFLNN(bool CNAHFDJPKEK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public interface DCFECMIPDEK<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IALMCJCIBIH([In] IAKPIKDOPKP<TData> JDBNHJHDKAI);

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool IALMCJCIBIH([In] AMMIHIKAJDC<TData> JDBNHJHDKAI);
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public interface HCABBADOBPN<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OMENOEDKBHE([In] HPEDKAKMCJN<TData> PEDINFMMANF);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool PBPLGGNGNBE([In] JEJDKJPBPHB EFAJKAILHEF);

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool CBHLHLGJKKO();
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public class LAMKCJICPAP<TData> : EFMKOODMAJI<DCFECMIPDEK<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly IAKPIKDOPKP<TData> JDBNHJHDKAI;

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x4712330", Offset = "0x4711330", VA = "0x184712330")]
	public LAMKCJICPAP(IEnumerable<TData> JCJBLFPIMAJ, Quaternion KDBEGDDLMCM, Vector3? OAOKKHHAMGM, bool DLDKKFLNKHC, bool CNAHFDJPKEK, DCFECMIPDEK<TData> BGLJKFHLJGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x437C270", Offset = "0x437B270", VA = "0x18437C270", Slot = "4")]
	public override bool IALMCJCIBIH()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public class FFDDJNANBJD<TData> : EFMKOODMAJI<HCABBADOBPN<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x3C4C550", Offset = "0x3C4B550", VA = "0x183C4C550")]
	public FFDDJNANBJD(HCABBADOBPN<TData> BGLJKFHLJGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x3FF4B50", Offset = "0x3FF3B50", VA = "0x183FF4B50", Slot = "4")]
	public override bool IALMCJCIBIH()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public class CAODABOGMDM<TData> : EFMKOODMAJI<HCABBADOBPN<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly HPEDKAKMCJN<TData> JDBNHJHDKAI;

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x5705C70", Offset = "0x5704C70", VA = "0x185705C70")]
	public CAODABOGMDM(IEnumerable<TData> JCJBLFPIMAJ, bool CNAHFDJPKEK, HCABBADOBPN<TData> BGLJKFHLJGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x437C270", Offset = "0x437B270", VA = "0x18437C270", Slot = "4")]
	public override bool IALMCJCIBIH()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public class NOBBBPHJDHI<TData> : EFMKOODMAJI<DCFECMIPDEK<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly AMMIHIKAJDC<TData> JDBNHJHDKAI;

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x49FE7F0", Offset = "0x49FD7F0", VA = "0x1849FE7F0")]
	public NOBBBPHJDHI(IEnumerable<TData> JCJBLFPIMAJ, Quaternion DNJIGOLGPMK, NIDEIFPEPFL OEKIIMPMKKJ, Vector3? OAOKKHHAMGM, bool DLDKKFLNKHC, bool CNAHFDJPKEK, Space BPEAJPGDPCN, DCFECMIPDEK<TData> BGLJKFHLJGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x40E9C20", Offset = "0x40E8C20", VA = "0x1840E9C20", Slot = "4")]
	public override bool IALMCJCIBIH()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public class DFEMHPBNPJD<TData> : EFMKOODMAJI<HCABBADOBPN<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly JEJDKJPBPHB JDBNHJHDKAI;

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x5D76AC0", Offset = "0x5D75AC0", VA = "0x185D76AC0")]
	public DFEMHPBNPJD(Quaternion KDBEGDDLMCM, Vector3? OAOKKHHAMGM, bool DLDKKFLNKHC, HCABBADOBPN<TData> BGLJKFHLJGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x3C4B6E0", Offset = "0x3C4A6E0", VA = "0x183C4B6E0", Slot = "4")]
	public override bool IALMCJCIBIH()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public struct IAKPIKDOPKP<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public readonly IEnumerable<TData> JCJBLFPIMAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public readonly Quaternion KDBEGDDLMCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public readonly Vector3? OAOKKHHAMGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public readonly bool DLDKKFLNKHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public readonly bool CNAHFDJPKEK;

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x42E4020", Offset = "0x42E3020", VA = "0x1842E4020")]
	public IAKPIKDOPKP(IEnumerable<TData> JCJBLFPIMAJ, Quaternion KDBEGDDLMCM, Vector3? OAOKKHHAMGM, bool DLDKKFLNKHC, bool CNAHFDJPKEK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public struct HPEDKAKMCJN<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public readonly IEnumerable<TData> JCJBLFPIMAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public readonly bool CNAHFDJPKEK;

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x422BD10", Offset = "0x422AD10", VA = "0x18422BD10")]
	public HPEDKAKMCJN(IEnumerable<TData> JCJBLFPIMAJ, bool CNAHFDJPKEK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public struct AMMIHIKAJDC<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public readonly IEnumerable<TData> JCJBLFPIMAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public readonly Quaternion DNJIGOLGPMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public readonly NIDEIFPEPFL OEKIIMPMKKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public readonly Vector3? OAOKKHHAMGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public readonly bool DLDKKFLNKHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public readonly bool CNAHFDJPKEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public readonly Space BPEAJPGDPCN;

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x42C2CC0", Offset = "0x42C1CC0", VA = "0x1842C2CC0")]
	public AMMIHIKAJDC(IEnumerable<TData> JCJBLFPIMAJ, Quaternion DNJIGOLGPMK, NIDEIFPEPFL OEKIIMPMKKJ, Vector3? OAOKKHHAMGM, bool DLDKKFLNKHC, bool CNAHFDJPKEK, Space BPEAJPGDPCN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public struct JEJDKJPBPHB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public readonly Quaternion KDBEGDDLMCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public readonly Vector3? OAOKKHHAMGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public readonly bool DLDKKFLNKHC;

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x5113400", Offset = "0x5112400", VA = "0x185113400")]
	public JEJDKJPBPHB(Quaternion KDBEGDDLMCM, Vector3? OAOKKHHAMGM, bool DLDKKFLNKHC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public interface AAFOOPABBOM<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OMENOEDKBHE([In] OFNFPJALCJB<TData> PEDINFMMANF);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool PBPLGGNGNBE([In] DOOIDJDNNKM EFAJKAILHEF);

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool PBPLGGNGNBE([In] PHPLAGLGDOD EFAJKAILHEF);

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool PBPLGGNGNBE([In] LADHIKMOLFA EFAJKAILHEF);

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool CBHLHLGJKKO();
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public class GNENMKBELCP<TData> : EFMKOODMAJI<AAFOOPABBOM<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly LADHIKMOLFA CFLLMINLMIE;

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x418EFF0", Offset = "0x418DFF0", VA = "0x18418EFF0")]
	public GNENMKBELCP(Vector3 AMHKJGGAABJ, float OPMJCEFOCMG, Vector3 OAOKKHHAMGM, bool FCJKLPFOHMM, bool HJJNBDFPMOP, AAFOOPABBOM<TData> BGLJKFHLJGM, Space BPEAJPGDPCN = Space.Self)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x418EF90", Offset = "0x418DF90", VA = "0x18418EF90", Slot = "4")]
	public override bool IALMCJCIBIH()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public class NABPIGBHBCJ<TData> : EFMKOODMAJI<AAFOOPABBOM<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x3C4C550", Offset = "0x3C4B550", VA = "0x183C4C550")]
	public NABPIGBHBCJ(AAFOOPABBOM<TData> BGLJKFHLJGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x49B6CB0", Offset = "0x49B5CB0", VA = "0x1849B6CB0", Slot = "4")]
	public override bool IALMCJCIBIH()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public class DKBBKIDLJJK<TData> : EFMKOODMAJI<AAFOOPABBOM<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly OFNFPJALCJB<TData> CFLLMINLMIE;

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x5DBA260", Offset = "0x5DB9260", VA = "0x185DBA260")]
	public DKBBKIDLJJK(IEnumerable<TData> JCJBLFPIMAJ, bool CNAHFDJPKEK, AAFOOPABBOM<TData> BGLJKFHLJGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x437C270", Offset = "0x437B270", VA = "0x18437C270", Slot = "4")]
	public override bool IALMCJCIBIH()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public class HBFDKBLEAMO<TData> : EFMKOODMAJI<AAFOOPABBOM<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly PHPLAGLGDOD CFLLMINLMIE;

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x41D6F20", Offset = "0x41D5F20", VA = "0x1841D6F20")]
	public HBFDKBLEAMO(float CMKILBJNKIC, bool MJCKHOLIFEL, Vector3 OAOKKHHAMGM, AAFOOPABBOM<TData> BGLJKFHLJGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x41D6E60", Offset = "0x41D5E60", VA = "0x1841D6E60", Slot = "4")]
	public override bool IALMCJCIBIH()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public class FEJCNOIHECH<TData> : EFMKOODMAJI<AAFOOPABBOM<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly DOOIDJDNNKM CFLLMINLMIE;

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x3FF3160", Offset = "0x3FF2160", VA = "0x183FF3160")]
	public FEJCNOIHECH(float OPMJCEFOCMG, Vector3 OAOKKHHAMGM, AAFOOPABBOM<TData> BGLJKFHLJGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x3C4B6E0", Offset = "0x3C4A6E0", VA = "0x183C4B6E0", Slot = "4")]
	public override bool IALMCJCIBIH()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public struct LADHIKMOLFA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public readonly Vector3 AMHKJGGAABJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public readonly float OPMJCEFOCMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public readonly Vector3 OAOKKHHAMGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public readonly bool HPHHEFPEMLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public readonly Space BPEAJPGDPCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public readonly bool HJJNBDFPMOP;

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x6EF8CE0", Offset = "0x6EF7CE0", VA = "0x186EF8CE0")]
	public LADHIKMOLFA(Vector3 AMHKJGGAABJ, float OPMJCEFOCMG, Vector3 OAOKKHHAMGM, bool HPHHEFPEMLA, bool LAAFKIHIJDN, Space BPEAJPGDPCN = Space.Self)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public struct OFNFPJALCJB<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public readonly IEnumerable<TData> JCJBLFPIMAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public readonly bool CNAHFDJPKEK;

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x4B10120", Offset = "0x4B0F120", VA = "0x184B10120")]
	public OFNFPJALCJB(IEnumerable<TData> JCJBLFPIMAJ, bool CNAHFDJPKEK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public struct PHPLAGLGDOD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public readonly float CMKILBJNKIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public readonly bool MJCKHOLIFEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public readonly Vector3 OAOKKHHAMGM;

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x6EF9380", Offset = "0x6EF8380", VA = "0x186EF9380")]
	public PHPLAGLGDOD(float CMKILBJNKIC, bool MJCKHOLIFEL, Vector3 OAOKKHHAMGM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public struct DOOIDJDNNKM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public readonly float OPMJCEFOCMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public readonly Vector3 OAOKKHHAMGM;

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x50EE5E0", Offset = "0x50ED5E0", VA = "0x1850EE5E0")]
	public DOOIDJDNNKM(float OPMJCEFOCMG, Vector3 OAOKKHHAMGM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public struct JPFMBEGEBNF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public readonly Guid[] JCJBLFPIMAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public readonly bool GGKMFELFNOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public readonly bool HMCKPAPFPFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public readonly bool KOBIMAAAJBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public readonly Vector3[] EJBCGLMBPJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public readonly Quaternion[] ECFAGKIGDNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public readonly float[] OMMPPPAGFNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public readonly Dictionary<Guid, Vector3> JNEHFHFKPMI;

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x6EF8900", Offset = "0x6EF7900", VA = "0x186EF8900")]
	public JPFMBEGEBNF(Guid[] DOFJKNJHCCE, Vector3[] EJBCGLMBPJB, Quaternion[] ECFAGKIGDNN, float[] OMMPPPAGFNO, Dictionary<Guid, Vector3> JNEHFHFKPMI, bool GGKMFELFNOH = true, bool HMCKPAPFPFL = true, bool KOBIMAAAJBF = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x6EF8730", Offset = "0x6EF7730", VA = "0x186EF8730")]
	private static void JGGKDEEAIDF(Dictionary<Guid, Vector3> JNEHFHFKPMI, int BPOGKLKBELP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public static class NDLNFODFPMH
{
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	private struct PGKOBIPBOKI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public bool HJIHHDKKOIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public MAONAIOKEHK KCDIPLANOJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public MAONAIOKEHK HOBNAKCBHID;
	}

	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private static PGKOBIPBOKI HKBPKAINBJI;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static CancellationToken FMPODIFCDLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x6EF9190", Offset = "0x6EF8190", VA = "0x186EF9190")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	internal static MAONAIOKEHK KCDIPLANOJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x6EF8F50", Offset = "0x6EF7F50", VA = "0x186EF8F50")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x6EF91B0", Offset = "0x6EF81B0", VA = "0x186EF91B0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x6EF9210", Offset = "0x6EF8210", VA = "0x186EF9210")]
	[AEDCCIMPEFD.OFLDIEMPABC]
	internal static void MHIJNHBLKEJ(MAONAIOKEHK DKKBHACBDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x6EF9040", Offset = "0x6EF8040", VA = "0x186EF9040")]
	public static void CMJEOBEPHJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x6EF8FF0", Offset = "0x6EF7FF0", VA = "0x186EF8FF0")]
	private static MAONAIOKEHK CFPMLCJJCKL(MAONAIOKEHK FOEMAPKAAKA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public static class DAJJIGCJILD
{
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	public enum BONPHOFPGGB
	{
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		ICreationContextObject,
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		Guid
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x2DB5E90", Offset = "0x2DB4E90", VA = "0x182DB5E90")]
	public static void GDFMPBNEIEJ<T>(T DKOIJBOMAJG, BONPHOFPGGB PFCMGBLCCPJ) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x2DB5FF0", Offset = "0x2DB4FF0", VA = "0x182DB5FF0")]
	public static void GDFMPBNEIEJ<T>(T DKOIJBOMAJG) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x2DB5DE0", Offset = "0x2DB4DE0", VA = "0x182DB5DE0")]
	public static void FGJCEOMBNPP<T>(T DKOIJBOMAJG) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x2DB6060", Offset = "0x2DB5060", VA = "0x182DB6060")]
	public static T KIJHOBDIGPJ<T>(BONPHOFPGGB PFCMGBLCCPJ) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x2DB61D0", Offset = "0x2DB51D0", VA = "0x182DB61D0")]
	public static bool OKBNAJGEJDO<T>(BONPHOFPGGB PFCMGBLCCPJ, T? EKMHIKBFFHM, [Out][MaybeNullWhen(false)][NotNullWhen(true)] T BLDLGDDDKKF) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x2DB5D30", Offset = "0x2DB4D30", VA = "0x182DB5D30")]
	public static bool CKLDDDHHPAO<T>(BONPHOFPGGB PFCMGBLCCPJ) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x2DB5CD0", Offset = "0x2DB4CD0", VA = "0x182DB5CD0")]
	public static T KIJHOBDIGPJ<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x2DB6110", Offset = "0x2DB5110", VA = "0x182DB6110")]
	public static bool OKBNAJGEJDO<T>(T EKMHIKBFFHM, [Out] T BLDLGDDDKKF) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x2DB5CD0", Offset = "0x2DB4CD0", VA = "0x182DB5CD0")]
	public static bool CKLDDDHHPAO<T>() where T : class
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
internal static class LMHBGOHLFKI
{
	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x6EF8D20", Offset = "0x6EF7D20", VA = "0x186EF8D20")]
	public static void CMOFAEJICMJ(IEnumerable IGEFJMAOENB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x306BD00", Offset = "0x306AD00", VA = "0x18306BD00")]
	public static void CMOFAEJICMJ<T>(T[] CHPMBGHOEJI) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x306BEE0", Offset = "0x306AEE0", VA = "0x18306BEE0")]
	public static void CMOFAEJICMJ<T>(T FIAIOBCELLH) where T : notnull, Enum
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
