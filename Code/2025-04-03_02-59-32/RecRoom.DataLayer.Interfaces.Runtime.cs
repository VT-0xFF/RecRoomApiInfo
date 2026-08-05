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
		[Cpp2IlInjected.Address(RVA = "0x9BE830", Offset = "0x9BDC30", VA = "0x1809BE830")]
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
		[Cpp2IlInjected.Address(RVA = "0x9BE830", Offset = "0x9BDC30", VA = "0x1809BE830")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace _LogRegistration.RecRoom_DataLayer_Interfaces_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[RecRoom.Logging.Attributes.Preserve]
	[CompilerGenerated]
	public class LogRegistrationIndex : BDONJGGEMII
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7832910", Offset = "0x7831D10", VA = "0x187832910", Slot = "4")]
		public override void GEAMIGHEOPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9BE830", Offset = "0x9BDC30", VA = "0x1809BE830")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct FMMLDNMHJDH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private bool GMKPMNDBJMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private ViewId EOLCOMIJKHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private int HGHGCNDALFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private bool GJJGCJDCBAC;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7831280", Offset = "0x7830680", VA = "0x187831280")]
	public FMMLDNMHJDH(ViewId EOLCOMIJKHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x78312A0", Offset = "0x78306A0", VA = "0x1878312A0")]
	public FMMLDNMHJDH(int HGHGCNDALFP, bool GJJGCJDCBAC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x78311A0", Offset = "0x78305A0", VA = "0x1878311A0")]
	public ViewId OGIBAFDIDGL([Optional] ViewId CFEAHIBDGIO)
	{
		return default(ViewId);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class EDLAEPCBOMB
{
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly Guid LFODKEFMFCC;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static readonly Guid ANBGDDKDBNO;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static readonly Guid KIJKDEDOACB;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public static readonly Guid GFCCOGFKMOM;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly Guid CJAFBBBAFFF;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public static readonly Dictionary<string, Guid> NJALJJMICFJ;

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static readonly RRObjectPrefabData OJBGLNGCJBH;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly RRObjectPrefabData CLIJIOGIBMF;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly RRObjectPrefabData FHPCOMFAMEK;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7830BF0", Offset = "0x782FFF0", VA = "0x187830BF0")]
	public static Guid OFGOLCNFJDB(string IGEPDAOOLBO)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7830B80", Offset = "0x782FF80", VA = "0x187830B80")]
	public static RRObjectPrefabData NDAHCCGPKNC(CGLGBAJFIGE HAFNBBNOLPO)
	{
		return default(RRObjectPrefabData);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7830B10", Offset = "0x782FF10", VA = "0x187830B10")]
	public static RRObjectPrefabData EJPEODKEIBE(CGLGBAJFIGE HAFNBBNOLPO)
	{
		return default(RRObjectPrefabData);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7830B60", Offset = "0x782FF60", VA = "0x187830B60")]
	public static RRObjectPrefabData IJAIJDOHLFK(Guid KDBHLLEACIN)
	{
		return default(RRObjectPrefabData);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[DefaultMember("Item")]
public class IDCEMKBPIKO : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly Dictionary<int, object> HPMNBNLACCC;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public Dictionary<int, object> EEHHJHNNGPO
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x9943E0", Offset = "0x9937E0", VA = "0x1809943E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public object JODHLAKLPCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x78316F0", Offset = "0x7830AF0", VA = "0x1878316F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x7831880", Offset = "0x7830C80", VA = "0x187831880")]
	public IDCEMKBPIKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x99CAA0", Offset = "0x99BEA0", VA = "0x18099CAA0")]
	public IDCEMKBPIKO(Dictionary<int, object> HPMNBNLACCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7831820", Offset = "0x7830C20", VA = "0x187831820")]
	public bool JHOPICCACKP(NOLLPMEIIAL DJBLFBEBKGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x360A920", Offset = "0x3609D20", VA = "0x18360A920")]
	public void BLADEKKAEKH<T>(NOLLPMEIIAL DJBLFBEBKGO, T FFOEEMKIKJO, [Optional] T PFCPDJEHNAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x360AE50", Offset = "0x360A250", VA = "0x18360AE50")]
	public void JFGGMENNDNP<T>(NOLLPMEIIAL DJBLFBEBKGO, T FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x78317C0", Offset = "0x7830BC0", VA = "0x1878317C0")]
	public void JEBJOEBLLEI(NOLLPMEIIAL DJBLFBEBKGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7831750", Offset = "0x7830B50", VA = "0x187831750", Slot = "4")]
	public object Clone()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum NOLLPMEIIAL : byte
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
public struct PACEDMJLMPG<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public readonly NOLLPMEIIAL DJBLFBEBKGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly T PFCPDJEHNAP;

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x426F5F0", Offset = "0x426E9F0", VA = "0x18426F5F0")]
	public PACEDMJLMPG(NOLLPMEIIAL DJBLFBEBKGO, T PFCPDJEHNAP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x52B9190", Offset = "0x52B8590", VA = "0x1852B9190")]
	public static PACEDMJLMPG<T> CLMIANKGGAM(NOLLPMEIIAL DJBLFBEBKGO)
	{
		return default(PACEDMJLMPG<T>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x52B8FA0", Offset = "0x52B83A0", VA = "0x1852B8FA0")]
	public static PACEDMJLMPG<T> CLMIANKGGAM((NOLLPMEIIAL key, T value) PCMHLCLONGN)
	{
		return default(PACEDMJLMPG<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(HFMKHMBFCDH))]
public struct NKNHEFKHIEC : IEnumerable<object>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private class HFMKHMBFCDH : Dictionary<string, object>
	{
	}

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private static readonly GBHBOJAPDOA DPDKJPMBJOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private Dictionary<int, object> MHBNBGGMEBA;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool IDHODAIBOAG
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x15F77B0", Offset = "0x15F6BB0", VA = "0x1815F77B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int GMILMIAEFMI
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7832BD0", Offset = "0x7831FD0", VA = "0x187832BD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7832C20", Offset = "0x7832020", VA = "0x187832C20")]
	public static NKNHEFKHIEC GNHEPACBJCH()
	{
		return default(NKNHEFKHIEC);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0xC6E720", Offset = "0xC6DB20", VA = "0x180C6E720")]
	public NKNHEFKHIEC([Optional] Dictionary<int, object> MHBNBGGMEBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x37C51D0", Offset = "0x37C45D0", VA = "0x1837C51D0")]
	public void JJBKLNLGAIJ<T>(PACEDMJLMPG<T> DJBLFBEBKGO, T? FFOEEMKIKJO) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x37C4FF0", Offset = "0x37C43F0", VA = "0x1837C4FF0")]
	public void JJBKLNLGAIJ<T>((PACEDMJLMPG<T> key, T value) FMHCAJGAFOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x37C4E80", Offset = "0x37C4280", VA = "0x1837C4E80")]
	public void JJBKLNLGAIJ<T>(PACEDMJLMPG<T> DJBLFBEBKGO, T FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7832DB0", Offset = "0x78321B0", VA = "0x187832DB0")]
	public void KJPCKFGIEPN(NKNHEFKHIEC IEAOMLJNJLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7832B50", Offset = "0x7831F50", VA = "0x187832B50")]
	private void BECHPFCMIHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x37C2CA0", Offset = "0x37C20A0", VA = "0x1837C2CA0")]
	public bool BGPIDOLLEKE<T>(PACEDMJLMPG<T> DJBLFBEBKGO, [Out] T FFOEEMKIKJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x37C28F0", Offset = "0x37C1CF0", VA = "0x1837C28F0")]
	public bool BGPIDOLLEKE<T>(NOLLPMEIIAL DJBLFBEBKGO, [Out] T FFOEEMKIKJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x37C5E90", Offset = "0x37C5290", VA = "0x1837C5E90")]
	public T KCBEIPLNMMP<T>(PACEDMJLMPG<T> DJBLFBEBKGO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x37C4D60", Offset = "0x37C4160", VA = "0x1837C4D60")]
	public bool JHOPICCACKP<T>(PACEDMJLMPG<T> DJBLFBEBKGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7832D50", Offset = "0x7832150", VA = "0x187832D50")]
	public bool JHOPICCACKP(NOLLPMEIIAL DJBLFBEBKGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x37C4A50", Offset = "0x37C3E50", VA = "0x1837C4A50")]
	public void JEBJOEBLLEI<T>(PACEDMJLMPG<T> DJBLFBEBKGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7832D00", Offset = "0x7832100", VA = "0x187832D00")]
	public void JEBJOEBLLEI(NOLLPMEIIAL DJBLFBEBKGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0xC6E710", Offset = "0xC6DB10", VA = "0x180C6E710")]
	public Dictionary<int, object> FDPPAEPJFEF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7832CA0", Offset = "0x78320A0", VA = "0x187832CA0", Slot = "4")]
	public IEnumerator<object> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7832FC0", Offset = "0x78323C0", VA = "0x187832FC0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public enum IMGCEHKJKLL
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
	AnimationControllerComponents,
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	StudioObjectComponents
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface LBONLJHNMPC
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public enum LBLHFGLMECJ
	{
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		Entity,
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		Prefab
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	LocalId DJCDNMAFMIE
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	RRObjectPrefabData LFLPDIBCMLF
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BAAMOGNGJDM(params string[] CODPILFJFBC);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MLHNDDLKEII(IMGCEHKJKLL DINPFLHAPHF, LBLHFGLMECJ KGLDBFDNHBG = LBLHFGLMECJ.Entity);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GJKNGBBGIIG(Type HAFNBBNOLPO, ReadOnlySpan<byte> HPMNBNLACCC, int LEKAJJOJHOD, LBLHFGLMECJ KGLDBFDNHBG = LBLHFGLMECJ.Entity);

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MINAAJJLMLB(Type HAFNBBNOLPO, LBLHFGLMECJ KGLDBFDNHBG = LBLHFGLMECJ.Entity);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void LLHJIOLBJOM(IMGCEHKJKLL DINPFLHAPHF, LBLHFGLMECJ KGLDBFDNHBG = LBLHFGLMECJ.Entity);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool IOMAMOAAKGN(IMGCEHKJKLL DINPFLHAPHF);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void CENLJLKIKHK(bool FLEDEALCEPP, LBLHFGLMECJ KGLDBFDNHBG = LBLHFGLMECJ.Entity);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void MCCEPLAPEGL();
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class BFEBFCHNHDB
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x782FA30", Offset = "0x782EE30", VA = "0x18782FA30")]
	public static bool NJEJCMAGHIG(this LBONLJHNMPC PCJJKLDOJMD, IMGCEHKJKLL EOGFPKLNIAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x782F9D0", Offset = "0x782EDD0", VA = "0x18782F9D0")]
	public static void MLPEBPFAADH(this LBONLJHNMPC PCJJKLDOJMD, LBONLJHNMPC.LBLHFGLMECJ KGLDBFDNHBG = LBONLJHNMPC.LBLHFGLMECJ.Entity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x782F970", Offset = "0x782ED70", VA = "0x18782F970")]
	public static void DFGJEDJOIAC(this LBONLJHNMPC PCJJKLDOJMD, LBONLJHNMPC.LBLHFGLMECJ KGLDBFDNHBG = LBONLJHNMPC.LBLHFGLMECJ.Entity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x3376430", Offset = "0x3375830", VA = "0x183376430")]
	public static void FIOEBIIFNAK<T>(this LBONLJHNMPC PCJJKLDOJMD, LBONLJHNMPC.LBLHFGLMECJ KGLDBFDNHBG = LBONLJHNMPC.LBLHFGLMECJ.Entity) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3378250", Offset = "0x3377650", VA = "0x183378250")]
	public static void HGBONNOIGBM<T>(this LBONLJHNMPC PCJJKLDOJMD, LBONLJHNMPC.LBLHFGLMECJ KGLDBFDNHBG = LBONLJHNMPC.LBLHFGLMECJ.Entity) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3376510", Offset = "0x3375910", VA = "0x183376510")]
	public static void GEOEMDPGHPA<T>(this LBONLJHNMPC PCJJKLDOJMD, bool DBHDBLKAAMJ, LBONLJHNMPC.LBLHFGLMECJ KGLDBFDNHBG = LBONLJHNMPC.LBLHFGLMECJ.Entity) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x3376730", Offset = "0x3375B30", VA = "0x183376730")]
	public static void GJKNGBBGIIG<T>(this LBONLJHNMPC PCJJKLDOJMD, T FFOEEMKIKJO, LBONLJHNMPC.LBLHFGLMECJ KGLDBFDNHBG = LBONLJHNMPC.LBLHFGLMECJ.Entity) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x3378280", Offset = "0x3377680", VA = "0x183378280")]
	public static void MINAAJJLMLB<T>(this LBONLJHNMPC PCJJKLDOJMD, LBONLJHNMPC.LBLHFGLMECJ KGLDBFDNHBG = LBONLJHNMPC.LBLHFGLMECJ.Entity) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3376470", Offset = "0x3375870", VA = "0x183376470")]
	public static void FOMGBAIBHGB<T>(this LBONLJHNMPC PCJJKLDOJMD, LocalId KJCJJFGLKEE, LBONLJHNMPC.LBLHFGLMECJ KGLDBFDNHBG = LBONLJHNMPC.LBLHFGLMECJ.Entity) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x3376580", Offset = "0x3375980", VA = "0x183376580")]
	private static void GJKNGBBGIIG<T>(this LBONLJHNMPC PCJJKLDOJMD, Type HAFNBBNOLPO, T FFOEEMKIKJO, LBONLJHNMPC.LBLHFGLMECJ KGLDBFDNHBG = LBONLJHNMPC.LBLHFGLMECJ.Entity) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface PPOOIPHJPLD
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	Entity LPLOADAFMNM
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
public interface NGCJMMEPCHC
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void Bake(LBONLJHNMPC PCJJKLDOJMD);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface PBNCDCMIFPF
{
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CLOBGGHMELO(OLEMOLOENHO LGLPENFMNLD);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ACHLIELOPKD(OLEMOLOENHO LGLPENFMNLD);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface DADFFKFEBPK
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	ViewId DJDJEMPIEDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface EALHJCEOOHG : DADFFKFEBPK, OCLPABABAMG
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GDCNGOALEGL(ViewId FJMKAEOKOHP, ViewId GGKGLNFMPHD, Dictionary<int, object> JLLDPNEPEEK, OLEMOLOENHO EAOBCLAGGPD);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface AEBACOJCCKK : DADFFKFEBPK
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GDCNGOALEGL(BCEABACEBEP KLDFHLFOOFN, Vector3 MABKBAPDDLM, Quaternion NHANCIDGOLF, Vector3 GGIGFLDDKFE, bool OCAFPEPJNIB);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EGHPPMJPGCH(Vector3 MABKBAPDDLM, Quaternion NHANCIDGOLF, Vector3 GGIGFLDDKFE);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EMLOMBIHCBC(ViewId KLDFHLFOOFN);

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FEEHOAIAMPD(bool OCKPNBNLJIO);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CCMKHOCGBDM(bool DALOHEAPGAC);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface OCLPABABAMG
{
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AGCIDHOEPLK();
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface ICNFPDEEJIF
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NativeArray<Guid> BDLFMBIOCAL(World AGLNINADJCM, NativeArray<Entity> MGNIPLBHEJL, Allocator JMEGNHGDHIA);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct ABKFHOKLMEO : IComponentData, IEquatable<ABKFHOKLMEO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	[RecRoom.DataLayer.Default]
	[RecRoom.DataLayer.Field(1)]
	public uint HDKOPKMNJCH;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x782F570", Offset = "0x782E970", VA = "0x18782F570", Slot = "4")]
	public bool Equals(ABKFHOKLMEO KNCKFHOKGJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x782F4E0", Offset = "0x782E8E0", VA = "0x18782F4E0", Slot = "0")]
	public override bool Equals(object BLFGIKOAKOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x11D2130", Offset = "0x11D1530", VA = "0x1811D2130", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[RecRoom.DataLayer.RRGuid("A8D1A28C-A057-4DF1-B0CF-22A81E217E19")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(11322240854101484093uL)]
	[SwatchPrimaryKey]
	public struct AuthoredAIIdData : IComponentData, IEquatable<AuthoredAIIdData>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public uint Value;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x782F570", Offset = "0x782E970", VA = "0x18782F570", Slot = "4")]
		public bool Equals(AuthoredAIIdData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x782F7F0", Offset = "0x782EBF0", VA = "0x18782F7F0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x11D2130", Offset = "0x11D1530", VA = "0x1811D2130", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[RecRoom.DataLayer.StableTypeHash(11505792609904010668uL, 0u)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(11505792609904010668uL)]
	[RecRoom.DataLayer.RRGuid("B7CEB5B9-453F-4712-B833-27D907AA13E2")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct AuthoredLocalPoseData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default("new quaternion(new float4(float.NaN))")]
		public quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		[RecRoom.DataLayer.Default("new float3(float.NaN)")]
		[RecRoom.DataLayer.Field(2)]
		public float3 localPosition;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public readonly bool IsValid
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x782F8A0", Offset = "0x782ECA0", VA = "0x18782F8A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x4E105F0", Offset = "0x4E0F9F0", VA = "0x184E105F0")]
		public AuthoredLocalPoseData(quaternion localRotation, float3 localPosition)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x782F880", Offset = "0x782EC80", VA = "0x18782F880")]
		public static RigidTransform CLMIANKGGAM(AuthoredLocalPoseData poseData)
		{
			return default(RigidTransform);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x782F880", Offset = "0x782EC80", VA = "0x18782F880")]
		public static AuthoredLocalPoseData CLMIANKGGAM(RigidTransform pose)
		{
			return default(AuthoredLocalPoseData);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class HHDDMLEOIJA
{
	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x78316C0", Offset = "0x7830AC0", VA = "0x1878316C0")]
	public static AuthoredLocalPoseData NJPFAAMABBM([In] this RigidTransform FFOEEMKIKJO)
	{
		return default(AuthoredLocalPoseData);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0xBD44B0", Offset = "0xBD38B0", VA = "0x180BD44B0")]
	public static RigidTransform OJGIEBMEPIB(this AuthoredLocalPoseData FFOEEMKIKJO)
	{
		return default(RigidTransform);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7831690", Offset = "0x7830A90", VA = "0x187831690")]
	public static RigidTransform NGHGJCBLFNI([In] this AuthoredLocalPoseData FFOEEMKIKJO)
	{
		return default(RigidTransform);
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[RecRoom.DataLayer.RRGuid("C26C4B4E-5EF3-4F81-87C8-FED8EAD37242")]
	[TypeManager.ForcedStableTypeHash(9088562008033959482uL)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[CompilerGenerated]
	[RecRoom.DataLayer.StableTypeHash(9088562008033959482uL, 0u)]
	public struct AuthoredLocalUniformScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default(1f)]
		public float localUniformScale;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public readonly bool IsValid
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x782F900", Offset = "0x782ED00", VA = "0x18782F900")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x2860350", Offset = "0x285F750", VA = "0x182860350")]
		public AuthoredLocalUniformScaleData(float localUniformScale)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("7B1B8635-3FA9-4ADC-922B-3C25CE0C7E7D")]
	[CompilerGenerated]
	[RecRoom.DataLayer.StableTypeHash(10137300772124140051uL, 0u)]
	[TypeManager.ForcedStableTypeHash(10137300772124140051uL)]
	public struct AuthoredParentData : IComponentData, PPOOIPHJPLD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public Entity parent;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0xC6E710", Offset = "0xC6DB10", VA = "0x180C6E710", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xE3A760", Offset = "0xE39B60", VA = "0x180E3A760", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xE3A760", Offset = "0xE39B60", VA = "0x180E3A760")]
		public AuthoredParentData(Entity parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x782F960", Offset = "0x782ED60", VA = "0x18782F960", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001E")]
public struct IFBHJJBLCLE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001F")]
[TypeManager.ForcedStableTypeHash(11776442497872827640uL)]
public struct LNFPPCKDNLG : IComponentData
{
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[RecRoom.DataLayer.StableTypeHash(8594223769175916906uL, 0u)]
	[TypeManager.ForcedStableTypeHash(8594223769175916906uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.RRGuid("B9A63EF5-66A5-463C-8385-A7DC7CE137C3")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct ObjectBoardNodeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public NetworkGuid nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(2)]
		public NetworkGuid graphId;
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[TypeManager.ForcedStableTypeHash(5933855128949143734uL)]
	[RecRoom.DataLayer.RRGuid("B26EF01D-F674-4506-80B7-5345391A097E")]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct ReplicatedObjectActiveStatusData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		[RecRoom.DataLayer.Default(true)]
		[RecRoom.DataLayer.Field(1)]
		public bool active;
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("E9BA10A4-4EE9-431D-BD7F-FF2008ABFA03")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(16338184133650423946uL)]
	public struct ReplicatedObjectOwnedByPlayerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		[RecRoom.DataLayer.Default(-1)]
		[RecRoom.DataLayer.Field(1)]
		public int actorId;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000023")]
public struct EOHOANFNIIL : IComponentData
{
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[RecRoom.DataLayer.RRGuid("46C500A2-9991-4987-B1AA-66E5C3D8E371")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[TypeManager.ForcedStableTypeHash(16223816226138460552uL)]
	[CompilerGenerated]
	public struct ReplicatedObjectTag : IComponentData
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(17912083982325865811uL)]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	[RecRoom.DataLayer.RRGuid("5ED157AA-488F-453A-A986-594595B8D777")]
	public struct ReplicatorData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public Entity Target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		[RecRoom.DataLayer.Field(2)]
		[RecRoom.DataLayer.Default(false)]
		public bool NeedsCircuitUpdate;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct EFFCPGJDJDD : IComponentData
{
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[TypeManager.ForcedStableTypeHash(8691279933813304851uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.RRGuid("AEA4D222-29BA-462F-9C0A-AA2063671C68")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct ReplicatorMaxObjectCountData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default(10)]
		public int count;
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[TypeManager.ForcedStableTypeHash(16379995002884076574uL)]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	[RecRoom.DataLayer.RRGuid("400790C1-E8D9-4779-A549-3780DAEC2FDF")]
	[CompilerGenerated]
	public struct ReplicatorPreallocatedObjectCountData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default(0)]
		public int preallocatedCopies;
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[RecRoom.DataLayer.RRGuid("6A82044A-E392-4DCD-B4BC-A120E58334EA")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(8536678595025273356uL)]
	[RecRoom.DataLayer.StableTypeHash(8536678595025273356uL, 0u)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct EntityPrefabPartData : IComponentData, IComparable<EntityPrefabPartData>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public Entity prefabRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		[RecRoom.DataLayer.Field(2)]
		[RecRoom.DataLayer.Default]
		public uint partId;

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x78310D0", Offset = "0x78304D0", VA = "0x1878310D0", Slot = "4")]
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
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		[SerializeField]
		private uint id;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x11BE580", Offset = "0x11BD980", VA = "0x1811BE580")]
		internal EntityPrefabPartId(uint NCJKGMLAKGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x9E04A0", Offset = "0x9DF8A0", VA = "0x1809E04A0")]
		internal uint JJBLJLLLEON()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x202FBC0", Offset = "0x202EFC0", VA = "0x18202FBC0", Slot = "4")]
		public bool Equals(EntityPrefabPartId KNCKFHOKGJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x7831120", Offset = "0x7830520", VA = "0x187831120", Slot = "0")]
		public override bool Equals(object BLFGIKOAKOL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x11D2130", Offset = "0x11D1530", VA = "0x1811D2130", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x202FB30", Offset = "0x202EF30", VA = "0x18202FB30", Slot = "5")]
		public int CompareTo(EntityPrefabPartId KNCKFHOKGJM)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[TypeManager.ForcedStableTypeHash(15026348711748810383uL)]
public struct JAIPIICBNEE : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public Entity BNJHIIEDKCI;
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	[CompilerGenerated]
	[ConfigGroup("Physics", 0)]
	[TypeManager.ForcedStableTypeHash(2330616907306882483uL)]
	[RecRoom.DataLayer.RRGuid("F74D558B-BDCC-48C8-A8EF-1F7559E5EAA0")]
	public struct PhysicsModelCollisionModeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		[Config(null, 0)]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default(MEOCNMKGIFD.Children)]
		public MEOCNMKGIFD collisionMode;
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[ConfigGroup("Container", 0)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("8A12EB45-2A15-41CE-AFF7-90A9F984D3A2")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(11125590729425051511uL)]
	public struct ContainerIsRecolorableData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		[RecRoom.DataLayer.Field(1)]
		[Config(null, 0)]
		[RecRoom.DataLayer.Default]
		public bool IsRecolorable;
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[TypeManager.ForcedStableTypeHash(14800424556151816553uL)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[InternalBufferCapacity(0)]
	[CompilerGenerated]
	[RecRoom.DataLayer.RRGuid("55EAB643-95BB-4C3A-832C-798EBCD95AD5")]
	public struct ContainerNameBuffer : IBufferElementData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public byte data;
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[TypeManager.ForcedStableTypeHash(13657791279235747653uL)]
	[RecRoom.DataLayer.StableTypeHash(13657791279235747653uL, 0u)]
	[RecRoom.DataLayer.RRGuid("89708D57-D027-494A-A159-221E6C643B6B")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[ConfigGroup("Container", 0)]
	[CompilerGenerated]
	public struct ContainerNameData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		[Config(null, 0)]
		public FixedString64Bytes name;
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[ConfigGroup("Physics", 0)]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	[CompilerGenerated]
	[RecRoom.DataLayer.RRGuid("CA023286-E0F6-4DA9-A346-94E86B93977C")]
	[TypeManager.ForcedStableTypeHash(13904209480152351845uL)]
	public struct PhysicsModelGrabbableModeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		[Config(null, 0)]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public AMAHBNLCGNL grabbableMode;
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[RecRoom.DataLayer.RRGuid("84485C1B-18ED-4D4A-86A4-34CEED482615")]
	[ConfigGroup("Container", 0)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.StableTypeHash(16485879999901987510uL, 0u)]
	[TypeManager.ForcedStableTypeHash(16485879999901987510uL)]
	[CompilerGenerated]
	public struct NavMeshGenerationData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		[Config(null, 0)]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default(OAIMBNMHJKM.NavMeshGenerator)]
		public OAIMBNMHJKM mode;
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	[RecRoom.DataLayer.RRGuid("C5BCE8B3-6E69-41D4-921A-BE2E3E0A4DAB")]
	[CompilerGenerated]
	[ConfigGroup("Physics", 0)]
	[TypeManager.ForcedStableTypeHash(1954118413118190521uL)]
	public struct PhysicsModelCollisionLayerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		[RecRoom.DataLayer.Default(PJJDLHIAMPI.IsDynamicEnvironment)]
		[Config(null, 0)]
		[RecRoom.DataLayer.Field(1)]
		public PJJDLHIAMPI collisionLayer;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class AKLJKEFDKLP
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public enum GIDIJGBOELF
	{
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		Dynamic,
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		Static,
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		Enemy,
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		Vehicle
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public enum HOGABFBGAKA
	{
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		Environmental,
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		IgnoreStaticGeometry,
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		IgnoreOtherDynamic,
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		IgnorePlayers,
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		IgnoreMost,
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		Projectile
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x782F580", Offset = "0x782E980", VA = "0x18782F580")]
	public static (GIDIJGBOELF, HOGABFBGAKA) BOOKNIMNAAH(this PJJDLHIAMPI DMGLPHIJGLL)
	{
		return default((GIDIJGBOELF, HOGABFBGAKA));
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[RecRoom.DataLayer.RRGuid("F63AA9EA-6191-4DE9-BB18-1F049F432124")]
	[CompilerGenerated]
	[ConfigGroup("Physics", 0)]
	[RecRoom.DataLayer.NetworkComponent(4, false)]
	[TypeManager.ForcedStableTypeHash(16462677563651546047uL)]
	public struct PhysicsModelFlagsData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		[Config(null, 0)]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default(FECKIEFHJNO.DEFAULT)]
		public FECKIEFHJNO flags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[RecRoom.DataLayer.RRGuid("B6D08147-6AEA-4270-BDC4-8CF68662318D")]
	[TypeManager.ForcedStableTypeHash(1094837642118998916uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.StableTypeHash(1094837642118998916uL, 0u)]
	[ConfigGroup("Physics", 0)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct PhysicsModelMassOverrideData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		[Config(null, 0)]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default(0f)]
		public float mass;
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[RecRoom.DataLayer.RRGuid("D732BC3D-4F8D-4FDE-BDB2-88C095D973C2")]
	[RecRoom.DataLayer.StableTypeHash(1537567323754185605uL, 0u)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(1537567323754185605uL)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct CostumePieceParentCostumeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public Entity parentCostume;
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[TypeManager.ForcedStableTypeHash(5115014870530256079uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.StableTypeHash(5115014870530256079uL, 0u)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("36A2D516-8596-4794-BEAE-40BECA68C798")]
	public struct CostumePieceSlotIndexData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public int slotIndex;
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(10518841812724430444uL)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("17799917-98EE-4D9A-A8D1-B0BE5F7316E3")]
	public struct InventionIdData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default(0L)]
		public long inventionId;

		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public const long INVALID_INVENTION_ID = 0L;

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xBD44B0", Offset = "0xBD38B0", VA = "0x180BD44B0")]
		public static InventionIdData CLMIANKGGAM(long value)
		{
			return default(InventionIdData);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7831910", Offset = "0x7830D10", VA = "0x187831910")]
		public readonly bool MGNGDGHDPEM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x75909D0", Offset = "0x758FDD0", VA = "0x1875909D0")]
		public static bool MGNGDGHDPEM(long inventionId)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[RecRoom.DataLayer.RRGuid("629F0A56-C478-4353-BBDA-8A8BB5FEE478")]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	[TypeManager.ForcedStableTypeHash(14338988155392421373uL)]
	[RecRoom.DataLayer.TombstonedFields(new int[] { 1 })]
	[CompilerGenerated]
	public struct InventionInstanceIdData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(2)]
		public NetworkGuid instanceId;

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x1111790", Offset = "0x1110B90", VA = "0x181111790")]
		public static InventionInstanceIdData CLMIANKGGAM(Guid value)
		{
			return default(InventionInstanceIdData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[RecRoom.DataLayer.RRGuid("A3B27452-BD6C-43B2-BAFF-CF885EB1608B")]
	[TypeManager.ForcedStableTypeHash(12111354511484844847uL)]
	[RuntimeOnly]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.StableTypeHash(12111354511484844847uL, 0u)]
	[CompilerGenerated]
	public struct ParentData : IComponentData, PPOOIPHJPLD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public Entity parent;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0xC6E710", Offset = "0xC6DB10", VA = "0x180C6E710", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0xE3A760", Offset = "0xE39B60", VA = "0x180E3A760", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xE3A760", Offset = "0xE39B60", VA = "0x180E3A760")]
		public ParentData(Entity parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0xBD44B0", Offset = "0xBD38B0", VA = "0x180BD44B0")]
		public static implicit operator ParentData(Entity entity)
		{
			return default(ParentData);
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003D")]
public struct LCJFMHADJJP : IComponentData
{
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[RecRoom.DataLayer.StableTypeHash(1950029632769634832uL, 0u)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(1950029632769634832uL)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("c886150a-7231-4cc5-a2b2-f222500e6960")]
	public struct SiblingSortOrderData : IEquatable<SiblingSortOrderData>, IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public CPJAFFJHONJ order;

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xBD44B0", Offset = "0xBD38B0", VA = "0x180BD44B0")]
		public static SiblingSortOrderData CLMIANKGGAM(CPJAFFJHONJ value)
		{
			return default(SiblingSortOrderData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x782FD50", Offset = "0x782F150", VA = "0x18782FD50", Slot = "4")]
		public bool Equals(SiblingSortOrderData other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	[RecRoom.DataLayer.RRGuid("46CEA601-8AA7-423D-B1EA-EEABAE73413F")]
	[TypeManager.ForcedStableTypeHash(6217116203744017593uL)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct InteractionFilterAllTagsData : IComponentData, PPOOIPHJPLD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public Entity allTags;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xC6E710", Offset = "0xC6DB10", VA = "0x180C6E710", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0xE3A760", Offset = "0xE39B60", VA = "0x180E3A760", Slot = "5")]
			set
			{
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("49CEFD0F-3A38-4A9B-835E-10B4C2D08392")]
	[TypeManager.ForcedStableTypeHash(6215026851838101933uL)]
	[CompilerGenerated]
	public struct InteractionFilterAnyTagsData : IComponentData, PPOOIPHJPLD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public Entity anyTags;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0xC6E710", Offset = "0xC6DB10", VA = "0x180C6E710", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xE3A760", Offset = "0xE39B60", VA = "0x180E3A760", Slot = "5")]
			set
			{
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[TypeManager.ForcedStableTypeHash(6780642047612598977uL)]
	[RecRoom.DataLayer.RRGuid("11CE457F-4366-4AAD-B7E3-28D82B4FAFCF")]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct InteractionFilterEnabledData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		[RecRoom.DataLayer.Default(MHBPIDFNAAN.Disabled)]
		[RecRoom.DataLayer.Field(1)]
		public MHBPIDFNAAN filterMode;
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(6642820932987006861uL)]
	[RecRoom.DataLayer.RRGuid("F7789094-7D82-4D27-B805-2CC1B8C0A538")]
	public struct InteractionFilterEntityRefData : IComponentData, PPOOIPHJPLD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public Entity filterEntity;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xC6E710", Offset = "0xC6DB10", VA = "0x180C6E710", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0xE3A760", Offset = "0xE39B60", VA = "0x180E3A760", Slot = "5")]
			set
			{
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[RecRoom.DataLayer.RRGuid("C7E95AF7-DB7D-4432-8DAA-8F36EC6C4308")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(15467295871228743847uL)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct InteractionFilterNoneTagsData : IComponentData, PPOOIPHJPLD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public Entity noneTags;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0xC6E710", Offset = "0xC6DB10", VA = "0x180C6E710", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0xE3A760", Offset = "0xE39B60", VA = "0x180E3A760", Slot = "5")]
			set
			{
			}
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[TypeManager.ForcedStableTypeHash(15012400804589552708uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.RRGuid("007F8815-C87C-4E6B-BC56-3BA0C4888E3D")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.StableTypeHash(15012400804589552708uL, 0u)]
	public struct OverrideObjectNetworkIdData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public uint networkIdBits;
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[RecRoom.DataLayer.RRGuid("30228348-77DF-48F6-B2EF-B0883D3E10CA")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(4540375434353162791uL)]
	public struct MakerPenHeldData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public bool makerPenHeld;
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[RecRoom.DataLayer.RRGuid("FB9853D6-6231-43FD-A754-00105DC30880")]
	[CompilerGenerated]
	[ConfigGroup("Object", 0)]
	[RecRoom.DataLayer.NetworkComponent(6, false)]
	[TypeManager.ForcedStableTypeHash(8459715919607487693uL)]
	public struct ObjectPolicyData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		[RecRoom.DataLayer.Default("new ScaleRestriction(1,1)")]
		[RecRoom.DataLayer.Field(2)]
		public KIFMKPPKEAC scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		[RecRoom.DataLayer.Default("ObjectPolicyUserConfigurableFlags.DEFAULT")]
		[Config(null, 0)]
		[RecRoom.DataLayer.Field(3)]
		public KNMEEIJOCBO userConfigurableFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		[Config(null, 0)]
		[RecRoom.DataLayer.Field(4)]
		[RecRoom.DataLayer.Default(NLBLFFJPFIA.Default)]
		public NLBLFFJPFIA circuitsTransformBehavior;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default("ObjectPolicyEnumFlags.Default")]
		public HBMNMKJALBD flags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[RecRoom.DataLayer.RRGuid("617A903E-C2C2-467C-A138-287FDB487645")]
	[TypeManager.ForcedStableTypeHash(17708500325183871236uL)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[CompilerGenerated]
	[RecRoom.DataLayer.StableTypeHash(17708500325183871236uL, 0u)]
	public struct PlayerScopeData : IComponentData, PPOOIPHJPLD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public Entity playerScope;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public Entity Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xC6E710", Offset = "0xC6DB10", VA = "0x180C6E710", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xE3A760", Offset = "0xE39B60", VA = "0x180E3A760", Slot = "5")]
			set
			{
			}
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xBD44B0", Offset = "0xBD38B0", VA = "0x180BD44B0")]
		public static PlayerScopeData CLMIANKGGAM(Entity entity)
		{
			return default(PlayerScopeData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("F945B699-C9E5-4634-9F64-831484F4F3BD")]
	[RecRoom.DataLayer.StableTypeHash(16642773407304133105uL, 0u)]
	[ConfigGroup("Physics", 0)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(16642773407304133105uL)]
	public struct PhysicsMaterialData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		[Config(null, 0)]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default(10f)]
		public float density;
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[TypeManager.ForcedStableTypeHash(10537432342869025182uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("A2E0AF0F-C284-47E6-9535-A67A29BF5730")]
	[RecRoom.DataLayer.StableTypeHash(10537432342869025182uL, 0u)]
	public struct ShapeConfigData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default(AEPLEEMHJAE.None)]
		public AEPLEEMHJAE flags;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool DynamicUVProjection
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x6C53CF0", Offset = "0x6C530F0", VA = "0x186C53CF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool PreventInvertedCreation
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x6C53D00", Offset = "0x6C53100", VA = "0x186C53D00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool NewBendLogic
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x78339E0", Offset = "0x7832DE0", VA = "0x1878339E0")]
			get
			{
				return default(bool);
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[RecRoom.DataLayer.RRGuid("5C706BF1-9D50-456A-B974-521E8E2CC660")]
	[RecRoom.DataLayer.StableTypeHash(10917729582819845312uL, 0u)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(10917729582819845312uL)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct ShapeTypeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public ODMPMFHJCBJ shapeType;
	}
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[TypeManager.ForcedStableTypeHash(5298506180484533559uL)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("36418781-DB47-4DE7-A138-CC88D1D795C0")]
	[RecRoom.DataLayer.StableTypeHash(5298506180484533559uL, 0u)]
	[CompilerGenerated]
	public struct SplinePointOrderData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public CPJAFFJHONJ order;

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0xBD44B0", Offset = "0xBD38B0", VA = "0x180BD44B0")]
		public static SplinePointOrderData CLMIANKGGAM(CPJAFFJHONJ value)
		{
			return default(SplinePointOrderData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[TypeManager.ForcedStableTypeHash(16368389834000856208uL)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("FCEE3BCD-9C10-4BF4-954A-0DCFE8810227")]
	[RecRoom.DataLayer.StableTypeHash(16368389834000856208uL, 0u)]
	[CompilerGenerated]
	public struct SplinePointParentData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public Entity spline;
	}
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[TypeManager.ForcedStableTypeHash(18095612727592564636uL)]
	[RecRoom.DataLayer.RRGuid("5A6D38A4-1A58-4EB4-9C1B-06ADA0D44AFA")]
	[RecRoom.DataLayer.StableTypeHash(18095612727592564636uL, 0u)]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct SplinePointPositionData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public float3 localPosition;
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("433F66B6-CC1C-4A8A-BF73-2B797440A8DB")]
	[RecRoom.DataLayer.StableTypeHash(1429513518619209486uL, 0u)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(1429513518619209486uL)]
	public struct SplinePointRotationData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		[RecRoom.DataLayer.Default("new quaternion(0, 0, 0, 1f)")]
		[RecRoom.DataLayer.Field(1)]
		public quaternion localRotation;
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	[RecRoom.DataLayer.StableTypeHash(1238044349990854547uL, 0u)]
	[TypeManager.ForcedStableTypeHash(1238044349990854547uL)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("04CA3CCE-F121-4B5B-BC56-FE8E9C77F0F4")]
	public struct SplinePointScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		[RecRoom.DataLayer.Default("new float3(1)")]
		[RecRoom.DataLayer.Field(1)]
		public float3 localScale;
	}
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[RecRoom.DataLayer.StableTypeHash(4657247877648983868uL, 0u)]
	[TypeManager.ForcedStableTypeHash(4657247877648983868uL)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[CompilerGenerated]
	[RecRoom.DataLayer.RRGuid("E0610986-0F8F-494A-8C6E-8A2D2491B088")]
	public struct SplineShapeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public OFDKKEMCEOC parameters;
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[TypeManager.ForcedStableTypeHash(12332323170023439017uL)]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	[CompilerGenerated]
	[RecRoom.DataLayer.RRGuid("73C344D9-D535-4753-9D9A-B6DEDE4079B0")]
	[RecRoom.DataLayer.TombstonedFields(new int[] { 1 })]
	[RecRoom.DataLayer.StableTypeHash(12332323170023439017uL, 0u)]
	public struct OMShapeContainerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		[RecRoom.DataLayer.Field(2)]
		[RecRoom.DataLayer.Default(true)]
		public bool canModifyWithCircuits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
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
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public int version;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
[Flags]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.RRGuid("CC657074-87FD-47F7-A7B0-F5CCE922A9D0")]
[RecRoom.DataLayer.Range(HFPJMNAOGAF.MIN, HFPJMNAOGAF.ALL)]
public enum HFPJMNAOGAF
{
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	IsAllowed = 1,
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	UseDefaultVisualEffects = 2,
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	DEFAULT = 2,
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	ALL = 3,
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	MAX = 3
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(5328722791392374178uL)]
	[RecRoom.DataLayer.RRGuid("34BA53CB-16FB-45DB-AA25-293CE7C8DAE4")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct ToolCleanupSettingsData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default(15f)]
		public float delay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		[RecRoom.DataLayer.Default(HFPJMNAOGAF.UseDefaultVisualEffects)]
		[RecRoom.DataLayer.Field(2)]
		public HFPJMNAOGAF toolCleanupFlags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[TypeManager.ForcedStableTypeHash(13768238190614302474uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.RRGuid("48C72ABE-383D-45C6-9610-773F2B4F84C6")]
	[RecRoom.DataLayer.TombstonedFields(new int[] { 2, 3 })]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	public struct ToolCleanupStatusData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public float cleanupStartTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		[RecRoom.DataLayer.Field(4)]
		[RecRoom.DataLayer.Default]
		public PMMDFGLDHNM statusFlags;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.RRGuid("E63050BA-D087-4027-99F8-4AFDEA229CD8")]
[RecRoom.DataLayer.Range(PMMDFGLDHNM.None, PMMDFGLDHNM.ALL)]
[Flags]
public enum PMMDFGLDHNM
{
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	ForceCleanup = 1,
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	CleanupDone = 2,
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	CleanupPaused = 4,
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	ALL = 7,
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	MAX = 7
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[TypeManager.ForcedStableTypeHash(463077377357487319uL)]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	[RecRoom.DataLayer.RRGuid("021E8703-AAFD-4965-8C38-FF86663126D2")]
	[CompilerGenerated]
	public struct LocalDeformableScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		[RecRoom.DataLayer.Default("new float3(1)")]
		[RecRoom.DataLayer.Field(1)]
		public float3 localDeformationScale;

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0xE1B6E0", Offset = "0xE1AAE0", VA = "0x180E1B6E0")]
		public LocalDeformableScaleData(float3 scale)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[TypeManager.ForcedStableTypeHash(1369925932270831712uL)]
	[RecRoom.DataLayer.StableTypeHash(1369925932270831712uL, 0u)]
	[RecRoom.DataLayer.RRGuid("38AA9F1D-FD16-4B56-917C-3341D0EB1DF2")]
	public struct LocalPoseData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default("new quaternion(0,0,0,1)")]
		public quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		[RecRoom.DataLayer.Field(2)]
		[RecRoom.DataLayer.Default]
		public float3 localPosition;

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x4E105F0", Offset = "0x4E0F9F0", VA = "0x184E105F0")]
		public LocalPoseData(quaternion localRotation, float3 localPosition)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x782F880", Offset = "0x782EC80", VA = "0x18782F880")]
		public static RigidTransform CLMIANKGGAM(LocalPoseData poseData)
		{
			return default(RigidTransform);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x782F880", Offset = "0x782EC80", VA = "0x18782F880")]
		public static LocalPoseData CLMIANKGGAM(RigidTransform pose)
		{
			return default(LocalPoseData);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public static class PBNGCGEHFGH
{
	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x7833130", Offset = "0x7832530", VA = "0x187833130")]
	public static LocalPoseData BNCAHMPBBED([In] this RigidTransform FFOEEMKIKJO)
	{
		return default(LocalPoseData);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x7833160", Offset = "0x7832560", VA = "0x187833160")]
	public static RigidTransform NGHGJCBLFNI([In] this LocalPoseData FFOEEMKIKJO)
	{
		return default(RigidTransform);
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(2720902521635056246uL)]
	[RecRoom.DataLayer.StableTypeHash(2720902521635056246uL, 0u)]
	[RecRoom.DataLayer.RRGuid("0E9FADE9-751A-4A53-B455-4F8EA675754D")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct LocalUniformScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		[RecRoom.DataLayer.Default(1f)]
		[RecRoom.DataLayer.Field(1)]
		public float localUniformScale;
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[TypeManager.ForcedStableTypeHash(5730545663584378555uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.StableTypeHash(5730545663584378555uL, 0u)]
	[RecRoom.DataLayer.RRGuid("F01774C0-98E7-491E-AAA5-85B64AFFA182")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct TransformFlagsData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public BPAFOCGKPKM transformHint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(2)]
		public KNDGIBFMLDC transformPriority;
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	[RecRoom.DataLayer.RRGuid("392BF0C9-F464-491A-8725-E4B5E5C4ECD4")]
	[RecRoom.DataLayer.DoNotGenerateComponentProperties]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(12583036596830542024uL)]
	public struct RRObjectPrefabData : ISharedComponentData, IEquatable<RRObjectPrefabData>, IComparable<RRObjectPrefabData>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public CGLGBAJFIGE prefabType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		[RecRoom.DataLayer.Field(2)]
		[RecRoom.DataLayer.Default]
		public Guid prefabGuid;

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x78338D0", Offset = "0x7832CD0", VA = "0x1878338D0")]
		public RRObjectPrefabData(Guid prefabGuid, CGLGBAJFIGE prefabType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x78337D0", Offset = "0x7832BD0", VA = "0x1878337D0", Slot = "4")]
		public readonly bool Equals(RRObjectPrefabData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7833710", Offset = "0x7832B10", VA = "0x187833710", Slot = "0")]
		public override readonly bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x78338E0", Offset = "0x7832CE0", VA = "0x1878338E0")]
		public static bool operator ==(RRObjectPrefabData a, RRObjectPrefabData b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x7830A90", Offset = "0x782FE90", VA = "0x187830A90", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x7833640", Offset = "0x7832A40", VA = "0x187833640", Slot = "5")]
		public readonly int CompareTo(RRObjectPrefabData other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7833830", Offset = "0x7832C30", VA = "0x187833830", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[TypeManager.ForcedStableTypeHash(17550159503907726442uL)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("FF90B503-A0B5-4B3D-BACF-046FA1456FBD")]
	[CompilerGenerated]
	public struct ReferenceGroupKindData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public KKDMKJIEJIF kind;
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(18363292822319307914uL)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("2C78EEBE-6DD9-44FF-A70D-6C2EE9BB8FB3")]
	public struct ReferenceGroupOwnerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public Entity owner;
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(11947588904347318594uL)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("177498E9-83A6-4C2E-A8C1-B1951B47E74D")]
	public struct ReferenceGroupReferenceBuffer : IBufferElementData, PPOOIPHJPLD, IEquatable<ReferenceGroupReferenceBuffer>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public Entity reference;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public Entity Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0xC6E710", Offset = "0xC6DB10", VA = "0x180C6E710", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0xE3A760", Offset = "0xE39B60", VA = "0x180E3A760", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x78339D0", Offset = "0x7832DD0", VA = "0x1878339D0", Slot = "6")]
		public bool Equals(ReferenceGroupReferenceBuffer other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x7833940", Offset = "0x7832D40", VA = "0x187833940", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x9E04A0", Offset = "0x9DF8A0", VA = "0x1809E04A0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000060")]
public struct DMBILKGHLEN : IEqualityComparer<ReferenceGroupReferenceBuffer>
{
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public static DMBILKGHLEN AMGMCPILGIN;

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x78308D0", Offset = "0x782FCD0", VA = "0x1878308D0", Slot = "4")]
	public bool Equals(ReferenceGroupReferenceBuffer MEAMPLHPPKP, ReferenceGroupReferenceBuffer KDELALKKKOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0xD005B0", Offset = "0xCFF9B0", VA = "0x180D005B0", Slot = "5")]
	public int GetHashCode(ReferenceGroupReferenceBuffer BLFGIKOAKOL)
	{
		return default(int);
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[TypeManager.ForcedStableTypeHash(17466046755328781668uL)]
	[InternalBufferCapacity(0)]
	[CompilerGenerated]
	[RecRoom.DataLayer.RRGuid("DE12A401-BD29-4B00-A629-7EFBECEDCFDF")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct AuthoredUserTagReferenceBuffer : CNPHOJIFAPH, IBufferElementData, PPOOIPHJPLD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public Entity Child;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0xC6E710", Offset = "0xC6DB10", VA = "0x180C6E710", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0xE3A760", Offset = "0xE39B60", VA = "0x180E3A760", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xE3A760", Offset = "0xE39B60", VA = "0x180E3A760")]
		public AuthoredUserTagReferenceBuffer(Entity entity)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0xBD44B0", Offset = "0xBD38B0", VA = "0x180BD44B0")]
		public static AuthoredUserTagReferenceBuffer CLMIANKGGAM(Entity entity)
		{
			return default(AuthoredUserTagReferenceBuffer);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public interface CNPHOJIFAPH : IBufferElementData, PPOOIPHJPLD
{
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[TypeManager.ForcedStableTypeHash(12148147190301245780uL)]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	[CompilerGenerated]
	[RecRoom.DataLayer.RRGuid("00B7CB5E-4C0C-4D2C-AC95-78529EE58768")]
	public struct PersistentUserTagData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public FixedList32Bytes<int> tags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		[RecRoom.DataLayer.Field(2)]
		[RecRoom.DataLayer.Default(false)]
		public bool initalizedDefaults;
	}
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[TypeManager.ForcedStableTypeHash(1859693175312uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.StableTypeHash(1859693175312uL, 0u)]
	[RecRoom.DataLayer.RRGuid("80D85A55-B2F6-4860-A851-62973DC10940")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[SwatchPrimaryKey]
	public struct UserTagNameData : IComponentData, IEquatable<UserTagNameData>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public FixedString32Bytes Value;

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x7833B10", Offset = "0x7832F10", VA = "0x187833B10")]
		public UserTagNameData(string value)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x78339F0", Offset = "0x7832DF0", VA = "0x1878339F0")]
		public static UserTagNameData CLMIANKGGAM(string value)
		{
			return default(UserTagNameData);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x7833A30", Offset = "0x7832E30", VA = "0x187833A30", Slot = "4")]
		public bool Equals(UserTagNameData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x7833A60", Offset = "0x7832E60", VA = "0x187833A60", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x7833B00", Offset = "0x7832F00", VA = "0x187833B00", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[InternalBufferCapacity(0)]
	[TypeManager.ForcedStableTypeHash(2039749658960193818uL)]
	[RecRoom.DataLayer.RRGuid("1E609F72-38C4-433D-BB17-B718F89DF446")]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct UserTagReferenceBuffer : CNPHOJIFAPH, IBufferElementData, PPOOIPHJPLD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public Entity Child;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0xC6E710", Offset = "0xC6DB10", VA = "0x180C6E710", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0xE3A760", Offset = "0xE39B60", VA = "0x180E3A760", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0xE3A760", Offset = "0xE39B60", VA = "0x180E3A760")]
		public UserTagReferenceBuffer(Entity entity)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0xBD44B0", Offset = "0xBD38B0", VA = "0x180BD44B0")]
		public static UserTagReferenceBuffer CLMIANKGGAM(Entity entity)
		{
			return default(UserTagReferenceBuffer);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[RecRoom.DataLayer.StableTypeHash(1591066774816564574uL, 0u)]
	[TypeManager.ForcedStableTypeHash(1591066774816564574uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("C36DDF08-CA52-4E33-8078-2F6E915D4FDA")]
	[ConfigGroup("Visual", 0)]
	public struct StandardRenderableVisualData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		[Config(null, 0)]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public IMDMMENCIGE color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		[Config(null, 0)]
		[RecRoom.DataLayer.Field(2)]
		[RecRoom.DataLayer.Default]
		public GKPHPKBFEMO material;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		[Config(null, 0)]
		[RecRoom.DataLayer.Field(3)]
		[RecRoom.DataLayer.Default]
		public float uvScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		[RecRoom.DataLayer.Field(4)]
		[RecRoom.DataLayer.Default]
		[Config(null, 0)]
		public float3 uvOffset;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
[RecRoom.DataLayer.RRGuid("6B598497-D68A-4CC9-9D41-09EF6B966499")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.Range(NLBLFFJPFIA.NONE, NLBLFFJPFIA.COUNT)]
public enum NLBLFFJPFIA
{
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	NONE = 0,
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	[Config("Default (can transform roots, children are static)", 0)]
	Default = 1,
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	[Config("Can Transform (chips like SetPosition can modify)", 0)]
	CircuitsCanTransform = 2,
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	[Config("Always Static (chips cannot modify transform)", 0)]
	AlwaysStatic = 3,
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	COUNT = 4,
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	MAX = 4
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.RRGuid("17517E1A-CF1A-48C9-B6A5-F9E42C1B9E96")]
[RecRoom.DataLayer.Range(0, 4)]
public enum JOGGKGEEDGF
{
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	Box = 1,
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	Sphere = 2,
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	Capsule = 3,
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	Mesh = 4,
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	COUNT = 5,
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	MAX = 4
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
[RecRoom.DataLayer.RRGuid("A13F5102-9259-42B9-B782-BB7CC33A0C4F")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[Flags]
[RecRoom.DataLayer.Range(ADIGCPMBFHP.NONE, ADIGCPMBFHP.ALL)]
public enum ADIGCPMBFHP
{
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	NONE = 0,
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	Object = 1,
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	Player = 2,
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	Projectile = 4,
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	Vehicle = 8,
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	ALL = 0xF
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
[RecRoom.DataLayer.NetworkEnum(2, false)]
[RecRoom.DataLayer.Range(0, 127)]
[RecRoom.DataLayer.RRGuid("F843A776-E042-43B7-8167-0C7A421062F8")]
public enum PJJDLHIAMPI : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	[@Tooltip("Indicating it can be walked on and moved")]
	[Config("Dynamic (Environment)", 0)]
	IsDynamicEnvironment = 0,
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	[Config("Dynamic", -1)]
	IsDynamic = 10,
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	[Config("Dynamic (Ignore Static Geometry)", 0)]
	IsDynamicIgnoreStaticGeometry = 11,
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	[Config("Dynamic (Ignore Other Dynamic)", 0)]
	IsDynamicIgnoreOtherDynamic = 12,
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	[Config("Dynamic (Ignore Players)", 0)]
	IsDynamicIgnorePlayers = 13,
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	[Config("Dynamic (Ignore Most)", 0)]
	IsDynamicIgnoreMost = 14,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	[Config("Enemy Collision", 0)]
	IsEnemyCollision = 30,
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	[Config("Enemy Projectile", 0)]
	IsEnemyProjectile = 31,
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	[Config("Vehicle Physics", 0)]
	IsVehicleCollision = 40,
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	[ConfigIgnore]
	STATIC = 100,
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	[ConfigIgnore]
	DECORATION = 101,
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	MAX = 127
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
[RecRoom.DataLayer.Range(MEOCNMKGIFD.Off, MEOCNMKGIFD.COUNT)]
[RecRoom.DataLayer.NetworkEnum(2, false)]
[RecRoom.DataLayer.RRGuid("9ADF7A0D-D808-48A7-BFCB-3272FB5D8A52")]
public enum MEOCNMKGIFD : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	Off = 0,
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	Children = 1,
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	Hull = 2,
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	COUNT = 3,
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	MAX = 2
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
[RecRoom.DataLayer.Range(0, 2)]
[RecRoom.DataLayer.RRGuid("3B156405-5769-4DB2-87EA-2B846AC4E584")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
public enum ODMPMFHJCBJ
{
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	Primitive = 1,
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	Spline = 2,
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	COUNT = 3,
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	MAX = 2
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
[RecRoom.DataLayer.RRGuid("61EFE94A-235A-4281-B938-1A5BE32A18B1")]
[RecRoom.DataLayer.Range(AMAHBNLCGNL.Pivot, AMAHBNLCGNL.COUNT)]
[RecRoom.DataLayer.NetworkEnum(2, false)]
public enum AMAHBNLCGNL : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	Pivot = 0,
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	Bounds = 1,
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	COUNT = 2,
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	MAX = 1
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
[RecRoom.DataLayer.Range(MHBPIDFNAAN.EnabledForRole, MHBPIDFNAAN.DisabledForRole)]
[RecRoom.DataLayer.RRGuid("c0973732-e735-44cd-9727-a9a79bad01e3")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
public enum MHBPIDFNAAN : byte
{
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	EnabledForRole,
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	DisabledForRole,
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	Disabled
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.RRGuid("7E7D5AA1-2EC9-488B-8AB2-703F13BCB8CF")]
[RecRoom.DataLayer.Range(OAIMBNMHJKM.NavMeshGenerator, OAIMBNMHJKM.NavMeshBlocker)]
public enum OAIMBNMHJKM
{
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	NavMeshGenerator = 0,
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	NavMeshIgnored = 1,
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	NavMeshBlocker = 2,
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	MAX = 2
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
[Flags]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.RRGuid("7B493897-FE06-4FC8-AB72-8B7BF5A313D3")]
[RecRoom.DataLayer.Range(HBMNMKJALBD.None, HBMNMKJALBD.All)]
public enum HBMNMKJALBD
{
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	All = 0x3FFF,
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	Default = 0x3FFF
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
[RecRoom.DataLayer.Range(0, MJCHGMLLMCK.COUNT)]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.RRGuid("4427686F-E636-4F43-91F7-6BC74DEC584E")]
public enum MJCHGMLLMCK
{
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	SupportsRotation,
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	SupportsDeformation,
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	SupportsScaling,
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	SupportsMirroring,
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	SupportsCloning,
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	SupportsRecoloring,
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	CanDestroy,
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	CanSaveIntoInventions,
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	SupportsRespawn,
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	SupportsMerging,
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	SupportsSplitting,
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	SupportsKeys,
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	CanEditWithMakerPen,
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	DEPRECATED_IsGrabbable,
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public static class LDFGHMLDLCC
{
	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x78328E0", Offset = "0x7831CE0", VA = "0x1878328E0")]
	public static void JFGGMENNDNP(this HBMNMKJALBD KHCEBCMPDGO, MJCHGMLLMCK ECNGBDIKOPO, bool IBPGEKGMGLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x78328C0", Offset = "0x7831CC0", VA = "0x1878328C0")]
	public static bool DDFENMDGHBA(this HBMNMKJALBD KHCEBCMPDGO, MJCHGMLLMCK ECNGBDIKOPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0xD03450", Offset = "0xD02850", VA = "0x180D03450")]
	public static HBMNMKJALBD KPMFPMMPPBL(this MJCHGMLLMCK ECNGBDIKOPO)
	{
		return default(HBMNMKJALBD);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
[RecRoom.DataLayer.NetworkEnum(2, false)]
[RecRoom.DataLayer.RRGuid("E3C51303-32F0-4EF4-8A66-C814E323653D")]
[RecRoom.DataLayer.Range(KNMEEIJOCBO.NONE, KNMEEIJOCBO.COUNT)]
[Flags]
public enum KNMEEIJOCBO
{
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	NONE = 0,
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	IsFrozen = 1,
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	IsGrabbable = 2,
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	COUNT = 3,
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	ALL = 3,
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	DEFAULT = 0
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
[RecRoom.DataLayer.RRGuid("777AD204-3AC0-41CE-BDC0-894C5821B3B9")]
[RecRoom.DataLayer.Range(1000, 8000)]
[RecRoom.DataLayer.NetworkEnum(1, false)]
public enum CGLGBAJFIGE
{
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	[Config("Container", 0)]
	Container = 1000,
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	[Config("Container", 0)]
	LegacyShapeContainer = 1001,
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	[Config("Container", 0)]
	CreationShapeContainer = 1002,
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	[Config("Container", 0)]
	CostumePieceShapeContainer = 1003,
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	[Config("Empty", 0)]
	Empty = 4000,
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	[Config("Legacy Box", 0)]
	Shape_Primitive_LegacyBox = 2000,
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	[Config("Sphere", 0)]
	Shape_Primitive_Sphere = 2001,
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	[Config("Cylinder", 0)]
	Shape_Primitive_Cylinder = 2002,
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	[Config("Legacy Wedge", 0)]
	Shape_Primitive_LegacyWedge = 2003,
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	[Config("Legacy Pyramid", 0)]
	Shape_Primitive_LegacyPyramid = 2004,
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	[Config("Trigger Volume Box", 0)]
	Shape_Primitive_TriggerVolumeBox = 2005,
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	[Config("Box", 0)]
	Shape_Primitive_Box = 2006,
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	[Config("Rounded Box", 0)]
	Shape_Primitive_RoundedBox = 2007,
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	[Config("Wedge", 0)]
	Shape_Primitive_Wedge = 2008,
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	[Config("Pyramid", 0)]
	Shape_Primitive_Pyramid = 2009,
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	[Config("Half Sphere", 0)]
	Shape_Primitive_HalfSphere = 2010,
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	[Config("Cone", 0)]
	Shape_Primitive_Cone = 2011,
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	[Config("Pipe", 0)]
	Shape_Primitive_Pipe = 2012,
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	[Config("Donut", 0)]
	Shape_Primitive_Donut = 2013,
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	[Config("Half Pipe", 0)]
	Shape_Primitive_HalfPipe = 2014,
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	[Config("Diamond", 0)]
	Shape_Primitive_Diamond = 2015,
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	[Config("Mound", 0)]
	Shape_Primitive_Mound = 2016,
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	[Config("Cube (Simple)", 0)]
	Shape_Primitive_ADVANCED_Cube = 2017,
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	[Config("Sphere (Simple)", 0)]
	Shape_Primitive_ADVANCED_Sphere = 2018,
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	[Config("Cylinder (Simple)", 0)]
	Shape_Primitive_ADVANCED_Cylinder = 2019,
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	[Config("Cone (Simple)", 0)]
	Shape_Primitive_ADVANCED_Cone = 2020,
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	[Config("Pyramid (Simple)", 0)]
	Shape_Primitive_ADVANCED_Pyramid = 2021,
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	[Config("Octagon (Simple)", 0)]
	Shape_Primitive_ADVANCED_Octagon = 2022,
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	[Config("Triangle (Simple)", 0)]
	Shape_Primitive_ADVANCED_Triangle = 2023,
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	[Config("Hexagon (Simple)", 0)]
	Shape_Primitive_ADVANCED_Hexagon = 2024,
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	[Config("Quarter Pipe", 0)]
	Shape_Primitive_ADVANCED_QuarterPipe = 2025,
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	[Config("Pentagon (Simple)", 0)]
	Shape_Primitive_ADVANCED_Pentagon = 2026,
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	[Config("Dodecahedron", 0)]
	Shape_Primitive_ADVANCED_Dodecahedron = 2027,
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	[Config("Icosahedron", 0)]
	Shape_Primitive_ADVANCED_Trihedron = 2028,
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	[Config("Octahedron", 0)]
	Shape_Primitive_ADVANCED_Octahedron = 2029,
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	[Config("Quarter Cylinder", 0)]
	Shape_Primitive_RR_QuarterCylinder = 2030,
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	[Config("Pentagon", 0)]
	Shape_Primitive_RR_Pentagon = 2031,
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	[Config("Quarter Sphere", 0)]
	Shape_Primitive_RR_QuarterSphere = 2032,
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	[Config("Wedge (Simple)", 0)]
	Shape_Primitive_ADVANCED_Wedge = 2033,
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	[Config("Hexagon", 0)]
	Shape_Primitive_RR_Hexagon = 2034,
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	[Config("Octagon", 0)]
	Shape_Primitive_RR_Octagon = 2035,
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	[Config("Triangle", 0)]
	Shape_Primitive_RR_Triangle = 2036,
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	[Config("Spline", 0)]
	Shape_Spline = 3000,
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	[Config("Container Pivot", 0)]
	Other_ContainerPivot = 6000,
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	[Config("Spine Point", 0)]
	Other_SplinePoint = 6001,
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	[Config("Reference Point", 0)]
	Other_ReferencePoint = 6002,
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	[Config("UserTags", 0)]
	Other_UserTag = 6003,
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	[Config("Reference Group", 0)]
	Other_ReferenceGroup = 6004,
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	[Config("Interaction Filter", 0)]
	Other_InteractionFilterTags = 6005,
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	[ConfigIgnore]
	UNUSED2 = 5000,
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	[Config("Object", 0)]
	PrefabRootGameObject = 7000,
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	[Config("PrefabInternal", 0)]
	PrefabInternalGameObject = 7001,
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	[Config("Player", 0)]
	Player = 8000
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public static class GJOFIMAMACD
{
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	[CompilerGenerated]
	private sealed class KNBIBOGAMAH : IEnumerable<CGLGBAJFIGE>, IEnumerable, IEnumerator<CGLGBAJFIGE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		private CGLGBAJFIGE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		private IEnumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private CGLGBAJFIGE System.Collections.Generic.IEnumerator<RecRoom.DataLayer.ObjectPrefabType>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0xADE5D0", Offset = "0xADD9D0", VA = "0x180ADE5D0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(CGLGBAJFIGE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x7832810", Offset = "0x7831C10", VA = "0x187832810", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x118F820", Offset = "0x118EC20", VA = "0x18118F820")]
		[DebuggerHidden]
		public KNBIBOGAMAH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x7832860", Offset = "0x7831C60", VA = "0x187832860", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x7832450", Offset = "0x7831850", VA = "0x187832450", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x78326C0", Offset = "0x7831AC0", VA = "0x1878326C0")]
		private void OMCGPHJKBHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x78327C0", Offset = "0x7831BC0", VA = "0x1878327C0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x7832720", Offset = "0x7831B20", VA = "0x187832720", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<CGLGBAJFIGE> System.Collections.Generic.IEnumerable<RecRoom.DataLayer.ObjectPrefabType>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x7832720", Offset = "0x7831B20", VA = "0x187832720", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[CompilerGenerated]
	private sealed class PLCIAHOILAA : IEnumerable<CGLGBAJFIGE>, IEnumerable, IEnumerator<CGLGBAJFIGE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		private CGLGBAJFIGE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		private CGLGBAJFIGE <last>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		private CGLGBAJFIGE <i>5__3;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private CGLGBAJFIGE System.Collections.Generic.IEnumerator<RecRoom.DataLayer.ObjectPrefabType>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0xADE5D0", Offset = "0xADD9D0", VA = "0x180ADE5D0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(CGLGBAJFIGE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x7833470", Offset = "0x7832870", VA = "0x187833470", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x118F820", Offset = "0x118EC20", VA = "0x18118F820")]
		[DebuggerHidden]
		public PLCIAHOILAA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x7833320", Offset = "0x7832720", VA = "0x187833320", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x7833420", Offset = "0x7832820", VA = "0x187833420", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x7833380", Offset = "0x7832780", VA = "0x187833380", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<CGLGBAJFIGE> System.Collections.Generic.IEnumerable<RecRoom.DataLayer.ObjectPrefabType>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x7833380", Offset = "0x7832780", VA = "0x187833380", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[CompilerGenerated]
	private sealed class DJHBAIKBNKC : IEnumerable<CGLGBAJFIGE>, IEnumerable, IEnumerator<CGLGBAJFIGE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		private CGLGBAJFIGE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		private IEnumerator<CGLGBAJFIGE> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private CGLGBAJFIGE System.Collections.Generic.IEnumerator<RecRoom.DataLayer.ObjectPrefabType>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0xADE5D0", Offset = "0xADD9D0", VA = "0x180ADE5D0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(CGLGBAJFIGE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x78307F0", Offset = "0x782FBF0", VA = "0x1878307F0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x118F820", Offset = "0x118EC20", VA = "0x18118F820")]
		[DebuggerHidden]
		public DJHBAIKBNKC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x7830840", Offset = "0x782FC40", VA = "0x187830840", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x7830410", Offset = "0x782F810", VA = "0x187830410", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x78306B0", Offset = "0x782FAB0", VA = "0x1878306B0")]
		private void OMCGPHJKBHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x78307A0", Offset = "0x782FBA0", VA = "0x1878307A0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x7830700", Offset = "0x782FB00", VA = "0x187830700", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<CGLGBAJFIGE> System.Collections.Generic.IEnumerable<RecRoom.DataLayer.ObjectPrefabType>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x7830700", Offset = "0x782FB00", VA = "0x187830700", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x78315D0", Offset = "0x78309D0", VA = "0x1878315D0")]
	[IteratorStateMachine(typeof(KNBIBOGAMAH))]
	public static IEnumerable<CGLGBAJFIGE> KAIIKLLLJKL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x7831630", Offset = "0x7830A30", VA = "0x187831630")]
	[IteratorStateMachine(typeof(PLCIAHOILAA))]
	public static IEnumerable<CGLGBAJFIGE> MODOFELAPAI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x7831570", Offset = "0x7830970", VA = "0x187831570")]
	[IteratorStateMachine(typeof(DJHBAIKBNKC))]
	public static IEnumerable<CGLGBAJFIGE> GCNDPOJKOAE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public static class ALBNACJMBKH
{
	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x782F7C0", Offset = "0x782EBC0", VA = "0x18782F7C0")]
	public static bool PHLGFMLDPAF(this CGLGBAJFIGE HAFNBBNOLPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x782F770", Offset = "0x782EB70", VA = "0x18782F770")]
	public static bool FHIJAGDLIBO(this RRObjectPrefabData FNCAILILPPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x782F740", Offset = "0x782EB40", VA = "0x18782F740")]
	public static bool FHIJAGDLIBO(this CGLGBAJFIGE HAFNBBNOLPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x782F7A0", Offset = "0x782EBA0", VA = "0x18782F7A0")]
	public static NNIMMHMAHEI JEMPDODBALC(this CGLGBAJFIGE OEEAJPMCKOG)
	{
		return default(NNIMMHMAHEI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x782F710", Offset = "0x782EB10", VA = "0x18782F710")]
	internal static LAKCOENPCJI BHMIDHJFOMI(this NNIMMHMAHEI NILLICCLHIK)
	{
		return default(LAKCOENPCJI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x782F720", Offset = "0x782EB20", VA = "0x18782F720")]
	internal static LAKCOENPCJI BHMIDHJFOMI(this CGLGBAJFIGE OEEAJPMCKOG)
	{
		return default(LAKCOENPCJI);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
internal enum LAKCOENPCJI
{
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	Container = 1000,
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	Empty = 4000,
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	Primitive = 2000,
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	Spline = 3000,
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	Other = 6000,
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	UNUSED2 = 5000,
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	GameObject = 7000,
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	Player = 8000
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
[RecRoom.DataLayer.RRGuid("A32413BC-21F3-4F7C-84B0-37724A854A67")]
[RecRoom.DataLayer.Range(0, 8)]
[RecRoom.DataLayer.NetworkEnum(1, false)]
public enum NNIMMHMAHEI
{
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	None,
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	Container,
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	Primitive,
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	Spline,
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	Empty,
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	UNUSED2,
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	Other,
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	GameObject,
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	Player
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public static class BNKMMJELGMD
{
	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x782FC90", Offset = "0x782F090", VA = "0x18782FC90")]
	public static bool JGPHBAKOIEC(this NNIMMHMAHEI NILLICCLHIK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
[RecRoom.DataLayer.NetworkEnum(3, false)]
[RecRoom.DataLayer.RRGuid("7A0D34B5-FFE5-4C21-BB0C-CB3EBA34C797")]
[RecRoom.DataLayer.Range(0, FECKIEFHJNO.ALL)]
[Flags]
public enum FECKIEFHJNO : ushort
{
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	NONE = 0,
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	PhysicsEnabled = 1,
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	GravityEnabled = 2,
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	HasCustomMass = 4,
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	CollisionEvent = 0x40,
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	CanUse = 0x200,
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	CanClimb = 0x400,
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	CanWallRun = 0x800,
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	CanClamber = 0x1000,
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	CanTeleport = 0x2000,
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	SuppressCollision = 0x4000,
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	DEFAULT = 0x3800,
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	ALL = 0x3E47,
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	MAX = 0x3E47
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	[CompilerGenerated]
	[RecRoom.DataLayer.StableTypeHash(8060729269509364919uL, 0u)]
	[TypeManager.ForcedStableTypeHash(8060729269509364919uL)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("5D4503E7-6CC4-4938-8840-1B859C391878")]
	public struct PrimitiveShapeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public OGALGCNMGJH shapeType;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
[RecRoom.DataLayer.Range(-1, 38)]
[RecRoom.DataLayer.RRGuid("517224CC-0A79-4FE9-B048-53C37955D823")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
public enum OGALGCNMGJH
{
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	LegacyBox = 2,
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	RR_Sphere = 3,
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	RR_Cylinder = 4,
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	LEGACY_Wedge = 5,
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	LEGACY_Pyramid = 6,
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	LEGACY_TriggerVolumeBox = 7,
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	RR_Box = 8,
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	LEGACY_RoundedBox = 9,
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	RR_Wedge = 10,
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	RR_Pyramid = 11,
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	RR_HalfSphere = 12,
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	RR_Cone = 13,
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	RR_Pipe = 14,
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	RR_Donut = 15,
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	RR_HalfPipe = 16,
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	RR_Diamond = 17,
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	ADVANCED_Mound = 18,
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	ADVANCED_Cube = 19,
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	ADVANCED_Sphere = 20,
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	ADVANCED_Cylinder = 21,
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	ADVANCED_Cone = 22,
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	ADVANCED_Pyramid = 23,
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	ADVANCED_Octagon = 24,
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	ADVANCED_Triangle = 25,
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	ADVANCED_Hexagon = 26,
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	ADVANCED_QuarterPipe = 27,
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	ADVANCED_Pentagon = 28,
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	ADVANCED_Dodecahedron = 29,
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	ADVANCED_Trihedron = 30,
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	ADVANCED_Octahedron = 31,
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	RR_QuarterCylinder = 32,
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	RR_Pentagon = 33,
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	RR_QuarterSphere = 34,
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	ADVANCED_Wedge = 35,
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	RR_Hexagon = 36,
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	RR_Octagon = 37,
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	RR_Triangle = 38,
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	COUNT = 39,
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	MIN_VALUE = -1,
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	MAX_VALUE = 38
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.RRGuid("3D27DF09-CAE2-4C3F-B808-03AD605F8E98")]
[RecRoom.DataLayer.Range(KKDMKJIEJIF.None, KKDMKJIEJIF.COUNT)]
public enum KKDMKJIEJIF : byte
{
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	AnimationGroup = 1,
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	COUNT = 2,
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	MAX = 2
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
[RecRoom.DataLayer.RRGuid("1829B7EA-C0EA-4E77-8EB2-BA23E995C860")]
[RecRoom.DataLayer.Range(0, 7)]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[Flags]
public enum AEPLEEMHJAE
{
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	DynamicUVProjection = 1,
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	PreventInvertedCreation = 2,
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	NewBendLogic = 4,
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	All = 7,
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	MAX = 7
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.RRGuid("CCB58F66-EF02-476E-820F-9D593E2C3DE5")]
[RecRoom.DataLayer.Range(0, 7)]
[Flags]
public enum AEKEOCGFHPH
{
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	IsRibbon = 1,
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	RoundedTubes = 2,
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	OldStyleCaps = 4,
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	All = 7,
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	MAX = 7
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
[Flags]
[RecRoom.DataLayer.Range(0, 1)]
[RecRoom.DataLayer.RRGuid("72742F9B-D48E-4CED-B403-444201FFEE66")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
public enum BPAFOCGKPKM
{
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	Static = 0,
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	Dynamic = 1,
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	All = 1
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
[RecRoom.DataLayer.RRGuid("C5BE1CDA-5EF5-4EBF-BC7E-3E3510C68A7F")]
[RecRoom.DataLayer.Range(-2, 2)]
[RecRoom.DataLayer.NetworkEnum(1, false)]
public enum KNDGIBFMLDC
{
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	Frozen = -2,
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	Low = -1,
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	Normal = 0,
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	High = 1,
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	Realtime = 2,
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	Default = 0,
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	MIN = -2,
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	MAX = 2
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
[RecRoom.DataLayer.Range(int.MinValue, int.MaxValue)]
[RecRoom.DataLayer.RRGuid("D6AFAFED-8BAA-4499-9696-9CBB716EF514")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
public enum IMDMMENCIGE
{
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	Red = 0,
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	Orange = 1,
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	Yellow = 2,
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	LightGreen = 3,
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	Blue = 4,
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	LightBlue = 5,
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	Teal = 6,
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	Green = 7,
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	Purple = 8,
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	LightPink = 9,
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	Pink = 10,
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	Brown = 11,
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	Tan = 12,
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	White = 13,
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	Grey = 14,
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	DarkGrey = 15,
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	DarkBrown = 16,
	[Cpp2IlInjected.Token(Token = "0x4000207")]
	LightBrown = 17,
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	LightGrey = 18,
	[Cpp2IlInjected.Token(Token = "0x4000209")]
	Black = 19,
	[Cpp2IlInjected.Token(Token = "0x400020A")]
	DarkRed = 20,
	[Cpp2IlInjected.Token(Token = "0x400020B")]
	DarkOrange = 21,
	[Cpp2IlInjected.Token(Token = "0x400020C")]
	DarkYellow = 22,
	[Cpp2IlInjected.Token(Token = "0x400020D")]
	DarkGreen = 23,
	[Cpp2IlInjected.Token(Token = "0x400020E")]
	DarkTeal = 24,
	[Cpp2IlInjected.Token(Token = "0x400020F")]
	DarkBlue = 25,
	[Cpp2IlInjected.Token(Token = "0x4000210")]
	DarkPurple = 26,
	[Cpp2IlInjected.Token(Token = "0x4000211")]
	DarkPink = 27,
	[Cpp2IlInjected.Token(Token = "0x4000212")]
	LightRed = 28,
	[Cpp2IlInjected.Token(Token = "0x4000213")]
	LightOrange = 29,
	[Cpp2IlInjected.Token(Token = "0x4000214")]
	LightYellow = 30,
	[Cpp2IlInjected.Token(Token = "0x4000215")]
	Cyan = 31,
	[Cpp2IlInjected.Token(Token = "0x4000216")]
	LightPurple = 32,
	[Cpp2IlInjected.Token(Token = "0x4000217")]
	DarkTan = 33,
	[Cpp2IlInjected.Token(Token = "0x4000218")]
	NewColor1 = 34,
	[Cpp2IlInjected.Token(Token = "0x4000219")]
	NewColor2 = 35,
	[Cpp2IlInjected.Token(Token = "0x400021A")]
	NewColor3 = 36,
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	NewColor4 = 37,
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	NewColor5 = 38,
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	NewColor6 = 39,
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	NewColor7 = 40,
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	NewColor8 = 41,
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	NewColor9 = 42,
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	NewColor10 = 43,
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	NewColor11 = 44,
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	NewColor12 = 45,
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	NewColor13 = 46,
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	NewColor14 = 47,
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	NewColor15 = 48,
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	NewColor16 = 49,
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	NewColor17 = 50,
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	NewColor18 = 51,
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	NewColor19 = 52,
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	NewColor20 = 53,
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	NewColor21 = 54,
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	NewColor22 = 55,
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	NewColor23 = 56,
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	NewColor24 = 57,
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	NewColor25 = 58,
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	NewColor26 = 59,
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	NewColor27 = 60,
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	Default = 0
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
[RecRoom.DataLayer.RRGuid("C57BE511-BA1A-4D83-BA58-303F34F4DE74")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.Range(-1, 31)]
public enum GKPHPKBFEMO
{
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	Cardboard = 0,
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	Neon = 1,
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	Brick = 2,
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	Carpet = 3,
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	Dirt = 4,
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	Grass = 5,
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	MetalReflective = 6,
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	Concrete = 7,
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	Linoleum = 8,
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	Plaster = 9,
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	WoodLogs = 10,
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	WoodBoards = 11,
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	WoodGrain = 12,
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	WoodFloor = 13,
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	Sand = 14,
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	GlossyPlastic = 15,
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	Cloth = 16,
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	RubberFloor = 17,
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	MetalFloorTread = 18,
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	PaintedBrick = 19,
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	Crashpad = 20,
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	PaintedWood = 21,
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	GripTape = 22,
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	GalvanizedMetal = 23,
	[Cpp2IlInjected.Token(Token = "0x400024E")]
	ParticleBoard = 24,
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	CheckeredFloor = 25,
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	SparklyVinyl = 26,
	[Cpp2IlInjected.Token(Token = "0x4000251")]
	Gravel = 27,
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	Rock = 28,
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	Placeholder29 = 29,
	[Cpp2IlInjected.Token(Token = "0x4000254")]
	Placeholder30 = 30,
	[Cpp2IlInjected.Token(Token = "0x4000255")]
	Placeholder31 = 31,
	[Cpp2IlInjected.Token(Token = "0x4000256")]
	COUNT = 32,
	[Cpp2IlInjected.Token(Token = "0x4000257")]
	MIN = -1,
	[Cpp2IlInjected.Token(Token = "0x4000258")]
	MAX = 31,
	[Cpp2IlInjected.Token(Token = "0x4000259")]
	Default = 0
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
[RecRoom.DataLayer.NetworkStruct(1, false)]
[RecRoom.DataLayer.RRGuid("112F004A-C92F-4055-99F9-D430EC13FE3C")]
public struct CPJAFFJHONJ : IComparable<CPJAFFJHONJ>, IEquatable<CPJAFFJHONJ>
{
	[Cpp2IlInjected.Token(Token = "0x400025A")]
	public static readonly CPJAFFJHONJ GBADJOAJCAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400025B")]
	[RecRoom.DataLayer.Field(1)]
	public uint MLMPOKAHHBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400025C")]
	[RecRoom.DataLayer.Field(2)]
	public uint AMELMLPFILD;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	private readonly uint LBDFICCCNAC
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x782FDF0", Offset = "0x782F1F0", VA = "0x18782FDF0")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public readonly bool PNPLPCMDCBA
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x782FDE0", Offset = "0x782F1E0", VA = "0x18782FDE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x7830330", Offset = "0x782F730", VA = "0x187830330")]
	public CPJAFFJHONJ(int MLMPOKAHHBF, int JFPIBKGAILO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x7830330", Offset = "0x782F730", VA = "0x187830330")]
	public CPJAFFJHONJ(uint MLMPOKAHHBF, uint JFPIBKGAILO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x7830390", Offset = "0x782F790", VA = "0x187830390")]
	private CPJAFFJHONJ(uint MLMPOKAHHBF, uint JFPIBKGAILO, bool FOMPAOHONHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x782FE00", Offset = "0x782F200", VA = "0x18782FE00")]
	public CPJAFFJHONJ JOLMNDCOHKJ(int HGHGCNDALFP = 1)
	{
		return default(CPJAFFJHONJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x7830180", Offset = "0x782F580", VA = "0x187830180")]
	public CPJAFFJHONJ NNCDJNIOFLG(int HGHGCNDALFP = 1)
	{
		return default(CPJAFFJHONJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x782FE70", Offset = "0x782F270", VA = "0x18782FE70")]
	public static CPJAFFJHONJ KOKOIMAGEOG(CPJAFFJHONJ KGCKEJLFPJB, CPJAFFJHONJ HKELKGIPNGP)
	{
		return default(CPJAFFJHONJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x7830210", Offset = "0x782F610", VA = "0x187830210")]
	private static ulong OLJMKDPLIHH(ulong PCMHLCLONGN, ulong IAJJOLNCJOI)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x782FCA0", Offset = "0x782F0A0", VA = "0x18782FCA0", Slot = "4")]
	public int CompareTo(CPJAFFJHONJ KNCKFHOKGJM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x782FCC0", Offset = "0x782F0C0", VA = "0x18782FCC0", Slot = "0")]
	public override bool Equals(object BLFGIKOAKOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x7830250", Offset = "0x782F650", VA = "0x187830250", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x782FD50", Offset = "0x782F150", VA = "0x18782FD50", Slot = "5")]
	public bool Equals(CPJAFFJHONJ KNCKFHOKGJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x782FD90", Offset = "0x782F190", VA = "0x18782FD90", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x343A860", Offset = "0x3439C60", VA = "0x18343A860")]
	public static bool PEOCKCCHEIN(CPJAFFJHONJ KGCKEJLFPJB, CPJAFFJHONJ HKELKGIPNGP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x78301F0", Offset = "0x782F5F0", VA = "0x1878301F0")]
	public static bool OGMAAAEFFPP(CPJAFFJHONJ KGCKEJLFPJB, CPJAFFJHONJ HKELKGIPNGP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x7830160", Offset = "0x782F560", VA = "0x187830160")]
	public static bool NDDKCCDNOBB(CPJAFFJHONJ KGCKEJLFPJB, CPJAFFJHONJ HKELKGIPNGP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x782FD70", Offset = "0x782F170", VA = "0x18782FD70")]
	public static bool GEFPPOKBDCB(CPJAFFJHONJ KGCKEJLFPJB, CPJAFFJHONJ HKELKGIPNGP)
	{
		return default(bool);
	}
}
namespace RecRoom.DataLayer
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	[RecRoom.DataLayer.NetworkStruct(1, false)]
	[RecRoom.DataLayer.RRGuid("D3AB0F52-EA41-4891-9470-6E945A9D6583")]
	public struct NetworkGuid : IEquatable<NetworkGuid>, IComparable<NetworkGuid>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		[RecRoom.DataLayer.Field(1)]
		public int4 data;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public Guid Guid
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x1111790", Offset = "0x1110B90", VA = "0x181111790")]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x11117A0", Offset = "0x1110BA0", VA = "0x1811117A0")]
			set
			{
			}
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x1111790", Offset = "0x1110B90", VA = "0x181111790")]
		public static Guid CLMIANKGGAM(NetworkGuid KDBHLLEACIN)
		{
			return default(Guid);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x1111790", Offset = "0x1110B90", VA = "0x181111790")]
		public static NetworkGuid CLMIANKGGAM(Guid KDBHLLEACIN)
		{
			return default(NetworkGuid);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x7833050", Offset = "0x7832450", VA = "0x187833050", Slot = "4")]
		public bool Equals(NetworkGuid KNCKFHOKGJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x490F920", Offset = "0x490ED20", VA = "0x18490F920", Slot = "5")]
		public int CompareTo(NetworkGuid KNCKFHOKGJM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x7833080", Offset = "0x7832480", VA = "0x187833080", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
[RecRoom.DataLayer.RRGuid("9F5F33BE-7C0A-4870-9CE0-BA79440E7F98")]
[RecRoom.DataLayer.NetworkStruct(1, false)]
public struct KIFMKPPKEAC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400025E")]
	[RecRoom.DataLayer.Field(1)]
	public bool CGAPLHFOGJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400025F")]
	[RecRoom.DataLayer.Field(2)]
	public float3 LMDEOMMGMJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000260")]
	[RecRoom.DataLayer.Field(3)]
	public float3 AAPEOEOPAGE;

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x782D500", Offset = "0x782C900", VA = "0x18782D500")]
	public KIFMKPPKEAC(float GCDIMBKCOPF, float IPOFNNMKDAE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
[RecRoom.DataLayer.NetworkStruct(1, false)]
[RecRoom.DataLayer.RRGuid("35984D5B-ACBD-4389-A94B-840070A871E2")]
public struct OFDKKEMCEOC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000261")]
	[RecRoom.DataLayer.Field(1)]
	public float GKKGJNHJJOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000262")]
	[RecRoom.DataLayer.Field(2)]
	public int OEHJNPNNGLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000263")]
	[RecRoom.DataLayer.Field(3)]
	public AEKEOCGFHPH KHCEBCMPDGO;

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public bool CIPMINOOIGK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x78330E0", Offset = "0x78324E0", VA = "0x1878330E0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x78330C0", Offset = "0x78324C0", VA = "0x1878330C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public bool MNIKIPNBOLL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x7833110", Offset = "0x7832510", VA = "0x187833110")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x78330A0", Offset = "0x78324A0", VA = "0x1878330A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public bool NJFNLKGAPLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x7833120", Offset = "0x7832520", VA = "0x187833120")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x78330F0", Offset = "0x78324F0", VA = "0x1878330F0")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public class JKCEGOOJALI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000264")]
	public AEBACOJCCKK CLJDABMONFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000265")]
	public int DMJOILCPEKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000266")]
	public bool FFGLGDIECKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D")]
	[Cpp2IlInjected.Token(Token = "0x4000267")]
	public bool IPMLDHKLNHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E")]
	[Cpp2IlInjected.Token(Token = "0x4000268")]
	public bool GKGNOOADCEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000269")]
	public Vector3 KLIFIKMFFNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400026A")]
	public Quaternion APIEPNJDKPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400026B")]
	public bool BLECJHPLAPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400026C")]
	public Vector3 KLLLKPKKICE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400026D")]
	public Vector3 JIBOIOMKOBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400026E")]
	public Vector3 LDEKPGJHDEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x400026F")]
	public bool EMLEGNJMPMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000270")]
	protected ViewId IKGIBNJECGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x4000271")]
	protected FMMLDNMHJDH OHIFFEKPFII;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public ViewId HPKMIDPCNMF
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x7831920", Offset = "0x7830D20", VA = "0x187831920")]
		get
		{
			return default(ViewId);
		}
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0xE5DF70", Offset = "0xE5D370", VA = "0x180E5DF70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x78319C0", Offset = "0x7830DC0", VA = "0x1878319C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
	public JKCEGOOJALI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public struct DMGOODPFPCO : IEquatable<DMGOODPFPCO>, IComparable<DMGOODPFPCO>
{
	[Cpp2IlInjected.Token(Token = "0x4000272")]
	public static readonly int GLGPDBCJFOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000273")]
	public RRObjectPrefabData BKMONPLIHMM;

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x7830AC0", Offset = "0x782FEC0", VA = "0x187830AC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x7830A20", Offset = "0x782FE20", VA = "0x187830A20", Slot = "4")]
	public bool Equals(DMGOODPFPCO KNCKFHOKGJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x7830920", Offset = "0x782FD20", VA = "0x187830920", Slot = "0")]
	public override bool Equals(object BLFGIKOAKOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x7830A90", Offset = "0x782FE90", VA = "0x187830A90", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x78308F0", Offset = "0x782FCF0", VA = "0x1878308F0", Slot = "5")]
	public int CompareTo(DMGOODPFPCO KNCKFHOKGJM)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public readonly struct NFIJHFLFIBC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000274")]
	public readonly BACBNDOKFMO HHPLOFOADGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000275")]
	public readonly int LFFICDOLKNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000276")]
	public readonly int MBJNKPPFCJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000277")]
	public readonly int CKBJBNMIKCF;

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x1E12800", Offset = "0x1E11C00", VA = "0x181E12800")]
	public NFIJHFLFIBC(BACBNDOKFMO GHAKMOHCDAE, int PFIEGLANFFF, int CAFGEHNKFBC, int PMBCBLGMAAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x7832A70", Offset = "0x7831E70", VA = "0x187832A70")]
	public static NFIJHFLFIBC IMOFFNEFPEE(byte FAAABALDJOO, int CAFGEHNKFBC, int PMBCBLGMAAM)
	{
		return default(NFIJHFLFIBC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x78329A0", Offset = "0x7831DA0", VA = "0x1878329A0")]
	public static NFIJHFLFIBC IMOFFNEFPEE(BACBNDOKFMO GHAKMOHCDAE, int CAFGEHNKFBC, int PMBCBLGMAAM)
	{
		return default(NFIJHFLFIBC);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
internal class BMHMOAEENDB : ContainerPropertyBag<IDCEMKBPIKO>
{
	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x782FC30", Offset = "0x782F030", VA = "0x18782FC30")]
	public BMHMOAEENDB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
internal class FPDGFFNNHAJ : ContainerPropertyBag<RRObjectPrefabData>
{
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	private class JPKELOFHEFP : Property<RRObjectPrefabData, CGLGBAJFIGE>
	{
		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public override string KAFLMFCDNKO
		{
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x7832420", Offset = "0x7831820", VA = "0x187832420", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public override bool HMHCPPJANGM
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x9DE710", Offset = "0x9DDB10", VA = "0x1809DE710", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x7832330", Offset = "0x7831730", VA = "0x187832330")]
		public JPKELOFHEFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x2049D90", Offset = "0x2049190", VA = "0x182049D90", Slot = "14")]
		public override CGLGBAJFIGE GetValue(RRObjectPrefabData NKMJDOBLHGP)
		{
			return default(CGLGBAJFIGE);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x782EEE0", Offset = "0x782E2E0", VA = "0x18782EEE0", Slot = "15")]
		public override void SetValue(RRObjectPrefabData NKMJDOBLHGP, CGLGBAJFIGE FFOEEMKIKJO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000091")]
	private class PJFNEMOMLIC : Property<RRObjectPrefabData, Guid>
	{
		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public override string KAFLMFCDNKO
		{
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x78332F0", Offset = "0x78326F0", VA = "0x1878332F0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public override bool HMHCPPJANGM
		{
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x9DE710", Offset = "0x9DDB10", VA = "0x1809DE710", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x7833200", Offset = "0x7832600", VA = "0x187833200")]
		public PJFNEMOMLIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x2C6DCD0", Offset = "0x2C6D0D0", VA = "0x182C6DCD0", Slot = "14")]
		public override Guid GetValue(RRObjectPrefabData NKMJDOBLHGP)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x78331F0", Offset = "0x78325F0", VA = "0x1878331F0", Slot = "15")]
		public override void SetValue(RRObjectPrefabData NKMJDOBLHGP, Guid FFOEEMKIKJO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x78312E0", Offset = "0x78306E0", VA = "0x1878312E0")]
	public FPDGFFNNHAJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
internal class PCJOPLEKLPA : ContainerPropertyBag<Guid>
{
	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x7833190", Offset = "0x7832590", VA = "0x187833190")]
	public PCJOPLEKLPA()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x78334C0", Offset = "0x78328C0", VA = "0x1878334C0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		[UnityEngine.Scripting.Preserve]
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
