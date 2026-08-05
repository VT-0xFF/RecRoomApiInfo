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
		[Cpp2IlInjected.Address(RVA = "0x854A280", Offset = "0x8548C80", VA = "0x18854A280", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x29CDED0", Offset = "0x29CC8D0", VA = "0x1829CDED0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class NOJOMAMKPAM : IComparer<OJBCBIHCMHF>
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private sealed class HPIGAJDMBHK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public OJBCBIHCMHF x;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public OJBCBIHCMHF y;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public HPIGAJDMBHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xE9BD20", Offset = "0xE9A720", VA = "0x180E9BD20")]
		internal bool HFLNBBAFCGP(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x22301B0", Offset = "0x222EBB0", VA = "0x1822301B0")]
		internal bool CMIDBMLMHJN(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xE9BD20", Offset = "0xE9A720", VA = "0x180E9BD20")]
		internal bool LHKCIKNOBDK(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x22301B0", Offset = "0x222EBB0", VA = "0x1822301B0")]
		internal bool AMPGIKPJIKA(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private List<KeepsakeCategoryThemePair> OOBFBPDCKDL;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0xABA5E0", Offset = "0xAB8FE0", VA = "0x180ABA5E0")]
	public NOJOMAMKPAM(List<KeepsakeCategoryThemePair> DKALAMIJDAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x8549770", Offset = "0x8548170", VA = "0x188549770", Slot = "4")]
	public int Compare(OJBCBIHCMHF FKPKEFAKAOE, OJBCBIHCMHF KEEMKILMOML)
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
		public OJBCBIHCMHF KeepsakeCategory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public KeepsakeTheme KeepsakeTheme;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[LDDMKMABCFO]
public class HGHPNBBHAOD : DNDJMNPJOGO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class DEBLJMNCDJD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public HGHPNBBHAOD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public OJBCBIHCMHF keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public DEBLJMNCDJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x8538FD0", Offset = "0x85379D0", VA = "0x188538FD0")]
		internal FKFADEBPFBK<Guid> BDFLMOGBHLC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x8539590", Offset = "0x8537F90", VA = "0x188539590")]
		internal void JPIGKHPCEMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x8539120", Offset = "0x8537B20", VA = "0x188539120")]
		internal void DHPDNHJLHHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x8539180", Offset = "0x8537B80", VA = "0x188539180")]
		internal void FICFPKKFKDM(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x8538FA0", Offset = "0x85379A0", VA = "0x188538FA0")]
		internal void BBEHEIGIBBI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class LDMAKABDEAP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public HGHPNBBHAOD <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public LDMAKABDEAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8548F70", Offset = "0x8547970", VA = "0x188548F70")]
		internal void HPLLPCEGKLL(MAOIBNGJACL response)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x8548F10", Offset = "0x8547910", VA = "0x188548F10")]
		internal void CIOKCNCFNDB(string error)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class GBDHBAGGAIG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public KeepsakeTheme theme;

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public GBDHBAGGAIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8539D10", Offset = "0x8538710", VA = "0x188539D10")]
		internal bool NHPIAPBFBPJ(KeepsakeCategoryThemePair categoryThemePair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class FOCGBHLIAAL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public HGHPNBBHAOD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public long progressionEventId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public OJBCBIHCMHF? keepsakeCategory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public FOCGBHLIAAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x8539950", Offset = "0x8538350", VA = "0x188539950")]
		internal void JBNGBFCOGJA(KeepsakeProgressionEventInstancesDTO result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x8539920", Offset = "0x8538320", VA = "0x188539920")]
		internal void HDHLJHAHGLI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x85399E0", Offset = "0x85383E0", VA = "0x1885399E0")]
		internal FKFADEBPFBK<IEnumerable<Guid>> MDMNLFOBEJM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x7FEE310", Offset = "0x7FECD10", VA = "0x187FEE310")]
		internal bool OKMHFFIFHHB(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class PJLFIJGJOBO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public KeepsakeRoomInstanceIdsDTO instancesInRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public FOCGBHLIAAL CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public PJLFIJGJOBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x8549B00", Offset = "0x8548500", VA = "0x188549B00")]
		internal FKFADEBPFBK<IEnumerable<Guid>> OLPIIPHDHBP(KeepsakeRoomInstancesDTO roomInstancesDTO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class GNJPCKAPFIH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public KeepsakeRoomInstancesDTO roomInstancesDTO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public PJLFIJGJOBO CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public GNJPCKAPFIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x853A0B0", Offset = "0x8538AB0", VA = "0x18853A0B0")]
		internal bool GINHHEHCBJC(Guid instanceId)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class LOKFDPMJPLM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Guid instanceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public GNJPCKAPFIH CS$<>8__locals3;

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public LOKFDPMJPLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x8549320", Offset = "0x8547D20", VA = "0x188549320")]
		internal bool NCKGGEPBIJF(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class NJKBIOHBKOK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public HGHPNBBHAOD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public NJKBIOHBKOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x8549430", Offset = "0x8547E30", VA = "0x188549430")]
		internal FKFADEBPFBK<IEnumerable<Guid>> EJEEIPJIICP(IEnumerable<Guid> instanceIds)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x85397C0", Offset = "0x85381C0", VA = "0x1885397C0")]
		internal bool CKHFDHNIIBN(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class GKMJAENLMAJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public HGHPNBBHAOD <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public GKMJAENLMAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x853A020", Offset = "0x8538A20", VA = "0x18853A020")]
		internal void NDCEBEOKAOE(KeepsakeProgressionEventInstancesDTO result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x8539920", Offset = "0x8538320", VA = "0x188539920")]
		internal void OCHKFFKCGCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x8539D30", Offset = "0x8538730", VA = "0x188539D30")]
		internal FKFADEBPFBK<Dictionary<Guid, OJBCBIHCMHF>> FGGJALOIDEP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x7FEE310", Offset = "0x7FECD10", VA = "0x187FEE310")]
		internal bool PBAGJJKIAKD(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class PNFNEKHLOPO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public KeepsakeRoomInstanceIdsDTO instancesInRoom;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public PNFNEKHLOPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x8549C80", Offset = "0x8548680", VA = "0x188549C80")]
		internal FKFADEBPFBK<Dictionary<Guid, OJBCBIHCMHF>> MFEBPGDAPNG(KeepsakeRoomInstancesDTO roomInstancesDTO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class PPGADNLBJDM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public KeepsakeRoomInstancesDTO roomInstancesDTO;

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public PPGADNLBJDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x8549E30", Offset = "0x8548830", VA = "0x188549E30")]
		internal bool CPJLAHINLDB(Guid instanceId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x8549F10", Offset = "0x8548910", VA = "0x188549F10")]
		internal KeyValuePair<Guid, OJBCBIHCMHF> IGMNNJMAFBI(Guid instanceId)
		{
			return default(KeyValuePair<Guid, OJBCBIHCMHF>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class HNAFOMHKGLF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public Guid instanceId;

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public HNAFOMHKGLF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x1055F10", Offset = "0x1054910", VA = "0x181055F10")]
		internal bool AHFOOONJAGK(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class IJNBCADAKHG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public Guid instanceId;

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public IJNBCADAKHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x1055F10", Offset = "0x1054910", VA = "0x181055F10")]
		internal bool DGEHCMLAHLI(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class EGIEBPOBNBA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public HGHPNBBHAOD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public EGIEBPOBNBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x85395C0", Offset = "0x8537FC0", VA = "0x1885395C0")]
		internal FKFADEBPFBK<Dictionary<Guid, OJBCBIHCMHF>> LNMLLOOMIJO(Dictionary<Guid, OJBCBIHCMHF> instanceIdsAndCategories)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x85397C0", Offset = "0x85381C0", VA = "0x1885397C0")]
		internal bool LPAJAMCEKGD(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class EHEMNOKCHMH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public KeepsakeRoomInstanceIdsDTO collectedInstanceIds;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public EHEMNOKCHMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x85397E0", Offset = "0x85381E0", VA = "0x1885397E0")]
		internal bool HNOJAFAJBBD(KeyValuePair<Guid, OJBCBIHCMHF> idCategoryPair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class NOIAOLCPHMD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public Dictionary<Guid, OJBCBIHCMHF> instanceIdsAndCategories;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public NOIAOLCPHMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x8549620", Offset = "0x8548020", VA = "0x188549620")]
		internal KeyValuePair<OJBCBIHCMHF, int> HHOHPFMBPOK(OJBCBIHCMHF category)
		{
			return default(KeyValuePair<OJBCBIHCMHF, int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class NGNAEIHJMML
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public OJBCBIHCMHF category;

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public NGNAEIHJMML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0xFC20A0", Offset = "0xFC0AA0", VA = "0x180FC20A0")]
		internal bool LCKFMOHGPAG(OJBCBIHCMHF instanceCategory)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class JAEJOMEHBID
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public Dictionary<Guid, OJBCBIHCMHF> instanceIdsAndCategories;

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public JAEJOMEHBID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x8548780", Offset = "0x8547180", VA = "0x188548780")]
		internal KeyValuePair<OJBCBIHCMHF, int> PHELHALGBPJ(OJBCBIHCMHF category)
		{
			return default(KeyValuePair<OJBCBIHCMHF, int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class CBDECKKAGAF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public OJBCBIHCMHF category;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public CBDECKKAGAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0xFC20A0", Offset = "0xFC0AA0", VA = "0x180FC20A0")]
		internal bool PGHHHJKEHII(OJBCBIHCMHF instanceCategory)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class CGNCABLGPIM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public HGHPNBBHAOD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public Func<KeepsakeRoomDTO, bool> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public CGNCABLGPIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x8538EB0", Offset = "0x85378B0", VA = "0x188538EB0")]
		internal bool GPNGIFDMGLN(DateTime nowUtc, DateTime eventStartTime, int roomOrder, TimeSpan unlockStartOffset, TimeSpan unlockInterval, int unlockBatchSize)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x8538DF0", Offset = "0x85377F0", VA = "0x188538DF0")]
		internal bool ECFKCFHCFOD(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x8538DD0", Offset = "0x85377D0", VA = "0x188538DD0")]
		internal bool BCEKBMHAHAI(KeepsakeRoomDTO r)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x8538DD0", Offset = "0x85377D0", VA = "0x188538DD0")]
		internal bool LBGPJOFLDHK(KeepsakeRoomDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class INJFEAJPFLJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public INJFEAJPFLJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x1369040", Offset = "0x1367A40", VA = "0x181369040")]
		internal bool NGFFHIHJPFO(KeepsakeRoomListDTO roomList)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class EIDCJBBLMFF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public Func<KeepsakeRoomDTO, bool> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public EIDCJBBLMFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x8539860", Offset = "0x8538260", VA = "0x188539860")]
		internal bool NBNFHLAIKFP(KeepsakeRoomListDTO roomList)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x289F1A0", Offset = "0x289DBA0", VA = "0x18289F1A0")]
		internal bool NHGJOFBCBIF(KeepsakeRoomDTO room)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class NDOIMLPCAMG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public NDOIMLPCAMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x85493D0", Offset = "0x8547DD0", VA = "0x1885493D0")]
		internal bool DLPMKPJDFKH(KeepsakeRoomListDTO i)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class OJLPJPNKJEN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public OJLPJPNKJEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x1369040", Offset = "0x1367A40", VA = "0x181369040")]
		internal bool OGBFHCKDDAP(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class ONBBKAINPOG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public Guid keepsakeInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public ONBBKAINPOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x8549A20", Offset = "0x8548420", VA = "0x188549A20")]
		internal bool IHMBHAMPKOI(KeyValuePair<Guid, KeepsakeInstanceDTO> instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class BMMMFGMDINJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public OJBCBIHCMHF keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public BMMMFGMDINJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x2480D80", Offset = "0x247F780", VA = "0x182480D80")]
		internal bool JNDDIDGJEHI(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class BIJHOHPOMHJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public Guid keepsakeInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public BIJHOHPOMHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x8538D70", Offset = "0x8537770", VA = "0x188538D70")]
		internal bool CDNICFODEFO(KeyValuePair<Guid, KeepsakeInstanceDTO> instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class PLJILGOCMCO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public OJBCBIHCMHF keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public PLJILGOCMCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x8549C40", Offset = "0x8548640", VA = "0x188549C40")]
		internal bool CNGFCFELMHJ(KeyValuePair<Guid, OJBCBIHCMHF> x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class NFGPJFHOACM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public OJBCBIHCMHF newKeepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public NFGPJFHOACM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x2480D80", Offset = "0x247F780", VA = "0x182480D80")]
		internal bool MFKCKGONAKD(KeepsakeInstanceDTO instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class PGLPBCPCFPG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public long currentRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public long? currentSubRoomId;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public PGLPBCPCFPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x8549A80", Offset = "0x8548480", VA = "0x188549A80")]
		internal bool KLDEIIINHAG(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class KAGGBLIGLDI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public IReadOnlyList<KeepsakeRoomListDTO> roomList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public KAGGBLIGLDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x85488D0", Offset = "0x85472D0", VA = "0x1885488D0")]
		internal bool OIODOIOBPHJ(KeepsakeRoomDTO room)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class NMDBNMBCIFB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public KeepsakeRoomDTO room;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public KAGGBLIGLDI CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public NMDBNMBCIFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x85495A0", Offset = "0x8547FA0", VA = "0x1885495A0")]
		internal bool FBNAHHEHCLA(KeepsakeRoomListDTO roomListDto)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private struct GOLOLENIDJK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public HGHPNBBHAOD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public CMFAJILFAHI args;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x853A1E0", Offset = "0x8538BE0", VA = "0x18853A1E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x853A700", Offset = "0x8539100", VA = "0x18853A700", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private struct KKGLCHPECLO : IAsyncStateMachine
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
		public HGHPNBBHAOD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public string message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x85489C0", Offset = "0x85473C0", VA = "0x1885489C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x8548C60", Offset = "0x8547660", VA = "0x188548C60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly DateTime JKNEHBCODND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly CCHHFPCJGJG KPCHNIDIEGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly FPFLCBFCCGD ELDIMDDPBDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly KDBNBFOGBKJ NICDIGHELON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly FMCANOBGOOL PDDLIKLBOKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly IHINAEDCPHM NGALMEDAPGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly LHGPGFCMLKM NKMEHEKPBJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly ICCMCAOCNJP CKKGCEBLKJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly HJKBCKDIADL EHCDEMFECBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly LEDGLCJMNLL ENGJEGCCFFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly AFBBPGIGOFP JACGPLDHJDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly CBJAOFNNIOB EMHCGOGBKFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly DHAIBAFNOKJ BMGAFLHELHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly MCGGGBGPEPF DNJDIACKINJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly NJDDFNKNKDL HKJAJPPLJAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly AFCBJHNNPNF LEAGHOGAOII;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly BADJDEJKIIJ<KeepsakesConfig.KeepsakesOptions> ALFCEIKBPNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly JLFIJNDEFBP OPGACPAKDDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly Dictionary<Guid, KeepsakeInstanceDTO> PEBDFNANAJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly HashSet<Guid> DLNOHLCIAMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly HashSet<long> FFKJLFHCIBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private Dictionary<OJBCBIHCMHF, int> AMKMNGJAFOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly HashSet<Guid> FILMNFMOCEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly IDisposable JFIEMNBMCCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private Task IBBMLPKECJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private FKFADEBPFBK<Guid> KINFHGBEHOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private long? GPABNADFNCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private KeepsakeProgressionEventInstancesDTO JFBLNIPAEDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private FKFADEBPFBK<KeepsakeProgressionEventInstancesDTO> PNLJMBILFGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private IReadOnlyDictionary<OJBCBIHCMHF, KeepsakeCategoryConfigDTO> AAJPJJCCPJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private KeepsakeGlobalConfigDTO EEDFOKFIEDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private HashSet<long> HEDPMFIFGFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private HashSet<long> AFAHJECLCJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private List<KeepsakeRoomListDTO> CEBGMFELDHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private List<KeepsakeRoomListDTO> DPPKJEMFLND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private List<KeepsakeRoomListDTO> LECPIAJDGGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private Dictionary<long, string> ADOCAJBFPKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private Dictionary<long, string> DBPOKAFGEOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private Dictionary<long, DateTime> CNNKJLBFAFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private Dictionary<long, List<KeepsakeRoomDTO>> BCBNKABMANO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private Dictionary<long, List<KeepsakeRoomDTO>> BMCNLACJDMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private Dictionary<long, long> HCPJJBLFLKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly List<string> FOMHGJBELHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private DateTime GEJKIKKMJIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly IDisposable KDGNKPIDJOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private Dictionary<Guid, OJBCBIHCMHF> ABNAJHCFBCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private Dictionary<OJBCBIHCMHF, int> PNNBLGKNGBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private List<KeepsakeCategoryThemePair> DKALAMIJDAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private NOJOMAMKPAM FJPCFOJDIPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private bool IEDJNNLFEPF;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool MNPIAINMLDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xADB270", Offset = "0xAD9C70", VA = "0x180ADB270", Slot = "53")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xADAFF0", Offset = "0xAD99F0", VA = "0x180ADAFF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool GENGHMJKEFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x853B650", Offset = "0x853A050", VA = "0x18853B650", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool AJAABMBMPEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x85400B0", Offset = "0x853EAB0", VA = "0x1885400B0", Slot = "36")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private long NAMFDKBNAAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8545680", Offset = "0x8544080", VA = "0x188545680")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private long? MAHFNLNFHIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x853AD70", Offset = "0x8539770", VA = "0x18853AD70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private bool OPNLOJAKBJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8545A70", Offset = "0x8544470", VA = "0x188545A70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public IReadOnlyList<KeepsakeRoomListDTO> JFGGEIIOPEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xC261F0", Offset = "0xC24BF0", VA = "0x180C261F0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public IReadOnlyList<KeepsakeRoomListDTO> KIPDEPBGLHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xC265D0", Offset = "0xC24FD0", VA = "0x180C265D0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IReadOnlyList<KeepsakeRoomListDTO> EGNBJDPENKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xC40F40", Offset = "0xC3F940", VA = "0x180C40F40", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public IReadOnlyDictionary<long, string> NLIAKHLHOFD
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xC29330", Offset = "0xC27D30", VA = "0x180C29330", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	internal bool AGBJPOFPCIP
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xD29940", Offset = "0xD28340", VA = "0x180D29940")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Guid?> HJICEHBINPM
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x853DC30", Offset = "0x853C630", VA = "0x18853DC30", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8543210", Offset = "0x8541C10", VA = "0x188543210", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action FLEJHGJOMPK
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8546870", Offset = "0x8545270", VA = "0x188546870", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x853DB90", Offset = "0x853C590", VA = "0x18853DB90", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action POKGMAMMFKI
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x853B9D0", Offset = "0x853A3D0", VA = "0x18853B9D0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8541E00", Offset = "0x8540800", VA = "0x188541E00", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x85471C0", Offset = "0x8545BC0", VA = "0x1885471C0")]
	[RecRoom.NoEngine.Common.Preserve]
	internal HGHPNBBHAOD([BMCONCJPCIA(null)][NotNull] CCHHFPCJGJG KPCHNIDIEGK, [NotNull][BMCONCJPCIA(null)] FABKHPHGOJG CCLILLPKLPO, [NotNull][BMCONCJPCIA(null)] FPFLCBFCCGD ELDIMDDPBDH, [NotNull][BMCONCJPCIA(null)] KDBNBFOGBKJ NICDIGHELON, [BMCONCJPCIA(null)][NotNull] FMCANOBGOOL PDDLIKLBOKO, [BMCONCJPCIA(null)][NotNull] IHINAEDCPHM NGALMEDAPGH, [BMCONCJPCIA(null)][NotNull] LHGPGFCMLKM NKMEHEKPBJH, [NotNull][BMCONCJPCIA(null)] ICCMCAOCNJP CKKGCEBLKJB, [NotNull][BMCONCJPCIA(null)] HJKBCKDIADL EHCDEMFECBB, [NotNull][BMCONCJPCIA(null)] GOEFANHLKKC PPNGBFCANID, [NotNull][BMCONCJPCIA(null)] LEDGLCJMNLL ENGJEGCCFFH, [NotNull][BMCONCJPCIA(null)] AFBBPGIGOFP JACGPLDHJDA, [NotNull][BMCONCJPCIA(null)] CBJAOFNNIOB EMHCGOGBKFA, [NotNull][BMCONCJPCIA(null)] DHAIBAFNOKJ BMGAFLHELHL, [BMCONCJPCIA(null)][NotNull] MCGGGBGPEPF DNJDIACKINJ, [BMCONCJPCIA(null)][NotNull] NJDDFNKNKDL HKJAJPPLJAG, [NotNull][BMCONCJPCIA(null)] AFCBJHNNPNF LEAGHOGAOII, [BMCONCJPCIA(null)][NotNull] BADJDEJKIIJ<KeepsakesConfig.KeepsakesOptions> ALFCEIKBPNG, [NotNull][BMCONCJPCIA(null)] JLFIJNDEFBP OPGACPAKDDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x853FE20", Offset = "0x853E820", VA = "0x18853FE20", Slot = "15")]
	public bool HEIHGLJHBDD(List<string> DELPMLPOCLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x853F580", Offset = "0x853DF80", VA = "0x18853F580", Slot = "16")]
	public FKFADEBPFBK<Guid> HBNFNCHIDJC(OJBCBIHCMHF CBICHGNAKFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x8541A50", Offset = "0x8540450", VA = "0x188541A50", Slot = "17")]
	public CNBBKAECPOB INCIILNOBAM(Guid KHHJKJEPENJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x853F100", Offset = "0x853DB00", VA = "0x18853F100", Slot = "18")]
	public CNBBKAECPOB GMEJPMILDGB(Guid KHHJKJEPENJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x853C650", Offset = "0x853B050", VA = "0x18853C650", Slot = "19")]
	public bool DAJOFHLNKAF(Guid KHHJKJEPENJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x853B8E0", Offset = "0x853A2E0", VA = "0x18853B8E0", Slot = "20")]
	public bool BMAALLHLDIJ(Guid KHHJKJEPENJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x8544D90", Offset = "0x8543790", VA = "0x188544D90")]
	public KeepsakeTheme MLAFBNPHGCG(Guid KHHJKJEPENJ)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x8541460", Offset = "0x853FE60", VA = "0x188541460")]
	public bool IFANHMGACNM(OJBCBIHCMHF CBICHGNAKFE, [Out] KeepsakeTheme BKNIKPBHFHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x8542290", Offset = "0x8540C90", VA = "0x188542290")]
	public List<KeepsakeTheme> JNIMJMNAKPN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x8541120", Offset = "0x853FB20", VA = "0x188541120")]
	public int HPMLLJCHHCI(OJBCBIHCMHF CBICHGNAKFE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x853B350", Offset = "0x8539D50", VA = "0x18853B350")]
	public OJBCBIHCMHF BFCBEBOCGNE(Guid KHHJKJEPENJ)
	{
		return default(OJBCBIHCMHF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x853A870", Offset = "0x8539270", VA = "0x18853A870", Slot = "34")]
	public List<OJBCBIHCMHF> ABLIMMLGMIF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x853B910", Offset = "0x853A310", VA = "0x18853B910", Slot = "35")]
	public IComparer<OJBCBIHCMHF> BMNPPLMDLJB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x853C7B0", Offset = "0x853B1B0", VA = "0x18853C7B0", Slot = "32")]
	public string DPKGHNAGJMK(OJBCBIHCMHF CBICHGNAKFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x853DCE0", Offset = "0x853C6E0", VA = "0x18853DCE0", Slot = "33")]
	public string FAIOPJPIBFO(OJBCBIHCMHF CBICHGNAKFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x85453E0", Offset = "0x8543DE0", VA = "0x1885453E0", Slot = "21")]
	public bool NKOJHCBMMHH(Guid KHHJKJEPENJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x8546480", Offset = "0x8544E80", VA = "0x188546480", Slot = "22")]
	public void OJGNDCMIGDO(Guid KHHJKJEPENJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x8541F80", Offset = "0x8540980", VA = "0x188541F80", Slot = "23")]
	public void JFKMBJODJAE(OJBCBIHCMHF CBICHGNAKFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x853B6A0", Offset = "0x853A0A0", VA = "0x18853B6A0", Slot = "24")]
	public void BIDEDAEFIAL(Guid KHHJKJEPENJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x8546A70", Offset = "0x8545470", VA = "0x188546A70", Slot = "25")]
	public int PCPOBBCPBGG()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x8542890", Offset = "0x8541290", VA = "0x188542890", Slot = "31")]
	public FKFADEBPFBK<IEnumerable<Guid>> KDPADCJNOKD(long GDCAPMONNDM, long KEFAHAJFGLE, OJBCBIHCMHF? CBICHGNAKFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x853B4B0", Offset = "0x8539EB0", VA = "0x18853B4B0", Slot = "30")]
	public FKFADEBPFBK<IEnumerable<Guid>> BFEBMDAJNCD(long GDCAPMONNDM, long KEFAHAJFGLE, OJBCBIHCMHF? CBICHGNAKFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x853A9C0", Offset = "0x85393C0", VA = "0x18853A9C0", Slot = "54")]
	public FKFADEBPFBK<Dictionary<Guid, OJBCBIHCMHF>> AKJOLPFEIOC(long GDCAPMONNDM, long KEFAHAJFGLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x8542C40", Offset = "0x8541640", VA = "0x188542C40", Slot = "55")]
	public FKFADEBPFBK<Dictionary<Guid, OJBCBIHCMHF>> KEKJODFLOIA(long GDCAPMONNDM, long KEFAHAJFGLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x8542F70", Offset = "0x8541970", VA = "0x188542F70", Slot = "26")]
	public FKFADEBPFBK<int> KJAMLPMIILC(long GDCAPMONNDM, long KEFAHAJFGLE, OJBCBIHCMHF? CBICHGNAKFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x853C4F0", Offset = "0x853AEF0", VA = "0x18853C4F0", Slot = "27")]
	public FKFADEBPFBK<int> CPLAAIPMPMN(long GDCAPMONNDM, long KEFAHAJFGLE, OJBCBIHCMHF? CBICHGNAKFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x8545750", Offset = "0x8544150", VA = "0x188545750", Slot = "28")]
	public FKFADEBPFBK<Dictionary<OJBCBIHCMHF, int>> NLKCBCIPCBD(long GDCAPMONNDM, long KEFAHAJFGLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x8540170", Offset = "0x853EB70", VA = "0x188540170", Slot = "29")]
	public FKFADEBPFBK<Dictionary<OJBCBIHCMHF, int>> HIHDHLFAPAG(long GDCAPMONNDM, long KEFAHAJFGLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x853AE00", Offset = "0x8539800", VA = "0x18853AE00", Slot = "37")]
	public bool ALMAMFINHFP(long GDCAPMONNDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x8545A80", Offset = "0x8544480", VA = "0x188545A80", Slot = "56")]
	public bool OFLLFKFCMDL(long GDCAPMONNDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x8541640", Offset = "0x8540040", VA = "0x188541640", Slot = "38")]
	public bool IHNGHLBMDDJ(long GDCAPMONNDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x853C140", Offset = "0x853AB40", VA = "0x18853C140", Slot = "57")]
	public bool COJFCBCCNBC(long GDCAPMONNDM, [Out] MMONPFCHCMH KCCLOPMBEPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x8546EB0", Offset = "0x85458B0", VA = "0x188546EB0", Slot = "39")]
	public bool PJEAGHPEBEL(long KBFNBNBEBAB, [Out] DateTime CMPCAPDABDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x853D650", Offset = "0x853C050", VA = "0x18853D650", Slot = "40")]
	public long EFEGAKJBBDO(long KBFNBNBEBAB)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x853A760", Offset = "0x8539160", VA = "0x18853A760", Slot = "41")]
	public long ABJLAOOKGKF(long GDCAPMONNDM)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x853E170", Offset = "0x853CB70", VA = "0x18853E170", Slot = "42")]
	public int FIKAGHCMHJB(long KBFNBNBEBAB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x8541EA0", Offset = "0x85408A0", VA = "0x188541EA0", Slot = "43")]
	public bool JDMOINFFJOK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x8542100", Offset = "0x8540B00", VA = "0x188542100", Slot = "44")]
	public bool JLPNMKHPBFH(long KBFNBNBEBAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x853FB90", Offset = "0x853E590", VA = "0x18853FB90", Slot = "45")]
	public IReadOnlyList<long> HCOCMKBAFOK(long KBFNBNBEBAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x853CD90", Offset = "0x853B790", VA = "0x18853CD90", Slot = "46")]
	public int EALBNDHLNNN(long KBFNBNBEBAB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x85442D0", Offset = "0x8542CD0", VA = "0x1885442D0", Slot = "50")]
	public long MBNGOLEAFNG(long PNNEIJPLEHL)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x8545070", Offset = "0x8543A70", VA = "0x188545070", Slot = "51")]
	public OJBCBIHCMHF NALOPJCDFNB()
	{
		return default(OJBCBIHCMHF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x85464F0", Offset = "0x8544EF0", VA = "0x1885464F0")]
	private bool OJHNLDNGHMC(Guid KHHJKJEPENJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x85432C0", Offset = "0x8541CC0", VA = "0x1885432C0")]
	private void KMOOBBMPLDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x85439B0", Offset = "0x85423B0", VA = "0x1885439B0")]
	private OJBCBIHCMHF LLCJNIOOOEO()
	{
		return default(OJBCBIHCMHF);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x853D010", Offset = "0x853BA10", VA = "0x18853D010")]
	private void ECFBFOCBGBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x8542DD0", Offset = "0x85417D0", VA = "0x188542DD0")]
	private int KGDMJMJJPMC(KeepsakeRoomListDTO CFMHBGHMKAM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x8541950", Offset = "0x8540350", VA = "0x188541950")]
	private int IJICEHJKLOG(DateTime BMEINAMLCJH, DateTime IFLHJIGGNKF, TimeSpan PGMBLANHDKF, int BOLAIGPELKG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x853E380", Offset = "0x853CD80", VA = "0x18853E380")]
	private void GCDCBBHJANC(IEnumerable<KeepsakeInstanceDTO> PEBDFNANAJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x8546620", Offset = "0x8545020", VA = "0x188546620")]
	private void OKAEFHPHEJI(IEnumerable<KeepsakeCollectionRecordDTO> BEDMAMNNHFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x853EED0", Offset = "0x853D8D0", VA = "0x18853EED0")]
	private void GJKCLJMLLOG(IEnumerable<long> KOIKNMBKMCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0xB9CAD0", Offset = "0xB9B4D0", VA = "0x180B9CAD0")]
	private void DHDLJKABLJE(KeepsakeGlobalConfigDTO EEDFOKFIEDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x85416E0", Offset = "0x85400E0", VA = "0x1885416E0")]
	private bool IICCNLMGEPG(OJBCBIHCMHF CBICHGNAKFE, [Out] Guid EIBCLPOHBBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x853DE60", Offset = "0x853C860", VA = "0x18853DE60")]
	private bool FEMJJGMMHCA([Out] Guid EIBCLPOHBBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x8546910", Offset = "0x8545310", VA = "0x188546910")]
	private bool OMAJCDFBFFI(Guid KHHJKJEPENJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x853E010", Offset = "0x853CA10", VA = "0x18853E010")]
	private IEnumerable<Guid> FGOKLEFOHAO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x8542640", Offset = "0x8541040", VA = "0x188542640")]
	private IEnumerable<KeepsakeInstanceDTO> KBANANGKEEK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x8544750", Offset = "0x8543150", VA = "0x188544750")]
	private void MJPLGMFBHOO(Guid KHHJKJEPENJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x853E700", Offset = "0x853D100", VA = "0x18853E700")]
	private bool GFLFMJFHEGI(Guid KHHJKJEPENJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x8544ED0", Offset = "0x85438D0", VA = "0x188544ED0")]
	private void MMNIAEAIHGD(Guid KHHJKJEPENJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x853F4A0", Offset = "0x853DEA0", VA = "0x18853F4A0")]
	private void HAIHNFDMNBG(OJBCBIHCMHF NOJNONODDMI, int NDJBKIDHIBG, Dictionary<OJBCBIHCMHF, int> IGHGKMBGPLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x853E610", Offset = "0x853D010", VA = "0x18853E610")]
	private int GDJPJGEBEDM(OJBCBIHCMHF CBICHGNAKFE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x853CE40", Offset = "0x853B840", VA = "0x18853CE40")]
	private void EBBBILCMPOC(KeepsakeInstanceDTO FDMHHJMEOPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x853BC50", Offset = "0x853A650", VA = "0x18853BC50")]
	private void CEOHLIKANII(KeepsakeInstanceDTO FDMHHJMEOPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x8543D70", Offset = "0x8542770", VA = "0x188543D70")]
	private void LOJHHDCPIHB(Guid KHHJKJEPENJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x853E350", Offset = "0x853CD50", VA = "0x18853E350")]
	private void GIALILEKNEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x853FE00", Offset = "0x853E800", VA = "0x18853FE00")]
	private void HDGKFODCOBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x8543790", Offset = "0x8542190", VA = "0x188543790")]
	private void KOCLFPCPDNM(GJIGLAJEIOM MLNHANKLKJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x853E350", Offset = "0x853CD50", VA = "0x18853E350")]
	private void FMDBLKJCGIM(LEGLGJBOCGC PMNHIPACJLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x853E350", Offset = "0x853CD50", VA = "0x18853E350")]
	private void PDOEFIHMLPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x853AE60", Offset = "0x8539860", VA = "0x18853AE60")]
	private void BCPKIHLOOJJ(float PMIHAPOMGLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x85447E0", Offset = "0x85431E0", VA = "0x1885447E0")]
	private void MKMBIDKOGAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x853E7B0", Offset = "0x853D1B0", VA = "0x18853E7B0")]
	private bool GIGMGHFJLDI(Guid KHHJKJEPENJ, [Out] string LPFFEIMINMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x853EF30", Offset = "0x853D930", VA = "0x18853EF30")]
	private bool GKADEEFDDEM(Guid KHHJKJEPENJ, [Out] KeepsakeCategoryConfigDTO NOJNONODDMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x8546970", Offset = "0x8545370", VA = "0x188546970")]
	private void OOJIMEOHGJA(string AKEJFNGKBEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x853DF00", Offset = "0x853C900", VA = "0x18853DF00")]
	private bool FGEHCPEIIBC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x853BE60", Offset = "0x853A860", VA = "0x18853BE60")]
	private List<long> CHOBEKIIGFN(IEnumerable<KeepsakeRoomDTO> MKLIIPOGFOI, IReadOnlyList<KeepsakeRoomListDTO> CKINAFBGBPA, long KBFNBNBEBAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x853E9B0", Offset = "0x853D3B0", VA = "0x18853E9B0")]
	private bool GIOALFAFPFK(Guid KHHJKJEPENJ, [Out] string IHPAEKNOMOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x8545AE0", Offset = "0x85444E0", VA = "0x188545AE0", Slot = "47")]
	public string OGGAOBLPEFB(PBKOMJHLCNG DINIBIEEFJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x8545B40", Offset = "0x8544540", VA = "0x188545B40", Slot = "49")]
	public string OGIDADFDIKK(PBKOMJHLCNG DINIBIEEFJB, long GDCAPMONNDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x8543C90", Offset = "0x8542690", VA = "0x188543C90", Slot = "48")]
	public string LLHDGOKIKFO(PBKOMJHLCNG DINIBIEEFJB, int LFLGOCBKDHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x8540230", Offset = "0x853EC30", VA = "0x188540230")]
	private void HONIKJEGLKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x8542700", Offset = "0x8541100", VA = "0x188542700")]
	private void KCCCOGJEFPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x8546A50", Offset = "0x8545450", VA = "0x188546A50")]
	private PBKOMJHLCNG OPHBHHOFKKC(LCIKBIAEKOC KPMOLHNALPE)
	{
		return default(PBKOMJHLCNG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x853F480", Offset = "0x853DE80", VA = "0x18853F480")]
	private PBKOMJHLCNG GPPLJFDJECA(LCIKBIAEKOC KPMOLHNALPE)
	{
		return default(PBKOMJHLCNG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x853BA70", Offset = "0x853A470", VA = "0x18853BA70")]
	internal static string CBKOBKMPHFE(MAOIBNGJACL EKMCEDIJMDM, string LGNNAMFCFBB, bool FCDMOECGFPP, int LGABGECNCNK, int IHMGFPKFGPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x853C930", Offset = "0x853B330", VA = "0x18853C930", Slot = "52")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x8546400", Offset = "0x8544E00", VA = "0x188546400")]
	private PLLAKKIDGFG OIGHAPJJFMD(FNAEIBBBBBE LFGCONENJAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x85412A0", Offset = "0x853FCA0", VA = "0x1885412A0")]
	private BGBIJHCFHPL IDMBBBCAHEP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x8545F60", Offset = "0x8544960", VA = "0x188545F60")]
	private Task OHABKPNNDCE(CMFAJILFAHI ALHCDLPBNNA, CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x8545960", Offset = "0x8544360", VA = "0x188545960")]
	[AsyncStateMachine(typeof(GOLOLENIDJK))]
	private Task OCLIGEDJCPA(CMFAJILFAHI ALHCDLPBNNA, CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x8546320", Offset = "0x8544D20", VA = "0x188546320")]
	private Task OICGMDAGNPH(CMFAJILFAHI ALHCDLPBNNA, CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x8541CD0", Offset = "0x85406D0", VA = "0x188541CD0")]
	[AsyncStateMachine(typeof(KKGLCHPECLO))]
	private Task INKJDODEPDG(string JEBOHIALEMJ, TimeSpan NKLJDLEGOFO, CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x8543990", Offset = "0x8542390", VA = "0x188543990")]
	[CompilerGenerated]
	private void LKKFOJJKIFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x853B200", Offset = "0x8539C00", VA = "0x18853B200")]
	[CompilerGenerated]
	private void BELMOMDHHGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x853B250", Offset = "0x8539C50", VA = "0x18853B250")]
	[CompilerGenerated]
	private bool BFAKCFEFJJM(KeepsakeInstanceDTO FKPKEFAKAOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x8546FF0", Offset = "0x85459F0", VA = "0x188546FF0")]
	[CompilerGenerated]
	private FKFADEBPFBK<Dictionary<OJBCBIHCMHF, int>> PMCMGEBJAPH(Dictionary<Guid, OJBCBIHCMHF> DOCNDMAILME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x8543800", Offset = "0x8542200", VA = "0x188543800")]
	[CompilerGenerated]
	private FKFADEBPFBK<Dictionary<OJBCBIHCMHF, int>> LHAKIAPFNKE(Dictionary<Guid, OJBCBIHCMHF> DOCNDMAILME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x8543970", Offset = "0x8542370", VA = "0x188543970")]
	[CompilerGenerated]
	private bool LJMHPCEGINL(KeepsakeRoomListDTO FKPKEFAKAOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x8541FD0", Offset = "0x85409D0", VA = "0x188541FD0")]
	[CompilerGenerated]
	private bool JGOCEDEMIBN(KeepsakeInstanceDTO FKPKEFAKAOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x8544140", Offset = "0x8542B40", VA = "0x188544140")]
	[CompilerGenerated]
	private void LPNCBINDOAK(Tuple<KeepsakeRoomInstancesDTO, IReadOnlyDictionary<OJBCBIHCMHF, KeepsakeCategoryConfigDTO>, KeepsakeGlobalConfigDTO> DOFMOFNBENO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x8547160", Offset = "0x8545B60", VA = "0x188547160")]
	[CompilerGenerated]
	private void POLMBMPEEFE(string IHPAEKNOMOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x8544590", Offset = "0x8542F90", VA = "0x188544590")]
	[CompilerGenerated]
	private Task MGPCEKDANIN(CancellationToken LBOKELJLMEH)
	{
		return null;
	}
}
namespace RecRoom.Keepsakes
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public class KeepsakesConfig : ScriptableObject, BADJDEJKIIJ<KeepsakesConfig.KeepsakesOptions>
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200002B")]
		public class KeepsakesOptions
		{
			[Cpp2IlInjected.Token(Token = "0x200002C")]
			[CompilerGenerated]
			private sealed class FPFLBCFLFDE
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000098")]
				public string themeId;

				[Cpp2IlInjected.Token(Token = "0x60000F3")]
				[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
				public FPFLBCFLFDE()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000F4")]
				[Cpp2IlInjected.Address(RVA = "0x8539CE0", Offset = "0x85386E0", VA = "0x188539CE0")]
				internal bool NLGDPFBOCOM(KeepsakeTheme x)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60000F5")]
				[Cpp2IlInjected.Address(RVA = "0x8539CE0", Offset = "0x85386E0", VA = "0x188539CE0")]
				internal bool ANCBGCJNPOP(KeepsakeTheme x)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			[SerializeField]
			private KeepsakeTheme[] themes;

			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x8548D40", Offset = "0x8547740", VA = "0x188548D40")]
			public bool HDOAFPKGEBF(string JCGKACEFOIP, [Out] KeepsakeTheme BKNIKPBHFHG)
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
			[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x8548CC0", Offset = "0x85476C0", VA = "0x188548CC0")]
		[DMKNBLIJJON.EGFDFBOLNDK.IOMGPCDPIJG]
		internal static void CCKCOACOBKL(JBJKIIKOACK KLIEGJHNGPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0xD5D430", Offset = "0xD5BE30", VA = "0x180D5D430")]
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
