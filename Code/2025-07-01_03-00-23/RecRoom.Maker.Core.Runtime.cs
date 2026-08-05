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
		[Cpp2IlInjected.Address(RVA = "0xA6F950", Offset = "0xA6DF50", VA = "0x180A6F950")]
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
		[Cpp2IlInjected.Address(RVA = "0x80080C0", Offset = "0x80066C0", VA = "0x1880080C0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA705D0", Offset = "0xA6EBD0", VA = "0x180A705D0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA70610", Offset = "0xA6EC10", VA = "0x180A70610")]
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
		[Cpp2IlInjected.Address(RVA = "0x8008560", Offset = "0x8006B60", VA = "0x188008560", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x282D140", Offset = "0x282B740", VA = "0x18282D140")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum KJAOEGOOKDA
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	ShowFreeInventionsInR2PaletteSearch
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum CJKGBKCINIO
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
public interface CJAFFJLOHPN<TData, TReturn>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TReturn DGKBEANEEFF(TData ODCICEDDLMB);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface MAEICMLNHLM<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ClearHoverTarget(OFBOANHMLNE JJPBMBMBBPA);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool SetHoverTarget(TData OKOGHNMMGGB, Collider NPJDKPLLNIC, OFBOANHMLNE JJPBMBMBBPA, [Optional] CPCDDMBJLPC? PEPEADBEOBH);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool TryGetHoverTarget([Out] TData OKOGHNMMGGB);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool TryGetHoverCollider([Out] Collider NPJDKPLLNIC);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface LHJPGBJEGCH<TData> : LJMDMNDMEJF, DKAPLCEJEJB<TData>, NCKLIFGFHEJ<TData>, JHCGDBKDFKC<TData>, KBMINIBICHJ, GAEKOGPCCCO<TData>, IMPPNPCLFNJ, JCOGPICMOMG
{
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface GAEKOGPCCCO<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool Raycast(Vector3 HOPJCEGNGCM, Vector3 GJGHBLDDKFD, float AMEHFMMOAMH, [Out] T PLGCPHAMILF, [Out] Vector3 BHFPNAMAKKB, [Out] Collider NPJDKPLLNIC);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int SpherecastPick(Vector3 HOPJCEGNGCM, Vector3 GJGHBLDDKFD, float BKNGAOILNGH, float AMEHFMMOAMH, T[] GANJBJLBCBL, [Out] Vector3 JMHDNPMMGJH, [Out] Collider EKPFNNIEOMP);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int SpherePick(Vector3 HOPJCEGNGCM, float BKNGAOILNGH, Vector3 PAEJCKBABPD, T[] GANJBJLBCBL);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool TryGetObjectFromColliderInCurrentScope(Collider DDEHFNFBNGL, [Out] T DMDLDNPCFEG);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface LJMDMNDMEJF
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Bounds LAHHOEAKNHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	Transform PDJGIMAOMKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	Bounds OACHIEBFFCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Transform OKHKEIHBOCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	Vector3 KBJPPLNPLOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool JBMGOGKDGAN
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
	void SetSelectionBoundsDirty(bool HNKBDCHLALN = true, int MBLAAICFABP = 0);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void ShouldHideSelectionBoundsPreview(bool JMBBLFCHPIF, object DKFMAIJGPFL);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface JCOGPICMOMG
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	LGEBFGGIOJB LOLKJEJDOHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface FENBKCLBKGF
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool GODCOIDPAOK
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool JJHOMDCKLIH
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool APOFGCMHKCB
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
	void TrySetPreviousCloneMapping(Dictionary<Guid, Guid> DAKCMBKNGME);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface JHCGDBKDFKC<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool MOLDBBPBOPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	int FOKKEBEPBLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<TData> HAFDDKOELBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IsSelected(TData GANFJJCKLGF);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IsSelectable(TData GANFJJCKLGF);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface DKAPLCEJEJB<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void RenderHoverHighlight(T ODCICEDDLMB, [Optional] CPCDDMBJLPC? INCEDNPHADK, bool FEHDONBNCKB = true);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RenderHoverHighlight(int FOAMCIPOLAA, IEnumerable<T> OFGGJJPABEH, bool FEHDONBNCKB = true);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RenderHoverHighlight(int FOAMCIPOLAA, IEnumerable<T> OFGGJJPABEH, CPCDDMBJLPC INCEDNPHADK, bool FEHDONBNCKB = true);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface IMPPNPCLFNJ
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnSelectionPickedUp();

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnSelectionReleased();
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface KBMINIBICHJ
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool LBFKPEMMOGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool IPJCJCAIBMP
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	bool BMBPICGAPAD
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	bool KDDJHMEOMOD
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct AHOPJCCCDPO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public bool BCIKEFCCCPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public float? CDPFGOLPCJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public float? ILPCPCLNHPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public float? IMEDNGBJPLG;
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct AKCDMJCNIBA<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public IEnumerable<TData> HPEBAHEPAPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public AHOPJCCCDPO OPBMLJMGKLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public bool GEIELIMOBOC;

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x4F8DD10", Offset = "0x4F8C310", VA = "0x184F8DD10")]
	public AKCDMJCNIBA(IEnumerable<TData> CIEPDNPGAMI, bool FBBCDEBFKJJ, float? MHLKPAANLEB, float? EHECCAJFJLF, float? DAIHGBJJCHG, bool GEIELIMOBOC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface IGJBBKMBFNA<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NJPLCABILLF([In] AKCDMJCNIBA<TData> MMCAOMENGOP);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class DIMPEAKDNEK<TData> : IKOICLDPMHH<IGJBBKMBFNA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly AKCDMJCNIBA<TData> MMCAOMENGOP;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6D12A70", Offset = "0x6D11070", VA = "0x186D12A70")]
	public DIMPEAKDNEK(IEnumerable<TData> CIEPDNPGAMI, bool FBBCDEBFKJJ, float? MHLKPAANLEB, float? EHECCAJFJLF, float? DAIHGBJJCHG, bool GEIELIMOBOC, IGJBBKMBFNA<TData> GOFEAPECJPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x4BF27D0", Offset = "0x4BF0DD0", VA = "0x184BF27D0", Slot = "4")]
	public override bool NJPLCABILLF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct GEBKIBDBLPM<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public IEnumerable<TData> HPEBAHEPAPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public string EAENBKOLAIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public bool FFKKMEIOKDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public bool GEIELIMOBOC;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x4D2D1A0", Offset = "0x4D2B7A0", VA = "0x184D2D1A0")]
	public GEBKIBDBLPM(IEnumerable<TData> CIEPDNPGAMI, string ODEILPPIMEL, bool BJNGDJJAHML, bool GEIELIMOBOC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface LLJMEECLJIF<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NJPLCABILLF([In] GEBKIBDBLPM<TData> MMCAOMENGOP);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class BKFPMBEJHGC<TData> : IKOICLDPMHH<LLJMEECLJIF<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly GEBKIBDBLPM<TData> MMCAOMENGOP;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x62085A0", Offset = "0x6206BA0", VA = "0x1862085A0")]
	public BKFPMBEJHGC(IEnumerable<TData> CIEPDNPGAMI, string ODEILPPIMEL, bool BJNGDJJAHML, bool GEIELIMOBOC, LLJMEECLJIF<TData> GOFEAPECJPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x4BF27D0", Offset = "0x4BF0DD0", VA = "0x184BF27D0", Slot = "4")]
	public override bool NJPLCABILLF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public abstract class IKOICLDPMHH<TReceiver> : LFJAMCMFNHM<TReceiver, bool> where TReceiver : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x479A440", Offset = "0x4798A40", VA = "0x18479A440")]
	public IKOICLDPMHH(TReceiver GOFEAPECJPJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public abstract class PAHHGGONIPP<TReceiver, TFromTask> : LFJAMCMFNHM<TReceiver, Task<TFromTask>>
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x479A440", Offset = "0x4798A40", VA = "0x18479A440")]
	public PAHHGGONIPP(TReceiver GOFEAPECJPJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public abstract class LFJAMCMFNHM<TReceiver, TFromExecute> where TReceiver : notnull where TFromExecute : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	protected TReceiver GOFEAPECJPJ;

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x53836D0", Offset = "0x5381CD0", VA = "0x1853836D0")]
	public LFJAMCMFNHM(TReceiver GOFEAPECJPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TFromExecute NJPLCABILLF();
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public abstract class IGCNAJKDLMD<TReceiver, TResult> : LFJAMCMFNHM<TReceiver, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x479A440", Offset = "0x4798A40", VA = "0x18479A440")]
	public IGCNAJKDLMD(TReceiver GOFEAPECJPJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public struct KOLLJPFNBCE<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public TGroup HBHGDLLLEHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public TData GDNFDCBIKFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public IEnumerable<TData> HPEBAHEPAPC;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x1CC85D0", Offset = "0x1CC6BD0", VA = "0x181CC85D0")]
	public KOLLJPFNBCE(TGroup GAODFEACCFH, TData LEEJNDALBIB, IEnumerable<TData> CIEPDNPGAMI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct AFJAPPEDPMB<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public TGroup HBHGDLLLEHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public IEnumerable<TData> HPEBAHEPAPC;

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0xB8E8F0", Offset = "0xB8CEF0", VA = "0x180B8E8F0")]
	public AFJAPPEDPMB(TGroup GAODFEACCFH, IEnumerable<TData> CIEPDNPGAMI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct NDFPPIPJANK<TGroup> where TGroup : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public TGroup HBHGDLLLEHF;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0xDE8A40", Offset = "0xDE7040", VA = "0x180DE8A40")]
	public NDFPPIPJANK(TGroup GAODFEACCFH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public struct HOBCNCNHADH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public IEnumerable<Guid> HPEBAHEPAPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public Guid GNPDGNCGFOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly bool DCPIHEHADLL;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x8007560", Offset = "0x8005B60", VA = "0x188007560")]
	public HOBCNCNHADH(IEnumerable<Guid> CIEPDNPGAMI, Guid PEJPFKIGPMP, bool GEIELIMOBOC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public struct INOBFHOEAKE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public Guid GNPDGNCGFOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public readonly bool DCPIHEHADLL;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x27A73B0", Offset = "0x27A59B0", VA = "0x1827A73B0")]
	public INOBFHOEAKE(Guid PEJPFKIGPMP, bool GEIELIMOBOC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface BDNMCDJNKFP<TGroup, TData>
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IOAMMFOPFBF ENNHABJNMJC(KOLLJPFNBCE<TGroup, TData> BHGOIJOCPBC);

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IOAMMFOPFBF FJCMGEHBAEN(KOLLJPFNBCE<TGroup, TData> BHGOIJOCPBC);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IOAMMFOPFBF AMBPKEOCAOK(AFJAPPEDPMB<TGroup, TData> BHGOIJOCPBC);

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IOAMMFOPFBF MOJLAHFCGLC(NDFPPIPJANK<TGroup> BHGOIJOCPBC);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public interface BKFHPCBMEMI
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IOAMMFOPFBF> ENNHABJNMJC(HOBCNCNHADH BHGOIJOCPBC);

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<IOAMMFOPFBF> FJCMGEHBAEN(INOBFHOEAKE BHGOIJOCPBC);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class PNHBPCFOAAD<TGroup, TData> : IGCNAJKDLMD<BDNMCDJNKFP<TGroup, TData>, IOAMMFOPFBF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly AFJAPPEDPMB<TGroup, TData> BHGOIJOCPBC;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x58F69A0", Offset = "0x58F4FA0", VA = "0x1858F69A0")]
	public PNHBPCFOAAD(TGroup GAODFEACCFH, IEnumerable<TData> CIEPDNPGAMI, BDNMCDJNKFP<TGroup, TData> GOFEAPECJPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x58F68D0", Offset = "0x58F4ED0", VA = "0x1858F68D0", Slot = "4")]
	public override IOAMMFOPFBF NJPLCABILLF()
	{
		return default(IOAMMFOPFBF);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class LBDOKOPEKMM<TGroup, TData> : IGCNAJKDLMD<BDNMCDJNKFP<TGroup, TData>, IOAMMFOPFBF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly KOLLJPFNBCE<TGroup, TData> BHGOIJOCPBC;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x5375C50", Offset = "0x5374250", VA = "0x185375C50")]
	public LBDOKOPEKMM(TGroup GAODFEACCFH, TData NLKHOFMEFPH, IEnumerable<TData> CIEPDNPGAMI, BDNMCDJNKFP<TGroup, TData> GOFEAPECJPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x5375B80", Offset = "0x5374180", VA = "0x185375B80", Slot = "4")]
	public override IOAMMFOPFBF NJPLCABILLF()
	{
		return default(IOAMMFOPFBF);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class PGMCCIGJGHE<TGroup, TData> : IGCNAJKDLMD<BDNMCDJNKFP<TGroup, TData>, IOAMMFOPFBF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly NDFPPIPJANK<TGroup> BHGOIJOCPBC;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x4DD5030", Offset = "0x4DD3630", VA = "0x184DD5030")]
	public PGMCCIGJGHE(TGroup GAODFEACCFH, BDNMCDJNKFP<TGroup, TData> GOFEAPECJPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x58D91B0", Offset = "0x58D77B0", VA = "0x1858D91B0", Slot = "4")]
	public override IOAMMFOPFBF NJPLCABILLF()
	{
		return default(IOAMMFOPFBF);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class DJDNNJDGCKM<TGroup, TData> : IGCNAJKDLMD<BDNMCDJNKFP<TGroup, TData>, IOAMMFOPFBF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly KOLLJPFNBCE<TGroup, TData> BHGOIJOCPBC;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x5375C50", Offset = "0x5374250", VA = "0x185375C50")]
	public DJDNNJDGCKM(TGroup GAODFEACCFH, TData LEEJNDALBIB, IEnumerable<TData> CIEPDNPGAMI, BDNMCDJNKFP<TGroup, TData> GOFEAPECJPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6D14B50", Offset = "0x6D13150", VA = "0x186D14B50", Slot = "4")]
	public override IOAMMFOPFBF NJPLCABILLF()
	{
		return default(IOAMMFOPFBF);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class FPKFPHIAIBH : PAHHGGONIPP<BKFHPCBMEMI, IOAMMFOPFBF>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private struct IDIILJLOIAA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public AsyncTaskMethodBuilder<IOAMMFOPFBF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public FPKFPHIAIBH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private TaskAwaiter<IOAMMFOPFBF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x80075C0", Offset = "0x8005BC0", VA = "0x1880075C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x8007860", Offset = "0x8005E60", VA = "0x188007860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private HOBCNCNHADH BHGOIJOCPBC;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x8006E70", Offset = "0x8005470", VA = "0x188006E70")]
	public FPKFPHIAIBH(IEnumerable<Guid> GNDJCNPICAI, Guid PEJPFKIGPMP, bool GEIELIMOBOC, BKFHPCBMEMI GOFEAPECJPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x8006D80", Offset = "0x8005380", VA = "0x188006D80", Slot = "4")]
	[AsyncStateMachine(typeof(IDIILJLOIAA))]
	public override Task<IOAMMFOPFBF> NJPLCABILLF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class CDMMPLMBHON : PAHHGGONIPP<BKFHPCBMEMI, IOAMMFOPFBF>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private struct HDFOEAFDCJM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public AsyncTaskMethodBuilder<IOAMMFOPFBF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public CDMMPLMBHON <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private TaskAwaiter<IOAMMFOPFBF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x8007160", Offset = "0x8005760", VA = "0x188007160", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x8007400", Offset = "0x8005A00", VA = "0x188007400", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly INOBFHOEAKE BHGOIJOCPBC;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x8006790", Offset = "0x8004D90", VA = "0x188006790")]
	public CDMMPLMBHON(Guid PEJPFKIGPMP, bool GEIELIMOBOC, BKFHPCBMEMI GOFEAPECJPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x80066A0", Offset = "0x8004CA0", VA = "0x1880066A0", Slot = "4")]
	[AsyncStateMachine(typeof(HDFOEAFDCJM))]
	public override Task<IOAMMFOPFBF> NJPLCABILLF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public readonly struct IBMOFDKNNDF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public readonly BLEEGIEOIHJ IFNMNKDCMNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly bool DCPIHEHADLL;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x80075A0", Offset = "0x8005BA0", VA = "0x1880075A0")]
	public IBMOFDKNNDF(BLEEGIEOIHJ EKPNJKMOFEC, bool GEIELIMOBOC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface IBFLAJGJHFI<TSpawnType> where TSpawnType : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> NJPLCABILLF(IBMOFDKNNDF PAJBGOBPBCO);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class IBPGDFLBPLB<TSpawnType> : PAHHGGONIPP<IBFLAJGJHFI<TSpawnType>, TSpawnType> where TSpawnType : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private struct CPENGOBDODI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public AsyncTaskMethodBuilder<TSpawnType> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public IBPGDFLBPLB<TSpawnType> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private TaskAwaiter<TSpawnType> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x68881C0", Offset = "0x68867C0", VA = "0x1868881C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x47591B0", Offset = "0x47577B0", VA = "0x1847591B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly IBMOFDKNNDF PAJBGOBPBCO;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x4F46560", Offset = "0x4F44B60", VA = "0x184F46560")]
	public IBPGDFLBPLB(BLEEGIEOIHJ EKPNJKMOFEC, bool GEIELIMOBOC, IBFLAJGJHFI<TSpawnType> GOFEAPECJPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x4F46360", Offset = "0x4F44960", VA = "0x184F46360", Slot = "4")]
	[AsyncStateMachine(typeof(IBPGDFLBPLB<>.CPENGOBDODI))]
	public override Task<TSpawnType> NJPLCABILLF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public readonly struct BLEEGIEOIHJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly bool HBPNCHINHEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly Vector3 BBIEEIIPMBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly Vector3 DGHMAMNELGC;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x8006570", Offset = "0x8004B70", VA = "0x188006570")]
	public BLEEGIEOIHJ(Transform ANHGAHMFOBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x80065E0", Offset = "0x8004BE0", VA = "0x1880065E0")]
	public BLEEGIEOIHJ(Vector3 IFDADDNBHKB, Vector3 NHLFNDFGAHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x8006540", Offset = "0x8004B40", VA = "0x188006540")]
	public static BLEEGIEOIHJ PLEBMHKEBJO()
	{
		return default(BLEEGIEOIHJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x8006610", Offset = "0x8004C10", VA = "0x188006610")]
	private BLEEGIEOIHJ(bool CHLLELKNCHC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public struct CMLCHLPNIAP<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public TNode GNDIKPIIGDH;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x687CF80", Offset = "0x687B580", VA = "0x18687CF80")]
	public CMLCHLPNIAP(TNode GNDIKPIIGDH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public struct KKBPLCJGADF<TNode, TReparentOperations> where TNode : notnull where TReparentOperations : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public TNode LKHDHJOMEPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public TReparentOperations OKAHHPNMENI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public PKDKLNDFCIM GFMFHHFDDAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly bool DCPIHEHADLL;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x52D87F0", Offset = "0x52D6DF0", VA = "0x1852D87F0")]
	public KKBPLCJGADF(TNode LKHDHJOMEPO, TReparentOperations OKAHHPNMENI, PKDKLNDFCIM GFMFHHFDDAH, bool GEIELIMOBOC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface JLHJCMPADGG<TNode, TReparentOperations>
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LJAEGJIOAMB([In] CMLCHLPNIAP<TNode> OJOABOLHHIH);

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool ODBKIMILCDF([In] KKBPLCJGADF<TNode, TReparentOperations> GJIBHLPIPAB);

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool OJFIPMKBLKJ();
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class PDFBEDNDBHC<TNode, TReparentOperations> : IKOICLDPMHH<JLHJCMPADGG<TNode, TReparentOperations>>
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x479A440", Offset = "0x4798A40", VA = "0x18479A440")]
	public PDFBEDNDBHC(JLHJCMPADGG<TNode, TReparentOperations> GOFEAPECJPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x58B2250", Offset = "0x58B0850", VA = "0x1858B2250", Slot = "4")]
	public override bool NJPLCABILLF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public class EHLGNJEPPEH<TNode, TReparentOperations> : IKOICLDPMHH<JLHJCMPADGG<TNode, TReparentOperations>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly KKBPLCJGADF<TNode, TReparentOperations> GJIBHLPIPAB;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x478AA10", Offset = "0x4789010", VA = "0x18478AA10")]
	public EHLGNJEPPEH(TNode LKHDHJOMEPO, TReparentOperations OKAHHPNMENI, PKDKLNDFCIM GFMFHHFDDAH, JLHJCMPADGG<TNode, TReparentOperations> GOFEAPECJPJ, bool GEIELIMOBOC = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x478A940", Offset = "0x4788F40", VA = "0x18478A940", Slot = "4")]
	public override bool NJPLCABILLF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public class MLDABGEDKGA<TNode, TReparentOperations> : IKOICLDPMHH<JLHJCMPADGG<TNode, TReparentOperations>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly CMLCHLPNIAP<TNode> OJOABOLHHIH;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5613A90", Offset = "0x5612090", VA = "0x185613A90")]
	public MLDABGEDKGA(TNode PNGHHDLCCLF, JLHJCMPADGG<TNode, TReparentOperations> GOFEAPECJPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x4BF27D0", Offset = "0x4BF0DD0", VA = "0x184BF27D0", Slot = "4")]
	public override bool NJPLCABILLF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct MAOIJFCFBHO<TSpawnInfo> where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public TSpawnInfo CONALGMNMPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public Vector3 NHLFNDFGAHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public Quaternion CFFPEJBOBIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public float HKINPNLCPPL;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x55F8870", Offset = "0x55F6E70", VA = "0x1855F8870")]
	public MAOIJFCFBHO(TSpawnInfo CONALGMNMPH, Vector3 NHLFNDFGAHK, Quaternion CFFPEJBOBIA, float HKINPNLCPPL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public interface DJMHJHEMPBK<TSpawnType, TSpawnInfo>
{
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> KNFKOIBCEIH([In] MAOIJFCFBHO<TSpawnInfo> PCPMDLODHKB, CancellationToken KMHHNOGHBLL);
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class OOPOKOMJENN<TSpawnType, TSpawnInfo> : PAHHGGONIPP<DJMHJHEMPBK<TSpawnType, TSpawnInfo>, TSpawnType> where TSpawnType : notnull where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private readonly MAOIJFCFBHO<TSpawnInfo> MMCAOMENGOP;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x57ECF60", Offset = "0x57EB560", VA = "0x1857ECF60")]
	public OOPOKOMJENN(TSpawnInfo ABCAEHMHPJP, Vector3 NHLFNDFGAHK, Quaternion CFFPEJBOBIA, float HKINPNLCPPL, DJMHJHEMPBK<TSpawnType, TSpawnInfo> GOFEAPECJPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x57ECE80", Offset = "0x57EB480", VA = "0x1857ECE80", Slot = "4")]
	public override Task<TSpawnType> NJPLCABILLF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public readonly struct BGAHBDAMKLM<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly IEnumerable<TData> HPEBAHEPAPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public readonly bool DCPIHEHADLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly bool LJNJGOEHNKC;

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6157400", Offset = "0x6155A00", VA = "0x186157400")]
	public BGAHBDAMKLM(IEnumerable<TData> CIEPDNPGAMI, bool GEIELIMOBOC = false, bool NPOPOEDNDHF = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface IFIMEEJEMPF<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IOAMMFOPFBF> EPBEIOACDHK([In] BGAHBDAMKLM<TData> BNDFHPBKIKJ, CancellationToken KMHHNOGHBLL);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public class DABHANECCKO<TData> : PAHHGGONIPP<IFIMEEJEMPF<TData>, IOAMMFOPFBF> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private readonly BGAHBDAMKLM<TData> AEBLKDNMKID;

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6CB6300", Offset = "0x6CB4900", VA = "0x186CB6300")]
	public DABHANECCKO(IEnumerable<TData> CIEPDNPGAMI, bool GEIELIMOBOC, IFIMEEJEMPF<TData> GOFEAPECJPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x57ECE80", Offset = "0x57EB480", VA = "0x1857ECE80", Slot = "4")]
	public override Task<IOAMMFOPFBF> NJPLCABILLF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public struct IMFENLFEDIA<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly T OKOGHNMMGGB;

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x4F79FD0", Offset = "0x4F785D0", VA = "0x184F79FD0")]
	public IMFENLFEDIA(T GFECMHPOLAL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface PFJKKHBNJGH<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LJAEGJIOAMB([In] IMFENLFEDIA<T> BJLHNFHNBAL);

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool ODBKIMILCDF();
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface KJIGEOKLEDD<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NJPLCABILLF([In] KBBHBKIGAGN<T> ANMDBBEIMEL);
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public struct KBBHBKIGAGN<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public readonly T OKOGHNMMGGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly bool IFELDLKLBLD;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x528F1A0", Offset = "0x528D7A0", VA = "0x18528F1A0")]
	public KBBHBKIGAGN(T GFECMHPOLAL, bool MIFFHCNGJJN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class ELNGBEHILAP<T> : IKOICLDPMHH<PFJKKHBNJGH<T>> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x479A440", Offset = "0x4798A40", VA = "0x18479A440")]
	public ELNGBEHILAP(PFJKKHBNJGH<T> GOFEAPECJPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x479A380", Offset = "0x4798980", VA = "0x18479A380", Slot = "4")]
	public override bool NJPLCABILLF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public class HAPKCCCHGOB<T> : IKOICLDPMHH<PFJKKHBNJGH<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly IMFENLFEDIA<T> BJLHNFHNBAL;

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x4DD4FB0", Offset = "0x4DD35B0", VA = "0x184DD4FB0")]
	public HAPKCCCHGOB(T OKOGHNMMGGB, PFJKKHBNJGH<T> GOFEAPECJPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x4BF27D0", Offset = "0x4BF0DD0", VA = "0x184BF27D0", Slot = "4")]
	public override bool NJPLCABILLF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public class PKENKKPNDMP<T> : IKOICLDPMHH<KJIGEOKLEDD<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private readonly KBBHBKIGAGN<T> ANMDBBEIMEL;

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x58E7470", Offset = "0x58E5A70", VA = "0x1858E7470")]
	public PKENKKPNDMP(T OKOGHNMMGGB, bool MIFFHCNGJJN, KJIGEOKLEDD<T> GOFEAPECJPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x4BF27D0", Offset = "0x4BF0DD0", VA = "0x184BF27D0", Slot = "4")]
	public override bool NJPLCABILLF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public struct CMINHBPGDMH<TData> where TData : notnull, BJKPINGIDGC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public IEnumerable<TData> HPEBAHEPAPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public bool IFBNGIKEGNE;

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x687CC80", Offset = "0x687B280", VA = "0x18687CC80")]
	public CMINHBPGDMH(IEnumerable<TData> IBFEPLPFPAJ, bool OJIAFGPOGKD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public struct FFKNGIHHOOM<TData> where TData : notnull, BJKPINGIDGC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public List<TData> HPEBAHEPAPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public List<bool> HILBAGIIHAM;

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x4C057E0", Offset = "0x4C03DE0", VA = "0x184C057E0")]
	public FFKNGIHHOOM(List<TData> IBFEPLPFPAJ, List<bool> FDGBHCHKNBK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface BJKPINGIDGC
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	bool HDLMPGEMHMP
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
public interface JNCNCEEHFFI<TData> where TData : BJKPINGIDGC
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NJPLCABILLF([In] CMINHBPGDMH<TData> BLGNGFPGJCB);

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NJPLCABILLF([In] FFKNGIHHOOM<TData> BLGNGFPGJCB);
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public interface GJJJCABMPCH<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EILEPNFMHJL(T OKOGHNMMGGB);
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public class FOCOCFHFMPA<TData> : IKOICLDPMHH<JNCNCEEHFFI<TData>> where TData : notnull, BJKPINGIDGC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly CMINHBPGDMH<TData> BLGNGFPGJCB;

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x4C5A5F0", Offset = "0x4C58BF0", VA = "0x184C5A5F0")]
	public FOCOCFHFMPA(List<TData> CIEPDNPGAMI, bool IFBNGIKEGNE, JNCNCEEHFFI<TData> GOFEAPECJPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x4BF27D0", Offset = "0x4BF0DD0", VA = "0x184BF27D0", Slot = "4")]
	public override bool NJPLCABILLF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public class FLNONODAFDJ<TData> : IKOICLDPMHH<JNCNCEEHFFI<TData>> where TData : notnull, BJKPINGIDGC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly FFKNGIHHOOM<TData> BLGNGFPGJCB;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x4C56840", Offset = "0x4C54E40", VA = "0x184C56840")]
	public FLNONODAFDJ(List<TData> CIEPDNPGAMI, List<bool> HILBAGIIHAM, JNCNCEEHFFI<TData> GOFEAPECJPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x4C56780", Offset = "0x4C54D80", VA = "0x184C56780", Slot = "4")]
	public override bool NJPLCABILLF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public interface ICDBLODPGJD<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IOAMMFOPFBF> NJPLCABILLF(GPJODMACPBG<TData> NNHKCHILKBN);
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public class PFLPODOIBPB<TData> : PAHHGGONIPP<ICDBLODPGJD<TData>, IOAMMFOPFBF> where TData : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private struct JFJGPBGMEGG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public AsyncTaskMethodBuilder<IOAMMFOPFBF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public PFLPODOIBPB<TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private TaskAwaiter<IOAMMFOPFBF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x519BA00", Offset = "0x519A000", VA = "0x18519BA00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x519BCF0", Offset = "0x519A2F0", VA = "0x18519BCF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly GPJODMACPBG<TData> GGMHHJHNKDO;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x58B96D0", Offset = "0x58B7CD0", VA = "0x1858B96D0")]
	public PFLPODOIBPB(TData FEFJFLIKHGB, IReadOnlyList<TData> NDIKCJJLCJA, bool GEIELIMOBOC, ICDBLODPGJD<TData> GOFEAPECJPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x58B95D0", Offset = "0x58B7BD0", VA = "0x1858B95D0", Slot = "4")]
	[AsyncStateMachine(typeof(PFLPODOIBPB<>.JFJGPBGMEGG))]
	public override Task<IOAMMFOPFBF> NJPLCABILLF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public struct GPJODMACPBG<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public TData NAIDHAAIDNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public IReadOnlyList<TData> PPPCCLIFOKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public bool DCPIHEHADLL;

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x2EDF800", Offset = "0x2EDDE00", VA = "0x182EDF800")]
	public GPJODMACPBG(TData FEFJFLIKHGB, IReadOnlyList<TData> NDIKCJJLCJA, bool GEIELIMOBOC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public interface CMNFKCLAHFL<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NJPLCABILLF([In] NOMFOAMPNGP<TData> IHGCIEIGNNO);
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public interface CFNBEKLNMHK<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NJPLCABILLF([In] MHAMOFGGHFI<TData> IHGCIEIGNNO);
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public interface APLAILKNGPH<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IGPOOGADCBI([In] IMPKGPBKGFN<TData> IHGCIEIGNNO);

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ODBKIMILCDF();
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class BBCGNGKKKIE<TData> : IKOICLDPMHH<CMNFKCLAHFL<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly NOMFOAMPNGP<TData> IHGCIEIGNNO;

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x613C8F0", Offset = "0x613AEF0", VA = "0x18613C8F0")]
	public BBCGNGKKKIE(IEnumerable<TData> CIEPDNPGAMI, NGNKOEFODLB HFIMNHFKOFL, FFLLKLIPNGD KKIOJDIOKCM, float NACCPECNNNM, string? ODEILPPIMEL, bool EEPNIKJKIGM, bool GEIELIMOBOC, CMNFKCLAHFL<TData> GOFEAPECJPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x4BF27D0", Offset = "0x4BF0DD0", VA = "0x184BF27D0", Slot = "4")]
	public override bool NJPLCABILLF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class OIIIJBFMBKK<TData> : IKOICLDPMHH<CFNBEKLNMHK<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly MHAMOFGGHFI<TData> IHGCIEIGNNO;

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x57D6160", Offset = "0x57D4760", VA = "0x1857D6160")]
	public OIIIJBFMBKK(TData[] CIEPDNPGAMI, NGNKOEFODLB[] HFIMNHFKOFL, FFLLKLIPNGD[] KKIOJDIOKCM, float[] NACCPECNNNM, CFNBEKLNMHK<TData> GOFEAPECJPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x4757460", Offset = "0x4755A60", VA = "0x184757460", Slot = "4")]
	public override bool NJPLCABILLF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class CNMEOFPEEEI<TData> : IKOICLDPMHH<APLAILKNGPH<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x479A440", Offset = "0x4798A40", VA = "0x18479A440")]
	public CNMEOFPEEEI(APLAILKNGPH<TData> GOFEAPECJPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x687E830", Offset = "0x687CE30", VA = "0x18687E830", Slot = "4")]
	public override bool NJPLCABILLF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public class EBJCFFADJML<TData> : IKOICLDPMHH<APLAILKNGPH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly IMPKGPBKGFN<TData> IHGCIEIGNNO;

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x4757520", Offset = "0x4755B20", VA = "0x184757520")]
	public EBJCFFADJML(IEnumerable<TData> CIEPDNPGAMI, NGNKOEFODLB HFIMNHFKOFL, FFLLKLIPNGD KKIOJDIOKCM, float NACCPECNNNM, APLAILKNGPH<TData> GOFEAPECJPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x4757460", Offset = "0x4755A60", VA = "0x184757460", Slot = "4")]
	public override bool NJPLCABILLF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public struct NOMFOAMPNGP<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public IEnumerable<TData> HPEBAHEPAPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public NGNKOEFODLB AKMCIMNLAFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public FFLLKLIPNGD PFNPFBIHOKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public float DNMLDIOIFIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public string? EAENBKOLAIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public bool? LJGCAEOLEME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public bool DCPIHEHADLL;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x56A57E0", Offset = "0x56A3DE0", VA = "0x1856A57E0")]
	public NOMFOAMPNGP(IEnumerable<TData> CIEPDNPGAMI, NGNKOEFODLB HFIMNHFKOFL, FFLLKLIPNGD KKIOJDIOKCM, float NACCPECNNNM, string? ODEILPPIMEL, bool? EEPNIKJKIGM, bool GEIELIMOBOC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public struct MHAMOFGGHFI<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public TData[] HPEBAHEPAPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public NGNKOEFODLB[] AKMCIMNLAFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public FFLLKLIPNGD[] PFNPFBIHOKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public float[] NACCPECNNNM;

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x56091D0", Offset = "0x56077D0", VA = "0x1856091D0")]
	public MHAMOFGGHFI(TData[] CIEPDNPGAMI, NGNKOEFODLB[] HFIMNHFKOFL, FFLLKLIPNGD[] KKIOJDIOKCM, float[] NACCPECNNNM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public struct IMPKGPBKGFN<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public IEnumerable<TData> HPEBAHEPAPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public NGNKOEFODLB AKMCIMNLAFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public FFLLKLIPNGD PFNPFBIHOKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public float NACCPECNNNM;

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x4F9C890", Offset = "0x4F9AE90", VA = "0x184F9C890")]
	public IMPKGPBKGFN(IEnumerable<TData> CIEPDNPGAMI, NGNKOEFODLB HFIMNHFKOFL, FFLLKLIPNGD KKIOJDIOKCM, float NACCPECNNNM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public interface NCKLIFGFHEJ<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AMBPKEOCAOK([In] HAMDLHGJEOI<TData> BNDFHPBKIKJ);

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MOJLAHFCGLC([In] HAMDLHGJEOI<TData> BNDFHPBKIKJ);

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AOHMDFPOOJB([In] bool LNIMDIEBNGE);

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool OIOAGAFPMGP([In] HAMDLHGJEOI<TData> BNDFHPBKIKJ);

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NHOPENNENFL();

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool OKHHDJNKPAJ([In] TData APHFPJGMKAJ);
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public class JPJGNIHEIOL<TData> : IKOICLDPMHH<NCKLIFGFHEJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly HAMDLHGJEOI<TData> BNDFHPBKIKJ;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x51E2820", Offset = "0x51E0E20", VA = "0x1851E2820")]
	public JPJGNIHEIOL(List<TData> LKKBHMIMCBF, NCKLIFGFHEJ<TData> GOFEAPECJPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x4BF27D0", Offset = "0x4BF0DD0", VA = "0x184BF27D0", Slot = "4")]
	public override bool NJPLCABILLF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class NOADBBKMOHK<TData> : IKOICLDPMHH<NCKLIFGFHEJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x479A440", Offset = "0x4798A40", VA = "0x18479A440")]
	public NOADBBKMOHK(NCKLIFGFHEJ<TData> GOFEAPECJPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x56A39E0", Offset = "0x56A1FE0", VA = "0x1856A39E0", Slot = "4")]
	public override bool NJPLCABILLF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public class APFAICGADLI<TData> : IKOICLDPMHH<NCKLIFGFHEJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly bool GEIELIMOBOC;

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x50745C0", Offset = "0x5072BC0", VA = "0x1850745C0")]
	public APFAICGADLI(bool GEIELIMOBOC, NCKLIFGFHEJ<TData> GOFEAPECJPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x5074560", Offset = "0x5072B60", VA = "0x185074560", Slot = "4")]
	public override bool NJPLCABILLF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class JCDIBPGACEP<TData> : IKOICLDPMHH<NCKLIFGFHEJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly HAMDLHGJEOI<TData> BNDFHPBKIKJ;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x516C370", Offset = "0x516A970", VA = "0x18516C370")]
	public JCDIBPGACEP(List<TData> LKKBHMIMCBF, bool GEIELIMOBOC, NCKLIFGFHEJ<TData> GOFEAPECJPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x4C56780", Offset = "0x4C54D80", VA = "0x184C56780", Slot = "4")]
	public override bool NJPLCABILLF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class EBADLEAENKF<TData> : IKOICLDPMHH<NCKLIFGFHEJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly TData APHFPJGMKAJ;

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x47558C0", Offset = "0x4753EC0", VA = "0x1847558C0")]
	public EBADLEAENKF(TData APHFPJGMKAJ, NCKLIFGFHEJ<TData> GOFEAPECJPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x4755740", Offset = "0x4753D40", VA = "0x184755740", Slot = "4")]
	public override bool NJPLCABILLF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class MJMEILCFHEK<TData> : IKOICLDPMHH<NCKLIFGFHEJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private readonly HAMDLHGJEOI<TData> BNDFHPBKIKJ;

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x5612AA0", Offset = "0x56110A0", VA = "0x185612AA0")]
	public MJMEILCFHEK(IEnumerable<TData> LKKBHMIMCBF, NCKLIFGFHEJ<TData> GOFEAPECJPJ, bool GEIELIMOBOC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x56129D0", Offset = "0x5610FD0", VA = "0x1856129D0", Slot = "4")]
	public override bool NJPLCABILLF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public struct HAMDLHGJEOI<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public IEnumerable<TData> HPEBAHEPAPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public bool GEIELIMOBOC;

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x4DD49A0", Offset = "0x4DD2FA0", VA = "0x184DD49A0")]
	public HAMDLHGJEOI(IEnumerable<TData> IBFEPLPFPAJ, bool PJGIICOFPGB = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public interface BGMBJPFPIEA
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IOAMMFOPFBF> NJPLCABILLF(KFPOCPAJNFG LPFGOKEKJPP);
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class KONAGBHAKPN : PAHHGGONIPP<BGMBJPFPIEA, IOAMMFOPFBF>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[CompilerGenerated]
	private struct JBOHFDKFGDA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public AsyncTaskMethodBuilder<IOAMMFOPFBF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public KONAGBHAKPN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private TaskAwaiter<IOAMMFOPFBF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x80078D0", Offset = "0x8005ED0", VA = "0x1880078D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x8007B40", Offset = "0x8006140", VA = "0x188007B40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly KFPOCPAJNFG ENINENJPJHH;

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x8007CC0", Offset = "0x80062C0", VA = "0x188007CC0")]
	public KONAGBHAKPN(bool GEIELIMOBOC, BGMBJPFPIEA GOFEAPECJPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x8007BD0", Offset = "0x80061D0", VA = "0x188007BD0", Slot = "4")]
	[AsyncStateMachine(typeof(JBOHFDKFGDA))]
	public override Task<IOAMMFOPFBF> NJPLCABILLF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public struct KFPOCPAJNFG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public bool DCPIHEHADLL;

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x2BCE300", Offset = "0x2BCC900", VA = "0x182BCE300")]
	public KFPOCPAJNFG(bool GEIELIMOBOC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public readonly struct HKJJBOPBLKH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public readonly bool NIJMICLGFLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public readonly bool EDGJBLELDGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public readonly bool HKINPNLCPPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public readonly bool GEIELIMOBOC;

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x5F46420", Offset = "0x5F44A20", VA = "0x185F46420")]
	public HKJJBOPBLKH(bool NIJMICLGFLP, bool EDGJBLELDGI, bool HKINPNLCPPL, bool GEIELIMOBOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x8007550", Offset = "0x8005B50", VA = "0x188007550")]
	public HKJJBOPBLKH(bool EDGJBLELDGI, bool GEIELIMOBOC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public interface EHGBHIAKOMG
{
	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JCKAEGDEDOF(HKJJBOPBLKH GADHEAFCNCH);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KDHPFJDCPJM(HKJJBOPBLKH GADHEAFCNCH);
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public class HFLIONMKAIF : IKOICLDPMHH<EHGBHIAKOMG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly HKJJBOPBLKH GADHEAFCNCH;

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x80074C0", Offset = "0x8005AC0", VA = "0x1880074C0")]
	public HFLIONMKAIF(bool DFOHJKCGEGI, bool EDGJBLELDGI, bool HKINPNLCPPL, bool GEIELIMOBOC, EHGBHIAKOMG GOFEAPECJPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x8007470", Offset = "0x8005A70", VA = "0x188007470", Slot = "4")]
	public override bool NJPLCABILLF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public class LBEEEMFBMEN : IKOICLDPMHH<EHGBHIAKOMG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly HKJJBOPBLKH GADHEAFCNCH;

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x8007D70", Offset = "0x8006370", VA = "0x188007D70")]
	public LBEEEMFBMEN(bool EDGJBLELDGI, bool GEIELIMOBOC, EHGBHIAKOMG GOFEAPECJPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x8007D20", Offset = "0x8006320", VA = "0x188007D20", Slot = "4")]
	public override bool NJPLCABILLF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public interface MLLBCACPKHI
{
	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NJPLCABILLF([In] FHLPAAAMKGN EDONHGCODFC);
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class NHEENLOGAKG : IKOICLDPMHH<MLLBCACPKHI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly FHLPAAAMKGN EDONHGCODFC;

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x8007EE0", Offset = "0x80064E0", VA = "0x188007EE0")]
	public NHEENLOGAKG(Guid[] AOFOPNGONJH, Vector3[] LEGHMOIFMOP, Quaternion[] GICPCBFPOHF, float[] GELOOKIOCLA, Dictionary<Guid, Vector3> AOIEDGFDHOH, MLLBCACPKHI GOFEAPECJPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x8007E30", Offset = "0x8006430", VA = "0x188007E30", Slot = "4")]
	public override bool NJPLCABILLF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public interface DIPJPNIJOON<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LJAEGJIOAMB([In] OHPAGANPLDP<TData> OJOABOLHHIH);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool IGPOOGADCBI([In] JDKKKFDBMLL BIFCJMJPKEG);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IGPOOGADCBI([In] OCAJMMNBHDO BIFCJMJPKEG);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool ODBKIMILCDF();
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class NHLCIAFLEOG<TData> : IKOICLDPMHH<DIPJPNIJOON<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x479A440", Offset = "0x4798A40", VA = "0x18479A440")]
	public NHLCIAFLEOG(DIPJPNIJOON<TData> GOFEAPECJPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x5692580", Offset = "0x5690B80", VA = "0x185692580", Slot = "4")]
	public override bool NJPLCABILLF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public class NEHJDLKBIEL<TData> : IKOICLDPMHH<DIPJPNIJOON<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly JDKKKFDBMLL JFMPKLHCNEK;

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x5688350", Offset = "0x5686950", VA = "0x185688350")]
	public NEHJDLKBIEL(Vector3 DIGMIMEEANK, bool JGLDLKAGOML, DIPJPNIJOON<TData> GOFEAPECJPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x4FA3F10", Offset = "0x4FA2510", VA = "0x184FA3F10", Slot = "4")]
	public override bool NJPLCABILLF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public class CLGHJEJPHKK<TData> : IKOICLDPMHH<DIPJPNIJOON<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly OCAJMMNBHDO JFMPKLHCNEK;

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x687C2D0", Offset = "0x687A8D0", VA = "0x18687C2D0")]
	public CLGHJEJPHKK(Guid BPPPBEHDNOG, int KHMHPNKMLMD, Vector3 NHLFNDFGAHK, Quaternion CFFPEJBOBIA, float OFCEKCJNBGJ, bool JGLDLKAGOML, DIPJPNIJOON<TData> GOFEAPECJPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x687C270", Offset = "0x687A870", VA = "0x18687C270", Slot = "4")]
	public override bool NJPLCABILLF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public class JNKFHMCGCMI<TData> : IKOICLDPMHH<DIPJPNIJOON<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly OHPAGANPLDP<TData> JFMPKLHCNEK;

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x51DCCA0", Offset = "0x51DB2A0", VA = "0x1851DCCA0")]
	public JNKFHMCGCMI(TData OKOGHNMMGGB, bool GEIELIMOBOC, DIPJPNIJOON<TData> GOFEAPECJPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x4BF27D0", Offset = "0x4BF0DD0", VA = "0x184BF27D0", Slot = "4")]
	public override bool NJPLCABILLF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public struct JDKKKFDBMLL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public readonly Vector3 DIGMIMEEANK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public readonly bool JGLDLKAGOML;

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x8007BB0", Offset = "0x80061B0", VA = "0x188007BB0")]
	public JDKKKFDBMLL(Vector3 DIGMIMEEANK, bool JGLDLKAGOML)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public struct OCAJMMNBHDO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public readonly Guid BPPPBEHDNOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public readonly int KHMHPNKMLMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public readonly Vector3 NHLFNDFGAHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public readonly Quaternion CFFPEJBOBIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public readonly float OFCEKCJNBGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public readonly bool JGLDLKAGOML;

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x8008140", Offset = "0x8006740", VA = "0x188008140")]
	public OCAJMMNBHDO(Guid BPPPBEHDNOG, int KHMHPNKMLMD, Vector3 NHLFNDFGAHK, Quaternion CFFPEJBOBIA, float OFCEKCJNBGJ, bool JGLDLKAGOML)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public struct OHPAGANPLDP<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public readonly TData OKOGHNMMGGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public readonly bool GEIELIMOBOC;

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x57CED50", Offset = "0x57CD350", VA = "0x1857CED50")]
	public OHPAGANPLDP(TData OKOGHNMMGGB, bool GEIELIMOBOC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public interface PHALBKPEGII<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NJPLCABILLF([In] GMHMIAPGCIC<TData> AJHPOGEPCLD);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NJPLCABILLF([In] OEPIODJNLCI<TData> AJHPOGEPCLD);
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public interface KOIPIONDMDD<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LJAEGJIOAMB([In] DJDMJGBHPAG<TData> LDBMNAHOKBE);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool IGPOOGADCBI([In] IBLDBIFJPIH BIFCJMJPKEG);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool ODBKIMILCDF();
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public class OIMIJGDMECM<TData> : IKOICLDPMHH<PHALBKPEGII<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly GMHMIAPGCIC<TData> AJHPOGEPCLD;

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x57D6230", Offset = "0x57D4830", VA = "0x1857D6230")]
	public OIMIJGDMECM(IEnumerable<TData> CIEPDNPGAMI, Vector3 EAIEGNCFGOH, bool GEIELIMOBOC, PHALBKPEGII<TData> GOFEAPECJPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x4BF27D0", Offset = "0x4BF0DD0", VA = "0x184BF27D0", Slot = "4")]
	public override bool NJPLCABILLF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public class KJJEFECHAGN<TData> : IKOICLDPMHH<KOIPIONDMDD<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x479A440", Offset = "0x4798A40", VA = "0x18479A440")]
	public KJJEFECHAGN(KOIPIONDMDD<TData> GOFEAPECJPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x4DA1A50", Offset = "0x4DA0050", VA = "0x184DA1A50", Slot = "4")]
	public override bool NJPLCABILLF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public class FCDKJKHCIKI<TData> : IKOICLDPMHH<KOIPIONDMDD<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly DJDMJGBHPAG<TData> AJHPOGEPCLD;

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x4BF2890", Offset = "0x4BF0E90", VA = "0x184BF2890")]
	public FCDKJKHCIKI(IEnumerable<TData> CIEPDNPGAMI, bool GEIELIMOBOC, KOIPIONDMDD<TData> GOFEAPECJPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x4BF27D0", Offset = "0x4BF0DD0", VA = "0x184BF27D0", Slot = "4")]
	public override bool NJPLCABILLF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public class PCLDKPAHMLG<TData> : IKOICLDPMHH<PHALBKPEGII<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly OEPIODJNLCI<TData> AJHPOGEPCLD;

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x58B0BA0", Offset = "0x58AF1A0", VA = "0x1858B0BA0")]
	public PCLDKPAHMLG(IEnumerable<TData> CIEPDNPGAMI, Vector3 DKKOPEBIBLC, JMMLOBBAPMN FKPOEGNJMFP, bool GEIELIMOBOC, PHALBKPEGII<TData> GOFEAPECJPJ, Space OPNKNPKOJEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x478A940", Offset = "0x4788F40", VA = "0x18478A940", Slot = "4")]
	public override bool NJPLCABILLF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public class IPJGEJDGDMP<TData> : IKOICLDPMHH<KOIPIONDMDD<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly IBLDBIFJPIH AJHPOGEPCLD;

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x4FA3F70", Offset = "0x4FA2570", VA = "0x184FA3F70")]
	public IPJGEJDGDMP(Vector3 EAIEGNCFGOH, KOIPIONDMDD<TData> GOFEAPECJPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x4FA3F10", Offset = "0x4FA2510", VA = "0x184FA3F10", Slot = "4")]
	public override bool NJPLCABILLF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public struct GMHMIAPGCIC<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public readonly IEnumerable<TData> CIEPDNPGAMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public readonly Vector3 EAIEGNCFGOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public readonly bool GEIELIMOBOC;

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x4D9D310", Offset = "0x4D9B910", VA = "0x184D9D310")]
	public GMHMIAPGCIC(IEnumerable<TData> CIEPDNPGAMI, Vector3 EAIEGNCFGOH, bool GEIELIMOBOC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public struct DJDMJGBHPAG<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public readonly IEnumerable<TData> CIEPDNPGAMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public readonly bool GEIELIMOBOC;

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x6D14510", Offset = "0x6D12B10", VA = "0x186D14510")]
	public DJDMJGBHPAG(IEnumerable<TData> CIEPDNPGAMI, bool GEIELIMOBOC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public struct OEPIODJNLCI<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	public readonly IEnumerable<TData> CIEPDNPGAMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	public readonly Vector3 DKKOPEBIBLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public readonly JMMLOBBAPMN FKPOEGNJMFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public readonly bool GEIELIMOBOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public readonly Space OPNKNPKOJEE;

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x57BA060", Offset = "0x57B8660", VA = "0x1857BA060")]
	public OEPIODJNLCI(IEnumerable<TData> CIEPDNPGAMI, Vector3 DKKOPEBIBLC, JMMLOBBAPMN FKPOEGNJMFP, bool GEIELIMOBOC, Space OPNKNPKOJEE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public struct IBLDBIFJPIH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public readonly Vector3 EAIEGNCFGOH;

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x2BD0DF0", Offset = "0x2BCF3F0", VA = "0x182BD0DF0")]
	public IBLDBIFJPIH(Vector3 EAIEGNCFGOH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public enum JMMLOBBAPMN
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
public interface INEAOPFMHPH
{
	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NJPLCABILLF([In] KLMBHIAHDCK FKJMAOOFKDA);
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public class ELIODGKMMON : IKOICLDPMHH<INEAOPFMHPH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private readonly KLMBHIAHDCK FKJMAOOFKDA;

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x80068C0", Offset = "0x8004EC0", VA = "0x1880068C0")]
	public ELIODGKMMON(bool GEIELIMOBOC, INEAOPFMHPH GOFEAPECJPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x8006810", Offset = "0x8004E10", VA = "0x188006810", Slot = "4")]
	public override bool NJPLCABILLF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public readonly struct KLMBHIAHDCK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public readonly bool GEIELIMOBOC;

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x2BCE300", Offset = "0x2BCC900", VA = "0x182BCE300")]
	public KLMBHIAHDCK(bool GEIELIMOBOC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public interface KIBNEHHBGNE<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NJPLCABILLF([In] JJFMCLOGIBA<TData> HCHBONHBFLN);

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NJPLCABILLF([In] HKNLDGDLFAI<TData> HCHBONHBFLN);
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public interface EKBHABNAPCJ<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LJAEGJIOAMB([In] PPACEBKMPFM<TData> OJOABOLHHIH);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool IGPOOGADCBI([In] JOFGJEPHKKA BIFCJMJPKEG);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool ODBKIMILCDF();
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public class FPFIJCGOHNC<TData> : IKOICLDPMHH<KIBNEHHBGNE<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private readonly JJFMCLOGIBA<TData> HCHBONHBFLN;

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x4C8EFC0", Offset = "0x4C8D5C0", VA = "0x184C8EFC0")]
	public FPFIJCGOHNC(IEnumerable<TData> CIEPDNPGAMI, Quaternion EAIEGNCFGOH, Vector3? CLIDEFKMLPF, bool HDOBOOINOPB, bool GEIELIMOBOC, KIBNEHHBGNE<TData> GOFEAPECJPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x4BF27D0", Offset = "0x4BF0DD0", VA = "0x184BF27D0", Slot = "4")]
	public override bool NJPLCABILLF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public class GOPBJMHJKBG<TData> : IKOICLDPMHH<EKBHABNAPCJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x479A440", Offset = "0x4798A40", VA = "0x18479A440")]
	public GOPBJMHJKBG(EKBHABNAPCJ<TData> GOFEAPECJPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x4DA1A50", Offset = "0x4DA0050", VA = "0x184DA1A50", Slot = "4")]
	public override bool NJPLCABILLF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public class OHAJFDMPKJP<TData> : IKOICLDPMHH<EKBHABNAPCJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly PPACEBKMPFM<TData> HCHBONHBFLN;

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x57CDBC0", Offset = "0x57CC1C0", VA = "0x1857CDBC0")]
	public OHAJFDMPKJP(IEnumerable<TData> CIEPDNPGAMI, bool GEIELIMOBOC, EKBHABNAPCJ<TData> GOFEAPECJPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x4BF27D0", Offset = "0x4BF0DD0", VA = "0x184BF27D0", Slot = "4")]
	public override bool NJPLCABILLF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public class KHADNMFAJEO<TData> : IKOICLDPMHH<KIBNEHHBGNE<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private readonly HKNLDGDLFAI<TData> HCHBONHBFLN;

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x52CDA00", Offset = "0x52CC000", VA = "0x1852CDA00")]
	public KHADNMFAJEO(IEnumerable<TData> CIEPDNPGAMI, Quaternion MOFKKEOHOBJ, JMMLOBBAPMN NCEHADCGHFM, Vector3? CLIDEFKMLPF, bool HDOBOOINOPB, bool GEIELIMOBOC, Space OPNKNPKOJEE, KIBNEHHBGNE<TData> GOFEAPECJPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x478A940", Offset = "0x4788F40", VA = "0x18478A940", Slot = "4")]
	public override bool NJPLCABILLF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public class CIFCFPHIBHD<TData> : IKOICLDPMHH<EKBHABNAPCJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private readonly JOFGJEPHKKA HCHBONHBFLN;

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x67A80A0", Offset = "0x67A66A0", VA = "0x1867A80A0")]
	public CIFCFPHIBHD(Quaternion EAIEGNCFGOH, Vector3? CLIDEFKMLPF, bool HDOBOOINOPB, EKBHABNAPCJ<TData> GOFEAPECJPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x4FA3F10", Offset = "0x4FA2510", VA = "0x184FA3F10", Slot = "4")]
	public override bool NJPLCABILLF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public struct JJFMCLOGIBA<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public readonly IEnumerable<TData> CIEPDNPGAMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public readonly Quaternion EAIEGNCFGOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public readonly Vector3? CLIDEFKMLPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public readonly bool HDOBOOINOPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public readonly bool GEIELIMOBOC;

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x51D6010", Offset = "0x51D4610", VA = "0x1851D6010")]
	public JJFMCLOGIBA(IEnumerable<TData> CIEPDNPGAMI, Quaternion EAIEGNCFGOH, Vector3? CLIDEFKMLPF, bool HDOBOOINOPB, bool GEIELIMOBOC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public struct PPACEBKMPFM<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public readonly IEnumerable<TData> CIEPDNPGAMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public readonly bool GEIELIMOBOC;

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x59024D0", Offset = "0x5900AD0", VA = "0x1859024D0")]
	public PPACEBKMPFM(IEnumerable<TData> CIEPDNPGAMI, bool GEIELIMOBOC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public struct HKNLDGDLFAI<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public readonly IEnumerable<TData> CIEPDNPGAMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public readonly Quaternion MOFKKEOHOBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public readonly JMMLOBBAPMN NCEHADCGHFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public readonly Vector3? CLIDEFKMLPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public readonly bool HDOBOOINOPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public readonly bool GEIELIMOBOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public readonly Space OPNKNPKOJEE;

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x4E1A980", Offset = "0x4E18F80", VA = "0x184E1A980")]
	public HKNLDGDLFAI(IEnumerable<TData> CIEPDNPGAMI, Quaternion MOFKKEOHOBJ, JMMLOBBAPMN NCEHADCGHFM, Vector3? CLIDEFKMLPF, bool HDOBOOINOPB, bool GEIELIMOBOC, Space OPNKNPKOJEE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public struct JOFGJEPHKKA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public readonly Quaternion EAIEGNCFGOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public readonly Vector3? CLIDEFKMLPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public readonly bool HDOBOOINOPB;

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x5F00E60", Offset = "0x5EFF460", VA = "0x185F00E60")]
	public JOFGJEPHKKA(Quaternion EAIEGNCFGOH, Vector3? CLIDEFKMLPF, bool HDOBOOINOPB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public interface IGPKJEIKPEK<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LJAEGJIOAMB([In] DIKDJIOIHKI<TData> OJOABOLHHIH);

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool IGPOOGADCBI([In] OACBBPPBNLG BIFCJMJPKEG);

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IGPOOGADCBI([In] AAJAICDCAFB BIFCJMJPKEG);

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IGPOOGADCBI([In] LCENMMAJJHE BIFCJMJPKEG);

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool ODBKIMILCDF();
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public class IENKIGFPFEM<TData> : IKOICLDPMHH<IGPKJEIKPEK<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private readonly LCENMMAJJHE CODKKHHDGMO;

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x4F58700", Offset = "0x4F56D00", VA = "0x184F58700")]
	public IENKIGFPFEM(Vector3 FBBLFPKLIEO, float OKDFECFEJGM, Vector3 CLIDEFKMLPF, bool LEBGPOPHJPJ, bool ABGOEDOINLD, IGPKJEIKPEK<TData> GOFEAPECJPJ, Space OPNKNPKOJEE = Space.Self)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x4F586A0", Offset = "0x4F56CA0", VA = "0x184F586A0", Slot = "4")]
	public override bool NJPLCABILLF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public class GAODIDBOCMI<TData> : IKOICLDPMHH<IGPKJEIKPEK<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x479A440", Offset = "0x4798A40", VA = "0x18479A440")]
	public GAODIDBOCMI(IGPKJEIKPEK<TData> GOFEAPECJPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x4D25940", Offset = "0x4D23F40", VA = "0x184D25940", Slot = "4")]
	public override bool NJPLCABILLF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
public class BLOHCEMNGCA<TData> : IKOICLDPMHH<IGPKJEIKPEK<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private readonly DIKDJIOIHKI<TData> CODKKHHDGMO;

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x620F780", Offset = "0x620DD80", VA = "0x18620F780")]
	public BLOHCEMNGCA(IEnumerable<TData> CIEPDNPGAMI, bool GEIELIMOBOC, IGPKJEIKPEK<TData> GOFEAPECJPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x4BF27D0", Offset = "0x4BF0DD0", VA = "0x184BF27D0", Slot = "4")]
	public override bool NJPLCABILLF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
public class OKDDMPBNABO<TData> : IKOICLDPMHH<IGPKJEIKPEK<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private readonly AAJAICDCAFB CODKKHHDGMO;

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x57D7110", Offset = "0x57D5710", VA = "0x1857D7110")]
	public OKDDMPBNABO(float ICFMEAPOOEO, bool DJFHKHPBADK, Vector3 CLIDEFKMLPF, IGPKJEIKPEK<TData> GOFEAPECJPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x57D7040", Offset = "0x57D5640", VA = "0x1857D7040", Slot = "4")]
	public override bool NJPLCABILLF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
public class CEDHKGLEEGH<TData> : IKOICLDPMHH<IGPKJEIKPEK<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private readonly OACBBPPBNLG CODKKHHDGMO;

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x6797D10", Offset = "0x6796310", VA = "0x186797D10")]
	public CEDHKGLEEGH(float OKDFECFEJGM, Vector3 CLIDEFKMLPF, IGPKJEIKPEK<TData> GOFEAPECJPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x4FA3F10", Offset = "0x4FA2510", VA = "0x184FA3F10", Slot = "4")]
	public override bool NJPLCABILLF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
public struct LCENMMAJJHE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public readonly Vector3 FBBLFPKLIEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public readonly float OKDFECFEJGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public readonly Vector3 CLIDEFKMLPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	public readonly bool JGLDLKAGOML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	public readonly Space OPNKNPKOJEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	public readonly bool ABGOEDOINLD;

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x8007DF0", Offset = "0x80063F0", VA = "0x188007DF0")]
	public LCENMMAJJHE(Vector3 FBBLFPKLIEO, float OKDFECFEJGM, Vector3 CLIDEFKMLPF, bool JGLDLKAGOML, bool GGIKLGMCOBH, Space OPNKNPKOJEE = Space.Self)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public struct DIKDJIOIHKI<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public readonly IEnumerable<TData> CIEPDNPGAMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public readonly bool GEIELIMOBOC;

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x6D12220", Offset = "0x6D10820", VA = "0x186D12220")]
	public DIKDJIOIHKI(IEnumerable<TData> CIEPDNPGAMI, bool GEIELIMOBOC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
public struct AAJAICDCAFB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public readonly float ICFMEAPOOEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public readonly bool DJFHKHPBADK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public readonly Vector3 CLIDEFKMLPF;

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x8006520", Offset = "0x8004B20", VA = "0x188006520")]
	public AAJAICDCAFB(float ICFMEAPOOEO, bool DJFHKHPBADK, Vector3 CLIDEFKMLPF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public struct OACBBPPBNLG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public readonly float OKDFECFEJGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public readonly Vector3 CLIDEFKMLPF;

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x5EC10B0", Offset = "0x5EBF6B0", VA = "0x185EC10B0")]
	public OACBBPPBNLG(float OKDFECFEJGM, Vector3 CLIDEFKMLPF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public struct FHLPAAAMKGN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public readonly Guid[] CIEPDNPGAMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public readonly bool MEHCFPNJPIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public readonly bool OFOFGDFAJLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public readonly bool OCGNEPCPCFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public readonly Vector3[] LEGHMOIFMOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public readonly Quaternion[] GICPCBFPOHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public readonly float[] GELOOKIOCLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public readonly Dictionary<Guid, Vector3> AOIEDGFDHOH;

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x8006AF0", Offset = "0x80050F0", VA = "0x188006AF0")]
	public FHLPAAAMKGN(Guid[] AOFOPNGONJH, Vector3[] LEGHMOIFMOP, Quaternion[] GICPCBFPOHF, float[] GELOOKIOCLA, Dictionary<Guid, Vector3> AOIEDGFDHOH, bool MEHCFPNJPIF = true, bool OFOFGDFAJLO = true, bool OCGNEPCPCFH = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x8006920", Offset = "0x8004F20", VA = "0x188006920")]
	private static void GDFKLIJHHNF(Dictionary<Guid, Vector3> AOIEDGFDHOH, int OKLAHEOPLBI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public static class PFCABMHOLOI
{
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	private struct CMNCOMJECOK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public bool APJGBNBBCIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public DCNOMJHNEOK GCIHOPCMPFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public DCNOMJHNEOK PBLGMGKOIKI;
	}

	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private static CMNCOMJECOK IMOOKMFJHPC;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static CancellationToken JMHGIAHOODA
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x8008370", Offset = "0x8006970", VA = "0x188008370")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	internal static DCNOMJHNEOK GCIHOPCMPFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x80082D0", Offset = "0x80068D0", VA = "0x1880082D0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x80084F0", Offset = "0x8006AF0", VA = "0x1880084F0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x8008180", Offset = "0x8006780", VA = "0x188008180")]
	[BNHIEDNKDNA.CCDABDMPDDG]
	internal static void BGFKKOPDAMP(DCNOMJHNEOK KEKDBNKNBGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x8008390", Offset = "0x8006990", VA = "0x188008390")]
	public static void MGCNIAHBIMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x8008280", Offset = "0x8006880", VA = "0x188008280")]
	private static DCNOMJHNEOK CEIDFHNEOND(DCNOMJHNEOK FJADHAPEHDD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
public static class FBJGHNJBMGJ
{
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	public enum NKCKEIHNCDL
	{
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		ICreationContextObject,
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		Guid
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x3B1D140", Offset = "0x3B1B740", VA = "0x183B1D140")]
	public static void GFKLHMMDHFO<T>(T EFKLKBOLJNG, NKCKEIHNCDL JLPANLJHHFI) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x3B1D0E0", Offset = "0x3B1B6E0", VA = "0x183B1D0E0")]
	public static void GFKLHMMDHFO<T>(T EFKLKBOLJNG) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x3B1D000", Offset = "0x3B1B600", VA = "0x183B1D000")]
	public static void GFKLHMMDHFO<T, TImpl, T>() where T : class where TImpl : notnull, T where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x3B1CF90", Offset = "0x3B1B590", VA = "0x183B1CF90")]
	public static void GBDOCFKODHO<T>(T EFKLKBOLJNG) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x3B1D360", Offset = "0x3B1B960", VA = "0x183B1D360")]
	public static T KBGIPADPFGF<T>(NKCKEIHNCDL JLPANLJHHFI) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x3B1D400", Offset = "0x3B1BA00", VA = "0x183B1D400")]
	public static bool MGMGGGDLPBE<T>(NKCKEIHNCDL JLPANLJHHFI, T? APJJAKENBAJ, [Out][MaybeNullWhen(false)][NotNullWhen(true)] T MFGOPLBDBPH) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x3B1CE90", Offset = "0x3B1B490", VA = "0x183B1CE90")]
	public static bool FHDLJIMLFNN<T>(NKCKEIHNCDL JLPANLJHHFI, [Out][NotNullWhen(true)][MaybeNullWhen(false)] T LLJONALEANL) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x3B1D2C0", Offset = "0x3B1B8C0", VA = "0x183B1D2C0")]
	public static bool GMGELBLIAGK<T>(NKCKEIHNCDL JLPANLJHHFI) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x3B1D280", Offset = "0x3B1B880", VA = "0x183B1D280")]
	public static T KBGIPADPFGF<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x3B1D530", Offset = "0x3B1BB30", VA = "0x183B1D530")]
	public static bool MGMGGGDLPBE<T>(T APJJAKENBAJ, [Out] T MFGOPLBDBPH) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x3B1D280", Offset = "0x3B1B880", VA = "0x183B1D280")]
	public static bool GMGELBLIAGK<T>() where T : class
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
internal static class GIDIJKGFFJL
{
	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x8006F30", Offset = "0x8005530", VA = "0x188006F30")]
	public static void CEODGCDAIBB(IEnumerable MHKKLCCALJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x3B4DF30", Offset = "0x3B4C530", VA = "0x183B4DF30")]
	public static void CEODGCDAIBB<T>(T[] DDENONPPKCL) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x3B4E110", Offset = "0x3B4C710", VA = "0x183B4E110")]
	public static void CEODGCDAIBB<T>(T DANMPOCKLCI) where T : notnull, Enum
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
