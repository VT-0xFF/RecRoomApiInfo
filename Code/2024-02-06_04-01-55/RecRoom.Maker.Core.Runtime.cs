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
		[Cpp2IlInjected.Address(RVA = "0x7C9520", Offset = "0x7C8920", VA = "0x1807C9520")]
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
		[Cpp2IlInjected.Address(RVA = "0x60B2480", Offset = "0x60B1880", VA = "0x1860B2480")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7CA360", Offset = "0x7C9760", VA = "0x1807CA360")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CA3A0", Offset = "0x7C97A0", VA = "0x1807CA3A0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface DDNDCPPIPDH<TData, TReturn>
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TReturn NMKKLAEHPLI(TData BHPOPDOKECN);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface JDJFFMHGMEA<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ClearHoverTarget(AMFLIOCCAIB NLPOGDIPJCG);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool SetHoverTarget(TData JILDGEDOLHB, Collider NAGOIHOGOPC, AMFLIOCCAIB NLPOGDIPJCG, [Optional] PBFAHIGAOLI? IIKINGILAEB);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool TryGetHoverTarget([Out] TData JILDGEDOLHB);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool TryGetHoverCollider([Out] Collider NAGOIHOGOPC);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface GHHELFFMNMB<TData> : DAFPGNDOMBD, HDMGGANMIKM<TData>, IDEKDFFEMAA<TData>, LNIJOKBCILK<TData>, GCDGGAKEFOM, JFEGIEDCKHN<TData>, GPLCEKKHBJG, MOMJDIGHACD
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface JFEGIEDCKHN<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool Raycast(Vector3 KMMPCLIFELN, Vector3 PNADBCDBNOL, float FIOIECEGGAH, [Out] T HNJBJOLLKNM, [Out] Vector3 MAFFJMAKPJF, [Out] Collider NAGOIHOGOPC);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int SpherecastPick(Vector3 KMMPCLIFELN, Vector3 PNADBCDBNOL, float ONADJHBIEIN, float FIOIECEGGAH, T[] BHHEFHDONLM, [Out] Vector3 HHFFOADFLPM, [Out] Collider ABFLFDMKKFB);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int SpherePick(Vector3 KMMPCLIFELN, float ONADJHBIEIN, Vector3 FOPDAGMDFKF, T[] BHHEFHDONLM);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool TryGetObjectFromColliderInCurrentScope(Collider AILIANBMFFG, [Out] T ICLKPMKCOLC);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface DAFPGNDOMBD
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Bounds EGDDBIDDCPF
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	Transform LJCMDFHPCIE
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	Bounds LEAJABBBBLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Transform JPCHEELPNMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	Vector3 DEENJDBCACL
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool PMGBIPJCPCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void SetSelectionBoundsDirty(bool MDMHAJOOBIK = true, int OBJPNNPPEOB = 0);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ShouldHideSelectionBoundsPreview(bool DHDKDBMKPJN, object BDHKJODLPCL);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface MOMJDIGHACD
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	DICJLHNIKOO KDOOFNPBBAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface BMNNPJMODOP
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool LDCENFBIDHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool LKHGAOEFKCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool EABMCFFICCI
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
	void TrySetPreviousCloneMapping(Dictionary<Guid, Guid> IMIKDOKDBKL);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface LNIJOKBCILK<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool BBFINECEBHL
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	int CPJKMBAIJFC
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<TData> FDEJBKDJNLC
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IsSelected(TData IEEBNOOJIPC);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IsSelectable(TData IEEBNOOJIPC);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface HDMGGANMIKM<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void RenderHoverHighlight(T BHPOPDOKECN, [Optional] PBFAHIGAOLI? DBDNECKMLBJ, bool BPOFCFPPCLL = true);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RenderHoverHighlight(int CBPPKGAPPDD, IEnumerable<T> ANGBOGHIHDD, bool BPOFCFPPCLL = true);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RenderHoverHighlight(int CBPPKGAPPDD, IEnumerable<T> ANGBOGHIHDD, PBFAHIGAOLI DBDNECKMLBJ, bool BPOFCFPPCLL = true);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface GPLCEKKHBJG
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnSelectionPickedUp();

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnSelectionReleased();
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface GCDGGAKEFOM
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool HMFLKHBFKOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool LLDHIMLOEGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	bool KJNCONCPLNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	bool IOLCIMHNDCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public abstract class AOGNCBCJBJJ<TReceiver> : IKNLGEFOBOI<TReceiver, bool> where TReceiver : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x32B63D0", Offset = "0x32B57D0", VA = "0x1832B63D0")]
	public AOGNCBCJBJJ(TReceiver KNPJGAEAGFF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public abstract class IFHJPCDCBOJ<TReceiver, TFromTask> : IKNLGEFOBOI<TReceiver, Task<TFromTask>>
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x32B63D0", Offset = "0x32B57D0", VA = "0x1832B63D0")]
	public IFHJPCDCBOJ(TReceiver KNPJGAEAGFF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public abstract class IKNLGEFOBOI<TReceiver, TFromExecute> where TReceiver : notnull where TFromExecute : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	protected TReceiver KNPJGAEAGFF;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x382E650", Offset = "0x382DA50", VA = "0x18382E650")]
	public IKNLGEFOBOI(TReceiver KNPJGAEAGFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TFromExecute GPHODLAFDGD();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public abstract class MODCAMELDKK<TReceiver, TResult> : IKNLGEFOBOI<TReceiver, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x32B63D0", Offset = "0x32B57D0", VA = "0x1832B63D0")]
	public MODCAMELDKK(TReceiver KNPJGAEAGFF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct IIAJHPHKOML<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public TGroup MHJFKOGIBFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public TData ACBNMONIGGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public IEnumerable<TData> PBIGFLCIJAP;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x1A1F1B0", Offset = "0x1A1E5B0", VA = "0x181A1F1B0")]
	public IIAJHPHKOML(TGroup LFOJDFABKDO, TData MLMHIBIKPGH, IEnumerable<TData> IKPEPAECKJM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct JNENBIGCPIG<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public TGroup MHJFKOGIBFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public IEnumerable<TData> PBIGFLCIJAP;

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x87C050", Offset = "0x87B450", VA = "0x18087C050")]
	public JNENBIGCPIG(TGroup LFOJDFABKDO, IEnumerable<TData> IKPEPAECKJM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct CIEGDLCDAND<TGroup> where TGroup : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public TGroup MHJFKOGIBFO;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x8BA370", Offset = "0x8B9770", VA = "0x1808BA370")]
	public CIEGDLCDAND(TGroup LFOJDFABKDO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct KIFAKMGLKII<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public IEnumerable<TData> PBIGFLCIJAP;

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x8BA370", Offset = "0x8B9770", VA = "0x1808BA370")]
	public KIFAKMGLKII(IEnumerable<TData> IKPEPAECKJM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface DKOGPNDMDPK<TGroup, TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "0")]
	FKENBJIFMCE CJJNKDMFIIJ(IIAJHPHKOML<TGroup, TData> NFLFJEOOILI);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "1")]
	FKENBJIFMCE FMDDEECIDDL(IIAJHPHKOML<TGroup, TData> NFLFJEOOILI);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "2")]
	FKENBJIFMCE DDMIDEBHCKB(JNENBIGCPIG<TGroup, TData> NFLFJEOOILI);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "3")]
	FKENBJIFMCE KOIKIBGNJJG(CIEGDLCDAND<TGroup> NFLFJEOOILI);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface HLPEMBJHPBP<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<FKENBJIFMCE> CJJNKDMFIIJ(KIFAKMGLKII<TData> NFLFJEOOILI);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class PPEMEPFNFCG<TGroup, TData> : MODCAMELDKK<DKOGPNDMDPK<TGroup, TData>, FKENBJIFMCE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly JNENBIGCPIG<TGroup, TData> NFLFJEOOILI;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x40CAC20", Offset = "0x40CA020", VA = "0x1840CAC20")]
	public PPEMEPFNFCG(TGroup LFOJDFABKDO, IEnumerable<TData> IKPEPAECKJM, DKOGPNDMDPK<TGroup, TData> KNPJGAEAGFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x40CAB50", Offset = "0x40C9F50", VA = "0x1840CAB50", Slot = "4")]
	public override FKENBJIFMCE GPHODLAFDGD()
	{
		return default(FKENBJIFMCE);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class MCPOAJIPPNM<TGroup, TData> : MODCAMELDKK<DKOGPNDMDPK<TGroup, TData>, FKENBJIFMCE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly IIAJHPHKOML<TGroup, TData> NFLFJEOOILI;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x32BE060", Offset = "0x32BD460", VA = "0x1832BE060")]
	public MCPOAJIPPNM(TGroup LFOJDFABKDO, TData BLJEMLBLJJK, IEnumerable<TData> IKPEPAECKJM, DKOGPNDMDPK<TGroup, TData> KNPJGAEAGFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3DBA4A0", Offset = "0x3DB98A0", VA = "0x183DBA4A0", Slot = "4")]
	public override FKENBJIFMCE GPHODLAFDGD()
	{
		return default(FKENBJIFMCE);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class EAFEHKDNBCE<TGroup, TData> : MODCAMELDKK<DKOGPNDMDPK<TGroup, TData>, FKENBJIFMCE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly CIEGDLCDAND<TGroup> NFLFJEOOILI;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x329F6B0", Offset = "0x329EAB0", VA = "0x18329F6B0")]
	public EAFEHKDNBCE(TGroup LFOJDFABKDO, DKOGPNDMDPK<TGroup, TData> KNPJGAEAGFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x329F5E0", Offset = "0x329E9E0", VA = "0x18329F5E0", Slot = "4")]
	public override FKENBJIFMCE GPHODLAFDGD()
	{
		return default(FKENBJIFMCE);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class EKCNKJIHBHK<TGroup, TData> : MODCAMELDKK<DKOGPNDMDPK<TGroup, TData>, FKENBJIFMCE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly IIAJHPHKOML<TGroup, TData> NFLFJEOOILI;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x32BE060", Offset = "0x32BD460", VA = "0x1832BE060")]
	public EKCNKJIHBHK(TGroup LFOJDFABKDO, TData MLMHIBIKPGH, IEnumerable<TData> IKPEPAECKJM, DKOGPNDMDPK<TGroup, TData> KNPJGAEAGFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x32BDF80", Offset = "0x32BD380", VA = "0x1832BDF80", Slot = "4")]
	public override FKENBJIFMCE GPHODLAFDGD()
	{
		return default(FKENBJIFMCE);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class ANMKNOLHGEJ<TData> : IFHJPCDCBOJ<HLPEMBJHPBP<TData>, FKENBJIFMCE> where TData : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private struct HGDNLINHBFH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public AsyncTaskMethodBuilder<FKENBJIFMCE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public ANMKNOLHGEJ<TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private TaskAwaiter<FKENBJIFMCE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x375C4D0", Offset = "0x375B8D0", VA = "0x18375C4D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x375C770", Offset = "0x375BB70", VA = "0x18375C770", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private KIFAKMGLKII<TData> NFLFJEOOILI;

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x329F6B0", Offset = "0x329EAB0", VA = "0x18329F6B0")]
	public ANMKNOLHGEJ(IEnumerable<TData> APMBFCIMFLD, HLPEMBJHPBP<TData> KNPJGAEAGFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x37A9E70", Offset = "0x37A9270", VA = "0x1837A9E70", Slot = "4")]
	[AsyncStateMachine(typeof(ANMKNOLHGEJ<>.HGDNLINHBFH))]
	public override Task<FKENBJIFMCE> GPHODLAFDGD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public readonly struct NJBONEOPFNG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly EPBLOGPHJEA PNMKNFIDICP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly bool OHEMICEOGLC;

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x60B2460", Offset = "0x60B1860", VA = "0x1860B2460")]
	public NJBONEOPFNG(EPBLOGPHJEA FBDBAOOGHNJ, bool FAEFDAGKBNC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface HGMEBCBIAHD<TSpawnType> where TSpawnType : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> GPHODLAFDGD(NJBONEOPFNG PGKJCJIIEIB);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class GLDNBKBPBCL<TSpawnType> : IFHJPCDCBOJ<HGMEBCBIAHD<TSpawnType>, TSpawnType> where TSpawnType : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private struct NCJKMIIHPOK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public AsyncTaskMethodBuilder<TSpawnType> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public GLDNBKBPBCL<TSpawnType> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private TaskAwaiter<TSpawnType> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x3E93800", Offset = "0x3E92C00", VA = "0x183E93800", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x32BA2D0", Offset = "0x32B96D0", VA = "0x1832BA2D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly NJBONEOPFNG PGKJCJIIEIB;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3718E30", Offset = "0x3718230", VA = "0x183718E30")]
	public GLDNBKBPBCL(EPBLOGPHJEA FBDBAOOGHNJ, bool FAEFDAGKBNC, HGMEBCBIAHD<TSpawnType> KNPJGAEAGFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3718B30", Offset = "0x3717F30", VA = "0x183718B30", Slot = "4")]
	[AsyncStateMachine(typeof(GLDNBKBPBCL<>.NCJKMIIHPOK))]
	public override Task<TSpawnType> GPHODLAFDGD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public readonly struct EPBLOGPHJEA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly bool AIEMMBBMPCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public readonly Vector3 CDMAJCLKHAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly Vector3 EAICKOBNBAN;

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x60B1980", Offset = "0x60B0D80", VA = "0x1860B1980")]
	public EPBLOGPHJEA(Transform ELGBBANGCHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x60B1950", Offset = "0x60B0D50", VA = "0x1860B1950")]
	public EPBLOGPHJEA(Vector3 PKPPJECMOIC, Vector3 BEBKKMFGLCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x60B1920", Offset = "0x60B0D20", VA = "0x1860B1920")]
	public static EPBLOGPHJEA IDKMHHLNFJD()
	{
		return default(EPBLOGPHJEA);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x60B19F0", Offset = "0x60B0DF0", VA = "0x1860B19F0")]
	private EPBLOGPHJEA(bool OBFPHLNOAIG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public struct JDKHHBEBEPO<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public TNode PLLHCJKCOCJ;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x3A1B130", Offset = "0x3A1A530", VA = "0x183A1B130")]
	public JDKHHBEBEPO(TNode PLLHCJKCOCJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct EEGGMINABOA<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public TNode PJAICKAEDOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public EBHFGAAIDDM HKOOKDIAOKO;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x32A7420", Offset = "0x32A6820", VA = "0x1832A7420")]
	public EEGGMINABOA(TNode PJAICKAEDOG, EBHFGAAIDDM HKOOKDIAOKO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface PDBIGLDLPCH<TNode>
{
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CNOOAGIBHPP([In] JDKHHBEBEPO<TNode> IIJCGLICFOD);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool ANHDGOAFJJC([In] EEGGMINABOA<TNode> FLKOOIECKOM);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool NDHNOEAGBHA();
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class LMIKAPJJJEG<TNode> : AOGNCBCJBJJ<PDBIGLDLPCH<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x32B63D0", Offset = "0x32B57D0", VA = "0x1832B63D0")]
	public LMIKAPJJJEG(PDBIGLDLPCH<TNode> KNPJGAEAGFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3BD7A40", Offset = "0x3BD6E40", VA = "0x183BD7A40", Slot = "4")]
	public override bool GPHODLAFDGD()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class CCKMCGOMLGM<TNode> : AOGNCBCJBJJ<PDBIGLDLPCH<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly EEGGMINABOA<TNode> FLKOOIECKOM;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x4925B60", Offset = "0x4924F60", VA = "0x184925B60")]
	public CCKMCGOMLGM(TNode PJAICKAEDOG, EBHFGAAIDDM HKOOKDIAOKO, PDBIGLDLPCH<TNode> KNPJGAEAGFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x36BB880", Offset = "0x36BAC80", VA = "0x1836BB880", Slot = "4")]
	public override bool GPHODLAFDGD()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class GGBFDMCJHFF<TNode> : AOGNCBCJBJJ<PDBIGLDLPCH<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly JDKHHBEBEPO<TNode> IIJCGLICFOD;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x370ACB0", Offset = "0x370A0B0", VA = "0x18370ACB0")]
	public GGBFDMCJHFF(TNode DPOHGENHHFG, PDBIGLDLPCH<TNode> KNPJGAEAGFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x32B5F90", Offset = "0x32B5390", VA = "0x1832B5F90", Slot = "4")]
	public override bool GPHODLAFDGD()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct DPFJMOEBDAA<TSpawnInfo> where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public TSpawnInfo ELKKFMGIMOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public Vector3 BEBKKMFGLCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public Quaternion IKFFGJBHBIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public float LFBOEHOBPJC;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5022AB0", Offset = "0x5021EB0", VA = "0x185022AB0")]
	public DPFJMOEBDAA(TSpawnInfo ELKKFMGIMOH, Vector3 BEBKKMFGLCG, Quaternion IKFFGJBHBIC, float LFBOEHOBPJC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface HDNOJPPIKLJ<TSpawnType, TSpawnInfo>
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> JIAJBKBHKBM([In] DPFJMOEBDAA<TSpawnInfo> EEAFBOBJALA, CancellationToken PPJMMMGPFGD);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class LKALBFCJLPB<TSpawnType, TSpawnInfo> : IFHJPCDCBOJ<HDNOJPPIKLJ<TSpawnType, TSpawnInfo>, TSpawnType> where TSpawnType : notnull where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly DPFJMOEBDAA<TSpawnInfo> EALPNGKPAMO;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x3BD11F0", Offset = "0x3BD05F0", VA = "0x183BD11F0")]
	public LKALBFCJLPB(TSpawnInfo JGFPABJKOBA, Vector3 BEBKKMFGLCG, Quaternion IKFFGJBHBIC, float LFBOEHOBPJC, HDNOJPPIKLJ<TSpawnType, TSpawnInfo> KNPJGAEAGFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3BD0E50", Offset = "0x3BD0250", VA = "0x183BD0E50", Slot = "4")]
	public override Task<TSpawnType> GPHODLAFDGD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public readonly struct BEKCGFKABGD<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly IEnumerable<TData> PBIGFLCIJAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public readonly bool OHEMICEOGLC;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x472DFF0", Offset = "0x472D3F0", VA = "0x18472DFF0")]
	public BEKCGFKABGD(IEnumerable<TData> IKPEPAECKJM, bool FAEFDAGKBNC = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface HMHKIOLDBMO<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<FKENBJIFMCE> KKMNIMGLIHH([In] BEKCGFKABGD<TData> LLCFIJKBCEC, CancellationToken PPJMMMGPFGD);
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class LJNPBKILOMB<TData> : IFHJPCDCBOJ<HMHKIOLDBMO<TData>, FKENBJIFMCE> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly BEKCGFKABGD<TData> LMFDJMHMNCG;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x3BD0FC0", Offset = "0x3BD03C0", VA = "0x183BD0FC0")]
	public LJNPBKILOMB(IEnumerable<TData> IKPEPAECKJM, bool FAEFDAGKBNC, HMHKIOLDBMO<TData> KNPJGAEAGFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x3BD0E50", Offset = "0x3BD0250", VA = "0x183BD0E50", Slot = "4")]
	public override Task<FKENBJIFMCE> GPHODLAFDGD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct PHBBPKLIDGA<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public readonly T JILDGEDOLHB;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x4097120", Offset = "0x4096520", VA = "0x184097120")]
	public PHBBPKLIDGA(T BICFKDKOEDB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public interface FLOIIIJOAHO<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CNOOAGIBHPP([In] PHBBPKLIDGA<T> HAOOKHPPBIK);

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool ANHDGOAFJJC();
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface ILAGBKENAPO<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GPHODLAFDGD([In] LBGJEPOOKIK<T> BLCODOPICNP);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct LBGJEPOOKIK<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public readonly T JILDGEDOLHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public readonly bool KKIFJHBCINJ;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x3B5F770", Offset = "0x3B5EB70", VA = "0x183B5F770")]
	public LBGJEPOOKIK(T BICFKDKOEDB, bool IGDABCIGHJM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class HDPEBCDMNDJ<T> : AOGNCBCJBJJ<FLOIIIJOAHO<T>> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x32B63D0", Offset = "0x32B57D0", VA = "0x1832B63D0")]
	public HDPEBCDMNDJ(FLOIIIJOAHO<T> KNPJGAEAGFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x3759AC0", Offset = "0x3758EC0", VA = "0x183759AC0", Slot = "4")]
	public override bool GPHODLAFDGD()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public class GLIGHKLJALE<T> : AOGNCBCJBJJ<FLOIIIJOAHO<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly PHBBPKLIDGA<T> HAOOKHPPBIK;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x371B3E0", Offset = "0x371A7E0", VA = "0x18371B3E0")]
	public GLIGHKLJALE(T JILDGEDOLHB, FLOIIIJOAHO<T> KNPJGAEAGFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x32B5F90", Offset = "0x32B5390", VA = "0x1832B5F90", Slot = "4")]
	public override bool GPHODLAFDGD()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public class BALNDJALCGL<T> : AOGNCBCJBJJ<ILAGBKENAPO<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly LBGJEPOOKIK<T> BLCODOPICNP;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x4709D80", Offset = "0x4709180", VA = "0x184709D80")]
	public BALNDJALCGL(T JILDGEDOLHB, bool IGDABCIGHJM, ILAGBKENAPO<T> KNPJGAEAGFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x32B5F90", Offset = "0x32B5390", VA = "0x1832B5F90", Slot = "4")]
	public override bool GPHODLAFDGD()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct OJGGJEHIENM<TData> where TData : notnull, JPKHCDFKPNG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public IEnumerable<TData> PBIGFLCIJAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public bool DKLMLGOHCNA;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x3FDDF60", Offset = "0x3FDD360", VA = "0x183FDDF60")]
	public OJGGJEHIENM(IEnumerable<TData> JDJMAHHMHCG, bool BLFMKLOKNNC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public struct CJGBDEDPEKB<TData> where TData : notnull, JPKHCDFKPNG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public List<TData> PBIGFLCIJAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public List<bool> GPELCBOIIIE;

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x4A2A870", Offset = "0x4A29C70", VA = "0x184A2A870")]
	public CJGBDEDPEKB(List<TData> JDJMAHHMHCG, List<bool> MAGGFODFKAL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public interface JPKHCDFKPNG
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	bool FKGCHLCEBJJ
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
public interface FHIBCMBOGHI<TData> where TData : JPKHCDFKPNG
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GPHODLAFDGD([In] OJGGJEHIENM<TData> OOCGCBDEINL);

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GPHODLAFDGD([In] CJGBDEDPEKB<TData> OOCGCBDEINL);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface BMABDJPDAPG<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CKECHOKMHIM(T JILDGEDOLHB);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public class NDMCILJGMHH<TData> : AOGNCBCJBJJ<FHIBCMBOGHI<TData>> where TData : notnull, JPKHCDFKPNG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly OJGGJEHIENM<TData> OOCGCBDEINL;

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x3EAE300", Offset = "0x3EAD700", VA = "0x183EAE300")]
	public NDMCILJGMHH(List<TData> IKPEPAECKJM, bool DKLMLGOHCNA, FHIBCMBOGHI<TData> KNPJGAEAGFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x32B5F90", Offset = "0x32B5390", VA = "0x1832B5F90", Slot = "4")]
	public override bool GPHODLAFDGD()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public class BJGNAABHEBF<TData> : AOGNCBCJBJJ<FHIBCMBOGHI<TData>> where TData : notnull, JPKHCDFKPNG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly CJGBDEDPEKB<TData> OOCGCBDEINL;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x4736130", Offset = "0x4735530", VA = "0x184736130")]
	public BJGNAABHEBF(List<TData> IKPEPAECKJM, List<bool> GPELCBOIIIE, FHIBCMBOGHI<TData> KNPJGAEAGFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x36F66B0", Offset = "0x36F5AB0", VA = "0x1836F66B0", Slot = "4")]
	public override bool GPHODLAFDGD()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface GMEOOIPMAMJ : JPKHCDFKPNG
{
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface ONDOAHIBKLE<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<FKENBJIFMCE> GPHODLAFDGD(IGMFBMCIAJJ<TData> CBFBJIDCMPL);
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class DHKKGJOEIEO<TData> : IFHJPCDCBOJ<ONDOAHIBKLE<TData>, FKENBJIFMCE> where TData : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private struct EMOJPIHDOOK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public AsyncTaskMethodBuilder<FKENBJIFMCE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public DHKKGJOEIEO<TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private TaskAwaiter<FKENBJIFMCE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x32C2D70", Offset = "0x32C2170", VA = "0x1832C2D70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x32C3060", Offset = "0x32C2460", VA = "0x1832C3060", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly IGMFBMCIAJJ<TData> KLKNNBBBBCG;

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x4FD9290", Offset = "0x4FD8690", VA = "0x184FD9290")]
	public DHKKGJOEIEO(TData HFDCHMLEKJA, IReadOnlyList<TData> NAJAPKPNFKE, bool FAEFDAGKBNC, ONDOAHIBKLE<TData> KNPJGAEAGFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x4FD9190", Offset = "0x4FD8590", VA = "0x184FD9190", Slot = "4")]
	[AsyncStateMachine(typeof(DHKKGJOEIEO<>.EMOJPIHDOOK))]
	public override Task<FKENBJIFMCE> GPHODLAFDGD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public struct IGMFBMCIAJJ<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public TData CNNCJFGEPBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public IReadOnlyList<TData> BOONIKMCOLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public bool OHEMICEOGLC;

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x3825E50", Offset = "0x3825250", VA = "0x183825E50")]
	public IGMFBMCIAJJ(TData HFDCHMLEKJA, IReadOnlyList<TData> NAJAPKPNFKE, bool FAEFDAGKBNC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public interface BKMPAMJJGIK<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GPHODLAFDGD([In] GFBCDJLDBLC<TData> OOCCENCCNKN);
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface BFAPCDCFFKN<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GPHODLAFDGD([In] DOHPIAHLDOA<TData> OOCCENCCNKN);
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public interface DFENAEMALNI<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PEDHPAJGOIO([In] JJHJGNMLMJF<TData> OOCCENCCNKN);

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ANHDGOAFJJC();
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class HNHHDFPPKEL<TData> : AOGNCBCJBJJ<BKMPAMJJGIK<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly GFBCDJLDBLC<TData> OOCCENCCNKN;

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x377B280", Offset = "0x377A680", VA = "0x18377B280")]
	public HNHHDFPPKEL(IEnumerable<TData> IKPEPAECKJM, CCPEEPBGDGI MNHFMCFPMMK, DEEJPCOLBIH LNKFECCMIIP, float FIOMOOEIHDA, bool FAEFDAGKBNC, BKMPAMJJGIK<TData> KNPJGAEAGFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x32B5F90", Offset = "0x32B5390", VA = "0x1832B5F90", Slot = "4")]
	public override bool GPHODLAFDGD()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class JLLNEBEDEHI<TData> : AOGNCBCJBJJ<BFAPCDCFFKN<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly DOHPIAHLDOA<TData> OOCCENCCNKN;

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x3A59760", Offset = "0x3A58B60", VA = "0x183A59760")]
	public JLLNEBEDEHI(TData[] IKPEPAECKJM, CCPEEPBGDGI[] MNHFMCFPMMK, DEEJPCOLBIH[] LNKFECCMIIP, float[] FIOMOOEIHDA, BFAPCDCFFKN<TData> KNPJGAEAGFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x3A596A0", Offset = "0x3A58AA0", VA = "0x183A596A0", Slot = "4")]
	public override bool GPHODLAFDGD()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class EHOCLKIACHP<TData> : AOGNCBCJBJJ<DFENAEMALNI<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x32B63D0", Offset = "0x32B57D0", VA = "0x1832B63D0")]
	public EHOCLKIACHP(DFENAEMALNI<TData> KNPJGAEAGFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x32B7080", Offset = "0x32B6480", VA = "0x1832B7080", Slot = "4")]
	public override bool GPHODLAFDGD()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public class PBBCDAMHENH<TData> : AOGNCBCJBJJ<DFENAEMALNI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly JJHJGNMLMJF<TData> OOCCENCCNKN;

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x407E5B0", Offset = "0x407D9B0", VA = "0x18407E5B0")]
	public PBBCDAMHENH(IEnumerable<TData> IKPEPAECKJM, CCPEEPBGDGI MNHFMCFPMMK, DEEJPCOLBIH LNKFECCMIIP, float FIOMOOEIHDA, DFENAEMALNI<TData> KNPJGAEAGFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x3A596A0", Offset = "0x3A58AA0", VA = "0x183A596A0", Slot = "4")]
	public override bool GPHODLAFDGD()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public struct GFBCDJLDBLC<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public IEnumerable<TData> PBIGFLCIJAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public CCPEEPBGDGI BLNABIPFJBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public DEEJPCOLBIH EGILJJMFIGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public float FIOMOOEIHDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public bool FAEFDAGKBNC;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x36FEA60", Offset = "0x36FDE60", VA = "0x1836FEA60")]
	public GFBCDJLDBLC(IEnumerable<TData> IKPEPAECKJM, CCPEEPBGDGI MNHFMCFPMMK, DEEJPCOLBIH LNKFECCMIIP, float FIOMOOEIHDA, bool FAEFDAGKBNC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public struct DOHPIAHLDOA<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public TData[] PBIGFLCIJAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public CCPEEPBGDGI[] BLNABIPFJBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public DEEJPCOLBIH[] EGILJJMFIGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public float[] FIOMOOEIHDA;

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x5018BC0", Offset = "0x5017FC0", VA = "0x185018BC0")]
	public DOHPIAHLDOA(TData[] IKPEPAECKJM, CCPEEPBGDGI[] MNHFMCFPMMK, DEEJPCOLBIH[] LNKFECCMIIP, float[] FIOMOOEIHDA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public struct JJHJGNMLMJF<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public IEnumerable<TData> PBIGFLCIJAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public CCPEEPBGDGI BLNABIPFJBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public DEEJPCOLBIH EGILJJMFIGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public float FIOMOOEIHDA;

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x3A406E0", Offset = "0x3A3FAE0", VA = "0x183A406E0")]
	public JJHJGNMLMJF(IEnumerable<TData> IKPEPAECKJM, CCPEEPBGDGI MNHFMCFPMMK, DEEJPCOLBIH LNKFECCMIIP, float FIOMOOEIHDA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public interface IDEKDFFEMAA<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DDMIDEBHCKB([In] KPEILFEFOGC<TData> LLCFIJKBCEC);

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KOIKIBGNJJG([In] KPEILFEFOGC<TData> LLCFIJKBCEC);

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FNAFJIGCFNJ([In] bool GCNOCAEHGGI);

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool EJBMBPPCCOO([In] KPEILFEFOGC<TData> LLCFIJKBCEC);

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JIMILNFLKPI();

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool AAMMBCAHEBE([In] TData IEDDNJOMAEH);
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public class JBLKBCKEIHK<TData> : AOGNCBCJBJJ<IDEKDFFEMAA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private readonly KPEILFEFOGC<TData> LLCFIJKBCEC;

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x39C0E70", Offset = "0x39C0270", VA = "0x1839C0E70")]
	public JBLKBCKEIHK(List<TData> PGGCOHKMABC, IDEKDFFEMAA<TData> KNPJGAEAGFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x32B5F90", Offset = "0x32B5390", VA = "0x1832B5F90", Slot = "4")]
	public override bool GPHODLAFDGD()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class CPAHKPADLBP<TData> : AOGNCBCJBJJ<IDEKDFFEMAA<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x32B63D0", Offset = "0x32B57D0", VA = "0x1832B63D0")]
	public CPAHKPADLBP(IDEKDFFEMAA<TData> KNPJGAEAGFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x4B0B250", Offset = "0x4B0A650", VA = "0x184B0B250", Slot = "4")]
	public override bool GPHODLAFDGD()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class NCFOGFLAANP<TData> : AOGNCBCJBJJ<IDEKDFFEMAA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly bool FAEFDAGKBNC;

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x3E932B0", Offset = "0x3E926B0", VA = "0x183E932B0")]
	public NCFOGFLAANP(bool FAEFDAGKBNC, IDEKDFFEMAA<TData> KNPJGAEAGFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x3E93250", Offset = "0x3E92650", VA = "0x183E93250", Slot = "4")]
	public override bool GPHODLAFDGD()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public class GBINGGJCCLD<TData> : AOGNCBCJBJJ<IDEKDFFEMAA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly KPEILFEFOGC<TData> LLCFIJKBCEC;

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x36F6800", Offset = "0x36F5C00", VA = "0x1836F6800")]
	public GBINGGJCCLD(List<TData> PGGCOHKMABC, bool FAEFDAGKBNC, IDEKDFFEMAA<TData> KNPJGAEAGFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x36F66B0", Offset = "0x36F5AB0", VA = "0x1836F66B0", Slot = "4")]
	public override bool GPHODLAFDGD()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class NEJEIBBNJJD<TData> : AOGNCBCJBJJ<IDEKDFFEMAA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly TData IEDDNJOMAEH;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x3EAE790", Offset = "0x3EADB90", VA = "0x183EAE790")]
	public NEJEIBBNJJD(TData IEDDNJOMAEH, IDEKDFFEMAA<TData> KNPJGAEAGFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x3EAE610", Offset = "0x3EADA10", VA = "0x183EAE610", Slot = "4")]
	public override bool GPHODLAFDGD()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class LNJBHEGOIGP<TData> : AOGNCBCJBJJ<IDEKDFFEMAA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private readonly KPEILFEFOGC<TData> LLCFIJKBCEC;

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x3BDFB50", Offset = "0x3BDEF50", VA = "0x183BDFB50")]
	public LNJBHEGOIGP(IEnumerable<TData> PGGCOHKMABC, IDEKDFFEMAA<TData> KNPJGAEAGFF, bool FAEFDAGKBNC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x3BDFA80", Offset = "0x3BDEE80", VA = "0x183BDFA80", Slot = "4")]
	public override bool GPHODLAFDGD()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public struct KPEILFEFOGC<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public IEnumerable<TData> PBIGFLCIJAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public bool FAEFDAGKBNC;

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x3AE1920", Offset = "0x3AE0D20", VA = "0x183AE1920")]
	public KPEILFEFOGC(IEnumerable<TData> JDJMAHHMHCG, bool PCIIOFIHEAG = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public interface CEPIHFPDFCP
{
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<FKENBJIFMCE> GPHODLAFDGD(EHJDEDPBPMB JPCLGCJNHBO);
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public class BEBNMLPLBLM : IFHJPCDCBOJ<CEPIHFPDFCP, FKENBJIFMCE>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private struct FLDMFICKICH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public AsyncTaskMethodBuilder<FKENBJIFMCE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public BEBNMLPLBLM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private TaskAwaiter<FKENBJIFMCE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x60B1AA0", Offset = "0x60B0EA0", VA = "0x1860B1AA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x60B1D20", Offset = "0x60B1120", VA = "0x1860B1D20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private readonly EHJDEDPBPMB DIDOINMOELN;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x60B1380", Offset = "0x60B0780", VA = "0x1860B1380")]
	public BEBNMLPLBLM(bool FAEFDAGKBNC, CEPIHFPDFCP KNPJGAEAGFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x60B1290", Offset = "0x60B0690", VA = "0x1860B1290", Slot = "4")]
	[AsyncStateMachine(typeof(FLDMFICKICH))]
	public override Task<FKENBJIFMCE> GPHODLAFDGD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public struct EHJDEDPBPMB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public bool OHEMICEOGLC;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0xC48A30", Offset = "0xC47E30", VA = "0x180C48A30")]
	public EHJDEDPBPMB(bool FAEFDAGKBNC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public readonly struct LFCJOMOLMLG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly bool GPIOJPFOADG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly bool ICMEMCODCFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public readonly bool LFBOEHOBPJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public readonly bool FAEFDAGKBNC;

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x45B5BA0", Offset = "0x45B4FA0", VA = "0x1845B5BA0")]
	public LFCJOMOLMLG(bool GPIOJPFOADG, bool ICMEMCODCFA, bool LFBOEHOBPJC, bool FAEFDAGKBNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x60B1DF0", Offset = "0x60B11F0", VA = "0x1860B1DF0")]
	public LFCJOMOLMLG(bool ICMEMCODCFA, bool FAEFDAGKBNC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public interface DJHMHDFFGAA
{
	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HAKHBENNFCH(LFCJOMOLMLG MABGIPEDBHC);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MBCKKGNNDPA(LFCJOMOLMLG MABGIPEDBHC);
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class EBPIMBELHCG : AOGNCBCJBJJ<DJHMHDFFGAA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly LFCJOMOLMLG MABGIPEDBHC;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x60B1890", Offset = "0x60B0C90", VA = "0x1860B1890")]
	public EBPIMBELHCG(bool NPBNAACKOLN, bool ICMEMCODCFA, bool LFBOEHOBPJC, bool FAEFDAGKBNC, DJHMHDFFGAA KNPJGAEAGFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x60B1840", Offset = "0x60B0C40", VA = "0x1860B1840", Slot = "4")]
	public override bool GPHODLAFDGD()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public class ACAPGFJJGDN : AOGNCBCJBJJ<DJHMHDFFGAA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly LFCJOMOLMLG MABGIPEDBHC;

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x60B0ED0", Offset = "0x60B02D0", VA = "0x1860B0ED0")]
	public ACAPGFJJGDN(bool ICMEMCODCFA, bool FAEFDAGKBNC, DJHMHDFFGAA KNPJGAEAGFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x60B0E80", Offset = "0x60B0280", VA = "0x1860B0E80", Slot = "4")]
	public override bool GPHODLAFDGD()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public interface BCDKDILFBNN
{
	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GPHODLAFDGD([In] DHOEHBBOBAB FBPDBFFJKPN);
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class NCAKOHHPPFJ : AOGNCBCJBJJ<BCDKDILFBNN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly DHOEHBBOBAB FBPDBFFJKPN;

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x60B2280", Offset = "0x60B1680", VA = "0x1860B2280")]
	public NCAKOHHPPFJ(Guid[] HECGBFONJDO, Vector3[] KIHOLKOCEPE, Quaternion[] HNBABGKKFKC, float[] BJGFOMMFHCK, Dictionary<Guid, Vector3> ENKKOEDDMEF, BCDKDILFBNN KNPJGAEAGFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x60B21D0", Offset = "0x60B15D0", VA = "0x1860B21D0", Slot = "4")]
	public override bool GPHODLAFDGD()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public interface CPLHKFALBJN<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CNOOAGIBHPP([In] CPDPHOBENJL<TData> IIJCGLICFOD);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool PEDHPAJGOIO([In] FKEJJNBKLCM BMENBHCKILP);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool PEDHPAJGOIO([In] GHECIJJFAOB BMENBHCKILP);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool ANHDGOAFJJC();
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public class EPCMKBBKDCP<TData> : AOGNCBCJBJJ<CPLHKFALBJN<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x32B63D0", Offset = "0x32B57D0", VA = "0x1832B63D0")]
	public EPCMKBBKDCP(CPLHKFALBJN<TData> KNPJGAEAGFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x32E6050", Offset = "0x32E5450", VA = "0x1832E6050", Slot = "4")]
	public override bool GPHODLAFDGD()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public class LMDHLNAGINF<TData> : AOGNCBCJBJJ<CPLHKFALBJN<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly FKEJJNBKLCM LPFFOGEGFND;

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x3BD79B0", Offset = "0x3BD6DB0", VA = "0x183BD79B0")]
	public LMDHLNAGINF(Vector3 HDKCBLHPMIO, bool ODLPKIKPIHO, CPLHKFALBJN<TData> KNPJGAEAGFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x32B8420", Offset = "0x32B7820", VA = "0x1832B8420", Slot = "4")]
	public override bool GPHODLAFDGD()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class ILLGKCPFDMH<TData> : AOGNCBCJBJJ<CPLHKFALBJN<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly GHECIJJFAOB LPFFOGEGFND;

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x3830370", Offset = "0x382F770", VA = "0x183830370")]
	public ILLGKCPFDMH(Guid JJOINPBFHON, int AHDNEIKOMIB, Vector3 BEBKKMFGLCG, Quaternion IKFFGJBHBIC, float CABLJKKDANE, bool ODLPKIKPIHO, CPLHKFALBJN<TData> KNPJGAEAGFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x3830310", Offset = "0x382F710", VA = "0x183830310", Slot = "4")]
	public override bool GPHODLAFDGD()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public class LKIEHIAAINO<TData> : AOGNCBCJBJJ<CPLHKFALBJN<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly CPDPHOBENJL<TData> LPFFOGEGFND;

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x3BD63B0", Offset = "0x3BD57B0", VA = "0x183BD63B0")]
	public LKIEHIAAINO(TData JILDGEDOLHB, bool FAEFDAGKBNC, CPLHKFALBJN<TData> KNPJGAEAGFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x32B5F90", Offset = "0x32B5390", VA = "0x1832B5F90", Slot = "4")]
	public override bool GPHODLAFDGD()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public struct FKEJJNBKLCM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public readonly Vector3 HDKCBLHPMIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public readonly bool ODLPKIKPIHO;

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x60B1A80", Offset = "0x60B0E80", VA = "0x1860B1A80")]
	public FKEJJNBKLCM(Vector3 HDKCBLHPMIO, bool ODLPKIKPIHO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public struct GHECIJJFAOB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public readonly Guid JJOINPBFHON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public readonly int AHDNEIKOMIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public readonly Vector3 BEBKKMFGLCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public readonly Quaternion IKFFGJBHBIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public readonly float CABLJKKDANE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public readonly bool ODLPKIKPIHO;

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x60B1D90", Offset = "0x60B1190", VA = "0x1860B1D90")]
	public GHECIJJFAOB(Guid JJOINPBFHON, int AHDNEIKOMIB, Vector3 BEBKKMFGLCG, Quaternion IKFFGJBHBIC, float CABLJKKDANE, bool ODLPKIKPIHO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public struct CPDPHOBENJL<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public readonly TData JILDGEDOLHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public readonly bool FAEFDAGKBNC;

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x4B0B340", Offset = "0x4B0A740", VA = "0x184B0B340")]
	public CPDPHOBENJL(TData JILDGEDOLHB, bool FAEFDAGKBNC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public interface BOOGMOJKDJH<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GPHODLAFDGD([In] FLDAAHMCHLK<TData> HEFMAGKJGPH);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GPHODLAFDGD([In] GHBFHABMHGE<TData> HEFMAGKJGPH);
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public interface DBEKIELGLFB<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CNOOAGIBHPP([In] CJDIEONLMJK<TData> OGHCLOFNKKP);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool PEDHPAJGOIO([In] NMAHPKIKLCA BMENBHCKILP);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool ANHDGOAFJJC();
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public class EGHGNOAHKJP<TData> : AOGNCBCJBJJ<BOOGMOJKDJH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly FLDAAHMCHLK<TData> HEFMAGKJGPH;

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x32B6050", Offset = "0x32B5450", VA = "0x1832B6050")]
	public EGHGNOAHKJP(IEnumerable<TData> IKPEPAECKJM, Vector3 KMNBGLCHLBK, bool FAEFDAGKBNC, BOOGMOJKDJH<TData> KNPJGAEAGFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x32B5F90", Offset = "0x32B5390", VA = "0x1832B5F90", Slot = "4")]
	public override bool GPHODLAFDGD()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class PEKJBNKFGPG<TData> : AOGNCBCJBJJ<DBEKIELGLFB<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x32B63D0", Offset = "0x32B57D0", VA = "0x1832B63D0")]
	public PEKJBNKFGPG(DBEKIELGLFB<TData> KNPJGAEAGFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x3BD7A40", Offset = "0x3BD6E40", VA = "0x183BD7A40", Slot = "4")]
	public override bool GPHODLAFDGD()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class ODJBMNCACKM<TData> : AOGNCBCJBJJ<DBEKIELGLFB<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly CJDIEONLMJK<TData> HEFMAGKJGPH;

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x3FC8E30", Offset = "0x3FC8230", VA = "0x183FC8E30")]
	public ODJBMNCACKM(IEnumerable<TData> IKPEPAECKJM, bool FAEFDAGKBNC, DBEKIELGLFB<TData> KNPJGAEAGFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x32B5F90", Offset = "0x32B5390", VA = "0x1832B5F90", Slot = "4")]
	public override bool GPHODLAFDGD()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class AEECBLMHAHH<TData> : AOGNCBCJBJJ<BOOGMOJKDJH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly GHBFHABMHGE<TData> HEFMAGKJGPH;

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x36BB950", Offset = "0x36BAD50", VA = "0x1836BB950")]
	public AEECBLMHAHH(IEnumerable<TData> IKPEPAECKJM, Vector3 PFCJEJPBBPH, BIMDFFHIKNK ONAOLPBDFJB, bool FAEFDAGKBNC, BOOGMOJKDJH<TData> KNPJGAEAGFF, Space CJOGBNCNLLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x36BB880", Offset = "0x36BAC80", VA = "0x1836BB880", Slot = "4")]
	public override bool GPHODLAFDGD()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public class LCMIHOBJBIG<TData> : AOGNCBCJBJJ<DBEKIELGLFB<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly NMAHPKIKLCA HEFMAGKJGPH;

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x3B65400", Offset = "0x3B64800", VA = "0x183B65400")]
	public LCMIHOBJBIG(Vector3 KMNBGLCHLBK, DBEKIELGLFB<TData> KNPJGAEAGFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x32B8420", Offset = "0x32B7820", VA = "0x1832B8420", Slot = "4")]
	public override bool GPHODLAFDGD()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public struct FLDAAHMCHLK<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public readonly IEnumerable<TData> IKPEPAECKJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public readonly Vector3 KMNBGLCHLBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public readonly bool FAEFDAGKBNC;

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x3649300", Offset = "0x3648700", VA = "0x183649300")]
	public FLDAAHMCHLK(IEnumerable<TData> IKPEPAECKJM, Vector3 KMNBGLCHLBK, bool FAEFDAGKBNC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public struct CJDIEONLMJK<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public readonly IEnumerable<TData> IKPEPAECKJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public readonly bool FAEFDAGKBNC;

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x4A29B70", Offset = "0x4A28F70", VA = "0x184A29B70")]
	public CJDIEONLMJK(IEnumerable<TData> IKPEPAECKJM, bool FAEFDAGKBNC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public struct GHBFHABMHGE<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public readonly IEnumerable<TData> IKPEPAECKJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public readonly Vector3 PFCJEJPBBPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public readonly BIMDFFHIKNK ONAOLPBDFJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public readonly bool FAEFDAGKBNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public readonly Space CJOGBNCNLLD;

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x370F4D0", Offset = "0x370E8D0", VA = "0x18370F4D0")]
	public GHBFHABMHGE(IEnumerable<TData> IKPEPAECKJM, Vector3 PFCJEJPBBPH, BIMDFFHIKNK ONAOLPBDFJB, bool FAEFDAGKBNC, Space CJOGBNCNLLD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public struct NMAHPKIKLCA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public readonly Vector3 KMNBGLCHLBK;

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x1E95740", Offset = "0x1E94B40", VA = "0x181E95740")]
	public NMAHPKIKLCA(Vector3 KMNBGLCHLBK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public enum BIMDFFHIKNK
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
[Cpp2IlInjected.Token(Token = "0x2000074")]
public interface PPLJFJAAILC
{
	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GPHODLAFDGD([In] MINGMHFFNEJ HKNMMFMOJHC);
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public class ALFDPNAONAN : AOGNCBCJBJJ<PPLJFJAAILC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly MINGMHFFNEJ HKNMMFMOJHC;

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x60B1000", Offset = "0x60B0400", VA = "0x1860B1000")]
	public ALFDPNAONAN(bool FAEFDAGKBNC, PPLJFJAAILC KNPJGAEAGFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x60B0F50", Offset = "0x60B0350", VA = "0x1860B0F50", Slot = "4")]
	public override bool GPHODLAFDGD()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public readonly struct MINGMHFFNEJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public readonly bool FAEFDAGKBNC;

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0xC48A30", Offset = "0xC47E30", VA = "0x180C48A30")]
	public MINGMHFFNEJ(bool FAEFDAGKBNC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public interface BJPBFHDFCLH<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GPHODLAFDGD([In] CJKOKEDGKEF<TData> ABKGEKFNGPA);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GPHODLAFDGD([In] KDCIMJALBOB<TData> ABKGEKFNGPA);
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public interface LIGMFBMAKHB<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CNOOAGIBHPP([In] BLGGKPDEJNO<TData> IIJCGLICFOD);

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool PEDHPAJGOIO([In] BKLPEMBILGF BMENBHCKILP);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool ANHDGOAFJJC();
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public class JCICEIMNGAA<TData> : AOGNCBCJBJJ<BJPBFHDFCLH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly CJKOKEDGKEF<TData> ABKGEKFNGPA;

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x39C5EF0", Offset = "0x39C52F0", VA = "0x1839C5EF0")]
	public JCICEIMNGAA(IEnumerable<TData> IKPEPAECKJM, Quaternion KMNBGLCHLBK, Vector3? AFBHMKPGOHI, bool BMOALKAMMDJ, bool FAEFDAGKBNC, BJPBFHDFCLH<TData> KNPJGAEAGFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x32B5F90", Offset = "0x32B5390", VA = "0x1832B5F90", Slot = "4")]
	public override bool GPHODLAFDGD()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public class MHOFGLFGMNC<TData> : AOGNCBCJBJJ<LIGMFBMAKHB<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x32B63D0", Offset = "0x32B57D0", VA = "0x1832B63D0")]
	public MHOFGLFGMNC(LIGMFBMAKHB<TData> KNPJGAEAGFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x3BD7A40", Offset = "0x3BD6E40", VA = "0x183BD7A40", Slot = "4")]
	public override bool GPHODLAFDGD()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public class LNGMAAGOJNO<TData> : AOGNCBCJBJJ<LIGMFBMAKHB<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly BLGGKPDEJNO<TData> ABKGEKFNGPA;

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x3BDF110", Offset = "0x3BDE510", VA = "0x183BDF110")]
	public LNGMAAGOJNO(IEnumerable<TData> IKPEPAECKJM, bool FAEFDAGKBNC, LIGMFBMAKHB<TData> KNPJGAEAGFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x32B5F90", Offset = "0x32B5390", VA = "0x1832B5F90", Slot = "4")]
	public override bool GPHODLAFDGD()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public class PJOLJDNMGDJ<TData> : AOGNCBCJBJJ<BJPBFHDFCLH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly KDCIMJALBOB<TData> ABKGEKFNGPA;

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x40A6350", Offset = "0x40A5750", VA = "0x1840A6350")]
	public PJOLJDNMGDJ(IEnumerable<TData> IKPEPAECKJM, Quaternion LPIOAHFAGLJ, BIMDFFHIKNK PAIMHJDAGKJ, Vector3? AFBHMKPGOHI, bool BMOALKAMMDJ, bool FAEFDAGKBNC, Space CJOGBNCNLLD, BJPBFHDFCLH<TData> KNPJGAEAGFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x36BB880", Offset = "0x36BAC80", VA = "0x1836BB880", Slot = "4")]
	public override bool GPHODLAFDGD()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public class MANIBILLOJB<TData> : AOGNCBCJBJJ<LIGMFBMAKHB<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly BKLPEMBILGF ABKGEKFNGPA;

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x3DACEB0", Offset = "0x3DAC2B0", VA = "0x183DACEB0")]
	public MANIBILLOJB(Quaternion KMNBGLCHLBK, Vector3? AFBHMKPGOHI, bool BMOALKAMMDJ, LIGMFBMAKHB<TData> KNPJGAEAGFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x32B8420", Offset = "0x32B7820", VA = "0x1832B8420", Slot = "4")]
	public override bool GPHODLAFDGD()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public struct CJKOKEDGKEF<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public readonly IEnumerable<TData> IKPEPAECKJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public readonly Quaternion KMNBGLCHLBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public readonly Vector3? AFBHMKPGOHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public readonly bool BMOALKAMMDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public readonly bool FAEFDAGKBNC;

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x4A2AD20", Offset = "0x4A2A120", VA = "0x184A2AD20")]
	public CJKOKEDGKEF(IEnumerable<TData> IKPEPAECKJM, Quaternion KMNBGLCHLBK, Vector3? AFBHMKPGOHI, bool BMOALKAMMDJ, bool FAEFDAGKBNC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public struct BLGGKPDEJNO<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public readonly IEnumerable<TData> IKPEPAECKJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public readonly bool FAEFDAGKBNC;

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x473C570", Offset = "0x473B970", VA = "0x18473C570")]
	public BLGGKPDEJNO(IEnumerable<TData> IKPEPAECKJM, bool FAEFDAGKBNC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public struct KDCIMJALBOB<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public readonly IEnumerable<TData> IKPEPAECKJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public readonly Quaternion LPIOAHFAGLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public readonly BIMDFFHIKNK PAIMHJDAGKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public readonly Vector3? AFBHMKPGOHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public readonly bool BMOALKAMMDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public readonly bool FAEFDAGKBNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public readonly Space CJOGBNCNLLD;

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x3ABDB70", Offset = "0x3ABCF70", VA = "0x183ABDB70")]
	public KDCIMJALBOB(IEnumerable<TData> IKPEPAECKJM, Quaternion LPIOAHFAGLJ, BIMDFFHIKNK PAIMHJDAGKJ, Vector3? AFBHMKPGOHI, bool BMOALKAMMDJ, bool FAEFDAGKBNC, Space CJOGBNCNLLD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public struct BKLPEMBILGF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public readonly Quaternion KMNBGLCHLBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public readonly Vector3? AFBHMKPGOHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public readonly bool BMOALKAMMDJ;

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x457B060", Offset = "0x457A460", VA = "0x18457B060")]
	public BKLPEMBILGF(Quaternion KMNBGLCHLBK, Vector3? AFBHMKPGOHI, bool BMOALKAMMDJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public interface INLGGOBCJDI<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CNOOAGIBHPP([In] IOAJBCBBHEI<TData> IIJCGLICFOD);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool PEDHPAJGOIO([In] DPGCKHNCEGM BMENBHCKILP);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool PEDHPAJGOIO([In] IIGFHNNOMGL BMENBHCKILP);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool PEDHPAJGOIO([In] ONHCFGFJHLC BMENBHCKILP);

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool ANHDGOAFJJC();
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public class FADEAMOCFBL<TData> : AOGNCBCJBJJ<INLGGOBCJDI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly ONHCFGFJHLC KPMFAGFLGHK;

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x36283C0", Offset = "0x36277C0", VA = "0x1836283C0")]
	public FADEAMOCFBL(Vector3 MGAIAJOFKDM, float COMNKNINMAC, Vector3 AFBHMKPGOHI, bool HNMDKGLGLDJ, bool AHOKEEFHOPA, INLGGOBCJDI<TData> KNPJGAEAGFF, Space CJOGBNCNLLD = Space.Self)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x3628360", Offset = "0x3627760", VA = "0x183628360", Slot = "4")]
	public override bool GPHODLAFDGD()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public class KHJMNKGPJFL<TData> : AOGNCBCJBJJ<INLGGOBCJDI<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x32B63D0", Offset = "0x32B57D0", VA = "0x1832B63D0")]
	public KHJMNKGPJFL(INLGGOBCJDI<TData> KNPJGAEAGFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x3AC8A70", Offset = "0x3AC7E70", VA = "0x183AC8A70", Slot = "4")]
	public override bool GPHODLAFDGD()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public class LOBLIPFONAD<TData> : AOGNCBCJBJJ<INLGGOBCJDI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly IOAJBCBBHEI<TData> KPMFAGFLGHK;

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x3BE37A0", Offset = "0x3BE2BA0", VA = "0x183BE37A0")]
	public LOBLIPFONAD(IEnumerable<TData> IKPEPAECKJM, bool FAEFDAGKBNC, INLGGOBCJDI<TData> KNPJGAEAGFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x32B5F90", Offset = "0x32B5390", VA = "0x1832B5F90", Slot = "4")]
	public override bool GPHODLAFDGD()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public class CAHGPEOBHDP<TData> : AOGNCBCJBJJ<INLGGOBCJDI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly IIGFHNNOMGL KPMFAGFLGHK;

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x4832990", Offset = "0x4831D90", VA = "0x184832990")]
	public CAHGPEOBHDP(float BJCAPPPHDFH, bool OPNLCPBDMDF, Vector3 AFBHMKPGOHI, INLGGOBCJDI<TData> KNPJGAEAGFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x48328C0", Offset = "0x4831CC0", VA = "0x1848328C0", Slot = "4")]
	public override bool GPHODLAFDGD()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public class EIJCACJDDKA<TData> : AOGNCBCJBJJ<INLGGOBCJDI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly DPGCKHNCEGM KPMFAGFLGHK;

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x32B8480", Offset = "0x32B7880", VA = "0x1832B8480")]
	public EIJCACJDDKA(float COMNKNINMAC, Vector3 AFBHMKPGOHI, INLGGOBCJDI<TData> KNPJGAEAGFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x32B8420", Offset = "0x32B7820", VA = "0x1832B8420", Slot = "4")]
	public override bool GPHODLAFDGD()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public struct ONHCFGFJHLC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	public readonly Vector3 MGAIAJOFKDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public readonly float COMNKNINMAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public readonly Vector3 AFBHMKPGOHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public readonly bool ODLPKIKPIHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public readonly Space CJOGBNCNLLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public readonly bool AHOKEEFHOPA;

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x60B2500", Offset = "0x60B1900", VA = "0x1860B2500")]
	public ONHCFGFJHLC(Vector3 MGAIAJOFKDM, float COMNKNINMAC, Vector3 AFBHMKPGOHI, bool ODLPKIKPIHO, bool PFCDMCFPMEC, Space CJOGBNCNLLD = Space.Self)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public struct IOAJBCBBHEI<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public readonly IEnumerable<TData> IKPEPAECKJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public readonly bool FAEFDAGKBNC;

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x383D620", Offset = "0x383CA20", VA = "0x18383D620")]
	public IOAJBCBBHEI(IEnumerable<TData> IKPEPAECKJM, bool FAEFDAGKBNC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public struct IIGFHNNOMGL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public readonly float BJCAPPPHDFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public readonly bool OPNLCPBDMDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public readonly Vector3 AFBHMKPGOHI;

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x60B1DD0", Offset = "0x60B11D0", VA = "0x1860B1DD0")]
	public IIGFHNNOMGL(float BJCAPPPHDFH, bool OPNLCPBDMDF, Vector3 AFBHMKPGOHI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public struct DPGCKHNCEGM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public readonly float COMNKNINMAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public readonly Vector3 AFBHMKPGOHI;

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x455BBC0", Offset = "0x455AFC0", VA = "0x18455BBC0")]
	public DPGCKHNCEGM(float COMNKNINMAC, Vector3 AFBHMKPGOHI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public struct DHOEHBBOBAB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public readonly Guid[] IKPEPAECKJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public readonly bool OBECPCIGMPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public readonly bool EFHFABKLCBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public readonly bool GGLNGFPKMNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public readonly Vector3[] KIHOLKOCEPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public readonly Quaternion[] HNBABGKKFKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public readonly float[] BJGFOMMFHCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public readonly Dictionary<Guid, Vector3> ENKKOEDDMEF;

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x60B15B0", Offset = "0x60B09B0", VA = "0x1860B15B0")]
	public DHOEHBBOBAB(Guid[] HECGBFONJDO, Vector3[] KIHOLKOCEPE, Quaternion[] HNBABGKKFKC, float[] BJGFOMMFHCK, Dictionary<Guid, Vector3> ENKKOEDDMEF, bool OBECPCIGMPO = true, bool EFHFABKLCBJ = true, bool GGLNGFPKMNH = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x60B13E0", Offset = "0x60B07E0", VA = "0x1860B13E0")]
	private static void HJEAIGGBPFK(Dictionary<Guid, Vector3> ENKKOEDDMEF, int MEIHKCPPEHL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public static class NAGHMFHMEIB
{
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	private struct EJMLNINEHGL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public bool IPKLJCDCJFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public FJIKPBKCIMI GNJMIMGEDIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public FJIKPBKCIMI HKDFCGKLDLD;
	}

	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private static EJMLNINEHGL GDCIGCCPCGD;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static CancellationToken LFJGOEKGNKO
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x60B20B0", Offset = "0x60B14B0", VA = "0x1860B20B0")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	internal static FJIKPBKCIMI GNJMIMGEDIP
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x60B1F50", Offset = "0x60B1350", VA = "0x1860B1F50")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x60B2040", Offset = "0x60B1440", VA = "0x1860B2040")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x60B20D0", Offset = "0x60B14D0", VA = "0x1860B20D0")]
	[HMKFFNEGBBO(PNDDNINAHEG.Room, FMOKCMPGPEB.None)]
	private static void PPHHLHHCDCB(FJIKPBKCIMI ILILBMNDLCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x60B1E00", Offset = "0x60B1200", VA = "0x1860B1E00")]
	public static void CJNCIGMNEAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x60B1FF0", Offset = "0x60B13F0", VA = "0x1860B1FF0")]
	private static FJIKPBKCIMI LNKDLMELDKC(FJIKPBKCIMI GDFFFOEGNBI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public static class KAOFLOJGGIF
{
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	public enum FPAOACFIJOC
	{
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		ICreationContextObject,
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		Guid
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x27060B0", Offset = "0x27054B0", VA = "0x1827060B0")]
	public static void FDHEFBGFBCP<T>(T EANIAGEJDFL, FPAOACFIJOC FICJMFBEBIN) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x2706050", Offset = "0x2705450", VA = "0x182706050")]
	public static void FDHEFBGFBCP<T>(T EANIAGEJDFL) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x27061F0", Offset = "0x27055F0", VA = "0x1827061F0")]
	public static void GPEMKNHADPP<T>(T EANIAGEJDFL) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x2706260", Offset = "0x2705660", VA = "0x182706260")]
	public static T JJNOBLLAEFC<T>(FPAOACFIJOC FICJMFBEBIN) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x2705F20", Offset = "0x2705320", VA = "0x182705F20")]
	public static bool DABECMHCGCA<T>(FPAOACFIJOC FICJMFBEBIN, T BECJHBJGPFJ, [Out] T AOFOJJBEFMG) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x2706340", Offset = "0x2705740", VA = "0x182706340")]
	public static bool PAPAOLBAPFM<T>(FPAOACFIJOC FICJMFBEBIN) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x2706300", Offset = "0x2705700", VA = "0x182706300")]
	public static T JJNOBLLAEFC<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x2706300", Offset = "0x2705700", VA = "0x182706300")]
	public static bool PAPAOLBAPFM<T>() where T : class
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
internal static class ALIDFFBIGEK
{
	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x60B1060", Offset = "0x60B0460", VA = "0x1860B1060")]
	public static void DFKFLLPPGAE(IEnumerable KKKEFMMFFLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x2CF77A0", Offset = "0x2CF6BA0", VA = "0x182CF77A0")]
	public static void DFKFLLPPGAE<T>(T[] MGNOJHKHDPK) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x2CF7980", Offset = "0x2CF6D80", VA = "0x182CF7980")]
	public static void DFKFLLPPGAE<T>(T DBNNOOCLLFO) where T : notnull, Enum
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
