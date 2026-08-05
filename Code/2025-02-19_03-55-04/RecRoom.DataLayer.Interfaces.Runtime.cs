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
		[Cpp2IlInjected.Address(RVA = "0x9827A0", Offset = "0x9813A0", VA = "0x1809827A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9827A0", Offset = "0x9813A0", VA = "0x1809827A0")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct MIFMNKDNGLA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private bool PNBNOAFPGFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private ViewId KFPFLKNFFBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private int KKHFKGIPICC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private bool CMHHKACCLBK;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x745D7C0", Offset = "0x745C3C0", VA = "0x18745D7C0")]
	public MIFMNKDNGLA(ViewId KFPFLKNFFBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x745D780", Offset = "0x745C380", VA = "0x18745D780")]
	public MIFMNKDNGLA(int KKHFKGIPICC, bool CMHHKACCLBK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x745D6A0", Offset = "0x745C2A0", VA = "0x18745D6A0")]
	public ViewId PHBCIMFNDCL([Optional] ViewId JGMAGKPKPGK)
	{
		return default(ViewId);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class ADFLJJGFNGN
{
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly Guid FKBNPJILIPD;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static readonly Guid MPAOLNFKOAK;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static readonly Guid CMELCIAAGFG;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public static readonly Guid GIEMEOPOIKM;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly Guid BAJFLCKIIDL;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public static readonly Dictionary<string, Guid> LOAJFAMOAOJ;

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static readonly RRObjectPrefabData HOBPFNAPCJN;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly RRObjectPrefabData GILALIMHAMG;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly RRObjectPrefabData OFFGOCIILNC;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x745A080", Offset = "0x7458C80", VA = "0x18745A080")]
	public static Guid PAOFOBHJCKK(string BGKKCEGMOKH)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7459FF0", Offset = "0x7458BF0", VA = "0x187459FF0")]
	public static RRObjectPrefabData FNLMKPBKOFK(MCEIIDDCFHJ ADFFEBFOCBD)
	{
		return default(RRObjectPrefabData);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7459FA0", Offset = "0x7458BA0", VA = "0x187459FA0")]
	public static RRObjectPrefabData FIMLFFMMAEL(MCEIIDDCFHJ ADFFEBFOCBD)
	{
		return default(RRObjectPrefabData);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x745A060", Offset = "0x7458C60", VA = "0x18745A060")]
	public static RRObjectPrefabData NNGILBBOMHI(Guid IEIMOIIMGDN)
	{
		return default(RRObjectPrefabData);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[DefaultMember("Item")]
public class INBEMIBMLGO : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly Dictionary<int, object> LLDJIJICLJF;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public Dictionary<int, object> JBDHCGELIFD
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x9574F0", Offset = "0x9560F0", VA = "0x1809574F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x745B7F0", Offset = "0x745A3F0", VA = "0x18745B7F0")]
	public INBEMIBMLGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x95A080", Offset = "0x958C80", VA = "0x18095A080")]
	public INBEMIBMLGO(Dictionary<int, object> LLDJIJICLJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x745B6C0", Offset = "0x745A2C0", VA = "0x18745B6C0")]
	public bool ALDLKJOOCIM(IMFODMGAGGC NKANGPLHEGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x33C1CB0", Offset = "0x33C08B0", VA = "0x1833C1CB0")]
	public void AHEKIFPJHGO<T>(IMFODMGAGGC NKANGPLHEGE, T MPDLOLIOGJL, [Optional] T NBKBMLNEBHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x33C21E0", Offset = "0x33C0DE0", VA = "0x1833C21E0")]
	public void BGCBAJHAPLO<T>(IMFODMGAGGC NKANGPLHEGE, T MPDLOLIOGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x745B720", Offset = "0x745A320", VA = "0x18745B720")]
	public void BLAPNJAELFA(IMFODMGAGGC NKANGPLHEGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x745B780", Offset = "0x745A380", VA = "0x18745B780", Slot = "4")]
	public object Clone()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum IMFODMGAGGC : byte
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
public struct DGHLPIMIBBH<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly IMFODMGAGGC NKANGPLHEGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public readonly T NBKBMLNEBHK;

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x4E5A760", Offset = "0x4E59360", VA = "0x184E5A760")]
	public DGHLPIMIBBH(IMFODMGAGGC NKANGPLHEGE, T NBKBMLNEBHK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x630CEC0", Offset = "0x630BAC0", VA = "0x18630CEC0")]
	public static DGHLPIMIBBH<T> NIBCGLOMJGK(IMFODMGAGGC NKANGPLHEGE)
	{
		return default(DGHLPIMIBBH<T>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x630CD20", Offset = "0x630B920", VA = "0x18630CD20")]
	public static DGHLPIMIBBH<T> NIBCGLOMJGK((IMFODMGAGGC key, T value) CEDOOEEEDCO)
	{
		return default(DGHLPIMIBBH<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(JGEDFBIBHMO))]
public struct JLHPGPMALFI : IEnumerable<object>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private class JGEDFBIBHMO : Dictionary<string, object>
	{
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private Dictionary<int, object> KNNHCEBFGKJ;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool NHPIKHBJFOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x1514220", Offset = "0x1512E20", VA = "0x181514220")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int PHJGKILIPGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x745B940", Offset = "0x745A540", VA = "0x18745B940")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x745B990", Offset = "0x745A590", VA = "0x18745B990")]
	public static JLHPGPMALFI EPPBBCFCJMI()
	{
		return default(JLHPGPMALFI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0xBDB470", Offset = "0xBDA070", VA = "0x180BDB470")]
	public JLHPGPMALFI([Optional] Dictionary<int, object> KNNHCEBFGKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x33FEB90", Offset = "0x33FD790", VA = "0x1833FEB90")]
	public void GFCJDEIJPEO<T>(DGHLPIMIBBH<T> NKANGPLHEGE, T? MPDLOLIOGJL) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x33FE860", Offset = "0x33FD460", VA = "0x1833FE860")]
	public void GFCJDEIJPEO<T>((DGHLPIMIBBH<T> key, T value) NKDOOAOOPNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x33FE880", Offset = "0x33FD480", VA = "0x1833FE880")]
	public void GFCJDEIJPEO<T>(DGHLPIMIBBH<T> NKANGPLHEGE, T MPDLOLIOGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x745BAF0", Offset = "0x745A6F0", VA = "0x18745BAF0")]
	public void NKJHPILHNAJ(JLHPGPMALFI CGPMLCFDDHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x745BA70", Offset = "0x745A670", VA = "0x18745BA70")]
	private void HGFFJCPBDPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x33FF3E0", Offset = "0x33FDFE0", VA = "0x1833FF3E0")]
	public bool JLHCCLDIOMP<T>(DGHLPIMIBBH<T> NKANGPLHEGE, [Out] T MPDLOLIOGJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x33FF2D0", Offset = "0x33FDED0", VA = "0x1833FF2D0")]
	public bool JLHCCLDIOMP<T>(IMFODMGAGGC NKANGPLHEGE, [Out] T MPDLOLIOGJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x33FE6F0", Offset = "0x33FD2F0", VA = "0x1833FE6F0")]
	public T EMGPDKBHHCM<T>(DGHLPIMIBBH<T> NKANGPLHEGE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x33FE6B0", Offset = "0x33FD2B0", VA = "0x1833FE6B0")]
	public bool ALDLKJOOCIM<T>(DGHLPIMIBBH<T> NKANGPLHEGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x745B890", Offset = "0x745A490", VA = "0x18745B890")]
	public bool ALDLKJOOCIM(IMFODMGAGGC NKANGPLHEGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x33FE6D0", Offset = "0x33FD2D0", VA = "0x1833FE6D0")]
	public void BLAPNJAELFA<T>(DGHLPIMIBBH<T> NKANGPLHEGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x745B8F0", Offset = "0x745A4F0", VA = "0x18745B8F0")]
	public void BLAPNJAELFA(IMFODMGAGGC NKANGPLHEGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0xBDB480", Offset = "0xBDA080", VA = "0x180BDB480")]
	public Dictionary<int, object> GOIAKHMKCGI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x745BA10", Offset = "0x745A610", VA = "0x18745BA10", Slot = "4")]
	public IEnumerator<object> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x745BCC0", Offset = "0x745A8C0", VA = "0x18745BCC0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public enum KKABOFINALJ
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
	PhysicsModelComponents
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface EEPNIHLMHOE
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public enum OEMOHEMCMCK
	{
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		Entity,
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		Prefab
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	LocalId IGDDOGNFOCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	RRObjectPrefabData OLBHDAHEKIA
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PNHPJDKOLFD(params string[] AJOBKLGCIIG);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CIADDJHMCAM(KKABOFINALJ IBENCIJLNLB, OEMOHEMCMCK GLPFCMCNEBI = OEMOHEMCMCK.Entity);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EGCGFACLOCM(Type ADFFEBFOCBD, ReadOnlySpan<byte> LLDJIJICLJF, int HDFMAHEALDM, OEMOHEMCMCK GLPFCMCNEBI = OEMOHEMCMCK.Entity);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NKPABHBACIG(Type ADFFEBFOCBD, OEMOHEMCMCK GLPFCMCNEBI = OEMOHEMCMCK.Entity);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void BOPHNKPDHAC(KKABOFINALJ IBENCIJLNLB, OEMOHEMCMCK GLPFCMCNEBI = OEMOHEMCMCK.Entity);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool OBGHIIAGKGG(KKABOFINALJ IBENCIJLNLB);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void ACCILAJDPON(bool CPCHHDCMBGG, OEMOHEMCMCK GLPFCMCNEBI = OEMOHEMCMCK.Entity);

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void ECNBDILNHOG();
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class DIHADMIFKNF
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x745AA40", Offset = "0x7459640", VA = "0x18745AA40")]
	public static bool IAHNKPLMENH(this EEPNIHLMHOE HJIAOGEIAJO, KKABOFINALJ EFKBGLNDIKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x745ACA0", Offset = "0x74598A0", VA = "0x18745ACA0")]
	public static void JPPIDOAGECM(this EEPNIHLMHOE HJIAOGEIAJO, EEPNIHLMHOE.OEMOHEMCMCK GLPFCMCNEBI = EEPNIHLMHOE.OEMOHEMCMCK.Entity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x745AC40", Offset = "0x7459840", VA = "0x18745AC40")]
	public static void JJNMMDJCFCO(this EEPNIHLMHOE HJIAOGEIAJO, EEPNIHLMHOE.OEMOHEMCMCK GLPFCMCNEBI = EEPNIHLMHOE.OEMOHEMCMCK.Entity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x31A3720", Offset = "0x31A2320", VA = "0x1831A3720")]
	public static void BKBMPIHCACC<T>(this EEPNIHLMHOE HJIAOGEIAJO, EEPNIHLMHOE.OEMOHEMCMCK GLPFCMCNEBI = EEPNIHLMHOE.OEMOHEMCMCK.Entity) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x30DD920", Offset = "0x30DC520", VA = "0x1830DD920")]
	public static void DGCAOHNNGLK<T>(this EEPNIHLMHOE HJIAOGEIAJO, EEPNIHLMHOE.OEMOHEMCMCK GLPFCMCNEBI = EEPNIHLMHOE.OEMOHEMCMCK.Entity) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x31A5430", Offset = "0x31A4030", VA = "0x1831A5430")]
	public static void GMGCLANEJDA<T>(this EEPNIHLMHOE HJIAOGEIAJO, bool LBIHOJANFDD, EEPNIHLMHOE.OEMOHEMCMCK GLPFCMCNEBI = EEPNIHLMHOE.OEMOHEMCMCK.Entity) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x31A3910", Offset = "0x31A2510", VA = "0x1831A3910")]
	public static void EGCGFACLOCM<T>(this EEPNIHLMHOE HJIAOGEIAJO, T MPDLOLIOGJL, EEPNIHLMHOE.OEMOHEMCMCK GLPFCMCNEBI = EEPNIHLMHOE.OEMOHEMCMCK.Entity) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x31A54A0", Offset = "0x31A40A0", VA = "0x1831A54A0")]
	public static void NKPABHBACIG<T>(this EEPNIHLMHOE HJIAOGEIAJO, EEPNIHLMHOE.OEMOHEMCMCK GLPFCMCNEBI = EEPNIHLMHOE.OEMOHEMCMCK.Entity) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x31A5680", Offset = "0x31A4280", VA = "0x1831A5680")]
	public static void PONMMMABHCG<T>(this EEPNIHLMHOE HJIAOGEIAJO, LocalId JKOPHJKJLOL, EEPNIHLMHOE.OEMOHEMCMCK GLPFCMCNEBI = EEPNIHLMHOE.OEMOHEMCMCK.Entity) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x31A3760", Offset = "0x31A2360", VA = "0x1831A3760")]
	private static void EGCGFACLOCM<T>(this EEPNIHLMHOE HJIAOGEIAJO, Type ADFFEBFOCBD, T MPDLOLIOGJL, EEPNIHLMHOE.OEMOHEMCMCK GLPFCMCNEBI = EEPNIHLMHOE.OEMOHEMCMCK.Entity) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface DAGLOENMFJH
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	Entity DCAIFFNHBOF
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
public interface DELPGJANODF
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void Bake(EEPNIHLMHOE HJIAOGEIAJO);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface DOBJKAJCHGH
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LEAAOOBMPPN(GEDEGCEHLJI GMOJJMIJPJF);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KOOAAOLIGLG(GEDEGCEHLJI GMOJJMIJPJF);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface EOALDEGAJIB
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	ViewId KKOFHFCGCBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface PEPDCBAKMHG : EOALDEGAJIB, MADGPIEOEMP, JJJBBNHMIFL.NEEFIEJPFND
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AIMKJDEKJHN(ViewId NMBJJIACNGP, ViewId GONMHLNBOCC, Dictionary<int, object> FLHCIALOJPM, GEDEGCEHLJI MGIILDCJJIC);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface AOEICAANHOH : EOALDEGAJIB, JJJBBNHMIFL.NEEFIEJPFND
{
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AIMKJDEKJHN(FCEEFAMELLC KOIBCEOILEL, Vector3 DDPAPHFNFJI, Quaternion CIDNHFONBIJ, Vector3 AHOEGMFCFON, bool KIJPGGCIJKC);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MKACLOBOGCI(Vector3 DDPAPHFNFJI, Quaternion CIDNHFONBIJ, Vector3 AHOEGMFCFON);

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JCGLDFHMCIJ(ViewId KOIBCEOILEL);

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CHOGAAHIMIG(bool DIHPPIAKHID);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CHHOBONOLDB(bool KBNJJFOODIG);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface MADGPIEOEMP : JJJBBNHMIFL.NEEFIEJPFND
{
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BBCDGADOJKP();
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface ILFFMBHNJPD
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NativeArray<Guid> BAMCHKBONGL(World CDEKECFBCAL, NativeArray<Entity> BMGAGFMALJB, Allocator LNBNGBBFCIG);
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
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		[RecRoom.DataLayer.Default("new quaternion(new float4(float.NaN))")]
		[RecRoom.DataLayer.Field(1)]
		public quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		[RecRoom.DataLayer.Field(2)]
		[RecRoom.DataLayer.Default("new float3(float.NaN)")]
		public float3 localPosition;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public readonly bool IsValid
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x745A4F0", Offset = "0x74590F0", VA = "0x18745A4F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x4AE9240", Offset = "0x4AE7E40", VA = "0x184AE9240")]
		public AuthoredLocalPoseData(quaternion localRotation, float3 localPosition)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x745A550", Offset = "0x7459150", VA = "0x18745A550")]
		public static RigidTransform NIBCGLOMJGK(AuthoredLocalPoseData poseData)
		{
			return default(RigidTransform);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x745A550", Offset = "0x7459150", VA = "0x18745A550")]
		public static AuthoredLocalPoseData NIBCGLOMJGK(RigidTransform pose)
		{
			return default(AuthoredLocalPoseData);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class OJOOMNGJEBG
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x745D8C0", Offset = "0x745C4C0", VA = "0x18745D8C0")]
	public static AuthoredLocalPoseData MNECKLFEOCG([In] this RigidTransform MPDLOLIOGJL)
	{
		return default(AuthoredLocalPoseData);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0xB17D80", Offset = "0xB16980", VA = "0x180B17D80")]
	public static RigidTransform PPBIEAGLOFF(this AuthoredLocalPoseData MPDLOLIOGJL)
	{
		return default(RigidTransform);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x745D890", Offset = "0x745C490", VA = "0x18745D890")]
	public static RigidTransform MIONLNLMBGN([In] this AuthoredLocalPoseData MPDLOLIOGJL)
	{
		return default(RigidTransform);
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[TypeManager.ForcedStableTypeHash(9088562008033959482uL)]
	[RecRoom.DataLayer.RRGuid("C26C4B4E-5EF3-4F81-87C8-FED8EAD37242")]
	[RecRoom.DataLayer.StableTypeHash(9088562008033959482uL, 0u)]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct AuthoredLocalUniformScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default(1f)]
		public float localUniformScale;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public readonly bool IsValid
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x745A570", Offset = "0x7459170", VA = "0x18745A570")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x271BA60", Offset = "0x271A660", VA = "0x18271BA60")]
		public AuthoredLocalUniformScaleData(float localUniformScale)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[RecRoom.DataLayer.StableTypeHash(10137300772124140051uL, 0u)]
	[TypeManager.ForcedStableTypeHash(10137300772124140051uL)]
	[RecRoom.DataLayer.RRGuid("7B1B8635-3FA9-4ADC-922B-3C25CE0C7E7D")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[CompilerGenerated]
	public struct AuthoredParentData : IComponentData, DAGLOENMFJH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public Entity parent;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xBDB480", Offset = "0xBDA080", VA = "0x180BDB480", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x147F1B0", Offset = "0x147DDB0", VA = "0x18147F1B0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x147F1B0", Offset = "0x147DDB0", VA = "0x18147F1B0")]
		public AuthoredParentData(Entity parent)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xB17D80", Offset = "0xB16980", VA = "0x180B17D80")]
		public static AuthoredParentData NIBCGLOMJGK(Entity entity)
		{
			return default(AuthoredParentData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x745A5D0", Offset = "0x74591D0", VA = "0x18745A5D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct APJFFLKCPLO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct OKGACCDBDOA : IComponentData
{
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(8594223769175916906uL)]
	[RecRoom.DataLayer.RRGuid("B9A63EF5-66A5-463C-8385-A7DC7CE137C3")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.StableTypeHash(8594223769175916906uL, 0u)]
	public struct ObjectBoardNodeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public NetworkGuid nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(2)]
		public NetworkGuid graphId;
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[RecRoom.DataLayer.RRGuid("B26EF01D-F674-4506-80B7-5345391A097E")]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[TypeManager.ForcedStableTypeHash(5933855128949143734uL)]
	public struct ReplicatedObjectActiveStatusData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default(true)]
		public bool active;
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[RecRoom.DataLayer.RRGuid("E9BA10A4-4EE9-431D-BD7F-FF2008ABFA03")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(16338184133650423946uL)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct ReplicatedObjectOwnedByPlayerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		[RecRoom.DataLayer.Default(-1)]
		[RecRoom.DataLayer.Field(1)]
		public int actorId;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct DDDFCEEFIMK : IComponentData
{
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[TypeManager.ForcedStableTypeHash(16223816226138460552uL)]
	[RecRoom.DataLayer.RRGuid("46C500A2-9991-4987-B1AA-66E5C3D8E371")]
	public struct ReplicatedObjectTag : IComponentData
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(17912083982325865811uL)]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	[RecRoom.DataLayer.RRGuid("5ED157AA-488F-453A-A986-594595B8D777")]
	public struct ReplicatorData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public Entity Target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		[RecRoom.DataLayer.Field(2)]
		[RecRoom.DataLayer.Default(false)]
		public bool NeedsCircuitUpdate;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000023")]
public struct HKHOKJOBOFO : IComponentData
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
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		[RecRoom.DataLayer.Default(10)]
		[RecRoom.DataLayer.Field(1)]
		public int count;
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[TypeManager.ForcedStableTypeHash(16379995002884076574uL)]
	[RecRoom.DataLayer.RRGuid("400790C1-E8D9-4779-A549-3780DAEC2FDF")]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	[CompilerGenerated]
	public struct ReplicatorPreallocatedObjectCountData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
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
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public Entity prefabRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		[RecRoom.DataLayer.Field(2)]
		[RecRoom.DataLayer.Default]
		public uint partId;

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x745AF20", Offset = "0x7459B20", VA = "0x18745AF20", Slot = "4")]
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
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		[SerializeField]
		private uint id;

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x10A34D0", Offset = "0x10A20D0", VA = "0x1810A34D0")]
		internal EntityPrefabPartId(uint HGEMPDBGGBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x9A3DB0", Offset = "0x9A29B0", VA = "0x1809A3DB0")]
		internal uint ENBINLJJKFK()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x1ECB340", Offset = "0x1EC9F40", VA = "0x181ECB340", Slot = "4")]
		public bool Equals(EntityPrefabPartId PELBNOCGOOJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x745AF70", Offset = "0x7459B70", VA = "0x18745AF70", Slot = "0")]
		public override bool Equals(object CFMCKCBBBKK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x10D73D0", Offset = "0x10D5FD0", VA = "0x1810D73D0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x1ECB2A0", Offset = "0x1EC9EA0", VA = "0x181ECB2A0", Slot = "5")]
		public int CompareTo(EntityPrefabPartId PELBNOCGOOJ)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public struct DMDCBKFIHBK : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public Entity MABMNACPLLH;
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
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		[RecRoom.DataLayer.Field(1)]
		[Config(null, 0)]
		[RecRoom.DataLayer.Default(KHFGJEJADIN.Children)]
		public KHFGJEJADIN collisionMode;
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[InternalBufferCapacity(0)]
	[TypeManager.ForcedStableTypeHash(14800424556151816553uL)]
	[RecRoom.DataLayer.RRGuid("55EAB643-95BB-4C3A-832C-798EBCD95AD5")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[CompilerGenerated]
	public struct ContainerNameBuffer : IBufferElementData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public byte data;
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[RecRoom.DataLayer.RRGuid("89708D57-D027-494A-A159-221E6C643B6B")]
	[RecRoom.DataLayer.StableTypeHash(13657791279235747653uL, 0u)]
	[ConfigGroup("Container", 0)]
	[TypeManager.ForcedStableTypeHash(13657791279235747653uL)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[CompilerGenerated]
	public struct ContainerNameData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		[Config(null, 0)]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public FixedString64Bytes name;
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[RecRoom.DataLayer.RRGuid("CA023286-E0F6-4DA9-A346-94E86B93977C")]
	[CompilerGenerated]
	[ConfigGroup("Physics", 0)]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	[TypeManager.ForcedStableTypeHash(13904209480152351845uL)]
	public struct PhysicsModelGrabbableModeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		[Config(null, 0)]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public GKJNGJEAINA grabbableMode;
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[ConfigGroup("Container", 0)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(16485879999901987510uL)]
	[RecRoom.DataLayer.StableTypeHash(16485879999901987510uL, 0u)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("84485C1B-18ED-4D4A-86A4-34CEED482615")]
	public struct NavMeshGenerationData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default(ILOIBFOGPCD.NavMeshGenerator)]
		[Config(null, 0)]
		public ILOIBFOGPCD mode;
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[ConfigGroup("Physics", 0)]
	[TypeManager.ForcedStableTypeHash(1954118413118190521uL)]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	[CompilerGenerated]
	[RecRoom.DataLayer.RRGuid("C5BCE8B3-6E69-41D4-921A-BE2E3E0A4DAB")]
	public struct PhysicsModelCollisionLayerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		[RecRoom.DataLayer.Default(LNEANCDCPBK.IsDynamicEnvironment)]
		[RecRoom.DataLayer.Field(1)]
		[Config(null, 0)]
		public LNEANCDCPBK collisionLayer;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public static class IMBFDGEABEI
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public enum CJINJDCFHEP
	{
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		Dynamic,
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		Static,
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		Enemy,
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		Vehicle
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public enum CEPODHOPOPP
	{
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		Environmental,
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		IgnoreStaticGeometry,
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		IgnoreOtherDynamic,
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		IgnorePlayers,
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		IgnoreMost,
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		Projectile
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x745B530", Offset = "0x745A130", VA = "0x18745B530")]
	public static (CJINJDCFHEP, CEPODHOPOPP) BLOINFPNJEC(this LNEANCDCPBK ONGOOIJKOLB)
	{
		return default((CJINJDCFHEP, CEPODHOPOPP));
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[ConfigGroup("Physics", 0)]
	[RecRoom.DataLayer.RRGuid("F63AA9EA-6191-4DE9-BB18-1F049F432124")]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(3, false)]
	[TypeManager.ForcedStableTypeHash(16455981537837065632uL)]
	public struct PhysicsModelFlagsData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		[Config(null, 0)]
		[RecRoom.DataLayer.Default(KOKMBHAEOFP.DEFAULT)]
		[RecRoom.DataLayer.Field(1)]
		public KOKMBHAEOFP flags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[TypeManager.ForcedStableTypeHash(1094837642118998916uL)]
	[ConfigGroup("Physics", 0)]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("B6D08147-6AEA-4270-BDC4-8CF68662318D")]
	[RecRoom.DataLayer.StableTypeHash(1094837642118998916uL, 0u)]
	public struct PhysicsModelMassOverrideData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		[Config(null, 0)]
		[RecRoom.DataLayer.Default(0f)]
		[RecRoom.DataLayer.Field(1)]
		public float mass;
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[RecRoom.DataLayer.RRGuid("D732BC3D-4F8D-4FDE-BDB2-88C095D973C2")]
	[RecRoom.DataLayer.StableTypeHash(1537567323754185605uL, 0u)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(1537567323754185605uL)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct CostumePieceParentCostumeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public Entity parentCostume;
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[RecRoom.DataLayer.StableTypeHash(5115014870530256079uL, 0u)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("36A2D516-8596-4794-BEAE-40BECA68C798")]
	[TypeManager.ForcedStableTypeHash(5115014870530256079uL)]
	[CompilerGenerated]
	public struct CostumePieceSlotIndexData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public int slotIndex;
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[TypeManager.ForcedStableTypeHash(10518841812724430444uL)]
	[RecRoom.DataLayer.RRGuid("17799917-98EE-4D9A-A8D1-B0BE5F7316E3")]
	[CompilerGenerated]
	public struct InventionIdData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default(0L)]
		public long inventionId;

		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public const long INVALID_INVENTION_ID = 0L;

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0xB17D80", Offset = "0xB16980", VA = "0x180B17D80")]
		public static InventionIdData NIBCGLOMJGK(long value)
		{
			return default(InventionIdData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x745B880", Offset = "0x745A480", VA = "0x18745B880")]
		public readonly bool LJGBHIKBOLF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x722C860", Offset = "0x722B460", VA = "0x18722C860")]
		public static bool LJGBHIKBOLF(long inventionId)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[RecRoom.DataLayer.RRGuid("629F0A56-C478-4353-BBDA-8A8BB5FEE478")]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	[CompilerGenerated]
	[RecRoom.DataLayer.TombstonedFields(new int[] { 1 })]
	[TypeManager.ForcedStableTypeHash(14338988155392421373uL)]
	public struct InventionInstanceIdData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		[RecRoom.DataLayer.Field(2)]
		[RecRoom.DataLayer.Default]
		public NetworkGuid instanceId;

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x103AC90", Offset = "0x1039890", VA = "0x18103AC90")]
		public static InventionInstanceIdData NIBCGLOMJGK(Guid value)
		{
			return default(InventionInstanceIdData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[RuntimeOnly]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[TypeManager.ForcedStableTypeHash(12111354511484844847uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.StableTypeHash(12111354511484844847uL, 0u)]
	[RecRoom.DataLayer.RRGuid("A3B27452-BD6C-43B2-BAFF-CF885EB1608B")]
	public struct ParentData : IComponentData, DAGLOENMFJH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public Entity parent;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0xBDB480", Offset = "0xBDA080", VA = "0x180BDB480", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x147F1B0", Offset = "0x147DDB0", VA = "0x18147F1B0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x147F1B0", Offset = "0x147DDB0", VA = "0x18147F1B0")]
		public ParentData(Entity parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0xB17D80", Offset = "0xB16980", VA = "0x180B17D80")]
		public static implicit operator ParentData(Entity entity)
		{
			return default(ParentData);
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000039")]
public struct OIOHIBKDEKM : IComponentData
{
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[RecRoom.DataLayer.StableTypeHash(1950029632769634832uL, 0u)]
	[RecRoom.DataLayer.RRGuid("c886150a-7231-4cc5-a2b2-f222500e6960")]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[TypeManager.ForcedStableTypeHash(1950029632769634832uL)]
	public struct SiblingSortOrderData : IEquatable<SiblingSortOrderData>, IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public KNNDLIBEPCE order;

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0xB17D80", Offset = "0xB16980", VA = "0x180B17D80")]
		public static SiblingSortOrderData NIBCGLOMJGK(KNNDLIBEPCE value)
		{
			return default(SiblingSortOrderData);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x745D150", Offset = "0x745BD50", VA = "0x18745D150", Slot = "4")]
		public bool Equals(SiblingSortOrderData other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[TypeManager.ForcedStableTypeHash(6217116203744017593uL)]
	[RecRoom.DataLayer.RRGuid("46CEA601-8AA7-423D-B1EA-EEABAE73413F")]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct InteractionFilterAllTagsData : IComponentData, DAGLOENMFJH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public Entity allTags;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xBDB480", Offset = "0xBDA080", VA = "0x180BDB480", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x147F1B0", Offset = "0x147DDB0", VA = "0x18147F1B0", Slot = "5")]
			set
			{
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(6215026851838101933uL)]
	[RecRoom.DataLayer.RRGuid("49CEFD0F-3A38-4A9B-835E-10B4C2D08392")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct InteractionFilterAnyTagsData : IComponentData, DAGLOENMFJH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public Entity anyTags;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0xBDB480", Offset = "0xBDA080", VA = "0x180BDB480", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x147F1B0", Offset = "0x147DDB0", VA = "0x18147F1B0", Slot = "5")]
			set
			{
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("11CE457F-4366-4AAD-B7E3-28D82B4FAFCF")]
	[TypeManager.ForcedStableTypeHash(6780642047612598977uL)]
	[CompilerGenerated]
	public struct InteractionFilterEnabledData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		[RecRoom.DataLayer.Default(AOMEDNFEJFK.Disabled)]
		[RecRoom.DataLayer.Field(1)]
		public AOMEDNFEJFK filterMode;
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[RecRoom.DataLayer.RRGuid("F7789094-7D82-4D27-B805-2CC1B8C0A538")]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[TypeManager.ForcedStableTypeHash(6642820932987006861uL)]
	public struct InteractionFilterEntityRefData : IComponentData, DAGLOENMFJH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public Entity filterEntity;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0xBDB480", Offset = "0xBDA080", VA = "0x180BDB480", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x147F1B0", Offset = "0x147DDB0", VA = "0x18147F1B0", Slot = "5")]
			set
			{
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[CompilerGenerated]
	[RecRoom.DataLayer.RRGuid("C7E95AF7-DB7D-4432-8DAA-8F36EC6C4308")]
	[TypeManager.ForcedStableTypeHash(15467295871228743847uL)]
	public struct InteractionFilterNoneTagsData : IComponentData, DAGLOENMFJH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public Entity noneTags;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0xBDB480", Offset = "0xBDA080", VA = "0x180BDB480", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x147F1B0", Offset = "0x147DDB0", VA = "0x18147F1B0", Slot = "5")]
			set
			{
			}
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	[RecRoom.DataLayer.StableTypeHash(15012400804589552708uL, 0u)]
	[RecRoom.DataLayer.RRGuid("007F8815-C87C-4E6B-BC56-3BA0C4888E3D")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[TypeManager.ForcedStableTypeHash(15012400804589552708uL)]
	public struct OverrideObjectNetworkIdData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public uint networkIdBits;
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	[RecRoom.DataLayer.RRGuid("30228348-77DF-48F6-B2EF-B0883D3E10CA")]
	[TypeManager.ForcedStableTypeHash(4540375434353162791uL)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct MakerPenHeldData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public bool makerPenHeld;
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[TypeManager.ForcedStableTypeHash(8459715919607487693uL)]
	[CompilerGenerated]
	[ConfigGroup("Object", 0)]
	[RecRoom.DataLayer.NetworkComponent(6, false)]
	[RecRoom.DataLayer.RRGuid("FB9853D6-6231-43FD-A754-00105DC30880")]
	public struct ObjectPolicyData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		[RecRoom.DataLayer.Default("new ScaleRestriction(1,1)")]
		[RecRoom.DataLayer.Field(2)]
		public CFJKLKGPMMA scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		[RecRoom.DataLayer.Field(3)]
		[Config(null, 0)]
		[RecRoom.DataLayer.Default("ObjectPolicyUserConfigurableFlags.DEFAULT")]
		public MBIGAFAMMKG userConfigurableFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		[RecRoom.DataLayer.Default(EEAIKJADKBJ.Default)]
		[Config(null, 0)]
		[RecRoom.DataLayer.Field(4)]
		public EEAIKJADKBJ circuitsTransformBehavior;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default("ObjectPolicyEnumFlags.Default")]
		public ILNIKCMEHIN flags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[TypeManager.ForcedStableTypeHash(17708500325183871236uL)]
	[RecRoom.DataLayer.RRGuid("617A903E-C2C2-467C-A138-287FDB487645")]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.StableTypeHash(17708500325183871236uL, 0u)]
	public struct PlayerScopeData : IComponentData, DAGLOENMFJH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public Entity playerScope;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public Entity Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xBDB480", Offset = "0xBDA080", VA = "0x180BDB480", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x147F1B0", Offset = "0x147DDB0", VA = "0x18147F1B0", Slot = "5")]
			set
			{
			}
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0xB17D80", Offset = "0xB16980", VA = "0x180B17D80")]
		public static PlayerScopeData NIBCGLOMJGK(Entity entity)
		{
			return default(PlayerScopeData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[TypeManager.ForcedStableTypeHash(16642773407304133105uL)]
	[ConfigGroup("Physics", 0)]
	[RecRoom.DataLayer.StableTypeHash(16642773407304133105uL, 0u)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("F945B699-C9E5-4634-9F64-831484F4F3BD")]
	[CompilerGenerated]
	public struct PhysicsMaterialData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
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
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default(AELPFFMHMMC.None)]
		public AELPFFMHMMC flags;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool DynamicUVProjection
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x6944E40", Offset = "0x6943A40", VA = "0x186944E40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool PreventInvertedCreation
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x6944E50", Offset = "0x6943A50", VA = "0x186944E50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool NewBendLogic
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x745DE10", Offset = "0x745CA10", VA = "0x18745DE10")]
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
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public AIILLNJMIAK shapeType;
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
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public KNNDLIBEPCE order;

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xB17D80", Offset = "0xB16980", VA = "0x180B17D80")]
		public static SplinePointOrderData NIBCGLOMJGK(KNNDLIBEPCE value)
		{
			return default(SplinePointOrderData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[TypeManager.ForcedStableTypeHash(16368389834000856208uL)]
	[RecRoom.DataLayer.StableTypeHash(16368389834000856208uL, 0u)]
	[RecRoom.DataLayer.RRGuid("FCEE3BCD-9C10-4BF4-954A-0DCFE8810227")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[CompilerGenerated]
	public struct SplinePointParentData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public Entity spline;
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.StableTypeHash(18095612727592564636uL, 0u)]
	[CompilerGenerated]
	[RecRoom.DataLayer.RRGuid("5A6D38A4-1A58-4EB4-9C1B-06ADA0D44AFA")]
	[TypeManager.ForcedStableTypeHash(18095612727592564636uL)]
	public struct SplinePointPositionData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public float3 localPosition;
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[TypeManager.ForcedStableTypeHash(1429513518619209486uL)]
	[RecRoom.DataLayer.StableTypeHash(1429513518619209486uL, 0u)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[CompilerGenerated]
	[RecRoom.DataLayer.RRGuid("433F66B6-CC1C-4A8A-BF73-2B797440A8DB")]
	public struct SplinePointRotationData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default("new quaternion(0, 0, 0, 1f)")]
		public quaternion localRotation;
	}
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[TypeManager.ForcedStableTypeHash(1238044349990854547uL)]
	[RecRoom.DataLayer.RRGuid("04CA3CCE-F121-4B5B-BC56-FE8E9C77F0F4")]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.StableTypeHash(1238044349990854547uL, 0u)]
	public struct SplinePointScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		[RecRoom.DataLayer.Default("new float3(1)")]
		[RecRoom.DataLayer.Field(1)]
		public float3 localScale;
	}
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[RecRoom.DataLayer.StableTypeHash(4657247877648983868uL, 0u)]
	[TypeManager.ForcedStableTypeHash(4657247877648983868uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.RRGuid("E0610986-0F8F-494A-8C6E-8A2D2491B088")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct SplineShapeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public BGBHOGOFFCI parameters;
	}
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	[RecRoom.DataLayer.RRGuid("73C344D9-D535-4753-9D9A-B6DEDE4079B0")]
	[TypeManager.ForcedStableTypeHash(12332323170023439017uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.TombstonedFields(new int[] { 1 })]
	[RecRoom.DataLayer.StableTypeHash(12332323170023439017uL, 0u)]
	public struct OMShapeContainerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		[RecRoom.DataLayer.Field(2)]
		[RecRoom.DataLayer.Default(true)]
		public bool canModifyWithCircuits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		[RecRoom.DataLayer.Default(true)]
		[RecRoom.DataLayer.Field(3)]
		public bool optimizedCollidersEnabled;
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	[CompilerGenerated]
	[RecRoom.DataLayer.RRGuid("2B5C4208-9113-4F65-B3A6-18EAE1FF3937")]
	[TypeManager.ForcedStableTypeHash(17673274643717888315uL)]
	public struct SerializedDataLayerVersionData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public int version;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[Flags]
[RecRoom.DataLayer.Range(BOKJMHLAGIM.MIN, BOKJMHLAGIM.ALL)]
[RecRoom.DataLayer.RRGuid("CC657074-87FD-47F7-A7B0-F5CCE922A9D0")]
public enum BOKJMHLAGIM
{
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	IsAllowed = 1,
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	UseDefaultVisualEffects = 2,
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	DEFAULT = 2,
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	ALL = 3,
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	MAX = 3
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[RecRoom.DataLayer.RRGuid("34BA53CB-16FB-45DB-AA25-293CE7C8DAE4")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(5328722791392374178uL)]
	public struct ToolCleanupSettingsData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		[RecRoom.DataLayer.Default(15f)]
		[RecRoom.DataLayer.Field(1)]
		public float delay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		[RecRoom.DataLayer.Field(2)]
		[RecRoom.DataLayer.Default(BOKJMHLAGIM.UseDefaultVisualEffects)]
		public BOKJMHLAGIM toolCleanupFlags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[TypeManager.ForcedStableTypeHash(13768238190614302474uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.RRGuid("48C72ABE-383D-45C6-9610-773F2B4F84C6")]
	[RecRoom.DataLayer.TombstonedFields(new int[] { 2, 3 })]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	public struct ToolCleanupStatusData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public float cleanupStartTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		[RecRoom.DataLayer.Field(4)]
		[RecRoom.DataLayer.Default]
		public KGJBIIODIFF statusFlags;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
[Flags]
[RecRoom.DataLayer.Range(KGJBIIODIFF.None, KGJBIIODIFF.ALL)]
[RecRoom.DataLayer.RRGuid("E63050BA-D087-4027-99F8-4AFDEA229CD8")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
public enum KGJBIIODIFF
{
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	ForceCleanup = 1,
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	CleanupDone = 2,
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	CleanupPaused = 4,
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	ALL = 7,
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	MAX = 7
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	[TypeManager.ForcedStableTypeHash(463077377357487319uL)]
	[RecRoom.DataLayer.RRGuid("021E8703-AAFD-4965-8C38-FF86663126D2")]
	[CompilerGenerated]
	public struct LocalDeformableScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		[RecRoom.DataLayer.Default("new float3(1)")]
		[RecRoom.DataLayer.Field(1)]
		public float3 localDeformationScale;

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x271DD40", Offset = "0x271C940", VA = "0x18271DD40")]
		public LocalDeformableScaleData(float3 scale)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.StableTypeHash(1369925932270831712uL, 0u)]
	[TypeManager.ForcedStableTypeHash(1369925932270831712uL)]
	[RecRoom.DataLayer.RRGuid("38AA9F1D-FD16-4B56-917C-3341D0EB1DF2")]
	public struct LocalPoseData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		[RecRoom.DataLayer.Default("new quaternion(0,0,0,1)")]
		[RecRoom.DataLayer.Field(1)]
		public quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(2)]
		public float3 localPosition;

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x4AE9240", Offset = "0x4AE7E40", VA = "0x184AE9240")]
		public LocalPoseData(quaternion localRotation, float3 localPosition)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x745A550", Offset = "0x7459150", VA = "0x18745A550")]
		public static RigidTransform NIBCGLOMJGK(LocalPoseData poseData)
		{
			return default(RigidTransform);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x745A550", Offset = "0x7459150", VA = "0x18745A550")]
		public static LocalPoseData NIBCGLOMJGK(RigidTransform pose)
		{
			return default(LocalPoseData);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public static class MHLCCFIGION
{
	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x745D640", Offset = "0x745C240", VA = "0x18745D640")]
	public static LocalPoseData AJLNBCOOCCP([In] this RigidTransform MPDLOLIOGJL)
	{
		return default(LocalPoseData);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x745D670", Offset = "0x745C270", VA = "0x18745D670")]
	public static RigidTransform MIONLNLMBGN([In] this LocalPoseData MPDLOLIOGJL)
	{
		return default(RigidTransform);
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(2720902521635056246uL)]
	[RecRoom.DataLayer.RRGuid("0E9FADE9-751A-4A53-B455-4F8EA675754D")]
	[RecRoom.DataLayer.StableTypeHash(2720902521635056246uL, 0u)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct LocalUniformScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		[RecRoom.DataLayer.Default(1f)]
		[RecRoom.DataLayer.Field(1)]
		public float localUniformScale;
	}
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[RecRoom.DataLayer.RRGuid("F01774C0-98E7-491E-AAA5-85B64AFFA182")]
	[RecRoom.DataLayer.StableTypeHash(5730545663584378555uL, 0u)]
	[TypeManager.ForcedStableTypeHash(5730545663584378555uL)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[CompilerGenerated]
	public struct TransformFlagsData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public HCIBANBNEEL transformHint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		[RecRoom.DataLayer.Field(2)]
		[RecRoom.DataLayer.Default]
		public MDHOEMALAKC transformPriority;
	}
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[RecRoom.DataLayer.DoNotGenerateComponentProperties]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(12583036596830542024uL)]
	[RecRoom.DataLayer.RRGuid("392BF0C9-F464-491A-8725-E4B5E5C4ECD4")]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	public struct RRObjectPrefabData : ISharedComponentData, IEquatable<RRObjectPrefabData>, IComparable<RRObjectPrefabData>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public MCEIIDDCFHJ prefabType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		[RecRoom.DataLayer.Field(2)]
		[RecRoom.DataLayer.Default]
		public Guid prefabGuid;

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x745DD00", Offset = "0x745C900", VA = "0x18745DD00")]
		public RRObjectPrefabData(Guid prefabGuid, MCEIIDDCFHJ prefabType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x745DC00", Offset = "0x745C800", VA = "0x18745DC00", Slot = "4")]
		public readonly bool Equals(RRObjectPrefabData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x745DB40", Offset = "0x745C740", VA = "0x18745DB40", Slot = "0")]
		public override readonly bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x745DD10", Offset = "0x745C910", VA = "0x18745DD10")]
		public static bool operator ==(RRObjectPrefabData a, RRObjectPrefabData b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x745AEA0", Offset = "0x7459AA0", VA = "0x18745AEA0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x745DA70", Offset = "0x745C670", VA = "0x18745DA70", Slot = "5")]
		public readonly int CompareTo(RRObjectPrefabData other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x745DC60", Offset = "0x745C860", VA = "0x18745DC60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("FF90B503-A0B5-4B3D-BACF-046FA1456FBD")]
	[TypeManager.ForcedStableTypeHash(17550159503907726442uL)]
	[CompilerGenerated]
	public struct ReferenceGroupKindData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public GDGOOJEEKEA kind;
	}
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("2C78EEBE-6DD9-44FF-A70D-6C2EE9BB8FB3")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(18363292822319307914uL)]
	public struct ReferenceGroupOwnerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public Entity owner;
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[TypeManager.ForcedStableTypeHash(11947588904347318594uL)]
	[RecRoom.DataLayer.RRGuid("177498E9-83A6-4C2E-A8C1-B1951B47E74D")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[CompilerGenerated]
	public struct ReferenceGroupReferenceBuffer : IBufferElementData, DAGLOENMFJH, IEquatable<ReferenceGroupReferenceBuffer>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public Entity reference;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public Entity Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0xBDB480", Offset = "0xBDA080", VA = "0x180BDB480", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x147F1B0", Offset = "0x147DDB0", VA = "0x18147F1B0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x745DE00", Offset = "0x745CA00", VA = "0x18745DE00", Slot = "6")]
		public bool Equals(ReferenceGroupReferenceBuffer other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x745DD70", Offset = "0x745C970", VA = "0x18745DD70", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x9A3DB0", Offset = "0x9A29B0", VA = "0x1809A3DB0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005C")]
public struct LHLFCIPGCPK : IEqualityComparer<ReferenceGroupReferenceBuffer>
{
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public static LHLFCIPGCPK EPMIHDCFDJH;

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x745D620", Offset = "0x745C220", VA = "0x18745D620", Slot = "4")]
	public bool Equals(ReferenceGroupReferenceBuffer MDFKHKOGFDI, ReferenceGroupReferenceBuffer ELJEANFLEPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0xC23D30", Offset = "0xC22930", VA = "0x180C23D30", Slot = "5")]
	public int GetHashCode(ReferenceGroupReferenceBuffer CFMCKCBBBKK)
	{
		return default(int);
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(17466046755328781668uL)]
	[InternalBufferCapacity(0)]
	[RecRoom.DataLayer.RRGuid("DE12A401-BD29-4B00-A629-7EFBECEDCFDF")]
	public struct AuthoredUserTagReferenceBuffer : NMLHJEBCPPA, IBufferElementData, DAGLOENMFJH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public Entity Child;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0xBDB480", Offset = "0xBDA080", VA = "0x180BDB480", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x147F1B0", Offset = "0x147DDB0", VA = "0x18147F1B0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x147F1B0", Offset = "0x147DDB0", VA = "0x18147F1B0")]
		public AuthoredUserTagReferenceBuffer(Entity entity)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0xB17D80", Offset = "0xB16980", VA = "0x180B17D80")]
		public static AuthoredUserTagReferenceBuffer NIBCGLOMJGK(Entity entity)
		{
			return default(AuthoredUserTagReferenceBuffer);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public interface NMLHJEBCPPA : IBufferElementData, DAGLOENMFJH
{
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	[RecRoom.DataLayer.RRGuid("00B7CB5E-4C0C-4D2C-AC95-78529EE58768")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(12148147190301245780uL)]
	public struct PersistentUserTagData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public FixedList32Bytes<int> tags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		[RecRoom.DataLayer.Default(false)]
		[RecRoom.DataLayer.Field(2)]
		public bool initalizedDefaults;
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	[RecRoom.DataLayer.RRGuid("80D85A55-B2F6-4860-A851-62973DC10940")]
	[SwatchPrimaryKey]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[TypeManager.ForcedStableTypeHash(1859693175312uL)]
	[RecRoom.DataLayer.StableTypeHash(1859693175312uL, 0u)]
	public struct UserTagNameData : IComponentData, IEquatable<UserTagNameData>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public FixedString32Bytes Value;

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x745DF40", Offset = "0x745CB40", VA = "0x18745DF40")]
		public UserTagNameData(string value)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x745DF00", Offset = "0x745CB00", VA = "0x18745DF00")]
		public static UserTagNameData NIBCGLOMJGK(string value)
		{
			return default(UserTagNameData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x745DE20", Offset = "0x745CA20", VA = "0x18745DE20", Slot = "4")]
		public bool Equals(UserTagNameData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x745DE50", Offset = "0x745CA50", VA = "0x18745DE50", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x745DEF0", Offset = "0x745CAF0", VA = "0x18745DEF0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[InternalBufferCapacity(0)]
	[RecRoom.DataLayer.RRGuid("1E609F72-38C4-433D-BB17-B718F89DF446")]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[TypeManager.ForcedStableTypeHash(2039749658960193818uL)]
	public struct UserTagReferenceBuffer : NMLHJEBCPPA, IBufferElementData, DAGLOENMFJH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public Entity Child;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0xBDB480", Offset = "0xBDA080", VA = "0x180BDB480", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x147F1B0", Offset = "0x147DDB0", VA = "0x18147F1B0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x147F1B0", Offset = "0x147DDB0", VA = "0x18147F1B0")]
		public UserTagReferenceBuffer(Entity entity)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0xB17D80", Offset = "0xB16980", VA = "0x180B17D80")]
		public static UserTagReferenceBuffer NIBCGLOMJGK(Entity entity)
		{
			return default(UserTagReferenceBuffer);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[RecRoom.DataLayer.RRGuid("C36DDF08-CA52-4E33-8078-2F6E915D4FDA")]
	[ConfigGroup("Visual", 0)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(1591066774816564574uL)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.StableTypeHash(1591066774816564574uL, 0u)]
	public struct StandardRenderableVisualData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		[Config(null, 0)]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public NECIPBBCOII color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		[RecRoom.DataLayer.Field(2)]
		[Config(null, 0)]
		[RecRoom.DataLayer.Default]
		public GDJFDDEMAEB material;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		[Config(null, 0)]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(3)]
		public float uvScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		[RecRoom.DataLayer.Field(4)]
		[RecRoom.DataLayer.Default]
		[Config(null, 0)]
		public float3 uvOffset;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
[RecRoom.DataLayer.RRGuid("6B598497-D68A-4CC9-9D41-09EF6B966499")]
[RecRoom.DataLayer.Range(EEAIKJADKBJ.NONE, EEAIKJADKBJ.COUNT)]
[RecRoom.DataLayer.NetworkEnum(1, false)]
public enum EEAIKJADKBJ
{
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	NONE = 0,
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	[Config("Default (can transform roots, children are static)", 0)]
	Default = 1,
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	[Config("Can Transform (chips like SetPosition can modify)", 0)]
	CircuitsCanTransform = 2,
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	[Config("Always Static (chips cannot modify transform)", 0)]
	AlwaysStatic = 3,
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	COUNT = 4,
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	MAX = 4
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
[RecRoom.DataLayer.RRGuid("17517E1A-CF1A-48C9-B6A5-F9E42C1B9E96")]
[RecRoom.DataLayer.Range(0, 4)]
[RecRoom.DataLayer.NetworkEnum(1, false)]
public enum JHJICKNHEEE
{
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	Box = 1,
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	Sphere = 2,
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	Capsule = 3,
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	Mesh = 4,
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	COUNT = 5,
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	MAX = 4
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
[Flags]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.RRGuid("A13F5102-9259-42B9-B782-BB7CC33A0C4F")]
[RecRoom.DataLayer.Range(PFGLGJPJAIP.NONE, PFGLGJPJAIP.ALL)]
public enum PFGLGJPJAIP
{
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	NONE = 0,
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	Object = 1,
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	Player = 2,
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	Projectile = 4,
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	Vehicle = 8,
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	ALL = 0xF
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
[RecRoom.DataLayer.NetworkEnum(2, false)]
[RecRoom.DataLayer.Range(0, 127)]
[RecRoom.DataLayer.RRGuid("F843A776-E042-43B7-8167-0C7A421062F8")]
public enum LNEANCDCPBK : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	[@Tooltip("Indicating it can be walked on and moved")]
	[Config("Dynamic (Environment)", 0)]
	IsDynamicEnvironment = 0,
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	[Config("Dynamic", -1)]
	IsDynamic = 10,
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	[Config("Dynamic (Ignore Static Geometry)", 0)]
	IsDynamicIgnoreStaticGeometry = 11,
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	[Config("Dynamic (Ignore Other Dynamic)", 0)]
	IsDynamicIgnoreOtherDynamic = 12,
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	[Config("Dynamic (Ignore Players)", 0)]
	IsDynamicIgnorePlayers = 13,
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	[Config("Dynamic (Ignore Most)", 0)]
	IsDynamicIgnoreMost = 14,
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	[Config("Enemy Collision", 0)]
	IsEnemyCollision = 30,
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	[Config("Enemy Projectile", 0)]
	IsEnemyProjectile = 31,
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	[Config("Vehicle Physics", 0)]
	IsVehicleCollision = 40,
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	[ConfigIgnore]
	STATIC = 100,
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	[ConfigIgnore]
	DECORATION = 101,
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	MAX = 127
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
[RecRoom.DataLayer.RRGuid("9ADF7A0D-D808-48A7-BFCB-3272FB5D8A52")]
[RecRoom.DataLayer.NetworkEnum(2, false)]
[RecRoom.DataLayer.Range(KHFGJEJADIN.Off, KHFGJEJADIN.COUNT)]
public enum KHFGJEJADIN : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	Off = 0,
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	Children = 1,
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	Hull = 2,
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	COUNT = 3,
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	MAX = 2
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
[RecRoom.DataLayer.RRGuid("3B156405-5769-4DB2-87EA-2B846AC4E584")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.Range(0, 2)]
public enum AIILLNJMIAK
{
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	Primitive = 1,
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	Spline = 2,
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	COUNT = 3,
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	MAX = 2
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
[RecRoom.DataLayer.RRGuid("61EFE94A-235A-4281-B938-1A5BE32A18B1")]
[RecRoom.DataLayer.NetworkEnum(2, false)]
[RecRoom.DataLayer.Range(GKJNGJEAINA.Pivot, GKJNGJEAINA.COUNT)]
public enum GKJNGJEAINA : byte
{
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	Pivot = 0,
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	Bounds = 1,
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	COUNT = 2,
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	MAX = 1
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.RRGuid("c0973732-e735-44cd-9727-a9a79bad01e3")]
[RecRoom.DataLayer.Range(AOMEDNFEJFK.EnabledForRole, AOMEDNFEJFK.DisabledForRole)]
public enum AOMEDNFEJFK : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	EnabledForRole,
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	DisabledForRole,
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	Disabled
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.RRGuid("7E7D5AA1-2EC9-488B-8AB2-703F13BCB8CF")]
[RecRoom.DataLayer.Range(ILOIBFOGPCD.NavMeshGenerator, ILOIBFOGPCD.NavMeshBlocker)]
public enum ILOIBFOGPCD
{
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	NavMeshGenerator = 0,
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	NavMeshIgnored = 1,
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	NavMeshBlocker = 2,
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	MAX = 2
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
[RecRoom.DataLayer.RRGuid("7B493897-FE06-4FC8-AB72-8B7BF5A313D3")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.Range(ILNIKCMEHIN.None, ILNIKCMEHIN.All)]
[Flags]
public enum ILNIKCMEHIN
{
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	All = 0x3FFF,
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	Default = 0x3FFF
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.Range(0, LNPHONEGEAD.COUNT)]
[RecRoom.DataLayer.RRGuid("4427686F-E636-4F43-91F7-6BC74DEC584E")]
public enum LNPHONEGEAD
{
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	SupportsRotation,
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	SupportsDeformation,
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	SupportsScaling,
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	SupportsMirroring,
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	SupportsCloning,
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	SupportsRecoloring,
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	CanDestroy,
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	CanSaveIntoInventions,
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	SupportsRespawn,
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	SupportsMerging,
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	SupportsSplitting,
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	SupportsKeys,
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	CanEditWithMakerPen,
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	DEPRECATED_IsGrabbable,
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public static class FIKPOBAMODG
{
	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x745B020", Offset = "0x7459C20", VA = "0x18745B020")]
	public static void BGCBAJHAPLO(this ILNIKCMEHIN HOHMEIEFKJJ, LNPHONEGEAD HMCMOIEJDMF, bool KOGJFECFIAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x745B000", Offset = "0x7459C00", VA = "0x18745B000")]
	public static bool AAFKDEDKPCE(this ILNIKCMEHIN HOHMEIEFKJJ, LNPHONEGEAD HMCMOIEJDMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0xC44A80", Offset = "0xC43680", VA = "0x180C44A80")]
	public static ILNIKCMEHIN LAMGHIFFGLG(this LNPHONEGEAD HMCMOIEJDMF)
	{
		return default(ILNIKCMEHIN);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
[RecRoom.DataLayer.Range(MBIGAFAMMKG.NONE, MBIGAFAMMKG.COUNT)]
[RecRoom.DataLayer.NetworkEnum(2, false)]
[RecRoom.DataLayer.RRGuid("E3C51303-32F0-4EF4-8A66-C814E323653D")]
[Flags]
public enum MBIGAFAMMKG
{
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	NONE = 0,
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	IsFrozen = 1,
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	IsGrabbable = 2,
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	COUNT = 3,
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	ALL = 3,
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	DEFAULT = 0
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
[RecRoom.DataLayer.Range(1000, 8000)]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.RRGuid("777AD204-3AC0-41CE-BDC0-894C5821B3B9")]
public enum MCEIIDDCFHJ
{
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	[Config("Container", 0)]
	Container = 1000,
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	[Config("Container", 0)]
	LegacyShapeContainer = 1001,
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	[Config("Container", 0)]
	CreationShapeContainer = 1002,
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	[Config("Container", 0)]
	CostumePieceShapeContainer = 1003,
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	[Config("Empty", 0)]
	Empty = 4000,
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	[Config("Legacy Box", 0)]
	Shape_Primitive_LegacyBox = 2000,
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	[Config("Sphere", 0)]
	Shape_Primitive_Sphere = 2001,
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	[Config("Cylinder", 0)]
	Shape_Primitive_Cylinder = 2002,
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	[Config("Legacy Wedge", 0)]
	Shape_Primitive_LegacyWedge = 2003,
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	[Config("Legacy Pyramid", 0)]
	Shape_Primitive_LegacyPyramid = 2004,
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	[Config("Trigger Volume Box", 0)]
	Shape_Primitive_TriggerVolumeBox = 2005,
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	[Config("Box", 0)]
	Shape_Primitive_Box = 2006,
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	[Config("Rounded Box", 0)]
	Shape_Primitive_RoundedBox = 2007,
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	[Config("Wedge", 0)]
	Shape_Primitive_Wedge = 2008,
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	[Config("Pyramid", 0)]
	Shape_Primitive_Pyramid = 2009,
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	[Config("Half Sphere", 0)]
	Shape_Primitive_HalfSphere = 2010,
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	[Config("Cone", 0)]
	Shape_Primitive_Cone = 2011,
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	[Config("Pipe", 0)]
	Shape_Primitive_Pipe = 2012,
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	[Config("Donut", 0)]
	Shape_Primitive_Donut = 2013,
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	[Config("Half Pipe", 0)]
	Shape_Primitive_HalfPipe = 2014,
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	[Config("Diamond", 0)]
	Shape_Primitive_Diamond = 2015,
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	[Config("Mound", 0)]
	Shape_Primitive_Mound = 2016,
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	[Config("Cube (Simple)", 0)]
	Shape_Primitive_ADVANCED_Cube = 2017,
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	[Config("Sphere (Simple)", 0)]
	Shape_Primitive_ADVANCED_Sphere = 2018,
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	[Config("Cylinder (Simple)", 0)]
	Shape_Primitive_ADVANCED_Cylinder = 2019,
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	[Config("Cone (Simple)", 0)]
	Shape_Primitive_ADVANCED_Cone = 2020,
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	[Config("Pyramid (Simple)", 0)]
	Shape_Primitive_ADVANCED_Pyramid = 2021,
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	[Config("Octagon (Simple)", 0)]
	Shape_Primitive_ADVANCED_Octagon = 2022,
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	[Config("Triangle (Simple)", 0)]
	Shape_Primitive_ADVANCED_Triangle = 2023,
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	[Config("Hexagon (Simple)", 0)]
	Shape_Primitive_ADVANCED_Hexagon = 2024,
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	[Config("Quarter Pipe", 0)]
	Shape_Primitive_ADVANCED_QuarterPipe = 2025,
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	[Config("Pentagon (Simple)", 0)]
	Shape_Primitive_ADVANCED_Pentagon = 2026,
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	[Config("Dodecahedron", 0)]
	Shape_Primitive_ADVANCED_Dodecahedron = 2027,
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	[Config("Icosahedron", 0)]
	Shape_Primitive_ADVANCED_Trihedron = 2028,
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	[Config("Octahedron", 0)]
	Shape_Primitive_ADVANCED_Octahedron = 2029,
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	[Config("Quarter Cylinder", 0)]
	Shape_Primitive_RR_QuarterCylinder = 2030,
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	[Config("Pentagon", 0)]
	Shape_Primitive_RR_Pentagon = 2031,
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	[Config("Quarter Sphere", 0)]
	Shape_Primitive_RR_QuarterSphere = 2032,
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	[Config("Wedge (Simple)", 0)]
	Shape_Primitive_ADVANCED_Wedge = 2033,
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	[Config("Hexagon", 0)]
	Shape_Primitive_RR_Hexagon = 2034,
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	[Config("Octagon", 0)]
	Shape_Primitive_RR_Octagon = 2035,
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	[Config("Triangle", 0)]
	Shape_Primitive_RR_Triangle = 2036,
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	[Config("Spline", 0)]
	Shape_Spline = 3000,
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	[Config("Container Pivot", 0)]
	Other_ContainerPivot = 6000,
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	[Config("Spine Point", 0)]
	Other_SplinePoint = 6001,
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	[Config("Reference Point", 0)]
	Other_ReferencePoint = 6002,
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	[Config("UserTags", 0)]
	Other_UserTag = 6003,
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	[Config("Reference Group", 0)]
	Other_ReferenceGroup = 6004,
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	[Config("Interaction Filter", 0)]
	Other_InteractionFilterTags = 6005,
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	[ConfigIgnore]
	UNUSED2 = 5000,
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	[Config("Object", 0)]
	PrefabRootGameObject = 7000,
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	[Config("PrefabInternal", 0)]
	PrefabInternalGameObject = 7001,
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	[Config("Player", 0)]
	Player = 8000
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public static class JNEGIFBKDML
{
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[CompilerGenerated]
	private sealed class GHIGMAGAFAF : IEnumerable<MCEIIDDCFHJ>, IEnumerable, IEnumerator<MCEIIDDCFHJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private MCEIIDDCFHJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private IEnumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private MCEIIDDCFHJ System.Collections.Generic.IEnumerator<RecRoom.DataLayer.ObjectPrefabType>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0xA3A0A0", Offset = "0xA38CA0", VA = "0x180A3A0A0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(MCEIIDDCFHJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x745B420", Offset = "0x745A020", VA = "0x18745B420", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x10A8CB0", Offset = "0x10A78B0", VA = "0x1810A8CB0")]
		[DebuggerHidden]
		public GHIGMAGAFAF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x745B470", Offset = "0x745A070", VA = "0x18745B470", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x745B0B0", Offset = "0x7459CB0", VA = "0x18745B0B0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x745B050", Offset = "0x7459C50", VA = "0x18745B050")]
		private void AOMOFJGADBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x745B3D0", Offset = "0x7459FD0", VA = "0x18745B3D0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x745B330", Offset = "0x7459F30", VA = "0x18745B330", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<MCEIIDDCFHJ> System.Collections.Generic.IEnumerable<RecRoom.DataLayer.ObjectPrefabType>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x745B330", Offset = "0x7459F30", VA = "0x18745B330", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000073")]
	[CompilerGenerated]
	private sealed class KHIKMIBMNID : IEnumerable<MCEIIDDCFHJ>, IEnumerable, IEnumerator<MCEIIDDCFHJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private MCEIIDDCFHJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private IEnumerator<MCEIIDDCFHJ> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		private MCEIIDDCFHJ System.Collections.Generic.IEnumerator<RecRoom.DataLayer.ObjectPrefabType>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0xA3A0A0", Offset = "0xA38CA0", VA = "0x180A3A0A0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(MCEIIDDCFHJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x745C250", Offset = "0x745AE50", VA = "0x18745C250", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x10A8CB0", Offset = "0x10A78B0", VA = "0x1810A8CB0")]
		[DebuggerHidden]
		public KHIKMIBMNID(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x745C2A0", Offset = "0x745AEA0", VA = "0x18745C2A0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x745BEC0", Offset = "0x745AAC0", VA = "0x18745BEC0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x745BE70", Offset = "0x745AA70", VA = "0x18745BE70")]
		private void AOMOFJGADBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x745C200", Offset = "0x745AE00", VA = "0x18745C200", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x745C160", Offset = "0x745AD60", VA = "0x18745C160", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<MCEIIDDCFHJ> System.Collections.Generic.IEnumerable<RecRoom.DataLayer.ObjectPrefabType>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x745C160", Offset = "0x745AD60", VA = "0x18745C160", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x745BD30", Offset = "0x745A930", VA = "0x18745BD30")]
	[IteratorStateMachine(typeof(GHIGMAGAFAF))]
	public static IEnumerable<MCEIIDDCFHJ> NJCAIJJEBBO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x745BCD0", Offset = "0x745A8D0", VA = "0x18745BCD0")]
	[IteratorStateMachine(typeof(KHIKMIBMNID))]
	public static IEnumerable<MCEIIDDCFHJ> ANCEHIBMCKC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public static class KFIJNNMHAPP
{
	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x745BD90", Offset = "0x745A990", VA = "0x18745BD90")]
	public static bool ALAEHBLPJBP(this MCEIIDDCFHJ ADFFEBFOCBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x745BDF0", Offset = "0x745A9F0", VA = "0x18745BDF0")]
	public static bool EOEHIPHJJDD(this RRObjectPrefabData JBGGDOMIMMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x745BDC0", Offset = "0x745A9C0", VA = "0x18745BDC0")]
	public static bool EOEHIPHJJDD(this MCEIIDDCFHJ ADFFEBFOCBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x745BE20", Offset = "0x745AA20", VA = "0x18745BE20")]
	public static MCAMCBGPIBD HLJMEGOFBAO(this MCEIIDDCFHJ FDCILKKFHHF)
	{
		return default(MCAMCBGPIBD);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x745BE40", Offset = "0x745AA40", VA = "0x18745BE40")]
	internal static PINCLODBCDN IABNBMBMBMM(this MCAMCBGPIBD NCAKCNAOHMK)
	{
		return default(PINCLODBCDN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x745BE50", Offset = "0x745AA50", VA = "0x18745BE50")]
	internal static PINCLODBCDN IABNBMBMBMM(this MCEIIDDCFHJ FDCILKKFHHF)
	{
		return default(PINCLODBCDN);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
internal enum PINCLODBCDN
{
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	Container = 1000,
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	Empty = 4000,
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	Primitive = 2000,
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	Spline = 3000,
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	Other = 6000,
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	UNUSED2 = 5000,
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	GameObject = 7000,
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	Player = 8000
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
[RecRoom.DataLayer.RRGuid("A32413BC-21F3-4F7C-84B0-37724A854A67")]
[RecRoom.DataLayer.Range(0, 8)]
[RecRoom.DataLayer.NetworkEnum(1, false)]
public enum MCAMCBGPIBD
{
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	Container,
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	Primitive,
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	Spline,
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	Empty,
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	UNUSED2,
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	Other,
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	GameObject,
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	Player
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public static class DIAEPCLLLBL
{
	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x745AA30", Offset = "0x7459630", VA = "0x18745AA30")]
	public static bool GCCBNPKJBKA(this MCAMCBGPIBD NCAKCNAOHMK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
[RecRoom.DataLayer.NetworkEnum(2, false)]
[RecRoom.DataLayer.RRGuid("7A0D34B5-FFE5-4C21-BB0C-CB3EBA34C797")]
[RecRoom.DataLayer.Range(0, KOKMBHAEOFP.ALL)]
[Flags]
public enum KOKMBHAEOFP : ushort
{
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	NONE = 0,
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	PhysicsEnabled = 1,
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	GravityEnabled = 2,
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	HasCustomMass = 4,
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	CollisionEvent = 0x40,
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	CanUse = 0x200,
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	CanClimb = 0x400,
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	CanWallRun = 0x800,
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	CanClamber = 0x1000,
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	CanTeleport = 0x2000,
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	DEFAULT = 0x3800,
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	ALL = 0x3E47,
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	MAX = 0x3E47
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	[CompilerGenerated]
	[RecRoom.DataLayer.StableTypeHash(8060729269509364919uL, 0u)]
	[RecRoom.DataLayer.RRGuid("5D4503E7-6CC4-4938-8840-1B859C391878")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[TypeManager.ForcedStableTypeHash(8060729269509364919uL)]
	public struct PrimitiveShapeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public PKHCDPIAIHH shapeType;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
[RecRoom.DataLayer.Range(-1, 38)]
[RecRoom.DataLayer.RRGuid("517224CC-0A79-4FE9-B048-53C37955D823")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
public enum PKHCDPIAIHH
{
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	LegacyBox = 2,
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	RR_Sphere = 3,
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	RR_Cylinder = 4,
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	LEGACY_Wedge = 5,
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	LEGACY_Pyramid = 6,
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	LEGACY_TriggerVolumeBox = 7,
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	RR_Box = 8,
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	LEGACY_RoundedBox = 9,
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	RR_Wedge = 10,
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	RR_Pyramid = 11,
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	RR_HalfSphere = 12,
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	RR_Cone = 13,
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	RR_Pipe = 14,
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	RR_Donut = 15,
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	RR_HalfPipe = 16,
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	RR_Diamond = 17,
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	ADVANCED_Mound = 18,
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	ADVANCED_Cube = 19,
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	ADVANCED_Sphere = 20,
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	ADVANCED_Cylinder = 21,
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	ADVANCED_Cone = 22,
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	ADVANCED_Pyramid = 23,
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	ADVANCED_Octagon = 24,
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	ADVANCED_Triangle = 25,
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	ADVANCED_Hexagon = 26,
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	ADVANCED_QuarterPipe = 27,
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	ADVANCED_Pentagon = 28,
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	ADVANCED_Dodecahedron = 29,
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	ADVANCED_Trihedron = 30,
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	ADVANCED_Octahedron = 31,
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	RR_QuarterCylinder = 32,
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	RR_Pentagon = 33,
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	RR_QuarterSphere = 34,
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	ADVANCED_Wedge = 35,
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	RR_Hexagon = 36,
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	RR_Octagon = 37,
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	RR_Triangle = 38,
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	COUNT = 39,
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	MIN_VALUE = -1,
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	MAX_VALUE = 38
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
[RecRoom.DataLayer.RRGuid("3D27DF09-CAE2-4C3F-B808-03AD605F8E98")]
[RecRoom.DataLayer.Range(GDGOOJEEKEA.None, GDGOOJEEKEA.COUNT)]
[RecRoom.DataLayer.NetworkEnum(1, false)]
public enum GDGOOJEEKEA : byte
{
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	AnimationGroup = 1,
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	COUNT = 2,
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	MAX = 2
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
[RecRoom.DataLayer.RRGuid("1829B7EA-C0EA-4E77-8EB2-BA23E995C860")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[Flags]
[RecRoom.DataLayer.Range(0, 7)]
public enum AELPFFMHMMC
{
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	DynamicUVProjection = 1,
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	PreventInvertedCreation = 2,
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	NewBendLogic = 4,
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	All = 7,
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	MAX = 7
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[Flags]
[RecRoom.DataLayer.Range(0, 7)]
[RecRoom.DataLayer.RRGuid("CCB58F66-EF02-476E-820F-9D593E2C3DE5")]
public enum LGKICAFDIOA
{
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	IsRibbon = 1,
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	RoundedTubes = 2,
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	OldStyleCaps = 4,
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	All = 7,
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	MAX = 7
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[RecRoom.DataLayer.RRGuid("72742F9B-D48E-4CED-B403-444201FFEE66")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[Flags]
[RecRoom.DataLayer.Range(0, 1)]
public enum HCIBANBNEEL
{
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	Static = 0,
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	Dynamic = 1,
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	All = 1
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.RRGuid("C5BE1CDA-5EF5-4EBF-BC7E-3E3510C68A7F")]
[RecRoom.DataLayer.Range(-2, 2)]
public enum MDHOEMALAKC
{
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	Frozen = -2,
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	Low = -1,
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	Normal = 0,
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	High = 1,
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	Realtime = 2,
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	Default = 0,
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	MIN = -2,
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	MAX = 2
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
[RecRoom.DataLayer.Range(int.MinValue, int.MaxValue)]
[RecRoom.DataLayer.RRGuid("D6AFAFED-8BAA-4499-9696-9CBB716EF514")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
public enum NECIPBBCOII
{
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	Red = 0,
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	Orange = 1,
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	Yellow = 2,
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	LightGreen = 3,
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	Blue = 4,
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	LightBlue = 5,
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	Teal = 6,
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	Green = 7,
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	Purple = 8,
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	LightPink = 9,
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	Pink = 10,
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	Brown = 11,
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	Tan = 12,
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	White = 13,
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	Grey = 14,
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	DarkGrey = 15,
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	DarkBrown = 16,
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	LightBrown = 17,
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	LightGrey = 18,
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	Black = 19,
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	DarkRed = 20,
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	DarkOrange = 21,
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	DarkYellow = 22,
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	DarkGreen = 23,
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	DarkTeal = 24,
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	DarkBlue = 25,
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	DarkPurple = 26,
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	DarkPink = 27,
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	LightRed = 28,
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	LightOrange = 29,
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	LightYellow = 30,
	[Cpp2IlInjected.Token(Token = "0x4000207")]
	Cyan = 31,
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	LightPurple = 32,
	[Cpp2IlInjected.Token(Token = "0x4000209")]
	DarkTan = 33,
	[Cpp2IlInjected.Token(Token = "0x400020A")]
	NewColor1 = 34,
	[Cpp2IlInjected.Token(Token = "0x400020B")]
	NewColor2 = 35,
	[Cpp2IlInjected.Token(Token = "0x400020C")]
	NewColor3 = 36,
	[Cpp2IlInjected.Token(Token = "0x400020D")]
	NewColor4 = 37,
	[Cpp2IlInjected.Token(Token = "0x400020E")]
	NewColor5 = 38,
	[Cpp2IlInjected.Token(Token = "0x400020F")]
	NewColor6 = 39,
	[Cpp2IlInjected.Token(Token = "0x4000210")]
	NewColor7 = 40,
	[Cpp2IlInjected.Token(Token = "0x4000211")]
	NewColor8 = 41,
	[Cpp2IlInjected.Token(Token = "0x4000212")]
	NewColor9 = 42,
	[Cpp2IlInjected.Token(Token = "0x4000213")]
	NewColor10 = 43,
	[Cpp2IlInjected.Token(Token = "0x4000214")]
	NewColor11 = 44,
	[Cpp2IlInjected.Token(Token = "0x4000215")]
	NewColor12 = 45,
	[Cpp2IlInjected.Token(Token = "0x4000216")]
	NewColor13 = 46,
	[Cpp2IlInjected.Token(Token = "0x4000217")]
	NewColor14 = 47,
	[Cpp2IlInjected.Token(Token = "0x4000218")]
	NewColor15 = 48,
	[Cpp2IlInjected.Token(Token = "0x4000219")]
	NewColor16 = 49,
	[Cpp2IlInjected.Token(Token = "0x400021A")]
	NewColor17 = 50,
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	NewColor18 = 51,
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	NewColor19 = 52,
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	NewColor20 = 53,
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	NewColor21 = 54,
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	NewColor22 = 55,
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	NewColor23 = 56,
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	NewColor24 = 57,
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	NewColor25 = 58,
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	NewColor26 = 59,
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	NewColor27 = 60,
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	Default = 0
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.RRGuid("C57BE511-BA1A-4D83-BA58-303F34F4DE74")]
[RecRoom.DataLayer.Range(-1, 31)]
public enum GDJFDDEMAEB
{
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	Cardboard = 0,
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	Neon = 1,
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	Brick = 2,
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	Carpet = 3,
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	Dirt = 4,
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	Grass = 5,
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	MetalReflective = 6,
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	Concrete = 7,
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	Linoleum = 8,
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	Plaster = 9,
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	WoodLogs = 10,
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	WoodBoards = 11,
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	WoodGrain = 12,
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	WoodFloor = 13,
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	Sand = 14,
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	GlossyPlastic = 15,
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	Cloth = 16,
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	RubberFloor = 17,
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	MetalFloorTread = 18,
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	PaintedBrick = 19,
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	Crashpad = 20,
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	PaintedWood = 21,
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	GripTape = 22,
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	GalvanizedMetal = 23,
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	ParticleBoard = 24,
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	CheckeredFloor = 25,
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	SparklyVinyl = 26,
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	Gravel = 27,
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	Rock = 28,
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	Placeholder29 = 29,
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	Placeholder30 = 30,
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	Placeholder31 = 31,
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	COUNT = 32,
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	MIN = -1,
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	MAX = 31,
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	Default = 0
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
[RecRoom.DataLayer.NetworkStruct(1, false)]
[RecRoom.DataLayer.RRGuid("112F004A-C92F-4055-99F9-D430EC13FE3C")]
public struct KNNDLIBEPCE : IComparable<KNNDLIBEPCE>, IEquatable<KNNDLIBEPCE>
{
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	public static readonly KNNDLIBEPCE PCKMBPNMICK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	[RecRoom.DataLayer.Field(1)]
	public uint GBLLCAMPNIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400024E")]
	[RecRoom.DataLayer.Field(2)]
	public uint HHBGOIJLOFL;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	private readonly uint OHOGECDHFKH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x745D330", Offset = "0x745BF30", VA = "0x18745D330")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public readonly bool KBPDDCJKJDD
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x745D2C0", Offset = "0x745BEC0", VA = "0x18745D2C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x745D420", Offset = "0x745C020", VA = "0x18745D420")]
	public KNNDLIBEPCE(int GBLLCAMPNIK, int PBIOBFICIDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x745D420", Offset = "0x745C020", VA = "0x18745D420")]
	public KNNDLIBEPCE(uint GBLLCAMPNIK, uint PBIOBFICIDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x745D480", Offset = "0x745C080", VA = "0x18745D480")]
	private KNNDLIBEPCE(uint GBLLCAMPNIK, uint PBIOBFICIDG, bool JDDBINHPGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x745D250", Offset = "0x745BE50", VA = "0x18745D250")]
	public KNNDLIBEPCE JMICGPKENEK(int KKHFKGIPICC = 1)
	{
		return default(KNNDLIBEPCE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x745D170", Offset = "0x745BD70", VA = "0x18745D170")]
	public KNNDLIBEPCE GDBEHPHPPKL(int KKHFKGIPICC = 1)
	{
		return default(KNNDLIBEPCE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x745CD90", Offset = "0x745B990", VA = "0x18745CD90")]
	public static KNNDLIBEPCE BJOFFIFILKJ(KNNDLIBEPCE NFOAKNOEKCL, KNNDLIBEPCE AFFPJGJMKFP)
	{
		return default(KNNDLIBEPCE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x745D2F0", Offset = "0x745BEF0", VA = "0x18745D2F0")]
	private static ulong MNOMCBBINIH(ulong CEDOOEEEDCO, ulong LJEHMGANCNG)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x745D090", Offset = "0x745BC90", VA = "0x18745D090", Slot = "4")]
	public int CompareTo(KNNDLIBEPCE PELBNOCGOOJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x745D0B0", Offset = "0x745BCB0", VA = "0x18745D0B0", Slot = "0")]
	public override bool Equals(object CFMCKCBBBKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x745D340", Offset = "0x745BF40", VA = "0x18745D340", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x745D150", Offset = "0x745BD50", VA = "0x18745D150", Slot = "5")]
	public bool Equals(KNNDLIBEPCE PELBNOCGOOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x745D1E0", Offset = "0x745BDE0", VA = "0x18745D1E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x338C480", Offset = "0x338B080", VA = "0x18338C480")]
	public static bool LBLECGDECIN(KNNDLIBEPCE NFOAKNOEKCL, KNNDLIBEPCE AFFPJGJMKFP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x745CD70", Offset = "0x745B970", VA = "0x18745CD70")]
	public static bool AIDLCBIJBIF(KNNDLIBEPCE NFOAKNOEKCL, KNNDLIBEPCE AFFPJGJMKFP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x745D230", Offset = "0x745BE30", VA = "0x18745D230")]
	public static bool JGMNAFNFOJO(KNNDLIBEPCE NFOAKNOEKCL, KNNDLIBEPCE AFFPJGJMKFP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x745D2D0", Offset = "0x745BED0", VA = "0x18745D2D0")]
	public static bool MILCDBLFFBA(KNNDLIBEPCE NFOAKNOEKCL, KNNDLIBEPCE AFFPJGJMKFP)
	{
		return default(bool);
	}
}
namespace RecRoom.DataLayer
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	[RecRoom.DataLayer.RRGuid("D3AB0F52-EA41-4891-9470-6E945A9D6583")]
	[RecRoom.DataLayer.NetworkStruct(1, false)]
	public struct NetworkGuid : IEquatable<NetworkGuid>, IComparable<NetworkGuid>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		[RecRoom.DataLayer.Field(1)]
		public int4 data;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public Guid Guid
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x103AC90", Offset = "0x1039890", VA = "0x18103AC90")]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x103ACA0", Offset = "0x10398A0", VA = "0x18103ACA0")]
			set
			{
			}
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x103AC90", Offset = "0x1039890", VA = "0x18103AC90")]
		public static Guid NIBCGLOMJGK(NetworkGuid IEIMOIIMGDN)
		{
			return default(Guid);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x103AC90", Offset = "0x1039890", VA = "0x18103AC90")]
		public static NetworkGuid NIBCGLOMJGK(Guid IEIMOIIMGDN)
		{
			return default(NetworkGuid);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x745D840", Offset = "0x745C440", VA = "0x18745D840", Slot = "4")]
		public bool Equals(NetworkGuid PELBNOCGOOJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x4B26DD0", Offset = "0x4B259D0", VA = "0x184B26DD0", Slot = "5")]
		public int CompareTo(NetworkGuid PELBNOCGOOJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x745D870", Offset = "0x745C470", VA = "0x18745D870", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
[RecRoom.DataLayer.NetworkStruct(1, false)]
[RecRoom.DataLayer.RRGuid("9F5F33BE-7C0A-4870-9CE0-BA79440E7F98")]
public struct CFJKLKGPMMA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	[RecRoom.DataLayer.Field(1)]
	public bool BEPIDPDHFCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000251")]
	[RecRoom.DataLayer.Field(2)]
	public float3 EAJEKAPGEEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	[RecRoom.DataLayer.Field(3)]
	public float3 FDLFOFFAOMO;

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x7458550", Offset = "0x7457150", VA = "0x187458550")]
	public CFJKLKGPMMA(float DMOKGKPBDAL, float IBGGHDAOBFM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
[RecRoom.DataLayer.NetworkStruct(1, false)]
[RecRoom.DataLayer.RRGuid("35984D5B-ACBD-4389-A94B-840070A871E2")]
public struct BGBHOGOFFCI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	[RecRoom.DataLayer.Field(1)]
	public float JKEPJGHOFFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000254")]
	[RecRoom.DataLayer.Field(2)]
	public int GCEAMCNFION;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000255")]
	[RecRoom.DataLayer.Field(3)]
	public LGKICAFDIOA HOHMEIEFKJJ;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool LHMINMKFJOD
	{
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x745A630", Offset = "0x7459230", VA = "0x18745A630")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x745A5E0", Offset = "0x74591E0", VA = "0x18745A5E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool IIOKHBDDCGK
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x745A660", Offset = "0x7459260", VA = "0x18745A660")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x745A600", Offset = "0x7459200", VA = "0x18745A600")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool NKLLHLLIKKG
	{
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x745A620", Offset = "0x7459220", VA = "0x18745A620")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x745A640", Offset = "0x7459240", VA = "0x18745A640")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public class KJOFAPGGGHI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000256")]
	public AOEICAANHOH HBOKLLPLOPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000257")]
	public int LPFOKHACKIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000258")]
	public bool INDNBMGINBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D")]
	[Cpp2IlInjected.Token(Token = "0x4000259")]
	public bool CKGNKAKAKGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E")]
	[Cpp2IlInjected.Token(Token = "0x400025A")]
	public bool GONHKLKCMCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400025B")]
	public Vector3 JCCKFLFINHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400025C")]
	public Quaternion BLLDMMJBALA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400025D")]
	public bool AAGDGNNMPDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400025E")]
	public Vector3 JKIMKCFOJEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400025F")]
	public Vector3 EOJIEALBLHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000260")]
	public Vector3 IJNLPKLIBIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000261")]
	public bool GLBOBIEKADM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000262")]
	protected ViewId OBBJNHGBHJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x4000263")]
	protected MIFMNKDNGLA AMFILENIFOL;

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public ViewId KIOCBPPNNKI
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x745C330", Offset = "0x745AF30", VA = "0x18745C330")]
		get
		{
			return default(ViewId);
		}
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0xD74780", Offset = "0xD73380", VA = "0x180D74780")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x745C3D0", Offset = "0x745AFD0", VA = "0x18745C3D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
	public KJOFAPGGGHI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public struct EBJGFKOFGAE : IEquatable<EBJGFKOFGAE>, IComparable<EBJGFKOFGAE>
{
	[Cpp2IlInjected.Token(Token = "0x4000264")]
	public static readonly int JJJJPKLNMHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000265")]
	public RRObjectPrefabData DLFNGKIHPEG;

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x745AED0", Offset = "0x7459AD0", VA = "0x18745AED0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x745AD30", Offset = "0x7459930", VA = "0x18745AD30", Slot = "4")]
	public bool Equals(EBJGFKOFGAE PELBNOCGOOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x745ADA0", Offset = "0x74599A0", VA = "0x18745ADA0", Slot = "0")]
	public override bool Equals(object CFMCKCBBBKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x745AEA0", Offset = "0x7459AA0", VA = "0x18745AEA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x745AD00", Offset = "0x7459900", VA = "0x18745AD00", Slot = "5")]
	public int CompareTo(EBJGFKOFGAE PELBNOCGOOJ)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
internal class NMBPOLJOPIB : ContainerPropertyBag<INBEMIBMLGO>
{
	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x745D7E0", Offset = "0x745C3E0", VA = "0x18745D7E0")]
	public NMBPOLJOPIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
internal class BMDHOEJOKDP : ContainerPropertyBag<RRObjectPrefabData>
{
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	private class KPBGNICFDGL : Property<RRObjectPrefabData, MCEIIDDCFHJ>
	{
		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public override string NMFKAOGOELC
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x745D5F0", Offset = "0x745C1F0", VA = "0x18745D5F0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public override bool EDFBHKBNGLD
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x9A1F50", Offset = "0x9A0B50", VA = "0x1809A1F50", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x745D500", Offset = "0x745C100", VA = "0x18745D500")]
		public KPBGNICFDGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x1EE94C0", Offset = "0x1EE80C0", VA = "0x181EE94C0", Slot = "14")]
		public override MCEIIDDCFHJ GetValue(RRObjectPrefabData AGGFAPJEEEN)
		{
			return default(MCEIIDDCFHJ);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x7448080", Offset = "0x7446C80", VA = "0x187448080", Slot = "15")]
		public override void SetValue(RRObjectPrefabData AGGFAPJEEEN, MCEIIDDCFHJ MPDLOLIOGJL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008B")]
	private class CFDNKMHGPCJ : Property<RRObjectPrefabData, Guid>
	{
		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override string NMFKAOGOELC
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x745AA00", Offset = "0x7459600", VA = "0x18745AA00", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public override bool EDFBHKBNGLD
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x9A1F50", Offset = "0x9A0B50", VA = "0x1809A1F50", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x745A910", Offset = "0x7459510", VA = "0x18745A910")]
		public CFDNKMHGPCJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x2B0E3B0", Offset = "0x2B0CFB0", VA = "0x182B0E3B0", Slot = "14")]
		public override Guid GetValue(RRObjectPrefabData AGGFAPJEEEN)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x745A900", Offset = "0x7459500", VA = "0x18745A900", Slot = "15")]
		public override void SetValue(RRObjectPrefabData AGGFAPJEEEN, Guid MPDLOLIOGJL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x745A670", Offset = "0x7459270", VA = "0x18745A670")]
	public BMDHOEJOKDP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
internal class HGLGECIJOAE : ContainerPropertyBag<Guid>
{
	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x745B4D0", Offset = "0x745A0D0", VA = "0x18745B4D0")]
	public HGLGECIJOAE()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x745D8F0", Offset = "0x745C4F0", VA = "0x18745D8F0")]
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
