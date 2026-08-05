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
		[Cpp2IlInjected.Address(RVA = "0x7D9DB70", Offset = "0x7D9C570", VA = "0x187D9DB70", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2796C60", Offset = "0x2795660", VA = "0x182796C60")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class AMAIBNDNCKI : IComparer<JJFPKLGIJNA>
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private sealed class JINAOPEHDEN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public JJFPKLGIJNA x;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public JJFPKLGIJNA y;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public JINAOPEHDEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xD88140", Offset = "0xD86B40", VA = "0x180D88140")]
		internal bool MPGMHMLNJJN(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2007BA0", Offset = "0x20065A0", VA = "0x182007BA0")]
		internal bool ODFIMJDJKNN(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xD88140", Offset = "0xD86B40", VA = "0x180D88140")]
		internal bool GOBDGIHOOMK(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2007BA0", Offset = "0x20065A0", VA = "0x182007BA0")]
		internal bool ODNNGHGIPJF(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private List<KeepsakeCategoryThemePair> DMDGBMNIHPA;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0xA14510", Offset = "0xA12F10", VA = "0x180A14510")]
	public AMAIBNDNCKI(List<KeepsakeCategoryThemePair> BOFCJBCMPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7D8CD30", Offset = "0x7D8B730", VA = "0x187D8CD30", Slot = "4")]
	public int Compare(JJFPKLGIJNA CBPCNABIALH, JJFPKLGIJNA CBOHEKOGGHJ)
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
		public JJFPKLGIJNA KeepsakeCategory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public KeepsakeTheme KeepsakeTheme;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[NHPBPJDIEFG]
public class OJIFKAEGNHA : KDHCIHAIJOA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class MHFDLCAKIBE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public OJIFKAEGNHA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public JJFPKLGIJNA keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public MHFDLCAKIBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7D8F610", Offset = "0x7D8E010", VA = "0x187D8F610")]
		internal MPBOGDMHBIL<Guid> MKKOJECNLED()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7D8F5E0", Offset = "0x7D8DFE0", VA = "0x187D8F5E0")]
		internal void JLJELGIFODK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7D8F580", Offset = "0x7D8DF80", VA = "0x187D8F580")]
		internal void FHOAEGJBPME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7D8F140", Offset = "0x7D8DB40", VA = "0x187D8F140")]
		internal void AFBOLAKFNMF(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7D8F550", Offset = "0x7D8DF50", VA = "0x187D8F550")]
		internal void AFJFFHNAMNA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class JLDOPLOCCBO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public OJIFKAEGNHA <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public JLDOPLOCCBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7D8E020", Offset = "0x7D8CA20", VA = "0x187D8E020")]
		internal void OICNKNECCBH(NBLIJPCCJMG response)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7D8E3D0", Offset = "0x7D8CDD0", VA = "0x187D8E3D0")]
		internal void OPHHELCBEHD(string error)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class HOLPAKKIAGC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public KeepsakeTheme theme;

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public HOLPAKKIAGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x7D8DC80", Offset = "0x7D8C680", VA = "0x187D8DC80")]
		internal bool OKBNCBMCIJG(KeepsakeCategoryThemePair categoryThemePair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class FCEMDDNEMLD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public OJIFKAEGNHA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public long progressionEventId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public JJFPKLGIJNA? keepsakeCategory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public FCEMDDNEMLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x7D8D670", Offset = "0x7D8C070", VA = "0x187D8D670")]
		internal void MLPBGCNFPAN(KeepsakeProgressionEventInstancesDTO result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x7D8D340", Offset = "0x7D8BD40", VA = "0x187D8D340")]
		internal void FKGFCNNGDME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x7D8D370", Offset = "0x7D8BD70", VA = "0x187D8D370")]
		internal MPBOGDMHBIL<IEnumerable<Guid>> MLNJFCCBJKK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x78A16A0", Offset = "0x78A00A0", VA = "0x1878A16A0")]
		internal bool DOAGPJJLALL(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class MFKMBFAIBOO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public KeepsakeRoomInstanceIdsDTO instancesInRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public FCEMDDNEMLD CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public MFKMBFAIBOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x7D8F000", Offset = "0x7D8DA00", VA = "0x187D8F000")]
		internal MPBOGDMHBIL<IEnumerable<Guid>> FDNPPHPCMFM(KeepsakeRoomInstancesDTO roomInstancesDTO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class CECNKEPFKNB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public KeepsakeRoomInstancesDTO roomInstancesDTO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public MFKMBFAIBOO CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public CECNKEPFKNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x7D8CFE0", Offset = "0x7D8B9E0", VA = "0x187D8CFE0")]
		internal bool FFCJAAEIOPP(Guid instanceId)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class OMMPJPLDHEK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Guid instanceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public CECNKEPFKNB CS$<>8__locals3;

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public OMMPJPLDHEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x7D9D830", Offset = "0x7D9C230", VA = "0x187D9D830")]
		internal bool CDJLEIJEKGL(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class KECFHFOBIJL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public OJIFKAEGNHA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public KECFHFOBIJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x7D8E690", Offset = "0x7D8D090", VA = "0x187D8E690")]
		internal MPBOGDMHBIL<IEnumerable<Guid>> IGLKCOCFJEP(IEnumerable<Guid> instanceIds)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x7D8DA60", Offset = "0x7D8C460", VA = "0x187D8DA60")]
		internal bool GOIJCFPEGLH(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class LNCEOCBPAGD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public OJIFKAEGNHA <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public LNCEOCBPAGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x7D8EF70", Offset = "0x7D8D970", VA = "0x187D8EF70")]
		internal void OBANDNCEBPP(KeepsakeProgressionEventInstancesDTO result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x7D8D340", Offset = "0x7D8BD40", VA = "0x187D8D340")]
		internal void CJCNNLPELON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x7D8EC80", Offset = "0x7D8D680", VA = "0x187D8EC80")]
		internal MPBOGDMHBIL<Dictionary<Guid, JJFPKLGIJNA>> KBNOCOMPDCO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x78A16A0", Offset = "0x78A00A0", VA = "0x1878A16A0")]
		internal bool MJCIOFCPDAC(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class LMEANGLJJEJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public KeepsakeRoomInstanceIdsDTO instancesInRoom;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public LMEANGLJJEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x7D8EAD0", Offset = "0x7D8D4D0", VA = "0x187D8EAD0")]
		internal MPBOGDMHBIL<Dictionary<Guid, JJFPKLGIJNA>> HDKBNHDBGMD(KeepsakeRoomInstancesDTO roomInstancesDTO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class JMBLCONODOH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public KeepsakeRoomInstancesDTO roomInstancesDTO;

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public JMBLCONODOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x7D8E430", Offset = "0x7D8CE30", VA = "0x187D8E430")]
		internal bool EIJECGHMLHO(Guid instanceId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x7D8E510", Offset = "0x7D8CF10", VA = "0x187D8E510")]
		internal KeyValuePair<Guid, JJFPKLGIJNA> INMOEDNBKHL(Guid instanceId)
		{
			return default(KeyValuePair<Guid, JJFPKLGIJNA>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class EMOMKKKJGMN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public Guid instanceId;

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public EMOMKKKJGMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x268B660", Offset = "0x268A060", VA = "0x18268B660")]
		internal bool HMDJFHDDEBP(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class FPFDIKEMOOC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public Guid instanceId;

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public FPFDIKEMOOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x268B660", Offset = "0x268A060", VA = "0x18268B660")]
		internal bool LOOIJGMANDK(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class HHBIHNIHDJA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public OJIFKAEGNHA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public HHBIHNIHDJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x7D8DA80", Offset = "0x7D8C480", VA = "0x187D8DA80")]
		internal MPBOGDMHBIL<Dictionary<Guid, JJFPKLGIJNA>> NGCEGPNJNLB(Dictionary<Guid, JJFPKLGIJNA> instanceIdsAndCategories)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x7D8DA60", Offset = "0x7D8C460", VA = "0x187D8DA60")]
		internal bool FJMPMFOGBOL(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class LBIEJCKBCMI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public KeepsakeRoomInstanceIdsDTO collectedInstanceIds;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public LBIEJCKBCMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x7D8EA50", Offset = "0x7D8D450", VA = "0x187D8EA50")]
		internal bool BMKAFKCAEGE(KeyValuePair<Guid, JJFPKLGIJNA> idCategoryPair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class DGMIIDOBBHM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public Dictionary<Guid, JJFPKLGIJNA> instanceIdsAndCategories;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public DGMIIDOBBHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x7D8D110", Offset = "0x7D8BB10", VA = "0x187D8D110")]
		internal KeyValuePair<JJFPKLGIJNA, int> AEAMOOEPBMB(JJFPKLGIJNA category)
		{
			return default(KeyValuePair<JJFPKLGIJNA, int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class LKMEFALBPOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public JJFPKLGIJNA category;

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public LKMEFALBPOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0xE8CE80", Offset = "0xE8B880", VA = "0x180E8CE80")]
		internal bool NIFOFICHNGL(JJFPKLGIJNA instanceCategory)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class IDJHOOMACCO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public Dictionary<Guid, JJFPKLGIJNA> instanceIdsAndCategories;

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public IDJHOOMACCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x7D8DCA0", Offset = "0x7D8C6A0", VA = "0x187D8DCA0")]
		internal KeyValuePair<JJFPKLGIJNA, int> EBIBNDOCPJF(JJFPKLGIJNA category)
		{
			return default(KeyValuePair<JJFPKLGIJNA, int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class HEDODOEPIEB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public JJFPKLGIJNA category;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public HEDODOEPIEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0xE8CE80", Offset = "0xE8B880", VA = "0x180E8CE80")]
		internal bool KKCJGOEOKKO(JJFPKLGIJNA instanceCategory)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class JJFDJEMLFAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public OJIFKAEGNHA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public Func<KeepsakeRoomDTO, bool> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public JJFDJEMLFAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x7D8DF30", Offset = "0x7D8C930", VA = "0x187D8DF30")]
		internal bool IEJLLHDOAHC(DateTime nowUtc, DateTime eventStartTime, int roomOrder, TimeSpan unlockStartOffset, TimeSpan unlockInterval, int unlockBatchSize)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x7D8DE70", Offset = "0x7D8C870", VA = "0x187D8DE70")]
		internal bool GLEIHLBCBPC(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x7D8DE50", Offset = "0x7D8C850", VA = "0x187D8DE50")]
		internal bool BFLDDKDCCMJ(KeepsakeRoomDTO r)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x7D8DE50", Offset = "0x7D8C850", VA = "0x187D8DE50")]
		internal bool JKMALPHCPPK(KeepsakeRoomDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class FFMADMLFKAL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public FFMADMLFKAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0xEFEA00", Offset = "0xEFD400", VA = "0x180EFEA00")]
		internal bool DDBMIFOEGHO(KeepsakeRoomListDTO roomList)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class NAIOOOBGMJF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public Func<KeepsakeRoomDTO, bool> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public NAIOOOBGMJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x7D8F760", Offset = "0x7D8E160", VA = "0x187D8F760")]
		internal bool CLEDEBHNELL(KeepsakeRoomListDTO roomList)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x2612240", Offset = "0x2610C40", VA = "0x182612240")]
		internal bool IOGIJPJFKBA(KeepsakeRoomDTO room)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class FJCCPDIFHCD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public FJCCPDIFHCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x7D8D700", Offset = "0x7D8C100", VA = "0x187D8D700")]
		internal bool ENFODEPJFLP(KeepsakeRoomListDTO i)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class NCIHEHJBPCO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public NCIHEHJBPCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0xEFEA00", Offset = "0xEFD400", VA = "0x180EFEA00")]
		internal bool KCAFFJOJEMD(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class JAPEAEDAPBK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public Guid keepsakeInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public JAPEAEDAPBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x7D8DDF0", Offset = "0x7D8C7F0", VA = "0x187D8DDF0")]
		internal bool LBLEPGEEJNE(KeyValuePair<Guid, KeepsakeInstanceDTO> instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class MIEKBKKEPIO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public JJFPKLGIJNA keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public MIEKBKKEPIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x223B190", Offset = "0x2239B90", VA = "0x18223B190")]
		internal bool NGBBDGHHMJD(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class EDEPJAHAAKE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public Guid keepsakeInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public EDEPJAHAAKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x7D8D260", Offset = "0x7D8BC60", VA = "0x187D8D260")]
		internal bool EHDPCJIOGJM(KeyValuePair<Guid, KeepsakeInstanceDTO> instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class NCBOOOJKFDF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public JJFPKLGIJNA keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public NCBOOOJKFDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x7D8F820", Offset = "0x7D8E220", VA = "0x187D8F820")]
		internal bool EFLFEJLACJL(KeyValuePair<Guid, JJFPKLGIJNA> x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class LMPNCNEIICE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public JJFPKLGIJNA newKeepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public LMPNCNEIICE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x223B190", Offset = "0x2239B90", VA = "0x18223B190")]
		internal bool COHBHEAEGON(KeepsakeInstanceDTO instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class PMGBLHEIFCB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public long currentRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public long? currentSubRoomId;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public PMGBLHEIFCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x7D9D8E0", Offset = "0x7D9C2E0", VA = "0x187D9D8E0")]
		internal bool KANBOAFOFGE(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class NCPDEFGBIFB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public IReadOnlyList<KeepsakeRoomListDTO> roomList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public NCPDEFGBIFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x7D8F860", Offset = "0x7D8E260", VA = "0x187D8F860")]
		internal bool EDKHMDOGFLP(KeepsakeRoomDTO room)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class ELAKNDKMCAK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public KeepsakeRoomDTO room;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public NCPDEFGBIFB CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public ELAKNDKMCAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x7D8D2C0", Offset = "0x7D8BCC0", VA = "0x187D8D2C0")]
		internal bool FMAHJIOGDGI(KeepsakeRoomListDTO roomListDto)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private struct ALAMKPOLBNA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public OJIFKAEGNHA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public JFCHLDJHBKP args;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x7D8C7B0", Offset = "0x7D8B1B0", VA = "0x187D8C7B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x7D8CCD0", Offset = "0x7D8B6D0", VA = "0x187D8CCD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private struct HEMGMDOJLBI : IAsyncStateMachine
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
		public OJIFKAEGNHA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public string message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x7D8D760", Offset = "0x7D8C160", VA = "0x187D8D760", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x7D8DA00", Offset = "0x7D8C400", VA = "0x187D8DA00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly DateTime NLCLHCAKAGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly HLBCBFGNCDI OBBPCOLPIFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly BDNKEHJFKKK OACIKIJKLCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly NCPPOIOCNFE NMLOPAGCFCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly KGGIDKBMOPH NCENOCGOCMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly POJDIKBGDHI DLDEJAGLCHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly IGMDPHEOLOC EMOGAMHMCGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly OBLLMGJFLEG KNNGAINLICA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly ICKNPKBJODA JEJFACEGMCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly HFFIGAJJBDA IBJINHGKOBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly EAOGMICDMDD JPBLFPOGNLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly KFNMLAJAJEB CCJGANLKFLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly KFPAFNJKJID JMMBHCFJMCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly DCCIEDHPKOJ JEBDMANDAOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly HKFNDNNDPDP PGDCFDKJHHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly HEILNANPDJC MNPKNCJLCKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly DMAIMHDJNEK<KeepsakesConfig.KeepsakesOptions> LCCNAOLCHEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly JJPMOJNHOLC CCEMKGCMKEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly Dictionary<Guid, KeepsakeInstanceDTO> CNFPGMLMIBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly HashSet<Guid> NEHAPGFGOOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly HashSet<long> EBNIBPIBOMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private Dictionary<JJFPKLGIJNA, int> APAKDCIGPLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly HashSet<Guid> OONHOHBIPCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly IDisposable BNONMHECOEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private Task ELCFBFDKAEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private MPBOGDMHBIL<Guid> LLHKGOKFGOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private long? DEPHPBJKFLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private KeepsakeProgressionEventInstancesDTO NPDOKEEKGLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private MPBOGDMHBIL<KeepsakeProgressionEventInstancesDTO> CEPAOJKGMNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private IReadOnlyDictionary<JJFPKLGIJNA, KeepsakeCategoryConfigDTO> EOEEKCFPLDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private KeepsakeGlobalConfigDTO BEGAIJKJEJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private HashSet<long> MDCPCJINNGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private HashSet<long> ACOEMIDPBBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private List<KeepsakeRoomListDTO> BPPNAGGBMPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private List<KeepsakeRoomListDTO> LODHIHOPPMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private List<KeepsakeRoomListDTO> CNJNCLJEEIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private Dictionary<long, string> HCNFAHGDMEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private Dictionary<long, string> OJLOIGDMGAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private Dictionary<long, DateTime> IBDBBBHIHDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private Dictionary<long, List<KeepsakeRoomDTO>> BDBAAEFECHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private Dictionary<long, List<KeepsakeRoomDTO>> EMLHIJMMANE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private Dictionary<long, long> DNOKLANNPGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly List<string> CBADJHCDDKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private DateTime LKCMGIAAEHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly IDisposable LJFCDPLHDJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private Dictionary<Guid, JJFPKLGIJNA> LFOIHNJLDFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private Dictionary<JJFPKLGIJNA, int> JMBCDGGIFBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private List<KeepsakeCategoryThemePair> BOFCJBCMPMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private AMAIBNDNCKI JOJOMCLKDMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private bool IECKLNGGCBA;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool FDINODNHONB
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA38610", Offset = "0xA37010", VA = "0x180A38610", Slot = "53")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA38390", Offset = "0xA36D90", VA = "0x180A38390")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool FHECHCEGJIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7D98300", Offset = "0x7D96D00", VA = "0x187D98300", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool EBNHFMJEKDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7D93650", Offset = "0x7D92050", VA = "0x187D93650", Slot = "36")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private long NLOJLCKJHOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7D9B780", Offset = "0x7D9A180", VA = "0x187D9B780")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private long? OLEAFBABNIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7D98A10", Offset = "0x7D97410", VA = "0x187D98A10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private bool DFFFPNCBLKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7D9A660", Offset = "0x7D99060", VA = "0x187D9A660")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public IReadOnlyList<KeepsakeRoomListDTO> JHMNEIPLIEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xB2C1A0", Offset = "0xB2ABA0", VA = "0x180B2C1A0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public IReadOnlyList<KeepsakeRoomListDTO> LEKIBFFPAJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xB302E0", Offset = "0xB2ECE0", VA = "0x180B302E0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IReadOnlyList<KeepsakeRoomListDTO> OHCNPIMEGJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xB48D10", Offset = "0xB47710", VA = "0x180B48D10", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public IReadOnlyDictionary<long, string> GHKLNHLCPBH
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xB2C5B0", Offset = "0xB2AFB0", VA = "0x180B2C5B0", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	internal bool OEKAIDOEMOH
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xC28BA0", Offset = "0xC275A0", VA = "0x180C28BA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Guid?> OGGFPOFCOFP
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7D957D0", Offset = "0x7D941D0", VA = "0x187D957D0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7D9B850", Offset = "0x7D9A250", VA = "0x187D9B850", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action OPLFCEHMKPG
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7D93710", Offset = "0x7D92110", VA = "0x187D93710", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7D98580", Offset = "0x7D96F80", VA = "0x187D98580", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action JJJBDINKILI
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7D94E50", Offset = "0x7D93850", VA = "0x187D94E50", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7D95730", Offset = "0x7D94130", VA = "0x187D95730", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7D9C270", Offset = "0x7D9AC70", VA = "0x187D9C270")]
	[RecRoom.NoEngine.Common.Preserve]
	internal OJIFKAEGNHA([CNHMBDDCGKB(null)][NotNull] HLBCBFGNCDI OBBPCOLPIFL, [NotNull][CNHMBDDCGKB(null)] HEBBNJMIOCB OCGGFKMLMND, [NotNull][CNHMBDDCGKB(null)] BDNKEHJFKKK OACIKIJKLCL, [NotNull][CNHMBDDCGKB(null)] NCPPOIOCNFE NMLOPAGCFCB, [CNHMBDDCGKB(null)][NotNull] KGGIDKBMOPH NCENOCGOCMB, [CNHMBDDCGKB(null)][NotNull] POJDIKBGDHI DLDEJAGLCHP, [CNHMBDDCGKB(null)][NotNull] IGMDPHEOLOC EMOGAMHMCGI, [NotNull][CNHMBDDCGKB(null)] OBLLMGJFLEG KNNGAINLICA, [NotNull][CNHMBDDCGKB(null)] ICKNPKBJODA JEJFACEGMCJ, [NotNull][CNHMBDDCGKB(null)] PPHNMLPMELJ DBJECEACKPH, [NotNull][CNHMBDDCGKB(null)] HFFIGAJJBDA IBJINHGKOBE, [NotNull][CNHMBDDCGKB(null)] EAOGMICDMDD JPBLFPOGNLB, [NotNull][CNHMBDDCGKB(null)] KFNMLAJAJEB CCJGANLKFLJ, [NotNull][CNHMBDDCGKB(null)] KFPAFNJKJID JMMBHCFJMCL, [CNHMBDDCGKB(null)][NotNull] DCCIEDHPKOJ JEBDMANDAOH, [CNHMBDDCGKB(null)][NotNull] HKFNDNNDPDP PGDCFDKJHHG, [NotNull][CNHMBDDCGKB(null)] HEILNANPDJC MNPKNCJLCKG, [CNHMBDDCGKB(null)][NotNull] DMAIMHDJNEK<KeepsakesConfig.KeepsakesOptions> LCCNAOLCHEE, [NotNull][CNHMBDDCGKB(null)] JJPMOJNHOLC CCEMKGCMKEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7D979E0", Offset = "0x7D963E0", VA = "0x187D979E0", Slot = "15")]
	public bool KKBMLJINHDN(List<string> MOFPKKGJJBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7D9AB30", Offset = "0x7D99530", VA = "0x187D9AB30", Slot = "16")]
	public MPBOGDMHBIL<Guid> OMMEMNLHMDD(JJFPKLGIJNA HBPOCPOHODD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7D9B900", Offset = "0x7D9A300", VA = "0x187D9B900", Slot = "17")]
	public FDBBAHKKNBB PODFBLCLEPM(Guid APLOIMOLGJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7D937B0", Offset = "0x7D921B0", VA = "0x187D937B0", Slot = "18")]
	public FDBBAHKKNBB FHFIFPFOCAN(Guid APLOIMOLGJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7D96940", Offset = "0x7D95340", VA = "0x187D96940", Slot = "19")]
	public bool KAOBNIPFGHI(Guid APLOIMOLGJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7D90FA0", Offset = "0x7D8F9A0", VA = "0x187D90FA0", Slot = "20")]
	public bool BAIDOMBDHLH(Guid APLOIMOLGJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7D9A670", Offset = "0x7D99070", VA = "0x187D9A670")]
	public KeepsakeTheme OLFKHLHONCF(Guid APLOIMOLGJJ)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7D9A090", Offset = "0x7D98A90", VA = "0x187D9A090")]
	public bool NOHKLKCINOI(JJFPKLGIJNA HBPOCPOHODD, [Out] KeepsakeTheme NELCPAOHEOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7D94EF0", Offset = "0x7D938F0", VA = "0x187D94EF0")]
	public List<KeepsakeTheme> HPGFPGFJMAO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7D8FA20", Offset = "0x7D8E420", VA = "0x187D8FA20")]
	public int AHDDCCGLMLD(JJFPKLGIJNA HBPOCPOHODD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7D952A0", Offset = "0x7D93CA0", VA = "0x187D952A0")]
	public JJFPKLGIJNA IBCPFOICPJB(Guid APLOIMOLGJJ)
	{
		return default(JJFPKLGIJNA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7D98440", Offset = "0x7D96E40", VA = "0x187D98440", Slot = "34")]
	public List<JJFPKLGIJNA> MACFCNJLNKG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7D91660", Offset = "0x7D90060", VA = "0x187D91660", Slot = "35")]
	public IComparer<JJFPKLGIJNA> DCAOGLFBKGC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7D98C10", Offset = "0x7D97610", VA = "0x187D98C10", Slot = "32")]
	public string NEAPJGLNAAO(JJFPKLGIJNA HBPOCPOHODD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7D95CF0", Offset = "0x7D946F0", VA = "0x187D95CF0", Slot = "33")]
	public string JFOEHBBHFBA(JJFPKLGIJNA HBPOCPOHODD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7D95E70", Offset = "0x7D94870", VA = "0x187D95E70", Slot = "21")]
	public bool JGHKFCDCBEH(Guid APLOIMOLGJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7D8F9B0", Offset = "0x7D8E3B0", VA = "0x187D8F9B0", Slot = "22")]
	public void AGCPDFFCJPG(Guid APLOIMOLGJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7D91CD0", Offset = "0x7D906D0", VA = "0x187D91CD0", Slot = "23")]
	public void DLDPNPPOBFK(JJFPKLGIJNA HBPOCPOHODD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7D98D90", Offset = "0x7D97790", VA = "0x187D98D90", Slot = "24")]
	public void NFHBEONMEJP(Guid APLOIMOLGJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7D93FF0", Offset = "0x7D929F0", VA = "0x187D93FF0", Slot = "25")]
	public int GJBPBGKHDMJ()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7D91720", Offset = "0x7D90120", VA = "0x187D91720", Slot = "31")]
	public MPBOGDMHBIL<IEnumerable<Guid>> DDNNFHHPEDN(long FHOIPEIAACP, long AAFEKOBABPD, JJFPKLGIJNA? HBPOCPOHODD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7D95880", Offset = "0x7D94280", VA = "0x187D95880", Slot = "30")]
	public MPBOGDMHBIL<IEnumerable<Guid>> IJFEGEOIMAD(long FHOIPEIAACP, long AAFEKOBABPD, JJFPKLGIJNA? HBPOCPOHODD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7D97630", Offset = "0x7D96030", VA = "0x187D97630", Slot = "54")]
	public MPBOGDMHBIL<Dictionary<Guid, JJFPKLGIJNA>> KHOECCGBAHC(long FHOIPEIAACP, long AAFEKOBABPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7D913E0", Offset = "0x7D8FDE0", VA = "0x187D913E0", Slot = "55")]
	public MPBOGDMHBIL<Dictionary<Guid, JJFPKLGIJNA>> CGFIOCPPCKH(long FHOIPEIAACP, long AAFEKOBABPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7D98FD0", Offset = "0x7D979D0", VA = "0x187D98FD0", Slot = "26")]
	public MPBOGDMHBIL<int> NGKKOLAJMFA(long FHOIPEIAACP, long AAFEKOBABPD, JJFPKLGIJNA? HBPOCPOHODD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7D92F00", Offset = "0x7D91900", VA = "0x187D92F00", Slot = "27")]
	public MPBOGDMHBIL<int> FABKOCOJCEG(long FHOIPEIAACP, long AAFEKOBABPD, JJFPKLGIJNA? HBPOCPOHODD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7D9A7B0", Offset = "0x7D991B0", VA = "0x187D9A7B0", Slot = "28")]
	public MPBOGDMHBIL<Dictionary<JJFPKLGIJNA, int>> OMFKGAEJGFB(long FHOIPEIAACP, long AAFEKOBABPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7D91320", Offset = "0x7D8FD20", VA = "0x187D91320", Slot = "29")]
	public MPBOGDMHBIL<Dictionary<JJFPKLGIJNA, int>> CEKJFOCJIAA(long FHOIPEIAACP, long AAFEKOBABPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7D946A0", Offset = "0x7D930A0", VA = "0x187D946A0", Slot = "37")]
	public bool GOKCDOBMLML(long FHOIPEIAACP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7D96740", Offset = "0x7D95140", VA = "0x187D96740", Slot = "56")]
	public bool JOMNOJCDJKP(long FHOIPEIAACP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7D94CA0", Offset = "0x7D936A0", VA = "0x187D94CA0", Slot = "38")]
	public bool HJEENEEOAKB(long FHOIPEIAACP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7D962E0", Offset = "0x7D94CE0", VA = "0x187D962E0", Slot = "57")]
	public bool JMGJNFMEJJE(long FHOIPEIAACP, [Out] ALPGOOJMDNM PBMONNAMJHK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7D911E0", Offset = "0x7D8FBE0", VA = "0x187D911E0", Slot = "39")]
	public bool BJGFCKEHCNC(long DKMMEAHHGNL, [Out] DateTime KLPHMKMOKJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7D99640", Offset = "0x7D98040", VA = "0x187D99640", Slot = "40")]
	public long NIFJJGOELNI(long DKMMEAHHGNL)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7D933F0", Offset = "0x7D91DF0", VA = "0x187D933F0", Slot = "41")]
	public long FDMHCICOGFJ(long FHOIPEIAACP)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7D9A270", Offset = "0x7D98C70", VA = "0x187D9A270", Slot = "42")]
	public int OCLONEEIOCF(long DKMMEAHHGNL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7D95B30", Offset = "0x7D94530", VA = "0x187D95B30", Slot = "43")]
	public bool JCLGCFLJFHL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x7D94700", Offset = "0x7D93100", VA = "0x187D94700", Slot = "44")]
	public bool HBIKDDCLHBP(long DKMMEAHHGNL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7D97D20", Offset = "0x7D96720", VA = "0x187D97D20", Slot = "45")]
	public IReadOnlyList<long> LBBEGENBPAE(long DKMMEAHHGNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7D97F90", Offset = "0x7D96990", VA = "0x187D97F90", Slot = "46")]
	public int LFAMJPNOOLP(long DKMMEAHHGNL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7D98040", Offset = "0x7D96A40", VA = "0x187D98040", Slot = "50")]
	public long LFEKFHCHPAK(long PJAGMGAAKND)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7D92B00", Offset = "0x7D91500", VA = "0x187D92B00", Slot = "51")]
	public JJFPKLGIJNA ELDGGPABJEB()
	{
		return default(JJFPKLGIJNA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7D92570", Offset = "0x7D90F70", VA = "0x187D92570")]
	private bool EEOONOLMOLN(Guid APLOIMOLGJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7D93B30", Offset = "0x7D92530", VA = "0x187D93B30")]
	private void GDDLPEJLKDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7D95460", Offset = "0x7D93E60", VA = "0x187D95460")]
	private JJFPKLGIJNA IICDNBEGMFI()
	{
		return default(JJFPKLGIJNA);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7D9B140", Offset = "0x7D99B40", VA = "0x187D9B140")]
	private void OOBHMFBOBCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7D967A0", Offset = "0x7D951A0", VA = "0x187D967A0")]
	private int KAHGHCCAAHE(KeepsakeRoomListDTO EHHFOBOBAJJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7D926A0", Offset = "0x7D910A0", VA = "0x187D926A0")]
	private int EFEKLDLLDCP(DateTime EPAIECILPPG, DateTime GEOECCFCDPO, TimeSpan DHLEHCEOGEG, int IGICGLKCOLJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7D8FD40", Offset = "0x7D8E740", VA = "0x187D8FD40")]
	private void AIGEGFFCJAA(IEnumerable<KeepsakeInstanceDTO> CNFPGMLMIBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7D91D20", Offset = "0x7D90720", VA = "0x187D91D20")]
	private void DMLMNLJJHHC(IEnumerable<KeepsakeCollectionRecordDTO> MPHDMHGBOIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7D9A030", Offset = "0x7D98A30", VA = "0x187D9A030")]
	private void NLNAEFIBHLN(IEnumerable<long> NOIICGAFMMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0xAA8F30", Offset = "0xAA7930", VA = "0x180AA8F30")]
	private void GOPBHPOIKKL(KeepsakeGlobalConfigDTO BEGAIJKJEJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7D987B0", Offset = "0x7D971B0", VA = "0x187D987B0")]
	private bool MGEBBEMOIOP(JJFPKLGIJNA HBPOCPOHODD, [Out] Guid IMAAOOIJOAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7D92E60", Offset = "0x7D91860", VA = "0x187D92E60")]
	private bool ENDFNIBMGGP([Out] Guid IMAAOOIJOAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7D95400", Offset = "0x7D93E00", VA = "0x187D95400")]
	private bool IDLMCDNKLAI(Guid APLOIMOLGJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x7D94B50", Offset = "0x7D93550", VA = "0x187D94B50")]
	private IEnumerable<Guid> HEBBFFFJHHF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7D91570", Offset = "0x7D8FF70", VA = "0x187D91570")]
	private IEnumerable<KeepsakeInstanceDTO> CJAAJHECFLO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7D98370", Offset = "0x7D96D70", VA = "0x187D98370")]
	private void LKCPDLHEPGI(Guid APLOIMOLGJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7D97C70", Offset = "0x7D96670", VA = "0x187D97C70")]
	private bool KOKNJCBHHHA(Guid APLOIMOLGJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7D8FBA0", Offset = "0x7D8E5A0", VA = "0x187D8FBA0")]
	private void AICHLOPEBGC(Guid APLOIMOLGJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7D90FD0", Offset = "0x7D8F9D0", VA = "0x187D90FD0")]
	private void BFIHJAJIJMA(JJFPKLGIJNA KGIGFDOMMJA, int DLNAJFLMHAB, Dictionary<JJFPKLGIJNA, int> BHOIHCCJJGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7D90EB0", Offset = "0x7D8F8B0", VA = "0x187D90EB0")]
	private int APKFHFJMLIE(JJFPKLGIJNA HBPOCPOHODD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7D97460", Offset = "0x7D95E60", VA = "0x187D97460")]
	private void KGIFNAGBKIM(KeepsakeInstanceDTO LAHEHBIKJDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7D9A450", Offset = "0x7D98E50", VA = "0x187D9A450")]
	private void OFKJNNOIPJG(KeepsakeInstanceDTO LAHEHBIKJDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7D99270", Offset = "0x7D97C70", VA = "0x187D99270")]
	private void NHEOBNOGOJL(Guid APLOIMOLGJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7D91630", Offset = "0x7D90030", VA = "0x187D91630")]
	private void ILAJAPEPALL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7D98350", Offset = "0x7D96D50", VA = "0x187D98350")]
	private void LJJJPHPPGJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7D92A90", Offset = "0x7D91490", VA = "0x187D92A90")]
	private void EKPGBCDKJNK(NPPCBBFHGKB MAHHBHOMIJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7D91630", Offset = "0x7D90030", VA = "0x187D91630")]
	private void COGLCCMBBBN(MGHIFNAEKMG OJDHMKOBKLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7D91630", Offset = "0x7D90030", VA = "0x187D91630")]
	private void OOAMLANFPKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7D93050", Offset = "0x7D91A50", VA = "0x187D93050")]
	private void FCLJBOKEAFE(float HAFMFFEGLKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x7D96AA0", Offset = "0x7D954A0", VA = "0x187D96AA0")]
	private void KFHBKJOINCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7D91AD0", Offset = "0x7D904D0", VA = "0x187D91AD0")]
	private bool DEFNHGMFOMF(Guid APLOIMOLGJJ, [Out] string PMEBBMLODIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7D9BB80", Offset = "0x7D9A580", VA = "0x187D9BB80")]
	private bool POIBMPMFPCK(Guid APLOIMOLGJJ, [Out] KeepsakeCategoryConfigDTO KGIGFDOMMJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7D95C10", Offset = "0x7D94610", VA = "0x187D95C10")]
	private void JFJKGMINBLG(string LJKJKJCKCBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7D95A20", Offset = "0x7D94420", VA = "0x187D95A20")]
	private bool JBCKEPMLHCC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7D94890", Offset = "0x7D93290", VA = "0x187D94890")]
	private List<long> HCAIJLGMODP(IEnumerable<KeepsakeRoomDTO> EMMOCCBHKPB, IReadOnlyList<KeepsakeRoomListDTO> DJCDLEMIIDJ, long DKMMEAHHGNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x7D9BD50", Offset = "0x7D9A750", VA = "0x187D9BD50")]
	private bool PPPALOCINNG(Guid APLOIMOLGJJ, [Out] string OLIGKIPGKGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7D96690", Offset = "0x7D95090", VA = "0x187D96690", Slot = "47")]
	public string JNBPGCAEDMI(KAAHDAPEMLH PCPKHPOGMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x7D97040", Offset = "0x7D95A40", VA = "0x187D97040", Slot = "49")]
	public string KGEEOHDALNP(KAAHDAPEMLH PCPKHPOGMEP, long FHOIPEIAACP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7D94410", Offset = "0x7D92E10", VA = "0x187D94410", Slot = "48")]
	public string GKJCDCEMAMK(KAAHDAPEMLH PCPKHPOGMEP, int EOBAOGKDGHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x7D8FFD0", Offset = "0x7D8E9D0", VA = "0x187D8FFD0")]
	private void AIOGHFKAPOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7D98620", Offset = "0x7D97020", VA = "0x187D98620")]
	private void MDHPECNBGHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x7D920F0", Offset = "0x7D90AF0", VA = "0x187D920F0")]
	private KAAHDAPEMLH DPBCEPEJMOL(KGOIMDJLHMP KJHKCJMBLJG)
	{
		return default(KAAHDAPEMLH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x7D98420", Offset = "0x7D96E20", VA = "0x187D98420")]
	private KAAHDAPEMLH LMJOOOLPGIK(KGOIMDJLHMP KJHKCJMBLJG)
	{
		return default(KAAHDAPEMLH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7D96100", Offset = "0x7D94B00", VA = "0x187D96100")]
	internal static string JLEIJGMGBEN(NBLIJPCCJMG COBBCGIHJAA, string JIABHABFIPA, bool FIEBHNLEMIL, int AFJAMGFFLJB, int LCCKMLOMIIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7D92110", Offset = "0x7D90B10", VA = "0x187D92110", Slot = "52")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x7D93500", Offset = "0x7D91F00", VA = "0x187D93500")]
	private MKIOIHPBAPC FECEALBEJII(GBDECDHLMJN FKLJNCFBHIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7D944E0", Offset = "0x7D92EE0", VA = "0x187D944E0")]
	private OACHJIOLDGM GMEHKLKAEIN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7D99B80", Offset = "0x7D98580", VA = "0x187D99B80")]
	private Task NIKAOKANDDE(JFCHLDJHBKP MPEOAHOICFG, CancellationToken JKPNCAGHEDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7D94D40", Offset = "0x7D93740", VA = "0x187D94D40")]
	[AsyncStateMachine(typeof(ALAMKPOLBNA))]
	private Task HKPDHCBFKEB(JFCHLDJHBKP MPEOAHOICFG, CancellationToken JKPNCAGHEDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7D93580", Offset = "0x7D91F80", VA = "0x187D93580")]
	private Task FEIGOKDMIDO(JFCHLDJHBKP MPEOAHOICFG, CancellationToken JKPNCAGHEDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7D910B0", Offset = "0x7D8FAB0", VA = "0x187D910B0")]
	[AsyncStateMachine(typeof(HEMGMDOJLBI))]
	private Task BIOOMCKKKKN(string IJOJGNJMCGP, TimeSpan MBPLFLMEDBL, CancellationToken JKPNCAGHEDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7D90E90", Offset = "0x7D8F890", VA = "0x187D90E90")]
	[CompilerGenerated]
	private void AJHCALAFOJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7D966F0", Offset = "0x7D950F0", VA = "0x187D966F0")]
	[CompilerGenerated]
	private void JNMMPMDKMHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7D99F30", Offset = "0x7D98930", VA = "0x187D99F30")]
	[CompilerGenerated]
	private bool NLIAOIKBBNI(KeepsakeInstanceDTO CBPCNABIALH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7D98AA0", Offset = "0x7D974A0", VA = "0x187D98AA0")]
	[CompilerGenerated]
	private MPBOGDMHBIL<Dictionary<JJFPKLGIJNA, int>> NDGCDOGHHHB(Dictionary<Guid, JJFPKLGIJNA> IEIFPCPIMBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x7D9A9C0", Offset = "0x7D993C0", VA = "0x187D9A9C0")]
	[CompilerGenerated]
	private MPBOGDMHBIL<Dictionary<JJFPKLGIJNA, int>> OMIHCKAOJNF(Dictionary<Guid, JJFPKLGIJNA> IEIFPCPIMBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7D98400", Offset = "0x7D96E00", VA = "0x187D98400")]
	[CompilerGenerated]
	private bool LKOCGHGGCFP(KeepsakeRoomListDTO CBPCNABIALH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7D92960", Offset = "0x7D91360", VA = "0x187D92960")]
	[CompilerGenerated]
	private bool EJHJMEJMLGD(KeepsakeInstanceDTO CBPCNABIALH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7D91F60", Offset = "0x7D90960", VA = "0x187D91F60")]
	[CompilerGenerated]
	private void DPAHLJMLBNO(Tuple<KeepsakeRoomInstancesDTO, IReadOnlyDictionary<JJFPKLGIJNA, KeepsakeCategoryConfigDTO>, KeepsakeGlobalConfigDTO> NONPLOKGMEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7D8F950", Offset = "0x7D8E350", VA = "0x187D8F950")]
	[CompilerGenerated]
	private void ACDHIFJAHJB(string OLIGKIPGKGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x7D927A0", Offset = "0x7D911A0", VA = "0x187D927A0")]
	[CompilerGenerated]
	private Task EJFELLMBNIO(CancellationToken CJBAJGFJMMG)
	{
		return null;
	}
}
namespace RecRoom.Keepsakes
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public class KeepsakesConfig : ScriptableObject, DMAIMHDJNEK<KeepsakesConfig.KeepsakesOptions>
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200002B")]
		public class KeepsakesOptions
		{
			[Cpp2IlInjected.Token(Token = "0x200002C")]
			[CompilerGenerated]
			private sealed class KBFPAJDGNED
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000098")]
				public string themeId;

				[Cpp2IlInjected.Token(Token = "0x60000F3")]
				[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
				public KBFPAJDGNED()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000F4")]
				[Cpp2IlInjected.Address(RVA = "0x7D8E660", Offset = "0x7D8D060", VA = "0x187D8E660")]
				internal bool BGMHFNDGEPO(KeepsakeTheme x)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60000F5")]
				[Cpp2IlInjected.Address(RVA = "0x7D8E660", Offset = "0x7D8D060", VA = "0x187D8E660")]
				internal bool OLOPKNFAMCM(KeepsakeTheme x)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			[SerializeField]
			private KeepsakeTheme[] themes;

			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x7D8E880", Offset = "0x7D8D280", VA = "0x187D8E880")]
			public bool LAFDNABDAOB(string KHIOPBNCPPM, [Out] KeepsakeTheme NELCPAOHEOO)
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
			[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x7D8E800", Offset = "0x7D8D200", VA = "0x187D8E800")]
		[CGLGNCLDKHN.CKJOAALDIOP.OPIHCDHBMNP]
		internal static void FEDJMCICCOK(MHGNCMHMEKD DJGDNAKMFCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0xC49D80", Offset = "0xC48780", VA = "0x180C49D80")]
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
