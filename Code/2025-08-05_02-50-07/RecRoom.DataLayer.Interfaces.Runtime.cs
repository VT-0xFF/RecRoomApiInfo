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
		[Cpp2IlInjected.Address(RVA = "0xA98EF0", Offset = "0xA982F0", VA = "0x180A98EF0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA98EF0", Offset = "0xA982F0", VA = "0x180A98EF0")]
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
	public class LogRegistrationIndex : FIPEGIMCDPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x824FEB0", Offset = "0x824F2B0", VA = "0x18824FEB0", Slot = "4")]
		public override void AAGBOPIEMBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA98EF0", Offset = "0xA982F0", VA = "0x180A98EF0")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct FBAIIMBPKEL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private bool HKFFCGICBIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private ViewId MIMIGBMDBGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private int FDIDNNCIDHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private bool OMBCDAEENCG;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x824EFB0", Offset = "0x824E3B0", VA = "0x18824EFB0")]
	public FBAIIMBPKEL(ViewId MIMIGBMDBGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x824EF70", Offset = "0x824E370", VA = "0x18824EF70")]
	public FBAIIMBPKEL(int FDIDNNCIDHK, bool OMBCDAEENCG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x824EE90", Offset = "0x824E290", VA = "0x18824EE90")]
	public ViewId KNOGMOEONAK([Optional] ViewId ENBOBCPEHLE)
	{
		return default(ViewId);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class MCCLENDDGHD
{
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly Guid FEHBHKOPOFL;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static readonly Guid NFIFDFGJHMF;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static readonly Guid APLOMNFAKHN;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public static readonly Guid NGMHBMOPCNL;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly Guid JHAFJNJEPIF;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public static readonly Dictionary<string, Guid> FBMCKIOPECL;

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static readonly RRObjectPrefabData MGONDDPPLGC;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly RRObjectPrefabData IILAEJNFGFN;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly RRObjectPrefabData LCKKNBMHMBC;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x8250200", Offset = "0x824F600", VA = "0x188250200")]
	public static Guid PHEAGILENIN(string HDNPPEBJPAE)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x8250190", Offset = "0x824F590", VA = "0x188250190")]
	public static RRObjectPrefabData JKFIBNKOPFJ(KEPNMPHCHCC IIHAKBEOLJD)
	{
		return default(RRObjectPrefabData);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x8250140", Offset = "0x824F540", VA = "0x188250140")]
	public static RRObjectPrefabData DOGAKAPGLCD(KEPNMPHCHCC IIHAKBEOLJD)
	{
		return default(RRObjectPrefabData);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x8250120", Offset = "0x824F520", VA = "0x188250120")]
	public static RRObjectPrefabData CLCKMAJDBPI(Guid OOOANFDGEED)
	{
		return default(RRObjectPrefabData);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[DefaultMember("Item")]
public class KFNNMIHFMBA : IComponentData, ICloneable, JGINFHKGIOJ
{
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static readonly AKNCNLDICPO CCLJCJDJCOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly Dictionary<int, object> NGIAGNLBILI;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public Dictionary<int, object> NMPPAMCHJMA
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public object FMHPKKMCCLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x824F280", Offset = "0x824E680", VA = "0x18824F280")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x824F490", Offset = "0x824E890", VA = "0x18824F490")]
	public KFNNMIHFMBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0xA75990", Offset = "0xA74D90", VA = "0x180A75990")]
	public KFNNMIHFMBA(Dictionary<int, object> NGIAGNLBILI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x824F3E0", Offset = "0x824E7E0", VA = "0x18824F3E0", Slot = "5")]
	public bool JMMHHDIDKDC(JLPPDAJAOIB PEENICAIFOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x824F2E0", Offset = "0x824E6E0", VA = "0x18824F2E0", Slot = "6")]
	public void GIBILGFPOJB(AKNCNLDICPO CCLJCJDJCOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x3D7BB80", Offset = "0x3D7AF80", VA = "0x183D7BB80")]
	public void CDJMBKGCJMN<T>(JLPPDAJAOIB PEENICAIFOP, T CBMEHPPMEEA, [Optional] T ABINAMGBLJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3D7C030", Offset = "0x3D7B430", VA = "0x183D7C030")]
	public void LFFCNKDPJLH<T>(JLPPDAJAOIB PEENICAIFOP, T CBMEHPPMEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x824F1B0", Offset = "0x824E5B0", VA = "0x18824F1B0")]
	public void CBDHBFLGDII(JLPPDAJAOIB PEENICAIFOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x824F210", Offset = "0x824E610", VA = "0x18824F210", Slot = "4")]
	public object Clone()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum JLPPDAJAOIB : byte
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
public struct LNCBEEHHKEA<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly JLPPDAJAOIB PEENICAIFOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly T ABINAMGBLJP;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x54DB8C0", Offset = "0x54DACC0", VA = "0x1854DB8C0")]
	public LNCBEEHHKEA(JLPPDAJAOIB PEENICAIFOP, T ABINAMGBLJP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x558C4F0", Offset = "0x558B8F0", VA = "0x18558C4F0")]
	public static LNCBEEHHKEA<T> GKKMDDPCKIG(JLPPDAJAOIB PEENICAIFOP)
	{
		return default(LNCBEEHHKEA<T>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x558C300", Offset = "0x558B700", VA = "0x18558C300")]
	public static LNCBEEHHKEA<T> GKKMDDPCKIG((JLPPDAJAOIB key, T value) HCFCOMCPJPA)
	{
		return default(LNCBEEHHKEA<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface JGINFHKGIOJ
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JMMHHDIDKDC(JLPPDAJAOIB PEENICAIFOP);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GIBILGFPOJB(AKNCNLDICPO CCLJCJDJCOE);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[DebuggerTypeProxy(typeof(KENJIMDKCIP))]
[DebuggerDisplay("Count = {Count}")]
public struct NALOKHDCBNN : IEnumerable<object>, IEnumerable, JGINFHKGIOJ
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	private class KENJIMDKCIP : Dictionary<string, object>
	{
	}

	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private static readonly AKNCNLDICPO CCLJCJDJCOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private Dictionary<int, object> FGEMBJJOPFK;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool AJBBOECICAG
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x19CEBA0", Offset = "0x19CDFA0", VA = "0x1819CEBA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int JGJMKJIDNDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8250A70", Offset = "0x824FE70", VA = "0x188250A70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x82509F0", Offset = "0x824FDF0", VA = "0x1882509F0")]
	public static NALOKHDCBNN CEOONNIFPHP()
	{
		return default(NALOKHDCBNN);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0xE62750", Offset = "0xE61B50", VA = "0x180E62750")]
	public NALOKHDCBNN([Optional] Dictionary<int, object> FGEMBJJOPFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x3E54700", Offset = "0x3E53B00", VA = "0x183E54700")]
	public void KOBMLIBBKBO<T>(LNCBEEHHKEA<T> PEENICAIFOP, T? CBMEHPPMEEA) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x3E54530", Offset = "0x3E53930", VA = "0x183E54530")]
	public void KOBMLIBBKBO<T>((LNCBEEHHKEA<T> key, T value) ABCLNLLIHOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3E545A0", Offset = "0x3E539A0", VA = "0x183E545A0")]
	public void KOBMLIBBKBO<T>(LNCBEEHHKEA<T> PEENICAIFOP, T CBMEHPPMEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x8250CF0", Offset = "0x82500F0", VA = "0x188250CF0")]
	public void NFFFKIMBGDJ(NALOKHDCBNN BEOBAPANJHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x8250C10", Offset = "0x8250010", VA = "0x188250C10")]
	private void IPJPKJAMFMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3E526C0", Offset = "0x3E51AC0", VA = "0x183E526C0")]
	public bool EGMGAAFJGGH<T>(LNCBEEHHKEA<T> PEENICAIFOP, [Out] T CBMEHPPMEEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3E51F40", Offset = "0x3E51340", VA = "0x183E51F40", Slot = "8")]
	public bool EGMGAAFJGGH<T>(JLPPDAJAOIB PEENICAIFOP, [Out] T CBMEHPPMEEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3E54110", Offset = "0x3E53510", VA = "0x183E54110")]
	public T JBLGKLGAMJI<T>(LNCBEEHHKEA<T> PEENICAIFOP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3E54410", Offset = "0x3E53810", VA = "0x183E54410")]
	public bool JMMHHDIDKDC<T>(LNCBEEHHKEA<T> PEENICAIFOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x8250C90", Offset = "0x8250090", VA = "0x188250C90", Slot = "6")]
	public bool JMMHHDIDKDC(JLPPDAJAOIB PEENICAIFOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3E51C30", Offset = "0x3E51030", VA = "0x183E51C30")]
	public void CBDHBFLGDII<T>(LNCBEEHHKEA<T> PEENICAIFOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x82509A0", Offset = "0x824FDA0", VA = "0x1882509A0")]
	public void CBDHBFLGDII(JLPPDAJAOIB PEENICAIFOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0xAF6920", Offset = "0xAF5D20", VA = "0x180AF6920")]
	public Dictionary<int, object> IMODHHIDFFG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x8250BB0", Offset = "0x824FFB0", VA = "0x188250BB0", Slot = "4")]
	public IEnumerator<object> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x8250F00", Offset = "0x8250300", VA = "0x188250F00", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x8250AC0", Offset = "0x824FEC0", VA = "0x188250AC0", Slot = "7")]
	public void GIBILGFPOJB(AKNCNLDICPO CCLJCJDJCOE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public enum LEKBACCJJCH
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
public interface JHFFNIJDHNE
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public enum MFFEPOOEKKF
	{
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		Entity,
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		Prefab
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	LocalId KADHGKILELJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	RRObjectPrefabData FGEMFJIOEMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JJGFIAINCHP(params string[] AOIOCLJAONJ);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HILAKNIJNCB(LEKBACCJJCH PNJCPIKINJK, MFFEPOOEKKF KLNPGHMOELH = MFFEPOOEKKF.Entity);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JBGCFHFMKPC(Type IIHAKBEOLJD, ReadOnlySpan<byte> NGIAGNLBILI, int GINIKDBJGMP, MFFEPOOEKKF KLNPGHMOELH = MFFEPOOEKKF.Entity);

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BDPLACJEOHJ(Type IIHAKBEOLJD, MFFEPOOEKKF KLNPGHMOELH = MFFEPOOEKKF.Entity);

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void IBAEGMLALEJ(LEKBACCJJCH PNJCPIKINJK, MFFEPOOEKKF KLNPGHMOELH = MFFEPOOEKKF.Entity);

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool FLNNLMLNOOA(LEKBACCJJCH PNJCPIKINJK);

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void LDHAIHGECKK(bool HDNLCPOBGMI, MFFEPOOEKKF KLNPGHMOELH = MFFEPOOEKKF.Entity);

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void NNLIIBHKPGM();

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void GGMJJDNMAOB(Type IIHAKBEOLJD);

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "11")]
	DCDKAIBLHNM HAJPMLJIPLH(Type IIHAKBEOLJD);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class MKGAEOBKDAJ
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x82506E0", Offset = "0x824FAE0", VA = "0x1882506E0")]
	public static bool KKJABBLDAEG(this JHFFNIJDHNE HFJHENFIDEF, LEKBACCJJCH JFINDLBKLHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x82508E0", Offset = "0x824FCE0", VA = "0x1882508E0")]
	public static void LJADEKKMBHB(this JHFFNIJDHNE HFJHENFIDEF, JHFFNIJDHNE.MFFEPOOEKKF KLNPGHMOELH = JHFFNIJDHNE.MFFEPOOEKKF.Entity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x8250940", Offset = "0x824FD40", VA = "0x188250940")]
	public static void NPHIDLMBFGL(this JHFFNIJDHNE HFJHENFIDEF, JHFFNIJDHNE.MFFEPOOEKKF KLNPGHMOELH = JHFFNIJDHNE.MFFEPOOEKKF.Entity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3DF5070", Offset = "0x3DF4470", VA = "0x183DF5070")]
	public static void OLLOCHGEIPJ<T>(this JHFFNIJDHNE HFJHENFIDEF, JHFFNIJDHNE.MFFEPOOEKKF KLNPGHMOELH = JHFFNIJDHNE.MFFEPOOEKKF.Entity) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3CA01F0", Offset = "0x3C9F5F0", VA = "0x183CA01F0")]
	public static void EKNELIMDFFM<T>(this JHFFNIJDHNE HFJHENFIDEF, JHFFNIJDHNE.MFFEPOOEKKF KLNPGHMOELH = JHFFNIJDHNE.MFFEPOOEKKF.Entity) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3DF33B0", Offset = "0x3DF27B0", VA = "0x183DF33B0")]
	public static void FLEFOPIPNLH<T>(this JHFFNIJDHNE HFJHENFIDEF, bool IODKPAGIFAI, JHFFNIJDHNE.MFFEPOOEKKF KLNPGHMOELH = JHFFNIJDHNE.MFFEPOOEKKF.Entity) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x3DF34D0", Offset = "0x3DF28D0", VA = "0x183DF34D0")]
	public static void JBGCFHFMKPC<T>(this JHFFNIJDHNE HFJHENFIDEF, T CBMEHPPMEEA, JHFFNIJDHNE.MFFEPOOEKKF KLNPGHMOELH = JHFFNIJDHNE.MFFEPOOEKKF.Entity) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3DF31D0", Offset = "0x3DF25D0", VA = "0x183DF31D0")]
	public static void BDPLACJEOHJ<T>(this JHFFNIJDHNE HFJHENFIDEF, JHFFNIJDHNE.MFFEPOOEKKF KLNPGHMOELH = JHFFNIJDHNE.MFFEPOOEKKF.Entity) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3DF33E0", Offset = "0x3DF27E0", VA = "0x183DF33E0")]
	public static void GGMJJDNMAOB<T>(this JHFFNIJDHNE HFJHENFIDEF) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3DF5090", Offset = "0x3DF4490", VA = "0x183DF5090")]
	public static void PLPCNMHAAKL<T>(this JHFFNIJDHNE HFJHENFIDEF, LocalId HNIIKCBNMGN, JHFFNIJDHNE.MFFEPOOEKKF KLNPGHMOELH = JHFFNIJDHNE.MFFEPOOEKKF.Entity) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3DF3590", Offset = "0x3DF2990", VA = "0x183DF3590")]
	private static void JBGCFHFMKPC<T>(this JHFFNIJDHNE HFJHENFIDEF, Type IIHAKBEOLJD, T CBMEHPPMEEA, JHFFNIJDHNE.MFFEPOOEKKF KLNPGHMOELH = JHFFNIJDHNE.MFFEPOOEKKF.Entity) where T : struct
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct GHOGGHFCKAI
{
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface OBHJLGHKFJO
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	Entity DFHPPODNHFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface DOMLIJNADCE
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "0")]
	void PreBake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Bake(JHFFNIJDHNE HFJHENFIDEF);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface KNGPDMLDJHE
{
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	DCDKAIBLHNM AECGBGCFEMK(Type IIHAKBEOLJD);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class CAHGDLKINKO
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x3A9D8B0", Offset = "0x3A9CCB0", VA = "0x183A9D8B0")]
	public static void AECGBGCFEMK<T>(this KNGPDMLDJHE HFJHENFIDEF, [Out] T CBMEHPPMEEA) where T : DCDKAIBLHNM
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface DCDKAIBLHNM
{
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class CPEIOKJAJGK
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x3AB0560", Offset = "0x3AAF960", VA = "0x183AB0560")]
	public static void BBDGGLPIBGJ<T>(this JHFFNIJDHNE HFJHENFIDEF) where T : DCDKAIBLHNM, MLCHICODICF, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x3AB0610", Offset = "0x3AAFA10", VA = "0x183AB0610")]
	public static void FEFDLHFNFMH<T>(this T HGPMENNMCEA, JHFFNIJDHNE HFJHENFIDEF) where T : DCDKAIBLHNM, MLCHICODICF
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x3AB06B0", Offset = "0x3AAFAB0", VA = "0x183AB06B0")]
	public static bool KHMHFDCLMBA<T>(this T CHKMMJGEHPI) where T : DCDKAIBLHNM
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface MLCHICODICF
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	Type ONNPDPBAGIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AHINEHNEJJM(DCDKAIBLHNM CHKMMJGEHPI);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface EIPBMJPCDEK : DOMLIJNADCE
{
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void InitNetworkData(KNGPDMLDJHE HFJHENFIDEF);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface PPMBIINKLOC : DCDKAIBLHNM
{
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface JEOBLPECIJA
{
	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DNHJDLIIODA(NNAECDFEPDN BDBJAOEOBNM);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MMBAEIEOJOK(NNAECDFEPDN BDBJAOEOBNM);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface BODNLDOFCKL
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	ViewId JNIGAHJGKFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface CEBAJGBFBNL : BODNLDOFCKL, HJLMOCPJLCP
{
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void Initialize(ViewId LPOADEEILAO, ViewId FJKHJKAHEMG, Dictionary<int, object> JAIKDDBMDJG, NNAECDFEPDN CCGANJILKHA);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface MECLGJLEBLN : BODNLDOFCKL
{
	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PJOFCLDPLJB(DNOIABBOEPJ JIECBJMGMAC, Vector3 IPGNGMJBFOL, Quaternion JJPOMEGMBHP, Vector3 GAPOEDFJKKB, bool JEDOPOILNPO);

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LNNGPHGOKAM(Vector3 IPGNGMJBFOL, Quaternion JJPOMEGMBHP, Vector3 GAPOEDFJKKB);

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PPKDCGAIMAJ(ViewId JIECBJMGMAC);

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FBGGJKMFEFA(bool GKEMFOHLFEH);

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DKOCLMDLDIO(bool JCIMDFEHIJG);
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface HJLMOCPJLCP
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NKNCDILNOJO();
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface KOBELPGPMPF
{
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NativeArray<Guid> FJCNDGHJKCI(World BADONBAKCJC, NativeArray<Entity> FGABDCIOGLK, Allocator KCEIEKBPKNP);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface OEHCPCJJKEN
{
	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ANHDHIGPMFL(Entity MEOOAHKPJCE, int MNJLHCOPBOJ);

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MGJNAPPPCJL(Entity MEOOAHKPJCE, int MNJLHCOPBOJ);

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ReadOnlySpan<byte> OPLPPCPDAFN(Entity MEOOAHKPJCE, int MNJLHCOPBOJ);

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void AGKLFOLPHOI(Entity MEOOAHKPJCE, int MNJLHCOPBOJ, ReadOnlySpan<byte> CBMEHPPMEEA);

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JFCBNBFMPGL(Entity MEOOAHKPJCE, int MNJLHCOPBOJ, Action BFDLNHAHOHH);

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void IICLMLNKEIE(Entity MEOOAHKPJCE, int MNJLHCOPBOJ, Action BFDLNHAHOHH);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public static class EMLPHPPKDHC
{
	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x3B3FBC0", Offset = "0x3B3EFC0", VA = "0x183B3FBC0")]
	public static T IJPOJCGHLJJ<T>(this OEHCPCJJKEN CFCJIOONHFB, Entity MEOOAHKPJCE, int MNJLHCOPBOJ) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x3B3F870", Offset = "0x3B3EC70", VA = "0x183B3F870")]
	public static void CIDECNHJJHJ<T>(this OEHCPCJJKEN CFCJIOONHFB, Entity MEOOAHKPJCE, int MNJLHCOPBOJ, T CBMEHPPMEEA) where T : struct
	{
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[TypeManager.ForcedStableTypeHash(9635027148749164348uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.RRGuid("6241769E-7423-45E5-B125-9F7EAA5D5232")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct AiCodeGenIdData : IComponentData, IEquatable<AiCodeGenIdData>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public FixedString64Bytes Value;

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x824E3A0", Offset = "0x824D7A0", VA = "0x18824E3A0", Slot = "4")]
		public bool Equals(AiCodeGenIdData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x824E3E0", Offset = "0x824D7E0", VA = "0x18824E3E0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x824E4A0", Offset = "0x824D8A0", VA = "0x18824E4A0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(3758703684052595571uL)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("399DD840-DE45-43FA-9EB0-5E80BC93C8CB")]
	public struct AiCodeGenNameData : IComponentData, IEquatable<AiCodeGenNameData>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public FixedString64Bytes Value;

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x824E3A0", Offset = "0x824D7A0", VA = "0x18824E3A0", Slot = "4")]
		public bool Equals(AiCodeGenNameData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x824E4B0", Offset = "0x824D8B0", VA = "0x18824E4B0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x824E4A0", Offset = "0x824D8A0", VA = "0x18824E4A0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public struct DDFGPEIEKGC : IComponentData, IEquatable<DDFGPEIEKGC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	[RecRoom.DataLayer.Field(1)]
	[RecRoom.DataLayer.Default]
	public uint JCMAOCOGHGO;

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x824E570", Offset = "0x824D970", VA = "0x18824E570", Slot = "4")]
	public bool Equals(DDFGPEIEKGC LHDOHAKINKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x824ECD0", Offset = "0x824E0D0", VA = "0x18824ECD0", Slot = "0")]
	public override bool Equals(object DEJGDIIDCDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x1543490", Offset = "0x1542890", VA = "0x181543490", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	[RecRoom.DataLayer.TombstonedFields(new int[] { 2 })]
	[RecRoom.DataLayer.RRGuid("A8D1A28C-A057-4DF1-B0CF-22A81E217E19")]
	[RecRoom.DataLayer.NetworkComponent(4, false)]
	[TypeManager.ForcedStableTypeHash(11317457978519712368uL)]
	public struct AuthoredAIIdData : IComponentData, IEquatable<AuthoredAIIdData>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public uint Value;

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x824E570", Offset = "0x824D970", VA = "0x18824E570", Slot = "4")]
		public bool Equals(AuthoredAIIdData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x824E580", Offset = "0x824D980", VA = "0x18824E580", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x1543490", Offset = "0x1542890", VA = "0x181543490", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	[RecRoom.DataLayer.RRGuid("650DAD22-E465-4BF2-9A09-076774E09A3E")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[TypeManager.ForcedStableTypeHash(3063687516547021329uL)]
	public struct AuthoredLocalDeformableScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default("new float3(1)")]
		public float3 localDeformationScale;

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x2CE8DC0", Offset = "0x2CE81C0", VA = "0x182CE8DC0")]
		public AuthoredLocalDeformableScaleData(float3 scale)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[TypeManager.ForcedStableTypeHash(11505792609904010668uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.StableTypeHash(11505792609904010668uL, 0u)]
	[RecRoom.DataLayer.RRGuid("B7CEB5B9-453F-4712-B833-27D907AA13E2")]
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
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x824E610", Offset = "0x824DA10", VA = "0x18824E610")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x54E20C0", Offset = "0x54E14C0", VA = "0x1854E20C0")]
		public AuthoredLocalPoseData(quaternion localRotation, float3 localPosition)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x824E670", Offset = "0x824DA70", VA = "0x18824E670")]
		public static RigidTransform GKKMDDPCKIG(AuthoredLocalPoseData poseData)
		{
			return default(RigidTransform);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x824E670", Offset = "0x824DA70", VA = "0x18824E670")]
		public static AuthoredLocalPoseData GKKMDDPCKIG(RigidTransform pose)
		{
			return default(AuthoredLocalPoseData);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class AEIIOMOGMIK
{
	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x824E210", Offset = "0x824D610", VA = "0x18824E210")]
	public static AuthoredLocalPoseData BCNIKPBPHMB([In] this RigidTransform CBMEHPPMEEA)
	{
		return default(AuthoredLocalPoseData);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0xDC9780", Offset = "0xDC8B80", VA = "0x180DC9780")]
	public static RigidTransform AHMKMLOGECE(this AuthoredLocalPoseData CBMEHPPMEEA)
	{
		return default(RigidTransform);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x824E240", Offset = "0x824D640", VA = "0x18824E240")]
	public static RigidTransform CMLANHEHDIE([In] this AuthoredLocalPoseData CBMEHPPMEEA)
	{
		return default(RigidTransform);
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.StableTypeHash(9088562008033959482uL, 0u)]
	[TypeManager.ForcedStableTypeHash(9088562008033959482uL)]
	[CompilerGenerated]
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
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x824E690", Offset = "0x824DA90", VA = "0x18824E690")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x2CEA450", Offset = "0x2CE9850", VA = "0x182CEA450")]
		public AuthoredLocalUniformScaleData(float localUniformScale)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("7B1B8635-3FA9-4ADC-922B-3C25CE0C7E7D")]
	[RecRoom.DataLayer.StableTypeHash(10137300772124140051uL, 0u)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(10137300772124140051uL)]
	public struct AuthoredParentData : IComponentData, OBHJLGHKFJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public Entity parent;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xAF6920", Offset = "0xAF5D20", VA = "0x180AF6920", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x1395E90", Offset = "0x1395290", VA = "0x181395E90", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x1395E90", Offset = "0x1395290", VA = "0x181395E90")]
		public AuthoredParentData(Entity parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x824E6F0", Offset = "0x824DAF0", VA = "0x18824E6F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002C")]
public struct GBJHLJKJBMG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002D")]
[TypeManager.ForcedStableTypeHash(11776442497872827640uL)]
public struct CJANFGIKBNO : IComponentData
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
		[RecRoom.DataLayer.Default(true)]
		[RecRoom.DataLayer.Field(1)]
		public bool isOwnedByTerrain;
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[TypeManager.ForcedStableTypeHash(8594223769175916906uL)]
	[RecRoom.DataLayer.StableTypeHash(8594223769175916906uL, 0u)]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
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
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("B26EF01D-F674-4506-80B7-5345391A097E")]
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
	[RecRoom.DataLayer.RRGuid("E9BA10A4-4EE9-431D-BD7F-FF2008ABFA03")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
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
public struct HOLPFAKPFCL : IComponentData
{
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[RecRoom.DataLayer.RRGuid("46C500A2-9991-4987-B1AA-66E5C3D8E371")]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[TypeManager.ForcedStableTypeHash(16223816226138460552uL)]
	public struct ReplicatedObjectTag : IComponentData
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	[RecRoom.DataLayer.RRGuid("5ED157AA-488F-453A-A986-594595B8D777")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(17912083982325865811uL)]
	public struct ReplicatorData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public Entity Target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		[RecRoom.DataLayer.Default(false)]
		[RecRoom.DataLayer.Field(2)]
		public bool NeedsCircuitUpdate;
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[RecRoom.DataLayer.RRGuid("72F1ABE4-CB5D-4809-8C6D-BC4D800D9E30")]
	[TypeManager.ForcedStableTypeHash(11840542726010018465uL)]
	[RuntimeOnly]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
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
public struct NIMLMMGKFBA : IComponentData
{
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[TypeManager.ForcedStableTypeHash(8691279933813304851uL)]
	[RecRoom.DataLayer.RRGuid("AEA4D222-29BA-462F-9C0A-AA2063671C68")]
	[CompilerGenerated]
	public struct ReplicatorMaxObjectCountData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		[RecRoom.DataLayer.Default(10)]
		[RecRoom.DataLayer.Field(1)]
		public int count;
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[RecRoom.DataLayer.RRGuid("400790C1-E8D9-4779-A549-3780DAEC2FDF")]
	[TypeManager.ForcedStableTypeHash(16379995002884076574uL)]
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
	[TypeManager.ForcedStableTypeHash(8536678595025273356uL)]
	[RecRoom.DataLayer.StableTypeHash(8536678595025273356uL, 0u)]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("6A82044A-E392-4DCD-B4BC-A120E58334EA")]
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

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x824EDB0", Offset = "0x824E1B0", VA = "0x18824EDB0", Slot = "4")]
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

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x1530B00", Offset = "0x152FF00", VA = "0x181530B00")]
		internal EntityPrefabPartId(uint CLNGGGMIBPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0xD71620", Offset = "0xD70A20", VA = "0x180D71620")]
		internal uint GJGHINKFDPO()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x247B9F0", Offset = "0x247ADF0", VA = "0x18247B9F0", Slot = "4")]
		public bool Equals(EntityPrefabPartId LHDOHAKINKP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x824EE00", Offset = "0x824E200", VA = "0x18824EE00", Slot = "0")]
		public override bool Equals(object DEJGDIIDCDN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x1543490", Offset = "0x1542890", VA = "0x181543490", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x247B950", Offset = "0x247AD50", VA = "0x18247B950", Slot = "5")]
		public int CompareTo(EntityPrefabPartId LHDOHAKINKP)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[TypeManager.ForcedStableTypeHash(15026348711748810383uL)]
public struct CBHDDCJAEPD : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public Entity JNKOIGEJLAM;
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	[ConfigGroup("Physics", 0)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(2330616907306882483uL)]
	[RecRoom.DataLayer.RRGuid("F74D558B-BDCC-48C8-A8EF-1F7559E5EAA0")]
	public struct PhysicsModelCollisionModeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		[RecRoom.DataLayer.Field(1)]
		[Config(null, 0)]
		[RecRoom.DataLayer.Default(OPHMAHEJLBB.Children)]
		public OPHMAHEJLBB collisionMode;
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	[RecRoom.DataLayer.RRGuid("8A12EB45-2A15-41CE-AFF7-90A9F984D3A2")]
	[ConfigGroup("Container", 0)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[TypeManager.ForcedStableTypeHash(11125590729425051511uL)]
	public struct ContainerIsRecolorableData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		[RecRoom.DataLayer.Default]
		[Config(null, 0)]
		[RecRoom.DataLayer.Field(1)]
		public bool IsRecolorable;
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[RecRoom.DataLayer.RRGuid("55EAB643-95BB-4C3A-832C-798EBCD95AD5")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(14800424556151816553uL)]
	[InternalBufferCapacity(0)]
	public struct ContainerNameBuffer : IBufferElementData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public byte data;
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[CompilerGenerated]
	[ConfigGroup("Container", 0)]
	[TypeManager.ForcedStableTypeHash(13657791279235747653uL)]
	[RecRoom.DataLayer.RRGuid("89708D57-D027-494A-A159-221E6C643B6B")]
	[RecRoom.DataLayer.StableTypeHash(13657791279235747653uL, 0u)]
	public struct ContainerNameData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		[RecRoom.DataLayer.Default]
		[Config(null, 0)]
		[RecRoom.DataLayer.Field(1)]
		public FixedString64Bytes name;
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[ConfigGroup("Physics", 0)]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	[TypeManager.ForcedStableTypeHash(13904209480152351845uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.RRGuid("CA023286-E0F6-4DA9-A346-94E86B93977C")]
	public struct PhysicsModelGrabbableModeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		[Config(null, 0)]
		public EBPMCOGAHLH grabbableMode;
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[RecRoom.DataLayer.StableTypeHash(16485879999901987510uL, 0u)]
	[RecRoom.DataLayer.RRGuid("84485C1B-18ED-4D4A-86A4-34CEED482615")]
	[ConfigGroup("Container", 0)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(16485879999901987510uL)]
	public struct NavMeshGenerationData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		[RecRoom.DataLayer.Default(AGIDIJAMCNH.NavMeshGenerator)]
		[Config(null, 0)]
		[RecRoom.DataLayer.Field(1)]
		public AGIDIJAMCNH mode;
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[ConfigGroup("Physics", 0)]
	[RecRoom.DataLayer.RRGuid("C5BCE8B3-6E69-41D4-921A-BE2E3E0A4DAB")]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	[TypeManager.ForcedStableTypeHash(1954118413118190521uL)]
	public struct PhysicsModelCollisionLayerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		[RecRoom.DataLayer.Default(CGPPANCJEFA.IsDynamicEnvironment)]
		[Config(null, 0)]
		[RecRoom.DataLayer.Field(1)]
		public CGPPANCJEFA collisionLayer;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class NFIPFHPEIDC
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public enum MPBKCKFKJCN
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
	public enum CDKIEAIAAAD
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

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x8250F90", Offset = "0x8250390", VA = "0x188250F90")]
	public static (MPBKCKFKJCN, CDKIEAIAAAD) BODAGPAEKPP(this CGPPANCJEFA DANOPCAPJEB)
	{
		return default((MPBKCKFKJCN, CDKIEAIAAAD));
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(4, false)]
	[RecRoom.DataLayer.RRGuid("F63AA9EA-6191-4DE9-BB18-1F049F432124")]
	[TypeManager.ForcedStableTypeHash(16462677563651546047uL)]
	[ConfigGroup("Physics", 0)]
	public struct PhysicsModelFlagsData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		[RecRoom.DataLayer.Field(1)]
		[Config(null, 0)]
		[RecRoom.DataLayer.Default(BNADNEMKMMC.DEFAULT)]
		public BNADNEMKMMC flags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[ConfigGroup("Physics", 0)]
	[RecRoom.DataLayer.RRGuid("B6D08147-6AEA-4270-BDC4-8CF68662318D")]
	[RecRoom.DataLayer.StableTypeHash(1094837642118998916uL, 0u)]
	[TypeManager.ForcedStableTypeHash(1094837642118998916uL)]
	public struct PhysicsModelMassOverrideData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default(0f)]
		[Config(null, 0)]
		public float mass;
	}
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(10518841812724430444uL)]
	[RecRoom.DataLayer.RRGuid("17799917-98EE-4D9A-A8D1-B0BE5F7316E3")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
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
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0xDC9780", Offset = "0xDC8B80", VA = "0x180DC9780")]
		public static InventionIdData GKKMDDPCKIG(long value)
		{
			return default(InventionIdData);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x824F090", Offset = "0x824E490", VA = "0x18824F090")]
		public readonly bool ONDHCFLEEHI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7F53080", Offset = "0x7F52480", VA = "0x187F53080")]
		public static bool ONDHCFLEEHI(long inventionId)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[TypeManager.ForcedStableTypeHash(14338988155392421373uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.TombstonedFields(new int[] { 1 })]
	[RecRoom.DataLayer.RRGuid("629F0A56-C478-4353-BBDA-8A8BB5FEE478")]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	public struct InventionInstanceIdData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		[RecRoom.DataLayer.Field(2)]
		[RecRoom.DataLayer.Default]
		public NetworkGuid instanceId;

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x1243A30", Offset = "0x1242E30", VA = "0x181243A30")]
		public static InventionInstanceIdData GKKMDDPCKIG(Guid value)
		{
			return default(InventionInstanceIdData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[RecRoom.DataLayer.RRGuid("5D26C8C6-7B5E-481E-B31E-6F30BE69D3C9")]
	[TypeManager.ForcedStableTypeHash(7796256876318585598uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct DesyncEntityReferenceData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public Entity entity;
	}
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[TypeManager.ForcedStableTypeHash(3111430309403391054uL)]
	[RecRoom.DataLayer.RRGuid("AFCA5CDE-FE11-4D4A-BBC6-32EE1D254891")]
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
	[CompilerGenerated]
	[RecRoom.DataLayer.RRGuid("F1D14C4E-5388-4D7C-B641-5E79453B80AB")]
	[TypeManager.ForcedStableTypeHash(3936130774074738641uL)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct DesyncNetworkComponentsData : IBufferElementData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public ulong stableTypeHash;
	}
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(16880504271670651740uL)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("04FC082C-DAD0-45B5-A3EF-F042100BAF0F")]
	[RuntimeOnly]
	public struct ElementSnapPointData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public Entity snappedTo;
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[RecRoom.DataLayer.RRGuid("C9620D1E-DE40-4530-954E-90760F1B7A41")]
	[CompilerGenerated]
	[RuntimeOnly]
	[TypeManager.ForcedStableTypeHash(12457040547531531440uL)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct ElementSnapPointRuntimeFlagsData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default(CAKFJLPKMGI.None)]
		public CAKFJLPKMGI flags;
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[RecRoom.DataLayer.StableTypeHash(12111354511484844847uL, 0u)]
	[TypeManager.ForcedStableTypeHash(12111354511484844847uL)]
	[RuntimeOnly]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("A3B27452-BD6C-43B2-BAFF-CF885EB1608B")]
	[CompilerGenerated]
	public struct ParentData : IComponentData, OBHJLGHKFJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public Entity parent;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0xAF6920", Offset = "0xAF5D20", VA = "0x180AF6920", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x1395E90", Offset = "0x1395290", VA = "0x181395E90", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x1395E90", Offset = "0x1395290", VA = "0x181395E90")]
		public ParentData(Entity parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0xDC9780", Offset = "0xDC8B80", VA = "0x180DC9780")]
		public static implicit operator ParentData(Entity entity)
		{
			return default(ParentData);
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000050")]
public struct IKKFIKCDEKN : IComponentData
{
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[RecRoom.DataLayer.RRGuid("c886150a-7231-4cc5-a2b2-f222500e6960")]
	[TypeManager.ForcedStableTypeHash(1950029632769634832uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.StableTypeHash(1950029632769634832uL, 0u)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct SiblingSortOrderData : IEquatable<SiblingSortOrderData>, IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public OJNFHONPFAP order;

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0xDC9780", Offset = "0xDC8B80", VA = "0x180DC9780")]
		public static SiblingSortOrderData GKKMDDPCKIG(OJNFHONPFAP value)
		{
			return default(SiblingSortOrderData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x8251890", Offset = "0x8250C90", VA = "0x188251890", Slot = "4")]
		public bool Equals(SiblingSortOrderData other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("46CEA601-8AA7-423D-B1EA-EEABAE73413F")]
	[TypeManager.ForcedStableTypeHash(6217116203744017593uL)]
	[CompilerGenerated]
	public struct InteractionFilterAllTagsData : IComponentData, OBHJLGHKFJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public Entity allTags;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0xAF6920", Offset = "0xAF5D20", VA = "0x180AF6920", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x1395E90", Offset = "0x1395290", VA = "0x181395E90", Slot = "5")]
			set
			{
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[TypeManager.ForcedStableTypeHash(6215026851838101933uL)]
	[RecRoom.DataLayer.RRGuid("49CEFD0F-3A38-4A9B-835E-10B4C2D08392")]
	[CompilerGenerated]
	public struct InteractionFilterAnyTagsData : IComponentData, OBHJLGHKFJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public Entity anyTags;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xAF6920", Offset = "0xAF5D20", VA = "0x180AF6920", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x1395E90", Offset = "0x1395290", VA = "0x181395E90", Slot = "5")]
			set
			{
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	[RecRoom.DataLayer.RRGuid("11CE457F-4366-4AAD-B7E3-28D82B4FAFCF")]
	[TypeManager.ForcedStableTypeHash(6780642047612598977uL)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct InteractionFilterEnabledData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		[RecRoom.DataLayer.Default(JHJGBLLNBFI.Disabled)]
		[RecRoom.DataLayer.Field(1)]
		public JHJGBLLNBFI filterMode;
	}
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[TypeManager.ForcedStableTypeHash(6642820932987006861uL)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("F7789094-7D82-4D27-B805-2CC1B8C0A538")]
	[CompilerGenerated]
	public struct InteractionFilterEntityRefData : IComponentData, OBHJLGHKFJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public Entity filterEntity;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0xAF6920", Offset = "0xAF5D20", VA = "0x180AF6920", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x1395E90", Offset = "0x1395290", VA = "0x181395E90", Slot = "5")]
			set
			{
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("C7E95AF7-DB7D-4432-8DAA-8F36EC6C4308")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(15467295871228743847uL)]
	public struct InteractionFilterNoneTagsData : IComponentData, OBHJLGHKFJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public Entity noneTags;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0xAF6920", Offset = "0xAF5D20", VA = "0x180AF6920", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x1395E90", Offset = "0x1395290", VA = "0x181395E90", Slot = "5")]
			set
			{
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[RecRoom.DataLayer.RRGuid("C0280102-4D0D-4960-B108-E59CAE468710")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[CompilerGenerated]
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
		[RecRoom.DataLayer.Default(JHJGBLLNBFI.EnabledForRole)]
		[RecRoom.DataLayer.Field(2)]
		public JHJGBLLNBFI mode;
	}
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[TypeManager.ForcedStableTypeHash(10434800737286119109uL)]
	[RecRoom.DataLayer.RRGuid("A5E08071-6B43-446F-A542-878B31E43736")]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct MagneticAnchorData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public Entity connectedAnchor;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[RecRoom.DataLayer.RRGuid("007F8815-C87C-4E6B-BC56-3BA0C4888E3D")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(15012400804589552708uL)]
	[RecRoom.DataLayer.StableTypeHash(15012400804589552708uL, 0u)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct OverrideObjectNetworkIdData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public uint networkIdBits;
	}
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("30228348-77DF-48F6-B2EF-B0883D3E10CA")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(4540375434353162791uL)]
	public struct MakerPenHeldData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public bool makerPenHeld;
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[RecRoom.DataLayer.NetworkComponent(6, false)]
	[RecRoom.DataLayer.RRGuid("FB9853D6-6231-43FD-A754-00105DC30880")]
	[TypeManager.ForcedStableTypeHash(8459715919607487693uL)]
	[CompilerGenerated]
	[ConfigGroup("Object", 0)]
	public struct ObjectPolicyData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		[RecRoom.DataLayer.Field(2)]
		[RecRoom.DataLayer.Default("new ScaleRestriction(1,1)")]
		public ICHHKDNLLPL scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		[RecRoom.DataLayer.Default("ObjectPolicyUserConfigurableFlags.DEFAULT")]
		[Config(null, 0)]
		[RecRoom.DataLayer.Field(3)]
		public OEFDIDBPHAO userConfigurableFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		[RecRoom.DataLayer.Field(4)]
		[RecRoom.DataLayer.Default(OBOGCMLDHKJ.Default)]
		[Config(null, 0)]
		public OBOGCMLDHKJ circuitsTransformBehavior;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		[RecRoom.DataLayer.Default("ObjectPolicyEnumFlags.Default")]
		[RecRoom.DataLayer.Field(1)]
		public JFKBIGJMKEO flags;
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("01AEEF22-2473-4505-A473-0BBF009690B3")]
	[TypeManager.ForcedStableTypeHash(2965180940795077803uL)]
	[CompilerGenerated]
	[SerializationOnly]
	public struct RemovedNetworkComponentsBuffer : IBufferElementData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public ulong stableTypeHash;
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("617A903E-C2C2-467C-A138-287FDB487645")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(17708500325183871236uL)]
	[RecRoom.DataLayer.StableTypeHash(17708500325183871236uL, 0u)]
	public struct PlayerScopeData : IComponentData, OBHJLGHKFJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public Entity playerScope;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public Entity Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0xAF6920", Offset = "0xAF5D20", VA = "0x180AF6920", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x1395E90", Offset = "0x1395290", VA = "0x181395E90", Slot = "5")]
			set
			{
			}
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0xDC9780", Offset = "0xDC8B80", VA = "0x180DC9780")]
		public static PlayerScopeData GKKMDDPCKIG(Entity entity)
		{
			return default(PlayerScopeData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[RecRoom.DataLayer.RRGuid("F945B699-C9E5-4634-9F64-831484F4F3BD")]
	[RecRoom.DataLayer.StableTypeHash(16642773407304133105uL, 0u)]
	[ConfigGroup("Physics", 0)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(16642773407304133105uL)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct PhysicsMaterialData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		[Config(null, 0)]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default(10f)]
		public float density;
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[RecRoom.DataLayer.RRGuid("A2E0AF0F-C284-47E6-9535-A67A29BF5730")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[TypeManager.ForcedStableTypeHash(10537432342869025182uL)]
	[RecRoom.DataLayer.StableTypeHash(10537432342869025182uL, 0u)]
	[CompilerGenerated]
	public struct ShapeConfigData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default(HNPEOKBOCPL.None)]
		public HNPEOKBOCPL flags;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool DynamicUVProjection
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x7597870", Offset = "0x7596C70", VA = "0x187597870")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool PreventInvertedCreation
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x7597860", Offset = "0x7596C60", VA = "0x187597860")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public bool NewBendLogic
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x8252910", Offset = "0x8251D10", VA = "0x188252910")]
			get
			{
				return default(bool);
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("5C706BF1-9D50-456A-B974-521E8E2CC660")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(10917729582819845312uL)]
	[RecRoom.DataLayer.StableTypeHash(10917729582819845312uL, 0u)]
	public struct ShapeTypeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public ALLEDPCNAAI shapeType;
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[RecRoom.DataLayer.StableTypeHash(5298506180484533559uL, 0u)]
	[CompilerGenerated]
	[RecRoom.DataLayer.RRGuid("36418781-DB47-4DE7-A138-CC88D1D795C0")]
	[TypeManager.ForcedStableTypeHash(5298506180484533559uL)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct SplinePointOrderData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public OJNFHONPFAP order;

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0xDC9780", Offset = "0xDC8B80", VA = "0x180DC9780")]
		public static SplinePointOrderData GKKMDDPCKIG(OJNFHONPFAP value)
		{
			return default(SplinePointOrderData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[TypeManager.ForcedStableTypeHash(16368389834000856208uL)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[CompilerGenerated]
	[RecRoom.DataLayer.RRGuid("FCEE3BCD-9C10-4BF4-954A-0DCFE8810227")]
	[RecRoom.DataLayer.StableTypeHash(16368389834000856208uL, 0u)]
	public struct SplinePointParentData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public Entity spline;
	}
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[RecRoom.DataLayer.RRGuid("5A6D38A4-1A58-4EB4-9C1B-06ADA0D44AFA")]
	[RecRoom.DataLayer.StableTypeHash(18095612727592564636uL, 0u)]
	[TypeManager.ForcedStableTypeHash(18095612727592564636uL)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[CompilerGenerated]
	public struct SplinePointPositionData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public float3 localPosition;
	}
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[RecRoom.DataLayer.StableTypeHash(1429513518619209486uL, 0u)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(1429513518619209486uL)]
	[RecRoom.DataLayer.RRGuid("433F66B6-CC1C-4A8A-BF73-2B797440A8DB")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct SplinePointRotationData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		[RecRoom.DataLayer.Default("new quaternion(0, 0, 0, 1f)")]
		[RecRoom.DataLayer.Field(1)]
		public quaternion localRotation;
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[RecRoom.DataLayer.RRGuid("04CA3CCE-F121-4B5B-BC56-FE8E9C77F0F4")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.StableTypeHash(1238044349990854547uL, 0u)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(1238044349990854547uL)]
	public struct SplinePointScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default("new float3(1)")]
		public float3 localScale;
	}
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[RecRoom.DataLayer.RRGuid("E0610986-0F8F-494A-8C6E-8A2D2491B088")]
	[RecRoom.DataLayer.StableTypeHash(4657247877648983868uL, 0u)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[TypeManager.ForcedStableTypeHash(4657247877648983868uL)]
	[CompilerGenerated]
	public struct SplineShapeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public BFGADLCEFPF parameters;
	}
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	[RecRoom.DataLayer.StableTypeHash(12332323170023439017uL, 0u)]
	[RecRoom.DataLayer.RRGuid("73C344D9-D535-4753-9D9A-B6DEDE4079B0")]
	[TypeManager.ForcedStableTypeHash(12332323170023439017uL)]
	[RecRoom.DataLayer.TombstonedFields(new int[] { 1 })]
	public struct OMShapeContainerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		[RecRoom.DataLayer.Default(true)]
		[RecRoom.DataLayer.Field(2)]
		public bool canModifyWithCircuits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		[RecRoom.DataLayer.Field(3)]
		[RecRoom.DataLayer.Default(true)]
		public bool optimizedCollidersEnabled;
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[TypeManager.ForcedStableTypeHash(17673274643717888315uL)]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	[CompilerGenerated]
	[RecRoom.DataLayer.RRGuid("2B5C4208-9113-4F65-B3A6-18EAE1FF3937")]
	public struct SerializedDataLayerVersionData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public int version;
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	[RecRoom.DataLayer.RRGuid("530E7647-9756-405B-8F83-554B2251FEA9")]
	[TypeManager.ForcedStableTypeHash(2300229493044241130uL)]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	public struct TerrainGenerationData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default(0u)]
		public uint Seed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		[RecRoom.DataLayer.Field(2)]
		[RecRoom.DataLayer.Default(1f)]
		public float BaseTerrainHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		[RecRoom.DataLayer.Default(1f)]
		[RecRoom.DataLayer.Field(3)]
		public float BaseTerrainFeatureScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		[RecRoom.DataLayer.Field(4)]
		[RecRoom.DataLayer.Default]
		public PBFAHNBOMEH PlayAreaShape;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(5)]
		public GLJNFGKKOAM BaseTerrainRoughness;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		[RecRoom.DataLayer.Field(6)]
		[RecRoom.DataLayer.Default]
		public CGJIJKGNEMN BaseTerrainHeightFunction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		[RecRoom.DataLayer.Field(7)]
		[RecRoom.DataLayer.Default(0.75f)]
		public float PlayAreaOpacity;
	}
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[RecRoom.DataLayer.RRGuid("207C2E2E-B1B0-4A2B-8A14-9651A907CBC6")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(2736085529679546037uL)]
	public struct TerrainLayerBuffer : IBufferElementData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public TerrainGenerationLayer layer;
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[CompilerGenerated]
	[RecRoom.DataLayer.RRGuid("557221B3-5BED-456A-8B42-A8D934D18103")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[TypeManager.ForcedStableTypeHash(17384573708384647569uL)]
	public struct TerrainMaterialLayerBuffer : IBufferElementData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public GCFFMGKDNLP layer;
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[TypeManager.ForcedStableTypeHash(15805686756326706819uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.RRGuid("6BA5DFA9-9617-4782-A765-0DD5898267E0")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct TerrainWaterData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		[RecRoom.DataLayer.Default(-1)]
		[RecRoom.DataLayer.Field(1)]
		public float WaterHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		[RecRoom.DataLayer.Default(0.25f)]
		[RecRoom.DataLayer.Field(2)]
		public float WaterChop;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		[RecRoom.DataLayer.Default(0.25f)]
		[RecRoom.DataLayer.Field(3)]
		public float WaterAlpha;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		[RecRoom.DataLayer.Field(4)]
		[RecRoom.DataLayer.Default(GEGMIDKLLFN.Invalid)]
		public GEGMIDKLLFN WaterColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		[RecRoom.DataLayer.Field(5)]
		[RecRoom.DataLayer.Default(GEGMIDKLLFN.Invalid)]
		public GEGMIDKLLFN DeepColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		[RecRoom.DataLayer.Field(6)]
		[RecRoom.DataLayer.Default(1)]
		public float EmissiveStrength;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
[RecRoom.DataLayer.RRGuid("CC657074-87FD-47F7-A7B0-F5CCE922A9D0")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.Range(KGMJKHNNELD.MIN, KGMJKHNNELD.ALL)]
[Flags]
public enum KGMJKHNNELD
{
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	IsAllowed = 1,
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	UseDefaultVisualEffects = 2,
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	DEFAULT = 2,
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	ALL = 3,
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	MAX = 3
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(5328722791392374178uL)]
	[RecRoom.DataLayer.RRGuid("34BA53CB-16FB-45DB-AA25-293CE7C8DAE4")]
	public struct ToolCleanupSettingsData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		[RecRoom.DataLayer.Default(15f)]
		[RecRoom.DataLayer.Field(1)]
		public float delay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		[RecRoom.DataLayer.Default(KGMJKHNNELD.UseDefaultVisualEffects)]
		[RecRoom.DataLayer.Field(2)]
		public KGMJKHNNELD toolCleanupFlags;
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(13768238190614302474uL)]
	[RecRoom.DataLayer.RRGuid("48C72ABE-383D-45C6-9610-773F2B4F84C6")]
	[RecRoom.DataLayer.TombstonedFields(new int[] { 2, 3 })]
	public struct ToolCleanupStatusData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public float cleanupStartTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		[RecRoom.DataLayer.Field(4)]
		[RecRoom.DataLayer.Default]
		public LPDGDMDBJPF statusFlags;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
[RecRoom.DataLayer.RRGuid("E63050BA-D087-4027-99F8-4AFDEA229CD8")]
[RecRoom.DataLayer.Range(LPDGDMDBJPF.None, LPDGDMDBJPF.ALL)]
[Flags]
[RecRoom.DataLayer.NetworkEnum(1, false)]
public enum LPDGDMDBJPF
{
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	ForceCleanup = 1,
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	CleanupDone = 2,
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	CleanupPaused = 4,
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	ALL = 7,
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	MAX = 7
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[RecRoom.DataLayer.RRGuid("021E8703-AAFD-4965-8C38-FF86663126D2")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(463077377357487319uL)]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	public struct LocalDeformableScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		[RecRoom.DataLayer.Default("new float3(1)")]
		[RecRoom.DataLayer.Field(1)]
		public float3 localDeformationScale;

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x2CE8DC0", Offset = "0x2CE81C0", VA = "0x182CE8DC0")]
		public LocalDeformableScaleData(float3 scale)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[RecRoom.DataLayer.RRGuid("38AA9F1D-FD16-4B56-917C-3341D0EB1DF2")]
	[TypeManager.ForcedStableTypeHash(1369925932270831712uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.StableTypeHash(1369925932270831712uL, 0u)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct LocalPoseData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default("new quaternion(0,0,0,1)")]
		public quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(2)]
		public float3 localPosition;

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x54E20C0", Offset = "0x54E14C0", VA = "0x1854E20C0")]
		public LocalPoseData(quaternion localRotation, float3 localPosition)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x824E670", Offset = "0x824DA70", VA = "0x18824E670")]
		public static RigidTransform GKKMDDPCKIG(LocalPoseData poseData)
		{
			return default(RigidTransform);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x824E670", Offset = "0x824DA70", VA = "0x18824E670")]
		public static LocalPoseData GKKMDDPCKIG(RigidTransform pose)
		{
			return default(LocalPoseData);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public static class CJMLEKOLGDM
{
	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x824EC80", Offset = "0x824E080", VA = "0x18824EC80")]
	public static LocalPoseData LBOBGLAGBIB([In] this RigidTransform CBMEHPPMEEA)
	{
		return default(LocalPoseData);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x824EC50", Offset = "0x824E050", VA = "0x18824EC50")]
	public static RigidTransform CMLANHEHDIE([In] this LocalPoseData CBMEHPPMEEA)
	{
		return default(RigidTransform);
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[TypeManager.ForcedStableTypeHash(2720902521635056246uL)]
	[RecRoom.DataLayer.StableTypeHash(2720902521635056246uL, 0u)]
	[RecRoom.DataLayer.RRGuid("0E9FADE9-751A-4A53-B455-4F8EA675754D")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[CompilerGenerated]
	public struct LocalUniformScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default(1f)]
		public float localUniformScale;
	}
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.StableTypeHash(5730545663584378555uL, 0u)]
	[TypeManager.ForcedStableTypeHash(5730545663584378555uL)]
	[RecRoom.DataLayer.RRGuid("F01774C0-98E7-491E-AAA5-85B64AFFA182")]
	[CompilerGenerated]
	public struct TransformFlagsData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public IMPKOJJLIDN transformHint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		[RecRoom.DataLayer.Field(2)]
		[RecRoom.DataLayer.Default]
		public IFFBGKJLFIG transformPriority;
	}
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	[RecRoom.DataLayer.RRGuid("392BF0C9-F464-491A-8725-E4B5E5C4ECD4")]
	[TypeManager.ForcedStableTypeHash(12583036596830542024uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.DoNotGenerateComponentProperties]
	public struct RRObjectPrefabData : ISharedComponentData, IEquatable<RRObjectPrefabData>, IComparable<RRObjectPrefabData>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public KEPNMPHCHCC prefabType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(2)]
		public Guid prefabGuid;

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x8252800", Offset = "0x8251C00", VA = "0x188252800")]
		public RRObjectPrefabData(Guid prefabGuid, KEPNMPHCHCC prefabType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x8252700", Offset = "0x8251B00", VA = "0x188252700", Slot = "4")]
		public readonly bool Equals(RRObjectPrefabData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x8252640", Offset = "0x8251A40", VA = "0x188252640", Slot = "0")]
		public override readonly bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x8252810", Offset = "0x8251C10", VA = "0x188252810")]
		public static bool operator ==(RRObjectPrefabData a, RRObjectPrefabData b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x8252440", Offset = "0x8251840", VA = "0x188252440", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x8252250", Offset = "0x8251650", VA = "0x188252250", Slot = "5")]
		public readonly int CompareTo(RRObjectPrefabData other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x8252760", Offset = "0x8251B60", VA = "0x188252760", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[RecRoom.DataLayer.RRGuid("FF90B503-A0B5-4B3D-BACF-046FA1456FBD")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(17550159503907726442uL)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct ReferenceGroupKindData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public GDCPGHBNPPK kind;
	}
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[TypeManager.ForcedStableTypeHash(18363292822319307914uL)]
	[RecRoom.DataLayer.RRGuid("2C78EEBE-6DD9-44FF-A70D-6C2EE9BB8FB3")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[CompilerGenerated]
	public struct ReferenceGroupOwnerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public Entity owner;
	}
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	[TypeManager.ForcedStableTypeHash(11947588904347318594uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.RRGuid("177498E9-83A6-4C2E-A8C1-B1951B47E74D")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct ReferenceGroupReferenceBuffer : IBufferElementData, OBHJLGHKFJO, IEquatable<ReferenceGroupReferenceBuffer>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public Entity reference;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public Entity Entity
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0xAF6920", Offset = "0xAF5D20", VA = "0x180AF6920", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x1395E90", Offset = "0x1395290", VA = "0x181395E90", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x8252900", Offset = "0x8251D00", VA = "0x188252900", Slot = "6")]
		public bool Equals(ReferenceGroupReferenceBuffer other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x8252870", Offset = "0x8251C70", VA = "0x188252870", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0xD71620", Offset = "0xD70A20", VA = "0x180D71620", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007A")]
public struct COKCHEICDGO : IEqualityComparer<ReferenceGroupReferenceBuffer>
{
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public static COKCHEICDGO BCIBOEFGOGH;

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x824ECB0", Offset = "0x824E0B0", VA = "0x18824ECB0", Slot = "4")]
	public bool Equals(ReferenceGroupReferenceBuffer FNBJHADJBNG, ReferenceGroupReferenceBuffer MODFPFNICHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0xB69C40", Offset = "0xB69040", VA = "0x180B69C40", Slot = "5")]
	public int GetHashCode(ReferenceGroupReferenceBuffer DEJGDIIDCDN)
	{
		return default(int);
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[RecRoom.DataLayer.RRGuid("DE12A401-BD29-4B00-A629-7EFBECEDCFDF")]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[InternalBufferCapacity(0)]
	[TypeManager.ForcedStableTypeHash(17466046755328781668uL)]
	public struct AuthoredUserTagReferenceBuffer : AIFAMBILPOI, IBufferElementData, OBHJLGHKFJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public Entity Child;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0xAF6920", Offset = "0xAF5D20", VA = "0x180AF6920", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x1395E90", Offset = "0x1395290", VA = "0x181395E90", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x1395E90", Offset = "0x1395290", VA = "0x181395E90")]
		public AuthoredUserTagReferenceBuffer(Entity entity)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0xDC9780", Offset = "0xDC8B80", VA = "0x180DC9780")]
		public static AuthoredUserTagReferenceBuffer GKKMDDPCKIG(Entity entity)
		{
			return default(AuthoredUserTagReferenceBuffer);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public interface AIFAMBILPOI : IBufferElementData, OBHJLGHKFJO
{
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	[CompilerGenerated]
	[RecRoom.DataLayer.RRGuid("00B7CB5E-4C0C-4D2C-AC95-78529EE58768")]
	[TypeManager.ForcedStableTypeHash(12148147190301245780uL)]
	public struct PersistentUserTagData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public FixedList32Bytes<int> tags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		[RecRoom.DataLayer.Default(false)]
		[RecRoom.DataLayer.Field(2)]
		public bool initalizedDefaults;
	}
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	[CompilerGenerated]
	[RecRoom.DataLayer.RRGuid("80D85A55-B2F6-4860-A851-62973DC10940")]
	[RecRoom.DataLayer.StableTypeHash(1859693175312uL, 0u)]
	[TypeManager.ForcedStableTypeHash(1859693175312uL)]
	[SwatchPrimaryKey]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct UserTagNameData : IComponentData, IEquatable<UserTagNameData>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public FixedString32Bytes Value;

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x8252A40", Offset = "0x8251E40", VA = "0x188252A40")]
		public UserTagNameData(string value)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x82529F0", Offset = "0x8251DF0", VA = "0x1882529F0")]
		public static UserTagNameData GKKMDDPCKIG(string value)
		{
			return default(UserTagNameData);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x8252920", Offset = "0x8251D20", VA = "0x188252920", Slot = "4")]
		public bool Equals(UserTagNameData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x8252950", Offset = "0x8251D50", VA = "0x188252950", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x8252A30", Offset = "0x8251E30", VA = "0x188252A30", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[RuntimeOnly]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[CompilerGenerated]
	[InternalBufferCapacity(0)]
	[TypeManager.ForcedStableTypeHash(2039749658960193818uL)]
	[RecRoom.DataLayer.RRGuid("1E609F72-38C4-433D-BB17-B718F89DF446")]
	public struct UserTagReferenceBuffer : AIFAMBILPOI, IBufferElementData, OBHJLGHKFJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public Entity Child;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0xAF6920", Offset = "0xAF5D20", VA = "0x180AF6920", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x1395E90", Offset = "0x1395290", VA = "0x181395E90", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x1395E90", Offset = "0x1395290", VA = "0x181395E90")]
		public UserTagReferenceBuffer(Entity entity)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0xDC9780", Offset = "0xDC8B80", VA = "0x180DC9780")]
		public static UserTagReferenceBuffer GKKMDDPCKIG(Entity entity)
		{
			return default(UserTagReferenceBuffer);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.StableTypeHash(1591066774816564574uL, 0u)]
	[RecRoom.DataLayer.RRGuid("C36DDF08-CA52-4E33-8078-2F6E915D4FDA")]
	[CompilerGenerated]
	[ConfigGroup("Visual", 0)]
	[TypeManager.ForcedStableTypeHash(1591066774816564574uL)]
	[CanDesync]
	public struct StandardRenderableVisualData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		[Config(null, 0)]
		public GEGMIDKLLFN color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		[Config(null, 0)]
		[RecRoom.DataLayer.Field(2)]
		[RecRoom.DataLayer.Default]
		public HPLJMLNNILP material;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		[Config(null, 0)]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(3)]
		public float uvScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(4)]
		[Config(null, 0)]
		public float3 uvOffset;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
[RecRoom.DataLayer.RRGuid("6B598497-D68A-4CC9-9D41-09EF6B966499")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.Range(OBOGCMLDHKJ.NONE, OBOGCMLDHKJ.COUNT)]
public enum OBOGCMLDHKJ
{
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	NONE = 0,
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	[Config("Default (can transform roots, children are static)", 0)]
	Default = 1,
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	[Config("Can Transform (chips like SetPosition can modify)", 0)]
	CircuitsCanTransform = 2,
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	[Config("Always Static (chips cannot modify transform)", 0)]
	AlwaysStatic = 3,
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	COUNT = 4,
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	MAX = 4
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
[RecRoom.DataLayer.RRGuid("17517E1A-CF1A-48C9-B6A5-F9E42C1B9E96")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.Range(0, 4)]
public enum KMMLDPFAOGJ
{
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	Box = 1,
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	Sphere = 2,
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	Capsule = 3,
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	Mesh = 4,
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	COUNT = 5,
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	MAX = 4
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[Flags]
[RecRoom.DataLayer.Range(NJPOGFBPPEO.NONE, NJPOGFBPPEO.ALL)]
[RecRoom.DataLayer.RRGuid("A13F5102-9259-42B9-B782-BB7CC33A0C4F")]
public enum NJPOGFBPPEO
{
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	NONE = 0,
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	Object = 1,
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	Player = 2,
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	Projectile = 4,
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	Vehicle = 8,
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	ALL = 0xF
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
[RecRoom.DataLayer.Range(0, 127)]
[RecRoom.DataLayer.RRGuid("F843A776-E042-43B7-8167-0C7A421062F8")]
[RecRoom.DataLayer.NetworkEnum(2, false)]
public enum CGPPANCJEFA : byte
{
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	[Config("Dynamic (Environment)", 0)]
	[@Tooltip("Indicating it can be walked on and moved")]
	IsDynamicEnvironment = 0,
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	[Config("Dynamic", -1)]
	IsDynamic = 10,
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	[Config("Dynamic (Ignore Static Geometry)", 0)]
	IsDynamicIgnoreStaticGeometry = 11,
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	[Config("Dynamic (Ignore Other Dynamic)", 0)]
	IsDynamicIgnoreOtherDynamic = 12,
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	[Config("Dynamic (Ignore Players)", 0)]
	IsDynamicIgnorePlayers = 13,
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	[Config("Dynamic (Ignore Most)", 0)]
	IsDynamicIgnoreMost = 14,
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	[Config("Enemy Collision", 0)]
	IsEnemyCollision = 30,
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	[Config("Enemy Projectile", 0)]
	IsEnemyProjectile = 31,
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	[Config("Vehicle Physics", 0)]
	IsVehicleCollision = 40,
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	[ConfigIgnore]
	STATIC = 100,
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	[ConfigIgnore]
	DECORATION = 101,
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	MAX = 127
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
[RecRoom.DataLayer.Range(OPHMAHEJLBB.Off, OPHMAHEJLBB.COUNT)]
[RecRoom.DataLayer.NetworkEnum(2, false)]
[RecRoom.DataLayer.RRGuid("9ADF7A0D-D808-48A7-BFCB-3272FB5D8A52")]
public enum OPHMAHEJLBB : byte
{
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	Off = 0,
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	Children = 1,
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	Hull = 2,
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	COUNT = 3,
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	MAX = 2
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.Range(CAKFJLPKMGI.None, CAKFJLPKMGI.SnapLocked)]
[RecRoom.DataLayer.RRGuid("0E5141AE-23E1-45A5-8BB0-04CC01E925E2")]
[Flags]
public enum CAKFJLPKMGI : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	SnapLocked = 1,
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	All = 1,
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	Default = 0
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
[RecRoom.DataLayer.RRGuid("3B156405-5769-4DB2-87EA-2B846AC4E584")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.Range(0, 2)]
public enum ALLEDPCNAAI
{
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	Primitive = 1,
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	Spline = 2,
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	COUNT = 3,
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	MAX = 2
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
[RecRoom.DataLayer.Range(EBPMCOGAHLH.Pivot, EBPMCOGAHLH.COUNT)]
[RecRoom.DataLayer.RRGuid("61EFE94A-235A-4281-B938-1A5BE32A18B1")]
[RecRoom.DataLayer.NetworkEnum(2, false)]
public enum EBPMCOGAHLH : byte
{
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	Pivot = 0,
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	Bounds = 1,
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	COUNT = 2,
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	MAX = 1
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
[RecRoom.DataLayer.RRGuid("95D8649F-566A-409B-8090-61DA57EE41CC")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.Range(GFNPHJLPFHE.Canyon, GFNPHJLPFHE.Random)]
public enum GFNPHJLPFHE
{
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	Canyon,
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	Moon,
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	Bowl,
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	Hills,
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	Island,
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	Desert,
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	Random
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
[RecRoom.DataLayer.Range(JHJGBLLNBFI.EnabledForRole, JHJGBLLNBFI.Disabled)]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.RRGuid("c0973732-e735-44cd-9727-a9a79bad01e3")]
public enum JHJGBLLNBFI : byte
{
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	EnabledForRole,
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	DisabledForRole,
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	Disabled
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.RRGuid("7E7D5AA1-2EC9-488B-8AB2-703F13BCB8CF")]
[RecRoom.DataLayer.Range(AGIDIJAMCNH.NavMeshGenerator, AGIDIJAMCNH.NavMeshBlocker)]
public enum AGIDIJAMCNH
{
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	NavMeshGenerator = 0,
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	NavMeshIgnored = 1,
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	NavMeshBlocker = 2,
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	MAX = 2
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
[RecRoom.DataLayer.RRGuid("7B493897-FE06-4FC8-AB72-8B7BF5A313D3")]
[RecRoom.DataLayer.Range(JFKBIGJMKEO.None, JFKBIGJMKEO.All)]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[Flags]
public enum JFKBIGJMKEO
{
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	All = 0x3FFF,
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	Default = 0x3FFF
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
[RecRoom.DataLayer.Range(0, CEKELHJFPPO.COUNT)]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.RRGuid("4427686F-E636-4F43-91F7-6BC74DEC584E")]
public enum CEKELHJFPPO
{
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	SupportsRotation,
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	SupportsDeformation,
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	SupportsScaling,
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	SupportsMirroring,
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	SupportsCloning,
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	SupportsRecoloring,
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	CanDestroy,
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	CanSaveIntoInventions,
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	SupportsRespawn,
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	SupportsMerging,
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	SupportsSplitting,
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	SupportsKeys,
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	CanEditWithMakerPen,
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	DEPRECATED_IsGrabbable,
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public static class ELDFAKDLKPB
{
	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x824ED80", Offset = "0x824E180", VA = "0x18824ED80")]
	public static void LFFCNKDPJLH(this JFKBIGJMKEO DPALHGCDOLB, CEKELHJFPPO LPCKDIDNKJO, bool MOELHOCKLNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x824ED60", Offset = "0x824E160", VA = "0x18824ED60")]
	public static bool IMAELMMENJK(this JFKBIGJMKEO DPALHGCDOLB, CEKELHJFPPO LPCKDIDNKJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0xEFC290", Offset = "0xEFB690", VA = "0x180EFC290")]
	public static JFKBIGJMKEO EFPCODHCPBO(this CEKELHJFPPO LPCKDIDNKJO)
	{
		return default(JFKBIGJMKEO);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
[RecRoom.DataLayer.NetworkEnum(2, false)]
[RecRoom.DataLayer.RRGuid("E3C51303-32F0-4EF4-8A66-C814E323653D")]
[RecRoom.DataLayer.Range(OEFDIDBPHAO.NONE, OEFDIDBPHAO.COUNT)]
[Flags]
public enum OEFDIDBPHAO
{
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	NONE = 0,
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	IsFrozen = 1,
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	IsGrabbable = 2,
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	PickUpDefaultToPlaceIfPhysical = 4,
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	COUNT = 5,
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	ALL = 5,
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	DEFAULT = 0
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
[RecRoom.DataLayer.RRGuid("777AD204-3AC0-41CE-BDC0-894C5821B3B9")]
[RecRoom.DataLayer.Range(KEPNMPHCHCC.None, 8000)]
[RecRoom.DataLayer.NetworkEnum(1, false)]
public enum KEPNMPHCHCC
{
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	[Config("Container", 0)]
	Container = 1000,
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	[Config("Container", 0)]
	LegacyShapeContainer = 1001,
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	[Config("Container", 0)]
	CreationShapeContainer = 1002,
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	[Config("Empty", 0)]
	Empty = 4000,
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	[Config("Legacy Box", 0)]
	Shape_Primitive_LegacyBox = 2000,
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	[Config("Sphere", 0)]
	Shape_Primitive_Sphere = 2001,
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	[Config("Cylinder", 0)]
	Shape_Primitive_Cylinder = 2002,
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	[Config("Legacy Wedge", 0)]
	Shape_Primitive_LegacyWedge = 2003,
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	[Config("Legacy Pyramid", 0)]
	Shape_Primitive_LegacyPyramid = 2004,
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	[Config("Trigger Volume Box", 0)]
	Shape_Primitive_TriggerVolumeBox = 2005,
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	[Config("Box", 0)]
	Shape_Primitive_Box = 2006,
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	[Config("Rounded Box", 0)]
	Shape_Primitive_RoundedBox = 2007,
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	[Config("Wedge", 0)]
	Shape_Primitive_Wedge = 2008,
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	[Config("Pyramid", 0)]
	Shape_Primitive_Pyramid = 2009,
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	[Config("Half Sphere", 0)]
	Shape_Primitive_HalfSphere = 2010,
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	[Config("Cone", 0)]
	Shape_Primitive_Cone = 2011,
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	[Config("Pipe", 0)]
	Shape_Primitive_Pipe = 2012,
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	[Config("Donut", 0)]
	Shape_Primitive_Donut = 2013,
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	[Config("Half Pipe", 0)]
	Shape_Primitive_HalfPipe = 2014,
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	[Config("Diamond", 0)]
	Shape_Primitive_Diamond = 2015,
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	[Config("Mound", 0)]
	Shape_Primitive_Mound = 2016,
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	[Config("Cube (Simple)", 0)]
	Shape_Primitive_ADVANCED_Cube = 2017,
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	[Config("Sphere (Simple)", 0)]
	Shape_Primitive_ADVANCED_Sphere = 2018,
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	[Config("Cylinder (Simple)", 0)]
	Shape_Primitive_ADVANCED_Cylinder = 2019,
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	[Config("Cone (Simple)", 0)]
	Shape_Primitive_ADVANCED_Cone = 2020,
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	[Config("Pyramid (Simple)", 0)]
	Shape_Primitive_ADVANCED_Pyramid = 2021,
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	[Config("Octagon (Simple)", 0)]
	Shape_Primitive_ADVANCED_Octagon = 2022,
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	[Config("Triangle (Simple)", 0)]
	Shape_Primitive_ADVANCED_Triangle = 2023,
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	[Config("Hexagon (Simple)", 0)]
	Shape_Primitive_ADVANCED_Hexagon = 2024,
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	[Config("Quarter Pipe", 0)]
	Shape_Primitive_ADVANCED_QuarterPipe = 2025,
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	[Config("Pentagon (Simple)", 0)]
	Shape_Primitive_ADVANCED_Pentagon = 2026,
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	[Config("Dodecahedron", 0)]
	Shape_Primitive_ADVANCED_Dodecahedron = 2027,
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	[Config("Icosahedron", 0)]
	Shape_Primitive_ADVANCED_Trihedron = 2028,
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	[Config("Octahedron", 0)]
	Shape_Primitive_ADVANCED_Octahedron = 2029,
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	[Config("Quarter Cylinder", 0)]
	Shape_Primitive_RR_QuarterCylinder = 2030,
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	[Config("Pentagon", 0)]
	Shape_Primitive_RR_Pentagon = 2031,
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	[Config("Quarter Sphere", 0)]
	Shape_Primitive_RR_QuarterSphere = 2032,
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	[Config("Wedge (Simple)", 0)]
	Shape_Primitive_ADVANCED_Wedge = 2033,
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	[Config("Hexagon", 0)]
	Shape_Primitive_RR_Hexagon = 2034,
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	[Config("Octagon", 0)]
	Shape_Primitive_RR_Octagon = 2035,
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	[Config("Triangle", 0)]
	Shape_Primitive_RR_Triangle = 2036,
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	[Config("Spline", 0)]
	Shape_Spline = 3000,
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	[Config("Container Pivot", 0)]
	Other_ContainerPivot = 6000,
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	[Config("Spine Point", 0)]
	Other_SplinePoint = 6001,
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	[Config("Reference Point", 0)]
	Other_ReferencePoint = 6002,
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	[Config("UserTags", 0)]
	Other_UserTag = 6003,
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	[Config("Reference Group", 0)]
	Other_ReferenceGroup = 6004,
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	[Config("Interaction Filter", 0)]
	Other_InteractionFilterTags = 6005,
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	[ConfigIgnore]
	Other_DesyncNetworkObject = 6006,
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	[ConfigIgnore]
	NativeObject_SnapPoint = 5000,
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	[Config("Object", 0)]
	PrefabRootGameObject = 7000,
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	[Config("PrefabInternal", 0)]
	PrefabInternalGameObject = 7001,
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	[Config("Player", 0)]
	Player = 8000
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
public static class AEJJCJGKKEI
{
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	[CompilerGenerated]
	private sealed class PABKOCHELPC : IEnumerable<KEPNMPHCHCC>, IEnumerable, IEnumerator<KEPNMPHCHCC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		private KEPNMPHCHCC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		private IEnumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		private KEPNMPHCHCC System.Collections.Generic.IEnumerator<RecRoom.DataLayer.ObjectPrefabType>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0xAC6FB0", Offset = "0xAC63B0", VA = "0x180AC6FB0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(KEPNMPHCHCC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x8251F10", Offset = "0x8251310", VA = "0x188251F10", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x1515760", Offset = "0x1514B60", VA = "0x181515760")]
		[DebuggerHidden]
		public PABKOCHELPC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x8251F60", Offset = "0x8251360", VA = "0x188251F60", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x8251BB0", Offset = "0x8250FB0", VA = "0x188251BB0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x8251B50", Offset = "0x8250F50", VA = "0x188251B50")]
		private void DKMCMBPCGHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x8251EC0", Offset = "0x82512C0", VA = "0x188251EC0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x8251E20", Offset = "0x8251220", VA = "0x188251E20", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<KEPNMPHCHCC> System.Collections.Generic.IEnumerable<RecRoom.DataLayer.ObjectPrefabType>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x8251E20", Offset = "0x8251220", VA = "0x188251E20", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000093")]
	[CompilerGenerated]
	private sealed class MBJKDLDINHE : IEnumerable<KEPNMPHCHCC>, IEnumerable, IEnumerator<KEPNMPHCHCC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		private KEPNMPHCHCC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		private KEPNMPHCHCC <last>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		private KEPNMPHCHCC <i>5__3;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		private KEPNMPHCHCC System.Collections.Generic.IEnumerator<RecRoom.DataLayer.ObjectPrefabType>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0xAC6FB0", Offset = "0xAC63B0", VA = "0x180AC6FB0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(KEPNMPHCHCC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x82500D0", Offset = "0x824F4D0", VA = "0x1882500D0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x1515760", Offset = "0x1514B60", VA = "0x181515760")]
		[DebuggerHidden]
		public MBJKDLDINHE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x824FF80", Offset = "0x824F380", VA = "0x18824FF80", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x8250080", Offset = "0x824F480", VA = "0x188250080", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x824FFE0", Offset = "0x824F3E0", VA = "0x18824FFE0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<KEPNMPHCHCC> System.Collections.Generic.IEnumerable<RecRoom.DataLayer.ObjectPrefabType>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x824FFE0", Offset = "0x824F3E0", VA = "0x18824FFE0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000094")]
	[CompilerGenerated]
	private sealed class BAOJDIGAGJP : IEnumerable<KEPNMPHCHCC>, IEnumerable, IEnumerator<KEPNMPHCHCC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		private KEPNMPHCHCC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		private IEnumerator<KEPNMPHCHCC> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		private KEPNMPHCHCC System.Collections.Generic.IEnumerator<RecRoom.DataLayer.ObjectPrefabType>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0xAC6FB0", Offset = "0xAC63B0", VA = "0x180AC6FB0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(KEPNMPHCHCC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x824EAE0", Offset = "0x824DEE0", VA = "0x18824EAE0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x1515760", Offset = "0x1514B60", VA = "0x181515760")]
		[DebuggerHidden]
		public BAOJDIGAGJP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x824EB30", Offset = "0x824DF30", VA = "0x18824EB30", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x824E750", Offset = "0x824DB50", VA = "0x18824E750", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x824E700", Offset = "0x824DB00", VA = "0x18824E700")]
		private void DKMCMBPCGHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x824EA90", Offset = "0x824DE90", VA = "0x18824EA90", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x824E9F0", Offset = "0x824DDF0", VA = "0x18824E9F0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<KEPNMPHCHCC> System.Collections.Generic.IEnumerable<RecRoom.DataLayer.ObjectPrefabType>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x824E9F0", Offset = "0x824DDF0", VA = "0x18824E9F0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x824E2D0", Offset = "0x824D6D0", VA = "0x18824E2D0")]
	[IteratorStateMachine(typeof(PABKOCHELPC))]
	public static IEnumerable<KEPNMPHCHCC> PKNINLKGAIE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x824E330", Offset = "0x824D730", VA = "0x18824E330")]
	[IteratorStateMachine(typeof(MBJKDLDINHE))]
	public static IEnumerable<KEPNMPHCHCC> PPGIAIJNJDP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x824E270", Offset = "0x824D670", VA = "0x18824E270")]
	[IteratorStateMachine(typeof(BAOJDIGAGJP))]
	public static IEnumerable<KEPNMPHCHCC> NIGAKPIOBHJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public static class JPHJACFDBOE
{
	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x824F0D0", Offset = "0x824E4D0", VA = "0x18824F0D0")]
	public static bool FMGMPONEDDE(this RRObjectPrefabData ADIIJMJHCKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x824F100", Offset = "0x824E500", VA = "0x18824F100")]
	public static bool FMGMPONEDDE(this KEPNMPHCHCC IIHAKBEOLJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x824F130", Offset = "0x824E530", VA = "0x18824F130")]
	public static bool HAMBAJBCEOE(this RRObjectPrefabData ADIIJMJHCKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x824F160", Offset = "0x824E560", VA = "0x18824F160")]
	public static bool HAMBAJBCEOE(this KEPNMPHCHCC IIHAKBEOLJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x824F190", Offset = "0x824E590", VA = "0x18824F190")]
	public static PBMOMKKFMLL IFAGFFPKPPJ(this KEPNMPHCHCC HCOCMBHFGFG)
	{
		return default(PBMOMKKFMLL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x824F0C0", Offset = "0x824E4C0", VA = "0x18824F0C0")]
	internal static MIPCLLMFMNF ALPPJIMFLJC(this PBMOMKKFMLL LKHMPELKIJH)
	{
		return default(MIPCLLMFMNF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x824F0A0", Offset = "0x824E4A0", VA = "0x18824F0A0")]
	internal static MIPCLLMFMNF ALPPJIMFLJC(this KEPNMPHCHCC HCOCMBHFGFG)
	{
		return default(MIPCLLMFMNF);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
internal enum MIPCLLMFMNF
{
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	Container = 1000,
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	Empty = 4000,
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	Primitive = 2000,
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	Spline = 3000,
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	Other = 6000,
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	NativeObject = 5000,
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	GameObject = 7000,
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	Player = 8000
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
[RecRoom.DataLayer.RRGuid("A32413BC-21F3-4F7C-84B0-37724A854A67")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.Range(0, 8)]
public enum PBMOMKKFMLL
{
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	Container,
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	Primitive,
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	Spline,
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	Empty,
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	NativeObject,
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	Other,
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	GameObject,
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	Player
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public static class AKPKGNLNBMF
{
	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x824E390", Offset = "0x824D790", VA = "0x18824E390")]
	public static bool NDAGBBLFMAN(this PBMOMKKFMLL LKHMPELKIJH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
[RecRoom.DataLayer.RRGuid("7A0D34B5-FFE5-4C21-BB0C-CB3EBA34C797")]
[RecRoom.DataLayer.Range(0, BNADNEMKMMC.ALL)]
[Flags]
[RecRoom.DataLayer.NetworkEnum(3, false)]
public enum BNADNEMKMMC : ushort
{
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	NONE = 0,
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	PhysicsEnabled = 1,
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	GravityEnabled = 2,
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	HasCustomMass = 4,
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	CollisionEvent = 0x40,
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	CanUse = 0x200,
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	CanClimb = 0x400,
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	CanWallRun = 0x800,
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	CanClamber = 0x1000,
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	CanTeleport = 0x2000,
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	SuppressCollision = 0x4000,
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	DEFAULT = 0x3800,
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	ALL = 0x7E47,
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	MAX = 0x7E47
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[TypeManager.ForcedStableTypeHash(8060729269509364919uL)]
	[RecRoom.DataLayer.RRGuid("5D4503E7-6CC4-4938-8840-1B859C391878")]
	[RecRoom.DataLayer.StableTypeHash(8060729269509364919uL, 0u)]
	[CompilerGenerated]
	public struct PrimitiveShapeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public BFBNMLCCBFM shapeType;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
[RecRoom.DataLayer.Range(-1, 38)]
[RecRoom.DataLayer.RRGuid("517224CC-0A79-4FE9-B048-53C37955D823")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
public enum BFBNMLCCBFM
{
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	LegacyBox = 2,
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	RR_Sphere = 3,
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	RR_Cylinder = 4,
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	LEGACY_Wedge = 5,
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	LEGACY_Pyramid = 6,
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	LEGACY_TriggerVolumeBox = 7,
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	RR_Box = 8,
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	LEGACY_RoundedBox = 9,
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	RR_Wedge = 10,
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	RR_Pyramid = 11,
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	RR_HalfSphere = 12,
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	RR_Cone = 13,
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	RR_Pipe = 14,
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	RR_Donut = 15,
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	RR_HalfPipe = 16,
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	RR_Diamond = 17,
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	ADVANCED_Mound = 18,
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	ADVANCED_Cube = 19,
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	ADVANCED_Sphere = 20,
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	ADVANCED_Cylinder = 21,
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	ADVANCED_Cone = 22,
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	ADVANCED_Pyramid = 23,
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	ADVANCED_Octagon = 24,
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	ADVANCED_Triangle = 25,
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	ADVANCED_Hexagon = 26,
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	ADVANCED_QuarterPipe = 27,
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	ADVANCED_Pentagon = 28,
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	ADVANCED_Dodecahedron = 29,
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	ADVANCED_Trihedron = 30,
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	ADVANCED_Octahedron = 31,
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	RR_QuarterCylinder = 32,
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	RR_Pentagon = 33,
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	RR_QuarterSphere = 34,
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	ADVANCED_Wedge = 35,
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	RR_Hexagon = 36,
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	RR_Octagon = 37,
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	RR_Triangle = 38,
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	COUNT = 39,
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	MIN_VALUE = -1,
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	MAX_VALUE = 38
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
[RecRoom.DataLayer.RRGuid("3D27DF09-CAE2-4C3F-B808-03AD605F8E98")]
[RecRoom.DataLayer.Range(GDCPGHBNPPK.None, GDCPGHBNPPK.COUNT)]
[RecRoom.DataLayer.NetworkEnum(1, false)]
public enum GDCPGHBNPPK : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	AnimationGroup = 1,
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	COUNT = 2,
	[Cpp2IlInjected.Token(Token = "0x4000207")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	MAX = 2
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
[Flags]
[RecRoom.DataLayer.Range(0, 7)]
[RecRoom.DataLayer.RRGuid("1829B7EA-C0EA-4E77-8EB2-BA23E995C860")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
public enum HNPEOKBOCPL
{
	[Cpp2IlInjected.Token(Token = "0x400020A")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400020B")]
	DynamicUVProjection = 1,
	[Cpp2IlInjected.Token(Token = "0x400020C")]
	PreventInvertedCreation = 2,
	[Cpp2IlInjected.Token(Token = "0x400020D")]
	NewBendLogic = 4,
	[Cpp2IlInjected.Token(Token = "0x400020E")]
	All = 7,
	[Cpp2IlInjected.Token(Token = "0x400020F")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000210")]
	MAX = 7
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
[RecRoom.DataLayer.Range(0, 7)]
[RecRoom.DataLayer.RRGuid("CCB58F66-EF02-476E-820F-9D593E2C3DE5")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[Flags]
public enum ODFEMOHOCPF
{
	[Cpp2IlInjected.Token(Token = "0x4000212")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000213")]
	IsRibbon = 1,
	[Cpp2IlInjected.Token(Token = "0x4000214")]
	RoundedTubes = 2,
	[Cpp2IlInjected.Token(Token = "0x4000215")]
	OldStyleCaps = 4,
	[Cpp2IlInjected.Token(Token = "0x4000216")]
	All = 7,
	[Cpp2IlInjected.Token(Token = "0x4000217")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000218")]
	MAX = 7
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
[RecRoom.DataLayer.Range(LIJDKGLMFLG.Default, LIJDKGLMFLG.Count)]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.RRGuid("97516D96-FDF4-4ECC-881B-57A014A7D805")]
public enum LIJDKGLMFLG
{
	[Cpp2IlInjected.Token(Token = "0x400021A")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	Import,
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	Generate,
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	Ignore,
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	Count
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
[RecRoom.DataLayer.Range(FJHHAKPMJGL.Everywhere, FJHHAKPMJGL.MAX)]
[RecRoom.DataLayer.RRGuid("4913AA4C-C771-455C-AF49-938E5DEA653E")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
public enum FJHHAKPMJGL : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	Everywhere,
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	Center,
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	Edges,
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	North,
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	South,
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	East,
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	West,
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	RandomLines,
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	RandomBlobs,
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	MAX
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.RRGuid("4AD21D91-EFC4-4DAD-863D-4014EB5AB12D")]
[RecRoom.DataLayer.Range(CGJIJKGNEMN.Normal, CGJIJKGNEMN.MAX)]
public enum CGJIJKGNEMN : byte
{
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	Normal,
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	Steep,
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	Mesa,
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	MAX
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
[RecRoom.DataLayer.RRGuid("4DAD40E0-53B5-4B82-B53A-BC3E96F9B507")]
[RecRoom.DataLayer.Range(GLJNFGKKOAM.GentleSlopes, GLJNFGKKOAM.MAX)]
[RecRoom.DataLayer.NetworkEnum(1, false)]
public enum GLJNFGKKOAM : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	GentleSlopes,
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	RuggedSlopes,
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	Flat,
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	MediumSlopes,
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	RiverBed,
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	MAX
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
[RecRoom.DataLayer.Range(PBFAHNBOMEH.Circle, PBFAHNBOMEH.MAX)]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.RRGuid("966E2586-2CE9-4280-898A-894565917A54")]
public enum PBFAHNBOMEH : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	Circle,
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	Square,
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	MAX
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
[Flags]
[RecRoom.DataLayer.RRGuid("72742F9B-D48E-4CED-B403-444201FFEE66")]
[RecRoom.DataLayer.Range(0, 1)]
[RecRoom.DataLayer.NetworkEnum(1, false)]
public enum IMPKOJJLIDN
{
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	Static = 0,
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	Dynamic = 1,
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	All = 1
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
[RecRoom.DataLayer.Range(-2, 2)]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.RRGuid("C5BE1CDA-5EF5-4EBF-BC7E-3E3510C68A7F")]
public enum IFFBGKJLFIG
{
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	Frozen = -2,
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	Low = -1,
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	Normal = 0,
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	High = 1,
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	Realtime = 2,
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	Default = 0,
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	MIN = -2,
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	MAX = 2
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
[RecRoom.DataLayer.Range(int.MinValue, int.MaxValue)]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.RRGuid("D6AFAFED-8BAA-4499-9696-9CBB716EF514")]
public enum GEGMIDKLLFN
{
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	Red = 0,
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	Orange = 1,
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	Yellow = 2,
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	LightGreen = 3,
	[Cpp2IlInjected.Token(Token = "0x400024E")]
	Blue = 4,
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	LightBlue = 5,
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	Teal = 6,
	[Cpp2IlInjected.Token(Token = "0x4000251")]
	Green = 7,
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	Purple = 8,
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	LightPink = 9,
	[Cpp2IlInjected.Token(Token = "0x4000254")]
	Pink = 10,
	[Cpp2IlInjected.Token(Token = "0x4000255")]
	Brown = 11,
	[Cpp2IlInjected.Token(Token = "0x4000256")]
	Tan = 12,
	[Cpp2IlInjected.Token(Token = "0x4000257")]
	White = 13,
	[Cpp2IlInjected.Token(Token = "0x4000258")]
	Grey = 14,
	[Cpp2IlInjected.Token(Token = "0x4000259")]
	DarkGrey = 15,
	[Cpp2IlInjected.Token(Token = "0x400025A")]
	DarkBrown = 16,
	[Cpp2IlInjected.Token(Token = "0x400025B")]
	LightBrown = 17,
	[Cpp2IlInjected.Token(Token = "0x400025C")]
	LightGrey = 18,
	[Cpp2IlInjected.Token(Token = "0x400025D")]
	Black = 19,
	[Cpp2IlInjected.Token(Token = "0x400025E")]
	DarkRed = 20,
	[Cpp2IlInjected.Token(Token = "0x400025F")]
	DarkOrange = 21,
	[Cpp2IlInjected.Token(Token = "0x4000260")]
	DarkYellow = 22,
	[Cpp2IlInjected.Token(Token = "0x4000261")]
	DarkGreen = 23,
	[Cpp2IlInjected.Token(Token = "0x4000262")]
	DarkTeal = 24,
	[Cpp2IlInjected.Token(Token = "0x4000263")]
	DarkBlue = 25,
	[Cpp2IlInjected.Token(Token = "0x4000264")]
	DarkPurple = 26,
	[Cpp2IlInjected.Token(Token = "0x4000265")]
	DarkPink = 27,
	[Cpp2IlInjected.Token(Token = "0x4000266")]
	LightRed = 28,
	[Cpp2IlInjected.Token(Token = "0x4000267")]
	LightOrange = 29,
	[Cpp2IlInjected.Token(Token = "0x4000268")]
	LightYellow = 30,
	[Cpp2IlInjected.Token(Token = "0x4000269")]
	Cyan = 31,
	[Cpp2IlInjected.Token(Token = "0x400026A")]
	LightPurple = 32,
	[Cpp2IlInjected.Token(Token = "0x400026B")]
	DarkTan = 33,
	[Cpp2IlInjected.Token(Token = "0x400026C")]
	NewColor1 = 34,
	[Cpp2IlInjected.Token(Token = "0x400026D")]
	NewColor2 = 35,
	[Cpp2IlInjected.Token(Token = "0x400026E")]
	NewColor3 = 36,
	[Cpp2IlInjected.Token(Token = "0x400026F")]
	NewColor4 = 37,
	[Cpp2IlInjected.Token(Token = "0x4000270")]
	NewColor5 = 38,
	[Cpp2IlInjected.Token(Token = "0x4000271")]
	NewColor6 = 39,
	[Cpp2IlInjected.Token(Token = "0x4000272")]
	NewColor7 = 40,
	[Cpp2IlInjected.Token(Token = "0x4000273")]
	NewColor8 = 41,
	[Cpp2IlInjected.Token(Token = "0x4000274")]
	NewColor9 = 42,
	[Cpp2IlInjected.Token(Token = "0x4000275")]
	NewColor10 = 43,
	[Cpp2IlInjected.Token(Token = "0x4000276")]
	NewColor11 = 44,
	[Cpp2IlInjected.Token(Token = "0x4000277")]
	NewColor12 = 45,
	[Cpp2IlInjected.Token(Token = "0x4000278")]
	NewColor13 = 46,
	[Cpp2IlInjected.Token(Token = "0x4000279")]
	NewColor14 = 47,
	[Cpp2IlInjected.Token(Token = "0x400027A")]
	NewColor15 = 48,
	[Cpp2IlInjected.Token(Token = "0x400027B")]
	NewColor16 = 49,
	[Cpp2IlInjected.Token(Token = "0x400027C")]
	NewColor17 = 50,
	[Cpp2IlInjected.Token(Token = "0x400027D")]
	NewColor18 = 51,
	[Cpp2IlInjected.Token(Token = "0x400027E")]
	NewColor19 = 52,
	[Cpp2IlInjected.Token(Token = "0x400027F")]
	NewColor20 = 53,
	[Cpp2IlInjected.Token(Token = "0x4000280")]
	NewColor21 = 54,
	[Cpp2IlInjected.Token(Token = "0x4000281")]
	NewColor22 = 55,
	[Cpp2IlInjected.Token(Token = "0x4000282")]
	NewColor23 = 56,
	[Cpp2IlInjected.Token(Token = "0x4000283")]
	NewColor24 = 57,
	[Cpp2IlInjected.Token(Token = "0x4000284")]
	NewColor25 = 58,
	[Cpp2IlInjected.Token(Token = "0x4000285")]
	NewColor26 = 59,
	[Cpp2IlInjected.Token(Token = "0x4000286")]
	NewColor27 = 60,
	[Cpp2IlInjected.Token(Token = "0x4000287")]
	Default = 0
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
[RecRoom.DataLayer.Range(-1, 31)]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.RRGuid("C57BE511-BA1A-4D83-BA58-303F34F4DE74")]
public enum HPLJMLNNILP
{
	[Cpp2IlInjected.Token(Token = "0x4000289")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x400028A")]
	Cardboard = 0,
	[Cpp2IlInjected.Token(Token = "0x400028B")]
	Neon = 1,
	[Cpp2IlInjected.Token(Token = "0x400028C")]
	Brick = 2,
	[Cpp2IlInjected.Token(Token = "0x400028D")]
	Carpet = 3,
	[Cpp2IlInjected.Token(Token = "0x400028E")]
	Dirt = 4,
	[Cpp2IlInjected.Token(Token = "0x400028F")]
	Grass = 5,
	[Cpp2IlInjected.Token(Token = "0x4000290")]
	MetalReflective = 6,
	[Cpp2IlInjected.Token(Token = "0x4000291")]
	Concrete = 7,
	[Cpp2IlInjected.Token(Token = "0x4000292")]
	Linoleum = 8,
	[Cpp2IlInjected.Token(Token = "0x4000293")]
	Plaster = 9,
	[Cpp2IlInjected.Token(Token = "0x4000294")]
	WoodLogs = 10,
	[Cpp2IlInjected.Token(Token = "0x4000295")]
	WoodBoards = 11,
	[Cpp2IlInjected.Token(Token = "0x4000296")]
	WoodGrain = 12,
	[Cpp2IlInjected.Token(Token = "0x4000297")]
	WoodFloor = 13,
	[Cpp2IlInjected.Token(Token = "0x4000298")]
	Sand = 14,
	[Cpp2IlInjected.Token(Token = "0x4000299")]
	GlossyPlastic = 15,
	[Cpp2IlInjected.Token(Token = "0x400029A")]
	Cloth = 16,
	[Cpp2IlInjected.Token(Token = "0x400029B")]
	RubberFloor = 17,
	[Cpp2IlInjected.Token(Token = "0x400029C")]
	MetalFloorTread = 18,
	[Cpp2IlInjected.Token(Token = "0x400029D")]
	PaintedBrick = 19,
	[Cpp2IlInjected.Token(Token = "0x400029E")]
	Crashpad = 20,
	[Cpp2IlInjected.Token(Token = "0x400029F")]
	PaintedWood = 21,
	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	GripTape = 22,
	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	GalvanizedMetal = 23,
	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	ParticleBoard = 24,
	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	CheckeredFloor = 25,
	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	SparklyVinyl = 26,
	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	Gravel = 27,
	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	Rock = 28,
	[Cpp2IlInjected.Token(Token = "0x40002A7")]
	Placeholder29 = 29,
	[Cpp2IlInjected.Token(Token = "0x40002A8")]
	Placeholder30 = 30,
	[Cpp2IlInjected.Token(Token = "0x40002A9")]
	Placeholder31 = 31,
	[Cpp2IlInjected.Token(Token = "0x40002AA")]
	COUNT = 32,
	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	MIN = -1,
	[Cpp2IlInjected.Token(Token = "0x40002AC")]
	MAX = 31,
	[Cpp2IlInjected.Token(Token = "0x40002AD")]
	Default = 0
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
[RecRoom.DataLayer.NetworkInterface(1, false)]
[RecRoom.DataLayer.RRGuid("CEFA84DC-B72D-4313-B0DB-FDFF30A6FCDC")]
public interface JBLCKMMHLIG : DCDKAIBLHNM
{
	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	[RecRoom.DataLayer.Default]
	[RecRoom.DataLayer.Field(1)]
	[Set.Any]
	[RecRoom.DataLayer.Key("MP_MSF")]
	[CanDesync]
	FixedString32Bytes FMJDCGKEOAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	[CanDesync]
	[Set.Any]
	[RecRoom.DataLayer.Field(2)]
	[RuntimeOnly]
	[RecRoom.DataLayer.Key("MP_MGR")]
	[RecRoom.DataLayer.Default]
	(long RequestId, int ActorNumber, int ServerTimestamp) LCFINKHNBDK
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action KFFJDDOCBCK;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action LPCMLBFOGHM;
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
[RecRoom.DataLayer.RRGuid("B23E7E5C-828C-4A29-9AB2-774DFC53D18E")]
[RecRoom.DataLayer.NetworkInterface(1, false)]
public interface JHOKCELOIPE : DCDKAIBLHNM
{
	[Cpp2IlInjected.Token(Token = "0x17000021")]
	[RecRoom.DataLayer.Field(1)]
	[Set.Auth]
	[ProtoProp("PersistenceViewData.SandboxDeformationData.Deformation", typeof(GHOGGHFCKAI))]
	[RecRoom.DataLayer.Key("SBDScale")]
	[RecRoom.DataLayer.Default]
	float3 HNGFPHJMIIF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action LCLNKDIGBLH;
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
[RecRoom.DataLayer.NetworkStruct(1, false)]
[RecRoom.DataLayer.RRGuid("112F004A-C92F-4055-99F9-D430EC13FE3C")]
public struct OJNFHONPFAP : IComparable<OJNFHONPFAP>, IEquatable<OJNFHONPFAP>
{
	[Cpp2IlInjected.Token(Token = "0x40002AE")]
	public static readonly OJNFHONPFAP BOBPMJBGCMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002AF")]
	[RecRoom.DataLayer.Field(1)]
	public uint OOIDEANKLHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40002B0")]
	[RecRoom.DataLayer.Field(2)]
	public uint LAJDIIEEBFO;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	private readonly uint DIJFAINACIE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x82514E0", Offset = "0x82508E0", VA = "0x1882514E0")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public readonly bool JDPJAANKGAC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x82518B0", Offset = "0x8250CB0", VA = "0x1882518B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x8251A70", Offset = "0x8250E70", VA = "0x188251A70")]
	public OJNFHONPFAP(int OOIDEANKLHC, int OLGMBJKFNKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x8251A70", Offset = "0x8250E70", VA = "0x188251A70")]
	public OJNFHONPFAP(uint OOIDEANKLHC, uint OLGMBJKFNKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x8251AD0", Offset = "0x8250ED0", VA = "0x188251AD0")]
	private OJNFHONPFAP(uint OOIDEANKLHC, uint OLGMBJKFNKG, bool EAKKCBNLIAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x8251470", Offset = "0x8250870", VA = "0x188251470")]
	public OJNFHONPFAP DBFIBENFPBO(int FDIDNNCIDHK = 1)
	{
		return default(OJNFHONPFAP);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x82513E0", Offset = "0x82507E0", VA = "0x1882513E0")]
	public OJNFHONPFAP BGANLPIAAFC(int FDIDNNCIDHK = 1)
	{
		return default(OJNFHONPFAP);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x82514F0", Offset = "0x82508F0", VA = "0x1882514F0")]
	public static OJNFHONPFAP EJKOJFJJOKI(OJNFHONPFAP JLJHECODIOL, OJNFHONPFAP DABLONGJEGN)
	{
		return default(OJNFHONPFAP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x8251950", Offset = "0x8250D50", VA = "0x188251950")]
	private static ulong NAFJNHHLDEG(ulong HCFCOMCPJPA, ulong JOCIBENNGKI)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x8251450", Offset = "0x8250850", VA = "0x188251450", Slot = "4")]
	public int CompareTo(OJNFHONPFAP LHDOHAKINKP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x82517F0", Offset = "0x8250BF0", VA = "0x1882517F0", Slot = "0")]
	public override bool Equals(object DEJGDIIDCDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x8251990", Offset = "0x8250D90", VA = "0x188251990", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x8251890", Offset = "0x8250C90", VA = "0x188251890", Slot = "5")]
	public bool Equals(OJNFHONPFAP LHDOHAKINKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x82518C0", Offset = "0x8250CC0", VA = "0x1882518C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x3CF8720", Offset = "0x3CF7B20", VA = "0x183CF8720")]
	public static bool ILMCFLMCOJH(OJNFHONPFAP JLJHECODIOL, OJNFHONPFAP DABLONGJEGN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x82513C0", Offset = "0x82507C0", VA = "0x1882513C0")]
	public static bool AMDBHCBNEEF(OJNFHONPFAP JLJHECODIOL, OJNFHONPFAP DABLONGJEGN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x8251930", Offset = "0x8250D30", VA = "0x188251930")]
	public static bool LGPMICEJJPF(OJNFHONPFAP JLJHECODIOL, OJNFHONPFAP DABLONGJEGN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x8251910", Offset = "0x8250D10", VA = "0x188251910")]
	public static bool JOBEEIKIGEN(OJNFHONPFAP JLJHECODIOL, OJNFHONPFAP DABLONGJEGN)
	{
		return default(bool);
	}
}
namespace RecRoom.DataLayer
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	[RecRoom.DataLayer.RRGuid("D3AB0F52-EA41-4891-9470-6E945A9D6583")]
	[RecRoom.DataLayer.NetworkStruct(1, false)]
	public struct NetworkGuid : IEquatable<NetworkGuid>, IComparable<NetworkGuid>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		[RecRoom.DataLayer.Field(1)]
		public int4 data;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Guid Guid
		{
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x1243A30", Offset = "0x1242E30", VA = "0x181243A30")]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x146A160", Offset = "0x1469560", VA = "0x18146A160")]
			set
			{
			}
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x1243A30", Offset = "0x1242E30", VA = "0x181243A30")]
		public static Guid GKKMDDPCKIG(NetworkGuid OOOANFDGEED)
		{
			return default(Guid);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x1243A30", Offset = "0x1242E30", VA = "0x181243A30")]
		public static NetworkGuid GKKMDDPCKIG(Guid OOOANFDGEED)
		{
			return default(NetworkGuid);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x8251120", Offset = "0x8250520", VA = "0x188251120", Slot = "4")]
		public bool Equals(NetworkGuid LHDOHAKINKP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x530E7E0", Offset = "0x530DBE0", VA = "0x18530E7E0", Slot = "5")]
		public int CompareTo(NetworkGuid LHDOHAKINKP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x8251150", Offset = "0x8250550", VA = "0x188251150", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
[RecRoom.DataLayer.RRGuid("9F5F33BE-7C0A-4870-9CE0-BA79440E7F98")]
[RecRoom.DataLayer.NetworkStruct(1, false)]
public struct ICHHKDNLLPL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002B2")]
	[RecRoom.DataLayer.Field(1)]
	public bool DGKJCLCLLMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40002B3")]
	[RecRoom.DataLayer.Field(2)]
	public float3 IFNIKKCAEDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002B4")]
	[RecRoom.DataLayer.Field(3)]
	public float3 COPNKDDHOIJ;

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x824CB10", Offset = "0x824BF10", VA = "0x18824CB10")]
	public ICHHKDNLLPL(float FELPICHHHLC, float IDCCLFDFCEL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
[RecRoom.DataLayer.NetworkStruct(1, false)]
[RecRoom.DataLayer.RRGuid("35984D5B-ACBD-4389-A94B-840070A871E2")]
public struct BFGADLCEFPF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002B5")]
	[RecRoom.DataLayer.Field(1)]
	public float DFFOCIFLKBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40002B6")]
	[RecRoom.DataLayer.Field(2)]
	public int NGFMBEFFJCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40002B7")]
	[RecRoom.DataLayer.Field(3)]
	public ODFEMOHOCPF DPALHGCDOLB;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public bool GFMCGDGBAEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x824EC20", Offset = "0x824E020", VA = "0x18824EC20")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x824EBD0", Offset = "0x824DFD0", VA = "0x18824EBD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public bool HNCCECMKHON
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x824EBF0", Offset = "0x824DFF0", VA = "0x18824EBF0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x824EC30", Offset = "0x824E030", VA = "0x18824EC30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool AFJMPBCMPHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x824EBC0", Offset = "0x824DFC0", VA = "0x18824EBC0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x824EC00", Offset = "0x824E000", VA = "0x18824EC00")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
[RecRoom.DataLayer.NetworkStruct(1, false)]
[RecRoom.DataLayer.RRGuid("88EB8A39-C735-43FA-8414-C0B7AEEF4FF6")]
public struct GCFFMGKDNLP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002B8")]
	[RecRoom.DataLayer.Field(1)]
	public GEGMIDKLLFN OEIPOCOOFKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	[RecRoom.DataLayer.Field(2)]
	public HPLJMLNNILP FHELPMHCHCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	[RecRoom.DataLayer.Field(3)]
	public GEGMIDKLLFN NFECCNCDAPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	[RecRoom.DataLayer.Field(4)]
	public HPLJMLNNILP AAJJEFOOIOD;
}
namespace RecRoom.DataLayer
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[RecRoom.DataLayer.RRGuid("CE1911D2-B422-4E58-B0D6-2474AEA69D41")]
	[RecRoom.DataLayer.NetworkStruct(1, false)]
	public struct TerrainGenerationLayer
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		[RecRoom.DataLayer.Field(1)]
		public GLJNFGKKOAM TerrainRoughness;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		[RecRoom.DataLayer.Field(2)]
		public FJHHAKPMJGL TerrainShape;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		[RecRoom.DataLayer.Field(3)]
		public CGJIJKGNEMN HeightFunction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		[RecRoom.DataLayer.Field(4)]
		public float FeatureScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		[RecRoom.DataLayer.Field(5)]
		public float Height;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
public struct LPDMMEHBJGN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002C1")]
	public MECLGJLEBLN DDEDGOAKMIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40002C2")]
	public int LCPPPKMGHKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40002C3")]
	public bool COOIHAEOEHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD")]
	[Cpp2IlInjected.Token(Token = "0x40002C4")]
	public bool NKNDDNALLNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE")]
	[Cpp2IlInjected.Token(Token = "0x40002C5")]
	public bool PBILJAPDDHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002C6")]
	public Vector3 BKPAIEKHLGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40002C7")]
	public Quaternion GGEGPGBJIHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40002C8")]
	public bool NGMLOLNGFAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002C9")]
	public Vector3 HNGFPHJMIIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40002CA")]
	public Vector3 PNPNAIDPCCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40002CB")]
	public Vector3 OLDECIJOCNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x40002CC")]
	public bool MMJAAIBKAME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40002CD")]
	public ViewId MDMGPCBIPIJ;

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x824F520", Offset = "0x824E920", VA = "0x18824F520", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
public struct PEOEKKEOCIM : IEquatable<PEOEKKEOCIM>, IComparable<PEOEKKEOCIM>
{
	[Cpp2IlInjected.Token(Token = "0x40002CE")]
	public static readonly int BIICCFIKJGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002CF")]
	public RRObjectPrefabData MKFMLBCIMEB;

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x8252470", Offset = "0x8251870", VA = "0x188252470", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x82522D0", Offset = "0x82516D0", VA = "0x1882522D0", Slot = "4")]
	public bool Equals(PEOEKKEOCIM LHDOHAKINKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x8252340", Offset = "0x8251740", VA = "0x188252340", Slot = "0")]
	public override bool Equals(object DEJGDIIDCDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x8252440", Offset = "0x8251840", VA = "0x188252440", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x8252250", Offset = "0x8251650", VA = "0x188252250", Slot = "5")]
	public int CompareTo(PEOEKKEOCIM LHDOHAKINKP)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
internal class HGFBPGFDOIF : ContainerPropertyBag<KFNNMIHFMBA>
{
	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x824EFD0", Offset = "0x824E3D0", VA = "0x18824EFD0")]
	public HGFBPGFDOIF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
internal class PEIEPDEJIJC : ContainerPropertyBag<RRObjectPrefabData>
{
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	private class OCENIAPGLCG : Property<RRObjectPrefabData, KEPNMPHCHCC>
	{
		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public override string GODGCHFEMGD
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x8251260", Offset = "0x8250660", VA = "0x188251260", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public override bool NBPHDBEEFKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0xAB9810", Offset = "0xAB8C10", VA = "0x180AB9810", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x8251170", Offset = "0x8250570", VA = "0x188251170")]
		public OCENIAPGLCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x142C4C0", Offset = "0x142B8C0", VA = "0x18142C4C0", Slot = "14")]
		public override KEPNMPHCHCC GetValue(RRObjectPrefabData MNCIANLLPKI)
		{
			return default(KEPNMPHCHCC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x824C690", Offset = "0x824BA90", VA = "0x18824C690", Slot = "15")]
		public override void SetValue(RRObjectPrefabData MNCIANLLPKI, KEPNMPHCHCC CBMEHPPMEEA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	private class OHACBJABPEH : Property<RRObjectPrefabData, Guid>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public override string GODGCHFEMGD
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x8251390", Offset = "0x8250790", VA = "0x188251390", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override bool NBPHDBEEFKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0xAB9810", Offset = "0xAB8C10", VA = "0x180AB9810", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x82512A0", Offset = "0x82506A0", VA = "0x1882512A0")]
		public OHACBJABPEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x2C5E580", Offset = "0x2C5D980", VA = "0x182C5E580", Slot = "14")]
		public override Guid GetValue(RRObjectPrefabData MNCIANLLPKI)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x8251290", Offset = "0x8250690", VA = "0x188251290", Slot = "15")]
		public override void SetValue(RRObjectPrefabData MNCIANLLPKI, Guid CBMEHPPMEEA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x8251FC0", Offset = "0x82513C0", VA = "0x188251FC0")]
	public PEIEPDEJIJC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
internal class HKOMJGOBPHG : ContainerPropertyBag<Guid>
{
	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x824F030", Offset = "0x824E430", VA = "0x18824F030")]
	public HKOMJGOBPHG()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x82524C0", Offset = "0x82518C0", VA = "0x1882524C0")]
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
