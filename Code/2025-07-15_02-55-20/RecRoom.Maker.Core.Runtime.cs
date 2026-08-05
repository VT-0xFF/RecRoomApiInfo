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
		[Cpp2IlInjected.Address(RVA = "0xA873F0", Offset = "0xA85FF0", VA = "0x180A873F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x815BC00", Offset = "0x815A800", VA = "0x18815BC00")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA87960", Offset = "0xA86560", VA = "0x180A87960")]
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
		[Cpp2IlInjected.Address(RVA = "0xA879A0", Offset = "0xA865A0", VA = "0x180A879A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x815C230", Offset = "0x815AE30", VA = "0x18815C230", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x28B3880", Offset = "0x28B2480", VA = "0x1828B3880")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum JDGJFFGLJPK
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	ShowFreeInventionsInR2PaletteSearch
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum EOJCPGKEDLP
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
public interface MAMKLMJNJJO<TData, TReturn>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TReturn MPMOBJGNFEL(TData KOJLNGLNBMH);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface DLMMONIBDDI<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ClearHoverTarget(LAPLBNLJIBM HIFDEOPGBPA);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool SetHoverTarget(TData ADGCHNLKFKK, Collider NKGDEMNCDMC, LAPLBNLJIBM HIFDEOPGBPA, [Optional] HEODKAOIMMP? KLDOKOMDPGD);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool TryGetHoverTarget([Out] TData ADGCHNLKFKK);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool TryGetHoverCollider([Out] Collider NKGDEMNCDMC);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface BIIFLFHAKOH<TData> : PCBHADDHJNL, OGKBOPBMDFG<TData>, DLLJAGKOAFN<TData>, LJGLMJEKMMC<TData>, JMGEPGMKJHD, BGKCJIHFAFK<TData>, NLCJJCMBLIA, DJHEAPNINPO
{
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface BGKCJIHFAFK<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool Raycast(Vector3 PFKAKKFNLEP, Vector3 DBIJDHDPOAF, float FKJNFPHAHOE, [Out] T BKCMGPGLFFD, [Out] Vector3 MPCKPJAOCAE, [Out] Collider NKGDEMNCDMC);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int SpherecastPick(Vector3 PFKAKKFNLEP, Vector3 DBIJDHDPOAF, float JBAKPDFMJPJ, float FKJNFPHAHOE, T[] KPBLOKAPILA, [Out] Vector3 JDLKKAKPOHC, [Out] Collider MKCGIKHFKII);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int SpherePick(Vector3 PFKAKKFNLEP, float JBAKPDFMJPJ, Vector3 IFOIHKPGGPC, T[] KPBLOKAPILA);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool TryGetObjectFromColliderInCurrentScope(Collider CKPKIHAALAC, [Out] T GLNLALDALND);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface PCBHADDHJNL
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Bounds FMDFOHHNOGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	Transform AMJIBBOLMFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	Bounds HMLAOJFFHCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Transform DDKIOFCMDKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	Vector3 CMLBGPPHLNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool AJLFHAJNODA
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
	void SetSelectionBoundsDirty(bool CFBOPDOLPOK = true, int ENKNGIOEIEH = 0);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void ShouldHideSelectionBoundsPreview(bool POOGJMFDFDI, object DANCOEFIHDF);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface DJHEAPNINPO
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	LKKDMOCNJPN PHKOLLAJLJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface AOLAJDFIIHB
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool CILHCFFHGLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool EJPIOLOCPJF
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool ICPNJMBHLNH
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
	void TrySetPreviousCloneMapping(Dictionary<Guid, Guid> HGOENNHLHAC);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface LJGLMJEKMMC<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool EKJNAACMCPN
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	int BIBDLGODGMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<TData> LNCBEJJNKND
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IsSelected(TData BHNJKAEPJMN);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IsSelectable(TData BHNJKAEPJMN);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface OGKBOPBMDFG<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void RenderHoverHighlight(T KOJLNGLNBMH, [Optional] HEODKAOIMMP? AFOHEDFHHBI, bool IPAPAOBMNHD = true);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RenderHoverHighlight(int NKGPOLKDIPE, IEnumerable<T> FAPPAACKMEM, bool IPAPAOBMNHD = true);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RenderHoverHighlight(int NKGPOLKDIPE, IEnumerable<T> FAPPAACKMEM, HEODKAOIMMP AFOHEDFHHBI, bool IPAPAOBMNHD = true);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface NLCJJCMBLIA
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnSelectionPickedUp();

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnSelectionReleased();
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface JMGEPGMKJHD
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool IKBJCCENPIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool GPJJBFIEENG
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	bool EHEJFJPFILG
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	bool GLELCBIEAMP
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct NCAODOHAOCE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public bool MPNLAEAGNFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public float? EAELFFNNNAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public float? MJJOMEBOGDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public float? GAFHLBEDCFD;
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct LGHDNHIGHIE<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public IEnumerable<TData> FEJDCONKNIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public NCAODOHAOCE PKEIHKFCLGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public bool AHCCKLMJFPK;

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x545FE30", Offset = "0x545EA30", VA = "0x18545FE30")]
	public LGHDNHIGHIE(IEnumerable<TData> AHNBPPOPJNA, bool EDDJBDHNDOE, float? KGHINJENAIK, float? BNBCBHJAJGO, float? FKANJKAMMFE, bool AHCCKLMJFPK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface DIBANKLPNOC<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NDPIAIALAKO([In] LGHDNHIGHIE<TData> AHEPAEIEJIO);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class NEMFEFEIBDK<TData> : OKCFIIOHFDM<DIBANKLPNOC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly LGHDNHIGHIE<TData> AHEPAEIEJIO;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x57091B0", Offset = "0x5707DB0", VA = "0x1857091B0")]
	public NEMFEFEIBDK(IEnumerable<TData> AHNBPPOPJNA, bool EDDJBDHNDOE, float? KGHINJENAIK, float? BNBCBHJAJGO, float? FKANJKAMMFE, bool AHCCKLMJFPK, DIBANKLPNOC<TData> NHJPJMHIKLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x4E8E8D0", Offset = "0x4E8D4D0", VA = "0x184E8E8D0", Slot = "4")]
	public override bool NDPIAIALAKO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct GIOINOKJGFH<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public IEnumerable<TData> FEJDCONKNIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public string JANGKCMCKOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public bool GJIAKIJLBOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public bool AHCCKLMJFPK;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x4EA6AE0", Offset = "0x4EA56E0", VA = "0x184EA6AE0")]
	public GIOINOKJGFH(IEnumerable<TData> AHNBPPOPJNA, string HIGFGBDCIBL, bool MBHHAKEJEJD, bool AHCCKLMJFPK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface PEKFFDJALHL<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NDPIAIALAKO([In] GIOINOKJGFH<TData> AHEPAEIEJIO);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class GFCCBNLPACF<TData> : OKCFIIOHFDM<PEKFFDJALHL<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly GIOINOKJGFH<TData> AHEPAEIEJIO;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x4E8E990", Offset = "0x4E8D590", VA = "0x184E8E990")]
	public GFCCBNLPACF(IEnumerable<TData> AHNBPPOPJNA, string HIGFGBDCIBL, bool MBHHAKEJEJD, bool AHCCKLMJFPK, PEKFFDJALHL<TData> NHJPJMHIKLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x4E8E8D0", Offset = "0x4E8D4D0", VA = "0x184E8E8D0", Slot = "4")]
	public override bool NDPIAIALAKO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public abstract class OKCFIIOHFDM<TReceiver> : PLGLIEEKJPJ<TReceiver, bool> where TReceiver : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x445D2A0", Offset = "0x445BEA0", VA = "0x18445D2A0")]
	public OKCFIIOHFDM(TReceiver NHJPJMHIKLA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public abstract class OPPNAJGLIPC<TReceiver, TFromTask> : PLGLIEEKJPJ<TReceiver, Task<TFromTask>>
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x445D2A0", Offset = "0x445BEA0", VA = "0x18445D2A0")]
	public OPPNAJGLIPC(TReceiver NHJPJMHIKLA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public abstract class PLGLIEEKJPJ<TReceiver, TFromExecute> where TReceiver : notnull where TFromExecute : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	protected TReceiver NHJPJMHIKLA;

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x59DBA10", Offset = "0x59DA610", VA = "0x1859DBA10")]
	public PLGLIEEKJPJ(TReceiver NHJPJMHIKLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TFromExecute NDPIAIALAKO();
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public abstract class DEFHIDPGCFA<TReceiver, TResult> : PLGLIEEKJPJ<TReceiver, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x445D2A0", Offset = "0x445BEA0", VA = "0x18445D2A0")]
	public DEFHIDPGCFA(TReceiver NHJPJMHIKLA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public struct HODEEFIHFDE<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public TGroup JEGDHIKICNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public TData PLJMOAOKBAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public IEnumerable<TData> FEJDCONKNIL;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x1D74E20", Offset = "0x1D73A20", VA = "0x181D74E20")]
	public HODEEFIHFDE(TGroup AJKJIPIDACN, TData GDLKECJKNGA, IEnumerable<TData> AHNBPPOPJNA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct BLEHGNEIDBP<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public TGroup JEGDHIKICNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public IEnumerable<TData> FEJDCONKNIL;

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0xBCEBD0", Offset = "0xBCD7D0", VA = "0x180BCEBD0")]
	public BLEHGNEIDBP(TGroup AJKJIPIDACN, IEnumerable<TData> AHNBPPOPJNA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct FGOEHNKCMHE<TGroup> where TGroup : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public TGroup JEGDHIKICNC;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0xE4EA80", Offset = "0xE4D680", VA = "0x180E4EA80")]
	public FGOEHNKCMHE(TGroup AJKJIPIDACN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public struct JFDFLAAMAPE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public IEnumerable<Guid> FEJDCONKNIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public Guid HMAKMGKMPDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly bool CFGBOJKPJLF;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x815B730", Offset = "0x815A330", VA = "0x18815B730")]
	public JFDFLAAMAPE(IEnumerable<Guid> AHNBPPOPJNA, Guid JOEKCJMJCNE, bool AHCCKLMJFPK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public struct PHCKIOGJKAK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public Guid HMAKMGKMPDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public readonly bool CFGBOJKPJLF;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x28730E0", Offset = "0x2871CE0", VA = "0x1828730E0")]
	public PHCKIOGJKAK(Guid JOEKCJMJCNE, bool AHCCKLMJFPK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface DLNPBFHNPBG<TGroup, TData>
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OOFOAJBEHPB EKDKFEGJBDF(HODEEFIHFDE<TGroup, TData> PBPHIEGHIEC);

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "1")]
	OOFOAJBEHPB MPALHEDMPOI(HODEEFIHFDE<TGroup, TData> PBPHIEGHIEC);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "2")]
	OOFOAJBEHPB HBPEBKMJNMB(BLEHGNEIDBP<TGroup, TData> PBPHIEGHIEC);

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "3")]
	OOFOAJBEHPB IIDNIEHAKCH(FGOEHNKCMHE<TGroup> PBPHIEGHIEC);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public interface HBFDEDLPDMN
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<OOFOAJBEHPB> EKDKFEGJBDF(JFDFLAAMAPE PBPHIEGHIEC);

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<OOFOAJBEHPB> MPALHEDMPOI(PHCKIOGJKAK PBPHIEGHIEC);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class OGJDJBBEPLN<TGroup, TData> : DEFHIDPGCFA<DLNPBFHNPBG<TGroup, TData>, OOFOAJBEHPB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly BLEHGNEIDBP<TGroup, TData> PBPHIEGHIEC;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x58611E0", Offset = "0x585FDE0", VA = "0x1858611E0")]
	public OGJDJBBEPLN(TGroup AJKJIPIDACN, IEnumerable<TData> AHNBPPOPJNA, DLNPBFHNPBG<TGroup, TData> NHJPJMHIKLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x5861110", Offset = "0x585FD10", VA = "0x185861110", Slot = "4")]
	public override OOFOAJBEHPB NDPIAIALAKO()
	{
		return default(OOFOAJBEHPB);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class KNOPFMFPEEB<TGroup, TData> : DEFHIDPGCFA<DLNPBFHNPBG<TGroup, TData>, OOFOAJBEHPB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly HODEEFIHFDE<TGroup, TData> PBPHIEGHIEC;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x53D28C0", Offset = "0x53D14C0", VA = "0x1853D28C0")]
	public KNOPFMFPEEB(TGroup AJKJIPIDACN, TData HHNIGEHKNJJ, IEnumerable<TData> AHNBPPOPJNA, DLNPBFHNPBG<TGroup, TData> NHJPJMHIKLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x53D27F0", Offset = "0x53D13F0", VA = "0x1853D27F0", Slot = "4")]
	public override OOFOAJBEHPB NDPIAIALAKO()
	{
		return default(OOFOAJBEHPB);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class PMIPBHDGMCO<TGroup, TData> : DEFHIDPGCFA<DLNPBFHNPBG<TGroup, TData>, OOFOAJBEHPB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly FGOEHNKCMHE<TGroup> PBPHIEGHIEC;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x53B1760", Offset = "0x53B0360", VA = "0x1853B1760")]
	public PMIPBHDGMCO(TGroup AJKJIPIDACN, DLNPBFHNPBG<TGroup, TData> NHJPJMHIKLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x5A14C70", Offset = "0x5A13870", VA = "0x185A14C70", Slot = "4")]
	public override OOFOAJBEHPB NDPIAIALAKO()
	{
		return default(OOFOAJBEHPB);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class CPAEGPLCACC<TGroup, TData> : DEFHIDPGCFA<DLNPBFHNPBG<TGroup, TData>, OOFOAJBEHPB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly HODEEFIHFDE<TGroup, TData> PBPHIEGHIEC;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x53D28C0", Offset = "0x53D14C0", VA = "0x1853D28C0")]
	public CPAEGPLCACC(TGroup AJKJIPIDACN, TData GDLKECJKNGA, IEnumerable<TData> AHNBPPOPJNA, DLNPBFHNPBG<TGroup, TData> NHJPJMHIKLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6C59280", Offset = "0x6C57E80", VA = "0x186C59280", Slot = "4")]
	public override OOFOAJBEHPB NDPIAIALAKO()
	{
		return default(OOFOAJBEHPB);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class OLOGGLALPCF : OPPNAJGLIPC<HBFDEDLPDMN, OOFOAJBEHPB>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private struct LHDAFMNCADL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public AsyncTaskMethodBuilder<OOFOAJBEHPB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public OLOGGLALPCF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private TaskAwaiter<OOFOAJBEHPB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x815B780", Offset = "0x815A380", VA = "0x18815B780", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x815BA10", Offset = "0x815A610", VA = "0x18815BA10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private JFDFLAAMAPE PBPHIEGHIEC;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x815BD70", Offset = "0x815A970", VA = "0x18815BD70")]
	public OLOGGLALPCF(IEnumerable<Guid> FNCGOLGEPNA, Guid JOEKCJMJCNE, bool AHCCKLMJFPK, HBFDEDLPDMN NHJPJMHIKLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x815BC80", Offset = "0x815A880", VA = "0x18815BC80", Slot = "4")]
	[AsyncStateMachine(typeof(LHDAFMNCADL))]
	public override Task<OOFOAJBEHPB> NDPIAIALAKO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class ONMPMPNFGHO : OPPNAJGLIPC<HBFDEDLPDMN, OOFOAJBEHPB>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private struct EHFKEEFNDHA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public AsyncTaskMethodBuilder<OOFOAJBEHPB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public ONMPMPNFGHO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private TaskAwaiter<OOFOAJBEHPB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x815B040", Offset = "0x8159C40", VA = "0x18815B040", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x815B2E0", Offset = "0x8159EE0", VA = "0x18815B2E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly PHCKIOGJKAK PBPHIEGHIEC;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x815BF20", Offset = "0x815AB20", VA = "0x18815BF20")]
	public ONMPMPNFGHO(Guid JOEKCJMJCNE, bool AHCCKLMJFPK, HBFDEDLPDMN NHJPJMHIKLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x815BE30", Offset = "0x815AA30", VA = "0x18815BE30", Slot = "4")]
	[AsyncStateMachine(typeof(EHFKEEFNDHA))]
	public override Task<OOFOAJBEHPB> NDPIAIALAKO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public readonly struct IDIPPBCPAPI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public readonly LONEGNJBLPE PBPBFNEMEEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly bool CFGBOJKPJLF;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x815B5C0", Offset = "0x815A1C0", VA = "0x18815B5C0")]
	public IDIPPBCPAPI(LONEGNJBLPE NGEKHIEILOM, bool AHCCKLMJFPK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface NAAIJDAEBKB<TSpawnType> where TSpawnType : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> NDPIAIALAKO(IDIPPBCPAPI PGBMEEHIMLN);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class EICAGJNMEDP<TSpawnType> : OPPNAJGLIPC<NAAIJDAEBKB<TSpawnType>, TSpawnType> where TSpawnType : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private struct CIFHMLCEKLF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public AsyncTaskMethodBuilder<TSpawnType> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public EICAGJNMEDP<TSpawnType> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private TaskAwaiter<TSpawnType> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x6B6DFF0", Offset = "0x6B6CBF0", VA = "0x186B6DFF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x4458DE0", Offset = "0x44579E0", VA = "0x184458DE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly IDIPPBCPAPI PGBMEEHIMLN;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x48D8800", Offset = "0x48D7400", VA = "0x1848D8800")]
	public EICAGJNMEDP(LONEGNJBLPE NGEKHIEILOM, bool AHCCKLMJFPK, NAAIJDAEBKB<TSpawnType> NHJPJMHIKLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x48D8620", Offset = "0x48D7220", VA = "0x1848D8620", Slot = "4")]
	[AsyncStateMachine(typeof(EICAGJNMEDP<>.CIFHMLCEKLF))]
	public override Task<TSpawnType> NDPIAIALAKO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public readonly struct LONEGNJBLPE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly bool EIBAPGDCOAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly Vector3 HOHLDGAJNOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly Vector3 BCBKGNPANPG;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x815BAB0", Offset = "0x815A6B0", VA = "0x18815BAB0")]
	public LONEGNJBLPE(Transform MMNPHIOEGKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x815BB20", Offset = "0x815A720", VA = "0x18815BB20")]
	public LONEGNJBLPE(Vector3 JMBLGBJKENI, Vector3 FEMJLOIOGIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x815BA80", Offset = "0x815A680", VA = "0x18815BA80")]
	public static LONEGNJBLPE JEKMEOOFFAJ()
	{
		return default(LONEGNJBLPE);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x815BB50", Offset = "0x815A750", VA = "0x18815BB50")]
	private LONEGNJBLPE(bool DPFCNPELFKD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public struct JMJBPBIMIBM<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public TNode KFONNNOOMNO;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x52EED70", Offset = "0x52ED970", VA = "0x1852EED70")]
	public JMJBPBIMIBM(TNode KFONNNOOMNO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public struct MOHJCGKKCLE<TNode, TReparentOperations> where TNode : notnull where TReparentOperations : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public TNode BNMBOFCCLHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public TReparentOperations OGEJFKNCLAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public FNAFCNALFKF IKPBMIJKALA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly bool CFGBOJKPJLF;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x56A9C20", Offset = "0x56A8820", VA = "0x1856A9C20")]
	public MOHJCGKKCLE(TNode BNMBOFCCLHM, TReparentOperations OGEJFKNCLAF, FNAFCNALFKF IKPBMIJKALA, bool AHCCKLMJFPK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface IPCDAOMPJPP<TNode, TReparentOperations>
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PKHJAAKBFLL([In] JMJBPBIMIBM<TNode> PPHNEFGNDLO);

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GMPEEAJMAHK([In] MOHJCGKKCLE<TNode, TReparentOperations> BIJAJMNAJAO);

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool LPOEPAHHCNG();
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class MBAHNHGNPJL<TNode, TReparentOperations> : OKCFIIOHFDM<IPCDAOMPJPP<TNode, TReparentOperations>>
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x445D2A0", Offset = "0x445BEA0", VA = "0x18445D2A0")]
	public MBAHNHGNPJL(IPCDAOMPJPP<TNode, TReparentOperations> NHJPJMHIKLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x50AAC00", Offset = "0x50A9800", VA = "0x1850AAC00", Slot = "4")]
	public override bool NDPIAIALAKO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public class KFKEPKJAFCE<TNode, TReparentOperations> : OKCFIIOHFDM<IPCDAOMPJPP<TNode, TReparentOperations>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly MOHJCGKKCLE<TNode, TReparentOperations> BIJAJMNAJAO;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x53B44A0", Offset = "0x53B30A0", VA = "0x1853B44A0")]
	public KFKEPKJAFCE(TNode BNMBOFCCLHM, TReparentOperations OGEJFKNCLAF, FNAFCNALFKF IKPBMIJKALA, IPCDAOMPJPP<TNode, TReparentOperations> NHJPJMHIKLA, bool AHCCKLMJFPK = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x4F66150", Offset = "0x4F64D50", VA = "0x184F66150", Slot = "4")]
	public override bool NDPIAIALAKO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public class AOEGGCPANLG<TNode, TReparentOperations> : OKCFIIOHFDM<IPCDAOMPJPP<TNode, TReparentOperations>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly JMJBPBIMIBM<TNode> PPHNEFGNDLO;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5250D30", Offset = "0x524F930", VA = "0x185250D30")]
	public AOEGGCPANLG(TNode DIGCAEJPGPL, IPCDAOMPJPP<TNode, TReparentOperations> NHJPJMHIKLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x4E8E8D0", Offset = "0x4E8D4D0", VA = "0x184E8E8D0", Slot = "4")]
	public override bool NDPIAIALAKO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct COEBEAFJMNC<TSpawnInfo> where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public TSpawnInfo HHICCFFEJNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public Vector3 FEMJLOIOGIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public Quaternion DINDLKHALMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public float ECJMFFOLCCL;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6C49F10", Offset = "0x6C48B10", VA = "0x186C49F10")]
	public COEBEAFJMNC(TSpawnInfo HHICCFFEJNF, Vector3 FEMJLOIOGIK, Quaternion DINDLKHALMD, float ECJMFFOLCCL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public interface PMEHDODJCNM<TSpawnType, TSpawnInfo>
{
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> MPNIFPIAEPH([In] COEBEAFJMNC<TSpawnInfo> JAKANJFEPCD, CancellationToken JHCOCAANJDL);
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class HPAGMHIDNIK<TSpawnType, TSpawnInfo> : OPPNAJGLIPC<PMEHDODJCNM<TSpawnType, TSpawnInfo>, TSpawnType> where TSpawnType : notnull where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private readonly COEBEAFJMNC<TSpawnInfo> AHEPAEIEJIO;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x4FAE690", Offset = "0x4FAD290", VA = "0x184FAE690")]
	public HPAGMHIDNIK(TSpawnInfo FLILAOPFHOM, Vector3 FEMJLOIOGIK, Quaternion DINDLKHALMD, float ECJMFFOLCCL, PMEHDODJCNM<TSpawnType, TSpawnInfo> NHJPJMHIKLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x4FAE4B0", Offset = "0x4FAD0B0", VA = "0x184FAE4B0", Slot = "4")]
	public override Task<TSpawnType> NDPIAIALAKO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public readonly struct IFOGAOFEHOB<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly IEnumerable<TData> FEJDCONKNIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public readonly bool CFGBOJKPJLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly bool DLPPLJJIBHN;

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x5074510", Offset = "0x5073110", VA = "0x185074510")]
	public IFOGAOFEHOB(IEnumerable<TData> AHNBPPOPJNA, bool AHCCKLMJFPK = false, bool IHANJGMKCAM = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface NAFACBKMAIG<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<OOFOAJBEHPB> MACDPIBHNOL([In] IFOGAOFEHOB<TData> EDMBABKJGMF, CancellationToken JHCOCAANJDL);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public class CDLGCEPOINO<TData> : OPPNAJGLIPC<NAFACBKMAIG<TData>, OOFOAJBEHPB> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private readonly IFOGAOFEHOB<TData> HOLLNIDLGIL;

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6A6F900", Offset = "0x6A6E500", VA = "0x186A6F900")]
	public CDLGCEPOINO(IEnumerable<TData> AHNBPPOPJNA, bool AHCCKLMJFPK, NAFACBKMAIG<TData> NHJPJMHIKLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x4FAE4B0", Offset = "0x4FAD0B0", VA = "0x184FAE4B0", Slot = "4")]
	public override Task<OOFOAJBEHPB> NDPIAIALAKO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public struct DBCMEMOPKPE<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly T ADGCHNLKFKK;

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x4450210", Offset = "0x444EE10", VA = "0x184450210")]
	public DBCMEMOPKPE(T HDIPJFHOHCA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface ICHEAHMJCOO<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PKHJAAKBFLL([In] DBCMEMOPKPE<T> JFFEPFHNIJK);

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GMPEEAJMAHK();
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface KELBFDNEHHH<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NDPIAIALAKO([In] LKPKBMEPDLC<T> GDMMKAOOIEL);
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public struct LKPKBMEPDLC<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public readonly T ADGCHNLKFKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly bool KNKFFKKIHMH;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x546A100", Offset = "0x5468D00", VA = "0x18546A100")]
	public LKPKBMEPDLC(T HDIPJFHOHCA, bool HHDLDNADJCJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class JHHAGDNKLGE<T> : OKCFIIOHFDM<ICHEAHMJCOO<T>> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x445D2A0", Offset = "0x445BEA0", VA = "0x18445D2A0")]
	public JHHAGDNKLGE(ICHEAHMJCOO<T> NHJPJMHIKLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x52E2340", Offset = "0x52E0F40", VA = "0x1852E2340", Slot = "4")]
	public override bool NDPIAIALAKO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public class KEMMKHLBGKO<T> : OKCFIIOHFDM<ICHEAHMJCOO<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly DBCMEMOPKPE<T> JFFEPFHNIJK;

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x53B16E0", Offset = "0x53B02E0", VA = "0x1853B16E0")]
	public KEMMKHLBGKO(T ADGCHNLKFKK, ICHEAHMJCOO<T> NHJPJMHIKLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x4E8E8D0", Offset = "0x4E8D4D0", VA = "0x184E8E8D0", Slot = "4")]
	public override bool NDPIAIALAKO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public class OFIHHFPFADO<T> : OKCFIIOHFDM<KELBFDNEHHH<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private readonly LKPKBMEPDLC<T> GDMMKAOOIEL;

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x585CBA0", Offset = "0x585B7A0", VA = "0x18585CBA0")]
	public OFIHHFPFADO(T ADGCHNLKFKK, bool HHDLDNADJCJ, KELBFDNEHHH<T> NHJPJMHIKLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x4E8E8D0", Offset = "0x4E8D4D0", VA = "0x184E8E8D0", Slot = "4")]
	public override bool NDPIAIALAKO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public struct BFPNOOGOGOG<TData> where TData : notnull, FCFPGGHOLGL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public IEnumerable<TData> FEJDCONKNIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public bool JPNACBICIBJ;

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x63407E0", Offset = "0x633F3E0", VA = "0x1863407E0")]
	public BFPNOOGOGOG(IEnumerable<TData> GIIOJCFGMPG, bool DIMNHBONIBG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public struct BENEEOEJFLA<TData> where TData : notnull, FCFPGGHOLGL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public List<TData> FEJDCONKNIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public List<bool> BMGDDPCOLOA;

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x633CEF0", Offset = "0x633BAF0", VA = "0x18633CEF0")]
	public BENEEOEJFLA(List<TData> GIIOJCFGMPG, List<bool> JBOEMIDFLEO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface FCFPGGHOLGL
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	bool BFHOONFJFIH
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
public interface LAFCLNHLGNO<TData> where TData : FCFPGGHOLGL
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NDPIAIALAKO([In] BFPNOOGOGOG<TData> NIJKFONFOLM);

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NDPIAIALAKO([In] BENEEOEJFLA<TData> NIJKFONFOLM);
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public interface KGOOLLPIAOG<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CPJPIJMLPHG(T ADGCHNLKFKK);
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public class PJGKGNNJIAH<TData> : OKCFIIOHFDM<LAFCLNHLGNO<TData>> where TData : notnull, FCFPGGHOLGL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly BFPNOOGOGOG<TData> NIJKFONFOLM;

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x59CFBE0", Offset = "0x59CE7E0", VA = "0x1859CFBE0")]
	public PJGKGNNJIAH(List<TData> AHNBPPOPJNA, bool JPNACBICIBJ, LAFCLNHLGNO<TData> NHJPJMHIKLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x4E8E8D0", Offset = "0x4E8D4D0", VA = "0x184E8E8D0", Slot = "4")]
	public override bool NDPIAIALAKO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public class DGCPECONAAD<TData> : OKCFIIOHFDM<LAFCLNHLGNO<TData>> where TData : notnull, FCFPGGHOLGL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly BENEEOEJFLA<TData> NIJKFONFOLM;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x4462930", Offset = "0x4461530", VA = "0x184462930")]
	public DGCPECONAAD(List<TData> AHNBPPOPJNA, List<bool> BMGDDPCOLOA, LAFCLNHLGNO<TData> NHJPJMHIKLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x4462870", Offset = "0x4461470", VA = "0x184462870", Slot = "4")]
	public override bool NDPIAIALAKO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public interface JMMNHNCMKBH<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<OOFOAJBEHPB> NDPIAIALAKO(PDBPAEPCEII<TData> AGHMFDPBMLO);
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public class JFKFJAAPHPM<TData> : OPPNAJGLIPC<JMMNHNCMKBH<TData>, OOFOAJBEHPB> where TData : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private struct GCDNNNMEKII : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public AsyncTaskMethodBuilder<OOFOAJBEHPB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public JFKFJAAPHPM<TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private TaskAwaiter<OOFOAJBEHPB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x4E48FD0", Offset = "0x4E47BD0", VA = "0x184E48FD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x4E492B0", Offset = "0x4E47EB0", VA = "0x184E492B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly PDBPAEPCEII<TData> BKBIOFEDNEF;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x52CA040", Offset = "0x52C8C40", VA = "0x1852CA040")]
	public JFKFJAAPHPM(TData DEGJCLAIADH, IReadOnlyList<TData> DHGMCEAKFIG, bool AHCCKLMJFPK, JMMNHNCMKBH<TData> NHJPJMHIKLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x52C9F40", Offset = "0x52C8B40", VA = "0x1852C9F40", Slot = "4")]
	[AsyncStateMachine(typeof(JFKFJAAPHPM<>.GCDNNNMEKII))]
	public override Task<OOFOAJBEHPB> NDPIAIALAKO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public struct PDBPAEPCEII<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public TData PJJGHMJLBLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public IReadOnlyList<TData> AADLHKAAGPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public bool CFGBOJKPJLF;

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x2FA77C0", Offset = "0x2FA63C0", VA = "0x182FA77C0")]
	public PDBPAEPCEII(TData DEGJCLAIADH, IReadOnlyList<TData> DHGMCEAKFIG, bool AHCCKLMJFPK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public interface LMCJNMPMNLC<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NDPIAIALAKO([In] EKMPODKPOGJ<TData> IDLBGAGIKID);
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public interface JLKBIEDJHIK<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NDPIAIALAKO([In] IADEMPOONPE<TData> IDLBGAGIKID);
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public interface KDDPHPNMBAG<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CFCGLAAOKIE([In] NHMEAGIODFL<TData> IDLBGAGIKID);

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GMPEEAJMAHK();
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class CBDJAJGBNCH<TData> : OKCFIIOHFDM<LMCJNMPMNLC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly EKMPODKPOGJ<TData> IDLBGAGIKID;

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6A69170", Offset = "0x6A67D70", VA = "0x186A69170")]
	public CBDJAJGBNCH(IEnumerable<TData> AHNBPPOPJNA, HEEBNBDCPDH MGBNCENPLKH, BNIMJFMEDEA CIBNABIMGCK, float CAOAAOPJCFM, string? HIGFGBDCIBL, bool NFHLHAMHPII, bool AHCCKLMJFPK, LMCJNMPMNLC<TData> NHJPJMHIKLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x4E8E8D0", Offset = "0x4E8D4D0", VA = "0x184E8E8D0", Slot = "4")]
	public override bool NDPIAIALAKO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class GEOMMJJBAOI<TData> : OKCFIIOHFDM<JLKBIEDJHIK<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly IADEMPOONPE<TData> IDLBGAGIKID;

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x4E8C810", Offset = "0x4E8B410", VA = "0x184E8C810")]
	public GEOMMJJBAOI(TData[] AHNBPPOPJNA, HEEBNBDCPDH[] MGBNCENPLKH, BNIMJFMEDEA[] CIBNABIMGCK, float[] CAOAAOPJCFM, JLKBIEDJHIK<TData> NHJPJMHIKLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x4E8C750", Offset = "0x4E8B350", VA = "0x184E8C750", Slot = "4")]
	public override bool NDPIAIALAKO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class LFNOHNJKAFD<TData> : OKCFIIOHFDM<KDDPHPNMBAG<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x445D2A0", Offset = "0x445BEA0", VA = "0x18445D2A0")]
	public LFNOHNJKAFD(KDDPHPNMBAG<TData> NHJPJMHIKLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x545ED10", Offset = "0x545D910", VA = "0x18545ED10", Slot = "4")]
	public override bool NDPIAIALAKO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public class AHEMLNCIIOD<TData> : OKCFIIOHFDM<KDDPHPNMBAG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly NHMEAGIODFL<TData> IDLBGAGIKID;

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x5096950", Offset = "0x5095550", VA = "0x185096950")]
	public AHEMLNCIIOD(IEnumerable<TData> AHNBPPOPJNA, HEEBNBDCPDH MGBNCENPLKH, BNIMJFMEDEA CIBNABIMGCK, float CAOAAOPJCFM, KDDPHPNMBAG<TData> NHJPJMHIKLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x4E8C750", Offset = "0x4E8B350", VA = "0x184E8C750", Slot = "4")]
	public override bool NDPIAIALAKO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public struct EKMPODKPOGJ<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public IEnumerable<TData> FEJDCONKNIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public HEEBNBDCPDH MEHMDJKIAJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public BNIMJFMEDEA HLAFGCCNOEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public float LOIJJKBLKAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public string? JANGKCMCKOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public bool? HOODMNNNHBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public bool CFGBOJKPJLF;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x48E39C0", Offset = "0x48E25C0", VA = "0x1848E39C0")]
	public EKMPODKPOGJ(IEnumerable<TData> AHNBPPOPJNA, HEEBNBDCPDH MGBNCENPLKH, BNIMJFMEDEA CIBNABIMGCK, float CAOAAOPJCFM, string? HIGFGBDCIBL, bool? NFHLHAMHPII, bool AHCCKLMJFPK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public struct IADEMPOONPE<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public TData[] FEJDCONKNIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public HEEBNBDCPDH[] MEHMDJKIAJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public BNIMJFMEDEA[] HLAFGCCNOEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public float[] CAOAAOPJCFM;

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x504FD70", Offset = "0x504E970", VA = "0x18504FD70")]
	public IADEMPOONPE(TData[] AHNBPPOPJNA, HEEBNBDCPDH[] MGBNCENPLKH, BNIMJFMEDEA[] CIBNABIMGCK, float[] CAOAAOPJCFM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public struct NHMEAGIODFL<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public IEnumerable<TData> FEJDCONKNIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public HEEBNBDCPDH MEHMDJKIAJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public BNIMJFMEDEA HLAFGCCNOEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public float CAOAAOPJCFM;

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x570CB10", Offset = "0x570B710", VA = "0x18570CB10")]
	public NHMEAGIODFL(IEnumerable<TData> AHNBPPOPJNA, HEEBNBDCPDH MGBNCENPLKH, BNIMJFMEDEA CIBNABIMGCK, float CAOAAOPJCFM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public interface DLLJAGKOAFN<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HBPEBKMJNMB([In] CGAJENOFIJH<TData> EDMBABKJGMF);

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IIDNIEHAKCH([In] CGAJENOFIJH<TData> EDMBABKJGMF);

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GOOIABOJKFJ([In] bool GKIMDAKOOBI);

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool JEAJEPEFGKE([In] CGAJENOFIJH<TData> EDMBABKJGMF);

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ODGDCIMHIOJ();

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool MGIHAJHGAMG([In] TData ONHKOEPALCP);
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public class LNIEDHIDJAK<TData> : OKCFIIOHFDM<DLLJAGKOAFN<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly CGAJENOFIJH<TData> EDMBABKJGMF;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x546E240", Offset = "0x546CE40", VA = "0x18546E240")]
	public LNIEDHIDJAK(List<TData> LNODOELCPNI, DLLJAGKOAFN<TData> NHJPJMHIKLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x4E8E8D0", Offset = "0x4E8D4D0", VA = "0x184E8E8D0", Slot = "4")]
	public override bool NDPIAIALAKO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class LOLDOELEDHL<TData> : OKCFIIOHFDM<DLLJAGKOAFN<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x445D2A0", Offset = "0x445BEA0", VA = "0x18445D2A0")]
	public LOLDOELEDHL(DLLJAGKOAFN<TData> NHJPJMHIKLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x546F6D0", Offset = "0x546E2D0", VA = "0x18546F6D0", Slot = "4")]
	public override bool NDPIAIALAKO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public class FBMNCNLKKDC<TData> : OKCFIIOHFDM<DLLJAGKOAFN<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly bool AHCCKLMJFPK;

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x4D57750", Offset = "0x4D56350", VA = "0x184D57750")]
	public FBMNCNLKKDC(bool AHCCKLMJFPK, DLLJAGKOAFN<TData> NHJPJMHIKLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x4D576F0", Offset = "0x4D562F0", VA = "0x184D576F0", Slot = "4")]
	public override bool NDPIAIALAKO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class DPHKHNJGHEA<TData> : OKCFIIOHFDM<DLLJAGKOAFN<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly CGAJENOFIJH<TData> EDMBABKJGMF;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x447F900", Offset = "0x447E500", VA = "0x18447F900")]
	public DPHKHNJGHEA(List<TData> LNODOELCPNI, bool AHCCKLMJFPK, DLLJAGKOAFN<TData> NHJPJMHIKLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x4462870", Offset = "0x4461470", VA = "0x184462870", Slot = "4")]
	public override bool NDPIAIALAKO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class OKGGCKJNGOM<TData> : OKCFIIOHFDM<DLLJAGKOAFN<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly TData ONHKOEPALCP;

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x5881010", Offset = "0x587FC10", VA = "0x185881010")]
	public OKGGCKJNGOM(TData ONHKOEPALCP, DLLJAGKOAFN<TData> NHJPJMHIKLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x5880EA0", Offset = "0x587FAA0", VA = "0x185880EA0", Slot = "4")]
	public override bool NDPIAIALAKO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class HKDJMNDFIHN<TData> : OKCFIIOHFDM<DLLJAGKOAFN<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private readonly CGAJENOFIJH<TData> EDMBABKJGMF;

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x4F9E700", Offset = "0x4F9D300", VA = "0x184F9E700")]
	public HKDJMNDFIHN(IEnumerable<TData> LNODOELCPNI, DLLJAGKOAFN<TData> NHJPJMHIKLA, bool AHCCKLMJFPK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x4F9E5A0", Offset = "0x4F9D1A0", VA = "0x184F9E5A0", Slot = "4")]
	public override bool NDPIAIALAKO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public struct CGAJENOFIJH<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public IEnumerable<TData> FEJDCONKNIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public bool AHCCKLMJFPK;

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x6B69BD0", Offset = "0x6B687D0", VA = "0x186B69BD0")]
	public CGAJENOFIJH(IEnumerable<TData> GIIOJCFGMPG, bool KHLFIANAJNE = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public interface POPIDFFGHKB
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<OOFOAJBEHPB> NDPIAIALAKO(KIFHKHDGLPO IOLKJNFBDFF);
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class IGKNLMFEEOA : OPPNAJGLIPC<POPIDFFGHKB, OOFOAJBEHPB>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[CompilerGenerated]
	private struct CLOMPGBIGBM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public AsyncTaskMethodBuilder<OOFOAJBEHPB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public IGKNLMFEEOA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private TaskAwaiter<OOFOAJBEHPB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x815A420", Offset = "0x8159020", VA = "0x18815A420", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x815A6A0", Offset = "0x81592A0", VA = "0x18815A6A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly KIFHKHDGLPO IDHHBIAHMKH;

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x815B6D0", Offset = "0x815A2D0", VA = "0x18815B6D0")]
	public IGKNLMFEEOA(bool AHCCKLMJFPK, POPIDFFGHKB NHJPJMHIKLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x815B5E0", Offset = "0x815A1E0", VA = "0x18815B5E0", Slot = "4")]
	[AsyncStateMachine(typeof(CLOMPGBIGBM))]
	public override Task<OOFOAJBEHPB> NDPIAIALAKO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public struct KIFHKHDGLPO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public bool CFGBOJKPJLF;

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x2C574C0", Offset = "0x2C560C0", VA = "0x182C574C0")]
	public KIFHKHDGLPO(bool AHCCKLMJFPK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public readonly struct KAAKOEHALDP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public readonly bool DIDCIEBHICD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public readonly bool DILCKLANGMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public readonly bool ECJMFFOLCCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public readonly bool AHCCKLMJFPK;

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x6080E70", Offset = "0x607FA70", VA = "0x186080E70")]
	public KAAKOEHALDP(bool DIDCIEBHICD, bool DILCKLANGMF, bool ECJMFFOLCCL, bool AHCCKLMJFPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x815B770", Offset = "0x815A370", VA = "0x18815B770")]
	public KAAKOEHALDP(bool DILCKLANGMF, bool AHCCKLMJFPK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public interface BAGIBJPMPMB
{
	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LKKGDLBCDJF(KAAKOEHALDP BLOIHKOPHFK);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HHOHIHOEBEA(KAAKOEHALDP BLOIHKOPHFK);
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public class FCDEPAJKBED : OKCFIIOHFDM<BAGIBJPMPMB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly KAAKOEHALDP BLOIHKOPHFK;

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x815B3A0", Offset = "0x8159FA0", VA = "0x18815B3A0")]
	public FCDEPAJKBED(bool LMGPODOPMIJ, bool DILCKLANGMF, bool ECJMFFOLCCL, bool AHCCKLMJFPK, BAGIBJPMPMB NHJPJMHIKLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x815B350", Offset = "0x8159F50", VA = "0x18815B350", Slot = "4")]
	public override bool NDPIAIALAKO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public class DONGAAFKEAB : OKCFIIOHFDM<BAGIBJPMPMB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly KAAKOEHALDP BLOIHKOPHFK;

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x815AFC0", Offset = "0x8159BC0", VA = "0x18815AFC0")]
	public DONGAAFKEAB(bool DILCKLANGMF, bool AHCCKLMJFPK, BAGIBJPMPMB NHJPJMHIKLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x815AF70", Offset = "0x8159B70", VA = "0x18815AF70", Slot = "4")]
	public override bool NDPIAIALAKO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public interface EOGGDKLMBEA
{
	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NDPIAIALAKO([In] DHPKPLCDJLE FLDDNFOEHDI);
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class PNMAJGNIPPN : OKCFIIOHFDM<EOGGDKLMBEA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly DHPKPLCDJLE FLDDNFOEHDI;

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x815C050", Offset = "0x815AC50", VA = "0x18815C050")]
	public PNMAJGNIPPN(Guid[] OEENDNDNDPI, Vector3[] HEBAICDCFDN, Quaternion[] AJLLNIDOKJD, float[] JMACHMGCMLJ, Dictionary<Guid, Vector3> BHOEHKHMFEP, EOGGDKLMBEA NHJPJMHIKLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x815BFA0", Offset = "0x815ABA0", VA = "0x18815BFA0", Slot = "4")]
	public override bool NDPIAIALAKO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public interface KDHALMOCHGO<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PKHJAAKBFLL([In] MBAOBLIGMBN<TData> PPHNEFGNDLO);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CFCGLAAOKIE([In] CMJHKGCEOBC EADBBACOBKH);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool CFCGLAAOKIE([In] IAFFOIDDAMO EADBBACOBKH);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool GMPEEAJMAHK();
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class JOKBDLNDOCC<TData> : OKCFIIOHFDM<KDHALMOCHGO<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x445D2A0", Offset = "0x445BEA0", VA = "0x18445D2A0")]
	public JOKBDLNDOCC(KDHALMOCHGO<TData> NHJPJMHIKLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x52F1720", Offset = "0x52F0320", VA = "0x1852F1720", Slot = "4")]
	public override bool NDPIAIALAKO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public class LLFOAHAOJGA<TData> : OKCFIIOHFDM<KDHALMOCHGO<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly CMJHKGCEOBC NJCPJOMEPFH;

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x546A230", Offset = "0x5468E30", VA = "0x18546A230")]
	public LLFOAHAOJGA(Vector3 PNAFKHADEEO, bool OHMMBPCPCDB, KDHALMOCHGO<TData> NHJPJMHIKLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x4465230", Offset = "0x4463E30", VA = "0x184465230", Slot = "4")]
	public override bool NDPIAIALAKO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public class MBGDNGDKAIP<TData> : OKCFIIOHFDM<KDHALMOCHGO<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly IAFFOIDDAMO NJCPJOMEPFH;

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x564BED0", Offset = "0x564AAD0", VA = "0x18564BED0")]
	public MBGDNGDKAIP(Guid NFAODKGGHED, int LCCBBMBENOH, Vector3 FEMJLOIOGIK, Quaternion DINDLKHALMD, float BNDEJLLMNLK, bool OHMMBPCPCDB, KDHALMOCHGO<TData> NHJPJMHIKLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x564BE70", Offset = "0x564AA70", VA = "0x18564BE70", Slot = "4")]
	public override bool NDPIAIALAKO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public class IOLILFNIPFO<TData> : OKCFIIOHFDM<KDHALMOCHGO<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly MBAOBLIGMBN<TData> NJCPJOMEPFH;

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x50B3D60", Offset = "0x50B2960", VA = "0x1850B3D60")]
	public IOLILFNIPFO(TData ADGCHNLKFKK, bool AHCCKLMJFPK, KDHALMOCHGO<TData> NHJPJMHIKLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x4E8E8D0", Offset = "0x4E8D4D0", VA = "0x184E8E8D0", Slot = "4")]
	public override bool NDPIAIALAKO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public struct CMJHKGCEOBC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public readonly Vector3 PNAFKHADEEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public readonly bool OHMMBPCPCDB;

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x815A710", Offset = "0x8159310", VA = "0x18815A710")]
	public CMJHKGCEOBC(Vector3 PNAFKHADEEO, bool OHMMBPCPCDB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public struct IAFFOIDDAMO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public readonly Guid NFAODKGGHED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public readonly int LCCBBMBENOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public readonly Vector3 FEMJLOIOGIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public readonly Quaternion DINDLKHALMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public readonly float BNDEJLLMNLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public readonly bool OHMMBPCPCDB;

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x815B580", Offset = "0x815A180", VA = "0x18815B580")]
	public IAFFOIDDAMO(Guid NFAODKGGHED, int LCCBBMBENOH, Vector3 FEMJLOIOGIK, Quaternion DINDLKHALMD, float BNDEJLLMNLK, bool OHMMBPCPCDB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public struct MBAOBLIGMBN<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public readonly TData ADGCHNLKFKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public readonly bool AHCCKLMJFPK;

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x564AAB0", Offset = "0x56496B0", VA = "0x18564AAB0")]
	public MBAOBLIGMBN(TData ADGCHNLKFKK, bool AHCCKLMJFPK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public interface GNMIGHBPBHG<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NDPIAIALAKO([In] GENFKACOINK<TData> OONACCKANBC);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NDPIAIALAKO([In] LNOEEAFKKIM<TData> OONACCKANBC);
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public interface NHEAPEHNELJ<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PKHJAAKBFLL([In] LPLDPPPOEBP<TData> LCFCCHCEEMF);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CFCGLAAOKIE([In] HAMHAAGHPGD EADBBACOBKH);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool GMPEEAJMAHK();
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public class OEPMKIHDOIM<TData> : OKCFIIOHFDM<GNMIGHBPBHG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly GENFKACOINK<TData> OONACCKANBC;

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x585BEC0", Offset = "0x585AAC0", VA = "0x18585BEC0")]
	public OEPMKIHDOIM(IEnumerable<TData> AHNBPPOPJNA, Vector3 AKBEFLOKAGB, bool AHCCKLMJFPK, GNMIGHBPBHG<TData> NHJPJMHIKLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x4E8E8D0", Offset = "0x4E8D4D0", VA = "0x184E8E8D0", Slot = "4")]
	public override bool NDPIAIALAKO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public class ILGCAMPPDCP<TData> : OKCFIIOHFDM<NHEAPEHNELJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x445D2A0", Offset = "0x445BEA0", VA = "0x18445D2A0")]
	public ILGCAMPPDCP(NHEAPEHNELJ<TData> NHJPJMHIKLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x50AAC00", Offset = "0x50A9800", VA = "0x1850AAC00", Slot = "4")]
	public override bool NDPIAIALAKO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public class NNCGEPHNALG<TData> : OKCFIIOHFDM<NHEAPEHNELJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly LPLDPPPOEBP<TData> OONACCKANBC;

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x5725460", Offset = "0x5724060", VA = "0x185725460")]
	public NNCGEPHNALG(IEnumerable<TData> AHNBPPOPJNA, bool AHCCKLMJFPK, NHEAPEHNELJ<TData> NHJPJMHIKLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x4E8E8D0", Offset = "0x4E8D4D0", VA = "0x184E8E8D0", Slot = "4")]
	public override bool NDPIAIALAKO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public class HCHAHDBIPKB<TData> : OKCFIIOHFDM<GNMIGHBPBHG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly LNOEEAFKKIM<TData> OONACCKANBC;

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x4F66210", Offset = "0x4F64E10", VA = "0x184F66210")]
	public HCHAHDBIPKB(IEnumerable<TData> AHNBPPOPJNA, Vector3 DKCMGEPGIDK, PPLIFENOOLD IPDEABLMMIP, bool AHCCKLMJFPK, GNMIGHBPBHG<TData> NHJPJMHIKLA, Space AOFIEOCHFMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x4F66150", Offset = "0x4F64D50", VA = "0x184F66150", Slot = "4")]
	public override bool NDPIAIALAKO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public class DGPKPLOKKMO<TData> : OKCFIIOHFDM<NHEAPEHNELJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly HAMHAAGHPGD OONACCKANBC;

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x4465290", Offset = "0x4463E90", VA = "0x184465290")]
	public DGPKPLOKKMO(Vector3 AKBEFLOKAGB, NHEAPEHNELJ<TData> NHJPJMHIKLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x4465230", Offset = "0x4463E30", VA = "0x184465230", Slot = "4")]
	public override bool NDPIAIALAKO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public struct GENFKACOINK<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public readonly IEnumerable<TData> AHNBPPOPJNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public readonly Vector3 AKBEFLOKAGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public readonly bool AHCCKLMJFPK;

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x4E8A300", Offset = "0x4E88F00", VA = "0x184E8A300")]
	public GENFKACOINK(IEnumerable<TData> AHNBPPOPJNA, Vector3 AKBEFLOKAGB, bool AHCCKLMJFPK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public struct LPLDPPPOEBP<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public readonly IEnumerable<TData> AHNBPPOPJNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public readonly bool AHCCKLMJFPK;

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x5478DB0", Offset = "0x54779B0", VA = "0x185478DB0")]
	public LPLDPPPOEBP(IEnumerable<TData> AHNBPPOPJNA, bool AHCCKLMJFPK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public struct LNOEEAFKKIM<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	public readonly IEnumerable<TData> AHNBPPOPJNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	public readonly Vector3 DKCMGEPGIDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public readonly PPLIFENOOLD IPDEABLMMIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public readonly bool AHCCKLMJFPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public readonly Space AOFIEOCHFMF;

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x546E4E0", Offset = "0x546D0E0", VA = "0x18546E4E0")]
	public LNOEEAFKKIM(IEnumerable<TData> AHNBPPOPJNA, Vector3 DKCMGEPGIDK, PPLIFENOOLD IPDEABLMMIP, bool AHCCKLMJFPK, Space AOFIEOCHFMF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public struct HAMHAAGHPGD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public readonly Vector3 AKBEFLOKAGB;

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x2C53B50", Offset = "0x2C52750", VA = "0x182C53B50")]
	public HAMHAAGHPGD(Vector3 AKBEFLOKAGB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public enum PPLIFENOOLD
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
public interface LOPEKINAAEG
{
	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NDPIAIALAKO([In] DGJCMAAFBEF IGHGAIHAHHG);
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public class GFBEHOMJFJB : OKCFIIOHFDM<LOPEKINAAEG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private readonly DGJCMAAFBEF IGHGAIHAHHG;

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x815B4E0", Offset = "0x815A0E0", VA = "0x18815B4E0")]
	public GFBEHOMJFJB(bool AHCCKLMJFPK, LOPEKINAAEG NHJPJMHIKLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x815B430", Offset = "0x815A030", VA = "0x18815B430", Slot = "4")]
	public override bool NDPIAIALAKO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public readonly struct DGJCMAAFBEF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public readonly bool AHCCKLMJFPK;

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x2C574C0", Offset = "0x2C560C0", VA = "0x182C574C0")]
	public DGJCMAAFBEF(bool AHCCKLMJFPK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public interface MADAJDCBDHO<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NDPIAIALAKO([In] HOMHHIOJOFH<TData> ANHEJCBOKBI);

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NDPIAIALAKO([In] MFEMANJAPAO<TData> ANHEJCBOKBI);
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public interface KHPPBFABIPF<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PKHJAAKBFLL([In] HJEIHDKGEGC<TData> PPHNEFGNDLO);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CFCGLAAOKIE([In] NHACPGNCEJO EADBBACOBKH);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool GMPEEAJMAHK();
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public class ALIMCHDCOKO<TData> : OKCFIIOHFDM<MADAJDCBDHO<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private readonly HOMHHIOJOFH<TData> ANHEJCBOKBI;

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x5186040", Offset = "0x5184C40", VA = "0x185186040")]
	public ALIMCHDCOKO(IEnumerable<TData> AHNBPPOPJNA, Quaternion AKBEFLOKAGB, Vector3? HPFOCEPOPCG, bool CCKAMJLFJBM, bool AHCCKLMJFPK, MADAJDCBDHO<TData> NHJPJMHIKLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x4E8E8D0", Offset = "0x4E8D4D0", VA = "0x184E8E8D0", Slot = "4")]
	public override bool NDPIAIALAKO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public class OEAJCGADODO<TData> : OKCFIIOHFDM<KHPPBFABIPF<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x445D2A0", Offset = "0x445BEA0", VA = "0x18445D2A0")]
	public OEAJCGADODO(KHPPBFABIPF<TData> NHJPJMHIKLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x50AAC00", Offset = "0x50A9800", VA = "0x1850AAC00", Slot = "4")]
	public override bool NDPIAIALAKO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public class HMDEFMDDHCN<TData> : OKCFIIOHFDM<KHPPBFABIPF<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly HJEIHDKGEGC<TData> ANHEJCBOKBI;

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x4FA42E0", Offset = "0x4FA2EE0", VA = "0x184FA42E0")]
	public HMDEFMDDHCN(IEnumerable<TData> AHNBPPOPJNA, bool AHCCKLMJFPK, KHPPBFABIPF<TData> NHJPJMHIKLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x4E8E8D0", Offset = "0x4E8D4D0", VA = "0x184E8E8D0", Slot = "4")]
	public override bool NDPIAIALAKO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public class MDCCPIKBOKL<TData> : OKCFIIOHFDM<MADAJDCBDHO<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private readonly MFEMANJAPAO<TData> ANHEJCBOKBI;

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x5663C70", Offset = "0x5662870", VA = "0x185663C70")]
	public MDCCPIKBOKL(IEnumerable<TData> AHNBPPOPJNA, Quaternion MKDCJPGKILG, PPLIFENOOLD LHMHOKAEIHM, Vector3? HPFOCEPOPCG, bool CCKAMJLFJBM, bool AHCCKLMJFPK, Space AOFIEOCHFMF, MADAJDCBDHO<TData> NHJPJMHIKLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x4F66150", Offset = "0x4F64D50", VA = "0x184F66150", Slot = "4")]
	public override bool NDPIAIALAKO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public class GPLNCMNFFGL<TData> : OKCFIIOHFDM<KHPPBFABIPF<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private readonly NHACPGNCEJO ANHEJCBOKBI;

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x4F29ED0", Offset = "0x4F28AD0", VA = "0x184F29ED0")]
	public GPLNCMNFFGL(Quaternion AKBEFLOKAGB, Vector3? HPFOCEPOPCG, bool CCKAMJLFJBM, KHPPBFABIPF<TData> NHJPJMHIKLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x4465230", Offset = "0x4463E30", VA = "0x184465230", Slot = "4")]
	public override bool NDPIAIALAKO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public struct HOMHHIOJOFH<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public readonly IEnumerable<TData> AHNBPPOPJNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public readonly Quaternion AKBEFLOKAGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public readonly Vector3? HPFOCEPOPCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public readonly bool CCKAMJLFJBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public readonly bool AHCCKLMJFPK;

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x4FAE390", Offset = "0x4FACF90", VA = "0x184FAE390")]
	public HOMHHIOJOFH(IEnumerable<TData> AHNBPPOPJNA, Quaternion AKBEFLOKAGB, Vector3? HPFOCEPOPCG, bool CCKAMJLFJBM, bool AHCCKLMJFPK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public struct HJEIHDKGEGC<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public readonly IEnumerable<TData> AHNBPPOPJNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public readonly bool AHCCKLMJFPK;

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x4F9D670", Offset = "0x4F9C270", VA = "0x184F9D670")]
	public HJEIHDKGEGC(IEnumerable<TData> AHNBPPOPJNA, bool AHCCKLMJFPK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public struct MFEMANJAPAO<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public readonly IEnumerable<TData> AHNBPPOPJNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public readonly Quaternion MKDCJPGKILG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public readonly PPLIFENOOLD LHMHOKAEIHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public readonly Vector3? HPFOCEPOPCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public readonly bool CCKAMJLFJBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public readonly bool AHCCKLMJFPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public readonly Space AOFIEOCHFMF;

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x5670110", Offset = "0x566ED10", VA = "0x185670110")]
	public MFEMANJAPAO(IEnumerable<TData> AHNBPPOPJNA, Quaternion MKDCJPGKILG, PPLIFENOOLD LHMHOKAEIHM, Vector3? HPFOCEPOPCG, bool CCKAMJLFJBM, bool AHCCKLMJFPK, Space AOFIEOCHFMF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public struct NHACPGNCEJO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public readonly Quaternion AKBEFLOKAGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public readonly Vector3? HPFOCEPOPCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public readonly bool CCKAMJLFJBM;

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x6028C00", Offset = "0x6027800", VA = "0x186028C00")]
	public NHACPGNCEJO(Quaternion AKBEFLOKAGB, Vector3? HPFOCEPOPCG, bool CCKAMJLFJBM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public interface COCCGLNBMKM<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PKHJAAKBFLL([In] AFJCCDFGFMO<TData> PPHNEFGNDLO);

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CFCGLAAOKIE([In] JHMDCOKBMOF EADBBACOBKH);

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool CFCGLAAOKIE([In] MMPBEHDBJDM EADBBACOBKH);

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool CFCGLAAOKIE([In] GONNBDJAIEI EADBBACOBKH);

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool GMPEEAJMAHK();
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public class MLCOFEODEDA<TData> : OKCFIIOHFDM<COCCGLNBMKM<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private readonly GONNBDJAIEI IMCHLGEFOCB;

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x569AD80", Offset = "0x5699980", VA = "0x18569AD80")]
	public MLCOFEODEDA(Vector3 GAFAMDJNGGF, float MPBOAKIOADM, Vector3 HPFOCEPOPCG, bool BEIDHPHCHOB, bool LKAJIBMLPHN, COCCGLNBMKM<TData> NHJPJMHIKLA, Space AOFIEOCHFMF = Space.Self)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x569AD20", Offset = "0x5699920", VA = "0x18569AD20", Slot = "4")]
	public override bool NDPIAIALAKO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public class JHDKEOMGJAA<TData> : OKCFIIOHFDM<COCCGLNBMKM<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x445D2A0", Offset = "0x445BEA0", VA = "0x18445D2A0")]
	public JHDKEOMGJAA(COCCGLNBMKM<TData> NHJPJMHIKLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x52E1D00", Offset = "0x52E0900", VA = "0x1852E1D00", Slot = "4")]
	public override bool NDPIAIALAKO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
public class LEPKKBGOHJK<TData> : OKCFIIOHFDM<COCCGLNBMKM<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private readonly AFJCCDFGFMO<TData> IMCHLGEFOCB;

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x545E9E0", Offset = "0x545D5E0", VA = "0x18545E9E0")]
	public LEPKKBGOHJK(IEnumerable<TData> AHNBPPOPJNA, bool AHCCKLMJFPK, COCCGLNBMKM<TData> NHJPJMHIKLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x4E8E8D0", Offset = "0x4E8D4D0", VA = "0x184E8E8D0", Slot = "4")]
	public override bool NDPIAIALAKO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
public class MFBDCNLOOGA<TData> : OKCFIIOHFDM<COCCGLNBMKM<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private readonly MMPBEHDBJDM IMCHLGEFOCB;

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x566DD70", Offset = "0x566C970", VA = "0x18566DD70")]
	public MFBDCNLOOGA(float NKNIOOBABID, bool OEIELPKEEHH, Vector3 HPFOCEPOPCG, COCCGLNBMKM<TData> NHJPJMHIKLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x566DCB0", Offset = "0x566C8B0", VA = "0x18566DCB0", Slot = "4")]
	public override bool NDPIAIALAKO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
public class GEJCDCKOLFJ<TData> : OKCFIIOHFDM<COCCGLNBMKM<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private readonly JHMDCOKBMOF IMCHLGEFOCB;

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x4E89FC0", Offset = "0x4E88BC0", VA = "0x184E89FC0")]
	public GEJCDCKOLFJ(float MPBOAKIOADM, Vector3 HPFOCEPOPCG, COCCGLNBMKM<TData> NHJPJMHIKLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x4465230", Offset = "0x4463E30", VA = "0x184465230", Slot = "4")]
	public override bool NDPIAIALAKO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
public struct GONNBDJAIEI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public readonly Vector3 GAFAMDJNGGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public readonly float MPBOAKIOADM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public readonly Vector3 HPFOCEPOPCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	public readonly bool OHMMBPCPCDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	public readonly Space AOFIEOCHFMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	public readonly bool LKAJIBMLPHN;

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x815B540", Offset = "0x815A140", VA = "0x18815B540")]
	public GONNBDJAIEI(Vector3 GAFAMDJNGGF, float MPBOAKIOADM, Vector3 HPFOCEPOPCG, bool OHMMBPCPCDB, bool NJCICLGHGLO, Space AOFIEOCHFMF = Space.Self)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public struct AFJCCDFGFMO<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public readonly IEnumerable<TData> AHNBPPOPJNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public readonly bool AHCCKLMJFPK;

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x5092500", Offset = "0x5091100", VA = "0x185092500")]
	public AFJCCDFGFMO(IEnumerable<TData> AHNBPPOPJNA, bool AHCCKLMJFPK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
public struct MMPBEHDBJDM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public readonly float NKNIOOBABID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public readonly bool OEIELPKEEHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public readonly Vector3 HPFOCEPOPCG;

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x815BBE0", Offset = "0x815A7E0", VA = "0x18815BBE0")]
	public MMPBEHDBJDM(float NKNIOOBABID, bool OEIELPKEEHH, Vector3 HPFOCEPOPCG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public struct JHMDCOKBMOF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public readonly float MPBOAKIOADM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public readonly Vector3 HPFOCEPOPCG;

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x5FEC960", Offset = "0x5FEB560", VA = "0x185FEC960")]
	public JHMDCOKBMOF(float MPBOAKIOADM, Vector3 HPFOCEPOPCG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public struct DHPKPLCDJLE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public readonly Guid[] AHNBPPOPJNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public readonly bool DKLLELDOHAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public readonly bool NFPDMJFPACB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public readonly bool IHJNDDDMJAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public readonly Vector3[] HEBAICDCFDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public readonly Quaternion[] AJLLNIDOKJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public readonly float[] JMACHMGCMLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public readonly Dictionary<Guid, Vector3> BHOEHKHMFEP;

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x815A900", Offset = "0x8159500", VA = "0x18815A900")]
	public DHPKPLCDJLE(Guid[] OEENDNDNDPI, Vector3[] HEBAICDCFDN, Quaternion[] AJLLNIDOKJD, float[] JMACHMGCMLJ, Dictionary<Guid, Vector3> BHOEHKHMFEP, bool DKLLELDOHAA = true, bool NFPDMJFPACB = true, bool IHJNDDDMJAB = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x815A730", Offset = "0x8159330", VA = "0x18815A730")]
	private static void CFHFCKFHOCB(Dictionary<Guid, Vector3> BHOEHKHMFEP, int KFOKMEJOIEA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public static class DLILIALIGFL
{
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	private struct BDPPFBAIOEB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public bool FMJNMGABEIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public LGPCNHIHIDJ DEBLJLLGKCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public LGPCNHIHIDJ NKBLHGODPCG;
	}

	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private static BDPPFBAIOEB HALLGDBDOKJ;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static CancellationToken EALJMBJMFLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x815AC90", Offset = "0x8159890", VA = "0x18815AC90")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	internal static LGPCNHIHIDJ DEBLJLLGKCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x815AED0", Offset = "0x8159AD0", VA = "0x18815AED0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x815AE60", Offset = "0x8159A60", VA = "0x18815AE60")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x815AB90", Offset = "0x8159790", VA = "0x18815AB90")]
	[HHMPGEJNNFC.FBIGHDDEPNK]
	internal static void CFEHOJBIEEO(LGPCNHIHIDJ BFHHLALAHLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x815AD00", Offset = "0x8159900", VA = "0x18815AD00")]
	public static void HLOPEGKIHMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x815ACB0", Offset = "0x81598B0", VA = "0x18815ACB0")]
	private static LGPCNHIHIDJ GAGICBBKGBC(LGPCNHIHIDJ IEJEJIAGNDN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
public static class MCNJEOHKACL
{
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	public enum JMDJBMFJJEE
	{
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		ICreationContextObject,
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		Guid
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x3D45BB0", Offset = "0x3D447B0", VA = "0x183D45BB0")]
	public static void IKPJELGLPPA<T>(T MIOFGENCPDE, JMDJBMFJJEE MDCDODCGNEK) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x3D45B50", Offset = "0x3D44750", VA = "0x183D45B50")]
	public static void IKPJELGLPPA<T>(T MIOFGENCPDE) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x3D45A70", Offset = "0x3D44670", VA = "0x183D45A70")]
	public static void IKPJELGLPPA<T, TImpl, T>() where T : class where TImpl : notnull, T where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x3D45E90", Offset = "0x3D44A90", VA = "0x183D45E90")]
	public static void OJEDDNPAIGL<T>(T MIOFGENCPDE) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x3D45CF0", Offset = "0x3D448F0", VA = "0x183D45CF0")]
	public static T LGFPFICEOKK<T>(JMDJBMFJJEE MDCDODCGNEK) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x3D458A0", Offset = "0x3D444A0", VA = "0x183D458A0")]
	public static bool GNMDKNPAJOM<T>(JMDJBMFJJEE MDCDODCGNEK, T? ABFIKNBHKON, [Out][MaybeNullWhen(false)][NotNullWhen(true)] T KDFKNHCCBBN) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x3D45D90", Offset = "0x3D44990", VA = "0x183D45D90")]
	public static bool MJEOFAEGOGI<T>(JMDJBMFJJEE MDCDODCGNEK, [Out][NotNullWhen(true)][MaybeNullWhen(false)] T MJNLPECMLGD) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x3D457C0", Offset = "0x3D443C0", VA = "0x183D457C0")]
	public static bool CCDKDBCBAFF<T>(JMDJBMFJJEE MDCDODCGNEK) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x3D45860", Offset = "0x3D44460", VA = "0x183D45860")]
	public static T LGFPFICEOKK<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x3D459D0", Offset = "0x3D445D0", VA = "0x183D459D0")]
	public static bool GNMDKNPAJOM<T>(T ABFIKNBHKON, [Out] T KDFKNHCCBBN) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x3D45860", Offset = "0x3D44460", VA = "0x183D45860")]
	public static bool CCDKDBCBAFF<T>() where T : class
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
internal static class ALNEIACHIHG
{
	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x815A1F0", Offset = "0x8158DF0", VA = "0x18815A1F0")]
	public static void PLDEJKPHNMP(IEnumerable PEDKIKCGBIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x31931E0", Offset = "0x3191DE0", VA = "0x1831931E0")]
	public static void PLDEJKPHNMP<T>(T[] COJHNLDFDFB) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x31933C0", Offset = "0x3191FC0", VA = "0x1831933C0")]
	public static void PLDEJKPHNMP<T>(T IILFEKLIFDP) where T : notnull, Enum
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
