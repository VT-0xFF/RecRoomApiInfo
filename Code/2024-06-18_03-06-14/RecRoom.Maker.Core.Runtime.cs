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
		[Cpp2IlInjected.Address(RVA = "0x876AF0", Offset = "0x8754F0", VA = "0x180876AF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x690B3A0", Offset = "0x6909DA0", VA = "0x18690B3A0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8775C0", Offset = "0x875FC0", VA = "0x1808775C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x877600", Offset = "0x876000", VA = "0x180877600")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface JALNEGKIBOL<TData, TReturn>
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TReturn GFDIOBCBPGJ(TData GKHPLGCJCPF);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface DHIBLDDPECK<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ClearHoverTarget(ELBLCNDCDKC OBIFNJCEHNI);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool SetHoverTarget(TData PIBCCEDJCCL, Collider GKKLOBOOLHC, ELBLCNDCDKC OBIFNJCEHNI, [Optional] ALFFGGLLEIB? AFJNALAHEBG);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool TryGetHoverTarget([Out] TData PIBCCEDJCCL);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool TryGetHoverCollider([Out] Collider GKKLOBOOLHC);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface AKIDBPAOKDO<TData> : NPBFCNILCNG, MILJGONBJGN<TData>, HMHJPBCGAML<TData>, EBNCKFEMFDB<TData>, LPIBOGDAMEC, BGHLKEPOGCL<TData>, BJDGJEJDMDA, NOOPJEONIAG
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface BGHLKEPOGCL<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool Raycast(Vector3 FLANCHPFPCL, Vector3 NMAFDGGPBKA, float APKOACGHEPL, [Out] T AJNPCALFECF, [Out] Vector3 EINNIOPEAKG, [Out] Collider GKKLOBOOLHC);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int SpherecastPick(Vector3 FLANCHPFPCL, Vector3 NMAFDGGPBKA, float LPJAGJGCIOC, float APKOACGHEPL, T[] NDOCCIJIFLJ, [Out] Vector3 GHJJFMHMECH, [Out] Collider DNGPOKMCHFE);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int SpherePick(Vector3 FLANCHPFPCL, float LPJAGJGCIOC, Vector3 NAPAHDNIEAO, T[] NDOCCIJIFLJ);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool TryGetObjectFromColliderInCurrentScope(Collider ICFPDPJMPEN, [Out] T KJMCHIKKJOD);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface NPBFCNILCNG
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Bounds GAGCBIOBEPE
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	Transform OLBJAMEBDMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	Bounds LNNEDJOJKFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Transform LLCCDHCGBFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	Vector3 AHDGOBAFFOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool HBEDIHEOJNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void SetSelectionBoundsDirty(bool DGMCPOKJIBI = true, int AKNFGBAHDJJ = 0);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ShouldHideSelectionBoundsPreview(bool FIIELCNAFMG, object JCIFCENKMKP);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface NOOPJEONIAG
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	MNIMPDIHNFL MKHJBGLKGEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface MCFEFMALJNF
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool OFBKNFDHPGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool OLEIAPEPEGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool LACPAIKLHLI
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
	void TrySetPreviousCloneMapping(Dictionary<Guid, Guid> FPFOEOEGGPL);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface EBNCKFEMFDB<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool AIAIFGNIAEE
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	int MIHLOHLFBDA
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<TData> AENIKHMHNLB
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IsSelected(TData IMMLPPOHEAP);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IsSelectable(TData IMMLPPOHEAP);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface MILJGONBJGN<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void RenderHoverHighlight(T GKHPLGCJCPF, [Optional] ALFFGGLLEIB? COJIOHPGJMM, bool LKKPOEHPKDG = true);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RenderHoverHighlight(int OHELHAFFKFF, IEnumerable<T> NLAHNEMPHBP, bool LKKPOEHPKDG = true);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RenderHoverHighlight(int OHELHAFFKFF, IEnumerable<T> NLAHNEMPHBP, ALFFGGLLEIB COJIOHPGJMM, bool LKKPOEHPKDG = true);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface BJDGJEJDMDA
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnSelectionPickedUp();

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnSelectionReleased();
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface LPIBOGDAMEC
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool KGGOBDPBDLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool BPMICJEBGHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	bool EPAIFDOBGDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	bool CGJHKIOEJGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public abstract class KPNFPOMCMJF<TReceiver> : KHIDEHHJNHP<TReceiver, bool> where TReceiver : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3BE02E0", Offset = "0x3BDECE0", VA = "0x183BE02E0")]
	public KPNFPOMCMJF(TReceiver KGEAKKOPFLC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public abstract class HDMDHNIPDOM<TReceiver, TFromTask> : KHIDEHHJNHP<TReceiver, Task<TFromTask>>
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3BE02E0", Offset = "0x3BDECE0", VA = "0x183BE02E0")]
	public HDMDHNIPDOM(TReceiver KGEAKKOPFLC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public abstract class KHIDEHHJNHP<TReceiver, TFromExecute> where TReceiver : notnull where TFromExecute : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	protected TReceiver KGEAKKOPFLC;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x41C1240", Offset = "0x41BFC40", VA = "0x1841C1240")]
	public KHIDEHHJNHP(TReceiver KGEAKKOPFLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TFromExecute GGDEKLHCCBN();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public abstract class CKKNDOIFDPM<TReceiver, TResult> : KHIDEHHJNHP<TReceiver, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3BE02E0", Offset = "0x3BDECE0", VA = "0x183BE02E0")]
	public CKKNDOIFDPM(TReceiver KGEAKKOPFLC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct NNGMJNPPBII<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public TGroup EFLCBDNEHOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public TData IBLGBMHJBIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public IEnumerable<TData> KJBECJDCILP;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x1E8A6D0", Offset = "0x1E890D0", VA = "0x181E8A6D0")]
	public NNGMJNPPBII(TGroup DAHALANMKMN, TData GKGBMJKFHAH, IEnumerable<TData> MEAEOFMNDKG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct FICMFJGNPDM<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public TGroup EFLCBDNEHOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public IEnumerable<TData> KJBECJDCILP;

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0xAA6F80", Offset = "0xAA5980", VA = "0x180AA6F80")]
	public FICMFJGNPDM(TGroup DAHALANMKMN, IEnumerable<TData> MEAEOFMNDKG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct AAGHAJAMGJN<TGroup> where TGroup : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public TGroup EFLCBDNEHOB;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x921B20", Offset = "0x920520", VA = "0x180921B20")]
	public AAGHAJAMGJN(TGroup DAHALANMKMN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct BFOCFHMNCHL<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public IEnumerable<TData> KJBECJDCILP;

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x921B20", Offset = "0x920520", VA = "0x180921B20")]
	public BFOCFHMNCHL(IEnumerable<TData> MEAEOFMNDKG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface MAGOGPOAAPB<TGroup, TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CAGJDFDCDED CGGGIILIBLH(NNGMJNPPBII<TGroup, TData> HAJIFJCDMKG);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "1")]
	CAGJDFDCDED OLEMCGLJELB(NNGMJNPPBII<TGroup, TData> HAJIFJCDMKG);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "2")]
	CAGJDFDCDED ELEHIJEGPNN(FICMFJGNPDM<TGroup, TData> HAJIFJCDMKG);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "3")]
	CAGJDFDCDED KBGAJJPIOBN(AAGHAJAMGJN<TGroup> HAJIFJCDMKG);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface OEOLGBLMDBN<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<CAGJDFDCDED> CGGGIILIBLH(BFOCFHMNCHL<TData> HAJIFJCDMKG);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class PBKLNANMGJD<TGroup, TData> : CKKNDOIFDPM<MAGOGPOAAPB<TGroup, TData>, CAGJDFDCDED>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly FICMFJGNPDM<TGroup, TData> HAJIFJCDMKG;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x46B5E20", Offset = "0x46B4820", VA = "0x1846B5E20")]
	public PBKLNANMGJD(TGroup DAHALANMKMN, IEnumerable<TData> MEAEOFMNDKG, MAGOGPOAAPB<TGroup, TData> KGEAKKOPFLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x46B5D60", Offset = "0x46B4760", VA = "0x1846B5D60", Slot = "4")]
	public override CAGJDFDCDED GGDEKLHCCBN()
	{
		return default(CAGJDFDCDED);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class BCGBJKEHMKA<TGroup, TData> : CKKNDOIFDPM<MAGOGPOAAPB<TGroup, TData>, CAGJDFDCDED>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly NNGMJNPPBII<TGroup, TData> HAJIFJCDMKG;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x4DD6070", Offset = "0x4DD4A70", VA = "0x184DD6070")]
	public BCGBJKEHMKA(TGroup DAHALANMKMN, TData BHJLCNFNMMM, IEnumerable<TData> MEAEOFMNDKG, MAGOGPOAAPB<TGroup, TData> KGEAKKOPFLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x4DD5FA0", Offset = "0x4DD49A0", VA = "0x184DD5FA0", Slot = "4")]
	public override CAGJDFDCDED GGDEKLHCCBN()
	{
		return default(CAGJDFDCDED);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class EIJBNKILBJH<TGroup, TData> : CKKNDOIFDPM<MAGOGPOAAPB<TGroup, TData>, CAGJDFDCDED>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly AAGHAJAMGJN<TGroup> HAJIFJCDMKG;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3864A40", Offset = "0x3863440", VA = "0x183864A40")]
	public EIJBNKILBJH(TGroup DAHALANMKMN, MAGOGPOAAPB<TGroup, TData> KGEAKKOPFLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x3864980", Offset = "0x3863380", VA = "0x183864980", Slot = "4")]
	public override CAGJDFDCDED GGDEKLHCCBN()
	{
		return default(CAGJDFDCDED);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class DGKLEKJGPBG<TGroup, TData> : CKKNDOIFDPM<MAGOGPOAAPB<TGroup, TData>, CAGJDFDCDED>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly NNGMJNPPBII<TGroup, TData> HAJIFJCDMKG;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x4DD6070", Offset = "0x4DD4A70", VA = "0x184DD6070")]
	public DGKLEKJGPBG(TGroup DAHALANMKMN, TData GKGBMJKFHAH, IEnumerable<TData> MEAEOFMNDKG, MAGOGPOAAPB<TGroup, TData> KGEAKKOPFLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x57A0FC0", Offset = "0x579F9C0", VA = "0x1857A0FC0", Slot = "4")]
	public override CAGJDFDCDED GGDEKLHCCBN()
	{
		return default(CAGJDFDCDED);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class MKFLFEPDFKP<TData> : HDMDHNIPDOM<OEOLGBLMDBN<TData>, CAGJDFDCDED> where TData : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private struct DMHJKDNMOCG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public AsyncTaskMethodBuilder<CAGJDFDCDED> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public MKFLFEPDFKP<TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private TaskAwaiter<CAGJDFDCDED> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x57D0BA0", Offset = "0x57CF5A0", VA = "0x1857D0BA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x57D0E40", Offset = "0x57CF840", VA = "0x1857D0E40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private BFOCFHMNCHL<TData> HAJIFJCDMKG;

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x3864A40", Offset = "0x3863440", VA = "0x183864A40")]
	public MKFLFEPDFKP(IEnumerable<TData> FNEMKAPCEGN, OEOLGBLMDBN<TData> KGEAKKOPFLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x4479950", Offset = "0x4478350", VA = "0x184479950", Slot = "4")]
	[AsyncStateMachine(typeof(MKFLFEPDFKP<>.DMHJKDNMOCG))]
	public override Task<CAGJDFDCDED> GGDEKLHCCBN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public readonly struct ONFDDGOCEJC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly HOIFIGGALCP PIOMGNJDNPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly bool HCKKMFLMJJE;

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x690B420", Offset = "0x6909E20", VA = "0x18690B420")]
	public ONFDDGOCEJC(HOIFIGGALCP FIEBJHLMDDM, bool EOPPONKINEJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface FONACHFDEOD<TSpawnType> where TSpawnType : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> GGDEKLHCCBN(ONFDDGOCEJC NGAEDOJKBMB);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class EFODEFFBIAH<TSpawnType> : HDMDHNIPDOM<FONACHFDEOD<TSpawnType>, TSpawnType> where TSpawnType : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private struct ENOKFPLCIDI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public AsyncTaskMethodBuilder<TSpawnType> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public EFODEFFBIAH<TSpawnType> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private TaskAwaiter<TSpawnType> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x387AD40", Offset = "0x3879740", VA = "0x18387AD40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x387B860", Offset = "0x387A260", VA = "0x18387B860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly ONFDDGOCEJC NGAEDOJKBMB;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3844AE0", Offset = "0x38434E0", VA = "0x183844AE0")]
	public EFODEFFBIAH(HOIFIGGALCP FIEBJHLMDDM, bool EOPPONKINEJ, FONACHFDEOD<TSpawnType> KGEAKKOPFLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x38448E0", Offset = "0x38432E0", VA = "0x1838448E0", Slot = "4")]
	[AsyncStateMachine(typeof(EFODEFFBIAH<>.ENOKFPLCIDI))]
	public override Task<TSpawnType> GGDEKLHCCBN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public readonly struct HOIFIGGALCP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly bool KCAHAHFFINM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public readonly Vector3 BEOHJFBPBPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly Vector3 IOJOFKPMLAD;

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x690A8E0", Offset = "0x69092E0", VA = "0x18690A8E0")]
	public HOIFIGGALCP(Transform GBPCFIPKCMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x690A950", Offset = "0x6909350", VA = "0x18690A950")]
	public HOIFIGGALCP(Vector3 GKJCNLBHEIK, Vector3 GLNEOPDBMFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x690A820", Offset = "0x6909220", VA = "0x18690A820")]
	public static HOIFIGGALCP BGGBHBONJHL()
	{
		return default(HOIFIGGALCP);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x690A850", Offset = "0x6909250", VA = "0x18690A850")]
	private HOIFIGGALCP(bool HDGDIPFCKEM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public struct FJACADELOFP<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public TNode PMMLDEJENOP;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x3C084F0", Offset = "0x3C06EF0", VA = "0x183C084F0")]
	public FJACADELOFP(TNode PMMLDEJENOP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct DBCLFBDCIKC<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public TNode ENOMOFGKLCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public MEBPKMBIMAE IHEPJJANGHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly bool HCKKMFLMJJE;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x5757E00", Offset = "0x5756800", VA = "0x185757E00")]
	public DBCLFBDCIKC(TNode ENOMOFGKLCF, MEBPKMBIMAE IHEPJJANGHE, bool EOPPONKINEJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface BKGBEKNJMEJ<TNode>
{
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EPFBAPBGONI([In] FJACADELOFP<TNode> MEEHHCLIFCH);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool BIACLBBLNLP([In] DBCLFBDCIKC<TNode> NLFAPEOLBPD);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool PCMMFCKPEDN();
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class NPAAKNICFLD<TNode> : KPNFPOMCMJF<BKGBEKNJMEJ<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x3BE02E0", Offset = "0x3BDECE0", VA = "0x183BE02E0")]
	public NPAAKNICFLD(BKGBEKNJMEJ<TNode> KGEAKKOPFLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3E949F0", Offset = "0x3E933F0", VA = "0x183E949F0", Slot = "4")]
	public override bool GGDEKLHCCBN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class HBABFHIHDON<TNode> : KPNFPOMCMJF<BKGBEKNJMEJ<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly DBCLFBDCIKC<TNode> NLFAPEOLBPD;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x3DA4190", Offset = "0x3DA2B90", VA = "0x183DA4190")]
	public HBABFHIHDON(TNode ENOMOFGKLCF, MEBPKMBIMAE IHEPJJANGHE, BKGBEKNJMEJ<TNode> KGEAKKOPFLC, bool EOPPONKINEJ = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x3DA40D0", Offset = "0x3DA2AD0", VA = "0x183DA40D0", Slot = "4")]
	public override bool GGDEKLHCCBN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class CFAHLCGPFGJ<TNode> : KPNFPOMCMJF<BKGBEKNJMEJ<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly FJACADELOFP<TNode> MEEHHCLIFCH;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x515DC40", Offset = "0x515C640", VA = "0x18515DC40")]
	public CFAHLCGPFGJ(TNode EPPJBBOKCLM, BKGBEKNJMEJ<TNode> KGEAKKOPFLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3844590", Offset = "0x3842F90", VA = "0x183844590", Slot = "4")]
	public override bool GGDEKLHCCBN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct IGELEMEJPFH<TSpawnInfo> where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public TSpawnInfo BDMIJBJLEHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public Vector3 GLNEOPDBMFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public Quaternion NGGFFKDNCFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public float GIFACOBMIEN;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3E9A6C0", Offset = "0x3E990C0", VA = "0x183E9A6C0")]
	public IGELEMEJPFH(TSpawnInfo BDMIJBJLEHE, Vector3 GLNEOPDBMFP, Quaternion NGGFFKDNCFB, float GIFACOBMIEN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface MNBFPJONDEJ<TSpawnType, TSpawnInfo>
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> NLMNAMFBAGM([In] IGELEMEJPFH<TSpawnInfo> MBDBHCGALFO, CancellationToken AOLOJHLCMLE);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class JKCDBCMMENH<TSpawnType, TSpawnInfo> : HDMDHNIPDOM<MNBFPJONDEJ<TSpawnType, TSpawnInfo>, TSpawnType> where TSpawnType : notnull where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly IGELEMEJPFH<TSpawnInfo> BKANBMHGIEE;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x40E83A0", Offset = "0x40E6DA0", VA = "0x1840E83A0")]
	public JKCDBCMMENH(TSpawnInfo HLGDOLILLGL, Vector3 GLNEOPDBMFP, Quaternion NGGFFKDNCFB, float GIFACOBMIEN, MNBFPJONDEJ<TSpawnType, TSpawnInfo> KGEAKKOPFLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x40E82C0", Offset = "0x40E6CC0", VA = "0x1840E82C0", Slot = "4")]
	public override Task<TSpawnType> GGDEKLHCCBN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public readonly struct DBNGBBNOCHL<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public readonly IEnumerable<TData> KJBECJDCILP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public readonly bool HCKKMFLMJJE;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x575A200", Offset = "0x5758C00", VA = "0x18575A200")]
	public DBNGBBNOCHL(IEnumerable<TData> MEAEOFMNDKG, bool EOPPONKINEJ = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface MHGIHHDHMHL<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<CAGJDFDCDED> JCHPJGGMANH([In] DBNGBBNOCHL<TData> AIKIGCDOFMB, CancellationToken AOLOJHLCMLE);
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class LIHCDLMMHAI<TData> : HDMDHNIPDOM<MHGIHHDHMHL<TData>, CAGJDFDCDED> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private readonly DBNGBBNOCHL<TData> IINGNNJFFPK;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x4287600", Offset = "0x4286000", VA = "0x184287600")]
	public LIHCDLMMHAI(IEnumerable<TData> MEAEOFMNDKG, bool EOPPONKINEJ, MHGIHHDHMHL<TData> KGEAKKOPFLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x40E82C0", Offset = "0x40E6CC0", VA = "0x1840E82C0", Slot = "4")]
	public override Task<CAGJDFDCDED> GGDEKLHCCBN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct KFNEPMCKNFN<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public readonly T PIBCCEDJCCL;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x41BFF20", Offset = "0x41BE920", VA = "0x1841BFF20")]
	public KFNEPMCKNFN(T OEFFOEKDHJD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public interface FLGCKFEAKFC<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EPFBAPBGONI([In] KFNEPMCKNFN<T> JDEAJJNEMJB);

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool BIACLBBLNLP();
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface AEDAOKOFIEN<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GGDEKLHCCBN([In] MFLLNABKAIE<T> NBCDDMHBFNG);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct MFLLNABKAIE<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public readonly T PIBCCEDJCCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public readonly bool AOJNDJMJGJK;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x44704E0", Offset = "0x446EEE0", VA = "0x1844704E0")]
	public MFLLNABKAIE(T OEFFOEKDHJD, bool EANNIDLOCPG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class LDLKAMIBIAM<T> : KPNFPOMCMJF<FLGCKFEAKFC<T>> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x3BE02E0", Offset = "0x3BDECE0", VA = "0x183BE02E0")]
	public LDLKAMIBIAM(FLGCKFEAKFC<T> KGEAKKOPFLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x426B330", Offset = "0x4269D30", VA = "0x18426B330", Slot = "4")]
	public override bool GGDEKLHCCBN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public class KPCMODPHBPG<T> : KPNFPOMCMJF<FLGCKFEAKFC<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly KFNEPMCKNFN<T> JDEAJJNEMJB;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x41FD6D0", Offset = "0x41FC0D0", VA = "0x1841FD6D0")]
	public KPCMODPHBPG(T PIBCCEDJCCL, FLGCKFEAKFC<T> KGEAKKOPFLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x3844590", Offset = "0x3842F90", VA = "0x183844590", Slot = "4")]
	public override bool GGDEKLHCCBN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public class GLHEJKJCLCP<T> : KPNFPOMCMJF<AEDAOKOFIEN<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly MFLLNABKAIE<T> NBCDDMHBFNG;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x3D3A2B0", Offset = "0x3D38CB0", VA = "0x183D3A2B0")]
	public GLHEJKJCLCP(T PIBCCEDJCCL, bool EANNIDLOCPG, AEDAOKOFIEN<T> KGEAKKOPFLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x3844590", Offset = "0x3842F90", VA = "0x183844590", Slot = "4")]
	public override bool GGDEKLHCCBN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct GMPFNPDENCF<TData> where TData : notnull, FIPHDIHMIEC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public IEnumerable<TData> KJBECJDCILP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public bool HPHMIGGPLNM;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x3D3D930", Offset = "0x3D3C330", VA = "0x183D3D930")]
	public GMPFNPDENCF(IEnumerable<TData> OLCPJAOCBGE, bool LEIIPDNALGD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public struct MIPNILKBGJH<TData> where TData : notnull, FIPHDIHMIEC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public List<TData> KJBECJDCILP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public List<bool> AKJNMOBFAHO;

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x4478080", Offset = "0x4476A80", VA = "0x184478080")]
	public MIPNILKBGJH(List<TData> OLCPJAOCBGE, List<bool> KMMIENCBBGE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public interface FIPHDIHMIEC
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	bool MAOPJDCADND
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
public interface GDBOOFIHPFJ<TData> where TData : FIPHDIHMIEC
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GGDEKLHCCBN([In] GMPFNPDENCF<TData> ICGOJBFLMEI);

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GGDEKLHCCBN([In] MIPNILKBGJH<TData> ICGOJBFLMEI);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface BGJNKPHCCJB<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JMGCLFNGJGL(T PIBCCEDJCCL);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public class NIBDJLOACNH<TData> : KPNFPOMCMJF<GDBOOFIHPFJ<TData>> where TData : notnull, FIPHDIHMIEC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly GMPFNPDENCF<TData> ICGOJBFLMEI;

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x44E3FA0", Offset = "0x44E29A0", VA = "0x1844E3FA0")]
	public NIBDJLOACNH(List<TData> MEAEOFMNDKG, bool HPHMIGGPLNM, GDBOOFIHPFJ<TData> KGEAKKOPFLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x3844590", Offset = "0x3842F90", VA = "0x183844590", Slot = "4")]
	public override bool GGDEKLHCCBN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public class FIILBOFJNFH<TData> : KPNFPOMCMJF<GDBOOFIHPFJ<TData>> where TData : notnull, FIPHDIHMIEC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly MIPNILKBGJH<TData> ICGOJBFLMEI;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x3C07D20", Offset = "0x3C06720", VA = "0x183C07D20")]
	public FIILBOFJNFH(List<TData> MEAEOFMNDKG, List<bool> AKJNMOBFAHO, GDBOOFIHPFJ<TData> KGEAKKOPFLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x3C07C70", Offset = "0x3C06670", VA = "0x183C07C70", Slot = "4")]
	public override bool GGDEKLHCCBN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface NJAJOLEELGF<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<CAGJDFDCDED> GGDEKLHCCBN(IILPCJPEDDG<TData> BCABBNMKMLL);
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public class JOMMBKDBLIA<TData> : HDMDHNIPDOM<NJAJOLEELGF<TData>, CAGJDFDCDED> where TData : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private struct FKIFGBMFGHK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public AsyncTaskMethodBuilder<CAGJDFDCDED> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public JOMMBKDBLIA<TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private TaskAwaiter<CAGJDFDCDED> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x3C256E0", Offset = "0x3C240E0", VA = "0x183C256E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x3C259C0", Offset = "0x3C243C0", VA = "0x183C259C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly IILPCJPEDDG<TData> EDDBFACKGIG;

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x410FD50", Offset = "0x410E750", VA = "0x18410FD50")]
	public JOMMBKDBLIA(TData LGFDKMEPAPH, IReadOnlyList<TData> KPDGCCAKPMB, bool EOPPONKINEJ, NJAJOLEELGF<TData> KGEAKKOPFLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x410FC50", Offset = "0x410E650", VA = "0x18410FC50", Slot = "4")]
	[AsyncStateMachine(typeof(JOMMBKDBLIA<>.FKIFGBMFGHK))]
	public override Task<CAGJDFDCDED> GGDEKLHCCBN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public struct IILPCJPEDDG<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public TData JCAMEHKAGEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public IReadOnlyList<TData> PAFNODGOHPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public bool HCKKMFLMJJE;

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x3E9CC70", Offset = "0x3E9B670", VA = "0x183E9CC70")]
	public IILPCJPEDDG(TData LGFDKMEPAPH, IReadOnlyList<TData> KPDGCCAKPMB, bool EOPPONKINEJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public interface AFDBENOFKFI<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GGDEKLHCCBN([In] DJFPHPPBJKM<TData> HIIIHGKOIOK);
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public interface EFOJJFIHGCG<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GGDEKLHCCBN([In] OLAHAEDFFMD<TData> HIIIHGKOIOK);
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface HCFJBHOMJLG<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HLPLJLHGALL([In] JIHDENABENE<TData> HIIIHGKOIOK);

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BIACLBBLNLP();
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public class HCNIDHPHAIH<TData> : KPNFPOMCMJF<AFDBENOFKFI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly DJFPHPPBJKM<TData> HIIIHGKOIOK;

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x3DAF390", Offset = "0x3DADD90", VA = "0x183DAF390")]
	public HCNIDHPHAIH(IEnumerable<TData> MEAEOFMNDKG, JHALCGHGKFM COGPPELINPO, IEFJNCNDPKA OKNIOBAOHHE, float JEOJDNAAEJE, bool EOPPONKINEJ, AFDBENOFKFI<TData> KGEAKKOPFLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x3844590", Offset = "0x3842F90", VA = "0x183844590", Slot = "4")]
	public override bool GGDEKLHCCBN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class DNGJAHLGLKE<TData> : KPNFPOMCMJF<EFOJJFIHGCG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly OLAHAEDFFMD<TData> HIIIHGKOIOK;

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x57D1580", Offset = "0x57CFF80", VA = "0x1857D1580")]
	public DNGJAHLGLKE(TData[] MEAEOFMNDKG, JHALCGHGKFM[] COGPPELINPO, IEFJNCNDPKA[] OKNIOBAOHHE, float[] JEOJDNAAEJE, EFOJJFIHGCG<TData> KGEAKKOPFLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x3D27F80", Offset = "0x3D26980", VA = "0x183D27F80", Slot = "4")]
	public override bool GGDEKLHCCBN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class GEOIKKGIIHI<TData> : KPNFPOMCMJF<HCFJBHOMJLG<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x3BE02E0", Offset = "0x3BDECE0", VA = "0x183BE02E0")]
	public GEOIKKGIIHI(HCFJBHOMJLG<TData> KGEAKKOPFLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x3D1AA00", Offset = "0x3D19400", VA = "0x183D1AA00", Slot = "4")]
	public override bool GGDEKLHCCBN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class GFOEAAEOECF<TData> : KPNFPOMCMJF<HCFJBHOMJLG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly JIHDENABENE<TData> HIIIHGKOIOK;

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x3D28030", Offset = "0x3D26A30", VA = "0x183D28030")]
	public GFOEAAEOECF(IEnumerable<TData> MEAEOFMNDKG, JHALCGHGKFM COGPPELINPO, IEFJNCNDPKA OKNIOBAOHHE, float JEOJDNAAEJE, HCFJBHOMJLG<TData> KGEAKKOPFLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x3D27F80", Offset = "0x3D26980", VA = "0x183D27F80", Slot = "4")]
	public override bool GGDEKLHCCBN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public struct DJFPHPPBJKM<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public IEnumerable<TData> KJBECJDCILP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public JHALCGHGKFM CFMBBGMFHHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public IEFJNCNDPKA ELGPMOBIFBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public float JEOJDNAAEJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public bool EOPPONKINEJ;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x57C4C30", Offset = "0x57C3630", VA = "0x1857C4C30")]
	public DJFPHPPBJKM(IEnumerable<TData> MEAEOFMNDKG, JHALCGHGKFM COGPPELINPO, IEFJNCNDPKA OKNIOBAOHHE, float JEOJDNAAEJE, bool EOPPONKINEJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public struct OLAHAEDFFMD<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public TData[] KJBECJDCILP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public JHALCGHGKFM[] CFMBBGMFHHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public IEFJNCNDPKA[] ELGPMOBIFBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public float[] JEOJDNAAEJE;

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x460F870", Offset = "0x460E270", VA = "0x18460F870")]
	public OLAHAEDFFMD(TData[] MEAEOFMNDKG, JHALCGHGKFM[] COGPPELINPO, IEFJNCNDPKA[] OKNIOBAOHHE, float[] JEOJDNAAEJE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public struct JIHDENABENE<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public IEnumerable<TData> KJBECJDCILP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public JHALCGHGKFM CFMBBGMFHHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public IEFJNCNDPKA ELGPMOBIFBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public float JEOJDNAAEJE;

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x40D7B80", Offset = "0x40D6580", VA = "0x1840D7B80")]
	public JIHDENABENE(IEnumerable<TData> MEAEOFMNDKG, JHALCGHGKFM COGPPELINPO, IEFJNCNDPKA OKNIOBAOHHE, float JEOJDNAAEJE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public interface HMHJPBCGAML<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ELEHIJEGPNN([In] JKOBABOKELN<TData> AIKIGCDOFMB);

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KBGAJJPIOBN([In] JKOBABOKELN<TData> AIKIGCDOFMB);

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FFOGBHPIDAF([In] bool GPFBNLMIFGL);

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool AOFFEFDELNF([In] JKOBABOKELN<TData> AIKIGCDOFMB);

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DNFJGBLLHKA();

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool JBIACKCANFO([In] TData JAMBMCLCAPI);
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public class MKFDLIDOKPC<TData> : KPNFPOMCMJF<HMHJPBCGAML<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly JKOBABOKELN<TData> AIKIGCDOFMB;

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x4479810", Offset = "0x4478210", VA = "0x184479810")]
	public MKFDLIDOKPC(List<TData> KJGLHKICAHL, HMHJPBCGAML<TData> KGEAKKOPFLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x3844590", Offset = "0x3842F90", VA = "0x183844590", Slot = "4")]
	public override bool GGDEKLHCCBN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public class OECALBDILGD<TData> : KPNFPOMCMJF<HMHJPBCGAML<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x3BE02E0", Offset = "0x3BDECE0", VA = "0x183BE02E0")]
	public OECALBDILGD(HMHJPBCGAML<TData> KGEAKKOPFLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x45FB5D0", Offset = "0x45F9FD0", VA = "0x1845FB5D0", Slot = "4")]
	public override bool GGDEKLHCCBN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class AIGEEMMPJEI<TData> : KPNFPOMCMJF<HMHJPBCGAML<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly bool EOPPONKINEJ;

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x3CE6A30", Offset = "0x3CE5430", VA = "0x183CE6A30")]
	public AIGEEMMPJEI(bool EOPPONKINEJ, HMHJPBCGAML<TData> KGEAKKOPFLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x3CE69D0", Offset = "0x3CE53D0", VA = "0x183CE69D0", Slot = "4")]
	public override bool GGDEKLHCCBN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class MLDNBKLMBNJ<TData> : KPNFPOMCMJF<HMHJPBCGAML<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly JKOBABOKELN<TData> AIKIGCDOFMB;

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x447B9B0", Offset = "0x447A3B0", VA = "0x18447B9B0")]
	public MLDNBKLMBNJ(List<TData> KJGLHKICAHL, bool EOPPONKINEJ, HMHJPBCGAML<TData> KGEAKKOPFLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x3C07C70", Offset = "0x3C06670", VA = "0x183C07C70", Slot = "4")]
	public override bool GGDEKLHCCBN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public class OKDEJHIMOIO<TData> : KPNFPOMCMJF<HMHJPBCGAML<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private readonly TData JAMBMCLCAPI;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x460BB10", Offset = "0x460A510", VA = "0x18460BB10")]
	public OKDEJHIMOIO(TData JAMBMCLCAPI, HMHJPBCGAML<TData> KGEAKKOPFLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x460BA50", Offset = "0x460A450", VA = "0x18460BA50", Slot = "4")]
	public override bool GGDEKLHCCBN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class KKPOPMHMPOF<TData> : KPNFPOMCMJF<HMHJPBCGAML<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly JKOBABOKELN<TData> AIKIGCDOFMB;

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x41ECA60", Offset = "0x41EB460", VA = "0x1841ECA60")]
	public KKPOPMHMPOF(IEnumerable<TData> KJGLHKICAHL, HMHJPBCGAML<TData> KGEAKKOPFLC, bool EOPPONKINEJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x41EC8F0", Offset = "0x41EB2F0", VA = "0x1841EC8F0", Slot = "4")]
	public override bool GGDEKLHCCBN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public struct JKOBABOKELN<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public IEnumerable<TData> KJBECJDCILP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public bool EOPPONKINEJ;

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x40EBB60", Offset = "0x40EA560", VA = "0x1840EBB60")]
	public JKOBABOKELN(IEnumerable<TData> OLCPJAOCBGE, bool OKMOGLAAMPB = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public interface LBCPHIDCOPN
{
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<CAGJDFDCDED> GGDEKLHCCBN(FAADOCNEAKL FGDEAPCDKCG);
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public class DCCABHLCOGO : HDMDHNIPDOM<LBCPHIDCOPN, CAGJDFDCDED>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private struct IAJIHFCCFCM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public AsyncTaskMethodBuilder<CAGJDFDCDED> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public DCCABHLCOGO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private TaskAwaiter<CAGJDFDCDED> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x690A980", Offset = "0x6909380", VA = "0x18690A980", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x690ABF0", Offset = "0x69095F0", VA = "0x18690ABF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly FAADOCNEAKL ANLPLANIKID;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x690A5D0", Offset = "0x6908FD0", VA = "0x18690A5D0")]
	public DCCABHLCOGO(bool EOPPONKINEJ, LBCPHIDCOPN KGEAKKOPFLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x690A4E0", Offset = "0x6908EE0", VA = "0x18690A4E0", Slot = "4")]
	[AsyncStateMachine(typeof(IAJIHFCCFCM))]
	public override Task<CAGJDFDCDED> GGDEKLHCCBN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public struct FAADOCNEAKL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public bool HCKKMFLMJJE;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0xE21AD0", Offset = "0xE204D0", VA = "0x180E21AD0")]
	public FAADOCNEAKL(bool EOPPONKINEJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public readonly struct NBMIIFDFAEH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly bool FBGNAOLICKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public readonly bool HCGDALHNLCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public readonly bool GIFACOBMIEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public readonly bool EOPPONKINEJ;

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x4C612C0", Offset = "0x4C5FCC0", VA = "0x184C612C0")]
	public NBMIIFDFAEH(bool FBGNAOLICKN, bool HCGDALHNLCB, bool GIFACOBMIEN, bool EOPPONKINEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x690B390", Offset = "0x6909D90", VA = "0x18690B390")]
	public NBMIIFDFAEH(bool HCGDALHNLCB, bool EOPPONKINEJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public interface KONHAMIEBJA
{
	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KNNFNLAKNML(NBMIIFDFAEH MCLBHOKDDBA);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NJEFJMKAEHB(NBMIIFDFAEH MCLBHOKDDBA);
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public class EGOMDNHDKFN : KPNFPOMCMJF<KONHAMIEBJA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly NBMIIFDFAEH MCLBHOKDDBA;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x690A750", Offset = "0x6909150", VA = "0x18690A750")]
	public EGOMDNHDKFN(bool OFGHBAGNEDJ, bool HCGDALHNLCB, bool GIFACOBMIEN, bool EOPPONKINEJ, KONHAMIEBJA KGEAKKOPFLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x690A700", Offset = "0x6909100", VA = "0x18690A700", Slot = "4")]
	public override bool GGDEKLHCCBN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class DFNHJCJLKKF : KPNFPOMCMJF<KONHAMIEBJA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly NBMIIFDFAEH MCLBHOKDDBA;

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x690A680", Offset = "0x6909080", VA = "0x18690A680")]
	public DFNHJCJLKKF(bool HCGDALHNLCB, bool EOPPONKINEJ, KONHAMIEBJA KGEAKKOPFLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x690A630", Offset = "0x6909030", VA = "0x18690A630", Slot = "4")]
	public override bool GGDEKLHCCBN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public interface LMLHLMGCAJP
{
	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GGDEKLHCCBN([In] IDFCKLOKOGJ AKIGDKANDDH);
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class LGFMDAFPKDG : KPNFPOMCMJF<LMLHLMGCAJP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly IDFCKLOKOGJ AKIGDKANDDH;

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x690B1B0", Offset = "0x6909BB0", VA = "0x18690B1B0")]
	public LGFMDAFPKDG(Guid[] OJODNELIEAM, Vector3[] FICHHPJDHKH, Quaternion[] DEBMLKAHFEC, float[] KHCKNMKLBLA, Dictionary<Guid, Vector3> GLMEMKONGKK, LMLHLMGCAJP KGEAKKOPFLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x690B100", Offset = "0x6909B00", VA = "0x18690B100", Slot = "4")]
	public override bool GGDEKLHCCBN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public interface BIJCAAPOMBM<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EPFBAPBGONI([In] LCDENEOJENJ<TData> MEEHHCLIFCH);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HLPLJLHGALL([In] HEDFLNPLNON JPNMLMKHLBH);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool HLPLJLHGALL([In] KFHKJHNBIOH JPNMLMKHLBH);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool BIACLBBLNLP();
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class LAGILLALMCF<TData> : KPNFPOMCMJF<BIJCAAPOMBM<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x3BE02E0", Offset = "0x3BDECE0", VA = "0x183BE02E0")]
	public LAGILLALMCF(BIJCAAPOMBM<TData> KGEAKKOPFLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x425B680", Offset = "0x425A080", VA = "0x18425B680", Slot = "4")]
	public override bool GGDEKLHCCBN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public class HLDHFFGPNPA<TData> : KPNFPOMCMJF<BIJCAAPOMBM<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly HEDFLNPLNON ENLEPMPHDKJ;

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x3DE0E20", Offset = "0x3DDF820", VA = "0x183DE0E20")]
	public HLDHFFGPNPA(Vector3 GJMLIHLBKON, bool DGOBEFAGCCE, BIJCAAPOMBM<TData> KGEAKKOPFLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x383B970", Offset = "0x383A370", VA = "0x18383B970", Slot = "4")]
	public override bool GGDEKLHCCBN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public class EHEPOAGPFED<TData> : KPNFPOMCMJF<BIJCAAPOMBM<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly KFHKJHNBIOH ENLEPMPHDKJ;

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x384F4D0", Offset = "0x384DED0", VA = "0x18384F4D0")]
	public EHEPOAGPFED(Guid DECCCPKCGDM, int ILOCEPPJPDO, Vector3 GLNEOPDBMFP, Quaternion NGGFFKDNCFB, float EHEGOIJKGEH, bool DGOBEFAGCCE, BIJCAAPOMBM<TData> KGEAKKOPFLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x384F470", Offset = "0x384DE70", VA = "0x18384F470", Slot = "4")]
	public override bool GGDEKLHCCBN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class GFHLICIJAKJ<TData> : KPNFPOMCMJF<BIJCAAPOMBM<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly LCDENEOJENJ<TData> ENLEPMPHDKJ;

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x3D27ED0", Offset = "0x3D268D0", VA = "0x183D27ED0")]
	public GFHLICIJAKJ(TData PIBCCEDJCCL, bool EOPPONKINEJ, BIJCAAPOMBM<TData> KGEAKKOPFLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x3844590", Offset = "0x3842F90", VA = "0x183844590", Slot = "4")]
	public override bool GGDEKLHCCBN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public struct HEDFLNPLNON
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public readonly Vector3 GJMLIHLBKON;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public readonly bool DGOBEFAGCCE;

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x690A800", Offset = "0x6909200", VA = "0x18690A800")]
	public HEDFLNPLNON(Vector3 GJMLIHLBKON, bool DGOBEFAGCCE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public struct KFHKJHNBIOH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public readonly Guid DECCCPKCGDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public readonly int ILOCEPPJPDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public readonly Vector3 GLNEOPDBMFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public readonly Quaternion NGGFFKDNCFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public readonly float EHEGOIJKGEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public readonly bool DGOBEFAGCCE;

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x690B0C0", Offset = "0x6909AC0", VA = "0x18690B0C0")]
	public KFHKJHNBIOH(Guid DECCCPKCGDM, int ILOCEPPJPDO, Vector3 GLNEOPDBMFP, Quaternion NGGFFKDNCFB, float EHEGOIJKGEH, bool DGOBEFAGCCE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public struct LCDENEOJENJ<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public readonly TData PIBCCEDJCCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public readonly bool EOPPONKINEJ;

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x4268DD0", Offset = "0x42677D0", VA = "0x184268DD0")]
	public LCDENEOJENJ(TData PIBCCEDJCCL, bool EOPPONKINEJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public interface KCOLAPNOAEB<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GGDEKLHCCBN([In] OFHHKDHNCGG<TData> HMAGOOBGCGC);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GGDEKLHCCBN([In] NBDMKMOHAJM<TData> HMAGOOBGCGC);
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public interface POFKDOBPHDI<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EPFBAPBGONI([In] GMFIOMBBDJH<TData> FFOGGMKANBD);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HLPLJLHGALL([In] MFJGCNGONJO JPNMLMKHLBH);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool BIACLBBLNLP();
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public class HICALKCHFGJ<TData> : KPNFPOMCMJF<KCOLAPNOAEB<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly OFHHKDHNCGG<TData> HMAGOOBGCGC;

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x3DCF010", Offset = "0x3DCDA10", VA = "0x183DCF010")]
	public HICALKCHFGJ(IEnumerable<TData> MEAEOFMNDKG, Vector3 KMEPIIBBOGO, bool EOPPONKINEJ, KCOLAPNOAEB<TData> KGEAKKOPFLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x3844590", Offset = "0x3842F90", VA = "0x183844590", Slot = "4")]
	public override bool GGDEKLHCCBN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public class IDPHEPCOGGJ<TData> : KPNFPOMCMJF<POFKDOBPHDI<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x3BE02E0", Offset = "0x3BDECE0", VA = "0x183BE02E0")]
	public IDPHEPCOGGJ(POFKDOBPHDI<TData> KGEAKKOPFLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x3E949F0", Offset = "0x3E933F0", VA = "0x183E949F0", Slot = "4")]
	public override bool GGDEKLHCCBN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class FEAPOGCHNHH<TData> : KPNFPOMCMJF<POFKDOBPHDI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly GMFIOMBBDJH<TData> HMAGOOBGCGC;

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x3BF6A60", Offset = "0x3BF5460", VA = "0x183BF6A60")]
	public FEAPOGCHNHH(IEnumerable<TData> MEAEOFMNDKG, bool EOPPONKINEJ, POFKDOBPHDI<TData> KGEAKKOPFLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x3844590", Offset = "0x3842F90", VA = "0x183844590", Slot = "4")]
	public override bool GGDEKLHCCBN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class LDPGKJLHKMI<TData> : KPNFPOMCMJF<KCOLAPNOAEB<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly NBDMKMOHAJM<TData> HMAGOOBGCGC;

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x426B740", Offset = "0x426A140", VA = "0x18426B740")]
	public LDPGKJLHKMI(IEnumerable<TData> MEAEOFMNDKG, Vector3 KOOAIGPJHJI, NADLKJPIABO ILMCKBACMLD, bool EOPPONKINEJ, KCOLAPNOAEB<TData> KGEAKKOPFLC, Space OJJOPADGNLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x3DA40D0", Offset = "0x3DA2AD0", VA = "0x183DA40D0", Slot = "4")]
	public override bool GGDEKLHCCBN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class IFPFEMDIJDF<TData> : KPNFPOMCMJF<POFKDOBPHDI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly MFJGCNGONJO HMAGOOBGCGC;

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x3E99DC0", Offset = "0x3E987C0", VA = "0x183E99DC0")]
	public IFPFEMDIJDF(Vector3 KMEPIIBBOGO, POFKDOBPHDI<TData> KGEAKKOPFLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x383B970", Offset = "0x383A370", VA = "0x18383B970", Slot = "4")]
	public override bool GGDEKLHCCBN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public struct OFHHKDHNCGG<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public readonly IEnumerable<TData> MEAEOFMNDKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public readonly Vector3 KMEPIIBBOGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public readonly bool EOPPONKINEJ;

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x45FB620", Offset = "0x45FA020", VA = "0x1845FB620")]
	public OFHHKDHNCGG(IEnumerable<TData> MEAEOFMNDKG, Vector3 KMEPIIBBOGO, bool EOPPONKINEJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public struct GMFIOMBBDJH<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public readonly IEnumerable<TData> MEAEOFMNDKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public readonly bool EOPPONKINEJ;

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x3D3A9A0", Offset = "0x3D393A0", VA = "0x183D3A9A0")]
	public GMFIOMBBDJH(IEnumerable<TData> MEAEOFMNDKG, bool EOPPONKINEJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public struct NBDMKMOHAJM<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public readonly IEnumerable<TData> MEAEOFMNDKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public readonly Vector3 KOOAIGPJHJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public readonly NADLKJPIABO ILMCKBACMLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public readonly bool EOPPONKINEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public readonly Space OJJOPADGNLJ;

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x44CADA0", Offset = "0x44C97A0", VA = "0x1844CADA0")]
	public NBDMKMOHAJM(IEnumerable<TData> MEAEOFMNDKG, Vector3 KOOAIGPJHJI, NADLKJPIABO ILMCKBACMLD, bool EOPPONKINEJ, Space OJJOPADGNLJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public struct MFJGCNGONJO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public readonly Vector3 KMEPIIBBOGO;

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x2150900", Offset = "0x214F300", VA = "0x182150900")]
	public MFJGCNGONJO(Vector3 KMEPIIBBOGO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public enum NADLKJPIABO
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
[Cpp2IlInjected.Token(Token = "0x2000073")]
public interface FDFBLOEKHAN
{
	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GGDEKLHCCBN([In] CBKPOACEIOG AMOEFBOHJBI);
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public class PMCLPLHPJIL : KPNFPOMCMJF<FDFBLOEKHAN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly CBKPOACEIOG AMOEFBOHJBI;

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x690B4F0", Offset = "0x6909EF0", VA = "0x18690B4F0")]
	public PMCLPLHPJIL(bool EOPPONKINEJ, FDFBLOEKHAN KGEAKKOPFLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x690B440", Offset = "0x6909E40", VA = "0x18690B440", Slot = "4")]
	public override bool GGDEKLHCCBN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public readonly struct CBKPOACEIOG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public readonly bool EOPPONKINEJ;

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0xE21AD0", Offset = "0xE204D0", VA = "0x180E21AD0")]
	public CBKPOACEIOG(bool EOPPONKINEJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public interface EEODNINAJFA<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GGDEKLHCCBN([In] DDNFCBGBLBK<TData> MILFIICFFDO);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GGDEKLHCCBN([In] OCJNIHHFKJM<TData> MILFIICFFDO);
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public interface JOHMPBKOEIB<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EPFBAPBGONI([In] ACBMBDDHBKH<TData> MEEHHCLIFCH);

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HLPLJLHGALL([In] EMFPMCGBNLK JPNMLMKHLBH);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool BIACLBBLNLP();
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public class LOPDEMOHCPO<TData> : KPNFPOMCMJF<EEODNINAJFA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly DDNFCBGBLBK<TData> MILFIICFFDO;

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x42A7180", Offset = "0x42A5B80", VA = "0x1842A7180")]
	public LOPDEMOHCPO(IEnumerable<TData> MEAEOFMNDKG, Quaternion KMEPIIBBOGO, Vector3? DGFKJIDKEFO, bool GBGJPPIIJMC, bool EOPPONKINEJ, EEODNINAJFA<TData> KGEAKKOPFLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x3844590", Offset = "0x3842F90", VA = "0x183844590", Slot = "4")]
	public override bool GGDEKLHCCBN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public class DMFJGEKGHMG<TData> : KPNFPOMCMJF<JOHMPBKOEIB<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x3BE02E0", Offset = "0x3BDECE0", VA = "0x183BE02E0")]
	public DMFJGEKGHMG(JOHMPBKOEIB<TData> KGEAKKOPFLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x3E949F0", Offset = "0x3E933F0", VA = "0x183E949F0", Slot = "4")]
	public override bool GGDEKLHCCBN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public class EFJLOENIEKH<TData> : KPNFPOMCMJF<JOHMPBKOEIB<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly ACBMBDDHBKH<TData> MILFIICFFDO;

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x3844640", Offset = "0x3843040", VA = "0x183844640")]
	public EFJLOENIEKH(IEnumerable<TData> MEAEOFMNDKG, bool EOPPONKINEJ, JOHMPBKOEIB<TData> KGEAKKOPFLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x3844590", Offset = "0x3842F90", VA = "0x183844590", Slot = "4")]
	public override bool GGDEKLHCCBN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public class MIMIKDCDAFH<TData> : KPNFPOMCMJF<EEODNINAJFA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly OCJNIHHFKJM<TData> MILFIICFFDO;

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x4475AD0", Offset = "0x44744D0", VA = "0x184475AD0")]
	public MIMIKDCDAFH(IEnumerable<TData> MEAEOFMNDKG, Quaternion IFDBNFBKKAA, NADLKJPIABO GPLBLOFKIFM, Vector3? DGFKJIDKEFO, bool GBGJPPIIJMC, bool EOPPONKINEJ, Space OJJOPADGNLJ, EEODNINAJFA<TData> KGEAKKOPFLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x3DA40D0", Offset = "0x3DA2AD0", VA = "0x183DA40D0", Slot = "4")]
	public override bool GGDEKLHCCBN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public class NJMIOFJMOML<TData> : KPNFPOMCMJF<JOHMPBKOEIB<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly EMFPMCGBNLK MILFIICFFDO;

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x44E4060", Offset = "0x44E2A60", VA = "0x1844E4060")]
	public NJMIOFJMOML(Quaternion KMEPIIBBOGO, Vector3? DGFKJIDKEFO, bool GBGJPPIIJMC, JOHMPBKOEIB<TData> KGEAKKOPFLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x383B970", Offset = "0x383A370", VA = "0x18383B970", Slot = "4")]
	public override bool GGDEKLHCCBN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public struct DDNFCBGBLBK<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public readonly IEnumerable<TData> MEAEOFMNDKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public readonly Quaternion KMEPIIBBOGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public readonly Vector3? DGFKJIDKEFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public readonly bool GBGJPPIIJMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public readonly bool EOPPONKINEJ;

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x5766840", Offset = "0x5765240", VA = "0x185766840")]
	public DDNFCBGBLBK(IEnumerable<TData> MEAEOFMNDKG, Quaternion KMEPIIBBOGO, Vector3? DGFKJIDKEFO, bool GBGJPPIIJMC, bool EOPPONKINEJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public struct ACBMBDDHBKH<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public readonly IEnumerable<TData> MEAEOFMNDKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public readonly bool EOPPONKINEJ;

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x3CCDF50", Offset = "0x3CCC950", VA = "0x183CCDF50")]
	public ACBMBDDHBKH(IEnumerable<TData> MEAEOFMNDKG, bool EOPPONKINEJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public struct OCJNIHHFKJM<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public readonly IEnumerable<TData> MEAEOFMNDKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public readonly Quaternion IFDBNFBKKAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public readonly NADLKJPIABO GPLBLOFKIFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public readonly Vector3? DGFKJIDKEFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public readonly bool GBGJPPIIJMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public readonly bool EOPPONKINEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public readonly Space OJJOPADGNLJ;

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x45F9010", Offset = "0x45F7A10", VA = "0x1845F9010")]
	public OCJNIHHFKJM(IEnumerable<TData> MEAEOFMNDKG, Quaternion IFDBNFBKKAA, NADLKJPIABO GPLBLOFKIFM, Vector3? DGFKJIDKEFO, bool GBGJPPIIJMC, bool EOPPONKINEJ, Space OJJOPADGNLJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public struct EMFPMCGBNLK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public readonly Quaternion KMEPIIBBOGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public readonly Vector3? DGFKJIDKEFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public readonly bool GBGJPPIIJMC;

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x4C242D0", Offset = "0x4C22CD0", VA = "0x184C242D0")]
	public EMFPMCGBNLK(Quaternion KMEPIIBBOGO, Vector3? DGFKJIDKEFO, bool GBGJPPIIJMC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public interface NIOCIENMIGA<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EPFBAPBGONI([In] IBLIBCAPPMP<TData> MEEHHCLIFCH);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HLPLJLHGALL([In] LHLCCEMOENH JPNMLMKHLBH);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool HLPLJLHGALL([In] FFLFKEMICCK JPNMLMKHLBH);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool HLPLJLHGALL([In] AINIHJOCKDA JPNMLMKHLBH);

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool BIACLBBLNLP();
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public class AGLLJNOPNBM<TData> : KPNFPOMCMJF<NIOCIENMIGA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly AINIHJOCKDA KPLGFMGKHBK;

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x3CDA950", Offset = "0x3CD9350", VA = "0x183CDA950")]
	public AGLLJNOPNBM(Vector3 OPEFBMJCMEL, float MCFAHFLECNM, Vector3 DGFKJIDKEFO, bool JGNCIEDMFBK, bool LJGLCIFJFKL, NIOCIENMIGA<TData> KGEAKKOPFLC, Space OJJOPADGNLJ = Space.Self)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x3CDA8F0", Offset = "0x3CD92F0", VA = "0x183CDA8F0", Slot = "4")]
	public override bool GGDEKLHCCBN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public class JFPMOONNPMJ<TData> : KPNFPOMCMJF<NIOCIENMIGA<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x3BE02E0", Offset = "0x3BDECE0", VA = "0x183BE02E0")]
	public JFPMOONNPMJ(NIOCIENMIGA<TData> KGEAKKOPFLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x405D870", Offset = "0x405C270", VA = "0x18405D870", Slot = "4")]
	public override bool GGDEKLHCCBN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public class NAJFKDJNNDP<TData> : KPNFPOMCMJF<NIOCIENMIGA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly IBLIBCAPPMP<TData> KPLGFMGKHBK;

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x44C98C0", Offset = "0x44C82C0", VA = "0x1844C98C0")]
	public NAJFKDJNNDP(IEnumerable<TData> MEAEOFMNDKG, bool EOPPONKINEJ, NIOCIENMIGA<TData> KGEAKKOPFLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x3844590", Offset = "0x3842F90", VA = "0x183844590", Slot = "4")]
	public override bool GGDEKLHCCBN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public class AFHAKCMDENB<TData> : KPNFPOMCMJF<NIOCIENMIGA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly FFLFKEMICCK KPLGFMGKHBK;

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x3CD6A30", Offset = "0x3CD5430", VA = "0x183CD6A30")]
	public AFHAKCMDENB(float ELFAMKPNBBN, bool OGCHMHKIBJJ, Vector3 DGFKJIDKEFO, NIOCIENMIGA<TData> KGEAKKOPFLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x3CD6970", Offset = "0x3CD5370", VA = "0x183CD6970", Slot = "4")]
	public override bool GGDEKLHCCBN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public class EDIAPAFNAAJ<TData> : KPNFPOMCMJF<NIOCIENMIGA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly LHLCCEMOENH KPLGFMGKHBK;

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x383B9D0", Offset = "0x383A3D0", VA = "0x18383B9D0")]
	public EDIAPAFNAAJ(float MCFAHFLECNM, Vector3 DGFKJIDKEFO, NIOCIENMIGA<TData> KGEAKKOPFLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x383B970", Offset = "0x383A370", VA = "0x18383B970", Slot = "4")]
	public override bool GGDEKLHCCBN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public struct AINIHJOCKDA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public readonly Vector3 OPEFBMJCMEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public readonly float MCFAHFLECNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public readonly Vector3 DGFKJIDKEFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public readonly bool DGOBEFAGCCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public readonly Space OJJOPADGNLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public readonly bool LJGLCIFJFKL;

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x6909EA0", Offset = "0x69088A0", VA = "0x186909EA0")]
	public AINIHJOCKDA(Vector3 OPEFBMJCMEL, float MCFAHFLECNM, Vector3 DGFKJIDKEFO, bool DGOBEFAGCCE, bool GELDBDHLDIG, Space OJJOPADGNLJ = Space.Self)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public struct IBLIBCAPPMP<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public readonly IEnumerable<TData> MEAEOFMNDKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public readonly bool EOPPONKINEJ;

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x3E90FD0", Offset = "0x3E8F9D0", VA = "0x183E90FD0")]
	public IBLIBCAPPMP(IEnumerable<TData> MEAEOFMNDKG, bool EOPPONKINEJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public struct FFLFKEMICCK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public readonly float ELFAMKPNBBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public readonly bool OGCHMHKIBJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public readonly Vector3 DGFKJIDKEFO;

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x690A7E0", Offset = "0x69091E0", VA = "0x18690A7E0")]
	public FFLFKEMICCK(float ELFAMKPNBBN, bool OGCHMHKIBJJ, Vector3 DGFKJIDKEFO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public struct LHLCCEMOENH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public readonly float MCFAHFLECNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public readonly Vector3 DGFKJIDKEFO;

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x4C00BB0", Offset = "0x4BFF5B0", VA = "0x184C00BB0")]
	public LHLCCEMOENH(float MCFAHFLECNM, Vector3 DGFKJIDKEFO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public struct IDFCKLOKOGJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public readonly Guid[] MEAEOFMNDKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public readonly bool OMDBEPDLIGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public readonly bool KPAPKHIHHJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public readonly bool BICDMDHPGMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public readonly Vector3[] FICHHPJDHKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public readonly Quaternion[] DEBMLKAHFEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public readonly float[] KHCKNMKLBLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public readonly Dictionary<Guid, Vector3> GLMEMKONGKK;

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x690AE30", Offset = "0x6909830", VA = "0x18690AE30")]
	public IDFCKLOKOGJ(Guid[] OJODNELIEAM, Vector3[] FICHHPJDHKH, Quaternion[] DEBMLKAHFEC, float[] KHCKNMKLBLA, Dictionary<Guid, Vector3> GLMEMKONGKK, bool OMDBEPDLIGF = true, bool KPAPKHIHHJE = true, bool BICDMDHPGMD = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x690AC60", Offset = "0x6909660", VA = "0x18690AC60")]
	private static void KCJBIPICKFC(Dictionary<Guid, Vector3> GLMEMKONGKK, int CEFJIEIKNEL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public static class AKOKCLEOPGF
{
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	private struct ICLHAHKPMNA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public bool DNDAIPCGHLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public GPECMKAJNMD JKPNPOAFODC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public GPECMKAJNMD JHMDPGOLGGK;
	}

	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private static ICLHAHKPMNA EELDKBGLJMH;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static CancellationToken JEHCHCJLNHB
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x6909F30", Offset = "0x6908930", VA = "0x186909F30")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	internal static GPECMKAJNMD JKPNPOAFODC
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x690A210", Offset = "0x6908C10", VA = "0x18690A210")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x690A1A0", Offset = "0x6908BA0", VA = "0x18690A1A0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x690A0A0", Offset = "0x6908AA0", VA = "0x18690A0A0")]
	[MHFEIEAPENL(ABEEEPGJOJM.Room, CMFCLNIIIKO.None)]
	private static void HKLKPMFNMFN(GPECMKAJNMD FOJAPHKAAEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x6909F50", Offset = "0x6908950", VA = "0x186909F50")]
	public static void GLMNPCAHJLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x6909EE0", Offset = "0x69088E0", VA = "0x186909EE0")]
	private static GPECMKAJNMD DOBIKKHEKDL(GPECMKAJNMD HJCMBDGAKNE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public static class DAIKMIAPAGE
{
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	public enum IMGLHAPCJFF
	{
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		ICreationContextObject,
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		Guid
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x295D550", Offset = "0x295BF50", VA = "0x18295D550")]
	public static void CAKNCLFHCAB<T>(T LGHIKPMCACI, IMGLHAPCJFF ADDOHDGDFOD) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x295D4E0", Offset = "0x295BEE0", VA = "0x18295D4E0")]
	public static void CAKNCLFHCAB<T>(T LGHIKPMCACI) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x295D970", Offset = "0x295C370", VA = "0x18295D970")]
	public static void GHIHKDMLMKD<T>(T LGHIKPMCACI) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x295D430", Offset = "0x295BE30", VA = "0x18295D430")]
	public static T AMGKFNFCLFC<T>(IMGLHAPCJFF ADDOHDGDFOD) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x295D820", Offset = "0x295C220", VA = "0x18295D820")]
	public static bool GBFLHMLGFGE<T>(IMGLHAPCJFF ADDOHDGDFOD, T? IAMGFGODMHL, [Out][NotNullWhen(true)][MaybeNullWhen(false)] T LPFKJEIMHCG) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x295D6B0", Offset = "0x295C0B0", VA = "0x18295D6B0")]
	public static bool FMLOPDGHIFD<T>(IMGLHAPCJFF ADDOHDGDFOD) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x295D3D0", Offset = "0x295BDD0", VA = "0x18295D3D0")]
	public static T AMGKFNFCLFC<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x295D760", Offset = "0x295C160", VA = "0x18295D760")]
	public static bool GBFLHMLGFGE<T>(T IAMGFGODMHL, [Out] T LPFKJEIMHCG) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x295D3D0", Offset = "0x295BDD0", VA = "0x18295D3D0")]
	public static bool FMLOPDGHIFD<T>() where T : class
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
internal static class BGALLBLBBFA
{
	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x690A2B0", Offset = "0x6908CB0", VA = "0x18690A2B0")]
	public static void MJINKGBPHDI(IEnumerable HIBNJBICPAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x28B8AA0", Offset = "0x28B74A0", VA = "0x1828B8AA0")]
	public static void MJINKGBPHDI<T>(T[] MHMBNFEOIBK) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x28B8C80", Offset = "0x28B7680", VA = "0x1828B8C80")]
	public static void MJINKGBPHDI<T>(T BLJILELIBPK) where T : notnull, Enum
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
