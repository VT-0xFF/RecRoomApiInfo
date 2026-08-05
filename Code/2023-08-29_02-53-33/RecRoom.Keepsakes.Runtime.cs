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
	public class KeepsakesConfig : ScriptableObject, BJGAAEALPEI<KeepsakesConfig.KeepsakesOptions>
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		public class KeepsakesOptions
		{
			[Cpp2IlInjected.Token(Token = "0x2000004")]
			[CompilerGenerated]
			private sealed class EEFKMHGLCIO
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000003")]
				public string themeId;

				[Cpp2IlInjected.Token(Token = "0x6000005")]
				[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
				public EEFKMHGLCIO()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000006")]
				[Cpp2IlInjected.Address(RVA = "0x56D87D0", Offset = "0x56D7BD0", VA = "0x1856D87D0")]
				internal bool DOILOAMLLHE(KeepsakeTheme x)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000007")]
				[Cpp2IlInjected.Address(RVA = "0x56D87D0", Offset = "0x56D7BD0", VA = "0x1856D87D0")]
				internal bool KHPMBKDFNLN(KeepsakeTheme x)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000002")]
			[SerializeField]
			private KeepsakeTheme[] themes;

			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x56E7A20", Offset = "0x56E6E20", VA = "0x1856E7A20")]
			public bool JJDFDFEPNLB(string GGCHLADAEML, out KeepsakeTheme PEEBBDMMJAO)
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
			[Cpp2IlInjected.Address(RVA = "0x7F3130", Offset = "0x7F2530", VA = "0x1807F3130", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x56E79A0", Offset = "0x56E6DA0", VA = "0x1856E79A0")]
		[GHLDKGGJCDP(FGNCLGKDFDK.GameOnly)]
		private static void NAFFPAPIKOC(EPBOEGFMAOO OHJGEOICJDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x992770", Offset = "0x991B70", VA = "0x180992770")]
		public KeepsakesConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class CJHNLAFIBMM : IComparer<ALPCGHPMCLM>
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class BDHCJACEMFD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public ALPCGHPMCLM x;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public ALPCGHPMCLM y;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
		public BDHCJACEMFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xB56E90", Offset = "0xB56290", VA = "0x180B56E90")]
		internal bool LEBFDGMBNFO(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x15C5FC0", Offset = "0x15C53C0", VA = "0x1815C5FC0")]
		internal bool IIBENFJAOGJ(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xB56E90", Offset = "0xB56290", VA = "0x180B56E90")]
		internal bool IEGLIHPPPMG(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x15C5FC0", Offset = "0x15C53C0", VA = "0x1815C5FC0")]
		internal bool MHEKIBGFJBP(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<KeepsakeCategoryThemePair> DHFCPLCHPNL;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7FF090", Offset = "0x7FE490", VA = "0x1807FF090")]
	public CJHNLAFIBMM(List<KeepsakeCategoryThemePair> CILKPJDCIAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x56D82C0", Offset = "0x56D76C0", VA = "0x1856D82C0", Slot = "4")]
	public int Compare(ALPCGHPMCLM GEAEMIOLNKK, ALPCGHPMCLM KFMHCNGHPHP)
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
		public ALPCGHPMCLM KeepsakeCategory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public KeepsakeTheme KeepsakeTheme;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[BFHCHFMBBNB]
public class EMKMMPEIGLD : BEPGKHCEPLH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class FKBBHLICKLG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public EMKMMPEIGLD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public ALPCGHPMCLM keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
		public FKBBHLICKLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x56E6790", Offset = "0x56E5B90", VA = "0x1856E6790")]
		internal MCFFIFIPNKE<Guid> DBOHALNOIOP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x56E6D30", Offset = "0x56E6130", VA = "0x1856E6D30")]
		internal void IIMJPCEPBKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x56E6D60", Offset = "0x56E6160", VA = "0x1856E6D60")]
		internal void LKIAJEENDLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x56E68D0", Offset = "0x56E5CD0", VA = "0x1856E68D0")]
		internal void DCICNIDCDIA(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x56E6DC0", Offset = "0x56E61C0", VA = "0x1856E6DC0")]
		internal void LMLKAAHIEAB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class IHNLBJBNCJP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public EMKMMPEIGLD <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
		public IHNLBJBNCJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x56E7490", Offset = "0x56E6890", VA = "0x1856E7490")]
		internal void KIIOMKJFBEH(MJIFEMJOLBM response)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x56E7430", Offset = "0x56E6830", VA = "0x1856E7430")]
		internal void GLGALHKGMNM(string error)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class GEAIKOKJBOB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public KeepsakeTheme theme;

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
		public GEAIKOKJBOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x56E7090", Offset = "0x56E6490", VA = "0x1856E7090")]
		internal bool DEFEEEFPANH(KeepsakeCategoryThemePair categoryThemePair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class BNJOEMBKAAL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public EMKMMPEIGLD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public long progressionEventId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public ALPCGHPMCLM? keepsakeCategory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
		public BNJOEMBKAAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x56D7EA0", Offset = "0x56D72A0", VA = "0x1856D7EA0")]
		internal void ANPOIGOKJEC(KeepsakeProgressionEventInstancesDTO result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x56D7900", Offset = "0x56D6D00", VA = "0x1856D7900")]
		internal void KOJJOKPKDLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x56D7F20", Offset = "0x56D7320", VA = "0x1856D7F20")]
		internal MCFFIFIPNKE<IEnumerable<Guid>> PBNLGFFMBDB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x2C565B0", Offset = "0x2C559B0", VA = "0x182C565B0")]
		internal bool ECLNMCNIHCC(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class PCBHPGGJAOO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public KeepsakeRoomInstanceIdsDTO instancesInRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public BNJOEMBKAAL CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
		public PCBHPGGJAOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x56E8280", Offset = "0x56E7680", VA = "0x1856E8280")]
		internal MCFFIFIPNKE<IEnumerable<Guid>> APMDGLLCGBM(KeepsakeRoomInstancesDTO roomInstancesDTO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class PPMAHLJNEMN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public KeepsakeRoomInstancesDTO roomInstancesDTO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public PCBHPGGJAOO CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
		public PPMAHLJNEMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x56E8980", Offset = "0x56E7D80", VA = "0x1856E8980")]
		internal bool FOHFMGCMIDN(Guid instanceId)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class IEIJCCJDEDD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Guid instanceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public PPMAHLJNEMN CS$<>8__locals3;

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
		public IEIJCCJDEDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x56E7330", Offset = "0x56E6730", VA = "0x1856E7330")]
		internal bool KMNCDIPPCKN(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class ODKBBLJIPLP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public EMKMMPEIGLD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
		public ODKBBLJIPLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x56E7ED0", Offset = "0x56E72D0", VA = "0x1856E7ED0")]
		internal MCFFIFIPNKE<IEnumerable<Guid>> GEPOFLKPNEF(IEnumerable<Guid> instanceIds)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x56E8040", Offset = "0x56E7440", VA = "0x1856E8040")]
		internal bool GKEEAEMMFEA(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class AAAEEIKNGBM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public EMKMMPEIGLD <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
		public AAAEEIKNGBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x56D7880", Offset = "0x56D6C80", VA = "0x1856D7880")]
		internal void DOJNPMDFONO(KeepsakeProgressionEventInstancesDTO result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x56D7900", Offset = "0x56D6D00", VA = "0x1856D7900")]
		internal void JDOFIOAFPHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x56D7930", Offset = "0x56D6D30", VA = "0x1856D7930")]
		internal MCFFIFIPNKE<Dictionary<Guid, ALPCGHPMCLM>> JGECJDEGIID()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x2C565B0", Offset = "0x2C559B0", VA = "0x182C565B0")]
		internal bool NDNGOGDNJOD(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class GDMCFDJJNHB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public KeepsakeRoomInstanceIdsDTO instancesInRoom;

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
		public GDMCFDJJNHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x56E6EC0", Offset = "0x56E62C0", VA = "0x1856E6EC0")]
		internal MCFFIFIPNKE<Dictionary<Guid, ALPCGHPMCLM>> DLKKEBOPOPO(KeepsakeRoomInstancesDTO roomInstancesDTO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class BCGAKMFILPN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public KeepsakeRoomInstancesDTO roomInstancesDTO;

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
		public BCGAKMFILPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x56D7C30", Offset = "0x56D7030", VA = "0x1856D7C30")]
		internal bool CMEFNEEGCBG(Guid instanceId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x56D7D20", Offset = "0x56D7120", VA = "0x1856D7D20")]
		internal KeyValuePair<Guid, ALPCGHPMCLM> OJFIONKPKJJ(Guid instanceId)
		{
			return default(KeyValuePair<Guid, ALPCGHPMCLM>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class KBEEGBJFOIG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public Guid instanceId;

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
		public KBEEGBJFOIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x56E7840", Offset = "0x56E6C40", VA = "0x1856E7840")]
		internal bool HNKFEGGHLCG(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class HIDDIOHPCEI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public Guid instanceId;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
		public HIDDIOHPCEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x56E70C0", Offset = "0x56E64C0", VA = "0x1856E70C0")]
		internal bool EJPNHGILJFF(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class OHJEAKKEIJA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public EMKMMPEIGLD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
		public OHJEAKKEIJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x56E8060", Offset = "0x56E7460", VA = "0x1856E8060")]
		internal MCFFIFIPNKE<Dictionary<Guid, ALPCGHPMCLM>> OKNCELONEFK(Dictionary<Guid, ALPCGHPMCLM> instanceIdsAndCategories)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x56E8040", Offset = "0x56E7440", VA = "0x1856E8040")]
		internal bool GAGIBLKMNEG(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class PCNOMHDAGBI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public KeepsakeRoomInstanceIdsDTO collectedInstanceIds;

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
		public PCNOMHDAGBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x56E83D0", Offset = "0x56E77D0", VA = "0x1856E83D0")]
		internal bool EOGMHKNOJOF(KeyValuePair<Guid, ALPCGHPMCLM> idCategoryPair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class ENBJHECAILA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public Dictionary<Guid, ALPCGHPMCLM> instanceIdsAndCategories;

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
		public ENBJHECAILA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x56E65A0", Offset = "0x56E59A0", VA = "0x1856E65A0")]
		internal KeyValuePair<ALPCGHPMCLM, int> NBOBAHMLPLP(ALPCGHPMCLM category)
		{
			return default(KeyValuePair<ALPCGHPMCLM, int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class MOBBCEAJGEB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public ALPCGHPMCLM category;

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
		public MOBBCEAJGEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0xA2C400", Offset = "0xA2B800", VA = "0x180A2C400")]
		internal bool BFKCFDHFODO(ALPCGHPMCLM instanceCategory)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class DDLOJLNAAHJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public Dictionary<Guid, ALPCGHPMCLM> instanceIdsAndCategories;

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
		public DDLOJLNAAHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x56D8570", Offset = "0x56D7970", VA = "0x1856D8570")]
		internal KeyValuePair<ALPCGHPMCLM, int> KMGELOMNJCE(ALPCGHPMCLM category)
		{
			return default(KeyValuePair<ALPCGHPMCLM, int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class EDEPLEGLPMF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public ALPCGHPMCLM category;

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
		public EDEPLEGLPMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0xA2C400", Offset = "0xA2B800", VA = "0x180A2C400")]
		internal bool GANNGKIGOPH(ALPCGHPMCLM instanceCategory)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class HJFIBJPFLNB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public EMKMMPEIGLD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public Func<KeepsakeRoomDTO, bool> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
		public HJFIBJPFLNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x56E7250", Offset = "0x56E6650", VA = "0x1856E7250")]
		internal bool NKJOMDMJJLK(DateTime nowUtc, DateTime eventStartTime, int roomOrder, TimeSpan unlockStartOffset, TimeSpan unlockInterval, int unlockBatchSize)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x56E7180", Offset = "0x56E6580", VA = "0x1856E7180")]
		internal bool HAAEMLMBMDK(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x56E7160", Offset = "0x56E6560", VA = "0x1856E7160")]
		internal bool BKLGBHGAEOC(KeepsakeRoomDTO r)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x56E7160", Offset = "0x56E6560", VA = "0x1856E7160")]
		internal bool LHKMGAMHMBP(KeepsakeRoomDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class KGMDBNEEKEI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
		public KGMDBNEEKEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0xBB60A0", Offset = "0xBB54A0", VA = "0x180BB60A0")]
		internal bool IGJKCMIEAHB(KeepsakeRoomListDTO roomList)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class GCGFBFPPHLE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public Func<KeepsakeRoomDTO, bool> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
		public GCGFBFPPHLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x56E6DF0", Offset = "0x56E61F0", VA = "0x1856E6DF0")]
		internal bool GNBFCMHILJK(KeepsakeRoomListDTO roomList)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0xBF08A0", Offset = "0xBEFCA0", VA = "0x180BF08A0")]
		internal bool AJBOPDLOKGG(KeepsakeRoomDTO room)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class DGBICAMMPBI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
		public DGBICAMMPBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x56D86D0", Offset = "0x56D7AD0", VA = "0x1856D86D0")]
		internal bool EDEBHIMOLNL(KeepsakeRoomListDTO i)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class JENKDBIAHCH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
		public JENKDBIAHCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0xBB60A0", Offset = "0xBB54A0", VA = "0x180BB60A0")]
		internal bool DLKCKHNOOBC(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class DIEEMBABCIF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public Guid keepsakeInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
		public DIEEMBABCIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x56D8740", Offset = "0x56D7B40", VA = "0x1856D8740")]
		internal bool PNNOKFEAPDO(KeyValuePair<Guid, KeepsakeInstanceDTO> instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class HMKBJKKOEHO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public ALPCGHPMCLM keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
		public HMKBJKKOEHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0xBFB1A0", Offset = "0xBFA5A0", VA = "0x180BFB1A0")]
		internal bool COJGNNEGNHK(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class EOKDCAHFBCG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public Guid keepsakeInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
		public EOKDCAHFBCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x56E6700", Offset = "0x56E5B00", VA = "0x1856E6700")]
		internal bool ECBDFJGPIKG(KeyValuePair<Guid, KeepsakeInstanceDTO> instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class KBIBKIEPCBP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public ALPCGHPMCLM keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
		public KBIBKIEPCBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x56E78E0", Offset = "0x56E6CE0", VA = "0x1856E78E0")]
		internal bool BFKJOINLFGL(KeyValuePair<Guid, ALPCGHPMCLM> x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class ABBFLJAKLLC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public ALPCGHPMCLM newKeepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
		public ABBFLJAKLLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0xBFB1A0", Offset = "0xBFA5A0", VA = "0x180BFB1A0")]
		internal bool HCOJABGKDLM(KeepsakeInstanceDTO instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class BPILNMCMLDD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public long currentRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public long? currentSubRoomId;

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
		public BPILNMCMLDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x56D8230", Offset = "0x56D7630", VA = "0x1856D8230")]
		internal bool HAIBILCCFJM(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class NBMFHEEPDKN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public IEnumerable<KeepsakeRoomListDTO> roomList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
		public NBMFHEEPDKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x56E7BF0", Offset = "0x56E6FF0", VA = "0x1856E7BF0")]
		internal bool PMODHFLJLIB(KeepsakeRoomDTO room)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class KECKNJDJGFB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public KeepsakeRoomDTO room;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public NBMFHEEPDKN CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
		public KECKNJDJGFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x56E7920", Offset = "0x56E6D20", VA = "0x1856E7920")]
		internal bool IHJJBKNGECI(KeepsakeRoomListDTO roomListDto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class PPCOJGOIDHG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public LPPEEGCNOPD args;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public EMKMMPEIGLD <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
		public PPCOJGOIDHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x56E8450", Offset = "0x56E7850", VA = "0x1856E8450", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class NMHAOFIACCO : IAsyncStateMachine
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
		public EMKMMPEIGLD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
		public NMHAOFIACCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x56E7CE0", Offset = "0x56E70E0", VA = "0x1856E7CE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly DateTime OFEOHFJINNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly NBLAFBENHED GMCMFFNHKLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly MLCGBCNMPJC CGBOMINCMOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly CKLMAJDGHAE KPHPIGIFBCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly LPPBMHCGHDM KBAKLGIDCLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly LKHDAGLDLDH CPLMKFAPFEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly JFOCEJIILKK GJONABCLECB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly PNKHGMIBNNI CBHBAPNBIKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly PFBAADEJOBA PBBMDKLPMJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly NDCBBAOEPAA DDNPIPNFKPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly JLPLACCHMKD LCIJBJBGHFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly OMINCBMFBNO AABNIOCICKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly OBGANFJFGFP JKIGLFCCJNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly LCEGLCOOPCF PHOLGLOCBEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly ENJODDNJIKD DGLIEJINEGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly MLEHJAMOLIK AEFFNDMNAEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly BJGAAEALPEI<KeepsakesConfig.KeepsakesOptions> CPIBKOBEODB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly JALNCDMAJCJ FMKCFGBFEPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly Dictionary<Guid, KeepsakeInstanceDTO> DCHIKNIKEDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly HashSet<Guid> ALBFEGPHEEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly HashSet<long> HGBHDCCGOPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private Dictionary<ALPCGHPMCLM, int> GEACCFAHMCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly HashSet<Guid> LLNPPDNAJCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly IDisposable DBKGIEPFBOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private Task NNGJMACBKOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private MCFFIFIPNKE<Guid> LMOAGADPKGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private long? OCCGCPHEHPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private KeepsakeProgressionEventInstancesDTO KPDCLKGKOLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private MCFFIFIPNKE<KeepsakeProgressionEventInstancesDTO> EOHJGMOMNOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private IReadOnlyDictionary<ALPCGHPMCLM, KeepsakeCategoryConfigDTO> ICADFGPKMDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private KeepsakeGlobalConfigDTO NAJJDEPHFJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private HashSet<long> IMFDGEAHJFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private HashSet<long> EIBNCLIIFKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private List<KeepsakeRoomListDTO> LFNFNDEAFGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private List<KeepsakeRoomListDTO> PKEAEMNEBLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private List<KeepsakeRoomListDTO> BCJLHMOACOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private Dictionary<long, string> GNKABPMMOPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private Dictionary<long, string> LJBOAMMMIGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private Dictionary<long, DateTime> JDDPKPEFCMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private Dictionary<long, List<KeepsakeRoomDTO>> AMGINMBCMNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private Dictionary<long, List<KeepsakeRoomDTO>> PEPCNKNMBFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private Dictionary<long, long> ACEHKOEEEEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly List<string> NMDHIHCMKGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private DateTime OOBPHGIFDHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly IDisposable MKIIHLJLCGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private Dictionary<Guid, ALPCGHPMCLM> MHBFPJLNBLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private Dictionary<ALPCGHPMCLM, int> OIPHLODIHCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private List<KeepsakeCategoryThemePair> CILKPJDCIAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private CJHNLAFIBMM GPICJEOMHKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private bool CGOGAKCLEFJ;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool CMHOHIHILEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8FD060", Offset = "0x8FC460", VA = "0x1808FD060", Slot = "53")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8FD5F0", Offset = "0x8FC9F0", VA = "0x1808FD5F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool EPALINODPOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x56E1E10", Offset = "0x56E1210", VA = "0x1856E1E10", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool DKOBHLMFPDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x56E2330", Offset = "0x56E1730", VA = "0x1856E2330", Slot = "36")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private long LBAPIKBGJAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x56D8860", Offset = "0x56D7C60", VA = "0x1856D8860")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private long? FPAGKHJBJHG
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x56D9440", Offset = "0x56D8840", VA = "0x1856D9440")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private bool CJFIHFOPBCC
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x56E35F0", Offset = "0x56E29F0", VA = "0x1856E35F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public IReadOnlyList<KeepsakeRoomListDTO> AOGEHIDCEMF
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xD4B560", Offset = "0xD4A960", VA = "0x180D4B560", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IReadOnlyList<KeepsakeRoomListDTO> GHPHNFHABOM
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x91FBE0", Offset = "0x91EFE0", VA = "0x18091FBE0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public IReadOnlyList<KeepsakeRoomListDTO> LFFBOKPGBEH
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x91FC20", Offset = "0x91F020", VA = "0x18091FC20", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public IReadOnlyDictionary<long, string> FDEFNGFALAO
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xC5D960", Offset = "0xC5CD60", VA = "0x180C5D960", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	internal bool CBOHKJAKIHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x9BBE30", Offset = "0x9BB230", VA = "0x1809BBE30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Guid?> KFALDIIJMDO
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x56DF520", Offset = "0x56DE920", VA = "0x1856DF520", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x56DB1B0", Offset = "0x56DA5B0", VA = "0x1856DB1B0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action LOFKDMKLHDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x56DAA80", Offset = "0x56D9E80", VA = "0x1856DAA80", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x56DB320", Offset = "0x56DA720", VA = "0x1856DB320", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action BAKHJCCDEKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x56E4150", Offset = "0x56E3550", VA = "0x1856E4150", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x56E1060", Offset = "0x56E0460", VA = "0x1856E1060", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x56E5280", Offset = "0x56E4680", VA = "0x1856E5280")]
	[Preserve]
	internal EMKMMPEIGLD([NotNull][EPGFAMNCJKC(null)] NBLAFBENHED GMCMFFNHKLE, [NotNull][EPGFAMNCJKC(null)] LNBMHEPKEDJ EONGFEEMONK, [NotNull][EPGFAMNCJKC(null)] MLCGBCNMPJC CGBOMINCMOP, [NotNull][EPGFAMNCJKC(null)] CKLMAJDGHAE KPHPIGIFBCN, [NotNull][EPGFAMNCJKC(null)] LPPBMHCGHDM KBAKLGIDCLG, [NotNull][EPGFAMNCJKC(null)] LKHDAGLDLDH CPLMKFAPFEF, [NotNull][EPGFAMNCJKC(null)] JFOCEJIILKK GJONABCLECB, [NotNull][EPGFAMNCJKC(null)] PNKHGMIBNNI CBHBAPNBIKM, [NotNull][EPGFAMNCJKC(null)] PFBAADEJOBA PBBMDKLPMJK, [NotNull][EPGFAMNCJKC(null)] DBAKDCDHOBN GKPEPPFBPHJ, [NotNull][EPGFAMNCJKC(null)] NDCBBAOEPAA DDNPIPNFKPH, [NotNull][EPGFAMNCJKC(null)] JLPLACCHMKD LCIJBJBGHFC, [NotNull][EPGFAMNCJKC(null)] OMINCBMFBNO AABNIOCICKN, [NotNull][EPGFAMNCJKC(null)] OBGANFJFGFP JKIGLFCCJNF, [NotNull][EPGFAMNCJKC(null)] LCEGLCOOPCF PHOLGLOCBEC, [NotNull][EPGFAMNCJKC(null)] ENJODDNJIKD DGLIEJINEGA, [NotNull][EPGFAMNCJKC(null)] MLEHJAMOLIK AEFFNDMNAEL, [NotNull][EPGFAMNCJKC(null)] BJGAAEALPEI<KeepsakesConfig.KeepsakesOptions> CPIBKOBEODB, [NotNull][EPGFAMNCJKC(null)] JALNCDMAJCJ FMKCFGBFEPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x56E0CA0", Offset = "0x56E00A0", VA = "0x1856E0CA0", Slot = "15")]
	public bool IIDFNFPLCHF(List<string> DDEDJIOHNDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x56E12E0", Offset = "0x56E06E0", VA = "0x1856E12E0", Slot = "16")]
	public MCFFIFIPNKE<Guid> JNBANCKGPPE(ALPCGHPMCLM EJHGPGAGNJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x56D9E50", Offset = "0x56D9250", VA = "0x1856D9E50", Slot = "17")]
	public CCKGNGCPCCF BLFGLPFOKNH(Guid PHMLMEFLACC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x56E1FB0", Offset = "0x56E13B0", VA = "0x1856E1FB0", Slot = "18")]
	public CCKGNGCPCCF KLMNKJEJJMM(Guid PHMLMEFLACC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x56E1E60", Offset = "0x56E1260", VA = "0x1856E1E60", Slot = "19")]
	public bool KJOKANOLKFG(Guid PHMLMEFLACC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x56E4830", Offset = "0x56E3C30", VA = "0x1856E4830", Slot = "20")]
	public bool PDGJPOJFIFE(Guid PHMLMEFLACC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x56DABD0", Offset = "0x56D9FD0", VA = "0x1856DABD0")]
	public KeepsakeTheme DDGJJBONLIJ(Guid PHMLMEFLACC)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x56DA530", Offset = "0x56D9930", VA = "0x1856DA530")]
	public bool CAFJBODFMJE(ALPCGHPMCLM EJHGPGAGNJJ, out KeepsakeTheme PEEBBDMMJAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x56E4DC0", Offset = "0x56E41C0", VA = "0x1856E4DC0")]
	public List<KeepsakeTheme> PIACNCNKIKO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x56DB050", Offset = "0x56DA450", VA = "0x1856DB050")]
	public int DGLLIBIHLPM(ALPCGHPMCLM EJHGPGAGNJJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x56DAEE0", Offset = "0x56DA2E0", VA = "0x1856DAEE0")]
	public ALPCGHPMCLM DDPBADBHIKN(Guid PHMLMEFLACC)
	{
		return default(ALPCGHPMCLM);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x56E04A0", Offset = "0x56DF8A0", VA = "0x1856E04A0", Slot = "34")]
	public List<ALPCGHPMCLM> IDKIIGMPNGJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x56DF810", Offset = "0x56DEC10", VA = "0x1856DF810", Slot = "35")]
	public IComparer<ALPCGHPMCLM> HDOMEAPOEBN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x56DAD70", Offset = "0x56DA170", VA = "0x1856DAD70", Slot = "32")]
	public string DDMOBHONIOD(ALPCGHPMCLM EJHGPGAGNJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x56DED90", Offset = "0x56DE190", VA = "0x1856DED90", Slot = "33")]
	public string GDLMGOFOECF(ALPCGHPMCLM EJHGPGAGNJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x56E07F0", Offset = "0x56DFBF0", VA = "0x1856E07F0", Slot = "21")]
	public bool IFCADKMKKBP(Guid PHMLMEFLACC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x56DD4D0", Offset = "0x56DC8D0", VA = "0x1856DD4D0", Slot = "22")]
	public void FFHEAFGBABP(Guid PHMLMEFLACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x56E1240", Offset = "0x56E0640", VA = "0x1856E1240", Slot = "23")]
	public void JFKKMBGPIEE(ALPCGHPMCLM EJHGPGAGNJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x56DF5C0", Offset = "0x56DE9C0", VA = "0x1856DF5C0", Slot = "24")]
	public void HALLOJKFLIO(Guid PHMLMEFLACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x56E19B0", Offset = "0x56E0DB0", VA = "0x1856E19B0", Slot = "25")]
	public int KGOFEKJECMF()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x56E2880", Offset = "0x56E1C80", VA = "0x1856E2880", Slot = "31")]
	public MCFFIFIPNKE<IEnumerable<Guid>> LCKAIGEMKIM(long KLOAGIPENLJ, long MIJGFFLJFFK, ALPCGHPMCLM? EJHGPGAGNJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x56DC090", Offset = "0x56DB490", VA = "0x1856DC090", Slot = "30")]
	public MCFFIFIPNKE<IEnumerable<Guid>> EGNNEMAPGGN(long KLOAGIPENLJ, long MIJGFFLJFFK, ALPCGHPMCLM? EJHGPGAGNJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x56DB980", Offset = "0x56DAD80", VA = "0x1856DB980", Slot = "54")]
	public MCFFIFIPNKE<Dictionary<Guid, ALPCGHPMCLM>> EGFOACAADHE(long KLOAGIPENLJ, long MIJGFFLJFFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x56E4640", Offset = "0x56E3A40", VA = "0x1856E4640", Slot = "55")]
	public MCFFIFIPNKE<Dictionary<Guid, ALPCGHPMCLM>> OOILEACOJDP(long KLOAGIPENLJ, long MIJGFFLJFFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x56DA1A0", Offset = "0x56D95A0", VA = "0x1856DA1A0", Slot = "26")]
	public MCFFIFIPNKE<int> BOBCGBEINFK(long KLOAGIPENLJ, long MIJGFFLJFFK, ALPCGHPMCLM? EJHGPGAGNJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x56DC7E0", Offset = "0x56DBBE0", VA = "0x1856DC7E0", Slot = "27")]
	public MCFFIFIPNKE<int> EJKFNMIGHIN(long KLOAGIPENLJ, long MIJGFFLJFFK, ALPCGHPMCLM? EJHGPGAGNJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x56E3E30", Offset = "0x56E3230", VA = "0x1856E3E30", Slot = "28")]
	public MCFFIFIPNKE<Dictionary<ALPCGHPMCLM, int>> NNPKOMGPCHH(long KLOAGIPENLJ, long MIJGFFLJFFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x56DB250", Offset = "0x56DA650", VA = "0x1856DB250", Slot = "29")]
	public MCFFIFIPNKE<Dictionary<ALPCGHPMCLM, int>> DMPIKBKBBIO(long KLOAGIPENLJ, long MIJGFFLJFFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x56D92E0", Offset = "0x56D86E0", VA = "0x1856D92E0", Slot = "37")]
	public bool BDPACGJOOJB(long KLOAGIPENLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x56E0C40", Offset = "0x56E0040", VA = "0x1856E0C40", Slot = "56")]
	public bool IGPGJLMBJJA(long KLOAGIPENLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x56E1910", Offset = "0x56E0D10", VA = "0x1856E1910", Slot = "38")]
	public bool JNICEEIABJP(long KLOAGIPENLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x56D9A90", Offset = "0x56D8E90", VA = "0x1856D9A90", Slot = "57")]
	public bool BLEKIFOHNDE(long KLOAGIPENLJ, out IGPECDKBFHO DHLPOGMFGGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x56E41F0", Offset = "0x56E35F0", VA = "0x1856E41F0", Slot = "39")]
	public bool OKFEIIPPEDI(long IAICADHOCEP, out DateTime BLJPJFDEBEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x56DFF90", Offset = "0x56DF390", VA = "0x1856DFF90", Slot = "40")]
	public long ICGGJDGBIKI(long IAICADHOCEP)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x56D8930", Offset = "0x56D7D30", VA = "0x1856D8930", Slot = "41")]
	public long AODLNPCCFGN(long KLOAGIPENLJ)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x56E05F0", Offset = "0x56DF9F0", VA = "0x1856E05F0", Slot = "42")]
	public int IEPJPHAJDII(long IAICADHOCEP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x56E4060", Offset = "0x56E3460", VA = "0x1856E4060", Slot = "43")]
	public bool OGIPCOEMNJE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x56DD540", Offset = "0x56DC940", VA = "0x1856DD540", Slot = "44")]
	public bool FFNBAAPEGPC(long IAICADHOCEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x56DD800", Offset = "0x56DCC00", VA = "0x1856DD800", Slot = "45")]
	public IEnumerable<long> FHBBCPELEED(long IAICADHOCEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x56E0FB0", Offset = "0x56E03B0", VA = "0x1856E0FB0", Slot = "46")]
	public int IKFLDEDGBFG(long IAICADHOCEP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x56DBD60", Offset = "0x56DB160", VA = "0x1856DBD60", Slot = "50")]
	public long EGLLIOFDBFE(long JMJEDLDIMKO)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x56E2D00", Offset = "0x56E2100", VA = "0x1856E2D00", Slot = "51")]
	public ALPCGHPMCLM LILBAGHHJAN()
	{
		return default(ALPCGHPMCLM);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x56DD390", Offset = "0x56DC790", VA = "0x1856DD390")]
	private bool FEJPBJMHGKG(Guid PHMLMEFLACC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x56D8C30", Offset = "0x56D8030", VA = "0x1856D8C30")]
	private void BCBGODPPDHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x56E4340", Offset = "0x56E3740", VA = "0x1856E4340")]
	private ALPCGHPMCLM OLGCOHHANCB()
	{
		return default(ALPCGHPMCLM);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x56DC230", Offset = "0x56DB630", VA = "0x1856DC230")]
	private void EIBMGKDPJFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x56E0A90", Offset = "0x56DFE90", VA = "0x1856E0A90")]
	private int IGOECEAMHJG(KeepsakeRoomListDTO PPHLCGKHIFH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x56DA0D0", Offset = "0x56D94D0", VA = "0x1856DA0D0")]
	private int BLMCBPEDEHL(DateTime KONGJGGNNLN, DateTime HIJOPCLNAGM, TimeSpan PEGLGKJLKLM, int FEBPEKFLFNJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x56DCF80", Offset = "0x56DC380", VA = "0x1856DCF80")]
	private void FACCFIGFBIP(IEnumerable<KeepsakeInstanceDTO> DCHIKNIKEDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x56DFAB0", Offset = "0x56DEEB0", VA = "0x1856DFAB0")]
	private void HLMELEPGJPF(IEnumerable<KeepsakeCollectionRecordDTO> GILAFLLLJLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x56DF4C0", Offset = "0x56DE8C0", VA = "0x1856DF4C0")]
	private void GGIDEOALJOF(IEnumerable<long> IKLDJCPLGMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x10D2660", Offset = "0x10D1A60", VA = "0x1810D2660")]
	private void PLGDNFLMMAM(KeepsakeGlobalConfigDTO NAJJDEPHFJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x56D94E0", Offset = "0x56D88E0", VA = "0x1856D94E0")]
	private bool BJNAFEFKHFB(ALPCGHPMCLM EJHGPGAGNJJ, out Guid LIICIEOLIBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x56DA460", Offset = "0x56D9860", VA = "0x1856DA460")]
	private bool BPBLALOEFIA(out Guid LIICIEOLIBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x56E32C0", Offset = "0x56E26C0", VA = "0x1856E32C0")]
	private bool LONJAJCKJMM(Guid PHMLMEFLACC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x56DB820", Offset = "0x56DAC20", VA = "0x1856DB820")]
	private IEnumerable<Guid> EDFFLAFFPKK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x56DECC0", Offset = "0x56DE0C0", VA = "0x1856DECC0")]
	private IEnumerable<KeepsakeInstanceDTO> GCEHFCMEHCN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x56E30B0", Offset = "0x56E24B0", VA = "0x1856E30B0")]
	private void LKLBNLKGAHF(Guid PHMLMEFLACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x56DAB20", Offset = "0x56D9F20", VA = "0x1856DAB20")]
	private bool DCCNHBCBIEJ(Guid PHMLMEFLACC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x56DDDB0", Offset = "0x56DD1B0", VA = "0x1856DDDB0")]
	private void FJHCOMPBAPE(Guid PHMLMEFLACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x56E03C0", Offset = "0x56DF7C0", VA = "0x1856E03C0")]
	private void ICIJAIHCHOB(ALPCGHPMCLM ECFGKMJGODM, int HFBGMBEDJLJ, ref Dictionary<ALPCGHPMCLM, int> HNPJGFLDAMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x56D9340", Offset = "0x56D8740", VA = "0x1856D9340")]
	private int BHHHNDKJCFO(ALPCGHPMCLM EJHGPGAGNJJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x56D8A50", Offset = "0x56D7E50", VA = "0x1856D8A50")]
	private void BABCADFLAOL(KeepsakeInstanceDTO BGMICCELFBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x56DD190", Offset = "0x56DC590", VA = "0x1856DD190")]
	private void FDPAGMBEEGB(KeepsakeInstanceDTO BGMICCELFBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x56DA700", Offset = "0x56D9B00", VA = "0x1856DA700")]
	private void CGKODDIJOHN(Guid PHMLMEFLACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x56E3610", Offset = "0x56E2A10", VA = "0x1856E3610")]
	private void MKAEANLBMDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x56DDF50", Offset = "0x56DD350", VA = "0x1856DDF50")]
	private void FMHPGLPHMEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x56DF8B0", Offset = "0x56DECB0", VA = "0x1856DF8B0")]
	private void HFMNKDIDKJE(HGDMCGJABOC AEBEOKJKAMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x56E2400", Offset = "0x56E1800", VA = "0x1856E2400")]
	private void KOALIMJCGMO(NNGOGGLJOBC.BCAIKGLMBBE ICNDEPGFBMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x56E47D0", Offset = "0x56E3BD0", VA = "0x1856E47D0")]
	private void PCNALNKFFHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x56E3970", Offset = "0x56E2D70", VA = "0x1856E3970")]
	private void NHAFHFCCHGP(float EPGCOIJLGLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x56E4860", Offset = "0x56E3C60", VA = "0x1856E4860")]
	private void PDNGNLDHGND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x56E27F0", Offset = "0x56E1BF0", VA = "0x1856E27F0")]
	private bool LBKGDDCLJCP(Guid PHMLMEFLACC, out string BFPMIHFAOPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x56D9110", Offset = "0x56D8510", VA = "0x1856D9110")]
	private bool BCIDEMDCIBB(Guid PHMLMEFLACC, out KeepsakeCategoryConfigDTO ECFGKMJGODM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x56E33C0", Offset = "0x56E27C0", VA = "0x1856E33C0")]
	private void MFIBHKGBPKD(string ENKDIOOPJAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x56E3670", Offset = "0x56E2A70", VA = "0x1856E3670")]
	private bool MLHGOAPKHLD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x56D9790", Offset = "0x56D8B90", VA = "0x1856D9790")]
	private IEnumerable<long> BLBMNFOIMKF(IEnumerable<KeepsakeRoomDTO> NHLDABPPPPL, IEnumerable<KeepsakeRoomListDTO> OGHAODKAAMO, long IAICADHOCEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x56DEF00", Offset = "0x56DE300", VA = "0x1856DEF00")]
	private bool GEOHIPFIGFG(Guid PHMLMEFLACC, out string KDPCEEMNMDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x56D8800", Offset = "0x56D7C00", VA = "0x1856D8800", Slot = "47")]
	public string AABLEHHECBA(JIOICINKBJC CDEHFIHAHHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x56DCB30", Offset = "0x56DBF30", VA = "0x1856DCB30", Slot = "49")]
	public string ENHCKCFPEOE(JIOICINKBJC CDEHFIHAHHH, long KLOAGIPENLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x56DFCF0", Offset = "0x56DF0F0", VA = "0x1856DFCF0", Slot = "48")]
	public string HMLMJHDHHNE(JIOICINKBJC CDEHFIHAHHH, int HAHFHNMPGHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x56DDF70", Offset = "0x56DD370", VA = "0x1856DDF70")]
	private void GACMFMOLOIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x56E1100", Offset = "0x56E0500", VA = "0x1856E1100")]
	private void JDPBLJPKDIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x56D9A70", Offset = "0x56D8E70", VA = "0x1856D9A70")]
	private JIOICINKBJC BLCAKCCOIDO(JOMNBOGAHNI KCDPODAPAAO)
	{
		return default(JIOICINKBJC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x56D8C10", Offset = "0x56D8010", VA = "0x1856D8C10")]
	private JIOICINKBJC BCAGEPCPBOH(JOMNBOGAHNI KCDPODAPAAO)
	{
		return default(JIOICINKBJC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x56DC950", Offset = "0x56DBD50", VA = "0x1856DC950")]
	internal static string EKOMJAOKAIG(MJIFEMJOLBM BDCLMEKIDFP, string FJOMAMCCDEK, bool FBEGMPOCCAJ, int BMIBEMEKIBD, int JNCOADKKNDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x56DB3C0", Offset = "0x56DA7C0", VA = "0x1856DB3C0", Slot = "52")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x56E2C70", Offset = "0x56E2070", VA = "0x1856E2C70")]
	private MBMFMEKGGGG LGDMBJCEHJB(KAPKJIFIGFH OPEKDJECONJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x56DD9E0", Offset = "0x56DCDE0", VA = "0x1856DD9E0")]
	private EMOBOPJMDHG FINLBGBBBMC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x56E2460", Offset = "0x56E1860", VA = "0x1856E2460")]
	private Task KOIPGJONEBE(LPPEEGCNOPD KLEPOOAJLPJ, CancellationToken DNKHCCGNODC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x56E5110", Offset = "0x56E4510", VA = "0x1856E5110")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(PPCOJGOIDHG))]
	private Task PJEKGHGIAFF(LPPEEGCNOPD KLEPOOAJLPJ, CancellationToken DNKHCCGNODC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x56E3320", Offset = "0x56E2720", VA = "0x1856E3320")]
	private Task MANDAMLLCMO(LPPEEGCNOPD KLEPOOAJLPJ, CancellationToken DNKHCCGNODC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x56E3790", Offset = "0x56E2B90", VA = "0x1856E3790")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(NMHAOFIACCO))]
	private Task MMNLEGHAIOK(string HGJHDPGFLKO, TimeSpan CGHGJLAENOE, CancellationToken DNKHCCGNODC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x405CD70", Offset = "0x405C170", VA = "0x18405CD70")]
	[CompilerGenerated]
	private void AIIOPGGKPFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x56E3920", Offset = "0x56E2D20", VA = "0x1856E3920")]
	[CompilerGenerated]
	private void NGPPLHNKJBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x56E3D40", Offset = "0x56E3140", VA = "0x1856E3D40")]
	[CompilerGenerated]
	private bool NJGMNMMNPOJ(KeepsakeInstanceDTO GEAEMIOLNKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x56DFE10", Offset = "0x56DF210", VA = "0x1856DFE10")]
	[CompilerGenerated]
	private MCFFIFIPNKE<Dictionary<ALPCGHPMCLM, int>> IAOHEPENAPD(Dictionary<Guid, ALPCGHPMCLM> NCHJBBABDBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x56E3140", Offset = "0x56E2540", VA = "0x1856E3140")]
	[CompilerGenerated]
	private MCFFIFIPNKE<Dictionary<ALPCGHPMCLM, int>> LLIENGDCJMJ(Dictionary<Guid, ALPCGHPMCLM> NCHJBBABDBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x56E35D0", Offset = "0x56E29D0", VA = "0x1856E35D0")]
	[CompilerGenerated]
	private bool MIJMDCJLMNN(KeepsakeRoomListDTO GEAEMIOLNKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x56E34A0", Offset = "0x56E28A0", VA = "0x1856E34A0")]
	[CompilerGenerated]
	private bool MGONNLAHBPC(KeepsakeInstanceDTO GEAEMIOLNKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x56DF930", Offset = "0x56DED30", VA = "0x1856DF930")]
	[CompilerGenerated]
	private void HLLNBBPLCAH(Tuple<KeepsakeRoomInstancesDTO, IReadOnlyDictionary<ALPCGHPMCLM, KeepsakeCategoryConfigDTO>, KeepsakeGlobalConfigDTO> GCPLHJJHFHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x56E1280", Offset = "0x56E0680", VA = "0x1856E1280")]
	[CompilerGenerated]
	private void JHKFKCKMFJI(string KDPCEEMNMDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x56DDB80", Offset = "0x56DCF80", VA = "0x1856DDB80")]
	[CompilerGenerated]
	private Task FJAIDIAHCLA(CancellationToken OIFCDCPDEOF)
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
