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
	public class _AssemblyIndex : MGJKNLCKGOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6BE4640", Offset = "0x6BE3040", VA = "0x186BE4640", Slot = "8")]
		public override void KLIFGJHDPHO(DIMDGJNLMOK registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6283490", Offset = "0x6281E90", VA = "0x186283490")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class ENOABCOKPEM : IComparer<EFNAILPKJGE>
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private sealed class OABMHFHFAJF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public EFNAILPKJGE x;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public EFNAILPKJGE y;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
		public OABMHFHFAJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x111C030", Offset = "0x111AA30", VA = "0x18111C030")]
		internal bool OHBGLOBBMIJ(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x1550EC0", Offset = "0x154F8C0", VA = "0x181550EC0")]
		internal bool LODAIENAKKB(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x111C030", Offset = "0x111AA30", VA = "0x18111C030")]
		internal bool DLGOJHNFCKO(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1550EC0", Offset = "0x154F8C0", VA = "0x181550EC0")]
		internal bool KCOJFEHONLP(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private List<KeepsakeCategoryThemePair> JGENBOPGLEM;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x882870", Offset = "0x881270", VA = "0x180882870")]
	public ENOABCOKPEM(List<KeepsakeCategoryThemePair> BPNMFPDDHHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6BE2330", Offset = "0x6BE0D30", VA = "0x186BE2330", Slot = "4")]
	public int Compare(EFNAILPKJGE ICJCFEHCALD, EFNAILPKJGE MPEFCGEJLMG)
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
		public EFNAILPKJGE KeepsakeCategory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public KeepsakeTheme KeepsakeTheme;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[PLAFBFJHEAK]
public class DIJFODABEAA : HIJFLCFLCAJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class AJCFJEKOLGB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public DIJFODABEAA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public EFNAILPKJGE keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
		public AJCFJEKOLGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6BD39B0", Offset = "0x6BD23B0", VA = "0x186BD39B0")]
		internal CAPIMDIPLHM<Guid> PIMABMNPIJO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6BD3570", Offset = "0x6BD1F70", VA = "0x186BD3570")]
		internal void IKGPLBBGEOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6BD3510", Offset = "0x6BD1F10", VA = "0x186BD3510")]
		internal void HMKNHGPECFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6BD35A0", Offset = "0x6BD1FA0", VA = "0x186BD35A0")]
		internal void ILPGIDPOGOD(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6BD34E0", Offset = "0x6BD1EE0", VA = "0x186BD34E0")]
		internal void DPIADIDGNPJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class NCEIAKEMNHH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public DIJFODABEAA <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
		public NCEIAKEMNHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6BE3A90", Offset = "0x6BE2490", VA = "0x186BE3A90")]
		internal void NJPHFPPJFNG(CPIKMAMOKBM response)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6BE3A30", Offset = "0x6BE2430", VA = "0x186BE3A30")]
		internal void CLEJMDDBKNO(string error)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class EPKGIJPKMEE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public KeepsakeTheme theme;

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
		public EPKGIJPKMEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x6BE25E0", Offset = "0x6BE0FE0", VA = "0x186BE25E0")]
		internal bool CFLJKBLPKPG(KeepsakeCategoryThemePair categoryThemePair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class DGIECKFBMCP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public DIJFODABEAA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public long progressionEventId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public EFNAILPKJGE? keepsakeCategory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
		public DGIECKFBMCP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6BD3F50", Offset = "0x6BD2950", VA = "0x186BD3F50")]
		internal void ECNIPBCFLLP(KeepsakeProgressionEventInstancesDTO result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x6BD42E0", Offset = "0x6BD2CE0", VA = "0x186BD42E0")]
		internal void PAABLBBCFOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x6BD3FE0", Offset = "0x6BD29E0", VA = "0x186BD3FE0")]
		internal CAPIMDIPLHM<IEnumerable<Guid>> GAKILDIJADP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x6850640", Offset = "0x684F040", VA = "0x186850640")]
		internal bool NPDEJMFBHBP(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class CAFBCAMACIP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public KeepsakeRoomInstanceIdsDTO instancesInRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public DGIECKFBMCP CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
		public CAFBCAMACIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x6BD3CE0", Offset = "0x6BD26E0", VA = "0x186BD3CE0")]
		internal CAPIMDIPLHM<IEnumerable<Guid>> BHIJOCKGFIE(KeepsakeRoomInstancesDTO roomInstancesDTO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class NIKMAKDHPME
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public KeepsakeRoomInstancesDTO roomInstancesDTO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public CAFBCAMACIP CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
		public NIKMAKDHPME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x6BE3E40", Offset = "0x6BE2840", VA = "0x186BE3E40")]
		internal bool AKPIJJONGFP(Guid instanceId)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class CBIGMIPONCC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Guid instanceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public NIKMAKDHPME CS$<>8__locals3;

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
		public CBIGMIPONCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x6BD3E20", Offset = "0x6BD2820", VA = "0x186BD3E20")]
		internal bool BLPHMNBGDFA(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class PHPJFNCKLID
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public DIJFODABEAA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
		public PHPJFNCKLID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x6BE42C0", Offset = "0x6BE2CC0", VA = "0x186BE42C0")]
		internal CAPIMDIPLHM<IEnumerable<Guid>> LBLIAMIKONP(IEnumerable<Guid> instanceIds)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x6BE2D20", Offset = "0x6BE1720", VA = "0x186BE2D20")]
		internal bool MCMOEEJPGCH(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class MBMCPAGPFCC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public DIJFODABEAA <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
		public MBMCPAGPFCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x6BE3120", Offset = "0x6BE1B20", VA = "0x186BE3120")]
		internal void CJDBMPNMPKN(KeepsakeProgressionEventInstancesDTO result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x6BD42E0", Offset = "0x6BD2CE0", VA = "0x186BD42E0")]
		internal void HLJMIKEHAHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x6BE31B0", Offset = "0x6BE1BB0", VA = "0x186BE31B0")]
		internal CAPIMDIPLHM<Dictionary<Guid, EFNAILPKJGE>> PAKJOOMDCNP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x6850640", Offset = "0x684F040", VA = "0x186850640")]
		internal bool LPLEDDLKNJE(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class HBHLHMHFNGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public KeepsakeRoomInstanceIdsDTO instancesInRoom;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
		public HBHLHMHFNGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x6BE26E0", Offset = "0x6BE10E0", VA = "0x186BE26E0")]
		internal CAPIMDIPLHM<Dictionary<Guid, EFNAILPKJGE>> AKICBIFFDAP(KeepsakeRoomInstancesDTO roomInstancesDTO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class OLPGDNGOAAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public KeepsakeRoomInstancesDTO roomInstancesDTO;

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
		public OLPGDNGOAAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x6BE41E0", Offset = "0x6BE2BE0", VA = "0x186BE41E0")]
		internal bool MLHHOKHHGBF(Guid instanceId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6BE4090", Offset = "0x6BE2A90", VA = "0x186BE4090")]
		internal KeyValuePair<Guid, EFNAILPKJGE> IDOGGCKGPFM(Guid instanceId)
		{
			return default(KeyValuePair<Guid, EFNAILPKJGE>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class OGLANLLEGDB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public Guid instanceId;

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
		public OGLANLLEGDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x1AA72E0", Offset = "0x1AA5CE0", VA = "0x181AA72E0")]
		internal bool EGKJGAHLHCN(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class JBLMLIDIKGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public Guid instanceId;

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
		public JBLMLIDIKGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x1AA72E0", Offset = "0x1AA5CE0", VA = "0x181AA72E0")]
		internal bool APECFHMKOPJ(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class IJJFAKKNEGI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public DIJFODABEAA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
		public IJJFAKKNEGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x6BE2B20", Offset = "0x6BE1520", VA = "0x186BE2B20")]
		internal CAPIMDIPLHM<Dictionary<Guid, EFNAILPKJGE>> CAJHDGLCNMF(Dictionary<Guid, EFNAILPKJGE> instanceIdsAndCategories)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x6BE2D20", Offset = "0x6BE1720", VA = "0x186BE2D20")]
		internal bool FPFBDOOJJEI(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class CMFCAHNLLAA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public KeepsakeRoomInstanceIdsDTO collectedInstanceIds;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
		public CMFCAHNLLAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x6BD3ED0", Offset = "0x6BD28D0", VA = "0x186BD3ED0")]
		internal bool KIHBIMGEEHL(KeyValuePair<Guid, EFNAILPKJGE> idCategoryPair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class KKDDPIIAHAO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public Dictionary<Guid, EFNAILPKJGE> instanceIdsAndCategories;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
		public KKDDPIIAHAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x6BE2D80", Offset = "0x6BE1780", VA = "0x186BE2D80")]
		internal KeyValuePair<EFNAILPKJGE, int> NPLEBPEJDDG(EFNAILPKJGE category)
		{
			return default(KeyValuePair<EFNAILPKJGE, int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class LJNOJLGHBDJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public EFNAILPKJGE category;

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
		public LJNOJLGHBDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x147FF80", Offset = "0x147E980", VA = "0x18147FF80")]
		internal bool LAHGCCLPKNB(EFNAILPKJGE instanceCategory)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class BJBCCAPDGNC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public Dictionary<Guid, EFNAILPKJGE> instanceIdsAndCategories;

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
		public BJBCCAPDGNC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x6BD3B90", Offset = "0x6BD2590", VA = "0x186BD3B90")]
		internal KeyValuePair<EFNAILPKJGE, int> DKBOBCFLNAL(EFNAILPKJGE category)
		{
			return default(KeyValuePair<EFNAILPKJGE, int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class PAKLKKFBHLP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public EFNAILPKJGE category;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
		public PAKLKKFBHLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x147FF80", Offset = "0x147E980", VA = "0x18147FF80")]
		internal bool MOHOEGOKBLO(EFNAILPKJGE instanceCategory)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class HHNBGCAMOAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public DIJFODABEAA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public Func<KeepsakeRoomDTO, bool> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
		public HHNBGCAMOAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x6BE28F0", Offset = "0x6BE12F0", VA = "0x186BE28F0")]
		internal bool FLALJFFDHMP(DateTime nowUtc, DateTime eventStartTime, int roomOrder, TimeSpan unlockStartOffset, TimeSpan unlockInterval, int unlockBatchSize)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x6BE2A00", Offset = "0x6BE1400", VA = "0x186BE2A00")]
		internal bool KELPBOKDGLK(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x6BE29E0", Offset = "0x6BE13E0", VA = "0x186BE29E0")]
		internal bool PEJELJKGFFA(KeepsakeRoomDTO r)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x6BE29E0", Offset = "0x6BE13E0", VA = "0x186BE29E0")]
		internal bool FOBNMEMGLCK(KeepsakeRoomDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class LFOACLBCGJI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
		public LFOACLBCGJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0xAF0B50", Offset = "0xAEF550", VA = "0x180AF0B50")]
		internal bool KIPNCNFPHON(KeepsakeRoomListDTO roomList)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class DIFHFKBACPH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public Func<KeepsakeRoomDTO, bool> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
		public DIFHFKBACPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x6BD4310", Offset = "0x6BD2D10", VA = "0x186BD4310")]
		internal bool BKIPAFFIFJE(KeepsakeRoomListDTO roomList)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x1A643B0", Offset = "0x1A62DB0", VA = "0x181A643B0")]
		internal bool LLHNHKFMKMO(KeepsakeRoomDTO room)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class FEAGHCOJJAK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
		public FEAGHCOJJAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x6BE2600", Offset = "0x6BE1000", VA = "0x186BE2600")]
		internal bool JKEOJKEDHFD(KeepsakeRoomListDTO i)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class OELHHNHCCLA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
		public OELHHNHCCLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0xAF0B50", Offset = "0xAEF550", VA = "0x180AF0B50")]
		internal bool GBACIPBPCFG(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class HBLEBOFHLNA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public Guid keepsakeInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
		public HBLEBOFHLNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x6BE2890", Offset = "0x6BE1290", VA = "0x186BE2890")]
		internal bool CMDDMILAPDF(KeyValuePair<Guid, KeepsakeInstanceDTO> instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class HBBIPBEKFBC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public EFNAILPKJGE keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
		public HBBIPBEKFBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x172BD90", Offset = "0x172A790", VA = "0x18172BD90")]
		internal bool OCOKEOCDOLP(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class HMBGNDEICEI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public Guid keepsakeInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
		public HMBGNDEICEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x6BE2AC0", Offset = "0x6BE14C0", VA = "0x186BE2AC0")]
		internal bool MPKOOJAPBPD(KeyValuePair<Guid, KeepsakeInstanceDTO> instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class JBAKMIBBLGN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public EFNAILPKJGE keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
		public JBAKMIBBLGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x6BE2D40", Offset = "0x6BE1740", VA = "0x186BE2D40")]
		internal bool EIBCAJJOEFP(KeyValuePair<Guid, EFNAILPKJGE> x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class IPHBKPGFGNO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public EFNAILPKJGE newKeepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
		public IPHBKPGFGNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x172BD90", Offset = "0x172A790", VA = "0x18172BD90")]
		internal bool CMLJHODEGGA(KeepsakeInstanceDTO instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class FGMFKEGPEMM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public long currentRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public long? currentSubRoomId;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
		public FGMFKEGPEMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x6BE2660", Offset = "0x6BE1060", VA = "0x186BE2660")]
		internal bool MLIAEJEHCLK(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class OAPAIJJOBDD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public IEnumerable<KeepsakeRoomListDTO> roomList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
		public OAPAIJJOBDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x6BE3FA0", Offset = "0x6BE29A0", VA = "0x186BE3FA0")]
		internal bool PLPAMEKBJJJ(KeepsakeRoomDTO room)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class BENDMHBMAOJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public KeepsakeRoomDTO room;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public OAPAIJJOBDD CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
		public BENDMHBMAOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x6BD3B10", Offset = "0x6BD2510", VA = "0x186BD3B10")]
		internal bool DKHHLPDHMCJ(KeepsakeRoomListDTO roomListDto)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private struct NCCKCFNLKMN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public DIJFODABEAA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public NIKPNOMJFLH args;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x6BE34A0", Offset = "0x6BE1EA0", VA = "0x186BE34A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x6BE39D0", Offset = "0x6BE23D0", VA = "0x186BE39D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private struct AFDNEKALCHP : IAsyncStateMachine
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
		public DIJFODABEAA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public string message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x6BD31F0", Offset = "0x6BD1BF0", VA = "0x186BD31F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x6BD3480", Offset = "0x6BD1E80", VA = "0x186BD3480", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly DateTime ENKFABHGFCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly PJBGLBKIJMD BCIKCBLFFBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly LKPLDOLGCKE NEOMADILIEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly LFCJPACCDMH NDHEPEHBDKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly DIMIPNMECOA PLNIAIFHMFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly BOGKKCACAOB LHDGOKCNJCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly IMBJFDPEAJL PCICNCOFPOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly OABMGFLAECG NKGAGKNBBII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly OPDBHKOMLBF IMHDFDKMELG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly CCDHFNCAMJB HFCCBPPGLCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly OFBMOIEHODJ NGCHKJAFGAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly KOFFCHIBFCN LDFLDEGAHPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly HBJMPCMPBBN AJLGMMOBLLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly IJJEDEIJFDK CHHMOMKLNEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly HMNNBBIJGKO MIKEDKFFIKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly GFEMHOFJCGN OOBEMKODKLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly MACJMLCHLOC<KeepsakesConfig.KeepsakesOptions> IIPNOBBMFOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly JAHIFEMIDHK LGHCFIEDAOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly Dictionary<Guid, KeepsakeInstanceDTO> DLGMEMIHFPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly HashSet<Guid> OOAAOFKADKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly HashSet<long> CPMLGPDEOMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private Dictionary<EFNAILPKJGE, int> NFDMMOPNMPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly HashSet<Guid> HKJDPKCCAGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly IDisposable DAJAMCOKBDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private Task KBJNKCBNLDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private CAPIMDIPLHM<Guid> JNIGFKEAIMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private long? AMEEGGGHOAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private KeepsakeProgressionEventInstancesDTO MBLFEBPHHHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private CAPIMDIPLHM<KeepsakeProgressionEventInstancesDTO> HLMGLCLFKBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private IReadOnlyDictionary<EFNAILPKJGE, KeepsakeCategoryConfigDTO> JHNPKGPCPLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private KeepsakeGlobalConfigDTO BDAPECBBKHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private HashSet<long> JABMAEMOGOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private HashSet<long> GEKGOMJACDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private List<KeepsakeRoomListDTO> BCCPBAEIGNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private List<KeepsakeRoomListDTO> KDBMMPDMJPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private List<KeepsakeRoomListDTO> POFECFHKHAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private Dictionary<long, string> HKLKBKEIJAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private Dictionary<long, string> BALHIBGBIFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private Dictionary<long, DateTime> OGJMBLLJFNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private Dictionary<long, List<KeepsakeRoomDTO>> KLJAIOJCGME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private Dictionary<long, List<KeepsakeRoomDTO>> KGOOGPLADFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private Dictionary<long, long> GKELCNLGAOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly List<string> KFAFAAKONPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private DateTime MKFBAPACEFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly IDisposable FAPHMGPBIPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private Dictionary<Guid, EFNAILPKJGE> FGPFHIDCCPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private Dictionary<EFNAILPKJGE, int> NBMLFPEKNBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private List<KeepsakeCategoryThemePair> BPNMFPDDHHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private ENOABCOKPEM LPMEIMLHMEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private bool KMLJCJMGAGM;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool KMNHAGIBFJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xB75510", Offset = "0xB73F10", VA = "0x180B75510", Slot = "53")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xC622D0", Offset = "0xC60CD0", VA = "0x180C622D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool OEAMJHBLLDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6BD5510", Offset = "0x6BD3F10", VA = "0x186BD5510", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool FCNHFEJFJIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6BE0670", Offset = "0x6BDF070", VA = "0x186BE0670", Slot = "36")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private long FOAGLMILHPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6BDF7B0", Offset = "0x6BDE1B0", VA = "0x186BDF7B0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private long? FHFHKHOFBIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6BD6840", Offset = "0x6BD5240", VA = "0x186BD6840")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private bool IPNNJAKIKHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6BD7310", Offset = "0x6BD5D10", VA = "0x186BD7310")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public IReadOnlyList<KeepsakeRoomListDTO> GINLGCEHCKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x9601F0", Offset = "0x95EBF0", VA = "0x1809601F0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public IReadOnlyList<KeepsakeRoomListDTO> KJMFLMPDCCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xC9AE60", Offset = "0xC99860", VA = "0x180C9AE60", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IReadOnlyList<KeepsakeRoomListDTO> BICLMGMLFKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8EEA10", Offset = "0x8ED410", VA = "0x1808EEA10", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public IReadOnlyDictionary<long, string> ICNFJMBKGGD
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8E8790", Offset = "0x8E7190", VA = "0x1808E8790", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	internal bool BAKDNMADDHB
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x19D80D0", Offset = "0x19D6AD0", VA = "0x1819D80D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Guid?> EJMMCKOJKHB
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6BE0D00", Offset = "0x6BDF700", VA = "0x186BE0D00", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6BD9F80", Offset = "0x6BD8980", VA = "0x186BD9F80", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action EHFIJCHJIJP
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6BDAAF0", Offset = "0x6BD94F0", VA = "0x186BDAAF0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6BDB6A0", Offset = "0x6BDA0A0", VA = "0x186BDB6A0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action KJIPEDDFCHH
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6BD5560", Offset = "0x6BD3F60", VA = "0x186BD5560", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6BDAB90", Offset = "0x6BD9590", VA = "0x186BDAB90", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6BE0DB0", Offset = "0x6BDF7B0", VA = "0x186BE0DB0")]
	[RecRoom.NoEngine.Common.Preserve]
	internal DIJFODABEAA([CNNDHKODGDP(null)][NotNull] PJBGLBKIJMD BCIKCBLFFBK, [NotNull][CNNDHKODGDP(null)] ONKPALEHEPK DDIIFEKPIGK, [NotNull][CNNDHKODGDP(null)] LKPLDOLGCKE NEOMADILIEK, [NotNull][CNNDHKODGDP(null)] LFCJPACCDMH NDHEPEHBDKJ, [CNNDHKODGDP(null)][NotNull] DIMIPNMECOA PLNIAIFHMFE, [CNNDHKODGDP(null)][NotNull] BOGKKCACAOB LHDGOKCNJCN, [CNNDHKODGDP(null)][NotNull] IMBJFDPEAJL PCICNCOFPOM, [NotNull][CNNDHKODGDP(null)] OABMGFLAECG NKGAGKNBBII, [NotNull][CNNDHKODGDP(null)] OPDBHKOMLBF IMHDFDKMELG, [NotNull][CNNDHKODGDP(null)] EJLANOIIGIH ANDLKDGPKKC, [NotNull][CNNDHKODGDP(null)] CCDHFNCAMJB HFCCBPPGLCE, [NotNull][CNNDHKODGDP(null)] OFBMOIEHODJ NGCHKJAFGAF, [NotNull][CNNDHKODGDP(null)] KOFFCHIBFCN LDFLDEGAHPL, [NotNull][CNNDHKODGDP(null)] HBJMPCMPBBN AJLGMMOBLLK, [CNNDHKODGDP(null)][NotNull] IJJEDEIJFDK CHHMOMKLNEF, [CNNDHKODGDP(null)][NotNull] HMNNBBIJGKO MIKEDKFFIKJ, [NotNull][CNNDHKODGDP(null)] GFEMHOFJCGN OOBEMKODKLN, [CNNDHKODGDP(null)][NotNull] MACJMLCHLOC<KeepsakesConfig.KeepsakesOptions> IIPNOBBMFOE, [NotNull][CNNDHKODGDP(null)] JAHIFEMIDHK LGHCFIEDAOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6BD7F30", Offset = "0x6BD6930", VA = "0x186BD7F30", Slot = "15")]
	public bool FBNBJPJEBMM(List<string> PHDIDCMKDFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6BD43D0", Offset = "0x6BD2DD0", VA = "0x186BD43D0", Slot = "16")]
	public CAPIMDIPLHM<Guid> AAIAKANHDHN(EFNAILPKJGE EMPFDKECDCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6BD90C0", Offset = "0x6BD7AC0", VA = "0x186BD90C0", Slot = "17")]
	public MFAPHLCBHHA FNLBKGDHFAB(Guid OOOJEGNMLIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6BDFDC0", Offset = "0x6BDE7C0", VA = "0x186BDFDC0", Slot = "18")]
	public MFAPHLCBHHA OLKLDKAEAFJ(Guid OOOJEGNMLIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6BDA3A0", Offset = "0x6BD8DA0", VA = "0x186BDA3A0", Slot = "19")]
	public bool HMHIDALLPGA(Guid OOOJEGNMLIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6BD6610", Offset = "0x6BD5010", VA = "0x186BD6610", Slot = "20")]
	public bool CINDANCNDEO(Guid OOOJEGNMLIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6BDB560", Offset = "0x6BD9F60", VA = "0x186BDB560")]
	public KeepsakeTheme JNMNOBAEIEP(Guid OOOJEGNMLIB)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6BE0490", Offset = "0x6BDEE90", VA = "0x186BE0490")]
	public bool PDKKEMDFKHP(EFNAILPKJGE EMPFDKECDCP, [Out] KeepsakeTheme JEFEDICDIFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6BD6990", Offset = "0x6BD5390", VA = "0x186BD6990")]
	public List<KeepsakeTheme> DBFEHKFLDIK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6BD4E20", Offset = "0x6BD3820", VA = "0x186BD4E20")]
	public int AKIAOBCKHNA(EFNAILPKJGE EMPFDKECDCP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6BE0310", Offset = "0x6BDED10", VA = "0x186BE0310")]
	public EFNAILPKJGE PBKDGCPOGEJ(Guid OOOJEGNMLIB)
	{
		return default(EFNAILPKJGE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6BD63E0", Offset = "0x6BD4DE0", VA = "0x186BD63E0", Slot = "34")]
	public List<EFNAILPKJGE> BKHIPENAGEP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6BDBB60", Offset = "0x6BDA560", VA = "0x186BDBB60", Slot = "35")]
	public IComparer<EFNAILPKJGE> JPAICCOBNMF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6BD9E00", Offset = "0x6BD8800", VA = "0x186BD9E00", Slot = "32")]
	public string GPJOCFALPLM(EFNAILPKJGE EMPFDKECDCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6BDF180", Offset = "0x6BDDB80", VA = "0x186BDF180", Slot = "33")]
	public string NEPFLJJEIOM(EFNAILPKJGE EMPFDKECDCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6BDBD90", Offset = "0x6BDA790", VA = "0x186BDBD90", Slot = "21")]
	public bool KFBILJEFGHP(Guid OOOJEGNMLIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6BE0150", Offset = "0x6BDEB50", VA = "0x186BE0150", Slot = "22")]
	public void ONJMCHEAHOM(Guid OOOJEGNMLIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6BDF650", Offset = "0x6BDE050", VA = "0x186BDF650", Slot = "23")]
	public void NJNIAHHHOGG(EFNAILPKJGE EMPFDKECDCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6BDA740", Offset = "0x6BD9140", VA = "0x186BDA740", Slot = "24")]
	public void IFABMBJIHAA(Guid OOOJEGNMLIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6BD7320", Offset = "0x6BD5D20", VA = "0x186BD7320", Slot = "25")]
	public int ECNEAPJJKMC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6BD8D10", Offset = "0x6BD7710", VA = "0x186BD8D10", Slot = "31")]
	public CAPIMDIPLHM<IEnumerable<Guid>> FNBBNKEPALP(long NDAIANNJONA, long HBHMLMDHDGG, EFNAILPKJGE? EMPFDKECDCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6BDA5A0", Offset = "0x6BD8FA0", VA = "0x186BDA5A0", Slot = "30")]
	public CAPIMDIPLHM<IEnumerable<Guid>> IDCIIFHPLLC(long NDAIANNJONA, long HBHMLMDHDGG, EFNAILPKJGE? EMPFDKECDCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6BD7740", Offset = "0x6BD6140", VA = "0x186BD7740", Slot = "54")]
	public CAPIMDIPLHM<Dictionary<Guid, EFNAILPKJGE>> EEDBGFJGLIH(long NDAIANNJONA, long HBHMLMDHDGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6BDA030", Offset = "0x6BD8A30", VA = "0x186BDA030", Slot = "55")]
	public CAPIMDIPLHM<Dictionary<Guid, EFNAILPKJGE>> HGKJEDGPBGH(long NDAIANNJONA, long HBHMLMDHDGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6BD4FA0", Offset = "0x6BD39A0", VA = "0x186BD4FA0", Slot = "26")]
	public CAPIMDIPLHM<int> ANKOODIAEDM(long NDAIANNJONA, long HBHMLMDHDGG, EFNAILPKJGE? EMPFDKECDCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6BE01C0", Offset = "0x6BDEBC0", VA = "0x186BE01C0", Slot = "27")]
	public CAPIMDIPLHM<int> PBACFGBHMJH(long NDAIANNJONA, long HBHMLMDHDGG, EFNAILPKJGE? EMPFDKECDCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6BD8A30", Offset = "0x6BD7430", VA = "0x186BD8A30", Slot = "28")]
	public CAPIMDIPLHM<Dictionary<EFNAILPKJGE, int>> FLGLOHHJGPN(long NDAIANNJONA, long HBHMLMDHDGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6BDF880", Offset = "0x6BDE280", VA = "0x186BDF880", Slot = "29")]
	public CAPIMDIPLHM<Dictionary<EFNAILPKJGE, int>> ODPJLFPICGH(long NDAIANNJONA, long HBHMLMDHDGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6BD9BC0", Offset = "0x6BD85C0", VA = "0x186BD9BC0", Slot = "37")]
	public bool GMMDLMDFEFP(long NDAIANNJONA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6BDF6A0", Offset = "0x6BDE0A0", VA = "0x186BDF6A0", Slot = "56")]
	public bool NMPMCKNIMAH(long NDAIANNJONA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6BD88C0", Offset = "0x6BD72C0", VA = "0x186BD88C0", Slot = "38")]
	public bool FHPFDMMFNNH(long NDAIANNJONA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6BD5FE0", Offset = "0x6BD49E0", VA = "0x186BD5FE0", Slot = "57")]
	public bool BGLIMBBOPNB(long NDAIANNJONA, [Out] OCKOEBLCBGC EGKJKLNJAPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6BDF300", Offset = "0x6BDDD00", VA = "0x186BDF300", Slot = "39")]
	public bool NHFPPGCBIMB(long BMLCOADFIGK, [Out] DateTime ECJNPOBFGDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6BDDCF0", Offset = "0x6BDC6F0", VA = "0x186BDDCF0", Slot = "40")]
	public long NBJMLFINHFO(long BMLCOADFIGK)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6BD6DA0", Offset = "0x6BD57A0", VA = "0x186BD6DA0", Slot = "41")]
	public long DIELGKFCHFB(long NDAIANNJONA)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6BD7D50", Offset = "0x6BD6750", VA = "0x186BD7D50", Slot = "42")]
	public int ELBFJHOFICD(long BMLCOADFIGK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6BD87E0", Offset = "0x6BD71E0", VA = "0x186BD87E0", Slot = "43")]
	public bool FHCLCKBBNCE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6BD4B60", Offset = "0x6BD3560", VA = "0x186BD4B60", Slot = "44")]
	public bool ADAPCBDFJKD(long BMLCOADFIGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6BD9C20", Offset = "0x6BD8620", VA = "0x186BD9C20", Slot = "45")]
	public IEnumerable<long> GNJPIPCFLEF(long BMLCOADFIGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6BDF700", Offset = "0x6BDE100", VA = "0x186BDF700", Slot = "46")]
	public int NPGOBBGBCEF(long BMLCOADFIGK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6BDD2C0", Offset = "0x6BDBCC0", VA = "0x186BDD2C0", Slot = "50")]
	public long LKBNMEGMOAP(long CKLFDEPECCC)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6BD95C0", Offset = "0x6BD7FC0", VA = "0x186BD95C0", Slot = "51")]
	public EFNAILPKJGE GFOIEGNKGLJ()
	{
		return default(EFNAILPKJGE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6BDF940", Offset = "0x6BDE340", VA = "0x186BDF940")]
	private bool OEINHHMBPOP(Guid OOOJEGNMLIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6BDB0B0", Offset = "0x6BD9AB0", VA = "0x186BDB0B0")]
	private void JMOBCGIOHAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6BD5240", Offset = "0x6BD3C40", VA = "0x186BD5240")]
	private EFNAILPKJGE APDGGDGONAH()
	{
		return default(EFNAILPKJGE);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6BDCBA0", Offset = "0x6BDB5A0", VA = "0x186BDCBA0")]
	private void LKAHBKCDBFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6BD9340", Offset = "0x6BD7D40", VA = "0x186BD9340")]
	private int GCAGELCGGLO(KeepsakeRoomListDTO PPKJAGLCFHC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6BDC740", Offset = "0x6BDB140", VA = "0x186BDC740")]
	private int LCEKLGCBAKK(DateTime OIDMPJIOAKI, DateTime HFIJHOMOFHI, TimeSpan OHGPPMDPOBG, int NFDNBIIHHMD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6BD9940", Offset = "0x6BD8340", VA = "0x186BD9940")]
	private void GJHDLAKLDFI(IEnumerable<KeepsakeInstanceDTO> DLGMEMIHFPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6BDAE70", Offset = "0x6BD9870", VA = "0x186BDAE70")]
	private void JKBCHCFDNNO(IEnumerable<KeepsakeCollectionRecordDTO> LAMGHPKBHPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6BD6D40", Offset = "0x6BD5740", VA = "0x186BD6D40")]
	private void DBGPGNDHJDO(IEnumerable<long> GAFLDLBPMEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0xBE4A90", Offset = "0xBE3490", VA = "0x180BE4A90")]
	private void BGIBDNANNKP(KeepsakeGlobalConfigDTO BDAPECBBKHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x6BD7AF0", Offset = "0x6BD64F0", VA = "0x186BD7AF0")]
	private bool EFFOLPGGLIE(EFNAILPKJGE EMPFDKECDCP, [Out] Guid EIJNDOLACDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6BDA500", Offset = "0x6BD8F00", VA = "0x186BDA500")]
	private bool IANIFBHOABI([Out] Guid EIJNDOLACDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6BDBD30", Offset = "0x6BDA730", VA = "0x186BDBD30")]
	private bool KFBCNHEMAJL(Guid OOOJEGNMLIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6BDFC70", Offset = "0x6BDE670", VA = "0x186BDFC70")]
	private IEnumerable<Guid> OLGFEEFAJFJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x6BD68D0", Offset = "0x6BD52D0", VA = "0x186BD68D0")]
	private IEnumerable<KeepsakeInstanceDTO> CPOAHKNDBIP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6BD5F50", Offset = "0x6BD4950", VA = "0x186BD5F50")]
	private void BGAFHKAPBEL(Guid OOOJEGNMLIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6BDAC30", Offset = "0x6BD9630", VA = "0x186BDAC30")]
	private bool IJEJJHGHNEK(Guid OOOJEGNMLIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6BDC840", Offset = "0x6BDB240", VA = "0x186BDC840")]
	private void LFFAIAOCNGD(Guid OOOJEGNMLIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6BD94E0", Offset = "0x6BD7EE0", VA = "0x186BD94E0")]
	private void GDHFFBNPIKJ(EFNAILPKJGE PMPHJFMHGDH, int MEBNJJEINIC, Dictionary<EFNAILPKJGE, int> EBAIOJLMGLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6BD6520", Offset = "0x6BD4F20", VA = "0x186BD6520")]
	private int BPMLIGKPKIA(EFNAILPKJGE EMPFDKECDCP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6BDDB20", Offset = "0x6BDC520", VA = "0x186BDDB20")]
	private void MKOAGELNLEC(KeepsakeInstanceDTO FDJMBNMINJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6BDF440", Offset = "0x6BDDE40", VA = "0x186BDF440")]
	private void NIGJDPPMJLB(KeepsakeInstanceDTO FDJMBNMINJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6BE0930", Offset = "0x6BDF330", VA = "0x186BE0930")]
	private void PMHKCOJHPFN(Guid OOOJEGNMLIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6BD6390", Offset = "0x6BD4D90", VA = "0x186BD6390")]
	private void KCAMLPMMMMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6BD63C0", Offset = "0x6BD4DC0", VA = "0x186BD63C0")]
	private void BJBHJIGJCNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6BD67D0", Offset = "0x6BD51D0", VA = "0x186BD67D0")]
	private void CKNGKEDJPAK(LCPOCDBECPL HNPLOPPBOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6BD6390", Offset = "0x6BD4D90", VA = "0x186BD6390")]
	private void BHJEPIJEMLD(ILEFPPEKNMD GIGIFGONEAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6BD6390", Offset = "0x6BD4D90", VA = "0x186BD6390")]
	private void LBEHDKLBJOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6BDC210", Offset = "0x6BDAC10", VA = "0x186BDC210")]
	private void KOHKPAHCOPD(float LBBEJLNBHEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6BD5600", Offset = "0x6BD4000", VA = "0x186BD5600")]
	private void BAAEDFADPOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6BDFA70", Offset = "0x6BDE470", VA = "0x186BDFA70")]
	private bool OJKMNBDMCBD(Guid OOOJEGNMLIB, [Out] string DPHDFJFDKBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6BDC020", Offset = "0x6BDAA20", VA = "0x186BDC020")]
	private bool KGPIINCEKJH(Guid OOOJEGNMLIB, [Out] KeepsakeCategoryConfigDTO PMPHJFMHGDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6BDD1E0", Offset = "0x6BDBBE0", VA = "0x186BDD1E0")]
	private void LKBGMKELBAP(string KGHGMFKOBOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6BDBC20", Offset = "0x6BDA620", VA = "0x186BDBC20")]
	private bool KCCOEHBEHBD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6BDD870", Offset = "0x6BDC270", VA = "0x186BDD870")]
	private IEnumerable<long> MDLJKBCAOOJ(IEnumerable<KeepsakeRoomDTO> CKABOOJNKNG, IEnumerable<KeepsakeRoomListDTO> PEFLMBPNOME, long BMLCOADFIGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6BD82C0", Offset = "0x6BD6CC0", VA = "0x186BD82C0")]
	private bool FGICDLECBOK(Guid OOOJEGNMLIB, [Out] string DMBOCOKFCJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6BDACE0", Offset = "0x6BD96E0", VA = "0x186BDACE0", Slot = "47")]
	public string JAODGHNENEB(PJGBFEEIEAA ADMFIOLJGPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6BDB740", Offset = "0x6BDA140", VA = "0x186BDB740", Slot = "49")]
	public string JOKKPNDLKBA(PJGBFEEIEAA ADMFIOLJGPK, long NDAIANNJONA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6BD8960", Offset = "0x6BD7360", VA = "0x186BD8960", Slot = "48")]
	public string FKFJIJBGNJK(PJGBFEEIEAA ADMFIOLJGPK, int NOECNNHPFDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6BDE280", Offset = "0x6BDCC80", VA = "0x186BDE280")]
	private void NEMIBAECLEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6BD6640", Offset = "0x6BD5040", VA = "0x186BD6640")]
	private void CJBFOMDCIEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6BE0730", Offset = "0x6BDF130", VA = "0x186BE0730")]
	private PJGBFEEIEAA PHOCFKFLDHG(DHOHCGOINLM FCAFLFFLBDO)
	{
		return default(PJGBFEEIEAA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6BD9920", Offset = "0x6BD8320", VA = "0x186BD9920")]
	private PJGBFEEIEAA GGBKECGLIOC(DHOHCGOINLM FCAFLFFLBDO)
	{
		return default(PJGBFEEIEAA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6BE0750", Offset = "0x6BDF150", VA = "0x186BE0750")]
	internal static string PJPAFDEAMAA(CPIKMAMOKBM DOPHHDHNACG, string LKIDIEALMDI, bool NNDKOCODEJH, int PLNGCNODDKB, int IHDODECJEIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6BD6EB0", Offset = "0x6BD58B0", VA = "0x186BD6EB0", Slot = "52")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6BDA320", Offset = "0x6BD8D20", VA = "0x186BDA320")]
	private IPDFKJFOODE HLHOICLMEBP(PHNOICNFFCM CBNEFOEIJNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6BDD580", Offset = "0x6BDBF80", VA = "0x186BDD580")]
	private LPNCDEIHJMN LLKOOCEHMOJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6BD5BA0", Offset = "0x6BD45A0", VA = "0x186BD5BA0")]
	private Task BFNCMGJAGIN(NIKPNOMJFLH EBIJIHILGPC, CancellationToken OGJIGALEPCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6BDA210", Offset = "0x6BD8C10", VA = "0x186BDA210")]
	[AsyncStateMachine(typeof(NCCKCFNLKMN))]
	private Task HKIMCCDPFEO(NIKPNOMJFLH EBIJIHILGPC, CancellationToken OGJIGALEPCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6BD8C40", Offset = "0x6BD7640", VA = "0x186BD8C40")]
	private Task FMDFKCLPDBF(NIKPNOMJFLH EBIJIHILGPC, CancellationToken OGJIGALEPCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6BDAD40", Offset = "0x6BD9740", VA = "0x186BDAD40")]
	[AsyncStateMachine(typeof(AFDNEKALCHP))]
	private Task JBHNAGGBKNK(string MEBLNPKEJMN, TimeSpan NHACNLDIECL, CancellationToken OGJIGALEPCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6BDC1F0", Offset = "0x6BDABF0", VA = "0x186BDC1F0")]
	[CompilerGenerated]
	private void KIJHAPJBPFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6BDA1C0", Offset = "0x6BD8BC0", VA = "0x186BDA1C0")]
	[CompilerGenerated]
	private void HKHBEMMFKMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6BD81C0", Offset = "0x6BD6BC0", VA = "0x186BD81C0")]
	[CompilerGenerated]
	private bool FBNHOLGCOGA(KeepsakeInstanceDTO ICJCFEHCALD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6BD49F0", Offset = "0x6BD33F0", VA = "0x186BD49F0")]
	[CompilerGenerated]
	private CAPIMDIPLHM<Dictionary<EFNAILPKJGE, int>> ABAOLLGGHML(Dictionary<Guid, EFNAILPKJGE> NEJNAEPCKGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6BDA980", Offset = "0x6BD9380", VA = "0x186BDA980")]
	[CompilerGenerated]
	private CAPIMDIPLHM<Dictionary<EFNAILPKJGE, int>> IFODMDDIAFB(Dictionary<Guid, EFNAILPKJGE> NEJNAEPCKGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6BE0470", Offset = "0x6BDEE70", VA = "0x186BE0470")]
	[CompilerGenerated]
	private bool PDIPHDFKLEG(KeepsakeRoomListDTO ICJCFEHCALD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6BDD740", Offset = "0x6BDC140", VA = "0x186BDD740")]
	[CompilerGenerated]
	private bool LNHJPNPGDOK(KeepsakeInstanceDTO ICJCFEHCALD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6BDC5B0", Offset = "0x6BDAFB0", VA = "0x186BDC5B0")]
	[CompilerGenerated]
	private void KOLBHDALOEL(Tuple<KeepsakeRoomInstancesDTO, IReadOnlyDictionary<EFNAILPKJGE, KeepsakeCategoryConfigDTO>, KeepsakeGlobalConfigDTO> FKDPICIBJEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6BDE220", Offset = "0x6BDCC20", VA = "0x186BDE220")]
	[CompilerGenerated]
	private void NBLOEMPFFEK(string DMBOCOKFCJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6BDC9E0", Offset = "0x6BDB3E0", VA = "0x186BDC9E0")]
	[CompilerGenerated]
	private Task LIKEIDEMGBB(CancellationToken NBFKIPJKMHO)
	{
		return null;
	}
}
namespace RecRoom.Keepsakes
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public class KeepsakesConfig : ScriptableObject, MACJMLCHLOC<KeepsakesConfig.KeepsakesOptions>
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200002B")]
		public class KeepsakesOptions
		{
			[Cpp2IlInjected.Token(Token = "0x200002C")]
			[CompilerGenerated]
			private sealed class NMFIFDBGIPL
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000098")]
				public string themeId;

				[Cpp2IlInjected.Token(Token = "0x60000F3")]
				[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
				public NMFIFDBGIPL()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000F4")]
				[Cpp2IlInjected.Address(RVA = "0x6BE3F70", Offset = "0x6BE2970", VA = "0x186BE3F70")]
				internal bool LGMGAELPEJB(KeepsakeTheme x)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60000F5")]
				[Cpp2IlInjected.Address(RVA = "0x6BE3F70", Offset = "0x6BE2970", VA = "0x186BE3F70")]
				internal bool PHFFHDJKAJE(KeepsakeTheme x)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			[SerializeField]
			private KeepsakeTheme[] themes;

			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x6BE2F50", Offset = "0x6BE1950", VA = "0x186BE2F50")]
			public bool DKFLHDIHECJ(string PIPGLBCIELA, [Out] KeepsakeTheme JEFEDICDIFM)
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
			[Cpp2IlInjected.Address(RVA = "0x886780", Offset = "0x885180", VA = "0x180886780", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x6BE2ED0", Offset = "0x6BE18D0", VA = "0x186BE2ED0")]
		[POCMGODEOKB.GGOFPJDKHFE.NHEEFPAGIJC]
		internal static void JIHNHODNBNJ(APIKLLPBEEI PLCAFBBHOLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x903700", Offset = "0x902100", VA = "0x180903700")]
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
