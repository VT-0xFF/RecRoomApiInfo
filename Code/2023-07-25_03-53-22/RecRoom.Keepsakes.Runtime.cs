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
	public class KeepsakesConfig : ScriptableObject, PECGFOJMAPA<KeepsakesConfig.KeepsakesOptions>
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		public class KeepsakesOptions
		{
			[Cpp2IlInjected.Token(Token = "0x2000004")]
			[CompilerGenerated]
			private sealed class GNLMPMLOBMC
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000003")]
				public string themeId;

				[Cpp2IlInjected.Token(Token = "0x6000006")]
				[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
				public GNLMPMLOBMC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000007")]
				[Cpp2IlInjected.Address(RVA = "0x579BAF0", Offset = "0x579AAF0", VA = "0x18579BAF0")]
				internal bool CONDFHJHPMG(KeepsakeTheme x)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000008")]
				[Cpp2IlInjected.Address(RVA = "0x579BAF0", Offset = "0x579AAF0", VA = "0x18579BAF0")]
				internal bool PPKLMMJEMJK(KeepsakeTheme x)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000002")]
			[SerializeField]
			private KeepsakeTheme[] themes;

			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x919D70", Offset = "0x918D70", VA = "0x180919D70")]
			public KeepsakesOptions([Optional] KeepsakeTheme[] FCGLINBFJNL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x579D4C0", Offset = "0x579C4C0", VA = "0x18579D4C0")]
			public bool LLCMPDCHHAA(string BIBPJHLPPCO, out KeepsakeTheme JEKFDJMFKJG)
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
			[Cpp2IlInjected.Address(RVA = "0x913300", Offset = "0x912300", VA = "0x180913300", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x579D440", Offset = "0x579C440", VA = "0x18579D440")]
		[FBCFLFBFGIL(LAFFCBAHJKM.GameOnly)]
		private static void HEBPGFNGBNI(CNALHHIKJDD DBGHBAHCJKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA756E0", Offset = "0xA746E0", VA = "0x180A756E0")]
		public KeepsakesConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class JHPGHPGPJMC : IComparer<KMEGHOEMOEP>
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class EGFLOANIIIN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public KMEGHOEMOEP x;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public KMEGHOEMOEP y;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public EGFLOANIIIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xC619E0", Offset = "0xC609E0", VA = "0x180C619E0")]
		internal bool ILKLBLCOJOJ(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xC631B0", Offset = "0xC621B0", VA = "0x180C631B0")]
		internal bool NKLKDLEBBLF(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xC619E0", Offset = "0xC609E0", VA = "0x180C619E0")]
		internal bool GFKDLDCAAFO(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xC631B0", Offset = "0xC621B0", VA = "0x180C631B0")]
		internal bool BEFACEBBJAH(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<KeepsakeCategoryThemePair> NPNNIMJNKCI;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x919D70", Offset = "0x918D70", VA = "0x180919D70")]
	public JHPGHPGPJMC(List<KeepsakeCategoryThemePair> NCKHKHKGIFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x579CB90", Offset = "0x579BB90", VA = "0x18579CB90", Slot = "4")]
	public int Compare(KMEGHOEMOEP FKPADFHIFHA, KMEGHOEMOEP NAFGCLHKJEH)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum FAFIENHLEAK
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
		public KMEGHOEMOEP KeepsakeCategory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public KeepsakeTheme KeepsakeTheme;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[LADFGCPPLHJ]
public class CDILJGDFINA : CPLICJDPDAC, IDisposable
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct CDODEKFFJIG
	{
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public const string KPCCNPKGDHJ = "Keepsake placement still in progress. Please wait a moment before placing another keepsake.";

		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public const string FINJPKNAKGM = "The keepsake feature is disabled.";

		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public const string MMPMLIIOKLJ = "This account is not authorized to place keepsakes.";

		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public const string NPLODLDGIOA = "Must be at least a room co-owner to modify keepsakes.";

		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public const string KGIHMLOPFFJ = "Invalid keepsake.";

		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public const string NNAJHAMOLLJ = "Keepsake is already collected.";

		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public const string OGOKEPGGDFN = "You have to collect other keepsakes before you can collect this one.";

		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public const string FGEOCOPHBNB = "The keepsake is not in your current room.";

		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public const string NNCNCNFMDJK = "Cannot add or remove keepsakes while limited time event is active.";

		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public const string CJPEFLMPAML = "Cannot collect keepsake after limited time event has ended.";

		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public const string MKDOHLDPBEA = "This room does not have keepsake permissions.";

		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public const string KGOBAEHGDHM = "This room has not unlocked yet.";

		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public const string LCDLGNLHCKM = "This room is locked until its unlock item is purchased.";
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class IHNBJPDDKIM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public CDILJGDFINA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public KMEGHOEMOEP keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public IHNBJPDDKIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x579C340", Offset = "0x579B340", VA = "0x18579C340")]
		internal IBHBGBJGJHP<Guid> GLAGHJLHDKH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x579C510", Offset = "0x579B510", VA = "0x18579C510")]
		internal void PAJBEAGDMMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x579C4B0", Offset = "0x579B4B0", VA = "0x18579C4B0")]
		internal void KAFAPCLFNMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x579BEE0", Offset = "0x579AEE0", VA = "0x18579BEE0")]
		internal void CIDINCGACKL(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x579C480", Offset = "0x579B480", VA = "0x18579C480")]
		internal void IJBGEINHMLL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class LCBNLIONEPF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public CDILJGDFINA <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public LCBNLIONEPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x579D6F0", Offset = "0x579C6F0", VA = "0x18579D6F0")]
		internal void LBAFOGJDJEA(BPFJAOFFEPK response)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x579D690", Offset = "0x579C690", VA = "0x18579D690")]
		internal void IELKOLIMCLM(string error)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class AGOBBMOBFAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public KeepsakeTheme theme;

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public AGOBBMOBFAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x578CC80", Offset = "0x578BC80", VA = "0x18578CC80")]
		internal bool BBJFMOOBAMI(KeepsakeCategoryThemePair categoryThemePair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class ECLOHIOLIKN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public CDILJGDFINA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public KMEGHOEMOEP keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public ECLOHIOLIKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x579B720", Offset = "0x579A720", VA = "0x18579B720")]
		internal bool KACAJANOEPP(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class JMNDJKFKABM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public CDILJGDFINA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public long progressionEventId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public KMEGHOEMOEP? keepsakeCategory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public JMNDJKFKABM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x579D180", Offset = "0x579C180", VA = "0x18579D180")]
		internal void JJJMGAFLBIF(KeepsakeProgressionEventInstancesDTO result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x579CE40", Offset = "0x579BE40", VA = "0x18579CE40")]
		internal void FKDGOFJCHHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x579CE70", Offset = "0x579BE70", VA = "0x18579CE70")]
		internal IBHBGBJGJHP<IEnumerable<Guid>> GOEILDELLCM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x579D200", Offset = "0x579C200", VA = "0x18579D200")]
		internal bool JLIFIEAMPPN(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class GMINKJEFOEN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public KeepsakeRoomInstanceIdsDTO instancesInRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public JMNDJKFKABM CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public GMINKJEFOEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x579B9A0", Offset = "0x579A9A0", VA = "0x18579B9A0")]
		internal IBHBGBJGJHP<IEnumerable<Guid>> BPFPNAFNMHC(KeepsakeRoomInstancesDTO roomInstancesDTO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class DBMDLJLHHNP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public KeepsakeRoomInstancesDTO roomInstancesDTO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public GMINKJEFOEN CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public DBMDLJLHHNP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x579B5F0", Offset = "0x579A5F0", VA = "0x18579B5F0")]
		internal bool MOIKIHAGDPJ(Guid instanceId)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class JOEBLHHNEBN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public Guid instanceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public DBMDLJLHHNP CS$<>8__locals3;

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public JOEBLHHNEBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x579D2B0", Offset = "0x579C2B0", VA = "0x18579D2B0")]
		internal bool BDGIKNHDDON(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class IGPDFNDBGAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public CDILJGDFINA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public IGPDFNDBGAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x579BD70", Offset = "0x579AD70", VA = "0x18579BD70")]
		internal IBHBGBJGJHP<IEnumerable<Guid>> MIHHNFNGBMC(IEnumerable<Guid> instanceIds)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x2F4BCB0", Offset = "0x2F4ACB0", VA = "0x182F4BCB0")]
		internal bool MANJHJABKFI(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class NJPMAMBDLOF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public CDILJGDFINA <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public NJPMAMBDLOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x579E010", Offset = "0x579D010", VA = "0x18579E010")]
		internal void NFHODKPHGMP(KeepsakeProgressionEventInstancesDTO result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x579CE40", Offset = "0x579BE40", VA = "0x18579CE40")]
		internal void GIANAHKCBLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x579DD10", Offset = "0x579CD10", VA = "0x18579DD10")]
		internal IBHBGBJGJHP<Dictionary<Guid, KMEGHOEMOEP>> EPAGKNLKGNO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x579D200", Offset = "0x579C200", VA = "0x18579D200")]
		internal bool OKNCKDKIHPO(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class LPNIOMCACGN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public KeepsakeRoomInstanceIdsDTO instancesInRoom;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public LPNIOMCACGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x579DB40", Offset = "0x579CB40", VA = "0x18579DB40")]
		internal IBHBGBJGJHP<Dictionary<Guid, KMEGHOEMOEP>> NCPBNEKFIGH(KeepsakeRoomInstancesDTO roomInstancesDTO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class BAGKEFGKKJF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public KeepsakeRoomInstancesDTO roomInstancesDTO;

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public BAGKEFGKKJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x578CE30", Offset = "0x578BE30", VA = "0x18578CE30")]
		internal bool LFAPDCEOKJF(Guid instanceId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x578CCB0", Offset = "0x578BCB0", VA = "0x18578CCB0")]
		internal KeyValuePair<Guid, KMEGHOEMOEP> JNLFPAGDJJD(Guid instanceId)
		{
			return default(KeyValuePair<Guid, KMEGHOEMOEP>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class LDDCIAFKKKL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public Guid instanceId;

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public LDDCIAFKKKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x579DAA0", Offset = "0x579CAA0", VA = "0x18579DAA0")]
		internal bool IKNAEKDHFIN(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class IIGJHLHEGLP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public Guid instanceId;

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public IIGJHLHEGLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x579C540", Offset = "0x579B540", VA = "0x18579C540")]
		internal bool ACBNPNPGKGJ(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class BBPLCMEMMKK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public CDILJGDFINA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public BBPLCMEMMKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x578CF20", Offset = "0x578BF20", VA = "0x18578CF20")]
		internal IBHBGBJGJHP<Dictionary<Guid, KMEGHOEMOEP>> AMLCBBNACGI(Dictionary<Guid, KMEGHOEMOEP> instanceIdsAndCategories)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x2F4BCB0", Offset = "0x2F4ACB0", VA = "0x182F4BCB0")]
		internal bool MAEPGOJNNKD(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class PHDBDFLDHFL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public KeepsakeRoomInstanceIdsDTO collectedInstanceIds;

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public PHDBDFLDHFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x579E3A0", Offset = "0x579D3A0", VA = "0x18579E3A0")]
		internal bool PGLMJOMGEDK(KeyValuePair<Guid, KMEGHOEMOEP> idCategoryPair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class HJGJFJNPEIK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public Dictionary<Guid, KMEGHOEMOEP> instanceIdsAndCategories;

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public HJGJFJNPEIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x579BB20", Offset = "0x579AB20", VA = "0x18579BB20")]
		internal KeyValuePair<KMEGHOEMOEP, int> IMFCIMJCHID(KMEGHOEMOEP category)
		{
			return default(KeyValuePair<KMEGHOEMOEP, int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class DPGCKMAKFAE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public KMEGHOEMOEP category;

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public DPGCKMAKFAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x1642D40", Offset = "0x1641D40", VA = "0x181642D40")]
		internal bool FFHDGBFJCJO(KMEGHOEMOEP instanceCategory)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class ENIIIIPMLDI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public Dictionary<Guid, KMEGHOEMOEP> instanceIdsAndCategories;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public ENIIIIPMLDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x579B840", Offset = "0x579A840", VA = "0x18579B840")]
		internal KeyValuePair<KMEGHOEMOEP, int> NBEPENKBDLE(KMEGHOEMOEP category)
		{
			return default(KeyValuePair<KMEGHOEMOEP, int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class KCEBECNIBCK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public KMEGHOEMOEP category;

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public KCEBECNIBCK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x1642D40", Offset = "0x1641D40", VA = "0x181642D40")]
		internal bool EDOHDLJKAFF(KMEGHOEMOEP instanceCategory)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class PALJNGALLJJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public CDILJGDFINA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public Func<KeepsakeRoomDTO, bool> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public PALJNGALLJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x579E1F0", Offset = "0x579D1F0", VA = "0x18579E1F0")]
		internal bool GMNDCBMOFOF(DateTime nowUtc, DateTime eventStartTime, int roomOrder, TimeSpan unlockStartOffset, TimeSpan unlockInterval, int unlockBatchSize)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x579E2D0", Offset = "0x579D2D0", VA = "0x18579E2D0")]
		internal bool IBJKHJAHBCO(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x579E1D0", Offset = "0x579D1D0", VA = "0x18579E1D0")]
		internal bool EMGFFJPOFKJ(KeepsakeRoomDTO r)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x579E1D0", Offset = "0x579D1D0", VA = "0x18579E1D0")]
		internal bool OJMBDDPGAOJ(KeepsakeRoomDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class AGECDDHJFHL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public AGECDDHJFHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0xCAB4C0", Offset = "0xCAA4C0", VA = "0x180CAB4C0")]
		internal bool OCPLAHEKEKK(KeepsakeRoomListDTO roomList)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class ONNMOMHOHED
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public Func<KeepsakeRoomDTO, bool> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public ONNMOMHOHED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x579E100", Offset = "0x579D100", VA = "0x18579E100")]
		internal bool KBAPEDAEFJF(KeepsakeRoomListDTO roomList)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0xD34290", Offset = "0xD33290", VA = "0x180D34290")]
		internal bool DCNHGNMKLJD(KeepsakeRoomDTO room)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class OBBFFGBGDJJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public OBBFFGBGDJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x579E090", Offset = "0x579D090", VA = "0x18579E090")]
		internal bool ADIPKIJAIFE(KeepsakeRoomListDTO i)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class KGEJOLJEODD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public KGEJOLJEODD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0xCAB4C0", Offset = "0xCAA4C0", VA = "0x180CAB4C0")]
		internal bool MJOKBMOHCHH(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class JODDEKIOHAE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public Guid keepsakeInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public JODDEKIOHAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x579D220", Offset = "0x579C220", VA = "0x18579D220")]
		internal bool OOAICKIBLDP(KeyValuePair<Guid, KeepsakeInstanceDTO> instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class MGIKMGKPADP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public KMEGHOEMOEP keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public MGIKMGKPADP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0xF204E0", Offset = "0xF1F4E0", VA = "0x180F204E0")]
		internal bool KLNDOFOHJDA(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class BNDDNNPPCDC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public Guid keepsakeInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public BNDDNNPPCDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x578D180", Offset = "0x578C180", VA = "0x18578D180")]
		internal bool AOKKPKILCJL(KeyValuePair<Guid, KeepsakeInstanceDTO> instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class BEKMJOIJGBC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public KMEGHOEMOEP keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public BEKMJOIJGBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x578D140", Offset = "0x578C140", VA = "0x18578D140")]
		internal bool IEJODCLEFJD(KeyValuePair<Guid, KMEGHOEMOEP> x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class JEPLNIAPGCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public KMEGHOEMOEP newKeepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public JEPLNIAPGCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0xF204E0", Offset = "0xF1F4E0", VA = "0x180F204E0")]
		internal bool KJOBEKHBAKG(KeepsakeInstanceDTO instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class KAHBBHJHEEE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public long currentRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public long? currentSubRoomId;

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public KAHBBHJHEEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x579D3B0", Offset = "0x579C3B0", VA = "0x18579D3B0")]
		internal bool FEBLFFGEMFN(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class ICOEIDEHCHM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public IEnumerable<KeepsakeRoomListDTO> roomList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public ICOEIDEHCHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x579BC80", Offset = "0x579AC80", VA = "0x18579BC80")]
		internal bool KDPOLFEIABD(KeepsakeRoomDTO room)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class IJAACOOLJHG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public KeepsakeRoomDTO room;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public ICOEIDEHCHM CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public IJAACOOLJHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x579C5E0", Offset = "0x579B5E0", VA = "0x18579C5E0")]
		internal bool LIKEBKLOJBC(KeepsakeRoomListDTO roomListDto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class IKGHEJKHOFM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public OFIMLBDMAME args;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public CDILJGDFINA <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public IKGHEJKHOFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x579C660", Offset = "0x579B660", VA = "0x18579C660", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class PPOHJIPIFLH : IAsyncStateMachine
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
		public CDILJGDFINA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public PPOHJIPIFLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x579E420", Offset = "0x579D420", VA = "0x18579E420", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private const int FHBGGLPPFCA = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly DateTime MIEKCIDJOIA;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private const int MMOIDMPKJKO = 3;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private const long OOKCBADAPHO = -1L;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private const char CNCGGKAOGBL = '|';

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly EPECKBNCCHJ CADKGLLGAMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly NMHBKNDBGIA HJIAMHDEFKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly OEBJBBIDBFJ ADMBFFJFLFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly NIMPGJJOFHP GGAJCIOMCEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly HIPOKMDFNOD FGIILGHEHMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly MPAKFMKEDMP OIKCIPCNCKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly NDLENNICCHK KMPGOOMEOMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly JAEAMIMPOOP JOJGGPKEEEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly CBOFLMGCHLM GBJKJDEAJHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly MCKMMKOMAGH LCOBJMOHNJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly FJNNNLMPKOD KHNBLELGLJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly NEEJFIELJHJ OCMEEKPCHCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly GIJELLJFDIN BBIKKGHNHKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly MIOONCMKGBF BDGHHMPLACA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly HDBPBCNEHOA LHHMOHHCHPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly PECGFOJMAPA<KeepsakesConfig.KeepsakesOptions> BBFEMHKPCFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly IMBCFAJLPLN GGPALPEDDJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly Dictionary<Guid, KeepsakeInstanceDTO> FBHHALPFOKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly HashSet<Guid> LBKHODNOHKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly HashSet<long> JFEBBEEBEEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private Dictionary<KMEGHOEMOEP, int> HGEPDOODGHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private readonly HashSet<Guid> OLMBMODFFBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private readonly IDisposable EPMIKIECGCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private Task EFCOJPFCKOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private IBHBGBJGJHP<Guid> FPNNLACBHCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private long? AJPIBLMCMBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private KeepsakeProgressionEventInstancesDTO PCOMNNENHML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private IBHBGBJGJHP<KeepsakeProgressionEventInstancesDTO> NFDAOOLNCJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private IReadOnlyDictionary<KMEGHOEMOEP, KeepsakeCategoryConfigDTO> DCAENGPFBMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private KeepsakeGlobalConfigDTO KHGHBGLLLMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private HashSet<long> HLMMBBLNEMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private HashSet<long> LOJBOPBAPNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private List<KeepsakeRoomListDTO> HAPFENHAKOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private List<KeepsakeRoomListDTO> EOMBNFGAEJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private List<KeepsakeRoomListDTO> AFONNFOJPBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private Dictionary<long, string> JBCNEBCJBLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private Dictionary<long, string> JGPHMBEHCNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private Dictionary<long, DateTime> ILMKLLDJPGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private Dictionary<long, List<KeepsakeRoomDTO>> DLHKLCJHOGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private Dictionary<long, List<KeepsakeRoomDTO>> LCALLDFCAEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private Dictionary<long, long> IJIJHJBFMFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly List<string> JPBEKCPGLLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private DateTime MMPHICNMOOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly IDisposable FKJGKHKOHEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private Dictionary<Guid, KMEGHOEMOEP> EGPIPNCNCGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private Dictionary<KMEGHOEMOEP, int> CIPLEDLKNKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private List<KeepsakeCategoryThemePair> NCKHKHKGIFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private JHPGHPGPJMC JMKNCAMOCLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private bool APGENPOJJOA;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool CENAOLGPHHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x90AA90", Offset = "0x909A90", VA = "0x18090AA90", Slot = "53")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x90AAA0", Offset = "0x909AA0", VA = "0x18090AAA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool IHIADCMNCMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x57907B0", Offset = "0x578F7B0", VA = "0x1857907B0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool MIMIDIHEENA
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x57901C0", Offset = "0x578F1C0", VA = "0x1857901C0", Slot = "36")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private long EIFOCCDIAIH
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5798C40", Offset = "0x5797C40", VA = "0x185798C40")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private long? DAGBIAGFDNO
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x579A230", Offset = "0x5799230", VA = "0x18579A230")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private bool LIELKMOFBBB
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x578FBB0", Offset = "0x578EBB0", VA = "0x18578FBB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public IReadOnlyList<KeepsakeRoomListDTO> AGIMIJPNKBO
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x11AD710", Offset = "0x11AC710", VA = "0x1811AD710", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IReadOnlyList<KeepsakeRoomListDTO> ILPBMIDGPIM
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xC87900", Offset = "0xC86900", VA = "0x180C87900", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public IReadOnlyList<KeepsakeRoomListDTO> BIEKGDPJIDF
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xA64BF0", Offset = "0xA63BF0", VA = "0x180A64BF0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public IReadOnlyDictionary<long, string> AFJNAKEJMKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x10B4DD0", Offset = "0x10B3DD0", VA = "0x1810B4DD0", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public IReadOnlyDictionary<long, string> CKLNGJFAOHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xF986D0", Offset = "0xF976D0", VA = "0x180F986D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	internal bool DIFFGEBGCBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x11AD720", Offset = "0x11AC720", VA = "0x1811AD720")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x5795F40", Offset = "0x5794F40", VA = "0x185795F40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Guid?> PJNNLGCIODC
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x57957D0", Offset = "0x57947D0", VA = "0x1857957D0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x5791CA0", Offset = "0x5790CA0", VA = "0x185791CA0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action BGFPHKLGEJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5798820", Offset = "0x5797820", VA = "0x185798820", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x5799ED0", Offset = "0x5798ED0", VA = "0x185799ED0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action ECOBKKFKODG
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5792A70", Offset = "0x5791A70", VA = "0x185792A70", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x5795EA0", Offset = "0x5794EA0", VA = "0x185795EA0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x579A2D0", Offset = "0x57992D0", VA = "0x18579A2D0")]
	[Preserve]
	internal CDILJGDFINA([NotNull][JFLEHDEIONF(null)] EPECKBNCCHJ CADKGLLGAMH, [NotNull][JFLEHDEIONF(null)] PIIBMPJNMEE KPIKGBJHPHP, [NotNull][JFLEHDEIONF(null)] NMHBKNDBGIA HJIAMHDEFKL, [NotNull][JFLEHDEIONF(null)] OEBJBBIDBFJ ADMBFFJFLFB, [NotNull][JFLEHDEIONF(null)] NIMPGJJOFHP GGAJCIOMCEB, [NotNull][JFLEHDEIONF(null)] HIPOKMDFNOD FGIILGHEHMH, [NotNull][JFLEHDEIONF(null)] MPAKFMKEDMP OIKCIPCNCKH, [NotNull][JFLEHDEIONF(null)] NDLENNICCHK KMPGOOMEOMI, [NotNull][JFLEHDEIONF(null)] JAEAMIMPOOP JOJGGPKEEEH, [NotNull][JFLEHDEIONF(null)] FAPDJEIOFHL HHJJAGLOAJO, [NotNull][JFLEHDEIONF(null)] CBOFLMGCHLM GBJKJDEAJHC, [NotNull][JFLEHDEIONF(null)] MCKMMKOMAGH LCOBJMOHNJG, [NotNull][JFLEHDEIONF(null)] FJNNNLMPKOD KHNBLELGLJM, [NotNull][JFLEHDEIONF(null)] NEEJFIELJHJ OCMEEKPCHCL, [NotNull][JFLEHDEIONF(null)] GIJELLJFDIN BBIKKGHNHKI, [NotNull][JFLEHDEIONF(null)] MIOONCMKGBF BDGHHMPLACA, [NotNull][JFLEHDEIONF(null)] HDBPBCNEHOA LHHMOHHCHPC, [NotNull][JFLEHDEIONF(null)] PECGFOJMAPA<KeepsakesConfig.KeepsakesOptions> BBFEMHKPCFJ, [NotNull][JFLEHDEIONF(null)] IMBCFAJLPLN GGPALPEDDJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x578D770", Offset = "0x578C770", VA = "0x18578D770", Slot = "15")]
	public bool ACBMCCNLLMD(List<string> EKNEPGGNFJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5798D10", Offset = "0x5797D10", VA = "0x185798D10", Slot = "16")]
	public IBHBGBJGJHP<Guid> PAPEJPHDAKC(KMEGHOEMOEP EIIJKHEKNOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5797CF0", Offset = "0x5796CF0", VA = "0x185797CF0", Slot = "17")]
	public GAEMIFNLIHB NKNGKCMKLEN(Guid LMKJBONLEIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x578DFB0", Offset = "0x578CFB0", VA = "0x18578DFB0", Slot = "18")]
	public GAEMIFNLIHB BDOILHALEJJ(Guid LMKJBONLEIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5792640", Offset = "0x5791640", VA = "0x185792640", Slot = "19")]
	public bool EPINDOOFGFG(Guid LMKJBONLEIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5794BF0", Offset = "0x5793BF0", VA = "0x185794BF0", Slot = "20")]
	public bool HKJCHELCKFN(Guid LMKJBONLEIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x57974D0", Offset = "0x57964D0", VA = "0x1857974D0")]
	public KeepsakeTheme MJHEBBNDMLI(Guid LMKJBONLEIO)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5790290", Offset = "0x578F290", VA = "0x185790290")]
	public bool DHGIOKJCMGP(KMEGHOEMOEP EIIJKHEKNOL, out KeepsakeTheme JEKFDJMFKJG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5790C00", Offset = "0x578FC00", VA = "0x185790C00")]
	public List<KeepsakeTheme> DOHHPFIBNON()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x5795930", Offset = "0x5794930", VA = "0x185795930")]
	public int JMBHPCLDNMI(KMEGHOEMOEP EIIJKHEKNOL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5793200", Offset = "0x5792200", VA = "0x185793200")]
	public KMEGHOEMOEP GDHLADOAMMJ(Guid LMKJBONLEIO)
	{
		return default(KMEGHOEMOEP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5792B10", Offset = "0x5791B10", VA = "0x185792B10", Slot = "34")]
	public List<KMEGHOEMOEP> FHIOJFGNKMH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5798780", Offset = "0x5797780", VA = "0x185798780", Slot = "35")]
	public IComparer<KMEGHOEMOEP> OKMGNIHBGLO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x578E390", Offset = "0x578D390", VA = "0x18578E390", Slot = "32")]
	public string BILGGBPPJFH(KMEGHOEMOEP EIIJKHEKNOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5794910", Offset = "0x5793910", VA = "0x185794910", Slot = "33")]
	public string HAJIMKOFEHB(KMEGHOEMOEP EIIJKHEKNOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x57984E0", Offset = "0x57974E0", VA = "0x1857984E0", Slot = "21")]
	public bool OGJGPDHAGLG(Guid LMKJBONLEIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x57966D0", Offset = "0x57956D0", VA = "0x1857966D0", Slot = "22")]
	public void LGAPHKGINEB(Guid LMKJBONLEIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5797F70", Offset = "0x5796F70", VA = "0x185797F70", Slot = "23")]
	public void NMLLMIONCKP(KMEGHOEMOEP EIIJKHEKNOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x57988C0", Offset = "0x57978C0", VA = "0x1857988C0", Slot = "24")]
	public void OMIBLLJOPFO(Guid LMKJBONLEIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5793810", Offset = "0x5792810", VA = "0x185793810", Slot = "25")]
	public int GJIOBDBHCKP()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5793C70", Offset = "0x5792C70", VA = "0x185793C70", Slot = "54")]
	public int GJIOBDBHCKP(KMEGHOEMOEP EIIJKHEKNOL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5793FE0", Offset = "0x5792FE0", VA = "0x185793FE0", Slot = "31")]
	public IBHBGBJGJHP<IEnumerable<Guid>> GNDABALJGDM(long IHGIEILPMCA, long OMDBFLIACPJ, KMEGHOEMOEP? EIIJKHEKNOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5796880", Offset = "0x5795880", VA = "0x185796880", Slot = "30")]
	public IBHBGBJGJHP<IEnumerable<Guid>> LLCIGNAJDAF(long IHGIEILPMCA, long OMDBFLIACPJ, KMEGHOEMOEP? EIIJKHEKNOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5790F50", Offset = "0x578FF50", VA = "0x185790F50", Slot = "55")]
	public IBHBGBJGJHP<Dictionary<Guid, KMEGHOEMOEP>> DOJKILEJGND(long IHGIEILPMCA, long OMDBFLIACPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5796540", Offset = "0x5795540", VA = "0x185796540", Slot = "56")]
	public IBHBGBJGJHP<Dictionary<Guid, KMEGHOEMOEP>> KMBMKBEKCOJ(long IHGIEILPMCA, long OMDBFLIACPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x57919E0", Offset = "0x57909E0", VA = "0x1857919E0", Slot = "26")]
	public IBHBGBJGJHP<int> EBDPNPGCOBD(long IHGIEILPMCA, long OMDBFLIACPJ, KMEGHOEMOEP? EIIJKHEKNOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5792F40", Offset = "0x5791F40", VA = "0x185792F40", Slot = "27")]
	public IBHBGBJGJHP<int> FIKBECLJMNB(long IHGIEILPMCA, long OMDBFLIACPJ, KMEGHOEMOEP? EIIJKHEKNOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x578FCB0", Offset = "0x578ECB0", VA = "0x18578FCB0", Slot = "28")]
	public IBHBGBJGJHP<Dictionary<KMEGHOEMOEP, int>> CFNMBMFJLHK(long IHGIEILPMCA, long OMDBFLIACPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5791F50", Offset = "0x5790F50", VA = "0x185791F50", Slot = "29")]
	public IBHBGBJGJHP<Dictionary<KMEGHOEMOEP, int>> EGHFCECGDNK(long IHGIEILPMCA, long OMDBFLIACPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x57958D0", Offset = "0x57948D0", VA = "0x1857958D0", Slot = "37")]
	public bool JIGIPHACGAN(long IHGIEILPMCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x5796FE0", Offset = "0x5795FE0", VA = "0x185796FE0", Slot = "57")]
	public bool LONNPGPOHCL(long IHGIEILPMCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x5797670", Offset = "0x5796670", VA = "0x185797670", Slot = "38")]
	public bool NAJFCGONEMK(long IHGIEILPMCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x5797760", Offset = "0x5796760", VA = "0x185797760", Slot = "58")]
	public bool NENCGAONGJL(long IHGIEILPMCA, out HLBEAIMBHDH EGOBLNIFHFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x5798310", Offset = "0x5797310", VA = "0x185798310", Slot = "39")]
	public bool OCDCIPBEKKP(long OFIAHIMEHLM, out DateTime BEGBNGFKMNK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x57997A0", Offset = "0x57987A0", VA = "0x1857997A0", Slot = "40")]
	public long PGJHPJIPPEA(long OFIAHIMEHLM)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x5791330", Offset = "0x5790330", VA = "0x185791330", Slot = "59")]
	public IEnumerable<int> DPCPBOGLCCG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x57950F0", Offset = "0x57940F0", VA = "0x1857950F0", Slot = "41")]
	public long IKHAKHKDFJD(long IHGIEILPMCA)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x5795390", Offset = "0x5794390", VA = "0x185795390", Slot = "42")]
	public int JAEPEHBAGBO(long OFIAHIMEHLM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x5792100", Offset = "0x5791100", VA = "0x185792100", Slot = "43")]
	public bool EMIEDELBPIJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x5799F70", Offset = "0x5798F70", VA = "0x185799F70", Slot = "44")]
	public bool PNPFPMNHJNB(long OFIAHIMEHLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x5792890", Offset = "0x5791890", VA = "0x185792890", Slot = "45")]
	public IEnumerable<long> FEEANNHDHED(long OFIAHIMEHLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x5795FB0", Offset = "0x5794FB0", VA = "0x185795FB0", Slot = "46")]
	public int KHLCGINPEDI(long OFIAHIMEHLM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x5790460", Offset = "0x578F460", VA = "0x185790460", Slot = "50")]
	public long DIDGFBICBFB(long GPDBHFNPFML)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x5794560", Offset = "0x5793560", VA = "0x185794560", Slot = "51")]
	public KMEGHOEMOEP GOMAAINKDPH()
	{
		return default(KMEGHOEMOEP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x5796740", Offset = "0x5795740", VA = "0x185796740")]
	private bool LILGDMLKKIB(Guid LMKJBONLEIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x5796060", Offset = "0x5795060", VA = "0x185796060")]
	private void KLCIDGDEGGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x5799BD0", Offset = "0x5798BD0", VA = "0x185799BD0")]
	private KMEGHOEMOEP PHHBBHPDDJD()
	{
		return default(KMEGHOEMOEP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x578E6B0", Offset = "0x578D6B0", VA = "0x18578E6B0")]
	private void BLIGLECCANL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x578E500", Offset = "0x578D500", VA = "0x18578E500")]
	private int BKPFMEMCKPJ(KeepsakeRoomListDTO AEFCCACEAJA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5795CE0", Offset = "0x5794CE0", VA = "0x185795CE0")]
	private int KDIICJKEEMN(DateTime PPNGGLJEOPI, DateTime BOPEBJJGNCO, TimeSpan KCJDJDJCIGD, int NJKLHLNDBJM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5791D40", Offset = "0x5790D40", VA = "0x185791D40")]
	private void EDHNHDMPAKB(IEnumerable<KeepsakeInstanceDTO> FBHHALPFOKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5795590", Offset = "0x5794590", VA = "0x185795590")]
	private void JEAFKCLEFFB(IEnumerable<KeepsakeCollectionRecordDTO> PBMMFOBGFDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5794EF0", Offset = "0x5793EF0", VA = "0x185794EF0")]
	private void IHCIGGHABNA(IEnumerable<long> IIMGBPFCPMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x1016D10", Offset = "0x1015D10", VA = "0x181016D10")]
	private void CPJDAPKLJHP(KeepsakeGlobalConfigDTO KHGHBGLLLMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5797220", Offset = "0x5796220", VA = "0x185797220")]
	private bool MILDBDFDKOL(KMEGHOEMOEP EIIJKHEKNOL, out Guid OOEKHNBGDML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5793130", Offset = "0x5792130", VA = "0x185793130")]
	private bool GCJNGGAIJDC(out Guid OOEKHNBGDML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5797040", Offset = "0x5796040", VA = "0x185797040")]
	private bool MALMAFNFABE(Guid LMKJBONLEIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5797FB0", Offset = "0x5796FB0", VA = "0x185797FB0")]
	private IEnumerable<Guid> NPKLJDGIJCF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x578FAE0", Offset = "0x578EAE0", VA = "0x18578FAE0")]
	private IEnumerable<KeepsakeInstanceDTO> BOOKJBGADMG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x5795E10", Offset = "0x5794E10", VA = "0x185795E10")]
	private void KGBOPHEIBOK(Guid LMKJBONLEIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5795A90", Offset = "0x5794A90", VA = "0x185795A90")]
	private bool JMKJCKBLEPB(Guid LMKJBONLEIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5794F50", Offset = "0x5793F50", VA = "0x185794F50")]
	private void IHLLLFPPGGH(Guid LMKJBONLEIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x5792020", Offset = "0x5791020", VA = "0x185792020")]
	private void EILCOADOMMI(KMEGHOEMOEP FHJIOGDDBKF, int BKGMDJNEIPD, ref Dictionary<KMEGHOEMOEP, int> JAHNFAANBHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x5792790", Offset = "0x5791790", VA = "0x185792790")]
	private int FAGFJMNHIJL(KMEGHOEMOEP EIIJKHEKNOL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x578FEE0", Offset = "0x578EEE0", VA = "0x18578FEE0")]
	private void CGIGFJHNCMK(KeepsakeInstanceDTO DJFNEHPCNIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5798110", Offset = "0x5797110", VA = "0x185798110")]
	private void OAOEGMGFEPE(KeepsakeInstanceDTO DJFNEHPCNIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x5790880", Offset = "0x578F880", VA = "0x185790880")]
	private void DODMBPOEACC(Guid LMKJBONLEIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x57930B0", Offset = "0x57920B0", VA = "0x1857930B0")]
	private void FJKLNDEKMIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5790790", Offset = "0x578F790", VA = "0x185790790")]
	private void DJNEGIJCKAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x5790800", Offset = "0x578F800", VA = "0x185790800")]
	private void DNIMGPAIJPO(KPECHFMAHBD JBAGHENJMLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x5798460", Offset = "0x5797460", VA = "0x185798460")]
	private void OCLOONOJBIL(MEOIKJBCLEB.PPDOELGECGE EOHGDDIECBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x5795DB0", Offset = "0x5794DB0", VA = "0x185795DB0")]
	private void KFICMAJCCNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x5799340", Offset = "0x5798340", VA = "0x185799340")]
	private void PBCMMDJNIEP(float LHHBCMNKGBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x578D210", Offset = "0x578C210", VA = "0x18578D210")]
	private void ABBCNBFOMLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x578DC00", Offset = "0x578CC00", VA = "0x18578DC00")]
	private bool AEPOPDNDGNJ(Guid LMKJBONLEIO, out string GJNFJDGODPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5797B20", Offset = "0x5796B20", VA = "0x185797B20")]
	private bool NHGFOFMPCMG(Guid LMKJBONLEIO, out KeepsakeCategoryConfigDTO FHJIOGDDBKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x578FBD0", Offset = "0x578EBD0", VA = "0x18578FBD0")]
	private void CDJPIEADOPO(string FNFHAMDAPNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x578EC60", Offset = "0x578DC60", VA = "0x18578EC60")]
	private bool BMCHNOABKFO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x5792C60", Offset = "0x5791C60", VA = "0x185792C60")]
	private IEnumerable<long> FIHFPGLHBJD(IEnumerable<KeepsakeRoomDTO> NCCDPNIBEOH, IEnumerable<KeepsakeRoomListDTO> GFGGIEKOOJH, long OFIAHIMEHLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5796A20", Offset = "0x5795A20", VA = "0x185796A20")]
	private bool LONHPCEAEBP(Guid LMKJBONLEIO, out string AOLOOCNDGPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x5795870", Offset = "0x5794870", VA = "0x185795870", Slot = "47")]
	public string JFGOKEGCKKM(ODJOEPELKMB NNEKLHKNGKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x57921F0", Offset = "0x57911F0", VA = "0x1857921F0", Slot = "49")]
	public string EOCPMFEKFGM(ODJOEPELKMB NNEKLHKNGKH, long IHGIEILPMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x57900A0", Offset = "0x578F0A0", VA = "0x1857900A0", Slot = "48")]
	public string CGJIAJCPMLH(ODJOEPELKMB NNEKLHKNGKH, int EGCOIOBOFKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x578ED80", Offset = "0x578DD80", VA = "0x18578ED80")]
	private void BOBHGCODPIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x578DE70", Offset = "0x578CE70", VA = "0x18578DE70")]
	private void BCPOOEHHBAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x57937F0", Offset = "0x57927F0", VA = "0x1857937F0")]
	private ODJOEPELKMB GIJABAINDED(JNEMIFKFLGO LMINDPMDFAK)
	{
		return default(ODJOEPELKMB);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x5793110", Offset = "0x5792110", VA = "0x185793110")]
	private ODJOEPELKMB GBCINGLKALN(JNEMIFKFLGO LMINDPMDFAK)
	{
		return default(ODJOEPELKMB);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x578DC90", Offset = "0x578CC90", VA = "0x18578DC90")]
	internal static string APIELOJOHII(BPFJAOFFEPK JMOJACHBEPK, string CPBEDAELHGM, bool HOAGPACGEJG, int KECGOANKHCJ, int CFEGBAPJMIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x5791580", Offset = "0x5790580", VA = "0x185791580", Slot = "52")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x5799710", Offset = "0x5798710", VA = "0x185799710")]
	private PEOGNNHCCMJ PDNFJJFFFFK(PIPFLAHHDDO AJKECCIHKAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5795B40", Offset = "0x5794B40", VA = "0x185795B40")]
	private JMCCIKOGHMP JNDIGJCODNI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x5793370", Offset = "0x5792370", VA = "0x185793370")]
	private Task GGEPKFNPCDP(OFIMLBDMAME CIIMHINGMLG, CancellationToken OAGBBBCDIGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x5794A80", Offset = "0x5793A80", VA = "0x185794A80")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(IKGHEJKHOFM))]
	private Task HGFANDPCKJP(OFIMLBDMAME CIIMHINGMLG, CancellationToken OAGBBBCDIGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x5794E50", Offset = "0x5793E50", VA = "0x185794E50")]
	private Task IBOKAHLIMLJ(OFIMLBDMAME CIIMHINGMLG, CancellationToken OAGBBBCDIGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x57943D0", Offset = "0x57933D0", VA = "0x1857943D0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(PPOHJIPIFLH))]
	private Task GNKAMFOGDEK(string HJJLMCEMDKN, TimeSpan GMKNAKKPCCO, CancellationToken OAGBBBCDIGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x41D9CD0", Offset = "0x41D8CD0", VA = "0x1841D9CD0")]
	[CompilerGenerated]
	private void GNIMFFILBKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x5797710", Offset = "0x5796710", VA = "0x185797710")]
	[CompilerGenerated]
	private void NCELKKLEAGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x5793700", Offset = "0x5792700", VA = "0x185793700")]
	[CompilerGenerated]
	private bool GHKIPALKAEF(KeepsakeInstanceDTO FKPADFHIFHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x5795210", Offset = "0x5794210", VA = "0x185795210")]
	[CompilerGenerated]
	private IBHBGBJGJHP<Dictionary<KMEGHOEMOEP, int>> IPMMGECEPBJ(Dictionary<Guid, KMEGHOEMOEP> MBMCENPGNKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x57970A0", Offset = "0x57960A0", VA = "0x1857970A0")]
	[CompilerGenerated]
	private IBHBGBJGJHP<Dictionary<KMEGHOEMOEP, int>> MAOAHJOFIOO(Dictionary<Guid, KMEGHOEMOEP> MBMCENPGNKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x57984C0", Offset = "0x57974C0", VA = "0x1857984C0")]
	[CompilerGenerated]
	private bool ODMGCMBFEJJ(KeepsakeRoomListDTO FKPADFHIFHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x5798B10", Offset = "0x5797B10", VA = "0x185798B10")]
	[CompilerGenerated]
	private bool ONCEGFIPPGD(KeepsakeInstanceDTO FKPADFHIFHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x578DA80", Offset = "0x578CA80", VA = "0x18578DA80")]
	[CompilerGenerated]
	private void AELGNJPDIDA(Tuple<KeepsakeRoomInstancesDTO, IReadOnlyDictionary<KMEGHOEMOEP, KeepsakeCategoryConfigDTO>, KeepsakeGlobalConfigDTO> DIPMGIHIBAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x578E330", Offset = "0x578D330", VA = "0x18578E330")]
	[CompilerGenerated]
	private void BEIAGIMCDCG(string AOLOOCNDGPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x5794C20", Offset = "0x5793C20", VA = "0x185794C20")]
	[CompilerGenerated]
	private Task HPONLEMOPKP(CancellationToken HLCCHPDJAAO)
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
public class MHGFMJKAFPI
{
	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
	public MHGFMJKAFPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0xBB9C20", Offset = "0xBB8C20", VA = "0x180BB9C20")]
	public static string KILOLNAHAFI(byte[] BKIADALNNFJ, byte[] EEICCMPLMOJ)
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
