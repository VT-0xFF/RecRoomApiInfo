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
		[Cpp2IlInjected.Address(RVA = "0xA1A8A0", Offset = "0xA19AA0", VA = "0x180A1A8A0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA1A8A0", Offset = "0xA19AA0", VA = "0x180A1A8A0")]
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
	public class LogRegistrationIndex : IHAELNMODEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7C446C0", Offset = "0x7C438C0", VA = "0x187C446C0", Slot = "4")]
		public override void OOCHIMKFMHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA1A8A0", Offset = "0xA19AA0", VA = "0x180A1A8A0")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct CGAOJMNLPCJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private bool KALOOBAPGIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private ViewId NDLKHGHIICJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private int OEBFFKLMAPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private bool BDGDNEPOFKJ;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7C42B30", Offset = "0x7C41D30", VA = "0x187C42B30")]
	public CGAOJMNLPCJ(ViewId NDLKHGHIICJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7C42B50", Offset = "0x7C41D50", VA = "0x187C42B50")]
	public CGAOJMNLPCJ(int OEBFFKLMAPN, bool BDGDNEPOFKJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7C42A50", Offset = "0x7C41C50", VA = "0x187C42A50")]
	public ViewId KGLDCOEDBFL([Optional] ViewId BDIPCLIJIHK)
	{
		return default(ViewId);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class HIBPIICNNNH
{
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly Guid LPNDHHLBBNB;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static readonly Guid EDFNINOHMEG;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static readonly Guid FAHMBIKLIKL;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public static readonly Guid CLOADFPDJAP;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly Guid JJHHKCCBALK;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public static readonly Dictionary<string, Guid> MCNHDOKFDHP;

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static readonly RRObjectPrefabData LMDHFHIPMNO;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly RRObjectPrefabData GHJBBFNCNCN;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly RRObjectPrefabData GPMPPDLLELG;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7C43140", Offset = "0x7C42340", VA = "0x187C43140")]
	public static Guid NPIOMLPLJGC(string DGIAFBEDPNJ)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7C43060", Offset = "0x7C42260", VA = "0x187C43060")]
	public static RRObjectPrefabData FIDJNLIMGBP(OKHKCFDCPLN EDLOHJEBKFM)
	{
		return default(RRObjectPrefabData);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7C430F0", Offset = "0x7C422F0", VA = "0x187C430F0")]
	public static RRObjectPrefabData KGNKNLAKNPH(OKHKCFDCPLN EDLOHJEBKFM)
	{
		return default(RRObjectPrefabData);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7C430D0", Offset = "0x7C422D0", VA = "0x187C430D0")]
	public static RRObjectPrefabData HONFHEKIIJM(Guid DIHOLCNHIND)
	{
		return default(RRObjectPrefabData);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[DefaultMember("Item")]
public class GCPHFAECGBF : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly Dictionary<int, object> DHAOEHNLNON;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public Dictionary<int, object> ALBEJFPMKJB
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public object JCGKBEGFBHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7C42CC0", Offset = "0x7C41EC0", VA = "0x187C42CC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x7C42E50", Offset = "0x7C42050", VA = "0x187C42E50")]
	public GCPHFAECGBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x9FB1E0", Offset = "0x9FA3E0", VA = "0x1809FB1E0")]
	public GCPHFAECGBF(Dictionary<int, object> DHAOEHNLNON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7C42D90", Offset = "0x7C41F90", VA = "0x187C42D90")]
	public bool DBFNPMCEBBC(DGOHIKJIHIE AGBHGDFILGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x381EFA0", Offset = "0x381E1A0", VA = "0x18381EFA0")]
	public void OKMNIJCMHMP<T>(DGOHIKJIHIE AGBHGDFILGO, T MLCDCHNOCFI, [Optional] T FAGKKFIFNNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x381EDE0", Offset = "0x381DFE0", VA = "0x18381EDE0")]
	public void DENBCCCLIHH<T>(DGOHIKJIHIE AGBHGDFILGO, T MLCDCHNOCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7C42DF0", Offset = "0x7C41FF0", VA = "0x187C42DF0")]
	public void KKKHDEJPLIG(DGOHIKJIHIE AGBHGDFILGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7C42D20", Offset = "0x7C41F20", VA = "0x187C42D20", Slot = "4")]
	public object Clone()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum DGOHIKJIHIE : byte
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
public struct CDCLLCNGDPO<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public readonly DGOHIKJIHIE AGBHGDFILGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly T FAGKKFIFNNI;

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4A501D0", Offset = "0x4A4F3D0", VA = "0x184A501D0")]
	public CDCLLCNGDPO(DGOHIKJIHIE AGBHGDFILGO, T FAGKKFIFNNI)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x644B1B0", Offset = "0x644A3B0", VA = "0x18644B1B0")]
	public static CDCLLCNGDPO<T> NEKLFDMHCNA(DGOHIKJIHIE AGBHGDFILGO)
	{
		return default(CDCLLCNGDPO<T>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x644B2E0", Offset = "0x644A4E0", VA = "0x18644B2E0")]
	public static CDCLLCNGDPO<T> NEKLFDMHCNA((DGOHIKJIHIE key, T value) FCKEKMKDGOB)
	{
		return default(CDCLLCNGDPO<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(ILCMMDGMCGG))]
public struct NPBKHGDHPBE : IEnumerable<object>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private class ILCMMDGMCGG : Dictionary<string, object>
	{
	}

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private static readonly FODGIOKBGBI FHEIHFBIKLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private Dictionary<int, object> MGEECOGALOB;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool CGPGHNNJOHG
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x1743130", Offset = "0x1742330", VA = "0x181743130")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int FAGABNHAKHN
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7C45470", Offset = "0x7C44670", VA = "0x187C45470")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7C45130", Offset = "0x7C44330", VA = "0x187C45130")]
	public static NPBKHGDHPBE EAIFKKLDBGP()
	{
		return default(NPBKHGDHPBE);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0xD42160", Offset = "0xD41360", VA = "0x180D42160")]
	public NPBKHGDHPBE([Optional] Dictionary<int, object> MGEECOGALOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x398E2F0", Offset = "0x398D4F0", VA = "0x18398E2F0")]
	public void OOLDDNFEGEK<T>(CDCLLCNGDPO<T> AGBHGDFILGO, T? MLCDCHNOCFI) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x398E110", Offset = "0x398D310", VA = "0x18398E110")]
	public void OOLDDNFEGEK<T>((CDCLLCNGDPO<T> key, T value) JDCPBBKFIMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x398DFA0", Offset = "0x398D1A0", VA = "0x18398DFA0")]
	public void OOLDDNFEGEK<T>(CDCLLCNGDPO<T> AGBHGDFILGO, T MLCDCHNOCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7C45210", Offset = "0x7C44410", VA = "0x187C45210")]
	public void HCPMLEOPPMA(NPBKHGDHPBE JIJCOIBMMGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7C454C0", Offset = "0x7C446C0", VA = "0x187C454C0")]
	private void MNFKMEBPDCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x398BC20", Offset = "0x398AE20", VA = "0x18398BC20")]
	public bool FLFGMEICIOC<T>(CDCLLCNGDPO<T> AGBHGDFILGO, [Out] T MLCDCHNOCFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x398B870", Offset = "0x398AA70", VA = "0x18398B870")]
	public bool FLFGMEICIOC<T>(DGOHIKJIHIE AGBHGDFILGO, [Out] T MLCDCHNOCFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x398DCA0", Offset = "0x398CEA0", VA = "0x18398DCA0")]
	public T ONNNHNMLIFN<T>(CDCLLCNGDPO<T> AGBHGDFILGO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x398B750", Offset = "0x398A950", VA = "0x18398B750")]
	public bool DBFNPMCEBBC<T>(CDCLLCNGDPO<T> AGBHGDFILGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7C450D0", Offset = "0x7C442D0", VA = "0x187C450D0")]
	public bool DBFNPMCEBBC(DGOHIKJIHIE AGBHGDFILGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x398D990", Offset = "0x398CB90", VA = "0x18398D990")]
	public void KKKHDEJPLIG<T>(CDCLLCNGDPO<T> AGBHGDFILGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7C45420", Offset = "0x7C44620", VA = "0x187C45420")]
	public void KKKHDEJPLIG(DGOHIKJIHIE AGBHGDFILGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0xD42150", Offset = "0xD41350", VA = "0x180D42150")]
	public Dictionary<int, object> LKBNIJDEABB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7C451B0", Offset = "0x7C443B0", VA = "0x187C451B0", Slot = "4")]
	public IEnumerator<object> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7C45540", Offset = "0x7C44740", VA = "0x187C45540", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public enum OEOIMIFEKCH
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
	StudioObjectComponents,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	DesyncNetworkObjectComponents,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	AuthoredPoseComponents
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface IFLFAPHLPOC
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public enum KMLOBEGCHOG
	{
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		Entity,
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		Prefab
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	LocalId KCFOPJDDHPF
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	RRObjectPrefabData DPFHIMGDLOC
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FKPMGJMAHNG(params string[] BLGKPGNAIBK);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KKFGAGJPICF(OEOIMIFEKCH EEGKMDDKFBE, KMLOBEGCHOG BGIKBFMPDCC = KMLOBEGCHOG.Entity);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FFCHMONPEMB(Type EDLOHJEBKFM, ReadOnlySpan<byte> DHAOEHNLNON, int FPALNLNFJOC, KMLOBEGCHOG BGIKBFMPDCC = KMLOBEGCHOG.Entity);

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void IGPBECMIONI(Type EDLOHJEBKFM, KMLOBEGCHOG BGIKBFMPDCC = KMLOBEGCHOG.Entity);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void FNJOLLFADPP(OEOIMIFEKCH EEGKMDDKFBE, KMLOBEGCHOG BGIKBFMPDCC = KMLOBEGCHOG.Entity);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool CABBLHCHKNO(OEOIMIFEKCH EEGKMDDKFBE);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void FDJOKHCDFHD(bool IMFCIEADBDA, KMLOBEGCHOG BGIKBFMPDCC = KMLOBEGCHOG.Entity);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void NDIGPHEOJHG();

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void ONIMKOBNIIE(Type EDLOHJEBKFM);

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "11")]
	JPNFLMLFIPK DCLNFEAFOHF(Type EDLOHJEBKFM);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class NGMBFFMMDMN
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7C44C70", Offset = "0x7C43E70", VA = "0x187C44C70")]
	public static bool BHEPFDHBHMD(this IFLFAPHLPOC OPJOIGJBJKN, OEOIMIFEKCH DHOGCHOHKLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7C44E70", Offset = "0x7C44070", VA = "0x187C44E70")]
	public static void LEEFJOGACAP(this IFLFAPHLPOC OPJOIGJBJKN, IFLFAPHLPOC.KMLOBEGCHOG BGIKBFMPDCC = IFLFAPHLPOC.KMLOBEGCHOG.Entity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7C44ED0", Offset = "0x7C440D0", VA = "0x187C44ED0")]
	public static void OGAEJLFJLIJ(this IFLFAPHLPOC OPJOIGJBJKN, IFLFAPHLPOC.KMLOBEGCHOG BGIKBFMPDCC = IFLFAPHLPOC.KMLOBEGCHOG.Entity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3983B40", Offset = "0x3982D40", VA = "0x183983B40")]
	public static void FCIOFINDMDO<T>(this IFLFAPHLPOC OPJOIGJBJKN, IFLFAPHLPOC.KMLOBEGCHOG BGIKBFMPDCC = IFLFAPHLPOC.KMLOBEGCHOG.Entity) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x37F36F0", Offset = "0x37F28F0", VA = "0x1837F36F0")]
	public static void KJHNLBPFNGA<T>(this IFLFAPHLPOC OPJOIGJBJKN, IFLFAPHLPOC.KMLOBEGCHOG BGIKBFMPDCC = IFLFAPHLPOC.KMLOBEGCHOG.Entity) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x3985AC0", Offset = "0x3984CC0", VA = "0x183985AC0")]
	public static void HLJKPOPLMLO<T>(this IFLFAPHLPOC OPJOIGJBJKN, bool IFLGKOCAIOG, IFLFAPHLPOC.KMLOBEGCHOG BGIKBFMPDCC = IFLFAPHLPOC.KMLOBEGCHOG.Entity) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3983B80", Offset = "0x3982D80", VA = "0x183983B80")]
	public static void FFCHMONPEMB<T>(this IFLFAPHLPOC OPJOIGJBJKN, T MLCDCHNOCFI, IFLFAPHLPOC.KMLOBEGCHOG BGIKBFMPDCC = IFLFAPHLPOC.KMLOBEGCHOG.Entity) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x3985B30", Offset = "0x3984D30", VA = "0x183985B30")]
	public static void IGPBECMIONI<T>(this IFLFAPHLPOC OPJOIGJBJKN, IFLFAPHLPOC.KMLOBEGCHOG BGIKBFMPDCC = IFLFAPHLPOC.KMLOBEGCHOG.Entity) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3985D10", Offset = "0x3984F10", VA = "0x183985D10")]
	public static void ONIMKOBNIIE<T>(this IFLFAPHLPOC OPJOIGJBJKN) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3983AA0", Offset = "0x3982CA0", VA = "0x183983AA0")]
	public static void BLLLLAAAAGE<T>(this IFLFAPHLPOC OPJOIGJBJKN, LocalId EANCCIKOAFJ, IFLFAPHLPOC.KMLOBEGCHOG BGIKBFMPDCC = IFLFAPHLPOC.KMLOBEGCHOG.Entity) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3983C40", Offset = "0x3982E40", VA = "0x183983C40")]
	private static void FFCHMONPEMB<T>(this IFLFAPHLPOC OPJOIGJBJKN, Type EDLOHJEBKFM, T MLCDCHNOCFI, IFLFAPHLPOC.KMLOBEGCHOG BGIKBFMPDCC = IFLFAPHLPOC.KMLOBEGCHOG.Entity) where T : struct
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct HMALLMOHPCA
{
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface DBHDPPKALIP
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	Entity PDLFACMOJJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface KKHGLPKGNNB
{
	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void Bake(IFLFAPHLPOC OPJOIGJBJKN);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface KOGJBEAOEPA
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JPNFLMLFIPK DNCEAGEBBHO(Type EDLOHJEBKFM);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class OMMILILJFOB
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x39FAE90", Offset = "0x39FA090", VA = "0x1839FAE90")]
	public static void DNCEAGEBBHO<T>(this KOGJBEAOEPA OPJOIGJBJKN, [Out] T MLCDCHNOCFI) where T : JPNFLMLFIPK
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface JPNFLMLFIPK
{
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class OAGBMEDFLPC
{
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x39DE030", Offset = "0x39DD230", VA = "0x1839DE030")]
	public static void GCOGLKCGINN<T>(this T ELAPGGHMDCC, IFLFAPHLPOC OPJOIGJBJKN) where T : JPNFLMLFIPK, EOINDFNEDAI
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x39DDFF0", Offset = "0x39DD1F0", VA = "0x1839DDFF0")]
	public static bool DHGLPEGDBLB<T>(this T ACPFMGEKNNK) where T : JPNFLMLFIPK
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface EOINDFNEDAI
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	Type MOIMLPEHJLH
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LHEIMFHDGOA(JPNFLMLFIPK ACPFMGEKNNK);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface ABPNCFGDNFA : KKHGLPKGNNB
{
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void InitNetworkData(KOGJBEAOEPA OPJOIGJBJKN);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface OCDMHNCHIGM : JPNFLMLFIPK
{
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface DGDACOEFOEH
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DDICPEDMJMH(MMNMPKDPAGK KOCMKKLCMKL);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LCHBAIIBOPJ(MMNMPKDPAGK KOCMKKLCMKL);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface OPKBLCJLMNI
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	ViewId MIJPAFJJHGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface GHFHANGICMB : OPKBLCJLMNI, ENGCOENEKCO
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void Initialize(ViewId BHIKICEGEMH, ViewId EAKDKFBBGKE, Dictionary<int, object> IEEHHNMCCEB, MMNMPKDPAGK FNEFIOJLPDJ);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface OJKKAKHNEGD : OPKBLCJLMNI
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ILLMBOBOELN(KOAGADGMKNF NJHDJGHEICO, Vector3 KGEICFIBDCA, Quaternion JLBNIDPEHNC, Vector3 MCNGNFFDHIC, bool CBAOHCJPBHJ);

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PBGGBDBOLKM(Vector3 KGEICFIBDCA, Quaternion JLBNIDPEHNC, Vector3 MCNGNFFDHIC);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GDFLKEKMOMJ(ViewId NJHDJGHEICO);

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BEEBPPKPKHP(bool KEMMFNJGKPF);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DAIGCEJEPFA(bool IEDLNHJHKFB);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface ENGCOENEKCO
{
	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DFDLLLBCEAJ();
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface OMNBBOPHMDK
{
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NativeArray<Guid> IGKNJPHBCBG(World NKENFIFGFHM, NativeArray<Entity> EEOGDGCIFOA, Allocator FOPENOLHBOM);
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface FJMKGJNBFNF
{
	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "0")]
	ReadOnlySpan<byte> LLGKACNFPFG(Entity LBPCFJCJDPM, int EJBEKIHBFOO);

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FBCMOCNKAHH(Entity LBPCFJCJDPM, int EJBEKIHBFOO, ReadOnlySpan<byte> MLCDCHNOCFI);

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BJADGGGDGOB(Entity LBPCFJCJDPM, int EJBEKIHBFOO, Action LKEPFHDAAED);

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MMLDCNFNLHG(Entity LBPCFJCJDPM, int EJBEKIHBFOO, Action LKEPFHDAAED);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public static class DAALLFCICGA
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x36618C0", Offset = "0x3660AC0", VA = "0x1836618C0")]
	public static T GPGCJFFAJFK<T>(this FJMKGJNBFNF MNCMOKIKCCI, Entity LBPCFJCJDPM, int EJBEKIHBFOO) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x3661A10", Offset = "0x3660C10", VA = "0x183661A10")]
	public static void JPBAOEEGBBB<T>(this FJMKGJNBFNF MNCMOKIKCCI, Entity LBPCFJCJDPM, int EJBEKIHBFOO, T MLCDCHNOCFI) where T : struct
	{
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(9635027148749164348uL)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("6241769E-7423-45E5-B125-9F7EAA5D5232")]
	public struct AiCodeGenIdData : IComponentData, IEquatable<AiCodeGenIdData>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public FixedString64Bytes Value;

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x7C42310", Offset = "0x7C41510", VA = "0x187C42310", Slot = "4")]
		public bool Equals(AiCodeGenIdData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7C42350", Offset = "0x7C41550", VA = "0x187C42350", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x7C42400", Offset = "0x7C41600", VA = "0x187C42400", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[TypeManager.ForcedStableTypeHash(3758703684052595571uL)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("399DD840-DE45-43FA-9EB0-5E80BC93C8CB")]
	[CompilerGenerated]
	public struct AiCodeGenNameData : IComponentData, IEquatable<AiCodeGenNameData>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public FixedString64Bytes Value;

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x7C42310", Offset = "0x7C41510", VA = "0x187C42310", Slot = "4")]
		public bool Equals(AiCodeGenNameData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x7C42410", Offset = "0x7C41610", VA = "0x187C42410", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x7C42400", Offset = "0x7C41600", VA = "0x187C42400", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public struct CAOAOALBPPI : IComponentData, IEquatable<CAOAOALBPPI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	[RecRoom.DataLayer.Field(1)]
	[RecRoom.DataLayer.Default]
	public uint ABLHJAOAOGP;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7C424C0", Offset = "0x7C416C0", VA = "0x187C424C0", Slot = "4")]
	public bool Equals(CAOAOALBPPI FNJGMJGALLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7C42730", Offset = "0x7C41930", VA = "0x187C42730", Slot = "0")]
	public override bool Equals(object DBCLNEGBNLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x12D61D0", Offset = "0x12D53D0", VA = "0x1812D61D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[RecRoom.DataLayer.TombstonedFields(new int[] { 2 })]
	[TypeManager.ForcedStableTypeHash(11317457978519712368uL)]
	[RecRoom.DataLayer.RRGuid("A8D1A28C-A057-4DF1-B0CF-22A81E217E19")]
	[RecRoom.DataLayer.NetworkComponent(4, false)]
	[CompilerGenerated]
	public struct AuthoredAIIdData : IComponentData, IEquatable<AuthoredAIIdData>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public uint Value;

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7C424C0", Offset = "0x7C416C0", VA = "0x187C424C0", Slot = "4")]
		public bool Equals(AuthoredAIIdData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7C424D0", Offset = "0x7C416D0", VA = "0x187C424D0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x12D61D0", Offset = "0x12D53D0", VA = "0x1812D61D0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(3063687516547021329uL)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("650DAD22-E465-4BF2-9A09-076774E09A3E")]
	public struct AuthoredLocalDeformableScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		[RecRoom.DataLayer.Default("new float3(1)")]
		[RecRoom.DataLayer.Field(1)]
		public float3 localDeformationScale;

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xECBC20", Offset = "0xECAE20", VA = "0x180ECBC20")]
		public AuthoredLocalDeformableScaleData(float3 scale)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(11505792609904010668uL)]
	[RecRoom.DataLayer.RRGuid("B7CEB5B9-453F-4712-B833-27D907AA13E2")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.StableTypeHash(11505792609904010668uL, 0u)]
	public struct AuthoredLocalPoseData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default("new quaternion(new float4(float.NaN))")]
		public quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		[RecRoom.DataLayer.Field(2)]
		[RecRoom.DataLayer.Default("new float3(float.NaN)")]
		public float3 localPosition;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public readonly bool IsValid
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x7C42560", Offset = "0x7C41760", VA = "0x187C42560")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x50A7BD0", Offset = "0x50A6DD0", VA = "0x1850A7BD0")]
		public AuthoredLocalPoseData(quaternion localRotation, float3 localPosition)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x7C425C0", Offset = "0x7C417C0", VA = "0x187C425C0")]
		public static RigidTransform NEKLFDMHCNA(AuthoredLocalPoseData poseData)
		{
			return default(RigidTransform);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x7C425C0", Offset = "0x7C417C0", VA = "0x187C425C0")]
		public static AuthoredLocalPoseData NEKLFDMHCNA(RigidTransform pose)
		{
			return default(AuthoredLocalPoseData);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public static class FGLCFPMBMBP
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x7C42C60", Offset = "0x7C41E60", VA = "0x187C42C60")]
	public static AuthoredLocalPoseData FKDMHKKNKLN([In] this RigidTransform MLCDCHNOCFI)
	{
		return default(AuthoredLocalPoseData);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0xC84900", Offset = "0xC83B00", VA = "0x180C84900")]
	public static RigidTransform DMJDPPFPBEE(this AuthoredLocalPoseData MLCDCHNOCFI)
	{
		return default(RigidTransform);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7C42C90", Offset = "0x7C41E90", VA = "0x187C42C90")]
	public static RigidTransform HMCNONOMHPA([In] this AuthoredLocalPoseData MLCDCHNOCFI)
	{
		return default(RigidTransform);
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(9088562008033959482uL)]
	[RecRoom.DataLayer.StableTypeHash(9088562008033959482uL, 0u)]
	[RecRoom.DataLayer.RRGuid("C26C4B4E-5EF3-4F81-87C8-FED8EAD37242")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct AuthoredLocalUniformScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		[RecRoom.DataLayer.Default(1f)]
		[RecRoom.DataLayer.Field(1)]
		public float localUniformScale;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public readonly bool IsValid
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x7C425E0", Offset = "0x7C417E0", VA = "0x187C425E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x29E44F0", Offset = "0x29E36F0", VA = "0x1829E44F0")]
		public AuthoredLocalUniformScaleData(float localUniformScale)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[TypeManager.ForcedStableTypeHash(10137300772124140051uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.StableTypeHash(10137300772124140051uL, 0u)]
	[RecRoom.DataLayer.RRGuid("7B1B8635-3FA9-4ADC-922B-3C25CE0C7E7D")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct AuthoredParentData : IComponentData, DBHDPPKALIP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public Entity parent;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0xD42150", Offset = "0xD41350", VA = "0x180D42150", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0xEEC790", Offset = "0xEEB990", VA = "0x180EEC790", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0xEEC790", Offset = "0xEEB990", VA = "0x180EEC790")]
		public AuthoredParentData(Entity parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x7C42640", Offset = "0x7C41840", VA = "0x187C42640", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct OFOCODGLOBA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002C")]
[TypeManager.ForcedStableTypeHash(11776442497872827640uL)]
public struct BLICLOELEHF : IComponentData
{
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[RecRoom.DataLayer.StableTypeHash(8594223769175916906uL, 0u)]
	[TypeManager.ForcedStableTypeHash(8594223769175916906uL)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[CompilerGenerated]
	[RecRoom.DataLayer.RRGuid("B9A63EF5-66A5-463C-8385-A7DC7CE137C3")]
	public struct ObjectBoardNodeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public NetworkGuid nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		[RecRoom.DataLayer.Field(2)]
		[RecRoom.DataLayer.Default]
		public NetworkGuid graphId;
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[RecRoom.DataLayer.RRGuid("B26EF01D-F674-4506-80B7-5345391A097E")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(5933855128949143734uL)]
	public struct ReplicatedObjectActiveStatusData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		[RecRoom.DataLayer.Default(true)]
		[RecRoom.DataLayer.Field(1)]
		public bool active;
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[RecRoom.DataLayer.RRGuid("E9BA10A4-4EE9-431D-BD7F-FF2008ABFA03")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(16338184133650423946uL)]
	public struct ReplicatedObjectOwnedByPlayerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default(-1)]
		public int actorId;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000030")]
public struct DFICHLODDOK : IComponentData
{
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[TypeManager.ForcedStableTypeHash(16223816226138460552uL)]
	[RecRoom.DataLayer.RRGuid("46C500A2-9991-4987-B1AA-66E5C3D8E371")]
	public struct ReplicatedObjectTag : IComponentData
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	[RecRoom.DataLayer.RRGuid("5ED157AA-488F-453A-A986-594595B8D777")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(17912083982325865811uL)]
	public struct ReplicatorData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public Entity Target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		[RecRoom.DataLayer.Default(false)]
		[RecRoom.DataLayer.Field(2)]
		public bool NeedsCircuitUpdate;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000033")]
public struct IDOBHHBFOND : IComponentData
{
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[TypeManager.ForcedStableTypeHash(8691279933813304851uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.RRGuid("AEA4D222-29BA-462F-9C0A-AA2063671C68")]
	public struct ReplicatorMaxObjectCountData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		[RecRoom.DataLayer.Default(10)]
		[RecRoom.DataLayer.Field(1)]
		public int count;
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	[TypeManager.ForcedStableTypeHash(16379995002884076574uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.RRGuid("400790C1-E8D9-4779-A549-3780DAEC2FDF")]
	public struct ReplicatorPreallocatedObjectCountData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default(0)]
		public int preallocatedCopies;
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	[RecRoom.DataLayer.RRGuid("6A82044A-E392-4DCD-B4BC-A120E58334EA")]
	[RecRoom.DataLayer.StableTypeHash(8536678595025273356uL, 0u)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[TypeManager.ForcedStableTypeHash(8536678595025273356uL)]
	public struct EntityPrefabPartData : IComponentData, IComparable<EntityPrefabPartData>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public Entity prefabRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(2)]
		public uint partId;

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x7C42B90", Offset = "0x7C41D90", VA = "0x187C42B90", Slot = "4")]
		public readonly int CompareTo(EntityPrefabPartData other)
		{
			return default(int);
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public struct EntityPrefabPartId : IEquatable<EntityPrefabPartId>, IComparable<EntityPrefabPartId>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		[SerializeField]
		private uint id;

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x12B95B0", Offset = "0x12B87B0", VA = "0x1812B95B0")]
		internal EntityPrefabPartId(uint MKHHKDJKLDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0xA3D0B0", Offset = "0xA3C2B0", VA = "0x180A3D0B0")]
		internal uint EJNHNCNCGPJ()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x2175BB0", Offset = "0x2174DB0", VA = "0x182175BB0", Slot = "4")]
		public bool Equals(EntityPrefabPartId FNJGMJGALLH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x7C42BE0", Offset = "0x7C41DE0", VA = "0x187C42BE0", Slot = "0")]
		public override bool Equals(object DBCLNEGBNLN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x12D61D0", Offset = "0x12D53D0", VA = "0x1812D61D0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x2175B20", Offset = "0x2174D20", VA = "0x182175B20", Slot = "5")]
		public int CompareTo(EntityPrefabPartId FNJGMJGALLH)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[TypeManager.ForcedStableTypeHash(15026348711748810383uL)]
public struct DIJDHNDFKJC : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public Entity IJONBOEPBFA;
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	[CompilerGenerated]
	[ConfigGroup("Physics", 0)]
	[TypeManager.ForcedStableTypeHash(2330616907306882483uL)]
	[RecRoom.DataLayer.RRGuid("F74D558B-BDCC-48C8-A8EF-1F7559E5EAA0")]
	public struct PhysicsModelCollisionModeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		[Config(null, 0)]
		[RecRoom.DataLayer.Default(CLCCGGMNJHK.Children)]
		[RecRoom.DataLayer.Field(1)]
		public CLCCGGMNJHK collisionMode;
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(11125590729425051511uL)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[ConfigGroup("Container", 0)]
	[RecRoom.DataLayer.RRGuid("8A12EB45-2A15-41CE-AFF7-90A9F984D3A2")]
	public struct ContainerIsRecolorableData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		[Config(null, 0)]
		public bool IsRecolorable;
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("55EAB643-95BB-4C3A-832C-798EBCD95AD5")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(14800424556151816553uL)]
	[InternalBufferCapacity(0)]
	public struct ContainerNameBuffer : IBufferElementData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public byte data;
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("89708D57-D027-494A-A159-221E6C643B6B")]
	[TypeManager.ForcedStableTypeHash(13657791279235747653uL)]
	[CompilerGenerated]
	[ConfigGroup("Container", 0)]
	[RecRoom.DataLayer.StableTypeHash(13657791279235747653uL, 0u)]
	public struct ContainerNameData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		[Config(null, 0)]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public FixedString64Bytes name;
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	[ConfigGroup("Physics", 0)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(13904209480152351845uL)]
	[RecRoom.DataLayer.RRGuid("CA023286-E0F6-4DA9-A346-94E86B93977C")]
	public struct PhysicsModelGrabbableModeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		[Config(null, 0)]
		public EBPGAOAANLG grabbableMode;
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("84485C1B-18ED-4D4A-86A4-34CEED482615")]
	[RecRoom.DataLayer.StableTypeHash(16485879999901987510uL, 0u)]
	[TypeManager.ForcedStableTypeHash(16485879999901987510uL)]
	[CompilerGenerated]
	[ConfigGroup("Container", 0)]
	public struct NavMeshGenerationData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default(INHFKGENNEJ.NavMeshGenerator)]
		[Config(null, 0)]
		public INHFKGENNEJ mode;
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	[TypeManager.ForcedStableTypeHash(1954118413118190521uL)]
	[ConfigGroup("Physics", 0)]
	[CompilerGenerated]
	[RecRoom.DataLayer.RRGuid("C5BCE8B3-6E69-41D4-921A-BE2E3E0A4DAB")]
	public struct PhysicsModelCollisionLayerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default(LFONANDBLOB.IsDynamicEnvironment)]
		[Config(null, 0)]
		public LFONANDBLOB collisionLayer;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class PIDPCMJDAHE
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public enum GAPHBKAIIFC
	{
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		Dynamic,
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		Static,
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		Enemy,
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		Vehicle
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public enum BJCJNFPDOEI
	{
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		Environmental,
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		IgnoreStaticGeometry,
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		IgnoreOtherDynamic,
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		IgnorePlayers,
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		IgnoreMost,
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		Projectile
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7C459A0", Offset = "0x7C44BA0", VA = "0x187C459A0")]
	public static (GAPHBKAIIFC, BJCJNFPDOEI) FHNPLGICLCM(this LFONANDBLOB LFADMJJFICC)
	{
		return default((GAPHBKAIIFC, BJCJNFPDOEI));
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[RecRoom.DataLayer.RRGuid("F63AA9EA-6191-4DE9-BB18-1F049F432124")]
	[TypeManager.ForcedStableTypeHash(16462677563651546047uL)]
	[ConfigGroup("Physics", 0)]
	[RecRoom.DataLayer.NetworkComponent(4, false)]
	[CompilerGenerated]
	public struct PhysicsModelFlagsData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		[Config(null, 0)]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default(PFDCBFKJOFO.DEFAULT)]
		public PFDCBFKJOFO flags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[TypeManager.ForcedStableTypeHash(1094837642118998916uL)]
	[CompilerGenerated]
	[ConfigGroup("Physics", 0)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("B6D08147-6AEA-4270-BDC4-8CF68662318D")]
	[RecRoom.DataLayer.StableTypeHash(1094837642118998916uL, 0u)]
	public struct PhysicsModelMassOverrideData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default(0f)]
		[Config(null, 0)]
		public float mass;
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[RecRoom.DataLayer.StableTypeHash(1537567323754185605uL, 0u)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(1537567323754185605uL)]
	[RecRoom.DataLayer.RRGuid("D732BC3D-4F8D-4FDE-BDB2-88C095D973C2")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct CostumePieceParentCostumeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public Entity parentCostume;
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[RecRoom.DataLayer.RRGuid("36A2D516-8596-4794-BEAE-40BECA68C798")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(5115014870530256079uL)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.StableTypeHash(5115014870530256079uL, 0u)]
	public struct CostumePieceSlotIndexData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public int slotIndex;
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("17799917-98EE-4D9A-A8D1-B0BE5F7316E3")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(10518841812724430444uL)]
	public struct InventionIdData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default(0L)]
		public long inventionId;

		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public const long INVALID_INVENTION_ID = 0L;

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0xC84900", Offset = "0xC83B00", VA = "0x180C84900")]
		public static InventionIdData NEKLFDMHCNA(long value)
		{
			return default(InventionIdData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x7C43850", Offset = "0x7C42A50", VA = "0x187C43850")]
		public readonly bool CLPCJAPIHFI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x798F000", Offset = "0x798E200", VA = "0x18798F000")]
		public static bool CLPCJAPIHFI(long inventionId)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[RecRoom.DataLayer.RRGuid("629F0A56-C478-4353-BBDA-8A8BB5FEE478")]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	[RecRoom.DataLayer.TombstonedFields(new int[] { 1 })]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(14338988155392421373uL)]
	public struct InventionInstanceIdData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(2)]
		public NetworkGuid instanceId;

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x1227CB0", Offset = "0x1226EB0", VA = "0x181227CB0")]
		public static InventionInstanceIdData NEKLFDMHCNA(Guid value)
		{
			return default(InventionInstanceIdData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[TypeManager.ForcedStableTypeHash(7796256876318585598uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.RRGuid("5D26C8C6-7B5E-481E-B31E-6F30BE69D3C9")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct DesyncEntityReferenceData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public Entity entity;
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[RecRoom.DataLayer.RRGuid("AFCA5CDE-FE11-4D4A-BBC6-32EE1D254891")]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[TypeManager.ForcedStableTypeHash(3111430309403391054uL)]
	public struct DesyncNetworkEntityBackReferenceData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public Entity entity;
	}
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("F1D14C4E-5388-4D7C-B641-5E79453B80AB")]
	[TypeManager.ForcedStableTypeHash(3936130774074738641uL)]
	[CompilerGenerated]
	[SerializationOnly]
	public struct DesyncNetworkComponentsData : IBufferElementData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public ulong stableTypeHash;
	}
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[RuntimeOnly]
	[RecRoom.DataLayer.StableTypeHash(12111354511484844847uL, 0u)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[TypeManager.ForcedStableTypeHash(12111354511484844847uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.RRGuid("A3B27452-BD6C-43B2-BAFF-CF885EB1608B")]
	public struct ParentData : IComponentData, DBHDPPKALIP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public Entity parent;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0xD42150", Offset = "0xD41350", VA = "0x180D42150", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0xEEC790", Offset = "0xEEB990", VA = "0x180EEC790", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0xEEC790", Offset = "0xEEB990", VA = "0x180EEC790")]
		public ParentData(Entity parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0xC84900", Offset = "0xC83B00", VA = "0x180C84900")]
		public static implicit operator ParentData(Entity entity)
		{
			return default(ParentData);
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004D")]
public struct LJOPHCEOEDP : IComponentData
{
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[RecRoom.DataLayer.StableTypeHash(1950029632769634832uL, 0u)]
	[TypeManager.ForcedStableTypeHash(1950029632769634832uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.RRGuid("c886150a-7231-4cc5-a2b2-f222500e6960")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct SiblingSortOrderData : IEquatable<SiblingSortOrderData>, IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public ABGKFFJDPAB order;

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0xC84900", Offset = "0xC83B00", VA = "0x180C84900")]
		public static SiblingSortOrderData NEKLFDMHCNA(ABGKFFJDPAB value)
		{
			return default(SiblingSortOrderData);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x7C41F30", Offset = "0x7C41130", VA = "0x187C41F30", Slot = "4")]
		public bool Equals(SiblingSortOrderData other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[TypeManager.ForcedStableTypeHash(6217116203744017593uL)]
	[RecRoom.DataLayer.RRGuid("46CEA601-8AA7-423D-B1EA-EEABAE73413F")]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct InteractionFilterAllTagsData : IComponentData, DBHDPPKALIP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public Entity allTags;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0xD42150", Offset = "0xD41350", VA = "0x180D42150", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0xEEC790", Offset = "0xEEB990", VA = "0x180EEC790", Slot = "5")]
			set
			{
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("49CEFD0F-3A38-4A9B-835E-10B4C2D08392")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(6215026851838101933uL)]
	public struct InteractionFilterAnyTagsData : IComponentData, DBHDPPKALIP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public Entity anyTags;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0xD42150", Offset = "0xD41350", VA = "0x180D42150", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0xEEC790", Offset = "0xEEB990", VA = "0x180EEC790", Slot = "5")]
			set
			{
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[TypeManager.ForcedStableTypeHash(6780642047612598977uL)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[CompilerGenerated]
	[RecRoom.DataLayer.RRGuid("11CE457F-4366-4AAD-B7E3-28D82B4FAFCF")]
	public struct InteractionFilterEnabledData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default(OOJGIMJMHJA.Disabled)]
		public OOJGIMJMHJA filterMode;
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[TypeManager.ForcedStableTypeHash(6642820932987006861uL)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[CompilerGenerated]
	[RecRoom.DataLayer.RRGuid("F7789094-7D82-4D27-B805-2CC1B8C0A538")]
	public struct InteractionFilterEntityRefData : IComponentData, DBHDPPKALIP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public Entity filterEntity;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0xD42150", Offset = "0xD41350", VA = "0x180D42150", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0xEEC790", Offset = "0xEEB990", VA = "0x180EEC790", Slot = "5")]
			set
			{
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("C7E95AF7-DB7D-4432-8DAA-8F36EC6C4308")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(15467295871228743847uL)]
	public struct InteractionFilterNoneTagsData : IComponentData, DBHDPPKALIP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public Entity noneTags;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0xD42150", Offset = "0xD41350", VA = "0x180D42150", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xEEC790", Offset = "0xEEB990", VA = "0x180EEC790", Slot = "5")]
			set
			{
			}
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[RecRoom.DataLayer.RRGuid("007F8815-C87C-4E6B-BC56-3BA0C4888E3D")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.StableTypeHash(15012400804589552708uL, 0u)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(15012400804589552708uL)]
	public struct OverrideObjectNetworkIdData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public uint networkIdBits;
	}
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(4540375434353162791uL)]
	[RecRoom.DataLayer.RRGuid("30228348-77DF-48F6-B2EF-B0883D3E10CA")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct MakerPenHeldData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public bool makerPenHeld;
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[ConfigGroup("Object", 0)]
	[CompilerGenerated]
	[RecRoom.DataLayer.RRGuid("FB9853D6-6231-43FD-A754-00105DC30880")]
	[RecRoom.DataLayer.NetworkComponent(6, false)]
	[TypeManager.ForcedStableTypeHash(8459715919607487693uL)]
	public struct ObjectPolicyData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		[RecRoom.DataLayer.Default("new ScaleRestriction(1,1)")]
		[RecRoom.DataLayer.Field(2)]
		public LKBFADCEBCA scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		[Config(null, 0)]
		[RecRoom.DataLayer.Default("ObjectPolicyUserConfigurableFlags.DEFAULT")]
		[RecRoom.DataLayer.Field(3)]
		public KHFPIIIDCNJ userConfigurableFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		[RecRoom.DataLayer.Field(4)]
		[RecRoom.DataLayer.Default(LEFIJBDKMMH.Default)]
		[Config(null, 0)]
		public LEFIJBDKMMH circuitsTransformBehavior;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		[RecRoom.DataLayer.Default("ObjectPolicyEnumFlags.Default")]
		[RecRoom.DataLayer.Field(1)]
		public PKDAAPODPAF flags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[TypeManager.ForcedStableTypeHash(2965180940795077803uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.RRGuid("01AEEF22-2473-4505-A473-0BBF009690B3")]
	[SerializationOnly]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct RemovedNetworkComponentsBuffer : IBufferElementData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public ulong stableTypeHash;
	}
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[RecRoom.DataLayer.RRGuid("617A903E-C2C2-467C-A138-287FDB487645")]
	[CompilerGenerated]
	[RecRoom.DataLayer.StableTypeHash(17708500325183871236uL, 0u)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[TypeManager.ForcedStableTypeHash(17708500325183871236uL)]
	public struct PlayerScopeData : IComponentData, DBHDPPKALIP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public Entity playerScope;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public Entity Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0xD42150", Offset = "0xD41350", VA = "0x180D42150", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0xEEC790", Offset = "0xEEB990", VA = "0x180EEC790", Slot = "5")]
			set
			{
			}
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0xC84900", Offset = "0xC83B00", VA = "0x180C84900")]
		public static PlayerScopeData NEKLFDMHCNA(Entity entity)
		{
			return default(PlayerScopeData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[RecRoom.DataLayer.RRGuid("F945B699-C9E5-4634-9F64-831484F4F3BD")]
	[RecRoom.DataLayer.StableTypeHash(16642773407304133105uL, 0u)]
	[ConfigGroup("Physics", 0)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[TypeManager.ForcedStableTypeHash(16642773407304133105uL)]
	[CompilerGenerated]
	public struct PhysicsMaterialData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		[Config(null, 0)]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default(10f)]
		public float density;
	}
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.StableTypeHash(10537432342869025182uL, 0u)]
	[TypeManager.ForcedStableTypeHash(10537432342869025182uL)]
	[RecRoom.DataLayer.RRGuid("A2E0AF0F-C284-47E6-9535-A67A29BF5730")]
	[CompilerGenerated]
	public struct ShapeConfigData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default(OMNIHJEOLPK.None)]
		public OMNIHJEOLPK flags;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool DynamicUVProjection
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x7022470", Offset = "0x7021670", VA = "0x187022470")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool PreventInvertedCreation
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x7022480", Offset = "0x7021680", VA = "0x187022480")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public bool NewBendLogic
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x7C45F80", Offset = "0x7C45180", VA = "0x187C45F80")]
			get
			{
				return default(bool);
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	[RecRoom.DataLayer.RRGuid("5C706BF1-9D50-456A-B974-521E8E2CC660")]
	[RecRoom.DataLayer.StableTypeHash(10917729582819845312uL, 0u)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[TypeManager.ForcedStableTypeHash(10917729582819845312uL)]
	public struct ShapeTypeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public NGNNDBBMKGO shapeType;
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("36418781-DB47-4DE7-A138-CC88D1D795C0")]
	[RecRoom.DataLayer.StableTypeHash(5298506180484533559uL, 0u)]
	[TypeManager.ForcedStableTypeHash(5298506180484533559uL)]
	public struct SplinePointOrderData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public ABGKFFJDPAB order;

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xC84900", Offset = "0xC83B00", VA = "0x180C84900")]
		public static SplinePointOrderData NEKLFDMHCNA(ABGKFFJDPAB value)
		{
			return default(SplinePointOrderData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[RecRoom.DataLayer.StableTypeHash(16368389834000856208uL, 0u)]
	[RecRoom.DataLayer.RRGuid("FCEE3BCD-9C10-4BF4-954A-0DCFE8810227")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(16368389834000856208uL)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct SplinePointParentData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public Entity spline;
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[RecRoom.DataLayer.RRGuid("5A6D38A4-1A58-4EB4-9C1B-06ADA0D44AFA")]
	[RecRoom.DataLayer.StableTypeHash(18095612727592564636uL, 0u)]
	[TypeManager.ForcedStableTypeHash(18095612727592564636uL)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[CompilerGenerated]
	public struct SplinePointPositionData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public float3 localPosition;
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("433F66B6-CC1C-4A8A-BF73-2B797440A8DB")]
	[RecRoom.DataLayer.StableTypeHash(1429513518619209486uL, 0u)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(1429513518619209486uL)]
	public struct SplinePointRotationData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default("new quaternion(0, 0, 0, 1f)")]
		public quaternion localRotation;
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.StableTypeHash(1238044349990854547uL, 0u)]
	[TypeManager.ForcedStableTypeHash(1238044349990854547uL)]
	[RecRoom.DataLayer.RRGuid("04CA3CCE-F121-4B5B-BC56-FE8E9C77F0F4")]
	[CompilerGenerated]
	public struct SplinePointScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default("new float3(1)")]
		public float3 localScale;
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[RecRoom.DataLayer.RRGuid("E0610986-0F8F-494A-8C6E-8A2D2491B088")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.StableTypeHash(4657247877648983868uL, 0u)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(4657247877648983868uL)]
	public struct SplineShapeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public BKHKOHIOKMA parameters;
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[TypeManager.ForcedStableTypeHash(12332323170023439017uL)]
	[RecRoom.DataLayer.TombstonedFields(new int[] { 1 })]
	[RecRoom.DataLayer.StableTypeHash(12332323170023439017uL, 0u)]
	[RecRoom.DataLayer.RRGuid("73C344D9-D535-4753-9D9A-B6DEDE4079B0")]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	[CompilerGenerated]
	public struct OMShapeContainerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		[RecRoom.DataLayer.Field(2)]
		[RecRoom.DataLayer.Default(true)]
		public bool canModifyWithCircuits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		[RecRoom.DataLayer.Field(3)]
		[RecRoom.DataLayer.Default(true)]
		public bool optimizedCollidersEnabled;
	}
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[RecRoom.DataLayer.RRGuid("2B5C4208-9113-4F65-B3A6-18EAE1FF3937")]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(17673274643717888315uL)]
	public struct SerializedDataLayerVersionData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public int version;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
[RecRoom.DataLayer.Range(MAEIDCFHPBM.MIN, MAEIDCFHPBM.ALL)]
[Flags]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.RRGuid("CC657074-87FD-47F7-A7B0-F5CCE922A9D0")]
public enum MAEIDCFHPBM
{
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	IsAllowed = 1,
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	UseDefaultVisualEffects = 2,
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	DEFAULT = 2,
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	ALL = 3,
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	MAX = 3
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("34BA53CB-16FB-45DB-AA25-293CE7C8DAE4")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(5328722791392374178uL)]
	public struct ToolCleanupSettingsData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default(15f)]
		public float delay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		[RecRoom.DataLayer.Default(MAEIDCFHPBM.UseDefaultVisualEffects)]
		[RecRoom.DataLayer.Field(2)]
		public MAEIDCFHPBM toolCleanupFlags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[TypeManager.ForcedStableTypeHash(13768238190614302474uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.TombstonedFields(new int[] { 2, 3 })]
	[RecRoom.DataLayer.RRGuid("48C72ABE-383D-45C6-9610-773F2B4F84C6")]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	public struct ToolCleanupStatusData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public float cleanupStartTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(4)]
		public JMKBGDCMHGD statusFlags;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
[RecRoom.DataLayer.Range(JMKBGDCMHGD.None, JMKBGDCMHGD.ALL)]
[RecRoom.DataLayer.RRGuid("E63050BA-D087-4027-99F8-4AFDEA229CD8")]
[Flags]
[RecRoom.DataLayer.NetworkEnum(1, false)]
public enum JMKBGDCMHGD
{
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	ForceCleanup = 1,
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	CleanupDone = 2,
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	CleanupPaused = 4,
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	ALL = 7,
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	MAX = 7
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[RecRoom.DataLayer.RRGuid("021E8703-AAFD-4965-8C38-FF86663126D2")]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(463077377357487319uL)]
	public struct LocalDeformableScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default("new float3(1)")]
		public float3 localDeformationScale;

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0xECBC20", Offset = "0xECAE20", VA = "0x180ECBC20")]
		public LocalDeformableScaleData(float3 scale)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[TypeManager.ForcedStableTypeHash(1369925932270831712uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("38AA9F1D-FD16-4B56-917C-3341D0EB1DF2")]
	[RecRoom.DataLayer.StableTypeHash(1369925932270831712uL, 0u)]
	public struct LocalPoseData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default("new quaternion(0,0,0,1)")]
		public quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		[RecRoom.DataLayer.Field(2)]
		[RecRoom.DataLayer.Default]
		public float3 localPosition;

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x50A7BD0", Offset = "0x50A6DD0", VA = "0x1850A7BD0")]
		public LocalPoseData(quaternion localRotation, float3 localPosition)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x7C425C0", Offset = "0x7C417C0", VA = "0x187C425C0")]
		public static RigidTransform NEKLFDMHCNA(LocalPoseData poseData)
		{
			return default(RigidTransform);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x7C425C0", Offset = "0x7C417C0", VA = "0x187C425C0")]
		public static LocalPoseData NEKLFDMHCNA(RigidTransform pose)
		{
			return default(LocalPoseData);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public static class JEBPOFOIAHK
{
	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x7C43890", Offset = "0x7C42A90", VA = "0x187C43890")]
	public static LocalPoseData LOOHDPHIDHJ([In] this RigidTransform MLCDCHNOCFI)
	{
		return default(LocalPoseData);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x7C43860", Offset = "0x7C42A60", VA = "0x187C43860")]
	public static RigidTransform HMCNONOMHPA([In] this LocalPoseData MLCDCHNOCFI)
	{
		return default(RigidTransform);
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[RecRoom.DataLayer.StableTypeHash(2720902521635056246uL, 0u)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("0E9FADE9-751A-4A53-B455-4F8EA675754D")]
	[TypeManager.ForcedStableTypeHash(2720902521635056246uL)]
	[CompilerGenerated]
	public struct LocalUniformScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		[RecRoom.DataLayer.Default(1f)]
		[RecRoom.DataLayer.Field(1)]
		public float localUniformScale;
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[RecRoom.DataLayer.StableTypeHash(5730545663584378555uL, 0u)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("F01774C0-98E7-491E-AAA5-85B64AFFA182")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(5730545663584378555uL)]
	public struct TransformFlagsData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public AOJHOPOPKNA transformHint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		[RecRoom.DataLayer.Field(2)]
		[RecRoom.DataLayer.Default]
		public EFJIDMBHDAA transformPriority;
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	[RecRoom.DataLayer.DoNotGenerateComponentProperties]
	[CompilerGenerated]
	[RecRoom.DataLayer.RRGuid("392BF0C9-F464-491A-8725-E4B5E5C4ECD4")]
	[TypeManager.ForcedStableTypeHash(12583036596830542024uL)]
	public struct RRObjectPrefabData : ISharedComponentData, IEquatable<RRObjectPrefabData>, IComparable<RRObjectPrefabData>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public OKHKCFDCPLN prefabType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		[RecRoom.DataLayer.Field(2)]
		[RecRoom.DataLayer.Default]
		public Guid prefabGuid;

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x7C45E70", Offset = "0x7C45070", VA = "0x187C45E70")]
		public RRObjectPrefabData(Guid prefabGuid, OKHKCFDCPLN prefabType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x7C45D70", Offset = "0x7C44F70", VA = "0x187C45D70", Slot = "4")]
		public readonly bool Equals(RRObjectPrefabData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x7C45CB0", Offset = "0x7C44EB0", VA = "0x187C45CB0", Slot = "0")]
		public override readonly bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x7C45E80", Offset = "0x7C45080", VA = "0x187C45E80")]
		public static bool operator ==(RRObjectPrefabData a, RRObjectPrefabData b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x7C45920", Offset = "0x7C44B20", VA = "0x187C45920", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x7C45730", Offset = "0x7C44930", VA = "0x187C45730", Slot = "5")]
		public readonly int CompareTo(RRObjectPrefabData other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x7C45DD0", Offset = "0x7C44FD0", VA = "0x187C45DD0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[TypeManager.ForcedStableTypeHash(17550159503907726442uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.RRGuid("FF90B503-A0B5-4B3D-BACF-046FA1456FBD")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct ReferenceGroupKindData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public FKJDPJEKDDH kind;
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("2C78EEBE-6DD9-44FF-A70D-6C2EE9BB8FB3")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(18363292822319307914uL)]
	public struct ReferenceGroupOwnerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public Entity owner;
	}
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("177498E9-83A6-4C2E-A8C1-B1951B47E74D")]
	[TypeManager.ForcedStableTypeHash(11947588904347318594uL)]
	[CompilerGenerated]
	public struct ReferenceGroupReferenceBuffer : IBufferElementData, DBHDPPKALIP, IEquatable<ReferenceGroupReferenceBuffer>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public Entity reference;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public Entity Entity
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xD42150", Offset = "0xD41350", VA = "0x180D42150", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0xEEC790", Offset = "0xEEB990", VA = "0x180EEC790", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x7C45F70", Offset = "0x7C45170", VA = "0x187C45F70", Slot = "6")]
		public bool Equals(ReferenceGroupReferenceBuffer other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x7C45EE0", Offset = "0x7C450E0", VA = "0x187C45EE0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0xA3D0B0", Offset = "0xA3C2B0", VA = "0x180A3D0B0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000071")]
public struct KOBJJLFLEAF : IEqualityComparer<ReferenceGroupReferenceBuffer>
{
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	public static KOBJJLFLEAF EMOEMPAFHHF;

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x7C43D30", Offset = "0x7C42F30", VA = "0x187C43D30", Slot = "4")]
	public bool Equals(ReferenceGroupReferenceBuffer CCOLDGJALNH, ReferenceGroupReferenceBuffer JCBKIOEHCDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0xA70030", Offset = "0xA6F230", VA = "0x180A70030", Slot = "5")]
	public int GetHashCode(ReferenceGroupReferenceBuffer DBCLNEGBNLN)
	{
		return default(int);
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[TypeManager.ForcedStableTypeHash(17466046755328781668uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.RRGuid("DE12A401-BD29-4B00-A629-7EFBECEDCFDF")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[InternalBufferCapacity(0)]
	public struct AuthoredUserTagReferenceBuffer : EKEGHMKBIAL, IBufferElementData, DBHDPPKALIP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public Entity Child;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0xD42150", Offset = "0xD41350", VA = "0x180D42150", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0xEEC790", Offset = "0xEEB990", VA = "0x180EEC790", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0xEEC790", Offset = "0xEEB990", VA = "0x180EEC790")]
		public AuthoredUserTagReferenceBuffer(Entity entity)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0xC84900", Offset = "0xC83B00", VA = "0x180C84900")]
		public static AuthoredUserTagReferenceBuffer NEKLFDMHCNA(Entity entity)
		{
			return default(AuthoredUserTagReferenceBuffer);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public interface EKEGHMKBIAL : IBufferElementData, DBHDPPKALIP
{
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	[RecRoom.DataLayer.RRGuid("00B7CB5E-4C0C-4D2C-AC95-78529EE58768")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(12148147190301245780uL)]
	public struct PersistentUserTagData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public FixedList32Bytes<int> tags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		[RecRoom.DataLayer.Default(false)]
		[RecRoom.DataLayer.Field(2)]
		public bool initalizedDefaults;
	}
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	[TypeManager.ForcedStableTypeHash(1859693175312uL)]
	[RecRoom.DataLayer.StableTypeHash(1859693175312uL, 0u)]
	[CompilerGenerated]
	[SwatchPrimaryKey]
	[RecRoom.DataLayer.RRGuid("80D85A55-B2F6-4860-A851-62973DC10940")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct UserTagNameData : IComponentData, IEquatable<UserTagNameData>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public FixedString32Bytes Value;

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x7C460B0", Offset = "0x7C452B0", VA = "0x187C460B0")]
		public UserTagNameData(string value)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x7C46070", Offset = "0x7C45270", VA = "0x187C46070")]
		public static UserTagNameData NEKLFDMHCNA(string value)
		{
			return default(UserTagNameData);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x7C45F90", Offset = "0x7C45190", VA = "0x187C45F90", Slot = "4")]
		public bool Equals(UserTagNameData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x7C45FC0", Offset = "0x7C451C0", VA = "0x187C45FC0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x7C46060", Offset = "0x7C45260", VA = "0x187C46060", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[TypeManager.ForcedStableTypeHash(2039749658960193818uL)]
	[InternalBufferCapacity(0)]
	[RecRoom.DataLayer.RRGuid("1E609F72-38C4-433D-BB17-B718F89DF446")]
	[CompilerGenerated]
	[RuntimeOnly]
	public struct UserTagReferenceBuffer : EKEGHMKBIAL, IBufferElementData, DBHDPPKALIP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public Entity Child;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0xD42150", Offset = "0xD41350", VA = "0x180D42150", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0xEEC790", Offset = "0xEEB990", VA = "0x180EEC790", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0xEEC790", Offset = "0xEEB990", VA = "0x180EEC790")]
		public UserTagReferenceBuffer(Entity entity)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0xC84900", Offset = "0xC83B00", VA = "0x180C84900")]
		public static UserTagReferenceBuffer NEKLFDMHCNA(Entity entity)
		{
			return default(UserTagReferenceBuffer);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[ConfigGroup("Visual", 0)]
	[TypeManager.ForcedStableTypeHash(1591066774816564574uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.RRGuid("C36DDF08-CA52-4E33-8078-2F6E915D4FDA")]
	[RecRoom.DataLayer.StableTypeHash(1591066774816564574uL, 0u)]
	[CanDesync]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct StandardRenderableVisualData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		[RecRoom.DataLayer.Field(1)]
		[Config(null, 0)]
		[RecRoom.DataLayer.Default]
		public KFBMHGEEILN color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		[Config(null, 0)]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(2)]
		public JMMJHJPMGML material;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		[RecRoom.DataLayer.Field(3)]
		[Config(null, 0)]
		[RecRoom.DataLayer.Default]
		public float uvScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		[RecRoom.DataLayer.Field(4)]
		[Config(null, 0)]
		[RecRoom.DataLayer.Default]
		public float3 uvOffset;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.RRGuid("6B598497-D68A-4CC9-9D41-09EF6B966499")]
[RecRoom.DataLayer.Range(LEFIJBDKMMH.NONE, LEFIJBDKMMH.COUNT)]
public enum LEFIJBDKMMH
{
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	NONE = 0,
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	[Config("Default (can transform roots, children are static)", 0)]
	Default = 1,
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	[Config("Can Transform (chips like SetPosition can modify)", 0)]
	CircuitsCanTransform = 2,
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	[Config("Always Static (chips cannot modify transform)", 0)]
	AlwaysStatic = 3,
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	COUNT = 4,
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	MAX = 4
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.RRGuid("17517E1A-CF1A-48C9-B6A5-F9E42C1B9E96")]
[RecRoom.DataLayer.Range(0, 4)]
public enum HDJHPOLEBEA
{
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	Box = 1,
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	Sphere = 2,
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	Capsule = 3,
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	Mesh = 4,
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	COUNT = 5,
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	MAX = 4
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
[Flags]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.RRGuid("A13F5102-9259-42B9-B782-BB7CC33A0C4F")]
[RecRoom.DataLayer.Range(BGOMAEDNPDC.NONE, BGOMAEDNPDC.ALL)]
public enum BGOMAEDNPDC
{
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	NONE = 0,
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	Object = 1,
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	Player = 2,
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	Projectile = 4,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	Vehicle = 8,
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	ALL = 0xF
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
[RecRoom.DataLayer.NetworkEnum(2, false)]
[RecRoom.DataLayer.RRGuid("F843A776-E042-43B7-8167-0C7A421062F8")]
[RecRoom.DataLayer.Range(0, 127)]
public enum LFONANDBLOB : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	[@Tooltip("Indicating it can be walked on and moved")]
	[Config("Dynamic (Environment)", 0)]
	IsDynamicEnvironment = 0,
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	[Config("Dynamic", -1)]
	IsDynamic = 10,
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	[Config("Dynamic (Ignore Static Geometry)", 0)]
	IsDynamicIgnoreStaticGeometry = 11,
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	[Config("Dynamic (Ignore Other Dynamic)", 0)]
	IsDynamicIgnoreOtherDynamic = 12,
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	[Config("Dynamic (Ignore Players)", 0)]
	IsDynamicIgnorePlayers = 13,
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	[Config("Dynamic (Ignore Most)", 0)]
	IsDynamicIgnoreMost = 14,
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	[Config("Enemy Collision", 0)]
	IsEnemyCollision = 30,
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	[Config("Enemy Projectile", 0)]
	IsEnemyProjectile = 31,
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	[Config("Vehicle Physics", 0)]
	IsVehicleCollision = 40,
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	[ConfigIgnore]
	STATIC = 100,
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	[ConfigIgnore]
	DECORATION = 101,
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	MAX = 127
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
[RecRoom.DataLayer.RRGuid("9ADF7A0D-D808-48A7-BFCB-3272FB5D8A52")]
[RecRoom.DataLayer.NetworkEnum(2, false)]
[RecRoom.DataLayer.Range(CLCCGGMNJHK.Off, CLCCGGMNJHK.COUNT)]
public enum CLCCGGMNJHK : byte
{
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	Off = 0,
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	Children = 1,
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	Hull = 2,
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	COUNT = 3,
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	MAX = 2
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.RRGuid("3B156405-5769-4DB2-87EA-2B846AC4E584")]
[RecRoom.DataLayer.Range(0, 2)]
public enum NGNNDBBMKGO
{
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	Primitive = 1,
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	Spline = 2,
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	COUNT = 3,
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	MAX = 2
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[RecRoom.DataLayer.Range(EBPGAOAANLG.Pivot, EBPGAOAANLG.COUNT)]
[RecRoom.DataLayer.RRGuid("61EFE94A-235A-4281-B938-1A5BE32A18B1")]
[RecRoom.DataLayer.NetworkEnum(2, false)]
public enum EBPGAOAANLG : byte
{
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	Pivot = 0,
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	Bounds = 1,
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	COUNT = 2,
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	MAX = 1
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
[RecRoom.DataLayer.Range(OOJGIMJMHJA.EnabledForRole, OOJGIMJMHJA.Disabled)]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.RRGuid("c0973732-e735-44cd-9727-a9a79bad01e3")]
public enum OOJGIMJMHJA : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	EnabledForRole,
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	DisabledForRole,
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	Disabled
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
[RecRoom.DataLayer.Range(INHFKGENNEJ.NavMeshGenerator, INHFKGENNEJ.NavMeshBlocker)]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.RRGuid("7E7D5AA1-2EC9-488B-8AB2-703F13BCB8CF")]
public enum INHFKGENNEJ
{
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	NavMeshGenerator = 0,
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	NavMeshIgnored = 1,
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	NavMeshBlocker = 2,
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	MAX = 2
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.RRGuid("7B493897-FE06-4FC8-AB72-8B7BF5A313D3")]
[RecRoom.DataLayer.Range(PKDAAPODPAF.None, PKDAAPODPAF.All)]
[Flags]
public enum PKDAAPODPAF
{
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	All = 0x3FFF,
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	Default = 0x3FFF
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
[RecRoom.DataLayer.RRGuid("4427686F-E636-4F43-91F7-6BC74DEC584E")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.Range(0, HBDBNMDAFGA.COUNT)]
public enum HBDBNMDAFGA
{
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	SupportsRotation,
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	SupportsDeformation,
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	SupportsScaling,
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	SupportsMirroring,
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	SupportsCloning,
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	SupportsRecoloring,
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	CanDestroy,
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	CanSaveIntoInventions,
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	SupportsRespawn,
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	SupportsMerging,
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	SupportsSplitting,
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	SupportsKeys,
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	CanEditWithMakerPen,
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	DEPRECATED_IsGrabbable,
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public static class BHIEBHIGIHF
{
	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x7C42650", Offset = "0x7C41850", VA = "0x187C42650")]
	public static void DENBCCCLIHH(this PKDAAPODPAF MJJLCGKEEJD, HBDBNMDAFGA OEGOKAIDMHG, bool BMBINDLKLHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x7C42680", Offset = "0x7C41880", VA = "0x187C42680")]
	public static bool OHKMJOKCAAG(this PKDAAPODPAF MJJLCGKEEJD, HBDBNMDAFGA OEGOKAIDMHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0xDB6150", Offset = "0xDB5350", VA = "0x180DB6150")]
	public static PKDAAPODPAF HDAHHJDGLBM(this HBDBNMDAFGA OEGOKAIDMHG)
	{
		return default(PKDAAPODPAF);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
[RecRoom.DataLayer.Range(KHFPIIIDCNJ.NONE, KHFPIIIDCNJ.COUNT)]
[Flags]
[RecRoom.DataLayer.NetworkEnum(2, false)]
[RecRoom.DataLayer.RRGuid("E3C51303-32F0-4EF4-8A66-C814E323653D")]
public enum KHFPIIIDCNJ
{
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	NONE = 0,
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	IsFrozen = 1,
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	IsGrabbable = 2,
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	COUNT = 3,
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	ALL = 3,
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	DEFAULT = 0
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.RRGuid("777AD204-3AC0-41CE-BDC0-894C5821B3B9")]
[RecRoom.DataLayer.Range(OKHKCFDCPLN.None, 8000)]
public enum OKHKCFDCPLN
{
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	[Config("Container", 0)]
	Container = 1000,
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	[Config("Container", 0)]
	LegacyShapeContainer = 1001,
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	[Config("Container", 0)]
	CreationShapeContainer = 1002,
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	[Config("Container", 0)]
	CostumePieceShapeContainer = 1003,
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	[Config("Empty", 0)]
	Empty = 4000,
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	[Config("Legacy Box", 0)]
	Shape_Primitive_LegacyBox = 2000,
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	[Config("Sphere", 0)]
	Shape_Primitive_Sphere = 2001,
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	[Config("Cylinder", 0)]
	Shape_Primitive_Cylinder = 2002,
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	[Config("Legacy Wedge", 0)]
	Shape_Primitive_LegacyWedge = 2003,
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	[Config("Legacy Pyramid", 0)]
	Shape_Primitive_LegacyPyramid = 2004,
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	[Config("Trigger Volume Box", 0)]
	Shape_Primitive_TriggerVolumeBox = 2005,
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	[Config("Box", 0)]
	Shape_Primitive_Box = 2006,
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	[Config("Rounded Box", 0)]
	Shape_Primitive_RoundedBox = 2007,
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	[Config("Wedge", 0)]
	Shape_Primitive_Wedge = 2008,
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	[Config("Pyramid", 0)]
	Shape_Primitive_Pyramid = 2009,
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	[Config("Half Sphere", 0)]
	Shape_Primitive_HalfSphere = 2010,
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	[Config("Cone", 0)]
	Shape_Primitive_Cone = 2011,
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	[Config("Pipe", 0)]
	Shape_Primitive_Pipe = 2012,
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	[Config("Donut", 0)]
	Shape_Primitive_Donut = 2013,
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	[Config("Half Pipe", 0)]
	Shape_Primitive_HalfPipe = 2014,
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	[Config("Diamond", 0)]
	Shape_Primitive_Diamond = 2015,
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	[Config("Mound", 0)]
	Shape_Primitive_Mound = 2016,
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	[Config("Cube (Simple)", 0)]
	Shape_Primitive_ADVANCED_Cube = 2017,
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	[Config("Sphere (Simple)", 0)]
	Shape_Primitive_ADVANCED_Sphere = 2018,
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	[Config("Cylinder (Simple)", 0)]
	Shape_Primitive_ADVANCED_Cylinder = 2019,
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	[Config("Cone (Simple)", 0)]
	Shape_Primitive_ADVANCED_Cone = 2020,
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	[Config("Pyramid (Simple)", 0)]
	Shape_Primitive_ADVANCED_Pyramid = 2021,
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	[Config("Octagon (Simple)", 0)]
	Shape_Primitive_ADVANCED_Octagon = 2022,
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	[Config("Triangle (Simple)", 0)]
	Shape_Primitive_ADVANCED_Triangle = 2023,
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	[Config("Hexagon (Simple)", 0)]
	Shape_Primitive_ADVANCED_Hexagon = 2024,
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	[Config("Quarter Pipe", 0)]
	Shape_Primitive_ADVANCED_QuarterPipe = 2025,
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	[Config("Pentagon (Simple)", 0)]
	Shape_Primitive_ADVANCED_Pentagon = 2026,
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	[Config("Dodecahedron", 0)]
	Shape_Primitive_ADVANCED_Dodecahedron = 2027,
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	[Config("Icosahedron", 0)]
	Shape_Primitive_ADVANCED_Trihedron = 2028,
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	[Config("Octahedron", 0)]
	Shape_Primitive_ADVANCED_Octahedron = 2029,
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	[Config("Quarter Cylinder", 0)]
	Shape_Primitive_RR_QuarterCylinder = 2030,
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	[Config("Pentagon", 0)]
	Shape_Primitive_RR_Pentagon = 2031,
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	[Config("Quarter Sphere", 0)]
	Shape_Primitive_RR_QuarterSphere = 2032,
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	[Config("Wedge (Simple)", 0)]
	Shape_Primitive_ADVANCED_Wedge = 2033,
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	[Config("Hexagon", 0)]
	Shape_Primitive_RR_Hexagon = 2034,
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	[Config("Octagon", 0)]
	Shape_Primitive_RR_Octagon = 2035,
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	[Config("Triangle", 0)]
	Shape_Primitive_RR_Triangle = 2036,
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	[Config("Spline", 0)]
	Shape_Spline = 3000,
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	[Config("Container Pivot", 0)]
	Other_ContainerPivot = 6000,
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	[Config("Spine Point", 0)]
	Other_SplinePoint = 6001,
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	[Config("Reference Point", 0)]
	Other_ReferencePoint = 6002,
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	[Config("UserTags", 0)]
	Other_UserTag = 6003,
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	[Config("Reference Group", 0)]
	Other_ReferenceGroup = 6004,
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	[Config("Interaction Filter", 0)]
	Other_InteractionFilterTags = 6005,
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	[ConfigIgnore]
	Other_DesyncNetworkObject = 6006,
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	[ConfigIgnore]
	UNUSED2 = 5000,
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	[Config("Object", 0)]
	PrefabRootGameObject = 7000,
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	[Config("PrefabInternal", 0)]
	PrefabInternalGameObject = 7001,
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	[Config("Player", 0)]
	Player = 8000
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public static class IDAHLOHDKNH
{
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	[CompilerGenerated]
	private sealed class KINHHMFBABL : IEnumerable<OKHKCFDCPLN>, IEnumerable, IEnumerator<OKHKCFDCPLN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		private OKHKCFDCPLN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		private IEnumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		private OKHKCFDCPLN System.Collections.Generic.IEnumerator<RecRoom.DataLayer.ObjectPrefabType>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0xB834E0", Offset = "0xB826E0", VA = "0x180B834E0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(OKHKCFDCPLN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x7C43C80", Offset = "0x7C42E80", VA = "0x187C43C80", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x12ABCE0", Offset = "0x12AAEE0", VA = "0x1812ABCE0")]
		[DebuggerHidden]
		public KINHHMFBABL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x7C43CD0", Offset = "0x7C42ED0", VA = "0x187C43CD0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x7C43920", Offset = "0x7C42B20", VA = "0x187C43920", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x7C438C0", Offset = "0x7C42AC0", VA = "0x187C438C0")]
		private void CKKMGPGLJAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x7C43C30", Offset = "0x7C42E30", VA = "0x187C43C30", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x7C43B90", Offset = "0x7C42D90", VA = "0x187C43B90", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<OKHKCFDCPLN> System.Collections.Generic.IEnumerable<RecRoom.DataLayer.ObjectPrefabType>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x7C43B90", Offset = "0x7C42D90", VA = "0x187C43B90", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000088")]
	[CompilerGenerated]
	private sealed class NIGEKMNJAAA : IEnumerable<OKHKCFDCPLN>, IEnumerable, IEnumerator<OKHKCFDCPLN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		private OKHKCFDCPLN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		private OKHKCFDCPLN <last>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private OKHKCFDCPLN <i>5__3;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		private OKHKCFDCPLN System.Collections.Generic.IEnumerator<RecRoom.DataLayer.ObjectPrefabType>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0xB834E0", Offset = "0xB826E0", VA = "0x180B834E0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(OKHKCFDCPLN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x7C45080", Offset = "0x7C44280", VA = "0x187C45080", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x12ABCE0", Offset = "0x12AAEE0", VA = "0x1812ABCE0")]
		[DebuggerHidden]
		public NIGEKMNJAAA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x7C44F30", Offset = "0x7C44130", VA = "0x187C44F30", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x7C45030", Offset = "0x7C44230", VA = "0x187C45030", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x7C44F90", Offset = "0x7C44190", VA = "0x187C44F90", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<OKHKCFDCPLN> System.Collections.Generic.IEnumerable<RecRoom.DataLayer.ObjectPrefabType>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x7C44F90", Offset = "0x7C44190", VA = "0x187C44F90", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000089")]
	[CompilerGenerated]
	private sealed class NGENPCIHHJL : IEnumerable<OKHKCFDCPLN>, IEnumerable, IEnumerator<OKHKCFDCPLN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		private OKHKCFDCPLN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		private IEnumerator<OKHKCFDCPLN> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		private OKHKCFDCPLN System.Collections.Generic.IEnumerator<RecRoom.DataLayer.ObjectPrefabType>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0xB834E0", Offset = "0xB826E0", VA = "0x180B834E0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(OKHKCFDCPLN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x7C44B90", Offset = "0x7C43D90", VA = "0x187C44B90", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x12ABCE0", Offset = "0x12AAEE0", VA = "0x1812ABCE0")]
		[DebuggerHidden]
		public NGENPCIHHJL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x7C44BE0", Offset = "0x7C43DE0", VA = "0x187C44BE0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x7C44800", Offset = "0x7C43A00", VA = "0x187C44800", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x7C447B0", Offset = "0x7C439B0", VA = "0x187C447B0")]
		private void CKKMGPGLJAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x7C44B40", Offset = "0x7C43D40", VA = "0x187C44B40", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x7C44AA0", Offset = "0x7C43CA0", VA = "0x187C44AA0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<OKHKCFDCPLN> System.Collections.Generic.IEnumerable<RecRoom.DataLayer.ObjectPrefabType>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x7C44AA0", Offset = "0x7C43CA0", VA = "0x187C44AA0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x7C43660", Offset = "0x7C42860", VA = "0x187C43660")]
	[IteratorStateMachine(typeof(KINHHMFBABL))]
	public static IEnumerable<OKHKCFDCPLN> IOJAMGLDIBA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x7C43600", Offset = "0x7C42800", VA = "0x187C43600")]
	[IteratorStateMachine(typeof(NIGEKMNJAAA))]
	public static IEnumerable<OKHKCFDCPLN> BAELADENDLA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x7C436C0", Offset = "0x7C428C0", VA = "0x187C436C0")]
	[IteratorStateMachine(typeof(NGENPCIHHJL))]
	public static IEnumerable<OKHKCFDCPLN> JPJBCFEALLA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public static class OAIKBEHEMPP
{
	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x7C45700", Offset = "0x7C44900", VA = "0x187C45700")]
	public static bool PHHIGFLIIHA(this RRObjectPrefabData CKBDDAGAOEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x7C456D0", Offset = "0x7C448D0", VA = "0x187C456D0")]
	public static bool PHHIGFLIIHA(this OKHKCFDCPLN EDLOHJEBKFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x7C45670", Offset = "0x7C44870", VA = "0x187C45670")]
	public static bool KAMMNMADFLE(this RRObjectPrefabData CKBDDAGAOEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x7C456A0", Offset = "0x7C448A0", VA = "0x187C456A0")]
	public static bool KAMMNMADFLE(this OKHKCFDCPLN EDLOHJEBKFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x7C45620", Offset = "0x7C44820", VA = "0x187C45620")]
	public static IANOFDJKDKE CEIMCNAOJGH(this OKHKCFDCPLN ONDECPHMAJI)
	{
		return default(IANOFDJKDKE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x7C45660", Offset = "0x7C44860", VA = "0x187C45660")]
	internal static FCMJLDMNPBH ELFGIIAGDOH(this IANOFDJKDKE ODHJIEMHPHD)
	{
		return default(FCMJLDMNPBH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x7C45640", Offset = "0x7C44840", VA = "0x187C45640")]
	internal static FCMJLDMNPBH ELFGIIAGDOH(this OKHKCFDCPLN ONDECPHMAJI)
	{
		return default(FCMJLDMNPBH);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
internal enum FCMJLDMNPBH
{
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	Container = 1000,
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	Empty = 4000,
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	Primitive = 2000,
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	Spline = 3000,
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	Other = 6000,
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	UNUSED2 = 5000,
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	GameObject = 7000,
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	Player = 8000
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.RRGuid("A32413BC-21F3-4F7C-84B0-37724A854A67")]
[RecRoom.DataLayer.Range(0, 8)]
public enum IANOFDJKDKE
{
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	Container,
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	Primitive,
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	Spline,
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	Empty,
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	UNUSED2,
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	Other,
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	GameObject,
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	Player
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public static class KPEBDIEPMGN
{
	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x7C43D50", Offset = "0x7C42F50", VA = "0x187C43D50")]
	public static bool JEMNBPFMDJD(this IANOFDJKDKE ODHJIEMHPHD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
[RecRoom.DataLayer.NetworkEnum(3, false)]
[RecRoom.DataLayer.RRGuid("7A0D34B5-FFE5-4C21-BB0C-CB3EBA34C797")]
[Flags]
[RecRoom.DataLayer.Range(0, PFDCBFKJOFO.ALL)]
public enum PFDCBFKJOFO : ushort
{
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	NONE = 0,
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	PhysicsEnabled = 1,
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	GravityEnabled = 2,
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	HasCustomMass = 4,
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	CollisionEvent = 0x40,
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	CanUse = 0x200,
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	CanClimb = 0x400,
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	CanWallRun = 0x800,
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	CanClamber = 0x1000,
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	CanTeleport = 0x2000,
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	SuppressCollision = 0x4000,
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	DEFAULT = 0x3800,
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	ALL = 0x7E47,
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	MAX = 0x7E47
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.StableTypeHash(8060729269509364919uL, 0u)]
	[RecRoom.DataLayer.RRGuid("5D4503E7-6CC4-4938-8840-1B859C391878")]
	[TypeManager.ForcedStableTypeHash(8060729269509364919uL)]
	public struct PrimitiveShapeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public JNBMIBPKCDD shapeType;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
[RecRoom.DataLayer.Range(-1, 38)]
[RecRoom.DataLayer.RRGuid("517224CC-0A79-4FE9-B048-53C37955D823")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
public enum JNBMIBPKCDD
{
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	LegacyBox = 2,
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	RR_Sphere = 3,
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	RR_Cylinder = 4,
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	LEGACY_Wedge = 5,
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	LEGACY_Pyramid = 6,
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	LEGACY_TriggerVolumeBox = 7,
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	RR_Box = 8,
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	LEGACY_RoundedBox = 9,
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	RR_Wedge = 10,
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	RR_Pyramid = 11,
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	RR_HalfSphere = 12,
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	RR_Cone = 13,
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	RR_Pipe = 14,
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	RR_Donut = 15,
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	RR_HalfPipe = 16,
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	RR_Diamond = 17,
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	ADVANCED_Mound = 18,
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	ADVANCED_Cube = 19,
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	ADVANCED_Sphere = 20,
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	ADVANCED_Cylinder = 21,
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	ADVANCED_Cone = 22,
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	ADVANCED_Pyramid = 23,
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	ADVANCED_Octagon = 24,
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	ADVANCED_Triangle = 25,
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	ADVANCED_Hexagon = 26,
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	ADVANCED_QuarterPipe = 27,
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	ADVANCED_Pentagon = 28,
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	ADVANCED_Dodecahedron = 29,
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	ADVANCED_Trihedron = 30,
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	ADVANCED_Octahedron = 31,
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	RR_QuarterCylinder = 32,
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	RR_Pentagon = 33,
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	RR_QuarterSphere = 34,
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	ADVANCED_Wedge = 35,
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	RR_Hexagon = 36,
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	RR_Octagon = 37,
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	RR_Triangle = 38,
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	COUNT = 39,
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	MIN_VALUE = -1,
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	MAX_VALUE = 38
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
[RecRoom.DataLayer.Range(FKJDPJEKDDH.None, FKJDPJEKDDH.COUNT)]
[RecRoom.DataLayer.RRGuid("3D27DF09-CAE2-4C3F-B808-03AD605F8E98")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
public enum FKJDPJEKDDH : byte
{
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	AnimationGroup = 1,
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	COUNT = 2,
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	MAX = 2
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
[RecRoom.DataLayer.Range(0, 7)]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[Flags]
[RecRoom.DataLayer.RRGuid("1829B7EA-C0EA-4E77-8EB2-BA23E995C860")]
public enum OMNIHJEOLPK
{
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	DynamicUVProjection = 1,
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	PreventInvertedCreation = 2,
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	NewBendLogic = 4,
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	All = 7,
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	MAX = 7
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
[RecRoom.DataLayer.RRGuid("CCB58F66-EF02-476E-820F-9D593E2C3DE5")]
[RecRoom.DataLayer.Range(0, 7)]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[Flags]
public enum MPABIJINPFE
{
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	IsRibbon = 1,
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	RoundedTubes = 2,
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	OldStyleCaps = 4,
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	All = 7,
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	MAX = 7
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
[RecRoom.DataLayer.Range(0, 1)]
[RecRoom.DataLayer.RRGuid("72742F9B-D48E-4CED-B403-444201FFEE66")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[Flags]
public enum AOJHOPOPKNA
{
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	Static = 0,
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	Dynamic = 1,
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	All = 1
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
[RecRoom.DataLayer.Range(-2, 2)]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.RRGuid("C5BE1CDA-5EF5-4EBF-BC7E-3E3510C68A7F")]
public enum EFJIDMBHDAA
{
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	Frozen = -2,
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	Low = -1,
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	Normal = 0,
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	High = 1,
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	Realtime = 2,
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	Default = 0,
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	MIN = -2,
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	MAX = 2
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
[RecRoom.DataLayer.RRGuid("D6AFAFED-8BAA-4499-9696-9CBB716EF514")]
[RecRoom.DataLayer.Range(int.MinValue, int.MaxValue)]
[RecRoom.DataLayer.NetworkEnum(1, false)]
public enum KFBMHGEEILN
{
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	Red = 0,
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	Orange = 1,
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	Yellow = 2,
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	LightGreen = 3,
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	Blue = 4,
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	LightBlue = 5,
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	Teal = 6,
	[Cpp2IlInjected.Token(Token = "0x4000207")]
	Green = 7,
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	Purple = 8,
	[Cpp2IlInjected.Token(Token = "0x4000209")]
	LightPink = 9,
	[Cpp2IlInjected.Token(Token = "0x400020A")]
	Pink = 10,
	[Cpp2IlInjected.Token(Token = "0x400020B")]
	Brown = 11,
	[Cpp2IlInjected.Token(Token = "0x400020C")]
	Tan = 12,
	[Cpp2IlInjected.Token(Token = "0x400020D")]
	White = 13,
	[Cpp2IlInjected.Token(Token = "0x400020E")]
	Grey = 14,
	[Cpp2IlInjected.Token(Token = "0x400020F")]
	DarkGrey = 15,
	[Cpp2IlInjected.Token(Token = "0x4000210")]
	DarkBrown = 16,
	[Cpp2IlInjected.Token(Token = "0x4000211")]
	LightBrown = 17,
	[Cpp2IlInjected.Token(Token = "0x4000212")]
	LightGrey = 18,
	[Cpp2IlInjected.Token(Token = "0x4000213")]
	Black = 19,
	[Cpp2IlInjected.Token(Token = "0x4000214")]
	DarkRed = 20,
	[Cpp2IlInjected.Token(Token = "0x4000215")]
	DarkOrange = 21,
	[Cpp2IlInjected.Token(Token = "0x4000216")]
	DarkYellow = 22,
	[Cpp2IlInjected.Token(Token = "0x4000217")]
	DarkGreen = 23,
	[Cpp2IlInjected.Token(Token = "0x4000218")]
	DarkTeal = 24,
	[Cpp2IlInjected.Token(Token = "0x4000219")]
	DarkBlue = 25,
	[Cpp2IlInjected.Token(Token = "0x400021A")]
	DarkPurple = 26,
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	DarkPink = 27,
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	LightRed = 28,
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	LightOrange = 29,
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	LightYellow = 30,
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	Cyan = 31,
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	LightPurple = 32,
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	DarkTan = 33,
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	NewColor1 = 34,
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	NewColor2 = 35,
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	NewColor3 = 36,
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	NewColor4 = 37,
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	NewColor5 = 38,
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	NewColor6 = 39,
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	NewColor7 = 40,
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	NewColor8 = 41,
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	NewColor9 = 42,
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	NewColor10 = 43,
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	NewColor11 = 44,
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	NewColor12 = 45,
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	NewColor13 = 46,
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	NewColor14 = 47,
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	NewColor15 = 48,
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	NewColor16 = 49,
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	NewColor17 = 50,
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	NewColor18 = 51,
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	NewColor19 = 52,
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	NewColor20 = 53,
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	NewColor21 = 54,
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	NewColor22 = 55,
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	NewColor23 = 56,
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	NewColor24 = 57,
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	NewColor25 = 58,
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	NewColor26 = 59,
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	NewColor27 = 60,
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	Default = 0
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
[RecRoom.DataLayer.Range(-1, 31)]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.RRGuid("C57BE511-BA1A-4D83-BA58-303F34F4DE74")]
public enum JMMJHJPMGML
{
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	Cardboard = 0,
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	Neon = 1,
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	Brick = 2,
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	Carpet = 3,
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	Dirt = 4,
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	Grass = 5,
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	MetalReflective = 6,
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	Concrete = 7,
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	Linoleum = 8,
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	Plaster = 9,
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	WoodLogs = 10,
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	WoodBoards = 11,
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	WoodGrain = 12,
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	WoodFloor = 13,
	[Cpp2IlInjected.Token(Token = "0x400024E")]
	Sand = 14,
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	GlossyPlastic = 15,
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	Cloth = 16,
	[Cpp2IlInjected.Token(Token = "0x4000251")]
	RubberFloor = 17,
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	MetalFloorTread = 18,
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	PaintedBrick = 19,
	[Cpp2IlInjected.Token(Token = "0x4000254")]
	Crashpad = 20,
	[Cpp2IlInjected.Token(Token = "0x4000255")]
	PaintedWood = 21,
	[Cpp2IlInjected.Token(Token = "0x4000256")]
	GripTape = 22,
	[Cpp2IlInjected.Token(Token = "0x4000257")]
	GalvanizedMetal = 23,
	[Cpp2IlInjected.Token(Token = "0x4000258")]
	ParticleBoard = 24,
	[Cpp2IlInjected.Token(Token = "0x4000259")]
	CheckeredFloor = 25,
	[Cpp2IlInjected.Token(Token = "0x400025A")]
	SparklyVinyl = 26,
	[Cpp2IlInjected.Token(Token = "0x400025B")]
	Gravel = 27,
	[Cpp2IlInjected.Token(Token = "0x400025C")]
	Rock = 28,
	[Cpp2IlInjected.Token(Token = "0x400025D")]
	Placeholder29 = 29,
	[Cpp2IlInjected.Token(Token = "0x400025E")]
	Placeholder30 = 30,
	[Cpp2IlInjected.Token(Token = "0x400025F")]
	Placeholder31 = 31,
	[Cpp2IlInjected.Token(Token = "0x4000260")]
	COUNT = 32,
	[Cpp2IlInjected.Token(Token = "0x4000261")]
	MIN = -1,
	[Cpp2IlInjected.Token(Token = "0x4000262")]
	MAX = 31,
	[Cpp2IlInjected.Token(Token = "0x4000263")]
	Default = 0
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
[RecRoom.DataLayer.RRGuid("B23E7E5C-828C-4A29-9AB2-774DFC53D18E")]
[RecRoom.DataLayer.NetworkInterface(1, false)]
public interface FIKKFDFMCLG : JPNFLMLFIPK
{
	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	[RecRoom.DataLayer.Default]
	[Set.Auth]
	[RecRoom.DataLayer.Key("SBDScale")]
	[ProtoProp("PersistenceViewData.SandboxDeformationData.Deformation", typeof(HMALLMOHPCA))]
	[RecRoom.DataLayer.Field(1)]
	float3 MKNJDDMDEKH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action PBAMLJMJNMO;
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
[RecRoom.DataLayer.RRGuid("112F004A-C92F-4055-99F9-D430EC13FE3C")]
[RecRoom.DataLayer.NetworkStruct(1, false)]
public struct ABGKFFJDPAB : IComparable<ABGKFFJDPAB>, IEquatable<ABGKFFJDPAB>
{
	[Cpp2IlInjected.Token(Token = "0x4000264")]
	public static readonly ABGKFFJDPAB MLINAHCDIHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000265")]
	[RecRoom.DataLayer.Field(1)]
	public uint FMBKCFHKMPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000266")]
	[RecRoom.DataLayer.Field(2)]
	public uint EFAJGAEJLEB;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	private readonly uint FIALGHCHAJC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x7C41F00", Offset = "0x7C41100", VA = "0x187C41F00")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public readonly bool KJALJJOFOOG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x7C41BE0", Offset = "0x7C40DE0", VA = "0x187C41BE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x7C42230", Offset = "0x7C41430", VA = "0x187C42230")]
	public ABGKFFJDPAB(int FMBKCFHKMPM, int BKONMGHGPMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x7C42230", Offset = "0x7C41430", VA = "0x187C42230")]
	public ABGKFFJDPAB(uint FMBKCFHKMPM, uint BKONMGHGPMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x7C42290", Offset = "0x7C41490", VA = "0x187C42290")]
	private ABGKFFJDPAB(uint FMBKCFHKMPM, uint BKONMGHGPMC, bool HBNFBKBLMCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x7C420A0", Offset = "0x7C412A0", VA = "0x187C420A0")]
	public ABGKFFJDPAB ICDFFCNNPDO(int OEBFFKLMAPN = 1)
	{
		return default(ABGKFFJDPAB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x7C41FE0", Offset = "0x7C411E0", VA = "0x187C41FE0")]
	public ABGKFFJDPAB FHBIEIAMJEH(int OEBFFKLMAPN = 1)
	{
		return default(ABGKFFJDPAB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x7C41C10", Offset = "0x7C40E10", VA = "0x187C41C10")]
	public static ABGKFFJDPAB DJCJIDACIMF(ABGKFFJDPAB MHEJPNNFCGC, ABGKFFJDPAB BGMAPCGDHFK)
	{
		return default(ABGKFFJDPAB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x7C41BA0", Offset = "0x7C40DA0", VA = "0x187C41BA0")]
	private static ulong BMFNEBFDICA(ulong FCKEKMKDGOB, ulong PMDPDEMGJJE)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x7C41BF0", Offset = "0x7C40DF0", VA = "0x187C41BF0", Slot = "4")]
	public int CompareTo(ABGKFFJDPAB FNJGMJGALLH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x7C41F50", Offset = "0x7C41150", VA = "0x187C41F50", Slot = "0")]
	public override bool Equals(object DBCLNEGBNLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x7C42150", Offset = "0x7C41350", VA = "0x187C42150", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x7C41F30", Offset = "0x7C41130", VA = "0x187C41F30", Slot = "5")]
	public bool Equals(ABGKFFJDPAB FNJGMJGALLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x7C42050", Offset = "0x7C41250", VA = "0x187C42050", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x3620750", Offset = "0x361F950", VA = "0x183620750")]
	public static bool NDBPPCEOMJH(ABGKFFJDPAB MHEJPNNFCGC, ABGKFFJDPAB BGMAPCGDHFK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x7C41F10", Offset = "0x7C41110", VA = "0x187C41F10")]
	public static bool EFJOOJHLAGB(ABGKFFJDPAB MHEJPNNFCGC, ABGKFFJDPAB BGMAPCGDHFK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x7C42110", Offset = "0x7C41310", VA = "0x187C42110")]
	public static bool IONBNHFPCDG(ABGKFFJDPAB MHEJPNNFCGC, ABGKFFJDPAB BGMAPCGDHFK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x7C42130", Offset = "0x7C41330", VA = "0x187C42130")]
	public static bool MOKODGIIGOB(ABGKFFJDPAB MHEJPNNFCGC, ABGKFFJDPAB BGMAPCGDHFK)
	{
		return default(bool);
	}
}
namespace RecRoom.DataLayer
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	[RecRoom.DataLayer.RRGuid("D3AB0F52-EA41-4891-9470-6E945A9D6583")]
	[RecRoom.DataLayer.NetworkStruct(1, false)]
	public struct NetworkGuid : IEquatable<NetworkGuid>, IComparable<NetworkGuid>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		[RecRoom.DataLayer.Field(1)]
		public int4 data;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public Guid Guid
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x1227CB0", Offset = "0x1226EB0", VA = "0x181227CB0")]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x1227CC0", Offset = "0x1226EC0", VA = "0x181227CC0")]
			set
			{
			}
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x1227CB0", Offset = "0x1226EB0", VA = "0x181227CB0")]
		public static Guid NEKLFDMHCNA(NetworkGuid DIHOLCNHIND)
		{
			return default(Guid);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x1227CB0", Offset = "0x1226EB0", VA = "0x181227CB0")]
		public static NetworkGuid NEKLFDMHCNA(Guid DIHOLCNHIND)
		{
			return default(NetworkGuid);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x7C455D0", Offset = "0x7C447D0", VA = "0x187C455D0", Slot = "4")]
		public bool Equals(NetworkGuid FNJGMJGALLH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x5396FD0", Offset = "0x53961D0", VA = "0x185396FD0", Slot = "5")]
		public int CompareTo(NetworkGuid FNJGMJGALLH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x7C45600", Offset = "0x7C44800", VA = "0x187C45600", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
[RecRoom.DataLayer.RRGuid("9F5F33BE-7C0A-4870-9CE0-BA79440E7F98")]
[RecRoom.DataLayer.NetworkStruct(1, false)]
public struct LKBFADCEBCA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000268")]
	[RecRoom.DataLayer.Field(1)]
	public bool PGGLOGHIPPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000269")]
	[RecRoom.DataLayer.Field(2)]
	public float3 NDEKPPCLDHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400026A")]
	[RecRoom.DataLayer.Field(3)]
	public float3 NODFBBNBCGM;

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x7C3F760", Offset = "0x7C3E960", VA = "0x187C3F760")]
	public LKBFADCEBCA(float BCBBNNPFNAH, float IMCPMFMKKOG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
[RecRoom.DataLayer.NetworkStruct(1, false)]
[RecRoom.DataLayer.RRGuid("35984D5B-ACBD-4389-A94B-840070A871E2")]
public struct BKHKOHIOKMA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400026B")]
	[RecRoom.DataLayer.Field(1)]
	public float CHOICMFCEJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400026C")]
	[RecRoom.DataLayer.Field(2)]
	public int OJOBKOPHLIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400026D")]
	[RecRoom.DataLayer.Field(3)]
	public MPABIJINPFE MJJLCGKEEJD;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public bool KGAMKAHFDDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x7C426F0", Offset = "0x7C418F0", VA = "0x187C426F0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x7C42710", Offset = "0x7C41910", VA = "0x187C42710")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public bool PNMFKGACHKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x7C426E0", Offset = "0x7C418E0", VA = "0x187C426E0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x7C426A0", Offset = "0x7C418A0", VA = "0x187C426A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public bool AKOHBLFNOPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x7C42700", Offset = "0x7C41900", VA = "0x187C42700")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x7C426C0", Offset = "0x7C418C0", VA = "0x187C426C0")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
public struct LKKBBGCNCDA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400026E")]
	public OJKKAKHNEGD CCKIMEINDKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400026F")]
	public int BAJAOMHPNPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000270")]
	public bool KHEGMEICAOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD")]
	[Cpp2IlInjected.Token(Token = "0x4000271")]
	public bool AAFDBGIDFLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE")]
	[Cpp2IlInjected.Token(Token = "0x4000272")]
	public bool IDKMKECFDKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000273")]
	public Vector3 PHGICKGLDGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000274")]
	public Quaternion JPIDPNKLHAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000275")]
	public bool GHJECNJPFHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000276")]
	public Vector3 MKNJDDMDEKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000277")]
	public Vector3 OBPAEIDOCJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000278")]
	public Vector3 CCFEONCCPJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000279")]
	public bool BNGMKMJNIDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400027A")]
	public ViewId NDCECOPABHJ;

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x7C43D60", Offset = "0x7C42F60", VA = "0x187C43D60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
public struct OIAPHONGFCP : IEquatable<OIAPHONGFCP>, IComparable<OIAPHONGFCP>
{
	[Cpp2IlInjected.Token(Token = "0x400027B")]
	public static readonly int GIHDIHFKKCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400027C")]
	public RRObjectPrefabData IGJKKFNOEMM;

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x7C45950", Offset = "0x7C44B50", VA = "0x187C45950", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x7C457B0", Offset = "0x7C449B0", VA = "0x187C457B0", Slot = "4")]
	public bool Equals(OIAPHONGFCP FNJGMJGALLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x7C45820", Offset = "0x7C44A20", VA = "0x187C45820", Slot = "0")]
	public override bool Equals(object DBCLNEGBNLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x7C45920", Offset = "0x7C44B20", VA = "0x187C45920", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x7C45730", Offset = "0x7C44930", VA = "0x187C45730", Slot = "5")]
	public int CompareTo(OIAPHONGFCP FNJGMJGALLH)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
internal class GIJPEPINFMI : ContainerPropertyBag<GCPHFAECGBF>
{
	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x7C43000", Offset = "0x7C42200", VA = "0x187C43000")]
	public GIJPEPINFMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
internal class CELPAOGHJHL : ContainerPropertyBag<RRObjectPrefabData>
{
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	private class GDFGAMEPAMN : Property<RRObjectPrefabData, OKHKCFDCPLN>
	{
		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public override string BGMICIBNDMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x7C42FD0", Offset = "0x7C421D0", VA = "0x187C42FD0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public override bool FDKDJBEEIID
		{
			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0xA3B3E0", Offset = "0xA3A5E0", VA = "0x180A3B3E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x7C42EE0", Offset = "0x7C420E0", VA = "0x187C42EE0")]
		public GDFGAMEPAMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x21927C0", Offset = "0x21919C0", VA = "0x1821927C0", Slot = "14")]
		public override OKHKCFDCPLN GetValue(RRObjectPrefabData NPCDKJJJIDL)
		{
			return default(OKHKCFDCPLN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x7C41630", Offset = "0x7C40830", VA = "0x187C41630", Slot = "15")]
		public override void SetValue(RRObjectPrefabData NPCDKJJJIDL, OKHKCFDCPLN MLCDCHNOCFI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	private class IMMECPJLIOF : Property<RRObjectPrefabData, Guid>
	{
		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public override string BGMICIBNDMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x7C43820", Offset = "0x7C42A20", VA = "0x187C43820", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public override bool FDKDJBEEIID
		{
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0xA3B3E0", Offset = "0xA3A5E0", VA = "0x180A3B3E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x7C43730", Offset = "0x7C42930", VA = "0x187C43730")]
		public IMMECPJLIOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x2DDC660", Offset = "0x2DDB860", VA = "0x182DDC660", Slot = "14")]
		public override Guid GetValue(RRObjectPrefabData NPCDKJJJIDL)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x7C43720", Offset = "0x7C42920", VA = "0x187C43720", Slot = "15")]
		public override void SetValue(RRObjectPrefabData NPCDKJJJIDL, Guid MLCDCHNOCFI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x7C427C0", Offset = "0x7C419C0", VA = "0x187C427C0")]
	public CELPAOGHJHL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
internal class MOFIAOMPPFB : ContainerPropertyBag<Guid>
{
	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x7C44750", Offset = "0x7C43950", VA = "0x187C44750")]
	public MOFIAOMPPFB()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x7C45B30", Offset = "0x7C44D30", VA = "0x187C45B30")]
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
