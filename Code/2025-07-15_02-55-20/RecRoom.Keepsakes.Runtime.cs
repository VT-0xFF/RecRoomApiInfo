using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using JetBrains.Annotations;
using RecNet;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Keepsakes;
using RecRoom.NoEngine.Common;
using UnityEngine;
using UnityEngine.AddressableAssets;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _AssemblyRegistry.RecRoom_Keepsakes_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x81532B0", Offset = "0x8151EB0", VA = "0x1881532B0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x28B3880", Offset = "0x28B2480", VA = "0x1828B3880")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class OHAMNDFFCPN : IComparer<HINJKNFEFAE>
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private sealed class FMPFPHHNIAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public HINJKNFEFAE x;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public HINJKNFEFAE y;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public FMPFPHHNIAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xE0F700", Offset = "0xE0E300", VA = "0x180E0F700")]
		internal bool FAEOAIPDKKD(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2115B60", Offset = "0x2114760", VA = "0x182115B60")]
		internal bool JGHJODIINON(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xE0F700", Offset = "0xE0E300", VA = "0x180E0F700")]
		internal bool AAJJAJPNBBE(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2115B60", Offset = "0x2114760", VA = "0x182115B60")]
		internal bool BDPBNPDBNJJ(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private List<KeepsakeCategoryThemePair> DFLIHHAKEEN;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0xA628A0", Offset = "0xA614A0", VA = "0x180A628A0")]
	public OHAMNDFFCPN(List<KeepsakeCategoryThemePair> NLFNIJOEHCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x8152DE0", Offset = "0x81519E0", VA = "0x188152DE0", Slot = "4")]
	public int Compare(HINJKNFEFAE LGCEHLADNJC, HINJKNFEFAE LFHMHCKODDK)
	{
		return default(int);
	}
}
namespace RecRoom.Keepsakes
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct KeepsakeCategoryThemePair
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public HINJKNFEFAE KeepsakeCategory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public KeepsakeTheme KeepsakeTheme;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[GOLNKMGDHKC]
public class FHEIHJHEAGN : MOLKACCDFDP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class DHELLGELCAG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public FHEIHJHEAGN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public HINJKNFEFAE keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public DHELLGELCAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x8143320", Offset = "0x8141F20", VA = "0x188143320")]
		internal AIDGEFHMIOM<Guid> MGHDLACACIO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x8142E80", Offset = "0x8141A80", VA = "0x188142E80")]
		internal void FBBAAFBIOFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x8142EB0", Offset = "0x8141AB0", VA = "0x188142EB0")]
		internal void LBNCIAKONBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x8142F10", Offset = "0x8141B10", VA = "0x188142F10")]
		internal void MAKMLIPHCPP(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x8142E50", Offset = "0x8141A50", VA = "0x188142E50")]
		internal void AGOHINGJMPP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class ECDDMDCMCGK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public FHEIHJHEAGN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public string keepsakePickupName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public int collectedKeepsakeCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public int collectableKeepsakeCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public Guid keepsakeInstanceId;

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public ECDDMDCMCGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8143560", Offset = "0x8142160", VA = "0x188143560")]
		internal void GPHFGOMOJFD(CFOFIOIMKBJ response)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x8143500", Offset = "0x8142100", VA = "0x188143500")]
		internal void EBKGNGDFIKD(string error)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class HKCAICDJOKE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public KeepsakeTheme theme;

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public HKCAICDJOKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8151F40", Offset = "0x8150B40", VA = "0x188151F40")]
		internal bool GPGJOPCECDN(KeepsakeCategoryThemePair categoryThemePair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class ACEJIAIMOCA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public FHEIHJHEAGN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public long progressionEventId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public HINJKNFEFAE? keepsakeCategory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public ACEJIAIMOCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x8142600", Offset = "0x8141200", VA = "0x188142600")]
		internal void KOFABMJJHKO(KeepsakeProgressionEventInstancesDTO result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x81425D0", Offset = "0x81411D0", VA = "0x1881425D0")]
		internal void IEHIKAPGHCJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x81422D0", Offset = "0x8140ED0", VA = "0x1881422D0")]
		internal AIDGEFHMIOM<IEnumerable<Guid>> BOMOAHHLDFM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x7C455E0", Offset = "0x7C441E0", VA = "0x187C455E0")]
		internal bool GDNPNHPGPIP(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class FPFBIFOBIHL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public KeepsakeRoomInstanceIdsDTO instancesInRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public ACEJIAIMOCA CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public FPFBIFOBIHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x8151D70", Offset = "0x8150970", VA = "0x188151D70")]
		internal AIDGEFHMIOM<IEnumerable<Guid>> IMMLLAKGNPL(KeepsakeRoomInstancesDTO roomInstancesDTO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class LBPFEICOMPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public KeepsakeRoomInstancesDTO roomInstancesDTO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public FPFBIFOBIHL CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public LBPFEICOMPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x8152790", Offset = "0x8151390", VA = "0x188152790")]
		internal bool MCBOCBJONPH(Guid instanceId)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class JMLJHNJCNOF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Guid instanceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public LBPFEICOMPJ CS$<>8__locals3;

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public JMLJHNJCNOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x8152170", Offset = "0x8150D70", VA = "0x188152170")]
		internal bool BAHPHPBLBOB(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class ELNKHNJPEAE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public FHEIHJHEAGN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public ELNKHNJPEAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x8143B30", Offset = "0x8142730", VA = "0x188143B30")]
		internal AIDGEFHMIOM<IEnumerable<Guid>> CONNOBDCLGC(IEnumerable<Guid> instanceIds)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x8143B10", Offset = "0x8142710", VA = "0x188143B10")]
		internal bool MJNOBJJNLHF(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class NPCGIBJKGDA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public FHEIHJHEAGN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public long progressionEventId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public NPCGIBJKGDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x8152D50", Offset = "0x8151950", VA = "0x188152D50")]
		internal void LEKIKELOLPI(KeepsakeProgressionEventInstancesDTO result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x81425D0", Offset = "0x81411D0", VA = "0x1881425D0")]
		internal void MIFEOPHOHBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x8152A60", Offset = "0x8151660", VA = "0x188152A60")]
		internal AIDGEFHMIOM<Dictionary<Guid, HINJKNFEFAE>> FGBLIGIBOAH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x7C455E0", Offset = "0x7C441E0", VA = "0x187C455E0")]
		internal bool NDOHKFALKIE(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class ANNMLAELJKM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public KeepsakeRoomInstanceIdsDTO instancesInRoom;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public ANNMLAELJKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x8142690", Offset = "0x8141290", VA = "0x188142690")]
		internal AIDGEFHMIOM<Dictionary<Guid, HINJKNFEFAE>> DKFDHPKCLKF(KeepsakeRoomInstancesDTO roomInstancesDTO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class JNCNNKAHJHB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public KeepsakeRoomInstancesDTO roomInstancesDTO;

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public JNCNNKAHJHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x8152370", Offset = "0x8150F70", VA = "0x188152370")]
		internal bool PIJGHNPDGLM(Guid instanceId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x8152220", Offset = "0x8150E20", VA = "0x188152220")]
		internal KeyValuePair<Guid, HINJKNFEFAE> OPDJDCJPABO(Guid instanceId)
		{
			return default(KeyValuePair<Guid, HINJKNFEFAE>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class JNAMDKNMOOA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public Guid instanceId;

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public JNAMDKNMOOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x27C34A0", Offset = "0x27C20A0", VA = "0x1827C34A0")]
		internal bool MHAFDCMHHOI(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class DNCHFPGGEKG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public Guid instanceId;

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public DNCHFPGGEKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x27C34A0", Offset = "0x27C20A0", VA = "0x1827C34A0")]
		internal bool DCMFAHLDNJI(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class EKDFNOBNBEL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public FHEIHJHEAGN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public EKDFNOBNBEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x8143910", Offset = "0x8142510", VA = "0x188143910")]
		internal AIDGEFHMIOM<Dictionary<Guid, HINJKNFEFAE>> BHFCPHFJGGF(Dictionary<Guid, HINJKNFEFAE> instanceIdsAndCategories)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x8143B10", Offset = "0x8142710", VA = "0x188143B10")]
		internal bool HFDJMHCENJG(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class DNNKGIODACD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public KeepsakeRoomInstanceIdsDTO collectedInstanceIds;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public DNNKGIODACD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x8143480", Offset = "0x8142080", VA = "0x188143480")]
		internal bool ELHPNIHHHBK(KeyValuePair<Guid, HINJKNFEFAE> idCategoryPair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class COGNLEHEDAF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public Dictionary<Guid, HINJKNFEFAE> instanceIdsAndCategories;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public COGNLEHEDAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x8142B30", Offset = "0x8141730", VA = "0x188142B30")]
		internal KeyValuePair<HINJKNFEFAE, int> JKICIPAGLFA(HINJKNFEFAE category)
		{
			return default(KeyValuePair<HINJKNFEFAE, int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class IFMJJHIDNAE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public HINJKNFEFAE category;

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public IFMJJHIDNAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0xF37C50", Offset = "0xF36850", VA = "0x180F37C50")]
		internal bool BMJGMKCPEHN(HINJKNFEFAE instanceCategory)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class JEBEEGMKFMN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public Dictionary<Guid, HINJKNFEFAE> instanceIdsAndCategories;

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public JEBEEGMKFMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x8152020", Offset = "0x8150C20", VA = "0x188152020")]
		internal KeyValuePair<HINJKNFEFAE, int> IDJIJIHNBCM(HINJKNFEFAE category)
		{
			return default(KeyValuePair<HINJKNFEFAE, int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class CDPLJMDIKAC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public HINJKNFEFAE category;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public CDPLJMDIKAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0xF37C50", Offset = "0xF36850", VA = "0x180F37C50")]
		internal bool KEOFBKBFBAK(HINJKNFEFAE instanceCategory)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class CPIIGADDPGI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public FHEIHJHEAGN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public Func<KeepsakeRoomDTO, bool> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public CPIIGADDPGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x8142CA0", Offset = "0x81418A0", VA = "0x188142CA0")]
		internal bool HCPAJNBNOFF(DateTime nowUtc, DateTime eventStartTime, int roomOrder, TimeSpan unlockStartOffset, TimeSpan unlockInterval, int unlockBatchSize)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x8142D90", Offset = "0x8141990", VA = "0x188142D90")]
		internal bool PAKCKKCBGHD(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x8142C80", Offset = "0x8141880", VA = "0x188142C80")]
		internal bool OILGEABPIIE(KeepsakeRoomDTO r)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x8142C80", Offset = "0x8141880", VA = "0x188142C80")]
		internal bool BFCDAAMBHGI(KeepsakeRoomDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class GFLDBEGAPJJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public GFLDBEGAPJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0xF9D970", Offset = "0xF9C570", VA = "0x180F9D970")]
		internal bool NAIGLFLKJIJ(KeepsakeRoomListDTO roomList)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class NEIFEGOBMCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public Func<KeepsakeRoomDTO, bool> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public NEIFEGOBMCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x81529A0", Offset = "0x81515A0", VA = "0x1881529A0")]
		internal bool IEBFKPHOOJI(KeepsakeRoomListDTO roomList)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x2766570", Offset = "0x2765170", VA = "0x182766570")]
		internal bool LLEEHAFBKFH(KeepsakeRoomDTO room)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class HFIFNODMAAP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public HFIFNODMAAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x8151EE0", Offset = "0x8150AE0", VA = "0x188151EE0")]
		internal bool GHGJEIEIDEE(KeepsakeRoomListDTO i)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class CPDINOCFICK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public CPDINOCFICK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0xF9D970", Offset = "0xF9C570", VA = "0x180F9D970")]
		internal bool LLPGKHLKJKO(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class FAMENHDJMIE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public Guid keepsakeInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public FAMENHDJMIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x8143CA0", Offset = "0x81428A0", VA = "0x188143CA0")]
		internal bool GKLEGBHJHCL(KeyValuePair<Guid, KeepsakeInstanceDTO> instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class NOCDGNDCJMJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public HINJKNFEFAE keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public NOCDGNDCJMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x236E260", Offset = "0x236CE60", VA = "0x18236E260")]
		internal bool NIKIKHEGGCO(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class LOGKPMDODGJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public Guid keepsakeInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public LOGKPMDODGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x81528C0", Offset = "0x81514C0", VA = "0x1881528C0")]
		internal bool LNFNPKANIOF(KeyValuePair<Guid, KeepsakeInstanceDTO> instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class IIMCIBNMFHO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public HINJKNFEFAE keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public IIMCIBNMFHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x8151FE0", Offset = "0x8150BE0", VA = "0x188151FE0")]
		internal bool CNOGCOALKBD(KeyValuePair<Guid, HINJKNFEFAE> x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class OALEJCIECPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public HINJKNFEFAE newKeepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public OALEJCIECPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x236E260", Offset = "0x236CE60", VA = "0x18236E260")]
		internal bool DCNPFMJAPGG(KeepsakeInstanceDTO instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class MEHBEJMPFIB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public long currentRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public long? currentSubRoomId;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public MEHBEJMPFIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x8152920", Offset = "0x8151520", VA = "0x188152920")]
		internal bool GFEBOOOPJOL(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class KBKNNBALJPA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public IReadOnlyList<KeepsakeRoomListDTO> roomList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public KBKNNBALJPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x8152450", Offset = "0x8151050", VA = "0x188152450")]
		internal bool LHMOMIBDAGO(KeepsakeRoomDTO room)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class HPPGPNLAHJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public KeepsakeRoomDTO room;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public KBKNNBALJPA CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public HPPGPNLAHJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x8151F60", Offset = "0x8150B60", VA = "0x188151F60")]
		internal bool GOKKCDDBHDF(KeepsakeRoomListDTO roomListDto)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private struct AAKKCFMMLMK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public FHEIHJHEAGN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public KMDFPIFPLDI args;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x8141D40", Offset = "0x8140940", VA = "0x188141D40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x8142270", Offset = "0x8140E70", VA = "0x188142270", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private struct BEHFIKFJEIJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public TimeSpan delay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public FHEIHJHEAGN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public string message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x8142840", Offset = "0x8141440", VA = "0x188142840", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x8142AD0", Offset = "0x81416D0", VA = "0x188142AD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly DateTime EFACPPHIHMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly GNNHJGKDEMF PANHMDCENKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly MMDKHKEFECB LHIMCPHKAHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly FOCDAHMCAPG HGCDEBJBPAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly ACCCEGLMGPP FCBBPCLEBJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly JPPFLHIEAKP NGAPIMCMAAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly FMOPLFDGOJL GPNPECGNIDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly GAKJFMFPCFO FFCKLGIKLOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly ACODFCDONDP OMNFPJIOKPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly DKCBALPBFPJ ABKELJNOFBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly KPIOJAPJACJ EEFIGGOLNDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly GAKOHEPJGKD AINLEFBBHJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly MDHEJJOELKA FBMJJMABGKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly BGFMEDCIGJB NBIBGELPJGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly OCOIGMOIADB DDBAJAMNMLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly MBDBKJKILHH LOAKGGDNOOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly DEMOIOHLLCD<KeepsakesConfig.KeepsakesOptions> ENJHAFMCLFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly CEDFNINGHPN NCAMCGOHDNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly Dictionary<Guid, KeepsakeInstanceDTO> CDGOENBHLDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly HashSet<Guid> JFPHOMHAHOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly HashSet<long> JNPDGHDOBMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private Dictionary<HINJKNFEFAE, int> BBDNCFHFHJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly HashSet<Guid> EHJHICDKGMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly IDisposable LDKDKJFBPKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private Task POIAOCIMLOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private AIDGEFHMIOM<Guid> MLOMMEIHHJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private long? DJGINJCGKHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private KeepsakeProgressionEventInstancesDTO JKFANBBMJNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private AIDGEFHMIOM<KeepsakeProgressionEventInstancesDTO> JDBMIEMIENL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private IReadOnlyDictionary<HINJKNFEFAE, KeepsakeCategoryConfigDTO> FBMLLPAFNBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private KeepsakeGlobalConfigDTO KEMLPEMDLLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private HashSet<long> FPHCDFLOICM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private HashSet<long> MKIDFIKIHNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private List<KeepsakeRoomListDTO> OCKGKBHLLEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private List<KeepsakeRoomListDTO> FJJLNHLLIPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private List<KeepsakeRoomListDTO> IOJFFDGOOFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private Dictionary<long, string> GHPNOKMNDFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private Dictionary<long, string> PMBMGAAKMHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private Dictionary<long, DateTime> PKGGGCBFGEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private Dictionary<long, List<KeepsakeRoomDTO>> EJIGBGPOKLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private Dictionary<long, List<KeepsakeRoomDTO>> DLMJCFFICAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private Dictionary<long, long> JMADBAIMHOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly List<string> MGBDDEJHDIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private DateTime DLCLFOKHDKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly IDisposable DCOMLBNILMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private Dictionary<Guid, HINJKNFEFAE> MANDFAODDEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private Dictionary<HINJKNFEFAE, int> ABJDGFBPGCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private List<KeepsakeCategoryThemePair> NLFNIJOEHCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private OHAMNDFFCPN LDMGCHDMADD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private bool JIDEEBOOEHD;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool OHNCHIKNNAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA8A4F0", Offset = "0xA890F0", VA = "0x180A8A4F0", Slot = "53")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA8A270", Offset = "0xA88E70", VA = "0x180A8A270")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool HJIKMJKMOJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8145110", Offset = "0x8143D10", VA = "0x188145110", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool LHOEKCMMBOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8143FA0", Offset = "0x8142BA0", VA = "0x188143FA0", Slot = "36")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private long BOLDGNFGKHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8146B10", Offset = "0x8145710", VA = "0x188146B10")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private long? FANJMBPKJJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x81504B0", Offset = "0x814F0B0", VA = "0x1881504B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private bool OCLIHKKACOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x814D9A0", Offset = "0x814C5A0", VA = "0x18814D9A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public IReadOnlyList<KeepsakeRoomListDTO> IJGEMCEEEDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xBB7E40", Offset = "0xBB6A40", VA = "0x180BB7E40", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public IReadOnlyList<KeepsakeRoomListDTO> NPJCKGBIAGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xBB96F0", Offset = "0xBB82F0", VA = "0x180BB96F0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IReadOnlyList<KeepsakeRoomListDTO> CHALMOMEJGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xBCA2C0", Offset = "0xBC8EC0", VA = "0x180BCA2C0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public IReadOnlyDictionary<long, string> OMGFHPGBGBG
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xBB7E70", Offset = "0xBB6A70", VA = "0x180BB7E70", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	internal bool NGELBPADGOB
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xB1BE50", Offset = "0xB1AA50", VA = "0x180B1BE50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Guid?> CCLKBKOBLCD
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8149B80", Offset = "0x8148780", VA = "0x188149B80", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8144110", Offset = "0x8142D10", VA = "0x188144110", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action BLKMNINNMNP
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8148920", Offset = "0x8147520", VA = "0x188148920", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x814F6F0", Offset = "0x814E2F0", VA = "0x18814F6F0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action EJNFOIMCMCM
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8147370", Offset = "0x8145F70", VA = "0x188147370", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x814F510", Offset = "0x814E110", VA = "0x18814F510", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x81507A0", Offset = "0x814F3A0", VA = "0x1881507A0")]
	[RecRoom.NoEngine.Common.Preserve]
	internal FHEIHJHEAGN([HAKCNCGPHPD(null)][NotNull] GNNHJGKDEMF PANHMDCENKO, [NotNull][HAKCNCGPHPD(null)] CGIGLIONEGJ GIPGNPNHAHB, [NotNull][HAKCNCGPHPD(null)] MMDKHKEFECB LHIMCPHKAHD, [NotNull][HAKCNCGPHPD(null)] FOCDAHMCAPG HGCDEBJBPAK, [HAKCNCGPHPD(null)][NotNull] ACCCEGLMGPP FCBBPCLEBJC, [HAKCNCGPHPD(null)][NotNull] JPPFLHIEAKP NGAPIMCMAAI, [HAKCNCGPHPD(null)][NotNull] FMOPLFDGOJL GPNPECGNIDF, [NotNull][HAKCNCGPHPD(null)] GAKJFMFPCFO FFCKLGIKLOP, [NotNull][HAKCNCGPHPD(null)] ACODFCDONDP OMNFPJIOKPC, [NotNull][HAKCNCGPHPD(null)] PACCLKJAGAG EKOGIECBMGF, [NotNull][HAKCNCGPHPD(null)] DKCBALPBFPJ ABKELJNOFBE, [NotNull][HAKCNCGPHPD(null)] KPIOJAPJACJ EEFIGGOLNDM, [NotNull][HAKCNCGPHPD(null)] GAKOHEPJGKD AINLEFBBHJF, [NotNull][HAKCNCGPHPD(null)] MDHEJJOELKA FBMJJMABGKK, [HAKCNCGPHPD(null)][NotNull] BGFMEDCIGJB NBIBGELPJGE, [HAKCNCGPHPD(null)][NotNull] OCOIGMOIADB DDBAJAMNMLK, [NotNull][HAKCNCGPHPD(null)] MBDBKJKILHH LOAKGGDNOOO, [HAKCNCGPHPD(null)][NotNull] DEMOIOHLLCD<KeepsakesConfig.KeepsakesOptions> ENJHAFMCLFP, [NotNull][HAKCNCGPHPD(null)] CEDFNINGHPN NCAMCGOHDNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x8150120", Offset = "0x814ED20", VA = "0x188150120", Slot = "15")]
	public bool PBNLCFEJAFP(List<string> LNCBNJGPLBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x8148300", Offset = "0x8146F00", VA = "0x188148300", Slot = "16")]
	public AIDGEFHMIOM<Guid> GGAECPDHPMI(HINJKNFEFAE IHIJKMLLOBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x81490A0", Offset = "0x8147CA0", VA = "0x1881490A0", Slot = "17")]
	public IPNMFPLCPOG HBGJKPIPFKH(Guid FIKJJNJEAPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x814A130", Offset = "0x8148D30", VA = "0x18814A130", Slot = "18")]
	public IPNMFPLCPOG IBMFONCBCHJ(Guid FIKJJNJEAPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x8146EC0", Offset = "0x8145AC0", VA = "0x188146EC0", Slot = "19")]
	public bool EPBDGIMFOJK(Guid FIKJJNJEAPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x814E060", Offset = "0x814CC60", VA = "0x18814E060", Slot = "20")]
	public bool NANNLEKHEFM(Guid FIKJJNJEAPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x8145310", Offset = "0x8143F10", VA = "0x188145310")]
	public KeepsakeTheme DBOPAFAPLCD(Guid FIKJJNJEAPJ)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x814BD00", Offset = "0x814A900", VA = "0x18814BD00")]
	public bool KKDLHCEHKLC(HINJKNFEFAE IHIJKMLLOBC, [Out] KeepsakeTheme OJFEHNPNALJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x81457F0", Offset = "0x81443F0", VA = "0x1881457F0")]
	public List<KeepsakeTheme> DGIHEPKCHBH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x81494C0", Offset = "0x81480C0", VA = "0x1881494C0")]
	public int HHKCCCDEDOA(HINJKNFEFAE IHIJKMLLOBC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x814B8C0", Offset = "0x814A4C0", VA = "0x18814B8C0")]
	public HINJKNFEFAE JNLBGOEHMHM(Guid FIKJJNJEAPJ)
	{
		return default(HINJKNFEFAE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x81451C0", Offset = "0x8143DC0", VA = "0x1881451C0", Slot = "34")]
	public List<HINJKNFEFAE> DBOOFFBGPNL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x814C410", Offset = "0x814B010", VA = "0x18814C410", Slot = "35")]
	public IComparer<HINJKNFEFAE> LKCOAMLLEOG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x814F7B0", Offset = "0x814E3B0", VA = "0x18814F7B0", Slot = "32")]
	public string OKNGLEDNFNI(HINJKNFEFAE IHIJKMLLOBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x814C220", Offset = "0x814AE20", VA = "0x18814C220", Slot = "33")]
	public string LIJAOBLJNGP(HINJKNFEFAE IHIJKMLLOBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x8143D00", Offset = "0x8142900", VA = "0x188143D00", Slot = "21")]
	public bool ABPOJOODFBH(Guid FIKJJNJEAPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x814B850", Offset = "0x814A450", VA = "0x18814B850", Slot = "22")]
	public void JJEHGOKPAAM(Guid FIKJJNJEAPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x81489C0", Offset = "0x81475C0", VA = "0x1881489C0", Slot = "23")]
	public void GNFEKHINOMM(HINJKNFEFAE IHIJKMLLOBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x8150560", Offset = "0x814F160", VA = "0x188150560", Slot = "24")]
	public void PLGDCHGANPM(Guid FIKJJNJEAPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x814F930", Offset = "0x814E530", VA = "0x18814F930", Slot = "25")]
	public int OLKGDMKHPFJ()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x8147A90", Offset = "0x8146690", VA = "0x188147A90", Slot = "31")]
	public AIDGEFHMIOM<IEnumerable<Guid>> GDDENJFEDJJ(long MJILNJAJHOI, long KCMBLIMEDJJ, HINJKNFEFAE? IHIJKMLLOBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x8149320", Offset = "0x8147F20", VA = "0x188149320", Slot = "30")]
	public AIDGEFHMIOM<IEnumerable<Guid>> HDFMLBIMJME(long MJILNJAJHOI, long KCMBLIMEDJJ, HINJKNFEFAE? IHIJKMLLOBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x8144B70", Offset = "0x8143770", VA = "0x188144B70", Slot = "54")]
	public AIDGEFHMIOM<Dictionary<Guid, HINJKNFEFAE>> BNJPGKLLAAI(long MJILNJAJHOI, long KCMBLIMEDJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x814FF90", Offset = "0x814EB90", VA = "0x18814FF90", Slot = "55")]
	public AIDGEFHMIOM<Dictionary<Guid, HINJKNFEFAE>> ONHIEMEGJCP(long MJILNJAJHOI, long KCMBLIMEDJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x814A7B0", Offset = "0x81493B0", VA = "0x18814A7B0", Slot = "26")]
	public AIDGEFHMIOM<int> IDGGNOGPIII(long MJILNJAJHOI, long KCMBLIMEDJJ, HINJKNFEFAE? IHIJKMLLOBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x814E090", Offset = "0x814CC90", VA = "0x18814E090", Slot = "27")]
	public AIDGEFHMIOM<int> NCCGBMDHHIC(long MJILNJAJHOI, long KCMBLIMEDJJ, HINJKNFEFAE? IHIJKMLLOBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x814D9B0", Offset = "0x814C5B0", VA = "0x18814D9B0", Slot = "28")]
	public AIDGEFHMIOM<Dictionary<HINJKNFEFAE, int>> MOHCLJBPFBA(long MJILNJAJHOI, long KCMBLIMEDJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x81479D0", Offset = "0x81465D0", VA = "0x1881479D0", Slot = "29")]
	public AIDGEFHMIOM<Dictionary<HINJKNFEFAE, int>> GBPDOONJKNE(long MJILNJAJHOI, long KCMBLIMEDJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x81450B0", Offset = "0x8143CB0", VA = "0x1881450B0", Slot = "37")]
	public bool CBMMGKHAMLA(long MJILNJAJHOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x8145160", Offset = "0x8143D60", VA = "0x188145160", Slot = "56")]
	public bool COFIFNLLIAB(long MJILNJAJHOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x8147F80", Offset = "0x8146B80", VA = "0x188147F80", Slot = "38")]
	public bool GEGNDHGHFGN(long MJILNJAJHOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x814DBC0", Offset = "0x814C7C0", VA = "0x18814DBC0", Slot = "57")]
	public bool MPGGJLPMEOJ(long MJILNJAJHOI, [Out] FOFIELFGFDD JLJHBKCLFCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x814F5B0", Offset = "0x814E1B0", VA = "0x18814F5B0", Slot = "39")]
	public bool NNIFDBOHJBN(long MGDCJAMDHOE, [Out] DateTime HPPECFPKHEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x8149640", Offset = "0x8148240", VA = "0x188149640", Slot = "40")]
	public long HKGANLCOLDE(long MGDCJAMDHOE)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x8144A00", Offset = "0x8143600", VA = "0x188144A00", Slot = "41")]
	public long BHABEHDIHOH(long MJILNJAJHOI)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x814A5D0", Offset = "0x81491D0", VA = "0x18814A5D0", Slot = "42")]
	public int IDFPJANDCBO(long MGDCJAMDHOE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x8147290", Offset = "0x8145E90", VA = "0x188147290", Slot = "43")]
	public bool FDHFAFIJGED()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x8145BA0", Offset = "0x81447A0", VA = "0x188145BA0", Slot = "44")]
	public bool DGLAHOLEIAD(long MGDCJAMDHOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x8146030", Offset = "0x8144C30", VA = "0x188146030", Slot = "45")]
	public IReadOnlyList<long> DLLNNHIMJDJ(long MGDCJAMDHOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x814C870", Offset = "0x814B470", VA = "0x18814C870", Slot = "46")]
	public int LLLLKNPBMMO(long MGDCJAMDHOE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x814C5B0", Offset = "0x814B1B0", VA = "0x18814C5B0", Slot = "50")]
	public long LLKEOAMDKND(long HFMLOCIAIAO)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x814C920", Offset = "0x814B520", VA = "0x18814C920", Slot = "51")]
	public HINJKNFEFAE LMOLHCDCNJC()
	{
		return default(HINJKNFEFAE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x8147E50", Offset = "0x8146A50", VA = "0x188147E50")]
	private bool GEBLGCDMKJG(Guid FIKJJNJEAPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x814AA60", Offset = "0x8149660", VA = "0x18814AA60")]
	private void IFMHPPJLGBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x8148020", Offset = "0x8146C20", VA = "0x188148020")]
	private HINJKNFEFAE GFGNOHAJPGK()
	{
		return default(HINJKNFEFAE);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x814B0A0", Offset = "0x8149CA0", VA = "0x18814B0A0")]
	private void IOLLBHJJBIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x81446A0", Offset = "0x81432A0", VA = "0x1881446A0")]
	private int ANNNALIFEHB(KeepsakeRoomListDTO HGGAGBEGFPI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x814D8A0", Offset = "0x814C4A0", VA = "0x18814D8A0")]
	private int MIDGKFJCBNN(DateTime AHHHNKKKGLL, DateTime NELNPJPPLFK, TimeSpan DPBJIDBICFA, int CNDKAIMFMCP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x8144410", Offset = "0x8143010", VA = "0x188144410")]
	private void ANCNAAPHHCD(IEnumerable<KeepsakeInstanceDTO> CDGOENBHLDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x81441C0", Offset = "0x8142DC0", VA = "0x1881441C0")]
	private void AKMLFJEGFAG(IEnumerable<KeepsakeCollectionRecordDTO> GIOAGMENHJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x814D840", Offset = "0x814C440", VA = "0x18814D840")]
	private void MFCLCIPHBIL(IEnumerable<long> IDMIIGNMIBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0xB1D0F0", Offset = "0xB1BCF0", VA = "0x180B1D0F0")]
	private void AKGPHDIPJPG(KeepsakeGlobalConfigDTO KEMLPEMDLLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x814D5D0", Offset = "0x814C1D0", VA = "0x18814D5D0")]
	private bool MEIKBIPJFNG(HINJKNFEFAE IHIJKMLLOBC, [Out] Guid KJJELGNEJLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x814BEE0", Offset = "0x814AAE0", VA = "0x18814BEE0")]
	private bool KKPDJGIPCNO([Out] Guid KJJELGNEJLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x8147230", Offset = "0x8145E30", VA = "0x188147230")]
	private bool FCHENKEPLON(Guid FIKJJNJEAPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x8145D30", Offset = "0x8144930", VA = "0x188145D30")]
	private IEnumerable<Guid> DJDGHOKJKPJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x8146890", Offset = "0x8145490", VA = "0x188146890")]
	private IEnumerable<KeepsakeInstanceDTO> EDCACAPEEPO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x814C190", Offset = "0x814AD90", VA = "0x18814C190")]
	private void LGFBAPBALKG(Guid FIKJJNJEAPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x814BC50", Offset = "0x814A850", VA = "0x18814BC50")]
	private bool KJOOKHCOLNA(Guid FIKJJNJEAPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x8145E90", Offset = "0x8144A90", VA = "0x188145E90")]
	private void DKHJCIECBAE(Guid FIKJJNJEAPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x814BF80", Offset = "0x814AB80", VA = "0x18814BF80")]
	private void KLAJPJBFFEG(HINJKNFEFAE CJIPCCCFEPA, int BEAONNGPBDP, Dictionary<HINJKNFEFAE, int> EHDEINBIHPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x814DF70", Offset = "0x814CB70", VA = "0x18814DF70")]
	private int MPPCFONHLEF(HINJKNFEFAE IHIJKMLLOBC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x8145620", Offset = "0x8144220", VA = "0x188145620")]
	private void DFFDDCAHBDA(KeepsakeInstanceDTO FGAMJFDPGJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x814BA20", Offset = "0x814A620", VA = "0x18814BA20")]
	private void JOMCFJDMECK(KeepsakeInstanceDTO FGAMJFDPGJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x814CC90", Offset = "0x814B890", VA = "0x18814CC90")]
	private void LOBCICDKJGM(Guid FIKJJNJEAPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x8144060", Offset = "0x8142C60", VA = "0x188144060")]
	private void FKONAPADODA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x8150540", Offset = "0x814F140", VA = "0x188150540")]
	private void PJOABNFMPJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x814C3A0", Offset = "0x814AFA0", VA = "0x18814C3A0")]
	private void LJKGAGCDOID(KFDMJFDHECO DOAMFFHFJCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x8144060", Offset = "0x8142C60", VA = "0x188144060")]
	private void NNBICMNKHIG(NCPNPOFGOIM KOJLNGLNBMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x8144060", Offset = "0x8142C60", VA = "0x188144060")]
	private void ADKFCGMLBGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x8148D00", Offset = "0x8147900", VA = "0x188148D00")]
	private void HAKFCBFBGFO(float PGNEIGACMBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x8147410", Offset = "0x8146010", VA = "0x188147410")]
	private void FLNNCCLICAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x814FD90", Offset = "0x814E990", VA = "0x18814FD90")]
	private bool OMENOHEHHIL(Guid FIKJJNJEAPJ, [Out] string CFPJFOCGANO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x8145450", Offset = "0x8144050", VA = "0x188145450")]
	private bool DFAOGHFKAAB(Guid FIKJJNJEAPJ, [Out] KeepsakeCategoryConfigDTO CJIPCCCFEPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x8147150", Offset = "0x8145D50", VA = "0x188147150")]
	private void FBAABCFPHJH(string BCBLEPPKJPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x8148BF0", Offset = "0x81477F0", VA = "0x188148BF0")]
	private bool GOELMGMACID()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x8146BE0", Offset = "0x81457E0", VA = "0x188146BE0")]
	private List<long> ELDJKJEOIAB(IEnumerable<KeepsakeRoomDTO> PEKDAJFKFFH, IReadOnlyList<KeepsakeRoomListDTO> CJBDOIIBKAP, long MGDCJAMDHOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x814D060", Offset = "0x814BC60", VA = "0x18814D060")]
	private bool LPICMDLHLLK(Guid FIKJJNJEAPJ, [Out] string PDIIGKEPNLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x814F0F0", Offset = "0x814DCF0", VA = "0x18814F0F0", Slot = "47")]
	public string NKGAIKFIHBL(FKFMOFGFJGD EAMKOMCEHEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x8149C30", Offset = "0x8148830", VA = "0x188149C30", Slot = "49")]
	public string HMBJDDDEFJC(FKFMOFGFJGD EAMKOMCEHEE, long MJILNJAJHOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x814A050", Offset = "0x8148C50", VA = "0x18814A050", Slot = "48")]
	public string IBCMFMPABGM(FKFMOFGFJGD EAMKOMCEHEE, int ABBLJKKOOOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x814E1F0", Offset = "0x814CDF0", VA = "0x18814E1F0")]
	private void NDDDNBKKFND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x8144F20", Offset = "0x8143B20", VA = "0x188144F20")]
	private void BNNIGGMKBIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x814FD70", Offset = "0x814E970", VA = "0x18814FD70")]
	private FKFMOFGFJGD OLPCPDFDMPB(BPBBJBLDIPA KOOHJGFFMIP)
	{
		return default(FKFMOFGFJGD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x814BC30", Offset = "0x814A830", VA = "0x18814BC30")]
	private FKFMOFGFJGD KGPMLIPJHKB(BPBBJBLDIPA KOOHJGFFMIP)
	{
		return default(FKFMOFGFJGD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x8148A10", Offset = "0x8147610", VA = "0x188148A10")]
	internal static string GNNBDHKMFNH(CFOFIOIMKBJ FLHCCHCJDKE, string DJJHPDACKOG, bool KLPMJLEJJNP, int PENIHIIBJBF, int EECHKHOPMJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x8146430", Offset = "0x8145030", VA = "0x188146430", Slot = "52")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x8144090", Offset = "0x8142C90", VA = "0x188144090")]
	private OODMIMAFAPJ AEBJJBLPNAF(PLCCGHEKGIM IDMBPFFAEOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x8146950", Offset = "0x8145550", VA = "0x188146950")]
	private EMINEFLFECB EFGEKNPAPLE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x814F150", Offset = "0x814DD50", VA = "0x18814F150")]
	private Task NLBBCMPGNBN(KMDFPIFPLDI AHEPAEIEJIO, CancellationToken JHCOCAANJDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x814A4C0", Offset = "0x81490C0", VA = "0x18814A4C0")]
	[AsyncStateMachine(typeof(AAKKCFMMLMK))]
	private Task IDEHILGCLOP(KMDFPIFPLDI AHEPAEIEJIO, CancellationToken JHCOCAANJDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x814C4D0", Offset = "0x814B0D0", VA = "0x18814C4D0")]
	private Task LKPEGJAJFOI(KMDFPIFPLDI AHEPAEIEJIO, CancellationToken JHCOCAANJDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x8147020", Offset = "0x8145C20", VA = "0x188147020")]
	[AsyncStateMachine(typeof(BEHFIKFJEIJ))]
	private Task EPINOCPDDOP(string HLMEMBFCHLD, TimeSpan GOMONLIGLJP, CancellationToken JHCOCAANJDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x814F790", Offset = "0x814E390", VA = "0x18814F790")]
	[CompilerGenerated]
	private void OFBJJDINDGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x814D580", Offset = "0x814C180", VA = "0x18814D580")]
	[CompilerGenerated]
	private void MDPLGHGMFOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x81503B0", Offset = "0x814EFB0", VA = "0x1881503B0")]
	[CompilerGenerated]
	private bool PEGJAHOLIFB(KeepsakeInstanceDTO LGCEHLADNJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x814AF30", Offset = "0x8149B30", VA = "0x18814AF30")]
	[CompilerGenerated]
	private AIDGEFHMIOM<Dictionary<HINJKNFEFAE, int>> IOLJCNLIIGP(Dictionary<Guid, HINJKNFEFAE> CCEGCCFOONM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x814B6E0", Offset = "0x814A2E0", VA = "0x18814B6E0")]
	[CompilerGenerated]
	private AIDGEFHMIOM<Dictionary<HINJKNFEFAE, int>> JACMHLLAKIF(Dictionary<Guid, HINJKNFEFAE> CCEGCCFOONM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x81479B0", Offset = "0x81465B0", VA = "0x1881479B0")]
	[CompilerGenerated]
	private bool GAIAPFKKMAO(KeepsakeRoomListDTO LGCEHLADNJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x814C060", Offset = "0x814AC60", VA = "0x18814C060")]
	[CompilerGenerated]
	private bool KPIGOBDLDGB(KeepsakeInstanceDTO LGCEHLADNJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x81462A0", Offset = "0x8144EA0", VA = "0x1881462A0")]
	[CompilerGenerated]
	private void DMLMBIALHGE(Tuple<KeepsakeRoomInstancesDTO, IReadOnlyDictionary<HINJKNFEFAE, KeepsakeCategoryConfigDTO>, KeepsakeGlobalConfigDTO> GDMLMHKNJNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x8144B10", Offset = "0x8143710", VA = "0x188144B10")]
	[CompilerGenerated]
	private void BILPELJBHPF(string PDIIGKEPNLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x8144840", Offset = "0x8143440", VA = "0x188144840")]
	[CompilerGenerated]
	private Task BAPNDAGOENN(CancellationToken CCGJHGGGCLB)
	{
		return null;
	}
}
namespace RecRoom.Keepsakes
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public class KeepsakesConfig : ScriptableObject, DEMOIOHLLCD<KeepsakesConfig.KeepsakesOptions>
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200002B")]
		public class KeepsakesOptions
		{
			[Cpp2IlInjected.Token(Token = "0x200002C")]
			[CompilerGenerated]
			private sealed class HCMAHGFDDIK
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000098")]
				public string themeId;

				[Cpp2IlInjected.Token(Token = "0x60000F3")]
				[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
				public HCMAHGFDDIK()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000F4")]
				[Cpp2IlInjected.Address(RVA = "0x8151EB0", Offset = "0x8150AB0", VA = "0x188151EB0")]
				internal bool JFECGGPIMDA(KeepsakeTheme x)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60000F5")]
				[Cpp2IlInjected.Address(RVA = "0x8151EB0", Offset = "0x8150AB0", VA = "0x188151EB0")]
				internal bool FJNMDOHIBGM(KeepsakeTheme x)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			[SerializeField]
			private KeepsakeTheme[] themes;

			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x81525C0", Offset = "0x81511C0", VA = "0x1881525C0")]
			public bool HJKPBGPECNJ(string JNJLDABAMAL, [Out] KeepsakeTheme OJFEHNPNALJ)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		[SerializeField]
		private KeepsakesOptions options;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public KeepsakesOptions Value
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x8152540", Offset = "0x8151140", VA = "0x188152540")]
		[HHMPGEJNNFC.JKDCLEHGFFF.OKMFHHNNKLI]
		internal static void GDCJIDLIJAN(LGPCNHIHIDJ EHEGCBFMKDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0xCCB4F0", Offset = "0xCCA0F0", VA = "0x180CCB4F0")]
		public KeepsakesConfig()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public struct KeepsakeTheme
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public string ThemeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public int ThemeOrder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		[Header("Pickup")]
		public string PickupName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public AssetReference PickupPrefabReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public AudioClip PickupSfx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public float PickupSfxVolume;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		[Header("Colors")]
		public bool UseCustomColors;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public Color BeamColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public Color BaseColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		[Header("Looping Sound")]
		public AudioClip LoopingSfx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public float LoopingSfxVolume;
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
