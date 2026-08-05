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
		[Cpp2IlInjected.Address(RVA = "0x72C5420", Offset = "0x72C4220", VA = "0x1872C5420", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2408FF0", Offset = "0x2407DF0", VA = "0x182408FF0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class IPPHIAFOPOP : IComparer<MJGAMLALHAD>
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private sealed class IMCKDANIIJN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public MJGAMLALHAD x;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public MJGAMLALHAD y;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public IMCKDANIIJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xB9F450", Offset = "0xB9E250", VA = "0x180B9F450")]
		internal bool OIDLMGGDJDF(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x1C45C10", Offset = "0x1C44A10", VA = "0x181C45C10")]
		internal bool HODBCFNKMKK(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xB9F450", Offset = "0xB9E250", VA = "0x180B9F450")]
		internal bool LHHHGPFFNFM(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1C45C10", Offset = "0x1C44A10", VA = "0x181C45C10")]
		internal bool FLHAKLKNHMK(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private List<KeepsakeCategoryThemePair> IABOFILDGCF;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x8FE740", Offset = "0x8FD540", VA = "0x1808FE740")]
	public IPPHIAFOPOP(List<KeepsakeCategoryThemePair> BCKFMLEMMAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x72C2950", Offset = "0x72C1750", VA = "0x1872C2950", Slot = "4")]
	public int Compare(MJGAMLALHAD LBONEMFCDEA, MJGAMLALHAD IOKFBHNPJAN)
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
		public MJGAMLALHAD KeepsakeCategory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public KeepsakeTheme KeepsakeTheme;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[HLDENJBKDHO]
public class GDEJGFIAMIL : KGJJNCGCPGF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class KFNNCPBIKIH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public GDEJGFIAMIL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public MJGAMLALHAD keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public KFNNCPBIKIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x72C3400", Offset = "0x72C2200", VA = "0x1872C3400")]
		internal MNHDJBCOCND<Guid> EFBGMLAPDDL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x72C33D0", Offset = "0x72C21D0", VA = "0x1872C33D0")]
		internal void CIADIOPAEHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x72C3580", Offset = "0x72C2380", VA = "0x1872C3580")]
		internal void KALPCJLNFON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x72C2FC0", Offset = "0x72C1DC0", VA = "0x1872C2FC0")]
		internal void CBBDBLOFAKM(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x72C3550", Offset = "0x72C2350", VA = "0x1872C3550")]
		internal void HHJHFFODLGM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class OPAJHGOFJOJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public GDEJGFIAMIL <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public OPAJHGOFJOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x72C4DF0", Offset = "0x72C3BF0", VA = "0x1872C4DF0")]
		internal void CNOPGIPLLPB(JJOANLDPPDF response)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x72C51A0", Offset = "0x72C3FA0", VA = "0x1872C51A0")]
		internal void JOHLNMDIFDC(string error)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class GDHIBNIKPEM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public KeepsakeTheme theme;

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public GDHIBNIKPEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x72C24F0", Offset = "0x72C12F0", VA = "0x1872C24F0")]
		internal bool OANEGBDDPCK(KeepsakeCategoryThemePair categoryThemePair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class KGBKPOJMNNN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public GDEJGFIAMIL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public long progressionEventId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public MJGAMLALHAD? keepsakeCategory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public KGBKPOJMNNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x72C3610", Offset = "0x72C2410", VA = "0x1872C3610")]
		internal void AMMJJMLENCB(KeepsakeProgressionEventInstancesDTO result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x72C35E0", Offset = "0x72C23E0", VA = "0x1872C35E0")]
		internal void ADIMPHGMIPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x72C36A0", Offset = "0x72C24A0", VA = "0x1872C36A0")]
		internal MNHDJBCOCND<IEnumerable<Guid>> CDKHKDCDKGC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x6E99480", Offset = "0x6E98280", VA = "0x186E99480")]
		internal bool IGJCCAELEAP(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class AFCMFCEHNMF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public KeepsakeRoomInstanceIdsDTO instancesInRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public KGBKPOJMNNN CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public AFCMFCEHNMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x72B3F40", Offset = "0x72B2D40", VA = "0x1872B3F40")]
		internal MNHDJBCOCND<IEnumerable<Guid>> GLNKLBFNBMF(KeepsakeRoomInstancesDTO roomInstancesDTO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class KDEIJFBHADI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public KeepsakeRoomInstancesDTO roomInstancesDTO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public AFCMFCEHNMF CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public KDEIJFBHADI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x72C2CC0", Offset = "0x72C1AC0", VA = "0x1872C2CC0")]
		internal bool EFFHKLPPLFG(Guid instanceId)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class MNMBBAINNIK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Guid instanceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public KDEIJFBHADI CS$<>8__locals3;

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public MNMBBAINNIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x72C4160", Offset = "0x72C2F60", VA = "0x1872C4160")]
		internal bool LDCOIPGHKGA(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class ODNNCOHADDL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public GDEJGFIAMIL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public ODNNCOHADDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x72C4A90", Offset = "0x72C3890", VA = "0x1872C4A90")]
		internal MNHDJBCOCND<IEnumerable<Guid>> BHMAIOLNIOH(IEnumerable<Guid> instanceIds)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x72C4410", Offset = "0x72C3210", VA = "0x1872C4410")]
		internal bool ELGIJEKCOMN(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class MKLEHNDJJCI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public GDEJGFIAMIL <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public MKLEHNDJJCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x72C4090", Offset = "0x72C2E90", VA = "0x1872C4090")]
		internal void IGJFKIAACME(KeepsakeProgressionEventInstancesDTO result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x72C35E0", Offset = "0x72C23E0", VA = "0x1872C35E0")]
		internal void GMCBHFOPNCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x72C3DA0", Offset = "0x72C2BA0", VA = "0x1872C3DA0")]
		internal MNHDJBCOCND<Dictionary<Guid, MJGAMLALHAD>> EADNMNIEKOK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x6E99480", Offset = "0x6E98280", VA = "0x186E99480")]
		internal bool CIDCBLLJICF(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class LPLFMBFPLCB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public KeepsakeRoomInstanceIdsDTO instancesInRoom;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public LPLFMBFPLCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x72C3BF0", Offset = "0x72C29F0", VA = "0x1872C3BF0")]
		internal MNHDJBCOCND<Dictionary<Guid, MJGAMLALHAD>> FDPIKLHGHBF(KeepsakeRoomInstancesDTO roomInstancesDTO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class DGAPLEBKKBF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public KeepsakeRoomInstancesDTO roomInstancesDTO;

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public DGAPLEBKKBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x72B4260", Offset = "0x72B3060", VA = "0x1872B4260")]
		internal bool PEKALDNLLML(Guid instanceId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x72B4110", Offset = "0x72B2F10", VA = "0x1872B4110")]
		internal KeyValuePair<Guid, MJGAMLALHAD> EKGAGFGNGJD(Guid instanceId)
		{
			return default(KeyValuePair<Guid, MJGAMLALHAD>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class PHFOOKMKOOA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public Guid instanceId;

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public PHFOOKMKOOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x2209070", Offset = "0x2207E70", VA = "0x182209070")]
		internal bool AGHBIECPPLD(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class FOBALDOBOFF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public Guid instanceId;

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public FOBALDOBOFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x2209070", Offset = "0x2207E70", VA = "0x182209070")]
		internal bool NILFLCOJEMI(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class MOAKLMFLOOJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public GDEJGFIAMIL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public MOAKLMFLOOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x72C4210", Offset = "0x72C3010", VA = "0x1872C4210")]
		internal MNHDJBCOCND<Dictionary<Guid, MJGAMLALHAD>> FKFFCLHCMGF(Dictionary<Guid, MJGAMLALHAD> instanceIdsAndCategories)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x72C4410", Offset = "0x72C3210", VA = "0x1872C4410")]
		internal bool OEOGBEAMIKK(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class OODIEHJLNNO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public KeepsakeRoomInstanceIdsDTO collectedInstanceIds;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public OODIEHJLNNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x72C4D70", Offset = "0x72C3B70", VA = "0x1872C4D70")]
		internal bool MIFOFODAKHI(KeyValuePair<Guid, MJGAMLALHAD> idCategoryPair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class FJHFEAMMGKL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public Dictionary<Guid, MJGAMLALHAD> instanceIdsAndCategories;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public FJHFEAMMGKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x72B43A0", Offset = "0x72B31A0", VA = "0x1872B43A0")]
		internal KeyValuePair<MJGAMLALHAD, int> BBMKCIMPBDC(MJGAMLALHAD category)
		{
			return default(KeyValuePair<MJGAMLALHAD, int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class ONPBOJNANOG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public MJGAMLALHAD category;

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public ONPBOJNANOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0xCA31C0", Offset = "0xCA1FC0", VA = "0x180CA31C0")]
		internal bool OLLJCCAIPFO(MJGAMLALHAD instanceCategory)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class HNLOIEJIBKB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public Dictionary<Guid, MJGAMLALHAD> instanceIdsAndCategories;

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public HNLOIEJIBKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x72C2800", Offset = "0x72C1600", VA = "0x1872C2800")]
		internal KeyValuePair<MJGAMLALHAD, int> AAIBEALJDCD(MJGAMLALHAD category)
		{
			return default(KeyValuePair<MJGAMLALHAD, int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class HHCDHCFIMPA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public MJGAMLALHAD category;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public HHCDHCFIMPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0xCA31C0", Offset = "0xCA1FC0", VA = "0x180CA31C0")]
		internal bool IAANPJEKDGC(MJGAMLALHAD instanceCategory)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class KFIMBNKFABM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public GDEJGFIAMIL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public Func<KeepsakeRoomDTO, bool> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public KFIMBNKFABM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x72C2EB0", Offset = "0x72C1CB0", VA = "0x1872C2EB0")]
		internal bool JNICKPBJFHB(DateTime nowUtc, DateTime eventStartTime, int roomOrder, TimeSpan unlockStartOffset, TimeSpan unlockInterval, int unlockBatchSize)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x72C2DF0", Offset = "0x72C1BF0", VA = "0x1872C2DF0")]
		internal bool IGOLCAMBADF(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x72C2FA0", Offset = "0x72C1DA0", VA = "0x1872C2FA0")]
		internal bool OGHPOELBIOD(KeepsakeRoomDTO r)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x72C2FA0", Offset = "0x72C1DA0", VA = "0x1872C2FA0")]
		internal bool KKACFEEBPEC(KeepsakeRoomDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class ONCELEBFAJA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public ONCELEBFAJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0xD0CC10", Offset = "0xD0BA10", VA = "0x180D0CC10")]
		internal bool BNCHCDCNNKF(KeepsakeRoomListDTO roomList)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class KBONNHOJCBM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public Func<KeepsakeRoomDTO, bool> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public KBONNHOJCBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x72C2C00", Offset = "0x72C1A00", VA = "0x1872C2C00")]
		internal bool OPGFPODDCJH(KeepsakeRoomListDTO roomList)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x21D01E0", Offset = "0x21CEFE0", VA = "0x1821D01E0")]
		internal bool DKDPKPLAIBA(KeepsakeRoomDTO room)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class DOIKFCAJKKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public DOIKFCAJKKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x72B4340", Offset = "0x72B3140", VA = "0x1872B4340")]
		internal bool CALEJAHBNBO(KeepsakeRoomListDTO i)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class OLEOADCIGDC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public OLEOADCIGDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0xD0CC10", Offset = "0xD0BA10", VA = "0x180D0CC10")]
		internal bool GOHHKGOMKMJ(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class BDNBFDOABGH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public Guid keepsakeInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public BDNBFDOABGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x72B4080", Offset = "0x72B2E80", VA = "0x1872B4080")]
		internal bool KLOIBCGNCON(KeyValuePair<Guid, KeepsakeInstanceDTO> instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class ACAPOCLEDMB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public MJGAMLALHAD keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public ACAPOCLEDMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x1E318A0", Offset = "0x1E306A0", VA = "0x181E318A0")]
		internal bool MONFDIPCBJA(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class MOHGPLFEEFC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public Guid keepsakeInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public MOHGPLFEEFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x72C4430", Offset = "0x72C3230", VA = "0x1872C4430")]
		internal bool CKDIKODOLFB(KeyValuePair<Guid, KeepsakeInstanceDTO> instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class MLGOFFLDBHD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public MJGAMLALHAD keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public MLGOFFLDBHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x72C4120", Offset = "0x72C2F20", VA = "0x1872C4120")]
		internal bool IANFDOJAPDH(KeyValuePair<Guid, MJGAMLALHAD> x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class NMOABHNKJAA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public MJGAMLALHAD newKeepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public NMOABHNKJAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x1E318A0", Offset = "0x1E306A0", VA = "0x181E318A0")]
		internal bool KLEMJNOJLOC(KeepsakeInstanceDTO instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class ONKFGMHBAKL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public long currentRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public long? currentSubRoomId;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public ONKFGMHBAKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x72C4CF0", Offset = "0x72C3AF0", VA = "0x1872C4CF0")]
		internal bool EPHBJDJCOJN(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class OILJBHJCPOF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public IReadOnlyList<KeepsakeRoomListDTO> roomList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public OILJBHJCPOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x72C4C00", Offset = "0x72C3A00", VA = "0x1872C4C00")]
		internal bool LJGMBNGFBLC(KeepsakeRoomDTO room)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class NJGOFDKDCNF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public KeepsakeRoomDTO room;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public OILJBHJCPOF CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public NJGOFDKDCNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x72C4A10", Offset = "0x72C3810", VA = "0x1872C4A10")]
		internal bool PBOBCICBJOI(KeepsakeRoomListDTO roomListDto)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private struct NGCNKHKMLPH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public GDEJGFIAMIL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public HGCCILDLOLL args;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x72C4490", Offset = "0x72C3290", VA = "0x1872C4490", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x72C49B0", Offset = "0x72C37B0", VA = "0x1872C49B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private struct HFNHBPHCPJC : IAsyncStateMachine
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
		public GDEJGFIAMIL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public string message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x72C2510", Offset = "0x72C1310", VA = "0x1872C2510", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x72C27A0", Offset = "0x72C15A0", VA = "0x1872C27A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly DateTime LABNGPOOCHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly FFKAOHGMCOC PNHLJCBIBKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly AKBODHKMCKF NHGGDAIBALI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly HDLJILIGCIO FBNDCNEODFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly KNJOEGIPOFK CLBLPOFHNAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly CJPBMALJOBP FDPNEEAEJHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly NEOHLPEJJDO MEAIKHEOKKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly HNACKPHJDOM GDJKMEBAFNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly JPDCMPIABBH JGDMKGHAADE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly DDODMENECGH DMPMEKEFOGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly JANFBPBAGKP PLHJLFHCLFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly CEFBMPGBCKC LOFJHKDFNLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly LCPFGGJNGLH JKEMDBPOPLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly EFMJDGGLEPE AJLFLGJMDJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly BFGDOKOKOHB JFABNNLFOFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly LADPBGMMBAL GLBCCMFAHHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly HGDALPBEPLL<KeepsakesConfig.KeepsakesOptions> IDEGCFOPFGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly DPIEDOFFLCF HMHLOFOACGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly Dictionary<Guid, KeepsakeInstanceDTO> PPEPINHGEGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly HashSet<Guid> KDGONEHEKMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly HashSet<long> EDOPCHPLMGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private Dictionary<MJGAMLALHAD, int> MKEGBIBJEDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly HashSet<Guid> DEPKBOBNGGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly IDisposable NBAPBCHNOBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private Task ABGMOGKIKFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private MNHDJBCOCND<Guid> DPBMNEKMLHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private long? PDAFLOAMANA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private KeepsakeProgressionEventInstancesDTO EAFAFEPGJGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private MNHDJBCOCND<KeepsakeProgressionEventInstancesDTO> FADCFHBGEFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private IReadOnlyDictionary<MJGAMLALHAD, KeepsakeCategoryConfigDTO> AIELMJHCBPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private KeepsakeGlobalConfigDTO EGEEMLDHFBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private HashSet<long> EHKGGALCJLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private HashSet<long> ODIKMDKKCFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private List<KeepsakeRoomListDTO> OHEBOKAGAIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private List<KeepsakeRoomListDTO> LNIIGLOADDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private List<KeepsakeRoomListDTO> GAGGGBBJCNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private Dictionary<long, string> ODKIOEKDBHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private Dictionary<long, string> FAFHDOHKOCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private Dictionary<long, DateTime> DDELAFOPAGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private Dictionary<long, List<KeepsakeRoomDTO>> MILKBKPIGGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private Dictionary<long, List<KeepsakeRoomDTO>> PHCCJFEENNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private Dictionary<long, long> LONCHJPLEPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly List<string> AKIPFPENMHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private DateTime JEOOMIDPKNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly IDisposable IAIPKMHLFKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private Dictionary<Guid, MJGAMLALHAD> DICCCLKNLME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private Dictionary<MJGAMLALHAD, int> BJNGIDHLCOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private List<KeepsakeCategoryThemePair> BCKFMLEMMAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private IPPHIAFOPOP JINNFNCPFMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private bool LLFENNKLCNI;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool MCFEODCIKNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x922F70", Offset = "0x921D70", VA = "0x180922F70", Slot = "53")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x922CF0", Offset = "0x921AF0", VA = "0x180922CF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool OFMEHGIBIGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x72BF7C0", Offset = "0x72BE5C0", VA = "0x1872BF7C0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool JHPINOOOOME
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x72BFDB0", Offset = "0x72BEBB0", VA = "0x1872BFDB0", Slot = "36")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private long BIKEPHPPLOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x72BA3B0", Offset = "0x72B91B0", VA = "0x1872BA3B0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private long? AFJPNMIADGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x72B7F00", Offset = "0x72B6D00", VA = "0x1872B7F00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private bool EDFHKNCKMCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x72B5160", Offset = "0x72B3F60", VA = "0x1872B5160")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public IReadOnlyList<KeepsakeRoomListDTO> JDOFIOHJCBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x962140", Offset = "0x960F40", VA = "0x180962140", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public IReadOnlyList<KeepsakeRoomListDTO> JNOIOBCLNCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x96DA80", Offset = "0x96C880", VA = "0x18096DA80", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IReadOnlyList<KeepsakeRoomListDTO> JCHKBLLKLGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x96E700", Offset = "0x96D500", VA = "0x18096E700", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public IReadOnlyDictionary<long, string> IENLGNLGFPN
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x95D2D0", Offset = "0x95C0D0", VA = "0x18095D2D0", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	internal bool AGOBCOEKENC
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x95A5D0", Offset = "0x9593D0", VA = "0x18095A5D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Guid?> COHGBJKLANH
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x72B98E0", Offset = "0x72B86E0", VA = "0x1872B98E0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x72B4F10", Offset = "0x72B3D10", VA = "0x1872B4F10", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action EGMOJCEHEHA
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x72BFEC0", Offset = "0x72BECC0", VA = "0x1872BFEC0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x72B8130", Offset = "0x72B6F30", VA = "0x1872B8130", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action AHEBEEKCEDE
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x72BBAA0", Offset = "0x72BA8A0", VA = "0x1872BBAA0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x72BE970", Offset = "0x72BD770", VA = "0x1872BE970", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x72C0F30", Offset = "0x72BFD30", VA = "0x1872C0F30")]
	[RecRoom.NoEngine.Common.Preserve]
	internal GDEJGFIAMIL([MHFJPMCEEAM(null)][NotNull] FFKAOHGMCOC PNHLJCBIBKD, [NotNull][MHFJPMCEEAM(null)] DDJGAGKAGGH JFNPNLNAOPB, [NotNull][MHFJPMCEEAM(null)] AKBODHKMCKF NHGGDAIBALI, [NotNull][MHFJPMCEEAM(null)] HDLJILIGCIO FBNDCNEODFI, [MHFJPMCEEAM(null)][NotNull] KNJOEGIPOFK CLBLPOFHNAF, [MHFJPMCEEAM(null)][NotNull] CJPBMALJOBP FDPNEEAEJHK, [MHFJPMCEEAM(null)][NotNull] NEOHLPEJJDO MEAIKHEOKKF, [NotNull][MHFJPMCEEAM(null)] HNACKPHJDOM GDJKMEBAFNF, [NotNull][MHFJPMCEEAM(null)] JPDCMPIABBH JGDMKGHAADE, [NotNull][MHFJPMCEEAM(null)] AAHGDAHDHEN EAEFLKFALGM, [NotNull][MHFJPMCEEAM(null)] DDODMENECGH DMPMEKEFOGI, [NotNull][MHFJPMCEEAM(null)] JANFBPBAGKP PLHJLFHCLFL, [NotNull][MHFJPMCEEAM(null)] CEFBMPGBCKC LOFJHKDFNLA, [NotNull][MHFJPMCEEAM(null)] LCPFGGJNGLH JKEMDBPOPLF, [MHFJPMCEEAM(null)][NotNull] EFMJDGGLEPE AJLFLGJMDJM, [MHFJPMCEEAM(null)][NotNull] BFGDOKOKOHB JFABNNLFOFD, [NotNull][MHFJPMCEEAM(null)] LADPBGMMBAL GLBCCMFAHHB, [MHFJPMCEEAM(null)][NotNull] HGDALPBEPLL<KeepsakesConfig.KeepsakesOptions> IDEGCFOPFGC, [NotNull][MHFJPMCEEAM(null)] DPIEDOFFLCF HMHLOFOACGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x72B44F0", Offset = "0x72B32F0", VA = "0x1872B44F0", Slot = "15")]
	public bool AFLAIINCJKM(List<string> HCPCOPHPEAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x72BEF10", Offset = "0x72BDD10", VA = "0x1872BEF10", Slot = "16")]
	public MNHDJBCOCND<Guid> MODLGEJBDBJ(MJGAMLALHAD NJKEIHDFKML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x72BBEF0", Offset = "0x72BACF0", VA = "0x1872BBEF0", Slot = "17")]
	public LDHIGNIGDAL IMFJACNMNLL(Guid MJDLHFNFBNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x72B51D0", Offset = "0x72B3FD0", VA = "0x1872B51D0", Slot = "18")]
	public LDHIGNIGDAL BJODHDDAHLN(Guid MJDLHFNFBNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x72C0DD0", Offset = "0x72BFBD0", VA = "0x1872C0DD0", Slot = "19")]
	public bool PLEHECPMKCI(Guid MJDLHFNFBNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x72BC2D0", Offset = "0x72BB0D0", VA = "0x1872BC2D0", Slot = "20")]
	public bool IPBBCGDEFGE(Guid MJDLHFNFBNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x72BE250", Offset = "0x72BD050", VA = "0x1872BE250")]
	public KeepsakeTheme KOIDJFACLGA(Guid MJDLHFNFBNN)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x72B4970", Offset = "0x72B3770", VA = "0x1872B4970")]
	public bool AMEIMFHAMFG(MJGAMLALHAD NJKEIHDFKML, [Out] KeepsakeTheme LGLKMNAELJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x72BB6F0", Offset = "0x72BA4F0", VA = "0x1872BB6F0")]
	public List<KeepsakeTheme> IDANEAINICL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x72B9760", Offset = "0x72B8560", VA = "0x1872B9760")]
	public int GCKCKFGLGOP(MJGAMLALHAD NJKEIHDFKML)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x72BC170", Offset = "0x72BAF70", VA = "0x1872BC170")]
	public MJGAMLALHAD INGBNEOIKMC(Guid MJDLHFNFBNN)
	{
		return default(MJGAMLALHAD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x72BADF0", Offset = "0x72B9BF0", VA = "0x1872BADF0", Slot = "34")]
	public List<MJGAMLALHAD> HHAFDOCPPGH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x72BE6C0", Offset = "0x72BD4C0", VA = "0x1872BE6C0", Slot = "35")]
	public IComparer<MJGAMLALHAD> LNHKMFHGOJB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x72BE440", Offset = "0x72BD240", VA = "0x1872BE440", Slot = "32")]
	public string LHNGKKCIJKF(MJGAMLALHAD NJKEIHDFKML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x72BB150", Offset = "0x72B9F50", VA = "0x1872BB150", Slot = "33")]
	public string HPMBLJONHLP(MJGAMLALHAD NJKEIHDFKML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x72BBC50", Offset = "0x72BAA50", VA = "0x1872BBC50", Slot = "21")]
	public bool ILLKCCMPBFK(Guid MJDLHFNFBNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x72B7E90", Offset = "0x72B6C90", VA = "0x1872B7E90", Slot = "22")]
	public void EKNCDGNCEII(Guid MJDLHFNFBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x72BFE70", Offset = "0x72BEC70", VA = "0x1872BFE70", Slot = "23")]
	public void NHAHMPOMEEL(MJGAMLALHAD NJKEIHDFKML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x72B7C50", Offset = "0x72B6A50", VA = "0x1872B7C50", Slot = "24")]
	public void EGPDDDOBDFJ(Guid MJDLHFNFBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x72B9F70", Offset = "0x72B8D70", VA = "0x1872B9F70", Slot = "25")]
	public int GOBMMJHOMDB()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x72BC300", Offset = "0x72BB100", VA = "0x1872BC300", Slot = "31")]
	public MNHDJBCOCND<IEnumerable<Guid>> JADFBPIPFAN(long OGMIFIGJENM, long JMJOPNJJPCA, MJGAMLALHAD? NJKEIHDFKML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x72B5760", Offset = "0x72B4560", VA = "0x1872B5760", Slot = "30")]
	public MNHDJBCOCND<IEnumerable<Guid>> CBADOBEKHCN(long OGMIFIGJENM, long JMJOPNJJPCA, MJGAMLALHAD? NJKEIHDFKML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x72B5FF0", Offset = "0x72B4DF0", VA = "0x1872B5FF0", Slot = "54")]
	public MNHDJBCOCND<Dictionary<Guid, MJGAMLALHAD>> CIEKDKDAPNJ(long OGMIFIGJENM, long JMJOPNJJPCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x72BCFA0", Offset = "0x72BBDA0", VA = "0x1872BCFA0", Slot = "55")]
	public MNHDJBCOCND<Dictionary<Guid, MJGAMLALHAD>> KBBONAPDKKJ(long OGMIFIGJENM, long JMJOPNJJPCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x72BF520", Offset = "0x72BE320", VA = "0x1872BF520", Slot = "26")]
	public MNHDJBCOCND<int> NAECFGNLIHO(long OGMIFIGJENM, long JMJOPNJJPCA, MJGAMLALHAD? NJKEIHDFKML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x72C0930", Offset = "0x72BF730", VA = "0x1872C0930", Slot = "27")]
	public MNHDJBCOCND<int> OGOPKBLAPFE(long OGMIFIGJENM, long JMJOPNJJPCA, MJGAMLALHAD? NJKEIHDFKML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x72B5550", Offset = "0x72B4350", VA = "0x1872B5550", Slot = "28")]
	public MNHDJBCOCND<Dictionary<MJGAMLALHAD, int>> BLMMOKLCCCE(long OGMIFIGJENM, long JMJOPNJJPCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x72BCBF0", Offset = "0x72BB9F0", VA = "0x1872BCBF0", Slot = "29")]
	public MNHDJBCOCND<Dictionary<MJGAMLALHAD, int>> JMHMINJOECG(long OGMIFIGJENM, long JMJOPNJJPCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x72BDFA0", Offset = "0x72BCDA0", VA = "0x1872BDFA0", Slot = "37")]
	public bool KJPHOFCLADF(long OGMIFIGJENM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x72BD130", Offset = "0x72BBF30", VA = "0x1872BD130", Slot = "56")]
	public bool KHEGPOBINDK(long OGMIFIGJENM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x72BB590", Offset = "0x72BA390", VA = "0x1872BB590", Slot = "38")]
	public bool IABOJBKDEJO(long OGMIFIGJENM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x72C0360", Offset = "0x72BF160", VA = "0x1872C0360", Slot = "57")]
	public bool OABGDOCDLPL(long OGMIFIGJENM, [Out] GMNPJHMNGIE NBLHMPALIGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x72B9510", Offset = "0x72B8310", VA = "0x1872B9510", Slot = "39")]
	public bool GADNCBKAMHG(long GDMCPEAFOIK, [Out] DateTime NKILJKODMPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x72BC6B0", Offset = "0x72BB4B0", VA = "0x1872BC6B0", Slot = "40")]
	public long JFBAMBOKFJF(long GDMCPEAFOIK)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x72B6580", Offset = "0x72B5380", VA = "0x1872B6580", Slot = "41")]
	public long COMFKFBBILE(long OGMIFIGJENM)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x72B63A0", Offset = "0x72B51A0", VA = "0x1872B63A0", Slot = "42")]
	public int CMEGBNEGAAM(long GDMCPEAFOIK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x72B9E90", Offset = "0x72B8C90", VA = "0x1872B9E90", Slot = "43")]
	public bool GMCJJMHKOCI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x72BEB10", Offset = "0x72BD910", VA = "0x1872BEB10", Slot = "44")]
	public bool MNGLNDEJLKC(long GDMCPEAFOIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x72B6D30", Offset = "0x72B5B30", VA = "0x1872B6D30", Slot = "45")]
	public IReadOnlyList<long> DIMPPDFIFHC(long GDMCPEAFOIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x72BFF60", Offset = "0x72BED60", VA = "0x1872BFF60", Slot = "46")]
	public int NMFKFHAJJKN(long GDMCPEAFOIK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x72BB2D0", Offset = "0x72BA0D0", VA = "0x1872BB2D0", Slot = "50")]
	public long HPMFFDNLMON(long ICFCJEPDCGA)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x72B9990", Offset = "0x72B8790", VA = "0x1872B9990", Slot = "51")]
	public MJGAMLALHAD GJBHCLIDIPA()
	{
		return default(MJGAMLALHAD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x72BCCB0", Offset = "0x72BBAB0", VA = "0x1872BCCB0")]
	private bool JONNNEBOFOH(Guid MJDLHFNFBNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x72BDAD0", Offset = "0x72BC8D0", VA = "0x1872BDAD0")]
	private void KJKMLKLGACP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x72BAAA0", Offset = "0x72B98A0", VA = "0x1872BAAA0")]
	private MJGAMLALHAD HDJOGPJBDPK()
	{
		return default(MJGAMLALHAD);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x72BD490", Offset = "0x72BC290", VA = "0x1872BD490")]
	private void KJIOCBHBJOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x72B7F90", Offset = "0x72B6D90", VA = "0x1872B7F90")]
	private int EPJGMJBJNBP(KeepsakeRoomListDTO JNEMJEHFAGH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x72C0010", Offset = "0x72BEE10", VA = "0x1872C0010")]
	private int NNDKBLFPMPI(DateTime FGACLBOMKMC, DateTime AMDGGGCIFHP, TimeSpan IPCPPHHGHCF, int NCFFLMFMJOL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x72B6AA0", Offset = "0x72B58A0", VA = "0x1872B6AA0")]
	private void DGIDLMGEDHC(IEnumerable<KeepsakeInstanceDTO> PPEPINHGEGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x72C0110", Offset = "0x72BEF10", VA = "0x1872C0110")]
	private void NPGIFACPCOM(IEnumerable<KeepsakeCollectionRecordDTO> DBEAAEMDKLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x72B6FA0", Offset = "0x72B5DA0", VA = "0x1872B6FA0")]
	private void DNKNAJFFBEN(IEnumerable<long> DKCIBMMDKLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x985280", Offset = "0x984080", VA = "0x180985280")]
	private void GEFKIOFEKLB(KeepsakeGlobalConfigDTO EGEEMLDHFBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x72BECA0", Offset = "0x72BDAA0", VA = "0x1872BECA0")]
	private bool MNLIDPIICAB(MJGAMLALHAD NJKEIHDFKML, [Out] Guid BIOGPOJFEAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x72BEA10", Offset = "0x72BD810", VA = "0x1872BEA10")]
	private bool MJGCAOLDJAI([Out] Guid BIOGPOJFEAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x72B7000", Offset = "0x72B5E00", VA = "0x1872B7000")]
	private bool DPHHJPBJGFN(Guid MJDLHFNFBNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x72B81D0", Offset = "0x72B6FD0", VA = "0x1872B81D0")]
	private IEnumerable<Guid> FFGJNLKAIMK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x72BB630", Offset = "0x72BA430", VA = "0x1872BB630")]
	private IEnumerable<KeepsakeInstanceDTO> IAIEEHLDABN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x72BE000", Offset = "0x72BCE00", VA = "0x1872BE000")]
	private void KKMABFHKBJG(Guid MJDLHFNFBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x72BE390", Offset = "0x72BD190", VA = "0x1872BE390")]
	private bool LGGPHMDCEBK(Guid MJDLHFNFBNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x72B4FC0", Offset = "0x72B3DC0", VA = "0x1872B4FC0")]
	private void BAHCHJPOHBH(Guid MJDLHFNFBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x72B4780", Offset = "0x72B3580", VA = "0x1872B4780")]
	private void AGMLLCLPCML(MJGAMLALHAD INPCIJAHNDH, int ENMFPEJJKKN, Dictionary<MJGAMLALHAD, int> LIDPJKKHFCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x72BBB60", Offset = "0x72BA960", VA = "0x1872BBB60")]
	private int IKECKOBKCAO(MJGAMLALHAD NJKEIHDFKML)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x72C0710", Offset = "0x72BF510", VA = "0x1872C0710")]
	private void OCCBEMOOEFK(KeepsakeInstanceDTO NDECCEHDOLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x72B9300", Offset = "0x72B8100", VA = "0x1872B9300")]
	private void FOIOLBCHOKM(KeepsakeInstanceDTO NDECCEHDOLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x72B7880", Offset = "0x72B6680", VA = "0x1872B7880")]
	private void EDKEFFLFOHI(Guid MJDLHFNFBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x72BB120", Offset = "0x72B9F20", VA = "0x1872BB120")]
	private void MKLEPGKMLGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x72BBB40", Offset = "0x72BA940", VA = "0x1872BBB40")]
	private void IKCMGABPLIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x72BAD80", Offset = "0x72B9B80", VA = "0x1872BAD80")]
	private void HDPGLJHCIIB(KDCHDHEFHAG NGNJEIAEFMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x72BB120", Offset = "0x72B9F20", VA = "0x1872BB120")]
	private void OFPBKONCOCO(LFCJNJHHHHK JOOHPPHJKMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x72BB120", Offset = "0x72B9F20", VA = "0x1872BB120")]
	private void HOIDNOKIEBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x72B7060", Offset = "0x72B5E60", VA = "0x1872B7060")]
	private void DPJJEPGDEJN(float KAHALBDEBIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x72BF810", Offset = "0x72BE610", VA = "0x1872BF810")]
	private void NFPHDNMBDFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x72B6690", Offset = "0x72B5490", VA = "0x1872B6690")]
	private bool DAJMIBOLPBA(Guid MJDLHFNFBNN, [Out] string PIOGBGOBMME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x72C0AB0", Offset = "0x72BF8B0", VA = "0x1872C0AB0")]
	private bool OPCBCDPFJBP(Guid MJDLHFNFBNN, [Out] KeepsakeCategoryConfigDTO INPCIJAHNDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x72B9220", Offset = "0x72B8020", VA = "0x1872B9220")]
	private void FNJIPPOEFOE(string MMLPEKEEFNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x72B9650", Offset = "0x72B8450", VA = "0x1872B9650")]
	private bool GBKIKNFAEKJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x72B5D10", Offset = "0x72B4B10", VA = "0x1872B5D10")]
	private List<long> CDCGCPLJJEO(IEnumerable<KeepsakeRoomDTO> OPMDMMJDADJ, IReadOnlyList<KeepsakeRoomListDTO> JNEAIMNCJNG, long GDMCPEAFOIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x72BA560", Offset = "0x72B9360", VA = "0x1872BA560")]
	private bool GPEFNEOLNFN(Guid MJDLHFNFBNN, [Out] string LKNDCPLLKMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x72BEAB0", Offset = "0x72BD8B0", VA = "0x1872BEAB0", Slot = "47")]
	public string MLCMJAJDLAO(JKOPLJNIFNL EFDLDIHIPLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x72B58F0", Offset = "0x72B46F0", VA = "0x1872B58F0", Slot = "49")]
	public string CCPMFDFFJFL(JKOPLJNIFNL EFDLDIHIPLO, long OGMIFIGJENM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x72B6890", Offset = "0x72B5690", VA = "0x1872B6890", Slot = "48")]
	public string DDKKBHLLJIC(JKOPLJNIFNL EFDLDIHIPLO, int FEHNKBKBBEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x72B8330", Offset = "0x72B7130", VA = "0x1872B8330")]
	private void FJGGJOLEIAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x72BD300", Offset = "0x72BC100", VA = "0x1872BD300")]
	private void KIAPKFCDAOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x72C0A90", Offset = "0x72BF890", VA = "0x1872C0A90")]
	private JKOPLJNIFNL OOGDFEHNEHJ(DIHBMJMMFGA GPICHDMMABL)
	{
		return default(JKOPLJNIFNL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x72C0C80", Offset = "0x72BFA80", VA = "0x1872C0C80")]
	private JKOPLJNIFNL PGPIPMNLJGM(DIHBMJMMFGA GPICHDMMABL)
	{
		return default(JKOPLJNIFNL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x72BAF40", Offset = "0x72B9D40", VA = "0x1872BAF40")]
	internal static string HHIDHPMMDGC(JJOANLDPPDF PKKIMDPEFJM, string GCPFPNNBPFL, bool CIBJDGGMOCJ, int FIMOONJGFNO, int GDDBGMFHJOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x72B7400", Offset = "0x72B6200", VA = "0x1872B7400", Slot = "52")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x72BE780", Offset = "0x72BD580", VA = "0x1872BE780")]
	private MDFDKOJBEAB LODMPJNDEIP(NJGJGBGCLGP KJPFMIPALHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x72BE090", Offset = "0x72BCE90", VA = "0x1872BE090")]
	private DADKOHLCLHL KMGJEMPMDGE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x72B4B50", Offset = "0x72B3950", VA = "0x1872B4B50")]
	private Task AMLIKBCJCPM(HGCCILDLOLL EHEEIKICBAM, CancellationToken FEHCANHDGHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x72B4860", Offset = "0x72B3660", VA = "0x1872B4860")]
	[AsyncStateMachine(typeof(NGCNKHKMLPH))]
	private Task AHLGOAHKBOC(HGCCILDLOLL EHEEIKICBAM, CancellationToken FEHCANHDGHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x72BA480", Offset = "0x72B9280", VA = "0x1872BA480")]
	private Task GPDDBHDPPMD(HGCCILDLOLL EHEEIKICBAM, CancellationToken FEHCANHDGHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x72C0CA0", Offset = "0x72BFAA0", VA = "0x1872C0CA0")]
	[AsyncStateMachine(typeof(HFNHBPHCPJC))]
	private Task PHIKIDMFKLL(string KKBJAPCBOHH, TimeSpan IKGNDPPIJGE, CancellationToken FEHCANHDGHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x72B7860", Offset = "0x72B6660", VA = "0x1872B7860")]
	[CompilerGenerated]
	private void EDJGDHLIMAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x72C08E0", Offset = "0x72BF6E0", VA = "0x1872C08E0")]
	[CompilerGenerated]
	private void OEDNEGOKAKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x72BE5C0", Offset = "0x72BD3C0", VA = "0x1872BE5C0")]
	[CompilerGenerated]
	private bool LHNIDEEPKJP(KeepsakeInstanceDTO LBONEMFCDEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x72BE800", Offset = "0x72BD600", VA = "0x1872BE800")]
	[CompilerGenerated]
	private MNHDJBCOCND<Dictionary<MJGAMLALHAD, int>> MAGMIBGIGBA(Dictionary<Guid, MJGAMLALHAD> JMJDHKDDCPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x72BD190", Offset = "0x72BBF90", VA = "0x1872BD190")]
	[CompilerGenerated]
	private MNHDJBCOCND<Dictionary<MJGAMLALHAD, int>> KHHBHHMJELJ(Dictionary<Guid, MJGAMLALHAD> JMJDHKDDCPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x72BAA80", Offset = "0x72B9880", VA = "0x1872BAA80")]
	[CompilerGenerated]
	private bool HCHHJOBIBJE(KeepsakeRoomListDTO LBONEMFCDEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x72B6970", Offset = "0x72B5770", VA = "0x1872B6970")]
	[CompilerGenerated]
	private bool DEENMEPEIDD(KeepsakeInstanceDTO LBONEMFCDEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x72B9D00", Offset = "0x72B8B00", VA = "0x1872B9D00")]
	[CompilerGenerated]
	private void GKNPLEPKNML(Tuple<KeepsakeRoomInstancesDTO, IReadOnlyDictionary<MJGAMLALHAD, KeepsakeCategoryConfigDTO>, KeepsakeGlobalConfigDTO> MMBKIMKKEEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x72B5170", Offset = "0x72B3F70", VA = "0x1872B5170")]
	[CompilerGenerated]
	private void BBCCALOAOPI(string LKNDCPLLKMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x72BCDE0", Offset = "0x72BBBE0", VA = "0x1872BCDE0")]
	[CompilerGenerated]
	private Task JPMGJMLMJFN(CancellationToken EOFPDFHCFJA)
	{
		return null;
	}
}
namespace RecRoom.Keepsakes
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public class KeepsakesConfig : ScriptableObject, HGDALPBEPLL<KeepsakesConfig.KeepsakesOptions>
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200002B")]
		public class KeepsakesOptions
		{
			[Cpp2IlInjected.Token(Token = "0x200002C")]
			[CompilerGenerated]
			private sealed class BEDJOJMKIMC
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000098")]
				public string themeId;

				[Cpp2IlInjected.Token(Token = "0x60000F3")]
				[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
				public BEDJOJMKIMC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000F4")]
				[Cpp2IlInjected.Address(RVA = "0x72B40E0", Offset = "0x72B2EE0", VA = "0x1872B40E0")]
				internal bool IKMCAIHIGCJ(KeepsakeTheme x)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60000F5")]
				[Cpp2IlInjected.Address(RVA = "0x72B40E0", Offset = "0x72B2EE0", VA = "0x1872B40E0")]
				internal bool FFLOLCHPEEA(KeepsakeTheme x)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			[SerializeField]
			private KeepsakeTheme[] themes;

			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x72C3A20", Offset = "0x72C2820", VA = "0x1872C3A20")]
			public bool PLGPMKDIALN(string ANMGANHBFJC, [Out] KeepsakeTheme LGLKMNAELJK)
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
			[Cpp2IlInjected.Address(RVA = "0x8F4430", Offset = "0x8F3230", VA = "0x1808F4430", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x72C39A0", Offset = "0x72C27A0", VA = "0x1872C39A0")]
		[FOLINPJCBJN.HMBDLNHFFEJ.EKAOCHOMHGE]
		internal static void GGGLAIJELEP(IEPIHLKICIO BCNFHKMHIOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0xA79E30", Offset = "0xA78C30", VA = "0x180A79E30")]
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
