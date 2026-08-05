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
using RecRoom.Keepsakes;
using RecRoom.NoEngine.Common;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Keepsakes
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public class KeepsakesConfig : ScriptableObject, JOCJAINBDJD<KeepsakesConfig.KeepsakesOptions>
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		public class KeepsakesOptions
		{
			[Cpp2IlInjected.Token(Token = "0x2000004")]
			[CompilerGenerated]
			private sealed class BDADFHLOFKC
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000003")]
				public string themeId;

				[Cpp2IlInjected.Token(Token = "0x6000006")]
				[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
				public BDADFHLOFKC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000007")]
				[Cpp2IlInjected.Address(RVA = "0x579AA00", Offset = "0x5799000", VA = "0x18579AA00")]
				internal bool PBKAJLPNLII(KeepsakeTheme x)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000008")]
				[Cpp2IlInjected.Address(RVA = "0x579AA00", Offset = "0x5799000", VA = "0x18579AA00")]
				internal bool KEBHGDIJPAE(KeepsakeTheme x)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000002")]
			[SerializeField]
			private KeepsakeTheme[] themes;

			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x959E30", Offset = "0x958430", VA = "0x180959E30")]
			public KeepsakesOptions([Optional] KeepsakeTheme[] PEKKOLCHIIJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x57AB150", Offset = "0x57A9750", VA = "0x1857AB150")]
			public bool MOKOGANPDNK(string HBHMDCLPEIN, out KeepsakeTheme PCAOCBHMGLN)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		private KeepsakesOptions options;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public KeepsakesOptions Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x86F2B0", Offset = "0x86D8B0", VA = "0x18086F2B0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x57AB0D0", Offset = "0x57A96D0", VA = "0x1857AB0D0")]
		[PJEDGFFEDPC(PDIHHCLCNFI.GameOnly)]
		private static void ACDBAIMHKIG(EIHIACACEHJ GEAGAOEEJFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9A2FF0", Offset = "0x9A15F0", VA = "0x1809A2FF0")]
		public KeepsakesConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class PPBIJOAJEPE : IComparer<NHINHHJKNOE>
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class MPBPCMOGPHK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public NHINHHJKNOE x;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public NHINHHJKNOE y;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public MPBPCMOGPHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xC0B750", Offset = "0xC09D50", VA = "0x180C0B750")]
		internal bool PKHLHKEEOAA(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xDBF5A0", Offset = "0xDBDBA0", VA = "0x180DBF5A0")]
		internal bool IJEEIKHGLPO(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xC0B750", Offset = "0xC09D50", VA = "0x180C0B750")]
		internal bool LFEBHAMNGAE(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xDBF5A0", Offset = "0xDBDBA0", VA = "0x180DBF5A0")]
		internal bool DKEGFKEJPPA(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<KeepsakeCategoryThemePair> JEOFFCCJABO;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x959E30", Offset = "0x958430", VA = "0x180959E30")]
	public PPBIJOAJEPE(List<KeepsakeCategoryThemePair> AGNPJGCLIHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x57AC0F0", Offset = "0x57AA6F0", VA = "0x1857AC0F0", Slot = "4")]
	public int Compare(NHINHHJKNOE HMINFBNCMPL, NHINHHJKNOE MPEHLADJKCP)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum HBOFHHNGNFF
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Running,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	Completed,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Faulted
}
namespace RecRoom.Keepsakes
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct KeepsakeCategoryThemePair
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public NHINHHJKNOE KeepsakeCategory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public KeepsakeTheme KeepsakeTheme;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[GGHJLFJGPPO]
public class KLNGBFMKNOJ : NEEJAOENAHK, IDisposable
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct HLLFMHKBFCI
	{
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public const string DHAIPMOCMDL = "Keepsake placement still in progress. Please wait a moment before placing another keepsake.";

		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public const string HPLFEKMLPMM = "The keepsake feature is disabled.";

		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public const string GHFEGIFLBOA = "This account is not authorized to place keepsakes.";

		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public const string NGGCLFPOFAA = "Must be at least a room co-owner to modify keepsakes.";

		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public const string KNGHDCPAGDB = "Invalid keepsake.";

		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public const string KIPHCIPECJA = "Keepsake is already collected.";

		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public const string GLNGDEJGEDM = "You have to collect other keepsakes before you can collect this one.";

		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public const string CPAIGHFDECF = "The keepsake is not in your current room.";

		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public const string KFILGMGEFBA = "Cannot add or remove keepsakes while limited time event is active.";

		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public const string NNFLPFIHIEN = "Cannot collect keepsake after limited time event has ended.";

		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public const string KKHOIBIJGAO = "This room does not have keepsake permissions.";

		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public const string NJNIBKCIOAN = "This room has not unlocked yet.";

		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public const string GJJLEKPPBNC = "This room is locked until its unlock item is purchased.";
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class OIINMBFMMLO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public KLNGBFMKNOJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public NHINHHJKNOE keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public OIINMBFMMLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x57ABA30", Offset = "0x57AA030", VA = "0x1857ABA30")]
		internal LEKACFEIBBA<Guid> LPIKMGHNPEA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x57ABB70", Offset = "0x57AA170", VA = "0x1857ABB70")]
		internal void MCPKJOCJDPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x57ABBA0", Offset = "0x57AA1A0", VA = "0x1857ABBA0")]
		internal void MPHCMPFKFGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x57ABC00", Offset = "0x57AA200", VA = "0x1857ABC00")]
		internal void PHEALMMJCIJ(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x57ABA00", Offset = "0x57AA000", VA = "0x1857ABA00")]
		internal void HPLHLKAJIAO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class KMOAIJJCILJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public KLNGBFMKNOJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public string keepsakePickupName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public int collectedKeepsakeCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public int collectableKeepsakeCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public Guid keepsakeInstanceId;

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public KMOAIJJCILJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x57AAB60", Offset = "0x57A9160", VA = "0x1857AAB60")]
		internal void AEPOMKMOPKB(NIBAEBKHDAH response)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x57AAF10", Offset = "0x57A9510", VA = "0x1857AAF10")]
		internal void ICFBCNIJCJB(string error)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class CJPNEFHGCPP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public KeepsakeTheme theme;

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public CJPNEFHGCPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x579ACE0", Offset = "0x57992E0", VA = "0x18579ACE0")]
		internal bool NOJJDFAIIKM(KeepsakeCategoryThemePair categoryThemePair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class IBDEHMMIMED
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public KLNGBFMKNOJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public NHINHHJKNOE keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public IBDEHMMIMED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x579BA70", Offset = "0x579A070", VA = "0x18579BA70")]
		internal bool KJHHJFNPNGH(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class EGLAPGBEBOO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public KLNGBFMKNOJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public long progressionEventId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public NHINHHJKNOE? keepsakeCategory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public EGLAPGBEBOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x579B320", Offset = "0x5799920", VA = "0x18579B320")]
		internal void JBJDAOMPGFF(KeepsakeProgressionEventInstancesDTO result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x579B2D0", Offset = "0x57998D0", VA = "0x18579B2D0")]
		internal void GKICJCEOBNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x579AFC0", Offset = "0x57995C0", VA = "0x18579AFC0")]
		internal LEKACFEIBBA<IEnumerable<Guid>> CMJOJDCLJNE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x579B300", Offset = "0x5799900", VA = "0x18579B300")]
		internal bool GKPGPKDLCMB(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class EINNHIPBOEN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public KeepsakeRoomInstanceIdsDTO instancesInRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public EGLAPGBEBOO CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public EINNHIPBOEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x579B3A0", Offset = "0x57999A0", VA = "0x18579B3A0")]
		internal LEKACFEIBBA<IEnumerable<Guid>> JIEELFFMABG(KeepsakeRoomInstancesDTO roomInstancesDTO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class BFABJHCNBAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public KeepsakeRoomInstancesDTO roomInstancesDTO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public EINNHIPBOEN CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public BFABJHCNBAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x579AA30", Offset = "0x5799030", VA = "0x18579AA30")]
		internal bool EIPJBANIHOA(Guid instanceId)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class NDJPEMAHOGE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public Guid instanceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public BFABJHCNBAN CS$<>8__locals3;

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public NDJPEMAHOGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x57AB320", Offset = "0x57A9920", VA = "0x1857AB320")]
		internal bool LBBDDIMDBNJ(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class CNPANIBPNDM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public KLNGBFMKNOJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public CNPANIBPNDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x579AD10", Offset = "0x5799310", VA = "0x18579AD10")]
		internal LEKACFEIBBA<IEnumerable<Guid>> KHBLNNHKFIG(IEnumerable<Guid> instanceIds)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x4DB0EE0", Offset = "0x4DAF4E0", VA = "0x184DB0EE0")]
		internal bool KEPJKMPAENO(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class FKMMKBLMPAI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public KLNGBFMKNOJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public long progressionEventId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public FKMMKBLMPAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x579B870", Offset = "0x5799E70", VA = "0x18579B870")]
		internal void LJCEKCGIACP(KeepsakeProgressionEventInstancesDTO result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x579B2D0", Offset = "0x57998D0", VA = "0x18579B2D0")]
		internal void KLEINHJMJDE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x579B570", Offset = "0x5799B70", VA = "0x18579B570")]
		internal LEKACFEIBBA<Dictionary<Guid, NHINHHJKNOE>> BIOMBOCAIDL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x579B300", Offset = "0x5799900", VA = "0x18579B300")]
		internal bool OGDNAPFONKC(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class NHKIKKOPLBE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public KeepsakeRoomInstanceIdsDTO instancesInRoom;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public NHKIKKOPLBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x57AB580", Offset = "0x57A9B80", VA = "0x1857AB580")]
		internal LEKACFEIBBA<Dictionary<Guid, NHINHHJKNOE>> MFMCIOMKLNC(KeepsakeRoomInstancesDTO roomInstancesDTO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class IBOBGHJDGFK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public KeepsakeRoomInstancesDTO roomInstancesDTO;

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public IBOBGHJDGFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x579BB90", Offset = "0x579A190", VA = "0x18579BB90")]
		internal bool CELGFCIGFHC(Guid instanceId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x579BC80", Offset = "0x579A280", VA = "0x18579BC80")]
		internal KeyValuePair<Guid, NHINHHJKNOE> CPFNNNFEBNM(Guid instanceId)
		{
			return default(KeyValuePair<Guid, NHINHHJKNOE>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class CJOFPOCCFHE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public Guid instanceId;

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public CJOFPOCCFHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x579AC40", Offset = "0x5799240", VA = "0x18579AC40")]
		internal bool BOLAAKBFPCO(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class BFMGOKFNJIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public Guid instanceId;

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public BFMGOKFNJIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x579ABA0", Offset = "0x57991A0", VA = "0x18579ABA0")]
		internal bool ACHOKKEIAKD(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class OFBKHAJDJJP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public KLNGBFMKNOJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public OFBKHAJDJJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x57AB750", Offset = "0x57A9D50", VA = "0x1857AB750")]
		internal LEKACFEIBBA<Dictionary<Guid, NHINHHJKNOE>> ACLIHKCGKEC(Dictionary<Guid, NHINHHJKNOE> instanceIdsAndCategories)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x4DB0EE0", Offset = "0x4DAF4E0", VA = "0x184DB0EE0")]
		internal bool DBDKKNFAIAL(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class JGNLGNHICFM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public KeepsakeRoomInstanceIdsDTO collectedInstanceIds;

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public JGNLGNHICFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x579C520", Offset = "0x579AB20", VA = "0x18579C520")]
		internal bool OPHDGDMPMLM(KeyValuePair<Guid, NHINHHJKNOE> idCategoryPair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class NEOHFCHBEHD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public Dictionary<Guid, NHINHHJKNOE> instanceIdsAndCategories;

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public NEOHFCHBEHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x57AB420", Offset = "0x57A9A20", VA = "0x1857AB420")]
		internal KeyValuePair<NHINHHJKNOE, int> OLGCBACKAMK(NHINHHJKNOE category)
		{
			return default(KeyValuePair<NHINHHJKNOE, int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class CKMKACNNABI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public NHINHHJKNOE category;

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public CKMKACNNABI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0xFE3900", Offset = "0xFE1F00", VA = "0x180FE3900")]
		internal bool IEIKJJDEEHI(NHINHHJKNOE instanceCategory)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class KOHECPDEHLK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public Dictionary<Guid, NHINHHJKNOE> instanceIdsAndCategories;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public KOHECPDEHLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x57AAF70", Offset = "0x57A9570", VA = "0x1857AAF70")]
		internal KeyValuePair<NHINHHJKNOE, int> NOPILCEOMJK(NHINHHJKNOE category)
		{
			return default(KeyValuePair<NHINHHJKNOE, int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class JPOBJILANLC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public NHINHHJKNOE category;

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public JPOBJILANLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0xFE3900", Offset = "0xFE1F00", VA = "0x180FE3900")]
		internal bool KJBEEGHNAAO(NHINHHJKNOE instanceCategory)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class KFOBKFLEANJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public KLNGBFMKNOJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public Func<KeepsakeRoomDTO, bool> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public KFOBKFLEANJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x579C5C0", Offset = "0x579ABC0", VA = "0x18579C5C0")]
		internal bool DNMKKKGJKPC(DateTime nowUtc, DateTime eventStartTime, int roomOrder, TimeSpan unlockStartOffset, TimeSpan unlockInterval, int unlockBatchSize)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x579C6A0", Offset = "0x579ACA0", VA = "0x18579C6A0")]
		internal bool JNGKMKJKNEE(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x579C5A0", Offset = "0x579ABA0", VA = "0x18579C5A0")]
		internal bool DHKBJFOCKDC(KeepsakeRoomDTO r)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x579C5A0", Offset = "0x579ABA0", VA = "0x18579C5A0")]
		internal bool PAHJNNHKEHG(KeepsakeRoomDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class JAPPOPOKOKI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public JAPPOPOKOKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0xF9C2D0", Offset = "0xF9A8D0", VA = "0x180F9C2D0")]
		internal bool KFDNOJOJLPO(KeepsakeRoomListDTO roomList)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class EBMMPMPHHGB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public Func<KeepsakeRoomDTO, bool> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public EBMMPMPHHGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x579AEF0", Offset = "0x57994F0", VA = "0x18579AEF0")]
		internal bool ADJMCBPBNGE(KeepsakeRoomListDTO roomList)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0xC6A880", Offset = "0xC68E80", VA = "0x180C6A880")]
		internal bool FGBBLFLHMBG(KeepsakeRoomDTO room)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class DMGHABFJGIB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public DMGHABFJGIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x579AE80", Offset = "0x5799480", VA = "0x18579AE80")]
		internal bool BLKAPINHFOP(KeepsakeRoomListDTO i)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class NBACAKONDCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public NBACAKONDCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0xF9C2D0", Offset = "0xF9A8D0", VA = "0x180F9C2D0")]
		internal bool JDEEEBNPDGB(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class OHIGFJLBKNE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public Guid keepsakeInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public OHIGFJLBKNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x57AB970", Offset = "0x57A9F70", VA = "0x1857AB970")]
		internal bool IFDEIEJAJKC(KeyValuePair<Guid, KeepsakeInstanceDTO> instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class PNEFFBJFBKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public NHINHHJKNOE keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public PNEFFBJFBKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0xFB15C0", Offset = "0xFAFBC0", VA = "0x180FB15C0")]
		internal bool NCGLCNLLMNC(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class POEGHNBHPEG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public Guid keepsakeInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public POEGHNBHPEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x57AC060", Offset = "0x57AA660", VA = "0x1857AC060")]
		internal bool ALBOFPINIDF(KeyValuePair<Guid, KeepsakeInstanceDTO> instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class BFEKAMBPIDN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public NHINHHJKNOE keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public BFEKAMBPIDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x579AB60", Offset = "0x5799160", VA = "0x18579AB60")]
		internal bool IFINCJEJMBA(KeyValuePair<Guid, NHINHHJKNOE> x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class NHMKCNFBLJB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public NHINHHJKNOE newKeepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public NHMKCNFBLJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0xFB15C0", Offset = "0xFAFBC0", VA = "0x180FB15C0")]
		internal bool MIEOPENPHHI(KeepsakeInstanceDTO instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class GLBLIPKEMBI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public long currentRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public long? currentSubRoomId;

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public GLBLIPKEMBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x579B9E0", Offset = "0x5799FE0", VA = "0x18579B9E0")]
		internal bool CFCEJECNJGI(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class GKGKJJFHIJF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public IEnumerable<KeepsakeRoomListDTO> roomList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public GKGKJJFHIJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x579B8F0", Offset = "0x5799EF0", VA = "0x18579B8F0")]
		internal bool LCEMBOINCCC(KeepsakeRoomDTO room)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class EONHDEHOBDE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public KeepsakeRoomDTO room;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public GKGKJJFHIJF CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public EONHDEHOBDE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x579B4F0", Offset = "0x5799AF0", VA = "0x18579B4F0")]
		internal bool GBLPIBJJLHB(KeepsakeRoomListDTO roomListDto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class IDMJMPKCNMG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public EPFFDDEKBCK args;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public KLNGBFMKNOJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private Exception <e>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private List<KeepsakeInstanceDTO> <validKeepsakeInstances>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public IDMJMPKCNMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x579BE00", Offset = "0x579A400", VA = "0x18579BE00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class ILOFJLBMJFL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public string message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public TimeSpan delay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public KLNGBFMKNOJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public ILOFJLBMJFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x579C330", Offset = "0x579A930", VA = "0x18579C330", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private const int HLLALCADCJA = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly DateTime AEBLPENKENJ;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private const int KKIIFOLGIMF = 3;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private const long ONNKACIAPBL = -1L;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private const char DFJJLHHOIBJ = '|';

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly OFLLPDEHFIM GHPOFDEFNND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly HHFODJJHAJD FJEHBDDAPLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly EOCOGOKGKMN MAGCLCAENFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly IMOPGLGBEMP AAOIODAJFAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly NJPEDPIBAHB LCPJEGLKADH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly HBJCGAMHNII GCNLCDHFFMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly CHOIGDNKNLL GFLBKLKGHCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly HDOGFNJHJAM EGGPOCDMEIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly FFPDFAMPCEK ODABAEFJENI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly FAKNAAKAMLL GIGAOMMJKHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly HABIKIDGCKG GEIGOHFFCPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly CFPLGDAFHEJ FMEFFECEHEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly ELIPFEFIOLM EMICCMDELJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly AJINBAGEIEH OKKHHFAPGJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly EMOKLDEAGDL LJKGOGKHMEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly JOCJAINBDJD<KeepsakesConfig.KeepsakesOptions> FAJHLKMLAGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly GOAKOJLIONO EPJKBBIHJJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly Dictionary<Guid, KeepsakeInstanceDTO> GKBONNLGKEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly HashSet<Guid> KNDLGHIIPGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly HashSet<long> FGIDLCGLMFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private Dictionary<NHINHHJKNOE, int> JLEEALJONHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private readonly HashSet<Guid> MEPCPNCMIND;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private readonly IDisposable LOKGGLIBOCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private Task NBLBHBFONON;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private LEKACFEIBBA<Guid> JDCLNPKHPDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private long? CJBMPDPCMHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private KeepsakeProgressionEventInstancesDTO ANAALHHCGBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private LEKACFEIBBA<KeepsakeProgressionEventInstancesDTO> EEPKEHBAKOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private IReadOnlyDictionary<NHINHHJKNOE, KeepsakeCategoryConfigDTO> DFKOGAKMEEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private KeepsakeGlobalConfigDTO MAEKHIJOEPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private HashSet<long> EAKCFFFFJBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private HashSet<long> HJOBBOCBCOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private List<KeepsakeRoomListDTO> PLGNBIJKDBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private List<KeepsakeRoomListDTO> OKCNGBPJFOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private List<KeepsakeRoomListDTO> DCEMNKGIMFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private Dictionary<long, string> PONPDLDPCIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private Dictionary<long, string> NBHHMGAEMCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private Dictionary<long, DateTime> DFGGBONOHHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private Dictionary<long, List<KeepsakeRoomDTO>> IBJDGHJDOEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private Dictionary<long, List<KeepsakeRoomDTO>> KFOFBPJJLBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private Dictionary<long, long> NGKKBAAHHLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly List<string> EPGJFFFEFHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private DateTime MMIAECLGFDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly IDisposable JEJODPCGDKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private Dictionary<Guid, NHINHHJKNOE> EOIBGCCAONI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private Dictionary<NHINHHJKNOE, int> FGIFAEOPHJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private List<KeepsakeCategoryThemePair> AGNPJGCLIHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private PPBIJOAJEPE OJJHLMHDCAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private bool IEDHNAGMMOO;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool LMDCAOEAHOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x9584D0", Offset = "0x956AD0", VA = "0x1809584D0", Slot = "53")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x958220", Offset = "0x956820", VA = "0x180958220")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool PGJIFELPPAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x579F190", Offset = "0x579D790", VA = "0x18579F190", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool NJCNCKAILEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x57A2720", Offset = "0x57A0D20", VA = "0x1857A2720", Slot = "36")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private long FPMHJOHFNFK
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x579E9A0", Offset = "0x579CFA0", VA = "0x18579E9A0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private long? CLCHBHFPHBB
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x57A1AC0", Offset = "0x57A00C0", VA = "0x1857A1AC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private bool CBMBHMDPCNA
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x579F1E0", Offset = "0x579D7E0", VA = "0x18579F1E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public IReadOnlyList<KeepsakeRoomListDTO> BFIEKPDNNHN
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x14B1640", Offset = "0x14AFC40", VA = "0x1814B1640", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IReadOnlyList<KeepsakeRoomListDTO> HFNCDCPBFBL
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xD43120", Offset = "0xD41720", VA = "0x180D43120", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public IReadOnlyList<KeepsakeRoomListDTO> DHIKFFIJKCI
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xD77800", Offset = "0xD75E00", VA = "0x180D77800", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public IReadOnlyDictionary<long, string> GLOJOGEJFKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xCCA340", Offset = "0xCC8940", VA = "0x180CCA340", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public IReadOnlyDictionary<long, string> LMNNKMCEONK
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xD776A0", Offset = "0xD75CA0", VA = "0x180D776A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	internal bool JLOEMIPIDEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x14B1650", Offset = "0x14AFC50", VA = "0x1814B1650")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x57A6CF0", Offset = "0x57A52F0", VA = "0x1857A6CF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Guid?> DMLDPAIOMJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x57A4690", Offset = "0x57A2C90", VA = "0x1857A4690", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x57A24A0", Offset = "0x57A0AA0", VA = "0x1857A24A0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action EIKLMNAGGAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x579EAB0", Offset = "0x579D0B0", VA = "0x18579EAB0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x57A8BF0", Offset = "0x57A71F0", VA = "0x1857A8BF0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action EGDOKLEHBFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x57A0BD0", Offset = "0x579F1D0", VA = "0x1857A0BD0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x579FEC0", Offset = "0x579E4C0", VA = "0x18579FEC0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x57A9840", Offset = "0x57A7E40", VA = "0x1857A9840")]
	[Preserve]
	internal KLNGBFMKNOJ([NotNull][NALHKAIJJND(null)] OFLLPDEHFIM GHPOFDEFNND, [NotNull][NALHKAIJJND(null)] IBCIOGFALAD MCBNJNCDBMH, [NotNull][NALHKAIJJND(null)] HHFODJJHAJD FJEHBDDAPLA, [NotNull][NALHKAIJJND(null)] EOCOGOKGKMN MAGCLCAENFE, [NotNull][NALHKAIJJND(null)] IMOPGLGBEMP AAOIODAJFAJ, [NotNull][NALHKAIJJND(null)] NJPEDPIBAHB LCPJEGLKADH, [NotNull][NALHKAIJJND(null)] HBJCGAMHNII GCNLCDHFFMO, [NotNull][NALHKAIJJND(null)] CHOIGDNKNLL GFLBKLKGHCO, [NotNull][NALHKAIJJND(null)] HDOGFNJHJAM EGGPOCDMEIJ, [NotNull][NALHKAIJJND(null)] PHCPDFDAHLE PGHPIPDPLIK, [NotNull][NALHKAIJJND(null)] FFPDFAMPCEK ODABAEFJENI, [NotNull][NALHKAIJJND(null)] FAKNAAKAMLL GIGAOMMJKHA, [NotNull][NALHKAIJJND(null)] HABIKIDGCKG GEIGOHFFCPN, [NotNull][NALHKAIJJND(null)] CFPLGDAFHEJ FMEFFECEHEK, [NotNull][NALHKAIJJND(null)] ELIPFEFIOLM EMICCMDELJE, [NotNull][NALHKAIJJND(null)] AJINBAGEIEH OKKHHFAPGJF, [NotNull][NALHKAIJJND(null)] EMOKLDEAGDL LJKGOGKHMEL, [NotNull][NALHKAIJJND(null)] JOCJAINBDJD<KeepsakesConfig.KeepsakesOptions> FAJHLKMLAGA, [NotNull][NALHKAIJJND(null)] GOAKOJLIONO EPJKBBIHJJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x57A6D60", Offset = "0x57A5360", VA = "0x1857A6D60", Slot = "15")]
	public bool NGOGIGMIGAP(List<string> HACBBPJFDDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x57A27F0", Offset = "0x57A0DF0", VA = "0x1857A27F0", Slot = "16")]
	public LEKACFEIBBA<Guid> JAPALLFKPCA(NHINHHJKNOE DOLKJBDIFLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x579D450", Offset = "0x579BA50", VA = "0x18579D450", Slot = "17")]
	public ADCACBFKFKM AMKNLHGGPKG(Guid BHBNPLODPJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x57A8730", Offset = "0x57A6D30", VA = "0x1857A8730", Slot = "18")]
	public ADCACBFKFKM OIDBPOKJNOL(Guid BHBNPLODPJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x579DC20", Offset = "0x579C220", VA = "0x18579DC20", Slot = "19")]
	public bool BKPDJPDKCBJ(Guid BHBNPLODPJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x579EA80", Offset = "0x579D080", VA = "0x18579EA80", Slot = "20")]
	public bool DDFEEDMFCGF(Guid BHBNPLODPJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x57A7640", Offset = "0x57A5C40", VA = "0x1857A7640")]
	public KeepsakeTheme NOEKNCHONNH(Guid BHBNPLODPJC)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x57A1500", Offset = "0x579FB00", VA = "0x1857A1500")]
	public bool GLFOILHJCKJ(NHINHHJKNOE DOLKJBDIFLO, out KeepsakeTheme PCAOCBHMGLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x57A4D60", Offset = "0x57A3360", VA = "0x1857A4D60")]
	public List<KeepsakeTheme> LINMHOJAIHH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x579D9D0", Offset = "0x579BFD0", VA = "0x18579D9D0")]
	public int BDHCEBLDGHH(NHINHHJKNOE DOLKJBDIFLO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x579E830", Offset = "0x579CE30", VA = "0x18579E830")]
	public NHINHHJKNOE CMPPCEAPPAB(Guid BHBNPLODPJC)
	{
		return default(NHINHHJKNOE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x579E6E0", Offset = "0x579CCE0", VA = "0x18579E6E0", Slot = "34")]
	public List<NHINHHJKNOE> CKEKJGCJALG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x57A1A20", Offset = "0x57A0020", VA = "0x1857A1A20", Slot = "35")]
	public IComparer<NHINHHJKNOE> IDHMLKBNFMH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x579F020", Offset = "0x579D620", VA = "0x18579F020", Slot = "32")]
	public string EAEJMCEDFLO(NHINHHJKNOE DOLKJBDIFLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x579D2C0", Offset = "0x579B8C0", VA = "0x18579D2C0", Slot = "33")]
	public string AKBNFCHNIHD(NHINHHJKNOE DOLKJBDIFLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x57A3BB0", Offset = "0x57A21B0", VA = "0x1857A3BB0", Slot = "21")]
	public bool JKPJECENAJN(Guid BHBNPLODPJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x579EB50", Offset = "0x579D150", VA = "0x18579EB50", Slot = "22")]
	public void DLAKEOEIIDC(Guid BHBNPLODPJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x579E1D0", Offset = "0x579C7D0", VA = "0x18579E1D0", Slot = "23")]
	public void CEIIOCJACMC(NHINHHJKNOE DOLKJBDIFLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x57A0810", Offset = "0x579EE10", VA = "0x1857A0810", Slot = "24")]
	public void FDABNPMJOCN(Guid BHBNPLODPJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x579F8C0", Offset = "0x579DEC0", VA = "0x18579F8C0", Slot = "25")]
	public int EMDBEGPJPDC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x579F550", Offset = "0x579DB50", VA = "0x18579F550", Slot = "54")]
	public int EMDBEGPJPDC(NHINHHJKNOE DOLKJBDIFLO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x57A8170", Offset = "0x57A6770", VA = "0x1857A8170", Slot = "31")]
	public LEKACFEIBBA<IEnumerable<Guid>> OGBFCNKIKBO(long EDDMGMBKEBK, long DGNKKLIGEOC, NHINHHJKNOE? DOLKJBDIFLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x57A0390", Offset = "0x579E990", VA = "0x1857A0390", Slot = "30")]
	public LEKACFEIBBA<IEnumerable<Guid>> EPJOMMHHMJM(long EDDMGMBKEBK, long DGNKKLIGEOC, NHINHHJKNOE? DOLKJBDIFLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x57A0DF0", Offset = "0x579F3F0", VA = "0x1857A0DF0", Slot = "55")]
	public LEKACFEIBBA<Dictionary<Guid, NHINHHJKNOE>> GAEJHLAFIFM(long EDDMGMBKEBK, long DGNKKLIGEOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x57A7FE0", Offset = "0x57A65E0", VA = "0x1857A7FE0", Slot = "56")]
	public LEKACFEIBBA<Dictionary<Guid, NHINHHJKNOE>> OENOPAMNEHM(long EDDMGMBKEBK, long DGNKKLIGEOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x579CC70", Offset = "0x579B270", VA = "0x18579CC70", Slot = "26")]
	public LEKACFEIBBA<int> AHCIGKMPNKL(long EDDMGMBKEBK, long DGNKKLIGEOC, NHINHHJKNOE? DOLKJBDIFLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x57A0A60", Offset = "0x579F060", VA = "0x1857A0A60", Slot = "27")]
	public LEKACFEIBBA<int> FDKEOOKBCCJ(long EDDMGMBKEBK, long DGNKKLIGEOC, NHINHHJKNOE? DOLKJBDIFLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x57A51D0", Offset = "0x57A37D0", VA = "0x1857A51D0", Slot = "28")]
	public LEKACFEIBBA<Dictionary<NHINHHJKNOE, int>> LMMHAOKDKOI(long EDDMGMBKEBK, long DGNKKLIGEOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x579E100", Offset = "0x579C700", VA = "0x18579E100", Slot = "29")]
	public LEKACFEIBBA<Dictionary<NHINHHJKNOE, int>> CCOIHBHNMDE(long EDDMGMBKEBK, long DGNKKLIGEOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x579E210", Offset = "0x579C810", VA = "0x18579E210", Slot = "37")]
	public bool CFFHOCGCODB(long EDDMGMBKEBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x57A18D0", Offset = "0x579FED0", VA = "0x1857A18D0", Slot = "57")]
	public bool HBLKJOECNJD(long EDDMGMBKEBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x57A8AB0", Offset = "0x57A70B0", VA = "0x1857A8AB0", Slot = "38")]
	public bool OMOOJGGPPFK(long EDDMGMBKEBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x57A9420", Offset = "0x57A7A20", VA = "0x1857A9420", Slot = "58")]
	public bool PKHMDNLIPOE(long EDDMGMBKEBK, out IIJLPGJKDPK PKHAFDBCFOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x57A8C90", Offset = "0x57A7290", VA = "0x1857A8C90", Slot = "39")]
	public bool PGONFJKODCK(long PICNFCHGPOB, out DateTime PGGAINGBBMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x579FF60", Offset = "0x579E560", VA = "0x18579FF60", Slot = "40")]
	public long EOFADNLKOKG(long PICNFCHGPOB)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x57A1C40", Offset = "0x57A0240", VA = "0x1857A1C40", Slot = "59")]
	public IEnumerable<int> IGKGBMHALHM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x57A7070", Offset = "0x57A5670", VA = "0x1857A7070", Slot = "41")]
	public long NHPBKACCIBJ(long EDDMGMBKEBK)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x57A5AE0", Offset = "0x57A40E0", VA = "0x1857A5AE0", Slot = "42")]
	public int MNJNAOGJCHF(long PICNFCHGPOB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x579DB30", Offset = "0x579C130", VA = "0x18579DB30", Slot = "43")]
	public bool BHLAHDJPJGM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x579E420", Offset = "0x579CA20", VA = "0x18579E420", Slot = "44")]
	public bool CIEJLJIAADB(long PICNFCHGPOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x57A2540", Offset = "0x57A0B40", VA = "0x1857A2540", Slot = "45")]
	public IEnumerable<long> INFLFFEPEME(long PICNFCHGPOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x57A7F30", Offset = "0x57A6530", VA = "0x1857A7F30", Slot = "46")]
	public int OEHELFHJMII(long PICNFCHGPOB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x57A7190", Offset = "0x57A5790", VA = "0x1857A7190", Slot = "50")]
	public long NIGIIOGFCCD(long PALCPIKIKLB)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x57A7800", Offset = "0x57A5E00", VA = "0x1857A7800", Slot = "51")]
	public NHINHHJKNOE OANKFFGHJFN()
	{
		return default(NHINHHJKNOE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x57A8560", Offset = "0x57A6B60", VA = "0x1857A8560")]
	private bool OGHJMMBGMJJ(Guid BHBNPLODPJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x57A3F80", Offset = "0x57A2580", VA = "0x1857A3F80")]
	private void KFKIENHOCDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x579D6D0", Offset = "0x579BCD0", VA = "0x18579D6D0")]
	private NHINHHJKNOE BCJELEHMHIG()
	{
		return default(NHINHHJKNOE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x57A5530", Offset = "0x57A3B30", VA = "0x1857A5530")]
	private void MIKFMBFHJPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x579E270", Offset = "0x579C870", VA = "0x18579E270")]
	private int CGNOOMFICDO(KeepsakeRoomListDTO FLJPLNNLLBB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x579C770", Offset = "0x579AD70", VA = "0x18579C770")]
	private int AAFCCCKOJCM(DateTime MAEPAEKHNII, DateTime FBHEFJPEMJC, TimeSpan JKICMPHPEOD, int DEAEJEINILL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x579F340", Offset = "0x579D940", VA = "0x18579F340")]
	private void EKBHOPIDJCC(IEnumerable<KeepsakeInstanceDTO> GKBONNLGKEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x57A4B20", Offset = "0x57A3120", VA = "0x1857A4B20")]
	private void LBCEOKDBBMH(IEnumerable<KeepsakeCollectionRecordDTO> HJLPMJMLJGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x57A3F20", Offset = "0x57A2520", VA = "0x1857A3F20")]
	private void KDBCNAFFKPL(IEnumerable<long> PEJHPCOBEPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0xF5C000", Offset = "0xF5A600", VA = "0x180F5C000")]
	private void HLKBIBJJGOJ(KeepsakeGlobalConfigDTO MAEKHIJOEPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x57A6A40", Offset = "0x57A5040", VA = "0x1857A6A40")]
	private bool NBCEODBGBDN(NHINHHJKNOE DOLKJBDIFLO, out Guid PGGNIEOFMEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x57A3E50", Offset = "0x57A2450", VA = "0x1857A3E50")]
	private bool JMNEILMNJNB(out Guid PGGNIEOFMEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x57A19C0", Offset = "0x579FFC0", VA = "0x1857A19C0")]
	private bool HPEJHNLLNLK(Guid BHBNPLODPJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x57A0C70", Offset = "0x579F270", VA = "0x1857A0C70")]
	private IEnumerable<Guid> FKLNKKILFJK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x57A1290", Offset = "0x579F890", VA = "0x1857A1290")]
	private IEnumerable<KeepsakeInstanceDTO> GDPIJJMKFCP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x579C9C0", Offset = "0x579AFC0", VA = "0x18579C9C0")]
	private void ABDCEDEHLHG(Guid BHBNPLODPJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x57A3570", Offset = "0x57A1B70", VA = "0x1857A3570")]
	private bool JEIIAMMGOBD(Guid BHBNPLODPJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x57A1360", Offset = "0x579F960", VA = "0x1857A1360")]
	private void GHNMLHHAGPN(Guid BHBNPLODPJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x57A1B60", Offset = "0x57A0160", VA = "0x1857A1B60")]
	private void IGCNOBNBOKD(NHINHHJKNOE IKBGHKLDENG, int NCDLCNBPFPE, ref Dictionary<NHINHHJKNOE, int> OMCPFJGMEGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x57A4900", Offset = "0x57A2F00", VA = "0x1857A4900")]
	private int KLJKIMBHAAE(NHINHHJKNOE DOLKJBDIFLO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x579CA50", Offset = "0x579B050", VA = "0x18579CA50")]
	private void ABONAEOPFAM(KeepsakeInstanceDTO EPAAHLJOCPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x57A16D0", Offset = "0x579FCD0", VA = "0x1857A16D0")]
	private void GNFFEHLLBAJ(KeepsakeInstanceDTO EPAAHLJOCPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x57A7BB0", Offset = "0x57A61B0", VA = "0x1857A7BB0")]
	private void OCOGEBDGOMO(Guid BHBNPLODPJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x57A3620", Offset = "0x57A1C20", VA = "0x1857A3620")]
	private void JFABFBGDHCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x579D430", Offset = "0x579BA30", VA = "0x18579D430")]
	private void AMBAOCNFHCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x57A2E20", Offset = "0x57A1420", VA = "0x1857A2E20")]
	private void JBFLGCEPPMM(MEALHALACCD CJBHPGFBNKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x57A97E0", Offset = "0x57A7DE0", VA = "0x1857A97E0")]
	private void PPALHCCKAEI(NEKNLJFPOHC.KBANAPJGMEG IAMEECMGPIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x57A11D0", Offset = "0x579F7D0", VA = "0x1857A11D0")]
	private void GBAKFOMJLPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x57A8F60", Offset = "0x57A7560", VA = "0x1857A8F60")]
	private void PJDOHIOGNHO(float ENFPIMAOMDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x57A3010", Offset = "0x57A1610", VA = "0x1857A3010")]
	private void JDFLEGPGKOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x57A86A0", Offset = "0x57A6CA0", VA = "0x1857A86A0")]
	private bool OHNCJEEHFNN(Guid BHBNPLODPJC, out string NDEHKHOJNJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x57A4730", Offset = "0x57A2D30", VA = "0x1857A4730")]
	private bool KKKHBPPKIPD(Guid BHBNPLODPJC, out KeepsakeCategoryConfigDTO IKBGHKLDENG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x57A3680", Offset = "0x57A1C80", VA = "0x1857A3680")]
	private void JFHCGNMHABP(string EGOBKGDOFOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x57A4A00", Offset = "0x57A3000", VA = "0x1857A4A00")]
	private bool KOPFICJHIMD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x57A0530", Offset = "0x579EB30", VA = "0x1857A0530")]
	private IEnumerable<long> FAPIEHPBODE(IEnumerable<KeepsakeRoomDTO> LAALCIAJPEH, IEnumerable<KeepsakeRoomListDTO> LJGEPHEGEEF, long PICNFCHGPOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x57A1E90", Offset = "0x57A0490", VA = "0x1857A1E90")]
	private bool IHBAJDAJANF(Guid BHBNPLODPJC, out string KAEDNDEPIBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x57A1230", Offset = "0x579F830", VA = "0x1857A1230", Slot = "47")]
	public string GCBJPKBCALE(IKBGIOLBELG HLNGHNGFGFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x57A3760", Offset = "0x57A1D60", VA = "0x1857A3760", Slot = "49")]
	public string JFKJJELPMOH(IKBGIOLBELG HLNGHNGFGFC, long EDDMGMBKEBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x57A50B0", Offset = "0x57A36B0", VA = "0x1857A50B0", Slot = "48")]
	public string LLAPMBLNPBE(IKBGIOLBELG HLNGHNGFGFC, int CFPEMLGGEHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x57A5CE0", Offset = "0x57A42E0", VA = "0x1857A5CE0")]
	private void MOOKLCJPPMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x579F200", Offset = "0x579D800", VA = "0x18579F200")]
	private void EHHILLLICIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x579DD70", Offset = "0x579C370", VA = "0x18579DD70")]
	private IKBGIOLBELG BLLKAFPHJMB(BAFOBLIBAOL HNGIMKFFEJJ)
	{
		return default(IKBGIOLBELG);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x57A77E0", Offset = "0x57A5DE0", VA = "0x1857A77E0")]
	private IKBGIOLBELG NPPCHDKECCC(BAFOBLIBAOL HNGIMKFFEJJ)
	{
		return default(IKBGIOLBELG);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x579DF20", Offset = "0x579C520", VA = "0x18579DF20")]
	internal static string CAMOMHMEIPK(NIBAEBKHDAH CGMOGCAIPPC, string EMGPIPKJEBN, bool DFBDCMLKKEG, int PHBDMDCNEGB, int PABOAAKALGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x579EBC0", Offset = "0x579D1C0", VA = "0x18579EBC0", Slot = "52")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x57A1930", Offset = "0x579FF30", VA = "0x1857A1930")]
	private LOJBOFKMJHM HMMJMDEDNPE(IFFNBNNJJLC OABCKJAKNMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x579FD20", Offset = "0x579E320", VA = "0x18579FD20")]
	private JAEANCGJHOM EMEIKBAMMGH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x579CF30", Offset = "0x579B530", VA = "0x18579CF30")]
	private Task AHHPFAMELPA(EPFFDDEKBCK GDDHAFPALIL, CancellationToken OOAGLCBNIOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x57A2EA0", Offset = "0x57A14A0", VA = "0x1857A2EA0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(IDMJMPKCNMG))]
	private Task JBMLJACKPCK(EPFFDDEKBCK GDDHAFPALIL, CancellationToken OOAGLCBNIOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x57A8B50", Offset = "0x57A7150", VA = "0x1857A8B50")]
	private Task PBCCGAPLAOG(EPFFDDEKBCK GDDHAFPALIL, CancellationToken OOAGLCBNIOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x579DD90", Offset = "0x579C390", VA = "0x18579DD90")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(ILOFJLBMJFL))]
	private Task CALLEBDICJD(string JIEHBANCLJP, TimeSpan KJAFNGOKNKP, CancellationToken OOAGLCBNIOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x4215E90", Offset = "0x4214490", VA = "0x184215E90")]
	[CompilerGenerated]
	private void DOHOJHMPCJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x57A2450", Offset = "0x57A0A50", VA = "0x1857A2450")]
	[CompilerGenerated]
	private void IIADGEICLPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x57A9330", Offset = "0x57A7930", VA = "0x1857A9330")]
	[CompilerGenerated]
	private bool PKCOAHNJJPI(KeepsakeInstanceDTO HMINFBNCMPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x57A74C0", Offset = "0x57A5AC0", VA = "0x1857A74C0")]
	[CompilerGenerated]
	private LEKACFEIBBA<Dictionary<NHINHHJKNOE, int>> NKOKDIILOAO(Dictionary<Guid, NHINHHJKNOE> NJNEAKPMGCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x57A8DE0", Offset = "0x57A73E0", VA = "0x1857A8DE0")]
	[CompilerGenerated]
	private LEKACFEIBBA<Dictionary<NHINHHJKNOE, int>> PJALNJCNHDN(Dictionary<Guid, NHINHHJKNOE> NJNEAKPMGCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x57A0DD0", Offset = "0x579F3D0", VA = "0x1857A0DD0")]
	[CompilerGenerated]
	private bool FPGBBHICPLG(KeepsakeRoomListDTO HMINFBNCMPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x57A5400", Offset = "0x57A3A00", VA = "0x1857A5400")]
	[CompilerGenerated]
	private bool MCFCMGLFELP(KeepsakeInstanceDTO HMINFBNCMPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x579C840", Offset = "0x579AE40", VA = "0x18579C840")]
	[CompilerGenerated]
	private void AAPJHEAFHIJ(Tuple<KeepsakeRoomInstancesDTO, IReadOnlyDictionary<NHINHHJKNOE, KeepsakeCategoryConfigDTO>, KeepsakeGlobalConfigDTO> KEMHJBDKFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x579CC10", Offset = "0x579B210", VA = "0x18579CC10")]
	[CompilerGenerated]
	private void ADCOICAMDGG(string KAEDNDEPIBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x57A4460", Offset = "0x57A2A60", VA = "0x1857A4460")]
	[CompilerGenerated]
	private Task KGFCFLNAFNI(CancellationToken NMLNHOEOIGJ)
	{
		return null;
	}
}
namespace RecRoom.Keepsakes
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public struct KeepsakeTheme
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public string ThemeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public int ThemeOrder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		[Header("Pickup")]
		public string PickupName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public GameObject PickupPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public AudioClip PickupSfx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public float PickupSfxVolume;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		[Header("Colors")]
		public bool UseCustomColors;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public Color BeamColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public Color BaseColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		[Header("Looping Sound")]
		public AudioClip LoopingSfx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public float LoopingSfxVolume;
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class IMLHFCPJGKL
{
	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
	public IMLHFCPJGKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0xD12BC0", Offset = "0xD111C0", VA = "0x180D12BC0")]
	public static string GOMDFOEHABF(byte[] CEBGDHINIFO, byte[] FGJCLMKLDKK)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public class __BB_OBFUSCATOR_VERSION_3_10_0
	{
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
