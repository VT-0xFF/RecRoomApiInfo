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
		[Cpp2IlInjected.Address(RVA = "0xA530A0", Offset = "0xA518A0", VA = "0x180A530A0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA530A0", Offset = "0xA518A0", VA = "0x180A530A0")]
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
	public class LogRegistrationIndex : HJMIPPBHOKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7F4D140", Offset = "0x7F4B940", VA = "0x187F4D140", Slot = "4")]
		public override void KELFLPPCOLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA530A0", Offset = "0xA518A0", VA = "0x180A530A0")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct MOOOHEJHAAP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private bool MFNJNHGELCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private ViewId HEFGNKGLBJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private int BJCMHPBMOOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private bool MBAMEPAOIHD;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7F4D8D0", Offset = "0x7F4C0D0", VA = "0x187F4D8D0")]
	public MOOOHEJHAAP(ViewId HEFGNKGLBJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7F4D890", Offset = "0x7F4C090", VA = "0x187F4D890")]
	public MOOOHEJHAAP(int BJCMHPBMOOK, bool MBAMEPAOIHD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7F4D7B0", Offset = "0x7F4BFB0", VA = "0x187F4D7B0")]
	public ViewId AKIGNNFLIBL([Optional] ViewId FKIHKDELPAN)
	{
		return default(ViewId);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class MNNEDONPDKF
{
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly Guid FENDFJLGGDM;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static readonly Guid PEODGIAEJGL;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static readonly Guid ADNFHLILHNI;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public static readonly Guid GAJBJHKNGPO;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly Guid EOJEMLBCPOJ;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public static readonly Dictionary<string, Guid> CGPLJLBMOHE;

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static readonly RRObjectPrefabData MBBIAMEEKKP;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly RRObjectPrefabData BENMIFLEDPO;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly RRObjectPrefabData IBLMJJNALHL;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7F4D2F0", Offset = "0x7F4BAF0", VA = "0x187F4D2F0")]
	public static Guid MNGIEFEECBN(string HPANEBBHGAC)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7F4D260", Offset = "0x7F4BA60", VA = "0x187F4D260")]
	public static RRObjectPrefabData JICHFBJBNOH(OMOMKAHPFJK CEPGAJKBPDM)
	{
		return default(RRObjectPrefabData);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7F4D210", Offset = "0x7F4BA10", VA = "0x187F4D210")]
	public static RRObjectPrefabData GCAJPAOLMBB(OMOMKAHPFJK CEPGAJKBPDM)
	{
		return default(RRObjectPrefabData);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7F4D2D0", Offset = "0x7F4BAD0", VA = "0x187F4D2D0")]
	public static RRObjectPrefabData JMGALCEIGKJ(Guid JMHOEKKPCPG)
	{
		return default(RRObjectPrefabData);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[DefaultMember("Item")]
public class JEOCDAOJLCO : IComponentData, ICloneable, MDOHEKEJMDJ
{
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static readonly BMELPJIFPCL GLHOMCPEEHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly Dictionary<int, object> IMINNNCPCJF;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public Dictionary<int, object> KFMKJLCMCLK
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public object NOJAFKJLFLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7F4CD70", Offset = "0x7F4B570", VA = "0x187F4CD70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x7F4CE20", Offset = "0x7F4B620", VA = "0x187F4CE20")]
	public JEOCDAOJLCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0xA2D2A0", Offset = "0xA2BAA0", VA = "0x180A2D2A0")]
	public JEOCDAOJLCO(Dictionary<int, object> IMINNNCPCJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7F4CC10", Offset = "0x7F4B410", VA = "0x187F4CC10", Slot = "5")]
	public bool IKEJFGHDLPJ(KAMCAEPAIHM MNMCNOJCKAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7F4CC70", Offset = "0x7F4B470", VA = "0x187F4CC70", Slot = "6")]
	public void PDKFKOKNBKI(BMELPJIFPCL GLHOMCPEEHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x3A5AD10", Offset = "0x3A59510", VA = "0x183A5AD10")]
	public void MJDGHPKEDKD<T>(KAMCAEPAIHM MNMCNOJCKAF, T MGONBEDEDON, [Optional] T GJPLADDCFJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3A5B240", Offset = "0x3A59A40", VA = "0x183A5B240")]
	public void NNLOAAEAPBJ<T>(KAMCAEPAIHM MNMCNOJCKAF, T MGONBEDEDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7F4CBB0", Offset = "0x7F4B3B0", VA = "0x187F4CBB0")]
	public void HKOLMKDGPPH(KAMCAEPAIHM MNMCNOJCKAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7F4CB40", Offset = "0x7F4B340", VA = "0x187F4CB40", Slot = "4")]
	public object Clone()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum KAMCAEPAIHM : byte
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
public struct LOALOHBCHLL<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly KAMCAEPAIHM MNMCNOJCKAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly T GJPLADDCFJL;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x4C5E6F0", Offset = "0x4C5CEF0", VA = "0x184C5E6F0")]
	public LOALOHBCHLL(KAMCAEPAIHM MNMCNOJCKAF, T GJPLADDCFJL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x533EF60", Offset = "0x533D760", VA = "0x18533EF60")]
	public static LOALOHBCHLL<T> KEINEINMKGA(KAMCAEPAIHM MNMCNOJCKAF)
	{
		return default(LOALOHBCHLL<T>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x533ED70", Offset = "0x533D570", VA = "0x18533ED70")]
	public static LOALOHBCHLL<T> KEINEINMKGA((KAMCAEPAIHM key, T value) HBMOFOICGEH)
	{
		return default(LOALOHBCHLL<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface MDOHEKEJMDJ
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IKEJFGHDLPJ(KAMCAEPAIHM MNMCNOJCKAF);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PDKFKOKNBKI(BMELPJIFPCL GLHOMCPEEHH);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[DebuggerTypeProxy(typeof(GPCCBLHBOCB))]
[DebuggerDisplay("Count = {Count}")]
public struct APNNOCBGIPF : IEnumerable<object>, IEnumerable, MDOHEKEJMDJ
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	private class GPCCBLHBOCB : Dictionary<string, object>
	{
	}

	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private static readonly BMELPJIFPCL GLHOMCPEEHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private Dictionary<int, object> JCPNJLMMOLN;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool AGNMEGAEAJC
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x182E280", Offset = "0x182CA80", VA = "0x18182E280")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int JAJBNKBAONK
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7F4A630", Offset = "0x7F48E30", VA = "0x187F4A630")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7F4A5B0", Offset = "0x7F48DB0", VA = "0x187F4A5B0")]
	public static APNNOCBGIPF INHDMBAMCNE()
	{
		return default(APNNOCBGIPF);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0xDB8C40", Offset = "0xDB7440", VA = "0x180DB8C40")]
	public APNNOCBGIPF([Optional] Dictionary<int, object> JCPNJLMMOLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x41F5E40", Offset = "0x41F4640", VA = "0x1841F5E40")]
	public void GGGBGBDKNKJ<T>(LOALOHBCHLL<T> MNMCNOJCKAF, T? MGONBEDEDON) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x41F5C60", Offset = "0x41F4460", VA = "0x1841F5C60")]
	public void GGGBGBDKNKJ<T>((LOALOHBCHLL<T> key, T value) GGIHKFIOAOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x41F5AF0", Offset = "0x41F42F0", VA = "0x1841F5AF0")]
	public void GGGBGBDKNKJ<T>(LOALOHBCHLL<T> MNMCNOJCKAF, T MGONBEDEDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7F4A210", Offset = "0x7F48A10", VA = "0x187F4A210")]
	public void CBOMIAJEOHK(APNNOCBGIPF GJKNNKIANJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7F4A4D0", Offset = "0x7F48CD0", VA = "0x187F4A4D0")]
	private void HNPKBJNJFKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x41F7980", Offset = "0x41F6180", VA = "0x1841F7980")]
	public bool PLBNMDLFKAN<T>(LOALOHBCHLL<T> MNMCNOJCKAF, [Out] T MGONBEDEDON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x41F7230", Offset = "0x41F5A30", VA = "0x1841F7230", Slot = "8")]
	public bool PLBNMDLFKAN<T>(KAMCAEPAIHM MNMCNOJCKAF, [Out] T MGONBEDEDON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x41F6F30", Offset = "0x41F5730", VA = "0x1841F6F30")]
	public T MMOADGANLAE<T>(LOALOHBCHLL<T> MNMCNOJCKAF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x41F6E10", Offset = "0x41F5610", VA = "0x1841F6E10")]
	public bool IKEJFGHDLPJ<T>(LOALOHBCHLL<T> MNMCNOJCKAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7F4A550", Offset = "0x7F48D50", VA = "0x187F4A550", Slot = "6")]
	public bool IKEJFGHDLPJ(KAMCAEPAIHM MNMCNOJCKAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x41F6B00", Offset = "0x41F5300", VA = "0x1841F6B00")]
	public void HKOLMKDGPPH<T>(LOALOHBCHLL<T> MNMCNOJCKAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7F4A480", Offset = "0x7F48C80", VA = "0x187F4A480")]
	public void HKOLMKDGPPH(KAMCAEPAIHM MNMCNOJCKAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0xDB8D70", Offset = "0xDB7570", VA = "0x180DB8D70")]
	public Dictionary<int, object> BACLJAEPMIK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7F4A420", Offset = "0x7F48C20", VA = "0x187F4A420", Slot = "4")]
	public IEnumerator<object> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7F4A770", Offset = "0x7F48F70", VA = "0x187F4A770", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7F4A680", Offset = "0x7F48E80", VA = "0x187F4A680", Slot = "7")]
	public void PDKFKOKNBKI(BMELPJIFPCL GLHOMCPEEHH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public enum LDMCDPNNEOE
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
public interface HDJJIILNIDG
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public enum BHOBMNLOJHN
	{
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		Entity,
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		Prefab
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	LocalId APKCJCBKCMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	RRObjectPrefabData GKBOCMCDPMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HEKKDJDLHED(params string[] LKKCBIFCBED);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NLIGMABKNBJ(LDMCDPNNEOE FECBGFDGPKP, BHOBMNLOJHN MFMCIMMKBLC = BHOBMNLOJHN.Entity);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JDEKLHIGFDK(Type CEPGAJKBPDM, ReadOnlySpan<byte> IMINNNCPCJF, int NAPFLDCMKIC, BHOBMNLOJHN MFMCIMMKBLC = BHOBMNLOJHN.Entity);

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void COHOKOIFPJG(Type CEPGAJKBPDM, BHOBMNLOJHN MFMCIMMKBLC = BHOBMNLOJHN.Entity);

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void DFCPIGDNHLK(LDMCDPNNEOE FECBGFDGPKP, BHOBMNLOJHN MFMCIMMKBLC = BHOBMNLOJHN.Entity);

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool NBDENJMEDMA(LDMCDPNNEOE FECBGFDGPKP);

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void NKFGOCBDMOD(bool KHCGAHGHNKM, BHOBMNLOJHN MFMCIMMKBLC = BHOBMNLOJHN.Entity);

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void HABEJLOEFAG();

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void BGFACCDGJBP(Type CEPGAJKBPDM);

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "11")]
	DLEFIPJOGKA EGKMFCNGELO(Type CEPGAJKBPDM);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class BNMMJEPOMJA
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7F4AD30", Offset = "0x7F49530", VA = "0x187F4AD30")]
	public static bool KIHGOJFPMEK(this HDJJIILNIDG MJAGIMDGJBK, LDMCDPNNEOE LCPLPGNINPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7F4ACD0", Offset = "0x7F494D0", VA = "0x187F4ACD0")]
	public static void KEAIIGPAGGN(this HDJJIILNIDG MJAGIMDGJBK, HDJJIILNIDG.BHOBMNLOJHN MFMCIMMKBLC = HDJJIILNIDG.BHOBMNLOJHN.Entity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7F4AC70", Offset = "0x7F49470", VA = "0x187F4AC70")]
	public static void FPIGNEMMGIJ(this HDJJIILNIDG MJAGIMDGJBK, HDJJIILNIDG.BHOBMNLOJHN MFMCIMMKBLC = HDJJIILNIDG.BHOBMNLOJHN.Entity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3737FC0", Offset = "0x37367C0", VA = "0x183737FC0")]
	public static void PNPDNDEELFK<T>(this HDJJIILNIDG MJAGIMDGJBK, HDJJIILNIDG.BHOBMNLOJHN MFMCIMMKBLC = HDJJIILNIDG.BHOBMNLOJHN.Entity) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3735F90", Offset = "0x3734790", VA = "0x183735F90")]
	public static void FLFBMHOAHED<T>(this HDJJIILNIDG MJAGIMDGJBK, HDJJIILNIDG.BHOBMNLOJHN MFMCIMMKBLC = HDJJIILNIDG.BHOBMNLOJHN.Entity) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3737EB0", Offset = "0x37366B0", VA = "0x183737EB0")]
	public static void KFOPKJBENKD<T>(this HDJJIILNIDG MJAGIMDGJBK, bool GNGILFBJLGH, HDJJIILNIDG.BHOBMNLOJHN MFMCIMMKBLC = HDJJIILNIDG.BHOBMNLOJHN.Entity) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x3735FC0", Offset = "0x37347C0", VA = "0x183735FC0")]
	public static void JDEKLHIGFDK<T>(this HDJJIILNIDG MJAGIMDGJBK, T MGONBEDEDON, HDJJIILNIDG.BHOBMNLOJHN MFMCIMMKBLC = HDJJIILNIDG.BHOBMNLOJHN.Entity) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3735DB0", Offset = "0x37345B0", VA = "0x183735DB0")]
	public static void COHOKOIFPJG<T>(this HDJJIILNIDG MJAGIMDGJBK, HDJJIILNIDG.BHOBMNLOJHN MFMCIMMKBLC = HDJJIILNIDG.BHOBMNLOJHN.Entity) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3735CC0", Offset = "0x37344C0", VA = "0x183735CC0")]
	public static void BGFACCDGJBP<T>(this HDJJIILNIDG MJAGIMDGJBK) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3737F20", Offset = "0x3736720", VA = "0x183737F20")]
	public static void LCIGFIONBPN<T>(this HDJJIILNIDG MJAGIMDGJBK, LocalId MIKNGKGCFKJ, HDJJIILNIDG.BHOBMNLOJHN MFMCIMMKBLC = HDJJIILNIDG.BHOBMNLOJHN.Entity) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x37360A0", Offset = "0x37348A0", VA = "0x1837360A0")]
	private static void JDEKLHIGFDK<T>(this HDJJIILNIDG MJAGIMDGJBK, Type CEPGAJKBPDM, T MGONBEDEDON, HDJJIILNIDG.BHOBMNLOJHN MFMCIMMKBLC = HDJJIILNIDG.BHOBMNLOJHN.Entity) where T : struct
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct ELMNHFBGKHN
{
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface FLIJOCAGNHH
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	Entity JDCDJCPFDCE
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
public interface PJJHFEPBJLP
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "0")]
	void PreBake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Bake(HDJJIILNIDG MJAGIMDGJBK);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface GODKPINLIBP
{
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	DLEFIPJOGKA BDKDNGLBOBN(Type CEPGAJKBPDM);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class HHPKKPBDGLI
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x3A04290", Offset = "0x3A02A90", VA = "0x183A04290")]
	public static void BDKDNGLBOBN<T>(this GODKPINLIBP MJAGIMDGJBK, [Out] T MGONBEDEDON) where T : DLEFIPJOGKA
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface DLEFIPJOGKA
{
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class FLMFGNFKPDH
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x39CCA70", Offset = "0x39CB270", VA = "0x1839CCA70")]
	public static void LNHIJIIGKCC<T>(this T BIGNAJOAKMM, HDJJIILNIDG MJAGIMDGJBK) where T : DLEFIPJOGKA, KNEGIOFLHFH
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x39CCA30", Offset = "0x39CB230", VA = "0x1839CCA30")]
	public static bool IOJPAHEFDKJ<T>(this T LFCOMABKENF) where T : DLEFIPJOGKA
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface KNEGIOFLHFH
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	Type AFGNFEIKJAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HBCBFICEHBC(DLEFIPJOGKA LFCOMABKENF);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface HKACGCBLIKC : PJJHFEPBJLP
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void InitNetworkData(GODKPINLIBP MJAGIMDGJBK);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface LMNKAAGCLLK : DLEFIPJOGKA
{
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface ABCPNDDIMEF
{
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BELBHFHAHKH(GBNNBLFIGLH FIOLDALLLFF);

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PBKKEHFAMBG(GBNNBLFIGLH FIOLDALLLFF);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface BKMLAMEFBLM
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	ViewId HAHHANMGHEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface AEGIMLOKCDC : BKMLAMEFBLM, JJIBMHKNOBJ
{
	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void Initialize(ViewId JNLMNIFMELA, ViewId LKGJHOBIBKA, Dictionary<int, object> FDLLKGDBNDF, GBNNBLFIGLH PKBMMFHCONE);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface FLMIJAAMBOI : BKMLAMEFBLM
{
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IEAMPCKAMFG(JKKCHPONOAD MJNLMOPPION, Vector3 BAIEFBENFCP, Quaternion HBPGIGGIBDO, Vector3 NAFAGKAHDMC, bool KKPNFPAPKLE);

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FIECFJFFHAA(Vector3 BAIEFBENFCP, Quaternion HBPGIGGIBDO, Vector3 NAFAGKAHDMC);

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KBJIKDOEMIH(ViewId MJNLMOPPION);

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GAFCGBKCIAO(bool KGMIPPNIMHP);

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KEFLOBECDLA(bool JJNKKOIOJDD);
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface JJIBMHKNOBJ
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PBCHDEEEACC();
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface ECLGHANDHLL
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NativeArray<Guid> LBGJOOOBKJH(World NAHDLONMOKF, NativeArray<Entity> EFHAKLBGNAC, Allocator GFNKGIEEHMD);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface IIFDLIOCAME
{
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	ReadOnlySpan<byte> BNBDECDLFEE(Entity JAOKKIIOCBD, int BKKAKOKANAJ);

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ELMMBODKHHD(Entity JAOKKIIOCBD, int BKKAKOKANAJ, ReadOnlySpan<byte> MGONBEDEDON);

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DGPHJNFEFGB(Entity JAOKKIIOCBD, int BKKAKOKANAJ, Action LKHIOLGKDDF);

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ACBPKBAAOPI(Entity JAOKKIIOCBD, int BKKAKOKANAJ, Action LKHIOLGKDDF);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public static class FEGHJBPHNAD
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x39A88E0", Offset = "0x39A70E0", VA = "0x1839A88E0")]
	public static T IPLCBNPNHCA<T>(this IIFDLIOCAME NNAJFFEFKBD, Entity JAOKKIIOCBD, int BKKAKOKANAJ) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x39A87B0", Offset = "0x39A6FB0", VA = "0x1839A87B0")]
	public static void BOGMBJJJBOB<T>(this IIFDLIOCAME NNAJFFEFKBD, Entity JAOKKIIOCBD, int BKKAKOKANAJ, T MGONBEDEDON) where T : struct
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
		[Cpp2IlInjected.Address(RVA = "0x7F4A800", Offset = "0x7F49000", VA = "0x187F4A800", Slot = "4")]
		public bool Equals(AiCodeGenIdData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x7F4A840", Offset = "0x7F49040", VA = "0x187F4A840", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x7F4A8F0", Offset = "0x7F490F0", VA = "0x187F4A8F0", Slot = "2")]
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
		[Cpp2IlInjected.Address(RVA = "0x7F4A800", Offset = "0x7F49000", VA = "0x187F4A800", Slot = "4")]
		public bool Equals(AiCodeGenNameData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7F4A900", Offset = "0x7F49100", VA = "0x187F4A900", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7F4A8F0", Offset = "0x7F490F0", VA = "0x187F4A8F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public struct JCKGIADAIMB : IComponentData, IEquatable<JCKGIADAIMB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	[RecRoom.DataLayer.Default]
	[RecRoom.DataLayer.Field(1)]
	public uint HDAKFEADKFH;

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7F4A9B0", Offset = "0x7F491B0", VA = "0x187F4A9B0", Slot = "4")]
	public bool Equals(JCKGIADAIMB KEKEFPAJGHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x7F4CAB0", Offset = "0x7F4B2B0", VA = "0x187F4CAB0", Slot = "0")]
	public override bool Equals(object HPLLAPMNIJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x13D3B00", Offset = "0x13D2300", VA = "0x1813D3B00", Slot = "2")]
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
		[Cpp2IlInjected.Address(RVA = "0x7F4A9B0", Offset = "0x7F491B0", VA = "0x187F4A9B0", Slot = "4")]
		public bool Equals(AuthoredAIIdData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x7F4A9C0", Offset = "0x7F491C0", VA = "0x187F4A9C0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x13D3B00", Offset = "0x13D2300", VA = "0x1813D3B00", Slot = "2")]
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
		[Cpp2IlInjected.Address(RVA = "0x1268020", Offset = "0x1266820", VA = "0x181268020")]
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
			[Cpp2IlInjected.Address(RVA = "0x7F4AA50", Offset = "0x7F49250", VA = "0x187F4AA50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x524B3A0", Offset = "0x5249BA0", VA = "0x18524B3A0")]
		public AuthoredLocalPoseData(quaternion localRotation, float3 localPosition)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7F4AAB0", Offset = "0x7F492B0", VA = "0x187F4AAB0")]
		public static RigidTransform KEINEINMKGA(AuthoredLocalPoseData poseData)
		{
			return default(RigidTransform);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x7F4AAB0", Offset = "0x7F492B0", VA = "0x187F4AAB0")]
		public static AuthoredLocalPoseData KEINEINMKGA(RigidTransform pose)
		{
			return default(AuthoredLocalPoseData);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class GJDBHMANKLL
{
	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7F4C610", Offset = "0x7F4AE10", VA = "0x187F4C610")]
	public static AuthoredLocalPoseData JOKDKBAPIFH([In] this RigidTransform MGONBEDEDON)
	{
		return default(AuthoredLocalPoseData);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0xD02080", Offset = "0xD00880", VA = "0x180D02080")]
	public static RigidTransform CDMEBIDINEL(this AuthoredLocalPoseData MGONBEDEDON)
	{
		return default(RigidTransform);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7F4C5E0", Offset = "0x7F4ADE0", VA = "0x187F4C5E0")]
	public static RigidTransform IDFKFLAIHOM([In] this AuthoredLocalPoseData MGONBEDEDON)
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
			[Cpp2IlInjected.Address(RVA = "0x7F4AAD0", Offset = "0x7F492D0", VA = "0x187F4AAD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x2AAA980", Offset = "0x2AA9180", VA = "0x182AAA980")]
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
	public struct AuthoredParentData : IComponentData, FLIJOCAGNHH
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
			[Cpp2IlInjected.Address(RVA = "0xDB8D70", Offset = "0xDB7570", VA = "0x180DB8D70", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x128A850", Offset = "0x1289050", VA = "0x18128A850", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x128A850", Offset = "0x1289050", VA = "0x18128A850")]
		public AuthoredParentData(Entity parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x7F4AB30", Offset = "0x7F49330", VA = "0x187F4AB30", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002C")]
public struct DDNACEAPOCF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002D")]
[TypeManager.ForcedStableTypeHash(11776442497872827640uL)]
public struct FIBILCIANLE : IComponentData
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
public struct PDOLEDHGFKM : IComponentData
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
public struct DOJPKKBFONA : IComponentData
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
		[Cpp2IlInjected.Address(RVA = "0x7F4C1E0", Offset = "0x7F4A9E0", VA = "0x187F4C1E0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x139F860", Offset = "0x139E060", VA = "0x18139F860")]
		internal EntityPrefabPartId(uint EBHOIBHGECB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0xBD78B0", Offset = "0xBD60B0", VA = "0x180BD78B0")]
		internal uint NNMAMHJGLDF()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x22673C0", Offset = "0x2265BC0", VA = "0x1822673C0", Slot = "4")]
		public bool Equals(EntityPrefabPartId KEKEFPAJGHD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x7F4C230", Offset = "0x7F4AA30", VA = "0x187F4C230", Slot = "0")]
		public override bool Equals(object HPLLAPMNIJF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x13D3B00", Offset = "0x13D2300", VA = "0x1813D3B00", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x2267330", Offset = "0x2265B30", VA = "0x182267330", Slot = "5")]
		public int CompareTo(EntityPrefabPartId KEKEFPAJGHD)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[TypeManager.ForcedStableTypeHash(15026348711748810383uL)]
public struct KCCMPIHCMGJ : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public Entity PDGAOLJEHNA;
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
		[RecRoom.DataLayer.Default(CAOAEEFLCJP.Children)]
		[Config(null, 0)]
		public CAOAEEFLCJP collisionMode;
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
		public KDBFAPJFMCH grabbableMode;
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
		[RecRoom.DataLayer.Default(BGGCNEGFHDD.NavMeshGenerator)]
		[Config(null, 0)]
		[RecRoom.DataLayer.Field(1)]
		public BGGCNEGFHDD mode;
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
		[RecRoom.DataLayer.Default(BAMKOOJPPFO.IsDynamicEnvironment)]
		public BAMKOOJPPFO collisionLayer;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class DGLGEOLDJHJ
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public enum JADDIEPDBPB
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
	public enum HDFOFBFPAJD
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
	[Cpp2IlInjected.Address(RVA = "0x7F4B6A0", Offset = "0x7F49EA0", VA = "0x187F4B6A0")]
	public static (JADDIEPDBPB, HDFOFBFPAJD) JAGMLEFBIHP(this BAMKOOJPPFO GBIENHEIENE)
	{
		return default((JADDIEPDBPB, HDFOFBFPAJD));
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
		[RecRoom.DataLayer.Default(KOIOMAEALHN.DEFAULT)]
		public KOIOMAEALHN flags;
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
		[Cpp2IlInjected.Address(RVA = "0xD02080", Offset = "0xD00880", VA = "0x180D02080")]
		public static InventionIdData KEINEINMKGA(long value)
		{
			return default(InventionIdData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7F4CAA0", Offset = "0x7F4B2A0", VA = "0x187F4CAA0")]
		public readonly bool BAEBJBIMHIA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7C917A0", Offset = "0x7C8FFA0", VA = "0x187C917A0")]
		public static bool BAEBJBIMHIA(long inventionId)
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
		[Cpp2IlInjected.Address(RVA = "0x1125530", Offset = "0x1123D30", VA = "0x181125530")]
		public static InventionInstanceIdData KEINEINMKGA(Guid value)
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
	public struct ParentData : IComponentData, FLIJOCAGNHH
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
			[Cpp2IlInjected.Address(RVA = "0xDB8D70", Offset = "0xDB7570", VA = "0x180DB8D70", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x128A850", Offset = "0x1289050", VA = "0x18128A850", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x128A850", Offset = "0x1289050", VA = "0x18128A850")]
		public ParentData(Entity parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xD02080", Offset = "0xD00880", VA = "0x180D02080")]
		public static implicit operator ParentData(Entity entity)
		{
			return default(ParentData);
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004D")]
public struct KKIDMKGKAFD : IComponentData
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
		public CDNLFFIPOFD order;

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0xD02080", Offset = "0xD00880", VA = "0x180D02080")]
		public static SiblingSortOrderData KEINEINMKGA(CDNLFFIPOFD value)
		{
			return default(SiblingSortOrderData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x7F4B000", Offset = "0x7F49800", VA = "0x187F4B000", Slot = "4")]
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
	public struct InteractionFilterAllTagsData : IComponentData, FLIJOCAGNHH
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
			[Cpp2IlInjected.Address(RVA = "0xDB8D70", Offset = "0xDB7570", VA = "0x180DB8D70", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x128A850", Offset = "0x1289050", VA = "0x18128A850", Slot = "5")]
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
	public struct InteractionFilterAnyTagsData : IComponentData, FLIJOCAGNHH
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
			[Cpp2IlInjected.Address(RVA = "0xDB8D70", Offset = "0xDB7570", VA = "0x180DB8D70", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x128A850", Offset = "0x1289050", VA = "0x18128A850", Slot = "5")]
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
		[RecRoom.DataLayer.Default(DJJLOJMEBGF.Disabled)]
		[RecRoom.DataLayer.Field(1)]
		public DJJLOJMEBGF filterMode;
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(6642820932987006861uL)]
	[RecRoom.DataLayer.RRGuid("F7789094-7D82-4D27-B805-2CC1B8C0A538")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	public struct InteractionFilterEntityRefData : IComponentData, FLIJOCAGNHH
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
			[Cpp2IlInjected.Address(RVA = "0xDB8D70", Offset = "0xDB7570", VA = "0x180DB8D70", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x128A850", Offset = "0x1289050", VA = "0x18128A850", Slot = "5")]
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
	public struct InteractionFilterNoneTagsData : IComponentData, FLIJOCAGNHH
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
			[Cpp2IlInjected.Address(RVA = "0xDB8D70", Offset = "0xDB7570", VA = "0x180DB8D70", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x128A850", Offset = "0x1289050", VA = "0x18128A850", Slot = "5")]
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
		public EHMGAOAPFNO scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		[Config(null, 0)]
		[RecRoom.DataLayer.Default("ObjectPolicyUserConfigurableFlags.DEFAULT")]
		[RecRoom.DataLayer.Field(3)]
		public KPECNNGKFAP userConfigurableFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		[RecRoom.DataLayer.Default(JMDHHCJMALC.Default)]
		[Config(null, 0)]
		[RecRoom.DataLayer.Field(4)]
		public JMDHHCJMALC circuitsTransformBehavior;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default("ObjectPolicyEnumFlags.Default")]
		public GFIBKOJMGEC flags;
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
	public struct PlayerScopeData : IComponentData, FLIJOCAGNHH
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
			[Cpp2IlInjected.Address(RVA = "0xDB8D70", Offset = "0xDB7570", VA = "0x180DB8D70", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x128A850", Offset = "0x1289050", VA = "0x18128A850", Slot = "5")]
			set
			{
			}
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xD02080", Offset = "0xD00880", VA = "0x180D02080")]
		public static PlayerScopeData KEINEINMKGA(Entity entity)
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
		[RecRoom.DataLayer.Default(CMGJMELDMAG.None)]
		public CMGJMELDMAG flags;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool DynamicUVProjection
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x731F870", Offset = "0x731E070", VA = "0x18731F870")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool PreventInvertedCreation
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x731F860", Offset = "0x731E060", VA = "0x18731F860")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public bool NewBendLogic
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x7F4E870", Offset = "0x7F4D070", VA = "0x187F4E870")]
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
		public AHMGEEBMBGP shapeType;
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
		public CDNLFFIPOFD order;

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0xD02080", Offset = "0xD00880", VA = "0x180D02080")]
		public static SplinePointOrderData KEINEINMKGA(CDNLFFIPOFD value)
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
		public ONDGGPNOKFN parameters;
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
[RecRoom.DataLayer.Range(NKDJMMDIMMK.MIN, NKDJMMDIMMK.ALL)]
[RecRoom.DataLayer.RRGuid("CC657074-87FD-47F7-A7B0-F5CCE922A9D0")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
public enum NKDJMMDIMMK
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
		[RecRoom.DataLayer.Default(NKDJMMDIMMK.UseDefaultVisualEffects)]
		[RecRoom.DataLayer.Field(2)]
		public NKDJMMDIMMK toolCleanupFlags;
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
		public MJIOFNFLODC statusFlags;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
[Flags]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.RRGuid("E63050BA-D087-4027-99F8-4AFDEA229CD8")]
[RecRoom.DataLayer.Range(MJIOFNFLODC.None, MJIOFNFLODC.ALL)]
public enum MJIOFNFLODC
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
		[Cpp2IlInjected.Address(RVA = "0x1268020", Offset = "0x1266820", VA = "0x181268020")]
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
		[Cpp2IlInjected.Address(RVA = "0x524B3A0", Offset = "0x5249BA0", VA = "0x18524B3A0")]
		public LocalPoseData(quaternion localRotation, float3 localPosition)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x7F4AAB0", Offset = "0x7F492B0", VA = "0x187F4AAB0")]
		public static RigidTransform KEINEINMKGA(LocalPoseData poseData)
		{
			return default(RigidTransform);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x7F4AAB0", Offset = "0x7F492B0", VA = "0x187F4AAB0")]
		public static LocalPoseData KEINEINMKGA(RigidTransform pose)
		{
			return default(LocalPoseData);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public static class FNCLPLEEHBD
{
	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x7F4C340", Offset = "0x7F4AB40", VA = "0x187F4C340")]
	public static LocalPoseData KIKJJLKINAJ([In] this RigidTransform MGONBEDEDON)
	{
		return default(LocalPoseData);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x7F4C310", Offset = "0x7F4AB10", VA = "0x187F4C310")]
	public static RigidTransform IDFKFLAIHOM([In] this LocalPoseData MGONBEDEDON)
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
		public DCHEOBPJONN transformHint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		[RecRoom.DataLayer.Field(2)]
		[RecRoom.DataLayer.Default]
		public DJLCPDHFEOB transformPriority;
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
		public OMOMKAHPFJK prefabType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		[RecRoom.DataLayer.Field(2)]
		[RecRoom.DataLayer.Default]
		public Guid prefabGuid;

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x7F4E760", Offset = "0x7F4CF60", VA = "0x187F4E760")]
		public RRObjectPrefabData(Guid prefabGuid, OMOMKAHPFJK prefabType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x7F4E660", Offset = "0x7F4CE60", VA = "0x187F4E660", Slot = "4")]
		public readonly bool Equals(RRObjectPrefabData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x7F4E5A0", Offset = "0x7F4CDA0", VA = "0x187F4E5A0", Slot = "0")]
		public override readonly bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x7F4E770", Offset = "0x7F4CF70", VA = "0x187F4E770")]
		public static bool operator ==(RRObjectPrefabData a, RRObjectPrefabData b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x7F4C560", Offset = "0x7F4AD60", VA = "0x187F4C560", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x7F4C370", Offset = "0x7F4AB70", VA = "0x187F4C370", Slot = "5")]
		public readonly int CompareTo(RRObjectPrefabData other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x7F4E6C0", Offset = "0x7F4CEC0", VA = "0x187F4E6C0", Slot = "3")]
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
		public HANCEIDOMMA kind;
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
	public struct ReferenceGroupReferenceBuffer : IBufferElementData, FLIJOCAGNHH, IEquatable<ReferenceGroupReferenceBuffer>
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
			[Cpp2IlInjected.Address(RVA = "0xDB8D70", Offset = "0xDB7570", VA = "0x180DB8D70", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x128A850", Offset = "0x1289050", VA = "0x18128A850", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x7F4E860", Offset = "0x7F4D060", VA = "0x187F4E860", Slot = "6")]
		public bool Equals(ReferenceGroupReferenceBuffer other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x7F4E7D0", Offset = "0x7F4CFD0", VA = "0x187F4E7D0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0xBD78B0", Offset = "0xBD60B0", VA = "0x180BD78B0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000071")]
public struct HGPBJDGLJIF : IEqualityComparer<ReferenceGroupReferenceBuffer>
{
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public static HGPBJDGLJIF JMOEBDABFID;

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x7F4C640", Offset = "0x7F4AE40", VA = "0x187F4C640", Slot = "4")]
	public bool Equals(ReferenceGroupReferenceBuffer BDGPJOKJNIL, ReferenceGroupReferenceBuffer HDAFCDJNHAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0xAEDD00", Offset = "0xAEC500", VA = "0x180AEDD00", Slot = "5")]
	public int GetHashCode(ReferenceGroupReferenceBuffer HPLLAPMNIJF)
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
	public struct AuthoredUserTagReferenceBuffer : ELGJDGCILLO, IBufferElementData, FLIJOCAGNHH
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
			[Cpp2IlInjected.Address(RVA = "0xDB8D70", Offset = "0xDB7570", VA = "0x180DB8D70", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x128A850", Offset = "0x1289050", VA = "0x18128A850", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x128A850", Offset = "0x1289050", VA = "0x18128A850")]
		public AuthoredUserTagReferenceBuffer(Entity entity)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xD02080", Offset = "0xD00880", VA = "0x180D02080")]
		public static AuthoredUserTagReferenceBuffer KEINEINMKGA(Entity entity)
		{
			return default(AuthoredUserTagReferenceBuffer);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public interface ELGJDGCILLO : IBufferElementData, FLIJOCAGNHH
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
		[Cpp2IlInjected.Address(RVA = "0x7F4E9A0", Offset = "0x7F4D1A0", VA = "0x187F4E9A0")]
		public UserTagNameData(string value)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x7F4E960", Offset = "0x7F4D160", VA = "0x187F4E960")]
		public static UserTagNameData KEINEINMKGA(string value)
		{
			return default(UserTagNameData);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x7F4E880", Offset = "0x7F4D080", VA = "0x187F4E880", Slot = "4")]
		public bool Equals(UserTagNameData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x7F4E8B0", Offset = "0x7F4D0B0", VA = "0x187F4E8B0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x7F4E950", Offset = "0x7F4D150", VA = "0x187F4E950", Slot = "2")]
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
	public struct UserTagReferenceBuffer : ELGJDGCILLO, IBufferElementData, FLIJOCAGNHH
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
			[Cpp2IlInjected.Address(RVA = "0xDB8D70", Offset = "0xDB7570", VA = "0x180DB8D70", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x128A850", Offset = "0x1289050", VA = "0x18128A850", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x128A850", Offset = "0x1289050", VA = "0x18128A850")]
		public UserTagReferenceBuffer(Entity entity)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0xD02080", Offset = "0xD00880", VA = "0x180D02080")]
		public static UserTagReferenceBuffer KEINEINMKGA(Entity entity)
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
		public HJJEDNCFOMD color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		[RecRoom.DataLayer.Default]
		[Config(null, 0)]
		[RecRoom.DataLayer.Field(2)]
		public ODAFNIPBPOF material;

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
[RecRoom.DataLayer.Range(JMDHHCJMALC.NONE, JMDHHCJMALC.COUNT)]
[RecRoom.DataLayer.RRGuid("6B598497-D68A-4CC9-9D41-09EF6B966499")]
public enum JMDHHCJMALC
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
public enum ICJMBODOOLK
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
[RecRoom.DataLayer.Range(MCJPBFNHNJD.NONE, MCJPBFNHNJD.ALL)]
[RecRoom.DataLayer.RRGuid("A13F5102-9259-42B9-B782-BB7CC33A0C4F")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[Flags]
public enum MCJPBFNHNJD
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
public enum BAMKOOJPPFO : byte
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
[RecRoom.DataLayer.Range(CAOAEEFLCJP.Off, CAOAEEFLCJP.COUNT)]
[RecRoom.DataLayer.NetworkEnum(2, false)]
public enum CAOAEEFLCJP : byte
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
public enum AHMGEEBMBGP
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
[RecRoom.DataLayer.Range(KDBFAPJFMCH.Pivot, KDBFAPJFMCH.COUNT)]
[RecRoom.DataLayer.NetworkEnum(2, false)]
[RecRoom.DataLayer.RRGuid("61EFE94A-235A-4281-B938-1A5BE32A18B1")]
public enum KDBFAPJFMCH : byte
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
[RecRoom.DataLayer.Range(DJJLOJMEBGF.EnabledForRole, DJJLOJMEBGF.Disabled)]
[RecRoom.DataLayer.RRGuid("c0973732-e735-44cd-9727-a9a79bad01e3")]
public enum DJJLOJMEBGF : byte
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
[RecRoom.DataLayer.Range(BGGCNEGFHDD.NavMeshGenerator, BGGCNEGFHDD.NavMeshBlocker)]
public enum BGGCNEGFHDD
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
[RecRoom.DataLayer.Range(GFIBKOJMGEC.None, GFIBKOJMGEC.All)]
[RecRoom.DataLayer.RRGuid("7B493897-FE06-4FC8-AB72-8B7BF5A313D3")]
public enum GFIBKOJMGEC
{
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	All = 0x3FFF,
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	Default = 0x3FFF
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
[RecRoom.DataLayer.Range(0, MDPGAHIEILH.COUNT)]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.RRGuid("4427686F-E636-4F43-91F7-6BC74DEC584E")]
public enum MDPGAHIEILH
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
public static class DKIFENCPLPM
{
	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x7F4C1B0", Offset = "0x7F4A9B0", VA = "0x187F4C1B0")]
	public static void NNLOAAEAPBJ(this GFIBKOJMGEC NMFHGOAHANN, MDPGAHIEILH JGMFDAAAACE, bool CCCAKBLNGCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x7F4C190", Offset = "0x7F4A990", VA = "0x187F4C190")]
	public static bool BJDFCLKONOA(this GFIBKOJMGEC NMFHGOAHANN, MDPGAHIEILH JGMFDAAAACE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0xE32980", Offset = "0xE31180", VA = "0x180E32980")]
	public static GFIBKOJMGEC MJINCDCHINM(this MDPGAHIEILH JGMFDAAAACE)
	{
		return default(GFIBKOJMGEC);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
[RecRoom.DataLayer.RRGuid("E3C51303-32F0-4EF4-8A66-C814E323653D")]
[RecRoom.DataLayer.Range(KPECNNGKFAP.NONE, KPECNNGKFAP.COUNT)]
[RecRoom.DataLayer.NetworkEnum(2, false)]
[Flags]
public enum KPECNNGKFAP
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
[RecRoom.DataLayer.Range(OMOMKAHPFJK.None, 8000)]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.RRGuid("777AD204-3AC0-41CE-BDC0-894C5821B3B9")]
public enum OMOMKAHPFJK
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
public static class LLOBCHNACNF
{
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	[CompilerGenerated]
	private sealed class OJHLFICGEIK : IEnumerable<OMOMKAHPFJK>, IEnumerable, IEnumerator<OMOMKAHPFJK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		private OMOMKAHPFJK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		private IEnumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		private OMOMKAHPFJK System.Collections.Generic.IEnumerator<RecRoom.DataLayer.ObjectPrefabType>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0xA76460", Offset = "0xA74C60", VA = "0x180A76460", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(OMOMKAHPFJK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x7F4E2E0", Offset = "0x7F4CAE0", VA = "0x187F4E2E0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x139A8E0", Offset = "0x13990E0", VA = "0x18139A8E0")]
		[DebuggerHidden]
		public OJHLFICGEIK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x7F4E330", Offset = "0x7F4CB30", VA = "0x187F4E330", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x7F4DF80", Offset = "0x7F4C780", VA = "0x187F4DF80", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x7F4DF20", Offset = "0x7F4C720", VA = "0x187F4DF20")]
		private void EGKKBNFIFOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x7F4E290", Offset = "0x7F4CA90", VA = "0x187F4E290", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x7F4E1F0", Offset = "0x7F4C9F0", VA = "0x187F4E1F0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<OMOMKAHPFJK> System.Collections.Generic.IEnumerable<RecRoom.DataLayer.ObjectPrefabType>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x7F4E1F0", Offset = "0x7F4C9F0", VA = "0x187F4E1F0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000088")]
	[CompilerGenerated]
	private sealed class IKHCKBJKFLG : IEnumerable<OMOMKAHPFJK>, IEnumerable, IEnumerator<OMOMKAHPFJK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		private OMOMKAHPFJK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		private OMOMKAHPFJK <last>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private OMOMKAHPFJK <i>5__3;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		private OMOMKAHPFJK System.Collections.Generic.IEnumerator<RecRoom.DataLayer.ObjectPrefabType>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0xA76460", Offset = "0xA74C60", VA = "0x180A76460", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(OMOMKAHPFJK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x7F4CA50", Offset = "0x7F4B250", VA = "0x187F4CA50", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x139A8E0", Offset = "0x13990E0", VA = "0x18139A8E0")]
		[DebuggerHidden]
		public IKHCKBJKFLG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x7F4C900", Offset = "0x7F4B100", VA = "0x187F4C900", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x7F4CA00", Offset = "0x7F4B200", VA = "0x187F4CA00", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x7F4C960", Offset = "0x7F4B160", VA = "0x187F4C960", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<OMOMKAHPFJK> System.Collections.Generic.IEnumerable<RecRoom.DataLayer.ObjectPrefabType>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x7F4C960", Offset = "0x7F4B160", VA = "0x187F4C960", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000089")]
	[CompilerGenerated]
	private sealed class NAFFLPBMNNG : IEnumerable<OMOMKAHPFJK>, IEnumerable, IEnumerator<OMOMKAHPFJK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		private OMOMKAHPFJK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		private IEnumerator<OMOMKAHPFJK> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		private OMOMKAHPFJK System.Collections.Generic.IEnumerator<RecRoom.DataLayer.ObjectPrefabType>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0xA76460", Offset = "0xA74C60", VA = "0x180A76460", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(OMOMKAHPFJK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x7F4DCD0", Offset = "0x7F4C4D0", VA = "0x187F4DCD0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x139A8E0", Offset = "0x13990E0", VA = "0x18139A8E0")]
		[DebuggerHidden]
		public NAFFLPBMNNG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x7F4DD20", Offset = "0x7F4C520", VA = "0x187F4DD20", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x7F4D940", Offset = "0x7F4C140", VA = "0x187F4D940", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x7F4D8F0", Offset = "0x7F4C0F0", VA = "0x187F4D8F0")]
		private void EGKKBNFIFOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x7F4DC80", Offset = "0x7F4C480", VA = "0x187F4DC80", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x7F4DBE0", Offset = "0x7F4C3E0", VA = "0x187F4DBE0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<OMOMKAHPFJK> System.Collections.Generic.IEnumerable<RecRoom.DataLayer.ObjectPrefabType>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x7F4DBE0", Offset = "0x7F4C3E0", VA = "0x187F4DBE0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x7F4D0E0", Offset = "0x7F4B8E0", VA = "0x187F4D0E0")]
	[IteratorStateMachine(typeof(OJHLFICGEIK))]
	public static IEnumerable<OMOMKAHPFJK> GPBFKAOHKHE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x7F4D020", Offset = "0x7F4B820", VA = "0x187F4D020")]
	[IteratorStateMachine(typeof(IKHCKBJKFLG))]
	public static IEnumerable<OMOMKAHPFJK> BOPNFEILPJL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x7F4D080", Offset = "0x7F4B880", VA = "0x187F4D080")]
	[IteratorStateMachine(typeof(NAFFLPBMNNG))]
	public static IEnumerable<OMOMKAHPFJK> EMPHNDIGBGI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public static class LJNCMLLPBBI
{
	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x7F4CFA0", Offset = "0x7F4B7A0", VA = "0x187F4CFA0")]
	public static bool JIKCEKMNDGC(this RRObjectPrefabData BDBPPAAGMMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x7F4CFD0", Offset = "0x7F4B7D0", VA = "0x187F4CFD0")]
	public static bool JIKCEKMNDGC(this OMOMKAHPFJK CEPGAJKBPDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x7F4CF40", Offset = "0x7F4B740", VA = "0x187F4CF40")]
	public static bool CKFFPJBKBLL(this RRObjectPrefabData BDBPPAAGMMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x7F4CF10", Offset = "0x7F4B710", VA = "0x187F4CF10")]
	public static bool CKFFPJBKBLL(this OMOMKAHPFJK CEPGAJKBPDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x7F4D000", Offset = "0x7F4B800", VA = "0x187F4D000")]
	public static HGLHFINFANA MMDKAEBIKCD(this OMOMKAHPFJK HIGIPMBNHHD)
	{
		return default(HGLHFINFANA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x7F4CF70", Offset = "0x7F4B770", VA = "0x187F4CF70")]
	internal static PIDKJJKDANG IKHFCHNIBNP(this HGLHFINFANA CEBILNINJIM)
	{
		return default(PIDKJJKDANG);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x7F4CF80", Offset = "0x7F4B780", VA = "0x187F4CF80")]
	internal static PIDKJJKDANG IKHFCHNIBNP(this OMOMKAHPFJK HIGIPMBNHHD)
	{
		return default(PIDKJJKDANG);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
internal enum PIDKJJKDANG
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
public enum HGLHFINFANA
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
public static class HKLKOJNEGFD
{
	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x7F4C660", Offset = "0x7F4AE60", VA = "0x187F4C660")]
	public static bool OKPOOMNLFDA(this HGLHFINFANA CEBILNINJIM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
[RecRoom.DataLayer.NetworkEnum(3, false)]
[RecRoom.DataLayer.Range(0, KOIOMAEALHN.ALL)]
[RecRoom.DataLayer.RRGuid("7A0D34B5-FFE5-4C21-BB0C-CB3EBA34C797")]
[Flags]
public enum KOIOMAEALHN : ushort
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
		public HBIFHMNPGDK shapeType;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
[RecRoom.DataLayer.NetworkEnum(1, false)]
[RecRoom.DataLayer.RRGuid("517224CC-0A79-4FE9-B048-53C37955D823")]
[RecRoom.DataLayer.Range(-1, 38)]
public enum HBIFHMNPGDK
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
[RecRoom.DataLayer.Range(HANCEIDOMMA.None, HANCEIDOMMA.COUNT)]
[RecRoom.DataLayer.NetworkEnum(1, false)]
public enum HANCEIDOMMA : byte
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
public enum CMGJMELDMAG
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
public enum IKBILMPCMNJ
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
public enum DCHEOBPJONN
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
public enum DJLCPDHFEOB
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
public enum HJJEDNCFOMD
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
public enum ODAFNIPBPOF
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
public interface AJMOHKGFDEI : DLEFIPJOGKA
{
	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	[RecRoom.DataLayer.Field(1)]
	[RecRoom.DataLayer.Key("SBDScale")]
	[RecRoom.DataLayer.Default]
	[ProtoProp("PersistenceViewData.SandboxDeformationData.Deformation", typeof(ELMNHFBGKHN))]
	[Set.Auth]
	float3 HDBDMJCJIFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action CMBFAMFMNBG;
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
[RecRoom.DataLayer.NetworkStruct(1, false)]
[RecRoom.DataLayer.RRGuid("112F004A-C92F-4055-99F9-D430EC13FE3C")]
public struct CDNLFFIPOFD : IComparable<CDNLFFIPOFD>, IEquatable<CDNLFFIPOFD>
{
	[Cpp2IlInjected.Token(Token = "0x4000264")]
	public static readonly CDNLFFIPOFD EBKBGKJDDBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000265")]
	[RecRoom.DataLayer.Field(1)]
	public uint KJGAEHBGANK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000266")]
	[RecRoom.DataLayer.Field(2)]
	public uint BCLEDICKKBL;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	private readonly uint GPLLNADPDDG
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x7F4B4D0", Offset = "0x7F49CD0", VA = "0x187F4B4D0")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public readonly bool KBFIABEIPGM
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x7F4B4C0", Offset = "0x7F49CC0", VA = "0x187F4B4C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x7F4B640", Offset = "0x7F49E40", VA = "0x187F4B640")]
	public CDNLFFIPOFD(int KJGAEHBGANK, int OHKPGMLAFFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x7F4B640", Offset = "0x7F49E40", VA = "0x187F4B640")]
	public CDNLFFIPOFD(uint KJGAEHBGANK, uint OHKPGMLAFFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x7F4B5C0", Offset = "0x7F49DC0", VA = "0x187F4B5C0")]
	private CDNLFFIPOFD(uint KJGAEHBGANK, uint OHKPGMLAFFJ, bool LPIKKNEEBFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x7F4B3F0", Offset = "0x7F49BF0", VA = "0x187F4B3F0")]
	public CDNLFFIPOFD JGOBKNAPBFP(int BJCMHPBMOOK = 1)
	{
		return default(CDNLFFIPOFD);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x7F4AF70", Offset = "0x7F49770", VA = "0x187F4AF70")]
	public CDNLFFIPOFD DEOGJMPAHDK(int BJCMHPBMOOK = 1)
	{
		return default(CDNLFFIPOFD);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x7F4B100", Offset = "0x7F49900", VA = "0x187F4B100")]
	public static CDNLFFIPOFD JFHNMFMPEDK(CDNLFFIPOFD HGBNKPCDEON, CDNLFFIPOFD DPOCHOAKFKE)
	{
		return default(CDNLFFIPOFD);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x7F4B480", Offset = "0x7F49C80", VA = "0x187F4B480")]
	private static ulong JLCPECGEPBO(ulong HBMOFOICGEH, ulong LDEEDNGKJOE)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x7F4AF50", Offset = "0x7F49750", VA = "0x187F4AF50", Slot = "4")]
	public int CompareTo(CDNLFFIPOFD KEKEFPAJGHD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x7F4B020", Offset = "0x7F49820", VA = "0x187F4B020", Slot = "0")]
	public override bool Equals(object HPLLAPMNIJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x7F4B4E0", Offset = "0x7F49CE0", VA = "0x187F4B4E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x7F4B000", Offset = "0x7F49800", VA = "0x187F4B000", Slot = "5")]
	public bool Equals(CDNLFFIPOFD KEKEFPAJGHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x7F4B0B0", Offset = "0x7F498B0", VA = "0x187F4B0B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x3844970", Offset = "0x3843170", VA = "0x183844970")]
	public static bool NALNDDPCEFD(CDNLFFIPOFD HGBNKPCDEON, CDNLFFIPOFD DPOCHOAKFKE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x7F4AF30", Offset = "0x7F49730", VA = "0x187F4AF30")]
	public static bool BLLMPNNLKNM(CDNLFFIPOFD HGBNKPCDEON, CDNLFFIPOFD DPOCHOAKFKE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x7F4AFE0", Offset = "0x7F497E0", VA = "0x187F4AFE0")]
	public static bool EMJLHKMNKHE(CDNLFFIPOFD HGBNKPCDEON, CDNLFFIPOFD DPOCHOAKFKE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x7F4B460", Offset = "0x7F49C60", VA = "0x187F4B460")]
	public static bool JJDNIMAFPDI(CDNLFFIPOFD HGBNKPCDEON, CDNLFFIPOFD DPOCHOAKFKE)
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
			[Cpp2IlInjected.Address(RVA = "0x1125530", Offset = "0x1123D30", VA = "0x181125530")]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x12F1FF0", Offset = "0x12F07F0", VA = "0x1812F1FF0")]
			set
			{
			}
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x1125530", Offset = "0x1123D30", VA = "0x181125530")]
		public static Guid KEINEINMKGA(NetworkGuid JMHOEKKPCPG)
		{
			return default(Guid);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x1125530", Offset = "0x1123D30", VA = "0x181125530")]
		public static NetworkGuid KEINEINMKGA(Guid JMHOEKKPCPG)
		{
			return default(NetworkGuid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x7F4DED0", Offset = "0x7F4C6D0", VA = "0x187F4DED0", Slot = "4")]
		public bool Equals(NetworkGuid KEKEFPAJGHD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x6D0B340", Offset = "0x6D09B40", VA = "0x186D0B340", Slot = "5")]
		public int CompareTo(NetworkGuid KEKEFPAJGHD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x7F4DF00", Offset = "0x7F4C700", VA = "0x187F4DF00", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
[RecRoom.DataLayer.RRGuid("9F5F33BE-7C0A-4870-9CE0-BA79440E7F98")]
[RecRoom.DataLayer.NetworkStruct(1, false)]
public struct EHMGAOAPFNO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000268")]
	[RecRoom.DataLayer.Field(1)]
	public bool EMMOENAPJHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000269")]
	[RecRoom.DataLayer.Field(2)]
	public float3 LAIHMODDCAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400026A")]
	[RecRoom.DataLayer.Field(3)]
	public float3 CPJLHDHKPHG;

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x7F47E00", Offset = "0x7F46600", VA = "0x187F47E00")]
	public EHMGAOAPFNO(float EDBIKCGPICF, float PIMEBNLNKIL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
[RecRoom.DataLayer.NetworkStruct(1, false)]
[RecRoom.DataLayer.RRGuid("35984D5B-ACBD-4389-A94B-840070A871E2")]
public struct ONDGGPNOKFN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400026B")]
	[RecRoom.DataLayer.Field(1)]
	public float CIFGKDHKDOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400026C")]
	[RecRoom.DataLayer.Field(2)]
	public int LJNNJIGIHHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400026D")]
	[RecRoom.DataLayer.Field(3)]
	public IKBILMPCMNJ NMFHGOAHANN;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public bool BJJEMCEGIMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x7F4E3F0", Offset = "0x7F4CBF0", VA = "0x187F4E3F0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x7F4E3A0", Offset = "0x7F4CBA0", VA = "0x187F4E3A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public bool AJFFMACCMAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x7F4E390", Offset = "0x7F4CB90", VA = "0x187F4E390")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x7F4E3C0", Offset = "0x7F4CBC0", VA = "0x187F4E3C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public bool GEOJDLJFJPB
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x7F4E3E0", Offset = "0x7F4CBE0", VA = "0x187F4E3E0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x7F4E400", Offset = "0x7F4CC00", VA = "0x187F4E400")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
public struct DILHAMBPDCK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400026E")]
	public FLMIJAAMBOI FLFIEAHMHKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400026F")]
	public int KLPKJLCNMOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000270")]
	public bool DKICDGBHGLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD")]
	[Cpp2IlInjected.Token(Token = "0x4000271")]
	public bool ELEHPKKLCGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE")]
	[Cpp2IlInjected.Token(Token = "0x4000272")]
	public bool OJBCPIHBJLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000273")]
	public Vector3 EOALAOOGNLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000274")]
	public Quaternion FAABMGBBECF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000275")]
	public bool HGEIKJENBBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000276")]
	public Vector3 HDBDMJCJIFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000277")]
	public Vector3 CKIJIOFGMBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000278")]
	public Vector3 KFKFFKMGEMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000279")]
	public bool GBLBIEACNFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400027A")]
	public ViewId KHCAHEAGJAC;

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x7F4B830", Offset = "0x7F4A030", VA = "0x187F4B830", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
public struct FPGJDDPNHNM : IEquatable<FPGJDDPNHNM>, IComparable<FPGJDDPNHNM>
{
	[Cpp2IlInjected.Token(Token = "0x400027B")]
	public static readonly int CJHLHHPHPNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400027C")]
	public RRObjectPrefabData OJKJJCNLKLJ;

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x7F4C590", Offset = "0x7F4AD90", VA = "0x187F4C590", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x7F4C4F0", Offset = "0x7F4ACF0", VA = "0x187F4C4F0", Slot = "4")]
	public bool Equals(FPGJDDPNHNM KEKEFPAJGHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x7F4C3F0", Offset = "0x7F4ABF0", VA = "0x187F4C3F0", Slot = "0")]
	public override bool Equals(object HPLLAPMNIJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x7F4C560", Offset = "0x7F4AD60", VA = "0x187F4C560", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x7F4C370", Offset = "0x7F4AB70", VA = "0x187F4C370", Slot = "5")]
	public int CompareTo(FPGJDDPNHNM KEKEFPAJGHD)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
internal class FFMKEDAPDOF : ContainerPropertyBag<JEOCDAOJLCO>
{
	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x7F4C2B0", Offset = "0x7F4AAB0", VA = "0x187F4C2B0")]
	public FFMKEDAPDOF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
internal class IEKIJEAPAND : ContainerPropertyBag<RRObjectPrefabData>
{
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	private class NLKHMCCOAGD : Property<RRObjectPrefabData, OMOMKAHPFJK>
	{
		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public override string NCBGIDALPJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x7F4DEA0", Offset = "0x7F4C6A0", VA = "0x187F4DEA0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public override bool FEDAMJDDKCF
		{
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0xA73360", Offset = "0xA71B60", VA = "0x180A73360", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x7F4DDB0", Offset = "0x7F4C5B0", VA = "0x187F4DDB0")]
		public NLKHMCCOAGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x2287BC0", Offset = "0x22863C0", VA = "0x182287BC0", Slot = "14")]
		public override OMOMKAHPFJK GetValue(RRObjectPrefabData MBKOPLBCEJA)
		{
			return default(OMOMKAHPFJK);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x7F49E20", Offset = "0x7F48620", VA = "0x187F49E20", Slot = "15")]
		public override void SetValue(RRObjectPrefabData MBKOPLBCEJA, OMOMKAHPFJK MGONBEDEDON)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	private class BCDENFOGAOF : Property<RRObjectPrefabData, Guid>
	{
		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public override string NCBGIDALPJM
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x7F4AC40", Offset = "0x7F49440", VA = "0x187F4AC40", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public override bool FEDAMJDDKCF
		{
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0xA73360", Offset = "0xA71B60", VA = "0x180A73360", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x7F4AB50", Offset = "0x7F49350", VA = "0x187F4AB50")]
		public BCDENFOGAOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x2A3ED50", Offset = "0x2A3D550", VA = "0x182A3ED50", Slot = "14")]
		public override Guid GetValue(RRObjectPrefabData MBKOPLBCEJA)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x7F4AB40", Offset = "0x7F49340", VA = "0x187F4AB40", Slot = "15")]
		public override void SetValue(RRObjectPrefabData MBKOPLBCEJA, Guid MGONBEDEDON)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x7F4C670", Offset = "0x7F4AE70", VA = "0x187F4C670")]
	public IEKIJEAPAND()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
internal class KGAHEMMAOKD : ContainerPropertyBag<Guid>
{
	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x7F4CEB0", Offset = "0x7F4B6B0", VA = "0x187F4CEB0")]
	public KGAHEMMAOKD()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x7F4E420", Offset = "0x7F4CC20", VA = "0x187F4E420")]
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
