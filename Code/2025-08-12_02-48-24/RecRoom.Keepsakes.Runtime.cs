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
		[Cpp2IlInjected.Address(RVA = "0x84B7390", Offset = "0x84B5990", VA = "0x1884B7390", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2960290", Offset = "0x295E890", VA = "0x182960290")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class GLENAKGELMJ : IComparer<FHPPEAFCOMD>
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private sealed class EEELMCEEFMD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public FHPPEAFCOMD x;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public FHPPEAFCOMD y;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public EEELMCEEFMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xE792C0", Offset = "0xE778C0", VA = "0x180E792C0")]
		internal bool NLBACHJGLFM(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x21D4CD0", Offset = "0x21D32D0", VA = "0x1821D4CD0")]
		internal bool FADFLOFEOIF(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xE792C0", Offset = "0xE778C0", VA = "0x180E792C0")]
		internal bool OCAIALHPAOF(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x21D4CD0", Offset = "0x21D32D0", VA = "0x1821D4CD0")]
		internal bool JIOEAFGPFFM(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private List<KeepsakeCategoryThemePair> EIBKLEEOLGA;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0xA9AB40", Offset = "0xA99140", VA = "0x180A9AB40")]
	public GLENAKGELMJ(List<KeepsakeCategoryThemePair> DJNONDHMNAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x84A6CA0", Offset = "0x84A52A0", VA = "0x1884A6CA0", Slot = "4")]
	public int Compare(FHPPEAFCOMD POMPNNDHCKO, FHPPEAFCOMD JLAHKMCOIFF)
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
		public FHPPEAFCOMD KeepsakeCategory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public KeepsakeTheme KeepsakeTheme;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[KALHGBCMMAN]
public class MMMDFJJCOKC : PDHFEEGOKIK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class NFIGOGBFOML
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public MMMDFJJCOKC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public FHPPEAFCOMD keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public NFIGOGBFOML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x84B6780", Offset = "0x84B4D80", VA = "0x1884B6780")]
		internal LDNIFFJFEMD<Guid> DDPHIIGGGLH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x84B66F0", Offset = "0x84B4CF0", VA = "0x1884B66F0")]
		internal void AJHGDOJLOAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x84B6720", Offset = "0x84B4D20", VA = "0x1884B6720")]
		internal void CCGHDBIPEPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x84B68D0", Offset = "0x84B4ED0", VA = "0x1884B68D0")]
		internal void FOEIFILCFIL(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x84B6CE0", Offset = "0x84B52E0", VA = "0x1884B6CE0")]
		internal void OLEIGLMNMIL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class LLMDHBJOEHL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public MMMDFJJCOKC <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public LLMDHBJOEHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x84A8170", Offset = "0x84A6770", VA = "0x1884A8170")]
		internal void EKNPLFNOINE(MNKGFPIOCNG response)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x84A8110", Offset = "0x84A6710", VA = "0x1884A8110")]
		internal void BNJGJPEMHDB(string error)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class JNAEEDPBKAF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public KeepsakeTheme theme;

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public JNAEEDPBKAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x84A7CE0", Offset = "0x84A62E0", VA = "0x1884A7CE0")]
		internal bool MHAAIIKEEJK(KeepsakeCategoryThemePair categoryThemePair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class HGPAHDOEDME
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public MMMDFJJCOKC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public long progressionEventId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public FHPPEAFCOMD? keepsakeCategory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public HGPAHDOEDME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x84A72D0", Offset = "0x84A58D0", VA = "0x1884A72D0")]
		internal void DAANFMADLPB(KeepsakeProgressionEventInstancesDTO result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x84A7360", Offset = "0x84A5960", VA = "0x1884A7360")]
		internal void IEFFGKBOPCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x84A7390", Offset = "0x84A5990", VA = "0x1884A7390")]
		internal LDNIFFJFEMD<IEnumerable<Guid>> PLCHAIPNGAN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x7F85DD0", Offset = "0x7F843D0", VA = "0x187F85DD0")]
		internal bool CIEOODJCPIJ(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class GEMLNNBMINJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public KeepsakeRoomInstanceIdsDTO instancesInRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public HGPAHDOEDME CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public GEMLNNBMINJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x84A6B00", Offset = "0x84A5100", VA = "0x1884A6B00")]
		internal LDNIFFJFEMD<IEnumerable<Guid>> JHLBIFOBDNI(KeepsakeRoomInstancesDTO roomInstancesDTO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class KFGOEACPOGJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public KeepsakeRoomInstancesDTO roomInstancesDTO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public GEMLNNBMINJ CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public KFGOEACPOGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x84A7D00", Offset = "0x84A6300", VA = "0x1884A7D00")]
		internal bool IALOJEJAGBI(Guid instanceId)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class IIEHIPIPLOE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Guid instanceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public KFGOEACPOGJ CS$<>8__locals3;

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public IIEHIPIPLOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x84A78B0", Offset = "0x84A5EB0", VA = "0x1884A78B0")]
		internal bool GCAGPHKHAKO(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class NLAIPOAKPIM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public MMMDFJJCOKC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public NLAIPOAKPIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x84B6F40", Offset = "0x84B5540", VA = "0x1884B6F40")]
		internal LDNIFFJFEMD<IEnumerable<Guid>> PBMOKBGNBAI(IEnumerable<Guid> instanceIds)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x84A7890", Offset = "0x84A5E90", VA = "0x1884A7890")]
		internal bool FHGAKJCAOBF(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class JIFFKIBHHJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public MMMDFJJCOKC <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public JIFFKIBHHJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x84A7C50", Offset = "0x84A6250", VA = "0x1884A7C50")]
		internal void NMEDEMPNIEG(KeepsakeProgressionEventInstancesDTO result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x84A7360", Offset = "0x84A5960", VA = "0x1884A7360")]
		internal void ECJKOJLKFBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x84A7960", Offset = "0x84A5F60", VA = "0x1884A7960")]
		internal LDNIFFJFEMD<Dictionary<Guid, FHPPEAFCOMD>> FDJKDCKOPKN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x7F85DD0", Offset = "0x7F843D0", VA = "0x187F85DD0")]
		internal bool JMOLHMDNFGJ(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class FPMCGKJHGPD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public KeepsakeRoomInstanceIdsDTO instancesInRoom;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public FPMCGKJHGPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x84A6950", Offset = "0x84A4F50", VA = "0x1884A6950")]
		internal LDNIFFJFEMD<Dictionary<Guid, FHPPEAFCOMD>> PMHIBCEHBCE(KeepsakeRoomInstancesDTO roomInstancesDTO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class NJPLMIDOIIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public KeepsakeRoomInstancesDTO roomInstancesDTO;

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public NJPLMIDOIIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x84B6D10", Offset = "0x84B5310", VA = "0x1884B6D10")]
		internal bool GMGCDKCLJHK(Guid instanceId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x84B6DF0", Offset = "0x84B53F0", VA = "0x1884B6DF0")]
		internal KeyValuePair<Guid, FHPPEAFCOMD> OANKCLCJAKH(Guid instanceId)
		{
			return default(KeyValuePair<Guid, FHPPEAFCOMD>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class CCFEPCNKHCD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public Guid instanceId;

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public CCFEPCNKHCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x1021460", Offset = "0x101FA60", VA = "0x181021460")]
		internal bool KPPOAJPHGLI(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class MMKCAFLOOMH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public Guid instanceId;

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public MMKCAFLOOMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x1021460", Offset = "0x101FA60", VA = "0x181021460")]
		internal bool CCBNOGHAEBP(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class IDFFJPBGGFI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public MMMDFJJCOKC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public IDFFJPBGGFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x84A7690", Offset = "0x84A5C90", VA = "0x1884A7690")]
		internal LDNIFFJFEMD<Dictionary<Guid, FHPPEAFCOMD>> GKBFHPMKIKC(Dictionary<Guid, FHPPEAFCOMD> instanceIdsAndCategories)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x84A7890", Offset = "0x84A5E90", VA = "0x1884A7890")]
		internal bool HMLDLIKNMLA(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class HBNGNHMPLKK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public KeepsakeRoomInstanceIdsDTO collectedInstanceIds;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public HBNGNHMPLKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x84A7250", Offset = "0x84A5850", VA = "0x1884A7250")]
		internal bool ODECLEBJEKD(KeyValuePair<Guid, FHPPEAFCOMD> idCategoryPair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class FBFJADLDGHK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public Dictionary<Guid, FHPPEAFCOMD> instanceIdsAndCategories;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public FBFJADLDGHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x84A6280", Offset = "0x84A4880", VA = "0x1884A6280")]
		internal KeyValuePair<FHPPEAFCOMD, int> AKCPJMAOMKB(FHPPEAFCOMD category)
		{
			return default(KeyValuePair<FHPPEAFCOMD, int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class GGFENGCFBOJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public FHPPEAFCOMD category;

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public GGFENGCFBOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0xF99260", Offset = "0xF97860", VA = "0x180F99260")]
		internal bool JKPAPIBNBPO(FHPPEAFCOMD instanceCategory)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class NEBPCAANABN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public Dictionary<Guid, FHPPEAFCOMD> instanceIdsAndCategories;

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public NEBPCAANABN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x84B65A0", Offset = "0x84B4BA0", VA = "0x1884B65A0")]
		internal KeyValuePair<FHPPEAFCOMD, int> FJOLODOLPAI(FHPPEAFCOMD category)
		{
			return default(KeyValuePair<FHPPEAFCOMD, int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class EFOEIKEHLCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public FHPPEAFCOMD category;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public EFOEIKEHLCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0xF99260", Offset = "0xF97860", VA = "0x180F99260")]
		internal bool MJKPPJINEHO(FHPPEAFCOMD instanceCategory)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class BOLOLFEDKAO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public MMMDFJJCOKC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public Func<KeepsakeRoomDTO, bool> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public BOLOLFEDKAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x84A5EA0", Offset = "0x84A44A0", VA = "0x1884A5EA0")]
		internal bool KOLOEMEJDBA(DateTime nowUtc, DateTime eventStartTime, int roomOrder, TimeSpan unlockStartOffset, TimeSpan unlockInterval, int unlockBatchSize)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x84A5F90", Offset = "0x84A4590", VA = "0x1884A5F90")]
		internal bool NPGPODLLNLP(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x84A5E80", Offset = "0x84A4480", VA = "0x1884A5E80")]
		internal bool ANEFBBPKPGN(KeepsakeRoomDTO r)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x84A5E80", Offset = "0x84A4480", VA = "0x1884A5E80")]
		internal bool FCAPCKKCFOL(KeepsakeRoomDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class IDLGKKKFGGH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public IDLGKKKFGGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0xFED1D0", Offset = "0xFEB7D0", VA = "0x180FED1D0")]
		internal bool OJOMDEKAPPI(KeepsakeRoomListDTO roomList)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class NPOPABJAEED
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public Func<KeepsakeRoomDTO, bool> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public NPOPABJAEED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x84B70B0", Offset = "0x84B56B0", VA = "0x1884B70B0")]
		internal bool LPMHMOIBAPM(KeepsakeRoomListDTO roomList)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x2832990", Offset = "0x2830F90", VA = "0x182832990")]
		internal bool PPHNCMJOMPG(KeepsakeRoomDTO room)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class GEOFCJAKBNJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public GEOFCJAKBNJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x84A6C40", Offset = "0x84A5240", VA = "0x1884A6C40")]
		internal bool FKOJMLMEGOH(KeepsakeRoomListDTO i)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class EEOBHCEAGGK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public EEOBHCEAGGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0xFED1D0", Offset = "0xFEB7D0", VA = "0x180FED1D0")]
		internal bool CBBGKGLEDML(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class KIINGMDBDHP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public Guid keepsakeInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public KIINGMDBDHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x84A7E30", Offset = "0x84A6430", VA = "0x1884A7E30")]
		internal bool DPHCIMADMBD(KeyValuePair<Guid, KeepsakeInstanceDTO> instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class LADDOEFLCAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public FHPPEAFCOMD keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public LADDOEFLCAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x242CF30", Offset = "0x242B530", VA = "0x18242CF30")]
		internal bool JOEJPEIMIGB(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class MFDCPJDKGNC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public Guid keepsakeInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public MFDCPJDKGNC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x84A8520", Offset = "0x84A6B20", VA = "0x1884A8520")]
		internal bool FNAPJPKGFII(KeyValuePair<Guid, KeepsakeInstanceDTO> instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class EHBMKDBKEKB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public FHPPEAFCOMD keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public EHBMKDBKEKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x84A6240", Offset = "0x84A4840", VA = "0x1884A6240")]
		internal bool LLJHMIAHKBI(KeyValuePair<Guid, FHPPEAFCOMD> x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class NOONJJIFCEO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public FHPPEAFCOMD newKeepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public NOONJJIFCEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x242CF30", Offset = "0x242B530", VA = "0x18242CF30")]
		internal bool HGAOPKGCNGA(KeepsakeInstanceDTO instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class CGJDJIKKFME
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public long currentRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public long? currentSubRoomId;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public CGJDJIKKFME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x84A6050", Offset = "0x84A4650", VA = "0x1884A6050")]
		internal bool DKOMEPLPLMH(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class CIOIFDBJFDN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public IReadOnlyList<KeepsakeRoomListDTO> roomList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public CIOIFDBJFDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x84A60D0", Offset = "0x84A46D0", VA = "0x1884A60D0")]
		internal bool LBDIIJPCLGP(KeepsakeRoomDTO room)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class EFEIDLJHNFI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public KeepsakeRoomDTO room;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public CIOIFDBJFDN CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public EFEIDLJHNFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x84A61C0", Offset = "0x84A47C0", VA = "0x1884A61C0")]
		internal bool OMELFGGHMEN(KeepsakeRoomListDTO roomListDto)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private struct FDJDKFFBNII : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public MMMDFJJCOKC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public IJFCDEBIONC args;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x84A63D0", Offset = "0x84A49D0", VA = "0x1884A63D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x84A68F0", Offset = "0x84A4EF0", VA = "0x1884A68F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private struct HABDOMNLPIP : IAsyncStateMachine
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
		public MMMDFJJCOKC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public string message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x84A6F50", Offset = "0x84A5550", VA = "0x1884A6F50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x84A71F0", Offset = "0x84A57F0", VA = "0x1884A71F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly DateTime DBNCBPHGNDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly EPIJPKKNJNE JFFHIGNABOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly MNKCCOPFLLA HMAHNOLAPIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly ONOLEPKNCGF KCDDBCINFDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly GGHDICOMJEK GLNABHCOHBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly JLNLKEHGLNB IKNADJOBEJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly AOJALDDEOBI FMJGPDBOGAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly FEMJLABBIID KAFEGFGNLEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly KIEDMBBPLID AKPCIDNDKGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly JKBCGLENMDN MJDGJIJDGGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly FOJNKGKGEHA IHHDCNCNCPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly KDODIGCGHOH KAMCJIDGDIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly AHFAHDPONGL DNGKJLPAODJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly KGNHCANDILK AFPNEGGDGPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly CNKHKECMBDD MGHBJAOGPPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly DKGIANPHICG MCCAGOGFMBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly FIABBMLPIOD<KeepsakesConfig.KeepsakesOptions> EEPOAHLOJPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly NLLNDLCIBOH GKOADHMGHNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly Dictionary<Guid, KeepsakeInstanceDTO> DKLAEHGLFPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly HashSet<Guid> FHEPMKPFGLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly HashSet<long> LNOHDNHHGCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private Dictionary<FHPPEAFCOMD, int> BJAKIFHJNJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly HashSet<Guid> JFLDDNFKMOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly IDisposable PDEJEHENALI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private Task NNCGIFFICIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private LDNIFFJFEMD<Guid> CLLBEEEPCGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private long? NOBOKKHDFLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private KeepsakeProgressionEventInstancesDTO JIMMBHOCIPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private LDNIFFJFEMD<KeepsakeProgressionEventInstancesDTO> JNBPFMAPDBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private IReadOnlyDictionary<FHPPEAFCOMD, KeepsakeCategoryConfigDTO> LDBBMAJDGFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private KeepsakeGlobalConfigDTO GJDNMHPEEAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private HashSet<long> NFFMBOANDHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private HashSet<long> LBLNAFFGLFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private List<KeepsakeRoomListDTO> GJEELIIICPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private List<KeepsakeRoomListDTO> NEICNLFIHHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private List<KeepsakeRoomListDTO> APBGHEPNFNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private Dictionary<long, string> LKDMEEIMJIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private Dictionary<long, string> COOGJICGLOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private Dictionary<long, DateTime> EJJFPMLGFCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private Dictionary<long, List<KeepsakeRoomDTO>> JGBPJBMEMID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private Dictionary<long, List<KeepsakeRoomDTO>> EALLIBPPKJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private Dictionary<long, long> BONGNAMODLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly List<string> LEAIIFALMHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private DateTime LELMMDGCDLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly IDisposable NCIBLHKHPEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private Dictionary<Guid, FHPPEAFCOMD> OBLOGPFMOIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private Dictionary<FHPPEAFCOMD, int> DPDLJJCBNNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private List<KeepsakeCategoryThemePair> DJNONDHMNAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private GLENAKGELMJ PFMHKEDKCHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private bool KFPCKECCPCA;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool JHIEKECOPBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xAC3630", Offset = "0xAC1C30", VA = "0x180AC3630", Slot = "53")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xAC33B0", Offset = "0xAC19B0", VA = "0x180AC33B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool GFMBKNJGAPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x84ACCF0", Offset = "0x84AB2F0", VA = "0x1884ACCF0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool AIIPIELBJGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x84B2A60", Offset = "0x84B1060", VA = "0x1884B2A60", Slot = "36")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private long BJGAILOMFJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x84A8C30", Offset = "0x84A7230", VA = "0x1884A8C30")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private long? ECHPAMCIKJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x84AD140", Offset = "0x84AB740", VA = "0x1884AD140")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private bool NFBMAMMOJAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x84B1E40", Offset = "0x84B0440", VA = "0x1884B1E40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public IReadOnlyList<KeepsakeRoomListDTO> OKBCEMDIHIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xC04210", Offset = "0xC02810", VA = "0x180C04210", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public IReadOnlyList<KeepsakeRoomListDTO> PFCBGNIOCFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xC0ECE0", Offset = "0xC0D2E0", VA = "0x180C0ECE0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IReadOnlyList<KeepsakeRoomListDTO> FKBBPLGDNCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xC1EDB0", Offset = "0xC1D3B0", VA = "0x180C1EDB0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public IReadOnlyDictionary<long, string> IPEGPJBIFEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xC0CC70", Offset = "0xC0B270", VA = "0x180C0CC70", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	internal bool KBHAEBMALOM
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xB6DDB0", Offset = "0xB6C3B0", VA = "0x180B6DDB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Guid?> OKOMNGBJMFF
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x84AAA80", Offset = "0x84A9080", VA = "0x1884AAA80", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x84AB2B0", Offset = "0x84A98B0", VA = "0x1884AB2B0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action KJEIAAIECCB
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x84A8580", Offset = "0x84A6B80", VA = "0x1884A8580", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x84B0AE0", Offset = "0x84AF0E0", VA = "0x1884B0AE0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action KKFDAIPMNNN
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x84B0D60", Offset = "0x84AF360", VA = "0x1884B0D60", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x84B1780", Offset = "0x84AFD80", VA = "0x1884B1780", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x84B4FE0", Offset = "0x84B35E0", VA = "0x1884B4FE0")]
	[RecRoom.NoEngine.Common.Preserve]
	internal MMMDFJJCOKC([OEKMEJFDAAI(null)][NotNull] EPIJPKKNJNE JFFHIGNABOC, [NotNull][OEKMEJFDAAI(null)] KMNENFMKNHB OPOFAOLMBIH, [NotNull][OEKMEJFDAAI(null)] MNKCCOPFLLA HMAHNOLAPIH, [NotNull][OEKMEJFDAAI(null)] ONOLEPKNCGF KCDDBCINFDH, [OEKMEJFDAAI(null)][NotNull] GGHDICOMJEK GLNABHCOHBJ, [OEKMEJFDAAI(null)][NotNull] JLNLKEHGLNB IKNADJOBEJE, [OEKMEJFDAAI(null)][NotNull] AOJALDDEOBI FMJGPDBOGAC, [NotNull][OEKMEJFDAAI(null)] FEMJLABBIID KAFEGFGNLEN, [NotNull][OEKMEJFDAAI(null)] KIEDMBBPLID AKPCIDNDKGF, [NotNull][OEKMEJFDAAI(null)] IADHOCBLLMC NBFGIDDGCBB, [NotNull][OEKMEJFDAAI(null)] JKBCGLENMDN MJDGJIJDGGH, [NotNull][OEKMEJFDAAI(null)] FOJNKGKGEHA IHHDCNCNCPF, [NotNull][OEKMEJFDAAI(null)] KDODIGCGHOH KAMCJIDGDIH, [NotNull][OEKMEJFDAAI(null)] AHFAHDPONGL DNGKJLPAODJ, [OEKMEJFDAAI(null)][NotNull] KGNHCANDILK AFPNEGGDGPJ, [OEKMEJFDAAI(null)][NotNull] CNKHKECMBDD MGHBJAOGPPO, [NotNull][OEKMEJFDAAI(null)] DKGIANPHICG MCCAGOGFMBB, [OEKMEJFDAAI(null)][NotNull] FIABBMLPIOD<KeepsakesConfig.KeepsakesOptions> EEPOAHLOJPI, [NotNull][OEKMEJFDAAI(null)] NLLNDLCIBOH GKOADHMGHNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x84A91B0", Offset = "0x84A77B0", VA = "0x1884A91B0", Slot = "15")]
	public bool BDFNGGHAGGH(List<string> HIMCFIEGNNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x84A8620", Offset = "0x84A6C20", VA = "0x1884A8620", Slot = "16")]
	public LDNIFFJFEMD<Guid> AEPFBIHEODH(FHPPEAFCOMD HMJOAIAPIPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x84ACEC0", Offset = "0x84AB4C0", VA = "0x1884ACEC0", Slot = "17")]
	public CNOKEDEBLOH FGHOMPJPKIE(Guid HMLPHLNLMFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x84B2500", Offset = "0x84B0B00", VA = "0x1884B2500", Slot = "18")]
	public CNOKEDEBLOH KNGNJNOHIOF(Guid HMLPHLNLMFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x84AA780", Offset = "0x84A8D80", VA = "0x1884AA780", Slot = "19")]
	public bool CDLGCDKGIBG(Guid HMLPHLNLMFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x84A8E30", Offset = "0x84A7430", VA = "0x1884A8E30", Slot = "20")]
	public bool AKDLHCMLBIA(Guid HMLPHLNLMFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x84B49A0", Offset = "0x84B2FA0", VA = "0x1884B49A0")]
	public KeepsakeTheme PNNLFIJOLAJ(Guid HMLPHLNLMFM)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x84AD370", Offset = "0x84AB970", VA = "0x1884AD370")]
	public bool GADMDGKPGEG(FHPPEAFCOMD HMJOAIAPIPB, [Out] KeepsakeTheme BIHKFFDJLMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x84B4280", Offset = "0x84B2880", VA = "0x1884B4280")]
	public List<KeepsakeTheme> PFMNGMJBHGC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x84B2880", Offset = "0x84B0E80", VA = "0x1884B2880")]
	public int LJHFICFEBOE(FHPPEAFCOMD HMJOAIAPIPB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x84A9050", Offset = "0x84A7650", VA = "0x1884A9050")]
	public FHPPEAFCOMD BBKILCMACIE(Guid HMLPHLNLMFM)
	{
		return default(FHPPEAFCOMD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x84AA630", Offset = "0x84A8C30", VA = "0x1884AA630", Slot = "34")]
	public List<FHPPEAFCOMD> CBHDMIPLHGJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x84A8E60", Offset = "0x84A7460", VA = "0x1884A8E60", Slot = "35")]
	public IComparer<FHPPEAFCOMD> AMIKLCMGIHL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x84ACD40", Offset = "0x84AB340", VA = "0x1884ACD40", Slot = "32")]
	public string FGHEHOALECL(FHPPEAFCOMD HMJOAIAPIPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x84B3E80", Offset = "0x84B2480", VA = "0x1884B3E80", Slot = "33")]
	public string OKFIDBPNMLP(FHPPEAFCOMD HMJOAIAPIPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x84ADE20", Offset = "0x84AC420", VA = "0x1884ADE20", Slot = "21")]
	public bool GEANHCMNPDO(Guid HMLPHLNLMFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x84B1520", Offset = "0x84AFB20", VA = "0x1884B1520", Slot = "22")]
	public void JMIAFFBLNPN(Guid HMLPHLNLMFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x84B4000", Offset = "0x84B2600", VA = "0x1884B4000", Slot = "23")]
	public void OOELHFPIAPF(FHPPEAFCOMD HMJOAIAPIPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x84B1AE0", Offset = "0x84B00E0", VA = "0x1884B1AE0", Slot = "24")]
	public void KCNCBHJELFM(Guid HMLPHLNLMFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x84AAE70", Offset = "0x84A9470", VA = "0x1884AAE70", Slot = "25")]
	public int CNEEJEFDLMJ()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x84AB920", Offset = "0x84A9F20", VA = "0x1884AB920", Slot = "31")]
	public LDNIFFJFEMD<IEnumerable<Guid>> EAPAOEINJMD(long PANGCFBNCCJ, long DBKMLACHOOC, FHPPEAFCOMD? HMJOAIAPIPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x84AD1D0", Offset = "0x84AB7D0", VA = "0x1884AD1D0", Slot = "30")]
	public LDNIFFJFEMD<IEnumerable<Guid>> FLNHHNKDCCL(long PANGCFBNCCJ, long DBKMLACHOOC, FHPPEAFCOMD? HMJOAIAPIPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x84B0730", Offset = "0x84AED30", VA = "0x1884B0730", Slot = "54")]
	public LDNIFFJFEMD<Dictionary<Guid, FHPPEAFCOMD>> IIOLGMKMBNK(long PANGCFBNCCJ, long DBKMLACHOOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x84B2300", Offset = "0x84B0900", VA = "0x1884B2300", Slot = "55")]
	public LDNIFFJFEMD<Dictionary<Guid, FHPPEAFCOMD>> KMGPCBDMMPJ(long PANGCFBNCCJ, long DBKMLACHOOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x84AAB30", Offset = "0x84A9130", VA = "0x1884AAB30", Slot = "26")]
	public LDNIFFJFEMD<int> CHNDLJLGLAL(long PANGCFBNCCJ, long DBKMLACHOOC, FHPPEAFCOMD? HMJOAIAPIPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x84AB360", Offset = "0x84A9960", VA = "0x1884AB360", Slot = "27")]
	public LDNIFFJFEMD<int> DOPFJPKPODA(long PANGCFBNCCJ, long DBKMLACHOOC, FHPPEAFCOMD? HMJOAIAPIPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x84B1FE0", Offset = "0x84B05E0", VA = "0x1884B1FE0", Slot = "28")]
	public LDNIFFJFEMD<Dictionary<FHPPEAFCOMD, int>> KKPEBDBHNKL(long PANGCFBNCCJ, long DBKMLACHOOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x84A9650", Offset = "0x84A7C50", VA = "0x1884A9650", Slot = "29")]
	public LDNIFFJFEMD<Dictionary<FHPPEAFCOMD, int>> BLJBEGAPPDM(long PANGCFBNCCJ, long DBKMLACHOOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x84AC520", Offset = "0x84AAB20", VA = "0x1884AC520", Slot = "37")]
	public bool ENFLIGMNGCG(long PANGCFBNCCJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x84AF1A0", Offset = "0x84AD7A0", VA = "0x1884AF1A0", Slot = "56")]
	public bool HDDFANHKLPG(long PANGCFBNCCJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x84B1DA0", Offset = "0x84B03A0", VA = "0x1884B1DA0", Slot = "38")]
	public bool KGJIKCHONNO(long PANGCFBNCCJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x84ADA70", Offset = "0x84AC070", VA = "0x1884ADA70", Slot = "57")]
	public bool GDHGHACKGFO(long PANGCFBNCCJ, [Out] MCFKMNHFGGB LMLHEPFBBCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x84ACAD0", Offset = "0x84AB0D0", VA = "0x1884ACAD0", Slot = "39")]
	public bool EPFDOCFNIEO(long DPAAGCAMIEF, [Out] DateTime CEIHKPAPGOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x84AE6E0", Offset = "0x84ACCE0", VA = "0x1884AE6E0", Slot = "40")]
	public long GKPPEOOCFCC(long DPAAGCAMIEF)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x84B1230", Offset = "0x84AF830", VA = "0x1884B1230", Slot = "41")]
	public long JGPGHCHLINF(long PANGCFBNCCJ)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x84B3110", Offset = "0x84B1710", VA = "0x1884B3110", Slot = "42")]
	public int MFKLBKOMFHN(long DPAAGCAMIEF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x84B3AF0", Offset = "0x84B20F0", VA = "0x1884B3AF0", Slot = "43")]
	public bool OAGLCDIPNLG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x84B3BF0", Offset = "0x84B21F0", VA = "0x1884B3BF0", Slot = "44")]
	public bool OIGFMOHBBIK(long DPAAGCAMIEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x84B4D70", Offset = "0x84B3370", VA = "0x1884B4D70", Slot = "45")]
	public IReadOnlyList<long> POJJIHNDDFF(long DPAAGCAMIEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x84B0EF0", Offset = "0x84AF4F0", VA = "0x1884B0EF0", Slot = "46")]
	public int IOINLFGJKGE(long DPAAGCAMIEF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x84B1820", Offset = "0x84AFE20", VA = "0x1884B1820", Slot = "50")]
	public long KADGFIMPDND(long EMOFGDMAEMC)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x84AF890", Offset = "0x84ADE90", VA = "0x1884AF890", Slot = "51")]
	public FHPPEAFCOMD HNPKMOCHJKE()
	{
		return default(FHPPEAFCOMD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x84A8F20", Offset = "0x84A7520", VA = "0x1884A8F20")]
	private bool AOLHDFJEGBP(Guid HMLPHLNLMFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x84ABFA0", Offset = "0x84AA5A0", VA = "0x1884ABFA0")]
	private void EKLEEOMMANM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x84AC680", Offset = "0x84AAC80", VA = "0x1884AC680")]
	private FHPPEAFCOMD EOLBJIFDEJH()
	{
		return default(FHPPEAFCOMD);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x84AFF40", Offset = "0x84AE540", VA = "0x1884AFF40")]
	private void IFCKNBEDCPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x84B4800", Offset = "0x84B2E00", VA = "0x1884B4800")]
	private int PMHJMLIMPAF(KeepsakeRoomListDTO AIBJLPBMEEH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x84AC580", Offset = "0x84AAB80", VA = "0x1884AC580")]
	private int ENOAOJHFILG(DateTime PNEILPAMGDP, DateTime KFHGNAKEKDC, TimeSpan ENIGFCAAEEJ, int GCEPJCNKNFL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x84B4AE0", Offset = "0x84B30E0", VA = "0x1884B4AE0")]
	private void POGAPPNFDDL(IEnumerable<KeepsakeInstanceDTO> DKLAEHGLFPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x84B2EC0", Offset = "0x84B14C0", VA = "0x1884B2EC0")]
	private void MEDKPOKEHII(IEnumerable<KeepsakeCollectionRecordDTO> NICGICBEIJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x84AE680", Offset = "0x84ACC80", VA = "0x1884AE680")]
	private void GKHKILLGGNF(IEnumerable<long> DBGLGMMHDAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0xB859D0", Offset = "0xB83FD0", VA = "0x180B859D0")]
	private void BNCDKGDPJJG(KeepsakeGlobalConfigDTO GJDNMHPEEAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x84B3460", Offset = "0x84B1A60", VA = "0x1884B3460")]
	private bool MJMDMPHDKND(FHPPEAFCOMD HMJOAIAPIPB, [Out] Guid HCJAEDPDKCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x84AADD0", Offset = "0x84A93D0", VA = "0x1884AADD0")]
	private bool CICOOFKIOEE([Out] Guid HCJAEDPDKCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x84B2A00", Offset = "0x84B1000", VA = "0x1884B2A00")]
	private bool LNHLDANPPLM(Guid HMLPHLNLMFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x84AEC20", Offset = "0x84AD220", VA = "0x1884AEC20")]
	private IEnumerable<Guid> GLEIMCALEPH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x84ABD20", Offset = "0x84AA320", VA = "0x1884ABD20")]
	private IEnumerable<KeepsakeInstanceDTO> EEMINPIDKGN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x84B11A0", Offset = "0x84AF7A0", VA = "0x1884B11A0")]
	private void JFKOBFNHHPG(Guid HMLPHLNLMFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x84AC470", Offset = "0x84AAA70", VA = "0x1884AC470")]
	private bool EMNHCEENCIB(Guid HMLPHLNLMFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x84AA8E0", Offset = "0x84A8EE0", VA = "0x1884AA8E0")]
	private void CFJIOLCKMAK(Guid HMLPHLNLMFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x84B41A0", Offset = "0x84B27A0", VA = "0x1884B41A0")]
	private void PCOOFOIOMAO(FHPPEAFCOMD HIKGHFOMFFB, int FEEOAMBCAFN, Dictionary<FHPPEAFCOMD, int> MHKIMMFFIBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x84B0E00", Offset = "0x84AF400", VA = "0x1884B0E00")]
	private int IMPPDPDEHNF(FHPPEAFCOMD HMJOAIAPIPB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x84B4630", Offset = "0x84B2C30", VA = "0x1884B4630")]
	private void PICNMFPMNFC(KeepsakeInstanceDTO ADBIAPLAOEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x84A9440", Offset = "0x84A7A40", VA = "0x1884A9440")]
	private void BJMIFFFMGMG(KeepsakeInstanceDTO ADBIAPLAOEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x84AE290", Offset = "0x84AC890", VA = "0x1884AE290")]
	private void GHAAHFLNIPF(Guid HMLPHLNLMFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x84AA600", Offset = "0x84A8C00", VA = "0x1884AA600")]
	private void BOCNHCCIFIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x84B3BD0", Offset = "0x84B21D0", VA = "0x1884B3BD0")]
	private void OBHOEAGCAPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x84B2490", Offset = "0x84B0A90", VA = "0x1884B2490")]
	private void KMJMGMAKJNF(LENFHGBFNGI KJJNKABOFCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x84AA600", Offset = "0x84A8C00", VA = "0x1884AA600")]
	private void OINCCJGHAAN(BNPGBAKMNMM NDBJJGOPOFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x84AA600", Offset = "0x84A8C00", VA = "0x1884AA600")]
	private void INPBBDMKHAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x84B2B20", Offset = "0x84B1120", VA = "0x1884B2B20")]
	private void MCNAEIJHGOB(float EEOAGLADFHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x84AF200", Offset = "0x84AD800", VA = "0x1884AF200")]
	private void HJHEBCEEOFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x84B0FA0", Offset = "0x84AF5A0", VA = "0x1884B0FA0")]
	private bool JEHPBFHAPBG(Guid HMLPHLNLMFM, [Out] string FGOOHGHKBPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x84AE0C0", Offset = "0x84AC6C0", VA = "0x1884AE0C0")]
	private bool GFJAKDOPAEK(Guid HMLPHLNLMFM, [Out] KeepsakeCategoryConfigDTO HIKGHFOMFFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x84AF7B0", Offset = "0x84ADDB0", VA = "0x1884AF7B0")]
	private void HJIJAEAGGAD(string DMGMBCGCHOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x84B1670", Offset = "0x84AFC70", VA = "0x1884B1670")]
	private bool JOGGMNPLIFO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x84AFC00", Offset = "0x84AE200", VA = "0x1884AFC00")]
	private List<long> HOIJHKPHCFI(IEnumerable<KeepsakeRoomDTO> LIOCPDKFEFG, IReadOnlyList<KeepsakeRoomListDTO> LOKPHEHDMMM, long DPAAGCAMIEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x84AD550", Offset = "0x84ABB50", VA = "0x1884AD550")]
	private bool GBLEJMBLOCJ(Guid HMLPHLNLMFM, [Out] string GJJJIJGCEEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x84B3A90", Offset = "0x84B2090", VA = "0x1884B3A90", Slot = "47")]
	public string NBKHCMCCHMB(AFJAGDNCGCG NHEOECMPBNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x84AED80", Offset = "0x84AD380", VA = "0x1884AED80", Slot = "49")]
	public string GNLAGIPJENP(AFJAGDNCGCG NHEOECMPBNP, long PANGCFBNCCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x84ACC10", Offset = "0x84AB210", VA = "0x1884ACC10", Slot = "48")]
	public string FDCCGFKJENF(AFJAGDNCGCG NHEOECMPBNP, int BFBICABCACI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x84A9710", Offset = "0x84A7D10", VA = "0x1884A9710")]
	private void BNOBLEDHKHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x84B1E50", Offset = "0x84B0450", VA = "0x1884B1E50")]
	private void KKHDFPMLNKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x84AE660", Offset = "0x84ACC60", VA = "0x1884AE660")]
	private AFJAGDNCGCG GJLBJEACEPK(ONPGLOLIMJA MKGBBGPINMH)
	{
		return default(AFJAGDNCGCG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x84B0580", Offset = "0x84AEB80", VA = "0x1884B0580")]
	private AFJAGDNCGCG IHGKFGIMGEB(ONPGLOLIMJA MKGBBGPINMH)
	{
		return default(AFJAGDNCGCG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x84B1340", Offset = "0x84AF940", VA = "0x1884B1340")]
	internal static string JIOKPBGEGAF(MNKGFPIOCNG LEFGFCJGALC, string IJLAMAKNJJG, bool HBGADANLHJK, int HOOAEDNPGFK, int BMEMDMDBFNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x84AB4C0", Offset = "0x84A9AC0", VA = "0x1884AB4C0", Slot = "52")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x84B1D20", Offset = "0x84B0320", VA = "0x1884B1D20")]
	private BIPOFBJBGMJ KDALJBJNLPP(NGPBJJLAELK GLGPDEGBMNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x84B0B80", Offset = "0x84AF180", VA = "0x1884B0B80")]
	private PPBHMNHJALP ILAKNJAMGKO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x84B36D0", Offset = "0x84B1CD0", VA = "0x1884B36D0")]
	private Task MPOMOBLEBBH(IJFCDEBIONC KGIPMLMDBBA, CancellationToken MEKNAIONNND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x84B21F0", Offset = "0x84B07F0", VA = "0x1884B21F0")]
	[AsyncStateMachine(typeof(FDJDKFFBNII))]
	private Task KLAEAKCDLHJ(IJFCDEBIONC KGIPMLMDBBA, CancellationToken MEKNAIONNND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x84B1590", Offset = "0x84AFB90", VA = "0x1884B1590")]
	private Task JMLPEMNKKOC(IJFCDEBIONC KGIPMLMDBBA, CancellationToken MEKNAIONNND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x84A8D00", Offset = "0x84A7300", VA = "0x1884A8D00")]
	[AsyncStateMachine(typeof(HABDOMNLPIP))]
	private Task AIIJHNHEHPI(string IFEHDCDCFPK, TimeSpan OKDCHLACJMH, CancellationToken MEKNAIONNND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x84B4050", Offset = "0x84B2650", VA = "0x1884B4050")]
	[CompilerGenerated]
	private void OPJKDDJJEKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x84ABCD0", Offset = "0x84AA2D0", VA = "0x1884ABCD0")]
	[CompilerGenerated]
	private void ECMLNJOCPGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x84B3D80", Offset = "0x84B2380", VA = "0x1884B3D80")]
	[CompilerGenerated]
	private bool OIMJKGMDJLD(KeepsakeInstanceDTO POMPNNDHCKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x84B32F0", Offset = "0x84B18F0", VA = "0x1884B32F0")]
	[CompilerGenerated]
	private LDNIFFJFEMD<Dictionary<FHPPEAFCOMD, int>> MGFKDKDDEML(Dictionary<Guid, FHPPEAFCOMD> FMBDJAAKJGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x84AC960", Offset = "0x84AAF60", VA = "0x1884AC960")]
	[CompilerGenerated]
	private LDNIFFJFEMD<Dictionary<FHPPEAFCOMD, int>> EONJEBMADEL(Dictionary<Guid, FHPPEAFCOMD> FMBDJAAKJGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x84B0D40", Offset = "0x84AF340", VA = "0x1884B0D40")]
	[CompilerGenerated]
	private bool ILELEPLKEAC(KeepsakeRoomListDTO POMPNNDHCKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x84B4070", Offset = "0x84B2670", VA = "0x1884B4070")]
	[CompilerGenerated]
	private bool PBLOHMFLOFK(KeepsakeInstanceDTO POMPNNDHCKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x84B05A0", Offset = "0x84AEBA0", VA = "0x1884B05A0")]
	[CompilerGenerated]
	private void IHJJFBHLIFN(Tuple<KeepsakeRoomInstancesDTO, IReadOnlyDictionary<FHPPEAFCOMD, KeepsakeCategoryConfigDTO>, KeepsakeGlobalConfigDTO> CJDAJOJGDLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x84AFEE0", Offset = "0x84AE4E0", VA = "0x1884AFEE0")]
	[CompilerGenerated]
	private void IEKNNEGOBGO(string GJJJIJGCEEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x84ABDE0", Offset = "0x84AA3E0", VA = "0x1884ABDE0")]
	[CompilerGenerated]
	private Task EGNHANEEGCO(CancellationToken BBCLHPFAKCF)
	{
		return null;
	}
}
namespace RecRoom.Keepsakes
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public class KeepsakesConfig : ScriptableObject, FIABBMLPIOD<KeepsakesConfig.KeepsakesOptions>
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200002B")]
		public class KeepsakesOptions
		{
			[Cpp2IlInjected.Token(Token = "0x200002C")]
			[CompilerGenerated]
			private sealed class KPIOHFMDPKG
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000098")]
				public string themeId;

				[Cpp2IlInjected.Token(Token = "0x60000F3")]
				[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
				public KPIOHFMDPKG()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000F4")]
				[Cpp2IlInjected.Address(RVA = "0x84A7E90", Offset = "0x84A6490", VA = "0x1884A7E90")]
				internal bool JMKELALEPPO(KeepsakeTheme x)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60000F5")]
				[Cpp2IlInjected.Address(RVA = "0x84A7E90", Offset = "0x84A6490", VA = "0x1884A7E90")]
				internal bool HIJEEGINIEB(KeepsakeTheme x)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			[SerializeField]
			private KeepsakeTheme[] themes;

			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x84A7F40", Offset = "0x84A6540", VA = "0x1884A7F40")]
			public bool JBCGPCPBEIP(string HDPLGPAMIDO, [Out] KeepsakeTheme BIHKFFDJLMB)
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
			[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x84A7EC0", Offset = "0x84A64C0", VA = "0x1884A7EC0")]
		[LAFCEDCMNGK.DCDCJCFDIHP.KFAGBDMOPBG]
		internal static void ADENDBKKDEC(CFPMHDJNIAH LOLOEONEEKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0xD461A0", Offset = "0xD447A0", VA = "0x180D461A0")]
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
