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
		[Cpp2IlInjected.Address(RVA = "0xA2B980", Offset = "0xA2AB80", VA = "0x180A2B980")]
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
		[Cpp2IlInjected.Address(RVA = "0xA2B980", Offset = "0xA2AB80", VA = "0x180A2B980")]
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
	public class LogRegistrationIndex : LALFEIIPPKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7C02230", Offset = "0x7C01430", VA = "0x187C02230", Slot = "4")]
		public override void ELDCOJNOKAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA2B980", Offset = "0xA2AB80", VA = "0x180A2B980")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct JFCHFPCKANG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private bool ODHIHPJJPGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private ViewId LIOACKIDDBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private int GJBFKFHLHKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private bool HGNIMMIHAGM;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7C02120", Offset = "0x7C01320", VA = "0x187C02120")]
	public JFCHFPCKANG(ViewId LIOACKIDDBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7C02140", Offset = "0x7C01340", VA = "0x187C02140")]
	public JFCHFPCKANG(int GJBFKFHLHKP, bool HGNIMMIHAGM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7C02040", Offset = "0x7C01240", VA = "0x187C02040")]
	public ViewId AFEFMFKBJPL([Optional] ViewId DKJNDCLMCKO)
	{
		return default(ViewId);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class GGILNJIOLAD
{
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly Guid CHOOFJCCMCO;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static readonly Guid FNCMIGCMLHK;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static readonly Guid PDMDHDBLGNI;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public static readonly Guid MPOBMIGJDKP;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly Guid IGGPPAENLIF;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public static readonly Dictionary<string, Guid> JKIKOOKJDNP;

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static readonly RRObjectPrefabData NOOKLPLEDLD;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly RRObjectPrefabData EOCIAJEECBD;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly RRObjectPrefabData HLPMGFHCADI;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7C01970", Offset = "0x7C00B70", VA = "0x187C01970")]
	public static Guid AIHBKMDANGC(string GBOCGPJOEEK)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7C01A10", Offset = "0x7C00C10", VA = "0x187C01A10")]
	public static RRObjectPrefabData NCAEIOJHAMP(DDPHEKACOFI GDHKDBJPDLG)
	{
		return default(RRObjectPrefabData);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7C019A0", Offset = "0x7C00BA0", VA = "0x187C019A0")]
	public static RRObjectPrefabData FALMABKCMBE(DDPHEKACOFI GDHKDBJPDLG)
	{
		return default(RRObjectPrefabData);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7C019F0", Offset = "0x7C00BF0", VA = "0x187C019F0")]
	public static RRObjectPrefabData FIKIBKOHPAG(Guid DJOIAEMCFDK)
	{
		return default(RRObjectPrefabData);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[DefaultMember("Item")]
public class DNNLAHBGMBD : IComponentData, ICloneable, DBPOFPLIGBO
{
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static readonly KEPOMIIOHBM EBHKLAMEJCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly Dictionary<int, object> CAIGHLKIDBF;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public Dictionary<int, object> OCEAHOAJAAG
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xA011A0", Offset = "0xA003A0", VA = "0x180A011A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public object HAHLLCOCBCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7BFFCD0", Offset = "0x7BFEED0", VA = "0x187BFFCD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x7BFFEE0", Offset = "0x7BFF0E0", VA = "0x187BFFEE0")]
	public DNNLAHBGMBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0xA0F6B0", Offset = "0xA0E8B0", VA = "0x180A0F6B0")]
	public DNNLAHBGMBD(Dictionary<int, object> CAIGHLKIDBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7BFFC70", Offset = "0x7BFEE70", VA = "0x187BFFC70", Slot = "5")]
	public bool FALMCDECAMG(GFJCGALDBGO MHDODBCCAJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7BFFD30", Offset = "0x7BFEF30", VA = "0x187BFFD30", Slot = "6")]
	public void NFMLNACLIJM(KEPOMIIOHBM EBHKLAMEJCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x3868310", Offset = "0x3867510", VA = "0x183868310")]
	public void EOCKEAJHEJK<T>(GFJCGALDBGO MHDODBCCAJB, T KJIOHKMJAPE, [Optional] T FEOJADDJKIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3868150", Offset = "0x3867350", VA = "0x183868150")]
	public void DEEMOOGCBGF<T>(GFJCGALDBGO MHDODBCCAJB, T KJIOHKMJAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7BFFE30", Offset = "0x7BFF030", VA = "0x187BFFE30")]
	public void PKCJOLGDFLO(GFJCGALDBGO MHDODBCCAJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7BFFC00", Offset = "0x7BFEE00", VA = "0x187BFFC00", Slot = "4")]
	public object Clone()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum GFJCGALDBGO : byte
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
	UnitySubAssets
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct AIPPKFAMMCJ<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly GFJCGALDBGO MHDODBCCAJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly T FEOJADDJKIL;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x4F33EB0", Offset = "0x4F330B0", VA = "0x184F33EB0")]
	public AIPPKFAMMCJ(GFJCGALDBGO MHDODBCCAJB, T FEOJADDJKIL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x4F33C40", Offset = "0x4F32E40", VA = "0x184F33C40")]
	public static AIPPKFAMMCJ<T> PDHAGBEBCNG(GFJCGALDBGO MHDODBCCAJB)
	{
		return default(AIPPKFAMMCJ<T>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x4F33C70", Offset = "0x4F32E70", VA = "0x184F33C70")]
	public static AIPPKFAMMCJ<T> PDHAGBEBCNG((GFJCGALDBGO key, T value) BGPKBCGBDMP)
	{
		return default(AIPPKFAMMCJ<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface DBPOFPLIGBO
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FALMCDECAMG(GFJCGALDBGO MHDODBCCAJB);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NFMLNACLIJM(KEPOMIIOHBM EBHKLAMEJCE);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[DebuggerTypeProxy(typeof(IOHLEGHILBG))]
[DebuggerDisplay("Count = {Count}")]
public struct DDJGKBBEDKH : IEnumerable<object>, IEnumerable, DBPOFPLIGBO
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	private class IOHLEGHILBG : Dictionary<string, object>
	{
	}

	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private static readonly KEPOMIIOHBM EBHKLAMEJCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private Dictionary<int, object> AJLJPILGNIP;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool PAKAGCJKALC
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x1814100", Offset = "0x1813300", VA = "0x181814100")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int OGMGMMMEFKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7BFF610", Offset = "0x7BFE810", VA = "0x187BFF610")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7BFF590", Offset = "0x7BFE790", VA = "0x187BFF590")]
	public static DDJGKBBEDKH DBJJOAFKEPP()
	{
		return default(DDJGKBBEDKH);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0xD91890", Offset = "0xD90A90", VA = "0x180D91890")]
	public DDJGKBBEDKH([Optional] Dictionary<int, object> AJLJPILGNIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x3856760", Offset = "0x3855960", VA = "0x183856760")]
	public void LHOMNBOIMGH<T>(AIPPKFAMMCJ<T> MHDODBCCAJB, T? KJIOHKMJAPE) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x3856590", Offset = "0x3855790", VA = "0x183856590")]
	public void LHOMNBOIMGH<T>((AIPPKFAMMCJ<T> key, T value) PEDOHHMFOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3856600", Offset = "0x3855800", VA = "0x183856600")]
	public void LHOMNBOIMGH<T>(AIPPKFAMMCJ<T> MHDODBCCAJB, T KJIOHKMJAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7BFF7A0", Offset = "0x7BFE9A0", VA = "0x187BFF7A0")]
	public void JKECMACEHMD(DDJGKBBEDKH LMDCFNDMKMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7BFF720", Offset = "0x7BFE920", VA = "0x187BFF720")]
	private void IJDFNMPLFGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x38547D0", Offset = "0x38539D0", VA = "0x1838547D0")]
	public bool FBLKJFCBGPJ<T>(AIPPKFAMMCJ<T> MHDODBCCAJB, [Out] T KJIOHKMJAPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3854420", Offset = "0x3853620", VA = "0x183854420", Slot = "8")]
	public bool FBLKJFCBGPJ<T>(GFJCGALDBGO MHDODBCCAJB, [Out] T KJIOHKMJAPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3857520", Offset = "0x3856720", VA = "0x183857520")]
	public T MFLBPAMAKHM<T>(AIPPKFAMMCJ<T> MHDODBCCAJB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3854300", Offset = "0x3853500", VA = "0x183854300")]
	public bool FALMCDECAMG<T>(AIPPKFAMMCJ<T> MHDODBCCAJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7BFF660", Offset = "0x7BFE860", VA = "0x187BFF660", Slot = "6")]
	public bool FALMCDECAMG(GFJCGALDBGO MHDODBCCAJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3857820", Offset = "0x3856A20", VA = "0x183857820")]
	public void PKCJOLGDFLO<T>(AIPPKFAMMCJ<T> MHDODBCCAJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7BFFAA0", Offset = "0x7BFECA0", VA = "0x187BFFAA0")]
	public void PKCJOLGDFLO(GFJCGALDBGO MHDODBCCAJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0xD919D0", Offset = "0xD90BD0", VA = "0x180D919D0")]
	public Dictionary<int, object> IDBIPJGAHLK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7BFF6C0", Offset = "0x7BFE8C0", VA = "0x187BFF6C0", Slot = "4")]
	public IEnumerator<object> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7BFFAF0", Offset = "0x7BFECF0", VA = "0x187BFFAF0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7BFF9B0", Offset = "0x7BFEBB0", VA = "0x187BFF9B0", Slot = "7")]
	public void NFMLNACLIJM(KEPOMIIOHBM EBHKLAMEJCE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public enum EFIDCPLKGBJ
{
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	PrefabComponents,
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	LocalObjectComponents,
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	NetworkedObjectComponents,
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	PolicyComponents,
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	ConnectableComponents,
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	RbexComponents,
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	TransformPoseComponents,
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	UniformTransformComponents,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	DeformableSizeComponents,
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	ShapeComponents,
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	PrimitiveComponents,
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	SplineComponents,
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	SplinePointComponents,
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	ContainerComponents,
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	ContainerLikeComponents,
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	ReplicatorComponents,
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	ContainerPivotComponents,
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	ShapeContainerComponents,
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	CostumePieceComponents,
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	PreventSerializationComponent,
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	DontPropagatePhysicsComponent,
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	DontPropagateOwnershipComponent,
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	LegacyGameObjectComponents,
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	GameObjectLegacyGizmoComponents,
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	GameObjectCostumeDummyPropComponents,
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	PlayerComponents,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	PlayerRbexComponents,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	PlayerTransformComponents,
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	RequireEmbodiedComponents,
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	EntityPrefabRootComponents,
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	EntityPrefabPartComponents,
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	SocketComponents,
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	VisibleInHierarchyComponents,
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	ToolCleanupComponents,
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	TagComponents,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	InteractionFilterTagComponents,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	AutoEmbodimentComponents,
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	ReferenceGroupComponents,
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	UserTagStorageComponents,
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	ReplicatedObjectComponents,
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	InteractionFilteringSettingsComponents,
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	InventionTrackingComponents,
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	ObjectBoardComponents,
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	NetworkTransformComponents,
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	AlwaysEmbodiedScopeComponents,
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	LoadInstanceLifetimeComponents,
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	PhysicsModelComponents,
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	StudioPropObjectComponents,
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	AnimationControllerComponents,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	StudioObjectComponents,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	DesyncNetworkObjectComponents,
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	AuthoredPoseComponents,
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	HasCustomInertialPropertiesWhenRootComponents
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface FDMFIFPHKJP
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public enum IMIJDDNPANE
	{
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		Entity,
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		Prefab
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	LocalId HMMACBBIIEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	RRObjectPrefabData IMJPJOEFIOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JMPGHILBEJJ(params string[] OECAECFBJIG);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PAJDPJAEEGB(EFIDCPLKGBJ JIJEAFDLOKF, IMIJDDNPANE CPNALAHLBCM = IMIJDDNPANE.Entity);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ADMAKGEFAAD(Type GDHKDBJPDLG, ReadOnlySpan<byte> CAIGHLKIDBF, int LCBGIPCKGMF, IMIJDDNPANE CPNALAHLBCM = IMIJDDNPANE.Entity);

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KAOHHIBOPGA(Type GDHKDBJPDLG, IMIJDDNPANE CPNALAHLBCM = IMIJDDNPANE.Entity);

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void LDHPJILHPJP(EFIDCPLKGBJ JIJEAFDLOKF, IMIJDDNPANE CPNALAHLBCM = IMIJDDNPANE.Entity);

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool FFBDACFEIJL(EFIDCPLKGBJ JIJEAFDLOKF);

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void HBFDDLIOJFP(bool GIKDOPOBIAD, IMIJDDNPANE CPNALAHLBCM = IMIJDDNPANE.Entity);

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void MMJLAEACIIA();

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void INJPOINLGAL(Type GDHKDBJPDLG);

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "11")]
	OCLOANDEEPK ACOIOPKGLIJ(Type GDHKDBJPDLG);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class AEJJEJJIJPD
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7BFE460", Offset = "0x7BFD660", VA = "0x187BFE460")]
	public static bool OGDLECDDHPA(this FDMFIFPHKJP BKDMJHGCDEA, EFIDCPLKGBJ IMLPAHMDDDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7BFE400", Offset = "0x7BFD600", VA = "0x187BFE400")]
	public static void EDFOMMEGMNO(this FDMFIFPHKJP BKDMJHGCDEA, FDMFIFPHKJP.IMIJDDNPANE CPNALAHLBCM = FDMFIFPHKJP.IMIJDDNPANE.Entity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7BFE3A0", Offset = "0x7BFD5A0", VA = "0x187BFE3A0")]
	public static void DIEMFLBPLDD(this FDMFIFPHKJP BKDMJHGCDEA, FDMFIFPHKJP.IMIJDDNPANE CPNALAHLBCM = FDMFIFPHKJP.IMIJDDNPANE.Entity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2FA4400", Offset = "0x2FA3600", VA = "0x182FA4400")]
	public static void GLAOBMMGGHN<T>(this FDMFIFPHKJP BKDMJHGCDEA, FDMFIFPHKJP.IMIJDDNPANE CPNALAHLBCM = FDMFIFPHKJP.IMIJDDNPANE.Entity) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2FA4420", Offset = "0x2FA3620", VA = "0x182FA4420")]
	public static void GOEHJOHMANM<T>(this FDMFIFPHKJP BKDMJHGCDEA, FDMFIFPHKJP.IMIJDDNPANE CPNALAHLBCM = FDMFIFPHKJP.IMIJDDNPANE.Entity) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2FA4710", Offset = "0x2FA3910", VA = "0x182FA4710")]
	public static void LHHLIOJKNII<T>(this FDMFIFPHKJP BKDMJHGCDEA, bool EODLKOGINBN, FDMFIFPHKJP.IMIJDDNPANE CPNALAHLBCM = FDMFIFPHKJP.IMIJDDNPANE.Entity) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2FA2990", Offset = "0x2FA1B90", VA = "0x182FA2990")]
	public static void ADMAKGEFAAD<T>(this FDMFIFPHKJP BKDMJHGCDEA, T KJIOHKMJAPE, FDMFIFPHKJP.IMIJDDNPANE CPNALAHLBCM = FDMFIFPHKJP.IMIJDDNPANE.Entity) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x2FA4530", Offset = "0x2FA3730", VA = "0x182FA4530")]
	public static void KAOHHIBOPGA<T>(this FDMFIFPHKJP BKDMJHGCDEA, FDMFIFPHKJP.IMIJDDNPANE CPNALAHLBCM = FDMFIFPHKJP.IMIJDDNPANE.Entity) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x2FA4430", Offset = "0x2FA3630", VA = "0x182FA4430")]
	public static void INJPOINLGAL<T>(this FDMFIFPHKJP BKDMJHGCDEA) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x2FA4740", Offset = "0x2FA3940", VA = "0x182FA4740")]
	public static void OCIGMCPMDEI<T>(this FDMFIFPHKJP BKDMJHGCDEA, LocalId MNPNHJICMND, FDMFIFPHKJP.IMIJDDNPANE CPNALAHLBCM = FDMFIFPHKJP.IMIJDDNPANE.Entity) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x2FA2810", Offset = "0x2FA1A10", VA = "0x182FA2810")]
	private static void ADMAKGEFAAD<T>(this FDMFIFPHKJP BKDMJHGCDEA, Type GDHKDBJPDLG, T KJIOHKMJAPE, FDMFIFPHKJP.IMIJDDNPANE CPNALAHLBCM = FDMFIFPHKJP.IMIJDDNPANE.Entity) where T : struct
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct ILGHBGMLPEL
{
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface DKLHOFAAIEO
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	Entity JICIEFKGHKK
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
public interface FCCLCKGFKHO
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "0")]
	void PreBake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Bake(FDMFIFPHKJP BKDMJHGCDEA);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface GMJKKMPLFHE
{
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OCLOANDEEPK KPBMFLANNLK(Type GDHKDBJPDLG);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class MBHLEIPBMFI
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x3AE7EC0", Offset = "0x3AE70C0", VA = "0x183AE7EC0")]
	public static void KPBMFLANNLK<T>(this GMJKKMPLFHE BKDMJHGCDEA, [Out] T KJIOHKMJAPE) where T : OCLOANDEEPK
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface OCLOANDEEPK
{
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class HBGHPHDKJJG
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x3A19A10", Offset = "0x3A18C10", VA = "0x183A19A10")]
	public static void FDNGPJFAPCN<T>(this T HBNOJPHCEPL, FDMFIFPHKJP BKDMJHGCDEA) where T : OCLOANDEEPK, IBPCIJIBJHP
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x3A199D0", Offset = "0x3A18BD0", VA = "0x183A199D0")]
	public static bool BPJMFJGBGIB<T>(this T AICEEILOCCE) where T : OCLOANDEEPK
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface IBPCIJIBJHP
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	Type KIOALFNNKNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GGNEAAKPFPJ(OCLOANDEEPK AICEEILOCCE);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface OGKMPEBBKCK : FCCLCKGFKHO
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void InitNetworkData(GMJKKMPLFHE BKDMJHGCDEA);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface KGNFIILOFPE : OCLOANDEEPK
{
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface CGHCLGPOONK
{
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ONGNIJMOLEE(NPGIOFFINPJ LPGODJOFLMG);

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LLICDAFNIGG(NPGIOFFINPJ LPGODJOFLMG);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface DIJGCPMDLBC
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	ViewId LMKPGOKNJNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface AMDJOLLNHGD : DIJGCPMDLBC, GNLFIEKGJKB
{
	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void Initialize(ViewId NFNHBFGEPBF, ViewId LAGMIMGOKAI, Dictionary<int, object> MGGGOEHGEIK, NPGIOFFINPJ IMMAKBDNFNI);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface BEJMLJNBJMK : DIJGCPMDLBC
{
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AFLILFPIJAH(DLILJGCOAIF FLKKOCNDECC, Vector3 JCHDHELBFIA, Quaternion FODPIPCFDKK, Vector3 OJKDLNLPBGA, bool EIDAHNLMDLO);

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JNMAAPLDPBL(Vector3 JCHDHELBFIA, Quaternion FODPIPCFDKK, Vector3 OJKDLNLPBGA);

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KMHANLPIIHA(ViewId FLKKOCNDECC);

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NBBJBHOGDLC(bool CHOBENNEHGP);

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PINMOOGFDIH(bool HGCDNNEEPCO);
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface GNLFIEKGJKB
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ACIDHONCBAB();
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface DKDGOHEOKAK
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NativeArray<Guid> EKIANKFJJHN(World AFDKGPIKPNA, NativeArray<Entity> HBEMCIPCOAI, Allocator DPAKHKILCMF);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface OEIBAEMFMJM
{
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	ReadOnlySpan<byte> HMGNDFBGNEH(Entity GONFONDIOED, int GBOFDIKGPCE);

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ELBHIPJIAMM(Entity GONFONDIOED, int GBOFDIKGPCE, ReadOnlySpan<byte> KJIOHKMJAPE);

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AGFNFCFGKPI(Entity GONFONDIOED, int GBOFDIKGPCE, Action MHPGHAHOBNK);

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void AGIHPCFFIMJ(Entity GONFONDIOED, int GBOFDIKGPCE, Action MHPGHAHOBNK);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public static class IDDBIPKEHMG
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x3A44A50", Offset = "0x3A43C50", VA = "0x183A44A50")]
	public static T DIMDIDKBHCM<T>(this OEIBAEMFMJM EJONAEIGCHL, Entity GONFONDIOED, int GBOFDIKGPCE) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x3A44B90", Offset = "0x3A43D90", VA = "0x183A44B90")]
	public static void OGJPNENBPAE<T>(this OEIBAEMFMJM EJONAEIGCHL, Entity GONFONDIOED, int GBOFDIKGPCE, T KJIOHKMJAPE) where T : struct
	{
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[TypeManager.ForcedStableTypeHash(9635027148749164348uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.RRGuid("6241769E-7423-45E5-B125-9F7EAA5D5232")]
	public struct AiCodeGenIdData : IComponentData, IEquatable<AiCodeGenIdData>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public FixedString64Bytes Value;

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x7BFE660", Offset = "0x7BFD860", VA = "0x187BFE660", Slot = "4")]
		public bool Equals(AiCodeGenIdData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x7BFE6A0", Offset = "0x7BFD8A0", VA = "0x187BFE6A0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x7BFE760", Offset = "0x7BFD960", VA = "0x187BFE760", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[TypeManager.ForcedStableTypeHash(3758703684052595571uL)]
	[RecRoom.DataLayer.RRGuid("399DD840-DE45-43FA-9EB0-5E80BC93C8CB")]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct AiCodeGenNameData : IComponentData, IEquatable<AiCodeGenNameData>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public FixedString64Bytes Value;

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7BFE660", Offset = "0x7BFD860", VA = "0x187BFE660", Slot = "4")]
		public bool Equals(AiCodeGenNameData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7BFE770", Offset = "0x7BFD970", VA = "0x187BFE770", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7BFE760", Offset = "0x7BFD960", VA = "0x187BFE760", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public struct BHHBLKPMKGN : IComponentData, IEquatable<BHHBLKPMKGN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	[RecRoom.DataLayer.Default]
	[RecRoom.DataLayer.Field(1)]
	public uint LFLEGEJLLKE;

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7BFE830", Offset = "0x7BFDA30", VA = "0x187BFE830", Slot = "4")]
	public bool Equals(BHHBLKPMKGN CMOCFNBHPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x7BFEAF0", Offset = "0x7BFDCF0", VA = "0x187BFEAF0", Slot = "0")]
	public override bool Equals(object KFMNDOMPAMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x13D8CD0", Offset = "0x13D7ED0", VA = "0x1813D8CD0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[RecRoom.DataLayer.RRGuid("A8D1A28C-A057-4DF1-B0CF-22A81E217E19")]
	[TypeManager.ForcedStableTypeHash(11317457978519712368uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.TombstonedFields(new int[] { 2 })]
	[RecRoom.DataLayer.NetworkComponent(4, false)]
	public struct AuthoredAIIdData : IComponentData, IEquatable<AuthoredAIIdData>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public uint Value;

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x7BFE830", Offset = "0x7BFDA30", VA = "0x187BFE830", Slot = "4")]
		public bool Equals(AuthoredAIIdData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x7BFE840", Offset = "0x7BFDA40", VA = "0x187BFE840", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x13D8CD0", Offset = "0x13D7ED0", VA = "0x1813D8CD0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[TypeManager.ForcedStableTypeHash(3063687516547021329uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.RRGuid("650DAD22-E465-4BF2-9A09-076774E09A3E")]
	public struct AuthoredLocalDeformableScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		[RecRoom.DataLayer.Default("new float3(1)")]
		[RecRoom.DataLayer.Field(1)]
		public float3 localDeformationScale;

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x2ACF310", Offset = "0x2ACE510", VA = "0x182ACF310")]
		public AuthoredLocalDeformableScaleData(float3 scale)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[RecRoom.DataLayer.StableTypeHash(11505792609904010668uL, 0u)]
	[TypeManager.ForcedStableTypeHash(11505792609904010668uL)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("B7CEB5B9-453F-4712-B833-27D907AA13E2")]
	[CompilerGenerated]
	public struct AuthoredLocalPoseData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		[RecRoom.DataLayer.Default("new quaternion(new float4(float.NaN))")]
		[RecRoom.DataLayer.Field(1)]
		public quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		[RecRoom.DataLayer.Field(2)]
		[RecRoom.DataLayer.Default("new float3(float.NaN)")]
		public float3 localPosition;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public readonly bool IsValid
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x7BFE8D0", Offset = "0x7BFDAD0", VA = "0x187BFE8D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x51CF0A0", Offset = "0x51CE2A0", VA = "0x1851CF0A0")]
		public AuthoredLocalPoseData(quaternion localRotation, float3 localPosition)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7BFE930", Offset = "0x7BFDB30", VA = "0x187BFE930")]
		public static RigidTransform PDHAGBEBCNG(AuthoredLocalPoseData poseData)
		{
			return default(RigidTransform);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x7BFE930", Offset = "0x7BFDB30", VA = "0x187BFE930")]
		public static AuthoredLocalPoseData PDHAGBEBCNG(RigidTransform pose)
		{
			return default(AuthoredLocalPoseData);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class JJNBLKPPMHD
{
	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7C021B0", Offset = "0x7C013B0", VA = "0x187C021B0")]
	public static AuthoredLocalPoseData NDHBLOFICHE([In] this RigidTransform KJIOHKMJAPE)
	{
		return default(AuthoredLocalPoseData);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0xCDE2C0", Offset = "0xCDD4C0", VA = "0x180CDE2C0")]
	public static RigidTransform KODHGFBABOI(this AuthoredLocalPoseData KJIOHKMJAPE)
	{
		return default(RigidTransform);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7C02180", Offset = "0x7C01380", VA = "0x187C02180")]
	public static RigidTransform MALIFEOIGOK([In] this AuthoredLocalPoseData KJIOHKMJAPE)
	{
		return default(RigidTransform);
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[TypeManager.ForcedStableTypeHash(9088562008033959482uL)]
	[RecRoom.DataLayer.StableTypeHash(9088562008033959482uL, 0u)]
	[RecRoom.DataLayer.RRGuid("C26C4B4E-5EF3-4F81-87C8-FED8EAD37242")]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct AuthoredLocalUniformScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		[RecRoom.DataLayer.Default(1f)]
		[RecRoom.DataLayer.Field(1)]
		public float localUniformScale;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public readonly bool IsValid
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x7BFE950", Offset = "0x7BFDB50", VA = "0x187BFE950")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x2ACD610", Offset = "0x2ACC810", VA = "0x182ACD610")]
		public AuthoredLocalUniformScaleData(float localUniformScale)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[TypeManager.ForcedStableTypeHash(10137300772124140051uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.StableTypeHash(10137300772124140051uL, 0u)]
	[RecRoom.DataLayer.RRGuid("7B1B8635-3FA9-4ADC-922B-3C25CE0C7E7D")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct AuthoredParentData : IComponentData, DKLHOFAAIEO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public Entity parent;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0xD919D0", Offset = "0xD90BD0", VA = "0x180D919D0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x124E8B0", Offset = "0x124DAB0", VA = "0x18124E8B0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x124E8B0", Offset = "0x124DAB0", VA = "0x18124E8B0")]
		public AuthoredParentData(Entity parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x7BFE9B0", Offset = "0x7BFDBB0", VA = "0x187BFE9B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002C")]
public struct FOKKHALCALO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002D")]
[TypeManager.ForcedStableTypeHash(11776442497872827640uL)]
public struct OBBJBLAHPME : IComponentData
{
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[RecRoom.DataLayer.RRGuid("B9A63EF5-66A5-463C-8385-A7DC7CE137C3")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[TypeManager.ForcedStableTypeHash(8594223769175916906uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.StableTypeHash(8594223769175916906uL, 0u)]
	public struct ObjectBoardNodeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public NetworkGuid nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(2)]
		public NetworkGuid graphId;
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("B26EF01D-F674-4506-80B7-5345391A097E")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(5933855128949143734uL)]
	public struct ReplicatedObjectActiveStatusData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		[RecRoom.DataLayer.Default(true)]
		[RecRoom.DataLayer.Field(1)]
		public bool active;
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[TypeManager.ForcedStableTypeHash(16338184133650423946uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.RRGuid("E9BA10A4-4EE9-431D-BD7F-FF2008ABFA03")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct ReplicatedObjectOwnedByPlayerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default(-1)]
		public int actorId;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct GNFHKFMOCKI : IComponentData
{
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[CompilerGenerated]
	[RecRoom.DataLayer.RRGuid("46C500A2-9991-4987-B1AA-66E5C3D8E371")]
	[TypeManager.ForcedStableTypeHash(16223816226138460552uL)]
	public struct ReplicatedObjectTag : IComponentData
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	[RecRoom.DataLayer.RRGuid("5ED157AA-488F-453A-A986-594595B8D777")]
	[TypeManager.ForcedStableTypeHash(17912083982325865811uL)]
	public struct ReplicatorData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public Entity Target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		[RecRoom.DataLayer.Field(2)]
		[RecRoom.DataLayer.Default(false)]
		public bool NeedsCircuitUpdate;
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[RuntimeOnly]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(11840542726010018465uL)]
	[RecRoom.DataLayer.RRGuid("72F1ABE4-CB5D-4809-8C6D-BC4D800D9E30")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct ReplicatorExpectedCircuitsRevisionData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public uint ExpectedRevision;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000035")]
public struct CBMGCPDEMNM : IComponentData
{
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[TypeManager.ForcedStableTypeHash(8691279933813304851uL)]
	[RecRoom.DataLayer.RRGuid("AEA4D222-29BA-462F-9C0A-AA2063671C68")]
	public struct ReplicatorMaxObjectCountData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default(10)]
		public int count;
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	[RecRoom.DataLayer.RRGuid("400790C1-E8D9-4779-A549-3780DAEC2FDF")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(16379995002884076574uL)]
	public struct ReplicatorPreallocatedObjectCountData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default(0)]
		public int preallocatedCopies;
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.StableTypeHash(8536678595025273356uL, 0u)]
	[CompilerGenerated]
	[RecRoom.DataLayer.RRGuid("6A82044A-E392-4DCD-B4BC-A120E58334EA")]
	[TypeManager.ForcedStableTypeHash(8536678595025273356uL)]
	public struct EntityPrefabPartData : IComponentData, IComparable<EntityPrefabPartData>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public Entity prefabRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(2)]
		public uint partId;

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x7C00C10", Offset = "0x7BFFE10", VA = "0x187C00C10", Slot = "4")]
		public readonly int CompareTo(EntityPrefabPartData other)
		{
			return default(int);
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public struct EntityPrefabPartId : IEquatable<EntityPrefabPartId>, IComparable<EntityPrefabPartId>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		[SerializeField]
		private uint id;

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x1399440", Offset = "0x1398640", VA = "0x181399440")]
		internal EntityPrefabPartId(uint APBCLGNDGBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0xBB1DE0", Offset = "0xBB0FE0", VA = "0x180BB1DE0")]
		internal uint ODDPIFOFAKK()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x2273C90", Offset = "0x2272E90", VA = "0x182273C90", Slot = "4")]
		public bool Equals(EntityPrefabPartId CMOCFNBHPLJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x7C00C60", Offset = "0x7BFFE60", VA = "0x187C00C60", Slot = "0")]
		public override bool Equals(object KFMNDOMPAMC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x13D8CD0", Offset = "0x13D7ED0", VA = "0x1813D8CD0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x2273BF0", Offset = "0x2272DF0", VA = "0x182273BF0", Slot = "5")]
		public int CompareTo(EntityPrefabPartId CMOCFNBHPLJ)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[TypeManager.ForcedStableTypeHash(15026348711748810383uL)]
public struct GKIFEOMNDHP : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public Entity HHAIGBDCFAE;
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[TypeManager.ForcedStableTypeHash(2330616907306882483uL)]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	[CompilerGenerated]
	[ConfigGroup("Physics", 0)]
	[RecRoom.DataLayer.RRGuid("F74D558B-BDCC-48C8-A8EF-1F7559E5EAA0")]
	public struct PhysicsModelCollisionModeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default(PDFBMJELBFB.Children)]
		[Config(null, 0)]
		public PDFBMJELBFB collisionMode;
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[TypeManager.ForcedStableTypeHash(11125590729425051511uL)]
	[ConfigGroup("Container", 0)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("8A12EB45-2A15-41CE-AFF7-90A9F984D3A2")]
	[CompilerGenerated]
	public struct ContainerIsRecolorableData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		[Config(null, 0)]
		public bool IsRecolorable;
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	[RecRoom.DataLayer.RRGuid("55EAB643-95BB-4C3A-832C-798EBCD95AD5")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[TypeManager.ForcedStableTypeHash(14800424556151816553uL)]
	[InternalBufferCapacity(0)]
	public struct ContainerNameBuffer : IBufferElementData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public byte data;
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[RecRoom.DataLayer.RRGuid("89708D57-D027-494A-A159-221E6C643B6B")]
	[CompilerGenerated]
	[ConfigGroup("Container", 0)]
	[TypeManager.ForcedStableTypeHash(13657791279235747653uL)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.StableTypeHash(13657791279235747653uL, 0u)]
	public struct ContainerNameData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		[Config(null, 0)]
		public FixedString64Bytes name;
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	[ConfigGroup("Physics", 0)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(13904209480152351845uL)]
	[RecRoom.DataLayer.RRGuid("CA023286-E0F6-4DA9-A346-94E86B93977C")]
	public struct PhysicsModelGrabbableModeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		[RecRoom.DataLayer.Field(1)]
		[Config(null, 0)]
		[RecRoom.DataLayer.Default]
		public CICBNKDBBEN grabbableMode;
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[TypeManager.ForcedStableTypeHash(16485879999901987510uL)]
	[ConfigGroup("Container", 0)]
	[RecRoom.DataLayer.RRGuid("84485C1B-18ED-4D4A-86A4-34CEED482615")]
	[RecRoom.DataLayer.StableTypeHash(16485879999901987510uL, 0u)]
	public struct NavMeshGenerationData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		[RecRoom.DataLayer.Default(FGGMEDFADEL.NavMeshGenerator)]
		[Config(null, 0)]
		[RecRoom.DataLayer.Field(1)]
		public FGGMEDFADEL mode;
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[RecRoom.DataLayer.RRGuid("C5BCE8B3-6E69-41D4-921A-BE2E3E0A4DAB")]
	[ConfigGroup("Physics", 0)]
	[TypeManager.ForcedStableTypeHash(1954118413118190521uL)]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	[CompilerGenerated]
	public struct PhysicsModelCollisionLayerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		[RecRoom.DataLayer.Field(1)]
		[Config(null, 0)]
		[RecRoom.DataLayer.Default(NOFKHNNLBFH.IsDynamicEnvironment)]
		public NOFKHNNLBFH collisionLayer;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class DNOGMIGPKPK
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public enum NGECCCOOGCG
	{
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		Dynamic,
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		Static,
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		Enemy,
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		Vehicle
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public enum CDHKLHNAJJL
	{
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		Environmental,
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		IgnoreStaticGeometry,
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		IgnoreOtherDynamic,
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		IgnorePlayers,
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		IgnoreMost,
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		Projectile
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x7BFFF70", Offset = "0x7BFF170", VA = "0x187BFFF70")]
	public static (NGECCCOOGCG, CDHKLHNAJJL) JDOJLMHMDEP(this NOFKHNNLBFH BMDFOPHBMNP)
	{
		return default((NGECCCOOGCG, CDHKLHNAJJL));
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[ConfigGroup("Physics", 0)]
	[RecRoom.DataLayer.NetworkComponent(4, false)]
	[RecRoom.DataLayer.RRGuid("F63AA9EA-6191-4DE9-BB18-1F049F432124")]
	[TypeManager.ForcedStableTypeHash(16462677563651546047uL)]
	[CompilerGenerated]
	public struct PhysicsModelFlagsData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		[RecRoom.DataLayer.Field(1)]
		[Config(null, 0)]
		[RecRoom.DataLayer.Default(JMAPILMLMLJ.DEFAULT)]
		public JMAPILMLMLJ flags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[ConfigGroup("Physics", 0)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(1094837642118998916uL)]
	[RecRoom.DataLayer.RRGuid("B6D08147-6AEA-4270-BDC4-8CF68662318D")]
	[RecRoom.DataLayer.StableTypeHash(1094837642118998916uL, 0u)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct PhysicsModelMassOverrideData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default(0f)]
		[Config(null, 0)]
		public float mass;
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[TypeManager.ForcedStableTypeHash(10518841812724430444uL)]
	[RecRoom.DataLayer.RRGuid("17799917-98EE-4D9A-A8D1-B0BE5F7316E3")]
	[CompilerGenerated]
	public struct InventionIdData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default(0L)]
		public long inventionId;

		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public const long INVALID_INVENTION_ID = 0L;

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0xCDE2C0", Offset = "0xCDD4C0", VA = "0x180CDE2C0")]
		public static InventionIdData PDHAGBEBCNG(long value)
		{
			return default(InventionIdData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7C02030", Offset = "0x7C01230", VA = "0x187C02030")]
		public readonly bool HHAOBDKMCDL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x793C2F0", Offset = "0x793B4F0", VA = "0x18793C2F0")]
		public static bool HHAOBDKMCDL(long inventionId)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[RecRoom.DataLayer.TombstonedFields(new int[] { 1 })]
	[RecRoom.DataLayer.RRGuid("629F0A56-C478-4353-BBDA-8A8BB5FEE478")]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	[TypeManager.ForcedStableTypeHash(14338988155392421373uL)]
	[CompilerGenerated]
	public struct InventionInstanceIdData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		[RecRoom.DataLayer.Field(2)]
		[RecRoom.DataLayer.Default]
		public NetworkGuid instanceId;

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x1102FD0", Offset = "0x11021D0", VA = "0x181102FD0")]
		public static InventionInstanceIdData PDHAGBEBCNG(Guid value)
		{
			return default(InventionInstanceIdData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("5D26C8C6-7B5E-481E-B31E-6F30BE69D3C9")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(7796256876318585598uL)]
	public struct DesyncEntityReferenceData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public Entity entity;
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("AFCA5CDE-FE11-4D4A-BBC6-32EE1D254891")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(3111430309403391054uL)]
	public struct DesyncNetworkEntityBackReferenceData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public Entity entity;
	}
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("F1D14C4E-5388-4D7C-B641-5E79453B80AB")]
	[SerializationOnly]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(3936130774074738641uL)]
	public struct DesyncNetworkComponentsData : IBufferElementData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public ulong stableTypeHash;
	}
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[RecRoom.DataLayer.StableTypeHash(12111354511484844847uL, 0u)]
	[RecRoom.DataLayer.RRGuid("A3B27452-BD6C-43B2-BAFF-CF885EB1608B")]
	[CompilerGenerated]
	[RuntimeOnly]
	[TypeManager.ForcedStableTypeHash(12111354511484844847uL)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct ParentData : IComponentData, DKLHOFAAIEO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public Entity parent;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0xD919D0", Offset = "0xD90BD0", VA = "0x180D919D0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x124E8B0", Offset = "0x124DAB0", VA = "0x18124E8B0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x124E8B0", Offset = "0x124DAB0", VA = "0x18124E8B0")]
		public ParentData(Entity parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xCDE2C0", Offset = "0xCDD4C0", VA = "0x180CDE2C0")]
		public static implicit operator ParentData(Entity entity)
		{
			return default(ParentData);
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004D")]
public struct OJPAJCNIGCK : IComponentData
{
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[RecRoom.DataLayer.RRGuid("c886150a-7231-4cc5-a2b2-f222500e6960")]
	[RecRoom.DataLayer.StableTypeHash(1950029632769634832uL, 0u)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(1950029632769634832uL)]
	public struct SiblingSortOrderData : IEquatable<SiblingSortOrderData>, IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public CFAEEBOPCFL order;

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0xCDE2C0", Offset = "0xCDD4C0", VA = "0x180CDE2C0")]
		public static SiblingSortOrderData PDHAGBEBCNG(CFAEEBOPCFL value)
		{
			return default(SiblingSortOrderData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x7BFEEE0", Offset = "0x7BFE0E0", VA = "0x187BFEEE0", Slot = "4")]
		public bool Equals(SiblingSortOrderData other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[RecRoom.DataLayer.RRGuid("46CEA601-8AA7-423D-B1EA-EEABAE73413F")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(6217116203744017593uL)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct InteractionFilterAllTagsData : IComponentData, DKLHOFAAIEO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public Entity allTags;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0xD919D0", Offset = "0xD90BD0", VA = "0x180D919D0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x124E8B0", Offset = "0x124DAB0", VA = "0x18124E8B0", Slot = "5")]
			set
			{
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[TypeManager.ForcedStableTypeHash(6215026851838101933uL)]
	[RecRoom.DataLayer.RRGuid("49CEFD0F-3A38-4A9B-835E-10B4C2D08392")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[CompilerGenerated]
	public struct InteractionFilterAnyTagsData : IComponentData, DKLHOFAAIEO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public Entity anyTags;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0xD919D0", Offset = "0xD90BD0", VA = "0x180D919D0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x124E8B0", Offset = "0x124DAB0", VA = "0x18124E8B0", Slot = "5")]
			set
			{
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[TypeManager.ForcedStableTypeHash(6780642047612598977uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("11CE457F-4366-4AAD-B7E3-28D82B4FAFCF")]
	public struct InteractionFilterEnabledData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		[RecRoom.DataLayer.Default(MHPIEANPOCL.Disabled)]
		[RecRoom.DataLayer.Field(1)]
		public MHPIEANPOCL filterMode;
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(6642820932987006861uL)]
	[RecRoom.DataLayer.RRGuid("F7789094-7D82-4D27-B805-2CC1B8C0A538")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct InteractionFilterEntityRefData : IComponentData, DKLHOFAAIEO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public Entity filterEntity;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0xD919D0", Offset = "0xD90BD0", VA = "0x180D919D0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x124E8B0", Offset = "0x124DAB0", VA = "0x18124E8B0", Slot = "5")]
			set
			{
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[TypeManager.ForcedStableTypeHash(15467295871228743847uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.RRGuid("C7E95AF7-DB7D-4432-8DAA-8F36EC6C4308")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct InteractionFilterNoneTagsData : IComponentData, DKLHOFAAIEO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public Entity noneTags;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0xD919D0", Offset = "0xD90BD0", VA = "0x180D919D0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x124E8B0", Offset = "0x124DAB0", VA = "0x18124E8B0", Slot = "5")]
			set
			{
			}
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[TypeManager.ForcedStableTypeHash(15012400804589552708uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.RRGuid("007F8815-C87C-4E6B-BC56-3BA0C4888E3D")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.StableTypeHash(15012400804589552708uL, 0u)]
	public struct OverrideObjectNetworkIdData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public uint networkIdBits;
	}
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	[RecRoom.DataLayer.RRGuid("30228348-77DF-48F6-B2EF-B0883D3E10CA")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[TypeManager.ForcedStableTypeHash(4540375434353162791uL)]
	public struct MakerPenHeldData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public bool makerPenHeld;
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[TypeManager.ForcedStableTypeHash(8459715919607487693uL)]
	[CompilerGenerated]
	[ConfigGroup("Object", 0)]
	[RecRoom.DataLayer.RRGuid("FB9853D6-6231-43FD-A754-00105DC30880")]
	[RecRoom.DataLayer.NetworkComponent(6, false)]
	public struct ObjectPolicyData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		[RecRoom.DataLayer.Default("new ScaleRestriction(1,1)")]
		[RecRoom.DataLayer.Field(2)]
		public ELOKJCCPGOO scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		[Config(null, 0)]
		[RecRoom.DataLayer.Default("ObjectPolicyUserConfigurableFlags.DEFAULT")]
		[RecRoom.DataLayer.Field(3)]
		public EGKABEIDDMN userConfigurableFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		[RecRoom.DataLayer.Default(NFJOAPCLPMN.Default)]
		[Config(null, 0)]
		[RecRoom.DataLayer.Field(4)]
		public NFJOAPCLPMN circuitsTransformBehavior;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default("ObjectPolicyEnumFlags.Default")]
		public IHGGIMFFGOL flags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[SerializationOnly]
	[RecRoom.DataLayer.RRGuid("01AEEF22-2473-4505-A473-0BBF009690B3")]
	[TypeManager.ForcedStableTypeHash(2965180940795077803uL)]
	[CompilerGenerated]
	public struct RemovedNetworkComponentsBuffer : IBufferElementData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public ulong stableTypeHash;
	}
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[TypeManager.ForcedStableTypeHash(17708500325183871236uL)]
	[RecRoom.DataLayer.StableTypeHash(17708500325183871236uL, 0u)]
	[CompilerGenerated]
	[RecRoom.DataLayer.RRGuid("617A903E-C2C2-467C-A138-287FDB487645")]
	public struct PlayerScopeData : IComponentData, DKLHOFAAIEO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public Entity playerScope;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public Entity Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0xD919D0", Offset = "0xD90BD0", VA = "0x180D919D0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x124E8B0", Offset = "0x124DAB0", VA = "0x18124E8B0", Slot = "5")]
			set
			{
			}
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xCDE2C0", Offset = "0xCDD4C0", VA = "0x180CDE2C0")]
		public static PlayerScopeData PDHAGBEBCNG(Entity entity)
		{
			return default(PlayerScopeData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[ConfigGroup("Physics", 0)]
	[TypeManager.ForcedStableTypeHash(16642773407304133105uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.StableTypeHash(16642773407304133105uL, 0u)]
	[RecRoom.DataLayer.RRGuid("F945B699-C9E5-4634-9F64-831484F4F3BD")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct PhysicsMaterialData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		[Config(null, 0)]
		[RecRoom.DataLayer.Default(10f)]
		[RecRoom.DataLayer.Field(1)]
		public float density;
	}
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	[RecRoom.DataLayer.StableTypeHash(10537432342869025182uL, 0u)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[TypeManager.ForcedStableTypeHash(10537432342869025182uL)]
	[RecRoom.DataLayer.RRGuid("A2E0AF0F-C284-47E6-9535-A67A29BF5730")]
	public struct ShapeConfigData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default(FEDMKIFLINL.None)]
		public FEDMKIFLINL flags;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool DynamicUVProjection
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x6FB5020", Offset = "0x6FB4220", VA = "0x186FB5020")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool PreventInvertedCreation
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x6FB5010", Offset = "0x6FB4210", VA = "0x186FB5010")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public bool NewBendLogic
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x7C02A90", Offset = "0x7C01C90", VA = "0x187C02A90")]
			get
			{
				return default(bool);
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[RecRoom.DataLayer.RRGuid("5C706BF1-9D50-456A-B974-521E8E2CC660")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[TypeManager.ForcedStableTypeHash(10917729582819845312uL)]
	[RecRoom.DataLayer.StableTypeHash(10917729582819845312uL, 0u)]
	[CompilerGenerated]
	public struct ShapeTypeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public OFACAOILFPJ shapeType;
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("36418781-DB47-4DE7-A138-CC88D1D795C0")]
	[TypeManager.ForcedStableTypeHash(5298506180484533559uL)]
	[RecRoom.DataLayer.StableTypeHash(5298506180484533559uL, 0u)]
	[CompilerGenerated]
	public struct SplinePointOrderData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public CFAEEBOPCFL order;

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0xCDE2C0", Offset = "0xCDD4C0", VA = "0x180CDE2C0")]
		public static SplinePointOrderData PDHAGBEBCNG(CFAEEBOPCFL value)
		{
			return default(SplinePointOrderData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("FCEE3BCD-9C10-4BF4-954A-0DCFE8810227")]
	[RecRoom.DataLayer.StableTypeHash(16368389834000856208uL, 0u)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(16368389834000856208uL)]
	public struct SplinePointParentData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public Entity spline;
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[RecRoom.DataLayer.RRGuid("5A6D38A4-1A58-4EB4-9C1B-06ADA0D44AFA")]
	[TypeManager.ForcedStableTypeHash(18095612727592564636uL)]
	[RecRoom.DataLayer.StableTypeHash(18095612727592564636uL, 0u)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[CompilerGenerated]
	public struct SplinePointPositionData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public float3 localPosition;
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("433F66B6-CC1C-4A8A-BF73-2B797440A8DB")]
	[RecRoom.DataLayer.StableTypeHash(1429513518619209486uL, 0u)]
	[TypeManager.ForcedStableTypeHash(1429513518619209486uL)]
	public struct SplinePointRotationData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default("new quaternion(0, 0, 0, 1f)")]
		public quaternion localRotation;
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[RecRoom.DataLayer.RRGuid("04CA3CCE-F121-4B5B-BC56-FE8E9C77F0F4")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.StableTypeHash(1238044349990854547uL, 0u)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(1238044349990854547uL)]
	public struct SplinePointScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default("new float3(1)")]
		public float3 localScale;
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	[RecRoom.DataLayer.StableTypeHash(4657247877648983868uL, 0u)]
	[RecRoom.DataLayer.RRGuid("E0610986-0F8F-494A-8C6E-8A2D2491B088")]
	[TypeManager.ForcedStableTypeHash(4657247877648983868uL)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct SplineShapeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public FLHGMAEFHJA parameters;
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[RecRoom.DataLayer.TombstonedFields(new int[] { 1 })]
	[RecRoom.DataLayer.RRGuid("73C344D9-D535-4753-9D9A-B6DEDE4079B0")]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(12332323170023439017uL)]
	[RecRoom.DataLayer.StableTypeHash(12332323170023439017uL, 0u)]
	public struct OMShapeContainerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		[RecRoom.DataLayer.Field(2)]
		[RecRoom.DataLayer.Default(true)]
		public bool canModifyWithCircuits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		[RecRoom.DataLayer.Field(3)]
		[RecRoom.DataLayer.Default(true)]
		public bool optimizedCollidersEnabled;
	}
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[TypeManager.ForcedStableTypeHash(17673274643717888315uL)]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	[RecRoom.DataLayer.RRGuid("2B5C4208-9113-4F65-B3A6-18EAE1FF3937")]
	[CompilerGenerated]
	public struct SerializedDataLayerVersionData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public int version;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
[Flags]
[RecRoom.DataLayer.Range(ILCFGLPCBBA.MIN, ILCFGLPCBBA.ALL)]
[RecRoom.DataLayer.RRGuid("CC657074-87FD-47F7-A7B0-F5CCE922A9D0")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
public enum ILCFGLPCBBA
{
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	IsAllowed = 1,
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	UseDefaultVisualEffects = 2,
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	DEFAULT = 2,
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	ALL = 3,
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	MAX = 3
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(5328722791392374178uL)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("34BA53CB-16FB-45DB-AA25-293CE7C8DAE4")]
	public struct ToolCleanupSettingsData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		[RecRoom.DataLayer.Default(15f)]
		[RecRoom.DataLayer.Field(1)]
		public float delay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		[RecRoom.DataLayer.Default(ILCFGLPCBBA.UseDefaultVisualEffects)]
		[RecRoom.DataLayer.Field(2)]
		public ILCFGLPCBBA toolCleanupFlags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	[RecRoom.DataLayer.TombstonedFields(new int[] { 2, 3 })]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(13768238190614302474uL)]
	[RecRoom.DataLayer.RRGuid("48C72ABE-383D-45C6-9610-773F2B4F84C6")]
	public struct ToolCleanupStatusData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public float cleanupStartTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		[RecRoom.DataLayer.Field(4)]
		[RecRoom.DataLayer.Default]
		public AOIGGABKAPL statusFlags;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
[Flags]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.RRGuid("E63050BA-D087-4027-99F8-4AFDEA229CD8")]
[RecRoom.DataLayer.Range(AOIGGABKAPL.None, AOIGGABKAPL.ALL)]
public enum AOIGGABKAPL
{
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	ForceCleanup = 1,
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	CleanupDone = 2,
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	CleanupPaused = 4,
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	ALL = 7,
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	MAX = 7
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(463077377357487319uL)]
	[RecRoom.DataLayer.RRGuid("021E8703-AAFD-4965-8C38-FF86663126D2")]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	public struct LocalDeformableScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default("new float3(1)")]
		public float3 localDeformationScale;

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x2ACF310", Offset = "0x2ACE510", VA = "0x182ACF310")]
		public LocalDeformableScaleData(float3 scale)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	[RecRoom.DataLayer.StableTypeHash(1369925932270831712uL, 0u)]
	[TypeManager.ForcedStableTypeHash(1369925932270831712uL)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("38AA9F1D-FD16-4B56-917C-3341D0EB1DF2")]
	public struct LocalPoseData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default("new quaternion(0,0,0,1)")]
		public quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		[RecRoom.DataLayer.Field(2)]
		[RecRoom.DataLayer.Default]
		public float3 localPosition;

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x51CF0A0", Offset = "0x51CE2A0", VA = "0x1851CF0A0")]
		public LocalPoseData(quaternion localRotation, float3 localPosition)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x7BFE930", Offset = "0x7BFDB30", VA = "0x187BFE930")]
		public static RigidTransform PDHAGBEBCNG(LocalPoseData poseData)
		{
			return default(RigidTransform);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x7BFE930", Offset = "0x7BFDB30", VA = "0x187BFE930")]
		public static LocalPoseData PDHAGBEBCNG(RigidTransform pose)
		{
			return default(LocalPoseData);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public static class OKFBFGHDCPO
{
	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x7C02610", Offset = "0x7C01810", VA = "0x187C02610")]
	public static LocalPoseData PKPEHGILJDK([In] this RigidTransform KJIOHKMJAPE)
	{
		return default(LocalPoseData);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x7C025E0", Offset = "0x7C017E0", VA = "0x187C025E0")]
	public static RigidTransform MALIFEOIGOK([In] this LocalPoseData KJIOHKMJAPE)
	{
		return default(RigidTransform);
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("0E9FADE9-751A-4A53-B455-4F8EA675754D")]
	[RecRoom.DataLayer.StableTypeHash(2720902521635056246uL, 0u)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(2720902521635056246uL)]
	public struct LocalUniformScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default(1f)]
		public float localUniformScale;
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[RecRoom.DataLayer.RRGuid("F01774C0-98E7-491E-AAA5-85B64AFFA182")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.StableTypeHash(5730545663584378555uL, 0u)]
	[TypeManager.ForcedStableTypeHash(5730545663584378555uL)]
	[CompilerGenerated]
	public struct TransformFlagsData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public ANPOCMELKCN transformHint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		[RecRoom.DataLayer.Field(2)]
		[RecRoom.DataLayer.Default]
		public JCCPFEAHFCB transformPriority;
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	[RecRoom.DataLayer.RRGuid("392BF0C9-F464-491A-8725-E4B5E5C4ECD4")]
	[RecRoom.DataLayer.DoNotGenerateComponentProperties]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(12583036596830542024uL)]
	public struct RRObjectPrefabData : ISharedComponentData, IEquatable<RRObjectPrefabData>, IComparable<RRObjectPrefabData>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public DDPHEKACOFI prefabType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		[RecRoom.DataLayer.Field(2)]
		[RecRoom.DataLayer.Default]
		public Guid prefabGuid;

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x7C02980", Offset = "0x7C01B80", VA = "0x187C02980")]
		public RRObjectPrefabData(Guid prefabGuid, DDPHEKACOFI prefabType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x7C02880", Offset = "0x7C01A80", VA = "0x187C02880", Slot = "4")]
		public readonly bool Equals(RRObjectPrefabData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x7C027C0", Offset = "0x7C019C0", VA = "0x187C027C0", Slot = "0")]
		public override readonly bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x7C02990", Offset = "0x7C01B90", VA = "0x187C02990")]
		public static bool operator ==(RRObjectPrefabData a, RRObjectPrefabData b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x7BFED70", Offset = "0x7BFDF70", VA = "0x187BFED70", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x7BFEB80", Offset = "0x7BFDD80", VA = "0x187BFEB80", Slot = "5")]
		public readonly int CompareTo(RRObjectPrefabData other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x7C028E0", Offset = "0x7C01AE0", VA = "0x187C028E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[TypeManager.ForcedStableTypeHash(17550159503907726442uL)]
	[RecRoom.DataLayer.RRGuid("FF90B503-A0B5-4B3D-BACF-046FA1456FBD")]
	public struct ReferenceGroupKindData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public HEGALGDCMOB kind;
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[TypeManager.ForcedStableTypeHash(18363292822319307914uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("2C78EEBE-6DD9-44FF-A70D-6C2EE9BB8FB3")]
	public struct ReferenceGroupOwnerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public Entity owner;
	}
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[RecRoom.DataLayer.RRGuid("177498E9-83A6-4C2E-A8C1-B1951B47E74D")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[TypeManager.ForcedStableTypeHash(11947588904347318594uL)]
	[CompilerGenerated]
	public struct ReferenceGroupReferenceBuffer : IBufferElementData, DKLHOFAAIEO, IEquatable<ReferenceGroupReferenceBuffer>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public Entity reference;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public Entity Entity
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0xD919D0", Offset = "0xD90BD0", VA = "0x180D919D0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x124E8B0", Offset = "0x124DAB0", VA = "0x18124E8B0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x7C02A80", Offset = "0x7C01C80", VA = "0x187C02A80", Slot = "6")]
		public bool Equals(ReferenceGroupReferenceBuffer other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x7C029F0", Offset = "0x7C01BF0", VA = "0x187C029F0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0xBB1DE0", Offset = "0xBB0FE0", VA = "0x180BB1DE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000071")]
public struct DIPMBGJOECA : IEqualityComparer<ReferenceGroupReferenceBuffer>
{
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public static DIPMBGJOECA LGHIFDBIJOC;

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x7BFFB80", Offset = "0x7BFED80", VA = "0x187BFFB80", Slot = "4")]
	public bool Equals(ReferenceGroupReferenceBuffer HGCMPGNMMIB, ReferenceGroupReferenceBuffer PIALGICKFLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0xAC71B0", Offset = "0xAC63B0", VA = "0x180AC71B0", Slot = "5")]
	public int GetHashCode(ReferenceGroupReferenceBuffer KFMNDOMPAMC)
	{
		return default(int);
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[RecRoom.DataLayer.RRGuid("DE12A401-BD29-4B00-A629-7EFBECEDCFDF")]
	[TypeManager.ForcedStableTypeHash(17466046755328781668uL)]
	[CompilerGenerated]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[InternalBufferCapacity(0)]
	public struct AuthoredUserTagReferenceBuffer : OOKMHKFNMNP, IBufferElementData, DKLHOFAAIEO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public Entity Child;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0xD919D0", Offset = "0xD90BD0", VA = "0x180D919D0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x124E8B0", Offset = "0x124DAB0", VA = "0x18124E8B0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x124E8B0", Offset = "0x124DAB0", VA = "0x18124E8B0")]
		public AuthoredUserTagReferenceBuffer(Entity entity)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xCDE2C0", Offset = "0xCDD4C0", VA = "0x180CDE2C0")]
		public static AuthoredUserTagReferenceBuffer PDHAGBEBCNG(Entity entity)
		{
			return default(AuthoredUserTagReferenceBuffer);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public interface OOKMHKFNMNP : IBufferElementData, DKLHOFAAIEO
{
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[RecRoom.DataLayer.RRGuid("00B7CB5E-4C0C-4D2C-AC95-78529EE58768")]
	[TypeManager.ForcedStableTypeHash(12148147190301245780uL)]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	[CompilerGenerated]
	public struct PersistentUserTagData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public FixedList32Bytes<int> tags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		[RecRoom.DataLayer.Default(false)]
		[RecRoom.DataLayer.Field(2)]
		public bool initalizedDefaults;
	}
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	[TypeManager.ForcedStableTypeHash(1859693175312uL)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("80D85A55-B2F6-4860-A851-62973DC10940")]
	[RecRoom.DataLayer.StableTypeHash(1859693175312uL, 0u)]
	[SwatchPrimaryKey]
	[CompilerGenerated]
	public struct UserTagNameData : IComponentData, IEquatable<UserTagNameData>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public FixedString32Bytes Value;

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x7C02BC0", Offset = "0x7C01DC0", VA = "0x187C02BC0")]
		public UserTagNameData(string value)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x7C02B80", Offset = "0x7C01D80", VA = "0x187C02B80")]
		public static UserTagNameData PDHAGBEBCNG(string value)
		{
			return default(UserTagNameData);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x7C02AA0", Offset = "0x7C01CA0", VA = "0x187C02AA0", Slot = "4")]
		public bool Equals(UserTagNameData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x7C02AD0", Offset = "0x7C01CD0", VA = "0x187C02AD0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x7C02B70", Offset = "0x7C01D70", VA = "0x187C02B70", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	[InternalBufferCapacity(0)]
	[TypeManager.ForcedStableTypeHash(2039749658960193818uL)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("1E609F72-38C4-433D-BB17-B718F89DF446")]
	[CompilerGenerated]
	[RuntimeOnly]
	public struct UserTagReferenceBuffer : OOKMHKFNMNP, IBufferElementData, DKLHOFAAIEO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		public Entity Child;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0xD919D0", Offset = "0xD90BD0", VA = "0x180D919D0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x124E8B0", Offset = "0x124DAB0", VA = "0x18124E8B0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x124E8B0", Offset = "0x124DAB0", VA = "0x18124E8B0")]
		public UserTagReferenceBuffer(Entity entity)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0xCDE2C0", Offset = "0xCDD4C0", VA = "0x180CDE2C0")]
		public static UserTagReferenceBuffer PDHAGBEBCNG(Entity entity)
		{
			return default(UserTagReferenceBuffer);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.StableTypeHash(1591066774816564574uL, 0u)]
	[CanDesync]
	[CompilerGenerated]
	[RecRoom.DataLayer.RRGuid("C36DDF08-CA52-4E33-8078-2F6E915D4FDA")]
	[TypeManager.ForcedStableTypeHash(1591066774816564574uL)]
	[ConfigGroup("Visual", 0)]
	public struct StandardRenderableVisualData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Field(1)]
		[Config(null, 0)]
		public OFLMEILHLBB color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		[RecRoom.DataLayer.Default]
		[Config(null, 0)]
		[RecRoom.DataLayer.Field(2)]
		public FCIAGNOBJCE material;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		[RecRoom.DataLayer.Field(3)]
		[Config(null, 0)]
		[RecRoom.DataLayer.Default]
		public float uvScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		[RecRoom.DataLayer.Field(4)]
		[RecRoom.DataLayer.Default]
		[Config(null, 0)]
		public float3 uvOffset;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.Range(NFJOAPCLPMN.NONE, NFJOAPCLPMN.COUNT)]
[RecRoom.DataLayer.RRGuid("6B598497-D68A-4CC9-9D41-09EF6B966499")]
public enum NFJOAPCLPMN
{
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	NONE = 0,
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	[Config("Default (can transform roots, children are static)", 0)]
	Default = 1,
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	[Config("Can Transform (chips like SetPosition can modify)", 0)]
	CircuitsCanTransform = 2,
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	[Config("Always Static (chips cannot modify transform)", 0)]
	AlwaysStatic = 3,
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	COUNT = 4,
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	MAX = 4
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.Range(0, 4)]
[RecRoom.DataLayer.RRGuid("17517E1A-CF1A-48C9-B6A5-F9E42C1B9E96")]
public enum AIMIJPAFDKE
{
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	Box = 1,
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	Sphere = 2,
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	Capsule = 3,
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	Mesh = 4,
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	COUNT = 5,
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	MAX = 4
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
[RecRoom.DataLayer.Range(CJMJJFMOKMN.NONE, CJMJJFMOKMN.ALL)]
[RecRoom.DataLayer.RRGuid("A13F5102-9259-42B9-B782-BB7CC33A0C4F")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[Flags]
public enum CJMJJFMOKMN
{
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	NONE = 0,
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	Object = 1,
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	Player = 2,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	Projectile = 4,
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	Vehicle = 8,
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	ALL = 0xF
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
[RecRoom.DataLayer.NetworkEnum(2, false)]
[RecRoom.DataLayer.RRGuid("F843A776-E042-43B7-8167-0C7A421062F8")]
[RecRoom.DataLayer.Range(0, 127)]
public enum NOFKHNNLBFH : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	[@Tooltip("Indicating it can be walked on and moved")]
	[Config("Dynamic (Environment)", 0)]
	IsDynamicEnvironment = 0,
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	[Config("Dynamic", -1)]
	IsDynamic = 10,
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	[Config("Dynamic (Ignore Static Geometry)", 0)]
	IsDynamicIgnoreStaticGeometry = 11,
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	[Config("Dynamic (Ignore Other Dynamic)", 0)]
	IsDynamicIgnoreOtherDynamic = 12,
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	[Config("Dynamic (Ignore Players)", 0)]
	IsDynamicIgnorePlayers = 13,
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	[Config("Dynamic (Ignore Most)", 0)]
	IsDynamicIgnoreMost = 14,
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	[Config("Enemy Collision", 0)]
	IsEnemyCollision = 30,
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	[Config("Enemy Projectile", 0)]
	IsEnemyProjectile = 31,
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	[Config("Vehicle Physics", 0)]
	IsVehicleCollision = 40,
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	[ConfigIgnore]
	STATIC = 100,
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	[ConfigIgnore]
	DECORATION = 101,
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	MAX = 127
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
[RecRoom.DataLayer.RRGuid("9ADF7A0D-D808-48A7-BFCB-3272FB5D8A52")]
[RecRoom.DataLayer.Range(PDFBMJELBFB.Off, PDFBMJELBFB.COUNT)]
[RecRoom.DataLayer.NetworkEnum(2, false)]
public enum PDFBMJELBFB : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	Off = 0,
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	Children = 1,
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	Hull = 2,
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	COUNT = 3,
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	MAX = 2
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.Range(0, 2)]
[RecRoom.DataLayer.RRGuid("3B156405-5769-4DB2-87EA-2B846AC4E584")]
public enum OFACAOILFPJ
{
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	Primitive = 1,
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	Spline = 2,
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	COUNT = 3,
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	MAX = 2
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[RecRoom.DataLayer.Range(CICBNKDBBEN.Pivot, CICBNKDBBEN.COUNT)]
[RecRoom.DataLayer.NetworkEnum(2, false)]
[RecRoom.DataLayer.RRGuid("61EFE94A-235A-4281-B938-1A5BE32A18B1")]
public enum CICBNKDBBEN : byte
{
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	Pivot = 0,
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	Bounds = 1,
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	COUNT = 2,
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	MAX = 1
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.Range(MHPIEANPOCL.EnabledForRole, MHPIEANPOCL.Disabled)]
[RecRoom.DataLayer.RRGuid("c0973732-e735-44cd-9727-a9a79bad01e3")]
public enum MHPIEANPOCL : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	EnabledForRole,
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	DisabledForRole,
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	Disabled
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.RRGuid("7E7D5AA1-2EC9-488B-8AB2-703F13BCB8CF")]
[RecRoom.DataLayer.Range(FGGMEDFADEL.NavMeshGenerator, FGGMEDFADEL.NavMeshBlocker)]
public enum FGGMEDFADEL
{
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	NavMeshGenerator = 0,
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	NavMeshIgnored = 1,
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	NavMeshBlocker = 2,
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	MAX = 2
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[Flags]
[RecRoom.DataLayer.Range(IHGGIMFFGOL.None, IHGGIMFFGOL.All)]
[RecRoom.DataLayer.RRGuid("7B493897-FE06-4FC8-AB72-8B7BF5A313D3")]
public enum IHGGIMFFGOL
{
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	All = 0x3FFF,
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	Default = 0x3FFF
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
[RecRoom.DataLayer.Range(0, JMIACHAENFH.COUNT)]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.RRGuid("4427686F-E636-4F43-91F7-6BC74DEC584E")]
public enum JMIACHAENFH
{
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	SupportsRotation,
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	SupportsDeformation,
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	SupportsScaling,
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	SupportsMirroring,
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	SupportsCloning,
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	SupportsRecoloring,
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	CanDestroy,
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	CanSaveIntoInventions,
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	SupportsRespawn,
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	SupportsMerging,
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	SupportsSplitting,
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	SupportsKeys,
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	CanEditWithMakerPen,
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	DEPRECATED_IsGrabbable,
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public static class JPMOKGJMIPJ
{
	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x7C021E0", Offset = "0x7C013E0", VA = "0x187C021E0")]
	public static void DEEMOOGCBGF(this IHGGIMFFGOL FFMDBMBLMEI, JMIACHAENFH ACGHCPFKPDF, bool PGEJJMOHEOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x7C02210", Offset = "0x7C01410", VA = "0x187C02210")]
	public static bool MJEAGAJKNHB(this IHGGIMFFGOL FFMDBMBLMEI, JMIACHAENFH ACGHCPFKPDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0xE1FBA0", Offset = "0xE1EDA0", VA = "0x180E1FBA0")]
	public static IHGGIMFFGOL LNOJAIDEDFK(this JMIACHAENFH ACGHCPFKPDF)
	{
		return default(IHGGIMFFGOL);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
[RecRoom.DataLayer.RRGuid("E3C51303-32F0-4EF4-8A66-C814E323653D")]
[RecRoom.DataLayer.Range(EGKABEIDDMN.NONE, EGKABEIDDMN.COUNT)]
[RecRoom.DataLayer.NetworkEnum(2, false)]
[Flags]
public enum EGKABEIDDMN
{
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	NONE = 0,
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	IsFrozen = 1,
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	IsGrabbable = 2,
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	COUNT = 3,
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	ALL = 3,
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	DEFAULT = 0
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
[RecRoom.DataLayer.Range(DDPHEKACOFI.None, 8000)]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.RRGuid("777AD204-3AC0-41CE-BDC0-894C5821B3B9")]
public enum DDPHEKACOFI
{
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	[Config("Container", 0)]
	Container = 1000,
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	[Config("Container", 0)]
	LegacyShapeContainer = 1001,
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	[Config("Container", 0)]
	CreationShapeContainer = 1002,
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
public static class IONIKJHIPOO
{
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	[CompilerGenerated]
	private sealed class FPIEBOGBBHB : IEnumerable<DDPHEKACOFI>, IEnumerable, IEnumerator<DDPHEKACOFI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		private DDPHEKACOFI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		private IEnumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		private DDPHEKACOFI System.Collections.Generic.IEnumerator<RecRoom.DataLayer.ObjectPrefabType>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0xA90990", Offset = "0xA8FB90", VA = "0x180A90990", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(DDPHEKACOFI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x7C018C0", Offset = "0x7C00AC0", VA = "0x187C018C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x137E0F0", Offset = "0x137D2F0", VA = "0x18137E0F0")]
		[DebuggerHidden]
		public FPIEBOGBBHB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x7C01910", Offset = "0x7C00B10", VA = "0x187C01910", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x7C01550", Offset = "0x7C00750", VA = "0x187C01550", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x7C014F0", Offset = "0x7C006F0", VA = "0x187C014F0")]
		private void DOCBGIOIEEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x7C01870", Offset = "0x7C00A70", VA = "0x187C01870", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x7C017D0", Offset = "0x7C009D0", VA = "0x187C017D0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<DDPHEKACOFI> System.Collections.Generic.IEnumerable<RecRoom.DataLayer.ObjectPrefabType>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x7C017D0", Offset = "0x7C009D0", VA = "0x187C017D0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000088")]
	[CompilerGenerated]
	private sealed class FEAFDBOPLDP : IEnumerable<DDPHEKACOFI>, IEnumerable, IEnumerator<DDPHEKACOFI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		private DDPHEKACOFI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		private DDPHEKACOFI <last>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private DDPHEKACOFI <i>5__3;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		private DDPHEKACOFI System.Collections.Generic.IEnumerator<RecRoom.DataLayer.ObjectPrefabType>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0xA90990", Offset = "0xA8FB90", VA = "0x180A90990", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(DDPHEKACOFI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x7C00E40", Offset = "0x7C00040", VA = "0x187C00E40", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x137E0F0", Offset = "0x137D2F0", VA = "0x18137E0F0")]
		[DebuggerHidden]
		public FEAFDBOPLDP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x7C00CF0", Offset = "0x7BFFEF0", VA = "0x187C00CF0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x7C00DF0", Offset = "0x7BFFFF0", VA = "0x187C00DF0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x7C00D50", Offset = "0x7BFFF50", VA = "0x187C00D50", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<DDPHEKACOFI> System.Collections.Generic.IEnumerable<RecRoom.DataLayer.ObjectPrefabType>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x7C00D50", Offset = "0x7BFFF50", VA = "0x187C00D50", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000089")]
	[CompilerGenerated]
	private sealed class FPELKFPLHPP : IEnumerable<DDPHEKACOFI>, IEnumerable, IEnumerator<DDPHEKACOFI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		private DDPHEKACOFI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		private IEnumerator<DDPHEKACOFI> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		private DDPHEKACOFI System.Collections.Generic.IEnumerator<RecRoom.DataLayer.ObjectPrefabType>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0xA90990", Offset = "0xA8FB90", VA = "0x180A90990", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(DDPHEKACOFI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x7C01410", Offset = "0x7C00610", VA = "0x187C01410", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x137E0F0", Offset = "0x137D2F0", VA = "0x18137E0F0")]
		[DebuggerHidden]
		public FPELKFPLHPP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x7C01460", Offset = "0x7C00660", VA = "0x187C01460", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x7C01080", Offset = "0x7C00280", VA = "0x187C01080", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x7C01030", Offset = "0x7C00230", VA = "0x187C01030")]
		private void DOCBGIOIEEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x7C013C0", Offset = "0x7C005C0", VA = "0x187C013C0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x7C01320", Offset = "0x7C00520", VA = "0x187C01320", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<DDPHEKACOFI> System.Collections.Generic.IEnumerable<RecRoom.DataLayer.ObjectPrefabType>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x7C01320", Offset = "0x7C00520", VA = "0x187C01320", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x7C01FD0", Offset = "0x7C011D0", VA = "0x187C01FD0")]
	[IteratorStateMachine(typeof(FPIEBOGBBHB))]
	public static IEnumerable<DDPHEKACOFI> LONFJLHBENL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x7C01F10", Offset = "0x7C01110", VA = "0x187C01F10")]
	[IteratorStateMachine(typeof(FEAFDBOPLDP))]
	public static IEnumerable<DDPHEKACOFI> KOPFMGBHDLD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x7C01F70", Offset = "0x7C01170", VA = "0x187C01F70")]
	[IteratorStateMachine(typeof(FPELKFPLHPP))]
	public static IEnumerable<DDPHEKACOFI> LCAOKFONBKN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public static class FHKPILNPKOH
{
	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x7C00EB0", Offset = "0x7C000B0", VA = "0x187C00EB0")]
	public static bool GAMFJBMDNDI(this RRObjectPrefabData AAIGIAMCPKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x7C00EE0", Offset = "0x7C000E0", VA = "0x187C00EE0")]
	public static bool GAMFJBMDNDI(this DDPHEKACOFI GDHKDBJPDLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x7C00F70", Offset = "0x7C00170", VA = "0x187C00F70")]
	public static bool PABBOFMGPMB(this RRObjectPrefabData AAIGIAMCPKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x7C00F40", Offset = "0x7C00140", VA = "0x187C00F40")]
	public static bool PABBOFMGPMB(this DDPHEKACOFI GDHKDBJPDLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x7C00E90", Offset = "0x7C00090", VA = "0x187C00E90")]
	public static IHPINLDMLGD DLLHJKCLEDI(this DDPHEKACOFI OBMOFEPEPAD)
	{
		return default(IHPINLDMLGD);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x7C00F30", Offset = "0x7C00130", VA = "0x187C00F30")]
	internal static LBKGOGPGLIE NGKEAAMIGOB(this IHPINLDMLGD BIAABFFGEBE)
	{
		return default(LBKGOGPGLIE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x7C00F10", Offset = "0x7C00110", VA = "0x187C00F10")]
	internal static LBKGOGPGLIE NGKEAAMIGOB(this DDPHEKACOFI OBMOFEPEPAD)
	{
		return default(LBKGOGPGLIE);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
internal enum LBKGOGPGLIE
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
public enum IHPINLDMLGD
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
public static class CKMAHGFJCHE
{
	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x7BFF580", Offset = "0x7BFE780", VA = "0x187BFF580")]
	public static bool NCBOKKECFHE(this IHPINLDMLGD BIAABFFGEBE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
[RecRoom.DataLayer.NetworkEnum(3, false)]
[RecRoom.DataLayer.Range(0, JMAPILMLMLJ.ALL)]
[RecRoom.DataLayer.RRGuid("7A0D34B5-FFE5-4C21-BB0C-CB3EBA34C797")]
[Flags]
public enum JMAPILMLMLJ : ushort
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
	[TypeManager.ForcedStableTypeHash(8060729269509364919uL)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.StableTypeHash(8060729269509364919uL, 0u)]
	[RecRoom.DataLayer.RRGuid("5D4503E7-6CC4-4938-8840-1B859C391878")]
	[CompilerGenerated]
	public struct PrimitiveShapeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public AJCKMHEMCBO shapeType;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.RRGuid("517224CC-0A79-4FE9-B048-53C37955D823")]
[RecRoom.DataLayer.Range(-1, 38)]
public enum AJCKMHEMCBO
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
[RecRoom.DataLayer.RRGuid("3D27DF09-CAE2-4C3F-B808-03AD605F8E98")]
[RecRoom.DataLayer.Range(HEGALGDCMOB.None, HEGALGDCMOB.COUNT)]
[RecRoom.DataLayer.NetworkEnum(1, false)]
public enum HEGALGDCMOB : byte
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
[RecRoom.DataLayer.RRGuid("1829B7EA-C0EA-4E77-8EB2-BA23E995C860")]
[RecRoom.DataLayer.Range(0, 7)]
[Flags]
[RecRoom.DataLayer.NetworkEnum(1, false)]
public enum FEDMKIFLINL
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
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.Range(0, 7)]
[Flags]
public enum NDNJLMAHJJI
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
[RecRoom.DataLayer.RRGuid("72742F9B-D48E-4CED-B403-444201FFEE66")]
[RecRoom.DataLayer.Range(0, 1)]
[Flags]
[RecRoom.DataLayer.NetworkEnum(1, false)]
public enum ANPOCMELKCN
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
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.RRGuid("C5BE1CDA-5EF5-4EBF-BC7E-3E3510C68A7F")]
[RecRoom.DataLayer.Range(-2, 2)]
public enum JCCPFEAHFCB
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
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.Range(int.MinValue, int.MaxValue)]
public enum OFLMEILHLBB
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
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.Range(-1, 31)]
[RecRoom.DataLayer.RRGuid("C57BE511-BA1A-4D83-BA58-303F34F4DE74")]
public enum FCIAGNOBJCE
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
public interface FBHDFIIEOKK : OCLOANDEEPK
{
	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	[RecRoom.DataLayer.Field(1)]
	[RecRoom.DataLayer.Key("SBDScale")]
	[RecRoom.DataLayer.Default]
	[ProtoProp("PersistenceViewData.SandboxDeformationData.Deformation", typeof(ILGHBGMLPEL))]
	[Set.Auth]
	float3 NONFLPGEECD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action MIGOFFBIAPB;
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
[RecRoom.DataLayer.NetworkStruct(1, false)]
[RecRoom.DataLayer.RRGuid("112F004A-C92F-4055-99F9-D430EC13FE3C")]
public struct CFAEEBOPCFL : IComparable<CFAEEBOPCFL>, IEquatable<CFAEEBOPCFL>
{
	[Cpp2IlInjected.Token(Token = "0x4000264")]
	public static readonly CFAEEBOPCFL BCEMEONNHIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000265")]
	[RecRoom.DataLayer.Field(1)]
	public uint HEEBAJECGGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000266")]
	[RecRoom.DataLayer.Field(2)]
	public uint JJHCPMBFLLE;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	private readonly uint CIBANLLNKMK
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x7BFEDF0", Offset = "0x7BFDFF0", VA = "0x187BFEDF0")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public readonly bool APFGOMCKPFB
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x7BFEE00", Offset = "0x7BFE000", VA = "0x187BFEE00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x7BFF520", Offset = "0x7BFE720", VA = "0x187BFF520")]
	public CFAEEBOPCFL(int HEEBAJECGGJ, int HCJAHOCLNIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x7BFF520", Offset = "0x7BFE720", VA = "0x187BFF520")]
	public CFAEEBOPCFL(uint HEEBAJECGGJ, uint HCJAHOCLNIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x7BFF4A0", Offset = "0x7BFE6A0", VA = "0x187BFF4A0")]
	private CFAEEBOPCFL(uint HEEBAJECGGJ, uint HCJAHOCLNIN, bool NFAPLFNBJPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x7BFF330", Offset = "0x7BFE530", VA = "0x187BFF330")]
	public CFAEEBOPCFL OHJCHMBLJBH(int GJBFKFHLHKP = 1)
	{
		return default(CFAEEBOPCFL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x7BFEE30", Offset = "0x7BFE030", VA = "0x187BFEE30")]
	public CFAEEBOPCFL DFBHPNOCMKG(int GJBFKFHLHKP = 1)
	{
		return default(CFAEEBOPCFL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x7BFF030", Offset = "0x7BFE230", VA = "0x187BFF030")]
	public static CFAEEBOPCFL MKANHGNIJBB(CFAEEBOPCFL KEAFHNNEEAN, CFAEEBOPCFL FNKKBNJEBAC)
	{
		return default(CFAEEBOPCFL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x7BFEEA0", Offset = "0x7BFE0A0", VA = "0x187BFEEA0")]
	private static ulong ELGCBFEFPEF(ulong BGPKBCGBDMP, ulong NIJBGCGEGBN)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x7BFEE10", Offset = "0x7BFE010", VA = "0x187BFEE10", Slot = "4")]
	public int CompareTo(CFAEEBOPCFL CMOCFNBHPLJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x7BFEF00", Offset = "0x7BFE100", VA = "0x187BFEF00", Slot = "0")]
	public override bool Equals(object KFMNDOMPAMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x7BFF3C0", Offset = "0x7BFE5C0", VA = "0x187BFF3C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x7BFEEE0", Offset = "0x7BFE0E0", VA = "0x187BFEEE0", Slot = "5")]
	public bool Equals(CFAEEBOPCFL CMOCFNBHPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x7BFEFA0", Offset = "0x7BFE1A0", VA = "0x187BFEFA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x3AE8700", Offset = "0x3AE7900", VA = "0x183AE8700")]
	public static bool EEDHALGLIEL(CFAEEBOPCFL KEAFHNNEEAN, CFAEEBOPCFL FNKKBNJEBAC)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x7BFEFF0", Offset = "0x7BFE1F0", VA = "0x187BFEFF0")]
	public static bool JGFOFPDALHN(CFAEEBOPCFL KEAFHNNEEAN, CFAEEBOPCFL FNKKBNJEBAC)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x7BFF010", Offset = "0x7BFE210", VA = "0x187BFF010")]
	public static bool LIMKPKGLNBA(CFAEEBOPCFL KEAFHNNEEAN, CFAEEBOPCFL FNKKBNJEBAC)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x7BFF3A0", Offset = "0x7BFE5A0", VA = "0x187BFF3A0")]
	public static bool PNGIKFAGIPP(CFAEEBOPCFL KEAFHNNEEAN, CFAEEBOPCFL FNKKBNJEBAC)
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
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x1102FD0", Offset = "0x11021D0", VA = "0x181102FD0")]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x13066A0", Offset = "0x13058A0", VA = "0x1813066A0")]
			set
			{
			}
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x1102FD0", Offset = "0x11021D0", VA = "0x181102FD0")]
		public static Guid PDHAGBEBCNG(NetworkGuid DJOIAEMCFDK)
		{
			return default(Guid);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x1102FD0", Offset = "0x11021D0", VA = "0x181102FD0")]
		public static NetworkGuid PDHAGBEBCNG(Guid DJOIAEMCFDK)
		{
			return default(NetworkGuid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x7C02590", Offset = "0x7C01790", VA = "0x187C02590", Slot = "4")]
		public bool Equals(NetworkGuid CMOCFNBHPLJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x5490CD0", Offset = "0x548FED0", VA = "0x185490CD0", Slot = "5")]
		public int CompareTo(NetworkGuid CMOCFNBHPLJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x7C025C0", Offset = "0x7C017C0", VA = "0x187C025C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
[RecRoom.DataLayer.RRGuid("9F5F33BE-7C0A-4870-9CE0-BA79440E7F98")]
[RecRoom.DataLayer.NetworkStruct(1, false)]
public struct ELOKJCCPGOO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000268")]
	[RecRoom.DataLayer.Field(1)]
	public bool NPFLOGOKNBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000269")]
	[RecRoom.DataLayer.Field(2)]
	public float3 CBHEEDCGPOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400026A")]
	[RecRoom.DataLayer.Field(3)]
	public float3 HKMPDEDONHF;

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x7BFBF80", Offset = "0x7BFB180", VA = "0x187BFBF80")]
	public ELOKJCCPGOO(float FHHDCGHGHIP, float AFOBMPBBEDH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
[RecRoom.DataLayer.NetworkStruct(1, false)]
[RecRoom.DataLayer.RRGuid("35984D5B-ACBD-4389-A94B-840070A871E2")]
public struct FLHGMAEFHJA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400026B")]
	[RecRoom.DataLayer.Field(1)]
	public float JEGINGABLBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400026C")]
	[RecRoom.DataLayer.Field(2)]
	public int GGHELHBAIFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400026D")]
	[RecRoom.DataLayer.Field(3)]
	public NDNJLMAHJJI FFMDBMBLMEI;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public bool ADDNJIJFNEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x7C01000", Offset = "0x7C00200", VA = "0x187C01000")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x7C00FA0", Offset = "0x7C001A0", VA = "0x187C00FA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public bool IAFBBNJPGDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x7C00FF0", Offset = "0x7C001F0", VA = "0x187C00FF0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x7C01010", Offset = "0x7C00210", VA = "0x187C01010")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public bool FGNNFPEONOP
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x7C00FE0", Offset = "0x7C001E0", VA = "0x187C00FE0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x7C00FC0", Offset = "0x7C001C0", VA = "0x187C00FC0")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
public struct DPGDOGEFGCI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400026E")]
	public BEJMLJNBJMK ODILGJPAECC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400026F")]
	public int BHPPGGEOANJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000270")]
	public bool PEKINICHOKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD")]
	[Cpp2IlInjected.Token(Token = "0x4000271")]
	public bool MBBJIMEKMNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE")]
	[Cpp2IlInjected.Token(Token = "0x4000272")]
	public bool MAFGMGLPPDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000273")]
	public Vector3 MILMNOPOIGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000274")]
	public Quaternion DDKKAJIGLLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000275")]
	public bool JBELKPPKLJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000276")]
	public Vector3 NONFLPGEECD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000277")]
	public Vector3 JCPNDHLLKPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000278")]
	public Vector3 JMFCCBNDHLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000279")]
	public bool HBMCDKPHAOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400027A")]
	public ViewId JLOOLFKPNMH;

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x7C00100", Offset = "0x7BFF300", VA = "0x187C00100", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
public struct BKIPAKIMEBM : IEquatable<BKIPAKIMEBM>, IComparable<BKIPAKIMEBM>
{
	[Cpp2IlInjected.Token(Token = "0x400027B")]
	public static readonly int PGNBJKFAMMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400027C")]
	public RRObjectPrefabData IJDBKPEJDOI;

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x7BFEDA0", Offset = "0x7BFDFA0", VA = "0x187BFEDA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x7BFEC00", Offset = "0x7BFDE00", VA = "0x187BFEC00", Slot = "4")]
	public bool Equals(BKIPAKIMEBM CMOCFNBHPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x7BFEC70", Offset = "0x7BFDE70", VA = "0x187BFEC70", Slot = "0")]
	public override bool Equals(object KFMNDOMPAMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x7BFED70", Offset = "0x7BFDF70", VA = "0x187BFED70", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x7BFEB80", Offset = "0x7BFDD80", VA = "0x187BFEB80", Slot = "5")]
	public int CompareTo(BKIPAKIMEBM CMOCFNBHPLJ)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
internal class EILMMKDGNFD : ContainerPropertyBag<DNNLAHBGMBD>
{
	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x7C00A90", Offset = "0x7BFFC90", VA = "0x187C00A90")]
	public EILMMKDGNFD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
internal class MEJFJKBFBOC : ContainerPropertyBag<RRObjectPrefabData>
{
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	private class EKPNJKNLLDE : Property<RRObjectPrefabData, DDPHEKACOFI>
	{
		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public override string KGCJIDMKOBH
		{
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x7C00BE0", Offset = "0x7BFFDE0", VA = "0x187C00BE0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public override bool JNOIOHADNLB
		{
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0xA4C7C0", Offset = "0xA4B9C0", VA = "0x180A4C7C0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x7C00AF0", Offset = "0x7BFFCF0", VA = "0x187C00AF0")]
		public EKPNJKNLLDE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x2295500", Offset = "0x2294700", VA = "0x182295500", Slot = "14")]
		public override DDPHEKACOFI GetValue(RRObjectPrefabData MBLPEFIMNGA)
		{
			return default(DDPHEKACOFI);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x7BFDE30", Offset = "0x7BFD030", VA = "0x187BFDE30", Slot = "15")]
		public override void SetValue(RRObjectPrefabData MBLPEFIMNGA, DDPHEKACOFI KJIOHKMJAPE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	private class BFOGACKAKPP : Property<RRObjectPrefabData, Guid>
	{
		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public override string KGCJIDMKOBH
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x7BFEAC0", Offset = "0x7BFDCC0", VA = "0x187BFEAC0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public override bool JNOIOHADNLB
		{
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0xA4C7C0", Offset = "0xA4B9C0", VA = "0x180A4C7C0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x7BFE9D0", Offset = "0x7BFDBD0", VA = "0x187BFE9D0")]
		public BFOGACKAKPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x2A5D500", Offset = "0x2A5C700", VA = "0x182A5D500", Slot = "14")]
		public override Guid GetValue(RRObjectPrefabData MBLPEFIMNGA)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x7BFE9C0", Offset = "0x7BFDBC0", VA = "0x187BFE9C0", Slot = "15")]
		public override void SetValue(RRObjectPrefabData MBLPEFIMNGA, Guid KJIOHKMJAPE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x7C02300", Offset = "0x7C01500", VA = "0x187C02300")]
	public MEJFJKBFBOC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
internal class DJNAANDBBGJ : ContainerPropertyBag<Guid>
{
	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x7BFFBA0", Offset = "0x7BFEDA0", VA = "0x187BFFBA0")]
	public DJNAANDBBGJ()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x7C02640", Offset = "0x7C01840", VA = "0x187C02640")]
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
