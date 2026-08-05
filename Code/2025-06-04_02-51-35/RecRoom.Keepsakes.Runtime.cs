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
		[Cpp2IlInjected.Address(RVA = "0x7FF5A70", Offset = "0x7FF4270", VA = "0x187FF5A70", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2731690", Offset = "0x272FE90", VA = "0x182731690")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class MBLOJFKKNDP : IComparer<FENEICOAGDP>
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private sealed class EBOMGNCDGGO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public FENEICOAGDP x;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public FENEICOAGDP y;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public EBOMGNCDGGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xD8ECB0", Offset = "0xD8D4B0", VA = "0x180D8ECB0")]
		internal bool DOJPHHPJBOF(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x1F7A7A0", Offset = "0x1F78FA0", VA = "0x181F7A7A0")]
		internal bool ELLCKFHBPGM(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xD8ECB0", Offset = "0xD8D4B0", VA = "0x180D8ECB0")]
		internal bool JJPPOFDGEMF(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1F7A7A0", Offset = "0x1F78FA0", VA = "0x181F7A7A0")]
		internal bool MFOOMKALHIE(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private List<KeepsakeCategoryThemePair> HGPACDDDFBC;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0xA2D2A0", Offset = "0xA2BAA0", VA = "0x180A2D2A0")]
	public MBLOJFKKNDP(List<KeepsakeCategoryThemePair> PMKBMPNEDAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7FF4A20", Offset = "0x7FF3220", VA = "0x187FF4A20", Slot = "4")]
	public int Compare(FENEICOAGDP BDGPJOKJNIL, FENEICOAGDP HDAFCDJNHAK)
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
		public FENEICOAGDP KeepsakeCategory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public KeepsakeTheme KeepsakeTheme;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[DIADIMJDNBG]
public class JODLHOMBOHD : NBDBLHCMOOG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class PJKFFFGJDPL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public JODLHOMBOHD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public FENEICOAGDP keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public PJKFFFGJDPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7FF56B0", Offset = "0x7FF3EB0", VA = "0x187FF56B0")]
		internal BFIFKPBFBML<Guid> MMDIEMDMBDD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7FF5680", Offset = "0x7FF3E80", VA = "0x187FF5680")]
		internal void HNDFEIIHACN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7FF5210", Offset = "0x7FF3A10", VA = "0x187FF5210")]
		internal void CKPGGEELBBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7FF5270", Offset = "0x7FF3A70", VA = "0x187FF5270")]
		internal void CNPEMPDAOHE(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7FF51E0", Offset = "0x7FF39E0", VA = "0x187FF51E0")]
		internal void BFNADIAIKBJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class KMGLDDGMJCD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public JODLHOMBOHD <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public KMGLDDGMJCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7FF4250", Offset = "0x7FF2A50", VA = "0x187FF4250")]
		internal void NDCAIPNJHFB(IBCMILEFKJL response)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7FF41F0", Offset = "0x7FF29F0", VA = "0x187FF41F0")]
		internal void MBJMBOBBDLK(string error)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class BPFCENBNBDM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public KeepsakeTheme theme;

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public BPFCENBNBDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x7FE49B0", Offset = "0x7FE31B0", VA = "0x187FE49B0")]
		internal bool GKPPFFDONCM(KeepsakeCategoryThemePair categoryThemePair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class DIACGFHMBKL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public JODLHOMBOHD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public long progressionEventId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public FENEICOAGDP? keepsakeCategory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public DIACGFHMBKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x7FE5630", Offset = "0x7FE3E30", VA = "0x187FE5630")]
		internal void DIHBFNFIDJE(KeepsakeProgressionEventInstancesDTO result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x7FE56C0", Offset = "0x7FE3EC0", VA = "0x187FE56C0")]
		internal void KAMCJNGFNKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x7FE5330", Offset = "0x7FE3B30", VA = "0x187FE5330")]
		internal BFIFKPBFBML<IEnumerable<Guid>> BNMHFOHKNOK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x7B09470", Offset = "0x7B07C70", VA = "0x187B09470")]
		internal bool JNAIBFMLKFL(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class IOAFPCMNBEH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public KeepsakeRoomInstanceIdsDTO instancesInRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public DIACGFHMBKL CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public IOAFPCMNBEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x7FE5EC0", Offset = "0x7FE46C0", VA = "0x187FE5EC0")]
		internal BFIFKPBFBML<IEnumerable<Guid>> LCAJINJEPIO(KeepsakeRoomInstancesDTO roomInstancesDTO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class FJMHGDGIAED
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public KeepsakeRoomInstancesDTO roomInstancesDTO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public IOAFPCMNBEH CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public FJMHGDGIAED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x7FE56F0", Offset = "0x7FE3EF0", VA = "0x187FE56F0")]
		internal bool JDPMAINOPHO(Guid instanceId)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class PCPHHFAFFOP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Guid instanceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public FJMHGDGIAED CS$<>8__locals3;

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public PCPHHFAFFOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x7FF5130", Offset = "0x7FF3930", VA = "0x187FF5130")]
		internal bool NFOLEBNHLDI(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class GMHPKDHNCAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public JODLHOMBOHD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public GMHPKDHNCAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x7FE59E0", Offset = "0x7FE41E0", VA = "0x187FE59E0")]
		internal BFIFKPBFBML<IEnumerable<Guid>> AMINOOLBHNN(IEnumerable<Guid> instanceIds)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x7FE5B50", Offset = "0x7FE4350", VA = "0x187FE5B50")]
		internal bool FJPIDPMAFCG(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class OEBKCNCAPKJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public JODLHOMBOHD <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public OEBKCNCAPKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x7FF5020", Offset = "0x7FF3820", VA = "0x187FF5020")]
		internal void JOGOAKIKEJO(KeepsakeProgressionEventInstancesDTO result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x7FE56C0", Offset = "0x7FE3EC0", VA = "0x187FE56C0")]
		internal void DGMHNANPABF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x7FF4D30", Offset = "0x7FF3530", VA = "0x187FF4D30")]
		internal BFIFKPBFBML<Dictionary<Guid, FENEICOAGDP>> DNPOIMKJCEK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x7B09470", Offset = "0x7B07C70", VA = "0x187B09470")]
		internal bool LBDDNCFDLGJ(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class CDHAFEIMGLG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public KeepsakeRoomInstanceIdsDTO instancesInRoom;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public CDHAFEIMGLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x7FE4C00", Offset = "0x7FE3400", VA = "0x187FE4C00")]
		internal BFIFKPBFBML<Dictionary<Guid, FENEICOAGDP>> LMGPJKOICDC(KeepsakeRoomInstancesDTO roomInstancesDTO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class CCDMMACAFGL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public KeepsakeRoomInstancesDTO roomInstancesDTO;

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public CCDMMACAFGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x7FE49D0", Offset = "0x7FE31D0", VA = "0x187FE49D0")]
		internal bool GJCDADJLMPB(Guid instanceId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x7FE4AB0", Offset = "0x7FE32B0", VA = "0x187FE4AB0")]
		internal KeyValuePair<Guid, FENEICOAGDP> KDBAGODJJEK(Guid instanceId)
		{
			return default(KeyValuePair<Guid, FENEICOAGDP>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class EJPJAEANCFF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public Guid instanceId;

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public EJPJAEANCFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x260AF70", Offset = "0x2609770", VA = "0x18260AF70")]
		internal bool NPIHAMFMBPO(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class OKHIOGOOAHN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public Guid instanceId;

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public OKHIOGOOAHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x260AF70", Offset = "0x2609770", VA = "0x18260AF70")]
		internal bool HCCDAEEOPMO(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class JLEHJNLNAEE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public JODLHOMBOHD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public JLEHJNLNAEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x7FE6080", Offset = "0x7FE4880", VA = "0x187FE6080")]
		internal BFIFKPBFBML<Dictionary<Guid, FENEICOAGDP>> FHFNKBFECDG(Dictionary<Guid, FENEICOAGDP> instanceIdsAndCategories)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x7FE5B50", Offset = "0x7FE4350", VA = "0x187FE5B50")]
		internal bool FCPBCLBLOJK(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class PBAOPGKPAPO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public KeepsakeRoomInstanceIdsDTO collectedInstanceIds;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public PBAOPGKPAPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x7FF50B0", Offset = "0x7FF38B0", VA = "0x187FF50B0")]
		internal bool MJJCPEGHEBD(KeyValuePair<Guid, FENEICOAGDP> idCategoryPair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class BMIMFHFHENI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public Dictionary<Guid, FENEICOAGDP> instanceIdsAndCategories;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public BMIMFHFHENI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x7FE4860", Offset = "0x7FE3060", VA = "0x187FE4860")]
		internal KeyValuePair<FENEICOAGDP, int> KAKPDOHCLBG(FENEICOAGDP category)
		{
			return default(KeyValuePair<FENEICOAGDP, int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class FJEFBKEDHBB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public FENEICOAGDP category;

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public FJEFBKEDHBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0xE6F600", Offset = "0xE6DE00", VA = "0x180E6F600")]
		internal bool IGEGLNBFDGG(FENEICOAGDP instanceCategory)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class GGFBPBMAOKM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public Dictionary<Guid, FENEICOAGDP> instanceIdsAndCategories;

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public GGFBPBMAOKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x7FE5890", Offset = "0x7FE4090", VA = "0x187FE5890")]
		internal KeyValuePair<FENEICOAGDP, int> EJIBEFNPOCK(FENEICOAGDP category)
		{
			return default(KeyValuePair<FENEICOAGDP, int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class ENAIKMDKBAI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public FENEICOAGDP category;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public ENAIKMDKBAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0xE6F600", Offset = "0xE6DE00", VA = "0x180E6F600")]
		internal bool GHAKFAOCOEH(FENEICOAGDP instanceCategory)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class LOLGGAEBCBM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public JODLHOMBOHD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public Func<KeepsakeRoomDTO, bool> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public LOLGGAEBCBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x7FF4910", Offset = "0x7FF3110", VA = "0x187FF4910")]
		internal bool IMJFLBMIPAB(DateTime nowUtc, DateTime eventStartTime, int roomOrder, TimeSpan unlockStartOffset, TimeSpan unlockInterval, int unlockBatchSize)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x7FF4850", Offset = "0x7FF3050", VA = "0x187FF4850")]
		internal bool ADMAHOGAGPD(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x7FF4A00", Offset = "0x7FF3200", VA = "0x187FF4A00")]
		internal bool JBDPGHCPFED(KeepsakeRoomDTO r)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x7FF4A00", Offset = "0x7FF3200", VA = "0x187FF4A00")]
		internal bool PAGPKDIKEDF(KeepsakeRoomDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class EFMNKNKPEIM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public EFMNKNKPEIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0xEF4A90", Offset = "0xEF3290", VA = "0x180EF4A90")]
		internal bool PJDDAINKGNN(KeepsakeRoomListDTO roomList)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class KCIIEGJPIDI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public Func<KeepsakeRoomDTO, bool> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public KCIIEGJPIDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x7FF4130", Offset = "0x7FF2930", VA = "0x187FF4130")]
		internal bool IFMBNJFHCBJ(KeepsakeRoomListDTO roomList)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x2595790", Offset = "0x2593F90", VA = "0x182595790")]
		internal bool IFJPPKGNNNG(KeepsakeRoomDTO room)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class MPDHBOJNCAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public MPDHBOJNCAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x7FF4CD0", Offset = "0x7FF34D0", VA = "0x187FF4CD0")]
		internal bool IMFNPOGHLJL(KeepsakeRoomListDTO i)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class NDMDMODGBHG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public NDMDMODGBHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0xEF4A90", Offset = "0xEF3290", VA = "0x180EF4A90")]
		internal bool KBBKFGOFPHL(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class PNBPAHGEENK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public Guid keepsakeInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public PNBPAHGEENK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x7FF5800", Offset = "0x7FF4000", VA = "0x187FF5800")]
		internal bool IJGIIIOKGLL(KeyValuePair<Guid, KeepsakeInstanceDTO> instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class LGGIONLMKLO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public FENEICOAGDP keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public LGGIONLMKLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x21AF9F0", Offset = "0x21AE1F0", VA = "0x1821AF9F0")]
		internal bool CIGCGJMBMDP(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class HFDDGDDEDOB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public Guid keepsakeInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public HFDDGDDEDOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x7FE5B70", Offset = "0x7FE4370", VA = "0x187FE5B70")]
		internal bool KJEMMMHJLFK(KeyValuePair<Guid, KeepsakeInstanceDTO> instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class FNECNEJLMOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public FENEICOAGDP keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public FNECNEJLMOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x7FE5850", Offset = "0x7FE4050", VA = "0x187FE5850")]
		internal bool EHNJFJPCNJM(KeyValuePair<Guid, FENEICOAGDP> x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class OKFMDGCKLJB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public FENEICOAGDP newKeepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public OKFMDGCKLJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x21AF9F0", Offset = "0x21AE1F0", VA = "0x1821AF9F0")]
		internal bool MFGLHIGMNNC(KeepsakeInstanceDTO instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class AIEGMDOAJPL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public long currentRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public long? currentSubRoomId;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public AIEGMDOAJPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x7FE46F0", Offset = "0x7FE2EF0", VA = "0x187FE46F0")]
		internal bool OIMOFJOMEPB(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class BHLGDNEPFLM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public IReadOnlyList<KeepsakeRoomListDTO> roomList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public BHLGDNEPFLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x7FE4770", Offset = "0x7FE2F70", VA = "0x187FE4770")]
		internal bool PDMGACBHGOO(KeepsakeRoomDTO room)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class JIBKAJJFBEB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public KeepsakeRoomDTO room;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public BHLGDNEPFLM CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public JIBKAJJFBEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x7FE6000", Offset = "0x7FE4800", VA = "0x187FE6000")]
		internal bool EBJBCOMAFAL(KeepsakeRoomListDTO roomListDto)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private struct DEAGCFGFPHA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public JODLHOMBOHD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public HDBLPJBDELH args;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x7FE4DB0", Offset = "0x7FE35B0", VA = "0x187FE4DB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x7FE52D0", Offset = "0x7FE3AD0", VA = "0x187FE52D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private struct IMIBLHNDGON : IAsyncStateMachine
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
		public JODLHOMBOHD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public string message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x7FE5BD0", Offset = "0x7FE43D0", VA = "0x187FE5BD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x7FE5E60", Offset = "0x7FE4660", VA = "0x187FE5E60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly DateTime CDEIANMABBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly FCKOEGGMONG JHNGDGEMICF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly JCCHADKKJED PCGIPLIEPLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly JOHIGFMBHFE GOGKCGCILIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly JJPOOPBBPFC EEAAOGCIBCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly CKBNJKGCBIE KFBGJKCPJCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly JEFBABGOAKF HLEIAPMBPDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly JJCPPGOLFEC NEPFHOEEIOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly KIFHCLNMNON FLIPFCGMCOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly CLPMKNHLPCN OIFCLMJLFAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly DGIKPEGPJAE HHCHIJDHLFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly AGKENCJENIJ IADJPOODAKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly FEAPIENHOEM ILCIONEPKIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly DCLKEJLJDPN OCLBOPAIHNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly ACILHBNCEAK IAGCADNHJCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly AFIBAJHIFMJ IKIKFGGLHPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly JGBKNGOIJGA<KeepsakesConfig.KeepsakesOptions> OJJIDCCJBBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly OPHBELKNMNO NJNLAMHGMGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly Dictionary<Guid, KeepsakeInstanceDTO> FFHPJJDBCGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly HashSet<Guid> KOBNMDACAJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly HashSet<long> KLOBHIJBPLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private Dictionary<FENEICOAGDP, int> DAPGPKPEKLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly HashSet<Guid> KDNOAKJJDLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly IDisposable HJNLINOFIPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private Task FKNEGEFENAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private BFIFKPBFBML<Guid> GIPFGJHGHNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private long? OCBOGHLBLMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private KeepsakeProgressionEventInstancesDTO DMJKHIOOPJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private BFIFKPBFBML<KeepsakeProgressionEventInstancesDTO> HOCAGNBBMML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private IReadOnlyDictionary<FENEICOAGDP, KeepsakeCategoryConfigDTO> KBGAGHCAIBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private KeepsakeGlobalConfigDTO CCGPDBPFEAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private HashSet<long> EENCAOJPAOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private HashSet<long> PKIMMKNCPEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private List<KeepsakeRoomListDTO> ICGMAJAICFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private List<KeepsakeRoomListDTO> EKBAKPJPCAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private List<KeepsakeRoomListDTO> OBLBCIFMJKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private Dictionary<long, string> AALDCBMOEIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private Dictionary<long, string> IFIOJFKFKOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private Dictionary<long, DateTime> CMJNDPEAPAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private Dictionary<long, List<KeepsakeRoomDTO>> NGIOFAMNCEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private Dictionary<long, List<KeepsakeRoomDTO>> FNIHFFDEHKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private Dictionary<long, long> BOJOPKDHECB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly List<string> LFHOIHCGINP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private DateTime BGECMHJDAGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly IDisposable MJLJFCLHCMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private Dictionary<Guid, FENEICOAGDP> NHPDGMKMHKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private Dictionary<FENEICOAGDP, int> JNMHIAEEOHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private List<KeepsakeCategoryThemePair> PMKBMPNEDAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private MBLOJFKKNDP AKNDKGLGMJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private bool IALONLNFACH;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool MLFAOFCKPKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA56260", Offset = "0xA54A60", VA = "0x180A56260", Slot = "53")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA56080", Offset = "0xA54880", VA = "0x180A56080")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool FLENGFEKMBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7FEC360", Offset = "0x7FEAB60", VA = "0x187FEC360", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool EIPAIBEDIIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7FEC3B0", Offset = "0x7FEABB0", VA = "0x187FEC3B0", Slot = "36")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private long ICODIKELDML
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7FEA6B0", Offset = "0x7FE8EB0", VA = "0x187FEA6B0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private long? CNBDFCJDPPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7FF1A80", Offset = "0x7FF0280", VA = "0x187FF1A80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private bool FEMDJAMLMFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7FF1740", Offset = "0x7FEFF40", VA = "0x187FF1740")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public IReadOnlyList<KeepsakeRoomListDTO> OKPOOADKIBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xB380A0", Offset = "0xB368A0", VA = "0x180B380A0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public IReadOnlyList<KeepsakeRoomListDTO> OPFAOAFJLLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xB33C60", Offset = "0xB32460", VA = "0x180B33C60", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IReadOnlyList<KeepsakeRoomListDTO> DEIJHLLPIJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xB46150", Offset = "0xB44950", VA = "0x180B46150", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public IReadOnlyDictionary<long, string> CLLCDGAPOAM
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xB2EAA0", Offset = "0xB2D2A0", VA = "0x180B2EAA0", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	internal bool NBKHBBOMHJB
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xC144E0", Offset = "0xC12CE0", VA = "0x180C144E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Guid?> IPCHOPANJHL
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7FE9A90", Offset = "0x7FE8290", VA = "0x187FE9A90", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7FEC010", Offset = "0x7FEA810", VA = "0x187FEC010", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action BMFKKMDLDMO
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7FE71D0", Offset = "0x7FE59D0", VA = "0x187FE71D0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7FF1B80", Offset = "0x7FF0380", VA = "0x187FF1B80", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action BCGKCHFOOLH
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7FF10D0", Offset = "0x7FEF8D0", VA = "0x187FF10D0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7FE7A10", Offset = "0x7FE6210", VA = "0x187FE7A10", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7FF2B70", Offset = "0x7FF1370", VA = "0x187FF2B70")]
	[RecRoom.NoEngine.Common.Preserve]
	internal JODLHOMBOHD([FAPODKMFODF(null)][NotNull] FCKOEGGMONG JHNGDGEMICF, [NotNull][FAPODKMFODF(null)] FNBFDEKMNMG ELFBOFKBFJF, [NotNull][FAPODKMFODF(null)] JCCHADKKJED PCGIPLIEPLG, [NotNull][FAPODKMFODF(null)] JOHIGFMBHFE GOGKCGCILIG, [FAPODKMFODF(null)][NotNull] JJPOOPBBPFC EEAAOGCIBCL, [FAPODKMFODF(null)][NotNull] CKBNJKGCBIE KFBGJKCPJCG, [FAPODKMFODF(null)][NotNull] JEFBABGOAKF HLEIAPMBPDI, [NotNull][FAPODKMFODF(null)] JJCPPGOLFEC NEPFHOEEIOP, [NotNull][FAPODKMFODF(null)] KIFHCLNMNON FLIPFCGMCOP, [NotNull][FAPODKMFODF(null)] ANFEINDHBIN FINCINEMKOM, [NotNull][FAPODKMFODF(null)] CLPMKNHLPCN OIFCLMJLFAJ, [NotNull][FAPODKMFODF(null)] DGIKPEGPJAE HHCHIJDHLFF, [NotNull][FAPODKMFODF(null)] AGKENCJENIJ IADJPOODAKJ, [NotNull][FAPODKMFODF(null)] FEAPIENHOEM ILCIONEPKIN, [FAPODKMFODF(null)][NotNull] DCLKEJLJDPN OCLBOPAIHNG, [FAPODKMFODF(null)][NotNull] ACILHBNCEAK IAGCADNHJCD, [NotNull][FAPODKMFODF(null)] AFIBAJHIFMJ IKIKFGGLHPE, [FAPODKMFODF(null)][NotNull] JGBKNGOIJGA<KeepsakesConfig.KeepsakesOptions> OJJIDCCJBBN, [NotNull][FAPODKMFODF(null)] OPHBELKNMNO NJNLAMHGMGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7FF1E00", Offset = "0x7FF0600", VA = "0x187FF1E00", Slot = "15")]
	public bool OLLEGMFPDKG(List<string> FHHHKKDCFON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7FF0AC0", Offset = "0x7FEF2C0", VA = "0x187FF0AC0", Slot = "16")]
	public BFIFKPBFBML<Guid> LOALKMJGDNK(FENEICOAGDP FKGFACJAFLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7FE7AD0", Offset = "0x7FE62D0", VA = "0x187FE7AD0", Slot = "17")]
	public FKGMEHDMFDF ANMFGPLGFPE(Guid EHGGCLOFHJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7FEA260", Offset = "0x7FE8A60", VA = "0x187FEA260", Slot = "18")]
	public FKGMEHDMFDF FCICDMIBJIB(Guid EHGGCLOFHJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7FE9930", Offset = "0x7FE8130", VA = "0x187FE9930", Slot = "19")]
	public bool EBHGMEKOIKD(Guid EHGGCLOFHJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7FE8B20", Offset = "0x7FE7320", VA = "0x187FE8B20", Slot = "20")]
	public bool BHIDHJKCDCI(Guid EHGGCLOFHJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7FEC630", Offset = "0x7FEAE30", VA = "0x187FEC630")]
	public KeepsakeTheme JACKJMIOEGD(Guid EHGGCLOFHJH)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7FE9DA0", Offset = "0x7FE85A0", VA = "0x187FE9DA0")]
	public bool EHMIHJANIAK(FENEICOAGDP FKGFACJAFLC, [Out] KeepsakeTheme POODKAKGHNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7FEAFB0", Offset = "0x7FE97B0", VA = "0x187FEAFB0")]
	public List<KeepsakeTheme> GJGFJPDELMK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7FECA00", Offset = "0x7FEB200", VA = "0x187FECA00")]
	public int JDBFDINPLEO(FENEICOAGDP FKGFACJAFLC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7FF1920", Offset = "0x7FF0120", VA = "0x187FF1920")]
	public FENEICOAGDP NFFLHNNAKNO(Guid EHGGCLOFHJH)
	{
		return default(FENEICOAGDP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7FEE430", Offset = "0x7FECC30", VA = "0x187FEE430", Slot = "34")]
	public List<FENEICOAGDP> KHODEPJIKDO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7FE8E80", Offset = "0x7FE7680", VA = "0x187FE8E80", Slot = "35")]
	public IComparer<FENEICOAGDP> CPIDOOECAAJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7FEB930", Offset = "0x7FEA130", VA = "0x187FEB930", Slot = "32")]
	public string HCJBFCFCBHM(FENEICOAGDP FKGFACJAFLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7FEDAA0", Offset = "0x7FEC2A0", VA = "0x187FEDAA0", Slot = "33")]
	public string JLBKFHOFHDP(FENEICOAGDP FKGFACJAFLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7FEFA90", Offset = "0x7FEE290", VA = "0x187FEFA90", Slot = "21")]
	public bool LHDEHCFMHBD(Guid EHGGCLOFHJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7FF1B10", Offset = "0x7FF0310", VA = "0x187FF1B10", Slot = "22")]
	public void NLDPJJKDICA(Guid EHGGCLOFHJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7FEC310", Offset = "0x7FEAB10", VA = "0x187FEC310", Slot = "23")]
	public void ICGFMDEMNKI(FENEICOAGDP FKGFACJAFLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7FF1170", Offset = "0x7FEF970", VA = "0x187FF1170", Slot = "24")]
	public void MIDIIEOIHJA(Guid EHGGCLOFHJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7FE8F40", Offset = "0x7FE7740", VA = "0x187FE8F40", Slot = "25")]
	public int DDMEDDNLNKM()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7FE8640", Offset = "0x7FE6E40", VA = "0x187FE8640", Slot = "31")]
	public BFIFKPBFBML<IEnumerable<Guid>> BHALPLNKPCC(long GFHIJAKOMMI, long CNNKDELNHGM, FENEICOAGDP? FKGFACJAFLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7FEF740", Offset = "0x7FEDF40", VA = "0x187FEF740", Slot = "30")]
	public BFIFKPBFBML<IEnumerable<Guid>> LDICHDDEAAI(long GFHIJAKOMMI, long CNNKDELNHGM, FENEICOAGDP? FKGFACJAFLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7FEDE30", Offset = "0x7FEC630", VA = "0x187FEDE30", Slot = "54")]
	public BFIFKPBFBML<Dictionary<Guid, FENEICOAGDP>> KBHGNFPDDCD(long GFHIJAKOMMI, long CNNKDELNHGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7FEA070", Offset = "0x7FE8870", VA = "0x187FEA070", Slot = "55")]
	public BFIFKPBFBML<Dictionary<Guid, FENEICOAGDP>> FBPMFMNDGPB(long GFHIJAKOMMI, long CNNKDELNHGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7FEC770", Offset = "0x7FEAF70", VA = "0x187FEC770", Slot = "26")]
	public BFIFKPBFBML<int> JBIDDEPAJGB(long GFHIJAKOMMI, long CNNKDELNHGM, FENEICOAGDP? FKGFACJAFLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7FF13B0", Offset = "0x7FEFBB0", VA = "0x187FF13B0", Slot = "27")]
	public BFIFKPBFBML<int> MIDJGGIGLAO(long GFHIJAKOMMI, long CNNKDELNHGM, FENEICOAGDP? FKGFACJAFLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7FF2960", Offset = "0x7FF1160", VA = "0x187FF2960", Slot = "28")]
	public BFIFKPBFBML<Dictionary<FENEICOAGDP, int>> PPIJKLFLGIC(long GFHIJAKOMMI, long CNNKDELNHGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7FEFD20", Offset = "0x7FEE520", VA = "0x187FEFD20", Slot = "29")]
	public BFIFKPBFBML<Dictionary<FENEICOAGDP, int>> LIOPJMEMAOA(long GFHIJAKOMMI, long CNNKDELNHGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7FEE3D0", Offset = "0x7FECBD0", VA = "0x187FEE3D0", Slot = "37")]
	public bool KFILKHHHNMH(long GFHIJAKOMMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7FEAF50", Offset = "0x7FE9750", VA = "0x187FEAF50", Slot = "56")]
	public bool GIKFAEBHMCK(long GFHIJAKOMMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7FF28C0", Offset = "0x7FF10C0", VA = "0x187FF28C0", Slot = "38")]
	public bool PNJGAGIBCOI(long GFHIJAKOMMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7FE7F90", Offset = "0x7FE6790", VA = "0x187FE7F90", Slot = "57")]
	public bool BCNFJJKNFFK(long GFHIJAKOMMI, [Out] GNEDPIFHMMI DHKKNPFJFKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7FEC0C0", Offset = "0x7FEA8C0", VA = "0x187FEC0C0", Slot = "39")]
	public bool HPHGMGPFHCD(long JDGNBHJADFG, [Out] DateTime BPGIPJKFMCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7FE6AC0", Offset = "0x7FE52C0", VA = "0x187FE6AC0", Slot = "40")]
	public long AFFIKHGEGPH(long JDGNBHJADFG)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7FEC200", Offset = "0x7FEAA00", VA = "0x187FEC200", Slot = "41")]
	public long HPLCKCMOAJI(long GFHIJAKOMMI)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7FF1C20", Offset = "0x7FF0420", VA = "0x187FF1C20", Slot = "42")]
	public int OADAIEEPNMP(long JDGNBHJADFG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7FE6280", Offset = "0x7FE4A80", VA = "0x187FE6280", Slot = "43")]
	public bool ABPEOHDCAOL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x7FEBE80", Offset = "0x7FEA680", VA = "0x187FEBE80", Slot = "44")]
	public bool HLKBOHPDBKC(long JDGNBHJADFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7FEF3A0", Offset = "0x7FEDBA0", VA = "0x187FEF3A0", Slot = "45")]
	public IReadOnlyList<long> LBLIFEMFPEG(long JDGNBHJADFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7FF1690", Offset = "0x7FEFE90", VA = "0x187FF1690", Slot = "46")]
	public int MLENDJEOJPF(long JDGNBHJADFG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7FEAC90", Offset = "0x7FE9490", VA = "0x187FEAC90", Slot = "50")]
	public long GBGDHFPCPLL(long PNDBJHLEJJP)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7FEB5D0", Offset = "0x7FE9DD0", VA = "0x187FEB5D0", Slot = "51")]
	public FENEICOAGDP HBLJFLPMFGD()
	{
		return default(FENEICOAGDP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7FE89F0", Offset = "0x7FE71F0", VA = "0x187FE89F0")]
	private bool BHDIAPMDOOC(Guid EHGGCLOFHJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7FEE620", Offset = "0x7FECE20", VA = "0x187FEE620")]
	private void KLIKAAMEONA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7FF2560", Offset = "0x7FF0D60", VA = "0x187FF2560")]
	private FENEICOAGDP PBHNLIKJAKE()
	{
		return default(FENEICOAGDP);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7FEEBF0", Offset = "0x7FED3F0", VA = "0x187FEEBF0")]
	private void KMPPPHNGCGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7FEC490", Offset = "0x7FEAC90", VA = "0x187FEC490")]
	private int JAAPBDOBCKC(KeepsakeRoomListDTO GNCGBPHAENF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7FE8340", Offset = "0x7FE6B40", VA = "0x187FE8340")]
	private int BCONNGKIBIC(DateTime FJJGEABINCN, DateTime KAEEAJFNEHH, TimeSpan JJIEHBDOMFN, int NAPENAJJFPP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7FEAA10", Offset = "0x7FE9210", VA = "0x187FEAA10")]
	private void FPLGKJOLPPG(IEnumerable<KeepsakeInstanceDTO> FFHPJJDBCGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7FE8BE0", Offset = "0x7FE73E0", VA = "0x187FE8BE0")]
	private void CIBHADBJIIA(IEnumerable<KeepsakeCollectionRecordDTO> NLINIBAHNAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7FEA8F0", Offset = "0x7FE90F0", VA = "0x187FEA8F0")]
	private void FPGNEEBBOPO(IEnumerable<long> HKICBPMMBJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAA9E00", VA = "0x180AAB600")]
	private void KGOBNLNDGLB(KeepsakeGlobalConfigDTO CCGPDBPFEAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7FE9B40", Offset = "0x7FE8340", VA = "0x187FE9B40")]
	private bool EDJLMAJLAEF(FENEICOAGDP FKGFACJAFLC, [Out] Guid JDBOEADOBCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7FEB360", Offset = "0x7FE9B60", VA = "0x187FEB360")]
	private bool GLOMPPGIINM([Out] Guid JDBOEADOBCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7FEA200", Offset = "0x7FE8A00", VA = "0x187FEA200")]
	private bool FCEDGCKLNPM(Guid EHGGCLOFHJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x7FE9380", Offset = "0x7FE7B80", VA = "0x187FE9380")]
	private IEnumerable<Guid> DNKLGEJKBEN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7FEA950", Offset = "0x7FE9150", VA = "0x187FEA950")]
	private IEnumerable<KeepsakeInstanceDTO> FPKFDBOICLE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7FE8B50", Offset = "0x7FE7350", VA = "0x187FE8B50")]
	private void CFCONJFPGFF(Guid EHGGCLOFHJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7FEE570", Offset = "0x7FECD70", VA = "0x187FEE570")]
	private bool KKBJPHDENAJ(Guid EHGGCLOFHJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7FEE230", Offset = "0x7FECA30", VA = "0x187FEE230")]
	private void KEMLBHPMIMP(Guid EHGGCLOFHJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7FF1840", Offset = "0x7FF0040", VA = "0x187FF1840")]
	private void NAONIPIHMGD(FENEICOAGDP PAOIAAAHGOA, int JBIEJLKBFNL, Dictionary<FENEICOAGDP, int> EACIMFJLGNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7FF1750", Offset = "0x7FEFF50", VA = "0x187FF1750")]
	private int MNPAIGHBPMI(FENEICOAGDP FKGFACJAFLC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7FE7000", Offset = "0x7FE5800", VA = "0x187FE7000")]
	private void AFKDAAKCOCF(KeepsakeInstanceDTO ENDPBFECAMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7FEDC20", Offset = "0x7FEC420", VA = "0x187FEDC20")]
	private void JOOAOPFMMJA(KeepsakeInstanceDTO ENDPBFECAMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7FF2190", Offset = "0x7FF0990", VA = "0x187FF2190")]
	private void OPOPLCANAPF(Guid EHGGCLOFHJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7FE7D50", Offset = "0x7FE6550", VA = "0x187FE7D50")]
	private void LDBPOHBGCPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7FE7AB0", Offset = "0x7FE62B0", VA = "0x187FE7AB0")]
	private void AMNAPDLHOFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7FF2830", Offset = "0x7FF1030", VA = "0x187FF2830")]
	private void PBIPCGEDIPP(FPBLLGEBKEJ MMOLNADADKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7FE7D50", Offset = "0x7FE6550", VA = "0x187FE7D50")]
	private void EGIHNNOPCCP(LPHNGGDHPGM HPLLAPMNIJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7FE7D50", Offset = "0x7FE6550", VA = "0x187FE7D50")]
	private void APFCCOBOIIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7FF0720", Offset = "0x7FEEF20", VA = "0x187FF0720")]
	private void LMKOHCDELBO(float GBGEOECKKBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x7FE6520", Offset = "0x7FE4D20", VA = "0x187FE6520")]
	private void ADEAEKNHLNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7FE8440", Offset = "0x7FE6C40", VA = "0x187FE8440")]
	private bool BDACCCEAEAG(Guid EHGGCLOFHJH, [Out] string ALGONKMEBBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7FEB400", Offset = "0x7FE9C00", VA = "0x187FEB400")]
	private bool GMCLKEJGMAK(Guid EHGGCLOFHJH, [Out] KeepsakeCategoryConfigDTO PAOIAAAHGOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7FE7D80", Offset = "0x7FE6580", VA = "0x187FE7D80")]
	private void APMDIMBAGMC(string HFGOALBMNDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7FEBD70", Offset = "0x7FEA570", VA = "0x187FEBD70")]
	private bool HLEOMDBLKNJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7FEBAB0", Offset = "0x7FEA2B0", VA = "0x187FEBAB0")]
	private List<long> HJONJPBFIBC(IEnumerable<KeepsakeRoomDTO> BGPEFAOPBKK, IReadOnlyList<KeepsakeRoomListDTO> OHFFLFNAIJM, long JDGNBHJADFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x7FF0200", Offset = "0x7FEEA00", VA = "0x187FF0200")]
	private bool LLIAJFDOBLJ(Guid EHGGCLOFHJH, [Out] string MEBFHJECJFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7FE8E20", Offset = "0x7FE7620", VA = "0x187FE8E20", Slot = "47")]
	public string CKHMAGEFCPB(EHECGENJAFL LCDBNDEMKFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x7FEFDE0", Offset = "0x7FEE5E0", VA = "0x187FEFDE0", Slot = "49")]
	public string LKMJLLBDHGE(EHECGENJAFL LCDBNDEMKFP, long GFHIJAKOMMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7FEA5E0", Offset = "0x7FE8DE0", VA = "0x187FEA5E0", Slot = "48")]
	public string FHAOJPEFJJL(EHECGENJAFL LCDBNDEMKFP, int FMCGDOLFBMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x7FECBE0", Offset = "0x7FEB3E0", VA = "0x187FECBE0")]
	private void JKDPIJPMNDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7FE74D0", Offset = "0x7FE5CD0", VA = "0x187FE74D0")]
	private void AJPEMACBMCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x7FEA050", Offset = "0x7FE8850", VA = "0x187FEA050")]
	private EHECGENJAFL EONBANNPAKF(EGMDPNLNOOL KGGPLKLMBJH)
	{
		return default(EHECGENJAFL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x7FEC470", Offset = "0x7FEAC70", VA = "0x187FEC470")]
	private EHECGENJAFL IMEPEEJEKFO(EGMDPNLNOOL KGGPLKLMBJH)
	{
		return default(EHECGENJAFL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7FE7270", Offset = "0x7FE5A70", VA = "0x187FE7270")]
	internal static string AJGKGBBPEGK(IBCMILEFKJL NONMNKHNEAF, string BFNOJCGAOKM, bool OJEPOPADBIM, int LEIKOKHAIJB, int CHKNCHLLKPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7FE94D0", Offset = "0x7FE7CD0", VA = "0x187FE94D0", Slot = "52")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x7FE7450", Offset = "0x7FE5C50", VA = "0x187FE7450")]
	private AKIGBGIOJEO AJMICGLLJAL(EIGONBNGIIK OAAEEAIGGNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7FE6360", Offset = "0x7FE4B60", VA = "0x187FE6360")]
	private AHFDHLNPAAB ACKMMANNBJA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7FE7660", Offset = "0x7FE5E60", VA = "0x187FE7660")]
	private Task AJPIGFMNGJJ(HDBLPJBDELH JALDLFHONHH, CancellationToken GMEAHOBHMAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7FEEAE0", Offset = "0x7FED2E0", VA = "0x187FEEAE0")]
	[AsyncStateMachine(typeof(DEAGCFGFPHA))]
	private Task KMKHEJANFEH(HDBLPJBDELH JALDLFHONHH, CancellationToken GMEAHOBHMAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7FE9F80", Offset = "0x7FE8780", VA = "0x187FE9F80")]
	private Task EOMPBJFMGJM(HDBLPJBDELH JALDLFHONHH, CancellationToken GMEAHOBHMAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7FE7E60", Offset = "0x7FE6660", VA = "0x187FE7E60")]
	[AsyncStateMachine(typeof(IMIBLHNDGON))]
	private Task BBAOHAPOHAP(string ILBALOOKKCP, TimeSpan OAPHLLINKIL, CancellationToken GMEAHOBHMAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7FE9360", Offset = "0x7FE7B60", VA = "0x187FE9360")]
	[CompilerGenerated]
	private void DMKDKLMDOHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7FEE1E0", Offset = "0x7FEC9E0", VA = "0x187FEE1E0")]
	[CompilerGenerated]
	private void KCBMIGDAEJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7FF2090", Offset = "0x7FF0890", VA = "0x187FF2090")]
	[CompilerGenerated]
	private bool ONNBKONOKKD(KeepsakeInstanceDTO BDGPJOKJNIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7FEA780", Offset = "0x7FE8F80", VA = "0x187FEA780")]
	[CompilerGenerated]
	private BFIFKPBFBML<Dictionary<FENEICOAGDP, int>> FKCKDKDEEJJ(Dictionary<Guid, FENEICOAGDP> GFFMJNOBAAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x7FEF230", Offset = "0x7FEDA30", VA = "0x187FEF230")]
	[CompilerGenerated]
	private BFIFKPBFBML<Dictionary<FENEICOAGDP, int>> LAAAFCJNBOE(Dictionary<Guid, FENEICOAGDP> GFFMJNOBAAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7FF28A0", Offset = "0x7FF10A0", VA = "0x187FF28A0")]
	[CompilerGenerated]
	private bool PEPOKKAPHIB(KeepsakeRoomListDTO BDGPJOKJNIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7FEF610", Offset = "0x7FEDE10", VA = "0x187FEF610")]
	[CompilerGenerated]
	private bool LCBAHMAOLEA(KeepsakeInstanceDTO BDGPJOKJNIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7FF1500", Offset = "0x7FEFD00", VA = "0x187FF1500")]
	[CompilerGenerated]
	private void MLDJCNOHACC(Tuple<KeepsakeRoomInstancesDTO, IReadOnlyDictionary<FENEICOAGDP, KeepsakeCategoryConfigDTO>, KeepsakeGlobalConfigDTO> EBAHALBPMDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7FECB80", Offset = "0x7FEB380", VA = "0x187FECB80")]
	[CompilerGenerated]
	private void JFOLLJAFBKC(string MEBFHJECJFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x7FEF8D0", Offset = "0x7FEE0D0", VA = "0x187FEF8D0")]
	[CompilerGenerated]
	private Task LFEDCIMIPOB(CancellationToken OCCIAJMBMHB)
	{
		return null;
	}
}
namespace RecRoom.Keepsakes
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public class KeepsakesConfig : ScriptableObject, JGBKNGOIJGA<KeepsakesConfig.KeepsakesOptions>
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200002B")]
		public class KeepsakesOptions
		{
			[Cpp2IlInjected.Token(Token = "0x200002C")]
			[CompilerGenerated]
			private sealed class FJOPAIOPPEG
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000098")]
				public string themeId;

				[Cpp2IlInjected.Token(Token = "0x60000F3")]
				[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
				public FJOPAIOPPEG()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000F4")]
				[Cpp2IlInjected.Address(RVA = "0x7FE5820", Offset = "0x7FE4020", VA = "0x187FE5820")]
				internal bool PAGPHNMLGLH(KeepsakeTheme x)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60000F5")]
				[Cpp2IlInjected.Address(RVA = "0x7FE5820", Offset = "0x7FE4020", VA = "0x187FE5820")]
				internal bool JBKECHKEJMO(KeepsakeTheme x)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			[SerializeField]
			private KeepsakeTheme[] themes;

			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x7FF4680", Offset = "0x7FF2E80", VA = "0x187FF4680")]
			public bool NEGLFODANNF(string HKEBFFKEPOD, [Out] KeepsakeTheme POODKAKGHNG)
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
			[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x7FF4600", Offset = "0x7FF2E00", VA = "0x187FF4600")]
		[NOOFMBJKOEL.LBENCLOPAFN.ODLCBGDPONC]
		internal static void MNKNDOLBIJB(OIKNHNBNAFI MBKOPLBCEJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0xC33770", Offset = "0xC31F70", VA = "0x180C33770")]
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
