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
		[Cpp2IlInjected.Address(RVA = "0x7CA9E10", Offset = "0x7CA9010", VA = "0x187CA9E10", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x274B560", Offset = "0x274A760", VA = "0x18274B560")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class JGNKGDHOONP : IComparer<JDOMPGJPOEI>
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private sealed class LGGOJOHJDDA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public JDOMPGJPOEI x;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public JDOMPGJPOEI y;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public LGGOJOHJDDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xD67F60", Offset = "0xD67160", VA = "0x180D67F60")]
		internal bool ICJHCMMKDOI(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x1F921B0", Offset = "0x1F913B0", VA = "0x181F921B0")]
		internal bool NFNPADBPCBE(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xD67F60", Offset = "0xD67160", VA = "0x180D67F60")]
		internal bool PHEMJPAGOIO(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1F921B0", Offset = "0x1F913B0", VA = "0x181F921B0")]
		internal bool OHGCCAKNLBH(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private List<KeepsakeCategoryThemePair> ELOPAMEFBPB;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0xA0F6B0", Offset = "0xA0E8B0", VA = "0x180A0F6B0")]
	public JGNKGDHOONP(List<KeepsakeCategoryThemePair> NFFJEALOJDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7CA8390", Offset = "0x7CA7590", VA = "0x187CA8390", Slot = "4")]
	public int Compare(JDOMPGJPOEI HGCMPGNMMIB, JDOMPGJPOEI PIALGICKFLK)
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
		public JDOMPGJPOEI KeepsakeCategory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public KeepsakeTheme KeepsakeTheme;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[CBAABKHKLJM]
public class GIBOAICCGPK : MEBGNIEBDPP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class DCHIMABDKIH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public GIBOAICCGPK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public JDOMPGJPOEI keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public DCHIMABDKIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7C98CE0", Offset = "0x7C97EE0", VA = "0x187C98CE0")]
		internal GFHJFJDJPFP<Guid> HKOANJOIDJM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7C992E0", Offset = "0x7C984E0", VA = "0x187C992E0")]
		internal void PLOKGOLDEOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7C98E70", Offset = "0x7C98070", VA = "0x187C98E70")]
		internal void MIJOCHKMPDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7C98ED0", Offset = "0x7C980D0", VA = "0x187C98ED0")]
		internal void MJJBHIFLELF(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7C98E40", Offset = "0x7C98040", VA = "0x187C98E40")]
		internal void KGJBMIPDGCP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class OGBLDFMBIMH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public GIBOAICCGPK <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public OGBLDFMBIMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7CA9550", Offset = "0x7CA8750", VA = "0x187CA9550")]
		internal void KPPJJCGHNPF(KFBLIHNFHOH response)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7CA94F0", Offset = "0x7CA86F0", VA = "0x187CA94F0")]
		internal void ICHHMDEMGNM(string error)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class LJJKJGCDOMI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public KeepsakeTheme theme;

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public LJJKJGCDOMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x7CA8A00", Offset = "0x7CA7C00", VA = "0x187CA8A00")]
		internal bool GKMFGNOGPCH(KeepsakeCategoryThemePair categoryThemePair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class ELECKPGLAFH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public GIBOAICCGPK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public long progressionEventId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public JDOMPGJPOEI? keepsakeCategory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public ELECKPGLAFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x7C99970", Offset = "0x7C98B70", VA = "0x187C99970")]
		internal void KKCJKFAMHMG(KeepsakeProgressionEventInstancesDTO result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x7C99730", Offset = "0x7C98930", VA = "0x187C99730")]
		internal void BPBIPFJBMPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x7C99A00", Offset = "0x7C98C00", VA = "0x187C99A00")]
		internal GFHJFJDJPFP<IEnumerable<Guid>> NKMCFABFACD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x77D9C50", Offset = "0x77D8E50", VA = "0x1877D9C50")]
		internal bool DHIFCDGGAAG(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class ENDLGIBHHMH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public KeepsakeRoomInstanceIdsDTO instancesInRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public ELECKPGLAFH CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public ENDLGIBHHMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x7C99D00", Offset = "0x7C98F00", VA = "0x187C99D00")]
		internal GFHJFJDJPFP<IEnumerable<Guid>> IIJKNCPFJBM(KeepsakeRoomInstancesDTO roomInstancesDTO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class BIGGOJFGGMI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public KeepsakeRoomInstancesDTO roomInstancesDTO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public ENDLGIBHHMH CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public BIGGOJFGGMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x7C98BB0", Offset = "0x7C97DB0", VA = "0x187C98BB0")]
		internal bool PLIMJNAHOBH(Guid instanceId)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class NBOGLNMHKEH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Guid instanceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public BIGGOJFGGMI CS$<>8__locals3;

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public NBOGLNMHKEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x7CA9160", Offset = "0x7CA8360", VA = "0x187CA9160")]
		internal bool MDBPKGIKNCC(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class LHMDINLEAFI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public GIBOAICCGPK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public LHMDINLEAFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x7CA8890", Offset = "0x7CA7A90", VA = "0x187CA8890")]
		internal GFHJFJDJPFP<IEnumerable<Guid>> LGHLALFLPKN(IEnumerable<Guid> instanceIds)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x7C9A040", Offset = "0x7C99240", VA = "0x187C9A040")]
		internal bool BNPBLMLDBEO(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class DOOKAJPFDHC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public GIBOAICCGPK <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public DOOKAJPFDHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x7C993B0", Offset = "0x7C985B0", VA = "0x187C993B0")]
		internal void EBLKJBMFMCN(KeepsakeProgressionEventInstancesDTO result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x7C99730", Offset = "0x7C98930", VA = "0x187C99730")]
		internal void KMHHKPLLGDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x7C99440", Offset = "0x7C98640", VA = "0x187C99440")]
		internal GFHJFJDJPFP<Dictionary<Guid, JDOMPGJPOEI>> HBNDIFJMODP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x77D9C50", Offset = "0x77D8E50", VA = "0x1877D9C50")]
		internal bool PDKGCMBFJFJ(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class EBNCEIEBIIL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public KeepsakeRoomInstanceIdsDTO instancesInRoom;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public EBNCEIEBIIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x7C997C0", Offset = "0x7C989C0", VA = "0x187C997C0")]
		internal GFHJFJDJPFP<Dictionary<Guid, JDOMPGJPOEI>> LGFBMLPPDAF(KeepsakeRoomInstancesDTO roomInstancesDTO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class HAKGALLMHFN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public KeepsakeRoomInstancesDTO roomInstancesDTO;

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public HAKGALLMHFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x7CA82B0", Offset = "0x7CA74B0", VA = "0x187CA82B0")]
		internal bool LIPBNIMPKMF(Guid instanceId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x7CA8160", Offset = "0x7CA7360", VA = "0x187CA8160")]
		internal KeyValuePair<Guid, JDOMPGJPOEI> CPFONCHJOCA(Guid instanceId)
		{
			return default(KeyValuePair<Guid, JDOMPGJPOEI>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class DILPBEBBHEM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public Guid instanceId;

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public DILPBEBBHEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x2625550", Offset = "0x2624750", VA = "0x182625550")]
		internal bool NMHGANFHLGJ(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class LAMLHFHPPOB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public Guid instanceId;

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public LAMLHFHPPOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x2625550", Offset = "0x2624750", VA = "0x182625550")]
		internal bool LGMLCPIGMIB(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class FKCLOAHLOAP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public GIBOAICCGPK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public FKCLOAHLOAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x7C99E40", Offset = "0x7C99040", VA = "0x187C99E40")]
		internal GFHJFJDJPFP<Dictionary<Guid, JDOMPGJPOEI>> OLDHCCKGPMD(Dictionary<Guid, JDOMPGJPOEI> instanceIdsAndCategories)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x7C9A040", Offset = "0x7C99240", VA = "0x187C9A040")]
		internal bool PNIJJCBKPCK(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class NBOHKMAJIBF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public KeepsakeRoomInstanceIdsDTO collectedInstanceIds;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public NBOHKMAJIBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x7CA9210", Offset = "0x7CA8410", VA = "0x187CA9210")]
		internal bool DPJMGEGOEOB(KeyValuePair<Guid, JDOMPGJPOEI> idCategoryPair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class LMEKGPBFFEJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public Dictionary<Guid, JDOMPGJPOEI> instanceIdsAndCategories;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public LMEKGPBFFEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x7CA8A20", Offset = "0x7CA7C20", VA = "0x187CA8A20")]
		internal KeyValuePair<JDOMPGJPOEI, int> KPOJHJIOCBG(JDOMPGJPOEI category)
		{
			return default(KeyValuePair<JDOMPGJPOEI, int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class EDOKEBLPOGE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public JDOMPGJPOEI category;

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public EDOKEBLPOGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0xE501B0", Offset = "0xE4F3B0", VA = "0x180E501B0")]
		internal bool PJODBEGLJJL(JDOMPGJPOEI instanceCategory)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class AKNLNBHJLKN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public Dictionary<Guid, JDOMPGJPOEI> instanceIdsAndCategories;

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public AKNLNBHJLKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x7C98A60", Offset = "0x7C97C60", VA = "0x187C98A60")]
		internal KeyValuePair<JDOMPGJPOEI, int> AAIDABLDJOP(JDOMPGJPOEI category)
		{
			return default(KeyValuePair<JDOMPGJPOEI, int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class NDCFDKHFPOM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public JDOMPGJPOEI category;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public NDCFDKHFPOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0xE501B0", Offset = "0xE4F3B0", VA = "0x180E501B0")]
		internal bool CFLGJPANCJJ(JDOMPGJPOEI instanceCategory)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class GBEKNDNHGBL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public GIBOAICCGPK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public Func<KeepsakeRoomDTO, bool> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public GBEKNDNHGBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x7C9A060", Offset = "0x7C99260", VA = "0x187C9A060")]
		internal bool BLLHODMOMAJ(DateTime nowUtc, DateTime eventStartTime, int roomOrder, TimeSpan unlockStartOffset, TimeSpan unlockInterval, int unlockBatchSize)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x7C9A170", Offset = "0x7C99370", VA = "0x187C9A170")]
		internal bool MHFAOMLCDEG(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x7C9A150", Offset = "0x7C99350", VA = "0x187C9A150")]
		internal bool IAPKNGIGECP(KeepsakeRoomDTO r)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x7C9A150", Offset = "0x7C99350", VA = "0x187C9A150")]
		internal bool OOBMCJHHPCA(KeepsakeRoomDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class CBLNPLAKLJC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public CBLNPLAKLJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0xECEF10", Offset = "0xECE110", VA = "0x180ECEF10")]
		internal bool MBHFBGHJOME(KeepsakeRoomListDTO roomList)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class NNLNGNEDAHG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public Func<KeepsakeRoomDTO, bool> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public NNLNGNEDAHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x7CA9380", Offset = "0x7CA8580", VA = "0x187CA9380")]
		internal bool HNHLFGPNMNP(KeepsakeRoomListDTO roomList)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x25A80D0", Offset = "0x25A72D0", VA = "0x1825A80D0")]
		internal bool KCNKBOPGEIO(KeepsakeRoomDTO room)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class EBHBDPJEDGN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public EBHBDPJEDGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x7C99760", Offset = "0x7C98960", VA = "0x187C99760")]
		internal bool DMCJAIPCKKP(KeepsakeRoomListDTO i)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class OABAFJNHFHM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public OABAFJNHFHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0xECEF10", Offset = "0xECE110", VA = "0x180ECEF10")]
		internal bool LCKNLCGLFLA(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class MBLGHGAELCG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public Guid keepsakeInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public MBLGHGAELCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x7CA9100", Offset = "0x7CA8300", VA = "0x187CA9100")]
		internal bool GCCBAENFPMC(KeyValuePair<Guid, KeepsakeInstanceDTO> instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class HJFCBEJOFDC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public JDOMPGJPOEI keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public HJFCBEJOFDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x21BF750", Offset = "0x21BE950", VA = "0x1821BF750")]
		internal bool JHPNAJJMLLB(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class DKADKNMBHKH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public Guid keepsakeInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public DKADKNMBHKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x7C99310", Offset = "0x7C98510", VA = "0x187C99310")]
		internal bool IFPEHJCGBEJ(KeyValuePair<Guid, KeepsakeInstanceDTO> instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class DONHGONEPDN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public JDOMPGJPOEI keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public DONHGONEPDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x7C99370", Offset = "0x7C98570", VA = "0x187C99370")]
		internal bool OJDBBPEODAG(KeyValuePair<Guid, JDOMPGJPOEI> x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class BJJABJIKPOI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public JDOMPGJPOEI newKeepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public BJJABJIKPOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x21BF750", Offset = "0x21BE950", VA = "0x1821BF750")]
		internal bool CEMKCICPGGE(KeepsakeInstanceDTO instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class ACOFLKHCLBJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public long currentRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public long? currentSubRoomId;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public ACOFLKHCLBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x7C989E0", Offset = "0x7C97BE0", VA = "0x187C989E0")]
		internal bool FKIADGJOOMH(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class NECFOPDIJJP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public IReadOnlyList<KeepsakeRoomListDTO> roomList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public NECFOPDIJJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x7CA9290", Offset = "0x7CA8490", VA = "0x187CA9290")]
		internal bool MBFGPGAPDCK(KeepsakeRoomDTO room)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class OEEBOCLDCBO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public KeepsakeRoomDTO room;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public NECFOPDIJJP CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public OEEBOCLDCBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x7CA9470", Offset = "0x7CA8670", VA = "0x187CA9470")]
		internal bool MNDNOAPHNBE(KeepsakeRoomListDTO roomListDto)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private struct MBBNJHBPGOC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public GIBOAICCGPK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public IMGOPGMMMDH args;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x7CA8B70", Offset = "0x7CA7D70", VA = "0x187CA8B70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x7CA90A0", Offset = "0x7CA82A0", VA = "0x187CA90A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private struct PBNNJHIFHFC : IAsyncStateMachine
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
		public GIBOAICCGPK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public string message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x7CA9900", Offset = "0x7CA8B00", VA = "0x187CA9900", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x7CA9BA0", Offset = "0x7CA8DA0", VA = "0x187CA9BA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly DateTime PCNMEFKHDJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly AMKPCHCHDLI ADABLGGDMDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly MKKJDGBEGLC HHEJFGGCDFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly PANKMIFEGDJ BJGBGNLOBNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly DHLHPBIKGGG EKGMHLMCNAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly GAPAGLFJNJK IKFFOMHBDLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly JKNFMCKPNHB LILOKELBBCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly FMJDBDONLDC DJOOOBHJMCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly AGONIDGIFFK NCFBNFPHDDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly KDODPOMDMLE AJNDKJEAFOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly AOJKGOIKJDH GKHNDPHBOFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly JNELLCEAEHD CPNMCCKHCAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly AACKACLGNHJ EBAAIMJBJPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly LHGAOOLBKEB FICGBLBBAND;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly AOECBKAPKIF ALEJIBBDDGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly LKKACGOMJHM AEMENHIGDPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly JCHOGLGKCJJ<KeepsakesConfig.KeepsakesOptions> AFJJJNJGALF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly IIOGDLIHHEO GKOIAJLIOIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly Dictionary<Guid, KeepsakeInstanceDTO> LDPEMPENHBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly HashSet<Guid> KKCIOJHCCDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly HashSet<long> BHKPBMDDEBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private Dictionary<JDOMPGJPOEI, int> OHEMGGECFIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly HashSet<Guid> CONFHAAOOLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly IDisposable GBHLIGPDGEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private Task HPMEDMKPGEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private GFHJFJDJPFP<Guid> HACBKKIHBEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private long? JMPOCDFNDIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private KeepsakeProgressionEventInstancesDTO CLKAHANDPAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private GFHJFJDJPFP<KeepsakeProgressionEventInstancesDTO> ONFDFECKMDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private IReadOnlyDictionary<JDOMPGJPOEI, KeepsakeCategoryConfigDTO> DJHHKNOCBMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private KeepsakeGlobalConfigDTO FCDBFPGODIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private HashSet<long> EGBOGOMEBIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private HashSet<long> CCDCJBKMIBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private List<KeepsakeRoomListDTO> MFHHPHPODKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private List<KeepsakeRoomListDTO> OEIDMDCEIGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private List<KeepsakeRoomListDTO> KNDBDCLJDEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private Dictionary<long, string> EDAOAGBJGDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private Dictionary<long, string> KPIOCLPLPNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private Dictionary<long, DateTime> OINDHJCEJHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private Dictionary<long, List<KeepsakeRoomDTO>> GAGMLEFGJKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private Dictionary<long, List<KeepsakeRoomDTO>> NADNPOKAKFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private Dictionary<long, long> OBIPLIIGENH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly List<string> MHECCGAPBNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private DateTime IDNCBPOLNGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly IDisposable CJCOFNBALIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private Dictionary<Guid, JDOMPGJPOEI> GHKMIEPBCGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private Dictionary<JDOMPGJPOEI, int> PECJGMLBJKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private List<KeepsakeCategoryThemePair> NFFJEALOJDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private JGNKGDHOONP AMIMHMNDGKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private bool FHPOEPJIJLE;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool DEEHMBBNFIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA2F4A0", Offset = "0xA2E6A0", VA = "0x180A2F4A0", Slot = "53")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA2F2C0", Offset = "0xA2E4C0", VA = "0x180A2F2C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool BBGBPFCJGMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7C9B310", Offset = "0x7C9A510", VA = "0x187C9B310", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool CPJIAGNFLKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7CA4AF0", Offset = "0x7CA3CF0", VA = "0x187CA4AF0", Slot = "36")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private long HBJPHEHILJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7C9CF10", Offset = "0x7C9C110", VA = "0x187C9CF10")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private long? OMECFKNIOKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7C9F070", Offset = "0x7C9E270", VA = "0x187C9F070")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private bool GNPBNFGHFNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7C9FC80", Offset = "0x7C9EE80", VA = "0x187C9FC80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public IReadOnlyList<KeepsakeRoomListDTO> MJAOMAGEMLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xB07AD0", Offset = "0xB06CD0", VA = "0x180B07AD0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public IReadOnlyList<KeepsakeRoomListDTO> PCMPFMMAOML
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xB067F0", Offset = "0xB059F0", VA = "0x180B067F0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IReadOnlyList<KeepsakeRoomListDTO> NAIAIOHIHNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xB20000", Offset = "0xB1F200", VA = "0x180B20000", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public IReadOnlyDictionary<long, string> KFBDIKDPNFG
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xB14690", Offset = "0xB13890", VA = "0x180B14690", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	internal bool NALANHHCPFP
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xBF2F50", Offset = "0xBF2150", VA = "0x180BF2F50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Guid?> BBCEMMKEACO
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7C9AAF0", Offset = "0x7C99CF0", VA = "0x187C9AAF0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7C9B6F0", Offset = "0x7C9A8F0", VA = "0x187C9B6F0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action FMGDLMENEEA
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7CA0980", Offset = "0x7C9FB80", VA = "0x187CA0980", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7CA0D10", Offset = "0x7C9FF10", VA = "0x187CA0D10", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action CGKPAIBILEF
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7C9E360", Offset = "0x7C9D560", VA = "0x187C9E360", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7C9F5E0", Offset = "0x7C9E7E0", VA = "0x187C9F5E0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7CA6B90", Offset = "0x7CA5D90", VA = "0x187CA6B90")]
	[RecRoom.NoEngine.Common.Preserve]
	internal GIBOAICCGPK([NGLIAOPBMFM(null)][NotNull] AMKPCHCHDLI ADABLGGDMDI, [NotNull][NGLIAOPBMFM(null)] FAMJNCFEMOB NNPMIHDHFPD, [NotNull][NGLIAOPBMFM(null)] MKKJDGBEGLC HHEJFGGCDFD, [NotNull][NGLIAOPBMFM(null)] PANKMIFEGDJ BJGBGNLOBNJ, [NGLIAOPBMFM(null)][NotNull] DHLHPBIKGGG EKGMHLMCNAG, [NGLIAOPBMFM(null)][NotNull] GAPAGLFJNJK IKFFOMHBDLM, [NGLIAOPBMFM(null)][NotNull] JKNFMCKPNHB LILOKELBBCO, [NotNull][NGLIAOPBMFM(null)] FMJDBDONLDC DJOOOBHJMCJ, [NotNull][NGLIAOPBMFM(null)] AGONIDGIFFK NCFBNFPHDDJ, [NotNull][NGLIAOPBMFM(null)] GIOPBGIKLHH CAIBHGLDKPB, [NotNull][NGLIAOPBMFM(null)] KDODPOMDMLE AJNDKJEAFOK, [NotNull][NGLIAOPBMFM(null)] AOJKGOIKJDH GKHNDPHBOFG, [NotNull][NGLIAOPBMFM(null)] JNELLCEAEHD CPNMCCKHCAA, [NotNull][NGLIAOPBMFM(null)] AACKACLGNHJ EBAAIMJBJPK, [NGLIAOPBMFM(null)][NotNull] LHGAOOLBKEB FICGBLBBAND, [NGLIAOPBMFM(null)][NotNull] AOECBKAPKIF ALEJIBBDDGF, [NotNull][NGLIAOPBMFM(null)] LKKACGOMJHM AEMENHIGDPD, [NGLIAOPBMFM(null)][NotNull] JCHOGLGKCJJ<KeepsakesConfig.KeepsakesOptions> AFJJJNJGALF, [NotNull][NGLIAOPBMFM(null)] IIOGDLIHHEO GKOIAJLIOIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7C9DE20", Offset = "0x7C9D020", VA = "0x187C9DE20", Slot = "15")]
	public bool FKDBJHNAFMK(List<string> IEGJPLMPOIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7CA1F40", Offset = "0x7CA1140", VA = "0x187CA1F40", Slot = "16")]
	public GFHJFJDJPFP<Guid> LJLMINNNJGI(JDOMPGJPOEI OKOMECGCMED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7C9F260", Offset = "0x7C9E460", VA = "0x187C9F260", Slot = "17")]
	public IFBEDABPFIF HOHJHFPNGFO(Guid ILGEEOKLNJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7C9A250", Offset = "0x7C99450", VA = "0x187C9A250", Slot = "18")]
	public IFBEDABPFIF AIJLLMGCENB(Guid ILGEEOKLNJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7CA4CC0", Offset = "0x7CA3EC0", VA = "0x187CA4CC0", Slot = "19")]
	public bool OBEKNIOLLIP(Guid ILGEEOKLNJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7C9B7A0", Offset = "0x7C9A9A0", VA = "0x187C9B7A0", Slot = "20")]
	public bool CKIKCBLBKNP(Guid ILGEEOKLNJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7C9D2D0", Offset = "0x7C9C4D0", VA = "0x187C9D2D0")]
	public KeepsakeTheme ENJDOFEEFPK(Guid ILGEEOKLNJP)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7CA5A20", Offset = "0x7CA4C20", VA = "0x187CA5A20")]
	public bool OPICPGKGDGK(JDOMPGJPOEI OKOMECGCMED, [Out] KeepsakeTheme EKPKMMLDHJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7C9D990", Offset = "0x7C9CB90", VA = "0x187C9D990")]
	public List<KeepsakeTheme> FJLEHMAEFBC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7CA3AA0", Offset = "0x7CA2CA0", VA = "0x187CA3AA0")]
	public int NJHANCMDJNP(JDOMPGJPOEI OKOMECGCMED)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7CA5E10", Offset = "0x7CA5010", VA = "0x187CA5E10")]
	public JDOMPGJPOEI PFOABDMHHID(Guid ILGEEOKLNJP)
	{
		return default(JDOMPGJPOEI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7C9D4C0", Offset = "0x7C9C6C0", VA = "0x187C9D4C0", Slot = "34")]
	public List<JDOMPGJPOEI> FAOGFAFDBIE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7CA13E0", Offset = "0x7CA05E0", VA = "0x187CA13E0", Slot = "35")]
	public IComparer<JDOMPGJPOEI> KKNEDADHGPC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7C9B570", Offset = "0x7C9A770", VA = "0x187C9B570", Slot = "32")]
	public string CJCELGJPMCA(JDOMPGJPOEI OKOMECGCMED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7C9E0B0", Offset = "0x7C9D2B0", VA = "0x187C9E0B0", Slot = "33")]
	public string FKIHPAPJGFM(JDOMPGJPOEI OKOMECGCMED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7C9D040", Offset = "0x7C9C240", VA = "0x187C9D040", Slot = "21")]
	public bool EKGAMBHPEIL(Guid ILGEEOKLNJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7C9B360", Offset = "0x7C9A560", VA = "0x187C9B360", Slot = "22")]
	public void BONIIBDPIOL(Guid ILGEEOKLNJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7CA6900", Offset = "0x7CA5B00", VA = "0x187CA6900", Slot = "23")]
	public void POHPJIKBLDC(JDOMPGJPOEI OKOMECGCMED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7CA1770", Offset = "0x7CA0970", VA = "0x187CA1770", Slot = "24")]
	public void KNENMJBPFPA(Guid ILGEEOKLNJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7CA0E20", Offset = "0x7CA0020", VA = "0x187CA0E20", Slot = "25")]
	public int KJMODLFIGCP()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7CA6550", Offset = "0x7CA5750", VA = "0x187CA6550", Slot = "31")]
	public GFHJFJDJPFP<IEnumerable<Guid>> PNMDADMGNJL(long LADMAADOIBG, long KAPHMJCHJGH, JDOMPGJPOEI? OKOMECGCMED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7CA0A20", Offset = "0x7C9FC20", VA = "0x187CA0A20", Slot = "30")]
	public GFHJFJDJPFP<IEnumerable<Guid>> JLGNDDIDIAB(long LADMAADOIBG, long KAPHMJCHJGH, JDOMPGJPOEI? OKOMECGCMED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7CA0200", Offset = "0x7C9F400", VA = "0x187CA0200", Slot = "54")]
	public GFHJFJDJPFP<Dictionary<Guid, JDOMPGJPOEI>> IOBJNFPPPAB(long LADMAADOIBG, long KAPHMJCHJGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7CA57E0", Offset = "0x7CA49E0", VA = "0x187CA57E0", Slot = "55")]
	public GFHJFJDJPFP<Dictionary<Guid, JDOMPGJPOEI>> OKPOCPMFHDJ(long LADMAADOIBG, long KAPHMJCHJGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7CA2560", Offset = "0x7CA1760", VA = "0x187CA2560", Slot = "26")]
	public GFHJFJDJPFP<int> LPANFNGELDO(long LADMAADOIBG, long KAPHMJCHJGH, JDOMPGJPOEI? OKOMECGCMED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7C9B0E0", Offset = "0x7C9A2E0", VA = "0x187C9B0E0", Slot = "27")]
	public GFHJFJDJPFP<int> BNEMJLNGHMO(long LADMAADOIBG, long KAPHMJCHJGH, JDOMPGJPOEI? OKOMECGCMED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7CA5C00", Offset = "0x7CA4E00", VA = "0x187CA5C00", Slot = "28")]
	public GFHJFJDJPFP<Dictionary<JDOMPGJPOEI, int>> PCMPDPFJDJP(long LADMAADOIBG, long KAPHMJCHJGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7CA4E20", Offset = "0x7CA4020", VA = "0x187CA4E20", Slot = "29")]
	public GFHJFJDJPFP<Dictionary<JDOMPGJPOEI, int>> OCAEOKLNPPO(long LADMAADOIBG, long KAPHMJCHJGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7C9CFE0", Offset = "0x7C9C1E0", VA = "0x187C9CFE0", Slot = "37")]
	public bool EHNHENBNDOC(long LADMAADOIBG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7C9C700", Offset = "0x7C9B900", VA = "0x187C9C700", Slot = "56")]
	public bool EEHPKKKGLEL(long LADMAADOIBG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7C9FBE0", Offset = "0x7C9EDE0", VA = "0x187C9FBE0", Slot = "38")]
	public bool IDHFAKMNGAG(long LADMAADOIBG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7C9FC90", Offset = "0x7C9EE90", VA = "0x187C9FC90", Slot = "57")]
	public bool IHEHABOBFEF(long LADMAADOIBG, [Out] GOOBOCPGHLG CCPMIJHDDGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7CA6410", Offset = "0x7CA5610", VA = "0x187CA6410", Slot = "39")]
	public bool PLLFPNGNJNM(long GDMLHCEGIGH, [Out] DateTime HIBNDIIHHGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7C9C760", Offset = "0x7C9B960", VA = "0x187C9C760", Slot = "40")]
	public long EEKLLLLPLDD(long GDMLHCEGIGH)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7CA5070", Offset = "0x7CA4270", VA = "0x187CA5070", Slot = "41")]
	public long OHJLJGIBGDB(long LADMAADOIBG)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7CA5180", Offset = "0x7CA4380", VA = "0x187CA5180", Slot = "42")]
	public int OHPLEPEGCMC(long GDMLHCEGIGH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7C9DD40", Offset = "0x7C9CF40", VA = "0x187C9DD40", Slot = "43")]
	public bool FJODOKLJGEK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x7CA6A00", Offset = "0x7CA5C00", VA = "0x187CA6A00", Slot = "44")]
	public bool PPMHIBANHHI(long GDMLHCEGIGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7C9CCA0", Offset = "0x7C9BEA0", VA = "0x187C9CCA0", Slot = "45")]
	public IReadOnlyList<long> EGLMCLNACJH(long GDMLHCEGIGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7CA5970", Offset = "0x7CA4B70", VA = "0x187CA5970", Slot = "46")]
	public int OLKAOOCOBHF(long GDMLHCEGIGH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7C9ABA0", Offset = "0x7C99DA0", VA = "0x187C9ABA0", Slot = "50")]
	public long BGPCPBOAHAL(long GCMFNKELGOL)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7C9BBD0", Offset = "0x7C9ADD0", VA = "0x187C9BBD0", Slot = "51")]
	public JDOMPGJPOEI DLEEDFNHHDN()
	{
		return default(JDOMPGJPOEI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7C9E230", Offset = "0x7C9D430", VA = "0x187C9E230")]
	private bool FNBDPECKDEL(Guid ILGEEOKLNJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7C9E400", Offset = "0x7C9D600", VA = "0x187C9E400")]
	private void GHODPMGOOIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7CA14A0", Offset = "0x7CA06A0", VA = "0x187CA14A0")]
	private JDOMPGJPOEI KMHCCJIIBML()
	{
		return default(JDOMPGJPOEI);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7CA2A90", Offset = "0x7CA1C90", VA = "0x187CA2A90")]
	private void MNEBNPPEEDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7C9B3D0", Offset = "0x7C9A5D0", VA = "0x187C9B3D0")]
	private int CFFCAPFJIJG(KeepsakeRoomListDTO CFNMNBIGNHJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7CA5F70", Offset = "0x7CA5170", VA = "0x187CA5F70")]
	private int PIMNEDIOECL(DateTime NBMIGAILNDI, DateTime PCHDICFLNCA, TimeSpan BEKFKDPOLFN, int OMPLBIHNJBA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7C9E8C0", Offset = "0x7C9DAC0", VA = "0x187C9E8C0")]
	private void GIJBOOHJMFN(IEnumerable<KeepsakeInstanceDTO> LDPEMPENHBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7C9B990", Offset = "0x7C9AB90", VA = "0x187C9B990")]
	private void DIFEDKHPBFA(IEnumerable<KeepsakeCollectionRecordDTO> ACIEJNPMGFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7CA1EE0", Offset = "0x7CA10E0", VA = "0x187CA1EE0")]
	private void LGMHIGMFEDA(IEnumerable<long> CHOGIBGDHCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84C40", VA = "0x180A85A40")]
	private void IIDEOIGCIOA(KeepsakeGlobalConfigDTO FCDBFPGODIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7C9C4A0", Offset = "0x7C9B6A0", VA = "0x187C9C4A0")]
	private bool EAAANCBKFEB(JDOMPGJPOEI OKOMECGCMED, [Out] Guid JCNFFFIKGJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7C9AE60", Offset = "0x7C9A060", VA = "0x187C9AE60")]
	private bool BIODDDBAAAO([Out] Guid JCNFFFIKGJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7C9F200", Offset = "0x7C9E400", VA = "0x187C9F200")]
	private bool HMOMAKLELGM(Guid ILGEEOKLNJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x7CA0830", Offset = "0x7C9FA30", VA = "0x187CA0830")]
	private IEnumerable<Guid> JIIMLLBEKCC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7C9AA30", Offset = "0x7C99C30", VA = "0x187C9AA30")]
	private IEnumerable<KeepsakeInstanceDTO> BGBFFOIAEJB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7CA6950", Offset = "0x7CA5B50", VA = "0x187CA6950")]
	private void PPFBCIIPDAO(Guid ILGEEOKLNJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7C9D410", Offset = "0x7C9C610", VA = "0x187C9D410")]
	private bool EPMMFBLGMMB(Guid ILGEEOKLNJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7CA1240", Offset = "0x7CA0440", VA = "0x187CA1240")]
	private void KKEMDIBMKCP(Guid ILGEEOKLNJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7C9B230", Offset = "0x7C9A430", VA = "0x187C9B230")]
	private void BNPKPNILMCN(JDOMPGJPOEI JDEHBEJMLMF, int CLEPPKIENLN, Dictionary<JDOMPGJPOEI, int> BEFKEPEOOJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7CA0740", Offset = "0x7C9F940", VA = "0x187CA0740")]
	private int JELJBPIMDIH(JDOMPGJPOEI OKOMECGCMED)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7CA38D0", Offset = "0x7CA2AD0", VA = "0x187CA38D0")]
	private void NIFOBNPIJKG(KeepsakeInstanceDTO MBLJMOFPBOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7CA1CD0", Offset = "0x7CA0ED0", VA = "0x187CA1CD0")]
	private void LEGIPLLNACP(KeepsakeInstanceDTO MBLJMOFPBOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7C9F680", Offset = "0x7C9E880", VA = "0x187C9F680")]
	private void ICLONFPNEIM(Guid ILGEEOKLNJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7C9A5E0", Offset = "0x7C997E0", VA = "0x187C9A5E0")]
	private void IPHMCLLDECJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7C9A230", Offset = "0x7C99430", VA = "0x187C9A230")]
	private void AFAEOLDKCLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7CA0DB0", Offset = "0x7C9FFB0", VA = "0x187CA0DB0")]
	private void KGIMKLHIGKE(BAILLPCCAKA KABJBFJMJJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7C9A5E0", Offset = "0x7C997E0", VA = "0x187C9A5E0")]
	private void AKDODGCCCIL(LJHPEKBEACH KFMNDOMPAMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7C9A5E0", Offset = "0x7C997E0", VA = "0x187C9A5E0")]
	private void LACIPOPFDPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7CA6070", Offset = "0x7CA5270", VA = "0x187CA6070")]
	private void PLIONJFKNPE(float AKHINELDCBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x7CA30D0", Offset = "0x7CA22D0", VA = "0x187CA30D0")]
	private void MPGLFJEDMJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7CA2830", Offset = "0x7CA1A30", VA = "0x187CA2830")]
	private bool MFEMDIJNBLJ(Guid ILGEEOKLNJP, [Out] string DMLOEBILEKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7C9D600", Offset = "0x7C9C800", VA = "0x187C9D600")]
	private bool FBGIHOGOJDA(Guid ILGEEOKLNJP, [Out] KeepsakeCategoryConfigDTO JDEHBEJMLMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7C9F100", Offset = "0x7C9E300", VA = "0x187C9F100")]
	private void HAONOJAGNMG(string LIHGFEBAGDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7CA4BB0", Offset = "0x7CA3DB0", VA = "0x187CA4BB0")]
	private bool OAOFEOPBGIO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7CA1A10", Offset = "0x7CA0C10", VA = "0x187CA1A10")]
	private List<long> LCNPOFBLONA(IEnumerable<KeepsakeRoomDTO> JOJCNEHEGGE, IReadOnlyList<KeepsakeRoomListDTO> GEIPILPFGOH, long GDMLHCEGIGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x7C9EB50", Offset = "0x7C9DD50", VA = "0x187C9EB50")]
	private bool GMBCLCKEBOO(Guid ILGEEOKLNJP, [Out] string HKIJLMNBOAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7CA2A30", Offset = "0x7CA1C30", VA = "0x187CA2A30", Slot = "47")]
	public string MMMMPJIOJNN(PPDPMHOAAHK NLFNMLCIIIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x7C9A610", Offset = "0x7C99810", VA = "0x187C9A610", Slot = "49")]
	public string BAOMLPPCLIH(PPDPMHOAAHK NLFNMLCIIIA, long LADMAADOIBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7CA0C40", Offset = "0x7C9FE40", VA = "0x187CA0C40", Slot = "48")]
	public string KAOBMMLLDBG(PPDPMHOAAHK NLFNMLCIIIA, int GMLJDOHICKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x7CA3C20", Offset = "0x7CA2E20", VA = "0x187CA3C20")]
	private void NJMCPKCIOME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7CA05B0", Offset = "0x7C9F7B0", VA = "0x187CA05B0")]
	private void JBAGEGBMMEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x7CA69E0", Offset = "0x7CA5BE0", VA = "0x187CA69E0")]
	private PPDPMHOAAHK PPFIOOHFEJE(DMFGIKKONEO JMKENBHOEFA)
	{
		return default(PPDPMHOAAHK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x7CA4EE0", Offset = "0x7CA40E0", VA = "0x187CA4EE0")]
	private PPDPMHOAAHK ODHLAHJOABH(DMFGIKKONEO JMKENBHOEFA)
	{
		return default(PPDPMHOAAHK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7C9AF00", Offset = "0x7C9A100", VA = "0x187C9AF00")]
	internal static string BLFHIIAJHGA(KFBLIHNFHOH CGIFBLJGGGB, string MAMLCFAHKFC, bool DFAOFDKMOOK, int CKCHLDIEFAA, int LJMKGCEGJKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7C9C040", Offset = "0x7C9B240", VA = "0x187C9C040", Slot = "52")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x7CA0BC0", Offset = "0x7C9FDC0", VA = "0x187CA0BC0")]
	private ONOANLDBBEM KAHNIHLAJOK(BNFABCHNBCL GALNOKDLDNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7C9B7D0", Offset = "0x7C9A9D0", VA = "0x187C9B7D0")]
	private CBFAMDHOPFE DEPGNCMFMDI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7CA5430", Offset = "0x7CA4630", VA = "0x187CA5430")]
	private Task OKOFCDGDDEN(IMGOPGMMMDH CCEPNMMABPI, CancellationToken FHBCOAHILMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7C9BF30", Offset = "0x7C9B130", VA = "0x187C9BF30")]
	[AsyncStateMachine(typeof(MBBNJHBPGOC))]
	private Task DOBAPNBKNKG(IMGOPGMMMDH CCEPNMMABPI, CancellationToken FHBCOAHILMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7CA5360", Offset = "0x7CA4560", VA = "0x187CA5360")]
	private Task OICPDPMBNAG(IMGOPGMMMDH CCEPNMMABPI, CancellationToken FHBCOAHILMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7CA3670", Offset = "0x7CA2870", VA = "0x187CA3670")]
	[AsyncStateMachine(typeof(PBNNJHIFHFC))]
	private Task NALMMKGKHKB(string NPEJLHCJPAI, TimeSpan BIHKMGFMOGK, CancellationToken FHBCOAHILMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7C9F1E0", Offset = "0x7C9E3E0", VA = "0x187C9F1E0")]
	[CompilerGenerated]
	private void HHGBBGHEBJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7C9D940", Offset = "0x7C9CB40", VA = "0x187C9D940")]
	[CompilerGenerated]
	private void FDILEAICLAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7C9F4E0", Offset = "0x7C9E6E0", VA = "0x187C9F4E0")]
	[CompilerGenerated]
	private bool IABIBPKLDNC(KeepsakeInstanceDTO HGCMPGNMMIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7C9D7D0", Offset = "0x7C9C9D0", VA = "0x187C9D7D0")]
	[CompilerGenerated]
	private GFHJFJDJPFP<Dictionary<JDOMPGJPOEI, int>> FCOIBKKGBFI(Dictionary<Guid, JDOMPGJPOEI> PJGPPICIDLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x7CA4F00", Offset = "0x7CA4100", VA = "0x187CA4F00")]
	[CompilerGenerated]
	private GFHJFJDJPFP<Dictionary<JDOMPGJPOEI, int>> ODINFIMLJGA(Dictionary<Guid, JDOMPGJPOEI> PJGPPICIDLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7CA2810", Offset = "0x7CA1A10", VA = "0x187CA2810")]
	[CompilerGenerated]
	private bool MDBCBACIGNN(KeepsakeRoomListDTO HGCMPGNMMIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7CA37A0", Offset = "0x7CA29A0", VA = "0x187CA37A0")]
	[CompilerGenerated]
	private bool NGDHPHPCGBN(KeepsakeInstanceDTO HGCMPGNMMIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7C9FA50", Offset = "0x7C9EC50", VA = "0x187C9FA50")]
	[CompilerGenerated]
	private void IDDLJACLGHE(Tuple<KeepsakeRoomInstancesDTO, IReadOnlyDictionary<JDOMPGJPOEI, KeepsakeCategoryConfigDTO>, KeepsakeGlobalConfigDTO> MGKDBALIGKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7CA19B0", Offset = "0x7CA0BB0", VA = "0x187CA19B0")]
	[CompilerGenerated]
	private void LAEDOJBHLKH(string HKIJLMNBOAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x7CA0040", Offset = "0x7C9F240", VA = "0x187CA0040")]
	[CompilerGenerated]
	private Task IJDMAKLIKGO(CancellationToken OOPKGAMKFFK)
	{
		return null;
	}
}
namespace RecRoom.Keepsakes
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public class KeepsakesConfig : ScriptableObject, JCHOGLGKCJJ<KeepsakesConfig.KeepsakesOptions>
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200002B")]
		public class KeepsakesOptions
		{
			[Cpp2IlInjected.Token(Token = "0x200002C")]
			[CompilerGenerated]
			private sealed class ODIOKONNBCN
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000098")]
				public string themeId;

				[Cpp2IlInjected.Token(Token = "0x60000F3")]
				[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
				public ODIOKONNBCN()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000F4")]
				[Cpp2IlInjected.Address(RVA = "0x7CA9440", Offset = "0x7CA8640", VA = "0x187CA9440")]
				internal bool KMJADALGPIL(KeepsakeTheme x)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60000F5")]
				[Cpp2IlInjected.Address(RVA = "0x7CA9440", Offset = "0x7CA8640", VA = "0x187CA9440")]
				internal bool MCFHPNIIGPE(KeepsakeTheme x)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			[SerializeField]
			private KeepsakeTheme[] themes;

			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x7CA86C0", Offset = "0x7CA78C0", VA = "0x187CA86C0")]
			public bool PICCPGONMEM(string FOFNKPMEPKE, [Out] KeepsakeTheme EKPKMMLDHJJ)
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
			[Cpp2IlInjected.Address(RVA = "0xA00BA0", Offset = "0x9FFDA0", VA = "0x180A00BA0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x7CA8640", Offset = "0x7CA7840", VA = "0x187CA8640")]
		[MGCKGAIBEHC.PCMIGKEOIEO.MAPPJIPMPIK]
		internal static void LDPAGBHHOJF(FJCFOKJAKFO MBLPEFIMNGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0xC19EC0", Offset = "0xC190C0", VA = "0x180C19EC0")]
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
