using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom;
using RecRoom.DataLayer;
using RecRoom.Foundation;
using RecRoom.Logging.Attributes;
using RecRoom.ObjectModel;
using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Properties;
using UnityEngine;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x9BC110", Offset = "0x9BB510", VA = "0x1809BC110")]
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
	internal sealed class IsUnmanagedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x9BC110", Offset = "0x9BB510", VA = "0x1809BC110")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace _LogRegistration.RecRoom_DataLayer_Interfaces_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : PNJEOLJBAIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x77C2E40", Offset = "0x77C2240", VA = "0x1877C2E40", Slot = "4")]
		public override void ELBDPICAHPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9BC110", Offset = "0x9BB510", VA = "0x1809BC110")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct NNAIHBJJNLB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private bool ICIHHNNNEBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private ViewId KFCLFFPDPGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private int NPELPNMIGOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private bool GJEDCHGMCDL;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x77C3550", Offset = "0x77C2950", VA = "0x1877C3550")]
	public NNAIHBJJNLB(ViewId KFCLFFPDPGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x77C3570", Offset = "0x77C2970", VA = "0x1877C3570")]
	public NNAIHBJJNLB(int NPELPNMIGOA, bool GJEDCHGMCDL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x77C3470", Offset = "0x77C2870", VA = "0x1877C3470")]
	public ViewId KHLIJEPDKDC([Optional] ViewId IPNKBIDKLEL)
	{
		return default(ViewId);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class DJJGKKPBKGC
{
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly Guid HHAGNLEGOOJ;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static readonly Guid ECCJJNEFKHC;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static readonly Guid IOEADBPDLDD;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public static readonly Guid LDAFNJLOOAO;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly Guid EAOCGEONJDH;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public static readonly Dictionary<string, Guid> DLBJCFOHOLA;

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static readonly RRObjectPrefabData COJEDKHGKKF;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly RRObjectPrefabData LNHCMBFOKOE;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly RRObjectPrefabData GJPIIILGKDN;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x77C0730", Offset = "0x77BFB30", VA = "0x1877C0730")]
	public static Guid JADBDIOHPPA(string MPGDCPPMNJN)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x77C0650", Offset = "0x77BFA50", VA = "0x1877C0650")]
	public static RRObjectPrefabData AMLFGKEONPD(PMHBKOEDEGH MAIGGPEPIHD)
	{
		return default(RRObjectPrefabData);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x77C06E0", Offset = "0x77BFAE0", VA = "0x1877C06E0")]
	public static RRObjectPrefabData GHPPELNCNJC(PMHBKOEDEGH MAIGGPEPIHD)
	{
		return default(RRObjectPrefabData);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x77C06C0", Offset = "0x77BFAC0", VA = "0x1877C06C0")]
	public static RRObjectPrefabData GHNBDGBEEJG(Guid IIBHEJCKGGH)
	{
		return default(RRObjectPrefabData);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[DefaultMember("Item")]
public class EJLLLMMKFBD : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly Dictionary<int, object> AMHCLKHIFKH;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public Dictionary<int, object> CBNHMBHNHHG
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x991DC0", Offset = "0x9911C0", VA = "0x180991DC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public object PPOFLIOMKNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x77C0F80", Offset = "0x77C0380", VA = "0x1877C0F80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x77C0FE0", Offset = "0x77C03E0", VA = "0x1877C0FE0")]
	public EJLLLMMKFBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x999BC0", Offset = "0x998FC0", VA = "0x180999BC0")]
	public EJLLLMMKFBD(Dictionary<int, object> AMHCLKHIFKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x77C0F20", Offset = "0x77C0320", VA = "0x1877C0F20")]
	public bool FHEFKDKCICI(FIJEABLBCOI MCBJECJLDOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3441560", Offset = "0x3440960", VA = "0x183441560")]
	public void HNKMNNGAGLI<T>(FIJEABLBCOI MCBJECJLDOM, T FIIKLGCIAGG, [Optional] T MBADHELIPJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x34413A0", Offset = "0x34407A0", VA = "0x1834413A0")]
	public void AJAPKMAIBCL<T>(FIJEABLBCOI MCBJECJLDOM, T FIIKLGCIAGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x77C0EC0", Offset = "0x77C02C0", VA = "0x1877C0EC0")]
	public void FBDLIPAFCGJ(FIJEABLBCOI MCBJECJLDOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x77C0E50", Offset = "0x77C0250", VA = "0x1877C0E50", Slot = "4")]
	public object Clone()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum FIJEABLBCOI : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	ColorOverride,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	TeamOverride,
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	MakerPenInteractionFilter,
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	PersistenceViewId,
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	R1ControlPanelCircuitContextId,
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	R1ControlPanelIsDeserializeId,
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	R1ControlPanelParentCircuitContextId,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	PreviewCircuitContextId,
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	PreviewCircuitContextIsDeserializeId,
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	CircuitNodeKey,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	SpawnableToolType,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	ObjectPickupLockedByKeyId,
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	CostumeEquipLockedByKeyId,
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	PreviewOnly,
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	CardBoxViewId,
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	RoleId,
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	WearerId,
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	PlayerSpawnedEquipmentPurpose,
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	PlayerSpawnedEquipmentColorGuid,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	PlayerSpawnedEquipmentModificationGuid,
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	BagId,
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	Tag,
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	SuppressCleanupTool,
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	SuppressAnimateInParticlesTool,
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	SuppressSkinsTool,
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	SuppressAnimInOut,
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	IgnoreDynamicCollisionsTool,
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	RuntimeSpawn,
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	OwnerPlayerId,
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	SpawnTags,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	ExcludeFromRoomSave,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	AvatarItem,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	ConsumableType,
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	ConsumableId,
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	GiftJson,
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	PlayerRootNetworkId,
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	Source,
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	UnitySubAssets
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct HFGOHCMPIPA<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public readonly FIJEABLBCOI MCBJECJLDOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly T MBADHELIPJM;

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4884390", Offset = "0x4883790", VA = "0x184884390")]
	public HFGOHCMPIPA(FIJEABLBCOI MCBJECJLDOM, T MBADHELIPJM)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x48842A0", Offset = "0x48836A0", VA = "0x1848842A0")]
	public static HFGOHCMPIPA<T> MDKCMNAEKLA(FIJEABLBCOI MCBJECJLDOM)
	{
		return default(HFGOHCMPIPA<T>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x4884170", Offset = "0x4883570", VA = "0x184884170")]
	public static HFGOHCMPIPA<T> MDKCMNAEKLA((FIJEABLBCOI key, T value) NJNDFFALKHH)
	{
		return default(HFGOHCMPIPA<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(KKELPJPLHOL))]
public struct GPMAMEJIKCA : IEnumerable<object>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private class KKELPJPLHOL : Dictionary<string, object>
	{
	}

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private static readonly ABDDJEPKCOD LEMJHEDOKDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private Dictionary<int, object> NFHKMOGHIBC;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool MOKMGBCLCOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x15F7740", Offset = "0x15F6B40", VA = "0x1815F7740")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int DLMGPHHMEHB
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x77C1460", Offset = "0x77C0860", VA = "0x1877C1460")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x77C14B0", Offset = "0x77C08B0", VA = "0x1877C14B0")]
	public static GPMAMEJIKCA DCJNBNANGBG()
	{
		return default(GPMAMEJIKCA);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0xC67CE0", Offset = "0xC670E0", VA = "0x180C67CE0")]
	public GPMAMEJIKCA([Optional] Dictionary<int, object> NFHKMOGHIBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x35C6CA0", Offset = "0x35C60A0", VA = "0x1835C6CA0")]
	public void LLICHLCEEGA<T>(HFGOHCMPIPA<T> MCBJECJLDOM, T? FIIKLGCIAGG) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x35C6AC0", Offset = "0x35C5EC0", VA = "0x1835C6AC0")]
	public void LLICHLCEEGA<T>((HFGOHCMPIPA<T> key, T value) PNBFGAKOODD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x35C6B30", Offset = "0x35C5F30", VA = "0x1835C6B30")]
	public void LLICHLCEEGA<T>(HFGOHCMPIPA<T> MCBJECJLDOM, T FIIKLGCIAGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x77C1640", Offset = "0x77C0A40", VA = "0x1877C1640")]
	public void IPLPGHMGFGO(GPMAMEJIKCA ICAPBAKKPBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x77C13E0", Offset = "0x77C07E0", VA = "0x1877C13E0")]
	private void AEJOPFDILPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x35C50A0", Offset = "0x35C44A0", VA = "0x1835C50A0")]
	public bool HNOOOLJPLPG<T>(HFGOHCMPIPA<T> MCBJECJLDOM, [Out] T FIIKLGCIAGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x35C4930", Offset = "0x35C3D30", VA = "0x1835C4930")]
	public bool HNOOOLJPLPG<T>(FIJEABLBCOI MCBJECJLDOM, [Out] T FIIKLGCIAGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x35C7B40", Offset = "0x35C6F40", VA = "0x1835C7B40")]
	public T OPDPDDMLDLG<T>(HFGOHCMPIPA<T> MCBJECJLDOM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x35C4810", Offset = "0x35C3C10", VA = "0x1835C4810")]
	public bool FHEFKDKCICI<T>(HFGOHCMPIPA<T> MCBJECJLDOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x77C1580", Offset = "0x77C0980", VA = "0x1877C1580")]
	public bool FHEFKDKCICI(FIJEABLBCOI MCBJECJLDOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x35C44F0", Offset = "0x35C38F0", VA = "0x1835C44F0")]
	public void FBDLIPAFCGJ<T>(HFGOHCMPIPA<T> MCBJECJLDOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x77C1530", Offset = "0x77C0930", VA = "0x1877C1530")]
	public void FBDLIPAFCGJ(FIJEABLBCOI MCBJECJLDOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0xC67BB0", Offset = "0xC66FB0", VA = "0x180C67BB0")]
	public Dictionary<int, object> MNGCGFIIJIH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x77C15E0", Offset = "0x77C09E0", VA = "0x1877C15E0", Slot = "4")]
	public IEnumerator<object> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x77C1850", Offset = "0x77C0C50", VA = "0x1877C1850", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public enum KJELJHLCLKC
{
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	PrefabComponents,
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	LocalObjectComponents,
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	NetworkedObjectComponents,
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	PolicyComponents,
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	ConnectableComponents,
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	RbexComponents,
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	TransformPoseComponents,
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	UniformTransformComponents,
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	DeformableSizeComponents,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	ShapeComponents,
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	PrimitiveComponents,
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	SplineComponents,
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	SplinePointComponents,
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	ContainerComponents,
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	ContainerLikeComponents,
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	ReplicatorComponents,
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	ContainerPivotComponents,
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	ShapeContainerComponents,
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	CostumePieceComponents,
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	PreventSerializationComponent,
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	DontPropagatePhysicsComponent,
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	DontPropagateOwnershipComponent,
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	LegacyGameObjectComponents,
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	GameObjectLegacyGizmoComponents,
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	GameObjectCostumeDummyPropComponents,
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	PlayerComponents,
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	PlayerRbexComponents,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	PlayerTransformComponents,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	RequireEmbodiedComponents,
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	EntityPrefabRootComponents,
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	EntityPrefabPartComponents,
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	SocketComponents,
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	VisibleInHierarchyComponents,
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	ToolCleanupComponents,
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	TagComponents,
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	InteractionFilterTagComponents,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	AutoEmbodimentComponents,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	ReferenceGroupComponents,
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	UserTagStorageComponents,
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	ReplicatedObjectComponents,
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	InteractionFilteringSettingsComponents,
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	InventionTrackingComponents,
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	ObjectBoardComponents,
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	NetworkTransformComponents,
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	AlwaysEmbodiedScopeComponents,
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	LoadInstanceLifetimeComponents,
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	PhysicsModelComponents,
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	StudioPropObjectComponents,
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	AnimationControllerComponents
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface BPMCNODDCDP
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public enum ACPEBHCGEKN
	{
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		Entity,
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		Prefab
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	LocalId OBFGLMGPDAA
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	RRObjectPrefabData CGPLKBHDBEK
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MLBEMAALMOC(params string[] MEBHEOCCLEP);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CNBIOIOMPPF(KJELJHLCLKC GPMMEHMNBEA, ACPEBHCGEKN MBENOAGKGBM = ACPEBHCGEKN.Entity);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void AONPMCOHEMM(Type MAIGGPEPIHD, ReadOnlySpan<byte> AMHCLKHIFKH, int IBOKFCFFPNJ, ACPEBHCGEKN MBENOAGKGBM = ACPEBHCGEKN.Entity);

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LIHOKIILKAJ(Type MAIGGPEPIHD, ACPEBHCGEKN MBENOAGKGBM = ACPEBHCGEKN.Entity);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void LAMNFMJHDJA(KJELJHLCLKC GPMMEHMNBEA, ACPEBHCGEKN MBENOAGKGBM = ACPEBHCGEKN.Entity);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool NEFFMIKNJMM(KJELJHLCLKC GPMMEHMNBEA);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void JLMACKOFMJD(bool KLNEAJOADMB, ACPEBHCGEKN MBENOAGKGBM = ACPEBHCGEKN.Entity);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void KMNJFKAHPOH();
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class BEABHOKGMNG
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x77BF960", Offset = "0x77BED60", VA = "0x1877BF960")]
	public static bool JEIDIOMKOHL(this BPMCNODDCDP PFPNPMCGHHC, KJELJHLCLKC KEPDMOAMLIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x77BF900", Offset = "0x77BED00", VA = "0x1877BF900")]
	public static void CBFBBMLGJGK(this BPMCNODDCDP PFPNPMCGHHC, BPMCNODDCDP.ACPEBHCGEKN MBENOAGKGBM = BPMCNODDCDP.ACPEBHCGEKN.Entity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x77BFB60", Offset = "0x77BEF60", VA = "0x1877BFB60")]
	public static void PGGIFHAIIMH(this BPMCNODDCDP PFPNPMCGHHC, BPMCNODDCDP.ACPEBHCGEKN MBENOAGKGBM = BPMCNODDCDP.ACPEBHCGEKN.Entity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x335C100", Offset = "0x335B500", VA = "0x18335C100")]
	public static void OEEALPILBPH<T>(this BPMCNODDCDP PFPNPMCGHHC, BPMCNODDCDP.ACPEBHCGEKN MBENOAGKGBM = BPMCNODDCDP.ACPEBHCGEKN.Entity) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x335C0D0", Offset = "0x335B4D0", VA = "0x18335C0D0")]
	public static void LKEIKDBHIHL<T>(this BPMCNODDCDP PFPNPMCGHHC, BPMCNODDCDP.ACPEBHCGEKN MBENOAGKGBM = BPMCNODDCDP.ACPEBHCGEKN.Entity) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x335BE80", Offset = "0x335B280", VA = "0x18335BE80")]
	public static void JECMNLDNDOK<T>(this BPMCNODDCDP PFPNPMCGHHC, bool NPIJGBKGJMD, BPMCNODDCDP.ACPEBHCGEKN MBENOAGKGBM = BPMCNODDCDP.ACPEBHCGEKN.Entity) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x335A2C0", Offset = "0x33596C0", VA = "0x18335A2C0")]
	public static void AONPMCOHEMM<T>(this BPMCNODDCDP PFPNPMCGHHC, T FIIKLGCIAGG, BPMCNODDCDP.ACPEBHCGEKN MBENOAGKGBM = BPMCNODDCDP.ACPEBHCGEKN.Entity) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x335BEF0", Offset = "0x335B2F0", VA = "0x18335BEF0")]
	public static void LIHOKIILKAJ<T>(this BPMCNODDCDP PFPNPMCGHHC, BPMCNODDCDP.ACPEBHCGEKN MBENOAGKGBM = BPMCNODDCDP.ACPEBHCGEKN.Entity) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x335BDE0", Offset = "0x335B1E0", VA = "0x18335BDE0")]
	public static void HLPCEEJGKIP<T>(this BPMCNODDCDP PFPNPMCGHHC, LocalId MBPEAJOCCID, BPMCNODDCDP.ACPEBHCGEKN MBENOAGKGBM = BPMCNODDCDP.ACPEBHCGEKN.Entity) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x335A110", Offset = "0x3359510", VA = "0x18335A110")]
	private static void AONPMCOHEMM<T>(this BPMCNODDCDP PFPNPMCGHHC, Type MAIGGPEPIHD, T FIIKLGCIAGG, BPMCNODDCDP.ACPEBHCGEKN MBENOAGKGBM = BPMCNODDCDP.ACPEBHCGEKN.Entity) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface JEOELMAEKKE
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	Entity IAFDAGDDGKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface MCFNOLNCJAA
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void Bake(BPMCNODDCDP PFPNPMCGHHC);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface HHBEHEHGCJH
{
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CPHLNOHLOEP(HEAAFFHJEKN EJFMLPKGCPJ);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GEMOEDAJGPO(HEAAFFHJEKN EJFMLPKGCPJ);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface GCIIPPECECE
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	ViewId OIINKEIGFPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface DKEJLBDINOD : GCIIPPECECE, ODPPNCKEBEL
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MBHBIOMKKEG(ViewId PPCIJNOBOKO, ViewId AJAJBPAIFPG, Dictionary<int, object> GCADBJPOPIH, HEAAFFHJEKN MLGOEAANOGC);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface IPABMCENOKG : GCIIPPECECE
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MBHBIOMKKEG(FJKKFAEOEBP PBIFOHNGFLL, Vector3 PFOFJFECKOD, Quaternion HKMKFJAMILI, Vector3 CMIEHLAIIDI, bool AONFCLNJFLM);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NHLIKHMMMKO(Vector3 PFOFJFECKOD, Quaternion HKMKFJAMILI, Vector3 CMIEHLAIIDI);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MEECIGHOFNG(ViewId PBIFOHNGFLL);

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EPCGGCAGMIE(bool IGDPJBEOIBB);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LCOBKLGODIG(bool CDFPCJGOPAN);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface ODPPNCKEBEL
{
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LKEDENKGAIC();
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface AHBNDOHGONG
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NativeArray<Guid> GDLHOAPJIKA(World DKMHLJBGIPA, NativeArray<Entity> CCIGPBFJEAO, Allocator LENIJMBFHJK);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct AMFAIIPMOGK : IComponentData, IEquatable<AMFAIIPMOGK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	[RecRoom.DataLayer.Default]
	[RecRoom.DataLayer.Field(1)]
	public uint HNMCNCHEPGK;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x77BF710", Offset = "0x77BEB10", VA = "0x1877BF710", Slot = "4")]
	public bool Equals(AMFAIIPMOGK JAPIEEBOJEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x77BF680", Offset = "0x77BEA80", VA = "0x1877BF680", Slot = "0")]
	public override bool Equals(object HAPOBHMBDHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x11C1CE0", Offset = "0x11C10E0", VA = "0x1811C1CE0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[SwatchPrimaryKey]
	[TypeManager.ForcedStableTypeHash(11322240854101484093uL)]
	[RecRoom.DataLayer.RRGuid("A8D1A28C-A057-4DF1-B0CF-22A81E217E19")]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct AuthoredAIIdData : IComponentData, IEquatable<AuthoredAIIdData>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public uint Value;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x77BF710", Offset = "0x77BEB10", VA = "0x1877BF710", Slot = "4")]
		public bool Equals(AuthoredAIIdData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x77BF780", Offset = "0x77BEB80", VA = "0x1877BF780", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x11C1CE0", Offset = "0x11C10E0", VA = "0x1811C1CE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[TypeManager.ForcedStableTypeHash(11505792609904010668uL)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[CompilerGenerated]
	[RecRoom.DataLayer.RRGuid("B7CEB5B9-453F-4712-B833-27D907AA13E2")]
	[RecRoom.DataLayer.StableTypeHash(11505792609904010668uL, 0u)]
	public struct AuthoredLocalPoseData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		[RecRoom.DataLayer.Default("new quaternion(new float4(float.NaN))")]
		[RecRoom.DataLayer.Field(1)]
		public quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		[RecRoom.DataLayer.Default("new float3(float.NaN)")]
		[RecRoom.DataLayer.Field(2)]
		public float3 localPosition;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public readonly bool IsValid
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x77BF810", Offset = "0x77BEC10", VA = "0x1877BF810")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x4D67640", Offset = "0x4D66A40", VA = "0x184D67640")]
		public AuthoredLocalPoseData(quaternion localRotation, float3 localPosition)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x77BF870", Offset = "0x77BEC70", VA = "0x1877BF870")]
		public static RigidTransform MDKCMNAEKLA(AuthoredLocalPoseData poseData)
		{
			return default(RigidTransform);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x77BF870", Offset = "0x77BEC70", VA = "0x1877BF870")]
		public static AuthoredLocalPoseData MDKCMNAEKLA(RigidTransform pose)
		{
			return default(AuthoredLocalPoseData);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class APGKHFPKJCH
{
	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x77BF750", Offset = "0x77BEB50", VA = "0x1877BF750")]
	public static AuthoredLocalPoseData LGMCKPDFMCC([In] this RigidTransform FIIKLGCIAGG)
	{
		return default(AuthoredLocalPoseData);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0xBD0860", Offset = "0xBCFC60", VA = "0x180BD0860")]
	public static RigidTransform GBDNBFNMJBC(this AuthoredLocalPoseData FIIKLGCIAGG)
	{
		return default(RigidTransform);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x77BF720", Offset = "0x77BEB20", VA = "0x1877BF720")]
	public static RigidTransform FNLJPDLLDKD([In] this AuthoredLocalPoseData FIIKLGCIAGG)
	{
		return default(RigidTransform);
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("C26C4B4E-5EF3-4F81-87C8-FED8EAD37242")]
	[RecRoom.DataLayer.StableTypeHash(9088562008033959482uL, 0u)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(9088562008033959482uL)]
	public struct AuthoredLocalUniformScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default(1f)]
		public float localUniformScale;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public readonly bool IsValid
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x77BF890", Offset = "0x77BEC90", VA = "0x1877BF890")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x28526F0", Offset = "0x2851AF0", VA = "0x1828526F0")]
		public AuthoredLocalUniformScaleData(float localUniformScale)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[TypeManager.ForcedStableTypeHash(10137300772124140051uL)]
	[RecRoom.DataLayer.RRGuid("7B1B8635-3FA9-4ADC-922B-3C25CE0C7E7D")]
	[RecRoom.DataLayer.StableTypeHash(10137300772124140051uL, 0u)]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct AuthoredParentData : IComponentData, JEOELMAEKKE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public Entity parent;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0xC67BB0", Offset = "0xC66FB0", VA = "0x180C67BB0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xE35E50", Offset = "0xE35250", VA = "0x180E35E50", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xE35E50", Offset = "0xE35250", VA = "0x180E35E50")]
		public AuthoredParentData(Entity parent)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0xBD0860", Offset = "0xBCFC60", VA = "0x180BD0860")]
		public static AuthoredParentData MDKCMNAEKLA(Entity entity)
		{
			return default(AuthoredParentData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x77BF8F0", Offset = "0x77BECF0", VA = "0x1877BF8F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001E")]
public struct PHLOFDBFIHP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001F")]
[TypeManager.ForcedStableTypeHash(11776442497872827640uL)]
public struct KKIAKMDIFMJ : IComponentData
{
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[TypeManager.ForcedStableTypeHash(8594223769175916906uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.StableTypeHash(8594223769175916906uL, 0u)]
	[RecRoom.DataLayer.RRGuid("B9A63EF5-66A5-463C-8385-A7DC7CE137C3")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct ObjectBoardNodeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public NetworkGuid nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(2)]
		public NetworkGuid graphId;
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[RecRoom.DataLayer.RRGuid("B26EF01D-F674-4506-80B7-5345391A097E")]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[TypeManager.ForcedStableTypeHash(5933855128949143734uL)]
	public struct ReplicatedObjectActiveStatusData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		[RecRoom.DataLayer.Default(true)]
		[RecRoom.DataLayer.Field(1)]
		public bool active;
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[RecRoom.DataLayer.RRGuid("E9BA10A4-4EE9-431D-BD7F-FF2008ABFA03")]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[TypeManager.ForcedStableTypeHash(16338184133650423946uL)]
	public struct ReplicatedObjectOwnedByPlayerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		[RecRoom.DataLayer.Default(-1)]
		[RecRoom.DataLayer.Field(1)]
		public int actorId;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000023")]
public struct LFIIANAPBGH : IComponentData
{
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[TypeManager.ForcedStableTypeHash(16223816226138460552uL)]
	[RecRoom.DataLayer.RRGuid("46C500A2-9991-4987-B1AA-66E5C3D8E371")]
	public struct ReplicatedObjectTag : IComponentData
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[RecRoom.DataLayer.RRGuid("5ED157AA-488F-453A-A986-594595B8D777")]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	[TypeManager.ForcedStableTypeHash(17912083982325865811uL)]
	[CompilerGenerated]
	public struct ReplicatorData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public Entity Target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		[RecRoom.DataLayer.Field(2)]
		[RecRoom.DataLayer.Default(false)]
		public bool NeedsCircuitUpdate;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct BBHHDACOHIA : IComponentData
{
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("AEA4D222-29BA-462F-9C0A-AA2063671C68")]
	[TypeManager.ForcedStableTypeHash(8691279933813304851uL)]
	[CompilerGenerated]
	public struct ReplicatorMaxObjectCountData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		[RecRoom.DataLayer.Default(10)]
		[RecRoom.DataLayer.Field(1)]
		public int count;
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(16379995002884076574uL)]
	[RecRoom.DataLayer.RRGuid("400790C1-E8D9-4779-A549-3780DAEC2FDF")]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	public struct ReplicatorPreallocatedObjectCountData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default(0)]
		public int preallocatedCopies;
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	[RecRoom.DataLayer.RRGuid("6A82044A-E392-4DCD-B4BC-A120E58334EA")]
	[RecRoom.DataLayer.StableTypeHash(8536678595025273356uL, 0u)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[TypeManager.ForcedStableTypeHash(8536678595025273356uL)]
	public struct EntityPrefabPartData : IComponentData, IComparable<EntityPrefabPartData>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public Entity prefabRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		[RecRoom.DataLayer.Field(2)]
		[RecRoom.DataLayer.Default]
		public uint partId;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x77C1070", Offset = "0x77C0470", VA = "0x1877C1070", Slot = "4")]
		public readonly int CompareTo(EntityPrefabPartData other)
		{
			return default(int);
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public struct EntityPrefabPartId : IEquatable<EntityPrefabPartId>, IComparable<EntityPrefabPartId>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		[SerializeField]
		private uint id;

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x11A6020", Offset = "0x11A5420", VA = "0x1811A6020")]
		internal EntityPrefabPartId(uint IIKCEJDFBDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x9DD8E0", Offset = "0x9DCCE0", VA = "0x1809DD8E0")]
		internal uint KDLCODIBCDC()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x1FF4240", Offset = "0x1FF3640", VA = "0x181FF4240", Slot = "4")]
		public bool Equals(EntityPrefabPartId JAPIEEBOJEA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x77C10C0", Offset = "0x77C04C0", VA = "0x1877C10C0", Slot = "0")]
		public override bool Equals(object HAPOBHMBDHP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x11C1CE0", Offset = "0x11C10E0", VA = "0x1811C1CE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x1FF41A0", Offset = "0x1FF35A0", VA = "0x181FF41A0", Slot = "5")]
		public int CompareTo(EntityPrefabPartId JAPIEEBOJEA)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[TypeManager.ForcedStableTypeHash(15026348711748810383uL)]
public struct NDPGJJJIKGE : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public Entity DOGEJFLHEAM;
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	[ConfigGroup("Physics", 0)]
	[TypeManager.ForcedStableTypeHash(2330616907306882483uL)]
	[RecRoom.DataLayer.RRGuid("F74D558B-BDCC-48C8-A8EF-1F7559E5EAA0")]
	[CompilerGenerated]
	public struct PhysicsModelCollisionModeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		[Config(null, 0)]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default(IEHBBGFNHHB.Children)]
		public IEHBBGFNHHB collisionMode;
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	[ConfigGroup("Container", 0)]
	[TypeManager.ForcedStableTypeHash(11125590729425051511uL)]
	[RecRoom.DataLayer.RRGuid("8A12EB45-2A15-41CE-AFF7-90A9F984D3A2")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct ContainerIsRecolorableData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		[Config(null, 0)]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public bool IsRecolorable;
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(14800424556151816553uL)]
	[RecRoom.DataLayer.RRGuid("55EAB643-95BB-4C3A-832C-798EBCD95AD5")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[InternalBufferCapacity(0)]
	public struct ContainerNameBuffer : IBufferElementData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public byte data;
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[TypeManager.ForcedStableTypeHash(13657791279235747653uL)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[CompilerGenerated]
	[RecRoom.DataLayer.StableTypeHash(13657791279235747653uL, 0u)]
	[ConfigGroup("Container", 0)]
	[RecRoom.DataLayer.RRGuid("89708D57-D027-494A-A159-221E6C643B6B")]
	public struct ContainerNameData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		[Config(null, 0)]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public FixedString64Bytes name;
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	[RecRoom.DataLayer.RRGuid("CA023286-E0F6-4DA9-A346-94E86B93977C")]
	[TypeManager.ForcedStableTypeHash(13904209480152351845uL)]
	[CompilerGenerated]
	[ConfigGroup("Physics", 0)]
	public struct PhysicsModelGrabbableModeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		[RecRoom.DataLayer.Field(1)]
		[Config(null, 0)]
		[RecRoom.DataLayer.Default]
		public FNONMPLFBAH grabbableMode;
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("84485C1B-18ED-4D4A-86A4-34CEED482615")]
	[TypeManager.ForcedStableTypeHash(16485879999901987510uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.StableTypeHash(16485879999901987510uL, 0u)]
	[ConfigGroup("Container", 0)]
	public struct NavMeshGenerationData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default(IPEFDNGGMKI.NavMeshGenerator)]
		[Config(null, 0)]
		public IPEFDNGGMKI mode;
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[TypeManager.ForcedStableTypeHash(1954118413118190521uL)]
	[CompilerGenerated]
	[ConfigGroup("Physics", 0)]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	[RecRoom.DataLayer.RRGuid("C5BCE8B3-6E69-41D4-921A-BE2E3E0A4DAB")]
	public struct PhysicsModelCollisionLayerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		[Config(null, 0)]
		[RecRoom.DataLayer.Default(NMNNBIJOGOM.IsDynamicEnvironment)]
		[RecRoom.DataLayer.Field(1)]
		public NMNNBIJOGOM collisionLayer;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class DNNPHEOCEMB
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public enum IKLMJGGHGHB
	{
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		Dynamic,
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		Static,
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		Enemy,
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		Vehicle
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public enum GKGELOBIBJJ
	{
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		Environmental,
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		IgnoreStaticGeometry,
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		IgnoreOtherDynamic,
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		IgnorePlayers,
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		IgnoreMost,
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		Projectile
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x77C0BA0", Offset = "0x77BFFA0", VA = "0x1877C0BA0")]
	public static (IKLMJGGHGHB, GKGELOBIBJJ) ONFGCICPMLC(this NMNNBIJOGOM JBHMHOMJPDO)
	{
		return default((IKLMJGGHGHB, GKGELOBIBJJ));
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[TypeManager.ForcedStableTypeHash(16462677563651546047uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(4, false)]
	[ConfigGroup("Physics", 0)]
	[RecRoom.DataLayer.RRGuid("F63AA9EA-6191-4DE9-BB18-1F049F432124")]
	public struct PhysicsModelFlagsData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		[Config(null, 0)]
		[RecRoom.DataLayer.Default(GFLDGCHPDND.DEFAULT)]
		[RecRoom.DataLayer.Field(1)]
		public GFLDGCHPDND flags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[RecRoom.DataLayer.RRGuid("B6D08147-6AEA-4270-BDC4-8CF68662318D")]
	[TypeManager.ForcedStableTypeHash(1094837642118998916uL)]
	[CompilerGenerated]
	[ConfigGroup("Physics", 0)]
	[RecRoom.DataLayer.StableTypeHash(1094837642118998916uL, 0u)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct PhysicsModelMassOverrideData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		[RecRoom.DataLayer.Default(0f)]
		[Config(null, 0)]
		[RecRoom.DataLayer.Field(1)]
		public float mass;
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[TypeManager.ForcedStableTypeHash(1537567323754185605uL)]
	[RecRoom.DataLayer.RRGuid("D732BC3D-4F8D-4FDE-BDB2-88C095D973C2")]
	[RecRoom.DataLayer.StableTypeHash(1537567323754185605uL, 0u)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[CompilerGenerated]
	public struct CostumePieceParentCostumeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public Entity parentCostume;
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	[RecRoom.DataLayer.StableTypeHash(5115014870530256079uL, 0u)]
	[TypeManager.ForcedStableTypeHash(5115014870530256079uL)]
	[RecRoom.DataLayer.RRGuid("36A2D516-8596-4794-BEAE-40BECA68C798")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct CostumePieceSlotIndexData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public int slotIndex;
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[RecRoom.DataLayer.RRGuid("17799917-98EE-4D9A-A8D1-B0BE5F7316E3")]
	[TypeManager.ForcedStableTypeHash(10518841812724430444uL)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[CompilerGenerated]
	public struct InventionIdData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default(0L)]
		public long inventionId;

		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public const long INVALID_INVENTION_ID = 0L;

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xBD0860", Offset = "0xBCFC60", VA = "0x180BD0860")]
		public static InventionIdData MDKCMNAEKLA(long value)
		{
			return default(InventionIdData);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x77C29F0", Offset = "0x77C1DF0", VA = "0x1877C29F0")]
		public readonly bool DEHEMAOBJEB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x75300D0", Offset = "0x752F4D0", VA = "0x1875300D0")]
		public static bool DEHEMAOBJEB(long inventionId)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	[RecRoom.DataLayer.RRGuid("629F0A56-C478-4353-BBDA-8A8BB5FEE478")]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	[RecRoom.DataLayer.TombstonedFields(new int[] { 1 })]
	[TypeManager.ForcedStableTypeHash(14338988155392421373uL)]
	public struct InventionInstanceIdData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		[RecRoom.DataLayer.Field(2)]
		[RecRoom.DataLayer.Default]
		public NetworkGuid instanceId;

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x110A3D0", Offset = "0x11097D0", VA = "0x18110A3D0")]
		public static InventionInstanceIdData MDKCMNAEKLA(Guid value)
		{
			return default(InventionInstanceIdData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[RuntimeOnly]
	[TypeManager.ForcedStableTypeHash(12111354511484844847uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.StableTypeHash(12111354511484844847uL, 0u)]
	[RecRoom.DataLayer.RRGuid("A3B27452-BD6C-43B2-BAFF-CF885EB1608B")]
	public struct ParentData : IComponentData, JEOELMAEKKE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public Entity parent;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0xC67BB0", Offset = "0xC66FB0", VA = "0x180C67BB0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0xE35E50", Offset = "0xE35250", VA = "0x180E35E50", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0xE35E50", Offset = "0xE35250", VA = "0x180E35E50")]
		public ParentData(Entity parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xBD0860", Offset = "0xBCFC60", VA = "0x180BD0860")]
		public static implicit operator ParentData(Entity entity)
		{
			return default(ParentData);
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003D")]
public struct EDEKBAHPICK : IComponentData
{
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[TypeManager.ForcedStableTypeHash(1950029632769634832uL)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[CompilerGenerated]
	[RecRoom.DataLayer.RRGuid("c886150a-7231-4cc5-a2b2-f222500e6960")]
	[RecRoom.DataLayer.StableTypeHash(1950029632769634832uL, 0u)]
	public struct SiblingSortOrderData : IEquatable<SiblingSortOrderData>, IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public ICHONNPKFBH order;

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0xBD0860", Offset = "0xBCFC60", VA = "0x180BD0860")]
		public static SiblingSortOrderData MDKCMNAEKLA(ICHONNPKFBH value)
		{
			return default(SiblingSortOrderData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x77C2150", Offset = "0x77C1550", VA = "0x1877C2150", Slot = "4")]
		public bool Equals(SiblingSortOrderData other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("46CEA601-8AA7-423D-B1EA-EEABAE73413F")]
	[TypeManager.ForcedStableTypeHash(6217116203744017593uL)]
	public struct InteractionFilterAllTagsData : IComponentData, JEOELMAEKKE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public Entity allTags;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0xC67BB0", Offset = "0xC66FB0", VA = "0x180C67BB0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0xE35E50", Offset = "0xE35250", VA = "0x180E35E50", Slot = "5")]
			set
			{
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[RecRoom.DataLayer.RRGuid("49CEFD0F-3A38-4A9B-835E-10B4C2D08392")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(6215026851838101933uL)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct InteractionFilterAnyTagsData : IComponentData, JEOELMAEKKE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public Entity anyTags;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xC67BB0", Offset = "0xC66FB0", VA = "0x180C67BB0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xE35E50", Offset = "0xE35250", VA = "0x180E35E50", Slot = "5")]
			set
			{
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("11CE457F-4366-4AAD-B7E3-28D82B4FAFCF")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(6780642047612598977uL)]
	public struct InteractionFilterEnabledData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		[RecRoom.DataLayer.Default(CIIOGCMNFDK.Disabled)]
		[RecRoom.DataLayer.Field(1)]
		public CIIOGCMNFDK filterMode;
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(6642820932987006861uL)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("F7789094-7D82-4D27-B805-2CC1B8C0A538")]
	public struct InteractionFilterEntityRefData : IComponentData, JEOELMAEKKE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public Entity filterEntity;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0xC67BB0", Offset = "0xC66FB0", VA = "0x180C67BB0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0xE35E50", Offset = "0xE35250", VA = "0x180E35E50", Slot = "5")]
			set
			{
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[TypeManager.ForcedStableTypeHash(15467295871228743847uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.RRGuid("C7E95AF7-DB7D-4432-8DAA-8F36EC6C4308")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct InteractionFilterNoneTagsData : IComponentData, JEOELMAEKKE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public Entity noneTags;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0xC67BB0", Offset = "0xC66FB0", VA = "0x180C67BB0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0xE35E50", Offset = "0xE35250", VA = "0x180E35E50", Slot = "5")]
			set
			{
			}
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("007F8815-C87C-4E6B-BC56-3BA0C4888E3D")]
	[RecRoom.DataLayer.StableTypeHash(15012400804589552708uL, 0u)]
	[TypeManager.ForcedStableTypeHash(15012400804589552708uL)]
	public struct OverrideObjectNetworkIdData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public uint networkIdBits;
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(4540375434353162791uL)]
	[RecRoom.DataLayer.RRGuid("30228348-77DF-48F6-B2EF-B0883D3E10CA")]
	public struct MakerPenHeldData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public bool makerPenHeld;
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[ConfigGroup("Object", 0)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(8459715919607487693uL)]
	[RecRoom.DataLayer.NetworkComponent(6, false)]
	[RecRoom.DataLayer.RRGuid("FB9853D6-6231-43FD-A754-00105DC30880")]
	public struct ObjectPolicyData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		[RecRoom.DataLayer.Field(2)]
		[RecRoom.DataLayer.Default("new ScaleRestriction(1,1)")]
		public GDMHDEGEKJE scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		[RecRoom.DataLayer.Default("ObjectPolicyUserConfigurableFlags.DEFAULT")]
		[Config(null, 0)]
		[RecRoom.DataLayer.Field(3)]
		public JBEIFKBPHCL userConfigurableFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		[RecRoom.DataLayer.Field(4)]
		[RecRoom.DataLayer.Default(JPHGCKAMKCE.Default)]
		[Config(null, 0)]
		public JPHGCKAMKCE circuitsTransformBehavior;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default("ObjectPolicyEnumFlags.Default")]
		public CFMKEFNDENA flags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[RecRoom.DataLayer.StableTypeHash(17708500325183871236uL, 0u)]
	[RecRoom.DataLayer.RRGuid("617A903E-C2C2-467C-A138-287FDB487645")]
	[TypeManager.ForcedStableTypeHash(17708500325183871236uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct PlayerScopeData : IComponentData, JEOELMAEKKE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public Entity playerScope;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public Entity Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xC67BB0", Offset = "0xC66FB0", VA = "0x180C67BB0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xE35E50", Offset = "0xE35250", VA = "0x180E35E50", Slot = "5")]
			set
			{
			}
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xBD0860", Offset = "0xBCFC60", VA = "0x180BD0860")]
		public static PlayerScopeData MDKCMNAEKLA(Entity entity)
		{
			return default(PlayerScopeData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[TypeManager.ForcedStableTypeHash(16642773407304133105uL)]
	[ConfigGroup("Physics", 0)]
	[RecRoom.DataLayer.StableTypeHash(16642773407304133105uL, 0u)]
	[RecRoom.DataLayer.RRGuid("F945B699-C9E5-4634-9F64-831484F4F3BD")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[CompilerGenerated]
	public struct PhysicsMaterialData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		[RecRoom.DataLayer.Default(10f)]
		[RecRoom.DataLayer.Field(1)]
		[Config(null, 0)]
		public float density;
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.StableTypeHash(10537432342869025182uL, 0u)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(10537432342869025182uL)]
	[RecRoom.DataLayer.RRGuid("A2E0AF0F-C284-47E6-9535-A67A29BF5730")]
	public struct ShapeConfigData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		[RecRoom.DataLayer.Default(JIHOGGHEDMF.None)]
		[RecRoom.DataLayer.Field(1)]
		public JIHOGGHEDMF flags;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool DynamicUVProjection
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x6C04610", Offset = "0x6C03A10", VA = "0x186C04610")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool PreventInvertedCreation
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x6C04600", Offset = "0x6C03A00", VA = "0x186C04600")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool NewBendLogic
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x77C3BF0", Offset = "0x77C2FF0", VA = "0x1877C3BF0")]
			get
			{
				return default(bool);
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[TypeManager.ForcedStableTypeHash(10917729582819845312uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("5C706BF1-9D50-456A-B974-521E8E2CC660")]
	[RecRoom.DataLayer.StableTypeHash(10917729582819845312uL, 0u)]
	public struct ShapeTypeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public NFCAIDCIJJF shapeType;
	}
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[RecRoom.DataLayer.StableTypeHash(5298506180484533559uL, 0u)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("36418781-DB47-4DE7-A138-CC88D1D795C0")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(5298506180484533559uL)]
	public struct SplinePointOrderData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public ICHONNPKFBH order;

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0xBD0860", Offset = "0xBCFC60", VA = "0x180BD0860")]
		public static SplinePointOrderData MDKCMNAEKLA(ICHONNPKFBH value)
		{
			return default(SplinePointOrderData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[RecRoom.DataLayer.RRGuid("FCEE3BCD-9C10-4BF4-954A-0DCFE8810227")]
	[TypeManager.ForcedStableTypeHash(16368389834000856208uL)]
	[RecRoom.DataLayer.StableTypeHash(16368389834000856208uL, 0u)]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct SplinePointParentData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public Entity spline;
	}
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[TypeManager.ForcedStableTypeHash(18095612727592564636uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.StableTypeHash(18095612727592564636uL, 0u)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("5A6D38A4-1A58-4EB4-9C1B-06ADA0D44AFA")]
	public struct SplinePointPositionData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public float3 localPosition;
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[TypeManager.ForcedStableTypeHash(1429513518619209486uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("433F66B6-CC1C-4A8A-BF73-2B797440A8DB")]
	[RecRoom.DataLayer.StableTypeHash(1429513518619209486uL, 0u)]
	public struct SplinePointRotationData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		[RecRoom.DataLayer.Default("new quaternion(0, 0, 0, 1f)")]
		[RecRoom.DataLayer.Field(1)]
		public quaternion localRotation;
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	[RecRoom.DataLayer.RRGuid("04CA3CCE-F121-4B5B-BC56-FE8E9C77F0F4")]
	[RecRoom.DataLayer.StableTypeHash(1238044349990854547uL, 0u)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[TypeManager.ForcedStableTypeHash(1238044349990854547uL)]
	public struct SplinePointScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default("new float3(1)")]
		public float3 localScale;
	}
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("E0610986-0F8F-494A-8C6E-8A2D2491B088")]
	[RecRoom.DataLayer.StableTypeHash(4657247877648983868uL, 0u)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(4657247877648983868uL)]
	public struct SplineShapeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public IJKALMPDIAP parameters;
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	[RecRoom.DataLayer.RRGuid("73C344D9-D535-4753-9D9A-B6DEDE4079B0")]
	[RecRoom.DataLayer.StableTypeHash(12332323170023439017uL, 0u)]
	[RecRoom.DataLayer.TombstonedFields(new int[] { 1 })]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(12332323170023439017uL)]
	public struct OMShapeContainerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		[RecRoom.DataLayer.Field(2)]
		[RecRoom.DataLayer.Default(true)]
		public bool canModifyWithCircuits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		[RecRoom.DataLayer.Default(true)]
		[RecRoom.DataLayer.Field(3)]
		public bool optimizedCollidersEnabled;
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	[RecRoom.DataLayer.RRGuid("2B5C4208-9113-4F65-B3A6-18EAE1FF3937")]
	[TypeManager.ForcedStableTypeHash(17673274643717888315uL)]
	public struct SerializedDataLayerVersionData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public int version;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.RRGuid("CC657074-87FD-47F7-A7B0-F5CCE922A9D0")]
[RecRoom.DataLayer.Range(BNNPCJEEJFG.MIN, BNNPCJEEJFG.ALL)]
[Flags]
public enum BNNPCJEEJFG
{
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	IsAllowed = 1,
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	UseDefaultVisualEffects = 2,
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	DEFAULT = 2,
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	ALL = 3,
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	MAX = 3
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("34BA53CB-16FB-45DB-AA25-293CE7C8DAE4")]
	[TypeManager.ForcedStableTypeHash(5328722791392374178uL)]
	public struct ToolCleanupSettingsData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		[RecRoom.DataLayer.Default(15f)]
		[RecRoom.DataLayer.Field(1)]
		public float delay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		[RecRoom.DataLayer.Field(2)]
		[RecRoom.DataLayer.Default(BNNPCJEEJFG.UseDefaultVisualEffects)]
		public BNNPCJEEJFG toolCleanupFlags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[TypeManager.ForcedStableTypeHash(13768238190614302474uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.TombstonedFields(new int[] { 2, 3 })]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	[RecRoom.DataLayer.RRGuid("48C72ABE-383D-45C6-9610-773F2B4F84C6")]
	public struct ToolCleanupStatusData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public float cleanupStartTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		[RecRoom.DataLayer.Field(4)]
		[RecRoom.DataLayer.Default]
		public NFOAHHPMJGH statusFlags;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[Flags]
[RecRoom.DataLayer.Range(NFOAHHPMJGH.None, NFOAHHPMJGH.ALL)]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.RRGuid("E63050BA-D087-4027-99F8-4AFDEA229CD8")]
public enum NFOAHHPMJGH
{
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	ForceCleanup = 1,
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	CleanupDone = 2,
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	CleanupPaused = 4,
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	ALL = 7,
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	MAX = 7
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	[RecRoom.DataLayer.RRGuid("021E8703-AAFD-4965-8C38-FF86663126D2")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(463077377357487319uL)]
	public struct LocalDeformableScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		[RecRoom.DataLayer.Default("new float3(1)")]
		[RecRoom.DataLayer.Field(1)]
		public float3 localDeformationScale;

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0xE14CA0", Offset = "0xE140A0", VA = "0x180E14CA0")]
		public LocalDeformableScaleData(float3 scale)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[RecRoom.DataLayer.StableTypeHash(1369925932270831712uL, 0u)]
	[CompilerGenerated]
	[RecRoom.DataLayer.RRGuid("38AA9F1D-FD16-4B56-917C-3341D0EB1DF2")]
	[TypeManager.ForcedStableTypeHash(1369925932270831712uL)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct LocalPoseData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		[RecRoom.DataLayer.Default("new quaternion(0,0,0,1)")]
		[RecRoom.DataLayer.Field(1)]
		public quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		[RecRoom.DataLayer.Field(2)]
		[RecRoom.DataLayer.Default]
		public float3 localPosition;

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x4D67640", Offset = "0x4D66A40", VA = "0x184D67640")]
		public LocalPoseData(quaternion localRotation, float3 localPosition)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x77BF870", Offset = "0x77BEC70", VA = "0x1877BF870")]
		public static RigidTransform MDKCMNAEKLA(LocalPoseData poseData)
		{
			return default(RigidTransform);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x77BF870", Offset = "0x77BEC70", VA = "0x1877BF870")]
		public static LocalPoseData MDKCMNAEKLA(RigidTransform pose)
		{
			return default(LocalPoseData);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public static class LMAICDLBBEB
{
	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x77C2E10", Offset = "0x77C2210", VA = "0x1877C2E10")]
	public static LocalPoseData PCFNNHLCJNJ([In] this RigidTransform FIIKLGCIAGG)
	{
		return default(LocalPoseData);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x77C2DE0", Offset = "0x77C21E0", VA = "0x1877C2DE0")]
	public static RigidTransform FNLJPDLLDKD([In] this LocalPoseData FIIKLGCIAGG)
	{
		return default(RigidTransform);
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("0E9FADE9-751A-4A53-B455-4F8EA675754D")]
	[RecRoom.DataLayer.StableTypeHash(2720902521635056246uL, 0u)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(2720902521635056246uL)]
	public struct LocalUniformScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default(1f)]
		public float localUniformScale;
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.StableTypeHash(5730545663584378555uL, 0u)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(5730545663584378555uL)]
	[RecRoom.DataLayer.RRGuid("F01774C0-98E7-491E-AAA5-85B64AFFA182")]
	public struct TransformFlagsData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public PBCNMOHBOKP transformHint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(2)]
		public COHGCJIEJHF transformPriority;
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[RecRoom.DataLayer.RRGuid("392BF0C9-F464-491A-8725-E4B5E5C4ECD4")]
	[RecRoom.DataLayer.DoNotGenerateComponentProperties]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(12583036596830542024uL)]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	public struct RRObjectPrefabData : ISharedComponentData, IEquatable<RRObjectPrefabData>, IComparable<RRObjectPrefabData>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public PMHBKOEDEGH prefabType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		[RecRoom.DataLayer.Field(2)]
		[RecRoom.DataLayer.Default]
		public Guid prefabGuid;

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x77C3A70", Offset = "0x77C2E70", VA = "0x1877C3A70")]
		public RRObjectPrefabData(Guid prefabGuid, PMHBKOEDEGH prefabType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x77C3970", Offset = "0x77C2D70", VA = "0x1877C3970", Slot = "4")]
		public readonly bool Equals(RRObjectPrefabData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x77C38B0", Offset = "0x77C2CB0", VA = "0x1877C38B0", Slot = "0")]
		public override readonly bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x77C3AE0", Offset = "0x77C2EE0", VA = "0x1877C3AE0")]
		public static bool operator !=(RRObjectPrefabData a, RRObjectPrefabData b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x77C3A80", Offset = "0x77C2E80", VA = "0x1877C3A80")]
		public static bool operator ==(RRObjectPrefabData a, RRObjectPrefabData b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x77C2BA0", Offset = "0x77C1FA0", VA = "0x1877C2BA0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x77C37E0", Offset = "0x77C2BE0", VA = "0x1877C37E0", Slot = "5")]
		public readonly int CompareTo(RRObjectPrefabData other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x77C39D0", Offset = "0x77C2DD0", VA = "0x1877C39D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[TypeManager.ForcedStableTypeHash(17550159503907726442uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.RRGuid("FF90B503-A0B5-4B3D-BACF-046FA1456FBD")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct ReferenceGroupKindData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public MDOHGMNCHPB kind;
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(18363292822319307914uL)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("2C78EEBE-6DD9-44FF-A70D-6C2EE9BB8FB3")]
	public struct ReferenceGroupOwnerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public Entity owner;
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[TypeManager.ForcedStableTypeHash(11947588904347318594uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.RRGuid("177498E9-83A6-4C2E-A8C1-B1951B47E74D")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct ReferenceGroupReferenceBuffer : IBufferElementData, JEOELMAEKKE, IEquatable<ReferenceGroupReferenceBuffer>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public Entity reference;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public Entity Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xC67BB0", Offset = "0xC66FB0", VA = "0x180C67BB0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0xE35E50", Offset = "0xE35250", VA = "0x180E35E50", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x77C3BE0", Offset = "0x77C2FE0", VA = "0x1877C3BE0", Slot = "6")]
		public bool Equals(ReferenceGroupReferenceBuffer other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x77C3B50", Offset = "0x77C2F50", VA = "0x1877C3B50", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x9DD8E0", Offset = "0x9DCCE0", VA = "0x1809DD8E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000060")]
public struct IJPFHEOJAMO : IEqualityComparer<ReferenceGroupReferenceBuffer>
{
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public static IJPFHEOJAMO OCEPFJKKOBL;

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x77C28A0", Offset = "0x77C1CA0", VA = "0x1877C28A0", Slot = "4")]
	public bool Equals(ReferenceGroupReferenceBuffer JFJPEDLJOKC, ReferenceGroupReferenceBuffer MJINJIJLGDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0xCFB520", Offset = "0xCFA920", VA = "0x180CFB520", Slot = "5")]
	public int GetHashCode(ReferenceGroupReferenceBuffer HAPOBHMBDHP)
	{
		return default(int);
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[TypeManager.ForcedStableTypeHash(17466046755328781668uL)]
	[InternalBufferCapacity(0)]
	[RecRoom.DataLayer.RRGuid("DE12A401-BD29-4B00-A629-7EFBECEDCFDF")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[CompilerGenerated]
	public struct AuthoredUserTagReferenceBuffer : OHAEHGBAAKP, IBufferElementData, JEOELMAEKKE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public Entity Child;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0xC67BB0", Offset = "0xC66FB0", VA = "0x180C67BB0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0xE35E50", Offset = "0xE35250", VA = "0x180E35E50", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0xE35E50", Offset = "0xE35250", VA = "0x180E35E50")]
		public AuthoredUserTagReferenceBuffer(Entity entity)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0xBD0860", Offset = "0xBCFC60", VA = "0x180BD0860")]
		public static AuthoredUserTagReferenceBuffer MDKCMNAEKLA(Entity entity)
		{
			return default(AuthoredUserTagReferenceBuffer);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public interface OHAEHGBAAKP : IBufferElementData, JEOELMAEKKE
{
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[TypeManager.ForcedStableTypeHash(12148147190301245780uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.RRGuid("00B7CB5E-4C0C-4D2C-AC95-78529EE58768")]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	public struct PersistentUserTagData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public FixedList32Bytes<int> tags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		[RecRoom.DataLayer.Field(2)]
		[RecRoom.DataLayer.Default(false)]
		public bool initalizedDefaults;
	}
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[SwatchPrimaryKey]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("80D85A55-B2F6-4860-A851-62973DC10940")]
	[RecRoom.DataLayer.StableTypeHash(1859693175312uL, 0u)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(1859693175312uL)]
	public struct UserTagNameData : IComponentData, IEquatable<UserTagNameData>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public FixedString32Bytes Value;

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x77C3D20", Offset = "0x77C3120", VA = "0x1877C3D20")]
		public UserTagNameData(string value)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x77C3CE0", Offset = "0x77C30E0", VA = "0x1877C3CE0")]
		public static UserTagNameData MDKCMNAEKLA(string value)
		{
			return default(UserTagNameData);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x77C3C00", Offset = "0x77C3000", VA = "0x1877C3C00", Slot = "4")]
		public bool Equals(UserTagNameData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x77C3C30", Offset = "0x77C3030", VA = "0x1877C3C30", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x77C3CD0", Offset = "0x77C30D0", VA = "0x1877C3CD0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[RecRoom.DataLayer.RRGuid("1E609F72-38C4-433D-BB17-B718F89DF446")]
	[InternalBufferCapacity(0)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[TypeManager.ForcedStableTypeHash(2039749658960193818uL)]
	[CompilerGenerated]
	public struct UserTagReferenceBuffer : OHAEHGBAAKP, IBufferElementData, JEOELMAEKKE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public Entity Child;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0xC67BB0", Offset = "0xC66FB0", VA = "0x180C67BB0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0xE35E50", Offset = "0xE35250", VA = "0x180E35E50", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0xE35E50", Offset = "0xE35250", VA = "0x180E35E50")]
		public UserTagReferenceBuffer(Entity entity)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0xBD0860", Offset = "0xBCFC60", VA = "0x180BD0860")]
		public static UserTagReferenceBuffer MDKCMNAEKLA(Entity entity)
		{
			return default(UserTagReferenceBuffer);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[CompilerGenerated]
	[RecRoom.DataLayer.StableTypeHash(1591066774816564574uL, 0u)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[ConfigGroup("Visual", 0)]
	[RecRoom.DataLayer.RRGuid("C36DDF08-CA52-4E33-8078-2F6E915D4FDA")]
	[TypeManager.ForcedStableTypeHash(1591066774816564574uL)]
	public struct StandardRenderableVisualData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		[Config(null, 0)]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public HCFAOKCHPKF color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		[RecRoom.DataLayer.Field(2)]
		[RecRoom.DataLayer.Default]
		[Config(null, 0)]
		public CGNLCNMEKCO material;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(3)]
		[Config(null, 0)]
		public float uvScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		[RecRoom.DataLayer.Field(4)]
		[Config(null, 0)]
		[RecRoom.DataLayer.Default]
		public float3 uvOffset;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
[RecRoom.DataLayer.RRGuid("6B598497-D68A-4CC9-9D41-09EF6B966499")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.Range(JPHGCKAMKCE.NONE, JPHGCKAMKCE.COUNT)]
public enum JPHGCKAMKCE
{
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	NONE = 0,
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	[Config("Default (can transform roots, children are static)", 0)]
	Default = 1,
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	[Config("Can Transform (chips like SetPosition can modify)", 0)]
	CircuitsCanTransform = 2,
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	[Config("Always Static (chips cannot modify transform)", 0)]
	AlwaysStatic = 3,
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	COUNT = 4,
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	MAX = 4
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
[RecRoom.DataLayer.Range(0, 4)]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.RRGuid("17517E1A-CF1A-48C9-B6A5-F9E42C1B9E96")]
public enum IMGLJFHOAIN
{
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	Box = 1,
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	Sphere = 2,
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	Capsule = 3,
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	Mesh = 4,
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	COUNT = 5,
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	MAX = 4
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.RRGuid("A13F5102-9259-42B9-B782-BB7CC33A0C4F")]
[RecRoom.DataLayer.Range(KCCFINBJMPF.NONE, KCCFINBJMPF.ALL)]
[Flags]
public enum KCCFINBJMPF
{
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	NONE = 0,
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	Object = 1,
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	Player = 2,
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	Projectile = 4,
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	Vehicle = 8,
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	ALL = 0xF
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
[RecRoom.DataLayer.RRGuid("F843A776-E042-43B7-8167-0C7A421062F8")]
[RecRoom.DataLayer.NetworkEnum(2, false)]
[RecRoom.DataLayer.Range(0, 127)]
public enum NMNNBIJOGOM : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	[Config("Dynamic (Environment)", 0)]
	[@Tooltip("Indicating it can be walked on and moved")]
	IsDynamicEnvironment = 0,
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	[Config("Dynamic", -1)]
	IsDynamic = 10,
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	[Config("Dynamic (Ignore Static Geometry)", 0)]
	IsDynamicIgnoreStaticGeometry = 11,
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	[Config("Dynamic (Ignore Other Dynamic)", 0)]
	IsDynamicIgnoreOtherDynamic = 12,
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	[Config("Dynamic (Ignore Players)", 0)]
	IsDynamicIgnorePlayers = 13,
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	[Config("Dynamic (Ignore Most)", 0)]
	IsDynamicIgnoreMost = 14,
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	[Config("Enemy Collision", 0)]
	IsEnemyCollision = 30,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	[Config("Enemy Projectile", 0)]
	IsEnemyProjectile = 31,
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	[Config("Vehicle Physics", 0)]
	IsVehicleCollision = 40,
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	[ConfigIgnore]
	STATIC = 100,
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	[ConfigIgnore]
	DECORATION = 101,
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	MAX = 127
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
[RecRoom.DataLayer.Range(IEHBBGFNHHB.Off, IEHBBGFNHHB.COUNT)]
[RecRoom.DataLayer.RRGuid("9ADF7A0D-D808-48A7-BFCB-3272FB5D8A52")]
[RecRoom.DataLayer.NetworkEnum(2, false)]
public enum IEHBBGFNHHB : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	Off = 0,
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	Children = 1,
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	Hull = 2,
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	COUNT = 3,
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	MAX = 2
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.RRGuid("3B156405-5769-4DB2-87EA-2B846AC4E584")]
[RecRoom.DataLayer.Range(0, 2)]
public enum NFCAIDCIJJF
{
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	Primitive = 1,
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	Spline = 2,
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	COUNT = 3,
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	MAX = 2
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
[RecRoom.DataLayer.NetworkEnum(2, false)]
[RecRoom.DataLayer.RRGuid("61EFE94A-235A-4281-B938-1A5BE32A18B1")]
[RecRoom.DataLayer.Range(FNONMPLFBAH.Pivot, FNONMPLFBAH.COUNT)]
public enum FNONMPLFBAH : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	Pivot = 0,
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	Bounds = 1,
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	COUNT = 2,
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	MAX = 1
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
[RecRoom.DataLayer.RRGuid("c0973732-e735-44cd-9727-a9a79bad01e3")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.Range(CIIOGCMNFDK.EnabledForRole, CIIOGCMNFDK.DisabledForRole)]
public enum CIIOGCMNFDK : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	EnabledForRole,
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	DisabledForRole,
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	Disabled
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.Range(IPEFDNGGMKI.NavMeshGenerator, IPEFDNGGMKI.NavMeshBlocker)]
[RecRoom.DataLayer.RRGuid("7E7D5AA1-2EC9-488B-8AB2-703F13BCB8CF")]
public enum IPEFDNGGMKI
{
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	NavMeshGenerator = 0,
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	NavMeshIgnored = 1,
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	NavMeshBlocker = 2,
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	MAX = 2
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.RRGuid("7B493897-FE06-4FC8-AB72-8B7BF5A313D3")]
[RecRoom.DataLayer.Range(CFMKEFNDENA.None, CFMKEFNDENA.All)]
[Flags]
public enum CFMKEFNDENA
{
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	All = 0x3FFF,
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	Default = 0x3FFF
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
[RecRoom.DataLayer.RRGuid("4427686F-E636-4F43-91F7-6BC74DEC584E")]
[RecRoom.DataLayer.Range(0, FNKCIIFFJPF.COUNT)]
[RecRoom.DataLayer.NetworkEnum(1, false)]
public enum FNKCIIFFJPF
{
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	SupportsRotation,
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	SupportsDeformation,
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	SupportsScaling,
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	SupportsMirroring,
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	SupportsCloning,
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	SupportsRecoloring,
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	CanDestroy,
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	CanSaveIntoInventions,
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	SupportsRespawn,
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	SupportsMerging,
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	SupportsSplitting,
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	SupportsKeys,
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	CanEditWithMakerPen,
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	DEPRECATED_IsGrabbable,
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public static class CLHKCCMCAAA
{
	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x77BFBC0", Offset = "0x77BEFC0", VA = "0x1877BFBC0")]
	public static void AJAPKMAIBCL(this CFMKEFNDENA CPMLONDPBFE, FNKCIIFFJPF GFOMFMOGDGF, bool ODCIGAJHLFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x77BFBF0", Offset = "0x77BEFF0", VA = "0x1877BFBF0")]
	public static bool GDJKKLMIBAA(this CFMKEFNDENA CPMLONDPBFE, FNKCIIFFJPF GFOMFMOGDGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0xD06710", Offset = "0xD05B10", VA = "0x180D06710")]
	public static CFMKEFNDENA BABPKOKHNJD(this FNKCIIFFJPF GFOMFMOGDGF)
	{
		return default(CFMKEFNDENA);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
[RecRoom.DataLayer.NetworkEnum(2, false)]
[RecRoom.DataLayer.RRGuid("E3C51303-32F0-4EF4-8A66-C814E323653D")]
[RecRoom.DataLayer.Range(JBEIFKBPHCL.NONE, JBEIFKBPHCL.COUNT)]
[Flags]
public enum JBEIFKBPHCL
{
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	NONE = 0,
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	IsFrozen = 1,
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	IsGrabbable = 2,
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	COUNT = 3,
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	ALL = 3,
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	DEFAULT = 0
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
[RecRoom.DataLayer.RRGuid("777AD204-3AC0-41CE-BDC0-894C5821B3B9")]
[RecRoom.DataLayer.Range(1000, 8000)]
[RecRoom.DataLayer.NetworkEnum(1, false)]
public enum PMHBKOEDEGH
{
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	[Config("Container", 0)]
	Container = 1000,
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	[Config("Container", 0)]
	LegacyShapeContainer = 1001,
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	[Config("Container", 0)]
	CreationShapeContainer = 1002,
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	[Config("Container", 0)]
	CostumePieceShapeContainer = 1003,
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	[Config("Empty", 0)]
	Empty = 4000,
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	[Config("Legacy Box", 0)]
	Shape_Primitive_LegacyBox = 2000,
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	[Config("Sphere", 0)]
	Shape_Primitive_Sphere = 2001,
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	[Config("Cylinder", 0)]
	Shape_Primitive_Cylinder = 2002,
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	[Config("Legacy Wedge", 0)]
	Shape_Primitive_LegacyWedge = 2003,
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	[Config("Legacy Pyramid", 0)]
	Shape_Primitive_LegacyPyramid = 2004,
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	[Config("Trigger Volume Box", 0)]
	Shape_Primitive_TriggerVolumeBox = 2005,
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	[Config("Box", 0)]
	Shape_Primitive_Box = 2006,
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	[Config("Rounded Box", 0)]
	Shape_Primitive_RoundedBox = 2007,
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	[Config("Wedge", 0)]
	Shape_Primitive_Wedge = 2008,
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	[Config("Pyramid", 0)]
	Shape_Primitive_Pyramid = 2009,
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	[Config("Half Sphere", 0)]
	Shape_Primitive_HalfSphere = 2010,
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	[Config("Cone", 0)]
	Shape_Primitive_Cone = 2011,
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	[Config("Pipe", 0)]
	Shape_Primitive_Pipe = 2012,
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	[Config("Donut", 0)]
	Shape_Primitive_Donut = 2013,
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	[Config("Half Pipe", 0)]
	Shape_Primitive_HalfPipe = 2014,
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	[Config("Diamond", 0)]
	Shape_Primitive_Diamond = 2015,
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	[Config("Mound", 0)]
	Shape_Primitive_Mound = 2016,
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	[Config("Cube (Simple)", 0)]
	Shape_Primitive_ADVANCED_Cube = 2017,
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	[Config("Sphere (Simple)", 0)]
	Shape_Primitive_ADVANCED_Sphere = 2018,
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	[Config("Cylinder (Simple)", 0)]
	Shape_Primitive_ADVANCED_Cylinder = 2019,
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	[Config("Cone (Simple)", 0)]
	Shape_Primitive_ADVANCED_Cone = 2020,
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	[Config("Pyramid (Simple)", 0)]
	Shape_Primitive_ADVANCED_Pyramid = 2021,
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	[Config("Octagon (Simple)", 0)]
	Shape_Primitive_ADVANCED_Octagon = 2022,
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	[Config("Triangle (Simple)", 0)]
	Shape_Primitive_ADVANCED_Triangle = 2023,
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	[Config("Hexagon (Simple)", 0)]
	Shape_Primitive_ADVANCED_Hexagon = 2024,
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	[Config("Quarter Pipe", 0)]
	Shape_Primitive_ADVANCED_QuarterPipe = 2025,
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	[Config("Pentagon (Simple)", 0)]
	Shape_Primitive_ADVANCED_Pentagon = 2026,
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	[Config("Dodecahedron", 0)]
	Shape_Primitive_ADVANCED_Dodecahedron = 2027,
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	[Config("Icosahedron", 0)]
	Shape_Primitive_ADVANCED_Trihedron = 2028,
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	[Config("Octahedron", 0)]
	Shape_Primitive_ADVANCED_Octahedron = 2029,
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	[Config("Quarter Cylinder", 0)]
	Shape_Primitive_RR_QuarterCylinder = 2030,
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	[Config("Pentagon", 0)]
	Shape_Primitive_RR_Pentagon = 2031,
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	[Config("Quarter Sphere", 0)]
	Shape_Primitive_RR_QuarterSphere = 2032,
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	[Config("Wedge (Simple)", 0)]
	Shape_Primitive_ADVANCED_Wedge = 2033,
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	[Config("Hexagon", 0)]
	Shape_Primitive_RR_Hexagon = 2034,
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	[Config("Octagon", 0)]
	Shape_Primitive_RR_Octagon = 2035,
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	[Config("Triangle", 0)]
	Shape_Primitive_RR_Triangle = 2036,
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	[Config("Spline", 0)]
	Shape_Spline = 3000,
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	[Config("Container Pivot", 0)]
	Other_ContainerPivot = 6000,
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	[Config("Spine Point", 0)]
	Other_SplinePoint = 6001,
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	[Config("Reference Point", 0)]
	Other_ReferencePoint = 6002,
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	[Config("UserTags", 0)]
	Other_UserTag = 6003,
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	[Config("Reference Group", 0)]
	Other_ReferenceGroup = 6004,
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	[Config("Interaction Filter", 0)]
	Other_InteractionFilterTags = 6005,
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	[ConfigIgnore]
	UNUSED2 = 5000,
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	[Config("Object", 0)]
	PrefabRootGameObject = 7000,
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	[Config("PrefabInternal", 0)]
	PrefabInternalGameObject = 7001,
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	[Config("Player", 0)]
	Player = 8000
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public static class HEOBGGIIBCM
{
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	[CompilerGenerated]
	private sealed class HNJLADCCPJN : IEnumerable<PMHBKOEDEGH>, IEnumerable, IEnumerator<PMHBKOEDEGH>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		private PMHBKOEDEGH <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		private IEnumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private PMHBKOEDEGH System.Collections.Generic.IEnumerator<RecRoom.DataLayer.ObjectPrefabType>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0xADD770", Offset = "0xADCB70", VA = "0x180ADD770", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(PMHBKOEDEGH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x77C1FD0", Offset = "0x77C13D0", VA = "0x1877C1FD0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x118EEB0", Offset = "0x118E2B0", VA = "0x18118EEB0")]
		[DebuggerHidden]
		public HNJLADCCPJN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x77C2020", Offset = "0x77C1420", VA = "0x1877C2020", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x77C1C60", Offset = "0x77C1060", VA = "0x1877C1C60", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x77C1C00", Offset = "0x77C1000", VA = "0x1877C1C00")]
		private void KNMHCFDKFOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x77C1F80", Offset = "0x77C1380", VA = "0x1877C1F80", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x77C1EE0", Offset = "0x77C12E0", VA = "0x1877C1EE0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<PMHBKOEDEGH> System.Collections.Generic.IEnumerable<RecRoom.DataLayer.ObjectPrefabType>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x77C1EE0", Offset = "0x77C12E0", VA = "0x1877C1EE0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[CompilerGenerated]
	private sealed class GPNOOICPJNL : IEnumerable<PMHBKOEDEGH>, IEnumerable, IEnumerator<PMHBKOEDEGH>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		private PMHBKOEDEGH <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		private PMHBKOEDEGH <last>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		private PMHBKOEDEGH <i>5__3;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private PMHBKOEDEGH System.Collections.Generic.IEnumerator<RecRoom.DataLayer.ObjectPrefabType>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0xADD770", Offset = "0xADCB70", VA = "0x180ADD770", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(PMHBKOEDEGH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x77C1A30", Offset = "0x77C0E30", VA = "0x1877C1A30", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x118EEB0", Offset = "0x118E2B0", VA = "0x18118EEB0")]
		[DebuggerHidden]
		public GPNOOICPJNL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x77C18E0", Offset = "0x77C0CE0", VA = "0x1877C18E0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x77C19E0", Offset = "0x77C0DE0", VA = "0x1877C19E0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x77C1940", Offset = "0x77C0D40", VA = "0x1877C1940", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<PMHBKOEDEGH> System.Collections.Generic.IEnumerable<RecRoom.DataLayer.ObjectPrefabType>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x77C1940", Offset = "0x77C0D40", VA = "0x1877C1940", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[CompilerGenerated]
	private sealed class MBAGLDLAMBI : IEnumerable<PMHBKOEDEGH>, IEnumerable, IEnumerator<PMHBKOEDEGH>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private PMHBKOEDEGH <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		private IEnumerator<PMHBKOEDEGH> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private PMHBKOEDEGH System.Collections.Generic.IEnumerator<RecRoom.DataLayer.ObjectPrefabType>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0xADD770", Offset = "0xADCB70", VA = "0x180ADD770", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(PMHBKOEDEGH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x77C32B0", Offset = "0x77C26B0", VA = "0x1877C32B0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x118EEB0", Offset = "0x118E2B0", VA = "0x18118EEB0")]
		[DebuggerHidden]
		public MBAGLDLAMBI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x77C3300", Offset = "0x77C2700", VA = "0x1877C3300", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x77C2F20", Offset = "0x77C2320", VA = "0x1877C2F20", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x77C2ED0", Offset = "0x77C22D0", VA = "0x1877C2ED0")]
		private void KNMHCFDKFOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x77C3260", Offset = "0x77C2660", VA = "0x1877C3260", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x77C31C0", Offset = "0x77C25C0", VA = "0x1877C31C0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<PMHBKOEDEGH> System.Collections.Generic.IEnumerable<RecRoom.DataLayer.ObjectPrefabType>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x77C31C0", Offset = "0x77C25C0", VA = "0x1877C31C0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x77C1BA0", Offset = "0x77C0FA0", VA = "0x1877C1BA0")]
	[IteratorStateMachine(typeof(HNJLADCCPJN))]
	public static IEnumerable<PMHBKOEDEGH> LHPJNMNIJKN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x77C1AE0", Offset = "0x77C0EE0", VA = "0x1877C1AE0")]
	[IteratorStateMachine(typeof(GPNOOICPJNL))]
	public static IEnumerable<PMHBKOEDEGH> BJPJGOHEEOD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x77C1B40", Offset = "0x77C0F40", VA = "0x1877C1B40")]
	[IteratorStateMachine(typeof(MBAGLDLAMBI))]
	public static IEnumerable<PMHBKOEDEGH> GDODFPNEDKG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public static class MCMJLINPMDK
{
	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x77C3390", Offset = "0x77C2790", VA = "0x1877C3390")]
	public static bool BHFALBAGFLA(this PMHBKOEDEGH MAIGGPEPIHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x77C33E0", Offset = "0x77C27E0", VA = "0x1877C33E0")]
	public static bool NEIPOPIBLNN(this RRObjectPrefabData LLIIABOMFHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x77C3410", Offset = "0x77C2810", VA = "0x1877C3410")]
	public static bool NEIPOPIBLNN(this PMHBKOEDEGH MAIGGPEPIHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x77C33C0", Offset = "0x77C27C0", VA = "0x1877C33C0")]
	public static LKJMPFNEKFB MMPLBOINGMB(this PMHBKOEDEGH EOKGBFAAECE)
	{
		return default(LKJMPFNEKFB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x77C3460", Offset = "0x77C2860", VA = "0x1877C3460")]
	internal static MFEPIPBDKJC OJAIJEANJEB(this LKJMPFNEKFB HOAMBGIHCIG)
	{
		return default(MFEPIPBDKJC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x77C3440", Offset = "0x77C2840", VA = "0x1877C3440")]
	internal static MFEPIPBDKJC OJAIJEANJEB(this PMHBKOEDEGH EOKGBFAAECE)
	{
		return default(MFEPIPBDKJC);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
internal enum MFEPIPBDKJC
{
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	Container = 1000,
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	Empty = 4000,
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	Primitive = 2000,
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	Spline = 3000,
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	Other = 6000,
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	UNUSED2 = 5000,
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	GameObject = 7000,
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	Player = 8000
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
[RecRoom.DataLayer.Range(0, 8)]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.RRGuid("A32413BC-21F3-4F7C-84B0-37724A854A67")]
public enum LKJMPFNEKFB
{
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	None,
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	Container,
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	Primitive,
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	Spline,
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	Empty,
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	UNUSED2,
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	Other,
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	GameObject,
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	Player
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public static class LDDLCKGHCBE
{
	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x77C2DD0", Offset = "0x77C21D0", VA = "0x1877C2DD0")]
	public static bool GDMCFJBKHAI(this LKJMPFNEKFB HOAMBGIHCIG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
[RecRoom.DataLayer.NetworkEnum(3, false)]
[RecRoom.DataLayer.RRGuid("7A0D34B5-FFE5-4C21-BB0C-CB3EBA34C797")]
[RecRoom.DataLayer.Range(0, GFLDGCHPDND.ALL)]
[Flags]
public enum GFLDGCHPDND : ushort
{
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	NONE = 0,
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	PhysicsEnabled = 1,
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	GravityEnabled = 2,
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	HasCustomMass = 4,
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	CollisionEvent = 0x40,
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	CanUse = 0x200,
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	CanClimb = 0x400,
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	CanWallRun = 0x800,
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	CanClamber = 0x1000,
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	CanTeleport = 0x2000,
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	SuppressCollision = 0x4000,
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	DEFAULT = 0x3800,
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	ALL = 0x3E47,
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	MAX = 0x3E47
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	[TypeManager.ForcedStableTypeHash(8060729269509364919uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.StableTypeHash(8060729269509364919uL, 0u)]
	[RecRoom.DataLayer.RRGuid("5D4503E7-6CC4-4938-8840-1B859C391878")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct PrimitiveShapeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public GCBGIGDHMFN shapeType;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
[RecRoom.DataLayer.Range(-1, 38)]
[RecRoom.DataLayer.RRGuid("517224CC-0A79-4FE9-B048-53C37955D823")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
public enum GCBGIGDHMFN
{
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	LegacyBox = 2,
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	RR_Sphere = 3,
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	RR_Cylinder = 4,
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	LEGACY_Wedge = 5,
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	LEGACY_Pyramid = 6,
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	LEGACY_TriggerVolumeBox = 7,
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	RR_Box = 8,
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	LEGACY_RoundedBox = 9,
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	RR_Wedge = 10,
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	RR_Pyramid = 11,
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	RR_HalfSphere = 12,
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	RR_Cone = 13,
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	RR_Pipe = 14,
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	RR_Donut = 15,
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	RR_HalfPipe = 16,
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	RR_Diamond = 17,
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	ADVANCED_Mound = 18,
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	ADVANCED_Cube = 19,
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	ADVANCED_Sphere = 20,
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	ADVANCED_Cylinder = 21,
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	ADVANCED_Cone = 22,
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	ADVANCED_Pyramid = 23,
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	ADVANCED_Octagon = 24,
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	ADVANCED_Triangle = 25,
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	ADVANCED_Hexagon = 26,
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	ADVANCED_QuarterPipe = 27,
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	ADVANCED_Pentagon = 28,
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	ADVANCED_Dodecahedron = 29,
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	ADVANCED_Trihedron = 30,
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	ADVANCED_Octahedron = 31,
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	RR_QuarterCylinder = 32,
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	RR_Pentagon = 33,
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	RR_QuarterSphere = 34,
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	ADVANCED_Wedge = 35,
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	RR_Hexagon = 36,
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	RR_Octagon = 37,
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	RR_Triangle = 38,
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	COUNT = 39,
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	MIN_VALUE = -1,
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	MAX_VALUE = 38
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.Range(MDOHGMNCHPB.None, MDOHGMNCHPB.COUNT)]
[RecRoom.DataLayer.RRGuid("3D27DF09-CAE2-4C3F-B808-03AD605F8E98")]
public enum MDOHGMNCHPB : byte
{
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	AnimationGroup = 1,
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	COUNT = 2,
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	MAX = 2
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
[Flags]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.Range(0, 7)]
[RecRoom.DataLayer.RRGuid("1829B7EA-C0EA-4E77-8EB2-BA23E995C860")]
public enum JIHOGGHEDMF
{
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	DynamicUVProjection = 1,
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	PreventInvertedCreation = 2,
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	NewBendLogic = 4,
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	All = 7,
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	MAX = 7
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
[RecRoom.DataLayer.RRGuid("CCB58F66-EF02-476E-820F-9D593E2C3DE5")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[Flags]
[RecRoom.DataLayer.Range(0, 7)]
public enum IINBDMIFCPI
{
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	IsRibbon = 1,
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	RoundedTubes = 2,
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	OldStyleCaps = 4,
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	All = 7,
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	MAX = 7
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
[Flags]
[RecRoom.DataLayer.RRGuid("72742F9B-D48E-4CED-B403-444201FFEE66")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.Range(0, 1)]
public enum PBCNMOHBOKP
{
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	Static = 0,
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	Dynamic = 1,
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	All = 1
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.RRGuid("C5BE1CDA-5EF5-4EBF-BC7E-3E3510C68A7F")]
[RecRoom.DataLayer.Range(-2, 2)]
public enum COHGCJIEJHF
{
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	Frozen = -2,
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	Low = -1,
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	Normal = 0,
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	High = 1,
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	Realtime = 2,
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	Default = 0,
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	MIN = -2,
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	MAX = 2
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
[RecRoom.DataLayer.RRGuid("D6AFAFED-8BAA-4499-9696-9CBB716EF514")]
[RecRoom.DataLayer.Range(int.MinValue, int.MaxValue)]
[RecRoom.DataLayer.NetworkEnum(1, false)]
public enum HCFAOKCHPKF
{
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	Red = 0,
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	Orange = 1,
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	Yellow = 2,
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	LightGreen = 3,
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	Blue = 4,
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	LightBlue = 5,
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	Teal = 6,
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	Green = 7,
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	Purple = 8,
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	LightPink = 9,
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	Pink = 10,
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	Brown = 11,
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	Tan = 12,
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	White = 13,
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	Grey = 14,
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	DarkGrey = 15,
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	DarkBrown = 16,
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	LightBrown = 17,
	[Cpp2IlInjected.Token(Token = "0x4000207")]
	LightGrey = 18,
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	Black = 19,
	[Cpp2IlInjected.Token(Token = "0x4000209")]
	DarkRed = 20,
	[Cpp2IlInjected.Token(Token = "0x400020A")]
	DarkOrange = 21,
	[Cpp2IlInjected.Token(Token = "0x400020B")]
	DarkYellow = 22,
	[Cpp2IlInjected.Token(Token = "0x400020C")]
	DarkGreen = 23,
	[Cpp2IlInjected.Token(Token = "0x400020D")]
	DarkTeal = 24,
	[Cpp2IlInjected.Token(Token = "0x400020E")]
	DarkBlue = 25,
	[Cpp2IlInjected.Token(Token = "0x400020F")]
	DarkPurple = 26,
	[Cpp2IlInjected.Token(Token = "0x4000210")]
	DarkPink = 27,
	[Cpp2IlInjected.Token(Token = "0x4000211")]
	LightRed = 28,
	[Cpp2IlInjected.Token(Token = "0x4000212")]
	LightOrange = 29,
	[Cpp2IlInjected.Token(Token = "0x4000213")]
	LightYellow = 30,
	[Cpp2IlInjected.Token(Token = "0x4000214")]
	Cyan = 31,
	[Cpp2IlInjected.Token(Token = "0x4000215")]
	LightPurple = 32,
	[Cpp2IlInjected.Token(Token = "0x4000216")]
	DarkTan = 33,
	[Cpp2IlInjected.Token(Token = "0x4000217")]
	NewColor1 = 34,
	[Cpp2IlInjected.Token(Token = "0x4000218")]
	NewColor2 = 35,
	[Cpp2IlInjected.Token(Token = "0x4000219")]
	NewColor3 = 36,
	[Cpp2IlInjected.Token(Token = "0x400021A")]
	NewColor4 = 37,
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	NewColor5 = 38,
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	NewColor6 = 39,
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	NewColor7 = 40,
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	NewColor8 = 41,
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	NewColor9 = 42,
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	NewColor10 = 43,
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	NewColor11 = 44,
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	NewColor12 = 45,
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	NewColor13 = 46,
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	NewColor14 = 47,
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	NewColor15 = 48,
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	NewColor16 = 49,
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	NewColor17 = 50,
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	NewColor18 = 51,
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	NewColor19 = 52,
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	NewColor20 = 53,
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	NewColor21 = 54,
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	NewColor22 = 55,
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	NewColor23 = 56,
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	NewColor24 = 57,
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	NewColor25 = 58,
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	NewColor26 = 59,
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	NewColor27 = 60,
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	Default = 0
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.RRGuid("C57BE511-BA1A-4D83-BA58-303F34F4DE74")]
[RecRoom.DataLayer.Range(-1, 31)]
public enum CGNLCNMEKCO
{
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	Cardboard = 0,
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	Neon = 1,
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	Brick = 2,
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	Carpet = 3,
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	Dirt = 4,
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	Grass = 5,
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	MetalReflective = 6,
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	Concrete = 7,
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	Linoleum = 8,
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	Plaster = 9,
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	WoodLogs = 10,
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	WoodBoards = 11,
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	WoodGrain = 12,
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	WoodFloor = 13,
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	Sand = 14,
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	GlossyPlastic = 15,
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	Cloth = 16,
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	RubberFloor = 17,
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	MetalFloorTread = 18,
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	PaintedBrick = 19,
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	Crashpad = 20,
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	PaintedWood = 21,
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	GripTape = 22,
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	GalvanizedMetal = 23,
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	ParticleBoard = 24,
	[Cpp2IlInjected.Token(Token = "0x400024E")]
	CheckeredFloor = 25,
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	SparklyVinyl = 26,
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	Gravel = 27,
	[Cpp2IlInjected.Token(Token = "0x4000251")]
	Rock = 28,
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	Placeholder29 = 29,
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	Placeholder30 = 30,
	[Cpp2IlInjected.Token(Token = "0x4000254")]
	Placeholder31 = 31,
	[Cpp2IlInjected.Token(Token = "0x4000255")]
	COUNT = 32,
	[Cpp2IlInjected.Token(Token = "0x4000256")]
	MIN = -1,
	[Cpp2IlInjected.Token(Token = "0x4000257")]
	MAX = 31,
	[Cpp2IlInjected.Token(Token = "0x4000258")]
	Default = 0
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
[RecRoom.DataLayer.RRGuid("112F004A-C92F-4055-99F9-D430EC13FE3C")]
[RecRoom.DataLayer.NetworkStruct(1, false)]
public struct ICHONNPKFBH : IComparable<ICHONNPKFBH>, IEquatable<ICHONNPKFBH>
{
	[Cpp2IlInjected.Token(Token = "0x4000259")]
	public static readonly ICHONNPKFBH OGOLFLHIENG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400025A")]
	[RecRoom.DataLayer.Field(1)]
	public uint GNFFHGGODDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400025B")]
	[RecRoom.DataLayer.Field(2)]
	public uint ANCDNGALCAK;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	private readonly uint GKLHPKIKABA
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x77C2320", Offset = "0x77C1720", VA = "0x1877C2320")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public readonly bool MLDGJAOBMHH
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x77C2310", Offset = "0x77C1710", VA = "0x1877C2310")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x77C2730", Offset = "0x77C1B30", VA = "0x1877C2730")]
	public ICHONNPKFBH(int GNFFHGGODDP, int GIDGIHDALDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x77C2730", Offset = "0x77C1B30", VA = "0x1877C2730")]
	public ICHONNPKFBH(uint GNFFHGGODDP, uint GIDGIHDALDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x77C2790", Offset = "0x77C1B90", VA = "0x1877C2790")]
	private ICHONNPKFBH(uint GNFFHGGODDP, uint GIDGIHDALDL, bool OALHBMECPGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x77C2210", Offset = "0x77C1610", VA = "0x1877C2210")]
	public ICHONNPKFBH FAGCLGKIOJA(int NPELPNMIGOA = 1)
	{
		return default(ICHONNPKFBH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x77C20E0", Offset = "0x77C14E0", VA = "0x1877C20E0")]
	public ICHONNPKFBH ENPEBEAJIIK(int NPELPNMIGOA = 1)
	{
		return default(ICHONNPKFBH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x77C2330", Offset = "0x77C1730", VA = "0x1877C2330")]
	public static ICHONNPKFBH OKAOAAGHACI(ICHONNPKFBH AJLPPHLPDOI, ICHONNPKFBH PODDNHBLFOD)
	{
		return default(ICHONNPKFBH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x77C20A0", Offset = "0x77C14A0", VA = "0x1877C20A0")]
	private static ulong DBCJJAFAFCL(ulong NJNDFFALKHH, ulong NLOOBJLDIMA)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x77C2080", Offset = "0x77C1480", VA = "0x1877C2080", Slot = "4")]
	public int CompareTo(ICHONNPKFBH JAPIEEBOJEA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x77C2170", Offset = "0x77C1570", VA = "0x1877C2170", Slot = "0")]
	public override bool Equals(object HAPOBHMBDHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x77C2650", Offset = "0x77C1A50", VA = "0x1877C2650", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x77C2150", Offset = "0x77C1550", VA = "0x1877C2150", Slot = "5")]
	public bool Equals(ICHONNPKFBH JAPIEEBOJEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x77C22A0", Offset = "0x77C16A0", VA = "0x1877C22A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x3402060", Offset = "0x3401460", VA = "0x183402060")]
	public static bool IGEKHAEJGKN(ICHONNPKFBH AJLPPHLPDOI, ICHONNPKFBH PODDNHBLFOD)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x77C2630", Offset = "0x77C1A30", VA = "0x1877C2630")]
	public static bool PIPJPONNKNK(ICHONNPKFBH AJLPPHLPDOI, ICHONNPKFBH PODDNHBLFOD)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x77C2280", Offset = "0x77C1680", VA = "0x1877C2280")]
	public static bool FOMOLBHAPHA(ICHONNPKFBH AJLPPHLPDOI, ICHONNPKFBH PODDNHBLFOD)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x77C22F0", Offset = "0x77C16F0", VA = "0x1877C22F0")]
	public static bool IGLPNNEEFPE(ICHONNPKFBH AJLPPHLPDOI, ICHONNPKFBH PODDNHBLFOD)
	{
		return default(bool);
	}
}
namespace RecRoom.DataLayer
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	[RecRoom.DataLayer.RRGuid("D3AB0F52-EA41-4891-9470-6E945A9D6583")]
	[RecRoom.DataLayer.NetworkStruct(1, false)]
	public struct NetworkGuid : IEquatable<NetworkGuid>, IComparable<NetworkGuid>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		[RecRoom.DataLayer.Field(1)]
		public int4 data;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public Guid Guid
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x110A3D0", Offset = "0x11097D0", VA = "0x18110A3D0")]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x110A3E0", Offset = "0x11097E0", VA = "0x18110A3E0")]
			set
			{
			}
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x110A3D0", Offset = "0x11097D0", VA = "0x18110A3D0")]
		public static Guid MDKCMNAEKLA(NetworkGuid IIBHEJCKGGH)
		{
			return default(Guid);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x110A3D0", Offset = "0x11097D0", VA = "0x18110A3D0")]
		public static NetworkGuid MDKCMNAEKLA(Guid IIBHEJCKGGH)
		{
			return default(NetworkGuid);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x77C35B0", Offset = "0x77C29B0", VA = "0x1877C35B0", Slot = "4")]
		public bool Equals(NetworkGuid JAPIEEBOJEA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x49B5940", Offset = "0x49B4D40", VA = "0x1849B5940", Slot = "5")]
		public int CompareTo(NetworkGuid JAPIEEBOJEA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x77C35E0", Offset = "0x77C29E0", VA = "0x1877C35E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
[RecRoom.DataLayer.NetworkStruct(1, false)]
[RecRoom.DataLayer.RRGuid("9F5F33BE-7C0A-4870-9CE0-BA79440E7F98")]
public struct GDMHDEGEKJE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400025D")]
	[RecRoom.DataLayer.Field(1)]
	public bool EJBJKNOIGIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400025E")]
	[RecRoom.DataLayer.Field(2)]
	public float3 JNBGFHJKDCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400025F")]
	[RecRoom.DataLayer.Field(3)]
	public float3 HKIBBKLCJDG;

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x77BD6A0", Offset = "0x77BCAA0", VA = "0x1877BD6A0")]
	public GDMHDEGEKJE(float IPECBHNLFPB, float HJCBHKAGEBL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
[RecRoom.DataLayer.RRGuid("35984D5B-ACBD-4389-A94B-840070A871E2")]
[RecRoom.DataLayer.NetworkStruct(1, false)]
public struct IJKALMPDIAP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000260")]
	[RecRoom.DataLayer.Field(1)]
	public float ONBNIKAEMHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000261")]
	[RecRoom.DataLayer.Field(2)]
	public int IKMNKKHJDPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000262")]
	[RecRoom.DataLayer.Field(3)]
	public IINBDMIFCPI CPMLONDPBFE;

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public bool FHCNLEOHCDN
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x77C2890", Offset = "0x77C1C90", VA = "0x1877C2890")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x77C2830", Offset = "0x77C1C30", VA = "0x1877C2830")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public bool ACBBAMDHNCB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x77C2870", Offset = "0x77C1C70", VA = "0x1877C2870")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x77C2850", Offset = "0x77C1C50", VA = "0x1877C2850")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public bool MDIAOHMEJDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x77C2880", Offset = "0x77C1C80", VA = "0x1877C2880")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x77C2810", Offset = "0x77C1C10", VA = "0x1877C2810")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public class COPDEMIPPCL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000263")]
	public IPABMCENOKG OKKFDMCBBIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000264")]
	public int OOKJHCHIHDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000265")]
	public bool JFNOKHADCEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D")]
	[Cpp2IlInjected.Token(Token = "0x4000266")]
	public bool ECFOMHFBBGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E")]
	[Cpp2IlInjected.Token(Token = "0x4000267")]
	public bool NLALGFBLIIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000268")]
	public Vector3 CPGAKMJDLGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000269")]
	public Quaternion DBFFJKGJHAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400026A")]
	public bool LCNHDKNHFPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400026B")]
	public Vector3 OIHEBFGIBMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400026C")]
	public Vector3 IAAGHFCPHGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400026D")]
	public Vector3 JAAIJMADACO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x400026E")]
	public bool AMKCIMFCCNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400026F")]
	protected ViewId PGALBDJLHNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x4000270")]
	protected NNAIHBJJNLB CFANPHCIHBG;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public ViewId GIGCCLEGOIF
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x77BFC10", Offset = "0x77BF010", VA = "0x1877BFC10")]
		get
		{
			return default(ViewId);
		}
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0xE57A50", Offset = "0xE56E50", VA = "0x180E57A50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x77BFCB0", Offset = "0x77BF0B0", VA = "0x1877BFCB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
	public COPDEMIPPCL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public struct JHEBDNOPPKP : IEquatable<JHEBDNOPPKP>, IComparable<JHEBDNOPPKP>
{
	[Cpp2IlInjected.Token(Token = "0x4000271")]
	public static readonly int EEPKEBLLOGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000272")]
	public RRObjectPrefabData FAHGNPJKBFP;

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x77C2BD0", Offset = "0x77C1FD0", VA = "0x1877C2BD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x77C2B30", Offset = "0x77C1F30", VA = "0x1877C2B30", Slot = "4")]
	public bool Equals(JHEBDNOPPKP JAPIEEBOJEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x77C2A30", Offset = "0x77C1E30", VA = "0x1877C2A30", Slot = "0")]
	public override bool Equals(object HAPOBHMBDHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x77C2BA0", Offset = "0x77C1FA0", VA = "0x1877C2BA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x77C2A00", Offset = "0x77C1E00", VA = "0x1877C2A00", Slot = "5")]
	public int CompareTo(JHEBDNOPPKP JAPIEEBOJEA)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public readonly struct KBACDNJLCPJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000273")]
	public readonly PGDAECHAJON IBLPNMGJGKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000274")]
	public readonly int ODGLLBKJPED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000275")]
	public readonly int FJCKGEJBFMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000276")]
	public readonly int NJHFGHFPEOH;

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x1DF4B20", Offset = "0x1DF3F20", VA = "0x181DF4B20")]
	public KBACDNJLCPJ(PGDAECHAJON KLEPNKCFGHC, int OIPIMHJOFDD, int JKFPEDCDOHF, int NMCDJOLHKNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x77C2C20", Offset = "0x77C2020", VA = "0x1877C2C20")]
	public static KBACDNJLCPJ DOBKKCEJLEK(byte FMHFJIMEAHI, int JKFPEDCDOHF, int NMCDJOLHKNF)
	{
		return default(KBACDNJLCPJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x77C2D00", Offset = "0x77C2100", VA = "0x1877C2D00")]
	public static KBACDNJLCPJ DOBKKCEJLEK(PGDAECHAJON KLEPNKCFGHC, int JKFPEDCDOHF, int NMCDJOLHKNF)
	{
		return default(KBACDNJLCPJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
internal class HEEEGDFCIMK : ContainerPropertyBag<EJLLLMMKFBD>
{
	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x77C1A80", Offset = "0x77C0E80", VA = "0x1877C1A80")]
	public HEEEGDFCIMK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
internal class GJHNBIGNBON : ContainerPropertyBag<RRObjectPrefabData>
{
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	private class EIMJODBGPIA : Property<RRObjectPrefabData, PMHBKOEDEGH>
	{
		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public override string EDDDAEGNADF
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x77C0E20", Offset = "0x77C0220", VA = "0x1877C0E20", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public override bool GKMGMAJNIBL
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x9DBC10", Offset = "0x9DB010", VA = "0x1809DBC10", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x77C0D30", Offset = "0x77C0130", VA = "0x1877C0D30")]
		public EIMJODBGPIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x20137E0", Offset = "0x2012BE0", VA = "0x1820137E0", Slot = "14")]
		public override PMHBKOEDEGH GetValue(RRObjectPrefabData PHDMEDCBLHH)
		{
			return default(PMHBKOEDEGH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x77BF110", Offset = "0x77BE510", VA = "0x1877BF110", Slot = "15")]
		public override void SetValue(RRObjectPrefabData PHDMEDCBLHH, PMHBKOEDEGH FIIKLGCIAGG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000091")]
	private class INIJKHCJPKL : Property<RRObjectPrefabData, Guid>
	{
		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public override string EDDDAEGNADF
		{
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x77C29C0", Offset = "0x77C1DC0", VA = "0x1877C29C0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public override bool GKMGMAJNIBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x9DBC10", Offset = "0x9DB010", VA = "0x1809DBC10", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x77C28D0", Offset = "0x77C1CD0", VA = "0x1877C28D0")]
		public INIJKHCJPKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x2C34A40", Offset = "0x2C33E40", VA = "0x182C34A40", Slot = "14")]
		public override Guid GetValue(RRObjectPrefabData PHDMEDCBLHH)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x77C28C0", Offset = "0x77C1CC0", VA = "0x1877C28C0", Slot = "15")]
		public override void SetValue(RRObjectPrefabData PHDMEDCBLHH, Guid FIIKLGCIAGG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x77C1150", Offset = "0x77C0550", VA = "0x1877C1150")]
	public GJHNBIGNBON()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
internal class OFHMOBFANHJ : ContainerPropertyBag<Guid>
{
	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x77C3600", Offset = "0x77C2A00", VA = "0x1877C3600")]
	public OFHMOBFANHJ()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x77C3660", Offset = "0x77C2A60", VA = "0x1877C3660")]
		[UnityEngine.Scripting.Preserve]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		public static void Initialize()
		{
		}
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
