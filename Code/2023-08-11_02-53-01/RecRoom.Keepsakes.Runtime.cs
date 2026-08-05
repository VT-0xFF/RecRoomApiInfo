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
	public class KeepsakesConfig : ScriptableObject, PCOHLDANFPN<KeepsakesConfig.KeepsakesOptions>
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		public class KeepsakesOptions
		{
			[Cpp2IlInjected.Token(Token = "0x2000004")]
			[CompilerGenerated]
			private sealed class HCAPLACDKIG
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000003")]
				public string themeId;

				[Cpp2IlInjected.Token(Token = "0x6000005")]
				[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
				public HCAPLACDKIG()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000006")]
				[Cpp2IlInjected.Address(RVA = "0x567CAF0", Offset = "0x567B2F0", VA = "0x18567CAF0")]
				internal bool CJEEKNOMNPG(KeepsakeTheme x)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000007")]
				[Cpp2IlInjected.Address(RVA = "0x567CAF0", Offset = "0x567B2F0", VA = "0x18567CAF0")]
				internal bool GAOLAPFABAC(KeepsakeTheme x)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000002")]
			[SerializeField]
			private KeepsakeTheme[] themes;

			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x567D540", Offset = "0x567BD40", VA = "0x18567D540")]
			public bool JJMJLBJFDLG(string FDPJBFKADEJ, out KeepsakeTheme PNIIBDNJFNO)
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
			[Cpp2IlInjected.Address(RVA = "0x7DFD30", Offset = "0x7DE530", VA = "0x1807DFD30", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x567D4C0", Offset = "0x567BCC0", VA = "0x18567D4C0")]
		[NFOBBCLLFPP(BGPNPCEMJLD.GameOnly)]
		private static void EBMOAACPAFK(LIFDIPFHEEA KEMGJJIKGPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9176C0", Offset = "0x915EC0", VA = "0x1809176C0")]
		public KeepsakesConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class GDGGEDNFIBP : IComparer<HILCHEIPPND>
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class HKLGBAEMDKN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public HILCHEIPPND x;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public HILCHEIPPND y;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public HKLGBAEMDKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xA3DC00", Offset = "0xA3C400", VA = "0x180A3DC00")]
		internal bool IAECNFMHIME(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x11B76B0", Offset = "0x11B5EB0", VA = "0x1811B76B0")]
		internal bool PAIHBAOEFID(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xA3DC00", Offset = "0xA3C400", VA = "0x180A3DC00")]
		internal bool LOFJJEJMIEB(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x11B76B0", Offset = "0x11B5EB0", VA = "0x1811B76B0")]
		internal bool FNIFAICAGFD(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<KeepsakeCategoryThemePair> CKJMKBNPICB;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x8BA230", Offset = "0x8B8A30", VA = "0x1808BA230")]
	public GDGGEDNFIBP(List<KeepsakeCategoryThemePair> OGKONHKKBEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x567C810", Offset = "0x567B010", VA = "0x18567C810", Slot = "4")]
	public int Compare(HILCHEIPPND FBGKLELIKCG, HILCHEIPPND LFJEFFKGLOE)
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
		public HILCHEIPPND KeepsakeCategory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public KeepsakeTheme KeepsakeTheme;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[ACFLGLMHDEN]
public class OGBDDBIJKLE : FDJMJPOBBAH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class KBMIFCJDFPC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public OGBDDBIJKLE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public HILCHEIPPND keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public KBMIFCJDFPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x567D2C0", Offset = "0x567BAC0", VA = "0x18567D2C0")]
		internal JJMNNLLBAJO<Guid> LILGMGOHMLC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x567D400", Offset = "0x567BC00", VA = "0x18567D400")]
		internal void PKPMIMNBEDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x567CE00", Offset = "0x567B600", VA = "0x18567CE00")]
		internal void EMHGOIMEDJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x567CE60", Offset = "0x567B660", VA = "0x18567CE60")]
		internal void JACOOANEMFB(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x567CDD0", Offset = "0x567B5D0", VA = "0x18567CDD0")]
		internal void BHMPCOMMNKL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class PNBJFKOBLDH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public OGBDDBIJKLE <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public PNBJFKOBLDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x568C360", Offset = "0x568AB60", VA = "0x18568C360")]
		internal void LDKOMHALOEF(HAPMGBGMADL response)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x568C300", Offset = "0x568AB00", VA = "0x18568C300")]
		internal void DHPOKPIFCKP(string error)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class HAJDNJCDCOA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public KeepsakeTheme theme;

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public HAJDNJCDCOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x567CAC0", Offset = "0x567B2C0", VA = "0x18567CAC0")]
		internal bool AJAKBDONMOA(KeepsakeCategoryThemePair categoryThemePair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class BNDMIJGFEKP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public OGBDDBIJKLE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public long progressionEventId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public HILCHEIPPND? keepsakeCategory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public BNDMIJGFEKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x567BB80", Offset = "0x567A380", VA = "0x18567BB80")]
		internal void AIKJKBDKCOI(KeepsakeProgressionEventInstancesDTO result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x567B560", Offset = "0x5679D60", VA = "0x18567B560")]
		internal void CPKDKFOMJLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x567BC00", Offset = "0x567A400", VA = "0x18567BC00")]
		internal JJMNNLLBAJO<IEnumerable<Guid>> JHCIBEONLLM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x3CAA290", Offset = "0x3CA8A90", VA = "0x183CAA290")]
		internal bool HDAOAENADME(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class CMMKDDMHHFG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public KeepsakeRoomInstanceIdsDTO instancesInRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public BNDMIJGFEKP CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public CMMKDDMHHFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x567C270", Offset = "0x567AA70", VA = "0x18567C270")]
		internal JJMNNLLBAJO<IEnumerable<Guid>> KCNGPHMANNF(KeepsakeRoomInstancesDTO roomInstancesDTO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class NGLHPCNBANO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public KeepsakeRoomInstancesDTO roomInstancesDTO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public CMMKDDMHHFG CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public NGLHPCNBANO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x567DA70", Offset = "0x567C270", VA = "0x18567DA70")]
		internal bool JOAMBBCNDIM(Guid instanceId)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class BALJOJKACJC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Guid instanceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public NGLHPCNBANO CS$<>8__locals3;

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public BALJOJKACJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x567BA80", Offset = "0x567A280", VA = "0x18567BA80")]
		internal bool MHINPIDBBJD(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class JHPJNKLCMIL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public OGBDDBIJKLE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public JHPJNKLCMIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x567CC60", Offset = "0x567B460", VA = "0x18567CC60")]
		internal JJMNNLLBAJO<IEnumerable<Guid>> GNNKGGPFLCP(IEnumerable<Guid> instanceIds)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x567CC40", Offset = "0x567B440", VA = "0x18567CC40")]
		internal bool CIOFLGMJHCD(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class ALJGJLFMBCF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public OGBDDBIJKLE <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public ALJGJLFMBCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x567B4E0", Offset = "0x5679CE0", VA = "0x18567B4E0")]
		internal void BANOKNMEAOO(KeepsakeProgressionEventInstancesDTO result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x567B560", Offset = "0x5679D60", VA = "0x18567B560")]
		internal void CKDLBOEBBEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x567B590", Offset = "0x5679D90", VA = "0x18567B590")]
		internal JJMNNLLBAJO<Dictionary<Guid, HILCHEIPPND>> EJDPFDDBLDB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x3CAA290", Offset = "0x3CA8A90", VA = "0x183CAA290")]
		internal bool PHBBGFKKAFP(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class BPIKKPENMMI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public KeepsakeRoomInstanceIdsDTO instancesInRoom;

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public BPIKKPENMMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x567C0A0", Offset = "0x567A8A0", VA = "0x18567C0A0")]
		internal JJMNNLLBAJO<Dictionary<Guid, HILCHEIPPND>> KFDFBFDPKKI(KeepsakeRoomInstancesDTO roomInstancesDTO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class DLJDODHKPKI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public KeepsakeRoomInstancesDTO roomInstancesDTO;

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public DLJDODHKPKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x567C540", Offset = "0x567AD40", VA = "0x18567C540")]
		internal bool IDEJAGGGNDJ(Guid instanceId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x567C3C0", Offset = "0x567ABC0", VA = "0x18567C3C0")]
		internal KeyValuePair<Guid, HILCHEIPPND> DAHNDGEGJMA(Guid instanceId)
		{
			return default(KeyValuePair<Guid, HILCHEIPPND>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class BPEFCFEKDIE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public Guid instanceId;

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public BPEFCFEKDIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x567C000", Offset = "0x567A800", VA = "0x18567C000")]
		internal bool HHBPDMPHCNB(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class MKIKGAMBNJC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public Guid instanceId;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public MKIKGAMBNJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x567D9D0", Offset = "0x567C1D0", VA = "0x18567D9D0")]
		internal bool ECNBLHGDEPB(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class PCHODHCDHIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public OGBDDBIJKLE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public PCHODHCDHIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x568C0E0", Offset = "0x568A8E0", VA = "0x18568C0E0")]
		internal JJMNNLLBAJO<Dictionary<Guid, HILCHEIPPND>> DFPDAFFCNOD(Dictionary<Guid, HILCHEIPPND> instanceIdsAndCategories)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x567CC40", Offset = "0x567B440", VA = "0x18567CC40")]
		internal bool DJADNGGCDNG(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class FJJHLHKFINA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public KeepsakeRoomInstanceIdsDTO collectedInstanceIds;

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public FJJHLHKFINA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x567C630", Offset = "0x567AE30", VA = "0x18567C630")]
		internal bool NCMGOHFAAKF(KeyValuePair<Guid, HILCHEIPPND> idCategoryPair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class NJCBJMCPLEK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public Dictionary<Guid, HILCHEIPPND> instanceIdsAndCategories;

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public NJCBJMCPLEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x567DBA0", Offset = "0x567C3A0", VA = "0x18567DBA0")]
		internal KeyValuePair<HILCHEIPPND, int> AENDPIGOLLB(HILCHEIPPND category)
		{
			return default(KeyValuePair<HILCHEIPPND, int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class CDCHMPNDGDF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public HILCHEIPPND category;

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public CDCHMPNDGDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x11295D0", Offset = "0x1127DD0", VA = "0x1811295D0")]
		internal bool FGKMJJNFJAB(HILCHEIPPND instanceCategory)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class GCBDLPAOCAF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public Dictionary<Guid, HILCHEIPPND> instanceIdsAndCategories;

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public GCBDLPAOCAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x567C6B0", Offset = "0x567AEB0", VA = "0x18567C6B0")]
		internal KeyValuePair<HILCHEIPPND, int> HKPCOEEAPMG(HILCHEIPPND category)
		{
			return default(KeyValuePair<HILCHEIPPND, int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class JHJHKADFOMP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public HILCHEIPPND category;

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public JHJHKADFOMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x11295D0", Offset = "0x1127DD0", VA = "0x1811295D0")]
		internal bool KJDENILOMBO(HILCHEIPPND instanceCategory)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class LOHEFHECJAC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public OGBDDBIJKLE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public Func<KeepsakeRoomDTO, bool> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public LOHEFHECJAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x567D730", Offset = "0x567BF30", VA = "0x18567D730")]
		internal bool EABJBPEBDIH(DateTime nowUtc, DateTime eventStartTime, int roomOrder, TimeSpan unlockStartOffset, TimeSpan unlockInterval, int unlockBatchSize)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x567D810", Offset = "0x567C010", VA = "0x18567D810")]
		internal bool GFLPNJPBKEC(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x567D710", Offset = "0x567BF10", VA = "0x18567D710")]
		internal bool HKFHIHPKDMN(KeepsakeRoomDTO r)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x567D710", Offset = "0x567BF10", VA = "0x18567D710")]
		internal bool DNGLKPGOLOA(KeepsakeRoomDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class KPADHKKLOGP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public KPADHKKLOGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0xA345C0", Offset = "0xA32DC0", VA = "0x180A345C0")]
		internal bool PEFANPBKCPF(KeepsakeRoomListDTO roomList)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class ONLBMPDHGKH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public Func<KeepsakeRoomDTO, bool> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public ONLBMPDHGKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x568C010", Offset = "0x568A810", VA = "0x18568C010")]
		internal bool KFKPGNDPKEP(KeepsakeRoomListDTO roomList)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0xADE580", Offset = "0xADCD80", VA = "0x180ADE580")]
		internal bool MKOIDNMMCJI(KeepsakeRoomDTO room)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class MEDAEJGEPHL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public MEDAEJGEPHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x567D960", Offset = "0x567C160", VA = "0x18567D960")]
		internal bool NFJHOBCFGFC(KeepsakeRoomListDTO i)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class AIGLGOJJAEE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public AIGLGOJJAEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0xA345C0", Offset = "0xA32DC0", VA = "0x180A345C0")]
		internal bool GDFNJOFJIOE(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class KCPGBIJNAIL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public Guid keepsakeInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public KCPGBIJNAIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x567D430", Offset = "0x567BC30", VA = "0x18567D430")]
		internal bool BIJHLKHODGJ(KeyValuePair<Guid, KeepsakeInstanceDTO> instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class OMEABNJKEGJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public HILCHEIPPND keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public OMEABNJKEGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0xACEB50", Offset = "0xACD350", VA = "0x180ACEB50")]
		internal bool JPEBMCAAJNB(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class JHHKKKHDFPI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public Guid keepsakeInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public JHHKKKHDFPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x567CBB0", Offset = "0x567B3B0", VA = "0x18567CBB0")]
		internal bool JGEECDIGFID(KeyValuePair<Guid, KeepsakeInstanceDTO> instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class NOLKKEJDNOF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public HILCHEIPPND keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public NOLKKEJDNOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x567E230", Offset = "0x567CA30", VA = "0x18567E230")]
		internal bool JIICDOFCKBM(KeyValuePair<Guid, HILCHEIPPND> x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class HKIEJEODBLL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public HILCHEIPPND newKeepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public HKIEJEODBLL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0xACEB50", Offset = "0xACD350", VA = "0x180ACEB50")]
		internal bool BDJLIMPMLOB(KeepsakeInstanceDTO instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class IDHHPKFILIP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public long currentRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public long? currentSubRoomId;

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public IDHHPKFILIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x567CB20", Offset = "0x567B320", VA = "0x18567CB20")]
		internal bool FBDBJMKOOJI(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class BNLJKAJJGHI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public IEnumerable<KeepsakeRoomListDTO> roomList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public BNLJKAJJGHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x567BF10", Offset = "0x567A710", VA = "0x18567BF10")]
		internal bool APBJGJDNFNC(KeepsakeRoomDTO room)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class MAFGIBFELNF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public KeepsakeRoomDTO room;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public BNLJKAJJGHI CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public MAFGIBFELNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x567D8E0", Offset = "0x567C0E0", VA = "0x18567D8E0")]
		internal bool MHINILLCJAM(KeepsakeRoomListDTO roomListDto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class NKPLMIBBGFC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public ALNDGPDOBOK args;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public OGBDDBIJKLE <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public NKPLMIBBGFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x567DD00", Offset = "0x567C500", VA = "0x18567DD00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class AOAHGGFPHHC : IAsyncStateMachine
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
		public OGBDDBIJKLE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public AOAHGGFPHHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x567B890", Offset = "0x567A090", VA = "0x18567B890", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly DateTime CAPHNFPCDIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly CBNFKMOHMEN POAOLOFBHAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly KCEIPHEAPMO KLDDIBBLMBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly FBPCDNMBCFF FHDKABBGAIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly AFPANMHMIBP HBOOKDCHNPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly PDMJIAEOMIP KPGFDADNAJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly HGIGNMLBMMN KEHAKPOPKCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly KGKEADDOPJG IELDLCCFOIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly FMDMEJLHLEH NDDDHNPEAPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly LHKMHCLDMMO FLOCOIABGEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly AIAAPIDLIMK COHHEJCCBKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly MJDHOKEBFAF MLLGJDKHIOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly OJPFDFHPHJI BLLPBMLGGCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly HFOEOKNEKGK OGNHKJHBGCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly FIHDKPEAOBM AHBAIFGILLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly FNFJKICMOJE IMLNKEDJGBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly PCOHLDANFPN<KeepsakesConfig.KeepsakesOptions> LFCKIHDGDIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly LDOHJBCKEED FMKDNPLHJLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly Dictionary<Guid, KeepsakeInstanceDTO> LIOENAKHOAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly HashSet<Guid> APAOKHDFGMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly HashSet<long> ABNJAJHNPLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private Dictionary<HILCHEIPPND, int> KDMJKMLKCKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly HashSet<Guid> LNHFOMIIEKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly IDisposable JGFEOAJOEAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private Task DHMFCKPIBIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private JJMNNLLBAJO<Guid> BGALHPHDEOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private long? NLJCIDFBEGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private KeepsakeProgressionEventInstancesDTO GKKCMMFMEKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private JJMNNLLBAJO<KeepsakeProgressionEventInstancesDTO> MOIHJKMCBOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private IReadOnlyDictionary<HILCHEIPPND, KeepsakeCategoryConfigDTO> EBKDKLMHPED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private KeepsakeGlobalConfigDTO BPEMODHJOCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private HashSet<long> IOBHDPMBEMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private HashSet<long> IKGMBLNFMAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private List<KeepsakeRoomListDTO> PIOEKGJNBJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private List<KeepsakeRoomListDTO> PKNDDOCKFDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private List<KeepsakeRoomListDTO> IELNHKOBFCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private Dictionary<long, string> FKFMLDEJPPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private Dictionary<long, string> GAENJHIIBIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private Dictionary<long, DateTime> DHFFMAADJFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private Dictionary<long, List<KeepsakeRoomDTO>> MCDEBKMDJFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private Dictionary<long, List<KeepsakeRoomDTO>> JKELNLFOHBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private Dictionary<long, long> JJAMCKIGLAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly List<string> BDBFPGJCEAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private DateTime INIIBIGOJMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly IDisposable EBIPINCKLOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private Dictionary<Guid, HILCHEIPPND> MDBNBDOGFAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private Dictionary<HILCHEIPPND, int> GHLIPJCCLOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private List<KeepsakeCategoryThemePair> OGKONHKKBEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private GDGGEDNFIBP KBNGLPPNJGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private bool IEDCBHPFAEH;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool GGNNKFIFPCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7ECD80", Offset = "0x7EB580", VA = "0x1807ECD80", Slot = "53")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7ECD90", Offset = "0x7EB590", VA = "0x1807ECD90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool BPOPBHDFEFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x56832B0", Offset = "0x5681AB0", VA = "0x1856832B0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool KNGCEHKAKAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x5681FB0", Offset = "0x56807B0", VA = "0x185681FB0", Slot = "36")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private long IGIGINIIIJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5682770", Offset = "0x5680F70", VA = "0x185682770")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private long? LLGIHCIFIIK
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5683210", Offset = "0x5681A10", VA = "0x185683210")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private bool JDEPCHCMOCD
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x567F460", Offset = "0x567DC60", VA = "0x18567F460")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public IReadOnlyList<KeepsakeRoomListDTO> DIGPGEFBFBA
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xD72C30", Offset = "0xD71430", VA = "0x180D72C30", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IReadOnlyList<KeepsakeRoomListDTO> IADAOGOLAED
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xCE9AF0", Offset = "0xCE82F0", VA = "0x180CE9AF0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public IReadOnlyList<KeepsakeRoomListDTO> PEAEAHGPEEH
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x976770", Offset = "0x974F70", VA = "0x180976770", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public IReadOnlyDictionary<long, string> OJBJBAFALPO
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xC61580", Offset = "0xC5FD80", VA = "0x180C61580", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	internal bool KECNBCJOAFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xD72C40", Offset = "0xD71440", VA = "0x180D72C40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Guid?> LFGGGLCBHFN
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5686320", Offset = "0x5684B20", VA = "0x185686320", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5685C10", Offset = "0x5684410", VA = "0x185685C10", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action NBONNKJHDJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x56826D0", Offset = "0x5680ED0", VA = "0x1856826D0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x567FD60", Offset = "0x567E560", VA = "0x18567FD60", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action ALNMAKCNKJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x56851C0", Offset = "0x56839C0", VA = "0x1856851C0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5687950", Offset = "0x5686150", VA = "0x185687950", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x568ACF0", Offset = "0x56894F0", VA = "0x18568ACF0")]
	[Preserve]
	internal OGBDDBIJKLE([NotNull][JHPEMCNOMHI(null)] CBNFKMOHMEN POAOLOFBHAM, [NotNull][JHPEMCNOMHI(null)] FELKPDCPELP MNDDFOKLOLL, [NotNull][JHPEMCNOMHI(null)] KCEIPHEAPMO KLDDIBBLMBB, [NotNull][JHPEMCNOMHI(null)] FBPCDNMBCFF FHDKABBGAIH, [NotNull][JHPEMCNOMHI(null)] AFPANMHMIBP HBOOKDCHNPD, [NotNull][JHPEMCNOMHI(null)] PDMJIAEOMIP KPGFDADNAJA, [NotNull][JHPEMCNOMHI(null)] HGIGNMLBMMN KEHAKPOPKCM, [NotNull][JHPEMCNOMHI(null)] KGKEADDOPJG IELDLCCFOIL, [NotNull][JHPEMCNOMHI(null)] FMDMEJLHLEH NDDDHNPEAPJ, [NotNull][JHPEMCNOMHI(null)] PCKPOPMIKKL CJNBDILJMJA, [NotNull][JHPEMCNOMHI(null)] LHKMHCLDMMO FLOCOIABGEF, [NotNull][JHPEMCNOMHI(null)] AIAAPIDLIMK COHHEJCCBKO, [NotNull][JHPEMCNOMHI(null)] MJDHOKEBFAF MLLGJDKHIOP, [NotNull][JHPEMCNOMHI(null)] OJPFDFHPHJI BLLPBMLGGCH, [NotNull][JHPEMCNOMHI(null)] HFOEOKNEKGK OGNHKJHBGCN, [NotNull][JHPEMCNOMHI(null)] FIHDKPEAOBM AHBAIFGILLP, [NotNull][JHPEMCNOMHI(null)] FNFJKICMOJE IMLNKEDJGBB, [NotNull][JHPEMCNOMHI(null)] PCOHLDANFPN<KeepsakesConfig.KeepsakesOptions> LFCKIHDGDIE, [NotNull][JHPEMCNOMHI(null)] LDOHJBCKEED FMKDNPLHJLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x56894D0", Offset = "0x5687CD0", VA = "0x1856894D0", Slot = "15")]
	public bool OCMPNOAPKEN(List<string> OGBPPOFHCGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5688510", Offset = "0x5686D10", VA = "0x185688510", Slot = "16")]
	public JJMNNLLBAJO<Guid> NLDMCFBGICC(HILCHEIPPND OBPJKIHHCKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5685600", Offset = "0x5683E00", VA = "0x185685600", Slot = "17")]
	public GHJKEMFHLHG KKBBJGAHPIB(Guid LKGGLHIONPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x56863C0", Offset = "0x5684BC0", VA = "0x1856863C0", Slot = "18")]
	public GHJKEMFHLHG LIBAGKJAJAM(Guid LKGGLHIONPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5687450", Offset = "0x5685C50", VA = "0x185687450", Slot = "19")]
	public bool MCDGGKELPCP(Guid LKGGLHIONPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5682080", Offset = "0x5680880", VA = "0x185682080", Slot = "20")]
	public bool FNNBBLBFPKJ(Guid LKGGLHIONPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5683300", Offset = "0x5681B00", VA = "0x185683300")]
	public KeepsakeTheme IBLLKKOPOEK(Guid LKGGLHIONPO)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5684FF0", Offset = "0x56837F0", VA = "0x185684FF0")]
	public bool JGFJPIFJFME(HILCHEIPPND OBPJKIHHCKA, out KeepsakeTheme PNIIBDNJFNO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5682E60", Offset = "0x5681660", VA = "0x185682E60")]
	public List<KeepsakeTheme> HKKNNNOCDOB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x567FB30", Offset = "0x567E330", VA = "0x18567FB30")]
	public int BNAIBBDDMLH(HILCHEIPPND OBPJKIHHCKA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x567EAF0", Offset = "0x567D2F0", VA = "0x18567EAF0")]
	public HILCHEIPPND AGADEFFKNKG(Guid LKGGLHIONPO)
	{
		return default(HILCHEIPPND);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5680BE0", Offset = "0x567F3E0", VA = "0x185680BE0", Slot = "34")]
	public List<HILCHEIPPND> DLFBPJMLMDH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x568A180", Offset = "0x5688980", VA = "0x18568A180", Slot = "35")]
	public IComparer<HILCHEIPPND> PELNICIFEJE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5680D30", Offset = "0x567F530", VA = "0x185680D30", Slot = "32")]
	public string DMLBLCGPPOD(HILCHEIPPND OBPJKIHHCKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x567F4E0", Offset = "0x567DCE0", VA = "0x18567F4E0", Slot = "33")]
	public string BKKGMHHJLKL(HILCHEIPPND OBPJKIHHCKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5685F20", Offset = "0x5684720", VA = "0x185685F20", Slot = "21")]
	public bool LCCANNMFLCB(Guid LKGGLHIONPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5681360", Offset = "0x567FB60", VA = "0x185681360", Slot = "22")]
	public void EDJCILLCNFB(Guid LKGGLHIONPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x56870C0", Offset = "0x56858C0", VA = "0x1856870C0", Slot = "23")]
	public void LPKDMFACAPF(HILCHEIPPND OBPJKIHHCKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x567F130", Offset = "0x567D930", VA = "0x18567F130", Slot = "24")]
	public void BBKCEBEJPBH(Guid LKGGLHIONPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5687D20", Offset = "0x5686520", VA = "0x185687D20", Slot = "25")]
	public int NIELHBNOBHH()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x56834A0", Offset = "0x5681CA0", VA = "0x1856834A0", Slot = "31")]
	public JJMNNLLBAJO<IEnumerable<Guid>> IDDBHCIPMGC(long AFGKPOPONBN, long MLFPNCDFMFB, HILCHEIPPND? OBPJKIHHCKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x568AA70", Offset = "0x5689270", VA = "0x18568AA70", Slot = "30")]
	public JJMNNLLBAJO<IEnumerable<Guid>> PMHJOPAAKFO(long AFGKPOPONBN, long MLFPNCDFMFB, HILCHEIPPND? OBPJKIHHCKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5689D80", Offset = "0x5688580", VA = "0x185689D80", Slot = "54")]
	public JJMNNLLBAJO<Dictionary<Guid, HILCHEIPPND>> OMEOEEEGHCD(long AFGKPOPONBN, long MLFPNCDFMFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5685A80", Offset = "0x5684280", VA = "0x185685A80", Slot = "55")]
	public JJMNNLLBAJO<Dictionary<Guid, HILCHEIPPND>> KNHICJLEPBF(long AFGKPOPONBN, long MLFPNCDFMFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5687190", Offset = "0x5685990", VA = "0x185687190", Slot = "26")]
	public JJMNNLLBAJO<int> LPNMNIHLGNP(long AFGKPOPONBN, long MLFPNCDFMFB, HILCHEIPPND? OBPJKIHHCKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x56838F0", Offset = "0x56820F0", VA = "0x1856838F0", Slot = "27")]
	public JJMNNLLBAJO<int> IHAJOMBLKLM(long AFGKPOPONBN, long MLFPNCDFMFB, HILCHEIPPND? OBPJKIHHCKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5681AE0", Offset = "0x56802E0", VA = "0x185681AE0", Slot = "28")]
	public JJMNNLLBAJO<Dictionary<HILCHEIPPND, int>> FAPDJEPEIIA(long AFGKPOPONBN, long MLFPNCDFMFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x567FC90", Offset = "0x567E490", VA = "0x18567FC90", Slot = "29")]
	public JJMNNLLBAJO<Dictionary<HILCHEIPPND, int>> BOAPCOOHPJO(long AFGKPOPONBN, long MLFPNCDFMFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x5683890", Offset = "0x5682090", VA = "0x185683890", Slot = "37")]
	public bool IEDNGAJCICP(long AFGKPOPONBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x56855A0", Offset = "0x5683DA0", VA = "0x1856855A0", Slot = "56")]
	public bool KIDKNCLOKJK(long AFGKPOPONBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x5680420", Offset = "0x567EC20", VA = "0x185680420", Slot = "38")]
	public bool CLJFDKDCMJK(long AFGKPOPONBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x56899C0", Offset = "0x56881C0", VA = "0x1856899C0", Slot = "57")]
	public bool OKFNBCICJHC(long AFGKPOPONBN, out EKFLAMAKKCI IACLMJOMGHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x5688180", Offset = "0x5686980", VA = "0x185688180", Slot = "39")]
	public bool NJHELEGOLNA(long LNJPMMGCLEE, out DateTime PKGOOCDADMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x567E490", Offset = "0x567CC90", VA = "0x18567E490", Slot = "40")]
	public long ADMHMPACKDB(long LNJPMMGCLEE)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x567F010", Offset = "0x567D810", VA = "0x18567F010", Slot = "41")]
	public long ANENOMIKNLO(long AFGKPOPONBN)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x5685880", Offset = "0x5684080", VA = "0x185685880", Slot = "42")]
	public int KMEKFEBOOGJ(long LNJPMMGCLEE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x56854B0", Offset = "0x5683CB0", VA = "0x1856854B0", Slot = "43")]
	public bool KDCIEDNCGPH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x5684AC0", Offset = "0x56832C0", VA = "0x185684AC0", Slot = "44")]
	public bool INGKGCCKLJN(long LNJPMMGCLEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x56897E0", Offset = "0x5687FE0", VA = "0x1856897E0", Slot = "45")]
	public IEnumerable<long> OELMCJDHFHC(long LNJPMMGCLEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x5682BD0", Offset = "0x56813D0", VA = "0x185682BD0", Slot = "46")]
	public int HIMHBPDHHFA(long LNJPMMGCLEE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x5686740", Offset = "0x5684F40", VA = "0x185686740", Slot = "50")]
	public long LKNIDCPAOKO(long ELEBFIAHDOE)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x56890C0", Offset = "0x56878C0", VA = "0x1856890C0", Slot = "51")]
	public HILCHEIPPND OALDFDFAGON()
	{
		return default(HILCHEIPPND);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x56847D0", Offset = "0x5682FD0", VA = "0x1856847D0")]
	private bool ILONJNONNNM(Guid LKGGLHIONPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x567F650", Offset = "0x567DE50", VA = "0x18567F650")]
	private void BKLFHNAHFIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x567EC60", Offset = "0x567D460", VA = "0x18567EC60")]
	private HILCHEIPPND AKBDNFBFGEM()
	{
		return default(HILCHEIPPND);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x56804C0", Offset = "0x567ECC0", VA = "0x1856804C0")]
	private void DDMGIMPJJJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x5684910", Offset = "0x5683110", VA = "0x185684910")]
	private int IMBPOLFLDCG(KeepsakeRoomListDTO IODFMIHJCAM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x5685E50", Offset = "0x5684650", VA = "0x185685E50")]
	private int LBEEEJCALDG(DateTime AAGCOHONENF, DateTime HDDAJBCBODJ, TimeSpan OPLCIHPCILD, int FEEEOBKFJAA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x5684D80", Offset = "0x5683580", VA = "0x185684D80")]
	private void JBGPJBCEMLN(IEnumerable<KeepsakeInstanceDTO> LIOENAKHOAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x56882D0", Offset = "0x5686AD0", VA = "0x1856882D0")]
	private void NJHGOJFHBEK(IEnumerable<KeepsakeCollectionRecordDTO> LLINHLAGEKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x567E8C0", Offset = "0x567D0C0", VA = "0x18567E8C0")]
	private void AENBIJACABJ(IEnumerable<long> FFPEELNBBBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x1270770", Offset = "0x126EF70", VA = "0x181270770")]
	private void POMBPDDFPIM(KeepsakeGlobalConfigDTO BPEMODHJOCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x567FE00", Offset = "0x567E600", VA = "0x18567FE00")]
	private bool CDBAKOCCHLI(HILCHEIPPND OBPJKIHHCKA, out Guid MNDIBJPLFCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5686C70", Offset = "0x5685470", VA = "0x185686C70")]
	private bool LOKIACKIDPJ(out Guid MNDIBJPLFCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5681300", Offset = "0x567FB00", VA = "0x185681300")]
	private bool EAJKBLAIFIB(Guid LKGGLHIONPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x568A910", Offset = "0x5689110", VA = "0x18568A910")]
	private IEnumerable<Guid> PKNDBOMCEFG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5685260", Offset = "0x5683A60", VA = "0x185685260")]
	private IEnumerable<KeepsakeInstanceDTO> KALIKLNHAAN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5681F20", Offset = "0x5680720", VA = "0x185681F20")]
	private void FMJEIFPKHBN(Guid LKGGLHIONPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x567EF60", Offset = "0x567D760", VA = "0x18567EF60")]
	private bool AKKDODEHEFK(Guid LKGGLHIONPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5685CB0", Offset = "0x56844B0", VA = "0x185685CB0")]
	private void LBBGDHKLHHE(Guid LKGGLHIONPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x568AC10", Offset = "0x5689410", VA = "0x18568AC10")]
	private void PNMCNOHGLEB(HILCHEIPPND FDDLGGHNBKN, int ABFIBHILFJO, ref Dictionary<HILCHEIPPND, int> BNCCOHPBHBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x56879F0", Offset = "0x56861F0", VA = "0x1856879F0")]
	private int MNHBICCOBEM(HILCHEIPPND OBPJKIHHCKA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x56813D0", Offset = "0x567FBD0", VA = "0x1856813D0")]
	private void EMFECAPFDIE(KeepsakeInstanceDTO MNDFMHBLOOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5686A70", Offset = "0x5685270", VA = "0x185686A70")]
	private void LMKAHDJJOJC(KeepsakeInstanceDTO MNDFMHBLOOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5686D40", Offset = "0x5685540", VA = "0x185686D40")]
	private void LPFELNDGBJH(Guid LKGGLHIONPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x567F480", Offset = "0x567DC80", VA = "0x18567F480")]
	private void BHGHFDDKHLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x568A160", Offset = "0x5688960", VA = "0x18568A160")]
	private void OOEFEBKDIOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x56875A0", Offset = "0x5685DA0", VA = "0x1856875A0")]
	private void MIACKDOCCFL(COMIIGGELLE CAHMLNACFAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5689470", Offset = "0x5687C70", VA = "0x185689470")]
	private void OCANHFPEBDO(EFCCAKCFBAG.BACNMHFCIBD CEPDEAHBHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x5682670", Offset = "0x5680E70", VA = "0x185682670")]
	private void GDPNHBPDPAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5681590", Offset = "0x567FD90", VA = "0x185681590")]
	private void EPHAABFKCHK(float EHGCOGAGBHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x568A3B0", Offset = "0x5688BB0", VA = "0x18568A3B0")]
	private void PIPGOABBACJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x5687C90", Offset = "0x5686490", VA = "0x185687C90")]
	private bool NHFBJGJGGEB(Guid LKGGLHIONPO, out string CLBJOGHFEOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x567E920", Offset = "0x567D120", VA = "0x18567E920")]
	private bool AFPGDGCJJHJ(Guid LKGGLHIONPO, out KeepsakeCategoryConfigDTO FDDLGGHNBKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x567F380", Offset = "0x567DB80", VA = "0x18567F380")]
	private void BBOOOABJHEN(string AFMHCMJAMIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x5686200", Offset = "0x5684A00", VA = "0x185686200")]
	private bool LDJOBMHCIMO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x5687620", Offset = "0x5685E20", VA = "0x185687620")]
	private IEnumerable<long> MIHDMOOEFEC(IEnumerable<KeepsakeRoomDTO> MFGGIJOIECP, IEnumerable<KeepsakeRoomListDTO> FGDOFMDPIDN, long LNJPMMGCLEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x56820B0", Offset = "0x56808B0", VA = "0x1856820B0")]
	private bool GABADAGANIL(Guid LKGGLHIONPO, out string OABOGFOJNOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x56831B0", Offset = "0x56819B0", VA = "0x1856831B0", Slot = "47")]
	public string HKLGMAINFEL(NDHHBPMHGPL PBFJMMIHAAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x5688C70", Offset = "0x5687470", VA = "0x185688C70", Slot = "49")]
	public string OAJNBFDJGOM(NDHHBPMHGPL PBFJMMIHAAA, long AFGKPOPONBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5681E00", Offset = "0x5680600", VA = "0x185681E00", Slot = "48")]
	public string FFICIEEBKPP(NDHHBPMHGPL PBFJMMIHAAA, int CEMIGKDJPLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x5683A60", Offset = "0x5682260", VA = "0x185683A60")]
	private void IIMJCOGLBCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x56802E0", Offset = "0x567EAE0", VA = "0x1856802E0")]
	private void CKOHJPMALIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x56861E0", Offset = "0x56849E0", VA = "0x1856861E0")]
	private NDHHBPMHGPL LCILCEBPHMF(DDCGLHPBFHP JCCLHLMKLJC)
	{
		return default(NDHHBPMHGPL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x56847B0", Offset = "0x5682FB0", VA = "0x1856847B0")]
	private NDHHBPMHGPL IJGADBILBND(DDCGLHPBFHP JCCLHLMKLJC)
	{
		return default(NDHHBPMHGPL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x5682C80", Offset = "0x5681480", VA = "0x185682C80")]
	internal static string HJCOAOAKEEN(HAPMGBGMADL CBFDMEHPMJK, string IDBBGAHCOGF, bool EGAPCIKBHPE, int GCPALKKPKNO, int OJKLOBJCMDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x5680EA0", Offset = "0x567F6A0", VA = "0x185680EA0", Slot = "52")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x5687100", Offset = "0x5685900", VA = "0x185687100")]
	private LIHOBIGHABN LPMEILDBDCN(BNKEEFOCAMM KDDFEFMMFMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x5687AF0", Offset = "0x56862F0", VA = "0x185687AF0")]
	private BCECPACDPCH NBIFECMDLHC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x5682840", Offset = "0x5681040", VA = "0x185682840")]
	private Task GMJAGFIOCPF(ALNDGPDOBOK HPDOEALAHJH, CancellationToken NNLBJPBEHPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x5680A70", Offset = "0x567F270", VA = "0x185680A70")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(NKPLMIBBGFC))]
	private Task DKDLGEBCBGM(ALNDGPDOBOK HPDOEALAHJH, CancellationToken NNLBJPBEHPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x567E270", Offset = "0x567CA70", VA = "0x18567E270")]
	private Task AABCIHAEHFP(ALNDGPDOBOK HPDOEALAHJH, CancellationToken NNLBJPBEHPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x568A220", Offset = "0x5688A20", VA = "0x18568A220")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(AOAHGGFPHHC))]
	private Task PGADONELNHK(string AKADEFDGONP, TimeSpan JLMOFFKMFOO, CancellationToken NNLBJPBEHPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x406B420", Offset = "0x4069C20", VA = "0x18406B420")]
	[CompilerGenerated]
	private void MMENLDIFBIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x5687900", Offset = "0x5686100", VA = "0x185687900")]
	[CompilerGenerated]
	private void MKEFMFNIEAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x5681D10", Offset = "0x5680510", VA = "0x185681D10")]
	[CompilerGenerated]
	private bool FDKEEICLHHJ(KeepsakeInstanceDTO FBGKLELIKCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x5685330", Offset = "0x5683B30", VA = "0x185685330")]
	[CompilerGenerated]
	private JJMNNLLBAJO<Dictionary<HILCHEIPPND, int>> KDBCJKCKEOL(Dictionary<Guid, HILCHEIPPND> LOPHAOJJKHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x5681960", Offset = "0x5680160", VA = "0x185681960")]
	[CompilerGenerated]
	private JJMNNLLBAJO<Dictionary<HILCHEIPPND, int>> EPIHNPGJEKK(Dictionary<Guid, HILCHEIPPND> LOPHAOJJKHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x56861C0", Offset = "0x56849C0", VA = "0x1856861C0")]
	[CompilerGenerated]
	private bool LCGAAPPAABG(KeepsakeRoomListDTO FBGKLELIKCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x5688B40", Offset = "0x5687340", VA = "0x185688B40")]
	[CompilerGenerated]
	private bool NOPPMBEMLCD(KeepsakeInstanceDTO FBGKLELIKCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x567E310", Offset = "0x567CB10", VA = "0x18567E310")]
	[CompilerGenerated]
	private void AAEFHNBOFJO(Tuple<KeepsakeRoomInstancesDTO, IReadOnlyDictionary<HILCHEIPPND, KeepsakeCategoryConfigDTO>, KeepsakeGlobalConfigDTO> CHEMNNNMLEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x5684F90", Offset = "0x5683790", VA = "0x185684F90")]
	[CompilerGenerated]
	private void JEIADBBEJEH(string OABOGFOJNOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x56800B0", Offset = "0x567E8B0", VA = "0x1856800B0")]
	[CompilerGenerated]
	private Task CIHOFEPGFBM(CancellationToken IPDLHDCOEFF)
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
