using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
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
	public class KeepsakesConfig : ScriptableObject, KLEGICIHAEO<KeepsakesConfig.KeepsakesOptions>
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		public class KeepsakesOptions
		{
			[Cpp2IlInjected.Token(Token = "0x2000004")]
			[CompilerGenerated]
			private sealed class FPDOFNMAFEF
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000003")]
				public string themeId;

				[Cpp2IlInjected.Token(Token = "0x6000005")]
				[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
				public FPDOFNMAFEF()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000006")]
				[Cpp2IlInjected.Address(RVA = "0x56AF6F0", Offset = "0x56AE8F0", VA = "0x1856AF6F0")]
				internal bool PHLGNOJCNCO(KeepsakeTheme x)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000007")]
				[Cpp2IlInjected.Address(RVA = "0x56AF6F0", Offset = "0x56AE8F0", VA = "0x1856AF6F0")]
				internal bool KIMKBIALAHO(KeepsakeTheme x)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000002")]
			[SerializeField]
			private KeepsakeTheme[] themes;

			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x56B0410", Offset = "0x56AF610", VA = "0x1856B0410")]
			public bool JPJKHJDMDDC(string NPEGKDLIHJE, out KeepsakeTheme OBLFKPNFOEA)
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
			[Cpp2IlInjected.Address(RVA = "0x7EBAF0", Offset = "0x7EACF0", VA = "0x1807EBAF0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x56B0390", Offset = "0x56AF590", VA = "0x1856B0390")]
		[GKCPJLBLCDF(EHLDMJJGFKP.GameOnly)]
		private static void CBJFBKKBGCJ(JFLMNMMPBBG AKLNKNCLGHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x99A150", Offset = "0x999350", VA = "0x18099A150")]
		public KeepsakesConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class OPBEKHANPEA : IComparer<DLHAJNJECEF>
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class MLEEJKKLKHJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public DLHAJNJECEF x;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public DLHAJNJECEF y;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public MLEEJKKLKHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xCC35F0", Offset = "0xCC27F0", VA = "0x180CC35F0")]
		internal bool DONNOCHGJKB(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xC6F110", Offset = "0xC6E310", VA = "0x180C6F110")]
		internal bool PJKLNLOPGCJ(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xCC35F0", Offset = "0xCC27F0", VA = "0x180CC35F0")]
		internal bool ICDDHDDMKOA(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xC6F110", Offset = "0xC6E310", VA = "0x180C6F110")]
		internal bool GGOPPFJFKPA(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<KeepsakeCategoryThemePair> HNMBIKKAFAN;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x8888D0", Offset = "0x887AD0", VA = "0x1808888D0")]
	public OPBEKHANPEA(List<KeepsakeCategoryThemePair> LJOJOEBLOHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x56B1160", Offset = "0x56B0360", VA = "0x1856B1160", Slot = "4")]
	public int Compare(DLHAJNJECEF JPBGAMDOIJA, DLHAJNJECEF IIJHAMIHIMK)
	{
		return default(int);
	}
}
namespace RecRoom.Keepsakes
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct KeepsakeCategoryThemePair
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public DLHAJNJECEF KeepsakeCategory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public KeepsakeTheme KeepsakeTheme;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[FDHBNKNBNCC]
public class BJIINDBHLKK : EOBEKFCDCGB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class JBNDBCNKFCK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public BJIINDBHLKK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public DLHAJNJECEF keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public JBNDBCNKFCK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x56B0060", Offset = "0x56AF260", VA = "0x1856B0060")]
		internal OOMFLHAHLDK<Guid> LJJOPKLIDLJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x56B01A0", Offset = "0x56AF3A0", VA = "0x1856B01A0")]
		internal void MNKEFPHKBLL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x56B01D0", Offset = "0x56AF3D0", VA = "0x1856B01D0")]
		internal void OCMBMFNKMMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x56AFBD0", Offset = "0x56AEDD0", VA = "0x1856AFBD0")]
		internal void EPMAOLCANOA(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x56B0030", Offset = "0x56AF230", VA = "0x1856B0030")]
		internal void KHENILKHMHF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class NCFFNDAEPLC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public BJIINDBHLKK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public string keepsakePickupName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public int collectedKeepsakeCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public int collectableKeepsakeCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public Guid keepsakeInstanceId;

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public NCFFNDAEPLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x56B0830", Offset = "0x56AFA30", VA = "0x1856B0830")]
		internal void IJAJDCIBKML(PKJDOKODLMG response)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x56B0BE0", Offset = "0x56AFDE0", VA = "0x1856B0BE0")]
		internal void JBPENFMBBGE(string error)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class OAIIMDOPKJA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public KeepsakeTheme theme;

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public OAIIMDOPKJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x56B0FD0", Offset = "0x56B01D0", VA = "0x1856B0FD0")]
		internal bool OLPOAEIHMLD(KeepsakeCategoryThemePair categoryThemePair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class NHHABLJLNKL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public BJIINDBHLKK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public long progressionEventId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public DLHAJNJECEF? keepsakeCategory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public NHHABLJLNKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x56B0C40", Offset = "0x56AFE40", VA = "0x1856B0C40")]
		internal void FFLKLMLEDDP(KeepsakeProgressionEventInstancesDTO result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x56AEB00", Offset = "0x56ADD00", VA = "0x1856AEB00")]
		internal void DEJFAOJIAIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x56B0CC0", Offset = "0x56AFEC0", VA = "0x1856B0CC0")]
		internal OOMFLHAHLDK<IEnumerable<Guid>> JJIIICNGGPO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x2FA4A10", Offset = "0x2FA3C10", VA = "0x182FA4A10")]
		internal bool JOMEACDLHLO(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class EIMLGLOLOKG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public KeepsakeRoomInstanceIdsDTO instancesInRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public NHHABLJLNKL CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public EIMLGLOLOKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x56AF390", Offset = "0x56AE590", VA = "0x1856AF390")]
		internal OOMFLHAHLDK<IEnumerable<Guid>> CCHEJPDHKGK(KeepsakeRoomInstancesDTO roomInstancesDTO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class MHFEENPAPKF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public KeepsakeRoomInstancesDTO roomInstancesDTO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public EIMLGLOLOKG CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public MHFEENPAPKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x56B0700", Offset = "0x56AF900", VA = "0x1856B0700")]
		internal bool IJOFIJFMNAM(Guid instanceId)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class BDCOABOHGIE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Guid instanceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public MHFEENPAPKF CS$<>8__locals3;

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public BDCOABOHGIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x56A0A20", Offset = "0x569FC20", VA = "0x1856A0A20")]
		internal bool BACJLDEGDBD(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class IPLBNHBLKLK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public BJIINDBHLKK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public IPLBNHBLKLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x56AFA60", Offset = "0x56AEC60", VA = "0x1856AFA60")]
		internal OOMFLHAHLDK<IEnumerable<Guid>> MJKCNHHGCEF(IEnumerable<Guid> instanceIds)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x56AE8C0", Offset = "0x56ADAC0", VA = "0x1856AE8C0")]
		internal bool EKHKNIKPNAH(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class BLOMPLNLEGD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public BJIINDBHLKK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public long progressionEventId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public BLOMPLNLEGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x56AEE30", Offset = "0x56AE030", VA = "0x1856AEE30")]
		internal void PKGPBCJJCNB(KeepsakeProgressionEventInstancesDTO result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x56AEB00", Offset = "0x56ADD00", VA = "0x1856AEB00")]
		internal void AANMJBGFBAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x56AEB30", Offset = "0x56ADD30", VA = "0x1856AEB30")]
		internal OOMFLHAHLDK<Dictionary<Guid, DLHAJNJECEF>> LBKHKCHJFFJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x2FA4A10", Offset = "0x2FA3C10", VA = "0x182FA4A10")]
		internal bool DCCPLAIONPA(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class DACHAAPHAJG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public KeepsakeRoomInstanceIdsDTO instancesInRoom;

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public DACHAAPHAJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x56AEF50", Offset = "0x56AE150", VA = "0x1856AEF50")]
		internal OOMFLHAHLDK<Dictionary<Guid, DLHAJNJECEF>> HPEHHLJFGHN(KeepsakeRoomInstancesDTO roomInstancesDTO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class DJHMOMNAJDH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public KeepsakeRoomInstancesDTO roomInstancesDTO;

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public DJHMOMNAJDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x56AF2A0", Offset = "0x56AE4A0", VA = "0x1856AF2A0")]
		internal bool PEOCDBJIEIF(Guid instanceId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x56AF120", Offset = "0x56AE320", VA = "0x1856AF120")]
		internal KeyValuePair<Guid, DLHAJNJECEF> NNBPJNOGPFK(Guid instanceId)
		{
			return default(KeyValuePair<Guid, DLHAJNJECEF>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class FDLKKKFGKGJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public Guid instanceId;

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public FDLKKKFGKGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x56AF650", Offset = "0x56AE850", VA = "0x1856AF650")]
		internal bool OCIEKMOGKHL(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class BOHHDPHOADK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public Guid instanceId;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public BOHHDPHOADK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x56AEEB0", Offset = "0x56AE0B0", VA = "0x1856AEEB0")]
		internal bool MKGKGBFHBBA(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class BLMNJAAPFGP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public BJIINDBHLKK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public BLMNJAAPFGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x56AE8E0", Offset = "0x56ADAE0", VA = "0x1856AE8E0")]
		internal OOMFLHAHLDK<Dictionary<Guid, DLHAJNJECEF>> LHCGOMNNAJP(Dictionary<Guid, DLHAJNJECEF> instanceIdsAndCategories)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x56AE8C0", Offset = "0x56ADAC0", VA = "0x1856AE8C0")]
		internal bool DMHBIENKPBP(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class HMHFGIAJIHL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public KeepsakeRoomInstanceIdsDTO collectedInstanceIds;

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public HMHFGIAJIHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x56AF720", Offset = "0x56AE920", VA = "0x1856AF720")]
		internal bool PJHJOPCKNCE(KeyValuePair<Guid, DLHAJNJECEF> idCategoryPair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class OAKBDBNCAAE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public Dictionary<Guid, DLHAJNJECEF> instanceIdsAndCategories;

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public OAKBDBNCAAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x56B1000", Offset = "0x56B0200", VA = "0x1856B1000")]
		internal KeyValuePair<DLHAJNJECEF, int> KFPEHCPBGAH(DLHAJNJECEF category)
		{
			return default(KeyValuePair<DLHAJNJECEF, int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class OEPKMGFFKHF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public DLHAJNJECEF category;

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public OEPKMGFFKHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0xF4CD70", Offset = "0xF4BF70", VA = "0x180F4CD70")]
		internal bool HMOEAKGOJEL(DLHAJNJECEF instanceCategory)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class JJFDKDBKPMK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public Dictionary<Guid, DLHAJNJECEF> instanceIdsAndCategories;

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public JJFDKDBKPMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x56B0230", Offset = "0x56AF430", VA = "0x1856B0230")]
		internal KeyValuePair<DLHAJNJECEF, int> JPAHEACMPKL(DLHAJNJECEF category)
		{
			return default(KeyValuePair<DLHAJNJECEF, int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class NGOJJODOLPD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public DLHAJNJECEF category;

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public NGOJJODOLPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0xF4CD70", Offset = "0xF4BF70", VA = "0x180F4CD70")]
		internal bool MICEHDMPLAJ(DLHAJNJECEF instanceCategory)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class ABOIADPBOGE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public BJIINDBHLKK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public Func<KeepsakeRoomDTO, bool> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public ABOIADPBOGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x56A0240", Offset = "0x569F440", VA = "0x1856A0240")]
		internal bool FBFCEBAKCHC(DateTime nowUtc, DateTime eventStartTime, int roomOrder, TimeSpan unlockStartOffset, TimeSpan unlockInterval, int unlockBatchSize)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x56A0320", Offset = "0x569F520", VA = "0x1856A0320")]
		internal bool JDPEAOBCLOF(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x56A0220", Offset = "0x569F420", VA = "0x1856A0220")]
		internal bool ABEHLEEGMNN(KeepsakeRoomDTO r)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x56A0220", Offset = "0x569F420", VA = "0x1856A0220")]
		internal bool CGFDFGBCHPC(KeepsakeRoomDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class EHOFAJNAFLB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public EHOFAJNAFLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0xB27D40", Offset = "0xB26F40", VA = "0x180B27D40")]
		internal bool JAINAAMDCEP(KeepsakeRoomListDTO roomList)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class IMDINLNHIBG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public Func<KeepsakeRoomDTO, bool> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public IMDINLNHIBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x56AF990", Offset = "0x56AEB90", VA = "0x1856AF990")]
		internal bool FFOCHAMLBFE(KeepsakeRoomListDTO roomList)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0xAD9930", Offset = "0xAD8B30", VA = "0x180AD9930")]
		internal bool IPPFACCLFDF(KeepsakeRoomDTO room)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class BBGLJIPPJMC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public BBGLJIPPJMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x56A0920", Offset = "0x569FB20", VA = "0x1856A0920")]
		internal bool AODHIMNIANF(KeepsakeRoomListDTO i)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class MLEBCMDNFFP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public MLEBCMDNFFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0xB27D40", Offset = "0xB26F40", VA = "0x180B27D40")]
		internal bool BFFMEJCEJFH(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class LOPKEHJABNC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public Guid keepsakeInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public LOPKEHJABNC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x56B0670", Offset = "0x56AF870", VA = "0x1856B0670")]
		internal bool MEKDOBGLACK(KeyValuePair<Guid, KeepsakeInstanceDTO> instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class NCDFKLKHFNO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public DLHAJNJECEF keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public NCDFKLKHFNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0xAD5ED0", Offset = "0xAD50D0", VA = "0x180AD5ED0")]
		internal bool FFELKMBKBCP(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class LKLHELKEDNB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public Guid keepsakeInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public LKLHELKEDNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x56B05E0", Offset = "0x56AF7E0", VA = "0x1856B05E0")]
		internal bool NECJCKAHEFP(KeyValuePair<Guid, KeepsakeInstanceDTO> instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class PMFKJEJEKAC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public DLHAJNJECEF keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public PMFKJEJEKAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x56B1410", Offset = "0x56B0610", VA = "0x1856B1410")]
		internal bool AGDFMCAKEBC(KeyValuePair<Guid, DLHAJNJECEF> x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class LHKFBAGBLFD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public DLHAJNJECEF newKeepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public LHKFBAGBLFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0xAD5ED0", Offset = "0xAD50D0", VA = "0x180AD5ED0")]
		internal bool PMIPPLNDAJI(KeepsakeInstanceDTO instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class BCJKAEKEMCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public long currentRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public long? currentSubRoomId;

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public BCJKAEKEMCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x56A0990", Offset = "0x569FB90", VA = "0x1856A0990")]
		internal bool NHLCHKKJFCG(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class EOBIIIHGDDC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public IEnumerable<KeepsakeRoomListDTO> roomList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public EOBIIIHGDDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x56AF560", Offset = "0x56AE760", VA = "0x1856AF560")]
		internal bool FMAEOOOEIEB(KeepsakeRoomDTO room)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class EJEEDHFDJLP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public KeepsakeRoomDTO room;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public EOBIIIHGDDC CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public EJEEDHFDJLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x56AF4E0", Offset = "0x56AE6E0", VA = "0x1856AF4E0")]
		internal bool LIOJGBAICGL(KeepsakeRoomListDTO roomListDto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class AFCKIAHBOOM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public LPHBDDFNIEM args;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public BJIINDBHLKK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private Exception <e>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private List<KeepsakeInstanceDTO> <validKeepsakeInstances>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public AFCKIAHBOOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x56A03F0", Offset = "0x569F5F0", VA = "0x1856A03F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class IGCCFNHJHDE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public string message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public TimeSpan delay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public BJIINDBHLKK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public IGCCFNHJHDE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x56AF7A0", Offset = "0x56AE9A0", VA = "0x1856AF7A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly DateTime GKGKDLIJHOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly HGMNIHJCAIE HIIGPJBGICK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly GFLMCFANCML FECDLBKBDMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly KFHMJIMJKGN LNHDJMOIEPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly OPMAGJLJOEH IGEKKNCBPBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly MFJKEMECNGI BFBBPILOBDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly MCCHMKHJLMF DPKGEHFCLGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly IJHNPMDMGIK NPDKCJPJIJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly ALKNFJDHKDJ FPIOPDMALNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly FLABIJEPLDF MPMOHPBOMGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly NHHGJFCBPGI COCKBPMAGEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly OGKDDILLKFK NBKEOJODANH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly KGIADFGHENL NDNNMBJNPHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly FBKJOGAPAEM IABNCEOMBGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly FMABBFFAJFM EJNAPPPBKFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly ABOPJMGLBBD GBPMIBGGBAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly KLEGICIHAEO<KeepsakesConfig.KeepsakesOptions> CPPBBBCKIMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly ABJPHNNDPLE CJGKPKOFFDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly Dictionary<Guid, KeepsakeInstanceDTO> GNENEDOLGJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly HashSet<Guid> DCEBFLODDAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly HashSet<long> KMJMKFGGCBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private Dictionary<DLHAJNJECEF, int> ELBHLACEHBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly HashSet<Guid> MFPNMDKBNOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly IDisposable BJCEDDJJIMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private Task EMBPEHOPLNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private OOMFLHAHLDK<Guid> CCHPLLMDANH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private long? HMJOLCHLPII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private KeepsakeProgressionEventInstancesDTO FJKPLICCBEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private OOMFLHAHLDK<KeepsakeProgressionEventInstancesDTO> EMGOOILFMKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private IReadOnlyDictionary<DLHAJNJECEF, KeepsakeCategoryConfigDTO> NFMEBBJBNMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private KeepsakeGlobalConfigDTO CCFKIKNCBKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private HashSet<long> LJFFIPCGPOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private HashSet<long> KJFACDGPAEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private List<KeepsakeRoomListDTO> NFBDDIMMNNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private List<KeepsakeRoomListDTO> IPCOINHIGKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private List<KeepsakeRoomListDTO> AJAOCIGGLDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private Dictionary<long, string> MJKGKAEJMLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private Dictionary<long, string> ICBGCKAMACI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private Dictionary<long, DateTime> NDEIFEAKJLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private Dictionary<long, List<KeepsakeRoomDTO>> KFOMHDHGFBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private Dictionary<long, List<KeepsakeRoomDTO>> LIEMDNHNHIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private Dictionary<long, long> KMOGPMMGKDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly List<string> ENOMEOBLBJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private DateTime IIJMAPBNFGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly IDisposable CCEEBIMCDDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private Dictionary<Guid, DLHAJNJECEF> HEBPFDJNBHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private Dictionary<DLHAJNJECEF, int> NNFMFNFDMAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private List<KeepsakeCategoryThemePair> LJOJOEBLOHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private OPBEKHANPEA KCNHJEEDPJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private bool OJFCIFNGENI;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool FLADJJFJNGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x929880", Offset = "0x928A80", VA = "0x180929880", Slot = "53")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x9298C0", Offset = "0x928AC0", VA = "0x1809298C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool OIMGCFAAMLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x56A6E80", Offset = "0x56A6080", VA = "0x1856A6E80", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool IFJEANPGBOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x56AC610", Offset = "0x56AB810", VA = "0x1856AC610", Slot = "36")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private long PMJLNIAEOKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x56A9130", Offset = "0x56A8330", VA = "0x1856A9130")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private long? LFEAHCGGFIL
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x56A8D50", Offset = "0x56A7F50", VA = "0x1856A8D50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private bool GKGIGBGBPLF
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x56A5700", Offset = "0x56A4900", VA = "0x1856A5700")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public IReadOnlyList<KeepsakeRoomListDTO> MKOMCMLNCCM
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xA07120", Offset = "0xA06320", VA = "0x180A07120", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IReadOnlyList<KeepsakeRoomListDTO> NECCJLKLLNM
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xE58610", Offset = "0xE57810", VA = "0x180E58610", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public IReadOnlyList<KeepsakeRoomListDTO> FCFCNPIBNIF
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x1203E60", Offset = "0x1203060", VA = "0x181203E60", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public IReadOnlyDictionary<long, string> DNKDOOPFLCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xBE9E60", Offset = "0xBE9060", VA = "0x180BE9E60", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	internal bool ADOOHJFGAPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xE58620", Offset = "0xE57820", VA = "0x180E58620")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Guid?> MONEFKLEAPA
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x56AADF0", Offset = "0x56A9FF0", VA = "0x1856AADF0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x56ABAC0", Offset = "0x56AACC0", VA = "0x1856ABAC0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action GMNOHCFAGLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x56A29F0", Offset = "0x56A1BF0", VA = "0x1856A29F0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x56A68E0", Offset = "0x56A5AE0", VA = "0x1856A68E0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action LJGENJMCMGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x56AAAC0", Offset = "0x56A9CC0", VA = "0x1856AAAC0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x56A1C10", Offset = "0x56A0E10", VA = "0x1856A1C10", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x56AD5A0", Offset = "0x56AC7A0", VA = "0x1856AD5A0")]
	[Preserve]
	internal BJIINDBHLKK([NotNull][NDGONEEEGIA(null)] HGMNIHJCAIE HIIGPJBGICK, [NotNull][NDGONEEEGIA(null)] CEJONHFMJDN KPHDNBHKAKO, [NotNull][NDGONEEEGIA(null)] GFLMCFANCML FECDLBKBDMO, [NotNull][NDGONEEEGIA(null)] KFHMJIMJKGN LNHDJMOIEPH, [NotNull][NDGONEEEGIA(null)] OPMAGJLJOEH IGEKKNCBPBF, [NotNull][NDGONEEEGIA(null)] MFJKEMECNGI BFBBPILOBDE, [NotNull][NDGONEEEGIA(null)] MCCHMKHJLMF DPKGEHFCLGO, [NotNull][NDGONEEEGIA(null)] IJHNPMDMGIK NPDKCJPJIJG, [NotNull][NDGONEEEGIA(null)] ALKNFJDHKDJ FPIOPDMALNF, [NotNull][NDGONEEEGIA(null)] OCILFANHGGG GKABAKBAONJ, [NotNull][NDGONEEEGIA(null)] FLABIJEPLDF MPMOHPBOMGM, [NotNull][NDGONEEEGIA(null)] NHHGJFCBPGI COCKBPMAGEL, [NotNull][NDGONEEEGIA(null)] OGKDDILLKFK NBKEOJODANH, [NotNull][NDGONEEEGIA(null)] KGIADFGHENL NDNNMBJNPHD, [NotNull][NDGONEEEGIA(null)] FBKJOGAPAEM IABNCEOMBGF, [NotNull][NDGONEEEGIA(null)] FMABBFFAJFM EJNAPPPBKFD, [NotNull][NDGONEEEGIA(null)] ABOPJMGLBBD GBPMIBGGBAO, [NotNull][NDGONEEEGIA(null)] KLEGICIHAEO<KeepsakesConfig.KeepsakesOptions> CPPBBBCKIMF, [NotNull][NDGONEEEGIA(null)] ABJPHNNDPLE CJGKPKOFFDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x56AB2B0", Offset = "0x56AA4B0", VA = "0x1856AB2B0", Slot = "15")]
	public bool ODJAACCGCIJ(List<string> KLKDCMDJCNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x56A6FA0", Offset = "0x56A61A0", VA = "0x1856A6FA0", Slot = "16")]
	public OOMFLHAHLDK<Guid> IMAIMMBIJKI(DLHAJNJECEF HKACKNCFAEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x56A0BF0", Offset = "0x569FDF0", VA = "0x1856A0BF0", Slot = "17")]
	public GIOBGNHJLID ADNJJPKGBDH(Guid CKCOJKGAGID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x56A9350", Offset = "0x56A8550", VA = "0x1856A9350", Slot = "18")]
	public GIOBGNHJLID KMCMABMPGND(Guid CKCOJKGAGID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x56AA2E0", Offset = "0x56A94E0", VA = "0x1856AA2E0", Slot = "19")]
	public bool LOKFFKALNLO(Guid CKCOJKGAGID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x56A61F0", Offset = "0x56A53F0", VA = "0x1856A61F0", Slot = "20")]
	public bool GLICHGAJHCL(Guid CKCOJKGAGID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x56A4440", Offset = "0x56A3640", VA = "0x1856A4440")]
	public KeepsakeTheme FDIAMLEOPFJ(Guid CKCOJKGAGID)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x56AA430", Offset = "0x56A9630", VA = "0x1856AA430")]
	public bool LPOBAIAMIHC(DLHAJNJECEF HKACKNCFAEK, out KeepsakeTheme OBLFKPNFOEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x56AA6A0", Offset = "0x56A98A0", VA = "0x1856AA6A0")]
	public List<KeepsakeTheme> MJJMHONCEOD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x56A8B30", Offset = "0x56A7D30", VA = "0x1856A8B30")]
	public int KDABOALJICO(DLHAJNJECEF HKACKNCFAEK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x56AD430", Offset = "0x56AC630", VA = "0x1856AD430")]
	public DLHAJNJECEF PKJNIIECKGN(Guid CKCOJKGAGID)
	{
		return default(DLHAJNJECEF);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x56A75D0", Offset = "0x56A67D0", VA = "0x1856A75D0", Slot = "34")]
	public List<DLHAJNJECEF> IMFPDILFKMC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x56AA600", Offset = "0x56A9800", VA = "0x1856AA600", Slot = "35")]
	public IComparer<DLHAJNJECEF> MBAFDBJCHGL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x56ABCD0", Offset = "0x56AAED0", VA = "0x1856ABCD0", Slot = "32")]
	public string OOLKAOEDJDD(DLHAJNJECEF HKACKNCFAEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x56A45E0", Offset = "0x56A37E0", VA = "0x1856A45E0", Slot = "33")]
	public string FLFDILHLFIL(DLHAJNJECEF HKACKNCFAEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x56AC270", Offset = "0x56AB470", VA = "0x1856AC270", Slot = "21")]
	public bool PGLIGCLEGHF(Guid CKCOJKGAGID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x56A24A0", Offset = "0x56A16A0", VA = "0x1856A24A0", Slot = "22")]
	public void CLFBCHFMFJF(Guid CKCOJKGAGID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x56A9EB0", Offset = "0x56A90B0", VA = "0x1856A9EB0", Slot = "23")]
	public void LKKHBNDCMEA(DLHAJNJECEF HKACKNCFAEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x56A2A90", Offset = "0x56A1C90", VA = "0x1856A2A90", Slot = "24")]
	public void DIGIGGNDEJO(Guid CKCOJKGAGID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x56A85B0", Offset = "0x56A77B0", VA = "0x1856A85B0", Slot = "25")]
	public int KBLAFDAIPBO()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x56A2D90", Offset = "0x56A1F90", VA = "0x1856A2D90", Slot = "31")]
	public OOMFLHAHLDK<IEnumerable<Guid>> DMHLLFHFKAN(long HBFBDJIOFCF, long HHLFKPKHDIA, DLHAJNJECEF? HKACKNCFAEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x56A7CD0", Offset = "0x56A6ED0", VA = "0x1856A7CD0", Slot = "30")]
	public OOMFLHAHLDK<IEnumerable<Guid>> JCBLIPOLNHI(long HBFBDJIOFCF, long HHLFKPKHDIA, DLHAJNJECEF? HKACKNCFAEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x56A4F60", Offset = "0x56A4160", VA = "0x1856A4F60", Slot = "54")]
	public OOMFLHAHLDK<Dictionary<Guid, DLHAJNJECEF>> GAHNFANIKAP(long HBFBDJIOFCF, long HHLFKPKHDIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x56A11A0", Offset = "0x56A03A0", VA = "0x1856A11A0", Slot = "55")]
	public OOMFLHAHLDK<Dictionary<Guid, DLHAJNJECEF>> AJBIGEFIOCC(long HBFBDJIOFCF, long HHLFKPKHDIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x56A4B20", Offset = "0x56A3D20", VA = "0x1856A4B20", Slot = "26")]
	public OOMFLHAHLDK<int> FMBPCNJHDAA(long HBFBDJIOFCF, long HHLFKPKHDIA, DLHAJNJECEF? HKACKNCFAEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x56A8010", Offset = "0x56A7210", VA = "0x1856A8010", Slot = "27")]
	public OOMFLHAHLDK<int> JLEJDKPEGPO(long HBFBDJIOFCF, long HHLFKPKHDIA, DLHAJNJECEF? HKACKNCFAEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x56A6220", Offset = "0x56A5420", VA = "0x1856A6220", Slot = "28")]
	public OOMFLHAHLDK<Dictionary<DLHAJNJECEF, int>> GMCNPHCHFML(long HBFBDJIOFCF, long HHLFKPKHDIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x56AA9F0", Offset = "0x56A9BF0", VA = "0x1856AA9F0", Slot = "29")]
	public OOMFLHAHLDK<Dictionary<DLHAJNJECEF, int>> MKDJHBOJFLE(long HBFBDJIOFCF, long HHLFKPKHDIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x56A9D10", Offset = "0x56A8F10", VA = "0x1856A9D10", Slot = "37")]
	public bool LFKONGAOMOJ(long HBFBDJIOFCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x56A9CB0", Offset = "0x56A8EB0", VA = "0x1856A9CB0", Slot = "56")]
	public bool LFHMMIKJAHF(long HBFBDJIOFCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x56AAB60", Offset = "0x56A9D60", VA = "0x1856AAB60", Slot = "38")]
	public bool MNLGEGOGDAO(long HBFBDJIOFCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x56A5340", Offset = "0x56A4540", VA = "0x1856A5340", Slot = "57")]
	public bool GDFEJAIGCJG(long HBFBDJIOFCF, out ILFIAEHALFM GBNNFJPOIJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x56A9200", Offset = "0x56A8400", VA = "0x1856A9200", Slot = "39")]
	public bool KKOCAFCHNJD(long NMDBCDIOHJN, out DateTime HNLHDHCOGFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x56ABE40", Offset = "0x56AB040", VA = "0x1856ABE40", Slot = "40")]
	public long PENEOLHFPMD(long NMDBCDIOHJN)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x56A0E70", Offset = "0x56A0070", VA = "0x1856A0E70", Slot = "41")]
	public long AFPILHNKHIJ(long HBFBDJIOFCF)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x56A39A0", Offset = "0x56A2BA0", VA = "0x1856A39A0", Slot = "42")]
	public int ECGHODDPDHP(long NMDBCDIOHJN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x56A9BC0", Offset = "0x56A8DC0", VA = "0x1856A9BC0", Slot = "43")]
	public bool LDCAMOOMFLP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x56A1330", Offset = "0x56A0530", VA = "0x1856A1330", Slot = "44")]
	public bool APGGNJICPDO(long NMDBCDIOHJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x56AB5C0", Offset = "0x56AA7C0", VA = "0x1856AB5C0", Slot = "45")]
	public IEnumerable<long> ODOLOILJHHI(long NMDBCDIOHJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x56A6980", Offset = "0x56A5B80", VA = "0x1856A6980", Slot = "46")]
	public int IGKEEEHGPPC(long NMDBCDIOHJN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x56AAEF0", Offset = "0x56AA0F0", VA = "0x1856AAEF0", Slot = "50")]
	public long OAGHOEFKFHG(long JLLLDBKHPHE)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x56A3F60", Offset = "0x56A3160", VA = "0x1856A3F60", Slot = "51")]
	public DLHAJNJECEF EHFJMFEADFA()
	{
		return default(DLHAJNJECEF);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x56A96D0", Offset = "0x56A88D0", VA = "0x1856A96D0")]
	private bool KMILPIPHKKP(Guid CKCOJKGAGID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x56A5720", Offset = "0x56A4920", VA = "0x1856A5720")]
	private void GEAIMIKELGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x56A1D40", Offset = "0x56A0F40", VA = "0x1856A1D40")]
	private DLHAJNJECEF BNANFGLHKJH()
	{
		return default(DLHAJNJECEF);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x56A7720", Offset = "0x56A6920", VA = "0x1856A7720")]
	private void INMAFPDHEOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x56A8F80", Offset = "0x56A8180", VA = "0x1856A8F80")]
	private int KJOCKPPICFF(KeepsakeRoomListDTO NOFMGPKBCMK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x56A0B20", Offset = "0x569FD20", VA = "0x1856A0B20")]
	private int ABOLEPPEMKE(DateTime JCOJFOCJFDN, DateTime LKHHKIJPMDJ, TimeSpan MPAIOPGFCCE, int JDNGCPHFGHI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x56A0F90", Offset = "0x56A0190", VA = "0x1856A0F90")]
	private void AHJFGOKONME(IEnumerable<KeepsakeInstanceDTO> GNENEDOLGJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x56A2200", Offset = "0x56A1400", VA = "0x1856A2200")]
	private void CJOMAKNMLIF(IEnumerable<KeepsakeCollectionRecordDTO> AHKKIHMIACF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x56A8CF0", Offset = "0x56A7EF0", VA = "0x1856A8CF0")]
	private void KGHBOJHJFHP(IEnumerable<long> MEEOECICPOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x1037CA0", Offset = "0x1036EA0", VA = "0x181037CA0")]
	private void MGJPAGJOJPJ(KeepsakeGlobalConfigDTO CCFKIKNCBKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x56A6610", Offset = "0x56A5810", VA = "0x1856A6610")]
	private bool HIFDPHJJKGI(DLHAJNJECEF HKACKNCFAEK, out Guid ALBIBHLCFIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x56AAD20", Offset = "0x56A9F20", VA = "0x1856AAD20")]
	private bool NJJJPHLMOAI(out Guid ALBIBHLCFIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x56A43E0", Offset = "0x56A35E0", VA = "0x1856A43E0")]
	private bool FBDOENPGCCG(Guid CKCOJKGAGID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x56A2510", Offset = "0x56A1710", VA = "0x1856A2510")]
	private IEnumerable<Guid> CMJHFEPIJID()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x56A6ED0", Offset = "0x56A60D0", VA = "0x1856A6ED0")]
	private IEnumerable<KeepsakeInstanceDTO> IHOKLDOEAOH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x56A1CB0", Offset = "0x56A0EB0", VA = "0x1856A1CB0")]
	private void BEPKEIAPDEC(Guid CKCOJKGAGID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x56A2CE0", Offset = "0x56A1EE0", VA = "0x1856A2CE0")]
	private bool DKNLOOPHEMK(Guid CKCOJKGAGID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x56A3BA0", Offset = "0x56A2DA0", VA = "0x1856A3BA0")]
	private void EFLIMHNPAPM(Guid CKCOJKGAGID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x56A3460", Offset = "0x56A2660", VA = "0x1856A3460")]
	private void DPEBKMMAMHG(DLHAJNJECEF LPDDCEMOGCP, int ICDHJMDKDKK, ref Dictionary<DLHAJNJECEF, int> BPKBCINLFGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x56AC510", Offset = "0x56AB710", VA = "0x1856AC510")]
	private int PIFIMDFFKLE(DLHAJNJECEF HKACKNCFAEK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x56A6450", Offset = "0x56A5650", VA = "0x1856A6450")]
	private void HBJKEAIBDGP(KeepsakeInstanceDTO NBIHEEINOGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x56A83B0", Offset = "0x56A75B0", VA = "0x1856A83B0")]
	private void JPEPLKMGLCO(KeepsakeInstanceDTO NBIHEEINOGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x56A2670", Offset = "0x56A1870", VA = "0x1856A2670")]
	private void CMMIKMFIEDA(Guid CKCOJKGAGID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x56AAE90", Offset = "0x56AA090", VA = "0x1856AAE90")]
	private void NPDMGEHENPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x56A7E70", Offset = "0x56A7070", VA = "0x1856A7E70")]
	private void JFGHCPLNNIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x56A4310", Offset = "0x56A3510", VA = "0x1856A4310")]
	private void EJPAHNBHJFL(CONHHIMJCNJ GEMCJBEAJOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x56A15F0", Offset = "0x56A07F0", VA = "0x1856A15F0")]
	private void BAKEGDHAJIG(DJBONIOOOPJ.OEGDECCHPMH PPNJOAJJOFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x56A8C90", Offset = "0x56A7E90", VA = "0x1856A8C90")]
	private void KGFMOLOKCCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x56A4750", Offset = "0x56A3950", VA = "0x1856A4750")]
	private void FMAECINDPOM(float CDJLGECOGOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x56A5C00", Offset = "0x56A4E00", VA = "0x1856A5C00")]
	private void GEOFOMFFPHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x56AB220", Offset = "0x56AA420", VA = "0x1856AB220")]
	private bool ODGNOCFIJII(Guid CKCOJKGAGID, out string GLJBAEOKNDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x56A9FE0", Offset = "0x56A91E0", VA = "0x1856A9FE0")]
	private bool LOBIDANICDF(Guid CKCOJKGAGID, out KeepsakeCategoryConfigDTO LPDDCEMOGCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x56AB800", Offset = "0x56AAA00", VA = "0x1856AB800")]
	private void OJFIHLGFOLO(string LOACANDAGDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x56A8A10", Offset = "0x56A7C10", VA = "0x1856A8A10")]
	private bool KBMHOKFMMFA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x56A3180", Offset = "0x56A2380", VA = "0x1856A3180")]
	private IEnumerable<long> DOLFODOEFPL(IEnumerable<KeepsakeRoomDTO> CJIHOEBMMHP, IEnumerable<KeepsakeRoomListDTO> CNBKMNAGAHD, long NMDBCDIOHJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x56A1650", Offset = "0x56A0850", VA = "0x1856A1650")]
	private bool BAPNNEBHKOE(Guid CKCOJKGAGID, out string BMNKLBFFLLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x56A2440", Offset = "0x56A1640", VA = "0x1856A2440", Slot = "47")]
	public string CLBLOLMEDOI(GMCHEMCNICO AGPFNFFABML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x56A6A30", Offset = "0x56A5C30", VA = "0x1856A6A30", Slot = "49")]
	public string IHDDDDJEKBG(GMCHEMCNICO AGPFNFFABML, long HBFBDJIOFCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x56AAC00", Offset = "0x56A9E00", VA = "0x1856AAC00", Slot = "48")]
	public string NBDIBBFAHPG(GMCHEMCNICO AGPFNFFABML, int NPLDKLOKFAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x56AC6E0", Offset = "0x56AB8E0", VA = "0x1856AC6E0")]
	private void PJFCGEFNDNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x56A9D70", Offset = "0x56A8F70", VA = "0x1856A9D70")]
	private void LJCFJIIGNIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x56A9BA0", Offset = "0x56A8DA0", VA = "0x1856A9BA0")]
	private GMCHEMCNICO LBBBAGGLABP(BMGHOIIKLGM NKFLICLIKOA)
	{
		return default(GMCHEMCNICO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x56A2040", Offset = "0x56A1240", VA = "0x1856A2040")]
	private GMCHEMCNICO BNOHCOCPGJA(BMGHOIIKLGM NKFLICLIKOA)
	{
		return default(GMCHEMCNICO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x56AB8E0", Offset = "0x56AAAE0", VA = "0x1856AB8E0")]
	internal static string OJLOAMJDDBF(PKJDOKODLMG GGGBLCGFJEB, string MDALAFNGNBD, bool AJEPKPEPHPP, int FCMBMHNPPMK, int GBDHFFDHIJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x56A3540", Offset = "0x56A2740", VA = "0x1856A3540", Slot = "52")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x56A6160", Offset = "0x56A5360", VA = "0x1856A6160")]
	private FGEDLIOJPHD GJEBFOKAHJP(CPCMBHAGMBL IGDKNPAEELF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x56A2060", Offset = "0x56A1260", VA = "0x1856A2060")]
	private PFLLMDOGJCE BPOLODEHMFI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x56A9810", Offset = "0x56A8A10", VA = "0x1856A9810")]
	private Task KNKGFFDMGAD(LPHBDDFNIEM LCGFCGNMPHN, CancellationToken MELLLMEKJLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x56ABB60", Offset = "0x56AAD60", VA = "0x1856ABB60")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(AFCKIAHBOOM))]
	private Task OMMBJDPMJNO(LPHBDDFNIEM LCGFCGNMPHN, CancellationToken MELLLMEKJLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x56A3D40", Offset = "0x56A2F40", VA = "0x1856A3D40")]
	private Task EGBHDCJEJBE(LPHBDDFNIEM LCGFCGNMPHN, CancellationToken MELLLMEKJLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x56A8DF0", Offset = "0x56A7FF0", VA = "0x1856A8DF0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(IGCCFNHJHDE))]
	private Task KIMBDLOJPGD(string JPOEHOENKPI, TimeSpan GNBBILJLFDG, CancellationToken MELLLMEKJLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x3F81910", Offset = "0x3F80B10", VA = "0x183F81910")]
	[CompilerGenerated]
	private void KLCFJMFKELB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x56A4390", Offset = "0x56A3590", VA = "0x1856A4390")]
	[CompilerGenerated]
	private void ELMCNIJFJCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x56A9EF0", Offset = "0x56A90F0", VA = "0x1856A9EF0")]
	[CompilerGenerated]
	private bool LLEKPCJMLPD(KeepsakeInstanceDTO JPBGAMDOIJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x56A3DE0", Offset = "0x56A2FE0", VA = "0x1856A3DE0")]
	[CompilerGenerated]
	private OOMFLHAHLDK<Dictionary<DLHAJNJECEF, int>> EGNJJHFGFKB(Dictionary<Guid, DLHAJNJECEF> FAGOBKBPJPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x56A4DE0", Offset = "0x56A3FE0", VA = "0x1856A4DE0")]
	[CompilerGenerated]
	private OOMFLHAHLDK<Dictionary<DLHAJNJECEF, int>> FNIBDIOIHJD(Dictionary<Guid, DLHAJNJECEF> FAGOBKBPJPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x56A68C0", Offset = "0x56A5AC0", VA = "0x1856A68C0")]
	[CompilerGenerated]
	private bool HNMKFMJDFPB(KeepsakeRoomListDTO JPBGAMDOIJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x56AA1B0", Offset = "0x56A93B0", VA = "0x1856AA1B0")]
	[CompilerGenerated]
	private bool LOGHHNNJIEF(KeepsakeInstanceDTO JPBGAMDOIJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x56A7E90", Offset = "0x56A7090", VA = "0x1856A7E90")]
	[CompilerGenerated]
	private void JJACGIGPKEN(Tuple<KeepsakeRoomInstancesDTO, IReadOnlyDictionary<DLHAJNJECEF, KeepsakeCategoryConfigDTO>, KeepsakeGlobalConfigDTO> BCKMMLMPPAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x56AB7A0", Offset = "0x56AA9A0", VA = "0x1856AB7A0")]
	[CompilerGenerated]
	private void OGIPNIKBBMH(string BMNKLBFFLLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x56A8180", Offset = "0x56A7380", VA = "0x1856A8180")]
	[CompilerGenerated]
	private Task JPCNMNMDHBF(CancellationToken LEAPIFKBGFG)
	{
		return null;
	}
}
namespace RecRoom.Keepsakes
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public struct KeepsakeTheme
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public string ThemeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public int ThemeOrder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		[Header("Pickup")]
		public string PickupName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public GameObject PickupPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public AudioClip PickupSfx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public float PickupSfxVolume;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		[Header("Colors")]
		public bool UseCustomColors;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public Color BeamColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public Color BaseColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		[Header("Looping Sound")]
		public AudioClip LoopingSfx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
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
