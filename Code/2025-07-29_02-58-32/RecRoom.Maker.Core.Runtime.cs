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
		[Cpp2IlInjected.Address(RVA = "0xAAFD40", Offset = "0xAAE740", VA = "0x180AAFD40")]
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
		[Cpp2IlInjected.Address(RVA = "0x8361C80", Offset = "0x8360680", VA = "0x188361C80")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAB0110", Offset = "0xAAEB10", VA = "0x180AB0110")]
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
		[Cpp2IlInjected.Address(RVA = "0xAB0150", Offset = "0xAAEB50", VA = "0x180AB0150")]
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
		[Cpp2IlInjected.Address(RVA = "0x8361F70", Offset = "0x8360970", VA = "0x188361F70", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2906C90", Offset = "0x2905690", VA = "0x182906C90")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum AKAKGHINPHN
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	ShowFreeInventionsInR2PaletteSearch
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum BNPEEDMCOIH
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
public interface AAGHIBAHKDB<TData, TReturn>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TReturn EAJNAADLEFF(TData CEFJEHJNIAP);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface LLAKGOMIABB<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ClearHoverTarget(OKMKFILIGJN FHPECEFKIBM);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool SetHoverTarget(TData IMFCAPGBDGB, Collider JOENJLJLKNB, OKMKFILIGJN FHPECEFKIBM, [Optional] BCPAHBIDOOE? ALEHBOFMHNO);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool TryGetHoverTarget([Out] TData IMFCAPGBDGB);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool TryGetHoverCollider([Out] Collider JOENJLJLKNB);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface JCICAFELNAD<TData> : GDCDMMKMDGG, OPGCALBMHFD<TData>, JIPPCBJGEAN<TData>, GNBPJOEGJAK<TData>, EPBCLLLINGG, CKBEPLBGFPH<TData>, LNILKHJJHKF, HCFFKAIKALA
{
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface CKBEPLBGFPH<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool Raycast(Vector3 ENKAPPCINPK, Vector3 PNELABKCNPL, float JFEGIFCHDHH, [Out] T PHGNDOKGIBK, [Out] Vector3 NDPBCPGIAOC, [Out] Collider JOENJLJLKNB);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int SpherecastPick(Vector3 ENKAPPCINPK, Vector3 PNELABKCNPL, float LOAJCHMNLAD, float JFEGIFCHDHH, T[] OGPILGJOEII, [Out] Vector3 MLCIPDFMJLJ, [Out] Collider BDODMPHGBEB);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int SpherePick(Vector3 ENKAPPCINPK, float LOAJCHMNLAD, Vector3 GLINLLIKFBC, T[] OGPILGJOEII);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool TryGetObjectFromColliderInCurrentScope(Collider LCNIJABNGPK, [Out] T IBOKLPOPOHD);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface GDCDMMKMDGG
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Bounds IOMIBGHFJCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	Transform DGCKOFMALFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	Bounds NIEHPEBALOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Transform HEKCMCGJKCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	Vector3 APCBMFMEPND
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool AIHOFIFAFBC
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
	void SetSelectionBoundsDirty(bool IBLKDOCEJBF = true, int HHAIFHNNJDI = 0);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void ShouldHideSelectionBoundsPreview(bool OFLOANJICLB, object DHNMCOFINFM);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface HCFFKAIKALA
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	HPDJJKCNBLF OGIMNIENCJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface KAGBHBENOJH
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool CJGNILODDOB
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool IPMEJCDJGIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool AFNBOBMONNK
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
	void TrySetPreviousCloneMapping(Dictionary<Guid, Guid> EIEFMDPGJAP);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface GNBPJOEGJAK<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool KCKCOODKPMD
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	int OKOEAMCEOPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<TData> OIFOHKMOMEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IsSelected(TData HNLFGCKBFGI);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IsSelectable(TData HNLFGCKBFGI);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface OPGCALBMHFD<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void RenderHoverHighlight(T CEFJEHJNIAP, [Optional] BCPAHBIDOOE? MDAJNMHNCHC, bool LHCACIMCLDH = true);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RenderHoverHighlight(int CDCPIGCEABM, IEnumerable<T> KEDANMKGBBA, bool LHCACIMCLDH = true);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RenderHoverHighlight(int CDCPIGCEABM, IEnumerable<T> KEDANMKGBBA, BCPAHBIDOOE MDAJNMHNCHC, bool LHCACIMCLDH = true);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface LNILKHJJHKF
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnSelectionPickedUp();

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnSelectionReleased();
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface EPBCLLLINGG
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool DCNBHNMKNIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool KJGJHNDJOBO
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	bool EKILEMEGKCP
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	bool OBDAICPOBMG
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct NOIOFAFEHDC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public bool HEKFNGJEMMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public float? IHHLIGOHAKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public float? LDLJJOLFCNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public float? MABPILFFNBN;
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct OJMIEIABMPN<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public IEnumerable<TData> IGBOJCMDLCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public NOIOFAFEHDC IJHEKEHAOJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public bool COMGLCBBPKO;

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5A25200", Offset = "0x5A23C00", VA = "0x185A25200")]
	public OJMIEIABMPN(IEnumerable<TData> KAKEELPILFA, bool HONGGCDCBMI, float? BOBENCENLGF, float? OPPACCCPKCM, float? DHLHDBFLBMC, bool COMGLCBBPKO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface MMHKDLKCHBH<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IOLGKAAFKLA([In] OJMIEIABMPN<TData> GACFFBLMJOF);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class FFENNIKNOBA<TData> : FIMFBLDLBLG<MMHKDLKCHBH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly OJMIEIABMPN<TData> GACFFBLMJOF;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x4DF9370", Offset = "0x4DF7D70", VA = "0x184DF9370")]
	public FFENNIKNOBA(IEnumerable<TData> KAKEELPILFA, bool HONGGCDCBMI, float? BOBENCENLGF, float? OPPACCCPKCM, float? DHLHDBFLBMC, bool COMGLCBBPKO, MMHKDLKCHBH<TData> JCPGGABKCEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x494A230", Offset = "0x4948C30", VA = "0x18494A230", Slot = "4")]
	public override bool IOLGKAAFKLA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct ABIDIJPFNFB<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public IEnumerable<TData> IGBOJCMDLCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public string HHBAAHCOJDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public bool OANEHPDOHKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public bool COMGLCBBPKO;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5141A70", Offset = "0x5140470", VA = "0x185141A70")]
	public ABIDIJPFNFB(IEnumerable<TData> KAKEELPILFA, string OCELNAFHMKB, bool EFHKBCNGCGJ, bool COMGLCBBPKO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface EBPOHAPOACF<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IOLGKAAFKLA([In] ABIDIJPFNFB<TData> GACFFBLMJOF);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class DGMDICLOANM<TData> : FIMFBLDLBLG<EBPOHAPOACF<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly ABIDIJPFNFB<TData> GACFFBLMJOF;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6FFBBA0", Offset = "0x6FFA5A0", VA = "0x186FFBBA0")]
	public DGMDICLOANM(IEnumerable<TData> KAKEELPILFA, string OCELNAFHMKB, bool EFHKBCNGCGJ, bool COMGLCBBPKO, EBPOHAPOACF<TData> JCPGGABKCEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x494A230", Offset = "0x4948C30", VA = "0x18494A230", Slot = "4")]
	public override bool IOLGKAAFKLA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public abstract class FIMFBLDLBLG<TReceiver> : NEEPMMHHFNP<TReceiver, bool> where TReceiver : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x4DE3900", Offset = "0x4DE2300", VA = "0x184DE3900")]
	public FIMFBLDLBLG(TReceiver JCPGGABKCEJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public abstract class PGDPOFLJBAE<TReceiver, TFromTask> : NEEPMMHHFNP<TReceiver, Task<TFromTask>>
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x4DE3900", Offset = "0x4DE2300", VA = "0x184DE3900")]
	public PGDPOFLJBAE(TReceiver JCPGGABKCEJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public abstract class NEEPMMHHFNP<TReceiver, TFromExecute> where TReceiver : notnull where TFromExecute : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	protected TReceiver JCPGGABKCEJ;

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x58AE1F0", Offset = "0x58ACBF0", VA = "0x1858AE1F0")]
	public NEEPMMHHFNP(TReceiver JCPGGABKCEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TFromExecute IOLGKAAFKLA();
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public abstract class HBECOOMODFH<TReceiver, TResult> : NEEPMMHHFNP<TReceiver, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x4DE3900", Offset = "0x4DE2300", VA = "0x184DE3900")]
	public HBECOOMODFH(TReceiver JCPGGABKCEJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public struct FHKABFCAPKC<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public TGroup LBOCGLEGGKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public TData FNLGBEHAFBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public IEnumerable<TData> IGBOJCMDLCP;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x1DD2320", Offset = "0x1DD0D20", VA = "0x181DD2320")]
	public FHKABFCAPKC(TGroup DAGIJFADGGJ, TData IHKBIKNKHJM, IEnumerable<TData> KAKEELPILFA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct KGHCPLHCAGI<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public TGroup LBOCGLEGGKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public IEnumerable<TData> IGBOJCMDLCP;

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0xC12020", Offset = "0xC10A20", VA = "0x180C12020")]
	public KGHCPLHCAGI(TGroup DAGIJFADGGJ, IEnumerable<TData> KAKEELPILFA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct FOFMFBDLIMI<TGroup> where TGroup : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public TGroup LBOCGLEGGKI;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0xE76700", Offset = "0xE75100", VA = "0x180E76700")]
	public FOFMFBDLIMI(TGroup DAGIJFADGGJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public struct EJNAEKAOBMI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public IEnumerable<Guid> IGBOJCMDLCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public Guid HIKMCMJHAHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly bool AHKKCKDPIHA;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x83602A0", Offset = "0x835ECA0", VA = "0x1883602A0")]
	public EJNAEKAOBMI(IEnumerable<Guid> KAKEELPILFA, Guid ILKNJHOHFKB, bool COMGLCBBPKO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public struct GCFBGDLJCLL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public Guid HIKMCMJHAHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public readonly bool AHKKCKDPIHA;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x28BB180", Offset = "0x28B9B80", VA = "0x1828BB180")]
	public GCFBGDLJCLL(Guid ILKNJHOHFKB, bool COMGLCBBPKO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface NPEJAPCFLAM<TGroup, TData>
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JKBAJCFPDKG CJGKOOMNLLC(FHKABFCAPKC<TGroup, TData> LAJDCHMFAGD);

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "1")]
	JKBAJCFPDKG FFHAAIIBFIO(FHKABFCAPKC<TGroup, TData> LAJDCHMFAGD);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "2")]
	JKBAJCFPDKG NFMOFONFCLK(KGHCPLHCAGI<TGroup, TData> LAJDCHMFAGD);

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "3")]
	JKBAJCFPDKG JINEFNGJKLM(FOFMFBDLIMI<TGroup> LAJDCHMFAGD);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public interface KOGMDDCLBHJ
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<JKBAJCFPDKG> CJGKOOMNLLC(EJNAEKAOBMI LAJDCHMFAGD);

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<JKBAJCFPDKG> FFHAAIIBFIO(GCFBGDLJCLL LAJDCHMFAGD);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class GDMKDJPPEOK<TGroup, TData> : HBECOOMODFH<NPEJAPCFLAM<TGroup, TData>, JKBAJCFPDKG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly KGHCPLHCAGI<TGroup, TData> LAJDCHMFAGD;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x4F507F0", Offset = "0x4F4F1F0", VA = "0x184F507F0")]
	public GDMKDJPPEOK(TGroup DAGIJFADGGJ, IEnumerable<TData> KAKEELPILFA, NPEJAPCFLAM<TGroup, TData> JCPGGABKCEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x4F50720", Offset = "0x4F4F120", VA = "0x184F50720", Slot = "4")]
	public override JKBAJCFPDKG IOLGKAAFKLA()
	{
		return default(JKBAJCFPDKG);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class OCLBCIGHOCF<TGroup, TData> : HBECOOMODFH<NPEJAPCFLAM<TGroup, TData>, JKBAJCFPDKG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly FHKABFCAPKC<TGroup, TData> LAJDCHMFAGD;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x583C100", Offset = "0x583AB00", VA = "0x18583C100")]
	public OCLBCIGHOCF(TGroup DAGIJFADGGJ, TData BNEAHPGINFK, IEnumerable<TData> KAKEELPILFA, NPEJAPCFLAM<TGroup, TData> JCPGGABKCEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x59F6DE0", Offset = "0x59F57E0", VA = "0x1859F6DE0", Slot = "4")]
	public override JKBAJCFPDKG IOLGKAAFKLA()
	{
		return default(JKBAJCFPDKG);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class HGMDMCHDLGJ<TGroup, TData> : HBECOOMODFH<NPEJAPCFLAM<TGroup, TData>, JKBAJCFPDKG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly FOFMFBDLIMI<TGroup> LAJDCHMFAGD;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x5043740", Offset = "0x5042140", VA = "0x185043740")]
	public HGMDMCHDLGJ(TGroup DAGIJFADGGJ, NPEJAPCFLAM<TGroup, TData> JCPGGABKCEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x5043680", Offset = "0x5042080", VA = "0x185043680", Slot = "4")]
	public override JKBAJCFPDKG IOLGKAAFKLA()
	{
		return default(JKBAJCFPDKG);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class MMJOBBBEJPP<TGroup, TData> : HBECOOMODFH<NPEJAPCFLAM<TGroup, TData>, JKBAJCFPDKG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly FHKABFCAPKC<TGroup, TData> LAJDCHMFAGD;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x583C100", Offset = "0x583AB00", VA = "0x18583C100")]
	public MMJOBBBEJPP(TGroup DAGIJFADGGJ, TData IHKBIKNKHJM, IEnumerable<TData> KAKEELPILFA, NPEJAPCFLAM<TGroup, TData> JCPGGABKCEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x583C020", Offset = "0x583AA20", VA = "0x18583C020", Slot = "4")]
	public override JKBAJCFPDKG IOLGKAAFKLA()
	{
		return default(JKBAJCFPDKG);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class NJIKDBOPPDC : PGDPOFLJBAE<KOGMDDCLBHJ, JKBAJCFPDKG>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private struct KAKMPGPDLBD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public AsyncTaskMethodBuilder<JKBAJCFPDKG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public NJIKDBOPPDC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private TaskAwaiter<JKBAJCFPDKG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x8360E10", Offset = "0x835F810", VA = "0x188360E10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x83610A0", Offset = "0x835FAA0", VA = "0x1883610A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private EJNAEKAOBMI LAJDCHMFAGD;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x83617E0", Offset = "0x83601E0", VA = "0x1883617E0")]
	public NJIKDBOPPDC(IEnumerable<Guid> LALAKIFCLAN, Guid ILKNJHOHFKB, bool COMGLCBBPKO, KOGMDDCLBHJ JCPGGABKCEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x83616F0", Offset = "0x83600F0", VA = "0x1883616F0", Slot = "4")]
	[AsyncStateMachine(typeof(KAKMPGPDLBD))]
	public override Task<JKBAJCFPDKG> IOLGKAAFKLA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class JCLFOGBINLM : PGDPOFLJBAE<KOGMDDCLBHJ, JKBAJCFPDKG>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private struct LKKODBMHLPH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public AsyncTaskMethodBuilder<JKBAJCFPDKG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public JCLFOGBINLM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private TaskAwaiter<JKBAJCFPDKG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x8361150", Offset = "0x835FB50", VA = "0x188361150", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x83613F0", Offset = "0x835FDF0", VA = "0x1883613F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly GCFBGDLJCLL LAJDCHMFAGD;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x8360C30", Offset = "0x835F630", VA = "0x188360C30")]
	public JCLFOGBINLM(Guid ILKNJHOHFKB, bool COMGLCBBPKO, KOGMDDCLBHJ JCPGGABKCEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x8360B40", Offset = "0x835F540", VA = "0x188360B40", Slot = "4")]
	[AsyncStateMachine(typeof(LKKODBMHLPH))]
	public override Task<JKBAJCFPDKG> IOLGKAAFKLA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public readonly struct KIKPDFNPBPM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public readonly JPBGENOHBFL FPLGBLHGJDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly bool AHKKCKDPIHA;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x8361110", Offset = "0x835FB10", VA = "0x188361110")]
	public KIKPDFNPBPM(JPBGENOHBFL JPBIFMEBEOE, bool COMGLCBBPKO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface ODJEPNJENGF<TSpawnType> where TSpawnType : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> IOLGKAAFKLA(KIKPDFNPBPM GOFPDHEKNBG);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class DLEHIPFPIEH<TSpawnType> : PGDPOFLJBAE<ODJEPNJENGF<TSpawnType>, TSpawnType> where TSpawnType : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private struct HNMFOFHJMIA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public AsyncTaskMethodBuilder<TSpawnType> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public DLEHIPFPIEH<TSpawnType> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private TaskAwaiter<TSpawnType> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x50679B0", Offset = "0x50663B0", VA = "0x1850679B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x4F47B60", Offset = "0x4F46560", VA = "0x184F47B60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly KIKPDFNPBPM GOFPDHEKNBG;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x703CC10", Offset = "0x703B610", VA = "0x18703CC10")]
	public DLEHIPFPIEH(JPBGENOHBFL JPBIFMEBEOE, bool COMGLCBBPKO, ODJEPNJENGF<TSpawnType> JCPGGABKCEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x703CB10", Offset = "0x703B510", VA = "0x18703CB10", Slot = "4")]
	[AsyncStateMachine(typeof(DLEHIPFPIEH<>.HNMFOFHJMIA))]
	public override Task<TSpawnType> IOLGKAAFKLA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public readonly struct JPBGENOHBFL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly bool FJPHDCMOAOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly Vector3 EEAGNNDEMKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly Vector3 FLMJNMGJKCO;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x8360CE0", Offset = "0x835F6E0", VA = "0x188360CE0")]
	public JPBGENOHBFL(Transform MOHCJBDLCBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x8360DE0", Offset = "0x835F7E0", VA = "0x188360DE0")]
	public JPBGENOHBFL(Vector3 HKIFHFOHPEK, Vector3 DDIHIBMHCDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x8360CB0", Offset = "0x835F6B0", VA = "0x188360CB0")]
	public static JPBGENOHBFL GICKIFLNCPB()
	{
		return default(JPBGENOHBFL);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x8360D50", Offset = "0x835F750", VA = "0x188360D50")]
	private JPBGENOHBFL(bool IKLGOHDDGDD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public struct NGACGNPGNKJ<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public TNode BPEOFPKJENL;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x58B4300", Offset = "0x58B2D00", VA = "0x1858B4300")]
	public NGACGNPGNKJ(TNode BPEOFPKJENL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public struct FBDOIMHNLKI<TNode, TReparentOperations> where TNode : notnull where TReparentOperations : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public TNode OJBGPFHOBDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public TReparentOperations HIAPCIFNINH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public HHAMEAPOGFI DCKBFOCMNDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly bool AHKKCKDPIHA;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x4DEE950", Offset = "0x4DED350", VA = "0x184DEE950")]
	public FBDOIMHNLKI(TNode OJBGPFHOBDF, TReparentOperations HIAPCIFNINH, HHAMEAPOGFI DCKBFOCMNDM, bool COMGLCBBPKO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface EMPHOLEDOIG<TNode, TReparentOperations>
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KEBOKDDDBKE([In] NGACGNPGNKJ<TNode> BDGBNJMKNAA);

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DAOCLBLDNEA([In] FBDOIMHNLKI<TNode, TReparentOperations> NJBINGJIMAI);

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool KPJKJCFGNDG();
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class ILMNANMEMNP<TNode, TReparentOperations> : FIMFBLDLBLG<EMPHOLEDOIG<TNode, TReparentOperations>>
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x4DE3900", Offset = "0x4DE2300", VA = "0x184DE3900")]
	public ILMNANMEMNP(EMPHOLEDOIG<TNode, TReparentOperations> JCPGGABKCEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x516B850", Offset = "0x516A250", VA = "0x18516B850", Slot = "4")]
	public override bool IOLGKAAFKLA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public class KLHOCPLLICB<TNode, TReparentOperations> : FIMFBLDLBLG<EMPHOLEDOIG<TNode, TReparentOperations>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly FBDOIMHNLKI<TNode, TReparentOperations> NJBINGJIMAI;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5501A00", Offset = "0x5500400", VA = "0x185501A00")]
	public KLHOCPLLICB(TNode OJBGPFHOBDF, TReparentOperations HIAPCIFNINH, HHAMEAPOGFI DCKBFOCMNDM, EMPHOLEDOIG<TNode, TReparentOperations> JCPGGABKCEJ, bool COMGLCBBPKO = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x511E590", Offset = "0x511CF90", VA = "0x18511E590", Slot = "4")]
	public override bool IOLGKAAFKLA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public class IHKAHPAMFDN<TNode, TReparentOperations> : FIMFBLDLBLG<EMPHOLEDOIG<TNode, TReparentOperations>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly NGACGNPGNKJ<TNode> BDGBNJMKNAA;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x514FEF0", Offset = "0x514E8F0", VA = "0x18514FEF0")]
	public IHKAHPAMFDN(TNode LMNJNJOPBEN, EMPHOLEDOIG<TNode, TReparentOperations> JCPGGABKCEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x494A230", Offset = "0x4948C30", VA = "0x18494A230", Slot = "4")]
	public override bool IOLGKAAFKLA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct KHFAGFFLIIA<TSpawnInfo> where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public TSpawnInfo PNPEPJHPPCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public Vector3 DDIHIBMHCDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public Quaternion JCDLBIBEGAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public float DILGPPEHCGK;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x54F3D70", Offset = "0x54F2770", VA = "0x1854F3D70")]
	public KHFAGFFLIIA(TSpawnInfo PNPEPJHPPCM, Vector3 DDIHIBMHCDH, Quaternion JCDLBIBEGAF, float DILGPPEHCGK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public interface CAOGIAHKIIP<TSpawnType, TSpawnInfo>
{
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> DBKIMCFPCHB([In] KHFAGFFLIIA<TSpawnInfo> IIDCDJPHPPD, CancellationToken OMJKEHOJJFF);
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class DNEODCLJOKK<TSpawnType, TSpawnInfo> : PGDPOFLJBAE<CAOGIAHKIIP<TSpawnType, TSpawnInfo>, TSpawnType> where TSpawnType : notnull where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private readonly KHFAGFFLIIA<TSpawnInfo> GACFFBLMJOF;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x703E220", Offset = "0x703CC20", VA = "0x18703E220")]
	public DNEODCLJOKK(TSpawnInfo CCOMDAMBNHJ, Vector3 DDIHIBMHCDH, Quaternion JCDLBIBEGAF, float DILGPPEHCGK, CAOGIAHKIIP<TSpawnType, TSpawnInfo> JCPGGABKCEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x4945320", Offset = "0x4943D20", VA = "0x184945320", Slot = "4")]
	public override Task<TSpawnType> IOLGKAAFKLA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public readonly struct KMOLPIJPIGA<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly IEnumerable<TData> IGBOJCMDLCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public readonly bool AHKKCKDPIHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly bool DGGBPLICCJD;

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x5502660", Offset = "0x5501060", VA = "0x185502660")]
	public KMOLPIJPIGA(IEnumerable<TData> KAKEELPILFA, bool COMGLCBBPKO = false, bool ADMEAKIAOBO = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface BNKPGBFLAJG<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<JKBAJCFPDKG> FBMOPGCDHMB([In] KMOLPIJPIGA<TData> DIONIOJMHDF, CancellationToken OMJKEHOJJFF);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public class EKOOHCBKODI<TData> : PGDPOFLJBAE<BNKPGBFLAJG<TData>, JKBAJCFPDKG> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private readonly KMOLPIJPIGA<TData> PDOJBDJJDOA;

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x49454A0", Offset = "0x4943EA0", VA = "0x1849454A0")]
	public EKOOHCBKODI(IEnumerable<TData> KAKEELPILFA, bool COMGLCBBPKO, BNKPGBFLAJG<TData> JCPGGABKCEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x4945320", Offset = "0x4943D20", VA = "0x184945320", Slot = "4")]
	public override Task<JKBAJCFPDKG> IOLGKAAFKLA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public struct GJIJMPFPNBF<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly T IMFCAPGBDGB;

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x4F76730", Offset = "0x4F75130", VA = "0x184F76730")]
	public GJIJMPFPNBF(T DGFOJDLGJHN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface BCCIPCGFPMD<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KEBOKDDDBKE([In] GJIJMPFPNBF<T> HELALCOMKOB);

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DAOCLBLDNEA();
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface BPHMIHNIIFC<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IOLGKAAFKLA([In] GCNKIOCOCHO<T> GHLPNEFIBNH);
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public struct GCNKIOCOCHO<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public readonly T IMFCAPGBDGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly bool CBPGFCIOMJP;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x4F46CF0", Offset = "0x4F456F0", VA = "0x184F46CF0")]
	public GCNKIOCOCHO(T DGFOJDLGJHN, bool MBNAGILKAHA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class FHNGOBCANPP<T> : FIMFBLDLBLG<BCCIPCGFPMD<T>> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x4DE3900", Offset = "0x4DE2300", VA = "0x184DE3900")]
	public FHNGOBCANPP(BCCIPCGFPMD<T> JCPGGABKCEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x4E0B3B0", Offset = "0x4E09DB0", VA = "0x184E0B3B0", Slot = "4")]
	public override bool IOLGKAAFKLA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public class JHOEBMKDLAD<T> : FIMFBLDLBLG<BCCIPCGFPMD<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly GJIJMPFPNBF<T> HELALCOMKOB;

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x53D8B70", Offset = "0x53D7570", VA = "0x1853D8B70")]
	public JHOEBMKDLAD(T IMFCAPGBDGB, BCCIPCGFPMD<T> JCPGGABKCEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x494A230", Offset = "0x4948C30", VA = "0x18494A230", Slot = "4")]
	public override bool IOLGKAAFKLA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public class NMBFLKIHMPI<T> : FIMFBLDLBLG<BPHMIHNIIFC<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private readonly GCNKIOCOCHO<T> GHLPNEFIBNH;

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x58D8140", Offset = "0x58D6B40", VA = "0x1858D8140")]
	public NMBFLKIHMPI(T IMFCAPGBDGB, bool MBNAGILKAHA, BPHMIHNIIFC<T> JCPGGABKCEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x494A230", Offset = "0x4948C30", VA = "0x18494A230", Slot = "4")]
	public override bool IOLGKAAFKLA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public struct HMLKAOEKKGF<TData> where TData : notnull, OCIKAONEONB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public IEnumerable<TData> IGBOJCMDLCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public bool BDHLDJNLBFI;

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x505F570", Offset = "0x505DF70", VA = "0x18505F570")]
	public HMLKAOEKKGF(IEnumerable<TData> OKFFEIBIGJE, bool KOIGDIFFGIH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public struct FEMKLLMEIJN<TData> where TData : notnull, OCIKAONEONB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public List<TData> IGBOJCMDLCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public List<bool> LGHMPJFFNND;

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x4DF6210", Offset = "0x4DF4C10", VA = "0x184DF6210")]
	public FEMKLLMEIJN(List<TData> OKFFEIBIGJE, List<bool> DEOPHLBMHOG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface OCIKAONEONB
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	bool IAHOHILNGPE
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
public interface HIOKFIIHJNB<TData> where TData : OCIKAONEONB
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IOLGKAAFKLA([In] HMLKAOEKKGF<TData> CGAKGPELANM);

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IOLGKAAFKLA([In] FEMKLLMEIJN<TData> CGAKGPELANM);
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public interface GFKAKPKAHJF<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PEMPPAKAFBL(T IMFCAPGBDGB);
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public class PLMFJHACDBN<TData> : FIMFBLDLBLG<HIOKFIIHJNB<TData>> where TData : notnull, OCIKAONEONB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly HMLKAOEKKGF<TData> CGAKGPELANM;

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x5B522B0", Offset = "0x5B50CB0", VA = "0x185B522B0")]
	public PLMFJHACDBN(List<TData> KAKEELPILFA, bool BDHLDJNLBFI, HIOKFIIHJNB<TData> JCPGGABKCEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x494A230", Offset = "0x4948C30", VA = "0x18494A230", Slot = "4")]
	public override bool IOLGKAAFKLA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public class EHLPMIGLHFE<TData> : FIMFBLDLBLG<HIOKFIIHJNB<TData>> where TData : notnull, OCIKAONEONB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly FEMKLLMEIJN<TData> CGAKGPELANM;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x4937C40", Offset = "0x4936640", VA = "0x184937C40")]
	public EHLPMIGLHFE(List<TData> KAKEELPILFA, List<bool> LGHMPJFFNND, HIOKFIIHJNB<TData> JCPGGABKCEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x4937B80", Offset = "0x4936580", VA = "0x184937B80", Slot = "4")]
	public override bool IOLGKAAFKLA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public interface IKGBPMGPNPP<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<JKBAJCFPDKG> IOLGKAAFKLA(IMBPHJCDIGL<TData> JBPMAMAEOIE);
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public class DAKLCPNMKMK<TData> : PGDPOFLJBAE<IKGBPMGPNPP<TData>, JKBAJCFPDKG> where TData : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private struct PBLLALAJAFP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public AsyncTaskMethodBuilder<JKBAJCFPDKG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public DAKLCPNMKMK<TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private TaskAwaiter<JKBAJCFPDKG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x5AF7230", Offset = "0x5AF5C30", VA = "0x185AF7230", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x5AF7510", Offset = "0x5AF5F10", VA = "0x185AF7510", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly IMBPHJCDIGL<TData> KNIKBHKFOOM;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x6FEA250", Offset = "0x6FE8C50", VA = "0x186FEA250")]
	public DAKLCPNMKMK(TData PFFAAGKBBGD, IReadOnlyList<TData> ILOPLHAHENL, bool COMGLCBBPKO, IKGBPMGPNPP<TData> JCPGGABKCEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6FEA150", Offset = "0x6FE8B50", VA = "0x186FEA150", Slot = "4")]
	[AsyncStateMachine(typeof(DAKLCPNMKMK<>.PBLLALAJAFP))]
	public override Task<JKBAJCFPDKG> IOLGKAAFKLA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public struct IMBPHJCDIGL<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public TData IDHGLAHAJBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public IReadOnlyList<TData> POEGOGAIGIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public bool AHKKCKDPIHA;

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x2FF1570", Offset = "0x2FEFF70", VA = "0x182FF1570")]
	public IMBPHJCDIGL(TData PFFAAGKBBGD, IReadOnlyList<TData> ILOPLHAHENL, bool COMGLCBBPKO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public interface KAECDHJDIIH<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IOLGKAAFKLA([In] NIIMIFGHAJK<TData> CGNOJNOEKGM);
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public interface EDJCBDFHBLJ<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IOLGKAAFKLA([In] FIFKCBMNNPJ<TData> CGNOJNOEKGM);
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public interface OGJJBGJOFEB<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GOBHFCKLAOC([In] OADNAADJICM<TData> CGNOJNOEKGM);

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DAOCLBLDNEA();
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class NEBAFPAKFKP<TData> : FIMFBLDLBLG<KAECDHJDIIH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly NIIMIFGHAJK<TData> CGNOJNOEKGM;

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x58AD620", Offset = "0x58AC020", VA = "0x1858AD620")]
	public NEBAFPAKFKP(IEnumerable<TData> KAKEELPILFA, KJCFHBDBFJC EDNHAEBPHJD, GFPBOOEDAHD POCHLMCAOAO, float AKEFMMGMKDP, string? OCELNAFHMKB, bool HFLAEGJNMDC, bool COMGLCBBPKO, KAECDHJDIIH<TData> JCPGGABKCEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x494A230", Offset = "0x4948C30", VA = "0x18494A230", Slot = "4")]
	public override bool IOLGKAAFKLA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class DBCDDCECNKE<TData> : FIMFBLDLBLG<EDJCBDFHBLJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly FIFKCBMNNPJ<TData> CGNOJNOEKGM;

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x6FEAE50", Offset = "0x6FE9850", VA = "0x186FEAE50")]
	public DBCDDCECNKE(TData[] KAKEELPILFA, KJCFHBDBFJC[] EDNHAEBPHJD, GFPBOOEDAHD[] POCHLMCAOAO, float[] AKEFMMGMKDP, EDJCBDFHBLJ<TData> JCPGGABKCEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x5B295A0", Offset = "0x5B27FA0", VA = "0x185B295A0", Slot = "4")]
	public override bool IOLGKAAFKLA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class FOIPEDHJDHM<TData> : FIMFBLDLBLG<OGJJBGJOFEB<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x4DE3900", Offset = "0x4DE2300", VA = "0x184DE3900")]
	public FOIPEDHJDHM(OGJJBGJOFEB<TData> JCPGGABKCEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x4E513E0", Offset = "0x4E4FDE0", VA = "0x184E513E0", Slot = "4")]
	public override bool IOLGKAAFKLA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public class PKMLEGFMMFM<TData> : FIMFBLDLBLG<OGJJBGJOFEB<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly OADNAADJICM<TData> CGNOJNOEKGM;

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x5B29660", Offset = "0x5B28060", VA = "0x185B29660")]
	public PKMLEGFMMFM(IEnumerable<TData> KAKEELPILFA, KJCFHBDBFJC EDNHAEBPHJD, GFPBOOEDAHD POCHLMCAOAO, float AKEFMMGMKDP, OGJJBGJOFEB<TData> JCPGGABKCEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x5B295A0", Offset = "0x5B27FA0", VA = "0x185B295A0", Slot = "4")]
	public override bool IOLGKAAFKLA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public struct NIIMIFGHAJK<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public IEnumerable<TData> IGBOJCMDLCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public KJCFHBDBFJC CALPOELKNMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public GFPBOOEDAHD ADBOMPMBHDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public float ENNPFLHHJKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public string? HHBAAHCOJDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public bool? CPCLDMKDBDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public bool AHKKCKDPIHA;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x58BCBD0", Offset = "0x58BB5D0", VA = "0x1858BCBD0")]
	public NIIMIFGHAJK(IEnumerable<TData> KAKEELPILFA, KJCFHBDBFJC EDNHAEBPHJD, GFPBOOEDAHD POCHLMCAOAO, float AKEFMMGMKDP, string? OCELNAFHMKB, bool? HFLAEGJNMDC, bool COMGLCBBPKO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public struct FIFKCBMNNPJ<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public TData[] IGBOJCMDLCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public KJCFHBDBFJC[] CALPOELKNMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public GFPBOOEDAHD[] ADBOMPMBHDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public float[] AKEFMMGMKDP;

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x4E0C530", Offset = "0x4E0AF30", VA = "0x184E0C530")]
	public FIFKCBMNNPJ(TData[] KAKEELPILFA, KJCFHBDBFJC[] EDNHAEBPHJD, GFPBOOEDAHD[] POCHLMCAOAO, float[] AKEFMMGMKDP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public struct OADNAADJICM<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public IEnumerable<TData> IGBOJCMDLCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public KJCFHBDBFJC CALPOELKNMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public GFPBOOEDAHD ADBOMPMBHDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public float AKEFMMGMKDP;

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x59EE290", Offset = "0x59ECC90", VA = "0x1859EE290")]
	public OADNAADJICM(IEnumerable<TData> KAKEELPILFA, KJCFHBDBFJC EDNHAEBPHJD, GFPBOOEDAHD POCHLMCAOAO, float AKEFMMGMKDP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public interface JIPPCBJGEAN<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NFMOFONFCLK([In] NNALCCOJFLN<TData> DIONIOJMHDF);

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JINEFNGJKLM([In] NNALCCOJFLN<TData> DIONIOJMHDF);

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KELJCIMIMHK([In] bool BIHBEJEBIKN);

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool JLMDJNMHKCF([In] NNALCCOJFLN<TData> DIONIOJMHDF);

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PBPDOHMDJIP();

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool KPILONEKFFE([In] TData HGOIPELJBGF);
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public class AJILFIGMBIO<TData> : FIMFBLDLBLG<JIPPCBJGEAN<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly NNALCCOJFLN<TData> DIONIOJMHDF;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x530A1D0", Offset = "0x5308BD0", VA = "0x18530A1D0")]
	public AJILFIGMBIO(List<TData> AKIPGEFJGDO, JIPPCBJGEAN<TData> JCPGGABKCEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x494A230", Offset = "0x4948C30", VA = "0x18494A230", Slot = "4")]
	public override bool IOLGKAAFKLA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class MPBEIOBLAIG<TData> : FIMFBLDLBLG<JIPPCBJGEAN<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x4DE3900", Offset = "0x4DE2300", VA = "0x184DE3900")]
	public MPBEIOBLAIG(JIPPCBJGEAN<TData> JCPGGABKCEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x584D740", Offset = "0x584C140", VA = "0x18584D740", Slot = "4")]
	public override bool IOLGKAAFKLA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public class FFFLMOLAOHJ<TData> : FIMFBLDLBLG<JIPPCBJGEAN<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly bool COMGLCBBPKO;

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x4DF96C0", Offset = "0x4DF80C0", VA = "0x184DF96C0")]
	public FFFLMOLAOHJ(bool COMGLCBBPKO, JIPPCBJGEAN<TData> JCPGGABKCEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x4DF9660", Offset = "0x4DF8060", VA = "0x184DF9660", Slot = "4")]
	public override bool IOLGKAAFKLA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class FPMKECGNGMP<TData> : FIMFBLDLBLG<JIPPCBJGEAN<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly NNALCCOJFLN<TData> DIONIOJMHDF;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x4E54200", Offset = "0x4E52C00", VA = "0x184E54200")]
	public FPMKECGNGMP(List<TData> AKIPGEFJGDO, bool COMGLCBBPKO, JIPPCBJGEAN<TData> JCPGGABKCEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x4937B80", Offset = "0x4936580", VA = "0x184937B80", Slot = "4")]
	public override bool IOLGKAAFKLA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class IPNMDJALJML<TData> : FIMFBLDLBLG<JIPPCBJGEAN<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly TData HGOIPELJBGF;

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x51800E0", Offset = "0x517EAE0", VA = "0x1851800E0")]
	public IPNMDJALJML(TData HGOIPELJBGF, JIPPCBJGEAN<TData> JCPGGABKCEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x5180020", Offset = "0x517EA20", VA = "0x185180020", Slot = "4")]
	public override bool IOLGKAAFKLA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class FKGBMDBINKK<TData> : FIMFBLDLBLG<JIPPCBJGEAN<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private readonly NNALCCOJFLN<TData> DIONIOJMHDF;

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x4E1DC40", Offset = "0x4E1C640", VA = "0x184E1DC40")]
	public FKGBMDBINKK(IEnumerable<TData> AKIPGEFJGDO, JIPPCBJGEAN<TData> JCPGGABKCEJ, bool COMGLCBBPKO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x4E1DAE0", Offset = "0x4E1C4E0", VA = "0x184E1DAE0", Slot = "4")]
	public override bool IOLGKAAFKLA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public struct NNALCCOJFLN<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public IEnumerable<TData> IGBOJCMDLCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public bool COMGLCBBPKO;

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x58DA080", Offset = "0x58D8A80", VA = "0x1858DA080")]
	public NNALCCOJFLN(IEnumerable<TData> OKFFEIBIGJE, bool APDBGJPJCCH = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public interface LCGPEMNBLAP
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<JKBAJCFPDKG> IOLGKAAFKLA(PJEDJJPPJHL JKHOJJKGPDO);
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class DAJELFDGOHJ : PGDPOFLJBAE<LCGPEMNBLAP, JKBAJCFPDKG>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[CompilerGenerated]
	private struct JCKANDPAPBO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public AsyncTaskMethodBuilder<JKBAJCFPDKG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public DAJELFDGOHJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private TaskAwaiter<JKBAJCFPDKG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x8360850", Offset = "0x835F250", VA = "0x188360850", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x8360AD0", Offset = "0x835F4D0", VA = "0x188360AD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly PJEDJJPPJHL DBNKBDMBAAG;

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x8360040", Offset = "0x835EA40", VA = "0x188360040")]
	public DAJELFDGOHJ(bool COMGLCBBPKO, LCGPEMNBLAP JCPGGABKCEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x835FF50", Offset = "0x835E950", VA = "0x18835FF50", Slot = "4")]
	[AsyncStateMachine(typeof(JCKANDPAPBO))]
	public override Task<JKBAJCFPDKG> IOLGKAAFKLA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public struct PJEDJJPPJHL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public bool AHKKCKDPIHA;

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x2CC8EC0", Offset = "0x2CC78C0", VA = "0x182CC8EC0")]
	public PJEDJJPPJHL(bool COMGLCBBPKO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public readonly struct DOHLLHDAMHP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public readonly bool JIPEHINIBHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public readonly bool AGMBABDNOHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public readonly bool DILGPPEHCGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public readonly bool COMGLCBBPKO;

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x61CC6C0", Offset = "0x61CB0C0", VA = "0x1861CC6C0")]
	public DOHLLHDAMHP(bool JIPEHINIBHD, bool AGMBABDNOHJ, bool DILGPPEHCGK, bool COMGLCBBPKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x8360290", Offset = "0x835EC90", VA = "0x188360290")]
	public DOHLLHDAMHP(bool AGMBABDNOHJ, bool COMGLCBBPKO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public interface CLCMKADIOJL
{
	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CAOEDNFPKDL(DOHLLHDAMHP HIAANEAELEF);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool LONAHDDGCAL(DOHLLHDAMHP HIAANEAELEF);
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public class DNNEEOCIPPF : FIMFBLDLBLG<CLCMKADIOJL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly DOHLLHDAMHP HIAANEAELEF;

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x8360200", Offset = "0x835EC00", VA = "0x188360200")]
	public DNNEEOCIPPF(bool EOBBLENOIHL, bool AGMBABDNOHJ, bool DILGPPEHCGK, bool COMGLCBBPKO, CLCMKADIOJL JCPGGABKCEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x83601B0", Offset = "0x835EBB0", VA = "0x1883601B0", Slot = "4")]
	public override bool IOLGKAAFKLA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public class GAPIJMOMBKO : FIMFBLDLBLG<CLCMKADIOJL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly DOHLLHDAMHP HIAANEAELEF;

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x8360330", Offset = "0x835ED30", VA = "0x188360330")]
	public GAPIJMOMBKO(bool AGMBABDNOHJ, bool COMGLCBBPKO, CLCMKADIOJL JCPGGABKCEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x83602E0", Offset = "0x835ECE0", VA = "0x1883602E0", Slot = "4")]
	public override bool IOLGKAAFKLA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public interface KFLCFAHNAHE
{
	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IOLGKAAFKLA([In] HFNIBEKODIM CBFANNCLPEO);
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class NCOINEDMDIB : FIMFBLDLBLG<KFLCFAHNAHE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly HFNIBEKODIM CBFANNCLPEO;

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x8361510", Offset = "0x835FF10", VA = "0x188361510")]
	public NCOINEDMDIB(Guid[] EGPGALCFCDL, Vector3[] MPJMIAOHMFH, Quaternion[] NDHMBBJDJLI, float[] LHFNJDALAPE, Dictionary<Guid, Vector3> DEGNFOFBCDJ, KFLCFAHNAHE JCPGGABKCEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x8361460", Offset = "0x835FE60", VA = "0x188361460", Slot = "4")]
	public override bool IOLGKAAFKLA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public interface JJGDHACGDPH<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KEBOKDDDBKE([In] MFFMKKCNJDK<TData> BDGBNJMKNAA);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GOBHFCKLAOC([In] KJGMJHLPEIG MIOFDJGNEIC);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool GOBHFCKLAOC([In] PPDKNDGBDIJ MIOFDJGNEIC);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool DAOCLBLDNEA();
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class HELMNADJOBI<TData> : FIMFBLDLBLG<JJGDHACGDPH<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x4DE3900", Offset = "0x4DE2300", VA = "0x184DE3900")]
	public HELMNADJOBI(JJGDHACGDPH<TData> JCPGGABKCEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x5039340", Offset = "0x5037D40", VA = "0x185039340", Slot = "4")]
	public override bool IOLGKAAFKLA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public class CEGFLFDKPAE<TData> : FIMFBLDLBLG<JJGDHACGDPH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly KJGMJHLPEIG GNGJNEGNGEL;

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x696B300", Offset = "0x6969D00", VA = "0x18696B300")]
	public CEGFLFDKPAE(Vector3 BGIBAKIENGK, bool LDEIEFLDIPN, JJGDHACGDPH<TData> JCPGGABKCEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x4F56780", Offset = "0x4F55180", VA = "0x184F56780", Slot = "4")]
	public override bool IOLGKAAFKLA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public class LJGKPJMPKJD<TData> : FIMFBLDLBLG<JJGDHACGDPH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly PPDKNDGBDIJ GNGJNEGNGEL;

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x5617D40", Offset = "0x5616740", VA = "0x185617D40")]
	public LJGKPJMPKJD(Guid KBKAENJGJLI, int FILGHJLFKAL, Vector3 DDIHIBMHCDH, Quaternion JCDLBIBEGAF, float DLJDKOFPIMN, bool LDEIEFLDIPN, JJGDHACGDPH<TData> JCPGGABKCEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x5617CE0", Offset = "0x56166E0", VA = "0x185617CE0", Slot = "4")]
	public override bool IOLGKAAFKLA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public class FNKFMIKGABF<TData> : FIMFBLDLBLG<JJGDHACGDPH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly MFFMKKCNJDK<TData> GNGJNEGNGEL;

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x4E497C0", Offset = "0x4E481C0", VA = "0x184E497C0")]
	public FNKFMIKGABF(TData IMFCAPGBDGB, bool COMGLCBBPKO, JJGDHACGDPH<TData> JCPGGABKCEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x494A230", Offset = "0x4948C30", VA = "0x18494A230", Slot = "4")]
	public override bool IOLGKAAFKLA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public struct KJGMJHLPEIG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public readonly Vector3 BGIBAKIENGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public readonly bool LDEIEFLDIPN;

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x8361130", Offset = "0x835FB30", VA = "0x188361130")]
	public KJGMJHLPEIG(Vector3 BGIBAKIENGK, bool LDEIEFLDIPN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public struct PPDKNDGBDIJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public readonly Guid KBKAENJGJLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public readonly int FILGHJLFKAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public readonly Vector3 DDIHIBMHCDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public readonly Quaternion JCDLBIBEGAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public readonly float DLJDKOFPIMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public readonly bool LDEIEFLDIPN;

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x8361F30", Offset = "0x8360930", VA = "0x188361F30")]
	public PPDKNDGBDIJ(Guid KBKAENJGJLI, int FILGHJLFKAL, Vector3 DDIHIBMHCDH, Quaternion JCDLBIBEGAF, float DLJDKOFPIMN, bool LDEIEFLDIPN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public struct MFFMKKCNJDK<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public readonly TData IMFCAPGBDGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public readonly bool COMGLCBBPKO;

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x5819DF0", Offset = "0x58187F0", VA = "0x185819DF0")]
	public MFFMKKCNJDK(TData IMFCAPGBDGB, bool COMGLCBBPKO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public interface FJLAIFCNHFK<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IOLGKAAFKLA([In] IIPFIGEBOOB<TData> JCDBAPEBONO);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool IOLGKAAFKLA([In] FINECCHEMAF<TData> JCDBAPEBONO);
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public interface FJDPKJAFOCB<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KEBOKDDDBKE([In] AFKKLOCEFDB<TData> FDFMBOAGKMN);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GOBHFCKLAOC([In] AIGFCFNDEKG MIOFDJGNEIC);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool DAOCLBLDNEA();
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public class EOMKMMPMCPE<TData> : FIMFBLDLBLG<FJLAIFCNHFK<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly IIPFIGEBOOB<TData> JCDBAPEBONO;

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x494A2F0", Offset = "0x4948CF0", VA = "0x18494A2F0")]
	public EOMKMMPMCPE(IEnumerable<TData> KAKEELPILFA, Vector3 DPCBJFHIMBH, bool COMGLCBBPKO, FJLAIFCNHFK<TData> JCPGGABKCEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x494A230", Offset = "0x4948C30", VA = "0x18494A230", Slot = "4")]
	public override bool IOLGKAAFKLA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public class NPCOMGCJECE<TData> : FIMFBLDLBLG<FJDPKJAFOCB<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x4DE3900", Offset = "0x4DE2300", VA = "0x184DE3900")]
	public NPCOMGCJECE(FJDPKJAFOCB<TData> JCPGGABKCEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x516B850", Offset = "0x516A250", VA = "0x18516B850", Slot = "4")]
	public override bool IOLGKAAFKLA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public class LEOHOEKMDBP<TData> : FIMFBLDLBLG<FJDPKJAFOCB<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly AFKKLOCEFDB<TData> JCDBAPEBONO;

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x5592A40", Offset = "0x5591440", VA = "0x185592A40")]
	public LEOHOEKMDBP(IEnumerable<TData> KAKEELPILFA, bool COMGLCBBPKO, FJDPKJAFOCB<TData> JCPGGABKCEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x494A230", Offset = "0x4948C30", VA = "0x18494A230", Slot = "4")]
	public override bool IOLGKAAFKLA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public class IDOOBBLGEPF<TData> : FIMFBLDLBLG<FJLAIFCNHFK<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly FINECCHEMAF<TData> JCDBAPEBONO;

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x511E650", Offset = "0x511D050", VA = "0x18511E650")]
	public IDOOBBLGEPF(IEnumerable<TData> KAKEELPILFA, Vector3 GEDBKDPHPII, IIAGMGACJNE PEDMPEOEGJC, bool COMGLCBBPKO, FJLAIFCNHFK<TData> JCPGGABKCEJ, Space PHJGFFNKNBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x511E590", Offset = "0x511CF90", VA = "0x18511E590", Slot = "4")]
	public override bool IOLGKAAFKLA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public class MLIIGFPLFBO<TData> : FIMFBLDLBLG<FJDPKJAFOCB<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly AIGFCFNDEKG JCDBAPEBONO;

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x583B750", Offset = "0x583A150", VA = "0x18583B750")]
	public MLIIGFPLFBO(Vector3 DPCBJFHIMBH, FJDPKJAFOCB<TData> JCPGGABKCEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x4F56780", Offset = "0x4F55180", VA = "0x184F56780", Slot = "4")]
	public override bool IOLGKAAFKLA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public struct IIPFIGEBOOB<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public readonly IEnumerable<TData> KAKEELPILFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public readonly Vector3 DPCBJFHIMBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public readonly bool COMGLCBBPKO;

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x5153320", Offset = "0x5151D20", VA = "0x185153320")]
	public IIPFIGEBOOB(IEnumerable<TData> KAKEELPILFA, Vector3 DPCBJFHIMBH, bool COMGLCBBPKO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public struct AFKKLOCEFDB<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public readonly IEnumerable<TData> KAKEELPILFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public readonly bool COMGLCBBPKO;

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x5238270", Offset = "0x5236C70", VA = "0x185238270")]
	public AFKKLOCEFDB(IEnumerable<TData> KAKEELPILFA, bool COMGLCBBPKO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public struct FINECCHEMAF<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	public readonly IEnumerable<TData> KAKEELPILFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	public readonly Vector3 GEDBKDPHPII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public readonly IIAGMGACJNE PEDMPEOEGJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public readonly bool COMGLCBBPKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public readonly Space PHJGFFNKNBD;

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x4E10130", Offset = "0x4E0EB30", VA = "0x184E10130")]
	public FINECCHEMAF(IEnumerable<TData> KAKEELPILFA, Vector3 GEDBKDPHPII, IIAGMGACJNE PEDMPEOEGJC, bool COMGLCBBPKO, Space PHJGFFNKNBD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public struct AIGFCFNDEKG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public readonly Vector3 DPCBJFHIMBH;

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x2CC9F30", Offset = "0x2CC8930", VA = "0x182CC9F30")]
	public AIGFCFNDEKG(Vector3 DPCBJFHIMBH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public enum IIAGMGACJNE
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
public interface DEPHADMDIGA
{
	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IOLGKAAFKLA([In] LBPDCMNGOGA OKEFDDNKMAK);
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public class DCGJGIDGAOJ : FIMFBLDLBLG<DEPHADMDIGA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private readonly LBPDCMNGOGA OKEFDDNKMAK;

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x8360150", Offset = "0x835EB50", VA = "0x188360150")]
	public DCGJGIDGAOJ(bool COMGLCBBPKO, DEPHADMDIGA JCPGGABKCEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x83600A0", Offset = "0x835EAA0", VA = "0x1883600A0", Slot = "4")]
	public override bool IOLGKAAFKLA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public readonly struct LBPDCMNGOGA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public readonly bool COMGLCBBPKO;

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x2CC8EC0", Offset = "0x2CC78C0", VA = "0x182CC8EC0")]
	public LBPDCMNGOGA(bool COMGLCBBPKO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public interface JOJKNODKMJC<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IOLGKAAFKLA([In] IJADLGGEOBE<TData> KFJGININOCO);

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool IOLGKAAFKLA([In] LIOHCCMMINM<TData> KFJGININOCO);
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public interface CACHAKABHKL<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KEBOKDDDBKE([In] LEKBHELBHJI<TData> BDGBNJMKNAA);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GOBHFCKLAOC([In] PBJMGOKGDLN MIOFDJGNEIC);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool DAOCLBLDNEA();
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public class NAFDBCLAAHE<TData> : FIMFBLDLBLG<JOJKNODKMJC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private readonly IJADLGGEOBE<TData> KFJGININOCO;

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x589B920", Offset = "0x589A320", VA = "0x18589B920")]
	public NAFDBCLAAHE(IEnumerable<TData> KAKEELPILFA, Quaternion DPCBJFHIMBH, Vector3? HADGNHANOBD, bool ONDGGJCLEAI, bool COMGLCBBPKO, JOJKNODKMJC<TData> JCPGGABKCEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x494A230", Offset = "0x4948C30", VA = "0x18494A230", Slot = "4")]
	public override bool IOLGKAAFKLA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public class NICLFJBJOJG<TData> : FIMFBLDLBLG<CACHAKABHKL<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x4DE3900", Offset = "0x4DE2300", VA = "0x184DE3900")]
	public NICLFJBJOJG(CACHAKABHKL<TData> JCPGGABKCEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x516B850", Offset = "0x516A250", VA = "0x18516B850", Slot = "4")]
	public override bool IOLGKAAFKLA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public class FPAKEHMPIGD<TData> : FIMFBLDLBLG<CACHAKABHKL<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly LEKBHELBHJI<TData> KFJGININOCO;

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x4E514C0", Offset = "0x4E4FEC0", VA = "0x184E514C0")]
	public FPAKEHMPIGD(IEnumerable<TData> KAKEELPILFA, bool COMGLCBBPKO, CACHAKABHKL<TData> JCPGGABKCEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x494A230", Offset = "0x4948C30", VA = "0x18494A230", Slot = "4")]
	public override bool IOLGKAAFKLA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public class JNBEFLGHALF<TData> : FIMFBLDLBLG<JOJKNODKMJC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private readonly LIOHCCMMINM<TData> KFJGININOCO;

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x540B080", Offset = "0x5409A80", VA = "0x18540B080")]
	public JNBEFLGHALF(IEnumerable<TData> KAKEELPILFA, Quaternion NEGOMNLGDAE, IIAGMGACJNE LMBOCCOOMAL, Vector3? HADGNHANOBD, bool ONDGGJCLEAI, bool COMGLCBBPKO, Space PHJGFFNKNBD, JOJKNODKMJC<TData> JCPGGABKCEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x511E590", Offset = "0x511CF90", VA = "0x18511E590", Slot = "4")]
	public override bool IOLGKAAFKLA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public class GFGEONBEGCF<TData> : FIMFBLDLBLG<CACHAKABHKL<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private readonly PBJMGOKGDLN KFJGININOCO;

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x4F567E0", Offset = "0x4F551E0", VA = "0x184F567E0")]
	public GFGEONBEGCF(Quaternion DPCBJFHIMBH, Vector3? HADGNHANOBD, bool ONDGGJCLEAI, CACHAKABHKL<TData> JCPGGABKCEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x4F56780", Offset = "0x4F55180", VA = "0x184F56780", Slot = "4")]
	public override bool IOLGKAAFKLA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public struct IJADLGGEOBE<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public readonly IEnumerable<TData> KAKEELPILFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public readonly Quaternion DPCBJFHIMBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public readonly Vector3? HADGNHANOBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public readonly bool ONDGGJCLEAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public readonly bool COMGLCBBPKO;

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x5153440", Offset = "0x5151E40", VA = "0x185153440")]
	public IJADLGGEOBE(IEnumerable<TData> KAKEELPILFA, Quaternion DPCBJFHIMBH, Vector3? HADGNHANOBD, bool ONDGGJCLEAI, bool COMGLCBBPKO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public struct LEKBHELBHJI<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public readonly IEnumerable<TData> KAKEELPILFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public readonly bool COMGLCBBPKO;

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x55903F0", Offset = "0x558EDF0", VA = "0x1855903F0")]
	public LEKBHELBHJI(IEnumerable<TData> KAKEELPILFA, bool COMGLCBBPKO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public struct LIOHCCMMINM<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public readonly IEnumerable<TData> KAKEELPILFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public readonly Quaternion NEGOMNLGDAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public readonly IIAGMGACJNE LMBOCCOOMAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public readonly Vector3? HADGNHANOBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public readonly bool ONDGGJCLEAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public readonly bool COMGLCBBPKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public readonly Space PHJGFFNKNBD;

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x5616BB0", Offset = "0x56155B0", VA = "0x185616BB0")]
	public LIOHCCMMINM(IEnumerable<TData> KAKEELPILFA, Quaternion NEGOMNLGDAE, IIAGMGACJNE LMBOCCOOMAL, Vector3? HADGNHANOBD, bool ONDGGJCLEAI, bool COMGLCBBPKO, Space PHJGFFNKNBD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public struct PBJMGOKGDLN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public readonly Quaternion DPCBJFHIMBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public readonly Vector3? HADGNHANOBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public readonly bool ONDGGJCLEAI;

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x61821E0", Offset = "0x6180BE0", VA = "0x1861821E0")]
	public PBJMGOKGDLN(Quaternion DPCBJFHIMBH, Vector3? HADGNHANOBD, bool ONDGGJCLEAI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public interface JOOJKPOHNHM<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KEBOKDDDBKE([In] BFHNEEENEAK<TData> BDGBNJMKNAA);

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GOBHFCKLAOC([In] PJHCPKFMOLI MIOFDJGNEIC);

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool GOBHFCKLAOC([In] ALDHBNDOMAB MIOFDJGNEIC);

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool GOBHFCKLAOC([In] GIGNAEDLGON MIOFDJGNEIC);

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool DAOCLBLDNEA();
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public class DAPIGKCFOAB<TData> : FIMFBLDLBLG<JOOJKPOHNHM<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private readonly GIGNAEDLGON BECJNFMLCIB;

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x6FEA370", Offset = "0x6FE8D70", VA = "0x186FEA370")]
	public DAPIGKCFOAB(Vector3 KCOLDADAMNK, float OBEKFMJKMIG, Vector3 HADGNHANOBD, bool NFFGJDICDHB, bool PENLECPIKGH, JOOJKPOHNHM<TData> JCPGGABKCEJ, Space PHJGFFNKNBD = Space.Self)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x6FEA310", Offset = "0x6FE8D10", VA = "0x186FEA310", Slot = "4")]
	public override bool IOLGKAAFKLA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public class JGNLBLKNCDC<TData> : FIMFBLDLBLG<JOOJKPOHNHM<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x4DE3900", Offset = "0x4DE2300", VA = "0x184DE3900")]
	public JGNLBLKNCDC(JOOJKPOHNHM<TData> JCPGGABKCEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x53D3F10", Offset = "0x53D2910", VA = "0x1853D3F10", Slot = "4")]
	public override bool IOLGKAAFKLA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
public class NENCJLBDMCN<TData> : FIMFBLDLBLG<JOOJKPOHNHM<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private readonly BFHNEEENEAK<TData> BECJNFMLCIB;

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x58AE4B0", Offset = "0x58ACEB0", VA = "0x1858AE4B0")]
	public NENCJLBDMCN(IEnumerable<TData> KAKEELPILFA, bool COMGLCBBPKO, JOOJKPOHNHM<TData> JCPGGABKCEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x494A230", Offset = "0x4948C30", VA = "0x18494A230", Slot = "4")]
	public override bool IOLGKAAFKLA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
public class ADBHBFIKBPP<TData> : FIMFBLDLBLG<JOOJKPOHNHM<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private readonly ALDHBNDOMAB BECJNFMLCIB;

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x52336E0", Offset = "0x52320E0", VA = "0x1852336E0")]
	public ADBHBFIKBPP(float GBJHGFIBJJN, bool NJFGCCEMGEP, Vector3 HADGNHANOBD, JOOJKPOHNHM<TData> JCPGGABKCEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x5233620", Offset = "0x5232020", VA = "0x185233620", Slot = "4")]
	public override bool IOLGKAAFKLA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
public class KCGKOIDPCLO<TData> : FIMFBLDLBLG<JOOJKPOHNHM<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private readonly PJHCPKFMOLI BECJNFMLCIB;

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x54E2450", Offset = "0x54E0E50", VA = "0x1854E2450")]
	public KCGKOIDPCLO(float OBEKFMJKMIG, Vector3 HADGNHANOBD, JOOJKPOHNHM<TData> JCPGGABKCEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x4F56780", Offset = "0x4F55180", VA = "0x184F56780", Slot = "4")]
	public override bool IOLGKAAFKLA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
public struct GIGNAEDLGON
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public readonly Vector3 KCOLDADAMNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public readonly float OBEKFMJKMIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public readonly Vector3 HADGNHANOBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	public readonly bool LDEIEFLDIPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	public readonly Space PHJGFFNKNBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	public readonly bool PENLECPIKGH;

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x83603B0", Offset = "0x835EDB0", VA = "0x1883603B0")]
	public GIGNAEDLGON(Vector3 KCOLDADAMNK, float OBEKFMJKMIG, Vector3 HADGNHANOBD, bool LDEIEFLDIPN, bool JKOMGOCOLIJ, Space PHJGFFNKNBD = Space.Self)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public struct BFHNEEENEAK<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public readonly IEnumerable<TData> KAKEELPILFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public readonly bool COMGLCBBPKO;

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x6598380", Offset = "0x6596D80", VA = "0x186598380")]
	public BFHNEEENEAK(IEnumerable<TData> KAKEELPILFA, bool COMGLCBBPKO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
public struct ALDHBNDOMAB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public readonly float GBJHGFIBJJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public readonly bool NJFGCCEMGEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public readonly Vector3 HADGNHANOBD;

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x835FF30", Offset = "0x835E930", VA = "0x18835FF30")]
	public ALDHBNDOMAB(float GBJHGFIBJJN, bool NJFGCCEMGEP, Vector3 HADGNHANOBD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public struct PJHCPKFMOLI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public readonly float OBEKFMJKMIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public readonly Vector3 HADGNHANOBD;

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x6145830", Offset = "0x6144230", VA = "0x186145830")]
	public PJHCPKFMOLI(float OBEKFMJKMIG, Vector3 HADGNHANOBD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public struct HFNIBEKODIM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public readonly Guid[] KAKEELPILFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public readonly bool CPPKKHEMHNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public readonly bool NJKDAGDBFBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public readonly bool NLHIBBGCAAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public readonly Vector3[] MPJMIAOHMFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public readonly Quaternion[] NDHMBBJDJLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public readonly float[] LHFNJDALAPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public readonly Dictionary<Guid, Vector3> DEGNFOFBCDJ;

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x83605C0", Offset = "0x835EFC0", VA = "0x1883605C0")]
	public HFNIBEKODIM(Guid[] EGPGALCFCDL, Vector3[] MPJMIAOHMFH, Quaternion[] NDHMBBJDJLI, float[] LHFNJDALAPE, Dictionary<Guid, Vector3> DEGNFOFBCDJ, bool CPPKKHEMHNM = true, bool NJKDAGDBFBK = true, bool NLHIBBGCAAO = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x83603F0", Offset = "0x835EDF0", VA = "0x1883603F0")]
	private static void EDHEJPIJJDA(Dictionary<Guid, Vector3> DEGNFOFBCDJ, int FBDGJOBODAH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public static class NLOCAGGDKFH
{
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	private struct KICKKHGHNCJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public bool CIIMGBCFCFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public CFAMNNNCHJA EEJNMHAHMEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public CFAMNNNCHJA MDOLBNGMNOA;
	}

	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private static KICKKHGHNCJ KCHGHENEHBL;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static CancellationToken FIOAMKACPAK
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x8361C60", Offset = "0x8360660", VA = "0x188361C60")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	internal static CFAMNNNCHJA EEJNMHAHMEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x8361A70", Offset = "0x8360470", VA = "0x188361A70")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x8361A00", Offset = "0x8360400", VA = "0x188361A00")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x8361B10", Offset = "0x8360510", VA = "0x188361B10")]
	[PPMDKOHJEBA.DAJFAGCFHOC]
	internal static void JDFNEBKBOEL(CFAMNNNCHJA CHOMGGGNEFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x83618A0", Offset = "0x83602A0", VA = "0x1883618A0")]
	public static void AAJENMMCLHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x8361C10", Offset = "0x8360610", VA = "0x188361C10")]
	private static CFAMNNNCHJA MCILFGDEJCI(CFAMNNNCHJA PEBKMCJKHME)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
public static class CHJOMPKOCKD
{
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	public enum MLGLEEPAAIG
	{
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		ICreationContextObject,
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		Guid
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x3A6B4C0", Offset = "0x3A69EC0", VA = "0x183A6B4C0")]
	public static void NIPBDHIABGA<T>(T PKGDNOOHCCN, MLGLEEPAAIG AEOGKDPPBBE) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x3A6B600", Offset = "0x3A6A000", VA = "0x183A6B600")]
	public static void NIPBDHIABGA<T>(T PKGDNOOHCCN) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x3A6B3E0", Offset = "0x3A69DE0", VA = "0x183A6B3E0")]
	public static void NIPBDHIABGA<T, TImpl, T>() where T : class where TImpl : notnull, T where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x3A6AF20", Offset = "0x3A69920", VA = "0x183A6AF20")]
	public static void ALFIHNEOOGK<T>(T PKGDNOOHCCN) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x3A6AFD0", Offset = "0x3A699D0", VA = "0x183A6AFD0")]
	public static T DHBICMHDGKM<T>(MLGLEEPAAIG AEOGKDPPBBE) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x3A6B210", Offset = "0x3A69C10", VA = "0x183A6B210")]
	public static bool KPLGLDIBGLN<T>(MLGLEEPAAIG AEOGKDPPBBE, T? LPGCDHCEPCA, [Out][MaybeNullWhen(false)][NotNullWhen(true)] T EOAADPBPMKM) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x3A6B070", Offset = "0x3A69A70", VA = "0x183A6B070")]
	public static bool JDPDNIKFAPH<T>(MLGLEEPAAIG AEOGKDPPBBE, [Out][NotNullWhen(true)][MaybeNullWhen(false)] T IGEALLLBHHC) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x3A6B340", Offset = "0x3A69D40", VA = "0x183A6B340")]
	public static bool MNBAJCCCEPP<T>(MLGLEEPAAIG AEOGKDPPBBE) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x3A6AF90", Offset = "0x3A69990", VA = "0x183A6AF90")]
	public static T DHBICMHDGKM<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x3A6B170", Offset = "0x3A69B70", VA = "0x183A6B170")]
	public static bool KPLGLDIBGLN<T>(T LPGCDHCEPCA, [Out] T EOAADPBPMKM) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x3A6AF90", Offset = "0x3A69990", VA = "0x183A6AF90")]
	public static bool MNBAJCCCEPP<T>() where T : class
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
internal static class OMHHGBNIAFO
{
	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x8361D00", Offset = "0x8360700", VA = "0x188361D00")]
	public static void AIINPHKIHFC(IEnumerable PCAEHLGLCLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x3E4DCD0", Offset = "0x3E4C6D0", VA = "0x183E4DCD0")]
	public static void AIINPHKIHFC<T>(T[] JCEJMKLBKKB) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x3E4DEB0", Offset = "0x3E4C8B0", VA = "0x183E4DEB0")]
	public static void AIINPHKIHFC<T>(T IGABBOEDEPP) where T : notnull, Enum
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
