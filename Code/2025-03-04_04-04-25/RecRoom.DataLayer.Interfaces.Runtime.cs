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
		[Cpp2IlInjected.Address(RVA = "0x97B910", Offset = "0x979F10", VA = "0x18097B910")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class IsUnmanagedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x97B910", Offset = "0x979F10", VA = "0x18097B910")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct HBAPKNHAKNO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private bool HLHJCKMKFLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private ViewId LIONHPBDDCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private int FDJGEFDKBBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private bool ICOHILMEHOG;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x74AF610", Offset = "0x74ADC10", VA = "0x1874AF610")]
	public HBAPKNHAKNO(ViewId LIONHPBDDCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x74AF630", Offset = "0x74ADC30", VA = "0x1874AF630")]
	public HBAPKNHAKNO(int FDJGEFDKBBO, bool ICOHILMEHOG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x74AF530", Offset = "0x74ADB30", VA = "0x1874AF530")]
	public ViewId BDMAOKAFOAH([Optional] ViewId DNEPFHNCEMG)
	{
		return default(ViewId);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class CBOFDJLIKME
{
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly Guid EFOONGAMLCO;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static readonly Guid PIDDBMHMPGH;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static readonly Guid BACDJIMOJHF;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public static readonly Guid DOBHMBHBHAJ;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly Guid NNAPBKMILPF;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public static readonly Dictionary<string, Guid> KNJKLEGBENK;

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static readonly RRObjectPrefabData MMDHLILLBOK;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly RRObjectPrefabData PMENOKGOCBL;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly RRObjectPrefabData IAFECMPECBJ;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x74AE090", Offset = "0x74AC690", VA = "0x1874AE090")]
	public static Guid NAOFBKMNMPD(string OMOOEGOLALI)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x74AE000", Offset = "0x74AC600", VA = "0x1874AE000")]
	public static RRObjectPrefabData BFEJEENKGGC(LBJDMFOKJAE BMIPLDLMPCD)
	{
		return default(RRObjectPrefabData);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x74ADFB0", Offset = "0x74AC5B0", VA = "0x1874ADFB0")]
	public static RRObjectPrefabData AKNFMMMJMIG(LBJDMFOKJAE BMIPLDLMPCD)
	{
		return default(RRObjectPrefabData);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x74AE070", Offset = "0x74AC670", VA = "0x1874AE070")]
	public static RRObjectPrefabData GBHDCOFJPBG(Guid JINNLDEOCMO)
	{
		return default(RRObjectPrefabData);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[DefaultMember("Item")]
public class DLFJAADKMKH : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly Dictionary<int, object> GIDGOODJFLJ;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public Dictionary<int, object> FENODPMPHEB
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x950410", Offset = "0x94EA10", VA = "0x180950410")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x74AEAD0", Offset = "0x74AD0D0", VA = "0x1874AEAD0")]
	public DLFJAADKMKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x958BA0", Offset = "0x9571A0", VA = "0x180958BA0")]
	public DLFJAADKMKH(Dictionary<int, object> GIDGOODJFLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x74AEA10", Offset = "0x74AD010", VA = "0x1874AEA10")]
	public bool GBPPMFIDIFK(IGNCGNKDNME LKMGECEEGEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3252B20", Offset = "0x3251120", VA = "0x183252B20")]
	public void OKCBENGKJJG<T>(IGNCGNKDNME LKMGECEEGEE, T KBGCCIOIGBD, [Optional] T IDJBNLNBJCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x3252960", Offset = "0x3250F60", VA = "0x183252960")]
	public void ECFLGDLFBIO<T>(IGNCGNKDNME LKMGECEEGEE, T KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x74AEA70", Offset = "0x74AD070", VA = "0x1874AEA70")]
	public void OCDDHDAHAOD(IGNCGNKDNME LKMGECEEGEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x74AE9A0", Offset = "0x74ACFA0", VA = "0x1874AE9A0", Slot = "4")]
	public object Clone()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum IGNCGNKDNME : byte
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
	Source
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct GPFGMAPIEFI<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly IGNCGNKDNME LKMGECEEGEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public readonly T IDJBNLNBJCD;

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x45BFEB0", Offset = "0x45BE4B0", VA = "0x1845BFEB0")]
	public GPFGMAPIEFI(IGNCGNKDNME LKMGECEEGEE, T IDJBNLNBJCD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x45BFE00", Offset = "0x45BE400", VA = "0x1845BFE00")]
	public static GPFGMAPIEFI<T> HEGJABMHLEC(IGNCGNKDNME LKMGECEEGEE)
	{
		return default(GPFGMAPIEFI<T>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x45BFCD0", Offset = "0x45BE2D0", VA = "0x1845BFCD0")]
	public static GPFGMAPIEFI<T> HEGJABMHLEC((IGNCGNKDNME key, T value) AMGCKABOOPF)
	{
		return default(GPFGMAPIEFI<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(BDGCMAPCADO))]
public struct DPGADNNJFDK : IEnumerable<object>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private class BDGCMAPCADO : Dictionary<string, object>
	{
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private Dictionary<int, object> FJJOKDBOKAE;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool LCHDPNFEMLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x1511EB0", Offset = "0x15104B0", VA = "0x181511EB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int AGHLCEGEAOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x74AEF40", Offset = "0x74AD540", VA = "0x1874AEF40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x74AEEC0", Offset = "0x74AD4C0", VA = "0x1874AEEC0")]
	public static DPGADNNJFDK OILMBKHFGKP()
	{
		return default(DPGADNNJFDK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0xBD5420", Offset = "0xBD3A20", VA = "0x180BD5420")]
	public DPGADNNJFDK([Optional] Dictionary<int, object> FJJOKDBOKAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3255A30", Offset = "0x3254030", VA = "0x183255A30")]
	public void HBHDBABAKDP<T>(GPFGMAPIEFI<T> LKMGECEEGEE, T? KBGCCIOIGBD) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x32557B0", Offset = "0x3253DB0", VA = "0x1832557B0")]
	public void HBHDBABAKDP<T>((GPFGMAPIEFI<T> key, T value) IJMIPGLMMKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x32557D0", Offset = "0x3253DD0", VA = "0x1832557D0")]
	public void HBHDBABAKDP<T>(GPFGMAPIEFI<T> LKMGECEEGEE, T KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x74AECA0", Offset = "0x74AD2A0", VA = "0x1874AECA0")]
	public void JLBOABPGIKD(DPGADNNJFDK MOEBIEOOLFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x74AEB60", Offset = "0x74AD160", VA = "0x1874AEB60")]
	private void CIDIOEOELJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x32550F0", Offset = "0x32536F0", VA = "0x1832550F0")]
	public bool GMJNAAAPBAP<T>(GPFGMAPIEFI<T> LKMGECEEGEE, [Out] T KBGCCIOIGBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3254ED0", Offset = "0x32534D0", VA = "0x183254ED0")]
	public bool GMJNAAAPBAP<T>(IGNCGNKDNME LKMGECEEGEE, [Out] T KBGCCIOIGBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x3254D40", Offset = "0x3253340", VA = "0x183254D40")]
	public T DKANEHLLIGL<T>(GPFGMAPIEFI<T> LKMGECEEGEE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x3254EB0", Offset = "0x32534B0", VA = "0x183254EB0")]
	public bool GBPPMFIDIFK<T>(GPFGMAPIEFI<T> LKMGECEEGEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x74AEBE0", Offset = "0x74AD1E0", VA = "0x1874AEBE0")]
	public bool GBPPMFIDIFK(IGNCGNKDNME LKMGECEEGEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x32561C0", Offset = "0x32547C0", VA = "0x1832561C0")]
	public void OCDDHDAHAOD<T>(GPFGMAPIEFI<T> LKMGECEEGEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x74AEE70", Offset = "0x74AD470", VA = "0x1874AEE70")]
	public void OCDDHDAHAOD(IGNCGNKDNME LKMGECEEGEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0xBD5490", Offset = "0xBD3A90", VA = "0x180BD5490")]
	public Dictionary<int, object> KAAACLLHBNK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x74AEC40", Offset = "0x74AD240", VA = "0x1874AEC40", Slot = "4")]
	public IEnumerator<object> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x74AEF90", Offset = "0x74AD590", VA = "0x1874AEF90", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public enum JPJKNIHLIML
{
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	PrefabComponents,
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	LocalObjectComponents,
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	NetworkedObjectComponents,
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	PolicyComponents,
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	ConnectableComponents,
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	RbexComponents,
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	TransformPoseComponents,
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	UniformTransformComponents,
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	DeformableSizeComponents,
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	ShapeComponents,
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	PrimitiveComponents,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	SplineComponents,
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	SplinePointComponents,
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	ContainerComponents,
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	ContainerLikeComponents,
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	ReplicatorComponents,
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	ContainerPivotComponents,
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	ShapeContainerComponents,
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	CostumePieceComponents,
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	PreventSerializationComponent,
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	DontPropagatePhysicsComponent,
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	DontPropagateOwnershipComponent,
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	LegacyGameObjectComponents,
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	GameObjectLegacyGizmoComponents,
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	GameObjectCostumeDummyPropComponents,
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	PlayerComponents,
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	PlayerRbexComponents,
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	PlayerTransformComponents,
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	RequireEmbodiedComponents,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	EntityPrefabRootComponents,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	EntityPrefabPartComponents,
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	SocketComponents,
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	VisibleInHierarchyComponents,
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	ToolCleanupComponents,
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	TagComponents,
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	InteractionFilterTagComponents,
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	AutoEmbodimentComponents,
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	ReferenceGroupComponents,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	UserTagStorageComponents,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	ReplicatedObjectComponents,
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	InteractionFilteringSettingsComponents,
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	InventionTrackingComponents,
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	ObjectBoardComponents,
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	NetworkTransformComponents,
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	AlwaysEmbodiedScopeComponents,
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	LoadInstanceLifetimeComponents,
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	PhysicsModelComponents,
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	StudioPropObjectComponents,
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	AnimationControllerComponents
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface DBGGEFBGBDL
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public enum IBDIFFIBLJB
	{
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		Entity,
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		Prefab
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	LocalId OGFOOBGNEML
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	RRObjectPrefabData FHMIBMFBHIA
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LBKNFOCIMNA(params string[] KEJFIGAFLGB);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GMMKFIOCOMF(JPJKNIHLIML HGLIBCCGHFA, IBDIFFIBLJB OALDHMLLKME = IBDIFFIBLJB.Entity);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JJLBGEAKAHC(Type BMIPLDLMPCD, ReadOnlySpan<byte> GIDGOODJFLJ, int BAKLLMJBFJF, IBDIFFIBLJB OALDHMLLKME = IBDIFFIBLJB.Entity);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void AGEBBFOHEIP(Type BMIPLDLMPCD, IBDIFFIBLJB OALDHMLLKME = IBDIFFIBLJB.Entity);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OGNNKFLAPDK(JPJKNIHLIML HGLIBCCGHFA, IBDIFFIBLJB OALDHMLLKME = IBDIFFIBLJB.Entity);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool HLNJDKFPHKA(JPJKNIHLIML HGLIBCCGHFA);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void EECLOOLLGJI(bool HJFMFDLPPFM, IBDIFFIBLJB OALDHMLLKME = IBDIFFIBLJB.Entity);

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void PAIANDKJHHD();
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class PECCCDFIKPA
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x74B12A0", Offset = "0x74AF8A0", VA = "0x1874B12A0")]
	public static bool CFIEIFDNOGG(this DBGGEFBGBDL BPPCEJGCMKA, JPJKNIHLIML CMHPCDCAOKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x74B1500", Offset = "0x74AFB00", VA = "0x1874B1500")]
	public static void KBDDDGNHACK(this DBGGEFBGBDL BPPCEJGCMKA, DBGGEFBGBDL.IBDIFFIBLJB OALDHMLLKME = DBGGEFBGBDL.IBDIFFIBLJB.Entity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x74B14A0", Offset = "0x74AFAA0", VA = "0x1874B14A0")]
	public static void GMGEEJHBIGD(this DBGGEFBGBDL BPPCEJGCMKA, DBGGEFBGBDL.IBDIFFIBLJB OALDHMLLKME = DBGGEFBGBDL.IBDIFFIBLJB.Entity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3601A90", Offset = "0x3600090", VA = "0x183601A90")]
	public static void ELPBAFAFOGN<T>(this DBGGEFBGBDL BPPCEJGCMKA, DBGGEFBGBDL.IBDIFFIBLJB OALDHMLLKME = DBGGEFBGBDL.IBDIFFIBLJB.Entity) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x34166E0", Offset = "0x3414CE0", VA = "0x1834166E0")]
	public static void BJCMDOBMOHC<T>(this DBGGEFBGBDL BPPCEJGCMKA, DBGGEFBGBDL.IBDIFFIBLJB OALDHMLLKME = DBGGEFBGBDL.IBDIFFIBLJB.Entity) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x36037A0", Offset = "0x3601DA0", VA = "0x1836037A0")]
	public static void JKMEAOEPPFH<T>(this DBGGEFBGBDL BPPCEJGCMKA, bool OMDICMNFCPD, DBGGEFBGBDL.IBDIFFIBLJB OALDHMLLKME = DBGGEFBGBDL.IBDIFFIBLJB.Entity) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3601AD0", Offset = "0x36000D0", VA = "0x183601AD0")]
	public static void JJLBGEAKAHC<T>(this DBGGEFBGBDL BPPCEJGCMKA, T KBGCCIOIGBD, DBGGEFBGBDL.IBDIFFIBLJB OALDHMLLKME = DBGGEFBGBDL.IBDIFFIBLJB.Entity) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x36018B0", Offset = "0x35FFEB0", VA = "0x1836018B0")]
	public static void AGEBBFOHEIP<T>(this DBGGEFBGBDL BPPCEJGCMKA, DBGGEFBGBDL.IBDIFFIBLJB OALDHMLLKME = DBGGEFBGBDL.IBDIFFIBLJB.Entity) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3603810", Offset = "0x3601E10", VA = "0x183603810")]
	public static void MEGMGJDMJNJ<T>(this DBGGEFBGBDL BPPCEJGCMKA, LocalId KPOCLGHHOEP, DBGGEFBGBDL.IBDIFFIBLJB OALDHMLLKME = DBGGEFBGBDL.IBDIFFIBLJB.Entity) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3601BB0", Offset = "0x36001B0", VA = "0x183601BB0")]
	private static void JJLBGEAKAHC<T>(this DBGGEFBGBDL BPPCEJGCMKA, Type BMIPLDLMPCD, T KBGCCIOIGBD, DBGGEFBGBDL.IBDIFFIBLJB OALDHMLLKME = DBGGEFBGBDL.IBDIFFIBLJB.Entity) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface NHANIEANCKA
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	Entity MOKMABEPCCP
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface BNNAEHMNCPN
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void Bake(DBGGEFBGBDL BPPCEJGCMKA);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface KBNMBGAIHKJ
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LGIKFMCIDCL(NOONNECLOAO KHELFHBHLMG);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GKNDOGEGHBE(NOONNECLOAO KHELFHBHLMG);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface ANNFJJMJFBC
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	ViewId NDHLJNNLLAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface PDOOMAJLGEG : ANNFJJMJFBC, NDDIFFHHJMM
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HPHCPPKCEKM(ViewId ILODFGNHKCN, ViewId CEJKAPGPBEB, Dictionary<int, object> EIEEOCBNIGD, NOONNECLOAO ADMEOFCKKPF);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface IKFPPMNFKBP : ANNFJJMJFBC
{
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HPHCPPKCEKM(GFBOHEINDFO LDIAONMHHPK, Vector3 IJNCCGADGJC, Quaternion BALNGIJIBOK, Vector3 IGOKMENAGDH, bool GDJGDCNHJBL);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HHJDALAKBFI(Vector3 IJNCCGADGJC, Quaternion BALNGIJIBOK, Vector3 IGOKMENAGDH);

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PDMHANMAJFJ(ViewId LDIAONMHHPK);

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void INCABJFHDGH(bool AHLNJODMFLD);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IDMOJGCLKBO(bool PHLNFMBEHHP);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface NDDIFFHHJMM
{
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IMEFJFIMJMN();
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface EBCNHPBOGML
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NativeArray<Guid> ONFPLKNJHOJ(World ENFBJMHAMNL, NativeArray<Entity> AKCBEPDCJFL, Allocator LEILKJFLDFN);
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[TypeManager.ForcedStableTypeHash(11505792609904010668uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.StableTypeHash(11505792609904010668uL, 0u)]
	[RecRoom.DataLayer.RRGuid("B7CEB5B9-453F-4712-B833-27D907AA13E2")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct AuthoredLocalPoseData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		[RecRoom.DataLayer.Default("new quaternion(new float4(float.NaN))")]
		[RecRoom.DataLayer.Field(1)]
		public quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		[RecRoom.DataLayer.Default("new float3(float.NaN)")]
		[RecRoom.DataLayer.Field(2)]
		public float3 localPosition;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public readonly bool IsValid
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x74ADC50", Offset = "0x74AC250", VA = "0x1874ADC50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x4B9E380", Offset = "0x4B9C980", VA = "0x184B9E380")]
		public AuthoredLocalPoseData(quaternion localRotation, float3 localPosition)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x74ADCB0", Offset = "0x74AC2B0", VA = "0x1874ADCB0")]
		public static RigidTransform HEGJABMHLEC(AuthoredLocalPoseData poseData)
		{
			return default(RigidTransform);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x74ADCB0", Offset = "0x74AC2B0", VA = "0x1874ADCB0")]
		public static AuthoredLocalPoseData HEGJABMHLEC(RigidTransform pose)
		{
			return default(AuthoredLocalPoseData);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class ALMDEHIFOGO
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x74ADA00", Offset = "0x74AC000", VA = "0x1874ADA00")]
	public static AuthoredLocalPoseData LCOBMBCNLLD([In] this RigidTransform KBGCCIOIGBD)
	{
		return default(AuthoredLocalPoseData);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0xB13490", Offset = "0xB11A90", VA = "0x180B13490")]
	public static RigidTransform MLIELBJFOAA(this AuthoredLocalPoseData KBGCCIOIGBD)
	{
		return default(RigidTransform);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x74ADA30", Offset = "0x74AC030", VA = "0x1874ADA30")]
	public static RigidTransform MGNONINDAIK([In] this AuthoredLocalPoseData KBGCCIOIGBD)
	{
		return default(RigidTransform);
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("C26C4B4E-5EF3-4F81-87C8-FED8EAD37242")]
	[RecRoom.DataLayer.StableTypeHash(9088562008033959482uL, 0u)]
	[TypeManager.ForcedStableTypeHash(9088562008033959482uL)]
	public struct AuthoredLocalUniformScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default(1f)]
		public float localUniformScale;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public readonly bool IsValid
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x74ADCD0", Offset = "0x74AC2D0", VA = "0x1874ADCD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x2774080", Offset = "0x2772680", VA = "0x182774080")]
		public AuthoredLocalUniformScaleData(float localUniformScale)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("7B1B8635-3FA9-4ADC-922B-3C25CE0C7E7D")]
	[RecRoom.DataLayer.StableTypeHash(10137300772124140051uL, 0u)]
	[TypeManager.ForcedStableTypeHash(10137300772124140051uL)]
	public struct AuthoredParentData : IComponentData, NHANIEANCKA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public Entity parent;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xBD5490", Offset = "0xBD3A90", VA = "0x180BD5490", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x14A3DE0", Offset = "0x14A23E0", VA = "0x1814A3DE0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x14A3DE0", Offset = "0x14A23E0", VA = "0x1814A3DE0")]
		public AuthoredParentData(Entity parent)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xB13490", Offset = "0xB11A90", VA = "0x180B13490")]
		public static AuthoredParentData HEGJABMHLEC(Entity entity)
		{
			return default(AuthoredParentData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x74ADD30", Offset = "0x74AC330", VA = "0x1874ADD30", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct PPADNEEHGAE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct EGLHHMCPEJE : IComponentData
{
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[RecRoom.DataLayer.StableTypeHash(8594223769175916906uL, 0u)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("B9A63EF5-66A5-463C-8385-A7DC7CE137C3")]
	[TypeManager.ForcedStableTypeHash(8594223769175916906uL)]
	[CompilerGenerated]
	public struct ObjectBoardNodeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public NetworkGuid nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(2)]
		public NetworkGuid graphId;
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[RecRoom.DataLayer.RRGuid("B26EF01D-F674-4506-80B7-5345391A097E")]
	[TypeManager.ForcedStableTypeHash(5933855128949143734uL)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[CompilerGenerated]
	public struct ReplicatedObjectActiveStatusData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		[RecRoom.DataLayer.Default(true)]
		[RecRoom.DataLayer.Field(1)]
		public bool active;
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[TypeManager.ForcedStableTypeHash(16338184133650423946uL)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("E9BA10A4-4EE9-431D-BD7F-FF2008ABFA03")]
	[CompilerGenerated]
	public struct ReplicatedObjectOwnedByPlayerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default(-1)]
		public int actorId;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct DDGIAHEPNAA : IComponentData
{
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[TypeManager.ForcedStableTypeHash(16223816226138460552uL)]
	[RecRoom.DataLayer.RRGuid("46C500A2-9991-4987-B1AA-66E5C3D8E371")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[CompilerGenerated]
	public struct ReplicatedObjectTag : IComponentData
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(17912083982325865811uL)]
	[RecRoom.DataLayer.RRGuid("5ED157AA-488F-453A-A986-594595B8D777")]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	public struct ReplicatorData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public Entity Target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		[RecRoom.DataLayer.Default(false)]
		[RecRoom.DataLayer.Field(2)]
		public bool NeedsCircuitUpdate;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000023")]
public struct HCLHNFGIMDI : IComponentData
{
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("AEA4D222-29BA-462F-9C0A-AA2063671C68")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(8691279933813304851uL)]
	public struct ReplicatorMaxObjectCountData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default(10)]
		public int count;
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	[RecRoom.DataLayer.RRGuid("400790C1-E8D9-4779-A549-3780DAEC2FDF")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(16379995002884076574uL)]
	public struct ReplicatorPreallocatedObjectCountData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default(0)]
		public int preallocatedCopies;
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	[RecRoom.DataLayer.RRGuid("6A82044A-E392-4DCD-B4BC-A120E58334EA")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.StableTypeHash(8536678595025273356uL, 0u)]
	[TypeManager.ForcedStableTypeHash(8536678595025273356uL)]
	public struct EntityPrefabPartData : IComponentData, IComparable<EntityPrefabPartData>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public Entity prefabRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(2)]
		public uint partId;

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x74AF0D0", Offset = "0x74AD6D0", VA = "0x1874AF0D0", Slot = "4")]
		public readonly int CompareTo(EntityPrefabPartData other)
		{
			return default(int);
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public struct EntityPrefabPartId : IEquatable<EntityPrefabPartId>, IComparable<EntityPrefabPartId>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		[SerializeField]
		private uint id;

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x10AD620", Offset = "0x10ABC20", VA = "0x1810AD620")]
		internal EntityPrefabPartId(uint KGHCKLKGJKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x99D850", Offset = "0x99BE50", VA = "0x18099D850")]
		internal uint OCPPHPOJBML()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x1EF9B00", Offset = "0x1EF8100", VA = "0x181EF9B00", Slot = "4")]
		public bool Equals(EntityPrefabPartId OKCHLIEAIJP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x74AF120", Offset = "0x74AD720", VA = "0x1874AF120", Slot = "0")]
		public override bool Equals(object GMFKPONAANG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x110C3A0", Offset = "0x110A9A0", VA = "0x18110C3A0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x1EF9A60", Offset = "0x1EF8060", VA = "0x181EF9A60", Slot = "5")]
		public int CompareTo(EntityPrefabPartId OKCHLIEAIJP)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public struct JECPHNGLMDH : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public Entity OGNNAFLGGHA;
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	[RecRoom.DataLayer.RRGuid("F74D558B-BDCC-48C8-A8EF-1F7559E5EAA0")]
	[ConfigGroup("Physics", 0)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(2330616907306882483uL)]
	public struct PhysicsModelCollisionModeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		[RecRoom.DataLayer.Field(1)]
		[Config(null, 0)]
		[RecRoom.DataLayer.Default(BBKFGBALMBJ.Children)]
		public BBKFGBALMBJ collisionMode;
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[InternalBufferCapacity(0)]
	[TypeManager.ForcedStableTypeHash(14800424556151816553uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.RRGuid("55EAB643-95BB-4C3A-832C-798EBCD95AD5")]
	public struct ContainerNameBuffer : IBufferElementData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public byte data;
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("89708D57-D027-494A-A159-221E6C643B6B")]
	[RecRoom.DataLayer.StableTypeHash(13657791279235747653uL, 0u)]
	[ConfigGroup("Container", 0)]
	[TypeManager.ForcedStableTypeHash(13657791279235747653uL)]
	[CompilerGenerated]
	public struct ContainerNameData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		[Config(null, 0)]
		public FixedString64Bytes name;
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[ConfigGroup("Physics", 0)]
	[RecRoom.DataLayer.RRGuid("CA023286-E0F6-4DA9-A346-94E86B93977C")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(13904209480152351845uL)]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	public struct PhysicsModelGrabbableModeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		[Config(null, 0)]
		public AEONEPFEMAI grabbableMode;
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[RecRoom.DataLayer.RRGuid("84485C1B-18ED-4D4A-86A4-34CEED482615")]
	[RecRoom.DataLayer.StableTypeHash(16485879999901987510uL, 0u)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[CompilerGenerated]
	[ConfigGroup("Container", 0)]
	[TypeManager.ForcedStableTypeHash(16485879999901987510uL)]
	public struct NavMeshGenerationData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		[Config(null, 0)]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default(PGBKBOPFMNI.NavMeshGenerator)]
		public PGBKBOPFMNI mode;
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[TypeManager.ForcedStableTypeHash(1954118413118190521uL)]
	[CompilerGenerated]
	[ConfigGroup("Physics", 0)]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	[RecRoom.DataLayer.RRGuid("C5BCE8B3-6E69-41D4-921A-BE2E3E0A4DAB")]
	public struct PhysicsModelCollisionLayerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		[RecRoom.DataLayer.Default(LAKFMIPGDFM.IsDynamicEnvironment)]
		[Config(null, 0)]
		[RecRoom.DataLayer.Field(1)]
		public LAKFMIPGDFM collisionLayer;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public static class CAPLJOGMHPB
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public enum CBNLDLJHKPJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		Dynamic,
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		Static,
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		Enemy,
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		Vehicle
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public enum AFPACLBEHJJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		Environmental,
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		IgnoreStaticGeometry,
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		IgnoreOtherDynamic,
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		IgnorePlayers,
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		IgnoreMost,
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		Projectile
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x74ADE20", Offset = "0x74AC420", VA = "0x1874ADE20")]
	public static (CBNLDLJHKPJ, AFPACLBEHJJ) FFABPPDOHIG(this LAKFMIPGDFM GKKHJGBAALN)
	{
		return default((CBNLDLJHKPJ, AFPACLBEHJJ));
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[ConfigGroup("Physics", 0)]
	[RecRoom.DataLayer.RRGuid("F63AA9EA-6191-4DE9-BB18-1F049F432124")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(16455981537837065632uL)]
	[RecRoom.DataLayer.NetworkComponent(3, false)]
	public struct PhysicsModelFlagsData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		[RecRoom.DataLayer.Default(KMKOJLIANAG.DEFAULT)]
		[Config(null, 0)]
		[RecRoom.DataLayer.Field(1)]
		public KMKOJLIANAG flags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[RecRoom.DataLayer.StableTypeHash(1094837642118998916uL, 0u)]
	[TypeManager.ForcedStableTypeHash(1094837642118998916uL)]
	[ConfigGroup("Physics", 0)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("B6D08147-6AEA-4270-BDC4-8CF68662318D")]
	[CompilerGenerated]
	public struct PhysicsModelMassOverrideData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		[RecRoom.DataLayer.Default(0f)]
		[Config(null, 0)]
		[RecRoom.DataLayer.Field(1)]
		public float mass;
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[TypeManager.ForcedStableTypeHash(1537567323754185605uL)]
	[RecRoom.DataLayer.StableTypeHash(1537567323754185605uL, 0u)]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("D732BC3D-4F8D-4FDE-BDB2-88C095D973C2")]
	public struct CostumePieceParentCostumeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public Entity parentCostume;
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	[RecRoom.DataLayer.StableTypeHash(5115014870530256079uL, 0u)]
	[RecRoom.DataLayer.RRGuid("36A2D516-8596-4794-BEAE-40BECA68C798")]
	[TypeManager.ForcedStableTypeHash(5115014870530256079uL)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct CostumePieceSlotIndexData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public int slotIndex;
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[TypeManager.ForcedStableTypeHash(10518841812724430444uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.RRGuid("17799917-98EE-4D9A-A8D1-B0BE5F7316E3")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct InventionIdData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		[RecRoom.DataLayer.Default(0L)]
		[RecRoom.DataLayer.Field(1)]
		public long inventionId;

		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public const long INVALID_INVENTION_ID = 0L;

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0xB13490", Offset = "0xB11A90", VA = "0x180B13490")]
		public static InventionIdData HEGJABMHLEC(long value)
		{
			return default(InventionIdData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x74AFE20", Offset = "0x74AE420", VA = "0x1874AFE20")]
		public readonly bool DJEPOOALMJD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x722FA50", Offset = "0x722E050", VA = "0x18722FA50")]
		public static bool DJEPOOALMJD(long inventionId)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	[CompilerGenerated]
	[RecRoom.DataLayer.TombstonedFields(new int[] { 1 })]
	[TypeManager.ForcedStableTypeHash(14338988155392421373uL)]
	[RecRoom.DataLayer.RRGuid("629F0A56-C478-4353-BBDA-8A8BB5FEE478")]
	public struct InventionInstanceIdData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(2)]
		public NetworkGuid instanceId;

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x1048800", Offset = "0x1046E00", VA = "0x181048800")]
		public static InventionInstanceIdData HEGJABMHLEC(Guid value)
		{
			return default(InventionInstanceIdData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[RuntimeOnly]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("A3B27452-BD6C-43B2-BAFF-CF885EB1608B")]
	[RecRoom.DataLayer.StableTypeHash(12111354511484844847uL, 0u)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(12111354511484844847uL)]
	public struct ParentData : IComponentData, NHANIEANCKA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public Entity parent;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0xBD5490", Offset = "0xBD3A90", VA = "0x180BD5490", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x14A3DE0", Offset = "0x14A23E0", VA = "0x1814A3DE0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x14A3DE0", Offset = "0x14A23E0", VA = "0x1814A3DE0")]
		public ParentData(Entity parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0xB13490", Offset = "0xB11A90", VA = "0x180B13490")]
		public static implicit operator ParentData(Entity entity)
		{
			return default(ParentData);
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000039")]
public struct FPCKPAABHGK : IComponentData
{
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[TypeManager.ForcedStableTypeHash(1950029632769634832uL)]
	[RecRoom.DataLayer.RRGuid("c886150a-7231-4cc5-a2b2-f222500e6960")]
	[RecRoom.DataLayer.StableTypeHash(1950029632769634832uL, 0u)]
	public struct SiblingSortOrderData : IEquatable<SiblingSortOrderData>, IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public HMNOMFGLPAB order;

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0xB13490", Offset = "0xB11A90", VA = "0x180B13490")]
		public static SiblingSortOrderData HEGJABMHLEC(HMNOMFGLPAB value)
		{
			return default(SiblingSortOrderData);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x74AF6C0", Offset = "0x74ADCC0", VA = "0x1874AF6C0", Slot = "4")]
		public bool Equals(SiblingSortOrderData other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[TypeManager.ForcedStableTypeHash(6217116203744017593uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.RRGuid("46CEA601-8AA7-423D-B1EA-EEABAE73413F")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct InteractionFilterAllTagsData : IComponentData, NHANIEANCKA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public Entity allTags;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xBD5490", Offset = "0xBD3A90", VA = "0x180BD5490", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x14A3DE0", Offset = "0x14A23E0", VA = "0x1814A3DE0", Slot = "5")]
			set
			{
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("49CEFD0F-3A38-4A9B-835E-10B4C2D08392")]
	[TypeManager.ForcedStableTypeHash(6215026851838101933uL)]
	public struct InteractionFilterAnyTagsData : IComponentData, NHANIEANCKA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public Entity anyTags;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0xBD5490", Offset = "0xBD3A90", VA = "0x180BD5490", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x14A3DE0", Offset = "0x14A23E0", VA = "0x1814A3DE0", Slot = "5")]
			set
			{
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("11CE457F-4366-4AAD-B7E3-28D82B4FAFCF")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(6780642047612598977uL)]
	public struct InteractionFilterEnabledData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		[RecRoom.DataLayer.Default(ADAPBJDILJP.Disabled)]
		[RecRoom.DataLayer.Field(1)]
		public ADAPBJDILJP filterMode;
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(6642820932987006861uL)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("F7789094-7D82-4D27-B805-2CC1B8C0A538")]
	public struct InteractionFilterEntityRefData : IComponentData, NHANIEANCKA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public Entity filterEntity;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0xBD5490", Offset = "0xBD3A90", VA = "0x180BD5490", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x14A3DE0", Offset = "0x14A23E0", VA = "0x1814A3DE0", Slot = "5")]
			set
			{
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[RecRoom.DataLayer.RRGuid("C7E95AF7-DB7D-4432-8DAA-8F36EC6C4308")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(15467295871228743847uL)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct InteractionFilterNoneTagsData : IComponentData, NHANIEANCKA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public Entity noneTags;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0xBD5490", Offset = "0xBD3A90", VA = "0x180BD5490", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x14A3DE0", Offset = "0x14A23E0", VA = "0x1814A3DE0", Slot = "5")]
			set
			{
			}
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("007F8815-C87C-4E6B-BC56-3BA0C4888E3D")]
	[RecRoom.DataLayer.StableTypeHash(15012400804589552708uL, 0u)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(15012400804589552708uL)]
	public struct OverrideObjectNetworkIdData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public uint networkIdBits;
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[RecRoom.DataLayer.RRGuid("30228348-77DF-48F6-B2EF-B0883D3E10CA")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(4540375434353162791uL)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct MakerPenHeldData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public bool makerPenHeld;
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[RecRoom.DataLayer.RRGuid("FB9853D6-6231-43FD-A754-00105DC30880")]
	[RecRoom.DataLayer.NetworkComponent(6, false)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(8459715919607487693uL)]
	[ConfigGroup("Object", 0)]
	public struct ObjectPolicyData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		[RecRoom.DataLayer.Field(2)]
		[RecRoom.DataLayer.Default("new ScaleRestriction(1,1)")]
		public BFDPJCKJFHK scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		[RecRoom.DataLayer.Default("ObjectPolicyUserConfigurableFlags.DEFAULT")]
		[RecRoom.DataLayer.Field(3)]
		[Config(null, 0)]
		public MIICMHIJAKL userConfigurableFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		[RecRoom.DataLayer.Default(HPHAOIABICP.Default)]
		[Config(null, 0)]
		[RecRoom.DataLayer.Field(4)]
		public HPHAOIABICP circuitsTransformBehavior;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		[RecRoom.DataLayer.Default("ObjectPolicyEnumFlags.Default")]
		[RecRoom.DataLayer.Field(1)]
		public PEOGKAGLGAI flags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("617A903E-C2C2-467C-A138-287FDB487645")]
	[TypeManager.ForcedStableTypeHash(17708500325183871236uL)]
	[RecRoom.DataLayer.StableTypeHash(17708500325183871236uL, 0u)]
	[CompilerGenerated]
	public struct PlayerScopeData : IComponentData, NHANIEANCKA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public Entity playerScope;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public Entity Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xBD5490", Offset = "0xBD3A90", VA = "0x180BD5490", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x14A3DE0", Offset = "0x14A23E0", VA = "0x1814A3DE0", Slot = "5")]
			set
			{
			}
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0xB13490", Offset = "0xB11A90", VA = "0x180B13490")]
		public static PlayerScopeData HEGJABMHLEC(Entity entity)
		{
			return default(PlayerScopeData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[CompilerGenerated]
	[ConfigGroup("Physics", 0)]
	[RecRoom.DataLayer.StableTypeHash(16642773407304133105uL, 0u)]
	[RecRoom.DataLayer.RRGuid("F945B699-C9E5-4634-9F64-831484F4F3BD")]
	[TypeManager.ForcedStableTypeHash(16642773407304133105uL)]
	public struct PhysicsMaterialData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default(10f)]
		[Config(null, 0)]
		public float density;
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[TypeManager.ForcedStableTypeHash(10537432342869025182uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.StableTypeHash(10537432342869025182uL, 0u)]
	[RecRoom.DataLayer.RRGuid("A2E0AF0F-C284-47E6-9535-A67A29BF5730")]
	public struct ShapeConfigData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		[RecRoom.DataLayer.Default(EDJKJELJDNI.None)]
		[RecRoom.DataLayer.Field(1)]
		public EDJKJELJDNI flags;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool DynamicUVProjection
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x6937A00", Offset = "0x6936000", VA = "0x186937A00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool PreventInvertedCreation
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x6937A10", Offset = "0x6936010", VA = "0x186937A10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool NewBendLogic
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x74B1B00", Offset = "0x74B0100", VA = "0x1874B1B00")]
			get
			{
				return default(bool);
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[TypeManager.ForcedStableTypeHash(10917729582819845312uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.StableTypeHash(10917729582819845312uL, 0u)]
	[RecRoom.DataLayer.RRGuid("5C706BF1-9D50-456A-B974-521E8E2CC660")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct ShapeTypeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public ADOECMLOFOB shapeType;
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(5298506180484533559uL)]
	[RecRoom.DataLayer.StableTypeHash(5298506180484533559uL, 0u)]
	[RecRoom.DataLayer.RRGuid("36418781-DB47-4DE7-A138-CC88D1D795C0")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct SplinePointOrderData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public HMNOMFGLPAB order;

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xB13490", Offset = "0xB11A90", VA = "0x180B13490")]
		public static SplinePointOrderData HEGJABMHLEC(HMNOMFGLPAB value)
		{
			return default(SplinePointOrderData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[TypeManager.ForcedStableTypeHash(16368389834000856208uL)]
	[RecRoom.DataLayer.StableTypeHash(16368389834000856208uL, 0u)]
	[RecRoom.DataLayer.RRGuid("FCEE3BCD-9C10-4BF4-954A-0DCFE8810227")]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct SplinePointParentData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public Entity spline;
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[RecRoom.DataLayer.StableTypeHash(18095612727592564636uL, 0u)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(18095612727592564636uL)]
	[RecRoom.DataLayer.RRGuid("5A6D38A4-1A58-4EB4-9C1B-06ADA0D44AFA")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct SplinePointPositionData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public float3 localPosition;
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[RecRoom.DataLayer.StableTypeHash(1429513518619209486uL, 0u)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("433F66B6-CC1C-4A8A-BF73-2B797440A8DB")]
	[TypeManager.ForcedStableTypeHash(1429513518619209486uL)]
	[CompilerGenerated]
	public struct SplinePointRotationData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default("new quaternion(0, 0, 0, 1f)")]
		public quaternion localRotation;
	}
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[RecRoom.DataLayer.RRGuid("04CA3CCE-F121-4B5B-BC56-FE8E9C77F0F4")]
	[TypeManager.ForcedStableTypeHash(1238044349990854547uL)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.StableTypeHash(1238044349990854547uL, 0u)]
	[CompilerGenerated]
	public struct SplinePointScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default("new float3(1)")]
		public float3 localScale;
	}
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[RecRoom.DataLayer.StableTypeHash(4657247877648983868uL, 0u)]
	[CompilerGenerated]
	[RecRoom.DataLayer.RRGuid("E0610986-0F8F-494A-8C6E-8A2D2491B088")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[TypeManager.ForcedStableTypeHash(4657247877648983868uL)]
	public struct SplineShapeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public GHMFPPOCHDI parameters;
	}
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	[RecRoom.DataLayer.RRGuid("73C344D9-D535-4753-9D9A-B6DEDE4079B0")]
	[RecRoom.DataLayer.StableTypeHash(12332323170023439017uL, 0u)]
	[RecRoom.DataLayer.TombstonedFields(new int[] { 1 })]
	[TypeManager.ForcedStableTypeHash(12332323170023439017uL)]
	public struct OMShapeContainerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		[RecRoom.DataLayer.Default(true)]
		[RecRoom.DataLayer.Field(2)]
		public bool canModifyWithCircuits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		[RecRoom.DataLayer.Field(3)]
		[RecRoom.DataLayer.Default(true)]
		public bool optimizedCollidersEnabled;
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[RecRoom.DataLayer.RRGuid("2B5C4208-9113-4F65-B3A6-18EAE1FF3937")]
	[TypeManager.ForcedStableTypeHash(17673274643717888315uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	public struct SerializedDataLayerVersionData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public int version;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
[RecRoom.DataLayer.RRGuid("CC657074-87FD-47F7-A7B0-F5CCE922A9D0")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[Flags]
[RecRoom.DataLayer.Range(EIFCHLJGNJM.MIN, EIFCHLJGNJM.ALL)]
public enum EIFCHLJGNJM
{
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	IsAllowed = 1,
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	UseDefaultVisualEffects = 2,
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	DEFAULT = 2,
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	ALL = 3,
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	MAX = 3
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("34BA53CB-16FB-45DB-AA25-293CE7C8DAE4")]
	[TypeManager.ForcedStableTypeHash(5328722791392374178uL)]
	[CompilerGenerated]
	public struct ToolCleanupSettingsData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		[RecRoom.DataLayer.Default(15f)]
		[RecRoom.DataLayer.Field(1)]
		public float delay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		[RecRoom.DataLayer.Field(2)]
		[RecRoom.DataLayer.Default(EIFCHLJGNJM.UseDefaultVisualEffects)]
		public EIFCHLJGNJM toolCleanupFlags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	[TypeManager.ForcedStableTypeHash(13768238190614302474uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.RRGuid("48C72ABE-383D-45C6-9610-773F2B4F84C6")]
	[RecRoom.DataLayer.TombstonedFields(new int[] { 2, 3 })]
	public struct ToolCleanupStatusData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public float cleanupStartTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(4)]
		public GEKBHKNKKME statusFlags;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.RRGuid("E63050BA-D087-4027-99F8-4AFDEA229CD8")]
[RecRoom.DataLayer.Range(GEKBHKNKKME.None, GEKBHKNKKME.ALL)]
[Flags]
public enum GEKBHKNKKME
{
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	ForceCleanup = 1,
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	CleanupDone = 2,
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	CleanupPaused = 4,
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	ALL = 7,
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	MAX = 7
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[TypeManager.ForcedStableTypeHash(463077377357487319uL)]
	[RecRoom.DataLayer.RRGuid("021E8703-AAFD-4965-8C38-FF86663126D2")]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	public struct LocalDeformableScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default("new float3(1)")]
		public float3 localDeformationScale;

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x2771E00", Offset = "0x2770400", VA = "0x182771E00")]
		public LocalDeformableScaleData(float3 scale)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[TypeManager.ForcedStableTypeHash(1369925932270831712uL)]
	[RecRoom.DataLayer.StableTypeHash(1369925932270831712uL, 0u)]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("38AA9F1D-FD16-4B56-917C-3341D0EB1DF2")]
	public struct LocalPoseData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		[RecRoom.DataLayer.Default("new quaternion(0,0,0,1)")]
		[RecRoom.DataLayer.Field(1)]
		public quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(2)]
		public float3 localPosition;

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x4B9E380", Offset = "0x4B9C980", VA = "0x184B9E380")]
		public LocalPoseData(quaternion localRotation, float3 localPosition)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x74ADCB0", Offset = "0x74AC2B0", VA = "0x1874ADCB0")]
		public static RigidTransform HEGJABMHLEC(LocalPoseData poseData)
		{
			return default(RigidTransform);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x74ADCB0", Offset = "0x74AC2B0", VA = "0x1874ADCB0")]
		public static LocalPoseData HEGJABMHLEC(RigidTransform pose)
		{
			return default(LocalPoseData);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public static class OKCNMNOIPDI
{
	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x74B1000", Offset = "0x74AF600", VA = "0x1874B1000")]
	public static LocalPoseData JBHCNODGPKJ([In] this RigidTransform KBGCCIOIGBD)
	{
		return default(LocalPoseData);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x74B1030", Offset = "0x74AF630", VA = "0x1874B1030")]
	public static RigidTransform MGNONINDAIK([In] this LocalPoseData KBGCCIOIGBD)
	{
		return default(RigidTransform);
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(2720902521635056246uL)]
	[RecRoom.DataLayer.RRGuid("0E9FADE9-751A-4A53-B455-4F8EA675754D")]
	[RecRoom.DataLayer.StableTypeHash(2720902521635056246uL, 0u)]
	public struct LocalUniformScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default(1f)]
		public float localUniformScale;
	}
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[RecRoom.DataLayer.StableTypeHash(5730545663584378555uL, 0u)]
	[TypeManager.ForcedStableTypeHash(5730545663584378555uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.RRGuid("F01774C0-98E7-491E-AAA5-85B64AFFA182")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct TransformFlagsData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public GGAMIDPBJDH transformHint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		[RecRoom.DataLayer.Field(2)]
		[RecRoom.DataLayer.Default]
		public FHNKOECFNCG transformPriority;
	}
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[RecRoom.DataLayer.RRGuid("392BF0C9-F464-491A-8725-E4B5E5C4ECD4")]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(12583036596830542024uL)]
	[RecRoom.DataLayer.DoNotGenerateComponentProperties]
	public struct RRObjectPrefabData : ISharedComponentData, IEquatable<RRObjectPrefabData>, IComparable<RRObjectPrefabData>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public LBJDMFOKJAE prefabType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(2)]
		public Guid prefabGuid;

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x74B1980", Offset = "0x74AFF80", VA = "0x1874B1980")]
		public RRObjectPrefabData(Guid prefabGuid, LBJDMFOKJAE prefabType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x74B1880", Offset = "0x74AFE80", VA = "0x1874B1880", Slot = "4")]
		public readonly bool Equals(RRObjectPrefabData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x74B17C0", Offset = "0x74AFDC0", VA = "0x1874B17C0", Slot = "0")]
		public override readonly bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x74B19F0", Offset = "0x74AFFF0", VA = "0x1874B19F0")]
		public static bool operator !=(RRObjectPrefabData a, RRObjectPrefabData b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x74B1990", Offset = "0x74AFF90", VA = "0x1874B1990")]
		public static bool operator ==(RRObjectPrefabData a, RRObjectPrefabData b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x74B0ED0", Offset = "0x74AF4D0", VA = "0x1874B0ED0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x74B16F0", Offset = "0x74AFCF0", VA = "0x1874B16F0", Slot = "5")]
		public readonly int CompareTo(RRObjectPrefabData other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x74B18E0", Offset = "0x74AFEE0", VA = "0x1874B18E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[TypeManager.ForcedStableTypeHash(17550159503907726442uL)]
	[RecRoom.DataLayer.RRGuid("FF90B503-A0B5-4B3D-BACF-046FA1456FBD")]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct ReferenceGroupKindData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public EKDALHPLPPO kind;
	}
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("2C78EEBE-6DD9-44FF-A70D-6C2EE9BB8FB3")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(18363292822319307914uL)]
	public struct ReferenceGroupOwnerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public Entity owner;
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[RecRoom.DataLayer.RRGuid("177498E9-83A6-4C2E-A8C1-B1951B47E74D")]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[TypeManager.ForcedStableTypeHash(11947588904347318594uL)]
	public struct ReferenceGroupReferenceBuffer : IBufferElementData, NHANIEANCKA, IEquatable<ReferenceGroupReferenceBuffer>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public Entity reference;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public Entity Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0xBD5490", Offset = "0xBD3A90", VA = "0x180BD5490", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x14A3DE0", Offset = "0x14A23E0", VA = "0x1814A3DE0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x74B1AF0", Offset = "0x74B00F0", VA = "0x1874B1AF0", Slot = "6")]
		public bool Equals(ReferenceGroupReferenceBuffer other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x74B1A60", Offset = "0x74B0060", VA = "0x1874B1A60", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x99D850", Offset = "0x99BE50", VA = "0x18099D850", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005C")]
public struct HKGGEOHLLIJ : IEqualityComparer<ReferenceGroupReferenceBuffer>
{
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public static HKGGEOHLLIJ MPDPNCAPBBE;

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x74AF670", Offset = "0x74ADC70", VA = "0x1874AF670", Slot = "4")]
	public bool Equals(ReferenceGroupReferenceBuffer IKAEODCKAIP, ReferenceGroupReferenceBuffer ACCJFOPIMAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0xC3F460", Offset = "0xC3DA60", VA = "0x180C3F460", Slot = "5")]
	public int GetHashCode(ReferenceGroupReferenceBuffer GMFKPONAANG)
	{
		return default(int);
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(17466046755328781668uL)]
	[InternalBufferCapacity(0)]
	[RecRoom.DataLayer.RRGuid("DE12A401-BD29-4B00-A629-7EFBECEDCFDF")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct AuthoredUserTagReferenceBuffer : GGGHBGBJBAO, IBufferElementData, NHANIEANCKA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public Entity Child;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0xBD5490", Offset = "0xBD3A90", VA = "0x180BD5490", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x14A3DE0", Offset = "0x14A23E0", VA = "0x1814A3DE0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x14A3DE0", Offset = "0x14A23E0", VA = "0x1814A3DE0")]
		public AuthoredUserTagReferenceBuffer(Entity entity)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0xB13490", Offset = "0xB11A90", VA = "0x180B13490")]
		public static AuthoredUserTagReferenceBuffer HEGJABMHLEC(Entity entity)
		{
			return default(AuthoredUserTagReferenceBuffer);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public interface GGGHBGBJBAO : IBufferElementData, NHANIEANCKA
{
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(12148147190301245780uL)]
	[RecRoom.DataLayer.RRGuid("00B7CB5E-4C0C-4D2C-AC95-78529EE58768")]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	public struct PersistentUserTagData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public FixedList32Bytes<int> tags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		[RecRoom.DataLayer.Default(false)]
		[RecRoom.DataLayer.Field(2)]
		public bool initalizedDefaults;
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.StableTypeHash(1859693175312uL, 0u)]
	[RecRoom.DataLayer.RRGuid("80D85A55-B2F6-4860-A851-62973DC10940")]
	[SwatchPrimaryKey]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(1859693175312uL)]
	public struct UserTagNameData : IComponentData, IEquatable<UserTagNameData>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public FixedString32Bytes Value;

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x74B1C30", Offset = "0x74B0230", VA = "0x1874B1C30")]
		public UserTagNameData(string value)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x74B1BF0", Offset = "0x74B01F0", VA = "0x1874B1BF0")]
		public static UserTagNameData HEGJABMHLEC(string value)
		{
			return default(UserTagNameData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x74B1B10", Offset = "0x74B0110", VA = "0x1874B1B10", Slot = "4")]
		public bool Equals(UserTagNameData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x74B1B40", Offset = "0x74B0140", VA = "0x1874B1B40", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x74B1BE0", Offset = "0x74B01E0", VA = "0x1874B1BE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(2039749658960193818uL)]
	[RecRoom.DataLayer.RRGuid("1E609F72-38C4-433D-BB17-B718F89DF446")]
	[InternalBufferCapacity(0)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct UserTagReferenceBuffer : GGGHBGBJBAO, IBufferElementData, NHANIEANCKA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public Entity Child;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0xBD5490", Offset = "0xBD3A90", VA = "0x180BD5490", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x14A3DE0", Offset = "0x14A23E0", VA = "0x1814A3DE0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x14A3DE0", Offset = "0x14A23E0", VA = "0x1814A3DE0")]
		public UserTagReferenceBuffer(Entity entity)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0xB13490", Offset = "0xB11A90", VA = "0x180B13490")]
		public static UserTagReferenceBuffer HEGJABMHLEC(Entity entity)
		{
			return default(UserTagReferenceBuffer);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[RecRoom.DataLayer.StableTypeHash(1591066774816564574uL, 0u)]
	[ConfigGroup("Visual", 0)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(1591066774816564574uL)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("C36DDF08-CA52-4E33-8078-2F6E915D4FDA")]
	public struct StandardRenderableVisualData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		[RecRoom.DataLayer.Default]
		[Config(null, 0)]
		[RecRoom.DataLayer.Field(1)]
		public CPAENDDAKAG color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		[RecRoom.DataLayer.Default]
		[Config(null, 0)]
		[RecRoom.DataLayer.Field(2)]
		public FLMNFNBLJCG material;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		[RecRoom.DataLayer.Default]
		[Config(null, 0)]
		[RecRoom.DataLayer.Field(3)]
		public float uvScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		[Config(null, 0)]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(4)]
		public float3 uvOffset;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
[RecRoom.DataLayer.RRGuid("6B598497-D68A-4CC9-9D41-09EF6B966499")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.Range(HPHAOIABICP.NONE, HPHAOIABICP.COUNT)]
public enum HPHAOIABICP
{
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	NONE = 0,
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	[Config("Default (can transform roots, children are static)", 0)]
	Default = 1,
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	[Config("Can Transform (chips like SetPosition can modify)", 0)]
	CircuitsCanTransform = 2,
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	[Config("Always Static (chips cannot modify transform)", 0)]
	AlwaysStatic = 3,
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	COUNT = 4,
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	MAX = 4
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
[RecRoom.DataLayer.RRGuid("17517E1A-CF1A-48C9-B6A5-F9E42C1B9E96")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.Range(0, 4)]
public enum DMENLJIOLHH
{
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	Box = 1,
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	Sphere = 2,
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	Capsule = 3,
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	Mesh = 4,
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	COUNT = 5,
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	MAX = 4
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
[RecRoom.DataLayer.Range(LMLINLLCMLO.NONE, LMLINLLCMLO.ALL)]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.RRGuid("A13F5102-9259-42B9-B782-BB7CC33A0C4F")]
[Flags]
public enum LMLINLLCMLO
{
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	NONE = 0,
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	Object = 1,
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	Player = 2,
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	Projectile = 4,
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	Vehicle = 8,
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	ALL = 0xF
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
[RecRoom.DataLayer.Range(0, 127)]
[RecRoom.DataLayer.RRGuid("F843A776-E042-43B7-8167-0C7A421062F8")]
[RecRoom.DataLayer.NetworkEnum(2, false)]
public enum LAKFMIPGDFM : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	[@Tooltip("Indicating it can be walked on and moved")]
	[Config("Dynamic (Environment)", 0)]
	IsDynamicEnvironment = 0,
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	[Config("Dynamic", -1)]
	IsDynamic = 10,
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	[Config("Dynamic (Ignore Static Geometry)", 0)]
	IsDynamicIgnoreStaticGeometry = 11,
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	[Config("Dynamic (Ignore Other Dynamic)", 0)]
	IsDynamicIgnoreOtherDynamic = 12,
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	[Config("Dynamic (Ignore Players)", 0)]
	IsDynamicIgnorePlayers = 13,
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	[Config("Dynamic (Ignore Most)", 0)]
	IsDynamicIgnoreMost = 14,
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	[Config("Enemy Collision", 0)]
	IsEnemyCollision = 30,
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	[Config("Enemy Projectile", 0)]
	IsEnemyProjectile = 31,
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	[Config("Vehicle Physics", 0)]
	IsVehicleCollision = 40,
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	[ConfigIgnore]
	STATIC = 100,
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	[ConfigIgnore]
	DECORATION = 101,
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	MAX = 127
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
[RecRoom.DataLayer.NetworkEnum(2, false)]
[RecRoom.DataLayer.RRGuid("9ADF7A0D-D808-48A7-BFCB-3272FB5D8A52")]
[RecRoom.DataLayer.Range(BBKFGBALMBJ.Off, BBKFGBALMBJ.COUNT)]
public enum BBKFGBALMBJ : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	Off = 0,
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	Children = 1,
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	Hull = 2,
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	COUNT = 3,
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	MAX = 2
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
[RecRoom.DataLayer.RRGuid("3B156405-5769-4DB2-87EA-2B846AC4E584")]
[RecRoom.DataLayer.Range(0, 2)]
[RecRoom.DataLayer.NetworkEnum(1, false)]
public enum ADOECMLOFOB
{
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	Primitive = 1,
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	Spline = 2,
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	COUNT = 3,
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	MAX = 2
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
[RecRoom.DataLayer.NetworkEnum(2, false)]
[RecRoom.DataLayer.Range(AEONEPFEMAI.Pivot, AEONEPFEMAI.COUNT)]
[RecRoom.DataLayer.RRGuid("61EFE94A-235A-4281-B938-1A5BE32A18B1")]
public enum AEONEPFEMAI : byte
{
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	Pivot = 0,
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	Bounds = 1,
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	COUNT = 2,
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	MAX = 1
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.RRGuid("c0973732-e735-44cd-9727-a9a79bad01e3")]
[RecRoom.DataLayer.Range(ADAPBJDILJP.EnabledForRole, ADAPBJDILJP.DisabledForRole)]
public enum ADAPBJDILJP : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	EnabledForRole,
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	DisabledForRole,
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	Disabled
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
[RecRoom.DataLayer.Range(PGBKBOPFMNI.NavMeshGenerator, PGBKBOPFMNI.NavMeshBlocker)]
[RecRoom.DataLayer.RRGuid("7E7D5AA1-2EC9-488B-8AB2-703F13BCB8CF")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
public enum PGBKBOPFMNI
{
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	NavMeshGenerator = 0,
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	NavMeshIgnored = 1,
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	NavMeshBlocker = 2,
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	MAX = 2
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
[Flags]
[RecRoom.DataLayer.Range(PEOGKAGLGAI.None, PEOGKAGLGAI.All)]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.RRGuid("7B493897-FE06-4FC8-AB72-8B7BF5A313D3")]
public enum PEOGKAGLGAI
{
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	All = 0x3FFF,
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	Default = 0x3FFF
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
[RecRoom.DataLayer.Range(0, GNIEIAEKOMM.COUNT)]
[RecRoom.DataLayer.RRGuid("4427686F-E636-4F43-91F7-6BC74DEC584E")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
public enum GNIEIAEKOMM
{
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	SupportsRotation,
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	SupportsDeformation,
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	SupportsScaling,
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	SupportsMirroring,
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	SupportsCloning,
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	SupportsRecoloring,
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	CanDestroy,
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	CanSaveIntoInventions,
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	SupportsRespawn,
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	SupportsMerging,
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	SupportsSplitting,
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	SupportsKeys,
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	CanEditWithMakerPen,
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	DEPRECATED_IsGrabbable,
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public static class ALOJJHMJDLE
{
	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x74ADA80", Offset = "0x74AC080", VA = "0x1874ADA80")]
	public static void ECFLGDLFBIO(this PEOGKAGLGAI PNCPEFMKILJ, GNIEIAEKOMM GJHIKFFPLLL, bool BDDPPMGPFHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x74ADA60", Offset = "0x74AC060", VA = "0x1874ADA60")]
	public static bool BEEPJBLGJBK(this PEOGKAGLGAI PNCPEFMKILJ, GNIEIAEKOMM GJHIKFFPLLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0xC50F60", Offset = "0xC4F560", VA = "0x180C50F60")]
	public static PEOGKAGLGAI OAKIMOOMNLI(this GNIEIAEKOMM GJHIKFFPLLL)
	{
		return default(PEOGKAGLGAI);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
[RecRoom.DataLayer.NetworkEnum(2, false)]
[RecRoom.DataLayer.RRGuid("E3C51303-32F0-4EF4-8A66-C814E323653D")]
[RecRoom.DataLayer.Range(MIICMHIJAKL.NONE, MIICMHIJAKL.COUNT)]
[Flags]
public enum MIICMHIJAKL
{
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	NONE = 0,
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	IsFrozen = 1,
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	IsGrabbable = 2,
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	COUNT = 3,
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	ALL = 3,
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	DEFAULT = 0
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
[RecRoom.DataLayer.RRGuid("777AD204-3AC0-41CE-BDC0-894C5821B3B9")]
[RecRoom.DataLayer.Range(1000, 8000)]
[RecRoom.DataLayer.NetworkEnum(1, false)]
public enum LBJDMFOKJAE
{
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	[Config("Container", 0)]
	Container = 1000,
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	[Config("Container", 0)]
	LegacyShapeContainer = 1001,
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	[Config("Container", 0)]
	CreationShapeContainer = 1002,
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	[Config("Container", 0)]
	CostumePieceShapeContainer = 1003,
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	[Config("Empty", 0)]
	Empty = 4000,
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	[Config("Legacy Box", 0)]
	Shape_Primitive_LegacyBox = 2000,
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	[Config("Sphere", 0)]
	Shape_Primitive_Sphere = 2001,
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	[Config("Cylinder", 0)]
	Shape_Primitive_Cylinder = 2002,
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	[Config("Legacy Wedge", 0)]
	Shape_Primitive_LegacyWedge = 2003,
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	[Config("Legacy Pyramid", 0)]
	Shape_Primitive_LegacyPyramid = 2004,
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	[Config("Trigger Volume Box", 0)]
	Shape_Primitive_TriggerVolumeBox = 2005,
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	[Config("Box", 0)]
	Shape_Primitive_Box = 2006,
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	[Config("Rounded Box", 0)]
	Shape_Primitive_RoundedBox = 2007,
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	[Config("Wedge", 0)]
	Shape_Primitive_Wedge = 2008,
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	[Config("Pyramid", 0)]
	Shape_Primitive_Pyramid = 2009,
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	[Config("Half Sphere", 0)]
	Shape_Primitive_HalfSphere = 2010,
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	[Config("Cone", 0)]
	Shape_Primitive_Cone = 2011,
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	[Config("Pipe", 0)]
	Shape_Primitive_Pipe = 2012,
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	[Config("Donut", 0)]
	Shape_Primitive_Donut = 2013,
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	[Config("Half Pipe", 0)]
	Shape_Primitive_HalfPipe = 2014,
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	[Config("Diamond", 0)]
	Shape_Primitive_Diamond = 2015,
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	[Config("Mound", 0)]
	Shape_Primitive_Mound = 2016,
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	[Config("Cube (Simple)", 0)]
	Shape_Primitive_ADVANCED_Cube = 2017,
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	[Config("Sphere (Simple)", 0)]
	Shape_Primitive_ADVANCED_Sphere = 2018,
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	[Config("Cylinder (Simple)", 0)]
	Shape_Primitive_ADVANCED_Cylinder = 2019,
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	[Config("Cone (Simple)", 0)]
	Shape_Primitive_ADVANCED_Cone = 2020,
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	[Config("Pyramid (Simple)", 0)]
	Shape_Primitive_ADVANCED_Pyramid = 2021,
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	[Config("Octagon (Simple)", 0)]
	Shape_Primitive_ADVANCED_Octagon = 2022,
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	[Config("Triangle (Simple)", 0)]
	Shape_Primitive_ADVANCED_Triangle = 2023,
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	[Config("Hexagon (Simple)", 0)]
	Shape_Primitive_ADVANCED_Hexagon = 2024,
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	[Config("Quarter Pipe", 0)]
	Shape_Primitive_ADVANCED_QuarterPipe = 2025,
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	[Config("Pentagon (Simple)", 0)]
	Shape_Primitive_ADVANCED_Pentagon = 2026,
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	[Config("Dodecahedron", 0)]
	Shape_Primitive_ADVANCED_Dodecahedron = 2027,
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	[Config("Icosahedron", 0)]
	Shape_Primitive_ADVANCED_Trihedron = 2028,
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	[Config("Octahedron", 0)]
	Shape_Primitive_ADVANCED_Octahedron = 2029,
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	[Config("Quarter Cylinder", 0)]
	Shape_Primitive_RR_QuarterCylinder = 2030,
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	[Config("Pentagon", 0)]
	Shape_Primitive_RR_Pentagon = 2031,
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	[Config("Quarter Sphere", 0)]
	Shape_Primitive_RR_QuarterSphere = 2032,
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	[Config("Wedge (Simple)", 0)]
	Shape_Primitive_ADVANCED_Wedge = 2033,
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	[Config("Hexagon", 0)]
	Shape_Primitive_RR_Hexagon = 2034,
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	[Config("Octagon", 0)]
	Shape_Primitive_RR_Octagon = 2035,
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	[Config("Triangle", 0)]
	Shape_Primitive_RR_Triangle = 2036,
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	[Config("Spline", 0)]
	Shape_Spline = 3000,
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	[Config("Container Pivot", 0)]
	Other_ContainerPivot = 6000,
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	[Config("Spine Point", 0)]
	Other_SplinePoint = 6001,
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	[Config("Reference Point", 0)]
	Other_ReferencePoint = 6002,
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	[Config("UserTags", 0)]
	Other_UserTag = 6003,
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	[Config("Reference Group", 0)]
	Other_ReferenceGroup = 6004,
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	[Config("Interaction Filter", 0)]
	Other_InteractionFilterTags = 6005,
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	[ConfigIgnore]
	UNUSED2 = 5000,
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	[Config("Object", 0)]
	PrefabRootGameObject = 7000,
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	[Config("PrefabInternal", 0)]
	PrefabInternalGameObject = 7001,
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	[Config("Player", 0)]
	Player = 8000
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public static class PCDOOPMBMKP
{
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[CompilerGenerated]
	private sealed class CNHNCFDKGCC : IEnumerable<LBJDMFOKJAE>, IEnumerable, IEnumerator<LBJDMFOKJAE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private LBJDMFOKJAE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private IEnumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private LBJDMFOKJAE System.Collections.Generic.IEnumerator<RecRoom.DataLayer.ObjectPrefabType>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0xA35E20", Offset = "0xA34420", VA = "0x180A35E20", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(LBJDMFOKJAE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x74AE8F0", Offset = "0x74ACEF0", VA = "0x1874AE8F0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x10A62D0", Offset = "0x10A48D0", VA = "0x1810A62D0")]
		[DebuggerHidden]
		public CNHNCFDKGCC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x74AE940", Offset = "0x74ACF40", VA = "0x1874AE940", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x74AE580", Offset = "0x74ACB80", VA = "0x1874AE580", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x74AE520", Offset = "0x74ACB20", VA = "0x1874AE520")]
		private void ACIHHJJLKBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x74AE8A0", Offset = "0x74ACEA0", VA = "0x1874AE8A0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x74AE800", Offset = "0x74ACE00", VA = "0x1874AE800", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<LBJDMFOKJAE> System.Collections.Generic.IEnumerable<RecRoom.DataLayer.ObjectPrefabType>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x74AE800", Offset = "0x74ACE00", VA = "0x1874AE800", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000073")]
	[CompilerGenerated]
	private sealed class ANKAFEODCPG : IEnumerable<LBJDMFOKJAE>, IEnumerable, IEnumerator<LBJDMFOKJAE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private LBJDMFOKJAE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		private LBJDMFOKJAE <last>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		private LBJDMFOKJAE <i>5__3;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		private LBJDMFOKJAE System.Collections.Generic.IEnumerator<RecRoom.DataLayer.ObjectPrefabType>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0xA35E20", Offset = "0xA34420", VA = "0x180A35E20", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(LBJDMFOKJAE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x74ADC00", Offset = "0x74AC200", VA = "0x1874ADC00", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x10A62D0", Offset = "0x10A48D0", VA = "0x1810A62D0")]
		[DebuggerHidden]
		public ANKAFEODCPG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x74ADAB0", Offset = "0x74AC0B0", VA = "0x1874ADAB0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x74ADBB0", Offset = "0x74AC1B0", VA = "0x1874ADBB0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x74ADB10", Offset = "0x74AC110", VA = "0x1874ADB10", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<LBJDMFOKJAE> System.Collections.Generic.IEnumerable<RecRoom.DataLayer.ObjectPrefabType>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x74ADB10", Offset = "0x74AC110", VA = "0x1874ADB10", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[CompilerGenerated]
	private sealed class LEHLAOFDHHL : IEnumerable<LBJDMFOKJAE>, IEnumerable, IEnumerator<LBJDMFOKJAE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		private LBJDMFOKJAE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		private IEnumerator<LBJDMFOKJAE> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		private LBJDMFOKJAE System.Collections.Generic.IEnumerator<RecRoom.DataLayer.ObjectPrefabType>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0xA35E20", Offset = "0xA34420", VA = "0x180A35E20", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(LBJDMFOKJAE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x74B0C50", Offset = "0x74AF250", VA = "0x1874B0C50", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x10A62D0", Offset = "0x10A48D0", VA = "0x1810A62D0")]
		[DebuggerHidden]
		public LEHLAOFDHHL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x74B0CA0", Offset = "0x74AF2A0", VA = "0x1874B0CA0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x74B08C0", Offset = "0x74AEEC0", VA = "0x1874B08C0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x74B0870", Offset = "0x74AEE70", VA = "0x1874B0870")]
		private void ACIHHJJLKBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x74B0C00", Offset = "0x74AF200", VA = "0x1874B0C00", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x74B0B60", Offset = "0x74AF160", VA = "0x1874B0B60", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<LBJDMFOKJAE> System.Collections.Generic.IEnumerable<RecRoom.DataLayer.ObjectPrefabType>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x74B0B60", Offset = "0x74AF160", VA = "0x1874B0B60", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x74B1240", Offset = "0x74AF840", VA = "0x1874B1240")]
	[IteratorStateMachine(typeof(CNHNCFDKGCC))]
	public static IEnumerable<LBJDMFOKJAE> HOKPGEFDAJJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x74B1180", Offset = "0x74AF780", VA = "0x1874B1180")]
	[IteratorStateMachine(typeof(ANKAFEODCPG))]
	public static IEnumerable<LBJDMFOKJAE> BKGAEPLPIHL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x74B11E0", Offset = "0x74AF7E0", VA = "0x1874B11E0")]
	[IteratorStateMachine(typeof(LEHLAOFDHHL))]
	public static IEnumerable<LBJDMFOKJAE> HMOJDDIFLFD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public static class BNKKIMAMHJE
{
	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x74ADD40", Offset = "0x74AC340", VA = "0x1874ADD40")]
	public static bool AOALNDDJFPA(this LBJDMFOKJAE BMIPLDLMPCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x74ADDF0", Offset = "0x74AC3F0", VA = "0x1874ADDF0")]
	public static bool OFCMCBNNBOJ(this RRObjectPrefabData NEKDLFACDOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x74ADDC0", Offset = "0x74AC3C0", VA = "0x1874ADDC0")]
	public static bool OFCMCBNNBOJ(this LBJDMFOKJAE BMIPLDLMPCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x74ADD70", Offset = "0x74AC370", VA = "0x1874ADD70")]
	public static CBKOFJIKNOE DECAAHAIDDG(this LBJDMFOKJAE GHJDJHIELJH)
	{
		return default(CBKOFJIKNOE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x74ADDB0", Offset = "0x74AC3B0", VA = "0x1874ADDB0")]
	internal static BKBMBDKJCIG MEIHPLIFMDG(this CBKOFJIKNOE FJCDLCFJEBC)
	{
		return default(BKBMBDKJCIG);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x74ADD90", Offset = "0x74AC390", VA = "0x1874ADD90")]
	internal static BKBMBDKJCIG MEIHPLIFMDG(this LBJDMFOKJAE GHJDJHIELJH)
	{
		return default(BKBMBDKJCIG);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
internal enum BKBMBDKJCIG
{
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	Container = 1000,
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	Empty = 4000,
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	Primitive = 2000,
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	Spline = 3000,
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	Other = 6000,
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	UNUSED2 = 5000,
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	GameObject = 7000,
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	Player = 8000
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.Range(0, 8)]
[RecRoom.DataLayer.RRGuid("A32413BC-21F3-4F7C-84B0-37724A854A67")]
public enum CBKOFJIKNOE
{
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	Container,
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	Primitive,
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	Spline,
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	Empty,
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	UNUSED2,
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	Other,
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	GameObject,
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	Player
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public static class POJECFIJAOJ
{
	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x74B1560", Offset = "0x74AFB60", VA = "0x1874B1560")]
	public static bool JPKJIGNEIII(this CBKOFJIKNOE FJCDLCFJEBC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
[RecRoom.DataLayer.NetworkEnum(2, false)]
[RecRoom.DataLayer.Range(0, KMKOJLIANAG.ALL)]
[Flags]
[RecRoom.DataLayer.RRGuid("7A0D34B5-FFE5-4C21-BB0C-CB3EBA34C797")]
public enum KMKOJLIANAG : ushort
{
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	NONE = 0,
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	PhysicsEnabled = 1,
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	GravityEnabled = 2,
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	HasCustomMass = 4,
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	CollisionEvent = 0x40,
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	CanUse = 0x200,
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	CanClimb = 0x400,
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	CanWallRun = 0x800,
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	CanClamber = 0x1000,
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	CanTeleport = 0x2000,
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	DEFAULT = 0x3800,
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	ALL = 0x3E47,
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	MAX = 0x3E47
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[TypeManager.ForcedStableTypeHash(8060729269509364919uL)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("5D4503E7-6CC4-4938-8840-1B859C391878")]
	[RecRoom.DataLayer.StableTypeHash(8060729269509364919uL, 0u)]
	[CompilerGenerated]
	public struct PrimitiveShapeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public OFHIFDOIEMG shapeType;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
[RecRoom.DataLayer.RRGuid("517224CC-0A79-4FE9-B048-53C37955D823")]
[RecRoom.DataLayer.Range(-1, 38)]
[RecRoom.DataLayer.NetworkEnum(1, false)]
public enum OFHIFDOIEMG
{
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	LegacyBox = 2,
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	RR_Sphere = 3,
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	RR_Cylinder = 4,
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	LEGACY_Wedge = 5,
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	LEGACY_Pyramid = 6,
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	LEGACY_TriggerVolumeBox = 7,
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	RR_Box = 8,
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	LEGACY_RoundedBox = 9,
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	RR_Wedge = 10,
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	RR_Pyramid = 11,
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	RR_HalfSphere = 12,
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	RR_Cone = 13,
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	RR_Pipe = 14,
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	RR_Donut = 15,
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	RR_HalfPipe = 16,
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	RR_Diamond = 17,
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	ADVANCED_Mound = 18,
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	ADVANCED_Cube = 19,
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	ADVANCED_Sphere = 20,
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	ADVANCED_Cylinder = 21,
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	ADVANCED_Cone = 22,
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	ADVANCED_Pyramid = 23,
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	ADVANCED_Octagon = 24,
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	ADVANCED_Triangle = 25,
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	ADVANCED_Hexagon = 26,
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	ADVANCED_QuarterPipe = 27,
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	ADVANCED_Pentagon = 28,
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	ADVANCED_Dodecahedron = 29,
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	ADVANCED_Trihedron = 30,
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	ADVANCED_Octahedron = 31,
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	RR_QuarterCylinder = 32,
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	RR_Pentagon = 33,
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	RR_QuarterSphere = 34,
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	ADVANCED_Wedge = 35,
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	RR_Hexagon = 36,
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	RR_Octagon = 37,
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	RR_Triangle = 38,
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	COUNT = 39,
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	MIN_VALUE = -1,
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	MAX_VALUE = 38
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
[RecRoom.DataLayer.RRGuid("3D27DF09-CAE2-4C3F-B808-03AD605F8E98")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.Range(EKDALHPLPPO.None, EKDALHPLPPO.COUNT)]
public enum EKDALHPLPPO : byte
{
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	AnimationGroup = 1,
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	COUNT = 2,
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	MAX = 2
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.RRGuid("1829B7EA-C0EA-4E77-8EB2-BA23E995C860")]
[RecRoom.DataLayer.Range(0, 7)]
[Flags]
public enum EDJKJELJDNI
{
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	DynamicUVProjection = 1,
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	PreventInvertedCreation = 2,
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	NewBendLogic = 4,
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	All = 7,
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	MAX = 7
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[Flags]
[RecRoom.DataLayer.RRGuid("CCB58F66-EF02-476E-820F-9D593E2C3DE5")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.Range(0, 7)]
public enum CBJMMJDEABF
{
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	IsRibbon = 1,
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	RoundedTubes = 2,
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	OldStyleCaps = 4,
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	All = 7,
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	MAX = 7
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
[Flags]
[RecRoom.DataLayer.Range(0, 1)]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.RRGuid("72742F9B-D48E-4CED-B403-444201FFEE66")]
public enum GGAMIDPBJDH
{
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	Static = 0,
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	Dynamic = 1,
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	All = 1
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.RRGuid("C5BE1CDA-5EF5-4EBF-BC7E-3E3510C68A7F")]
[RecRoom.DataLayer.Range(-2, 2)]
public enum FHNKOECFNCG
{
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	Frozen = -2,
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	Low = -1,
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	Normal = 0,
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	High = 1,
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	Realtime = 2,
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	Default = 0,
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	MIN = -2,
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	MAX = 2
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
[RecRoom.DataLayer.Range(int.MinValue, int.MaxValue)]
[RecRoom.DataLayer.RRGuid("D6AFAFED-8BAA-4499-9696-9CBB716EF514")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
public enum CPAENDDAKAG
{
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	Red = 0,
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	Orange = 1,
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	Yellow = 2,
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	LightGreen = 3,
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	Blue = 4,
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	LightBlue = 5,
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	Teal = 6,
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	Green = 7,
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	Purple = 8,
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	LightPink = 9,
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	Pink = 10,
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	Brown = 11,
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	Tan = 12,
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	White = 13,
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	Grey = 14,
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	DarkGrey = 15,
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	DarkBrown = 16,
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	LightBrown = 17,
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	LightGrey = 18,
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	Black = 19,
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	DarkRed = 20,
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	DarkOrange = 21,
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	DarkYellow = 22,
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	DarkGreen = 23,
	[Cpp2IlInjected.Token(Token = "0x4000207")]
	DarkTeal = 24,
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	DarkBlue = 25,
	[Cpp2IlInjected.Token(Token = "0x4000209")]
	DarkPurple = 26,
	[Cpp2IlInjected.Token(Token = "0x400020A")]
	DarkPink = 27,
	[Cpp2IlInjected.Token(Token = "0x400020B")]
	LightRed = 28,
	[Cpp2IlInjected.Token(Token = "0x400020C")]
	LightOrange = 29,
	[Cpp2IlInjected.Token(Token = "0x400020D")]
	LightYellow = 30,
	[Cpp2IlInjected.Token(Token = "0x400020E")]
	Cyan = 31,
	[Cpp2IlInjected.Token(Token = "0x400020F")]
	LightPurple = 32,
	[Cpp2IlInjected.Token(Token = "0x4000210")]
	DarkTan = 33,
	[Cpp2IlInjected.Token(Token = "0x4000211")]
	NewColor1 = 34,
	[Cpp2IlInjected.Token(Token = "0x4000212")]
	NewColor2 = 35,
	[Cpp2IlInjected.Token(Token = "0x4000213")]
	NewColor3 = 36,
	[Cpp2IlInjected.Token(Token = "0x4000214")]
	NewColor4 = 37,
	[Cpp2IlInjected.Token(Token = "0x4000215")]
	NewColor5 = 38,
	[Cpp2IlInjected.Token(Token = "0x4000216")]
	NewColor6 = 39,
	[Cpp2IlInjected.Token(Token = "0x4000217")]
	NewColor7 = 40,
	[Cpp2IlInjected.Token(Token = "0x4000218")]
	NewColor8 = 41,
	[Cpp2IlInjected.Token(Token = "0x4000219")]
	NewColor9 = 42,
	[Cpp2IlInjected.Token(Token = "0x400021A")]
	NewColor10 = 43,
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	NewColor11 = 44,
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	NewColor12 = 45,
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	NewColor13 = 46,
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	NewColor14 = 47,
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	NewColor15 = 48,
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	NewColor16 = 49,
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	NewColor17 = 50,
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	NewColor18 = 51,
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	NewColor19 = 52,
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	NewColor20 = 53,
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	NewColor21 = 54,
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	NewColor22 = 55,
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	NewColor23 = 56,
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	NewColor24 = 57,
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	NewColor25 = 58,
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	NewColor26 = 59,
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	NewColor27 = 60,
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	Default = 0
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.RRGuid("C57BE511-BA1A-4D83-BA58-303F34F4DE74")]
[RecRoom.DataLayer.Range(-1, 31)]
public enum FLMNFNBLJCG
{
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	Cardboard = 0,
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	Neon = 1,
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	Brick = 2,
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	Carpet = 3,
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	Dirt = 4,
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	Grass = 5,
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	MetalReflective = 6,
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	Concrete = 7,
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	Linoleum = 8,
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	Plaster = 9,
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	WoodLogs = 10,
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	WoodBoards = 11,
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	WoodGrain = 12,
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	WoodFloor = 13,
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	Sand = 14,
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	GlossyPlastic = 15,
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	Cloth = 16,
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	RubberFloor = 17,
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	MetalFloorTread = 18,
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	PaintedBrick = 19,
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	Crashpad = 20,
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	PaintedWood = 21,
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	GripTape = 22,
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	GalvanizedMetal = 23,
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	ParticleBoard = 24,
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	CheckeredFloor = 25,
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	SparklyVinyl = 26,
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	Gravel = 27,
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	Rock = 28,
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	Placeholder29 = 29,
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	Placeholder30 = 30,
	[Cpp2IlInjected.Token(Token = "0x400024E")]
	Placeholder31 = 31,
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	COUNT = 32,
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	MIN = -1,
	[Cpp2IlInjected.Token(Token = "0x4000251")]
	MAX = 31,
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	Default = 0
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
[RecRoom.DataLayer.RRGuid("112F004A-C92F-4055-99F9-D430EC13FE3C")]
[RecRoom.DataLayer.NetworkStruct(1, false)]
public struct HMNOMFGLPAB : IComparable<HMNOMFGLPAB>, IEquatable<HMNOMFGLPAB>
{
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	public static readonly HMNOMFGLPAB DGEEMDAPOEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000254")]
	[RecRoom.DataLayer.Field(1)]
	public uint JMNGPEMOIBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000255")]
	[RecRoom.DataLayer.Field(2)]
	public uint EHOHKFHHIIM;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	private readonly uint ENPAKICDNOP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x74AF880", Offset = "0x74ADE80", VA = "0x1874AF880")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public readonly bool DLCFPDABHIK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x74AF690", Offset = "0x74ADC90", VA = "0x1874AF690")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x74AFDC0", Offset = "0x74AE3C0", VA = "0x1874AFDC0")]
	public HMNOMFGLPAB(int JMNGPEMOIBI, int ELAJMNJLNOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x74AFDC0", Offset = "0x74AE3C0", VA = "0x1874AFDC0")]
	public HMNOMFGLPAB(uint JMNGPEMOIBI, uint ELAJMNJLNOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x74AFD40", Offset = "0x74AE340", VA = "0x1874AFD40")]
	private HMNOMFGLPAB(uint JMNGPEMOIBI, uint ELAJMNJLNOO, bool IHOIBPLGAOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x74AF7A0", Offset = "0x74ADDA0", VA = "0x1874AF7A0")]
	public HMNOMFGLPAB GACEGDPOKJI(int FDJGEFDKBBO = 1)
	{
		return default(HMNOMFGLPAB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x74AFBF0", Offset = "0x74AE1F0", VA = "0x1874AFBF0")]
	public HMNOMFGLPAB OKNDFLDOIFK(int FDJGEFDKBBO = 1)
	{
		return default(HMNOMFGLPAB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x74AF890", Offset = "0x74ADE90", VA = "0x1874AF890")]
	public static HMNOMFGLPAB MFNNEEEDACP(HMNOMFGLPAB HJGDMEAJFEI, HMNOMFGLPAB OHAJMMPIMHB)
	{
		return default(HMNOMFGLPAB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x74AFB90", Offset = "0x74AE190", VA = "0x1874AFB90")]
	private static ulong MHANCEFFBNF(ulong AMGCKABOOPF, ulong PPCFCAEIJMM)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x74AF6A0", Offset = "0x74ADCA0", VA = "0x1874AF6A0", Slot = "4")]
	public int CompareTo(HMNOMFGLPAB OKCHLIEAIJP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x74AF6E0", Offset = "0x74ADCE0", VA = "0x1874AF6E0", Slot = "0")]
	public override bool Equals(object GMFKPONAANG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x74AFC60", Offset = "0x74AE260", VA = "0x1874AFC60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x74AF6C0", Offset = "0x74ADCC0", VA = "0x1874AF6C0", Slot = "5")]
	public bool Equals(HMNOMFGLPAB OKCHLIEAIJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x74AF810", Offset = "0x74ADE10", VA = "0x1874AF810", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x33DB220", Offset = "0x33D9820", VA = "0x1833DB220")]
	public static bool BFIJCNNIIMH(HMNOMFGLPAB HJGDMEAJFEI, HMNOMFGLPAB OHAJMMPIMHB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x74AF860", Offset = "0x74ADE60", VA = "0x1874AF860")]
	public static bool HKDAGECLGLD(HMNOMFGLPAB HJGDMEAJFEI, HMNOMFGLPAB OHAJMMPIMHB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x74AFBD0", Offset = "0x74AE1D0", VA = "0x1874AFBD0")]
	public static bool ODHCBGJCBCA(HMNOMFGLPAB HJGDMEAJFEI, HMNOMFGLPAB OHAJMMPIMHB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x74AF780", Offset = "0x74ADD80", VA = "0x1874AF780")]
	public static bool FFFGEAOKDJH(HMNOMFGLPAB HJGDMEAJFEI, HMNOMFGLPAB OHAJMMPIMHB)
	{
		return default(bool);
	}
}
namespace RecRoom.DataLayer
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	[RecRoom.DataLayer.RRGuid("D3AB0F52-EA41-4891-9470-6E945A9D6583")]
	[RecRoom.DataLayer.NetworkStruct(1, false)]
	public struct NetworkGuid : IEquatable<NetworkGuid>, IComparable<NetworkGuid>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		[RecRoom.DataLayer.Field(1)]
		public int4 data;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public Guid Guid
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x1048800", Offset = "0x1046E00", VA = "0x181048800")]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x10488D0", Offset = "0x1046ED0", VA = "0x1810488D0")]
			set
			{
			}
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x1048800", Offset = "0x1046E00", VA = "0x181048800")]
		public static Guid HEGJABMHLEC(NetworkGuid JINNLDEOCMO)
		{
			return default(Guid);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x1048800", Offset = "0x1046E00", VA = "0x181048800")]
		public static NetworkGuid HEGJABMHLEC(Guid JINNLDEOCMO)
		{
			return default(NetworkGuid);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x74B0F50", Offset = "0x74AF550", VA = "0x1874B0F50", Slot = "4")]
		public bool Equals(NetworkGuid OKCHLIEAIJP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x4699120", Offset = "0x4697720", VA = "0x184699120", Slot = "5")]
		public int CompareTo(NetworkGuid OKCHLIEAIJP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x74B0F80", Offset = "0x74AF580", VA = "0x1874B0F80", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
[RecRoom.DataLayer.NetworkStruct(1, false)]
[RecRoom.DataLayer.RRGuid("9F5F33BE-7C0A-4870-9CE0-BA79440E7F98")]
public struct BFDPJCKJFHK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000257")]
	[RecRoom.DataLayer.Field(1)]
	public bool GCDMKJKGKMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000258")]
	[RecRoom.DataLayer.Field(2)]
	public float3 NNLLEIGGPEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000259")]
	[RecRoom.DataLayer.Field(3)]
	public float3 IGEMGLHLOEC;

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x74ABFB0", Offset = "0x74AA5B0", VA = "0x1874ABFB0")]
	public BFDPJCKJFHK(float CDIPILBCKFB, float HCEBABCAMLE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
[RecRoom.DataLayer.NetworkStruct(1, false)]
[RecRoom.DataLayer.RRGuid("35984D5B-ACBD-4389-A94B-840070A871E2")]
public struct GHMFPPOCHDI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400025A")]
	[RecRoom.DataLayer.Field(1)]
	public float MMHCLBPDOPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400025B")]
	[RecRoom.DataLayer.Field(2)]
	public int ENCHIMLCJAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400025C")]
	[RecRoom.DataLayer.Field(3)]
	public CBJMMJDEABF PNCPEFMKILJ;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool EJGEJEKCLPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x74AF4C0", Offset = "0x74ADAC0", VA = "0x1874AF4C0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x74AF4E0", Offset = "0x74ADAE0", VA = "0x1874AF4E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public bool KFEKJCLAOOL
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x74AF4D0", Offset = "0x74ADAD0", VA = "0x1874AF4D0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x74AF510", Offset = "0x74ADB10", VA = "0x1874AF510")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public bool BOAGBKMLGEF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x74AF500", Offset = "0x74ADB00", VA = "0x1874AF500")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x74AF4A0", Offset = "0x74ADAA0", VA = "0x1874AF4A0")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public class KJMMAOIEJBO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400025D")]
	public IKFPPMNFKBP KKKLHABLMLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400025E")]
	public int LEPCEKLNDEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400025F")]
	public bool GMIKMKKIIKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D")]
	[Cpp2IlInjected.Token(Token = "0x4000260")]
	public bool OCHKCGKIIGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E")]
	[Cpp2IlInjected.Token(Token = "0x4000261")]
	public bool DEAIADLPDBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000262")]
	public Vector3 NAMOIOBECGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000263")]
	public Quaternion KGCMOGJCFFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000264")]
	public bool FLOGIFMHEDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000265")]
	public Vector3 PKJENICKIKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000266")]
	public Vector3 IMKEKDHANPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000267")]
	public Vector3 PFLMNICJFFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000268")]
	public bool PPIKACAJIBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000269")]
	protected ViewId MHPIOPAPGMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x400026A")]
	protected HBAPKNHAKNO DAKNHNALELJ;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public ViewId OODLEPBAEAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x74AFE30", Offset = "0x74AE430", VA = "0x1874AFE30")]
		get
		{
			return default(ViewId);
		}
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0xD7F330", Offset = "0xD7D930", VA = "0x180D7F330")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x74AFED0", Offset = "0x74AE4D0", VA = "0x1874AFED0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
	public KJMMAOIEJBO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public struct MNGFOGALJIN : IEquatable<MNGFOGALJIN>, IComparable<MNGFOGALJIN>
{
	[Cpp2IlInjected.Token(Token = "0x400026B")]
	public static readonly int OMFFONMKFBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400026C")]
	public RRObjectPrefabData CFENBMBECBB;

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x74B0F00", Offset = "0x74AF500", VA = "0x1874B0F00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x74B0E60", Offset = "0x74AF460", VA = "0x1874B0E60", Slot = "4")]
	public bool Equals(MNGFOGALJIN OKCHLIEAIJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x74B0D60", Offset = "0x74AF360", VA = "0x1874B0D60", Slot = "0")]
	public override bool Equals(object GMFKPONAANG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x74B0ED0", Offset = "0x74AF4D0", VA = "0x1874B0ED0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x74B0D30", Offset = "0x74AF330", VA = "0x1874B0D30", Slot = "5")]
	public int CompareTo(MNGFOGALJIN OKCHLIEAIJP)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
internal class OGDMDOOCAJE : ContainerPropertyBag<DLFJAADKMKH>
{
	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x74B0FA0", Offset = "0x74AF5A0", VA = "0x1874B0FA0")]
	public OGDMDOOCAJE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
internal class FEEMAMNCHCF : ContainerPropertyBag<RRObjectPrefabData>
{
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	private class OLJCOOBAJNO : Property<RRObjectPrefabData, LBJDMFOKJAE>
	{
		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override string OPDMIMOEGEA
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x74B1150", Offset = "0x74AF750", VA = "0x1874B1150", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public override bool NJEEMOHCODN
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x99B9F0", Offset = "0x999FF0", VA = "0x18099B9F0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x74B1060", Offset = "0x74AF660", VA = "0x1874B1060")]
		public OLJCOOBAJNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x1F19DE0", Offset = "0x1F183E0", VA = "0x181F19DE0", Slot = "14")]
		public override LBJDMFOKJAE GetValue(RRObjectPrefabData MGOKPJKELJG)
		{
			return default(LBJDMFOKJAE);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x749C910", Offset = "0x749AF10", VA = "0x18749C910", Slot = "15")]
		public override void SetValue(RRObjectPrefabData MGOKPJKELJG, LBJDMFOKJAE KBGCCIOIGBD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008C")]
	private class EDFKHOCNIJO : Property<RRObjectPrefabData, Guid>
	{
		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public override string OPDMIMOEGEA
		{
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x74AF0A0", Offset = "0x74AD6A0", VA = "0x1874AF0A0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public override bool NJEEMOHCODN
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x99B9F0", Offset = "0x999FF0", VA = "0x18099B9F0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x74AEFB0", Offset = "0x74AD5B0", VA = "0x1874AEFB0")]
		public EDFKHOCNIJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x2B6BEB0", Offset = "0x2B6A4B0", VA = "0x182B6BEB0", Slot = "14")]
		public override Guid GetValue(RRObjectPrefabData MGOKPJKELJG)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x74AEFA0", Offset = "0x74AD5A0", VA = "0x1874AEFA0", Slot = "15")]
		public override void SetValue(RRObjectPrefabData MGOKPJKELJG, Guid KBGCCIOIGBD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x74AF1B0", Offset = "0x74AD7B0", VA = "0x1874AF1B0")]
	public FEEMAMNCHCF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
internal class GGALDAMMGIG : ContainerPropertyBag<Guid>
{
	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x74AF440", Offset = "0x74ADA40", VA = "0x1874AF440")]
	public GGALDAMMGIG()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x74B1570", Offset = "0x74AFB70", VA = "0x1874B1570")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		[Preserve]
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
