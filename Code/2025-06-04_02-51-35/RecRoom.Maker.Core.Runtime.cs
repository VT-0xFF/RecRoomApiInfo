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
using RecRoom.DataLayer.Registration;
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
		[Cpp2IlInjected.Address(RVA = "0xA530A0", Offset = "0xA518A0", VA = "0x180A530A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7FFE1A0", Offset = "0x7FFC9A0", VA = "0x187FFE1A0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA536D0", Offset = "0xA51ED0", VA = "0x180A536D0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA53710", Offset = "0xA51F10", VA = "0x180A53710")]
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
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7FFE8E0", Offset = "0x7FFD0E0", VA = "0x187FFE8E0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2731690", Offset = "0x272FE90", VA = "0x182731690")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum JPAJCKBNNJE
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	NameAZ,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	NameZA,
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	InkCostAsc,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	InkCostDesc,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	Oldest,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Newest
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface AMNCADIBGBF<TData, TReturn>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TReturn PPJKEOLEDLA(TData HPLLAPMNIJF);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface DFDHJOBOFLN<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ClearHoverTarget(ENNALFFELEI GKFNNILCDJN);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool SetHoverTarget(TData OLBBKGLINIK, Collider DGNFPOHAKDB, ENNALFFELEI GKFNNILCDJN, [Optional] ELCBLENENFJ? CMALCIALEEL);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool TryGetHoverTarget([Out] TData OLBBKGLINIK);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool TryGetHoverCollider([Out] Collider DGNFPOHAKDB);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface JEGADPHHMDK<TData> : OIJLNIPIKFB, HDKBHCPJCPN<TData>, PLBMFHDLJJK<TData>, HEFIHHHADPG<TData>, OAHFJCMKADH, NJGGDDFCGLG<TData>, GNHKKEKAHMG, OBEIPJHMDEM
{
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface NJGGDDFCGLG<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool Raycast(Vector3 CCEAAKFKCFC, Vector3 LONBCENHPHO, float IOEOMGELKJC, [Out] T IJPBOPJKPBM, [Out] Vector3 EFHECLBCPIJ, [Out] Collider DGNFPOHAKDB);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int SpherecastPick(Vector3 CCEAAKFKCFC, Vector3 LONBCENHPHO, float GJLBIEBFDJG, float IOEOMGELKJC, T[] DJPNGEAMIOK, [Out] Vector3 BCINKLDKOGP, [Out] Collider FAOMLFAAJOC);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int SpherePick(Vector3 CCEAAKFKCFC, float GJLBIEBFDJG, Vector3 LIMGHDGGFBB, T[] DJPNGEAMIOK);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool TryGetObjectFromColliderInCurrentScope(Collider MJEGAAMKNMM, [Out] T OOPKLJHFOGK);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface OIJLNIPIKFB
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Bounds OHJDEDAAJHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	Transform NEDPHCDCOPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	Bounds DPMFINMJMFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Transform NLDKHKCMMJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	Vector3 KABKILNELOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool OAALGAEAFBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void UpdateLocalSelectionBounds();

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void SetSelectionBoundsDirty(bool FGOFHIPGMOD = true, int NGGHJHMCBKK = 0);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void ShouldHideSelectionBoundsPreview(bool PCFBCKEHEEC, object KAJENDFCCBJ);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface OBEIPJHMDEM
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	KECNPIDOCPH HLJLJENOEFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface LEJNGHFGACH
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool AMEOKDOMELJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool CMIENOCEKLF
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool LKKBGIACPOA
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Dictionary<Guid, Guid> TryGetPreviousCloneMapping();

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void TrySetPreviousCloneMapping(Dictionary<Guid, Guid> AJBFLOHKDNN);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface HEFIHHHADPG<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool ECANPLDEHHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	int ALMDEAEENAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<TData> MDFPBKAGBCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IsSelected(TData NAGJHHJDFPB);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IsSelectable(TData NAGJHHJDFPB);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface HDKBHCPJCPN<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void RenderHoverHighlight(T HPLLAPMNIJF, [Optional] ELCBLENENFJ? FIPGMBEGOHI, bool IHNECMHKHOA = true);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RenderHoverHighlight(int FMGALNGIOGC, IEnumerable<T> JOIHPEIKCGH, bool IHNECMHKHOA = true);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RenderHoverHighlight(int FMGALNGIOGC, IEnumerable<T> JOIHPEIKCGH, ELCBLENENFJ FIPGMBEGOHI, bool IHNECMHKHOA = true);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface GNHKKEKAHMG
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnSelectionPickedUp();

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnSelectionReleased();
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface OAHFJCMKADH
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool MKAIFPHLIEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool OHACPLBPMJO
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	bool BCPIKEILIFH
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	bool BGIBBFDICOD
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct LKGIKMCJDIG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public bool EBKIEKCNGJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public float? AFIJALFFFFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public float? HFJMGDBHOEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public float? BHOBCOHICDN;
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct FODNHGGPDPG<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public IEnumerable<TData> KJGDADNAFJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public LKGIKMCJDIG ICEBONNPFEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public bool BLLNLICKMHB;

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x4BC1060", Offset = "0x4BBF860", VA = "0x184BC1060")]
	public FODNHGGPDPG(IEnumerable<TData> OOMIFLDLFHC, bool LEFKEHABHNO, float? KNPIDEMAEHP, float? LGACFNJFHND, float? GKFPMLANEIL, bool BLLNLICKMHB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface KOJKMKOBPLD<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BFIONFFGJIC([In] FODNHGGPDPG<TData> JALDLFHONHH);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class EPBFMKHBINI<TData> : KDDAGGNLBDO<KOJKMKOBPLD<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly FODNHGGPDPG<TData> JALDLFHONHH;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x4757430", Offset = "0x4755C30", VA = "0x184757430")]
	public EPBFMKHBINI(IEnumerable<TData> OOMIFLDLFHC, bool LEFKEHABHNO, float? KNPIDEMAEHP, float? LGACFNJFHND, float? GKFPMLANEIL, bool BLLNLICKMHB, KOJKMKOBPLD<TData> HCJKOGOOPMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x4757370", Offset = "0x4755B70", VA = "0x184757370", Slot = "4")]
	public override bool BFIONFFGJIC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct AKHEGHJABME<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public IEnumerable<TData> KJGDADNAFJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public string PJEGNFPPICA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public bool HGOOOKDOCEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public bool BLLNLICKMHB;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x4E2CF00", Offset = "0x4E2B700", VA = "0x184E2CF00")]
	public AKHEGHJABME(IEnumerable<TData> OOMIFLDLFHC, string FLCIMENMGDL, bool MKPFBFGHOEC, bool BLLNLICKMHB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface AMFMENMPCPP<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BFIONFFGJIC([In] AKHEGHJABME<TData> JALDLFHONHH);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class LHJOLHOGCGL<TData> : KDDAGGNLBDO<AMFMENMPCPP<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly AKHEGHJABME<TData> JALDLFHONHH;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x52FDAC0", Offset = "0x52FC2C0", VA = "0x1852FDAC0")]
	public LHJOLHOGCGL(IEnumerable<TData> OOMIFLDLFHC, string FLCIMENMGDL, bool MKPFBFGHOEC, bool BLLNLICKMHB, AMFMENMPCPP<TData> HCJKOGOOPMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x4757370", Offset = "0x4755B70", VA = "0x184757370", Slot = "4")]
	public override bool BFIONFFGJIC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public abstract class KDDAGGNLBDO<TReceiver> : ANCCMMPMHKL<TReceiver, bool> where TReceiver : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x46F1D30", Offset = "0x46F0530", VA = "0x1846F1D30")]
	public KDDAGGNLBDO(TReceiver HCJKOGOOPMP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public abstract class ADMHBELILGG<TReceiver, TFromTask> : ANCCMMPMHKL<TReceiver, Task<TFromTask>>
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x46F1D30", Offset = "0x46F0530", VA = "0x1846F1D30")]
	public ADMHBELILGG(TReceiver HCJKOGOOPMP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public abstract class ANCCMMPMHKL<TReceiver, TFromExecute> where TReceiver : notnull where TFromExecute : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	protected TReceiver HCJKOGOOPMP;

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x4E3AC30", Offset = "0x4E39430", VA = "0x184E3AC30")]
	public ANCCMMPMHKL(TReceiver HCJKOGOOPMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TFromExecute BFIONFFGJIC();
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public abstract class ODKDGJBGOLC<TReceiver, TResult> : ANCCMMPMHKL<TReceiver, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x46F1D30", Offset = "0x46F0530", VA = "0x1846F1D30")]
	public ODKDGJBGOLC(TReceiver HCJKOGOOPMP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct FPMDLOOOLKC<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public TGroup NBCPGNDPAHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public TData EJNBELKCKFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public IEnumerable<TData> KJGDADNAFJL;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x22B06D0", Offset = "0x22AEED0", VA = "0x1822B06D0")]
	public FPMDLOOOLKC(TGroup FJEDFFPMNNH, TData NJAOBFANKMJ, IEnumerable<TData> OOMIFLDLFHC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public struct KMPFIIHDHPK<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public TGroup NBCPGNDPAHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public IEnumerable<TData> KJGDADNAFJL;

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0xB4C820", Offset = "0xB4B020", VA = "0x180B4C820")]
	public KMPFIIHDHPK(TGroup FJEDFFPMNNH, IEnumerable<TData> OOMIFLDLFHC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct OEJGPJKFNOD<TGroup> where TGroup : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public TGroup NBCPGNDPAHO;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0xDB8C40", Offset = "0xDB7440", VA = "0x180DB8C40")]
	public OEJGPJKFNOD(TGroup FJEDFFPMNNH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct LNMOMLEHFAC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public IEnumerable<Guid> KJGDADNAFJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public Guid HCMKBHMLMGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly bool IBBJJFMONGG;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7FFD8B0", Offset = "0x7FFC0B0", VA = "0x187FFD8B0")]
	public LNMOMLEHFAC(IEnumerable<Guid> OOMIFLDLFHC, Guid ABGEAPPONAC, bool BLLNLICKMHB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public struct EOILFBIKHNG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public Guid HCMKBHMLMGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly bool IBBJJFMONGG;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x26A4D90", Offset = "0x26A3590", VA = "0x1826A4D90")]
	public EOILFBIKHNG(Guid ABGEAPPONAC, bool BLLNLICKMHB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface KEADJPLEFLI<TGroup, TData>
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MAKGJFAHFIH NGBAJFBNNMN(FPMDLOOOLKC<TGroup, TData> BNOPIECELMF);

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "1")]
	MAKGJFAHFIH FEOLCBGOBKN(FPMDLOOOLKC<TGroup, TData> BNOPIECELMF);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "2")]
	MAKGJFAHFIH POKEDADNFCB(KMPFIIHDHPK<TGroup, TData> BNOPIECELMF);

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "3")]
	MAKGJFAHFIH BCAEFEGBDLO(OEJGPJKFNOD<TGroup> BNOPIECELMF);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface NAAFLHKNHDL
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<MAKGJFAHFIH> NGBAJFBNNMN(LNMOMLEHFAC BNOPIECELMF);

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<MAKGJFAHFIH> FEOLCBGOBKN(EOILFBIKHNG BNOPIECELMF);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class KKCCHBPMMBK<TGroup, TData> : ODKDGJBGOLC<KEADJPLEFLI<TGroup, TData>, MAKGJFAHFIH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly KMPFIIHDHPK<TGroup, TData> BNOPIECELMF;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x51B9470", Offset = "0x51B7C70", VA = "0x1851B9470")]
	public KKCCHBPMMBK(TGroup FJEDFFPMNNH, IEnumerable<TData> OOMIFLDLFHC, KEADJPLEFLI<TGroup, TData> HCJKOGOOPMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x51B93A0", Offset = "0x51B7BA0", VA = "0x1851B93A0", Slot = "4")]
	public override MAKGJFAHFIH BFIONFFGJIC()
	{
		return default(MAKGJFAHFIH);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class LNAKLBLOAAL<TGroup, TData> : ODKDGJBGOLC<KEADJPLEFLI<TGroup, TData>, MAKGJFAHFIH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly FPMDLOOOLKC<TGroup, TData> BNOPIECELMF;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x4C82D20", Offset = "0x4C81520", VA = "0x184C82D20")]
	public LNAKLBLOAAL(TGroup FJEDFFPMNNH, TData PFBIAGIMICB, IEnumerable<TData> OOMIFLDLFHC, KEADJPLEFLI<TGroup, TData> HCJKOGOOPMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x5328670", Offset = "0x5326E70", VA = "0x185328670", Slot = "4")]
	public override MAKGJFAHFIH BFIONFFGJIC()
	{
		return default(MAKGJFAHFIH);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class DMKFBFDKNFP<TGroup, TData> : ODKDGJBGOLC<KEADJPLEFLI<TGroup, TData>, MAKGJFAHFIH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly OEJGPJKFNOD<TGroup> BNOPIECELMF;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x61647F0", Offset = "0x6162FF0", VA = "0x1861647F0")]
	public DMKFBFDKNFP(TGroup FJEDFFPMNNH, KEADJPLEFLI<TGroup, TData> HCJKOGOOPMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6D5B710", Offset = "0x6D59F10", VA = "0x186D5B710", Slot = "4")]
	public override MAKGJFAHFIH BFIONFFGJIC()
	{
		return default(MAKGJFAHFIH);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class GEDIIHOAAEB<TGroup, TData> : ODKDGJBGOLC<KEADJPLEFLI<TGroup, TData>, MAKGJFAHFIH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly FPMDLOOOLKC<TGroup, TData> BNOPIECELMF;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x4C82D20", Offset = "0x4C81520", VA = "0x184C82D20")]
	public GEDIIHOAAEB(TGroup FJEDFFPMNNH, TData NJAOBFANKMJ, IEnumerable<TData> OOMIFLDLFHC, KEADJPLEFLI<TGroup, TData> HCJKOGOOPMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x4C82C40", Offset = "0x4C81440", VA = "0x184C82C40", Slot = "4")]
	public override MAKGJFAHFIH BFIONFFGJIC()
	{
		return default(MAKGJFAHFIH);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class BBEMKBNBNMM : ADMHBELILGG<NAAFLHKNHDL, MAKGJFAHFIH>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private struct NCKJHGKDEMG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public AsyncTaskMethodBuilder<MAKGJFAHFIH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public BBEMKBNBNMM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private TaskAwaiter<MAKGJFAHFIH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x7FFDA40", Offset = "0x7FFC240", VA = "0x187FFDA40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x7FFDCD0", Offset = "0x7FFC4D0", VA = "0x187FFDCD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private LNMOMLEHFAC BNOPIECELMF;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7FFCAD0", Offset = "0x7FFB2D0", VA = "0x187FFCAD0")]
	public BBEMKBNBNMM(IEnumerable<Guid> ENKMNPJAKCF, Guid ABGEAPPONAC, bool BLLNLICKMHB, NAAFLHKNHDL HCJKOGOOPMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7FFC9E0", Offset = "0x7FFB1E0", VA = "0x187FFC9E0", Slot = "4")]
	[AsyncStateMachine(typeof(NCKJHGKDEMG))]
	public override Task<MAKGJFAHFIH> BFIONFFGJIC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class IMFFLACPLNG : ADMHBELILGG<NAAFLHKNHDL, MAKGJFAHFIH>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private struct HHEAOHAKEHC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public AsyncTaskMethodBuilder<MAKGJFAHFIH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public IMFFLACPLNG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private TaskAwaiter<MAKGJFAHFIH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x7FFD0F0", Offset = "0x7FFB8F0", VA = "0x187FFD0F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x7FFD390", Offset = "0x7FFBB90", VA = "0x187FFD390", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private readonly EOILFBIKHNG BNOPIECELMF;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7FFD500", Offset = "0x7FFBD00", VA = "0x187FFD500")]
	public IMFFLACPLNG(Guid ABGEAPPONAC, bool BLLNLICKMHB, NAAFLHKNHDL HCJKOGOOPMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7FFD410", Offset = "0x7FFBC10", VA = "0x187FFD410", Slot = "4")]
	[AsyncStateMachine(typeof(HHEAOHAKEHC))]
	public override Task<MAKGJFAHFIH> BFIONFFGJIC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public readonly struct ABAKBIIEKAI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public readonly MKMPOGKGDAC MBNFADPAPKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public readonly bool IBBJJFMONGG;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7FFC8F0", Offset = "0x7FFB0F0", VA = "0x187FFC8F0")]
	public ABAKBIIEKAI(MKMPOGKGDAC PGCBGNGMIAI, bool BLLNLICKMHB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface EEIFAEMAOHB<TSpawnType> where TSpawnType : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> BFIONFFGJIC(ABAKBIIEKAI JAPDNCNIHFL);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class OGJAFNHONEM<TSpawnType> : ADMHBELILGG<EEIFAEMAOHB<TSpawnType>, TSpawnType> where TSpawnType : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct LNPPMFKMOOP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public AsyncTaskMethodBuilder<TSpawnType> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public OGJAFNHONEM<TSpawnType> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private TaskAwaiter<TSpawnType> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x53389B0", Offset = "0x53371B0", VA = "0x1853389B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x4BB0940", Offset = "0x4BAF140", VA = "0x184BB0940", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly ABAKBIIEKAI JAPDNCNIHFL;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x57317C0", Offset = "0x572FFC0", VA = "0x1857317C0")]
	public OGJAFNHONEM(MKMPOGKGDAC PGCBGNGMIAI, bool BLLNLICKMHB, EEIFAEMAOHB<TSpawnType> HCJKOGOOPMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x57315A0", Offset = "0x572FDA0", VA = "0x1857315A0", Slot = "4")]
	[AsyncStateMachine(typeof(OGJAFNHONEM<>.LNPPMFKMOOP))]
	public override Task<TSpawnType> BFIONFFGJIC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public readonly struct MKMPOGKGDAC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly bool ALLEKLBGPMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly Vector3 EAOKBEELIFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly Vector3 EOALAOOGNLB;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7FFD920", Offset = "0x7FFC120", VA = "0x187FFD920")]
	public MKMPOGKGDAC(Transform EKKJBOCLPHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7FFDA10", Offset = "0x7FFC210", VA = "0x187FFDA10")]
	public MKMPOGKGDAC(Vector3 IILAMILCBNH, Vector3 KKEEFCOJJFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7FFD8F0", Offset = "0x7FFC0F0", VA = "0x187FFD8F0")]
	public static MKMPOGKGDAC FGIKHGILDDC()
	{
		return default(MKMPOGKGDAC);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7FFD990", Offset = "0x7FFC190", VA = "0x187FFD990")]
	private MKMPOGKGDAC(bool BIJGGPENAKI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct PHGPDFBJLAM<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public TNode EBIABJPPKKE;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x58A8DB0", Offset = "0x58A75B0", VA = "0x1858A8DB0")]
	public PHGPDFBJLAM(TNode EBIABJPPKKE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public struct KHOJAHJICPC<TNode, TReparentOperations> where TNode : notnull where TReparentOperations : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public TNode ENDFHLNJMGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public TReparentOperations OMENOKPMLGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public LEHFDKGLMOD AGBDGOGMNHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public readonly bool IBBJJFMONGG;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x51B3AD0", Offset = "0x51B22D0", VA = "0x1851B3AD0")]
	public KHOJAHJICPC(TNode ENDFHLNJMGM, TReparentOperations OMENOKPMLGP, LEHFDKGLMOD AGBDGOGMNHE, bool BLLNLICKMHB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface DDNLBDMKACH<TNode, TReparentOperations>
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KFGGGIBIPIK([In] PHGPDFBJLAM<TNode> JDPCPIFIBJD);

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NKDBMLBPFPD([In] KHOJAHJICPC<TNode, TReparentOperations> ECMFEILDACO);

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool MCHCDMEGBPE();
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class OJPIJHGOEHJ<TNode, TReparentOperations> : KDDAGGNLBDO<DDNLBDMKACH<TNode, TReparentOperations>>
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x46F1D30", Offset = "0x46F0530", VA = "0x1846F1D30")]
	public OJPIJHGOEHJ(DDNLBDMKACH<TNode, TReparentOperations> HCJKOGOOPMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x50B70F0", Offset = "0x50B58F0", VA = "0x1850B70F0", Slot = "4")]
	public override bool BFIONFFGJIC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class FAPPNPEGBND<TNode, TReparentOperations> : KDDAGGNLBDO<DDNLBDMKACH<TNode, TReparentOperations>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly KHOJAHJICPC<TNode, TReparentOperations> ECMFEILDACO;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x4B97550", Offset = "0x4B95D50", VA = "0x184B97550")]
	public FAPPNPEGBND(TNode ENDFHLNJMGM, TReparentOperations OMENOKPMLGP, LEHFDKGLMOD AGBDGOGMNHE, DDNLBDMKACH<TNode, TReparentOperations> HCJKOGOOPMP, bool BLLNLICKMHB = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x4B97490", Offset = "0x4B95C90", VA = "0x184B97490", Slot = "4")]
	public override bool BFIONFFGJIC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public class DFBHEBHCIDG<TNode, TReparentOperations> : KDDAGGNLBDO<DDNLBDMKACH<TNode, TReparentOperations>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly PHGPDFBJLAM<TNode> JDPCPIFIBJD;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6CF8900", Offset = "0x6CF7100", VA = "0x186CF8900")]
	public DFBHEBHCIDG(TNode HCJLMGIBJBM, DDNLBDMKACH<TNode, TReparentOperations> HCJKOGOOPMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x4757370", Offset = "0x4755B70", VA = "0x184757370", Slot = "4")]
	public override bool BFIONFFGJIC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public struct JHOMNPOLLAH<TSpawnInfo> where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public TSpawnInfo MEJBIDOAGEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public Vector3 KKEEFCOJJFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public Quaternion FENAGHBAFHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public float DKMKOJPHLDD;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x50B71A0", Offset = "0x50B59A0", VA = "0x1850B71A0")]
	public JHOMNPOLLAH(TSpawnInfo MEJBIDOAGEM, Vector3 KKEEFCOJJFM, Quaternion FENAGHBAFHI, float DKMKOJPHLDD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public interface GHJEBJFANPB<TSpawnType, TSpawnInfo>
{
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> JADEEBBIMEA([In] JHOMNPOLLAH<TSpawnInfo> IEBANBGOADI, CancellationToken GMEAHOBHMAD);
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public class ECNHNKABGHH<TSpawnType, TSpawnInfo> : ADMHBELILGG<GHJEBJFANPB<TSpawnType, TSpawnInfo>, TSpawnType> where TSpawnType : notnull where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly JHOMNPOLLAH<TSpawnInfo> JALDLFHONHH;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x469C1F0", Offset = "0x469A9F0", VA = "0x18469C1F0")]
	public ECNHNKABGHH(TSpawnInfo PMANCOMHDOB, Vector3 KKEEFCOJJFM, Quaternion FENAGHBAFHI, float DKMKOJPHLDD, GHJEBJFANPB<TSpawnType, TSpawnInfo> HCJKOGOOPMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x469BFF0", Offset = "0x469A7F0", VA = "0x18469BFF0", Slot = "4")]
	public override Task<TSpawnType> BFIONFFGJIC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public readonly struct KFIBGBCHEEO<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public readonly IEnumerable<TData> KJGDADNAFJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public readonly bool IBBJJFMONGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly bool AFKGKCIAPCK;

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x51A8400", Offset = "0x51A6C00", VA = "0x1851A8400")]
	public KFIBGBCHEEO(IEnumerable<TData> OOMIFLDLFHC, bool BLLNLICKMHB = false, bool CABCEPMHDGP = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface PICLIABDFKG<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<MAKGJFAHFIH> DFKLFPFLPIO([In] KFIBGBCHEEO<TData> AGKEDMGOKIE, CancellationToken GMEAHOBHMAD);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class NCMPOCLNFKJ<TData> : ADMHBELILGG<PICLIABDFKG<TData>, MAKGJFAHFIH> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private readonly KFIBGBCHEEO<TData> GOAMIANEIMD;

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x55A8900", Offset = "0x55A7100", VA = "0x1855A8900")]
	public NCMPOCLNFKJ(IEnumerable<TData> OOMIFLDLFHC, bool BLLNLICKMHB, PICLIABDFKG<TData> HCJKOGOOPMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x469BFF0", Offset = "0x469A7F0", VA = "0x18469BFF0", Slot = "4")]
	public override Task<MAKGJFAHFIH> BFIONFFGJIC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public struct MOCMGLLKOBL<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly T OLBBKGLINIK;

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x55522F0", Offset = "0x5550AF0", VA = "0x1855522F0")]
	public MOCMGLLKOBL(T OBIHFMDPIHO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface JEKMBJPPEMG<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KFGGGIBIPIK([In] MOCMGLLKOBL<T> CMPFMJPBNNE);

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NKDBMLBPFPD();
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface CAJCPGANBPG<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BFIONFFGJIC([In] CFPFGJMBPEN<T> GCMIBHJENFM);
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public struct CFPFGJMBPEN<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly T OLBBKGLINIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly bool EENFGNOAGFH;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x669AAC0", Offset = "0x66992C0", VA = "0x18669AAC0")]
	public CFPFGJMBPEN(T OBIHFMDPIHO, bool BJGNPKCAJKJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class KMOAJFOBHMH<T> : KDDAGGNLBDO<JEKMBJPPEMG<T>> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x46F1D30", Offset = "0x46F0530", VA = "0x1846F1D30")]
	public KMOAJFOBHMH(JEKMBJPPEMG<T> HCJKOGOOPMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x51C16C0", Offset = "0x51BFEC0", VA = "0x1851C16C0", Slot = "4")]
	public override bool BFIONFFGJIC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class BDIBJPEHBFI<T> : KDDAGGNLBDO<JEKMBJPPEMG<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly MOCMGLLKOBL<T> CMPFMJPBNNE;

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6164870", Offset = "0x6163070", VA = "0x186164870")]
	public BDIBJPEHBFI(T OLBBKGLINIK, JEKMBJPPEMG<T> HCJKOGOOPMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x4757370", Offset = "0x4755B70", VA = "0x184757370", Slot = "4")]
	public override bool BFIONFFGJIC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public class CEGNODACPOM<T> : KDDAGGNLBDO<CAJCPGANBPG<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly CFPFGJMBPEN<T> GCMIBHJENFM;

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6695DC0", Offset = "0x66945C0", VA = "0x186695DC0")]
	public CEGNODACPOM(T OLBBKGLINIK, bool BJGNPKCAJKJ, CAJCPGANBPG<T> HCJKOGOOPMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x4757370", Offset = "0x4755B70", VA = "0x184757370", Slot = "4")]
	public override bool BFIONFFGJIC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public struct ELBGKIHJHHD<TData> where TData : notnull, GIHKAKJDMDH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public IEnumerable<TData> KJGDADNAFJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public bool ILNOMKEPCAB;

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x473BAF0", Offset = "0x473A2F0", VA = "0x18473BAF0")]
	public ELBGKIHJHHD(IEnumerable<TData> FJCBKCMBLPL, bool AEEKKLGDFJP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public struct ILGHGPDDFDO<TData> where TData : notnull, GIHKAKJDMDH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public List<TData> KJGDADNAFJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public List<bool> HPGPBLKCHHH;

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x4E8B130", Offset = "0x4E89930", VA = "0x184E8B130")]
	public ILGHGPDDFDO(List<TData> FJCBKCMBLPL, List<bool> GJFCLGLFNBN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public interface GIHKAKJDMDH
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	bool OHFCMCOOGGA
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface BJPBFDMGKKE<TData> where TData : GIHKAKJDMDH
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BFIONFFGJIC([In] ELBGKIHJHHD<TData> DHKGPMGGNCK);

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BFIONFFGJIC([In] ILGHGPDDFDO<TData> DHKGPMGGNCK);
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public interface IIPPDEPGHAI<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BGPAOMHJNKM(T OLBBKGLINIK);
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class HHDHBAIDPMA<TData> : KDDAGGNLBDO<BJPBFDMGKKE<TData>> where TData : notnull, GIHKAKJDMDH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private readonly ELBGKIHJHHD<TData> DHKGPMGGNCK;

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x4D04A40", Offset = "0x4D03240", VA = "0x184D04A40")]
	public HHDHBAIDPMA(List<TData> OOMIFLDLFHC, bool ILNOMKEPCAB, BJPBFDMGKKE<TData> HCJKOGOOPMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x4757370", Offset = "0x4755B70", VA = "0x184757370", Slot = "4")]
	public override bool BFIONFFGJIC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public class KAPAJKGGPMG<TData> : KDDAGGNLBDO<BJPBFDMGKKE<TData>> where TData : notnull, GIHKAKJDMDH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly ILGHGPDDFDO<TData> DHKGPMGGNCK;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x5188AF0", Offset = "0x51872F0", VA = "0x185188AF0")]
	public KAPAJKGGPMG(List<TData> OOMIFLDLFHC, List<bool> HPGPBLKCHHH, BJPBFDMGKKE<TData> HCJKOGOOPMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x4D31300", Offset = "0x4D2FB00", VA = "0x184D31300", Slot = "4")]
	public override bool BFIONFFGJIC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public interface HPMCNLEKCEC<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<MAKGJFAHFIH> BFIONFFGJIC(AJFLMCANNBA<TData> JMJINDFPNDJ);
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public class EIPICAFGPGB<TData> : ADMHBELILGG<HPMCNLEKCEC<TData>, MAKGJFAHFIH> where TData : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private struct KMNHCAOMFEM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public AsyncTaskMethodBuilder<MAKGJFAHFIH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public EIPICAFGPGB<TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private TaskAwaiter<MAKGJFAHFIH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x51C1370", Offset = "0x51BFB70", VA = "0x1851C1370", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x51C1650", Offset = "0x51BFE50", VA = "0x1851C1650", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly AJFLMCANNBA<TData> BKIMHENHDNA;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x46F2460", Offset = "0x46F0C60", VA = "0x1846F2460")]
	public EIPICAFGPGB(TData DLLHAKNGANH, IReadOnlyList<TData> MLFFNDKDKCL, bool BLLNLICKMHB, HPMCNLEKCEC<TData> HCJKOGOOPMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x46F2360", Offset = "0x46F0B60", VA = "0x1846F2360", Slot = "4")]
	[AsyncStateMachine(typeof(EIPICAFGPGB<>.KMNHCAOMFEM))]
	public override Task<MAKGJFAHFIH> BFIONFFGJIC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public struct AJFLMCANNBA<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public TData LJADEKDLEBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public IReadOnlyList<TData> GFGFAJEPMCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public bool IBBJJFMONGG;

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x2DA5050", Offset = "0x2DA3850", VA = "0x182DA5050")]
	public AJFLMCANNBA(TData DLLHAKNGANH, IReadOnlyList<TData> MLFFNDKDKCL, bool BLLNLICKMHB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public interface MDNJMMIGPCB<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BFIONFFGJIC([In] HGPJLMBELLM<TData> GPIEIABDLHP);
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public interface CHFPEIFJFNE<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BFIONFFGJIC([In] JGBOBLDIOMK<TData> GPIEIABDLHP);
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public interface EHDKMPCFCAK<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LIJMGDGMNEJ([In] LPCODEMBGMC<TData> GPIEIABDLHP);

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NKDBMLBPFPD();
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public class KNKPGLICJKJ<TData> : KDDAGGNLBDO<MDNJMMIGPCB<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly HGPJLMBELLM<TData> GPIEIABDLHP;

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x51C1EF0", Offset = "0x51C06F0", VA = "0x1851C1EF0")]
	public KNKPGLICJKJ(IEnumerable<TData> OOMIFLDLFHC, OCHABKGPDJF BIKIHAKPCIG, MGEEHPEJAKN IPKNLMFNGIO, float BJBPNGPOJFB, string? FLCIMENMGDL, bool AABKONLLBPF, bool BLLNLICKMHB, MDNJMMIGPCB<TData> HCJKOGOOPMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x4757370", Offset = "0x4755B70", VA = "0x184757370", Slot = "4")]
	public override bool BFIONFFGJIC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class EINOIFLHJKD<TData> : KDDAGGNLBDO<CHFPEIFJFNE<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly JGBOBLDIOMK<TData> GPIEIABDLHP;

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x46F1E60", Offset = "0x46F0660", VA = "0x1846F1E60")]
	public EINOIFLHJKD(TData[] OOMIFLDLFHC, OCHABKGPDJF[] BIKIHAKPCIG, MGEEHPEJAKN[] IPKNLMFNGIO, float[] BJBPNGPOJFB, CHFPEIFJFNE<TData> HCJKOGOOPMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x46F1DA0", Offset = "0x46F05A0", VA = "0x1846F1DA0", Slot = "4")]
	public override bool BFIONFFGJIC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class JODJFJIMBFA<TData> : KDDAGGNLBDO<EHDKMPCFCAK<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x46F1D30", Offset = "0x46F0530", VA = "0x1846F1D30")]
	public JODJFJIMBFA(EHDKMPCFCAK<TData> HCJKOGOOPMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x50DCF00", Offset = "0x50DB700", VA = "0x1850DCF00", Slot = "4")]
	public override bool BFIONFFGJIC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class EMKAKAPBCEA<TData> : KDDAGGNLBDO<EHDKMPCFCAK<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly LPCODEMBGMC<TData> GPIEIABDLHP;

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x474CDE0", Offset = "0x474B5E0", VA = "0x18474CDE0")]
	public EMKAKAPBCEA(IEnumerable<TData> OOMIFLDLFHC, OCHABKGPDJF BIKIHAKPCIG, MGEEHPEJAKN IPKNLMFNGIO, float BJBPNGPOJFB, EHDKMPCFCAK<TData> HCJKOGOOPMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x46F1DA0", Offset = "0x46F05A0", VA = "0x1846F1DA0", Slot = "4")]
	public override bool BFIONFFGJIC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public struct HGPJLMBELLM<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public IEnumerable<TData> KJGDADNAFJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public OCHABKGPDJF NOCIFGGBANI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public MGEEHPEJAKN CCOKKNAJIML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public float DEKMHJAIAIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public string? PJEGNFPPICA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public bool? AEIDAANNOEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public bool IBBJJFMONGG;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x4D048F0", Offset = "0x4D030F0", VA = "0x184D048F0")]
	public HGPJLMBELLM(IEnumerable<TData> OOMIFLDLFHC, OCHABKGPDJF BIKIHAKPCIG, MGEEHPEJAKN IPKNLMFNGIO, float BJBPNGPOJFB, string? FLCIMENMGDL, bool? AABKONLLBPF, bool BLLNLICKMHB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public struct JGBOBLDIOMK<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public TData[] KJGDADNAFJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public OCHABKGPDJF[] NOCIFGGBANI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public MGEEHPEJAKN[] CCOKKNAJIML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public float[] BJBPNGPOJFB;

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x50B1CB0", Offset = "0x50B04B0", VA = "0x1850B1CB0")]
	public JGBOBLDIOMK(TData[] OOMIFLDLFHC, OCHABKGPDJF[] BIKIHAKPCIG, MGEEHPEJAKN[] IPKNLMFNGIO, float[] BJBPNGPOJFB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public struct LPCODEMBGMC<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public IEnumerable<TData> KJGDADNAFJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public OCHABKGPDJF NOCIFGGBANI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public MGEEHPEJAKN CCOKKNAJIML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public float BJBPNGPOJFB;

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x5359050", Offset = "0x5357850", VA = "0x185359050")]
	public LPCODEMBGMC(IEnumerable<TData> OOMIFLDLFHC, OCHABKGPDJF BIKIHAKPCIG, MGEEHPEJAKN IPKNLMFNGIO, float BJBPNGPOJFB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public interface PLBMFHDLJJK<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool POKEDADNFCB([In] NNIEOPFDJFB<TData> AGKEDMGOKIE);

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BCAEFEGBDLO([In] NNIEOPFDJFB<TData> AGKEDMGOKIE);

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PMLMEDABBEP([In] bool OAPJCBBPAMC);

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool OABMNIOJNPL([In] NNIEOPFDJFB<TData> AGKEDMGOKIE);

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NLHKHJBEIAG();

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool FEACFIPMHNB([In] TData GNCKOHMEIKK);
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class NFADGNDJJNH<TData> : KDDAGGNLBDO<PLBMFHDLJJK<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly NNIEOPFDJFB<TData> AGKEDMGOKIE;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x55B6BE0", Offset = "0x55B53E0", VA = "0x1855B6BE0")]
	public NFADGNDJJNH(List<TData> DBAICDFECAB, PLBMFHDLJJK<TData> HCJKOGOOPMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x4757370", Offset = "0x4755B70", VA = "0x184757370", Slot = "4")]
	public override bool BFIONFFGJIC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public class MLNLOOAFOAA<TData> : KDDAGGNLBDO<PLBMFHDLJJK<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x46F1D30", Offset = "0x46F0530", VA = "0x1846F1D30")]
	public MLNLOOAFOAA(PLBMFHDLJJK<TData> HCJKOGOOPMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x554DBF0", Offset = "0x554C3F0", VA = "0x18554DBF0", Slot = "4")]
	public override bool BFIONFFGJIC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class PHJFJCIDCOM<TData> : KDDAGGNLBDO<PLBMFHDLJJK<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly bool BLLNLICKMHB;

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x58A8E80", Offset = "0x58A7680", VA = "0x1858A8E80")]
	public PHJFJCIDCOM(bool BLLNLICKMHB, PLBMFHDLJJK<TData> HCJKOGOOPMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x58A8E20", Offset = "0x58A7620", VA = "0x1858A8E20", Slot = "4")]
	public override bool BFIONFFGJIC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public class HOLOBCLGPDK<TData> : KDDAGGNLBDO<PLBMFHDLJJK<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly NNIEOPFDJFB<TData> AGKEDMGOKIE;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x4D31470", Offset = "0x4D2FC70", VA = "0x184D31470")]
	public HOLOBCLGPDK(List<TData> DBAICDFECAB, bool BLLNLICKMHB, PLBMFHDLJJK<TData> HCJKOGOOPMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x4D31300", Offset = "0x4D2FB00", VA = "0x184D31300", Slot = "4")]
	public override bool BFIONFFGJIC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class GNEFOLEKLLL<TData> : KDDAGGNLBDO<PLBMFHDLJJK<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly TData GNCKOHMEIKK;

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x4CAA340", Offset = "0x4CA8B40", VA = "0x184CAA340")]
	public GNEFOLEKLLL(TData GNCKOHMEIKK, PLBMFHDLJJK<TData> HCJKOGOOPMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x4CAA1C0", Offset = "0x4CA89C0", VA = "0x184CAA1C0", Slot = "4")]
	public override bool BFIONFFGJIC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class PCGBILGIBIM<TData> : KDDAGGNLBDO<PLBMFHDLJJK<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly NNIEOPFDJFB<TData> AGKEDMGOKIE;

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x5811F10", Offset = "0x5810710", VA = "0x185811F10")]
	public PCGBILGIBIM(IEnumerable<TData> DBAICDFECAB, PLBMFHDLJJK<TData> HCJKOGOOPMP, bool BLLNLICKMHB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x5811E50", Offset = "0x5810650", VA = "0x185811E50", Slot = "4")]
	public override bool BFIONFFGJIC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public struct NNIEOPFDJFB<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public IEnumerable<TData> KJGDADNAFJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public bool BLLNLICKMHB;

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x55E4B10", Offset = "0x55E3310", VA = "0x1855E4B10")]
	public NNIEOPFDJFB(IEnumerable<TData> FJCBKCMBLPL, bool NJHFLLMBKCK = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public interface PDJGKFBNEKH
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<MAKGJFAHFIH> BFIONFFGJIC(MBHADCGBGKB HLMIJNINLEN);
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public class BCLCHLLFBJC : ADMHBELILGG<PDJGKFBNEKH, MAKGJFAHFIH>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private struct PMHKEOLFBOK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public AsyncTaskMethodBuilder<MAKGJFAHFIH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public BCLCHLLFBJC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private TaskAwaiter<MAKGJFAHFIH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x7FFE600", Offset = "0x7FFCE00", VA = "0x187FFE600", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x7FFE870", Offset = "0x7FFD070", VA = "0x187FFE870", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private readonly MBHADCGBGKB FNKMLAIGIBB;

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x7FFCC80", Offset = "0x7FFB480", VA = "0x187FFCC80")]
	public BCLCHLLFBJC(bool BLLNLICKMHB, PDJGKFBNEKH HCJKOGOOPMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x7FFCB90", Offset = "0x7FFB390", VA = "0x187FFCB90", Slot = "4")]
	[AsyncStateMachine(typeof(PMHKEOLFBOK))]
	public override Task<MAKGJFAHFIH> BFIONFFGJIC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public struct MBHADCGBGKB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public bool IBBJJFMONGG;

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x2AA99A0", Offset = "0x2AA81A0", VA = "0x182AA99A0")]
	public MBHADCGBGKB(bool BLLNLICKMHB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public readonly struct IELNLNIOFCO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public readonly bool EPDDDIIIDOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public readonly bool GEGFFJOKPEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public readonly bool DKMKOJPHLDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public readonly bool BLLNLICKMHB;

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x5F43640", Offset = "0x5F41E40", VA = "0x185F43640")]
	public IELNLNIOFCO(bool EPDDDIIIDOH, bool GEGFFJOKPEE, bool DKMKOJPHLDD, bool BLLNLICKMHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x7FFD400", Offset = "0x7FFBC00", VA = "0x187FFD400")]
	public IELNLNIOFCO(bool GEGFFJOKPEE, bool BLLNLICKMHB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public interface HBLKJIOODLC
{
	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FOIDGHHICGK(IELNLNIOFCO MOEDDGFJJKF);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NPJADDJOGPD(IELNLNIOFCO MOEDDGFJJKF);
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public class JCDEKCHPMLJ : KDDAGGNLBDO<HBLKJIOODLC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly IELNLNIOFCO MOEDDGFJJKF;

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x7FFD5D0", Offset = "0x7FFBDD0", VA = "0x187FFD5D0")]
	public JCDEKCHPMLJ(bool KCODNJGBFEK, bool GEGFFJOKPEE, bool DKMKOJPHLDD, bool BLLNLICKMHB, HBLKJIOODLC HCJKOGOOPMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x7FFD580", Offset = "0x7FFBD80", VA = "0x187FFD580", Slot = "4")]
	public override bool BFIONFFGJIC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public class BBDMIAOFPON : KDDAGGNLBDO<HBLKJIOODLC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly IELNLNIOFCO MOEDDGFJJKF;

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x7FFC960", Offset = "0x7FFB160", VA = "0x187FFC960")]
	public BBDMIAOFPON(bool GEGFFJOKPEE, bool BLLNLICKMHB, HBLKJIOODLC HCJKOGOOPMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x7FFC910", Offset = "0x7FFB110", VA = "0x187FFC910", Slot = "4")]
	public override bool BFIONFFGJIC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public interface JGOOFAGDCGL
{
	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BFIONFFGJIC([In] NMKEOGIEPJP KBJMFENPBCO);
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public class PCOJHODBPLB : KDDAGGNLBDO<JGOOFAGDCGL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly NMKEOGIEPJP KBJMFENPBCO;

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x7FFE3E0", Offset = "0x7FFCBE0", VA = "0x187FFE3E0")]
	public PCOJHODBPLB(Guid[] KBCAODMNMPE, Vector3[] OEDPAJNKFEN, Quaternion[] LBAFIMIIDDP, float[] FAGNEENCDHO, Dictionary<Guid, Vector3> HEDCHEFMFHH, JGOOFAGDCGL HCJKOGOOPMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x7FFE330", Offset = "0x7FFCB30", VA = "0x187FFE330", Slot = "4")]
	public override bool BFIONFFGJIC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public interface JHBNIIJEAIC<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KFGGGIBIPIK([In] JDIJKJOJKKH<TData> JDPCPIFIBJD);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool LIJMGDGMNEJ([In] EGEKINGLNIJ DLHDICMHILG);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool LIJMGDGMNEJ([In] PIHGJJICKOH DLHDICMHILG);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool NKDBMLBPFPD();
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class EHPHFFNOJKM<TData> : KDDAGGNLBDO<JHBNIIJEAIC<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x46F1D30", Offset = "0x46F0530", VA = "0x1846F1D30")]
	public EHPHFFNOJKM(JHBNIIJEAIC<TData> HCJKOGOOPMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x46F1CE0", Offset = "0x46F04E0", VA = "0x1846F1CE0", Slot = "4")]
	public override bool BFIONFFGJIC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class IHHEJFMDJGJ<TData> : KDDAGGNLBDO<JHBNIIJEAIC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly EGEKINGLNIJ PCFDPIKIKJE;

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x4E7A2B0", Offset = "0x4E78AB0", VA = "0x184E7A2B0")]
	public IHHEJFMDJGJ(Vector3 PGCPEEKMKOD, bool GALFLDOIEDP, JHBNIIJEAIC<TData> HCJKOGOOPMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x4E7A250", Offset = "0x4E78A50", VA = "0x184E7A250", Slot = "4")]
	public override bool BFIONFFGJIC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public class GAOJGPEJIOG<TData> : KDDAGGNLBDO<JHBNIIJEAIC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly PIHGJJICKOH PCFDPIKIKJE;

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x4C76E50", Offset = "0x4C75650", VA = "0x184C76E50")]
	public GAOJGPEJIOG(Guid JNKAGDGFPMI, int PNJCJGEIDHG, Vector3 KKEEFCOJJFM, Quaternion FENAGHBAFHI, float ANIHENNGJAL, bool GALFLDOIEDP, JHBNIIJEAIC<TData> HCJKOGOOPMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x4C76DF0", Offset = "0x4C755F0", VA = "0x184C76DF0", Slot = "4")]
	public override bool BFIONFFGJIC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public class MLOLOPOCNKF<TData> : KDDAGGNLBDO<JHBNIIJEAIC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly JDIJKJOJKKH<TData> PCFDPIKIKJE;

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x554DCF0", Offset = "0x554C4F0", VA = "0x18554DCF0")]
	public MLOLOPOCNKF(TData OLBBKGLINIK, bool BLLNLICKMHB, JHBNIIJEAIC<TData> HCJKOGOOPMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x4757370", Offset = "0x4755B70", VA = "0x184757370", Slot = "4")]
	public override bool BFIONFFGJIC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public struct EGEKINGLNIJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public readonly Vector3 PGCPEEKMKOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public readonly bool GALFLDOIEDP;

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x7FFCCE0", Offset = "0x7FFB4E0", VA = "0x187FFCCE0")]
	public EGEKINGLNIJ(Vector3 PGCPEEKMKOD, bool GALFLDOIEDP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public struct PIHGJJICKOH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public readonly Guid JNKAGDGFPMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public readonly int PNJCJGEIDHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public readonly Vector3 KKEEFCOJJFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public readonly Quaternion FENAGHBAFHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public readonly float ANIHENNGJAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public readonly bool GALFLDOIEDP;

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x7FFE5C0", Offset = "0x7FFCDC0", VA = "0x187FFE5C0")]
	public PIHGJJICKOH(Guid JNKAGDGFPMI, int PNJCJGEIDHG, Vector3 KKEEFCOJJFM, Quaternion FENAGHBAFHI, float ANIHENNGJAL, bool GALFLDOIEDP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public struct JDIJKJOJKKH<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public readonly TData OLBBKGLINIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public readonly bool BLLNLICKMHB;

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x50ABC40", Offset = "0x50AA440", VA = "0x1850ABC40")]
	public JDIJKJOJKKH(TData OLBBKGLINIK, bool BLLNLICKMHB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public interface DKHGNGCCJPC<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BFIONFFGJIC([In] GCCICNECKPF<TData> DCODAAPIFOH);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool BFIONFFGJIC([In] OJMCBEDCLJF<TData> DCODAAPIFOH);
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public interface LGCJFBKEOKO<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KFGGGIBIPIK([In] DLDMCCPHBHD<TData> LOPFAEHCIHH);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool LIJMGDGMNEJ([In] LNNNPMFCJPM DLHDICMHILG);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool NKDBMLBPFPD();
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public class JBDNDPPLKIG<TData> : KDDAGGNLBDO<DKHGNGCCJPC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly GCCICNECKPF<TData> DCODAAPIFOH;

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x5076840", Offset = "0x5075040", VA = "0x185076840")]
	public JBDNDPPLKIG(IEnumerable<TData> OOMIFLDLFHC, Vector3 NNHNLEJOCDG, bool BLLNLICKMHB, DKHGNGCCJPC<TData> HCJKOGOOPMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x4757370", Offset = "0x4755B70", VA = "0x184757370", Slot = "4")]
	public override bool BFIONFFGJIC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public class JHNNBPKFNDA<TData> : KDDAGGNLBDO<LGCJFBKEOKO<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x46F1D30", Offset = "0x46F0530", VA = "0x1846F1D30")]
	public JHNNBPKFNDA(LGCJFBKEOKO<TData> HCJKOGOOPMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x50B70F0", Offset = "0x50B58F0", VA = "0x1850B70F0", Slot = "4")]
	public override bool BFIONFFGJIC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public class DHMCNBCJIPJ<TData> : KDDAGGNLBDO<LGCJFBKEOKO<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly DLDMCCPHBHD<TData> DCODAAPIFOH;

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x6D07120", Offset = "0x6D05920", VA = "0x186D07120")]
	public DHMCNBCJIPJ(IEnumerable<TData> OOMIFLDLFHC, bool BLLNLICKMHB, LGCJFBKEOKO<TData> HCJKOGOOPMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x4757370", Offset = "0x4755B70", VA = "0x184757370", Slot = "4")]
	public override bool BFIONFFGJIC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public class ADIIMCFIPOM<TData> : KDDAGGNLBDO<DKHGNGCCJPC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly OJMCBEDCLJF<TData> DCODAAPIFOH;

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x4C62EF0", Offset = "0x4C616F0", VA = "0x184C62EF0")]
	public ADIIMCFIPOM(IEnumerable<TData> OOMIFLDLFHC, Vector3 BEGBHCJFDBC, NIHLGIJOHAF GIAIBPBANGC, bool BLLNLICKMHB, DKHGNGCCJPC<TData> HCJKOGOOPMP, Space DEPKPAIFNKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x4B97490", Offset = "0x4B95C90", VA = "0x184B97490", Slot = "4")]
	public override bool BFIONFFGJIC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public class IIFOBOCIIMF<TData> : KDDAGGNLBDO<LGCJFBKEOKO<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly LNNNPMFCJPM DCODAAPIFOH;

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x4E7A4A0", Offset = "0x4E78CA0", VA = "0x184E7A4A0")]
	public IIFOBOCIIMF(Vector3 NNHNLEJOCDG, LGCJFBKEOKO<TData> HCJKOGOOPMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x4E7A250", Offset = "0x4E78A50", VA = "0x184E7A250", Slot = "4")]
	public override bool BFIONFFGJIC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public struct GCCICNECKPF<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public readonly IEnumerable<TData> OOMIFLDLFHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public readonly Vector3 NNHNLEJOCDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public readonly bool BLLNLICKMHB;

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x4C7B830", Offset = "0x4C7A030", VA = "0x184C7B830")]
	public GCCICNECKPF(IEnumerable<TData> OOMIFLDLFHC, Vector3 NNHNLEJOCDG, bool BLLNLICKMHB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public struct DLDMCCPHBHD<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public readonly IEnumerable<TData> OOMIFLDLFHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public readonly bool BLLNLICKMHB;

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x6D567A0", Offset = "0x6D54FA0", VA = "0x186D567A0")]
	public DLDMCCPHBHD(IEnumerable<TData> OOMIFLDLFHC, bool BLLNLICKMHB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public struct OJMCBEDCLJF<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public readonly IEnumerable<TData> OOMIFLDLFHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public readonly Vector3 BEGBHCJFDBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	public readonly NIHLGIJOHAF GIAIBPBANGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	public readonly bool BLLNLICKMHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public readonly Space DEPKPAIFNKE;

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x5741BB0", Offset = "0x57403B0", VA = "0x185741BB0")]
	public OJMCBEDCLJF(IEnumerable<TData> OOMIFLDLFHC, Vector3 BEGBHCJFDBC, NIHLGIJOHAF GIAIBPBANGC, bool BLLNLICKMHB, Space DEPKPAIFNKE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public struct LNNNPMFCJPM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public readonly Vector3 NNHNLEJOCDG;

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x1268020", Offset = "0x1266820", VA = "0x181268020")]
	public LNNNPMFCJPM(Vector3 NNHNLEJOCDG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public enum NIHLGIJOHAF
{
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	XYZ,
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	X_only,
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	Y_only,
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	Z_only
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public interface GBAMKJOOKFC
{
	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BFIONFFGJIC([In] DPELAGBGGEL HDKDNLHCPKM);
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public class OKNLIGMMODO : KDDAGGNLBDO<GBAMKJOOKFC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private readonly DPELAGBGGEL HDKDNLHCPKM;

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x7FFE2D0", Offset = "0x7FFCAD0", VA = "0x187FFE2D0")]
	public OKNLIGMMODO(bool BLLNLICKMHB, GBAMKJOOKFC HCJKOGOOPMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x7FFE220", Offset = "0x7FFCA20", VA = "0x187FFE220", Slot = "4")]
	public override bool BFIONFFGJIC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public readonly struct DPELAGBGGEL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public readonly bool BLLNLICKMHB;

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x2AA99A0", Offset = "0x2AA81A0", VA = "0x182AA99A0")]
	public DPELAGBGGEL(bool BLLNLICKMHB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public interface ILPMKAKOJBG<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BFIONFFGJIC([In] IEHLHFEBPAK<TData> MDJGJBHNDNC);

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool BFIONFFGJIC([In] HOHAHPECNJE<TData> MDJGJBHNDNC);
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public interface JFABJAFILDF<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KFGGGIBIPIK([In] ICFDBNFGOFP<TData> JDPCPIFIBJD);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool LIJMGDGMNEJ([In] DECPCOBFIAP DLHDICMHILG);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool NKDBMLBPFPD();
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public class MIHDGINKCBN<TData> : KDDAGGNLBDO<ILPMKAKOJBG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private readonly IEHLHFEBPAK<TData> MDJGJBHNDNC;

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x5544240", Offset = "0x5542A40", VA = "0x185544240")]
	public MIHDGINKCBN(IEnumerable<TData> OOMIFLDLFHC, Quaternion NNHNLEJOCDG, Vector3? PIHCGGHKCDP, bool PLBKCOOONLM, bool BLLNLICKMHB, ILPMKAKOJBG<TData> HCJKOGOOPMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x4757370", Offset = "0x4755B70", VA = "0x184757370", Slot = "4")]
	public override bool BFIONFFGJIC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public class OHBHBFHCFHA<TData> : KDDAGGNLBDO<JFABJAFILDF<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x46F1D30", Offset = "0x46F0530", VA = "0x1846F1D30")]
	public OHBHBFHCFHA(JFABJAFILDF<TData> HCJKOGOOPMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x50B70F0", Offset = "0x50B58F0", VA = "0x1850B70F0", Slot = "4")]
	public override bool BFIONFFGJIC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public class JIDGIAKOPIA<TData> : KDDAGGNLBDO<JFABJAFILDF<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private readonly ICFDBNFGOFP<TData> MDJGJBHNDNC;

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x50B7280", Offset = "0x50B5A80", VA = "0x1850B7280")]
	public JIDGIAKOPIA(IEnumerable<TData> OOMIFLDLFHC, bool BLLNLICKMHB, JFABJAFILDF<TData> HCJKOGOOPMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x4757370", Offset = "0x4755B70", VA = "0x184757370", Slot = "4")]
	public override bool BFIONFFGJIC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public class LONFCFGLNDC<TData> : KDDAGGNLBDO<ILPMKAKOJBG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private readonly HOHAHPECNJE<TData> MDJGJBHNDNC;

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x5354A00", Offset = "0x5353200", VA = "0x185354A00")]
	public LONFCFGLNDC(IEnumerable<TData> OOMIFLDLFHC, Quaternion MLOJGNMFDMK, NIHLGIJOHAF PNIKGFPDAEB, Vector3? PIHCGGHKCDP, bool PLBKCOOONLM, bool BLLNLICKMHB, Space DEPKPAIFNKE, ILPMKAKOJBG<TData> HCJKOGOOPMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x4B97490", Offset = "0x4B95C90", VA = "0x184B97490", Slot = "4")]
	public override bool BFIONFFGJIC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public class MBJGAMFNCCH<TData> : KDDAGGNLBDO<JFABJAFILDF<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly DECPCOBFIAP MDJGJBHNDNC;

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x5526A70", Offset = "0x5525270", VA = "0x185526A70")]
	public MBJGAMFNCCH(Quaternion NNHNLEJOCDG, Vector3? PIHCGGHKCDP, bool PLBKCOOONLM, JFABJAFILDF<TData> HCJKOGOOPMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x4E7A250", Offset = "0x4E78A50", VA = "0x184E7A250", Slot = "4")]
	public override bool BFIONFFGJIC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public struct IEHLHFEBPAK<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public readonly IEnumerable<TData> OOMIFLDLFHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public readonly Quaternion NNHNLEJOCDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public readonly Vector3? PIHCGGHKCDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public readonly bool PLBKCOOONLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public readonly bool BLLNLICKMHB;

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x4E6F3C0", Offset = "0x4E6DBC0", VA = "0x184E6F3C0")]
	public IEHLHFEBPAK(IEnumerable<TData> OOMIFLDLFHC, Quaternion NNHNLEJOCDG, Vector3? PIHCGGHKCDP, bool PLBKCOOONLM, bool BLLNLICKMHB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public struct ICFDBNFGOFP<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public readonly IEnumerable<TData> OOMIFLDLFHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public readonly bool BLLNLICKMHB;

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x4DDF390", Offset = "0x4DDDB90", VA = "0x184DDF390")]
	public ICFDBNFGOFP(IEnumerable<TData> OOMIFLDLFHC, bool BLLNLICKMHB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public struct HOHAHPECNJE<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public readonly IEnumerable<TData> OOMIFLDLFHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public readonly Quaternion MLOJGNMFDMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public readonly NIHLGIJOHAF PNIKGFPDAEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public readonly Vector3? PIHCGGHKCDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public readonly bool PLBKCOOONLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public readonly bool BLLNLICKMHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public readonly Space DEPKPAIFNKE;

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x4D2FC40", Offset = "0x4D2E440", VA = "0x184D2FC40")]
	public HOHAHPECNJE(IEnumerable<TData> OOMIFLDLFHC, Quaternion MLOJGNMFDMK, NIHLGIJOHAF PNIKGFPDAEB, Vector3? PIHCGGHKCDP, bool PLBKCOOONLM, bool BLLNLICKMHB, Space DEPKPAIFNKE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public struct DECPCOBFIAP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public readonly Quaternion NNHNLEJOCDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public readonly Vector3? PIHCGGHKCDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public readonly bool PLBKCOOONLM;

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x5ED9C60", Offset = "0x5ED8460", VA = "0x185ED9C60")]
	public DECPCOBFIAP(Quaternion NNHNLEJOCDG, Vector3? PIHCGGHKCDP, bool PLBKCOOONLM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public interface OCGENIGNMDG<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KFGGGIBIPIK([In] NKEKGKEJKEC<TData> JDPCPIFIBJD);

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool LIJMGDGMNEJ([In] JNHKBBDALDF DLHDICMHILG);

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool LIJMGDGMNEJ([In] JDBEIOHCMHM DLHDICMHILG);

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool LIJMGDGMNEJ([In] HFGDECHBDPP DLHDICMHILG);

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool NKDBMLBPFPD();
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public class GJDLNGJIBDM<TData> : KDDAGGNLBDO<OCGENIGNMDG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private readonly HFGDECHBDPP HBKILAPNFAL;

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x4C945C0", Offset = "0x4C92DC0", VA = "0x184C945C0")]
	public GJDLNGJIBDM(Vector3 JGHHHGDENNJ, float KEPHKFOICBM, Vector3 PIHCGGHKCDP, bool DPANPNDNPMI, bool ABEHNMFNDNH, OCGENIGNMDG<TData> HCJKOGOOPMP, Space DEPKPAIFNKE = Space.Self)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x4C94560", Offset = "0x4C92D60", VA = "0x184C94560", Slot = "4")]
	public override bool BFIONFFGJIC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public class BFOKEPPNPKO<TData> : KDDAGGNLBDO<OCGENIGNMDG<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x46F1D30", Offset = "0x46F0530", VA = "0x1846F1D30")]
	public BFOKEPPNPKO(OCGENIGNMDG<TData> HCJKOGOOPMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x616E5E0", Offset = "0x616CDE0", VA = "0x18616E5E0", Slot = "4")]
	public override bool BFIONFFGJIC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public class GOOPPHPBJKO<TData> : KDDAGGNLBDO<OCGENIGNMDG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private readonly NKEKGKEJKEC<TData> HBKILAPNFAL;

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x4CAE390", Offset = "0x4CACB90", VA = "0x184CAE390")]
	public GOOPPHPBJKO(IEnumerable<TData> OOMIFLDLFHC, bool BLLNLICKMHB, OCGENIGNMDG<TData> HCJKOGOOPMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x4757370", Offset = "0x4755B70", VA = "0x184757370", Slot = "4")]
	public override bool BFIONFFGJIC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
public class JILGIDMOEIK<TData> : KDDAGGNLBDO<OCGENIGNMDG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private readonly JDBEIOHCMHM HBKILAPNFAL;

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x50BB540", Offset = "0x50B9D40", VA = "0x1850BB540")]
	public JILGIDMOEIK(float HFJGKHBLMDN, bool NCOCDDDKMFP, Vector3 PIHCGGHKCDP, OCGENIGNMDG<TData> HCJKOGOOPMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x50BB480", Offset = "0x50B9C80", VA = "0x1850BB480", Slot = "4")]
	public override bool BFIONFFGJIC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
public class JIPNFAIAKPO<TData> : KDDAGGNLBDO<OCGENIGNMDG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private readonly JNHKBBDALDF HBKILAPNFAL;

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x50C0E40", Offset = "0x50BF640", VA = "0x1850C0E40")]
	public JIPNFAIAKPO(float KEPHKFOICBM, Vector3 PIHCGGHKCDP, OCGENIGNMDG<TData> HCJKOGOOPMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x4E7A250", Offset = "0x4E78A50", VA = "0x184E7A250", Slot = "4")]
	public override bool BFIONFFGJIC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
public struct HFGDECHBDPP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public readonly Vector3 JGHHHGDENNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public readonly float KEPHKFOICBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public readonly Vector3 PIHCGGHKCDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public readonly bool GALFLDOIEDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public readonly Space DEPKPAIFNKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	public readonly bool ABEHNMFNDNH;

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x7FFD0B0", Offset = "0x7FFB8B0", VA = "0x187FFD0B0")]
	public HFGDECHBDPP(Vector3 JGHHHGDENNJ, float KEPHKFOICBM, Vector3 PIHCGGHKCDP, bool GALFLDOIEDP, bool OLCMKBLPBFP, Space DEPKPAIFNKE = Space.Self)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
public struct NKEKGKEJKEC<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	public readonly IEnumerable<TData> OOMIFLDLFHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	public readonly bool BLLNLICKMHB;

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x55D51B0", Offset = "0x55D39B0", VA = "0x1855D51B0")]
	public NKEKGKEJKEC(IEnumerable<TData> OOMIFLDLFHC, bool BLLNLICKMHB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public struct JDBEIOHCMHM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public readonly float HFJGKHBLMDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public readonly bool NCOCDDDKMFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public readonly Vector3 PIHCGGHKCDP;

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x7FFD660", Offset = "0x7FFBE60", VA = "0x187FFD660")]
	public JDBEIOHCMHM(float HFJGKHBLMDN, bool NCOCDDDKMFP, Vector3 PIHCGGHKCDP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
public struct JNHKBBDALDF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public readonly float KEPHKFOICBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public readonly Vector3 PIHCGGHKCDP;

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x5EAEDB0", Offset = "0x5EAD5B0", VA = "0x185EAEDB0")]
	public JNHKBBDALDF(float KEPHKFOICBM, Vector3 PIHCGGHKCDP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public struct NMKEOGIEPJP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public readonly Guid[] OOMIFLDLFHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public readonly bool JFDLNEHCLMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public readonly bool HGALIBAEFEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public readonly bool BCIEPELKJEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public readonly Vector3[] OEDPAJNKFEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public readonly Quaternion[] LBAFIMIIDDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public readonly float[] FAGNEENCDHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public readonly Dictionary<Guid, Vector3> HEDCHEFMFHH;

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x7FFDF10", Offset = "0x7FFC710", VA = "0x187FFDF10")]
	public NMKEOGIEPJP(Guid[] KBCAODMNMPE, Vector3[] OEDPAJNKFEN, Quaternion[] LBAFIMIIDDP, float[] FAGNEENCDHO, Dictionary<Guid, Vector3> HEDCHEFMFHH, bool JFDLNEHCLMA = true, bool HGALIBAEFEE = true, bool BCIEPELKJEG = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x7FFDD40", Offset = "0x7FFC540", VA = "0x187FFDD40")]
	private static void LLPKIGLEEMH(Dictionary<Guid, Vector3> HEDCHEFMFHH, int HINJLPNLHGM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public static class HAJOADLMCJA
{
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	private struct GKHBJIDKIAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public bool KDKDIKGMGML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public OIKNHNBNAFI MMOKDOMNOHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public OIKNHNBNAFI NMBPLDOOLDM;
	}

	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private static GKHBJIDKIAM HGKMBCNDMBG;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static CancellationToken HHKMJGAKFPB
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x7FFCEA0", Offset = "0x7FFB6A0", VA = "0x187FFCEA0")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	internal static OIKNHNBNAFI MMOKDOMNOHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x7FFCEC0", Offset = "0x7FFB6C0", VA = "0x187FFCEC0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x7FFCD00", Offset = "0x7FFB500", VA = "0x187FFCD00")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x7FFCD60", Offset = "0x7FFB560", VA = "0x187FFCD60")]
	[NOOFMBJKOEL.BCMLOIAHPDE]
	internal static void EJEHBAIOEFG(OIKNHNBNAFI IHELJGDICAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x7FFCF60", Offset = "0x7FFB760", VA = "0x187FFCF60")]
	public static void MMBGNLDGDEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x7FFCE50", Offset = "0x7FFB650", VA = "0x187FFCE50")]
	private static OIKNHNBNAFI GGAGNNCAOBM(OIKNHNBNAFI KJPICGPOAKA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
public static class KHFANKCLAGG
{
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	public enum DJAACDEBCOM
	{
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		ICreationContextObject,
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		Guid
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x3A910B0", Offset = "0x3A8F8B0", VA = "0x183A910B0")]
	public static void HHPGNFHDGFP<T>(T CMJLAOBGHAL, DJAACDEBCOM CEPGAJKBPDM) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x3A91040", Offset = "0x3A8F840", VA = "0x183A91040")]
	public static void HHPGNFHDGFP<T>(T CMJLAOBGHAL) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x3A90F50", Offset = "0x3A8F750", VA = "0x183A90F50")]
	public static void HHPGNFHDGFP<T, TImpl, T>() where T : class where TImpl : notnull, T where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x3A91210", Offset = "0x3A8FA10", VA = "0x183A91210")]
	public static void JIKDDJAGEHG<T>(T CMJLAOBGHAL) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x3A90BE0", Offset = "0x3A8F3E0", VA = "0x183A90BE0")]
	public static T CEJDCFFPPDB<T>(DJAACDEBCOM CEPGAJKBPDM) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x3A90C90", Offset = "0x3A8F490", VA = "0x183A90C90")]
	public static bool CLCEOBPBAJN<T>(DJAACDEBCOM CEPGAJKBPDM, T? NBJFHEGCMAC, [Out][NotNullWhen(true)][MaybeNullWhen(false)] T OJPNDJAACMN) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x3A90A70", Offset = "0x3A8F270", VA = "0x183A90A70")]
	public static bool BCILHMILEKD<T>(DJAACDEBCOM CEPGAJKBPDM, [Out][NotNullWhen(true)][MaybeNullWhen(false)] T PMNLLADBEKI) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x3A90EA0", Offset = "0x3A8F6A0", VA = "0x183A90EA0")]
	public static bool HBJHCHOLHPH<T>(DJAACDEBCOM CEPGAJKBPDM) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x3A90B80", Offset = "0x3A8F380", VA = "0x183A90B80")]
	public static T CEJDCFFPPDB<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x3A90DE0", Offset = "0x3A8F5E0", VA = "0x183A90DE0")]
	public static bool CLCEOBPBAJN<T>(T NBJFHEGCMAC, [Out] T OJPNDJAACMN) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x3A90B80", Offset = "0x3A8F380", VA = "0x183A90B80")]
	public static bool HBJHCHOLHPH<T>() where T : class
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
internal static class LENAHAENHNF
{
	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x7FFD680", Offset = "0x7FFBE80", VA = "0x187FFD680")]
	public static void OJHIIBJJIJN(IEnumerable LONPIGBPLOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x3AA3830", Offset = "0x3AA2030", VA = "0x183AA3830")]
	public static void OJHIIBJJIJN<T>(T[] LPBOBEPEKNH) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x3AA3920", Offset = "0x3AA2120", VA = "0x183AA3920")]
	public static void OJHIIBJJIJN<T>(T IJLILEGPOCK) where T : notnull, Enum
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
