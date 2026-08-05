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
	public class _AssemblyIndex : PPJBMGKOMFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6E19050", Offset = "0x6E18450", VA = "0x186E19050", Slot = "8")]
		public override void JFOOIIGPHCJ(GHGEJHAEAMC registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x648F4C0", Offset = "0x648E8C0", VA = "0x18648F4C0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class KMBBIOAGHFO : IComparer<OLMJDNCJDKP>
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private sealed class OFMGBIEOMNB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public OLMJDNCJDKP x;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public OLMJDNCJDKP y;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public OFMGBIEOMNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x1284060", Offset = "0x1283460", VA = "0x181284060")]
		internal bool IIAIGLHPMEK(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x17BEAE0", Offset = "0x17BDEE0", VA = "0x1817BEAE0")]
		internal bool NIJFJMCCJMH(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1284060", Offset = "0x1283460", VA = "0x181284060")]
		internal bool OAGBAFBDEOE(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x17BEAE0", Offset = "0x17BDEE0", VA = "0x1817BEAE0")]
		internal bool AOMHIDGBJKH(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private List<KeepsakeCategoryThemePair> MAEFKJOPBED;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x8B47B0", Offset = "0x8B3BB0", VA = "0x1808B47B0")]
	public KMBBIOAGHFO(List<KeepsakeCategoryThemePair> BLNHDKHBMDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6E0A2A0", Offset = "0x6E096A0", VA = "0x186E0A2A0", Slot = "4")]
	public int Compare(OLMJDNCJDKP LBEGFJJGJFP, OLMJDNCJDKP GAMIAAAKNPF)
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
		public OLMJDNCJDKP KeepsakeCategory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public KeepsakeTheme KeepsakeTheme;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[JEGDMIPNMMJ]
public class MELLHBNIAJB : LFEHEOHAGJB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class BAOKLMEMHKD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public MELLHBNIAJB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public OLMJDNCJDKP keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public BAOKLMEMHKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6E07F90", Offset = "0x6E07390", VA = "0x186E07F90")]
		internal MJGAHFINLMO<Guid> IIJBPFEFNIE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6E08110", Offset = "0x6E07510", VA = "0x186E08110")]
		internal void OPODGNEDCOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6E07F30", Offset = "0x6E07330", VA = "0x186E07F30")]
		internal void CBCLJEPIHFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6E08140", Offset = "0x6E07540", VA = "0x186E08140")]
		internal void PGANHOOIBBM(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6E080E0", Offset = "0x6E074E0", VA = "0x186E080E0")]
		internal void NCOMFDCHALP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class CEFMJLPLFKB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public MELLHBNIAJB <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public CEFMJLPLFKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6E085B0", Offset = "0x6E079B0", VA = "0x186E085B0")]
		internal void KIFBGKBFDFN(IEIPKBKGMFM response)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6E08550", Offset = "0x6E07950", VA = "0x186E08550")]
		internal void EMOGOOGBLPE(string error)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class CODCLEJNGEP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public KeepsakeTheme theme;

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public CODCLEJNGEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x6E08A50", Offset = "0x6E07E50", VA = "0x186E08A50")]
		internal bool OHFOJJDAPBO(KeepsakeCategoryThemePair categoryThemePair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class HBOONJLIEOK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public MELLHBNIAJB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public long progressionEventId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public OLMJDNCJDKP? keepsakeCategory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public HBOONJLIEOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6E09110", Offset = "0x6E08510", VA = "0x186E09110")]
		internal void GMDIKJJKKCO(KeepsakeProgressionEventInstancesDTO result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x6E090E0", Offset = "0x6E084E0", VA = "0x186E090E0")]
		internal void ACAGNHEHBFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x6E091A0", Offset = "0x6E085A0", VA = "0x186E091A0")]
		internal MJGAHFINLMO<IEnumerable<Guid>> MFMACLKLOGA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x6A4C310", Offset = "0x6A4B710", VA = "0x186A4C310")]
		internal bool OKBBOHDKLJI(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class AODFEMDBGDK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public KeepsakeRoomInstanceIdsDTO instancesInRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public HBOONJLIEOK CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public AODFEMDBGDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x6E07DF0", Offset = "0x6E071F0", VA = "0x186E07DF0")]
		internal MJGAHFINLMO<IEnumerable<Guid>> LODPGKIFBDK(KeepsakeRoomInstancesDTO roomInstancesDTO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class NIPKPMDDPDO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public KeepsakeRoomInstancesDTO roomInstancesDTO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public AODFEMDBGDK CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public NIPKPMDDPDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x6E186C0", Offset = "0x6E17AC0", VA = "0x186E186C0")]
		internal bool FKBFAECAJCG(Guid instanceId)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class LJDPEIFKHNL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Guid instanceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public NIPKPMDDPDO CS$<>8__locals3;

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public LJDPEIFKHNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x6E0A7D0", Offset = "0x6E09BD0", VA = "0x186E0A7D0")]
		internal bool IICBJPFKIHM(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class KJOMJILENNF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public MELLHBNIAJB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public KJOMJILENNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x6E0A130", Offset = "0x6E09530", VA = "0x186E0A130")]
		internal MJGAHFINLMO<IEnumerable<Guid>> KCNEHFJOCLK(IEnumerable<Guid> instanceIds)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x6E0A110", Offset = "0x6E09510", VA = "0x186E0A110")]
		internal bool HPDNMJFMBJE(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class IOFADCACEJG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public MELLHBNIAJB <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public IOFADCACEJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x6E098B0", Offset = "0x6E08CB0", VA = "0x186E098B0")]
		internal void JMENEEIJNGH(KeepsakeProgressionEventInstancesDTO result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x6E090E0", Offset = "0x6E084E0", VA = "0x186E090E0")]
		internal void ABOLOAEFNOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x6E095C0", Offset = "0x6E089C0", VA = "0x186E095C0")]
		internal MJGAHFINLMO<Dictionary<Guid, OLMJDNCJDKP>> EOHDGIKDKHG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x6A4C310", Offset = "0x6A4B710", VA = "0x186A4C310")]
		internal bool CJNCCHCGODD(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class EKCFOFGGBJG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public KeepsakeRoomInstanceIdsDTO instancesInRoom;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public EKCFOFGGBJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x6E08C80", Offset = "0x6E08080", VA = "0x186E08C80")]
		internal MJGAHFINLMO<Dictionary<Guid, OLMJDNCJDKP>> MILPPFBLHHP(KeepsakeRoomInstancesDTO roomInstancesDTO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class FJIAPDOLGCF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public KeepsakeRoomInstancesDTO roomInstancesDTO;

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public FJIAPDOLGCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x6E08F80", Offset = "0x6E08380", VA = "0x186E08F80")]
		internal bool JGFFHNBJNEL(Guid instanceId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6E08E30", Offset = "0x6E08230", VA = "0x186E08E30")]
		internal KeyValuePair<Guid, OLMJDNCJDKP> JGBLMBDJKIM(Guid instanceId)
		{
			return default(KeyValuePair<Guid, OLMJDNCJDKP>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class HKGDGFHJCHH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public Guid instanceId;

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public HKGDGFHJCHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x1D50A60", Offset = "0x1D4FE60", VA = "0x181D50A60")]
		internal bool GJPHOGIAAAH(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class MGJLFHEFDGF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public Guid instanceId;

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public MGJLFHEFDGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x1D50A60", Offset = "0x1D4FE60", VA = "0x181D50A60")]
		internal bool JGEIACKBAIM(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class PMEKAHMOELD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public MELLHBNIAJB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public PMEKAHMOELD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x6E18AF0", Offset = "0x6E17EF0", VA = "0x186E18AF0")]
		internal MJGAHFINLMO<Dictionary<Guid, OLMJDNCJDKP>> ILFAPIKLDIP(Dictionary<Guid, OLMJDNCJDKP> instanceIdsAndCategories)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x6E0A110", Offset = "0x6E09510", VA = "0x186E0A110")]
		internal bool HHPPKBANHMM(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class FKMGHCNIBIN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public KeepsakeRoomInstanceIdsDTO collectedInstanceIds;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public FKMGHCNIBIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x6E09060", Offset = "0x6E08460", VA = "0x186E09060")]
		internal bool HOBIKGDNGCP(KeyValuePair<Guid, OLMJDNCJDKP> idCategoryPair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class POAFLHFMAIF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public Dictionary<Guid, OLMJDNCJDKP> instanceIdsAndCategories;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public POAFLHFMAIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x6E18CF0", Offset = "0x6E180F0", VA = "0x186E18CF0")]
		internal KeyValuePair<OLMJDNCJDKP, int> NNONKGCCINF(OLMJDNCJDKP category)
		{
			return default(KeyValuePair<OLMJDNCJDKP, int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class NOJJPDEINFC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public OLMJDNCJDKP category;

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public NOJJPDEINFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x9410B0", Offset = "0x9404B0", VA = "0x1809410B0")]
		internal bool FLPPBPOKNGM(OLMJDNCJDKP instanceCategory)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class DHLHLMJONGI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public Dictionary<Guid, OLMJDNCJDKP> instanceIdsAndCategories;

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public DHLHLMJONGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x6E08B30", Offset = "0x6E07F30", VA = "0x186E08B30")]
		internal KeyValuePair<OLMJDNCJDKP, int> EHGMCFPDGNH(OLMJDNCJDKP category)
		{
			return default(KeyValuePair<OLMJDNCJDKP, int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class PEDEAMDBCLI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public OLMJDNCJDKP category;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public PEDEAMDBCLI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x9410B0", Offset = "0x9404B0", VA = "0x1809410B0")]
		internal bool GDICLBBAKDG(OLMJDNCJDKP instanceCategory)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class KFJPPFPGDGD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public MELLHBNIAJB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public Func<KeepsakeRoomDTO, bool> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public KFJPPFPGDGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x6E09F40", Offset = "0x6E09340", VA = "0x186E09F40")]
		internal bool DJPGEDEGKAP(DateTime nowUtc, DateTime eventStartTime, int roomOrder, TimeSpan unlockStartOffset, TimeSpan unlockInterval, int unlockBatchSize)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x6E0A050", Offset = "0x6E09450", VA = "0x186E0A050")]
		internal bool HPPHKEDLIDH(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x6E0A030", Offset = "0x6E09430", VA = "0x186E0A030")]
		internal bool MOMODOCOMFP(KeepsakeRoomDTO r)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x6E0A030", Offset = "0x6E09430", VA = "0x186E0A030")]
		internal bool HKJPHLNBHGA(KeepsakeRoomDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class EELDABJJOAI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public EELDABJJOAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x9A23F0", Offset = "0x9A17F0", VA = "0x1809A23F0")]
		internal bool KKBGDCHAGNK(KeepsakeRoomListDTO roomList)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class ADFKNBNGIMK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public Func<KeepsakeRoomDTO, bool> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public ADFKNBNGIMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x6E07D30", Offset = "0x6E07130", VA = "0x186E07D30")]
		internal bool IMDNBIBALBM(KeepsakeRoomListDTO roomList)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x1CF6A00", Offset = "0x1CF5E00", VA = "0x181CF6A00")]
		internal bool IJNKELODKEP(KeepsakeRoomDTO room)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class DANMOCGNCCE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public DANMOCGNCCE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x6E08A70", Offset = "0x6E07E70", VA = "0x186E08A70")]
		internal bool PGLJJBMPIFB(KeepsakeRoomListDTO i)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class MOPKHDDCKMI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public MOPKHDDCKMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x9A23F0", Offset = "0x9A17F0", VA = "0x1809A23F0")]
		internal bool BOKADMJNHDA(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class IAKICNANFJJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public Guid keepsakeInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public IAKICNANFJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x6E09560", Offset = "0x6E08960", VA = "0x186E09560")]
		internal bool JLPNACBFDJA(KeyValuePair<Guid, KeepsakeInstanceDTO> instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class KOEAMHJNPHO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public OLMJDNCJDKP keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public KOEAMHJNPHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x19C6440", Offset = "0x19C5840", VA = "0x1819C6440")]
		internal bool GCAOMCEIGOB(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class DCNMAPHEBJG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public Guid keepsakeInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public DCNMAPHEBJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x6E08AD0", Offset = "0x6E07ED0", VA = "0x186E08AD0")]
		internal bool CMOKJPKJJFJ(KeyValuePair<Guid, KeepsakeInstanceDTO> instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class HODICKGJDAF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public OLMJDNCJDKP keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public HODICKGJDAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x6E094A0", Offset = "0x6E088A0", VA = "0x186E094A0")]
		internal bool GGEINJKNOBD(KeyValuePair<Guid, OLMJDNCJDKP> x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class PBLEOGHELKN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public OLMJDNCJDKP newKeepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public PBLEOGHELKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x19C6440", Offset = "0x19C5840", VA = "0x1819C6440")]
		internal bool ADIHFEHMFOG(KeepsakeInstanceDTO instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class HPDFDONJJBP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public long currentRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public long? currentSubRoomId;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public HPDFDONJJBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x6E094E0", Offset = "0x6E088E0", VA = "0x186E094E0")]
		internal bool POAJDKIALII(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class CEGCANMEDMF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public IEnumerable<KeepsakeRoomListDTO> roomList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public CEGCANMEDMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x6E08960", Offset = "0x6E07D60", VA = "0x186E08960")]
		internal bool GMLPJJFEBMG(KeepsakeRoomDTO room)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class KENCEDLGIEN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public KeepsakeRoomDTO room;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public CEGCANMEDMF CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public KENCEDLGIEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x6E09EC0", Offset = "0x6E092C0", VA = "0x186E09EC0")]
		internal bool GJPKBHDNGNH(KeepsakeRoomListDTO roomListDto)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private struct JCBPLJNCPPL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public MELLHBNIAJB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public LMMLJLDDCAM args;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x6E09940", Offset = "0x6E08D40", VA = "0x186E09940", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x6E09E60", Offset = "0x6E09260", VA = "0x186E09E60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private struct OLIHFCGBHLA : IAsyncStateMachine
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
		public MELLHBNIAJB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public string message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x6E187F0", Offset = "0x6E17BF0", VA = "0x186E187F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x6E18A90", Offset = "0x6E17E90", VA = "0x186E18A90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly DateTime GCEANMHPJCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly MBGCDAHEPJM JONMGCKCEKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly MFIKCKOKPNF JFIMOODCDOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly DIJNKHMGNPC ENFDCOLJHOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly NCOEGDMMPCG IONJIBLBPPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly ABPMMLMGFMJ LHLCJGLEKJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly PIFLIMHOFPM DGAAJBAODBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly MMKFOOFFIFM HFDFJGPGOMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly JBIAOBMMOIH BHLNPLGEMCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly CDOIIJHIKJB NHKMKNANLFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly JHAFLMKPJHO CCPAEPGNAIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly HLDPCPPHLKC CNLFICJLICP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly OHMOLNDPOPP KJNMNCAEFCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly FOPJIBGGJJD EAEHCLJNOAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly LKOPBDJOAJB CEEIPFBCOJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly CFKANHJCJBB IMDPBFNLDEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly FBEEFNEHFPG<KeepsakesConfig.KeepsakesOptions> ALOJIDNACGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly OMPFDBLPBEP HEFFGHBGHBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly Dictionary<Guid, KeepsakeInstanceDTO> IAJACLGMLNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly HashSet<Guid> BGNEMKMHBNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly HashSet<long> IJCBLAFEOPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private Dictionary<OLMJDNCJDKP, int> NADJFFLGPFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly HashSet<Guid> GPPKLBJCBGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly IDisposable DPLINEKNDHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private Task MMKBLCDJLIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private MJGAHFINLMO<Guid> DEDMHINMENE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private long? JHHDADHHHJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private KeepsakeProgressionEventInstancesDTO HHOOIIJEPLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private MJGAHFINLMO<KeepsakeProgressionEventInstancesDTO> DMFGFHBEHJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private IReadOnlyDictionary<OLMJDNCJDKP, KeepsakeCategoryConfigDTO> PKJIPHOBFMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private KeepsakeGlobalConfigDTO FLMOANBMOBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private HashSet<long> NCEOMLENFDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private HashSet<long> CFMMFOHODOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private List<KeepsakeRoomListDTO> LGNHPILGOBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private List<KeepsakeRoomListDTO> HMLAJGBFNKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private List<KeepsakeRoomListDTO> CFBPJFDBJMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private Dictionary<long, string> LLLKOBINGMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private Dictionary<long, string> NFIJLMBNFEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private Dictionary<long, DateTime> EIDMPLPGBGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private Dictionary<long, List<KeepsakeRoomDTO>> EEEMJBFKNCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private Dictionary<long, List<KeepsakeRoomDTO>> GMIBBILMLLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private Dictionary<long, long> DPMJEBFFCBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly List<string> HICADKEIKED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private DateTime EILOICBIKJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly IDisposable BJPDOLIAKME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private Dictionary<Guid, OLMJDNCJDKP> GGPLGMJCMII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private Dictionary<OLMJDNCJDKP, int> KBOMDBBAGDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private List<KeepsakeCategoryThemePair> BLNHDKHBMDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private KMBBIOAGHFO ALONNIHNJBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private bool AGKOEDGNLPD;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool LJFPJGMMBNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xCAB850", Offset = "0xCAAC50", VA = "0x180CAB850", Slot = "53")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xDB0010", Offset = "0xDAF410", VA = "0x180DB0010")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool CDAPJJCBAOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6E128E0", Offset = "0x6E11CE0", VA = "0x186E128E0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool LFDHJNGOAIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6E17040", Offset = "0x6E16440", VA = "0x186E17040", Slot = "36")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private long KOBPKHOHFAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6E0E800", Offset = "0x6E0DC00", VA = "0x186E0E800")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private long? IIHNBDHEACL
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6E0FD50", Offset = "0x6E0F150", VA = "0x186E0FD50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private bool BJOPNMLBHAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6E165F0", Offset = "0x6E159F0", VA = "0x186E165F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public IReadOnlyList<KeepsakeRoomListDTO> OKLHJIMNEPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x9048E0", Offset = "0x903CE0", VA = "0x1809048E0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public IReadOnlyList<KeepsakeRoomListDTO> DLNPKMAAEFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xDE4710", Offset = "0xDE3B10", VA = "0x180DE4710", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IReadOnlyList<KeepsakeRoomListDTO> FDDOAJMGPAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x9F94F0", Offset = "0x9F88F0", VA = "0x1809F94F0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public IReadOnlyDictionary<long, string> LNGKMGMCBEG
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x922140", Offset = "0x921540", VA = "0x180922140", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	internal bool KDDMGBGCEJA
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x1C56DC0", Offset = "0x1C561C0", VA = "0x181C56DC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Guid?> PDMNFDGGHND
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6E10900", Offset = "0x6E0FD00", VA = "0x186E10900", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6E0E520", Offset = "0x6E0D920", VA = "0x186E0E520", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action DBPECIHCBDM
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B7F0", Offset = "0x6E0ABF0", VA = "0x186E0B7F0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6E15820", Offset = "0x6E14C20", VA = "0x186E15820", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action NJCBAMLMMFI
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6E0FAA0", Offset = "0x6E0EEA0", VA = "0x186E0FAA0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6E0D3C0", Offset = "0x6E0C7C0", VA = "0x186E0D3C0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6E17100", Offset = "0x6E16500", VA = "0x186E17100")]
	[RecRoom.NoEngine.Common.Preserve]
	internal MELLHBNIAJB([CCLHMIDBCEM(null)][NotNull] MBGCDAHEPJM JONMGCKCEKG, [NotNull][CCLHMIDBCEM(null)] AACPFFJDDDA FBIKKAJLDAK, [NotNull][CCLHMIDBCEM(null)] MFIKCKOKPNF JFIMOODCDOA, [NotNull][CCLHMIDBCEM(null)] DIJNKHMGNPC ENFDCOLJHOH, [CCLHMIDBCEM(null)][NotNull] NCOEGDMMPCG IONJIBLBPPI, [CCLHMIDBCEM(null)][NotNull] ABPMMLMGFMJ LHLCJGLEKJD, [CCLHMIDBCEM(null)][NotNull] PIFLIMHOFPM DGAAJBAODBB, [NotNull][CCLHMIDBCEM(null)] MMKFOOFFIFM HFDFJGPGOMG, [NotNull][CCLHMIDBCEM(null)] JBIAOBMMOIH BHLNPLGEMCN, [NotNull][CCLHMIDBCEM(null)] JNCOMNHABGN MNIOMOODKAC, [NotNull][CCLHMIDBCEM(null)] CDOIIJHIKJB NHKMKNANLFA, [NotNull][CCLHMIDBCEM(null)] JHAFLMKPJHO CCPAEPGNAIF, [NotNull][CCLHMIDBCEM(null)] HLDPCPPHLKC CNLFICJLICP, [NotNull][CCLHMIDBCEM(null)] OHMOLNDPOPP KJNMNCAEFCB, [CCLHMIDBCEM(null)][NotNull] FOPJIBGGJJD EAEHCLJNOAC, [CCLHMIDBCEM(null)][NotNull] LKOPBDJOAJB CEEIPFBCOJI, [NotNull][CCLHMIDBCEM(null)] CFKANHJCJBB IMDPBFNLDEL, [CCLHMIDBCEM(null)][NotNull] FBEEFNEHFPG<KeepsakesConfig.KeepsakesOptions> ALOJIDNACGI, [NotNull][CCLHMIDBCEM(null)] OMPFDBLPBEP HEFFGHBGHBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6E0E100", Offset = "0x6E0D500", VA = "0x186E0E100", Slot = "15")]
	public bool EHKDHNDLPNB(List<string> FLMNPMPJJME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6E0FDE0", Offset = "0x6E0F1E0", VA = "0x186E0FDE0", Slot = "16")]
	public MJGAHFINLMO<Guid> GHLCGBIIJBO(OLMJDNCJDKP NIOPKALLHHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6E13FC0", Offset = "0x6E133C0", VA = "0x186E13FC0", Slot = "17")]
	public GELPMBCHBBO LADNLGAEMBD(Guid DCANINCFJNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6E0AAC0", Offset = "0x6E09EC0", VA = "0x186E0AAC0", Slot = "18")]
	public GELPMBCHBBO ANEBDBANGDG(Guid DCANINCFJNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6E107A0", Offset = "0x6E0FBA0", VA = "0x186E107A0", Slot = "19")]
	public bool GKNHDAPIABM(Guid DCANINCFJNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6E153F0", Offset = "0x6E147F0", VA = "0x186E153F0", Slot = "20")]
	public bool MIIIOHBKKJN(Guid DCANINCFJNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6E123A0", Offset = "0x6E117A0", VA = "0x186E123A0")]
	public KeepsakeTheme INKOLFNALCE(Guid DCANINCFJNC)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6E169C0", Offset = "0x6E15DC0", VA = "0x186E169C0")]
	public bool PFAGLABCEKF(OLMJDNCJDKP NIOPKALLHHO, [Out] KeepsakeTheme FKGALAIOIKD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6E0AE40", Offset = "0x6E0A240", VA = "0x186E0AE40")]
	public List<KeepsakeTheme> AOCDJPAIDLL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6E142A0", Offset = "0x6E136A0", VA = "0x186E142A0")]
	public int LFPBEGAIDOO(OLMJDNCJDKP NIOPKALLHHO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6E15CF0", Offset = "0x6E150F0", VA = "0x186E15CF0")]
	public OLMJDNCJDKP NPOFDBEACGO(Guid DCANINCFJNC)
	{
		return default(OLMJDNCJDKP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6E0F960", Offset = "0x6E0ED60", VA = "0x186E0F960", Slot = "34")]
	public List<OLMJDNCJDKP> GAFALDJFEOD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6E15E50", Offset = "0x6E15250", VA = "0x186E15E50", Slot = "35")]
	public IComparer<OLMJDNCJDKP> OBLGHOALKKH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6E158C0", Offset = "0x6E14CC0", VA = "0x186E158C0", Slot = "32")]
	public string NECJCHOMGNG(OLMJDNCJDKP NIOPKALLHHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6E13830", Offset = "0x6E12C30", VA = "0x186E13830", Slot = "33")]
	public string KAHHANNOGEK(OLMJDNCJDKP NIOPKALLHHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6E118D0", Offset = "0x6E10CD0", VA = "0x186E118D0", Slot = "21")]
	public bool HOHIHJBFPLM(Guid DCANINCFJNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6E13E50", Offset = "0x6E13250", VA = "0x186E13E50", Slot = "22")]
	public void KFIKCGPJLNH(Guid DCANINCFJNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6E15420", Offset = "0x6E14820", VA = "0x186E15420", Slot = "23")]
	public void MKECNLEKEII(OLMJDNCJDKP NIOPKALLHHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6E15A40", Offset = "0x6E14E40", VA = "0x186E15A40", Slot = "24")]
	public void NEGNEEPEKCJ(Guid DCANINCFJNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6E0D550", Offset = "0x6E0C950", VA = "0x186E0D550", Slot = "25")]
	public int DNFNKPMMDPJ()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6E103F0", Offset = "0x6E0F7F0", VA = "0x186E103F0", Slot = "31")]
	public MJGAHFINLMO<IEnumerable<Guid>> GKMPJCHGFLB(long FJBFONPAOAD, long ECPFEFINHGJ, OLMJDNCJDKP? NIOPKALLHHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6E15470", Offset = "0x6E14870", VA = "0x186E15470", Slot = "30")]
	public MJGAHFINLMO<IEnumerable<Guid>> MNDABACEMGB(long FJBFONPAOAD, long ECPFEFINHGJ, OLMJDNCJDKP? NIOPKALLHHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B890", Offset = "0x6E0AC90", VA = "0x186E0B890", Slot = "54")]
	public MJGAHFINLMO<Dictionary<Guid, OLMJDNCJDKP>> CABJMCFLIDJ(long FJBFONPAOAD, long ECPFEFINHGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6E0EE70", Offset = "0x6E0E270", VA = "0x186E0EE70", Slot = "55")]
	public MJGAHFINLMO<Dictionary<Guid, OLMJDNCJDKP>> FGBCKIGBLLF(long FJBFONPAOAD, long ECPFEFINHGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6E15F10", Offset = "0x6E15310", VA = "0x186E15F10", Slot = "26")]
	public MJGAHFINLMO<int> ODHPOCLHNCO(long FJBFONPAOAD, long ECPFEFINHGJ, OLMJDNCJDKP? NIOPKALLHHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6E0E6B0", Offset = "0x6E0DAB0", VA = "0x186E0E6B0", Slot = "27")]
	public MJGAHFINLMO<int> EOPMCAFBGHL(long FJBFONPAOAD, long ECPFEFINHGJ, OLMJDNCJDKP? NIOPKALLHHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6E16BA0", Offset = "0x6E15FA0", VA = "0x186E16BA0", Slot = "28")]
	public MJGAHFINLMO<Dictionary<OLMJDNCJDKP, int>> PGBCCDDJJEJ(long FJBFONPAOAD, long ECPFEFINHGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6E0E460", Offset = "0x6E0D860", VA = "0x186E0E460", Slot = "29")]
	public MJGAHFINLMO<Dictionary<OLMJDNCJDKP, int>> ELADEILJGIP(long FJBFONPAOAD, long ECPFEFINHGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6E0E0A0", Offset = "0x6E0D4A0", VA = "0x186E0E0A0", Slot = "37")]
	public bool EFOBLPILAEB(long FJBFONPAOAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6E14240", Offset = "0x6E13640", VA = "0x186E14240", Slot = "56")]
	public bool LBDGLCLOEEN(long FJBFONPAOAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B2E0", Offset = "0x6E0A6E0", VA = "0x186E0B2E0", Slot = "38")]
	public bool BHMJPIJBHHI(long FJBFONPAOAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6E11FF0", Offset = "0x6E113F0", VA = "0x186E11FF0", Slot = "57")]
	public bool ILMAFAKIEEF(long FJBFONPAOAD, [Out] LPHNIFOLACE DFILHOCGELP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6E0D970", Offset = "0x6E0CD70", VA = "0x186E0D970", Slot = "39")]
	public bool DOBHMFODBKI(long OFHPONEDNCM, [Out] DateTime ECNDNEJPNNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6E0E8D0", Offset = "0x6E0DCD0", VA = "0x186E0E8D0", Slot = "40")]
	public long FDKDFGNICIK(long OFHPONEDNCM)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6E0CE50", Offset = "0x6E0C250", VA = "0x186E0CE50", Slot = "41")]
	public long CMHJFCKAFPJ(long FJBFONPAOAD)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6E15210", Offset = "0x6E14610", VA = "0x186E15210", Slot = "42")]
	public int MFDGAMCCKIG(long OFHPONEDNCM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6E0E5D0", Offset = "0x6E0D9D0", VA = "0x186E0E5D0", Slot = "43")]
	public bool ENABBALKCKK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6E0DF10", Offset = "0x6E0D310", VA = "0x186E0DF10", Slot = "44")]
	public bool EFKHKNCDNDG(long OFHPONEDNCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6E12C10", Offset = "0x6E12010", VA = "0x186E12C10", Slot = "45")]
	public IEnumerable<long> JGPJHNMJFHA(long OFHPONEDNCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6E16480", Offset = "0x6E15880", VA = "0x186E16480", Slot = "46")]
	public int OGKPAFIJJDL(long OFHPONEDNCM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6E10E10", Offset = "0x6E10210", VA = "0x186E10E10", Slot = "50")]
	public long HFGGIOJJIEC(long GEGJGKLHIFJ)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B490", Offset = "0x6E0A890", VA = "0x186E0B490", Slot = "51")]
	public OLMJDNCJDKP BMMPHPCLKFH()
	{
		return default(OLMJDNCJDKP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6E109B0", Offset = "0x6E0FDB0", VA = "0x186E109B0")]
	private bool GLGEDCHOJHG(Guid DCANINCFJNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6E12DF0", Offset = "0x6E121F0", VA = "0x186E12DF0")]
	private void JLIKNHNGIIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6E0CB20", Offset = "0x6E0BF20", VA = "0x186E0CB20")]
	private OLMJDNCJDKP CKILJBKEAAK()
	{
		return default(OLMJDNCJDKP);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6E11290", Offset = "0x6E10690", VA = "0x186E11290")]
	private void HKMGLFHFIJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6E14D10", Offset = "0x6E14110", VA = "0x186E14D10")]
	private int MBEPBMEOMFM(KeepsakeRoomListDTO OMEKLOJJECN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6E13310", Offset = "0x6E12710", VA = "0x186E13310")]
	private int JPBPDNPJFML(DateTime PFFEACIPAKD, DateTime DOMHLCKKBCM, TimeSpan HDAEKCLBCGG, int MIMAGGJELMH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6E12650", Offset = "0x6E11A50", VA = "0x186E12650")]
	private void JBBBOKFLGJL(IEnumerable<KeepsakeInstanceDTO> IAJACLGMLNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6E13C10", Offset = "0x6E13010", VA = "0x186E13C10")]
	private void KDAGCOBIBCN(IEnumerable<KeepsakeCollectionRecordDTO> KKCMBNCJFGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6E0AA60", Offset = "0x6E09E60", VA = "0x186E0AA60")]
	private void AJOEEMKKJEA(IEnumerable<long> DPGIHDBODCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0xA54B40", Offset = "0xA53F40", VA = "0x180A54B40")]
	private void LBJEJFJCKEP(KeepsakeGlobalConfigDTO FLMOANBMOBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x6E139B0", Offset = "0x6E12DB0", VA = "0x186E139B0")]
	private bool KBLBGPBIEDH(OLMJDNCJDKP NIOPKALLHHO, [Out] Guid IDHGGHAADCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B240", Offset = "0x6E0A640", VA = "0x186E0B240")]
	private bool BHDGMBCCBCL([Out] Guid IDHGGHAADCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6E132B0", Offset = "0x6E126B0", VA = "0x186E132B0")]
	private bool JMGKLPPOCFH(Guid DCANINCFJNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6E11EA0", Offset = "0x6E112A0", VA = "0x186E11EA0")]
	private IEnumerable<Guid> IEEEMMDHJFA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x6E16530", Offset = "0x6E15930", VA = "0x186E16530")]
	private IEnumerable<KeepsakeInstanceDTO> OKAHIAOGIKM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6E11B60", Offset = "0x6E10F60", VA = "0x186E11B60")]
	private void HPNBBBGPFJL(Guid DCANINCFJNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6E0CF60", Offset = "0x6E0C360", VA = "0x186E0CF60")]
	private bool DCMMCPAJLMI(Guid DCANINCFJNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6E0F220", Offset = "0x6E0E620", VA = "0x186E0F220")]
	private void FMHCGPCIKOI(Guid DCANINCFJNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6E15610", Offset = "0x6E14A10", VA = "0x186E15610")]
	private void NBCKMKBDNMG(OLMJDNCJDKP KKCGFLAHKCD, int DKDNOBDCOEF, Dictionary<OLMJDNCJDKP, int> LIEFPJMPMPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6E0F000", Offset = "0x6E0E400", VA = "0x186E0F000")]
	private int FINKPAKLMNK(OLMJDNCJDKP NIOPKALLHHO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6E12A40", Offset = "0x6E11E40", VA = "0x186E12A40")]
	private void JGIJNINAMIP(KeepsakeInstanceDTO KNFLIGMFOFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6E0FB40", Offset = "0x6E0EF40", VA = "0x186E0FB40")]
	private void GGGNNJFFHHL(KeepsakeInstanceDTO KNFLIGMFOFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6E14940", Offset = "0x6E13D40", VA = "0x186E14940")]
	private void MAFAKAAMAIG(Guid DCANINCFJNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6E0D460", Offset = "0x6E0C860", VA = "0x186E0D460")]
	private void GCOPBJNCMLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6E13FA0", Offset = "0x6E133A0", VA = "0x186E13FA0")]
	private void KGOBEFLPIBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6E15C80", Offset = "0x6E15080", VA = "0x186E15C80")]
	private void NKNHFMAPMJA(EALNFCKLDEO IMCPDPDEAID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6E0D460", Offset = "0x6E0C860", VA = "0x186E0D460")]
	private void KKLPJLMIDCG(KDFCGCBHJNM FMAFBHGACNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6E0D460", Offset = "0x6E0C860", VA = "0x186E0D460")]
	private void DHFOINILPID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6E16600", Offset = "0x6E15A00", VA = "0x186E16600")]
	private void OMNIDMAIDBE(float NJKOHBLGLDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6E0F3C0", Offset = "0x6E0E7C0", VA = "0x186E0F3C0")]
	private void FPMFIOAGOAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6E161B0", Offset = "0x6E155B0", VA = "0x186E161B0")]
	private bool OFGLPOPJHLJ(Guid DCANINCFJNC, [Out] string BAKKAMFGFNH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6E15040", Offset = "0x6E14440", VA = "0x186E15040")]
	private bool MEIAFFAPLGC(Guid DCANINCFJNC, [Out] KeepsakeCategoryConfigDTO KKCGFLAHKCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6E13EC0", Offset = "0x6E132C0", VA = "0x186E13EC0")]
	private void KGACHIKIEJG(string CDMNEMPOKAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6E12930", Offset = "0x6E11D30", VA = "0x186E12930")]
	private bool JEOCEKJFOJN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6E11BF0", Offset = "0x6E10FF0", VA = "0x186E11BF0")]
	private IEnumerable<long> IDDEOHPHHMB(IEnumerable<KeepsakeRoomDTO> ANDPBNJGKAH, IEnumerable<KeepsakeRoomListDTO> PIBHDHLMDBE, long OFHPONEDNCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6E14420", Offset = "0x6E13820", VA = "0x186E14420")]
	private bool LGEDPKBIAMI(Guid DCANINCFJNC, [Out] string MEDJAOOGFHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6E0EE10", Offset = "0x6E0E210", VA = "0x186E0EE10", Slot = "47")]
	public string FFKKEGLIAKP(PALPGELKGFK HKAFPLDDPOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6E13410", Offset = "0x6E12810", VA = "0x186E13410", Slot = "49")]
	public string JPDGOIIAPFK(PALPGELKGFK HKAFPLDDPOF, long FJBFONPAOAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6E0E390", Offset = "0x6E0D790", VA = "0x186E0E390", Slot = "48")]
	public string EJIPMHCCFAA(PALPGELKGFK HKAFPLDDPOF, int ACHIBPEDJIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6E0BC60", Offset = "0x6E0B060", VA = "0x186E0BC60")]
	private void CHODJBCPKKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6E14EB0", Offset = "0x6E142B0", VA = "0x186E14EB0")]
	private void MEBKNAKIICA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6E0D530", Offset = "0x6E0C930", VA = "0x186E0D530")]
	private PALPGELKGFK DMLFKMFDFFA(LPOPHHHBPDA LLNBENLMFGE)
	{
		return default(PALPGELKGFK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6E0D510", Offset = "0x6E0C910", VA = "0x186E0D510")]
	private PALPGELKGFK DKKFDPIGNKF(LPOPHHHBPDA LLNBENLMFGE)
	{
		return default(PALPGELKGFK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6E0A880", Offset = "0x6E09C80", VA = "0x186E0A880")]
	internal static string ACJLICKOFKJ(IEIPKBKGMFM HFCCJFPMBKD, string KNDKMGNKINN, bool GCDADEDDMKD, int LIHBABKMHED, int OGIGODHIOGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6E0DAB0", Offset = "0x6E0CEB0", VA = "0x186E0DAB0", Slot = "52")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6E0D490", Offset = "0x6E0C890", VA = "0x186E0D490")]
	private IEJAANOGAED DKCEIKOHFJP(JDJLHJHOJPN JKMCFDPMPIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6E110D0", Offset = "0x6E104D0", VA = "0x186E110D0")]
	private ANFGIAPIKFH HKDIOGEHNCI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6E0D010", Offset = "0x6E0C410", VA = "0x186E0D010")]
	private Task DCNGPNHNDCO(LMMLJLDDCAM CJLBFJEOAOD, CancellationToken NBBCMDKGJKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B380", Offset = "0x6E0A780", VA = "0x186E0B380")]
	[AsyncStateMachine(typeof(JCBPLJNCPPL))]
	private Task BJJFKOFKMLP(LMMLJLDDCAM CJLBFJEOAOD, CancellationToken NBBCMDKGJKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6E163B0", Offset = "0x6E157B0", VA = "0x186E163B0")]
	private Task OGKOJPJJLPC(LMMLJLDDCAM CJLBFJEOAOD, CancellationToken NBBCMDKGJKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6E156F0", Offset = "0x6E14AF0", VA = "0x186E156F0")]
	[AsyncStateMachine(typeof(OLIHFCGBHLA))]
	private Task NBNGGGNOOAG(string MOKGCFCFCPE, TimeSpan POBAEMLGMME, CancellationToken NBBCMDKGJKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6E169A0", Offset = "0x6E15DA0", VA = "0x186E169A0")]
	[CompilerGenerated]
	private void PCANILLCBFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B1F0", Offset = "0x6E0A5F0", VA = "0x186E0B1F0")]
	[CompilerGenerated]
	private void BABIGKMCBKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6E16F40", Offset = "0x6E16340", VA = "0x186E16F40")]
	[CompilerGenerated]
	private bool PKGCPDBAEKF(KeepsakeInstanceDTO LBEGFJJGJFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6E10AE0", Offset = "0x6E0FEE0", VA = "0x186E10AE0")]
	[CompilerGenerated]
	private MJGAHFINLMO<Dictionary<OLMJDNCJDKP, int>> GMKGGDGMHPF(Dictionary<Guid, OLMJDNCJDKP> HKEKCNCPLLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6E124E0", Offset = "0x6E118E0", VA = "0x186E124E0")]
	[CompilerGenerated]
	private MJGAHFINLMO<Dictionary<OLMJDNCJDKP, int>> IPKEJCPDCPH(Dictionary<Guid, OLMJDNCJDKP> HKEKCNCPLLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6E0BC40", Offset = "0x6E0B040", VA = "0x186E0BC40")]
	[CompilerGenerated]
	private bool CGCJLJAJNBH(KeepsakeRoomListDTO LBEGFJJGJFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6E0F0F0", Offset = "0x6E0E4F0", VA = "0x186E0F0F0")]
	[CompilerGenerated]
	private bool FJINLPAKNKJ(KeepsakeInstanceDTO LBEGFJJGJFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6E16DB0", Offset = "0x6E161B0", VA = "0x186E16DB0")]
	[CompilerGenerated]
	private void PGIBOKBOOHM(Tuple<KeepsakeRoomInstancesDTO, IReadOnlyDictionary<OLMJDNCJDKP, KeepsakeCategoryConfigDTO>, KeepsakeGlobalConfigDTO> MDGEJMLDPEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6E0CDF0", Offset = "0x6E0C1F0", VA = "0x186E0CDF0")]
	[CompilerGenerated]
	private void CMBFDKCOMLG(string MEDJAOOGFHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6E10C50", Offset = "0x6E10050", VA = "0x186E10C50")]
	[CompilerGenerated]
	private Task HCOPCFAMGIO(CancellationToken GEAHOFIMJGB)
	{
		return null;
	}
}
namespace RecRoom.Keepsakes
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public class KeepsakesConfig : ScriptableObject, FBEEFNEHFPG<KeepsakesConfig.KeepsakesOptions>
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200002B")]
		public class KeepsakesOptions
		{
			[Cpp2IlInjected.Token(Token = "0x200002C")]
			[CompilerGenerated]
			private sealed class LCDGMEOOMCC
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000098")]
				public string themeId;

				[Cpp2IlInjected.Token(Token = "0x60000F3")]
				[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
				public LCDGMEOOMCC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000F4")]
				[Cpp2IlInjected.Address(RVA = "0x6E0A7A0", Offset = "0x6E09BA0", VA = "0x186E0A7A0")]
				internal bool KENBGOCKMEI(KeepsakeTheme x)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60000F5")]
				[Cpp2IlInjected.Address(RVA = "0x6E0A7A0", Offset = "0x6E09BA0", VA = "0x186E0A7A0")]
				internal bool DEPDJBNBDMP(KeepsakeTheme x)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			[SerializeField]
			private KeepsakeTheme[] themes;

			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x6E0A5D0", Offset = "0x6E099D0", VA = "0x186E0A5D0")]
			public bool KOFBOPDGIFD(string PMPEBPGKHPK, [Out] KeepsakeTheme FKGALAIOIKD)
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
			[Cpp2IlInjected.Address(RVA = "0x8A89C0", Offset = "0x8A7DC0", VA = "0x1808A89C0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x6E0A550", Offset = "0x6E09950", VA = "0x186E0A550")]
		[OAJAKDHKADM.LHNCMMKCKFL.AGBJBPFJEIM]
		internal static void INBAICEHNJG(LBNNADLFMIK FKEBHAJCLGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0xA255A0", Offset = "0xA249A0", VA = "0x180A255A0")]
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
