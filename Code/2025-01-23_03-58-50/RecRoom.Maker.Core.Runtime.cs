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
		[Cpp2IlInjected.Address(RVA = "0x8E06A0", Offset = "0x8DEEA0", VA = "0x1808E06A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6F9B930", Offset = "0x6F9A130", VA = "0x186F9B930")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8E0B60", Offset = "0x8DF360", VA = "0x1808E0B60")]
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
		[Cpp2IlInjected.Address(RVA = "0x8E0BA0", Offset = "0x8DF3A0", VA = "0x1808E0BA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6F9BF50", Offset = "0x6F9A750", VA = "0x186F9BF50", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x21F3FE0", Offset = "0x21F27E0", VA = "0x1821F3FE0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface BOHLJBICADL<TData, TReturn>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TReturn DELGDCCEFEL(TData INCBEIDOHDO);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface HDNFPBEPIFP<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ClearHoverTarget(IEFPIBDDGGG NPIAJDKKINK);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool SetHoverTarget(TData BIINCLMPDMO, Collider IPEIJLHBLLN, IEFPIBDDGGG NPIAJDKKINK, [Optional] LDFEEADCCGN? FFBFILAAMIK);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool TryGetHoverTarget([Out] TData BIINCLMPDMO);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool TryGetHoverCollider([Out] Collider IPEIJLHBLLN);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface FJKPCBKIAFB<TData> : MMGOBPPPHBC, GGMPPOCINHN<TData>, DIJEMLBFENB<TData>, DKLOIKEGFFD<TData>, MKGEDHCACPN, GICLHKIHFEA<TData>, IHGJPKGDLAJ, DOJLFDNDKOG
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface GICLHKIHFEA<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool Raycast(Vector3 EJDLMDEMKCD, Vector3 NGBCGJCGHJG, float HFFBJNAMAGI, [Out] T HLBKCBPECKC, [Out] Vector3 OPAOPCCADOP, [Out] Collider IPEIJLHBLLN);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int SpherecastPick(Vector3 EJDLMDEMKCD, Vector3 NGBCGJCGHJG, float EMEDCLHDFME, float HFFBJNAMAGI, T[] NENLLLHBDLK, [Out] Vector3 LAAHDJHKFJG, [Out] Collider BNNFFBFPJGH);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int SpherePick(Vector3 EJDLMDEMKCD, float EMEDCLHDFME, Vector3 HEPIGENMFMP, T[] NENLLLHBDLK);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool TryGetObjectFromColliderInCurrentScope(Collider JFOLGMCMDLO, [Out] T MGOAKJGEDLH);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface MMGOBPPPHBC
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Bounds HAOININHHMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	Transform OINPEMOHIEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	Bounds GFHCPNOAABH
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Transform NGLIICOGCLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	Vector3 LDDMNNONICM
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool PLLDFIKLPEP
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
	void SetSelectionBoundsDirty(bool JCFGLOGGPBG = true, int PINMPHPFPOG = 0);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void ShouldHideSelectionBoundsPreview(bool FEOHJPIPPAP, object DJIMHLGHFGI);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface DOJLFDNDKOG
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	GCOJJNPJFGN DJEGJFKPBPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface HKEJIFGLJLL
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool IEMOALMFOCA
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool HJNEAOKIPHG
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool ICAHHCGHIIB
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
	void TrySetPreviousCloneMapping(Dictionary<Guid, Guid> PEKCAAKBPBC);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface DKLOIKEGFFD<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool JEILJFMMMDG
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	int NFCKEACADOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<TData> ALKFGJJNNNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IsSelected(TData DEDDGCENOOL);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IsSelectable(TData DEDDGCENOOL);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface GGMPPOCINHN<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void RenderHoverHighlight(T INCBEIDOHDO, [Optional] LDFEEADCCGN? CPOJFOEHPBN, bool CJNPMJCEPLN = true);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RenderHoverHighlight(int NELOIEKKMHO, IEnumerable<T> CNGGBMCFJGE, bool CJNPMJCEPLN = true);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RenderHoverHighlight(int NELOIEKKMHO, IEnumerable<T> CNGGBMCFJGE, LDFEEADCCGN CPOJFOEHPBN, bool CJNPMJCEPLN = true);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface IHGJPKGDLAJ
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnSelectionPickedUp();

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnSelectionReleased();
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface MKGEDHCACPN
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool EPPOBLHFPAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool PPMEMCGCABL
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	bool JMAMCFOABIC
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	bool EMEGMAFPLBL
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public abstract class CKMILMJBJOO<TReceiver> : EENPDGNGMCM<TReceiver, bool> where TReceiver : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3CD5E10", Offset = "0x3CD4610", VA = "0x183CD5E10")]
	public CKMILMJBJOO(TReceiver HBCKNOINJJA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public abstract class KPHMIMPDPFH<TReceiver, TFromTask> : EENPDGNGMCM<TReceiver, Task<TFromTask>>
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3CD5E10", Offset = "0x3CD4610", VA = "0x183CD5E10")]
	public KPHMIMPDPFH(TReceiver HBCKNOINJJA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public abstract class EENPDGNGMCM<TReceiver, TFromExecute> where TReceiver : notnull where TFromExecute : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	protected TReceiver HBCKNOINJJA;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x3CCD2A0", Offset = "0x3CCBAA0", VA = "0x183CCD2A0")]
	public EENPDGNGMCM(TReceiver HBCKNOINJJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TFromExecute FPGKMMGLAFA();
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public abstract class NODFKKJBGCF<TReceiver, TResult> : EENPDGNGMCM<TReceiver, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x3CD5E10", Offset = "0x3CD4610", VA = "0x183CD5E10")]
	public NODFKKJBGCF(TReceiver HBCKNOINJJA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct GKGDKAFFAFI<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public TGroup PBEIMCEKNMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public TData PNMPKKMKPMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public IEnumerable<TData> OMCLEABHHKI;

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x2204CA0", Offset = "0x22034A0", VA = "0x182204CA0")]
	public GKGDKAFFAFI(TGroup MMPLJIOEHMK, TData GBNFIMMGLAF, IEnumerable<TData> CFOCMBCLJLO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct JGCCDADCJJF<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public TGroup PBEIMCEKNMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public IEnumerable<TData> OMCLEABHHKI;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0xE64E60", Offset = "0xE63660", VA = "0x180E64E60")]
	public JGCCDADCJJF(TGroup MMPLJIOEHMK, IEnumerable<TData> CFOCMBCLJLO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct EFHMPDABBPA<TGroup> where TGroup : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public TGroup PBEIMCEKNMM;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x95E8E0", Offset = "0x95D0E0", VA = "0x18095E8E0")]
	public EFHMPDABBPA(TGroup MMPLJIOEHMK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct BCDFHJDCLAJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public IEnumerable<Guid> OMCLEABHHKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public Guid MKOJFLOEOHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public readonly bool BMODDCJEACO;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6F99F30", Offset = "0x6F98730", VA = "0x186F99F30")]
	public BCDFHJDCLAJ(IEnumerable<Guid> CFOCMBCLJLO, Guid KEAIAJFAMLG, bool MIPDANJBAMD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct MEOJFGHAPBB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public Guid MKOJFLOEOHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public readonly bool BMODDCJEACO;

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x1EC0AC0", Offset = "0x1EBF2C0", VA = "0x181EC0AC0")]
	public MEOJFGHAPBB(Guid KEAIAJFAMLG, bool MIPDANJBAMD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface LAMCGGJHGBO<TGroup, TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JEBHJKJIPPG ELNBFKINMGG(GKGDKAFFAFI<TGroup, TData> HIMJEPJPECK);

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "1")]
	JEBHJKJIPPG EJMHBFAJJDD(GKGDKAFFAFI<TGroup, TData> HIMJEPJPECK);

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "2")]
	JEBHJKJIPPG JEJONLEIACG(JGCCDADCJJF<TGroup, TData> HIMJEPJPECK);

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	JEBHJKJIPPG NJGDPAMOCBP(EFHMPDABBPA<TGroup> HIMJEPJPECK);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface EEIGIJLJFMA
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<JEBHJKJIPPG> ELNBFKINMGG(BCDFHJDCLAJ HIMJEPJPECK);

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<JEBHJKJIPPG> EJMHBFAJJDD(MEOJFGHAPBB HIMJEPJPECK);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class BIOFCGGHFMA<TGroup, TData> : NODFKKJBGCF<LAMCGGJHGBO<TGroup, TData>, JEBHJKJIPPG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly JGCCDADCJJF<TGroup, TData> HIMJEPJPECK;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x53BB680", Offset = "0x53B9E80", VA = "0x1853BB680")]
	public BIOFCGGHFMA(TGroup MMPLJIOEHMK, IEnumerable<TData> CFOCMBCLJLO, LAMCGGJHGBO<TGroup, TData> HBCKNOINJJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x53BB5C0", Offset = "0x53B9DC0", VA = "0x1853BB5C0", Slot = "4")]
	public override JEBHJKJIPPG FPGKMMGLAFA()
	{
		return default(JEBHJKJIPPG);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class OKFPBLGMLMM<TGroup, TData> : NODFKKJBGCF<LAMCGGJHGBO<TGroup, TData>, JEBHJKJIPPG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly GKGDKAFFAFI<TGroup, TData> HIMJEPJPECK;

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x4170D00", Offset = "0x416F500", VA = "0x184170D00")]
	public OKFPBLGMLMM(TGroup MMPLJIOEHMK, TData HIMMGEKKHPA, IEnumerable<TData> CFOCMBCLJLO, LAMCGGJHGBO<TGroup, TData> HBCKNOINJJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x4B5A980", Offset = "0x4B59180", VA = "0x184B5A980", Slot = "4")]
	public override JEBHJKJIPPG FPGKMMGLAFA()
	{
		return default(JEBHJKJIPPG);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class IIAJKFHOMCE<TGroup, TData> : NODFKKJBGCF<LAMCGGJHGBO<TGroup, TData>, JEBHJKJIPPG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly EFHMPDABBPA<TGroup> HIMJEPJPECK;

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x4313D40", Offset = "0x4312540", VA = "0x184313D40")]
	public IIAJKFHOMCE(TGroup MMPLJIOEHMK, LAMCGGJHGBO<TGroup, TData> HBCKNOINJJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x4313C80", Offset = "0x4312480", VA = "0x184313C80", Slot = "4")]
	public override JEBHJKJIPPG FPGKMMGLAFA()
	{
		return default(JEBHJKJIPPG);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class AHBFFLGKAID<TGroup, TData> : NODFKKJBGCF<LAMCGGJHGBO<TGroup, TData>, JEBHJKJIPPG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly GKGDKAFFAFI<TGroup, TData> HIMJEPJPECK;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x4170D00", Offset = "0x416F500", VA = "0x184170D00")]
	public AHBFFLGKAID(TGroup MMPLJIOEHMK, TData GBNFIMMGLAF, IEnumerable<TData> CFOCMBCLJLO, LAMCGGJHGBO<TGroup, TData> HBCKNOINJJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x4170C20", Offset = "0x416F420", VA = "0x184170C20", Slot = "4")]
	public override JEBHJKJIPPG FPGKMMGLAFA()
	{
		return default(JEBHJKJIPPG);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class EGLMKPNNIOC : KPHMIMPDPFH<EEIGIJLJFMA, JEBHJKJIPPG>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private struct COFBPABAJPF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public AsyncTaskMethodBuilder<JEBHJKJIPPG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public EGLMKPNNIOC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private TaskAwaiter<JEBHJKJIPPG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6F99FB0", Offset = "0x6F987B0", VA = "0x186F99FB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6F9A240", Offset = "0x6F98A40", VA = "0x186F9A240", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private BCDFHJDCLAJ HIMJEPJPECK;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6F9A3A0", Offset = "0x6F98BA0", VA = "0x186F9A3A0")]
	public EGLMKPNNIOC(IEnumerable<Guid> DEGBIGOPPBP, Guid KEAIAJFAMLG, bool MIPDANJBAMD, EEIGIJLJFMA HBCKNOINJJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6F9A2B0", Offset = "0x6F98AB0", VA = "0x186F9A2B0", Slot = "4")]
	[AsyncStateMachine(typeof(COFBPABAJPF))]
	public override Task<JEBHJKJIPPG> FPGKMMGLAFA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class HBEFPABKPPH : KPHMIMPDPFH<EEIGIJLJFMA, JEBHJKJIPPG>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private struct PCEJMIOOEIH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public AsyncTaskMethodBuilder<JEBHJKJIPPG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public HBEFPABKPPH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private TaskAwaiter<JEBHJKJIPPG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6F9BC40", Offset = "0x6F9A440", VA = "0x186F9BC40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6F9BEE0", Offset = "0x6F9A6E0", VA = "0x186F9BEE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly MEOJFGHAPBB HIMJEPJPECK;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6F9AE50", Offset = "0x6F99650", VA = "0x186F9AE50")]
	public HBEFPABKPPH(Guid KEAIAJFAMLG, bool MIPDANJBAMD, EEIGIJLJFMA HBCKNOINJJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6F9AD60", Offset = "0x6F99560", VA = "0x186F9AD60", Slot = "4")]
	[AsyncStateMachine(typeof(PCEJMIOOEIH))]
	public override Task<JEBHJKJIPPG> FPGKMMGLAFA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public readonly struct CNNMIBGHICG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly EIBPPMLGNDP JMCHJALKPJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly bool BMODDCJEACO;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6F99F90", Offset = "0x6F98790", VA = "0x186F99F90")]
	public CNNMIBGHICG(EIBPPMLGNDP OMEFIHBHKHG, bool MIPDANJBAMD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface NAILDBMFAHE<TSpawnType> where TSpawnType : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> FPGKMMGLAFA(CNNMIBGHICG CKODKBHLDBG);
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class PMJKFFGHKIN<TSpawnType> : KPHMIMPDPFH<NAILDBMFAHE<TSpawnType>, TSpawnType> where TSpawnType : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private struct INNCEEPKJAI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public AsyncTaskMethodBuilder<TSpawnType> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public PMJKFFGHKIN<TSpawnType> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private TaskAwaiter<TSpawnType> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x43385F0", Offset = "0x4336DF0", VA = "0x1843385F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x3CC8AA0", Offset = "0x3CC72A0", VA = "0x183CC8AA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly CNNMIBGHICG CKODKBHLDBG;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x4C75730", Offset = "0x4C73F30", VA = "0x184C75730")]
	public PMJKFFGHKIN(EIBPPMLGNDP OMEFIHBHKHG, bool MIPDANJBAMD, NAILDBMFAHE<TSpawnType> HBCKNOINJJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x4C75630", Offset = "0x4C73E30", VA = "0x184C75630", Slot = "4")]
	[AsyncStateMachine(typeof(PMJKFFGHKIN<>.INNCEEPKJAI))]
	public override Task<TSpawnType> FPGKMMGLAFA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public readonly struct EIBPPMLGNDP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly bool EICPPKPKDFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public readonly Vector3 EGFJEOGDKFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly Vector3 CMIONGHAGGG;

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6F9A4C0", Offset = "0x6F98CC0", VA = "0x186F9A4C0")]
	public EIBPPMLGNDP(Transform MIKDJDLMOAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6F9A490", Offset = "0x6F98C90", VA = "0x186F9A490")]
	public EIBPPMLGNDP(Vector3 LHHMNOGMEMF, Vector3 BALIIBCILHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x6F9A460", Offset = "0x6F98C60", VA = "0x186F9A460")]
	public static EIBPPMLGNDP IGANKIJEKEL()
	{
		return default(EIBPPMLGNDP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6F9A530", Offset = "0x6F98D30", VA = "0x186F9A530")]
	private EIBPPMLGNDP(bool ENMNGCDBNDP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public struct ADCJKOACKHF<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public TNode KJEEMCBFNGG;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x40FE180", Offset = "0x40FC980", VA = "0x1840FE180")]
	public ADCJKOACKHF(TNode KJEEMCBFNGG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public struct DJOMCNAJCDC<TNode, TReparentOperations> where TNode : notnull where TReparentOperations : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public TNode ADIDKKEOPEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public TReparentOperations DBHPCKMJJJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public DHMIBELOEMP ICPODEKLIID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public readonly bool BMODDCJEACO;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5DEDFF0", Offset = "0x5DEC7F0", VA = "0x185DEDFF0")]
	public DJOMCNAJCDC(TNode ADIDKKEOPEE, TReparentOperations DBHPCKMJJJA, DHMIBELOEMP ICPODEKLIID, bool MIPDANJBAMD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface BPOCIDJMBFK<TNode, TReparentOperations>
{
	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ICBJIJONOFC([In] ADCJKOACKHF<TNode> JCHCJDMEFFN);

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool JLJFFMNICJE([In] DJOMCNAJCDC<TNode, TReparentOperations> NJFMONHBLFK);

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool DOPGOHLPEFB();
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class DCHCLCCMCBE<TNode, TReparentOperations> : CKMILMJBJOO<BPOCIDJMBFK<TNode, TReparentOperations>>
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3CD5E10", Offset = "0x3CD4610", VA = "0x183CD5E10")]
	public DCHCLCCMCBE(BPOCIDJMBFK<TNode, TReparentOperations> HBCKNOINJJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x3CF6FE0", Offset = "0x3CF57E0", VA = "0x183CF6FE0", Slot = "4")]
	public override bool FPGKMMGLAFA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class DCEFNMNLCDA<TNode, TReparentOperations> : CKMILMJBJOO<BPOCIDJMBFK<TNode, TReparentOperations>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private readonly DJOMCNAJCDC<TNode, TReparentOperations> NJFMONHBLFK;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5D91EC0", Offset = "0x5D906C0", VA = "0x185D91EC0")]
	public DCEFNMNLCDA(TNode ADIDKKEOPEE, TReparentOperations DBHPCKMJJJA, DHMIBELOEMP ICPODEKLIID, BPOCIDJMBFK<TNode, TReparentOperations> HBCKNOINJJA, bool MIPDANJBAMD = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x3CC6C20", Offset = "0x3CC5420", VA = "0x183CC6C20", Slot = "4")]
	public override bool FPGKMMGLAFA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class BLKEONDFNLG<TNode, TReparentOperations> : CKMILMJBJOO<BPOCIDJMBFK<TNode, TReparentOperations>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private readonly ADCJKOACKHF<TNode> JCHCJDMEFFN;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x53C0CA0", Offset = "0x53BF4A0", VA = "0x1853C0CA0")]
	public BLKEONDFNLG(TNode EIDDFPNKNDB, BPOCIDJMBFK<TNode, TReparentOperations> HBCKNOINJJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x406CFB0", Offset = "0x406B7B0", VA = "0x18406CFB0", Slot = "4")]
	public override bool FPGKMMGLAFA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public struct IFNNPNJAFPI<TSpawnInfo> where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public TSpawnInfo MGDNDIMEMKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public Vector3 BALIIBCILHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public Quaternion OJEGGOKKPLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public float FKICLIIJEHG;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x430E440", Offset = "0x430CC40", VA = "0x18430E440")]
	public IFNNPNJAFPI(TSpawnInfo MGDNDIMEMKI, Vector3 BALIIBCILHH, Quaternion OJEGGOKKPLF, float FKICLIIJEHG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public interface HFBKNBPAJPP<TSpawnType, TSpawnInfo>
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> GAHGHEEONKK([In] IFNNPNJAFPI<TSpawnInfo> GLFKFMEPAMP, CancellationToken ALKEMFHOMCA);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public class HOAOLHNFKII<TSpawnType, TSpawnInfo> : KPHMIMPDPFH<HFBKNBPAJPP<TSpawnType, TSpawnInfo>, TSpawnType> where TSpawnType : notnull where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly IFNNPNJAFPI<TSpawnInfo> GIOJKAECAOO;

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x4242CB0", Offset = "0x42414B0", VA = "0x184242CB0")]
	public HOAOLHNFKII(TSpawnInfo CHOOOFPEAOK, Vector3 BALIIBCILHH, Quaternion OJEGGOKKPLF, float FKICLIIJEHG, HFBKNBPAJPP<TSpawnType, TSpawnInfo> HBCKNOINJJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x4242BD0", Offset = "0x42413D0", VA = "0x184242BD0", Slot = "4")]
	public override Task<TSpawnType> FPGKMMGLAFA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public readonly struct FPBNGCFFDGN<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public readonly IEnumerable<TData> OMCLEABHHKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public readonly bool BMODDCJEACO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly bool EJPOLIACACP;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x4081090", Offset = "0x407F890", VA = "0x184081090")]
	public FPBNGCFFDGN(IEnumerable<TData> CFOCMBCLJLO, bool MIPDANJBAMD = false, bool MOKGHOHHABF = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface HGFNCFFDAGN<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<JEBHJKJIPPG> FCMANCGJGEE([In] FPBNGCFFDGN<TData> LFOANLCJANB, CancellationToken ALKEMFHOMCA);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class PMHJOBGLAHO<TData> : KPHMIMPDPFH<HGFNCFFDAGN<TData>, JEBHJKJIPPG> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly FPBNGCFFDGN<TData> LHBAEDPFFHK;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x4C75380", Offset = "0x4C73B80", VA = "0x184C75380")]
	public PMHJOBGLAHO(IEnumerable<TData> CFOCMBCLJLO, bool MIPDANJBAMD, HGFNCFFDAGN<TData> HBCKNOINJJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x4242BD0", Offset = "0x42413D0", VA = "0x184242BD0", Slot = "4")]
	public override Task<JEBHJKJIPPG> FPGKMMGLAFA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public struct OHIFKMENPJL<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly T BIINCLMPDMO;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x4B54A80", Offset = "0x4B53280", VA = "0x184B54A80")]
	public OHIFKMENPJL(T HCDMGDADOGB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface FNKBCACODNA<T>
{
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ICBJIJONOFC([In] OHIFKMENPJL<T> MJCEKNACKEC);

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool JLJFFMNICJE();
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface GGHBEKHKJDG<T>
{
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FPGKMMGLAFA([In] KEHJDOLIJJC<T> CNPMMILHPPB);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct KEHJDOLIJJC<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly T BIINCLMPDMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly bool EHIHGIEOBON;

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x4632FC0", Offset = "0x46317C0", VA = "0x184632FC0")]
	public KEHJDOLIJJC(T HCDMGDADOGB, bool PEADOELKBIK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public class CJAEJAFMLDB<T> : CKMILMJBJOO<FNKBCACODNA<T>> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x3CD5E10", Offset = "0x3CD4610", VA = "0x183CD5E10")]
	public CJAEJAFMLDB(FNKBCACODNA<T> HBCKNOINJJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5926A80", Offset = "0x5925280", VA = "0x185926A80", Slot = "4")]
	public override bool FPGKMMGLAFA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class POAJDLLCOKN<T> : CKMILMJBJOO<FNKBCACODNA<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly OHIFKMENPJL<T> MJCEKNACKEC;

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x4C7DEF0", Offset = "0x4C7C6F0", VA = "0x184C7DEF0")]
	public POAJDLLCOKN(T BIINCLMPDMO, FNKBCACODNA<T> HBCKNOINJJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x406CFB0", Offset = "0x406B7B0", VA = "0x18406CFB0", Slot = "4")]
	public override bool FPGKMMGLAFA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class NGGHKCBAJOE<T> : CKMILMJBJOO<GGHBEKHKJDG<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly KEHJDOLIJJC<T> CNPMMILHPPB;

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x4A46590", Offset = "0x4A44D90", VA = "0x184A46590")]
	public NGGHKCBAJOE(T BIINCLMPDMO, bool PEADOELKBIK, GGHBEKHKJDG<T> HBCKNOINJJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x406CFB0", Offset = "0x406B7B0", VA = "0x18406CFB0", Slot = "4")]
	public override bool FPGKMMGLAFA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public struct IAOKNAPJFMK<TData> where TData : notnull, HFMJGPOEMNB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public IEnumerable<TData> OMCLEABHHKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public bool PHGPIJIHOPJ;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x42F56E0", Offset = "0x42F3EE0", VA = "0x1842F56E0")]
	public IAOKNAPJFMK(IEnumerable<TData> JHPEKDJHHMF, bool IHFJCMNFNCO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public struct BAMBLDANKEJ<TData> where TData : notnull, HFMJGPOEMNB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public List<TData> OMCLEABHHKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public List<bool> GLMPDGLNFPM;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x538AFF0", Offset = "0x53897F0", VA = "0x18538AFF0")]
	public BAMBLDANKEJ(List<TData> JHPEKDJHHMF, List<bool> HCMHEDLMIBK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface HFMJGPOEMNB
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	bool GKHMOINIBGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface KBMLKEHAGGA<TData> where TData : HFMJGPOEMNB
{
	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FPGKMMGLAFA([In] IAOKNAPJFMK<TData> NJELLLPKCBE);

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FPGKMMGLAFA([In] BAMBLDANKEJ<TData> NJELLLPKCBE);
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface JIEPDOLLCNL<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GECEPPOCGCI(T BIINCLMPDMO);
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class INKJIEEHEME<TData> : CKMILMJBJOO<KBMLKEHAGGA<TData>> where TData : notnull, HFMJGPOEMNB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly IAOKNAPJFMK<TData> NJELLLPKCBE;

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x4337020", Offset = "0x4335820", VA = "0x184337020")]
	public INKJIEEHEME(List<TData> CFOCMBCLJLO, bool PHGPIJIHOPJ, KBMLKEHAGGA<TData> HBCKNOINJJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x406CFB0", Offset = "0x406B7B0", VA = "0x18406CFB0", Slot = "4")]
	public override bool FPGKMMGLAFA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class CEKPPPJKAMA<TData> : CKMILMJBJOO<KBMLKEHAGGA<TData>> where TData : notnull, HFMJGPOEMNB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly BAMBLDANKEJ<TData> NJELLLPKCBE;

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x58404A0", Offset = "0x583ECA0", VA = "0x1858404A0")]
	public CEKPPPJKAMA(List<TData> CFOCMBCLJLO, List<bool> GLMPDGLNFPM, KBMLKEHAGGA<TData> HBCKNOINJJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x439A190", Offset = "0x4398990", VA = "0x18439A190", Slot = "4")]
	public override bool FPGKMMGLAFA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public interface LAOPOCDAOIJ<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<JEBHJKJIPPG> FPGKMMGLAFA(HDMELMEMAAL<TData> AAFHCAKPKJN);
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public class OJCGEMDBMEO<TData> : KPHMIMPDPFH<LAOPOCDAOIJ<TData>, JEBHJKJIPPG> where TData : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct FABPKEMDBFD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public AsyncTaskMethodBuilder<JEBHJKJIPPG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public OJCGEMDBMEO<TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private TaskAwaiter<JEBHJKJIPPG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x404ED80", Offset = "0x404D580", VA = "0x18404ED80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x404F060", Offset = "0x404D860", VA = "0x18404F060", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly HDMELMEMAAL<TData> MMHKLHBDNGD;

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x4B572E0", Offset = "0x4B55AE0", VA = "0x184B572E0")]
	public OJCGEMDBMEO(TData OOBLHLLIGPO, IReadOnlyList<TData> KBOLDDHCCCP, bool MIPDANJBAMD, LAOPOCDAOIJ<TData> HBCKNOINJJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x4B571E0", Offset = "0x4B559E0", VA = "0x184B571E0", Slot = "4")]
	[AsyncStateMachine(typeof(OJCGEMDBMEO<>.FABPKEMDBFD))]
	public override Task<JEBHJKJIPPG> FPGKMMGLAFA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public struct HDMELMEMAAL<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public TData CIEKFPHNOFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public IReadOnlyList<TData> MMJJLGOMFHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public bool BMODDCJEACO;

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x421BEE0", Offset = "0x421A6E0", VA = "0x18421BEE0")]
	public HDMELMEMAAL(TData OOBLHLLIGPO, IReadOnlyList<TData> KBOLDDHCCCP, bool MIPDANJBAMD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface IKIGLMCFDIH<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FPGKMMGLAFA([In] LCBHHEEFKDF<TData> OEIGPNNEJEC);
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public interface JGJJDBLFHON<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FPGKMMGLAFA([In] GNKMJKMPHIC<TData> OEIGPNNEJEC);
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public interface NBDDHIMPCHH<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IPEPACBLMKE([In] DCBJLJFMIGO<TData> OEIGPNNEJEC);

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JLJFFMNICJE();
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public class GDPBEJMOKAN<TData> : CKMILMJBJOO<IKIGLMCFDIH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly LCBHHEEFKDF<TData> OEIGPNNEJEC;

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x4125730", Offset = "0x4123F30", VA = "0x184125730")]
	public GDPBEJMOKAN(IEnumerable<TData> CFOCMBCLJLO, CEBKHCOPPLM LCDEMOPFJEN, PJFDOHDFBLL KMOLIAGHFFN, float BCAMIMKLAPP, bool MIPDANJBAMD, IKIGLMCFDIH<TData> HBCKNOINJJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x406CFB0", Offset = "0x406B7B0", VA = "0x18406CFB0", Slot = "4")]
	public override bool FPGKMMGLAFA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public class GNAINNACPLD<TData> : CKMILMJBJOO<JGJJDBLFHON<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private readonly GNKMJKMPHIC<TData> OEIGPNNEJEC;

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x4149C40", Offset = "0x4148440", VA = "0x184149C40")]
	public GNAINNACPLD(TData[] CFOCMBCLJLO, CEBKHCOPPLM[] LCDEMOPFJEN, PJFDOHDFBLL[] KMOLIAGHFFN, float[] BCAMIMKLAPP, JGJJDBLFHON<TData> HBCKNOINJJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x3CD1AF0", Offset = "0x3CD02F0", VA = "0x183CD1AF0", Slot = "4")]
	public override bool FPGKMMGLAFA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public class KGBHLLCKNAP<TData> : CKMILMJBJOO<NBDDHIMPCHH<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x3CD5E10", Offset = "0x3CD4610", VA = "0x183CD5E10")]
	public KGBHLLCKNAP(NBDDHIMPCHH<TData> HBCKNOINJJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x4639AE0", Offset = "0x46382E0", VA = "0x184639AE0", Slot = "4")]
	public override bool FPGKMMGLAFA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public class EFAHNPBBGDG<TData> : CKMILMJBJOO<NBDDHIMPCHH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private readonly DCBJLJFMIGO<TData> OEIGPNNEJEC;

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x3CD1BA0", Offset = "0x3CD03A0", VA = "0x183CD1BA0")]
	public EFAHNPBBGDG(IEnumerable<TData> CFOCMBCLJLO, CEBKHCOPPLM LCDEMOPFJEN, PJFDOHDFBLL KMOLIAGHFFN, float BCAMIMKLAPP, NBDDHIMPCHH<TData> HBCKNOINJJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x3CD1AF0", Offset = "0x3CD02F0", VA = "0x183CD1AF0", Slot = "4")]
	public override bool FPGKMMGLAFA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public struct LCBHHEEFKDF<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public IEnumerable<TData> OMCLEABHHKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public CEBKHCOPPLM JLCDCPNFHLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public PJFDOHDFBLL OAPEFBDFDDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public float BCAMIMKLAPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public bool MIPDANJBAMD;

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x471EF80", Offset = "0x471D780", VA = "0x18471EF80")]
	public LCBHHEEFKDF(IEnumerable<TData> CFOCMBCLJLO, CEBKHCOPPLM LCDEMOPFJEN, PJFDOHDFBLL KMOLIAGHFFN, float BCAMIMKLAPP, bool MIPDANJBAMD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public struct GNKMJKMPHIC<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public TData[] OMCLEABHHKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public CEBKHCOPPLM[] JLCDCPNFHLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public PJFDOHDFBLL[] OAPEFBDFDDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public float[] BCAMIMKLAPP;

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x414F250", Offset = "0x414DA50", VA = "0x18414F250")]
	public GNKMJKMPHIC(TData[] CFOCMBCLJLO, CEBKHCOPPLM[] LCDEMOPFJEN, PJFDOHDFBLL[] KMOLIAGHFFN, float[] BCAMIMKLAPP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public struct DCBJLJFMIGO<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public IEnumerable<TData> OMCLEABHHKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public CEBKHCOPPLM JLCDCPNFHLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public PJFDOHDFBLL OAPEFBDFDDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public float BCAMIMKLAPP;

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x5D90F50", Offset = "0x5D8F750", VA = "0x185D90F50")]
	public DCBJLJFMIGO(IEnumerable<TData> CFOCMBCLJLO, CEBKHCOPPLM LCDEMOPFJEN, PJFDOHDFBLL KMOLIAGHFFN, float BCAMIMKLAPP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public interface DIJEMLBFENB<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JEJONLEIACG([In] LHLNMGMJKJJ<TData> LFOANLCJANB);

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NJGDPAMOCBP([In] LHLNMGMJKJJ<TData> LFOANLCJANB);

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CGBFLJBLIHH([In] bool BDMPIJOPMCC);

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool LFFPFAPMMGJ([In] LHLNMGMJKJJ<TData> LFOANLCJANB);

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GMEJCNKFPAF();

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool JIELHGADFND([In] TData EFLCDGDKNNE);
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public class FLOFEHIMADP<TData> : CKMILMJBJOO<DIJEMLBFENB<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly LHLNMGMJKJJ<TData> LFOANLCJANB;

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x40721E0", Offset = "0x40709E0", VA = "0x1840721E0")]
	public FLOFEHIMADP(List<TData> HEMCJGBMGKH, DIJEMLBFENB<TData> HBCKNOINJJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x406CFB0", Offset = "0x406B7B0", VA = "0x18406CFB0", Slot = "4")]
	public override bool FPGKMMGLAFA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class DNKCOLNFEDC<TData> : CKMILMJBJOO<DIJEMLBFENB<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x3CD5E10", Offset = "0x3CD4610", VA = "0x183CD5E10")]
	public DNKCOLNFEDC(DIJEMLBFENB<TData> HBCKNOINJJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x5E01130", Offset = "0x5DFF930", VA = "0x185E01130", Slot = "4")]
	public override bool FPGKMMGLAFA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class AHHJEENLJMA<TData> : CKMILMJBJOO<DIJEMLBFENB<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private readonly bool MIPDANJBAMD;

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x4172FF0", Offset = "0x41717F0", VA = "0x184172FF0")]
	public AHHJEENLJMA(bool MIPDANJBAMD, DIJEMLBFENB<TData> HBCKNOINJJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x4172F90", Offset = "0x4171790", VA = "0x184172F90", Slot = "4")]
	public override bool FPGKMMGLAFA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class AJKELJCIDML<TData> : CKMILMJBJOO<DIJEMLBFENB<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly LHLNMGMJKJJ<TData> LFOANLCJANB;

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x439A240", Offset = "0x4398A40", VA = "0x18439A240")]
	public AJKELJCIDML(List<TData> HEMCJGBMGKH, bool MIPDANJBAMD, DIJEMLBFENB<TData> HBCKNOINJJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x439A190", Offset = "0x4398990", VA = "0x18439A190", Slot = "4")]
	public override bool FPGKMMGLAFA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public class HFFIEKNGGBC<TData> : CKMILMJBJOO<DIJEMLBFENB<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly TData EFLCDGDKNNE;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x4220560", Offset = "0x421ED60", VA = "0x184220560")]
	public HFFIEKNGGBC(TData EFLCDGDKNNE, DIJEMLBFENB<TData> HBCKNOINJJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x42203E0", Offset = "0x421EBE0", VA = "0x1842203E0", Slot = "4")]
	public override bool FPGKMMGLAFA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public class IDIMPFBONLN<TData> : CKMILMJBJOO<DIJEMLBFENB<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly LHLNMGMJKJJ<TData> LFOANLCJANB;

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x4304AD0", Offset = "0x43032D0", VA = "0x184304AD0")]
	public IDIMPFBONLN(IEnumerable<TData> HEMCJGBMGKH, DIJEMLBFENB<TData> HBCKNOINJJA, bool MIPDANJBAMD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x4304A10", Offset = "0x4303210", VA = "0x184304A10", Slot = "4")]
	public override bool FPGKMMGLAFA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public struct LHLNMGMJKJJ<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public IEnumerable<TData> OMCLEABHHKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public bool MIPDANJBAMD;

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x4739E80", Offset = "0x4738680", VA = "0x184739E80")]
	public LHLNMGMJKJJ(IEnumerable<TData> JHPEKDJHHMF, bool NHPIHJPPFDH = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public interface ELPNEOLCFFO
{
	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<JEBHJKJIPPG> FPGKMMGLAFA(KOHGAGOMDJO AELLFNICOEB);
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class KBIFNKHIIGK : KPHMIMPDPFH<ELPNEOLCFFO, JEBHJKJIPPG>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private struct FHJNGKOPIHJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public AsyncTaskMethodBuilder<JEBHJKJIPPG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public KBIFNKHIIGK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private TaskAwaiter<JEBHJKJIPPG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x6F9AA20", Offset = "0x6F99220", VA = "0x186F9AA20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x6F9AC90", Offset = "0x6F99490", VA = "0x186F9AC90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly KOHGAGOMDJO BEPKEJIOKEG;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6F9B580", Offset = "0x6F99D80", VA = "0x186F9B580")]
	public KBIFNKHIIGK(bool MIPDANJBAMD, ELPNEOLCFFO HBCKNOINJJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6F9B490", Offset = "0x6F99C90", VA = "0x186F9B490", Slot = "4")]
	[AsyncStateMachine(typeof(FHJNGKOPIHJ))]
	public override Task<JEBHJKJIPPG> FPGKMMGLAFA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public struct KOHGAGOMDJO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public bool BMODDCJEACO;

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x251B6A0", Offset = "0x2519EA0", VA = "0x18251B6A0")]
	public KOHGAGOMDJO(bool MIPDANJBAMD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public readonly struct AOHCPNDPKNG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public readonly bool JMEGJOGIIPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public readonly bool FPIHKNNDOAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public readonly bool FKICLIIJEHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public readonly bool MIPDANJBAMD;

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x51DC4E0", Offset = "0x51DACE0", VA = "0x1851DC4E0")]
	public AOHCPNDPKNG(bool JMEGJOGIIPH, bool FPIHKNNDOAH, bool FKICLIIJEHG, bool MIPDANJBAMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x6F99F20", Offset = "0x6F98720", VA = "0x186F99F20")]
	public AOHCPNDPKNG(bool FPIHKNNDOAH, bool MIPDANJBAMD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public interface MOLFIAJGMKD
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GDKDAGIPGPJ(AOHCPNDPKNG LLKDLFEPPFI);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool IEENIBPKGEG(AOHCPNDPKNG LLKDLFEPPFI);
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class NIPLFAAKLIM : CKMILMJBJOO<MOLFIAJGMKD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly AOHCPNDPKNG LLKDLFEPPFI;

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6F9B8A0", Offset = "0x6F9A0A0", VA = "0x186F9B8A0")]
	public NIPLFAAKLIM(bool NBEDBEKEEBM, bool FPIHKNNDOAH, bool FKICLIIJEHG, bool MIPDANJBAMD, MOLFIAJGMKD HBCKNOINJJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x6F9B850", Offset = "0x6F9A050", VA = "0x186F9B850", Slot = "4")]
	public override bool FPGKMMGLAFA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class JHGNLCCGGNI : CKMILMJBJOO<MOLFIAJGMKD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private readonly AOHCPNDPKNG LLKDLFEPPFI;

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x6F9B300", Offset = "0x6F99B00", VA = "0x186F9B300")]
	public JHGNLCCGGNI(bool FPIHKNNDOAH, bool MIPDANJBAMD, MOLFIAJGMKD HBCKNOINJJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x6F9B2B0", Offset = "0x6F99AB0", VA = "0x186F9B2B0", Slot = "4")]
	public override bool FPGKMMGLAFA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public interface GILELINAICE
{
	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FPGKMMGLAFA([In] FCBDEFHEKEP DGGECBBANAA);
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public class OBMKKDBFNHO : CKMILMJBJOO<GILELINAICE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private readonly FCBDEFHEKEP DGGECBBANAA;

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x6F9BA60", Offset = "0x6F9A260", VA = "0x186F9BA60")]
	public OBMKKDBFNHO(Guid[] JMKICBIGHMA, Vector3[] JPDMIKBIINP, Quaternion[] IKDNNGLFJFD, float[] PIIMBMOMMBG, Dictionary<Guid, Vector3> IDMKLPJDDBN, GILELINAICE HBCKNOINJJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x6F9B9B0", Offset = "0x6F9A1B0", VA = "0x186F9B9B0", Slot = "4")]
	public override bool FPGKMMGLAFA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public interface FFMGJJEKGJL<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ICBJIJONOFC([In] JNHLFELHBFM<TData> JCHCJDMEFFN);

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool IPEPACBLMKE([In] GALDAKNBMLO GKHHANLBJHH);

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IPEPACBLMKE([In] GJHJNIEJNJJ GKHHANLBJHH);

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool JLJFFMNICJE();
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public class AMBDJPCJKDH<TData> : CKMILMJBJOO<FFMGJJEKGJL<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x3CD5E10", Offset = "0x3CD4610", VA = "0x183CD5E10")]
	public AMBDJPCJKDH(FFMGJJEKGJL<TData> HBCKNOINJJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x43AF780", Offset = "0x43ADF80", VA = "0x1843AF780", Slot = "4")]
	public override bool FPGKMMGLAFA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public class LGLOKBJOAOM<TData> : CKMILMJBJOO<FFMGJJEKGJL<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private readonly GALDAKNBMLO HODKEPPBJBJ;

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x472B6B0", Offset = "0x4729EB0", VA = "0x18472B6B0")]
	public LGLOKBJOAOM(Vector3 IOGBJBJOAHC, bool MJAHAKFPPOI, FFMGJJEKGJL<TData> HBCKNOINJJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x4068560", Offset = "0x4066D60", VA = "0x184068560", Slot = "4")]
	public override bool FPGKMMGLAFA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public class FPLNENEDGAG<TData> : CKMILMJBJOO<FFMGJJEKGJL<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly GJHJNIEJNJJ HODKEPPBJBJ;

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x40822C0", Offset = "0x4080AC0", VA = "0x1840822C0")]
	public FPLNENEDGAG(Guid BOGGBBCJFDB, int ECDOOAABOPD, Vector3 BALIIBCILHH, Quaternion OJEGGOKKPLF, float EKHPIDKNFIF, bool MJAHAKFPPOI, FFMGJJEKGJL<TData> HBCKNOINJJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x4082260", Offset = "0x4080A60", VA = "0x184082260", Slot = "4")]
	public override bool FPGKMMGLAFA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public class FJNHMJJHDKP<TData> : CKMILMJBJOO<FFMGJJEKGJL<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly JNHLFELHBFM<TData> HODKEPPBJBJ;

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x406D060", Offset = "0x406B860", VA = "0x18406D060")]
	public FJNHMJJHDKP(TData BIINCLMPDMO, bool MIPDANJBAMD, FFMGJJEKGJL<TData> HBCKNOINJJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x406CFB0", Offset = "0x406B7B0", VA = "0x18406CFB0", Slot = "4")]
	public override bool FPGKMMGLAFA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public struct GALDAKNBMLO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public readonly Vector3 IOGBJBJOAHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public readonly bool MJAHAKFPPOI;

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x6F9AD00", Offset = "0x6F99500", VA = "0x186F9AD00")]
	public GALDAKNBMLO(Vector3 IOGBJBJOAHC, bool MJAHAKFPPOI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public struct GJHJNIEJNJJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public readonly Guid BOGGBBCJFDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public readonly int ECDOOAABOPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public readonly Vector3 BALIIBCILHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public readonly Quaternion OJEGGOKKPLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public readonly float EKHPIDKNFIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public readonly bool MJAHAKFPPOI;

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x6F9AD20", Offset = "0x6F99520", VA = "0x186F9AD20")]
	public GJHJNIEJNJJ(Guid BOGGBBCJFDB, int ECDOOAABOPD, Vector3 BALIIBCILHH, Quaternion OJEGGOKKPLF, float EKHPIDKNFIF, bool MJAHAKFPPOI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public struct JNHLFELHBFM<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public readonly TData BIINCLMPDMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public readonly bool MIPDANJBAMD;

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x4563190", Offset = "0x4561990", VA = "0x184563190")]
	public JNHLFELHBFM(TData BIINCLMPDMO, bool MIPDANJBAMD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public interface DMNAOEAFGHF<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FPGKMMGLAFA([In] NANLELCBCGM<TData> PAIBDEEHKGI);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool FPGKMMGLAFA([In] GLJALGPKJAN<TData> PAIBDEEHKGI);
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public interface APKCECHHBKO<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ICBJIJONOFC([In] CEOCJOCDDEF<TData> OECMGHCMFCH);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool IPEPACBLMKE([In] MDEMBPDAIKA GKHHANLBJHH);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool JLJFFMNICJE();
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class AIHKDKBADBM<TData> : CKMILMJBJOO<DMNAOEAFGHF<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private readonly NANLELCBCGM<TData> PAIBDEEHKGI;

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x4398C90", Offset = "0x4397490", VA = "0x184398C90")]
	public AIHKDKBADBM(IEnumerable<TData> CFOCMBCLJLO, Vector3 JJLNPCGDJIO, bool MIPDANJBAMD, DMNAOEAFGHF<TData> HBCKNOINJJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x406CFB0", Offset = "0x406B7B0", VA = "0x18406CFB0", Slot = "4")]
	public override bool FPGKMMGLAFA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public class PDGEEKFLMHG<TData> : CKMILMJBJOO<APKCECHHBKO<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x3CD5E10", Offset = "0x3CD4610", VA = "0x183CD5E10")]
	public PDGEEKFLMHG(APKCECHHBKO<TData> HBCKNOINJJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x3CF6FE0", Offset = "0x3CF57E0", VA = "0x183CF6FE0", Slot = "4")]
	public override bool FPGKMMGLAFA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public class ONHBEGJCAOB<TData> : CKMILMJBJOO<APKCECHHBKO<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private readonly CEOCJOCDDEF<TData> PAIBDEEHKGI;

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x4B6F090", Offset = "0x4B6D890", VA = "0x184B6F090")]
	public ONHBEGJCAOB(IEnumerable<TData> CFOCMBCLJLO, bool MIPDANJBAMD, APKCECHHBKO<TData> HBCKNOINJJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x406CFB0", Offset = "0x406B7B0", VA = "0x18406CFB0", Slot = "4")]
	public override bool FPGKMMGLAFA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public class HDDDNDDAPIP<TData> : CKMILMJBJOO<DMNAOEAFGHF<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private readonly GLJALGPKJAN<TData> PAIBDEEHKGI;

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x4218D60", Offset = "0x4217560", VA = "0x184218D60")]
	public HDDDNDDAPIP(IEnumerable<TData> CFOCMBCLJLO, Vector3 JNCKGPIGMFB, MNLGCKIHCHE ADHFJGAEGND, bool MIPDANJBAMD, DMNAOEAFGHF<TData> HBCKNOINJJA, Space JANEEIODCOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x3CC6C20", Offset = "0x3CC5420", VA = "0x183CC6C20", Slot = "4")]
	public override bool FPGKMMGLAFA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class FEHOKKAHBIN<TData> : CKMILMJBJOO<APKCECHHBKO<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private readonly MDEMBPDAIKA PAIBDEEHKGI;

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x40685C0", Offset = "0x4066DC0", VA = "0x1840685C0")]
	public FEHOKKAHBIN(Vector3 JJLNPCGDJIO, APKCECHHBKO<TData> HBCKNOINJJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x4068560", Offset = "0x4066D60", VA = "0x184068560", Slot = "4")]
	public override bool FPGKMMGLAFA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public struct NANLELCBCGM<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public readonly IEnumerable<TData> CFOCMBCLJLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public readonly Vector3 JJLNPCGDJIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public readonly bool MIPDANJBAMD;

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x4A36980", Offset = "0x4A35180", VA = "0x184A36980")]
	public NANLELCBCGM(IEnumerable<TData> CFOCMBCLJLO, Vector3 JJLNPCGDJIO, bool MIPDANJBAMD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public struct CEOCJOCDDEF<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public readonly IEnumerable<TData> CFOCMBCLJLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public readonly bool MIPDANJBAMD;

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x5840860", Offset = "0x583F060", VA = "0x185840860")]
	public CEOCJOCDDEF(IEnumerable<TData> CFOCMBCLJLO, bool MIPDANJBAMD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public struct GLJALGPKJAN<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public readonly IEnumerable<TData> CFOCMBCLJLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public readonly Vector3 JNCKGPIGMFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public readonly MNLGCKIHCHE ADHFJGAEGND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public readonly bool MIPDANJBAMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public readonly Space JANEEIODCOO;

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x4141680", Offset = "0x413FE80", VA = "0x184141680")]
	public GLJALGPKJAN(IEnumerable<TData> CFOCMBCLJLO, Vector3 JNCKGPIGMFB, MNLGCKIHCHE ADHFJGAEGND, bool MIPDANJBAMD, Space JANEEIODCOO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public struct MDEMBPDAIKA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public readonly Vector3 JJLNPCGDJIO;

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x251B9E0", Offset = "0x251A1E0", VA = "0x18251B9E0")]
	public MDEMBPDAIKA(Vector3 JJLNPCGDJIO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public enum MNLGCKIHCHE
{
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	XYZ,
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	X_only,
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	Y_only,
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	Z_only
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public interface AKMFHPOFDBE
{
	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FPGKMMGLAFA([In] JLGAOMIAJFF MAIOFOAPPEI);
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public class JNOMPFMFKPG : CKMILMJBJOO<AKMFHPOFDBE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly JLGAOMIAJFF MAIOFOAPPEI;

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x6F9B430", Offset = "0x6F99C30", VA = "0x186F9B430")]
	public JNOMPFMFKPG(bool MIPDANJBAMD, AKMFHPOFDBE HBCKNOINJJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x6F9B380", Offset = "0x6F99B80", VA = "0x186F9B380", Slot = "4")]
	public override bool FPGKMMGLAFA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public readonly struct JLGAOMIAJFF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public readonly bool MIPDANJBAMD;

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x251B6A0", Offset = "0x2519EA0", VA = "0x18251B6A0")]
	public JLGAOMIAJFF(bool MIPDANJBAMD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public interface JMBOPLOJBJP<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FPGKMMGLAFA([In] CJFLPLFNDHB<TData> OLBCECICBFK);

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool FPGKMMGLAFA([In] MPEBBCMDNMG<TData> OLBCECICBFK);
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public interface HLCGFEEJBAL<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ICBJIJONOFC([In] FKCPKLHCIOD<TData> JCHCJDMEFFN);

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool IPEPACBLMKE([In] OLDCHHDKDGD GKHHANLBJHH);

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool JLJFFMNICJE();
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public class NPMGJIJDHOL<TData> : CKMILMJBJOO<JMBOPLOJBJP<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly CJFLPLFNDHB<TData> OLBCECICBFK;

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x4A5F2C0", Offset = "0x4A5DAC0", VA = "0x184A5F2C0")]
	public NPMGJIJDHOL(IEnumerable<TData> CFOCMBCLJLO, Quaternion JJLNPCGDJIO, Vector3? DEHLCICBAMF, bool DIKBKJEDKEG, bool MIPDANJBAMD, JMBOPLOJBJP<TData> HBCKNOINJJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x406CFB0", Offset = "0x406B7B0", VA = "0x18406CFB0", Slot = "4")]
	public override bool FPGKMMGLAFA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public class EPNLDEOIGBH<TData> : CKMILMJBJOO<HLCGFEEJBAL<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x3CD5E10", Offset = "0x3CD4610", VA = "0x183CD5E10")]
	public EPNLDEOIGBH(HLCGFEEJBAL<TData> HBCKNOINJJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x3CF6FE0", Offset = "0x3CF57E0", VA = "0x183CF6FE0", Slot = "4")]
	public override bool FPGKMMGLAFA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public class AEIKGPLHAOM<TData> : CKMILMJBJOO<HLCGFEEJBAL<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly FKCPKLHCIOD<TData> OLBCECICBFK;

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x41045A0", Offset = "0x4102DA0", VA = "0x1841045A0")]
	public AEIKGPLHAOM(IEnumerable<TData> CFOCMBCLJLO, bool MIPDANJBAMD, HLCGFEEJBAL<TData> HBCKNOINJJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x406CFB0", Offset = "0x406B7B0", VA = "0x18406CFB0", Slot = "4")]
	public override bool FPGKMMGLAFA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public class EEEDJIHCJEE<TData> : CKMILMJBJOO<JMBOPLOJBJP<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly MPEBBCMDNMG<TData> OLBCECICBFK;

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x3CC6CE0", Offset = "0x3CC54E0", VA = "0x183CC6CE0")]
	public EEEDJIHCJEE(IEnumerable<TData> CFOCMBCLJLO, Quaternion GPHHCIHDHJK, MNLGCKIHCHE DHEJIIJHNKO, Vector3? DEHLCICBAMF, bool DIKBKJEDKEG, bool MIPDANJBAMD, Space JANEEIODCOO, JMBOPLOJBJP<TData> HBCKNOINJJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x3CC6C20", Offset = "0x3CC5420", VA = "0x183CC6C20", Slot = "4")]
	public override bool FPGKMMGLAFA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public class IGOMGIGOKMF<TData> : CKMILMJBJOO<HLCGFEEJBAL<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly OLDCHHDKDGD OLBCECICBFK;

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x4312380", Offset = "0x4310B80", VA = "0x184312380")]
	public IGOMGIGOKMF(Quaternion JJLNPCGDJIO, Vector3? DEHLCICBAMF, bool DIKBKJEDKEG, HLCGFEEJBAL<TData> HBCKNOINJJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x4068560", Offset = "0x4066D60", VA = "0x184068560", Slot = "4")]
	public override bool FPGKMMGLAFA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public struct CJFLPLFNDHB<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public readonly IEnumerable<TData> CFOCMBCLJLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public readonly Quaternion JJLNPCGDJIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public readonly Vector3? DEHLCICBAMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public readonly bool DIKBKJEDKEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public readonly bool MIPDANJBAMD;

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x5926AD0", Offset = "0x59252D0", VA = "0x185926AD0")]
	public CJFLPLFNDHB(IEnumerable<TData> CFOCMBCLJLO, Quaternion JJLNPCGDJIO, Vector3? DEHLCICBAMF, bool DIKBKJEDKEG, bool MIPDANJBAMD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public struct FKCPKLHCIOD<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public readonly IEnumerable<TData> CFOCMBCLJLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public readonly bool MIPDANJBAMD;

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x406EA10", Offset = "0x406D210", VA = "0x18406EA10")]
	public FKCPKLHCIOD(IEnumerable<TData> CFOCMBCLJLO, bool MIPDANJBAMD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public struct MPEBBCMDNMG<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public readonly IEnumerable<TData> CFOCMBCLJLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	public readonly Quaternion GPHHCIHDHJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	public readonly MNLGCKIHCHE DHEJIIJHNKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public readonly Vector3? DEHLCICBAMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public readonly bool DIKBKJEDKEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public readonly bool MIPDANJBAMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public readonly Space JANEEIODCOO;

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x49F93F0", Offset = "0x49F7BF0", VA = "0x1849F93F0")]
	public MPEBBCMDNMG(IEnumerable<TData> CFOCMBCLJLO, Quaternion GPHHCIHDHJK, MNLGCKIHCHE DHEJIIJHNKO, Vector3? DEHLCICBAMF, bool DIKBKJEDKEG, bool MIPDANJBAMD, Space JANEEIODCOO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public struct OLDCHHDKDGD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public readonly Quaternion JJLNPCGDJIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public readonly Vector3? DEHLCICBAMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public readonly bool DIKBKJEDKEG;

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x51A1EF0", Offset = "0x51A06F0", VA = "0x1851A1EF0")]
	public OLDCHHDKDGD(Quaternion JJLNPCGDJIO, Vector3? DEHLCICBAMF, bool DIKBKJEDKEG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public interface AIIKELJFGIF<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ICBJIJONOFC([In] IIDJNHGHLEN<TData> JCHCJDMEFFN);

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool IPEPACBLMKE([In] KKGCNEJHAJG GKHHANLBJHH);

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IPEPACBLMKE([In] CFNIMNAAKLO GKHHANLBJHH);

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IPEPACBLMKE([In] LBGKAIKKHND GKHHANLBJHH);

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool JLJFFMNICJE();
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public class AGCMMGHDFNL<TData> : CKMILMJBJOO<AIIKELJFGIF<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private readonly LBGKAIKKHND LKBCLDDEAMJ;

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x4170520", Offset = "0x416ED20", VA = "0x184170520")]
	public AGCMMGHDFNL(Vector3 FEOMFADJILH, float JIEAOBFDGBL, Vector3 DEHLCICBAMF, bool CFKHBFAMJEK, bool ALHHJOLFLLJ, AIIKELJFGIF<TData> HBCKNOINJJA, Space JANEEIODCOO = Space.Self)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x41704C0", Offset = "0x416ECC0", VA = "0x1841704C0", Slot = "4")]
	public override bool FPGKMMGLAFA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public class CDOGJBDACFL<TData> : CKMILMJBJOO<AIIKELJFGIF<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x3CD5E10", Offset = "0x3CD4610", VA = "0x183CD5E10")]
	public CDOGJBDACFL(AIIKELJFGIF<TData> HBCKNOINJJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x583E190", Offset = "0x583C990", VA = "0x18583E190", Slot = "4")]
	public override bool FPGKMMGLAFA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public class POLPNDGBKFH<TData> : CKMILMJBJOO<AIIKELJFGIF<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private readonly IIDJNHGHLEN<TData> LKBCLDDEAMJ;

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x4C802A0", Offset = "0x4C7EAA0", VA = "0x184C802A0")]
	public POLPNDGBKFH(IEnumerable<TData> CFOCMBCLJLO, bool MIPDANJBAMD, AIIKELJFGIF<TData> HBCKNOINJJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x406CFB0", Offset = "0x406B7B0", VA = "0x18406CFB0", Slot = "4")]
	public override bool FPGKMMGLAFA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public class KCJDCKHFBLG<TData> : CKMILMJBJOO<AIIKELJFGIF<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private readonly CFNIMNAAKLO LKBCLDDEAMJ;

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x4630140", Offset = "0x462E940", VA = "0x184630140")]
	public KCJDCKHFBLG(float GLGKICNHMLE, bool MDEJOIGKOIA, Vector3 DEHLCICBAMF, AIIKELJFGIF<TData> HBCKNOINJJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x4630080", Offset = "0x462E880", VA = "0x184630080", Slot = "4")]
	public override bool FPGKMMGLAFA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public class JOBCGFCDJEM<TData> : CKMILMJBJOO<AIIKELJFGIF<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private readonly KKGCNEJHAJG LKBCLDDEAMJ;

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x45648B0", Offset = "0x45630B0", VA = "0x1845648B0")]
	public JOBCGFCDJEM(float JIEAOBFDGBL, Vector3 DEHLCICBAMF, AIIKELJFGIF<TData> HBCKNOINJJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x4068560", Offset = "0x4066D60", VA = "0x184068560", Slot = "4")]
	public override bool FPGKMMGLAFA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public struct LBGKAIKKHND
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public readonly Vector3 FEOMFADJILH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public readonly float JIEAOBFDGBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public readonly Vector3 DEHLCICBAMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public readonly bool MJAHAKFPPOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public readonly Space JANEEIODCOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public readonly bool ALHHJOLFLLJ;

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x6F9B5E0", Offset = "0x6F99DE0", VA = "0x186F9B5E0")]
	public LBGKAIKKHND(Vector3 FEOMFADJILH, float JIEAOBFDGBL, Vector3 DEHLCICBAMF, bool MJAHAKFPPOI, bool OBHEFJHDLCO, Space JANEEIODCOO = Space.Self)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public struct IIDJNHGHLEN<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public readonly IEnumerable<TData> CFOCMBCLJLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public readonly bool MIPDANJBAMD;

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x43140E0", Offset = "0x43128E0", VA = "0x1843140E0")]
	public IIDJNHGHLEN(IEnumerable<TData> CFOCMBCLJLO, bool MIPDANJBAMD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public struct CFNIMNAAKLO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public readonly float GLGKICNHMLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public readonly bool MDEJOIGKOIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public readonly Vector3 DEHLCICBAMF;

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x6F99F70", Offset = "0x6F98770", VA = "0x186F99F70")]
	public CFNIMNAAKLO(float GLGKICNHMLE, bool MDEJOIGKOIA, Vector3 DEHLCICBAMF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public struct KKGCNEJHAJG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public readonly float JIEAOBFDGBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public readonly Vector3 DEHLCICBAMF;

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x51738A0", Offset = "0x51720A0", VA = "0x1851738A0")]
	public KKGCNEJHAJG(float JIEAOBFDGBL, Vector3 DEHLCICBAMF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public struct FCBDEFHEKEP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public readonly Guid[] CFOCMBCLJLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public readonly bool OPICHBLKMEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public readonly bool PCLEDKAIEBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public readonly bool CBKJJNCJJJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public readonly Vector3[] JPDMIKBIINP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public readonly Quaternion[] IKDNNGLFJFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public readonly float[] PIIMBMOMMBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public readonly Dictionary<Guid, Vector3> IDMKLPJDDBN;

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x6F9A790", Offset = "0x6F98F90", VA = "0x186F9A790")]
	public FCBDEFHEKEP(Guid[] JMKICBIGHMA, Vector3[] JPDMIKBIINP, Quaternion[] IKDNNGLFJFD, float[] PIIMBMOMMBG, Dictionary<Guid, Vector3> IDMKLPJDDBN, bool OPICHBLKMEF = true, bool PCLEDKAIEBG = true, bool CBKJJNCJJJA = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x6F9A5C0", Offset = "0x6F98DC0", VA = "0x186F9A5C0")]
	private static void FLNBMAFFONG(Dictionary<Guid, Vector3> IDMKLPJDDBN, int GGJIGFINEMD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public static class IFBHKBGGKLJ
{
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	private struct MFNPBJNNGCC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public bool LAOCDKDNIOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public CMONJLKOOCI IDBNEOAELLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public CMONJLKOOCI ANPBANIDMML;
	}

	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private static MFNPBJNNGCC IIDOBNPGEGF;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static CancellationToken NKIMAJGLIDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x6F9AF40", Offset = "0x6F99740", VA = "0x186F9AF40")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	internal static CMONJLKOOCI IDBNEOAELLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x6F9B1C0", Offset = "0x6F999C0", VA = "0x186F9B1C0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x6F9AED0", Offset = "0x6F996D0", VA = "0x186F9AED0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x6F9AF60", Offset = "0x6F99760", VA = "0x186F9AF60")]
	[PDAMAKFHAHC.NMMFGDGMJIH]
	internal static void EGBEIEOHABF(CMONJLKOOCI HEHEGONBGBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x6F9B060", Offset = "0x6F99860", VA = "0x186F9B060")]
	public static void FGGFCKBCIEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x6F9B260", Offset = "0x6F99A60", VA = "0x186F9B260")]
	private static CMONJLKOOCI JGFGGIBAOPE(CMONJLKOOCI MOELHMGOHPL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
public static class FMGEGCMAGHO
{
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public enum HOPEEOPDJML
	{
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		ICreationContextObject,
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		Guid
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x306B9A0", Offset = "0x306A1A0", VA = "0x18306B9A0")]
	public static void EJMNILOPJLF<T>(T BJNFKEAALFE, HOPEEOPDJML OCLAPBNMMGE) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x306BB00", Offset = "0x306A300", VA = "0x18306BB00")]
	public static void EJMNILOPJLF<T>(T BJNFKEAALFE) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x306BE30", Offset = "0x306A630", VA = "0x18306BE30")]
	public static void KEHCJINPFFH<T>(T BJNFKEAALFE) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x306B890", Offset = "0x306A090", VA = "0x18306B890")]
	public static T EFGCOGNKKLM<T>(HOPEEOPDJML OCLAPBNMMGE) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x306BC20", Offset = "0x306A420", VA = "0x18306BC20")]
	public static bool GKNHABNOIHP<T>(HOPEEOPDJML OCLAPBNMMGE, T? FALPBLAHOON, [Out][MaybeNullWhen(false)][NotNullWhen(true)] T EIKKBPCLGKK) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x306BB70", Offset = "0x306A370", VA = "0x18306BB70")]
	public static bool GFFGJKIMALM<T>(HOPEEOPDJML OCLAPBNMMGE) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x306B940", Offset = "0x306A140", VA = "0x18306B940")]
	public static T EFGCOGNKKLM<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x306BD70", Offset = "0x306A570", VA = "0x18306BD70")]
	public static bool GKNHABNOIHP<T>(T FALPBLAHOON, [Out] T EIKKBPCLGKK) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x306B940", Offset = "0x306A140", VA = "0x18306B940")]
	public static bool GFFGJKIMALM<T>() where T : class
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
internal static class LCDFOGBDBCP
{
	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x6F9B620", Offset = "0x6F99E20", VA = "0x186F9B620")]
	public static void DLKMNHGFPOB(IEnumerable OHDDEKBHCGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x3108650", Offset = "0x3106E50", VA = "0x183108650")]
	public static void DLKMNHGFPOB<T>(T[] GHAIAFELBIF) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x3108740", Offset = "0x3106F40", VA = "0x183108740")]
	public static void DLKMNHGFPOB<T>(T HGBJJIKLGEJ) where T : notnull, Enum
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
