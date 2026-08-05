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
		[Cpp2IlInjected.Address(RVA = "0x6F93070", Offset = "0x6F91870", VA = "0x186F93070", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x21F3FE0", Offset = "0x21F27E0", VA = "0x1821F3FE0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class PPKOGJCONHJ : IComparer<NHCLBNIPKNG>
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private sealed class NEEGLFLBBIO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public NHCLBNIPKNG x;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public NHCLBNIPKNG y;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public NEEGLFLBBIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x919EF0", Offset = "0x9186F0", VA = "0x180919EF0")]
		internal bool JMDNDKPABJB(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x1894AA0", Offset = "0x18932A0", VA = "0x181894AA0")]
		internal bool JDNBPMMENLO(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x919EF0", Offset = "0x9186F0", VA = "0x180919EF0")]
		internal bool LMGDDAKKMJK(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1894AA0", Offset = "0x18932A0", VA = "0x181894AA0")]
		internal bool MGABIBFHBKK(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private List<KeepsakeCategoryThemePair> GEHBNFPHIEL;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x8C0090", Offset = "0x8BE890", VA = "0x1808C0090")]
	public PPKOGJCONHJ(List<KeepsakeCategoryThemePair> BODJLADCHCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6F92BA0", Offset = "0x6F913A0", VA = "0x186F92BA0", Slot = "4")]
	public int Compare(NHCLBNIPKNG KHINBLFKKED, NHCLBNIPKNG NCCBPIFKDGE)
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
		public NHCLBNIPKNG KeepsakeCategory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public KeepsakeTheme KeepsakeTheme;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[CEOCIAMIFJE]
public class KLPAPPEIBGA : NKDGPEANBAO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class CGJJHHKDAJJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public KLPAPPEIBGA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public NHCLBNIPKNG keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public CGJJHHKDAJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6F81EE0", Offset = "0x6F806E0", VA = "0x186F81EE0")]
		internal AKLEHMINLPM<Guid> HLGNINCLFJB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6F81E50", Offset = "0x6F80650", VA = "0x186F81E50")]
		internal void CKLGOAGCDKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6F81E80", Offset = "0x6F80680", VA = "0x186F81E80")]
		internal void DAMJNHGPGEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6F82030", Offset = "0x6F80830", VA = "0x186F82030")]
		internal void LDPGOABKPJE(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6F82440", Offset = "0x6F80C40", VA = "0x186F82440")]
		internal void NODKHPJOGHL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class GOBEGGDBGPO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public KLPAPPEIBGA <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public GOBEGGDBGPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6F82B30", Offset = "0x6F81330", VA = "0x186F82B30")]
		internal void LGFHEGGGJLF(NFEPHJLEDEH response)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6F82AD0", Offset = "0x6F812D0", VA = "0x186F82AD0")]
		internal void GGIBHAFPMEJ(string error)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class DJLHNEDFNGG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public KeepsakeTheme theme;

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public DJLHNEDFNGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x6F824D0", Offset = "0x6F80CD0", VA = "0x186F824D0")]
		internal bool PHIHMBFFIMI(KeepsakeCategoryThemePair categoryThemePair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class OABCHDJINFI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public KLPAPPEIBGA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public long progressionEventId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public NHCLBNIPKNG? keepsakeCategory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public OABCHDJINFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6F925E0", Offset = "0x6F90DE0", VA = "0x186F925E0")]
		internal void JBBJLBINLLD(KeepsakeProgressionEventInstancesDTO result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x6F922B0", Offset = "0x6F90AB0", VA = "0x186F922B0")]
		internal void DLNEFIPBNNM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x6F922E0", Offset = "0x6F90AE0", VA = "0x186F922E0")]
		internal AKLEHMINLPM<IEnumerable<Guid>> IDJEOBPNLPN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x6B7C8B0", Offset = "0x6B7B0B0", VA = "0x186B7C8B0")]
		internal bool HOHCDCJGDNA(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class JBEIANJGMLH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public KeepsakeRoomInstanceIdsDTO instancesInRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public OABCHDJINFI CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public JBEIANJGMLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x6F83380", Offset = "0x6F81B80", VA = "0x186F83380")]
		internal AKLEHMINLPM<IEnumerable<Guid>> EMGDKDKJLAK(KeepsakeRoomInstancesDTO roomInstancesDTO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class FKFNMAALBMA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public KeepsakeRoomInstancesDTO roomInstancesDTO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public JBEIANJGMLH CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public FKFNMAALBMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x6F82600", Offset = "0x6F80E00", VA = "0x186F82600")]
		internal bool IBEDHKMFPFA(Guid instanceId)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class EGFFOJNHAFA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Guid instanceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public FKFNMAALBMA CS$<>8__locals3;

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public EGFFOJNHAFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x6F82550", Offset = "0x6F80D50", VA = "0x186F82550")]
		internal bool HJMKKHMKOOH(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class MJJFKJEHJAE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public KLPAPPEIBGA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public MJJFKJEHJAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x6F91EE0", Offset = "0x6F906E0", VA = "0x186F91EE0")]
		internal AKLEHMINLPM<IEnumerable<Guid>> MJBNIFFBLKA(IEnumerable<Guid> instanceIds)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x6F91EC0", Offset = "0x6F906C0", VA = "0x186F91EC0")]
		internal bool GAKPAPDDHLM(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class PAOBJDAEAIC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public KLPAPPEIBGA <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public PAOBJDAEAIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x6F92670", Offset = "0x6F90E70", VA = "0x186F92670")]
		internal void KPGAGLBBCBK(KeepsakeProgressionEventInstancesDTO result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x6F922B0", Offset = "0x6F90AB0", VA = "0x186F922B0")]
		internal void JKLFFEFONIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x6F92700", Offset = "0x6F90F00", VA = "0x186F92700")]
		internal AKLEHMINLPM<Dictionary<Guid, NHCLBNIPKNG>> LDPIDKECPBN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x6B7C8B0", Offset = "0x6B7B0B0", VA = "0x186B7C8B0")]
		internal bool DJFNIOCKPGL(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class PGEEOGODNNM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public KeepsakeRoomInstanceIdsDTO instancesInRoom;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public PGEEOGODNNM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x6F929F0", Offset = "0x6F911F0", VA = "0x186F929F0")]
		internal AKLEHMINLPM<Dictionary<Guid, NHCLBNIPKNG>> ODEBIFDAFKG(KeepsakeRoomInstancesDTO roomInstancesDTO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class JDBOFBLAMPH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public KeepsakeRoomInstancesDTO roomInstancesDTO;

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public JDBOFBLAMPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x6F834C0", Offset = "0x6F81CC0", VA = "0x186F834C0")]
		internal bool DFIOCEHJEAJ(Guid instanceId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6F835A0", Offset = "0x6F81DA0", VA = "0x186F835A0")]
		internal KeyValuePair<Guid, NHCLBNIPKNG> NKOEPAOCCEF(Guid instanceId)
		{
			return default(KeyValuePair<Guid, NHCLBNIPKNG>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class DNJGLJDEKME
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public Guid instanceId;

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public DNJGLJDEKME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x1E2D2F0", Offset = "0x1E2BAF0", VA = "0x181E2D2F0")]
		internal bool LCKLFFJMAMM(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class OEKDCPNAMAK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public Guid instanceId;

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public OEKDCPNAMAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x1E2D2F0", Offset = "0x1E2BAF0", VA = "0x181E2D2F0")]
		internal bool EMCFMLELJNH(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class NPHIDHKGKKH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public KLPAPPEIBGA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public NPHIDHKGKKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x6F920B0", Offset = "0x6F908B0", VA = "0x186F920B0")]
		internal AKLEHMINLPM<Dictionary<Guid, NHCLBNIPKNG>> KDFIAFKGANB(Dictionary<Guid, NHCLBNIPKNG> instanceIdsAndCategories)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x6F91EC0", Offset = "0x6F906C0", VA = "0x186F91EC0")]
		internal bool DNFNJOFPPLK(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class AINLIABAOOH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public KeepsakeRoomInstanceIdsDTO collectedInstanceIds;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public AINLIABAOOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x6F81CE0", Offset = "0x6F804E0", VA = "0x186F81CE0")]
		internal bool PPFFBADFIDB(KeyValuePair<Guid, NHCLBNIPKNG> idCategoryPair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class AIMPOBBALHF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public Dictionary<Guid, NHCLBNIPKNG> instanceIdsAndCategories;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public AIMPOBBALHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x6F81B90", Offset = "0x6F80390", VA = "0x186F81B90")]
		internal KeyValuePair<NHCLBNIPKNG, int> LDKMFJACICA(NHCLBNIPKNG category)
		{
			return default(KeyValuePair<NHCLBNIPKNG, int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class ANJBNLHEFEB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public NHCLBNIPKNG category;

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public ANJBNLHEFEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x9F2BA0", Offset = "0x9F13A0", VA = "0x1809F2BA0")]
		internal bool GOEMENGHGIA(NHCLBNIPKNG instanceCategory)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class FLGJFIICBPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public Dictionary<Guid, NHCLBNIPKNG> instanceIdsAndCategories;

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public FLGJFIICBPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x6F82730", Offset = "0x6F80F30", VA = "0x186F82730")]
		internal KeyValuePair<NHCLBNIPKNG, int> GCLMHMMOIOE(NHCLBNIPKNG category)
		{
			return default(KeyValuePair<NHCLBNIPKNG, int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class AJMLMPKGGFO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public NHCLBNIPKNG category;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public AJMLMPKGGFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x9F2BA0", Offset = "0x9F13A0", VA = "0x1809F2BA0")]
		internal bool CDJHFMCHEAH(NHCLBNIPKNG instanceCategory)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class GGKKPNEIPCH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public KLPAPPEIBGA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public Func<KeepsakeRoomDTO, bool> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public GGKKPNEIPCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x6F829E0", Offset = "0x6F811E0", VA = "0x186F829E0")]
		internal bool MFHOCKFDFNI(DateTime nowUtc, DateTime eventStartTime, int roomOrder, TimeSpan unlockStartOffset, TimeSpan unlockInterval, int unlockBatchSize)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x6F82900", Offset = "0x6F81100", VA = "0x186F82900")]
		internal bool HKEHPPIDAMM(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x6F829C0", Offset = "0x6F811C0", VA = "0x186F829C0")]
		internal bool NKPLJHIAOHI(KeepsakeRoomDTO r)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x6F829C0", Offset = "0x6F811C0", VA = "0x186F829C0")]
		internal bool LHJMKFLLCFO(KeepsakeRoomDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class IGIMHLAFNKK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public IGIMHLAFNKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0xA8C3D0", Offset = "0xA8ABD0", VA = "0x180A8C3D0")]
		internal bool NBGOEPGAGLI(KeepsakeRoomListDTO roomList)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class ICNNNDPDPLJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public Func<KeepsakeRoomDTO, bool> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public ICNNNDPDPLJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x6F831D0", Offset = "0x6F819D0", VA = "0x186F831D0")]
		internal bool EJFAENMLPPC(KeepsakeRoomListDTO roomList)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x1DF6DA0", Offset = "0x1DF55A0", VA = "0x181DF6DA0")]
		internal bool DLFCIPABOLE(KeepsakeRoomDTO room)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class NOBJLLEMLJD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public NOBJLLEMLJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x6F92050", Offset = "0x6F90850", VA = "0x186F92050")]
		internal bool BMIEAKGKIOP(KeepsakeRoomListDTO i)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class HPCGHKABBGJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public HPCGHKABBGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0xA8C3D0", Offset = "0xA8ABD0", VA = "0x180A8C3D0")]
		internal bool LAMEOMOHABP(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class EFHOLBIIIEN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public Guid keepsakeInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public EFHOLBIIIEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x6F824F0", Offset = "0x6F80CF0", VA = "0x186F824F0")]
		internal bool OJINHJNFIOL(KeyValuePair<Guid, KeepsakeInstanceDTO> instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class AIIOAAGDGBM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public NHCLBNIPKNG keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public AIIOAAGDGBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x1A66850", Offset = "0x1A65050", VA = "0x181A66850")]
		internal bool CIHFNGLLJAA(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class COMLGNAJPIK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public Guid keepsakeInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public COMLGNAJPIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x6F82470", Offset = "0x6F80C70", VA = "0x186F82470")]
		internal bool NCNPFAEAJPL(KeyValuePair<Guid, KeepsakeInstanceDTO> instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class CBMKPJJCOAH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public NHCLBNIPKNG keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public CBMKPJJCOAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x6F81D60", Offset = "0x6F80560", VA = "0x186F81D60")]
		internal bool HCHAEHDLGAP(KeyValuePair<Guid, NHCLBNIPKNG> x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class AJABJOANLEE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public NHCLBNIPKNG newKeepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public AJABJOANLEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x1A66850", Offset = "0x1A65050", VA = "0x181A66850")]
		internal bool GHKEMDIMBII(KeepsakeInstanceDTO instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class CCKJJOALJJN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public long currentRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public long? currentSubRoomId;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public CCKJJOALJJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x6F81DA0", Offset = "0x6F805A0", VA = "0x186F81DA0")]
		internal bool DEKEJILOLKG(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class IPGMGPAOPJJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public IReadOnlyList<KeepsakeRoomListDTO> roomList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public IPGMGPAOPJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x6F83290", Offset = "0x6F81A90", VA = "0x186F83290")]
		internal bool GNOPMHLONFL(KeepsakeRoomDTO room)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class FMGFFECFLLJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public KeepsakeRoomDTO room;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public IPGMGPAOPJJ CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public FMGFFECFLLJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x6F82880", Offset = "0x6F81080", VA = "0x186F82880")]
		internal bool MAILGLLBAAJ(KeepsakeRoomListDTO roomListDto)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private struct KMGCPJGPKDE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public KLPAPPEIBGA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public DLBOGIKOAJL args;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x6F916F0", Offset = "0x6F8FEF0", VA = "0x186F916F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x6F91C10", Offset = "0x6F90410", VA = "0x186F91C10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private struct HHKDCBFGBNG : IAsyncStateMachine
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
		public KLPAPPEIBGA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public string message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x6F82EE0", Offset = "0x6F816E0", VA = "0x186F82EE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x6F83170", Offset = "0x6F81970", VA = "0x186F83170", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly DateTime NHPBMABACHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly GLEPAHCOLDK AADBKJEAPCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly JJOIPAIBFMA LOCLHFOBHJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly NJGJFENAHFE DGCANIMNDNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly FACCIHHKMMG NJMCMNLEFNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly IAGIDJJHKCJ JCCNNNNOALN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly EANLPKAHCMH KGOFCICMCGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly GKICLCGBOMN GIJEODMEHOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly LIMEHMPEEEM GPBNDJAMPKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly HGKHIOLHJPP ENGFPACHMLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly HIOHIJELEPE IGBPALNBDAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly JBGKCNNBNKB PDAGIGFFIOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly KDNHMHNNFHP PDGAPPGLJLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly HANBPCBCJHN DPCJLEHNNOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly KECEFGLCHBO ECMAAOICPJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly HPEADDKCNII DIBOKBALCMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly HGCDCJGPAJF<KeepsakesConfig.KeepsakesOptions> PJFCIKCGIIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly BLOHICJFBII ONJINLHNHKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly Dictionary<Guid, KeepsakeInstanceDTO> DDLEPIDKFBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly HashSet<Guid> JGGLBKDAFEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly HashSet<long> PAAICINOIEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private Dictionary<NHCLBNIPKNG, int> GJGECFELGOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly HashSet<Guid> EOFPLOADBOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly IDisposable CCGJFIOACDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private Task HJMOCAONFBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private AKLEHMINLPM<Guid> DEGGCAAHOCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private long? COAHEOHIPOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private KeepsakeProgressionEventInstancesDTO NAAEGFALAFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private AKLEHMINLPM<KeepsakeProgressionEventInstancesDTO> GAHOLIAIPIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private IReadOnlyDictionary<NHCLBNIPKNG, KeepsakeCategoryConfigDTO> BEENKGBPKPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private KeepsakeGlobalConfigDTO KOIBILJJOEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private HashSet<long> COKHLFONIFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private HashSet<long> FOPLMCOGFPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private List<KeepsakeRoomListDTO> COIECDICCEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private List<KeepsakeRoomListDTO> MACLHBIFNBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private List<KeepsakeRoomListDTO> FDMFNCMGFJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private Dictionary<long, string> LFAAGPIHAAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private Dictionary<long, string> NBPIBBLPNGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private Dictionary<long, DateTime> PMDDCLOBHGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private Dictionary<long, List<KeepsakeRoomDTO>> NKGHHIGJKGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private Dictionary<long, List<KeepsakeRoomDTO>> MGOGCAOKNCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private Dictionary<long, long> KDHGCFPJLGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly List<string> NOIGFJNJGMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private DateTime NAPEKPIIDME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly IDisposable PMHCNFADPHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private Dictionary<Guid, NHCLBNIPKNG> FOKFMMBMFIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private Dictionary<NHCLBNIPKNG, int> LAACNMAOGDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private List<KeepsakeCategoryThemePair> BODJLADCHCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private PPKOGJCONHJ HJHOJFPJAGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private bool PNNLMDFKPDM;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool GBGAJBOFMHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8E3DA0", Offset = "0x8E25A0", VA = "0x1808E3DA0", Slot = "53")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8E3B20", Offset = "0x8E2320", VA = "0x1808E3B20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool JHPLHCCIADP
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6F8F480", Offset = "0x6F8DC80", VA = "0x186F8F480", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool LJBHBOIABHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6F84E20", Offset = "0x6F83620", VA = "0x186F84E20", Slot = "36")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private long EJMOOGGGEPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6F8B6D0", Offset = "0x6F89ED0", VA = "0x186F8B6D0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private long? OBCDCAJAEHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6F8F220", Offset = "0x6F8DA20", VA = "0x186F8F220")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private bool BGBPOINBDJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6F886E0", Offset = "0x6F86EE0", VA = "0x186F886E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public IReadOnlyList<KeepsakeRoomListDTO> GNFKPHNIIOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x9DB490", Offset = "0x9D9C90", VA = "0x1809DB490", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public IReadOnlyList<KeepsakeRoomListDTO> PMJBLKHJGDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x976780", Offset = "0x974F80", VA = "0x180976780", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IReadOnlyList<KeepsakeRoomListDTO> DMODPEACBLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xED1B20", Offset = "0xED0320", VA = "0x180ED1B20", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public IReadOnlyDictionary<long, string> FPLMMNMLPHP
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x9DB5F0", Offset = "0x9D9DF0", VA = "0x1809DB5F0", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	internal bool NCMJBJCPDJM
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2049FA0", Offset = "0x20487A0", VA = "0x182049FA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Guid?> HCALJKJECFO
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6F8E660", Offset = "0x6F8CE60", VA = "0x186F8E660", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6F860F0", Offset = "0x6F848F0", VA = "0x186F860F0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action GHKKDGIEJKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6F8A6A0", Offset = "0x6F88EA0", VA = "0x186F8A6A0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6F87310", Offset = "0x6F85B10", VA = "0x186F87310", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action BHGJIBDEMDN
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6F8E3B0", Offset = "0x6F8CBB0", VA = "0x186F8E3B0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6F85180", Offset = "0x6F83980", VA = "0x186F85180", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6F90130", Offset = "0x6F8E930", VA = "0x186F90130")]
	[RecRoom.NoEngine.Common.Preserve]
	internal KLPAPPEIBGA([NDCFMLCHJCI(null)][NotNull] GLEPAHCOLDK AADBKJEAPCN, [NotNull][NDCFMLCHJCI(null)] DLEJEIAEBAP PMFNDHNLNNO, [NotNull][NDCFMLCHJCI(null)] JJOIPAIBFMA LOCLHFOBHJM, [NotNull][NDCFMLCHJCI(null)] NJGJFENAHFE DGCANIMNDNJ, [NDCFMLCHJCI(null)][NotNull] FACCIHHKMMG NJMCMNLEFNI, [NDCFMLCHJCI(null)][NotNull] IAGIDJJHKCJ JCCNNNNOALN, [NDCFMLCHJCI(null)][NotNull] EANLPKAHCMH KGOFCICMCGB, [NotNull][NDCFMLCHJCI(null)] GKICLCGBOMN GIJEODMEHOJ, [NotNull][NDCFMLCHJCI(null)] LIMEHMPEEEM GPBNDJAMPKD, [NotNull][NDCFMLCHJCI(null)] CEGHFAIAMHL ELKJGKAKHHC, [NotNull][NDCFMLCHJCI(null)] HGKHIOLHJPP ENGFPACHMLH, [NotNull][NDCFMLCHJCI(null)] HIOHIJELEPE IGBPALNBDAN, [NotNull][NDCFMLCHJCI(null)] JBGKCNNBNKB PDAGIGFFIOB, [NotNull][NDCFMLCHJCI(null)] KDNHMHNNFHP PDGAPPGLJLC, [NDCFMLCHJCI(null)][NotNull] HANBPCBCJHN DPCJLEHNNOK, [NDCFMLCHJCI(null)][NotNull] KECEFGLCHBO ECMAAOICPJN, [NotNull][NDCFMLCHJCI(null)] HPEADDKCNII DIBOKBALCMJ, [NDCFMLCHJCI(null)][NotNull] HGCDCJGPAJF<KeepsakesConfig.KeepsakesOptions> PJFCIKCGIIA, [NotNull][NDCFMLCHJCI(null)] BLOHICJFBII ONJINLHNHKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6F87BF0", Offset = "0x6F863F0", VA = "0x186F87BF0", Slot = "15")]
	public bool EPFAJKEPODN(List<string> LIAEDEILFLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6F875E0", Offset = "0x6F85DE0", VA = "0x186F875E0", Slot = "16")]
	public AKLEHMINLPM<Guid> EKIJBBFAIEM(NHCLBNIPKNG HJOECMPFEAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6F8B450", Offset = "0x6F89C50", VA = "0x186F8B450", Slot = "17")]
	public MOPOHKAGKCI HJPMMNBGCGN(Guid NOIIKCGGEGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6F86B80", Offset = "0x6F85380", VA = "0x186F86B80", Slot = "18")]
	public MOPOHKAGKCI ECHJBHEAAGD(Guid NOIIKCGGEGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6F83C40", Offset = "0x6F82440", VA = "0x186F83C40", Slot = "19")]
	public bool AHHBEONBFEP(Guid NOIIKCGGEGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6F8C590", Offset = "0x6F8AD90", VA = "0x186F8C590", Slot = "20")]
	public bool IMDABBBKHHN(Guid NOIIKCGGEGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6F8EF50", Offset = "0x6F8D750", VA = "0x186F8EF50")]
	public KeepsakeTheme NGHAFLAMKGN(Guid NOIIKCGGEGJ)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6F8E040", Offset = "0x6F8C840", VA = "0x186F8E040")]
	public bool LKDNJNFLFMP(NHCLBNIPKNG HJOECMPFEAP, [Out] KeepsakeTheme HHMMGDPNHGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6F8D280", Offset = "0x6F8BA80", VA = "0x186F8D280")]
	public List<KeepsakeTheme> KOCIPCAFION()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6F87FE0", Offset = "0x6F867E0", VA = "0x186F87FE0")]
	public int FCLLNHAKHOI(NHCLBNIPKNG HJOECMPFEAP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6F8D120", Offset = "0x6F8B920", VA = "0x186F8D120")]
	public NHCLBNIPKNG KHABKCJGAII(Guid NOIIKCGGEGJ)
	{
		return default(NHCLBNIPKNG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6F871C0", Offset = "0x6F859C0", VA = "0x186F871C0", Slot = "34")]
	public List<NHCLBNIPKNG> EIACFJEJGFF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6F85220", Offset = "0x6F83A20", VA = "0x186F85220", Slot = "35")]
	public IComparer<NHCLBNIPKNG> CKPBEPLFOHO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6F88E10", Offset = "0x6F87610", VA = "0x186F88E10", Slot = "32")]
	public string GDNENIHENED(NHCLBNIPKNG HJOECMPFEAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6F87040", Offset = "0x6F85840", VA = "0x186F87040", Slot = "33")]
	public string EGIELPPMLME(NHCLBNIPKNG HJOECMPFEAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6F84EE0", Offset = "0x6F836E0", VA = "0x186F84EE0", Slot = "21")]
	public bool CHPLBDAHHOA(Guid NOIIKCGGEGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6F8C6C0", Offset = "0x6F8AEC0", VA = "0x186F8C6C0", Slot = "22")]
	public void JGGFCDGIDLF(Guid NOIIKCGGEGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6F88160", Offset = "0x6F86960", VA = "0x186F88160", Slot = "23")]
	public void FDMCFMGMOFL(NHCLBNIPKNG HJOECMPFEAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6F88290", Offset = "0x6F86A90", VA = "0x186F88290", Slot = "24")]
	public void FFPGIOHCFFJ(Guid NOIIKCGGEGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6F8A740", Offset = "0x6F88F40", VA = "0x186F8A740", Slot = "25")]
	public int HEEHLOBCEJN()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6F8C930", Offset = "0x6F8B130", VA = "0x186F8C930", Slot = "31")]
	public AKLEHMINLPM<IEnumerable<Guid>> KAIDBOMLHEB(long NKDNOGOOODN, long COAIJBNLMGB, NHCLBNIPKNG? HJOECMPFEAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6F8E220", Offset = "0x6F8CA20", VA = "0x186F8E220", Slot = "30")]
	public AKLEHMINLPM<IEnumerable<Guid>> LMBBIEGFHAM(long NKDNOGOOODN, long COAIJBNLMGB, NHCLBNIPKNG? HJOECMPFEAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6F8BE20", Offset = "0x6F8A620", VA = "0x186F8BE20", Slot = "54")]
	public AKLEHMINLPM<Dictionary<Guid, NHCLBNIPKNG>> IGEKFPJAOAM(long NKDNOGOOODN, long COAIJBNLMGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6F8DEB0", Offset = "0x6F8C6B0", VA = "0x186F8DEB0", Slot = "55")]
	public AKLEHMINLPM<Dictionary<Guid, NHCLBNIPKNG>> LJNGDBHGHIE(long NKDNOGOOODN, long COAIJBNLMGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6F8B1B0", Offset = "0x6F899B0", VA = "0x186F8B1B0", Slot = "26")]
	public AKLEHMINLPM<int> HJNIIEMABAH(long NKDNOGOOODN, long COAIJBNLMGB, NHCLBNIPKNG? HJOECMPFEAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6F87E80", Offset = "0x6F86680", VA = "0x186F87E80", Slot = "27")]
	public AKLEHMINLPM<int> EPNMAOLAFAC(long NKDNOGOOODN, long COAIJBNLMGB, NHCLBNIPKNG? HJOECMPFEAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6F884D0", Offset = "0x6F86CD0", VA = "0x186F884D0", Slot = "28")]
	public AKLEHMINLPM<Dictionary<NHCLBNIPKNG, int>> FHIIDCAPPDE(long NKDNOGOOODN, long COAIJBNLMGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6F88F90", Offset = "0x6F87790", VA = "0x186F88F90", Slot = "29")]
	public AKLEHMINLPM<Dictionary<NHCLBNIPKNG, int>> GDPCDPMANOE(long NKDNOGOOODN, long COAIJBNLMGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6F86F00", Offset = "0x6F85700", VA = "0x186F86F00", Slot = "37")]
	public bool ECOKMMKAHPE(long NKDNOGOOODN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6F845E0", Offset = "0x6F82DE0", VA = "0x186F845E0", Slot = "56")]
	public bool AMKPNMGFLAG(long NKDNOGOOODN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6F873B0", Offset = "0x6F85BB0", VA = "0x186F873B0", Slot = "38")]
	public bool EJIIJGBHNKN(long NKDNOGOOODN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6F89050", Offset = "0x6F87850", VA = "0x186F89050", Slot = "57")]
	public bool GHILMHPKAFL(long NKDNOGOOODN, [Out] GPJOHONIJHH BLIKPHFCCCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6F84BB0", Offset = "0x6F833B0", VA = "0x186F84BB0", Slot = "39")]
	public bool CBPCEEIIDIC(long LEFDLNKCBIP, [Out] DateTime OCHOIAAJMLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6F8D630", Offset = "0x6F8BE30", VA = "0x186F8D630", Slot = "40")]
	public long KPCNMMCCPIF(long LEFDLNKCBIP)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6F8E710", Offset = "0x6F8CF10", VA = "0x186F8E710", Slot = "41")]
	public long MJAKJPDNPCE(long NKDNOGOOODN)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6F886F0", Offset = "0x6F86EF0", VA = "0x186F886F0", Slot = "42")]
	public int FILLNHBHIML(long LEFDLNKCBIP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6F86F60", Offset = "0x6F85760", VA = "0x186F86F60", Slot = "43")]
	public bool EDMAINNAPJM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6F87450", Offset = "0x6F85C50", VA = "0x186F87450", Slot = "44")]
	public bool EKEIHDHMMBC(long LEFDLNKCBIP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6F8DBD0", Offset = "0x6F8C3D0", VA = "0x186F8DBD0", Slot = "45")]
	public IReadOnlyList<long> LIFFEELBOPE(long LEFDLNKCBIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6F8EB20", Offset = "0x6F8D320", VA = "0x186F8EB20", Slot = "46")]
	public int MNAGFIABNEC(long LEFDLNKCBIP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6F8C1D0", Offset = "0x6F8A9D0", VA = "0x186F8C1D0", Slot = "50")]
	public long IHHFCHGPJOO(long CBONEGIONEN)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6F88AA0", Offset = "0x6F872A0", VA = "0x186F88AA0", Slot = "51")]
	public NHCLBNIPKNG GBIBLCAAMLB()
	{
		return default(NHCLBNIPKNG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6F8EE20", Offset = "0x6F8D620", VA = "0x186F8EE20")]
	private bool NEPBMGOMGKB(Guid NOIIKCGGEGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6F846E0", Offset = "0x6F82EE0", VA = "0x186F846E0")]
	private void CAFHHBJABIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6F8FA60", Offset = "0x6F8E260", VA = "0x186F8FA60")]
	private NHCLBNIPKNG PFHONHJJBPM()
	{
		return default(NHCLBNIPKNG);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6F85AB0", Offset = "0x6F842B0", VA = "0x186F85AB0")]
	private void DDAHCLEEDAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6F8E450", Offset = "0x6F8CC50", VA = "0x186F8E450")]
	private int MCPDDCNDDKF(KeepsakeRoomListDTO HNDFHNMIEEO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6F8C490", Offset = "0x6F8AC90", VA = "0x186F8C490")]
	private int IKBMCFGHLLB(DateTime JKNACLBOPIN, DateTime MNCGGJAPGEE, TimeSpan GMNLDOCCFFF, int EAKJECOIBKJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6F86460", Offset = "0x6F84C60", VA = "0x186F86460")]
	private void DPCFGOKHJGE(IEnumerable<KeepsakeInstanceDTO> DDLEPIDKFBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6F8EBD0", Offset = "0x6F8D3D0", VA = "0x186F8EBD0")]
	private void NCPNIEABKGI(IEnumerable<KeepsakeCollectionRecordDTO> GBOIAOBDGHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6F85680", Offset = "0x6F83E80", VA = "0x186F85680")]
	private void COBHMPMFELP(IEnumerable<long> MPACJMFNCIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0xF684A0", Offset = "0xF66CA0", VA = "0x180F684A0")]
	private void NIOLMFLJGFM(KeepsakeGlobalConfigDTO KOIBILJJOEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x6F839B0", Offset = "0x6F821B0", VA = "0x186F839B0")]
	private bool AEIJLCJJJAG(NHCLBNIPKNG HJOECMPFEAP, [Out] Guid NLBCBBBFEGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6F84640", Offset = "0x6F82E40", VA = "0x186F84640")]
	private bool AOGGOOLEMLM([Out] Guid NLBCBBBFEGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6F8DB70", Offset = "0x6F8C370", VA = "0x186F8DB70")]
	private bool LALOHEFAOOI(Guid NOIIKCGGEGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6F8CFC0", Offset = "0x6F8B7C0", VA = "0x186F8CFC0")]
	private IEnumerable<Guid> KELBJGPKKNM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x6F888D0", Offset = "0x6F870D0", VA = "0x186F888D0")]
	private IEnumerable<KeepsakeInstanceDTO> FJNPGDNEOHE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6F889F0", Offset = "0x6F871F0", VA = "0x186F889F0")]
	private void FNGLFDMDPAD(Guid NOIIKCGGEGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6F836F0", Offset = "0x6F81EF0", VA = "0x186F836F0")]
	private bool AANEELGJJLE(Guid NOIIKCGGEGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6F8FDC0", Offset = "0x6F8E5C0", VA = "0x186F8FDC0")]
	private void PIAEEOOLEME(Guid NOIIKCGGEGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6F881B0", Offset = "0x6F869B0", VA = "0x186F881B0")]
	private void FEFEDEICEGI(NHCLBNIPKNG ACLOEPFIMMM, int CFHHNEODIHH, Dictionary<NHCLBNIPKNG, int> DDAGGMMEPLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6F90040", Offset = "0x6F8E840", VA = "0x186F90040")]
	private int PNLFKIPGPLP(NHCLBNIPKNG HJOECMPFEAP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6F89400", Offset = "0x6F87C00", VA = "0x186F89400")]
	private void GIGFKJHMPFG(KeepsakeInstanceDTO GJCNLEMLNAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6F837A0", Offset = "0x6F81FA0", VA = "0x186F837A0")]
	private void ACLCFDBOAIL(KeepsakeInstanceDTO GJCNLEMLNAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6F856E0", Offset = "0x6F83EE0", VA = "0x186F856E0")]
	private void DBBKENPCLBA(Guid NOIIKCGGEGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6F866F0", Offset = "0x6F84EF0", VA = "0x186F866F0")]
	private void HCLMPFNLDED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6F88A80", Offset = "0x6F87280", VA = "0x186F88A80")]
	private void FOBAHEPIGPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6F8DE40", Offset = "0x6F8C640", VA = "0x186F8DE40")]
	private void LJCPABAFFLC(BIBPMJIGLBK AKOGEPKEAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6F866F0", Offset = "0x6F84EF0", VA = "0x186F866F0")]
	private void KANGHNKGPNG(EMIEMKNGEAE INCBEIDOHDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6F866F0", Offset = "0x6F84EF0", VA = "0x186F866F0")]
	private void DPDKEFBCHAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6F852E0", Offset = "0x6F83AE0", VA = "0x186F852E0")]
	private void CNPMGAFCEGA(float KJOMHGBFMLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6F8B880", Offset = "0x6F8A080", VA = "0x186F8B880")]
	private void IDHCGIFIBJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6F8C730", Offset = "0x6F8AF30", VA = "0x186F8C730")]
	private bool KAFGIJAPMPJ(Guid NOIIKCGGEGJ, [Out] string IDAJBBFLAKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6F8F2B0", Offset = "0x6F8DAB0", VA = "0x186F8F2B0")]
	private bool OEHBPOOKOKD(Guid NOIIKCGGEGJ, [Out] KeepsakeCategoryConfigDTO ACLOEPFIMMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6F8FF60", Offset = "0x6F8E760", VA = "0x186F8FF60")]
	private void PKFKMDMMGPF(string AONPPGHOFDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6F8F6B0", Offset = "0x6F8DEB0", VA = "0x186F8F6B0")]
	private bool OOPFKMDHLIK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6F8CCE0", Offset = "0x6F8B4E0", VA = "0x186F8CCE0")]
	private List<long> KCHGLPGILHO(IEnumerable<KeepsakeRoomDTO> KOPLDFGAPKG, IReadOnlyList<KeepsakeRoomListDTO> OLHBBFANJBE, long LEFDLNKCBIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6F8AC90", Offset = "0x6F89490", VA = "0x186F8AC90")]
	private bool HGDBPMOOOFI(Guid NOIIKCGGEGJ, [Out] string JBBHONJKFOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6F88990", Offset = "0x6F87190", VA = "0x186F88990", Slot = "47")]
	public string FKMNMHBKPJM(ABDIINAKIJH BJJKKBNHGMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6F84160", Offset = "0x6F82960", VA = "0x186F84160", Slot = "49")]
	public string AILJCOPCLCC(ABDIINAKIJH BJJKKBNHGMB, long NKDNOGOOODN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6F8B7A0", Offset = "0x6F89FA0", VA = "0x186F8B7A0", Slot = "48")]
	public string ICGFBHGLHDO(ABDIINAKIJH BJJKKBNHGMB, int BFHMPILILHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6F897B0", Offset = "0x6F87FB0", VA = "0x186F897B0")]
	private void GPCHDAPJAAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6F8E990", Offset = "0x6F8D190", VA = "0x186F8E990")]
	private void MLDFPELLDMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6F8F090", Offset = "0x6F8D890", VA = "0x186F8F090")]
	private ABDIINAKIJH NLGALLCPNJK(BIFKICKCOCB DOOBNCEIFFJ)
	{
		return default(ABDIINAKIJH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6F8F690", Offset = "0x6F8DE90", VA = "0x186F8F690")]
	private ABDIINAKIJH OMEELDANNNC(BIFKICKCOCB DOOBNCEIFFJ)
	{
		return default(ABDIINAKIJH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6F895D0", Offset = "0x6F87DD0", VA = "0x186F895D0")]
	internal static string GKICEDDCBLI(NFEPHJLEDEH KKEMJABKDOK, string OOJIDOMANBE, bool LDGKKAILGIB, int JDJBHEFNPGI, int HGBIPDPHJEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6F86720", Offset = "0x6F84F20", VA = "0x186F86720", Slot = "52")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6F8FD40", Offset = "0x6F8E540", VA = "0x186F8FD40")]
	private NDIOHACFFEO PGHOMINDHHA(OEDKOGGDKCO MLPPKHDJMNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6F8F4D0", Offset = "0x6F8DCD0", VA = "0x186F8F4D0")]
	private KGHNBLFJMNI OIIBKINNBCB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6F83DA0", Offset = "0x6F825A0", VA = "0x186F83DA0")]
	private Task AHIFBLDDBDF(DLBOGIKOAJL GIOJKAECAOO, CancellationToken ALKEMFHOMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6F8AB80", Offset = "0x6F89380", VA = "0x186F8AB80")]
	[AsyncStateMachine(typeof(KMGCPJGPKDE))]
	private Task HFLDOHNOPIN(DLBOGIKOAJL GIOJKAECAOO, CancellationToken ALKEMFHOMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6F8F980", Offset = "0x6F8E180", VA = "0x186F8F980")]
	private Task PEFAINMDNCH(DLBOGIKOAJL GIOJKAECAOO, CancellationToken ALKEMFHOMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6F84CF0", Offset = "0x6F834F0", VA = "0x186F84CF0")]
	[AsyncStateMachine(typeof(HHKDCBFGBNG))]
	private Task CEOCBEDLJCA(string PJFOMDHJLBF, TimeSpan HGPHMKJNKGE, CancellationToken ALKEMFHOMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6F8E5F0", Offset = "0x6F8CDF0", VA = "0x186F8E5F0")]
	[CompilerGenerated]
	private void MGALKAHLALH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6F8E610", Offset = "0x6F8CE10", VA = "0x186F8E610")]
	[CompilerGenerated]
	private void MHCFFFOCCAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6F8C5C0", Offset = "0x6F8ADC0", VA = "0x186F8C5C0")]
	[CompilerGenerated]
	private bool IOBOCGNNDJK(KeepsakeInstanceDTO KHINBLFKKED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6F8F0B0", Offset = "0x6F8D8B0", VA = "0x186F8F0B0")]
	[CompilerGenerated]
	private AKLEHMINLPM<Dictionary<NHCLBNIPKNG, int>> NMEDHAMLAJM(Dictionary<Guid, NHCLBNIPKNG> NLLCEADGCAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6F8E820", Offset = "0x6F8D020", VA = "0x186F8E820")]
	[CompilerGenerated]
	private AKLEHMINLPM<Dictionary<NHCLBNIPKNG, int>> MKFJKIFCFJG(Dictionary<Guid, NHCLBNIPKNG> NLLCEADGCAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6F83C20", Offset = "0x6F82420", VA = "0x186F83C20")]
	[CompilerGenerated]
	private bool AFBJOGDOBKK(KeepsakeRoomListDTO KHINBLFKKED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6F86330", Offset = "0x6F84B30", VA = "0x186F86330")]
	[CompilerGenerated]
	private bool DGJKCMKMPAJ(KeepsakeInstanceDTO KHINBLFKKED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6F861A0", Offset = "0x6F849A0", VA = "0x186F861A0")]
	[CompilerGenerated]
	private void DDEMIDFAACD(Tuple<KeepsakeRoomInstancesDTO, IReadOnlyDictionary<NHCLBNIPKNG, KeepsakeCategoryConfigDTO>, KeepsakeGlobalConfigDTO> OPNJOKBMFIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6F84580", Offset = "0x6F82D80", VA = "0x186F84580")]
	[CompilerGenerated]
	private void AJMNBHPICFC(string JBBHONJKFOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6F8F7C0", Offset = "0x6F8DFC0", VA = "0x186F8F7C0")]
	[CompilerGenerated]
	private Task PACEKDHHPEM(CancellationToken KOHGMOHAGPF)
	{
		return null;
	}
}
namespace RecRoom.Keepsakes
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public class KeepsakesConfig : ScriptableObject, HGCDCJGPAJF<KeepsakesConfig.KeepsakesOptions>
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200002B")]
		public class KeepsakesOptions
		{
			[Cpp2IlInjected.Token(Token = "0x200002C")]
			[CompilerGenerated]
			private sealed class CEHMPFBIJAG
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000098")]
				public string themeId;

				[Cpp2IlInjected.Token(Token = "0x60000F3")]
				[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
				public CEHMPFBIJAG()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000F4")]
				[Cpp2IlInjected.Address(RVA = "0x6F81E20", Offset = "0x6F80620", VA = "0x186F81E20")]
				internal bool INBMGKKADNJ(KeepsakeTheme x)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60000F5")]
				[Cpp2IlInjected.Address(RVA = "0x6F81E20", Offset = "0x6F80620", VA = "0x186F81E20")]
				internal bool GBICCLDLJKA(KeepsakeTheme x)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			[SerializeField]
			private KeepsakeTheme[] themes;

			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x6F91CF0", Offset = "0x6F904F0", VA = "0x186F91CF0")]
			public bool ONBGCCAKMKA(string OLBNCIHHNLM, [Out] KeepsakeTheme HHMMGDPNHGO)
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
			[Cpp2IlInjected.Address(RVA = "0x8B51D0", Offset = "0x8B39D0", VA = "0x1808B51D0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x6F91C70", Offset = "0x6F90470", VA = "0x186F91C70")]
		[PDAMAKFHAHC.GNFCFDNPMLH.BGLEOICIJCF]
		internal static void EDDDBNCFOFG(CMONJLKOOCI MFHCHOKEAIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x9535A0", Offset = "0x951DA0", VA = "0x1809535A0")]
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
