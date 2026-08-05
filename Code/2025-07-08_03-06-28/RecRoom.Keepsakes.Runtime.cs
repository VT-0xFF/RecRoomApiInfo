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
		[Cpp2IlInjected.Address(RVA = "0x8111020", Offset = "0x810FE20", VA = "0x188111020", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x286F3E0", Offset = "0x286E1E0", VA = "0x18286F3E0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class KJHECLPCDBM : IComparer<MMIEHDFJNAE>
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private sealed class KHDCAONFIKP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public MMIEHDFJNAE x;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public MMIEHDFJNAE y;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public KHDCAONFIKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xE10460", Offset = "0xE0F260", VA = "0x180E10460")]
		internal bool FGGOCLEFDDA(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x20F5440", Offset = "0x20F4240", VA = "0x1820F5440")]
		internal bool EHNNIINPJFB(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xE10460", Offset = "0xE0F260", VA = "0x180E10460")]
		internal bool PPBPDNCFNDL(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x20F5440", Offset = "0x20F4240", VA = "0x1820F5440")]
		internal bool BCONFJCPBDP(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private List<KeepsakeCategoryThemePair> AKNBBBBINNM;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0xA665B0", Offset = "0xA653B0", VA = "0x180A665B0")]
	public KJHECLPCDBM(List<KeepsakeCategoryThemePair> JDOEMKABBFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x810F470", Offset = "0x810E270", VA = "0x18810F470", Slot = "4")]
	public int Compare(MMIEHDFJNAE DHOMBGCEEAK, MMIEHDFJNAE EDBCCDDDLPI)
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
		public MMIEHDFJNAE KeepsakeCategory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public KeepsakeTheme KeepsakeTheme;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[HCBEFNLCJPF]
public class GBLJIANGHEB : NBIEOFHOKIL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class NHPGLKEKGMH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public GBLJIANGHEB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public MMIEHDFJNAE keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public NHPGLKEKGMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x8110790", Offset = "0x810F590", VA = "0x188110790")]
		internal CEBCBDBEPBJ<Guid> IDDKHNPDPHO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x8110760", Offset = "0x810F560", VA = "0x188110760")]
		internal void HFFCJBJMHOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x8110700", Offset = "0x810F500", VA = "0x188110700")]
		internal void GNMOOBAHLDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x81102F0", Offset = "0x810F0F0", VA = "0x1881102F0")]
		internal void CIJHNDEABEH(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x81108E0", Offset = "0x810F6E0", VA = "0x1881108E0")]
		internal void IPFGALIJBOF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class KJNPOCCCOFE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public GBLJIANGHEB <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public KJNPOCCCOFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x810F780", Offset = "0x810E580", VA = "0x18810F780")]
		internal void FACIPAFCJAE(HMDHBLPJBHH response)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x810F720", Offset = "0x810E520", VA = "0x18810F720")]
		internal void AJAGCOGLIDH(string error)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class GKFCGGJMLGF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public KeepsakeTheme theme;

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public GKFCGGJMLGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x810EAA0", Offset = "0x810D8A0", VA = "0x18810EAA0")]
		internal bool LFNLAAAHKLE(KeepsakeCategoryThemePair categoryThemePair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class BFFLGIFDDLH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public GBLJIANGHEB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public long progressionEventId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public MMIEHDFJNAE? keepsakeCategory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public BFFLGIFDDLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x8100050", Offset = "0x80FEE50", VA = "0x188100050")]
		internal void NCALGCAAPKF(KeepsakeProgressionEventInstancesDTO result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x8100020", Offset = "0x80FEE20", VA = "0x188100020")]
		internal void NAKEPFMKFFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x80FFD20", Offset = "0x80FEB20", VA = "0x1880FFD20")]
		internal CEBCBDBEPBJ<IEnumerable<Guid>> KPOCMJDDABG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x7BFF950", Offset = "0x7BFE750", VA = "0x187BFF950")]
		internal bool AHGBHGIAFHN(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class LNIAJIEOMNN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public KeepsakeRoomInstanceIdsDTO instancesInRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public BFFLGIFDDLH CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public LNIAJIEOMNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x8110080", Offset = "0x810EE80", VA = "0x188110080")]
		internal CEBCBDBEPBJ<IEnumerable<Guid>> CFIJEBNAHBM(KeepsakeRoomInstancesDTO roomInstancesDTO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class NDJKHFPIHBD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public KeepsakeRoomInstancesDTO roomInstancesDTO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public LNIAJIEOMNN CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public NDJKHFPIHBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x81101C0", Offset = "0x810EFC0", VA = "0x1881101C0")]
		internal bool FNNKHCIHJNI(Guid instanceId)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class KEJJIBFOLPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Guid instanceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public NDJKHFPIHBD CS$<>8__locals3;

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public KEJJIBFOLPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x810EE40", Offset = "0x810DC40", VA = "0x18810EE40")]
		internal bool NPECMNDBCIE(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class BHAMNFADJGP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public GBLJIANGHEB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public BHAMNFADJGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x81000E0", Offset = "0x80FEEE0", VA = "0x1881000E0")]
		internal CEBCBDBEPBJ<IEnumerable<Guid>> DAGMIDKKPBN(IEnumerable<Guid> instanceIds)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x8100250", Offset = "0x80FF050", VA = "0x188100250")]
		internal bool JGGAIMFCMBB(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class GEGCLAEMLMF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public GBLJIANGHEB <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public GEGCLAEMLMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x810E720", Offset = "0x810D520", VA = "0x18810E720")]
		internal void JDIIKEPNLOE(KeepsakeProgressionEventInstancesDTO result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x8100020", Offset = "0x80FEE20", VA = "0x188100020")]
		internal void APBELIMLAHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x810E7B0", Offset = "0x810D5B0", VA = "0x18810E7B0")]
		internal CEBCBDBEPBJ<Dictionary<Guid, MMIEHDFJNAE>> OBBPGLHOAFJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x7BFF950", Offset = "0x7BFE750", VA = "0x187BFF950")]
		internal bool JMCIPCBGJJF(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class FEIGCOHGPPA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public KeepsakeRoomInstanceIdsDTO instancesInRoom;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public FEIGCOHGPPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x8100550", Offset = "0x80FF350", VA = "0x188100550")]
		internal CEBCBDBEPBJ<Dictionary<Guid, MMIEHDFJNAE>> FCJGBANMBCM(KeepsakeRoomInstancesDTO roomInstancesDTO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class JIIMMEHANEJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public KeepsakeRoomInstancesDTO roomInstancesDTO;

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public JIIMMEHANEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x810ED60", Offset = "0x810DB60", VA = "0x18810ED60")]
		internal bool GKEFFJDBPOC(Guid instanceId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x810EC10", Offset = "0x810DA10", VA = "0x18810EC10")]
		internal KeyValuePair<Guid, MMIEHDFJNAE> BHJBONGGPFD(Guid instanceId)
		{
			return default(KeyValuePair<Guid, MMIEHDFJNAE>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class KBJANFIPJAD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public Guid instanceId;

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public KBJANFIPJAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x278BEF0", Offset = "0x278ACF0", VA = "0x18278BEF0")]
		internal bool OAHDABJFOGD(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class KKDNNBNNGHI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public Guid instanceId;

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public KKDNNBNNGHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x278BEF0", Offset = "0x278ACF0", VA = "0x18278BEF0")]
		internal bool IDINFEOIHBP(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class BKKONPEMHGO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public GBLJIANGHEB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public BKKONPEMHGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x81002F0", Offset = "0x80FF0F0", VA = "0x1881002F0")]
		internal CEBCBDBEPBJ<Dictionary<Guid, MMIEHDFJNAE>> ILICJMNMHDD(Dictionary<Guid, MMIEHDFJNAE> instanceIdsAndCategories)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x8100250", Offset = "0x80FF050", VA = "0x188100250")]
		internal bool PLBHGFPGEIG(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class IJJNBGANALF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public KeepsakeRoomInstanceIdsDTO collectedInstanceIds;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public IJJNBGANALF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x810EB60", Offset = "0x810D960", VA = "0x18810EB60")]
		internal bool EANCHIJKPJN(KeyValuePair<Guid, MMIEHDFJNAE> idCategoryPair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class PHBKOOIPPFI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public Dictionary<Guid, MMIEHDFJNAE> instanceIdsAndCategories;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public PHBKOOIPPFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x8110A60", Offset = "0x810F860", VA = "0x188110A60")]
		internal KeyValuePair<MMIEHDFJNAE, int> AOEJAMCDPDB(MMIEHDFJNAE category)
		{
			return default(KeyValuePair<MMIEHDFJNAE, int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class CMKLLDINCCL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public MMIEHDFJNAE category;

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public CMKLLDINCCL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0xF19350", Offset = "0xF18150", VA = "0x180F19350")]
		internal bool CNJKFKCOEEK(MMIEHDFJNAE instanceCategory)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class ADDMMFAIECB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public Dictionary<Guid, MMIEHDFJNAE> instanceIdsAndCategories;

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public ADDMMFAIECB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x80FFB10", Offset = "0x80FE910", VA = "0x1880FFB10")]
		internal KeyValuePair<MMIEHDFJNAE, int> JKFIAJONMNC(MMIEHDFJNAE category)
		{
			return default(KeyValuePair<MMIEHDFJNAE, int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class MFHMFHOCIKI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public MMIEHDFJNAE category;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public MFHMFHOCIKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0xF19350", Offset = "0xF18150", VA = "0x180F19350")]
		internal bool IBGBMAKCJDH(MMIEHDFJNAE instanceCategory)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class PKGJOHMKPFO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public GBLJIANGHEB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public Func<KeepsakeRoomDTO, bool> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public PKGJOHMKPFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x8110BD0", Offset = "0x810F9D0", VA = "0x188110BD0")]
		internal bool GHBBAGOKHLB(DateTime nowUtc, DateTime eventStartTime, int roomOrder, TimeSpan unlockStartOffset, TimeSpan unlockInterval, int unlockBatchSize)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x8110CC0", Offset = "0x810FAC0", VA = "0x188110CC0")]
		internal bool IFIEBCANGMA(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x8110BB0", Offset = "0x810F9B0", VA = "0x188110BB0")]
		internal bool EGMDIFFOMCH(KeepsakeRoomDTO r)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x8110BB0", Offset = "0x810F9B0", VA = "0x188110BB0")]
		internal bool OBBMMFMFHAK(KeepsakeRoomDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class KKACHPKIPFB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public KKACHPKIPFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0xFAB770", Offset = "0xFAA570", VA = "0x180FAB770")]
		internal bool CEPIBFPEFNK(KeepsakeRoomListDTO roomList)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class AIMIBGBMIHE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public Func<KeepsakeRoomDTO, bool> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public AIMIBGBMIHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x80FFC60", Offset = "0x80FEA60", VA = "0x1880FFC60")]
		internal bool KLCPLIBDIKB(KeepsakeRoomListDTO roomList)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x2727270", Offset = "0x2726070", VA = "0x182727270")]
		internal bool CDAOPEEFDFL(KeepsakeRoomDTO room)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class OBPKMAGFABI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public OBPKMAGFABI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x8110910", Offset = "0x810F710", VA = "0x188110910")]
		internal bool LALCCOOBKPB(KeepsakeRoomListDTO i)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class DLEKCGKOAEB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public DLEKCGKOAEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0xFAB770", Offset = "0xFAA570", VA = "0x180FAB770")]
		internal bool JAPBGABEKBM(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class EKDFGAKCMNG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public Guid keepsakeInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public EKDFGAKCMNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x81004F0", Offset = "0x80FF2F0", VA = "0x1881004F0")]
		internal bool GIIFNCCIEDF(KeyValuePair<Guid, KeepsakeInstanceDTO> instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class FGCMGNOMLKD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public MMIEHDFJNAE keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public FGCMGNOMLKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x23319E0", Offset = "0x23307E0", VA = "0x1823319E0")]
		internal bool NFPOJHPMCJD(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class HCHDKOKLANK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public Guid keepsakeInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public HCHDKOKLANK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x810EAC0", Offset = "0x810D8C0", VA = "0x18810EAC0")]
		internal bool MOMEFEDJLPB(KeyValuePair<Guid, KeepsakeInstanceDTO> instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class IJCBFBIKOIB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public MMIEHDFJNAE keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public IJCBFBIKOIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x810EB20", Offset = "0x810D920", VA = "0x18810EB20")]
		internal bool FDCMAOHJEGO(KeyValuePair<Guid, MMIEHDFJNAE> x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class PJEJMGKHEDL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public MMIEHDFJNAE newKeepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public PJEJMGKHEDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x23319E0", Offset = "0x23307E0", VA = "0x1823319E0")]
		internal bool CECDBNIJMPC(KeepsakeInstanceDTO instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class BJKDKANMPKP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public long currentRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public long? currentSubRoomId;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public BJKDKANMPKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x8100270", Offset = "0x80FF070", VA = "0x188100270")]
		internal bool IJCHGFJMKJL(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class PEMNMJJAPPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public IReadOnlyList<KeepsakeRoomListDTO> roomList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public PEMNMJJAPPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x8110970", Offset = "0x810F770", VA = "0x188110970")]
		internal bool GMNMBLCEMNL(KeepsakeRoomDTO room)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class POANDKEGKHN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public KeepsakeRoomDTO room;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public PEMNMJJAPPJ CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public POANDKEGKHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x8110D80", Offset = "0x810FB80", VA = "0x188110D80")]
		internal bool BIJCHGJFDJF(KeepsakeRoomListDTO roomListDto)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private struct KINPEAEAAOK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public GBLJIANGHEB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public EIPHABKKBFG args;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x810EEF0", Offset = "0x810DCF0", VA = "0x18810EEF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x810F410", Offset = "0x810E210", VA = "0x18810F410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private struct LENGLHLNGKH : IAsyncStateMachine
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
		public GBLJIANGHEB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public string message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x810FD80", Offset = "0x810EB80", VA = "0x18810FD80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x8110020", Offset = "0x810EE20", VA = "0x188110020", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly DateTime DLKDLDCHOOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly DBDAHNGDEAD KDMNFHMFPLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly GFJHMBDCMFO CHPFLPIOIFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly JJLEENAFKBB PENBBBACLCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly INAJHAEFGAP GKFMGNGHIJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly IGPMCFDPCFE BFNHJCAHHAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly ADJKJNNEFOL JHAJHLFJFJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly CGDGOCJDGEK KPOCDPAKIDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly GLOINHDCCCK LEFGLILMCMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly NBAMFCCPNAH GMIOAHCNBEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly BCGJGHCGCOI CKLLCKOKOPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly DFDINHBLJIH BEGKLBJGHNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly OLNPKPHMNNE ENGNGPMGAHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly ECACGNCICMH PKLMKAJLNOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly EBOOCLAJMNB JICHLJCHAAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly NEFGBBBPMJE LFAMJEMPOAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly CNAMMMNFFBJ<KeepsakesConfig.KeepsakesOptions> LHBNHKOPIFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly EILEDNOBBBM BMDDNKKDAIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly Dictionary<Guid, KeepsakeInstanceDTO> HKKGCPMGCIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly HashSet<Guid> MBEFMFIKHJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly HashSet<long> DLJONANBHAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private Dictionary<MMIEHDFJNAE, int> NCEEAEDBOLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly HashSet<Guid> MFPHKKOCCPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly IDisposable OKCGDCJGCBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private Task FEFAFLGLMOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private CEBCBDBEPBJ<Guid> ICHNLIBCDLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private long? DCJAFJKGEHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private KeepsakeProgressionEventInstancesDTO JNODFEEEAIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private CEBCBDBEPBJ<KeepsakeProgressionEventInstancesDTO> CGMPNFPAMOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private IReadOnlyDictionary<MMIEHDFJNAE, KeepsakeCategoryConfigDTO> FPIGDIBCPBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private KeepsakeGlobalConfigDTO DNHKPIBNHJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private HashSet<long> PHCGEPBJOAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private HashSet<long> JLHJOKFBBLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private List<KeepsakeRoomListDTO> IFLADFDCBCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private List<KeepsakeRoomListDTO> CGDAFMLJPIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private List<KeepsakeRoomListDTO> HJIBFGEDLGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private Dictionary<long, string> BMEELELCADI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private Dictionary<long, string> IDFKOGPBNHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private Dictionary<long, DateTime> JKLKCELDNPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private Dictionary<long, List<KeepsakeRoomDTO>> MPIAFMCBGFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private Dictionary<long, List<KeepsakeRoomDTO>> LHKONEJNJJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private Dictionary<long, long> JJDLGPDCPJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly List<string> PKFMJHFOMCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private DateTime JPBCLAAHCDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly IDisposable PCDNGCKBKBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private Dictionary<Guid, MMIEHDFJNAE> JDGJMCBPLBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private Dictionary<MMIEHDFJNAE, int> MHPCLEHJPJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private List<KeepsakeCategoryThemePair> JDOEMKABBFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private KJHECLPCDBM EGPHPPLGFJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private bool JPHAFFPHKKC;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool JICIHHDACPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA86430", Offset = "0xA85230", VA = "0x180A86430", Slot = "53")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA861B0", Offset = "0xA84FB0", VA = "0x180A861B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool NGEMNLDFEAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8107DF0", Offset = "0x8106BF0", VA = "0x188107DF0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool BIPJAMPBCGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x810B130", Offset = "0x8109F30", VA = "0x18810B130", Slot = "36")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private long DNILIHFCNNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8107B80", Offset = "0x8106980", VA = "0x188107B80")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private long? CJAPMFOONAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x81090D0", Offset = "0x8107ED0", VA = "0x1881090D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private bool NEGFEOGJKDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8100700", Offset = "0x80FF500", VA = "0x188100700")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public IReadOnlyList<KeepsakeRoomListDTO> GOMICEEELJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xBB6A10", Offset = "0xBB5810", VA = "0x180BB6A10", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public IReadOnlyList<KeepsakeRoomListDTO> PMBCFDELHBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xBAAC50", Offset = "0xBA9A50", VA = "0x180BAAC50", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IReadOnlyList<KeepsakeRoomListDTO> KJDFGCAFLHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xBC4B60", Offset = "0xBC3960", VA = "0x180BC4B60", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public IReadOnlyDictionary<long, string> NOKGOIKOIJO
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xBB4C30", Offset = "0xBB3A30", VA = "0x180BB4C30", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	internal bool ADEBGIBNDCO
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xC9BED0", Offset = "0xC9ACD0", VA = "0x180C9BED0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Guid?> BCLKOHCKPON
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8106E40", Offset = "0x8105C40", VA = "0x188106E40", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x810ADB0", Offset = "0x8109BB0", VA = "0x18810ADB0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action PHBIFGLOPIG
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8105B10", Offset = "0x8104910", VA = "0x188105B10", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x810A2C0", Offset = "0x81090C0", VA = "0x18810A2C0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action MPBGNEHFNPA
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8100710", Offset = "0x80FF510", VA = "0x188100710", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8108B70", Offset = "0x8107970", VA = "0x188108B70", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x810D160", Offset = "0x810BF60", VA = "0x18810D160")]
	[RecRoom.NoEngine.Common.Preserve]
	internal GBLJIANGHEB([OLOAAHJODHH(null)][NotNull] DBDAHNGDEAD KDMNFHMFPLO, [NotNull][OLOAAHJODHH(null)] KGFJDPAACPB ADMEJHLBGMD, [NotNull][OLOAAHJODHH(null)] GFJHMBDCMFO CHPFLPIOIFD, [NotNull][OLOAAHJODHH(null)] JJLEENAFKBB PENBBBACLCN, [OLOAAHJODHH(null)][NotNull] INAJHAEFGAP GKFMGNGHIJN, [OLOAAHJODHH(null)][NotNull] IGPMCFDPCFE BFNHJCAHHAN, [OLOAAHJODHH(null)][NotNull] ADJKJNNEFOL JHAJHLFJFJD, [NotNull][OLOAAHJODHH(null)] CGDGOCJDGEK KPOCDPAKIDF, [NotNull][OLOAAHJODHH(null)] GLOINHDCCCK LEFGLILMCMC, [NotNull][OLOAAHJODHH(null)] CIOLLJBHAOI MHJFDOGPNFM, [NotNull][OLOAAHJODHH(null)] NBAMFCCPNAH GMIOAHCNBEI, [NotNull][OLOAAHJODHH(null)] BCGJGHCGCOI CKLLCKOKOPG, [NotNull][OLOAAHJODHH(null)] DFDINHBLJIH BEGKLBJGHNH, [NotNull][OLOAAHJODHH(null)] OLNPKPHMNNE ENGNGPMGAHN, [OLOAAHJODHH(null)][NotNull] ECACGNCICMH PKLMKAJLNOJ, [OLOAAHJODHH(null)][NotNull] EBOOCLAJMNB JICHLJCHAAH, [NotNull][OLOAAHJODHH(null)] NEFGBBBPMJE LFAMJEMPOAL, [OLOAAHJODHH(null)][NotNull] CNAMMMNFFBJ<KeepsakesConfig.KeepsakesOptions> LHBNHKOPIFM, [NotNull][OLOAAHJODHH(null)] EILEDNOBBBM BMDDNKKDAIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x8101D10", Offset = "0x8100B10", VA = "0x188101D10", Slot = "15")]
	public bool BGPBHHHFMJI(List<string> AOBEHHFIPOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x8101170", Offset = "0x80FFF70", VA = "0x188101170", Slot = "16")]
	public CEBCBDBEPBJ<Guid> APJPCOPPGOI(MMIEHDFJNAE OFJECDIDCNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x8102DC0", Offset = "0x8101BC0", VA = "0x188102DC0", Slot = "17")]
	public IDGEJBLICGP DGGAILDLADA(Guid OEDJPEFAHHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x8104110", Offset = "0x8102F10", VA = "0x188104110", Slot = "18")]
	public IDGEJBLICGP FEGIEIIAFPL(Guid OEDJPEFAHHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x81081E0", Offset = "0x8106FE0", VA = "0x1881081E0", Slot = "19")]
	public bool KBMKNLLHLKH(Guid OEDJPEFAHHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x810AE60", Offset = "0x8109C60", VA = "0x18810AE60", Slot = "20")]
	public bool OBFCDCIHBAI(Guid OEDJPEFAHHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x8101FA0", Offset = "0x8100DA0", VA = "0x188101FA0")]
	public KeepsakeTheme BHDMDOONKHF(Guid OEDJPEFAHHO)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x8108510", Offset = "0x8107310", VA = "0x188108510")]
	public bool KPKCMHAKGGG(MMIEHDFJNAE OFJECDIDCNG, [Out] KeepsakeTheme AKBCBFKBAJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x8104CB0", Offset = "0x8103AB0", VA = "0x188104CB0")]
	public List<KeepsakeTheme> GDILMBGIEBG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x8102C40", Offset = "0x8101A40", VA = "0x188102C40")]
	public int DFHFFPBAOHC(MMIEHDFJNAE OFJECDIDCNG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x810B970", Offset = "0x810A770", VA = "0x18810B970")]
	public MMIEHDFJNAE PAFDPNCAIJB(Guid OEDJPEFAHHO)
	{
		return default(MMIEHDFJNAE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x810A570", Offset = "0x8109370", VA = "0x18810A570", Slot = "34")]
	public List<MMIEHDFJNAE> NNPAFILKLDI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x810AA10", Offset = "0x8109810", VA = "0x18810AA10", Slot = "35")]
	public IComparer<MMIEHDFJNAE> OALEINMHFFF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x810BBC0", Offset = "0x810A9C0", VA = "0x18810BBC0", Slot = "32")]
	public string PHAMHFPDFPF(MMIEHDFJNAE OFJECDIDCNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x8105990", Offset = "0x8104790", VA = "0x188105990", Slot = "33")]
	public string GILIFPAPCIP(MMIEHDFJNAE OFJECDIDCNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x810AE90", Offset = "0x8109C90", VA = "0x18810AE90", Slot = "21")]
	public bool OCMBLMNCFNN(Guid OEDJPEFAHHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x8106490", Offset = "0x8105290", VA = "0x188106490", Slot = "22")]
	public void HFIHGEPMHBG(Guid OEDJPEFAHHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x8104C60", Offset = "0x8103A60", VA = "0x188104C60", Slot = "23")]
	public void GCFGDCCJFAN(MMIEHDFJNAE OFJECDIDCNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x8103040", Offset = "0x8101E40", VA = "0x188103040", Slot = "24")]
	public void DIMELFKIMBH(Guid OEDJPEFAHHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x8108C90", Offset = "0x8107A90", VA = "0x188108C90", Slot = "25")]
	public int LPJBIOAHGJC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x8103B30", Offset = "0x8102930", VA = "0x188103B30", Slot = "31")]
	public CEBCBDBEPBJ<IEnumerable<Guid>> EMLMLKGDBOD(long NCGHDDJNJOM, long BJAMPOPKJDH, MMIEHDFJNAE? OFJECDIDCNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x8105110", Offset = "0x8103F10", VA = "0x188105110", Slot = "30")]
	public CEBCBDBEPBJ<IEnumerable<Guid>> GHBKBNFGDCA(long NCGHDDJNJOM, long BJAMPOPKJDH, MMIEHDFJNAE? OFJECDIDCNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x81096E0", Offset = "0x81084E0", VA = "0x1881096E0", Slot = "54")]
	public CEBCBDBEPBJ<Dictionary<Guid, MMIEHDFJNAE>> MLKDMPJGHFK(long NCGHDDJNJOM, long BJAMPOPKJDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x81052B0", Offset = "0x81040B0", VA = "0x1881052B0", Slot = "55")]
	public CEBCBDBEPBJ<Dictionary<Guid, MMIEHDFJNAE>> GHFBONCNEOL(long NCGHDDJNJOM, long BJAMPOPKJDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x8103890", Offset = "0x8102690", VA = "0x188103890", Slot = "26")]
	public CEBCBDBEPBJ<int> ECIFEHOMGMM(long NCGHDDJNJOM, long BJAMPOPKJDH, MMIEHDFJNAE? OFJECDIDCNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x8102AE0", Offset = "0x81018E0", VA = "0x188102AE0", Slot = "27")]
	public CEBCBDBEPBJ<int> DBNINMBKAKL(long NCGHDDJNJOM, long BJAMPOPKJDH, MMIEHDFJNAE? OFJECDIDCNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x81086F0", Offset = "0x81074F0", VA = "0x1881086F0", Slot = "28")]
	public CEBCBDBEPBJ<Dictionary<MMIEHDFJNAE, int>> LAAAFIAMPIF(long NCGHDDJNJOM, long BJAMPOPKJDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x8100DF0", Offset = "0x80FFBF0", VA = "0x188100DF0", Slot = "29")]
	public CEBCBDBEPBJ<Dictionary<MMIEHDFJNAE, int>> ANGIAMNKJPI(long NCGHDDJNJOM, long BJAMPOPKJDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x8107E40", Offset = "0x8106C40", VA = "0x188107E40", Slot = "37")]
	public bool JPECPGLBIGE(long NCGHDDJNJOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x810B210", Offset = "0x810A010", VA = "0x18810B210", Slot = "56")]
	public bool OJLFLABPNJM(long NCGHDDJNJOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x8109640", Offset = "0x8108440", VA = "0x188109640", Slot = "38")]
	public bool MKGGECNOAMG(long NCGHDDJNJOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x8101960", Offset = "0x8100760", VA = "0x188101960", Slot = "57")]
	public bool BGHJBDOGHNI(long NCGHDDJNJOM, [Out] JAJGNDNFELM DENCOCAABLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x8108A30", Offset = "0x8107830", VA = "0x188108A30", Slot = "39")]
	public bool LEKNNGBKDFJ(long HLOIPPJIGHA, [Out] DateTime CDLCGHHBLDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x81007B0", Offset = "0x80FF5B0", VA = "0x1881007B0", Slot = "40")]
	public long AEPMMGOECPL(long HLOIPPJIGHA)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x8105BB0", Offset = "0x81049B0", VA = "0x188105BB0", Slot = "41")]
	public long GOEOCIOMDEA(long NCGHDDJNJOM)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x8106EF0", Offset = "0x8105CF0", VA = "0x188106EF0", Slot = "42")]
	public int HMOEKJKDACL(long HLOIPPJIGHA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x8102210", Offset = "0x8101010", VA = "0x188102210", Slot = "43")]
	public bool CCBCLHEDNPD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x810B7E0", Offset = "0x810A5E0", VA = "0x18810B7E0", Slot = "44")]
	public bool PAFBBMFDBMB(long HLOIPPJIGHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x8105440", Offset = "0x8104240", VA = "0x188105440", Slot = "45")]
	public IReadOnlyList<long> GICEGPHNPKP(long HLOIPPJIGHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x81023D0", Offset = "0x81011D0", VA = "0x1881023D0", Slot = "46")]
	public int CHOEIBEEJMC(long HLOIPPJIGHA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x8100EB0", Offset = "0x80FFCB0", VA = "0x188100EB0", Slot = "50")]
	public long AOFBGDMKKEM(long FOMLNCDPKBJ)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x8106500", Offset = "0x8105300", VA = "0x188106500", Slot = "51")]
	public MMIEHDFJNAE HIBNIDIMHHP()
	{
		return default(MMIEHDFJNAE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x810C0E0", Offset = "0x810AEE0", VA = "0x18810C0E0")]
	private bool PIOIGMLKKNO(Guid OEDJPEFAHHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x810B270", Offset = "0x810A070", VA = "0x18810B270")]
	private void OJMELBCPCME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x810AAD0", Offset = "0x81098D0", VA = "0x18810AAD0")]
	private MMIEHDFJNAE OALGPPEMBCE()
	{
		return default(MMIEHDFJNAE);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x8104620", Offset = "0x8103420", VA = "0x188104620")]
	private void FHOMAHFFKCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x8107230", Offset = "0x8106030", VA = "0x188107230")]
	private int IDNCIFPHBMB(KeepsakeRoomListDTO MAIEEMFDMMO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x8100CF0", Offset = "0x80FFAF0", VA = "0x188100CF0")]
	private int AJJPAFIDKJK(DateTime HNIHDIPCPEC, DateTime BKODOINHLOI, TimeSpan ENMOHHLIACI, int GOJOKGDKADG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x81093B0", Offset = "0x81081B0", VA = "0x1881093B0")]
	private void MKDOIIIBFEK(IEnumerable<KeepsakeInstanceDTO> HKKGCPMGCIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x81073D0", Offset = "0x81061D0", VA = "0x1881073D0")]
	private void IEHKDPMGKMD(IEnumerable<KeepsakeCollectionRecordDTO> KLENKLOMKCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x81040B0", Offset = "0x8102EB0", VA = "0x1881040B0")]
	private void FDNHMLCGLNJ(IEnumerable<long> IOPFIGGFKNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0xB1D8B0", Offset = "0xB1C6B0", VA = "0x180B1D8B0")]
	private void JJKANCKIMFL(KeepsakeGlobalConfigDTO DNHKPIBNHJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x81024A0", Offset = "0x81012A0", VA = "0x1881024A0")]
	private bool CNCPEANGNLE(MMIEHDFJNAE OFJECDIDCNG, [Out] Guid LFOKFHDIJDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x810B740", Offset = "0x810A540", VA = "0x18810B740")]
	private bool ONOHJHCADAO([Out] Guid LFOKFHDIJDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x81070D0", Offset = "0x8105ED0", VA = "0x1881070D0")]
	private bool HPJMNAPMDPJ(Guid OEDJPEFAHHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x8103280", Offset = "0x8102080", VA = "0x188103280")]
	private IEnumerable<Guid> DLKNMOLBBJN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x8108900", Offset = "0x8107700", VA = "0x188108900")]
	private IEnumerable<KeepsakeInstanceDTO> LAPBHPBBBIA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x8109320", Offset = "0x8108120", VA = "0x188109320")]
	private void MIOPMMCMINC(Guid OEDJPEFAHHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x8105060", Offset = "0x8103E60", VA = "0x188105060")]
	private bool GEJCNBKCHCG(Guid OEDJPEFAHHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x8107C50", Offset = "0x8106A50", VA = "0x188107C50")]
	private void JDKKCNODCIF(Guid OEDJPEFAHHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x8107130", Offset = "0x8105F30", VA = "0x188107130")]
	private void IADHDEHGCMA(MMIEHDFJNAE INDDHEPFNIF, int CGHPGNAOOBN, Dictionary<MMIEHDFJNAE, int> AAAFHLJGHFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x810BAD0", Offset = "0x810A8D0", VA = "0x18810BAD0")]
	private int PEDHDGKFEKI(MMIEHDFJNAE OFJECDIDCNG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x8108340", Offset = "0x8107140", VA = "0x188108340")]
	private void KFPJNKBJION(KeepsakeInstanceDTO KKNGGHABIIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x8107EA0", Offset = "0x8106CA0", VA = "0x188107EA0")]
	private void KAOGBKDLHGC(KeepsakeInstanceDTO KKNGGHABIIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x8102710", Offset = "0x8101510", VA = "0x188102710")]
	private void DBCIJCLKJGE(Guid OEDJPEFAHHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x8103860", Offset = "0x8102660", VA = "0x188103860")]
	private void EANCBKGKNFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x8102480", Offset = "0x8101280", VA = "0x188102480")]
	private void CJEFMBCEHHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x81089C0", Offset = "0x81077C0", VA = "0x1881089C0")]
	private void LBOGCDJOLFK(GOPOOGGIALC PIEALDOIJLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x8103860", Offset = "0x8102660", VA = "0x188103860")]
	private void HDAPBAOOMMD(DBNOPPMLBPG MKPNGAKJFMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x8103860", Offset = "0x8102660", VA = "0x188103860")]
	private void FIJGFPIBPDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x810BD40", Offset = "0x810AB40", VA = "0x18810BD40")]
	private void PHMNMONBKFI(float KJLNCNCOPDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x8106890", Offset = "0x8105690", VA = "0x188106890")]
	private void HKBPKGMBPAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x8109A90", Offset = "0x8108890", VA = "0x188109A90")]
	private bool MPFIHENEMEH(Guid OEDJPEFAHHO, [Out] string OLKHBHBPNOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x8103EE0", Offset = "0x8102CE0", VA = "0x188103EE0")]
	private bool EPDHHOHLJIE(Guid OEDJPEFAHHO, [Out] KeepsakeCategoryConfigDTO INDDHEPFNIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x81022F0", Offset = "0x81010F0", VA = "0x1881022F0")]
	private void CGKPIIOAKKO(string LDPPBDJBBPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x810A1B0", Offset = "0x8108FB0", VA = "0x18810A1B0")]
	private bool NFCAAGHHLHL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x81056B0", Offset = "0x81044B0", VA = "0x1881056B0")]
	private List<long> GILCGMAEBPL(IEnumerable<KeepsakeRoomDTO> BHINOMEBCMF, IReadOnlyList<KeepsakeRoomListDTO> NODMKEDFKDM, long HLOIPPJIGHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x8109C90", Offset = "0x8108A90", VA = "0x188109C90")]
	private bool NECAOBCNEMC(Guid OEDJPEFAHHO, [Out] string BKBLOMKNEFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x810C210", Offset = "0x810B010", VA = "0x18810C210", Slot = "47")]
	public string PNBNKCHJLOH(OPJPBJBNHPN IGFDJGINPPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x8107700", Offset = "0x8106500", VA = "0x188107700", Slot = "49")]
	public string IGKMJJIGCEP(OPJPBJBNHPN IGFDJGINPPO, long NCGHDDJNJOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x8107620", Offset = "0x8106420", VA = "0x188107620", Slot = "48")]
	public string IFEPKGENMGP(OPJPBJBNHPN IGFDJGINPPO, int ANECGKMLMFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x810C270", Offset = "0x810B070", VA = "0x18810C270")]
	private void PNMNNJLAAFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x8106300", Offset = "0x8105100", VA = "0x188106300")]
	private void HFIGKNNPFJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x81033E0", Offset = "0x81021E0", VA = "0x1881033E0")]
	private OPJPBJBNHPN DNAJLCBDIDI(JNCBCEICIPM DILDMCPDKCF)
	{
		return default(OPJPBJBNHPN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x8106870", Offset = "0x8105670", VA = "0x188106870")]
	private OPJPBJBNHPN HIKFLFJKHGB(JNCBCEICIPM DILDMCPDKCF)
	{
		return default(OPJPBJBNHPN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x8101780", Offset = "0x8100580", VA = "0x188101780")]
	internal static string BGFKLOIKFIO(HMDHBLPJBHH OOMHGCGFMGO, string NPIFGBJCOEP, bool POLHHDDKDBK, int IDDGKJOIIIH, int AMHDPNJCPNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x8103400", Offset = "0x8102200", VA = "0x188103400", Slot = "52")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x8108C10", Offset = "0x8107A10", VA = "0x188108C10")]
	private PPJMMNMCCIA LNHDIBPHKJI(CDKFIILELLC FMBEIGMGJCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x8109160", Offset = "0x8107F60", VA = "0x188109160")]
	private JKDIEKHIAPL MHGKGHAGIKM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x8105E30", Offset = "0x8104C30", VA = "0x188105E30")]
	private Task HELBADCGLLN(EIPHABKKBFG ENDEOBGIMGA, CancellationToken HIMDFBHMPLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x81061F0", Offset = "0x8104FF0", VA = "0x1881061F0")]
	[AsyncStateMachine(typeof(KINPEAEAAOK))]
	private Task HFGNKOEFNIF(EIPHABKKBFG ENDEOBGIMGA, CancellationToken HIMDFBHMPLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x810A6C0", Offset = "0x81094C0", VA = "0x18810A6C0")]
	private Task NOAGJGFDJFO(EIPHABKKBFG ENDEOBGIMGA, CancellationToken HIMDFBHMPLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x81020E0", Offset = "0x8100EE0", VA = "0x1881020E0")]
	[AsyncStateMachine(typeof(LENGLHLNGKH))]
	private Task BOHEMCNEMGL(string IIHOFBLPONF, TimeSpan HLKBKNPIPFF, CancellationToken HIMDFBHMPLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x810B1F0", Offset = "0x8109FF0", VA = "0x18810B1F0")]
	[CompilerGenerated]
	private void OIDJGIHOGLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x810A520", Offset = "0x8109320", VA = "0x18810A520")]
	[CompilerGenerated]
	private void NIMLFICNJKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x810A7A0", Offset = "0x81095A0", VA = "0x18810A7A0")]
	[CompilerGenerated]
	private bool NONDACKKOIO(KeepsakeInstanceDTO DHOMBGCEEAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x8105CC0", Offset = "0x8104AC0", VA = "0x188105CC0")]
	[CompilerGenerated]
	private CEBCBDBEPBJ<Dictionary<MMIEHDFJNAE, int>> HDDKKEKEADF(Dictionary<Guid, MMIEHDFJNAE> IOMANKDCNDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x810A8A0", Offset = "0x81096A0", VA = "0x18810A8A0")]
	[CompilerGenerated]
	private CEBCBDBEPBJ<Dictionary<MMIEHDFJNAE, int>> NOOBBHPJLEL(Dictionary<Guid, MMIEHDFJNAE> IOMANKDCNDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x8107210", Offset = "0x8106010", VA = "0x188107210")]
	[CompilerGenerated]
	private bool ICNFPEGAICD(KeepsakeRoomListDTO DHOMBGCEEAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x81080B0", Offset = "0x8106EB0", VA = "0x1881080B0")]
	[CompilerGenerated]
	private bool KBIHJCKIPPO(KeepsakeInstanceDTO DHOMBGCEEAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x8104490", Offset = "0x8103290", VA = "0x188104490")]
	[CompilerGenerated]
	private void FFMNEHPOJHB(Tuple<KeepsakeRoomInstancesDTO, IReadOnlyDictionary<MMIEHDFJNAE, KeepsakeCategoryConfigDTO>, KeepsakeGlobalConfigDTO> NFMOHCFHBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x8107B20", Offset = "0x8106920", VA = "0x188107B20")]
	[CompilerGenerated]
	private void IIHLBNMKKFF(string BKBLOMKNEFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x810A360", Offset = "0x8109160", VA = "0x18810A360")]
	[CompilerGenerated]
	private Task NHLLGLMKCGD(CancellationToken MFAHGIJOPAO)
	{
		return null;
	}
}
namespace RecRoom.Keepsakes
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public class KeepsakesConfig : ScriptableObject, CNAMMMNFFBJ<KeepsakesConfig.KeepsakesOptions>
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200002B")]
		public class KeepsakesOptions
		{
			[Cpp2IlInjected.Token(Token = "0x200002C")]
			[CompilerGenerated]
			private sealed class JDBGAOAEEII
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000098")]
				public string themeId;

				[Cpp2IlInjected.Token(Token = "0x60000F3")]
				[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
				public JDBGAOAEEII()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000F4")]
				[Cpp2IlInjected.Address(RVA = "0x810EBE0", Offset = "0x810D9E0", VA = "0x18810EBE0")]
				internal bool IODPMLNGHPJ(KeepsakeTheme x)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60000F5")]
				[Cpp2IlInjected.Address(RVA = "0x810EBE0", Offset = "0x810D9E0", VA = "0x18810EBE0")]
				internal bool MGFFNMFGBCF(KeepsakeTheme x)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			[SerializeField]
			private KeepsakeTheme[] themes;

			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x810FBB0", Offset = "0x810E9B0", VA = "0x18810FBB0")]
			public bool KHMMJNBDNHP(string IKEHNNDDOCO, [Out] KeepsakeTheme AKBCBFKBAJI)
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
			[Cpp2IlInjected.Address(RVA = "0xA59870", Offset = "0xA58670", VA = "0x180A59870", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x810FB30", Offset = "0x810E930", VA = "0x18810FB30")]
		[ONLJNMLDJBD.KDDDMPKOLFO.GACHHHHOLBP]
		internal static void KEKMDAEKNFP(LOAHJOOKLEP CHDHLAGMCKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0xCC5E40", Offset = "0xCC4C40", VA = "0x180CC5E40")]
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
