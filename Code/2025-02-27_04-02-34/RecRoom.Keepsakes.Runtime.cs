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
		[Cpp2IlInjected.Address(RVA = "0x74B1AC0", Offset = "0x74B0EC0", VA = "0x1874B1AC0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x242AF30", Offset = "0x242A330", VA = "0x18242AF30")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class MFGNMNHPKHE : IComparer<MAIAFFCEMDA>
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private sealed class GABGPMPKNOH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public MAIAFFCEMDA x;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public MAIAFFCEMDA y;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public GABGPMPKNOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xB88E80", Offset = "0xB88280", VA = "0x180B88E80")]
		internal bool BBHEJLGAAEB(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x1C2E1D0", Offset = "0x1C2D5D0", VA = "0x181C2E1D0")]
		internal bool MMPCNPGINOF(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xB88E80", Offset = "0xB88280", VA = "0x180B88E80")]
		internal bool LKMNMCMAEIJ(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1C2E1D0", Offset = "0x1C2D5D0", VA = "0x181C2E1D0")]
		internal bool BKEGOEJOCPK(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private List<KeepsakeCategoryThemePair> NMMHNGNEGJN;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x951BA0", Offset = "0x950FA0", VA = "0x180951BA0")]
	public MFGNMNHPKHE(List<KeepsakeCategoryThemePair> PGKIJFKCKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x74B1420", Offset = "0x74B0820", VA = "0x1874B1420", Slot = "4")]
	public int Compare(MAIAFFCEMDA IKAEODCKAIP, MAIAFFCEMDA ACCJFOPIMAB)
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
		public MAIAFFCEMDA KeepsakeCategory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public KeepsakeTheme KeepsakeTheme;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[GAFKBMEFLIK]
public class IACPIHHHCOI : HPDENNBAGKP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class MEGNNOKHOEK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public IACPIHHHCOI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public MAIAFFCEMDA keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public MEGNNOKHOEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x74B0CD0", Offset = "0x74B00D0", VA = "0x1874B0CD0")]
		internal NEEPBAPEEOL<Guid> ENBNBJFBKEH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x74B0E60", Offset = "0x74B0260", VA = "0x1874B0E60")]
		internal void NPNHCGBBCEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x74B0C70", Offset = "0x74B0070", VA = "0x1874B0C70")]
		internal void DFGKMIGNMKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x74B0860", Offset = "0x74AFC60", VA = "0x1874B0860")]
		internal void CBHPAIBJNAB(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x74B0E30", Offset = "0x74B0230", VA = "0x1874B0E30")]
		internal void NDHFCDPJFPK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class DAOGIAEEEAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public IACPIHHHCOI <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public DAOGIAEEEAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x74A0C90", Offset = "0x74A0090", VA = "0x1874A0C90")]
		internal void HJEFBIPKHGA(GPHBDLOMFBC response)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x74A0C30", Offset = "0x74A0030", VA = "0x1874A0C30")]
		internal void ABNFNOLGJGE(string error)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class ECPDJOFIPDJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public KeepsakeTheme theme;

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public ECPDJOFIPDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x74A1210", Offset = "0x74A0610", VA = "0x1874A1210")]
		internal bool PLBNGCBKHHI(KeepsakeCategoryThemePair categoryThemePair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class IFKHCMCFPLJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public IACPIHHHCOI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public long progressionEventId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public MAIAFFCEMDA? keepsakeCategory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public IFKHCMCFPLJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x74B0070", Offset = "0x74AF470", VA = "0x1874B0070")]
		internal void ICHKDIHMHME(KeepsakeProgressionEventInstancesDTO result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x74A1C50", Offset = "0x74A1050", VA = "0x1874A1C50")]
		internal void PPMIDJECJBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x74B0100", Offset = "0x74AF500", VA = "0x1874B0100")]
		internal NEEPBAPEEOL<IEnumerable<Guid>> MPINMAGFICJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x706E4F0", Offset = "0x706D8F0", VA = "0x18706E4F0")]
		internal bool EGELIOAMOLB(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class FNJDLHHKBLA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public KeepsakeRoomInstanceIdsDTO instancesInRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public IFKHCMCFPLJ CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public FNJDLHHKBLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x74A1790", Offset = "0x74A0B90", VA = "0x1874A1790")]
		internal NEEPBAPEEOL<IEnumerable<Guid>> KLGEDGLPBOO(KeepsakeRoomInstancesDTO roomInstancesDTO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class FHFFMHLAGAK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public KeepsakeRoomInstancesDTO roomInstancesDTO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public FNJDLHHKBLA CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public FHFFMHLAGAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x74A1660", Offset = "0x74A0A60", VA = "0x1874A1660")]
		internal bool BGFCLBEEHGL(Guid instanceId)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class BGJOHBKGKPG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Guid instanceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public FHFFMHLAGAK CS$<>8__locals3;

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public BGJOHBKGKPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x74A0910", Offset = "0x749FD10", VA = "0x1874A0910")]
		internal bool BKIDFPEGLAB(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class AALBLBPHFGE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public IACPIHHHCOI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public AALBLBPHFGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x74A0550", Offset = "0x749F950", VA = "0x1874A0550")]
		internal NEEPBAPEEOL<IEnumerable<Guid>> BMFANFKJLAO(IEnumerable<Guid> instanceIds)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x74A06C0", Offset = "0x749FAC0", VA = "0x1874A06C0")]
		internal bool GIILBMPGAJM(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class HKDLJDGFMAA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public IACPIHHHCOI <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public HKDLJDGFMAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x74A1F70", Offset = "0x74A1370", VA = "0x1874A1F70")]
		internal void OIAFIKJFINH(KeepsakeProgressionEventInstancesDTO result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x74A1C50", Offset = "0x74A1050", VA = "0x1874A1C50")]
		internal void BGLHNCADNBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x74A1C80", Offset = "0x74A1080", VA = "0x1874A1C80")]
		internal NEEPBAPEEOL<Dictionary<Guid, MAIAFFCEMDA>> INAJPCJMDFL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x706E4F0", Offset = "0x706D8F0", VA = "0x18706E4F0")]
		internal bool KJKBEJMLGPE(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class EPLAJKBJPMJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public KeepsakeRoomInstanceIdsDTO instancesInRoom;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public EPLAJKBJPMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x74A1230", Offset = "0x74A0630", VA = "0x1874A1230")]
		internal NEEPBAPEEOL<Dictionary<Guid, MAIAFFCEMDA>> CEIJAOKLDCG(KeepsakeRoomInstancesDTO roomInstancesDTO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class BCBFPAJJPDG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public KeepsakeRoomInstancesDTO roomInstancesDTO;

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public BCBFPAJJPDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x74A0830", Offset = "0x749FC30", VA = "0x1874A0830")]
		internal bool MNMCMCHIBNA(Guid instanceId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x74A06E0", Offset = "0x749FAE0", VA = "0x1874A06E0")]
		internal KeyValuePair<Guid, MAIAFFCEMDA> LDMBPKHGNNI(Guid instanceId)
		{
			return default(KeyValuePair<Guid, MAIAFFCEMDA>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class DCKDMNLGNAE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public Guid instanceId;

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public DCKDMNLGNAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x2214940", Offset = "0x2213D40", VA = "0x182214940")]
		internal bool BBLJJMNJIPH(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class IHOMNNKLDON
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public Guid instanceId;

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public IHOMNNKLDON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x2214940", Offset = "0x2213D40", VA = "0x182214940")]
		internal bool ECHCGHMNIIA(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class FDFMPHCDIBK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public IACPIHHHCOI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public FDFMPHCDIBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x74A1460", Offset = "0x74A0860", VA = "0x1874A1460")]
		internal NEEPBAPEEOL<Dictionary<Guid, MAIAFFCEMDA>> JJKBCJCGNLK(Dictionary<Guid, MAIAFFCEMDA> instanceIdsAndCategories)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x74A06C0", Offset = "0x749FAC0", VA = "0x1874A06C0")]
		internal bool GIGJAMFFPNL(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class OAFIIIPINJF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public KeepsakeRoomInstanceIdsDTO collectedInstanceIds;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public OAFIIIPINJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x74B17C0", Offset = "0x74B0BC0", VA = "0x1874B17C0")]
		internal bool GFJOCOFEEGN(KeyValuePair<Guid, MAIAFFCEMDA> idCategoryPair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class JKFCCCNJFAP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public Dictionary<Guid, MAIAFFCEMDA> instanceIdsAndCategories;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public JKFCCCNJFAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x74B0400", Offset = "0x74AF800", VA = "0x1874B0400")]
		internal KeyValuePair<MAIAFFCEMDA, int> FEPMBAJGFLI(MAIAFFCEMDA category)
		{
			return default(KeyValuePair<MAIAFFCEMDA, int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class FKBELDFFOFH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public MAIAFFCEMDA category;

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public FKBELDFFOFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0xC74EF0", Offset = "0xC742F0", VA = "0x180C74EF0")]
		internal bool OEODFIDLOKN(MAIAFFCEMDA instanceCategory)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class CFNCKHAFJDI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public Dictionary<Guid, MAIAFFCEMDA> instanceIdsAndCategories;

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public CFNCKHAFJDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x74A0AE0", Offset = "0x749FEE0", VA = "0x1874A0AE0")]
		internal KeyValuePair<MAIAFFCEMDA, int> LEPGGIFEPDJ(MAIAFFCEMDA category)
		{
			return default(KeyValuePair<MAIAFFCEMDA, int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class KOIGLEFEOAI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public MAIAFFCEMDA category;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public KOIGLEFEOAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0xC74EF0", Offset = "0xC742F0", VA = "0x180C74EF0")]
		internal bool BNABBPJEKFB(MAIAFFCEMDA instanceCategory)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class DFBPKBIJDMP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public IACPIHHHCOI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public Func<KeepsakeRoomDTO, bool> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public DFBPKBIJDMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x74A1120", Offset = "0x74A0520", VA = "0x1874A1120")]
		internal bool MBGKMHDJLCD(DateTime nowUtc, DateTime eventStartTime, int roomOrder, TimeSpan unlockStartOffset, TimeSpan unlockInterval, int unlockBatchSize)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x74A1040", Offset = "0x74A0440", VA = "0x1874A1040")]
		internal bool DEDDHHMCKLG(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x74A1100", Offset = "0x74A0500", VA = "0x1874A1100")]
		internal bool LBNIJELAPDC(KeepsakeRoomDTO r)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x74A1100", Offset = "0x74A0500", VA = "0x1874A1100")]
		internal bool PDIDMDFJFBC(KeepsakeRoomDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class AEDFJHJDOPC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public AEDFJHJDOPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0xCE8F90", Offset = "0xCE8390", VA = "0x180CE8F90")]
		internal bool MIAMFPIJOPJ(KeepsakeRoomListDTO roomList)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class BIGNAAHJPCC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public Func<KeepsakeRoomDTO, bool> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public BIGNAAHJPCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x74A0A20", Offset = "0x749FE20", VA = "0x1874A0A20")]
		internal bool KAOGHNBCKLF(KeepsakeRoomListDTO roomList)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x21DB090", Offset = "0x21DA490", VA = "0x1821DB090")]
		internal bool HJKEMMMCGGF(KeepsakeRoomDTO room)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class BHBMFHLEPFI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public BHBMFHLEPFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x74A09C0", Offset = "0x749FDC0", VA = "0x1874A09C0")]
		internal bool IDFNGMDDFPE(KeepsakeRoomListDTO i)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class NBEICIHPEKH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public NBEICIHPEKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0xCE8F90", Offset = "0xCE8390", VA = "0x180CE8F90")]
		internal bool NNFFCGLNGHN(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class GFHOAMNPFAP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public Guid keepsakeInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public GFHOAMNPFAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x74A18D0", Offset = "0x74A0CD0", VA = "0x1874A18D0")]
		internal bool OOELPFACCJD(KeyValuePair<Guid, KeepsakeInstanceDTO> instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class HFBDCKINPAA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public MAIAFFCEMDA keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public HFBDCKINPAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x1E2B510", Offset = "0x1E2A910", VA = "0x181E2B510")]
		internal bool GOMHBPONMCG(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class PGFCEKMFKAO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public Guid keepsakeInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public PGFCEKMFKAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x74B1840", Offset = "0x74B0C40", VA = "0x1874B1840")]
		internal bool NLHGPPOHPJB(KeyValuePair<Guid, KeepsakeInstanceDTO> instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class KOMKHABHCDA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public MAIAFFCEMDA keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public KOMKHABHCDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x74B0550", Offset = "0x74AF950", VA = "0x1874B0550")]
		internal bool BGDGGAIJCLJ(KeyValuePair<Guid, MAIAFFCEMDA> x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class DCGENOAHHPC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public MAIAFFCEMDA newKeepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public DCGENOAHHPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x1E2B510", Offset = "0x1E2A910", VA = "0x181E2B510")]
		internal bool OPECPOJHEMM(KeepsakeInstanceDTO instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class EPMDNDCDMFO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public long currentRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public long? currentSubRoomId;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public EPMDNDCDMFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x74A13E0", Offset = "0x74A07E0", VA = "0x1874A13E0")]
		internal bool IPNJOHGJKPB(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class MNPADGMBFCD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public IReadOnlyList<KeepsakeRoomListDTO> roomList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public MNPADGMBFCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x74B16D0", Offset = "0x74B0AD0", VA = "0x1874B16D0")]
		internal bool NFBKFHNFBMN(KeepsakeRoomDTO room)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class LHPLDMPMFHA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public KeepsakeRoomDTO room;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public MNPADGMBFCD CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public LHPLDMPMFHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x74B07E0", Offset = "0x74AFBE0", VA = "0x1874B07E0")]
		internal bool CIMBHKICAGE(KeepsakeRoomListDTO roomListDto)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private struct MEKDIBIHNGM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public IACPIHHHCOI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public BPPINHJEEIJ args;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x74B0E90", Offset = "0x74B0290", VA = "0x1874B0E90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x74B13C0", Offset = "0x74B07C0", VA = "0x1874B13C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private struct GHGONONANMB : IAsyncStateMachine
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
		public IACPIHHHCOI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public string message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x74A1930", Offset = "0x74A0D30", VA = "0x1874A1930", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x74A1BC0", Offset = "0x74A0FC0", VA = "0x1874A1BC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly DateTime LCGICNMOJDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly GFJFIDGHMOA CKEMIOHGOMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly IGEFIGDGMAI JKPDOMGEHKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly ADCPBBIAOCH BCAIDBPILOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly KJCONENAPPK HFNIINCGAEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly EKKKCNGJBOO GHFCFJHMPHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly CIFKNFKILGE OMMKHBGELAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly ENHCOOGKGFN ADFGFLNPGOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly JFIOHCKEEIP MGMCFGLJIGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly MLOAEAIKDOJ EDEPPIBHBIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly FGKLOENKHBI HHGBOFOOHDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly CMCKGIJHJHE NJDKDNFLIHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly KLHECNJFMMO AOMNFIDCDEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly OKEMOHPNDNB DCEMBCAMKNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly CKBCKKNCCCO PENLKINHKAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly CCAOPILOOAO AJLMACGMCAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly BCCJIGCFKHM<KeepsakesConfig.KeepsakesOptions> DCEHMKPFEJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly FIIDOADKEDD MGBNFJALEFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly Dictionary<Guid, KeepsakeInstanceDTO> IOGMLEMBKHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly HashSet<Guid> HJADCDFFECJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly HashSet<long> IBIDIBILJJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private Dictionary<MAIAFFCEMDA, int> EEGIJCLNHFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly HashSet<Guid> GDCFLKCECBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly IDisposable OHGCLGIIIDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private Task ADMGPGIOJBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private NEEPBAPEEOL<Guid> BKAIMIEFBDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private long? FOLEAJEHAPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private KeepsakeProgressionEventInstancesDTO DPECKFAFPKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private NEEPBAPEEOL<KeepsakeProgressionEventInstancesDTO> MHNNHAKOFMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private IReadOnlyDictionary<MAIAFFCEMDA, KeepsakeCategoryConfigDTO> LHOMNFMLNOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private KeepsakeGlobalConfigDTO PHMMNNJJCCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private HashSet<long> KIFJMDGCCLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private HashSet<long> EGFPBCCPNCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private List<KeepsakeRoomListDTO> CLNKGOPADKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private List<KeepsakeRoomListDTO> ONMKDKJHAGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private List<KeepsakeRoomListDTO> DGFLMFHJICE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private Dictionary<long, string> OBOIJCKPFKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private Dictionary<long, string> LOALJKBPAGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private Dictionary<long, DateTime> GJFCEPGMJID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private Dictionary<long, List<KeepsakeRoomDTO>> BFBHLKEAFNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private Dictionary<long, List<KeepsakeRoomDTO>> NGOBCBEPMEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private Dictionary<long, long> PDMIDGNGDNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly List<string> CCOOOMMIFEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private DateTime NNAEEPPOMNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly IDisposable PIKIHPOKBOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private Dictionary<Guid, MAIAFFCEMDA> LDDIKHGGCHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private Dictionary<MAIAFFCEMDA, int> ICGEHOIDLNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private List<KeepsakeCategoryThemePair> PGKIJFKCKKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private MFGNMNHPKHE JAHCPAJPNNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private bool NGNBCFLONGK;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool EMILPHGBGDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x978140", Offset = "0x977540", VA = "0x180978140", Slot = "53")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x977EC0", Offset = "0x9772C0", VA = "0x180977EC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool LDBACIOFHND
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x74A9020", Offset = "0x74A8420", VA = "0x1874A9020", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool IAALFFAGMII
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x74A51F0", Offset = "0x74A45F0", VA = "0x1874A51F0", Slot = "36")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private long ABODGGMBMAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x74A8EE0", Offset = "0x74A82E0", VA = "0x1874A8EE0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private long? MMHCBCMMGLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x74AD940", Offset = "0x74ACD40", VA = "0x1874AD940")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private bool AJMNCPDJNOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x74AA730", Offset = "0x74A9B30", VA = "0x1874AA730")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public IReadOnlyList<KeepsakeRoomListDTO> JDAHJCNPPLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x9B9300", Offset = "0x9B8700", VA = "0x1809B9300", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public IReadOnlyList<KeepsakeRoomListDTO> PDBBEJLAJJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x9B9610", Offset = "0x9B8A10", VA = "0x1809B9610", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IReadOnlyList<KeepsakeRoomListDTO> BKEODGKHKKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xA27B70", Offset = "0xA26F70", VA = "0x180A27B70", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public IReadOnlyDictionary<long, string> LIGCONLAOOO
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x9B8A20", Offset = "0x9B7E20", VA = "0x1809B8A20", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	internal bool NGPPOEPBCKG
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xA24410", Offset = "0xA23810", VA = "0x180A24410")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Guid?> PDPBEKKOKMO
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x74A7760", Offset = "0x74A6B60", VA = "0x1874A7760", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x74A4C50", Offset = "0x74A4050", VA = "0x1874A4C50", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action LAJGPAMLJKP
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x74AA740", Offset = "0x74A9B40", VA = "0x1874AA740", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x74A5A30", Offset = "0x74A4E30", VA = "0x1874A5A30", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action IMKPBFPPJAC
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x74A5AD0", Offset = "0x74A4ED0", VA = "0x1874A5AD0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x74A3DB0", Offset = "0x74A31B0", VA = "0x1874A3DB0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x74AEAA0", Offset = "0x74ADEA0", VA = "0x1874AEAA0")]
	[RecRoom.NoEngine.Common.Preserve]
	internal IACPIHHHCOI([IBJCGEMJMJL(null)][NotNull] GFJFIDGHMOA CKEMIOHGOMD, [NotNull][IBJCGEMJMJL(null)] DMBDJAPHJEC LINBCANIEFD, [NotNull][IBJCGEMJMJL(null)] IGEFIGDGMAI JKPDOMGEHKN, [NotNull][IBJCGEMJMJL(null)] ADCPBBIAOCH BCAIDBPILOG, [IBJCGEMJMJL(null)][NotNull] KJCONENAPPK HFNIINCGAEG, [IBJCGEMJMJL(null)][NotNull] EKKKCNGJBOO GHFCFJHMPHJ, [IBJCGEMJMJL(null)][NotNull] CIFKNFKILGE OMMKHBGELAA, [NotNull][IBJCGEMJMJL(null)] ENHCOOGKGFN ADFGFLNPGOG, [NotNull][IBJCGEMJMJL(null)] JFIOHCKEEIP MGMCFGLJIGI, [NotNull][IBJCGEMJMJL(null)] LHJPLLHHNOK DPMKKMKPHHH, [NotNull][IBJCGEMJMJL(null)] MLOAEAIKDOJ EDEPPIBHBIF, [NotNull][IBJCGEMJMJL(null)] FGKLOENKHBI HHGBOFOOHDB, [NotNull][IBJCGEMJMJL(null)] CMCKGIJHJHE NJDKDNFLIHG, [NotNull][IBJCGEMJMJL(null)] KLHECNJFMMO AOMNFIDCDEK, [IBJCGEMJMJL(null)][NotNull] OKEMOHPNDNB DCEMBCAMKNJ, [IBJCGEMJMJL(null)][NotNull] CKBCKKNCCCO PENLKINHKAD, [NotNull][IBJCGEMJMJL(null)] CCAOPILOOAO AJLMACGMCAP, [IBJCGEMJMJL(null)][NotNull] BCCJIGCFKHM<KeepsakesConfig.KeepsakesOptions> DCEHMKPFEJH, [NotNull][IBJCGEMJMJL(null)] FIIDOADKEDD MGBNFJALEFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x74AD9D0", Offset = "0x74ACDD0", VA = "0x1874AD9D0", Slot = "15")]
	public bool OCCNNMOLCBH(List<string> PLMCLHPCKGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x74A67F0", Offset = "0x74A5BF0", VA = "0x1874A67F0", Slot = "16")]
	public NEEPBAPEEOL<Guid> HDCDAFPBCID(MAIAFFCEMDA EALFFCNJEPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x74A4EB0", Offset = "0x74A42B0", VA = "0x1874A4EB0", Slot = "17")]
	public HJOKANJAKGB FAEGOKPFOKP(Guid CBCFADAIBAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x74A73B0", Offset = "0x74A67B0", VA = "0x1874A73B0", Slot = "18")]
	public HJOKANJAKGB HEHMKNNEGJA(Guid CBCFADAIBAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x74AA1D0", Offset = "0x74A95D0", VA = "0x1874AA1D0", Slot = "19")]
	public bool KKNAALMPOAI(Guid CBCFADAIBAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x74ADEC0", Offset = "0x74AD2C0", VA = "0x1874ADEC0", Slot = "20")]
	public bool OKLODBGBFAL(Guid CBCFADAIBAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x74AE360", Offset = "0x74AD760", VA = "0x1874AE360")]
	public KeepsakeTheme PDFFPALMGIB(Guid CBCFADAIBAF)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x74ADEF0", Offset = "0x74AD2F0", VA = "0x1874ADEF0")]
	public bool OKMCPHPHOBI(MAIAFFCEMDA EALFFCNJEPJ, [Out] KeepsakeTheme KAFMNEBABOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x74A3260", Offset = "0x74A2660", VA = "0x1874A3260")]
	public List<KeepsakeTheme> DCNHIMMFENL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x74A95B0", Offset = "0x74A89B0", VA = "0x1874A95B0")]
	public int KCAPDHMGDAI(MAIAFFCEMDA EALFFCNJEPJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x74A30A0", Offset = "0x74A24A0", VA = "0x1874A30A0")]
	public MAIAFFCEMDA CNIKIKAGIAL(Guid CBCFADAIBAF)
	{
		return default(MAIAFFCEMDA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x74A4210", Offset = "0x74A3610", VA = "0x1874A4210", Slot = "34")]
	public List<MAIAFFCEMDA> DPGODPFNMHF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x74ADE00", Offset = "0x74AD200", VA = "0x1874ADE00", Slot = "35")]
	public IComparer<MAIAFFCEMDA> OIAFJGAHLCJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x74AE0D0", Offset = "0x74AD4D0", VA = "0x1874AE0D0", Slot = "32")]
	public string OOEJNGOEPFD(MAIAFFCEMDA EALFFCNJEPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x74A8D60", Offset = "0x74A8160", VA = "0x1874A8D60", Slot = "33")]
	public string IPKPKEBGNJH(MAIAFFCEMDA EALFFCNJEPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x74A82B0", Offset = "0x74A76B0", VA = "0x1874A82B0", Slot = "21")]
	public bool IBCPHAPFJLO(Guid CBCFADAIBAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x74A5B70", Offset = "0x74A4F70", VA = "0x1874A5B70", Slot = "22")]
	public void GGKLEABLGKL(Guid CBCFADAIBAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x74A8630", Offset = "0x74A7A30", VA = "0x1874A8630", Slot = "23")]
	public void IGPCHGKBELD(MAIAFFCEMDA EALFFCNJEPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x74A9F90", Offset = "0x74A9390", VA = "0x1874A9F90", Slot = "24")]
	public void KKLJJPNKEDA(Guid CBCFADAIBAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x74A5F60", Offset = "0x74A5360", VA = "0x1874A5F60", Slot = "25")]
	public int GNNGDGIMMFA()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x74A3E50", Offset = "0x74A3250", VA = "0x1874A3E50", Slot = "31")]
	public NEEPBAPEEOL<IEnumerable<Guid>> DOFGGPLGLBD(long FFFLOIOFAMB, long ECHBAPBKGNC, MAIAFFCEMDA? EALFFCNJEPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x74A8BC0", Offset = "0x74A7FC0", VA = "0x1874A8BC0", Slot = "30")]
	public NEEPBAPEEOL<IEnumerable<Guid>> IOMJIMDFPHP(long FFFLOIOFAMB, long ECHBAPBKGNC, MAIAFFCEMDA? EALFFCNJEPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x74A5570", Offset = "0x74A4970", VA = "0x1874A5570", Slot = "54")]
	public NEEPBAPEEOL<Dictionary<Guid, MAIAFFCEMDA>> GAMLIKMJJCO(long FFFLOIOFAMB, long ECHBAPBKGNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x74A80C0", Offset = "0x74A74C0", VA = "0x1874A80C0", Slot = "55")]
	public NEEPBAPEEOL<Dictionary<Guid, MAIAFFCEMDA>> HNPIMCCOOEJ(long FFFLOIOFAMB, long ECHBAPBKGNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x74AD5F0", Offset = "0x74AC9F0", VA = "0x1874AD5F0", Slot = "26")]
	public NEEPBAPEEOL<int> NLLAJGEJEHC(long FFFLOIOFAMB, long ECHBAPBKGNC, MAIAFFCEMDA? EALFFCNJEPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x74A8A60", Offset = "0x74A7E60", VA = "0x1874A8A60", Slot = "27")]
	public NEEPBAPEEOL<int> IJOMEOOBCKO(long FFFLOIOFAMB, long ECHBAPBKGNC, MAIAFFCEMDA? EALFFCNJEPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x74A2470", Offset = "0x74A1870", VA = "0x1874A2470", Slot = "28")]
	public NEEPBAPEEOL<Dictionary<MAIAFFCEMDA, int>> BJECIEFEGFE(long FFFLOIOFAMB, long ECHBAPBKGNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x74A5130", Offset = "0x74A4530", VA = "0x1874A5130", Slot = "29")]
	public NEEPBAPEEOL<Dictionary<MAIAFFCEMDA, int>> FDHEMHBDDLC(long FFFLOIOFAMB, long ECHBAPBKGNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x74A3200", Offset = "0x74A2600", VA = "0x1874A3200", Slot = "37")]
	public bool DAGNOCENJMM(long FFFLOIOFAMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x74A47C0", Offset = "0x74A3BC0", VA = "0x1874A47C0", Slot = "56")]
	public bool EDIBDKOCBDA(long FFFLOIOFAMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x74AD8A0", Offset = "0x74ACCA0", VA = "0x1874AD8A0", Slot = "38")]
	public bool NLMAPJBNCMG(long FFFLOIOFAMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x74ACA70", Offset = "0x74ABE70", VA = "0x1874ACA70", Slot = "57")]
	public bool MKCCPGHEOHF(long FFFLOIOFAMB, [Out] EBPFFGDIFFM FKKNFCGKGEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x74A8680", Offset = "0x74A7A80", VA = "0x1874A8680", Slot = "39")]
	public bool IHBFGIIFIBL(long ICPGCFKAGBA, [Out] DateTime FJAPCIHJEHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x74A9070", Offset = "0x74A8470", VA = "0x1874A9070", Slot = "40")]
	public long JOBCAOKJGNE(long ICPGCFKAGBA)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x74A5920", Offset = "0x74A4D20", VA = "0x1874A5920", Slot = "41")]
	public long GCHFCILHOIM(long FFFLOIOFAMB)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x74A2000", Offset = "0x74A1400", VA = "0x1874A2000", Slot = "42")]
	public int AAHFHLNBBKK(long ICPGCFKAGBA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x74A8550", Offset = "0x74A7950", VA = "0x1874A8550", Slot = "43")]
	public bool IDPMKEGPOGK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x74A6660", Offset = "0x74A5A60", VA = "0x1874A6660", Slot = "44")]
	public bool HCBBPJBOGHD(long ICPGCFKAGBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x74A98D0", Offset = "0x74A8CD0", VA = "0x1874A98D0", Slot = "45")]
	public IReadOnlyList<long> KGNJAOAKMIF(long ICPGCFKAGBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x74AA410", Offset = "0x74A9810", VA = "0x1874AA410", Slot = "46")]
	public int KPGBJNONMBL(long ICPGCFKAGBA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x74ACED0", Offset = "0x74AC2D0", VA = "0x1874ACED0", Slot = "50")]
	public long NGEIDKAECHO(long MFJNOLFGAKE)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x74AA7E0", Offset = "0x74A9BE0", VA = "0x1874AA7E0", Slot = "51")]
	public MAIAFFCEMDA LHGFJKMGEGB()
	{
		return default(MAIAFFCEMDA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x74A21E0", Offset = "0x74A15E0", VA = "0x1874A21E0")]
	private bool AECHODJBBBC(Guid CBCFADAIBAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x74A7A30", Offset = "0x74A6E30", VA = "0x1874A7A30")]
	private void HJOHLPFMGBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x74AB6B0", Offset = "0x74AAAB0", VA = "0x1874AB6B0")]
	private MAIAFFCEMDA MFOOOEPMCJP()
	{
		return default(MAIAFFCEMDA);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x74AAB50", Offset = "0x74A9F50", VA = "0x1874AAB50")]
	private void LKNMLKGIEHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x74A88C0", Offset = "0x74A7CC0", VA = "0x1874A88C0")]
	private int IJGPANCNMFK(KeepsakeRoomListDTO JFJPBKAALIP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x74A5BE0", Offset = "0x74A4FE0", VA = "0x1874A5BE0")]
	private int GHJAMMGDLCB(DateTime CECGJMEMLMP, DateTime FOAGHGNHCNA, TimeSpan DJKGEIJGEPL, int HHCKLEKEOAA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x74A63A0", Offset = "0x74A57A0", VA = "0x1874A63A0")]
	private void GOCKBGHICBE(IEnumerable<KeepsakeInstanceDTO> IOGMLEMBKHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x74A2890", Offset = "0x74A1C90", VA = "0x1874A2890")]
	private void BOGFCPIIAAA(IEnumerable<KeepsakeCollectionRecordDTO> MLOAEIPLEOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x74A4BF0", Offset = "0x74A3FF0", VA = "0x1874A4BF0")]
	private void EENKGEMDIFH(IEnumerable<long> OIPLPAJBBFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x1088970", Offset = "0x1087D70", VA = "0x181088970")]
	private void IEGOEIIDNPH(KeepsakeGlobalConfigDTO PHMMNNJJCCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x74AA4C0", Offset = "0x74A98C0", VA = "0x1874AA4C0")]
	private bool LAMEICJCPJJ(MAIAFFCEMDA EALFFCNJEPJ, [Out] Guid GLLDKBLLCKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x74A53E0", Offset = "0x74A47E0", VA = "0x1874A53E0")]
	private bool FNBGLKEPPGE([Out] Guid GLLDKBLLCKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x74A2E40", Offset = "0x74A2240", VA = "0x1874A2E40")]
	private bool CFIMJGIONJG(Guid CBCFADAIBAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x74A2310", Offset = "0x74A1710", VA = "0x1874A2310")]
	private IEnumerable<Guid> AMDJFOLBIFF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x74ADC60", Offset = "0x74AD060", VA = "0x1874ADC60")]
	private IEnumerable<KeepsakeInstanceDTO> OEGJHEILJBO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x74ACE40", Offset = "0x74AC240", VA = "0x1874ACE40")]
	private void NFKIMMOFBMA(Guid CBCFADAIBAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x74A9EE0", Offset = "0x74A92E0", VA = "0x1874A9EE0")]
	private bool KJKLOOPGGHL(Guid CBCFADAIBAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x74A9730", Offset = "0x74A8B30", VA = "0x1874A9730")]
	private void KFKDHIMBIOJ(Guid CBCFADAIBAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x74ADD20", Offset = "0x74AD120", VA = "0x1874ADD20")]
	private void OFEMIMMIIIK(MAIAFFCEMDA AJKIFLFMGBI, int MKOOFCPFHDD, Dictionary<MAIAFFCEMDA, int> AJIMIAGJCFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x74A5480", Offset = "0x74A4880", VA = "0x1874A5480")]
	private int FOOJMFKGNOL(MAIAFFCEMDA EALFFCNJEPJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x74A2C70", Offset = "0x74A2070", VA = "0x1874A2C70")]
	private void CFBLILIOBEG(KeepsakeInstanceDTO IFFHMJLNINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x74A2680", Offset = "0x74A1A80", VA = "0x1874A2680")]
	private void BNIMMKCOKGN(KeepsakeInstanceDTO IFFHMJLNINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x74A4820", Offset = "0x74A3C20", VA = "0x1874A4820")]
	private void EENAABGJOJB(Guid CBCFADAIBAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x74A6630", Offset = "0x74A5A30", VA = "0x1874A6630")]
	private void JLLAOOLANAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x74A7740", Offset = "0x74A6B40", VA = "0x1874A7740")]
	private void HEOKMCELMEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x74A8FB0", Offset = "0x74A83B0", VA = "0x1874A8FB0")]
	private void JKJPMLEFMKA(ONLCNDEELLL EDKKLGLMFKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x74A6630", Offset = "0x74A5A30", VA = "0x1874A6630")]
	private void HAKIDMKFNHP(OFJIPMOFMFM GMFKPONAANG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x74A6630", Offset = "0x74A5A30", VA = "0x1874A6630")]
	private void IJDPJIPDEGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x74A9B40", Offset = "0x74A8F40", VA = "0x1874A9B40")]
	private void KHDGNDFKPCN(float GJIDBFHGEOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x74A6E10", Offset = "0x74A6210", VA = "0x1874A6E10")]
	private void HDPOAOAHPHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x74A2EA0", Offset = "0x74A22A0", VA = "0x1874A2EA0")]
	private bool CHINJIFHCBF(Guid CBCFADAIBAF, [Out] string JNIFLFMIGGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x74AE8D0", Offset = "0x74ADCD0", VA = "0x1874AE8D0")]
	private bool POGFKDKPHEF(Guid CBCFADAIBAF, [Out] KeepsakeCategoryConfigDTO AJKIFLFMGBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x74A3CD0", Offset = "0x74A30D0", VA = "0x1874A3CD0")]
	private void DKKKKABOGHD(string JGKKKNKIGEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x74A5E50", Offset = "0x74A5250", VA = "0x1874A5E50")]
	private bool GNIDKNBLGEL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x74AE4C0", Offset = "0x74AD8C0", VA = "0x1874AE4C0")]
	private List<long> PHHKDHDOCID(IEnumerable<KeepsakeRoomDTO> BPBCOLEPJDB, IReadOnlyList<KeepsakeRoomListDTO> BOKJFJMKBNO, long ICPGCFKAGBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x74AB190", Offset = "0x74AA590", VA = "0x1874AB190")]
	private bool LLHJGCIMDKM(Guid CBCFADAIBAF, [Out] string IFMHONGNKHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x74A7810", Offset = "0x74A6C10", VA = "0x1874A7810", Slot = "47")]
	public string HIOFLPHIMLB(PKPEIGLPOOD HBFCLOEJEAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x74A3780", Offset = "0x74A2B80", VA = "0x1874A3780", Slot = "49")]
	public string DGKBBLLEEAO(PKPEIGLPOOD HBFCLOEJEAJ, long FFFLOIOFAMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x74AA330", Offset = "0x74A9730", VA = "0x1874AA330", Slot = "48")]
	public string KOPCCDNHDIG(PKPEIGLPOOD HBFCLOEJEAJ, int GNLBGJKLMHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x74AB990", Offset = "0x74AAD90", VA = "0x1874AB990")]
	private void MGAMKCGMNKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x74A2AE0", Offset = "0x74A1EE0", VA = "0x1874A2AE0")]
	private void BOOGNDNILOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x74AD5D0", Offset = "0x74AC9D0", VA = "0x1874AD5D0")]
	private PKPEIGLPOOD NKPAAENMJGB(LHLHDPGPOJN PGMGMCBDDKM)
	{
		return default(PKPEIGLPOOD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x74ACE20", Offset = "0x74AC220", VA = "0x1874ACE20")]
	private PKPEIGLPOOD NCDFKILCBIO(LHLHDPGPOJN PGMGMCBDDKM)
	{
		return default(PKPEIGLPOOD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x74AC890", Offset = "0x74ABC90", VA = "0x1874AC890")]
	internal static string MHGFFCHFNEJ(GPHBDLOMFBC GIBMLNMIEIO, string HOHCOKEPABP, bool FMMDLFJAONF, int JCMKOFIEMPK, int DDOFGFJGGEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x74A4360", Offset = "0x74A3760", VA = "0x1874A4360", Slot = "52")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x74AD550", Offset = "0x74AC950", VA = "0x1874AD550")]
	private GGLMIDJEDGD NJBNNHLCILI(OPHKANJGPPK JHKDFCONLEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x74A7F00", Offset = "0x74A7300", VA = "0x1874A7F00")]
	private JKEGNLFNIEK HLIEPBKOEKB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x74AD190", Offset = "0x74AC590", VA = "0x1874AD190")]
	private Task NHOHFFGDLIA(BPPINHJEEIJ JIEBKPCGKFF, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x74AE250", Offset = "0x74AD650", VA = "0x1874AE250")]
	[AsyncStateMachine(typeof(MEKDIBIHNGM))]
	private Task OPNPMAHJHPB(BPPINHJEEIJ JIEBKPCGKFF, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x74AE7A0", Offset = "0x74ADBA0", VA = "0x1874AE7A0")]
	private Task PJLODGCNBBD(BPPINHJEEIJ JIEBKPCGKFF, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x74A3BA0", Offset = "0x74A2FA0", VA = "0x1874A3BA0")]
	[AsyncStateMachine(typeof(GHGONONANMB))]
	private Task DJHOOIKPMKI(string MIALAMIFNLM, TimeSpan OAKCDHIGPHN, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x74A4D00", Offset = "0x74A4100", VA = "0x1874A4D00")]
	[CompilerGenerated]
	private void EOFBCHPNBFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x74AE880", Offset = "0x74ADC80", VA = "0x1874AE880")]
	[CompilerGenerated]
	private void PNMKIGBEKFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x74A87C0", Offset = "0x74A7BC0", VA = "0x1874A87C0")]
	[CompilerGenerated]
	private bool IHPEEJPBKCE(KeepsakeInstanceDTO IKAEODCKAIP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x74A3610", Offset = "0x74A2A10", VA = "0x1874A3610")]
	[CompilerGenerated]
	private NEEPBAPEEOL<Dictionary<MAIAFFCEMDA, int>> DFMIOHGMCEM(Dictionary<Guid, MAIAFFCEMDA> NBMBAAHKNKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x74A5CE0", Offset = "0x74A50E0", VA = "0x1874A5CE0")]
	[CompilerGenerated]
	private NEEPBAPEEOL<Dictionary<MAIAFFCEMDA, int>> GHLFBDPFLOI(Dictionary<Guid, MAIAFFCEMDA> NBMBAAHKNKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x74AE4A0", Offset = "0x74AD8A0", VA = "0x1874AE4A0")]
	[CompilerGenerated]
	private bool PHBNGKBIAAH(KeepsakeRoomListDTO IKAEODCKAIP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x74A52B0", Offset = "0x74A46B0", VA = "0x1874A52B0")]
	[CompilerGenerated]
	private bool FFEODHMIIOB(KeepsakeInstanceDTO IKAEODCKAIP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x74A4D20", Offset = "0x74A4120", VA = "0x1874A4D20")]
	[CompilerGenerated]
	private void EOFKCOGLDLL(Tuple<KeepsakeRoomInstancesDTO, IReadOnlyDictionary<MAIAFFCEMDA, KeepsakeCategoryConfigDTO>, KeepsakeGlobalConfigDTO> JCAJHFICHIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x74A8250", Offset = "0x74A7650", VA = "0x1874A8250")]
	[CompilerGenerated]
	private void HOJFJPDKIPI(string IFMHONGNKHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x74A7870", Offset = "0x74A6C70", VA = "0x1874A7870")]
	[CompilerGenerated]
	private Task HJOBNKKIAHI(CancellationToken KOEKDKPOPPK)
	{
		return null;
	}
}
namespace RecRoom.Keepsakes
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public class KeepsakesConfig : ScriptableObject, BCCJIGCFKHM<KeepsakesConfig.KeepsakesOptions>
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200002B")]
		public class KeepsakesOptions
		{
			[Cpp2IlInjected.Token(Token = "0x200002C")]
			[CompilerGenerated]
			private sealed class HFKKJFOIGFN
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000098")]
				public string themeId;

				[Cpp2IlInjected.Token(Token = "0x60000F3")]
				[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
				public HFKKJFOIGFN()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000F4")]
				[Cpp2IlInjected.Address(RVA = "0x74A1C20", Offset = "0x74A1020", VA = "0x1874A1C20")]
				internal bool DJJLKHHEDCK(KeepsakeTheme x)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60000F5")]
				[Cpp2IlInjected.Address(RVA = "0x74A1C20", Offset = "0x74A1020", VA = "0x1874A1C20")]
				internal bool OLAMPENCMCO(KeepsakeTheme x)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			[SerializeField]
			private KeepsakeTheme[] themes;

			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x74B0610", Offset = "0x74AFA10", VA = "0x1874B0610")]
			public bool BKMAMINJMED(string HOGPMAAFCHE, [Out] KeepsakeTheme KAFMNEBABOO)
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
			[Cpp2IlInjected.Address(RVA = "0x94B6B0", Offset = "0x94AAB0", VA = "0x18094B6B0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x74B0590", Offset = "0x74AF990", VA = "0x1874B0590")]
		[HLOHOCOKELO.IDGFAEKKODB.GGCNFHIOHEN]
		internal static void HBMGFBHOMDP(GFKEMDIOCPC MGOKPJKELJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0xA3C8E0", Offset = "0xA3BCE0", VA = "0x180A3C8E0")]
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
