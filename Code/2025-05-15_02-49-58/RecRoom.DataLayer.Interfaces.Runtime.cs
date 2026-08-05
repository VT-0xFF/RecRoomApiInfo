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
		[Cpp2IlInjected.Address(RVA = "0xA149D0", Offset = "0xA12FD0", VA = "0x180A149D0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA149D0", Offset = "0xA12FD0", VA = "0x180A149D0")]
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
	public class LogRegistrationIndex : BPLGCOBKJGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7BDD9C0", Offset = "0x7BDBFC0", VA = "0x187BDD9C0", Slot = "4")]
		public override void AMBIAOGNIIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA149D0", Offset = "0xA12FD0", VA = "0x180A149D0")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct BJJBLBGIKLM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private bool EPGOOBIACLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private ViewId HMGHCPIBIBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private int LLPAIMMACAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private bool HMLEGGMLFHB;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7BDB760", Offset = "0x7BD9D60", VA = "0x187BDB760")]
	public BJJBLBGIKLM(ViewId HMGHCPIBIBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7BDB780", Offset = "0x7BD9D80", VA = "0x187BDB780")]
	public BJJBLBGIKLM(int LLPAIMMACAP, bool HMLEGGMLFHB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7BDB680", Offset = "0x7BD9C80", VA = "0x187BDB680")]
	public ViewId EACAOJJGFJM([Optional] ViewId EEKKHCDKMOF)
	{
		return default(ViewId);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class APADOBBIDGA
{
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly Guid IMGBKEBCKFP;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static readonly Guid AOJMJPIFDBP;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static readonly Guid ILMDGMCGGJG;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public static readonly Guid DPOCHPIOICP;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly Guid KEBBMMHOLFG;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public static readonly Dictionary<string, Guid> LGAAGJNDNGL;

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static readonly RRObjectPrefabData OOEOHDNHOCA;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly RRObjectPrefabData IKCNAJEAECF;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly RRObjectPrefabData NELFBKCACPK;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7BDAE20", Offset = "0x7BD9420", VA = "0x187BDAE20")]
	public static Guid OGDNJNDNOBL(string NFHOBPDKIPM)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7BDAE50", Offset = "0x7BD9450", VA = "0x187BDAE50")]
	public static RRObjectPrefabData PPPFJHFFFMN(ENDJLEPDNKB MLCOGCMJLBB)
	{
		return default(RRObjectPrefabData);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7BDADB0", Offset = "0x7BD93B0", VA = "0x187BDADB0")]
	public static RRObjectPrefabData CPOPDNOGJJA(ENDJLEPDNKB MLCOGCMJLBB)
	{
		return default(RRObjectPrefabData);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7BDAE00", Offset = "0x7BD9400", VA = "0x187BDAE00")]
	public static RRObjectPrefabData DEDIPMFKEHI(Guid DGNNPFFMIEE)
	{
		return default(RRObjectPrefabData);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[DefaultMember("Item")]
public class IGDOAEDLMGO : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly Dictionary<int, object> APDBNIMCPID;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public Dictionary<int, object> HCNIDPKECHH
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public object OEMFNNCKNFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7BDC930", Offset = "0x7BDAF30", VA = "0x187BDC930")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x7BDCA60", Offset = "0x7BDB060", VA = "0x187BDCA60")]
	public IGDOAEDLMGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x9F86D0", Offset = "0x9F6CD0", VA = "0x1809F86D0")]
	public IGDOAEDLMGO(Dictionary<int, object> APDBNIMCPID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7BDC8D0", Offset = "0x7BDAED0", VA = "0x187BDC8D0")]
	public bool AGMILAFMHHE(IHCOLJNPEOE OEHHKNIGGMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x389B7B0", Offset = "0x3899DB0", VA = "0x18389B7B0")]
	public void NDIHEKGNDCH<T>(IHCOLJNPEOE OEHHKNIGGMI, T OHLIHBDBKCE, [Optional] T JMMNJNFGHEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x389B5F0", Offset = "0x3899BF0", VA = "0x18389B5F0")]
	public void DGBNDJBCMEF<T>(IHCOLJNPEOE OEHHKNIGGMI, T OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7BDCA00", Offset = "0x7BDB000", VA = "0x187BDCA00")]
	public void GNAALOCCJEL(IHCOLJNPEOE OEHHKNIGGMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7BDC990", Offset = "0x7BDAF90", VA = "0x187BDC990", Slot = "4")]
	public object Clone()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum IHCOLJNPEOE : byte
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
public struct PFNBFCKPPHK<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public readonly IHCOLJNPEOE OEHHKNIGGMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly T JMMNJNFGHEP;

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4968C70", Offset = "0x4967270", VA = "0x184968C70")]
	public PFNBFCKPPHK(IHCOLJNPEOE OEHHKNIGGMI, T JMMNJNFGHEP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5610620", Offset = "0x560EC20", VA = "0x185610620")]
	public static PFNBFCKPPHK<T> OIFHDJNIHDL(IHCOLJNPEOE OEHHKNIGGMI)
	{
		return default(PFNBFCKPPHK<T>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x56107E0", Offset = "0x560EDE0", VA = "0x1856107E0")]
	public static PFNBFCKPPHK<T> OIFHDJNIHDL((IHCOLJNPEOE key, T value) FDJHCIBLFFB)
	{
		return default(PFNBFCKPPHK<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(EDHCEECNAFL))]
public struct NEEICKGOONJ : IEnumerable<object>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private class EDHCEECNAFL : Dictionary<string, object>
	{
	}

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private static readonly JBBHIJHGEPM PAJIGEJCNAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private Dictionary<int, object> PMLCGCAHNGK;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool AHPBLIDLKJE
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x172C280", Offset = "0x172A880", VA = "0x18172C280")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int CMIOJAJFIMN
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7BDDED0", Offset = "0x7BDC4D0", VA = "0x187BDDED0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7BDDB90", Offset = "0x7BDC190", VA = "0x187BDDB90")]
	public static NEEICKGOONJ FLLMCNLHKNL()
	{
		return default(NEEICKGOONJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0xD2EEF0", Offset = "0xD2D4F0", VA = "0x180D2EEF0")]
	public NEEICKGOONJ([Optional] Dictionary<int, object> PMLCGCAHNGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x39A64F0", Offset = "0x39A4AF0", VA = "0x1839A64F0")]
	public void IIGLPCDPOEE<T>(PFNBFCKPPHK<T> OEHHKNIGGMI, T? OHLIHBDBKCE) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x39A6310", Offset = "0x39A4910", VA = "0x1839A6310")]
	public void IIGLPCDPOEE<T>((PFNBFCKPPHK<T> key, T value) LPAPCJBBAOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x39A6380", Offset = "0x39A4980", VA = "0x1839A6380")]
	public void IIGLPCDPOEE<T>(PFNBFCKPPHK<T> OEHHKNIGGMI, T OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7BDDC10", Offset = "0x7BDC210", VA = "0x187BDDC10")]
	public void FONMAMFNLDF(NEEICKGOONJ KIDPOMGFMKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7BDDB10", Offset = "0x7BDC110", VA = "0x187BDDB10")]
	private void EEBICEODLFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x39A7D70", Offset = "0x39A6370", VA = "0x1839A7D70")]
	public bool LKMKPGKLGLC<T>(PFNBFCKPPHK<T> OEHHKNIGGMI, [Out] T OHLIHBDBKCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x39A7620", Offset = "0x39A5C20", VA = "0x1839A7620")]
	public bool LKMKPGKLGLC<T>(IHCOLJNPEOE OEHHKNIGGMI, [Out] T OHLIHBDBKCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x39A7320", Offset = "0x39A5920", VA = "0x1839A7320")]
	public T KOFPLAPLCIE<T>(PFNBFCKPPHK<T> OEHHKNIGGMI)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x39A5EE0", Offset = "0x39A44E0", VA = "0x1839A5EE0")]
	public bool AGMILAFMHHE<T>(PFNBFCKPPHK<T> OEHHKNIGGMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7BDDAB0", Offset = "0x7BDC0B0", VA = "0x187BDDAB0")]
	public bool AGMILAFMHHE(IHCOLJNPEOE OEHHKNIGGMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x39A6000", Offset = "0x39A4600", VA = "0x1839A6000")]
	public void GNAALOCCJEL<T>(PFNBFCKPPHK<T> OEHHKNIGGMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7BDDE20", Offset = "0x7BDC420", VA = "0x187BDDE20")]
	public void GNAALOCCJEL(IHCOLJNPEOE OEHHKNIGGMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0xD2EF00", Offset = "0xD2D500", VA = "0x180D2EF00")]
	public Dictionary<int, object> ICNDBGEHKNB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7BDDE70", Offset = "0x7BDC470", VA = "0x187BDDE70", Slot = "4")]
	public IEnumerator<object> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7BDDF20", Offset = "0x7BDC520", VA = "0x187BDDF20", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public enum NLGCKCLHFKD
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
public interface IDHOFIHAGPL
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public enum HLBADKHNPKN
	{
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		Entity,
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		Prefab
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	LocalId AFDJOEOIOAA
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	RRObjectPrefabData CDCPOPGPLKG
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OHLEOHAEFGM(params string[] MKHFKNEFINC);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NGJBEKAJDDN(NLGCKCLHFKD DAHOPIEFIKP, HLBADKHNPKN MECLDBHCDJI = HLBADKHNPKN.Entity);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FBGDELKOPOK(Type MLCOGCMJLBB, ReadOnlySpan<byte> APDBNIMCPID, int CMNLGNDNILP, HLBADKHNPKN MECLDBHCDJI = HLBADKHNPKN.Entity);

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BBEAMEEKJJD(Type MLCOGCMJLBB, HLBADKHNPKN MECLDBHCDJI = HLBADKHNPKN.Entity);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void AFCEPNOIBBB(NLGCKCLHFKD DAHOPIEFIKP, HLBADKHNPKN MECLDBHCDJI = HLBADKHNPKN.Entity);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool AAMGPMFECPH(NLGCKCLHFKD DAHOPIEFIKP);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void HEPBPAFELOP(bool GBIOBLCDPAL, HLBADKHNPKN MECLDBHCDJI = HLBADKHNPKN.Entity);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void APFJJIJGACJ();

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void MCCJAMPFHCL(Type MLCOGCMJLBB);

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "11")]
	LGFMDGFNDFK HHJHDHEEMLK(Type MLCOGCMJLBB);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class OKKEKAJIIFE
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7BDE060", Offset = "0x7BDC660", VA = "0x187BDE060")]
	public static bool KDHJBNOKIIN(this IDHOFIHAGPL INLEBAAACKH, NLGCKCLHFKD FEHDPLGKCJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7BDE000", Offset = "0x7BDC600", VA = "0x187BDE000")]
	public static void BPBFPCAIIIP(this IDHOFIHAGPL INLEBAAACKH, IDHOFIHAGPL.HLBADKHNPKN MECLDBHCDJI = IDHOFIHAGPL.HLBADKHNPKN.Entity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7BDE260", Offset = "0x7BDC860", VA = "0x187BDE260")]
	public static void NCJFFBKJBBK(this IDHOFIHAGPL INLEBAAACKH, IDHOFIHAGPL.HLBADKHNPKN MECLDBHCDJI = IDHOFIHAGPL.HLBADKHNPKN.Entity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x39F2810", Offset = "0x39F0E10", VA = "0x1839F2810")]
	public static void DOGNJDBPHDD<T>(this IDHOFIHAGPL INLEBAAACKH, IDHOFIHAGPL.HLBADKHNPKN MECLDBHCDJI = IDHOFIHAGPL.HLBADKHNPKN.Entity) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x35BBEB0", Offset = "0x35BA4B0", VA = "0x1835BBEB0")]
	public static void EAGLJDNNMCG<T>(this IDHOFIHAGPL INLEBAAACKH, IDHOFIHAGPL.HLBADKHNPKN MECLDBHCDJI = IDHOFIHAGPL.HLBADKHNPKN.Entity) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x39F2850", Offset = "0x39F0E50", VA = "0x1839F2850")]
	public static void EKGGLPHKKPI<T>(this IDHOFIHAGPL INLEBAAACKH, bool LNANGLLHFOF, IDHOFIHAGPL.HLBADKHNPKN MECLDBHCDJI = IDHOFIHAGPL.HLBADKHNPKN.Entity) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x39F28C0", Offset = "0x39F0EC0", VA = "0x1839F28C0")]
	public static void FBGDELKOPOK<T>(this IDHOFIHAGPL INLEBAAACKH, T OHLIHBDBKCE, IDHOFIHAGPL.HLBADKHNPKN MECLDBHCDJI = IDHOFIHAGPL.HLBADKHNPKN.Entity) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x39F2630", Offset = "0x39F0C30", VA = "0x1839F2630")]
	public static void BBEAMEEKJJD<T>(this IDHOFIHAGPL INLEBAAACKH, IDHOFIHAGPL.HLBADKHNPKN MECLDBHCDJI = IDHOFIHAGPL.HLBADKHNPKN.Entity) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x39F4800", Offset = "0x39F2E00", VA = "0x1839F4800")]
	public static void MCCJAMPFHCL<T>(this IDHOFIHAGPL INLEBAAACKH) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x39F48F0", Offset = "0x39F2EF0", VA = "0x1839F48F0")]
	public static void OHHFBFKEDHK<T>(this IDHOFIHAGPL INLEBAAACKH, LocalId GOGGPBKDKBC, IDHOFIHAGPL.HLBADKHNPKN MECLDBHCDJI = IDHOFIHAGPL.HLBADKHNPKN.Entity) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x39F2990", Offset = "0x39F0F90", VA = "0x1839F2990")]
	private static void FBGDELKOPOK<T>(this IDHOFIHAGPL INLEBAAACKH, Type MLCOGCMJLBB, T OHLIHBDBKCE, IDHOFIHAGPL.HLBADKHNPKN MECLDBHCDJI = IDHOFIHAGPL.HLBADKHNPKN.Entity) where T : struct
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct PLPGENBLKMG
{
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface OJDFJPEFOBA
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	Entity MFOJDPOEONE
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
public interface MECOHKFOCBB
{
	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void Bake(IDHOFIHAGPL INLEBAAACKH);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface LNNLBJMHLPI
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LGFMDGFNDFK OIHKMIDKDOJ(Type MLCOGCMJLBB);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class GIIGCMGAOBJ
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x387BEF0", Offset = "0x387A4F0", VA = "0x18387BEF0")]
	public static void OIHKMIDKDOJ<T>(this LNNLBJMHLPI INLEBAAACKH, [Out] T OHLIHBDBKCE) where T : LGFMDGFNDFK
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface LGFMDGFNDFK
{
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class OKNHGLOHLAM
{
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x39F4A20", Offset = "0x39F3020", VA = "0x1839F4A20")]
	public static void AGIJBCHIFCL<T>(this T FBJKBMEOFCA, IDHOFIHAGPL INLEBAAACKH) where T : LGFMDGFNDFK, ECMEDEOEGOM
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x39F4BA0", Offset = "0x39F31A0", VA = "0x1839F4BA0")]
	public static bool GAHPGJBKOAJ<T>(this T IFOOEHEEMON) where T : LGFMDGFNDFK
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface ECMEDEOEGOM
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	Type OCOAENNOCBC
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PNJIDJCBNNF(LGFMDGFNDFK IFOOEHEEMON);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface BHNEEPFEACI : MECOHKFOCBB
{
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void InitNetworkData(LNNLBJMHLPI INLEBAAACKH);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface OADGOMANPCA : LGFMDGFNDFK
{
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface LGPPLIONBEJ
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CCHIJCOFHFI(AEMMHEJJEHA LFJPHGCMAAL);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void APHNLOANEGJ(AEMMHEJJEHA LFJPHGCMAAL);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface ELDKDFIOIIJ
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	ViewId GNGBPIMGLMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface KGHDONEDALP : ELDKDFIOIIJ, NAEKJIPALAD
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void Initialize(ViewId LEMBFAMPAIL, ViewId GIGCJFBFOMC, Dictionary<int, object> BCFIBNCLPAG, AEMMHEJJEHA AMICCGMJHBK);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface FCGGNOJPDEK : ELDKDFIOIIJ
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ANJKPBDKBKO(JOKHKLAANOK JHDAOHEONAC, Vector3 IHMLAPGNLCC, Quaternion JHMNNKLOODA, Vector3 IPGOJHIDCAE, bool FDHCACAHFMC);

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FLLGLJHPANB(Vector3 IHMLAPGNLCC, Quaternion JHMNNKLOODA, Vector3 IPGOJHIDCAE);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PFEAOMFGIPC(ViewId JHDAOHEONAC);

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CKPJJKKMEKP(bool MPPGEIJOEIJ);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ECPBLJEGIEG(bool LPDOGKMEKAP);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface NAEKJIPALAD
{
	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FKJHJFBILFF();
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface LCNMIAJOHCH
{
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NativeArray<Guid> NLLPOEFGDEI(World JEOJCJGMOLH, NativeArray<Entity> ANKLKPHHPBD, Allocator NDFENJBGNOB);
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface KAFHPENPANL
{
	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "0")]
	ReadOnlySpan<byte> ILEKOPFLKFO(Entity IOGPJKLGKKO, int NONDBGDJLCN);

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KELGPFLAEAJ(Entity IOGPJKLGKKO, int NONDBGDJLCN, ReadOnlySpan<byte> OHLIHBDBKCE);

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DKGFPNPMJII(Entity IOGPJKLGKKO, int NONDBGDJLCN, Action COLEJLDPDCO);

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MPECAFFOBJP(Entity IOGPJKLGKKO, int NONDBGDJLCN, Action COLEJLDPDCO);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public static class GKGMJFNJCLP
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x387D350", Offset = "0x387B950", VA = "0x18387D350")]
	public static T LAGPMEDDOPG<T>(this KAFHPENPANL KLIKFABELCJ, Entity IOGPJKLGKKO, int NONDBGDJLCN) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x387D220", Offset = "0x387B820", VA = "0x18387D220")]
	public static void BPBBPDNEHPP<T>(this KAFHPENPANL KLIKFABELCJ, Entity IOGPJKLGKKO, int NONDBGDJLCN, T OHLIHBDBKCE) where T : struct
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
		[Cpp2IlInjected.Address(RVA = "0x7BDB350", Offset = "0x7BD9950", VA = "0x187BDB350", Slot = "4")]
		public bool Equals(AiCodeGenIdData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7BDB390", Offset = "0x7BD9990", VA = "0x187BDB390", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x7BDB440", Offset = "0x7BD9A40", VA = "0x187BDB440", Slot = "2")]
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
		[Cpp2IlInjected.Address(RVA = "0x7BDB350", Offset = "0x7BD9950", VA = "0x187BDB350", Slot = "4")]
		public bool Equals(AiCodeGenNameData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x7BDB450", Offset = "0x7BD9A50", VA = "0x187BDB450", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x7BDB440", Offset = "0x7BD9A40", VA = "0x187BDB440", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public struct AOKOFNMALIC : IComponentData, IEquatable<AOKOFNMALIC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	[RecRoom.DataLayer.Field(1)]
	[RecRoom.DataLayer.Default]
	public uint FPGFCMMHMJG;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7BDAD10", Offset = "0x7BD9310", VA = "0x187BDAD10", Slot = "4")]
	public bool Equals(AOKOFNMALIC MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7BDAD20", Offset = "0x7BD9320", VA = "0x187BDAD20", Slot = "0")]
	public override bool Equals(object BOMDCGFKGKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x12CE620", Offset = "0x12CCC20", VA = "0x1812CE620", Slot = "2")]
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
		[Cpp2IlInjected.Address(RVA = "0x7BDAD10", Offset = "0x7BD9310", VA = "0x187BDAD10", Slot = "4")]
		public bool Equals(AuthoredAIIdData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7BDB500", Offset = "0x7BD9B00", VA = "0x187BDB500", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x12CE620", Offset = "0x12CCC20", VA = "0x1812CE620", Slot = "2")]
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
		[Cpp2IlInjected.Address(RVA = "0xEC65F0", Offset = "0xEC4BF0", VA = "0x180EC65F0")]
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
			[Cpp2IlInjected.Address(RVA = "0x7BDB590", Offset = "0x7BD9B90", VA = "0x187BDB590")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x50C5710", Offset = "0x50C3D10", VA = "0x1850C5710")]
		public AuthoredLocalPoseData(quaternion localRotation, float3 localPosition)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x7BDB5F0", Offset = "0x7BD9BF0", VA = "0x187BDB5F0")]
		public static RigidTransform OIFHDJNIHDL(AuthoredLocalPoseData poseData)
		{
			return default(RigidTransform);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x7BDB5F0", Offset = "0x7BD9BF0", VA = "0x187BDB5F0")]
		public static AuthoredLocalPoseData OIFHDJNIHDL(RigidTransform pose)
		{
			return default(AuthoredLocalPoseData);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public static class MJIMCPOJMPF
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x7BDDA50", Offset = "0x7BDC050", VA = "0x187BDDA50")]
	public static AuthoredLocalPoseData BDEAMIGNKHE([In] this RigidTransform OHLIHBDBKCE)
	{
		return default(AuthoredLocalPoseData);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0xC7C260", Offset = "0xC7A860", VA = "0x180C7C260")]
	public static RigidTransform ADJDCGECIOG(this AuthoredLocalPoseData OHLIHBDBKCE)
	{
		return default(RigidTransform);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7BDDA80", Offset = "0x7BDC080", VA = "0x187BDDA80")]
	public static RigidTransform NPHEAOEBEFB([In] this AuthoredLocalPoseData OHLIHBDBKCE)
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
			[Cpp2IlInjected.Address(RVA = "0x7BDB610", Offset = "0x7BD9C10", VA = "0x187BDB610")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x29A9210", Offset = "0x29A7810", VA = "0x1829A9210")]
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
	public struct AuthoredParentData : IComponentData, OJDFJPEFOBA
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
			[Cpp2IlInjected.Address(RVA = "0xD2EF00", Offset = "0xD2D500", VA = "0x180D2EF00", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0xEE2DE0", Offset = "0xEE13E0", VA = "0x180EE2DE0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0xEE2DE0", Offset = "0xEE13E0", VA = "0x180EE2DE0")]
		public AuthoredParentData(Entity parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x7BDB670", Offset = "0x7BD9C70", VA = "0x187BDB670", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct LMLPKLCLOAH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002C")]
[TypeManager.ForcedStableTypeHash(11776442497872827640uL)]
public struct PLMMFGBGDEF : IComponentData
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
public struct FMMNFAMOAGO : IComponentData
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
public struct CAEJNPECHEM : IComponentData
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
		[Cpp2IlInjected.Address(RVA = "0x7BDC3A0", Offset = "0x7BDA9A0", VA = "0x187BDC3A0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x12AC0B0", Offset = "0x12AA6B0", VA = "0x1812AC0B0")]
		internal EntityPrefabPartId(uint HJPLNJNIFLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0xA36AF0", Offset = "0xA350F0", VA = "0x180A36AF0")]
		internal uint AKBIEILEDCK()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x2151FC0", Offset = "0x21505C0", VA = "0x182151FC0", Slot = "4")]
		public bool Equals(EntityPrefabPartId MIJLJBIHDMP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x7BDC3F0", Offset = "0x7BDA9F0", VA = "0x187BDC3F0", Slot = "0")]
		public override bool Equals(object BOMDCGFKGKF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x12CE620", Offset = "0x12CCC20", VA = "0x1812CE620", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x2151F30", Offset = "0x2150530", VA = "0x182151F30", Slot = "5")]
		public int CompareTo(EntityPrefabPartId MIJLJBIHDMP)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[TypeManager.ForcedStableTypeHash(15026348711748810383uL)]
public struct GDHCAHKECCD : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public Entity PAMAJIDJFOH;
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
		[RecRoom.DataLayer.Default(KCBFJLKHEKK.Children)]
		[RecRoom.DataLayer.Field(1)]
		public KCBFJLKHEKK collisionMode;
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
		public NEKAFJNOKCP grabbableMode;
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
		[RecRoom.DataLayer.Default(GCBFKFHDHEE.NavMeshGenerator)]
		[Config(null, 0)]
		public GCBFKFHDHEE mode;
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
		[RecRoom.DataLayer.Default(JKFPCOPLDFP.IsDynamicEnvironment)]
		[Config(null, 0)]
		public JKFPCOPLDFP collisionLayer;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class LFOBLGJDDIJ
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public enum BPAKAJLOIPM
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
	public enum IIIHBELNHCP
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
	[Cpp2IlInjected.Address(RVA = "0x7BDD710", Offset = "0x7BDBD10", VA = "0x187BDD710")]
	public static (BPAKAJLOIPM, IIIHBELNHCP) HPHIOMMEOCA(this JKFPCOPLDFP JGGBDGJFMCJ)
	{
		return default((BPAKAJLOIPM, IIIHBELNHCP));
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
		[RecRoom.DataLayer.Default(HGKJLDPCHCO.DEFAULT)]
		public HGKJLDPCHCO flags;
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
		[Cpp2IlInjected.Address(RVA = "0xC7C260", Offset = "0xC7A860", VA = "0x180C7C260")]
		public static InventionIdData OIFHDJNIHDL(long value)
		{
			return default(InventionIdData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x7BDCAF0", Offset = "0x7BDB0F0", VA = "0x187BDCAF0")]
		public readonly bool EPGCDDMIODH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x790F610", Offset = "0x790DC10", VA = "0x18790F610")]
		public static bool EPGCDDMIODH(long inventionId)
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
		[Cpp2IlInjected.Address(RVA = "0x1215820", Offset = "0x1213E20", VA = "0x181215820")]
		public static InventionInstanceIdData OIFHDJNIHDL(Guid value)
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
	public struct ParentData : IComponentData, OJDFJPEFOBA
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
			[Cpp2IlInjected.Address(RVA = "0xD2EF00", Offset = "0xD2D500", VA = "0x180D2EF00", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0xEE2DE0", Offset = "0xEE13E0", VA = "0x180EE2DE0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0xEE2DE0", Offset = "0xEE13E0", VA = "0x180EE2DE0")]
		public ParentData(Entity parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0xC7C260", Offset = "0xC7A860", VA = "0x180C7C260")]
		public static implicit operator ParentData(Entity entity)
		{
			return default(ParentData);
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004D")]
public struct ONJAKLJHILO : IComponentData
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
		public ENANNCNMKEP order;

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0xC7C260", Offset = "0xC7A860", VA = "0x180C7C260")]
		public static SiblingSortOrderData OIFHDJNIHDL(ENANNCNMKEP value)
		{
			return default(SiblingSortOrderData);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x7BDBD90", Offset = "0x7BDA390", VA = "0x187BDBD90", Slot = "4")]
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
	public struct InteractionFilterAllTagsData : IComponentData, OJDFJPEFOBA
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
			[Cpp2IlInjected.Address(RVA = "0xD2EF00", Offset = "0xD2D500", VA = "0x180D2EF00", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0xEE2DE0", Offset = "0xEE13E0", VA = "0x180EE2DE0", Slot = "5")]
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
	public struct InteractionFilterAnyTagsData : IComponentData, OJDFJPEFOBA
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
			[Cpp2IlInjected.Address(RVA = "0xD2EF00", Offset = "0xD2D500", VA = "0x180D2EF00", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0xEE2DE0", Offset = "0xEE13E0", VA = "0x180EE2DE0", Slot = "5")]
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
		[RecRoom.DataLayer.Default(JCGOJLOCOAC.Disabled)]
		public JCGOJLOCOAC filterMode;
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[TypeManager.ForcedStableTypeHash(6642820932987006861uL)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[CompilerGenerated]
	[RecRoom.DataLayer.RRGuid("F7789094-7D82-4D27-B805-2CC1B8C0A538")]
	public struct InteractionFilterEntityRefData : IComponentData, OJDFJPEFOBA
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
			[Cpp2IlInjected.Address(RVA = "0xD2EF00", Offset = "0xD2D500", VA = "0x180D2EF00", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0xEE2DE0", Offset = "0xEE13E0", VA = "0x180EE2DE0", Slot = "5")]
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
	public struct InteractionFilterNoneTagsData : IComponentData, OJDFJPEFOBA
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
			[Cpp2IlInjected.Address(RVA = "0xD2EF00", Offset = "0xD2D500", VA = "0x180D2EF00", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xEE2DE0", Offset = "0xEE13E0", VA = "0x180EE2DE0", Slot = "5")]
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
		public PHJDCIAHNAI scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		[Config(null, 0)]
		[RecRoom.DataLayer.Default("ObjectPolicyUserConfigurableFlags.DEFAULT")]
		[RecRoom.DataLayer.Field(3)]
		public FMJNGMHIFLD userConfigurableFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		[RecRoom.DataLayer.Field(4)]
		[RecRoom.DataLayer.Default(NAAMCHMIHPA.Default)]
		[Config(null, 0)]
		public NAAMCHMIHPA circuitsTransformBehavior;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		[RecRoom.DataLayer.Default("ObjectPolicyEnumFlags.Default")]
		[RecRoom.DataLayer.Field(1)]
		public LBIGPLJKBAG flags;
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
	public struct PlayerScopeData : IComponentData, OJDFJPEFOBA
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
			[Cpp2IlInjected.Address(RVA = "0xD2EF00", Offset = "0xD2D500", VA = "0x180D2EF00", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0xEE2DE0", Offset = "0xEE13E0", VA = "0x180EE2DE0", Slot = "5")]
			set
			{
			}
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0xC7C260", Offset = "0xC7A860", VA = "0x180C7C260")]
		public static PlayerScopeData OIFHDJNIHDL(Entity entity)
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
		[RecRoom.DataLayer.Default(CMOLENMEPKL.None)]
		public CMOLENMEPKL flags;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool DynamicUVProjection
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x6FB7EA0", Offset = "0x6FB64A0", VA = "0x186FB7EA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool PreventInvertedCreation
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x6FB7E90", Offset = "0x6FB6490", VA = "0x186FB7E90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public bool NewBendLogic
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x7BDE790", Offset = "0x7BDCD90", VA = "0x187BDE790")]
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
		public DDDGCGEFBGF shapeType;
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
		public ENANNCNMKEP order;

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xC7C260", Offset = "0xC7A860", VA = "0x180C7C260")]
		public static SplinePointOrderData OIFHDJNIHDL(ENANNCNMKEP value)
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
		public JCLGHPNFNJF parameters;
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
[RecRoom.DataLayer.Range(LLKIPCFLHEA.MIN, LLKIPCFLHEA.ALL)]
[Flags]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.RRGuid("CC657074-87FD-47F7-A7B0-F5CCE922A9D0")]
public enum LLKIPCFLHEA
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
		[RecRoom.DataLayer.Default(LLKIPCFLHEA.UseDefaultVisualEffects)]
		[RecRoom.DataLayer.Field(2)]
		public LLKIPCFLHEA toolCleanupFlags;
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
		public PMBKPGKOHOL statusFlags;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
[RecRoom.DataLayer.Range(PMBKPGKOHOL.None, PMBKPGKOHOL.ALL)]
[RecRoom.DataLayer.RRGuid("E63050BA-D087-4027-99F8-4AFDEA229CD8")]
[Flags]
[RecRoom.DataLayer.NetworkEnum(1, false)]
public enum PMBKPGKOHOL
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
		[Cpp2IlInjected.Address(RVA = "0xEC65F0", Offset = "0xEC4BF0", VA = "0x180EC65F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x50C5710", Offset = "0x50C3D10", VA = "0x1850C5710")]
		public LocalPoseData(quaternion localRotation, float3 localPosition)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x7BDB5F0", Offset = "0x7BD9BF0", VA = "0x187BDB5F0")]
		public static RigidTransform OIFHDJNIHDL(LocalPoseData poseData)
		{
			return default(RigidTransform);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x7BDB5F0", Offset = "0x7BD9BF0", VA = "0x187BDB5F0")]
		public static LocalPoseData OIFHDJNIHDL(RigidTransform pose)
		{
			return default(LocalPoseData);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public static class GCLDEBFCKGP
{
	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x7BDC590", Offset = "0x7BDAB90", VA = "0x187BDC590")]
	public static LocalPoseData NDIIHENBBCI([In] this RigidTransform OHLIHBDBKCE)
	{
		return default(LocalPoseData);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x7BDC5C0", Offset = "0x7BDABC0", VA = "0x187BDC5C0")]
	public static RigidTransform NPHEAOEBEFB([In] this LocalPoseData OHLIHBDBKCE)
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
		public BOHBIJHNLLB transformHint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		[RecRoom.DataLayer.Field(2)]
		[RecRoom.DataLayer.Default]
		public HCGMHICBIDB transformPriority;
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
		public ENDJLEPDNKB prefabType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		[RecRoom.DataLayer.Field(2)]
		[RecRoom.DataLayer.Default]
		public Guid prefabGuid;

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x7BDE680", Offset = "0x7BDCC80", VA = "0x187BDE680")]
		public RRObjectPrefabData(Guid prefabGuid, ENDJLEPDNKB prefabType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x7BDE580", Offset = "0x7BDCB80", VA = "0x187BDE580", Slot = "4")]
		public readonly bool Equals(RRObjectPrefabData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x7BDE4C0", Offset = "0x7BDCAC0", VA = "0x187BDE4C0", Slot = "0")]
		public override readonly bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x7BDE690", Offset = "0x7BDCC90", VA = "0x187BDE690")]
		public static bool operator ==(RRObjectPrefabData a, RRObjectPrefabData b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x7BDD640", Offset = "0x7BDBC40", VA = "0x187BDD640", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x7BDD450", Offset = "0x7BDBA50", VA = "0x187BDD450", Slot = "5")]
		public readonly int CompareTo(RRObjectPrefabData other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x7BDE5E0", Offset = "0x7BDCBE0", VA = "0x187BDE5E0", Slot = "3")]
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
		public AEGDAJEGAFP kind;
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
	public struct ReferenceGroupReferenceBuffer : IBufferElementData, OJDFJPEFOBA, IEquatable<ReferenceGroupReferenceBuffer>
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
			[Cpp2IlInjected.Address(RVA = "0xD2EF00", Offset = "0xD2D500", VA = "0x180D2EF00", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0xEE2DE0", Offset = "0xEE13E0", VA = "0x180EE2DE0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x7BDE780", Offset = "0x7BDCD80", VA = "0x187BDE780", Slot = "6")]
		public bool Equals(ReferenceGroupReferenceBuffer other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x7BDE6F0", Offset = "0x7BDCCF0", VA = "0x187BDE6F0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0xA36AF0", Offset = "0xA350F0", VA = "0x180A36AF0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000071")]
public struct OPDMJJOMCFN : IEqualityComparer<ReferenceGroupReferenceBuffer>
{
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	public static OPDMJJOMCFN OPJKGEJPJBC;

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x7BDE2C0", Offset = "0x7BDC8C0", VA = "0x187BDE2C0", Slot = "4")]
	public bool Equals(ReferenceGroupReferenceBuffer CEJAAIDLEPA, ReferenceGroupReferenceBuffer IMNDAJIDDFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0xA6B860", Offset = "0xA69E60", VA = "0x180A6B860", Slot = "5")]
	public int GetHashCode(ReferenceGroupReferenceBuffer BOMDCGFKGKF)
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
	public struct AuthoredUserTagReferenceBuffer : ELNLEJPFPKK, IBufferElementData, OJDFJPEFOBA
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
			[Cpp2IlInjected.Address(RVA = "0xD2EF00", Offset = "0xD2D500", VA = "0x180D2EF00", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0xEE2DE0", Offset = "0xEE13E0", VA = "0x180EE2DE0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0xEE2DE0", Offset = "0xEE13E0", VA = "0x180EE2DE0")]
		public AuthoredUserTagReferenceBuffer(Entity entity)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0xC7C260", Offset = "0xC7A860", VA = "0x180C7C260")]
		public static AuthoredUserTagReferenceBuffer OIFHDJNIHDL(Entity entity)
		{
			return default(AuthoredUserTagReferenceBuffer);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public interface ELNLEJPFPKK : IBufferElementData, OJDFJPEFOBA
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
		[Cpp2IlInjected.Address(RVA = "0x7BDE8C0", Offset = "0x7BDCEC0", VA = "0x187BDE8C0")]
		public UserTagNameData(string value)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x7BDE880", Offset = "0x7BDCE80", VA = "0x187BDE880")]
		public static UserTagNameData OIFHDJNIHDL(string value)
		{
			return default(UserTagNameData);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x7BDE7A0", Offset = "0x7BDCDA0", VA = "0x187BDE7A0", Slot = "4")]
		public bool Equals(UserTagNameData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x7BDE7D0", Offset = "0x7BDCDD0", VA = "0x187BDE7D0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x7BDE870", Offset = "0x7BDCE70", VA = "0x187BDE870", Slot = "2")]
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
	public struct UserTagReferenceBuffer : ELNLEJPFPKK, IBufferElementData, OJDFJPEFOBA
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
			[Cpp2IlInjected.Address(RVA = "0xD2EF00", Offset = "0xD2D500", VA = "0x180D2EF00", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0xEE2DE0", Offset = "0xEE13E0", VA = "0x180EE2DE0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0xEE2DE0", Offset = "0xEE13E0", VA = "0x180EE2DE0")]
		public UserTagReferenceBuffer(Entity entity)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0xC7C260", Offset = "0xC7A860", VA = "0x180C7C260")]
		public static UserTagReferenceBuffer OIFHDJNIHDL(Entity entity)
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
		public GBOINGGHPAL color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		[Config(null, 0)]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(2)]
		public OFEGKJHLAID material;

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
[RecRoom.DataLayer.Range(NAAMCHMIHPA.NONE, NAAMCHMIHPA.COUNT)]
public enum NAAMCHMIHPA
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
public enum AKLDBKIFCLK
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
[RecRoom.DataLayer.Range(AOMCLBDANLL.NONE, AOMCLBDANLL.ALL)]
public enum AOMCLBDANLL
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
public enum JKFPCOPLDFP : byte
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
[RecRoom.DataLayer.Range(KCBFJLKHEKK.Off, KCBFJLKHEKK.COUNT)]
public enum KCBFJLKHEKK : byte
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
public enum DDDGCGEFBGF
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
[RecRoom.DataLayer.Range(NEKAFJNOKCP.Pivot, NEKAFJNOKCP.COUNT)]
[RecRoom.DataLayer.RRGuid("61EFE94A-235A-4281-B938-1A5BE32A18B1")]
[RecRoom.DataLayer.NetworkEnum(2, false)]
public enum NEKAFJNOKCP : byte
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
[RecRoom.DataLayer.Range(JCGOJLOCOAC.EnabledForRole, JCGOJLOCOAC.Disabled)]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.RRGuid("c0973732-e735-44cd-9727-a9a79bad01e3")]
public enum JCGOJLOCOAC : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	EnabledForRole,
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	DisabledForRole,
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	Disabled
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
[RecRoom.DataLayer.Range(GCBFKFHDHEE.NavMeshGenerator, GCBFKFHDHEE.NavMeshBlocker)]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.RRGuid("7E7D5AA1-2EC9-488B-8AB2-703F13BCB8CF")]
public enum GCBFKFHDHEE
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
[RecRoom.DataLayer.Range(LBIGPLJKBAG.None, LBIGPLJKBAG.All)]
[Flags]
public enum LBIGPLJKBAG
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
[RecRoom.DataLayer.Range(0, CMOADABFGJO.COUNT)]
public enum CMOADABFGJO
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
public static class KNEHNNFFEGP
{
	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x7BDD6C0", Offset = "0x7BDBCC0", VA = "0x187BDD6C0")]
	public static void DGBNDJBCMEF(this LBIGPLJKBAG EIBMLBPPJAJ, CMOADABFGJO DGBMONCCFOI, bool MIHGKLOAIPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x7BDD6F0", Offset = "0x7BDBCF0", VA = "0x187BDD6F0")]
	public static bool OJKAOBMIKIG(this LBIGPLJKBAG EIBMLBPPJAJ, CMOADABFGJO DGBMONCCFOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0xDBD130", Offset = "0xDBB730", VA = "0x180DBD130")]
	public static LBIGPLJKBAG BECNNDIMBBH(this CMOADABFGJO DGBMONCCFOI)
	{
		return default(LBIGPLJKBAG);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
[RecRoom.DataLayer.Range(FMJNGMHIFLD.NONE, FMJNGMHIFLD.COUNT)]
[Flags]
[RecRoom.DataLayer.NetworkEnum(2, false)]
[RecRoom.DataLayer.RRGuid("E3C51303-32F0-4EF4-8A66-C814E323653D")]
public enum FMJNGMHIFLD
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
[RecRoom.DataLayer.Range(ENDJLEPDNKB.None, 8000)]
public enum ENDJLEPDNKB
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
public static class FBDGPOPGOEM
{
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	[CompilerGenerated]
	private sealed class DAOKFBDGGAL : IEnumerable<ENDJLEPDNKB>, IEnumerable, IEnumerator<ENDJLEPDNKB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		private ENDJLEPDNKB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		private IEnumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		private ENDJLEPDNKB System.Collections.Generic.IEnumerator<RecRoom.DataLayer.ObjectPrefabType>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0xB76480", Offset = "0xB74A80", VA = "0x180B76480", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(ENDJLEPDNKB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x7BDBB80", Offset = "0x7BDA180", VA = "0x187BDBB80", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x1285160", Offset = "0x1283760", VA = "0x181285160")]
		[DebuggerHidden]
		public DAOKFBDGGAL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x7BDBBD0", Offset = "0x7BDA1D0", VA = "0x187BDBBD0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x7BDB820", Offset = "0x7BD9E20", VA = "0x187BDB820", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x7BDB7C0", Offset = "0x7BD9DC0", VA = "0x187BDB7C0")]
		private void KILKBHNKCHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x7BDBB30", Offset = "0x7BDA130", VA = "0x187BDBB30", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x7BDBA90", Offset = "0x7BDA090", VA = "0x187BDBA90", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<ENDJLEPDNKB> System.Collections.Generic.IEnumerable<RecRoom.DataLayer.ObjectPrefabType>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x7BDBA90", Offset = "0x7BDA090", VA = "0x187BDBA90", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000088")]
	[CompilerGenerated]
	private sealed class IFMCDFECAOA : IEnumerable<ENDJLEPDNKB>, IEnumerable, IEnumerator<ENDJLEPDNKB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		private ENDJLEPDNKB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		private ENDJLEPDNKB <last>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private ENDJLEPDNKB <i>5__3;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		private ENDJLEPDNKB System.Collections.Generic.IEnumerator<RecRoom.DataLayer.ObjectPrefabType>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0xB76480", Offset = "0xB74A80", VA = "0x180B76480", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(ENDJLEPDNKB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x7BDC880", Offset = "0x7BDAE80", VA = "0x187BDC880", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x1285160", Offset = "0x1283760", VA = "0x181285160")]
		[DebuggerHidden]
		public IFMCDFECAOA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x7BDC730", Offset = "0x7BDAD30", VA = "0x187BDC730", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x7BDC830", Offset = "0x7BDAE30", VA = "0x187BDC830", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x7BDC790", Offset = "0x7BDAD90", VA = "0x187BDC790", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<ENDJLEPDNKB> System.Collections.Generic.IEnumerable<RecRoom.DataLayer.ObjectPrefabType>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x7BDC790", Offset = "0x7BDAD90", VA = "0x187BDC790", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000089")]
	[CompilerGenerated]
	private sealed class JMEABONOBLD : IEnumerable<ENDJLEPDNKB>, IEnumerable, IEnumerator<ENDJLEPDNKB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		private ENDJLEPDNKB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		private IEnumerator<ENDJLEPDNKB> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		private ENDJLEPDNKB System.Collections.Generic.IEnumerator<RecRoom.DataLayer.ObjectPrefabType>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0xB76480", Offset = "0xB74A80", VA = "0x180B76480", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(ENDJLEPDNKB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x7BDD310", Offset = "0x7BDB910", VA = "0x187BDD310", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x1285160", Offset = "0x1283760", VA = "0x181285160")]
		[DebuggerHidden]
		public JMEABONOBLD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x7BDD360", Offset = "0x7BDB960", VA = "0x187BDD360", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x7BDCF80", Offset = "0x7BDB580", VA = "0x187BDCF80", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x7BDCF30", Offset = "0x7BDB530", VA = "0x187BDCF30")]
		private void KILKBHNKCHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x7BDD2C0", Offset = "0x7BDB8C0", VA = "0x187BDD2C0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x7BDD220", Offset = "0x7BDB820", VA = "0x187BDD220", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<ENDJLEPDNKB> System.Collections.Generic.IEnumerable<RecRoom.DataLayer.ObjectPrefabType>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x7BDD220", Offset = "0x7BDB820", VA = "0x187BDD220", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x7BDC470", Offset = "0x7BDAA70", VA = "0x187BDC470")]
	[IteratorStateMachine(typeof(DAOKFBDGGAL))]
	public static IEnumerable<ENDJLEPDNKB> LLFIPDKMJDL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x7BDC530", Offset = "0x7BDAB30", VA = "0x187BDC530")]
	[IteratorStateMachine(typeof(IFMCDFECAOA))]
	public static IEnumerable<ENDJLEPDNKB> PGJNOMFKGDC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x7BDC4D0", Offset = "0x7BDAAD0", VA = "0x187BDC4D0")]
	[IteratorStateMachine(typeof(JMEABONOBLD))]
	public static IEnumerable<ENDJLEPDNKB> MECHAOLJMCG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public static class JDAMHOACAEG
{
	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x7BDCE50", Offset = "0x7BDB450", VA = "0x187BDCE50")]
	public static bool DJKLAHGMHIB(this RRObjectPrefabData AIKIMFDJJDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x7BDCE80", Offset = "0x7BDB480", VA = "0x187BDCE80")]
	public static bool DJKLAHGMHIB(this ENDJLEPDNKB MLCOGCMJLBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x7BDCEE0", Offset = "0x7BDB4E0", VA = "0x187BDCEE0")]
	public static bool NGIEADNIGNK(this RRObjectPrefabData AIKIMFDJJDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x7BDCEB0", Offset = "0x7BDB4B0", VA = "0x187BDCEB0")]
	public static bool NGIEADNIGNK(this ENDJLEPDNKB MLCOGCMJLBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x7BDCF10", Offset = "0x7BDB510", VA = "0x187BDCF10")]
	public static GJNFILFOLKG PLMNACGNKNJ(this ENDJLEPDNKB BLHCDMNIPMC)
	{
		return default(GJNFILFOLKG);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x7BDCE20", Offset = "0x7BDB420", VA = "0x187BDCE20")]
	internal static COKLINMHAHA APJNIIKIBJN(this GJNFILFOLKG GENJGIKLGPB)
	{
		return default(COKLINMHAHA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x7BDCE30", Offset = "0x7BDB430", VA = "0x187BDCE30")]
	internal static COKLINMHAHA APJNIIKIBJN(this ENDJLEPDNKB BLHCDMNIPMC)
	{
		return default(COKLINMHAHA);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
internal enum COKLINMHAHA
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
public enum GJNFILFOLKG
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
public static class HJJGHOOGGAD
{
	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x7BDC5F0", Offset = "0x7BDABF0", VA = "0x187BDC5F0")]
	public static bool LJDBFAFCPOG(this GJNFILFOLKG GENJGIKLGPB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
[RecRoom.DataLayer.NetworkEnum(3, false)]
[RecRoom.DataLayer.RRGuid("7A0D34B5-FFE5-4C21-BB0C-CB3EBA34C797")]
[Flags]
[RecRoom.DataLayer.Range(0, HGKJLDPCHCO.ALL)]
public enum HGKJLDPCHCO : ushort
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
		public JMKKFNHDEDM shapeType;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
[RecRoom.DataLayer.Range(-1, 38)]
[RecRoom.DataLayer.RRGuid("517224CC-0A79-4FE9-B048-53C37955D823")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
public enum JMKKFNHDEDM
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
[RecRoom.DataLayer.Range(AEGDAJEGAFP.None, AEGDAJEGAFP.COUNT)]
[RecRoom.DataLayer.RRGuid("3D27DF09-CAE2-4C3F-B808-03AD605F8E98")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
public enum AEGDAJEGAFP : byte
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
public enum CMOLENMEPKL
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
public enum FAGHJIMEEPL
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
public enum BOHBIJHNLLB
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
public enum HCGMHICBIDB
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
public enum GBOINGGHPAL
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
public enum OFEGKJHLAID
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
public interface ICEKMMAICHD : LGFMDGFNDFK
{
	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	[RecRoom.DataLayer.Default]
	[Set.Auth]
	[RecRoom.DataLayer.Key("SBDScale")]
	[ProtoProp("PersistenceViewData.SandboxDeformationData.Deformation", typeof(PLPGENBLKMG))]
	[RecRoom.DataLayer.Field(1)]
	float3 DAEGLJOIOBM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action GCLNMFFDGIF;
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
[RecRoom.DataLayer.RRGuid("112F004A-C92F-4055-99F9-D430EC13FE3C")]
[RecRoom.DataLayer.NetworkStruct(1, false)]
public struct ENANNCNMKEP : IComparable<ENANNCNMKEP>, IEquatable<ENANNCNMKEP>
{
	[Cpp2IlInjected.Token(Token = "0x4000264")]
	public static readonly ENANNCNMKEP KKKNNENCOAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000265")]
	[RecRoom.DataLayer.Field(1)]
	public uint ALMGJPDPHNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000266")]
	[RecRoom.DataLayer.Field(2)]
	public uint KFJKBLMFAAC;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	private readonly uint OEJFFHAEBHN
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x7BDBDB0", Offset = "0x7BDA3B0", VA = "0x187BDBDB0")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public readonly bool LKIDIFGHMGH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x7BDC160", Offset = "0x7BDA760", VA = "0x187BDC160")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x7BDC340", Offset = "0x7BDA940", VA = "0x187BDC340")]
	public ENANNCNMKEP(int ALMGJPDPHNA, int BGHCCOBCLHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x7BDC340", Offset = "0x7BDA940", VA = "0x187BDC340")]
	public ENANNCNMKEP(uint ALMGJPDPHNA, uint BGHCCOBCLHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x7BDC2C0", Offset = "0x7BDA8C0", VA = "0x187BDC2C0")]
	private ENANNCNMKEP(uint ALMGJPDPHNA, uint BGHCCOBCLHB, bool CKBEAALECEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x7BDBC30", Offset = "0x7BDA230", VA = "0x187BDBC30")]
	public ENANNCNMKEP ADJDGMIDLKB(int LLPAIMMACAP = 1)
	{
		return default(ENANNCNMKEP);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x7BDC170", Offset = "0x7BDA770", VA = "0x187BDC170")]
	public ENANNCNMKEP MEJNPEOGMOC(int LLPAIMMACAP = 1)
	{
		return default(ENANNCNMKEP);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x7BDBE30", Offset = "0x7BDA430", VA = "0x187BDBE30")]
	public static ENANNCNMKEP ILFFKOPKOEL(ENANNCNMKEP JOOBCOFNIAM, ENANNCNMKEP MCIIEEEAOOL)
	{
		return default(ENANNCNMKEP);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x7BDC120", Offset = "0x7BDA720", VA = "0x187BDC120")]
	private static ulong KCOAGBAOKMC(ulong FDJHCIBLFFB, ulong CNIMJCCKEDM)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x7BDBCA0", Offset = "0x7BDA2A0", VA = "0x187BDBCA0", Slot = "4")]
	public int CompareTo(ENANNCNMKEP MIJLJBIHDMP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x7BDBD00", Offset = "0x7BDA300", VA = "0x187BDBD00", Slot = "0")]
	public override bool Equals(object BOMDCGFKGKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x7BDC1E0", Offset = "0x7BDA7E0", VA = "0x187BDC1E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x7BDBD90", Offset = "0x7BDA390", VA = "0x187BDBD90", Slot = "5")]
	public bool Equals(ENANNCNMKEP MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x7BDBDC0", Offset = "0x7BDA3C0", VA = "0x187BDBDC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x388B250", Offset = "0x3889850", VA = "0x18388B250")]
	public static bool MMJMCICIDNJ(ENANNCNMKEP JOOBCOFNIAM, ENANNCNMKEP MCIIEEEAOOL)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x7BDBCC0", Offset = "0x7BDA2C0", VA = "0x187BDBCC0")]
	public static bool DIKHMNDIIDO(ENANNCNMKEP JOOBCOFNIAM, ENANNCNMKEP MCIIEEEAOOL)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x7BDBCE0", Offset = "0x7BDA2E0", VA = "0x187BDBCE0")]
	public static bool EBCEPFNFDOC(ENANNCNMKEP JOOBCOFNIAM, ENANNCNMKEP MCIIEEEAOOL)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x7BDBE10", Offset = "0x7BDA410", VA = "0x187BDBE10")]
	public static bool IAGMOHMMNLO(ENANNCNMKEP JOOBCOFNIAM, ENANNCNMKEP MCIIEEEAOOL)
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
			[Cpp2IlInjected.Address(RVA = "0x1215820", Offset = "0x1213E20", VA = "0x181215820")]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x1215810", Offset = "0x1213E10", VA = "0x181215810")]
			set
			{
			}
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x1215820", Offset = "0x1213E20", VA = "0x181215820")]
		public static Guid OIFHDJNIHDL(NetworkGuid DGNNPFFMIEE)
		{
			return default(Guid);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x1215820", Offset = "0x1213E20", VA = "0x181215820")]
		public static NetworkGuid OIFHDJNIHDL(Guid DGNNPFFMIEE)
		{
			return default(NetworkGuid);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x7BDDFB0", Offset = "0x7BDC5B0", VA = "0x187BDDFB0", Slot = "4")]
		public bool Equals(NetworkGuid MIJLJBIHDMP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x4C34790", Offset = "0x4C32D90", VA = "0x184C34790", Slot = "5")]
		public int CompareTo(NetworkGuid MIJLJBIHDMP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x7BDDFE0", Offset = "0x7BDC5E0", VA = "0x187BDDFE0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
[RecRoom.DataLayer.RRGuid("9F5F33BE-7C0A-4870-9CE0-BA79440E7F98")]
[RecRoom.DataLayer.NetworkStruct(1, false)]
public struct PHJDCIAHNAI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000268")]
	[RecRoom.DataLayer.Field(1)]
	public bool BFEIIPBAHBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000269")]
	[RecRoom.DataLayer.Field(2)]
	public float3 KKNGBCICPMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400026A")]
	[RecRoom.DataLayer.Field(3)]
	public float3 HGCALNKDCGJ;

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x7BD7F70", Offset = "0x7BD6570", VA = "0x187BD7F70")]
	public PHJDCIAHNAI(float COJGDIKBGKB, float JNIBMOMFMLL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
[RecRoom.DataLayer.NetworkStruct(1, false)]
[RecRoom.DataLayer.RRGuid("35984D5B-ACBD-4389-A94B-840070A871E2")]
public struct JCLGHPNFNJF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400026B")]
	[RecRoom.DataLayer.Field(1)]
	public float DPJOGBKFGAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400026C")]
	[RecRoom.DataLayer.Field(2)]
	public int EKPPINOMJIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400026D")]
	[RecRoom.DataLayer.Field(3)]
	public FAGHJIMEEPL EIBMLBPPJAJ;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public bool GAGKMEDIIDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x7BDCD90", Offset = "0x7BDB390", VA = "0x187BDCD90")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x7BDCDF0", Offset = "0x7BDB3F0", VA = "0x187BDCDF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public bool DCIOKLKOBML
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x7BDCDE0", Offset = "0x7BDB3E0", VA = "0x187BDCDE0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x7BDCDC0", Offset = "0x7BDB3C0", VA = "0x187BDCDC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public bool JPDHAHGCJCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x7BDCE10", Offset = "0x7BDB410", VA = "0x187BDCE10")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x7BDCDA0", Offset = "0x7BDB3A0", VA = "0x187BDCDA0")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
public struct ABBHPHKIIPL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400026E")]
	public FCGGNOJPDEK JGEDCNIFGNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400026F")]
	public int BEABAIJJKOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000270")]
	public bool GMPMKPGGEJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD")]
	[Cpp2IlInjected.Token(Token = "0x4000271")]
	public bool GALDAGOFMOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE")]
	[Cpp2IlInjected.Token(Token = "0x4000272")]
	public bool JCHJPAOKKBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000273")]
	public Vector3 MJJFMHOFJKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000274")]
	public Quaternion GMKIGHDIIHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000275")]
	public bool AIJNMMLLJHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000276")]
	public Vector3 DAEGLJOIOBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000277")]
	public Vector3 HJOJMFGLFGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000278")]
	public Vector3 NMABGNAMLGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000279")]
	public bool GOHKAKGPPMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400027A")]
	public ViewId NPNNICNEDAO;

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x7BDA3B0", Offset = "0x7BD89B0", VA = "0x187BDA3B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
public struct JPEBIBFEEOG : IEquatable<JPEBIBFEEOG>, IComparable<JPEBIBFEEOG>
{
	[Cpp2IlInjected.Token(Token = "0x400027B")]
	public static readonly int MBGODEFNBJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400027C")]
	public RRObjectPrefabData OMOOALIODHP;

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x7BDD670", Offset = "0x7BDBC70", VA = "0x187BDD670", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x7BDD5D0", Offset = "0x7BDBBD0", VA = "0x187BDD5D0", Slot = "4")]
	public bool Equals(JPEBIBFEEOG MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x7BDD4D0", Offset = "0x7BDBAD0", VA = "0x187BDD4D0", Slot = "0")]
	public override bool Equals(object BOMDCGFKGKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x7BDD640", Offset = "0x7BDBC40", VA = "0x187BDD640", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x7BDD450", Offset = "0x7BDBA50", VA = "0x187BDD450", Slot = "5")]
	public int CompareTo(JPEBIBFEEOG MIJLJBIHDMP)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
internal class JMEMEBGAFAE : ContainerPropertyBag<IGDOAEDLMGO>
{
	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x7BDD3F0", Offset = "0x7BDB9F0", VA = "0x187BDD3F0")]
	public JMEMEBGAFAE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
internal class JANNKALCLPG : ContainerPropertyBag<RRObjectPrefabData>
{
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	private class LJBAKOFHNHF : Property<RRObjectPrefabData, ENDJLEPDNKB>
	{
		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public override string IJKBIMCGCEM
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x7BDD990", Offset = "0x7BDBF90", VA = "0x187BDD990", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public override bool DJCGEFIJFFP
		{
			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0xA34DD0", Offset = "0xA333D0", VA = "0x180A34DD0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x7BDD8A0", Offset = "0x7BDBEA0", VA = "0x187BDD8A0")]
		public LJBAKOFHNHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x2171A90", Offset = "0x2170090", VA = "0x182171A90", Slot = "14")]
		public override ENDJLEPDNKB GetValue(RRObjectPrefabData NELIKBMJKPH)
		{
			return default(ENDJLEPDNKB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x7BD9F20", Offset = "0x7BD8520", VA = "0x187BD9F20", Slot = "15")]
		public override void SetValue(RRObjectPrefabData NELIKBMJKPH, ENDJLEPDNKB OHLIHBDBKCE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	private class HLMPPFMGBKP : Property<RRObjectPrefabData, Guid>
	{
		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public override string IJKBIMCGCEM
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x7BDC700", Offset = "0x7BDAD00", VA = "0x187BDC700", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public override bool DJCGEFIJFFP
		{
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0xA34DD0", Offset = "0xA333D0", VA = "0x180A34DD0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x7BDC610", Offset = "0x7BDAC10", VA = "0x187BDC610")]
		public HLMPPFMGBKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x2D9F450", Offset = "0x2D9DA50", VA = "0x182D9F450", Slot = "14")]
		public override Guid GetValue(RRObjectPrefabData NELIKBMJKPH)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x7BDC600", Offset = "0x7BDAC00", VA = "0x187BDC600", Slot = "15")]
		public override void SetValue(RRObjectPrefabData NELIKBMJKPH, Guid OHLIHBDBKCE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x7BDCB00", Offset = "0x7BDB100", VA = "0x187BDCB00")]
	public JANNKALCLPG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
internal class PJNCGLGKGBM : ContainerPropertyBag<Guid>
{
	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x7BDE2E0", Offset = "0x7BDC8E0", VA = "0x187BDE2E0")]
	public PJNCGLGKGBM()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x7BDE340", Offset = "0x7BDC940", VA = "0x187BDE340")]
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
