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
	public class _AssemblyIndex : KNLEODIDJOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6D93890", Offset = "0x6D92C90", VA = "0x186D93890", Slot = "8")]
		public override void LFFFLDDGBMJ(GFPLBLFDLJF registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x63F5FE0", Offset = "0x63F53E0", VA = "0x1863F5FE0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class AGJHEIMPGBN : IComparer<MKNCOJELGGF>
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private sealed class IPMPKNNEMHI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public MKNCOJELGGF x;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public MKNCOJELGGF y;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
		public IPMPKNNEMHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x91A3C0", Offset = "0x9197C0", VA = "0x18091A3C0")]
		internal bool NCEMNJOAHIB(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x1788910", Offset = "0x1787D10", VA = "0x181788910")]
		internal bool MNPBMNBCMHF(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x91A3C0", Offset = "0x9197C0", VA = "0x18091A3C0")]
		internal bool HJFHMGAICKH(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1788910", Offset = "0x1787D10", VA = "0x181788910")]
		internal bool NOKKEAIBFCA(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private List<KeepsakeCategoryThemePair> CGNCKOJKEDK;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x89A2A0", Offset = "0x8996A0", VA = "0x18089A2A0")]
	public AGJHEIMPGBN(List<KeepsakeCategoryThemePair> GMIAABJHIML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6D90420", Offset = "0x6D8F820", VA = "0x186D90420", Slot = "4")]
	public int Compare(MKNCOJELGGF KPPEBBOFEKD, MKNCOJELGGF EJAKPDCBGAD)
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
		public MKNCOJELGGF KeepsakeCategory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public KeepsakeTheme KeepsakeTheme;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[MMCIGIHMOCH]
public class ABEGOBJOEFJ : ODEEFHDECLP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class ANHFMILJLGJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public ABEGOBJOEFJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public MKNCOJELGGF keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
		public ANHFMILJLGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6D90700", Offset = "0x6D8FB00", VA = "0x186D90700")]
		internal ELLFHPNCMJG<Guid> JPKMJJEOMKB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6D906D0", Offset = "0x6D8FAD0", VA = "0x186D906D0")]
		internal void FKIJHMMLCEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6D90850", Offset = "0x6D8FC50", VA = "0x186D90850")]
		internal void NBLIMPKHIJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6D908B0", Offset = "0x6D8FCB0", VA = "0x186D908B0")]
		internal void OHBCALCLKEG(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6D90CC0", Offset = "0x6D900C0", VA = "0x186D90CC0")]
		internal void PCFGFMOFCNF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class NDAEIAFGHMN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public ABEGOBJOEFJ <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
		public NDAEIAFGHMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6D92F90", Offset = "0x6D92390", VA = "0x186D92F90")]
		internal void ENDPIPJAAOG(OMNFHIHKBLL response)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6D93340", Offset = "0x6D92740", VA = "0x186D93340")]
		internal void KIELBKBFKIC(string error)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class NFMKPKJAIBN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public KeepsakeTheme theme;

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
		public NFMKPKJAIBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x6D935D0", Offset = "0x6D929D0", VA = "0x186D935D0")]
		internal bool BMGLJEFHIPJ(KeepsakeCategoryThemePair categoryThemePair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class HNFCFBFIGEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public ABEGOBJOEFJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public long progressionEventId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public MKNCOJELGGF? keepsakeCategory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
		public HNFCFBFIGEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6D91F20", Offset = "0x6D91320", VA = "0x186D91F20")]
		internal void PLGHCAFPEMB(KeepsakeProgressionEventInstancesDTO result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x6D91870", Offset = "0x6D90C70", VA = "0x186D91870")]
		internal void LMKAEEEIDLN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x6D91C20", Offset = "0x6D91020", VA = "0x186D91C20")]
		internal ELLFHPNCMJG<IEnumerable<Guid>> ILNBNAAMMDL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x69CF460", Offset = "0x69CE860", VA = "0x1869CF460")]
		internal bool BEGENJNEOFP(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class DHKEHFHMCHH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public KeepsakeRoomInstanceIdsDTO instancesInRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public HNFCFBFIGEF CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
		public DHKEHFHMCHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x6D91140", Offset = "0x6D90540", VA = "0x186D91140")]
		internal ELLFHPNCMJG<IEnumerable<Guid>> LEPJFHKDFFP(KeepsakeRoomInstancesDTO roomInstancesDTO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class CANOLMHMHEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public KeepsakeRoomInstancesDTO roomInstancesDTO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public DHKEHFHMCHH CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
		public CANOLMHMHEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x6D90F20", Offset = "0x6D90320", VA = "0x186D90F20")]
		internal bool NPINCGJINBB(Guid instanceId)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class FDBOAJMGGHP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Guid instanceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public CANOLMHMHEF CS$<>8__locals3;

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
		public FDBOAJMGGHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x6D91490", Offset = "0x6D90890", VA = "0x186D91490")]
		internal bool IAFFFDBDHGN(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class MKNFKCAIAAK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public ABEGOBJOEFJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
		public MKNFKCAIAAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x6D92E20", Offset = "0x6D92220", VA = "0x186D92E20")]
		internal ELLFHPNCMJG<IEnumerable<Guid>> ABLHMMLADOF(IEnumerable<Guid> instanceIds)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x6D92E00", Offset = "0x6D92200", VA = "0x186D92E00")]
		internal bool BOGCACPIHKB(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class HBAMJBHLPNH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public ABEGOBJOEFJ <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
		public HBAMJBHLPNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x6D91B90", Offset = "0x6D90F90", VA = "0x186D91B90")]
		internal void MHFAHBFEBHH(KeepsakeProgressionEventInstancesDTO result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x6D91870", Offset = "0x6D90C70", VA = "0x186D91870")]
		internal void BMCHKCDEHJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x6D918A0", Offset = "0x6D90CA0", VA = "0x186D918A0")]
		internal ELLFHPNCMJG<Dictionary<Guid, MKNCOJELGGF>> GEMGFJBCILP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x69CF460", Offset = "0x69CE860", VA = "0x1869CF460")]
		internal bool HNNHEJGLBMI(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class EMAIODFFIGN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public KeepsakeRoomInstanceIdsDTO instancesInRoom;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
		public EMAIODFFIGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x6D91280", Offset = "0x6D90680", VA = "0x186D91280")]
		internal ELLFHPNCMJG<Dictionary<Guid, MKNCOJELGGF>> PJAFBCDEICP(KeepsakeRoomInstancesDTO roomInstancesDTO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class NDHOLPGANEA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public KeepsakeRoomInstancesDTO roomInstancesDTO;

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
		public NDHOLPGANEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x6D934F0", Offset = "0x6D928F0", VA = "0x186D934F0")]
		internal bool KOEKMIJBFDC(Guid instanceId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6D933A0", Offset = "0x6D927A0", VA = "0x186D933A0")]
		internal KeyValuePair<Guid, MKNCOJELGGF> BNLCNNGAIJP(Guid instanceId)
		{
			return default(KeyValuePair<Guid, MKNCOJELGGF>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class KBIOOKPCDGL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public Guid instanceId;

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
		public KBIOOKPCDGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x1D08240", Offset = "0x1D07640", VA = "0x181D08240")]
		internal bool HDICNIPBGLB(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class JDDHJPCGGOB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public Guid instanceId;

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
		public JDDHJPCGGOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x1D08240", Offset = "0x1D07640", VA = "0x181D08240")]
		internal bool NAAPIALFNAK(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class LKBNJJAHJFC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public ABEGOBJOEFJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
		public LKBNJJAHJFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x6D92C00", Offset = "0x6D92000", VA = "0x186D92C00")]
		internal ELLFHPNCMJG<Dictionary<Guid, MKNCOJELGGF>> DNOKIIABCIF(Dictionary<Guid, MKNCOJELGGF> instanceIdsAndCategories)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x6D92E00", Offset = "0x6D92200", VA = "0x186D92E00")]
		internal bool HALLOMPKAFF(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class BIDAHBAFEEA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public KeepsakeRoomInstanceIdsDTO collectedInstanceIds;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
		public BIDAHBAFEEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x6D90D50", Offset = "0x6D90150", VA = "0x186D90D50")]
		internal bool KFFNJMPBEFH(KeyValuePair<Guid, MKNCOJELGGF> idCategoryPair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class CAIPNAFHAJL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public Dictionary<Guid, MKNCOJELGGF> instanceIdsAndCategories;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
		public CAIPNAFHAJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x6D90DD0", Offset = "0x6D901D0", VA = "0x186D90DD0")]
		internal KeyValuePair<MKNCOJELGGF, int> GCGGAHLLIIE(MKNCOJELGGF category)
		{
			return default(KeyValuePair<MKNCOJELGGF, int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class AKIBOEIBNHI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public MKNCOJELGGF category;

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
		public AKIBOEIBNHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x985A10", Offset = "0x984E10", VA = "0x180985A10")]
		internal bool MHILCNOIPAI(MKNCOJELGGF instanceCategory)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class IDEELKPEAFG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public Dictionary<Guid, MKNCOJELGGF> instanceIdsAndCategories;

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
		public IDEELKPEAFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x6D91FB0", Offset = "0x6D913B0", VA = "0x186D91FB0")]
		internal KeyValuePair<MKNCOJELGGF, int> AFABFMNBEFF(MKNCOJELGGF category)
		{
			return default(KeyValuePair<MKNCOJELGGF, int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class MBELNCEHJLE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public MKNCOJELGGF category;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
		public MBELNCEHJLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x985A10", Offset = "0x984E10", VA = "0x180985A10")]
		internal bool LFIBNFIDCKJ(MKNCOJELGGF instanceCategory)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class KHCMAPKCMHE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public ABEGOBJOEFJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public Func<KeepsakeRoomDTO, bool> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
		public KHCMAPKCMHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x6D92820", Offset = "0x6D91C20", VA = "0x186D92820")]
		internal bool NJHFJFMDEKL(DateTime nowUtc, DateTime eventStartTime, int roomOrder, TimeSpan unlockStartOffset, TimeSpan unlockInterval, int unlockBatchSize)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x6D92760", Offset = "0x6D91B60", VA = "0x186D92760")]
		internal bool FPNHLJOMNOF(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x6D92740", Offset = "0x6D91B40", VA = "0x186D92740")]
		internal bool ABJPLOGEPCP(KeepsakeRoomDTO r)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x6D92740", Offset = "0x6D91B40", VA = "0x186D92740")]
		internal bool ELCBMAGLPOK(KeepsakeRoomDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class GHPKPGJFGPP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
		public GHPKPGJFGPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x9EF0F0", Offset = "0x9EE4F0", VA = "0x1809EF0F0")]
		internal bool GCGALJLEFNM(KeepsakeRoomListDTO roomList)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class IJBEGCEKBJN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public Func<KeepsakeRoomDTO, bool> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
		public IJBEGCEKBJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x6D92680", Offset = "0x6D91A80", VA = "0x186D92680")]
		internal bool LMBFINEPFDI(KeepsakeRoomListDTO roomList)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x1CD4DE0", Offset = "0x1CD41E0", VA = "0x181CD4DE0")]
		internal bool IDIFHNHJPOB(KeepsakeRoomDTO room)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class ENPBLLNLLFH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
		public ENPBLLNLLFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x6D91430", Offset = "0x6D90830", VA = "0x186D91430")]
		internal bool LKBHKMIOFCE(KeepsakeRoomListDTO i)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class IPLEBHNAAIE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
		public IPLEBHNAAIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x9EF0F0", Offset = "0x9EE4F0", VA = "0x1809EF0F0")]
		internal bool GGDCHCLCPFI(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class BCEGJFKHNLE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public Guid keepsakeInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
		public BCEGJFKHNLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x6D90CF0", Offset = "0x6D900F0", VA = "0x186D90CF0")]
		internal bool PNHGLDGKFKP(KeyValuePair<Guid, KeepsakeInstanceDTO> instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class ACFFGIJIDJE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public MKNCOJELGGF keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
		public ACFFGIJIDJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x19A68D0", Offset = "0x19A5CD0", VA = "0x1819A68D0")]
		internal bool DCOEPJCNLEK(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class LEKMAACIPDA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public Guid keepsakeInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
		public LEKMAACIPDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x6D92BA0", Offset = "0x6D91FA0", VA = "0x186D92BA0")]
		internal bool EGENBGHKJAA(KeyValuePair<Guid, KeepsakeInstanceDTO> instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class KNOLMEEHKOG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public MKNCOJELGGF keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
		public KNOLMEEHKOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x6D92910", Offset = "0x6D91D10", VA = "0x186D92910")]
		internal bool JNLMFMLBIFL(KeyValuePair<Guid, MKNCOJELGGF> x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class MBIEJKBJBIK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public MKNCOJELGGF newKeepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
		public MBIEJKBJBIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x19A68D0", Offset = "0x19A5CD0", VA = "0x1819A68D0")]
		internal bool MEAELLBLIKB(KeepsakeInstanceDTO instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class NPOHIKPEGKK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public long currentRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public long? currentSubRoomId;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
		public NPOHIKPEGKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x6D935F0", Offset = "0x6D929F0", VA = "0x186D935F0")]
		internal bool PDBHELDFBNA(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class CIABJGPAFEA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public IEnumerable<KeepsakeRoomListDTO> roomList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
		public CIABJGPAFEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x6D91050", Offset = "0x6D90450", VA = "0x186D91050")]
		internal bool LEMDNBODDED(KeepsakeRoomDTO room)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class ABPCJIMJPBH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public KeepsakeRoomDTO room;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public CIABJGPAFEA CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
		public ABPCJIMJPBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x6D903A0", Offset = "0x6D8F7A0", VA = "0x186D903A0")]
		internal bool PKIOILFAILF(KeepsakeRoomListDTO roomListDto)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private struct IILLBKOMKLC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public ABEGOBJOEFJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public GPHLDHMLGGJ args;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x6D92100", Offset = "0x6D91500", VA = "0x186D92100", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x6D92620", Offset = "0x6D91A20", VA = "0x186D92620", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private struct GMFKOJHNHDN : IAsyncStateMachine
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
		public ABEGOBJOEFJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public string message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x6D91570", Offset = "0x6D90970", VA = "0x186D91570", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x6D91810", Offset = "0x6D90C10", VA = "0x186D91810", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly DateTime DKPEFPHONGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly DDOPJHKBPDP FAAKNKHFBIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly OOPGNMJEGLA DFKBCONKNAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly MIJMNPJDNGI GKGFKJMFKEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly CGLEIMDAFHD PFOMLJDPAJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly HLOIEDKIPGM DJDECIMNOJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly GDDMPFNJBGH CPGPCILBIIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly EGBJMEDMCPG GJACEOBHLAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly MMJFCIBDCMM EGCDCDMFENK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly LJMNIDLMNPF ELHIIOIJGLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly NKAGFNAOJKP ODLAGECBMIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly EPFGLFCPJOI OGOGNDFHAJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly INODJPNBOCN HIONPBCBEAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly CBDHBMDLCGM EPHPPIGEEOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly CCHAHIINPBN JJJCFMMGODF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly MBKGHNEMCHF GIHKDNFKCLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly MJGBEPJIPCF<KeepsakesConfig.KeepsakesOptions> POLCFNEEHMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly FGJGNMDINBC CINKBOJJCID;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly Dictionary<Guid, KeepsakeInstanceDTO> OPHPPAPPFIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly HashSet<Guid> NEFICANFBIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly HashSet<long> BBAHHIFJGHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private Dictionary<MKNCOJELGGF, int> PLOOAAJHJOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly HashSet<Guid> ACCKOMLLMEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly IDisposable JKABMDLPJIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private Task MKJPMLKDEKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private ELLFHPNCMJG<Guid> CKNIDCFBLJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private long? IBHENGKLEFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private KeepsakeProgressionEventInstancesDTO GMGAPLIMDII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private ELLFHPNCMJG<KeepsakeProgressionEventInstancesDTO> AMIEIHNCKKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private IReadOnlyDictionary<MKNCOJELGGF, KeepsakeCategoryConfigDTO> CAKEJOCOKMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private KeepsakeGlobalConfigDTO MKMDEGAMEFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private HashSet<long> DEJGEINNNHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private HashSet<long> HAKKCLCMCCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private List<KeepsakeRoomListDTO> MGOCINIKPCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private List<KeepsakeRoomListDTO> GMDJPIGNEBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private List<KeepsakeRoomListDTO> KPGHPFGDCHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private Dictionary<long, string> INNHJDMNGHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private Dictionary<long, string> AJHJEDEOKLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private Dictionary<long, DateTime> HDJBBAGBKDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private Dictionary<long, List<KeepsakeRoomDTO>> HAOKMNFOIMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private Dictionary<long, List<KeepsakeRoomDTO>> PHOIKCEAKDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private Dictionary<long, long> LCMPDDKMPPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly List<string> ONFLKGDPKDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private DateTime OHANDMICHCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly IDisposable BKBLOCPKDBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private Dictionary<Guid, MKNCOJELGGF> DGMECBCHNGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private Dictionary<MKNCOJELGGF, int> CCKNOAHJMDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private List<KeepsakeCategoryThemePair> GMIAABJHIML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private AGJHEIMPGBN BONCEGFKEAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private bool IDADKFIBPFL;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool PAFDHALHOAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x953920", Offset = "0x952D20", VA = "0x180953920", Slot = "53")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x94E700", Offset = "0x94DB00", VA = "0x18094E700")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool ELGHGIEENLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6D8ECC0", Offset = "0x6D8E0C0", VA = "0x186D8ECC0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool ILPDAKPFKBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6D8AC70", Offset = "0x6D8A070", VA = "0x186D8AC70", Slot = "36")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private long LAIEFFFNFJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6D841F0", Offset = "0x6D835F0", VA = "0x186D841F0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private long? DLCJFNEKDID
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6D8AB30", Offset = "0x6D89F30", VA = "0x186D8AB30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private bool FCCEHELIKML
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6D86600", Offset = "0x6D85A00", VA = "0x186D86600")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public IReadOnlyList<KeepsakeRoomListDTO> OGMPGCNGJBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x96D030", Offset = "0x96C430", VA = "0x18096D030", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public IReadOnlyList<KeepsakeRoomListDTO> HKNCKBMOOBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x905670", Offset = "0x904A70", VA = "0x180905670", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IReadOnlyList<KeepsakeRoomListDTO> BHFCJNDAGDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xA46120", Offset = "0xA45520", VA = "0x180A46120", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public IReadOnlyDictionary<long, string> KMNKIBICBBC
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x96D1C0", Offset = "0x96C5C0", VA = "0x18096D1C0", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	internal bool OLKMNMEMEGL
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x1C543E0", Offset = "0x1C537E0", VA = "0x181C543E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Guid?> FBKJKEHFHDI
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6D8C2D0", Offset = "0x6D8B6D0", VA = "0x186D8C2D0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6D8ABC0", Offset = "0x6D89FC0", VA = "0x186D8ABC0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action PEDCDNHAIIF
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6D84BA0", Offset = "0x6D83FA0", VA = "0x186D84BA0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6D892C0", Offset = "0x6D886C0", VA = "0x186D892C0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action KJLKACIHMGH
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6D851D0", Offset = "0x6D845D0", VA = "0x186D851D0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6D86530", Offset = "0x6D85930", VA = "0x186D86530", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6D8EDE0", Offset = "0x6D8E1E0", VA = "0x186D8EDE0")]
	[RecRoom.NoEngine.Common.Preserve]
	internal ABEGOBJOEFJ([NDMEANGLJKD(null)][NotNull] DDOPJHKBPDP FAAKNKHFBIK, [NotNull][NDMEANGLJKD(null)] NOCIHHILPOB NJDKELKJIBP, [NotNull][NDMEANGLJKD(null)] OOPGNMJEGLA DFKBCONKNAK, [NotNull][NDMEANGLJKD(null)] MIJMNPJDNGI GKGFKJMFKEF, [NDMEANGLJKD(null)][NotNull] CGLEIMDAFHD PFOMLJDPAJP, [NDMEANGLJKD(null)][NotNull] HLOIEDKIPGM DJDECIMNOJE, [NDMEANGLJKD(null)][NotNull] GDDMPFNJBGH CPGPCILBIIK, [NotNull][NDMEANGLJKD(null)] EGBJMEDMCPG GJACEOBHLAG, [NotNull][NDMEANGLJKD(null)] MMJFCIBDCMM EGCDCDMFENK, [NotNull][NDMEANGLJKD(null)] NKIKAMFFEAJ NIDOAMLIJDA, [NotNull][NDMEANGLJKD(null)] LJMNIDLMNPF ELHIIOIJGLM, [NotNull][NDMEANGLJKD(null)] NKAGFNAOJKP ODLAGECBMIJ, [NotNull][NDMEANGLJKD(null)] EPFGLFCPJOI OGOGNDFHAJA, [NotNull][NDMEANGLJKD(null)] INODJPNBOCN HIONPBCBEAH, [NDMEANGLJKD(null)][NotNull] CBDHBMDLCGM EPHPPIGEEOE, [NDMEANGLJKD(null)][NotNull] CCHAHIINPBN JJJCFMMGODF, [NotNull][NDMEANGLJKD(null)] MBKGHNEMCHF GIHKDNFKCLH, [NDMEANGLJKD(null)][NotNull] MJGBEPJIPCF<KeepsakesConfig.KeepsakesOptions> POLCFNEEHMO, [NotNull][NDMEANGLJKD(null)] FGJGNMDINBC CINKBOJJCID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6D8D140", Offset = "0x6D8C540", VA = "0x186D8D140", Slot = "15")]
	public bool OHMJMMHGLCN(List<string> OEOGNNOHFAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6D8A3A0", Offset = "0x6D897A0", VA = "0x186D8A3A0", Slot = "16")]
	public ELLFHPNCMJG<Guid> LJNJPIGKMGB(MKNCOJELGGF BLPMHNAODAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6D87670", Offset = "0x6D86A70", VA = "0x186D87670", Slot = "17")]
	public NNKCIMLKELB HLCBAKPAGMK(Guid PLOIFBAPGKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6D8BD70", Offset = "0x6D8B170", VA = "0x186D8BD70", Slot = "18")]
	public NNKCIMLKELB NEAEFHJFGLD(Guid PLOIFBAPGKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6D87140", Offset = "0x6D86540", VA = "0x186D87140", Slot = "19")]
	public bool HFJBJBGIHPL(Guid PLOIFBAPGKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6D86CC0", Offset = "0x6D860C0", VA = "0x186D86CC0", Slot = "20")]
	public bool GLODCMIEJHK(Guid PLOIFBAPGKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6D8C380", Offset = "0x6D8B780", VA = "0x186D8C380")]
	public KeepsakeTheme OALKGDACFDK(Guid PLOIFBAPGKK)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6D86E40", Offset = "0x6D86240", VA = "0x186D86E40")]
	public bool GOENMAMMNLP(MKNCOJELGGF BLPMHNAODAE, [Out] KeepsakeTheme KFMNEEDDPFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6D83E40", Offset = "0x6D83240", VA = "0x186D83E40")]
	public List<KeepsakeTheme> CGEGEPDENDD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6D83040", Offset = "0x6D82440", VA = "0x186D83040")]
	public int ALGKLFDAHMN(MKNCOJELGGF BLPMHNAODAE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6D8BC10", Offset = "0x6D8B010", VA = "0x186D8BC10")]
	public MKNCOJELGGF NDLNMKFJCII(Guid PLOIFBAPGKK)
	{
		return default(MKNCOJELGGF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6D86CF0", Offset = "0x6D860F0", VA = "0x186D86CF0", Slot = "34")]
	public List<MKNCOJELGGF> GMLOCAFAGFD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6D86470", Offset = "0x6D85870", VA = "0x186D86470", Slot = "35")]
	public IComparer<MKNCOJELGGF> FMFLEGKPDNO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6D8B070", Offset = "0x6D8A470", VA = "0x186D8B070", Slot = "32")]
	public string MHDDAGGANCA(MKNCOJELGGF BLPMHNAODAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6D862F0", Offset = "0x6D856F0", VA = "0x186D862F0", Slot = "33")]
	public string FLNOEHOBFJD(MKNCOJELGGF BLPMHNAODAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6D878F0", Offset = "0x6D86CF0", VA = "0x186D878F0", Slot = "21")]
	public bool HMADPEOCDKG(Guid PLOIFBAPGKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6D8ED70", Offset = "0x6D8E170", VA = "0x186D8ED70", Slot = "22")]
	public void PPMKLMACMHN(Guid PLOIFBAPGKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6D89890", Offset = "0x6D88C90", VA = "0x186D89890", Slot = "23")]
	public void JINLHFHHDJD(MKNCOJELGGF BLPMHNAODAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6D825F0", Offset = "0x6D819F0", VA = "0x186D825F0", Slot = "24")]
	public void AFCNBACPJJH(Guid PLOIFBAPGKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6D834E0", Offset = "0x6D828E0", VA = "0x186D834E0", Slot = "25")]
	public int BHGBFANELFI()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6D89C30", Offset = "0x6D89030", VA = "0x186D89C30", Slot = "31")]
	public ELLFHPNCMJG<IEnumerable<Guid>> JMOFKALFLGB(long HLKBDGNJMKK, long LJJDPDIPAJJ, MKNCOJELGGF? BLPMHNAODAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6D896F0", Offset = "0x6D88AF0", VA = "0x186D896F0", Slot = "30")]
	public ELLFHPNCMJG<IEnumerable<Guid>> JILMDEEFOPB(long HLKBDGNJMKK, long LJJDPDIPAJJ, MKNCOJELGGF? BLPMHNAODAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6D84C40", Offset = "0x6D84040", VA = "0x186D84C40", Slot = "54")]
	public ELLFHPNCMJG<Dictionary<Guid, MKNCOJELGGF>> EBNPKGBMCCF(long HLKBDGNJMKK, long LJJDPDIPAJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6D82BF0", Offset = "0x6D81FF0", VA = "0x186D82BF0", Slot = "55")]
	public ELLFHPNCMJG<Dictionary<Guid, MKNCOJELGGF>> AJMLLKDGEIL(long HLKBDGNJMKK, long LJJDPDIPAJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6D8D780", Offset = "0x6D8CB80", VA = "0x186D8D780", Slot = "26")]
	public ELLFHPNCMJG<int> OLGHJPDGNOF(long HLKBDGNJMKK, long LJJDPDIPAJJ, MKNCOJELGGF? BLPMHNAODAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6D83920", Offset = "0x6D82D20", VA = "0x186D83920", Slot = "27")]
	public ELLFHPNCMJG<int> BJAOECAADME(long HLKBDGNJMKK, long LJJDPDIPAJJ, MKNCOJELGGF? BLPMHNAODAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6D8AE60", Offset = "0x6D8A260", VA = "0x186D8AE60", Slot = "28")]
	public ELLFHPNCMJG<Dictionary<MKNCOJELGGF, int>> MDKJMFAOGHC(long HLKBDGNJMKK, long LJJDPDIPAJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6D844E0", Offset = "0x6D838E0", VA = "0x186D844E0", Slot = "29")]
	public ELLFHPNCMJG<Dictionary<MKNCOJELGGF, int>> DKCAGDPEAPF(long HLKBDGNJMKK, long LJJDPDIPAJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6D89FE0", Offset = "0x6D893E0", VA = "0x186D89FE0", Slot = "37")]
	public bool KOBMJNELJEJ(long HLKBDGNJMKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6D870E0", Offset = "0x6D864E0", VA = "0x186D870E0", Slot = "56")]
	public bool HBCGODBOALB(long HLKBDGNJMKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6D8DF30", Offset = "0x6D8D330", VA = "0x186D8DF30", Slot = "38")]
	public bool PEMMDJMCHIE(long HLKBDGNJMKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6D8D3D0", Offset = "0x6D8C7D0", VA = "0x186D8D3D0", Slot = "57")]
	public bool OKKGIOPHCMF(long HLKBDGNJMKK, [Out] CIBJFECJHJB DMDMKMJODPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6D89180", Offset = "0x6D88580", VA = "0x186D89180", Slot = "39")]
	public bool JBMIMMFGMKM(long MIDKDKCCCEO, [Out] DateTime LILIGHOBIHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6D88C40", Offset = "0x6D88040", VA = "0x186D88C40", Slot = "40")]
	public long IPDINHCMGIL(long MIDKDKCCCEO)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6D887C0", Offset = "0x6D87BC0", VA = "0x186D887C0", Slot = "41")]
	public long IKHPFBAFCHP(long HLKBDGNJMKK)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6D8C4E0", Offset = "0x6D8B8E0", VA = "0x186D8C4E0", Slot = "42")]
	public int ODGHHHOOOLK(long MIDKDKCCCEO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6D87C70", Offset = "0x6D87070", VA = "0x186D87C70", Slot = "43")]
	public bool HMNDOIFGOML()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6D85270", Offset = "0x6D84670", VA = "0x186D85270", Slot = "44")]
	public bool FBPFPIDNOBL(long MIDKDKCCCEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6D86AE0", Offset = "0x6D85EE0", VA = "0x186D86AE0", Slot = "45")]
	public IEnumerable<long> GIGNCNEGKLD(long MIDKDKCCCEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6D831C0", Offset = "0x6D825C0", VA = "0x186D831C0", Slot = "46")]
	public int AOFDBNMMHJO(long MIDKDKCCCEO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6D8B1F0", Offset = "0x6D8A5F0", VA = "0x186D8B1F0", Slot = "50")]
	public long MOJNEFLNDMI(long OIJNGAEMPLF)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6D888D0", Offset = "0x6D87CD0", VA = "0x186D888D0", Slot = "51")]
	public MKNCOJELGGF INFPNCAMAHL()
	{
		return default(MKNCOJELGGF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6D8AD30", Offset = "0x6D8A130", VA = "0x186D8AD30")]
	private bool LPJEOEANACO(Guid PLOIFBAPGKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6D8CC70", Offset = "0x6D8C070", VA = "0x186D8CC70")]
	private void OHDHJMPJLMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6D89410", Offset = "0x6D88810", VA = "0x186D89410")]
	private MKNCOJELGGF JIECLKGEIPM()
	{
		return default(MKNCOJELGGF);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6D8B4B0", Offset = "0x6D8A8B0", VA = "0x186D8B4B0")]
	private void NAENDPLALOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6D832D0", Offset = "0x6D826D0", VA = "0x186D832D0")]
	private int APPKKHACAMG(KeepsakeRoomListDTO DABHDFDBMPP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6D8BAF0", Offset = "0x6D8AEF0", VA = "0x186D8BAF0")]
	private int NBMHIDKNGDG(DateTime GPGJJCNIGNP, DateTime DABGFNPPFDJ, TimeSpan OMHFLBDDPLN, int HCKOHOKOLNA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6D8DFD0", Offset = "0x6D8D3D0", VA = "0x186D8DFD0")]
	private void PHMMBBCEGDI(IEnumerable<KeepsakeInstanceDTO> OPHPPAPPFIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6D8E4C0", Offset = "0x6D8D8C0", VA = "0x186D8E4C0")]
	private void PKHJKJBHKHI(IEnumerable<KeepsakeCollectionRecordDTO> MNFHMECPOGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6D8ED10", Offset = "0x6D8E110", VA = "0x186D8ED10")]
	private void PPKONDGHBOA(IEnumerable<long> DLFOEDIFIPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0xABEF50", Offset = "0xABE350", VA = "0x180ABEF50")]
	private void OBCIFBGEHML(KeepsakeGlobalConfigDTO MKMDEGAMEFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x6D86780", Offset = "0x6D85B80", VA = "0x186D86780")]
	private bool GFOMGPDOFKK(MKNCOJELGGF BLPMHNAODAE, [Out] Guid NLNCEPEPMHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6D8A300", Offset = "0x6D89700", VA = "0x186D8A300")]
	private bool LJKIGJGHABL([Out] Guid NLNCEPEPMHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6D8AAD0", Offset = "0x6D89ED0", VA = "0x186D8AAD0")]
	private bool LMBLODEBIHJ(Guid PLOIFBAPGKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6D8C0F0", Offset = "0x6D8B4F0", VA = "0x186D8C0F0")]
	private IEnumerable<Guid> NHPPDCDCFGC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x6D87020", Offset = "0x6D86420", VA = "0x186D87020")]
	private IEnumerable<KeepsakeInstanceDTO> GPHIFMGIFDI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6D866F0", Offset = "0x6D85AF0", VA = "0x186D866F0")]
	private void GBDDMDDLDCP(Guid PLOIFBAPGKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6D89360", Offset = "0x6D88760", VA = "0x186D89360")]
	private bool JFPGLKKJAOI(Guid PLOIFBAPGKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6D845A0", Offset = "0x6D839A0", VA = "0x186D845A0")]
	private void DMPAMJBKBEM(Guid PLOIFBAPGKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6D87B90", Offset = "0x6D86F90", VA = "0x186D87B90")]
	private void HMJHALONLIA(MKNCOJELGGF CENOIGEPJMG, int OJMLBHBIANF, Dictionary<MKNCOJELGGF, int> CJLOHDJKOLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6D869F0", Offset = "0x6D85DF0", VA = "0x186D869F0")]
	private int GHEHILINNBH(MKNCOJELGGF BLPMHNAODAE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6D842C0", Offset = "0x6D836C0", VA = "0x186D842C0")]
	private void CJFDLDIHMLG(KeepsakeInstanceDTO COONFPOPBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6D8DA20", Offset = "0x6D8CE20", VA = "0x186D8DA20")]
	private void OOAHALLOGJH(KeepsakeInstanceDTO COONFPOPBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6D872A0", Offset = "0x6D866A0", VA = "0x186D872A0")]
	private void HIHLGPBJBNG(Guid PLOIFBAPGKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6D865D0", Offset = "0x6D859D0", VA = "0x186D865D0")]
	private void HHECDHBKDFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6D8A9B0", Offset = "0x6D89DB0", VA = "0x186D8A9B0")]
	private void LJOHPANIEKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6D83470", Offset = "0x6D82870", VA = "0x186D83470")]
	private void BBENHDGKCHA(LLDELMAFLOP JOIPCEGHEEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6D865D0", Offset = "0x6D859D0", VA = "0x186D865D0")]
	private void FNFAGLAOOAA(MEAHAOBKPOD FAKGLFFOLFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6D865D0", Offset = "0x6D859D0", VA = "0x186D865D0")]
	private void MBJDAFDIIGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6D83A80", Offset = "0x6D82E80", VA = "0x186D83A80")]
	private void BNAOALCEFLI(float HGPJOCJDEJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6D8C6C0", Offset = "0x6D8BAC0", VA = "0x186D8C6C0")]
	private void OFGJEFCMKML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6D8E2C0", Offset = "0x6D8D6C0", VA = "0x186D8E2C0")]
	private bool PJIOELJBJFE(Guid PLOIFBAPGKK, [Out] string LNEFIICFDDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6D8DD60", Offset = "0x6D8D160", VA = "0x186D8DD60")]
	private bool PEGLODCIEDH(Guid PLOIFBAPGKK, [Out] KeepsakeCategoryConfigDTO CENOIGEPJMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6D88600", Offset = "0x6D87A00", VA = "0x186D88600")]
	private void IIHDJEBMIPM(string KJNFHDLCDNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6D88270", Offset = "0x6D87670", VA = "0x186D88270")]
	private bool IBANGEKBMCI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6D82D80", Offset = "0x6D82180", VA = "0x186D82D80")]
	private IEnumerable<long> AKDFCOFHDFE(IEnumerable<KeepsakeRoomDTO> LEEOKNNBKPL, IEnumerable<KeepsakeRoomListDTO> EFJMNJKOCCD, long MIDKDKCCCEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6D87D50", Offset = "0x6D87150", VA = "0x186D87D50")]
	private bool HNLAEMBFDDO(Guid PLOIFBAPGKK, [Out] string IBDGAGPHJHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6D8E260", Offset = "0x6D8D660", VA = "0x186D8E260", Slot = "47")]
	public string PIMKJEPAPDJ(PNPPHHDIELP JBMADCBPCDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6D8E710", Offset = "0x6D8DB10", VA = "0x186D8E710", Slot = "49")]
	public string PKKFKCFNGCF(PNPPHHDIELP JBMADCBPCDE, long HLKBDGNJMKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6D86610", Offset = "0x6D85A10", VA = "0x186D86610", Slot = "48")]
	public string FPMJNBGDEHO(PNPPHHDIELP JBMADCBPCDE, int EHOFIAGFDOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6D85400", Offset = "0x6D84800", VA = "0x186D85400")]
	private void FLILBFFPCFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6D8A040", Offset = "0x6D89440", VA = "0x186D8A040")]
	private void KPJGCCHLINE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6D8C4C0", Offset = "0x6D8B8C0", VA = "0x186D8C4C0")]
	private PNPPHHDIELP OBIPDMENMDC(PNFHBDNFEPP JFFNEIMJIHN)
	{
		return default(PNPPHHDIELP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6D851B0", Offset = "0x6D845B0", VA = "0x186D851B0")]
	private PNPPHHDIELP EGMLCFJNFPL(PNFHBDNFEPP JFFNEIMJIHN)
	{
		return default(PNPPHHDIELP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6D89A50", Offset = "0x6D88E50", VA = "0x186D89A50")]
	internal static string JLDKEFDABBH(OMNFHIHKBLL NNFONGIDPDJ, string EGIAMPEKOME, bool FOMJGMLPIJN, int LJIKNKOJAMO, int ABJOOGLOAKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6D84740", Offset = "0x6D83B40", VA = "0x186D84740", Slot = "52")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6D8C250", Offset = "0x6D8B650", VA = "0x186D8C250")]
	private GGOJEKHBOHO NPMBDJPIGAC(EDHEFFCJEMG OGOJPCMIECF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6D82430", Offset = "0x6D81830", VA = "0x186D82430")]
	private NKDBMKMICHA ADAFEANNMFN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6D82830", Offset = "0x6D81C30", VA = "0x186D82830")]
	private Task AJDJEDEGOGN(GPHLDHMLGGJ KCHFAPGLICB, CancellationToken GBOOEEMCFEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6D88380", Offset = "0x6D87780", VA = "0x186D88380")]
	[AsyncStateMachine(typeof(IILLBKOMKLC))]
	private Task ICPFJAPFFJA(GPHLDHMLGGJ KCHFAPGLICB, CancellationToken GBOOEEMCFEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6D886E0", Offset = "0x6D87AE0", VA = "0x186D886E0")]
	private Task IKDHHIPJIOE(GPHLDHMLGGJ KCHFAPGLICB, CancellationToken GBOOEEMCFEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6D8A1D0", Offset = "0x6D895D0", VA = "0x186D8A1D0")]
	[AsyncStateMachine(typeof(GMFKOJHNHDN))]
	private Task LJDOKNGIIAL(string NFKMLKNHFEM, TimeSpan BDHIGEKMOEK, CancellationToken GBOOEEMCFEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6D8BBF0", Offset = "0x6D8AFF0", VA = "0x186D8BBF0")]
	[CompilerGenerated]
	private void NCBCJIPLAHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6D84490", Offset = "0x6D83890", VA = "0x186D84490")]
	[CompilerGenerated]
	private void CLDJNHOODJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6D8A9D0", Offset = "0x6D89DD0", VA = "0x186D8A9D0")]
	[CompilerGenerated]
	private bool LLIOLBKMHFH(KeepsakeInstanceDTO KPPEBBOFEKD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6D898E0", Offset = "0x6D88CE0", VA = "0x186D898E0")]
	[CompilerGenerated]
	private ELLFHPNCMJG<Dictionary<MKNCOJELGGF, int>> JKCPNOKBNLI(Dictionary<Guid, MKNCOJELGGF> NMCIEACNIOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6D88490", Offset = "0x6D87890", VA = "0x186D88490")]
	[CompilerGenerated]
	private ELLFHPNCMJG<Dictionary<MKNCOJELGGF, int>> IIEGIAEEDIB(Dictionary<Guid, MKNCOJELGGF> NMCIEACNIOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6D83E20", Offset = "0x6D83220", VA = "0x186D83E20")]
	[CompilerGenerated]
	private bool CEGKKDOCDAB(KeepsakeRoomListDTO KPPEBBOFEKD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6D8DC30", Offset = "0x6D8D030", VA = "0x186D8DC30")]
	[CompilerGenerated]
	private bool PCBADDFHBJE(KeepsakeInstanceDTO KPPEBBOFEKD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6D8EB30", Offset = "0x6D8DF30", VA = "0x186D8EB30")]
	[CompilerGenerated]
	private void PLDENOFCICG(Tuple<KeepsakeRoomInstancesDTO, IReadOnlyDictionary<MKNCOJELGGF, KeepsakeCategoryConfigDTO>, KeepsakeGlobalConfigDTO> NGOGOFCOAEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6D83270", Offset = "0x6D82670", VA = "0x186D83270")]
	[CompilerGenerated]
	private void APJJLPBEHCN(string IBDGAGPHJHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6D84FF0", Offset = "0x6D843F0", VA = "0x186D84FF0")]
	[CompilerGenerated]
	private Task EGGLJOMFPAL(CancellationToken LINAAHIADGM)
	{
		return null;
	}
}
namespace RecRoom.Keepsakes
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public class KeepsakesConfig : ScriptableObject, MJGBEPJIPCF<KeepsakesConfig.KeepsakesOptions>
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200002B")]
		public class KeepsakesOptions
		{
			[Cpp2IlInjected.Token(Token = "0x200002C")]
			[CompilerGenerated]
			private sealed class FPFPOFIAILA
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000098")]
				public string themeId;

				[Cpp2IlInjected.Token(Token = "0x60000F3")]
				[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
				public FPFPOFIAILA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000F4")]
				[Cpp2IlInjected.Address(RVA = "0x6D91540", Offset = "0x6D90940", VA = "0x186D91540")]
				internal bool OBBDHHICOJI(KeepsakeTheme x)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60000F5")]
				[Cpp2IlInjected.Address(RVA = "0x6D91540", Offset = "0x6D90940", VA = "0x186D91540")]
				internal bool GGAKCBGEKME(KeepsakeTheme x)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			[SerializeField]
			private KeepsakeTheme[] themes;

			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x6D929D0", Offset = "0x6D91DD0", VA = "0x186D929D0")]
			public bool HPNJFOAMKBB(string AJPKGDJDBIE, [Out] KeepsakeTheme KFMNEEDDPFL)
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
			[Cpp2IlInjected.Address(RVA = "0x89EF50", Offset = "0x89E350", VA = "0x18089EF50", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x6D92950", Offset = "0x6D91D50", VA = "0x186D92950")]
		[GOEIKLHOLGG.KCHBNNLNADK.IBDMBHIFIDC]
		internal static void LHFLNIJFEKK(MCLDCOGKKML HOCJPKACMFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0xA887D0", Offset = "0xA87BD0", VA = "0x180A887D0")]
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
