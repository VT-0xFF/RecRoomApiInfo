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
		[Cpp2IlInjected.Address(RVA = "0x98FE40", Offset = "0x98F240", VA = "0x18098FE40")]
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
		[Cpp2IlInjected.Address(RVA = "0x98FE40", Offset = "0x98F240", VA = "0x18098FE40")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct FEAIBEEBOCE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private bool AGLCJJDCNNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private ViewId CENIGLPGNOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private int FGCNBOMLCIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private bool KHJJMAIDGGD;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7595460", Offset = "0x7594860", VA = "0x187595460")]
	public FEAIBEEBOCE(ViewId CENIGLPGNOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7595420", Offset = "0x7594820", VA = "0x187595420")]
	public FEAIBEEBOCE(int FGCNBOMLCIC, bool KHJJMAIDGGD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7595340", Offset = "0x7594740", VA = "0x187595340")]
	public ViewId EFFPABMJNMI([Optional] ViewId OJGFNHNDBAH)
	{
		return default(ViewId);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class KFHJHGLFIMK
{
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly Guid HLFOMKNNCJL;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static readonly Guid BGOBFPGGIHG;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static readonly Guid JPOANKJHCMM;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public static readonly Guid NPPMOFHCJIJ;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly Guid BAOLLLGJNBD;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public static readonly Dictionary<string, Guid> LJHOKEOMBHJ;

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static readonly RRObjectPrefabData NAOMCHLAFIO;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly RRObjectPrefabData BLHDFAIPDEM;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly RRObjectPrefabData CDPDLDEKCMC;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7595C20", Offset = "0x7595020", VA = "0x187595C20")]
	public static Guid GHIEGIMKGEI(string OGOCCCFKJPG)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7595C70", Offset = "0x7595070", VA = "0x187595C70")]
	public static RRObjectPrefabData JJLIPAHABGE(CNBJKFKGILJ ANONBNLNHHL)
	{
		return default(RRObjectPrefabData);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7595BD0", Offset = "0x7594FD0", VA = "0x187595BD0")]
	public static RRObjectPrefabData CAGIAAHGBLE(CNBJKFKGILJ ANONBNLNHHL)
	{
		return default(RRObjectPrefabData);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7595C50", Offset = "0x7595050", VA = "0x187595C50")]
	public static RRObjectPrefabData IJDEEPDNOEM(Guid BCIHOIBCNMJ)
	{
		return default(RRObjectPrefabData);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[DefaultMember("Item")]
public class KGINFMABLHE : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly Dictionary<int, object> MJFOKKFMONL;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public Dictionary<int, object> IDIBBHDGOOI
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x969480", Offset = "0x968880", VA = "0x180969480")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public object BNGIPFMNGPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x75961F0", Offset = "0x75955F0", VA = "0x1875961F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x75962B0", Offset = "0x75956B0", VA = "0x1875962B0")]
	public KGINFMABLHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x96D760", Offset = "0x96CB60", VA = "0x18096D760")]
	public KGINFMABLHE(Dictionary<int, object> MJFOKKFMONL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x7596190", Offset = "0x7595590", VA = "0x187596190")]
	public bool DEDPIFLILBJ(NJPPIBNIKPE MCNLCGLNHHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3545FF0", Offset = "0x35453F0", VA = "0x183545FF0")]
	public void COEBLHEDAAK<T>(NJPPIBNIKPE MCNLCGLNHHO, T PEBNJNGMMHE, [Optional] T CIKOELCEFFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x3546520", Offset = "0x3545920", VA = "0x183546520")]
	public void FHPKMMCODGE<T>(NJPPIBNIKPE MCNLCGLNHHO, T PEBNJNGMMHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7596250", Offset = "0x7595650", VA = "0x187596250")]
	public void PBIACPFCCPC(NJPPIBNIKPE MCNLCGLNHHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7596120", Offset = "0x7595520", VA = "0x187596120", Slot = "4")]
	public object Clone()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum NJPPIBNIKPE : byte
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
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct GDNGEOGBMLM<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public readonly NJPPIBNIKPE MCNLCGLNHHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly T CIKOELCEFFM;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x4656720", Offset = "0x4655B20", VA = "0x184656720")]
	public GDNGEOGBMLM(NJPPIBNIKPE MCNLCGLNHHO, T CIKOELCEFFM)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x46565F0", Offset = "0x46559F0", VA = "0x1846565F0")]
	public static GDNGEOGBMLM<T> JKGHIELMIOO(NJPPIBNIKPE MCNLCGLNHHO)
	{
		return default(GDNGEOGBMLM<T>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x46566C0", Offset = "0x4655AC0", VA = "0x1846566C0")]
	public static GDNGEOGBMLM<T> JKGHIELMIOO((NJPPIBNIKPE key, T value) FJLJDCJDABK)
	{
		return default(GDNGEOGBMLM<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(IACFNLIPOPL))]
public struct ANCOAIADDGI : IEnumerable<object>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private class IACFNLIPOPL : Dictionary<string, object>
	{
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private Dictionary<int, object> GAPCIOOOOMF;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool MEKKKKJOLBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x1568130", Offset = "0x1567530", VA = "0x181568130")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int ECPNGLCMABA
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7594280", Offset = "0x7593680", VA = "0x187594280")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x75944A0", Offset = "0x75938A0", VA = "0x1875944A0")]
	public static ANCOAIADDGI GEEFBNOOFMP()
	{
		return default(ANCOAIADDGI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0xC1B040", Offset = "0xC1A440", VA = "0x180C1B040")]
	public ANCOAIADDGI([Optional] Dictionary<int, object> GAPCIOOOOMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3BC9020", Offset = "0x3BC8420", VA = "0x183BC9020")]
	public void KAAHFJDOOLK<T>(GDNGEOGBMLM<T> MCNLCGLNHHO, T? PEBNJNGMMHE) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3BC8EF0", Offset = "0x3BC82F0", VA = "0x183BC8EF0")]
	public void KAAHFJDOOLK<T>((GDNGEOGBMLM<T> key, T value) PHOJMCHLAOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3BC8F10", Offset = "0x3BC8310", VA = "0x183BC8F10")]
	public void KAAHFJDOOLK<T>(GDNGEOGBMLM<T> MCNLCGLNHHO, T PEBNJNGMMHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x75942D0", Offset = "0x75936D0", VA = "0x1875942D0")]
	public void FFIEOJBCHCJ(ANCOAIADDGI BLMGNEDEHDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7594580", Offset = "0x7593980", VA = "0x187594580")]
	private void MEKFCHHLHOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3BC9B20", Offset = "0x3BC8F20", VA = "0x183BC9B20")]
	public bool POFMAEKIJGP<T>(GDNGEOGBMLM<T> MCNLCGLNHHO, [Out] T PEBNJNGMMHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x3BC9920", Offset = "0x3BC8D20", VA = "0x183BC9920")]
	public bool POFMAEKIJGP<T>(NJPPIBNIKPE MCNLCGLNHHO, [Out] T PEBNJNGMMHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x3BC8D80", Offset = "0x3BC8180", VA = "0x183BC8D80")]
	public T JIEBOMPIMDK<T>(GDNGEOGBMLM<T> MCNLCGLNHHO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3BC8D60", Offset = "0x3BC8160", VA = "0x183BC8D60")]
	public bool DEDPIFLILBJ<T>(GDNGEOGBMLM<T> MCNLCGLNHHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7594220", Offset = "0x7593620", VA = "0x187594220")]
	public bool DEDPIFLILBJ(NJPPIBNIKPE MCNLCGLNHHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3BC9900", Offset = "0x3BC8D00", VA = "0x183BC9900")]
	public void PBIACPFCCPC<T>(GDNGEOGBMLM<T> MCNLCGLNHHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7594600", Offset = "0x7593A00", VA = "0x187594600")]
	public void PBIACPFCCPC(NJPPIBNIKPE MCNLCGLNHHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0xC1AFD0", Offset = "0xC1A3D0", VA = "0x180C1AFD0")]
	public Dictionary<int, object> ALKEBMMMJAG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7594520", Offset = "0x7593920", VA = "0x187594520", Slot = "4")]
	public IEnumerator<object> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7594650", Offset = "0x7593A50", VA = "0x187594650", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public enum NLKLILDBLDN
{
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	PrefabComponents,
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	LocalObjectComponents,
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	NetworkedObjectComponents,
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	PolicyComponents,
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	ConnectableComponents,
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	RbexComponents,
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	TransformPoseComponents,
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	UniformTransformComponents,
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	DeformableSizeComponents,
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	ShapeComponents,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	PrimitiveComponents,
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	SplineComponents,
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	SplinePointComponents,
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	ContainerComponents,
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	ContainerLikeComponents,
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	ReplicatorComponents,
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	ContainerPivotComponents,
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	ShapeContainerComponents,
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	CostumePieceComponents,
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	PreventSerializationComponent,
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	DontPropagatePhysicsComponent,
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	DontPropagateOwnershipComponent,
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	LegacyGameObjectComponents,
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	GameObjectLegacyGizmoComponents,
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	GameObjectCostumeDummyPropComponents,
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	PlayerComponents,
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	PlayerRbexComponents,
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	PlayerTransformComponents,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	RequireEmbodiedComponents,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	EntityPrefabRootComponents,
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	EntityPrefabPartComponents,
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	SocketComponents,
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	VisibleInHierarchyComponents,
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	ToolCleanupComponents,
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	TagComponents,
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	InteractionFilterTagComponents,
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	AutoEmbodimentComponents,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	ReferenceGroupComponents,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	UserTagStorageComponents,
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	ReplicatedObjectComponents,
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	InteractionFilteringSettingsComponents,
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	InventionTrackingComponents,
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	ObjectBoardComponents,
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	NetworkTransformComponents,
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	AlwaysEmbodiedScopeComponents,
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	LoadInstanceLifetimeComponents,
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	PhysicsModelComponents,
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	StudioPropObjectComponents,
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	AnimationControllerComponents
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface BILHHCLBMMK
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public enum OBIEOGHJCDH
	{
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		Entity,
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		Prefab
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	LocalId BKLGBEGJFIH
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	RRObjectPrefabData ICPCPJPDHOM
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OAGHIGDNBHD(params string[] JJCIOCEFNLE);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LKLMMHKOMAP(NLKLILDBLDN CAOHBLAJCCD, OBIEOGHJCDH PMFPMLHADKP = OBIEOGHJCDH.Entity);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void AFDHBPNEHCC(Type ANONBNLNHHL, ReadOnlySpan<byte> MJFOKKFMONL, int OAOIINEFFEA, OBIEOGHJCDH PMFPMLHADKP = OBIEOGHJCDH.Entity);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HHCGCKHLEGO(Type ANONBNLNHHL, OBIEOGHJCDH PMFPMLHADKP = OBIEOGHJCDH.Entity);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void BKNCFEAPFPL(NLKLILDBLDN CAOHBLAJCCD, OBIEOGHJCDH PMFPMLHADKP = OBIEOGHJCDH.Entity);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool ILGNPECEMHO(NLKLILDBLDN CAOHBLAJCCD);

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void CCFGFNKMMHK(bool CHOMGGGKJOB, OBIEOGHJCDH PMFPMLHADKP = OBIEOGHJCDH.Entity);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void NFEBAKPHOCK();
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class DGGBOEJAONM
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7594AC0", Offset = "0x7593EC0", VA = "0x187594AC0")]
	public static bool NEEJOKEHPEI(this BILHHCLBMMK MEBLJIBNLCL, NLKLILDBLDN DEDIIAHFDHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7594A00", Offset = "0x7593E00", VA = "0x187594A00")]
	public static void BKGHKLAPIMB(this BILHHCLBMMK MEBLJIBNLCL, BILHHCLBMMK.OBIEOGHJCDH PMFPMLHADKP = BILHHCLBMMK.OBIEOGHJCDH.Entity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7594A60", Offset = "0x7593E60", VA = "0x187594A60")]
	public static void BOILFBPBIDC(this BILHHCLBMMK MEBLJIBNLCL, BILHHCLBMMK.OBIEOGHJCDH PMFPMLHADKP = BILHHCLBMMK.OBIEOGHJCDH.Entity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x32D32F0", Offset = "0x32D26F0", VA = "0x1832D32F0")]
	public static void GPFHJHFHFOB<T>(this BILHHCLBMMK MEBLJIBNLCL, BILHHCLBMMK.OBIEOGHJCDH PMFPMLHADKP = BILHHCLBMMK.OBIEOGHJCDH.Entity) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x32CD690", Offset = "0x32CCA90", VA = "0x1832CD690")]
	public static void FLIBFNPBPIO<T>(this BILHHCLBMMK MEBLJIBNLCL, BILHHCLBMMK.OBIEOGHJCDH PMFPMLHADKP = BILHHCLBMMK.OBIEOGHJCDH.Entity) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x32D3280", Offset = "0x32D2680", VA = "0x1832D3280")]
	public static void GKJMCBPHBBE<T>(this BILHHCLBMMK MEBLJIBNLCL, bool KAAKOEHJNMO, BILHHCLBMMK.OBIEOGHJCDH PMFPMLHADKP = BILHHCLBMMK.OBIEOGHJCDH.Entity) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x32D1770", Offset = "0x32D0B70", VA = "0x1832D1770")]
	public static void AFDHBPNEHCC<T>(this BILHHCLBMMK MEBLJIBNLCL, T PEBNJNGMMHE, BILHHCLBMMK.OBIEOGHJCDH PMFPMLHADKP = BILHHCLBMMK.OBIEOGHJCDH.Entity) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x32D3330", Offset = "0x32D2730", VA = "0x1832D3330")]
	public static void HHCGCKHLEGO<T>(this BILHHCLBMMK MEBLJIBNLCL, BILHHCLBMMK.OBIEOGHJCDH PMFPMLHADKP = BILHHCLBMMK.OBIEOGHJCDH.Entity) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x32D3510", Offset = "0x32D2910", VA = "0x1832D3510")]
	public static void OPNPHFCONJG<T>(this BILHHCLBMMK MEBLJIBNLCL, LocalId DKAEPFAKBGE, BILHHCLBMMK.OBIEOGHJCDH PMFPMLHADKP = BILHHCLBMMK.OBIEOGHJCDH.Entity) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x32D15C0", Offset = "0x32D09C0", VA = "0x1832D15C0")]
	private static void AFDHBPNEHCC<T>(this BILHHCLBMMK MEBLJIBNLCL, Type ANONBNLNHHL, T PEBNJNGMMHE, BILHHCLBMMK.OBIEOGHJCDH PMFPMLHADKP = BILHHCLBMMK.OBIEOGHJCDH.Entity) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface EIHDBAKFPCG
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	Entity FOFFOEGGMGI
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface GLNJOIJGFPB
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void Bake(BILHHCLBMMK MEBLJIBNLCL);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface AGLPKLDCIME
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NFKLDOBGLML(EKCODMPEECK FDLLGPFCFLD);

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MKGMMMDDIEP(EKCODMPEECK FDLLGPFCFLD);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface AMGELEOCMKG
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	ViewId ECHMJPLIJMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface JKPGNNKAEHC : AMGELEOCMKG, LDKNJLKIMDD
{
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OBBALIPJEND(ViewId OBDGNLJFAHA, ViewId GLJLEHLONAN, Dictionary<int, object> EHAMKEJBOAG, EKCODMPEECK PABHOIEKLEA);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface DEHIGIKHMNG : AMGELEOCMKG
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OBBALIPJEND(GGJEEKAHCEJ HKNGNFLDPKM, Vector3 ODMGDEIMGFO, Quaternion NNFHCIFKIPA, Vector3 OHCIJMLLFKI, bool FMKGDABNNBK);

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OLOIEFGMIJJ(Vector3 ODMGDEIMGFO, Quaternion NNFHCIFKIPA, Vector3 OHCIJMLLFKI);

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NMIFEKBMEEA(ViewId HKNGNFLDPKM);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PMDDGIGHLPI(bool IPGOOEGMCME);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EOMCCGNHKJJ(bool IGBPFMLPGEG);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface LDKNJLKIMDD
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JLECGCJBBLC();
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface OAALKIJDLOD
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NativeArray<Guid> JBKLJBJBDMB(World HMKOFFGCOII, NativeArray<Entity> PPMNIACNFOH, Allocator FALBINAEKDG);
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[RecRoom.DataLayer.StableTypeHash(11505792609904010668uL, 0u)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(11505792609904010668uL)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("B7CEB5B9-453F-4712-B833-27D907AA13E2")]
	public struct AuthoredLocalPoseData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		[RecRoom.DataLayer.Default("new quaternion(new float4(float.NaN))")]
		[RecRoom.DataLayer.Field(1)]
		public quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		[RecRoom.DataLayer.Default("new float3(float.NaN)")]
		[RecRoom.DataLayer.Field(2)]
		public float3 localPosition;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public readonly bool IsValid
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x7594660", Offset = "0x7593A60", VA = "0x187594660")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x4BA5430", Offset = "0x4BA4830", VA = "0x184BA5430")]
		public AuthoredLocalPoseData(quaternion localRotation, float3 localPosition)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x75946C0", Offset = "0x7593AC0", VA = "0x1875946C0")]
		public static RigidTransform JKGHIELMIOO(AuthoredLocalPoseData poseData)
		{
			return default(RigidTransform);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x75946C0", Offset = "0x7593AC0", VA = "0x1875946C0")]
		public static AuthoredLocalPoseData JKGHIELMIOO(RigidTransform pose)
		{
			return default(AuthoredLocalPoseData);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class DNJDOMIIPDA
{
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7594CF0", Offset = "0x75940F0", VA = "0x187594CF0")]
	public static AuthoredLocalPoseData FLDLCJHDJDB([In] this RigidTransform PEBNJNGMMHE)
	{
		return default(AuthoredLocalPoseData);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0xB838A0", Offset = "0xB82CA0", VA = "0x180B838A0")]
	public static RigidTransform LGDPJNKMJBD(this AuthoredLocalPoseData PEBNJNGMMHE)
	{
		return default(RigidTransform);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7594CC0", Offset = "0x75940C0", VA = "0x187594CC0")]
	public static RigidTransform ENIPLIFACIH([In] this AuthoredLocalPoseData PEBNJNGMMHE)
	{
		return default(RigidTransform);
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("C26C4B4E-5EF3-4F81-87C8-FED8EAD37242")]
	[RecRoom.DataLayer.StableTypeHash(9088562008033959482uL, 0u)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(9088562008033959482uL)]
	public struct AuthoredLocalUniformScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default(1f)]
		public float localUniformScale;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public readonly bool IsValid
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x75946E0", Offset = "0x7593AE0", VA = "0x1875946E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x27C3650", Offset = "0x27C2A50", VA = "0x1827C3650")]
		public AuthoredLocalUniformScaleData(float localUniformScale)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(10137300772124140051uL)]
	[RecRoom.DataLayer.StableTypeHash(10137300772124140051uL, 0u)]
	[RecRoom.DataLayer.RRGuid("7B1B8635-3FA9-4ADC-922B-3C25CE0C7E7D")]
	public struct AuthoredParentData : IComponentData, EIHDBAKFPCG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public Entity parent;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xC1AFD0", Offset = "0xC1A3D0", VA = "0x180C1AFD0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x1501850", Offset = "0x1500C50", VA = "0x181501850", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x1501850", Offset = "0x1500C50", VA = "0x181501850")]
		public AuthoredParentData(Entity parent)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xB838A0", Offset = "0xB82CA0", VA = "0x180B838A0")]
		public static AuthoredParentData JKGHIELMIOO(Entity entity)
		{
			return default(AuthoredParentData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x7594740", Offset = "0x7593B40", VA = "0x187594740", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct GCPCMDBGKMI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001C")]
[TypeManager.ForcedStableTypeHash(11776442497872827640uL)]
public struct HGIEKLHDMAC : IComponentData
{
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(8594223769175916906uL)]
	[RecRoom.DataLayer.StableTypeHash(8594223769175916906uL, 0u)]
	[RecRoom.DataLayer.RRGuid("B9A63EF5-66A5-463C-8385-A7DC7CE137C3")]
	public struct ObjectBoardNodeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public NetworkGuid nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(2)]
		public NetworkGuid graphId;
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[RecRoom.DataLayer.RRGuid("B26EF01D-F674-4506-80B7-5345391A097E")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[TypeManager.ForcedStableTypeHash(5933855128949143734uL)]
	[CompilerGenerated]
	public struct ReplicatedObjectActiveStatusData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default(true)]
		public bool active;
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("E9BA10A4-4EE9-431D-BD7F-FF2008ABFA03")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(16338184133650423946uL)]
	public struct ReplicatedObjectOwnedByPlayerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		[RecRoom.DataLayer.Default(-1)]
		[RecRoom.DataLayer.Field(1)]
		public int actorId;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct HDPGNFFHNLO : IComponentData
{
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[TypeManager.ForcedStableTypeHash(16223816226138460552uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.RRGuid("46C500A2-9991-4987-B1AA-66E5C3D8E371")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
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
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public Entity Target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		[RecRoom.DataLayer.Field(2)]
		[RecRoom.DataLayer.Default(false)]
		public bool NeedsCircuitUpdate;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000023")]
public struct EFKEKPCEOGL : IComponentData
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
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		[RecRoom.DataLayer.Default(10)]
		[RecRoom.DataLayer.Field(1)]
		public int count;
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	[RecRoom.DataLayer.RRGuid("400790C1-E8D9-4779-A549-3780DAEC2FDF")]
	[TypeManager.ForcedStableTypeHash(16379995002884076574uL)]
	[CompilerGenerated]
	public struct ReplicatorPreallocatedObjectCountData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		[RecRoom.DataLayer.Default(0)]
		[RecRoom.DataLayer.Field(1)]
		public int preallocatedCopies;
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[RecRoom.DataLayer.RRGuid("6A82044A-E392-4DCD-B4BC-A120E58334EA")]
	[RecRoom.DataLayer.StableTypeHash(8536678595025273356uL, 0u)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(8536678595025273356uL)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct EntityPrefabPartData : IComponentData, IComparable<EntityPrefabPartData>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public Entity prefabRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		[RecRoom.DataLayer.Field(2)]
		[RecRoom.DataLayer.Default]
		public uint partId;

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x7595270", Offset = "0x7594670", VA = "0x187595270", Slot = "4")]
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
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		[SerializeField]
		private uint id;

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x1123940", Offset = "0x1122D40", VA = "0x181123940")]
		internal EntityPrefabPartId(uint NNKBGKICBEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x9B1820", Offset = "0x9B0C20", VA = "0x1809B1820")]
		internal uint FANPKJPCBBF()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x1F60680", Offset = "0x1F5FA80", VA = "0x181F60680", Slot = "4")]
		public bool Equals(EntityPrefabPartId MNALNBMKJLK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x75952C0", Offset = "0x75946C0", VA = "0x1875952C0", Slot = "0")]
		public override bool Equals(object NBAMGPFDMIB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x115EB10", Offset = "0x115DF10", VA = "0x18115EB10", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x1F605F0", Offset = "0x1F5F9F0", VA = "0x181F605F0", Slot = "5")]
		public int CompareTo(EntityPrefabPartId MNALNBMKJLK)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[TypeManager.ForcedStableTypeHash(15026348711748810383uL)]
public struct NDBADEPGPPC : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public Entity OGHDCLKOCFH;
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[ConfigGroup("Physics", 0)]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	[RecRoom.DataLayer.RRGuid("F74D558B-BDCC-48C8-A8EF-1F7559E5EAA0")]
	[TypeManager.ForcedStableTypeHash(2330616907306882483uL)]
	[CompilerGenerated]
	public struct PhysicsModelCollisionModeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default(AICLOPCAKOK.Children)]
		[Config(null, 0)]
		public AICLOPCAKOK collisionMode;
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(14800424556151816553uL)]
	[RecRoom.DataLayer.RRGuid("55EAB643-95BB-4C3A-832C-798EBCD95AD5")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[InternalBufferCapacity(0)]
	public struct ContainerNameBuffer : IBufferElementData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public byte data;
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[TypeManager.ForcedStableTypeHash(13657791279235747653uL)]
	[ConfigGroup("Container", 0)]
	[RecRoom.DataLayer.StableTypeHash(13657791279235747653uL, 0u)]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("89708D57-D027-494A-A159-221E6C643B6B")]
	public struct ContainerNameData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		[RecRoom.DataLayer.Field(1)]
		[Config(null, 0)]
		[RecRoom.DataLayer.Default]
		public FixedString64Bytes name;
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	[ConfigGroup("Physics", 0)]
	[RecRoom.DataLayer.RRGuid("CA023286-E0F6-4DA9-A346-94E86B93977C")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(13904209480152351845uL)]
	public struct PhysicsModelGrabbableModeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		[Config(null, 0)]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public PCICPALBLMA grabbableMode;
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[RecRoom.DataLayer.StableTypeHash(16485879999901987510uL, 0u)]
	[RecRoom.DataLayer.RRGuid("84485C1B-18ED-4D4A-86A4-34CEED482615")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(16485879999901987510uL)]
	[ConfigGroup("Container", 0)]
	public struct NavMeshGenerationData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default(KCPENIPBKIG.NavMeshGenerator)]
		[Config(null, 0)]
		public KCPENIPBKIG mode;
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[RecRoom.DataLayer.RRGuid("C5BCE8B3-6E69-41D4-921A-BE2E3E0A4DAB")]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	[ConfigGroup("Physics", 0)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(1954118413118190521uL)]
	public struct PhysicsModelCollisionLayerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		[RecRoom.DataLayer.Default(AOLFKOBBCMH.IsDynamicEnvironment)]
		[Config(null, 0)]
		[RecRoom.DataLayer.Field(1)]
		public AOLFKOBBCMH collisionLayer;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public static class CMNDLEJHNOE
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public enum LAPNJHFLHNO
	{
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		Dynamic,
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		Static,
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		Enemy,
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		Vehicle
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public enum GLOPHPOFEOH
	{
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		Environmental,
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		IgnoreStaticGeometry,
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		IgnoreOtherDynamic,
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		IgnorePlayers,
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		IgnoreMost,
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		Projectile
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7594860", Offset = "0x7593C60", VA = "0x187594860")]
	public static (LAPNJHFLHNO, GLOPHPOFEOH) HCAOJGJJDCM(this AOLFKOBBCMH AEPPPPJLFAJ)
	{
		return default((LAPNJHFLHNO, GLOPHPOFEOH));
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[RecRoom.DataLayer.RRGuid("F63AA9EA-6191-4DE9-BB18-1F049F432124")]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(3, false)]
	[TypeManager.ForcedStableTypeHash(16455981537837065632uL)]
	[ConfigGroup("Physics", 0)]
	public struct PhysicsModelFlagsData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default(AEGHABAAKPJ.DEFAULT)]
		[Config(null, 0)]
		public AEGHABAAKPJ flags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[TypeManager.ForcedStableTypeHash(1094837642118998916uL)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.StableTypeHash(1094837642118998916uL, 0u)]
	[ConfigGroup("Physics", 0)]
	[RecRoom.DataLayer.RRGuid("B6D08147-6AEA-4270-BDC4-8CF68662318D")]
	[CompilerGenerated]
	public struct PhysicsModelMassOverrideData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		[Config(null, 0)]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default(0f)]
		public float mass;
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[TypeManager.ForcedStableTypeHash(1537567323754185605uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.StableTypeHash(1537567323754185605uL, 0u)]
	[RecRoom.DataLayer.RRGuid("D732BC3D-4F8D-4FDE-BDB2-88C095D973C2")]
	public struct CostumePieceParentCostumeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
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
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public int slotIndex;
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("17799917-98EE-4D9A-A8D1-B0BE5F7316E3")]
	[TypeManager.ForcedStableTypeHash(10518841812724430444uL)]
	[CompilerGenerated]
	public struct InventionIdData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		[RecRoom.DataLayer.Default(0L)]
		[RecRoom.DataLayer.Field(1)]
		public long inventionId;

		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public const long INVALID_INVENTION_ID = 0L;

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xB838A0", Offset = "0xB82CA0", VA = "0x180B838A0")]
		public static InventionIdData JKGHIELMIOO(long value)
		{
			return default(InventionIdData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x7595970", Offset = "0x7594D70", VA = "0x187595970")]
		public readonly bool BJAIKHIOLDA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x7312100", Offset = "0x7311500", VA = "0x187312100")]
		public static bool BJAIKHIOLDA(long inventionId)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[TypeManager.ForcedStableTypeHash(14338988155392421373uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.RRGuid("629F0A56-C478-4353-BBDA-8A8BB5FEE478")]
	[RecRoom.DataLayer.TombstonedFields(new int[] { 1 })]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	public struct InventionInstanceIdData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(2)]
		public NetworkGuid instanceId;

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x109EED0", Offset = "0x109E2D0", VA = "0x18109EED0")]
		public static InventionInstanceIdData JKGHIELMIOO(Guid value)
		{
			return default(InventionInstanceIdData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("A3B27452-BD6C-43B2-BAFF-CF885EB1608B")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(12111354511484844847uL)]
	[RecRoom.DataLayer.StableTypeHash(12111354511484844847uL, 0u)]
	[RuntimeOnly]
	public struct ParentData : IComponentData, EIHDBAKFPCG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public Entity parent;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0xC1AFD0", Offset = "0xC1A3D0", VA = "0x180C1AFD0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x1501850", Offset = "0x1500C50", VA = "0x181501850", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x1501850", Offset = "0x1500C50", VA = "0x181501850")]
		public ParentData(Entity parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0xB838A0", Offset = "0xB82CA0", VA = "0x180B838A0")]
		public static implicit operator ParentData(Entity entity)
		{
			return default(ParentData);
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000039")]
public struct IAPANJEFAMM : IComponentData
{
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[TypeManager.ForcedStableTypeHash(1950029632769634832uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.RRGuid("c886150a-7231-4cc5-a2b2-f222500e6960")]
	[RecRoom.DataLayer.StableTypeHash(1950029632769634832uL, 0u)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct SiblingSortOrderData : IEquatable<SiblingSortOrderData>, IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public OOOKFBDHBLL order;

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xB838A0", Offset = "0xB82CA0", VA = "0x180B838A0")]
		public static SiblingSortOrderData JKGHIELMIOO(OOOKFBDHBLL value)
		{
			return default(SiblingSortOrderData);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7597430", Offset = "0x7596830", VA = "0x187597430", Slot = "4")]
		public bool Equals(SiblingSortOrderData other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[TypeManager.ForcedStableTypeHash(6217116203744017593uL)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[CompilerGenerated]
	[RecRoom.DataLayer.RRGuid("46CEA601-8AA7-423D-B1EA-EEABAE73413F")]
	public struct InteractionFilterAllTagsData : IComponentData, EIHDBAKFPCG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public Entity allTags;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0xC1AFD0", Offset = "0xC1A3D0", VA = "0x180C1AFD0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x1501850", Offset = "0x1500C50", VA = "0x181501850", Slot = "5")]
			set
			{
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[RecRoom.DataLayer.RRGuid("49CEFD0F-3A38-4A9B-835E-10B4C2D08392")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[TypeManager.ForcedStableTypeHash(6215026851838101933uL)]
	[CompilerGenerated]
	public struct InteractionFilterAnyTagsData : IComponentData, EIHDBAKFPCG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public Entity anyTags;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0xC1AFD0", Offset = "0xC1A3D0", VA = "0x180C1AFD0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x1501850", Offset = "0x1500C50", VA = "0x181501850", Slot = "5")]
			set
			{
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[TypeManager.ForcedStableTypeHash(6780642047612598977uL)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("11CE457F-4366-4AAD-B7E3-28D82B4FAFCF")]
	[CompilerGenerated]
	public struct InteractionFilterEnabledData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default(BGOAJJLHILN.Disabled)]
		public BGOAJJLHILN filterMode;
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(6642820932987006861uL)]
	[RecRoom.DataLayer.RRGuid("F7789094-7D82-4D27-B805-2CC1B8C0A538")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct InteractionFilterEntityRefData : IComponentData, EIHDBAKFPCG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public Entity filterEntity;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0xC1AFD0", Offset = "0xC1A3D0", VA = "0x180C1AFD0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x1501850", Offset = "0x1500C50", VA = "0x181501850", Slot = "5")]
			set
			{
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[TypeManager.ForcedStableTypeHash(15467295871228743847uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("C7E95AF7-DB7D-4432-8DAA-8F36EC6C4308")]
	public struct InteractionFilterNoneTagsData : IComponentData, EIHDBAKFPCG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public Entity noneTags;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0xC1AFD0", Offset = "0xC1A3D0", VA = "0x180C1AFD0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x1501850", Offset = "0x1500C50", VA = "0x181501850", Slot = "5")]
			set
			{
			}
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[RecRoom.DataLayer.RRGuid("007F8815-C87C-4E6B-BC56-3BA0C4888E3D")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[TypeManager.ForcedStableTypeHash(15012400804589552708uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.StableTypeHash(15012400804589552708uL, 0u)]
	public struct OverrideObjectNetworkIdData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public uint networkIdBits;
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	[RecRoom.DataLayer.RRGuid("30228348-77DF-48F6-B2EF-B0883D3E10CA")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[TypeManager.ForcedStableTypeHash(4540375434353162791uL)]
	public struct MakerPenHeldData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public bool makerPenHeld;
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[RecRoom.DataLayer.NetworkComponent(6, false)]
	[TypeManager.ForcedStableTypeHash(8459715919607487693uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.RRGuid("FB9853D6-6231-43FD-A754-00105DC30880")]
	[ConfigGroup("Object", 0)]
	public struct ObjectPolicyData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		[RecRoom.DataLayer.Default("new ScaleRestriction(1,1)")]
		[RecRoom.DataLayer.Field(2)]
		public AOEEPDNIMOA scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		[RecRoom.DataLayer.Default("ObjectPolicyUserConfigurableFlags.DEFAULT")]
		[RecRoom.DataLayer.Field(3)]
		[Config(null, 0)]
		public LBNCIFLCFMG userConfigurableFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		[RecRoom.DataLayer.Field(4)]
		[Config(null, 0)]
		[RecRoom.DataLayer.Default(AHINPDENBMA.Default)]
		public AHINPDENBMA circuitsTransformBehavior;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		[RecRoom.DataLayer.Default("ObjectPolicyEnumFlags.Default")]
		[RecRoom.DataLayer.Field(1)]
		public FGDPIGOCJKP flags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("617A903E-C2C2-467C-A138-287FDB487645")]
	[RecRoom.DataLayer.StableTypeHash(17708500325183871236uL, 0u)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(17708500325183871236uL)]
	public struct PlayerScopeData : IComponentData, EIHDBAKFPCG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public Entity playerScope;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public Entity Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0xC1AFD0", Offset = "0xC1A3D0", VA = "0x180C1AFD0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x1501850", Offset = "0x1500C50", VA = "0x181501850", Slot = "5")]
			set
			{
			}
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0xB838A0", Offset = "0xB82CA0", VA = "0x180B838A0")]
		public static PlayerScopeData JKGHIELMIOO(Entity entity)
		{
			return default(PlayerScopeData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[RecRoom.DataLayer.RRGuid("F945B699-C9E5-4634-9F64-831484F4F3BD")]
	[TypeManager.ForcedStableTypeHash(16642773407304133105uL)]
	[RecRoom.DataLayer.StableTypeHash(16642773407304133105uL, 0u)]
	[ConfigGroup("Physics", 0)]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct PhysicsMaterialData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		[Config(null, 0)]
		[RecRoom.DataLayer.Default(10f)]
		[RecRoom.DataLayer.Field(1)]
		public float density;
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	[RecRoom.DataLayer.StableTypeHash(10537432342869025182uL, 0u)]
	[RecRoom.DataLayer.RRGuid("A2E0AF0F-C284-47E6-9535-A67A29BF5730")]
	[TypeManager.ForcedStableTypeHash(10537432342869025182uL)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct ShapeConfigData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		[RecRoom.DataLayer.Default(OAHBOFCALAL.None)]
		[RecRoom.DataLayer.Field(1)]
		public OAHBOFCALAL flags;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool DynamicUVProjection
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x6A1DD20", Offset = "0x6A1D120", VA = "0x186A1DD20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool PreventInvertedCreation
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x6A1DD30", Offset = "0x6A1D130", VA = "0x186A1DD30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool NewBendLogic
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x75982F0", Offset = "0x75976F0", VA = "0x1875982F0")]
			get
			{
				return default(bool);
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[TypeManager.ForcedStableTypeHash(10917729582819845312uL)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("5C706BF1-9D50-456A-B974-521E8E2CC660")]
	[RecRoom.DataLayer.StableTypeHash(10917729582819845312uL, 0u)]
	[CompilerGenerated]
	public struct ShapeTypeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public KBLOCDAJKPE shapeType;
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[TypeManager.ForcedStableTypeHash(5298506180484533559uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.StableTypeHash(5298506180484533559uL, 0u)]
	[RecRoom.DataLayer.RRGuid("36418781-DB47-4DE7-A138-CC88D1D795C0")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct SplinePointOrderData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public OOOKFBDHBLL order;

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xB838A0", Offset = "0xB82CA0", VA = "0x180B838A0")]
		public static SplinePointOrderData JKGHIELMIOO(OOOKFBDHBLL value)
		{
			return default(SplinePointOrderData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("FCEE3BCD-9C10-4BF4-954A-0DCFE8810227")]
	[RecRoom.DataLayer.StableTypeHash(16368389834000856208uL, 0u)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(16368389834000856208uL)]
	public struct SplinePointParentData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public Entity spline;
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[RecRoom.DataLayer.StableTypeHash(18095612727592564636uL, 0u)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("5A6D38A4-1A58-4EB4-9C1B-06ADA0D44AFA")]
	[TypeManager.ForcedStableTypeHash(18095612727592564636uL)]
	[CompilerGenerated]
	public struct SplinePointPositionData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public float3 localPosition;
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[TypeManager.ForcedStableTypeHash(1429513518619209486uL)]
	[RecRoom.DataLayer.StableTypeHash(1429513518619209486uL, 0u)]
	[CompilerGenerated]
	[RecRoom.DataLayer.RRGuid("433F66B6-CC1C-4A8A-BF73-2B797440A8DB")]
	public struct SplinePointRotationData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		[RecRoom.DataLayer.Default("new quaternion(0, 0, 0, 1f)")]
		[RecRoom.DataLayer.Field(1)]
		public quaternion localRotation;
	}
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[TypeManager.ForcedStableTypeHash(1238044349990854547uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("04CA3CCE-F121-4B5B-BC56-FE8E9C77F0F4")]
	[RecRoom.DataLayer.StableTypeHash(1238044349990854547uL, 0u)]
	public struct SplinePointScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		[RecRoom.DataLayer.Default("new float3(1)")]
		[RecRoom.DataLayer.Field(1)]
		public float3 localScale;
	}
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.StableTypeHash(4657247877648983868uL, 0u)]
	[TypeManager.ForcedStableTypeHash(4657247877648983868uL)]
	[RecRoom.DataLayer.RRGuid("E0610986-0F8F-494A-8C6E-8A2D2491B088")]
	[CompilerGenerated]
	public struct SplineShapeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public EBCIGMMPLDE parameters;
	}
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[TypeManager.ForcedStableTypeHash(12332323170023439017uL)]
	[RecRoom.DataLayer.RRGuid("73C344D9-D535-4753-9D9A-B6DEDE4079B0")]
	[RecRoom.DataLayer.TombstonedFields(new int[] { 1 })]
	[RecRoom.DataLayer.StableTypeHash(12332323170023439017uL, 0u)]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	[CompilerGenerated]
	public struct OMShapeContainerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		[RecRoom.DataLayer.Default(true)]
		[RecRoom.DataLayer.Field(2)]
		public bool canModifyWithCircuits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		[RecRoom.DataLayer.Field(3)]
		[RecRoom.DataLayer.Default(true)]
		public bool optimizedCollidersEnabled;
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	[RecRoom.DataLayer.RRGuid("2B5C4208-9113-4F65-B3A6-18EAE1FF3937")]
	[TypeManager.ForcedStableTypeHash(17673274643717888315uL)]
	public struct SerializedDataLayerVersionData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public int version;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
[RecRoom.DataLayer.Range(JIMPHAPNHNN.MIN, JIMPHAPNHNN.ALL)]
[RecRoom.DataLayer.RRGuid("CC657074-87FD-47F7-A7B0-F5CCE922A9D0")]
[Flags]
[RecRoom.DataLayer.NetworkEnum(1, false)]
public enum JIMPHAPNHNN
{
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	IsAllowed = 1,
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	UseDefaultVisualEffects = 2,
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	DEFAULT = 2,
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	ALL = 3,
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	MAX = 3
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[TypeManager.ForcedStableTypeHash(5328722791392374178uL)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[CompilerGenerated]
	[RecRoom.DataLayer.RRGuid("34BA53CB-16FB-45DB-AA25-293CE7C8DAE4")]
	public struct ToolCleanupSettingsData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default(15f)]
		public float delay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		[RecRoom.DataLayer.Default(JIMPHAPNHNN.UseDefaultVisualEffects)]
		[RecRoom.DataLayer.Field(2)]
		public JIMPHAPNHNN toolCleanupFlags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[TypeManager.ForcedStableTypeHash(13768238190614302474uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.RRGuid("48C72ABE-383D-45C6-9610-773F2B4F84C6")]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	[RecRoom.DataLayer.TombstonedFields(new int[] { 2, 3 })]
	public struct ToolCleanupStatusData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public float cleanupStartTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		[RecRoom.DataLayer.Field(4)]
		[RecRoom.DataLayer.Default]
		public CPBJDAJGNMI statusFlags;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
[Flags]
[RecRoom.DataLayer.Range(CPBJDAJGNMI.None, CPBJDAJGNMI.ALL)]
[RecRoom.DataLayer.RRGuid("E63050BA-D087-4027-99F8-4AFDEA229CD8")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
public enum CPBJDAJGNMI
{
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	ForceCleanup = 1,
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	CleanupDone = 2,
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	CleanupPaused = 4,
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	ALL = 7,
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	MAX = 7
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[TypeManager.ForcedStableTypeHash(463077377357487319uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.RRGuid("021E8703-AAFD-4965-8C38-FF86663126D2")]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	public struct LocalDeformableScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default("new float3(1)")]
		public float3 localDeformationScale;

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x27C31D0", Offset = "0x27C25D0", VA = "0x1827C31D0")]
		public LocalDeformableScaleData(float3 scale)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[RecRoom.DataLayer.RRGuid("38AA9F1D-FD16-4B56-917C-3341D0EB1DF2")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[CompilerGenerated]
	[RecRoom.DataLayer.StableTypeHash(1369925932270831712uL, 0u)]
	[TypeManager.ForcedStableTypeHash(1369925932270831712uL)]
	public struct LocalPoseData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default("new quaternion(0,0,0,1)")]
		public quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		[RecRoom.DataLayer.Field(2)]
		[RecRoom.DataLayer.Default]
		public float3 localPosition;

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x4BA5430", Offset = "0x4BA4830", VA = "0x184BA5430")]
		public LocalPoseData(quaternion localRotation, float3 localPosition)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x75946C0", Offset = "0x7593AC0", VA = "0x1875946C0")]
		public static RigidTransform JKGHIELMIOO(LocalPoseData poseData)
		{
			return default(RigidTransform);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x75946C0", Offset = "0x7593AC0", VA = "0x1875946C0")]
		public static LocalPoseData JKGHIELMIOO(RigidTransform pose)
		{
			return default(LocalPoseData);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public static class CMLIPLOEEBE
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7594830", Offset = "0x7593C30", VA = "0x187594830")]
	public static LocalPoseData LLPKNOHDCIO([In] this RigidTransform PEBNJNGMMHE)
	{
		return default(LocalPoseData);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7594800", Offset = "0x7593C00", VA = "0x187594800")]
	public static RigidTransform ENIPLIFACIH([In] this LocalPoseData PEBNJNGMMHE)
	{
		return default(RigidTransform);
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	[RecRoom.DataLayer.RRGuid("0E9FADE9-751A-4A53-B455-4F8EA675754D")]
	[TypeManager.ForcedStableTypeHash(2720902521635056246uL)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.StableTypeHash(2720902521635056246uL, 0u)]
	public struct LocalUniformScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		[RecRoom.DataLayer.Default(1f)]
		[RecRoom.DataLayer.Field(1)]
		public float localUniformScale;
	}
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[TypeManager.ForcedStableTypeHash(5730545663584378555uL)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[CompilerGenerated]
	[RecRoom.DataLayer.StableTypeHash(5730545663584378555uL, 0u)]
	[RecRoom.DataLayer.RRGuid("F01774C0-98E7-491E-AAA5-85B64AFFA182")]
	public struct TransformFlagsData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public PKLLCJNIDEP transformHint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(2)]
		public PKNBEJKCAGA transformPriority;
	}
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	[RecRoom.DataLayer.RRGuid("392BF0C9-F464-491A-8725-E4B5E5C4ECD4")]
	[RecRoom.DataLayer.DoNotGenerateComponentProperties]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(12583036596830542024uL)]
	public struct RRObjectPrefabData : ISharedComponentData, IEquatable<RRObjectPrefabData>, IComparable<RRObjectPrefabData>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public CNBJKFKGILJ prefabType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(2)]
		public Guid prefabGuid;

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x7598170", Offset = "0x7597570", VA = "0x187598170")]
		public RRObjectPrefabData(Guid prefabGuid, CNBJKFKGILJ prefabType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x7598070", Offset = "0x7597470", VA = "0x187598070", Slot = "4")]
		public readonly bool Equals(RRObjectPrefabData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x7597FB0", Offset = "0x75973B0", VA = "0x187597FB0", Slot = "0")]
		public override readonly bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x75981E0", Offset = "0x75975E0", VA = "0x1875981E0")]
		public static bool operator !=(RRObjectPrefabData a, RRObjectPrefabData b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7598180", Offset = "0x7597580", VA = "0x187598180")]
		public static bool operator ==(RRObjectPrefabData a, RRObjectPrefabData b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7597CE0", Offset = "0x75970E0", VA = "0x187597CE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7597EE0", Offset = "0x75972E0", VA = "0x187597EE0", Slot = "5")]
		public readonly int CompareTo(RRObjectPrefabData other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x75980D0", Offset = "0x75974D0", VA = "0x1875980D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("FF90B503-A0B5-4B3D-BACF-046FA1456FBD")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(17550159503907726442uL)]
	public struct ReferenceGroupKindData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public NHILINKIAMC kind;
	}
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[TypeManager.ForcedStableTypeHash(18363292822319307914uL)]
	[RecRoom.DataLayer.RRGuid("2C78EEBE-6DD9-44FF-A70D-6C2EE9BB8FB3")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[CompilerGenerated]
	public struct ReferenceGroupOwnerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public Entity owner;
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("177498E9-83A6-4C2E-A8C1-B1951B47E74D")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(11947588904347318594uL)]
	public struct ReferenceGroupReferenceBuffer : IBufferElementData, EIHDBAKFPCG, IEquatable<ReferenceGroupReferenceBuffer>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public Entity reference;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public Entity Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0xC1AFD0", Offset = "0xC1A3D0", VA = "0x180C1AFD0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x1501850", Offset = "0x1500C50", VA = "0x181501850", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x75982E0", Offset = "0x75976E0", VA = "0x1875982E0", Slot = "6")]
		public bool Equals(ReferenceGroupReferenceBuffer other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7598250", Offset = "0x7597650", VA = "0x187598250", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x9B1820", Offset = "0x9B0C20", VA = "0x1809B1820", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005C")]
public struct KIKLNMCGKCN : IEqualityComparer<ReferenceGroupReferenceBuffer>
{
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public static KIKLNMCGKCN LPOHMOGIBPI;

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x7596340", Offset = "0x7595740", VA = "0x187596340", Slot = "4")]
	public bool Equals(ReferenceGroupReferenceBuffer COMHOHNLIIN, ReferenceGroupReferenceBuffer PJGBAACMKFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0xCAA690", Offset = "0xCA9A90", VA = "0x180CAA690", Slot = "5")]
	public int GetHashCode(ReferenceGroupReferenceBuffer NBAMGPFDMIB)
	{
		return default(int);
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[TypeManager.ForcedStableTypeHash(17466046755328781668uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("DE12A401-BD29-4B00-A629-7EFBECEDCFDF")]
	[InternalBufferCapacity(0)]
	public struct AuthoredUserTagReferenceBuffer : IOJCOIIMOBI, IBufferElementData, EIHDBAKFPCG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public Entity Child;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0xC1AFD0", Offset = "0xC1A3D0", VA = "0x180C1AFD0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x1501850", Offset = "0x1500C50", VA = "0x181501850", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x1501850", Offset = "0x1500C50", VA = "0x181501850")]
		public AuthoredUserTagReferenceBuffer(Entity entity)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0xB838A0", Offset = "0xB82CA0", VA = "0x180B838A0")]
		public static AuthoredUserTagReferenceBuffer JKGHIELMIOO(Entity entity)
		{
			return default(AuthoredUserTagReferenceBuffer);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public interface IOJCOIIMOBI : IBufferElementData, EIHDBAKFPCG
{
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	[RecRoom.DataLayer.RRGuid("00B7CB5E-4C0C-4D2C-AC95-78529EE58768")]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	[TypeManager.ForcedStableTypeHash(12148147190301245780uL)]
	public struct PersistentUserTagData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public FixedList32Bytes<int> tags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		[RecRoom.DataLayer.Default(false)]
		[RecRoom.DataLayer.Field(2)]
		public bool initalizedDefaults;
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[CompilerGenerated]
	[RecRoom.DataLayer.RRGuid("80D85A55-B2F6-4860-A851-62973DC10940")]
	[RecRoom.DataLayer.StableTypeHash(1859693175312uL, 0u)]
	[TypeManager.ForcedStableTypeHash(1859693175312uL)]
	[SwatchPrimaryKey]
	public struct UserTagNameData : IComponentData, IEquatable<UserTagNameData>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public FixedString32Bytes Value;

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x7598420", Offset = "0x7597820", VA = "0x187598420")]
		public UserTagNameData(string value)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x75983E0", Offset = "0x75977E0", VA = "0x1875983E0")]
		public static UserTagNameData JKGHIELMIOO(string value)
		{
			return default(UserTagNameData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x7598300", Offset = "0x7597700", VA = "0x187598300", Slot = "4")]
		public bool Equals(UserTagNameData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x7598330", Offset = "0x7597730", VA = "0x187598330", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x75983D0", Offset = "0x75977D0", VA = "0x1875983D0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[TypeManager.ForcedStableTypeHash(2039749658960193818uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[InternalBufferCapacity(0)]
	[RecRoom.DataLayer.RRGuid("1E609F72-38C4-433D-BB17-B718F89DF446")]
	public struct UserTagReferenceBuffer : IOJCOIIMOBI, IBufferElementData, EIHDBAKFPCG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public Entity Child;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0xC1AFD0", Offset = "0xC1A3D0", VA = "0x180C1AFD0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x1501850", Offset = "0x1500C50", VA = "0x181501850", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x1501850", Offset = "0x1500C50", VA = "0x181501850")]
		public UserTagReferenceBuffer(Entity entity)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0xB838A0", Offset = "0xB82CA0", VA = "0x180B838A0")]
		public static UserTagReferenceBuffer JKGHIELMIOO(Entity entity)
		{
			return default(UserTagReferenceBuffer);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[TypeManager.ForcedStableTypeHash(1591066774816564574uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.RRGuid("C36DDF08-CA52-4E33-8078-2F6E915D4FDA")]
	[RecRoom.DataLayer.StableTypeHash(1591066774816564574uL, 0u)]
	[ConfigGroup("Visual", 0)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct StandardRenderableVisualData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		[Config(null, 0)]
		public JDKHCFMOIGK color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(2)]
		[Config(null, 0)]
		public DDBKNDGEJJI material;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		[Config(null, 0)]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(3)]
		public float uvScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(4)]
		[Config(null, 0)]
		public float3 uvOffset;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.RRGuid("6B598497-D68A-4CC9-9D41-09EF6B966499")]
[RecRoom.DataLayer.Range(AHINPDENBMA.NONE, AHINPDENBMA.COUNT)]
public enum AHINPDENBMA
{
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	NONE = 0,
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	[Config("Default (can transform roots, children are static)", 0)]
	Default = 1,
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	[Config("Can Transform (chips like SetPosition can modify)", 0)]
	CircuitsCanTransform = 2,
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	[Config("Always Static (chips cannot modify transform)", 0)]
	AlwaysStatic = 3,
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	COUNT = 4,
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	MAX = 4
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.RRGuid("17517E1A-CF1A-48C9-B6A5-F9E42C1B9E96")]
[RecRoom.DataLayer.Range(0, 4)]
public enum KEHDCOHPEKE
{
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	Box = 1,
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	Sphere = 2,
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	Capsule = 3,
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	Mesh = 4,
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	COUNT = 5,
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	MAX = 4
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
[RecRoom.DataLayer.Range(JCOLMNNNBOA.NONE, JCOLMNNNBOA.ALL)]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[Flags]
[RecRoom.DataLayer.RRGuid("A13F5102-9259-42B9-B782-BB7CC33A0C4F")]
public enum JCOLMNNNBOA
{
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	NONE = 0,
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	Object = 1,
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	Player = 2,
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	Projectile = 4,
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	Vehicle = 8,
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	ALL = 0xF
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
[RecRoom.DataLayer.RRGuid("F843A776-E042-43B7-8167-0C7A421062F8")]
[RecRoom.DataLayer.NetworkEnum(2, false)]
[RecRoom.DataLayer.Range(0, 127)]
public enum AOLFKOBBCMH : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	[Config("Dynamic (Environment)", 0)]
	[@Tooltip("Indicating it can be walked on and moved")]
	IsDynamicEnvironment = 0,
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	[Config("Dynamic", -1)]
	IsDynamic = 10,
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	[Config("Dynamic (Ignore Static Geometry)", 0)]
	IsDynamicIgnoreStaticGeometry = 11,
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	[Config("Dynamic (Ignore Other Dynamic)", 0)]
	IsDynamicIgnoreOtherDynamic = 12,
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	[Config("Dynamic (Ignore Players)", 0)]
	IsDynamicIgnorePlayers = 13,
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	[Config("Dynamic (Ignore Most)", 0)]
	IsDynamicIgnoreMost = 14,
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	[Config("Enemy Collision", 0)]
	IsEnemyCollision = 30,
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	[Config("Enemy Projectile", 0)]
	IsEnemyProjectile = 31,
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	[Config("Vehicle Physics", 0)]
	IsVehicleCollision = 40,
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	[ConfigIgnore]
	STATIC = 100,
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	[ConfigIgnore]
	DECORATION = 101,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	MAX = 127
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
[RecRoom.DataLayer.Range(AICLOPCAKOK.Off, AICLOPCAKOK.COUNT)]
[RecRoom.DataLayer.RRGuid("9ADF7A0D-D808-48A7-BFCB-3272FB5D8A52")]
[RecRoom.DataLayer.NetworkEnum(2, false)]
public enum AICLOPCAKOK : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	Off = 0,
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	Children = 1,
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	Hull = 2,
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	COUNT = 3,
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	MAX = 2
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
[RecRoom.DataLayer.Range(0, 2)]
[RecRoom.DataLayer.RRGuid("3B156405-5769-4DB2-87EA-2B846AC4E584")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
public enum KBLOCDAJKPE
{
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	Primitive = 1,
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	Spline = 2,
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	COUNT = 3,
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	MAX = 2
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
[RecRoom.DataLayer.NetworkEnum(2, false)]
[RecRoom.DataLayer.RRGuid("61EFE94A-235A-4281-B938-1A5BE32A18B1")]
[RecRoom.DataLayer.Range(PCICPALBLMA.Pivot, PCICPALBLMA.COUNT)]
public enum PCICPALBLMA : byte
{
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	Pivot = 0,
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	Bounds = 1,
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	COUNT = 2,
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	MAX = 1
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
[RecRoom.DataLayer.RRGuid("c0973732-e735-44cd-9727-a9a79bad01e3")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.Range(BGOAJJLHILN.EnabledForRole, BGOAJJLHILN.DisabledForRole)]
public enum BGOAJJLHILN : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	EnabledForRole,
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	DisabledForRole,
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	Disabled
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
[RecRoom.DataLayer.Range(KCPENIPBKIG.NavMeshGenerator, KCPENIPBKIG.NavMeshBlocker)]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.RRGuid("7E7D5AA1-2EC9-488B-8AB2-703F13BCB8CF")]
public enum KCPENIPBKIG
{
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	NavMeshGenerator = 0,
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	NavMeshIgnored = 1,
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	NavMeshBlocker = 2,
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	MAX = 2
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
[RecRoom.DataLayer.RRGuid("7B493897-FE06-4FC8-AB72-8B7BF5A313D3")]
[RecRoom.DataLayer.Range(FGDPIGOCJKP.None, FGDPIGOCJKP.All)]
[Flags]
[RecRoom.DataLayer.NetworkEnum(1, false)]
public enum FGDPIGOCJKP
{
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	All = 0x3FFF,
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	Default = 0x3FFF
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
[RecRoom.DataLayer.Range(0, KNCNHJNGDAP.COUNT)]
[RecRoom.DataLayer.RRGuid("4427686F-E636-4F43-91F7-6BC74DEC584E")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
public enum KNCNHJNGDAP
{
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	SupportsRotation,
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	SupportsDeformation,
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	SupportsScaling,
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	SupportsMirroring,
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	SupportsCloning,
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	SupportsRecoloring,
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	CanDestroy,
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	CanSaveIntoInventions,
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	SupportsRespawn,
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	SupportsMerging,
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	SupportsSplitting,
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	SupportsKeys,
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	CanEditWithMakerPen,
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	DEPRECATED_IsGrabbable,
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public static class BLPPIJFOENH
{
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x7594770", Offset = "0x7593B70", VA = "0x187594770")]
	public static void FHPKMMCODGE(this FGDPIGOCJKP NHJKDMPGJCM, KNCNHJNGDAP CHNBOKMCOOC, bool LOKMCLGPAID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x7594750", Offset = "0x7593B50", VA = "0x187594750")]
	public static bool EJDPNJKNGGA(this FGDPIGOCJKP NHJKDMPGJCM, KNCNHJNGDAP CHNBOKMCOOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0xCC20B0", Offset = "0xCC14B0", VA = "0x180CC20B0")]
	public static FGDPIGOCJKP ADHLKNPFIGD(this KNCNHJNGDAP CHNBOKMCOOC)
	{
		return default(FGDPIGOCJKP);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
[RecRoom.DataLayer.NetworkEnum(2, false)]
[Flags]
[RecRoom.DataLayer.Range(LBNCIFLCFMG.NONE, LBNCIFLCFMG.COUNT)]
[RecRoom.DataLayer.RRGuid("E3C51303-32F0-4EF4-8A66-C814E323653D")]
public enum LBNCIFLCFMG
{
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	NONE = 0,
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	IsFrozen = 1,
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	IsGrabbable = 2,
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	COUNT = 3,
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	ALL = 3,
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	DEFAULT = 0
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
[RecRoom.DataLayer.RRGuid("777AD204-3AC0-41CE-BDC0-894C5821B3B9")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.Range(1000, 8000)]
public enum CNBJKFKGILJ
{
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	[Config("Container", 0)]
	Container = 1000,
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	[Config("Container", 0)]
	LegacyShapeContainer = 1001,
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	[Config("Container", 0)]
	CreationShapeContainer = 1002,
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	[Config("Container", 0)]
	CostumePieceShapeContainer = 1003,
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	[Config("Empty", 0)]
	Empty = 4000,
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	[Config("Legacy Box", 0)]
	Shape_Primitive_LegacyBox = 2000,
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	[Config("Sphere", 0)]
	Shape_Primitive_Sphere = 2001,
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	[Config("Cylinder", 0)]
	Shape_Primitive_Cylinder = 2002,
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	[Config("Legacy Wedge", 0)]
	Shape_Primitive_LegacyWedge = 2003,
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	[Config("Legacy Pyramid", 0)]
	Shape_Primitive_LegacyPyramid = 2004,
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	[Config("Trigger Volume Box", 0)]
	Shape_Primitive_TriggerVolumeBox = 2005,
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	[Config("Box", 0)]
	Shape_Primitive_Box = 2006,
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	[Config("Rounded Box", 0)]
	Shape_Primitive_RoundedBox = 2007,
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	[Config("Wedge", 0)]
	Shape_Primitive_Wedge = 2008,
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	[Config("Pyramid", 0)]
	Shape_Primitive_Pyramid = 2009,
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	[Config("Half Sphere", 0)]
	Shape_Primitive_HalfSphere = 2010,
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	[Config("Cone", 0)]
	Shape_Primitive_Cone = 2011,
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	[Config("Pipe", 0)]
	Shape_Primitive_Pipe = 2012,
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	[Config("Donut", 0)]
	Shape_Primitive_Donut = 2013,
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	[Config("Half Pipe", 0)]
	Shape_Primitive_HalfPipe = 2014,
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	[Config("Diamond", 0)]
	Shape_Primitive_Diamond = 2015,
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	[Config("Mound", 0)]
	Shape_Primitive_Mound = 2016,
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	[Config("Cube (Simple)", 0)]
	Shape_Primitive_ADVANCED_Cube = 2017,
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	[Config("Sphere (Simple)", 0)]
	Shape_Primitive_ADVANCED_Sphere = 2018,
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	[Config("Cylinder (Simple)", 0)]
	Shape_Primitive_ADVANCED_Cylinder = 2019,
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	[Config("Cone (Simple)", 0)]
	Shape_Primitive_ADVANCED_Cone = 2020,
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	[Config("Pyramid (Simple)", 0)]
	Shape_Primitive_ADVANCED_Pyramid = 2021,
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	[Config("Octagon (Simple)", 0)]
	Shape_Primitive_ADVANCED_Octagon = 2022,
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	[Config("Triangle (Simple)", 0)]
	Shape_Primitive_ADVANCED_Triangle = 2023,
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	[Config("Hexagon (Simple)", 0)]
	Shape_Primitive_ADVANCED_Hexagon = 2024,
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	[Config("Quarter Pipe", 0)]
	Shape_Primitive_ADVANCED_QuarterPipe = 2025,
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	[Config("Pentagon (Simple)", 0)]
	Shape_Primitive_ADVANCED_Pentagon = 2026,
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	[Config("Dodecahedron", 0)]
	Shape_Primitive_ADVANCED_Dodecahedron = 2027,
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	[Config("Icosahedron", 0)]
	Shape_Primitive_ADVANCED_Trihedron = 2028,
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	[Config("Octahedron", 0)]
	Shape_Primitive_ADVANCED_Octahedron = 2029,
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	[Config("Quarter Cylinder", 0)]
	Shape_Primitive_RR_QuarterCylinder = 2030,
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	[Config("Pentagon", 0)]
	Shape_Primitive_RR_Pentagon = 2031,
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	[Config("Quarter Sphere", 0)]
	Shape_Primitive_RR_QuarterSphere = 2032,
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	[Config("Wedge (Simple)", 0)]
	Shape_Primitive_ADVANCED_Wedge = 2033,
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	[Config("Hexagon", 0)]
	Shape_Primitive_RR_Hexagon = 2034,
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	[Config("Octagon", 0)]
	Shape_Primitive_RR_Octagon = 2035,
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	[Config("Triangle", 0)]
	Shape_Primitive_RR_Triangle = 2036,
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	[Config("Spline", 0)]
	Shape_Spline = 3000,
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	[Config("Container Pivot", 0)]
	Other_ContainerPivot = 6000,
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	[Config("Spine Point", 0)]
	Other_SplinePoint = 6001,
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	[Config("Reference Point", 0)]
	Other_ReferencePoint = 6002,
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	[Config("UserTags", 0)]
	Other_UserTag = 6003,
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	[Config("Reference Group", 0)]
	Other_ReferenceGroup = 6004,
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	[Config("Interaction Filter", 0)]
	Other_InteractionFilterTags = 6005,
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	[ConfigIgnore]
	UNUSED2 = 5000,
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	[Config("Object", 0)]
	PrefabRootGameObject = 7000,
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	[Config("PrefabInternal", 0)]
	PrefabInternalGameObject = 7001,
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	[Config("Player", 0)]
	Player = 8000
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public static class HKDBKIAGLPH
{
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[CompilerGenerated]
	private sealed class NFNDOLGNIED : IEnumerable<CNBJKFKGILJ>, IEnumerable, IEnumerator<CNBJKFKGILJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private CNBJKFKGILJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private IEnumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private CNBJKFKGILJ System.Collections.Generic.IEnumerator<RecRoom.DataLayer.ObjectPrefabType>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xA80880", Offset = "0xA7FC80", VA = "0x180A80880", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(CNBJKFKGILJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x75972D0", Offset = "0x75966D0", VA = "0x1875972D0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x1120EA0", Offset = "0x11202A0", VA = "0x181120EA0")]
		[DebuggerHidden]
		public NFNDOLGNIED(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x7597320", Offset = "0x7596720", VA = "0x187597320", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x7596F70", Offset = "0x7596370", VA = "0x187596F70", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x7596F10", Offset = "0x7596310", VA = "0x187596F10")]
		private void MHCHPBFCGPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x7597280", Offset = "0x7596680", VA = "0x187597280", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x75971E0", Offset = "0x75965E0", VA = "0x1875971E0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<CNBJKFKGILJ> System.Collections.Generic.IEnumerable<RecRoom.DataLayer.ObjectPrefabType>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x75971E0", Offset = "0x75965E0", VA = "0x1875971E0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000073")]
	[CompilerGenerated]
	private sealed class MKDMGCFIEGB : IEnumerable<CNBJKFKGILJ>, IEnumerable, IEnumerator<CNBJKFKGILJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		private CNBJKFKGILJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		private CNBJKFKGILJ <last>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		private CNBJKFKGILJ <i>5__3;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private CNBJKFKGILJ System.Collections.Generic.IEnumerator<RecRoom.DataLayer.ObjectPrefabType>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0xA80880", Offset = "0xA7FC80", VA = "0x180A80880", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(CNBJKFKGILJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x75964B0", Offset = "0x75958B0", VA = "0x1875964B0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x1120EA0", Offset = "0x11202A0", VA = "0x181120EA0")]
		[DebuggerHidden]
		public MKDMGCFIEGB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x7596360", Offset = "0x7595760", VA = "0x187596360", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x7596460", Offset = "0x7595860", VA = "0x187596460", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x75963C0", Offset = "0x75957C0", VA = "0x1875963C0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<CNBJKFKGILJ> System.Collections.Generic.IEnumerable<RecRoom.DataLayer.ObjectPrefabType>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x75963C0", Offset = "0x75957C0", VA = "0x1875963C0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[CompilerGenerated]
	private sealed class EHICJKNANCM : IEnumerable<CNBJKFKGILJ>, IEnumerable, IEnumerator<CNBJKFKGILJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		private CNBJKFKGILJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		private IEnumerator<CNBJKFKGILJ> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private CNBJKFKGILJ System.Collections.Generic.IEnumerator<RecRoom.DataLayer.ObjectPrefabType>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0xA80880", Offset = "0xA7FC80", VA = "0x180A80880", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(CNBJKFKGILJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x7595190", Offset = "0x7594590", VA = "0x187595190", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x1120EA0", Offset = "0x11202A0", VA = "0x181120EA0")]
		[DebuggerHidden]
		public EHICJKNANCM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x75951E0", Offset = "0x75945E0", VA = "0x1875951E0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x7594E00", Offset = "0x7594200", VA = "0x187594E00", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x7594DB0", Offset = "0x75941B0", VA = "0x187594DB0")]
		private void MHCHPBFCGPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x7595140", Offset = "0x7594540", VA = "0x187595140", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x75950A0", Offset = "0x75944A0", VA = "0x1875950A0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<CNBJKFKGILJ> System.Collections.Generic.IEnumerable<RecRoom.DataLayer.ObjectPrefabType>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x75950A0", Offset = "0x75944A0", VA = "0x1875950A0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x75954E0", Offset = "0x75948E0", VA = "0x1875954E0")]
	[IteratorStateMachine(typeof(NFNDOLGNIED))]
	public static IEnumerable<CNBJKFKGILJ> BDFINEEGJDD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x7595540", Offset = "0x7594940", VA = "0x187595540")]
	[IteratorStateMachine(typeof(MKDMGCFIEGB))]
	public static IEnumerable<CNBJKFKGILJ> COGOIHAAIKL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x75955A0", Offset = "0x75949A0", VA = "0x1875955A0")]
	[IteratorStateMachine(typeof(EHICJKNANCM))]
	public static IEnumerable<CNBJKFKGILJ> FDJCABHNPKF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public static class IDLDAFKJBBL
{
	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x7595650", Offset = "0x7594A50", VA = "0x187595650")]
	public static bool HLNDELOGBKE(this CNBJKFKGILJ ANONBNLNHHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x7595680", Offset = "0x7594A80", VA = "0x187595680")]
	public static bool ILLAJMOMMPF(this RRObjectPrefabData BIBPIMGGJLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x75956B0", Offset = "0x7594AB0", VA = "0x1875956B0")]
	public static bool ILLAJMOMMPF(this CNBJKFKGILJ ANONBNLNHHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x7595630", Offset = "0x7594A30", VA = "0x187595630")]
	public static HKBHHGEHAAD FEEFKMDEMPJ(this CNBJKFKGILJ IJODCDAMALB)
	{
		return default(HKBHHGEHAAD);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x7595620", Offset = "0x7594A20", VA = "0x187595620")]
	internal static LEAIKJOBCFK BHNOHMNNPOG(this HKBHHGEHAAD DIKJKPHGOEG)
	{
		return default(LEAIKJOBCFK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x7595600", Offset = "0x7594A00", VA = "0x187595600")]
	internal static LEAIKJOBCFK BHNOHMNNPOG(this CNBJKFKGILJ IJODCDAMALB)
	{
		return default(LEAIKJOBCFK);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
internal enum LEAIKJOBCFK
{
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	Container = 1000,
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	Empty = 4000,
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	Primitive = 2000,
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	Spline = 3000,
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	Other = 6000,
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	UNUSED2 = 5000,
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	GameObject = 7000,
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	Player = 8000
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
[RecRoom.DataLayer.Range(0, 8)]
[RecRoom.DataLayer.RRGuid("A32413BC-21F3-4F7C-84B0-37724A854A67")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
public enum HKBHHGEHAAD
{
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	Container,
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	Primitive,
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	Spline,
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	Empty,
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	UNUSED2,
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	Other,
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	GameObject,
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	Player
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public static class COAJNKNLFEN
{
	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x75949F0", Offset = "0x7593DF0", VA = "0x1875949F0")]
	public static bool HBKHHNCIBCD(this HKBHHGEHAAD DIKJKPHGOEG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
[Flags]
[RecRoom.DataLayer.NetworkEnum(2, false)]
[RecRoom.DataLayer.RRGuid("7A0D34B5-FFE5-4C21-BB0C-CB3EBA34C797")]
[RecRoom.DataLayer.Range(0, AEGHABAAKPJ.ALL)]
public enum AEGHABAAKPJ : ushort
{
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	NONE = 0,
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	PhysicsEnabled = 1,
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	GravityEnabled = 2,
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	HasCustomMass = 4,
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	CollisionEvent = 0x40,
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	CanUse = 0x200,
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	CanClimb = 0x400,
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	CanWallRun = 0x800,
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	CanClamber = 0x1000,
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	CanTeleport = 0x2000,
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	DEFAULT = 0x3800,
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	ALL = 0x3E47,
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	MAX = 0x3E47
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("5D4503E7-6CC4-4938-8840-1B859C391878")]
	[TypeManager.ForcedStableTypeHash(8060729269509364919uL)]
	[RecRoom.DataLayer.StableTypeHash(8060729269509364919uL, 0u)]
	public struct PrimitiveShapeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public KKPFGOPCOFD shapeType;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.RRGuid("517224CC-0A79-4FE9-B048-53C37955D823")]
[RecRoom.DataLayer.Range(-1, 38)]
public enum KKPFGOPCOFD
{
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	LegacyBox = 2,
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	RR_Sphere = 3,
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	RR_Cylinder = 4,
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	LEGACY_Wedge = 5,
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	LEGACY_Pyramid = 6,
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	LEGACY_TriggerVolumeBox = 7,
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	RR_Box = 8,
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	LEGACY_RoundedBox = 9,
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	RR_Wedge = 10,
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	RR_Pyramid = 11,
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	RR_HalfSphere = 12,
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	RR_Cone = 13,
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	RR_Pipe = 14,
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	RR_Donut = 15,
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	RR_HalfPipe = 16,
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	RR_Diamond = 17,
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	ADVANCED_Mound = 18,
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	ADVANCED_Cube = 19,
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	ADVANCED_Sphere = 20,
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	ADVANCED_Cylinder = 21,
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	ADVANCED_Cone = 22,
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	ADVANCED_Pyramid = 23,
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	ADVANCED_Octagon = 24,
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	ADVANCED_Triangle = 25,
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	ADVANCED_Hexagon = 26,
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	ADVANCED_QuarterPipe = 27,
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	ADVANCED_Pentagon = 28,
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	ADVANCED_Dodecahedron = 29,
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	ADVANCED_Trihedron = 30,
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	ADVANCED_Octahedron = 31,
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	RR_QuarterCylinder = 32,
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	RR_Pentagon = 33,
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	RR_QuarterSphere = 34,
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	ADVANCED_Wedge = 35,
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	RR_Hexagon = 36,
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	RR_Octagon = 37,
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	RR_Triangle = 38,
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	COUNT = 39,
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	MIN_VALUE = -1,
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	MAX_VALUE = 38
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
[RecRoom.DataLayer.Range(NHILINKIAMC.None, NHILINKIAMC.COUNT)]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.RRGuid("3D27DF09-CAE2-4C3F-B808-03AD605F8E98")]
public enum NHILINKIAMC : byte
{
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	AnimationGroup = 1,
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	COUNT = 2,
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	MAX = 2
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
[RecRoom.DataLayer.Range(0, 7)]
[RecRoom.DataLayer.RRGuid("1829B7EA-C0EA-4E77-8EB2-BA23E995C860")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[Flags]
public enum OAHBOFCALAL
{
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	DynamicUVProjection = 1,
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	PreventInvertedCreation = 2,
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	NewBendLogic = 4,
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	All = 7,
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	MAX = 7
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[RecRoom.DataLayer.RRGuid("CCB58F66-EF02-476E-820F-9D593E2C3DE5")]
[Flags]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.Range(0, 7)]
public enum DODFNBNEDGP
{
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	IsRibbon = 1,
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	RoundedTubes = 2,
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	OldStyleCaps = 4,
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	All = 7,
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	MAX = 7
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
[RecRoom.DataLayer.Range(0, 1)]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.RRGuid("72742F9B-D48E-4CED-B403-444201FFEE66")]
[Flags]
public enum PKLLCJNIDEP
{
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	Static = 0,
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	Dynamic = 1,
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	All = 1
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
[RecRoom.DataLayer.Range(-2, 2)]
[RecRoom.DataLayer.RRGuid("C5BE1CDA-5EF5-4EBF-BC7E-3E3510C68A7F")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
public enum PKNBEJKCAGA
{
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	Frozen = -2,
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	Low = -1,
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	Normal = 0,
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	High = 1,
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	Realtime = 2,
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	Default = 0,
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	MIN = -2,
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	MAX = 2
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
[RecRoom.DataLayer.RRGuid("D6AFAFED-8BAA-4499-9696-9CBB716EF514")]
[RecRoom.DataLayer.Range(int.MinValue, int.MaxValue)]
[RecRoom.DataLayer.NetworkEnum(1, false)]
public enum JDKHCFMOIGK
{
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	Red = 0,
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	Orange = 1,
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	Yellow = 2,
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	LightGreen = 3,
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	Blue = 4,
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	LightBlue = 5,
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	Teal = 6,
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	Green = 7,
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	Purple = 8,
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	LightPink = 9,
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	Pink = 10,
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	Brown = 11,
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	Tan = 12,
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	White = 13,
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	Grey = 14,
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	DarkGrey = 15,
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	DarkBrown = 16,
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	LightBrown = 17,
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	LightGrey = 18,
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	Black = 19,
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	DarkRed = 20,
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	DarkOrange = 21,
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	DarkYellow = 22,
	[Cpp2IlInjected.Token(Token = "0x4000207")]
	DarkGreen = 23,
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	DarkTeal = 24,
	[Cpp2IlInjected.Token(Token = "0x4000209")]
	DarkBlue = 25,
	[Cpp2IlInjected.Token(Token = "0x400020A")]
	DarkPurple = 26,
	[Cpp2IlInjected.Token(Token = "0x400020B")]
	DarkPink = 27,
	[Cpp2IlInjected.Token(Token = "0x400020C")]
	LightRed = 28,
	[Cpp2IlInjected.Token(Token = "0x400020D")]
	LightOrange = 29,
	[Cpp2IlInjected.Token(Token = "0x400020E")]
	LightYellow = 30,
	[Cpp2IlInjected.Token(Token = "0x400020F")]
	Cyan = 31,
	[Cpp2IlInjected.Token(Token = "0x4000210")]
	LightPurple = 32,
	[Cpp2IlInjected.Token(Token = "0x4000211")]
	DarkTan = 33,
	[Cpp2IlInjected.Token(Token = "0x4000212")]
	NewColor1 = 34,
	[Cpp2IlInjected.Token(Token = "0x4000213")]
	NewColor2 = 35,
	[Cpp2IlInjected.Token(Token = "0x4000214")]
	NewColor3 = 36,
	[Cpp2IlInjected.Token(Token = "0x4000215")]
	NewColor4 = 37,
	[Cpp2IlInjected.Token(Token = "0x4000216")]
	NewColor5 = 38,
	[Cpp2IlInjected.Token(Token = "0x4000217")]
	NewColor6 = 39,
	[Cpp2IlInjected.Token(Token = "0x4000218")]
	NewColor7 = 40,
	[Cpp2IlInjected.Token(Token = "0x4000219")]
	NewColor8 = 41,
	[Cpp2IlInjected.Token(Token = "0x400021A")]
	NewColor9 = 42,
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	NewColor10 = 43,
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	NewColor11 = 44,
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	NewColor12 = 45,
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	NewColor13 = 46,
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	NewColor14 = 47,
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	NewColor15 = 48,
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	NewColor16 = 49,
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	NewColor17 = 50,
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	NewColor18 = 51,
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	NewColor19 = 52,
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	NewColor20 = 53,
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	NewColor21 = 54,
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	NewColor22 = 55,
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	NewColor23 = 56,
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	NewColor24 = 57,
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	NewColor25 = 58,
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	NewColor26 = 59,
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	NewColor27 = 60,
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	Default = 0
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.RRGuid("C57BE511-BA1A-4D83-BA58-303F34F4DE74")]
[RecRoom.DataLayer.Range(-1, 31)]
public enum DDBKNDGEJJI
{
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	Cardboard = 0,
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	Neon = 1,
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	Brick = 2,
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	Carpet = 3,
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	Dirt = 4,
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	Grass = 5,
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	MetalReflective = 6,
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	Concrete = 7,
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	Linoleum = 8,
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	Plaster = 9,
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	WoodLogs = 10,
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	WoodBoards = 11,
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	WoodGrain = 12,
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	WoodFloor = 13,
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	Sand = 14,
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	GlossyPlastic = 15,
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	Cloth = 16,
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	RubberFloor = 17,
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	MetalFloorTread = 18,
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	PaintedBrick = 19,
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	Crashpad = 20,
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	PaintedWood = 21,
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	GripTape = 22,
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	GalvanizedMetal = 23,
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	ParticleBoard = 24,
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	CheckeredFloor = 25,
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	SparklyVinyl = 26,
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	Gravel = 27,
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	Rock = 28,
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	Placeholder29 = 29,
	[Cpp2IlInjected.Token(Token = "0x400024E")]
	Placeholder30 = 30,
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	Placeholder31 = 31,
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	COUNT = 32,
	[Cpp2IlInjected.Token(Token = "0x4000251")]
	MIN = -1,
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	MAX = 31,
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	Default = 0
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
[RecRoom.DataLayer.RRGuid("112F004A-C92F-4055-99F9-D430EC13FE3C")]
[RecRoom.DataLayer.NetworkStruct(1, false)]
public struct OOOKFBDHBLL : IComparable<OOOKFBDHBLL>, IEquatable<OOOKFBDHBLL>
{
	[Cpp2IlInjected.Token(Token = "0x4000254")]
	public static readonly OOOKFBDHBLL MAEOIBKNBOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000255")]
	[RecRoom.DataLayer.Field(1)]
	public uint PKODLLGJIME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000256")]
	[RecRoom.DataLayer.Field(2)]
	public uint KGCFBGEJCLJ;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	private readonly uint OMKMBFMCFAL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x75975F0", Offset = "0x75969F0", VA = "0x1875975F0")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public readonly bool DAHIKGIHLLP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x75975E0", Offset = "0x75969E0", VA = "0x1875975E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x7597A60", Offset = "0x7596E60", VA = "0x187597A60")]
	public OOOKFBDHBLL(int PKODLLGJIME, int CNJEINKMLMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x7597A60", Offset = "0x7596E60", VA = "0x187597A60")]
	public OOOKFBDHBLL(uint PKODLLGJIME, uint CNJEINKMLMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x7597AC0", Offset = "0x7596EC0", VA = "0x187597AC0")]
	private OOOKFBDHBLL(uint PKODLLGJIME, uint CNJEINKMLMI, bool BBFMNDEIFCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x75974E0", Offset = "0x75968E0", VA = "0x1875974E0")]
	public OOOKFBDHBLL FBDPOLFBGGC(int FGCNBOMLCIC = 1)
	{
		return default(OOOKFBDHBLL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x7597910", Offset = "0x7596D10", VA = "0x187597910")]
	public OOOKFBDHBLL NHKEPFCMFLK(int FGCNBOMLCIC = 1)
	{
		return default(OOOKFBDHBLL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x7597600", Offset = "0x7596A00", VA = "0x187597600")]
	public static OOOKFBDHBLL JIAHKLEAAKN(OOOKFBDHBLL BBGKOKBOEGA, OOOKFBDHBLL NBNHMPFPBPM)
	{
		return default(OOOKFBDHBLL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x75973F0", Offset = "0x75967F0", VA = "0x1875973F0")]
	private static ulong EFGPKCKKMCM(ulong FJLJDCJDABK, ulong DOGHGFGEHNK)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x75973D0", Offset = "0x75967D0", VA = "0x1875973D0", Slot = "4")]
	public int CompareTo(OOOKFBDHBLL MNALNBMKJLK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x7597450", Offset = "0x7596850", VA = "0x187597450", Slot = "0")]
	public override bool Equals(object NBAMGPFDMIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x7597980", Offset = "0x7596D80", VA = "0x187597980", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x7597430", Offset = "0x7596830", VA = "0x187597430", Slot = "5")]
	public bool Equals(OOOKFBDHBLL MNALNBMKJLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x7597590", Offset = "0x7596990", VA = "0x187597590", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x34AE540", Offset = "0x34AD940", VA = "0x1834AE540")]
	public static bool JECEAGOPPKI(OOOKFBDHBLL BBGKOKBOEGA, OOOKFBDHBLL NBNHMPFPBPM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x75978F0", Offset = "0x7596CF0", VA = "0x1875978F0")]
	public static bool NEBBLIKBPGD(OOOKFBDHBLL BBGKOKBOEGA, OOOKFBDHBLL NBNHMPFPBPM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x7597570", Offset = "0x7596970", VA = "0x187597570")]
	public static bool GGACLCHLFOO(OOOKFBDHBLL BBGKOKBOEGA, OOOKFBDHBLL NBNHMPFPBPM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x7597550", Offset = "0x7596950", VA = "0x187597550")]
	public static bool FFAHAKKJJJB(OOOKFBDHBLL BBGKOKBOEGA, OOOKFBDHBLL NBNHMPFPBPM)
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
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		[RecRoom.DataLayer.Field(1)]
		public int4 data;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public Guid Guid
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x109EED0", Offset = "0x109E2D0", VA = "0x18109EED0")]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x109EEE0", Offset = "0x109E2E0", VA = "0x18109EEE0")]
			set
			{
			}
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x109EED0", Offset = "0x109E2D0", VA = "0x18109EED0")]
		public static Guid JKGHIELMIOO(NetworkGuid BCIHOIBCNMJ)
		{
			return default(Guid);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x109EED0", Offset = "0x109E2D0", VA = "0x18109EED0")]
		public static NetworkGuid JKGHIELMIOO(Guid BCIHOIBCNMJ)
		{
			return default(NetworkGuid);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x7597380", Offset = "0x7596780", VA = "0x187597380", Slot = "4")]
		public bool Equals(NetworkGuid MNALNBMKJLK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x4813190", Offset = "0x4812590", VA = "0x184813190", Slot = "5")]
		public int CompareTo(NetworkGuid MNALNBMKJLK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x75973B0", Offset = "0x75967B0", VA = "0x1875973B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
[RecRoom.DataLayer.NetworkStruct(1, false)]
[RecRoom.DataLayer.RRGuid("9F5F33BE-7C0A-4870-9CE0-BA79440E7F98")]
public struct AOEEPDNIMOA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000258")]
	[RecRoom.DataLayer.Field(1)]
	public bool KFMEJIELJKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000259")]
	[RecRoom.DataLayer.Field(2)]
	public float3 MEPPCNKLELG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400025A")]
	[RecRoom.DataLayer.Field(3)]
	public float3 NNNKDAFPCKG;

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x75927C0", Offset = "0x7591BC0", VA = "0x1875927C0")]
	public AOEEPDNIMOA(float IKENCPHIKGM, float MNJHKANCBHC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
[RecRoom.DataLayer.RRGuid("35984D5B-ACBD-4389-A94B-840070A871E2")]
[RecRoom.DataLayer.NetworkStruct(1, false)]
public struct EBCIGMMPLDE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400025B")]
	[RecRoom.DataLayer.Field(1)]
	public float LLDHCAGLFJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400025C")]
	[RecRoom.DataLayer.Field(2)]
	public int BIFPCJAGKME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400025D")]
	[RecRoom.DataLayer.Field(3)]
	public DODFNBNEDGP NHJKDMPGJCM;

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public bool FIPBCFDKLOF
	{
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x7594D30", Offset = "0x7594130", VA = "0x187594D30")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x7594D90", Offset = "0x7594190", VA = "0x187594D90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public bool IGPBMMLECKH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x7594D80", Offset = "0x7594180", VA = "0x187594D80")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x7594D40", Offset = "0x7594140", VA = "0x187594D40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public bool PLJCMFPPIHP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x7594D20", Offset = "0x7594120", VA = "0x187594D20")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x7594D60", Offset = "0x7594160", VA = "0x187594D60")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public class MLMAHFCKIOO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400025E")]
	public DEHIGIKHMNG LMHKBJEFPIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400025F")]
	public int OIGDJAIFCJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000260")]
	public bool HHIOEMFBFMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D")]
	[Cpp2IlInjected.Token(Token = "0x4000261")]
	public bool NINDNNFIAFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E")]
	[Cpp2IlInjected.Token(Token = "0x4000262")]
	public bool NPIIKIHCGCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000263")]
	public Vector3 LLLAMAJMODF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000264")]
	public Quaternion ANFMFACGGJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000265")]
	public bool NOPINFKNLNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000266")]
	public Vector3 OJKGCKCDMHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000267")]
	public Vector3 IPEIEGLFJCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000268")]
	public Vector3 FLJNEDGHJGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000269")]
	public bool ILHACFFBMLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400026A")]
	protected ViewId EOHNOAPMNMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x400026B")]
	protected FEAIBEEBOCE GHHODIEFMKF;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public ViewId KJPGDIIKIGB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x7596500", Offset = "0x7595900", VA = "0x187596500")]
		get
		{
			return default(ViewId);
		}
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0xDF8A00", Offset = "0xDF7E00", VA = "0x180DF8A00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x75965A0", Offset = "0x75959A0", VA = "0x1875965A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
	public MLMAHFCKIOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public struct PBHJCKBALOJ : IEquatable<PBHJCKBALOJ>, IComparable<PBHJCKBALOJ>
{
	[Cpp2IlInjected.Token(Token = "0x400026C")]
	public static readonly int PFGGMDJIJNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400026D")]
	public RRObjectPrefabData EPNPEBHIEBC;

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x7597D10", Offset = "0x7597110", VA = "0x187597D10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x7597C70", Offset = "0x7597070", VA = "0x187597C70", Slot = "4")]
	public bool Equals(PBHJCKBALOJ MNALNBMKJLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x7597B70", Offset = "0x7596F70", VA = "0x187597B70", Slot = "0")]
	public override bool Equals(object NBAMGPFDMIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x7597CE0", Offset = "0x75970E0", VA = "0x187597CE0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x7597B40", Offset = "0x7596F40", VA = "0x187597B40", Slot = "5")]
	public int CompareTo(PBHJCKBALOJ MNALNBMKJLK)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
internal class CEABDJGGPEE : ContainerPropertyBag<KGINFMABLHE>
{
	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x75947A0", Offset = "0x7593BA0", VA = "0x1875947A0")]
	public CEABDJGGPEE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
internal class INMDEOEJLJL : ContainerPropertyBag<RRObjectPrefabData>
{
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	private class JHDLJPCGAML : Property<RRObjectPrefabData, CNBJKFKGILJ>
	{
		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public override string NAMECGEJFMI
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x7595A70", Offset = "0x7594E70", VA = "0x187595A70", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public override bool FBPFCDPCCGG
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x9AFB60", Offset = "0x9AEF60", VA = "0x1809AFB60", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x7595980", Offset = "0x7594D80", VA = "0x187595980")]
		public JHDLJPCGAML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x1F83240", Offset = "0x1F82640", VA = "0x181F83240", Slot = "14")]
		public override CNBJKFKGILJ GetValue(RRObjectPrefabData EOMAFKDOFHE)
		{
			return default(CNBJKFKGILJ);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x7583390", Offset = "0x7582790", VA = "0x187583390", Slot = "15")]
		public override void SetValue(RRObjectPrefabData EOMAFKDOFHE, CNBJKFKGILJ PEBNJNGMMHE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008C")]
	private class JKJKNCMEOAO : Property<RRObjectPrefabData, Guid>
	{
		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public override string NAMECGEJFMI
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x7595BA0", Offset = "0x7594FA0", VA = "0x187595BA0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public override bool FBPFCDPCCGG
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x9AFB60", Offset = "0x9AEF60", VA = "0x1809AFB60", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x7595AB0", Offset = "0x7594EB0", VA = "0x187595AB0")]
		public JKJKNCMEOAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x2B9A700", Offset = "0x2B99B00", VA = "0x182B9A700", Slot = "14")]
		public override Guid GetValue(RRObjectPrefabData EOMAFKDOFHE)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x7595AA0", Offset = "0x7594EA0", VA = "0x187595AA0", Slot = "15")]
		public override void SetValue(RRObjectPrefabData EOMAFKDOFHE, Guid PEBNJNGMMHE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x75956E0", Offset = "0x7594AE0", VA = "0x1875956E0")]
	public INMDEOEJLJL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
internal class GMPHBKDECGK : ContainerPropertyBag<Guid>
{
	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x7595480", Offset = "0x7594880", VA = "0x187595480")]
	public GMPHBKDECGK()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x7597D60", Offset = "0x7597160", VA = "0x187597D60")]
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
