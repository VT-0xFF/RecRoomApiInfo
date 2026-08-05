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
		[Cpp2IlInjected.Address(RVA = "0x9D7E50", Offset = "0x9D6850", VA = "0x1809D7E50")]
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
		[Cpp2IlInjected.Address(RVA = "0x9D7E50", Offset = "0x9D6850", VA = "0x1809D7E50")]
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
	public class LogRegistrationIndex : CCAGPMFGEMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x78B7D80", Offset = "0x78B6780", VA = "0x1878B7D80", Slot = "4")]
		public override void BLLBFFICICF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9D7E50", Offset = "0x9D6850", VA = "0x1809D7E50")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct LPFCEALDCNO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private bool AGCKDENEMBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private ViewId KJKNGBFPEFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private int LMGBAALNFHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private bool GIMHJBIJJMM;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x78B7D20", Offset = "0x78B6720", VA = "0x1878B7D20")]
	public LPFCEALDCNO(ViewId KJKNGBFPEFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x78B7D40", Offset = "0x78B6740", VA = "0x1878B7D40")]
	public LPFCEALDCNO(int LMGBAALNFHC, bool GIMHJBIJJMM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x78B7C40", Offset = "0x78B6640", VA = "0x1878B7C40")]
	public ViewId GGIBJJMCGOA([Optional] ViewId KDDNGBIALHA)
	{
		return default(ViewId);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class CBCADKGEJFN
{
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly Guid FHKIEAKAPAB;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static readonly Guid FAOPCLPKGKB;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static readonly Guid NHAHGECPLFB;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public static readonly Guid LKCLMGCGEDJ;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly Guid FLJIDADBOKP;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public static readonly Dictionary<string, Guid> EBJPHDAFKOP;

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static readonly RRObjectPrefabData DNKLNPNCPBD;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly RRObjectPrefabData KLBHLMCBIKI;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly RRObjectPrefabData PMMDNIGEIDD;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x78B5A30", Offset = "0x78B4430", VA = "0x1878B5A30")]
	public static Guid EHEMCDLNPJJ(string EMLAIMJKHOE)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x78B5AB0", Offset = "0x78B44B0", VA = "0x1878B5AB0")]
	public static RRObjectPrefabData MEIAMLJGFJP(KPBBJPOJBPM OHCGINPDMEI)
	{
		return default(RRObjectPrefabData);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x78B5A60", Offset = "0x78B4460", VA = "0x1878B5A60")]
	public static RRObjectPrefabData HGDNLGMHPMK(KPBBJPOJBPM OHCGINPDMEI)
	{
		return default(RRObjectPrefabData);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x78B5B20", Offset = "0x78B4520", VA = "0x1878B5B20")]
	public static RRObjectPrefabData PNFDPDCBDJE(Guid BIGAPECKJPI)
	{
		return default(RRObjectPrefabData);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[DefaultMember("Item")]
public class IAEIEHMNGOO : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly Dictionary<int, object> DFPGGEDGGGN;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public Dictionary<int, object> LPLAAGCJFBO
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x9AEFD0", Offset = "0x9AD9D0", VA = "0x1809AEFD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public object NKIDLMDDABC
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x78B7210", Offset = "0x78B5C10", VA = "0x1878B7210")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x78B7270", Offset = "0x78B5C70", VA = "0x1878B7270")]
	public IAEIEHMNGOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x9B0720", Offset = "0x9AF120", VA = "0x1809B0720")]
	public IAEIEHMNGOO(Dictionary<int, object> DFPGGEDGGGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x78B70E0", Offset = "0x78B5AE0", VA = "0x1878B70E0")]
	public bool APILFENFFID(LGNEECJPDPC NJBPFCDJFGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x36B0480", Offset = "0x36AEE80", VA = "0x1836B0480")]
	public void GFEPEMIDPMH<T>(LGNEECJPDPC NJBPFCDJFGD, T PPJFMHBDGNA, [Optional] T LPJIMLBFHAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x36B09B0", Offset = "0x36AF3B0", VA = "0x1836B09B0")]
	public void PMHEFKOCJCJ<T>(LGNEECJPDPC NJBPFCDJFGD, T PPJFMHBDGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x78B7140", Offset = "0x78B5B40", VA = "0x1878B7140")]
	public void CBCJJMKDJJC(LGNEECJPDPC NJBPFCDJFGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x78B71A0", Offset = "0x78B5BA0", VA = "0x1878B71A0", Slot = "4")]
	public object Clone()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum LGNEECJPDPC : byte
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
public struct AMOHJKOIAPP<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public readonly LGNEECJPDPC NJBPFCDJFGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly T LPJIMLBFHAO;

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x47ADBA0", Offset = "0x47AC5A0", VA = "0x1847ADBA0")]
	public AMOHJKOIAPP(LGNEECJPDPC NJBPFCDJFGD, T LPJIMLBFHAO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x508FC50", Offset = "0x508E650", VA = "0x18508FC50")]
	public static AMOHJKOIAPP<T> MEHFEEABIDG(LGNEECJPDPC NJBPFCDJFGD)
	{
		return default(AMOHJKOIAPP<T>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x508FCD0", Offset = "0x508E6D0", VA = "0x18508FCD0")]
	public static AMOHJKOIAPP<T> MEHFEEABIDG((LGNEECJPDPC key, T value) KEEADJCBJCP)
	{
		return default(AMOHJKOIAPP<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[DebuggerTypeProxy(typeof(NAAIINNMFLM))]
[DebuggerDisplay("Count = {Count}")]
public struct PDJBLPFEHEB : IEnumerable<object>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private class NAAIINNMFLM : Dictionary<string, object>
	{
	}

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private static readonly LMPJBEBLCLM BLAHIKOFFGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private Dictionary<int, object> KHABEFHMCBM;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool MNPGKBIJONA
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x1646230", Offset = "0x1644C30", VA = "0x181646230")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int NIAGHPMMKPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x78B8360", Offset = "0x78B6D60", VA = "0x1878B8360")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x78B8620", Offset = "0x78B7020", VA = "0x1878B8620")]
	public static PDJBLPFEHEB IDEDHGEBOCJ()
	{
		return default(PDJBLPFEHEB);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0xC9BA30", Offset = "0xC9A430", VA = "0x180C9BA30")]
	public PDJBLPFEHEB([Optional] Dictionary<int, object> KHABEFHMCBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x38366F0", Offset = "0x38350F0", VA = "0x1838366F0")]
	public void HEHCILJMFIP<T>(AMOHJKOIAPP<T> NJBPFCDJFGD, T? PPJFMHBDGNA) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x38363A0", Offset = "0x3834DA0", VA = "0x1838363A0")]
	public void HEHCILJMFIP<T>((AMOHJKOIAPP<T> key, T value) PCDFGDGOHLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3836410", Offset = "0x3834E10", VA = "0x183836410")]
	public void HEHCILJMFIP<T>(AMOHJKOIAPP<T> NJBPFCDJFGD, T PPJFMHBDGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x78B83B0", Offset = "0x78B6DB0", VA = "0x1878B83B0")]
	public void FAPPIOKLKNF(PDJBLPFEHEB KKMIKMKCMKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x78B86A0", Offset = "0x78B70A0", VA = "0x1878B86A0")]
	private void JCFABLNPBJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x3837E00", Offset = "0x3836800", VA = "0x183837E00")]
	public bool OCHHJJBEIMP<T>(AMOHJKOIAPP<T> NJBPFCDJFGD, [Out] T PPJFMHBDGNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x38376B0", Offset = "0x38360B0", VA = "0x1838376B0")]
	public bool OCHHJJBEIMP<T>(LGNEECJPDPC NJBPFCDJFGD, [Out] T PPJFMHBDGNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x38373B0", Offset = "0x3835DB0", VA = "0x1838373B0")]
	public T IAOHMEJGBLH<T>(AMOHJKOIAPP<T> NJBPFCDJFGD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3835F70", Offset = "0x3834970", VA = "0x183835F70")]
	public bool APILFENFFID<T>(AMOHJKOIAPP<T> NJBPFCDJFGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x78B82B0", Offset = "0x78B6CB0", VA = "0x1878B82B0")]
	public bool APILFENFFID(LGNEECJPDPC NJBPFCDJFGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3836090", Offset = "0x3834A90", VA = "0x183836090")]
	public void CBCJJMKDJJC<T>(AMOHJKOIAPP<T> NJBPFCDJFGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x78B8310", Offset = "0x78B6D10", VA = "0x1878B8310")]
	public void CBCJJMKDJJC(LGNEECJPDPC NJBPFCDJFGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0xC9BA50", Offset = "0xC9A450", VA = "0x180C9BA50")]
	public Dictionary<int, object> BHACEJOMPKG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x78B85C0", Offset = "0x78B6FC0", VA = "0x1878B85C0", Slot = "4")]
	public IEnumerator<object> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x78B8720", Offset = "0x78B7120", VA = "0x1878B8720", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public enum MKNPPLLEMJC
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
	DesyncNetworkObjectComponents
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface IIJAAMAGBPD
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public enum IBCDPGIDBJB
	{
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		Entity,
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		Prefab
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	LocalId OPKJNEKBKJN
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	RRObjectPrefabData IPLADHPMECI
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EHODEDBLMOJ(params string[] AGMGBCKIJCO);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OANJJCEJFIC(MKNPPLLEMJC PACIAGIHNFD, IBCDPGIDBJB NDELDEDNMOL = IBCDPGIDBJB.Entity);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MLBIPCFFPOE(Type OHCGINPDMEI, ReadOnlySpan<byte> DFPGGEDGGGN, int ELIMMGHKFAF, IBCDPGIDBJB NDELDEDNMOL = IBCDPGIDBJB.Entity);

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DJIBEHFMBMD(Type OHCGINPDMEI, IBCDPGIDBJB NDELDEDNMOL = IBCDPGIDBJB.Entity);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void DCFOHEPHPLM(MKNPPLLEMJC PACIAGIHNFD, IBCDPGIDBJB NDELDEDNMOL = IBCDPGIDBJB.Entity);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool FBIPIGNDMNC(MKNPPLLEMJC PACIAGIHNFD);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void NIIIGPDIFKD(bool CPOHHLDAHEC, IBCDPGIDBJB NDELDEDNMOL = IBCDPGIDBJB.Entity);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void PDAFGNJDHEC();

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "10")]
	NPJGMIPCEEB AKIEBPAIAGM(Type OHCGINPDMEI);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class OBKALJLPPON
{
	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x78B80B0", Offset = "0x78B6AB0", VA = "0x1878B80B0")]
	public static bool LMBBLLAKMLN(this IIJAAMAGBPD OJFCDDMGKNP, MKNPPLLEMJC ILBJJIFAJFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x78B8050", Offset = "0x78B6A50", VA = "0x1878B8050")]
	public static void HCIGAGAHBEF(this IIJAAMAGBPD OJFCDDMGKNP, IIJAAMAGBPD.IBCDPGIDBJB NDELDEDNMOL = IIJAAMAGBPD.IBCDPGIDBJB.Entity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x78B7FF0", Offset = "0x78B69F0", VA = "0x1878B7FF0")]
	public static void DIKCHNBKFBJ(this IIJAAMAGBPD OJFCDDMGKNP, IIJAAMAGBPD.IBCDPGIDBJB NDELDEDNMOL = IIJAAMAGBPD.IBCDPGIDBJB.Entity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x38173F0", Offset = "0x3815DF0", VA = "0x1838173F0")]
	public static void AMMJDNBKLPC<T>(this IIJAAMAGBPD OJFCDDMGKNP, IIJAAMAGBPD.IBCDPGIDBJB NDELDEDNMOL = IIJAAMAGBPD.IBCDPGIDBJB.Entity) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x341EA30", Offset = "0x341D430", VA = "0x18341EA30")]
	public static void BKMMNIDIMEP<T>(this IIJAAMAGBPD OJFCDDMGKNP, IIJAAMAGBPD.IBCDPGIDBJB NDELDEDNMOL = IIJAAMAGBPD.IBCDPGIDBJB.Entity) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x3817380", Offset = "0x3815D80", VA = "0x183817380")]
	public static void AEGMDPOKFDF<T>(this IIJAAMAGBPD OJFCDDMGKNP, bool ONDKIJMBDMH, IIJAAMAGBPD.IBCDPGIDBJB NDELDEDNMOL = IIJAAMAGBPD.IBCDPGIDBJB.Entity) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x38177C0", Offset = "0x38161C0", VA = "0x1838177C0")]
	public static void MLBIPCFFPOE<T>(this IIJAAMAGBPD OJFCDDMGKNP, T PPJFMHBDGNA, IIJAAMAGBPD.IBCDPGIDBJB NDELDEDNMOL = IIJAAMAGBPD.IBCDPGIDBJB.Entity) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3817430", Offset = "0x3815E30", VA = "0x183817430")]
	public static void DJIBEHFMBMD<T>(this IIJAAMAGBPD OJFCDDMGKNP, IIJAAMAGBPD.IBCDPGIDBJB NDELDEDNMOL = IIJAAMAGBPD.IBCDPGIDBJB.Entity) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x38192D0", Offset = "0x3817CD0", VA = "0x1838192D0")]
	public static void NJNLLGNMGKK<T>(this IIJAAMAGBPD OJFCDDMGKNP, LocalId CEJEEJJKEJL, IIJAAMAGBPD.IBCDPGIDBJB NDELDEDNMOL = IIJAAMAGBPD.IBCDPGIDBJB.Entity) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3817610", Offset = "0x3816010", VA = "0x183817610")]
	private static void MLBIPCFFPOE<T>(this IIJAAMAGBPD OJFCDDMGKNP, Type OHCGINPDMEI, T PPJFMHBDGNA, IIJAAMAGBPD.IBCDPGIDBJB NDELDEDNMOL = IIJAAMAGBPD.IBCDPGIDBJB.Entity) where T : struct
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct GALCBOMIEOE
{
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface BOAGFLLOLPF
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	Entity AMICHBPMCHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface FAIPNKEBNEL
{
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void Bake(IIJAAMAGBPD OJFCDDMGKNP);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface DEKOFCMLILH
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NPJGMIPCEEB GAJLDHKFMKH(Type OHCGINPDMEI);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class DGFJNNJLPKF
{
	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3463EA0", Offset = "0x34628A0", VA = "0x183463EA0")]
	public static void GAJLDHKFMKH<T>(this DEKOFCMLILH OJFCDDMGKNP, [Out] T PPJFMHBDGNA) where T : NPJGMIPCEEB
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface NPJGMIPCEEB
{
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class BCAJCPABPGN
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x33AD2B0", Offset = "0x33ABCB0", VA = "0x1833AD2B0")]
	public static void IMMALMJCKFA<T>(this T HNKGMJGLANC, IIJAAMAGBPD OJFCDDMGKNP) where T : NPJGMIPCEEB, JOMONHBMOBO
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x33AD270", Offset = "0x33ABC70", VA = "0x1833AD270")]
	public static bool ALKOAFDDPIL<T>(this T KMELAMGBDON) where T : NPJGMIPCEEB
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface JOMONHBMOBO
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	Type MAPPDKGNIGA
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ECPAKGCPJJJ(NPJGMIPCEEB KMELAMGBDON);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface HFEIIOJFJKM : FAIPNKEBNEL
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void InitNetworkData(DEKOFCMLILH OJFCDDMGKNP);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface JBGCBJINOLG : NPJGMIPCEEB
{
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface FPDAMLANPLH
{
	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void INBOIKMHHHE(JKHDNFMHOCD LNFLFPBOJOG);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FBFMDEACCFE(JKHDNFMHOCD LNFLFPBOJOG);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface AHBJNOPGEJE
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	ViewId BFGENGGBMBB
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface EEAKLOMOEIA : AHBJNOPGEJE, LAFEENCOAPI
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ELAEPFFNBKM(ViewId NCFPNKLNLDD, ViewId JKKOFNLLJGH, Dictionary<int, object> LCGNOGHMHOC, JKHDNFMHOCD NMGLJLCLAKO);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface FJJGNPGCINA : AHBJNOPGEJE
{
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ELAEPFFNBKM(MNGNDNIEHNP HGBJMKAPAJA, Vector3 GHOLIOPECPJ, Quaternion BOFAHJJKKBL, Vector3 FCPNAKMBNJM, bool HMNEOBIEBHG);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PMKKPGDOAOP(Vector3 GHOLIOPECPJ, Quaternion BOFAHJJKKBL, Vector3 FCPNAKMBNJM);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GICBAHPKOCO(ViewId HGBJMKAPAJA);

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LPCHDLOKMML(bool KMOGIPOCDBK);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CCLBJOMLAMH(bool IHKKLHOGEKE);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface LAFEENCOAPI
{
	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FHGDIHGEBPK();
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface DJCFMDOMDNB
{
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NativeArray<Guid> KGGOEDNEBFP(World ILOAGCFCJMA, NativeArray<Entity> GABLPEMHKBP, Allocator DDBBFOCJEFL);
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface LEBBNCCOKKN
{
	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "0")]
	ReadOnlySpan<byte> CINHKANJDHA(Entity CGNAGBGLBDK, int JJFNHINHLDE);

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CBCOPABPENP(Entity CGNAGBGLBDK, int JJFNHINHLDE, ReadOnlySpan<byte> PPJFMHBDGNA);

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GINMENGEIIA(Entity CGNAGBGLBDK, int JJFNHINHLDE, Action PCKPGHHEKOC);

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KKMEMDDEICE(Entity CGNAGBGLBDK, int JJFNHINHLDE, Action PCKPGHHEKOC);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public static class CHMHIHNHNFI
{
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x3420D40", Offset = "0x341F740", VA = "0x183420D40")]
	public static T PDCJGKFGIKK<T>(this LEBBNCCOKKN KNPJKIONHPL, Entity CGNAGBGLBDK, int JJFNHINHLDE) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3420C10", Offset = "0x341F610", VA = "0x183420C10")]
	public static void JLPABFCOJMI<T>(this LEBBNCCOKKN KNPJKIONHPL, Entity CGNAGBGLBDK, int JJFNHINHLDE, T PPJFMHBDGNA) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public struct KOFCHLAFCHE : IComponentData, IEquatable<KOFCHLAFCHE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	[RecRoom.DataLayer.Default]
	[RecRoom.DataLayer.Field(1)]
	public uint ABKPALEDJBA;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x78B4AF0", Offset = "0x78B34F0", VA = "0x1878B4AF0", Slot = "4")]
	public bool Equals(KOFCHLAFCHE OLKLGHOAKNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x78B7660", Offset = "0x78B6060", VA = "0x1878B7660", Slot = "0")]
	public override bool Equals(object OIIGDBLKEDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x11F8C60", Offset = "0x11F7660", VA = "0x1811F8C60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[RecRoom.DataLayer.RRGuid("A8D1A28C-A057-4DF1-B0CF-22A81E217E19")]
	[SwatchPrimaryKey]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	[TypeManager.ForcedStableTypeHash(11323197429217838438uL)]
	[CompilerGenerated]
	public struct AuthoredAIIdData : IComponentData, IEquatable<AuthoredAIIdData>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public uint Value;

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x78B4AF0", Offset = "0x78B34F0", VA = "0x1878B4AF0", Slot = "4")]
		public bool Equals(AuthoredAIIdData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x78B4B00", Offset = "0x78B3500", VA = "0x1878B4B00", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x11F8C60", Offset = "0x11F7660", VA = "0x1811F8C60", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[RecRoom.DataLayer.RRGuid("B7CEB5B9-453F-4712-B833-27D907AA13E2")]
	[CompilerGenerated]
	[RecRoom.DataLayer.StableTypeHash(11505792609904010668uL, 0u)]
	[TypeManager.ForcedStableTypeHash(11505792609904010668uL)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct AuthoredLocalPoseData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		[RecRoom.DataLayer.Default("new quaternion(new float4(float.NaN))")]
		[RecRoom.DataLayer.Field(1)]
		public quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		[RecRoom.DataLayer.Field(2)]
		[RecRoom.DataLayer.Default("new float3(float.NaN)")]
		public float3 localPosition;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public readonly bool IsValid
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x78B4B90", Offset = "0x78B3590", VA = "0x1878B4B90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x4EA0040", Offset = "0x4E9EA40", VA = "0x184EA0040")]
		public AuthoredLocalPoseData(quaternion localRotation, float3 localPosition)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x78B4BF0", Offset = "0x78B35F0", VA = "0x1878B4BF0")]
		public static RigidTransform MEHFEEABIDG(AuthoredLocalPoseData poseData)
		{
			return default(RigidTransform);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x78B4BF0", Offset = "0x78B35F0", VA = "0x1878B4BF0")]
		public static AuthoredLocalPoseData MEHFEEABIDG(RigidTransform pose)
		{
			return default(AuthoredLocalPoseData);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class CGKCKMPCHCP
{
	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x78B6000", Offset = "0x78B4A00", VA = "0x1878B6000")]
	public static AuthoredLocalPoseData JIGBDLCCGGE([In] this RigidTransform PPJFMHBDGNA)
	{
		return default(AuthoredLocalPoseData);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0xC12D40", Offset = "0xC11740", VA = "0x180C12D40")]
	public static RigidTransform FLPPPLDPLIB(this AuthoredLocalPoseData PPJFMHBDGNA)
	{
		return default(RigidTransform);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x78B5FD0", Offset = "0x78B49D0", VA = "0x1878B5FD0")]
	public static RigidTransform IBBIBMCIEBB([In] this AuthoredLocalPoseData PPJFMHBDGNA)
	{
		return default(RigidTransform);
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[TypeManager.ForcedStableTypeHash(9088562008033959482uL)]
	[RecRoom.DataLayer.StableTypeHash(9088562008033959482uL, 0u)]
	[RecRoom.DataLayer.RRGuid("C26C4B4E-5EF3-4F81-87C8-FED8EAD37242")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[CompilerGenerated]
	public struct AuthoredLocalUniformScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default(1f)]
		public float localUniformScale;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public readonly bool IsValid
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x78B4C10", Offset = "0x78B3610", VA = "0x1878B4C10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x28857F0", Offset = "0x28841F0", VA = "0x1828857F0")]
		public AuthoredLocalUniformScaleData(float localUniformScale)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[RecRoom.DataLayer.StableTypeHash(10137300772124140051uL, 0u)]
	[RecRoom.DataLayer.RRGuid("7B1B8635-3FA9-4ADC-922B-3C25CE0C7E7D")]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[TypeManager.ForcedStableTypeHash(10137300772124140051uL)]
	public struct AuthoredParentData : IComponentData, BOAGFLLOLPF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public Entity parent;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0xC9BA50", Offset = "0xC9A450", VA = "0x180C9BA50", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0xE68EE0", Offset = "0xE678E0", VA = "0x180E68EE0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xE68EE0", Offset = "0xE678E0", VA = "0x180E68EE0")]
		public AuthoredParentData(Entity parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x78B4C70", Offset = "0x78B3670", VA = "0x1878B4C70", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000028")]
public struct HNOKNPKFDMA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000029")]
[TypeManager.ForcedStableTypeHash(11776442497872827640uL)]
public struct KGIHFKNLPNA : IComponentData
{
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[RecRoom.DataLayer.StableTypeHash(8594223769175916906uL, 0u)]
	[RecRoom.DataLayer.RRGuid("B9A63EF5-66A5-463C-8385-A7DC7CE137C3")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(8594223769175916906uL)]
	public struct ObjectBoardNodeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public NetworkGuid nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(2)]
		public NetworkGuid graphId;
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[TypeManager.ForcedStableTypeHash(5933855128949143734uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.RRGuid("B26EF01D-F674-4506-80B7-5345391A097E")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct ReplicatedObjectActiveStatusData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		[RecRoom.DataLayer.Default(true)]
		[RecRoom.DataLayer.Field(1)]
		public bool active;
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(16338184133650423946uL)]
	[RecRoom.DataLayer.RRGuid("E9BA10A4-4EE9-431D-BD7F-FF2008ABFA03")]
	public struct ReplicatedObjectOwnedByPlayerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		[RecRoom.DataLayer.Default(-1)]
		[RecRoom.DataLayer.Field(1)]
		public int actorId;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002D")]
public struct GNGMOJINHLA : IComponentData
{
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[RecRoom.DataLayer.RRGuid("46C500A2-9991-4987-B1AA-66E5C3D8E371")]
	[TypeManager.ForcedStableTypeHash(16223816226138460552uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct ReplicatedObjectTag : IComponentData
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	[RecRoom.DataLayer.RRGuid("5ED157AA-488F-453A-A986-594595B8D777")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(17912083982325865811uL)]
	public struct ReplicatorData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public Entity Target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		[RecRoom.DataLayer.Field(2)]
		[RecRoom.DataLayer.Default(false)]
		public bool NeedsCircuitUpdate;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000030")]
public struct JIPCFCDJIAL : IComponentData
{
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	[RecRoom.DataLayer.RRGuid("AEA4D222-29BA-462F-9C0A-AA2063671C68")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[TypeManager.ForcedStableTypeHash(8691279933813304851uL)]
	public struct ReplicatorMaxObjectCountData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		[RecRoom.DataLayer.Default(10)]
		[RecRoom.DataLayer.Field(1)]
		public int count;
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[TypeManager.ForcedStableTypeHash(16379995002884076574uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.RRGuid("400790C1-E8D9-4779-A549-3780DAEC2FDF")]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	public struct ReplicatorPreallocatedObjectCountData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		[RecRoom.DataLayer.Default(0)]
		[RecRoom.DataLayer.Field(1)]
		public int preallocatedCopies;
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[RecRoom.DataLayer.RRGuid("6A82044A-E392-4DCD-B4BC-A120E58334EA")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[TypeManager.ForcedStableTypeHash(8536678595025273356uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.StableTypeHash(8536678595025273356uL, 0u)]
	public struct EntityPrefabPartData : IComponentData, IComparable<EntityPrefabPartData>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public Entity prefabRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(2)]
		public uint partId;

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x78B6D00", Offset = "0x78B5700", VA = "0x1878B6D00", Slot = "4")]
		public readonly int CompareTo(EntityPrefabPartData other)
		{
			return default(int);
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public struct EntityPrefabPartId : IEquatable<EntityPrefabPartId>, IComparable<EntityPrefabPartId>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		[SerializeField]
		private uint id;

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x11DE630", Offset = "0x11DD030", VA = "0x1811DE630")]
		internal EntityPrefabPartId(uint ICHIIHCEGJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x9F9640", Offset = "0x9F8040", VA = "0x1809F9640")]
		internal uint DPPDJKHHNFN()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x2064E20", Offset = "0x2063820", VA = "0x182064E20", Slot = "4")]
		public bool Equals(EntityPrefabPartId OLKLGHOAKNE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x78B6D50", Offset = "0x78B5750", VA = "0x1878B6D50", Slot = "0")]
		public override bool Equals(object OIIGDBLKEDN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x11F8C60", Offset = "0x11F7660", VA = "0x1811F8C60", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x2064D90", Offset = "0x2063790", VA = "0x182064D90", Slot = "5")]
		public int CompareTo(EntityPrefabPartId OLKLGHOAKNE)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[TypeManager.ForcedStableTypeHash(15026348711748810383uL)]
public struct BJLAGOFPGAJ : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public Entity CPKHDNICNAL;
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[ConfigGroup("Physics", 0)]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	[TypeManager.ForcedStableTypeHash(2330616907306882483uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.RRGuid("F74D558B-BDCC-48C8-A8EF-1F7559E5EAA0")]
	public struct PhysicsModelCollisionModeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		[RecRoom.DataLayer.Default(EOOPGOCNLLN.Children)]
		[Config(null, 0)]
		[RecRoom.DataLayer.Field(1)]
		public EOOPGOCNLLN collisionMode;
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[ConfigGroup("Container", 0)]
	[CompilerGenerated]
	[RecRoom.DataLayer.RRGuid("8A12EB45-2A15-41CE-AFF7-90A9F984D3A2")]
	[TypeManager.ForcedStableTypeHash(11125590729425051511uL)]
	public struct ContainerIsRecolorableData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		[Config(null, 0)]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public bool IsRecolorable;
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[InternalBufferCapacity(0)]
	[TypeManager.ForcedStableTypeHash(14800424556151816553uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.RRGuid("55EAB643-95BB-4C3A-832C-798EBCD95AD5")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct ContainerNameBuffer : IBufferElementData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public byte data;
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[ConfigGroup("Container", 0)]
	[RecRoom.DataLayer.RRGuid("89708D57-D027-494A-A159-221E6C643B6B")]
	[RecRoom.DataLayer.StableTypeHash(13657791279235747653uL, 0u)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[TypeManager.ForcedStableTypeHash(13657791279235747653uL)]
	[CompilerGenerated]
	public struct ContainerNameData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		[RecRoom.DataLayer.Field(1)]
		[Config(null, 0)]
		[RecRoom.DataLayer.Default]
		public FixedString64Bytes name;
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(13904209480152351845uL)]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	[RecRoom.DataLayer.RRGuid("CA023286-E0F6-4DA9-A346-94E86B93977C")]
	[ConfigGroup("Physics", 0)]
	public struct PhysicsModelGrabbableModeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		[Config(null, 0)]
		public FBKFJPCAJHI grabbableMode;
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	[RecRoom.DataLayer.StableTypeHash(16485879999901987510uL, 0u)]
	[TypeManager.ForcedStableTypeHash(16485879999901987510uL)]
	[ConfigGroup("Container", 0)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("84485C1B-18ED-4D4A-86A4-34CEED482615")]
	public struct NavMeshGenerationData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		[Config(null, 0)]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default(LBBNALJLICL.NavMeshGenerator)]
		public LBBNALJLICL mode;
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	[RecRoom.DataLayer.RRGuid("C5BCE8B3-6E69-41D4-921A-BE2E3E0A4DAB")]
	[ConfigGroup("Physics", 0)]
	[TypeManager.ForcedStableTypeHash(1954118413118190521uL)]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	public struct PhysicsModelCollisionLayerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		[RecRoom.DataLayer.Field(1)]
		[Config(null, 0)]
		[RecRoom.DataLayer.Default(PAAKCKFKCBH.IsDynamicEnvironment)]
		public PAAKCKFKCBH collisionLayer;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class GDAEFLGOHKI
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public enum DDLEJAMANPD
	{
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		Dynamic,
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		Static,
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		Enemy,
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		Vehicle
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public enum KILBBBFLFBP
	{
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		Environmental,
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		IgnoreStaticGeometry,
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		IgnoreOtherDynamic,
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		IgnorePlayers,
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		IgnoreMost,
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		Projectile
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x78B6E30", Offset = "0x78B5830", VA = "0x1878B6E30")]
	public static (DDLEJAMANPD, KILBBBFLFBP) NGJJAKBBELC(this PAAKCKFKCBH HKKKDLOOHLD)
	{
		return default((DDLEJAMANPD, KILBBBFLFBP));
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[RecRoom.DataLayer.NetworkComponent(4, false)]
	[ConfigGroup("Physics", 0)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(16462677563651546047uL)]
	[RecRoom.DataLayer.RRGuid("F63AA9EA-6191-4DE9-BB18-1F049F432124")]
	public struct PhysicsModelFlagsData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		[RecRoom.DataLayer.Default(ECGPIELDBBK.DEFAULT)]
		[Config(null, 0)]
		[RecRoom.DataLayer.Field(1)]
		public ECGPIELDBBK flags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[ConfigGroup("Physics", 0)]
	[TypeManager.ForcedStableTypeHash(1094837642118998916uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.StableTypeHash(1094837642118998916uL, 0u)]
	[RecRoom.DataLayer.RRGuid("B6D08147-6AEA-4270-BDC4-8CF68662318D")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct PhysicsModelMassOverrideData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default(0f)]
		[Config(null, 0)]
		public float mass;
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[RecRoom.DataLayer.RRGuid("D732BC3D-4F8D-4FDE-BDB2-88C095D973C2")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[CompilerGenerated]
	[RecRoom.DataLayer.StableTypeHash(1537567323754185605uL, 0u)]
	[TypeManager.ForcedStableTypeHash(1537567323754185605uL)]
	public struct CostumePieceParentCostumeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public Entity parentCostume;
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[RecRoom.DataLayer.StableTypeHash(5115014870530256079uL, 0u)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[CompilerGenerated]
	[RecRoom.DataLayer.RRGuid("36A2D516-8596-4794-BEAE-40BECA68C798")]
	[TypeManager.ForcedStableTypeHash(5115014870530256079uL)]
	public struct CostumePieceSlotIndexData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public int slotIndex;
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[TypeManager.ForcedStableTypeHash(10518841812724430444uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("17799917-98EE-4D9A-A8D1-B0BE5F7316E3")]
	public struct InventionIdData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		[RecRoom.DataLayer.Default(0L)]
		[RecRoom.DataLayer.Field(1)]
		public long inventionId;

		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public const long INVALID_INVENTION_ID = 0L;

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0xC12D40", Offset = "0xC11740", VA = "0x180C12D40")]
		public static InventionIdData MEHFEEABIDG(long value)
		{
			return default(InventionIdData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x78B7350", Offset = "0x78B5D50", VA = "0x1878B7350")]
		public readonly bool BOANIJNAGFO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x761E730", Offset = "0x761D130", VA = "0x18761E730")]
		public static bool BOANIJNAGFO(long inventionId)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	[RecRoom.DataLayer.TombstonedFields(new int[] { 1 })]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	[RecRoom.DataLayer.RRGuid("629F0A56-C478-4353-BBDA-8A8BB5FEE478")]
	[TypeManager.ForcedStableTypeHash(14338988155392421373uL)]
	public struct InventionInstanceIdData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(2)]
		public NetworkGuid instanceId;

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x1136330", Offset = "0x1134D30", VA = "0x181136330")]
		public static InventionInstanceIdData MEHFEEABIDG(Guid value)
		{
			return default(InventionInstanceIdData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[TypeManager.ForcedStableTypeHash(7796256876318585598uL)]
	[RecRoom.DataLayer.RRGuid("5D26C8C6-7B5E-481E-B31E-6F30BE69D3C9")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[CompilerGenerated]
	public struct DesyncEntityReferenceData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public Entity entity;
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[TypeManager.ForcedStableTypeHash(3111430309403391054uL)]
	[RecRoom.DataLayer.RRGuid("AFCA5CDE-FE11-4D4A-BBC6-32EE1D254891")]
	public struct DesyncNetworkEntityBackReferenceData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public Entity entity;
	}
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("F1D14C4E-5388-4D7C-B641-5E79453B80AB")]
	[SerializationOnly]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(3936130774074738641uL)]
	public struct DesyncNetworkComponentsData : IBufferElementData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public ulong stableTypeHash;
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[RecRoom.DataLayer.StableTypeHash(12111354511484844847uL, 0u)]
	[RuntimeOnly]
	[CompilerGenerated]
	[RecRoom.DataLayer.RRGuid("A3B27452-BD6C-43B2-BAFF-CF885EB1608B")]
	[TypeManager.ForcedStableTypeHash(12111354511484844847uL)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct ParentData : IComponentData, BOAGFLLOLPF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public Entity parent;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0xC9BA50", Offset = "0xC9A450", VA = "0x180C9BA50", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xE68EE0", Offset = "0xE678E0", VA = "0x180E68EE0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xE68EE0", Offset = "0xE678E0", VA = "0x180E68EE0")]
		public ParentData(Entity parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0xC12D40", Offset = "0xC11740", VA = "0x180C12D40")]
		public static implicit operator ParentData(Entity entity)
		{
			return default(ParentData);
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004A")]
public struct GNCCNGBPCAG : IComponentData
{
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("c886150a-7231-4cc5-a2b2-f222500e6960")]
	[CompilerGenerated]
	[RecRoom.DataLayer.StableTypeHash(1950029632769634832uL, 0u)]
	[TypeManager.ForcedStableTypeHash(1950029632769634832uL)]
	public struct SiblingSortOrderData : IEquatable<SiblingSortOrderData>, IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public BBOGLCEBAKD order;

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0xC12D40", Offset = "0xC11740", VA = "0x180C12D40")]
		public static SiblingSortOrderData MEHFEEABIDG(BBOGLCEBAKD value)
		{
			return default(SiblingSortOrderData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x78B5240", Offset = "0x78B3C40", VA = "0x1878B5240", Slot = "4")]
		public bool Equals(SiblingSortOrderData other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(6217116203744017593uL)]
	[RecRoom.DataLayer.RRGuid("46CEA601-8AA7-423D-B1EA-EEABAE73413F")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct InteractionFilterAllTagsData : IComponentData, BOAGFLLOLPF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public Entity allTags;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0xC9BA50", Offset = "0xC9A450", VA = "0x180C9BA50", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0xE68EE0", Offset = "0xE678E0", VA = "0x180E68EE0", Slot = "5")]
			set
			{
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[TypeManager.ForcedStableTypeHash(6215026851838101933uL)]
	[RecRoom.DataLayer.RRGuid("49CEFD0F-3A38-4A9B-835E-10B4C2D08392")]
	[CompilerGenerated]
	public struct InteractionFilterAnyTagsData : IComponentData, BOAGFLLOLPF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public Entity anyTags;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0xC9BA50", Offset = "0xC9A450", VA = "0x180C9BA50", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0xE68EE0", Offset = "0xE678E0", VA = "0x180E68EE0", Slot = "5")]
			set
			{
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[TypeManager.ForcedStableTypeHash(6780642047612598977uL)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("11CE457F-4366-4AAD-B7E3-28D82B4FAFCF")]
	[CompilerGenerated]
	public struct InteractionFilterEnabledData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default(KDOFINIJEKG.Disabled)]
		public KDOFINIJEKG filterMode;
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[TypeManager.ForcedStableTypeHash(6642820932987006861uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.RRGuid("F7789094-7D82-4D27-B805-2CC1B8C0A538")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct InteractionFilterEntityRefData : IComponentData, BOAGFLLOLPF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public Entity filterEntity;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0xC9BA50", Offset = "0xC9A450", VA = "0x180C9BA50", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0xE68EE0", Offset = "0xE678E0", VA = "0x180E68EE0", Slot = "5")]
			set
			{
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[TypeManager.ForcedStableTypeHash(15467295871228743847uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.RRGuid("C7E95AF7-DB7D-4432-8DAA-8F36EC6C4308")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct InteractionFilterNoneTagsData : IComponentData, BOAGFLLOLPF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public Entity noneTags;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0xC9BA50", Offset = "0xC9A450", VA = "0x180C9BA50", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0xE68EE0", Offset = "0xE678E0", VA = "0x180E68EE0", Slot = "5")]
			set
			{
			}
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[TypeManager.ForcedStableTypeHash(15012400804589552708uL)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.StableTypeHash(15012400804589552708uL, 0u)]
	[CompilerGenerated]
	[RecRoom.DataLayer.RRGuid("007F8815-C87C-4E6B-BC56-3BA0C4888E3D")]
	public struct OverrideObjectNetworkIdData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public uint networkIdBits;
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("30228348-77DF-48F6-B2EF-B0883D3E10CA")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(4540375434353162791uL)]
	public struct MakerPenHeldData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public bool makerPenHeld;
	}
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[RecRoom.DataLayer.NetworkComponent(6, false)]
	[RecRoom.DataLayer.RRGuid("FB9853D6-6231-43FD-A754-00105DC30880")]
	[TypeManager.ForcedStableTypeHash(8459715919607487693uL)]
	[ConfigGroup("Object", 0)]
	[CompilerGenerated]
	public struct ObjectPolicyData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		[RecRoom.DataLayer.Field(2)]
		[RecRoom.DataLayer.Default("new ScaleRestriction(1,1)")]
		public KPLMGPNDEAI scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		[Config(null, 0)]
		[RecRoom.DataLayer.Default("ObjectPolicyUserConfigurableFlags.DEFAULT")]
		[RecRoom.DataLayer.Field(3)]
		public HLDBNBPNCCB userConfigurableFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		[RecRoom.DataLayer.Field(4)]
		[RecRoom.DataLayer.Default(PPEOEAGKAEB.Default)]
		[Config(null, 0)]
		public PPEOEAGKAEB circuitsTransformBehavior;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default("ObjectPolicyEnumFlags.Default")]
		public CFBDDMMBAGN flags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[TypeManager.ForcedStableTypeHash(2965180940795077803uL)]
	[SerializationOnly]
	[RecRoom.DataLayer.RRGuid("01AEEF22-2473-4505-A473-0BBF009690B3")]
	[CompilerGenerated]
	public struct RemovedNetworkComponentsBuffer : IBufferElementData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public ulong stableTypeHash;
	}
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[RecRoom.DataLayer.StableTypeHash(17708500325183871236uL, 0u)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("617A903E-C2C2-467C-A138-287FDB487645")]
	[TypeManager.ForcedStableTypeHash(17708500325183871236uL)]
	[CompilerGenerated]
	public struct PlayerScopeData : IComponentData, BOAGFLLOLPF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public Entity playerScope;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public Entity Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0xC9BA50", Offset = "0xC9A450", VA = "0x180C9BA50", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0xE68EE0", Offset = "0xE678E0", VA = "0x180E68EE0", Slot = "5")]
			set
			{
			}
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0xC12D40", Offset = "0xC11740", VA = "0x180C12D40")]
		public static PlayerScopeData MEHFEEABIDG(Entity entity)
		{
			return default(PlayerScopeData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[TypeManager.ForcedStableTypeHash(16642773407304133105uL)]
	[CompilerGenerated]
	[ConfigGroup("Physics", 0)]
	[RecRoom.DataLayer.StableTypeHash(16642773407304133105uL, 0u)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("F945B699-C9E5-4634-9F64-831484F4F3BD")]
	public struct PhysicsMaterialData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default(10f)]
		[Config(null, 0)]
		public float density;
	}
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	[RecRoom.DataLayer.RRGuid("A2E0AF0F-C284-47E6-9535-A67A29BF5730")]
	[RecRoom.DataLayer.StableTypeHash(10537432342869025182uL, 0u)]
	[TypeManager.ForcedStableTypeHash(10537432342869025182uL)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct ShapeConfigData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default(FFELHMGLKAD.None)]
		public FFELHMGLKAD flags;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool DynamicUVProjection
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x6CD32C0", Offset = "0x6CD1CC0", VA = "0x186CD32C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool PreventInvertedCreation
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x6CD32D0", Offset = "0x6CD1CD0", VA = "0x186CD32D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public bool NewBendLogic
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x78B8DA0", Offset = "0x78B77A0", VA = "0x1878B8DA0")]
			get
			{
				return default(bool);
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[RecRoom.DataLayer.StableTypeHash(10917729582819845312uL, 0u)]
	[TypeManager.ForcedStableTypeHash(10917729582819845312uL)]
	[RecRoom.DataLayer.RRGuid("5C706BF1-9D50-456A-B974-521E8E2CC660")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[CompilerGenerated]
	public struct ShapeTypeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public CPEEJIKFAAE shapeType;
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[RecRoom.DataLayer.RRGuid("36418781-DB47-4DE7-A138-CC88D1D795C0")]
	[RecRoom.DataLayer.StableTypeHash(5298506180484533559uL, 0u)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(5298506180484533559uL)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct SplinePointOrderData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public BBOGLCEBAKD order;

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0xC12D40", Offset = "0xC11740", VA = "0x180C12D40")]
		public static SplinePointOrderData MEHFEEABIDG(BBOGLCEBAKD value)
		{
			return default(SplinePointOrderData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(16368389834000856208uL)]
	[RecRoom.DataLayer.StableTypeHash(16368389834000856208uL, 0u)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("FCEE3BCD-9C10-4BF4-954A-0DCFE8810227")]
	public struct SplinePointParentData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public Entity spline;
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[TypeManager.ForcedStableTypeHash(18095612727592564636uL)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("5A6D38A4-1A58-4EB4-9C1B-06ADA0D44AFA")]
	[RecRoom.DataLayer.StableTypeHash(18095612727592564636uL, 0u)]
	[CompilerGenerated]
	public struct SplinePointPositionData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public float3 localPosition;
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	[RecRoom.DataLayer.StableTypeHash(1429513518619209486uL, 0u)]
	[RecRoom.DataLayer.RRGuid("433F66B6-CC1C-4A8A-BF73-2B797440A8DB")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[TypeManager.ForcedStableTypeHash(1429513518619209486uL)]
	public struct SplinePointRotationData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default("new quaternion(0, 0, 0, 1f)")]
		public quaternion localRotation;
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	[RecRoom.DataLayer.RRGuid("04CA3CCE-F121-4B5B-BC56-FE8E9C77F0F4")]
	[RecRoom.DataLayer.StableTypeHash(1238044349990854547uL, 0u)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[TypeManager.ForcedStableTypeHash(1238044349990854547uL)]
	public struct SplinePointScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default("new float3(1)")]
		public float3 localScale;
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("E0610986-0F8F-494A-8C6E-8A2D2491B088")]
	[RecRoom.DataLayer.StableTypeHash(4657247877648983868uL, 0u)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(4657247877648983868uL)]
	public struct SplineShapeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public JPHEOFPJKHK parameters;
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[RecRoom.DataLayer.RRGuid("73C344D9-D535-4753-9D9A-B6DEDE4079B0")]
	[RecRoom.DataLayer.StableTypeHash(12332323170023439017uL, 0u)]
	[RecRoom.DataLayer.TombstonedFields(new int[] { 1 })]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(12332323170023439017uL)]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	public struct OMShapeContainerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		[RecRoom.DataLayer.Default(true)]
		[RecRoom.DataLayer.Field(2)]
		public bool canModifyWithCircuits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		[RecRoom.DataLayer.Field(3)]
		[RecRoom.DataLayer.Default(true)]
		public bool optimizedCollidersEnabled;
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[TypeManager.ForcedStableTypeHash(17673274643717888315uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.RRGuid("2B5C4208-9113-4F65-B3A6-18EAE1FF3937")]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	public struct SerializedDataLayerVersionData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public int version;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
[Flags]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.Range(EBEKHIBDNAC.MIN, EBEKHIBDNAC.ALL)]
[RecRoom.DataLayer.RRGuid("CC657074-87FD-47F7-A7B0-F5CCE922A9D0")]
public enum EBEKHIBDNAC
{
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	IsAllowed = 1,
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	UseDefaultVisualEffects = 2,
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	DEFAULT = 2,
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	ALL = 3,
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	MAX = 3
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[CompilerGenerated]
	[RecRoom.DataLayer.RRGuid("34BA53CB-16FB-45DB-AA25-293CE7C8DAE4")]
	[TypeManager.ForcedStableTypeHash(5328722791392374178uL)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct ToolCleanupSettingsData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		[RecRoom.DataLayer.Default(15f)]
		[RecRoom.DataLayer.Field(1)]
		public float delay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		[RecRoom.DataLayer.Default(EBEKHIBDNAC.UseDefaultVisualEffects)]
		[RecRoom.DataLayer.Field(2)]
		public EBEKHIBDNAC toolCleanupFlags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	[TypeManager.ForcedStableTypeHash(13768238190614302474uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.TombstonedFields(new int[] { 2, 3 })]
	[RecRoom.DataLayer.RRGuid("48C72ABE-383D-45C6-9610-773F2B4F84C6")]
	public struct ToolCleanupStatusData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public float cleanupStartTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		[RecRoom.DataLayer.Field(4)]
		[RecRoom.DataLayer.Default]
		public DDIJEGGEFPO statusFlags;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.RRGuid("E63050BA-D087-4027-99F8-4AFDEA229CD8")]
[RecRoom.DataLayer.Range(DDIJEGGEFPO.None, DDIJEGGEFPO.ALL)]
[Flags]
public enum DDIJEGGEFPO
{
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	ForceCleanup = 1,
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	CleanupDone = 2,
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	CleanupPaused = 4,
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	ALL = 7,
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	MAX = 7
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[TypeManager.ForcedStableTypeHash(463077377357487319uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.RRGuid("021E8703-AAFD-4965-8C38-FF86663126D2")]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	public struct LocalDeformableScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default("new float3(1)")]
		public float3 localDeformationScale;

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0xE49760", Offset = "0xE48160", VA = "0x180E49760")]
		public LocalDeformableScaleData(float3 scale)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[TypeManager.ForcedStableTypeHash(1369925932270831712uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("38AA9F1D-FD16-4B56-917C-3341D0EB1DF2")]
	[RecRoom.DataLayer.StableTypeHash(1369925932270831712uL, 0u)]
	public struct LocalPoseData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		[RecRoom.DataLayer.Default("new quaternion(0,0,0,1)")]
		[RecRoom.DataLayer.Field(1)]
		public quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		[RecRoom.DataLayer.Field(2)]
		[RecRoom.DataLayer.Default]
		public float3 localPosition;

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x4EA0040", Offset = "0x4E9EA40", VA = "0x184EA0040")]
		public LocalPoseData(quaternion localRotation, float3 localPosition)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x78B4BF0", Offset = "0x78B35F0", VA = "0x1878B4BF0")]
		public static RigidTransform MEHFEEABIDG(LocalPoseData poseData)
		{
			return default(RigidTransform);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x78B4BF0", Offset = "0x78B35F0", VA = "0x1878B4BF0")]
		public static LocalPoseData MEHFEEABIDG(RigidTransform pose)
		{
			return default(LocalPoseData);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public static class BBOEJOCBMPA
{
	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x78B4DA0", Offset = "0x78B37A0", VA = "0x1878B4DA0")]
	public static LocalPoseData FANDGPKDFJD([In] this RigidTransform PPJFMHBDGNA)
	{
		return default(LocalPoseData);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x78B4DD0", Offset = "0x78B37D0", VA = "0x1878B4DD0")]
	public static RigidTransform IBBIBMCIEBB([In] this LocalPoseData PPJFMHBDGNA)
	{
		return default(RigidTransform);
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[TypeManager.ForcedStableTypeHash(2720902521635056246uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.StableTypeHash(2720902521635056246uL, 0u)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("0E9FADE9-751A-4A53-B455-4F8EA675754D")]
	public struct LocalUniformScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default(1f)]
		public float localUniformScale;
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("F01774C0-98E7-491E-AAA5-85B64AFFA182")]
	[RecRoom.DataLayer.StableTypeHash(5730545663584378555uL, 0u)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(5730545663584378555uL)]
	public struct TransformFlagsData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public OLNPFJCDOCE transformHint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		[RecRoom.DataLayer.Field(2)]
		[RecRoom.DataLayer.Default]
		public DJPDLJCIGFM transformPriority;
	}
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[RecRoom.DataLayer.DoNotGenerateComponentProperties]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	[RecRoom.DataLayer.RRGuid("392BF0C9-F464-491A-8725-E4B5E5C4ECD4")]
	[TypeManager.ForcedStableTypeHash(12583036596830542024uL)]
	[CompilerGenerated]
	public struct RRObjectPrefabData : ISharedComponentData, IEquatable<RRObjectPrefabData>, IComparable<RRObjectPrefabData>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public KPBBJPOJBPM prefabType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		[RecRoom.DataLayer.Field(2)]
		[RecRoom.DataLayer.Default]
		public Guid prefabGuid;

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x78B8C90", Offset = "0x78B7690", VA = "0x1878B8C90")]
		public RRObjectPrefabData(Guid prefabGuid, KPBBJPOJBPM prefabType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x78B8B90", Offset = "0x78B7590", VA = "0x1878B8B90", Slot = "4")]
		public readonly bool Equals(RRObjectPrefabData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x78B8AD0", Offset = "0x78B74D0", VA = "0x1878B8AD0", Slot = "0")]
		public override readonly bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x78B8CA0", Offset = "0x78B76A0", VA = "0x1878B8CA0")]
		public static bool operator ==(RRObjectPrefabData a, RRObjectPrefabData b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x78B75E0", Offset = "0x78B5FE0", VA = "0x1878B75E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x78B73F0", Offset = "0x78B5DF0", VA = "0x1878B73F0", Slot = "5")]
		public readonly int CompareTo(RRObjectPrefabData other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x78B8BF0", Offset = "0x78B75F0", VA = "0x1878B8BF0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("FF90B503-A0B5-4B3D-BACF-046FA1456FBD")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(17550159503907726442uL)]
	public struct ReferenceGroupKindData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public PDPDCPPPIIG kind;
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("2C78EEBE-6DD9-44FF-A70D-6C2EE9BB8FB3")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(18363292822319307914uL)]
	public struct ReferenceGroupOwnerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public Entity owner;
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[TypeManager.ForcedStableTypeHash(11947588904347318594uL)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[CompilerGenerated]
	[RecRoom.DataLayer.RRGuid("177498E9-83A6-4C2E-A8C1-B1951B47E74D")]
	public struct ReferenceGroupReferenceBuffer : IBufferElementData, BOAGFLLOLPF, IEquatable<ReferenceGroupReferenceBuffer>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public Entity reference;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public Entity Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0xC9BA50", Offset = "0xC9A450", VA = "0x180C9BA50", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0xE68EE0", Offset = "0xE678E0", VA = "0x180E68EE0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x78B8D90", Offset = "0x78B7790", VA = "0x1878B8D90", Slot = "6")]
		public bool Equals(ReferenceGroupReferenceBuffer other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x78B8D00", Offset = "0x78B7700", VA = "0x1878B8D00", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x9F9640", Offset = "0x9F8040", VA = "0x1809F9640", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006E")]
public struct DFAKCMEKIBJ : IEqualityComparer<ReferenceGroupReferenceBuffer>
{
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	public static DFAKCMEKIBJ JKECEEFIAPF;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x78B6030", Offset = "0x78B4A30", VA = "0x1878B6030", Slot = "4")]
	public bool Equals(ReferenceGroupReferenceBuffer CJBFFOKBLHB, ReferenceGroupReferenceBuffer CNBLFOFLDDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0xD2D4E0", Offset = "0xD2BEE0", VA = "0x180D2D4E0", Slot = "5")]
	public int GetHashCode(ReferenceGroupReferenceBuffer OIIGDBLKEDN)
	{
		return default(int);
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[InternalBufferCapacity(0)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("DE12A401-BD29-4B00-A629-7EFBECEDCFDF")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(17466046755328781668uL)]
	public struct AuthoredUserTagReferenceBuffer : ADOCHFEMGHF, IBufferElementData, BOAGFLLOLPF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public Entity Child;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0xC9BA50", Offset = "0xC9A450", VA = "0x180C9BA50", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0xE68EE0", Offset = "0xE678E0", VA = "0x180E68EE0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0xE68EE0", Offset = "0xE678E0", VA = "0x180E68EE0")]
		public AuthoredUserTagReferenceBuffer(Entity entity)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0xC12D40", Offset = "0xC11740", VA = "0x180C12D40")]
		public static AuthoredUserTagReferenceBuffer MEHFEEABIDG(Entity entity)
		{
			return default(AuthoredUserTagReferenceBuffer);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public interface ADOCHFEMGHF : IBufferElementData, BOAGFLLOLPF
{
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	[TypeManager.ForcedStableTypeHash(12148147190301245780uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.RRGuid("00B7CB5E-4C0C-4D2C-AC95-78529EE58768")]
	public struct PersistentUserTagData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public FixedList32Bytes<int> tags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		[RecRoom.DataLayer.Default(false)]
		[RecRoom.DataLayer.Field(2)]
		public bool initalizedDefaults;
	}
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[CompilerGenerated]
	[SwatchPrimaryKey]
	[RecRoom.DataLayer.StableTypeHash(1859693175312uL, 0u)]
	[TypeManager.ForcedStableTypeHash(1859693175312uL)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("80D85A55-B2F6-4860-A851-62973DC10940")]
	public struct UserTagNameData : IComponentData, IEquatable<UserTagNameData>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public FixedString32Bytes Value;

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x78B8ED0", Offset = "0x78B78D0", VA = "0x1878B8ED0")]
		public UserTagNameData(string value)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x78B8E90", Offset = "0x78B7890", VA = "0x1878B8E90")]
		public static UserTagNameData MEHFEEABIDG(string value)
		{
			return default(UserTagNameData);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x78B8DB0", Offset = "0x78B77B0", VA = "0x1878B8DB0", Slot = "4")]
		public bool Equals(UserTagNameData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x78B8DE0", Offset = "0x78B77E0", VA = "0x1878B8DE0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x78B8E80", Offset = "0x78B7880", VA = "0x1878B8E80", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	[RuntimeOnly]
	[InternalBufferCapacity(0)]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[TypeManager.ForcedStableTypeHash(2039749658960193818uL)]
	[RecRoom.DataLayer.RRGuid("1E609F72-38C4-433D-BB17-B718F89DF446")]
	public struct UserTagReferenceBuffer : ADOCHFEMGHF, IBufferElementData, BOAGFLLOLPF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public Entity Child;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0xC9BA50", Offset = "0xC9A450", VA = "0x180C9BA50", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0xE68EE0", Offset = "0xE678E0", VA = "0x180E68EE0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0xE68EE0", Offset = "0xE678E0", VA = "0x180E68EE0")]
		public UserTagReferenceBuffer(Entity entity)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0xC12D40", Offset = "0xC11740", VA = "0x180C12D40")]
		public static UserTagReferenceBuffer MEHFEEABIDG(Entity entity)
		{
			return default(UserTagReferenceBuffer);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[ConfigGroup("Visual", 0)]
	[CanDesync]
	[RecRoom.DataLayer.StableTypeHash(1591066774816564574uL, 0u)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[TypeManager.ForcedStableTypeHash(1591066774816564574uL)]
	[RecRoom.DataLayer.RRGuid("C36DDF08-CA52-4E33-8078-2F6E915D4FDA")]
	[CompilerGenerated]
	public struct StandardRenderableVisualData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		[RecRoom.DataLayer.Default]
		[Config(null, 0)]
		[RecRoom.DataLayer.Field(1)]
		public EJODAALJJDB color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		[Config(null, 0)]
		[RecRoom.DataLayer.Field(2)]
		[RecRoom.DataLayer.Default]
		public IHJHIPFBKPL material;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		[RecRoom.DataLayer.Field(3)]
		[RecRoom.DataLayer.Default]
		[Config(null, 0)]
		public float uvScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		[RecRoom.DataLayer.Field(4)]
		[RecRoom.DataLayer.Default]
		[Config(null, 0)]
		public float3 uvOffset;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.Range(PPEOEAGKAEB.NONE, PPEOEAGKAEB.COUNT)]
[RecRoom.DataLayer.RRGuid("6B598497-D68A-4CC9-9D41-09EF6B966499")]
public enum PPEOEAGKAEB
{
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	NONE = 0,
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	[Config("Default (can transform roots, children are static)", 0)]
	Default = 1,
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	[Config("Can Transform (chips like SetPosition can modify)", 0)]
	CircuitsCanTransform = 2,
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	[Config("Always Static (chips cannot modify transform)", 0)]
	AlwaysStatic = 3,
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	COUNT = 4,
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	MAX = 4
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
[RecRoom.DataLayer.RRGuid("17517E1A-CF1A-48C9-B6A5-F9E42C1B9E96")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.Range(0, 4)]
public enum JBHNOMONDJA
{
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	Box = 1,
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	Sphere = 2,
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	Capsule = 3,
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	Mesh = 4,
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	COUNT = 5,
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	MAX = 4
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
[Flags]
[RecRoom.DataLayer.RRGuid("A13F5102-9259-42B9-B782-BB7CC33A0C4F")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.Range(ANFLFEGLFCA.NONE, ANFLFEGLFCA.ALL)]
public enum ANFLFEGLFCA
{
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	NONE = 0,
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	Object = 1,
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	Player = 2,
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	Projectile = 4,
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	Vehicle = 8,
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	ALL = 0xF
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
[RecRoom.DataLayer.Range(0, 127)]
[RecRoom.DataLayer.RRGuid("F843A776-E042-43B7-8167-0C7A421062F8")]
[RecRoom.DataLayer.NetworkEnum(2, false)]
public enum PAAKCKFKCBH : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	[@Tooltip("Indicating it can be walked on and moved")]
	[Config("Dynamic (Environment)", 0)]
	IsDynamicEnvironment = 0,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	[Config("Dynamic", -1)]
	IsDynamic = 10,
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	[Config("Dynamic (Ignore Static Geometry)", 0)]
	IsDynamicIgnoreStaticGeometry = 11,
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	[Config("Dynamic (Ignore Other Dynamic)", 0)]
	IsDynamicIgnoreOtherDynamic = 12,
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	[Config("Dynamic (Ignore Players)", 0)]
	IsDynamicIgnorePlayers = 13,
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	[Config("Dynamic (Ignore Most)", 0)]
	IsDynamicIgnoreMost = 14,
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	[Config("Enemy Collision", 0)]
	IsEnemyCollision = 30,
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	[Config("Enemy Projectile", 0)]
	IsEnemyProjectile = 31,
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	[Config("Vehicle Physics", 0)]
	IsVehicleCollision = 40,
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	[ConfigIgnore]
	STATIC = 100,
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	[ConfigIgnore]
	DECORATION = 101,
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	MAX = 127
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
[RecRoom.DataLayer.NetworkEnum(2, false)]
[RecRoom.DataLayer.RRGuid("9ADF7A0D-D808-48A7-BFCB-3272FB5D8A52")]
[RecRoom.DataLayer.Range(EOOPGOCNLLN.Off, EOOPGOCNLLN.COUNT)]
public enum EOOPGOCNLLN : byte
{
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	Off = 0,
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	Children = 1,
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	Hull = 2,
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	COUNT = 3,
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	MAX = 2
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.RRGuid("3B156405-5769-4DB2-87EA-2B846AC4E584")]
[RecRoom.DataLayer.Range(0, 2)]
public enum CPEEJIKFAAE
{
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	Primitive = 1,
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	Spline = 2,
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	COUNT = 3,
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	MAX = 2
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
[RecRoom.DataLayer.NetworkEnum(2, false)]
[RecRoom.DataLayer.RRGuid("61EFE94A-235A-4281-B938-1A5BE32A18B1")]
[RecRoom.DataLayer.Range(FBKFJPCAJHI.Pivot, FBKFJPCAJHI.COUNT)]
public enum FBKFJPCAJHI : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	Pivot = 0,
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	Bounds = 1,
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	COUNT = 2,
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	MAX = 1
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
[RecRoom.DataLayer.RRGuid("c0973732-e735-44cd-9727-a9a79bad01e3")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.Range(KDOFINIJEKG.EnabledForRole, KDOFINIJEKG.Disabled)]
public enum KDOFINIJEKG : byte
{
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	EnabledForRole,
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	DisabledForRole,
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	Disabled
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
[RecRoom.DataLayer.Range(LBBNALJLICL.NavMeshGenerator, LBBNALJLICL.NavMeshBlocker)]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.RRGuid("7E7D5AA1-2EC9-488B-8AB2-703F13BCB8CF")]
public enum LBBNALJLICL
{
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	NavMeshGenerator = 0,
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	NavMeshIgnored = 1,
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	NavMeshBlocker = 2,
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	MAX = 2
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[RecRoom.DataLayer.RRGuid("7B493897-FE06-4FC8-AB72-8B7BF5A313D3")]
[Flags]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.Range(CFBDDMMBAGN.None, CFBDDMMBAGN.All)]
public enum CFBDDMMBAGN
{
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	All = 0x3FFF,
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	Default = 0x3FFF
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
[RecRoom.DataLayer.Range(0, NNNDPOOLJMK.COUNT)]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.RRGuid("4427686F-E636-4F43-91F7-6BC74DEC584E")]
public enum NNNDPOOLJMK
{
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	SupportsRotation,
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	SupportsDeformation,
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	SupportsScaling,
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	SupportsMirroring,
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	SupportsCloning,
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	SupportsRecoloring,
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	CanDestroy,
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	CanSaveIntoInventions,
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	SupportsRespawn,
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	SupportsMerging,
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	SupportsSplitting,
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	SupportsKeys,
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	CanEditWithMakerPen,
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	DEPRECATED_IsGrabbable,
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public static class IELCJDNEHDF
{
	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x78B7320", Offset = "0x78B5D20", VA = "0x1878B7320")]
	public static void PMHEFKOCJCJ(this CFBDDMMBAGN BNNEEGIINDP, NNNDPOOLJMK JKMFGIMABPP, bool AMLCJKDLNFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x78B7300", Offset = "0x78B5D00", VA = "0x1878B7300")]
	public static bool EPNOHNLDOLO(this CFBDDMMBAGN BNNEEGIINDP, NNNDPOOLJMK JKMFGIMABPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0xD43A30", Offset = "0xD42430", VA = "0x180D43A30")]
	public static CFBDDMMBAGN IEKHKCDFLCK(this NNNDPOOLJMK JKMFGIMABPP)
	{
		return default(CFBDDMMBAGN);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
[RecRoom.DataLayer.Range(HLDBNBPNCCB.NONE, HLDBNBPNCCB.COUNT)]
[Flags]
[RecRoom.DataLayer.NetworkEnum(2, false)]
[RecRoom.DataLayer.RRGuid("E3C51303-32F0-4EF4-8A66-C814E323653D")]
public enum HLDBNBPNCCB
{
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	NONE = 0,
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	IsFrozen = 1,
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	IsGrabbable = 2,
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	COUNT = 3,
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	ALL = 3,
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	DEFAULT = 0
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.Range(KPBBJPOJBPM.None, 8000)]
[RecRoom.DataLayer.RRGuid("777AD204-3AC0-41CE-BDC0-894C5821B3B9")]
public enum KPBBJPOJBPM
{
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	[Config("Container", 0)]
	Container = 1000,
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	[Config("Container", 0)]
	LegacyShapeContainer = 1001,
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	[Config("Container", 0)]
	CreationShapeContainer = 1002,
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	[Config("Container", 0)]
	CostumePieceShapeContainer = 1003,
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	[Config("Empty", 0)]
	Empty = 4000,
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	[Config("Legacy Box", 0)]
	Shape_Primitive_LegacyBox = 2000,
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	[Config("Sphere", 0)]
	Shape_Primitive_Sphere = 2001,
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	[Config("Cylinder", 0)]
	Shape_Primitive_Cylinder = 2002,
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	[Config("Legacy Wedge", 0)]
	Shape_Primitive_LegacyWedge = 2003,
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	[Config("Legacy Pyramid", 0)]
	Shape_Primitive_LegacyPyramid = 2004,
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	[Config("Trigger Volume Box", 0)]
	Shape_Primitive_TriggerVolumeBox = 2005,
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	[Config("Box", 0)]
	Shape_Primitive_Box = 2006,
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	[Config("Rounded Box", 0)]
	Shape_Primitive_RoundedBox = 2007,
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	[Config("Wedge", 0)]
	Shape_Primitive_Wedge = 2008,
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	[Config("Pyramid", 0)]
	Shape_Primitive_Pyramid = 2009,
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	[Config("Half Sphere", 0)]
	Shape_Primitive_HalfSphere = 2010,
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	[Config("Cone", 0)]
	Shape_Primitive_Cone = 2011,
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	[Config("Pipe", 0)]
	Shape_Primitive_Pipe = 2012,
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	[Config("Donut", 0)]
	Shape_Primitive_Donut = 2013,
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	[Config("Half Pipe", 0)]
	Shape_Primitive_HalfPipe = 2014,
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	[Config("Diamond", 0)]
	Shape_Primitive_Diamond = 2015,
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	[Config("Mound", 0)]
	Shape_Primitive_Mound = 2016,
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	[Config("Cube (Simple)", 0)]
	Shape_Primitive_ADVANCED_Cube = 2017,
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	[Config("Sphere (Simple)", 0)]
	Shape_Primitive_ADVANCED_Sphere = 2018,
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	[Config("Cylinder (Simple)", 0)]
	Shape_Primitive_ADVANCED_Cylinder = 2019,
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	[Config("Cone (Simple)", 0)]
	Shape_Primitive_ADVANCED_Cone = 2020,
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	[Config("Pyramid (Simple)", 0)]
	Shape_Primitive_ADVANCED_Pyramid = 2021,
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	[Config("Octagon (Simple)", 0)]
	Shape_Primitive_ADVANCED_Octagon = 2022,
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	[Config("Triangle (Simple)", 0)]
	Shape_Primitive_ADVANCED_Triangle = 2023,
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	[Config("Hexagon (Simple)", 0)]
	Shape_Primitive_ADVANCED_Hexagon = 2024,
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	[Config("Quarter Pipe", 0)]
	Shape_Primitive_ADVANCED_QuarterPipe = 2025,
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	[Config("Pentagon (Simple)", 0)]
	Shape_Primitive_ADVANCED_Pentagon = 2026,
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	[Config("Dodecahedron", 0)]
	Shape_Primitive_ADVANCED_Dodecahedron = 2027,
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	[Config("Icosahedron", 0)]
	Shape_Primitive_ADVANCED_Trihedron = 2028,
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	[Config("Octahedron", 0)]
	Shape_Primitive_ADVANCED_Octahedron = 2029,
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	[Config("Quarter Cylinder", 0)]
	Shape_Primitive_RR_QuarterCylinder = 2030,
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	[Config("Pentagon", 0)]
	Shape_Primitive_RR_Pentagon = 2031,
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	[Config("Quarter Sphere", 0)]
	Shape_Primitive_RR_QuarterSphere = 2032,
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	[Config("Wedge (Simple)", 0)]
	Shape_Primitive_ADVANCED_Wedge = 2033,
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	[Config("Hexagon", 0)]
	Shape_Primitive_RR_Hexagon = 2034,
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	[Config("Octagon", 0)]
	Shape_Primitive_RR_Octagon = 2035,
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	[Config("Triangle", 0)]
	Shape_Primitive_RR_Triangle = 2036,
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	[Config("Spline", 0)]
	Shape_Spline = 3000,
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	[Config("Container Pivot", 0)]
	Other_ContainerPivot = 6000,
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	[Config("Spine Point", 0)]
	Other_SplinePoint = 6001,
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	[Config("Reference Point", 0)]
	Other_ReferencePoint = 6002,
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	[Config("UserTags", 0)]
	Other_UserTag = 6003,
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	[Config("Reference Group", 0)]
	Other_ReferenceGroup = 6004,
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	[Config("Interaction Filter", 0)]
	Other_InteractionFilterTags = 6005,
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	[ConfigIgnore]
	Other_DesyncNetworkObject = 6006,
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	[ConfigIgnore]
	UNUSED2 = 5000,
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	[Config("Object", 0)]
	PrefabRootGameObject = 7000,
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	[Config("PrefabInternal", 0)]
	PrefabInternalGameObject = 7001,
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	[Config("Player", 0)]
	Player = 8000
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public static class GHJBFLJGCCI
{
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	[CompilerGenerated]
	private sealed class LJGGJNALBMB : IEnumerable<KPBBJPOJBPM>, IEnumerable, IEnumerator<KPBBJPOJBPM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		private KPBBJPOJBPM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private IEnumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		private KPBBJPOJBPM System.Collections.Generic.IEnumerator<RecRoom.DataLayer.ObjectPrefabType>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0xB16BF0", Offset = "0xB155F0", VA = "0x180B16BF0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(KPBBJPOJBPM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x78B7AB0", Offset = "0x78B64B0", VA = "0x1878B7AB0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x11D73F0", Offset = "0x11D5DF0", VA = "0x1811D73F0")]
		[DebuggerHidden]
		public LJGGJNALBMB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x78B7B00", Offset = "0x78B6500", VA = "0x1878B7B00", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x78B7750", Offset = "0x78B6150", VA = "0x1878B7750", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x78B76F0", Offset = "0x78B60F0", VA = "0x1878B76F0")]
		private void JKNFIIFCPDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x78B7A60", Offset = "0x78B6460", VA = "0x1878B7A60", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x78B79C0", Offset = "0x78B63C0", VA = "0x1878B79C0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<KPBBJPOJBPM> System.Collections.Generic.IEnumerable<RecRoom.DataLayer.ObjectPrefabType>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x78B79C0", Offset = "0x78B63C0", VA = "0x1878B79C0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[CompilerGenerated]
	private sealed class PLAEKICLMPF : IEnumerable<KPBBJPOJBPM>, IEnumerable, IEnumerator<KPBBJPOJBPM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		private KPBBJPOJBPM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		private KPBBJPOJBPM <last>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private KPBBJPOJBPM <i>5__3;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		private KPBBJPOJBPM System.Collections.Generic.IEnumerator<RecRoom.DataLayer.ObjectPrefabType>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0xB16BF0", Offset = "0xB155F0", VA = "0x180B16BF0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(KPBBJPOJBPM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x78B8900", Offset = "0x78B7300", VA = "0x1878B8900", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x11D73F0", Offset = "0x11D5DF0", VA = "0x1811D73F0")]
		[DebuggerHidden]
		public PLAEKICLMPF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x78B87B0", Offset = "0x78B71B0", VA = "0x1878B87B0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x78B88B0", Offset = "0x78B72B0", VA = "0x1878B88B0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x78B8810", Offset = "0x78B7210", VA = "0x1878B8810", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<KPBBJPOJBPM> System.Collections.Generic.IEnumerable<RecRoom.DataLayer.ObjectPrefabType>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x78B8810", Offset = "0x78B7210", VA = "0x1878B8810", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000086")]
	[CompilerGenerated]
	private sealed class BEKDPKBKPOL : IEnumerable<KPBBJPOJBPM>, IEnumerable, IEnumerator<KPBBJPOJBPM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		private KPBBJPOJBPM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private IEnumerator<KPBBJPOJBPM> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		private KPBBJPOJBPM System.Collections.Generic.IEnumerator<RecRoom.DataLayer.ObjectPrefabType>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0xB16BF0", Offset = "0xB155F0", VA = "0x180B16BF0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(KPBBJPOJBPM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x78B5950", Offset = "0x78B4350", VA = "0x1878B5950", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x11D73F0", Offset = "0x11D5DF0", VA = "0x1811D73F0")]
		[DebuggerHidden]
		public BEKDPKBKPOL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x78B59A0", Offset = "0x78B43A0", VA = "0x1878B59A0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x78B55C0", Offset = "0x78B3FC0", VA = "0x1878B55C0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x78B5570", Offset = "0x78B3F70", VA = "0x1878B5570")]
		private void JKNFIIFCPDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x78B5900", Offset = "0x78B4300", VA = "0x1878B5900", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x78B5860", Offset = "0x78B4260", VA = "0x1878B5860", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<KPBBJPOJBPM> System.Collections.Generic.IEnumerable<RecRoom.DataLayer.ObjectPrefabType>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x78B5860", Offset = "0x78B4260", VA = "0x1878B5860", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x78B7020", Offset = "0x78B5A20", VA = "0x1878B7020")]
	[IteratorStateMachine(typeof(LJGGJNALBMB))]
	public static IEnumerable<KPBBJPOJBPM> CLBMCENHBJI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x78B6FC0", Offset = "0x78B59C0", VA = "0x1878B6FC0")]
	[IteratorStateMachine(typeof(PLAEKICLMPF))]
	public static IEnumerable<KPBBJPOJBPM> AJFNLJBCBCK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x78B7080", Offset = "0x78B5A80", VA = "0x1878B7080")]
	[IteratorStateMachine(typeof(BEKDPKBKPOL))]
	public static IEnumerable<KPBBJPOJBPM> DMKJPKIBHJN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public static class LOCDABJBOOG
{
	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x78B7C10", Offset = "0x78B6610", VA = "0x1878B7C10")]
	public static bool MGGKMDJOBHH(this KPBBJPOJBPM OHCGINPDMEI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x78B7B60", Offset = "0x78B6560", VA = "0x1878B7B60")]
	public static bool CFOOJCMFFKA(this RRObjectPrefabData IMGIFEBFJBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x78B7B90", Offset = "0x78B6590", VA = "0x1878B7B90")]
	public static bool CFOOJCMFFKA(this KPBBJPOJBPM OHCGINPDMEI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x78B7BC0", Offset = "0x78B65C0", VA = "0x1878B7BC0")]
	public static PHMLPDLGIJG IELEMAGOOGE(this KPBBJPOJBPM NPLOBGMFJFK)
	{
		return default(PHMLPDLGIJG);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x78B7BE0", Offset = "0x78B65E0", VA = "0x1878B7BE0")]
	internal static AOMHOKJGNGH LPAAGJOHCEN(this PHMLPDLGIJG GKHIEBGMKJK)
	{
		return default(AOMHOKJGNGH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x78B7BF0", Offset = "0x78B65F0", VA = "0x1878B7BF0")]
	internal static AOMHOKJGNGH LPAAGJOHCEN(this KPBBJPOJBPM NPLOBGMFJFK)
	{
		return default(AOMHOKJGNGH);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
internal enum AOMHOKJGNGH
{
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	Container = 1000,
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	Empty = 4000,
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	Primitive = 2000,
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	Spline = 3000,
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	Other = 6000,
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	UNUSED2 = 5000,
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	GameObject = 7000,
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	Player = 8000
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
[RecRoom.DataLayer.RRGuid("A32413BC-21F3-4F7C-84B0-37724A854A67")]
[RecRoom.DataLayer.Range(0, 8)]
[RecRoom.DataLayer.NetworkEnum(1, false)]
public enum PHMLPDLGIJG
{
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	Container,
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	Primitive,
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	Spline,
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	Empty,
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	UNUSED2,
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	Other,
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	GameObject,
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	Player
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public static class DGLINGPFNOO
{
	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x78B6050", Offset = "0x78B4A50", VA = "0x1878B6050")]
	public static bool CJEIHIJNGLN(this PHMLPDLGIJG GKHIEBGMKJK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
[Flags]
[RecRoom.DataLayer.RRGuid("7A0D34B5-FFE5-4C21-BB0C-CB3EBA34C797")]
[RecRoom.DataLayer.Range(0, ECGPIELDBBK.ALL)]
[RecRoom.DataLayer.NetworkEnum(3, false)]
public enum ECGPIELDBBK : ushort
{
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	NONE = 0,
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	PhysicsEnabled = 1,
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	GravityEnabled = 2,
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	HasCustomMass = 4,
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	CollisionEvent = 0x40,
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	CanUse = 0x200,
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	CanClimb = 0x400,
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	CanWallRun = 0x800,
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	CanClamber = 0x1000,
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	CanTeleport = 0x2000,
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	SuppressCollision = 0x4000,
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	DEFAULT = 0x3800,
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	ALL = 0x7E47,
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	MAX = 0x7E47
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	[TypeManager.ForcedStableTypeHash(8060729269509364919uL)]
	[RecRoom.DataLayer.RRGuid("5D4503E7-6CC4-4938-8840-1B859C391878")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[CompilerGenerated]
	[RecRoom.DataLayer.StableTypeHash(8060729269509364919uL, 0u)]
	public struct PrimitiveShapeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public AHBNMJGLFPD shapeType;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
[RecRoom.DataLayer.Range(-1, 38)]
[RecRoom.DataLayer.RRGuid("517224CC-0A79-4FE9-B048-53C37955D823")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
public enum AHBNMJGLFPD
{
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	LegacyBox = 2,
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	RR_Sphere = 3,
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	RR_Cylinder = 4,
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	LEGACY_Wedge = 5,
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	LEGACY_Pyramid = 6,
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	LEGACY_TriggerVolumeBox = 7,
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	RR_Box = 8,
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	LEGACY_RoundedBox = 9,
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	RR_Wedge = 10,
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	RR_Pyramid = 11,
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	RR_HalfSphere = 12,
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	RR_Cone = 13,
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	RR_Pipe = 14,
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	RR_Donut = 15,
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	RR_HalfPipe = 16,
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	RR_Diamond = 17,
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	ADVANCED_Mound = 18,
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	ADVANCED_Cube = 19,
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	ADVANCED_Sphere = 20,
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	ADVANCED_Cylinder = 21,
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	ADVANCED_Cone = 22,
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	ADVANCED_Pyramid = 23,
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	ADVANCED_Octagon = 24,
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	ADVANCED_Triangle = 25,
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	ADVANCED_Hexagon = 26,
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	ADVANCED_QuarterPipe = 27,
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	ADVANCED_Pentagon = 28,
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	ADVANCED_Dodecahedron = 29,
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	ADVANCED_Trihedron = 30,
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	ADVANCED_Octahedron = 31,
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	RR_QuarterCylinder = 32,
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	RR_Pentagon = 33,
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	RR_QuarterSphere = 34,
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	ADVANCED_Wedge = 35,
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	RR_Hexagon = 36,
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	RR_Octagon = 37,
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	RR_Triangle = 38,
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	COUNT = 39,
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	MIN_VALUE = -1,
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	MAX_VALUE = 38
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
[RecRoom.DataLayer.RRGuid("3D27DF09-CAE2-4C3F-B808-03AD605F8E98")]
[RecRoom.DataLayer.Range(PDPDCPPPIIG.None, PDPDCPPPIIG.COUNT)]
[RecRoom.DataLayer.NetworkEnum(1, false)]
public enum PDPDCPPPIIG : byte
{
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	AnimationGroup = 1,
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	COUNT = 2,
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	MAX = 2
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.RRGuid("1829B7EA-C0EA-4E77-8EB2-BA23E995C860")]
[RecRoom.DataLayer.Range(0, 7)]
[Flags]
public enum FFELHMGLKAD
{
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	DynamicUVProjection = 1,
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	PreventInvertedCreation = 2,
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	NewBendLogic = 4,
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	All = 7,
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	MAX = 7
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.Range(0, 7)]
[Flags]
[RecRoom.DataLayer.RRGuid("CCB58F66-EF02-476E-820F-9D593E2C3DE5")]
public enum LKPMBDOIBEA
{
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	IsRibbon = 1,
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	RoundedTubes = 2,
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	OldStyleCaps = 4,
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	All = 7,
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	MAX = 7
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.RRGuid("72742F9B-D48E-4CED-B403-444201FFEE66")]
[RecRoom.DataLayer.Range(0, 1)]
[Flags]
public enum OLNPFJCDOCE
{
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	Static = 0,
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	Dynamic = 1,
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	All = 1
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
[RecRoom.DataLayer.Range(-2, 2)]
[RecRoom.DataLayer.RRGuid("C5BE1CDA-5EF5-4EBF-BC7E-3E3510C68A7F")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
public enum DJPDLJCIGFM
{
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	Frozen = -2,
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	Low = -1,
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	Normal = 0,
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	High = 1,
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	Realtime = 2,
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	Default = 0,
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	MIN = -2,
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	MAX = 2
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.Range(int.MinValue, int.MaxValue)]
[RecRoom.DataLayer.RRGuid("D6AFAFED-8BAA-4499-9696-9CBB716EF514")]
public enum EJODAALJJDB
{
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	Red = 0,
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	Orange = 1,
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	Yellow = 2,
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	LightGreen = 3,
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	Blue = 4,
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	LightBlue = 5,
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	Teal = 6,
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	Green = 7,
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	Purple = 8,
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	LightPink = 9,
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	Pink = 10,
	[Cpp2IlInjected.Token(Token = "0x4000207")]
	Brown = 11,
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	Tan = 12,
	[Cpp2IlInjected.Token(Token = "0x4000209")]
	White = 13,
	[Cpp2IlInjected.Token(Token = "0x400020A")]
	Grey = 14,
	[Cpp2IlInjected.Token(Token = "0x400020B")]
	DarkGrey = 15,
	[Cpp2IlInjected.Token(Token = "0x400020C")]
	DarkBrown = 16,
	[Cpp2IlInjected.Token(Token = "0x400020D")]
	LightBrown = 17,
	[Cpp2IlInjected.Token(Token = "0x400020E")]
	LightGrey = 18,
	[Cpp2IlInjected.Token(Token = "0x400020F")]
	Black = 19,
	[Cpp2IlInjected.Token(Token = "0x4000210")]
	DarkRed = 20,
	[Cpp2IlInjected.Token(Token = "0x4000211")]
	DarkOrange = 21,
	[Cpp2IlInjected.Token(Token = "0x4000212")]
	DarkYellow = 22,
	[Cpp2IlInjected.Token(Token = "0x4000213")]
	DarkGreen = 23,
	[Cpp2IlInjected.Token(Token = "0x4000214")]
	DarkTeal = 24,
	[Cpp2IlInjected.Token(Token = "0x4000215")]
	DarkBlue = 25,
	[Cpp2IlInjected.Token(Token = "0x4000216")]
	DarkPurple = 26,
	[Cpp2IlInjected.Token(Token = "0x4000217")]
	DarkPink = 27,
	[Cpp2IlInjected.Token(Token = "0x4000218")]
	LightRed = 28,
	[Cpp2IlInjected.Token(Token = "0x4000219")]
	LightOrange = 29,
	[Cpp2IlInjected.Token(Token = "0x400021A")]
	LightYellow = 30,
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	Cyan = 31,
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	LightPurple = 32,
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	DarkTan = 33,
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	NewColor1 = 34,
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	NewColor2 = 35,
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	NewColor3 = 36,
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	NewColor4 = 37,
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	NewColor5 = 38,
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	NewColor6 = 39,
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	NewColor7 = 40,
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	NewColor8 = 41,
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	NewColor9 = 42,
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	NewColor10 = 43,
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	NewColor11 = 44,
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	NewColor12 = 45,
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	NewColor13 = 46,
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	NewColor14 = 47,
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	NewColor15 = 48,
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	NewColor16 = 49,
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	NewColor17 = 50,
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	NewColor18 = 51,
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	NewColor19 = 52,
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	NewColor20 = 53,
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	NewColor21 = 54,
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	NewColor22 = 55,
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	NewColor23 = 56,
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	NewColor24 = 57,
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	NewColor25 = 58,
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	NewColor26 = 59,
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	NewColor27 = 60,
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	Default = 0
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.RRGuid("C57BE511-BA1A-4D83-BA58-303F34F4DE74")]
[RecRoom.DataLayer.Range(-1, 31)]
public enum IHJHIPFBKPL
{
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	Cardboard = 0,
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	Neon = 1,
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	Brick = 2,
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	Carpet = 3,
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	Dirt = 4,
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	Grass = 5,
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	MetalReflective = 6,
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	Concrete = 7,
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	Linoleum = 8,
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	Plaster = 9,
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	WoodLogs = 10,
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	WoodBoards = 11,
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	WoodGrain = 12,
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	WoodFloor = 13,
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	Sand = 14,
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	GlossyPlastic = 15,
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	Cloth = 16,
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	RubberFloor = 17,
	[Cpp2IlInjected.Token(Token = "0x400024E")]
	MetalFloorTread = 18,
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	PaintedBrick = 19,
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	Crashpad = 20,
	[Cpp2IlInjected.Token(Token = "0x4000251")]
	PaintedWood = 21,
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	GripTape = 22,
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	GalvanizedMetal = 23,
	[Cpp2IlInjected.Token(Token = "0x4000254")]
	ParticleBoard = 24,
	[Cpp2IlInjected.Token(Token = "0x4000255")]
	CheckeredFloor = 25,
	[Cpp2IlInjected.Token(Token = "0x4000256")]
	SparklyVinyl = 26,
	[Cpp2IlInjected.Token(Token = "0x4000257")]
	Gravel = 27,
	[Cpp2IlInjected.Token(Token = "0x4000258")]
	Rock = 28,
	[Cpp2IlInjected.Token(Token = "0x4000259")]
	Placeholder29 = 29,
	[Cpp2IlInjected.Token(Token = "0x400025A")]
	Placeholder30 = 30,
	[Cpp2IlInjected.Token(Token = "0x400025B")]
	Placeholder31 = 31,
	[Cpp2IlInjected.Token(Token = "0x400025C")]
	COUNT = 32,
	[Cpp2IlInjected.Token(Token = "0x400025D")]
	MIN = -1,
	[Cpp2IlInjected.Token(Token = "0x400025E")]
	MAX = 31,
	[Cpp2IlInjected.Token(Token = "0x400025F")]
	Default = 0
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
[RecRoom.DataLayer.NetworkInterface(1, false)]
[RecRoom.DataLayer.RRGuid("B23E7E5C-828C-4A29-9AB2-774DFC53D18E")]
public interface EGPDLOGKCHH : NPJGMIPCEEB
{
	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	[RecRoom.DataLayer.Field(1)]
	[RecRoom.DataLayer.Key("SBDScale")]
	[RecRoom.DataLayer.Default]
	[ProtoProp("PersistenceViewData.SandboxDeformationData.Deformation", typeof(GALCBOMIEOE))]
	[Set.Auth]
	float3 MOGENFAMANI
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action PLNPNNCDPKJ;
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
[RecRoom.DataLayer.NetworkStruct(1, false)]
[RecRoom.DataLayer.RRGuid("112F004A-C92F-4055-99F9-D430EC13FE3C")]
public struct BBOGLCEBAKD : IComparable<BBOGLCEBAKD>, IEquatable<BBOGLCEBAKD>
{
	[Cpp2IlInjected.Token(Token = "0x4000260")]
	public static readonly BBOGLCEBAKD KPJGFDDMHFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000261")]
	[RecRoom.DataLayer.Field(1)]
	public uint FALFPCNMKMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000262")]
	[RecRoom.DataLayer.Field(2)]
	public uint AKBLFNIJLGO;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	private readonly uint LCHIELBMEMC
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x78B5380", Offset = "0x78B3D80", VA = "0x1878B5380")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public readonly bool BFBBKCKIDFH
	{
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x78B51A0", Offset = "0x78B3BA0", VA = "0x1878B51A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x78B5490", Offset = "0x78B3E90", VA = "0x1878B5490")]
	public BBOGLCEBAKD(int FALFPCNMKMD, int ELOAJIJECCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x78B5490", Offset = "0x78B3E90", VA = "0x1878B5490")]
	public BBOGLCEBAKD(uint FALFPCNMKMD, uint ELOAJIJECCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x78B54F0", Offset = "0x78B3EF0", VA = "0x1878B54F0")]
	private BBOGLCEBAKD(uint FALFPCNMKMD, uint ELOAJIJECCE, bool OMHBKNDCBJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x78B5110", Offset = "0x78B3B10", VA = "0x1878B5110")]
	public BBOGLCEBAKD BNMACELIPML(int LMGBAALNFHC = 1)
	{
		return default(BBOGLCEBAKD);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x78B5310", Offset = "0x78B3D10", VA = "0x1878B5310")]
	public BBOGLCEBAKD MDGHLFCKOIG(int LMGBAALNFHC = 1)
	{
		return default(BBOGLCEBAKD);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x78B4E20", Offset = "0x78B3820", VA = "0x1878B4E20")]
	public static BBOGLCEBAKD BJAPAKLNACA(BBOGLCEBAKD AKJAPDOPIOF, BBOGLCEBAKD CPKHJEJFIJK)
	{
		return default(BBOGLCEBAKD);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x78B5260", Offset = "0x78B3C60", VA = "0x1878B5260")]
	private static ulong GEENAEKCPNP(ulong KEEADJCBJCP, ulong LKKBJAKGIGL)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x78B5180", Offset = "0x78B3B80", VA = "0x1878B5180", Slot = "4")]
	public int CompareTo(BBOGLCEBAKD OLKLGHOAKNE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x78B51B0", Offset = "0x78B3BB0", VA = "0x1878B51B0", Slot = "0")]
	public override bool Equals(object OIIGDBLKEDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x78B53B0", Offset = "0x78B3DB0", VA = "0x1878B53B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x78B5240", Offset = "0x78B3C40", VA = "0x1878B5240", Slot = "5")]
	public bool Equals(BBOGLCEBAKD OLKLGHOAKNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x78B52C0", Offset = "0x78B3CC0", VA = "0x1878B52C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x371CE80", Offset = "0x371B880", VA = "0x18371CE80")]
	public static bool HFGMMLFJJJB(BBOGLCEBAKD AKJAPDOPIOF, BBOGLCEBAKD CPKHJEJFIJK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x78B4E00", Offset = "0x78B3800", VA = "0x1878B4E00")]
	public static bool BDABLEIINAG(BBOGLCEBAKD AKJAPDOPIOF, BBOGLCEBAKD CPKHJEJFIJK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x78B5390", Offset = "0x78B3D90", VA = "0x1878B5390")]
	public static bool PLLNAFNBBJC(BBOGLCEBAKD AKJAPDOPIOF, BBOGLCEBAKD CPKHJEJFIJK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x78B52A0", Offset = "0x78B3CA0", VA = "0x1878B52A0")]
	public static bool GLGNIBMIBIL(BBOGLCEBAKD AKJAPDOPIOF, BBOGLCEBAKD CPKHJEJFIJK)
	{
		return default(bool);
	}
}
namespace RecRoom.DataLayer
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	[RecRoom.DataLayer.NetworkStruct(1, false)]
	[RecRoom.DataLayer.RRGuid("D3AB0F52-EA41-4891-9470-6E945A9D6583")]
	public struct NetworkGuid : IEquatable<NetworkGuid>, IComparable<NetworkGuid>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		[RecRoom.DataLayer.Field(1)]
		public int4 data;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public Guid Guid
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x1136330", Offset = "0x1134D30", VA = "0x181136330")]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x1136320", Offset = "0x1134D20", VA = "0x181136320")]
			set
			{
			}
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x1136330", Offset = "0x1134D30", VA = "0x181136330")]
		public static Guid MEHFEEABIDG(NetworkGuid BIGAPECKJPI)
		{
			return default(Guid);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x1136330", Offset = "0x1134D30", VA = "0x181136330")]
		public static NetworkGuid MEHFEEABIDG(Guid BIGAPECKJPI)
		{
			return default(NetworkGuid);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x78B7FA0", Offset = "0x78B69A0", VA = "0x1878B7FA0", Slot = "4")]
		public bool Equals(NetworkGuid OLKLGHOAKNE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x52EFC70", Offset = "0x52EE670", VA = "0x1852EFC70", Slot = "5")]
		public int CompareTo(NetworkGuid OLKLGHOAKNE)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x78B7FD0", Offset = "0x78B69D0", VA = "0x1878B7FD0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
[RecRoom.DataLayer.NetworkStruct(1, false)]
[RecRoom.DataLayer.RRGuid("9F5F33BE-7C0A-4870-9CE0-BA79440E7F98")]
public struct KPLMGPNDEAI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000264")]
	[RecRoom.DataLayer.Field(1)]
	public bool PLGFLNLCLML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000265")]
	[RecRoom.DataLayer.Field(2)]
	public float3 KPLEJKMIMCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000266")]
	[RecRoom.DataLayer.Field(3)]
	public float3 DHHJGIKEAPF;

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x78B2820", Offset = "0x78B1220", VA = "0x1878B2820")]
	public KPLMGPNDEAI(float ODPANEHCOAE, float AIHFEHEPHFF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
[RecRoom.DataLayer.NetworkStruct(1, false)]
[RecRoom.DataLayer.RRGuid("35984D5B-ACBD-4389-A94B-840070A871E2")]
public struct JPHEOFPJKHK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000267")]
	[RecRoom.DataLayer.Field(1)]
	public float CCHOCGMLNHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000268")]
	[RecRoom.DataLayer.Field(2)]
	public int NBOIBGANHOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000269")]
	[RecRoom.DataLayer.Field(3)]
	public LKPMBDOIBEA BNNEEGIINDP;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public bool PODNLPPIGGD
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x78B7360", Offset = "0x78B5D60", VA = "0x1878B7360")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x78B73C0", Offset = "0x78B5DC0", VA = "0x1878B73C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public bool JDJHABCKPOG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x78B73E0", Offset = "0x78B5DE0", VA = "0x1878B73E0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x78B73A0", Offset = "0x78B5DA0", VA = "0x1878B73A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public bool HPEMNCOOJKD
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x78B7370", Offset = "0x78B5D70", VA = "0x1878B7370")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x78B7380", Offset = "0x78B5D80", VA = "0x1878B7380")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
public class DHIJOKOLFJM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400026A")]
	public FJJGNPGCINA GPNDPHJOAKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400026B")]
	public int LGAPHMPJGNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400026C")]
	public bool HJMKGFNNCFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D")]
	[Cpp2IlInjected.Token(Token = "0x400026D")]
	public bool JPMINNCINIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E")]
	[Cpp2IlInjected.Token(Token = "0x400026E")]
	public bool GHMIIHAKPBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400026F")]
	public Vector3 NHAANPHMDOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000270")]
	public Quaternion JHFELMOKPLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000271")]
	public bool ALENACKONCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000272")]
	public Vector3 MOGENFAMANI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000273")]
	public Vector3 OMBGOHLKNHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000274")]
	public Vector3 NJDKGDNNCKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000275")]
	public bool IBJDEINDOMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000276")]
	protected ViewId HIFCHDMMAJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x4000277")]
	protected LPFCEALDCNO BLPJIJOHGJF;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public ViewId EDFMDKKGONB
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x78B6060", Offset = "0x78B4A60", VA = "0x1878B6060")]
		get
		{
			return default(ViewId);
		}
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0xE8C6B0", Offset = "0xE8B0B0", VA = "0x180E8C6B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x78B6100", Offset = "0x78B4B00", VA = "0x1878B6100", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
	public DHIJOKOLFJM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
public struct KJHENAGCBNO : IEquatable<KJHENAGCBNO>, IComparable<KJHENAGCBNO>
{
	[Cpp2IlInjected.Token(Token = "0x4000278")]
	public static readonly int ODMHBMDCJHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000279")]
	public RRObjectPrefabData DEMHLIAEAHH;

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x78B7610", Offset = "0x78B6010", VA = "0x1878B7610", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x78B7470", Offset = "0x78B5E70", VA = "0x1878B7470", Slot = "4")]
	public bool Equals(KJHENAGCBNO OLKLGHOAKNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x78B74E0", Offset = "0x78B5EE0", VA = "0x1878B74E0", Slot = "0")]
	public override bool Equals(object OIIGDBLKEDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x78B75E0", Offset = "0x78B5FE0", VA = "0x1878B75E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x78B73F0", Offset = "0x78B5DF0", VA = "0x1878B73F0", Slot = "5")]
	public int CompareTo(KJHENAGCBNO OLKLGHOAKNE)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
internal class MCIIHLHPIEC : ContainerPropertyBag<IAEIEHMNGOO>
{
	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x78B7F40", Offset = "0x78B6940", VA = "0x1878B7F40")]
	public MCIIHLHPIEC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
internal class EEBJMEENPMJ : ContainerPropertyBag<RRObjectPrefabData>
{
	[Cpp2IlInjected.Token(Token = "0x200009E")]
	private class BBNPOCGANII : Property<RRObjectPrefabData, KPBBJPOJBPM>
	{
		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public override string HFKDIDMKBGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x78B4D70", Offset = "0x78B3770", VA = "0x1878B4D70", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public override bool KMCAIMHLNNE
		{
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x9F7930", Offset = "0x9F6330", VA = "0x1809F7930", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x78B4C80", Offset = "0x78B3680", VA = "0x1878B4C80")]
		public BBNPOCGANII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x2083650", Offset = "0x2082050", VA = "0x182083650", Slot = "14")]
		public override KPBBJPOJBPM GetValue(RRObjectPrefabData MCJDMILNGAL)
		{
			return default(KPBBJPOJBPM);
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x78B4660", Offset = "0x78B3060", VA = "0x1878B4660", Slot = "15")]
		public override void SetValue(RRObjectPrefabData MCJDMILNGAL, KPBBJPOJBPM PPJFMHBDGNA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009F")]
	private class MCAEJAGGABF : Property<RRObjectPrefabData, Guid>
	{
		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public override string HFKDIDMKBGI
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x78B7F10", Offset = "0x78B6910", VA = "0x1878B7F10", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public override bool KMCAIMHLNNE
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x9F7930", Offset = "0x9F6330", VA = "0x1809F7930", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x78B7E20", Offset = "0x78B6820", VA = "0x1878B7E20")]
		public MCAEJAGGABF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x2C8C210", Offset = "0x2C8AC10", VA = "0x182C8C210", Slot = "14")]
		public override Guid GetValue(RRObjectPrefabData MCJDMILNGAL)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x78B7E10", Offset = "0x78B6810", VA = "0x1878B7E10", Slot = "15")]
		public override void SetValue(RRObjectPrefabData MCJDMILNGAL, Guid PPJFMHBDGNA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x78B6A70", Offset = "0x78B5470", VA = "0x1878B6A70")]
	public EEBJMEENPMJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
internal class FGOOFLAMDCM : ContainerPropertyBag<Guid>
{
	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x78B6DD0", Offset = "0x78B57D0", VA = "0x1878B6DD0")]
	public FGOOFLAMDCM()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x78B8950", Offset = "0x78B7350", VA = "0x1878B8950")]
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
