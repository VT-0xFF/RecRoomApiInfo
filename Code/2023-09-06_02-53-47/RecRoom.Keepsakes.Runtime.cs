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
	public class KeepsakesConfig : ScriptableObject, LLLOGEPNBFK<KeepsakesConfig.KeepsakesOptions>
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		public class KeepsakesOptions
		{
			[Cpp2IlInjected.Token(Token = "0x2000004")]
			[CompilerGenerated]
			private sealed class FECHDAAFMAK
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000003")]
				public string themeId;

				[Cpp2IlInjected.Token(Token = "0x6000005")]
				[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
				public FECHDAAFMAK()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000006")]
				[Cpp2IlInjected.Address(RVA = "0x56C5F00", Offset = "0x56C4500", VA = "0x1856C5F00")]
				internal bool FIKIOPBJLBK(KeepsakeTheme x)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000007")]
				[Cpp2IlInjected.Address(RVA = "0x56C5F00", Offset = "0x56C4500", VA = "0x1856C5F00")]
				internal bool HODIOPOCAFJ(KeepsakeTheme x)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000002")]
			[SerializeField]
			private KeepsakeTheme[] themes;

			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x56D54A0", Offset = "0x56D3AA0", VA = "0x1856D54A0")]
			public bool IPJOKPMBOAG(string MPEAHHAHGHN, out KeepsakeTheme HLLFBCIFHPD)
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
			[Cpp2IlInjected.Address(RVA = "0x7ED620", Offset = "0x7EBC20", VA = "0x1807ED620", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x56D5420", Offset = "0x56D3A20", VA = "0x1856D5420")]
		[HFALCAKMDCP(BFPOMPMIJIJ.GameOnly)]
		private static void KDCCKDGHAKL(HOKFDAHMIPF IBEPDAFMEAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9341D0", Offset = "0x9327D0", VA = "0x1809341D0")]
		public KeepsakesConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class AOGENGOFHIG : IComparer<KNBGGKHAOAH>
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class OPKDOMBGEGD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public KNBGGKHAOAH x;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public KNBGGKHAOAH y;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public OPKDOMBGEGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xBED760", Offset = "0xBEBD60", VA = "0x180BED760")]
		internal bool IFOFFEACGOO(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xEC7A40", Offset = "0xEC6040", VA = "0x180EC7A40")]
		internal bool KDEKCIBKNNA(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xBED760", Offset = "0xBEBD60", VA = "0x180BED760")]
		internal bool LHGHPEOIMDB(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xEC7A40", Offset = "0xEC6040", VA = "0x180EC7A40")]
		internal bool EKLJBFBEOFL(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<KeepsakeCategoryThemePair> MPJNBABECPL;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0xA0C770", Offset = "0xA0AD70", VA = "0x180A0C770")]
	public AOGENGOFHIG(List<KeepsakeCategoryThemePair> JHKFLCABHDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x56C4CF0", Offset = "0x56C32F0", VA = "0x1856C4CF0", Slot = "4")]
	public int Compare(KNBGGKHAOAH HEICJNINGBE, KNBGGKHAOAH DNLDNFFNIEF)
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
		public KNBGGKHAOAH KeepsakeCategory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public KeepsakeTheme KeepsakeTheme;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[ONEJPGBFBKC]
public class FNKNJGBLBHO : LKLECENCKFL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class FBOGHENMFHN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public FNKNJGBLBHO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public KNBGGKHAOAH keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public FBOGHENMFHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x56C5DC0", Offset = "0x56C43C0", VA = "0x1856C5DC0")]
		internal MFBKDKPGMNP<Guid> MOEOFINPIOF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x56C58A0", Offset = "0x56C3EA0", VA = "0x1856C58A0")]
		internal void AEPJCFJIPPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x56C58D0", Offset = "0x56C3ED0", VA = "0x1856C58D0")]
		internal void FABPECBLPIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x56C5960", Offset = "0x56C3F60", VA = "0x1856C5960")]
		internal void GLIJFBAJMEE(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x56C5930", Offset = "0x56C3F30", VA = "0x1856C5930")]
		internal void GLEJAGALADL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class IFLJILDGOGA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public FNKNJGBLBHO <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public IFLJILDGOGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x56D4740", Offset = "0x56D2D40", VA = "0x1856D4740")]
		internal void OEPMALGCIPF(GMBGKNENFHK response)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x56D46E0", Offset = "0x56D2CE0", VA = "0x1856D46E0")]
		internal void NAOLPKBPJJI(string error)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class PHEKAABJNBK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public KeepsakeTheme theme;

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public PHEKAABJNBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x56D5DF0", Offset = "0x56D43F0", VA = "0x1856D5DF0")]
		internal bool BMIHJDHDGBF(KeepsakeCategoryThemePair categoryThemePair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class KLKIAMBGJDC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public FNKNJGBLBHO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public long progressionEventId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public KNBGGKHAOAH? keepsakeCategory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public KLKIAMBGJDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x56D53A0", Offset = "0x56D39A0", VA = "0x1856D53A0")]
		internal void JCLBNCKCOCJ(KeepsakeProgressionEventInstancesDTO result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x56D46B0", Offset = "0x56D2CB0", VA = "0x1856D46B0")]
		internal void DKJKMKMJODD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x56D5090", Offset = "0x56D3690", VA = "0x1856D5090")]
		internal MFBKDKPGMNP<IEnumerable<Guid>> DIBGCDIHNIM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x3A74060", Offset = "0x3A72660", VA = "0x183A74060")]
		internal bool MPNDHEBPIBD(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class EEBOGIDBHBK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public KeepsakeRoomInstanceIdsDTO instancesInRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public KLKIAMBGJDC CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public EEBOGIDBHBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x56C5750", Offset = "0x56C3D50", VA = "0x1856C5750")]
		internal MFBKDKPGMNP<IEnumerable<Guid>> PPKFAIMOBMJ(KeepsakeRoomInstancesDTO roomInstancesDTO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class NJJHPPIBJMM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public KeepsakeRoomInstancesDTO roomInstancesDTO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public EEBOGIDBHBK CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public NJJHPPIBJMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x56D5A90", Offset = "0x56D4090", VA = "0x1856D5A90")]
		internal bool LMLNFEAEGFK(Guid instanceId)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class ACEMONCJCKJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Guid instanceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public NJJHPPIBJMM CS$<>8__locals3;

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public ACEMONCJCKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x56C4BF0", Offset = "0x56C31F0", VA = "0x1856C4BF0")]
		internal bool MLCCAKJHCCP(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class IHOKNDGNOCE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public FNKNJGBLBHO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public IHOKNDGNOCE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x56D4AF0", Offset = "0x56D30F0", VA = "0x1856D4AF0")]
		internal MFBKDKPGMNP<IEnumerable<Guid>> DHIOIJMLIOK(IEnumerable<Guid> instanceIds)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x56C5320", Offset = "0x56C3920", VA = "0x1856C5320")]
		internal bool AFNCDMDGIKE(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class HHLLCDEEPAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public FNKNJGBLBHO <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public HHLLCDEEPAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x56D4330", Offset = "0x56D2930", VA = "0x1856D4330")]
		internal void IMAJJCBJDDD(KeepsakeProgressionEventInstancesDTO result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x56D46B0", Offset = "0x56D2CB0", VA = "0x1856D46B0")]
		internal void MILFHJMMFAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x56D43B0", Offset = "0x56D29B0", VA = "0x1856D43B0")]
		internal MFBKDKPGMNP<Dictionary<Guid, KNBGGKHAOAH>> LJLEFJPHHNN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x3A74060", Offset = "0x3A72660", VA = "0x183A74060")]
		internal bool OIECIICPLMN(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class MFDCJBJIGMO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public KeepsakeRoomInstanceIdsDTO instancesInRoom;

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public MFDCJBJIGMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x56D58C0", Offset = "0x56D3EC0", VA = "0x1856D58C0")]
		internal MFBKDKPGMNP<Dictionary<Guid, KNBGGKHAOAH>> GKEONDDECDA(KeepsakeRoomInstancesDTO roomInstancesDTO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class CPGAKAPPLNG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public KeepsakeRoomInstancesDTO roomInstancesDTO;

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public CPGAKAPPLNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x56C50B0", Offset = "0x56C36B0", VA = "0x1856C50B0")]
		internal bool JJGDPJDDIHM(Guid instanceId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x56C51A0", Offset = "0x56C37A0", VA = "0x1856C51A0")]
		internal KeyValuePair<Guid, KNBGGKHAOAH> NHBBAPHLDBE(Guid instanceId)
		{
			return default(KeyValuePair<Guid, KNBGGKHAOAH>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class FGAHKHDOBAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public Guid instanceId;

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public FGAHKHDOBAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x56C5F30", Offset = "0x56C4530", VA = "0x1856C5F30")]
		internal bool DAJFHCFHELP(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class IOMCMELABHM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public Guid instanceId;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public IOMCMELABHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x56D4D90", Offset = "0x56D3390", VA = "0x1856D4D90")]
		internal bool MJMHIPMDEIK(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class DFKMNCDLAEM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public FNKNJGBLBHO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public DFKMNCDLAEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x56C5340", Offset = "0x56C3940", VA = "0x1856C5340")]
		internal MFBKDKPGMNP<Dictionary<Guid, KNBGGKHAOAH>> PAFGOEAHLLF(Dictionary<Guid, KNBGGKHAOAH> instanceIdsAndCategories)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x56C5320", Offset = "0x56C3920", VA = "0x1856C5320")]
		internal bool GCHFEMDGBAL(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class BNMFEJBKFNG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public KeepsakeRoomInstanceIdsDTO collectedInstanceIds;

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public BNMFEJBKFNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x56C4FA0", Offset = "0x56C35A0", VA = "0x1856C4FA0")]
		internal bool EEDBDNCMEAG(KeyValuePair<Guid, KNBGGKHAOAH> idCategoryPair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class OHNPPIDBNNI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public Dictionary<Guid, KNBGGKHAOAH> instanceIdsAndCategories;

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public OHNPPIDBNNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x56D5C90", Offset = "0x56D4290", VA = "0x1856D5C90")]
		internal KeyValuePair<KNBGGKHAOAH, int> DDLLPHIMAAD(KNBGGKHAOAH category)
		{
			return default(KeyValuePair<KNBGGKHAOAH, int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class LHONDAAPOBG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public KNBGGKHAOAH category;

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public LHONDAAPOBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0xEC15C0", Offset = "0xEBFBC0", VA = "0x180EC15C0")]
		internal bool DJFBDKPMOMI(KNBGGKHAOAH instanceCategory)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class DGMIPBELLPC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public Dictionary<Guid, KNBGGKHAOAH> instanceIdsAndCategories;

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public DGMIPBELLPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x56C5560", Offset = "0x56C3B60", VA = "0x1856C5560")]
		internal KeyValuePair<KNBGGKHAOAH, int> AMPMILCOGOC(KNBGGKHAOAH category)
		{
			return default(KeyValuePair<KNBGGKHAOAH, int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class GFMHDOHEBEC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public KNBGGKHAOAH category;

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public GFMHDOHEBEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0xEC15C0", Offset = "0xEBFBC0", VA = "0x180EC15C0")]
		internal bool LLHAGHLEIPK(KNBGGKHAOAH instanceCategory)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class MCIJCAMFFLN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public FNKNJGBLBHO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public Func<KeepsakeRoomDTO, bool> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public MCIJCAMFFLN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x56D5710", Offset = "0x56D3D10", VA = "0x1856D5710")]
		internal bool LKEPBGNEMJE(DateTime nowUtc, DateTime eventStartTime, int roomOrder, TimeSpan unlockStartOffset, TimeSpan unlockInterval, int unlockBatchSize)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x56D57F0", Offset = "0x56D3DF0", VA = "0x1856D57F0")]
		internal bool MGPACJKFOGL(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x56D56F0", Offset = "0x56D3CF0", VA = "0x1856D56F0")]
		internal bool FONNAPLOBOP(KeepsakeRoomDTO r)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x56D56F0", Offset = "0x56D3CF0", VA = "0x1856D56F0")]
		internal bool GHBEOIANKMG(KeepsakeRoomDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class MAPGFHLCCJN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public MAPGFHLCCJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0xCDF840", Offset = "0xCDDE40", VA = "0x180CDF840")]
		internal bool BOJFOCAEJIE(KeepsakeRoomListDTO roomList)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class OBKOIPCDEAA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public Func<KeepsakeRoomDTO, bool> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public OBKOIPCDEAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x56D5BC0", Offset = "0x56D41C0", VA = "0x1856D5BC0")]
		internal bool LNGELOIMPJB(KeepsakeRoomListDTO roomList)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0xA61200", Offset = "0xA5F800", VA = "0x180A61200")]
		internal bool FBPLDGJDHDE(KeepsakeRoomDTO room)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class JOOIGONNIBG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public JOOIGONNIBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x56D5020", Offset = "0x56D3620", VA = "0x1856D5020")]
		internal bool IKAGENEHBHJ(KeepsakeRoomListDTO i)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class DOJAKBNDPNO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public DOJAKBNDPNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0xCDF840", Offset = "0xCDDE40", VA = "0x180CDF840")]
		internal bool HLIOAFILEKM(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class EAAHFEKFCMD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public Guid keepsakeInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public EAAHFEKFCMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x56C56C0", Offset = "0x56C3CC0", VA = "0x1856C56C0")]
		internal bool MGIIPAPAFGG(KeyValuePair<Guid, KeepsakeInstanceDTO> instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class FINMOJFMFBL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public KNBGGKHAOAH keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public FINMOJFMFBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0xA57920", Offset = "0xA55F20", VA = "0x180A57920")]
		internal bool JGCAJLPPBIG(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class CDLAKMOMOEM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public Guid keepsakeInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public CDLAKMOMOEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x56C5020", Offset = "0x56C3620", VA = "0x1856C5020")]
		internal bool IKIEHAKMHCE(KeyValuePair<Guid, KeepsakeInstanceDTO> instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class IOGDHOOOKHJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public KNBGGKHAOAH keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public IOGDHOOOKHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x56D4D50", Offset = "0x56D3350", VA = "0x1856D4D50")]
		internal bool DBAAJNMGHAK(KeyValuePair<Guid, KNBGGKHAOAH> x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class FHMJFCHHGBD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public KNBGGKHAOAH newKeepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public FHMJFCHHGBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0xA57920", Offset = "0xA55F20", VA = "0x180A57920")]
		internal bool JJIEEHHLDIA(KeepsakeInstanceDTO instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class GALEFDNOAHA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public long currentRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public long? currentSubRoomId;

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public GALEFDNOAHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x56D3D70", Offset = "0x56D2370", VA = "0x1856D3D70")]
		internal bool CHPNFFPJIJN(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class IJEOLPBAJCE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public IEnumerable<KeepsakeRoomListDTO> roomList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public IJEOLPBAJCE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x56D4C60", Offset = "0x56D3260", VA = "0x1856D4C60")]
		internal bool EGIAIPPCMCL(KeepsakeRoomDTO room)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class LDCDCIMDMNI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public KeepsakeRoomDTO room;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public IJEOLPBAJCE CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public LDCDCIMDMNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x56D5670", Offset = "0x56D3C70", VA = "0x1856D5670")]
		internal bool GDMKPMKEALJ(KeepsakeRoomListDTO roomListDto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class GJCDKIPJJBO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public HPPFBMKNACJ args;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public FNKNJGBLBHO <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public GJCDKIPJJBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x56D3E00", Offset = "0x56D2400", VA = "0x1856D3E00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class JEMGBDGMDNO : IAsyncStateMachine
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
		public FNKNJGBLBHO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public JEMGBDGMDNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x56D4E30", Offset = "0x56D3430", VA = "0x1856D4E30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly DateTime EEMCKFFFHDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly HJLLNBFEKHA IBOMCPNHIPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly GGACDJMDAAB IGAMACBLAEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly EDHFGBFECKH EOPNNJBKOLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly OHBBAOODGPM CHMIFBGAPMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly GHEEEKAANKE NFJMKMEECBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly JNNNFGCNLAL CLJLNLANOJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly IBEEOJCHKLH PMOJCGICPMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly NHMGFKECDEN EBEPKFPCHFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly NAFBOPBOONI AGHCGJDMPII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly GFMKMAPNKHB FFLFMEDBKNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly BLJANPFJMDG AMHOEFNIHNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly PHBFHDOHOPM ECJAFCHPPLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly HHNEEKPNBHP NPDIMHPPOLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly ABBJGACGOFG PCCLEKIMKLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly HLAAOIMKODK NJMEHFFCGKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly LLLOGEPNBFK<KeepsakesConfig.KeepsakesOptions> IGLCGHPCAIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly PNJKGCEFNDF CCNKOPKDIJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly Dictionary<Guid, KeepsakeInstanceDTO> JCFNJEDMEFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly HashSet<Guid> NNOGKJGGDEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly HashSet<long> GDNKJONEHJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private Dictionary<KNBGGKHAOAH, int> KLDAHDHEFAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly HashSet<Guid> KEJFFIIMIPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly IDisposable DLFIOCLGFED;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private Task CCDNBANNONI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private MFBKDKPGMNP<Guid> HEAGJKONMHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private long? DHPGCDLKMFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private KeepsakeProgressionEventInstancesDTO IKIAFGGICEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private MFBKDKPGMNP<KeepsakeProgressionEventInstancesDTO> AIIAJOLPCFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private IReadOnlyDictionary<KNBGGKHAOAH, KeepsakeCategoryConfigDTO> FOMMPKOLFKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private KeepsakeGlobalConfigDTO HAIBNJLMILP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private HashSet<long> JAOFLOBCCJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private HashSet<long> ILIKPIIIHAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private List<KeepsakeRoomListDTO> HFIPFCABFNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private List<KeepsakeRoomListDTO> HHCMFNCDNDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private List<KeepsakeRoomListDTO> GBCCOBOEOEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private Dictionary<long, string> FLNBHAAHCGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private Dictionary<long, string> NGBMEPJBOKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private Dictionary<long, DateTime> FGBLHPLJNOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private Dictionary<long, List<KeepsakeRoomDTO>> OEDLCMDKIBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private Dictionary<long, List<KeepsakeRoomDTO>> GMPIKGHHODE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private Dictionary<long, long> LEONHJKOFKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly List<string> IPGHMPKHNMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private DateTime PKELDELCFJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly IDisposable AEOELHOJEIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private Dictionary<Guid, KNBGGKHAOAH> IPAAGBEKDEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private Dictionary<KNBGGKHAOAH, int> AONICBIMCIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private List<KeepsakeCategoryThemePair> JHKFLCABHDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private AOGENGOFHIG NOBEAEDPIBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private bool MODPDKBJIJK;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool HIKFJFNJJPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xA2E160", Offset = "0xA2C760", VA = "0x180A2E160", Slot = "53")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xA2DCC0", Offset = "0xA2C2C0", VA = "0x180A2DCC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool HHMAMPOHJCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x56CE8F0", Offset = "0x56CCEF0", VA = "0x1856CE8F0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool CKFGAFJFFDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x56C8150", Offset = "0x56C6750", VA = "0x1856C8150", Slot = "36")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private long NEMJLAKMDLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x56D1150", Offset = "0x56CF750", VA = "0x1856D1150")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private long? JENONNCDFCK
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x56CA5D0", Offset = "0x56C8BD0", VA = "0x1856CA5D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private bool MLGPKECJFPN
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x56CA340", Offset = "0x56C8940", VA = "0x1856CA340")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public IReadOnlyList<KeepsakeRoomListDTO> NDEFNKFFFLF
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x12D68D0", Offset = "0x12D4ED0", VA = "0x1812D68D0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IReadOnlyList<KeepsakeRoomListDTO> GMFDPHNNEFK
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x12D68C0", Offset = "0x12D4EC0", VA = "0x1812D68C0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public IReadOnlyList<KeepsakeRoomListDTO> NGKEKIOMMNP
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xC9D6B0", Offset = "0xC9BCB0", VA = "0x180C9D6B0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public IReadOnlyDictionary<long, string> DPFHAPGDCKE
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xBE5660", Offset = "0xBE3C60", VA = "0x180BE5660", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	internal bool FHOKODCFOFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x1303A60", Offset = "0x1302060", VA = "0x181303A60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Guid?> CJDNHCDKGIG
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x56C9A80", Offset = "0x56C8080", VA = "0x1856C9A80", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x56CDBD0", Offset = "0x56CC1D0", VA = "0x1856CDBD0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action PKFKAJAHCLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x56C8220", Offset = "0x56C6820", VA = "0x1856C8220", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x56C6A90", Offset = "0x56C5090", VA = "0x1856C6A90", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action CNHABPKENFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x56C9340", Offset = "0x56C7940", VA = "0x1856C9340", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x56C73D0", Offset = "0x56C59D0", VA = "0x1856C73D0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x56D2A50", Offset = "0x56D1050", VA = "0x1856D2A50")]
	[Preserve]
	internal FNKNJGBLBHO([NotNull][BBBJPGKHPHG(null)] HJLLNBFEKHA IBOMCPNHIPG, [NotNull][BBBJPGKHPHG(null)] KCKEMPJGGPD MOMHLCALFKA, [NotNull][BBBJPGKHPHG(null)] GGACDJMDAAB IGAMACBLAEE, [NotNull][BBBJPGKHPHG(null)] EDHFGBFECKH EOPNNJBKOLJ, [NotNull][BBBJPGKHPHG(null)] OHBBAOODGPM CHMIFBGAPMN, [NotNull][BBBJPGKHPHG(null)] GHEEEKAANKE NFJMKMEECBN, [NotNull][BBBJPGKHPHG(null)] JNNNFGCNLAL CLJLNLANOJL, [NotNull][BBBJPGKHPHG(null)] IBEEOJCHKLH PMOJCGICPMO, [NotNull][BBBJPGKHPHG(null)] NHMGFKECDEN EBEPKFPCHFN, [NotNull][BBBJPGKHPHG(null)] OPJGCLOLEJA DCAEAAEIHAN, [NotNull][BBBJPGKHPHG(null)] NAFBOPBOONI AGHCGJDMPII, [NotNull][BBBJPGKHPHG(null)] GFMKMAPNKHB FFLFMEDBKNP, [NotNull][BBBJPGKHPHG(null)] BLJANPFJMDG AMHOEFNIHNB, [NotNull][BBBJPGKHPHG(null)] PHBFHDOHOPM ECJAFCHPPLI, [NotNull][BBBJPGKHPHG(null)] HHNEEKPNBHP NPDIMHPPOLH, [NotNull][BBBJPGKHPHG(null)] ABBJGACGOFG PCCLEKIMKLJ, [NotNull][BBBJPGKHPHG(null)] HLAAOIMKODK NJMEHFFCGKE, [NotNull][BBBJPGKHPHG(null)] LLLOGEPNBFK<KeepsakesConfig.KeepsakesOptions> IGLCGHPCAIJ, [NotNull][BBBJPGKHPHG(null)] PNJKGCEFNDF CCNKOPKDIJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x56C8C30", Offset = "0x56C7230", VA = "0x1856C8C30", Slot = "15")]
	public bool DKKIJJLCNLH(List<string> PABDOPMBDIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x56C75C0", Offset = "0x56C5BC0", VA = "0x1856C75C0", Slot = "16")]
	public MFBKDKPGMNP<Guid> BPJFMBNIFPD(KNBGGKHAOAH GMLMLHACFDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x56CD160", Offset = "0x56CB760", VA = "0x1856CD160", Slot = "17")]
	public HHGLIBCDIDA JCGJFFFFOKJ(Guid ABCJLNPFGLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x56CF320", Offset = "0x56CD920", VA = "0x1856CF320", Slot = "18")]
	public HHGLIBCDIDA OABKJJDDCGB(Guid ABCJLNPFGLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x56CEB60", Offset = "0x56CD160", VA = "0x1856CEB60", Slot = "19")]
	public bool MIDHPHFPIHP(Guid ABCJLNPFGLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x56CECB0", Offset = "0x56CD2B0", VA = "0x1856CECB0", Slot = "20")]
	public bool MNINGHBLMHB(Guid ABCJLNPFGLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x56CCCB0", Offset = "0x56CB2B0", VA = "0x1856CCCB0")]
	public KeepsakeTheme IDPGOKMPIJF(Guid ABCJLNPFGLC)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x56CD550", Offset = "0x56CBB50", VA = "0x1856CD550")]
	public bool JLBCHJPOOOG(KNBGGKHAOAH GMLMLHACFDB, out KeepsakeTheme HLLFBCIFHPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x56D2320", Offset = "0x56D0920", VA = "0x1856D2320")]
	public List<KeepsakeTheme> PPLLEALICEC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x56CF6A0", Offset = "0x56CDCA0", VA = "0x1856CF6A0")]
	public int OFLLFELLOJD(KNBGGKHAOAH GMLMLHACFDB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x56CBF80", Offset = "0x56CA580", VA = "0x1856CBF80")]
	public KNBGGKHAOAH HEIFICLGALJ(Guid ABCJLNPFGLC)
	{
		return default(KNBGGKHAOAH);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x56C7470", Offset = "0x56C5A70", VA = "0x1856C7470", Slot = "34")]
	public List<KNBGGKHAOAH> BPAABFONEND()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x56C9FE0", Offset = "0x56C85E0", VA = "0x1856C9FE0", Slot = "35")]
	public IComparer<KNBGGKHAOAH> EMLILALNPLA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x56CD3E0", Offset = "0x56CB9E0", VA = "0x1856CD3E0", Slot = "32")]
	public string JJEBDFGBGML(KNBGGKHAOAH GMLMLHACFDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x56C82C0", Offset = "0x56C68C0", VA = "0x1856C82C0", Slot = "33")]
	public string CNILGIEJMBD(KNBGGKHAOAH GMLMLHACFDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x56CE0D0", Offset = "0x56CC6D0", VA = "0x1856CE0D0", Slot = "21")]
	public bool LAKBHHOLDBL(Guid ABCJLNPFGLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x56CCE50", Offset = "0x56CB450", VA = "0x1856CCE50", Slot = "22")]
	public void IGCCEPDBDAP(Guid ABCJLNPFGLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x56CB480", Offset = "0x56C9A80", VA = "0x1856CB480", Slot = "23")]
	public void GCFHMJECPNM(KNBGGKHAOAH GMLMLHACFDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x56CD820", Offset = "0x56CBE20", VA = "0x1856CD820", Slot = "24")]
	public void JNBJAOCNCIE(Guid ABCJLNPFGLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x56CEEC0", Offset = "0x56CD4C0", VA = "0x1856CEEC0", Slot = "25")]
	public int NNMBGJECEBH()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x56D1F30", Offset = "0x56D0530", VA = "0x1856D1F30", Slot = "31")]
	public MFBKDKPGMNP<IEnumerable<Guid>> PIHDCGBGAFO(long AHLGFJPMMNL, long OHAAGCLGODK, KNBGGKHAOAH? GMLMLHACFDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x56CBBB0", Offset = "0x56CA1B0", VA = "0x1856CBBB0", Slot = "30")]
	public MFBKDKPGMNP<IEnumerable<Guid>> HAMLGNLOKPD(long AHLGFJPMMNL, long OHAAGCLGODK, KNBGGKHAOAH? GMLMLHACFDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x56D2670", Offset = "0x56D0C70", VA = "0x1856D2670", Slot = "54")]
	public MFBKDKPGMNP<Dictionary<Guid, KNBGGKHAOAH>> PPNALALNBJP(long AHLGFJPMMNL, long OHAAGCLGODK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x56CC8D0", Offset = "0x56CAED0", VA = "0x1856CC8D0", Slot = "55")]
	public MFBKDKPGMNP<Dictionary<Guid, KNBGGKHAOAH>> HLKGALNAABO(long AHLGFJPMMNL, long OHAAGCLGODK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x56CA080", Offset = "0x56C8680", VA = "0x1856CA080", Slot = "26")]
	public MFBKDKPGMNP<int> EPAOPPNCHIP(long AHLGFJPMMNL, long OHAAGCLGODK, KNBGGKHAOAH? GMLMLHACFDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x56C8720", Offset = "0x56C6D20", VA = "0x1856C8720", Slot = "27")]
	public MFBKDKPGMNP<int> DENBIDNNOCL(long AHLGFJPMMNL, long OHAAGCLGODK, KNBGGKHAOAH? GMLMLHACFDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x56CCA60", Offset = "0x56CB060", VA = "0x1856CCA60", Slot = "28")]
	public MFBKDKPGMNP<Dictionary<KNBGGKHAOAH, int>> HMFBDKGJPGK(long AHLGFJPMMNL, long OHAAGCLGODK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x56C9EB0", Offset = "0x56C84B0", VA = "0x1856C9EB0", Slot = "29")]
	public MFBKDKPGMNP<Dictionary<KNBGGKHAOAH, int>> EMDLLFFFLPB(long AHLGFJPMMNL, long OHAAGCLGODK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x56CE510", Offset = "0x56CCB10", VA = "0x1856CE510", Slot = "37")]
	public bool LLOFBLKCKHL(long AHLGFJPMMNL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x56D0F40", Offset = "0x56CF540", VA = "0x1856D0F40", Slot = "56")]
	public bool PDDHHNCLCIK(long AHLGFJPMMNL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x56C99E0", Offset = "0x56C7FE0", VA = "0x1856C99E0", Slot = "38")]
	public bool EAHEKHPPAJG(long AHLGFJPMMNL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x56CFB50", Offset = "0x56CE150", VA = "0x1856CFB50", Slot = "57")]
	public bool OLACJOOLACB(long AHLGFJPMMNL, out LLKAACAOHBA JCLELPKDILL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x56CED70", Offset = "0x56CD370", VA = "0x1856CED70", Slot = "39")]
	public bool NLDCAJGGDNB(long BICLHLPBJLE, out DateTime LEAOHKIKGNO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x56C6E20", Offset = "0x56C5420", VA = "0x1856C6E20", Slot = "40")]
	public long BEINOFAKLDP(long BICLHLPBJLE)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x56C9D90", Offset = "0x56C8390", VA = "0x1856C9D90", Slot = "41")]
	public long ELMJBGECFCM(long AHLGFJPMMNL)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x56C6C00", Offset = "0x56C5200", VA = "0x1856C6C00", Slot = "42")]
	public int BEEBAGPCFPH(long BICLHLPBJLE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x56CA920", Offset = "0x56C8F20", VA = "0x1856CA920", Slot = "43")]
	public bool FMNJDEOCFKB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x56CDE10", Offset = "0x56CC410", VA = "0x1856CDE10", Slot = "44")]
	public bool KHNOMCEEFAP(long BICLHLPBJLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x56C6790", Offset = "0x56C4D90", VA = "0x1856C6790", Slot = "45")]
	public IEnumerable<long> ADMBFJCAAOG(long BICLHLPBJLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x56CB3D0", Offset = "0x56C99D0", VA = "0x1856CB3D0", Slot = "46")]
	public int GBMMNENCMLK(long BICLHLPBJLE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x56D12C0", Offset = "0x56CF8C0", VA = "0x1856D12C0", Slot = "50")]
	public long PGAODPECFNN(long OOFGIKBNHBN)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x56CB020", Offset = "0x56C9620", VA = "0x1856CB020", Slot = "51")]
	public KNBGGKHAOAH GBLPPNMHKHO()
	{
		return default(KNBGGKHAOAH);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x56C6280", Offset = "0x56C4880", VA = "0x1856C6280")]
	private bool ADAAOBOPCDE(Guid ABCJLNPFGLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x56CC0F0", Offset = "0x56CA6F0", VA = "0x1856CC0F0")]
	private void HJCIFMCMACN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x56CC5D0", Offset = "0x56CABD0", VA = "0x1856CC5D0")]
	private KNBGGKHAOAH HKDAJIFECBL()
	{
		return default(KNBGGKHAOAH);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x56D15F0", Offset = "0x56CFBF0", VA = "0x1856D15F0")]
	private void PGEHHDFOHFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x56D0FA0", Offset = "0x56CF5A0", VA = "0x1856D0FA0")]
	private int PDIANOBNLIP(KeepsakeRoomListDTO PBINNHKHJNC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x56CB4C0", Offset = "0x56C9AC0", VA = "0x1856CB4C0")]
	private int GJPBFHJFFPA(DateTime HLMCBGPMMFJ, DateTime OFLDHCBMAFM, TimeSpan AGIMHJHOOPK, int AIFKKNJMMNC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x56C9B20", Offset = "0x56C8120", VA = "0x1856C9B20")]
	private void ECGMCAKNFCG(IEnumerable<KeepsakeInstanceDTO> JCFNJEDMEFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x56C8F40", Offset = "0x56C7540", VA = "0x1856C8F40")]
	private void DLMKAMNIFOH(IEnumerable<KeepsakeCollectionRecordDTO> GDNJIBIHBFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x56CE490", Offset = "0x56CCA90", VA = "0x1856CE490")]
	private void LDKJMPMEEHG(IEnumerable<long> JCCGNDBGICD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0xC998A0", Offset = "0xC97EA0", VA = "0x180C998A0")]
	private void DBILKBFAGEF(KeepsakeGlobalConfigDTO HAIBNJLMILP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x56C5FD0", Offset = "0x56C45D0", VA = "0x1856C5FD0")]
	private bool AALEGHMMEHP(KNBGGKHAOAH GMLMLHACFDB, out Guid MBCOBIGACGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x56C8650", Offset = "0x56C6C50", VA = "0x1856C8650")]
	private bool DCMPDOAEADL(out Guid MBCOBIGACGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x56CDA70", Offset = "0x56CC070", VA = "0x1856CDA70")]
	private bool KADIGNHLJFA(Guid ABCJLNPFGLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x56C91E0", Offset = "0x56C77E0", VA = "0x1856C91E0")]
	private IEnumerable<Guid> DNMICHGDKCH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x56C6B30", Offset = "0x56C5130", VA = "0x1856C6B30")]
	private IEnumerable<KeepsakeInstanceDTO> BBKBJKCFALG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x56CECE0", Offset = "0x56CD2E0", VA = "0x1856CECE0")]
	private void NEFGEOJAHEE(Guid ABCJLNPFGLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x56CDB20", Offset = "0x56CC120", VA = "0x1856CDB20")]
	private bool KCAGBDBMIHN(Guid ABCJLNPFGLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x56CDC70", Offset = "0x56CC270", VA = "0x1856CDC70")]
	private void KFHDHHFHIHI(Guid ABCJLNPFGLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x56CD000", Offset = "0x56CB600", VA = "0x1856CD000")]
	private void IKBCDMOAIAJ(KNBGGKHAOAH ILLGCEENAAK, int MBDJOKIBPCM, ref Dictionary<KNBGGKHAOAH, int> LFKBLEIAOLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x56CD720", Offset = "0x56CBD20", VA = "0x1856CD720")]
	private int JLKLHOFBMNF(KNBGGKHAOAH GMLMLHACFDB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x56CAE60", Offset = "0x56C9460", VA = "0x1856CAE60")]
	private void FOHEKFKENLJ(KeepsakeInstanceDTO BHILOJCFFIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x56CE960", Offset = "0x56CCF60", VA = "0x1856CE960")]
	private void MCKHLLJFOBN(KeepsakeInstanceDTO BHILOJCFFIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x56CE570", Offset = "0x56CCB70", VA = "0x1856CE570")]
	private void LPICMKCAFKB(Guid ABCJLNPFGLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x56C9180", Offset = "0x56C7780", VA = "0x1856C9180")]
	private void DMICPPCJOJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x56CCC90", Offset = "0x56CB290", VA = "0x1856CCC90")]
	private void IDJOGOBBFIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x56CD0E0", Offset = "0x56CB6E0", VA = "0x1856CD0E0")]
	private void IPAOBFOLBMC(ALHKALIJBLN HACPLKNDIBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x56C9F80", Offset = "0x56C8580", VA = "0x1856C9F80")]
	private void EMEBALPEKPI(EBGFEPHIFBL.AJFDODKLKCB NKFOPKJGBEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x56C8970", Offset = "0x56C6F70", VA = "0x1856C8970")]
	private void DIPILCPDBIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x56C63C0", Offset = "0x56C49C0", VA = "0x1856C63C0")]
	private void ADBLAHIFPNC(float CHAEBCLJGNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x56C7BF0", Offset = "0x56C61F0", VA = "0x1856C7BF0")]
	private void CFKKCFJEBPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x56C89D0", Offset = "0x56C6FD0", VA = "0x1856C89D0")]
	private bool DJPKEIGNJOA(Guid ABCJLNPFGLC, out string DMCAOENAHMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x56C8A60", Offset = "0x56C7060", VA = "0x1856C8A60")]
	private bool DKIBBOFEJED(Guid ABCJLNPFGLC, out KeepsakeCategoryConfigDTO ILLGCEENAAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x56C8890", Offset = "0x56C6E90", VA = "0x1856C8890")]
	private void DGEALHEKIKK(string BMMKDMLAIOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x56C6970", Offset = "0x56C4F70", VA = "0x1856C6970")]
	private bool AJFNLJNGOHJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x56D0C60", Offset = "0x56CF260", VA = "0x1856D0C60")]
	private IEnumerable<long> PAHKKIEAGMO(IEnumerable<KeepsakeRoomDTO> LPDINEKOILC, IEnumerable<KeepsakeRoomListDTO> DJPDKPLOINA, long BICLHLPBJLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x56CB5F0", Offset = "0x56C9BF0", VA = "0x1856CB5F0")]
	private bool GOGKLFDEGJJ(Guid ABCJLNPFGLC, out string PMBGBHCKNKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x56C9D30", Offset = "0x56C8330", VA = "0x1856C9D30", Slot = "47")]
	public string EFJCMOOMING(GJABPMEGKCN HBCGBCEJEDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x56CAA10", Offset = "0x56C9010", VA = "0x1856CAA10", Slot = "49")]
	public string FNOAJCPHGGK(GJABPMEGKCN HBCGBCEJEDE, long AHLGFJPMMNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x56CE370", Offset = "0x56CC970", VA = "0x1856CE370", Slot = "48")]
	public string LCOKFCJFALM(GJABPMEGKCN HBCGBCEJEDE, int LBEJMAKALIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x56CFF10", Offset = "0x56CE510", VA = "0x1856CFF10")]
	private void OOOMFKBGFCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x56CCEC0", Offset = "0x56CB4C0", VA = "0x1856CCEC0")]
	private void IGFCMMIHDJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x56C6E00", Offset = "0x56C5400", VA = "0x1856C6E00")]
	private GJABPMEGKCN BEEHEOKDECA(AJBAOAFEGGP MBCHDCMKPDK)
	{
		return default(GJABPMEGKCN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x56CE4F0", Offset = "0x56CCAF0", VA = "0x1856CE4F0")]
	private GJABPMEGKCN LJMBLONFICK(AJBAOAFEGGP MBCHDCMKPDK)
	{
		return default(GJABPMEGKCN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x56CF970", Offset = "0x56CDF70", VA = "0x1856CF970")]
	internal static string OKEMDMFBMPB(GMBGKNENFHK KBKPPPFJEMF, string PKJNAHEAKNK, bool PPNODAMFPAP, int ANHDDBEIOOD, int LEACADMKPNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x56C9580", Offset = "0x56C7B80", VA = "0x1856C9580", Slot = "52")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x56C8430", Offset = "0x56C6A30", VA = "0x1856C8430")]
	private PKIEGMKHMOF COOEDBEAODE(EGKKDNKLFAD MALFMJMCNPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x56C93E0", Offset = "0x56C79E0", VA = "0x1856C93E0")]
	private FMHOAJDHLNO DPGKOKDGKJJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x56D1BA0", Offset = "0x56D01A0", VA = "0x1856D1BA0")]
	private Task PGNJCCIGLNP(HPPFBMKNACJ CHPIMGNELOI, CancellationToken KEGMOCPJOHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x56CF800", Offset = "0x56CDE00", VA = "0x1856CF800")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(GJCDKIPJJBO))]
	private Task OHCGGFGHEFL(HPPFBMKNACJ CHPIMGNELOI, CancellationToken KEGMOCPJOHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x56D1220", Offset = "0x56CF820", VA = "0x1856D1220")]
	private Task PFEALLMEGFO(HPPFBMKNACJ CHPIMGNELOI, CancellationToken KEGMOCPJOHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x56C84C0", Offset = "0x56C6AC0", VA = "0x1856C84C0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JEMGBDGMDNO))]
	private Task DAMBALFEIJB(string DPAJDIEBNKM, TimeSpan PGDMLIPFPGI, CancellationToken KEGMOCPJOHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x4077450", Offset = "0x4075A50", VA = "0x184077450")]
	[CompilerGenerated]
	private void MIOHNLMBDOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x56CDAD0", Offset = "0x56CC0D0", VA = "0x1856CDAD0")]
	[CompilerGenerated]
	private void KBLACOPDGGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x56CA4E0", Offset = "0x56C8AE0", VA = "0x1856CA4E0")]
	[CompilerGenerated]
	private bool FCDKFNAAAFO(KeepsakeInstanceDTO HEICJNINGBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x56C7250", Offset = "0x56C5850", VA = "0x1856C7250")]
	[CompilerGenerated]
	private MFBKDKPGMNP<Dictionary<KNBGGKHAOAH, int>> BJIJOADLOAK(Dictionary<Guid, KNBGGKHAOAH> HFCJFHDNFCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x56CA360", Offset = "0x56C8960", VA = "0x1856CA360")]
	[CompilerGenerated]
	private MFBKDKPGMNP<Dictionary<KNBGGKHAOAH, int>> FBCBNGCBCGA(Dictionary<Guid, KNBGGKHAOAH> HFCJFHDNFCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x56CE940", Offset = "0x56CCF40", VA = "0x1856CE940")]
	[CompilerGenerated]
	private bool MBEBAFNOCJJ(KeepsakeRoomListDTO HEICJNINGBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x56CA670", Offset = "0x56C8C70", VA = "0x1856CA670")]
	[CompilerGenerated]
	private bool FHKGBANKKKK(KeepsakeInstanceDTO HEICJNINGBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x56CA7A0", Offset = "0x56C8DA0", VA = "0x1856CA7A0")]
	[CompilerGenerated]
	private void FLIAFNHDKEJ(Tuple<KeepsakeRoomInstancesDTO, IReadOnlyDictionary<KNBGGKHAOAH, KeepsakeCategoryConfigDTO>, KeepsakeGlobalConfigDTO> JKLIJHGHNNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x56CB590", Offset = "0x56C9B90", VA = "0x1856CB590")]
	[CompilerGenerated]
	private void GNLMBNJEPJO(string PMBGBHCKNKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x56CBD50", Offset = "0x56CA350", VA = "0x1856CBD50")]
	[CompilerGenerated]
	private Task HDKPPFKKHED(CancellationToken ELHMLJDBGBI)
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
