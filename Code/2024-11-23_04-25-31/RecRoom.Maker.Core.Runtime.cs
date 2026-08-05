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
		[Cpp2IlInjected.Address(RVA = "0x8D6960", Offset = "0x8D5360", VA = "0x1808D6960")]
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
		[Cpp2IlInjected.Address(RVA = "0x6E42030", Offset = "0x6E40A30", VA = "0x186E42030")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8D7890", Offset = "0x8D6290", VA = "0x1808D7890")]
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
		[Cpp2IlInjected.Address(RVA = "0x8D78D0", Offset = "0x8D62D0", VA = "0x1808D78D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6E421C0", Offset = "0x6E40BC0", VA = "0x186E421C0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2164780", Offset = "0x2163180", VA = "0x182164780")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface MHCBFPHPEEE<TData, TReturn>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TReturn PLLHBHAOPAJ(TData BBNKFKDCOLP);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface MHFAJIGDDHD<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ClearHoverTarget(OOPCLEKFIDN DGOLMMGEHPH);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool SetHoverTarget(TData PCFKCJNPKCO, Collider FJIHNDEABDF, OOPCLEKFIDN DGOLMMGEHPH, [Optional] FFJCINHIICI? CDLMBIHENGM);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool TryGetHoverTarget([Out] TData PCFKCJNPKCO);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool TryGetHoverCollider([Out] Collider FJIHNDEABDF);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface EDMENFNLDHB<TData> : LJMGMNPGHOL, LOGDNFMCJGL<TData>, DFDEFOEGBBF<TData>, DPHBEOJDAOC<TData>, OCCMICJICNI, FCJEFOILLEB<TData>, IPBODAIPOMP, HCHEKBJDKOA
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface FCJEFOILLEB<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool Raycast(Vector3 GFPIMNGNHHE, Vector3 GPCBHKJPHLL, float FHNFOJHGAMK, [Out] T MDFILGLIMLH, [Out] Vector3 PMIPKNNLDFH, [Out] Collider FJIHNDEABDF);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int SpherecastPick(Vector3 GFPIMNGNHHE, Vector3 GPCBHKJPHLL, float LMFHCHMDOEF, float FHNFOJHGAMK, T[] PCLONMIONNA, [Out] Vector3 FDDMBCCKIAI, [Out] Collider KBANIKINMJC);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int SpherePick(Vector3 GFPIMNGNHHE, float LMFHCHMDOEF, Vector3 GNCCDNLDGMI, T[] PCLONMIONNA);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool TryGetObjectFromColliderInCurrentScope(Collider LNGBIHIBEPB, [Out] T FAEJCGMHALF);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface LJMGMNPGHOL
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Bounds NDIKHIIGIIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	Transform KFKEELNHDMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	Bounds KNDOMPIIFJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Transform PGFLAIPJLEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	Vector3 EJKEGGDCGOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool CPHAPAPCALK
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void SetSelectionBoundsDirty(bool CAELOGJLMJK = true, int JMIFGKOFGLM = 0);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ShouldHideSelectionBoundsPreview(bool AHDOKAGNCPC, object AICEIDIHFDO);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface HCHEKBJDKOA
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	APNHDGDPKOI KLMNPKPPEAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface BBLMJCHDAMC
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool FBPEKNKCCEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool OEFJHHELJKH
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool EFKOMNFEHDH
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
	void TrySetPreviousCloneMapping(Dictionary<Guid, Guid> MBKPIAFFBKH);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface DPHBEOJDAOC<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool DEKJPHIOFKE
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	int PMGNNBJNEDK
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<TData> NCKNJCPAGGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IsSelected(TData GNDKBENMBLO);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IsSelectable(TData GNDKBENMBLO);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface LOGDNFMCJGL<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void RenderHoverHighlight(T BBNKFKDCOLP, [Optional] FFJCINHIICI? DBMKAIFBMAO, bool HJNKOBAFJPN = true);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RenderHoverHighlight(int FPDJICFHLGM, IEnumerable<T> OMODCOGMOOH, bool HJNKOBAFJPN = true);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RenderHoverHighlight(int FPDJICFHLGM, IEnumerable<T> OMODCOGMOOH, FFJCINHIICI DBMKAIFBMAO, bool HJNKOBAFJPN = true);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface IPBODAIPOMP
{
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnSelectionPickedUp();

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnSelectionReleased();
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface OCCMICJICNI
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool IAFOIFJMJHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool KMHJCCOFJBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	bool HBHFCCLMJKN
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	bool CMDCAFODHBL
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public abstract class MGMDGLHFMCE<TReceiver> : OOBKIJJBNHN<TReceiver, bool> where TReceiver : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3F04DD0", Offset = "0x3F037D0", VA = "0x183F04DD0")]
	public MGMDGLHFMCE(TReceiver PHIEHPFGCDC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public abstract class OAMABEFOLMB<TReceiver, TFromTask> : OOBKIJJBNHN<TReceiver, Task<TFromTask>>
{
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3F04DD0", Offset = "0x3F037D0", VA = "0x183F04DD0")]
	public OAMABEFOLMB(TReceiver PHIEHPFGCDC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public abstract class OOBKIJJBNHN<TReceiver, TFromExecute> where TReceiver : notnull where TFromExecute : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	protected TReceiver PHIEHPFGCDC;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x4ABDF90", Offset = "0x4ABC990", VA = "0x184ABDF90")]
	public OOBKIJJBNHN(TReceiver PHIEHPFGCDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TFromExecute EJNOFFABAJA();
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public abstract class FDICADNLKDN<TReceiver, TResult> : OOBKIJJBNHN<TReceiver, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x3F04DD0", Offset = "0x3F037D0", VA = "0x183F04DD0")]
	public FDICADNLKDN(TReceiver PHIEHPFGCDC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct NHCKMNDDOMM<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public TGroup JCEGFIPCNMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public TData OIEDANOENBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public IEnumerable<TData> FHAEPMAPDHN;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x21752A0", Offset = "0x2173CA0", VA = "0x1821752A0")]
	public NHCKMNDDOMM(TGroup BBPAMANHACG, TData KIDMCMJCBPN, IEnumerable<TData> NHJDBLOCBFH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct CAKJLIIBGLI<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public TGroup JCEGFIPCNMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public IEnumerable<TData> FHAEPMAPDHN;

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0xE07750", Offset = "0xE06150", VA = "0x180E07750")]
	public CAKJLIIBGLI(TGroup BBPAMANHACG, IEnumerable<TData> NHJDBLOCBFH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct OLHKPEDEELF<TGroup> where TGroup : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public TGroup JCEGFIPCNMA;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x957790", Offset = "0x956190", VA = "0x180957790")]
	public OLHKPEDEELF(TGroup BBPAMANHACG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct ONPCALOAEHP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public IEnumerable<Guid> FHAEPMAPDHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public Guid HADDEABPBKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public readonly bool PKPPCCCEBGJ;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6E420B0", Offset = "0x6E40AB0", VA = "0x186E420B0")]
	public ONPCALOAEHP(IEnumerable<Guid> NHJDBLOCBFH, Guid LDABPEMJBHK, bool GKJGAMBJMEJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct KNOKKGOJDEA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public Guid HADDEABPBKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public readonly bool PKPPCCCEBGJ;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x1DD5A00", Offset = "0x1DD4400", VA = "0x181DD5A00")]
	public KNOKKGOJDEA(Guid LDABPEMJBHK, bool GKJGAMBJMEJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface FJOGCNOIPEP<TGroup, TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OGKKJOODILP HCANGHIPPJG(NHCKMNDDOMM<TGroup, TData> DOJDMPHAKGL);

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "1")]
	OGKKJOODILP MMNEGGBBCNA(NHCKMNDDOMM<TGroup, TData> DOJDMPHAKGL);

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "2")]
	OGKKJOODILP BMALCKCKLOL(CAKJLIIBGLI<TGroup, TData> DOJDMPHAKGL);

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "3")]
	OGKKJOODILP PBDJPDIHLLO(OLHKPEDEELF<TGroup> DOJDMPHAKGL);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface IJHIBECLAMK
{
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<OGKKJOODILP> HCANGHIPPJG(ONPCALOAEHP DOJDMPHAKGL);

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<OGKKJOODILP> MMNEGGBBCNA(KNOKKGOJDEA DOJDMPHAKGL);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class JGEAEPHNEJH<TGroup, TData> : FDICADNLKDN<FJOGCNOIPEP<TGroup, TData>, OGKKJOODILP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly CAKJLIIBGLI<TGroup, TData> DOJDMPHAKGL;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x4426E90", Offset = "0x4425890", VA = "0x184426E90")]
	public JGEAEPHNEJH(TGroup BBPAMANHACG, IEnumerable<TData> NHJDBLOCBFH, FJOGCNOIPEP<TGroup, TData> PHIEHPFGCDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x4426DC0", Offset = "0x44257C0", VA = "0x184426DC0", Slot = "4")]
	public override OGKKJOODILP EJNOFFABAJA()
	{
		return default(OGKKJOODILP);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class PIEKKFJJANC<TGroup, TData> : FDICADNLKDN<FJOGCNOIPEP<TGroup, TData>, OGKKJOODILP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly NHCKMNDDOMM<TGroup, TData> DOJDMPHAKGL;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x4B70420", Offset = "0x4B6EE20", VA = "0x184B70420")]
	public PIEKKFJJANC(TGroup BBPAMANHACG, TData ICCKNOIEBNH, IEnumerable<TData> NHJDBLOCBFH, FJOGCNOIPEP<TGroup, TData> PHIEHPFGCDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x4B70340", Offset = "0x4B6ED40", VA = "0x184B70340", Slot = "4")]
	public override OGKKJOODILP EJNOFFABAJA()
	{
		return default(OGKKJOODILP);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class MKALANIGDIP<TGroup, TData> : FDICADNLKDN<FJOGCNOIPEP<TGroup, TData>, OGKKJOODILP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly OLHKPEDEELF<TGroup> DOJDMPHAKGL;

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x48C0300", Offset = "0x48BED00", VA = "0x1848C0300")]
	public MKALANIGDIP(TGroup BBPAMANHACG, FJOGCNOIPEP<TGroup, TData> PHIEHPFGCDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x48C0230", Offset = "0x48BEC30", VA = "0x1848C0230", Slot = "4")]
	public override OGKKJOODILP EJNOFFABAJA()
	{
		return default(OGKKJOODILP);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class DBJBAGDHEAL<TGroup, TData> : FDICADNLKDN<FJOGCNOIPEP<TGroup, TData>, OGKKJOODILP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly NHCKMNDDOMM<TGroup, TData> DOJDMPHAKGL;

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x4B70420", Offset = "0x4B6EE20", VA = "0x184B70420")]
	public DBJBAGDHEAL(TGroup BBPAMANHACG, TData KIDMCMJCBPN, IEnumerable<TData> NHJDBLOCBFH, FJOGCNOIPEP<TGroup, TData> PHIEHPFGCDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x5C70BF0", Offset = "0x5C6F5F0", VA = "0x185C70BF0", Slot = "4")]
	public override OGKKJOODILP EJNOFFABAJA()
	{
		return default(OGKKJOODILP);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class IFLABACKFIB : OAMABEFOLMB<IJHIBECLAMK, OGKKJOODILP>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private struct FHKBFAOJMAJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public AsyncTaskMethodBuilder<OGKKJOODILP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public IFLABACKFIB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private TaskAwaiter<OGKKJOODILP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6E40670", Offset = "0x6E3F070", VA = "0x186E40670", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6E40910", Offset = "0x6E3F310", VA = "0x186E40910", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private ONPCALOAEHP DOJDMPHAKGL;

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6E40D20", Offset = "0x6E3F720", VA = "0x186E40D20")]
	public IFLABACKFIB(IEnumerable<Guid> LKFNNJFBNKB, Guid LDABPEMJBHK, bool GKJGAMBJMEJ, IJHIBECLAMK PHIEHPFGCDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6E40C30", Offset = "0x6E3F630", VA = "0x186E40C30", Slot = "4")]
	[AsyncStateMachine(typeof(FHKBFAOJMAJ))]
	public override Task<OGKKJOODILP> EJNOFFABAJA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class KGNKIMHCHPF : OAMABEFOLMB<IJHIBECLAMK, OGKKJOODILP>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private struct LAMPMAMECNC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public AsyncTaskMethodBuilder<OGKKJOODILP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public KGNKIMHCHPF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private TaskAwaiter<OGKKJOODILP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6E41880", Offset = "0x6E40280", VA = "0x186E41880", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6E41B20", Offset = "0x6E40520", VA = "0x186E41B20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly KNOKKGOJDEA DOJDMPHAKGL;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6E41800", Offset = "0x6E40200", VA = "0x186E41800")]
	public KGNKIMHCHPF(Guid LDABPEMJBHK, bool GKJGAMBJMEJ, IJHIBECLAMK PHIEHPFGCDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6E41710", Offset = "0x6E40110", VA = "0x186E41710", Slot = "4")]
	[AsyncStateMachine(typeof(LAMPMAMECNC))]
	public override Task<OGKKJOODILP> EJNOFFABAJA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public readonly struct CHDPPGJGMMJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly MLCIGOGBEPB GFNPFMHOHOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly bool PKPPCCCEBGJ;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6E401D0", Offset = "0x6E3EBD0", VA = "0x186E401D0")]
	public CHDPPGJGMMJ(MLCIGOGBEPB IPBFDCEEHLP, bool GKJGAMBJMEJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface LMBKALJEDJJ<TSpawnType> where TSpawnType : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> EJNOFFABAJA(CHDPPGJGMMJ PMIMDLLHMNE);
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class LBPJEPKBNBH<TSpawnType> : OAMABEFOLMB<LMBKALJEDJJ<TSpawnType>, TSpawnType> where TSpawnType : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private struct OLNEMCKCMCB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public AsyncTaskMethodBuilder<TSpawnType> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public LBPJEPKBNBH<TSpawnType> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private TaskAwaiter<TSpawnType> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x4ABAF80", Offset = "0x4AB9980", VA = "0x184ABAF80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x4116EE0", Offset = "0x41158E0", VA = "0x184116EE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly CHDPPGJGMMJ PMIMDLLHMNE;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x464E400", Offset = "0x464CE00", VA = "0x18464E400")]
	public LBPJEPKBNBH(MLCIGOGBEPB IPBFDCEEHLP, bool GKJGAMBJMEJ, LMBKALJEDJJ<TSpawnType> PHIEHPFGCDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x464E0D0", Offset = "0x464CAD0", VA = "0x18464E0D0", Slot = "4")]
	[AsyncStateMachine(typeof(LBPJEPKBNBH<>.OLNEMCKCMCB))]
	public override Task<TSpawnType> EJNOFFABAJA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public readonly struct MLCIGOGBEPB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly bool AFOOFCPKONL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public readonly Vector3 ILFBEFJNKLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly Vector3 CNDDIEKMION;

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6E41CE0", Offset = "0x6E406E0", VA = "0x186E41CE0")]
	public MLCIGOGBEPB(Transform JBFFIOGBNMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6E41D50", Offset = "0x6E40750", VA = "0x186E41D50")]
	public MLCIGOGBEPB(Vector3 LIGJJEDBJEP, Vector3 PCPIJKGKPCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6E41CB0", Offset = "0x6E406B0", VA = "0x186E41CB0")]
	public static MLCIGOGBEPB JLKNNCHOGKA()
	{
		return default(MLCIGOGBEPB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x6E41D80", Offset = "0x6E40780", VA = "0x186E41D80")]
	private MLCIGOGBEPB(bool CMMLBBNMMHD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public struct EBMMPKMAGII<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public TNode NEEDMBPLONP;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x3B637D0", Offset = "0x3B621D0", VA = "0x183B637D0")]
	public EBMMPKMAGII(TNode NEEDMBPLONP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public struct LJLGLPCJAOK<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public TNode OCGLFPPJPCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public IGMHKNPDFBA DELLOJEFEAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public readonly bool PKPPCCCEBGJ;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x4673590", Offset = "0x4671F90", VA = "0x184673590")]
	public LJLGLPCJAOK(TNode OCGLFPPJPCB, IGMHKNPDFBA DELLOJEFEAG, bool GKJGAMBJMEJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface OCNFLGNCCIH<TNode>
{
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IJCHMIJCPJC([In] EBMMPKMAGII<TNode> NLIMHPMHADL);

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KKGJDFIPCFA([In] LJLGLPCJAOK<TNode> HGHPNFBIGMD);

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool FMPKJJBOFMF();
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class AMPCCPINEIJ<TNode> : MGMDGLHFMCE<OCNFLGNCCIH<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x3F04DD0", Offset = "0x3F037D0", VA = "0x183F04DD0")]
	public AMPCCPINEIJ(OCNFLGNCCIH<TNode> PHIEHPFGCDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x4160B00", Offset = "0x415F500", VA = "0x184160B00", Slot = "4")]
	public override bool EJNOFFABAJA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class OGNDKJEFMMI<TNode> : MGMDGLHFMCE<OCNFLGNCCIH<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private readonly LJLGLPCJAOK<TNode> HGHPNFBIGMD;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x4A59640", Offset = "0x4A58040", VA = "0x184A59640")]
	public OGNDKJEFMMI(TNode OCGLFPPJPCB, IGMHKNPDFBA DELLOJEFEAG, OCNFLGNCCIH<TNode> PHIEHPFGCDC, bool GKJGAMBJMEJ = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x4A59570", Offset = "0x4A57F70", VA = "0x184A59570", Slot = "4")]
	public override bool EJNOFFABAJA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class JPHNGPGLMBG<TNode> : MGMDGLHFMCE<OCNFLGNCCIH<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private readonly EBMMPKMAGII<TNode> NLIMHPMHADL;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x4446C30", Offset = "0x4445630", VA = "0x184446C30")]
	public JPHNGPGLMBG(TNode NFBKKJJNHHD, OCNFLGNCCIH<TNode> PHIEHPFGCDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x3B60E00", Offset = "0x3B5F800", VA = "0x183B60E00", Slot = "4")]
	public override bool EJNOFFABAJA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public struct HDNLJLBJLOB<TSpawnInfo> where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public TSpawnInfo FKNBJHAFGEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public Vector3 PCPIJKGKPCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public Quaternion MHLCHCEFDAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public float ECGPBBOMOPD;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x4176F20", Offset = "0x4175920", VA = "0x184176F20")]
	public HDNLJLBJLOB(TSpawnInfo FKNBJHAFGEP, Vector3 PCPIJKGKPCE, Quaternion MHLCHCEFDAI, float ECGPBBOMOPD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public interface KOHNOPBILGO<TSpawnType, TSpawnInfo>
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> FCDCMDFIFPH([In] HDNLJLBJLOB<TSpawnInfo> AMMGLHKIEMM, CancellationToken PPLDCJFFMEP);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public class KOPBCFOMJNN<TSpawnType, TSpawnInfo> : OAMABEFOLMB<KOHNOPBILGO<TSpawnType, TSpawnInfo>, TSpawnType> where TSpawnType : notnull where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly HDNLJLBJLOB<TSpawnInfo> LPLPEHNKFMM;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x45DA4D0", Offset = "0x45D8ED0", VA = "0x1845DA4D0")]
	public KOPBCFOMJNN(TSpawnInfo EACLPKBGJJM, Vector3 PCPIJKGKPCE, Quaternion MHLCHCEFDAI, float ECGPBBOMOPD, KOHNOPBILGO<TSpawnType, TSpawnInfo> PHIEHPFGCDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x45DA3F0", Offset = "0x45D8DF0", VA = "0x1845DA3F0", Slot = "4")]
	public override Task<TSpawnType> EJNOFFABAJA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public readonly struct BKDPMFDKIPE<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public readonly IEnumerable<TData> FHAEPMAPDHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public readonly bool PKPPCCCEBGJ;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x529A2F0", Offset = "0x5298CF0", VA = "0x18529A2F0")]
	public BKDPMFDKIPE(IEnumerable<TData> NHJDBLOCBFH, bool GKJGAMBJMEJ = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface LDIBDNABBDB<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<OGKKJOODILP> NHNFDJJDLDA([In] BKDPMFDKIPE<TData> OKEPFKDBMMJ, CancellationToken PPLDCJFFMEP);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class NNEGJFIJFJE<TData> : OAMABEFOLMB<LDIBDNABBDB<TData>, OGKKJOODILP> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly BKDPMFDKIPE<TData> KMKGJOAEMHB;

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x494D490", Offset = "0x494BE90", VA = "0x18494D490")]
	public NNEGJFIJFJE(IEnumerable<TData> NHJDBLOCBFH, bool GKJGAMBJMEJ, LDIBDNABBDB<TData> PHIEHPFGCDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x45DA3F0", Offset = "0x45D8DF0", VA = "0x1845DA3F0", Slot = "4")]
	public override Task<OGKKJOODILP> EJNOFFABAJA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public struct HGGOIDCEDFD<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly T PCFKCJNPKCO;

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x417B330", Offset = "0x4179D30", VA = "0x18417B330")]
	public HGGOIDCEDFD(T LMDNOIPKBCL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface ALAJHFIBDNJ<T>
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IJCHMIJCPJC([In] HGGOIDCEDFD<T> CIFBOIPKANM);

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KKGJDFIPCFA();
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface KFHLLKKFAEO<T>
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EJNOFFABAJA([In] OBNOHIKKLOD<T> JOFCICDAMIA);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct OBNOHIKKLOD<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public readonly T PCFKCJNPKCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly bool KEFOBJDLCFH;

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x4A4EDD0", Offset = "0x4A4D7D0", VA = "0x184A4EDD0")]
	public OBNOHIKKLOD(T LMDNOIPKBCL, bool BLOMGHNCJFI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public class NMPGHIOKIEP<T> : MGMDGLHFMCE<ALAJHFIBDNJ<T>> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x3F04DD0", Offset = "0x3F037D0", VA = "0x183F04DD0")]
	public NMPGHIOKIEP(ALAJHFIBDNJ<T> PHIEHPFGCDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x494C9E0", Offset = "0x494B3E0", VA = "0x18494C9E0", Slot = "4")]
	public override bool EJNOFFABAJA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class PCHEEJKHPGE<T> : MGMDGLHFMCE<ALAJHFIBDNJ<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly HGGOIDCEDFD<T> CIFBOIPKANM;

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x4B55560", Offset = "0x4B53F60", VA = "0x184B55560")]
	public PCHEEJKHPGE(T PCFKCJNPKCO, ALAJHFIBDNJ<T> PHIEHPFGCDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x3B60E00", Offset = "0x3B5F800", VA = "0x183B60E00", Slot = "4")]
	public override bool EJNOFFABAJA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class JLEINOANMHP<T> : MGMDGLHFMCE<KFHLLKKFAEO<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly OBNOHIKKLOD<T> JOFCICDAMIA;

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x443CAB0", Offset = "0x443B4B0", VA = "0x18443CAB0")]
	public JLEINOANMHP(T PCFKCJNPKCO, bool BLOMGHNCJFI, KFHLLKKFAEO<T> PHIEHPFGCDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x3B60E00", Offset = "0x3B5F800", VA = "0x183B60E00", Slot = "4")]
	public override bool EJNOFFABAJA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public struct FFDBGNIECPB<TData> where TData : notnull, CPCBGJDBMHK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public IEnumerable<TData> FHAEPMAPDHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public bool DIKCNHPPLOC;

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x3F882B0", Offset = "0x3F86CB0", VA = "0x183F882B0")]
	public FFDBGNIECPB(IEnumerable<TData> FPJEGABFKGH, bool KCHAOHHOAJM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public struct MDJAHOFDGEN<TData> where TData : notnull, CPCBGJDBMHK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public List<TData> FHAEPMAPDHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public List<bool> GFEMDMEKDHB;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x489A1A0", Offset = "0x4898BA0", VA = "0x18489A1A0")]
	public MDJAHOFDGEN(List<TData> FPJEGABFKGH, List<bool> FMOEDIDPDAP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface CPCBGJDBMHK
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	bool LDLBEKJINMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface GNFHNJJOCGC<TData> where TData : CPCBGJDBMHK
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EJNOFFABAJA([In] FFDBGNIECPB<TData> EMOKFNLLHHK);

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EJNOFFABAJA([In] MDJAHOFDGEN<TData> EMOKFNLLHHK);
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface OECANPACFMK<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BNHPEMCAHBH(T PCFKCJNPKCO);
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class PCDHJGEHADM<TData> : MGMDGLHFMCE<GNFHNJJOCGC<TData>> where TData : notnull, CPCBGJDBMHK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly FFDBGNIECPB<TData> EMOKFNLLHHK;

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x4B53790", Offset = "0x4B52190", VA = "0x184B53790")]
	public PCDHJGEHADM(List<TData> NHJDBLOCBFH, bool DIKCNHPPLOC, GNFHNJJOCGC<TData> PHIEHPFGCDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x3B60E00", Offset = "0x3B5F800", VA = "0x183B60E00", Slot = "4")]
	public override bool EJNOFFABAJA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class KHGLJNHGNEM<TData> : MGMDGLHFMCE<GNFHNJJOCGC<TData>> where TData : notnull, CPCBGJDBMHK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly MDJAHOFDGEN<TData> EMOKFNLLHHK;

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x4553560", Offset = "0x4551F60", VA = "0x184553560")]
	public KHGLJNHGNEM(List<TData> NHJDBLOCBFH, List<bool> GFEMDMEKDHB, GNFHNJJOCGC<TData> PHIEHPFGCDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x427AB30", Offset = "0x4279530", VA = "0x18427AB30", Slot = "4")]
	public override bool EJNOFFABAJA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public interface LPGDBDENHGF<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<OGKKJOODILP> EJNOFFABAJA(FNOOGCFOAEG<TData> MDGNEMPDOED);
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public class HMHMEDILCFC<TData> : OAMABEFOLMB<LPGDBDENHGF<TData>, OGKKJOODILP> where TData : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct JDEMIDIDCDD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public AsyncTaskMethodBuilder<OGKKJOODILP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public HMHMEDILCFC<TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private TaskAwaiter<OGKKJOODILP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x4412190", Offset = "0x4410B90", VA = "0x184412190", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x4412480", Offset = "0x4410E80", VA = "0x184412480", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly FNOOGCFOAEG<TData> KLACPMLJHJN;

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x4195450", Offset = "0x4193E50", VA = "0x184195450")]
	public HMHMEDILCFC(TData CPOKPDMOJHD, IReadOnlyList<TData> JMHLFABOMNG, bool GKJGAMBJMEJ, LPGDBDENHGF<TData> PHIEHPFGCDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x4195350", Offset = "0x4193D50", VA = "0x184195350", Slot = "4")]
	[AsyncStateMachine(typeof(HMHMEDILCFC<>.JDEMIDIDCDD))]
	public override Task<OGKKJOODILP> EJNOFFABAJA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public struct FNOOGCFOAEG<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public TData BCGBCOGGANA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public IReadOnlyList<TData> DLIPDDEOPGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public bool PKPPCCCEBGJ;

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x4034C60", Offset = "0x4033660", VA = "0x184034C60")]
	public FNOOGCFOAEG(TData CPOKPDMOJHD, IReadOnlyList<TData> JMHLFABOMNG, bool GKJGAMBJMEJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface NBDJPLDOABH<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EJNOFFABAJA([In] MHNKAFMCILL<TData> BAHEBKDCBCC);
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public interface FOJHFMMHEDE<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EJNOFFABAJA([In] GJIKKOPFKDB<TData> BAHEBKDCBCC);
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public interface CGNGAPAFPCI<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KNMJLGOGAPJ([In] JGFMBFCLHAF<TData> BAHEBKDCBCC);

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KKGJDFIPCFA();
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public class EACHHCKPEDE<TData> : MGMDGLHFMCE<NBDJPLDOABH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private readonly MHNKAFMCILL<TData> BAHEBKDCBCC;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x3B60EC0", Offset = "0x3B5F8C0", VA = "0x183B60EC0")]
	public EACHHCKPEDE(IEnumerable<TData> NHJDBLOCBFH, JKHIHEHMHKN GNADFIPFMAK, AJGLBKGCGHL FLBCMGELMBF, float IIFFHIAMFNG, bool GKJGAMBJMEJ, NBDJPLDOABH<TData> PHIEHPFGCDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x3B60E00", Offset = "0x3B5F800", VA = "0x183B60E00", Slot = "4")]
	public override bool EJNOFFABAJA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public class NPCFHNLDCHP<TData> : MGMDGLHFMCE<FOJHFMMHEDE<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private readonly GJIKKOPFKDB<TData> BAHEBKDCBCC;

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x49568C0", Offset = "0x49552C0", VA = "0x1849568C0")]
	public NPCFHNLDCHP(TData[] NHJDBLOCBFH, JKHIHEHMHKN[] GNADFIPFMAK, AJGLBKGCGHL[] FLBCMGELMBF, float[] IIFFHIAMFNG, FOJHFMMHEDE<TData> PHIEHPFGCDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x414D780", Offset = "0x414C180", VA = "0x18414D780", Slot = "4")]
	public override bool EJNOFFABAJA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public class JKGGFBOPOEK<TData> : MGMDGLHFMCE<CGNGAPAFPCI<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x3F04DD0", Offset = "0x3F037D0", VA = "0x183F04DD0")]
	public JKGGFBOPOEK(CGNGAPAFPCI<TData> PHIEHPFGCDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x443C3D0", Offset = "0x443ADD0", VA = "0x18443C3D0", Slot = "4")]
	public override bool EJNOFFABAJA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public class ALDGLLBFMDC<TData> : MGMDGLHFMCE<CGNGAPAFPCI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly JGFMBFCLHAF<TData> BAHEBKDCBCC;

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x414D840", Offset = "0x414C240", VA = "0x18414D840")]
	public ALDGLLBFMDC(IEnumerable<TData> NHJDBLOCBFH, JKHIHEHMHKN GNADFIPFMAK, AJGLBKGCGHL FLBCMGELMBF, float IIFFHIAMFNG, CGNGAPAFPCI<TData> PHIEHPFGCDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x414D780", Offset = "0x414C180", VA = "0x18414D780", Slot = "4")]
	public override bool EJNOFFABAJA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public struct MHNKAFMCILL<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public IEnumerable<TData> FHAEPMAPDHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public JKHIHEHMHKN OINFOILACMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public AJGLBKGCGHL NKKCKOMLDBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public float IIFFHIAMFNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public bool GKJGAMBJMEJ;

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x48BC9E0", Offset = "0x48BB3E0", VA = "0x1848BC9E0")]
	public MHNKAFMCILL(IEnumerable<TData> NHJDBLOCBFH, JKHIHEHMHKN GNADFIPFMAK, AJGLBKGCGHL FLBCMGELMBF, float IIFFHIAMFNG, bool GKJGAMBJMEJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public struct GJIKKOPFKDB<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public TData[] FHAEPMAPDHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public JKHIHEHMHKN[] OINFOILACMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public AJGLBKGCGHL[] NKKCKOMLDBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public float[] IIFFHIAMFNG;

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x410BEA0", Offset = "0x410A8A0", VA = "0x18410BEA0")]
	public GJIKKOPFKDB(TData[] NHJDBLOCBFH, JKHIHEHMHKN[] GNADFIPFMAK, AJGLBKGCGHL[] FLBCMGELMBF, float[] IIFFHIAMFNG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public struct JGFMBFCLHAF<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public IEnumerable<TData> FHAEPMAPDHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public JKHIHEHMHKN OINFOILACMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public AJGLBKGCGHL NKKCKOMLDBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public float IIFFHIAMFNG;

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x4426F40", Offset = "0x4425940", VA = "0x184426F40")]
	public JGFMBFCLHAF(IEnumerable<TData> NHJDBLOCBFH, JKHIHEHMHKN GNADFIPFMAK, AJGLBKGCGHL FLBCMGELMBF, float IIFFHIAMFNG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public interface DFDEFOEGBBF<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BMALCKCKLOL([In] IIMLMAALLKB<TData> OKEPFKDBMMJ);

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PBDJPDIHLLO([In] IIMLMAALLKB<TData> OKEPFKDBMMJ);

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AKCIPFJHGDF([In] bool DEPDDBCLFPI);

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool PIDONDKOCIH([In] IIMLMAALLKB<TData> OKEPFKDBMMJ);

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NALOPPJLNLA();

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool KKPCECJBJIK([In] TData COMODBAAJBB);
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public class EJKNEGLJHBL<TData> : MGMDGLHFMCE<DFDEFOEGBBF<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly IIMLMAALLKB<TData> OKEPFKDBMMJ;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x3B7E850", Offset = "0x3B7D250", VA = "0x183B7E850")]
	public EJKNEGLJHBL(List<TData> FAPCKKJDJFC, DFDEFOEGBBF<TData> PHIEHPFGCDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x3B60E00", Offset = "0x3B5F800", VA = "0x183B60E00", Slot = "4")]
	public override bool EJNOFFABAJA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class PGKANHLCHNP<TData> : MGMDGLHFMCE<DFDEFOEGBBF<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x3F04DD0", Offset = "0x3F037D0", VA = "0x183F04DD0")]
	public PGKANHLCHNP(DFDEFOEGBBF<TData> PHIEHPFGCDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x4B6AF90", Offset = "0x4B69990", VA = "0x184B6AF90", Slot = "4")]
	public override bool EJNOFFABAJA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class JALJCMPMLAN<TData> : MGMDGLHFMCE<DFDEFOEGBBF<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly bool GKJGAMBJMEJ;

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x4403040", Offset = "0x4401A40", VA = "0x184403040")]
	public JALJCMPMLAN(bool GKJGAMBJMEJ, DFDEFOEGBBF<TData> PHIEHPFGCDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x4402FE0", Offset = "0x44019E0", VA = "0x184402FE0", Slot = "4")]
	public override bool EJNOFFABAJA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class APGGKADHDFN<TData> : MGMDGLHFMCE<DFDEFOEGBBF<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly IIMLMAALLKB<TData> OKEPFKDBMMJ;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x427ABF0", Offset = "0x42795F0", VA = "0x18427ABF0")]
	public APGGKADHDFN(List<TData> FAPCKKJDJFC, bool GKJGAMBJMEJ, DFDEFOEGBBF<TData> PHIEHPFGCDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x427AB30", Offset = "0x4279530", VA = "0x18427AB30", Slot = "4")]
	public override bool EJNOFFABAJA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public class KEBKJPBJJMM<TData> : MGMDGLHFMCE<DFDEFOEGBBF<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private readonly TData COMODBAAJBB;

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x4520C60", Offset = "0x451F660", VA = "0x184520C60")]
	public KEBKJPBJJMM(TData COMODBAAJBB, DFDEFOEGBBF<TData> PHIEHPFGCDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x4520B90", Offset = "0x451F590", VA = "0x184520B90", Slot = "4")]
	public override bool EJNOFFABAJA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public class FLIHAMDNEIF<TData> : MGMDGLHFMCE<DFDEFOEGBBF<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly IIMLMAALLKB<TData> OKEPFKDBMMJ;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x3FC3530", Offset = "0x3FC1F30", VA = "0x183FC3530")]
	public FLIHAMDNEIF(IEnumerable<TData> FAPCKKJDJFC, DFDEFOEGBBF<TData> PHIEHPFGCDC, bool GKJGAMBJMEJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x3FC33B0", Offset = "0x3FC1DB0", VA = "0x183FC33B0", Slot = "4")]
	public override bool EJNOFFABAJA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public struct IIMLMAALLKB<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public IEnumerable<TData> FHAEPMAPDHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public bool GKJGAMBJMEJ;

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x4251EC0", Offset = "0x42508C0", VA = "0x184251EC0")]
	public IIMLMAALLKB(IEnumerable<TData> FPJEGABFKGH, bool FJIGICPEPKM = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public interface HAMINFLIKCJ
{
	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<OGKKJOODILP> EJNOFFABAJA(JNPPGLHJLNA NGMKIGHKOGO);
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class HPIEOGDMHCD : OAMABEFOLMB<HAMINFLIKCJ, OGKKJOODILP>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private struct JFNLHHOJPLJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public AsyncTaskMethodBuilder<OGKKJOODILP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public HPIEOGDMHCD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private TaskAwaiter<OGKKJOODILP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x6E41190", Offset = "0x6E3FB90", VA = "0x186E41190", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x6E41410", Offset = "0x6E3FE10", VA = "0x186E41410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly JNPPGLHJLNA GGOIOMEEPNC;

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x6E40BD0", Offset = "0x6E3F5D0", VA = "0x186E40BD0")]
	public HPIEOGDMHCD(bool GKJGAMBJMEJ, HAMINFLIKCJ PHIEHPFGCDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6E40AE0", Offset = "0x6E3F4E0", VA = "0x186E40AE0", Slot = "4")]
	[AsyncStateMachine(typeof(JFNLHHOJPLJ))]
	public override Task<OGKKJOODILP> EJNOFFABAJA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public struct JNPPGLHJLNA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public bool PKPPCCCEBGJ;

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x2452AC0", Offset = "0x24514C0", VA = "0x182452AC0")]
	public JNPPGLHJLNA(bool GKJGAMBJMEJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public readonly struct LCCPLHPGBPJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public readonly bool DKBIIBBLDNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public readonly bool PIENAOOOECM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public readonly bool ECGPBBOMOPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public readonly bool GKJGAMBJMEJ;

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x50FECC0", Offset = "0x50FD6C0", VA = "0x1850FECC0")]
	public LCCPLHPGBPJ(bool DKBIIBBLDNB, bool PIENAOOOECM, bool ECGPBBOMOPD, bool GKJGAMBJMEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x6E41B90", Offset = "0x6E40590", VA = "0x186E41B90")]
	public LCCPLHPGBPJ(bool PIENAOOOECM, bool GKJGAMBJMEJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public interface FDOMDMNIICP
{
	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FEDLPJLGLIO(LCCPLHPGBPJ DMLMMBAILOF);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CEKKBEAOEHA(LCCPLHPGBPJ DMLMMBAILOF);
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class FODCMDIMMNN : MGMDGLHFMCE<FDOMDMNIICP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly LCCPLHPGBPJ DMLMMBAILOF;

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x6E40A10", Offset = "0x6E3F410", VA = "0x186E40A10")]
	public FODCMDIMMNN(bool FOBEMKFOBOH, bool PIENAOOOECM, bool ECGPBBOMOPD, bool GKJGAMBJMEJ, FDOMDMNIICP PHIEHPFGCDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6E409C0", Offset = "0x6E3F3C0", VA = "0x186E409C0", Slot = "4")]
	public override bool EJNOFFABAJA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class PMPJKGONABF : MGMDGLHFMCE<FDOMDMNIICP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly LCCPLHPGBPJ DMLMMBAILOF;

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x6E42140", Offset = "0x6E40B40", VA = "0x186E42140")]
	public PMPJKGONABF(bool PIENAOOOECM, bool GKJGAMBJMEJ, FDOMDMNIICP PHIEHPFGCDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x6E420F0", Offset = "0x6E40AF0", VA = "0x186E420F0", Slot = "4")]
	public override bool EJNOFFABAJA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public interface ILEMBMJNMDG
{
	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EJNOFFABAJA([In] CHHOAPAHIDI DKIHCLMDNOK);
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public class KGEKALPCGNF : MGMDGLHFMCE<ILEMBMJNMDG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly CHHOAPAHIDI DKIHCLMDNOK;

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x6E41530", Offset = "0x6E3FF30", VA = "0x186E41530")]
	public KGEKALPCGNF(Guid[] AAKFIPHODBC, Vector3[] GLALFJIFMEH, Quaternion[] KAAHMJMNCDA, float[] MLCBMOABJEG, Dictionary<Guid, Vector3> NOPCHJCBKLE, ILEMBMJNMDG PHIEHPFGCDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x6E41480", Offset = "0x6E3FE80", VA = "0x186E41480", Slot = "4")]
	public override bool EJNOFFABAJA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public interface LFLADHIOBFN<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IJCHMIJCPJC([In] IKPHNJONJHK<TData> NLIMHPMHADL);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KNMJLGOGAPJ([In] CHENJCOEAFA GKGGGIJHNPA);

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool KNMJLGOGAPJ([In] FNIICFDKJNH GKGGGIJHNPA);

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool KKGJDFIPCFA();
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public class JPLIILFLECO<TData> : MGMDGLHFMCE<LFLADHIOBFN<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x3F04DD0", Offset = "0x3F037D0", VA = "0x183F04DD0")]
	public JPLIILFLECO(LFLADHIOBFN<TData> PHIEHPFGCDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x4446CD0", Offset = "0x44456D0", VA = "0x184446CD0", Slot = "4")]
	public override bool EJNOFFABAJA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public class NPJEILGGKGI<TData> : MGMDGLHFMCE<LFLADHIOBFN<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private readonly CHENJCOEAFA PBGIIPBKAPC;

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x496DE70", Offset = "0x496C870", VA = "0x18496DE70")]
	public NPJEILGGKGI(Vector3 ALFDOMNIHNN, bool HKMNPAAAEME, LFLADHIOBFN<TData> PHIEHPFGCDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x3F11680", Offset = "0x3F10080", VA = "0x183F11680", Slot = "4")]
	public override bool EJNOFFABAJA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public class DKOMNEDDPEI<TData> : MGMDGLHFMCE<LFLADHIOBFN<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private readonly FNIICFDKJNH PBGIIPBKAPC;

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x5C891B0", Offset = "0x5C87BB0", VA = "0x185C891B0")]
	public DKOMNEDDPEI(Guid JOBEMBPGFMB, int GCBONJOGHCD, Vector3 PCPIJKGKPCE, Quaternion MHLCHCEFDAI, float JNPCONGOFCD, bool HKMNPAAAEME, LFLADHIOBFN<TData> PHIEHPFGCDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x5C89150", Offset = "0x5C87B50", VA = "0x185C89150", Slot = "4")]
	public override bool EJNOFFABAJA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public class CGFGLNFNLEP<TData> : MGMDGLHFMCE<LFLADHIOBFN<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private readonly IKPHNJONJHK<TData> PBGIIPBKAPC;

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x5410090", Offset = "0x540EA90", VA = "0x185410090")]
	public CGFGLNFNLEP(TData PCFKCJNPKCO, bool GKJGAMBJMEJ, LFLADHIOBFN<TData> PHIEHPFGCDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x3B60E00", Offset = "0x3B5F800", VA = "0x183B60E00", Slot = "4")]
	public override bool EJNOFFABAJA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public struct CHENJCOEAFA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public readonly Vector3 ALFDOMNIHNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public readonly bool HKMNPAAAEME;

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x6E401F0", Offset = "0x6E3EBF0", VA = "0x186E401F0")]
	public CHENJCOEAFA(Vector3 ALFDOMNIHNN, bool HKMNPAAAEME)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public struct FNIICFDKJNH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public readonly Guid JOBEMBPGFMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public readonly int GCBONJOGHCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public readonly Vector3 PCPIJKGKPCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public readonly Quaternion MHLCHCEFDAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public readonly float JNPCONGOFCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public readonly bool HKMNPAAAEME;

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x6E40980", Offset = "0x6E3F380", VA = "0x186E40980")]
	public FNIICFDKJNH(Guid JOBEMBPGFMB, int GCBONJOGHCD, Vector3 PCPIJKGKPCE, Quaternion MHLCHCEFDAI, float JNPCONGOFCD, bool HKMNPAAAEME)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public struct IKPHNJONJHK<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public readonly TData PCFKCJNPKCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public readonly bool GKJGAMBJMEJ;

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x4258370", Offset = "0x4256D70", VA = "0x184258370")]
	public IKPHNJONJHK(TData PCFKCJNPKCO, bool GKJGAMBJMEJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public interface MHIOGHGFBEH<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EJNOFFABAJA([In] FGJLKGLDNJJ<TData> KJFAKGNJKJI);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool EJNOFFABAJA([In] MIBNNPHIDGA<TData> KJFAKGNJKJI);
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public interface DAMMJKCGNFE<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IJCHMIJCPJC([In] GEDEJDAJMLN<TData> BJMEJNNILPL);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KNMJLGOGAPJ([In] EAPLLLGOPDB GKGGGIJHNPA);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool KKGJDFIPCFA();
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class FCOCEOGAKOA<TData> : MGMDGLHFMCE<MHIOGHGFBEH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private readonly FGJLKGLDNJJ<TData> KJFAKGNJKJI;

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x3F14FE0", Offset = "0x3F139E0", VA = "0x183F14FE0")]
	public FCOCEOGAKOA(IEnumerable<TData> NHJDBLOCBFH, Vector3 HANLCGDKIBK, bool GKJGAMBJMEJ, MHIOGHGFBEH<TData> PHIEHPFGCDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x3B60E00", Offset = "0x3B5F800", VA = "0x183B60E00", Slot = "4")]
	public override bool EJNOFFABAJA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public class NMKGELOKGLI<TData> : MGMDGLHFMCE<DAMMJKCGNFE<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x3F04DD0", Offset = "0x3F037D0", VA = "0x183F04DD0")]
	public NMKGELOKGLI(DAMMJKCGNFE<TData> PHIEHPFGCDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x4160B00", Offset = "0x415F500", VA = "0x184160B00", Slot = "4")]
	public override bool EJNOFFABAJA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public class DJFBCIHFOBF<TData> : MGMDGLHFMCE<DAMMJKCGNFE<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly GEDEJDAJMLN<TData> KJFAKGNJKJI;

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x5C88070", Offset = "0x5C86A70", VA = "0x185C88070")]
	public DJFBCIHFOBF(IEnumerable<TData> NHJDBLOCBFH, bool GKJGAMBJMEJ, DAMMJKCGNFE<TData> PHIEHPFGCDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x3B60E00", Offset = "0x3B5F800", VA = "0x183B60E00", Slot = "4")]
	public override bool EJNOFFABAJA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public class CJDEEPKGEPP<TData> : MGMDGLHFMCE<MHIOGHGFBEH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private readonly MIBNNPHIDGA<TData> KJFAKGNJKJI;

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x5604E60", Offset = "0x5603860", VA = "0x185604E60")]
	public CJDEEPKGEPP(IEnumerable<TData> NHJDBLOCBFH, Vector3 OBJLMOMNDFH, OAEDKJBIFGC FMJEDHOKDLF, bool GKJGAMBJMEJ, MHIOGHGFBEH<TData> PHIEHPFGCDC, Space OGAPFKOLOCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x4A59570", Offset = "0x4A57F70", VA = "0x184A59570", Slot = "4")]
	public override bool EJNOFFABAJA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class NIFDEENPIKL<TData> : MGMDGLHFMCE<DAMMJKCGNFE<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private readonly EAPLLLGOPDB KJFAKGNJKJI;

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x4945F90", Offset = "0x4944990", VA = "0x184945F90")]
	public NIFDEENPIKL(Vector3 HANLCGDKIBK, DAMMJKCGNFE<TData> PHIEHPFGCDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x3F11680", Offset = "0x3F10080", VA = "0x183F11680", Slot = "4")]
	public override bool EJNOFFABAJA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public struct FGJLKGLDNJJ<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public readonly IEnumerable<TData> NHJDBLOCBFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public readonly Vector3 HANLCGDKIBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public readonly bool GKJGAMBJMEJ;

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x3F895C0", Offset = "0x3F87FC0", VA = "0x183F895C0")]
	public FGJLKGLDNJJ(IEnumerable<TData> NHJDBLOCBFH, Vector3 HANLCGDKIBK, bool GKJGAMBJMEJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public struct GEDEJDAJMLN<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public readonly IEnumerable<TData> NHJDBLOCBFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public readonly bool GKJGAMBJMEJ;

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x40E3D10", Offset = "0x40E2710", VA = "0x1840E3D10")]
	public GEDEJDAJMLN(IEnumerable<TData> NHJDBLOCBFH, bool GKJGAMBJMEJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public struct MIBNNPHIDGA<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public readonly IEnumerable<TData> NHJDBLOCBFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public readonly Vector3 OBJLMOMNDFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public readonly OAEDKJBIFGC FMJEDHOKDLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public readonly bool GKJGAMBJMEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public readonly Space OGAPFKOLOCB;

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x48BF880", Offset = "0x48BE280", VA = "0x1848BF880")]
	public MIBNNPHIDGA(IEnumerable<TData> NHJDBLOCBFH, Vector3 OBJLMOMNDFH, OAEDKJBIFGC FMJEDHOKDLF, bool GKJGAMBJMEJ, Space OGAPFKOLOCB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public struct EAPLLLGOPDB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public readonly Vector3 HANLCGDKIBK;

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x2453950", Offset = "0x2452350", VA = "0x182453950")]
	public EAPLLLGOPDB(Vector3 HANLCGDKIBK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public enum OAEDKJBIFGC
{
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	XYZ,
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	X_only,
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	Y_only,
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	Z_only
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public interface JAIIDHKPEPJ
{
	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EJNOFFABAJA([In] MJMIJJNLPNK NPPFEEONJEF);
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public class MILPPJGDHMB : MGMDGLHFMCE<JAIIDHKPEPJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly MJMIJJNLPNK NPPFEEONJEF;

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x6E41C50", Offset = "0x6E40650", VA = "0x186E41C50")]
	public MILPPJGDHMB(bool GKJGAMBJMEJ, JAIIDHKPEPJ PHIEHPFGCDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x6E41BA0", Offset = "0x6E405A0", VA = "0x186E41BA0", Slot = "4")]
	public override bool EJNOFFABAJA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public readonly struct MJMIJJNLPNK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public readonly bool GKJGAMBJMEJ;

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x2452AC0", Offset = "0x24514C0", VA = "0x182452AC0")]
	public MJMIJJNLPNK(bool GKJGAMBJMEJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public interface KMPCKNLOFFD<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EJNOFFABAJA([In] BGFLHIAAFCO<TData> GGEADHLPIMO);

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool EJNOFFABAJA([In] EPKLIOIBIOC<TData> GGEADHLPIMO);
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public interface FOGICLJBFDG<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IJCHMIJCPJC([In] HLPGFOPOCHL<TData> NLIMHPMHADL);

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KNMJLGOGAPJ([In] PJBDMJDBBEP GKGGGIJHNPA);

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool KKGJDFIPCFA();
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public class AJAFKCCCIKJ<TData> : MGMDGLHFMCE<KMPCKNLOFFD<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly BGFLHIAAFCO<TData> GGEADHLPIMO;

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x4146AD0", Offset = "0x41454D0", VA = "0x184146AD0")]
	public AJAFKCCCIKJ(IEnumerable<TData> NHJDBLOCBFH, Quaternion HANLCGDKIBK, Vector3? GLKGHCDKGEO, bool GCKGPNMBAFB, bool GKJGAMBJMEJ, KMPCKNLOFFD<TData> PHIEHPFGCDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x3B60E00", Offset = "0x3B5F800", VA = "0x183B60E00", Slot = "4")]
	public override bool EJNOFFABAJA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public class LKJNEFHMCKD<TData> : MGMDGLHFMCE<FOGICLJBFDG<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x3F04DD0", Offset = "0x3F037D0", VA = "0x183F04DD0")]
	public LKJNEFHMCKD(FOGICLJBFDG<TData> PHIEHPFGCDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x4160B00", Offset = "0x415F500", VA = "0x184160B00", Slot = "4")]
	public override bool EJNOFFABAJA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public class KLCENPCBHPK<TData> : MGMDGLHFMCE<FOGICLJBFDG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly HLPGFOPOCHL<TData> GGEADHLPIMO;

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x4562A40", Offset = "0x4561440", VA = "0x184562A40")]
	public KLCENPCBHPK(IEnumerable<TData> NHJDBLOCBFH, bool GKJGAMBJMEJ, FOGICLJBFDG<TData> PHIEHPFGCDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x3B60E00", Offset = "0x3B5F800", VA = "0x183B60E00", Slot = "4")]
	public override bool EJNOFFABAJA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public class BIPHOLNAAHA<TData> : MGMDGLHFMCE<KMPCKNLOFFD<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly EPKLIOIBIOC<TData> GGEADHLPIMO;

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x5295910", Offset = "0x5294310", VA = "0x185295910")]
	public BIPHOLNAAHA(IEnumerable<TData> NHJDBLOCBFH, Quaternion MIHHICGJLOE, OAEDKJBIFGC JJJCGHJCNLH, Vector3? GLKGHCDKGEO, bool GCKGPNMBAFB, bool GKJGAMBJMEJ, Space OGAPFKOLOCB, KMPCKNLOFFD<TData> PHIEHPFGCDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x4A59570", Offset = "0x4A57F70", VA = "0x184A59570", Slot = "4")]
	public override bool EJNOFFABAJA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public class MDJFANDKIOK<TData> : MGMDGLHFMCE<FOGICLJBFDG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly PJBDMJDBBEP GGEADHLPIMO;

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x489A680", Offset = "0x4899080", VA = "0x18489A680")]
	public MDJFANDKIOK(Quaternion HANLCGDKIBK, Vector3? GLKGHCDKGEO, bool GCKGPNMBAFB, FOGICLJBFDG<TData> PHIEHPFGCDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x3F11680", Offset = "0x3F10080", VA = "0x183F11680", Slot = "4")]
	public override bool EJNOFFABAJA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public struct BGFLHIAAFCO<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public readonly IEnumerable<TData> NHJDBLOCBFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public readonly Quaternion HANLCGDKIBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public readonly Vector3? GLKGHCDKGEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public readonly bool GCKGPNMBAFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public readonly bool GKJGAMBJMEJ;

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x527A180", Offset = "0x5278B80", VA = "0x18527A180")]
	public BGFLHIAAFCO(IEnumerable<TData> NHJDBLOCBFH, Quaternion HANLCGDKIBK, Vector3? GLKGHCDKGEO, bool GCKGPNMBAFB, bool GKJGAMBJMEJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public struct HLPGFOPOCHL<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public readonly IEnumerable<TData> NHJDBLOCBFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public readonly bool GKJGAMBJMEJ;

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x41913A0", Offset = "0x418FDA0", VA = "0x1841913A0")]
	public HLPGFOPOCHL(IEnumerable<TData> NHJDBLOCBFH, bool GKJGAMBJMEJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public struct EPKLIOIBIOC<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public readonly IEnumerable<TData> NHJDBLOCBFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public readonly Quaternion MIHHICGJLOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public readonly OAEDKJBIFGC JJJCGHJCNLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	public readonly Vector3? GLKGHCDKGEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	public readonly bool GCKGPNMBAFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public readonly bool GKJGAMBJMEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public readonly Space OGAPFKOLOCB;

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x3BAB4B0", Offset = "0x3BA9EB0", VA = "0x183BAB4B0")]
	public EPKLIOIBIOC(IEnumerable<TData> NHJDBLOCBFH, Quaternion MIHHICGJLOE, OAEDKJBIFGC JJJCGHJCNLH, Vector3? GLKGHCDKGEO, bool GCKGPNMBAFB, bool GKJGAMBJMEJ, Space OGAPFKOLOCB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public struct PJBDMJDBBEP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public readonly Quaternion HANLCGDKIBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public readonly Vector3? GLKGHCDKGEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public readonly bool GCKGPNMBAFB;

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x50A8CC0", Offset = "0x50A76C0", VA = "0x1850A8CC0")]
	public PJBDMJDBBEP(Quaternion HANLCGDKIBK, Vector3? GLKGHCDKGEO, bool GCKGPNMBAFB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public interface ANMGAAGIHEB<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IJCHMIJCPJC([In] MDIDPFDCPID<TData> NLIMHPMHADL);

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KNMJLGOGAPJ([In] OIHCIBDKBOP GKGGGIJHNPA);

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool KNMJLGOGAPJ([In] BAGJBIOFDMH GKGGGIJHNPA);

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool KNMJLGOGAPJ([In] GGDINPBJIFD GKGGGIJHNPA);

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool KKGJDFIPCFA();
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public class DPKBELHMCMD<TData> : MGMDGLHFMCE<ANMGAAGIHEB<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private readonly GGDINPBJIFD JABIAPKMAKF;

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x5C915C0", Offset = "0x5C8FFC0", VA = "0x185C915C0")]
	public DPKBELHMCMD(Vector3 EPKMIKMNPKJ, float BPHGKAKALMD, Vector3 GLKGHCDKGEO, bool IAGOOKHLNIC, bool KJHGGAOCMDD, ANMGAAGIHEB<TData> PHIEHPFGCDC, Space OGAPFKOLOCB = Space.Self)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x5C91560", Offset = "0x5C8FF60", VA = "0x185C91560", Slot = "4")]
	public override bool EJNOFFABAJA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public class CKNAAKJEHGA<TData> : MGMDGLHFMCE<ANMGAAGIHEB<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x3F04DD0", Offset = "0x3F037D0", VA = "0x183F04DD0")]
	public CKNAAKJEHGA(ANMGAAGIHEB<TData> PHIEHPFGCDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x560EB70", Offset = "0x560D570", VA = "0x18560EB70", Slot = "4")]
	public override bool EJNOFFABAJA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public class IEJEKGAOCKF<TData> : MGMDGLHFMCE<ANMGAAGIHEB<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private readonly MDIDPFDCPID<TData> JABIAPKMAKF;

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x42491D0", Offset = "0x4247BD0", VA = "0x1842491D0")]
	public IEJEKGAOCKF(IEnumerable<TData> NHJDBLOCBFH, bool GKJGAMBJMEJ, ANMGAAGIHEB<TData> PHIEHPFGCDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x3B60E00", Offset = "0x3B5F800", VA = "0x183B60E00", Slot = "4")]
	public override bool EJNOFFABAJA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public class CILJKGFDHPF<TData> : MGMDGLHFMCE<ANMGAAGIHEB<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private readonly BAGJBIOFDMH JABIAPKMAKF;

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x5604660", Offset = "0x5603060", VA = "0x185604660")]
	public CILJKGFDHPF(float MFPIALHDKPJ, bool OPCGGOHIGHA, Vector3 GLKGHCDKGEO, ANMGAAGIHEB<TData> PHIEHPFGCDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x5604590", Offset = "0x5602F90", VA = "0x185604590", Slot = "4")]
	public override bool EJNOFFABAJA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public class FALIOIGNIBJ<TData> : MGMDGLHFMCE<ANMGAAGIHEB<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private readonly OIHCIBDKBOP JABIAPKMAKF;

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x3F116E0", Offset = "0x3F100E0", VA = "0x183F116E0")]
	public FALIOIGNIBJ(float BPHGKAKALMD, Vector3 GLKGHCDKGEO, ANMGAAGIHEB<TData> PHIEHPFGCDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x3F11680", Offset = "0x3F10080", VA = "0x183F11680", Slot = "4")]
	public override bool EJNOFFABAJA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public struct GGDINPBJIFD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public readonly Vector3 EPKMIKMNPKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public readonly float BPHGKAKALMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public readonly Vector3 GLKGHCDKGEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public readonly bool HKMNPAAAEME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public readonly Space OGAPFKOLOCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public readonly bool KJHGGAOCMDD;

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x6E40AA0", Offset = "0x6E3F4A0", VA = "0x186E40AA0")]
	public GGDINPBJIFD(Vector3 EPKMIKMNPKJ, float BPHGKAKALMD, Vector3 GLKGHCDKGEO, bool HKMNPAAAEME, bool KLEPOKAMCCE, Space OGAPFKOLOCB = Space.Self)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public struct MDIDPFDCPID<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public readonly IEnumerable<TData> NHJDBLOCBFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public readonly bool GKJGAMBJMEJ;

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x4899B40", Offset = "0x4898540", VA = "0x184899B40")]
	public MDIDPFDCPID(IEnumerable<TData> NHJDBLOCBFH, bool GKJGAMBJMEJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public struct BAGJBIOFDMH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public readonly float MFPIALHDKPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public readonly bool OPCGGOHIGHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public readonly Vector3 GLKGHCDKGEO;

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x6E401B0", Offset = "0x6E3EBB0", VA = "0x186E401B0")]
	public BAGJBIOFDMH(float MFPIALHDKPJ, bool OPCGGOHIGHA, Vector3 GLKGHCDKGEO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public struct OIHCIBDKBOP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public readonly float BPHGKAKALMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public readonly Vector3 GLKGHCDKGEO;

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x5086AC0", Offset = "0x50854C0", VA = "0x185086AC0")]
	public OIHCIBDKBOP(float BPHGKAKALMD, Vector3 GLKGHCDKGEO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public struct CHHOAPAHIDI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public readonly Guid[] NHJDBLOCBFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public readonly bool BIBMMEINAIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public readonly bool NHCCMDNIFGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public readonly bool KPBIPOENPFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public readonly Vector3[] GLALFJIFMEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public readonly Quaternion[] KAAHMJMNCDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public readonly float[] MLCBMOABJEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public readonly Dictionary<Guid, Vector3> NOPCHJCBKLE;

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x6E403E0", Offset = "0x6E3EDE0", VA = "0x186E403E0")]
	public CHHOAPAHIDI(Guid[] AAKFIPHODBC, Vector3[] GLALFJIFMEH, Quaternion[] KAAHMJMNCDA, float[] MLCBMOABJEG, Dictionary<Guid, Vector3> NOPCHJCBKLE, bool BIBMMEINAIJ = true, bool NHCCMDNIFGI = true, bool KPBIPOENPFO = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x6E40210", Offset = "0x6E3EC10", VA = "0x186E40210")]
	private static void JKIGDGPOCLB(Dictionary<Guid, Vector3> NOPCHJCBKLE, int ECNMBIHHLCI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public static class IJKBKLMNIBL
{
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	private struct JOPMPJOONBC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public bool OGAKDCBHIGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public KNPHAFHLPCE ILMFPBOLFLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public KNPHAFHLPCE NEEPPAEANJF;
	}

	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private static JOPMPJOONBC JEJPGPFOJMM;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static CancellationToken NMEFDPMOOJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x6E40F90", Offset = "0x6E3F990", VA = "0x186E40F90")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	internal static KNPHAFHLPCE ILMFPBOLFLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x6E41000", Offset = "0x6E3FA00", VA = "0x186E41000")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x6E40F30", Offset = "0x6E3F930", VA = "0x186E40F30")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x6E410A0", Offset = "0x6E3FAA0", VA = "0x186E410A0")]
	[EPFHFFCDLIN.KDFGAEMPDLG]
	internal static void LAKIIFNFKHP(KNPHAFHLPCE OABFIFCNGLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x6E40DE0", Offset = "0x6E3F7E0", VA = "0x186E40DE0")]
	public static void ENPPBKGKMKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x6E40FB0", Offset = "0x6E3F9B0", VA = "0x186E40FB0")]
	private static KNPHAFHLPCE FPHKIMMCIFK(KNPHAFHLPCE HHNKILPHFCD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
public static class HDEDHEBLEKF
{
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public enum CJADJFOKONL
	{
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		ICreationContextObject,
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		Guid
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x2EFBB40", Offset = "0x2EFA540", VA = "0x182EFBB40")]
	public static void LPOJMJDGPAJ<T>(T NGPNBABCJIN, CJADJFOKONL BKKHBFLPOHJ) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x2EFBCB0", Offset = "0x2EFA6B0", VA = "0x182EFBCB0")]
	public static void LPOJMJDGPAJ<T>(T NGPNBABCJIN) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x2EFB8D0", Offset = "0x2EFA2D0", VA = "0x182EFB8D0")]
	public static void IDACGGIFJCC<T>(T NGPNBABCJIN) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x2EFB9E0", Offset = "0x2EFA3E0", VA = "0x182EFB9E0")]
	public static T KJCABELIABF<T>(CJADJFOKONL BKKHBFLPOHJ) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x2EFB6C0", Offset = "0x2EFA0C0", VA = "0x182EFB6C0")]
	public static bool HCJNPMNOANM<T>(CJADJFOKONL BKKHBFLPOHJ, T? DOILLENLJPH, [Out][NotNullWhen(true)][MaybeNullWhen(false)] T LKNBEKCNFJI) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x2EFBA90", Offset = "0x2EFA490", VA = "0x182EFBA90")]
	public static bool LOGGKDBGPIB<T>(CJADJFOKONL BKKHBFLPOHJ) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x2EFB980", Offset = "0x2EFA380", VA = "0x182EFB980")]
	public static T KJCABELIABF<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x2EFB810", Offset = "0x2EFA210", VA = "0x182EFB810")]
	public static bool HCJNPMNOANM<T>(T DOILLENLJPH, [Out] T LKNBEKCNFJI) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x2EFB980", Offset = "0x2EFA380", VA = "0x182EFB980")]
	public static bool LOGGKDBGPIB<T>() where T : class
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
internal static class NOOLNCCLFKO
{
	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x6E41E00", Offset = "0x6E40800", VA = "0x186E41E00")]
	public static void HBCHAMKIMPM(IEnumerable DDDCDOONMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x3057990", Offset = "0x3056390", VA = "0x183057990")]
	public static void HBCHAMKIMPM<T>(T[] LOCJOHPCANM) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x3057A80", Offset = "0x3056480", VA = "0x183057A80")]
	public static void HBCHAMKIMPM<T>(T COJJJGIBKEK) where T : notnull, Enum
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
