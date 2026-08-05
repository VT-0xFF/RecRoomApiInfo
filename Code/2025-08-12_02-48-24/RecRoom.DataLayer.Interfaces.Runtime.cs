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
		[Cpp2IlInjected.Address(RVA = "0xABFAB0", Offset = "0xABE0B0", VA = "0x180ABFAB0")]
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
		[Cpp2IlInjected.Address(RVA = "0xABFAB0", Offset = "0xABE0B0", VA = "0x180ABFAB0")]
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
	public class LogRegistrationIndex : EJFLMJDOOOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x84078C0", Offset = "0x8405EC0", VA = "0x1884078C0", Slot = "4")]
		public override void CBPAAEAGBMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xABFAB0", Offset = "0xABE0B0", VA = "0x180ABFAB0")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct MBIJIHLEFOC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private bool OBAADMPJCLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private ViewId KBEDHBMNMBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private int EFCGAKGCCGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private bool GMJFEJNPLBI;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x8407AB0", Offset = "0x84060B0", VA = "0x188407AB0")]
	public MBIJIHLEFOC(ViewId KBEDHBMNMBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x8407A70", Offset = "0x8406070", VA = "0x188407A70")]
	public MBIJIHLEFOC(int EFCGAKGCCGN, bool GMJFEJNPLBI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x8407990", Offset = "0x8405F90", VA = "0x188407990")]
	public ViewId GGMPIAOBNAN([Optional] ViewId MBCDAKCOJNL)
	{
		return default(ViewId);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class KJLHGNMFPNM
{
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly Guid NJODOHKPKMB;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static readonly Guid DADKGLIBHNF;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static readonly Guid GPLDKLFGLDA;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public static readonly Guid NOCIOJPBCFD;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly Guid EDDKLHHIFON;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public static readonly Dictionary<string, Guid> ENHONAMGOEP;

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static readonly RRObjectPrefabData GNHDEKIOCOM;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly RRObjectPrefabData OEGHMAAELJJ;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly RRObjectPrefabData HAKBIMDPGCE;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x8407140", Offset = "0x8405740", VA = "0x188407140")]
	public static Guid PEIMNHDJJKG(string DJFMCHMDHGK)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x84070D0", Offset = "0x84056D0", VA = "0x1884070D0")]
	public static RRObjectPrefabData HLMLMNLOBCI(GJAKPPLFMHA EHLAHNIAPLD)
	{
		return default(RRObjectPrefabData);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x8407060", Offset = "0x8405660", VA = "0x188407060")]
	public static RRObjectPrefabData ABKJCBMOICL(GJAKPPLFMHA EHLAHNIAPLD)
	{
		return default(RRObjectPrefabData);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x84070B0", Offset = "0x84056B0", VA = "0x1884070B0")]
	public static RRObjectPrefabData EBMLPOPPGII(Guid CLPJLOJHBDJ)
	{
		return default(RRObjectPrefabData);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[DefaultMember("Item")]
public class NHGAECOMCAG : IComponentData, ICloneable, IDMBFAOCJPA
{
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static readonly IDGHEFJHGEI FEFALLLFAGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly Dictionary<int, object> DAJAOHIJHHL;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public Dictionary<int, object> AIJFAAIOPNI
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public object BNCJGLMKBOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8407F80", Offset = "0x8406580", VA = "0x188407F80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x8408090", Offset = "0x8406690", VA = "0x188408090")]
	public NHGAECOMCAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0xA9AB40", Offset = "0xA99140", VA = "0x180A9AB40")]
	public NHGAECOMCAG(Dictionary<int, object> DAJAOHIJHHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x8407FE0", Offset = "0x84065E0", VA = "0x188407FE0", Slot = "5")]
	public bool LNHEDJJBHHC(LIABGOOHOMJ HFLDIIIPBCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3F13030", Offset = "0x3F11630", VA = "0x183F13030")]
	public void GJKNFNDKGEP<T>(LIABGOOHOMJ HFLDIIIPBCG, T FKMNCAKIOFK, [Optional] T DAKPJNHJLJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x3F12E70", Offset = "0x3F11470", VA = "0x183F12E70")]
	public void ADPGIIFDGLO<T>(LIABGOOHOMJ HFLDIIIPBCG, T FKMNCAKIOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x8407F20", Offset = "0x8406520", VA = "0x188407F20")]
	public void HCDNAOEAAEJ(LIABGOOHOMJ HFLDIIIPBCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x8407EB0", Offset = "0x84064B0", VA = "0x188407EB0", Slot = "4")]
	public object Clone()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum LIABGOOHOMJ : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	ColorOverride,
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	TeamOverride,
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	MakerPenInteractionFilter,
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	PersistenceViewId,
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	R1ControlPanelCircuitContextId,
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	R1ControlPanelIsDeserializeId,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	R1ControlPanelParentCircuitContextId,
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	PreviewCircuitContextId,
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	PreviewCircuitContextIsDeserializeId,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	CircuitNodeKey,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	SpawnableToolType,
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	ObjectPickupLockedByKeyId,
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	CostumeEquipLockedByKeyId,
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	PreviewOnly,
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	CardBoxViewId,
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	RoleId,
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	WearerId,
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	PlayerSpawnedEquipmentPurpose,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	PlayerSpawnedEquipmentColorGuid,
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	PlayerSpawnedEquipmentModificationGuid,
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	BagId,
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	Tag,
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	SuppressCleanupTool,
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	SuppressAnimateInParticlesTool,
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	SuppressSkinsTool,
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	SuppressAnimInOut,
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	IgnoreDynamicCollisionsTool,
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	RuntimeSpawn,
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	OwnerPlayerId,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	SpawnTags,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	ExcludeFromRoomSave,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	AvatarItem,
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	ConsumableType,
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	ConsumableId,
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	GiftJson,
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	PlayerRootNetworkId,
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	Source,
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	UnitySubAssets,
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	IsCompanion,
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	IsForCompanion,
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	ConsumableSeed
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct MMIGMMKICGA<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly LIABGOOHOMJ HFLDIIIPBCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly T DAKPJNHJLJO;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x4A79560", Offset = "0x4A77B60", VA = "0x184A79560")]
	public MMIGMMKICGA(LIABGOOHOMJ HFLDIIIPBCG, T DAKPJNHJLJO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5977F30", Offset = "0x5976530", VA = "0x185977F30")]
	public static MMIGMMKICGA<T> HPNBGLLBBBG(LIABGOOHOMJ HFLDIIIPBCG)
	{
		return default(MMIGMMKICGA<T>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x59781F0", Offset = "0x59767F0", VA = "0x1859781F0")]
	public static MMIGMMKICGA<T> HPNBGLLBBBG((LIABGOOHOMJ key, T value) IAFDMJDNHDH)
	{
		return default(MMIGMMKICGA<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface IDMBFAOCJPA
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LNHEDJJBHHC(LIABGOOHOMJ HFLDIIIPBCG);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(IBFIOMMHBOM))]
public struct DDNEFPADLOB : IEnumerable<object>, IEnumerable, IDMBFAOCJPA
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	private class IBFIOMMHBOM : Dictionary<string, object>
	{
	}

	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private static readonly IDGHEFJHGEI FEFALLLFAGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private Dictionary<int, object> MHCCEBNBPPI;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool ODCDDECAKBD
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x1A21380", Offset = "0x1A1F980", VA = "0x181A21380")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int DGBEIHMBLFP
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8404890", Offset = "0x8402E90", VA = "0x188404890")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x84048E0", Offset = "0x8402EE0", VA = "0x1884048E0")]
	public static DDNEFPADLOB EEPJBIPIECL()
	{
		return default(DDNEFPADLOB);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0xEB2930", Offset = "0xEB0F30", VA = "0x180EB2930")]
	public DDNEFPADLOB([Optional] Dictionary<int, object> MHCCEBNBPPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3BCD3A0", Offset = "0x3BCB9A0", VA = "0x183BCD3A0")]
	public void KMLBEHGKDFG<T>(MMIGMMKICGA<T> HFLDIIIPBCG, T? FKMNCAKIOFK) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3BCD1D0", Offset = "0x3BCB7D0", VA = "0x183BCD1D0")]
	public void KMLBEHGKDFG<T>((MMIGMMKICGA<T> key, T value) ELLGDENEHOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x3BCD070", Offset = "0x3BCB670", VA = "0x183BCD070")]
	public void KMLBEHGKDFG<T>(MMIGMMKICGA<T> HFLDIIIPBCG, T FKMNCAKIOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x8404A10", Offset = "0x8403010", VA = "0x188404A10")]
	public void IGDPBMMMPEN(DDNEFPADLOB JHGKHIGHBBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x8404C80", Offset = "0x8403280", VA = "0x188404C80")]
	private void PNHKIAJGEDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3BCE8A0", Offset = "0x3BCCEA0", VA = "0x183BCE8A0")]
	public bool NBJEBNMBDKD<T>(MMIGMMKICGA<T> HFLDIIIPBCG, [Out] T FKMNCAKIOFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3BCE120", Offset = "0x3BCC720", VA = "0x183BCE120", Slot = "7")]
	public bool NBJEBNMBDKD<T>(LIABGOOHOMJ HFLDIIIPBCG, [Out] T FKMNCAKIOFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3BD02F0", Offset = "0x3BCE8F0", VA = "0x183BD02F0")]
	public T OJBFOHJKJBG<T>(MMIGMMKICGA<T> HFLDIIIPBCG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3BCE000", Offset = "0x3BCC600", VA = "0x183BCE000")]
	public bool LNHEDJJBHHC<T>(MMIGMMKICGA<T> HFLDIIIPBCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x8404C20", Offset = "0x8403220", VA = "0x188404C20", Slot = "6")]
	public bool LNHEDJJBHHC(LIABGOOHOMJ HFLDIIIPBCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3BCCD60", Offset = "0x3BCB360", VA = "0x183BCCD60")]
	public void HCDNAOEAAEJ<T>(MMIGMMKICGA<T> HFLDIIIPBCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x84049C0", Offset = "0x8402FC0", VA = "0x1884049C0")]
	public void HCDNAOEAAEJ(LIABGOOHOMJ HFLDIIIPBCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0xB41570", Offset = "0xB3FB70", VA = "0x180B41570")]
	public Dictionary<int, object> EGEIFJKDKIP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x8404960", Offset = "0x8402F60", VA = "0x188404960", Slot = "4")]
	public IEnumerator<object> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x8404D00", Offset = "0x8403300", VA = "0x188404D00", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public enum AKPKPCIBINB
{
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	PrefabComponents,
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	LocalObjectComponents,
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	NetworkedObjectComponents,
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	PolicyComponents,
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	ConnectableComponents,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	RbexComponents,
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	TransformPoseComponents,
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	UniformTransformComponents,
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	DeformableSizeComponents,
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	ShapeComponents,
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	PrimitiveComponents,
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	SplineComponents,
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	SplinePointComponents,
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	ContainerComponents,
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	ContainerLikeComponents,
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	ReplicatorComponents,
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	ContainerPivotComponents,
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	ShapeContainerComponents,
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	CostumePieceComponents,
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	PreventSerializationComponent,
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	DontPropagatePhysicsComponent,
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	DontPropagateOwnershipComponent,
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	LegacyGameObjectComponents,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	GameObjectLegacyGizmoComponents,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	GameObjectCostumeDummyPropComponents,
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	PlayerComponents,
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	PlayerRbexComponents,
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	PlayerTransformComponents,
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	RequireEmbodiedComponents,
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	EntityPrefabRootComponents,
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	EntityPrefabPartComponents,
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	SocketComponents,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	VisibleInHierarchyComponents,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	ToolCleanupComponents,
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	TagComponents,
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	InteractionFilterTagComponents,
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	AutoEmbodimentComponents,
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	ReferenceGroupComponents,
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	UserTagStorageComponents,
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	ReplicatedObjectComponents,
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	InteractionFilteringSettingsComponents,
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	InventionTrackingComponents,
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	ObjectBoardComponents,
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	NetworkTransformComponents,
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	AlwaysEmbodiedScopeComponents,
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	LoadInstanceLifetimeComponents,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	PhysicsModelComponents,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	StudioPropObjectComponents,
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	AnimationControllerComponents,
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	StudioObjectComponents,
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	DesyncNetworkObjectComponents,
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	AuthoredPoseComponents,
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	HasCustomInertialPropertiesWhenRootComponents,
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	MagneticAnchorComponents,
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	SnapPointComponents,
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	TerrainGeneratorComponents
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface BECEKGEMHAB
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public enum IJLILHEIEJK
	{
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		Entity,
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		Prefab
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	LocalId PNIMHFMJKDH
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	RRObjectPrefabData AJKFMEBIKPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AJFCFFBNECE(params string[] MFBOBLCOBIC);

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BDBGFDOJODP(AKPKPCIBINB MIGOAPPFOLA, IJLILHEIEJK JDJJDFOGKAI = IJLILHEIEJK.Entity);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HNKHMHHMHKN(Type EHLAHNIAPLD, ReadOnlySpan<byte> DAJAOHIJHHL, int BKAPIDDDCBM, IJLILHEIEJK JDJJDFOGKAI = IJLILHEIEJK.Entity);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GMDFAHAOONI(Type EHLAHNIAPLD, IJLILHEIEJK JDJJDFOGKAI = IJLILHEIEJK.Entity);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void EDLABCMPCNP(AKPKPCIBINB MIGOAPPFOLA, IJLILHEIEJK JDJJDFOGKAI = IJLILHEIEJK.Entity);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool GNPEGBBEEHN(AKPKPCIBINB MIGOAPPFOLA);

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void AEPLJDABCAG(bool NOAAFHJIPOL, IJLILHEIEJK JDJJDFOGKAI = IJLILHEIEJK.Entity);

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void EICPCDBPLMP();

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void FONNGEKAKEP(Type EHLAHNIAPLD);

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "11")]
	HPCDMPIBNMN BGJMFEAGKDO(Type EHLAHNIAPLD);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class MBNGHBAKEMD
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x8407B30", Offset = "0x8406130", VA = "0x188407B30")]
	public static bool DPMKOMDDAII(this BECEKGEMHAB HHPFOCCGJIF, AKPKPCIBINB IJNDEDMJCID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x8407D30", Offset = "0x8406330", VA = "0x188407D30")]
	public static void FMFHCCHLJGA(this BECEKGEMHAB HHPFOCCGJIF, BECEKGEMHAB.IJLILHEIEJK JDJJDFOGKAI = BECEKGEMHAB.IJLILHEIEJK.Entity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x8407AD0", Offset = "0x84060D0", VA = "0x188407AD0")]
	public static void BFDOECNDNDM(this BECEKGEMHAB HHPFOCCGJIF, BECEKGEMHAB.IJLILHEIEJK JDJJDFOGKAI = BECEKGEMHAB.IJLILHEIEJK.Entity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x3E98FA0", Offset = "0x3E975A0", VA = "0x183E98FA0")]
	public static void GPFHLGDBHGN<T>(this BECEKGEMHAB HHPFOCCGJIF, BECEKGEMHAB.IJLILHEIEJK JDJJDFOGKAI = BECEKGEMHAB.IJLILHEIEJK.Entity) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3DB2240", Offset = "0x3DB0840", VA = "0x183DB2240")]
	public static void LJBENGJHDOF<T>(this BECEKGEMHAB HHPFOCCGJIF, BECEKGEMHAB.IJLILHEIEJK JDJJDFOGKAI = BECEKGEMHAB.IJLILHEIEJK.Entity) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x3E98CA0", Offset = "0x3E972A0", VA = "0x183E98CA0")]
	public static void FNFPHDEGBNP<T>(this BECEKGEMHAB HHPFOCCGJIF, bool KJDGEFNPPKL, BECEKGEMHAB.IJLILHEIEJK JDJJDFOGKAI = BECEKGEMHAB.IJLILHEIEJK.Entity) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3E99140", Offset = "0x3E97740", VA = "0x183E99140")]
	public static void HNKHMHHMHKN<T>(this BECEKGEMHAB HHPFOCCGJIF, T FKMNCAKIOFK, BECEKGEMHAB.IJLILHEIEJK JDJJDFOGKAI = BECEKGEMHAB.IJLILHEIEJK.Entity) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3E98DC0", Offset = "0x3E973C0", VA = "0x183E98DC0")]
	public static void GMDFAHAOONI<T>(this BECEKGEMHAB HHPFOCCGJIF, BECEKGEMHAB.IJLILHEIEJK JDJJDFOGKAI = BECEKGEMHAB.IJLILHEIEJK.Entity) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3E98CD0", Offset = "0x3E972D0", VA = "0x183E98CD0")]
	public static void FONNGEKAKEP<T>(this BECEKGEMHAB HHPFOCCGJIF) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x3E9ABA0", Offset = "0x3E991A0", VA = "0x183E9ABA0")]
	public static void PCELPDJAMON<T>(this BECEKGEMHAB HHPFOCCGJIF, LocalId DLICMGKJENE, BECEKGEMHAB.IJLILHEIEJK JDJJDFOGKAI = BECEKGEMHAB.IJLILHEIEJK.Entity) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3E98FC0", Offset = "0x3E975C0", VA = "0x183E98FC0")]
	private static void HNKHMHHMHKN<T>(this BECEKGEMHAB HHPFOCCGJIF, Type EHLAHNIAPLD, T FKMNCAKIOFK, BECEKGEMHAB.IJLILHEIEJK JDJJDFOGKAI = BECEKGEMHAB.IJLILHEIEJK.Entity) where T : struct
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct LEJODJOIJLE
{
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface BMIPOOOBAAO
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	Entity MFLBPHFKANA
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface NFDMFLCLDKG
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "0")]
	void PreBake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Bake(BECEKGEMHAB HHPFOCCGJIF);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface PDHNFHNDMCM
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HPCDMPIBNMN LHEOCKLJOBM(Type EHLAHNIAPLD);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class JMNBMPMDPDC
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3E3AB90", Offset = "0x3E39190", VA = "0x183E3AB90")]
	public static void LHEOCKLJOBM<T>(this PDHNFHNDMCM HHPFOCCGJIF, [Out] T FKMNCAKIOFK) where T : HPCDMPIBNMN
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface HPCDMPIBNMN
{
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class EKCNLIFNKDI
{
	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x3C10380", Offset = "0x3C0E980", VA = "0x183C10380")]
	public static void CCJIPPHNDEN<T>(this BECEKGEMHAB HHPFOCCGJIF) where T : HPCDMPIBNMN, BCNLMIDFFMP, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x3C10430", Offset = "0x3C0EA30", VA = "0x183C10430")]
	public static void IFBDIMHEBDO<T>(this T MIIJKEGPKFH, BECEKGEMHAB HHPFOCCGJIF) where T : HPCDMPIBNMN, BCNLMIDFFMP
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x3C104D0", Offset = "0x3C0EAD0", VA = "0x183C104D0")]
	public static bool PABAAAPLADO<T>(this T GKFNBEEEIHK) where T : HPCDMPIBNMN
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface BCNLMIDFFMP
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	Type NFMIODPMLKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CBDEJAGDNOD(HPCDMPIBNMN GKFNBEEEIHK);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface AICLAOCEEBN : NFDMFLCLDKG
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void InitNetworkData(PDHNFHNDMCM HHPFOCCGJIF);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface BDDADAJIGDN : HPCDMPIBNMN
{
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface GNPEAAGOCDM
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OEBOHEFDJFE(NAPCGDBANAF PDIOIHNCAEJ);

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void APCLOOEOELO(NAPCGDBANAF PDIOIHNCAEJ);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface LIIPLKPCKPC
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	ViewId IEEDJAJKAAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface FPKEBICGPLH : LIIPLKPCKPC, JMOJKNOIDJM
{
	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void Initialize(ViewId PPKONDOIPBI, ViewId EBOELBLDJNC, Dictionary<int, object> KMJJPAEMNAD, NAPCGDBANAF DBPGJLKPCJJ);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface AFHMAGIABHM : LIIPLKPCKPC
{
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LJDCNOCKLGC(DFCAHNMFPEN IGDHFGFJBMG, Vector3 AEDFHMKGLON, Quaternion IOCPNAEAJJE, Vector3 JLENBJDEIJA, bool HNKOGBHGJMF);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HHAKCEOMCDI(Vector3 AEDFHMKGLON, Quaternion IOCPNAEAJJE, Vector3 JLENBJDEIJA);

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MBGDBGDPEAA(ViewId IGDHFGFJBMG);

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BANCPLNNMLP(bool BILKOGPGDID);

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KBIFIOJEPMO(bool LJHONBFMJCP);
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface JMOJKNOIDJM
{
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BNNHAECAICM();
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface NPIDHPAHKDP
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NativeArray<Guid> FNBPOFOAFHL(World JJBMFGJCFJD, NativeArray<Entity> GIPMABPLBDJ, Allocator EKNOCGFFMAE);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface IOLMBKKACOM
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PGAKBNAHNED(Entity COIPJNEHPIG, int IBFEGOLHMPP);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ReadOnlySpan<byte> NGLIEJHDODN(Entity COIPJNEHPIG, int IBFEGOLHMPP);

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HNPLJENMCLE(Entity COIPJNEHPIG, int IBFEGOLHMPP, ReadOnlySpan<byte> FKMNCAKIOFK);

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CCLEINBCPAF(Entity COIPJNEHPIG, int IBFEGOLHMPP, Action GDMDDGECOJI);

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LACJMGDMPEP(Entity COIPJNEHPIG, int IBFEGOLHMPP, Action GDMDDGECOJI);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public static class EHJIHPHCPED
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x3C0E580", Offset = "0x3C0CB80", VA = "0x183C0E580")]
	public static T PHKFKCCPFFB<T>(this IOLMBKKACOM MELAFKEGKOC, Entity COIPJNEHPIG, int IBFEGOLHMPP) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x3C0E280", Offset = "0x3C0C880", VA = "0x183C0E280")]
	public static void DMELGEIMPOI<T>(this IOLMBKKACOM MELAFKEGKOC, Entity COIPJNEHPIG, int IBFEGOLHMPP, T FKMNCAKIOFK) where T : struct
	{
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	[RecRoom.DataLayer.RRGuid("6241769E-7423-45E5-B125-9F7EAA5D5232")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[TypeManager.ForcedStableTypeHash(9635027148749164348uL)]
	public struct AiCodeGenIdData : IComponentData, IEquatable<AiCodeGenIdData>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public FixedString64Bytes Value;

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x8404530", Offset = "0x8402B30", VA = "0x188404530", Slot = "4")]
		public bool Equals(AiCodeGenIdData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x8404570", Offset = "0x8402B70", VA = "0x188404570", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x8404630", Offset = "0x8402C30", VA = "0x188404630", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[TypeManager.ForcedStableTypeHash(3758703684052595571uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.RRGuid("399DD840-DE45-43FA-9EB0-5E80BC93C8CB")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct AiCodeGenNameData : IComponentData, IEquatable<AiCodeGenNameData>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public FixedString64Bytes Value;

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x8404530", Offset = "0x8402B30", VA = "0x188404530", Slot = "4")]
		public bool Equals(AiCodeGenNameData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x8404640", Offset = "0x8402C40", VA = "0x188404640", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x8404630", Offset = "0x8402C30", VA = "0x188404630", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public struct PBDFIJGMBFE : IComponentData, IEquatable<PBDFIJGMBFE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	[RecRoom.DataLayer.Default]
	[RecRoom.DataLayer.Field(1)]
	public uint FAGODIAEODP;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x8404700", Offset = "0x8402D00", VA = "0x188404700", Slot = "4")]
	public bool Equals(PBDFIJGMBFE IBCMCOKAJEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x8408380", Offset = "0x8406980", VA = "0x188408380", Slot = "0")]
	public override bool Equals(object NDBJJGOPOFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x15B33F0", Offset = "0x15B19F0", VA = "0x1815B33F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[TypeManager.ForcedStableTypeHash(11317457978519712368uL)]
	[RecRoom.DataLayer.NetworkComponent(4, false)]
	[RecRoom.DataLayer.RRGuid("A8D1A28C-A057-4DF1-B0CF-22A81E217E19")]
	[RecRoom.DataLayer.TombstonedFields(new int[] { 2 })]
	[CompilerGenerated]
	public struct AuthoredAIIdData : IComponentData, IEquatable<AuthoredAIIdData>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public uint Value;

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x8404700", Offset = "0x8402D00", VA = "0x188404700", Slot = "4")]
		public bool Equals(AuthoredAIIdData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x8404710", Offset = "0x8402D10", VA = "0x188404710", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x15B33F0", Offset = "0x15B19F0", VA = "0x1815B33F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[RecRoom.DataLayer.RRGuid("650DAD22-E465-4BF2-9A09-076774E09A3E")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[TypeManager.ForcedStableTypeHash(3063687516547021329uL)]
	[CompilerGenerated]
	public struct AuthoredLocalDeformableScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		[RecRoom.DataLayer.Default("new float3(1)")]
		[RecRoom.DataLayer.Field(1)]
		public float3 localDeformationScale;

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x2D7BEE0", Offset = "0x2D7A4E0", VA = "0x182D7BEE0")]
		public AuthoredLocalDeformableScaleData(float3 scale)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[RecRoom.DataLayer.RRGuid("B7CEB5B9-453F-4712-B833-27D907AA13E2")]
	[CompilerGenerated]
	[RecRoom.DataLayer.StableTypeHash(11505792609904010668uL, 0u)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[TypeManager.ForcedStableTypeHash(11505792609904010668uL)]
	public struct AuthoredLocalPoseData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default("new quaternion(new float4(float.NaN))")]
		public quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		[RecRoom.DataLayer.Field(2)]
		[RecRoom.DataLayer.Default("new float3(float.NaN)")]
		public float3 localPosition;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public readonly bool IsValid
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x84047C0", Offset = "0x8402DC0", VA = "0x1884047C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x5682890", Offset = "0x5680E90", VA = "0x185682890")]
		public AuthoredLocalPoseData(quaternion localRotation, float3 localPosition)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x84047A0", Offset = "0x8402DA0", VA = "0x1884047A0")]
		public static RigidTransform HPNBGLLBBBG(AuthoredLocalPoseData poseData)
		{
			return default(RigidTransform);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x84047A0", Offset = "0x8402DA0", VA = "0x1884047A0")]
		public static AuthoredLocalPoseData HPNBGLLBBBG(RigidTransform pose)
		{
			return default(AuthoredLocalPoseData);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class KLLJMIDCKPA
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x8407620", Offset = "0x8405C20", VA = "0x188407620")]
	public static AuthoredLocalPoseData GAKAHJJFJJB([In] this RigidTransform FKMNCAKIOFK)
	{
		return default(AuthoredLocalPoseData);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0xE0C5B0", Offset = "0xE0ABB0", VA = "0x180E0C5B0")]
	public static RigidTransform FDOPCNFHBJA(this AuthoredLocalPoseData FKMNCAKIOFK)
	{
		return default(RigidTransform);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x8407650", Offset = "0x8405C50", VA = "0x188407650")]
	public static RigidTransform NMBCNBHAJDL([In] this AuthoredLocalPoseData FKMNCAKIOFK)
	{
		return default(RigidTransform);
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(9088562008033959482uL)]
	[RecRoom.DataLayer.StableTypeHash(9088562008033959482uL, 0u)]
	[RecRoom.DataLayer.RRGuid("C26C4B4E-5EF3-4F81-87C8-FED8EAD37242")]
	public struct AuthoredLocalUniformScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default(1f)]
		public float localUniformScale;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public readonly bool IsValid
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x8404820", Offset = "0x8402E20", VA = "0x188404820")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x2D7E5A0", Offset = "0x2D7CBA0", VA = "0x182D7E5A0")]
		public AuthoredLocalUniformScaleData(float localUniformScale)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[RecRoom.DataLayer.RRGuid("7B1B8635-3FA9-4ADC-922B-3C25CE0C7E7D")]
	[TypeManager.ForcedStableTypeHash(10137300772124140051uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.StableTypeHash(10137300772124140051uL, 0u)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct AuthoredParentData : IComponentData, BMIPOOOBAAO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public Entity parent;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0xB41570", Offset = "0xB3FB70", VA = "0x180B41570", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x13E0130", Offset = "0x13DE730", VA = "0x1813E0130", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x13E0130", Offset = "0x13DE730", VA = "0x1813E0130")]
		public AuthoredParentData(Entity parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8404880", Offset = "0x8402E80", VA = "0x188404880", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002C")]
public struct PNCEHKEGDKF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002D")]
[TypeManager.ForcedStableTypeHash(11776442497872827640uL)]
public struct IGMKHMIHLNN : IComponentData
{
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("2631F4C3-DBC5-43A2-9257-7D51063B5B82")]
	[RecRoom.DataLayer.StableTypeHash(14109680383450184248uL, 0u)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(14109680383450184248uL)]
	public struct OwnedByTerrainTag : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default(true)]
		public bool isOwnedByTerrain;
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[TypeManager.ForcedStableTypeHash(8594223769175916906uL)]
	[RecRoom.DataLayer.StableTypeHash(8594223769175916906uL, 0u)]
	[RecRoom.DataLayer.RRGuid("B9A63EF5-66A5-463C-8385-A7DC7CE137C3")]
	public struct ObjectBoardNodeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public NetworkGuid nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		[RecRoom.DataLayer.Field(2)]
		[RecRoom.DataLayer.Default]
		public NetworkGuid graphId;
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[TypeManager.ForcedStableTypeHash(5933855128949143734uL)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("B26EF01D-F674-4506-80B7-5345391A097E")]
	[CompilerGenerated]
	public struct ReplicatedObjectActiveStatusData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		[RecRoom.DataLayer.Default(true)]
		[RecRoom.DataLayer.Field(1)]
		public bool active;
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[TypeManager.ForcedStableTypeHash(16338184133650423946uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("E9BA10A4-4EE9-431D-BD7F-FF2008ABFA03")]
	public struct ReplicatedObjectOwnedByPlayerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default(-1)]
		public int actorId;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000032")]
public struct FNBEGJFKPNJ : IComponentData
{
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("46C500A2-9991-4987-B1AA-66E5C3D8E371")]
	[TypeManager.ForcedStableTypeHash(16223816226138460552uL)]
	[CompilerGenerated]
	public struct ReplicatedObjectTag : IComponentData
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[TypeManager.ForcedStableTypeHash(17912083982325865811uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.RRGuid("5ED157AA-488F-453A-A986-594595B8D777")]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	public struct ReplicatorData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public Entity Target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		[RecRoom.DataLayer.Field(2)]
		[RecRoom.DataLayer.Default(false)]
		public bool NeedsCircuitUpdate;
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	[RuntimeOnly]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("72F1ABE4-CB5D-4809-8C6D-BC4D800D9E30")]
	[TypeManager.ForcedStableTypeHash(11840542726010018465uL)]
	public struct ReplicatorExpectedCircuitsRevisionData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public uint ExpectedRevision;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000036")]
public struct OLHPHEPDNAE : IComponentData
{
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[TypeManager.ForcedStableTypeHash(8691279933813304851uL)]
	[RecRoom.DataLayer.RRGuid("AEA4D222-29BA-462F-9C0A-AA2063671C68")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[CompilerGenerated]
	public struct ReplicatorMaxObjectCountData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default(10)]
		public int count;
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[TypeManager.ForcedStableTypeHash(16379995002884076574uL)]
	[RecRoom.DataLayer.RRGuid("400790C1-E8D9-4779-A549-3780DAEC2FDF")]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	public struct ReplicatorPreallocatedObjectCountData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		[RecRoom.DataLayer.Default(0)]
		[RecRoom.DataLayer.Field(1)]
		public int preallocatedCopies;
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(8536678595025273356uL)]
	[RecRoom.DataLayer.RRGuid("6A82044A-E392-4DCD-B4BC-A120E58334EA")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.StableTypeHash(8536678595025273356uL, 0u)]
	public struct EntityPrefabPartData : IComponentData, IComparable<EntityPrefabPartData>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public Entity prefabRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(2)]
		public uint partId;

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x8405750", Offset = "0x8403D50", VA = "0x188405750", Slot = "4")]
		public readonly int CompareTo(EntityPrefabPartData other)
		{
			return default(int);
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public struct EntityPrefabPartId : IEquatable<EntityPrefabPartId>, IComparable<EntityPrefabPartId>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		[SerializeField]
		private uint id;

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x1574730", Offset = "0x1572D30", VA = "0x181574730")]
		internal EntityPrefabPartId(uint JIEJOKBHEMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0xD94A80", Offset = "0xD93080", VA = "0x180D94A80")]
		internal uint EDNHPHECCFI()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x24C4E00", Offset = "0x24C3400", VA = "0x1824C4E00", Slot = "4")]
		public bool Equals(EntityPrefabPartId IBCMCOKAJEM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x84057A0", Offset = "0x8403DA0", VA = "0x1884057A0", Slot = "0")]
		public override bool Equals(object NDBJJGOPOFO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x15B33F0", Offset = "0x15B19F0", VA = "0x1815B33F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x24C4DF0", Offset = "0x24C33F0", VA = "0x1824C4DF0", Slot = "5")]
		public int CompareTo(EntityPrefabPartId IBCMCOKAJEM)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[TypeManager.ForcedStableTypeHash(15026348711748810383uL)]
public struct KNDGNKBOOFF : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public Entity ODAFEHBHNNA;
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[TypeManager.ForcedStableTypeHash(2330616907306882483uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	[ConfigGroup("Physics", 0)]
	[RecRoom.DataLayer.RRGuid("F74D558B-BDCC-48C8-A8EF-1F7559E5EAA0")]
	public struct PhysicsModelCollisionModeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		[RecRoom.DataLayer.Field(1)]
		[Config(null, 0)]
		[RecRoom.DataLayer.Default(MCDIDCAJDOP.Children)]
		public MCDIDCAJDOP collisionMode;
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	[ConfigGroup("Container", 0)]
	[TypeManager.ForcedStableTypeHash(11125590729425051511uL)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("8A12EB45-2A15-41CE-AFF7-90A9F984D3A2")]
	public struct ContainerIsRecolorableData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		[Config(null, 0)]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public bool IsRecolorable;
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[TypeManager.ForcedStableTypeHash(14800424556151816553uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.RRGuid("55EAB643-95BB-4C3A-832C-798EBCD95AD5")]
	[InternalBufferCapacity(0)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct ContainerNameBuffer : IBufferElementData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public byte data;
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	[ConfigGroup("Container", 0)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("89708D57-D027-494A-A159-221E6C643B6B")]
	[RecRoom.DataLayer.StableTypeHash(13657791279235747653uL, 0u)]
	[TypeManager.ForcedStableTypeHash(13657791279235747653uL)]
	public struct ContainerNameData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		[Config(null, 0)]
		public FixedString64Bytes name;
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[ConfigGroup("Physics", 0)]
	[RecRoom.DataLayer.RRGuid("CA023286-E0F6-4DA9-A346-94E86B93977C")]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(13904209480152351845uL)]
	public struct PhysicsModelGrabbableModeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		[Config(null, 0)]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public EENGOGLBEIG grabbableMode;
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[TypeManager.ForcedStableTypeHash(16485879999901987510uL)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[CompilerGenerated]
	[RecRoom.DataLayer.RRGuid("84485C1B-18ED-4D4A-86A4-34CEED482615")]
	[ConfigGroup("Container", 0)]
	[RecRoom.DataLayer.StableTypeHash(16485879999901987510uL, 0u)]
	public struct NavMeshGenerationData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		[Config(null, 0)]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default(FDHJIACFCFO.NavMeshGenerator)]
		public FDHJIACFCFO mode;
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[ConfigGroup("Physics", 0)]
	[RecRoom.DataLayer.RRGuid("C5BCE8B3-6E69-41D4-921A-BE2E3E0A4DAB")]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	[TypeManager.ForcedStableTypeHash(1954118413118190521uL)]
	[CompilerGenerated]
	public struct PhysicsModelCollisionLayerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		[Config(null, 0)]
		[RecRoom.DataLayer.Default(KBEFHOKOHMI.IsDynamicEnvironment)]
		[RecRoom.DataLayer.Field(1)]
		public KBEFHOKOHMI collisionLayer;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class OBEFFFCPPCO
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public enum OIPBMHJPMNN
	{
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		Dynamic,
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		Static,
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		Enemy,
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		Vehicle
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public enum HNPAFCDACBC
	{
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		Environmental,
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		IgnoreStaticGeometry,
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		IgnoreOtherDynamic,
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		IgnorePlayers,
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		IgnoreMost,
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		Projectile
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x84081F0", Offset = "0x84067F0", VA = "0x1884081F0")]
	public static (OIPBMHJPMNN, HNPAFCDACBC) MLALAMLOPAL(this KBEFHOKOHMI CGCOAIEEKKE)
	{
		return default((OIPBMHJPMNN, HNPAFCDACBC));
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[ConfigGroup("Physics", 0)]
	[RecRoom.DataLayer.RRGuid("F63AA9EA-6191-4DE9-BB18-1F049F432124")]
	[RecRoom.DataLayer.NetworkComponent(4, false)]
	[TypeManager.ForcedStableTypeHash(16462677563651546047uL)]
	[CompilerGenerated]
	public struct PhysicsModelFlagsData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		[RecRoom.DataLayer.Default(DJIAOOPCFNI.DEFAULT)]
		[RecRoom.DataLayer.Field(1)]
		[Config(null, 0)]
		public DJIAOOPCFNI flags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[TypeManager.ForcedStableTypeHash(1094837642118998916uL)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("B6D08147-6AEA-4270-BDC4-8CF68662318D")]
	[RecRoom.DataLayer.StableTypeHash(1094837642118998916uL, 0u)]
	[ConfigGroup("Physics", 0)]
	[CompilerGenerated]
	public struct PhysicsModelMassOverrideData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		[RecRoom.DataLayer.Default(0f)]
		[Config(null, 0)]
		[RecRoom.DataLayer.Field(1)]
		public float mass;
	}
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[TypeManager.ForcedStableTypeHash(10518841812724430444uL)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("17799917-98EE-4D9A-A8D1-B0BE5F7316E3")]
	[CompilerGenerated]
	public struct InventionIdData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default(0L)]
		public long inventionId;

		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public const long INVALID_INVENTION_ID = 0L;

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0xE0C5B0", Offset = "0xE0ABB0", VA = "0x180E0C5B0")]
		public static InventionIdData HPNBGLLBBBG(long value)
		{
			return default(InventionIdData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x8407050", Offset = "0x8405650", VA = "0x188407050")]
		public readonly bool IAIOPCFFPHF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x8111360", Offset = "0x810F960", VA = "0x188111360")]
		public static bool IAIOPCFFPHF(long inventionId)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	[RecRoom.DataLayer.TombstonedFields(new int[] { 1 })]
	[RecRoom.DataLayer.RRGuid("629F0A56-C478-4353-BBDA-8A8BB5FEE478")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(14338988155392421373uL)]
	public struct InventionInstanceIdData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(2)]
		public NetworkGuid instanceId;

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x1286740", Offset = "0x1284D40", VA = "0x181286740")]
		public static InventionInstanceIdData HPNBGLLBBBG(Guid value)
		{
			return default(InventionInstanceIdData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[TypeManager.ForcedStableTypeHash(7796256876318585598uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.RRGuid("5D26C8C6-7B5E-481E-B31E-6F30BE69D3C9")]
	public struct DesyncEntityReferenceData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public Entity entity;
	}
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("AFCA5CDE-FE11-4D4A-BBC6-32EE1D254891")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(3111430309403391054uL)]
	public struct DesyncNetworkEntityBackReferenceData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public Entity entity;
	}
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[SerializationOnly]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[TypeManager.ForcedStableTypeHash(3936130774074738641uL)]
	[RecRoom.DataLayer.RRGuid("F1D14C4E-5388-4D7C-B641-5E79453B80AB")]
	[CompilerGenerated]
	public struct DesyncNetworkComponentsData : IBufferElementData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public ulong stableTypeHash;
	}
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[TypeManager.ForcedStableTypeHash(16880504271670651740uL)]
	[RecRoom.DataLayer.RRGuid("04FC082C-DAD0-45B5-A3EF-F042100BAF0F")]
	[RuntimeOnly]
	[CompilerGenerated]
	public struct ElementSnapPointData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public Entity snappedTo;
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	[RuntimeOnly]
	[RecRoom.DataLayer.RRGuid("C9620D1E-DE40-4530-954E-90760F1B7A41")]
	[TypeManager.ForcedStableTypeHash(12457040547531531440uL)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct ElementSnapPointRuntimeFlagsData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		[RecRoom.DataLayer.Default(FIJDIDACNHL.None)]
		[RecRoom.DataLayer.Field(1)]
		public FIJDIDACNHL flags;
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[RuntimeOnly]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.StableTypeHash(12111354511484844847uL, 0u)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(12111354511484844847uL)]
	[RecRoom.DataLayer.RRGuid("A3B27452-BD6C-43B2-BAFF-CF885EB1608B")]
	public struct ParentData : IComponentData, BMIPOOOBAAO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public Entity parent;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0xB41570", Offset = "0xB3FB70", VA = "0x180B41570", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x13E0130", Offset = "0x13DE730", VA = "0x1813E0130", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x13E0130", Offset = "0x13DE730", VA = "0x1813E0130")]
		public ParentData(Entity parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xE0C5B0", Offset = "0xE0ABB0", VA = "0x180E0C5B0")]
		public static implicit operator ParentData(Entity entity)
		{
			return default(ParentData);
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000050")]
public struct AJIMDPHLFOK : IComponentData
{
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[RecRoom.DataLayer.StableTypeHash(1950029632769634832uL, 0u)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(1950029632769634832uL)]
	[RecRoom.DataLayer.RRGuid("c886150a-7231-4cc5-a2b2-f222500e6960")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct SiblingSortOrderData : IEquatable<SiblingSortOrderData>, IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public EDCLCHHFDDJ order;

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xE0C5B0", Offset = "0xE0ABB0", VA = "0x180E0C5B0")]
		public static SiblingSortOrderData HPNBGLLBBBG(EDCLCHHFDDJ value)
		{
			return default(SiblingSortOrderData);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8404E30", Offset = "0x8403430", VA = "0x188404E30", Slot = "4")]
		public bool Equals(SiblingSortOrderData other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	[RecRoom.DataLayer.RRGuid("46CEA601-8AA7-423D-B1EA-EEABAE73413F")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[TypeManager.ForcedStableTypeHash(6217116203744017593uL)]
	public struct InteractionFilterAllTagsData : IComponentData, BMIPOOOBAAO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public Entity allTags;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0xB41570", Offset = "0xB3FB70", VA = "0x180B41570", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x13E0130", Offset = "0x13DE730", VA = "0x1813E0130", Slot = "5")]
			set
			{
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[RecRoom.DataLayer.RRGuid("49CEFD0F-3A38-4A9B-835E-10B4C2D08392")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(6215026851838101933uL)]
	public struct InteractionFilterAnyTagsData : IComponentData, BMIPOOOBAAO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public Entity anyTags;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xB41570", Offset = "0xB3FB70", VA = "0x180B41570", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x13E0130", Offset = "0x13DE730", VA = "0x1813E0130", Slot = "5")]
			set
			{
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("11CE457F-4366-4AAD-B7E3-28D82B4FAFCF")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(6780642047612598977uL)]
	public struct InteractionFilterEnabledData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default(EKGHLLENOHA.Disabled)]
		public EKGHLLENOHA filterMode;
	}
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(6642820932987006861uL)]
	[RecRoom.DataLayer.RRGuid("F7789094-7D82-4D27-B805-2CC1B8C0A538")]
	public struct InteractionFilterEntityRefData : IComponentData, BMIPOOOBAAO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public Entity filterEntity;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0xB41570", Offset = "0xB3FB70", VA = "0x180B41570", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x13E0130", Offset = "0x13DE730", VA = "0x1813E0130", Slot = "5")]
			set
			{
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(15467295871228743847uL)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("C7E95AF7-DB7D-4432-8DAA-8F36EC6C4308")]
	public struct InteractionFilterNoneTagsData : IComponentData, BMIPOOOBAAO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public Entity noneTags;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xB41570", Offset = "0xB3FB70", VA = "0x180B41570", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x13E0130", Offset = "0x13DE730", VA = "0x1813E0130", Slot = "5")]
			set
			{
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[CompilerGenerated]
	[RecRoom.DataLayer.RRGuid("C0280102-4D0D-4960-B108-E59CAE468710")]
	[TypeManager.ForcedStableTypeHash(15820415814547747176uL)]
	public struct ObjectInteractionFilterData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public Entity entity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		[RecRoom.DataLayer.Default(EKGHLLENOHA.EnabledForRole)]
		[RecRoom.DataLayer.Field(2)]
		public EKGHLLENOHA mode;
	}
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[TypeManager.ForcedStableTypeHash(10434800737286119109uL)]
	[RecRoom.DataLayer.RRGuid("A5E08071-6B43-446F-A542-878B31E43736")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[CompilerGenerated]
	public struct MagneticAnchorData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public Entity connectedAnchor;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[TypeManager.ForcedStableTypeHash(15012400804589552708uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.StableTypeHash(15012400804589552708uL, 0u)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("007F8815-C87C-4E6B-BC56-3BA0C4888E3D")]
	public struct OverrideObjectNetworkIdData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public uint networkIdBits;
	}
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[RecRoom.DataLayer.RRGuid("9B8A289B-7511-48FB-9C5A-3202C6AD5185")]
	[TypeManager.ForcedStableTypeHash(764574820961958276uL)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[CompilerGenerated]
	public struct PlayerRoleComponentData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public EMDHJAPEHGM RoleType;
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("30228348-77DF-48F6-B2EF-B0883D3E10CA")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(4540375434353162791uL)]
	public struct MakerPenHeldData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public bool makerPenHeld;
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[ConfigGroup("Object", 0)]
	[RecRoom.DataLayer.NetworkComponent(6, false)]
	[RecRoom.DataLayer.RRGuid("FB9853D6-6231-43FD-A754-00105DC30880")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(8459715919607487693uL)]
	public struct ObjectPolicyData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		[RecRoom.DataLayer.Field(2)]
		[RecRoom.DataLayer.Default("new ScaleRestriction(1,1)")]
		public GAJCCCIGMFD scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		[RecRoom.DataLayer.Field(3)]
		[Config(null, 0)]
		[RecRoom.DataLayer.Default("ObjectPolicyUserConfigurableFlags.DEFAULT")]
		public KPKPCLALEAL userConfigurableFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		[Config(null, 0)]
		[RecRoom.DataLayer.Field(4)]
		[RecRoom.DataLayer.Default(BKNAOBLPGDM.Default)]
		public BKNAOBLPGDM circuitsTransformBehavior;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default("ObjectPolicyEnumFlags.Default")]
		public AIGILGIOKEF flags;
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[TypeManager.ForcedStableTypeHash(2965180940795077803uL)]
	[SerializationOnly]
	[RecRoom.DataLayer.RRGuid("01AEEF22-2473-4505-A473-0BBF009690B3")]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct RemovedNetworkComponentsBuffer : IBufferElementData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public ulong stableTypeHash;
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[RecRoom.DataLayer.RRGuid("617A903E-C2C2-467C-A138-287FDB487645")]
	[RecRoom.DataLayer.StableTypeHash(17708500325183871236uL, 0u)]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[TypeManager.ForcedStableTypeHash(17708500325183871236uL)]
	public struct PlayerScopeData : IComponentData, BMIPOOOBAAO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public Entity playerScope;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public Entity Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0xB41570", Offset = "0xB3FB70", VA = "0x180B41570", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x13E0130", Offset = "0x13DE730", VA = "0x1813E0130", Slot = "5")]
			set
			{
			}
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0xE0C5B0", Offset = "0xE0ABB0", VA = "0x180E0C5B0")]
		public static PlayerScopeData HPNBGLLBBBG(Entity entity)
		{
			return default(PlayerScopeData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[TypeManager.ForcedStableTypeHash(16642773407304133105uL)]
	[ConfigGroup("Physics", 0)]
	[RecRoom.DataLayer.StableTypeHash(16642773407304133105uL, 0u)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("F945B699-C9E5-4634-9F64-831484F4F3BD")]
	[CompilerGenerated]
	public struct PhysicsMaterialData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		[Config(null, 0)]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default(10f)]
		public float density;
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[TypeManager.ForcedStableTypeHash(10537432342869025182uL)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[CompilerGenerated]
	[RecRoom.DataLayer.StableTypeHash(10537432342869025182uL, 0u)]
	[RecRoom.DataLayer.RRGuid("A2E0AF0F-C284-47E6-9535-A67A29BF5730")]
	public struct ShapeConfigData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default(DFBCNJDDJPE.None)]
		public DFBCNJDDJPE flags;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool DynamicUVProjection
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x7743840", Offset = "0x7741E40", VA = "0x187743840")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool PreventInvertedCreation
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x7743830", Offset = "0x7741E30", VA = "0x187743830")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public bool NewBendLogic
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x84089E0", Offset = "0x8406FE0", VA = "0x1884089E0")]
			get
			{
				return default(bool);
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[TypeManager.ForcedStableTypeHash(10917729582819845312uL)]
	[RecRoom.DataLayer.RRGuid("5C706BF1-9D50-456A-B974-521E8E2CC660")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[CompilerGenerated]
	[RecRoom.DataLayer.StableTypeHash(10917729582819845312uL, 0u)]
	public struct ShapeTypeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public PPBNHAEPJLD shapeType;
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("36418781-DB47-4DE7-A138-CC88D1D795C0")]
	[RecRoom.DataLayer.StableTypeHash(5298506180484533559uL, 0u)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(5298506180484533559uL)]
	public struct SplinePointOrderData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public EDCLCHHFDDJ order;

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xE0C5B0", Offset = "0xE0ABB0", VA = "0x180E0C5B0")]
		public static SplinePointOrderData HPNBGLLBBBG(EDCLCHHFDDJ value)
		{
			return default(SplinePointOrderData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[RecRoom.DataLayer.RRGuid("FCEE3BCD-9C10-4BF4-954A-0DCFE8810227")]
	[RecRoom.DataLayer.StableTypeHash(16368389834000856208uL, 0u)]
	[TypeManager.ForcedStableTypeHash(16368389834000856208uL)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[CompilerGenerated]
	public struct SplinePointParentData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public Entity spline;
	}
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[TypeManager.ForcedStableTypeHash(18095612727592564636uL)]
	[RecRoom.DataLayer.StableTypeHash(18095612727592564636uL, 0u)]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("5A6D38A4-1A58-4EB4-9C1B-06ADA0D44AFA")]
	public struct SplinePointPositionData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public float3 localPosition;
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[RecRoom.DataLayer.RRGuid("433F66B6-CC1C-4A8A-BF73-2B797440A8DB")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.StableTypeHash(1429513518619209486uL, 0u)]
	[TypeManager.ForcedStableTypeHash(1429513518619209486uL)]
	[CompilerGenerated]
	public struct SplinePointRotationData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		[RecRoom.DataLayer.Default("new quaternion(0, 0, 0, 1f)")]
		[RecRoom.DataLayer.Field(1)]
		public quaternion localRotation;
	}
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(1238044349990854547uL)]
	[RecRoom.DataLayer.StableTypeHash(1238044349990854547uL, 0u)]
	[RecRoom.DataLayer.RRGuid("04CA3CCE-F121-4B5B-BC56-FE8E9C77F0F4")]
	public struct SplinePointScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default("new float3(1)")]
		public float3 localScale;
	}
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[RecRoom.DataLayer.StableTypeHash(4657247877648983868uL, 0u)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[CompilerGenerated]
	[RecRoom.DataLayer.RRGuid("E0610986-0F8F-494A-8C6E-8A2D2491B088")]
	[TypeManager.ForcedStableTypeHash(4657247877648983868uL)]
	public struct SplineShapeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public EKPIPMMBPJG parameters;
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[RecRoom.DataLayer.StableTypeHash(12332323170023439017uL, 0u)]
	[RecRoom.DataLayer.RRGuid("73C344D9-D535-4753-9D9A-B6DEDE4079B0")]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	[TypeManager.ForcedStableTypeHash(12332323170023439017uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.TombstonedFields(new int[] { 1 })]
	public struct OMShapeContainerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		[RecRoom.DataLayer.Default(true)]
		[RecRoom.DataLayer.Field(2)]
		public bool canModifyWithCircuits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		[RecRoom.DataLayer.Default(true)]
		[RecRoom.DataLayer.Field(3)]
		public bool optimizedCollidersEnabled;
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	[RecRoom.DataLayer.RRGuid("2B5C4208-9113-4F65-B3A6-18EAE1FF3937")]
	[TypeManager.ForcedStableTypeHash(17673274643717888315uL)]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	public struct SerializedDataLayerVersionData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public int version;
	}
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[RecRoom.DataLayer.RRGuid("530E7647-9756-405B-8F83-554B2251FEA9")]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(2300229493044241130uL)]
	public struct TerrainGenerationData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default(0u)]
		public uint Seed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		[RecRoom.DataLayer.Field(2)]
		[RecRoom.DataLayer.Default(1f)]
		public float BaseTerrainHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		[RecRoom.DataLayer.Default(1f)]
		[RecRoom.DataLayer.Field(3)]
		public float BaseTerrainFeatureScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		[RecRoom.DataLayer.Field(4)]
		[RecRoom.DataLayer.Default]
		public IDAMNGPLNCK PlayAreaShape;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(5)]
		public LMJANGHOCHE BaseTerrainRoughness;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(6)]
		public LKFHIDCNMGI BaseTerrainHeightFunction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		[RecRoom.DataLayer.Default(0.75f)]
		[RecRoom.DataLayer.Field(7)]
		public float PlayAreaOpacity;
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[CompilerGenerated]
	[RecRoom.DataLayer.RRGuid("207C2E2E-B1B0-4A2B-8A14-9651A907CBC6")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[TypeManager.ForcedStableTypeHash(2736085529679546037uL)]
	public struct TerrainLayerBuffer : IBufferElementData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public TerrainGenerationLayer layer;
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[TypeManager.ForcedStableTypeHash(17384573708384647569uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.RRGuid("557221B3-5BED-456A-8B42-A8D934D18103")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct TerrainMaterialLayerBuffer : IBufferElementData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public NPDFLAAOGLM layer;
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("6BA5DFA9-9617-4782-A765-0DD5898267E0")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(15805686756326706819uL)]
	public struct TerrainWaterData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default(-1)]
		public float WaterHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		[RecRoom.DataLayer.Field(2)]
		[RecRoom.DataLayer.Default(0.25f)]
		public float WaterChop;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		[RecRoom.DataLayer.Field(3)]
		[RecRoom.DataLayer.Default(0.25f)]
		public float WaterAlpha;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		[RecRoom.DataLayer.Default(DLKBGAHIKAB.Invalid)]
		[RecRoom.DataLayer.Field(4)]
		public DLKBGAHIKAB WaterColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		[RecRoom.DataLayer.Default(DLKBGAHIKAB.Invalid)]
		[RecRoom.DataLayer.Field(5)]
		public DLKBGAHIKAB DeepColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		[RecRoom.DataLayer.Default(1)]
		[RecRoom.DataLayer.Field(6)]
		public float EmissiveStrength;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[Flags]
[RecRoom.DataLayer.Range(BPPEILIDMBL.MIN, BPPEILIDMBL.ALL)]
[RecRoom.DataLayer.RRGuid("CC657074-87FD-47F7-A7B0-F5CCE922A9D0")]
public enum BPPEILIDMBL
{
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	IsAllowed = 1,
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	UseDefaultVisualEffects = 2,
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	DEFAULT = 2,
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	ALL = 3,
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	MAX = 3
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[TypeManager.ForcedStableTypeHash(5328722791392374178uL)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("34BA53CB-16FB-45DB-AA25-293CE7C8DAE4")]
	[CompilerGenerated]
	public struct ToolCleanupSettingsData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default(15f)]
		public float delay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		[RecRoom.DataLayer.Default(BPPEILIDMBL.UseDefaultVisualEffects)]
		[RecRoom.DataLayer.Field(2)]
		public BPPEILIDMBL toolCleanupFlags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[RecRoom.DataLayer.TombstonedFields(new int[] { 2, 3 })]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(13768238190614302474uL)]
	[RecRoom.DataLayer.RRGuid("48C72ABE-383D-45C6-9610-773F2B4F84C6")]
	public struct ToolCleanupStatusData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public float cleanupStartTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		[RecRoom.DataLayer.Field(4)]
		[RecRoom.DataLayer.Default]
		public FNJGDEFCMNB statusFlags;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.RRGuid("E63050BA-D087-4027-99F8-4AFDEA229CD8")]
[RecRoom.DataLayer.Range(FNJGDEFCMNB.None, FNJGDEFCMNB.ALL)]
[Flags]
public enum FNJGDEFCMNB
{
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	ForceCleanup = 1,
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	CleanupDone = 2,
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	CleanupPaused = 4,
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	ALL = 7,
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	MAX = 7
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[RecRoom.DataLayer.RRGuid("021E8703-AAFD-4965-8C38-FF86663126D2")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(463077377357487319uL)]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	public struct LocalDeformableScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		[RecRoom.DataLayer.Default("new float3(1)")]
		[RecRoom.DataLayer.Field(1)]
		public float3 localDeformationScale;

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x2D7BEE0", Offset = "0x2D7A4E0", VA = "0x182D7BEE0")]
		public LocalDeformableScaleData(float3 scale)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	[RecRoom.DataLayer.RRGuid("38AA9F1D-FD16-4B56-917C-3341D0EB1DF2")]
	[RecRoom.DataLayer.StableTypeHash(1369925932270831712uL, 0u)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(1369925932270831712uL)]
	public struct LocalPoseData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default("new quaternion(0,0,0,1)")]
		public quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		[RecRoom.DataLayer.Field(2)]
		[RecRoom.DataLayer.Default]
		public float3 localPosition;

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x5682890", Offset = "0x5680E90", VA = "0x185682890")]
		public LocalPoseData(quaternion localRotation, float3 localPosition)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x84047A0", Offset = "0x8402DA0", VA = "0x1884047A0")]
		public static RigidTransform HPNBGLLBBBG(LocalPoseData poseData)
		{
			return default(RigidTransform);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x84047A0", Offset = "0x8402DA0", VA = "0x1884047A0")]
		public static LocalPoseData HPNBGLLBBBG(RigidTransform pose)
		{
			return default(LocalPoseData);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public static class PFMEOJICDIP
{
	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x8408530", Offset = "0x8406B30", VA = "0x188408530")]
	public static LocalPoseData KBEHPOPHALI([In] this RigidTransform FKMNCAKIOFK)
	{
		return default(LocalPoseData);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x8408560", Offset = "0x8406B60", VA = "0x188408560")]
	public static RigidTransform NMBCNBHAJDL([In] this LocalPoseData FKMNCAKIOFK)
	{
		return default(RigidTransform);
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[TypeManager.ForcedStableTypeHash(2720902521635056246uL)]
	[RecRoom.DataLayer.RRGuid("0E9FADE9-751A-4A53-B455-4F8EA675754D")]
	[RecRoom.DataLayer.StableTypeHash(2720902521635056246uL, 0u)]
	[CompilerGenerated]
	public struct LocalUniformScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default(1f)]
		public float localUniformScale;
	}
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	[RecRoom.DataLayer.RRGuid("F01774C0-98E7-491E-AAA5-85B64AFFA182")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[TypeManager.ForcedStableTypeHash(5730545663584378555uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.StableTypeHash(5730545663584378555uL, 0u)]
	public struct TransformFlagsData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public CJMMDEBHJMA transformHint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(2)]
		public CPHNALMLPLL transformPriority;
	}
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	[RecRoom.DataLayer.RRGuid("392BF0C9-F464-491A-8725-E4B5E5C4ECD4")]
	[TypeManager.ForcedStableTypeHash(12583036596830542024uL)]
	[RecRoom.DataLayer.DoNotGenerateComponentProperties]
	public struct RRObjectPrefabData : ISharedComponentData, IEquatable<RRObjectPrefabData>, IComparable<RRObjectPrefabData>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public GJAKPPLFMHA prefabType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		[RecRoom.DataLayer.Field(2)]
		[RecRoom.DataLayer.Default]
		public Guid prefabGuid;

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x84088D0", Offset = "0x8406ED0", VA = "0x1884088D0")]
		public RRObjectPrefabData(Guid prefabGuid, GJAKPPLFMHA prefabType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x84087D0", Offset = "0x8406DD0", VA = "0x1884087D0", Slot = "4")]
		public readonly bool Equals(RRObjectPrefabData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x8408710", Offset = "0x8406D10", VA = "0x188408710", Slot = "0")]
		public override readonly bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x84088E0", Offset = "0x8406EE0", VA = "0x1884088E0")]
		public static bool operator ==(RRObjectPrefabData a, RRObjectPrefabData b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x8406130", Offset = "0x8404730", VA = "0x188406130", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x8405F40", Offset = "0x8404540", VA = "0x188405F40", Slot = "5")]
		public readonly int CompareTo(RRObjectPrefabData other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x8408830", Offset = "0x8406E30", VA = "0x188408830", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[RecRoom.DataLayer.RRGuid("FF90B503-A0B5-4B3D-BACF-046FA1456FBD")]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[TypeManager.ForcedStableTypeHash(17550159503907726442uL)]
	public struct ReferenceGroupKindData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public APBOCLHIEMC kind;
	}
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	[RecRoom.DataLayer.RRGuid("2C78EEBE-6DD9-44FF-A70D-6C2EE9BB8FB3")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[TypeManager.ForcedStableTypeHash(18363292822319307914uL)]
	[CompilerGenerated]
	public struct ReferenceGroupOwnerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public Entity owner;
	}
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[TypeManager.ForcedStableTypeHash(11947588904347318594uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("177498E9-83A6-4C2E-A8C1-B1951B47E74D")]
	public struct ReferenceGroupReferenceBuffer : IBufferElementData, BMIPOOOBAAO, IEquatable<ReferenceGroupReferenceBuffer>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public Entity reference;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public Entity Entity
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0xB41570", Offset = "0xB3FB70", VA = "0x180B41570", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x13E0130", Offset = "0x13DE730", VA = "0x1813E0130", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x84089D0", Offset = "0x8406FD0", VA = "0x1884089D0", Slot = "6")]
		public bool Equals(ReferenceGroupReferenceBuffer other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x8408940", Offset = "0x8406F40", VA = "0x188408940", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0xD94A80", Offset = "0xD93080", VA = "0x180D94A80", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007B")]
public struct NPNNPPNMHMP : IEqualityComparer<ReferenceGroupReferenceBuffer>
{
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public static NPNNPPNMHMP COLNIIHALMI;

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x8408180", Offset = "0x8406780", VA = "0x188408180", Slot = "4")]
	public bool Equals(ReferenceGroupReferenceBuffer POMPNNDHCKO, ReferenceGroupReferenceBuffer JLAHKMCOIFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0xBA89A0", Offset = "0xBA6FA0", VA = "0x180BA89A0", Slot = "5")]
	public int GetHashCode(ReferenceGroupReferenceBuffer NDBJJGOPOFO)
	{
		return default(int);
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("DE12A401-BD29-4B00-A629-7EFBECEDCFDF")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(17466046755328781668uL)]
	[InternalBufferCapacity(0)]
	public struct AuthoredUserTagReferenceBuffer : HPHPAPJGNBG, IBufferElementData, BMIPOOOBAAO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public Entity Child;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0xB41570", Offset = "0xB3FB70", VA = "0x180B41570", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x13E0130", Offset = "0x13DE730", VA = "0x1813E0130", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x13E0130", Offset = "0x13DE730", VA = "0x1813E0130")]
		public AuthoredUserTagReferenceBuffer(Entity entity)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0xE0C5B0", Offset = "0xE0ABB0", VA = "0x180E0C5B0")]
		public static AuthoredUserTagReferenceBuffer HPNBGLLBBBG(Entity entity)
		{
			return default(AuthoredUserTagReferenceBuffer);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public interface HPHPAPJGNBG : IBufferElementData, BMIPOOOBAAO
{
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	[RecRoom.DataLayer.RRGuid("00B7CB5E-4C0C-4D2C-AC95-78529EE58768")]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	[TypeManager.ForcedStableTypeHash(12148147190301245780uL)]
	public struct PersistentUserTagData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public FixedList32Bytes<int> tags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		[RecRoom.DataLayer.Field(2)]
		[RecRoom.DataLayer.Default(false)]
		public bool initalizedDefaults;
	}
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(1859693175312uL)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.StableTypeHash(1859693175312uL, 0u)]
	[RecRoom.DataLayer.RRGuid("80D85A55-B2F6-4860-A851-62973DC10940")]
	[SwatchPrimaryKey]
	public struct UserTagNameData : IComponentData, IEquatable<UserTagNameData>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public FixedString32Bytes Value;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x8408B10", Offset = "0x8407110", VA = "0x188408B10")]
		public UserTagNameData(string value)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x8408AD0", Offset = "0x84070D0", VA = "0x188408AD0")]
		public static UserTagNameData HPNBGLLBBBG(string value)
		{
			return default(UserTagNameData);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x84089F0", Offset = "0x8406FF0", VA = "0x1884089F0", Slot = "4")]
		public bool Equals(UserTagNameData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x8408A20", Offset = "0x8407020", VA = "0x188408A20", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x8408AC0", Offset = "0x84070C0", VA = "0x188408AC0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[InternalBufferCapacity(0)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("1E609F72-38C4-433D-BB17-B718F89DF446")]
	[TypeManager.ForcedStableTypeHash(2039749658960193818uL)]
	[CompilerGenerated]
	[RuntimeOnly]
	public struct UserTagReferenceBuffer : HPHPAPJGNBG, IBufferElementData, BMIPOOOBAAO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public Entity Child;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0xB41570", Offset = "0xB3FB70", VA = "0x180B41570", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x13E0130", Offset = "0x13DE730", VA = "0x1813E0130", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x13E0130", Offset = "0x13DE730", VA = "0x1813E0130")]
		public UserTagReferenceBuffer(Entity entity)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0xE0C5B0", Offset = "0xE0ABB0", VA = "0x180E0C5B0")]
		public static UserTagReferenceBuffer HPNBGLLBBBG(Entity entity)
		{
			return default(UserTagReferenceBuffer);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[CanDesync]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[TypeManager.ForcedStableTypeHash(1591066774816564574uL)]
	[RecRoom.DataLayer.StableTypeHash(1591066774816564574uL, 0u)]
	[ConfigGroup("Visual", 0)]
	[RecRoom.DataLayer.RRGuid("C36DDF08-CA52-4E33-8078-2F6E915D4FDA")]
	[CompilerGenerated]
	public struct StandardRenderableVisualData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		[Config(null, 0)]
		public DLKBGAHIKAB color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		[Config(null, 0)]
		[RecRoom.DataLayer.Field(2)]
		[RecRoom.DataLayer.Default]
		public BBOJGHFINDF material;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(3)]
		[Config(null, 0)]
		public float uvScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		[Config(null, 0)]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(4)]
		public float3 uvOffset;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.RRGuid("8D4C776C-B7A8-44BD-9901-159E4D1928F9")]
[RecRoom.DataLayer.Range(0, 255)]
public enum EMDHJAPEHGM : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	Banned = 1,
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	Host = 10,
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	Moderator = 20,
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	Contributor = 25,
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	CoOwner = 30,
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	TemporaryCoOwner = 31,
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	Creator = byte.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
[RecRoom.DataLayer.RRGuid("6B598497-D68A-4CC9-9D41-09EF6B966499")]
[RecRoom.DataLayer.Range(BKNAOBLPGDM.NONE, BKNAOBLPGDM.COUNT)]
[RecRoom.DataLayer.NetworkEnum(1, false)]
public enum BKNAOBLPGDM
{
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	NONE = 0,
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	[Config("Default (can transform roots, children are static)", 0)]
	Default = 1,
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	[Config("Can Transform (chips like SetPosition can modify)", 0)]
	CircuitsCanTransform = 2,
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	[Config("Always Static (chips cannot modify transform)", 0)]
	AlwaysStatic = 3,
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	COUNT = 4,
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	MAX = 4
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
[RecRoom.DataLayer.RRGuid("17517E1A-CF1A-48C9-B6A5-F9E42C1B9E96")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.Range(0, 4)]
public enum BIMGCHKCHIF
{
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	Box = 1,
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	Sphere = 2,
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	Capsule = 3,
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	Mesh = 4,
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	COUNT = 5,
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	MAX = 4
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
[Flags]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.RRGuid("A13F5102-9259-42B9-B782-BB7CC33A0C4F")]
[RecRoom.DataLayer.Range(NJCJNEOGKKD.NONE, NJCJNEOGKKD.ALL)]
public enum NJCJNEOGKKD
{
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	NONE = 0,
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	Object = 1,
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	Player = 2,
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	Projectile = 4,
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	Vehicle = 8,
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	ALL = 0xF
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
[RecRoom.DataLayer.Range(0, 127)]
[RecRoom.DataLayer.RRGuid("F843A776-E042-43B7-8167-0C7A421062F8")]
[RecRoom.DataLayer.NetworkEnum(2, false)]
public enum KBEFHOKOHMI : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	[@Tooltip("Indicating it can be walked on and moved")]
	[Config("Dynamic (Environment)", 0)]
	IsDynamicEnvironment = 0,
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	[Config("Dynamic", -1)]
	IsDynamic = 10,
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	[Config("Dynamic (Ignore Static Geometry)", 0)]
	IsDynamicIgnoreStaticGeometry = 11,
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	[Config("Dynamic (Ignore Other Dynamic)", 0)]
	IsDynamicIgnoreOtherDynamic = 12,
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	[Config("Dynamic (Ignore Players)", 0)]
	IsDynamicIgnorePlayers = 13,
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	[Config("Dynamic (Ignore Most)", 0)]
	IsDynamicIgnoreMost = 14,
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	[Config("Enemy Collision", 0)]
	IsEnemyCollision = 30,
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	[Config("Enemy Projectile", 0)]
	IsEnemyProjectile = 31,
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	[Config("Vehicle Physics", 0)]
	IsVehicleCollision = 40,
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	[ConfigIgnore]
	STATIC = 100,
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	[ConfigIgnore]
	DECORATION = 101,
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	MAX = 127
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
[RecRoom.DataLayer.Range(MCDIDCAJDOP.Off, MCDIDCAJDOP.COUNT)]
[RecRoom.DataLayer.RRGuid("9ADF7A0D-D808-48A7-BFCB-3272FB5D8A52")]
[RecRoom.DataLayer.NetworkEnum(2, false)]
public enum MCDIDCAJDOP : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	Off = 0,
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	Children = 1,
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	Hull = 2,
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	COUNT = 3,
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	MAX = 2
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
[RecRoom.DataLayer.RRGuid("0E5141AE-23E1-45A5-8BB0-04CC01E925E2")]
[RecRoom.DataLayer.Range(FIJDIDACNHL.None, FIJDIDACNHL.SnapLocked)]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[Flags]
public enum FIJDIDACNHL : byte
{
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	SnapLocked = 1,
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	All = 1,
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	Default = 0
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.RRGuid("3B156405-5769-4DB2-87EA-2B846AC4E584")]
[RecRoom.DataLayer.Range(0, 2)]
public enum PPBNHAEPJLD
{
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	Primitive = 1,
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	Spline = 2,
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	COUNT = 3,
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	MAX = 2
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
[RecRoom.DataLayer.NetworkEnum(2, false)]
[RecRoom.DataLayer.Range(EENGOGLBEIG.Pivot, EENGOGLBEIG.COUNT)]
[RecRoom.DataLayer.RRGuid("61EFE94A-235A-4281-B938-1A5BE32A18B1")]
public enum EENGOGLBEIG : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	Pivot = 0,
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	Bounds = 1,
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	COUNT = 2,
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	MAX = 1
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
[RecRoom.DataLayer.RRGuid("95D8649F-566A-409B-8090-61DA57EE41CC")]
[RecRoom.DataLayer.Range(DANGAEICKJF.Canyon, DANGAEICKJF.Random)]
[RecRoom.DataLayer.NetworkEnum(1, false)]
public enum DANGAEICKJF
{
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	Canyon,
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	Moon,
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	Bowl,
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	Hills,
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	Island,
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	Desert,
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	Random
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.Range(EKGHLLENOHA.EnabledForRole, EKGHLLENOHA.Disabled)]
[RecRoom.DataLayer.RRGuid("c0973732-e735-44cd-9727-a9a79bad01e3")]
public enum EKGHLLENOHA : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	EnabledForRole,
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	DisabledForRole,
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	Disabled
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
[RecRoom.DataLayer.RRGuid("7E7D5AA1-2EC9-488B-8AB2-703F13BCB8CF")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.Range(FDHJIACFCFO.NavMeshGenerator, FDHJIACFCFO.NavMeshBlocker)]
public enum FDHJIACFCFO
{
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	NavMeshGenerator = 0,
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	NavMeshIgnored = 1,
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	NavMeshBlocker = 2,
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	MAX = 2
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
[Flags]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.Range(AIGILGIOKEF.None, AIGILGIOKEF.All)]
[RecRoom.DataLayer.RRGuid("7B493897-FE06-4FC8-AB72-8B7BF5A313D3")]
public enum AIGILGIOKEF
{
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	All = 0x3FFF,
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	Default = 0x3FFF
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
[RecRoom.DataLayer.Range(0, CJAJHINJADJ.COUNT)]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.RRGuid("4427686F-E636-4F43-91F7-6BC74DEC584E")]
public enum CJAJHINJADJ
{
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	SupportsRotation,
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	SupportsDeformation,
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	SupportsScaling,
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	SupportsMirroring,
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	SupportsCloning,
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	SupportsRecoloring,
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	CanDestroy,
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	CanSaveIntoInventions,
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	SupportsRespawn,
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	SupportsMerging,
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	SupportsSplitting,
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	SupportsKeys,
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	CanEditWithMakerPen,
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	DEPRECATED_IsGrabbable,
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public static class HGABKCFPDCK
{
	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x84061B0", Offset = "0x84047B0", VA = "0x1884061B0")]
	public static void ADPGIIFDGLO(this AIGILGIOKEF OAKCIAMNOIJ, CJAJHINJADJ BBKAKIIKECB, bool COPJEOGEKIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x84061E0", Offset = "0x84047E0", VA = "0x1884061E0")]
	public static bool MMINCDOMDCO(this AIGILGIOKEF OAKCIAMNOIJ, CJAJHINJADJ BBKAKIIKECB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0xF5B340", Offset = "0xF59940", VA = "0x180F5B340")]
	public static AIGILGIOKEF MMKOCFFDBME(this CJAJHINJADJ BBKAKIIKECB)
	{
		return default(AIGILGIOKEF);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
[Flags]
[RecRoom.DataLayer.RRGuid("E3C51303-32F0-4EF4-8A66-C814E323653D")]
[RecRoom.DataLayer.NetworkEnum(2, false)]
[RecRoom.DataLayer.Range(KPKPCLALEAL.NONE, KPKPCLALEAL.COUNT)]
public enum KPKPCLALEAL
{
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	NONE = 0,
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	IsFrozen = 1,
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	IsGrabbable = 2,
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	PickUpDefaultToPlaceIfPhysical = 4,
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	COUNT = 5,
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	ALL = 5,
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	DEFAULT = 0
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
[RecRoom.DataLayer.Range(GJAKPPLFMHA.None, 8000)]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.RRGuid("777AD204-3AC0-41CE-BDC0-894C5821B3B9")]
public enum GJAKPPLFMHA
{
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	[Config("Container", 0)]
	Container = 1000,
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	[Config("Container", 0)]
	LegacyShapeContainer = 1001,
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	[Config("Container", 0)]
	CreationShapeContainer = 1002,
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	[Config("Empty", 0)]
	Empty = 4000,
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	[Config("Legacy Box", 0)]
	Shape_Primitive_LegacyBox = 2000,
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	[Config("Sphere", 0)]
	Shape_Primitive_Sphere = 2001,
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	[Config("Cylinder", 0)]
	Shape_Primitive_Cylinder = 2002,
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	[Config("Legacy Wedge", 0)]
	Shape_Primitive_LegacyWedge = 2003,
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	[Config("Legacy Pyramid", 0)]
	Shape_Primitive_LegacyPyramid = 2004,
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	[Config("Trigger Volume Box", 0)]
	Shape_Primitive_TriggerVolumeBox = 2005,
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	[Config("Box", 0)]
	Shape_Primitive_Box = 2006,
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	[Config("Rounded Box", 0)]
	Shape_Primitive_RoundedBox = 2007,
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	[Config("Wedge", 0)]
	Shape_Primitive_Wedge = 2008,
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	[Config("Pyramid", 0)]
	Shape_Primitive_Pyramid = 2009,
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	[Config("Half Sphere", 0)]
	Shape_Primitive_HalfSphere = 2010,
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	[Config("Cone", 0)]
	Shape_Primitive_Cone = 2011,
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	[Config("Pipe", 0)]
	Shape_Primitive_Pipe = 2012,
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	[Config("Donut", 0)]
	Shape_Primitive_Donut = 2013,
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	[Config("Half Pipe", 0)]
	Shape_Primitive_HalfPipe = 2014,
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	[Config("Diamond", 0)]
	Shape_Primitive_Diamond = 2015,
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	[Config("Mound", 0)]
	Shape_Primitive_Mound = 2016,
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	[Config("Cube (Simple)", 0)]
	Shape_Primitive_ADVANCED_Cube = 2017,
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	[Config("Sphere (Simple)", 0)]
	Shape_Primitive_ADVANCED_Sphere = 2018,
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	[Config("Cylinder (Simple)", 0)]
	Shape_Primitive_ADVANCED_Cylinder = 2019,
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	[Config("Cone (Simple)", 0)]
	Shape_Primitive_ADVANCED_Cone = 2020,
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	[Config("Pyramid (Simple)", 0)]
	Shape_Primitive_ADVANCED_Pyramid = 2021,
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	[Config("Octagon (Simple)", 0)]
	Shape_Primitive_ADVANCED_Octagon = 2022,
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	[Config("Triangle (Simple)", 0)]
	Shape_Primitive_ADVANCED_Triangle = 2023,
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	[Config("Hexagon (Simple)", 0)]
	Shape_Primitive_ADVANCED_Hexagon = 2024,
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	[Config("Quarter Pipe", 0)]
	Shape_Primitive_ADVANCED_QuarterPipe = 2025,
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	[Config("Pentagon (Simple)", 0)]
	Shape_Primitive_ADVANCED_Pentagon = 2026,
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	[Config("Dodecahedron", 0)]
	Shape_Primitive_ADVANCED_Dodecahedron = 2027,
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	[Config("Icosahedron", 0)]
	Shape_Primitive_ADVANCED_Trihedron = 2028,
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	[Config("Octahedron", 0)]
	Shape_Primitive_ADVANCED_Octahedron = 2029,
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	[Config("Quarter Cylinder", 0)]
	Shape_Primitive_RR_QuarterCylinder = 2030,
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	[Config("Pentagon", 0)]
	Shape_Primitive_RR_Pentagon = 2031,
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	[Config("Quarter Sphere", 0)]
	Shape_Primitive_RR_QuarterSphere = 2032,
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	[Config("Wedge (Simple)", 0)]
	Shape_Primitive_ADVANCED_Wedge = 2033,
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	[Config("Hexagon", 0)]
	Shape_Primitive_RR_Hexagon = 2034,
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	[Config("Octagon", 0)]
	Shape_Primitive_RR_Octagon = 2035,
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	[Config("Triangle", 0)]
	Shape_Primitive_RR_Triangle = 2036,
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	[Config("Spline", 0)]
	Shape_Spline = 3000,
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	[Config("Container Pivot", 0)]
	Other_ContainerPivot = 6000,
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	[Config("Spine Point", 0)]
	Other_SplinePoint = 6001,
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	[Config("Reference Point", 0)]
	Other_ReferencePoint = 6002,
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	[Config("UserTags", 0)]
	Other_UserTag = 6003,
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	[Config("Reference Group", 0)]
	Other_ReferenceGroup = 6004,
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	[Config("Interaction Filter", 0)]
	Other_InteractionFilterTags = 6005,
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	[ConfigIgnore]
	Other_DesyncNetworkObject = 6006,
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	[ConfigIgnore]
	NativeObject_SnapPoint = 5000,
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	[Config("Object", 0)]
	PrefabRootGameObject = 7000,
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	[Config("PrefabInternal", 0)]
	PrefabInternalGameObject = 7001,
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	[Config("Player", 0)]
	Player = 8000
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
public static class MDJGOOFFGHO
{
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	[CompilerGenerated]
	private sealed class FKFCEKJAKNL : IEnumerable<GJAKPPLFMHA>, IEnumerable, IEnumerator<GJAKPPLFMHA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		private GJAKPPLFMHA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		private IEnumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		private GJAKPPLFMHA System.Collections.Generic.IEnumerator<RecRoom.DataLayer.ObjectPrefabType>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0xAEAAE0", Offset = "0xAE90E0", VA = "0x180AEAAE0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(GJAKPPLFMHA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x8405E90", Offset = "0x8404490", VA = "0x188405E90", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x154FAF0", Offset = "0x154E0F0", VA = "0x18154FAF0")]
		[DebuggerHidden]
		public FKFCEKJAKNL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x8405EE0", Offset = "0x84044E0", VA = "0x188405EE0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x8405AD0", Offset = "0x84040D0", VA = "0x188405AD0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x8405D40", Offset = "0x8404340", VA = "0x188405D40")]
		private void OFOMAIJNFMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x8405E40", Offset = "0x8404440", VA = "0x188405E40", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x8405DA0", Offset = "0x84043A0", VA = "0x188405DA0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<GJAKPPLFMHA> System.Collections.Generic.IEnumerable<RecRoom.DataLayer.ObjectPrefabType>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x8405DA0", Offset = "0x84043A0", VA = "0x188405DA0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000095")]
	[CompilerGenerated]
	private sealed class EEJMDHBFFHI : IEnumerable<GJAKPPLFMHA>, IEnumerable, IEnumerator<GJAKPPLFMHA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private GJAKPPLFMHA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		private GJAKPPLFMHA <last>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		private GJAKPPLFMHA <i>5__3;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		private GJAKPPLFMHA System.Collections.Generic.IEnumerator<RecRoom.DataLayer.ObjectPrefabType>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0xAEAAE0", Offset = "0xAE90E0", VA = "0x180AEAAE0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(GJAKPPLFMHA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x8405670", Offset = "0x8403C70", VA = "0x188405670", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x154FAF0", Offset = "0x154E0F0", VA = "0x18154FAF0")]
		[DebuggerHidden]
		public EEJMDHBFFHI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x8405520", Offset = "0x8403B20", VA = "0x188405520", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x8405620", Offset = "0x8403C20", VA = "0x188405620", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x8405580", Offset = "0x8403B80", VA = "0x188405580", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<GJAKPPLFMHA> System.Collections.Generic.IEnumerable<RecRoom.DataLayer.ObjectPrefabType>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x8405580", Offset = "0x8403B80", VA = "0x188405580", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000096")]
	[CompilerGenerated]
	private sealed class IFIBHINGNDH : IEnumerable<GJAKPPLFMHA>, IEnumerable, IEnumerator<GJAKPPLFMHA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		private GJAKPPLFMHA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		private IEnumerator<GJAKPPLFMHA> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		private GJAKPPLFMHA System.Collections.Generic.IEnumerator<RecRoom.DataLayer.ObjectPrefabType>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0xAEAAE0", Offset = "0xAE90E0", VA = "0x180AEAAE0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(GJAKPPLFMHA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x8406F70", Offset = "0x8405570", VA = "0x188406F70", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x154FAF0", Offset = "0x154E0F0", VA = "0x18154FAF0")]
		[DebuggerHidden]
		public IFIBHINGNDH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x8406FC0", Offset = "0x84055C0", VA = "0x188406FC0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x8406B90", Offset = "0x8405190", VA = "0x188406B90", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x8406E30", Offset = "0x8405430", VA = "0x188406E30")]
		private void OFOMAIJNFMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x8406F20", Offset = "0x8405520", VA = "0x188406F20", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x8406E80", Offset = "0x8405480", VA = "0x188406E80", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<GJAKPPLFMHA> System.Collections.Generic.IEnumerable<RecRoom.DataLayer.ObjectPrefabType>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x8406E80", Offset = "0x8405480", VA = "0x188406E80", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x8407E50", Offset = "0x8406450", VA = "0x188407E50")]
	[IteratorStateMachine(typeof(FKFCEKJAKNL))]
	public static IEnumerable<GJAKPPLFMHA> NJMELBHMILN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x8407D90", Offset = "0x8406390", VA = "0x188407D90")]
	[IteratorStateMachine(typeof(EEJMDHBFFHI))]
	public static IEnumerable<GJAKPPLFMHA> ABKHKIGKDMB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x8407DF0", Offset = "0x84063F0", VA = "0x188407DF0")]
	[IteratorStateMachine(typeof(IFIBHINGNDH))]
	public static IEnumerable<GJAKPPLFMHA> GJBMDGKKMPO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public static class LCMJMJCOGFI
{
	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x8407830", Offset = "0x8405E30", VA = "0x188407830")]
	public static bool JMANAHDMBIJ(this RRObjectPrefabData HNHOCEELIEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x8407800", Offset = "0x8405E00", VA = "0x188407800")]
	public static bool JMANAHDMBIJ(this GJAKPPLFMHA EHLAHNIAPLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x8407860", Offset = "0x8405E60", VA = "0x188407860")]
	public static bool OKJBFHMJKAK(this RRObjectPrefabData HNHOCEELIEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x8407890", Offset = "0x8405E90", VA = "0x188407890")]
	public static bool OKJBFHMJKAK(this GJAKPPLFMHA EHLAHNIAPLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x84077B0", Offset = "0x8405DB0", VA = "0x1884077B0")]
	public static HCOAEMGEKKC GLNPCJGIMEJ(this GJAKPPLFMHA MMBNDPFHBFJ)
	{
		return default(HCOAEMGEKKC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x84077D0", Offset = "0x8405DD0", VA = "0x1884077D0")]
	internal static HEMMOJLMPPL IBNLFIBGLDI(this HCOAEMGEKKC JEMGDFOINDM)
	{
		return default(HEMMOJLMPPL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x84077E0", Offset = "0x8405DE0", VA = "0x1884077E0")]
	internal static HEMMOJLMPPL IBNLFIBGLDI(this GJAKPPLFMHA MMBNDPFHBFJ)
	{
		return default(HEMMOJLMPPL);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
internal enum HEMMOJLMPPL
{
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	Container = 1000,
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	Empty = 4000,
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	Primitive = 2000,
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	Spline = 3000,
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	Other = 6000,
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	NativeObject = 5000,
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	GameObject = 7000,
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	Player = 8000
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
[RecRoom.DataLayer.Range(0, 8)]
[RecRoom.DataLayer.RRGuid("A32413BC-21F3-4F7C-84B0-37724A854A67")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
public enum HCOAEMGEKKC
{
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	Container,
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	Primitive,
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	Spline,
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	Empty,
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	NativeObject,
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	Other,
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	GameObject,
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	Player
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
public static class FJFNLMFFCCG
{
	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x8405830", Offset = "0x8403E30", VA = "0x188405830")]
	public static bool MFHIKJPLLHI(this HCOAEMGEKKC JEMGDFOINDM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
[RecRoom.DataLayer.Range(0, DJIAOOPCFNI.ALL)]
[Flags]
[RecRoom.DataLayer.NetworkEnum(3, false)]
[RecRoom.DataLayer.RRGuid("7A0D34B5-FFE5-4C21-BB0C-CB3EBA34C797")]
public enum DJIAOOPCFNI : ushort
{
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	NONE = 0,
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	PhysicsEnabled = 1,
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	GravityEnabled = 2,
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	HasCustomMass = 4,
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	CollisionEvent = 0x40,
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	CanUse = 0x200,
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	CanClimb = 0x400,
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	CanWallRun = 0x800,
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	CanClamber = 0x1000,
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	CanTeleport = 0x2000,
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	SuppressCollision = 0x4000,
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	DEFAULT = 0x3800,
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	ALL = 0x7E47,
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	MAX = 0x7E47
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	[TypeManager.ForcedStableTypeHash(8060729269509364919uL)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.StableTypeHash(8060729269509364919uL, 0u)]
	[CompilerGenerated]
	[RecRoom.DataLayer.RRGuid("5D4503E7-6CC4-4938-8840-1B859C391878")]
	public struct PrimitiveShapeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public FNNLELJCGID shapeType;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
[RecRoom.DataLayer.Range(-1, 38)]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.RRGuid("517224CC-0A79-4FE9-B048-53C37955D823")]
public enum FNNLELJCGID
{
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	LegacyBox = 2,
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	RR_Sphere = 3,
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	RR_Cylinder = 4,
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	LEGACY_Wedge = 5,
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	LEGACY_Pyramid = 6,
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	LEGACY_TriggerVolumeBox = 7,
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	RR_Box = 8,
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	LEGACY_RoundedBox = 9,
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	RR_Wedge = 10,
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	RR_Pyramid = 11,
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	RR_HalfSphere = 12,
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	RR_Cone = 13,
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	RR_Pipe = 14,
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	RR_Donut = 15,
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	RR_HalfPipe = 16,
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	RR_Diamond = 17,
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	ADVANCED_Mound = 18,
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	ADVANCED_Cube = 19,
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	ADVANCED_Sphere = 20,
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	ADVANCED_Cylinder = 21,
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	ADVANCED_Cone = 22,
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	ADVANCED_Pyramid = 23,
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	ADVANCED_Octagon = 24,
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	ADVANCED_Triangle = 25,
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	ADVANCED_Hexagon = 26,
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	ADVANCED_QuarterPipe = 27,
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	ADVANCED_Pentagon = 28,
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	ADVANCED_Dodecahedron = 29,
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	ADVANCED_Trihedron = 30,
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	ADVANCED_Octahedron = 31,
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	RR_QuarterCylinder = 32,
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	RR_Pentagon = 33,
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	RR_QuarterSphere = 34,
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	ADVANCED_Wedge = 35,
	[Cpp2IlInjected.Token(Token = "0x4000207")]
	RR_Hexagon = 36,
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	RR_Octagon = 37,
	[Cpp2IlInjected.Token(Token = "0x4000209")]
	RR_Triangle = 38,
	[Cpp2IlInjected.Token(Token = "0x400020A")]
	COUNT = 39,
	[Cpp2IlInjected.Token(Token = "0x400020B")]
	MIN_VALUE = -1,
	[Cpp2IlInjected.Token(Token = "0x400020C")]
	MAX_VALUE = 38
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.Range(APBOCLHIEMC.None, APBOCLHIEMC.COUNT)]
[RecRoom.DataLayer.RRGuid("3D27DF09-CAE2-4C3F-B808-03AD605F8E98")]
public enum APBOCLHIEMC : byte
{
	[Cpp2IlInjected.Token(Token = "0x400020E")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400020F")]
	AnimationGroup = 1,
	[Cpp2IlInjected.Token(Token = "0x4000210")]
	COUNT = 2,
	[Cpp2IlInjected.Token(Token = "0x4000211")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000212")]
	MAX = 2
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.RRGuid("1829B7EA-C0EA-4E77-8EB2-BA23E995C860")]
[RecRoom.DataLayer.Range(0, 7)]
[Flags]
public enum DFBCNJDDJPE
{
	[Cpp2IlInjected.Token(Token = "0x4000214")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000215")]
	DynamicUVProjection = 1,
	[Cpp2IlInjected.Token(Token = "0x4000216")]
	PreventInvertedCreation = 2,
	[Cpp2IlInjected.Token(Token = "0x4000217")]
	NewBendLogic = 4,
	[Cpp2IlInjected.Token(Token = "0x4000218")]
	All = 7,
	[Cpp2IlInjected.Token(Token = "0x4000219")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x400021A")]
	MAX = 7
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
[Flags]
[RecRoom.DataLayer.Range(0, 7)]
[RecRoom.DataLayer.RRGuid("CCB58F66-EF02-476E-820F-9D593E2C3DE5")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
public enum EDHEHLCEEFH
{
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	IsRibbon = 1,
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	RoundedTubes = 2,
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	OldStyleCaps = 4,
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	All = 7,
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	MAX = 7
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.RRGuid("97516D96-FDF4-4ECC-881B-57A014A7D805")]
[RecRoom.DataLayer.Range(HIBCLHNAINH.Default, HIBCLHNAINH.Count)]
public enum HIBCLHNAINH
{
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	Import,
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	Generate,
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	Ignore,
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	Count
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.RRGuid("4913AA4C-C771-455C-AF49-938E5DEA653E")]
[RecRoom.DataLayer.Range(MEEOELBIEAK.Everywhere, MEEOELBIEAK.MAX)]
public enum MEEOELBIEAK : byte
{
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	Everywhere,
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	Center,
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	Edges,
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	North,
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	South,
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	East,
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	West,
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	RandomLines,
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	RandomBlobs,
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	MAX
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.Range(LKFHIDCNMGI.Normal, LKFHIDCNMGI.MAX)]
[RecRoom.DataLayer.RRGuid("4AD21D91-EFC4-4DAD-863D-4014EB5AB12D")]
public enum LKFHIDCNMGI : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	Normal,
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	Steep,
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	Mesa,
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	MAX
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
[RecRoom.DataLayer.Range(LMJANGHOCHE.GentleSlopes, LMJANGHOCHE.MAX)]
[RecRoom.DataLayer.RRGuid("4DAD40E0-53B5-4B82-B53A-BC3E96F9B507")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
public enum LMJANGHOCHE : byte
{
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	GentleSlopes,
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	RuggedSlopes,
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	Flat,
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	MediumSlopes,
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	RiverBed,
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	MAX
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.RRGuid("966E2586-2CE9-4280-898A-894565917A54")]
[RecRoom.DataLayer.Range(IDAMNGPLNCK.Circle, IDAMNGPLNCK.MAX)]
public enum IDAMNGPLNCK : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	Circle,
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	Square,
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	MAX
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
[RecRoom.DataLayer.Range(0, 1)]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.RRGuid("72742F9B-D48E-4CED-B403-444201FFEE66")]
[Flags]
public enum CJMMDEBHJMA
{
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	Static = 0,
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	Dynamic = 1,
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	All = 1
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
[RecRoom.DataLayer.Range(-2, 2)]
[RecRoom.DataLayer.RRGuid("C5BE1CDA-5EF5-4EBF-BC7E-3E3510C68A7F")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
public enum CPHNALMLPLL
{
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	Frozen = -2,
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	Low = -1,
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	Normal = 0,
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	High = 1,
	[Cpp2IlInjected.Token(Token = "0x400024E")]
	Realtime = 2,
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	Default = 0,
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	MIN = -2,
	[Cpp2IlInjected.Token(Token = "0x4000251")]
	MAX = 2
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.Range(int.MinValue, int.MaxValue)]
[RecRoom.DataLayer.RRGuid("D6AFAFED-8BAA-4499-9696-9CBB716EF514")]
public enum DLKBGAHIKAB
{
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x4000254")]
	Red = 0,
	[Cpp2IlInjected.Token(Token = "0x4000255")]
	Orange = 1,
	[Cpp2IlInjected.Token(Token = "0x4000256")]
	Yellow = 2,
	[Cpp2IlInjected.Token(Token = "0x4000257")]
	LightGreen = 3,
	[Cpp2IlInjected.Token(Token = "0x4000258")]
	Blue = 4,
	[Cpp2IlInjected.Token(Token = "0x4000259")]
	LightBlue = 5,
	[Cpp2IlInjected.Token(Token = "0x400025A")]
	Teal = 6,
	[Cpp2IlInjected.Token(Token = "0x400025B")]
	Green = 7,
	[Cpp2IlInjected.Token(Token = "0x400025C")]
	Purple = 8,
	[Cpp2IlInjected.Token(Token = "0x400025D")]
	LightPink = 9,
	[Cpp2IlInjected.Token(Token = "0x400025E")]
	Pink = 10,
	[Cpp2IlInjected.Token(Token = "0x400025F")]
	Brown = 11,
	[Cpp2IlInjected.Token(Token = "0x4000260")]
	Tan = 12,
	[Cpp2IlInjected.Token(Token = "0x4000261")]
	White = 13,
	[Cpp2IlInjected.Token(Token = "0x4000262")]
	Grey = 14,
	[Cpp2IlInjected.Token(Token = "0x4000263")]
	DarkGrey = 15,
	[Cpp2IlInjected.Token(Token = "0x4000264")]
	DarkBrown = 16,
	[Cpp2IlInjected.Token(Token = "0x4000265")]
	LightBrown = 17,
	[Cpp2IlInjected.Token(Token = "0x4000266")]
	LightGrey = 18,
	[Cpp2IlInjected.Token(Token = "0x4000267")]
	Black = 19,
	[Cpp2IlInjected.Token(Token = "0x4000268")]
	DarkRed = 20,
	[Cpp2IlInjected.Token(Token = "0x4000269")]
	DarkOrange = 21,
	[Cpp2IlInjected.Token(Token = "0x400026A")]
	DarkYellow = 22,
	[Cpp2IlInjected.Token(Token = "0x400026B")]
	DarkGreen = 23,
	[Cpp2IlInjected.Token(Token = "0x400026C")]
	DarkTeal = 24,
	[Cpp2IlInjected.Token(Token = "0x400026D")]
	DarkBlue = 25,
	[Cpp2IlInjected.Token(Token = "0x400026E")]
	DarkPurple = 26,
	[Cpp2IlInjected.Token(Token = "0x400026F")]
	DarkPink = 27,
	[Cpp2IlInjected.Token(Token = "0x4000270")]
	LightRed = 28,
	[Cpp2IlInjected.Token(Token = "0x4000271")]
	LightOrange = 29,
	[Cpp2IlInjected.Token(Token = "0x4000272")]
	LightYellow = 30,
	[Cpp2IlInjected.Token(Token = "0x4000273")]
	Cyan = 31,
	[Cpp2IlInjected.Token(Token = "0x4000274")]
	LightPurple = 32,
	[Cpp2IlInjected.Token(Token = "0x4000275")]
	DarkTan = 33,
	[Cpp2IlInjected.Token(Token = "0x4000276")]
	NewColor1 = 34,
	[Cpp2IlInjected.Token(Token = "0x4000277")]
	NewColor2 = 35,
	[Cpp2IlInjected.Token(Token = "0x4000278")]
	NewColor3 = 36,
	[Cpp2IlInjected.Token(Token = "0x4000279")]
	NewColor4 = 37,
	[Cpp2IlInjected.Token(Token = "0x400027A")]
	NewColor5 = 38,
	[Cpp2IlInjected.Token(Token = "0x400027B")]
	NewColor6 = 39,
	[Cpp2IlInjected.Token(Token = "0x400027C")]
	NewColor7 = 40,
	[Cpp2IlInjected.Token(Token = "0x400027D")]
	NewColor8 = 41,
	[Cpp2IlInjected.Token(Token = "0x400027E")]
	NewColor9 = 42,
	[Cpp2IlInjected.Token(Token = "0x400027F")]
	NewColor10 = 43,
	[Cpp2IlInjected.Token(Token = "0x4000280")]
	NewColor11 = 44,
	[Cpp2IlInjected.Token(Token = "0x4000281")]
	NewColor12 = 45,
	[Cpp2IlInjected.Token(Token = "0x4000282")]
	NewColor13 = 46,
	[Cpp2IlInjected.Token(Token = "0x4000283")]
	NewColor14 = 47,
	[Cpp2IlInjected.Token(Token = "0x4000284")]
	NewColor15 = 48,
	[Cpp2IlInjected.Token(Token = "0x4000285")]
	NewColor16 = 49,
	[Cpp2IlInjected.Token(Token = "0x4000286")]
	NewColor17 = 50,
	[Cpp2IlInjected.Token(Token = "0x4000287")]
	NewColor18 = 51,
	[Cpp2IlInjected.Token(Token = "0x4000288")]
	NewColor19 = 52,
	[Cpp2IlInjected.Token(Token = "0x4000289")]
	NewColor20 = 53,
	[Cpp2IlInjected.Token(Token = "0x400028A")]
	NewColor21 = 54,
	[Cpp2IlInjected.Token(Token = "0x400028B")]
	NewColor22 = 55,
	[Cpp2IlInjected.Token(Token = "0x400028C")]
	NewColor23 = 56,
	[Cpp2IlInjected.Token(Token = "0x400028D")]
	NewColor24 = 57,
	[Cpp2IlInjected.Token(Token = "0x400028E")]
	NewColor25 = 58,
	[Cpp2IlInjected.Token(Token = "0x400028F")]
	NewColor26 = 59,
	[Cpp2IlInjected.Token(Token = "0x4000290")]
	NewColor27 = 60,
	[Cpp2IlInjected.Token(Token = "0x4000291")]
	Default = 0
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
[RecRoom.DataLayer.Range(-1, 31)]
[RecRoom.DataLayer.RRGuid("C57BE511-BA1A-4D83-BA58-303F34F4DE74")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
public enum BBOJGHFINDF
{
	[Cpp2IlInjected.Token(Token = "0x4000293")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x4000294")]
	Cardboard = 0,
	[Cpp2IlInjected.Token(Token = "0x4000295")]
	Neon = 1,
	[Cpp2IlInjected.Token(Token = "0x4000296")]
	Brick = 2,
	[Cpp2IlInjected.Token(Token = "0x4000297")]
	Carpet = 3,
	[Cpp2IlInjected.Token(Token = "0x4000298")]
	Dirt = 4,
	[Cpp2IlInjected.Token(Token = "0x4000299")]
	Grass = 5,
	[Cpp2IlInjected.Token(Token = "0x400029A")]
	MetalReflective = 6,
	[Cpp2IlInjected.Token(Token = "0x400029B")]
	Concrete = 7,
	[Cpp2IlInjected.Token(Token = "0x400029C")]
	Linoleum = 8,
	[Cpp2IlInjected.Token(Token = "0x400029D")]
	Plaster = 9,
	[Cpp2IlInjected.Token(Token = "0x400029E")]
	WoodLogs = 10,
	[Cpp2IlInjected.Token(Token = "0x400029F")]
	WoodBoards = 11,
	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	WoodGrain = 12,
	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	WoodFloor = 13,
	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	Sand = 14,
	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	GlossyPlastic = 15,
	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	Cloth = 16,
	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	RubberFloor = 17,
	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	MetalFloorTread = 18,
	[Cpp2IlInjected.Token(Token = "0x40002A7")]
	PaintedBrick = 19,
	[Cpp2IlInjected.Token(Token = "0x40002A8")]
	Crashpad = 20,
	[Cpp2IlInjected.Token(Token = "0x40002A9")]
	PaintedWood = 21,
	[Cpp2IlInjected.Token(Token = "0x40002AA")]
	GripTape = 22,
	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	GalvanizedMetal = 23,
	[Cpp2IlInjected.Token(Token = "0x40002AC")]
	ParticleBoard = 24,
	[Cpp2IlInjected.Token(Token = "0x40002AD")]
	CheckeredFloor = 25,
	[Cpp2IlInjected.Token(Token = "0x40002AE")]
	SparklyVinyl = 26,
	[Cpp2IlInjected.Token(Token = "0x40002AF")]
	Gravel = 27,
	[Cpp2IlInjected.Token(Token = "0x40002B0")]
	Rock = 28,
	[Cpp2IlInjected.Token(Token = "0x40002B1")]
	Placeholder29 = 29,
	[Cpp2IlInjected.Token(Token = "0x40002B2")]
	Placeholder30 = 30,
	[Cpp2IlInjected.Token(Token = "0x40002B3")]
	Placeholder31 = 31,
	[Cpp2IlInjected.Token(Token = "0x40002B4")]
	COUNT = 32,
	[Cpp2IlInjected.Token(Token = "0x40002B5")]
	MIN = -1,
	[Cpp2IlInjected.Token(Token = "0x40002B6")]
	MAX = 31,
	[Cpp2IlInjected.Token(Token = "0x40002B7")]
	Default = 0
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
[RecRoom.DataLayer.RRGuid("CEFA84DC-B72D-4313-B0DB-FDFF30A6FCDC")]
[RecRoom.DataLayer.NetworkInterface(1, false)]
public interface KIDPBNIGCAD : HPCDMPIBNMN
{
	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	[Set.Any]
	[CanDesync]
	[RecRoom.DataLayer.Key("MP_MSF")]
	[RecRoom.DataLayer.Default]
	[RecRoom.DataLayer.Field(1)]
	FixedString32Bytes ILNBGOEMCAH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	[Set.Any]
	[RecRoom.DataLayer.Field(2)]
	[RuntimeOnly]
	[CanDesync]
	[RecRoom.DataLayer.Key("MP_MGR")]
	[RecRoom.DataLayer.Default]
	(long RequestId, int ActorNumber, int ServerTimestamp) IJJJFDCGLFA
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action AAOIHDEPDEK;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action MLCNJBOLPOM;
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
[RecRoom.DataLayer.NetworkInterface(1, false)]
[RecRoom.DataLayer.RRGuid("B23E7E5C-828C-4A29-9AB2-774DFC53D18E")]
public interface KMOLGOGOMLG : HPCDMPIBNMN
{
	[Cpp2IlInjected.Token(Token = "0x17000021")]
	[RecRoom.DataLayer.Default]
	[RecRoom.DataLayer.Key("SBDScale")]
	[RecRoom.DataLayer.Field(1)]
	[ProtoProp("PersistenceViewData.SandboxDeformationData.Deformation", typeof(LEJODJOIJLE))]
	[Set.Auth]
	float3 PFMPFEHANLN
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action GEEKBMHJKHF;
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
[RecRoom.DataLayer.RRGuid("112F004A-C92F-4055-99F9-D430EC13FE3C")]
[RecRoom.DataLayer.NetworkStruct(1, false)]
public struct EDCLCHHFDDJ : IComparable<EDCLCHHFDDJ>, IEquatable<EDCLCHHFDDJ>
{
	[Cpp2IlInjected.Token(Token = "0x40002B8")]
	public static readonly EDCLCHHFDDJ KBCDDOOGPEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	[RecRoom.DataLayer.Field(1)]
	public uint IMCMHIJKELF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	[RecRoom.DataLayer.Field(2)]
	public uint BCIIHCEPFND;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	private readonly uint OBAAKGPNJHI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x8404FD0", Offset = "0x84035D0", VA = "0x188404FD0")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public readonly bool EJBELALFPGK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x8405030", Offset = "0x8403630", VA = "0x188405030")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x8405440", Offset = "0x8403A40", VA = "0x188405440")]
	public EDCLCHHFDDJ(int IMCMHIJKELF, int PMCCEGNPAAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x8405440", Offset = "0x8403A40", VA = "0x188405440")]
	public EDCLCHHFDDJ(uint IMCMHIJKELF, uint PMCCEGNPAAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x84054A0", Offset = "0x8403AA0", VA = "0x1884054A0")]
	private EDCLCHHFDDJ(uint IMCMHIJKELF, uint PMCCEGNPAAK, bool IEHLOCAJNBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x8404F60", Offset = "0x8403560", VA = "0x188404F60")]
	public EDCLCHHFDDJ FCKFJDGOMEL(int EFCGAKGCCGN = 1)
	{
		return default(EDCLCHHFDDJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x8404EF0", Offset = "0x84034F0", VA = "0x188404EF0")]
	public EDCLCHHFDDJ FBFHDNJAAEN(int EFCGAKGCCGN = 1)
	{
		return default(EDCLCHHFDDJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x8405060", Offset = "0x8403660", VA = "0x188405060")]
	public static EDCLCHHFDDJ PFCHGOMFHEG(EDCLCHHFDDJ LEOAACGBJCD, EDCLCHHFDDJ GDBFOEGEGHN)
	{
		return default(EDCLCHHFDDJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x8404DF0", Offset = "0x84033F0", VA = "0x188404DF0")]
	private static ulong DHNIIMLEDLA(ulong IAFDMJDNHDH, ulong DFKKOPOBCBA)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x8404DD0", Offset = "0x84033D0", VA = "0x188404DD0", Slot = "4")]
	public int CompareTo(EDCLCHHFDDJ IBCMCOKAJEM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x8404E50", Offset = "0x8403450", VA = "0x188404E50", Slot = "0")]
	public override bool Equals(object NDBJJGOPOFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x8405360", Offset = "0x8403960", VA = "0x188405360", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x8404E30", Offset = "0x8403430", VA = "0x188404E30", Slot = "5")]
	public bool Equals(EDCLCHHFDDJ IBCMCOKAJEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x8404FE0", Offset = "0x84035E0", VA = "0x188404FE0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x3F3F600", Offset = "0x3F3DC00", VA = "0x183F3F600")]
	public static bool LMIMJGGKHMP(EDCLCHHFDDJ LEOAACGBJCD, EDCLCHHFDDJ GDBFOEGEGHN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x8405040", Offset = "0x8403640", VA = "0x188405040")]
	public static bool PACMOMIAEBP(EDCLCHHFDDJ LEOAACGBJCD, EDCLCHHFDDJ GDBFOEGEGHN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x8404DB0", Offset = "0x84033B0", VA = "0x188404DB0")]
	public static bool CCAINEPHDNP(EDCLCHHFDDJ LEOAACGBJCD, EDCLCHHFDDJ GDBFOEGEGHN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x8404D90", Offset = "0x8403390", VA = "0x188404D90")]
	public static bool BIJAGMEPPLL(EDCLCHHFDDJ LEOAACGBJCD, EDCLCHHFDDJ GDBFOEGEGHN)
	{
		return default(bool);
	}
}
namespace RecRoom.DataLayer
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	[RecRoom.DataLayer.RRGuid("D3AB0F52-EA41-4891-9470-6E945A9D6583")]
	[RecRoom.DataLayer.NetworkStruct(1, false)]
	public struct NetworkGuid : IEquatable<NetworkGuid>, IComparable<NetworkGuid>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		[RecRoom.DataLayer.Field(1)]
		public int4 data;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Guid Guid
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x1286740", Offset = "0x1284D40", VA = "0x181286740")]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x14EFE20", Offset = "0x14EE420", VA = "0x1814EFE20")]
			set
			{
			}
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x1286740", Offset = "0x1284D40", VA = "0x181286740")]
		public static Guid HPNBGLLBBBG(NetworkGuid CLPJLOJHBDJ)
		{
			return default(Guid);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x1286740", Offset = "0x1284D40", VA = "0x181286740")]
		public static NetworkGuid HPNBGLLBBBG(Guid CLPJLOJHBDJ)
		{
			return default(NetworkGuid);
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x84081A0", Offset = "0x84067A0", VA = "0x1884081A0", Slot = "4")]
		public bool Equals(NetworkGuid IBCMCOKAJEM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x6DE38B0", Offset = "0x6DE1EB0", VA = "0x186DE38B0", Slot = "5")]
		public int CompareTo(NetworkGuid IBCMCOKAJEM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x84081D0", Offset = "0x84067D0", VA = "0x1884081D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
[RecRoom.DataLayer.NetworkStruct(1, false)]
[RecRoom.DataLayer.RRGuid("9F5F33BE-7C0A-4870-9CE0-BA79440E7F98")]
public struct GAJCCCIGMFD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002BC")]
	[RecRoom.DataLayer.Field(1)]
	public bool ANBCINBEIHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40002BD")]
	[RecRoom.DataLayer.Field(2)]
	public float3 GNLDNDFAHPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002BE")]
	[RecRoom.DataLayer.Field(3)]
	public float3 NHLAECNDPON;

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x8402DB0", Offset = "0x84013B0", VA = "0x188402DB0")]
	public GAJCCCIGMFD(float AJNNFOKDGKA, float BHCLOJJFNGO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
[RecRoom.DataLayer.RRGuid("35984D5B-ACBD-4389-A94B-840070A871E2")]
[RecRoom.DataLayer.NetworkStruct(1, false)]
public struct EKPIPMMBPJG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002BF")]
	[RecRoom.DataLayer.Field(1)]
	public float BDJKCOLAJKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40002C0")]
	[RecRoom.DataLayer.Field(2)]
	public int FFOEEIHNLHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40002C1")]
	[RecRoom.DataLayer.Field(3)]
	public EDHEHLCEEFH OAKCIAMNOIJ;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public bool KBLBFPOEDPH
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x8405740", Offset = "0x8403D40", VA = "0x188405740")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x84056D0", Offset = "0x8403CD0", VA = "0x1884056D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public bool KDGEOLNDMEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x84056F0", Offset = "0x8403CF0", VA = "0x1884056F0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x8405720", Offset = "0x8403D20", VA = "0x188405720")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool IJLHGOCOMNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x84056C0", Offset = "0x8403CC0", VA = "0x1884056C0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x8405700", Offset = "0x8403D00", VA = "0x188405700")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
[RecRoom.DataLayer.NetworkStruct(1, false)]
[RecRoom.DataLayer.RRGuid("88EB8A39-C735-43FA-8414-C0B7AEEF4FF6")]
public struct NPDFLAAOGLM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002C2")]
	[RecRoom.DataLayer.Field(1)]
	public DLKBGAHIKAB CIDMFJFBPAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40002C3")]
	[RecRoom.DataLayer.Field(2)]
	public BBOJGHFINDF KKHKBMDNDFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40002C4")]
	[RecRoom.DataLayer.Field(3)]
	public DLKBGAHIKAB JMIFNOAMBOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40002C5")]
	[RecRoom.DataLayer.Field(4)]
	public BBOJGHFINDF OHDAGLBDFHJ;
}
namespace RecRoom.DataLayer
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	[RecRoom.DataLayer.NetworkStruct(1, false)]
	[RecRoom.DataLayer.RRGuid("CE1911D2-B422-4E58-B0D6-2474AEA69D41")]
	public struct TerrainGenerationLayer
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		[RecRoom.DataLayer.Field(1)]
		public LMJANGHOCHE TerrainRoughness;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		[RecRoom.DataLayer.Field(2)]
		public MEEOELBIEAK TerrainShape;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		[RecRoom.DataLayer.Field(3)]
		public LKFHIDCNMGI HeightFunction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		[RecRoom.DataLayer.Field(4)]
		public float FeatureScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		[RecRoom.DataLayer.Field(5)]
		public float Height;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
public struct HINBANPDLCM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002CB")]
	public AFHMAGIABHM AEJAJAHGPIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40002CC")]
	public int PAMLONENLCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40002CD")]
	public bool LPKIDOLJMEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD")]
	[Cpp2IlInjected.Token(Token = "0x40002CE")]
	public bool NGLJFGHJJOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE")]
	[Cpp2IlInjected.Token(Token = "0x40002CF")]
	public bool NKJLFNAOCIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002D0")]
	public Vector3 IIKJNDDFMGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40002D1")]
	public Quaternion NEMGOCEHIKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40002D2")]
	public bool BDMHLKANNMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002D3")]
	public Vector3 PFMPFEHANLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40002D4")]
	public Vector3 NMGPFPNENEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40002D5")]
	public Vector3 HCCPKBJIKFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x40002D6")]
	public bool HHOODKCFBIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40002D7")]
	public ViewId AKDEKCGBMCH;

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x8406200", Offset = "0x8404800", VA = "0x188406200", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
public struct GHNOPBMMBDI : IEquatable<GHNOPBMMBDI>, IComparable<GHNOPBMMBDI>
{
	[Cpp2IlInjected.Token(Token = "0x40002D8")]
	public static readonly int BBFGCKNDLEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	public RRObjectPrefabData EEGMKGNBEOE;

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x8406160", Offset = "0x8404760", VA = "0x188406160", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x84060C0", Offset = "0x84046C0", VA = "0x1884060C0", Slot = "4")]
	public bool Equals(GHNOPBMMBDI IBCMCOKAJEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x8405FC0", Offset = "0x84045C0", VA = "0x188405FC0", Slot = "0")]
	public override bool Equals(object NDBJJGOPOFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x8406130", Offset = "0x8404730", VA = "0x188406130", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x8405F40", Offset = "0x8404540", VA = "0x188405F40", Slot = "5")]
	public int CompareTo(GHNOPBMMBDI IBCMCOKAJEM)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
internal class NNEHHFIMIOK : ContainerPropertyBag<NHGAECOMCAG>
{
	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x8408120", Offset = "0x8406720", VA = "0x188408120")]
	public NNEHHFIMIOK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
internal class FJOKLNKGPPE : ContainerPropertyBag<RRObjectPrefabData>
{
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	private class PBFFJNKPONI : Property<RRObjectPrefabData, GJAKPPLFMHA>
	{
		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public override string CLGAHBNBCJM
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x8408500", Offset = "0x8406B00", VA = "0x188408500", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public override bool HBGKHJAILJC
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0xAE06A0", Offset = "0xADECA0", VA = "0x180AE06A0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x8408410", Offset = "0x8406A10", VA = "0x188408410")]
		public PBFFJNKPONI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x14735D0", Offset = "0x1471BD0", VA = "0x1814735D0", Slot = "14")]
		public override GJAKPPLFMHA GetValue(RRObjectPrefabData LOLOEONEEKB)
		{
			return default(GJAKPPLFMHA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x8402AB0", Offset = "0x84010B0", VA = "0x188402AB0", Slot = "15")]
		public override void SetValue(RRObjectPrefabData LOLOEONEEKB, GJAKPPLFMHA FKMNCAKIOFK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	private class LAEPCKHENLD : Property<RRObjectPrefabData, Guid>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public override string CLGAHBNBCJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x8407780", Offset = "0x8405D80", VA = "0x188407780", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override bool HBGKHJAILJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0xAE06A0", Offset = "0xADECA0", VA = "0x180AE06A0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x8407690", Offset = "0x8405C90", VA = "0x188407690")]
		public LAEPCKHENLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x2CD0E10", Offset = "0x2CCF410", VA = "0x182CD0E10", Slot = "14")]
		public override Guid GetValue(RRObjectPrefabData LOLOEONEEKB)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x8407680", Offset = "0x8405C80", VA = "0x188407680", Slot = "15")]
		public override void SetValue(RRObjectPrefabData LOLOEONEEKB, Guid FKMNCAKIOFK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x8405840", Offset = "0x8403E40", VA = "0x188405840")]
	public FJOKLNKGPPE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
internal class APIDKNLBNOH : ContainerPropertyBag<Guid>
{
	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x84044D0", Offset = "0x8402AD0", VA = "0x1884044D0")]
	public APIDKNLBNOH()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x8408590", Offset = "0x8406B90", VA = "0x188408590")]
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
