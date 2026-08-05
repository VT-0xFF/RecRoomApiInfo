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
		[Cpp2IlInjected.Address(RVA = "0xA873F0", Offset = "0xA85FF0", VA = "0x180A873F0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA873F0", Offset = "0xA85FF0", VA = "0x180A873F0")]
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
	public class LogRegistrationIndex : MMLLDFGFMPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x80A3870", Offset = "0x80A2470", VA = "0x1880A3870", Slot = "4")]
		public override void AMHLLDBNIFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA873F0", Offset = "0xA85FF0", VA = "0x180A873F0")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct MFCFDAHEKFH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private bool ACFEJCNNBKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private ViewId ECLEFOAKJDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private int HDEKJKJDEIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private bool AEOHGJBPNOG;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x80A3A20", Offset = "0x80A2620", VA = "0x1880A3A20")]
	public MFCFDAHEKFH(ViewId ECLEFOAKJDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x80A3A40", Offset = "0x80A2640", VA = "0x1880A3A40")]
	public MFCFDAHEKFH(int HDEKJKJDEIC, bool AEOHGJBPNOG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x80A3940", Offset = "0x80A2540", VA = "0x1880A3940")]
	public ViewId PIPCNMFCPAB([Optional] ViewId AGOFMAMNFIB)
	{
		return default(ViewId);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class CLGCPKPBIPJ
{
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly Guid FBMJANACLKF;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static readonly Guid LBEODEEAKCK;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static readonly Guid KKIKOANIMAE;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public static readonly Guid PMNLJBOAGPA;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly Guid DJBLLELOHEO;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public static readonly Dictionary<string, Guid> HHEKKPIEKKG;

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static readonly RRObjectPrefabData OOMNAHGAIPF;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly RRObjectPrefabData FPBABJKDOLL;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly RRObjectPrefabData DBKFFNPDDHN;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x80A13C0", Offset = "0x809FFC0", VA = "0x1880A13C0")]
	public static Guid HGBMIAKIDOC(string BKILENEPEEB)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x80A1350", Offset = "0x809FF50", VA = "0x1880A1350")]
	public static RRObjectPrefabData EMFMPFCHAPO(IBLPJFKLOID MDCDODCGNEK)
	{
		return default(RRObjectPrefabData);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x80A13F0", Offset = "0x809FFF0", VA = "0x1880A13F0")]
	public static RRObjectPrefabData MNDAMDBBAJP(IBLPJFKLOID MDCDODCGNEK)
	{
		return default(RRObjectPrefabData);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x80A1330", Offset = "0x809FF30", VA = "0x1880A1330")]
	public static RRObjectPrefabData BOLEDKHIHHE(Guid FHNOHJCOOKK)
	{
		return default(RRObjectPrefabData);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[DefaultMember("Item")]
public class PECJBNMGEAA : IComponentData, ICloneable, JHHAIBKFOIP
{
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static readonly PEOHNMCPNIJ GDLIBGFAMED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly Dictionary<int, object> CBCNBAPLLJM;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public Dictionary<int, object> OHABHFNOKHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xA5B540", Offset = "0xA5A140", VA = "0x180A5B540")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public object KLGHGIBKAEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x80A4950", Offset = "0x80A3550", VA = "0x1880A4950")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x80A4A00", Offset = "0x80A3600", VA = "0x1880A4A00")]
	public PECJBNMGEAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0xA628A0", Offset = "0xA614A0", VA = "0x180A628A0")]
	public PECJBNMGEAA(Dictionary<int, object> CBCNBAPLLJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x80A47F0", Offset = "0x80A33F0", VA = "0x1880A47F0", Slot = "5")]
	public bool IDFBIODBNNP(LDDCABDMBLN DHCHBFGMFFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x80A4850", Offset = "0x80A3450", VA = "0x1880A4850", Slot = "6")]
	public void JOKGPOMAEFF(PEOHNMCPNIJ GDLIBGFAMED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x3E08B30", Offset = "0x3E07730", VA = "0x183E08B30")]
	public void FBPLMOFAHPD<T>(LDDCABDMBLN DHCHBFGMFFD, T BKMPCFIAHIG, [Optional] T PLEDLJICBFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3E08FE0", Offset = "0x3E07BE0", VA = "0x183E08FE0")]
	public void IEFFBEILLPC<T>(LDDCABDMBLN DHCHBFGMFFD, T BKMPCFIAHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x80A4790", Offset = "0x80A3390", VA = "0x1880A4790")]
	public void ENKPLOICKCM(LDDCABDMBLN DHCHBFGMFFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x80A4720", Offset = "0x80A3320", VA = "0x1880A4720", Slot = "4")]
	public object Clone()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum LDDCABDMBLN : byte
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
	ConsumableSeed
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct EDJNJJGLCLB<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly LDDCABDMBLN DHCHBFGMFFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly T PLEDLJICBFM;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x48CD6A0", Offset = "0x48CC2A0", VA = "0x1848CD6A0")]
	public EDJNJJGLCLB(LDDCABDMBLN DHCHBFGMFFD, T PLEDLJICBFM)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x48CD470", Offset = "0x48CC070", VA = "0x1848CD470")]
	public static EDJNJJGLCLB<T> KDDDGPNBGLG(LDDCABDMBLN DHCHBFGMFFD)
	{
		return default(EDJNJJGLCLB<T>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x48CD3E0", Offset = "0x48CBFE0", VA = "0x1848CD3E0")]
	public static EDJNJJGLCLB<T> KDDDGPNBGLG((LDDCABDMBLN key, T value) JPILOOHOBDJ)
	{
		return default(EDJNJJGLCLB<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface JHHAIBKFOIP
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IDFBIODBNNP(LDDCABDMBLN DHCHBFGMFFD);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JOKGPOMAEFF(PEOHNMCPNIJ GDLIBGFAMED);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(JAFANJEBFPL))]
public struct MJAPGGNPMGD : IEnumerable<object>, IEnumerable, JHHAIBKFOIP
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	private class JAFANJEBFPL : Dictionary<string, object>
	{
	}

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private static readonly PEOHNMCPNIJ GDLIBGFAMED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private Dictionary<int, object> KCHMACEBLIA;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool AKCFPEAFOFL
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x19852C0", Offset = "0x1983EC0", VA = "0x1819852C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int POLDAEOLMKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x80A3CF0", Offset = "0x80A28F0", VA = "0x1880A3CF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x80A3D40", Offset = "0x80A2940", VA = "0x1880A3D40")]
	public static MJAPGGNPMGD FOGKIHKKOLG()
	{
		return default(MJAPGGNPMGD);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0xE4EA80", Offset = "0xE4D680", VA = "0x180E4EA80")]
	public MJAPGGNPMGD([Optional] Dictionary<int, object> KCHMACEBLIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x3D56A40", Offset = "0x3D55640", VA = "0x183D56A40")]
	public void NDGLNAHKHEG<T>(EDJNJJGLCLB<T> DHCHBFGMFFD, T? BKMPCFIAHIG) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x3D569D0", Offset = "0x3D555D0", VA = "0x183D569D0")]
	public void NDGLNAHKHEG<T>((EDJNJJGLCLB<T> key, T value) FODCMGFFFBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3D56870", Offset = "0x3D55470", VA = "0x183D56870")]
	public void NDGLNAHKHEG<T>(EDJNJJGLCLB<T> DHCHBFGMFFD, T BKMPCFIAHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x80A3F70", Offset = "0x80A2B70", VA = "0x1880A3F70")]
	public void MDMBKAPGMLH(MJAPGGNPMGD OJNBCCCOMPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x80A3C20", Offset = "0x80A2820", VA = "0x1880A3C20")]
	private void CBACPPGGEHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3D54200", Offset = "0x3D52E00", VA = "0x183D54200")]
	public bool GLNNPKODOFD<T>(EDJNJJGLCLB<T> DHCHBFGMFFD, [Out] T BKMPCFIAHIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3D54280", Offset = "0x3D52E80", VA = "0x183D54280", Slot = "8")]
	public bool GLNNPKODOFD<T>(LDDCABDMBLN DHCHBFGMFFD, [Out] T BKMPCFIAHIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3D56570", Offset = "0x3D55170", VA = "0x183D56570")]
	public T IDGMKNIAEKP<T>(EDJNJJGLCLB<T> DHCHBFGMFFD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3D56450", Offset = "0x3D55050", VA = "0x183D56450")]
	public bool IDFBIODBNNP<T>(EDJNJJGLCLB<T> DHCHBFGMFFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x80A3E20", Offset = "0x80A2A20", VA = "0x1880A3E20", Slot = "6")]
	public bool IDFBIODBNNP(LDDCABDMBLN DHCHBFGMFFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3D53EF0", Offset = "0x3D52AF0", VA = "0x183D53EF0")]
	public void ENKPLOICKCM<T>(EDJNJJGLCLB<T> DHCHBFGMFFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x80A3CA0", Offset = "0x80A28A0", VA = "0x1880A3CA0")]
	public void ENKPLOICKCM(LDDCABDMBLN DHCHBFGMFFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0xAF3D70", Offset = "0xAF2970", VA = "0x180AF3D70")]
	public Dictionary<int, object> KPCADEIONMB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x80A3DC0", Offset = "0x80A29C0", VA = "0x1880A3DC0", Slot = "4")]
	public IEnumerator<object> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x80A4180", Offset = "0x80A2D80", VA = "0x1880A4180", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x80A3E80", Offset = "0x80A2A80", VA = "0x1880A3E80", Slot = "7")]
	public void JOKGPOMAEFF(PEOHNMCPNIJ GDLIBGFAMED)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public enum HNHMAFCFMFC
{
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	PrefabComponents,
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	LocalObjectComponents,
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	NetworkedObjectComponents,
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	PolicyComponents,
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	ConnectableComponents,
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	RbexComponents,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	TransformPoseComponents,
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	UniformTransformComponents,
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	DeformableSizeComponents,
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	ShapeComponents,
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	PrimitiveComponents,
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	SplineComponents,
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	SplinePointComponents,
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	ContainerComponents,
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	ContainerLikeComponents,
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	ReplicatorComponents,
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	ContainerPivotComponents,
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	ShapeContainerComponents,
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	CostumePieceComponents,
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	PreventSerializationComponent,
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	DontPropagatePhysicsComponent,
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	DontPropagateOwnershipComponent,
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	LegacyGameObjectComponents,
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	GameObjectLegacyGizmoComponents,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	GameObjectCostumeDummyPropComponents,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	PlayerComponents,
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	PlayerRbexComponents,
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	PlayerTransformComponents,
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	RequireEmbodiedComponents,
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	EntityPrefabRootComponents,
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	EntityPrefabPartComponents,
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	SocketComponents,
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	VisibleInHierarchyComponents,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	ToolCleanupComponents,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	TagComponents,
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	InteractionFilterTagComponents,
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	AutoEmbodimentComponents,
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	ReferenceGroupComponents,
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	UserTagStorageComponents,
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	ReplicatedObjectComponents,
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	InteractionFilteringSettingsComponents,
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	InventionTrackingComponents,
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	ObjectBoardComponents,
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	NetworkTransformComponents,
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	AlwaysEmbodiedScopeComponents,
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	LoadInstanceLifetimeComponents,
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	PhysicsModelComponents,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	StudioPropObjectComponents,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	AnimationControllerComponents,
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	StudioObjectComponents,
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	DesyncNetworkObjectComponents,
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	AuthoredPoseComponents,
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	HasCustomInertialPropertiesWhenRootComponents,
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	MagneticAnchorComponents,
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	SnapPointComponents,
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	TerrainGeneratorComponents
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface HBNCMEMJHAL
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public enum PGEKPLONJBI
	{
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		Entity,
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		Prefab
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	LocalId NGHFCIGNAPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	RRObjectPrefabData JINAEOICEMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KHDMCLKJAFA(params string[] OBELFLFLBMI);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void AMIDECCDBMM(HNHMAFCFMFC DOJFGKNBPBM, PGEKPLONJBI CEBNHJNKAJN = PGEKPLONJBI.Entity);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MJFGIMDDCHJ(Type MDCDODCGNEK, ReadOnlySpan<byte> CBCNBAPLLJM, int ANPKEKOAAAJ, PGEKPLONJBI CEBNHJNKAJN = PGEKPLONJBI.Entity);

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LFNHHLFICBJ(Type MDCDODCGNEK, PGEKPLONJBI CEBNHJNKAJN = PGEKPLONJBI.Entity);

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ILIBJGPJCOA(HNHMAFCFMFC DOJFGKNBPBM, PGEKPLONJBI CEBNHJNKAJN = PGEKPLONJBI.Entity);

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool IAIEBPPIJPL(HNHMAFCFMFC DOJFGKNBPBM);

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void FINGLBJMGOI(bool NKJMAEOCIAK, PGEKPLONJBI CEBNHJNKAJN = PGEKPLONJBI.Entity);

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void OIPOIKAIOJA();

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void BBLIMBJMCOH(Type MDCDODCGNEK);

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "11")]
	GKNPGOIAOJL CAPLMLDIIHN(Type MDCDODCGNEK);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class LCGNBBOJGHI
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x80A3230", Offset = "0x80A1E30", VA = "0x1880A3230")]
	public static bool GGDMMGLNNPP(this HBNCMEMJHAL PBHLPKLGFAP, HNHMAFCFMFC KAPGMCDEGPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x80A3170", Offset = "0x80A1D70", VA = "0x1880A3170")]
	public static void AMKEHJAPHHG(this HBNCMEMJHAL PBHLPKLGFAP, HBNCMEMJHAL.PGEKPLONJBI CEBNHJNKAJN = HBNCMEMJHAL.PGEKPLONJBI.Entity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x80A31D0", Offset = "0x80A1DD0", VA = "0x1880A31D0")]
	public static void GBNELOLPDPK(this HBNCMEMJHAL PBHLPKLGFAP, HBNCMEMJHAL.PGEKPLONJBI CEBNHJNKAJN = HBNCMEMJHAL.PGEKPLONJBI.Entity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3D1B2E0", Offset = "0x3D19EE0", VA = "0x183D1B2E0")]
	public static void IKMAOJDLCDG<T>(this HBNCMEMJHAL PBHLPKLGFAP, HBNCMEMJHAL.PGEKPLONJBI CEBNHJNKAJN = HBNCMEMJHAL.PGEKPLONJBI.Entity) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3C5E3B0", Offset = "0x3C5CFB0", VA = "0x183C5E3B0")]
	public static void EKAGBAAAGOI<T>(this HBNCMEMJHAL PBHLPKLGFAP, HBNCMEMJHAL.PGEKPLONJBI CEBNHJNKAJN = HBNCMEMJHAL.PGEKPLONJBI.Entity) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3D1B300", Offset = "0x3D19F00", VA = "0x183D1B300")]
	public static void IOIGGCIBFHD<T>(this HBNCMEMJHAL PBHLPKLGFAP, bool HDEIKOEHJFL, HBNCMEMJHAL.PGEKPLONJBI CEBNHJNKAJN = HBNCMEMJHAL.PGEKPLONJBI.Entity) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x3D1B860", Offset = "0x3D1A460", VA = "0x183D1B860")]
	public static void MJFGIMDDCHJ<T>(this HBNCMEMJHAL PBHLPKLGFAP, T BKMPCFIAHIG, HBNCMEMJHAL.PGEKPLONJBI CEBNHJNKAJN = HBNCMEMJHAL.PGEKPLONJBI.Entity) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3D1B500", Offset = "0x3D1A100", VA = "0x183D1B500")]
	public static void LFNHHLFICBJ<T>(this HBNCMEMJHAL PBHLPKLGFAP, HBNCMEMJHAL.PGEKPLONJBI CEBNHJNKAJN = HBNCMEMJHAL.PGEKPLONJBI.Entity) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3D1B1F0", Offset = "0x3D19DF0", VA = "0x183D1B1F0")]
	public static void BBLIMBJMCOH<T>(this HBNCMEMJHAL PBHLPKLGFAP) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3D1B330", Offset = "0x3D19F30", VA = "0x183D1B330")]
	public static void KEGFDANDAHO<T>(this HBNCMEMJHAL PBHLPKLGFAP, LocalId ILPOHEPFNOO, HBNCMEMJHAL.PGEKPLONJBI CEBNHJNKAJN = HBNCMEMJHAL.PGEKPLONJBI.Entity) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3D1B6E0", Offset = "0x3D1A2E0", VA = "0x183D1B6E0")]
	private static void MJFGIMDDCHJ<T>(this HBNCMEMJHAL PBHLPKLGFAP, Type MDCDODCGNEK, T BKMPCFIAHIG, HBNCMEMJHAL.PGEKPLONJBI CEBNHJNKAJN = HBNCMEMJHAL.PGEKPLONJBI.Entity) where T : struct
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct KHDMCOLMFDK
{
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface HCLAGIILNMG
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	Entity KJHIOGAKPBP
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
public interface OFHCPBDAGAI
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "0")]
	void PreBake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Bake(HBNCMEMJHAL PBHLPKLGFAP);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface KKMOHPKKKBF
{
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GKNPGOIAOJL JHJCMOGOAFK(Type MDCDODCGNEK);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class DFMNNEBJKEP
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x3A8C420", Offset = "0x3A8B020", VA = "0x183A8C420")]
	public static void JHJCMOGOAFK<T>(this KKMOHPKKKBF PBHLPKLGFAP, [Out] T BKMPCFIAHIG) where T : GKNPGOIAOJL
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface GKNPGOIAOJL
{
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class BPEGLDIFKPH
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x39D8150", Offset = "0x39D6D50", VA = "0x1839D8150")]
	public static void CDPPEOBLDEM<T>(this T AOLOAOCMIFA, HBNCMEMJHAL PBHLPKLGFAP) where T : GKNPGOIAOJL, GHDHONHDFLA
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x39D8340", Offset = "0x39D6F40", VA = "0x1839D8340")]
	public static bool FMGAEGKAMGN<T>(this T EIJOCKPICML) where T : GKNPGOIAOJL
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface GHDHONHDFLA
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	Type GMIMCODLPJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IMHILHBHKJC(GKNPGOIAOJL EIJOCKPICML);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface MDIDOPLCMNJ : OFHCPBDAGAI
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void InitNetworkData(KKMOHPKKKBF PBHLPKLGFAP);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface PGCOHAINJNI : GKNPGOIAOJL
{
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface DLBHCBOPGBF
{
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CHCFAOMCGIP(MKFFFMAICOP LHBOIGHHIJM);

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NONGMOFJGEK(MKFFFMAICOP LHBOIGHHIJM);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface CIOKMEBIAHA
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	ViewId HJFBHEKPKEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface JJDJNNFCKLB : CIOKMEBIAHA, LLJCFEBNCHJ
{
	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void Initialize(ViewId OIKNGBAFDJB, ViewId FIIADEBIMKO, Dictionary<int, object> ELIABFCDDBG, MKFFFMAICOP JAOGNEOIMGK);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface FKBOJAJCNNN : CIOKMEBIAHA
{
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BFHPBJMBKJO(BPKOKGNGCMF IEPNOLIPIDE, Vector3 COLBAOBOGCI, Quaternion BFDIJLLKGHN, Vector3 LEDEKGCGNFK, bool IALKBIJAAAN);

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NPLJDFANAKA(Vector3 COLBAOBOGCI, Quaternion BFDIJLLKGHN, Vector3 LEDEKGCGNFK);

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PLPIOCHBPFK(ViewId IEPNOLIPIDE);

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EOHIMFHDKHH(bool BFAFAPMBIBK);

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NPEGAMCMLOG(bool HAHEBHLKMNK);
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface LLJCFEBNCHJ
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NLDKBKJGIFE();
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface OIENKMAIJMM
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NativeArray<Guid> MHJANMGBNFG(World FPCAGECIADG, NativeArray<Entity> ADEOCFOIFAB, Allocator HPEAGMDCCBL);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface NAEBDHBFECH
{
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	ReadOnlySpan<byte> HDJCHJFIDDF(Entity CGLPEGHHGMM, int JHAKJGDLIGP);

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EODHOFAFPPI(Entity CGLPEGHHGMM, int JHAKJGDLIGP, ReadOnlySpan<byte> BKMPCFIAHIG);

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JJAMAEDEFLN(Entity CGLPEGHHGMM, int JHAKJGDLIGP, Action HFBNHPDLHHL);

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HPAHELJFCJK(Entity CGLPEGHHGMM, int JHAKJGDLIGP, Action HFBNHPDLHHL);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public static class CLKEGFELLBF
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x3A42F70", Offset = "0x3A41B70", VA = "0x183A42F70")]
	public static T EGMLFCAILAO<T>(this NAEBDHBFECH LDPEDNIPEII, Entity CGLPEGHHGMM, int JHAKJGDLIGP) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x3A430B0", Offset = "0x3A41CB0", VA = "0x183A430B0")]
	public static void JBMMIPEKHHM<T>(this NAEBDHBFECH LDPEDNIPEII, Entity CGLPEGHHGMM, int JHAKJGDLIGP, T BKMPCFIAHIG) where T : struct
	{
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[RecRoom.DataLayer.RRGuid("6241769E-7423-45E5-B125-9F7EAA5D5232")]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[TypeManager.ForcedStableTypeHash(9635027148749164348uL)]
	public struct AiCodeGenIdData : IComponentData, IEquatable<AiCodeGenIdData>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public FixedString64Bytes Value;

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x80A0F70", Offset = "0x809FB70", VA = "0x1880A0F70", Slot = "4")]
		public bool Equals(AiCodeGenIdData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x80A0FB0", Offset = "0x809FBB0", VA = "0x1880A0FB0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x80A1070", Offset = "0x809FC70", VA = "0x1880A1070", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[TypeManager.ForcedStableTypeHash(3758703684052595571uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("399DD840-DE45-43FA-9EB0-5E80BC93C8CB")]
	public struct AiCodeGenNameData : IComponentData, IEquatable<AiCodeGenNameData>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public FixedString64Bytes Value;

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x80A0F70", Offset = "0x809FB70", VA = "0x1880A0F70", Slot = "4")]
		public bool Equals(AiCodeGenNameData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x80A1080", Offset = "0x809FC80", VA = "0x1880A1080", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x80A1070", Offset = "0x809FC70", VA = "0x1880A1070", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public struct KCANMFOOFAM : IComponentData, IEquatable<KCANMFOOFAM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	[RecRoom.DataLayer.Default]
	[RecRoom.DataLayer.Field(1)]
	public uint AHLMJDKCEID;

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x80A1140", Offset = "0x809FD40", VA = "0x1880A1140", Slot = "4")]
	public bool Equals(KCANMFOOFAM IIOGPDPGOLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x80A30E0", Offset = "0x80A1CE0", VA = "0x1880A30E0", Slot = "0")]
	public override bool Equals(object KOJLNGLNBMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x150B3A0", Offset = "0x1509FA0", VA = "0x18150B3A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[RecRoom.DataLayer.NetworkComponent(4, false)]
	[CompilerGenerated]
	[RecRoom.DataLayer.RRGuid("A8D1A28C-A057-4DF1-B0CF-22A81E217E19")]
	[RecRoom.DataLayer.TombstonedFields(new int[] { 2 })]
	[TypeManager.ForcedStableTypeHash(11317457978519712368uL)]
	public struct AuthoredAIIdData : IComponentData, IEquatable<AuthoredAIIdData>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public uint Value;

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x80A1140", Offset = "0x809FD40", VA = "0x1880A1140", Slot = "4")]
		public bool Equals(AuthoredAIIdData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x80A1150", Offset = "0x809FD50", VA = "0x1880A1150", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x150B3A0", Offset = "0x1509FA0", VA = "0x18150B3A0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[TypeManager.ForcedStableTypeHash(3063687516547021329uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("650DAD22-E465-4BF2-9A09-076774E09A3E")]
	public struct AuthoredLocalDeformableScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default("new float3(1)")]
		public float3 localDeformationScale;

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x2C53B50", Offset = "0x2C52750", VA = "0x182C53B50")]
		public AuthoredLocalDeformableScaleData(float3 scale)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[RecRoom.DataLayer.StableTypeHash(11505792609904010668uL, 0u)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("B7CEB5B9-453F-4712-B833-27D907AA13E2")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(11505792609904010668uL)]
	public struct AuthoredLocalPoseData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		[RecRoom.DataLayer.Default("new quaternion(new float4(float.NaN))")]
		[RecRoom.DataLayer.Field(1)]
		public quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		[RecRoom.DataLayer.Default("new float3(float.NaN)")]
		[RecRoom.DataLayer.Field(2)]
		public float3 localPosition;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public readonly bool IsValid
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x80A11E0", Offset = "0x809FDE0", VA = "0x1880A11E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x5449780", Offset = "0x5448380", VA = "0x185449780")]
		public AuthoredLocalPoseData(quaternion localRotation, float3 localPosition)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x80A1240", Offset = "0x809FE40", VA = "0x1880A1240")]
		public static RigidTransform KDDDGPNBGLG(AuthoredLocalPoseData poseData)
		{
			return default(RigidTransform);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x80A1240", Offset = "0x809FE40", VA = "0x1880A1240")]
		public static AuthoredLocalPoseData KDDDGPNBGLG(RigidTransform pose)
		{
			return default(AuthoredLocalPoseData);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class JCNOLFBJIBL
{
	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x80A3080", Offset = "0x80A1C80", VA = "0x1880A3080")]
	public static AuthoredLocalPoseData AMKBOMEHIHF([In] this RigidTransform BKMPCFIAHIG)
	{
		return default(AuthoredLocalPoseData);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0xD8D830", Offset = "0xD8C430", VA = "0x180D8D830")]
	public static RigidTransform HJDGFKIPIAK(this AuthoredLocalPoseData BKMPCFIAHIG)
	{
		return default(RigidTransform);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x80A30B0", Offset = "0x80A1CB0", VA = "0x1880A30B0")]
	public static RigidTransform DGFBAIBJGLB([In] this AuthoredLocalPoseData BKMPCFIAHIG)
	{
		return default(RigidTransform);
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("C26C4B4E-5EF3-4F81-87C8-FED8EAD37242")]
	[RecRoom.DataLayer.StableTypeHash(9088562008033959482uL, 0u)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(9088562008033959482uL)]
	public struct AuthoredLocalUniformScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default(1f)]
		public float localUniformScale;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public readonly bool IsValid
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x80A1260", Offset = "0x809FE60", VA = "0x1880A1260")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x2C53B40", Offset = "0x2C52740", VA = "0x182C53B40")]
		public AuthoredLocalUniformScaleData(float localUniformScale)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[TypeManager.ForcedStableTypeHash(10137300772124140051uL)]
	[RecRoom.DataLayer.RRGuid("7B1B8635-3FA9-4ADC-922B-3C25CE0C7E7D")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.StableTypeHash(10137300772124140051uL, 0u)]
	[CompilerGenerated]
	public struct AuthoredParentData : IComponentData, HCLAGIILNMG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public Entity parent;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0xAF3D70", Offset = "0xAF2970", VA = "0x180AF3D70", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x1347740", Offset = "0x1346340", VA = "0x181347740", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x1347740", Offset = "0x1346340", VA = "0x181347740")]
		public AuthoredParentData(Entity parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x80A12C0", Offset = "0x809FEC0", VA = "0x1880A12C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002C")]
public struct DKMMPKEFAGI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002D")]
[TypeManager.ForcedStableTypeHash(11776442497872827640uL)]
public struct CKOENFMLHOH : IComponentData
{
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[RecRoom.DataLayer.StableTypeHash(14109680383450184248uL, 0u)]
	[TypeManager.ForcedStableTypeHash(14109680383450184248uL)]
	[RecRoom.DataLayer.RRGuid("2631F4C3-DBC5-43A2-9257-7D51063B5B82")]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct OwnedByTerrainTag : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		[RecRoom.DataLayer.Default(true)]
		[RecRoom.DataLayer.Field(1)]
		public bool isOwnedByTerrain;
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[RecRoom.DataLayer.RRGuid("B9A63EF5-66A5-463C-8385-A7DC7CE137C3")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.StableTypeHash(8594223769175916906uL, 0u)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(8594223769175916906uL)]
	public struct ObjectBoardNodeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public NetworkGuid nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
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
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		[RecRoom.DataLayer.Default(true)]
		[RecRoom.DataLayer.Field(1)]
		public bool active;
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[TypeManager.ForcedStableTypeHash(16338184133650423946uL)]
	[RecRoom.DataLayer.RRGuid("E9BA10A4-4EE9-431D-BD7F-FF2008ABFA03")]
	[CompilerGenerated]
	public struct ReplicatedObjectOwnedByPlayerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		[RecRoom.DataLayer.Default(-1)]
		[RecRoom.DataLayer.Field(1)]
		public int actorId;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000032")]
public struct EKDGNDNBHHD : IComponentData
{
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(16223816226138460552uL)]
	[RecRoom.DataLayer.RRGuid("46C500A2-9991-4987-B1AA-66E5C3D8E371")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct ReplicatedObjectTag : IComponentData
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[TypeManager.ForcedStableTypeHash(17912083982325865811uL)]
	[RecRoom.DataLayer.RRGuid("5ED157AA-488F-453A-A986-594595B8D777")]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	public struct ReplicatorData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public Entity Target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		[RecRoom.DataLayer.Field(2)]
		[RecRoom.DataLayer.Default(false)]
		public bool NeedsCircuitUpdate;
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	[RecRoom.DataLayer.RRGuid("72F1ABE4-CB5D-4809-8C6D-BC4D800D9E30")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[TypeManager.ForcedStableTypeHash(11840542726010018465uL)]
	[RuntimeOnly]
	public struct ReplicatorExpectedCircuitsRevisionData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public uint ExpectedRevision;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000036")]
public struct JMJPMLGPJBI : IComponentData
{
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	[RecRoom.DataLayer.RRGuid("AEA4D222-29BA-462F-9C0A-AA2063671C68")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[TypeManager.ForcedStableTypeHash(8691279933813304851uL)]
	public struct ReplicatorMaxObjectCountData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		[RecRoom.DataLayer.Default(10)]
		[RecRoom.DataLayer.Field(1)]
		public int count;
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	[RecRoom.DataLayer.RRGuid("400790C1-E8D9-4779-A549-3780DAEC2FDF")]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	[TypeManager.ForcedStableTypeHash(16379995002884076574uL)]
	public struct ReplicatorPreallocatedObjectCountData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		[RecRoom.DataLayer.Default(0)]
		[RecRoom.DataLayer.Field(1)]
		public int preallocatedCopies;
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	[RecRoom.DataLayer.StableTypeHash(8536678595025273356uL, 0u)]
	[TypeManager.ForcedStableTypeHash(8536678595025273356uL)]
	[RecRoom.DataLayer.RRGuid("6A82044A-E392-4DCD-B4BC-A120E58334EA")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct EntityPrefabPartData : IComponentData, IComparable<EntityPrefabPartData>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public Entity prefabRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(2)]
		public uint partId;

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x80A2350", Offset = "0x80A0F50", VA = "0x1880A2350", Slot = "4")]
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
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		[SerializeField]
		private uint id;

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x14B6AC0", Offset = "0x14B56C0", VA = "0x1814B6AC0")]
		internal EntityPrefabPartId(uint OIBGADINDDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0xD8DE80", Offset = "0xD8CA80", VA = "0x180D8DE80")]
		internal uint LNOEHMIAJAO()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x2406580", Offset = "0x2405180", VA = "0x182406580", Slot = "4")]
		public bool Equals(EntityPrefabPartId IIOGPDPGOLB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x80A23A0", Offset = "0x80A0FA0", VA = "0x1880A23A0", Slot = "0")]
		public override bool Equals(object KOJLNGLNBMH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x150B3A0", Offset = "0x1509FA0", VA = "0x18150B3A0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x24064E0", Offset = "0x24050E0", VA = "0x1824064E0", Slot = "5")]
		public int CompareTo(EntityPrefabPartId IIOGPDPGOLB)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[TypeManager.ForcedStableTypeHash(15026348711748810383uL)]
public struct LIIANOAECKA : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public Entity APECMGHDCNK;
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[ConfigGroup("Physics", 0)]
	[RecRoom.DataLayer.RRGuid("F74D558B-BDCC-48C8-A8EF-1F7559E5EAA0")]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(2330616907306882483uL)]
	public struct PhysicsModelCollisionModeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		[Config(null, 0)]
		[RecRoom.DataLayer.Default(NGPGMOPOLKA.Children)]
		[RecRoom.DataLayer.Field(1)]
		public NGPGMOPOLKA collisionMode;
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[TypeManager.ForcedStableTypeHash(11125590729425051511uL)]
	[CompilerGenerated]
	[ConfigGroup("Container", 0)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("8A12EB45-2A15-41CE-AFF7-90A9F984D3A2")]
	public struct ContainerIsRecolorableData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		[RecRoom.DataLayer.Field(1)]
		[Config(null, 0)]
		[RecRoom.DataLayer.Default]
		public bool IsRecolorable;
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[InternalBufferCapacity(0)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[CompilerGenerated]
	[RecRoom.DataLayer.RRGuid("55EAB643-95BB-4C3A-832C-798EBCD95AD5")]
	[TypeManager.ForcedStableTypeHash(14800424556151816553uL)]
	public struct ContainerNameBuffer : IBufferElementData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public byte data;
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[TypeManager.ForcedStableTypeHash(13657791279235747653uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.StableTypeHash(13657791279235747653uL, 0u)]
	[RecRoom.DataLayer.RRGuid("89708D57-D027-494A-A159-221E6C643B6B")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[ConfigGroup("Container", 0)]
	public struct ContainerNameData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		[RecRoom.DataLayer.Default]
		[Config(null, 0)]
		[RecRoom.DataLayer.Field(1)]
		public FixedString64Bytes name;
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[ConfigGroup("Physics", 0)]
	[TypeManager.ForcedStableTypeHash(13904209480152351845uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	[RecRoom.DataLayer.RRGuid("CA023286-E0F6-4DA9-A346-94E86B93977C")]
	public struct PhysicsModelGrabbableModeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		[RecRoom.DataLayer.Default]
		[Config(null, 0)]
		[RecRoom.DataLayer.Field(1)]
		public EIBOFLPIJKL grabbableMode;
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[TypeManager.ForcedStableTypeHash(16485879999901987510uL)]
	[CompilerGenerated]
	[ConfigGroup("Container", 0)]
	[RecRoom.DataLayer.RRGuid("84485C1B-18ED-4D4A-86A4-34CEED482615")]
	[RecRoom.DataLayer.StableTypeHash(16485879999901987510uL, 0u)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct NavMeshGenerationData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		[Config(null, 0)]
		[RecRoom.DataLayer.Default(DMKDAHIMIGM.NavMeshGenerator)]
		[RecRoom.DataLayer.Field(1)]
		public DMKDAHIMIGM mode;
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	[RecRoom.DataLayer.RRGuid("C5BCE8B3-6E69-41D4-921A-BE2E3E0A4DAB")]
	[ConfigGroup("Physics", 0)]
	[TypeManager.ForcedStableTypeHash(1954118413118190521uL)]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	public struct PhysicsModelCollisionLayerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		[Config(null, 0)]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default(PKHKHHIBOLB.IsDynamicEnvironment)]
		public PKHKHHIBOLB collisionLayer;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class PJEIDFEALHC
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public enum KDHNOJPLKEB
	{
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		Dynamic,
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		Static,
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		Enemy,
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		Vehicle
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public enum CFCPGGADFOK
	{
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		Environmental,
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		IgnoreStaticGeometry,
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		IgnoreOtherDynamic,
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		IgnorePlayers,
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		IgnoreMost,
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		Projectile
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x80A4A90", Offset = "0x80A3690", VA = "0x1880A4A90")]
	public static (KDHNOJPLKEB, CFCPGGADFOK) GOLKKAHBLLB(this PKHKHHIBOLB JJKFIBNFCFA)
	{
		return default((KDHNOJPLKEB, CFCPGGADFOK));
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
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		[RecRoom.DataLayer.Default(GCOFBKNOKHB.DEFAULT)]
		[Config(null, 0)]
		[RecRoom.DataLayer.Field(1)]
		public GCOFBKNOKHB flags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[ConfigGroup("Physics", 0)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(1094837642118998916uL)]
	[RecRoom.DataLayer.RRGuid("B6D08147-6AEA-4270-BDC4-8CF68662318D")]
	[RecRoom.DataLayer.StableTypeHash(1094837642118998916uL, 0u)]
	public struct PhysicsModelMassOverrideData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		[RecRoom.DataLayer.Default(0f)]
		[Config(null, 0)]
		[RecRoom.DataLayer.Field(1)]
		public float mass;
	}
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[RecRoom.DataLayer.RRGuid("17799917-98EE-4D9A-A8D1-B0BE5F7316E3")]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[TypeManager.ForcedStableTypeHash(10518841812724430444uL)]
	public struct InventionIdData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default(0L)]
		public long inventionId;

		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public const long INVALID_INVENTION_ID = 0L;

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0xD8D830", Offset = "0xD8C430", VA = "0x180D8D830")]
		public static InventionIdData KDDDGPNBGLG(long value)
		{
			return default(InventionIdData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x80A3070", Offset = "0x80A1C70", VA = "0x1880A3070")]
		public readonly bool GCNLKEDCJFL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7DAE430", Offset = "0x7DAD030", VA = "0x187DAE430")]
		public static bool GCNLKEDCJFL(long inventionId)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[RecRoom.DataLayer.RRGuid("629F0A56-C478-4353-BBDA-8A8BB5FEE478")]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(14338988155392421373uL)]
	[RecRoom.DataLayer.TombstonedFields(new int[] { 1 })]
	public struct InventionInstanceIdData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		[RecRoom.DataLayer.Field(2)]
		[RecRoom.DataLayer.Default]
		public NetworkGuid instanceId;

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x11E4610", Offset = "0x11E3210", VA = "0x1811E4610")]
		public static InventionInstanceIdData KDDDGPNBGLG(Guid value)
		{
			return default(InventionInstanceIdData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	[RecRoom.DataLayer.RRGuid("5D26C8C6-7B5E-481E-B31E-6F30BE69D3C9")]
	[TypeManager.ForcedStableTypeHash(7796256876318585598uL)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct DesyncEntityReferenceData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public Entity entity;
	}
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	[RecRoom.DataLayer.RRGuid("AFCA5CDE-FE11-4D4A-BBC6-32EE1D254891")]
	[TypeManager.ForcedStableTypeHash(3111430309403391054uL)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct DesyncNetworkEntityBackReferenceData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public Entity entity;
	}
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[TypeManager.ForcedStableTypeHash(3936130774074738641uL)]
	[CompilerGenerated]
	[SerializationOnly]
	[RecRoom.DataLayer.RRGuid("F1D14C4E-5388-4D7C-B641-5E79453B80AB")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct DesyncNetworkComponentsData : IBufferElementData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public ulong stableTypeHash;
	}
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[TypeManager.ForcedStableTypeHash(16880504271670651740uL)]
	[CompilerGenerated]
	[RuntimeOnly]
	[RecRoom.DataLayer.RRGuid("04FC082C-DAD0-45B5-A3EF-F042100BAF0F")]
	public struct ElementSnapPointData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public Entity snappedTo;
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[RecRoom.DataLayer.RRGuid("C9620D1E-DE40-4530-954E-90760F1B7A41")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(12457040547531531440uL)]
	[RuntimeOnly]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct ElementSnapPointRuntimeFlagsData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default(HADDMPHJDFI.None)]
		public HADDMPHJDFI flags;
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	[RecRoom.DataLayer.StableTypeHash(12111354511484844847uL, 0u)]
	[RuntimeOnly]
	[RecRoom.DataLayer.RRGuid("A3B27452-BD6C-43B2-BAFF-CF885EB1608B")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[TypeManager.ForcedStableTypeHash(12111354511484844847uL)]
	public struct ParentData : IComponentData, HCLAGIILNMG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public Entity parent;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0xAF3D70", Offset = "0xAF2970", VA = "0x180AF3D70", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x1347740", Offset = "0x1346340", VA = "0x181347740", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x1347740", Offset = "0x1346340", VA = "0x181347740")]
		public ParentData(Entity parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xD8D830", Offset = "0xD8C430", VA = "0x180D8D830")]
		public static implicit operator ParentData(Entity entity)
		{
			return default(ParentData);
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000050")]
public struct KKPIJMEMACB : IComponentData
{
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[RecRoom.DataLayer.StableTypeHash(1950029632769634832uL, 0u)]
	[RecRoom.DataLayer.RRGuid("c886150a-7231-4cc5-a2b2-f222500e6960")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[TypeManager.ForcedStableTypeHash(1950029632769634832uL)]
	[CompilerGenerated]
	public struct SiblingSortOrderData : IEquatable<SiblingSortOrderData>, IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public EJDHJMPEDMM order;

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0xD8D830", Offset = "0xD8C430", VA = "0x180D8D830")]
		public static SiblingSortOrderData KDDDGPNBGLG(EJDHJMPEDMM value)
		{
			return default(SiblingSortOrderData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x80A1D90", Offset = "0x80A0990", VA = "0x1880A1D90", Slot = "4")]
		public bool Equals(SiblingSortOrderData other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("46CEA601-8AA7-423D-B1EA-EEABAE73413F")]
	[TypeManager.ForcedStableTypeHash(6217116203744017593uL)]
	public struct InteractionFilterAllTagsData : IComponentData, HCLAGIILNMG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public Entity allTags;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0xAF3D70", Offset = "0xAF2970", VA = "0x180AF3D70", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x1347740", Offset = "0x1346340", VA = "0x181347740", Slot = "5")]
			set
			{
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[CompilerGenerated]
	[RecRoom.DataLayer.RRGuid("49CEFD0F-3A38-4A9B-835E-10B4C2D08392")]
	[TypeManager.ForcedStableTypeHash(6215026851838101933uL)]
	public struct InteractionFilterAnyTagsData : IComponentData, HCLAGIILNMG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public Entity anyTags;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0xAF3D70", Offset = "0xAF2970", VA = "0x180AF3D70", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x1347740", Offset = "0x1346340", VA = "0x181347740", Slot = "5")]
			set
			{
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[TypeManager.ForcedStableTypeHash(6780642047612598977uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("11CE457F-4366-4AAD-B7E3-28D82B4FAFCF")]
	public struct InteractionFilterEnabledData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		[RecRoom.DataLayer.Default(CLBPEPNMNAE.Disabled)]
		[RecRoom.DataLayer.Field(1)]
		public CLBPEPNMNAE filterMode;
	}
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[TypeManager.ForcedStableTypeHash(6642820932987006861uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.RRGuid("F7789094-7D82-4D27-B805-2CC1B8C0A538")]
	public struct InteractionFilterEntityRefData : IComponentData, HCLAGIILNMG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public Entity filterEntity;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0xAF3D70", Offset = "0xAF2970", VA = "0x180AF3D70", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x1347740", Offset = "0x1346340", VA = "0x181347740", Slot = "5")]
			set
			{
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[RecRoom.DataLayer.RRGuid("C7E95AF7-DB7D-4432-8DAA-8F36EC6C4308")]
	[TypeManager.ForcedStableTypeHash(15467295871228743847uL)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[CompilerGenerated]
	public struct InteractionFilterNoneTagsData : IComponentData, HCLAGIILNMG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public Entity noneTags;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0xAF3D70", Offset = "0xAF2970", VA = "0x180AF3D70", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x1347740", Offset = "0x1346340", VA = "0x181347740", Slot = "5")]
			set
			{
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[TypeManager.ForcedStableTypeHash(15820415814547747176uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.RRGuid("C0280102-4D0D-4960-B108-E59CAE468710")]
	public struct ObjectInteractionFilterData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public Entity entity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		[RecRoom.DataLayer.Default(CLBPEPNMNAE.EnabledForRole)]
		[RecRoom.DataLayer.Field(2)]
		public CLBPEPNMNAE mode;
	}
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[RecRoom.DataLayer.RRGuid("A5E08071-6B43-446F-A542-878B31E43736")]
	[TypeManager.ForcedStableTypeHash(10434800737286119109uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct MagneticAnchorData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public Entity connectedAnchor;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	[RecRoom.DataLayer.StableTypeHash(15012400804589552708uL, 0u)]
	[RecRoom.DataLayer.RRGuid("007F8815-C87C-4E6B-BC56-3BA0C4888E3D")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[TypeManager.ForcedStableTypeHash(15012400804589552708uL)]
	public struct OverrideObjectNetworkIdData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public uint networkIdBits;
	}
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("30228348-77DF-48F6-B2EF-B0883D3E10CA")]
	[TypeManager.ForcedStableTypeHash(4540375434353162791uL)]
	public struct MakerPenHeldData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public bool makerPenHeld;
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[RecRoom.DataLayer.RRGuid("FB9853D6-6231-43FD-A754-00105DC30880")]
	[TypeManager.ForcedStableTypeHash(8459715919607487693uL)]
	[RecRoom.DataLayer.NetworkComponent(6, false)]
	[ConfigGroup("Object", 0)]
	[CompilerGenerated]
	public struct ObjectPolicyData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		[RecRoom.DataLayer.Default("new ScaleRestriction(1,1)")]
		[RecRoom.DataLayer.Field(2)]
		public PLGJBNGJIHN scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		[Config(null, 0)]
		[RecRoom.DataLayer.Default("ObjectPolicyUserConfigurableFlags.DEFAULT")]
		[RecRoom.DataLayer.Field(3)]
		public GOFNDNICMIL userConfigurableFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		[RecRoom.DataLayer.Default(IKHNFFIHEKH.Default)]
		[RecRoom.DataLayer.Field(4)]
		[Config(null, 0)]
		public IKHNFFIHEKH circuitsTransformBehavior;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default("ObjectPolicyEnumFlags.Default")]
		public LNEEJIFPGOM flags;
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[SerializationOnly]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[TypeManager.ForcedStableTypeHash(2965180940795077803uL)]
	[RecRoom.DataLayer.RRGuid("01AEEF22-2473-4505-A473-0BBF009690B3")]
	public struct RemovedNetworkComponentsBuffer : IBufferElementData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public ulong stableTypeHash;
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[TypeManager.ForcedStableTypeHash(17708500325183871236uL)]
	[RecRoom.DataLayer.RRGuid("617A903E-C2C2-467C-A138-287FDB487645")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[CompilerGenerated]
	[RecRoom.DataLayer.StableTypeHash(17708500325183871236uL, 0u)]
	public struct PlayerScopeData : IComponentData, HCLAGIILNMG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public Entity playerScope;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public Entity Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0xAF3D70", Offset = "0xAF2970", VA = "0x180AF3D70", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x1347740", Offset = "0x1346340", VA = "0x181347740", Slot = "5")]
			set
			{
			}
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xD8D830", Offset = "0xD8C430", VA = "0x180D8D830")]
		public static PlayerScopeData KDDDGPNBGLG(Entity entity)
		{
			return default(PlayerScopeData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	[ConfigGroup("Physics", 0)]
	[RecRoom.DataLayer.StableTypeHash(16642773407304133105uL, 0u)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("F945B699-C9E5-4634-9F64-831484F4F3BD")]
	[TypeManager.ForcedStableTypeHash(16642773407304133105uL)]
	public struct PhysicsMaterialData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		[RecRoom.DataLayer.Field(1)]
		[Config(null, 0)]
		[RecRoom.DataLayer.Default(10f)]
		public float density;
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[RecRoom.DataLayer.StableTypeHash(10537432342869025182uL, 0u)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[TypeManager.ForcedStableTypeHash(10537432342869025182uL)]
	[RecRoom.DataLayer.RRGuid("A2E0AF0F-C284-47E6-9535-A67A29BF5730")]
	[CompilerGenerated]
	public struct ShapeConfigData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		[RecRoom.DataLayer.Default(EHENCINGLKE.None)]
		[RecRoom.DataLayer.Field(1)]
		public EHENCINGLKE flags;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool DynamicUVProjection
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x7412C50", Offset = "0x7411850", VA = "0x187412C50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool PreventInvertedCreation
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x7412C60", Offset = "0x7411860", VA = "0x187412C60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public bool NewBendLogic
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x80A50D0", Offset = "0x80A3CD0", VA = "0x1880A50D0")]
			get
			{
				return default(bool);
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[RecRoom.DataLayer.RRGuid("5C706BF1-9D50-456A-B974-521E8E2CC660")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.StableTypeHash(10917729582819845312uL, 0u)]
	[TypeManager.ForcedStableTypeHash(10917729582819845312uL)]
	[CompilerGenerated]
	public struct ShapeTypeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public KNMEHEMEPOL shapeType;
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[TypeManager.ForcedStableTypeHash(5298506180484533559uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.StableTypeHash(5298506180484533559uL, 0u)]
	[RecRoom.DataLayer.RRGuid("36418781-DB47-4DE7-A138-CC88D1D795C0")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct SplinePointOrderData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public EJDHJMPEDMM order;

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0xD8D830", Offset = "0xD8C430", VA = "0x180D8D830")]
		public static SplinePointOrderData KDDDGPNBGLG(EJDHJMPEDMM value)
		{
			return default(SplinePointOrderData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[TypeManager.ForcedStableTypeHash(16368389834000856208uL)]
	[RecRoom.DataLayer.StableTypeHash(16368389834000856208uL, 0u)]
	[RecRoom.DataLayer.RRGuid("FCEE3BCD-9C10-4BF4-954A-0DCFE8810227")]
	public struct SplinePointParentData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public Entity spline;
	}
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	[RecRoom.DataLayer.StableTypeHash(18095612727592564636uL, 0u)]
	[RecRoom.DataLayer.RRGuid("5A6D38A4-1A58-4EB4-9C1B-06ADA0D44AFA")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[TypeManager.ForcedStableTypeHash(18095612727592564636uL)]
	public struct SplinePointPositionData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public float3 localPosition;
	}
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[TypeManager.ForcedStableTypeHash(1429513518619209486uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("433F66B6-CC1C-4A8A-BF73-2B797440A8DB")]
	[RecRoom.DataLayer.StableTypeHash(1429513518619209486uL, 0u)]
	public struct SplinePointRotationData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default("new quaternion(0, 0, 0, 1f)")]
		public quaternion localRotation;
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[RecRoom.DataLayer.RRGuid("04CA3CCE-F121-4B5B-BC56-FE8E9C77F0F4")]
	[TypeManager.ForcedStableTypeHash(1238044349990854547uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.StableTypeHash(1238044349990854547uL, 0u)]
	public struct SplinePointScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default("new float3(1)")]
		public float3 localScale;
	}
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[TypeManager.ForcedStableTypeHash(4657247877648983868uL)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("E0610986-0F8F-494A-8C6E-8A2D2491B088")]
	[CompilerGenerated]
	[RecRoom.DataLayer.StableTypeHash(4657247877648983868uL, 0u)]
	public struct SplineShapeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public LIACMAGLFCP parameters;
	}
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[TypeManager.ForcedStableTypeHash(12332323170023439017uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	[RecRoom.DataLayer.RRGuid("73C344D9-D535-4753-9D9A-B6DEDE4079B0")]
	[RecRoom.DataLayer.TombstonedFields(new int[] { 1 })]
	[RecRoom.DataLayer.StableTypeHash(12332323170023439017uL, 0u)]
	public struct OMShapeContainerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		[RecRoom.DataLayer.Field(2)]
		[RecRoom.DataLayer.Default(true)]
		public bool canModifyWithCircuits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		[RecRoom.DataLayer.Default(true)]
		[RecRoom.DataLayer.Field(3)]
		public bool optimizedCollidersEnabled;
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[RecRoom.DataLayer.RRGuid("2B5C4208-9113-4F65-B3A6-18EAE1FF3937")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(17673274643717888315uL)]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	public struct SerializedDataLayerVersionData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public int version;
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[TypeManager.ForcedStableTypeHash(2299272917927886785uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.RRGuid("530E7647-9756-405B-8F83-554B2251FEA9")]
	public struct TerrainGenerationData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default(0u)]
		public uint Seed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		[RecRoom.DataLayer.Default(1f)]
		[RecRoom.DataLayer.Field(2)]
		public float BaseTerrainHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		[RecRoom.DataLayer.Default(1f)]
		[RecRoom.DataLayer.Field(3)]
		public float BaseTerrainFeatureScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(4)]
		public ICMOIJBHMPP PlayAreaShape;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(5)]
		public KCNHKGPCNMH BaseTerrainRoughness;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		[RecRoom.DataLayer.Field(6)]
		[RecRoom.DataLayer.Default]
		public DIPACINJNHP BaseTerrainHeightFunction;
	}
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[TypeManager.ForcedStableTypeHash(2736085529679546037uL)]
	[RecRoom.DataLayer.RRGuid("207C2E2E-B1B0-4A2B-8A14-9651A907CBC6")]
	public struct TerrainLayerBuffer : IBufferElementData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public TerrainGenerationLayer layer;
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[RecRoom.DataLayer.RRGuid("557221B3-5BED-456A-8B42-A8D934D18103")]
	[TypeManager.ForcedStableTypeHash(17384573708384647569uL)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[CompilerGenerated]
	public struct TerrainMaterialLayerBuffer : IBufferElementData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public CPAFJEBFNBF layer;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.RRGuid("CC657074-87FD-47F7-A7B0-F5CCE922A9D0")]
[Flags]
[RecRoom.DataLayer.Range(DOAPHOIIDLI.MIN, DOAPHOIIDLI.ALL)]
public enum DOAPHOIIDLI
{
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	IsAllowed = 1,
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	UseDefaultVisualEffects = 2,
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	DEFAULT = 2,
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	ALL = 3,
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	MAX = 3
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[TypeManager.ForcedStableTypeHash(5328722791392374178uL)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("34BA53CB-16FB-45DB-AA25-293CE7C8DAE4")]
	[CompilerGenerated]
	public struct ToolCleanupSettingsData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		[RecRoom.DataLayer.Default(15f)]
		[RecRoom.DataLayer.Field(1)]
		public float delay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		[RecRoom.DataLayer.Field(2)]
		[RecRoom.DataLayer.Default(DOAPHOIIDLI.UseDefaultVisualEffects)]
		public DOAPHOIIDLI toolCleanupFlags;
	}
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[TypeManager.ForcedStableTypeHash(13768238190614302474uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.RRGuid("48C72ABE-383D-45C6-9610-773F2B4F84C6")]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	[RecRoom.DataLayer.TombstonedFields(new int[] { 2, 3 })]
	public struct ToolCleanupStatusData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public float cleanupStartTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(4)]
		public JEHMKKLDPGH statusFlags;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.RRGuid("E63050BA-D087-4027-99F8-4AFDEA229CD8")]
[RecRoom.DataLayer.Range(JEHMKKLDPGH.None, JEHMKKLDPGH.ALL)]
[Flags]
public enum JEHMKKLDPGH
{
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	ForceCleanup = 1,
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	CleanupDone = 2,
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	CleanupPaused = 4,
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	ALL = 7,
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	MAX = 7
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[RecRoom.DataLayer.RRGuid("021E8703-AAFD-4965-8C38-FF86663126D2")]
	[TypeManager.ForcedStableTypeHash(463077377357487319uL)]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	[CompilerGenerated]
	public struct LocalDeformableScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		[RecRoom.DataLayer.Default("new float3(1)")]
		[RecRoom.DataLayer.Field(1)]
		public float3 localDeformationScale;

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x2C53B50", Offset = "0x2C52750", VA = "0x182C53B50")]
		public LocalDeformableScaleData(float3 scale)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[TypeManager.ForcedStableTypeHash(1369925932270831712uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.RRGuid("38AA9F1D-FD16-4B56-917C-3341D0EB1DF2")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.StableTypeHash(1369925932270831712uL, 0u)]
	public struct LocalPoseData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default("new quaternion(0,0,0,1)")]
		public quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		[RecRoom.DataLayer.Field(2)]
		[RecRoom.DataLayer.Default]
		public float3 localPosition;

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x5449780", Offset = "0x5448380", VA = "0x185449780")]
		public LocalPoseData(quaternion localRotation, float3 localPosition)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x80A1240", Offset = "0x809FE40", VA = "0x1880A1240")]
		public static RigidTransform KDDDGPNBGLG(LocalPoseData poseData)
		{
			return default(RigidTransform);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x80A1240", Offset = "0x809FE40", VA = "0x1880A1240")]
		public static LocalPoseData KDDDGPNBGLG(RigidTransform pose)
		{
			return default(LocalPoseData);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public static class BFLMAFHCIHE
{
	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x80A1300", Offset = "0x809FF00", VA = "0x1880A1300")]
	public static LocalPoseData IFIEIABDMDK([In] this RigidTransform BKMPCFIAHIG)
	{
		return default(LocalPoseData);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x80A12D0", Offset = "0x809FED0", VA = "0x1880A12D0")]
	public static RigidTransform DGFBAIBJGLB([In] this LocalPoseData BKMPCFIAHIG)
	{
		return default(RigidTransform);
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	[TypeManager.ForcedStableTypeHash(2720902521635056246uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.StableTypeHash(2720902521635056246uL, 0u)]
	[RecRoom.DataLayer.RRGuid("0E9FADE9-751A-4A53-B455-4F8EA675754D")]
	public struct LocalUniformScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default(1f)]
		public float localUniformScale;
	}
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[TypeManager.ForcedStableTypeHash(5730545663584378555uL)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("F01774C0-98E7-491E-AAA5-85B64AFFA182")]
	[RecRoom.DataLayer.StableTypeHash(5730545663584378555uL, 0u)]
	[CompilerGenerated]
	public struct TransformFlagsData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public DBNFECDEJAL transformHint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		[RecRoom.DataLayer.Field(2)]
		[RecRoom.DataLayer.Default]
		public KCMGGEJIJHC transformPriority;
	}
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	[RecRoom.DataLayer.DoNotGenerateComponentProperties]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	[RecRoom.DataLayer.RRGuid("392BF0C9-F464-491A-8725-E4B5E5C4ECD4")]
	[TypeManager.ForcedStableTypeHash(12583036596830542024uL)]
	[CompilerGenerated]
	public struct RRObjectPrefabData : ISharedComponentData, IEquatable<RRObjectPrefabData>, IComparable<RRObjectPrefabData>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public IBLPJFKLOID prefabType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		[RecRoom.DataLayer.Field(2)]
		[RecRoom.DataLayer.Default]
		public Guid prefabGuid;

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x80A4FC0", Offset = "0x80A3BC0", VA = "0x1880A4FC0")]
		public RRObjectPrefabData(Guid prefabGuid, IBLPJFKLOID prefabType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x80A4EC0", Offset = "0x80A3AC0", VA = "0x1880A4EC0", Slot = "4")]
		public readonly bool Equals(RRObjectPrefabData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x80A4E00", Offset = "0x80A3A00", VA = "0x1880A4E00", Slot = "0")]
		public override readonly bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x80A4FD0", Offset = "0x80A3BD0", VA = "0x1880A4FD0")]
		public static bool operator ==(RRObjectPrefabData a, RRObjectPrefabData b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x80A1B40", Offset = "0x80A0740", VA = "0x1880A1B40", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x80A1950", Offset = "0x80A0550", VA = "0x1880A1950", Slot = "5")]
		public readonly int CompareTo(RRObjectPrefabData other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x80A4F20", Offset = "0x80A3B20", VA = "0x1880A4F20", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	[RecRoom.DataLayer.RRGuid("FF90B503-A0B5-4B3D-BACF-046FA1456FBD")]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[TypeManager.ForcedStableTypeHash(17550159503907726442uL)]
	public struct ReferenceGroupKindData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public MCKGLJLILAB kind;
	}
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[RecRoom.DataLayer.RRGuid("2C78EEBE-6DD9-44FF-A70D-6C2EE9BB8FB3")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(18363292822319307914uL)]
	public struct ReferenceGroupOwnerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public Entity owner;
	}
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[TypeManager.ForcedStableTypeHash(11947588904347318594uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.RRGuid("177498E9-83A6-4C2E-A8C1-B1951B47E74D")]
	public struct ReferenceGroupReferenceBuffer : IBufferElementData, HCLAGIILNMG, IEquatable<ReferenceGroupReferenceBuffer>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public Entity reference;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public Entity Entity
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0xAF3D70", Offset = "0xAF2970", VA = "0x180AF3D70", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x1347740", Offset = "0x1346340", VA = "0x181347740", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x80A50C0", Offset = "0x80A3CC0", VA = "0x1880A50C0", Slot = "6")]
		public bool Equals(ReferenceGroupReferenceBuffer other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x80A5030", Offset = "0x80A3C30", VA = "0x1880A5030", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0xD8DE80", Offset = "0xD8CA80", VA = "0x180D8DE80", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000079")]
public struct ICDKIBJLOLH : IEqualityComparer<ReferenceGroupReferenceBuffer>
{
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public static ICDKIBJLOLH JOFMPALJJOB;

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x80A26B0", Offset = "0x80A12B0", VA = "0x1880A26B0", Slot = "4")]
	public bool Equals(ReferenceGroupReferenceBuffer LGCEHLADNJC, ReferenceGroupReferenceBuffer LFHMHCKODDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0xB6BAB0", Offset = "0xB6A6B0", VA = "0x180B6BAB0", Slot = "5")]
	public int GetHashCode(ReferenceGroupReferenceBuffer KOJLNGLNBMH)
	{
		return default(int);
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("DE12A401-BD29-4B00-A629-7EFBECEDCFDF")]
	[InternalBufferCapacity(0)]
	[TypeManager.ForcedStableTypeHash(17466046755328781668uL)]
	public struct AuthoredUserTagReferenceBuffer : BNLHCLALDFF, IBufferElementData, HCLAGIILNMG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public Entity Child;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0xAF3D70", Offset = "0xAF2970", VA = "0x180AF3D70", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x1347740", Offset = "0x1346340", VA = "0x181347740", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x1347740", Offset = "0x1346340", VA = "0x181347740")]
		public AuthoredUserTagReferenceBuffer(Entity entity)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xD8D830", Offset = "0xD8C430", VA = "0x180D8D830")]
		public static AuthoredUserTagReferenceBuffer KDDDGPNBGLG(Entity entity)
		{
			return default(AuthoredUserTagReferenceBuffer);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public interface BNLHCLALDFF : IBufferElementData, HCLAGIILNMG
{
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	[RecRoom.DataLayer.RRGuid("00B7CB5E-4C0C-4D2C-AC95-78529EE58768")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(12148147190301245780uL)]
	public struct PersistentUserTagData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public FixedList32Bytes<int> tags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		[RecRoom.DataLayer.Default(false)]
		[RecRoom.DataLayer.Field(2)]
		public bool initalizedDefaults;
	}
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	[RecRoom.DataLayer.RRGuid("80D85A55-B2F6-4860-A851-62973DC10940")]
	[TypeManager.ForcedStableTypeHash(1859693175312uL)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[CompilerGenerated]
	[RecRoom.DataLayer.StableTypeHash(1859693175312uL, 0u)]
	[SwatchPrimaryKey]
	public struct UserTagNameData : IComponentData, IEquatable<UserTagNameData>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public FixedString32Bytes Value;

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x80A5200", Offset = "0x80A3E00", VA = "0x1880A5200")]
		public UserTagNameData(string value)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x80A51C0", Offset = "0x80A3DC0", VA = "0x1880A51C0")]
		public static UserTagNameData KDDDGPNBGLG(string value)
		{
			return default(UserTagNameData);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x80A50E0", Offset = "0x80A3CE0", VA = "0x1880A50E0", Slot = "4")]
		public bool Equals(UserTagNameData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x80A5110", Offset = "0x80A3D10", VA = "0x1880A5110", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x80A51B0", Offset = "0x80A3DB0", VA = "0x1880A51B0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	[RuntimeOnly]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[InternalBufferCapacity(0)]
	[TypeManager.ForcedStableTypeHash(2039749658960193818uL)]
	[RecRoom.DataLayer.RRGuid("1E609F72-38C4-433D-BB17-B718F89DF446")]
	[CompilerGenerated]
	public struct UserTagReferenceBuffer : BNLHCLALDFF, IBufferElementData, HCLAGIILNMG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public Entity Child;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0xAF3D70", Offset = "0xAF2970", VA = "0x180AF3D70", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x1347740", Offset = "0x1346340", VA = "0x181347740", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x1347740", Offset = "0x1346340", VA = "0x181347740")]
		public UserTagReferenceBuffer(Entity entity)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0xD8D830", Offset = "0xD8C430", VA = "0x180D8D830")]
		public static UserTagReferenceBuffer KDDDGPNBGLG(Entity entity)
		{
			return default(UserTagReferenceBuffer);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.StableTypeHash(1591066774816564574uL, 0u)]
	[TypeManager.ForcedStableTypeHash(1591066774816564574uL)]
	[ConfigGroup("Visual", 0)]
	[CanDesync]
	[CompilerGenerated]
	[RecRoom.DataLayer.RRGuid("C36DDF08-CA52-4E33-8078-2F6E915D4FDA")]
	public struct StandardRenderableVisualData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		[Config(null, 0)]
		public PFELNBBIHNK color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		[RecRoom.DataLayer.Field(2)]
		[Config(null, 0)]
		[RecRoom.DataLayer.Default]
		public MEKNHMCLLHC material;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		[RecRoom.DataLayer.Default]
		[Config(null, 0)]
		[RecRoom.DataLayer.Field(3)]
		public float uvScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		[RecRoom.DataLayer.Default]
		[Config(null, 0)]
		[RecRoom.DataLayer.Field(4)]
		public float3 uvOffset;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
[RecRoom.DataLayer.Range(IKHNFFIHEKH.NONE, IKHNFFIHEKH.COUNT)]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.RRGuid("6B598497-D68A-4CC9-9D41-09EF6B966499")]
public enum IKHNFFIHEKH
{
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	NONE = 0,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	[Config("Default (can transform roots, children are static)", 0)]
	Default = 1,
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	[Config("Can Transform (chips like SetPosition can modify)", 0)]
	CircuitsCanTransform = 2,
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	[Config("Always Static (chips cannot modify transform)", 0)]
	AlwaysStatic = 3,
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	COUNT = 4,
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	MAX = 4
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
[RecRoom.DataLayer.RRGuid("17517E1A-CF1A-48C9-B6A5-F9E42C1B9E96")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.Range(0, 4)]
public enum JBODEEFPGGG
{
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	Box = 1,
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	Sphere = 2,
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	Capsule = 3,
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	Mesh = 4,
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	COUNT = 5,
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	MAX = 4
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
[Flags]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.Range(OOPFCEMNFAD.NONE, OOPFCEMNFAD.ALL)]
[RecRoom.DataLayer.RRGuid("A13F5102-9259-42B9-B782-BB7CC33A0C4F")]
public enum OOPFCEMNFAD
{
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	NONE = 0,
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	Object = 1,
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	Player = 2,
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	Projectile = 4,
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	Vehicle = 8,
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	ALL = 0xF
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
[RecRoom.DataLayer.Range(0, 127)]
[RecRoom.DataLayer.RRGuid("F843A776-E042-43B7-8167-0C7A421062F8")]
[RecRoom.DataLayer.NetworkEnum(2, false)]
public enum PKHKHHIBOLB : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	[@Tooltip("Indicating it can be walked on and moved")]
	[Config("Dynamic (Environment)", 0)]
	IsDynamicEnvironment = 0,
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	[Config("Dynamic", -1)]
	IsDynamic = 10,
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	[Config("Dynamic (Ignore Static Geometry)", 0)]
	IsDynamicIgnoreStaticGeometry = 11,
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	[Config("Dynamic (Ignore Other Dynamic)", 0)]
	IsDynamicIgnoreOtherDynamic = 12,
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	[Config("Dynamic (Ignore Players)", 0)]
	IsDynamicIgnorePlayers = 13,
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	[Config("Dynamic (Ignore Most)", 0)]
	IsDynamicIgnoreMost = 14,
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	[Config("Enemy Collision", 0)]
	IsEnemyCollision = 30,
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	[Config("Enemy Projectile", 0)]
	IsEnemyProjectile = 31,
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	[Config("Vehicle Physics", 0)]
	IsVehicleCollision = 40,
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	[ConfigIgnore]
	STATIC = 100,
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	[ConfigIgnore]
	DECORATION = 101,
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	MAX = 127
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
[RecRoom.DataLayer.RRGuid("9ADF7A0D-D808-48A7-BFCB-3272FB5D8A52")]
[RecRoom.DataLayer.NetworkEnum(2, false)]
[RecRoom.DataLayer.Range(NGPGMOPOLKA.Off, NGPGMOPOLKA.COUNT)]
public enum NGPGMOPOLKA : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	Off = 0,
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	Children = 1,
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	Hull = 2,
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	COUNT = 3,
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	MAX = 2
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.Range(HADDMPHJDFI.None, HADDMPHJDFI.SnapLocked)]
[RecRoom.DataLayer.RRGuid("0E5141AE-23E1-45A5-8BB0-04CC01E925E2")]
[Flags]
public enum HADDMPHJDFI : byte
{
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	SnapLocked = 1,
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	All = 1,
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	Default = 0
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
[RecRoom.DataLayer.RRGuid("3B156405-5769-4DB2-87EA-2B846AC4E584")]
[RecRoom.DataLayer.Range(0, 2)]
[RecRoom.DataLayer.NetworkEnum(1, false)]
public enum KNMEHEMEPOL
{
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	Primitive = 1,
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	Spline = 2,
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	COUNT = 3,
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	MAX = 2
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
[RecRoom.DataLayer.NetworkEnum(2, false)]
[RecRoom.DataLayer.Range(EIBOFLPIJKL.Pivot, EIBOFLPIJKL.COUNT)]
[RecRoom.DataLayer.RRGuid("61EFE94A-235A-4281-B938-1A5BE32A18B1")]
public enum EIBOFLPIJKL : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	Pivot = 0,
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	Bounds = 1,
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	COUNT = 2,
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	MAX = 1
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.RRGuid("95D8649F-566A-409B-8090-61DA57EE41CC")]
[RecRoom.DataLayer.Range(NMOEFFJPCGI.Canyon, NMOEFFJPCGI.Random)]
public enum NMOEFFJPCGI
{
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	Canyon,
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	Moon,
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	Bowl,
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	Hills,
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	Island,
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	Desert,
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	Random
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.Range(CLBPEPNMNAE.EnabledForRole, CLBPEPNMNAE.Disabled)]
[RecRoom.DataLayer.RRGuid("c0973732-e735-44cd-9727-a9a79bad01e3")]
public enum CLBPEPNMNAE : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	EnabledForRole,
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	DisabledForRole,
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	Disabled
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
[RecRoom.DataLayer.Range(DMKDAHIMIGM.NavMeshGenerator, DMKDAHIMIGM.NavMeshBlocker)]
[RecRoom.DataLayer.RRGuid("7E7D5AA1-2EC9-488B-8AB2-703F13BCB8CF")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
public enum DMKDAHIMIGM
{
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	NavMeshGenerator = 0,
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	NavMeshIgnored = 1,
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	NavMeshBlocker = 2,
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	MAX = 2
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
[RecRoom.DataLayer.Range(LNEEJIFPGOM.None, LNEEJIFPGOM.All)]
[RecRoom.DataLayer.RRGuid("7B493897-FE06-4FC8-AB72-8B7BF5A313D3")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[Flags]
public enum LNEEJIFPGOM
{
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	All = 0x3FFF,
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	Default = 0x3FFF
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.RRGuid("4427686F-E636-4F43-91F7-6BC74DEC584E")]
[RecRoom.DataLayer.Range(0, DLFJGOLOEDK.COUNT)]
public enum DLFJGOLOEDK
{
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	SupportsRotation,
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	SupportsDeformation,
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	SupportsScaling,
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	SupportsMirroring,
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	SupportsCloning,
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	SupportsRecoloring,
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	CanDestroy,
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	CanSaveIntoInventions,
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	SupportsRespawn,
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	SupportsMerging,
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	SupportsSplitting,
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	SupportsKeys,
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	CanEditWithMakerPen,
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	DEPRECATED_IsGrabbable,
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public static class FNPMBFEOHFD
{
	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x80A2450", Offset = "0x80A1050", VA = "0x1880A2450")]
	public static void IEFFBEILLPC(this LNEEJIFPGOM HHPCFHFLKHA, DLFJGOLOEDK EKNOMHPDNJN, bool MNGLOBMLMGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x80A2430", Offset = "0x80A1030", VA = "0x1880A2430")]
	public static bool EMKGFGGGJML(this LNEEJIFPGOM HHPCFHFLKHA, DLFJGOLOEDK EKNOMHPDNJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0xEF4D10", Offset = "0xEF3910", VA = "0x180EF4D10")]
	public static LNEEJIFPGOM NPKKCDLJBOC(this DLFJGOLOEDK EKNOMHPDNJN)
	{
		return default(LNEEJIFPGOM);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
[RecRoom.DataLayer.NetworkEnum(2, false)]
[RecRoom.DataLayer.Range(GOFNDNICMIL.NONE, GOFNDNICMIL.COUNT)]
[Flags]
[RecRoom.DataLayer.RRGuid("E3C51303-32F0-4EF4-8A66-C814E323653D")]
public enum GOFNDNICMIL
{
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	NONE = 0,
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	IsFrozen = 1,
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	IsGrabbable = 2,
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	PickUpDefaultToPlaceIfPhysical = 4,
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	COUNT = 5,
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	ALL = 5,
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	DEFAULT = 0
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
[RecRoom.DataLayer.RRGuid("777AD204-3AC0-41CE-BDC0-894C5821B3B9")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.Range(IBLPJFKLOID.None, 8000)]
public enum IBLPJFKLOID
{
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	[Config("Container", 0)]
	Container = 1000,
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	[Config("Container", 0)]
	LegacyShapeContainer = 1001,
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	[Config("Container", 0)]
	CreationShapeContainer = 1002,
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	[Config("Empty", 0)]
	Empty = 4000,
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	[Config("Legacy Box", 0)]
	Shape_Primitive_LegacyBox = 2000,
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	[Config("Sphere", 0)]
	Shape_Primitive_Sphere = 2001,
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	[Config("Cylinder", 0)]
	Shape_Primitive_Cylinder = 2002,
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	[Config("Legacy Wedge", 0)]
	Shape_Primitive_LegacyWedge = 2003,
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	[Config("Legacy Pyramid", 0)]
	Shape_Primitive_LegacyPyramid = 2004,
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	[Config("Trigger Volume Box", 0)]
	Shape_Primitive_TriggerVolumeBox = 2005,
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	[Config("Box", 0)]
	Shape_Primitive_Box = 2006,
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	[Config("Rounded Box", 0)]
	Shape_Primitive_RoundedBox = 2007,
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	[Config("Wedge", 0)]
	Shape_Primitive_Wedge = 2008,
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	[Config("Pyramid", 0)]
	Shape_Primitive_Pyramid = 2009,
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	[Config("Half Sphere", 0)]
	Shape_Primitive_HalfSphere = 2010,
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	[Config("Cone", 0)]
	Shape_Primitive_Cone = 2011,
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	[Config("Pipe", 0)]
	Shape_Primitive_Pipe = 2012,
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	[Config("Donut", 0)]
	Shape_Primitive_Donut = 2013,
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	[Config("Half Pipe", 0)]
	Shape_Primitive_HalfPipe = 2014,
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	[Config("Diamond", 0)]
	Shape_Primitive_Diamond = 2015,
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	[Config("Mound", 0)]
	Shape_Primitive_Mound = 2016,
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	[Config("Cube (Simple)", 0)]
	Shape_Primitive_ADVANCED_Cube = 2017,
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	[Config("Sphere (Simple)", 0)]
	Shape_Primitive_ADVANCED_Sphere = 2018,
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	[Config("Cylinder (Simple)", 0)]
	Shape_Primitive_ADVANCED_Cylinder = 2019,
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	[Config("Cone (Simple)", 0)]
	Shape_Primitive_ADVANCED_Cone = 2020,
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	[Config("Pyramid (Simple)", 0)]
	Shape_Primitive_ADVANCED_Pyramid = 2021,
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	[Config("Octagon (Simple)", 0)]
	Shape_Primitive_ADVANCED_Octagon = 2022,
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	[Config("Triangle (Simple)", 0)]
	Shape_Primitive_ADVANCED_Triangle = 2023,
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	[Config("Hexagon (Simple)", 0)]
	Shape_Primitive_ADVANCED_Hexagon = 2024,
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	[Config("Quarter Pipe", 0)]
	Shape_Primitive_ADVANCED_QuarterPipe = 2025,
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	[Config("Pentagon (Simple)", 0)]
	Shape_Primitive_ADVANCED_Pentagon = 2026,
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	[Config("Dodecahedron", 0)]
	Shape_Primitive_ADVANCED_Dodecahedron = 2027,
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	[Config("Icosahedron", 0)]
	Shape_Primitive_ADVANCED_Trihedron = 2028,
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	[Config("Octahedron", 0)]
	Shape_Primitive_ADVANCED_Octahedron = 2029,
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	[Config("Quarter Cylinder", 0)]
	Shape_Primitive_RR_QuarterCylinder = 2030,
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	[Config("Pentagon", 0)]
	Shape_Primitive_RR_Pentagon = 2031,
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	[Config("Quarter Sphere", 0)]
	Shape_Primitive_RR_QuarterSphere = 2032,
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	[Config("Wedge (Simple)", 0)]
	Shape_Primitive_ADVANCED_Wedge = 2033,
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	[Config("Hexagon", 0)]
	Shape_Primitive_RR_Hexagon = 2034,
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	[Config("Octagon", 0)]
	Shape_Primitive_RR_Octagon = 2035,
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	[Config("Triangle", 0)]
	Shape_Primitive_RR_Triangle = 2036,
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	[Config("Spline", 0)]
	Shape_Spline = 3000,
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	[Config("Container Pivot", 0)]
	Other_ContainerPivot = 6000,
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	[Config("Spine Point", 0)]
	Other_SplinePoint = 6001,
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	[Config("Reference Point", 0)]
	Other_ReferencePoint = 6002,
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	[Config("UserTags", 0)]
	Other_UserTag = 6003,
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	[Config("Reference Group", 0)]
	Other_ReferenceGroup = 6004,
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	[Config("Interaction Filter", 0)]
	Other_InteractionFilterTags = 6005,
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	[ConfigIgnore]
	Other_DesyncNetworkObject = 6006,
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	[ConfigIgnore]
	NativeObject_SnapPoint = 5000,
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	[Config("Object", 0)]
	PrefabRootGameObject = 7000,
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	[Config("PrefabInternal", 0)]
	PrefabInternalGameObject = 7001,
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	[Config("Player", 0)]
	Player = 8000
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public static class LFBJMMLKDDI
{
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	[CompilerGenerated]
	private sealed class ALJAGGBMAOP : IEnumerable<IBLPJFKLOID>, IEnumerable, IEnumerator<IBLPJFKLOID>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		private IBLPJFKLOID <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		private IEnumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		private IBLPJFKLOID System.Collections.Generic.IEnumerator<RecRoom.DataLayer.ObjectPrefabType>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0xAB4D50", Offset = "0xAB3950", VA = "0x180AB4D50", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(IBLPJFKLOID);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x80A0D90", Offset = "0x809F990", VA = "0x1880A0D90", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x1356980", Offset = "0x1355580", VA = "0x181356980")]
		[DebuggerHidden]
		public ALJAGGBMAOP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x80A0DE0", Offset = "0x809F9E0", VA = "0x1880A0DE0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x80A0A30", Offset = "0x809F630", VA = "0x1880A0A30", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x80A09D0", Offset = "0x809F5D0", VA = "0x1880A09D0")]
		private void BOPPOGEKEOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x80A0D40", Offset = "0x809F940", VA = "0x1880A0D40", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x80A0CA0", Offset = "0x809F8A0", VA = "0x1880A0CA0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<IBLPJFKLOID> System.Collections.Generic.IEnumerable<RecRoom.DataLayer.ObjectPrefabType>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x80A0CA0", Offset = "0x809F8A0", VA = "0x1880A0CA0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000092")]
	[CompilerGenerated]
	private sealed class MHKCPFAOHMO : IEnumerable<IBLPJFKLOID>, IEnumerable, IEnumerator<IBLPJFKLOID>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		private IBLPJFKLOID <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		private IBLPJFKLOID <last>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		private IBLPJFKLOID <i>5__3;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		private IBLPJFKLOID System.Collections.Generic.IEnumerator<RecRoom.DataLayer.ObjectPrefabType>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0xAB4D50", Offset = "0xAB3950", VA = "0x180AB4D50", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(IBLPJFKLOID);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x80A3BD0", Offset = "0x80A27D0", VA = "0x1880A3BD0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x1356980", Offset = "0x1355580", VA = "0x181356980")]
		[DebuggerHidden]
		public MHKCPFAOHMO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x80A3A80", Offset = "0x80A2680", VA = "0x1880A3A80", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x80A3B80", Offset = "0x80A2780", VA = "0x1880A3B80", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x80A3AE0", Offset = "0x80A26E0", VA = "0x1880A3AE0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<IBLPJFKLOID> System.Collections.Generic.IEnumerable<RecRoom.DataLayer.ObjectPrefabType>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x80A3AE0", Offset = "0x80A26E0", VA = "0x1880A3AE0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000093")]
	[CompilerGenerated]
	private sealed class OAHOGHNGCCC : IEnumerable<IBLPJFKLOID>, IEnumerable, IEnumerator<IBLPJFKLOID>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		private IBLPJFKLOID <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		private IEnumerator<IBLPJFKLOID> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		private IBLPJFKLOID System.Collections.Generic.IEnumerator<RecRoom.DataLayer.ObjectPrefabType>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0xAB4D50", Offset = "0xAB3950", VA = "0x180AB4D50", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(IBLPJFKLOID);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x80A4640", Offset = "0x80A3240", VA = "0x1880A4640", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x1356980", Offset = "0x1355580", VA = "0x181356980")]
		[DebuggerHidden]
		public OAHOGHNGCCC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x80A4690", Offset = "0x80A3290", VA = "0x1880A4690", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x80A42B0", Offset = "0x80A2EB0", VA = "0x1880A42B0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x80A4260", Offset = "0x80A2E60", VA = "0x1880A4260")]
		private void BOPPOGEKEOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x80A45F0", Offset = "0x80A31F0", VA = "0x1880A45F0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x80A4550", Offset = "0x80A3150", VA = "0x1880A4550", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<IBLPJFKLOID> System.Collections.Generic.IEnumerable<RecRoom.DataLayer.ObjectPrefabType>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x80A4550", Offset = "0x80A3150", VA = "0x1880A4550", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x80A3490", Offset = "0x80A2090", VA = "0x1880A3490")]
	[IteratorStateMachine(typeof(ALJAGGBMAOP))]
	public static IEnumerable<IBLPJFKLOID> KKMAIJCFJPO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x80A3430", Offset = "0x80A2030", VA = "0x1880A3430")]
	[IteratorStateMachine(typeof(MHKCPFAOHMO))]
	public static IEnumerable<IBLPJFKLOID> DFEMAGAIJPC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x80A34F0", Offset = "0x80A20F0", VA = "0x1880A34F0")]
	[IteratorStateMachine(typeof(OAHOGHNGCCC))]
	public static IEnumerable<IBLPJFKLOID> LEFNFBGEAIL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
public static class GAHKNBCCIED
{
	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x80A2530", Offset = "0x80A1130", VA = "0x1880A2530")]
	public static bool LJAEEGOEOJB(this RRObjectPrefabData HCNOFOGDHDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x80A2560", Offset = "0x80A1160", VA = "0x1880A2560")]
	public static bool LJAEEGOEOJB(this IBLPJFKLOID MDCDODCGNEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x80A24A0", Offset = "0x80A10A0", VA = "0x1880A24A0")]
	public static bool HBGFPJCFLNH(this RRObjectPrefabData HCNOFOGDHDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x80A24D0", Offset = "0x80A10D0", VA = "0x1880A24D0")]
	public static bool HBGFPJCFLNH(this IBLPJFKLOID MDCDODCGNEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x80A2480", Offset = "0x80A1080", VA = "0x1880A2480")]
	public static BHNGGMAMCBI EPGFFIEEMLH(this IBLPJFKLOID JBGFIFPOODI)
	{
		return default(BHNGGMAMCBI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x80A2500", Offset = "0x80A1100", VA = "0x1880A2500")]
	internal static PCOJMIKHIEM JIGLIGBGDDL(this BHNGGMAMCBI JGFNGJHIJOE)
	{
		return default(PCOJMIKHIEM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x80A2510", Offset = "0x80A1110", VA = "0x1880A2510")]
	internal static PCOJMIKHIEM JIGLIGBGDDL(this IBLPJFKLOID JBGFIFPOODI)
	{
		return default(PCOJMIKHIEM);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
internal enum PCOJMIKHIEM
{
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	Container = 1000,
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	Empty = 4000,
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	Primitive = 2000,
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	Spline = 3000,
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	Other = 6000,
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	NativeObject = 5000,
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	GameObject = 7000,
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	Player = 8000
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.RRGuid("A32413BC-21F3-4F7C-84B0-37724A854A67")]
[RecRoom.DataLayer.Range(0, 8)]
public enum BHNGGMAMCBI
{
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	Container,
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	Primitive,
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	Spline,
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	Empty,
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	NativeObject,
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	Other,
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	GameObject,
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	Player
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public static class IKLHOENCBPL
{
	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x80A3060", Offset = "0x80A1C60", VA = "0x1880A3060")]
	public static bool PBLOLLKBEDG(this BHNGGMAMCBI JGFNGJHIJOE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
[RecRoom.DataLayer.RRGuid("7A0D34B5-FFE5-4C21-BB0C-CB3EBA34C797")]
[RecRoom.DataLayer.NetworkEnum(3, false)]
[Flags]
[RecRoom.DataLayer.Range(0, GCOFBKNOKHB.ALL)]
public enum GCOFBKNOKHB : ushort
{
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	NONE = 0,
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	PhysicsEnabled = 1,
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	GravityEnabled = 2,
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	HasCustomMass = 4,
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	CollisionEvent = 0x40,
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	CanUse = 0x200,
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	CanClimb = 0x400,
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	CanWallRun = 0x800,
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	CanClamber = 0x1000,
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	CanTeleport = 0x2000,
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	SuppressCollision = 0x4000,
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	DEFAULT = 0x3800,
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	ALL = 0x7E47,
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	MAX = 0x7E47
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	[RecRoom.DataLayer.StableTypeHash(8060729269509364919uL, 0u)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(8060729269509364919uL)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("5D4503E7-6CC4-4938-8840-1B859C391878")]
	public struct PrimitiveShapeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public LDLEEKNJJFJ shapeType;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
[RecRoom.DataLayer.RRGuid("517224CC-0A79-4FE9-B048-53C37955D823")]
[RecRoom.DataLayer.Range(-1, 38)]
[RecRoom.DataLayer.NetworkEnum(1, false)]
public enum LDLEEKNJJFJ
{
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	LegacyBox = 2,
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	RR_Sphere = 3,
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	RR_Cylinder = 4,
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	LEGACY_Wedge = 5,
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	LEGACY_Pyramid = 6,
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	LEGACY_TriggerVolumeBox = 7,
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	RR_Box = 8,
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	LEGACY_RoundedBox = 9,
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	RR_Wedge = 10,
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	RR_Pyramid = 11,
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	RR_HalfSphere = 12,
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	RR_Cone = 13,
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	RR_Pipe = 14,
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	RR_Donut = 15,
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	RR_HalfPipe = 16,
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	RR_Diamond = 17,
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	ADVANCED_Mound = 18,
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	ADVANCED_Cube = 19,
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	ADVANCED_Sphere = 20,
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	ADVANCED_Cylinder = 21,
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	ADVANCED_Cone = 22,
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	ADVANCED_Pyramid = 23,
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	ADVANCED_Octagon = 24,
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	ADVANCED_Triangle = 25,
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	ADVANCED_Hexagon = 26,
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	ADVANCED_QuarterPipe = 27,
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	ADVANCED_Pentagon = 28,
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	ADVANCED_Dodecahedron = 29,
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	ADVANCED_Trihedron = 30,
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	ADVANCED_Octahedron = 31,
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	RR_QuarterCylinder = 32,
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	RR_Pentagon = 33,
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	RR_QuarterSphere = 34,
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	ADVANCED_Wedge = 35,
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	RR_Hexagon = 36,
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	RR_Octagon = 37,
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	RR_Triangle = 38,
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	COUNT = 39,
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	MIN_VALUE = -1,
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	MAX_VALUE = 38
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
[RecRoom.DataLayer.Range(MCKGLJLILAB.None, MCKGLJLILAB.COUNT)]
[RecRoom.DataLayer.RRGuid("3D27DF09-CAE2-4C3F-B808-03AD605F8E98")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
public enum MCKGLJLILAB : byte
{
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	AnimationGroup = 1,
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	COUNT = 2,
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	MAX = 2
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
[Flags]
[RecRoom.DataLayer.RRGuid("1829B7EA-C0EA-4E77-8EB2-BA23E995C860")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.Range(0, 7)]
public enum EHENCINGLKE
{
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	DynamicUVProjection = 1,
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	PreventInvertedCreation = 2,
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	NewBendLogic = 4,
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	All = 7,
	[Cpp2IlInjected.Token(Token = "0x4000207")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	MAX = 7
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
[RecRoom.DataLayer.Range(0, 7)]
[RecRoom.DataLayer.RRGuid("CCB58F66-EF02-476E-820F-9D593E2C3DE5")]
[Flags]
[RecRoom.DataLayer.NetworkEnum(1, false)]
public enum IJJMALMNFPP
{
	[Cpp2IlInjected.Token(Token = "0x400020A")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400020B")]
	IsRibbon = 1,
	[Cpp2IlInjected.Token(Token = "0x400020C")]
	RoundedTubes = 2,
	[Cpp2IlInjected.Token(Token = "0x400020D")]
	OldStyleCaps = 4,
	[Cpp2IlInjected.Token(Token = "0x400020E")]
	All = 7,
	[Cpp2IlInjected.Token(Token = "0x400020F")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000210")]
	MAX = 7
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.Range(GJCBKPICDAM.Default, GJCBKPICDAM.Count)]
[RecRoom.DataLayer.RRGuid("97516D96-FDF4-4ECC-881B-57A014A7D805")]
public enum GJCBKPICDAM
{
	[Cpp2IlInjected.Token(Token = "0x4000212")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000213")]
	Import,
	[Cpp2IlInjected.Token(Token = "0x4000214")]
	Generate,
	[Cpp2IlInjected.Token(Token = "0x4000215")]
	Ignore,
	[Cpp2IlInjected.Token(Token = "0x4000216")]
	Count
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
[RecRoom.DataLayer.Range(GCHCIDJPNLL.Everywhere, GCHCIDJPNLL.MAX)]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.RRGuid("4913AA4C-C771-455C-AF49-938E5DEA653E")]
public enum GCHCIDJPNLL : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000218")]
	Everywhere,
	[Cpp2IlInjected.Token(Token = "0x4000219")]
	Center,
	[Cpp2IlInjected.Token(Token = "0x400021A")]
	Edges,
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	North,
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	South,
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	East,
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	West,
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	RandomLines,
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	RandomBlobs,
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	MAX
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
[RecRoom.DataLayer.Range(DIPACINJNHP.Normal, DIPACINJNHP.MAX)]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.RRGuid("4AD21D91-EFC4-4DAD-863D-4014EB5AB12D")]
public enum DIPACINJNHP : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	Normal,
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	Steep,
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	Mesa,
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	MAX
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.Range(KCNHKGPCNMH.GentleSlopes, KCNHKGPCNMH.MAX)]
[RecRoom.DataLayer.RRGuid("4DAD40E0-53B5-4B82-B53A-BC3E96F9B507")]
public enum KCNHKGPCNMH : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	GentleSlopes,
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	RuggedSlopes,
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	Flat,
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	MediumSlopes,
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	RiverBed,
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	MAX
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
[RecRoom.DataLayer.RRGuid("966E2586-2CE9-4280-898A-894565917A54")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.Range(ICMOIJBHMPP.Circle, ICMOIJBHMPP.MAX)]
public enum ICMOIJBHMPP : byte
{
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	Circle,
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	Square,
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	MAX
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
[RecRoom.DataLayer.Range(0, 1)]
[RecRoom.DataLayer.RRGuid("72742F9B-D48E-4CED-B403-444201FFEE66")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[Flags]
public enum DBNFECDEJAL
{
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	Static = 0,
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	Dynamic = 1,
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	All = 1
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.Range(-2, 2)]
[RecRoom.DataLayer.RRGuid("C5BE1CDA-5EF5-4EBF-BC7E-3E3510C68A7F")]
public enum KCMGGEJIJHC
{
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	Frozen = -2,
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	Low = -1,
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	Normal = 0,
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	High = 1,
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	Realtime = 2,
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	Default = 0,
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	MIN = -2,
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	MAX = 2
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.RRGuid("D6AFAFED-8BAA-4499-9696-9CBB716EF514")]
[RecRoom.DataLayer.Range(int.MinValue, int.MaxValue)]
public enum PFELNBBIHNK
{
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	Red = 0,
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	Orange = 1,
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	Yellow = 2,
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	LightGreen = 3,
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	Blue = 4,
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	LightBlue = 5,
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	Teal = 6,
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	Green = 7,
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	Purple = 8,
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	LightPink = 9,
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	Pink = 10,
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	Brown = 11,
	[Cpp2IlInjected.Token(Token = "0x400024E")]
	Tan = 12,
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	White = 13,
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	Grey = 14,
	[Cpp2IlInjected.Token(Token = "0x4000251")]
	DarkGrey = 15,
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	DarkBrown = 16,
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	LightBrown = 17,
	[Cpp2IlInjected.Token(Token = "0x4000254")]
	LightGrey = 18,
	[Cpp2IlInjected.Token(Token = "0x4000255")]
	Black = 19,
	[Cpp2IlInjected.Token(Token = "0x4000256")]
	DarkRed = 20,
	[Cpp2IlInjected.Token(Token = "0x4000257")]
	DarkOrange = 21,
	[Cpp2IlInjected.Token(Token = "0x4000258")]
	DarkYellow = 22,
	[Cpp2IlInjected.Token(Token = "0x4000259")]
	DarkGreen = 23,
	[Cpp2IlInjected.Token(Token = "0x400025A")]
	DarkTeal = 24,
	[Cpp2IlInjected.Token(Token = "0x400025B")]
	DarkBlue = 25,
	[Cpp2IlInjected.Token(Token = "0x400025C")]
	DarkPurple = 26,
	[Cpp2IlInjected.Token(Token = "0x400025D")]
	DarkPink = 27,
	[Cpp2IlInjected.Token(Token = "0x400025E")]
	LightRed = 28,
	[Cpp2IlInjected.Token(Token = "0x400025F")]
	LightOrange = 29,
	[Cpp2IlInjected.Token(Token = "0x4000260")]
	LightYellow = 30,
	[Cpp2IlInjected.Token(Token = "0x4000261")]
	Cyan = 31,
	[Cpp2IlInjected.Token(Token = "0x4000262")]
	LightPurple = 32,
	[Cpp2IlInjected.Token(Token = "0x4000263")]
	DarkTan = 33,
	[Cpp2IlInjected.Token(Token = "0x4000264")]
	NewColor1 = 34,
	[Cpp2IlInjected.Token(Token = "0x4000265")]
	NewColor2 = 35,
	[Cpp2IlInjected.Token(Token = "0x4000266")]
	NewColor3 = 36,
	[Cpp2IlInjected.Token(Token = "0x4000267")]
	NewColor4 = 37,
	[Cpp2IlInjected.Token(Token = "0x4000268")]
	NewColor5 = 38,
	[Cpp2IlInjected.Token(Token = "0x4000269")]
	NewColor6 = 39,
	[Cpp2IlInjected.Token(Token = "0x400026A")]
	NewColor7 = 40,
	[Cpp2IlInjected.Token(Token = "0x400026B")]
	NewColor8 = 41,
	[Cpp2IlInjected.Token(Token = "0x400026C")]
	NewColor9 = 42,
	[Cpp2IlInjected.Token(Token = "0x400026D")]
	NewColor10 = 43,
	[Cpp2IlInjected.Token(Token = "0x400026E")]
	NewColor11 = 44,
	[Cpp2IlInjected.Token(Token = "0x400026F")]
	NewColor12 = 45,
	[Cpp2IlInjected.Token(Token = "0x4000270")]
	NewColor13 = 46,
	[Cpp2IlInjected.Token(Token = "0x4000271")]
	NewColor14 = 47,
	[Cpp2IlInjected.Token(Token = "0x4000272")]
	NewColor15 = 48,
	[Cpp2IlInjected.Token(Token = "0x4000273")]
	NewColor16 = 49,
	[Cpp2IlInjected.Token(Token = "0x4000274")]
	NewColor17 = 50,
	[Cpp2IlInjected.Token(Token = "0x4000275")]
	NewColor18 = 51,
	[Cpp2IlInjected.Token(Token = "0x4000276")]
	NewColor19 = 52,
	[Cpp2IlInjected.Token(Token = "0x4000277")]
	NewColor20 = 53,
	[Cpp2IlInjected.Token(Token = "0x4000278")]
	NewColor21 = 54,
	[Cpp2IlInjected.Token(Token = "0x4000279")]
	NewColor22 = 55,
	[Cpp2IlInjected.Token(Token = "0x400027A")]
	NewColor23 = 56,
	[Cpp2IlInjected.Token(Token = "0x400027B")]
	NewColor24 = 57,
	[Cpp2IlInjected.Token(Token = "0x400027C")]
	NewColor25 = 58,
	[Cpp2IlInjected.Token(Token = "0x400027D")]
	NewColor26 = 59,
	[Cpp2IlInjected.Token(Token = "0x400027E")]
	NewColor27 = 60,
	[Cpp2IlInjected.Token(Token = "0x400027F")]
	Default = 0
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
[RecRoom.DataLayer.Range(-1, 31)]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.RRGuid("C57BE511-BA1A-4D83-BA58-303F34F4DE74")]
public enum MEKNHMCLLHC
{
	[Cpp2IlInjected.Token(Token = "0x4000281")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x4000282")]
	Cardboard = 0,
	[Cpp2IlInjected.Token(Token = "0x4000283")]
	Neon = 1,
	[Cpp2IlInjected.Token(Token = "0x4000284")]
	Brick = 2,
	[Cpp2IlInjected.Token(Token = "0x4000285")]
	Carpet = 3,
	[Cpp2IlInjected.Token(Token = "0x4000286")]
	Dirt = 4,
	[Cpp2IlInjected.Token(Token = "0x4000287")]
	Grass = 5,
	[Cpp2IlInjected.Token(Token = "0x4000288")]
	MetalReflective = 6,
	[Cpp2IlInjected.Token(Token = "0x4000289")]
	Concrete = 7,
	[Cpp2IlInjected.Token(Token = "0x400028A")]
	Linoleum = 8,
	[Cpp2IlInjected.Token(Token = "0x400028B")]
	Plaster = 9,
	[Cpp2IlInjected.Token(Token = "0x400028C")]
	WoodLogs = 10,
	[Cpp2IlInjected.Token(Token = "0x400028D")]
	WoodBoards = 11,
	[Cpp2IlInjected.Token(Token = "0x400028E")]
	WoodGrain = 12,
	[Cpp2IlInjected.Token(Token = "0x400028F")]
	WoodFloor = 13,
	[Cpp2IlInjected.Token(Token = "0x4000290")]
	Sand = 14,
	[Cpp2IlInjected.Token(Token = "0x4000291")]
	GlossyPlastic = 15,
	[Cpp2IlInjected.Token(Token = "0x4000292")]
	Cloth = 16,
	[Cpp2IlInjected.Token(Token = "0x4000293")]
	RubberFloor = 17,
	[Cpp2IlInjected.Token(Token = "0x4000294")]
	MetalFloorTread = 18,
	[Cpp2IlInjected.Token(Token = "0x4000295")]
	PaintedBrick = 19,
	[Cpp2IlInjected.Token(Token = "0x4000296")]
	Crashpad = 20,
	[Cpp2IlInjected.Token(Token = "0x4000297")]
	PaintedWood = 21,
	[Cpp2IlInjected.Token(Token = "0x4000298")]
	GripTape = 22,
	[Cpp2IlInjected.Token(Token = "0x4000299")]
	GalvanizedMetal = 23,
	[Cpp2IlInjected.Token(Token = "0x400029A")]
	ParticleBoard = 24,
	[Cpp2IlInjected.Token(Token = "0x400029B")]
	CheckeredFloor = 25,
	[Cpp2IlInjected.Token(Token = "0x400029C")]
	SparklyVinyl = 26,
	[Cpp2IlInjected.Token(Token = "0x400029D")]
	Gravel = 27,
	[Cpp2IlInjected.Token(Token = "0x400029E")]
	Rock = 28,
	[Cpp2IlInjected.Token(Token = "0x400029F")]
	Placeholder29 = 29,
	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	Placeholder30 = 30,
	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	Placeholder31 = 31,
	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	COUNT = 32,
	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	MIN = -1,
	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	MAX = 31,
	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	Default = 0
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
[RecRoom.DataLayer.RRGuid("B23E7E5C-828C-4A29-9AB2-774DFC53D18E")]
[RecRoom.DataLayer.NetworkInterface(1, false)]
public interface MAAIGLGFMMK : GKNPGOIAOJL
{
	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	[ProtoProp("PersistenceViewData.SandboxDeformationData.Deformation", typeof(KHDMCOLMFDK))]
	[RecRoom.DataLayer.Field(1)]
	[RecRoom.DataLayer.Key("SBDScale")]
	[RecRoom.DataLayer.Default]
	[Set.Auth]
	float3 CBMLEOEPLHL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action PIPINFCCFGC;
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
[RecRoom.DataLayer.NetworkStruct(1, false)]
[RecRoom.DataLayer.RRGuid("112F004A-C92F-4055-99F9-D430EC13FE3C")]
public struct EJDHJMPEDMM : IComparable<EJDHJMPEDMM>, IEquatable<EJDHJMPEDMM>
{
	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	public static readonly EJDHJMPEDMM LNCBONNLALO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002A7")]
	[RecRoom.DataLayer.Field(1)]
	public uint DBILMKLMBLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40002A8")]
	[RecRoom.DataLayer.Field(2)]
	public uint OJAIBOFNAND;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	private readonly uint PFPAINLJHKM
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x80A1E80", Offset = "0x80A0A80", VA = "0x1880A1E80")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public readonly bool BGMCAGMEELL
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x80A1C30", Offset = "0x80A0830", VA = "0x1880A1C30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x80A2270", Offset = "0x80A0E70", VA = "0x1880A2270")]
	public EJDHJMPEDMM(int DBILMKLMBLI, int FAKGGKHPMDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x80A2270", Offset = "0x80A0E70", VA = "0x1880A2270")]
	public EJDHJMPEDMM(uint DBILMKLMBLI, uint FAKGGKHPMDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x80A22D0", Offset = "0x80A0ED0", VA = "0x1880A22D0")]
	private EJDHJMPEDMM(uint DBILMKLMBLI, uint FAKGGKHPMDJ, bool FBKJOAELMIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x80A1C80", Offset = "0x80A0880", VA = "0x1880A1C80")]
	public EJDHJMPEDMM DCOJIFAFAGI(int HDEKJKJDEIC = 1)
	{
		return default(EJDHJMPEDMM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x80A1BC0", Offset = "0x80A07C0", VA = "0x1880A1BC0")]
	public EJDHJMPEDMM ANIOAOKMBBN(int HDEKJKJDEIC = 1)
	{
		return default(EJDHJMPEDMM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x80A1E90", Offset = "0x80A0A90", VA = "0x1880A1E90")]
	public static EJDHJMPEDMM NPAAOPPDLBF(EJDHJMPEDMM ODBANBBPCIA, EJDHJMPEDMM FMNHBACBGIN)
	{
		return default(EJDHJMPEDMM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x80A1E40", Offset = "0x80A0A40", VA = "0x1880A1E40")]
	private static ulong JKPCEAJDACB(ulong JPILOOHOBDJ, ulong MAKDDCFIOBO)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x80A1C60", Offset = "0x80A0860", VA = "0x1880A1C60", Slot = "4")]
	public int CompareTo(EJDHJMPEDMM IIOGPDPGOLB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x80A1CF0", Offset = "0x80A08F0", VA = "0x1880A1CF0", Slot = "0")]
	public override bool Equals(object KOJLNGLNBMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x80A2190", Offset = "0x80A0D90", VA = "0x1880A2190", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x80A1D90", Offset = "0x80A0990", VA = "0x1880A1D90", Slot = "5")]
	public bool Equals(EJDHJMPEDMM IIOGPDPGOLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x80A1DB0", Offset = "0x80A09B0", VA = "0x1880A1DB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x3D2A8F0", Offset = "0x3D294F0", VA = "0x183D2A8F0")]
	public static bool CDGFDPOPEPC(EJDHJMPEDMM ODBANBBPCIA, EJDHJMPEDMM FMNHBACBGIN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x80A1E20", Offset = "0x80A0A20", VA = "0x1880A1E20")]
	public static bool IECKAGJENEB(EJDHJMPEDMM ODBANBBPCIA, EJDHJMPEDMM FMNHBACBGIN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x80A1E00", Offset = "0x80A0A00", VA = "0x1880A1E00")]
	public static bool HMBMEHJDJDM(EJDHJMPEDMM ODBANBBPCIA, EJDHJMPEDMM FMNHBACBGIN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x80A1C40", Offset = "0x80A0840", VA = "0x1880A1C40")]
	public static bool CLMJAPOJGDO(EJDHJMPEDMM ODBANBBPCIA, EJDHJMPEDMM FMNHBACBGIN)
	{
		return default(bool);
	}
}
namespace RecRoom.DataLayer
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	[RecRoom.DataLayer.NetworkStruct(1, false)]
	[RecRoom.DataLayer.RRGuid("D3AB0F52-EA41-4891-9470-6E945A9D6583")]
	public struct NetworkGuid : IEquatable<NetworkGuid>, IComparable<NetworkGuid>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		[RecRoom.DataLayer.Field(1)]
		public int4 data;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public Guid Guid
		{
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x11E4610", Offset = "0x11E3210", VA = "0x1811E4610")]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x14354C0", Offset = "0x14340C0", VA = "0x1814354C0")]
			set
			{
			}
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x11E4610", Offset = "0x11E3210", VA = "0x1811E4610")]
		public static Guid KDDDGPNBGLG(NetworkGuid FHNOHJCOOKK)
		{
			return default(Guid);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x11E4610", Offset = "0x11E3210", VA = "0x1811E4610")]
		public static NetworkGuid KDDDGPNBGLG(Guid FHNOHJCOOKK)
		{
			return default(NetworkGuid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x80A4210", Offset = "0x80A2E10", VA = "0x1880A4210", Slot = "4")]
		public bool Equals(NetworkGuid IIOGPDPGOLB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x4E9CF70", Offset = "0x4E9BB70", VA = "0x184E9CF70", Slot = "5")]
		public int CompareTo(NetworkGuid IIOGPDPGOLB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x80A4240", Offset = "0x80A2E40", VA = "0x1880A4240", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
[RecRoom.DataLayer.NetworkStruct(1, false)]
[RecRoom.DataLayer.RRGuid("9F5F33BE-7C0A-4870-9CE0-BA79440E7F98")]
public struct PLGJBNGJIHN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002AA")]
	[RecRoom.DataLayer.Field(1)]
	public bool PMENEMBMEBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	[RecRoom.DataLayer.Field(2)]
	public float3 DMDHFOIBLHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002AC")]
	[RecRoom.DataLayer.Field(3)]
	public float3 EMIGICCIBIM;

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x809F3E0", Offset = "0x809DFE0", VA = "0x18809F3E0")]
	public PLGJBNGJIHN(float MPPPNIHIBJF, float ENBPGBPHHMH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
[RecRoom.DataLayer.RRGuid("35984D5B-ACBD-4389-A94B-840070A871E2")]
[RecRoom.DataLayer.NetworkStruct(1, false)]
public struct LIACMAGLFCP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002AD")]
	[RecRoom.DataLayer.Field(1)]
	public float MMDCHBAKHMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40002AE")]
	[RecRoom.DataLayer.Field(2)]
	public int NGAFEKGAMPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40002AF")]
	[RecRoom.DataLayer.Field(3)]
	public IJJMALMNFPP HHPCFHFLKHA;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public bool JKMDJDJCGGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x80A35B0", Offset = "0x80A21B0", VA = "0x1880A35B0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x80A35C0", Offset = "0x80A21C0", VA = "0x1880A35C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public bool PFJLFFLPPIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x80A3590", Offset = "0x80A2190", VA = "0x1880A3590")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x80A3550", Offset = "0x80A2150", VA = "0x1880A3550")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public bool DHEBGNPKEMN
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x80A35A0", Offset = "0x80A21A0", VA = "0x1880A35A0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x80A3570", Offset = "0x80A2170", VA = "0x1880A3570")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
[RecRoom.DataLayer.RRGuid("88EB8A39-C735-43FA-8414-C0B7AEEF4FF6")]
[RecRoom.DataLayer.NetworkStruct(1, false)]
public struct CPAFJEBFNBF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002B0")]
	[RecRoom.DataLayer.Field(1)]
	public PFELNBBIHNK IPKGOHNKIPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40002B1")]
	[RecRoom.DataLayer.Field(2)]
	public MEKNHMCLLHC HFCMNAJNHAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40002B2")]
	[RecRoom.DataLayer.Field(3)]
	public PFELNBBIHNK ENMNLEHCBGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40002B3")]
	[RecRoom.DataLayer.Field(4)]
	public MEKNHMCLLHC JBEGCKMGIGH;
}
namespace RecRoom.DataLayer
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	[RecRoom.DataLayer.NetworkStruct(1, false)]
	[RecRoom.DataLayer.RRGuid("CE1911D2-B422-4E58-B0D6-2474AEA69D41")]
	public struct TerrainGenerationLayer
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		[RecRoom.DataLayer.Field(1)]
		public KCNHKGPCNMH TerrainRoughness;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		[RecRoom.DataLayer.Field(2)]
		public GCHCIDJPNLL TerrainShape;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		[RecRoom.DataLayer.Field(3)]
		public DIPACINJNHP HeightFunction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		[RecRoom.DataLayer.Field(4)]
		public float FeatureScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		[RecRoom.DataLayer.Field(5)]
		public float Height;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
public struct IHJNLMEPEBP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	public FKBOJAJCNNN NFMCACNMIGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	public int GIIAJJKPPFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	public bool DHPGIJPNDIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD")]
	[Cpp2IlInjected.Token(Token = "0x40002BC")]
	public bool OJIALPIHJPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE")]
	[Cpp2IlInjected.Token(Token = "0x40002BD")]
	public bool FOJIDJKIPKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002BE")]
	public Vector3 BCBKGNPANPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40002BF")]
	public Quaternion EFKBKJCNDBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40002C0")]
	public bool KKBGDBMJCIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002C1")]
	public Vector3 CBMLEOEPLHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40002C2")]
	public Vector3 NHFKLGEKCLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40002C3")]
	public Vector3 PMHDBKDKDCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x40002C4")]
	public bool NIMGCPMIEOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40002C5")]
	public ViewId DEDDLIBFNPF;

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x80A26D0", Offset = "0x80A12D0", VA = "0x1880A26D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
public struct DOIPNDLFEIK : IEquatable<DOIPNDLFEIK>, IComparable<DOIPNDLFEIK>
{
	[Cpp2IlInjected.Token(Token = "0x40002C6")]
	public static readonly int AOAGPDNBCCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002C7")]
	public RRObjectPrefabData JBPODHEOMGI;

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x80A1B70", Offset = "0x80A0770", VA = "0x1880A1B70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x80A1AD0", Offset = "0x80A06D0", VA = "0x1880A1AD0", Slot = "4")]
	public bool Equals(DOIPNDLFEIK IIOGPDPGOLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x80A19D0", Offset = "0x80A05D0", VA = "0x1880A19D0", Slot = "0")]
	public override bool Equals(object KOJLNGLNBMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x80A1B40", Offset = "0x80A0740", VA = "0x1880A1B40", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x80A1950", Offset = "0x80A0550", VA = "0x1880A1950", Slot = "5")]
	public int CompareTo(DOIPNDLFEIK IIOGPDPGOLB)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
internal class DDHMEEMBDAN : ContainerPropertyBag<PECJBNMGEAA>
{
	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x80A18F0", Offset = "0x80A04F0", VA = "0x1880A18F0")]
	public DDHMEEMBDAN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
internal class LOJBAHANPBO : ContainerPropertyBag<RRObjectPrefabData>
{
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	private class HMHIMHEOMEP : Property<RRObjectPrefabData, IBLPJFKLOID>
	{
		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public override string FEGHCLOCPPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x80A2680", Offset = "0x80A1280", VA = "0x1880A2680", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public override bool OBFGHCLKFON
		{
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0xAA76B0", Offset = "0xAA62B0", VA = "0x180AA76B0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x80A2590", Offset = "0x80A1190", VA = "0x1880A2590")]
		public HMHIMHEOMEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x2427140", Offset = "0x2425D40", VA = "0x182427140", Slot = "14")]
		public override IBLPJFKLOID GetValue(RRObjectPrefabData EHEGCBFMKDA)
		{
			return default(IBLPJFKLOID);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x809EF60", Offset = "0x809DB60", VA = "0x18809EF60", Slot = "15")]
		public override void SetValue(RRObjectPrefabData EHEGCBFMKDA, IBLPJFKLOID BKMPCFIAHIG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	private class AMGNJDLONKH : Property<RRObjectPrefabData, Guid>
	{
		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public override string FEGHCLOCPPH
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x80A0F40", Offset = "0x809FB40", VA = "0x1880A0F40", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public override bool OBFGHCLKFON
		{
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0xAA76B0", Offset = "0xAA62B0", VA = "0x180AA76B0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x80A0E50", Offset = "0x809FA50", VA = "0x1880A0E50")]
		public AMGNJDLONKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x2BE7F60", Offset = "0x2BE6B60", VA = "0x182BE7F60", Slot = "14")]
		public override Guid GetValue(RRObjectPrefabData EHEGCBFMKDA)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x80A0E40", Offset = "0x809FA40", VA = "0x1880A0E40", Slot = "15")]
		public override void SetValue(RRObjectPrefabData EHEGCBFMKDA, Guid BKMPCFIAHIG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x80A35E0", Offset = "0x80A21E0", VA = "0x1880A35E0")]
	public LOJBAHANPBO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
internal class PMHBOABCFGG : ContainerPropertyBag<Guid>
{
	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x80A4C20", Offset = "0x80A3820", VA = "0x1880A4C20")]
	public PMHBOABCFGG()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x80A4C80", Offset = "0x80A3880", VA = "0x1880A4C80")]
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
