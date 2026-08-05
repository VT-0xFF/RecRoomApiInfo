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
		[Cpp2IlInjected.Address(RVA = "0x703B3B0", Offset = "0x703A7B0", VA = "0x18703B3B0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2200990", Offset = "0x21FFD90", VA = "0x182200990")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class ICCBPALNNGE : IComparer<BLGKFNMKMGA>
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private sealed class LCOJLHLBNIN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public BLGKFNMKMGA x;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public BLGKFNMKMGA y;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public LCOJLHLBNIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x9373E0", Offset = "0x9367E0", VA = "0x1809373E0")]
		internal bool ELDDPKKBNHJ(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x1888920", Offset = "0x1887D20", VA = "0x181888920")]
		internal bool IGOPOOAPEDC(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9373E0", Offset = "0x9367E0", VA = "0x1809373E0")]
		internal bool KDCONMCJJFF(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1888920", Offset = "0x1887D20", VA = "0x181888920")]
		internal bool GOKKHGMPEPK(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private List<KeepsakeCategoryThemePair> CMBDPFHBINF;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x8CADF0", Offset = "0x8CA1F0", VA = "0x1808CADF0")]
	public ICCBPALNNGE(List<KeepsakeCategoryThemePair> GHCGLPCFJAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7039D10", Offset = "0x7039110", VA = "0x187039D10", Slot = "4")]
	public int Compare(BLGKFNMKMGA KENGFOGLPKI, BLGKFNMKMGA IFGPABAHODO)
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
		public BLGKFNMKMGA KeepsakeCategory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public KeepsakeTheme KeepsakeTheme;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[GFHMGJFENGN]
public class EDPABKIDEDF : GDPBDJEECFD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class AGCLBLEBHHA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public EDPABKIDEDF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public BLGKFNMKMGA keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public AGCLBLEBHHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x702A500", Offset = "0x7029900", VA = "0x18702A500")]
		internal AMMGOODCICE<Guid> KJOBCAHHGMI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x702A030", Offset = "0x7029430", VA = "0x18702A030")]
		internal void AGBDJHFNDHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x702A4A0", Offset = "0x70298A0", VA = "0x18702A4A0")]
		internal void HMBHPPMPOOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x702A090", Offset = "0x7029490", VA = "0x18702A090")]
		internal void FLKNCICJPCN(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x702A060", Offset = "0x7029460", VA = "0x18702A060")]
		internal void DFILJGLDCKP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class ALCBCMGBJLM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public EDPABKIDEDF <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public ALCBCMGBJLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x702A790", Offset = "0x7029B90", VA = "0x18702A790")]
		internal void FLFDFHLHKAF(CGLOPECGFOI response)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x702AB40", Offset = "0x7029F40", VA = "0x18702AB40")]
		internal void LJIAIIEDBOC(string error)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class MOGEOEOLCPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public KeepsakeTheme theme;

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public MOGEOEOLCPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x703AB00", Offset = "0x7039F00", VA = "0x18703AB00")]
		internal bool BIOEHOKLBBM(KeepsakeCategoryThemePair categoryThemePair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class POHCDHJOPDA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public EDPABKIDEDF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public long progressionEventId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public BLGKFNMKMGA? keepsakeCategory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public POHCDHJOPDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x703AE10", Offset = "0x703A210", VA = "0x18703AE10")]
		internal void LFNJOHHLLOG(KeepsakeProgressionEventInstancesDTO result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x7038E60", Offset = "0x7038260", VA = "0x187038E60")]
		internal void HBDNNEEDDLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x703AEA0", Offset = "0x703A2A0", VA = "0x18703AEA0")]
		internal AMMGOODCICE<IEnumerable<Guid>> MIAMCEONGME()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x6C31B40", Offset = "0x6C30F40", VA = "0x186C31B40")]
		internal bool AIABEMHHGPI(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class AIFOEHNLHNO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public KeepsakeRoomInstanceIdsDTO instancesInRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public POHCDHJOPDA CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public AIFOEHNLHNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x702A650", Offset = "0x7029A50", VA = "0x18702A650")]
		internal AMMGOODCICE<IEnumerable<Guid>> CKLIHPKIFOJ(KeepsakeRoomInstancesDTO roomInstancesDTO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class EBMMEENIPLN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public KeepsakeRoomInstancesDTO roomInstancesDTO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public AIFOEHNLHNO CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public EBMMEENIPLN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x702AD30", Offset = "0x702A130", VA = "0x18702AD30")]
		internal bool IBJDCEIIHCM(Guid instanceId)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class CPIJJECCFOE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Guid instanceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public EBMMEENIPLN CS$<>8__locals3;

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public CPIJJECCFOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x702AC20", Offset = "0x702A020", VA = "0x18702AC20")]
		internal bool FMGJIGMAJCO(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class FKIOOLFBPPO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public EDPABKIDEDF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public FKIOOLFBPPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x7039230", Offset = "0x7038630", VA = "0x187039230")]
		internal AMMGOODCICE<IEnumerable<Guid>> LHDGHLENNBC(IEnumerable<Guid> instanceIds)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x7039210", Offset = "0x7038610", VA = "0x187039210")]
		internal bool FHOAFJEFFDD(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class FEKLOLIHHDL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public EDPABKIDEDF <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public FEKLOLIHHDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x7039180", Offset = "0x7038580", VA = "0x187039180")]
		internal void HKJENDEJKGL(KeepsakeProgressionEventInstancesDTO result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x7038E60", Offset = "0x7038260", VA = "0x187038E60")]
		internal void BGDPOIPOLBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x7038E90", Offset = "0x7038290", VA = "0x187038E90")]
		internal AMMGOODCICE<Dictionary<Guid, BLGKFNMKMGA>> BOECNGGNGIO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x6C31B40", Offset = "0x6C30F40", VA = "0x186C31B40")]
		internal bool DKAAFJGNOPL(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class OAEHLKFGNJK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public KeepsakeRoomInstanceIdsDTO instancesInRoom;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public OAEHLKFGNJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x703ABA0", Offset = "0x7039FA0", VA = "0x18703ABA0")]
		internal AMMGOODCICE<Dictionary<Guid, BLGKFNMKMGA>> GDAFEDPCFNG(KeepsakeRoomInstancesDTO roomInstancesDTO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class KOCNLPOBNMK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public KeepsakeRoomInstancesDTO roomInstancesDTO;

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public KOCNLPOBNMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x703A4B0", Offset = "0x70398B0", VA = "0x18703A4B0")]
		internal bool OKODDODMKPM(Guid instanceId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x703A360", Offset = "0x7039760", VA = "0x18703A360")]
		internal KeyValuePair<Guid, BLGKFNMKMGA> HILLIFAEEHF(Guid instanceId)
		{
			return default(KeyValuePair<Guid, BLGKFNMKMGA>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class JAKLMHGNDMJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public Guid instanceId;

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public JAKLMHGNDMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x1E3C630", Offset = "0x1E3BA30", VA = "0x181E3C630")]
		internal bool NKFLGPFIFEF(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class PLJJJCOBHEJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public Guid instanceId;

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public PLJJJCOBHEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x1E3C630", Offset = "0x1E3BA30", VA = "0x181E3C630")]
		internal bool BLAMKLDBGHO(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class FONLOIKENDN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public EDPABKIDEDF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public FONLOIKENDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x70393E0", Offset = "0x70387E0", VA = "0x1870393E0")]
		internal AMMGOODCICE<Dictionary<Guid, BLGKFNMKMGA>> MLMMGHDAJJF(Dictionary<Guid, BLGKFNMKMGA> instanceIdsAndCategories)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x7039210", Offset = "0x7038610", VA = "0x187039210")]
		internal bool BJBMODGNDCA(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class IJIHDHNFIMC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public KeepsakeRoomInstanceIdsDTO collectedInstanceIds;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public IJIHDHNFIMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x703A0B0", Offset = "0x70394B0", VA = "0x18703A0B0")]
		internal bool FNAINFLFPPD(KeyValuePair<Guid, BLGKFNMKMGA> idCategoryPair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class ECHLMMEHEPL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public Dictionary<Guid, BLGKFNMKMGA> instanceIdsAndCategories;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public ECHLMMEHEPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x702AE60", Offset = "0x702A260", VA = "0x18702AE60")]
		internal KeyValuePair<BLGKFNMKMGA, int> JIECGNIBLLM(BLGKFNMKMGA category)
		{
			return default(KeyValuePair<BLGKFNMKMGA, int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class JOOMBHHFGCB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public BLGKFNMKMGA category;

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public JOOMBHHFGCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0xA01790", Offset = "0xA00B90", VA = "0x180A01790")]
		internal bool HEOANJOCMFA(BLGKFNMKMGA instanceCategory)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class GOGJBEINMDB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public Dictionary<Guid, BLGKFNMKMGA> instanceIdsAndCategories;

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public GOGJBEINMDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x7039BC0", Offset = "0x7038FC0", VA = "0x187039BC0")]
		internal KeyValuePair<BLGKFNMKMGA, int> CCJPGONOKGC(BLGKFNMKMGA category)
		{
			return default(KeyValuePair<BLGKFNMKMGA, int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class BNKDFMJKAFM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public BLGKFNMKMGA category;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public BNKDFMJKAFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0xA01790", Offset = "0xA00B90", VA = "0x180A01790")]
		internal bool BKKKOKAFAMB(BLGKFNMKMGA instanceCategory)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class JODBIPALEND
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public EDPABKIDEDF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public Func<KeepsakeRoomDTO, bool> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public JODBIPALEND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x703A150", Offset = "0x7039550", VA = "0x18703A150")]
		internal bool LCMPAEBOGJE(DateTime nowUtc, DateTime eventStartTime, int roomOrder, TimeSpan unlockStartOffset, TimeSpan unlockInterval, int unlockBatchSize)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x703A240", Offset = "0x7039640", VA = "0x18703A240")]
		internal bool NFCJNALCBOA(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x703A130", Offset = "0x7039530", VA = "0x18703A130")]
		internal bool ABBOCONGNBN(KeepsakeRoomDTO r)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x703A130", Offset = "0x7039530", VA = "0x18703A130")]
		internal bool ILBFPKKNKOG(KeepsakeRoomDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class AIECPKLJIPO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public AIECPKLJIPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0xA99C70", Offset = "0xA99070", VA = "0x180A99C70")]
		internal bool DBILMMHJKHP(KeepsakeRoomListDTO roomList)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class OGEEFFJLCBM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public Func<KeepsakeRoomDTO, bool> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public OGEEFFJLCBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x703AD50", Offset = "0x703A150", VA = "0x18703AD50")]
		internal bool FLKPPDDJCGM(KeepsakeRoomListDTO roomList)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x1E04370", Offset = "0x1E03770", VA = "0x181E04370")]
		internal bool KFFFOOFKNKD(KeepsakeRoomDTO room)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class GKNGIDAODJD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public GKNGIDAODJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x7039B60", Offset = "0x7038F60", VA = "0x187039B60")]
		internal bool CNGFFLOFPPE(KeepsakeRoomListDTO i)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class HKLJHAKNNJG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public HKLJHAKNNJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0xA99C70", Offset = "0xA99070", VA = "0x180A99C70")]
		internal bool KCLADEMHEEF(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class DIFCBFLCDJG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public Guid keepsakeInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public DIFCBFLCDJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x702ACD0", Offset = "0x702A0D0", VA = "0x18702ACD0")]
		internal bool GDNEJPPNLCD(KeyValuePair<Guid, KeepsakeInstanceDTO> instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class INDDMJAGKFF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public BLGKFNMKMGA keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public INDDMJAGKFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x1A77100", Offset = "0x1A76500", VA = "0x181A77100")]
		internal bool LDEKCEEMNMJ(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class KDNFMHHJBFO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public Guid keepsakeInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public KDNFMHHJBFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x703A300", Offset = "0x7039700", VA = "0x18703A300")]
		internal bool BDMMFHPCLGG(KeyValuePair<Guid, KeepsakeInstanceDTO> instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class FMJKIKLGGNF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public BLGKFNMKMGA keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public FMJKIKLGGNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x70393A0", Offset = "0x70387A0", VA = "0x1870393A0")]
		internal bool HCKFMFLBKGN(KeyValuePair<Guid, BLGKFNMKMGA> x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class PDMNHGCIBOM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public BLGKFNMKMGA newKeepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public PDMNHGCIBOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x1A77100", Offset = "0x1A76500", VA = "0x181A77100")]
		internal bool FEJDAEKBJBO(KeepsakeInstanceDTO instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class CCCONGDLBCE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public long currentRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public long? currentSubRoomId;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public CCCONGDLBCE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x702ABA0", Offset = "0x7029FA0", VA = "0x18702ABA0")]
		internal bool LCAPGONPMEI(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class IGHMNGPPMOA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public IReadOnlyList<KeepsakeRoomListDTO> roomList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public IGHMNGPPMOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x7039FC0", Offset = "0x70393C0", VA = "0x187039FC0")]
		internal bool DCAHAGIHGNH(KeepsakeRoomDTO room)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class NLLFEKIHFME
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public KeepsakeRoomDTO room;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public IGHMNGPPMOA CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public NLLFEKIHFME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x703AB20", Offset = "0x7039F20", VA = "0x18703AB20")]
		internal bool ADLPNEHMLOJ(KeepsakeRoomListDTO roomListDto)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private struct GFPDEKPEEFJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public EDPABKIDEDF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public MCGHEPNDHCL args;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x70395E0", Offset = "0x70389E0", VA = "0x1870395E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x7039B00", Offset = "0x7038F00", VA = "0x187039B00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private struct LGBPDOMLLLE : IAsyncStateMachine
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
		public EDPABKIDEDF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public string message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x703A7E0", Offset = "0x7039BE0", VA = "0x18703A7E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x703AA70", Offset = "0x7039E70", VA = "0x18703AA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly DateTime DHHMEHDNGBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly DPBNAKNNKND CNADODAPMKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly JFDAOOGMJJH FGNOMFIMLPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly MCHONDIPPPK MJNMCDGCMNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly PHKJMBBDPIH JGMHIOEOBBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly JGCOOGJEKHJ EKABOCOCDBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly EINJFBIDMKP NDDBHBJJDBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly GGPPIGPEPAI LCGACHEIPAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly HCMOGHGOBGB NPGFBLNGFLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly ALDODBGDBHA OKGKDOLOPOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly DDLIANJKOAK EIOMOJDAKGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly OHIBLGFBNDM PCEDPHKHKKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly GNGEHECHLMB LMPCMNDFEEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly KOPBNHDLIAI GANNDOAINJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly PGEBOAMMCIG LOBFKICGNNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly CNEHIJMIJDK EDNCHDNMNOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly BDHJNNHJNNI<KeepsakesConfig.KeepsakesOptions> MFKLHLPHDGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly AJCHOFIOKBP OMPDJEGMEOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly Dictionary<Guid, KeepsakeInstanceDTO> IIIOCFBDKIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly HashSet<Guid> PKKOGLLLGBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly HashSet<long> MFJIKFKKOKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private Dictionary<BLGKFNMKMGA, int> BFHNOJHDBHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly HashSet<Guid> AAGJOFCODAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly IDisposable DGFMHLNNJHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private Task APDAFDGPAJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private AMMGOODCICE<Guid> HCOPJJOKLON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private long? EADOAFAALGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private KeepsakeProgressionEventInstancesDTO KCJEECPHDHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private AMMGOODCICE<KeepsakeProgressionEventInstancesDTO> GBGKMFIDABH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private IReadOnlyDictionary<BLGKFNMKMGA, KeepsakeCategoryConfigDTO> FFBEJGBOLBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private KeepsakeGlobalConfigDTO JJJMFJGIHEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private HashSet<long> ONBHONOINNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private HashSet<long> BFGMHJMLPDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private List<KeepsakeRoomListDTO> LMFJAAMLDCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private List<KeepsakeRoomListDTO> PAGJBCAALAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private List<KeepsakeRoomListDTO> HPNNIJBGADI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private Dictionary<long, string> LOEIGAIFLHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private Dictionary<long, string> FCPCNHNCPNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private Dictionary<long, DateTime> BDHKBIFIGHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private Dictionary<long, List<KeepsakeRoomDTO>> CJIGCBLBPCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private Dictionary<long, List<KeepsakeRoomDTO>> MADGIALFNAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private Dictionary<long, long> JKKOLHCDAFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly List<string> EALKDJLJLNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private DateTime NBIOODDPKKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly IDisposable LNCGGAGMLOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private Dictionary<Guid, BLGKFNMKMGA> BGBLHDBJDDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private Dictionary<BLGKFNMKMGA, int> MJBKKLGALLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private List<KeepsakeCategoryThemePair> GHCGLPCFJAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private ICCBPALNNGE PDJCIBNJLJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private bool GEDOCCHHPLH;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool EHNDAKOOLCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8F4100", Offset = "0x8F3500", VA = "0x1808F4100", Slot = "53")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8F3F20", Offset = "0x8F3320", VA = "0x1808F3F20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool IGDAPKGDODF
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x70302F0", Offset = "0x702F6F0", VA = "0x1870302F0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool ICKINPAONOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x702FBA0", Offset = "0x702EFA0", VA = "0x18702FBA0", Slot = "36")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private long DMCFCEJAJKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7031350", Offset = "0x7030750", VA = "0x187031350")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private long? HJFLOMGEMJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7032EA0", Offset = "0x70322A0", VA = "0x187032EA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private bool KKCEIMGBLNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7032A00", Offset = "0x7031E00", VA = "0x187032A00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public IReadOnlyList<KeepsakeRoomListDTO> OCKMLJOBDFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x9EBB30", Offset = "0x9EAF30", VA = "0x1809EBB30", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public IReadOnlyList<KeepsakeRoomListDTO> HHNICHJCDIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x985B20", Offset = "0x984F20", VA = "0x180985B20", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IReadOnlyList<KeepsakeRoomListDTO> MGBJHEGOJMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xEDF750", Offset = "0xEDEB50", VA = "0x180EDF750", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public IReadOnlyDictionary<long, string> CKOCFIMHPLK
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x9EBC90", Offset = "0x9EB090", VA = "0x1809EBC90", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	internal bool AFEIMKFJJGE
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x204BAC0", Offset = "0x204AEC0", VA = "0x18204BAC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Guid?> HMHNJJENLOF
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x702E1D0", Offset = "0x702D5D0", VA = "0x18702E1D0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x702F510", Offset = "0x702E910", VA = "0x18702F510", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action FFANJBCKCFP
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7034780", Offset = "0x7033B80", VA = "0x187034780", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7032B50", Offset = "0x7031F50", VA = "0x187032B50", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action CNAMPHIEICK
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x70368D0", Offset = "0x7035CD0", VA = "0x1870368D0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7033BB0", Offset = "0x7032FB0", VA = "0x187033BB0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x70378A0", Offset = "0x7036CA0", VA = "0x1870378A0")]
	[RecRoom.NoEngine.Common.Preserve]
	internal EDPABKIDEDF([CNGCCDLPGOD(null)][NotNull] DPBNAKNNKND CNADODAPMKL, [NotNull][CNGCCDLPGOD(null)] CBKPLBJIJFB JNPEEDEABBA, [NotNull][CNGCCDLPGOD(null)] JFDAOOGMJJH FGNOMFIMLPA, [NotNull][CNGCCDLPGOD(null)] MCHONDIPPPK MJNMCDGCMNF, [CNGCCDLPGOD(null)][NotNull] PHKJMBBDPIH JGMHIOEOBBG, [CNGCCDLPGOD(null)][NotNull] JGCOOGJEKHJ EKABOCOCDBK, [CNGCCDLPGOD(null)][NotNull] EINJFBIDMKP NDDBHBJJDBL, [NotNull][CNGCCDLPGOD(null)] GGPPIGPEPAI LCGACHEIPAL, [NotNull][CNGCCDLPGOD(null)] HCMOGHGOBGB NPGFBLNGFLA, [NotNull][CNGCCDLPGOD(null)] ACBNJEPHHPC IEGEBNIJCJK, [NotNull][CNGCCDLPGOD(null)] ALDODBGDBHA OKGKDOLOPOD, [NotNull][CNGCCDLPGOD(null)] DDLIANJKOAK EIOMOJDAKGL, [NotNull][CNGCCDLPGOD(null)] OHIBLGFBNDM PCEDPHKHKKD, [NotNull][CNGCCDLPGOD(null)] GNGEHECHLMB LMPCMNDFEEC, [CNGCCDLPGOD(null)][NotNull] KOPBNHDLIAI GANNDOAINJH, [CNGCCDLPGOD(null)][NotNull] PGEBOAMMCIG LOBFKICGNNG, [NotNull][CNGCCDLPGOD(null)] CNEHIJMIJDK EDNCHDNMNOO, [CNGCCDLPGOD(null)][NotNull] BDHJNNHJNNI<KeepsakesConfig.KeepsakesOptions> MFKLHLPHDGD, [NotNull][CNGCCDLPGOD(null)] AJCHOFIOKBP OMPDJEGMEOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x702BAA0", Offset = "0x702AEA0", VA = "0x18702BAA0", Slot = "15")]
	public bool AMBKHFNHDJF(List<string> ODNDIMMOBNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x702E280", Offset = "0x702D680", VA = "0x18702E280", Slot = "16")]
	public AMMGOODCICE<Guid> EDCOGBOJMLD(BLGKFNMKMGA HBNOJOAIBEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x70304A0", Offset = "0x702F8A0", VA = "0x1870304A0", Slot = "17")]
	public CLHPIMOBJFN GLIMAMKGGKA(Guid MALKHIENPGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7033F70", Offset = "0x7033370", VA = "0x187033F70", Slot = "18")]
	public CLHPIMOBJFN LMJNAKPPMCG(Guid MALKHIENPGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x70308B0", Offset = "0x702FCB0", VA = "0x1870308B0", Slot = "19")]
	public bool GOPOGOGDHLA(Guid MALKHIENPGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7034A10", Offset = "0x7033E10", VA = "0x187034A10", Slot = "20")]
	public bool MJNIGHHCAJL(Guid MALKHIENPGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x702C670", Offset = "0x702BA70", VA = "0x18702C670")]
	public KeepsakeTheme CAIFLFDPCAP(Guid MALKHIENPGL)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x702CD60", Offset = "0x702C160", VA = "0x18702CD60")]
	public bool DBPFCKCAIPA(BLGKFNMKMGA HBNOJOAIBEL, [Out] KeepsakeTheme MNJLIBOJOED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x702F7F0", Offset = "0x702EBF0", VA = "0x18702F7F0")]
	public List<KeepsakeTheme> FJKOOGAGLEK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x702F5C0", Offset = "0x702E9C0", VA = "0x18702F5C0")]
	public int FHJOKBAPILC(BLGKFNMKMGA HBNOJOAIBEL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7030340", Offset = "0x702F740", VA = "0x187030340")]
	public BLGKFNMKMGA GJMPMPMEFKM(Guid MALKHIENPGL)
	{
		return default(BLGKFNMKMGA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x702FC60", Offset = "0x702F060", VA = "0x18702FC60", Slot = "34")]
	public List<BLGKFNMKMGA> FMANPNBAAGJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7033AF0", Offset = "0x7032EF0", VA = "0x187033AF0", Slot = "35")]
	public IComparer<BLGKFNMKMGA> KOFNDAEOGDH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x702F320", Offset = "0x702E720", VA = "0x18702F320", Slot = "32")]
	public string EOIBDJEDEHM(BLGKFNMKMGA HBNOJOAIBEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x702C920", Offset = "0x702BD20", VA = "0x18702C920", Slot = "33")]
	public string CJCKGDAACFB(BLGKFNMKMGA HBNOJOAIBEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x702FDA0", Offset = "0x702F1A0", VA = "0x18702FDA0", Slot = "21")]
	public bool GEGCNGCOOJK(Guid MALKHIENPGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x70312E0", Offset = "0x70306E0", VA = "0x1870312E0", Slot = "22")]
	public void IEKAEFDOENO(Guid MALKHIENPGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7034A40", Offset = "0x7033E40", VA = "0x187034A40", Slot = "23")]
	public void MNICKGCDFPC(BLGKFNMKMGA HBNOJOAIBEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x702B1B0", Offset = "0x702A5B0", VA = "0x18702B1B0", Slot = "24")]
	public void ADJIHIBLFKA(Guid MALKHIENPGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x702EB50", Offset = "0x702DF50", VA = "0x18702EB50", Slot = "25")]
	public int EKNAHPAJODK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7034DC0", Offset = "0x70341C0", VA = "0x187034DC0", Slot = "31")]
	public AMMGOODCICE<IEnumerable<Guid>> NMDCKPCIOAG(long GGLEGKBAGLC, long MNCEKELOFNA, BLGKFNMKMGA? HBNOJOAIBEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7031420", Offset = "0x7030820", VA = "0x187031420", Slot = "30")]
	public AMMGOODCICE<IEnumerable<Guid>> IJFNCKMCMCM(long GGLEGKBAGLC, long MNCEKELOFNA, BLGKFNMKMGA? HBNOJOAIBEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x702EF70", Offset = "0x702E370", VA = "0x18702EF70", Slot = "54")]
	public AMMGOODCICE<Dictionary<Guid, BLGKFNMKMGA>> ELCLMHDFAHG(long GGLEGKBAGLC, long MNCEKELOFNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x70343E0", Offset = "0x70337E0", VA = "0x1870343E0", Slot = "55")]
	public AMMGOODCICE<Dictionary<Guid, BLGKFNMKMGA>> MDLAGECOFHJ(long GGLEGKBAGLC, long MNCEKELOFNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x702B810", Offset = "0x702AC10", VA = "0x18702B810", Slot = "26")]
	public AMMGOODCICE<int> AIGNHJIFKPO(long GGLEGKBAGLC, long MNCEKELOFNA, BLGKFNMKMGA? HBNOJOAIBEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7034630", Offset = "0x7033A30", VA = "0x187034630", Slot = "27")]
	public AMMGOODCICE<int> MHNHFBNPDLJ(long GGLEGKBAGLC, long MNCEKELOFNA, BLGKFNMKMGA? HBNOJOAIBEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7037690", Offset = "0x7036A90", VA = "0x187037690", Slot = "28")]
	public AMMGOODCICE<Dictionary<BLGKFNMKMGA, int>> PGAPJINCMAK(long GGLEGKBAGLC, long MNCEKELOFNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7034570", Offset = "0x7033970", VA = "0x187034570", Slot = "29")]
	public AMMGOODCICE<Dictionary<BLGKFNMKMGA, int>> MGGDHFKLIGB(long GGLEGKBAGLC, long MNCEKELOFNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7034AE0", Offset = "0x7033EE0", VA = "0x187034AE0", Slot = "37")]
	public bool NDMLFDMFFAB(long GGLEGKBAGLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7032F30", Offset = "0x7032330", VA = "0x187032F30", Slot = "56")]
	public bool JMFEIIPKBEL(long GGLEGKBAGLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x702BD50", Offset = "0x702B150", VA = "0x18702BD50", Slot = "38")]
	public bool BBNNDOOELBB(long GGLEGKBAGLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7033320", Offset = "0x7032720", VA = "0x187033320", Slot = "57")]
	public bool KEPCNGMOMEL(long GGLEGKBAGLC, [Out] OCFDGCNKEJP KDMIBKAPPNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7032A10", Offset = "0x7031E10", VA = "0x187032A10", Slot = "39")]
	public bool JIAEKKPLINB(long EBOAKLNPBFL, [Out] DateTime BKJGMDIIDGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7036970", Offset = "0x7035D70", VA = "0x187036970", Slot = "40")]
	public long OJPJBPKBJAD(long EBOAKLNPBFL)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7030A10", Offset = "0x702FE10", VA = "0x187030A10", Slot = "41")]
	public long GPEADEPEHAH(long GGLEGKBAGLC)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x70337E0", Offset = "0x7032BE0", VA = "0x1870337E0", Slot = "42")]
	public int KLCPNOHOJAM(long EBOAKLNPBFL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7030210", Offset = "0x702F610", VA = "0x187030210", Slot = "43")]
	public bool GGDONFNHEAE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x7037420", Offset = "0x7036820", VA = "0x187037420", Slot = "44")]
	public bool OOHMHOGGOIA(long EBOAKLNPBFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x702CAA0", Offset = "0x702BEA0", VA = "0x18702CAA0", Slot = "45")]
	public IReadOnlyList<long> CKDLJPCIIEJ(long EBOAKLNPBFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7032F90", Offset = "0x7032390", VA = "0x187032F90", Slot = "46")]
	public int JMGOHGNIHEP(long EBOAKLNPBFL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x70356F0", Offset = "0x7034AF0", VA = "0x1870356F0", Slot = "50")]
	public long OCPONGEGPPD(long BFMBDPPKGBL)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x702CF40", Offset = "0x702C340", VA = "0x18702CF40", Slot = "51")]
	public BLGKFNMKMGA DCGCONPFDFB()
	{
		return default(BLGKFNMKMGA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7031CC0", Offset = "0x70310C0", VA = "0x187031CC0")]
	private bool JANBIPJLEGK(Guid MALKHIENPGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7031800", Offset = "0x7030C00", VA = "0x187031800")]
	private void IPLKCGAJEFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7035420", Offset = "0x7034820", VA = "0x187035420")]
	private BLGKFNMKMGA NPPAAPOJFIG()
	{
		return default(BLGKFNMKMGA);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x702C010", Offset = "0x702B410", VA = "0x18702C010")]
	private void BKJHHJNPOJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7037280", Offset = "0x7036680", VA = "0x187037280")]
	private int ONFOCIIMNFA(KeepsakeRoomListDTO JOBEHJMKMOJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x702AFB0", Offset = "0x702A3B0", VA = "0x18702AFB0")]
	private int AAPNPHFKGLK(DateTime HGEHKNCGLPE, DateTime GEFIBBNFMNL, TimeSpan CPDIKMHMOIO, int MJCAMOKMGLK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7034B40", Offset = "0x7033F40", VA = "0x187034B40")]
	private void NICAKCNDIJF(IEnumerable<KeepsakeInstanceDTO> IIIOCFBDKIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7033C50", Offset = "0x7033050", VA = "0x187033C50")]
	private void LGOCMFFGCKL(IEnumerable<KeepsakeCollectionRecordDTO> LJNCADELPGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7036870", Offset = "0x7035C70", VA = "0x187036870")]
	private void OHDMKGJNNLM(IEnumerable<long> LODBAONBNMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0xE2B4E0", Offset = "0xE2A8E0", VA = "0x180E2B4E0")]
	private void NAOPOELNCIC(KeepsakeGlobalConfigDTO JJJMFJGIHEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x702D2A0", Offset = "0x702C6A0", VA = "0x18702D2A0")]
	private bool DDLGMDBEKBC(BLGKFNMKMGA HBNOJOAIBEL, [Out] Guid KILDILCKKEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7032E00", Offset = "0x7032200", VA = "0x187032E00")]
	private bool JKKAFLJDMEC([Out] Guid KILDILCKKEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x70332C0", Offset = "0x70326C0", VA = "0x1870332C0")]
	private bool KDEEIMBBAKA(Guid MALKHIENPGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x7031020", Offset = "0x7030420", VA = "0x187031020")]
	private IEnumerable<Guid> HLMDDLHFLCM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x70315B0", Offset = "0x70309B0", VA = "0x1870315B0")]
	private IEnumerable<KeepsakeInstanceDTO> IMECCEHBJHJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7030F90", Offset = "0x7030390", VA = "0x187030F90")]
	private void HHFOHMLFDPG(Guid MALKHIENPGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x702F740", Offset = "0x702EB40", VA = "0x18702F740")]
	private bool FHODNFHKDEB(Guid MALKHIENPGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x702D500", Offset = "0x702C900", VA = "0x18702D500")]
	private void DIHGECDGJDP(Guid MALKHIENPGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7033E90", Offset = "0x7033290", VA = "0x187033E90")]
	private void LIFJONAAPEK(BLGKFNMKMGA KAEMFOIOGCN, int KKMFFHOBGDI, Dictionary<BLGKFNMKMGA, int> COCOMCFIOFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x70342F0", Offset = "0x70336F0", VA = "0x1870342F0")]
	private int LPEONAELFNB(BLGKFNMKMGA HBNOJOAIBEL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7034840", Offset = "0x7033C40", VA = "0x187034840")]
	private void MJLHMKGFBKA(KeepsakeInstanceDTO BBAGNMLLCDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7032BF0", Offset = "0x7031FF0", VA = "0x187032BF0")]
	private void JKGMEJKPGBL(KeepsakeInstanceDTO BBAGNMLLCDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7036EB0", Offset = "0x70362B0", VA = "0x187036EB0")]
	private void OMAMMJDBDLP(Guid MALKHIENPGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x702CD10", Offset = "0x702C110", VA = "0x18702CD10")]
	private void CONKJJKDPFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x70301F0", Offset = "0x702F5F0", VA = "0x1870301F0")]
	private void GFDLCLAEGAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x702F4A0", Offset = "0x702E8A0", VA = "0x18702F4A0")]
	private void EPKHNNBAPHM(AFMCCHKAGHJ JOIHKBAHMPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x702CD10", Offset = "0x702C110", VA = "0x18702CD10")]
	private void FGMOBHLGJKN(FKKKCGJGODG NCHBKHMIMGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x702CD10", Offset = "0x702C110", VA = "0x18702CD10")]
	private void HKLGHCNLHIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7030B20", Offset = "0x702FF20", VA = "0x187030B20")]
	private void HDEHCCAFLPJ(float LDKAJOKKAHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x702D7D0", Offset = "0x702CBD0", VA = "0x18702D7D0")]
	private void DIPELEBHFDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x70330C0", Offset = "0x70324C0", VA = "0x1870330C0")]
	private bool KCHBDOLDJHN(Guid MALKHIENPGL, [Out] string OEBNPHJPANC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x70326C0", Offset = "0x7031AC0", VA = "0x1870326C0")]
	private bool JFIHFAINIKO(Guid MALKHIENPGL, [Out] KeepsakeCategoryConfigDTO KAEMFOIOGCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x70375B0", Offset = "0x70369B0", VA = "0x1870375B0")]
	private void OOKMFGAMHAE(string EFLBFAGJCHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x702C810", Offset = "0x702BC10", VA = "0x18702C810")]
	private bool CFFKGGAEPHI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x702E890", Offset = "0x702DC90", VA = "0x18702E890")]
	private List<long> EIAKIDAFKCO(IEnumerable<KeepsakeRoomDTO> JECJJKAEHNL, IReadOnlyList<KeepsakeRoomListDTO> KICHBNDPJKI, long EBOAKLNPBFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x7031DF0", Offset = "0x70311F0", VA = "0x187031DF0")]
	private bool JCNCACJAJKJ(Guid MALKHIENPGL, [Out] string PLAICKAFAFJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x702BDF0", Offset = "0x702B1F0", VA = "0x18702BDF0", Slot = "47")]
	public string BHDLCGIHHCL(BMGECNDKKMG LKEPIGCCPNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x702B3F0", Offset = "0x702A7F0", VA = "0x18702B3F0", Slot = "49")]
	public string AHGEOKKAECL(BMGECNDKKMG LKEPIGCCPNB, long GGLEGKBAGLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7030EC0", Offset = "0x70302C0", VA = "0x187030EC0", Slot = "48")]
	public string HFBOOFAPMPG(BMGECNDKKMG LKEPIGCCPNB, int PDNEEDBBLKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x70359B0", Offset = "0x7034DB0", VA = "0x1870359B0")]
	private void OFJCPHGNOHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7031670", Offset = "0x7030A70", VA = "0x187031670")]
	private void IOLKAJFPOGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x702C650", Offset = "0x702BA50", VA = "0x18702C650")]
	private BMGECNDKKMG BNJJELDCMII(CCJKPEKGLDL NLADLJFMCAL)
	{
		return default(BMGECNDKKMG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x7034820", Offset = "0x7033C20", VA = "0x187034820")]
	private BMGECNDKKMG MJJDDFBDCEH(CCJKPEKGLDL NLADLJFMCAL)
	{
		return default(BMGECNDKKMG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7035240", Offset = "0x7034640", VA = "0x187035240")]
	internal static string NPOBECHCBLF(CGLOPECGFOI HEFACCHBBDB, string DGLDFAGBAPK, bool MKKPMBEBCPM, int OPAPMCIABOP, int NPBGGOFCKLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x702DD70", Offset = "0x702D170", VA = "0x18702DD70", Slot = "52")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x7033040", Offset = "0x7032440", VA = "0x187033040")]
	private BMNBHAPJIMJ KBFKKEMOBMI(GHBEGPNJJCK GDDBEGDLDDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7030030", Offset = "0x702F430", VA = "0x187030030")]
	private ELGDDGNBNAM GFBLENEEHHP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7032310", Offset = "0x7031710", VA = "0x187032310")]
	private Task JFEMPFKBKBA(MCGHEPNDHCL DCNLGGHAIIP, CancellationToken FHGIOBPPFHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x70336D0", Offset = "0x7032AD0", VA = "0x1870336D0")]
	[AsyncStateMachine(typeof(GFPDEKPEEFJ))]
	private Task KHCJPAAPHDB(MCGHEPNDHCL DCNLGGHAIIP, CancellationToken FHGIOBPPFHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7035170", Offset = "0x7034570", VA = "0x187035170")]
	private Task NMEEAMKDGHE(MCGHEPNDHCL DCNLGGHAIIP, CancellationToken FHGIOBPPFHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x70339C0", Offset = "0x7032DC0", VA = "0x1870339C0")]
	[AsyncStateMachine(typeof(LGBPDOMLLLE))]
	private Task KNKCJHDCIGH(string LNICHECHJFC, TimeSpan DJKKGFHFCCE, CancellationToken FHGIOBPPFHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x702CD40", Offset = "0x702C140", VA = "0x18702CD40")]
	[CompilerGenerated]
	private void DBEKDCCCLNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7034A90", Offset = "0x7033E90", VA = "0x187034A90")]
	[CompilerGenerated]
	private void NDGNJKBIOBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x702B0B0", Offset = "0x702A4B0", VA = "0x18702B0B0")]
	[CompilerGenerated]
	private bool ACKGODMMDKA(KeepsakeInstanceDTO KENGFOGLPKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7032890", Offset = "0x7031C90", VA = "0x187032890")]
	[CompilerGenerated]
	private AMMGOODCICE<Dictionary<BLGKFNMKMGA, int>> JGGDOGJPIKB(Dictionary<Guid, BLGKFNMKMGA> DCNOGFNAMMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x7031170", Offset = "0x7030570", VA = "0x187031170")]
	[CompilerGenerated]
	private AMMGOODCICE<Dictionary<BLGKFNMKMGA, int>> IAELOLKPLOL(Dictionary<Guid, BLGKFNMKMGA> DCNOGFNAMMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x702BD30", Offset = "0x702B130", VA = "0x18702BD30")]
	[CompilerGenerated]
	private bool AOMOEKLDIFH(KeepsakeRoomListDTO KENGFOGLPKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x702D6A0", Offset = "0x702CAA0", VA = "0x18702D6A0")]
	[CompilerGenerated]
	private bool DIKDMICEFOL(KeepsakeInstanceDTO KENGFOGLPKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7030720", Offset = "0x702FB20", VA = "0x187030720")]
	[CompilerGenerated]
	private void GNACHPPCEEG(Tuple<KeepsakeRoomInstancesDTO, IReadOnlyDictionary<BLGKFNMKMGA, KeepsakeCategoryConfigDTO>, KeepsakeGlobalConfigDTO> ECLEOKJMKCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x702C7B0", Offset = "0x702BBB0", VA = "0x18702C7B0")]
	[CompilerGenerated]
	private void CFDJDCHHNKE(string PLAICKAFAFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x702BE50", Offset = "0x702B250", VA = "0x18702BE50")]
	[CompilerGenerated]
	private Task BIHDGINPKNO(CancellationToken JLAEGOPALBC)
	{
		return null;
	}
}
namespace RecRoom.Keepsakes
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public class KeepsakesConfig : ScriptableObject, BDHJNNHJNNI<KeepsakesConfig.KeepsakesOptions>
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200002B")]
		public class KeepsakesOptions
		{
			[Cpp2IlInjected.Token(Token = "0x200002C")]
			[CompilerGenerated]
			private sealed class MCCOFILDNIL
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000098")]
				public string themeId;

				[Cpp2IlInjected.Token(Token = "0x60000F3")]
				[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
				public MCCOFILDNIL()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000F4")]
				[Cpp2IlInjected.Address(RVA = "0x703AAD0", Offset = "0x7039ED0", VA = "0x18703AAD0")]
				internal bool PCBICIBJIFJ(KeepsakeTheme x)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60000F5")]
				[Cpp2IlInjected.Address(RVA = "0x703AAD0", Offset = "0x7039ED0", VA = "0x18703AAD0")]
				internal bool KFFFLCACILL(KeepsakeTheme x)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			[SerializeField]
			private KeepsakeTheme[] themes;

			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x703A610", Offset = "0x7039A10", VA = "0x18703A610")]
			public bool LOBEMCMAHHC(string CAODEBKBHGA, [Out] KeepsakeTheme MNJLIBOJOED)
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
			[Cpp2IlInjected.Address(RVA = "0x8C7D90", Offset = "0x8C7190", VA = "0x1808C7D90", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x703A590", Offset = "0x7039990", VA = "0x18703A590")]
		[AGCFNMIICNN.OGAOPBBDHOG.CHABDOHBNJI]
		internal static void BMOABOOGHNH(CGJHFFGEHKC CLDCJHAFFHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x962010", Offset = "0x961410", VA = "0x180962010")]
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
