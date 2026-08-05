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
		[Cpp2IlInjected.Address(RVA = "0x8554310", Offset = "0x8552910", VA = "0x188554310", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x29CB0D0", Offset = "0x29C96D0", VA = "0x1829CB0D0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class BLGAJCGNMKN : IComparer<BALHDFAAENP>
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private sealed class HKDAGDKFOPE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public BALHDFAAENP x;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public BALHDFAAENP y;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public HKDAGDKFOPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xE93E00", Offset = "0xE92400", VA = "0x180E93E00")]
		internal bool JFNNGMOFKEJ(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x222B890", Offset = "0x2229E90", VA = "0x18222B890")]
		internal bool OEFGMEDGAFO(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xE93E00", Offset = "0xE92400", VA = "0x180E93E00")]
		internal bool EIIDKKFOOHB(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x222B890", Offset = "0x2229E90", VA = "0x18222B890")]
		internal bool OGHDBLJIDCG(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private List<KeepsakeCategoryThemePair> CHDAHEGAJON;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0xAB22B0", Offset = "0xAB08B0", VA = "0x180AB22B0")]
	public BLGAJCGNMKN(List<KeepsakeCategoryThemePair> ADDODJOECLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x85432F0", Offset = "0x85418F0", VA = "0x1885432F0", Slot = "4")]
	public int Compare(BALHDFAAENP GBNAKFLHCOE, BALHDFAAENP ODEKEFJCIIL)
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
		public BALHDFAAENP KeepsakeCategory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public KeepsakeTheme KeepsakeTheme;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[OEHADFBFMEG]
public class CHIEJEAEALJ : DEPLECABLCP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class JMHODOBBDLN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public CHIEJEAEALJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public BALHDFAAENP keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public JMHODOBBDLN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x8552FA0", Offset = "0x85515A0", VA = "0x188552FA0")]
		internal EEOEHGFNDGC<Guid> OGLLILCLPEI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x8552F10", Offset = "0x8551510", VA = "0x188552F10")]
		internal void LNGGJBALCMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x8552F40", Offset = "0x8551540", VA = "0x188552F40")]
		internal void MLAGDLCAOLF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x8552B00", Offset = "0x8551100", VA = "0x188552B00")]
		internal void DKHDAAGDEPJ(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x8552AD0", Offset = "0x85510D0", VA = "0x188552AD0")]
		internal void CNOOCHCIELH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class OLOONBCDDOH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public CHIEJEAEALJ <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public OLOONBCDDOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8553770", Offset = "0x8551D70", VA = "0x188553770")]
		internal void HNLLLBLPAEM(LNGADCBDFNN response)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x8553B20", Offset = "0x8552120", VA = "0x188553B20")]
		internal void NEHIEGBKKHA(string error)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class HGLNNEBFFNG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public KeepsakeTheme theme;

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public HGLNNEBFFNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8552750", Offset = "0x8550D50", VA = "0x188552750")]
		internal bool NAMNOOCKGED(KeepsakeCategoryThemePair categoryThemePair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class DKHKIBFBFKK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public CHIEJEAEALJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public long progressionEventId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public BALHDFAAENP? keepsakeCategory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public DKHKIBFBFKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x85517A0", Offset = "0x854FDA0", VA = "0x1885517A0")]
		internal void CHBAKJDMPJA(KeepsakeProgressionEventInstancesDTO result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x8551B30", Offset = "0x8550130", VA = "0x188551B30")]
		internal void PIDLLPFDMIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x8551830", Offset = "0x854FE30", VA = "0x188551830")]
		internal EEOEHGFNDGC<IEnumerable<Guid>> GHGLGDJKCMF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x7FFD720", Offset = "0x7FFBD20", VA = "0x187FFD720")]
		internal bool MBHICBIPKFL(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class JNPDJOONGHP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public KeepsakeRoomInstanceIdsDTO instancesInRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public DKHKIBFBFKK CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public JNPDJOONGHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x8553130", Offset = "0x8551730", VA = "0x188553130")]
		internal EEOEHGFNDGC<IEnumerable<Guid>> NLOOBIPIEIE(KeepsakeRoomInstancesDTO roomInstancesDTO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class BBKMJHCILHI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public KeepsakeRoomInstancesDTO roomInstancesDTO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public JNPDJOONGHP CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public BBKMJHCILHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x85431C0", Offset = "0x85417C0", VA = "0x1885431C0")]
		internal bool KAHAKBMGGGL(Guid instanceId)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class CAMDBMDJIMC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Guid instanceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public BBKMJHCILHI CS$<>8__locals3;

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public CAMDBMDJIMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x85435A0", Offset = "0x8541BA0", VA = "0x1885435A0")]
		internal bool KAIGBLNHGCN(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class PBIFGFAGLFA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public CHIEJEAEALJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public PBIFGFAGLFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x8553B80", Offset = "0x8552180", VA = "0x188553B80")]
		internal EEOEHGFNDGC<IEnumerable<Guid>> BAHOEPEBBAL(IEnumerable<Guid> instanceIds)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x8552730", Offset = "0x8550D30", VA = "0x188552730")]
		internal bool MPNLGNIDAJL(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class PJCMGLIHBNK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public CHIEJEAEALJ <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public PJCMGLIHBNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x8554060", Offset = "0x8552660", VA = "0x188554060")]
		internal void PBDLMODJMJB(KeepsakeProgressionEventInstancesDTO result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x8551B30", Offset = "0x8550130", VA = "0x188551B30")]
		internal void IAOFDGBDECL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x8553D70", Offset = "0x8552370", VA = "0x188553D70")]
		internal EEOEHGFNDGC<Dictionary<Guid, BALHDFAAENP>> DBHHPEEHNBJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x7FFD720", Offset = "0x7FFBD20", VA = "0x187FFD720")]
		internal bool KAKLDGLHDDE(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class JOKINLGNGPF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public KeepsakeRoomInstanceIdsDTO instancesInRoom;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public JOKINLGNGPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x8553270", Offset = "0x8551870", VA = "0x188553270")]
		internal EEOEHGFNDGC<Dictionary<Guid, BALHDFAAENP>> BKCIIBJAJMB(KeepsakeRoomInstancesDTO roomInstancesDTO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class EJOMKKBCGEI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public KeepsakeRoomInstancesDTO roomInstancesDTO;

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public EJOMKKBCGEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x8551D30", Offset = "0x8550330", VA = "0x188551D30")]
		internal bool MFGLOAAIGEA(Guid instanceId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x8551E10", Offset = "0x8550410", VA = "0x188551E10")]
		internal KeyValuePair<Guid, BALHDFAAENP> OEKFCCMOEMM(Guid instanceId)
		{
			return default(KeyValuePair<Guid, BALHDFAAENP>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class DOPHKOHFNPG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public Guid instanceId;

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public DOPHKOHFNPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x1036940", Offset = "0x1034F40", VA = "0x181036940")]
		internal bool KIJHOHNPFHP(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class AHPLAAGMJHE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public Guid instanceId;

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public AHPLAAGMJHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x1036940", Offset = "0x1034F40", VA = "0x181036940")]
		internal bool KDOEHKKBKLK(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class GLKCCJIKAPO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public CHIEJEAEALJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public GLKCCJIKAPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x8552530", Offset = "0x8550B30", VA = "0x188552530")]
		internal EEOEHGFNDGC<Dictionary<Guid, BALHDFAAENP>> FOMCLLGNLGC(Dictionary<Guid, BALHDFAAENP> instanceIdsAndCategories)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x8552730", Offset = "0x8550D30", VA = "0x188552730")]
		internal bool PFGAAAIIHMJ(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class PHDGIJFDBMK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public KeepsakeRoomInstanceIdsDTO collectedInstanceIds;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public PHDGIJFDBMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x8553CF0", Offset = "0x85522F0", VA = "0x188553CF0")]
		internal bool HPGACHFMPPN(KeyValuePair<Guid, BALHDFAAENP> idCategoryPair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class BBBCMIGONHO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public Dictionary<Guid, BALHDFAAENP> instanceIdsAndCategories;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public BBBCMIGONHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x8543070", Offset = "0x8541670", VA = "0x188543070")]
		internal KeyValuePair<BALHDFAAENP, int> ANEENABJFKC(BALHDFAAENP category)
		{
			return default(KeyValuePair<BALHDFAAENP, int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class OLIKMIBEPDC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public BALHDFAAENP category;

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public OLIKMIBEPDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0xFB93E0", Offset = "0xFB79E0", VA = "0x180FB93E0")]
		internal bool GEFLDIBDDKL(BALHDFAAENP instanceCategory)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class IODDDMPMKEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public Dictionary<Guid, BALHDFAAENP> instanceIdsAndCategories;

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public IODDDMPMKEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x8552890", Offset = "0x8550E90", VA = "0x188552890")]
		internal KeyValuePair<BALHDFAAENP, int> DCKEKHNHMIE(BALHDFAAENP category)
		{
			return default(KeyValuePair<BALHDFAAENP, int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class KJMJNKJCGIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public BALHDFAAENP category;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public KJMJNKJCGIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0xFB93E0", Offset = "0xFB79E0", VA = "0x180FB93E0")]
		internal bool MEBJPLHNPCC(BALHDFAAENP instanceCategory)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class EHIHEILDODB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public CHIEJEAEALJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public Func<KeepsakeRoomDTO, bool> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public EHIHEILDODB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x8551B80", Offset = "0x8550180", VA = "0x188551B80")]
		internal bool LCJMCPOLKFI(DateTime nowUtc, DateTime eventStartTime, int roomOrder, TimeSpan unlockStartOffset, TimeSpan unlockInterval, int unlockBatchSize)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x8551C70", Offset = "0x8550270", VA = "0x188551C70")]
		internal bool MHAMIKLGDHD(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x8551B60", Offset = "0x8550160", VA = "0x188551B60")]
		internal bool DMGKEAFNLGI(KeepsakeRoomDTO r)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x8551B60", Offset = "0x8550160", VA = "0x188551B60")]
		internal bool ECNMDNCCEOE(KeepsakeRoomDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class JIOPECAMOJF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public JIOPECAMOJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x1352410", Offset = "0x1350A10", VA = "0x181352410")]
		internal bool FDHLJGKDGHK(KeepsakeRoomListDTO roomList)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class ILIKLMNHGJP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public Func<KeepsakeRoomDTO, bool> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public ILIKLMNHGJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x8552770", Offset = "0x8550D70", VA = "0x188552770")]
		internal bool DEDAEDNCLCD(KeepsakeRoomListDTO roomList)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x2894890", Offset = "0x2892E90", VA = "0x182894890")]
		internal bool CLOHBMFOFCL(KeepsakeRoomDTO room)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class COPGDLLEIID
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public COPGDLLEIID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x85516E0", Offset = "0x854FCE0", VA = "0x1885516E0")]
		internal bool FOACHGBFEGL(KeepsakeRoomListDTO i)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class ADOPJEGFGAH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public ADOPJEGFGAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x1352410", Offset = "0x1350A10", VA = "0x181352410")]
		internal bool KBLNKHGMPHD(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class IMMAIOGDJJI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public Guid keepsakeInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public IMMAIOGDJJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x8552830", Offset = "0x8550E30", VA = "0x188552830")]
		internal bool CDNLAOBJICE(KeyValuePair<Guid, KeepsakeInstanceDTO> instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class ONCHPKDLBED
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public BALHDFAAENP keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public ONCHPKDLBED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x247C880", Offset = "0x247AE80", VA = "0x18247C880")]
		internal bool LIMDENOHBMP(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class DKBDEPMPCHH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public Guid keepsakeInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public DKBDEPMPCHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x8551740", Offset = "0x854FD40", VA = "0x188551740")]
		internal bool MDFENKDNICE(KeyValuePair<Guid, KeepsakeInstanceDTO> instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class GBGLLEHCMDD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public BALHDFAAENP keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public GBGLLEHCMDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x8551F60", Offset = "0x8550560", VA = "0x188551F60")]
		internal bool OODDLJEGOAD(KeyValuePair<Guid, BALHDFAAENP> x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class GOCPOEDDFBA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public BALHDFAAENP newKeepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public GOCPOEDDFBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x247C880", Offset = "0x247AE80", VA = "0x18247C880")]
		internal bool IMFEFBEOBNB(KeepsakeInstanceDTO instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class NJBDOEPJGGB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public long currentRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public long? currentSubRoomId;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public NJBDOEPJGGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x8553670", Offset = "0x8551C70", VA = "0x188553670")]
		internal bool ALLDIKGKCMO(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class JDHGPLKCICH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public IReadOnlyList<KeepsakeRoomListDTO> roomList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public JDHGPLKCICH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x85529E0", Offset = "0x8550FE0", VA = "0x1885529E0")]
		internal bool ENBDDNPBBKG(KeepsakeRoomDTO room)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class ODNAGMAOAHI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public KeepsakeRoomDTO room;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public JDHGPLKCICH CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public ODNAGMAOAHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x85536F0", Offset = "0x8551CF0", VA = "0x1885536F0")]
		internal bool CGMENHMMFCA(KeepsakeRoomListDTO roomListDto)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private struct GHFOGEIOAHA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public CHIEJEAEALJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public GNGDPEPAGOH args;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x8551FA0", Offset = "0x85505A0", VA = "0x188551FA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x85524D0", Offset = "0x8550AD0", VA = "0x1885524D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private struct AJBALGOLAFP : IAsyncStateMachine
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
		public CHIEJEAEALJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public string message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x8542D70", Offset = "0x8541370", VA = "0x188542D70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x8543010", Offset = "0x8541610", VA = "0x188543010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly DateTime DMALBACFECM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly DCHEOFIBELP EOEAIAMBJMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly LMDPLBIHLOA EPFOFAGAAKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly IKJIHKEJMKC HALDJFJPCJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly PBGCLGKEAAI EEOPADDAFNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly AHCAALDFLGN NEBFBLABIHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly NPKLMAPFKPP JCJAKCMNNCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly FNBKODKPPKG IJBBDNEIOLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly NAICMPCIHAH JOLGKKEKLAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly KFAJOGFMPAC DCBMBLEENHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly KDBOPNANCNO LGHHCEDMNDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly ONDOEDEALJH CEPIPBFLAMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly BJJNKFMECOO JIMPPFMECIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly CDKLACJCPFP AAJMCDEIHCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly IKHAGINNNGC GNHIHLCFLBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly KNOKIILHDFE NKJNDBENPHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly AGMDMCDFNPP<KeepsakesConfig.KeepsakesOptions> PLMLGIGGGNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly DGLAIFNIHGO IGAOGNODFFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly Dictionary<Guid, KeepsakeInstanceDTO> HBNBODAOONB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly HashSet<Guid> HAFAOEFOEFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly HashSet<long> CIAJDAAEBMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private Dictionary<BALHDFAAENP, int> CLGNOFCPAFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly HashSet<Guid> BHNEEONJOBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly IDisposable NEDCPLIIJFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private Task GOHACAAENGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private EEOEHGFNDGC<Guid> CEFLMKMJLKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private long? HKHDGACLAEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private KeepsakeProgressionEventInstancesDTO OMADDLAGKMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private EEOEHGFNDGC<KeepsakeProgressionEventInstancesDTO> EFFGJIFEJPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private IReadOnlyDictionary<BALHDFAAENP, KeepsakeCategoryConfigDTO> MBMPGHJNHPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private KeepsakeGlobalConfigDTO AACJBINHEAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private HashSet<long> HFKPFGCFDMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private HashSet<long> KEBBFAOONAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private List<KeepsakeRoomListDTO> AGMFEAPCLLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private List<KeepsakeRoomListDTO> PDBMODMJKCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private List<KeepsakeRoomListDTO> JOFLLDLCAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private Dictionary<long, string> EBMADDBMIOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private Dictionary<long, string> OBLJKLBBHPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private Dictionary<long, DateTime> DFJBEMPKEBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private Dictionary<long, List<KeepsakeRoomDTO>> HNLKPCGINHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private Dictionary<long, List<KeepsakeRoomDTO>> MHAAHMHFKMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private Dictionary<long, long> ONGAKADBIPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly List<string> IKGDKBNNFBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private DateTime LAJNJLHGNOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly IDisposable IIFELGJDOBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private Dictionary<Guid, BALHDFAAENP> GHKEAHMIPMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private Dictionary<BALHDFAAENP, int> IPDMIDFEAEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private List<KeepsakeCategoryThemePair> ADDODJOECLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private BLGAJCGNMKN PLKPGEOBCKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private bool PCLIMPBGFOC;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool LFLLIAKMMPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xAD4490", Offset = "0xAD2A90", VA = "0x180AD4490", Slot = "53")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xAD43F0", Offset = "0xAD29F0", VA = "0x180AD43F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool PFAMMMEIGHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x854A990", Offset = "0x8548F90", VA = "0x18854A990", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool EOPPJLANFGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x854E730", Offset = "0x854CD30", VA = "0x18854E730", Slot = "36")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private long PDBHOKKEGOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8546BC0", Offset = "0x85451C0", VA = "0x188546BC0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private long? EEKFHMLALAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x85457D0", Offset = "0x8543DD0", VA = "0x1885457D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private bool FODCIKMAELK
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8543650", Offset = "0x8541C50", VA = "0x188543650")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public IReadOnlyList<KeepsakeRoomListDTO> BNFFLPEBDNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xC1C0D0", Offset = "0xC1A6D0", VA = "0x180C1C0D0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public IReadOnlyList<KeepsakeRoomListDTO> OKPECCEHGGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xC263A0", Offset = "0xC249A0", VA = "0x180C263A0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IReadOnlyList<KeepsakeRoomListDTO> BKMJOEONKNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xC3A7D0", Offset = "0xC38DD0", VA = "0x180C3A7D0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public IReadOnlyDictionary<long, string> MEOBJCMACCC
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xC22600", Offset = "0xC20C00", VA = "0x180C22600", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	internal bool FFPBKHGFHGC
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xD1B850", Offset = "0xD19E50", VA = "0x180D1B850")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Guid?> MEFFMMDODNI
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8546CF0", Offset = "0x85452F0", VA = "0x188546CF0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8547080", Offset = "0x8545680", VA = "0x188547080", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action MJOPMCAGLJG
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8549D80", Offset = "0x8548380", VA = "0x188549D80", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x854EB90", Offset = "0x854D190", VA = "0x18854EB90", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action EIKDLDLCFEP
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x854C7A0", Offset = "0x854ADA0", VA = "0x18854C7A0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x854FCB0", Offset = "0x854E2B0", VA = "0x18854FCB0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x8550110", Offset = "0x854E710", VA = "0x188550110")]
	[RecRoom.NoEngine.Common.Preserve]
	internal CHIEJEAEALJ([EDHLHMEHMKO(null)][NotNull] DCHEOFIBELP EOEAIAMBJMK, [NotNull][EDHLHMEHMKO(null)] BIDKKAOMJIC FGNBHLKJJPP, [NotNull][EDHLHMEHMKO(null)] LMDPLBIHLOA EPFOFAGAAKC, [NotNull][EDHLHMEHMKO(null)] IKJIHKEJMKC HALDJFJPCJN, [EDHLHMEHMKO(null)][NotNull] PBGCLGKEAAI EEOPADDAFNA, [EDHLHMEHMKO(null)][NotNull] AHCAALDFLGN NEBFBLABIHE, [EDHLHMEHMKO(null)][NotNull] NPKLMAPFKPP JCJAKCMNNCH, [NotNull][EDHLHMEHMKO(null)] FNBKODKPPKG IJBBDNEIOLG, [NotNull][EDHLHMEHMKO(null)] NAICMPCIHAH JOLGKKEKLAC, [NotNull][EDHLHMEHMKO(null)] JGEIJOKHDPN GDDDCKIOAMO, [NotNull][EDHLHMEHMKO(null)] KFAJOGFMPAC DCBMBLEENHA, [NotNull][EDHLHMEHMKO(null)] KDBOPNANCNO LGHHCEDMNDP, [NotNull][EDHLHMEHMKO(null)] ONDOEDEALJH CEPIPBFLAMC, [NotNull][EDHLHMEHMKO(null)] BJJNKFMECOO JIMPPFMECIA, [EDHLHMEHMKO(null)][NotNull] CDKLACJCPFP AAJMCDEIHCB, [EDHLHMEHMKO(null)][NotNull] IKHAGINNNGC GNHIHLCFLBG, [NotNull][EDHLHMEHMKO(null)] KNOKIILHDFE NKJNDBENPHK, [EDHLHMEHMKO(null)][NotNull] AGMDMCDFNPP<KeepsakesConfig.KeepsakesOptions> PLMLGIGGGNL, [NotNull][EDHLHMEHMKO(null)] DGLAIFNIHGO IGAOGNODFFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x8545320", Offset = "0x8543920", VA = "0x188545320", Slot = "15")]
	public bool COIJAAPDFLI(List<string> EOAPFKHPNNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x8544540", Offset = "0x8542B40", VA = "0x188544540", Slot = "16")]
	public EEOEHGFNDGC<Guid> BGJBCNHDOPF(BALHDFAAENP JIGKEGKFKMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x8547380", Offset = "0x8545980", VA = "0x188547380", Slot = "17")]
	public FBCJGBABFLH FJACKPFOBHK(Guid KFMICCKACKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x854EC90", Offset = "0x854D290", VA = "0x18854EC90", Slot = "18")]
	public FBCJGBABFLH OKIIMFMJIMB(Guid KFMICCKACKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x85443E0", Offset = "0x85429E0", VA = "0x1885443E0", Slot = "19")]
	public bool BBLJBKDELLJ(Guid KFMICCKACKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x85458C0", Offset = "0x8543EC0", VA = "0x1885458C0", Slot = "20")]
	public bool DIIKDBIHNOE(Guid KFMICCKACKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x8547240", Offset = "0x8545840", VA = "0x188547240")]
	public KeepsakeTheme FEONCHDNDAF(Guid KFMICCKACKP)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x854B130", Offset = "0x8549730", VA = "0x18854B130")]
	public bool LGPIEFHLKME(BALHDFAAENP JIGKEGKFKMO, [Out] KeepsakeTheme LMFMHPKLJNK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x854B780", Offset = "0x8549D80", VA = "0x18854B780")]
	public List<KeepsakeTheme> MAEFGCCGMCM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x8546040", Offset = "0x8544640", VA = "0x188546040")]
	public int EAJMHJPIFKA(BALHDFAAENP JIGKEGKFKMO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x85455B0", Offset = "0x8543BB0", VA = "0x1885455B0")]
	public BALHDFAAENP DBELOMAEDEJ(Guid KFMICCKACKP)
	{
		return default(BALHDFAAENP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x854B310", Offset = "0x8549910", VA = "0x18854B310", Slot = "34")]
	public List<BALHDFAAENP> LLHMINKCNCD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x8547800", Offset = "0x8545E00", VA = "0x188547800", Slot = "35")]
	public IComparer<BALHDFAAENP> FNJDKIELFGL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x8544FD0", Offset = "0x85435D0", VA = "0x188544FD0", Slot = "32")]
	public string CFKHFMMCMFL(BALHDFAAENP JIGKEGKFKMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x8549C00", Offset = "0x8548200", VA = "0x188549C00", Slot = "33")]
	public string JEHADMDMKMH(BALHDFAAENP JIGKEGKFKMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x8543660", Offset = "0x8541C60", VA = "0x188543660", Slot = "21")]
	public bool ACMMCOHOKGA(Guid KFMICCKACKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x85480C0", Offset = "0x85466C0", VA = "0x1885480C0", Slot = "22")]
	public void GDKCHLMJAOI(Guid KFMICCKACKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x8548130", Offset = "0x8546730", VA = "0x188548130", Slot = "23")]
	public void GIPCGNHIKGO(BALHDFAAENP JIGKEGKFKMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x854DEB0", Offset = "0x854C4B0", VA = "0x18854DEB0", Slot = "24")]
	public void OANGJCMPBBD(Guid KFMICCKACKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x854D420", Offset = "0x854BA20", VA = "0x18854D420", Slot = "25")]
	public int NAJPIEBMDGK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x854F8F0", Offset = "0x854DEF0", VA = "0x18854F8F0", Slot = "31")]
	public EEOEHGFNDGC<IEnumerable<Guid>> PBPGCAHOKLI(long DDLHEHAKJGF, long CHNIFGDGCKN, BALHDFAAENP? JIGKEGKFKMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x854FEE0", Offset = "0x854E4E0", VA = "0x18854FEE0", Slot = "30")]
	public EEOEHGFNDGC<IEnumerable<Guid>> PNLLLFKAOIP(long DDLHEHAKJGF, long CHNIFGDGCKN, BALHDFAAENP? JIGKEGKFKMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x8544C20", Offset = "0x8543220", VA = "0x188544C20", Slot = "54")]
	public EEOEHGFNDGC<Dictionary<Guid, BALHDFAAENP>> BPBDHPICIKB(long DDLHEHAKJGF, long CHNIFGDGCKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x85478C0", Offset = "0x8545EC0", VA = "0x1885478C0", Slot = "55")]
	public EEOEHGFNDGC<Dictionary<Guid, BALHDFAAENP>> FOHEMJGPHJL(long DDLHEHAKJGF, long CHNIFGDGCKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x8545920", Offset = "0x8543F20", VA = "0x188545920", Slot = "26")]
	public EEOEHGFNDGC<int> DLAFCIJMPKJ(long DDLHEHAKJGF, long CHNIFGDGCKN, BALHDFAAENP? JIGKEGKFKMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x854C200", Offset = "0x854A800", VA = "0x18854C200", Slot = "27")]
	public EEOEHGFNDGC<int> MHNNHFGPNJE(long DDLHEHAKJGF, long CHNIFGDGCKN, BALHDFAAENP? JIGKEGKFKMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x8549E20", Offset = "0x8548420", VA = "0x188549E20", Slot = "28")]
	public EEOEHGFNDGC<Dictionary<BALHDFAAENP, int>> JIHKFMMOJGO(long DDLHEHAKJGF, long CHNIFGDGCKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x8544B60", Offset = "0x8543160", VA = "0x188544B60", Slot = "29")]
	public EEOEHGFNDGC<Dictionary<BALHDFAAENP, int>> BINCFMEIMGK(long DDLHEHAKJGF, long CHNIFGDGCKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x854B460", Offset = "0x8549A60", VA = "0x18854B460", Slot = "37")]
	public bool LPFFJPOCCMD(long DDLHEHAKJGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x8546C90", Offset = "0x8545290", VA = "0x188546C90", Slot = "56")]
	public bool EKNALDFNEDF(long DDLHEHAKJGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x8545730", Offset = "0x8543D30", VA = "0x188545730", Slot = "38")]
	public bool DCAGGOKDLFL(long DDLHEHAKJGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x854BE50", Offset = "0x854A450", VA = "0x18854BE50", Slot = "57")]
	public bool MEJLBPHGCEG(long DDLHEHAKJGF, [Out] ABOLHDPIAGO ILHMKNDDFOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x8544100", Offset = "0x8542700", VA = "0x188544100", Slot = "39")]
	public bool AGPOENOCCOD(long JGEPAGPJBHJ, [Out] DateTime DIKAGINJENH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x8547B80", Offset = "0x8546180", VA = "0x188547B80", Slot = "40")]
	public long GCLJPDOEBMF(long JGEPAGPJBHJ)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x8548490", Offset = "0x8546A90", VA = "0x188548490", Slot = "41")]
	public long HOPPMCANBNP(long DDLHEHAKJGF)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x8548180", Offset = "0x8546780", VA = "0x188548180", Slot = "42")]
	public int GPHICIIPPAO(long JGEPAGPJBHJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x8546AE0", Offset = "0x85450E0", VA = "0x188546AE0", Slot = "43")]
	public bool EHHNOHPLNME()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x854DB90", Offset = "0x854C190", VA = "0x18854DB90", Slot = "44")]
	public bool NJMKFAFHCCN(long JGEPAGPJBHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x8543AD0", Offset = "0x85420D0", VA = "0x188543AD0", Slot = "45")]
	public IReadOnlyList<long> ADGACOJPCMM(long JGEPAGPJBHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x854FE30", Offset = "0x854E430", VA = "0x18854FE30", Slot = "46")]
	public int PLNAIAMDAML(long JGEPAGPJBHJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x854B4C0", Offset = "0x8549AC0", VA = "0x18854B4C0", Slot = "50")]
	public long LPLJOECIJCL(long MBENDBNALAE)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x854CAF0", Offset = "0x854B0F0", VA = "0x18854CAF0", Slot = "51")]
	public BALHDFAAENP MNOOGLPNMNI()
	{
		return default(BALHDFAAENP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x8548AE0", Offset = "0x85470E0", VA = "0x188548AE0")]
	private bool IHDIOOOHFIN(Guid KFMICCKACKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x854AA00", Offset = "0x8549000", VA = "0x18854AA00")]
	private void LCFBBLNICBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x854A240", Offset = "0x8548840", VA = "0x18854A240")]
	private BALHDFAAENP KHBDJBOFLAC()
	{
		return default(BALHDFAAENP);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x854E0F0", Offset = "0x854C6F0", VA = "0x18854E0F0")]
	private void ODFFEFJHCNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x854D860", Offset = "0x854BE60", VA = "0x18854D860")]
	private int NALCJFLOABB(KeepsakeRoomListDTO KNLFECCOENM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x854F020", Offset = "0x854D620", VA = "0x18854F020")]
	private int OLFAOEKKAEP(DateTime DJNIAJLOACI, DateTime AJOGBFHAPOA, TimeSpan DBBMGGELENJ, int PKGJNFBIONE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x8546850", Offset = "0x8544E50", VA = "0x188546850")]
	private void EFCEAEEGADE(IEnumerable<KeepsakeInstanceDTO> HBNBODAOONB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x854A6E0", Offset = "0x8548CE0", VA = "0x18854A6E0")]
	private void KJKIHHEEFGI(IEnumerable<KeepsakeCollectionRecordDTO> KBGMPBKGMHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x8545860", Offset = "0x8543E60", VA = "0x188545860")]
	private void DFNNPDBBAJM(IEnumerable<long> KHILLLDHGLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0xB95AC0", Offset = "0xB940C0", VA = "0x180B95AC0")]
	private void KNFBGNIFKFI(KeepsakeGlobalConfigDTO AACJBINHEAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x8546E10", Offset = "0x8545410", VA = "0x188546E10")]
	private bool EMNHBIAJABI(BALHDFAAENP JIGKEGKFKMO, [Out] Guid GMOPICKNGAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x854CE60", Offset = "0x854B460", VA = "0x18854CE60")]
	private bool MOMFDOPHOID([Out] Guid GMOPICKNGAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x854EC30", Offset = "0x854D230", VA = "0x18854EC30")]
	private bool OJKKEELCFHI(Guid KFMICCKACKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x854AED0", Offset = "0x85494D0", VA = "0x18854AED0")]
	private IEnumerable<Guid> LDBCDKALPAB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x8544240", Offset = "0x8542840", VA = "0x188544240")]
	private IEnumerable<KeepsakeInstanceDTO> AIHFOGDNNMB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x8550080", Offset = "0x854E680", VA = "0x188550080")]
	private void PNPLICNPPIJ(Guid KFMICCKACKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x854DA00", Offset = "0x854C000", VA = "0x18854DA00")]
	private bool NAOHFAJHMNO(Guid KFMICCKACKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x854C840", Offset = "0x854AE40", VA = "0x18854C840")]
	private void MLEMJMLGDPD(Guid KFMICCKACKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x8544300", Offset = "0x8542900", VA = "0x188544300")]
	private void APEEMKBHNCD(BALHDFAAENP OKIBPDDCDLN, int LIEMBGFJNAE, Dictionary<BALHDFAAENP, int> CBBGDICMGNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x8548C10", Offset = "0x8547210", VA = "0x188548C10")]
	private int ILOAPEKPHLG(BALHDFAAENP JIGKEGKFKMO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x8543900", Offset = "0x8541F00", VA = "0x188543900")]
	private void ADEOAHEOAKF(KeepsakeInstanceDTO FLFOKPBJNKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x854A030", Offset = "0x8548630", VA = "0x18854A030")]
	private void KBFDFJAGIHJ(KeepsakeInstanceDTO FLFOKPBJNKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x8548710", Offset = "0x8546D10", VA = "0x188548710")]
	private void IFCNMFIGOJE(Guid KFMICCKACKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x85458F0", Offset = "0x8543EF0", VA = "0x1885458F0")]
	private void EIHHJHNHFHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x85452E0", Offset = "0x85438E0", VA = "0x1885452E0")]
	private void CNPOIIAHFDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x8546DA0", Offset = "0x85453A0", VA = "0x188546DA0")]
	private void EMFBFHIFHJI(PLJBILDCAHO DBFHAHPDHHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x85458F0", Offset = "0x8543EF0", VA = "0x1885458F0")]
	private void IPDBMDAABLL(GDINHOGLIIL MPIDDJPOOMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x85458F0", Offset = "0x8543EF0", VA = "0x1885458F0")]
	private void DKKCOFFJHPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x854E7F0", Offset = "0x854CDF0", VA = "0x18854E7F0")]
	private void OHGKPBLJCOO(float FBIBDLMMIFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x854F180", Offset = "0x854D780", VA = "0x18854F180")]
	private void ONMJIHLHFPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x8547600", Offset = "0x8545C00", VA = "0x188547600")]
	private bool FJDIPGKAIDJ(Guid KFMICCKACKP, [Out] string BCCJFOBGJEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x85461C0", Offset = "0x85447C0", VA = "0x1885461C0")]
	private bool EAKEKLAACBE(Guid KFMICCKACKP, [Out] KeepsakeCategoryConfigDTO OKIBPDDCDLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x854DAB0", Offset = "0x854C0B0", VA = "0x18854DAB0")]
	private void NGMDLEKEMCF(string MEJLBKIDBME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x8547130", Offset = "0x8545730", VA = "0x188547130")]
	private bool FBJNHAGLAIO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x8546570", Offset = "0x8544B70", VA = "0x188546570")]
	private List<long> EDMJEFKGOEO(IEnumerable<KeepsakeRoomDTO> EKPKFKIAGKE, IReadOnlyList<KeepsakeRoomListDTO> JNMMAGPEKCF, long JGEPAGPJBHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x854CF00", Offset = "0x854B500", VA = "0x18854CF00")]
	private bool NABPDCHKIOA(Guid KFMICCKACKP, [Out] string DAANGKEHOHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x854A930", Offset = "0x8548F30", VA = "0x18854A930", Slot = "47")]
	public string KLBJJCMPGFO(FMMOMHGELHF JDKIJAOLACE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x854C380", Offset = "0x854A980", VA = "0x18854C380", Slot = "49")]
	public string MJKIPBNIIOL(FMMOMHGELHF JDKIJAOLACE, long DDLHEHAKJGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x854FD50", Offset = "0x854E350", VA = "0x18854FD50", Slot = "48")]
	public string PJPPNKCMFLK(FMMOMHGELHF JDKIJAOLACE, int KPLMOGBOEMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x8548D00", Offset = "0x8547300", VA = "0x188548D00")]
	private void IMNFOFOCNLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x854DD20", Offset = "0x854C320", VA = "0x18854DD20")]
	private void OACCDFDFNDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x8545300", Offset = "0x8543900", VA = "0x188545300")]
	private FMMOMHGELHF COHECIANJHE(OGIKPGHKKNF NCMLCOHPFED)
	{
		return default(FMMOMHGELHF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x854C360", Offset = "0x854A960", VA = "0x18854C360")]
	private FMMOMHGELHF MJDMINCJEGC(OGIKPGHKKNF NCMLCOHPFED)
	{
		return default(FMMOMHGELHF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x8546390", Offset = "0x8544990", VA = "0x188546390")]
	internal static string EAPDOMHMMAP(LNGADCBDFNN JIEFFLNKFPC, string AKODKPMDKAA, bool DEGAANMHOEG, int PEEODLEPDHC, int MAPNHGMKCCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x8545BE0", Offset = "0x85441E0", VA = "0x188545BE0", Slot = "52")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x854BC10", Offset = "0x854A210", VA = "0x18854BC10")]
	private NNBJIEPBBHI MBHDCALIDJF(MEINMPIOLGA CCBPHHKHJEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x854A520", Offset = "0x8548B20", VA = "0x18854A520")]
	private OOIGNHBEBHD KHJHEOJCPDD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x8543D40", Offset = "0x8542340", VA = "0x188543D40")]
	private Task AEFCMLFKPKO(GNGDPEPAGOH PNGANGECEEL, CancellationToken PJCIHHKJKBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x854C9E0", Offset = "0x854AFE0", VA = "0x18854C9E0")]
	[AsyncStateMachine(typeof(GHFOGEIOAHA))]
	private Task MMBCENGACIJ(GNGDPEPAGOH PNGANGECEEL, CancellationToken PJCIHHKJKBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x854BB30", Offset = "0x854A130", VA = "0x18854BB30")]
	private Task MALOOFJLAGF(GNGDPEPAGOH PNGANGECEEL, CancellationToken PJCIHHKJKBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x8548360", Offset = "0x8546960", VA = "0x188548360")]
	[AsyncStateMachine(typeof(AJBALGOLAFP))]
	private Task HAFNMFMCLDF(string GKNICJPCIJJ, TimeSpan IHIOJAIDJAO, CancellationToken PJCIHHKJKBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x854A9E0", Offset = "0x8548FE0", VA = "0x18854A9E0")]
	[CompilerGenerated]
	private void LAPEMMBAGOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x854F730", Offset = "0x854DD30", VA = "0x18854F730")]
	[CompilerGenerated]
	private void OOPNIFCLCLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x854B030", Offset = "0x8549630", VA = "0x18854B030")]
	[CompilerGenerated]
	private bool LGDCCIMDIAL(KeepsakeInstanceDTO GBNAKFLHCOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x85485A0", Offset = "0x8546BA0", VA = "0x1885485A0")]
	[CompilerGenerated]
	private EEOEHGFNDGC<Dictionary<BALHDFAAENP, int>> ICBBLEAHMBK(Dictionary<Guid, BALHDFAAENP> EBFIENFDEJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x854F780", Offset = "0x854DD80", VA = "0x18854F780")]
	[CompilerGenerated]
	private EEOEHGFNDGC<Dictionary<BALHDFAAENP, int>> PBNANDICIDF(Dictionary<Guid, BALHDFAAENP> EBFIENFDEJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x8545710", Offset = "0x8543D10", VA = "0x188545710")]
	[CompilerGenerated]
	private bool DBFKADOJCAH(KeepsakeRoomListDTO GBNAKFLHCOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x8547A50", Offset = "0x8546050", VA = "0x188547A50")]
	[CompilerGenerated]
	private bool GBGJNOCNOJN(KeepsakeInstanceDTO GBNAKFLHCOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x8545150", Offset = "0x8543750", VA = "0x188545150")]
	[CompilerGenerated]
	private void CIAGHBMKHGM(Tuple<KeepsakeRoomInstancesDTO, IReadOnlyDictionary<BALHDFAAENP, KeepsakeCategoryConfigDTO>, KeepsakeGlobalConfigDTO> NDPLDEAJBHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x854F120", Offset = "0x854D720", VA = "0x18854F120")]
	[CompilerGenerated]
	private void OMHEFMKEOHK(string DAANGKEHOHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x854BC90", Offset = "0x854A290", VA = "0x18854BC90")]
	[CompilerGenerated]
	private Task MBPJLGPGGEG(CancellationToken MKIFOAHMMPN)
	{
		return null;
	}
}
namespace RecRoom.Keepsakes
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public class KeepsakesConfig : ScriptableObject, AGMDMCDFNPP<KeepsakesConfig.KeepsakesOptions>
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200002B")]
		public class KeepsakesOptions
		{
			[Cpp2IlInjected.Token(Token = "0x200002C")]
			[CompilerGenerated]
			private sealed class JMNGGFCDHFB
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000098")]
				public string themeId;

				[Cpp2IlInjected.Token(Token = "0x60000F3")]
				[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
				public JMNGGFCDHFB()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000F4")]
				[Cpp2IlInjected.Address(RVA = "0x8553100", Offset = "0x8551700", VA = "0x188553100")]
				internal bool CBLMGAHHJEJ(KeepsakeTheme x)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60000F5")]
				[Cpp2IlInjected.Address(RVA = "0x8553100", Offset = "0x8551700", VA = "0x188553100")]
				internal bool KGGDNHIDBCF(KeepsakeTheme x)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			[SerializeField]
			private KeepsakeTheme[] themes;

			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x85534A0", Offset = "0x8551AA0", VA = "0x1885534A0")]
			public bool BHCGBDKHKCE(string PBBCDOBKLGB, [Out] KeepsakeTheme LMFMHPKLJNK)
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
			[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x8553420", Offset = "0x8551A20", VA = "0x188553420")]
		[EGNICHGEFDG.KHJDAJHJKCM.GHFDKJOPLIL]
		internal static void GOLDGDOKEIF(NMNJFHODGJA JBBCAANONNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0xD5F7D0", Offset = "0xD5DDD0", VA = "0x180D5F7D0")]
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
