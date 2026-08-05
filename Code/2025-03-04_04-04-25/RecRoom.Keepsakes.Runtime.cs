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
		[Cpp2IlInjected.Address(RVA = "0x754FF40", Offset = "0x754E540", VA = "0x18754FF40", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x245DCB0", Offset = "0x245C2B0", VA = "0x18245DCB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public GABGPMPKNOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xB8F210", Offset = "0xB8D810", VA = "0x180B8F210")]
		internal bool BBHEJLGAAEB(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x1C4F030", Offset = "0x1C4D630", VA = "0x181C4F030")]
		internal bool MMPCNPGINOF(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xB8F210", Offset = "0xB8D810", VA = "0x180B8F210")]
		internal bool LKMNMCMAEIJ(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1C4F030", Offset = "0x1C4D630", VA = "0x181C4F030")]
		internal bool BKEGOEJOCPK(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private List<KeepsakeCategoryThemePair> NMMHNGNEGJN;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x958BA0", Offset = "0x9571A0", VA = "0x180958BA0")]
	public MFGNMNHPKHE(List<KeepsakeCategoryThemePair> PGKIJFKCKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x754F8A0", Offset = "0x754DEA0", VA = "0x18754F8A0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public MEGNNOKHOEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x754F150", Offset = "0x754D750", VA = "0x18754F150")]
		internal NEEPBAPEEOL<Guid> ENBNBJFBKEH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x754F2E0", Offset = "0x754D8E0", VA = "0x18754F2E0")]
		internal void NPNHCGBBCEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x754F0F0", Offset = "0x754D6F0", VA = "0x18754F0F0")]
		internal void DFGKMIGNMKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x754ECE0", Offset = "0x754D2E0", VA = "0x18754ECE0")]
		internal void CBHPAIBJNAB(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x754F2B0", Offset = "0x754D8B0", VA = "0x18754F2B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public DAOGIAEEEAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x753F110", Offset = "0x753D710", VA = "0x18753F110")]
		internal void HJEFBIPKHGA(GPHBDLOMFBC response)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x753F0B0", Offset = "0x753D6B0", VA = "0x18753F0B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public ECPDJOFIPDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x753F690", Offset = "0x753DC90", VA = "0x18753F690")]
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
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public IFKHCMCFPLJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x754E4F0", Offset = "0x754CAF0", VA = "0x18754E4F0")]
		internal void ICHKDIHMHME(KeepsakeProgressionEventInstancesDTO result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x75400D0", Offset = "0x753E6D0", VA = "0x1875400D0")]
		internal void PPMIDJECJBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x754E580", Offset = "0x754CB80", VA = "0x18754E580")]
		internal NEEPBAPEEOL<IEnumerable<Guid>> MPINMAGFICJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x70D75F0", Offset = "0x70D5BF0", VA = "0x1870D75F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public FNJDLHHKBLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x753FC10", Offset = "0x753E210", VA = "0x18753FC10")]
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
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public FHFFMHLAGAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x753FAE0", Offset = "0x753E0E0", VA = "0x18753FAE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public BGJOHBKGKPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x753ED90", Offset = "0x753D390", VA = "0x18753ED90")]
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
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public AALBLBPHFGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x753E9D0", Offset = "0x753CFD0", VA = "0x18753E9D0")]
		internal NEEPBAPEEOL<IEnumerable<Guid>> BMFANFKJLAO(IEnumerable<Guid> instanceIds)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x753EB40", Offset = "0x753D140", VA = "0x18753EB40")]
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
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public HKDLJDGFMAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x75403F0", Offset = "0x753E9F0", VA = "0x1875403F0")]
		internal void OIAFIKJFINH(KeepsakeProgressionEventInstancesDTO result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x75400D0", Offset = "0x753E6D0", VA = "0x1875400D0")]
		internal void BGLHNCADNBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x7540100", Offset = "0x753E700", VA = "0x187540100")]
		internal NEEPBAPEEOL<Dictionary<Guid, MAIAFFCEMDA>> INAJPCJMDFL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x70D75F0", Offset = "0x70D5BF0", VA = "0x1870D75F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public EPLAJKBJPMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x753F6B0", Offset = "0x753DCB0", VA = "0x18753F6B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public BCBFPAJJPDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x753ECB0", Offset = "0x753D2B0", VA = "0x18753ECB0")]
		internal bool MNMCMCHIBNA(Guid instanceId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x753EB60", Offset = "0x753D160", VA = "0x18753EB60")]
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
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public DCKDMNLGNAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x2246DF0", Offset = "0x22453F0", VA = "0x182246DF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public IHOMNNKLDON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x2246DF0", Offset = "0x22453F0", VA = "0x182246DF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public FDFMPHCDIBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x753F8E0", Offset = "0x753DEE0", VA = "0x18753F8E0")]
		internal NEEPBAPEEOL<Dictionary<Guid, MAIAFFCEMDA>> JJKBCJCGNLK(Dictionary<Guid, MAIAFFCEMDA> instanceIdsAndCategories)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x753EB40", Offset = "0x753D140", VA = "0x18753EB40")]
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
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public OAFIIIPINJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x754FC40", Offset = "0x754E240", VA = "0x18754FC40")]
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
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public JKFCCCNJFAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x754E880", Offset = "0x754CE80", VA = "0x18754E880")]
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
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public FKBELDFFOFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0xC92E70", Offset = "0xC91470", VA = "0x180C92E70")]
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
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public CFNCKHAFJDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x753EF60", Offset = "0x753D560", VA = "0x18753EF60")]
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
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public KOIGLEFEOAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0xC92E70", Offset = "0xC91470", VA = "0x180C92E70")]
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
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public DFBPKBIJDMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x753F5A0", Offset = "0x753DBA0", VA = "0x18753F5A0")]
		internal bool MBGKMHDJLCD(DateTime nowUtc, DateTime eventStartTime, int roomOrder, TimeSpan unlockStartOffset, TimeSpan unlockInterval, int unlockBatchSize)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x753F4C0", Offset = "0x753DAC0", VA = "0x18753F4C0")]
		internal bool DEDDHHMCKLG(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x753F580", Offset = "0x753DB80", VA = "0x18753F580")]
		internal bool LBNIJELAPDC(KeepsakeRoomDTO r)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x753F580", Offset = "0x753DB80", VA = "0x18753F580")]
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
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public AEDFJHJDOPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0xCFA4F0", Offset = "0xCF8AF0", VA = "0x180CFA4F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public BIGNAAHJPCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x753EEA0", Offset = "0x753D4A0", VA = "0x18753EEA0")]
		internal bool KAOGHNBCKLF(KeepsakeRoomListDTO roomList)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x220D3C0", Offset = "0x220B9C0", VA = "0x18220D3C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public BHBMFHLEPFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x753EE40", Offset = "0x753D440", VA = "0x18753EE40")]
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
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public NBEICIHPEKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0xCFA4F0", Offset = "0xCF8AF0", VA = "0x180CFA4F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public GFHOAMNPFAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x753FD50", Offset = "0x753E350", VA = "0x18753FD50")]
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
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public HFBDCKINPAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x1E4CC30", Offset = "0x1E4B230", VA = "0x181E4CC30")]
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
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public PGFCEKMFKAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x754FCC0", Offset = "0x754E2C0", VA = "0x18754FCC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public KOMKHABHCDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x754E9D0", Offset = "0x754CFD0", VA = "0x18754E9D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public DCGENOAHHPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x1E4CC30", Offset = "0x1E4B230", VA = "0x181E4CC30")]
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
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public EPMDNDCDMFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x753F860", Offset = "0x753DE60", VA = "0x18753F860")]
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
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public MNPADGMBFCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x754FB50", Offset = "0x754E150", VA = "0x18754FB50")]
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
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public LHPLDMPMFHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x754EC60", Offset = "0x754D260", VA = "0x18754EC60")]
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
		[Cpp2IlInjected.Address(RVA = "0x754F310", Offset = "0x754D910", VA = "0x18754F310", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x754F840", Offset = "0x754DE40", VA = "0x18754F840", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x753FDB0", Offset = "0x753E3B0", VA = "0x18753FDB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x7540040", Offset = "0x753E640", VA = "0x187540040", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x97F1A0", Offset = "0x97D7A0", VA = "0x18097F1A0", Slot = "53")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x97EF20", Offset = "0x97D520", VA = "0x18097EF20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool LDBACIOFHND
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x75474A0", Offset = "0x7545AA0", VA = "0x1875474A0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool IAALFFAGMII
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7543670", Offset = "0x7541C70", VA = "0x187543670", Slot = "36")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private long ABODGGMBMAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7547360", Offset = "0x7545960", VA = "0x187547360")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private long? MMHCBCMMGLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x754BDC0", Offset = "0x754A3C0", VA = "0x18754BDC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private bool AJMNCPDJNOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7548BB0", Offset = "0x75471B0", VA = "0x187548BB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public IReadOnlyList<KeepsakeRoomListDTO> JDAHJCNPPLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x9C0E20", Offset = "0x9BF420", VA = "0x1809C0E20", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public IReadOnlyList<KeepsakeRoomListDTO> PDBBEJLAJJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x9C1130", Offset = "0x9BF730", VA = "0x1809C1130", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IReadOnlyList<KeepsakeRoomListDTO> BKEODGKHKKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xA2F4C0", Offset = "0xA2DAC0", VA = "0x180A2F4C0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public IReadOnlyDictionary<long, string> LIGCONLAOOO
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x9C0540", Offset = "0x9BEB40", VA = "0x1809C0540", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	internal bool NGPPOEPBCKG
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xA2BD60", Offset = "0xA2A360", VA = "0x180A2BD60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Guid?> PDPBEKKOKMO
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7545BE0", Offset = "0x75441E0", VA = "0x187545BE0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x75430D0", Offset = "0x75416D0", VA = "0x1875430D0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action LAJGPAMLJKP
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7548BC0", Offset = "0x75471C0", VA = "0x187548BC0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7543EB0", Offset = "0x75424B0", VA = "0x187543EB0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action IMKPBFPPJAC
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7543F50", Offset = "0x7542550", VA = "0x187543F50", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7542230", Offset = "0x7540830", VA = "0x187542230", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x754CF20", Offset = "0x754B520", VA = "0x18754CF20")]
	[RecRoom.NoEngine.Common.Preserve]
	internal IACPIHHHCOI([IBJCGEMJMJL(null)][NotNull] GFJFIDGHMOA CKEMIOHGOMD, [NotNull][IBJCGEMJMJL(null)] DMBDJAPHJEC LINBCANIEFD, [NotNull][IBJCGEMJMJL(null)] IGEFIGDGMAI JKPDOMGEHKN, [NotNull][IBJCGEMJMJL(null)] ADCPBBIAOCH BCAIDBPILOG, [IBJCGEMJMJL(null)][NotNull] KJCONENAPPK HFNIINCGAEG, [IBJCGEMJMJL(null)][NotNull] EKKKCNGJBOO GHFCFJHMPHJ, [IBJCGEMJMJL(null)][NotNull] CIFKNFKILGE OMMKHBGELAA, [NotNull][IBJCGEMJMJL(null)] ENHCOOGKGFN ADFGFLNPGOG, [NotNull][IBJCGEMJMJL(null)] JFIOHCKEEIP MGMCFGLJIGI, [NotNull][IBJCGEMJMJL(null)] LHJPLLHHNOK DPMKKMKPHHH, [NotNull][IBJCGEMJMJL(null)] MLOAEAIKDOJ EDEPPIBHBIF, [NotNull][IBJCGEMJMJL(null)] FGKLOENKHBI HHGBOFOOHDB, [NotNull][IBJCGEMJMJL(null)] CMCKGIJHJHE NJDKDNFLIHG, [NotNull][IBJCGEMJMJL(null)] KLHECNJFMMO AOMNFIDCDEK, [IBJCGEMJMJL(null)][NotNull] OKEMOHPNDNB DCEMBCAMKNJ, [IBJCGEMJMJL(null)][NotNull] CKBCKKNCCCO PENLKINHKAD, [NotNull][IBJCGEMJMJL(null)] CCAOPILOOAO AJLMACGMCAP, [IBJCGEMJMJL(null)][NotNull] BCCJIGCFKHM<KeepsakesConfig.KeepsakesOptions> DCEHMKPFEJH, [NotNull][IBJCGEMJMJL(null)] FIIDOADKEDD MGBNFJALEFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x754BE50", Offset = "0x754A450", VA = "0x18754BE50", Slot = "15")]
	public bool OCCNNMOLCBH(List<string> PLMCLHPCKGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7544C70", Offset = "0x7543270", VA = "0x187544C70", Slot = "16")]
	public NEEPBAPEEOL<Guid> HDCDAFPBCID(MAIAFFCEMDA EALFFCNJEPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7543330", Offset = "0x7541930", VA = "0x187543330", Slot = "17")]
	public HJOKANJAKGB FAEGOKPFOKP(Guid CBCFADAIBAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7545830", Offset = "0x7543E30", VA = "0x187545830", Slot = "18")]
	public HJOKANJAKGB HEHMKNNEGJA(Guid CBCFADAIBAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7548650", Offset = "0x7546C50", VA = "0x187548650", Slot = "19")]
	public bool KKNAALMPOAI(Guid CBCFADAIBAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x754C340", Offset = "0x754A940", VA = "0x18754C340", Slot = "20")]
	public bool OKLODBGBFAL(Guid CBCFADAIBAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x754C7E0", Offset = "0x754ADE0", VA = "0x18754C7E0")]
	public KeepsakeTheme PDFFPALMGIB(Guid CBCFADAIBAF)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x754C370", Offset = "0x754A970", VA = "0x18754C370")]
	public bool OKMCPHPHOBI(MAIAFFCEMDA EALFFCNJEPJ, [Out] KeepsakeTheme KAFMNEBABOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x75416E0", Offset = "0x753FCE0", VA = "0x1875416E0")]
	public List<KeepsakeTheme> DCNHIMMFENL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7547A30", Offset = "0x7546030", VA = "0x187547A30")]
	public int KCAPDHMGDAI(MAIAFFCEMDA EALFFCNJEPJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7541520", Offset = "0x753FB20", VA = "0x187541520")]
	public MAIAFFCEMDA CNIKIKAGIAL(Guid CBCFADAIBAF)
	{
		return default(MAIAFFCEMDA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7542690", Offset = "0x7540C90", VA = "0x187542690", Slot = "34")]
	public List<MAIAFFCEMDA> DPGODPFNMHF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x754C280", Offset = "0x754A880", VA = "0x18754C280", Slot = "35")]
	public IComparer<MAIAFFCEMDA> OIAFJGAHLCJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x754C550", Offset = "0x754AB50", VA = "0x18754C550", Slot = "32")]
	public string OOEJNGOEPFD(MAIAFFCEMDA EALFFCNJEPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x75471E0", Offset = "0x75457E0", VA = "0x1875471E0", Slot = "33")]
	public string IPKPKEBGNJH(MAIAFFCEMDA EALFFCNJEPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7546730", Offset = "0x7544D30", VA = "0x187546730", Slot = "21")]
	public bool IBCPHAPFJLO(Guid CBCFADAIBAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7543FF0", Offset = "0x75425F0", VA = "0x187543FF0", Slot = "22")]
	public void GGKLEABLGKL(Guid CBCFADAIBAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7546AB0", Offset = "0x75450B0", VA = "0x187546AB0", Slot = "23")]
	public void IGPCHGKBELD(MAIAFFCEMDA EALFFCNJEPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7548410", Offset = "0x7546A10", VA = "0x187548410", Slot = "24")]
	public void KKLJJPNKEDA(Guid CBCFADAIBAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x75443E0", Offset = "0x75429E0", VA = "0x1875443E0", Slot = "25")]
	public int GNNGDGIMMFA()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x75422D0", Offset = "0x75408D0", VA = "0x1875422D0", Slot = "31")]
	public NEEPBAPEEOL<IEnumerable<Guid>> DOFGGPLGLBD(long FFFLOIOFAMB, long ECHBAPBKGNC, MAIAFFCEMDA? EALFFCNJEPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7547040", Offset = "0x7545640", VA = "0x187547040", Slot = "30")]
	public NEEPBAPEEOL<IEnumerable<Guid>> IOMJIMDFPHP(long FFFLOIOFAMB, long ECHBAPBKGNC, MAIAFFCEMDA? EALFFCNJEPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x75439F0", Offset = "0x7541FF0", VA = "0x1875439F0", Slot = "54")]
	public NEEPBAPEEOL<Dictionary<Guid, MAIAFFCEMDA>> GAMLIKMJJCO(long FFFLOIOFAMB, long ECHBAPBKGNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7546540", Offset = "0x7544B40", VA = "0x187546540", Slot = "55")]
	public NEEPBAPEEOL<Dictionary<Guid, MAIAFFCEMDA>> HNPIMCCOOEJ(long FFFLOIOFAMB, long ECHBAPBKGNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x754BA70", Offset = "0x754A070", VA = "0x18754BA70", Slot = "26")]
	public NEEPBAPEEOL<int> NLLAJGEJEHC(long FFFLOIOFAMB, long ECHBAPBKGNC, MAIAFFCEMDA? EALFFCNJEPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7546EE0", Offset = "0x75454E0", VA = "0x187546EE0", Slot = "27")]
	public NEEPBAPEEOL<int> IJOMEOOBCKO(long FFFLOIOFAMB, long ECHBAPBKGNC, MAIAFFCEMDA? EALFFCNJEPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x75408F0", Offset = "0x753EEF0", VA = "0x1875408F0", Slot = "28")]
	public NEEPBAPEEOL<Dictionary<MAIAFFCEMDA, int>> BJECIEFEGFE(long FFFLOIOFAMB, long ECHBAPBKGNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x75435B0", Offset = "0x7541BB0", VA = "0x1875435B0", Slot = "29")]
	public NEEPBAPEEOL<Dictionary<MAIAFFCEMDA, int>> FDHEMHBDDLC(long FFFLOIOFAMB, long ECHBAPBKGNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7541680", Offset = "0x753FC80", VA = "0x187541680", Slot = "37")]
	public bool DAGNOCENJMM(long FFFLOIOFAMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7542C40", Offset = "0x7541240", VA = "0x187542C40", Slot = "56")]
	public bool EDIBDKOCBDA(long FFFLOIOFAMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x754BD20", Offset = "0x754A320", VA = "0x18754BD20", Slot = "38")]
	public bool NLMAPJBNCMG(long FFFLOIOFAMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x754AEF0", Offset = "0x75494F0", VA = "0x18754AEF0", Slot = "57")]
	public bool MKCCPGHEOHF(long FFFLOIOFAMB, [Out] EBPFFGDIFFM FKKNFCGKGEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7546B00", Offset = "0x7545100", VA = "0x187546B00", Slot = "39")]
	public bool IHBFGIIFIBL(long ICPGCFKAGBA, [Out] DateTime FJAPCIHJEHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x75474F0", Offset = "0x7545AF0", VA = "0x1875474F0", Slot = "40")]
	public long JOBCAOKJGNE(long ICPGCFKAGBA)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7543DA0", Offset = "0x75423A0", VA = "0x187543DA0", Slot = "41")]
	public long GCHFCILHOIM(long FFFLOIOFAMB)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7540480", Offset = "0x753EA80", VA = "0x187540480", Slot = "42")]
	public int AAHFHLNBBKK(long ICPGCFKAGBA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x75469D0", Offset = "0x7544FD0", VA = "0x1875469D0", Slot = "43")]
	public bool IDPMKEGPOGK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x7544AE0", Offset = "0x75430E0", VA = "0x187544AE0", Slot = "44")]
	public bool HCBBPJBOGHD(long ICPGCFKAGBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7547D50", Offset = "0x7546350", VA = "0x187547D50", Slot = "45")]
	public IReadOnlyList<long> KGNJAOAKMIF(long ICPGCFKAGBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7548890", Offset = "0x7546E90", VA = "0x187548890", Slot = "46")]
	public int KPGBJNONMBL(long ICPGCFKAGBA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x754B350", Offset = "0x7549950", VA = "0x18754B350", Slot = "50")]
	public long NGEIDKAECHO(long MFJNOLFGAKE)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7548C60", Offset = "0x7547260", VA = "0x187548C60", Slot = "51")]
	public MAIAFFCEMDA LHGFJKMGEGB()
	{
		return default(MAIAFFCEMDA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7540660", Offset = "0x753EC60", VA = "0x187540660")]
	private bool AECHODJBBBC(Guid CBCFADAIBAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7545EB0", Offset = "0x75444B0", VA = "0x187545EB0")]
	private void HJOHLPFMGBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7549B30", Offset = "0x7548130", VA = "0x187549B30")]
	private MAIAFFCEMDA MFOOOEPMCJP()
	{
		return default(MAIAFFCEMDA);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7548FD0", Offset = "0x75475D0", VA = "0x187548FD0")]
	private void LKNMLKGIEHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7546D40", Offset = "0x7545340", VA = "0x187546D40")]
	private int IJGPANCNMFK(KeepsakeRoomListDTO JFJPBKAALIP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7544060", Offset = "0x7542660", VA = "0x187544060")]
	private int GHJAMMGDLCB(DateTime CECGJMEMLMP, DateTime FOAGHGNHCNA, TimeSpan DJKGEIJGEPL, int HHCKLEKEOAA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7544820", Offset = "0x7542E20", VA = "0x187544820")]
	private void GOCKBGHICBE(IEnumerable<KeepsakeInstanceDTO> IOGMLEMBKHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7540D10", Offset = "0x753F310", VA = "0x187540D10")]
	private void BOGFCPIIAAA(IEnumerable<KeepsakeCollectionRecordDTO> MLOAEIPLEOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7543070", Offset = "0x7541670", VA = "0x187543070")]
	private void EENKGEMDIFH(IEnumerable<long> OIPLPAJBBFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x109D6C0", Offset = "0x109BCC0", VA = "0x18109D6C0")]
	private void IEGOEIIDNPH(KeepsakeGlobalConfigDTO PHMMNNJJCCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7548940", Offset = "0x7546F40", VA = "0x187548940")]
	private bool LAMEICJCPJJ(MAIAFFCEMDA EALFFCNJEPJ, [Out] Guid GLLDKBLLCKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7543860", Offset = "0x7541E60", VA = "0x187543860")]
	private bool FNBGLKEPPGE([Out] Guid GLLDKBLLCKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x75412C0", Offset = "0x753F8C0", VA = "0x1875412C0")]
	private bool CFIMJGIONJG(Guid CBCFADAIBAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x7540790", Offset = "0x753ED90", VA = "0x187540790")]
	private IEnumerable<Guid> AMDJFOLBIFF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x754C0E0", Offset = "0x754A6E0", VA = "0x18754C0E0")]
	private IEnumerable<KeepsakeInstanceDTO> OEGJHEILJBO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x754B2C0", Offset = "0x75498C0", VA = "0x18754B2C0")]
	private void NFKIMMOFBMA(Guid CBCFADAIBAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7548360", Offset = "0x7546960", VA = "0x187548360")]
	private bool KJKLOOPGGHL(Guid CBCFADAIBAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7547BB0", Offset = "0x75461B0", VA = "0x187547BB0")]
	private void KFKDHIMBIOJ(Guid CBCFADAIBAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x754C1A0", Offset = "0x754A7A0", VA = "0x18754C1A0")]
	private void OFEMIMMIIIK(MAIAFFCEMDA AJKIFLFMGBI, int MKOOFCPFHDD, Dictionary<MAIAFFCEMDA, int> AJIMIAGJCFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7543900", Offset = "0x7541F00", VA = "0x187543900")]
	private int FOOJMFKGNOL(MAIAFFCEMDA EALFFCNJEPJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x75410F0", Offset = "0x753F6F0", VA = "0x1875410F0")]
	private void CFBLILIOBEG(KeepsakeInstanceDTO IFFHMJLNINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7540B00", Offset = "0x753F100", VA = "0x187540B00")]
	private void BNIMMKCOKGN(KeepsakeInstanceDTO IFFHMJLNINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7542CA0", Offset = "0x75412A0", VA = "0x187542CA0")]
	private void EENAABGJOJB(Guid CBCFADAIBAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7544AB0", Offset = "0x75430B0", VA = "0x187544AB0")]
	private void JLLAOOLANAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7545BC0", Offset = "0x75441C0", VA = "0x187545BC0")]
	private void HEOKMCELMEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7547430", Offset = "0x7545A30", VA = "0x187547430")]
	private void JKJPMLEFMKA(ONLCNDEELLL EDKKLGLMFKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7544AB0", Offset = "0x75430B0", VA = "0x187544AB0")]
	private void HAKIDMKFNHP(OFJIPMOFMFM GMFKPONAANG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7544AB0", Offset = "0x75430B0", VA = "0x187544AB0")]
	private void IJDPJIPDEGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7547FC0", Offset = "0x75465C0", VA = "0x187547FC0")]
	private void KHDGNDFKPCN(float GJIDBFHGEOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x7545290", Offset = "0x7543890", VA = "0x187545290")]
	private void HDPOAOAHPHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7541320", Offset = "0x753F920", VA = "0x187541320")]
	private bool CHINJIFHCBF(Guid CBCFADAIBAF, [Out] string JNIFLFMIGGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x754CD50", Offset = "0x754B350", VA = "0x18754CD50")]
	private bool POGFKDKPHEF(Guid CBCFADAIBAF, [Out] KeepsakeCategoryConfigDTO AJKIFLFMGBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7542150", Offset = "0x7540750", VA = "0x187542150")]
	private void DKKKKABOGHD(string JGKKKNKIGEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x75442D0", Offset = "0x75428D0", VA = "0x1875442D0")]
	private bool GNIDKNBLGEL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x754C940", Offset = "0x754AF40", VA = "0x18754C940")]
	private List<long> PHHKDHDOCID(IEnumerable<KeepsakeRoomDTO> BPBCOLEPJDB, IReadOnlyList<KeepsakeRoomListDTO> BOKJFJMKBNO, long ICPGCFKAGBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x7549610", Offset = "0x7547C10", VA = "0x187549610")]
	private bool LLHJGCIMDKM(Guid CBCFADAIBAF, [Out] string IFMHONGNKHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7545C90", Offset = "0x7544290", VA = "0x187545C90", Slot = "47")]
	public string HIOFLPHIMLB(PKPEIGLPOOD HBFCLOEJEAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x7541C00", Offset = "0x7540200", VA = "0x187541C00", Slot = "49")]
	public string DGKBBLLEEAO(PKPEIGLPOOD HBFCLOEJEAJ, long FFFLOIOFAMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x75487B0", Offset = "0x7546DB0", VA = "0x1875487B0", Slot = "48")]
	public string KOPCCDNHDIG(PKPEIGLPOOD HBFCLOEJEAJ, int GNLBGJKLMHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x7549E10", Offset = "0x7548410", VA = "0x187549E10")]
	private void MGAMKCGMNKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7540F60", Offset = "0x753F560", VA = "0x187540F60")]
	private void BOOGNDNILOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x754BA50", Offset = "0x754A050", VA = "0x18754BA50")]
	private PKPEIGLPOOD NKPAAENMJGB(LHLHDPGPOJN PGMGMCBDDKM)
	{
		return default(PKPEIGLPOOD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x754B2A0", Offset = "0x75498A0", VA = "0x18754B2A0")]
	private PKPEIGLPOOD NCDFKILCBIO(LHLHDPGPOJN PGMGMCBDDKM)
	{
		return default(PKPEIGLPOOD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x754AD10", Offset = "0x7549310", VA = "0x18754AD10")]
	internal static string MHGFFCHFNEJ(GPHBDLOMFBC GIBMLNMIEIO, string HOHCOKEPABP, bool FMMDLFJAONF, int JCMKOFIEMPK, int DDOFGFJGGEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x75427E0", Offset = "0x7540DE0", VA = "0x1875427E0", Slot = "52")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x754B9D0", Offset = "0x7549FD0", VA = "0x18754B9D0")]
	private GGLMIDJEDGD NJBNNHLCILI(OPHKANJGPPK JHKDFCONLEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7546380", Offset = "0x7544980", VA = "0x187546380")]
	private JKEGNLFNIEK HLIEPBKOEKB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x754B610", Offset = "0x7549C10", VA = "0x18754B610")]
	private Task NHOHFFGDLIA(BPPINHJEEIJ JIEBKPCGKFF, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x754C6D0", Offset = "0x754ACD0", VA = "0x18754C6D0")]
	[AsyncStateMachine(typeof(MEKDIBIHNGM))]
	private Task OPNPMAHJHPB(BPPINHJEEIJ JIEBKPCGKFF, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x754CC20", Offset = "0x754B220", VA = "0x18754CC20")]
	private Task PJLODGCNBBD(BPPINHJEEIJ JIEBKPCGKFF, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7542020", Offset = "0x7540620", VA = "0x187542020")]
	[AsyncStateMachine(typeof(GHGONONANMB))]
	private Task DJHOOIKPMKI(string MIALAMIFNLM, TimeSpan OAKCDHIGPHN, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7543180", Offset = "0x7541780", VA = "0x187543180")]
	[CompilerGenerated]
	private void EOFBCHPNBFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x754CD00", Offset = "0x754B300", VA = "0x18754CD00")]
	[CompilerGenerated]
	private void PNMKIGBEKFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7546C40", Offset = "0x7545240", VA = "0x187546C40")]
	[CompilerGenerated]
	private bool IHPEEJPBKCE(KeepsakeInstanceDTO IKAEODCKAIP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7541A90", Offset = "0x7540090", VA = "0x187541A90")]
	[CompilerGenerated]
	private NEEPBAPEEOL<Dictionary<MAIAFFCEMDA, int>> DFMIOHGMCEM(Dictionary<Guid, MAIAFFCEMDA> NBMBAAHKNKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x7544160", Offset = "0x7542760", VA = "0x187544160")]
	[CompilerGenerated]
	private NEEPBAPEEOL<Dictionary<MAIAFFCEMDA, int>> GHLFBDPFLOI(Dictionary<Guid, MAIAFFCEMDA> NBMBAAHKNKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x754C920", Offset = "0x754AF20", VA = "0x18754C920")]
	[CompilerGenerated]
	private bool PHBNGKBIAAH(KeepsakeRoomListDTO IKAEODCKAIP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7543730", Offset = "0x7541D30", VA = "0x187543730")]
	[CompilerGenerated]
	private bool FFEODHMIIOB(KeepsakeInstanceDTO IKAEODCKAIP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x75431A0", Offset = "0x75417A0", VA = "0x1875431A0")]
	[CompilerGenerated]
	private void EOFKCOGLDLL(Tuple<KeepsakeRoomInstancesDTO, IReadOnlyDictionary<MAIAFFCEMDA, KeepsakeCategoryConfigDTO>, KeepsakeGlobalConfigDTO> JCAJHFICHIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x75466D0", Offset = "0x7544CD0", VA = "0x1875466D0")]
	[CompilerGenerated]
	private void HOJFJPDKIPI(string IFMHONGNKHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x7545CF0", Offset = "0x75442F0", VA = "0x187545CF0")]
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
				[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
				public HFKKJFOIGFN()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000F4")]
				[Cpp2IlInjected.Address(RVA = "0x75400A0", Offset = "0x753E6A0", VA = "0x1875400A0")]
				internal bool DJJLKHHEDCK(KeepsakeTheme x)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60000F5")]
				[Cpp2IlInjected.Address(RVA = "0x75400A0", Offset = "0x753E6A0", VA = "0x1875400A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x754EA90", Offset = "0x754D090", VA = "0x18754EA90")]
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
			[Cpp2IlInjected.Address(RVA = "0x9526B0", Offset = "0x950CB0", VA = "0x1809526B0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x754EA10", Offset = "0x754D010", VA = "0x18754EA10")]
		[HLOHOCOKELO.IDGFAEKKODB.GGCNFHIOHEN]
		internal static void HBMGFBHOMDP(GFKEMDIOCPC MGOKPJKELJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0xA447A0", Offset = "0xA42DA0", VA = "0x180A447A0")]
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
