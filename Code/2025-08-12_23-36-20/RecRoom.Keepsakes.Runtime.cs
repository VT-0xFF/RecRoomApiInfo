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
		[Cpp2IlInjected.Address(RVA = "0x83DE2C0", Offset = "0x83DD0C0", VA = "0x1883DE2C0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2941360", Offset = "0x2940160", VA = "0x182941360")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class EELOKPNIIPC : IComparer<PEIKCOPGDKJ>
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private sealed class JELDMBBFLJG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public PEIKCOPGDKJ x;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public PEIKCOPGDKJ y;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public JELDMBBFLJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xE724A0", Offset = "0xE712A0", VA = "0x180E724A0")]
		internal bool LLGBBIAOOGE(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x21C2B10", Offset = "0x21C1910", VA = "0x1821C2B10")]
		internal bool AGMFDNNIJBN(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xE724A0", Offset = "0xE712A0", VA = "0x180E724A0")]
		internal bool JLFHHJIDCLK(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x21C2B10", Offset = "0x21C1910", VA = "0x1821C2B10")]
		internal bool CNBOFDKODBI(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private List<KeepsakeCategoryThemePair> HODMLODOGOI;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0xA9BE10", Offset = "0xA9AC10", VA = "0x180A9BE10")]
	public EELOKPNIIPC(List<KeepsakeCategoryThemePair> IFHJIOBEEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x83CE4D0", Offset = "0x83CD2D0", VA = "0x1883CE4D0", Slot = "4")]
	public int Compare(PEIKCOPGDKJ DBBMOEGPNPP, PEIKCOPGDKJ COFKGIHGCOO)
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
		public PEIKCOPGDKJ KeepsakeCategory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public KeepsakeTheme KeepsakeTheme;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[CMNOLHHFBOP]
public class OJJHCEACGFO : HCFJKHLMHDM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class PIGIFEMJOMJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public OJJHCEACGFO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public PEIKCOPGDKJ keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public PIGIFEMJOMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x83DD9E0", Offset = "0x83DC7E0", VA = "0x1883DD9E0")]
		internal AIKJELDGMEB<Guid> ICFJJKBNONM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x83DD950", Offset = "0x83DC750", VA = "0x1883DD950")]
		internal void BDJOBGBOFOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x83DD980", Offset = "0x83DC780", VA = "0x1883DD980")]
		internal void EOJCPCBBNHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x83DDB70", Offset = "0x83DC970", VA = "0x1883DDB70")]
		internal void MMPAHKIJELG(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x83DDB40", Offset = "0x83DC940", VA = "0x1883DDB40")]
		internal void JCNMJGIAKGO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class DECCNDLEOBJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public OJJHCEACGFO <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public DECCNDLEOBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x83CDFB0", Offset = "0x83CCDB0", VA = "0x1883CDFB0")]
		internal void CFJGAPIKOGL(KIALFEGMEJE response)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x83CDF50", Offset = "0x83CCD50", VA = "0x1883CDF50")]
		internal void AENIBNAOFFP(string error)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class BJEPDJJCNNM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public KeepsakeTheme theme;

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public BJEPDJJCNNM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x83CD310", Offset = "0x83CC110", VA = "0x1883CD310")]
		internal bool FLLGOJBGBDO(KeepsakeCategoryThemePair categoryThemePair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class BEADABKIFKD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public OJJHCEACGFO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public long progressionEventId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public PEIKCOPGDKJ? keepsakeCategory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public BEADABKIFKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x83CCF20", Offset = "0x83CBD20", VA = "0x1883CCF20")]
		internal void JEDLDFFMFOH(KeepsakeProgressionEventInstancesDTO result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x83CCEF0", Offset = "0x83CBCF0", VA = "0x1883CCEF0")]
		internal void IKHAGGIFAAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x83CCFB0", Offset = "0x83CBDB0", VA = "0x1883CCFB0")]
		internal AIKJELDGMEB<IEnumerable<Guid>> POJDNEPACAB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x7EC8430", Offset = "0x7EC7230", VA = "0x187EC8430")]
		internal bool OKGCMIHAOEN(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class NMKKIONOODH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public KeepsakeRoomInstanceIdsDTO instancesInRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public BEADABKIFKD CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public NMKKIONOODH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x83CF710", Offset = "0x83CE510", VA = "0x1883CF710")]
		internal AIKJELDGMEB<IEnumerable<Guid>> NFGFLIJIIPO(KeepsakeRoomInstancesDTO roomInstancesDTO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class PNPKDGLLBCJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public KeepsakeRoomInstancesDTO roomInstancesDTO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public NMKKIONOODH CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public PNPKDGLLBCJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x83DDF80", Offset = "0x83DCD80", VA = "0x1883DDF80")]
		internal bool MCHFKEIBHKM(Guid instanceId)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class EBDGFOEJJAC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Guid instanceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public PNPKDGLLBCJ CS$<>8__locals3;

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public EBDGFOEJJAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x83CE420", Offset = "0x83CD220", VA = "0x1883CE420")]
		internal bool LALDFOGFAGN(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class FOOACKJKKOD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public OJJHCEACGFO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public FOOACKJKKOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x83CE930", Offset = "0x83CD730", VA = "0x1883CE930")]
		internal AIKJELDGMEB<IEnumerable<Guid>> ADANBELFFOL(IEnumerable<Guid> instanceIds)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x83CD330", Offset = "0x83CC130", VA = "0x1883CD330")]
		internal bool HDGPLKPKOBK(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class CPLPCPPBICL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public OJJHCEACGFO <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public CPLPCPPBICL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x83CDDD0", Offset = "0x83CCBD0", VA = "0x1883CDDD0")]
		internal void EDINMPJBAGB(KeepsakeProgressionEventInstancesDTO result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x83CCEF0", Offset = "0x83CBCF0", VA = "0x1883CCEF0")]
		internal void ECKOIFGPEGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x83CDAE0", Offset = "0x83CC8E0", VA = "0x1883CDAE0")]
		internal AIKJELDGMEB<Dictionary<Guid, PEIKCOPGDKJ>> EDDDJGFJKGB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x7EC8430", Offset = "0x7EC7230", VA = "0x187EC8430")]
		internal bool IONGKBLJMFJ(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class EILAGHJMIGN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public KeepsakeRoomInstanceIdsDTO instancesInRoom;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public EILAGHJMIGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x83CE780", Offset = "0x83CD580", VA = "0x1883CE780")]
		internal AIKJELDGMEB<Dictionary<Guid, PEIKCOPGDKJ>> MPGOKICNHGI(KeepsakeRoomInstancesDTO roomInstancesDTO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class KHOIFLGMIIO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public KeepsakeRoomInstancesDTO roomInstancesDTO;

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public KHOIFLGMIIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x83CF1E0", Offset = "0x83CDFE0", VA = "0x1883CF1E0")]
		internal bool DAFGFEMMKBK(Guid instanceId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x83CF2C0", Offset = "0x83CE0C0", VA = "0x1883CF2C0")]
		internal KeyValuePair<Guid, PEIKCOPGDKJ> HEJOIGIIEGL(Guid instanceId)
		{
			return default(KeyValuePair<Guid, PEIKCOPGDKJ>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class DBCKEAHDGKN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public Guid instanceId;

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public DBCKEAHDGKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x101E3E0", Offset = "0x101D1E0", VA = "0x18101E3E0")]
		internal bool HOIPDHAOALL(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class MBHKLIBNPEN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public Guid instanceId;

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public MBHKLIBNPEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x101E3E0", Offset = "0x101D1E0", VA = "0x18101E3E0")]
		internal bool JCEGGNKPLEN(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class BOAHNIEIJOF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public OJJHCEACGFO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public BOAHNIEIJOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x83CD350", Offset = "0x83CC150", VA = "0x1883CD350")]
		internal AIKJELDGMEB<Dictionary<Guid, PEIKCOPGDKJ>> LNHIHLNPLGA(Dictionary<Guid, PEIKCOPGDKJ> instanceIdsAndCategories)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x83CD330", Offset = "0x83CC130", VA = "0x1883CD330")]
		internal bool LKCOPCEJJFJ(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class GDMNCKLLCBD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public KeepsakeRoomInstanceIdsDTO collectedInstanceIds;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public GDMNCKLLCBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x83CEAA0", Offset = "0x83CD8A0", VA = "0x1883CEAA0")]
		internal bool ONEEAJJGJDB(KeyValuePair<Guid, PEIKCOPGDKJ> idCategoryPair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class HDGNBMHLLDG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public Dictionary<Guid, PEIKCOPGDKJ> instanceIdsAndCategories;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public HDGNBMHLLDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x83CEB20", Offset = "0x83CD920", VA = "0x1883CEB20")]
		internal KeyValuePair<PEIKCOPGDKJ, int> MLGNBJKOLIP(PEIKCOPGDKJ category)
		{
			return default(KeyValuePair<PEIKCOPGDKJ, int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class IKINBGILPMP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public PEIKCOPGDKJ category;

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public IKINBGILPMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0xF96BA0", Offset = "0xF959A0", VA = "0x180F96BA0")]
		internal bool BJDEICFGNJA(PEIKCOPGDKJ instanceCategory)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class PGIHCPIJNFD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public Dictionary<Guid, PEIKCOPGDKJ> instanceIdsAndCategories;

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public PGIHCPIJNFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x83DD780", Offset = "0x83DC580", VA = "0x1883DD780")]
		internal KeyValuePair<PEIKCOPGDKJ, int> HGKNCLELGEG(PEIKCOPGDKJ category)
		{
			return default(KeyValuePair<PEIKCOPGDKJ, int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class AOLGINMCDAK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public PEIKCOPGDKJ category;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public AOLGINMCDAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0xF96BA0", Offset = "0xF959A0", VA = "0x180F96BA0")]
		internal bool LBCLLMNNEHO(PEIKCOPGDKJ instanceCategory)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class IIKCPGJJIMI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public OJJHCEACGFO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public Func<KeepsakeRoomDTO, bool> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public IIKCPGJJIMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x83CF050", Offset = "0x83CDE50", VA = "0x1883CF050")]
		internal bool LCAGDDIGCFO(DateTime nowUtc, DateTime eventStartTime, int roomOrder, TimeSpan unlockStartOffset, TimeSpan unlockInterval, int unlockBatchSize)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x83CEF90", Offset = "0x83CDD90", VA = "0x1883CEF90")]
		internal bool DFGJMPMBJKP(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x83CEF70", Offset = "0x83CDD70", VA = "0x1883CEF70")]
		internal bool BDEPIKDPLFL(KeepsakeRoomDTO r)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x83CEF70", Offset = "0x83CDD70", VA = "0x1883CEF70")]
		internal bool HBHEBGNBDML(KeepsakeRoomDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class CKEEJIFJKNO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public CKEEJIFJKNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0xFF25A0", Offset = "0xFF13A0", VA = "0x180FF25A0")]
		internal bool FLDFBCNDGLN(KeepsakeRoomListDTO roomList)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class DFMHGFBHHPA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public Func<KeepsakeRoomDTO, bool> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public DFMHGFBHHPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x83CE360", Offset = "0x83CD160", VA = "0x1883CE360")]
		internal bool LKAIFKOMMKD(KeepsakeRoomListDTO roomList)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x280E760", Offset = "0x280D560", VA = "0x18280E760")]
		internal bool LLLJBEMPOEB(KeepsakeRoomDTO room)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class INFOFMKKIMI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public INFOFMKKIMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x83CF140", Offset = "0x83CDF40", VA = "0x1883CF140")]
		internal bool BLFJJLDOKHP(KeepsakeRoomListDTO i)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class EOMCPCIOIJH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public EOMCPCIOIJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0xFF25A0", Offset = "0xFF13A0", VA = "0x180FF25A0")]
		internal bool FMIPHBEIAEP(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class BIPJMDLCDPP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public Guid keepsakeInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public BIPJMDLCDPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x83CD2B0", Offset = "0x83CC0B0", VA = "0x1883CD2B0")]
		internal bool CEIAFEMGDHL(KeyValuePair<Guid, KeepsakeInstanceDTO> instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class HOANPGICABE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public PEIKCOPGDKJ keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public HOANPGICABE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x2412980", Offset = "0x2411780", VA = "0x182412980")]
		internal bool KADPOOLOGNE(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class AACNELLHBEJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public Guid keepsakeInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public AACNELLHBEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x83CCE90", Offset = "0x83CBC90", VA = "0x1883CCE90")]
		internal bool HJNNIEMJMLP(KeyValuePair<Guid, KeepsakeInstanceDTO> instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class JLGEABHLKCA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public PEIKCOPGDKJ keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public JLGEABHLKCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x83CF1A0", Offset = "0x83CDFA0", VA = "0x1883CF1A0")]
		internal bool JKAAFIMAHLD(KeyValuePair<Guid, PEIKCOPGDKJ> x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class FBKFALNDFEN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public PEIKCOPGDKJ newKeepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public FBKFALNDFEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x2412980", Offset = "0x2411780", VA = "0x182412980")]
		internal bool FFMKNEMAPND(KeepsakeInstanceDTO instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class PHPMHEMONMG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public long currentRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public long? currentSubRoomId;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public PHPMHEMONMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x83DD8D0", Offset = "0x83DC6D0", VA = "0x1883DD8D0")]
		internal bool KHEPIHHNEFL(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class DDJIEPBCKAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public IReadOnlyList<KeepsakeRoomListDTO> roomList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public DDJIEPBCKAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x83CDE60", Offset = "0x83CCC60", VA = "0x1883CDE60")]
		internal bool FPBEDKCGGGF(KeepsakeRoomDTO room)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class KPGGPBKDHGJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public KeepsakeRoomDTO room;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public DDJIEPBCKAB CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public KPGGPBKDHGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x83CF410", Offset = "0x83CE210", VA = "0x1883CF410")]
		internal bool PCLAIBEMBAB(KeepsakeRoomListDTO roomListDto)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private struct CMEFCACDFNK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public OJJHCEACGFO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public CHNMCCPJHLL args;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x83CD550", Offset = "0x83CC350", VA = "0x1883CD550", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x83CDA80", Offset = "0x83CC880", VA = "0x1883CDA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private struct HPKCFCNHPJG : IAsyncStateMachine
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
		public OJJHCEACGFO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public string message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x83CEC70", Offset = "0x83CDA70", VA = "0x1883CEC70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x83CEF10", Offset = "0x83CDD10", VA = "0x1883CEF10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly DateTime PHEOBPNCGHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly DELLFAEAFKP KEBINCNCFMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly DALJIDIBNIM OFLDIGPKMLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly EEHMLFIFDEC DJHOMELDFHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly GGPEDCBJGNB CGKAMFPFHBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly FPFANPNLBJN HGNBPILIDCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly IICNAAJFEHA BCIIKEJLELG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly IGMEPLKOBCH MLMNKBBPKNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly NLCNBLMKPKF LPOEOKNKAFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly ALDABFJJHPA OHBOEBMKKFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly AIDNNGNBHDL INIHFFLIIPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly IEKKMGGMCFO AJFHOEIPDIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly KIBCJDIOIPA HHJGKIGNEEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly ELAOGMGNFOO KFOIDAEMKKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly PINAEHPKMOD NFBOHICHICD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly ODEBHGOALGK NJIBFENKDOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly DLJMDABIBDF<KeepsakesConfig.KeepsakesOptions> PMEODJMCJOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly CEDIOCPLCGJ OOMNLGEDCIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly Dictionary<Guid, KeepsakeInstanceDTO> CAAGBHPEMKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly HashSet<Guid> GOOLMLDMKIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly HashSet<long> NCCLKCHIDMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private Dictionary<PEIKCOPGDKJ, int> NGKOPEOGLCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly HashSet<Guid> JHDHOAOHPHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly IDisposable BLOOCBHPGNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private Task DFDCAHHLJOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private AIKJELDGMEB<Guid> IEHOEJFPEOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private long? MDKAJIEBKCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private KeepsakeProgressionEventInstancesDTO APEPBEBKLMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private AIKJELDGMEB<KeepsakeProgressionEventInstancesDTO> KEAGOIJJPDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private IReadOnlyDictionary<PEIKCOPGDKJ, KeepsakeCategoryConfigDTO> JGCBHDHPMNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private KeepsakeGlobalConfigDTO AKJIECPEOAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private HashSet<long> LCPKJFFGHIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private HashSet<long> HOAIIMDGBJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private List<KeepsakeRoomListDTO> EIEDFCBHGON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private List<KeepsakeRoomListDTO> MPIIEOMOOIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private List<KeepsakeRoomListDTO> CPDHPNMCGPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private Dictionary<long, string> JKGHBPJCJIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private Dictionary<long, string> IOBGHHMBDAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private Dictionary<long, DateTime> HBNMDMHODHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private Dictionary<long, List<KeepsakeRoomDTO>> HLNAIJALDPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private Dictionary<long, List<KeepsakeRoomDTO>> NCADCAEEIEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private Dictionary<long, long> COMHMEBGOCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly List<string> FLGCLDHHIGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private DateTime DLELFBDKNHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly IDisposable MHNFNCGPNGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private Dictionary<Guid, PEIKCOPGDKJ> IHBBEBKPCDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private Dictionary<PEIKCOPGDKJ, int> CLIODFELLEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private List<KeepsakeCategoryThemePair> IFHJIOBEEML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private EELOKPNIIPC AAMBOGDNEPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private bool MLEAOCDPKLF;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool IINCFNJIHGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xAC2580", Offset = "0xAC1380", VA = "0x180AC2580", Slot = "53")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xAC2300", Offset = "0xAC1100", VA = "0x180AC2300")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool ABOGNDEAOPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x83DBA00", Offset = "0x83DA800", VA = "0x1883DBA00", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool NBLEDOKIDFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x83D9AA0", Offset = "0x83D88A0", VA = "0x1883D9AA0", Slot = "36")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private long CJHJHJNBHDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x83CF850", Offset = "0x83CE650", VA = "0x1883CF850")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private long? LDCAAFFEJJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x83D52E0", Offset = "0x83D40E0", VA = "0x1883D52E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private bool ONEBKKFECJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x83D7070", Offset = "0x83D5E70", VA = "0x1883D7070")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public IReadOnlyList<KeepsakeRoomListDTO> LIANDIIAFIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xC0A400", Offset = "0xC09200", VA = "0x180C0A400", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public IReadOnlyList<KeepsakeRoomListDTO> CACEGFFDCOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xC11470", Offset = "0xC10270", VA = "0x180C11470", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IReadOnlyList<KeepsakeRoomListDTO> DAMMGJIKELC
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xC1CF50", Offset = "0xC1BD50", VA = "0x180C1CF50", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public IReadOnlyDictionary<long, string> IPMOLEKELPO
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xC0FA30", Offset = "0xC0E830", VA = "0x180C0FA30", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	internal bool FEEHLMJCEGB
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xB6C950", Offset = "0xB6B750", VA = "0x180B6C950")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Guid?> JGGEIFIGIID
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x83D03E0", Offset = "0x83CF1E0", VA = "0x1883D03E0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x83DB7E0", Offset = "0x83DA5E0", VA = "0x1883DB7E0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action BMGOMKMBCGM
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x83DAA30", Offset = "0x83D9830", VA = "0x1883DAA30", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x83D2B60", Offset = "0x83D1960", VA = "0x1883D2B60", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action IHOOMPIDAIL
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x83D0340", Offset = "0x83CF140", VA = "0x1883D0340", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x83D4370", Offset = "0x83D3170", VA = "0x1883D4370", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x83DC1B0", Offset = "0x83DAFB0", VA = "0x1883DC1B0")]
	[RecRoom.NoEngine.Common.Preserve]
	internal OJJHCEACGFO([POMNKOCGGBN(null)][NotNull] DELLFAEAFKP KEBINCNCFMO, [NotNull][POMNKOCGGBN(null)] NFGFJOGJHBJ IMHHOFCJJBO, [NotNull][POMNKOCGGBN(null)] DALJIDIBNIM OFLDIGPKMLO, [NotNull][POMNKOCGGBN(null)] EEHMLFIFDEC DJHOMELDFHD, [POMNKOCGGBN(null)][NotNull] GGPEDCBJGNB CGKAMFPFHBJ, [POMNKOCGGBN(null)][NotNull] FPFANPNLBJN HGNBPILIDCC, [POMNKOCGGBN(null)][NotNull] IICNAAJFEHA BCIIKEJLELG, [NotNull][POMNKOCGGBN(null)] IGMEPLKOBCH MLMNKBBPKNB, [NotNull][POMNKOCGGBN(null)] NLCNBLMKPKF LPOEOKNKAFK, [NotNull][POMNKOCGGBN(null)] JIJKLEDFEOJ EMKNKADMMKF, [NotNull][POMNKOCGGBN(null)] ALDABFJJHPA OHBOEBMKKFD, [NotNull][POMNKOCGGBN(null)] AIDNNGNBHDL INIHFFLIIPD, [NotNull][POMNKOCGGBN(null)] IEKKMGGMCFO AJFHOEIPDIK, [NotNull][POMNKOCGGBN(null)] KIBCJDIOIPA HHJGKIGNEEF, [POMNKOCGGBN(null)][NotNull] ELAOGMGNFOO KFOIDAEMKKE, [POMNKOCGGBN(null)][NotNull] PINAEHPKMOD NFBOHICHICD, [NotNull][POMNKOCGGBN(null)] ODEBHGOALGK NJIBFENKDOM, [POMNKOCGGBN(null)][NotNull] DLJMDABIBDF<KeepsakesConfig.KeepsakesOptions> PMEODJMCJOL, [NotNull][POMNKOCGGBN(null)] CEDIOCPLCGJ OOMNLGEDCIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x83D6BB0", Offset = "0x83D59B0", VA = "0x1883D6BB0", Slot = "15")]
	public bool JFMMKGPDKLJ(List<string> LBKAEKNPEKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x83D05E0", Offset = "0x83CF3E0", VA = "0x1883D05E0", Slot = "16")]
	public AIKJELDGMEB<Guid> BEOHHGCGFKH(PEIKCOPGDKJ AKMAFPBEIMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x83D6930", Offset = "0x83D5730", VA = "0x1883D6930", Slot = "17")]
	public BFMPGGMMDDD JFCCLCGOLOA(Guid CHAPBCKABGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x83D3B80", Offset = "0x83D2980", VA = "0x1883D3B80", Slot = "18")]
	public BFMPGGMMDDD DPBLJJMIAOP(Guid CHAPBCKABGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x83CFD70", Offset = "0x83CEB70", VA = "0x1883CFD70", Slot = "19")]
	public bool AKJAMDDDFGI(Guid CHAPBCKABGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x83D1390", Offset = "0x83D0190", VA = "0x1883D1390", Slot = "20")]
	public bool BLDBFEEIJGK(Guid CHAPBCKABGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x83D3670", Offset = "0x83D2470", VA = "0x1883D3670")]
	public KeepsakeTheme DGCIHAGMCNM(Guid CHAPBCKABGN)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x83CFED0", Offset = "0x83CECD0", VA = "0x1883CFED0")]
	public bool AKPHIHOBJGM(PEIKCOPGDKJ AKMAFPBEIMM, [Out] KeepsakeTheme FDEEFGOPKEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x83D94F0", Offset = "0x83D82F0", VA = "0x1883D94F0")]
	public List<KeepsakeTheme> MBMEJPNDCGH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x83D8230", Offset = "0x83D7030", VA = "0x1883D8230")]
	public int KOOMPKHOCAG(PEIKCOPGDKJ AKMAFPBEIMM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x83D9080", Offset = "0x83D7E80", VA = "0x1883D9080")]
	public PEIKCOPGDKJ LPOJJLOJKCG(Guid CHAPBCKABGN)
	{
		return default(PEIKCOPGDKJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x83D2A20", Offset = "0x83D1820", VA = "0x1883D2A20", Slot = "34")]
	public List<PEIKCOPGDKJ> COCNMOMPICK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x83D2880", Offset = "0x83D1680", VA = "0x1883D2880", Slot = "35")]
	public IComparer<PEIKCOPGDKJ> CMGEDNKPFGN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x83D5A20", Offset = "0x83D4820", VA = "0x1883D5A20", Slot = "32")]
	public string GPAHHMHAIEG(PEIKCOPGDKJ AKMAFPBEIMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x83CFBF0", Offset = "0x83CE9F0", VA = "0x1883CFBF0", Slot = "33")]
	public string AFHPCJAIGNB(PEIKCOPGDKJ AKMAFPBEIMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x83D47B0", Offset = "0x83D35B0", VA = "0x1883D47B0", Slot = "21")]
	public bool FCADNKMKHII(Guid CHAPBCKABGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x83CF920", Offset = "0x83CE720", VA = "0x1883CF920", Slot = "22")]
	public void AALCOJOFCEF(Guid CHAPBCKABGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x83DBAD0", Offset = "0x83DA8D0", VA = "0x1883DBAD0", Slot = "23")]
	public void OEDAGALDCOP(PEIKCOPGDKJ AKMAFPBEIMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x83D53E0", Offset = "0x83D41E0", VA = "0x1883D53E0", Slot = "24")]
	public void FNDDBOCGMMM(Guid CHAPBCKABGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x83DAAD0", Offset = "0x83D98D0", VA = "0x1883DAAD0", Slot = "25")]
	public int NBIEJBDBEMC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x83DB370", Offset = "0x83DA170", VA = "0x1883DB370", Slot = "31")]
	public AIKJELDGMEB<IEnumerable<Guid>> NIBELMFFABF(long MDNJLMOPJKG, long PLJIDOFCCEP, PEIKCOPGDKJ? AKMAFPBEIMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x83D4A40", Offset = "0x83D3840", VA = "0x1883D4A40", Slot = "30")]
	public AIKJELDGMEB<IEnumerable<Guid>> FCEPCDHLNCK(long MDNJLMOPJKG, long PLJIDOFCCEP, PEIKCOPGDKJ? AKMAFPBEIMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x83D1AE0", Offset = "0x83D08E0", VA = "0x1883D1AE0", Slot = "54")]
	public AIKJELDGMEB<Dictionary<Guid, PEIKCOPGDKJ>> CCKPMCFJFPM(long MDNJLMOPJKG, long PLJIDOFCCEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x83D5EB0", Offset = "0x83D4CB0", VA = "0x1883D5EB0", Slot = "55")]
	public AIKJELDGMEB<Dictionary<Guid, PEIKCOPGDKJ>> HPCHKDFPHPK(long MDNJLMOPJKG, long PLJIDOFCCEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x83D33C0", Offset = "0x83D21C0", VA = "0x1883D33C0", Slot = "26")]
	public AIKJELDGMEB<int> DENDEFNHBHK(long MDNJLMOPJKG, long PLJIDOFCCEP, PEIKCOPGDKJ? AKMAFPBEIMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x83D5D60", Offset = "0x83D4B60", VA = "0x1883D5D60", Slot = "27")]
	public AIKJELDGMEB<int> HJHKLDMGMJI(long MDNJLMOPJKG, long PLJIDOFCCEP, PEIKCOPGDKJ? AKMAFPBEIMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x83DB160", Offset = "0x83D9F60", VA = "0x1883DB160", Slot = "28")]
	public AIKJELDGMEB<Dictionary<PEIKCOPGDKJ, int>> NHBAEJNLKIK(long MDNJLMOPJKG, long PLJIDOFCCEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x83DB720", Offset = "0x83DA520", VA = "0x1883DB720", Slot = "29")]
	public AIKJELDGMEB<Dictionary<PEIKCOPGDKJ, int>> NJHMOKFNCFC(long MDNJLMOPJKG, long PLJIDOFCCEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x83D45F0", Offset = "0x83D33F0", VA = "0x1883D45F0", Slot = "37")]
	public bool ENDFKHOHPPA(long MDNJLMOPJKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x83D88F0", Offset = "0x83D76F0", VA = "0x1883D88F0", Slot = "56")]
	public bool LAOLJEIDPPG(long MDNJLMOPJKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x83D1240", Offset = "0x83D0040", VA = "0x1883D1240", Slot = "38")]
	public bool BJJHAOBGPDO(long MDNJLMOPJKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x83D7960", Offset = "0x83D6760", VA = "0x1883D7960", Slot = "57")]
	public bool KHGNGLOOFIA(long MDNJLMOPJKG, [Out] BJPFGNDNABD EGCCGCHPPDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x83D3280", Offset = "0x83D2080", VA = "0x1883D3280", Slot = "39")]
	public bool DDJFMJHIMHE(long PNLNCBFPHNC, [Out] DateTime MLKHOCMFHMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x83D83B0", Offset = "0x83D71B0", VA = "0x1883D83B0", Slot = "40")]
	public long KPFJGLPJPFN(long PNLNCBFPHNC)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x83D1880", Offset = "0x83D0680", VA = "0x1883D1880", Slot = "41")]
	public long BOJOEGEAIAB(long MDNJLMOPJKG)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x83DBC50", Offset = "0x83DAA50", VA = "0x1883DBC50", Slot = "42")]
	public int OHBNHEPDAIB(long PNLNCBFPHNC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x83D8150", Offset = "0x83D6F50", VA = "0x1883D8150", Slot = "43")]
	public bool KOLLAICLPGI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x83D8C10", Offset = "0x83D7A10", VA = "0x1883D8C10", Slot = "44")]
	public bool LKIPADLNKNP(long PNLNCBFPHNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x83DAEF0", Offset = "0x83D9CF0", VA = "0x1883DAEF0", Slot = "45")]
	public IReadOnlyList<long> NCNKHOAELLF(long PNLNCBFPHNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x83D64B0", Offset = "0x83D52B0", VA = "0x1883D64B0", Slot = "46")]
	public int IGKHBDFHNJD(long PNLNCBFPHNC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x83D8DC0", Offset = "0x83D7BC0", VA = "0x1883D8DC0", Slot = "50")]
	public long LPMHNGECMGC(long IFAFJJKDADN)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x83D6150", Offset = "0x83D4F50", VA = "0x1883D6150", Slot = "51")]
	public PEIKCOPGDKJ IFGAJEJBOHL()
	{
		return default(PEIKCOPGDKJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x83D1990", Offset = "0x83D0790", VA = "0x1883D1990")]
	private bool CADJCGLPIMI(Guid CHAPBCKABGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x83D2DC0", Offset = "0x83D1BC0", VA = "0x1883D2DC0")]
	private void DBAFGLIFAHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x83D7660", Offset = "0x83D6460", VA = "0x1883D7660")]
	private PEIKCOPGDKJ KBIOFKPAFIF()
	{
		return default(PEIKCOPGDKJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x83D0C00", Offset = "0x83CFA00", VA = "0x1883D0C00")]
	private void BILLIBHBMDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x83D98A0", Offset = "0x83D86A0", VA = "0x1883D98A0")]
	private int MCCKNIAGPDA(KeepsakeRoomListDTO ADELONHDODI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x83D00B0", Offset = "0x83CEEB0", VA = "0x1883D00B0")]
	private int AMFCOMLJIHI(DateTime ICOKFDCICOG, DateTime NDKEFPDJFDO, TimeSpan JKCAMEIGMFL, int EGCBELDONKK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x83D2490", Offset = "0x83D1290", VA = "0x1883D2490")]
	private void CHHAAJKEALN(IEnumerable<KeepsakeInstanceDTO> CAAGBHPEMKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x83D57C0", Offset = "0x83D45C0", VA = "0x1883D57C0")]
	private void GHJKMMDIPGB(IEnumerable<KeepsakeCollectionRecordDTO> MJGFJBHAGHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x83D4750", Offset = "0x83D3550", VA = "0x1883D4750")]
	private void FBODJHDNFCN(IEnumerable<long> NKMDEEABOLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0xB7F940", Offset = "0xB7E740", VA = "0x180B7F940")]
	private void PHNBDAFOMHO(KeepsakeGlobalConfigDTO AKJIECPEOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x83CF990", Offset = "0x83CE790", VA = "0x1883CF990")]
	private bool ABAHNCAAONP(PEIKCOPGDKJ AKMAFPBEIMM, [Out] Guid CIENKMFHACK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x83D80B0", Offset = "0x83D6EB0", VA = "0x1883D80B0")]
	private bool KMHGAAMFPAC([Out] Guid CIENKMFHACK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x83D9A40", Offset = "0x83D8840", VA = "0x1883D9A40")]
	private bool MHPCNKAPHMM(Guid CHAPBCKABGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x83D0490", Offset = "0x83CF290", VA = "0x1883D0490")]
	private IEnumerable<Guid> BECHHIBDIOG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x83D7080", Offset = "0x83D5E80", VA = "0x1883D7080")]
	private IEnumerable<KeepsakeInstanceDTO> JOOOKBIOEAM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x83D6560", Offset = "0x83D5360", VA = "0x1883D6560")]
	private void IGNPDFDMIJB(Guid CHAPBCKABGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x83D12E0", Offset = "0x83D00E0", VA = "0x1883D12E0")]
	private bool BJJNLKMHALO(Guid CHAPBCKABGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x83D5620", Offset = "0x83D4420", VA = "0x1883D5620")]
	private void GBBMOCMAPCM(Guid CHAPBCKABGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x83D2940", Offset = "0x83D1740", VA = "0x1883D2940")]
	private void CNHKOGDDIKI(PEIKCOPGDKJ IBMBMDODBPF, int CBBANDGEEIF, Dictionary<PEIKCOPGDKJ, int> OPMDBIMFCFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x83D13C0", Offset = "0x83D01C0", VA = "0x1883D13C0")]
	private int BMFBDMLOAOC(PEIKCOPGDKJ AKMAFPBEIMM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x83DBE30", Offset = "0x83DAC30", VA = "0x1883DBE30")]
	private void PBKNKMBDDLE(KeepsakeInstanceDTO AIFIEHAHGEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x83D6720", Offset = "0x83D5520", VA = "0x1883D6720")]
	private void JCMJLKLDEPL(KeepsakeInstanceDTO AIFIEHAHGEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x83D14B0", Offset = "0x83D02B0", VA = "0x1883D14B0")]
	private void BMOFLJBJCNM(Guid CHAPBCKABGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x83D7930", Offset = "0x83D6730", VA = "0x1883D7930")]
	private void PIJLLLNEEDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x83D37B0", Offset = "0x83D25B0", VA = "0x1883D37B0")]
	private void DHPAEPKPDDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x83D5370", Offset = "0x83D4170", VA = "0x1883D5370")]
	private void FMHGOKGHFPL(KMEBIHHKPIL GHKJCAKPEIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x83D7930", Offset = "0x83D6730", VA = "0x1883D7930")]
	private void NDAIGBJDHMI(CKDOJJMBIIA ALGAKMGCCLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x83D7930", Offset = "0x83D6730", VA = "0x1883D7930")]
	private void KDPCDLHKIEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x83D7D10", Offset = "0x83D6B10", VA = "0x1883D7D10")]
	private void KICLOHJFMPI(float ANOLGLFFBFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x83D1E90", Offset = "0x83D0C90", VA = "0x1883D1E90")]
	private void CEFINOKIMPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x83D5000", Offset = "0x83D3E00", VA = "0x1883D5000")]
	private bool FFKONLAOIHG(Guid CHAPBCKABGN, [Out] string PNMBFDGBPFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x83D6E40", Offset = "0x83D5C40", VA = "0x1883D6E40")]
	private bool JHJHLJNCKBJ(Guid CHAPBCKABGN, [Out] KeepsakeCategoryConfigDTO IBMBMDODBPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x83D5200", Offset = "0x83D4000", VA = "0x1883D5200")]
	private void FGIPNEAFIIH(string IMIIGPOLNDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x83D2720", Offset = "0x83D1520", VA = "0x1883D2720")]
	private bool CIHJIFFKOLH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x83D8950", Offset = "0x83D7750", VA = "0x1883D8950")]
	private List<long> LEKPEMLMAAG(IEnumerable<KeepsakeRoomDTO> MGMJJAFEOPP, IReadOnlyList<KeepsakeRoomListDTO> DGECMCGOBHD, long PNLNCBFPHNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x83D7140", Offset = "0x83D5F40", VA = "0x1883D7140")]
	private bool KAIHGBGBFHK(Guid CHAPBCKABGN, [Out] string DFOJBJDIKPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x83D7010", Offset = "0x83D5E10", VA = "0x1883D7010", Slot = "47")]
	public string JHOHKMAMHBD(GGEFIDKABCN OIGGNLIGCIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x83D4BE0", Offset = "0x83D39E0", VA = "0x1883D4BE0", Slot = "49")]
	public string FFJOOIFNMBC(GGEFIDKABCN OIGGNLIGCIJ, long MDNJLMOPJKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x83D9420", Offset = "0x83D8220", VA = "0x1883D9420", Slot = "48")]
	public string MBKFDIHBDFL(GGEFIDKABCN OIGGNLIGCIJ, int BNFNMOBDEBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x83D9B60", Offset = "0x83D8960", VA = "0x1883D9B60")]
	private void MOANHIHBDMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x83DC020", Offset = "0x83DAE20", VA = "0x1883DC020")]
	private void PJCDHJKDGEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x83D1AC0", Offset = "0x83D08C0", VA = "0x1883D1AC0")]
	private GGEFIDKABCN CAKDJMKHIGO(FPKMMDCDBCK HEJFKLNCHPB)
	{
		return default(GGEFIDKABCN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x83D5A00", Offset = "0x83D4800", VA = "0x1883D5A00")]
	private GGEFIDKABCN GMAOBENMLPK(FPKMMDCDBCK HEJFKLNCHPB)
	{
		return default(GGEFIDKABCN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x83D4410", Offset = "0x83D3210", VA = "0x1883D4410")]
	internal static string EEMMFGODPBF(KIALFEGMEJE PNCENNMICLF, string NKMJKHEFEEB, bool OHIJPBEKHBM, int FMMJOAPFCPL, int DEDALNECCEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x83D3F10", Offset = "0x83D2D10", VA = "0x1883D3F10", Slot = "52")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x83DBA50", Offset = "0x83DA850", VA = "0x1883DBA50")]
	private NNJLPCOCOKC OCHNPLMFCNG(AFLCFHLHEHB LOAAAANIAKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x83D2C00", Offset = "0x83D1A00", VA = "0x1883D2C00")]
	private ECPGLILLNAG CPNMIJOKIMJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x83D37D0", Offset = "0x83D25D0", VA = "0x1883D37D0")]
	private Task DKHOENOPGGE(CHNMCCPJHLL NPIEBNDMCBK, CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x83D6040", Offset = "0x83D4E40", VA = "0x1883D6040")]
	[AsyncStateMachine(typeof(CMEFCACDFNK))]
	private Task ICEAKHBBPLH(CHNMCCPJHLL NPIEBNDMCBK, CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x83D91E0", Offset = "0x83D7FE0", VA = "0x1883D91E0")]
	private Task MAEIKDPAPMB(CHNMCCPJHLL NPIEBNDMCBK, CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x83DBB20", Offset = "0x83DA920", VA = "0x1883DBB20")]
	[AsyncStateMachine(typeof(HPKCFCNHPJG))]
	private Task OHAHEKHBCNH(string JDFCBBCKOGJ, TimeSpan MNDABBGPMEP, CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x83D8DA0", Offset = "0x83D7BA0", VA = "0x1883D8DA0")]
	[CompilerGenerated]
	private void LMKLCJGAMFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x83D2830", Offset = "0x83D1630", VA = "0x1883D2830")]
	[CompilerGenerated]
	private void CKEFFGIBCFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x83D4650", Offset = "0x83D3450", VA = "0x1883D4650")]
	[CompilerGenerated]
	private bool EOIDEHIKOMH(KeepsakeInstanceDTO DBBMOEGPNPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x83DB890", Offset = "0x83DA690", VA = "0x1883DB890")]
	[CompilerGenerated]
	private AIKJELDGMEB<Dictionary<PEIKCOPGDKJ, int>> NOJIFOGADPL(Dictionary<Guid, PEIKCOPGDKJ> NJEAEMFKNGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x83D92B0", Offset = "0x83D80B0", VA = "0x1883D92B0")]
	[CompilerGenerated]
	private AIKJELDGMEB<Dictionary<PEIKCOPGDKJ, int>> MAMIDNKJJAB(Dictionary<Guid, PEIKCOPGDKJ> NJEAEMFKNGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x83DC000", Offset = "0x83DAE00", VA = "0x1883DC000")]
	[CompilerGenerated]
	private bool PGCPIADDFNO(KeepsakeRoomListDTO DBBMOEGPNPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x83D65F0", Offset = "0x83D53F0", VA = "0x1883D65F0")]
	[CompilerGenerated]
	private bool JAFLLHOLFKP(KeepsakeInstanceDTO DBBMOEGPNPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x83D01B0", Offset = "0x83CEFB0", VA = "0x1883D01B0")]
	[CompilerGenerated]
	private void AOIFPOINGKG(Tuple<KeepsakeRoomInstancesDTO, IReadOnlyDictionary<PEIKCOPGDKJ, KeepsakeCategoryConfigDTO>, KeepsakeGlobalConfigDTO> LFLGOCOHDIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x83D2430", Offset = "0x83D1230", VA = "0x1883D2430")]
	[CompilerGenerated]
	private void CEOFGCCKNMF(string DFOJBJDIKPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x83D5BA0", Offset = "0x83D49A0", VA = "0x1883D5BA0")]
	[CompilerGenerated]
	private Task HEKCJLGDEGK(CancellationToken JPGKDONJACO)
	{
		return null;
	}
}
namespace RecRoom.Keepsakes
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public class KeepsakesConfig : ScriptableObject, DLJMDABIBDF<KeepsakesConfig.KeepsakesOptions>
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200002B")]
		public class KeepsakesOptions
		{
			[Cpp2IlInjected.Token(Token = "0x200002C")]
			[CompilerGenerated]
			private sealed class MKOLLGAEICF
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000098")]
				public string themeId;

				[Cpp2IlInjected.Token(Token = "0x60000F3")]
				[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
				public MKOLLGAEICF()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000F4")]
				[Cpp2IlInjected.Address(RVA = "0x83CF6E0", Offset = "0x83CE4E0", VA = "0x1883CF6E0")]
				internal bool JKKICFDFIFF(KeepsakeTheme x)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60000F5")]
				[Cpp2IlInjected.Address(RVA = "0x83CF6E0", Offset = "0x83CE4E0", VA = "0x1883CF6E0")]
				internal bool CJEEAICNKCD(KeepsakeTheme x)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			[SerializeField]
			private KeepsakeTheme[] themes;

			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x83CF510", Offset = "0x83CE310", VA = "0x1883CF510")]
			public bool AJMEAAELMFN(string OICGPDGOEAI, [Out] KeepsakeTheme FDEEFGOPKEH)
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
			[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x83CF490", Offset = "0x83CE290", VA = "0x1883CF490")]
		[NKOKDPHOKEP.APMGAGDLDLC.MJKDHMGHAOE]
		internal static void ODAPPKPCBLD(HJFNEHLLJBB HPOMHCIJOHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0xD40920", Offset = "0xD3F720", VA = "0x180D40920")]
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
