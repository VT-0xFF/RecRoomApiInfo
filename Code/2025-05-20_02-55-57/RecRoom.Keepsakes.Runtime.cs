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
		[Cpp2IlInjected.Address(RVA = "0x7CE94A0", Offset = "0x7CE86A0", VA = "0x187CE94A0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2675970", Offset = "0x2674B70", VA = "0x182675970")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class LMNGJHAPJCM : IComparer<DCGPHHIICLO>
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private sealed class IOPGIEONHKP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public DCGPHHIICLO x;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public DCGPHHIICLO y;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public IOPGIEONHKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xCF1A90", Offset = "0xCF0C90", VA = "0x180CF1A90")]
		internal bool BBJBPHOAOIP(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x1E9F930", Offset = "0x1E9EB30", VA = "0x181E9F930")]
		internal bool BLKHPCGCKEI(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xCF1A90", Offset = "0xCF0C90", VA = "0x180CF1A90")]
		internal bool GAFDHPNDLAI(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1E9F930", Offset = "0x1E9EB30", VA = "0x181E9F930")]
		internal bool KHMHNLFHAAG(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private List<KeepsakeCategoryThemePair> ALMJPIPLAPN;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x9FB1E0", Offset = "0x9FA3E0", VA = "0x1809FB1E0")]
	public LMNGJHAPJCM(List<KeepsakeCategoryThemePair> LMDKNFMFGJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7CE8050", Offset = "0x7CE7250", VA = "0x187CE8050", Slot = "4")]
	public int Compare(DCGPHHIICLO CCOLDGJALNH, DCGPHHIICLO JCBKIOEHCDD)
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
		public DCGPHHIICLO KeepsakeCategory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public KeepsakeTheme KeepsakeTheme;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[CFBFBMEJALB]
public class COBHJCONPGA : EGLMAECMKPK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class GDNIEELOELO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public COBHJCONPGA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public DCGPHHIICLO keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public GDNIEELOELO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7CE6E30", Offset = "0x7CE6030", VA = "0x187CE6E30")]
		internal CMEBMOPMCFP<Guid> IEOACOHDOLH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7CE6E00", Offset = "0x7CE6000", VA = "0x187CE6E00")]
		internal void HCAENPJACKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7CE6DA0", Offset = "0x7CE5FA0", VA = "0x187CE6DA0")]
		internal void FLPLLFANCCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7CE6990", Offset = "0x7CE5B90", VA = "0x187CE6990")]
		internal void EKIMPFIPKIM(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7CE6F90", Offset = "0x7CE6190", VA = "0x187CE6F90")]
		internal void JKLODAGFANA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class PGGKFNJBGGA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public COBHJCONPGA <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public PGGKFNJBGGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7CE8E20", Offset = "0x7CE8020", VA = "0x187CE8E20")]
		internal void AAIFFLPHOCD(OIMDOANKMPG response)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7CE91D0", Offset = "0x7CE83D0", VA = "0x187CE91D0")]
		internal void HNICHDMCBCA(string error)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class EJDLFOICFEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public KeepsakeTheme theme;

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public EJDLFOICFEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x7CE6940", Offset = "0x7CE5B40", VA = "0x187CE6940")]
		internal bool MJJGOCFKFNL(KeepsakeCategoryThemePair categoryThemePair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class IIKEBFHMMGG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public COBHJCONPGA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public long progressionEventId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public DCGPHHIICLO? keepsakeCategory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public IIKEBFHMMGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x7CE7A40", Offset = "0x7CE6C40", VA = "0x187CE7A40")]
		internal void IHMBBEILOKC(KeepsakeProgressionEventInstancesDTO result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x7CE7AD0", Offset = "0x7CE6CD0", VA = "0x187CE7AD0")]
		internal void JPDOOENCDND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x7CE7740", Offset = "0x7CE6940", VA = "0x187CE7740")]
		internal CMEBMOPMCFP<IEnumerable<Guid>> FJDJAGFLCPM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x782C6F0", Offset = "0x782B8F0", VA = "0x18782C6F0")]
		internal bool NIHACFOAOGG(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class GLCLGNHDKFL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public KeepsakeRoomInstanceIdsDTO instancesInRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public IIKEBFHMMGG CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public GLCLGNHDKFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x7CE7110", Offset = "0x7CE6310", VA = "0x187CE7110")]
		internal CMEBMOPMCFP<IEnumerable<Guid>> KOHJFOGGBHN(KeepsakeRoomInstancesDTO roomInstancesDTO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class ADELGJEEFNN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public KeepsakeRoomInstancesDTO roomInstancesDTO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public GLCLGNHDKFL CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public ADELGJEEFNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x7CD8130", Offset = "0x7CD7330", VA = "0x187CD8130")]
		internal bool JBICBJHOHPD(Guid instanceId)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class KDIIFACPGFO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Guid instanceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public ADELGJEEFNN CS$<>8__locals3;

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public KDIIFACPGFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x7CE7C70", Offset = "0x7CE6E70", VA = "0x187CE7C70")]
		internal bool MAFAADFHCMO(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class EEHLMCIOFED
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public COBHJCONPGA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public EEHLMCIOFED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x7CE67D0", Offset = "0x7CE59D0", VA = "0x187CE67D0")]
		internal CMEBMOPMCFP<IEnumerable<Guid>> MIABFDHGMDO(IEnumerable<Guid> instanceIds)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x7CE67B0", Offset = "0x7CE59B0", VA = "0x187CE67B0")]
		internal bool CIFFKNGPLOO(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class MJMJMDMPLFC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public COBHJCONPGA <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public MJMJMDMPLFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x7CE8300", Offset = "0x7CE7500", VA = "0x187CE8300")]
		internal void INIJAJKIICB(KeepsakeProgressionEventInstancesDTO result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x7CE7AD0", Offset = "0x7CE6CD0", VA = "0x187CE7AD0")]
		internal void MEACJFDNIJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x7CE8390", Offset = "0x7CE7590", VA = "0x187CE8390")]
		internal CMEBMOPMCFP<Dictionary<Guid, DCGPHHIICLO>> KAGJMEHBGNL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x782C6F0", Offset = "0x782B8F0", VA = "0x18782C6F0")]
		internal bool JBEBKKKHKKM(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class DLDAJCABKLD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public KeepsakeRoomInstanceIdsDTO instancesInRoom;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public DLDAJCABKLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x7CE6600", Offset = "0x7CE5800", VA = "0x187CE6600")]
		internal CMEBMOPMCFP<Dictionary<Guid, DCGPHHIICLO>> OEDPPJMPAOB(KeepsakeRoomInstancesDTO roomInstancesDTO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class BEEBEBGAPFB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public KeepsakeRoomInstancesDTO roomInstancesDTO;

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public BEEBEBGAPFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x7CD8500", Offset = "0x7CD7700", VA = "0x187CD8500")]
		internal bool MMCMAHFBDDC(Guid instanceId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x7CD83B0", Offset = "0x7CD75B0", VA = "0x187CD83B0")]
		internal KeyValuePair<Guid, DCGPHHIICLO> LMEIMCDCFJG(Guid instanceId)
		{
			return default(KeyValuePair<Guid, DCGPHHIICLO>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class LMIDHBHJBKG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public Guid instanceId;

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public LMIDHBHJBKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x25119B0", Offset = "0x2510BB0", VA = "0x1825119B0")]
		internal bool IKAHFAGJIMM(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class HCFMNANBANG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public Guid instanceId;

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public HCFMNANBANG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x25119B0", Offset = "0x2510BB0", VA = "0x1825119B0")]
		internal bool OGKPFKFPMON(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class HBKLBDIICNK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public COBHJCONPGA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public HBKLBDIICNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x7CE7540", Offset = "0x7CE6740", VA = "0x187CE7540")]
		internal CMEBMOPMCFP<Dictionary<Guid, DCGPHHIICLO>> BKPEDKCEDDO(Dictionary<Guid, DCGPHHIICLO> instanceIdsAndCategories)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x7CE67B0", Offset = "0x7CE59B0", VA = "0x187CE67B0")]
		internal bool JOMHDKHIBGL(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class IKFGEPFMDDI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public KeepsakeRoomInstanceIdsDTO collectedInstanceIds;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public IKFGEPFMDDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x7CE7B00", Offset = "0x7CE6D00", VA = "0x187CE7B00")]
		internal bool GLIIFICNEDE(KeyValuePair<Guid, DCGPHHIICLO> idCategoryPair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class GGDLNHPAGMM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public Dictionary<Guid, DCGPHHIICLO> instanceIdsAndCategories;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public GGDLNHPAGMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x7CE6FC0", Offset = "0x7CE61C0", VA = "0x187CE6FC0")]
		internal KeyValuePair<DCGPHHIICLO, int> LJKPJAGFGMG(DCGPHHIICLO category)
		{
			return default(KeyValuePair<DCGPHHIICLO, int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class BHPFBJHHLIO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public DCGPHHIICLO category;

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public BHPFBJHHLIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0xDF5670", Offset = "0xDF4870", VA = "0x180DF5670")]
		internal bool JPLFCIJJGPA(DCGPHHIICLO instanceCategory)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class AJEFLOAIIFM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public Dictionary<Guid, DCGPHHIICLO> instanceIdsAndCategories;

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public AJEFLOAIIFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x7CD8260", Offset = "0x7CD7460", VA = "0x187CD8260")]
		internal KeyValuePair<DCGPHHIICLO, int> FPCAGPOAAGG(DCGPHHIICLO category)
		{
			return default(KeyValuePair<DCGPHHIICLO, int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class INCDAKHMDOG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public DCGPHHIICLO category;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public INCDAKHMDOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0xDF5670", Offset = "0xDF4870", VA = "0x180DF5670")]
		internal bool KCFJMOMMMPG(DCGPHHIICLO instanceCategory)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class OLFGNBMNCMK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public COBHJCONPGA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public Func<KeepsakeRoomDTO, bool> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public OLFGNBMNCMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x7CE8C30", Offset = "0x7CE7E30", VA = "0x187CE8C30")]
		internal bool JLFLECAJEMF(DateTime nowUtc, DateTime eventStartTime, int roomOrder, TimeSpan unlockStartOffset, TimeSpan unlockInterval, int unlockBatchSize)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x7CE8D20", Offset = "0x7CE7F20", VA = "0x187CE8D20")]
		internal bool LHFBAKKNFKM(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x7CE8C10", Offset = "0x7CE7E10", VA = "0x187CE8C10")]
		internal bool MJDGEHMLIAH(KeepsakeRoomDTO r)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x7CE8C10", Offset = "0x7CE7E10", VA = "0x187CE8C10")]
		internal bool FABMEKIGLON(KeepsakeRoomDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class OAMBBBFLBDI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public OAMBBBFLBDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0xE6E1F0", Offset = "0xE6D3F0", VA = "0x180E6E1F0")]
		internal bool OLAPCPFOMCG(KeepsakeRoomListDTO roomList)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class CINKCJHJAEK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public Func<KeepsakeRoomDTO, bool> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public CINKCJHJAEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x7CD85E0", Offset = "0x7CD77E0", VA = "0x187CD85E0")]
		internal bool BEMANINNBIB(KeepsakeRoomListDTO roomList)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x249D640", Offset = "0x249C840", VA = "0x18249D640")]
		internal bool DHFIKMEOFFM(KeepsakeRoomDTO room)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class PPLBMINJFII
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public PPLBMINJFII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x7CE9230", Offset = "0x7CE8430", VA = "0x187CE9230")]
		internal bool GGELLJOJADM(KeepsakeRoomListDTO i)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class ACLFOCBOGHL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public ACLFOCBOGHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0xE6E1F0", Offset = "0xE6D3F0", VA = "0x180E6E1F0")]
		internal bool KJFKPBFHBAG(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class LLIPJAHJHPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public Guid keepsakeInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public LLIPJAHJHPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x7CE7FF0", Offset = "0x7CE71F0", VA = "0x187CE7FF0")]
		internal bool JIPPLEEKCHC(KeyValuePair<Guid, KeepsakeInstanceDTO> instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class NCEKHNNGNFK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public DCGPHHIICLO keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public NCEKHNNGNFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x20BCEB0", Offset = "0x20BC0B0", VA = "0x1820BCEB0")]
		internal bool HMFCNKAAKAH(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class CNLAEKHGMEK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public Guid keepsakeInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public CNLAEKHGMEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x7CD86A0", Offset = "0x7CD78A0", VA = "0x187CD86A0")]
		internal bool LGDFKCHDMCM(KeyValuePair<Guid, KeepsakeInstanceDTO> instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class PBLPPAFMALB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public DCGPHHIICLO keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public PBLPPAFMALB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x7CE8DE0", Offset = "0x7CE7FE0", VA = "0x187CE8DE0")]
		internal bool CEKKIBNIAJI(KeyValuePair<Guid, DCGPHHIICLO> x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class KMPBMNHFGFK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public DCGPHHIICLO newKeepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public KMPBMNHFGFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x20BCEB0", Offset = "0x20BC0B0", VA = "0x1820BCEB0")]
		internal bool EHEBNLPGGBA(KeepsakeInstanceDTO instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class AAJGMGAMPPH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public long currentRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public long? currentSubRoomId;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public AAJGMGAMPPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x7CD80B0", Offset = "0x7CD72B0", VA = "0x187CD80B0")]
		internal bool CGGMHGIHHLC(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class JLEAFAGDCLA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public IReadOnlyList<KeepsakeRoomListDTO> roomList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public JLEAFAGDCLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x7CE7B80", Offset = "0x7CE6D80", VA = "0x187CE7B80")]
		internal bool CADJAKJADBF(KeepsakeRoomDTO room)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class KLBHINFJJKN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public KeepsakeRoomDTO room;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public JLEAFAGDCLA CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public KLBHINFJJKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x7CE7D20", Offset = "0x7CE6F20", VA = "0x187CE7D20")]
		internal bool KKNNIBLBDAC(KeepsakeRoomListDTO roomListDto)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private struct MMBIIJBBHGO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public COBHJCONPGA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public FIEDEFBCGNM args;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x7CE8680", Offset = "0x7CE7880", VA = "0x187CE8680", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x7CE8BB0", Offset = "0x7CE7DB0", VA = "0x187CE8BB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private struct GMEFLIJBFDI : IAsyncStateMachine
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
		public COBHJCONPGA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public string message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x7CE7250", Offset = "0x7CE6450", VA = "0x187CE7250", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x7CE74E0", Offset = "0x7CE66E0", VA = "0x187CE74E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly DateTime HPLBOGGKFDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly MLCELPLGHKN LAPNHAHNKLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly AHKNKJFPJIE KFOPANHGDFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly ABAOLACCHHL GLLBKLDJIOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly PMODAIEAAOP FKDMJOECDHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly KBPOKGNGKKF LLMBGPNPABD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly PLIGANGDPHD DLLAGJGMJFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly EHKLKJJGGDO FKBGIHJJFDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly LKDJDKEKNAC GCMEJOEAFHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly GOGDPAFONHA DCNJHEFHBIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly GDINEDNDDOD AEGDAOMLJMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly OLALNMLGOHH AAEENKJEJHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly OPOKCJLOHBC BPBACNMDAIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly GLLIIHCJKOA GGCLFNKAIGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly JIDDDLABHMA JBFEHBPNHBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly DECADMNPJIG ICPFLHOEKBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly EPIFIECCMDK<KeepsakesConfig.KeepsakesOptions> KDLGPMFPDII;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly HJGCGGODOAD MIFPNJKPFOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly Dictionary<Guid, KeepsakeInstanceDTO> NFCPOCPCPOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly HashSet<Guid> NEPIPJFNAOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly HashSet<long> IBHGJMLBECM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private Dictionary<DCGPHHIICLO, int> AJCJGFEKMFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly HashSet<Guid> MBAPFOPKFDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly IDisposable CDOPMOFGGLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private Task EOPEGELMNNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private CMEBMOPMCFP<Guid> GBDNDHDJCIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private long? BICFNKLNHAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private KeepsakeProgressionEventInstancesDTO EPAKLPHNIPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private CMEBMOPMCFP<KeepsakeProgressionEventInstancesDTO> NGLKMBLKDGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private IReadOnlyDictionary<DCGPHHIICLO, KeepsakeCategoryConfigDTO> GKENFAOHPOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private KeepsakeGlobalConfigDTO LKLDHJBGGDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private HashSet<long> CLPDNLDMEAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private HashSet<long> FGKPGGDMHBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private List<KeepsakeRoomListDTO> OFOMMBIJDAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private List<KeepsakeRoomListDTO> LOKNKACJEHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private List<KeepsakeRoomListDTO> JOMFFHELIHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private Dictionary<long, string> IDFAEBKODIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private Dictionary<long, string> PPGAFKKBJHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private Dictionary<long, DateTime> NMGBLHLMJDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private Dictionary<long, List<KeepsakeRoomDTO>> GGIOMAGGJDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private Dictionary<long, List<KeepsakeRoomDTO>> LMEPGBFCDBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private Dictionary<long, long> HCICDJHMGNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly List<string> KJCPELLKEPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private DateTime AAFKJFJDMNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly IDisposable ODKDBPDPIDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private Dictionary<Guid, DCGPHHIICLO> IIKPHLALMNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private Dictionary<DCGPHHIICLO, int> OPIBEOFKIJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private List<KeepsakeCategoryThemePair> LMDKNFMFGJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private LMNGJHAPJCM KCGGFEGPNAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private bool AFINIJNLFIO;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool NDLDEDGDBDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA1E2D0", Offset = "0xA1D4D0", VA = "0x180A1E2D0", Slot = "53")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA1E050", Offset = "0xA1D250", VA = "0x180A1E050")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool MBCNPCDAJLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7CDBE90", Offset = "0x7CDB090", VA = "0x187CDBE90", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool NGNAEPJHFCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7CDF3B0", Offset = "0x7CDE5B0", VA = "0x187CDF3B0", Slot = "36")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private long IKEFBFDDAOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7CD9220", Offset = "0x7CD8420", VA = "0x187CD9220")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private long? ELKDDEKLIPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7CE3F00", Offset = "0x7CE3100", VA = "0x187CE3F00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private bool PDJFJNINPEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7CE1420", Offset = "0x7CE0620", VA = "0x187CE1420")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public IReadOnlyList<KeepsakeRoomListDTO> PGJGGBMMIHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xABB770", Offset = "0xABA970", VA = "0x180ABB770", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public IReadOnlyList<KeepsakeRoomListDTO> MBNCEBONOFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xABC0A0", Offset = "0xABB2A0", VA = "0x180ABC0A0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IReadOnlyList<KeepsakeRoomListDTO> AJMAKCABHMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xAC8220", Offset = "0xAC7420", VA = "0x180AC8220", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public IReadOnlyDictionary<long, string> PKPPPLLGBJK
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xABC8C0", Offset = "0xABBAC0", VA = "0x180ABC8C0", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	internal bool MJDGJLGOHEF
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xB90640", Offset = "0xB8F840", VA = "0x180B90640")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Guid?> JLDOEDHHOMK
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7CE2B10", Offset = "0x7CE1D10", VA = "0x187CE2B10", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7CDC050", Offset = "0x7CDB250", VA = "0x187CDC050", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action COBDPNIPFHD
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7CDC450", Offset = "0x7CDB650", VA = "0x187CDC450", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7CE1430", Offset = "0x7CE0630", VA = "0x187CE1430", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action DKGJLJFBJDL
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7CDE660", Offset = "0x7CDD860", VA = "0x187CDE660", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7CE4F90", Offset = "0x7CE4190", VA = "0x187CE4F90", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7CE5030", Offset = "0x7CE4230", VA = "0x187CE5030")]
	[RecRoom.NoEngine.Common.Preserve]
	internal COBHJCONPGA([ALHAHLCGLLK(null)][NotNull] MLCELPLGHKN LAPNHAHNKLK, [NotNull][ALHAHLCGLLK(null)] PPGJNHFCBMP BLKDEMHMLNB, [NotNull][ALHAHLCGLLK(null)] AHKNKJFPJIE KFOPANHGDFL, [NotNull][ALHAHLCGLLK(null)] ABAOLACCHHL GLLBKLDJIOH, [ALHAHLCGLLK(null)][NotNull] PMODAIEAAOP FKDMJOECDHA, [ALHAHLCGLLK(null)][NotNull] KBPOKGNGKKF LLMBGPNPABD, [ALHAHLCGLLK(null)][NotNull] PLIGANGDPHD DLLAGJGMJFP, [NotNull][ALHAHLCGLLK(null)] EHKLKJJGGDO FKBGIHJJFDH, [NotNull][ALHAHLCGLLK(null)] LKDJDKEKNAC GCMEJOEAFHA, [NotNull][ALHAHLCGLLK(null)] HODIDAPFOLL MGHPIBAKLGF, [NotNull][ALHAHLCGLLK(null)] GOGDPAFONHA DCNJHEFHBIC, [NotNull][ALHAHLCGLLK(null)] GDINEDNDDOD AEGDAOMLJMG, [NotNull][ALHAHLCGLLK(null)] OLALNMLGOHH AAEENKJEJHB, [NotNull][ALHAHLCGLLK(null)] OPOKCJLOHBC BPBACNMDAIP, [ALHAHLCGLLK(null)][NotNull] GLLIIHCJKOA GGCLFNKAIGH, [ALHAHLCGLLK(null)][NotNull] JIDDDLABHMA JBFEHBPNHBN, [NotNull][ALHAHLCGLLK(null)] DECADMNPJIG ICPFLHOEKBN, [ALHAHLCGLLK(null)][NotNull] EPIFIECCMDK<KeepsakesConfig.KeepsakesOptions> KDLGPMFPDII, [NotNull][ALHAHLCGLLK(null)] HJGCGGODOAD MIFPNJKPFOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7CE4490", Offset = "0x7CE3690", VA = "0x187CE4490", Slot = "15")]
	public bool PFJJBANDBPD(List<string> OHLCNOGNCDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7CDDD70", Offset = "0x7CDCF70", VA = "0x187CDDD70", Slot = "16")]
	public CMEBMOPMCFP<Guid> GFLECDHDAOB(DCGPHHIICLO IJHPGCNFKNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7CE31C0", Offset = "0x7CE23C0", VA = "0x187CE31C0", Slot = "17")]
	public IJPNCIBDOFL NBIGACDANME(Guid NKDDAALENNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7CE2330", Offset = "0x7CE1530", VA = "0x187CE2330", Slot = "18")]
	public IJPNCIBDOFL LHFFBBKNFHP(Guid NKDDAALENNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7CE14D0", Offset = "0x7CE06D0", VA = "0x187CE14D0", Slot = "19")]
	public bool KFABHDKDLEL(Guid NKDDAALENNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7CD9980", Offset = "0x7CD8B80", VA = "0x187CD9980", Slot = "20")]
	public bool BGPJKIIONMF(Guid NKDDAALENNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7CE12E0", Offset = "0x7CE04E0", VA = "0x187CE12E0")]
	public KeepsakeTheme KBKFPKAIOLN(Guid NKDDAALENNJ)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7CE42B0", Offset = "0x7CE34B0", VA = "0x187CE42B0")]
	public bool PCBGLEBOHCE(DCGPHHIICLO IJHPGCNFKNG, [Out] KeepsakeTheme HOBFICNNKNF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7CE2760", Offset = "0x7CE1960", VA = "0x187CE2760")]
	public List<KeepsakeTheme> LPMHHCBGPPA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7CE36A0", Offset = "0x7CE28A0", VA = "0x187CE36A0")]
	public int ODAPLNPHAPA(DCGPHHIICLO IJHPGCNFKNG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7CE21D0", Offset = "0x7CE13D0", VA = "0x187CE21D0")]
	public DCGPHHIICLO LHEGLNOJCPE(Guid NKDDAALENNJ)
	{
		return default(DCGPHHIICLO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7CE0460", Offset = "0x7CDF660", VA = "0x187CE0460", Slot = "34")]
	public List<DCGPHHIICLO> IJMFBLIICJA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7CE09E0", Offset = "0x7CDFBE0", VA = "0x187CE09E0", Slot = "35")]
	public IComparer<DCGPHHIICLO> JIFBFGOEBKA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7CDA0B0", Offset = "0x7CD92B0", VA = "0x187CDA0B0", Slot = "32")]
	public string CBELDBPIFPE(DCGPHHIICLO IJHPGCNFKNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7CDF180", Offset = "0x7CDE380", VA = "0x187CDF180", Slot = "33")]
	public string HHEIAOFGFLA(DCGPHHIICLO IJHPGCNFKNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7CDE8D0", Offset = "0x7CDDAD0", VA = "0x187CDE8D0", Slot = "21")]
	public bool GPNGHFNKCMA(Guid NKDDAALENNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7CD8750", Offset = "0x7CD7950", VA = "0x187CD8750", Slot = "22")]
	public void ACJKEELCIFE(Guid NKDDAALENNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7CE2C90", Offset = "0x7CE1E90", VA = "0x187CE2C90", Slot = "23")]
	public void MGHAGOPHFOF(DCGPHHIICLO IJHPGCNFKNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7CE3CC0", Offset = "0x7CE2EC0", VA = "0x187CE3CC0", Slot = "24")]
	public void OIANIECEFIM(Guid NKDDAALENNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7CDAF20", Offset = "0x7CDA120", VA = "0x187CDAF20", Slot = "25")]
	public int DAJOCMFCIGG()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7CDA730", Offset = "0x7CD9930", VA = "0x187CDA730", Slot = "31")]
	public CMEBMOPMCFP<IEnumerable<Guid>> CNBGLKHAPGO(long BENLNHBBIME, long MJOKCDGEBGK, DCGPHHIICLO? IJHPGCNFKNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7CE4C20", Offset = "0x7CE3E20", VA = "0x187CE4C20", Slot = "30")]
	public CMEBMOPMCFP<IEnumerable<Guid>> PLODNGOEAPO(long BENLNHBBIME, long MJOKCDGEBGK, DCGPHHIICLO? IJHPGCNFKNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7CDFE00", Offset = "0x7CDF000", VA = "0x187CDFE00", Slot = "54")]
	public CMEBMOPMCFP<Dictionary<Guid, DCGPHHIICLO>> IGDJPJFNDOP(long BENLNHBBIME, long MJOKCDGEBGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7CDEEB0", Offset = "0x7CDE0B0", VA = "0x187CDEEB0", Slot = "55")]
	public CMEBMOPMCFP<Dictionary<Guid, DCGPHHIICLO>> HDBBMILAMBD(long BENLNHBBIME, long MJOKCDGEBGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7CDAC80", Offset = "0x7CD9E80", VA = "0x187CDAC80", Slot = "26")]
	public CMEBMOPMCFP<int> DACJIIBNBGA(long BENLNHBBIME, long MJOKCDGEBGK, DCGPHHIICLO? IJHPGCNFKNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7CE4AD0", Offset = "0x7CE3CD0", VA = "0x187CE4AD0", Slot = "27")]
	public CMEBMOPMCFP<int> PKOFBLJGHKA(long BENLNHBBIME, long MJOKCDGEBGK, DCGPHHIICLO? IJHPGCNFKNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7CDB340", Offset = "0x7CDA540", VA = "0x187CDB340", Slot = "28")]
	public CMEBMOPMCFP<Dictionary<DCGPHHIICLO, int>> DMLDFCMMMDH(long BENLNHBBIME, long MJOKCDGEBGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7CDBDD0", Offset = "0x7CDAFD0", VA = "0x187CDBDD0", Slot = "29")]
	public CMEBMOPMCFP<Dictionary<DCGPHHIICLO, int>> EBBFAOHDLFK(long BENLNHBBIME, long MJOKCDGEBGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7CDA050", Offset = "0x7CD9250", VA = "0x187CDA050", Slot = "37")]
	public bool BKGGEJLFMII(long BENLNHBBIME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7CDE380", Offset = "0x7CDD580", VA = "0x187CDE380", Slot = "56")]
	public bool GGIGMOKEFLP(long BENLNHBBIME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7CE03C0", Offset = "0x7CDF5C0", VA = "0x187CE03C0", Slot = "38")]
	public bool IJKDLNBEIEG(long BENLNHBBIME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7CE4720", Offset = "0x7CE3920", VA = "0x187CE4720", Slot = "57")]
	public bool PIJLLJAJLKF(long BENLNHBBIME, [Out] EFMPFIJMHCH DOCPKNNLCIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7CDF040", Offset = "0x7CDE240", VA = "0x187CDF040", Slot = "39")]
	public bool HFLKDMFJKAM(long BFFBAHBIELJ, [Out] DateTime BAJIGMPOFPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7CD87C0", Offset = "0x7CD79C0", VA = "0x187CD87C0", Slot = "40")]
	public long ADGNAEOLKGL(long BFFBAHBIELJ)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7CE16E0", Offset = "0x7CE08E0", VA = "0x187CE16E0", Slot = "41")]
	public long KGOJFEDJPND(long BENLNHBBIME)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7CDC270", Offset = "0x7CDB470", VA = "0x187CDC270", Slot = "42")]
	public int FDIMCHJHOED(long BFFBAHBIELJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7CDEB60", Offset = "0x7CDDD60", VA = "0x187CDEB60", Slot = "43")]
	public bool HBFIBHLJPIB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x7CDE4D0", Offset = "0x7CDD6D0", VA = "0x187CDE4D0", Slot = "44")]
	public bool GIBOFFNHFNH(long BFFBAHBIELJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7CDEC40", Offset = "0x7CDDE40", VA = "0x187CDEC40", Slot = "45")]
	public IReadOnlyList<long> HCHCBDNGBIN(long BFFBAHBIELJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7CDF300", Offset = "0x7CDE500", VA = "0x187CDF300", Slot = "46")]
	public int HKPEPNKLLDC(long BFFBAHBIELJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7CE2CE0", Offset = "0x7CE1EE0", VA = "0x187CE2CE0", Slot = "50")]
	public long MJMMDBAGLMJ(long NKGIGJKDCJE)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7CD92F0", Offset = "0x7CD84F0", VA = "0x187CD92F0", Slot = "51")]
	public DCGPHHIICLO AOLAEMAOFHP()
	{
		return default(DCGPHHIICLO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7CE17F0", Offset = "0x7CE09F0", VA = "0x187CE17F0")]
	private bool KICPDKOKGJD(Guid NKDDAALENNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7CE1D10", Offset = "0x7CE0F10", VA = "0x187CE1D10")]
	private void LGIPLGLBODN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7CDC660", Offset = "0x7CDB860", VA = "0x187CDC660")]
	private DCGPHHIICLO FLIFDEHKBFB()
	{
		return default(DCGPHHIICLO);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7CE0AA0", Offset = "0x7CDFCA0", VA = "0x187CE0AA0")]
	private void JLOGCPMOOJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7CE3440", Offset = "0x7CE2640", VA = "0x187CE3440")]
	private int NCLNGBLJPLC(KeepsakeRoomListDTO FFNLPIMDCIL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7CE3820", Offset = "0x7CE2A20", VA = "0x187CE3820")]
	private int ODLCCJDBFPN(DateTime HGECPMFCLIF, DateTime IKGNOKPPMJP, TimeSpan DLFAPNCCBEK, int ECMDLHPAMMO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7CDA230", Offset = "0x7CD9430", VA = "0x187CDA230")]
	private void CCAFJEEEBOO(IEnumerable<KeepsakeInstanceDTO> NFCPOCPCPOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7CDC930", Offset = "0x7CDBB30", VA = "0x187CDC930")]
	private void FLNIMABECMG(IEnumerable<KeepsakeCollectionRecordDTO> OEOBPOIMKML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7CE3640", Offset = "0x7CE2840", VA = "0x187CE3640")]
	private void NIDHKPJMIDM(IEnumerable<long> IBLFKKEOEOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0xA6B140", Offset = "0xA6A340", VA = "0x180A6B140")]
	private void CPAJKIENODH(KeepsakeGlobalConfigDTO LKLDHJBGGDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7CDF470", Offset = "0x7CDE670", VA = "0x187CDF470")]
	private bool IBMFFBDPFDL(DCGPHHIICLO IJHPGCNFKNG, [Out] Guid OLFIKLGPBJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7CDE700", Offset = "0x7CDD900", VA = "0x187CDE700")]
	private bool GNNEGGDCBLI([Out] Guid OLFIKLGPBJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7CE35E0", Offset = "0x7CE27E0", VA = "0x187CE35E0")]
	private bool NEFKNDIOEKN(Guid NKDDAALENNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x7CDC120", Offset = "0x7CDB320", VA = "0x187CDC120")]
	private IEnumerable<Guid> EOCHFLJCPLG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7CDFB80", Offset = "0x7CDED80", VA = "0x187CDFB80")]
	private IEnumerable<KeepsakeInstanceDTO> ICKBPDGFPCD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7CE3130", Offset = "0x7CE2330", VA = "0x187CE3130")]
	private void NBICMCBNEMM(Guid NKDDAALENNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7CE1630", Offset = "0x7CE0830", VA = "0x187CE1630")]
	private bool KGFPPJLNKKD(Guid NKDDAALENNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7CDAAE0", Offset = "0x7CD9CE0", VA = "0x187CDAAE0")]
	private void CPOHLHELNIC(Guid NKDDAALENNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7CD9F70", Offset = "0x7CD9170", VA = "0x187CD9F70")]
	private void BIGHGEJABAC(DCGPHHIICLO BHDEGBMLBGB, int OKNPPFNDGKD, Dictionary<DCGPHHIICLO, int> LMBDBABNLEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7CDE3E0", Offset = "0x7CDD5E0", VA = "0x187CDE3E0")]
	private int GHEIGFBDACG(DCGPHHIICLO IJHPGCNFKNG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7CE4DC0", Offset = "0x7CE3FC0", VA = "0x187CE4DC0")]
	private void PMBFMFNJCBL(KeepsakeInstanceDTO LDGGKDGIGPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7CE01B0", Offset = "0x7CDF3B0", VA = "0x187CE01B0")]
	private void IJJHHEJHMFN(KeepsakeInstanceDTO LDGGKDGIGPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7CDF7B0", Offset = "0x7CDE9B0", VA = "0x187CDF7B0")]
	private void ICEGICLLOCG(Guid NKDDAALENNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7CE10E0", Offset = "0x7CE02E0", VA = "0x187CE10E0")]
	private void JOEIHBCENDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7CE2740", Offset = "0x7CE1940", VA = "0x187CE2740")]
	private void LNFOJHJDEAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7CDC5F0", Offset = "0x7CDB7F0", VA = "0x187CDC5F0")]
	private void FIBAAIGJLKK(DBJKOHCNHMF JFHHMNEAJLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7CE10E0", Offset = "0x7CE02E0", VA = "0x187CE10E0")]
	private void NFMPOAHJMDD(MBFNHHPFPBC DBCLNEGBNLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7CE10E0", Offset = "0x7CE02E0", VA = "0x187CE10E0")]
	private void NOHJJJIKLAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7CE3920", Offset = "0x7CE2B20", VA = "0x187CE3920")]
	private void OFJFMKDJPKN(float BCCEKGNMJIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x7CD99D0", Offset = "0x7CD8BD0", VA = "0x187CD99D0")]
	private void BIBOBLHIOLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7CD9650", Offset = "0x7CD8850", VA = "0x187CD9650")]
	private bool APCLLIDGAAP(Guid NKDDAALENNJ, [Out] string LJBMEBAPEKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7CE1110", Offset = "0x7CE0310", VA = "0x187CE1110")]
	private bool JPMPFCIGNHF(Guid NKDDAALENNJ, [Out] KeepsakeCategoryConfigDTO BHDEGBMLBGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7CDF6D0", Offset = "0x7CDE8D0", VA = "0x187CDF6D0")]
	private void ICBALHFDHMB(string PGAPAABCDDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7CDA510", Offset = "0x7CD9710", VA = "0x187CDA510")]
	private bool CFBEMLHEGCJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7CE3F90", Offset = "0x7CE3190", VA = "0x187CE3F90")]
	private List<long> OPFAEHFBHBA(IEnumerable<KeepsakeRoomDTO> HAHFFIGFHFL, IReadOnlyList<KeepsakeRoomListDTO> OBEPHOGEFHE, long BFFBAHBIELJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x7CD8D00", Offset = "0x7CD7F00", VA = "0x187CD8D00")]
	private bool ADIFAMNEIIF(Guid NKDDAALENNJ, [Out] string KOIHEPAFBFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7CE4250", Offset = "0x7CE3450", VA = "0x187CE4250", Slot = "47")]
	public string OPNFOEKBABL(OOCPOMAANEJ CFKDCHDLMLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x7CDB9B0", Offset = "0x7CDABB0", VA = "0x187CDB9B0", Slot = "49")]
	public string EANLAOELLLL(OOCPOMAANEJ CFKDCHDLMLH, long BENLNHBBIME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7CE2BC0", Offset = "0x7CE1DC0", VA = "0x187CE2BC0", Slot = "48")]
	public string MEDLNECCBIF(OOCPOMAANEJ CFKDCHDLMLH, int LPDODPMOMAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x7CDCCE0", Offset = "0x7CDBEE0", VA = "0x187CDCCE0")]
	private void FOBHNDKPJMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7CE2FA0", Offset = "0x7CE21A0", VA = "0x187CE2FA0")]
	private void MPBGOJACGFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x7CE1CF0", Offset = "0x7CE0EF0", VA = "0x187CE1CF0")]
	private OOCPOMAANEJ LACMFLCEFKK(HBBBDCHLDGB AIPOCEKPDEC)
	{
		return default(OOCPOMAANEJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x7CD99B0", Offset = "0x7CD8BB0", VA = "0x187CD99B0")]
	private OOCPOMAANEJ BHAPMAACJEE(HBBBDCHLDGB AIPOCEKPDEC)
	{
		return default(OOCPOMAANEJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7CE05A0", Offset = "0x7CDF7A0", VA = "0x187CE05A0")]
	internal static string INEPOLJFKJN(OIMDOANKMPG FFKACEKODPA, string KIIAPGFDDBO, bool LHHHLFDNFGG, int FNNJAIMCFLM, int AOPANFNBHLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7CDB550", Offset = "0x7CDA750", VA = "0x187CDB550", Slot = "52")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x7CE26C0", Offset = "0x7CE18C0", VA = "0x187CE26C0")]
	private BAKFNEOFNEC LJOKEAFPGNC(KPDBONCIMNC MLPHHMINIJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7CDDBB0", Offset = "0x7CDCDB0", VA = "0x187CDDBB0")]
	private ICLKLOMOCNH GAJCIBBFOGP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7CE1920", Offset = "0x7CE0B20", VA = "0x187CE1920")]
	private Task KPOBJMGCHEF(FIEDEFBCGNM EFGHMCKPMHN, CancellationToken HCELDNOKOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7CDA620", Offset = "0x7CD9820", VA = "0x187CDA620")]
	[AsyncStateMachine(typeof(MMBIIJBBHGO))]
	private Task CGEIBKGEKGA(FIEDEFBCGNM EFGHMCKPMHN, CancellationToken HCELDNOKOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7CE0910", Offset = "0x7CDFB10", VA = "0x187CE0910")]
	private Task JBIEBALOEGJ(FIEDEFBCGNM EFGHMCKPMHN, CancellationToken HCELDNOKOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7CDE7A0", Offset = "0x7CDD9A0", VA = "0x187CDE7A0")]
	[AsyncStateMachine(typeof(GMEFLIJBFDI))]
	private Task GPHLKNABJNN(string BDAAPBJEHGD, TimeSpan IDMEKEAALMJ, CancellationToken HCELDNOKOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7CE1CD0", Offset = "0x7CE0ED0", VA = "0x187CE1CD0")]
	[CompilerGenerated]
	private void KPOLMCJBJEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7CD8700", Offset = "0x7CD7900", VA = "0x187CD8700")]
	[CompilerGenerated]
	private void ABFGKCEAIHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7CDC4F0", Offset = "0x7CDB6F0", VA = "0x187CDC4F0")]
	[CompilerGenerated]
	private bool FGOACLLOAIC(KeepsakeInstanceDTO CCOLDGJALNH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7CDBEE0", Offset = "0x7CDB0E0", VA = "0x187CDBEE0")]
	[CompilerGenerated]
	private CMEBMOPMCFP<Dictionary<DCGPHHIICLO, int>> EHNMLOAJDJN(Dictionary<Guid, DCGPHHIICLO> DMFANOABCPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x7CDCB70", Offset = "0x7CDBD70", VA = "0x187CDCB70")]
	[CompilerGenerated]
	private CMEBMOPMCFP<Dictionary<DCGPHHIICLO, int>> FNCODABIGDM(Dictionary<Guid, DCGPHHIICLO> DMFANOABCPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7CDC100", Offset = "0x7CDB300", VA = "0x187CDC100")]
	[CompilerGenerated]
	private bool EKKPOADIONH(KeepsakeRoomListDTO CCOLDGJALNH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7CD9850", Offset = "0x7CD8A50", VA = "0x187CD9850")]
	[CompilerGenerated]
	private bool BFNJNFBKNGL(KeepsakeInstanceDTO CCOLDGJALNH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7CE0780", Offset = "0x7CDF980", VA = "0x187CE0780")]
	[CompilerGenerated]
	private void JAGIFDNGFGG(Tuple<KeepsakeRoomInstancesDTO, IReadOnlyDictionary<DCGPHHIICLO, KeepsakeCategoryConfigDTO>, KeepsakeGlobalConfigDTO> HEBIEBIPLCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7CDA4B0", Offset = "0x7CD96B0", VA = "0x187CDA4B0")]
	[CompilerGenerated]
	private void CEIBAEBFBCH(string KOIHEPAFBFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x7CDFC40", Offset = "0x7CDEE40", VA = "0x187CDFC40")]
	[CompilerGenerated]
	private Task IENPOICGLPJ(CancellationToken MPIOHOPBGEC)
	{
		return null;
	}
}
namespace RecRoom.Keepsakes
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public class KeepsakesConfig : ScriptableObject, EPIFIECCMDK<KeepsakesConfig.KeepsakesOptions>
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200002B")]
		public class KeepsakesOptions
		{
			[Cpp2IlInjected.Token(Token = "0x200002C")]
			[CompilerGenerated]
			private sealed class FLMKDJKIKJJ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000098")]
				public string themeId;

				[Cpp2IlInjected.Token(Token = "0x60000F3")]
				[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
				public FLMKDJKIKJJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000F4")]
				[Cpp2IlInjected.Address(RVA = "0x7CE6960", Offset = "0x7CE5B60", VA = "0x187CE6960")]
				internal bool DFPOFLCFMPP(KeepsakeTheme x)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60000F5")]
				[Cpp2IlInjected.Address(RVA = "0x7CE6960", Offset = "0x7CE5B60", VA = "0x187CE6960")]
				internal bool KBKEJJJGHNM(KeepsakeTheme x)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			[SerializeField]
			private KeepsakeTheme[] themes;

			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x7CE7E20", Offset = "0x7CE7020", VA = "0x187CE7E20")]
			public bool HAAOBMFDHEE(string LNOADGDMCIN, [Out] KeepsakeTheme HOBFICNNKNF)
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
			[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x7CE7DA0", Offset = "0x7CE6FA0", VA = "0x187CE7DA0")]
		[DBIDCJGLKKO.BICJMLCNMCI.FCGHBDOAPKJ]
		internal static void OIIIADNPFIO(HILJAABEPDC NPCDKJJJIDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0xBC3030", Offset = "0xBC2230", VA = "0x180BC3030")]
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
