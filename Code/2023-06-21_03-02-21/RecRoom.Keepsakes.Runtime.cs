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
	public class KeepsakesConfig : ScriptableObject, KNFIGHNPJKL<KeepsakesConfig.KeepsakesOptions>
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		public class KeepsakesOptions
		{
			[Cpp2IlInjected.Token(Token = "0x2000004")]
			[CompilerGenerated]
			private sealed class IDKIPJDPCDE
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000003")]
				public string themeId;

				[Cpp2IlInjected.Token(Token = "0x6000006")]
				[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
				public IDKIPJDPCDE()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000007")]
				[Cpp2IlInjected.Address(RVA = "0x10D0270", Offset = "0x10CF470", VA = "0x1810D0270")]
				internal bool IJCAIDMFADJ(KeepsakeTheme x)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000008")]
				[Cpp2IlInjected.Address(RVA = "0x10D0270", Offset = "0x10CF470", VA = "0x1810D0270")]
				internal bool FBFOBLDMCGP(KeepsakeTheme x)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000002")]
			[SerializeField]
			private KeepsakeTheme[] themes;

			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x8D7A20", Offset = "0x8D6C20", VA = "0x1808D7A20")]
			public KeepsakesOptions([Optional] KeepsakeTheme[] ICNHLEPCKCF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x10D1080", Offset = "0x10D0280", VA = "0x1810D1080")]
			public bool CELOEJKGMPG(string HFBNDONAJIM, out KeepsakeTheme PMCLNJCNLFD)
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
			[Cpp2IlInjected.Address(RVA = "0x844820", Offset = "0x843A20", VA = "0x180844820", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x10D1000", Offset = "0x10D0200", VA = "0x1810D1000")]
		[MPKPGFJAEKF(OJBJGAAILBP.GameOnly)]
		private static void BDIDELBNDKE(JLCNCEFHLIA HPKKDLHOJJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xC7A8A0", Offset = "0xC79AA0", VA = "0x180C7A8A0")]
		public KeepsakesConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class KAOGNOCBOII : IComparer<PIHCLHIKEPH>
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class MCAPDGBMJHC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public PIHCLHIKEPH x;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public PIHCLHIKEPH y;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public MCAPDGBMJHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x10DF770", Offset = "0x10DE970", VA = "0x1810DF770")]
		internal bool FGPGHECHAOD(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x10DF760", Offset = "0x10DE960", VA = "0x1810DF760")]
		internal bool MDKKLJEMIJN(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x10DF770", Offset = "0x10DE970", VA = "0x1810DF770")]
		internal bool EGLEPBIPLCB(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x10DF760", Offset = "0x10DE960", VA = "0x1810DF760")]
		internal bool EADCFBNLOFP(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<KeepsakeCategoryThemePair> IJBJKNGMKNP;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x8D7A20", Offset = "0x8D6C20", VA = "0x1808D7A20")]
	public KAOGNOCBOII(List<KeepsakeCategoryThemePair> JBNDKEJOKFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x10D0BE0", Offset = "0x10CFDE0", VA = "0x1810D0BE0", Slot = "4")]
	public int Compare(PIHCLHIKEPH JNIPLDLJAIJ, PIHCLHIKEPH GEADFOLNEOP)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum FDGONKOOHGB
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
		public PIHCLHIKEPH KeepsakeCategory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public KeepsakeTheme KeepsakeTheme;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[HMFLENOJLJJ]
public class LCPIALCFICP : HCHPEGJPAGO, IDisposable
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct IGOCJMIKDFM
	{
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public const string FALMAGCAJIP = "Keepsake placement still in progress. Please wait a moment before placing another keepsake.";

		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public const string CFNMONOEDLH = "The keepsake feature is disabled.";

		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public const string FFEBJDPDBFP = "This account is not authorized to place keepsakes.";

		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public const string DDIJEGEEFIN = "Must be at least a room co-owner to modify keepsakes.";

		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public const string HCIMCFPDNEG = "Invalid keepsake.";

		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public const string MBLAELNJDJF = "Keepsake is already collected.";

		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public const string GLAJFPIEHCJ = "You have to collect other keepsakes before you can collect this one.";

		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public const string PNHCKCIPEJF = "The keepsake is not in your current room.";

		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public const string OFMDNEAILGA = "Cannot add or remove keepsakes while limited time event is active.";

		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public const string LFCMBIJCOPG = "Cannot collect keepsake after limited time event has ended.";

		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public const string HFFBJPACOIG = "This room does not have keepsake permissions.";

		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public const string NCLHBLNOKFK = "This room has not unlocked yet.";

		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public const string JBDEMOCLEKO = "This room is locked until its unlock item is purchased.";
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class CKEDBBHNCAD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public LCPIALCFICP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public PIHCLHIKEPH keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public CKEDBBHNCAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x10CF1A0", Offset = "0x10CE3A0", VA = "0x1810CF1A0")]
		internal NHJDNADPIAN<Guid> IKKEAFNOEEK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x10CF2E0", Offset = "0x10CE4E0", VA = "0x1810CF2E0")]
		internal void ILPKPCAGPEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x10CF310", Offset = "0x10CE510", VA = "0x1810CF310")]
		internal void MFCEJGIMCDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x10CED40", Offset = "0x10CDF40", VA = "0x1810CED40")]
		internal void CHHNDKIGLBL(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x10CF370", Offset = "0x10CE570", VA = "0x1810CF370")]
		internal void ONFNGACMOPN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class IPHKNNBADEM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public LCPIALCFICP <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public IPHKNNBADEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x10D0460", Offset = "0x10CF660", VA = "0x1810D0460")]
		internal void DIODMDGLGCD(AEBAIJBAJAP response)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x10D0810", Offset = "0x10CFA10", VA = "0x1810D0810")]
		internal void OMBPPJICDBJ(string error)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class HECOMLJNDME
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public KeepsakeTheme theme;

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public HECOMLJNDME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x10D01D0", Offset = "0x10CF3D0", VA = "0x1810D01D0")]
		internal bool JEEPOBFBEBH(KeepsakeCategoryThemePair categoryThemePair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class IFNMKHLAJLG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public LCPIALCFICP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public PIHCLHIKEPH keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public IFNMKHLAJLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x10D02A0", Offset = "0x10CF4A0", VA = "0x1810D02A0")]
		internal bool DOHPKFPHIDN(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class BFALCOKCCNK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public LCPIALCFICP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public long progressionEventId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public PIHCLHIKEPH? keepsakeCategory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public BFALCOKCCNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x10CE960", Offset = "0x10CDB60", VA = "0x1810CE960")]
		internal void CLGAIMNNCMJ(KeepsakeProgressionEventInstancesDTO result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x10CECF0", Offset = "0x10CDEF0", VA = "0x1810CECF0")]
		internal void IALNBIEKLJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x10CE9E0", Offset = "0x10CDBE0", VA = "0x1810CE9E0")]
		internal NHJDNADPIAN<IEnumerable<Guid>> EDMCLMKOICO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x10CED20", Offset = "0x10CDF20", VA = "0x1810CED20")]
		internal bool MMOCANEBJPJ(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class NKOHCHGPNNC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public KeepsakeRoomInstanceIdsDTO instancesInRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public BFALCOKCCNK CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public NKOHCHGPNNC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x10DFA70", Offset = "0x10DEC70", VA = "0x1810DFA70")]
		internal NHJDNADPIAN<IEnumerable<Guid>> DEJPMBPINAL(KeepsakeRoomInstancesDTO roomInstancesDTO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class JDKCIMLBIBC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public KeepsakeRoomInstancesDTO roomInstancesDTO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public NKOHCHGPNNC CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public JDKCIMLBIBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x10D0870", Offset = "0x10CFA70", VA = "0x1810D0870")]
		internal bool AJFANMEJOLL(Guid instanceId)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class NLMNNFKMCPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public Guid instanceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public JDKCIMLBIBC CS$<>8__locals3;

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public NLMNNFKMCPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x10DFBC0", Offset = "0x10DEDC0", VA = "0x1810DFBC0")]
		internal bool IKGPNOJMGOM(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class PGCEKIJBIAF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public LCPIALCFICP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public PGCEKIJBIAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x10DFD50", Offset = "0x10DEF50", VA = "0x1810DFD50")]
		internal NHJDNADPIAN<IEnumerable<Guid>> INKFOJLPKJI(IEnumerable<Guid> instanceIds)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x10D0BC0", Offset = "0x10CFDC0", VA = "0x1810D0BC0")]
		internal bool AMKACPPLBBG(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class GCPKILADGIL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public LCPIALCFICP <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public GCPKILADGIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x10D0150", Offset = "0x10CF350", VA = "0x1810D0150")]
		internal void JBMJMBPGALB(KeepsakeProgressionEventInstancesDTO result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x10CECF0", Offset = "0x10CDEF0", VA = "0x1810CECF0")]
		internal void JNJHCEJALJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x10CFE50", Offset = "0x10CF050", VA = "0x1810CFE50")]
		internal NHJDNADPIAN<Dictionary<Guid, PIHCLHIKEPH>> HMCJJJMFBCO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x10CED20", Offset = "0x10CDF20", VA = "0x1810CED20")]
		internal bool LNCNOJLDCOI(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class ANJHOOKKIJH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public KeepsakeRoomInstanceIdsDTO instancesInRoom;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public ANJHOOKKIJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x10CE630", Offset = "0x10CD830", VA = "0x1810CE630")]
		internal NHJDNADPIAN<Dictionary<Guid, PIHCLHIKEPH>> GLKAJFOKOCG(KeepsakeRoomInstancesDTO roomInstancesDTO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class NGGNBGPIDNE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public KeepsakeRoomInstancesDTO roomInstancesDTO;

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public NGGNBGPIDNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x10DF900", Offset = "0x10DEB00", VA = "0x1810DF900")]
		internal bool MAEHNNJKCKF(Guid instanceId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x10DF780", Offset = "0x10DE980", VA = "0x1810DF780")]
		internal KeyValuePair<Guid, PIHCLHIKEPH> LJPIJPAHJPA(Guid instanceId)
		{
			return default(KeyValuePair<Guid, PIHCLHIKEPH>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class IIOKMMOJMKM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public Guid instanceId;

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public IIOKMMOJMKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x10D03C0", Offset = "0x10CF5C0", VA = "0x1810D03C0")]
		internal bool IDOCNJPJJBN(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class DGPADEOHLAF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public Guid instanceId;

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public DGPADEOHLAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x10CF3C0", Offset = "0x10CE5C0", VA = "0x1810CF3C0")]
		internal bool LKBILDLLIPL(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class JKCAFLAIIIF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public LCPIALCFICP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public JKCAFLAIIIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x10D09A0", Offset = "0x10CFBA0", VA = "0x1810D09A0")]
		internal NHJDNADPIAN<Dictionary<Guid, PIHCLHIKEPH>> BPKBJFEKMLG(Dictionary<Guid, PIHCLHIKEPH> instanceIdsAndCategories)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x10D0BC0", Offset = "0x10CFDC0", VA = "0x1810D0BC0")]
		internal bool PKBHIDLFJML(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class FPMJCLGDMMP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public KeepsakeRoomInstanceIdsDTO collectedInstanceIds;

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public FPMJCLGDMMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x10CF8A0", Offset = "0x10CEAA0", VA = "0x1810CF8A0")]
		internal bool DMGKDPGADEB(KeyValuePair<Guid, PIHCLHIKEPH> idCategoryPair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class KCHKDCLALLH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public Dictionary<Guid, PIHCLHIKEPH> instanceIdsAndCategories;

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public KCHKDCLALLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x10D0E90", Offset = "0x10D0090", VA = "0x1810D0E90")]
		internal KeyValuePair<PIHCLHIKEPH, int> DIJOBAHKPAD(PIHCLHIKEPH category)
		{
			return default(KeyValuePair<PIHCLHIKEPH, int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class KLBINMKGBAC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public PIHCLHIKEPH category;

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public KLBINMKGBAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x10D0FF0", Offset = "0x10D01F0", VA = "0x1810D0FF0")]
		internal bool OCAHKDKPJKK(PIHCLHIKEPH instanceCategory)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class BAPKNKJAHDB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public Dictionary<Guid, PIHCLHIKEPH> instanceIdsAndCategories;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public BAPKNKJAHDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x10CE800", Offset = "0x10CDA00", VA = "0x1810CE800")]
		internal KeyValuePair<PIHCLHIKEPH, int> MPGPCCDLMMF(PIHCLHIKEPH category)
		{
			return default(KeyValuePair<PIHCLHIKEPH, int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class KMDHOMIDLNB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public PIHCLHIKEPH category;

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public KMDHOMIDLNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x10D0FF0", Offset = "0x10D01F0", VA = "0x1810D0FF0")]
		internal bool HAILKLEHPPA(PIHCLHIKEPH instanceCategory)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class EAMIMBEENIM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public LCPIALCFICP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public Func<KeepsakeRoomDTO, bool> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public EAMIMBEENIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x10CF550", Offset = "0x10CE750", VA = "0x1810CF550")]
		internal bool BIMEHIKKCFD(DateTime nowUtc, DateTime eventStartTime, int roomOrder, TimeSpan unlockStartOffset, TimeSpan unlockInterval, int unlockBatchSize)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x10CF650", Offset = "0x10CE850", VA = "0x1810CF650")]
		internal bool NDGLKBLJIGL(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x10CF630", Offset = "0x10CE830", VA = "0x1810CF630")]
		internal bool KDPEOAGODJB(KeepsakeRoomDTO r)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x10CF630", Offset = "0x10CE830", VA = "0x1810CF630")]
		internal bool PIJAEPEEKNH(KeepsakeRoomDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class DAJMFJKOPCF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public DAJMFJKOPCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x10CF3A0", Offset = "0x10CE5A0", VA = "0x1810CF3A0")]
		internal bool KEEDPFNHJGM(KeepsakeRoomListDTO roomList)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class LONDFMAFHBE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public Func<KeepsakeRoomDTO, bool> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public LONDFMAFHBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x10DF690", Offset = "0x10DE890", VA = "0x1810DF690")]
		internal bool OKLBFHMANLB(KeepsakeRoomListDTO roomList)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x10DF670", Offset = "0x10DE870", VA = "0x1810DF670")]
		internal bool IMOHBCKFKDL(KeepsakeRoomDTO room)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class HNEACHOPHED
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public HNEACHOPHED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x10D0200", Offset = "0x10CF400", VA = "0x1810D0200")]
		internal bool NDCEDKKAHIG(KeepsakeRoomListDTO i)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class OPJDJMFHGPD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public OPJDJMFHGPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x10CF3A0", Offset = "0x10CE5A0", VA = "0x1810CF3A0")]
		internal bool IKFLDLKNKCD(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class FEMNBIABNDC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public Guid keepsakeInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public FEMNBIABNDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x10CF810", Offset = "0x10CEA10", VA = "0x1810CF810")]
		internal bool GNOJOCABBEA(KeyValuePair<Guid, KeepsakeInstanceDTO> instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class IFLOANOEFNN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public PIHCLHIKEPH keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public IFLOANOEFNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x10CF760", Offset = "0x10CE960", VA = "0x1810CF760")]
		internal bool LIDPCAJMBJD(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class ONMJELAELCJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public Guid keepsakeInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public ONMJELAELCJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x10DFCC0", Offset = "0x10DEEC0", VA = "0x1810DFCC0")]
		internal bool ANAKMDEFMAC(KeyValuePair<Guid, KeepsakeInstanceDTO> instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class EIJLDPNLIBK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public PIHCLHIKEPH keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public EIJLDPNLIBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x10CF720", Offset = "0x10CE920", VA = "0x1810CF720")]
		internal bool BIDMEDILMDA(KeyValuePair<Guid, PIHCLHIKEPH> x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class EMEOGFDFCCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public PIHCLHIKEPH newKeepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public EMEOGFDFCCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x10CF760", Offset = "0x10CE960", VA = "0x1810CF760")]
		internal bool BKOJNENEBNG(KeepsakeInstanceDTO instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class EPLECIEOKJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public long currentRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public long? currentSubRoomId;

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public EPLECIEOKJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x10CF780", Offset = "0x10CE980", VA = "0x1810CF780")]
		internal bool FCFEDNNNCBF(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class DPBCMHKPBPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public IEnumerable<KeepsakeRoomListDTO> roomList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public DPBCMHKPBPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x10CF460", Offset = "0x10CE660", VA = "0x1810CF460")]
		internal bool FOMDBLDEIAH(KeepsakeRoomDTO room)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class NJDDAJLDAEN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public KeepsakeRoomDTO room;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public DPBCMHKPBPJ CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public NJDDAJLDAEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x10DF9F0", Offset = "0x10DEBF0", VA = "0x1810DF9F0")]
		internal bool IGDBOIKHACE(KeepsakeRoomListDTO roomListDto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class GAIBDALMPKB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public FEKMMALKIBN args;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public LCPIALCFICP <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public GAIBDALMPKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x10CF920", Offset = "0x10CEB20", VA = "0x1810CF920", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class AHPJMNPKJJP : IAsyncStateMachine
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
		public LCPIALCFICP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public AHPJMNPKJJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x10CE440", Offset = "0x10CD640", VA = "0x1810CE440", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private const int PPOOBIPALBP = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly DateTime KNEPIEDCCGL;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private const int DPOFLPIJCPE = 3;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private const long FKFINJNELOG = -1L;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private const char LJLCGODJHNP = '|';

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly MGHPBNHHCFO NHCOJKJFKAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly CDLOMEPDACH AEGBBNKMLPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly MDGELECJJEL AFPEGIOPNFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly ONHBNGNJICJ ALJLFMJMHCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly MOGJDODAHJA COENACEECKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly HLPDNOLNLJC CCPAGHLKDFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly KLELFNKDBNP OCHOGPMKPDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly IPBPMMLOKDP BIHEKONDPKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly NJIMNIFLDIK EGJCJNAHODJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly MCMFBPEINOM LINPJOGCEDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly HEOBDDOGMBL NPDFGPGCFON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly KCIOFBGCBNB HMCMKAPEOGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly FMACKJJDDOO ELNAGFKOBDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly BJKIMEBKJHG DAGCAFJOIIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly OFJLDPEJIPH ENNFFJHCNKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly KNFIGHNPJKL<KeepsakesConfig.KeepsakesOptions> HIMIFCBAJPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly GLMBDHOFKPK IFKOJKGHEEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly Dictionary<Guid, KeepsakeInstanceDTO> AGIMFBDLBNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly HashSet<Guid> POPKLNEJKAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly HashSet<long> IOKHBFJAOAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private Dictionary<PIHCLHIKEPH, int> KHGGHIAIHLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private readonly HashSet<Guid> DPLJHFEOOLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private readonly IDisposable CBIKLLLPEDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private Task HBOBJPLFLLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private NHJDNADPIAN<Guid> DOLNCJPBHEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private long? BKKLHHHCGAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private KeepsakeProgressionEventInstancesDTO LCDCOKNGMFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private NHJDNADPIAN<KeepsakeProgressionEventInstancesDTO> FNDIAMDJDKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private IReadOnlyDictionary<PIHCLHIKEPH, KeepsakeCategoryConfigDTO> EGPIBJDPBGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private KeepsakeGlobalConfigDTO JCCDNPCKOLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private HashSet<long> LPKIOOHGDMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private HashSet<long> AJBJJIIFCAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private List<KeepsakeRoomListDTO> DACHOPMNLGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private List<KeepsakeRoomListDTO> PPDIGGHCFHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private List<KeepsakeRoomListDTO> CMJNKNLHGCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private Dictionary<long, string> IBMPGCALJPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private Dictionary<long, string> OFJHHNLDMOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private Dictionary<long, DateTime> DPOAOBFPJHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private Dictionary<long, List<KeepsakeRoomDTO>> LMCJJAJPACD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private Dictionary<long, List<KeepsakeRoomDTO>> GDGJIPJDCHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private Dictionary<long, long> CILOCICMAHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly List<string> ILMOABPHKHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private DateTime FHHDFDJNAAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly IDisposable OKCDNONKNFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private Dictionary<Guid, PIHCLHIKEPH> BKGJFDNFBLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private Dictionary<PIHCLHIKEPH, int> NGKNJFIDFLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private List<KeepsakeCategoryThemePair> JBNDKEJOKFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private KAOGNOCBOII HDABELMOHDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private bool KIAMACOALIF;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool EDCONPEJKNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8D6B70", Offset = "0x8D5D70", VA = "0x1808D6B70", Slot = "53")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xABB080", Offset = "0xABA280", VA = "0x180ABB080")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool PJCAOOKOPMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x10D66F0", Offset = "0x10D58F0", VA = "0x1810D66F0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool NOOLEFGLLOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x10D1D30", Offset = "0x10D0F30", VA = "0x1810D1D30", Slot = "36")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private long OMMBHGEEFLC
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x10D2650", Offset = "0x10D1850", VA = "0x1810D2650")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private long? IEPNHMKDEEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x10D6470", Offset = "0x10D5670", VA = "0x1810D6470")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private bool LMHFLJHKNEF
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x10DB2C0", Offset = "0x10DA4C0", VA = "0x1810DB2C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public IReadOnlyList<KeepsakeRoomListDTO> APEBIBMGCFC
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xABAC30", Offset = "0xAB9E30", VA = "0x180ABAC30", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IReadOnlyList<KeepsakeRoomListDTO> AEBELICMANA
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xEF9CA0", Offset = "0xEF8EA0", VA = "0x180EF9CA0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public IReadOnlyList<KeepsakeRoomListDTO> OADOLOIKDIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xEF9C70", Offset = "0xEF8E70", VA = "0x180EF9C70", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public IReadOnlyDictionary<long, string> HBKKMGEPPEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xABABA0", Offset = "0xAB9DA0", VA = "0x180ABABA0", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public IReadOnlyDictionary<long, string> PJBHMNDJGLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x10DE2E0", Offset = "0x10DD4E0", VA = "0x1810DE2E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	internal bool LODJCPLCAPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x10D9220", Offset = "0x10D8420", VA = "0x1810D9220")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x10D3DC0", Offset = "0x10D2FC0", VA = "0x1810D3DC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Guid?> CCLJECEMGLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x10DD320", Offset = "0x10DC520", VA = "0x1810DD320", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x10D6740", Offset = "0x10D5940", VA = "0x1810D6740", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action GBJBLIGGKHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x10D9A80", Offset = "0x10D8C80", VA = "0x1810D9A80", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x10DA900", Offset = "0x10D9B00", VA = "0x1810DA900", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action DOBKHNAEPNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x10D69C0", Offset = "0x10D5BC0", VA = "0x1810D69C0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x10DD000", Offset = "0x10DC200", VA = "0x1810DD000", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x10DE350", Offset = "0x10DD550", VA = "0x1810DE350")]
	[Preserve]
	internal LCPIALCFICP([NotNull][IDNKOMINBGM(null)] MGHPBNHHCFO NHCOJKJFKAA, [NotNull][IDNKOMINBGM(null)] MPIHBEJGGKO CELBODONCID, [NotNull][IDNKOMINBGM(null)] CDLOMEPDACH AEGBBNKMLPG, [NotNull][IDNKOMINBGM(null)] MDGELECJJEL AFPEGIOPNFO, [NotNull][IDNKOMINBGM(null)] ONHBNGNJICJ ALJLFMJMHCI, [NotNull][IDNKOMINBGM(null)] MOGJDODAHJA COENACEECKL, [NotNull][IDNKOMINBGM(null)] HLPDNOLNLJC CCPAGHLKDFA, [NotNull][IDNKOMINBGM(null)] KLELFNKDBNP OCHOGPMKPDB, [NotNull][IDNKOMINBGM(null)] IPBPMMLOKDP BIHEKONDPKH, [NotNull][IDNKOMINBGM(null)] HJGJBBBCHGP EJPBHGPNEGJ, [NotNull][IDNKOMINBGM(null)] NJIMNIFLDIK EGJCJNAHODJ, [NotNull][IDNKOMINBGM(null)] MCMFBPEINOM LINPJOGCEDK, [NotNull][IDNKOMINBGM(null)] HEOBDDOGMBL NPDFGPGCFON, [NotNull][IDNKOMINBGM(null)] KCIOFBGCBNB HMCMKAPEOGM, [NotNull][IDNKOMINBGM(null)] FMACKJJDDOO ELNAGFKOBDA, [NotNull][IDNKOMINBGM(null)] BJKIMEBKJHG DAGCAFJOIIG, [NotNull][IDNKOMINBGM(null)] OFJLDPEJIPH ENNFFJHCNKH, [NotNull][IDNKOMINBGM(null)] KNFIGHNPJKL<KeepsakesConfig.KeepsakesOptions> HIMIFCBAJPG, [NotNull][IDNKOMINBGM(null)] GLMBDHOFKPK IFKOJKGHEEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x10D9E20", Offset = "0x10D9020", VA = "0x1810D9E20", Slot = "15")]
	public bool JKGEDPNHEJG(List<string> IPLMAEDGHKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x10D6D50", Offset = "0x10D5F50", VA = "0x1810D6D50", Slot = "16")]
	public NHJDNADPIAN<Guid> HDPEOMBAEJP(PIHCLHIKEPH HPMPEKNNPND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x10DD0A0", Offset = "0x10DC2A0", VA = "0x1810DD0A0", Slot = "17")]
	public OOPPNGPPPLE OONKAMKGBCE(Guid JANCGILILJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x10D2730", Offset = "0x10D1930", VA = "0x1810D2730", Slot = "18")]
	public OOPPNGPPPLE BNMEPDCNLLM(Guid JANCGILILJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x10DB4D0", Offset = "0x10DA6D0", VA = "0x1810DB4D0", Slot = "19")]
	public bool LMBLDPACBAO(Guid JANCGILILJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x10D4E50", Offset = "0x10D4050", VA = "0x1810D4E50", Slot = "20")]
	public bool EFOOBAIBIJH(Guid JANCGILILJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x10D8B60", Offset = "0x10D7D60", VA = "0x1810D8B60")]
	public KeepsakeTheme IDKIDIBDCFD(Guid JANCGILILJA)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x10D5FD0", Offset = "0x10D51D0", VA = "0x1810D5FD0")]
	public bool FIDKJDMCOMO(PIHCLHIKEPH HPMPEKNNPND, out KeepsakeTheme PMCLNJCNLFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x10D7380", Offset = "0x10D6580", VA = "0x1810D7380")]
	public List<KeepsakeTheme> HEPKIFBJMIC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x10D2350", Offset = "0x10D1550", VA = "0x1810D2350")]
	public int AOFGLNFGBNN(PIHCLHIKEPH HPMPEKNNPND)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x10D61A0", Offset = "0x10D53A0", VA = "0x1810D61A0")]
	public PIHCLHIKEPH FKHNJLJHJJN(Guid JANCGILILJA)
	{
		return default(PIHCLHIKEPH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x10DB7A0", Offset = "0x10DA9A0", VA = "0x1810DB7A0", Slot = "34")]
	public List<PIHCLHIKEPH> LPMJGCCFHAI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x10D6A60", Offset = "0x10D5C60", VA = "0x1810D6A60", Slot = "35")]
	public IComparer<PIHCLHIKEPH> HCCAMDANEJK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x10D4E80", Offset = "0x10D4080", VA = "0x1810D4E80", Slot = "32")]
	public string EGDBMGNDHDJ(PIHCLHIKEPH HPMPEKNNPND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x10D2D80", Offset = "0x10D1F80", VA = "0x1810D2D80", Slot = "33")]
	public string CGOIAPHIHED(PIHCLHIKEPH HPMPEKNNPND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x10DC4F0", Offset = "0x10DB6F0", VA = "0x1810DC4F0", Slot = "21")]
	public bool NKNCMGJMDFF(Guid JANCGILILJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x10D84C0", Offset = "0x10D76C0", VA = "0x1810D84C0", Slot = "22")]
	public void HKIHFFOEMPE(Guid JANCGILILJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x10D8480", Offset = "0x10D7680", VA = "0x1810D8480", Slot = "23")]
	public void HIPAKOACLFK(PIHCLHIKEPH HPMPEKNNPND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x10DCC90", Offset = "0x10DBE90", VA = "0x1810DCC90", Slot = "24")]
	public void OHCGEPKEIND(Guid JANCGILILJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x10D5730", Offset = "0x10D4930", VA = "0x1810D5730", Slot = "25")]
	public int FBNLCDHDEPN()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x10D53C0", Offset = "0x10D45C0", VA = "0x1810D53C0", Slot = "54")]
	public int FBNLCDHDEPN(PIHCLHIKEPH HPMPEKNNPND)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x10D8770", Offset = "0x10D7970", VA = "0x1810D8770", Slot = "31")]
	public NHJDNADPIAN<IEnumerable<Guid>> HPCJNCMCNEB(long LNBFDCAEKJF, long MJHHGLBGJNF, PIHCLHIKEPH? HPMPEKNNPND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x10D18E0", Offset = "0x10D0AE0", VA = "0x1810D18E0", Slot = "30")]
	public NHJDNADPIAN<IEnumerable<Guid>> AEFLEIJHNEN(long LNBFDCAEKJF, long MJHHGLBGJNF, PIHCLHIKEPH? HPMPEKNNPND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x10DB910", Offset = "0x10DAB10", VA = "0x1810DB910", Slot = "55")]
	public NHJDNADPIAN<Dictionary<Guid, PIHCLHIKEPH>> MKGPGMGPACD(long LNBFDCAEKJF, long MJHHGLBGJNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x10DB340", Offset = "0x10DA540", VA = "0x1810DB340", Slot = "56")]
	public NHJDNADPIAN<Dictionary<Guid, PIHCLHIKEPH>> LKDCBODHLOG(long LNBFDCAEKJF, long MJHHGLBGJNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x10D1E00", Offset = "0x10D1000", VA = "0x1810D1E00", Slot = "26")]
	public NHJDNADPIAN<int> AHKJKOGJJGM(long LNBFDCAEKJF, long MJHHGLBGJNF, PIHCLHIKEPH? HPMPEKNNPND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x10D2BF0", Offset = "0x10D1DF0", VA = "0x1810D2BF0", Slot = "27")]
	public NHJDNADPIAN<int> CCNIAABDIIK(long LNBFDCAEKJF, long MJHHGLBGJNF, PIHCLHIKEPH? HPMPEKNNPND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x10DBF60", Offset = "0x10DB160", VA = "0x1810DBF60", Slot = "28")]
	public NHJDNADPIAN<Dictionary<PIHCLHIKEPH, int>> NABJDJLJMGN(long LNBFDCAEKJF, long MJHHGLBGJNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x10D1810", Offset = "0x10D0A10", VA = "0x1810D1810", Slot = "29")]
	public NHJDNADPIAN<Dictionary<PIHCLHIKEPH, int>> ADHNPKNEKII(long LNBFDCAEKJF, long MJHHGLBGJNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x10DE2F0", Offset = "0x10DD4F0", VA = "0x1810DE2F0", Slot = "37")]
	public bool PPCOEGPIJOH(long LNBFDCAEKJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x10DBF00", Offset = "0x10DB100", VA = "0x1810DBF00", Slot = "57")]
	public bool MOMNMEBEFFN(long LNBFDCAEKJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x10D9230", Offset = "0x10D8430", VA = "0x1810D9230", Slot = "38")]
	public bool INNDKALCBAB(long LNBFDCAEKJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x10DAA70", Offset = "0x10D9C70", VA = "0x1810DAA70", Slot = "58")]
	public bool KLKMJANIDOH(long LNBFDCAEKJF, out CBGCLGFAHPN AIHDFBDBFCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x10D90D0", Offset = "0x10D82D0", VA = "0x1810D90D0", Slot = "39")]
	public bool IGPJJLOOEKN(long FEMOKOOLCNN, out DateTime MPOBPBONKOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x10DA1F0", Offset = "0x10D93F0", VA = "0x1810DA1F0", Slot = "40")]
	public long JONPIABKOAC(long FEMOKOOLCNN)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x10D6B00", Offset = "0x10D5D00", VA = "0x1810D6B00", Slot = "59")]
	public IEnumerable<int> HDLPELJEIPM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x10DDBF0", Offset = "0x10DCDF0", VA = "0x1810DDBF0", Slot = "41")]
	public long PIOBGOMNHPK(long LNBFDCAEKJF)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x10DAE90", Offset = "0x10DA090", VA = "0x1810DAE90", Slot = "42")]
	public int KONPJEIBNBP(long FEMOKOOLCNN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x10D8D00", Offset = "0x10D7F00", VA = "0x1810D8D00", Slot = "43")]
	public bool IFGCGCKKNBE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x10D8DF0", Offset = "0x10D7FF0", VA = "0x1810D8DF0", Slot = "44")]
	public bool IGEKIDHHAOC(long FEMOKOOLCNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x10D6510", Offset = "0x10D5710", VA = "0x1810D6510", Slot = "45")]
	public IEnumerable<long> GAEIDDJKCIE(long FEMOKOOLCNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x10D6310", Offset = "0x10D5510", VA = "0x1810D6310", Slot = "46")]
	public int FPEIKBJBHDL(long FEMOKOOLCNN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x10DD420", Offset = "0x10DC620", VA = "0x1810DD420", Slot = "50")]
	public long PCGCOAHLPGK(long CPPDOOCKKGH)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x10D43E0", Offset = "0x10D35E0", VA = "0x1810D43E0", Slot = "51")]
	public PIHCLHIKEPH DOFEBOGACMA()
	{
		return default(PIHCLHIKEPH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x10D6880", Offset = "0x10D5A80", VA = "0x1810D6880")]
	private bool HABPDFPOGLK(Guid JANCGILILJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x10D3880", Offset = "0x10D2A80", VA = "0x1810D3880")]
	private void DCKNNEMDKHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x10D9B20", Offset = "0x10D8D20", VA = "0x1810D9B20")]
	private PIHCLHIKEPH JINLCLGDEPA()
	{
		return default(PIHCLHIKEPH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x10D3E30", Offset = "0x10D3030", VA = "0x1810D3E30")]
	private void DKJBECEGMGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x10DDD10", Offset = "0x10DCF10", VA = "0x1810DDD10")]
	private int PJDLDBDAHII(KeepsakeRoomListDTO LKHLPIKALEN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x10DA9A0", Offset = "0x10D9BA0", VA = "0x1810DA9A0")]
	private int KKHAGEFMBOD(DateTime HCBFPBFAMPK, DateTime ODFJKEABBOA, TimeSpan NLLAANHIFGH, int BEBFFHKHIAA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x10DBCF0", Offset = "0x10DAEF0", VA = "0x1810DBCF0")]
	private void MNBDHBLFPKJ(IEnumerable<KeepsakeInstanceDTO> AGIMFBDLBNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x10D8530", Offset = "0x10D7730", VA = "0x1810D8530")]
	private void HMDJLAILIJH(IEnumerable<KeepsakeCollectionRecordDTO> OHMNIALLADM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x10DA190", Offset = "0x10D9390", VA = "0x1810DA190")]
	private void JOBEAMKJOOM(IEnumerable<long> JDGDMBNJAHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x10DCFF0", Offset = "0x10DC1F0", VA = "0x1810DCFF0")]
	private void OKPHBHMOOLJ(KeepsakeGlobalConfigDTO JCCDNPCKOLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x10D1A80", Offset = "0x10D0C80", VA = "0x1810D1A80")]
	private bool AELKFGGBFCO(PIHCLHIKEPH HPMPEKNNPND, out Guid INAEGKKEEDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x10D98C0", Offset = "0x10D8AC0", VA = "0x1810D98C0")]
	private bool JCINHLKHMHA(out Guid INAEGKKEEDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x10DD3C0", Offset = "0x10DC5C0", VA = "0x1810DD3C0")]
	private bool PCCBEPBAGML(Guid JANCGILILJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x10D30F0", Offset = "0x10D22F0", VA = "0x1810D30F0")]
	private IEnumerable<Guid> CIKEKDDFDMG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x10DDEC0", Offset = "0x10DD0C0", VA = "0x1810DDEC0")]
	private IEnumerable<KeepsakeInstanceDTO> PNHHINMLEHD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x10DCEE0", Offset = "0x10DC0E0", VA = "0x1810DCEE0")]
	private void OJCMHLAOJMP(Guid JANCGILILJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x10D63C0", Offset = "0x10D55C0", VA = "0x1810D63C0")]
	private bool FPPGFJMHACO(Guid JANCGILILJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x10DCAF0", Offset = "0x10DBCF0", VA = "0x1810DCAF0")]
	private void ODKENIOJNGE(Guid JANCGILILJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x10D4D70", Offset = "0x10D3F70", VA = "0x1810D4D70")]
	private void EEGKIKEELKG(PIHCLHIKEPH BBDLOPHBELB, int EIFCDDHEIAF, ref Dictionary<PIHCLHIKEPH, int> FHHHNBFNBFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x10DC270", Offset = "0x10DB470", VA = "0x1810DC270")]
	private int NCHGLAHJGME(PIHCLHIKEPH HPMPEKNNPND)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x10DE120", Offset = "0x10DD320", VA = "0x1810DE120")]
	private void POMGADMBILE(KeepsakeInstanceDTO GDCGKJAEPHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x10D2EF0", Offset = "0x10D20F0", VA = "0x1810D2EF0")]
	private void CHENHPHNNMK(KeepsakeInstanceDTO GDCGKJAEPHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x10DD870", Offset = "0x10DCA70", VA = "0x1810DD870")]
	private void PIMEJMKOOMI(Guid JANCGILILJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x10DB2E0", Offset = "0x10DA4E0", VA = "0x1810DB2E0")]
	private void LFMKKAENCLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x10D2D60", Offset = "0x10D1F60", VA = "0x1810D2D60")]
	private void CCOKACJADHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x10DCF70", Offset = "0x10DC170", VA = "0x1810DCF70")]
	private void OKOBKLLPJFL(NAKGFMDIFDB GHJIPDLACNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x10DC790", Offset = "0x10DB990", VA = "0x1810DC790")]
	private void NLADHCGFGKC(JIGEKKNOGHC.NKFJHHKDIIP BHEOHCEHIBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x10DAE30", Offset = "0x10DA030", VA = "0x1810DAE30")]
	private void KOFABLPFGJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x10D4FF0", Offset = "0x10D41F0", VA = "0x1810D4FF0")]
	private void FAJNHKDCFEE(float OKFDMJPAALF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x10D9360", Offset = "0x10D8560", VA = "0x1810D9360")]
	private void JCGAHEOPIDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x10D5F20", Offset = "0x10D5120", VA = "0x1810D5F20")]
	private bool FENLBBFHNJE(Guid JANCGILILJA, out string JNMGFJIANOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x10DC920", Offset = "0x10DBB20", VA = "0x1810DC920")]
	private bool NPGCGCNNGKN(Guid JANCGILILJA, out KeepsakeCategoryConfigDTO BBDLOPHBELB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x10DC190", Offset = "0x10DB390", VA = "0x1810DC190")]
	private void NAOEPNGKAED(string OPJHAOHKCPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x10D2230", Offset = "0x10D1430", VA = "0x1810D2230")]
	private bool ALJHPJKKMGE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x10DA620", Offset = "0x10D9820", VA = "0x1810DA620")]
	private IEnumerable<long> KAEJHAIIONP(IEnumerable<KeepsakeRoomDTO> MGDBBNIDGHJ, IEnumerable<KeepsakeRoomListDTO> MBNCOKJLLHM, long FEMOKOOLCNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x10D1250", Offset = "0x10D0450", VA = "0x1810D1250")]
	private bool ABIAOOKDHML(Guid JANCGILILJA, out string KLEKJFJOCHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x10DA130", Offset = "0x10D9330", VA = "0x1810DA130", Slot = "47")]
	public string JKPEOCFFEIN(CBIIPFAPOKF NACCHDDNOJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x10D3250", Offset = "0x10D2450", VA = "0x1810D3250", Slot = "49")]
	public string CKJLIILJPAA(CBIIPFAPOKF NACCHDDNOJG, long LNBFDCAEKJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x10DD750", Offset = "0x10DC950", VA = "0x1810DD750", Slot = "48")]
	public string PCILGPFEJDF(CBIIPFAPOKF NACCHDDNOJG, int HKBOKBNIMKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x10D76D0", Offset = "0x10D68D0", VA = "0x1810D76D0")]
	private void HGPFCLDGGAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x10D2AB0", Offset = "0x10D1CB0", VA = "0x1810D2AB0")]
	private void BOFJNMPLBHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x10D90B0", Offset = "0x10D82B0", VA = "0x1810D90B0")]
	private CBIIPFAPOKF IGGAJBMIKND(DEPHKNCPDNG DMPNKANHDFG)
	{
		return default(CBIIPFAPOKF);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x10DB8F0", Offset = "0x10DAAF0", VA = "0x1810DB8F0")]
	private CBIIPFAPOKF MANHLPOJNOJ(DEPHKNCPDNG DMPNKANHDFG)
	{
		return default(CBIIPFAPOKF);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x10D36A0", Offset = "0x10D28A0", VA = "0x1810D36A0")]
	internal static string CPPHHDDPBBF(AEBAIJBAJAP DALKIHNCPJN, string DDFGAJKPHOE, bool BIJBKGMLGAB, int DEEMLOKNCIM, int DALHAEEIDHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x10D4790", Offset = "0x10D3990", VA = "0x1810D4790", Slot = "52")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x10D92D0", Offset = "0x10D84D0", VA = "0x1810D92D0")]
	private NAKMMEJMOAP IOEHLCKIHLM(NBDCAKCJOHF FKIAFEKBNAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x10D24B0", Offset = "0x10D16B0", VA = "0x1810D24B0")]
	private BDCIMDEJCKC BIADPCEOBOI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x10D5B90", Offset = "0x10D4D90", VA = "0x1810D5B90")]
	private Task FDABNOHBBHM(FEKMMALKIBN AHLCEBMCJMF, CancellationToken PLEKJLHDOLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x10D20C0", Offset = "0x10D12C0", VA = "0x1810D20C0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(GAIBDALMPKB))]
	private Task AKKANBJIOLO(FEKMMALKIBN AHLCEBMCJMF, CancellationToken PLEKJLHDOLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x10D67E0", Offset = "0x10D59E0", VA = "0x1810D67E0")]
	private Task HABDILCELNE(FEKMMALKIBN AHLCEBMCJMF, CancellationToken PLEKJLHDOLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x10DDF90", Offset = "0x10DD190", VA = "0x1810DDF90")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(AHPJMNPKJJP))]
	private Task POIGIEPLPLF(string CEOMJLPEFPB, TimeSpan EHJMAHNLOAA, CancellationToken PLEKJLHDOLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0xC7AD40", Offset = "0xC79F40", VA = "0x180C7AD40")]
	[CompilerGenerated]
	private void HIFGMBKBOJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x10D8430", Offset = "0x10D7630", VA = "0x1810D8430")]
	[CompilerGenerated]
	private void HIEFFFCLICC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x10D9990", Offset = "0x10D8B90", VA = "0x1810D9990")]
	[CompilerGenerated]
	private bool JCPNOOOJNOM(KeepsakeInstanceDTO JNIPLDLJAIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x10DB620", Offset = "0x10DA820", VA = "0x1810DB620")]
	[CompilerGenerated]
	private NHJDNADPIAN<Dictionary<PIHCLHIKEPH, int>> LOIEJOPCMAK(Dictionary<Guid, PIHCLHIKEPH> FINFADOEACC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x10DC370", Offset = "0x10DB570", VA = "0x1810DC370")]
	[CompilerGenerated]
	private NHJDNADPIAN<Dictionary<PIHCLHIKEPH, int>> NDGAOKIIDDF(Dictionary<Guid, PIHCLHIKEPH> FINFADOEACC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x10D5FB0", Offset = "0x10D51B0", VA = "0x1810D5FB0")]
	[CompilerGenerated]
	private bool FGLLJCIILPK(KeepsakeRoomListDTO JNIPLDLJAIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x10DC7F0", Offset = "0x10DB9F0", VA = "0x1810DC7F0")]
	[CompilerGenerated]
	private bool NPGCCLGIHLD(KeepsakeInstanceDTO JNIPLDLJAIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x10D4BF0", Offset = "0x10D3DF0", VA = "0x1810D4BF0")]
	[CompilerGenerated]
	private void EDDONEBHOCL(Tuple<KeepsakeRoomInstancesDTO, IReadOnlyDictionary<PIHCLHIKEPH, KeepsakeCategoryConfigDTO>, KeepsakeGlobalConfigDTO> LGLOPKEAHMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x10D3D60", Offset = "0x10D2F60", VA = "0x1810D3D60")]
	[CompilerGenerated]
	private void DDHBOGFGFNJ(string KLEKJFJOCHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x10DB090", Offset = "0x10DA290", VA = "0x1810DB090")]
	[CompilerGenerated]
	private Task KPEJLNFKPKI(CancellationToken LGAHMAGIEIA)
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
public class CGEPNPBBKEG
{
	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
	public CGEPNPBBKEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x892120", Offset = "0x891320", VA = "0x180892120")]
	public static string AADLLEBJPEC(byte[] MJAMHAEGDEA, byte[] ELNJHIHGPEE)
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
