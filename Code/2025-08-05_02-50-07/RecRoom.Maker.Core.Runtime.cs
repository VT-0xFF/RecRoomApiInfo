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
		[Cpp2IlInjected.Address(RVA = "0xA98EF0", Offset = "0xA982F0", VA = "0x180A98EF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x830A030", Offset = "0x8309430", VA = "0x18830A030")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA99B00", Offset = "0xA98F00", VA = "0x180A99B00")]
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
		[Cpp2IlInjected.Address(RVA = "0xA99B40", Offset = "0xA98F40", VA = "0x180A99B40")]
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
		[Cpp2IlInjected.Address(RVA = "0x830A600", Offset = "0x8309A00", VA = "0x18830A600", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x291FE80", Offset = "0x291F280", VA = "0x18291FE80")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum BOFAPCKBKGJ
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	ShowFreeInventionsInR2PaletteSearch
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum GPPDLAIIDBA
{
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	NameAZ,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	NameZA,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	InkCostAsc,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	InkCostDesc,
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	Oldest,
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	Newest
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface IPNLCJGFKPE<TData, TReturn>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TReturn PMCOGNGAOHN(TData DEJGDIIDCDN);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface FLKDOHBDFNM<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ClearHoverTarget(FGMNFDCCOAC KIGOHDAICAJ);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool SetHoverTarget(TData NJJNDJLGDNH, Collider DECOFKKPIGO, FGMNFDCCOAC KIGOHDAICAJ, [Optional] MPJPIJDIFLM? GDMDNAKCFMP);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool TryGetHoverTarget([Out] TData NJJNDJLGDNH);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool TryGetHoverCollider([Out] Collider DECOFKKPIGO);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface KNOBBHFJIEJ<TData> : DBADNAHHNKE, NPJKGCOFIMJ<TData>, KKOOMGILOPN<TData>, DILLLGMPMBM<TData>, AFKNMGOCPHF, LFCLLDCGLFA<TData>, IFJJGDHNCCC, ALDENMIHJAM
{
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface LFCLLDCGLFA<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool Raycast(Vector3 GOFLCKHIPLK, Vector3 NLDMHMFAEEN, float ICEDCEOLBDI, [Out] T NAODNPLMLGM, [Out] Vector3 LPJABJOBGNE, [Out] Collider DECOFKKPIGO);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int SpherecastPick(Vector3 GOFLCKHIPLK, Vector3 NLDMHMFAEEN, float MEHKCOCNILG, float ICEDCEOLBDI, T[] OBOHNNJIICC, [Out] Vector3 BGBFKEKLKIP, [Out] Collider FEMAJOCCBJD);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int SpherePick(Vector3 GOFLCKHIPLK, float MEHKCOCNILG, Vector3 FAIONNNCFKC, T[] OBOHNNJIICC);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool TryGetObjectFromColliderInCurrentScope(Collider NLMGKPGMOBC, [Out] T PKLHBFLNONB);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface DBADNAHHNKE
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Bounds MMBOFJFCGNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	Transform AGHNDPGDILC
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	Bounds PFHEIOOGJNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Transform BLBEKOJDADF
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	Vector3 EOLPFDJKAED
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool GJJEEIKHNEE
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
	void SetSelectionBoundsDirty(bool BNCNLFHOPAC = true, int HDAAOEBJNGA = 0);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void ShouldHideSelectionBoundsPreview(bool LIPHAGOELDN, object MONGIMOHLAO);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface ALDENMIHJAM
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	OFFOKCJIMNI MOLPEEKBEAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface ILJKJAOGNNA
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool OCENNNLBCCE
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool MPMCCONIHLM
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool FKICKIIJAMB
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
	void TrySetPreviousCloneMapping(Dictionary<Guid, Guid> EMPMPNLGJDK);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface DILLLGMPMBM<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool CIJMPCLCNLB
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	int CMPEPLEGLLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<TData> AJBMCDNNDEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IsSelected(TData GBDPBDHPLOA);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IsSelectable(TData GBDPBDHPLOA);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface NPJKGCOFIMJ<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void RenderHoverHighlight(T DEJGDIIDCDN, [Optional] MPJPIJDIFLM? ODCHPDHAEIG, bool DMCHLEGEJBC = true);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RenderHoverHighlight(int PPNAGMANAKJ, IEnumerable<T> KBFMDIBJOCA, bool DMCHLEGEJBC = true);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RenderHoverHighlight(int PPNAGMANAKJ, IEnumerable<T> KBFMDIBJOCA, MPJPIJDIFLM ODCHPDHAEIG, bool DMCHLEGEJBC = true);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface IFJJGDHNCCC
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnSelectionPickedUp();

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnSelectionReleased();
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface AFKNMGOCPHF
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool CEELCFJHIPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool FEFIHENEBMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	bool KHGHGMLCMEG
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	bool AGJNGLNGJCK
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct DPIKOHADHGK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public bool JBINPIFPNIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public float? ENCHCIHDOPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public float? HPOEOCCFCOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public float? FLEJLJJLJCL;
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct JKEJKADCBJF<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public IEnumerable<TData> JDEDIKIMPGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public DPIKOHADHGK BCGNCNLBNOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public bool MBBLAICPMDP;

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x536A5C0", Offset = "0x53699C0", VA = "0x18536A5C0")]
	public JKEJKADCBJF(IEnumerable<TData> KIBNCDDDBLI, bool LICBJLDAJEP, float? BHCOBPFFKLH, float? CLIKJBPKKKI, float? EGBGFHAIMNL, bool MBBLAICPMDP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface IOICDDKDDBK<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KMBBCCKJAHA([In] JKEJKADCBJF<TData> PHAOHJHLKGO);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class OOAKPLIDMBN<TData> : FLODBGCJFPL<IOICDDKDDBK<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly JKEJKADCBJF<TData> PHAOHJHLKGO;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x59F01F0", Offset = "0x59EF5F0", VA = "0x1859F01F0")]
	public OOAKPLIDMBN(IEnumerable<TData> KIBNCDDDBLI, bool LICBJLDAJEP, float? BHCOBPFFKLH, float? CLIKJBPKKKI, float? EGBGFHAIMNL, bool MBBLAICPMDP, IOICDDKDDBK<TData> EIMAFKHCFEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x4550430", Offset = "0x454F830", VA = "0x184550430", Slot = "4")]
	public override bool KMBBCCKJAHA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct PGJGJMNJFLI<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public IEnumerable<TData> JDEDIKIMPGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public string POEEFANCFBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public bool LCDACIMCHNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public bool MBBLAICPMDP;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5AC52C0", Offset = "0x5AC46C0", VA = "0x185AC52C0")]
	public PGJGJMNJFLI(IEnumerable<TData> KIBNCDDDBLI, string JDPAGNELAJI, bool MENPJDNIOMB, bool MBBLAICPMDP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface AMDGCCCMKPP<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KMBBCCKJAHA([In] PGJGJMNJFLI<TData> PHAOHJHLKGO);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class JIONJKEEHKD<TData> : FLODBGCJFPL<AMDGCCCMKPP<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly PGJGJMNJFLI<TData> PHAOHJHLKGO;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5360010", Offset = "0x535F410", VA = "0x185360010")]
	public JIONJKEEHKD(IEnumerable<TData> KIBNCDDDBLI, string JDPAGNELAJI, bool MENPJDNIOMB, bool MBBLAICPMDP, AMDGCCCMKPP<TData> EIMAFKHCFEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x4550430", Offset = "0x454F830", VA = "0x184550430", Slot = "4")]
	public override bool KMBBCCKJAHA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public abstract class FLODBGCJFPL<TReceiver> : FBJKGDPOAPO<TReceiver, bool> where TReceiver : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x49B64A0", Offset = "0x49B58A0", VA = "0x1849B64A0")]
	public FLODBGCJFPL(TReceiver EIMAFKHCFEM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public abstract class OFEPAMOKIBE<TReceiver, TFromTask> : FBJKGDPOAPO<TReceiver, Task<TFromTask>>
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x49B64A0", Offset = "0x49B58A0", VA = "0x1849B64A0")]
	public OFEPAMOKIBE(TReceiver EIMAFKHCFEM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public abstract class FBJKGDPOAPO<TReceiver, TFromExecute> where TReceiver : notnull where TFromExecute : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	protected TReceiver EIMAFKHCFEM;

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x4E5C280", Offset = "0x4E5B680", VA = "0x184E5C280")]
	public FBJKGDPOAPO(TReceiver EIMAFKHCFEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TFromExecute KMBBCCKJAHA();
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public abstract class FOIKHJPMOFA<TReceiver, TResult> : FBJKGDPOAPO<TReceiver, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x49B64A0", Offset = "0x49B58A0", VA = "0x1849B64A0")]
	public FOIKHJPMOFA(TReceiver EIMAFKHCFEM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public struct COMAMNNBFPJ<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public TGroup PEDJPCEGOND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public TData PDIOHIBMDLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public IEnumerable<TData> JDEDIKIMPGE;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x1DC77F0", Offset = "0x1DC6BF0", VA = "0x181DC77F0")]
	public COMAMNNBFPJ(TGroup NGHAJLKOBEJ, TData BJNDGMDBIKH, IEnumerable<TData> KIBNCDDDBLI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct OBDIMMGEMKG<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public TGroup PEDJPCEGOND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public IEnumerable<TData> JDEDIKIMPGE;

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0xBFDA60", Offset = "0xBFCE60", VA = "0x180BFDA60")]
	public OBDIMMGEMKG(TGroup NGHAJLKOBEJ, IEnumerable<TData> KIBNCDDDBLI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct BNPHOEKODNO<TGroup> where TGroup : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public TGroup PEDJPCEGOND;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0xE62750", Offset = "0xE61B50", VA = "0x180E62750")]
	public BNPHOEKODNO(TGroup NGHAJLKOBEJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public struct KAKFLLAJICI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public IEnumerable<Guid> JDEDIKIMPGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public Guid MEOAHPNKCJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly bool LHHPFILEBMK;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x8309800", Offset = "0x8308C00", VA = "0x188309800")]
	public KAKFLLAJICI(IEnumerable<Guid> KIBNCDDDBLI, Guid EBBBEBCAOME, bool MBBLAICPMDP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public struct DKFOHJGDGNF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public Guid MEOAHPNKCJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public readonly bool LHHPFILEBMK;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x28DD330", Offset = "0x28DC730", VA = "0x1828DD330")]
	public DKFOHJGDGNF(Guid EBBBEBCAOME, bool MBBLAICPMDP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface BKCLANDHDHN<TGroup, TData>
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IDJHPOJKNOB PNCMJPDENOP(COMAMNNBFPJ<TGroup, TData> CCNJAGBFPEI);

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDJHPOJKNOB PBJAPOMEDIL(COMAMNNBFPJ<TGroup, TData> CCNJAGBFPEI);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IDJHPOJKNOB MGEGBINKJMO(OBDIMMGEMKG<TGroup, TData> CCNJAGBFPEI);

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IDJHPOJKNOB IGENIOGMAKP(BNPHOEKODNO<TGroup> CCNJAGBFPEI);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public interface MMIBKELDJLH
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IDJHPOJKNOB> PNCMJPDENOP(KAKFLLAJICI CCNJAGBFPEI);

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<IDJHPOJKNOB> PBJAPOMEDIL(DKFOHJGDGNF CCNJAGBFPEI);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class LLHMLNHMHNP<TGroup, TData> : FOIKHJPMOFA<BKCLANDHDHN<TGroup, TData>, IDJHPOJKNOB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly OBDIMMGEMKG<TGroup, TData> CCNJAGBFPEI;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x551F090", Offset = "0x551E490", VA = "0x18551F090")]
	public LLHMLNHMHNP(TGroup NGHAJLKOBEJ, IEnumerable<TData> KIBNCDDDBLI, BKCLANDHDHN<TGroup, TData> EIMAFKHCFEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x551EFD0", Offset = "0x551E3D0", VA = "0x18551EFD0", Slot = "4")]
	public override IDJHPOJKNOB KMBBCCKJAHA()
	{
		return default(IDJHPOJKNOB);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class BDKJJEPNOEF<TGroup, TData> : FOIKHJPMOFA<BKCLANDHDHN<TGroup, TData>, IDJHPOJKNOB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly COMAMNNBFPJ<TGroup, TData> CCNJAGBFPEI;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x49D3170", Offset = "0x49D2570", VA = "0x1849D3170")]
	public BDKJJEPNOEF(TGroup NGHAJLKOBEJ, TData NDPBLKBCHGD, IEnumerable<TData> KIBNCDDDBLI, BKCLANDHDHN<TGroup, TData> EIMAFKHCFEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x646E3E0", Offset = "0x646D7E0", VA = "0x18646E3E0", Slot = "4")]
	public override IDJHPOJKNOB KMBBCCKJAHA()
	{
		return default(IDJHPOJKNOB);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class EHEKGLHOHOF<TGroup, TData> : FOIKHJPMOFA<BKCLANDHDHN<TGroup, TData>, IDJHPOJKNOB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly BNPHOEKODNO<TGroup> CCNJAGBFPEI;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x49D3020", Offset = "0x49D2420", VA = "0x1849D3020")]
	public EHEKGLHOHOF(TGroup NGHAJLKOBEJ, BKCLANDHDHN<TGroup, TData> EIMAFKHCFEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x49D2F60", Offset = "0x49D2360", VA = "0x1849D2F60", Slot = "4")]
	public override IDJHPOJKNOB KMBBCCKJAHA()
	{
		return default(IDJHPOJKNOB);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class EHFADCBMPLG<TGroup, TData> : FOIKHJPMOFA<BKCLANDHDHN<TGroup, TData>, IDJHPOJKNOB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly COMAMNNBFPJ<TGroup, TData> CCNJAGBFPEI;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x49D3170", Offset = "0x49D2570", VA = "0x1849D3170")]
	public EHFADCBMPLG(TGroup NGHAJLKOBEJ, TData BJNDGMDBIKH, IEnumerable<TData> KIBNCDDDBLI, BKCLANDHDHN<TGroup, TData> EIMAFKHCFEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x49D3090", Offset = "0x49D2490", VA = "0x1849D3090", Slot = "4")]
	public override IDJHPOJKNOB KMBBCCKJAHA()
	{
		return default(IDJHPOJKNOB);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class DJKCHHNEBJO : OFEPAMOKIBE<MMIBKELDJLH, IDJHPOJKNOB>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private struct AKFKPPOAMHI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public AsyncTaskMethodBuilder<IDJHPOJKNOB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public DJKCHHNEBJO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private TaskAwaiter<IDJHPOJKNOB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x83088B0", Offset = "0x8307CB0", VA = "0x1883088B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x8308B40", Offset = "0x8307F40", VA = "0x188308B40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private KAKFLLAJICI CCNJAGBFPEI;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x83091B0", Offset = "0x83085B0", VA = "0x1883091B0")]
	public DJKCHHNEBJO(IEnumerable<Guid> HODNBLIEAGA, Guid EBBBEBCAOME, bool MBBLAICPMDP, MMIBKELDJLH EIMAFKHCFEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x83090C0", Offset = "0x83084C0", VA = "0x1883090C0", Slot = "4")]
	[AsyncStateMachine(typeof(AKFKPPOAMHI))]
	public override Task<IDJHPOJKNOB> KMBBCCKJAHA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class PFFCAFCNONI : OFEPAMOKIBE<MMIBKELDJLH, IDJHPOJKNOB>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private struct NCAGLJLDAGI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public AsyncTaskMethodBuilder<IDJHPOJKNOB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public PFFCAFCNONI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private TaskAwaiter<IDJHPOJKNOB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x8309CC0", Offset = "0x83090C0", VA = "0x188309CC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x8309F60", Offset = "0x8309360", VA = "0x188309F60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly DKFOHJGDGNF CCNJAGBFPEI;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x830A580", Offset = "0x8309980", VA = "0x18830A580")]
	public PFFCAFCNONI(Guid EBBBEBCAOME, bool MBBLAICPMDP, MMIBKELDJLH EIMAFKHCFEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x830A490", Offset = "0x8309890", VA = "0x18830A490", Slot = "4")]
	[AsyncStateMachine(typeof(NCAGLJLDAGI))]
	public override Task<IDJHPOJKNOB> KMBBCCKJAHA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public readonly struct LGCDFNKJCBN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public readonly GKHFLECMDDJ EENBHNEFEIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly bool LHHPFILEBMK;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x8309CA0", Offset = "0x83090A0", VA = "0x188309CA0")]
	public LGCDFNKJCBN(GKHFLECMDDJ ALIHLBKMPIO, bool MBBLAICPMDP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface CDCIFOBBCFA<TSpawnType> where TSpawnType : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> KMBBCCKJAHA(LGCDFNKJCBN DECKMEGAPKK);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class CMIHGCFCDOA<TSpawnType> : OFEPAMOKIBE<CDCIFOBBCFA<TSpawnType>, TSpawnType> where TSpawnType : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private struct HIIIEMEPBOH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public AsyncTaskMethodBuilder<TSpawnType> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public CMIHGCFCDOA<TSpawnType> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private TaskAwaiter<TSpawnType> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x4FDF190", Offset = "0x4FDE590", VA = "0x184FDF190", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x4EB2AC0", Offset = "0x4EB1EC0", VA = "0x184EB2AC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly LGCDFNKJCBN DECKMEGAPKK;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6DB1CF0", Offset = "0x6DB10F0", VA = "0x186DB1CF0")]
	public CMIHGCFCDOA(GKHFLECMDDJ ALIHLBKMPIO, bool MBBLAICPMDP, CDCIFOBBCFA<TSpawnType> EIMAFKHCFEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6DB1C00", Offset = "0x6DB1000", VA = "0x186DB1C00", Slot = "4")]
	[AsyncStateMachine(typeof(CMIHGCFCDOA<>.HIIIEMEPBOH))]
	public override Task<TSpawnType> KMBBCCKJAHA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public readonly struct GKHFLECMDDJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly bool NFOGNKAOFFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly Vector3 OCPLAMENOME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly Vector3 BKPAIEKHLGF;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x83093F0", Offset = "0x83087F0", VA = "0x1883093F0")]
	public GKHFLECMDDJ(Transform PCNBLDAFIPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x83094F0", Offset = "0x83088F0", VA = "0x1883094F0")]
	public GKHFLECMDDJ(Vector3 KIAHAFCJEPK, Vector3 LBCFHLNAPLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x83093C0", Offset = "0x83087C0", VA = "0x1883093C0")]
	public static GKHFLECMDDJ JCIOENFMGMF()
	{
		return default(GKHFLECMDDJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x8309460", Offset = "0x8308860", VA = "0x188309460")]
	private GKHFLECMDDJ(bool COJPOPLHBBI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public struct KKPEHDJPBGF<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public TNode MJOAAIDBGIH;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x545C770", Offset = "0x545BB70", VA = "0x18545C770")]
	public KKPEHDJPBGF(TNode MJOAAIDBGIH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public struct BFFJJDEBCMC<TNode, TReparentOperations> where TNode : notnull where TReparentOperations : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public TNode NDJDNBPJAKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public TReparentOperations LGDBAHPOBNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public LJLENMCBJFF GILKNFOKIDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly bool LHHPFILEBMK;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6545A90", Offset = "0x6544E90", VA = "0x186545A90")]
	public BFFJJDEBCMC(TNode NDJDNBPJAKA, TReparentOperations LGDBAHPOBNP, LJLENMCBJFF GILKNFOKIDB, bool MBBLAICPMDP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface EKCBKFNGKIL<TNode, TReparentOperations>
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DHCBLAJMNPL([In] KKPEHDJPBGF<TNode> LHPONFJJEGD);

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KCDLCKJKHCF([In] BFFJJDEBCMC<TNode, TReparentOperations> BENCAOKPFAM);

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool JIGKLICEPPC();
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class JNONNPDKCLP<TNode, TReparentOperations> : FLODBGCJFPL<EKCBKFNGKIL<TNode, TReparentOperations>>
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x49B64A0", Offset = "0x49B58A0", VA = "0x1849B64A0")]
	public JNONNPDKCLP(EKCBKFNGKIL<TNode, TReparentOperations> EIMAFKHCFEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x5379E40", Offset = "0x5379240", VA = "0x185379E40", Slot = "4")]
	public override bool KMBBCCKJAHA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public class LJHJBNIEGPB<TNode, TReparentOperations> : FLODBGCJFPL<EKCBKFNGKIL<TNode, TReparentOperations>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly BFFJJDEBCMC<TNode, TReparentOperations> BENCAOKPFAM;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5518120", Offset = "0x5517520", VA = "0x185518120")]
	public LJHJBNIEGPB(TNode NDJDNBPJAKA, TReparentOperations LGDBAHPOBNP, LJLENMCBJFF GILKNFOKIDB, EKCBKFNGKIL<TNode, TReparentOperations> EIMAFKHCFEM, bool MBBLAICPMDP = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x5518060", Offset = "0x5517460", VA = "0x185518060", Slot = "4")]
	public override bool KMBBCCKJAHA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public class HGCEKEEAGNG<TNode, TReparentOperations> : FLODBGCJFPL<EKCBKFNGKIL<TNode, TReparentOperations>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly KKPEHDJPBGF<TNode> LHPONFJJEGD;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x4FBE520", Offset = "0x4FBD920", VA = "0x184FBE520")]
	public HGCEKEEAGNG(TNode KIGAEBCGNKJ, EKCBKFNGKIL<TNode, TReparentOperations> EIMAFKHCFEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x4550430", Offset = "0x454F830", VA = "0x184550430", Slot = "4")]
	public override bool KMBBCCKJAHA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct MNBGAMBGNBG<TSpawnInfo> where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public TSpawnInfo FMOBFNEJNMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public Vector3 LBCFHLNAPLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public Quaternion EMLGDFFEJED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public float MJHAIBCGLLD;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x5799220", Offset = "0x5798620", VA = "0x185799220")]
	public MNBGAMBGNBG(TSpawnInfo FMOBFNEJNMM, Vector3 LBCFHLNAPLC, Quaternion EMLGDFFEJED, float MJHAIBCGLLD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public interface KNGMENAFILF<TSpawnType, TSpawnInfo>
{
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> OOCLNJLJOJK([In] MNBGAMBGNBG<TSpawnInfo> MPKHNFBNHJL, CancellationToken GMKBGHHNCDJ);
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class LOONJLFGDAJ<TSpawnType, TSpawnInfo> : OFEPAMOKIBE<KNGMENAFILF<TSpawnType, TSpawnInfo>, TSpawnType> where TSpawnType : notnull where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private readonly MNBGAMBGNBG<TSpawnInfo> PHAOHJHLKGO;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x5595B70", Offset = "0x5594F70", VA = "0x185595B70")]
	public LOONJLFGDAJ(TSpawnInfo CMHHKNENODO, Vector3 LBCFHLNAPLC, Quaternion EMLGDFFEJED, float MJHAIBCGLLD, KNGMENAFILF<TSpawnType, TSpawnInfo> EIMAFKHCFEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x5595A90", Offset = "0x5594E90", VA = "0x185595A90", Slot = "4")]
	public override Task<TSpawnType> KMBBCCKJAHA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public readonly struct JNDNIPEDNPE<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly IEnumerable<TData> JDEDIKIMPGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public readonly bool LHHPFILEBMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly bool PJOPEFKGDGJ;

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x53799C0", Offset = "0x5378DC0", VA = "0x1853799C0")]
	public JNDNIPEDNPE(IEnumerable<TData> KIBNCDDDBLI, bool MBBLAICPMDP = false, bool GANOCPNGHIN = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface MBDBMBKJNJD<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IDJHPOJKNOB> JAHEAFONJJF([In] JNDNIPEDNPE<TData> MCBNBIKLBEF, CancellationToken GMKBGHHNCDJ);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public class MOAMJEMJDPK<TData> : OFEPAMOKIBE<MBDBMBKJNJD<TData>, IDJHPOJKNOB> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private readonly JNDNIPEDNPE<TData> EDLGBKMPOAB;

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x57A0E90", Offset = "0x57A0290", VA = "0x1857A0E90")]
	public MOAMJEMJDPK(IEnumerable<TData> KIBNCDDDBLI, bool MBBLAICPMDP, MBDBMBKJNJD<TData> EIMAFKHCFEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x5595A90", Offset = "0x5594E90", VA = "0x185595A90", Slot = "4")]
	public override Task<IDJHPOJKNOB> KMBBCCKJAHA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public struct NCECGIFCPPN<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly T NJJNDJLGDNH;

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x510BA70", Offset = "0x510AE70", VA = "0x18510BA70")]
	public NCECGIFCPPN(T JFKJAHBBNCE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface IENPNOMANNB<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DHCBLAJMNPL([In] NCECGIFCPPN<T> CDHDDKBOBDE);

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KCDLCKJKHCF();
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface PCGNGLMPAOJ<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KMBBCCKJAHA([In] EOKCCFCLEIN<T> BDIDNOEOOHK);
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public struct EOKCCFCLEIN<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public readonly T NJJNDJLGDNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly bool HJHOHOGBAAF;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x49F85D0", Offset = "0x49F79D0", VA = "0x1849F85D0")]
	public EOKCCFCLEIN(T JFKJAHBBNCE, bool AKNIBKDEPIM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class BMGFPIMLAAC<T> : FLODBGCJFPL<IENPNOMANNB<T>> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x49B64A0", Offset = "0x49B58A0", VA = "0x1849B64A0")]
	public BMGFPIMLAAC(IENPNOMANNB<T> EIMAFKHCFEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x68E48F0", Offset = "0x68E3CF0", VA = "0x1868E48F0", Slot = "4")]
	public override bool KMBBCCKJAHA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public class NPENACJAPCM<T> : FLODBGCJFPL<IENPNOMANNB<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly NCECGIFCPPN<T> CDHDDKBOBDE;

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x584AE40", Offset = "0x584A240", VA = "0x18584AE40")]
	public NPENACJAPCM(T NJJNDJLGDNH, IENPNOMANNB<T> EIMAFKHCFEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x4550430", Offset = "0x454F830", VA = "0x184550430", Slot = "4")]
	public override bool KMBBCCKJAHA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public class EBLFOLOGMKB<T> : FLODBGCJFPL<PCGNGLMPAOJ<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private readonly EOKCCFCLEIN<T> BDIDNOEOOHK;

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x49B4C30", Offset = "0x49B4030", VA = "0x1849B4C30")]
	public EBLFOLOGMKB(T NJJNDJLGDNH, bool AKNIBKDEPIM, PCGNGLMPAOJ<T> EIMAFKHCFEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x4550430", Offset = "0x454F830", VA = "0x184550430", Slot = "4")]
	public override bool KMBBCCKJAHA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public struct ABCFDMEFJKL<TData> where TData : notnull, OIOODPDHIIP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public IEnumerable<TData> JDEDIKIMPGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public bool HIDAEHLPKEB;

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x5100F50", Offset = "0x5100350", VA = "0x185100F50")]
	public ABCFDMEFJKL(IEnumerable<TData> KLKEMKLDCDF, bool FFFBDBCOFKL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public struct FGPDGFJKANP<TData> where TData : notnull, OIOODPDHIIP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public List<TData> JDEDIKIMPGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public List<bool> HJGALHEDOOI;

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x4E8E9D0", Offset = "0x4E8DDD0", VA = "0x184E8E9D0")]
	public FGPDGFJKANP(List<TData> KLKEMKLDCDF, List<bool> KBHCAEEHCDC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface OIOODPDHIIP
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	bool JPFFJEKGMJL
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public interface ENFBMBKCHLG<TData> where TData : OIOODPDHIIP
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KMBBCCKJAHA([In] ABCFDMEFJKL<TData> BAJNNDKAFAP);

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KMBBCCKJAHA([In] FGPDGFJKANP<TData> BAJNNDKAFAP);
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public interface BFBHECIHPAA<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BFFCOOLKNKM(T NJJNDJLGDNH);
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public class DGMLBFHHLKH<TData> : FLODBGCJFPL<ENFBMBKCHLG<TData>> where TData : notnull, OIOODPDHIIP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly ABCFDMEFJKL<TData> BAJNNDKAFAP;

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x45504E0", Offset = "0x454F8E0", VA = "0x1845504E0")]
	public DGMLBFHHLKH(List<TData> KIBNCDDDBLI, bool HIDAEHLPKEB, ENFBMBKCHLG<TData> EIMAFKHCFEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x4550430", Offset = "0x454F830", VA = "0x184550430", Slot = "4")]
	public override bool KMBBCCKJAHA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public class JKFJHDDEKLF<TData> : FLODBGCJFPL<ENFBMBKCHLG<TData>> where TData : notnull, OIOODPDHIIP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly FGPDGFJKANP<TData> BAJNNDKAFAP;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x536A790", Offset = "0x5369B90", VA = "0x18536A790")]
	public JKFJHDDEKLF(List<TData> KIBNCDDDBLI, List<bool> HJGALHEDOOI, ENFBMBKCHLG<TData> EIMAFKHCFEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x536A6E0", Offset = "0x5369AE0", VA = "0x18536A6E0", Slot = "4")]
	public override bool KMBBCCKJAHA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public interface LJBOJLBNGGC<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IDJHPOJKNOB> KMBBCCKJAHA(EDOECFFGOIO<TData> JPCKBCMOGHM);
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public class KPNNABEFNEL<TData> : OFEPAMOKIBE<LJBOJLBNGGC<TData>, IDJHPOJKNOB> where TData : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private struct AOAGEPJMGOD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public AsyncTaskMethodBuilder<IDJHPOJKNOB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public KPNNABEFNEL<TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private TaskAwaiter<IDJHPOJKNOB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x52C0FB0", Offset = "0x52C03B0", VA = "0x1852C0FB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x52C1290", Offset = "0x52C0690", VA = "0x1852C1290", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly EDOECFFGOIO<TData> IOCMICEIHJB;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x5475870", Offset = "0x5474C70", VA = "0x185475870")]
	public KPNNABEFNEL(TData NCKKPKDKCNP, IReadOnlyList<TData> GJJAIKKPNHE, bool MBBLAICPMDP, LJBOJLBNGGC<TData> EIMAFKHCFEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x5475770", Offset = "0x5474B70", VA = "0x185475770", Slot = "4")]
	[AsyncStateMachine(typeof(KPNNABEFNEL<>.AOAGEPJMGOD))]
	public override Task<IDJHPOJKNOB> KMBBCCKJAHA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public struct EDOECFFGOIO<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public TData AFHLHJGOKMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public IReadOnlyList<TData> IFHEHECPMBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public bool LHHPFILEBMK;

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x3017910", Offset = "0x3016D10", VA = "0x183017910")]
	public EDOECFFGOIO(TData NCKKPKDKCNP, IReadOnlyList<TData> GJJAIKKPNHE, bool MBBLAICPMDP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public interface KIDGMALKJCN<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KMBBCCKJAHA([In] DIIFPPECJLA<TData> ODCEEEBKFLM);
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public interface MILNDBCOEEN<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KMBBCCKJAHA([In] FOKGPINKJBI<TData> ODCEEEBKFLM);
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public interface EHJKLHNODOI<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KHJBIJFALPH([In] EOLIMLFLJBI<TData> ODCEEEBKFLM);

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KCDLCKJKHCF();
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class AKIJIMPNJMM<TData> : FLODBGCJFPL<KIDGMALKJCN<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly DIIFPPECJLA<TData> ODCEEEBKFLM;

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x52BA260", Offset = "0x52B9660", VA = "0x1852BA260")]
	public AKIJIMPNJMM(IEnumerable<TData> KIBNCDDDBLI, HOPHEEHHBNP IFBOGFLAOGG, BMPAPPBHELN GMFBEMFEGJH, float ADLMLIEOCMK, string? JDPAGNELAJI, bool IDOOKGGOIFE, bool MBBLAICPMDP, KIDGMALKJCN<TData> EIMAFKHCFEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x4550430", Offset = "0x454F830", VA = "0x184550430", Slot = "4")]
	public override bool KMBBCCKJAHA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class JHLLNNFJCFH<TData> : FLODBGCJFPL<MILNDBCOEEN<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly FOKGPINKJBI<TData> ODCEEEBKFLM;

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x532A730", Offset = "0x5329B30", VA = "0x18532A730")]
	public JHLLNNFJCFH(TData[] KIBNCDDDBLI, HOPHEEHHBNP[] IFBOGFLAOGG, BMPAPPBHELN[] GMFBEMFEGJH, float[] ADLMLIEOCMK, MILNDBCOEEN<TData> EIMAFKHCFEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x50ECBF0", Offset = "0x50EBFF0", VA = "0x1850ECBF0", Slot = "4")]
	public override bool KMBBCCKJAHA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class PFFBCMAKAMP<TData> : FLODBGCJFPL<EHJKLHNODOI<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x49B64A0", Offset = "0x49B58A0", VA = "0x1849B64A0")]
	public PFFBCMAKAMP(EHJKLHNODOI<TData> EIMAFKHCFEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x5AC3BF0", Offset = "0x5AC2FF0", VA = "0x185AC3BF0", Slot = "4")]
	public override bool KMBBCCKJAHA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public class IKHIIALKECM<TData> : FLODBGCJFPL<EHJKLHNODOI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly EOLIMLFLJBI<TData> ODCEEEBKFLM;

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x50ECCA0", Offset = "0x50EC0A0", VA = "0x1850ECCA0")]
	public IKHIIALKECM(IEnumerable<TData> KIBNCDDDBLI, HOPHEEHHBNP IFBOGFLAOGG, BMPAPPBHELN GMFBEMFEGJH, float ADLMLIEOCMK, EHJKLHNODOI<TData> EIMAFKHCFEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x50ECBF0", Offset = "0x50EBFF0", VA = "0x1850ECBF0", Slot = "4")]
	public override bool KMBBCCKJAHA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public struct DIIFPPECJLA<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public IEnumerable<TData> JDEDIKIMPGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public HOPHEEHHBNP LEHEPOAPIMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public BMPAPPBHELN NOKPIKBDEMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public float MEODOKMAJIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public string? POEEFANCFBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public bool? JGEGLFBFCPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public bool LHHPFILEBMK;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x4559440", Offset = "0x4558840", VA = "0x184559440")]
	public DIIFPPECJLA(IEnumerable<TData> KIBNCDDDBLI, HOPHEEHHBNP IFBOGFLAOGG, BMPAPPBHELN GMFBEMFEGJH, float ADLMLIEOCMK, string? JDPAGNELAJI, bool? IDOOKGGOIFE, bool MBBLAICPMDP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public struct FOKGPINKJBI<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public TData[] JDEDIKIMPGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public HOPHEEHHBNP[] LEHEPOAPIMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public BMPAPPBHELN[] NOKPIKBDEMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public float[] ADLMLIEOCMK;

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x4EB12A0", Offset = "0x4EB06A0", VA = "0x184EB12A0")]
	public FOKGPINKJBI(TData[] KIBNCDDDBLI, HOPHEEHHBNP[] IFBOGFLAOGG, BMPAPPBHELN[] GMFBEMFEGJH, float[] ADLMLIEOCMK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public struct EOLIMLFLJBI<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public IEnumerable<TData> JDEDIKIMPGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public HOPHEEHHBNP LEHEPOAPIMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public BMPAPPBHELN NOKPIKBDEMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public float ADLMLIEOCMK;

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x49F8690", Offset = "0x49F7A90", VA = "0x1849F8690")]
	public EOLIMLFLJBI(IEnumerable<TData> KIBNCDDDBLI, HOPHEEHHBNP IFBOGFLAOGG, BMPAPPBHELN GMFBEMFEGJH, float ADLMLIEOCMK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public interface KKOOMGILOPN<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MGEGBINKJMO([In] GAOPKCKPGEM<TData> MCBNBIKLBEF);

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IGENIOGMAKP([In] GAOPKCKPGEM<TData> MCBNBIKLBEF);

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NHGEGOICOJN([In] bool ENHABOKJIEH);

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool FEHJGMAKOEO([In] GAOPKCKPGEM<TData> MCBNBIKLBEF);

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MNKPKGAGFKI();

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool AMPECBOEHLA([In] TData MECCKPEEGNB);
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public class CHCACAKCDNG<TData> : FLODBGCJFPL<KKOOMGILOPN<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly GAOPKCKPGEM<TData> MCBNBIKLBEF;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6D724E0", Offset = "0x6D718E0", VA = "0x186D724E0")]
	public CHCACAKCDNG(List<TData> PHCFLGCBHJB, KKOOMGILOPN<TData> EIMAFKHCFEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x4550430", Offset = "0x454F830", VA = "0x184550430", Slot = "4")]
	public override bool KMBBCCKJAHA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class KOJMCKKMHMC<TData> : FLODBGCJFPL<KKOOMGILOPN<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x49B64A0", Offset = "0x49B58A0", VA = "0x1849B64A0")]
	public KOJMCKKMHMC(KKOOMGILOPN<TData> EIMAFKHCFEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x546F4C0", Offset = "0x546E8C0", VA = "0x18546F4C0", Slot = "4")]
	public override bool KMBBCCKJAHA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public class PEPIMMNCILE<TData> : FLODBGCJFPL<KKOOMGILOPN<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly bool MBBLAICPMDP;

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x5AC0340", Offset = "0x5ABF740", VA = "0x185AC0340")]
	public PEPIMMNCILE(bool MBBLAICPMDP, KKOOMGILOPN<TData> EIMAFKHCFEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x5AC02E0", Offset = "0x5ABF6E0", VA = "0x185AC02E0", Slot = "4")]
	public override bool KMBBCCKJAHA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class OKPPLLCCBFP<TData> : FLODBGCJFPL<KKOOMGILOPN<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly GAOPKCKPGEM<TData> MCBNBIKLBEF;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x59E5720", Offset = "0x59E4B20", VA = "0x1859E5720")]
	public OKPPLLCCBFP(List<TData> PHCFLGCBHJB, bool MBBLAICPMDP, KKOOMGILOPN<TData> EIMAFKHCFEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x536A6E0", Offset = "0x5369AE0", VA = "0x18536A6E0", Slot = "4")]
	public override bool KMBBCCKJAHA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class BHMOABKGDHE<TData> : FLODBGCJFPL<KKOOMGILOPN<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly TData MECCKPEEGNB;

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6553E90", Offset = "0x6553290", VA = "0x186553E90")]
	public BHMOABKGDHE(TData MECCKPEEGNB, KKOOMGILOPN<TData> EIMAFKHCFEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x6553D20", Offset = "0x6553120", VA = "0x186553D20", Slot = "4")]
	public override bool KMBBCCKJAHA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class HDMJEGKLBEB<TData> : FLODBGCJFPL<KKOOMGILOPN<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private readonly GAOPKCKPGEM<TData> MCBNBIKLBEF;

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x4FB08C0", Offset = "0x4FAFCC0", VA = "0x184FB08C0")]
	public HDMJEGKLBEB(IEnumerable<TData> PHCFLGCBHJB, KKOOMGILOPN<TData> EIMAFKHCFEM, bool MBBLAICPMDP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x4FB0760", Offset = "0x4FAFB60", VA = "0x184FB0760", Slot = "4")]
	public override bool KMBBCCKJAHA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public struct GAOPKCKPGEM<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public IEnumerable<TData> JDEDIKIMPGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public bool MBBLAICPMDP;

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x4F3C190", Offset = "0x4F3B590", VA = "0x184F3C190")]
	public GAOPKCKPGEM(IEnumerable<TData> KLKEMKLDCDF, bool GACKCFHGBAE = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public interface KCNIOBJKBLO
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IDJHPOJKNOB> KMBBCCKJAHA(JGHFAOJMFPA CFDNDFLEGJE);
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class EAFJPKIDBFF : OFEPAMOKIBE<KCNIOBJKBLO, IDJHPOJKNOB>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[CompilerGenerated]
	private struct AAGOLIMANJE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public AsyncTaskMethodBuilder<IDJHPOJKNOB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public EAFJPKIDBFF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private TaskAwaiter<IDJHPOJKNOB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x83085D0", Offset = "0x83079D0", VA = "0x1883085D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x8308840", Offset = "0x8307C40", VA = "0x188308840", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly JGHFAOJMFPA LIMJKAAOGKJ;

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x8309360", Offset = "0x8308760", VA = "0x188309360")]
	public EAFJPKIDBFF(bool MBBLAICPMDP, KCNIOBJKBLO EIMAFKHCFEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x8309270", Offset = "0x8308670", VA = "0x188309270", Slot = "4")]
	[AsyncStateMachine(typeof(AAGOLIMANJE))]
	public override Task<IDJHPOJKNOB> KMBBCCKJAHA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public struct JGHFAOJMFPA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public bool LHHPFILEBMK;

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x2CEA490", Offset = "0x2CE9890", VA = "0x182CEA490")]
	public JGHFAOJMFPA(bool MBBLAICPMDP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public readonly struct DJEIIELLMGM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public readonly bool LJCAIGHOIJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public readonly bool GKMCNCODMIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public readonly bool MJHAIBCGLLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public readonly bool MBBLAICPMDP;

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x61917A0", Offset = "0x6190BA0", VA = "0x1861917A0")]
	public DJEIIELLMGM(bool LJCAIGHOIJP, bool GKMCNCODMIG, bool MJHAIBCGLLD, bool MBBLAICPMDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x83090B0", Offset = "0x83084B0", VA = "0x1883090B0")]
	public DJEIIELLMGM(bool GKMCNCODMIG, bool MBBLAICPMDP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public interface OHLMDDHOAEP
{
	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GMBOIOGNCLP(DJEIIELLMGM MECAEIMEPMO);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool JFPCIJAPFMO(DJEIIELLMGM MECAEIMEPMO);
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public class JCHBFBCLGLL : FLODBGCJFPL<OHLMDDHOAEP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly DJEIIELLMGM MECAEIMEPMO;

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x8309680", Offset = "0x8308A80", VA = "0x188309680")]
	public JCHBFBCLGLL(bool GANAIKEBLIG, bool GKMCNCODMIG, bool MJHAIBCGLLD, bool MBBLAICPMDP, OHLMDDHOAEP EIMAFKHCFEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x8309630", Offset = "0x8308A30", VA = "0x188309630", Slot = "4")]
	public override bool KMBBCCKJAHA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public class JNCCNDIDBDF : FLODBGCJFPL<OHLMDDHOAEP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly DJEIIELLMGM MECAEIMEPMO;

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x8309780", Offset = "0x8308B80", VA = "0x188309780")]
	public JNCCNDIDBDF(bool GKMCNCODMIG, bool MBBLAICPMDP, OHLMDDHOAEP EIMAFKHCFEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x8309730", Offset = "0x8308B30", VA = "0x188309730", Slot = "4")]
	public override bool KMBBCCKJAHA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public interface GHFFDCBPPLA
{
	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KMBBCCKJAHA([In] KLGPCNPBEFH KLFDBCAFEEJ);
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class COHMJGCENJL : FLODBGCJFPL<GHFFDCBPPLA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly KLGPCNPBEFH KLFDBCAFEEJ;

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x8308ED0", Offset = "0x83082D0", VA = "0x188308ED0")]
	public COHMJGCENJL(Guid[] HAOIOKPKIAO, Vector3[] LNGOJOBDGLC, Quaternion[] OOMDMDOCNGA, float[] HMNEOEODNDH, Dictionary<Guid, Vector3> BIFMINFBABP, GHFFDCBPPLA EIMAFKHCFEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x8308E20", Offset = "0x8308220", VA = "0x188308E20", Slot = "4")]
	public override bool KMBBCCKJAHA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public interface DDMEJHIDOBJ<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DHCBLAJMNPL([In] IPFPJDHGGNM<TData> LHPONFJJEGD);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KHJBIJFALPH([In] NNFAFONELDB MNIIEOCDCCD);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool KHJBIJFALPH([In] ALBGOINLAJH MNIIEOCDCCD);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool KCDLCKJKHCF();
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class JLAMJIBBOCF<TData> : FLODBGCJFPL<DDMEJHIDOBJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x49B64A0", Offset = "0x49B58A0", VA = "0x1849B64A0")]
	public JLAMJIBBOCF(DDMEJHIDOBJ<TData> EIMAFKHCFEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x53746F0", Offset = "0x5373AF0", VA = "0x1853746F0", Slot = "4")]
	public override bool KMBBCCKJAHA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public class IEIJNCGAEKF<TData> : FLODBGCJFPL<DDMEJHIDOBJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly NNFAFONELDB NGBKJIHJLFF;

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x50C90F0", Offset = "0x50C84F0", VA = "0x1850C90F0")]
	public IEIJNCGAEKF(Vector3 PCOBIPPCGGK, bool MCOKBEFNOPE, DDMEJHIDOBJ<TData> EIMAFKHCFEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x50C9090", Offset = "0x50C8490", VA = "0x1850C9090", Slot = "4")]
	public override bool KMBBCCKJAHA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public class BMJGHKODNLL<TData> : FLODBGCJFPL<DDMEJHIDOBJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly ALBGOINLAJH NGBKJIHJLFF;

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x68E4B80", Offset = "0x68E3F80", VA = "0x1868E4B80")]
	public BMJGHKODNLL(Guid EEGKBLLIMJE, int NOEININIMIL, Vector3 LBCFHLNAPLC, Quaternion EMLGDFFEJED, float FLMDAOGEKMO, bool MCOKBEFNOPE, DDMEJHIDOBJ<TData> EIMAFKHCFEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x68E4B20", Offset = "0x68E3F20", VA = "0x1868E4B20", Slot = "4")]
	public override bool KMBBCCKJAHA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public class JANMKHNMJAK<TData> : FLODBGCJFPL<DDMEJHIDOBJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly IPFPJDHGGNM<TData> NGBKJIHJLFF;

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x5302610", Offset = "0x5301A10", VA = "0x185302610")]
	public JANMKHNMJAK(TData NJJNDJLGDNH, bool MBBLAICPMDP, DDMEJHIDOBJ<TData> EIMAFKHCFEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x4550430", Offset = "0x454F830", VA = "0x184550430", Slot = "4")]
	public override bool KMBBCCKJAHA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public struct NNFAFONELDB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public readonly Vector3 PCOBIPPCGGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public readonly bool MCOKBEFNOPE;

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x830A010", Offset = "0x8309410", VA = "0x18830A010")]
	public NNFAFONELDB(Vector3 PCOBIPPCGGK, bool MCOKBEFNOPE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public struct ALBGOINLAJH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public readonly Guid EEGKBLLIMJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public readonly int NOEININIMIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public readonly Vector3 LBCFHLNAPLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public readonly Quaternion EMLGDFFEJED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public readonly float FLMDAOGEKMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public readonly bool MCOKBEFNOPE;

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x8308BB0", Offset = "0x8307FB0", VA = "0x188308BB0")]
	public ALBGOINLAJH(Guid EEGKBLLIMJE, int NOEININIMIL, Vector3 LBCFHLNAPLC, Quaternion EMLGDFFEJED, float FLMDAOGEKMO, bool MCOKBEFNOPE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public struct IPFPJDHGGNM<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public readonly TData NJJNDJLGDNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public readonly bool MBBLAICPMDP;

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x511A710", Offset = "0x5119B10", VA = "0x18511A710")]
	public IPFPJDHGGNM(TData NJJNDJLGDNH, bool MBBLAICPMDP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public interface MIMFAMFHCHK<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KMBBCCKJAHA([In] FOECPLFFHKD<TData> OHMCBMJBHLB);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KMBBCCKJAHA([In] EIBFLILJAIL<TData> OHMCBMJBHLB);
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public interface FNMDOFNGIAM<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DHCBLAJMNPL([In] FECNHIGAMGN<TData> DIEDPKCJBNO);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KHJBIJFALPH([In] EHDBKPLCGEA MNIIEOCDCCD);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool KCDLCKJKHCF();
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public class MACLENOGJKH<TData> : FLODBGCJFPL<MIMFAMFHCHK<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly FOECPLFFHKD<TData> OHMCBMJBHLB;

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x5767F50", Offset = "0x5767350", VA = "0x185767F50")]
	public MACLENOGJKH(IEnumerable<TData> KIBNCDDDBLI, Vector3 NOJFDNDOCKD, bool MBBLAICPMDP, MIMFAMFHCHK<TData> EIMAFKHCFEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x4550430", Offset = "0x454F830", VA = "0x184550430", Slot = "4")]
	public override bool KMBBCCKJAHA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public class BCHNBMDMNIO<TData> : FLODBGCJFPL<FNMDOFNGIAM<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x49B64A0", Offset = "0x49B58A0", VA = "0x1849B64A0")]
	public BCHNBMDMNIO(FNMDOFNGIAM<TData> EIMAFKHCFEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x5379E40", Offset = "0x5379240", VA = "0x185379E40", Slot = "4")]
	public override bool KMBBCCKJAHA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public class FDHNMJMOHKF<TData> : FLODBGCJFPL<FNMDOFNGIAM<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly FECNHIGAMGN<TData> OHMCBMJBHLB;

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x4E60B40", Offset = "0x4E5FF40", VA = "0x184E60B40")]
	public FDHNMJMOHKF(IEnumerable<TData> KIBNCDDDBLI, bool MBBLAICPMDP, FNMDOFNGIAM<TData> EIMAFKHCFEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x4550430", Offset = "0x454F830", VA = "0x184550430", Slot = "4")]
	public override bool KMBBCCKJAHA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public class PABBFPKNDOC<TData> : FLODBGCJFPL<MIMFAMFHCHK<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly EIBFLILJAIL<TData> OHMCBMJBHLB;

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x5AA3F70", Offset = "0x5AA3370", VA = "0x185AA3F70")]
	public PABBFPKNDOC(IEnumerable<TData> KIBNCDDDBLI, Vector3 IGKIPIDLFMP, FMPPFODFNAH DEEFLCHBNDE, bool MBBLAICPMDP, MIMFAMFHCHK<TData> EIMAFKHCFEM, Space FHPFNNMPPCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x5518060", Offset = "0x5517460", VA = "0x185518060", Slot = "4")]
	public override bool KMBBCCKJAHA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public class MNOODDMJADM<TData> : FLODBGCJFPL<FNMDOFNGIAM<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly EHDBKPLCGEA OHMCBMJBHLB;

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x57A0750", Offset = "0x579FB50", VA = "0x1857A0750")]
	public MNOODDMJADM(Vector3 NOJFDNDOCKD, FNMDOFNGIAM<TData> EIMAFKHCFEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x50C9090", Offset = "0x50C8490", VA = "0x1850C9090", Slot = "4")]
	public override bool KMBBCCKJAHA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public struct FOECPLFFHKD<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public readonly IEnumerable<TData> KIBNCDDDBLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public readonly Vector3 NOJFDNDOCKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public readonly bool MBBLAICPMDP;

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x4EB10C0", Offset = "0x4EB04C0", VA = "0x184EB10C0")]
	public FOECPLFFHKD(IEnumerable<TData> KIBNCDDDBLI, Vector3 NOJFDNDOCKD, bool MBBLAICPMDP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public struct FECNHIGAMGN<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public readonly IEnumerable<TData> KIBNCDDDBLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public readonly bool MBBLAICPMDP;

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x4E64820", Offset = "0x4E63C20", VA = "0x184E64820")]
	public FECNHIGAMGN(IEnumerable<TData> KIBNCDDDBLI, bool MBBLAICPMDP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public struct EIBFLILJAIL<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	public readonly IEnumerable<TData> KIBNCDDDBLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	public readonly Vector3 IGKIPIDLFMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public readonly FMPPFODFNAH DEEFLCHBNDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public readonly bool MBBLAICPMDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public readonly Space FHPFNNMPPCN;

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x49D4050", Offset = "0x49D3450", VA = "0x1849D4050")]
	public EIBFLILJAIL(IEnumerable<TData> KIBNCDDDBLI, Vector3 IGKIPIDLFMP, FMPPFODFNAH DEEFLCHBNDE, bool MBBLAICPMDP, Space FHPFNNMPPCN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public struct EHDBKPLCGEA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public readonly Vector3 NOJFDNDOCKD;

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x2CE8DC0", Offset = "0x2CE81C0", VA = "0x182CE8DC0")]
	public EHDBKPLCGEA(Vector3 NOJFDNDOCKD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public enum FMPPFODFNAH
{
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	XYZ,
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	X_only,
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	Y_only,
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	Z_only
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public interface PBIMLLHCCMI
{
	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KMBBCCKJAHA([In] LFMFGHFEOEB JAJLKLBOPPK);
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public class HOPHOKAPPGG : FLODBGCJFPL<PBIMLLHCCMI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private readonly LFMFGHFEOEB JAJLKLBOPPK;

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x83095D0", Offset = "0x83089D0", VA = "0x1883095D0")]
	public HOPHOKAPPGG(bool MBBLAICPMDP, PBIMLLHCCMI EIMAFKHCFEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x8309520", Offset = "0x8308920", VA = "0x188309520", Slot = "4")]
	public override bool KMBBCCKJAHA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public readonly struct LFMFGHFEOEB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public readonly bool MBBLAICPMDP;

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x2CEA490", Offset = "0x2CE9890", VA = "0x182CEA490")]
	public LFMFGHFEOEB(bool MBBLAICPMDP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public interface IDCFAKBPFHH<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KMBBCCKJAHA([In] NKKJNLBFNHK<TData> GGNBJNBHEON);

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KMBBCCKJAHA([In] OCHHFFGHCJL<TData> GGNBJNBHEON);
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public interface EENGEPBDHNO<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DHCBLAJMNPL([In] ONEALLIEBLN<TData> LHPONFJJEGD);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KHJBIJFALPH([In] KJKAGHLNKIC MNIIEOCDCCD);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool KCDLCKJKHCF();
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public class BGFABOGNIHN<TData> : FLODBGCJFPL<IDCFAKBPFHH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private readonly NKKJNLBFNHK<TData> GGNBJNBHEON;

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x654C290", Offset = "0x654B690", VA = "0x18654C290")]
	public BGFABOGNIHN(IEnumerable<TData> KIBNCDDDBLI, Quaternion NOJFDNDOCKD, Vector3? MEENPCCFIHK, bool GEOLEGBPPBF, bool MBBLAICPMDP, IDCFAKBPFHH<TData> EIMAFKHCFEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x4550430", Offset = "0x454F830", VA = "0x184550430", Slot = "4")]
	public override bool KMBBCCKJAHA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public class OEMIEFDBEOM<TData> : FLODBGCJFPL<EENGEPBDHNO<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x49B64A0", Offset = "0x49B58A0", VA = "0x1849B64A0")]
	public OEMIEFDBEOM(EENGEPBDHNO<TData> EIMAFKHCFEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x5379E40", Offset = "0x5379240", VA = "0x185379E40", Slot = "4")]
	public override bool KMBBCCKJAHA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public class DOPHLFEFEKK<TData> : FLODBGCJFPL<EENGEPBDHNO<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly ONEALLIEBLN<TData> GGNBJNBHEON;

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x45665A0", Offset = "0x45659A0", VA = "0x1845665A0")]
	public DOPHLFEFEKK(IEnumerable<TData> KIBNCDDDBLI, bool MBBLAICPMDP, EENGEPBDHNO<TData> EIMAFKHCFEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x4550430", Offset = "0x454F830", VA = "0x184550430", Slot = "4")]
	public override bool KMBBCCKJAHA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public class MILMCGNDOGB<TData> : FLODBGCJFPL<IDCFAKBPFHH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private readonly OCHHFFGHCJL<TData> GGNBJNBHEON;

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x577EE00", Offset = "0x577E200", VA = "0x18577EE00")]
	public MILMCGNDOGB(IEnumerable<TData> KIBNCDDDBLI, Quaternion JPPJEADFMPI, FMPPFODFNAH IEIEMBNNFFP, Vector3? MEENPCCFIHK, bool GEOLEGBPPBF, bool MBBLAICPMDP, Space FHPFNNMPPCN, IDCFAKBPFHH<TData> EIMAFKHCFEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x5518060", Offset = "0x5517460", VA = "0x185518060", Slot = "4")]
	public override bool KMBBCCKJAHA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public class BBGNELIGHNF<TData> : FLODBGCJFPL<EENGEPBDHNO<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private readonly KJKAGHLNKIC GGNBJNBHEON;

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x645E640", Offset = "0x645DA40", VA = "0x18645E640")]
	public BBGNELIGHNF(Quaternion NOJFDNDOCKD, Vector3? MEENPCCFIHK, bool GEOLEGBPPBF, EENGEPBDHNO<TData> EIMAFKHCFEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x50C9090", Offset = "0x50C8490", VA = "0x1850C9090", Slot = "4")]
	public override bool KMBBCCKJAHA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public struct NKKJNLBFNHK<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public readonly IEnumerable<TData> KIBNCDDDBLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public readonly Quaternion NOJFDNDOCKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public readonly Vector3? MEENPCCFIHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public readonly bool GEOLEGBPPBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public readonly bool MBBLAICPMDP;

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x581BC40", Offset = "0x581B040", VA = "0x18581BC40")]
	public NKKJNLBFNHK(IEnumerable<TData> KIBNCDDDBLI, Quaternion NOJFDNDOCKD, Vector3? MEENPCCFIHK, bool GEOLEGBPPBF, bool MBBLAICPMDP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public struct ONEALLIEBLN<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public readonly IEnumerable<TData> KIBNCDDDBLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public readonly bool MBBLAICPMDP;

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x59ECAE0", Offset = "0x59EBEE0", VA = "0x1859ECAE0")]
	public ONEALLIEBLN(IEnumerable<TData> KIBNCDDDBLI, bool MBBLAICPMDP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public struct OCHHFFGHCJL<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public readonly IEnumerable<TData> KIBNCDDDBLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public readonly Quaternion JPPJEADFMPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public readonly FMPPFODFNAH IEIEMBNNFFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public readonly Vector3? MEENPCCFIHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public readonly bool GEOLEGBPPBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public readonly bool MBBLAICPMDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public readonly Space FHPFNNMPPCN;

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x59863E0", Offset = "0x59857E0", VA = "0x1859863E0")]
	public OCHHFFGHCJL(IEnumerable<TData> KIBNCDDDBLI, Quaternion JPPJEADFMPI, FMPPFODFNAH IEIEMBNNFFP, Vector3? MEENPCCFIHK, bool GEOLEGBPPBF, bool MBBLAICPMDP, Space FHPFNNMPPCN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public struct KJKAGHLNKIC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public readonly Quaternion NOJFDNDOCKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public readonly Vector3? MEENPCCFIHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public readonly bool GEOLEGBPPBF;

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x6157790", Offset = "0x6156B90", VA = "0x186157790")]
	public KJKAGHLNKIC(Quaternion NOJFDNDOCKD, Vector3? MEENPCCFIHK, bool GEOLEGBPPBF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public interface IPKGGFLBIEA<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DHCBLAJMNPL([In] AJEIEEPGDKP<TData> LHPONFJJEGD);

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KHJBIJFALPH([In] CDHKOBOMDML MNIIEOCDCCD);

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool KHJBIJFALPH([In] JGGCMJAKONO MNIIEOCDCCD);

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool KHJBIJFALPH([In] NHJNJFBNOGI MNIIEOCDCCD);

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool KCDLCKJKHCF();
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public class JAPEGKIOILD<TData> : FLODBGCJFPL<IPKGGFLBIEA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private readonly NHJNJFBNOGI ADEBGHJHJFB;

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x5303180", Offset = "0x5302580", VA = "0x185303180")]
	public JAPEGKIOILD(Vector3 PFDOOCGMEMF, float ECDGIBOACGM, Vector3 MEENPCCFIHK, bool MMJOGGGFCKA, bool BDIBJGHOIHC, IPKGGFLBIEA<TData> EIMAFKHCFEM, Space FHPFNNMPPCN = Space.Self)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x5303120", Offset = "0x5302520", VA = "0x185303120", Slot = "4")]
	public override bool KMBBCCKJAHA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public class KNNGPJPPFBJ<TData> : FLODBGCJFPL<IPKGGFLBIEA<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x49B64A0", Offset = "0x49B58A0", VA = "0x1849B64A0")]
	public KNNGPJPPFBJ(IPKGGFLBIEA<TData> EIMAFKHCFEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x54615F0", Offset = "0x54609F0", VA = "0x1854615F0", Slot = "4")]
	public override bool KMBBCCKJAHA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
public class MBMDMFEGBJC<TData> : FLODBGCJFPL<IPKGGFLBIEA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private readonly AJEIEEPGDKP<TData> ADEBGHJHJFB;

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x576A930", Offset = "0x5769D30", VA = "0x18576A930")]
	public MBMDMFEGBJC(IEnumerable<TData> KIBNCDDDBLI, bool MBBLAICPMDP, IPKGGFLBIEA<TData> EIMAFKHCFEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x4550430", Offset = "0x454F830", VA = "0x184550430", Slot = "4")]
	public override bool KMBBCCKJAHA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
public class KIJFJBDAJML<TData> : FLODBGCJFPL<IPKGGFLBIEA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private readonly JGGCMJAKONO ADEBGHJHJFB;

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x5451AA0", Offset = "0x5450EA0", VA = "0x185451AA0")]
	public KIJFJBDAJML(float OACDOKFPGFG, bool MGFLLGMAPAE, Vector3 MEENPCCFIHK, IPKGGFLBIEA<TData> EIMAFKHCFEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x54519E0", Offset = "0x5450DE0", VA = "0x1854519E0", Slot = "4")]
	public override bool KMBBCCKJAHA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
public class KJCCBGGKJII<TData> : FLODBGCJFPL<IPKGGFLBIEA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private readonly CDHKOBOMDML ADEBGHJHJFB;

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x5452680", Offset = "0x5451A80", VA = "0x185452680")]
	public KJCCBGGKJII(float ECDGIBOACGM, Vector3 MEENPCCFIHK, IPKGGFLBIEA<TData> EIMAFKHCFEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x50C9090", Offset = "0x50C8490", VA = "0x1850C9090", Slot = "4")]
	public override bool KMBBCCKJAHA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
public struct NHJNJFBNOGI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public readonly Vector3 PFDOOCGMEMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public readonly float ECDGIBOACGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public readonly Vector3 MEENPCCFIHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	public readonly bool MCOKBEFNOPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	public readonly Space FHPFNNMPPCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	public readonly bool BDIBJGHOIHC;

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x8309FD0", Offset = "0x83093D0", VA = "0x188309FD0")]
	public NHJNJFBNOGI(Vector3 PFDOOCGMEMF, float ECDGIBOACGM, Vector3 MEENPCCFIHK, bool MCOKBEFNOPE, bool DMHLNLKEKGL, Space FHPFNNMPPCN = Space.Self)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public struct AJEIEEPGDKP<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public readonly IEnumerable<TData> KIBNCDDDBLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public readonly bool MBBLAICPMDP;

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x52B79A0", Offset = "0x52B6DA0", VA = "0x1852B79A0")]
	public AJEIEEPGDKP(IEnumerable<TData> KIBNCDDDBLI, bool MBBLAICPMDP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
public struct JGGCMJAKONO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public readonly float OACDOKFPGFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public readonly bool MGFLLGMAPAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public readonly Vector3 MEENPCCFIHK;

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x8309710", Offset = "0x8308B10", VA = "0x188309710")]
	public JGGCMJAKONO(float OACDOKFPGFG, bool MGFLLGMAPAE, Vector3 MEENPCCFIHK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public struct CDHKOBOMDML
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public readonly float ECDGIBOACGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public readonly Vector3 MEENPCCFIHK;

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x6104AC0", Offset = "0x6103EC0", VA = "0x186104AC0")]
	public CDHKOBOMDML(float ECDGIBOACGM, Vector3 MEENPCCFIHK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public struct KLGPCNPBEFH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public readonly Guid[] KIBNCDDDBLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public readonly bool FMMHNALNJJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public readonly bool FLNBMKGOLOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public readonly bool OPCOINNPIHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public readonly Vector3[] LNGOJOBDGLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public readonly Quaternion[] OOMDMDOCNGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public readonly float[] HMNEOEODNDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public readonly Dictionary<Guid, Vector3> BIFMINFBABP;

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x8309A10", Offset = "0x8308E10", VA = "0x188309A10")]
	public KLGPCNPBEFH(Guid[] HAOIOKPKIAO, Vector3[] LNGOJOBDGLC, Quaternion[] OOMDMDOCNGA, float[] HMNEOEODNDH, Dictionary<Guid, Vector3> BIFMINFBABP, bool FMMHNALNJJO = true, bool FLNBMKGOLOD = true, bool OPCOINNPIHH = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x8309840", Offset = "0x8308C40", VA = "0x188309840")]
	private static void KNGEOMCAKDB(Dictionary<Guid, Vector3> BIFMINFBABP, int AICLNKJNCNP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public static class PFBNNCLGGLA
{
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	private struct POFNEDJOFJK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public bool FFOMBOPIAHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public JFAGCPCLAAF JMFDOLCFICM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public JFAGCPCLAAF LDHCDLJFNGB;
	}

	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private static POFNEDJOFJK MABLHKHCFKM;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static CancellationToken CKBDJOFGFBF
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x830A400", Offset = "0x8309800", VA = "0x18830A400")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	internal static JFAGCPCLAAF JMFDOLCFICM
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x830A360", Offset = "0x8309760", VA = "0x18830A360")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x830A420", Offset = "0x8309820", VA = "0x18830A420")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x830A0B0", Offset = "0x83094B0", VA = "0x18830A0B0")]
	[MKODAOGKIAA.PONKMEEEKBE]
	internal static void CJOCKMMIJAN(JFAGCPCLAAF KLKKEFCMFMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x830A1B0", Offset = "0x83095B0", VA = "0x18830A1B0")]
	public static void CNFJEHEIBKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x830A310", Offset = "0x8309710", VA = "0x18830A310")]
	private static JFAGCPCLAAF EGILFJDDLOK(JFAGCPCLAAF PCAICDKGOID)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
public static class DLNOALHJJMM
{
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	public enum GGMDDLEPMFN
	{
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		ICreationContextObject,
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		Guid
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x3B13310", Offset = "0x3B12710", VA = "0x183B13310")]
	public static void AMADJLLNPON<T>(T CDEDDCLKCCJ, GGMDDLEPMFN IIHAKBEOLJD) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x3B13450", Offset = "0x3B12850", VA = "0x183B13450")]
	public static void AMADJLLNPON<T>(T CDEDDCLKCCJ) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x3B13230", Offset = "0x3B12630", VA = "0x183B13230")]
	public static void AMADJLLNPON<T, TImpl, T>() where T : class where TImpl : notnull, T where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x3B13900", Offset = "0x3B12D00", VA = "0x183B13900")]
	public static void OEJIAKJLCGB<T>(T CDEDDCLKCCJ) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x3B13590", Offset = "0x3B12990", VA = "0x183B13590")]
	public static T DIJAEKOIPED<T>(GGMDDLEPMFN IIHAKBEOLJD) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x3B136D0", Offset = "0x3B12AD0", VA = "0x183B136D0")]
	public static bool KGHIMGHIPAA<T>(GGMDDLEPMFN IIHAKBEOLJD, T? LOGBEDNMLJE, [Out][MaybeNullWhen(false)][NotNullWhen(true)] T GADCLOODNNK) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x3B13800", Offset = "0x3B12C00", VA = "0x183B13800")]
	public static bool MJFGHENLGNF<T>(GGMDDLEPMFN IIHAKBEOLJD, [Out][NotNullWhen(true)][MaybeNullWhen(false)] T CLADDPJKFJL) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x3B134B0", Offset = "0x3B128B0", VA = "0x183B134B0")]
	public static bool DDDAAJOGIDK<T>(GGMDDLEPMFN IIHAKBEOLJD) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x3B13550", Offset = "0x3B12950", VA = "0x183B13550")]
	public static T DIJAEKOIPED<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x3B13630", Offset = "0x3B12A30", VA = "0x183B13630")]
	public static bool KGHIMGHIPAA<T>(T LOGBEDNMLJE, [Out] T GADCLOODNNK) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x3B13550", Offset = "0x3B12950", VA = "0x183B13550")]
	public static bool DDDAAJOGIDK<T>() where T : class
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
internal static class CAKMBJCOPHK
{
	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x8308BF0", Offset = "0x8307FF0", VA = "0x188308BF0")]
	public static void GOMCKMDECIG(IEnumerable LEANJGGPPBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x3A9DA00", Offset = "0x3A9CE00", VA = "0x183A9DA00")]
	public static void GOMCKMDECIG<T>(T[] LMLCJEFLFMP) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x3A9DAF0", Offset = "0x3A9CEF0", VA = "0x183A9DAF0")]
	public static void GOMCKMDECIG<T>(T JFDJMGGLGMC) where T : notnull, Enum
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
